Imports System.IO
Imports System.Linq
Imports System.Net
Imports System.Net.Mail
Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions

' View-model used only by the attendance screens (your Attendance class has no student name)
Public Class AttendanceRow
    Public Property StudentID As String
    Public Property StudentName As String
    Public Property AttendanceStatus As String      ' "Present" / "Absent" / "Late"
End Class

Public Interface IMemberRepository
    Function GetAll() As List(Of Member)
    Function Search(keyword As String) As List(Of Member)
    Function GetById(studentId As String) As Member
    Function Exists(studentId As String) As Boolean
    Sub Add(m As Member)
    Sub Update(m As Member)
    Sub Delete(studentId As String)
    Function CountAll() As Integer
End Interface

Public Interface IMembershipRepository
    Sub Save(ms As Membership)                    ' insert or update, matched by StudentID
    Sub DeleteByStudent(studentId As String)
End Interface

Public Interface IActivityRepository
    Function GetAll() As List(Of Activity)
    Function Search(keyword As String) As List(Of Activity)
    Function GetById(activityId As Integer) As Activity
    Function GetUpcoming() As List(Of Activity)
    Function GetByDateRange(fromDate As Date, toDate As Date) As List(Of Activity)
    Sub Add(a As Activity)
    Sub Update(a As Activity)
    Sub Delete(activityId As Integer)
    Function CountAll() As Integer
End Interface

Public Interface IAttendanceRepository
    ' Return EVERY member (LEFT JOIN); members with no saved record come back as "Absent".
    Function GetForActivity(activityId As Integer) As List(Of AttendanceRow)
    ' Insert or update one row per (ActivityID, StudentID).
    Sub Save(records As List(Of Attendance))
End Interface

Public Interface IParticipationRepository
    ' TotalAttended = count of Present or Late rows per member.
    Function GetAll() As List(Of Participation)
End Interface

Public Interface ILookupRepository
    Function GetCourses() As List(Of Course)
    Function GetYearLevels() As List(Of YearLevel)
    Function GetPositions() As List(Of Position)
End Interface

Public Interface IUserRepository
    ' passwordHash is already hashed with Auth.Hash(...)
    Function Validate(username As String, passwordHash As String) As User
    Function GetByEmail(email As String) As User
    Function UsernameTaken(username As String, exceptUserId As Integer) As Boolean
    Sub UpdateProfile(u As User)
    Sub UpdatePassword(userId As Integer, passwordHash As String)
End Interface

Public Module Services
    Public MemberRepo As IMemberRepository
    Public MembershipRepo As IMembershipRepository
    Public ActivityRepo As IActivityRepository
    Public AttendanceRepo As IAttendanceRepository
    Public ParticipationRepo As IParticipationRepository
    Public LookupRepo As ILookupRepository
    Public UserRepo As IUserRepository
End Module

Public Module Session
    Public CurrentUser As User
    Public Sub Clear()
        CurrentUser = Nothing
    End Sub
End Module

Public Module Lookups
    Public ReadOnly MemberStatuses As String() = {"Active", "Inactive"}
    Public ReadOnly AttendanceStatuses As String() = {"Present", "Absent", "Late"}

    ' Activity has no Status field in your model, so it is worked out from the date.
    Public Function ActivityStatusOf(d As Date) As String
        If d.Date > Date.Today Then Return "Upcoming"
        If d.Date = Date.Today Then Return "Today"
        Return "Completed"
    End Function
End Module

Public Module Auth
    Public Function Hash(plain As String) As String
        Using sha As SHA256 = SHA256.Create()
            Dim bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(If(plain, "")))
            Return String.Concat(bytes.Select(Function(b) b.ToString("x2")))
        End Using
    End Function

    Public Function NewCode() As String
        Dim buf(3) As Byte
        Using rng As RandomNumberGenerator = RandomNumberGenerator.Create()
            rng.GetBytes(buf)
        End Using
        Dim n As UInteger = BitConverter.ToUInt32(buf, 0)
        Return (CInt(n Mod 900000UI) + 100000).ToString()
    End Function

    Public Function IsValidEmail(email As String) As Boolean
        Return Regex.IsMatch(If(email, ""), "^[^@\s]+@[^@\s]+\.[^@\s]+$")
    End Function
End Module

Public Module Mailer
    ' Fill these in (Gmail needs an "App Password", not your normal password).
    Private Const SmtpHost As String = "smtp.gmail.com"
    Private Const SmtpPort As Integer = 587
    Private Const SmtpUser As String = "your-system-email@gmail.com"
    Private Const SmtpPass As String = "your-app-password"

    Public Sub SendCode(toEmail As String, code As String)
        Using msg As New MailMessage(SmtpUser, toEmail)
            msg.Subject = "SOMAMS - Password reset code"
            msg.Body = "Your SOMAMS verification code is: " & code & vbCrLf &
                       "It expires in 10 minutes. If you did not request this, ignore this email."
            Using smtp As New SmtpClient(SmtpHost, SmtpPort)
                smtp.EnableSsl = True
                smtp.Credentials = New NetworkCredential(SmtpUser, SmtpPass)
                smtp.Send(msg)
            End Using
        End Using
    End Sub
End Module

Public Module UI
    Private ReadOnly HintColor As Color = Color.Gray

    Public Sub Info(msg As String)
        MessageBox.Show(msg, "SOMAMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub Warn(msg As String)
        MessageBox.Show(msg, "SOMAMS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Public Function Ask(msg As String) As Boolean
        Return MessageBox.Show(msg, "SOMAMS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
    End Function

    ' Placeholder text for plain TextBoxes
    Public Sub SetPlaceholder(txt As TextBox, hint As String)
        txt.Tag = hint
        If txt.Text.Length = 0 OrElse txt.Text = hint Then
            txt.Text = hint
            txt.ForeColor = HintColor
        End If
        AddHandler txt.Enter, Sub(s, e)
                                  If txt.ForeColor = HintColor AndAlso txt.Text = hint Then
                                      txt.Text = ""
                                      txt.ForeColor = Color.Black
                                  End If
                              End Sub
        AddHandler txt.Leave, Sub(s, e)
                                  If txt.Text.Trim().Length = 0 Then
                                      txt.Text = hint
                                      txt.ForeColor = HintColor
                                  End If
                              End Sub
    End Sub

    ' Returns "" when the box only shows its placeholder.
    Public Function SearchText(txt As TextBox) As String
        Dim hint As String = TryCast(txt.Tag, String)
        If hint IsNot Nothing AndAlso txt.Text = hint AndAlso txt.ForeColor = HintColor Then Return ""
        Return txt.Text.Trim()
    End Function

    Public Sub StyleGrid(dgv As DataGridView)
        dgv.ReadOnly = True
        dgv.AllowUserToAddRows = False
        dgv.AllowUserToDeleteRows = False
        dgv.AllowUserToResizeRows = False
        dgv.MultiSelect = False
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv.EnableHeadersVisualStyles = False
        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.SkyBlue
        dgv.ColumnHeadersDefaultCellStyle.Font = New Font(dgv.Font, FontStyle.Bold)
        dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv.BackgroundColor = Color.White
    End Sub

    Public Function SelectedCell(dgv As DataGridView, columnName As String) As String
        If dgv.CurrentRow Is Nothing OrElse dgv.CurrentRow.IsNewRow Then Return Nothing
        Dim v = dgv.CurrentRow.Cells(columnName).Value
        Return If(v Is Nothing, Nothing, v.ToString())
    End Function

    Public Function MembersToTable(list As IEnumerable(Of Member)) As DataTable
        Dim dt As New DataTable()
        dt.Columns.Add("ID")
        dt.Columns.Add("Student Name")
        dt.Columns.Add("Course")
        dt.Columns.Add("Year Level")
        dt.Columns.Add("Position")
        dt.Columns.Add("Status")
        For Each m In list
            dt.Rows.Add(m.StudentID, m.StudentName, m.Course, m.YearLevel, m.Position, m.MembershipStatus)
        Next
        Return dt
    End Function

    Public Function ActivitiesToTable(list As IEnumerable(Of Activity)) As DataTable
        Dim dt As New DataTable()
        dt.Columns.Add("ActivityID", GetType(Integer))
        dt.Columns.Add("Activity")
        dt.Columns.Add("Date", GetType(Date))
        dt.Columns.Add("Location")
        dt.Columns.Add("Status")
        For Each a In list
            dt.Rows.Add(a.ActivityID, a.ActivityName, a.ActivityDate, a.Location, Lookups.ActivityStatusOf(a.ActivityDate))
        Next
        Return dt
    End Function

    Public Function ParticipationToTable(list As IEnumerable(Of Participation)) As DataTable
        Dim dt As New DataTable()
        dt.Columns.Add("ID")
        dt.Columns.Add("Student Name")
        dt.Columns.Add("Position")
        dt.Columns.Add("Total Attended", GetType(Integer))
        For Each p In list
            dt.Rows.Add(p.StudentID, p.StudentName, p.Position, p.TotalAttended)
        Next
        Return dt
    End Function

    Public Sub FillCombo(cbo As ComboBox, items As IEnumerable(Of String), Optional firstItem As String = Nothing)
        cbo.DropDownStyle = ComboBoxStyle.DropDownList
        cbo.Items.Clear()
        If firstItem IsNot Nothing Then cbo.Items.Add(firstItem)
        For Each i In items
            cbo.Items.Add(i)
        Next
        If cbo.Items.Count > 0 AndAlso firstItem IsNot Nothing Then cbo.SelectedIndex = 0 Else cbo.SelectedIndex = -1
    End Sub

    ' Small modal prompt built in code (supports masked input). Returns Nothing if cancelled.
    Public Function PromptText(title As String, prompt As String, Optional isPassword As Boolean = False) As String
        Using f As New Form()
            f.Text = title
            f.FormBorderStyle = FormBorderStyle.FixedDialog
            f.StartPosition = FormStartPosition.CenterParent
            f.MaximizeBox = False
            f.MinimizeBox = False
            f.ClientSize = New Size(340, 130)
            Dim lbl As New Label() With {.Text = prompt, .Left = 15, .Top = 15, .Width = 310, .Height = 35}
            Dim txt As New TextBox() With {.Left = 15, .Top = 55, .Width = 310, .UseSystemPasswordChar = isPassword}
            Dim ok As New Button() With {.Text = "OK", .Left = 165, .Top = 90, .Width = 75, .DialogResult = DialogResult.OK}
            Dim cancel As New Button() With {.Text = "Cancel", .Left = 250, .Top = 90, .Width = 75, .DialogResult = DialogResult.Cancel}
            f.Controls.AddRange(New Control() {lbl, txt, ok, cancel})
            f.AcceptButton = ok
            f.CancelButton = cancel
            If f.ShowDialog() = DialogResult.OK Then Return txt.Text
            Return Nothing
        End Using
    End Function

    Public Function LoadImageNoLock(path As String) As Image
        If String.IsNullOrEmpty(path) OrElse Not File.Exists(path) Then Return Nothing
        Using img As Image = Image.FromFile(path)
            Return New Bitmap(img)
        End Using
    End Function
End Module

Public Module Nav
    ' Set before opening Membership to edit an existing member (Nothing = add new).
    Public PendingMemberId As String = Nothing

    Private ReadOnly Pages As String() = {"Dashboard", "Members", "Activities", "Attendance", "Membership", "Participation", "Reports", "Settings"}

    Public Function FindControl(f As Form, name As String) As Control
        Return f.Controls.Find(name, True).FirstOrDefault()
    End Function

    ' Wires btnDashboard, btnMembers, ... btnSettings and btnLogout on any form.
    Public Sub WireSidebar(f As Form, active As String)
        For Each p In Pages
            Dim btn = TryCast(FindControl(f, "btn" & p), Button)
            If btn Is Nothing Then Continue For
            Dim target As String = p
            If p = active Then
                btn.BackColor = Color.Gold
                btn.ForeColor = Color.Black
            End If
            AddHandler btn.Click, Sub(s, e) NavigateTo(f, target)
        Next
        Dim lo = TryCast(FindControl(f, "btnLogout"), Button)
        If lo IsNot Nothing Then AddHandler lo.Click, Sub(s, e) Logout(f)
    End Sub

    ' Change the class names here if your forms are named differently
    Public Sub NavigateTo(current As Form, page As String)
        If current.Name = "frm" & page Then Return
        Dim nxt As Form = Nothing
        Select Case page
            Case "Dashboard" : nxt = New frmDashboard()
            Case "Members" : nxt = New frmMembers()
            Case "Activities" : nxt = New frmActivities()
            Case "Attendance" : nxt = New frmAttendance()
            Case "Membership" : nxt = New frmMembershipForm()
            Case "Participation" : nxt = New frmParticipation()
            Case "Reports" : nxt = New frmReports()
            Case "Settings" : nxt = New frmSettings()
        End Select
        If nxt Is Nothing Then Return
        nxt.StartPosition = FormStartPosition.Manual
        nxt.Location = current.Location
        nxt.Size = current.Size
        nxt.WindowState = current.WindowState
        nxt.Show()
        current.Close()
    End Sub

    Public Sub Logout(current As Form)
        Using dlg As New frmConfirmLogout()
            If dlg.ShowDialog(current) <> DialogResult.Yes Then Return
        End Using
        Session.Clear()
        Dim f As New frmLoggingOut()
        f.StartPosition = FormStartPosition.CenterScreen
        f.Show()
        current.Close()
    End Sub
End Module

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMembershipForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label5 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        txtStudentName = New TextBox()
        txtMembershipId = New TextBox()
        Label4 = New Label()
        Label2 = New Label()
        cboStatus = New ComboBox()
        cboCourse = New ComboBox()
        dtpDateJoined = New DateTimePicker()
        GroupBox1 = New GroupBox()
        cboYearLevel = New ComboBox()
        Label1 = New Label()
        cboPosition = New ComboBox()
        Panel2 = New Panel()
        Label10 = New Label()
        btnCancel = New Button()
        btnSave = New Button()
        Label3 = New Label()
        Panel1 = New Panel()
        Label12 = New Label()
        PictureBox1 = New PictureBox()
        btnLogout = New Button()
        btnNavSettings = New Button()
        btnNavMembership = New Button()
        btnNavAttendance = New Button()
        btnNavActivities = New Button()
        btnNavMembers = New Button()
        btnNavDashboard = New Button()
        btnNavReports = New Button()
        GroupBox1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label5.Location = New Point(513, 83)
        Label5.Name = "Label5"
        Label5.Size = New Size(154, 28)
        Label5.TabIndex = 1
        Label5.Text = "Student Name: "
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label9.Location = New Point(104, 212)
        Label9.Name = "Label9"
        Label9.Size = New Size(86, 28)
        Label9.TabIndex = 5
        Label9.Text = "Course: "
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label8.Location = New Point(900, 212)
        Label8.Name = "Label8"
        Label8.Size = New Size(199, 28)
        Label8.TabIndex = 4
        Label8.Text = "Membership Status: "
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label7.Location = New Point(104, 324)
        Label7.Name = "Label7"
        Label7.Size = New Size(131, 28)
        Label7.TabIndex = 3
        Label7.Text = "Date Joined: "
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label6.Location = New Point(900, 83)
        Label6.Name = "Label6"
        Label6.Size = New Size(96, 28)
        Label6.TabIndex = 2
        Label6.Text = "Position: "
        ' 
        ' txtStudentName
        ' 
        txtStudentName.BorderStyle = BorderStyle.FixedSingle
        txtStudentName.Location = New Point(513, 121)
        txtStudentName.Multiline = True
        txtStudentName.Name = "txtStudentName"
        txtStudentName.Size = New Size(267, 33)
        txtStudentName.TabIndex = 7
        ' 
        ' txtMembershipId
        ' 
        txtMembershipId.BorderStyle = BorderStyle.FixedSingle
        txtMembershipId.Location = New Point(104, 121)
        txtMembershipId.Multiline = True
        txtMembershipId.Name = "txtMembershipId"
        txtMembershipId.Size = New Size(267, 33)
        txtMembershipId.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label4.Location = New Point(104, 83)
        Label4.Name = "Label4"
        Label4.Size = New Size(164, 28)
        Label4.TabIndex = 0
        Label4.Text = "Membership ID: "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(36, 31)
        Label2.Name = "Label2"
        Label2.Size = New Size(315, 28)
        Label2.TabIndex = 2
        Label2.Text = "Membership Management Form"
        ' 
        ' cboStatus
        ' 
        cboStatus.FormattingEnabled = True
        cboStatus.Location = New Point(900, 252)
        cboStatus.Name = "cboStatus"
        cboStatus.Size = New Size(267, 33)
        cboStatus.TabIndex = 11
        ' 
        ' cboCourse
        ' 
        cboCourse.DropDownStyle = ComboBoxStyle.DropDownList
        cboCourse.FormattingEnabled = True
        cboCourse.Location = New Point(104, 252)
        cboCourse.Name = "cboCourse"
        cboCourse.Size = New Size(267, 33)
        cboCourse.TabIndex = 10
        ' 
        ' dtpDateJoined
        ' 
        dtpDateJoined.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpDateJoined.Location = New Point(104, 362)
        dtpDateJoined.MaxDate = New Date(2026, 9, 14, 0, 0, 0, 0)
        dtpDateJoined.Name = "dtpDateJoined"
        dtpDateJoined.Size = New Size(267, 27)
        dtpDateJoined.TabIndex = 9
        dtpDateJoined.Value = New Date(2026, 9, 14, 0, 0, 0, 0)
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.White
        GroupBox1.Controls.Add(cboYearLevel)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(cboStatus)
        GroupBox1.Controls.Add(cboCourse)
        GroupBox1.Controls.Add(dtpDateJoined)
        GroupBox1.Controls.Add(cboPosition)
        GroupBox1.Controls.Add(txtStudentName)
        GroupBox1.Controls.Add(txtMembershipId)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(115, 179)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1301, 441)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "Membership Form"
        ' 
        ' cboYearLevel
        ' 
        cboYearLevel.FormattingEnabled = True
        cboYearLevel.Location = New Point(513, 252)
        cboYearLevel.Name = "cboYearLevel"
        cboYearLevel.Size = New Size(267, 33)
        cboYearLevel.TabIndex = 13
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label1.Location = New Point(513, 212)
        Label1.Name = "Label1"
        Label1.Size = New Size(114, 28)
        Label1.TabIndex = 12
        Label1.Text = "Year Level: "
        ' 
        ' cboPosition
        ' 
        cboPosition.DropDownStyle = ComboBoxStyle.DropDownList
        cboPosition.FormattingEnabled = True
        cboPosition.Location = New Point(900, 121)
        cboPosition.Name = "cboPosition"
        cboPosition.Size = New Size(267, 33)
        cboPosition.TabIndex = 8
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(btnCancel)
        Panel2.Controls.Add(btnSave)
        Panel2.Controls.Add(GroupBox1)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Dock = DockStyle.Right
        Panel2.Location = New Point(378, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1529, 1012)
        Panel2.TabIndex = 6
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = SystemColors.ControlDark
        Label10.Location = New Point(131, 821)
        Label10.Name = "Label10"
        Label10.Size = New Size(317, 138)
        Label10.TabIndex = 7
        Label10.Text = "Record a date student joined." & vbCrLf & vbCrLf & "Identify active and inactive members." & vbCrLf & vbCrLf & "Update membership status when needed." & vbCrLf & vbCrLf
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(1204, 648)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(94, 46)
        btnCancel.TabIndex = 6
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.Navy
        btnSave.FlatAppearance.BorderColor = Color.Navy
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.ForeColor = SystemColors.Control
        btnSave.Location = New Point(1322, 648)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(94, 46)
        btnSave.TabIndex = 5
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(115, 74)
        Label3.Name = "Label3"
        Label3.Size = New Size(321, 23)
        Label3.TabIndex = 3
        Label3.Text = "Monitor active and inactive membership."
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Navy
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(btnLogout)
        Panel1.Controls.Add(btnNavSettings)
        Panel1.Controls.Add(btnNavMembership)
        Panel1.Controls.Add(btnNavAttendance)
        Panel1.Controls.Add(btnNavActivities)
        Panel1.Controls.Add(btnNavMembers)
        Panel1.Controls.Add(btnNavDashboard)
        Panel1.Controls.Add(btnNavReports)
        Panel1.Dock = DockStyle.Left
        Panel1.ForeColor = SystemColors.Control
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.RightToLeft = RightToLeft.No
        Panel1.Size = New Size(378, 1012)
        Panel1.TabIndex = 7
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Arial Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(181, 92)
        Label12.Name = "Label12"
        Label12.Size = New Size(154, 40)
        Label12.TabIndex = 43
        Label12.Text = "SOMAMS"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.logo2
        PictureBox1.Location = New Point(39, 45)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(125, 125)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 42
        PictureBox1.TabStop = False
        ' 
        ' btnLogout
        ' 
        btnLogout.FlatAppearance.BorderColor = Color.Red
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.ForeColor = SystemColors.Control
        btnLogout.Location = New Point(17, 950)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(348, 50)
        btnLogout.TabIndex = 32
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' btnNavSettings
        ' 
        btnNavSettings.FlatStyle = FlatStyle.Flat
        btnNavSettings.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        btnNavSettings.ForeColor = SystemColors.Control
        btnNavSettings.ImageAlign = ContentAlignment.MiddleLeft
        btnNavSettings.Location = New Point(15, 570)
        btnNavSettings.Margin = New Padding(5)
        btnNavSettings.Name = "btnNavSettings"
        btnNavSettings.Size = New Size(349, 50)
        btnNavSettings.TabIndex = 28
        btnNavSettings.Text = "Settings"
        btnNavSettings.UseVisualStyleBackColor = True
        ' 
        ' btnNavMembership
        ' 
        btnNavMembership.BackColor = Color.Gold
        btnNavMembership.FlatStyle = FlatStyle.Flat
        btnNavMembership.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        btnNavMembership.ForeColor = Color.Black
        btnNavMembership.ImageAlign = ContentAlignment.MiddleLeft
        btnNavMembership.Location = New Point(15, 450)
        btnNavMembership.Margin = New Padding(5)
        btnNavMembership.Name = "btnNavMembership"
        btnNavMembership.Size = New Size(349, 50)
        btnNavMembership.TabIndex = 26
        btnNavMembership.Text = "Membership"
        btnNavMembership.UseVisualStyleBackColor = False
        ' 
        ' btnNavAttendance
        ' 
        btnNavAttendance.FlatStyle = FlatStyle.Flat
        btnNavAttendance.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        btnNavAttendance.ForeColor = SystemColors.Control
        btnNavAttendance.ImageAlign = ContentAlignment.MiddleLeft
        btnNavAttendance.Location = New Point(15, 390)
        btnNavAttendance.Margin = New Padding(5)
        btnNavAttendance.Name = "btnNavAttendance"
        btnNavAttendance.Size = New Size(350, 50)
        btnNavAttendance.TabIndex = 25
        btnNavAttendance.Text = "Attendance"
        btnNavAttendance.UseVisualStyleBackColor = True
        ' 
        ' btnNavActivities
        ' 
        btnNavActivities.FlatStyle = FlatStyle.Flat
        btnNavActivities.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        btnNavActivities.ForeColor = SystemColors.Control
        btnNavActivities.ImageAlign = ContentAlignment.MiddleLeft
        btnNavActivities.Location = New Point(15, 330)
        btnNavActivities.Margin = New Padding(5)
        btnNavActivities.Name = "btnNavActivities"
        btnNavActivities.Size = New Size(349, 50)
        btnNavActivities.TabIndex = 24
        btnNavActivities.Text = "Activities"
        btnNavActivities.UseVisualStyleBackColor = True
        ' 
        ' btnNavMembers
        ' 
        btnNavMembers.FlatStyle = FlatStyle.Flat
        btnNavMembers.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        btnNavMembers.ForeColor = SystemColors.Control
        btnNavMembers.ImageAlign = ContentAlignment.MiddleLeft
        btnNavMembers.Location = New Point(15, 270)
        btnNavMembers.Margin = New Padding(5)
        btnNavMembers.Name = "btnNavMembers"
        btnNavMembers.Size = New Size(349, 50)
        btnNavMembers.TabIndex = 23
        btnNavMembers.Text = "Members"
        btnNavMembers.UseVisualStyleBackColor = True
        ' 
        ' btnNavDashboard
        ' 
        btnNavDashboard.FlatStyle = FlatStyle.Flat
        btnNavDashboard.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        btnNavDashboard.ForeColor = SystemColors.Control
        btnNavDashboard.ImageAlign = ContentAlignment.MiddleLeft
        btnNavDashboard.Location = New Point(15, 210)
        btnNavDashboard.Margin = New Padding(5)
        btnNavDashboard.Name = "btnNavDashboard"
        btnNavDashboard.Size = New Size(349, 50)
        btnNavDashboard.TabIndex = 22
        btnNavDashboard.Text = "Dashboard"
        btnNavDashboard.UseVisualStyleBackColor = True
        ' 
        ' btnNavReports
        ' 
        btnNavReports.FlatStyle = FlatStyle.Flat
        btnNavReports.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        btnNavReports.ForeColor = SystemColors.Control
        btnNavReports.ImageAlign = ContentAlignment.MiddleLeft
        btnNavReports.Location = New Point(15, 510)
        btnNavReports.Margin = New Padding(5)
        btnNavReports.Name = "btnNavReports"
        btnNavReports.Size = New Size(349, 50)
        btnNavReports.TabIndex = 41
        btnNavReports.Text = "Reports"
        btnNavReports.UseVisualStyleBackColor = True
        ' 
        ' frmMembershipForm
        ' 
        AutoScaleDimensions = New SizeF(120F, 120F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoScroll = True
        ClientSize = New Size(1902, 1033)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Name = "frmMembershipForm"
        Text = "MembershipForm"
        WindowState = FormWindowState.Maximized
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtStudentName As TextBox
    Friend WithEvents txtMembershipId As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents cboCourse As ComboBox
    Friend WithEvents dtpDateJoined As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cboPosition As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnNavSettings As Button
    Friend WithEvents btnNavMembership As Button
    Friend WithEvents btnNavAttendance As Button
    Friend WithEvents btnNavActivities As Button
    Friend WithEvents btnNavMembers As Button
    Friend WithEvents btnNavDashboard As Button
    Friend WithEvents cboYearLevel As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnNavReports As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class

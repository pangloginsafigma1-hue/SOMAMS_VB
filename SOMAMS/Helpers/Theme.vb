''' <summary>
''' One place that controls how every SOMAMS form looks: colours, fonts, buttons, tables,
''' the left sidebar, window titles and the window icon.
''' Every form calls  Theme.Apply(Me)  as the first line of its Load event, so all pages stay consistent.
''' </summary>
Public Module Theme

    ' ---------- colour palette ----------
    Public ReadOnly Navy As Color = Color.Navy
    Public ReadOnly NavyHover As Color = Color.FromArgb(26, 26, 150)
    Public ReadOnly NavyPressed As Color = Color.FromArgb(48, 48, 175)
    Public ReadOnly PageBack As Color = Color.FromArgb(243, 245, 250)
    Public ReadOnly TextDark As Color = Color.FromArgb(33, 37, 41)
    Public ReadOnly AccentBlue As Color = Color.FromArgb(30, 64, 175)
    Public ReadOnly SuccessGreen As Color = Color.FromArgb(34, 139, 34)
    Public ReadOnly DangerRed As Color = Color.FromArgb(198, 40, 40)
    Public ReadOnly SoftBlue As Color = Color.FromArgb(235, 238, 252)

    Private ReadOnly GridLine As Color = Color.FromArgb(225, 229, 240)
    Private ReadOnly GridAlt As Color = Color.FromArgb(240, 244, 255)
    Private ReadOnly GridSelect As Color = Color.FromArgb(207, 224, 255)

    Private Const FontName As String = "Segoe UI"

    ' Shrinks a page that is bigger than the screen (small laptops / projectors). Set False to turn off.
    Private Const FitToScreenEnabled As Boolean = True

    Private ReadOnly Titles As New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase) From {
        {"frmLogin", "Login"},
        {"frmForgotPassword", "Forgot Password"},
        {"frmDashboard", "Dashboard"},
        {"frmMembers", "Members"},
        {"frmMembershipForm", "Membership"},
        {"frmActivities", "Activities"},
        {"frmAttendance", "Attendance"},
        {"frmReports", "Reports"},
        {"frmSettings", "Settings"},
        {"frmExportAllMembers", "Export Members"},
        {"frmExportFilter", "Export Members (Filtered)"},
        {"frmExportActivities", "Export Activities"},
        {"frmExportAttendance", "Export Attendance"},
        {"frmConfirmLogout", "Confirm Logout"},
        {"frmLoggingOut", "Logging Out"},
        {"frmLoggedOut", "Logged Out"}
    }

    Private _iconHandle As IntPtr = IntPtr.Zero

    ' =====================================================================================
    '  Entry point
    ' =====================================================================================
    Public Sub Apply(form As Form)
        Try
            SetupWindow(form)
            FitToScreen(form)
            StyleTree(form)

            Dim sidebar As Panel = FindSidebar(form)
            If sidebar IsNot Nothing Then
                form.BackColor = PageBack
                LayoutSidebar(sidebar)
            End If

            SetDefaultButtons(form)
        Catch ex As Exception
            ' Styling must never stop a form from opening.
            Debug.WriteLine("Theme.Apply: " & ex.Message)
        End Try
    End Sub

    ' =====================================================================================
    '  Window (title, icon, border)
    ' =====================================================================================
    Private Sub SetupWindow(form As Form)
        Dim title As String = Nothing
        If Titles.TryGetValue(form.Name, title) Then form.Text = "SOMAMS  -  " & title

        Dim ic As Icon = AppIcon()
        If ic IsNot Nothing Then form.Icon = ic

        If form.WindowState = FormWindowState.Minimized Then form.WindowState = FormWindowState.Maximized

        ' borderless pop-ups get a thin frame so they stand out from the page behind them
        If form.FormBorderStyle = FormBorderStyle.None Then
            AddHandler form.Paint, Sub(s, e)
                                       Dim c As Color = If(IsDark(form.BackColor), Color.Gold, Navy)
                                       Using pen As New Pen(c, 2)
                                           e.Graphics.DrawRectangle(pen, 1, 1, form.ClientSize.Width - 3, form.ClientSize.Height - 3)
                                       End Using
                                   End Sub
            AddHandler form.Resize, Sub(s, e) form.Invalidate()
        End If
    End Sub

    ''' <summary>The SOMAMS logo as a window icon (a fresh wrapper per form, so closing a form never affects the next one).</summary>
    Private Function AppIcon() As Icon
        Try
            If _iconHandle = IntPtr.Zero Then
                Using bmp As New Bitmap(My.Resources.Resources.logo2, New Size(64, 64))
                    _iconHandle = bmp.GetHicon()
                End Using
            End If
            Return Icon.FromHandle(_iconHandle)
        Catch
            Return Nothing
        End Try
    End Function

    Private Sub SetDefaultButtons(form As Form)
        Select Case form.Name
            Case "frmLogin"
                form.AcceptButton = FindButton(form, "btnLogin")
            Case "frmForgotPassword"
                form.AcceptButton = FindButton(form, "btnContinue")
                form.CancelButton = FindButton(form, "pbBack")
            Case "frmExportAllMembers", "frmExportFilter"
                form.AcceptButton = FindButton(form, "btnExport")
                form.CancelButton = FindButton(form, "btnCancel")
            Case "frmExportActivities", "frmExportAttendance"
                form.AcceptButton = FindButton(form, "btnExport")
                form.CancelButton = FindButton(form, "pbBack")
            Case "frmConfirmLogout"
                form.CancelButton = FindButton(form, "btnCancel")
            Case "frmLoggedOut"
                form.AcceptButton = FindButton(form, "btnGoToLogin")
        End Select
    End Sub

    ' =====================================================================================
    '  Fit the page to the screen
    ' =====================================================================================
    Private Sub FitToScreen(form As Form)
        If Not FitToScreenEnabled Then Return
        If form.FormBorderStyle = FormBorderStyle.None Then Return      ' small pop-ups never need it

        Dim wa As Rectangle = Screen.FromControl(form).WorkingArea
        Dim contentW As Integer = 0
        Dim contentH As Integer = 0
        For Each c As Control In form.Controls
            contentW = Math.Max(contentW, c.Right)
            contentH = Math.Max(contentH, c.Bottom)
        Next
        If contentW <= 0 OrElse contentH <= 0 Then Return

        Dim factor As Double = Math.Min(1.0, Math.Min((wa.Width - 20) / contentW, (wa.Height - 50) / contentH))
        If factor >= 0.97 Then Return
        factor = Math.Max(factor, 0.5)

        ' remember every control's current font first, so inherited fonts are not scaled twice
        Dim fonts As New List(Of KeyValuePair(Of Control, Font))
        CollectFonts(form, fonts)

        form.SuspendLayout()
        form.Scale(New SizeF(CSng(factor), CSng(factor)))
        For Each kv As KeyValuePair(Of Control, Font) In fonts
            kv.Key.Font = ScaledFont(kv.Value, CSng(factor))
            Dim g As DataGridView = TryCast(kv.Key, DataGridView)
            If g IsNot Nothing Then
                ScaleCellStyleFont(g.DefaultCellStyle, CSng(factor))
                ScaleCellStyleFont(g.ColumnHeadersDefaultCellStyle, CSng(factor))
                ScaleCellStyleFont(g.AlternatingRowsDefaultCellStyle, CSng(factor))
            End If
        Next
        form.ResumeLayout(True)
    End Sub

    Private Sub CollectFonts(parent As Control, list As List(Of KeyValuePair(Of Control, Font)))
        list.Add(New KeyValuePair(Of Control, Font)(parent, parent.Font))
        For Each c As Control In parent.Controls
            CollectFonts(c, list)
        Next
    End Sub

    Private Function ScaledFont(f As Font, factor As Single) As Font
        Return New Font(f.FontFamily, Math.Max(6.0F, f.Size * factor), f.Style, f.Unit)
    End Function

    Private Sub ScaleCellStyleFont(style As DataGridViewCellStyle, factor As Single)
        If style.Font IsNot Nothing Then style.Font = ScaledFont(style.Font, factor)
    End Sub

    ' =====================================================================================
    '  Styling every control
    ' =====================================================================================
    Private Sub StyleTree(parent As Control)
        For Each c As Control In parent.Controls
            StyleOne(c)
            If c.HasChildren Then StyleTree(c)
        Next
    End Sub

    Private Sub StyleOne(c As Control)
        UnifyFont(c)

        If TypeOf c Is Button Then
            StyleButton(CType(c, Button))
        ElseIf TypeOf c Is DataGridView Then
            StyleGridVisual(CType(c, DataGridView))
        ElseIf TypeOf c Is TextBox Then
            StyleTextBox(CType(c, TextBox))
        ElseIf TypeOf c Is ComboBox OrElse TypeOf c Is DateTimePicker Then
            c.BackColor = Color.White
            c.ForeColor = TextDark
        ElseIf TypeOf c Is LinkLabel Then
            StyleLink(CType(c, LinkLabel))
        ElseIf TypeOf c Is Panel Then
            If c.Dock = DockStyle.None AndAlso c.BackColor.ToArgb() = SystemColors.Control.ToArgb() Then
                c.BackColor = PageBack
            End If
        End If
    End Sub

    ''' <summary>One font family (Segoe UI) everywhere; sizes and bold/italic are kept.</summary>
    Private Sub UnifyFont(c As Control)
        Dim f As Font = c.Font
        If Not String.Equals(f.Name, FontName, StringComparison.OrdinalIgnoreCase) Then
            c.Font = New Font(FontName, f.Size, f.Style, f.Unit)
        End If
    End Sub

    Private Sub StyleTextBox(tb As TextBox)
        tb.BorderStyle = BorderStyle.FixedSingle
        tb.BackColor = Color.White
        If tb.ForeColor <> Color.Gray Then tb.ForeColor = TextDark

        ' pressing Enter in any "txtSearch" box clicks that form's Search button
        If tb.Name = "txtSearch" Then
            AddHandler tb.KeyDown, Sub(s, e)
                                       If e.KeyCode = Keys.Enter Then
                                           e.SuppressKeyPress = True
                                           Dim owner As Form = tb.FindForm()
                                           If owner IsNot Nothing Then
                                               Dim search As Button = FindButton(owner, "btnSearch")
                                               If search IsNot Nothing Then search.PerformClick()
                                           End If
                                       End If
                                   End Sub
        End If
    End Sub

    Private Sub StyleLink(l As LinkLabel)
        l.LinkBehavior = LinkBehavior.HoverUnderline
        l.Cursor = Cursors.Hand

        Dim owner As Form = l.FindForm()
        If owner IsNot Nothing AndAlso owner.BackgroundImage IsNot Nothing Then Return   ' login page: keep its own colours

        If IsDark(EffectiveBack(l)) Then
            l.LinkColor = Color.Gold
            l.VisitedLinkColor = Color.Gold
            l.ActiveLinkColor = Color.White
        Else
            l.LinkColor = AccentBlue
            l.VisitedLinkColor = AccentBlue
            l.ActiveLinkColor = Navy
        End If
    End Sub

    ' ---------------------------------------------------------------- buttons
    Private Sub StyleButton(b As Button)
        b.Cursor = Cursors.Hand
        b.FlatStyle = FlatStyle.Flat
        b.UseVisualStyleBackColor = False

        If b.Name.StartsWith("btnNav", StringComparison.OrdinalIgnoreCase) OrElse b.Name = "btnLogout" Then
            StyleNavButton(b)
            Return
        End If

        ' icon-only buttons (the back arrow) stay plain
        If b.Image IsNot Nothing AndAlso b.Text = "" Then
            b.FlatAppearance.BorderSize = 0
            Return
        End If

        Dim back As Color
        Dim fore As Color = Color.White
        Dim border As Color
        Dim hover As Color
        Dim pressed As Color

        Select Case RoleOf(b.Name)
            Case "primary"
                back = Navy : border = Navy : hover = NavyHover : pressed = NavyPressed
            Case "accent"
                back = AccentBlue : border = AccentBlue
                hover = Color.FromArgb(37, 80, 210) : pressed = Color.FromArgb(20, 50, 150)
            Case "success"
                back = SuccessGreen : border = SuccessGreen
                hover = Color.FromArgb(28, 116, 28) : pressed = Color.FromArgb(20, 90, 20)
            Case "danger"
                back = DangerRed : border = DangerRed
                hover = Color.FromArgb(170, 30, 30) : pressed = Color.FromArgb(140, 20, 20)
            Case Else        ' secondary: white with a navy outline
                back = Color.White : fore = Navy : border = Navy
                hover = SoftBlue : pressed = Color.FromArgb(215, 220, 245)
        End Select

        b.BackColor = back
        b.ForeColor = fore
        b.FlatAppearance.BorderSize = 1
        b.FlatAppearance.BorderColor = border
        b.FlatAppearance.MouseOverBackColor = hover
        b.FlatAppearance.MouseDownBackColor = pressed
        b.Font = New Font(b.Font, FontStyle.Bold)
    End Sub

    Private Function RoleOf(name As String) As String
        Select Case name
            Case "btnAdd", "btnSave", "btnSaveAttendance", "btnSaveChanges", "btnLogin", "btnContinue", "btnYes", "btnGoToLogin"
                Return "primary"
            Case "btnSearch"
                Return "accent"
            Case "btnExport"
                Return "success"
            Case "btnDelete"
                Return "danger"
            Case Else
                Return "secondary"
        End Select
    End Function

    Private Sub StyleNavButton(b As Button)
        Dim isActive As Boolean = (b.BackColor.ToArgb() = Color.Gold.ToArgb())

        b.FlatAppearance.BorderSize = 0
        b.Font = New Font(b.Font, FontStyle.Bold)

        If b.Name = "btnLogout" Then
            b.TextAlign = ContentAlignment.MiddleCenter
            b.Padding = New Padding(0)
            b.BackColor = Navy
            b.ForeColor = Color.White
            b.FlatAppearance.BorderSize = 1
            b.FlatAppearance.BorderColor = DangerRed
            b.FlatAppearance.MouseOverBackColor = DangerRed
            b.FlatAppearance.MouseDownBackColor = Color.FromArgb(170, 30, 30)
            Return
        End If

        b.TextAlign = ContentAlignment.MiddleLeft
        b.Padding = New Padding(CInt(b.Height * 0.55), 0, 0, 0)

        If isActive Then
            b.BackColor = Color.Gold
            b.ForeColor = Color.FromArgb(20, 20, 60)
            b.FlatAppearance.MouseOverBackColor = Color.Gold
            b.FlatAppearance.MouseDownBackColor = Color.Gold
        Else
            b.BackColor = Navy
            b.ForeColor = Color.White
            b.FlatAppearance.MouseOverBackColor = NavyHover
            b.FlatAppearance.MouseDownBackColor = NavyPressed
        End If
    End Sub

    ' ---------------------------------------------------------------- tables
    Private Sub StyleGridVisual(g As DataGridView)
        Dim baseFont As Font = If(g.DefaultCellStyle.Font, g.Font)

        g.EnableHeadersVisualStyles = False
        g.BackgroundColor = Color.White
        g.BorderStyle = BorderStyle.FixedSingle
        g.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        g.GridColor = GridLine
        g.RowHeadersVisible = False
        g.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        g.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        g.ColumnHeadersHeight = CInt(baseFont.Height * 2.2)
        g.RowTemplate.Height = CInt(baseFont.Height * 2.0)

        With g.ColumnHeadersDefaultCellStyle
            .BackColor = Navy
            .ForeColor = Color.White
            .Font = New Font(FontName, baseFont.Size, FontStyle.Bold, baseFont.Unit)
            .Alignment = DataGridViewContentAlignment.MiddleLeft
            .Padding = New Padding(10, 0, 0, 0)
            .SelectionBackColor = Navy
            .SelectionForeColor = Color.White
        End With

        With g.DefaultCellStyle
            .BackColor = Color.White
            .ForeColor = TextDark
            .Font = New Font(FontName, baseFont.Size, FontStyle.Regular, baseFont.Unit)
            .SelectionBackColor = GridSelect
            .SelectionForeColor = TextDark
            .Padding = New Padding(10, 0, 0, 0)
        End With

        g.AlternatingRowsDefaultCellStyle.BackColor = GridAlt
        g.AlternatingRowsDefaultCellStyle.SelectionBackColor = GridSelect
        g.AlternatingRowsDefaultCellStyle.SelectionForeColor = TextDark
    End Sub

    ' =====================================================================================
    '  Sidebar (same position of logo / menu / logout on every page)
    ' =====================================================================================
    Private Function FindSidebar(form As Form) As Panel
        For Each c As Control In form.Controls
            Dim p As Panel = TryCast(c, Panel)
            If p IsNot Nothing AndAlso p.Dock = DockStyle.Left AndAlso p.BackColor.ToArgb() = Color.Navy.ToArgb() Then Return p
        Next
        Return Nothing
    End Function

    Private Sub LayoutSidebar(side As Panel)
        Dim navNames As String() = {"btnNavDashboard", "btnNavMembers", "btnNavActivities", "btnNavAttendance",
                                    "btnNavMembership", "btnNavReports", "btnNavSettings"}

        Dim margin As Integer = CInt(side.Width * 0.045)
        Dim y As Integer = CInt(side.Width * 0.09)

        ' logo + "SOMAMS" title
        Dim logo As PictureBox = Nothing
        Dim title As Label = Nothing
        For Each c As Control In side.Controls
            If logo Is Nothing AndAlso TypeOf c Is PictureBox Then logo = CType(c, PictureBox)
            If title Is Nothing AndAlso TypeOf c Is Label Then title = CType(c, Label)
        Next

        If logo IsNot Nothing Then
            Dim sz As Integer = CInt(side.Width * 0.3)
            logo.SizeMode = PictureBoxSizeMode.Zoom
            logo.Bounds = New Rectangle(CInt(side.Width * 0.08), y, sz, sz)
            y = logo.Bottom
            If title IsNot Nothing Then
                title.AutoSize = True
                title.BackColor = Color.Transparent
                title.ForeColor = Color.White
                title.Font = New Font(FontName, title.Font.Size, FontStyle.Bold, title.Font.Unit)
                Dim h As Integer = title.GetPreferredSize(Size.Empty).Height
                title.Location = New Point(logo.Right + margin, logo.Top + (logo.Height - h) \ 2)
            End If
        End If

        ' menu buttons: same size, even spacing
        Dim btnH As Integer = 0
        For Each n As String In navNames
            Dim b As Button = FindButton(side, n)
            If b IsNot Nothing Then btnH = Math.Max(btnH, b.Height)
        Next
        If btnH = 0 Then Return

        Dim gap As Integer = CInt(btnH * 0.2)
        Dim btnW As Integer = side.Width - 2 * margin
        y += CInt(side.Width * 0.12)

        For Each n As String In navNames
            Dim b As Button = FindButton(side, n)
            If b IsNot Nothing Then
                b.SetBounds(margin, y, btnW, btnH)
                b.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
                y += btnH + gap
            End If
        Next

        ' logout stays at the bottom edge
        Dim logout As Button = FindButton(side, "btnLogout")
        If logout IsNot Nothing Then
            logout.SetBounds(margin, side.ClientSize.Height - btnH - margin * 2, btnW, btnH)
            logout.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        End If
    End Sub

    ' =====================================================================================
    '  Small helpers
    ' =====================================================================================
    Private Function FindButton(parent As Control, name As String) As Button
        Dim found As Control() = parent.Controls.Find(name, True)
        If found.Length > 0 Then Return TryCast(found(0), Button)
        Return Nothing
    End Function

    Private Function EffectiveBack(c As Control) As Color
        Dim p As Control = c
        Do While p IsNot Nothing
            If p.BackColor.A = 255 Then Return p.BackColor
            p = p.Parent
        Loop
        Return Color.White
    End Function

    Private Function IsDark(c As Color) As Boolean
        Return (0.299 * c.R + 0.587 * c.G + 0.114 * c.B) < 110
    End Function
End Module

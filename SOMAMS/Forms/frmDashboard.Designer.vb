<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDashboard))
        Panel1 = New Panel()
        Label12 = New Label()
        PictureBox4 = New PictureBox()
        btnLogout = New Button()
        btnNavSettings = New Button()
        btnNavMembership = New Button()
        btnNavAttendance = New Button()
        btnNavActivities = New Button()
        btnNavMembers = New Button()
        btnNavDashboard = New Button()
        btnNavReports = New Button()
        Panel2 = New Panel()
        lblAdminName = New Label()
        PictureBox3 = New PictureBox()
        Panel7 = New Panel()
        llblQReports = New LinkLabel()
        llblQMembership = New LinkLabel()
        llblQAttendance = New LinkLabel()
        llblQActivities = New LinkLabel()
        llblQMembers = New LinkLabel()
        Label5 = New Label()
        Panel6 = New Panel()
        lstUpcoming = New ListView()
        Label7 = New Label()
        Label6 = New Label()
        Label4 = New Label()
        Panel4 = New Panel()
        lblActivityCount = New Label()
        llblViewActivities = New LinkLabel()
        Label9 = New Label()
        PictureBox2 = New PictureBox()
        Panel3 = New Panel()
        lblMemberCount = New Label()
        llblViewMembers = New LinkLabel()
        Label8 = New Label()
        PictureBox1 = New PictureBox()
        lblWelcome = New Label()
        Label2 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel7.SuspendLayout()
        Panel6.SuspendLayout()
        Panel4.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Navy
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(PictureBox4)
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
        Panel1.Margin = New Padding(4, 2, 4, 2)
        Panel1.Name = "Panel1"
        Panel1.RightToLeft = RightToLeft.No
        Panel1.Size = New Size(378, 1033)
        Panel1.TabIndex = 1
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Arial Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(180, 79)
        Label12.Name = "Label12"
        Label12.Size = New Size(154, 40)
        Label12.TabIndex = 40
        Label12.Text = "SOMAMS"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.logo2
        PictureBox4.Location = New Point(38, 39)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(125, 125)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 39
        PictureBox4.TabStop = False
        ' 
        ' btnLogout
        ' 
        btnLogout.FlatAppearance.BorderColor = Color.Red
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.ForeColor = SystemColors.Control
        btnLogout.Location = New Point(16, 974)
        btnLogout.Margin = New Padding(4, 2, 4, 2)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(349, 48)
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
        btnNavSettings.Location = New Point(14, 558)
        btnNavSettings.Margin = New Padding(5)
        btnNavSettings.Name = "btnNavSettings"
        btnNavSettings.Size = New Size(349, 48)
        btnNavSettings.TabIndex = 28
        btnNavSettings.Text = "Settings"
        btnNavSettings.UseVisualStyleBackColor = True
        ' 
        ' btnNavMembership
        ' 
        btnNavMembership.FlatStyle = FlatStyle.Flat
        btnNavMembership.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        btnNavMembership.ForeColor = SystemColors.Control
        btnNavMembership.ImageAlign = ContentAlignment.MiddleLeft
        btnNavMembership.Location = New Point(14, 442)
        btnNavMembership.Margin = New Padding(5)
        btnNavMembership.Name = "btnNavMembership"
        btnNavMembership.Size = New Size(349, 48)
        btnNavMembership.TabIndex = 26
        btnNavMembership.Text = "Membership"
        btnNavMembership.UseVisualStyleBackColor = True
        ' 
        ' btnNavAttendance
        ' 
        btnNavAttendance.FlatStyle = FlatStyle.Flat
        btnNavAttendance.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        btnNavAttendance.ForeColor = SystemColors.Control
        btnNavAttendance.ImageAlign = ContentAlignment.MiddleLeft
        btnNavAttendance.Location = New Point(14, 384)
        btnNavAttendance.Margin = New Padding(5)
        btnNavAttendance.Name = "btnNavAttendance"
        btnNavAttendance.Size = New Size(349, 48)
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
        btnNavActivities.Location = New Point(15, 326)
        btnNavActivities.Margin = New Padding(5)
        btnNavActivities.Name = "btnNavActivities"
        btnNavActivities.Size = New Size(349, 48)
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
        btnNavMembers.Location = New Point(15, 268)
        btnNavMembers.Margin = New Padding(5)
        btnNavMembers.Name = "btnNavMembers"
        btnNavMembers.Size = New Size(349, 48)
        btnNavMembers.TabIndex = 23
        btnNavMembers.Text = "Members"
        btnNavMembers.UseVisualStyleBackColor = True
        ' 
        ' btnNavDashboard
        ' 
        btnNavDashboard.BackColor = Color.Gold
        btnNavDashboard.FlatStyle = FlatStyle.Flat
        btnNavDashboard.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        btnNavDashboard.ForeColor = Color.Black
        btnNavDashboard.ImageAlign = ContentAlignment.MiddleLeft
        btnNavDashboard.Location = New Point(15, 210)
        btnNavDashboard.Margin = New Padding(5)
        btnNavDashboard.Name = "btnNavDashboard"
        btnNavDashboard.Size = New Size(349, 48)
        btnNavDashboard.TabIndex = 22
        btnNavDashboard.Text = "Dashboard"
        btnNavDashboard.UseVisualStyleBackColor = False
        ' 
        ' btnNavReports
        ' 
        btnNavReports.FlatStyle = FlatStyle.Flat
        btnNavReports.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        btnNavReports.ForeColor = SystemColors.Control
        btnNavReports.ImageAlign = ContentAlignment.MiddleLeft
        btnNavReports.Location = New Point(14, 500)
        btnNavReports.Margin = New Padding(5)
        btnNavReports.Name = "btnNavReports"
        btnNavReports.Size = New Size(349, 48)
        btnNavReports.TabIndex = 38
        btnNavReports.Text = "Reports"
        btnNavReports.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(lblAdminName)
        Panel2.Controls.Add(PictureBox3)
        Panel2.Controls.Add(Panel7)
        Panel2.Controls.Add(Panel6)
        Panel2.Controls.Add(Panel4)
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(lblWelcome)
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(378, 0)
        Panel2.Margin = New Padding(4, 2, 4, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1511, 1033)
        Panel2.TabIndex = 2
        ' 
        ' lblAdminName
        ' 
        lblAdminName.AutoSize = True
        lblAdminName.Location = New Point(1409, 99)
        lblAdminName.Margin = New Padding(4, 0, 4, 0)
        lblAdminName.Name = "lblAdminName"
        lblAdminName.Size = New Size(51, 20)
        lblAdminName.TabIndex = 8
        lblAdminName.Text = "admin"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Location = New Point(1392, 27)
        PictureBox3.Margin = New Padding(4, 2, 4, 2)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(80, 58)
        PictureBox3.TabIndex = 7
        PictureBox3.TabStop = False
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.White
        Panel7.BorderStyle = BorderStyle.FixedSingle
        Panel7.Controls.Add(llblQReports)
        Panel7.Controls.Add(llblQMembership)
        Panel7.Controls.Add(llblQAttendance)
        Panel7.Controls.Add(llblQActivities)
        Panel7.Controls.Add(llblQMembers)
        Panel7.Controls.Add(Label5)
        Panel7.Location = New Point(37, 794)
        Panel7.Margin = New Padding(4, 2, 4, 2)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(1435, 228)
        Panel7.TabIndex = 6
        ' 
        ' llblQReports
        ' 
        llblQReports.AutoSize = True
        llblQReports.Font = New Font("Arial", 12F)
        llblQReports.LinkBehavior = LinkBehavior.NeverUnderline
        llblQReports.LinkColor = Color.Black
        llblQReports.Location = New Point(668, 117)
        llblQReports.Margin = New Padding(4, 0, 4, 0)
        llblQReports.Name = "llblQReports"
        llblQReports.Size = New Size(80, 23)
        llblQReports.TabIndex = 6
        llblQReports.TabStop = True
        llblQReports.Text = "Reports"
        ' 
        ' llblQMembership
        ' 
        llblQMembership.AutoSize = True
        llblQMembership.Font = New Font("Arial", 12F)
        llblQMembership.LinkBehavior = LinkBehavior.NeverUnderline
        llblQMembership.LinkColor = Color.Black
        llblQMembership.Location = New Point(512, 117)
        llblQMembership.Margin = New Padding(4, 0, 4, 0)
        llblQMembership.Name = "llblQMembership"
        llblQMembership.Size = New Size(143, 23)
        llblQMembership.TabIndex = 4
        llblQMembership.TabStop = True
        llblQMembership.Text = "Membership   ·"
        ' 
        ' llblQAttendance
        ' 
        llblQAttendance.AutoSize = True
        llblQAttendance.Font = New Font("Arial", 12F)
        llblQAttendance.LinkBehavior = LinkBehavior.NeverUnderline
        llblQAttendance.LinkColor = Color.Black
        llblQAttendance.Location = New Point(377, 117)
        llblQAttendance.Margin = New Padding(4, 0, 4, 0)
        llblQAttendance.Name = "llblQAttendance"
        llblQAttendance.Size = New Size(134, 23)
        llblQAttendance.TabIndex = 3
        llblQAttendance.TabStop = True
        llblQAttendance.Text = "Attendance   ·"
        ' 
        ' llblQActivities
        ' 
        llblQActivities.AutoSize = True
        llblQActivities.Font = New Font("Arial", 12F)
        llblQActivities.LinkBehavior = LinkBehavior.NeverUnderline
        llblQActivities.LinkColor = Color.Black
        llblQActivities.Location = New Point(232, 117)
        llblQActivities.Margin = New Padding(4, 0, 4, 0)
        llblQActivities.Name = "llblQActivities"
        llblQActivities.Size = New Size(117, 23)
        llblQActivities.TabIndex = 2
        llblQActivities.TabStop = True
        llblQActivities.Text = " Activities   ·"
        ' 
        ' llblQMembers
        ' 
        llblQMembers.AutoSize = True
        llblQMembers.Font = New Font("Arial", 12F)
        llblQMembers.LinkBehavior = LinkBehavior.NeverUnderline
        llblQMembers.LinkColor = Color.Black
        llblQMembers.Location = New Point(95, 117)
        llblQMembers.Margin = New Padding(4, 0, 4, 0)
        llblQMembers.Name = "llblQMembers"
        llblQMembers.Size = New Size(118, 23)
        llblQMembers.TabIndex = 1
        llblQMembers.TabStop = True
        llblQMembers.Text = "Members   ·"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(32, 23)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(161, 28)
        Label5.TabIndex = 0
        Label5.Text = "Quick Access"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.White
        Panel6.BorderStyle = BorderStyle.FixedSingle
        Panel6.Controls.Add(lstUpcoming)
        Panel6.Controls.Add(Label7)
        Panel6.Controls.Add(Label6)
        Panel6.Controls.Add(Label4)
        Panel6.Location = New Point(37, 374)
        Panel6.Margin = New Padding(4, 2, 4, 2)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(1435, 371)
        Panel6.TabIndex = 5
        ' 
        ' lstUpcoming
        ' 
        lstUpcoming.Alignment = ListViewAlignment.Default
        lstUpcoming.BackColor = Color.White
        lstUpcoming.BorderStyle = BorderStyle.FixedSingle
        lstUpcoming.Font = New Font("Segoe UI", 12F)
        lstUpcoming.FullRowSelect = True
        lstUpcoming.GridLines = True
        lstUpcoming.Location = New Point(75, 102)
        lstUpcoming.Margin = New Padding(4, 2, 4, 2)
        lstUpcoming.Name = "lstUpcoming"
        lstUpcoming.Size = New Size(1283, 240)
        lstUpcoming.TabIndex = 3
        lstUpcoming.TileSize = New Size(50, 100)
        lstUpcoming.UseCompatibleStateImageBehavior = False
        lstUpcoming.View = View.List
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10.2F)
        Label7.Location = New Point(92, 196)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(0, 23)
        Label7.TabIndex = 2
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(31, 66)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(149, 22)
        Label6.TabIndex = 1
        Label6.Text = "Upcoming Activities"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(15, 20)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(262, 28)
        Label4.TabIndex = 0
        Label4.Text = "Organization Activities"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(lblActivityCount)
        Panel4.Controls.Add(llblViewActivities)
        Panel4.Controls.Add(Label9)
        Panel4.Controls.Add(PictureBox2)
        Panel4.Location = New Point(399, 128)
        Panel4.Margin = New Padding(4, 2, 4, 2)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(328, 212)
        Panel4.TabIndex = 4
        ' 
        ' lblActivityCount
        ' 
        lblActivityCount.AutoSize = True
        lblActivityCount.Font = New Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblActivityCount.ForeColor = Color.Blue
        lblActivityCount.Location = New Point(152, 102)
        lblActivityCount.Margin = New Padding(4, 0, 4, 0)
        lblActivityCount.Name = "lblActivityCount"
        lblActivityCount.Size = New Size(36, 41)
        lblActivityCount.TabIndex = 5
        lblActivityCount.Text = "2"
        ' 
        ' llblViewActivities
        ' 
        llblViewActivities.AutoSize = True
        llblViewActivities.LinkBehavior = LinkBehavior.NeverUnderline
        llblViewActivities.Location = New Point(106, 155)
        llblViewActivities.Margin = New Padding(4, 0, 4, 0)
        llblViewActivities.Name = "llblViewActivities"
        llblViewActivities.Size = New Size(123, 20)
        llblViewActivities.TabIndex = 4
        llblViewActivities.TabStop = True
        llblViewActivities.Text = "View all activities"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        Label9.Location = New Point(139, 49)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(78, 23)
        Label9.TabIndex = 2
        Label9.Text = "Activities"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(32, 31)
        PictureBox2.Margin = New Padding(4, 2, 4, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(71, 75)
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(lblMemberCount)
        Panel3.Controls.Add(llblViewMembers)
        Panel3.Controls.Add(Label8)
        Panel3.Controls.Add(PictureBox1)
        Panel3.Location = New Point(37, 128)
        Panel3.Margin = New Padding(4, 2, 4, 2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(328, 212)
        Panel3.TabIndex = 3
        ' 
        ' lblMemberCount
        ' 
        lblMemberCount.AutoSize = True
        lblMemberCount.Font = New Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMemberCount.ForeColor = Color.Green
        lblMemberCount.Location = New Point(142, 102)
        lblMemberCount.Margin = New Padding(4, 0, 4, 0)
        lblMemberCount.Name = "lblMemberCount"
        lblMemberCount.Size = New Size(54, 41)
        lblMemberCount.TabIndex = 4
        lblMemberCount.Text = "20"
        ' 
        ' llblViewMembers
        ' 
        llblViewMembers.AutoSize = True
        llblViewMembers.LinkBehavior = LinkBehavior.NeverUnderline
        llblViewMembers.Location = New Point(100, 155)
        llblViewMembers.Margin = New Padding(4, 0, 4, 0)
        llblViewMembers.Name = "llblViewMembers"
        llblViewMembers.Size = New Size(130, 20)
        llblViewMembers.TabIndex = 3
        llblViewMembers.TabStop = True
        llblViewMembers.Text = "View all members."
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        Label8.Location = New Point(142, 49)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(82, 23)
        Label8.TabIndex = 1
        Label8.Text = "Members"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(32, 31)
        PictureBox1.Margin = New Padding(4, 2, 4, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(72, 75)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblWelcome.Location = New Point(37, 79)
        lblWelcome.Margin = New Padding(4, 0, 4, 0)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(144, 23)
        lblWelcome.TabIndex = 2
        lblWelcome.Text = "Welcome, Admin!"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ImageAlign = ContentAlignment.BottomLeft
        Label2.Location = New Point(18, 27)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(183, 40)
        Label2.TabIndex = 1
        Label2.Text = "Dashboard"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' frmDashboard
        ' 
        AutoScaleDimensions = New SizeF(120F, 120F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoScroll = True
        ClientSize = New Size(1902, 1033)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Margin = New Padding(4, 2, 4, 2)
        Name = "frmDashboard"
        StartPosition = FormStartPosition.WindowsDefaultBounds
        Text = "Dashboard"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnNavSettings As Button
    Friend WithEvents btnNavMembership As Button
    Friend WithEvents btnNavAttendance As Button
    Friend WithEvents btnNavActivities As Button
    Friend WithEvents btnNavMembers As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents llblQReports As LinkLabel
    Friend WithEvents llblQMembership As LinkLabel
    Friend WithEvents llblQAttendance As LinkLabel
    Friend WithEvents llblQActivities As LinkLabel
    Friend WithEvents llblQMembers As LinkLabel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents llblViewActivities As LinkLabel
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents llblViewMembers As LinkLabel
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblWelcome As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblActivityCount As Label
    Friend WithEvents lblMemberCount As Label
    Friend WithEvents lstUpcoming As ListView
    Friend WithEvents lblAdminName As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btnNavDashboard As Button
    Friend WithEvents btnNavReports As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReports
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
        Label1 = New Label()
        Panel6 = New Panel()
        PictureBox12 = New PictureBox()
        llblAttendance = New LinkLabel()
        cardActivities = New Panel()
        PictureBox3 = New PictureBox()
        llblActivities = New LinkLabel()
        cardActiveInactive = New Panel()
        PictureBox2 = New PictureBox()
        llblActiveInactive = New LinkLabel()
        cardMembers = New Panel()
        PictureBox1 = New PictureBox()
        llblMembers = New LinkLabel()
        Label2 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel6.SuspendLayout()
        CType(PictureBox12, ComponentModel.ISupportInitialize).BeginInit()
        cardActivities.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        cardActiveInactive.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        cardMembers.SuspendLayout()
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
        Panel1.TabIndex = 2
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Arial Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(180, 84)
        Label12.Name = "Label12"
        Label12.Size = New Size(154, 40)
        Label12.TabIndex = 43
        Label12.Text = "SOMAMS"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.logo2
        PictureBox4.Location = New Point(38, 37)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(125, 125)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 42
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
        btnNavSettings.Location = New Point(15, 558)
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
        btnNavMembership.Size = New Size(351, 48)
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
        btnNavAttendance.Size = New Size(351, 48)
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
        btnNavActivities.Location = New Point(14, 326)
        btnNavActivities.Margin = New Padding(5)
        btnNavActivities.Name = "btnNavActivities"
        btnNavActivities.Size = New Size(351, 48)
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
        btnNavDashboard.BackColor = Color.Navy
        btnNavDashboard.FlatStyle = FlatStyle.Flat
        btnNavDashboard.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        btnNavDashboard.ForeColor = Color.White
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
        btnNavReports.BackColor = Color.Gold
        btnNavReports.FlatStyle = FlatStyle.Flat
        btnNavReports.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        btnNavReports.ForeColor = Color.Black
        btnNavReports.ImageAlign = ContentAlignment.MiddleLeft
        btnNavReports.Location = New Point(14, 500)
        btnNavReports.Margin = New Padding(5)
        btnNavReports.Name = "btnNavReports"
        btnNavReports.Size = New Size(351, 48)
        btnNavReports.TabIndex = 38
        btnNavReports.Text = "Reports"
        btnNavReports.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(460, 81)
        Label1.Name = "Label1"
        Label1.Size = New Size(215, 23)
        Label1.TabIndex = 11
        Label1.Text = "Generate and view reports." & vbCrLf
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.White
        Panel6.BorderStyle = BorderStyle.FixedSingle
        Panel6.Controls.Add(PictureBox12)
        Panel6.Controls.Add(llblAttendance)
        Panel6.Location = New Point(525, 645)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(356, 330)
        Panel6.TabIndex = 9
        ' 
        ' PictureBox12
        ' 
        PictureBox12.Location = New Point(46, 33)
        PictureBox12.Name = "PictureBox12"
        PictureBox12.Size = New Size(260, 200)
        PictureBox12.TabIndex = 1
        PictureBox12.TabStop = False
        ' 
        ' llblAttendance
        ' 
        llblAttendance.AutoSize = True
        llblAttendance.LinkBehavior = LinkBehavior.NeverUnderline
        llblAttendance.LinkColor = Color.Navy
        llblAttendance.Location = New Point(93, 266)
        llblAttendance.Name = "llblAttendance"
        llblAttendance.Size = New Size(138, 40)
        llblAttendance.TabIndex = 0
        llblAttendance.TabStop = True
        llblAttendance.Text = "Activity Attendance" & vbCrLf & " Report"
        llblAttendance.TextAlign = ContentAlignment.TopCenter
        ' 
        ' cardActivities
        ' 
        cardActivities.BackColor = Color.White
        cardActivities.BorderStyle = BorderStyle.FixedSingle
        cardActivities.Controls.Add(PictureBox3)
        cardActivities.Controls.Add(llblActivities)
        cardActivities.Location = New Point(1416, 210)
        cardActivities.Name = "cardActivities"
        cardActivities.Size = New Size(355, 330)
        cardActivities.TabIndex = 8
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Gold
        PictureBox3.Image = My.Resources.Resources.list1
        PictureBox3.Location = New Point(46, 33)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(260, 200)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 1
        PictureBox3.TabStop = False
        ' 
        ' llblActivities
        ' 
        llblActivities.AutoSize = True
        llblActivities.LinkBehavior = LinkBehavior.NeverUnderline
        llblActivities.LinkColor = Color.Navy
        llblActivities.Location = New Point(136, 265)
        llblActivities.Name = "llblActivities"
        llblActivities.Size = New Size(113, 20)
        llblActivities.TabIndex = 0
        llblActivities.TabStop = True
        llblActivities.Text = "List of Activities"
        llblActivities.TextAlign = ContentAlignment.TopCenter
        ' 
        ' cardActiveInactive
        ' 
        cardActiveInactive.BackColor = Color.White
        cardActiveInactive.BorderStyle = BorderStyle.FixedSingle
        cardActiveInactive.Controls.Add(PictureBox2)
        cardActiveInactive.Controls.Add(llblActiveInactive)
        cardActiveInactive.Location = New Point(973, 210)
        cardActiveInactive.Name = "cardActiveInactive"
        cardActiveInactive.Size = New Size(355, 330)
        cardActiveInactive.TabIndex = 7
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Gold
        PictureBox2.Image = My.Resources.Resources.active
        PictureBox2.Location = New Point(46, 33)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(260, 200)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' llblActiveInactive
        ' 
        llblActiveInactive.AutoSize = True
        llblActiveInactive.LinkBehavior = LinkBehavior.NeverUnderline
        llblActiveInactive.LinkColor = Color.Navy
        llblActiveInactive.Location = New Point(106, 265)
        llblActiveInactive.Name = "llblActiveInactive"
        llblActiveInactive.Size = New Size(134, 40)
        llblActiveInactive.TabIndex = 0
        llblActiveInactive.TabStop = True
        llblActiveInactive.Text = "Active and Inactive" & vbCrLf & " Members"
        llblActiveInactive.TextAlign = ContentAlignment.TopCenter
        ' 
        ' cardMembers
        ' 
        cardMembers.BackColor = Color.White
        cardMembers.BorderStyle = BorderStyle.FixedSingle
        cardMembers.Controls.Add(PictureBox1)
        cardMembers.Controls.Add(llblMembers)
        cardMembers.Location = New Point(525, 210)
        cardMembers.Name = "cardMembers"
        cardMembers.Size = New Size(355, 330)
        cardMembers.TabIndex = 6
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Gold
        PictureBox1.Image = My.Resources.Resources.members
        PictureBox1.Location = New Point(46, 33)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(260, 200)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' llblMembers
        ' 
        llblMembers.AutoSize = True
        llblMembers.LinkBehavior = LinkBehavior.NeverUnderline
        llblMembers.LinkColor = Color.Navy
        llblMembers.Location = New Point(93, 265)
        llblMembers.Name = "llblMembers"
        llblMembers.Size = New Size(161, 40)
        llblMembers.TabIndex = 0
        llblMembers.TabStop = True
        llblMembers.Text = "List of " & vbCrLf & "Organization Members"
        llblMembers.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(415, 37)
        Label2.Name = "Label2"
        Label2.Size = New Size(271, 28)
        Label2.TabIndex = 12
        Label2.Text = "Reports Management Form"
        ' 
        ' frmReports
        ' 
        AutoScaleDimensions = New SizeF(120F, 120F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoScroll = True
        ClientSize = New Size(1902, 1033)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Panel6)
        Controls.Add(cardActivities)
        Controls.Add(cardActiveInactive)
        Controls.Add(cardMembers)
        Controls.Add(Panel1)
        Name = "frmReports"
        Text = "frmReports"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        CType(PictureBox12, ComponentModel.ISupportInitialize).EndInit()
        cardActivities.ResumeLayout(False)
        cardActivities.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        cardActiveInactive.ResumeLayout(False)
        cardActiveInactive.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        cardMembers.ResumeLayout(False)
        cardMembers.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnNavSettings As Button
    Friend WithEvents btnNavParticipation As Button
    Friend WithEvents btnNavMembership As Button
    Friend WithEvents btnNavAttendance As Button
    Friend WithEvents btnNavActivities As Button
    Friend WithEvents btnNavMembers As Button
    Friend WithEvents btnNavDashboard As Button
    Friend WithEvents btnNavReports As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents llblAttendance As LinkLabel
    Friend WithEvents cardActivities As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents llblActivities As LinkLabel
    Friend WithEvents cardActiveInactive As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents llblActiveInactive As LinkLabel
    Friend WithEvents cardMembers As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents llblMembers As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox4 As PictureBox
End Class

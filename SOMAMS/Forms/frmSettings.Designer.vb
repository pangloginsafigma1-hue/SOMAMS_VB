<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        PictureBox1 = New PictureBox()
        btnNavReports = New Button()
        btnLogout = New Button()
        btnNavSettings = New Button()
        btnNavMembership = New Button()
        btnNavAttendance = New Button()
        btnNavActivities = New Button()
        btnNavMembers = New Button()
        btnNavDashboard = New Button()
        Panel2 = New Panel()
        btnSaveChanges = New Button()
        txtConfirmPassword = New TextBox()
        txtNewPassword = New TextBox()
        txtEmail = New TextBox()
        txtUserName = New TextBox()
        txtFullName = New TextBox()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        lblFullNameDisplay = New Label()
        Panel8 = New Panel()
        btnChangePhoto = New Button()
        pbPhoto = New PictureBox()
        Label3 = New Label()
        Label2 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel8.SuspendLayout()
        CType(pbPhoto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Navy
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(btnNavReports)
        Panel1.Controls.Add(btnLogout)
        Panel1.Controls.Add(btnNavSettings)
        Panel1.Controls.Add(btnNavMembership)
        Panel1.Controls.Add(btnNavAttendance)
        Panel1.Controls.Add(btnNavActivities)
        Panel1.Controls.Add(btnNavMembers)
        Panel1.Controls.Add(btnNavDashboard)
        Panel1.Dock = DockStyle.Left
        Panel1.ForeColor = SystemColors.Control
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.RightToLeft = RightToLeft.No
        Panel1.Size = New Size(378, 1033)
        Panel1.TabIndex = 9
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Arial Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(189, 84)
        Label12.Name = "Label12"
        Label12.Size = New Size(154, 40)
        Label12.TabIndex = 41
        Label12.Text = "SOMAMS"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.logo2
        PictureBox1.Location = New Point(40, 36)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(125, 125)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 40
        PictureBox1.TabStop = False
        ' 
        ' btnNavReports
        ' 
        btnNavReports.FlatStyle = FlatStyle.Flat
        btnNavReports.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        btnNavReports.ForeColor = SystemColors.Control
        btnNavReports.ImageAlign = ContentAlignment.MiddleLeft
        btnNavReports.Location = New Point(14, 510)
        btnNavReports.Margin = New Padding(5)
        btnNavReports.Name = "btnNavReports"
        btnNavReports.Size = New Size(350, 48)
        btnNavReports.TabIndex = 39
        btnNavReports.Text = "Reports"
        btnNavReports.UseVisualStyleBackColor = True
        ' 
        ' btnLogout
        ' 
        btnLogout.FlatAppearance.BorderColor = Color.Red
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.ForeColor = SystemColors.Control
        btnLogout.Location = New Point(14, 971)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(319, 50)
        btnLogout.TabIndex = 32
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' btnNavSettings
        ' 
        btnNavSettings.BackColor = Color.Gold
        btnNavSettings.FlatStyle = FlatStyle.Flat
        btnNavSettings.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        btnNavSettings.ForeColor = Color.Black
        btnNavSettings.ImageAlign = ContentAlignment.MiddleLeft
        btnNavSettings.Location = New Point(15, 568)
        btnNavSettings.Margin = New Padding(5)
        btnNavSettings.Name = "btnNavSettings"
        btnNavSettings.Size = New Size(349, 50)
        btnNavSettings.TabIndex = 28
        btnNavSettings.Text = "Settings"
        btnNavSettings.UseVisualStyleBackColor = False
        ' 
        ' btnNavMembership
        ' 
        btnNavMembership.FlatStyle = FlatStyle.Flat
        btnNavMembership.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        btnNavMembership.ForeColor = SystemColors.Control
        btnNavMembership.ImageAlign = ContentAlignment.MiddleLeft
        btnNavMembership.Location = New Point(14, 450)
        btnNavMembership.Margin = New Padding(5)
        btnNavMembership.Name = "btnNavMembership"
        btnNavMembership.Size = New Size(350, 50)
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
        btnNavAttendance.Location = New Point(14, 390)
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
        ' Panel2
        ' 
        Panel2.Controls.Add(btnSaveChanges)
        Panel2.Controls.Add(txtConfirmPassword)
        Panel2.Controls.Add(txtNewPassword)
        Panel2.Controls.Add(txtEmail)
        Panel2.Controls.Add(txtUserName)
        Panel2.Controls.Add(txtFullName)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(lblFullNameDisplay)
        Panel2.Controls.Add(Panel8)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(378, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1524, 1033)
        Panel2.TabIndex = 10
        ' 
        ' btnSaveChanges
        ' 
        btnSaveChanges.BackColor = Color.MediumBlue
        btnSaveChanges.ForeColor = SystemColors.Control
        btnSaveChanges.Location = New Point(1182, 773)
        btnSaveChanges.Name = "btnSaveChanges"
        btnSaveChanges.Size = New Size(171, 48)
        btnSaveChanges.TabIndex = 34
        btnSaveChanges.Text = "Save Changes"
        btnSaveChanges.UseVisualStyleBackColor = False
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle
        txtConfirmPassword.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtConfirmPassword.Location = New Point(845, 682)
        txtConfirmPassword.Multiline = True
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.Size = New Size(508, 36)
        txtConfirmPassword.TabIndex = 33
        txtConfirmPassword.Text = "*********"
        txtConfirmPassword.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtNewPassword
        ' 
        txtNewPassword.BorderStyle = BorderStyle.FixedSingle
        txtNewPassword.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNewPassword.Location = New Point(845, 581)
        txtNewPassword.Multiline = True
        txtNewPassword.Name = "txtNewPassword"
        txtNewPassword.Size = New Size(508, 36)
        txtNewPassword.TabIndex = 31
        txtNewPassword.Text = "*********"
        txtNewPassword.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtEmail
        ' 
        txtEmail.BorderStyle = BorderStyle.FixedSingle
        txtEmail.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtEmail.Location = New Point(845, 481)
        txtEmail.Multiline = True
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(508, 36)
        txtEmail.TabIndex = 29
        txtEmail.Text = "michiepatac@gmail.com"
        txtEmail.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtUserName
        ' 
        txtUserName.BorderStyle = BorderStyle.FixedSingle
        txtUserName.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUserName.Location = New Point(845, 389)
        txtUserName.Multiline = True
        txtUserName.Name = "txtUserName"
        txtUserName.Size = New Size(508, 36)
        txtUserName.TabIndex = 27
        txtUserName.Text = "admin"
        txtUserName.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtFullName
        ' 
        txtFullName.BorderStyle = BorderStyle.FixedSingle
        txtFullName.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtFullName.Location = New Point(845, 289)
        txtFullName.Multiline = True
        txtFullName.Name = "txtFullName"
        txtFullName.Size = New Size(508, 36)
        txtFullName.TabIndex = 24
        txtFullName.Text = "Michie A. Patac"
        txtFullName.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(808, 639)
        Label10.Name = "Label10"
        Label10.Size = New Size(171, 25)
        Label10.TabIndex = 32
        Label10.Text = "Confirm Password: "
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(808, 536)
        Label9.Name = "Label9"
        Label9.Size = New Size(166, 25)
        Label9.TabIndex = 30
        Label9.Text = "Change Password: "
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(808, 444)
        Label8.Name = "Label8"
        Label8.Size = New Size(137, 25)
        Label8.TabIndex = 28
        Label8.Text = "Email Address: "
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(808, 350)
        Label7.Name = "Label7"
        Label7.Size = New Size(105, 25)
        Label7.TabIndex = 26
        Label7.Text = "Username: "
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(808, 250)
        Label6.Name = "Label6"
        Label6.Size = New Size(97, 25)
        Label6.TabIndex = 23
        Label6.Text = "Fullname: "
        ' 
        ' lblFullNameDisplay
        ' 
        lblFullNameDisplay.AutoSize = True
        lblFullNameDisplay.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFullNameDisplay.Location = New Point(331, 245)
        lblFullNameDisplay.Name = "lblFullNameDisplay"
        lblFullNameDisplay.Size = New Size(178, 31)
        lblFullNameDisplay.TabIndex = 22
        lblFullNameDisplay.Text = "Michie A. Patac"
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.Snow
        Panel8.Controls.Add(btnChangePhoto)
        Panel8.Controls.Add(pbPhoto)
        Panel8.Location = New Point(207, 211)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(436, 610)
        Panel8.TabIndex = 25
        ' 
        ' btnChangePhoto
        ' 
        btnChangePhoto.FlatAppearance.BorderSize = 0
        btnChangePhoto.FlatStyle = FlatStyle.Popup
        btnChangePhoto.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnChangePhoto.ForeColor = Color.RoyalBlue
        btnChangePhoto.Location = New Point(124, 535)
        btnChangePhoto.Name = "btnChangePhoto"
        btnChangePhoto.Size = New Size(185, 39)
        btnChangePhoto.TabIndex = 9
        btnChangePhoto.Text = "Change Photo"
        btnChangePhoto.UseVisualStyleBackColor = True
        ' 
        ' pbPhoto
        ' 
        pbPhoto.Location = New Point(58, 91)
        pbPhoto.Name = "pbPhoto"
        pbPhoto.Size = New Size(315, 315)
        pbPhoto.TabIndex = 7
        pbPhoto.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(75, 75)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 23)
        Label3.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(24, 36)
        Label2.Name = "Label2"
        Label2.Size = New Size(280, 28)
        Label2.TabIndex = 2
        Label2.Text = "Reports and Admin Controls"
        ' 
        ' frmSettings
        ' 
        AutoScaleDimensions = New SizeF(120F, 120F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoScroll = True
        ClientSize = New Size(1902, 1033)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "frmSettings"
        Text = "frmSettings"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel8.ResumeLayout(False)
        CType(pbPhoto, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnNavSettings As Button
    Friend WithEvents btnNavParticipation As Button
    Friend WithEvents btnNavMembership As Button
    Friend WithEvents btnNavAttendance As Button
    Friend WithEvents btnNavActivities As Button
    Friend WithEvents btnNavMembers As Button
    Friend WithEvents btnNavDashboard As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnNavReports As Button
    Friend WithEvents btnSaveChanges As Button
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblFullNameDisplay As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents btnChangePhoto As Button
    Friend WithEvents pbPhoto As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label12 As Label
End Class

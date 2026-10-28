<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActivities
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
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel2 = New Panel()
        dgvActivities = New DataGridView()
        btnSearch = New Button()
        btnDelete = New Button()
        btnEdit = New Button()
        GroupBox1 = New GroupBox()
        txtDescription = New TextBox()
        cboStatus = New ComboBox()
        Label1 = New Label()
        btnSave = New Button()
        txtLocation = New TextBox()
        dtpDate = New DateTimePicker()
        txtActivityName = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        txtSearch = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
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
        Panel2.SuspendLayout()
        CType(dgvActivities, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(dgvActivities)
        Panel2.Controls.Add(btnSearch)
        Panel2.Controls.Add(btnDelete)
        Panel2.Controls.Add(btnEdit)
        Panel2.Controls.Add(GroupBox1)
        Panel2.Controls.Add(txtSearch)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Dock = DockStyle.Right
        Panel2.Location = New Point(378, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1529, 1012)
        Panel2.TabIndex = 1
        ' 
        ' dgvActivities
        ' 
        dgvActivities.AllowUserToAddRows = False
        dgvActivities.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvActivities.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        dgvActivities.BackgroundColor = SystemColors.Window
        dgvActivities.CellBorderStyle = DataGridViewCellBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.SkyBlue
        DataGridViewCellStyle2.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvActivities.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvActivities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvActivities.EditMode = DataGridViewEditMode.EditOnF2
        dgvActivities.EnableHeadersVisualStyles = False
        dgvActivities.GridColor = Color.Navy
        dgvActivities.Location = New Point(114, 220)
        dgvActivities.Name = "dgvActivities"
        dgvActivities.RowHeadersWidth = 51
        dgvActivities.Size = New Size(1326, 285)
        dgvActivities.TabIndex = 7
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.MediumBlue
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.ForeColor = SystemColors.Control
        btnSearch.Location = New Point(811, 135)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(94, 31)
        btnSearch.TabIndex = 13
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Red
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.ForeColor = SystemColors.Control
        btnDelete.Location = New Point(1346, 164)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(94, 42)
        btnDelete.TabIndex = 12
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.ForestGreen
        btnEdit.FlatStyle = FlatStyle.Flat
        btnEdit.ForeColor = SystemColors.Control
        btnEdit.Location = New Point(1214, 164)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(94, 42)
        btnEdit.TabIndex = 11
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.White
        GroupBox1.Controls.Add(txtDescription)
        GroupBox1.Controls.Add(cboStatus)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(btnSave)
        GroupBox1.Controls.Add(txtLocation)
        GroupBox1.Controls.Add(dtpDate)
        GroupBox1.Controls.Add(txtActivityName)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.FlatStyle = FlatStyle.Flat
        GroupBox1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(114, 537)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1326, 459)
        GroupBox1.TabIndex = 9
        GroupBox1.TabStop = False
        GroupBox1.Text = "Activity Information"
        ' 
        ' txtDescription
        ' 
        txtDescription.BorderStyle = BorderStyle.FixedSingle
        txtDescription.Location = New Point(267, 249)
        txtDescription.Multiline = True
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(969, 117)
        txtDescription.TabIndex = 11
        ' 
        ' cboStatus
        ' 
        cboStatus.FormattingEnabled = True
        cboStatus.Items.AddRange(New Object() {"Upcoming", "Completed"})
        cboStatus.Location = New Point(857, 195)
        cboStatus.Name = "cboStatus"
        cboStatus.Size = New Size(151, 33)
        cboStatus.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        Label1.Location = New Point(739, 195)
        Label1.Name = "Label1"
        Label1.Size = New Size(66, 23)
        Label1.TabIndex = 9
        Label1.Text = "Status :"
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.MediumBlue
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.ForeColor = SystemColors.Control
        btnSave.Location = New Point(1142, 388)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(94, 38)
        btnSave.TabIndex = 8
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' txtLocation
        ' 
        txtLocation.BackColor = Color.AliceBlue
        txtLocation.Location = New Point(267, 141)
        txtLocation.Name = "txtLocation"
        txtLocation.Size = New Size(969, 31)
        txtLocation.TabIndex = 6
        ' 
        ' dtpDate
        ' 
        dtpDate.Location = New Point(267, 195)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(346, 31)
        dtpDate.TabIndex = 5
        ' 
        ' txtActivityName
        ' 
        txtActivityName.BackColor = Color.AliceBlue
        txtActivityName.BorderStyle = BorderStyle.FixedSingle
        txtActivityName.Location = New Point(267, 85)
        txtActivityName.Name = "txtActivityName"
        txtActivityName.Size = New Size(969, 31)
        txtActivityName.TabIndex = 4
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        Label7.Location = New Point(69, 249)
        Label7.Name = "Label7"
        Label7.Size = New Size(110, 23)
        Label7.TabIndex = 3
        Label7.Text = "Description : "
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        Label6.Location = New Point(69, 141)
        Label6.Name = "Label6"
        Label6.Size = New Size(151, 23)
        Label6.TabIndex = 2
        Label6.Text = "Activity Location : "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        Label5.Location = New Point(69, 195)
        Label5.Name = "Label5"
        Label5.Size = New Size(117, 23)
        Label5.TabIndex = 1
        Label5.Text = "Activity Date :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        Label4.Location = New Point(69, 85)
        Label4.Name = "Label4"
        Label4.Size = New Size(132, 23)
        Label4.TabIndex = 0
        Label4.Text = "Activity Name : "
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = SystemColors.Control
        txtSearch.Location = New Point(114, 135)
        txtSearch.Multiline = True
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = " Search Activities"
        txtSearch.Size = New Size(691, 31)
        txtSearch.TabIndex = 8
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(79, 63)
        Label3.Name = "Label3"
        Label3.Size = New Size(335, 23)
        Label3.TabIndex = 3
        Label3.Text = "Manage organization activities and events."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(29, 21)
        Label2.Name = "Label2"
        Label2.Size = New Size(271, 28)
        Label2.TabIndex = 2
        Label2.Text = "Activity Management Form"
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
        Label12.Location = New Point(176, 88)
        Label12.Name = "Label12"
        Label12.Size = New Size(154, 40)
        Label12.TabIndex = 43
        Label12.Text = "SOMAMS"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.logo2
        PictureBox1.Location = New Point(34, 41)
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
        btnLogout.Location = New Point(14, 971)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(349, 50)
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
        btnNavSettings.Location = New Point(14, 568)
        btnNavSettings.Margin = New Padding(5)
        btnNavSettings.Name = "btnNavSettings"
        btnNavSettings.Size = New Size(350, 50)
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
        btnNavActivities.BackColor = Color.Gold
        btnNavActivities.FlatStyle = FlatStyle.Flat
        btnNavActivities.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        btnNavActivities.ForeColor = Color.Black
        btnNavActivities.ImageAlign = ContentAlignment.MiddleLeft
        btnNavActivities.Location = New Point(14, 330)
        btnNavActivities.Margin = New Padding(5)
        btnNavActivities.Name = "btnNavActivities"
        btnNavActivities.Size = New Size(350, 50)
        btnNavActivities.TabIndex = 24
        btnNavActivities.Text = "Activities"
        btnNavActivities.UseVisualStyleBackColor = False
        ' 
        ' btnNavMembers
        ' 
        btnNavMembers.FlatStyle = FlatStyle.Flat
        btnNavMembers.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        btnNavMembers.ForeColor = SystemColors.Control
        btnNavMembers.ImageAlign = ContentAlignment.MiddleLeft
        btnNavMembers.Location = New Point(14, 270)
        btnNavMembers.Margin = New Padding(5)
        btnNavMembers.Name = "btnNavMembers"
        btnNavMembers.Size = New Size(350, 50)
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
        btnNavReports.Location = New Point(14, 510)
        btnNavReports.Margin = New Padding(5)
        btnNavReports.Name = "btnNavReports"
        btnNavReports.Size = New Size(350, 48)
        btnNavReports.TabIndex = 41
        btnNavReports.Text = "Reports"
        btnNavReports.UseVisualStyleBackColor = True
        ' 
        ' frmActivities
        ' 
        AutoScaleDimensions = New SizeF(120F, 120F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoScroll = True
        ClientSize = New Size(1902, 1033)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Name = "frmActivities"
        Text = "frmActivities"
        WindowState = FormWindowState.Maximized
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(dgvActivities, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents txtActivityName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnNavSettings As Button
    Friend WithEvents btnNavParticipation As Button
    Friend WithEvents btnNavMembership As Button
    Friend WithEvents btnNavAttendance As Button
    Friend WithEvents btnNavActivities As Button
    Friend WithEvents btnNavMembers As Button
    Friend WithEvents btnNavDashboard As Button
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents dgvActivities As DataGridView
    Friend WithEvents btnSearch As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents btnNavReports As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMembers
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
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
        Panel2 = New Panel()
        btnSearch = New Button()
        btnExport = New Button()
        dgvMembers = New DataGridView()
        Label4 = New Label()
        btnDelete = New Button()
        btnEdit = New Button()
        btnAdd = New Button()
        txtSearch = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(dgvMembers, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        Panel1.Size = New Size(378, 1033)
        Panel1.TabIndex = 6
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Arial Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(179, 90)
        Label12.Name = "Label12"
        Label12.Size = New Size(154, 40)
        Label12.TabIndex = 43
        Label12.Text = "SOMAMS"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.logo2
        PictureBox1.Location = New Point(37, 43)
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
        btnLogout.Size = New Size(350, 50)
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
        btnNavSettings.Location = New Point(14, 597)
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
        btnNavMembership.Location = New Point(14, 479)
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
        btnNavAttendance.Location = New Point(14, 419)
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
        btnNavActivities.Location = New Point(15, 359)
        btnNavActivities.Margin = New Padding(5)
        btnNavActivities.Name = "btnNavActivities"
        btnNavActivities.Size = New Size(349, 50)
        btnNavActivities.TabIndex = 24
        btnNavActivities.Text = "Activities"
        btnNavActivities.UseVisualStyleBackColor = True
        ' 
        ' btnNavMembers
        ' 
        btnNavMembers.BackColor = Color.Gold
        btnNavMembers.FlatStyle = FlatStyle.Flat
        btnNavMembers.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        btnNavMembers.ForeColor = Color.Black
        btnNavMembers.ImageAlign = ContentAlignment.MiddleLeft
        btnNavMembers.Location = New Point(15, 299)
        btnNavMembers.Margin = New Padding(5)
        btnNavMembers.Name = "btnNavMembers"
        btnNavMembers.Size = New Size(349, 50)
        btnNavMembers.TabIndex = 23
        btnNavMembers.Text = "Members"
        btnNavMembers.UseVisualStyleBackColor = False
        ' 
        ' btnNavDashboard
        ' 
        btnNavDashboard.FlatStyle = FlatStyle.Flat
        btnNavDashboard.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        btnNavDashboard.ForeColor = SystemColors.Control
        btnNavDashboard.ImageAlign = ContentAlignment.MiddleLeft
        btnNavDashboard.Location = New Point(15, 239)
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
        btnNavReports.Location = New Point(15, 539)
        btnNavReports.Margin = New Padding(5)
        btnNavReports.Name = "btnNavReports"
        btnNavReports.Size = New Size(349, 48)
        btnNavReports.TabIndex = 39
        btnNavReports.Text = "Reports"
        btnNavReports.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackgroundImageLayout = ImageLayout.None
        Panel2.Controls.Add(btnSearch)
        Panel2.Controls.Add(btnExport)
        Panel2.Controls.Add(dgvMembers)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(btnDelete)
        Panel2.Controls.Add(btnEdit)
        Panel2.Controls.Add(btnAdd)
        Panel2.Controls.Add(txtSearch)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(376, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1529, 1033)
        Panel2.TabIndex = 7
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.MediumBlue
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.ForeColor = SystemColors.Control
        btnSearch.Location = New Point(524, 142)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(80, 41)
        btnSearch.TabIndex = 13
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' btnExport
        ' 
        btnExport.BackColor = Color.ForestGreen
        btnExport.Location = New Point(1352, 211)
        btnExport.Name = "btnExport"
        btnExport.Size = New Size(141, 50)
        btnExport.TabIndex = 12
        btnExport.Text = "Export Form"
        btnExport.UseVisualStyleBackColor = False
        ' 
        ' dgvMembers
        ' 
        dgvMembers.AllowUserToAddRows = False
        dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvMembers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        dgvMembers.BackgroundColor = SystemColors.Control
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.SkyBlue
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvMembers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMembers.EnableHeadersVisualStyles = False
        dgvMembers.GridColor = Color.Navy
        dgvMembers.Location = New Point(32, 285)
        dgvMembers.Name = "dgvMembers"
        dgvMembers.RowHeadersWidth = 51
        dgvMembers.Size = New Size(1461, 685)
        dgvMembers.TabIndex = 11
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Light", 10.2F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Gray
        Label4.Location = New Point(122, 1001)
        Label4.Name = "Label4"
        Label4.Size = New Size(392, 23)
        Label4.TabIndex = 10
        Label4.Text = "Student ID  ·  Student Name  ·  Course and Year Level"
        ' 
        ' btnDelete
        ' 
        btnDelete.FlatAppearance.BorderColor = Color.Navy
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.ForeColor = Color.Navy
        btnDelete.Location = New Point(272, 215)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(94, 46)
        btnDelete.TabIndex = 9
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.FlatAppearance.BorderColor = Color.Navy
        btnEdit.FlatStyle = FlatStyle.Flat
        btnEdit.ForeColor = Color.Navy
        btnEdit.Location = New Point(154, 215)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(94, 46)
        btnEdit.TabIndex = 8
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.Navy
        btnAdd.FlatAppearance.BorderColor = Color.SeaGreen
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.ForeColor = SystemColors.Control
        btnAdd.Location = New Point(32, 215)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(94, 46)
        btnAdd.TabIndex = 7
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = SystemColors.MenuBar
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Cursor = Cursors.IBeam
        txtSearch.Location = New Point(33, 142)
        txtSearch.Multiline = True
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(474, 41)
        txtSearch.TabIndex = 4
        txtSearch.Text = "Search Member"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(32, 77)
        Label3.Name = "Label3"
        Label3.Size = New Size(215, 23)
        Label3.TabIndex = 2
        Label3.Text = "Manage student members."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(17, 24)
        Label2.Name = "Label2"
        Label2.Size = New Size(435, 40)
        Label2.TabIndex = 1
        Label2.Text = "Member Management Form"
        ' 
        ' frmMembers
        ' 
        AutoScaleDimensions = New SizeF(120F, 120F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoScroll = True
        ClientSize = New Size(1902, 1033)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "frmMembers"
        Text = "Members"
        WindowState = FormWindowState.Minimized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(dgvMembers, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnNavSettings As Button
    Friend WithEvents btnNavMembership As Button
    Friend WithEvents btnNavAttendance As Button
    Friend WithEvents btnNavMembers As Button
    Friend WithEvents btnNavDashboard As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvMembers As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnExport As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnNavReports As Button
    Friend WithEvents btnNavActivities As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class

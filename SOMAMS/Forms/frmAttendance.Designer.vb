<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAttendance
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
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label2 = New Label()
        Label3 = New Label()
        GroupBox1 = New GroupBox()
        cboActivity = New ComboBox()
        Label4 = New Label()
        txtSearch = New TextBox()
        btnSaveAttendance = New Button()
        Panel2 = New Panel()
        lblSummary = New Label()
        ProgressBar1 = New ProgressBar()
        btnSearch = New Button()
        dgvAttendance = New DataGridView()
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
        GroupBox1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(dgvAttendance, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(38, 28)
        Label2.Name = "Label2"
        Label2.Size = New Size(306, 28)
        Label2.TabIndex = 2
        Label2.Text = "Attendance Management Form"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F)
        Label3.Location = New Point(92, 66)
        Label3.Name = "Label3"
        Label3.Size = New Size(215, 23)
        Label3.TabIndex = 3
        Label3.Text = "Manage student members."
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(cboActivity)
        GroupBox1.FlatStyle = FlatStyle.Flat
        GroupBox1.Location = New Point(109, 223)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(666, 78)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "Select Activity"
        ' 
        ' cboActivity
        ' 
        cboActivity.FormattingEnabled = True
        cboActivity.Location = New Point(25, 26)
        cboActivity.Name = "cboActivity"
        cboActivity.Size = New Size(618, 28)
        cboActivity.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Gray
        Label4.Location = New Point(109, 872)
        Label4.Name = "Label4"
        Label4.Size = New Size(277, 17)
        Label4.TabIndex = 6
        Label4.Text = "Record member attendance during an activity."
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearch.ForeColor = Color.Silver
        txtSearch.Location = New Point(109, 148)
        txtSearch.Multiline = True
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(417, 35)
        txtSearch.TabIndex = 14
        txtSearch.Text = "Search attendance records"
        ' 
        ' btnSaveAttendance
        ' 
        btnSaveAttendance.BackColor = Color.Navy
        btnSaveAttendance.ForeColor = SystemColors.Control
        btnSaveAttendance.Location = New Point(1305, 299)
        btnSaveAttendance.Name = "btnSaveAttendance"
        btnSaveAttendance.Size = New Size(151, 50)
        btnSaveAttendance.TabIndex = 16
        btnSaveAttendance.Text = "Save Attendance"
        btnSaveAttendance.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(lblSummary)
        Panel2.Controls.Add(ProgressBar1)
        Panel2.Controls.Add(btnSearch)
        Panel2.Controls.Add(dgvAttendance)
        Panel2.Controls.Add(btnSaveAttendance)
        Panel2.Controls.Add(txtSearch)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(GroupBox1)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Dock = DockStyle.Right
        Panel2.Location = New Point(378, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1531, 1012)
        Panel2.TabIndex = 1
        ' 
        ' lblSummary
        ' 
        lblSummary.AutoSize = True
        lblSummary.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSummary.ForeColor = SystemColors.WindowFrame
        lblSummary.Location = New Point(1322, 959)
        lblSummary.Name = "lblSummary"
        lblSummary.Size = New Size(134, 17)
        lblSummary.TabIndex = 20
        lblSummary.Text = "Present: 10  Absent: 1"
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.ForeColor = Color.LimeGreen
        ProgressBar1.Location = New Point(114, 993)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(1342, 10)
        ProgressBar1.TabIndex = 19
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.MediumBlue
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.ForeColor = SystemColors.Control
        btnSearch.Location = New Point(553, 148)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(94, 35)
        btnSearch.TabIndex = 18
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' dgvAttendance
        ' 
        dgvAttendance.AllowUserToAddRows = False
        dgvAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvAttendance.BackgroundColor = SystemColors.Control
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = Color.SkyBlue
        DataGridViewCellStyle3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvAttendance.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.SkyBlue
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.False
        dgvAttendance.DefaultCellStyle = DataGridViewCellStyle4
        dgvAttendance.EnableHeadersVisualStyles = False
        dgvAttendance.GridColor = Color.Navy
        dgvAttendance.Location = New Point(109, 370)
        dgvAttendance.Name = "dgvAttendance"
        dgvAttendance.RowHeadersWidth = 51
        dgvAttendance.Size = New Size(1347, 482)
        dgvAttendance.TabIndex = 17
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
        Panel1.Size = New Size(378, 1012)
        Panel1.TabIndex = 8
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Arial Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(181, 87)
        Label12.Name = "Label12"
        Label12.Size = New Size(154, 40)
        Label12.TabIndex = 41
        Label12.Text = "SOMAMS"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.logo2
        PictureBox1.Location = New Point(39, 40)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(125, 125)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 39
        PictureBox1.TabStop = False
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
        btnNavReports.TabIndex = 38
        btnNavReports.Text = "Reports"
        btnNavReports.UseVisualStyleBackColor = True
        ' 
        ' btnLogout
        ' 
        btnLogout.FlatAppearance.BorderColor = Color.Red
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.ForeColor = SystemColors.Control
        btnLogout.Location = New Point(12, 950)
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
        btnNavMembership.FlatStyle = FlatStyle.Flat
        btnNavMembership.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        btnNavMembership.ForeColor = SystemColors.Control
        btnNavMembership.ImageAlign = ContentAlignment.MiddleLeft
        btnNavMembership.Location = New Point(15, 450)
        btnNavMembership.Margin = New Padding(5)
        btnNavMembership.Name = "btnNavMembership"
        btnNavMembership.Size = New Size(349, 50)
        btnNavMembership.TabIndex = 26
        btnNavMembership.Text = "Membership"
        btnNavMembership.UseVisualStyleBackColor = True
        ' 
        ' btnNavAttendance
        ' 
        btnNavAttendance.BackColor = Color.Gold
        btnNavAttendance.FlatStyle = FlatStyle.Flat
        btnNavAttendance.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        btnNavAttendance.ForeColor = Color.Black
        btnNavAttendance.ImageAlign = ContentAlignment.MiddleLeft
        btnNavAttendance.Location = New Point(15, 390)
        btnNavAttendance.Margin = New Padding(5)
        btnNavAttendance.Name = "btnNavAttendance"
        btnNavAttendance.Size = New Size(349, 50)
        btnNavAttendance.TabIndex = 25
        btnNavAttendance.Text = "Attendance"
        btnNavAttendance.UseVisualStyleBackColor = False
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
        ' frmAttendance
        ' 
        AutoScaleDimensions = New SizeF(120F, 120F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoScroll = True
        ClientSize = New Size(1902, 1033)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Name = "frmAttendance"
        Text = "frmAttendance"
        WindowState = FormWindowState.Maximized
        GroupBox1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(dgvAttendance, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cboActivity As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSaveAttendance As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents btnLogout As Button
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents btnNavSettings As Button
    Friend WithEvents btnNavMembership As Button
    Friend WithEvents btnNavAttendance As Button
    Friend WithEvents btnNavActivities As Button
    Friend WithEvents btnNavMembers As Button
    Friend WithEvents btnNavDashboard As Button
    Friend WithEvents dgvAttendance As DataGridView
    Friend WithEvents btnSearch As Button
    Friend WithEvents lblSummary As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewComboBoxColumn
    Friend WithEvents btnNavReports As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label12 As Label
End Class

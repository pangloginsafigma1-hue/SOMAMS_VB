<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParticipation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmParticipation))
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        PictureBox8 = New PictureBox()
        btnLogout = New Button()
        btnNavSettings = New Button()
        btnNavMembership = New Button()
        btnNavAttendance = New Button()
        btnNavActivities = New Button()
        btnNavMembers = New Button()
        Button1 = New Button()
        btnNavReports = New Button()
        Panel2 = New Panel()
        Button5 = New Button()
        Button4 = New Button()
        TextBox1 = New TextBox()
        Panel3 = New Panel()
        Label4 = New Label()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Button3 = New Button()
        Button2 = New Button()
        Label3 = New Label()
        Label2 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Navy
        Panel1.Controls.Add(PictureBox8)
        Panel1.Controls.Add(btnLogout)
        Panel1.Controls.Add(btnNavSettings)
        Panel1.Controls.Add(btnNavMembership)
        Panel1.Controls.Add(btnNavAttendance)
        Panel1.Controls.Add(btnNavActivities)
        Panel1.Controls.Add(btnNavMembers)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(btnNavReports)
        Panel1.Dock = DockStyle.Left
        Panel1.ForeColor = SystemColors.Control
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.RightToLeft = RightToLeft.No
        Panel1.Size = New Size(378, 1033)
        Panel1.TabIndex = 8
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), Image)
        PictureBox8.Location = New Point(47, 49)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(250, 86)
        PictureBox8.TabIndex = 37
        PictureBox8.TabStop = False
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
        btnNavSettings.FlatStyle = FlatStyle.Flat
        btnNavSettings.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        btnNavSettings.ForeColor = SystemColors.Control
        btnNavSettings.ImageAlign = ContentAlignment.MiddleLeft
        btnNavSettings.Location = New Point(15, 645)
        btnNavSettings.Margin = New Padding(5)
        btnNavSettings.Name = "btnNavSettings"
        btnNavSettings.Size = New Size(348, 50)
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
        btnNavMembership.Location = New Point(14, 527)
        btnNavMembership.Margin = New Padding(5)
        btnNavMembership.Name = "btnNavMembership"
        btnNavMembership.Size = New Size(349, 50)
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
        btnNavAttendance.Location = New Point(14, 389)
        btnNavAttendance.Margin = New Padding(5)
        btnNavAttendance.Name = "btnNavAttendance"
        btnNavAttendance.Size = New Size(319, 50)
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
        btnNavActivities.Location = New Point(14, 320)
        btnNavActivities.Margin = New Padding(5)
        btnNavActivities.Name = "btnNavActivities"
        btnNavActivities.Size = New Size(319, 50)
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
        btnNavMembers.Location = New Point(14, 251)
        btnNavMembers.Margin = New Padding(5)
        btnNavMembers.Name = "btnNavMembers"
        btnNavMembers.Size = New Size(319, 50)
        btnNavMembers.TabIndex = 23
        btnNavMembers.Text = "Members"
        btnNavMembers.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        Button1.ForeColor = SystemColors.Control
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(14, 179)
        Button1.Margin = New Padding(5)
        Button1.Name = "Button1"
        Button1.Size = New Size(349, 50)
        Button1.TabIndex = 22
        Button1.Text = "Dashboard"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnNavReports
        ' 
        btnNavReports.FlatStyle = FlatStyle.Flat
        btnNavReports.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        btnNavReports.ForeColor = SystemColors.Control
        btnNavReports.ImageAlign = ContentAlignment.MiddleLeft
        btnNavReports.Location = New Point(14, 587)
        btnNavReports.Margin = New Padding(5)
        btnNavReports.Name = "btnNavReports"
        btnNavReports.Size = New Size(349, 48)
        btnNavReports.TabIndex = 41
        btnNavReports.Text = "Reports"
        btnNavReports.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Button5)
        Panel2.Controls.Add(Button4)
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(DataGridView1)
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Dock = DockStyle.Right
        Panel2.Location = New Point(380, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1522, 1033)
        Panel2.TabIndex = 9
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.LimeGreen
        Button5.Location = New Point(1295, 284)
        Button5.Name = "Button5"
        Button5.Size = New Size(148, 51)
        Button5.TabIndex = 11
        Button5.Text = "Export Form"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.MediumBlue
        Button4.Location = New Point(521, 137)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 37)
        Button4.TabIndex = 10
        Button4.Text = "Search"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Cursor = Cursors.IBeam
        TextBox1.Location = New Point(115, 137)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Search Student"
        TextBox1.Size = New Size(372, 37)
        TextBox1.TabIndex = 9
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.BackgroundImageLayout = ImageLayout.None
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(Label1)
        Panel3.Location = New Point(125, 209)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(241, 126)
        Panel3.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(104, 75)
        Label4.Name = "Label4"
        Label4.Size = New Size(23, 28)
        Label4.TabIndex = 1
        Label4.Text = "2"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(41, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(155, 25)
        Label1.TabIndex = 0
        Label1.Text = "Total of Activities"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        DataGridView1.BackgroundColor = SystemColors.Control
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = Color.SkyBlue
        DataGridViewCellStyle3.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4})
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.GridColor = Color.Navy
        DataGridView1.Location = New Point(110, 372)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1333, 563)
        DataGridView1.TabIndex = 7
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "ID"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Name"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Position"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Attended"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(1349, 789)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 46)
        Button3.TabIndex = 6
        Button3.Text = "Cancel"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Navy
        Button2.FlatAppearance.BorderColor = Color.Navy
        Button2.FlatAppearance.BorderSize = 0
        Button2.ForeColor = SystemColors.Control
        Button2.Location = New Point(1212, 789)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 46)
        Button2.TabIndex = 5
        Button2.Text = "Save"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(75, 75)
        Label3.Name = "Label3"
        Label3.Size = New Size(303, 23)
        Label3.TabIndex = 3
        Label3.Text = "Manage the participation of members."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(36, 31)
        Label2.Name = "Label2"
        Label2.Size = New Size(320, 28)
        Label2.TabIndex = 2
        Label2.Text = "Participation Management Form"
        ' 
        ' frmParticipation
        ' 
        AutoScaleDimensions = New SizeF(120F, 120F)
        AutoScaleMode = AutoScaleMode.Dpi
        ClientSize = New Size(1902, 1033)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "frmParticipation"
        Text = "frmParticipation"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnNavSettings As Button
    Friend WithEvents btnNavMembership As Button
    Friend WithEvents btnNavAttendance As Button
    Friend WithEvents btnNavActivities As Button
    Friend WithEvents btnNavMembers As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btnNavReports As Button
End Class

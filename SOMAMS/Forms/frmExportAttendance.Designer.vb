<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExportAttendance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExportAttendance))
        Label1 = New Label()
        Label2 = New Label()
        cboActivity = New ComboBox()
        btnExport = New Button()
        pbBack = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(40, 59)
        Label1.Name = "Label1"
        Label1.Size = New Size(366, 25)
        Label1.TabIndex = 0
        Label1.Text = "Export attendance in specific activities."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(40, 106)
        Label2.Name = "Label2"
        Label2.Size = New Size(129, 23)
        Label2.TabIndex = 1
        Label2.Text = "Choose activity."
        ' 
        ' cboActivity
        ' 
        cboActivity.DrawMode = DrawMode.OwnerDrawFixed
        cboActivity.DropDownHeight = 50
        cboActivity.DropDownStyle = ComboBoxStyle.DropDownList
        cboActivity.DropDownWidth = 160
        cboActivity.FlatStyle = FlatStyle.System
        cboActivity.Font = New Font("Segoe UI", 10F)
        cboActivity.ForeColor = Color.Black
        cboActivity.FormattingEnabled = True
        cboActivity.IntegralHeight = False
        cboActivity.ItemHeight = 35
        cboActivity.Location = New Point(40, 152)
        cboActivity.Name = "cboActivity"
        cboActivity.Size = New Size(448, 41)
        cboActivity.TabIndex = 2
        ' 
        ' btnExport
        ' 
        btnExport.BackColor = Color.ForestGreen
        btnExport.ForeColor = Color.Black
        btnExport.Location = New Point(173, 243)
        btnExport.Name = "btnExport"
        btnExport.Size = New Size(179, 41)
        btnExport.TabIndex = 3
        btnExport.Text = "Export Attendance"
        btnExport.UseVisualStyleBackColor = False
        ' 
        ' pbBack
        ' 
        pbBack.BackColor = Color.Transparent
        pbBack.FlatAppearance.BorderSize = 0
        pbBack.FlatStyle = FlatStyle.Flat
        pbBack.ForeColor = Color.Transparent
        pbBack.Image = CType(resources.GetObject("pbBack.Image"), Image)
        pbBack.Location = New Point(40, 12)
        pbBack.Name = "pbBack"
        pbBack.Size = New Size(36, 29)
        pbBack.TabIndex = 4
        pbBack.UseVisualStyleBackColor = False
        ' 
        ' frmExportAttendance
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Navy
        ClientSize = New Size(532, 327)
        Controls.Add(pbBack)
        Controls.Add(btnExport)
        Controls.Add(cboActivity)
        Controls.Add(Label2)
        Controls.Add(Label1)
        ForeColor = Color.White
        FormBorderStyle = FormBorderStyle.None
        Name = "frmExportAttendance"
        StartPosition = FormStartPosition.CenterParent
        Text = "frmaActivityAttendanceReport"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cboActivity As ComboBox
    Friend WithEvents btnExport As Button
    Friend WithEvents pbBack As Button
End Class

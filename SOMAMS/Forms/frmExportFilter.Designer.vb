<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExportFilter
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        cboMember = New ComboBox()
        cboPosition = New ComboBox()
        cboStatus = New ComboBox()
        btnExport = New Button()
        btnCancel = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(45, 61)
        Label1.Name = "Label1"
        Label1.Size = New Size(387, 25)
        Label1.TabIndex = 0
        Label1.Text = "Filter the information you want to export." + vbCrLf
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(45, 220)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 23)
        Label2.TabIndex = 1
        Label2.Text = "Position: "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(45, 119)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 23)
        Label3.TabIndex = 2
        Label3.Text = "Member: "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.2F)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(45, 314)
        Label4.Name = "Label4"
        Label4.Size = New Size(165, 23)
        Label4.TabIndex = 3
        Label4.Text = "Membership Status: "
        ' 
        ' cboMember
        ' 
        cboMember.DrawMode = DrawMode.OwnerDrawFixed
        cboMember.DropDownHeight = 120
        cboMember.DropDownStyle = ComboBoxStyle.DropDownList
        cboMember.DropDownWidth = 150
        cboMember.FormattingEnabled = True
        cboMember.IntegralHeight = False
        cboMember.ItemHeight = 40
        cboMember.Location = New Point(45, 145)
        cboMember.Name = "cboMember"
        cboMember.Size = New Size(412, 46)
        cboMember.TabIndex = 4
        ' 
        ' cboPosition
        ' 
        cboPosition.DrawMode = DrawMode.OwnerDrawFixed
        cboPosition.DropDownHeight = 120
        cboPosition.DropDownStyle = ComboBoxStyle.DropDownList
        cboPosition.DropDownWidth = 150
        cboPosition.FormattingEnabled = True
        cboPosition.IntegralHeight = False
        cboPosition.ItemHeight = 40
        cboPosition.Location = New Point(45, 246)
        cboPosition.Name = "cboPosition"
        cboPosition.Size = New Size(412, 46)
        cboPosition.TabIndex = 5
        ' 
        ' cboStatus
        ' 
        cboStatus.DrawMode = DrawMode.OwnerDrawFixed
        cboStatus.DropDownHeight = 120
        cboStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cboStatus.DropDownWidth = 150
        cboStatus.FormattingEnabled = True
        cboStatus.IntegralHeight = False
        cboStatus.ItemHeight = 40
        cboStatus.Location = New Point(45, 340)
        cboStatus.Name = "cboStatus"
        cboStatus.Size = New Size(412, 46)
        cboStatus.TabIndex = 6
        ' 
        ' btnExport
        ' 
        btnExport.BackColor = Color.ForestGreen
        btnExport.FlatAppearance.BorderColor = Color.ForestGreen
        btnExport.FlatAppearance.BorderSize = 0
        btnExport.Location = New Point(363, 458)
        btnExport.Name = "btnExport"
        btnExport.Size = New Size(94, 45)
        btnExport.TabIndex = 7
        btnExport.Text = "Export"
        btnExport.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(249, 458)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(94, 45)
        btnCancel.TabIndex = 8
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' frmExportFilter
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Navy
        ClientSize = New Size(505, 529)
        Controls.Add(btnCancel)
        Controls.Add(btnExport)
        Controls.Add(cboStatus)
        Controls.Add(cboPosition)
        Controls.Add(cboMember)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmExportFilter"
        StartPosition = FormStartPosition.CenterParent
        Text = "expFilterMembers"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cboMember As ComboBox
    Friend WithEvents cboPosition As ComboBox
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents btnExport As Button
    Friend WithEvents btnCancel As Button
End Class

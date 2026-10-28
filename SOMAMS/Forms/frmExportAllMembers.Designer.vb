<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExportAllMembers
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
        llblFilter = New LinkLabel()
        btnExport = New Button()
        btnCancel = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(40, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(363, 25)
        Label1.TabIndex = 0
        Label1.Text = "Export all members of the organization"
        ' 
        ' llblFilter
        ' 
        llblFilter.AutoSize = True
        llblFilter.ForeColor = Color.White
        llblFilter.LinkColor = Color.White
        llblFilter.Location = New Point(298, 87)
        llblFilter.Name = "llblFilter"
        llblFilter.Size = New Size(96, 20)
        llblFilter.TabIndex = 1
        llblFilter.TabStop = True
        llblFilter.Text = "Filter Export?"
        ' 
        ' btnExport
        ' 
        btnExport.BackColor = Color.ForestGreen
        btnExport.Location = New Point(305, 188)
        btnExport.Name = "btnExport"
        btnExport.Size = New Size(98, 46)
        btnExport.TabIndex = 2
        btnExport.Text = "Export"
        btnExport.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.ForeColor = Color.Black
        btnCancel.Location = New Point(178, 188)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(104, 46)
        btnCancel.TabIndex = 3
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' frmExportAllMembers
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Navy
        ClientSize = New Size(448, 275)
        Controls.Add(btnCancel)
        Controls.Add(btnExport)
        Controls.Add(llblFilter)
        Controls.Add(Label1)
        ForeColor = Color.White
        FormBorderStyle = FormBorderStyle.None
        Name = "frmExportAllMembers"
        StartPosition = FormStartPosition.CenterParent
        Text = "expFormListofMembers"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents llblFilter As LinkLabel
    Friend WithEvents btnExport As Button
    Friend WithEvents btnCancel As Button
End Class

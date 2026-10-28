<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfirmLogout
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
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        btnCancel = New Button()
        btnYes = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(130, 28)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(125, 62)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(119, 93)
        Label1.Name = "Label1"
        Label1.Size = New Size(145, 25)
        Label1.TabIndex = 1
        Label1.Text = "Confirm Logout"
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(73, 128)
        Label2.Name = "Label2"
        Label2.Size = New Size(242, 41)
        Label2.TabIndex = 2
        Label2.Text = "Are you sure you want to logout from your account? "
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(95, 191)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(94, 29)
        btnCancel.TabIndex = 3
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnYes
        ' 
        btnYes.Location = New Point(195, 191)
        btnYes.Name = "btnYes"
        btnYes.Size = New Size(94, 29)
        btnYes.TabIndex = 4
        btnYes.Text = "Yes, Logout"
        btnYes.UseVisualStyleBackColor = True
        ' 
        ' frmConfirmLogout
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(400, 250)
        Controls.Add(btnYes)
        Controls.Add(btnCancel)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmConfirmLogout"
        StartPosition = FormStartPosition.CenterParent
        Text = "frmConfirmLogout"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnYes As Button
End Class

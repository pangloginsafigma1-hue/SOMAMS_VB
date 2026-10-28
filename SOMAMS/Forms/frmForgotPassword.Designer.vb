<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmForgotPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmForgotPassword))
        Label1 = New Label()
        Label2 = New Label()
        btnContinue = New Button()
        txtEmail = New TextBox()
        pbBack = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(30, 71)
        Label1.Name = "Label1"
        Label1.Size = New Size(299, 25)
        Label1.TabIndex = 0
        Label1.Text = "Send code to your email account"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(30, 118)
        Label2.Name = "Label2"
        Label2.Size = New Size(170, 20)
        Label2.TabIndex = 1
        Label2.Text = "Enter you email address."
        ' 
        ' btnContinue
        ' 
        btnContinue.BackColor = Color.Navy
        btnContinue.FlatStyle = FlatStyle.Flat
        btnContinue.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnContinue.ForeColor = Color.White
        btnContinue.Location = New Point(30, 215)
        btnContinue.Name = "btnContinue"
        btnContinue.Size = New Size(382, 46)
        btnContinue.TabIndex = 2
        btnContinue.Text = "Continue"
        btnContinue.UseVisualStyleBackColor = False
        ' 
        ' txtEmail
        ' 
        txtEmail.BorderStyle = BorderStyle.FixedSingle
        txtEmail.Location = New Point(30, 151)
        txtEmail.Multiline = True
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(382, 44)
        txtEmail.TabIndex = 3
        ' 
        ' pbBack
        ' 
        pbBack.BackgroundImageLayout = ImageLayout.Stretch
        pbBack.FlatAppearance.BorderSize = 0
        pbBack.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        pbBack.Image = CType(resources.GetObject("pbBack.Image"), Image)
        pbBack.Location = New Point(30, 12)
        pbBack.Name = "pbBack"
        pbBack.Size = New Size(34, 38)
        pbBack.TabIndex = 4
        pbBack.UseVisualStyleBackColor = True
        ' 
        ' frmForgotPassword
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(441, 306)
        Controls.Add(pbBack)
        Controls.Add(txtEmail)
        Controls.Add(btnContinue)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmForgotPassword"
        StartPosition = FormStartPosition.CenterParent
        Text = "frmForgotPassword"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnContinue As Button
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents pbBack As Button
End Class

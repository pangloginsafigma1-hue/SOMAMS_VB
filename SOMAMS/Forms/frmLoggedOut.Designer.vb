<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoggedOut
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
        components = New ComponentModel.Container()
        btnGoToLogin = New Button()
        Label5 = New Label()
        pbRedirect = New ProgressBar()
        lblRedirect = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        tmrRedirect = New Timer(components)
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnGoToLogin
        ' 
        btnGoToLogin.Location = New Point(170, 469)
        btnGoToLogin.Name = "btnGoToLogin"
        btnGoToLogin.Size = New Size(123, 41)
        btnGoToLogin.TabIndex = 15
        btnGoToLogin.Text = "Go To Login"
        btnGoToLogin.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(104, 419)
        Label5.Name = "Label5"
        Label5.Size = New Size(266, 17)
        Label5.TabIndex = 14
        Label5.Text = "If your not redirected, click the button below"
        ' 
        ' pbRedirect
        ' 
        pbRedirect.ForeColor = Color.Green
        pbRedirect.Location = New Point(80, 395)
        pbRedirect.Name = "pbRedirect"
        pbRedirect.Size = New Size(312, 10)
        pbRedirect.Style = ProgressBarStyle.Continuous
        pbRedirect.TabIndex = 13
        ' 
        ' lblRedirect
        ' 
        lblRedirect.AutoSize = True
        lblRedirect.Location = New Point(104, 356)
        lblRedirect.Name = "lblRedirect"
        lblRedirect.Size = New Size(273, 20)
        lblRedirect.TabIndex = 12
        lblRedirect.Text = "Redirecting to login page in 3 seconds..."
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(135, 308)
        Label3.Name = "Label3"
        Label3.Size = New Size(209, 20)
        Label3.TabIndex = 11
        Label3.Text = "Thank you for using SOMAMS!"
        ' 
        ' Label2
        ' 
        Label2.Location = New Point(80, 283)
        Label2.Name = "Label2"
        Label2.Size = New Size(312, 25)
        Label2.TabIndex = 10
        Label2.Text = "You have been logged out from your account."
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(117, 245)
        Label1.Name = "Label1"
        Label1.Size = New Size(242, 28)
        Label1.TabIndex = 9
        Label1.Text = "Logged Out Successfully!"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(160, 107)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(146, 123)
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' frmLoggedOut
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(471, 613)
        Controls.Add(btnGoToLogin)
        Controls.Add(Label5)
        Controls.Add(pbRedirect)
        Controls.Add(lblRedirect)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmLoggedOut"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Logout Successful"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnGoToLogin As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents pbRedirect As ProgressBar
    Friend WithEvents lblRedirect As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tmrRedirect As Timer
End Class

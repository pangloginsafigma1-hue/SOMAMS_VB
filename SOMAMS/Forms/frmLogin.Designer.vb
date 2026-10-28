<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Label1 = New Label()
        Label2 = New Label()
        btnLogin = New Button()
        Label3 = New Label()
        Label4 = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        chkRememberMe = New CheckBox()
        llblForgotPassword = New LinkLabel()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        resources.ApplyResources(Label1, "Label1")
        Label1.BackColor = Color.Transparent
        Label1.ForeColor = Color.White
        Label1.Name = "Label1"
        ' 
        ' Label2
        ' 
        resources.ApplyResources(Label2, "Label2")
        Label2.BackColor = Color.Transparent
        Label2.ForeColor = Color.White
        Label2.Name = "Label2"
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.Navy
        btnLogin.FlatAppearance.BorderColor = Color.White
        btnLogin.FlatAppearance.BorderSize = 2
        resources.ApplyResources(btnLogin, "btnLogin")
        btnLogin.ForeColor = Color.White
        btnLogin.Name = "btnLogin"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        resources.ApplyResources(Label3, "Label3")
        Label3.BackColor = Color.Transparent
        Label3.ForeColor = Color.White
        Label3.Name = "Label3"
        ' 
        ' Label4
        ' 
        resources.ApplyResources(Label4, "Label4")
        Label4.BackColor = Color.Transparent
        Label4.ForeColor = Color.White
        Label4.Name = "Label4"
        ' 
        ' txtUsername
        ' 
        resources.ApplyResources(txtUsername, "txtUsername")
        txtUsername.Name = "txtUsername"
        ' 
        ' txtPassword
        ' 
        resources.ApplyResources(txtPassword, "txtPassword")
        txtPassword.Name = "txtPassword"
        ' 
        ' chkRememberMe
        ' 
        resources.ApplyResources(chkRememberMe, "chkRememberMe")
        chkRememberMe.BackColor = Color.Transparent
        chkRememberMe.ForeColor = Color.White
        chkRememberMe.Name = "chkRememberMe"
        chkRememberMe.UseVisualStyleBackColor = False
        ' 
        ' llblForgotPassword
        ' 
        resources.ApplyResources(llblForgotPassword, "llblForgotPassword")
        llblForgotPassword.BackColor = Color.Transparent
        llblForgotPassword.LinkBehavior = LinkBehavior.NeverUnderline
        llblForgotPassword.LinkColor = Color.White
        llblForgotPassword.Name = "llblForgotPassword"
        llblForgotPassword.TabStop = True
        ' 
        ' frmLogin
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.White
        BackgroundImage = My.Resources.Resources.SOMAMS__1_
        Controls.Add(llblForgotPassword)
        Controls.Add(chkRememberMe)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(btnLogin)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "frmLogin"
        WindowState = FormWindowState.Maximized
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents chkRememberMe As CheckBox
    Friend WithEvents llblForgotPassword As LinkLabel
End Class

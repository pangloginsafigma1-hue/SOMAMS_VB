Public Class frmLogin

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.UseSystemPasswordChar = True

        ' Check the database first
        Dim errMsg As String = ""
        If Not Database.TestConnection(errMsg) Then
            MessageBox.Show("Cannot connect to MySQL:" & vbCrLf & errMsg & vbCrLf & vbCrLf &
                            "Check the values at the top of Helpers\Database.vb.",
                            "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btnLogin.Enabled = False
            Return
        End If
        AuthController.EnsureDefaultAdmin()

        ' Remember Me
        If Not String.IsNullOrEmpty(My.Settings.SavedUsername) Then
            txtUsername.Text = My.Settings.SavedUsername
            chkRememberMe.Checked = True
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text.Trim() = "" OrElse txtPassword.Text = "" Then
            MessageBox.Show("Please enter your username and password.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim admin As Admin = AuthController.Login(txtUsername.Text.Trim(), txtPassword.Text)
        If admin Is Nothing Then
            MessageBox.Show("Incorrect username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Clear()
            txtPassword.Focus()
            Return
        End If

        Session.CurrentAdmin = admin
        My.Settings.SavedUsername = If(chkRememberMe.Checked, admin.Username, "")
        My.Settings.Save()
        Navigator.Open(Of frmDashboard)(Me)
    End Sub

    ' "Forgot Password?" (works for a Label or a LinkLabel)
    Private Sub llblForgotPassword_Click(sender As Object, e As EventArgs) Handles llblForgotPassword.Click
        Using f As New frmForgotPassword()
            f.ShowDialog(Me)
        End Using
    End Sub

    ' Press Enter in the password box to log in
    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnLogin.PerformClick()
        End If
    End Sub
End Class

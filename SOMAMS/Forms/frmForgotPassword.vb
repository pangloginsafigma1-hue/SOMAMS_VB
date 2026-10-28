Public Class frmForgotPassword

    Private Sub pbBack_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        Me.Close()
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        Dim email As String = txtEmail.Text.Trim()
        If email = "" Then
            MessageBox.Show("Please enter your email address.", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim admin As Admin = AuthController.FindByEmail(email)
        If admin Is Nothing Then
            MessageBox.Show("No account was found with that email.", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        btnContinue.Enabled = False
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim code As String = New Random().Next(100000, 1000000).ToString()
            Dim errMsg As String = ""
            If Not EmailService.SendCode(email, code, errMsg) Then
                MessageBox.Show("Could not send the email:" & vbCrLf & errMsg, "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            Me.Cursor = Cursors.Default

            Dim entered As String = InputBox("Enter the 6-digit code sent to " & email, "Verify Code")
            If entered.Trim() <> code Then
                MessageBox.Show("Incorrect code.", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim newPw As String = InputBox("Enter your new password (at least 6 characters):", "Reset Password")
            If newPw.Length < 6 Then
                MessageBox.Show("Password is too short. Please try again.", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            AuthController.ResetPassword(admin.AdminId, newPw)
            MessageBox.Show("Password changed. You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Finally
            Me.Cursor = Cursors.Default
            btnContinue.Enabled = True
        End Try
    End Sub
End Class

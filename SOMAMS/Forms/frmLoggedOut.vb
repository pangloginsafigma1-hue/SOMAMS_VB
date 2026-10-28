Public Class frmLoggedOut
    ' Add a Timer named tmrRedirect and a ProgressBar named pbRedirect to this form.

    Private _secondsLeft As Integer = 3
    Private _done As Boolean = False

    Private Sub frmLoggedOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pbRedirect.Minimum = 0
        pbRedirect.Maximum = 3
        pbRedirect.Value = 0
        lblRedirect.Text = "Redirecting to login page in 3 seconds..."
        tmrRedirect.Interval = 1000
        tmrRedirect.Start()
    End Sub

    Private Sub tmrRedirect_Tick(sender As Object, e As EventArgs) Handles tmrRedirect.Tick
        _secondsLeft -= 1
        pbRedirect.Value = 3 - _secondsLeft
        If _secondsLeft <= 0 Then
            GoToLogin()
        Else
            lblRedirect.Text = "Redirecting to login page in " & _secondsLeft & " seconds..."
        End If
    End Sub

    Private Sub btnGoToLogin_Click(sender As Object, e As EventArgs) Handles btnGoToLogin.Click
        GoToLogin()
    End Sub

    Private Sub GoToLogin()
        If _done Then Return
        _done = True
        tmrRedirect.Stop()
        Navigator.Show(New frmLogin(), Me)
    End Sub
End Class

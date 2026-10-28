Public Class frmLoggingOut
    ' Add a Timer named tmrWait to this form (Interval is set below).

    Private Sub frmLoggingOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrWait.Interval = 2000
        tmrWait.Start()
    End Sub

    Private Sub tmrWait_Tick(sender As Object, e As EventArgs) Handles tmrWait.Tick
        tmrWait.Stop()
        Me.Close()
    End Sub
End Class

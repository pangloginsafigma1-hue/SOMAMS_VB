Public Class frmConfirmLogout

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        Me.DialogResult = DialogResult.Yes
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub
End Class

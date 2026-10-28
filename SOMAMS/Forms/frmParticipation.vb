Public Class frmParticipation
    Private Sub frmParticipation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Using frmDashboard As New frmDashboard()
            frmDashboard.ShowDialog()
        End Using
        Me.Show()
    End Sub

    Private Sub btnNavMembers_Click(sender As Object, e As EventArgs) Handles btnNavMembers.Click
        Me.Hide()
        Using frmMembers As New frmMembers()
            frmMembers.ShowDialog()
        End Using
        Me.Show()
    End Sub

    Private Sub btnNavActivities_Click(sender As Object, e As EventArgs) Handles btnNavActivities.Click
        Me.Hide()
        Using frmActivities As New frmActivities()
            frmActivities.ShowDialog()
        End Using
        Me.Show()
    End Sub

    Private Sub btnNavAttendance_Click(sender As Object, e As EventArgs) Handles btnNavAttendance.Click
        Me.Hide()
        Using frmAttendance As New frmAttendance()
            frmAttendance.ShowDialog()
        End Using
        Me.Show()
    End Sub

    Private Sub btnNavMembership_Click(sender As Object, e As EventArgs) Handles btnNavMembership.Click
        Me.Hide()
        Using frmMembershipForm As New frmMembershipForm()
            frmMembershipForm.ShowDialog()
        End Using
        Me.Show()
    End Sub

    Private Sub btnNavParticipation_Click(sender As Object, e As EventArgs)
        Hide()

        Using frmParticipation As New frmParticipation
            frmParticipation.ShowDialog()
        End Using
        Show()
    End Sub

    Private Sub btnNavSettings_Click(sender As Object, e As EventArgs) Handles btnNavSettings.Click
        Me.Hide()
        Using frmSettings As New frmSettings()
            frmSettings.ShowDialog()
        End Using
        Me.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnNavReports.Click

    End Sub
End Class
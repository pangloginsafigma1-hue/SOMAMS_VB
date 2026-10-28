Public Class frmDashboard

    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Navigator.WireSidebar(Me)

        lblWelcome.Text = "Welcome, " & Session.CurrentAdmin.FullName & "!"
        lblAdminName.Text = Session.CurrentAdmin.Username

        lblMemberCount.Text = DashboardController.CountMembers().ToString()
        lblActivityCount.Text = DashboardController.CountActivities().ToString()

        lstUpcoming.Items.Clear()
        For Each r As DataRow In DashboardController.GetUpcomingActivities().Rows
            lstUpcoming.Items.Add(Convert.ToDateTime(r("activity_date")).ToString("MMM dd, yyyy") & "  -  " &
                                  r("activity_name").ToString() & "  (" & r("location").ToString() & ")")
        Next
    End Sub

    ' ----- cards -----
    Private Sub llblViewMembers_Click(sender As Object, e As EventArgs) Handles llblViewMembers.Click
        Navigator.Open(Of frmMembers)(Me)
    End Sub

    Private Sub llblViewActivities_Click(sender As Object, e As EventArgs) Handles llblViewActivities.Click
        Navigator.Open(Of frmActivities)(Me)
    End Sub

    ' ----- quick access links -----
    Private Sub llblQMembers_Click(sender As Object, e As EventArgs) Handles llblQMembers.Click
        Navigator.Open(Of frmMembers)(Me)
    End Sub

    Private Sub llblQActivities_Click(sender As Object, e As EventArgs) Handles llblQActivities.Click
        Navigator.Open(Of frmActivities)(Me)
    End Sub

    Private Sub llblQAttendance_Click(sender As Object, e As EventArgs) Handles llblQAttendance.Click
        Navigator.Open(Of frmAttendance)(Me)
    End Sub

    Private Sub llblQMembership_Click(sender As Object, e As EventArgs) Handles llblQMembership.Click
        Navigator.Open(Of frmMembershipForm)(Me)
    End Sub

    Private Sub llblQReports_Click(sender As Object, e As EventArgs) Handles llblQReports.Click
        Navigator.Open(Of frmReports)(Me)
    End Sub


End Class

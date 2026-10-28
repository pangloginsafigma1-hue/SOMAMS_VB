Public Class frmReports

    Private Sub frmReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Navigator.WireSidebar(Me)
    End Sub

    ' List of Organization Members -> "Export all members of the organization?" pop-up
    Private Sub llblMembers_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblMembers.LinkClicked
        ShowPopup(New frmExportAllMembers())
    End Sub

    ' Active and Inactive Members -> "Filter the information you want to export" pop-up
    Private Sub llblActiveInactive_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblActiveInactive.LinkClicked
        ShowPopup(New frmExportFilter())
    End Sub

    ' List of Activities -> "Export List of Activities" pop-up
    Private Sub llblActivities_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblActivities.LinkClicked
        ShowPopup(New frmExportActivities())
    End Sub

    ' Activity Attendance Report -> "Export attendance in specific activities" pop-up
    Private Sub llblAttendance_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblAttendance.LinkClicked
        ShowPopup(New frmExportAttendance())
    End Sub

    Private Sub ShowPopup(popup As Form)
        Using popup
            popup.ShowDialog(Me)
        End Using
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub
End Class
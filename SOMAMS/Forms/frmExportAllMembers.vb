Public Class frmExportAllMembers

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim dt As DataTable = ReportController.MembersReport(Nothing, Nothing, Nothing)
        If WordExporter.ExportWithDialog(dt, "List of Organization Members", "Members") Then Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    ' "Filter Members?" link -> opens the filter pop-up instead
    Private Sub llblFilter_Click(sender As Object, e As EventArgs) Handles llblFilter.Click
        Me.Hide()
        Using f As New frmExportFilter()
            f.ShowDialog()
        End Using
        Me.Close()
    End Sub
End Class

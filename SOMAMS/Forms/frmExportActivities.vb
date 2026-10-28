Public Class frmExportActivities

    Private Sub frmExportActivities_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFrom.MinDate = DateTimePicker.MinimumDateTime
        dtpFrom.MaxDate = DateTimePicker.MaximumDateTime
        dtpTo.MinDate = DateTimePicker.MinimumDateTime
        dtpTo.MaxDate = DateTimePicker.MaximumDateTime
        dtpFrom.Value = Date.Today
        dtpTo.Value = Date.Today
    End Sub

    Private Sub pbBack_Click(sender As Object, e As EventArgs) Handles pbBack.Click
        Me.Close()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        If dtpFrom.Value.Date > dtpTo.Value.Date Then
            MessageBox.Show("The 'From' date must not be later than the 'To' date.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim dt As DataTable = ReportController.ActivitiesReport(dtpFrom.Value, dtpTo.Value)
        Dim title As String = "List of Activities (" & dtpFrom.Value.ToString("MMM d, yyyy") & " - " & dtpTo.Value.ToString("MMM d, yyyy") & ")"
        If WordExporter.ExportWithDialog(dt, title, "Activities") Then Me.Close()
    End Sub
End Class

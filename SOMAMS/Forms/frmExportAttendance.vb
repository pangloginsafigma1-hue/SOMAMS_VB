Public Class frmExportAttendance

    Private Sub frmExportAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboActivity.DropDownStyle = ComboBoxStyle.DropDownList
        cboActivity.DisplayMember = "activity_name"
        cboActivity.ValueMember = "activity_id"
        cboActivity.DataSource = ActivityController.GetLookup()
        cboActivity.SelectedIndex = -1
    End Sub

    Private Sub pbBack_Click(sender As Object, e As EventArgs) Handles pbBack.Click
        Me.Close()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        If cboActivity.SelectedIndex < 0 Then
            MessageBox.Show("Please choose an activity.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim row As DataRowView = CType(cboActivity.SelectedItem, DataRowView)
        Dim id As Integer = Convert.ToInt32(row("activity_id"))
        Dim name As String = row("activity_name").ToString()

        Dim dt As DataTable = ReportController.AttendanceReport(id)
        If WordExporter.ExportWithDialog(dt, "Attendance Report: " & name, "Attendance") Then Me.Close()
    End Sub
End Class

Public Class frmExportFilter

    Private Sub frmExportFilter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            For Each cbo As ComboBox In {cboMember, cboPosition, cboStatus}
                cbo.ForeColor = Color.Black
                cbo.BackColor = Color.White
                cbo.DropDownStyle = ComboBoxStyle.DropDownList
            Next

            Dim dt As DataTable = MemberController.GetLookup()
            Dim allRow As DataRow = dt.NewRow()
            allRow("member_id") = ""
            allRow("student_name") = "All"
            dt.Rows.InsertAt(allRow, 0)
            cboMember.DisplayMember = "student_name"
            cboMember.ValueMember = "member_id"
            cboMember.DataSource = dt

            cboPosition.Items.AddRange(Lookups.WithAll(Lookups.Positions))
            cboStatus.Items.AddRange(Lookups.WithAll(Lookups.MemberStatuses))
            cboPosition.SelectedIndex = 0
            cboStatus.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show("Could not load the filter lists:" & vbCrLf & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim memberId As String = If(cboMember.SelectedValue Is Nothing, "", cboMember.SelectedValue.ToString())
        Dim position As String = If(cboPosition.SelectedItem.ToString() = "All", "", cboPosition.SelectedItem.ToString())
        Dim status As String = If(cboStatus.SelectedItem.ToString() = "All", "", cboStatus.SelectedItem.ToString())

        Dim dt As DataTable = ReportController.MembersReport(memberId, position, status)
        If WordExporter.ExportWithDialog(dt, "Organization Members Report", "MembersReport") Then Me.Close()
    End Sub


End Class

Public Class frmAttendance

    Private _roster As DataTable
    Private _loading As Boolean = False

    Private Sub frmAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Navigator.WireSidebar(Me)
        UiHelper.StyleGrid(dgvAttendance)
        UiHelper.SetPlaceholder(txtSearch, "Search attendance records")
        cboActivity.DropDownStyle = ComboBoxStyle.DropDownList

        _loading = True
        cboActivity.DisplayMember = "activity_name"
        cboActivity.ValueMember = "activity_id"
        cboActivity.DataSource = ActivityController.GetLookup()
        cboActivity.SelectedIndex = -1
        _loading = False
        lblSummary.Text = "Present: 0  Absent: 0"
    End Sub

    Private Function SelectedActivityId() As Integer
        If cboActivity.SelectedIndex < 0 Then Return 0
        Return Convert.ToInt32(CType(cboActivity.SelectedItem, DataRowView)("activity_id"))
    End Function

    Private Sub cboActivity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboActivity.SelectedIndexChanged
        If _loading OrElse cboActivity.SelectedIndex < 0 Then Return
        _roster = AttendanceController.GetRoster(SelectedActivityId())
        dgvAttendance.DataSource = _roster.DefaultView

        ' only the Attendance check box can be edited
        dgvAttendance.ReadOnly = False
        dgvAttendance.Columns("ID").ReadOnly = True
        dgvAttendance.Columns("Student Name").ReadOnly = True
        ApplySearch()
        UpdateSummary()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ApplySearch()
    End Sub

    Private Sub ApplySearch()
        If _roster Is Nothing Then Return
        Dim s As String = UiHelper.GetSearch(txtSearch).Replace("'", "''")
        _roster.DefaultView.RowFilter = If(s = "", "", "[Student Name] LIKE '%" & s & "%' OR [ID] LIKE '%" & s & "%'")
    End Sub

    ' commit the check box click immediately so the counter updates
    Private Sub dgvAttendance_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgvAttendance.CurrentCellDirtyStateChanged
        If dgvAttendance.IsCurrentCellDirty Then dgvAttendance.CommitEdit(DataGridViewDataErrorContexts.Commit)
    End Sub

    Private Sub dgvAttendance_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAttendance.CellValueChanged
        UpdateSummary()
    End Sub

    Private Sub UpdateSummary()
        If _roster Is Nothing Then Return
        Dim present As Integer = 0
        For Each r As DataRow In _roster.Rows
            If CBool(r("Attendance")) Then present += 1
        Next
        lblSummary.Text = "Present: " & present & "  Absent: " & (_roster.Rows.Count - present)
    End Sub

    Private Sub btnSaveAttendance_Click(sender As Object, e As EventArgs) Handles btnSaveAttendance.Click
        Dim activityId As Integer = SelectedActivityId()
        If activityId = 0 OrElse _roster Is Nothing Then
            MessageBox.Show("Please select an activity first.", "Attendance", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim records As New List(Of AttendanceRecord)
        For Each r As DataRow In _roster.Rows
            records.Add(New AttendanceRecord() With {
                .MemberId = r("ID").ToString(),
                .StudentName = r("Student Name").ToString(),
                .IsPresent = CBool(r("Attendance"))
            })
        Next
        AttendanceController.Save(activityId, records)
        MessageBox.Show("Attendance saved.", "Attendance", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


End Class

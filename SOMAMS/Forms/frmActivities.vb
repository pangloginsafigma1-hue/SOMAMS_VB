Public Class frmActivities

    Private _editingId As Integer = 0        ' 0 = adding a new activity

    Private Sub frmActivities_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Navigator.WireSidebar(Me)
        UiHelper.StyleGrid(dgvActivities)
        UiHelper.SetPlaceholder(txtSearch, "Search Activities")

        cboStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cboStatus.Items.AddRange(Lookups.ActivityStatuses)
        dtpDate.MinDate = DateTimePicker.MinimumDateTime
        dtpDate.MaxDate = DateTimePicker.MaximumDateTime
        ClearForm()
        LoadActivities()
    End Sub

    Private Sub LoadActivities()
        dgvActivities.DataSource = ActivityController.GetAll(UiHelper.GetSearch(txtSearch))
        If dgvActivities.Columns.Contains("ID") Then dgvActivities.Columns("ID").Visible = False
    End Sub

    Private Sub ClearForm()
        _editingId = 0
        txtActivityName.Clear()
        txtLocation.Clear()
        txtDescription.Clear()
        dtpDate.Value = Date.Today
        cboStatus.SelectedItem = "Upcoming"
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadActivities()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim v As Object = UiHelper.SelectedValue(dgvActivities, "ID")
        If v Is Nothing Then
            MessageBox.Show("Please select an activity to edit.", "Activities", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim a As Activity = ActivityController.GetById(Convert.ToInt32(v))
        If a Is Nothing Then Return
        _editingId = a.ActivityId
        txtActivityName.Text = a.ActivityName
        txtLocation.Text = a.Location
        dtpDate.Value = a.ActivityDate
        cboStatus.SelectedItem = a.Status
        txtDescription.Text = a.Description
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim v As Object = UiHelper.SelectedValue(dgvActivities, "ID")
        If v Is Nothing Then
            MessageBox.Show("Please select an activity to delete.", "Activities", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        If MessageBox.Show("Delete this activity? Its attendance records will also be deleted.",
                           "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            ActivityController.Delete(Convert.ToInt32(v))
            ClearForm()
            LoadActivities()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtActivityName.Text.Trim() = "" OrElse txtLocation.Text.Trim() = "" OrElse cboStatus.SelectedItem Is Nothing Then
            MessageBox.Show("Please enter the activity name, location and status.", "Activities", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim a As New Activity() With {
            .ActivityId = _editingId,
            .ActivityName = txtActivityName.Text.Trim(),
            .Location = txtLocation.Text.Trim(),
            .ActivityDate = dtpDate.Value.Date,
            .Status = cboStatus.SelectedItem.ToString(),
            .Description = txtDescription.Text.Trim()
        }
        Dim wasNew As Boolean = (_editingId = 0)
        ActivityController.Save(a)
        MessageBox.Show(If(wasNew, "Activity added.", "Activity updated."), "Activities", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ClearForm()
        LoadActivities()
    End Sub


End Class

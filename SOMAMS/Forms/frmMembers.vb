Public Class frmMembers

    Private Sub frmMembers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Navigator.WireSidebar(Me)
        UiHelper.StyleGrid(dgvMembers)
        UiHelper.SetPlaceholder(txtSearch, "Search Member")
        LoadMembers()
    End Sub

    Private Sub LoadMembers()
        dgvMembers.DataSource = MemberController.GetAll(UiHelper.GetSearch(txtSearch))
    End Sub

    Private Function SelectedMemberId() As String
        Dim v As Object = UiHelper.SelectedValue(dgvMembers, "ID")
        Return If(v Is Nothing, Nothing, v.ToString())
    End Function

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadMembers()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Navigator.Show(New frmMembershipForm(), Me)           ' blank form = add mode
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim id As String = SelectedMemberId()
        If id Is Nothing Then
            MessageBox.Show("Please select a member to edit.", "Members", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Navigator.Show(New frmMembershipForm() With {.EditMemberId = id}, Me)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim id As String = SelectedMemberId()
        If id Is Nothing Then
            MessageBox.Show("Please select a member to delete.", "Members", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        If MessageBox.Show("Delete member " & id & "? Their attendance records will also be deleted.",
                           "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            MemberController.Delete(id)
            LoadMembers()
        End If
    End Sub

    ' "Export Form" button: exports what the grid currently shows
    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        WordExporter.ExportWithDialog(WordExporter.FromGrid(dgvMembers), "List of Organization Members", "Members")
    End Sub


End Class

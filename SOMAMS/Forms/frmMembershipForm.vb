Public Class frmMembershipForm

    ''' <summary>Set before showing the form to edit a member. Nothing = add a new member.</summary>
    <System.ComponentModel.Browsable(False),
    System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public Property EditMemberId As String


    Private Sub frmMembershipForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Navigator.WireSidebar(Me)
        ' Reset any Min/Max date set in the designer so today's date is always valid
        dtpDateJoined.MinDate = DateTimePicker.MinimumDateTime
        dtpDateJoined.MaxDate = DateTimePicker.MaximumDateTime

        cboPosition.DropDownStyle = ComboBoxStyle.DropDownList
        cboCourse.DropDownStyle = ComboBoxStyle.DropDownList
        cboYearLevel.DropDownStyle = ComboBoxStyle.DropDownList
        cboStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cboPosition.Items.AddRange(Lookups.Positions)
        cboCourse.Items.AddRange(Lookups.Courses)
        cboYearLevel.Items.AddRange(Lookups.YearLevels)
        cboStatus.Items.AddRange(Lookups.MemberStatuses)

        If EditMemberId Is Nothing Then
            cboPosition.SelectedItem = "Member"
            cboStatus.SelectedItem = "Active"
            dtpDateJoined.Value = Date.Today
        Else
            Dim m As Member = MemberController.GetById(EditMemberId)
            If m Is Nothing Then Return
            txtMembershipId.Text = m.MemberId
            txtMembershipId.ReadOnly = True          ' the ID is the primary key
            txtStudentName.Text = m.StudentName
            cboPosition.SelectedItem = m.Position
            cboCourse.SelectedItem = m.Course
            cboYearLevel.SelectedItem = m.YearLevel
            cboStatus.SelectedItem = m.Status
            dtpDateJoined.Value = m.DateJoined
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtMembershipId.Text.Trim() = "" OrElse txtStudentName.Text.Trim() = "" OrElse
           cboPosition.SelectedItem Is Nothing OrElse cboCourse.SelectedItem Is Nothing OrElse
           cboYearLevel.SelectedItem Is Nothing OrElse cboStatus.SelectedItem Is Nothing Then
            MessageBox.Show("Please fill in all fields.", "Membership", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim m As New Member() With {
            .MemberId = txtMembershipId.Text.Trim(),
            .StudentName = txtStudentName.Text.Trim(),
            .Position = cboPosition.SelectedItem.ToString(),
            .Course = cboCourse.SelectedItem.ToString(),
            .YearLevel = cboYearLevel.SelectedItem.ToString(),
            .Status = cboStatus.SelectedItem.ToString(),
            .DateJoined = dtpDateJoined.Value.Date
        }

        If EditMemberId Is Nothing Then
            If MemberController.Exists(m.MemberId) Then
                MessageBox.Show("A member with that ID already exists.", "Membership", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            MemberController.Add(m)
            MessageBox.Show("Member added.", "Membership", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MemberController.Update(m)
            MessageBox.Show("Member updated.", "Membership", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Navigator.Open(Of frmMembers)(Me)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Navigator.Open(Of frmMembers)(Me)
    End Sub


End Class

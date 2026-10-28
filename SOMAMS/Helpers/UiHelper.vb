Public Module UiHelper

    ''' <summary>Gray placeholder text for a TextBox (works on every .NET version).</summary>
    Public Sub SetPlaceholder(tb As TextBox, placeholder As String)
        tb.Text = placeholder
        tb.ForeColor = Color.Gray
        AddHandler tb.Enter, Sub(s, e)
                                 If tb.ForeColor = Color.Gray Then
                                     tb.Text = ""
                                     tb.ForeColor = Color.Black
                                 End If
                             End Sub
        AddHandler tb.Leave, Sub(s, e)
                                 If tb.Text.Trim() = "" Then
                                     tb.Text = placeholder
                                     tb.ForeColor = Color.Gray
                                 End If
                             End Sub
    End Sub

    ''' <summary>Real search text ("" when the placeholder is showing).</summary>
    Public Function GetSearch(tb As TextBox) As String
        If tb.ForeColor = Color.Gray Then Return ""
        Return tb.Text.Trim()
    End Function

    ''' <summary>Common read-only DataGridView settings.</summary>
    Public Sub StyleGrid(dgv As DataGridView)
        dgv.AllowUserToAddRows = False
        dgv.AllowUserToDeleteRows = False
        dgv.MultiSelect = False
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv.AutoGenerateColumns = True
        dgv.ReadOnly = True
    End Sub

    ''' <summary>Value of a column in the currently selected grid row, or Nothing.</summary>
    Public Function SelectedValue(dgv As DataGridView, columnName As String) As Object
        If dgv.CurrentRow Is Nothing Then Return Nothing
        Return dgv.CurrentRow.Cells(columnName).Value
    End Function
End Module

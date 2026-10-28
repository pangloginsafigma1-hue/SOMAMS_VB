Public Class ActivityController

    Private Const SelectCols As String =
        "SELECT activity_id AS `ID`, activity_name AS `Activity`, DATE_FORMAT(activity_date,'%b %d, %Y') AS `Date`, " &
        "location AS `Location`, status AS `Status` FROM activities"

    Public Shared Function GetAll(search As String) As DataTable
        If search = "" Then
            Return Database.ExecuteTable(SelectCols & " ORDER BY activity_date DESC")
        End If
        Return Database.ExecuteTable(SelectCols &
            " WHERE activity_name LIKE @s OR location LIKE @s OR status LIKE @s ORDER BY activity_date DESC",
            Database.P("@s", "%" & search & "%"))
    End Function

    ''' <summary>activity_id + activity_name (for combo boxes).</summary>
    Public Shared Function GetLookup() As DataTable
        Return Database.ExecuteTable("SELECT activity_id, activity_name FROM activities ORDER BY activity_date DESC")
    End Function

    Public Shared Function GetById(id As Integer) As Activity
        Dim dt As DataTable = Database.ExecuteTable("SELECT * FROM activities WHERE activity_id=@id", Database.P("@id", id))
        If dt.Rows.Count = 0 Then Return Nothing
        Dim r As DataRow = dt.Rows(0)
        Return New Activity() With {
            .ActivityId = Convert.ToInt32(r("activity_id")),
            .ActivityName = r("activity_name").ToString(),
            .Location = r("location").ToString(),
            .ActivityDate = Convert.ToDateTime(r("activity_date")),
            .Status = r("status").ToString(),
            .Description = If(IsDBNull(r("description")), "", r("description").ToString())
        }
    End Function

    ''' <summary>Inserts when ActivityId = 0, otherwise updates.</summary>
    Public Shared Sub Save(a As Activity)
        If a.ActivityId = 0 Then
            Database.ExecuteNonQuery(
                "INSERT INTO activities (activity_name, location, activity_date, status, description) VALUES (@n,@l,@d,@s,@desc)",
                Database.P("@n", a.ActivityName), Database.P("@l", a.Location), Database.P("@d", a.ActivityDate.Date),
                Database.P("@s", a.Status), Database.P("@desc", a.Description))
        Else
            Database.ExecuteNonQuery(
                "UPDATE activities SET activity_name=@n, location=@l, activity_date=@d, status=@s, description=@desc WHERE activity_id=@id",
                Database.P("@n", a.ActivityName), Database.P("@l", a.Location), Database.P("@d", a.ActivityDate.Date),
                Database.P("@s", a.Status), Database.P("@desc", a.Description), Database.P("@id", a.ActivityId))
        End If
    End Sub

    Public Shared Sub Delete(id As Integer)
        Database.ExecuteNonQuery("DELETE FROM activities WHERE activity_id=@id", Database.P("@id", id))
    End Sub
End Class

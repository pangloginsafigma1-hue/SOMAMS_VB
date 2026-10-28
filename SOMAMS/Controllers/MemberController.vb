Public Class MemberController

    Private Const SelectCols As String =
        "SELECT member_id AS `ID`, student_name AS `Student Name`, course AS `Course`, " &
        "year_level AS `Year Level`, position AS `Position`, status AS `Status` FROM members"

    Public Shared Function GetAll(search As String) As DataTable
        If search = "" Then
            Return Database.ExecuteTable(SelectCols & " ORDER BY student_name")
        End If
        Return Database.ExecuteTable(SelectCols &
            " WHERE member_id LIKE @s OR student_name LIKE @s OR course LIKE @s OR year_level LIKE @s OR position LIKE @s OR status LIKE @s" &
            " ORDER BY student_name", Database.P("@s", "%" & search & "%"))
    End Function

    ''' <summary>member_id + student_name only (for combo boxes).</summary>
    Public Shared Function GetLookup() As DataTable
        Return Database.ExecuteTable("SELECT member_id, student_name FROM members ORDER BY student_name")
    End Function

    Public Shared Function GetById(id As String) As Member
        Dim dt As DataTable = Database.ExecuteTable("SELECT * FROM members WHERE member_id=@id", Database.P("@id", id))
        If dt.Rows.Count = 0 Then Return Nothing
        Dim r As DataRow = dt.Rows(0)
        Return New Member() With {
            .MemberId = r("member_id").ToString(),
            .StudentName = r("student_name").ToString(),
            .Course = r("course").ToString(),
            .YearLevel = r("year_level").ToString(),
            .Position = r("position").ToString(),
            .Status = r("status").ToString(),
            .DateJoined = Convert.ToDateTime(r("date_joined"))
        }
    End Function

    Public Shared Function Exists(id As String) As Boolean
        Return Convert.ToInt32(Database.ExecuteScalar("SELECT COUNT(*) FROM members WHERE member_id=@id", Database.P("@id", id))) > 0
    End Function

    Public Shared Sub Add(m As Member)
        Database.ExecuteNonQuery(
            "INSERT INTO members (member_id, student_name, course, year_level, position, status, date_joined) " &
            "VALUES (@id,@n,@c,@y,@p,@s,@d)",
            Database.P("@id", m.MemberId), Database.P("@n", m.StudentName), Database.P("@c", m.Course),
            Database.P("@y", m.YearLevel), Database.P("@p", m.Position), Database.P("@s", m.Status),
            Database.P("@d", m.DateJoined.Date))
    End Sub

    Public Shared Sub Update(m As Member)
        Database.ExecuteNonQuery(
            "UPDATE members SET student_name=@n, course=@c, year_level=@y, position=@p, status=@s, date_joined=@d " &
            "WHERE member_id=@id",
            Database.P("@id", m.MemberId), Database.P("@n", m.StudentName), Database.P("@c", m.Course),
            Database.P("@y", m.YearLevel), Database.P("@p", m.Position), Database.P("@s", m.Status),
            Database.P("@d", m.DateJoined.Date))
    End Sub

    Public Shared Sub Delete(id As String)
        Database.ExecuteNonQuery("DELETE FROM members WHERE member_id=@id", Database.P("@id", id))
    End Sub
End Class

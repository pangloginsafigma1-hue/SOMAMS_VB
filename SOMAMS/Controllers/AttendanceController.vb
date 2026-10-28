
Imports MySqlConnector

Public Class AttendanceController

    ''' <summary>
    ''' All ACTIVE members for an activity with a Boolean "Attendance" column
    ''' (True = present). Boolean columns show as check boxes in the DataGridView.
    ''' </summary>
    Public Shared Function GetRoster(activityId As Integer) As DataTable
        Dim raw As DataTable = Database.ExecuteTable(
            "SELECT m.member_id, m.student_name, COALESCE(a.is_present,0) AS is_present " &
            "FROM members m LEFT JOIN attendance a ON a.member_id=m.member_id AND a.activity_id=@a " &
            "WHERE m.status='Active' ORDER BY m.student_name", Database.P("@a", activityId))

        Dim result As New DataTable()
        result.Columns.Add("ID", GetType(String))
        result.Columns.Add("Student Name", GetType(String))
        result.Columns.Add("Attendance", GetType(Boolean))
        For Each r As DataRow In raw.Rows
            result.Rows.Add(r("member_id").ToString(), r("student_name").ToString(), Convert.ToInt32(r("is_present")) = 1)
        Next
        Return result
    End Function

    ''' <summary>Saves every row in one transaction (insert or update).</summary>
    Public Shared Sub Save(activityId As Integer, records As IEnumerable(Of AttendanceRecord))
        Using conn As MySqlConnection = Database.GetConnection()
            conn.Open()
            Using tx As MySqlTransaction = conn.BeginTransaction()
                Try
                    For Each rec As AttendanceRecord In records
                        Using cmd As New MySqlCommand(
                            "INSERT INTO attendance (activity_id, member_id, is_present) VALUES (@a,@m,@p) " &
                            "ON DUPLICATE KEY UPDATE is_present=@p", conn, tx)
                            cmd.Parameters.AddWithValue("@a", activityId)
                            cmd.Parameters.AddWithValue("@m", rec.MemberId)
                            cmd.Parameters.AddWithValue("@p", If(rec.IsPresent, 1, 0))
                            cmd.ExecuteNonQuery()
                        End Using
                    Next
                    tx.Commit()
                Catch
                    tx.Rollback()
                    Throw
                End Try
            End Using
        End Using
    End Sub
End Class

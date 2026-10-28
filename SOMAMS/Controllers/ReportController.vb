Imports System.Text

Imports MySqlConnector

''' <summary>Builds the tables that get exported to Word.</summary>
Public Class ReportController

    ''' <summary>Pass Nothing (or "") for any filter you don't want.</summary>
    Public Shared Function MembersReport(memberId As String, position As String, status As String) As DataTable
        Dim sql As New StringBuilder(
            "SELECT member_id AS `ID`, student_name AS `Student Name`, course AS `Course`, year_level AS `Year Level`, " &
            "position AS `Position`, status AS `Status`, DATE_FORMAT(date_joined,'%b %d, %Y') AS `Date Joined` " &
            "FROM members WHERE 1=1")
        Dim ps As New List(Of MySqlParameter)

        If Not String.IsNullOrEmpty(memberId) Then
            sql.Append(" AND member_id=@id")
            ps.Add(Database.P("@id", memberId))
        End If
        If Not String.IsNullOrEmpty(position) Then
            sql.Append(" AND position=@pos")
            ps.Add(Database.P("@pos", position))
        End If
        If Not String.IsNullOrEmpty(status) Then
            sql.Append(" AND status=@st")
            ps.Add(Database.P("@st", status))
        End If
        sql.Append(" ORDER BY student_name")
        Return Database.ExecuteTable(sql.ToString(), ps.ToArray())
    End Function

    Public Shared Function ActivitiesReport(fromDate As Date, toDate As Date) As DataTable
        Return Database.ExecuteTable(
            "SELECT activity_name AS `Activity`, DATE_FORMAT(activity_date,'%b %d, %Y') AS `Date`, location AS `Location`, " &
            "status AS `Status`, COALESCE(description,'') AS `Description` FROM activities " &
            "WHERE activity_date BETWEEN @f AND @t ORDER BY activity_date",
            Database.P("@f", fromDate.Date), Database.P("@t", toDate.Date))
    End Function

    Public Shared Function AttendanceReport(activityId As Integer) As DataTable
        Return Database.ExecuteTable(
            "SELECT m.member_id AS `ID`, m.student_name AS `Student Name`, m.course AS `Course`, " &
            "CASE WHEN a.is_present=1 THEN 'Present' ELSE 'Absent' END AS `Attendance` " &
            "FROM members m LEFT JOIN attendance a ON a.member_id=m.member_id AND a.activity_id=@a " &
            "WHERE m.status='Active' ORDER BY m.student_name", Database.P("@a", activityId))
    End Function
End Class

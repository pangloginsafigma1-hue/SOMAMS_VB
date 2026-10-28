Public Class DashboardController

    Public Shared Function CountMembers() As Integer
        Return Convert.ToInt32(Database.ExecuteScalar("SELECT COUNT(*) FROM members"))
    End Function

    Public Shared Function CountActivities() As Integer
        Return Convert.ToInt32(Database.ExecuteScalar("SELECT COUNT(*) FROM activities"))
    End Function

    Public Shared Function GetUpcomingActivities() As DataTable
        Return Database.ExecuteTable(
            "SELECT activity_name, activity_date, location FROM activities " &
            "WHERE status='Upcoming' AND activity_date >= CURDATE() ORDER BY activity_date LIMIT 20")
    End Function
End Class

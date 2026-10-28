''' <summary>Fixed lists used by the combo boxes. Edit freely.</summary>
Public Module Lookups
    Public ReadOnly Positions As String() = {"President", "Vice President", "Secretary", "Treasurer", "Auditor", "Public Information Officer", "Representative", "Member"}
    Public ReadOnly Courses As String() = {"BSCS", "BSIT", "BSIS"}
    Public ReadOnly YearLevels As String() = {"1st Year", "2nd Year", "3rd Year", "4th Year"}
    Public ReadOnly MemberStatuses As String() = {"Active", "Inactive"}
    Public ReadOnly ActivityStatuses As String() = {"Upcoming", "Ongoing", "Completed", "Cancelled"}

    ''' <summary>Returns the list with "All" added at the top (used by filters).</summary>
    Public Function WithAll(items As String()) As String()
        Dim l As New List(Of String)({"All"})
        l.AddRange(items)
        Return l.ToArray()
    End Function
End Module

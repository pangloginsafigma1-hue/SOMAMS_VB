Public Class Membership
    Public Property MembershipID As Integer
    Public Property StudentID As String
    Public Property Position As String
    Public Property DateJoined As Date
    Public Property Status As String
End Class
Public Class Course
    Public Property CourseID As Integer
    Public Property CourseName As String
End Class

Public Class YearLevel
    Public Property YearLevelID As Integer
    Public Property LevelName As String ' e.g., "1st Year", "2nd Year"
End Class

Public Class Position
    Public Property PositionID As Integer
    Public Property PositionName As String ' e.g., "President", "Member", "Secretary"
End Class
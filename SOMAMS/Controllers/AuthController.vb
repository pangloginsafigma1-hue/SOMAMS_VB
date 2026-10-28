Public Class AuthController

    ''' <summary>Returns the Admin if the login is correct, otherwise Nothing.</summary>
    Public Shared Function Login(username As String, password As String) As Admin
        Dim dt As DataTable = Database.ExecuteTable("SELECT * FROM admins WHERE username=@u LIMIT 1", Database.P("@u", username))
        If dt.Rows.Count = 0 Then Return Nothing
        Dim r As DataRow = dt.Rows(0)
        If Not BCrypt.Net.BCrypt.Verify(password, r("password_hash").ToString()) Then Return Nothing
        Return MapAdmin(r)
    End Function

    ''' <summary>Creates admin / admin123 if the admins table is empty.</summary>
    Public Shared Sub EnsureDefaultAdmin()
        Dim count As Integer = Convert.ToInt32(Database.ExecuteScalar("SELECT COUNT(*) FROM admins"))
        If count > 0 Then Return
        Database.ExecuteNonQuery(
            "INSERT INTO admins (full_name, username, email, password_hash) VALUES (@n,@u,@e,@h)",
            Database.P("@n", "Administrator"), Database.P("@u", "admin"),
            Database.P("@e", "admin@example.com"),
            Database.P("@h", BCrypt.Net.BCrypt.HashPassword("admin123")))
    End Sub

    Public Shared Function FindByEmail(email As String) As Admin
        Dim dt As DataTable = Database.ExecuteTable("SELECT * FROM admins WHERE email=@e LIMIT 1", Database.P("@e", email))
        If dt.Rows.Count = 0 Then Return Nothing
        Return MapAdmin(dt.Rows(0))
    End Function

    Public Shared Sub ResetPassword(adminId As Integer, newPassword As String)
        Database.ExecuteNonQuery("UPDATE admins SET password_hash=@h WHERE admin_id=@id",
            Database.P("@h", BCrypt.Net.BCrypt.HashPassword(newPassword)), Database.P("@id", adminId))
    End Sub

    Friend Shared Function MapAdmin(r As DataRow) As Admin
        Dim a As New Admin() With {
            .AdminId = Convert.ToInt32(r("admin_id")),
            .FullName = r("full_name").ToString(),
            .Username = r("username").ToString(),
            .Email = r("email").ToString(),
            .PasswordHash = r("password_hash").ToString()
        }
        If Not IsDBNull(r("photo")) Then a.Photo = CType(r("photo"), Byte())
        Return a
    End Function
End Class

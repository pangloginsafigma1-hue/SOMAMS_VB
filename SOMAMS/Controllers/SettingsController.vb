Public Class SettingsController

    Public Shared Function GetById(id As Integer) As Admin
        Dim dt As DataTable = Database.ExecuteTable("SELECT * FROM admins WHERE admin_id=@id", Database.P("@id", id))
        If dt.Rows.Count = 0 Then Return Nothing
        Return AuthController.MapAdmin(dt.Rows(0))
    End Function

    Public Shared Function UsernameTaken(username As String, exceptAdminId As Integer) As Boolean
        Return Convert.ToInt32(Database.ExecuteScalar(
            "SELECT COUNT(*) FROM admins WHERE username=@u AND admin_id<>@id",
            Database.P("@u", username), Database.P("@id", exceptAdminId))) > 0
    End Function

    ''' <summary>Saves profile + photo. newPassword = "" keeps the old password.</summary>
    Public Shared Sub Update(a As Admin, newPassword As String)
        If newPassword = "" Then
            Database.ExecuteNonQuery(
                "UPDATE admins SET full_name=@n, username=@u, email=@e, photo=@p WHERE admin_id=@id",
                Database.P("@n", a.FullName), Database.P("@u", a.Username), Database.P("@e", a.Email),
                Database.P("@p", a.Photo), Database.P("@id", a.AdminId))
        Else
            Database.ExecuteNonQuery(
                "UPDATE admins SET full_name=@n, username=@u, email=@e, photo=@p, password_hash=@h WHERE admin_id=@id",
                Database.P("@n", a.FullName), Database.P("@u", a.Username), Database.P("@e", a.Email),
                Database.P("@p", a.Photo), Database.P("@h", BCrypt.Net.BCrypt.HashPassword(newPassword)),
                Database.P("@id", a.AdminId))
        End If
    End Sub
End Class

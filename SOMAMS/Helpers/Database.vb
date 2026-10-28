
Imports MySqlConnector

''' <summary>Single place for the MySQL connection and query helpers.</summary>
Public Module Database

    ' ====== EDIT THESE VALUES TO MATCH YOUR MYSQL WORKBENCH CONNECTION ======
    Private Const Server As String = "localhost"
    Private Const Port As String = "3306"
    Private Const DbName As String = "somams_db"
    Private Const UserId As String = "root"
    Private Const Password As String = "mich09252005!"
    ' =========================================================================

    Private ReadOnly ConnString As String =
        $"Server={Server};Port={Port};Database={DbName};Uid={UserId};Pwd={Password};SslMode=None;AllowPublicKeyRetrieval=True;"

    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection(ConnString)
    End Function

    Public Function TestConnection(ByRef errorMessage As String) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
            End Using
            Return True
        Catch ex As Exception
            errorMessage = ex.Message
            Return False
        End Try
    End Function

    ''' <summary>Creates a parameter. Nothing becomes NULL in the database.</summary>
    Public Function P(name As String, value As Object) As MySqlParameter
        Return New MySqlParameter(name, If(value, DBNull.Value))
    End Function

    Public Function ExecuteTable(sql As String, ParamArray args() As MySqlParameter) As DataTable
        Dim dt As New DataTable()
        Using conn As MySqlConnection = GetConnection()
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddRange(args)
                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

    Public Function ExecuteNonQuery(sql As String, ParamArray args() As MySqlParameter) As Integer
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddRange(args)
                Return cmd.ExecuteNonQuery()
            End Using
        End Using
    End Function

    Public Function ExecuteScalar(sql As String, ParamArray args() As MySqlParameter) As Object
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddRange(args)
                Return cmd.ExecuteScalar()
            End Using
        End Using
    End Function
End Module

Imports Microsoft.EntityFrameworkCore

Public Module DbConfig
    ' Change user, password, port and database to match your MySQL Workbench connection
    Public Const ConnectionString As String =
        "Server=localhost;Port=3306;Database=somams;User=root;Password=mich09252005!;"

    ' Change to the version from SELECT VERSION();
    Public ReadOnly ServerVer As MySqlServerVersion = New MySqlServerVersion(New Version(8, 0, 36))
End Module


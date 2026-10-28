''' <summary>
''' Reads settings (database login, e-mail account) from "somams.config.ini" next to the program,
''' so no passwords are written inside the source code.
''' </summary>
Public Module AppConfig

    Private ReadOnly _values As Dictionary(Of String, String) = LoadFile()

    Private Function LoadFile() As Dictionary(Of String, String)
        Dim d As New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase)
        Try
            Dim path As String = IO.Path.Combine(AppContext.BaseDirectory, "somams.config.ini")
            If IO.File.Exists(path) Then
                For Each line As String In IO.File.ReadAllLines(path)
                    Dim t As String = line.Trim()
                    If t = "" OrElse t.StartsWith("#") OrElse t.StartsWith(";") Then Continue For
                    Dim i As Integer = t.IndexOf("="c)
                    If i > 0 Then d(t.Substring(0, i).Trim()) = t.Substring(i + 1).Trim()
                Next
            End If
        Catch
            ' a missing/unreadable file simply means "use the defaults"
        End Try
        Return d
    End Function

    ''' <summary>Value for a key, or the fallback when the key is missing/empty.</summary>
    Public Function GetValue(key As String, Optional fallback As String = "") As String
        Dim v As String = Nothing
        If _values.TryGetValue(key, v) AndAlso v <> "" Then Return v
        Return fallback
    End Function
End Module

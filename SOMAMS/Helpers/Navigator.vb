''' <summary>Opens forms and wires the left sidebar buttons on every main form.</summary>
Public Module Navigator

    ''' <summary>Opens form T and closes the current one.</summary>
    Public Sub Open(Of T As {Form, New})(current As Form)
        If TypeOf current Is T Then Return      ' already on this page
        [Show](New T(), current)
    End Sub

    ''' <summary>Shows an already-created form and closes the current one.</summary>
    Public Sub [Show](target As Form, current As Form)
        If current.WindowState = FormWindowState.Maximized Then
            target.WindowState = FormWindowState.Maximized
        Else
            target.StartPosition = FormStartPosition.CenterScreen
        End If
        target.Show()
        current.Close()
    End Sub

    ''' <summary>
    ''' Call once in each main form's Load event. Looks for buttons named
    ''' btnDashboard, btnMembers, btnActivities, btnAttendance, btnMembership,
    ''' btnReports, btnSettings, btnParticipation and btnLogout.
    ''' </summary>
    Public Sub WireSidebar(form As Form)
        Hook(form, "btnNavDashboard", Sub() Open(Of frmDashboard)(form))
        Hook(form, "btnNavMembers", Sub() Open(Of frmMembers)(form))
        Hook(form, "btnNavActivities", Sub() Open(Of frmActivities)(form))
        Hook(form, "btnNavAttendance", Sub() Open(Of frmAttendance)(form))
        Hook(form, "btnNavMembership", Sub() Open(Of frmMembershipForm)(form))
        Hook(form, "btnNavReports", Sub() Open(Of frmReports)(form))
        Hook(form, "btnNavSettings", Sub() Open(Of frmSettings)(form))
        Hook(form, "btnLogout", Sub() ConfirmLogout(form))
    End Sub

    Private Sub Hook(form As Form, controlName As String, action As Action)
        Dim found As Control() = form.Controls.Find(controlName, True)
        If found.Length > 0 Then
            AddHandler found(0).Click, Sub(s, e) action()
        End If
    End Sub

    ''' <summary>Confirm -> "Logging you out..." -> "Logged out successfully" -> login.</summary>
    Public Sub ConfirmLogout(current As Form)
        Using dlg As New frmConfirmLogout()
            If dlg.ShowDialog(current) <> DialogResult.Yes Then Return
        End Using
        Using wait As New frmLoggingOut()
            wait.ShowDialog(current)
        End Using
        Session.Clear()
        Dim done As New frmLoggedOut()
        done.StartPosition = FormStartPosition.CenterScreen
        done.Show()
        current.Close()
    End Sub
End Module

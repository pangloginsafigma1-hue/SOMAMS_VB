Imports System.Net
Imports System.Net.Mail

''' <summary>Sends the "forgot password" verification code by SMTP.</summary>
Public Module EmailService

    ' ====== EDIT: use a Gmail account + a Google "App Password" (not your normal password) ======
    Private Const SmtpHost As String = "smtp.gmail.com"
    Private Const SmtpPort As Integer = 587
    Private Const SenderEmail As String = "michiepatac@gmail.com"
    Private Const SenderAppPassword As String = "xlhc snll bpvq sqau"
    ' ======================================================================================

    Public Function SendCode(toEmail As String, code As String, ByRef errorMessage As String) As Boolean
        Try
            Using msg As New MailMessage(SenderEmail, toEmail)
                msg.Subject = "SOMAMS Password Reset Code"
                msg.Body = "Your SOMAMS verification code is: " & code & vbCrLf & "If you did not request this, ignore this email."
                Using smtp As New SmtpClient(SmtpHost, SmtpPort)
                    smtp.EnableSsl = True
                    smtp.Credentials = New NetworkCredential(SenderEmail, SenderAppPassword)
                    smtp.Send(msg)
                End Using
            End Using
            Return True
        Catch ex As Exception
            errorMessage = ex.Message
            Return False
        End Try
    End Function
End Module

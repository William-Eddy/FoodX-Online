Imports System.Net.Mail
Public Class Emails

    Dim Smtp_Server As New SmtpClient
    Dim e_mail As New MailMessage()
    Dim body As String

    Public Sub setEmailAccountSettings()

        Smtp_Server.UseDefaultCredentials = False
        Smtp_Server.Credentials = New Net.NetworkCredential("donotreply@innodex.dev", "Up3RdgdXFYk")
        Smtp_Server.Port = 26
        Smtp_Server.EnableSsl = False
        Smtp_Server.Host = "smtp.innodex.dev"

    End Sub

    Public Sub createNewEmail()

        e_mail = New MailMessage()
        e_mail.From = New MailAddress("donotreply@innodex.dev")
        e_mail.IsBodyHtml = True

    End Sub

    Public Sub setRecipient(recipient As String)

        e_mail.To.Add(recipient)

    End Sub

    Public Sub setSubject(subject As String)

        e_mail.Subject = subject

    End Sub

    Public Sub setToBody()

        e_mail.Body = body

    End Sub

    Public Sub sendEmail()

        Smtp_Server.Send(e_mail)
        MsgBox("Mail Sent")

    End Sub

    Public Sub addToBody(body)

        Me.body &= body

    End Sub

    Public Sub addHTMLFileToBody(filePath)

        addToBody(System.IO.File.ReadAllText(filePath))

    End Sub

End Class

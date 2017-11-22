
Imports System.Net.Mail

Public Class EmailUtils

    Public Shared Function SendMail(ByVal sFrom As String,
                                    ByVal sTo As String,
                                    ByVal sCC As String,
                                    ByVal sBCC As String,
                                    ByVal sReplyTo As String,
                                    ByVal sServer As String,
                                    ByVal iPort As Integer,
                                    ByVal sSubject As String,
                                    ByVal sMessage As String,
                                    ByVal bEnableSSL As Boolean,
                                    ByVal iMailSendTimeoutSeconds As Integer,
                                    ByVal sAttachmentFilePath As String) As Boolean

        Dim b As Boolean = False
        Dim mail As MailMessage = Nothing
        Dim smtp As SmtpClient = Nothing
        Dim attachment As Attachment = Nothing

        Try
            'init
            '------------------------
            mail = New MailMessage(sFrom, sTo, sSubject, sMessage)
            smtp = New SmtpClient

            'set attachment
            '------------------------
            If Not String.IsNullOrEmpty(sAttachmentFilePath) Then
                attachment = New Attachment(sAttachmentFilePath)
                mail.Attachments.Add(attachment)
            End If

            'set smtp
            '------------------------
            smtp.Host = sServer
            If iPort > 0 Then smtp.Port = iPort
            smtp.EnableSsl = bEnableSSL
            smtp.Timeout = iMailSendTimeoutSeconds * 1000
            'smtp.Timeout = 180 * 1000

            'send mail
            '------------------------
            smtp.Send(mail)
            b = True

        Catch ex As Exception
            b = False
            Throw ex
        Finally
            mail = Nothing
            smtp.Dispose()
            smtp = Nothing
        End Try

        Return b

    End Function

End Class

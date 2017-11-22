
Imports System.Text

Public Class EmailSettings
    Implements ISettings

    Public Property EmailReceiverAddress As String
    Public Property EmailServerName As String
    Public Property EmailServerPort As Integer
    Public Property EmailEnableSSL As Boolean
    Public Property EmailFromAddress As String
    Public Property EmailSendTimeoutSeconds As Integer

    Public Overrides Function ToString() As String Implements ISettings.ToString

        Dim sb As StringBuilder = Nothing

        Try
            sb = New StringBuilder

            sb.AppendLine("EmailEnableSSL: " & Me.EmailEnableSSL)
            sb.AppendLine("EmailFromAddress: " & Me.EmailFromAddress)
            sb.AppendLine("EmailReceiverAddress: " & Me.EmailReceiverAddress)
            sb.AppendLine("EmailSendTimeoutSeconds: " & Me.EmailSendTimeoutSeconds)
            sb.AppendLine("EmailServerName: " & Me.EmailServerName)
            sb.AppendLine("EmailServerPort: " & Me.EmailServerPort)

        Catch ex As Exception
            Throw ex
        Finally
        End Try

        Return sb.ToString

    End Function

End Class

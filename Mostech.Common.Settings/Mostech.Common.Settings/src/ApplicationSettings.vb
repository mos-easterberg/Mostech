
Imports System.Text

Public MustInherit Class ApplicationSettings
    Implements ISettings

    Public Property ApplicationName As String

    Public Overrides Function ToString() As String Implements ISettings.ToString

        Dim sb As StringBuilder = Nothing

        Try
            sb = New StringBuilder
            sb.AppendLine("ApplicationName: " & Me.ApplicationName)
        Catch ex As Exception
            Throw ex
        Finally
        End Try

        Return sb.ToString

    End Function

End Class

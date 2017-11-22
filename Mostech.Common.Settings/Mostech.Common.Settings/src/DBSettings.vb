
Imports System.Text

Public Class DBSettings
    Implements ISettings

    Public Property DBTableOwner As String
    Public Property DBDataSource As String
    Public Property DBInitialCatalog As String
    Public Property DBUserId As String
    Public Property DBPassword As String

    Public Overrides Function ToString() As String Implements ISettings.ToString

        Dim sb As StringBuilder = Nothing

        Try
            sb = New StringBuilder

            sb.AppendLine("DBDataSource: " & Me.DBDataSource)
            sb.AppendLine("DBInitialCatalog: " & Me.DBInitialCatalog)
            sb.AppendLine("DBPassword: " & Me.DBPassword)
            sb.AppendLine("DBTableOwner: " & Me.DBTableOwner)
            sb.AppendLine("DBUserId: " & Me.DBUserId)

        Catch ex As Exception
            Throw ex
        Finally
        End Try

        Return sb.ToString

    End Function

End Class


Imports Mostech.Common
Imports System.Text

Public Class DBAccess

    Public Property ConnectionString As String
    Public Property DBVendor As Toolbox.DatabaseUtils.DBVendor
    Public Property DBServer As String
    Public Property DBPort As Integer
    Public Property DBName As String
    Public Property DBUserID As String
    Public Property DBPassword As String
    Public Property DBTimeOutSeconds As Integer

    Public Sub New()
    End Sub

    Public Sub New(ByVal ConnectionString As String,
                   ByVal DBVendor As Toolbox.DatabaseUtils.DBVendor,
                   ByVal DBServer As String,
                   ByVal DBPort As Integer,
                   ByVal DBName As String,
                   ByVal DBUserID As String,
                   ByVal DBPassword As String,
                   ByVal DBTimeOutSeconds As Integer)

        Me.ConnectionString = ConnectionString
        Me.DBVendor = DBVendor
        Me.DBServer = DBServer
        Me.DBPort = DBPort
        Me.DBName = DBName
        Me.DBUserID = DBUserID
        Me.DBPassword = DBPassword
        Me.DBTimeOutSeconds = DBTimeOutSeconds

    End Sub

    Public Overrides Function ToString() As String

        Dim sb As New StringBuilder

        Try
            sb.AppendLine("ConnectionString: " & Me.ConnectionString)
            sb.AppendLine("DBVendor: " & Me.DBVendor)
            sb.AppendLine("DBServer: " & Me.DBServer)
            sb.AppendLine("DBPort: " & Me.DBPort)
            sb.AppendLine("DBName: " & Me.DBName)
            sb.AppendLine("DBUserID: " & Me.DBUserID)
            sb.AppendLine("DBPassword: " & Me.DBPassword)
            sb.AppendLine("DBTimeOutSeconds: " & Me.DBTimeOutSeconds)
        Catch ex As Exception
        End Try

        Return sb.ToString

    End Function

End Class



Imports System.Text

Public Class License

    Public Property Company As String
    Public Property StartDate As Date
    Public Property EndDate As Date
    Public Property NrOfLicensedUsers As Integer

    Public Sub New()
    End Sub

    Public Sub New(ByVal Company As String, ByVal StartDate As Date, ByVal EndDate As Date, ByVal NrOfLicensedUsers As Integer)

        Me.Company = Company
        Me.StartDate = StartDate
        Me.EndDate = EndDate
        Me.NrOfLicensedUsers = NrOfLicensedUsers

    End Sub

    Public Overrides Function ToString() As String

        Dim sb As New StringBuilder

        Try
            sb.AppendLine("Company: " & Me.Company)
            sb.AppendLine("StartDate: " & Me.StartDate)
            sb.AppendLine("EndDate: " & Me.EndDate)
            sb.AppendLine("NrOfLicensedUsers: " & Me.NrOfLicensedUsers)
        Catch ex As Exception
        End Try

        Return sb.ToString

    End Function

End Class


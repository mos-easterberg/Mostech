
Imports System.Text

Public Class Job
    Inherits Entity
    Implements IEntity

    Public Property Customer As String
    Public Property Category As String
    Public Property JobDate As String
    Public Property StartTime As String
    Public Property EndTime As String
    Public Property Duration As Integer
    Public Property Stylist As String
    Public Property PriceInclVAT As Decimal
    Public Property VATPercentage As Integer
    Public Property PriceExclVAT As Decimal
    Public Property Description As String

    Public Sub New()
    End Sub

    Public Sub New(ByVal Customer As String, ByVal Category As String, ByVal JobDate As String, ByVal StartTime As String, ByVal EndTime As String, ByVal Duration As Integer, ByVal Stylist As String, ByVal PriceInclVAT As Decimal, ByVal VATPercentage As Integer, ByVal PriceExclVAT As Decimal, ByVal Description As String)

        Me.Customer = Customer
        Me.Category = Category
        Me.JobDate = JobDate
        Me.StartTime = StartTime
        Me.EndTime = EndTime
        Me.Duration = Duration
        Me.Stylist = Stylist
        Me.PriceInclVAT = PriceInclVAT
        Me.VATPercentage = VATPercentage
        Me.PriceExclVAT = PriceExclVAT
        Me.Description = Description

    End Sub

    Public Overrides Function ToString() As String Implements IEntity.ToString

        Dim sb As New StringBuilder

        Try
            sb.AppendLine("ID: " & Me.ID)
            sb.AppendLine("Customer: " & Me.Customer)
            sb.AppendLine("Category: " & Me.Category)
            sb.AppendLine("JobDate: " & Me.JobDate)
            sb.AppendLine("StartTime: " & Me.StartTime)
            sb.AppendLine("EndTime: " & Me.EndTime)
            sb.AppendLine("Duration: " & Me.Duration)
            sb.AppendLine("Stylist: " & Me.Stylist)
            sb.AppendLine("PriceInclVAT: " & Me.PriceInclVAT)
            sb.AppendLine("VATPercentage: " & Me.VATPercentage)
            sb.AppendLine("PriceExclVAT: " & Me.PriceExclVAT)
            sb.AppendLine("Description: " & Me.Description)
        Catch ex As Exception
        End Try

        Return sb.ToString

    End Function

End Class


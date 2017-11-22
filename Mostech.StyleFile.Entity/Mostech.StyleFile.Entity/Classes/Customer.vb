
Imports System.Text

Public Class Customer
    Inherits Entity
    Implements IEntity

    Public Property Category As String
    Public Property FirstName As String
    Public Property LastName As String
    Public Property DateOfBirth As String
    Public Property Address As String
    Public Property District As String
    Public Property PostalCode As Integer
    Public Property City As String
    Public Property TelephoneMobile As String
    Public Property TelephoneHome As String
    Public Property TelephoneWork As String
    Public Property EmailAddress As String
    Public Property MiscInfo As String
    Public Property Allergy As String
    Public Property AllowSMS As Boolean
    Public Property AllowEmail As Boolean
    Public Property AllowMail As Boolean

    Public Sub New()
    End Sub

    Public Sub New(ByVal Category As String,
                   ByVal FirstName As String,
                   ByVal LastName As String,
                   ByVal DateOfBirth As String,
                   ByVal Address As String,
                   ByVal District As String,
                   ByVal PostalCode As Integer,
                   ByVal City As String,
                   ByVal TelephoneMobile As String,
                   ByVal TelephoneHome As String,
                   ByVal TelephoneWork As String,
                   ByVal EmailAddress As String,
                   ByVal MiscInfo As String,
                   ByVal Allergy As String,
                   ByVal AllowSMS As Boolean,
                   ByVal AllowEmail As Boolean,
                   ByVal AllowMail As Boolean)

        Me.Category = Category
        Me.FirstName = FirstName
        Me.LastName = LastName
        Me.DateOfBirth = DateOfBirth
        Me.Address = Address
        Me.District = District
        Me.PostalCode = PostalCode
        Me.City = City
        Me.TelephoneMobile = TelephoneMobile
        Me.TelephoneHome = TelephoneHome
        Me.TelephoneWork = TelephoneWork
        Me.EmailAddress = EmailAddress
        Me.MiscInfo = MiscInfo
        Me.Allergy = Allergy
        Me.AllowSMS = AllowSMS
        Me.AllowEmail = AllowEmail
        Me.AllowMail = AllowMail

    End Sub

    Public Overrides Function ToString() As String Implements IEntity.ToString

        Dim sb As New StringBuilder

        Try
            sb.AppendLine("Category: " & Me.Category)
            sb.AppendLine("FirstName: " & Me.FirstName)
            sb.AppendLine("LastName: " & Me.LastName)
            sb.AppendLine("DateOfBirth: " & Me.DateOfBirth)
            sb.AppendLine("Address: " & Me.Address)
            sb.AppendLine("PostalCode: " & Me.PostalCode)
            sb.AppendLine("City: " & Me.City)
            sb.AppendLine("TelephoneMobile: " & Me.TelephoneMobile)
            sb.AppendLine("TelephoneHome: " & Me.TelephoneHome)
            sb.AppendLine("TelephoneWork: " & Me.TelephoneWork)
            sb.AppendLine("EmailAddress: " & Me.EmailAddress)
            sb.AppendLine("MiscInfo: " & Me.MiscInfo)
            sb.AppendLine("Allergy: " & Me.Allergy)
            sb.AppendLine("AllowSMS: " & Me.AllowSMS)
            sb.AppendLine("AllowEmail: " & Me.AllowEmail)
            sb.AppendLine("AllowMail: " & Me.AllowMail)
        Catch ex As Exception
        End Try

        Return sb.ToString

    End Function

End Class


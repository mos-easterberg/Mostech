
Imports System.Text

Public Class Stylist
    Inherits Entity
    Implements IEntity

    Public Property Employment As String
    Public Property Profession As String
    Public Property FirstName As String
    Public Property LastName As String
    Public Property Address As String
    Public Property PostalCode As Integer
    Public Property City As String
    Public Property TelephoneMobile As String
    Public Property TelephoneHome As String
    Public Property TelephoneWork As String
    Public Property EmailAddress As String
    Public Property MiscInfo As String
    Public Property Allergy As String

    Public Sub New()
    End Sub

    Public Sub New(ByVal Employment As String,
                   ByVal Profession As String,
                   ByVal FirstName As String,
                   ByVal LastName As String,
                   ByVal Address As String,
                   ByVal PostalCode As Integer,
                   ByVal City As String,
                   ByVal TelephoneMobile As String,
                   ByVal TelephoneHome As String,
                   ByVal TelephoneWork As String,
                   ByVal EmailAddress As String,
                   ByVal MiscInfo As String, ByVal Allergy As String)

        Me.Employment = Employment
        Me.Profession = Profession
        Me.FirstName = FirstName
        Me.LastName = LastName
        Me.Address = Address
        Me.PostalCode = PostalCode
        Me.City = City
        Me.TelephoneMobile = TelephoneMobile
        Me.TelephoneHome = TelephoneHome
        Me.TelephoneWork = TelephoneWork
        Me.EmailAddress = EmailAddress
        Me.MiscInfo = MiscInfo
        Me.Allergy = Allergy

    End Sub

    Public Overrides Function ToString() As String Implements IEntity.ToString

        Dim sb As New StringBuilder

        Try
            sb.AppendLine("Employment: " & Me.Employment)
            sb.AppendLine("Profession: " & Me.Profession)
            sb.AppendLine("FirstName: " & Me.FirstName)
            sb.AppendLine("LastName: " & Me.LastName)
            sb.AppendLine("Address: " & Me.Address)
            sb.AppendLine("PostalCode: " & Me.PostalCode)
            sb.AppendLine("City: " & Me.City)
            sb.AppendLine("TelephoneMobile: " & Me.TelephoneMobile)
            sb.AppendLine("TelephoneHome: " & Me.TelephoneHome)
            sb.AppendLine("TelephoneWork: " & Me.TelephoneWork)
            sb.AppendLine("EmailAddress: " & Me.EmailAddress)
            sb.AppendLine("MiscInfo: " & Me.MiscInfo)
            sb.AppendLine("Allergy: " & Me.Allergy)
        Catch ex As Exception
        End Try

        Return sb.ToString

    End Function

End Class


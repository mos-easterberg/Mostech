
Imports System.Text

Public Class Category
    Inherits Entity
    Implements IEntity

    Public Property Type As String
    Public Property Value As String

    Public Sub New()
    End Sub

    Public Sub New(ByVal Type As String,
                   ByVal Value As String,
                   ByVal Active As Boolean,
                   ByVal [Default] As Boolean)

        Me.Type = Type
        Me.Value = Value
        Me.Active = Active
        Me.Default = [Default]

    End Sub

    Public Overrides Function ToString() As String Implements IEntity.ToString

        Dim sb As New StringBuilder

        Try
            sb.AppendLine("Type: " & Me.Type)
            sb.AppendLine("Value: " & Me.Value)
            sb.AppendLine("Active: " & Me.Active)
            sb.AppendLine("Default: " & Me.Default)
        Catch ex As Exception
        End Try

        Return sb.ToString

    End Function

End Class


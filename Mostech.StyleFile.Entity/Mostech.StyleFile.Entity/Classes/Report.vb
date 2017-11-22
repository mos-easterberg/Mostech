
Imports System.Text

Public Class Report
    Inherits Entity
    Implements IEntity

    Public Property Name As String
    Public Property SQL As String

    Public Sub New()
    End Sub

    Public Sub New(ByVal Name As String,
                   ByVal SQL As String)

        Me.Name = Name
        Me.SQL = SQL

    End Sub

    Public Overrides Function ToString() As String Implements IEntity.ToString

        Dim sb As New StringBuilder

        Try
            sb.AppendLine("Name: " & Me.Name)
            sb.AppendLine("SQL: " & Me.SQL)
        Catch ex As Exception
        End Try

        Return sb.ToString

    End Function

End Class


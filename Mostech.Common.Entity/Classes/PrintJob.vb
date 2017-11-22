
Imports System.Text

Public Class PrintJob

	Public Property ID As Integer
	Public Property Data As String
    'Public Property FilePath As String
    'Public Property Encoding As String

	Public Sub New()
	End Sub

    Public Sub New(ByVal ID As Integer,
                   ByVal Data As String)

        Me.ID = ID
        Me.Data = Data
        'Me.FilePath = FilePath
        'Me.Encoding = Encoding

    End Sub

    Public Overrides Function ToString() As String

        Dim sb As New StringBuilder

        Try
            sb.AppendLine("ID: " & Me.ID)
            sb.AppendLine("Data: " & Me.Data)
            'sb.AppendLine("FilePath: " & Me.FilePath)
            'sb.AppendLine("Encoding: " & Me.Encoding)
        Catch ex As Exception
        End Try

        Return sb.ToString

    End Function

End Class


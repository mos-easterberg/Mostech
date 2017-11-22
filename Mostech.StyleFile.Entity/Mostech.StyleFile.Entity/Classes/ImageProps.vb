
Imports System.Drawing
Imports System.Text

Public Class ImageProps
    Inherits Entity
    Implements IEntity

    Public Property ParentKey As String
    Public Property FileName As String
    Public Property Image As Image

    Public Overrides Function ToString() As String Implements IEntity.ToString

        Dim sb As New StringBuilder

        Try
            sb.AppendLine("ParentKey: " & Me.ParentKey)
            sb.AppendLine("FileName: " & Me.FileName)
            sb.AppendLine("Image: " & Me.Image.ToString)
        Catch ex As Exception
        End Try

        Return sb.ToString

    End Function

End Class


Imports System.Drawing
Imports System.IO
Imports System.Text

Public Class ImageUtils

    Public Shared Function LoadImage(ByVal sFilePath As String) As Image

        Dim img As Image = Nothing
        Dim fs As FileStream = Nothing

        Try
            fs = New FileStream(sFilePath, FileMode.Open, FileAccess.Read)
            img = Image.FromStream(fs)
        Catch ex As Exception
            Throw ex
        Finally
            fs.Close()
            fs = Nothing
        End Try

        Return img

    End Function

    Public Shared Sub SaveImage(ByVal img As Image,
                                ByVal sFilePath As String)


        Try
            img.Save(sFilePath)
        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Sub

    Public Shared Function CopyToStandaloneImage(ByRef img As Image) As Image

        Try
            Dim memory As New MemoryStream()
            img.Save(memory, Imaging.ImageFormat.Png)
            Return Image.FromStream(memory)
        Catch ex As Exception
            Throw ex
        End Try

        Return Nothing

    End Function

End Class


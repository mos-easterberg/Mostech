
Imports System.Threading

Public Class ThreadUtils

    Public Shared Sub Sleep(ByVal iSeconds As Integer)

        Try
            Thread.Sleep(1000 * iSeconds)
        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Sub

End Class


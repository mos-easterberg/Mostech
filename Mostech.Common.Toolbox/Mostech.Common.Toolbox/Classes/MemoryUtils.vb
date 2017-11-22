
Public Class MemoryUtils

    Public Shared Sub CollectGarbage(ByVal bCollect As Boolean)

        Try
            If bCollect Then
                GC.Collect()
            End If
        Catch ex As Exception
        Finally
        End Try

    End Sub

End Class

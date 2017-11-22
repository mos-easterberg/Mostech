
Imports Mostech.Common.Entity

Public Class DBHelper

    Public Shared Function RunSQL(ByVal dbAccessSettings As DBAccess) As DataSet

        Dim ds As DataSet = Nothing

        Try

        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function

End Class

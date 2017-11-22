
Imports Mostech.Common.DAL
Imports Mostech.Common.Entity

Public Class JobFacade
    Implements IFacade

    Public Function FetchBySQL(ByVal sSQL As String, ByVal db As DBAccess) As DataSet Implements IFacade.FetchBySQL

        Try
            Return DALEntry.SelectFromDB(sSQL, db)
        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Function Add(ByVal sSQL As String, ByVal db As DBAccess) As Boolean Implements IFacade.Add

        Try
            Return DALEntry.InsertToDB(sSQL, db)
        Catch ex As Exception
            Throw
        End Try

        Return False

    End Function

    Public Function Update(ByVal sSQL As String, ByVal db As DBAccess) As Boolean Implements IFacade.Update

        Try
            Return DALEntry.UpdateToDB(sSQL, db)
        Catch ex As Exception
            Throw
        End Try

        Return False

    End Function

    Public Function Remove(ByVal sSQL As String, ByVal db As DBAccess) As Boolean Implements IFacade.Remove

        Try
            Return DALEntry.DeleteFromDB(sSQL, db)
        Catch ex As Exception
            Throw
        End Try

        Return False

    End Function

    Public Function RunSQL(ByVal sSQL As String, ByVal db As DBAccess) As Boolean Implements IFacade.RunSQL

        Try
            Return DALEntry.RunSQL(sSQL, db)
        Catch ex As Exception
            Throw
        End Try

        Return False

    End Function

End Class

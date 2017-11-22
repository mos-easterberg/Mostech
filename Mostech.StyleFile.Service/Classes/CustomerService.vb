
Imports Mostech.StyleFile.Entity
Imports Mostech.StyleFile.Facade
Imports Mostech.StyleFile.Factory
Imports Mostech.Common.Entity

Public Class CustomerService
    Inherits AbstractService
    Implements IService

    Public Function FetchBySQLAsDataSet(ByVal sSQL As String, ByVal db As DBAccess) As DataSet Implements IService.FetchBySQLAsDataSet

        Dim facade As CustomerFacade

        Try
            facade = New CustomerFacade()

            Return facade.FetchBySQL(sSQL, db)
        Catch ex As Exception
            Throw
        Finally
            facade = Nothing
        End Try

    End Function

    Public Function FetchBySQL(ByVal sSQL As String, ByVal db As DBAccess) As Collection Implements IService.FetchBySQL

        Dim facade As CustomerFacade
        Dim factory As CustomerFactory

        Try
            facade = New CustomerFacade()
            factory = New CustomerFactory()
            Return factory.InstantiateEntity(facade.FetchBySQL(sSQL, db), FactoryEnums.InstantionType.FORM, db)
        Catch ex As Exception
            Throw
        Finally
            facade = Nothing
            factory = Nothing
        End Try

        Return Nothing

    End Function

    Public Function Add(ByVal entity As Entity.Entity, ByVal db As DBAccess) As Boolean Implements IService.Add

        Dim facade As CustomerFacade
        Dim factory As CustomerFactory
        Dim cust As Customer

        Try
            cust = DirectCast(entity, Customer)
            facade = New CustomerFacade()
            factory = New CustomerFactory()
            Return facade.Add(factory.CreateSQL(cust, FactoryEnums.DBOperation.INSERT, db), db)
        Catch ex As Exception
            Throw
        Finally
            facade = Nothing
            factory = Nothing
        End Try

        Return False

    End Function

    Public Function Update(ByVal entity As Entity.Entity, ByVal db As DBAccess) As Boolean Implements IService.Update

        Dim facade As CustomerFacade
        Dim factory As CustomerFactory
        Dim cust As Customer

        Try
            cust = DirectCast(entity, Customer)
            facade = New CustomerFacade()
            factory = New CustomerFactory()
            Return facade.Update(factory.CreateSQL(cust, FactoryEnums.DBOperation.UPDATE, db), db)
        Catch ex As Exception
            Throw
        Finally
            facade = Nothing
            factory = Nothing
        End Try

        Return False

    End Function

    Public Function Remove(ByVal sKey As String, ByVal db As DBAccess) As Boolean Implements IService.Remove

        Dim facade As CustomerFacade
        Dim factory As CustomerFactory

        Try
            facade = New CustomerFacade()
            factory = New CustomerFactory()
            Return facade.Remove(factory.CreateSQL(sKey, FactoryEnums.DBOperation.DELETE, db), db)
        Catch ex As Exception
            Throw
        Finally
            facade = Nothing
            factory = Nothing
        End Try

        Return False

    End Function

    Public Function RunSQL(ByVal sSQL As String, ByVal db As DBAccess) As Boolean Implements IService.RunSQL

        Dim facade As CustomerFacade

        Try
            facade = New CustomerFacade()
            Return facade.RunSQL(sSQL, db)
        Catch ex As Exception
            Throw
        Finally
            facade = Nothing
        End Try

        Return False

    End Function

End Class


Imports Mostech.StyleFile.Entity
Imports Mostech.StyleFile.Facade
Imports Mostech.StyleFile.Factory
Imports Mostech.Common.Entity

Public Class ImageService
    Inherits AbstractService
    Implements IService

    Public Function FetchBySQLAsDataSet(ByVal sSQL As String, ByVal db As DBAccess) As DataSet Implements IService.FetchBySQLAsDataSet

        Dim facade As ImageFacade

        Try
            facade = New ImageFacade()
            Return facade.FetchBySQL(sSQL, db)
        Catch ex As Exception
            Throw
        Finally
            facade = Nothing
        End Try

    End Function

    Public Function FetchBySQL(ByVal sSQL As String, ByVal db As DBAccess) As Collection Implements IService.FetchBySQL

        Dim facade As ImageFacade
        Dim factory As ImageFactory

        Try
            facade = New ImageFacade()
            factory = New ImageFactory()
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

        Dim facade As ImageFacade
        Dim factory As ImageFactory
        Dim img As ImageProps

        Try
            img = DirectCast(entity, ImageProps)
            facade = New ImageFacade()
            factory = New ImageFactory()
            Return facade.Add(factory.CreateSQL(img, FactoryEnums.DBOperation.INSERT, db), db)
        Catch ex As Exception
            Throw
        Finally
            facade = Nothing
            factory = Nothing
        End Try

        Return False

    End Function

    Public Function Update(ByVal entity As Entity.Entity, ByVal db As DBAccess) As Boolean Implements IService.Update

        Dim facade As ImageFacade
        Dim factory As ImageFactory
        Dim img As ImageProps

        Try
            img = DirectCast(entity, ImageProps)
            facade = New ImageFacade()
            factory = New ImageFactory()
            Return facade.Update(factory.CreateSQL(img, FactoryEnums.DBOperation.UPDATE, db), db)
        Catch ex As Exception
            Throw
        Finally
            facade = Nothing
            factory = Nothing
        End Try

        Return False

    End Function

    Public Function Remove(ByVal sKey As String, ByVal db As DBAccess) As Boolean Implements IService.Remove

        Dim facade As ImageFacade
        Dim factory As ImageFactory

        Try
            facade = New ImageFacade()
            factory = New ImageFactory()
            Return facade.Remove(factory.CreateSQL(sKey, FactoryEnums.DBOperation.DELETE, db), db)
        Catch ex As Exception
            Throw ex
        Finally
            facade = Nothing
            factory = Nothing
        End Try

        Return False

    End Function

    Public Function RemoveByParent(ByVal sParentKey As String, ByVal db As DBAccess) As Boolean

        Dim facade As ImageFacade
        Dim factory As ImageFactory

        Try
            facade = New ImageFacade()
            factory = New ImageFactory()
            Return facade.Remove(factory.CreateSQL(sParentKey, FactoryEnums.DBOperation.DELETE_BY_PARENT, db), db)
        Catch ex As Exception
            Throw ex
        Finally
            facade = Nothing
            factory = Nothing
        End Try

        Return False

    End Function

    Public Function RunSQL(ByVal sSQL As String, ByVal db As DBAccess) As Boolean Implements IService.RunSQL

        Dim facade As ImageFacade

        Try
            facade = New ImageFacade()
            Return facade.RunSQL(sSQL, db)
        Catch ex As Exception
            Throw
        Finally
            facade = Nothing
        End Try

        Return False

    End Function

End Class

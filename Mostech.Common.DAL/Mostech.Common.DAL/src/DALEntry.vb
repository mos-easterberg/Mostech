
Imports Mostech.Common.Entity

Public Class DALEntry

    Public Shared Function SelectFromDB(ByVal sSQL As String,
                                        ByVal db As DBAccess) As DataSet
        Try
            Select Case db.DBVendor
                Case Toolbox.DatabaseUtils.DBVendor.MSSQL
                Case Toolbox.DatabaseUtils.DBVendor.MYSQL
                    Return MySQLDAL.SelectFromDB(sSQL, db)
                Case Toolbox.DatabaseUtils.DBVendor.POSTGRES
            End Select
        Catch ex As Exception
            Throw ex
        End Try

        Return Nothing

    End Function

    Public Shared Function InsertToDB(ByVal sSQL As String,
                                      ByVal db As DBAccess) As Boolean

        Try
            Select Case db.DBVendor
                Case Toolbox.DatabaseUtils.DBVendor.MSSQL
                Case Toolbox.DatabaseUtils.DBVendor.MYSQL
                    Return MySQLDAL.InsertToDB(sSQL, db)
                Case Toolbox.DatabaseUtils.DBVendor.POSTGRES
            End Select
        Catch ex As Exception
            Throw ex
        End Try

        Return False

    End Function

    Public Shared Function UpdateToDB(ByVal sSQL As String,
                                      ByVal db As DBAccess) As Boolean

        Try
            Select Case db.DBVendor
                Case Toolbox.DatabaseUtils.DBVendor.MSSQL
                Case Toolbox.DatabaseUtils.DBVendor.MYSQL
                    Return MySQLDAL.UpdateToDB(sSQL, db)
                Case Toolbox.DatabaseUtils.DBVendor.POSTGRES
            End Select
        Catch ex As Exception
            Throw ex
        End Try

        Return False

    End Function

    Public Shared Function DeleteFromDB(ByVal sSQL As String,
                                        ByVal db As DBAccess) As Boolean

        Try
            Select Case db.DBVendor
                Case Toolbox.DatabaseUtils.DBVendor.MSSQL
                Case Toolbox.DatabaseUtils.DBVendor.MYSQL
                    Return MySQLDAL.DeleteFromDB(sSQL, db)
                Case Toolbox.DatabaseUtils.DBVendor.POSTGRES
            End Select
        Catch ex As Exception
            Throw ex
        End Try

        Return False

    End Function

    Public Shared Function RunSQL(ByVal sSQL As String,
                                  ByVal db As DBAccess) As Boolean

        Try
            Select Case db.DBVendor
                Case Toolbox.DatabaseUtils.DBVendor.MSSQL
                Case Toolbox.DatabaseUtils.DBVendor.MYSQL
                    Return MySQLDAL.RunSQL(sSQL, db)
                Case Toolbox.DatabaseUtils.DBVendor.POSTGRES
            End Select
        Catch ex As Exception
            Throw ex
        End Try

        Return False

    End Function

End Class

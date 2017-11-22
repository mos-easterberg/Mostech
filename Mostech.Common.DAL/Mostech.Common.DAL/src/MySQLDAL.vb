
Imports MySql.Data.MySqlClient
Imports Mostech.Common.Entity

Friend Class MySQLDAL
    Implements IDAL

    Private Shared Function _getConnection(ByVal db As DBAccess) As MySqlConnection

        Dim conn As MySqlConnection = Nothing

        Try
            conn = New MySqlConnection
            conn.ConnectionString = db.ConnectionString
            conn.Open()
        Catch ex As Exception
            Throw ex
        End Try

        Return conn

    End Function

    Private Shared Function _writeToDB(ByVal sSQL As String, _
                                       ByVal db As DBAccess) As Boolean

        Dim conn As MySqlConnection = Nothing
        Dim cmd As MySqlCommand = Nothing
        Dim i As Integer = 0

        Try
            conn = _getConnection(db)
            cmd = conn.CreateCommand
            cmd.CommandText = sSQL
            cmd.CommandTimeout = db.DBTimeOutSeconds
            i = cmd.ExecuteNonQuery()
            If i = 1 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        Finally
            conn.Close()
            conn.Dispose()
            conn = Nothing
        End Try

        Return False

    End Function

    Private Shared Function _readFromDB(ByVal sSQL As String, _
                                        ByVal db As DBAccess) As DataSet

        Dim conn As MySqlConnection = Nothing
        Dim da As MySqlDataAdapter = Nothing
        Dim ds As DataSet = Nothing
        Dim cb As MySqlCommandBuilder = Nothing

        Try
            ds = New DataSet
            conn = _getConnection(db)
            da = New MySqlDataAdapter(sSQL, conn)
            cb = New MySqlCommandBuilder(da)
            da.Fill(ds)

        Catch ex As Exception
            Throw ex
        Finally
            conn.Close()
            conn.Dispose()
            conn = Nothing
        End Try

        Return ds

    End Function

    Public Shared Function SelectFromDB(ByVal sSQL As String,
                                        ByVal db As DBAccess) As DataSet

        Try
            Return MySQLDAL._readFromDB(sSQL, db)
        Catch ex As Exception
            Throw ex
        End Try

        Return Nothing

    End Function

    Public Shared Function InsertToDB(ByVal sSQL As String,
                                      ByVal db As DBAccess) As Boolean

        Try
            Return MySQLDAL._writeToDB(sSQL, db)
        Catch ex As Exception
            Throw ex
        End Try

        Return False

    End Function

    Public Shared Function UpdateToDB(ByVal sSQL As String,
                                      ByVal db As DBAccess) As Boolean

        Try
            Return MySQLDAL._writeToDB(sSQL, db)
        Catch ex As Exception
            Throw ex
        End Try

        Return False

    End Function

    Public Shared Function DeleteFromDB(ByVal sSQL As String,
                                        ByVal db As DBAccess) As Boolean

        Try
            Return MySQLDAL._writeToDB(sSQL, db)
        Catch ex As Exception
            Throw ex
        End Try

        Return False

    End Function

    Public Shared Function RunSQL(ByVal sSQL As String,
                                  ByVal db As DBAccess) As Boolean

        Try
            Return MySQLDAL._writeToDB(sSQL, db)
        Catch ex As Exception
            Throw ex
        End Try

        Return False

    End Function

End Class

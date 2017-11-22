
Imports System.Data.SqlClient
Imports System.Text

Public Class MSSQLUtils

    Public Enum SQLCommandType
        [STORED_PROCEDURE] = 0
        [TEXT] = 1
    End Enum

    Private Shared Function _getConnectionString(ByVal settings As MSSQLSettings) As String

        Dim sb As New StringBuilder

        Try
            sb.Append("Data Source=" & settings.DataSource & ";")
            sb.Append("Initial Catalog=" & settings.InitialCatalog & ";")
            sb.Append("User Id=" & settings.UserID & ";")
            sb.Append("Password=" & Toolbox.EncryptionUtils.SimpleDecrypt(settings.Password) & ";")
        Catch ex As Exception
            Throw ex
        End Try

        Return sb.ToString

    End Function

    Public Shared Function GetConnection(ByVal settings As MSSQLSettings) As SqlConnection

        Dim connection As SqlConnection = Nothing

        Try
            connection = New SqlConnection
            connection.ConnectionString = _getConnectionString(settings)
            connection.Open()
        Catch ex As Exception
            Throw ex
        Finally
        End Try

        Return connection

    End Function

    Public Shared Function IsConnectionOpen(ByRef conn As SqlConnection) As Boolean

        Try
            Return (conn.State = ConnectionState.Open)
        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Function

    Public Shared Function GetData(ByRef conn As SqlConnection, _
                                   ByVal sSQL As String) As DataSet

        Dim ds As New DataSet
        Dim ada As SqlDataAdapter = Nothing

        Try
            ada = New SqlDataAdapter(sSQL, conn)
            ada.Fill(ds)
        Catch ex As Exception
            Throw ex
        Finally
            ada.Dispose()
            ada = Nothing
        End Try

        Return ds

    End Function

    Public Shared Function SetData(ByRef conn As SqlConnection, _
                                   ByVal sSQL As String, _
                                   ByVal iCommandTimeOut As Integer) As Boolean

        Try
            Return MSSQLUtils.SetData(conn, sSQL, iCommandTimeOut, SQLCommandType.TEXT)
        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Function

    Public Shared Function SetData(ByRef conn As SqlConnection, _
                                   ByVal sSQL As String, _
                                   ByVal iCommandTimeOut As Integer, _
                                   ByVal cmdType As SQLCommandType) As Boolean

        Dim cmd As SqlCommand = Nothing
        Dim b As Boolean = False

        Try
            cmd = conn.CreateCommand
            cmd.CommandText = sSQL
            cmd.CommandTimeout = iCommandTimeOut

            Select Case cmdType
                Case SQLCommandType.STORED_PROCEDURE : cmd.CommandType = CommandType.StoredProcedure
                Case SQLCommandType.TEXT : cmd.CommandType = CommandType.Text
            End Select

            cmd.ExecuteNonQuery()
            b = True

        Catch ex As Exception
            Throw ex
        Finally
            cmd.Dispose()
            cmd = Nothing
        End Try

        Return b

    End Function

End Class

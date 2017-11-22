
Imports Mostech.Common.Toolbox
'Imports Npgsql
'Imports NpgsqlTypes
Imports System.Text

Friend Class PostgresDAL

    'Public Enum SQLCommandType
    '    [STORED_PROCEDURE] = 0
    '    [TEXT] = 1
    'End Enum

    'Public Shared Function GetConnection(ByVal sConnectionString As String,
    '                                     ByVal bOpenConnection As Boolean) As NpgsqlConnection

    '    Dim conn As NpgsqlConnection = Nothing

    '    Try
    '        conn = New NpgsqlConnection()
    '        conn.ConnectionString = sConnectionString
    '        If bOpenConnection Then conn.Open()
    '    Catch ex As Exception
    '        Throw ex
    '    End Try

    '    Return conn

    'End Function

    'Public Shared Sub CloseConnection(ByRef conn As NpgsqlConnection)

    '    Try
    '        conn.Close()
    '    Catch ex As Exception
    '        Throw ex
    '    Finally
    '        Try
    '            conn.Dispose()
    '            conn = Nothing
    '        Catch ex As Exception
    '        End Try
    '    End Try

    'End Sub

    'Public Shared Function IsConnectionOpen(ByRef conn As NpgsqlConnection) As Boolean

    '    Try
    '        Return (conn.State = ConnectionState.Open)
    '    Catch ex As Exception
    '        Throw ex
    '    Finally
    '    End Try

    'End Function

    'Public Shared Function GetConnectionInfo(ByRef conn As NpgsqlConnection) As StringBuilder

    '    Dim sb As New StringBuilder

    '    Try
    '        sb.AppendLine("BackendProtocolVersion: " & conn.BackendProtocolVersion.ToString)
    '        sb.AppendLine("CommandTimeout: " & conn.CommandTimeout.ToString)
    '        sb.AppendLine("ConnectionLifeTime: " & conn.ConnectionLifeTime.ToString)
    '        sb.AppendLine("ConnectionString: " & conn.ConnectionString.ToString)
    '        sb.AppendLine("ConnectionTimeout: " & conn.ConnectionTimeout.ToString)
    '        sb.AppendLine("Database: " & conn.Database.ToString)
    '        sb.AppendLine("DataSource: " & conn.DataSource.ToString)
    '        sb.AppendLine("FullState: " & conn.FullState.ToString)
    '        sb.AppendLine("Host: " & conn.Host.ToString)
    '        sb.AppendLine("NpgsqlCompatibilityVersion: " & conn.NpgsqlCompatibilityVersion.ToString)
    '        sb.AppendLine("Port: " & conn.Port.ToString)
    '        sb.AppendLine("PostgreSqlVersion: " & conn.PostgreSqlVersion.ToString)
    '        sb.AppendLine("ProcessID: " & conn.ProcessID.ToString)
    '        sb.AppendLine("ServerVersion: " & conn.ServerVersion.ToString)
    '        sb.AppendLine("SSL: " & conn.SSL.ToString)
    '        sb.AppendLine("State: " & conn.State.ToString)
    '        sb.AppendLine("SyncNotification: " & conn.SyncNotification.ToString)
    '        sb.AppendLine("UseExtendedTypes: " & conn.UseExtendedTypes.ToString)
    '    Catch ex As Exception
    '        Throw ex
    '    Finally
    '    End Try

    '    Return sb

    'End Function

    'Public Shared Function GetData(ByRef conn As NpgsqlConnection,
    '                               ByVal sSQL As String) As DataSet

    '    Dim ds As New DataSet
    '    Dim ada As NpgsqlDataAdapter = Nothing

    '    Try
    '        ada = New NpgsqlDataAdapter(sSQL, conn)
    '        ada.Fill(ds)
    '    Catch ex As Exception
    '        Throw ex
    '    Finally
    '        ada.Dispose()
    '        ada = Nothing
    '    End Try

    '    Return ds

    'End Function

    'Public Shared Function SetData(ByRef conn As NpgsqlConnection,
    '                               ByVal sSQL As String,
    '                               ByVal iCommandTimeOut As Integer) As Boolean

    '    Try
    '        Return PostgresDAL.SetData(conn, sSQL, iCommandTimeOut, SQLCommandType.TEXT)
    '    Catch ex As Exception
    '        Throw ex
    '    Finally
    '    End Try

    'End Function

    'Public Shared Function SetData(ByRef conn As NpgsqlConnection,
    '                               ByVal sSQL As String,
    '                               ByVal iCommandTimeOut As Integer,
    '                               ByVal cmdType As SQLCommandType) As Boolean

    '    Dim cmd As NpgsqlCommand = Nothing
    '    Dim b As Boolean = False

    '    Try
    '        cmd = conn.CreateCommand
    '        cmd.CommandText = sSQL
    '        cmd.CommandTimeout = iCommandTimeOut

    '        Select Case cmdType
    '            Case SQLCommandType.STORED_PROCEDURE : cmd.CommandType = CommandType.StoredProcedure
    '            Case SQLCommandType.TEXT : cmd.CommandType = CommandType.Text
    '        End Select

    '        cmd.ExecuteNonQuery()
    '        b = True

    '    Catch ex As Exception
    '        Throw ex
    '    Finally
    '        cmd.Dispose()
    '        cmd = Nothing
    '    End Try

    '    Return b

    'End Function

End Class

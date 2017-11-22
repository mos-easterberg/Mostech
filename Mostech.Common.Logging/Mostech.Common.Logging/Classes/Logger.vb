
Imports Mostech.Common
Imports Mostech.Common.Settings

Public Class Logger

    Public Sub New()
    End Sub

    Public Shared Function PrepareLogDirectory(ByVal sLogDirectoryPath As String) As Boolean

        Try
            Return Toolbox.FileUtils.CreateDirectory(sLogDirectoryPath)
        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Function

    Public Shared Function EmptyLogOnStartup(ByVal logSettings As LogSettings) As Boolean

        Dim b As Boolean = False

        Try
            If logSettings.LogEmptyOnStartup Then
                b = Toolbox.FileUtils.EmptyFile(Logger.GetDailyLogFilePath(logSettings))
            Else
                b = True
            End If
        Catch ex As Exception
            Throw ex
        Finally
        End Try

        Return b

    End Function

    Public Shared Function Log(ByVal sMsg As String, _
                               ByVal logSettings As LogSettings) As Boolean

        Dim b As Boolean = False

        Try
            b = Log(sMsg, logSettings, LogEnums.LogMode.DISC)
        Catch ex As Exception
            If logSettings.LogThrowException Then Throw ex
            b = False
        Finally
            logSettings = Nothing
        End Try

        Return b

    End Function

    Public Shared Function Log(ByVal sMsg As String,
                               ByVal logSettings As LogSettings,
                               ByVal mode As LogEnums.LogMode,
                               Optional ByVal emailSettings As EmailSettings = Nothing) As Boolean

        Dim sFileName As String = ""
        Dim sEmailSubject As String = ""
        Dim b As Boolean = False

        Try

            'init
            '-------------------------------------------------------------------------
            If String.IsNullOrEmpty(sMsg) Then
                Return False
                Exit Function
            Else
                sFileName = logSettings.LogFolderPath & GetDailyLogFileName(logSettings.LogFileName)
                sEmailSubject = Microsoft.VisualBasic.Left(sMsg, 50)
            End If

            Select Case mode


                'DISC
                '-------------------------------------------------------------------------
                Case LogEnums.LogMode.DISC
                    Try
                        b = Toolbox.FileUtils.WriteMessage(sFileName, sMsg, True, 0, False, 0)
                    Catch ex As Exception
                        If logSettings.LogThrowException Then Throw ex
                    End Try


                    'EMAIL
                    '-------------------------------------------------------------------------
                Case LogEnums.LogMode.EMAIL
                    Try
                        b = Toolbox.EmailUtils.SendMail(emailSettings.EmailReceiverAddress, "", "", "", emailSettings.EmailServerName, emailSettings.EmailServerPort,
                                                       sEmailSubject, sMsg, emailSettings.EmailEnableSSL, emailSettings.EmailFromAddress,
                                                       emailSettings.EmailSendTimeoutSeconds, "")
                    Catch ex As Exception
                        If logSettings.LogThrowException Then Throw ex
                    End Try


                    'DISC_AND_EMAIL
                    '-------------------------------------------------------------------------
                Case LogEnums.LogMode.DISC_AND_EMAIL
                    Try
                        b = Toolbox.FileUtils.WriteMessage(sFileName, sMsg, True, 0, False, 0)
                    Catch ex As Exception
                        If logSettings.LogThrowException Then Throw ex
                    End Try

                    Try
                        b = Toolbox.EmailUtils.SendMail(emailSettings.EmailReceiverAddress, "", "", "", emailSettings.EmailServerName, emailSettings.EmailServerPort, _
                                                       sEmailSubject, sMsg, emailSettings.EmailEnableSSL, emailSettings.EmailFromAddress, _
                                                       emailSettings.EmailSendTimeoutSeconds, "")
                    Catch ex As Exception
                        If logSettings.LogThrowException Then Throw ex
                    End Try

            End Select

        Catch ex As Exception
            If logSettings.LogThrowException Then Throw ex
            b = False
        Finally
            logSettings = Nothing
        End Try

        Return b

    End Function

    Public Shared Function GetDailyLogFileName(ByVal sFileName As String) As String

        Dim sDailyFileName As String = ""

        Try
            sDailyFileName = Toolbox.DateAndTimeUtils.ConvertDate(Toolbox.DateAndTimeUtils.DateStyle.SWEDISH,
                                                                Toolbox.DateAndTimeUtils.DateFormat.SHORT,
                                                                Date.Today) & "_" & sFileName
        Catch ex As Exception
            Throw ex
        Finally
        End Try

        Return sDailyFileName

    End Function

    Public Shared Function GetDailyLogFilePath(ByVal logSettings As LogSettings) As String

        Dim sDailyFilePath As String = ""

        Try
            sDailyFilePath = Toolbox.FileUtils.SecureFilePath(logSettings.LogFolderPath) & Logger.GetDailyLogFileName(logSettings.LogFileName)
        Catch ex As Exception
            Throw ex
        Finally
        End Try

        Return sDailyFilePath

    End Function

End Class

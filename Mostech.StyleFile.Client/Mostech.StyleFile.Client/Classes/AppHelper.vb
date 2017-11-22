
Imports Mostech.Common
Imports Mostech.Common.Settings
Imports Mostech.Common.Logging
Imports Mostech.StyleFile.Entity

Imports System.Text

Public Class AppHelper

    Public Enum HandleException
        LOG
        MSGBOX
        BOTH
    End Enum

    Public Shared Sub CatchException(ByVal ex As Exception,
                                     ByVal handleExceptionType As HandleException,
                                     ByVal logSettings As LogSettings)

        Try
            Select Case handleExceptionType

                Case HandleException.MSGBOX
                    Toolbox.ErrorUtils.DisplayException(ex, "Error!")

                Case HandleException.LOG
                    Logger.Log("Error: " & ex.Message, logSettings)

                Case HandleException.BOTH
                    Toolbox.ErrorUtils.DisplayException(ex, "Error!")
                    Logger.Log("Error: " & ex.Message, logSettings)
            End Select

        Catch exc As Exception
            Toolbox.UIUtils.ShowMessageBox("Error when catching exception: " & exc.Message, "Error!", MessageBoxIcon.Error)
        Finally
        End Try

    End Sub

    Public Shared Function GetEntityKey() As String

        Try
            Return Guid.NewGuid.ToString
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Shared Function GetUserName() As String

        Try
            Return System.Environment.UserName
        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Shared Function CleanTimeValue(ByVal sTimeValue As String) As String

        Try
            If sTimeValue = ":" Then Return ""
        Catch ex As Exception
            Throw ex
        End Try

        Return sTimeValue

    End Function

    Public Shared Sub SetReqFieldsColor(ByRef ctrl As System.Windows.Forms.Control)

        Dim color As New Color

        Try
            ctrl.BackColor = color.FromArgb(Integer.Parse(UserSettings.UserAppSettings.RequiredFieldsColor))
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Shared Sub UpdateConnectionString()

        Try
            UserSettings.DBAccessSettings.ConnectionString = _
                Toolbox.DatabaseUtils.ConstructConnectionString(UserSettings.DBAccessSettings.DBVendor, _
                                                                UserSettings.DBAccessSettings.DBServer, _
                                                                UserSettings.DBAccessSettings.DBPort, _
                                                                UserSettings.DBAccessSettings.DBName, _
                                                                UserSettings.DBAccessSettings.DBUserID, _
                                                                UserSettings.DBAccessSettings.DBPassword, _
                                                                UserSettings.DBAccessSettings.DBTimeOutSeconds)
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Shared Function SetCommonEntitySettings(ByVal ent As Entity.Entity) As Entity.Entity

        Try
            ent.Created = Toolbox.DateAndTimeUtils.ConvertDate(Toolbox.DateAndTimeUtils.DateStyle.SWEDISH, Date.Now)
            ent.CreatedBy = AppHelper.GetUserName
            ent.Updated = ent.Created
            ent.UpdatedBy = ent.CreatedBy
        Catch ex As Exception
            Throw ex
        End Try

        Return ent

    End Function

    Public Shared Function FormatJob(ByVal jb As Job,
                                    ByVal formatStyle As AppEnums.JobFormatStyleEnum) As String

        Dim sb As New StringBuilder
        Dim sTitle As String = ""

        Try
            'init vars
            '-------------------------------------------------
            sTitle = "StyleFile - " + jb.Customer + " (ID: " + jb.ID + ")"

            Select Case formatStyle

                Case AppEnums.JobFormatStyleEnum.HTML
                    sb.AppendLine("<html>")
                    sb.AppendLine("<head>")
                    sb.AppendLine("<title>" + sTitle + "</title>")
                    sb.AppendLine("</head>")
                    sb.AppendLine("<body>")
                    sb.AppendLine("<pre>")

                    sb.AppendLine("</pre>")
                    sb.AppendLine("</body>")
                    sb.AppendLine("</html>")

                Case AppEnums.JobFormatStyleEnum.TEXT
                    sb.AppendLine("ID: " + jb.ID)
                    sb.AppendLine("Kund: " + jb.Customer)
                    sb.AppendLine("Datum: " + Toolbox.DateAndTimeUtils.ConvertDate(Toolbox.DateAndTimeUtils.DateStyle.FINNISH,
                                                                                   Toolbox.DateAndTimeUtils.DateFormat.SHORT,
                                                                                   jb.JobDate, ".", "") + " " + jb.StartTime)
                    sb.AppendLine("Kategori: " + jb.Category)
                    sb.AppendLine("Stylist: " + jb.Stylist)
                    sb.AppendLine("Pris: " + jb.PriceInclVAT.ToString)
                    sb.AppendLine("Beskrivning: " + jb.Description)

            End Select

        Catch ex As Exception
            Throw ex
        End Try

        Return sb.ToString

    End Function

End Class

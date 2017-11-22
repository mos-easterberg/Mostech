
Imports Mostech.Common
Imports Mostech.Common.Forms
Imports Mostech.Common.Logging
Imports Mostech.StyleFile.Entity
Imports Mostech.StyleFile.Service
Imports Mostech.Common.Entity

Imports System.Drawing
Imports System.Text

Public Class frmReport
    Inherits frmStyleFile
    Implements IFormSaveable, IFormCommon

    Private _sKey As String = ""

    Private Sub frmReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me._init()
    End Sub

    Private Sub frmReport_ResizeEnd(sender As Object, e As System.EventArgs) Handles Me.ResizeEnd

        Try
            'height
            '-------------------------------------------------
            Me.tcTabs.Height = Me.Height - 35
            Me.gbResult.Height = Me.Height - 100
            Me.dgData.Height = Me.Height - 125

            'width
            '-------------------------------------------------
            Me.tcTabs.Width = Me.Width - 14
            Me.gbResult.Width = Me.Width - 37
            Me.dgData.Width = Me.Width - 49

        Catch ex As Exception
        End Try

    End Sub

    Private Sub _closeForm(ByVal bConfirm As Boolean) Implements IFormCommon._closeForm

        Try
            Toolbox.UIUtils.CloseForm(Me, False, AppMessages.CONFIRM_CLOSE_WINDOW, AppMessages.DIALOG_CAPTION)
        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
        End Try

    End Sub

    Private Sub _init() Implements IFormCommon._init

        Try
            Me.FormState = FormStateEnum.LOADING
            Me._setIcon()
            Me._initUI()
            Me._setUIColor()
            Me._initTooltips()
            Me._loadReportsToCombos(False)
            Me._setSaveState(False)
            Me._isDirty(False)
            Toolbox.UIUtils.SetCaption(Me, "Rapport")
            Me.FormState = FormStateEnum.IDLE
        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
        End Try

    End Sub

    Private Sub _initUI() Implements IFormCommon._initUI

        Try
            Me.chkActive.Checked = True
            Me.rtbSQL.MaxLength = 100000

            Me.dgData.ReadOnly = True
            Me.dgData.AllowDrop = False

            Toolbox.UIUtils.SetFocus(Me.cboExecutableReports)

        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Sub

    Private Sub _setUIColor() Implements IFormCommon._setUIColor

        Try
            Me.BackColor = Color.FromArgb(Integer.Parse(UserSettings.UserAppSettings.FormBackColor))

            For Each ctrl As Control In Me.Controls
                If ctrl.GetType = GetType(Button) Then
                    ctrl.BackColor = Color.FromArgb(Integer.Parse(UserSettings.UserAppSettings.ButtonColor))
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub _setIcon() Implements IFormCommon._setIcon
        Me.Icon = My.Resources.icon_StyleFile
    End Sub

    Private Sub _initTooltips() Implements IFormCommon._initTooltips

        Try
            If Not UserSettings.UserAppSettings.ShowToolTips Then Exit Sub

            Toolbox.UIUtils.SetToolTip(Me.btnRemoveReport, AppMessages.REMOVE_REPORT)
            Toolbox.UIUtils.SetToolTip(Me.btnRun, AppMessages.RUN_REPORT)
            Toolbox.UIUtils.SetToolTip(Me.btnSaveReport, AppMessages.SAVE_REPORT)
            Toolbox.UIUtils.SetToolTip(Me.btnSaveResult, AppMessages.SAVE_RESULT)
            Toolbox.UIUtils.SetToolTip(Me.btnUpdateReport, AppMessages.UPDATE_REPORT)

            Toolbox.UIUtils.SetToolTip(Me.chkActive, AppMessages.IF_CHECKED_SHOW_IN_LIST)

        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Sub

    Private Sub _loadReportsToCombos(ByVal bClearUI As Boolean)

        Dim sReportIdentifier As String = ""

        Try
            Me.FormState = FormStateEnum.LOADING

            If bClearUI Then
                Me.cboEditableReports.Items.Clear()
                Me.cboExecutableReports.Items.Clear()
                Me.rtbSQL.Text = ""
            End If

            For Each rep As Report In ServiceHelper.LoadReportsFromDB
                'sReportIdentifier = rep.ID & ". " & rep.Name & GUIHelper.COMBOBOX_SEPARATOR & rep.Key
                sReportIdentifier = rep.Name & GUIHelper.COMBOBOX_SEPARATOR & rep.Key
                Me.cboEditableReports.Items.Add(sReportIdentifier)
                If rep.Active Then
                    Me.cboExecutableReports.Items.Add(sReportIdentifier)
                End If
            Next

            Me.cboEditableReports.Text = Me.cboEditableReports.Items(0)
            Me.cboExecutableReports.Text = Me.cboExecutableReports.Items(0)

            Me._setSaveState(False)
            Me._isDirty(False)
            Me.FormState = FormStateEnum.IDLE

        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Sub

    Private Sub _loadReportToUI(ByVal sKey As String, _
                                ByVal sTarget As String)

        Dim rep As Report

        Try
            rep = ServiceHelper.LoadReportFromDB(sKey)
            Me._sKey = rep.Key

            If sTarget = "EDIT" Then
                Me.txtID.Text = rep.ID
                Me.txtCreated.Text = rep.Created
                Me.txtEdited.Text = rep.Updated
                Me.txtName.Text = rep.Name
                Me.chkActive.Checked = rep.Active
                Me.rtbSQL.Text = rep.SQL
            ElseIf sTarget = "EXECUTE" Then

            End If

        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
            rep = Nothing
        End Try

    End Sub

    Private Sub _save() Implements IFormSaveable._save
    End Sub

    Private Sub _setSaveState(ByVal bIsSaveable As Boolean) Implements IFormSaveable._setSaveState
        Me.btnSaveReport.Enabled = bIsSaveable
        Me.btnUpdateReport.Enabled = bIsSaveable
    End Sub

    Private Sub _isDirty(ByVal b As Boolean) Implements IFormSaveable._isDirty

        Me.IsDirty = b
        If b Then
            Toolbox.UIUtils.SetCaption(Me, "Rapport (ej sparad)")
        Else
            Toolbox.UIUtils.SetCaption(Me, "Rapport")
        End If

    End Sub

    Private Function _isRequiredFieldsFilled() As Boolean Implements IFormSaveable._isRequiredFieldsFilled

        Dim b As Boolean = False

        Try
            If Me.rtbSQL.Text.Trim.Length >= 15 Then
                b = True
            End If
        Catch ex As Exception
            Throw ex
        Finally
        End Try

        Return b

    End Function

    Private Function _isInputValidated(ByVal entity As Entity.Entity) As Boolean Implements IFormSaveable._isInputValidated
        Return False
    End Function

    Private Function _isSafeQuery(ByVal rep As Report) As Boolean

        Dim b As Boolean = False

        Try
            If rep.SQL.Substring(0, 7).ToUpper = "SELECT " Then
                b = True
            End If
        Catch ex As Exception
            Throw ex
        Finally
        End Try

        Return b

    End Function

    Private Sub _saveReport(ByVal dbOp As AppEnums.DBOperationEnum)

        Dim rep As Report

        Try

            'is required fields filled 
            If Not Me._isRequiredFieldsFilled Then
                Toolbox.UIUtils.ShowMessageBox(AppMessages.REQUIRED_FIELDS_MISSING, AppMessages.DIALOG_CAPTION, MessageBoxIcon.Error)
                Exit Sub
            End If

            'instantiate
            rep = Me._instantiateFromUI(dbOp)

            'replace ' with "
            rep.SQL = rep.SQL.Replace("'", """")

            'has name?
            If rep.Name.Equals("") Then
                Toolbox.UIUtils.ShowMessageBox(AppMessages.QUERY_IS_UNTITLED, AppMessages.DIALOG_CAPTION, MessageBoxIcon.Error)
                Exit Sub
            End If

            'name ok?
            If rep.Name.Contains("'") Then
                Toolbox.UIUtils.ShowMessageBox(AppMessages.INPUT_VALIDATION_FAILED, AppMessages.DIALOG_CAPTION, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
  
            'is safe?
            If Not Me._isSafeQuery(rep) Then
                Toolbox.UIUtils.ShowMessageBox(AppMessages.QUERY_IS_UNSAFE, AppMessages.DIALOG_CAPTION, MessageBoxIcon.Information)
                Me._setSaveState(False)
                Me._isDirty(False)
                Exit Sub
            End If

            'save
            If Me._saveReportToDB(rep, dbOp) Then
                Me._loadReportsToCombos(True)
                Me._setSaveState(False)
                Me._isDirty(False)
            Else
                Toolbox.UIUtils.ShowMessageBox(AppMessages.FAILED_TO_SAVE_ITEM, AppMessages.DIALOG_CAPTION, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            Throw ex
        Finally
            rep = Nothing
        End Try

    End Sub

    Private Function _saveReportToDB(ByVal rep As Report, _
                                     ByVal dbOp As AppEnums.DBOperationEnum) As Boolean

        Dim b As Boolean = False
        Dim service As ReportService

        Try
            service = New ReportService()
            If dbOp = AppEnums.DBOperationEnum.INSERT Then
                rep.Key = AppHelper.GetEntityKey
                b = service.Add(rep, UserSettings.DBAccessSettings)
            Else
                'rep.Key = Me._sKey
                b = service.Update(rep, UserSettings.DBAccessSettings)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            service = Nothing
        End Try

        Return b

    End Function

    'Private Sub _instantiateFromUI(ByVal bValues As Boolean) Implements IFormSaveable._instantiateFromUI
    'End Sub

    Private Function _instantiateFromUI(ByVal dbOp As AppEnums.DBOperationEnum) As Report

        Dim rep As Report

        Try
            rep = New Report
            rep.Name = ""

            Select Case dbOp
                Case AppEnums.DBOperationEnum.INSERT
                    rep.Name = Toolbox.UIUtils.ShowQuestionBox("Ge rapporten ett namn!", AppMessages.DIALOG_CAPTION, "")
                    rep.Created = Toolbox.DateAndTimeUtils.ConvertDate(Toolbox.DateAndTimeUtils.DateStyle.SWEDISH, Date.Now)
                    rep.CreatedBy = AppHelper.GetUserName

                Case AppEnums.DBOperationEnum.UPDATE
                    rep.Key = GUIHelper.GetKeyFromComboString(Me.cboEditableReports.Text.Trim)
                    rep.Name = Me.txtName.Text.Trim 'GUIHelper.GetValueFromComboString(Me.cboEditableReports.Text)
                    rep.Updated = Toolbox.DateAndTimeUtils.ConvertDate(Toolbox.DateAndTimeUtils.DateStyle.SWEDISH, Date.Now)
                    rep.UpdatedBy = AppHelper.GetUserName

            End Select

            rep.SQL = Me.rtbSQL.Text.Trim
            rep.Active = Me.chkActive.Checked

        Catch ex As Exception
            Throw ex
        Finally
        End Try

        Return rep

    End Function

    Private Sub _runReport()

        Dim rep As Report = Nothing
        Dim service As ReportService
        Dim i As Integer = 0
        Dim ds As DataSet = Nothing
        Dim b As Boolean = False

        Try
            Toolbox.UIUtils.SetCursor(Cursors.WaitCursor, Me)
            service = New ReportService()
            Logger.Log("Running report: " & GUIHelper.GetValueFromComboString(Me.cboExecutableReports.Text), UserSettings.LogSettings, LogEnums.LogMode.DISC)
            rep = ServiceHelper.LoadReportFromDB(GUIHelper.GetKeyFromComboString(Me.cboExecutableReports.Text))
            ds = service.FetchBySQLAsDataSet(rep.SQL, UserSettings.DBAccessSettings)
            i = ds.Tables(0).Rows.Count
            Logger.Log("Rows returned: " & i, UserSettings.LogSettings, LogEnums.LogMode.DISC)
            Toolbox.UIUtils.SetCursor(Cursors.Default, Me)

            If i > 1000 Then
                If Toolbox.UIUtils.ConfirmDialog(AppMessages.LARGE_NR_OF_ROWS & i, AppMessages.DIALOG_CAPTION) Then
                    b = True
                Else
                    b = False
                End If
            Else
                b = True
            End If

            If b Then
                'Me.fcGrid.DataSource = ds.Tables(0)
                Me.dgData.DataSource = ds.Tables(0)
            End If

        Catch ex As Exception
            Throw ex
        Finally
            service = Nothing
            rep = Nothing
        End Try

    End Sub

    'Private Sub _saveResult()

    '    Dim sFilePath As String = ""
    '    Dim sb As New StringBuilder
    '    Dim sf As New SaveFileDialog
    '    Dim b As Boolean = False

    '    Try
    '        sf.InitialDirectory = UserSettings.UserAppSettings.ReportDefaultFolder
    '        sf.Filter = Toolbox.FileUtils.GetSaveFileDialogFilter
    '        sf.FilterIndex = 1
    '        sf.ShowDialog()
    '        sFilePath = sf.FileName

    '        Toolbox.UIUtils.SetCursor(Cursors.WaitCursor, Me)
    '        b = Me._export(sFilePath)
    '        Toolbox.UIUtils.SetCursor(Cursors.Default, Me)

    '        If b Then
    '            Toolbox.UIUtils.ShowMessageBox(AppMessages.EXPORT_SUCCESSFUL, UserSettings.UserAppSettings.ApplicationName, MessageBoxIcon.Information)
    '        Else
    '            Toolbox.UIUtils.ShowMessageBox(AppMessages.EXPORT_FAILED, UserSettings.UserAppSettings.ApplicationName, MessageBoxIcon.Error)
    '        End If

    '    Catch ex As Exception
    '        AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
    '    Finally
    '        sf = Nothing
    '    End Try

    'End Sub

    'Private Function _export(ByVal sFilePath As String) As Boolean

    '    Dim b As Boolean = False

    '    Try
    '        Select Case Toolbox.FileUtils.GetFileExtension(sFilePath).ToUpper
    '            Case "XLS" : b = Me.fcGrid.ExportToExcel(sFilePath, False, False)
    '            Case "PDF" : b = Me.fcGrid.ExportToPDF(sFilePath)
    '            Case "XML" : b = Me.fcGrid.ExportToXML(sFilePath)
    '            Case "CSV" : b = Me.fcGrid.ExportToCSV(sFilePath, False, False)
    '            Case "HTML" : b = Me.fcGrid.ExportToHTML(sFilePath)
    '        End Select
    '    Catch ex As Exception
    '        Throw ex
    '    Finally
    '    End Try

    '    Return b

    'End Function

    'Private Sub _openResultInExcel()

    '    Dim sFilePath As String = ""

    '    Try
    '        sFilePath = Me._checkAndFixTempStorageAndReturnFilepath()

    '        If Me.fcGrid.ExportToExcel(sFilePath) Then
    '            Toolbox.WindowsUtils.ExecuteOpenFileCommand(sFilePath)
    '            'Toolbox.UIUtils.ShowMessageBox(AppMessages.OPEN_FILE_FAILED & vbNewLine & sFilePath, UserSettings.UserAppSettings.ApplicationName, MessageBoxIcon.Error)
    '        Else
    '            Toolbox.UIUtils.ShowMessageBox(AppMessages.EXPORT_FAILED, UserSettings.UserAppSettings.ApplicationName, MessageBoxIcon.Error)
    '        End If

    '    Catch ex As Exception
    '        AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
    '    Finally
    '    End Try

    'End Sub

    'Private Function _checkAndFixTempStorageAndReturnFilepath() As String

    '    Dim sFolderPath As String = ""
    '    Dim sFilePath As String = ""

    '    Try
    '        sFolderPath = Toolbox.FileUtils.SecureFilePath(UserSettings.UserAppSettings.ReportTempFolder)

    '        If Not Toolbox.FileUtils.FolderExists(sFolderPath) Then
    '            If Toolbox.FileUtils.CreateDirectory(sFolderPath) Then
    '                sFilePath = sFolderPath & "temp.xls"
    '                If Not Toolbox.FileUtils.FileExists(sFilePath) Then
    '                    If Not Toolbox.FileUtils.CreateFile(sFilePath) Then
    '                        sFilePath = ""
    '                    End If
    '                End If
    '            End If
    '        End If

    '    Catch ex As Exception
    '        Throw ex
    '    Finally
    '    End Try

    '    Return sFilePath

    'End Function

    'Private Sub _printResult()

    '    Try
    '        Me.fcGrid.PrintPreview()
    '    Catch ex As Exception
    '        AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
    '    Finally
    '    End Try

    'End Sub

    Private Sub _removeReport()

        Dim sKey As String = ""

        Try
            If Toolbox.UIUtils.ConfirmDialog(AppMessages.CONFIRM_REMOVAL, AppMessages.DIALOG_CAPTION) = True Then
                Me._removeReport(sKey)
            End If
        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
        End Try

    End Sub

    Private Sub _removeReport(ByVal sKey As String)

        Dim service As ReportService

        Try
            service = New ReportService()
            If service.Remove(Me._sKey, UserSettings.DBAccessSettings) Then
                Me._loadReportsToCombos(True)
            Else
                Toolbox.UIUtils.ShowMessageBox(AppMessages.FAILED_TO_REMOVE_ITEM, AppMessages.DIALOG_CAPTION, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            service = Nothing
        End Try

    End Sub

    Private Sub _handleTabControlClick()

        If Me.tcTabs.SelectedTab.Name.Equals("tpCreateReport") Then
            Me.FormState = FormStateEnum.LOADING
            Me._loadReportToUI(GUIHelper.GetKeyFromComboString(Me.cboEditableReports.Text.Trim), "EDIT")
            Me.FormState = FormStateEnum.IDLE
        ElseIf Me.tcTabs.SelectedTab.Name.Equals("tpRunReport") Then
            'Me.FormState = FormStateEnum.IDLE
        End If

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me._closeForm(False)
    End Sub

    Private Sub btnSaveResult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me._saveResult()
        'Me.dgData.DrawToBitmap(New Bitmap)

    End Sub

    Private Sub btnPrintResult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me._printResult()
    End Sub

    Private Sub btnOpenResultInExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me._openResultInExcel()
    End Sub

    Private Sub btnSaveReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveReport.Click
        Me._saveReport(AppEnums.DBOperationEnum.INSERT)
    End Sub

    Private Sub rtbSQL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rtbSQL.TextChanged

        If Me.FormState = FormStateEnum.IDLE Then
            Me._setSaveState(True)
            Me._isDirty(True)
        End If

        GUIHelper.SetRemainingCharacterCountInLabel(Me.rtbSQL, Me.txtSQLCounter, "")

    End Sub

    Private Sub btnUpdateReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateReport.Click
        Me._saveReport(AppEnums.DBOperationEnum.UPDATE)
    End Sub

    Private Sub btnRemoveReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveReport.Click
        Me._removeReport()
    End Sub

    Private Sub cboEditableReports_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEditableReports.SelectedIndexChanged
        If Me.FormState = FormStateEnum.IDLE Then
            Me.FormState = FormStateEnum.LOADING
            Me._loadReportToUI(GUIHelper.GetKeyFromComboString(Me.cboEditableReports.Text.Trim), "EDIT")
            Me.FormState = FormStateEnum.IDLE
        End If
    End Sub

    Private Sub cboExecutableReports_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboExecutableReports.SelectedIndexChanged
        'If Me.FormState = FormStateEnum.IDLE Then
        '    Me._runReport()
        'End If
    End Sub

    Private Sub btnRun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRun.Click
        Me._runReport()
    End Sub

    Private Sub txtName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.TextChanged
        If Me.FormState = FormStateEnum.IDLE Then
            Me._setSaveState(True)
            Me._isDirty(True)
        End If
    End Sub

    Private Sub chkActive_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkActive.CheckedChanged
        If Me.FormState = FormStateEnum.IDLE Then
            Me._setSaveState(True)
            Me._isDirty(True)
        End If
    End Sub

    Private Sub tcTabs_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tcTabs.Click
        Me._handleTabControlClick()
    End Sub

    Private Sub btnDrawToBitmap_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveResult.Click
        Me._saveResult()
    End Sub

    Private Sub _saveResult()

        Dim bm As Bitmap = Nothing
        Dim rect As System.Drawing.Rectangle = Nothing
        Dim sFilePath As String = ""
        Dim sb As New StringBuilder

        Try
            Logger.Log("Saving report result...", UserSettings.LogSettings)

            'constructing file name
            '------------------------
            sb.Append(UserSettings.UserAppSettings.ReportResultFolder)
            sb.Append(Toolbox.DateAndTimeUtils.ConvertDate(Toolbox.DateAndTimeUtils.DateStyle.SWEDISH, Toolbox.DateAndTimeUtils.DateFormat.LONG, Date.Now, "-", "-"))
            sb.Append("_")
            sb.Append(GUIHelper.GetValueFromComboString(Me.cboExecutableReports.Text))
            sb.Append(".png")
            sFilePath = sb.ToString

            Logger.Log("...to file: " & sFilePath, UserSettings.LogSettings)
            Logger.Log("Drawing to bitmap...", UserSettings.LogSettings)
            bm = New Bitmap(Me.dgData.Width, Me.dgData.Height)
            rect = New Rectangle(Me.dgData.Location, Me.dgData.Size)
            Me.dgData.DrawToBitmap(bm, rect)
            Logger.Log("Saving to file...", UserSettings.LogSettings)
            bm.Save(sFilePath, Imaging.ImageFormat.Png)
            Logger.Log("Done!", UserSettings.LogSettings)

            If Toolbox.UIUtils.AskConfirmation("Rapporten sparad! Vill du öppna filen?", AppMessages.DIALOG_CAPTION, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Toolbox.WindowsUtils.ExecuteOpenFileCommand(sFilePath)
            End If

        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
            bm.Dispose()
            bm = Nothing
        End Try

    End Sub

End Class
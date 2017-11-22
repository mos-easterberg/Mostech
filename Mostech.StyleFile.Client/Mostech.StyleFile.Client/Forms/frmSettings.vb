
Imports Mostech.Common
Imports Mostech.Common.Entity
Imports Mostech.Common.Forms
Imports Mostech.Common.Settings
Imports Mostech.StyleFile.Entity
Imports Mostech.StyleFile.Service

Imports System.Text

Public Class frmSettings
    Inherits frmStyleFile
    Implements IFormSaveable, IFormCommon

    Private _dbOp As AppEnums.DBOperationEnum

    Private Enum _browseForTypeEnum
        HELPFILE
        BACKUP_SCRIPT
        BACKUP_FOLDER
        IMAGES_SOURCE
        IMAGES_REPOSITORY
        REPORT_RESULT
        JOB_PRINT
    End Enum

    Public WriteOnly Property DBOperation As AppEnums.DBOperationEnum
        Set(ByVal value As AppEnums.DBOperationEnum)
            Me._dbOp = value
        End Set
    End Property

    Private Sub frmSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me._init()
    End Sub

    Private Sub _closeForm(ByVal bConfirm As Boolean) Implements IFormCommon._closeForm

        Try
            If Me.IsDirty Then
                If Toolbox.UIUtils.ConfirmDialog("Vill du spara ändringarna?", AppMessages.DIALOG_CAPTION) Then
                    Me._save()
                Else
                    Toolbox.UIUtils.CloseForm(Me, False, AppMessages.CONFIRM_CLOSE_WINDOW, AppMessages.DIALOG_CAPTION)
                End If
            Else
                Toolbox.UIUtils.CloseForm(Me, False, AppMessages.CONFIRM_CLOSE_WINDOW, AppMessages.DIALOG_CAPTION)
            End If
        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Sub

    Private Sub _init() Implements IFormCommon._init

        Try
            Me._dbOp = AppEnums.DBOperationEnum.UPDATE
            Me._setIcon()
            Me._initUI()
            Me._setUIColor()
            Me._initTooltips()
            Me._loadDBTimeoutsToUI()
            Me._loadEmailSendTimeoutsToUI()
            Me._loadNrOfJobsPerPrintToUI()
            Me._loadSettingsToUI()
            Me._setSaveState(False)
            Me._isDirty(False)
            Toolbox.UIUtils.SetCaption(Me, "Inställningar")
        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
        End Try

    End Sub

    Private Sub _initUI() Implements IFormCommon._initUI

        Try

            'common
            '-------------------------------------------------
            Me.txtRequiredFields.MaxLength = 0

            'pwd
            '-------------------------------------------------
            Me.txtAppPassword.PasswordChar = "*"
            Me.txtAppPasswordRepeat.PasswordChar = "*"
            Me.txtAppPasswordRepeat.Enabled = False
            Me.chkDontUsePassword.Checked = UserSettings.UserAppSettings.Password.Equals("")

            'db
            '-------------------------------------------------
            Me.txtDBPassword.PasswordChar = "*"

            'special
            '-------------------------------------------------

            Me.CancelButton = Me.btnCancel
            Toolbox.UIUtils.SetCommonFormSettings(Me)

        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Sub

    Private Sub _setUIColor() Implements IFormCommon._setUIColor

        Try
            Me.BackColor = Color.FromArgb(Integer.Parse(UserSettings.UserAppSettings.FormBackColor))

            'Me
            '-------------------------------------------------
            For Each ctrl As Control In Me.Controls
                If ctrl.GetType = GetType(Button) Then
                    ctrl.BackColor = Color.FromArgb(Integer.Parse(UserSettings.UserAppSettings.ButtonColor))
                End If
            Next

            'tpGeneral
            '-------------------------------------------------
            For Each ctrl As Control In Me.tpGeneral.Controls
                If ctrl.GetType = GetType(Button) Then
                    ctrl.BackColor = Color.FromArgb(Integer.Parse(UserSettings.UserAppSettings.ButtonColor))
                End If
            Next

            'tpMiscSettings
            '-------------------------------------------------
            For Each ctrl As Control In Me.tpMiscSettings.Controls
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

            Toolbox.UIUtils.SetToolTip(Me.btnCancel, "Stäng")
        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Sub

    Private Sub _loadDBTimeoutsToUI()

        Dim i As Integer = 0

        Try
            For i = 10 To 120
                Me.cboDBTimeOut.Items.Add(i)
            Next
        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Sub

    Private Sub _loadEmailSendTimeoutsToUI()

        Dim i As Integer = 0

        Try
            For i = 1 To 60
                Me.cboEmailTimeout.Items.Add(i)
            Next
        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Sub

    Private Sub _loadNrOfJobsPerPrintToUI()

        Dim i As Integer = 0

        Try
            For i = 1 To 8
                Me.cboNrOfJobsPerPrint.Items.Add(i)
            Next
        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Sub

    Private Sub _loadSettingsToUI()

        Dim color As New Color

        Try

            'common
            '-------------------------------------------------
            Me.txtRequiredFields.BackColor = color.FromArgb(Integer.Parse(UserSettings.UserAppSettings.RequiredFieldsColor))
            Me.chkConfirmAppExit.Checked = UserSettings.UserAppSettings.ConfirmAppExit
            Me.chkDisplayActiveOnly.Checked = UserSettings.UserAppSettings.DisplayActiveOnly
            Me.chkShowTooltips.Checked = UserSettings.UserAppSettings.ShowToolTips
            Me.txtFormBackColor.BackColor = color.FromArgb(Integer.Parse(UserSettings.UserAppSettings.FormBackColor))
            Me.txtButtonColor.BackColor = color.FromArgb(Integer.Parse(UserSettings.UserAppSettings.ButtonColor))
            Me.txtTelephoneInitialText.Text = UserSettings.UserAppSettings.TelephoneInitialText
            Me.cboNrOfJobsPerPrint.Text = UserSettings.UserAppSettings.NrOfJobsPerPrint


            'pwd
            '-------------------------------------------------

            'db
            '-------------------------------------------------
            Me.txtServer.Text = UserSettings.DBAccessSettings.DBServer
            Me.txtPort.Text = UserSettings.DBAccessSettings.DBPort.ToString
            Me.txtDatabase.Text = UserSettings.DBAccessSettings.DBName
            Me.txtUsername.Text = UserSettings.DBAccessSettings.DBUserID
            Me.txtDBPassword.Text = UserSettings.DBAccessSettings.DBPassword
            Me.cboDBTimeOut.Text = UserSettings.DBAccessSettings.DBTimeOutSeconds.ToString

            'special
            '-------------------------------------------------
            Me.txtHelpFilePath.Text = UserSettings.UserAppSettings.HelpFile
            Me.txtBackupScriptPath.Text = UserSettings.UserAppSettings.BackupScriptPath
            Me.txtBackupFolderPath.Text = UserSettings.UserAppSettings.BackupFolderPath
            Me.txtJobImagesSourcePath.Text = UserSettings.UserAppSettings.JobImagesSourcePath
            Me.txtJobImagesRepositoryPath.Text = UserSettings.UserAppSettings.JobImagesRepositoryPath
            Me.txtReportResultPath.Text = UserSettings.UserAppSettings.ReportResultFolder
            Me.txtJobPrintFolderPath.Text = UserSettings.UserAppSettings.JobPrintFolderPath

            'email
            Me.txtEmailReceiver.Text = UserSettings.EmailSettings.EmailReceiverAddress
            Me.txtEmailSender.Text = UserSettings.EmailSettings.EmailFromAddress
            Me.txtEmailServer.Text = UserSettings.EmailSettings.EmailServerName
            Me.txtEmailPort.Text = UserSettings.EmailSettings.EmailServerPort
            Me.cboEmailTimeout.Text = UserSettings.EmailSettings.EmailSendTimeoutSeconds
            Me.chkEmailEnableSSL.Checked = UserSettings.EmailSettings.EmailEnableSSL

        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Me._save()
    End Sub

    Private Sub _save() Implements IFormSaveable._save

        Dim app As AppSettings = Nothing
        Dim db As DBAccess = Nothing
        Dim email As EmailSettings = Nothing

        Try

            'is required fields filled 
            '------------------------
            If Not Me._isRequiredFieldsFilled Then
                Toolbox.UIUtils.ShowMessageBox(AppMessages.REQUIRED_FIELDS_MISSING, AppMessages.DIALOG_CAPTION, MessageBoxIcon.Error)
                Me._setSaveState(False)
                Me._isDirty(False)
            End If


            'instantiate
            '------------------------
            app = Me._instantiateAppSettingsFromUI
            db = Me._instantiateDBSettingsFromUI
            email = Me._instantiateEmailSettingsFromUI
            Me._updateSettingsInstance(app, db, email)


            'is input validated
            '------------------------
            'If Not Me._isInputValidated(Nothing) Then
            '    Toolbox.UIUtils.ShowMessageBox(AppMessages.INPUT_VALIDATION_FAILED, AppMessages.DIALOG_CAPTION, MessageBoxIcon.Exclamation)
            '    Me._setSaveState(False)
            '    Me._isDirty(False)
            '    Exit Sub
            'End If


            'save
            '------------------------
            If Me._saveSettingsToConfigFile(app, db, email) Then
                Toolbox.UIUtils.CloseForm(Me, False, AppMessages.CONFIRM_CLOSE_WINDOW, AppMessages.DIALOG_CAPTION)
            Else
                Toolbox.UIUtils.ShowMessageBox(AppMessages.FAILED_TO_SAVE_ITEM, AppMessages.DIALOG_CAPTION, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
        End Try

    End Sub

    Private Sub _updateSettingsInstance(ByVal app As AppSettings,
                                        ByVal db As DBAccess,
                                        ByVal email As EmailSettings)

        Try

            'common
            '-------------------------------------------------
            UserSettings.UserAppSettings.RequiredFieldsColor = app.RequiredFieldsColor
            UserSettings.UserAppSettings.ConfirmAppExit = app.ConfirmAppExit
            UserSettings.UserAppSettings.DisplayActiveOnly = app.DisplayActiveOnly
            UserSettings.UserAppSettings.ShowToolTips = app.ShowToolTips
            UserSettings.UserAppSettings.FormBackColor = app.FormBackColor
            UserSettings.UserAppSettings.ButtonColor = app.ButtonColor
            UserSettings.UserAppSettings.TelephoneInitialText = app.TelephoneInitialText
            UserSettings.UserAppSettings.NrOfJobsPerPrint = app.NrOfJobsPerPrint

            'pwd
            '-------------------------------------------------
            UserSettings.UserAppSettings.Password = app.Password

            'db
            '-------------------------------------------------
            UserSettings.DBAccessSettings.DBServer = db.DBServer
            UserSettings.DBAccessSettings.DBPort = db.DBPort
            UserSettings.DBAccessSettings.DBName = db.DBName
            UserSettings.DBAccessSettings.DBUserID = db.DBUserID
            UserSettings.DBAccessSettings.DBPassword = db.DBPassword
            UserSettings.DBAccessSettings.DBTimeOutSeconds = db.DBTimeOutSeconds

            'special
            '-------------------------------------------------
            UserSettings.UserAppSettings.HelpFile = app.HelpFile
            UserSettings.UserAppSettings.BackupScriptPath = app.BackupScriptPath
            UserSettings.UserAppSettings.BackupFolderPath = app.BackupFolderPath
            UserSettings.UserAppSettings.JobImagesSourcePath = app.JobImagesSourcePath
            UserSettings.UserAppSettings.JobImagesRepositoryPath = app.JobImagesRepositoryPath
            UserSettings.UserAppSettings.ReportResultFolder = app.ReportResultFolder
            UserSettings.UserAppSettings.JobPrintFolderPath = app.JobPrintFolderPath

            'email
            '-------------------------------------------------
            UserSettings.EmailSettings.EmailEnableSSL = email.EmailEnableSSL
            UserSettings.EmailSettings.EmailFromAddress = email.EmailFromAddress
            UserSettings.EmailSettings.EmailReceiverAddress = email.EmailReceiverAddress
            UserSettings.EmailSettings.EmailSendTimeoutSeconds = email.EmailSendTimeoutSeconds
            UserSettings.EmailSettings.EmailServerName = email.EmailServerName
            UserSettings.EmailSettings.EmailServerPort = email.EmailServerPort

            'uppdatera connstring
            '-------------------------------------------------
            AppHelper.UpdateConnectionString()

        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Sub

    Private Function _saveSettingsToConfigFile(ByVal app As AppSettings,
                                               ByVal db As DBAccess,
                                               ByVal email As EmailSettings) As Boolean

        Dim b As Boolean = False

        Try

            'common
            '-------------------------------------------------
            My.Settings.RequiredFieldsColor = app.RequiredFieldsColor
            My.Settings.ConfirmAppExit = app.ConfirmAppExit
            My.Settings.DisplayActiveOnly = app.DisplayActiveOnly
            My.Settings.ShowToolTips = app.ShowToolTips
            My.Settings.FormBackColor = app.FormBackColor
            My.Settings.ButtonColor = app.ButtonColor
            My.Settings.TelephoneInitialText = app.TelephoneInitialText
            My.Settings.NrOfJobsPerPrint = app.NrOfJobsPerPrint

            'pwd
            '-------------------------------------------------
            My.Settings.Password = Toolbox.EncryptionUtils.SimpleEncrypt(app.Password)

            'db
            '-------------------------------------------------
            My.Settings.DBName = db.DBName
            My.Settings.DBPassword = Toolbox.EncryptionUtils.SimpleEncrypt(db.DBPassword)
            My.Settings.DBPort = db.DBPort
            My.Settings.DBServer = db.DBServer
            My.Settings.DBTimeOutSeconds = db.DBTimeOutSeconds
            My.Settings.DBUserID = db.DBUserID
            'My.Settings.DBVendor = db.DBVendor

            'special
            '-------------------------------------------------
            My.Settings.HelpFile = app.HelpFile
            My.Settings.BackupScriptPath = app.BackupScriptPath
            My.Settings.BackupFolderPath = app.BackupFolderPath
            My.Settings.JobImagesSourcePath = app.JobImagesSourcePath
            My.Settings.JobImagesRepositoryPath = app.JobImagesRepositoryPath
            My.Settings.ReportResultFolder = app.ReportResultFolder
            My.Settings.JobPrintFolderPath = app.JobPrintFolderPath

            'email
            '-------------------------------------------------
            My.Settings.EmailEnableSSL = email.EmailEnableSSL
            My.Settings.EmailFromAddress = email.EmailFromAddress
            My.Settings.EmailReceiverAddress = email.EmailReceiverAddress
            My.Settings.EmailSendTimeoutSeconds = email.EmailSendTimeoutSeconds
            My.Settings.EmailServerName = email.EmailServerName
            My.Settings.EmailServerPort = email.EmailServerPort

            'save
            '-------------------------------------------------
            My.Settings.Save()

            'report
            '-------------------------------------------------
            b = True

        Catch ex As Exception
            Throw ex
        Finally
        End Try

        Return b

    End Function

    Private Function _isRequiredFieldsFilled() As Boolean Implements IFormSaveable._isRequiredFieldsFilled

        Dim b As Boolean = True

        Try
            If Me.txtDatabase.Text.Trim <> "" Then b = True
        Catch ex As Exception
            Throw ex
        Finally
        End Try

        Return b

    End Function

    Private Function _isInputValidated(ByVal entity As Entity.Entity) As Boolean Implements IFormSaveable._isInputValidated
        Return False
    End Function

    Private Sub _setSaveState(ByVal bIsSaveable As Boolean) Implements IFormSaveable._setSaveState
        Me.btnSave.Enabled = bIsSaveable
    End Sub

    Private Sub _isDirty(ByVal b As Boolean) Implements IFormSaveable._isDirty

        Me.IsDirty = b
        If b Then
            Toolbox.UIUtils.SetCaption(Me, "Inställningar (ej sparade)")
        Else
            Toolbox.UIUtils.SetCaption(Me, "Inställningar")
        End If

    End Sub

    'Private Sub _instantiateFromUI(ByVal bValues As Boolean) Implements IFormSaveable._instantiateFromUI
    'End Sub

    Private Function _instantiateAppSettingsFromUI() As AppSettings

        Dim se As New AppSettings

        Try

            'common
            '-------------------------------------------------
            se.ConfirmAppExit = Me.chkConfirmAppExit.Checked
            se.RequiredFieldsColor = Me.txtRequiredFields.BackColor.ToArgb.ToString
            se.DisplayActiveOnly = Me.chkDisplayActiveOnly.Checked
            se.ShowToolTips = Me.chkShowTooltips.Checked
            se.FormBackColor = Me.txtFormBackColor.BackColor.ToArgb.ToString
            se.ButtonColor = Me.txtButtonColor.BackColor.ToArgb.ToString
            se.TelephoneInitialText = Me.txtTelephoneInitialText.Text.Trim
            se.NrOfJobsPerPrint = Me.cboNrOfJobsPerPrint.Text.Trim

            'pwd
            '-------------------------------------------------
            se.Password = Me.txtAppPassword.Text.Trim

            'special
            '-------------------------------------------------
            se.HelpFile = Me.txtHelpFilePath.Text.Trim
            se.BackupScriptPath = Me.txtBackupScriptPath.Text.Trim
            se.BackupFolderPath = Me.txtBackupFolderPath.Text.Trim
            se.JobImagesSourcePath = Me.txtJobImagesSourcePath.Text.Trim
            se.JobImagesRepositoryPath = Me.txtJobImagesRepositoryPath.Text.Trim
            se.ReportResultFolder = Me.txtReportResultPath.Text.Trim
            se.JobPrintFolderPath = Me.txtJobPrintFolderPath.Text.Trim

        Catch ex As Exception
            Throw ex
        Finally
        End Try

        Return se

    End Function

    Private Function _instantiateDBSettingsFromUI() As DBAccess

        Dim db As New DBAccess

        Try
            db.DBServer = Me.txtServer.Text.Trim
            db.DBPort = Integer.Parse(Me.txtPort.Text.Trim)
            db.DBName = Me.txtDatabase.Text.Trim
            db.DBUserID = Me.txtUsername.Text.Trim
            db.DBPassword = Me.txtDBPassword.Text.Trim
            db.DBTimeOutSeconds = Integer.Parse(Me.cboDBTimeOut.Text)
        Catch ex As Exception
            Throw ex
        Finally
        End Try

        Return db

    End Function

    Private Function _instantiateEmailSettingsFromUI() As EmailSettings

        Dim email As New EmailSettings

        Try
            email.EmailEnableSSL = Me.chkEmailEnableSSL.Checked
            email.EmailFromAddress = Me.txtEmailSender.Text.Trim
            email.EmailReceiverAddress = Me.txtEmailReceiver.Text.Trim
            email.EmailSendTimeoutSeconds = Toolbox.ConversionUtils.ParseInteger(Me.cboEmailTimeout.Text)
            email.EmailServerName = Me.txtEmailServer.Text.Trim
            email.EmailServerPort = Toolbox.ConversionUtils.ParseInteger(Me.txtEmailPort.Text)
        Catch ex As Exception
            Throw ex
        Finally
        End Try

        Return email

    End Function

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me._closeForm(False)
    End Sub

    Private Function _showColorPicker(ByVal colorCurrent As Color,
                                      ByVal sFieldType As String) As Color

        Dim dr As DialogResult = Nothing
        Dim color As Color = Nothing

        Try
            Me.colorPicker.SolidColorOnly = True
            Me.colorPicker.AllowFullOpen = False
            Me.colorPicker.ShowHelp = False
            Me.colorPicker.Color = color
            dr = Me.colorPicker.ShowDialog()
            If dr = DialogResult.OK Then
                color = Me.colorPicker.Color
                If color = Drawing.Color.White Then
                    If sFieldType.ToUpper.Equals("REQUIRED_FIELD") Then
                        Toolbox.UIUtils.ShowMessageBox(AppMessages.COLOR_NOT_VALID_FOR_REQUIRED_FIELDS, AppMessages.DIALOG_CAPTION, MessageBoxIcon.Error)
                    End If
                Else
                    Me._setSaveState(True)
                    Me._isDirty(True)
                End If
            End If
        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
        End Try

        Return color

    End Function

    Private Sub _validateUserRight(ByVal sTabTag As String)

        Try

            Select Case sTabTag.ToUpper
                Case "DATABASE" : Me._performLogin()
                Case "PASSWORD" : Me._performLogin()
                Case "EMAIL" : Me._performLogin()
            End Select

        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
        End Try

    End Sub

    Private Sub _performLogin()

        Dim sPwd As String = ""

        Try

            Try
                sPwd = UserSettings.UserAppSettings.Password
            Catch ex As Exception
                sPwd = My.Settings.Password
            End Try

            If sPwd.Length >= 3 Then
                Me._login(sPwd)
            End If
        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
        End Try

    End Sub

    Private Sub _login(ByVal sPassword As String)

        Dim frm As New frmLogin

        Try
            frm.Text = "StyleFile - kontroll av åtkomst"
            frm.Password = sPassword
            AddHandler frm.LoginExecuted, AddressOf frmLogin_LoginExecuted
            frm.ShowDialog()
        Catch ex As Exception
            Throw ex
        Finally
            frm = Nothing
        End Try

    End Sub

    Private Sub frmLogin_LoginExecuted(ByVal sender As System.Object, _
                                       ByVal ea As LoginEventArgs)

        Try
            If ea.LoginSuccess = False Then
                Me.tcTabs.SelectedTab = Me.tcTabs.TabPages.Item(0)
            End If
        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Sub

    Private Sub btnRequiredFields_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRequiredFields.Click
        Me.txtRequiredFields.BackColor = Me._showColorPicker(Me.txtRequiredFields.BackColor, "REQUIRED_FIELD")
    End Sub

    Private Sub btnFormBackColor_Click(sender As System.Object, e As System.EventArgs) Handles btnFormBackColor.Click
        Me.txtFormBackColor.BackColor = Me._showColorPicker(Me.txtFormBackColor.BackColor, "FORM")
    End Sub

    Private Sub btnButtonColor_Click(sender As System.Object, e As System.EventArgs) Handles btnButtonColor.Click
        Me.txtButtonColor.BackColor = Me._showColorPicker(Me.txtButtonColor.BackColor, "BUTTON")
    End Sub

    Private Sub chkConfirmActions_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkConfirmAppExit.CheckedChanged
        Me._setSaveState(True)
        Me._isDirty(True)
    End Sub

    Private Sub txtPriceModel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me._setSaveState(True)
        Me._isDirty(True)
    End Sub

    Private Sub chkDisplayActiveOnly_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDisplayActiveOnly.CheckedChanged
        Me._setSaveState(True)
        Me._isDirty(True)
    End Sub

    Private Sub chkShowTooltips_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkShowTooltips.CheckedChanged
        Me._setSaveState(True)
        Me._isDirty(True)
    End Sub

    Private Sub txtTelephoneInitialText_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTelephoneInitialText.TextChanged
        Me._setSaveState(True)
        Me._isDirty(True)
    End Sub

    Private Sub txtServer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtServer.TextChanged
        Me._setSaveState(True)
        Me._isDirty(True)
    End Sub

    Private Sub txtPort_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPort.TextChanged
        Me._setSaveState(True)
        Me._isDirty(True)
    End Sub

    Private Sub txtDatabase_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDatabase.TextChanged
        Me._setSaveState(True)
        Me._isDirty(True)
    End Sub

    Private Sub txtUsername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsername.TextChanged
        Me._setSaveState(True)
        Me._isDirty(True)
    End Sub

    Private Sub txtPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDBPassword.TextChanged
        Me._setSaveState(True)
        Me._isDirty(True)
    End Sub

    Private Sub cboDBTimeOut_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDBTimeOut.SelectedIndexChanged
        Me._setSaveState(True)
        Me._isDirty(True)
    End Sub

    Private Sub tpDatabase_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tpDatabase.Enter
        Me._validateUserRight(Me.tcTabs.SelectedTab.Tag)
    End Sub

    Private Sub tpPassword_Enter(sender As Object, e As System.EventArgs) Handles tpPassword.Enter
        Me._validateUserRight(Me.tcTabs.SelectedTab.Tag)
    End Sub

    Private Sub txtAppPassword_LostFocus(sender As Object, e As System.EventArgs) Handles txtAppPassword.LostFocus
        'Me._isPwdEqual()
    End Sub

    Private Sub txtAppPassword_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtAppPassword.TextChanged
        Me._setSaveState(True)
        Me._isDirty(True)
        Me.txtAppPasswordRepeat.Enabled = Me.txtAppPassword.Text.Trim.Length >= 3
    End Sub

    Private Sub txtAppPasswordRepeat_LostFocus(sender As Object, e As System.EventArgs) Handles txtAppPasswordRepeat.LostFocus
        Me._isPwdEqual()
    End Sub

    Private Sub txtAppPasswordRepeat_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtAppPasswordRepeat.TextChanged
        Me._setSaveState(True)
        Me._isDirty(True)
    End Sub

    Private Sub txtHelpFilePath_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHelpFilePath.TextChanged
        Me._setSaveState(True)
        Me._isDirty(True)
    End Sub

    Private Sub txtBackupScriptPath_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtBackupScriptPath.TextChanged
        Me._setSaveState(True)
        Me._isDirty(True)
    End Sub

    Private Sub txtBackupFolderPath_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtBackupFolderPath.TextChanged
        Me._setSaveState(True)
        Me._isDirty(True)
    End Sub

    Private Sub txtJobImagesSourcePath_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtJobImagesSourcePath.TextChanged
        Me._setSaveState(True)
        Me._isDirty(True)
    End Sub

    Private Sub txtJobImagesRepositoryPath_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtJobImagesRepositoryPath.TextChanged
        Me._setSaveState(True)
        Me._isDirty(True)
    End Sub

    Private Sub txtJobPrintFilePath_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtJobPrintFolderPath.TextChanged
        Me._setSaveState(True)
        Me._isDirty(True)
    End Sub

    Private Sub txtReportResultPath_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtReportResultPath.TextChanged
        Me._setSaveState(True)
        Me._isDirty(True)
    End Sub

    Private Sub txtEmailReceiver_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtEmailReceiver.TextChanged
        Me._setSaveState(True)
        Me._isDirty(True)
    End Sub

    Private Sub txtEmailSender_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtEmailSender.TextChanged
        Me._setSaveState(True)
        Me._isDirty(True)
    End Sub

    Private Sub txtEmailServer_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtEmailServer.TextChanged, txtEmailPort.TextChanged
        Me._setSaveState(True)
        Me._isDirty(True)
    End Sub

    Private Sub cboEmailPort_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)
        Me._setSaveState(True)
        Me._isDirty(True)
    End Sub

    Private Sub cboEmailTimeout_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboEmailTimeout.SelectedIndexChanged
        Me._setSaveState(True)
        Me._isDirty(True)
    End Sub

    Private Sub chkEmailEnableSSL_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkEmailEnableSSL.CheckedChanged
        Me._setSaveState(True)
        Me._isDirty(True)
    End Sub

    Private Sub cboNrOfJobsPerPrint_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboNrOfJobsPerPrint.SelectedIndexChanged
        Me._setSaveState(True)
        Me._isDirty(True)
    End Sub

    Private Sub btnBrowseForHelpFile_Click(sender As System.Object, e As System.EventArgs) Handles btnBrowseForHelpFile.Click

        Dim sPath As String = ""

        Try
            sPath = Me._browseFileSystemForPath(_browseForTypeEnum.HELPFILE)
            If Not sPath.Equals("") Then Me.txtHelpFilePath.Text = sPath
        Catch ex As Exception
        End Try

    End Sub

    Private Sub btnBrowseForBackupScript_Click(sender As System.Object, e As System.EventArgs) Handles btnBrowseForBackupScript.Click

        Dim sPath As String = ""

        Try
            sPath = Me._browseFileSystemForPath(_browseForTypeEnum.BACKUP_SCRIPT)
            If Not sPath.Equals("") Then Me.txtBackupScriptPath.Text = sPath
        Catch ex As Exception
        End Try

    End Sub

    Private Sub btnBrowseForBackupFolderPath_Click(sender As System.Object, e As System.EventArgs) Handles btnBrowseForBackupFolderPath.Click

        Dim sPath As String = ""

        Try
            sPath = Me._browseFileSystemForPath(_browseForTypeEnum.BACKUP_FOLDER)
            If Not sPath.Equals("") Then Me.txtBackupFolderPath.Text = sPath
        Catch ex As Exception
        End Try

    End Sub

    Private Sub btnBrowseForJobImagesSource_Click(sender As System.Object, e As System.EventArgs) Handles btnBrowseForJobImagesSource.Click

        Dim sPath As String = ""

        Try
            sPath = Me._browseFileSystemForPath(_browseForTypeEnum.IMAGES_SOURCE)
            If Not sPath.Equals("") Then Me.txtJobImagesSourcePath.Text = sPath
        Catch ex As Exception
        End Try

    End Sub

    Private Sub btnBrowseForJobImagesRepository_Click(sender As System.Object, e As System.EventArgs) Handles btnBrowseForJobImagesRepository.Click

        Dim sPath As String = ""

        Try
            sPath = Me._browseFileSystemForPath(_browseForTypeEnum.IMAGES_REPOSITORY)
            If Not sPath.Equals("") Then Me.txtJobImagesRepositoryPath.Text = sPath
        Catch ex As Exception
        End Try

    End Sub

    Private Sub btnBrowseForJobPrintFilePath_Click(sender As System.Object, e As System.EventArgs) Handles btnBrowseForJobPrintFolderPath.Click

        Dim sPath As String = ""

        Try
            sPath = Me._browseFileSystemForPath(_browseForTypeEnum.JOB_PRINT)
            If Not sPath.Equals("") Then Me.txtJobPrintFolderPath.Text = sPath
        Catch ex As Exception
        End Try

    End Sub

    Private Sub btnBrowseForReportResult_Click(sender As System.Object, e As System.EventArgs) Handles btnBrowseForReportResult.Click

        Dim sPath As String = ""

        Try
            sPath = Me._browseFileSystemForPath(_browseForTypeEnum.REPORT_RESULT)
            If Not sPath.Equals("") Then Me.txtReportResultPath.Text = sPath
        Catch ex As Exception
        End Try

    End Sub

    Private Function _browseFileSystemForPath(ByVal browseType As _browseForTypeEnum) As String

        Dim sPath As String = ""
        Dim sFileFilter As String = ""
        Dim sInitialFolder As String = ""

        Try
            sFileFilter = "Alla filer (*.*)|*.*"
            Select Case browseType

                Case _browseForTypeEnum.HELPFILE
                    sInitialFolder = Toolbox.FileUtils.GetFolderPathFromFilePath(UserSettings.UserAppSettings.HelpFile)
                    sPath = Toolbox.UIUtils.BrowseFileSystemForPath(sInitialFolder, sFileFilter, False, Toolbox.UIUtils.PathTypeEnum.FILE)

                Case _browseForTypeEnum.BACKUP_SCRIPT
                    sInitialFolder = Toolbox.FileUtils.GetFolderPathFromFilePath(UserSettings.UserAppSettings.BackupScriptPath)
                    sPath = Toolbox.UIUtils.BrowseFileSystemForPath(sInitialFolder, sFileFilter, False, Toolbox.UIUtils.PathTypeEnum.FILE)

                Case _browseForTypeEnum.BACKUP_FOLDER
                    sInitialFolder = UserSettings.UserAppSettings.BackupFolderPath
                    sPath = Toolbox.UIUtils.BrowseFileSystemForPath(sInitialFolder, sFileFilter, False, Toolbox.UIUtils.PathTypeEnum.FOLDER)

                Case _browseForTypeEnum.IMAGES_REPOSITORY
                    sInitialFolder = UserSettings.UserAppSettings.JobImagesRepositoryPath
                    sPath = Toolbox.UIUtils.BrowseFileSystemForPath(sInitialFolder, sFileFilter, False, Toolbox.UIUtils.PathTypeEnum.FOLDER)

                Case _browseForTypeEnum.IMAGES_SOURCE
                    sInitialFolder = UserSettings.UserAppSettings.JobImagesSourcePath
                    sPath = Toolbox.UIUtils.BrowseFileSystemForPath(sInitialFolder, sFileFilter, False, Toolbox.UIUtils.PathTypeEnum.FOLDER)

                Case _browseForTypeEnum.REPORT_RESULT
                    sInitialFolder = UserSettings.UserAppSettings.ReportResultFolder
                    sPath = Toolbox.UIUtils.BrowseFileSystemForPath(sInitialFolder, sFileFilter, False, Toolbox.UIUtils.PathTypeEnum.FOLDER)

                Case _browseForTypeEnum.JOB_PRINT
                    sInitialFolder = UserSettings.UserAppSettings.JobPrintFolderPath
                    sPath = Toolbox.UIUtils.BrowseFileSystemForPath(sInitialFolder, sFileFilter, False, Toolbox.UIUtils.PathTypeEnum.FOLDER)

            End Select
        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
        End Try

        Return sPath

    End Function

    Private Sub _isPwdEqual()

        Dim sAppPassword As String = ""
        Dim sAppPasswordRepeat As String = ""

        Try
            sAppPassword = Me.txtAppPassword.Text.Trim
            sAppPasswordRepeat = Me.txtAppPasswordRepeat.Text.Trim

            If Not sAppPassword.ToUpper.Equals(sAppPasswordRepeat.ToUpper) Then
                Toolbox.UIUtils.ShowMessageBox(AppMessages.PASSWORDS_NOT_EQUAL, AppMessages.DIALOG_CAPTION, MessageBoxIcon.Exclamation)
            End If

        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        End Try

    End Sub

    Private Sub _toggleUseEmptyPwd(ByVal bEmpty As Boolean)
        Me.txtAppPassword.Enabled = Not bEmpty
        Me.txtAppPasswordRepeat.Enabled = Not bEmpty

        If bEmpty Then
            Me.txtAppPassword.Clear()
            Me.txtAppPasswordRepeat.Clear()
        End If

    End Sub

    Private Sub chkDontUsePassword_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkDontUsePassword.CheckedChanged
        Me._toggleUseEmptyPwd(Me.chkDontUsePassword.Checked)
        Me._setSaveState(True)
        Me._isDirty(True)
    End Sub

End Class
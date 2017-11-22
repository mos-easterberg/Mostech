
Imports Mostech.Common
Imports Mostech.Common.Entity
Imports Mostech.Common.Forms
Imports Mostech.Common.Logging
Imports Mostech.StyleFile.Service
Imports Mostech.StyleFile.Entity

Imports System.Text
Imports System.IO

Public Class frmJob
    Inherits frmStyleFile
    Implements IFormSaveable, IFormCommon

    Private _sID As String
    Private _sKey As String
    Private _sCustomerKey As String
    Private _sCustomerID As String
    Private _sCustomerName As String
    Private _dbOp As AppEnums.DBOperationEnum

    Private Enum ImageLocationType
        SOURCE
        REPOSITORY
        TEMP
    End Enum

    Public WriteOnly Property Key As String
        Set(ByVal value As String)
            Me._sKey = value
        End Set
    End Property

    Public WriteOnly Property CustomerKey As String
        Set(ByVal value As String)
            Me._sCustomerKey = value
        End Set
    End Property

    Public WriteOnly Property CustomerID As String
        Set(ByVal value As String)
            Me._sCustomerID = value
        End Set
    End Property

    Public WriteOnly Property CustomerName As String
        Set(ByVal value As String)
            Me._sCustomerName = value
        End Set
    End Property

    Public WriteOnly Property DBOperation As AppEnums.DBOperationEnum
        Set(ByVal value As AppEnums.DBOperationEnum)
            Me._dbOp = value
        End Set
    End Property

    Private Sub frmJob_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If e.CloseReason = 0 Then
            e.Cancel = True
        End If

    End Sub

    Private Sub frmJob_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me._init()
    End Sub

    Private Sub btnAddImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddImage.Click
        Me._addImage()
    End Sub

    Private Sub btnRemoveImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveImage.Click
        Me._removeImage()
    End Sub

    Private Sub btnOpenImageExternally_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenImageExternally.Click
        Me._openImageExternally()
    End Sub

    Private Sub cboImages_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboImages.SelectedIndexChanged
        If Me.FormState = FormStateEnum.IDLE Then
            Me._updateSelectedImage()
        End If
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
            Me.FormState = FormStateEnum.LOADING
            Me._setIcon()
            Me._initUI()
            Me._setUIColor()
            Me._initTooltips()
            Me._loadClockTimesToUI()
            Me._setCurrentClockTimesToUI()
            Me._loadVATPercentagesToUI()
            Me._loadJobCategoriesToUI()
            Me._loadStylistsToUI()

            If Me._dbOp = AppEnums.DBOperationEnum.UPDATE Then
                Me._loadJobToUI(Me._sKey)
                Me._loadImagesToUI(Me._sKey)
            Else
                Me.btnAddImage.Enabled = False
                Me.btnRemoveImage.Enabled = False
                Me.btnOpenImageExternally.Enabled = False
            End If

            Me._setSaveState(False)
            Me._isDirty(False)

            Toolbox.UIUtils.SetCaption(Me, "Arbete")
            Me.lblCustomerName.Text = Me._sCustomerName

        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
            Me.FormState = FormStateEnum.IDLE
        End Try

    End Sub

    Private Sub _initUI() Implements IFormCommon._initUI

        Try
            Me.txtID.MaxLength = 7
            Me.txtID.ReadOnly = True
            Me.txtJobDuration.MaxLength = 4
            Me.txtJobDuration.Text = 0
            Me.txtPriceExclVAT.ReadOnly = True
            Me.txtJobDescription.MaxLength = 1000

            Me.cboStylist.DropDownStyle = ComboBoxStyle.DropDownList
            Me.cboVAT.DropDownStyle = ComboBoxStyle.DropDownList

            Me.btnOpenImageExternally.Enabled = False
            Me.dtJobDate.Format = DateTimePickerFormat.Short
            Me.dtJobDate.Value = Date.Today

            'Me.AcceptButton = Me.btnSave
            Me.CancelButton = Me.btnCancel
            Toolbox.UIUtils.SetCommonFormSettings(Me)

            AppHelper.SetReqFieldsColor(Me.cboCategory)
            AppHelper.SetReqFieldsColor(Me.cboStylist)

            Toolbox.UIUtils.SetFocus(Me.cboCategory)

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

            Toolbox.UIUtils.SetToolTip(Me.btnOpenImageExternally, AppMessages.OPEN_IMAGE_EXTERNALLY)
        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Sub

    Private Sub _loadClockTimesToUI()

        Try
            For i = 0 To 23
                Me.cboStartHour.Items.Add(Toolbox.StringUtils.Pad(i.ToString, "0", 2, Toolbox.StringUtils.PadDirection.LEFT))
                Me.cboEndHour.Items.Add(Toolbox.StringUtils.Pad(i.ToString, "0", 2, Toolbox.StringUtils.PadDirection.LEFT))
            Next
            For i = 0 To 59 Step 5
                Me.cboStartMinute.Items.Add(Toolbox.StringUtils.Pad(i.ToString, "0", 2, Toolbox.StringUtils.PadDirection.LEFT))
                Me.cboEndMinute.Items.Add(Toolbox.StringUtils.Pad(i.ToString, "0", 2, Toolbox.StringUtils.PadDirection.LEFT))
            Next
        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
        End Try

    End Sub

    Private Sub _setCurrentClockTimesToUI()

        Try
            Me.cboStartHour.Text = Toolbox.StringUtils.Pad(Date.Now.Hour.ToString, "0", 2, Toolbox.StringUtils.PadDirection.LEFT)
            Me.cboEndHour.Text = Me.cboStartHour.Text
            Me.cboStartMinute.Text = "00"
            Me.cboEndMinute.Text = "05"
        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
        End Try

    End Sub

    Private Sub _save() Implements IFormSaveable._save

        Dim jb As Job

        Try

            'is required fields filled 
            '------------------------
            If Not Me._isRequiredFieldsFilled Then
                Toolbox.UIUtils.ShowMessageBox(AppMessages.REQUIRED_FIELDS_MISSING, AppMessages.DIALOG_CAPTION, MessageBoxIcon.Exclamation)
                Me._setSaveState(False)
                Me._isDirty(False)
            End If

            'instantiate
            '------------------------
            jb = Me._instantiateFromUI(False)

            'is input validated
            '------------------------
            If Not Me._isInputValidated(jb) Then
                Toolbox.UIUtils.ShowMessageBox(AppMessages.INPUT_VALIDATION_FAILED, AppMessages.DIALOG_CAPTION, MessageBoxIcon.Exclamation)
                Me._setSaveState(False)
                Me._isDirty(False)
                Exit Sub
            End If

            'save
            '------------------------
            If Me._saveJob(jb) Then
                Toolbox.UIUtils.CloseForm(Me, False, AppMessages.CONFIRM_CLOSE_WINDOW, AppMessages.DIALOG_CAPTION)
            Else
                Toolbox.UIUtils.ShowMessageBox(AppMessages.FAILED_TO_SAVE_ITEM, AppMessages.DIALOG_CAPTION, MessageBoxIcon.Exclamation)
            End If

        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
        End Try

    End Sub

    Private Sub _setSaveState(ByVal bIsSaveable As Boolean) Implements IFormSaveable._setSaveState
        Me.btnSave.Enabled = bIsSaveable
    End Sub

    Private Sub _isDirty(ByVal b As Boolean) Implements IFormSaveable._isDirty

        Me.IsDirty = b
        If b Then
            Toolbox.UIUtils.SetCaption(Me, "Arbete (ej sparat)")
        Else
            Toolbox.UIUtils.SetCaption(Me, "Arbete")
        End If

    End Sub

    Private Function _isRequiredFieldsFilled() As Boolean Implements IFormSaveable._isRequiredFieldsFilled

        Dim b As Boolean = False

        Try
            b = Me.cboStylist.Text.Length > 0
        Catch ex As Exception
            b = False
            Throw ex
        End Try

        Return b

    End Function

    Private Function _isInputValidated(ByVal entity As Entity.Entity) As Boolean Implements IFormSaveable._isInputValidated

        Dim b As Boolean = False
        Dim jb As Job = Nothing
        Dim sSQLDelimiterChar As String = ""

        Try
            b = True
            jb = DirectCast(entity, Job)
            sSQLDelimiterChar = "'"

            If jb.Description.Contains(sSQLDelimiterChar) Then Return False

        Catch ex As Exception
            b = False
            Throw ex
        End Try

        Return b

    End Function

    Private Function _instantiateFromUI(ByVal bInstantiateValues As Boolean) As Job

        Dim jb As Job

        Try
            jb = New Job

            jb.Category = GUIHelper.GetKeyFromComboString(Me.cboCategory.Text)
            jb.JobDate = Toolbox.DateAndTimeUtils.FormatDateForMySQL(Me.dtJobDate.Value)
            jb.StartTime = Me.cboStartHour.Text & ":" & Me.cboStartMinute.Text
            jb.EndTime = Me.cboEndHour.Text & ":" & Me.cboEndMinute.Text
            If Me.txtJobDuration.Text <> "" Then jb.Duration = Toolbox.ConversionUtils.ParseInteger(Me.txtJobDuration.Text)
            If Me.cboStylist.Text <> "" Then jb.Stylist = GUIHelper.GetKeyFromComboString(Me.cboStylist.Text)

            If Me.txtPriceExclVAT.Text <> "" Then
                jb.PriceInclVAT = Toolbox.ConversionUtils.ParseDecimal(Me.mtxtPriceInclVAT.Text.Trim)
                jb.VATPercentage = Toolbox.ConversionUtils.ParseInteger(Me.cboVAT.Text)
                jb.PriceExclVAT = Toolbox.ConversionUtils.ParseDecimal(Me.txtPriceExclVAT.Text)
            End If

            jb.Description = Me.txtJobDescription.Text.Trim
            jb = AppHelper.SetCommonEntitySettings(jb)

            'for printing
            If bInstantiateValues Then
                jb.ID = Me._sID
                jb.Customer = ServiceHelper.TranslateKeyToValue("cu_key", Me._sCustomerKey, "concat(cu_lastname, ' ', cu_firstname)", AppEnums.EntityEnum.CUSTOMER)
                jb.Category = GUIHelper.GetValueFromComboString(Me.cboCategory.Text)
                If Me.cboStylist.Text <> "" Then jb.Stylist = GUIHelper.GetValueFromComboString(Me.cboStylist.Text)
            End If

        Catch ex As Exception
            Throw ex
        Finally
        End Try

        Return jb

    End Function

    Private Function _saveJob(ByVal jb As Job) As Boolean

        Dim b As Boolean = False
        Dim service As JobService

        Try
            service = New JobService()
            jb.Customer = Me._sCustomerKey
            If Me._dbOp = AppEnums.DBOperationEnum.INSERT Then
                jb.Key = AppHelper.GetEntityKey
                b = service.Add(jb, UserSettings.DBAccessSettings)
            Else
                jb.Key = Me._sKey
                b = service.Update(jb, UserSettings.DBAccessSettings)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            service = Nothing
        End Try

        Return b

    End Function

    Private Sub _loadJobToUI(ByVal sKey As String)

        Dim jb As Job
        Dim arr As ArrayList

        Try
            jb = ServiceHelper.LoadJobFromDB(sKey, AppEnums.EntityLoadTypeEnum.KEYS)

            Me._sID = jb.ID

            Me.txtID.Text = jb.ID
            Me.txtCreated.Text = jb.Created
            Me.txtEdited.Text = jb.Updated
            Me.cboCategory.Text = GUIHelper.GetLookupValue(jb.Category, Me.cboCategory.Items)
            Me.dtJobDate.Value = CDate(jb.JobDate)

            arr = Toolbox.StringUtils.Split(jb.StartTime, ":")
            Me.cboStartHour.Text = arr(0)
            Me.cboStartMinute.Text = arr(1)

            arr = Toolbox.StringUtils.Split(jb.EndTime, ":")
            Me.cboEndHour.Text = arr(0)
            Me.cboEndMinute.Text = arr(1)

            Me.txtJobDuration.Text = jb.Duration.ToString
            Me.cboStylist.Text = GUIHelper.GetLookupValue(jb.Stylist, Me.cboStylist.Items)

            If jb.PriceInclVAT > 0 Then
                Me.mtxtPriceInclVAT.Text = jb.PriceInclVAT.ToString
                Me.cboVAT.Text = jb.VATPercentage.ToString
                Me.txtPriceExclVAT.Text = jb.PriceExclVAT.ToString
            End If

            Me.txtJobDescription.Text = jb.Description

        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Sub

    Private Sub _loadStylistsToUI()

        Try
            For Each s As Stylist In ServiceHelper.LoadStylistsFromDB(True)
                Me.cboStylist.Items.Add(s.LastName & " " & s.FirstName & GUIHelper.COMBOBOX_SEPARATOR & s.Key)
            Next
            Me.cboStylist.Text = Me.cboStylist.Items(0)
        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Sub

    Private Sub _loadJobCategoriesToUI()

        Dim s As String = ""

        Try
            For Each ct As Category In ServiceHelper.GetCategories(AppEnums.CategoryTypeEnum.JOB, True)
                Me.cboCategory.Items.Add(ct.Value & GUIHelper.COMBOBOX_SEPARATOR & ct.Key)
                If ct.Default Then s = ct.Value & GUIHelper.COMBOBOX_SEPARATOR & ct.Key
            Next
            Me.cboCategory.Text = s
        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Sub

    Private Sub _loadVATPercentagesToUI()

        Dim s As String = ""

        Try
            For Each ct As Category In ServiceHelper.GetCategories(AppEnums.CategoryTypeEnum.VATPERCENTAGE, True)
                'Me.cboVAT.Items.Add(ct.Value & GUIHelper.COMBOBOX_SEPARATOR & ct.Key)
                Me.cboVAT.Items.Add(ct.Value)
                If ct.Default Then s = ct.Value '& GUIHelper.COMBOBOX_SEPARATOR & ct.Key
            Next
            Me.cboVAT.Text = s
        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Sub

    Private Sub _calculateJobDuration(ByVal iStartHour As Integer, _
                                      ByVal iStartMinute As Integer, _
                                      ByVal iEndHour As Integer, _
                                      ByVal iEndMinute As Integer)

        Dim iDurationHour As Integer = 0
        Dim iDurationMinute As Integer = 0
        Dim bIsCorrectTime As Boolean = True

        Try
            If iStartHour < 0 Or iStartHour > 23 Then bIsCorrectTime = False
            If iStartMinute < 0 Or iStartMinute > 59 Then bIsCorrectTime = False
            If iEndHour < 0 Or iEndHour > 23 Then bIsCorrectTime = False
            If iEndMinute < 0 Or iEndMinute > 59 Then bIsCorrectTime = False

            If iEndHour < iStartHour Then
                bIsCorrectTime = False
            ElseIf iStartHour = iEndHour Then
                If iEndMinute <= iStartMinute Then
                    bIsCorrectTime = False
                    'Me.cboEndMinute.Text = Me.cboEndMinute.Text + 1
                End If
            End If

            If bIsCorrectTime Then
                iDurationHour = iEndHour - iStartHour
                iDurationMinute = iEndMinute - iStartMinute
                Me.txtJobDuration.Text = Toolbox.DateAndTimeUtils.GetDurationInMinutes(iDurationHour, iDurationMinute)
            Else
                Me._handleCalculateJobDurationError()
            End If

        Catch ex As Exception
            Me._handleCalculateJobDurationError()
        Finally
        End Try

    End Sub

    Private Sub _handleCalculateJobDurationError()

        Try
            Toolbox.UIUtils.ShowMessageBox(AppMessages.INVALID_TIME, AppMessages.DIALOG_CAPTION, MessageBoxIcon.Exclamation)
            Me._setCurrentClockTimesToUI()
            Me.txtJobDuration.Text = ""
        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Sub

    Private Sub _calculatePriceExclVAT(ByVal sNetPrice As String, _
                                       ByVal sTaxPercentage As String)

        Dim dNetPrice As Double = 0.0
        Dim iTaxPercentage As Integer = 0

        Try
            sNetPrice = sNetPrice.Trim

            If sNetPrice.Trim <> "" AndAlso sNetPrice.Trim <> "," Then
                dNetPrice = Toolbox.ConversionUtils.ParseDouble(sNetPrice)
            Else
                Me.txtPriceExclVAT.Text = ""
                Exit Sub
            End If

            If sTaxPercentage <> "" Then
                iTaxPercentage = Toolbox.ConversionUtils.ParseInteger(sTaxPercentage)
            Else
                Me.txtPriceExclVAT.Text = ""
                Exit Sub
            End If

            If dNetPrice > 0 And iTaxPercentage > 0 Then
                Me.txtPriceExclVAT.Text = Toolbox.MiscUtils.CalculatePriceExclVAT(dNetPrice, iTaxPercentage, True)
            Else
                Me.txtPriceExclVAT.Text = ""
                Exit Sub
            End If

        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
        End Try

    End Sub

    Private Sub _print(ByVal sCustomerID As String)

        Dim b As Boolean = False
        Dim jb As Job = Nothing
        Dim pj As PrintJob = Nothing
        Dim sFormattedJob As String = ""
        Dim coll As Collection = Nothing

        Try

            'init 
            '-------------------------------------------------
            pj = New PrintJob
            coll = New Collection

            'dirty job?
            '-------------------------------------------------
            If Me.IsDirty Then
                Toolbox.UIUtils.ShowMessageBox(AppMessages.JOB_SAVE_BEFORE_PRINT, AppMessages.DIALOG_CAPTION, MessageBoxIcon.Stop)
                Exit Sub
            End If

            'get job from UI
            '-------------------------------------------------
            jb = Me._instantiateFromUI(True)
            Logger.Log("Printing job " & jb.ID & "...", UserSettings.LogSettings)

            'format job
            '-------------------------------------------------
            sFormattedJob = AppHelper.FormatJob(jb, AppEnums.JobFormatStyleEnum.TEXT)

            'set print job
            '-------------------------------------------------
            pj.ID = 1
            pj.Data = sFormattedJob
            'pj.Encoding = UserSettings.UserAppSettings.FileEncoding
            'pj.FilePath = Toolbox.FileUtils.CombinePath(UserSettings.UserAppSettings.JobPrintFolderPath, jb.ID) & ".txt"

            'print
            '-------------------------------------------------
            coll.Add(pj)
            b = PrintHelper.PrintJob(coll, sCustomerID, UserSettings.UserAppSettings.FileEncoding)

            'report
            '-------------------------------------------------
            If b Then
                Toolbox.UIUtils.ShowMessageBox(AppMessages.PRINTJOB_SENT_TO_PRINTER, AppMessages.DIALOG_CAPTION, MessageBoxIcon.Information)
                Logger.Log(AppMessages.PRINTJOB_SENT_TO_PRINTER, UserSettings.LogSettings)
            Else
                Toolbox.UIUtils.ShowMessageBox(AppMessages.PRINTJOB_NOT_SENT_TO_PRINTER, AppMessages.DIALOG_CAPTION, MessageBoxIcon.Error)
                Logger.Log(AppMessages.PRINTJOB_NOT_SENT_TO_PRINTER, UserSettings.LogSettings)
            End If

        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
        End Try

    End Sub

    Private Sub btnPrintJob_Click(sender As System.Object, e As System.EventArgs) Handles btnPrintJob.Click
        Me._print(Me._sCustomerID)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me._closeForm(False)
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Me._save()
    End Sub

    Private Sub cboCategory_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCategory.TextChanged
        Me._setSaveState(True)
        Me._isDirty(True)
    End Sub

    Private Sub dtJobDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtJobDate.ValueChanged
        Me._setSaveState(True)
        Me._isDirty(True)
    End Sub

    Private Sub cboStylist_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Me._setSaveState(True)
        Me._isDirty(True)
    End Sub

    Private Sub cboVAT_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboVAT.TextChanged
        Me._setSaveState(True)
        Me._isDirty(True)
    End Sub

    Private Sub txtJobDescription_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtJobDescription.TextChanged
        Me._setSaveState(True)
        Me._isDirty(True)
        GUIHelper.SetRemainingCharacterCountInLabel(Me.txtJobDescription, Me.gbJobDescription, "Beskrivning")
    End Sub

    'Private Sub mtxtJobStartTime_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
    '    If Me.FormState = FormStateEnum.IDLE Then
    '        Me._calculateJobDuration(Me.mtxtJobStartTime.Text.Trim, Me.mtxtJobEndTime.Text.Trim)
    '    End If
    'End Sub

    Private Sub mtxtJobStartTime_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Me._setSaveState(True)
        Me._isDirty(True)
    End Sub

    'Private Sub mtxtJobEndTime_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
    '    If Me.FormState = FormStateEnum.IDLE Then
    '        Me._calculateJobDuration(Me.mtxtJobStartTime.Text.Trim, Me.mtxtJobEndTime.Text.Trim)
    '    End If
    'End Sub

    Private Sub mtxtJobEndTime_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Me._setSaveState(True)
        Me._isDirty(True)
    End Sub

    Private Sub mtxtPriceInclVAT_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mtxtPriceInclVAT.LostFocus
        If Me.FormState = FormStateEnum.IDLE Then
            Me._formatPrice(Me.mtxtPriceInclVAT.Text.Trim)
        End If
    End Sub

    Private Sub mtxtPriceInclVAT_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles mtxtPriceInclVAT.TextChanged
        Me._setSaveState(True)
        Me._isDirty(True)
    End Sub

    Private Sub cboVAT_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboVAT.SelectedIndexChanged
        Me._setSaveState(True)
        Me._isDirty(True)
        If Me.FormState = FormStateEnum.IDLE Then
            Me._calculatePriceExclVAT(Me.mtxtPriceInclVAT.Text.Trim, Me.cboVAT.Text)
        End If
    End Sub

    Private Sub cboCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCategory.SelectedIndexChanged
        Me._setSaveState(True)
        Me._isDirty(True)
    End Sub

    Private Sub cboStylist_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboStylist.SelectedIndexChanged
        Me._setSaveState(True)
        Me._isDirty(True)
    End Sub

    Private Sub cboStartHour_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboStartHour.SelectedIndexChanged
        Me._setSaveState(True)
        Me._isDirty(True)
        If Me.FormState = FormStateEnum.IDLE Then
            Me._calculateJobDuration(Integer.Parse(Me.cboStartHour.Text), _
                                     Integer.Parse(Me.cboStartMinute.Text), _
                                     Integer.Parse(Me.cboEndHour.Text), _
                                     Integer.Parse(Me.cboEndMinute.Text))
        End If
    End Sub

    Private Sub cboEndHour_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEndHour.SelectedIndexChanged
        Me._setSaveState(True)
        Me._isDirty(True)
        If Me.FormState = FormStateEnum.IDLE Then
            Me._calculateJobDuration(Integer.Parse(Me.cboStartHour.Text), _
                                     Integer.Parse(Me.cboStartMinute.Text), _
                                     Integer.Parse(Me.cboEndHour.Text), _
                                     Integer.Parse(Me.cboEndMinute.Text))
        End If
    End Sub

    Private Sub cboStartMinute_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboStartMinute.SelectedIndexChanged
        Me._setSaveState(True)
        Me._isDirty(True)
        If Me.FormState = FormStateEnum.IDLE Then
            Me._calculateJobDuration(Integer.Parse(Me.cboStartHour.Text), _
                                     Integer.Parse(Me.cboStartMinute.Text), _
                                     Integer.Parse(Me.cboEndHour.Text), _
                                     Integer.Parse(Me.cboEndMinute.Text))
        End If
    End Sub

    Private Sub cboEndMinute_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEndMinute.SelectedIndexChanged
        Me._setSaveState(True)
        Me._isDirty(True)
        If Me.FormState = FormStateEnum.IDLE Then
            Me._calculateJobDuration(Integer.Parse(Me.cboStartHour.Text), _
                                     Integer.Parse(Me.cboStartMinute.Text), _
                                     Integer.Parse(Me.cboEndHour.Text), _
                                     Integer.Parse(Me.cboEndMinute.Text))
        End If
    End Sub

    Private Sub _formatPrice(ByVal sPrice As String)

        Dim sb As New StringBuilder
        Dim sDecimalPart As String = ""
        Dim sPricePart As String = ""
        Dim arr As New ArrayList

        Try
            'change "." --> ","
            If sPrice.Contains(".") Then sPrice = Toolbox.StringUtils.Replace(sPrice, ".", ",")

            Try
                arr = Toolbox.StringUtils.Split(sPrice, ",")
                sPricePart = arr(0)
                Select Case arr.Count
                    Case 1
                        'add 00-decimals
                        sDecimalPart = "00"
                    Case 2
                        sDecimalPart = arr(1).ToString.Substring(0, 2)
                End Select
            Catch ex As Exception
            End Try

            'construct price
            sPrice = sPricePart & "," & sDecimalPart
            Me.mtxtPriceInclVAT.Text = sPrice

            'calculate price excl VAT
            Me._calculatePriceExclVAT(sPrice, Me.cboVAT.Text)

        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
        End Try

    End Sub

    Private Sub _addImage()

        Dim sSourceFilePath As String = ""
        Dim sSourceFileName As String = ""
        Dim ofd As OpenFileDialog = Nothing
        Dim dr As DialogResult = Nothing
        Dim imgProps As ImageProps = Nothing
        Dim img As Image = Nothing
        Dim bContinue As Boolean = False

        Try

            'init
            '-------------------------------------------------
            bContinue = True


            'show dialog
            '-------------------------------------------------
            If bContinue Then
                Try
                    ofd = New OpenFileDialog
                    ofd.InitialDirectory = UserSettings.UserAppSettings.JobImagesSourcePath
                    ofd.ShowReadOnly = True
                    ofd.CheckFileExists = True
                    ofd.Multiselect = False
                    ofd.Filter = "Bildfiler(*.png;*.jpg;*.gif)|*.png;*.jpg;*.gif|Alla filer (*.*)|*.*"
                    dr = ofd.ShowDialog()
                Catch ex As Exception
                    bContinue = False
                End Try
            End If


            'was OK pressed?
            '-------------------------------------------------
            If bContinue Then
                bContinue = (dr = DialogResult.OK)
                If Not bContinue Then Exit Sub
            End If


            'new image?
            '-------------------------------------------------
            If bContinue Then
                sSourceFilePath = ofd.FileName
                sSourceFileName = Toolbox.FileUtils.GetFileNameFromPath(sSourceFilePath)
                For Each s As String In Me.cboImages.Items
                    s = GUIHelper.GetValueFromComboString(s)
                    If sSourceFileName.ToUpper.Equals(s.ToUpper) Then
                        Toolbox.UIUtils.ShowMessageBox("Bild '" & sSourceFileName & "' finns redan!", AppMessages.DIALOG_CAPTION, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                Next
            End If


            'assign properties
            '-------------------------------------------------
            If bContinue Then
                Try
                    img = Image.FromFile(sSourceFilePath)
                    imgProps = New ImageProps
                    imgProps.Key = AppHelper.GetEntityKey
                    imgProps.ParentKey = Me._sKey
                    imgProps.FileName = sSourceFileName
                    imgProps = AppHelper.SetCommonEntitySettings(imgProps)
                    imgProps.Image = img
                Catch ex As Exception
                    bContinue = False
                End Try
            End If


            'save to filesys
            '-------------------------------------------------
            If bContinue Then
                Try
                    bContinue = Me._saveImageToFileSystemRepository(imgProps, sSourceFilePath, Me._sID)
                Catch ex As Exception
                    bContinue = False
                End Try
            End If


            'save to db
            '------------------------
            If bContinue Then
                Try
                    bContinue = Me._saveImageToDB(imgProps)
                Catch ex As Exception
                    bContinue = False
                End Try
            End If


            'load to UI
            '-------------------------------------------------
            If bContinue Then
                Try
                    Me._loadImagesToUI(Me._sKey)
                    Me.pbImage.Image = imgProps.Image
                    Me.pbImage.Tag = imgProps.Key
                    Me.cboImages.Text = imgProps.FileName & GUIHelper.COMBOBOX_SEPARATOR & imgProps.Key
                Catch ex As Exception
                    bContinue = False
                End Try
            End If


            'report
            '-------------------------------------------------
            If Not bContinue Then
                Toolbox.UIUtils.ShowMessageBox(AppMessages.FAILED_TO_SAVE_ITEM, AppMessages.DIALOG_CAPTION, MessageBoxIcon.Error)
            End If


        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
            img = Nothing
        End Try

    End Sub

    Private Function _saveImageToDB(ByVal imgProps As ImageProps) As Boolean

        Dim service As ImageService

        Try
            service = New ImageService()
            Return service.Add(imgProps, UserSettings.DBAccessSettings)
        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
            service = Nothing
        End Try

        Return False

    End Function

    Private Function _saveImageToFileSystemRepository(ByVal imgProps As ImageProps,
                                                      ByVal sSourceFilePath As String,
                                                      ByVal sKey As String) As Boolean

        Dim sRepositoryFolderPath As String = ""
        Dim sRepositoryFilePath As String = ""
        Dim bContinue As Boolean = False

        Try

            'init
            '-------------------------------------------------
            bContinue = True


            'create directory per job id
            '-------------------------------------------------
            If bContinue Then
                sRepositoryFolderPath = Toolbox.FileUtils.CombinePath(UserSettings.UserAppSettings.JobImagesRepositoryPath, sKey)
                If Not Toolbox.FileUtils.FolderExists(sRepositoryFolderPath) Then
                    bContinue = Toolbox.FileUtils.CreateDirectory(sRepositoryFolderPath)
                End If
            End If


            'copy image 
            '-------------------------------------------------
            If bContinue Then
                sRepositoryFilePath = Toolbox.FileUtils.CombinePath(sRepositoryFolderPath, imgProps.FileName)
                bContinue = Toolbox.FileUtils.CopyFile(sSourceFilePath, sRepositoryFilePath, True)
            End If


            'finish up
            '-------------------------------------------------
            If bContinue Then
                Logger.Log("File " & imgProps.FileName & " saved to job " & imgProps.ID, UserSettings.LogSettings, LogEnums.LogMode.DISC)
            Else
                bContinue = Toolbox.FileUtils.DeleteFile(sRepositoryFilePath)
            End If


        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
        End Try

        Return bContinue

    End Function

    Private Sub _removeImage()

        Dim service As ImageService = Nothing
        Dim sFileName As String = ""
        Dim sFilePath As String = ""
        Dim bContinue As Boolean = False


        Try

            'init
            '-------------------------------------------------
            service = New ImageService()
            sFileName = GUIHelper.GetValueFromComboString(Me.cboImages.Text)
            sFilePath = Me._getImageFilePath(ImageLocationType.REPOSITORY, sFileName)
            bContinue = True


            'remove from db
            '-------------------------------------------------
            If bContinue Then
                Logger.Log("Removing image " & sFileName & " from database...", UserSettings.LogSettings)
                If service.Remove(Me.pbImage.Tag, UserSettings.DBAccessSettings) Then
                    Logger.Log("Done!", UserSettings.LogSettings)
                Else
                    Logger.Log("Failed!", UserSettings.LogSettings)
                    bContinue = False
                End If
            End If


            'remove from filesys
            '-------------------------------------------------
            If bContinue Then
                Logger.Log("Removing image from file system...", UserSettings.LogSettings)
                Try
                    Toolbox.FileUtils.SetFileAttributes(sFilePath, FileAttributes.Normal)
                    bContinue = (Toolbox.FileUtils.DeleteFile(sFilePath, 5, 1) > 0)
                Catch ex As Exception
                    Logger.Log("Error: " & ex.Message, UserSettings.LogSettings)
                End Try

                If bContinue Then
                    Me.pbImage.Image = Nothing
                    Logger.Log("Done!", UserSettings.LogSettings)
                Else
                    Logger.Log("Failed!", UserSettings.LogSettings)
                End If
            End If


            'report
            '-------------------------------------------------
            If bContinue Then
                Me._loadImagesToUI(Me._sKey)
            Else
                Toolbox.UIUtils.ShowMessageBox(AppMessages.FAILED_TO_REMOVE_ITEM, AppMessages.DIALOG_CAPTION, MessageBoxIcon.Exclamation)
            End If

        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
            service = Nothing
        End Try

    End Sub

    Private Sub _openImageExternally()

        Dim sFilePath As String = ""
        Dim sFolderPath As String = ""
        Dim img As Image = Nothing

        Try
            'sFolderPath = UserSettings.UserAppSettings.JobImagesTempPath & Me._sID
            'Toolbox.FileUtils.CreateDirectory(sFolderPath)
            sFilePath = Me._getImageFilePath(ImageLocationType.REPOSITORY, GUIHelper.GetValueFromComboString(Me.cboImages.Text))
            'img = Toolbox.ImageUtils.CopyToStandaloneImage(Me.pbImage.Image)
            'Toolbox.ImageUtils.SaveImage(img, sFilePath)
            'Me.pbImage.Image.Save(sFilePath)
            'Toolbox.ThreadUtils.Sleep(1)
            Toolbox.WindowsUtils.ExecuteOpenFileCommand(sFilePath)
            'Me._bTempImageOpened = True
        Catch ex As Exception
            'Me._catchException(ex, "Failed writing temporary image to disk at location: " & sFilePath, AppEnums.ErrorAction.LOG_AND_DISPLAY)
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
            'img.Dispose()
            'img = Nothing
        End Try

    End Sub

    Private Sub _loadImagesToUI(ByVal sJobKey As String)

        Dim bImagesFound As Boolean = True

        Try

            'clear
            '-------------------------------------------------
            If Me.cboImages.Items.Count > 0 Then Me.cboImages.Items.Clear()

            'load from db
            '-------------------------------------------------
            For Each img As ImageProps In ServiceHelper.LoadImagesFromDB(sJobKey)
                Me.cboImages.Items.Add(img.FileName & GUIHelper.COMBOBOX_SEPARATOR & img.Key)
            Next

            'update UI
            '-------------------------------------------------
            If Me.cboImages.Items.Count > 0 Then
                Me.cboImages.Text = Me.cboImages.Items(0)
                Me._updateSelectedImage()
                bImagesFound = True
            Else
                bImagesFound = False
            End If

            Me.lblChooseImage.Enabled = bImagesFound
            Me.cboImages.Enabled = bImagesFound
            Me.btnOpenImageExternally.Enabled = bImagesFound
            Me.btnRemoveImage.Enabled = bImagesFound

        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
        End Try

    End Sub

    Private Function _getImageFilePath(ByVal location As ImageLocationType,
                                       ByVal sFileName As String) As String

        Dim sFilePath As String = ""

        Try
            Select Case location
                Case ImageLocationType.REPOSITORY : sFilePath = UserSettings.UserAppSettings.JobImagesRepositoryPath & Me._sID & "\" & sFileName
                Case ImageLocationType.SOURCE : sFilePath = ""
                    'Case ImageLocationType.TEMP : sFilePath = UserSettings.UserAppSettings.JobImagesTempPath & Me._sID & "\" & sFileName
            End Select
        Catch ex As Exception
            Throw ex
        End Try

        Return sFilePath

    End Function

    Private Sub _updateSelectedImage()

        Dim img As Image = Nothing
        Dim sFilePath As String = ""
        Dim sFileName As String = ""


        Try
            sFileName = GUIHelper.GetValueFromComboString(Me.cboImages.Text)
            sFilePath = Me._getImageFilePath(ImageLocationType.REPOSITORY, sFileName)
            img = Toolbox.ImageUtils.LoadImage(sFilePath)
            Me.pbImage.Image = img
            Me.pbImage.Tag = GUIHelper.GetKeyFromComboString(Me.cboImages.Text)
        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
            img = Nothing
        End Try

    End Sub

End Class
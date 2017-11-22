
Imports Mostech.Common
Imports Mostech.Common.Forms
Imports Mostech.Common.Logging
Imports Mostech.Common.Settings
Imports Mostech.StyleFile.Entity
Imports Mostech.StyleFile.Service
Imports Mostech.Common.Entity

Imports System.Text

Public Class frmMain
    Inherits frmStyleFile
    Implements IFormCommon

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me._init()
    End Sub

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Try
            If UserSettings.UserAppSettings.ConfirmAppExit Then
                If Toolbox.UIUtils.ConfirmDialog("Vill du avsluta?", AppMessages.DIALOG_CAPTION) Then
                    Me._quit()
                Else
                    e.Cancel = True
                    Exit Sub
                End If
            Else
                Me._quit()
            End If
        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
        End Try

    End Sub

    Private Sub _init() Implements IFormCommon._init

        Try

            Me.FormState = FormStateEnum.LOADING
            Me._setIcon()
            Toolbox.UIUtils.SetCursor(Cursors.WaitCursor, Me)

            Me._createUserSettingsInstance()

            Logger.EmptyLogOnStartup(UserSettings.LogSettings)
            Logger.Log("===================================================", UserSettings.LogSettings)
            Logger.Log(UserSettings.UserAppSettings.ApplicationName & " is starting...", UserSettings.LogSettings)

            Me._performLogin()
            Me._checkLicenseValidity()
            Me._loadDynamicSearchFieldsToUI()
            Me._initUI()
            Me._setUIColor()
            Me._initTooltips()
            Me._setAppCaption(UserSettings.UserAppSettings.ApplicationName, UserSettings.License.Company)
            Me._loadAlphabetToLastNameCombo()
            Me._loadCustomersToUI(False, "A", UserSettings.UserAppSettings.DisplayActiveOnly)
            If Me.dgvCustomers.SelectedRows.Count > 0 Then
                Me._loadJobsToUI(False, Me.dgvCustomers.SelectedRows(0).Tag)
            End If
            Me.cboLastName.Text = Me.cboLastName.Items(0)

        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
            Me.FormState = FormStateEnum.IDLE
            Toolbox.UIUtils.SetCursor(Cursors.Default, Me)
        End Try

    End Sub

    Private Sub _quit()

        Try
            Application.ExitThread()
            Application.Exit()
        Catch ex As Exception
        Finally
        End Try

    End Sub

    Private Sub _initUI() Implements IFormCommon._initUI

        Try
            Me.chkShowAllCustomers.Checked = False
            Me.txtSearchCriteria.MaxLength = 30

            Me.dgvCustomers.Columns(0).Name = "cu_id"
            Me.dgvCustomers.Columns(1).Name = "cu_lastname"
            Me.dgvCustomers.Columns(2).Name = "cu_firstname"
            Me.dgvCustomers.Columns(3).Name = "cu_category"
            Me.dgvCustomers.Columns(4).Name = "cu_telmobile"
            Me.dgvCustomers.Columns(5).Name = "cu_city"

            Me.dgvJobs.Columns(0).Name = "jb_id"
            Me.dgvJobs.Columns(1).Name = "jb_date"
            Me.dgvJobs.Columns(2).Name = "jb_starttime"
            Me.dgvJobs.Columns(3).Name = "jb_stylist"
            Me.dgvJobs.Columns(4).Name = "jb_category"
            Me.dgvJobs.Columns(5).Name = "jb_description"

            Me.FormBorderStyle = BorderStyle.FixedSingle
            Me.HelpButton = False
            Me.MaximizeBox = False
            Me.MinimizeBox = True
            Me.StartPosition = FormStartPosition.CenterParent
            Me.ShowIcon = True
            Me.ShowInTaskbar = True
            Me.btnCancel.Visible = False

            'Me.btnPrintJob.Visible = False

            Me.cboLastName.Text = "A"
            Toolbox.UIUtils.SetFocus(Me.cboLastName)

        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Sub

    Private Sub _setUIColor() Implements IFormCommon._setUIColor

        Try
            Me.BackColor = Color.FromArgb(Integer.Parse(UserSettings.UserAppSettings.FormBackColor))

            'gbCustomer
            '-------------------------------------------------
            For Each ctrl As Control In Me.gbCustomer.Controls
                If ctrl.GetType = GetType(Button) Then
                    ctrl.BackColor = Color.FromArgb(Integer.Parse(UserSettings.UserAppSettings.ButtonColor))
                End If
            Next

            'gbWork
            '-------------------------------------------------
            For Each ctrl As Control In Me.gbWork.Controls
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

            'buttons
            '-------------------------------------------------
            'Toolbox.UIUtils.SetToolTip(Me.btnEditCustomer, AppMessages.EDIT_CUSTOMER)
            'Toolbox.UIUtils.SetToolTip(Me.btnEditJob, AppMessages.EDIT_JOB)
            'Toolbox.UIUtils.SetToolTip(Me.btnNewCustomer, AppMessages.NEW_CUSTOMER)
            'Toolbox.UIUtils.SetToolTip(Me.btnNewJob, AppMessages.NEW_JOB)
            'Toolbox.UIUtils.SetToolTip(Me.btnPrintJob, AppMessages.PRINT_JOB)
            'Toolbox.UIUtils.SetToolTip(Me.btnRemoveCustomer, AppMessages.REMOVE_CUSTOMER)
            'Toolbox.UIUtils.SetToolTip(Me.btnRemoveJob, AppMessages.REMOVE_JOB)

            Toolbox.UIUtils.SetToolTip(Me.chkShowAllCustomers, AppMessages.SHOW_ALL_CUSTOMERS)
            Toolbox.UIUtils.SetToolTip(Me.cboSearchField, AppMessages.DYNAMIC_SEARCH)

        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Sub

    Private Sub _closeForm(ByVal bConfirm As Boolean) Implements IFormCommon._closeForm

        Try
            If bConfirm Then
                If Toolbox.UIUtils.ConfirmDialog("Vill du avsluta?", AppMessages.DIALOG_CAPTION) Then
                    Me.Close()
                End If
            Else
                Me.Close()
            End If
        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
        End Try

    End Sub

    Private Sub _loadDynamicSearchFieldsToUI()

        Try
            'Me.cboSearchField.Items.Add("efternamn" & GUIHelper.COMBOBOX_SEPARATOR & "cu_lastname")
            'Me.cboSearchField.Items.Add("förnamn" & GUIHelper.COMBOBOX_SEPARATOR & "cu_firstname")
            'Me.cboSearchField.Items.Add("postnr" & GUIHelper.COMBOBOX_SEPARATOR & "cu_postalcode")
            'Me.cboSearchField.Items.Add("ort" & GUIHelper.COMBOBOX_SEPARATOR & "cu_city")
            'Me.cboSearchField.Items.Add("e-post" & GUIHelper.COMBOBOX_SEPARATOR & "cu_email")
            'Me.cboSearchField.Items.Add("allergi" & GUIHelper.COMBOBOX_SEPARATOR & "cu_allergy")
            'Me.cboSearchField.Items.Add("annat" & GUIHelper.COMBOBOX_SEPARATOR & "cu_miscinfo")
            Me.cboSearchField.Items.Add("efternamn")
            Me.cboSearchField.Items.Add("förnamn")
            Me.cboSearchField.Items.Add("address")
            Me.cboSearchField.Items.Add("postnr")
            Me.cboSearchField.Items.Add("ort")
            Me.cboSearchField.Items.Add("stadsdel")
            Me.cboSearchField.Items.Add("e-post")
            Me.cboSearchField.Items.Add("allergi")
            Me.cboSearchField.Items.Add("annat")

            Me.cboSearchField.Text = Me.cboSearchField.Items(0)
        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Sub

    Private Sub _setAppCaption(ByVal sApplicationName As String, _
                               ByVal sLicensedCompanyName As String)

        Try
            'Me.Text = sApplicationName & " - kundregister, historik & rapportering [licensierat för " & sLicensedCompanyName & "]"
            Me.Text = sApplicationName
        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Sub

    Private Sub _checkLicenseValidity()

        Dim dtLicenseEndDate As Date
        Dim sLicenseEndDate As String = ""
        Dim sMsg As String = ""
        Dim iDaysLeft As Integer = 0
        Dim bContinue As Boolean = True

        Try

            'fetch and check license
            '------------------------
            Try
                sLicenseEndDate = UserSettings.License.EndDate
                dtLicenseEndDate = Toolbox.DateAndTimeUtils.GetDate(sLicenseEndDate, Toolbox.DateAndTimeUtils.DateFormat.SHORT)
                iDaysLeft = Toolbox.ConversionUtils.ParseInteger(Toolbox.DateAndTimeUtils.GetTimeDiff(Date.Now.Date, dtLicenseEndDate, Toolbox.DateAndTimeUtils.TimeDiffStyle.D))
            Catch ex As Exception
                bContinue = False
                Logger.Log("An error occured when checking license, end date is '" & sLicenseEndDate & "', error msg: " & ex.Message, UserSettings.LogSettings)
                Toolbox.UIUtils.ShowMessageBox(AppMessages.LICENSE_NO_LONGER_VALID, AppMessages.DIALOG_CAPTION, MessageBoxIcon.Exclamation)
                Me._quit()
            End Try


            If bContinue Then
                Logger.Log("License expires " & dtLicenseEndDate.ToShortDateString & ", days left: " & iDaysLeft, UserSettings.LogSettings)
            End If


            'report
            '------------------------
            If iDaysLeft >= 1 AndAlso iDaysLeft <= 10 Then
                Toolbox.UIUtils.ShowMessageBox(AppMessages.LICENSE_VALIDITY_RUNNING_OUT & iDaysLeft, AppMessages.DIALOG_CAPTION, MessageBoxIcon.Information)
            ElseIf iDaysLeft <= 0 Then
                Toolbox.UIUtils.ShowMessageBox(AppMessages.LICENSE_NO_LONGER_VALID, AppMessages.DIALOG_CAPTION, MessageBoxIcon.Exclamation)
                Me._quit()
            End If

        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Sub

    Private Sub _createUserSettingsInstance()

        Try

            'ladda in DBSettings från config file
            '-------------------------------------------------
            UserSettings.DBAccessSettings = New DBAccess
            UserSettings.DBAccessSettings.DBName = My.Settings.DBName
            UserSettings.DBAccessSettings.DBPassword = Toolbox.EncryptionUtils.SimpleDecrypt(My.Settings.DBPassword)
            UserSettings.DBAccessSettings.DBPort = My.Settings.DBPort
            UserSettings.DBAccessSettings.DBServer = My.Settings.DBServer
            UserSettings.DBAccessSettings.DBUserID = My.Settings.DBUserID
            UserSettings.DBAccessSettings.DBTimeOutSeconds = My.Settings.DBTimeOutSeconds

            Select Case My.Settings.DBVendor.ToUpper
                Case "MSSQL" : UserSettings.DBAccessSettings.DBVendor = Toolbox.DatabaseUtils.DBVendor.MSSQL
                Case "MYSQL" : UserSettings.DBAccessSettings.DBVendor = Toolbox.DatabaseUtils.DBVendor.MYSQL
                Case "POSTGRES" : UserSettings.DBAccessSettings.DBVendor = Toolbox.DatabaseUtils.DBVendor.POSTGRES
            End Select



            'skapa connstring
            '-------------------------------------------------
            AppHelper.UpdateConnectionString()


            'ladda in AppSettings från config file
            '-------------------------------------------------
            UserSettings.UserAppSettings = New AppSettings
            UserSettings.UserAppSettings.Password = Toolbox.EncryptionUtils.SimpleDecrypt(My.Settings.Password)
            UserSettings.UserAppSettings.HelpFile = My.Settings.HelpFile
            UserSettings.UserAppSettings.ConfirmAppExit = My.Settings.ConfirmAppExit
            UserSettings.UserAppSettings.RequiredFieldsColor = My.Settings.RequiredFieldsColor
            UserSettings.UserAppSettings.DisplayActiveOnly = My.Settings.DisplayActiveOnly
            UserSettings.UserAppSettings.ApplicationName = My.Settings.ApplicationName
            UserSettings.UserAppSettings.BackupScriptPath = My.Settings.BackupScriptPath
            UserSettings.UserAppSettings.BackupFolderPath = Toolbox.FileUtils.SecureFolderPath(My.Settings.BackupFolderPath)
            UserSettings.UserAppSettings.JobImagesRepositoryPath = Toolbox.FileUtils.SecureFolderPath(My.Settings.JobImagesRepositoryPath)
            UserSettings.UserAppSettings.JobImagesSourcePath = Toolbox.FileUtils.SecureFolderPath(My.Settings.JobImagesSourcePath)
            UserSettings.UserAppSettings.ReportResultFolder = Toolbox.FileUtils.SecureFolderPath(My.Settings.ReportResultFolder)
            UserSettings.UserAppSettings.MostechWebSiteURL = My.Settings.MostechWebSiteURL
            UserSettings.UserAppSettings.MostechOnFacebookURL = My.Settings.MostechOnFacebookURL
            UserSettings.UserAppSettings.ShowToolTips = My.Settings.ShowToolTips
            UserSettings.UserAppSettings.FormBackColor = My.Settings.FormBackColor
            UserSettings.UserAppSettings.ButtonColor = My.Settings.ButtonColor
            UserSettings.UserAppSettings.TelephoneInitialText = My.Settings.TelephoneInitialText
            UserSettings.UserAppSettings.JobPrintFolderPath = My.Settings.JobPrintFolderPath
            UserSettings.UserAppSettings.FileEncoding = My.Settings.FileEncoding
            UserSettings.UserAppSettings.NrOfJobsPerPrint = My.Settings.NrOfJobsPerPrint


            'ladda in Licens från config file
            '-------------------------------------------------
            UserSettings.License = New License
            UserSettings.License.Company = My.Settings.LicenseCompany
            UserSettings.License.StartDate = My.Settings.LicenseStartDate
            UserSettings.License.EndDate = Toolbox.ConversionUtils.ParseDate(Toolbox.EncryptionUtils.SimpleDecrypt(My.Settings.LicenseEndDate), False)
            UserSettings.License.NrOfLicensedUsers = Toolbox.ConversionUtils.ParseInteger(Toolbox.EncryptionUtils.SimpleDecrypt(My.Settings.LicenseUsers))


            'LogSettings
            '-------------------------------------------------
            UserSettings.LogSettings = New LogSettings
            UserSettings.LogSettings.LogThrowException = My.Settings.LogThrowException
            UserSettings.LogSettings.LogFolderPath = Toolbox.FileUtils.SecureFolderPath(My.Settings.LogFolderPath)
            UserSettings.LogSettings.LogFileName = My.Settings.LogFileName
            UserSettings.LogSettings.LogEmptyOnStartup = My.Settings.LogEmptyOnStartup

            'EmailSettings 
            '-------------------------------------------------
            UserSettings.EmailSettings = New EmailSettings
            UserSettings.EmailSettings.EmailEnableSSL = My.Settings.EmailEnableSSL
            UserSettings.EmailSettings.EmailFromAddress = My.Settings.EmailFromAddress
            UserSettings.EmailSettings.EmailReceiverAddress = My.Settings.EmailReceiverAddress
            UserSettings.EmailSettings.EmailSendTimeoutSeconds = My.Settings.EmailSendTimeoutSeconds
            UserSettings.EmailSettings.EmailServerName = My.Settings.EmailServerName
            UserSettings.EmailSettings.EmailServerPort = My.Settings.EmailServerPort

        Catch ex As Exception
            Throw ex
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

            If Not sPwd.Equals("") Then
                Me._login(sPwd)
            End If
        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
        End Try

    End Sub

    Private Sub _login(ByVal sPassword As String)

        Dim frm As New frmLogin
        Dim bContinue As Boolean = False

        Try
            frm.Text = "StyleFile - logga in"
            bContinue = sPassword.Length >= 3

            If bContinue Then
                frm.Password = sPassword
                AddHandler frm.LoginExecuted, AddressOf frmLogin_LoginExecuted
                frm.ShowDialog()
            End If

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
                Me.Dispose()
                Me.Close()
            End If
        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Sub

    Private Sub _showStylistsForm()

        Dim s As New frmStylists

        Try
            s.ShowDialog()
        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
            s = Nothing
        End Try

    End Sub

    Private Sub _showCategoryForm()

        Dim frm As New frmCategories

        Try
            frm.ShowDialog()
        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
            frm = Nothing
        End Try

    End Sub

    Private Sub _showSettingsForm()

        Dim frm As New frmSettings

        Try
            frm.ShowDialog()
        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
            frm = Nothing
            Me._setUIColor()
        End Try

    End Sub

    Private Sub _showReportForm()

        Dim frm As New frmReport

        Try
            frm.ShowInTaskbar = True
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.Show()
            'frm.ShowDialog()
        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
            frm = Nothing
        End Try

    End Sub

    Private Sub _showLicenseForm()

        Dim frm As New frmLicense

        Try
            frm.ShowDialog()
        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
            frm = Nothing
        End Try

    End Sub

    Private Sub _showPage(ByVal sURI As String)

        Try
            Toolbox.WindowsUtils.ExecuteOpenFileCommand(sURI)
        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
        End Try

    End Sub

    Private Sub _showCustomerForm(ByVal sKey As String)

        Dim f As frmCustomer

        Try
            f = New frmCustomer
            If sKey.Equals("") Then
                f.DBOperation = AppEnums.DBOperationEnum.INSERT
            Else
                f.Key = sKey
                f.DBOperation = AppEnums.DBOperationEnum.UPDATE
            End If

            AddHandler f.CustomerHandled, AddressOf frmCustomer_CustomerHandled
            f.ShowDialog()

        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
            f = Nothing
        End Try

    End Sub

    Private Sub frmCustomer_CustomerHandled(ByVal sender As System.Object,
                                            ByVal ea As CustomerEventArgs)

        Try
            Me._loadCustomersToUI(True, ea.Customer.LastName.Substring(0, 1), UserSettings.UserAppSettings.DisplayActiveOnly)
            If ea.NewCustomer Then Me.dgvJobs.Rows.Clear()
        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
        End Try

    End Sub

    Private Sub _showJobForm(ByVal sKey As String,
                             ByVal sCustomerKey As String,
                             ByVal sCustomerID As String,
                             ByVal sCustomerName As String)

        Dim f As frmJob

        Try
            f = New frmJob
            f.CustomerKey = sCustomerKey
            f.CustomerID = sCustomerID
            f.CustomerName = sCustomerName

            If sKey = "" Then
                f.DBOperation = AppEnums.DBOperationEnum.INSERT
            Else
                f.Key = sKey
                f.DBOperation = AppEnums.DBOperationEnum.UPDATE
            End If

            f.ShowDialog()

        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
            f = Nothing
            Me._loadJobsToUI(True, sCustomerKey)
        End Try

    End Sub

    Private Sub _loadAlphabetToLastNameCombo()

        Try
            Me.cboLastName.Items.AddRange(Toolbox.MiscUtils.GetAlphabet(Toolbox.LanguageUtils.Language.SWEDISH))
            Me.cboLastName.Text = "A"
        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Sub

    Private Sub _loadCustomersToUI(ByVal customers As Collection, _
                                   ByVal bEmptyGrid As Boolean)

        Dim i As Integer = 0
        Dim iNrOfCustomers As Integer = 0

        Try
            If bEmptyGrid Then Me.dgvCustomers.Rows.Clear()
            iNrOfCustomers = customers.Count

            If iNrOfCustomers > 0 Then
                'Logger.Log("Loading " & iNrOfCustomers & " customers to UI...", UserSettings.LogSettings)
                For Each cust As Customer In customers
                    Me.dgvCustomers.Rows.Add()
                    Me.dgvCustomers.Rows(i).Tag = cust.Key
                    Me.dgvCustomers.Rows(i).Cells("cu_id").Value = cust.ID
                    Me.dgvCustomers.Rows(i).Cells("cu_lastname").Value = cust.LastName
                    Me.dgvCustomers.Rows(i).Cells("cu_firstname").Value = cust.FirstName
                    Me.dgvCustomers.Rows(i).Cells("cu_category").Value = ServiceHelper.TranslateKeyToValue("ct_key", cust.Category, "ct_value", AppEnums.EntityEnum.CATEGORY)
                    Me.dgvCustomers.Rows(i).Cells("cu_telmobile").Value = cust.TelephoneMobile
                    Me.dgvCustomers.Rows(i).Cells("cu_city").Value = cust.City
                    i += 1
                Next
                Me._toggleCustomerButtons(True)
                Me.btnNewJob.Enabled = True
            Else
                Me._toggleCustomerButtons(False)
                Me._toggleJobButtons(False)
                Me.btnNewJob.Enabled = False
                Me.dgvJobs.Rows.Clear()
            End If
        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
            customers = Nothing
        End Try

    End Sub

    Private Sub _loadCustomersToUI(ByVal bEmptyGrid As Boolean, _
                                   ByVal sFirstLetterInLastName As String, _
                                   ByVal bActiveOnly As Boolean)

        Try
            Toolbox.UIUtils.SetCursor(Cursors.WaitCursor, Me)
            Me._loadCustomersToUI(ServiceHelper.LoadCustomersFromDB(sFirstLetterInLastName, bActiveOnly), bEmptyGrid)
            Toolbox.UIUtils.SetCursor(Cursors.Default, Me)
        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Sub

    Private Sub _loadJobsToUI(ByVal bEmptyGrid As Boolean, _
                              ByVal sCustomerKey As String)

        Dim coll As Collection = Nothing
        Dim i As Integer = 0
        Dim iNrOfJobs As Integer = 0

        Try
            If bEmptyGrid Then Me.dgvJobs.Rows.Clear()

            coll = ServiceHelper.LoadJobsFromDB(sCustomerKey)
            iNrOfJobs = coll.Count

            If iNrOfJobs > 0 Then
                'Logger.Log("Loading " & iNrOfJobs & " jobs to UI...", UserSettings.LogSettings)
                For Each jb As Job In coll
                    Me.dgvJobs.Rows.Add()
                    Me.dgvJobs.Rows(i).Tag = jb.Key
                    Me.dgvJobs.Rows(i).Cells("jb_id").Value = jb.ID
                    Me.dgvJobs.Rows(i).Cells("jb_date").Value = jb.JobDate
                    Me.dgvJobs.Rows(i).Cells("jb_starttime").Value = jb.StartTime
                    Me.dgvJobs.Rows(i).Cells("jb_stylist").Value = ServiceHelper.TranslateKeyToValue("st_key", jb.Stylist, "st_firstname", AppEnums.EntityEnum.STYLIST)
                    Me.dgvJobs.Rows(i).Cells("jb_category").Value = ServiceHelper.TranslateKeyToValue("ct_key", jb.Category, "ct_value", AppEnums.EntityEnum.CATEGORY)
                    Me.dgvJobs.Rows(i).Cells("jb_description").Value = jb.Description
                    Me.dgvJobs.Rows(i).Cells("jb_description").ToolTipText = jb.Description
                    i += 1
                Next
                Me._toggleJobButtons(True)
            Else
                Me._toggleJobButtons(False)
            End If
            Toolbox.UIUtils.SetStatusBarMsg("Antal arbeten: " & coll.Count, "sblLeft", Me.sbMain)
        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
            coll = Nothing
        End Try

    End Sub

    Private Sub _toggleCustomerButtons(ByVal bEnable As Boolean)
        Me.btnEditCustomer.Enabled = bEnable
        Me.btnRemoveCustomer.Enabled = bEnable
    End Sub

    Private Sub _toggleJobButtons(ByVal bEnable As Boolean)
        Me.btnEditJob.Enabled = bEnable
        Me.btnRemoveJob.Enabled = bEnable
        Me.btnPrintJob.Enabled = bEnable
    End Sub

    Private Sub _removeCustomer()

        Dim sKey As String = ""

        Try
            If Me.dgvCustomers.SelectedRows.Count = 1 Then
                sKey = Me.dgvCustomers.SelectedRows(0).Tag
                Logger.Log("Removing customer " & sKey, UserSettings.LogSettings)
                If Me._customerHasJobs(sKey) Then
                    Toolbox.UIUtils.ShowMessageBox(AppMessages.CUSTOMER_HAS_JOBS, AppMessages.DIALOG_CAPTION, MessageBoxIcon.Exclamation)
                Else
                    If Toolbox.UIUtils.ConfirmDialog(AppMessages.CONFIRM_REMOVAL, AppMessages.DIALOG_CAPTION) = True Then
                        Me._removeCustomer(sKey, Me.cboLastName.Text, True)
                    End If
                End If
            Else
                Toolbox.UIUtils.ShowMessageBox(AppMessages.SELECT_ONE_GRIDROW, AppMessages.DIALOG_CAPTION, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Sub

    Private Sub _removeCustomer(ByVal sKey As String, _
                                ByVal sLastName As String, _
                                ByVal bActiveOnly As Boolean)

        Dim service As CustomerService = Nothing

        Try
            service = New CustomerService()
            If service.Remove(sKey, UserSettings.DBAccessSettings) Then
                Me._loadCustomersToUI(True, sLastName, bActiveOnly)
            Else
                Toolbox.UIUtils.ShowMessageBox(AppMessages.FAILED_TO_REMOVE_ITEM, AppMessages.DIALOG_CAPTION, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
            service = Nothing
        End Try

    End Sub

    Private Sub _removeJob()

        Dim sKey As String = ""
        Dim sCustomerKey As String = ""

        Try
            sKey = Me.dgvJobs.SelectedRows(0).Tag
            sCustomerKey = Me.dgvCustomers.SelectedRows(0).Tag

            If Toolbox.UIUtils.ConfirmDialog(AppMessages.CONFIRM_REMOVAL, AppMessages.DIALOG_CAPTION) = True Then
                Me._removeJobAndImages(sKey, sCustomerKey)
            End If

        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Sub

    Private Sub _removeJobAndImages(ByVal sKey As String,
                                    ByVal sCustomerKey As String)

        Dim jbService As JobService = Nothing
        Dim imgService As ImageService = Nothing
        Dim bContinue As Boolean = False
        Dim sImagesFolderPath As String = ""
        Dim sSQL As String = ""
        Dim iNrOfImages As Integer = 0
        Dim ds As DataSet = Nothing

        Try

            'init
            '------------------------
            jbService = New JobService()
            imgService = New ImageService()
            bContinue = True
            Logger.Log("Removing job and any images...", UserSettings.LogSettings)


            'remove image folder from filesys
            '------------------------
            If bContinue Then
                Try
                    sImagesFolderPath = Toolbox.FileUtils.CombinePath(UserSettings.UserAppSettings.JobImagesRepositoryPath, Me.dgvJobs.SelectedRows(0).Cells(0).Value.ToString)
                    If Toolbox.FileUtils.FolderExists(sImagesFolderPath) Then
                        Logger.Log("Removing image folder " & sImagesFolderPath & "...", UserSettings.LogSettings)
                        Toolbox.FileUtils.DeleteFolder(sImagesFolderPath, True)
                    End If
                Catch ex As Exception
                End Try
            End If

            'remove images from db
            '------------------------
            If bContinue Then
                sSQL = "select count(*) from image where im_parentkey='" & sKey & "'"
                ds = jbService.FetchBySQLAsDataSet(sSQL, UserSettings.DBAccessSettings)
                iNrOfImages = Toolbox.ConversionUtils.ParseInteger(ds.Tables(0).Rows(0).Item(0).ToString)
                If iNrOfImages > 0 Then
                    Logger.Log("Removing " & iNrOfImages & "...", UserSettings.LogSettings)
                    bContinue = imgService.RemoveByParent(sKey, UserSettings.DBAccessSettings)
                End If
            End If

            'remove job
            '------------------------
            If bContinue Then
                Logger.Log("Removing job...", UserSettings.LogSettings)
                bContinue = jbService.Remove(sKey, UserSettings.DBAccessSettings)
            End If

            're-load jobs
            '------------------------
            If bContinue Then
                Me._loadJobsToUI(True, sCustomerKey)
            End If

            'report
            '------------------------
            If bContinue Then
            Else
                Toolbox.UIUtils.ShowMessageBox(AppMessages.FAILED_TO_REMOVE_ITEM, AppMessages.DIALOG_CAPTION, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            Throw ex
        Finally
            ds = Nothing
        End Try

    End Sub

    Private Function _customerHasJobs(ByVal sCustomerKey As String) As Boolean

        Try
            Return ServiceHelper.LoadJobsFromDB(sCustomerKey).Count > 0
        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Function

    Private Sub _toggleCustomerListingMode(ByVal bShowAll As Boolean)

        Try
            If bShowAll Then
                If Toolbox.UIUtils.ConfirmDialog(AppMessages.LIST_ALL_CUSTOMERS, AppMessages.DIALOG_CAPTION) Then
                    Me.cboLastName.Enabled = False
                    Me._loadCustomersToUI(True, "", UserSettings.UserAppSettings.DisplayActiveOnly)
                Else
                    Me.chkShowAllCustomers.Checked = False
                End If
            Else
                Me.cboLastName.Enabled = True
            End If
        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
        End Try

    End Sub

    Private Sub _scrollCustomerList()

        Try
            If Me.dgvCustomers.SelectedRows.Count > 0 Then
                Me._loadJobsToUI(True, Me.dgvCustomers.SelectedRows(0).Tag)
            Else
                'Me.sbMain.Items("sblLeft").Text = "Antal arbeten: 0"
                Toolbox.UIUtils.SetStatusBarMsg("Antal arbeten: 0", "sblLeft", Me.sbMain)
            End If
        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
        End Try

    End Sub

    Private Sub _performDynamicSearch(ByVal sSearchField As String, _
                                      ByVal sSearchCriteria As String, _
                                      ByVal bActiveOnly As Boolean)

        Dim coll As Collection = Nothing

        Try
            'minst ett tecken för att söka
            If sSearchCriteria.Trim.Length = 0 Then Exit Sub

            Select Case sSearchField
                Case "efternamn" : sSearchField = "cu_lastname"
                Case "förnamn" : sSearchField = "cu_firstname"
                Case "address" : sSearchField = "cu_address"
                Case "postnr" : sSearchField = "cu_postalcode"
                Case "ort" : sSearchField = "cu_city"
                Case "stadsdel" : sSearchField = "cu_district"
                Case "e-post" : sSearchField = "cu_email"
                Case "allergi" : sSearchField = "cu_allergy"
                Case "annat" : sSearchField = "cu_miscinfo"
            End Select

            Logger.Log("Performing dynamic search: field=" & sSearchField & ", criteria=" & sSearchCriteria, UserSettings.LogSettings)
            Toolbox.UIUtils.SetCursor(Cursors.WaitCursor, Me)
            coll = ServiceHelper.LoadCustomersFromDBDynamically(sSearchField, sSearchCriteria, bActiveOnly)
            Logger.Log("Customers found: " & coll.Count, UserSettings.LogSettings)
            Me._loadCustomersToUI(coll, True)
            Toolbox.UIUtils.SetCursor(Cursors.Default, Me)

        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
        End Try

    End Sub

    Private Function _getSelectedCustomerNameFromCustomerGrid() As String

        Dim s As String = ""

        Try
            s = Me.dgvCustomers.SelectedRows(0).Cells("cu_lastname").Value.ToString & " " & Me.dgvCustomers.SelectedRows(0).Cells("cu_firstname").Value.ToString
        Catch ex As Exception
        End Try

        Return s

    End Function

    Private Function _getBackupFilePath() As String

        Dim sb As New StringBuilder

        Try
            sb.Append(Toolbox.FileUtils.SecureFolderPath(UserSettings.UserAppSettings.BackupFolderPath))
            sb.Append(Toolbox.DateAndTimeUtils.ConvertDate(Toolbox.DateAndTimeUtils.DateStyle.SWEDISH, Toolbox.DateAndTimeUtils.DateFormat.LONG, Date.Now, "-", "-"))
            sb.Append("_DUMP_OF_DB_")
            sb.Append(UserSettings.DBAccessSettings.DBName)
            sb.Append(".sql")
        Catch ex As Exception
            Throw ex
        End Try

        Return sb.ToString

    End Function

    Private Sub _backup()

        Dim proc As Process = Nothing
        Dim startCmd As ProcessStartInfo = Nothing
        Dim emailAnswer As MsgBoxResult = Nothing
        Dim bContinue As Boolean = False
        Dim bBackupSucceeded As Boolean = False
        Dim bMailSendingSucceeded As Boolean = False
        Dim sBackupFilePath As String = ""
        Dim sEmailSubject As String = ""
        Dim sEmailMessage As String = ""

        Try
            bContinue = True

            'init
            '-------------------------------------------------
            If bContinue Then
                Try
                    sBackupFilePath = Me._getBackupFilePath
                    startCmd = New ProcessStartInfo
                    startCmd.FileName = UserSettings.UserAppSettings.BackupScriptPath
                    startCmd.Arguments = UserSettings.DBAccessSettings.DBName & " " & sBackupFilePath
                Catch ex As Exception
                    bContinue = False
                    AppHelper.CatchException(ex, AppHelper.HandleException.LOG, UserSettings.LogSettings)
                End Try
            End If


            'confirm
            '-------------------------------------------------
            If bContinue Then
                emailAnswer = Toolbox.UIUtils.ConfirmDialog(AppMessages.BACKUP_AND_EMAIL_QUESTION, AppMessages.DIALOG_CAPTION, vbYesNoCancel)
                If emailAnswer = MsgBoxResult.Cancel Then
                    Exit Sub
                Else
                    Toolbox.UIUtils.SetStatusBarMsg("Skickar e-post...", "sblLeft", Me.sbMain)
                End If
            End If


            'backup
            '-------------------------------------------------
            If bContinue Then
                Try
                    Logger.Log("Backing up db...", UserSettings.LogSettings)
                    proc = Process.Start(startCmd)
                    proc.StartInfo.UseShellExecute = False
                    While (proc.HasExited = False)
                        Toolbox.ThreadUtils.Sleep(1)
                    End While
                    Logger.Log("Done.", UserSettings.LogSettings)
                    Toolbox.ThreadUtils.Sleep(1)
                Catch ex As Exception
                    bContinue = False
                    AppHelper.CatchException(ex, AppHelper.HandleException.LOG, UserSettings.LogSettings)
                End Try
            End If


            'verify
            '-------------------------------------------------
            If bContinue Then
                Try
                    Logger.Log("Checking whether backup file was written...", UserSettings.LogSettings)
                    If Toolbox.FileUtils.FileExists(sBackupFilePath) Then
                        bBackupSucceeded = True
                        Logger.Log("Yes, it was.", UserSettings.LogSettings)
                    Else
                        bBackupSucceeded = False
                        Logger.Log("No, it wasn't!", UserSettings.LogSettings)
                    End If
                Catch ex As Exception
                    bContinue = False
                    AppHelper.CatchException(ex, AppHelper.HandleException.LOG, UserSettings.LogSettings)
                Finally
                    bContinue = bBackupSucceeded
                End Try
            End If


            'email
            '-------------------------------------------------
            If bContinue Then
                If emailAnswer = MsgBoxResult.Yes Then
                    Try
                        sEmailSubject = Toolbox.FileUtils.GetFileNameFromPath(sBackupFilePath)
                        sEmailMessage = ""
                        Logger.Log("Sending backup file as e-mail...", UserSettings.LogSettings)
                        bMailSendingSucceeded = Toolbox.EmailUtils.SendMail(UserSettings.EmailSettings.EmailFromAddress, UserSettings.EmailSettings.EmailReceiverAddress,
                                                                            "", "", UserSettings.EmailSettings.EmailFromAddress,
                                                                            UserSettings.EmailSettings.EmailServerName, UserSettings.EmailSettings.EmailServerPort,
                                                                            sEmailSubject, sEmailMessage, UserSettings.EmailSettings.EmailEnableSSL,
                                                                            UserSettings.EmailSettings.EmailSendTimeoutSeconds, sBackupFilePath)
                        If bMailSendingSucceeded Then
                            Logger.Log("Mail sent.", UserSettings.LogSettings)
                        Else
                            Logger.Log("Mail wasn't sent!", UserSettings.LogSettings)
                        End If
                    Catch ex As Exception
                        AppHelper.CatchException(ex, AppHelper.HandleException.LOG, UserSettings.LogSettings)
                    Finally
                    End Try
                End If
            End If


            'report
            '-------------------------------------------------
            If bBackupSucceeded Then
                If emailAnswer = MsgBoxResult.Yes Then
                    If bMailSendingSucceeded Then
                        Toolbox.UIUtils.ShowMessageBox("Backup till filsystem klar, och e-post skickad!", AppMessages.DIALOG_CAPTION, MessageBoxIcon.Information)
                    Else
                        Toolbox.UIUtils.ShowMessageBox("Backup till filsystem klar, men e-post kunde ej skickas!", AppMessages.DIALOG_CAPTION, MessageBoxIcon.Information)
                    End If
                Else
                    Toolbox.UIUtils.ShowMessageBox("Backup till filsystem klar!", AppMessages.DIALOG_CAPTION, MessageBoxIcon.Information)
                End If
            Else
                Toolbox.UIUtils.ShowMessageBox("Backup till filsystem lyckades inte!", AppMessages.DIALOG_CAPTION, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
            Toolbox.UIUtils.SetStatusBarMsg("", "sblLeft", Me.sbMain)
        End Try

    End Sub

    Private Sub _printJobs(ByVal sCustomerID As String)

        Dim bContinue As Boolean = False
        Dim bPrintJobSuccess As Boolean = False
        Dim jb As Job = Nothing
        Dim pj As PrintJob = Nothing
        Dim printJobBatch As Collection = Nothing
        Dim iNrOfSelectedJobs As Integer = 0
        Dim iNrOfBatches As Integer = 0
        Dim sMsg As String = ""

        Try

            'init
            '-------------------------------------------------
            printJobBatch = New Collection
            bContinue = True

            'add 
            '-------------------------------------------------
            If bContinue Then
                For Each row As DataGridViewRow In Me.dgvJobs.Rows
                    Try
                        If row.Cells(6).Value Then
                            iNrOfSelectedJobs += 1
                            jb = ServiceHelper.LoadJobFromDB(row.Tag, AppEnums.EntityLoadTypeEnum.VALUES)
                            pj = New PrintJob
                            pj.ID = iNrOfSelectedJobs
                            pj.Data = AppHelper.FormatJob(jb, AppEnums.JobFormatStyleEnum.TEXT)
                            printJobBatch.Add(pj)
                        End If
                    Catch ex As Exception
                        bContinue = False
                        Logger.Log("Failed adding print job to collection: " & ex.Message, UserSettings.LogSettings)
                    End Try
                Next
            End If

            'no jobs selected?
            '-------------------------------------------------
            If iNrOfSelectedJobs = 0 Then
                Toolbox.UIUtils.ShowMessageBox(AppMessages.NO_JOBS_SELECTED, AppMessages.DIALOG_CAPTION, MessageBoxIcon.Information)
                Exit Sub
            End If

            'NrOfBatches
            '-------------------------------------------------
            iNrOfBatches = iNrOfSelectedJobs / UserSettings.UserAppSettings.NrOfJobsPerPrint
            If iNrOfSelectedJobs Mod UserSettings.UserAppSettings.NrOfJobsPerPrint > 0 Then iNrOfBatches += 1

            'print
            '-------------------------------------------------
            If bContinue Then
                Try
                    Logger.Log("Printing " & iNrOfSelectedJobs & " jobs in " & iNrOfBatches & " batches...", UserSettings.LogSettings)
                    bPrintJobSuccess = PrintHelper.PrintJob(printJobBatch, sCustomerID, UserSettings.UserAppSettings.FileEncoding)
                    If bPrintJobSuccess Then
                        Logger.Log("Print job batch successfully sent to printer.", UserSettings.LogSettings)
                    Else
                        Logger.Log("Print job batch wasn't sent to printer!", UserSettings.LogSettings)
                    End If
                Catch ex As Exception
                    AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
                End Try
            End If

            'report
            '-------------------------------------------------
            If bContinue Then
                Logger.Log(iNrOfSelectedJobs & " job(s) sent to printer in " & iNrOfBatches & " batch(es)!", UserSettings.LogSettings)
                sMsg = iNrOfSelectedJobs & " jobb skickade till skrivaren i " & iNrOfBatches & " utskrifter!" &
                        vbNewLine & "( " & UserSettings.UserAppSettings.NrOfJobsPerPrint & " jobb per sida)"
                Toolbox.UIUtils.ShowMessageBox(sMsg, AppMessages.DIALOG_CAPTION, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        End Try

    End Sub

    Private Sub mnuStylist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuStylist.Click
        Me._showStylistsForm()
    End Sub

    Private Sub btnNewCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewCustomer.Click
        Me._showCustomerForm("")
    End Sub

    Private Sub btnEditCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditCustomer.Click
        Me._showCustomerForm(Me.dgvCustomers.SelectedRows(0).Tag)
    End Sub

    Private Sub btnRemoveCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveCustomer.Click
        Me._removeCustomer()
    End Sub

    Private Sub chkShowAllCustomers_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowAllCustomers.CheckedChanged
        Me._toggleCustomerListingMode(Me.chkShowAllCustomers.Checked)
    End Sub

    Private Sub cboLastName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLastName.SelectedIndexChanged
        If Me.FormState = FormStateEnum.IDLE Then
            Me._loadCustomersToUI(True, Me.cboLastName.Text, UserSettings.UserAppSettings.DisplayActiveOnly)
            Me._scrollCustomerList()
        End If
    End Sub

    Private Sub btnNewJob_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewJob.Click
        Me._showJobForm("",
                        Me.dgvCustomers.SelectedRows(0).Tag,
                        Me.dgvCustomers.SelectedRows(0).Cells("cu_id").Value,
                        Me._getSelectedCustomerNameFromCustomerGrid)
    End Sub

    Private Sub btnEditJob_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditJob.Click
        Me._showJobForm(Me.dgvJobs.SelectedRows(0).Tag,
                        Me.dgvCustomers.SelectedRows(0).Tag,
                        Me.dgvCustomers.SelectedRows(0).Cells("cu_id").Value,
                        Me._getSelectedCustomerNameFromCustomerGrid)
    End Sub

    Private Sub btnRemoveJob_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveJob.Click
        Me._removeJob()
    End Sub

    Private Sub dgvCustomers_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCustomers.RowEnter
        Me._scrollCustomerList()
    End Sub

    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        Me._closeForm(UserSettings.UserAppSettings.ConfirmAppExit)
    End Sub

    Private Sub mnuCategory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCategory.Click
        Me._showCategoryForm()
    End Sub

    Private Sub chkActiveOnly_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me._loadCustomersToUI(True, Me.cboLastName.Text, UserSettings.UserAppSettings.DisplayActiveOnly)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me._closeForm(UserSettings.UserAppSettings.ConfirmAppExit)
    End Sub

    Private Sub mnuLicense_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLicense.Click
        Me._showLicenseForm()
    End Sub

    Private Sub mnuShowHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuShowHelp.Click
        Me._showPage(UserSettings.UserAppSettings.HelpFile)
    End Sub

    Private Sub txtLastNameSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchCriteria.TextChanged
        Me._performDynamicSearch(Me.cboSearchField.Text,
                                 Me.txtSearchCriteria.Text.Trim,
                                 UserSettings.UserAppSettings.DisplayActiveOnly)
    End Sub

    Private Sub dgvCustomers_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvCustomers.DoubleClick
        Me._showCustomerForm(Me.dgvCustomers.SelectedRows(0).Tag)
    End Sub

    Private Sub dgvJobs_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvJobs.DoubleClick
        Me._showJobForm(Me.dgvJobs.SelectedRows(0).Tag.ToString,
                        Me.dgvCustomers.SelectedRows(0).Tag.ToString,
                        Me.dgvCustomers.SelectedRows(0).Cells("cu_id").Value.ToString,
                        Me._getSelectedCustomerNameFromCustomerGrid)
    End Sub

    Private Sub mnuSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSettings.Click
        Me._showSettingsForm()
    End Sub

    Private Sub mnuReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReport.Click
        Me._showReportForm()
    End Sub

    Private Sub cboSearchField_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSearchField.SelectedIndexChanged
        Me._performDynamicSearch(Me.cboSearchField.Text, _
                                 Me.txtSearchCriteria.Text.Trim, _
                                 UserSettings.UserAppSettings.DisplayActiveOnly)
    End Sub

    Private Sub mnuBackup_Click(sender As System.Object, e As System.EventArgs) Handles mnuBackup.Click
        Me._backup()
    End Sub

    Private Sub mnuMostechWebSiteURL_Click(sender As System.Object, e As System.EventArgs) Handles mnuMostechWebSiteURL.Click
        Me._showPage(UserSettings.UserAppSettings.MostechWebSiteURL)
    End Sub

    Private Sub mnuMostechOnFacebook_Click(sender As System.Object, e As System.EventArgs) Handles mnuMostechOnFacebook.Click
        Toolbox.UIUtils.ShowMessageBox(AppMessages.NOT_YET_READY, AppMessages.DIALOG_CAPTION, MessageBoxIcon.Exclamation)
        'Me._showPage(UserSettings.UserAppSettings.MostechOnFacebookURL)
    End Sub

    Private Sub btnPrintJob_Click(sender As System.Object, e As System.EventArgs) Handles btnPrintJob.Click
        Me._printJobs(Me.dgvCustomers.SelectedRows(0).Cells("cu_id").Value)
    End Sub

End Class

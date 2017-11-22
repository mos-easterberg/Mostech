
Imports Mostech.Common
Imports Mostech.Common.Forms
Imports Mostech.StyleFile.Entity
Imports Mostech.StyleFile.Service

Imports System.Text

Public Class frmCustomer
    Inherits frmStyleFile
    Implements IFormSaveable, IFormCommon

    Private _sKey As String
    Private _dbOp As AppEnums.DBOperationEnum

    Public Event CustomerHandled(ByVal sender As Object, ByVal ea As CustomerEventArgs)

    Public WriteOnly Property Key As String
        Set(ByVal value As String)
            Me._sKey = value
        End Set
    End Property

    Public WriteOnly Property DBOperation As AppEnums.DBOperationEnum
        Set(ByVal value As AppEnums.DBOperationEnum)
            Me._dbOp = value
        End Set
    End Property

    Private Sub frmCustomer_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    End Sub

    Private Sub frmCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me._closeForm(False)
    End Sub

    Private Sub _init() Implements IFormCommon._init

        Try
            Me._setIcon()
            Me._initUI()
            Me._setUIColor()
            Me._initTooltips()
            Me._loadCustomerCategoriesToUI()
            Me._loadDistrictCategoriesToUI()
            Me._loadDOBToUI()
            If Me._dbOp = AppEnums.DBOperationEnum.UPDATE Then
                Me._loadCustomerToUI(Me._sKey)
            End If
            Me._setSaveState(False)
            Me._isDirty(False)
            Toolbox.UIUtils.SetCaption(Me, "Kund")
        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
        End Try

    End Sub

    Private Sub _initUI() Implements IFormCommon._initUI

        Try
            Me.txtID.MaxLength = 5
            Me.cboCategory.Sorted = True
            Me.cboCategory.DropDownStyle = ComboBoxStyle.DropDownList
            Me.txtLastName.MaxLength = 30
            Me.txtFirstName.MaxLength = 30
            Me.txtAddress.MaxLength = 100
            Me.txtPostalCode.MaxLength = 5
            Me.txtCity.MaxLength = 50
            Me.txtTelephoneMobile.MaxLength = 20
            Me.txtTelephoneHome.MaxLength = 20
            Me.txtTelephoneWork.MaxLength = 20
            Me.txtEmailAddress.MaxLength = 100
            Me.txtMiscInfo.MaxLength = 1000
            Me.txtAllergy.MaxLength = 1000
            Me.chkSMS.Checked = False
            Me.chkEmail.Checked = False
            Me.chkMail.Checked = False
            Me.chkActive.Checked = True

            Me.CancelButton = Me.btnCancel
            Toolbox.UIUtils.SetCommonFormSettings(Me)

            Me.txtTelephoneHome.Text = UserSettings.UserAppSettings.TelephoneInitialText
            Me.txtTelephoneMobile.Text = UserSettings.UserAppSettings.TelephoneInitialText
            Me.txtTelephoneWork.Text = UserSettings.UserAppSettings.TelephoneInitialText

            AppHelper.SetReqFieldsColor(Me.txtFirstName)
            AppHelper.SetReqFieldsColor(Me.txtLastName)

            Toolbox.UIUtils.SetFocus(Me.txtLastName)
            'Me.Icon = MyBase.Icon

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

            Toolbox.UIUtils.SetToolTip(Me.chkActive, AppMessages.IF_CHECKED_SHOW_IN_LIST)
        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Sub

    Private Sub _loadDOBToUI()

        Try

            'day
            '------------------------
            Me.cboDOBDay.Items.Add("")
            For i As Integer = 1 To 31
                Me.cboDOBDay.Items.Add(Toolbox.StringUtils.Pad(i.ToString, "0", 2, Toolbox.StringUtils.PadDirection.LEFT))
            Next

            'month
            '------------------------
            Me.cboDOBMonth.Items.Add("")
            For i As Integer = 1 To 12
                Me.cboDOBMonth.Items.Add(Toolbox.StringUtils.Pad(i.ToString, "0", 2, Toolbox.StringUtils.PadDirection.LEFT))
            Next

            'year
            '------------------------
            Me.cboDOBYear.Items.Add("")
            For i As Integer = 1900 To Date.Now.Year
                Me.cboDOBYear.Items.Add(i)
            Next

            Me.cboDOBDay.Text = ""
            Me.cboDOBMonth.Text = ""
            Me.cboDOBYear.Text = ""

        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        End Try

    End Sub

    Private Sub _loadCustomerCategoriesToUI()

        Dim s As String = ""

        Try
            For Each ct As Category In ServiceHelper.GetCategories(AppEnums.CategoryTypeEnum.CUSTOMER, True)
                Me.cboCategory.Items.Add(ct.Value & GUIHelper.COMBOBOX_SEPARATOR & ct.Key)
                If ct.Default Then
                    s = ct.Value & GUIHelper.COMBOBOX_SEPARATOR & ct.Key
                End If
            Next
            Me.cboCategory.Text = s
        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Sub

    Private Sub _loadDistrictCategoriesToUI()

        Dim s As String = ""

        Try
            For Each ct As Category In ServiceHelper.GetCategories(AppEnums.CategoryTypeEnum.DISTRICT, True)
                Me.cboDistrict.Items.Add(ct.Value & GUIHelper.COMBOBOX_SEPARATOR & ct.Key)
                If ct.Default Then
                    s = ct.Value & GUIHelper.COMBOBOX_SEPARATOR & ct.Key
                End If
            Next
            Me.cboDistrict.Text = s
        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Sub

    Private Sub _save() Implements IFormSaveable._save

        Dim cust As Customer
        Dim ea As New CustomerEventArgs

        Try

            'is required fields filled 
            '------------------------
            If Not Me._isRequiredFieldsFilled Then
                Toolbox.UIUtils.ShowMessageBox(AppMessages.REQUIRED_FIELDS_MISSING, AppMessages.DIALOG_CAPTION, MessageBoxIcon.Exclamation)
                Me._setSaveState(False)
                Me._isDirty(False)
                Exit Sub
            End If


            'instantiate
            '------------------------
            cust = Me._instantiateFromUI


            'is input validated
            '------------------------
            If Not Me._isInputValidated(cust) Then
                Toolbox.UIUtils.ShowMessageBox(AppMessages.INPUT_VALIDATION_FAILED, AppMessages.DIALOG_CAPTION, MessageBoxIcon.Exclamation)
                Me._setSaveState(False)
                Me._isDirty(False)
                Exit Sub
            End If


            'save
            '------------------------
            ea.Customer = cust
            If Me._dbOp = AppEnums.DBOperationEnum.INSERT Then
                ea.NewCustomer = True
            Else
                ea.NewCustomer = False
            End If

            If Me._saveCustomer(cust) Then
                Toolbox.UIUtils.CloseForm(Me, False, AppMessages.CONFIRM_CLOSE_WINDOW, AppMessages.DIALOG_CAPTION)
                RaiseEvent CustomerHandled(Me, ea)
            Else
                Toolbox.UIUtils.ShowMessageBox(AppMessages.FAILED_TO_SAVE_ITEM, AppMessages.DIALOG_CAPTION, MessageBoxIcon.Exclamation)
            End If

        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
        End Try

    End Sub

    Private Function _saveCustomer(ByVal cust As Customer) As Boolean

        Dim b As Boolean = False
        Dim service As CustomerService

        Try
            service = New CustomerService()
            If Me._dbOp = AppEnums.DBOperationEnum.INSERT Then
                cust.Key = AppHelper.GetEntityKey
                b = service.Add(cust, UserSettings.DBAccessSettings)
            Else
                cust.Key = Me._sKey
                b = service.Update(cust, UserSettings.DBAccessSettings)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            service = Nothing
        End Try

        Return b

    End Function

    Private Function _instantiateFromUI() As Customer

        Dim cust As New Customer

        Try
            cust.Category = GUIHelper.GetKeyFromComboString(Me.cboCategory.Text.Trim)
            cust.LastName = Me.txtLastName.Text.Trim
            cust.FirstName = Me.txtFirstName.Text.Trim
            cust.Address = Me.txtAddress.Text.Trim
            cust.District = GUIHelper.GetKeyFromComboString(Me.cboDistrict.Text.Trim)
            cust.DateOfBirth = Toolbox.PeopleIDUtils.GetDateOfBirthString(Me.cboDOBDay.Text, Me.cboDOBMonth.Text, Me.cboDOBYear.Text)
            If Me.txtPostalCode.Text.Trim <> "" Then
                cust.PostalCode = Toolbox.ConversionUtils.ParseInteger(Me.txtPostalCode.Text.Trim)
            End If
            cust.City = Me.txtCity.Text.Trim
            cust.TelephoneMobile = Me.txtTelephoneMobile.Text.Trim
            cust.TelephoneHome = Me.txtTelephoneHome.Text.Trim
            cust.TelephoneWork = Me.txtTelephoneWork.Text.Trim
            cust.EmailAddress = Me.txtEmailAddress.Text.Trim
            cust.AllowSMS = Me.chkSMS.Checked
            cust.AllowEmail = Me.chkEmail.Checked
            cust.AllowMail = Me.chkMail.Checked
            cust.Allergy = Me.txtAllergy.Text.Trim
            cust.MiscInfo = Me.txtMiscInfo.Text.Trim
            cust.Created = Toolbox.DateAndTimeUtils.ConvertDate(Toolbox.DateAndTimeUtils.DateStyle.SWEDISH, Date.Now)
            cust.CreatedBy = AppHelper.GetUserName
            cust.Updated = Toolbox.DateAndTimeUtils.ConvertDate(Toolbox.DateAndTimeUtils.DateStyle.SWEDISH, Date.Now)
            cust.UpdatedBy = AppHelper.GetUserName
            cust.Active = Me.chkActive.Checked
        Catch ex As Exception
            Throw ex
        Finally
        End Try

        Return cust

    End Function

    Private Sub _setSaveState(ByVal bIsSaveable As Boolean) Implements IFormSaveable._setSaveState
        Me.btnSave.Enabled = bIsSaveable
    End Sub

    Private Sub _isDirty(ByVal b As Boolean) Implements IFormSaveable._isDirty

        Me.IsDirty = b

        If b Then
            Toolbox.UIUtils.SetCaption(Me, "Kund (ej sparad)")
        Else
            Toolbox.UIUtils.SetCaption(Me, "Kund")
        End If

    End Sub

    Private Function _isRequiredFieldsFilled() As Boolean Implements IFormSaveable._isRequiredFieldsFilled

        Dim b As Boolean = True

        Try
            b = (Me.txtFirstName.Text.Length > 0)
            b = (Me.txtLastName.Text.Length > 0)
        Catch ex As Exception
            Throw ex
        Finally
        End Try

        Return b

    End Function

    Private Function _isInputValidated(ByVal entity As Entity.Entity) As Boolean Implements IFormSaveable._isInputValidated

        Dim b As Boolean = False
        Dim cust As Customer = Nothing
        Dim sSQLDelimiterChar As String = ""

        Try
            b = True
            cust = DirectCast(entity, Customer)
            sSQLDelimiterChar = "'"

            If cust.Address.Contains(sSQLDelimiterChar) Then Return False
            If cust.District.Contains(sSQLDelimiterChar) Then Return False
            If cust.Allergy.Contains(sSQLDelimiterChar) Then Return False
            If cust.City.Contains(sSQLDelimiterChar) Then Return False
            If cust.EmailAddress.Contains(sSQLDelimiterChar) Then Return False
            If cust.FirstName.Contains(sSQLDelimiterChar) Then Return False
            If cust.LastName.Contains(sSQLDelimiterChar) Then Return False
            If cust.MiscInfo.Contains(sSQLDelimiterChar) Then Return False
            If cust.TelephoneHome.Contains(sSQLDelimiterChar) Then Return False
            If cust.TelephoneMobile.Contains(sSQLDelimiterChar) Then Return False
            If cust.TelephoneWork.Contains(sSQLDelimiterChar) Then Return False

        Catch ex As Exception
            b = False
            Throw ex
        End Try

        Return b

    End Function

    Private Sub _loadCustomerToUI(ByVal sKey As String)

        Dim cust As Customer = Nothing

        Try
            cust = Me._loadCustomerFromDB(sKey)

            Me.txtID.Text = cust.ID
            Me.txtCreated.Text = cust.Created
            Me.txtEdited.Text = cust.Updated
            Me.cboCategory.Text = GUIHelper.GetLookupValue(cust.Category, Me.cboCategory.Items)
            Me.txtLastName.Text = cust.LastName
            Me.txtFirstName.Text = cust.FirstName
            Me.cboDOBDay.Text = Toolbox.PeopleIDUtils.GetDateOfBirthPart(cust.DateOfBirth, Toolbox.PeopleIDUtils.DateOfBirthPart.DAY)
            Me.cboDOBMonth.Text = Toolbox.PeopleIDUtils.GetDateOfBirthPart(cust.DateOfBirth, Toolbox.PeopleIDUtils.DateOfBirthPart.MONTH)
            Me.cboDOBYear.Text = Toolbox.PeopleIDUtils.GetDateOfBirthPart(cust.DateOfBirth, Toolbox.PeopleIDUtils.DateOfBirthPart.YEAR)
            Me.txtAddress.Text = cust.Address
            Me.cboDistrict.Text = GUIHelper.GetLookupValue(cust.District, Me.cboDistrict.Items)
            If cust.PostalCode > 0 Then Me.txtPostalCode.Text = cust.PostalCode.ToString
            Me.txtCity.Text = cust.City
            Me.txtTelephoneMobile.Text = cust.TelephoneMobile
            Me.txtTelephoneHome.Text = cust.TelephoneHome
            Me.txtTelephoneWork.Text = cust.TelephoneWork
            Me.txtEmailAddress.Text = cust.EmailAddress
            Me.chkSMS.Checked = cust.AllowSMS
            Me.chkEmail.Checked = cust.AllowEmail
            Me.chkMail.Checked = cust.AllowMail
            Me.txtAllergy.Text = cust.Allergy
            Me.txtMiscInfo.Text = cust.MiscInfo
            Me.chkActive.Checked = cust.Active
        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Sub

    Private Function _loadCustomerFromDB(ByVal sKey As String) As Customer

        Dim coll As Collection
        Dim cust As Customer
        Dim service As CustomerService
        Dim sb As New StringBuilder

        Try
            service = New CustomerService()
            sb.Append("select * from ")
            sb.Append(UserSettings.DBAccessSettings.DBName)
            sb.Append(".customer where cu_key='")
            sb.Append(sKey)
            sb.Append("'")
            coll = service.FetchBySQL(sb.ToString, UserSettings.DBAccessSettings)
            cust = DirectCast(coll.Item(1), Customer)
        Catch ex As Exception
            Throw ex
        Finally
            coll = Nothing
            service = Nothing
        End Try

        Return cust

    End Function

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Me._save()
    End Sub

    Private Sub txtEmailAddress_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEmailAddress.LostFocus
        GUIHelper.ValidateEmailAddress(Me.txtEmailAddress, True)
    End Sub

    Private Sub cboCategory_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCategory.TextChanged
        Me._setSaveState(True)
        Me._isDirty(True)
    End Sub

    Private Sub txtFirstName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFirstName.TextChanged
        Me._setSaveState(True)
        Me._isDirty(True)
    End Sub

    Private Sub txtLastName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLastName.TextChanged
        Me._setSaveState(True)
        Me._isDirty(True)
    End Sub

    Private Sub txtAddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAddress.TextChanged
        Me._setSaveState(True)
        Me._isDirty(True)
    End Sub

    Private Sub cboDOBDay_TextChanged(sender As Object, e As System.EventArgs) Handles cboDOBDay.TextChanged
        Me._setSaveState(True)
        Me._isDirty(True)
    End Sub

    Private Sub cboDOBMonth_TextChanged(sender As Object, e As System.EventArgs) Handles cboDOBMonth.TextChanged
        Me._setSaveState(True)
        Me._isDirty(True)
    End Sub

    Private Sub cboDOBYear_TextChanged(sender As Object, e As System.EventArgs) Handles cboDOBYear.TextChanged
        Me._setSaveState(True)
        Me._isDirty(True)
    End Sub

    Private Sub txtPostalCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPostalCode.TextChanged
        If Toolbox.ValidationUtils.IsValidPostalCode(Me.txtPostalCode.Text.Trim) Then
            Me._setSaveState(True)
            Me._isDirty(True)
        Else
            Toolbox.UIUtils.ShowMessageBox(AppMessages.INVALID_POSTALCODE, AppMessages.DIALOG_CAPTION, MessageBoxIcon.Exclamation)
            Me.txtPostalCode.Text = ""
            Me._setSaveState(False)
            Me._isDirty(False)
        End If
    End Sub

    Private Sub txtCity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCity.TextChanged
        Me._setSaveState(True)
        Me._isDirty(True)
    End Sub

    Private Sub txtDistrict_TextChanged(sender As System.Object, e As System.EventArgs)
        Me._setSaveState(True)
        Me._isDirty(True)
    End Sub

    Private Sub txtTelephoneMobile_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTelephoneMobile.TextChanged
        Me._setSaveState(True)
        Me._isDirty(True)
    End Sub

    Private Sub txtTelephoneHome_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTelephoneHome.TextChanged
        Me._setSaveState(True)
        Me._isDirty(True)
    End Sub

    Private Sub txtTelephoneWork_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTelephoneWork.TextChanged
        Me._setSaveState(True)
        Me._isDirty(True)
    End Sub

    Private Sub txtEmailAddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmailAddress.TextChanged
        Me._setSaveState(True)
        Me._isDirty(True)
    End Sub

    Private Sub txtMiscInfo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMiscInfo.TextChanged
        Me._setSaveState(True)
        Me._isDirty(True)
        GUIHelper.SetRemainingCharacterCountInLabel(Me.txtMiscInfo, Me.gbMiscInfo, "Annat")
    End Sub

    Private Sub txtAllergy_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAllergy.TextChanged
        Me._setSaveState(True)
        Me._isDirty(True)
        GUIHelper.SetRemainingCharacterCountInLabel(Me.txtAllergy, Me.gbAllergy, "Allergier")
    End Sub

    Private Sub chkSMS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSMS.CheckedChanged
        Me._setSaveState(True)
        Me._isDirty(True)
    End Sub

    Private Sub chkEmail_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEmail.CheckedChanged
        Me._setSaveState(True)
        Me._isDirty(True)
    End Sub

    Private Sub chkMail_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMail.CheckedChanged
        Me._setSaveState(True)
        Me._isDirty(True)
    End Sub

    Private Sub chkActive_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkActive.CheckedChanged
        Me._setSaveState(True)
        Me._isDirty(True)
    End Sub

    Private Sub cboDistrict_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboDistrict.SelectedIndexChanged
        Me._setSaveState(True)
        Me._isDirty(True)
    End Sub

End Class
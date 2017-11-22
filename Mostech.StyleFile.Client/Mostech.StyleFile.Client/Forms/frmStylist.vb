
Imports Mostech.Common
Imports Mostech.Common.Forms

Imports Mostech.StyleFile.Entity
Imports Mostech.StyleFile.Service

Imports System.Text

Public Class frmStylist
    Inherits frmStyleFile
    Implements IFormSaveable, IFormCommon

    Private _sKey As String
    Private _dbOp As AppEnums.DBOperationEnum

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

    Private Sub frmStylist_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            Me._setIcon()
            Me._initUI()
            Me._setUIColor()
            Me._initTooltips()
            Me._loadEmploymentTypesToUI()
            Me._loadProfessionCategoriesToUI()
            If Me._dbOp = AppEnums.DBOperationEnum.UPDATE Then
                Me._loadStylistToUI(Me._sKey)
            End If
            Me._setSaveState(False)
            Me._isDirty(False)
            Toolbox.UIUtils.SetCaption(Me, "Stylist")
        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
        End Try

    End Sub

    Private Sub _initUI() Implements IFormCommon._initUI

        Try
            Me.txtID.MaxLength = 7
            Me.txtID.ReadOnly = True
            Me.txtLastName.MaxLength = 30
            Me.txtFirstName.MaxLength = 30
            Me.txtAddress.MaxLength = 100
            Me.txtPostalCode.MaxLength = 5
            Me.txtCity.MaxLength = 50
            Me.txtTelephoneMobile.MaxLength = 20
            Me.txtTelephoneHome.MaxLength = 20
            Me.txtTelephoneWork.MaxLength = 20
            Me.txtEmailAddress.MaxLength = 100
            Me.txtAllergy.MaxLength = 1000
            Me.txtMiscInfo.MaxLength = 1000
            Me.chkActive.Checked = True

            Me.txtFirstName.BackColor = Color.Yellow
            Me.txtLastName.BackColor = Color.Yellow

            Me.CancelButton = Me.btnCancel

            Me.txtTelephoneHome.Text = UserSettings.UserAppSettings.TelephoneInitialText
            Me.txtTelephoneMobile.Text = UserSettings.UserAppSettings.TelephoneInitialText
            Me.txtTelephoneWork.Text = UserSettings.UserAppSettings.TelephoneInitialText

            Toolbox.UIUtils.SetCommonFormSettings(Me)

            AppHelper.SetReqFieldsColor(Me.txtFirstName)
            AppHelper.SetReqFieldsColor(Me.txtLastName)

            Toolbox.UIUtils.SetFocus(Me.txtLastName)

        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Sub

    Private Sub _setIcon() Implements IFormCommon._setIcon
        Me.Icon = My.Resources.icon_StyleFile
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

    Private Sub _initTooltips() Implements IFormCommon._initTooltips

        Try
            If Not UserSettings.UserAppSettings.ShowToolTips Then Exit Sub

            Toolbox.UIUtils.SetToolTip(Me.chkActive, AppMessages.IF_CHECKED_SHOW_IN_LIST)
        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Sub

    Private Sub _loadEmploymentTypesToUI()

        Dim s As String = ""

        Try
            For Each ct As Category In ServiceHelper.GetCategories(AppEnums.CategoryTypeEnum.EMPLOYMENT, True)
                Me.cboEmploymentType.Items.Add(ct.Value & GUIHelper.COMBOBOX_SEPARATOR & ct.Key)
                If ct.Default Then
                    s = ct.Value & GUIHelper.COMBOBOX_SEPARATOR & ct.Key
                End If
            Next
            Me.cboEmploymentType.Text = s
        Catch ex As Exception
            Throw
        Finally
        End Try

    End Sub

    Private Sub _loadProfessionCategoriesToUI()

        Dim s As String = ""

        Try
            For Each ct As Category In ServiceHelper.GetCategories(AppEnums.CategoryTypeEnum.PROFESSION, True)
                Me.cboProfession.Items.Add(ct.Value & GUIHelper.COMBOBOX_SEPARATOR & ct.Key)
                If ct.Default Then
                    s = ct.Value & GUIHelper.COMBOBOX_SEPARATOR & ct.Key
                End If
            Next
            Me.cboProfession.Text = s
        Catch ex As Exception
            Throw
        Finally
        End Try

    End Sub

    Private Sub _loadStylistToUI(ByVal sKey As String)

        Dim s As Stylist

        Try
            s = ServiceHelper.LoadStylistFromDB(sKey)

            Me.txtID.Text = s.ID
            Me.txtCreated.Text = s.Created
            Me.txtEdited.Text = s.Updated
            Me.cboEmploymentType.Text = GUIHelper.GetLookupValue(s.Employment, Me.cboEmploymentType.Items)
            Me.cboProfession.Text = GUIHelper.GetLookupValue(s.Profession, Me.cboProfession.Items)
            Me.txtLastName.Text = s.LastName
            Me.txtFirstName.Text = s.FirstName
            Me.txtAddress.Text = s.Address
            If s.PostalCode > 0 Then Me.txtPostalCode.Text = s.PostalCode.ToString
            Me.txtCity.Text = s.City
            Me.txtTelephoneMobile.Text = s.TelephoneMobile
            Me.txtTelephoneHome.Text = s.TelephoneHome
            Me.txtTelephoneWork.Text = s.TelephoneWork
            Me.txtEmailAddress.Text = s.EmailAddress
            Me.txtAllergy.Text = s.Allergy
            Me.txtMiscInfo.Text = s.MiscInfo
            Me.chkActive.Checked = s.Active

        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Me._save()
    End Sub

    Private Sub _save() Implements IFormSaveable._save

        Dim st As Stylist = Nothing

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
            st = Me._instantiateFromUI


            'is input validated
            '------------------------
            If Not Me._isInputValidated(st) Then
                Toolbox.UIUtils.ShowMessageBox(AppMessages.INPUT_VALIDATION_FAILED, AppMessages.DIALOG_CAPTION, MessageBoxIcon.Exclamation)
                Me._setSaveState(False)
                Me._isDirty(False)
                Exit Sub
            End If


            'save
            '------------------------
            If Me._saveStylist(st) Then
                Toolbox.UIUtils.CloseForm(Me, False, AppMessages.CONFIRM_CLOSE_WINDOW, AppMessages.DIALOG_CAPTION)
            Else
                Toolbox.UIUtils.ShowMessageBox(AppMessages.FAILED_TO_SAVE_ITEM, AppMessages.DIALOG_CAPTION, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
        End Try

    End Sub

    Private Function _saveStylist(ByVal s As Stylist) As Boolean

        Dim b As Boolean = False
        Dim service As StylistService

        Try
            service = New StylistService()
            If Me._dbOp = AppEnums.DBOperationEnum.INSERT Then
                s.Key = AppHelper.GetEntityKey
                b = service.Add(s, UserSettings.DBAccessSettings)
            Else
                s.Key = Me._sKey
                b = service.Update(s, UserSettings.DBAccessSettings)
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

    Private Function _instantiateFromUI() As Stylist

        Dim stylist As New Stylist

        Try
            stylist.Employment = GUIHelper.GetKeyFromComboString(Me.cboEmploymentType.Text.Trim)
            stylist.Profession = GUIHelper.GetKeyFromComboString(Me.cboProfession.Text.Trim)
            stylist.LastName = Me.txtLastName.Text.Trim
            stylist.FirstName = Me.txtFirstName.Text.Trim
            stylist.Address = Me.txtAddress.Text.Trim
            If Not Me.txtPostalCode.Text.Trim.Equals("") Then stylist.PostalCode = Toolbox.ConversionUtils.ParseInteger(Me.txtPostalCode.Text.Trim)
            stylist.City = Me.txtCity.Text.Trim
            stylist.TelephoneMobile = Me.txtTelephoneMobile.Text.Trim
            stylist.TelephoneHome = Me.txtTelephoneHome.Text.Trim
            stylist.TelephoneWork = Me.txtTelephoneWork.Text.Trim
            stylist.EmailAddress = Me.txtEmailAddress.Text.Trim
            stylist.Allergy = Me.txtAllergy.Text.Trim
            stylist.MiscInfo = Me.txtMiscInfo.Text.Trim
            stylist.Created = Toolbox.DateAndTimeUtils.ConvertDate(Toolbox.DateAndTimeUtils.DateStyle.SWEDISH, Date.Now)
            stylist.CreatedBy = AppHelper.GetUserName
            stylist.Updated = Toolbox.DateAndTimeUtils.ConvertDate(Toolbox.DateAndTimeUtils.DateStyle.SWEDISH, Date.Now)
            stylist.UpdatedBy = AppHelper.GetUserName
            stylist.Active = Me.chkActive.Checked
        Catch ex As Exception
            Throw ex
        Finally
        End Try

        Return stylist

    End Function

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
        Dim st As Stylist = Nothing
        Dim sSQLDelimiterChar As String = ""

        Try
            b = True
            st = DirectCast(entity, Stylist)
            sSQLDelimiterChar = "'"

            If st.Address.Contains(sSQLDelimiterChar) Then Return False
            If st.Allergy.Contains(sSQLDelimiterChar) Then Return False
            If st.City.Contains(sSQLDelimiterChar) Then Return False
            If st.EmailAddress.Contains(sSQLDelimiterChar) Then Return False
            If st.FirstName.Contains(sSQLDelimiterChar) Then Return False
            If st.LastName.Contains(sSQLDelimiterChar) Then Return False
            If st.MiscInfo.Contains(sSQLDelimiterChar) Then Return False
            If st.TelephoneHome.Contains(sSQLDelimiterChar) Then Return False
            If st.TelephoneMobile.Contains(sSQLDelimiterChar) Then Return False
            If st.TelephoneWork.Contains(sSQLDelimiterChar) Then Return False

        Catch ex As Exception
            b = False
            Throw ex
        End Try

        Return b

    End Function

    Private Sub _setSaveState(ByVal bIsSaveable As Boolean) Implements IFormSaveable._setSaveState
        Me.btnSave.Enabled = bIsSaveable
    End Sub

    Private Sub _isDirty(ByVal b As Boolean) Implements IFormSaveable._isDirty

        Me.IsDirty = b
        If b Then
            Toolbox.UIUtils.SetCaption(Me, "Stylist (ej sparad)")
        Else
            Toolbox.UIUtils.SetCaption(Me, "Stylist")
        End If

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me._closeForm(False)
    End Sub

    Private Sub txtEmailAddress_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEmailAddress.LostFocus
        GUIHelper.ValidateEmailAddress(Me.txtEmailAddress, True)
    End Sub

    Private Sub cboEmploymentType_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboEmploymentType.SelectedIndexChanged
        Me._setSaveState(True)
        Me._isDirty(True)
    End Sub

    Private Sub cboProfession_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProfession.SelectedIndexChanged
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

    Private Sub txtPostalCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPostalCode.TextChanged
        If Toolbox.ValidationUtils.IsValidPostalCode(Me.txtPostalCode.Text.Trim) Then
            Me._setSaveState(True)
            Me._isDirty(True)
        Else
            Toolbox.UIUtils.ShowMessageBox(AppMessages.INVALID_POSTALCODE, AppMessages.DIALOG_CAPTION, MessageBoxIcon.Error)
            Me.txtPostalCode.Text = ""
            Me._setSaveState(False)
            Me._isDirty(False)
        End If
    End Sub

    Private Sub txtCity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCity.TextChanged
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

    Private Sub chkActive_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkActive.CheckedChanged
        Me._setSaveState(True)
        Me._isDirty(True)
    End Sub

End Class
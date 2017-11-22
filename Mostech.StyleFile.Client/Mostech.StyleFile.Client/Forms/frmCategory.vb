
Imports Mostech.Common
Imports Mostech.Common.Forms
Imports Mostech.StyleFile.Entity

Public Class frmCategory
    Inherits frmStyleFile
    Implements IFormCommon, IFormSaveable

    Private _editType As AppEnums.EditTypeEnum

    Public Event CategoryAdded(ByVal sender As Object, ByVal ea As CategoryEventArgs)
    Public Event CategoryEdited(ByVal sender As Object, ByVal ea As CategoryEventArgs)

    Private Sub frmCategory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            Me._setSaveState(False)
        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
        End Try

    End Sub

    Private Sub _initUI() Implements IFormCommon._initUI

        Try
            Toolbox.UIUtils.SetCommonFormSettings(Me)
            Toolbox.UIUtils.SetCaption(Me, "Kategorivärde")
            AppHelper.SetReqFieldsColor(Me.txtValue)
            Toolbox.UIUtils.SetFocus(Me.txtValue)
        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Sub

    'Private Sub _instantiateFromUI(ByVal bValues As Boolean) Implements IFormSaveable._instantiateFromUI
    'End Sub

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

            Toolbox.UIUtils.SetToolTip(Me.chkActive, "Om ikryssad, kategorivärdet visas i rullgardinsmenyn, annars ej")
            Toolbox.UIUtils.SetToolTip(Me.chkDefault, "Om ikryssad, kategorivärdet visas som förhandsvalt värde i rullgardinsmenyn")

        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Sub

    Private Sub _save() Implements IFormSaveable._save

        Dim ea As CategoryEventArgs = Nothing
        Dim ct As Category = Nothing

        Try
            'init
            '------------------------
            ea = New CategoryEventArgs
            ct = New Category

            'is required fields filled
            '------------------------
            If Not Me._isRequiredFieldsFilled Then
                Toolbox.UIUtils.ShowMessageBox(AppMessages.REQUIRED_FIELDS_MISSING, AppMessages.DIALOG_CAPTION, MessageBoxIcon.Exclamation)
                Me._setSaveState(False)
                Me._isDirty(False)
            End If

            'instantiate
            '------------------------
            ct.Active = Me.chkActive.Checked
            ct.Default = Me.chkDefault.Checked
            ct.Value = Me.txtValue.Text.Trim

            'is input validated
            '------------------------
            If Not Me._isInputValidated(ct) Then
                Toolbox.UIUtils.ShowMessageBox(AppMessages.INPUT_VALIDATION_FAILED, AppMessages.DIALOG_CAPTION, MessageBoxIcon.Exclamation)
                Me._setSaveState(False)
                Me._isDirty(False)
                Exit Sub
            End If

            'close
            '------------------------
            ea.Value = ct.Value
            ea.Active = ct.Active
            ea.Default = ct.Default
            Select Case Me._editType
                Case AppEnums.EditTypeEnum.INSERT : RaiseEvent CategoryAdded(Me, ea)
                Case AppEnums.EditTypeEnum.UPDATE : RaiseEvent CategoryEdited(Me, ea)
            End Select
            Toolbox.UIUtils.CloseForm(Me, False, AppMessages.CONFIRM_CLOSE_WINDOW, AppMessages.DIALOG_CAPTION)

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
            Toolbox.UIUtils.SetCaption(Me, "Kategorivärde (ej sparat)")
        Else
            Toolbox.UIUtils.SetCaption(Me, "Kategorivärde")
        End If

    End Sub

    Private Function _isRequiredFieldsFilled() As Boolean Implements IFormSaveable._isRequiredFieldsFilled

        Try
            Return (Me.txtValue.Text.Length > 0)
        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Function

    Private Function _isInputValidated(ByVal entity As Entity.Entity) As Boolean Implements IFormSaveable._isInputValidated

        Dim b As Boolean = False
        Dim ct As Category = Nothing
        Dim sSQLDelimiterChar As String = ""

        Try
            b = True
            ct = DirectCast(entity, Category)
            sSQLDelimiterChar = "'"

            If ct.Value.Contains(sSQLDelimiterChar) Then Return False

        Catch ex As Exception
            b = False
            Throw ex
        End Try

        Return b

    End Function

    Public Sub InitForInsert(ByVal editType As AppEnums.EditTypeEnum)

        Try
            Me.chkActive.Checked = True
            Me.chkDefault.Checked = False
            Me._editType = editType
            Me.IsDirty = False
        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Sub

    Public Sub InitForUpdate(ByVal sValue As String, _
                             ByVal bActive As Boolean, _
                             ByVal bDefault As Boolean, _
                             ByVal editType As AppEnums.EditTypeEnum)

        Try
            Me.txtValue.Text = sValue
            Me.chkActive.Checked = bActive
            Me.chkDefault.Checked = bDefault
            Me._editType = editType
            Me.IsDirty = False
        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me._closeForm(False)
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Me._save()
    End Sub

    Private Sub txtValue_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtValue.TextChanged
        Me._setSaveState(True)
        Me._isDirty(True)
    End Sub

    Private Sub chkActive_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkActive.CheckedChanged
        Me._setSaveState(True)
        Me._isDirty(True)
    End Sub

    Private Sub chkDefault_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDefault.CheckedChanged
        Me._setSaveState(True)
        Me._isDirty(True)
        If Me.chkDefault.Checked Then Me.chkActive.Checked = True
    End Sub

End Class
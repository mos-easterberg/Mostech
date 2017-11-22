
Imports Mostech.Common
Imports Mostech.Common.Forms
Imports Mostech.StyleFile.Entity
Imports Mostech.StyleFile.Service

Imports System.Text

Public Class frmCategories
    Inherits frmStyleFile
    Implements IFormSaveable, IFormCommon

    Private _sKey As String

    Private Sub frmCategory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me._init()
    End Sub

    Private Sub _closeForm(ByVal bConfirm As Boolean) Implements IFormCommon._closeForm
        Toolbox.UIUtils.CloseForm(Me, bConfirm, AppMessages.CONFIRM_CLOSE_WINDOW, AppMessages.DIALOG_CAPTION)
    End Sub

    Private Sub _init() Implements IFormCommon._init

        Try
            Me._setIcon()
            Me._initUI()
            Me._setUIColor()
            Me._initTooltips()
        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
        End Try

    End Sub

    Private Sub _initUI() Implements IFormCommon._initUI

        Try
            Me.cboCategoryType.DropDownStyle = ComboBoxStyle.DropDownList
            Me.cboCategoryType.Items.Add("Arbete")
            Me.cboCategoryType.Items.Add("Kund")
            Me.cboCategoryType.Items.Add("Profession")
            Me.cboCategoryType.Items.Add("Momsprocent")
            Me.cboCategoryType.Items.Add("Anställningstyp")
            Me.cboCategoryType.Items.Add("Stadsdel")
            Me.cboCategoryType.Text = Me.cboCategoryType.Items(0)

            Me.dgvValues.Columns(0).Name = "ct_value"
            Me.dgvValues.Columns(1).Name = "ct_active"
            Me.dgvValues.Columns(2).Name = "ct_default"

            Me.CancelButton = Me.btnCancel
            Toolbox.UIUtils.SetCommonFormSettings(Me)

            Toolbox.UIUtils.SetFocus(Me.cboCategoryType)
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

            Toolbox.UIUtils.SetToolTip(Me.btnCancel, "Stäng")
        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Sub

    Private Sub _save() Implements IFormSaveable._save
    End Sub

    Private Function _saveCategory(ByVal ct As Category, _
                                   ByVal dbOp As AppEnums.DBOperationEnum) As Boolean

        Dim b As Boolean = False
        Dim service As CategoryService

        Try
            service = New CategoryService()
            If dbOp = AppEnums.DBOperationEnum.INSERT Then
                b = service.Add(ct, UserSettings.DBAccessSettings)
            Else
                ct.Key = Me._sKey
                b = service.Update(ct, UserSettings.DBAccessSettings)
            End If

            If ct.Default Then Me._setDefaultCategory(ct)

        Catch ex As Exception
            Throw ex
        Finally
            service = Nothing
        End Try

        Return b

    End Function

    Private Sub _setDefaultCategory(ByVal ct As Category)

        Dim service As CategoryService
        Dim sb As New StringBuilder

        Try
            service = New CategoryService()
            sb.Append("update ")
            sb.Append(UserSettings.DBAccessSettings.DBName)
            sb.Append(".category set ct_default=0 where")
            sb.Append(" ct_type='" & ct.Type & "'")
            sb.Append(" and ct_value <> '" & ct.Value & "'")
            service.RunSQL(sb.ToString, UserSettings.DBAccessSettings)
        Catch ex As Exception
            Throw ex
        Finally
            service = Nothing
        End Try

    End Sub

    Private Sub _setSaveState(ByVal bIsSaveable As Boolean) Implements IFormSaveable._setSaveState
    End Sub

    Private Sub _isDirty(ByVal b As Boolean) Implements IFormSaveable._isDirty
    End Sub

    Private Function _isRequiredFieldsFilled() As Boolean Implements IFormSaveable._isRequiredFieldsFilled
        Return False
    End Function

    Private Function _isInputValidated(ByVal entity As Entity.Entity) As Boolean Implements IFormSaveable._isInputValidated
        Return False
    End Function

    Private Sub _loadCategoriesToUI(ByVal bEmptyGrid As Boolean, _
                                    ByVal type As AppEnums.CategoryTypeEnum)

        Dim coll As Collection
        Dim i As Integer = 0

        Try
            If bEmptyGrid Then Me.dgvValues.Rows.Clear()
            coll = ServiceHelper.GetCategories(type, False)
            If coll.Count > 0 Then
                For Each ct As Category In coll
                    Me.dgvValues.Rows.Add()
                    Me.dgvValues.Rows(i).Tag = ct.Key
                    Me.dgvValues.Rows(i).Cells("ct_value").Value = ct.Value
                    Me.dgvValues.Rows(i).Cells("ct_active").Value = ct.Active
                    Me.dgvValues.Rows(i).Cells("ct_default").Value = ct.Default
                    i += 1
                Next
            End If
        Catch ex As Exception
            Throw ex
        Finally
            coll = Nothing
        End Try

    End Sub

    Private Function _getCategoryTypeFromUI() As AppEnums.CategoryTypeEnum

        Try
            Select Case Me.cboCategoryType.Text.ToUpper
                Case "ARBETE" : Return AppEnums.CategoryTypeEnum.JOB
                Case "KUND" : Return AppEnums.CategoryTypeEnum.CUSTOMER
                Case "PROFESSION" : Return AppEnums.CategoryTypeEnum.PROFESSION
                Case "MOMSPROCENT" : Return AppEnums.CategoryTypeEnum.VATPERCENTAGE
                Case "ANSTÄLLNINGSTYP" : Return AppEnums.CategoryTypeEnum.EMPLOYMENT
                Case "STADSDEL" : Return AppEnums.CategoryTypeEnum.DISTRICT
            End Select
        Catch ex As Exception
            Throw ex
        Finally
        End Try

        Return Nothing

    End Function

    Private Function _getCategoryTypeStringFromUI() As String
        Return Me.cboCategoryType.Text
    End Function

    Private Sub _addValue()

        Dim frm As New frmCategory

        Try
            frm.InitForInsert(AppEnums.EditTypeEnum.INSERT)
            AddHandler frm.CategoryAdded, AddressOf frmCategory_CategoryAdded
            frm.ShowDialog()
        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
        End Try

    End Sub

    Private Sub _editValue()

        Dim frm As New frmCategory

        Try
            Me._sKey = Me.dgvValues.SelectedRows(0).Tag
            frm.InitForUpdate(Me.dgvValues.SelectedRows(0).Cells(0).Value.ToString, _
                              Me.dgvValues.SelectedRows(0).Cells(1).Value, _
                              Me.dgvValues.SelectedRows(0).Cells(2).Value, _
                              AppEnums.EditTypeEnum.UPDATE)
            AddHandler frm.CategoryEdited, AddressOf frmCategory_CategoryEdited
            frm.ShowDialog()
        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
        End Try

    End Sub

    Private Sub frmCategory_CategoryAdded(ByVal sender As System.Object, _
                                          ByVal ea As CategoryEventArgs)

        Dim ct As New Category

        Try
            ct.Type = Me._getCategoryTypeStringFromUI
            ct.Value = ea.Value
            ct.Active = ea.Active
            ct.Default = ea.Default
            Me._saveCategory(ct, AppEnums.DBOperationEnum.INSERT)
        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
            Me._loadCategoriesToUI(True, Me._getCategoryTypeFromUI)
        End Try

    End Sub

    Private Sub frmCategory_CategoryEdited(ByVal sender As System.Object, _
                                           ByVal ea As CategoryEventArgs)

        Dim ct As New Category

        Try
            ct.Type = Me._getCategoryTypeStringFromUI
            ct.Value = ea.Value
            ct.Active = ea.Active
            ct.Default = ea.Default
            Me._saveCategory(ct, AppEnums.DBOperationEnum.UPDATE)
        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
            Me._loadCategoriesToUI(True, Me._getCategoryTypeFromUI)
        End Try

    End Sub

    Private Sub _removeValue()

        Try
            If Toolbox.UIUtils.ConfirmDialog(AppMessages.CONFIRM_REMOVAL, AppMessages.DIALOG_CAPTION) = True Then
                Me._removeValue(Me.dgvValues.SelectedRows(0).Tag)
            End If
        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
        End Try

    End Sub

    Private Sub _removeValue(ByVal sKey As String)

        Dim service As CategoryService

        Try
            service = New CategoryService()
            If service.Remove(sKey, UserSettings.DBAccessSettings) Then
                Me._loadCategoriesToUI(True, Me._getCategoryTypeFromUI())
            Else
                Toolbox.UIUtils.ShowMessageBox(AppMessages.FAILED_TO_REMOVE_ITEM, AppMessages.DIALOG_CAPTION, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            service = Nothing
        End Try

    End Sub

    Private Sub _scrollCategoryList()

        Try
            Me._loadCategoriesToUI(True, Me._getCategoryTypeFromUI())
        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
        End Try

    End Sub

    Private Sub btnNewValue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewValue.Click
        Me._addValue()
    End Sub

    Private Sub btnEditValue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditValue.Click
        Me._editValue()
    End Sub

    Private Sub btnRemoveValue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveValue.Click
        Me._removeValue()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me._closeForm(False)

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me._closeForm(False)
    End Sub

    Private Sub cboCategoryType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCategoryType.SelectedIndexChanged
        Me._scrollCategoryList()
    End Sub

    Private Sub dgvValues_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvValues.DoubleClick
        Me._editValue()
    End Sub

End Class
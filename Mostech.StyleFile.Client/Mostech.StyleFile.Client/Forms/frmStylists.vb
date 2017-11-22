
Imports Mostech.Common
Imports Mostech.Common.Forms

Imports Mostech.StyleFile.Entity
Imports Mostech.StyleFile.Service

Imports System.Text

Public Class frmStylists
    Inherits frmStyleFile
    Implements IFormCommon

    Private Sub frmStylists_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me._init()
    End Sub

    Private Sub _closeForm(ByVal bConfirm As Boolean) Implements IFormCommon._closeForm
        Toolbox.UIUtils.CloseForm(Me, False, AppMessages.CONFIRM_CLOSE_WINDOW, AppMessages.DIALOG_CAPTION)
    End Sub

    Private Sub _init() Implements IFormCommon._init

        Try
            Me._setIcon()
            Me._initUI()
            Me._setUIColor()
            Me._initTooltips()
            Me._loadStylistsToUI(False)
        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
        End Try

    End Sub

    Private Sub _initUI() Implements IFormCommon._initUI

        Try
            Me.dgvStylists.Columns(0).Name = "st_lastname"
            Me.dgvStylists.Columns(1).Name = "st_firstname"

            Me.CancelButton = Me.btnCancel
            Toolbox.UIUtils.SetCommonFormSettings(Me)
            Toolbox.UIUtils.SetFocus(Me.btnNewStylist)

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

    Private Sub _initTooltips() Implements IFormCommon._initTooltips

        Try
            If Not UserSettings.UserAppSettings.ShowToolTips Then Exit Sub

            Toolbox.UIUtils.SetToolTip(Me.btnCancel, "Stäng")
        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Sub

    Private Sub _loadStylistsToUI(ByVal bEmptyGrid As Boolean)

        Dim coll As Collection
        Dim i As Integer = 0
        Dim service As StylistService
        Dim sb As New StringBuilder

        Try
            service = New StylistService()
            If bEmptyGrid Then Me.dgvStylists.Rows.Clear()
            sb.Append("select * from ")
            sb.Append(UserSettings.DBAccessSettings.DBName)
            sb.Append(".stylist order by st_lastname")
            coll = service.FetchBySQL(sb.ToString, UserSettings.DBAccessSettings)
            If coll.Count > 0 Then
                For Each s As Stylist In coll
                    Me.dgvStylists.Rows.Add()
                    Me.dgvStylists.Rows(i).Tag = s.Key
                    Me.dgvStylists.Rows(i).Cells("st_lastname").Value = s.LastName
                    Me.dgvStylists.Rows(i).Cells("st_firstname").Value = s.FirstName
                    i += 1
                Next
                Me.btnEditStylist.Enabled = True
                Me.btnRemoveStylist.Enabled = True
            Else
                Me.btnEditStylist.Enabled = False
                Me.btnRemoveStylist.Enabled = False
            End If
        Catch ex As Exception
            Throw ex
        Finally
            coll = Nothing
            service = Nothing
        End Try

    End Sub

    Private Sub _setIcon() Implements IFormCommon._setIcon
        Me.Icon = My.Resources.icon_StyleFile
    End Sub

    Private Sub _showStylist(ByVal sKey As String)

        Dim f As frmStylist

        Try
            f = New frmStylist
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
            Me._loadStylistsToUI(True)
        End Try

    End Sub

    Private Sub _removeStylist()

        Dim sKey As String = ""

        Try
            If Me.dgvStylists.SelectedRows.Count = 1 Then
                sKey = Me.dgvStylists.SelectedRows(0).Tag
                If Me._stylistHasJobs(sKey) Then
                    Toolbox.UIUtils.ShowMessageBox(AppMessages.STYLIST_HAS_JOBS, AppMessages.DIALOG_CAPTION, MessageBoxIcon.Exclamation)
                Else
                    If Toolbox.UIUtils.ConfirmDialog(AppMessages.CONFIRM_REMOVAL, AppMessages.DIALOG_CAPTION) = True Then
                        Me._removeStylist(sKey)
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

    Private Function _stylistHasJobs(ByVal sKey As String) As Boolean

        Dim sb As New StringBuilder
        Dim service As StylistService
        Dim data As DataSet
        Dim b As Boolean = True

        Try
            service = New StylistService()
            sb.Append("select count(*) from ")
            sb.Append(UserSettings.DBAccessSettings.DBName)
            sb.Append(".job where jb_stylist = '")
            sb.Append(sKey)
            sb.Append("'")
            data = service.FetchBySQLAsDataSet(sb.ToString, UserSettings.DBAccessSettings)
            If Toolbox.ConversionUtils.ParseInteger(data.Tables(0).Rows(0).Item(0).ToString) >= 1 Then
                b = True
            Else
                b = False
            End If
        Catch ex As Exception
            Throw ex
        Finally
            data = Nothing
            service = Nothing
        End Try

        Return b

    End Function

    Private Sub _removeStylist(ByVal sKey As String)

        Dim service As StylistService

        Try
            service = New StylistService()
            If service.Remove(sKey, UserSettings.DBAccessSettings) Then
                Me._loadStylistsToUI(True)
            Else
                Toolbox.UIUtils.ShowMessageBox(AppMessages.FAILED_TO_REMOVE_ITEM, AppMessages.DIALOG_CAPTION, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            service = Nothing
        End Try

    End Sub

    Private Sub btnNewStylist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewStylist.Click
        Me._showStylist("")
    End Sub

    Private Sub btnEditStylist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditStylist.Click
        Me._showStylist(Me.dgvStylists.SelectedRows(0).Tag)
    End Sub

    Private Sub btnRemoveStylist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveStylist.Click
        Me._removeStylist()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me._closeForm(False)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me._closeForm(False)
    End Sub

    Private Sub dgvStylists_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvStylists.DoubleClick
        Me._showStylist(Me.dgvStylists.SelectedRows(0).Tag)
    End Sub

End Class
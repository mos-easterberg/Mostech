
Imports Mostech.Common
Imports Mostech.Common.Forms

Public Class frmLogin
    Inherits frmStyleFile
    Implements IFormCommon

    Private _sPassword As String = ""

    Public Event LoginExecuted(ByVal sender As Object, ByVal ea As LoginEventArgs)

    Public WriteOnly Property Password As String
        Set(ByVal value As String)
            'Me._sPassword = Toolbox.EncryptionUtils.SimpleDecrypt(value)
            Me._sPassword = value
        End Set
    End Property

    Private Sub frmLogin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me._init()
    End Sub

    Private Sub _closeForm(ByVal bConfirm As Boolean) Implements IFormCommon._closeForm

        Dim ea As New LoginEventArgs

        Try
            ea.LoginSuccess = False
            RaiseEvent LoginExecuted(Me, ea)
            Me.Close()
        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Sub

    Private Sub _init() Implements IFormCommon._init
        Me._setIcon()
        Me._initUI()
        Me._setUIColor()
        Me._initTooltips()
    End Sub

    Private Sub _initUI() Implements IFormCommon._initUI
        Me.txtPassword.PasswordChar = "*"
        Me.txtPassword.Focus()
        Me.btnOK.Enabled = False
        Toolbox.UIUtils.SetFocus(Me.btnOK)
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

            Toolbox.UIUtils.SetToolTip(Me.btnCancel, "Stäng")
        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me._closeForm(False)
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Me._login()
    End Sub

    Private Sub _login()

        Dim ea As New LoginEventArgs

        Try
            If Me._isCorrectPassword(Me.txtPassword.Text.Trim, Me._sPassword) Then
                ea.LoginSuccess = True
                RaiseEvent LoginExecuted(Me, ea)
                Me.Close()
            Else
                Me.txtPassword.Text = ""
                ea.LoginSuccess = False
                Toolbox.UIUtils.ShowMessageBox(AppMessages.INVALID_PASSWORD, AppMessages.DIALOG_CAPTION, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            AppHelper.CatchException(ex, AppHelper.HandleException.BOTH, UserSettings.LogSettings)
        Finally
            ea = Nothing
        End Try

    End Sub

    Private Function _isCorrectPassword(ByVal sText As String, _
                                        ByVal sCorrectPassword As String) As Boolean

        Dim bMatch As Boolean = False

        Try
            If sText.Equals(sCorrectPassword) Then
                bMatch = True
            End If
        Catch ex As Exception
            Throw ex
        Finally
        End Try

        Return bMatch

    End Function

    Private Sub txtPassword_TextChanged(sender As Object, e As System.EventArgs) Handles txtPassword.TextChanged
        Me.btnOK.Enabled = Me.txtPassword.Text.Trim.Length >= 3
    End Sub

End Class
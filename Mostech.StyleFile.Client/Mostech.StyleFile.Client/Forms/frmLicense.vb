
Imports Mostech.Common
Imports Mostech.Common.Forms

Public Class frmLicense
    Inherits frmStyleFile
    Implements IFormCommon

    Private Sub frmLicense_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me._init()
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

    Private Sub _init() Implements IFormCommon._init

        Try
            Me._setIcon()
            Me._initUI()
            Me._setUIColor()
            Me._initTooltips()
            Me._loadLicenseInfoToUI()
            'Me._loadCustomerLogoToUI()
        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Sub

    Private Sub _initUI() Implements IFormCommon._initUI

        Try
            Me.FormBorderStyle = BorderStyle.FixedSingle
            Me.HelpButton = False
            Me.StartPosition = FormStartPosition.CenterParent
            Me.ShowIcon = True
            Me.ShowInTaskbar = False
            Toolbox.UIUtils.SetFocus(Me.btnOK)
        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Sub

    'Private Sub _loadCustomerLogoToUI()

    '    Dim img As Image = Nothing
    '    Dim sLicenseCompany As String = ""

    '    Try
    '        sLicenseCompany = Toolbox.StringUtils.Split(UserSettings.License.Company, "-", False).Item(0).ToString

    '        Select Case sLicenseCompany.ToUpper
    '            Case "HAIRHOUSE" : img = My.Resources.hairhouse_logo
    '            Case "ZIKZAG" : img = My.Resources.zikzag_logo
    '            Case Else : img = My.Resources.mostech_logo
    '        End Select

    '        Me.pbCustomerLogo.Size = img.Size
    '        Me.pbCustomerLogo.Image = img

    '    Catch ex As Exception
    '        Throw ex
    '    End Try

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

            Toolbox.UIUtils.SetToolTip(Me.btnOK, "OK")
        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Sub

    Private Sub _loadLicenseInfoToUI()

        Try
            Me.lblStartDate.Text = UserSettings.License.StartDate
            Me.lblEndDate.Text = UserSettings.License.EndDate
            Me.lblUsers.Text = UserSettings.License.NrOfLicensedUsers
            Me.lblCompany.Text = UserSettings.License.Company
            Me.lblCopyRightDesc.Text = "Mostech"
        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Me._closeForm(False)
    End Sub

End Class
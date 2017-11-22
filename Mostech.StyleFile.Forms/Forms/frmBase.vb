
Public Class frmBase
    Inherits System.Windows.Forms.Form

    Private _isClosing As Boolean
    Private _sCaption As String

    Protected Property IsClosing() As Boolean
        Get
            Return Me._isClosing
        End Get
        Set(ByVal Value As Boolean)
            Me._isClosing = Value
        End Set
    End Property

    Protected Property Caption() As String
        Get
            Return Me._sCaption
        End Get
        Set(ByVal Value As String)
            Me._sCaption = Value
        End Set
    End Property

    Protected Sub SetLoading(ByVal bLoading As Boolean)

        If bLoading Then
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Else
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End If

    End Sub

    Protected Sub ShowForm(ByRef frm As System.Windows.Forms.Form)

        Try
            frm.Show()
        Catch ex As Exception
            Throw
        End Try

    End Sub

    Protected Sub ShowMDIForm(ByRef frm As System.Windows.Forms.Form, _
                             ByRef parentForm As System.Windows.Forms.Form)

        Try
            frm.MdiParent = parentForm
            frm.Show()
        Catch ex As Exception
            Throw
        End Try

    End Sub

    Protected Sub ShowModalForm(ByRef frm As System.Windows.Forms.Form, _
                             ByRef parentForm As System.Windows.Forms.Form)

        Try
            frm.ShowDialog(parentForm)
        Catch ex As Exception
            Throw
        End Try

    End Sub

    Protected Sub SetRequiredFieldsIdentification(ByRef fields As Collection, _
                                              ByVal backColor As System.Drawing.Color)

        Try
            For Each ctrl As System.Windows.Forms.Control In fields
                ctrl.BackColor = backColor
            Next
        Catch ex As Exception
            Throw
        End Try

    End Sub

    Protected Sub EnableControls(ByVal bEnable As Boolean, _
                                 ByRef frm As System.Windows.Forms.Form)

        Try
            Me.EnableControls(bEnable, New ArrayList, frm)
        Catch ex As Exception
            'Throw
        End Try

    End Sub

    Protected Sub EnableControls(ByVal bEnable As Boolean, _
                                 ByVal enabledControls As ArrayList, _
                                 ByRef frm As System.Windows.Forms.Form)

        Try
            For Each ctrl As System.Windows.Forms.Control In frm.Controls
                If enabledControls.Contains(ctrl.GetType.Name.ToUpper) Then
                    ctrl.Enabled = bEnable
                    If ctrl.HasChildren Then
                        Me.EnableControls(bEnable, enabledControls, ctrl.Controls)
                    End If
                Else
                    ctrl.Enabled = Not bEnable
                End If
            Next
        Catch ex As Exception
            'Throw
        End Try

    End Sub

    Protected Sub EnableControls(ByVal bEnable As Boolean, _
                                 ByVal enabledControls As ArrayList, _
                                 ByRef controls As System.Windows.Forms.Control.ControlCollection)

        Try
            For Each ctrl As System.Windows.Forms.Control In controls
                If enabledControls.Contains(ctrl.GetType.Name.ToUpper) Then
                    ctrl.Enabled = bEnable
                    If ctrl.HasChildren Then
                        Me.EnableControls(bEnable, enabledControls, ctrl.Controls)
                    End If
                Else
                    ctrl.Enabled = Not bEnable
                End If
            Next
        Catch ex As Exception
            'Throw
        End Try

    End Sub

End Class
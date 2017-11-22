
Imports System.Windows.Forms
Imports System.Windows.Forms.Control

Public Class UIUtils

    Public Enum PathTypeEnum
        FILE
        FOLDER
    End Enum

    Public Shared Function BrowseFileSystemForPath(ByVal sInitialFolder As String,
                                                   ByVal sFileFilter As String,
                                                   ByVal bShowReadOnly As Boolean,
                                                   ByVal pathType As PathTypeEnum) As String

        Dim ofd As OpenFileDialog = Nothing
        Dim odd As FolderBrowserDialog = Nothing
        Dim sPath As String = ""

        Try

            Select Case pathType

                'FILE
                '-------------------------------------------------
                Case PathTypeEnum.FILE
                    ofd = New OpenFileDialog
                    ofd.InitialDirectory = sInitialFolder
                    ofd.Filter = sFileFilter
                    ofd.ShowReadOnly = bShowReadOnly

                    If ofd.ShowDialog = DialogResult.OK Then
                        sPath = ofd.FileName
                    End If

                    'FOLDER
                    '-------------------------------------------------
                Case PathTypeEnum.FOLDER
                    odd = New FolderBrowserDialog

                    If odd.ShowDialog = DialogResult.OK Then
                        sPath = odd.SelectedPath
                    End If

            End Select

        Catch ex As Exception
            Throw ex
        Finally
        End Try

        Return sPath

    End Function

    Public Shared Sub SetCursor(ByVal cursor As Cursor, ByRef frm As Form)

        Try
            frm.Cursor = cursor
        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Sub

    Public Shared Sub ShowMessageBox(ByVal sMessage As String,
                                     ByVal sCaption As String,
                                     ByVal icon As MessageBoxIcon)


        Try
            MessageBox.Show(sMessage, sCaption, MessageBoxButtons.OK, icon)
        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Sub

    Public Shared Function AskConfirmation(ByVal sMessage As String,
                                           ByVal sCaption As String,
                                           ByVal style As MsgBoxStyle) As MsgBoxResult

        Dim answer As MsgBoxResult = Nothing
        Dim answerOption As MsgBoxStyle = Nothing

        Try
            answer = MsgBox(sMessage, style + vbQuestion, sCaption)
        Catch ex As Exception
            Throw ex
        Finally
        End Try

        Return answer

    End Function

    Public Shared Function ShowQuestionBox(ByVal sMessage As String,
                                           ByVal sCaption As String,
                                           ByVal sDefaultResponse As String) As String

        Dim s As String = ""

        Try
            s = InputBox(sMessage, sCaption, sDefaultResponse)
        Catch ex As Exception
            Throw ex
        Finally
        End Try

        Return s

    End Function

    Public Shared Sub SetToolTip(ByRef ctrl As Control,
                                 ByVal sText As String)

        Dim toolTipObj As New ToolTip

        Try
            With toolTipObj
                .AutoPopDelay = 5000
                .InitialDelay = 1000
                .ReshowDelay = 500
                'Force the ToolTip text to be displayed whether or not the form is active.
                .ShowAlways = True
                .SetToolTip(ctrl, sText)
            End With
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Shared Sub SetCaption(ByRef frm As System.Windows.Forms.Form,
                                 ByVal sCaption As String)

        Try
            frm.Text = sCaption
        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Sub

    Public Shared Sub SetStatusBarMsg(ByVal sMsg As String,
                                      ByVal sTabName As String,
                                      ByRef sb As System.Windows.Forms.StatusStrip)

        Try
            sb.Items(sTabName).Text = sMsg
        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Sub

    Public Shared Sub ShowNotYetImplementedMsg()

        Dim sMsg As String = "This function is not yet implemented!"
        Dim sCaption As String = "Not yet implemented"

        MessageBox.Show(sMsg, sCaption, MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Public Shared Function ConfirmDialog(ByVal sMsg As String,
                                         ByVal sCaption As String) As Boolean

        Dim b As Boolean = False

        Try
            If UIUtils.ConfirmDialog(sMsg, sCaption, MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
                b = True
            Else
                b = False
            End If
        Catch ex As Exception
            Throw ex
        End Try

        Return b

    End Function

    Public Shared Function ConfirmDialog(ByVal sMsg As String,
                                         ByVal sCaption As String,
                                         ByVal buttons As MessageBoxButtons) As MsgBoxResult

        Try
            Return MessageBox.Show(sMsg, sCaption, buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Shared Function CloseForm(ByRef frm As System.Windows.Forms.Form,
                                    ByVal bAsk As Boolean,
                                    ByVal sText As String,
                                    ByVal sCaption As String)

        Dim b As Boolean = False

        Try
            If bAsk Then
                If Toolbox.UIUtils.ConfirmDialog(sText, sCaption) Then
                    b = True
                    frm.Close()
                Else
                    b = False
                End If
            Else
                b = True
                frm.Close()
            End If
        Catch ex As Exception
            Throw
        End Try

        Return b

    End Function

    Public Shared Sub SetCommonFormSettings(ByRef frm As System.Windows.Forms.Form)

        Try
            frm.FormBorderStyle = BorderStyle.FixedSingle
            frm.HelpButton = False
            frm.MaximizeBox = False
            frm.MinimizeBox = False
            frm.StartPosition = FormStartPosition.CenterParent
            frm.ShowIcon = True
            frm.ShowInTaskbar = False
        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Sub

    Public Shared Sub SetFocus(ByRef ctrl As Control)

        Try
            ctrl.Focus()
        Catch ex As Exception
        End Try

    End Sub

    Public Shared Function GetControlsByType(ByVal allCtrls As ControlCollection,
                                             ByVal ctrlType As Type) As ControlCollection

        Dim ctrls As New ControlCollection(Nothing)

        Try
            For Each ctrl As Control In allCtrls
                If ctrl.GetType = ctrlType Then
                    ctrls.Add(ctrl)
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try

        Return ctrls

    End Function

End Class

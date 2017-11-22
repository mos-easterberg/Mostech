
Imports Mostech.Common

Imports Mostech.StyleFile.Entity
Imports Mostech.Common.Entity

Imports System.Text
Imports System.Windows.Forms

Public Class GUIHelper

    Public Const COMBOBOX_SEPARATOR As String = "                                                                                                      " & "#_#_#_#_#_#"

    Public Shared Sub SetRemainingCharacterCountInLabel(ByRef tb As TextBox, _
                                                        ByRef gb As GroupBox, _
                                                        ByVal sDesc As String)

        Try
            gb.Text = sDesc & GUIHelper._getRemainingCharacterCountString(tb)
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Shared Sub SetRemainingCharacterCountInLabel(ByRef tb As TextBox, _
                                                        ByRef lbl As Label, _
                                                        ByVal sDesc As String)

        Try
            lbl.Text = sDesc & GUIHelper._getRemainingCharacterCountString(tb)
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Shared Sub SetRemainingCharacterCountInLabel(ByRef rtb As RichTextBox, _
                                                        ByRef txt As TextBox, _
                                                        ByVal sDesc As String)

        Try
            txt.Text = sDesc & GUIHelper._getRemainingCharacterCountString(rtb.TextLength, rtb.MaxLength)
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Shared Sub SetRemainingCharacterCountInLabel(ByRef rtb As RichTextBox, _
                                                        ByRef gb As GroupBox, _
                                                        ByVal sDesc As String)

        Try
            gb.Text = sDesc & GUIHelper._getRemainingCharacterCountString(rtb.TextLength, rtb.MaxLength)
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Shared Function _getRemainingCharacterCountString(ByRef tb As TextBox) As String

        Try
            Return " (" & tb.TextLength & "/" & tb.MaxLength & ")"
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Shared Function _getRemainingCharacterCountString(ByVal iTextLength As Integer, _
                                                              ByVal iMaxLength As Integer) As String

        Try
            Return " (" & iTextLength & "/" & iMaxLength & ")"
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Shared Function GetKeyFromComboString(ByVal sComboValue As String) As String

        Dim array As ArrayList = Nothing

        Try
            If sComboValue.Equals("") Then Return ""
            array = Toolbox.StringUtils.Split(sComboValue, GUIHelper.COMBOBOX_SEPARATOR)
            Return array.Item(array.Count - 1).ToString
        Catch ex As Exception
            Throw ex
        End Try

        Return ""

    End Function

    Public Shared Function GetValueFromComboString(ByVal sComboValue As String) As String

        Dim array As ArrayList
        Dim iArrayLength As Integer = 0
        Dim s As String = ""

        Try
            If sComboValue.Equals("") Then Return ""
            array = Toolbox.StringUtils.Split(sComboValue, GUIHelper.COMBOBOX_SEPARATOR)
            iArrayLength = array.Count
            If iArrayLength = 2 Then
                s = array.Item(0).ToString
            ElseIf iArrayLength = 3 Then
                s = array.Item(0).ToString & " " & array.Item(1).ToString
            End If
        Catch ex As Exception
            Throw ex
        End Try

        Return s

    End Function

    Public Shared Function GetLookupValue(ByVal sKey As String, _
                                          ByVal items As ComboBox.ObjectCollection) As String

        Try
            For Each sComboValue As String In items
                If GUIHelper.GetKeyFromComboString(sComboValue) = sKey Then
                    Return sComboValue
                End If
            Next
        Catch ex As Exception
            Throw
        End Try

        Return ""

    End Function

    Public Shared Function ValidateEmailAddress(ByRef ctrl As Control) As Boolean

        Try
            ValidateEmailAddress(ctrl, False)
        Catch ex As Exception
            Throw
        End Try

        Return False

    End Function

    Public Shared Function ValidateEmailAddress(ByRef ctrl As Control, _
                                                ByVal bForceFocus As Boolean) As Boolean

        Try

            If ctrl Is Nothing Then
                Return True
            End If

            If ctrl.Text.Equals("") Then
                Return True
            End If

            If Toolbox.ValidationUtils.IsValidEmail(ctrl.Text.Trim) Then
                Return True
            Else
                Toolbox.UIUtils.ShowMessageBox(AppMessages.INVALID_EMAIL, AppMessages.DIALOG_CAPTION, MessageBoxIcon.Error)
                If bForceFocus Then
                    ctrl.Focus()
                End If
                Return False
            End If
        Catch ex As Exception
            Throw
            Return False
        End Try

    End Function

    Public Shared Sub ValidateEmailAddresses(ByVal sAddresses As String, _
                                             ByVal sDelimiter As String)

        Dim arr As New ArrayList
        Dim sb As New System.Text.StringBuilder
        Dim sMsg As String

        Try
            arr = Toolbox.ValidationUtils.GetValidatedEmailAddresses(sAddresses, sDelimiter, True)
            If arr.Count > 0 Then
                For Each s As String In arr
                    sb.Append(s)
                    sb.Append(vbNewLine)
                Next
                sMsg = "The following e-mail addresses are invalid;" & vbNewLine & vbNewLine & _
                        sb.ToString
                Toolbox.UIUtils.ShowMessageBox(sMsg, AppMessages.DIALOG_CAPTION, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            Throw
        End Try

    End Sub



End Class

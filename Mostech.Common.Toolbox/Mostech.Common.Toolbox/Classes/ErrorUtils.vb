
Imports System.Text

Public Class ErrorUtils

    Public Enum ErrorAction
        [DISPLAY]
        [LOG]
        [LOG_AND_DISPLAY]
    End Enum

    Public Shared Sub DisplayException(ByVal ex As Exception)

        Try
            ErrorUtils.DisplayException(ex, "")
        Catch exc As Exception
            Throw exc
        End Try

    End Sub

    Public Shared Sub DisplayException(ByVal ex As Exception,
                                       ByVal sErrMsg As String)

        Dim frm As frmExceptionDisplay

        Try
            frm = New frmExceptionDisplay
            frm.Init(ex, sErrMsg)
            frm.ShowDialog()
        Catch ex2 As Exception
            Throw ex2
        Finally
            frm = Nothing
        End Try

    End Sub

End Class

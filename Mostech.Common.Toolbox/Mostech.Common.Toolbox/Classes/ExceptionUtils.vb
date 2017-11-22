
Public Class ExceptionUtils

    Public Shared Function ExceptionToString(ByVal ex As Exception, _
                                             Optional ByVal bAllData As Boolean = False) As String

        Dim sMsg As String = ""
        Dim sHelpLink As String = ""
        Dim sInnerException As String = ""

        Try
            If Not bAllData Then
                sMsg = "Message: " & ex.Message.ToString & vbNewLine & _
                       "Source: " & ex.Source.ToString & vbNewLine & _
                       "TargetSite: " & ex.TargetSite.ToString
            Else

                Try
                    sHelpLink = ex.HelpLink.ToString
                Catch ex2 As Exception
                    sHelpLink = ""
                Finally
                End Try

                Try
                    sInnerException = ex.InnerException.ToString()
                Catch ex3 As Exception
                    sInnerException = ""
                Finally
                End Try

                sMsg = "Message: " & ex.Message.ToString & vbNewLine & _
                       "Source: " & ex.Source.ToString & vbNewLine & _
                       "TargetSite: " & ex.TargetSite.ToString & vbNewLine & _
                       "StackTrace: " & ex.StackTrace.ToString & vbNewLine & _
                       "HelpLink: " & sHelpLink & vbNewLine & _
                       "InnerException: " & sInnerException
            End If

        Catch exx As Exception
            Throw ex
        Finally
        End Try

        Return sMsg

    End Function

End Class

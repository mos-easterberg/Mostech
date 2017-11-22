
Imports System.Text

Public Class EncryptionUtils

    Public Shared Function SimpleEncrypt(ByVal sStr As String) As String

        Try
            Return EncryptionUtils.SimpleEncrypt(sStr, True)
        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Function

    Public Shared Function SimpleEncrypt(ByVal sStr As String, _
                                         ByVal bReplaceWhiteSpaceWithUnderScore As Boolean) As String

        Dim i As Integer
        Dim s As String
        Dim rnd As Integer
        Dim sb As New StringBuilder

        Try
            rnd = (Date.Now.Millisecond Mod 8) + 1

            sb.Append(Chr(rnd + 100))
            For i = 0 To sStr.Length - 1
                s = Chr(Asc(sStr.Substring(i, 1)) + rnd)
                If bReplaceWhiteSpaceWithUnderScore Then s = s.Replace(" ", "_")
                sb.Append(s)
            Next
        Catch ex As Exception
            Throw ex
        Finally
        End Try

        Return sb.ToString

    End Function

    Public Shared Function SimpleDecrypt(ByVal sStr As String) As String

        Try
            Return EncryptionUtils.SimpleDecrypt(sStr, True)
        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Function

    Public Shared Function SimpleDecrypt(ByVal sStr As String, _
                                         ByVal bReplaceUnderScoreWithWhiteSpace As Boolean) As String

        Dim i As Integer
        Dim s As String
        Dim rnd As Integer
        Dim sb As New StringBuilder

        Try
            sStr = sStr.Trim
            If sStr.Length = 0 Then Return String.Empty
            rnd = Asc(sStr.Substring(0, 1)) - 100

            For i = 1 To sStr.Length - 1
                s = Chr(Asc(sStr.Substring(i, 1)) - rnd).ToString
                If bReplaceUnderScoreWithWhiteSpace Then s = s.Replace("_", " ")
                sb.Append(s)
            Next
        Catch ex As Exception
            Throw ex
        Finally
        End Try

        Return sb.ToString.Trim

    End Function

End Class

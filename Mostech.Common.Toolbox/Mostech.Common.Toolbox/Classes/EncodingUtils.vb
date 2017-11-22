
Imports System.Text

Public Class EncodingUtils

    Public Shared Function UniCodeToXML(ByVal sString As String) As String

        Dim sb As New StringBuilder

        Try
            For Each c As Char In sString.ToCharArray()
                If Not EncodingUtils.IsCharInRange(c, 65, 90) AndAlso Not EncodingUtils.IsCharInRange(c, 97, 122) Then
                    sb.Append("&#" & AscW(c) & ";")
                Else
                    sb.Append(c)
                End If
            Next

        Catch ex As Exception
            Throw ex
        Finally
        End Try

        Return sb.ToString

    End Function

    Public Shared Function IsCharInRange(ByVal c As Char, _
                                         ByVal iLowerBoundary As Integer, _
                                         ByVal iUpperBoundary As Integer) As Boolean

        Dim b As Boolean = False
        Dim i As Integer = 0

        Try
            i = AscW(c)
            If i >= iLowerBoundary Then
                If i <= iUpperBoundary Then
                    b = True
                End If
            End If
        Catch ex As Exception
            Throw ex
        Finally
        End Try

        Return b

    End Function

    Public Shared Function TranslateStringToEncoding(ByVal sEncoding As String) As System.Text.Encoding

        Dim encoding As System.Text.Encoding = Nothing

        Try
            Select Case sEncoding
                Case "ASCII" : encoding = New System.Text.ASCIIEncoding
                Case "UNICODE" : encoding = New System.Text.UnicodeEncoding
                Case "UTF7" : encoding = New System.Text.UTF7Encoding
                Case "UTF8" : encoding = New System.Text.UTF8Encoding
                Case "UTF32" : encoding = New System.Text.UTF32Encoding

                Case Else : encoding = Nothing
            End Select

        Catch ex As Exception
            Throw ex
        Finally
        End Try

        Return encoding

    End Function

End Class

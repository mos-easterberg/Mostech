
Public Class MiscUtils

    Public Shared Function GetAlphabet(ByVal language As LanguageUtils.Language) As String()

        Dim alphabet() As String = Nothing

        Try
            Select Case language
                Case LanguageUtils.Language.ENGLISH
                    alphabet = New String() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
                Case LanguageUtils.Language.SWEDISH, LanguageUtils.Language.FINNISH
                    alphabet = New String() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "Å", "Ä", "Ö"}
            End Select
        Catch ex As Exception
            Throw ex
        Finally
        End Try

        Return alphabet

    End Function

    Public Shared Function CalculatePriceExclVAT(ByVal dNetPrice As Double, _
                                                 ByVal iTaxPercentage As Integer, _
                                                 ByVal bPadCents As Boolean) As String

        Dim dPriceExclVAT As Double = 0.0
        Dim dTaxPercentage As Double = 0.0
        Dim arr As ArrayList = Nothing
        Dim s As String = ""

        Try
            dTaxPercentage = (iTaxPercentage / 100) + 1
            dPriceExclVAT = Math.Round(dNetPrice / dTaxPercentage, 2)
            arr = StringUtils.Split(dPriceExclVAT.ToString, ",")
            If arr.Count = 1 Then arr.Add("0")
            arr(1) = StringUtils.Pad(arr(1), "0", 2, StringUtils.PadDirection.RIGHT)
            s = arr(0).ToString & "," & arr(1).ToString
        Catch ex As Exception
            Throw ex
        Finally
        End Try

        Return s

    End Function

End Class

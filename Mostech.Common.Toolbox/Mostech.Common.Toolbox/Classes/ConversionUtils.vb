
Public Class ConversionUtils

    Public Enum ConversionCoefficient
        KB
        MB
        GB
    End Enum

    Public Shared Function ConvertBytes(ByVal lBytes As Long, _
                                        ByVal coff As ConversionCoefficient) As Double

        Dim iDivisor As Integer
        Dim d As Double = 0.0

        Try
            Select Case coff
                Case ConversionCoefficient.KB : iDivisor = 1024
                Case ConversionCoefficient.MB : iDivisor = 1024 * 1024
                Case ConversionCoefficient.GB : iDivisor = 1024 * 1024 * 1024
            End Select

            d = Math.Round((lBytes / iDivisor), 0)

        Catch ex As Exception
            Throw ex
        Finally
        End Try

        Return d

    End Function

    Public Shared Function ParseDate(ByVal sDate As String,
                                     ByVal bThrowException As Boolean) As Date

        Try
            Return CDate(sDate)
        Catch ex As Exception
            If bThrowException Then Throw ex
        Finally
        End Try

        Return Nothing

    End Function

    Public Shared Function ParseInteger(ByVal s As String) As Integer

        Try
            Return Integer.Parse(s)
        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Function

    Public Shared Function ParseInteger(ByVal s As String, _
                                        ByVal bThrowException As Boolean) As Integer

        Dim i As Integer = 0

        Try
            i = Integer.Parse(s)
        Catch ex As Exception
            If bThrowException Then Throw ex
        Finally
        End Try

        Return i

    End Function

    Public Shared Function ParseDecimal(ByVal s As String) As Decimal

        Try
            Return Decimal.Parse(s)
        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Function

    Public Shared Function ParseDecimal(ByVal s As String, _
                                        ByVal bThrowException As Boolean) As Decimal

        Dim d As Decimal = 0.0

        Try
            d = Decimal.Parse(s)
        Catch ex As Exception
            If bThrowException Then Throw ex
        Finally
        End Try

        Return d

    End Function

    Public Shared Function ParseDouble(ByVal s As String) As Double

        Try
            Return Double.Parse(s)
        Catch ex As Exception
            Throw ex
        Finally
        End Try

    End Function

    Public Shared Function ParseDouble(ByVal s As String, _
                                       ByVal bThrowException As Boolean) As Double

        Dim d As Double = 0

        Try
            d = Double.Parse(s)
        Catch ex As Exception
            If bThrowException Then Throw ex
        Finally
        End Try

        Return d

    End Function

End Class

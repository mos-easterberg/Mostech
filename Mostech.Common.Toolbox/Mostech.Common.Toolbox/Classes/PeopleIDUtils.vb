
Imports System.Text

Public Class PeopleIDUtils

    Public Enum DateOfBirthPart
        DAY
        MONTH
        YEAR
    End Enum

    Public Shared Function GetDateOfBirthString(ByVal sDay As String,
                                                ByVal sMonth As String,
                                                ByVal sYear As String) As String

        Try
            Return PeopleIDUtils.GetDateOfBirthString(sDay, sMonth, sYear, "-")
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Shared Function GetDateOfBirthString(ByVal sDay As String,
                                               ByVal sMonth As String,
                                               ByVal sYear As String,
                                               ByVal sDatePartDelimiter As String) As String

        Dim sb As New StringBuilder

        Try
            sb.Append(sDay)
            sb.Append(sDatePartDelimiter)
            sb.Append(sMonth)
            sb.Append(sDatePartDelimiter)
            sb.Append(sYear)
        Catch ex As Exception
            Throw ex
        End Try

        Return sb.ToString

    End Function

    Public Shared Function GetDateOfBirthPart(ByVal sDateOfBirth As String,
                                              ByVal part As DateOfBirthPart) As String

        Try
            Return PeopleIDUtils.GetDateOfBirthPart(sDateOfBirth, part, "-")
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Shared Function GetDateOfBirthPart(ByVal sDateOfBirth As String,
                                              ByVal part As DateOfBirthPart,
                                              ByVal sDatePartDelimiter As String) As String

        Dim sDateOfBirthPart As String = ""
        Dim arr As New ArrayList

        Try
            '24-05-1976
            If sDateOfBirth.Length <> 10 Then Return ""

            arr = StringUtils.Split(sDateOfBirth, sDatePartDelimiter, False)
            Select Case part
                Case DateOfBirthPart.DAY : sDateOfBirthPart = arr(0).ToString
                Case DateOfBirthPart.MONTH : sDateOfBirthPart = arr(1).ToString
                Case DateOfBirthPart.YEAR : sDateOfBirthPart = arr(2).ToString
            End Select
        Catch ex As Exception
            Throw ex
        End Try

        Return sDateOfBirthPart

    End Function

End Class

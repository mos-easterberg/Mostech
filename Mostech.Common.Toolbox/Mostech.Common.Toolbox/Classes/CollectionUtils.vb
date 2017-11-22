
Public Class CollectionUtils

    Public Shared Function TranslateDelimitedStringToCollection(ByVal sString As String, _
                                                                ByVal sDelimiter As String) As Collection

        Dim coll As Collection = Nothing

        Try
            coll = New Collection
            For Each s As String In Toolbox.StringUtils.Split(sString, sDelimiter)
                coll.Add(s)
            Next
        Catch ex As Exception
            Throw ex
        End Try

        Return coll

    End Function

End Class

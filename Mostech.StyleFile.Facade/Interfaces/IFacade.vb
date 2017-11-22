
Imports Mostech.Common.Entity

Public Interface IFacade

    Function FetchBySQL(ByVal sSQL As String, ByVal db As DBAccess) As DataSet
    Function Add(ByVal sSQL As String, ByVal db As DBAccess) As Boolean
    Function Update(ByVal sSQL As String, ByVal db As DBAccess) As Boolean
    Function Remove(ByVal sSQL As String, ByVal db As DBAccess) As Boolean
    Function RunSQL(ByVal sSQL As String, ByVal db As DBAccess) As Boolean

End Interface


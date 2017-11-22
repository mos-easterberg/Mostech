
Imports Mostech.Common.Entity

Public Interface IService

    Function FetchBySQLAsDataSet(ByVal sSQL As String, ByVal db As DBAccess) As DataSet
    Function FetchBySQL(ByVal sSQL As String, ByVal db As DBAccess) As Collection
    Function Add(ByVal entity As Entity.Entity, ByVal db As DBAccess) As Boolean
    Function Update(ByVal entity As Entity.Entity, ByVal db As DBAccess) As Boolean
    Function Remove(ByVal sKey As String, ByVal db As DBAccess) As Boolean
    Function RunSQL(ByVal sSQL As String, ByVal db As DBAccess) As Boolean

End Interface

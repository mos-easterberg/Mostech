
Imports Mostech.Common.Entity

Public Interface IFactory

    Function InstantiateEntity(ByVal data As DataSet, ByVal type As FactoryEnums.InstantionType, ByVal db As DBAccess) As Collection
    Function CreateSQL(ByVal entity As Entity.Entity, ByVal dbOp As FactoryEnums.DBOperation, ByVal db As DBAccess) As String
    Function CreateSQL(ByVal sKey As String, ByVal dbOp As FactoryEnums.DBOperation, ByVal db As DBAccess) As String

End Interface


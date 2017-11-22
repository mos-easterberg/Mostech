
Public Class FactoryEnums

    Public Enum DBOperation
        [SELECT] = 0
        [INSERT] = 1
        [UPDATE] = 2
        [DELETE] = 3
        [DELETE_BY_PARENT] = 4
    End Enum

    Public Enum InstantionType
        GRID = 0
        FORM = 1
    End Enum

End Class

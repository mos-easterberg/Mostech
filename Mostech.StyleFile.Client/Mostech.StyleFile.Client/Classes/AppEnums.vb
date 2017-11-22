
Public Class AppEnums

    'Public Enum InstantiationTypeEnum
    '    [BASIC]
    '    [FULL]
    'End Enum

    Public Enum DBOperationEnum
        [SELECT_ONE]
        [SELECT_ALL]
        [INSERT]
        [UPDATE]
        [DELETE]
    End Enum

    Public Enum EntityEnum
        [STYLIST]
        [CUSTOMER]
        [JOB]
        [CATEGORY]
    End Enum

    Public Enum CategoryTypeEnum
        [ALL]
        [CUSTOMER]
        [JOB]
        [PROFESSION]
        [VATPERCENTAGE]
        [EMPLOYMENT]
        [DISTRICT]
    End Enum

    Public Enum EditTypeEnum
        [INSERT]
        [UPDATE]
    End Enum

    Public Enum JobFormatStyleEnum
        HTML
        TEXT
    End Enum

    Public Enum EntityLoadTypeEnum
        KEYS
        VALUES
    End Enum

End Class

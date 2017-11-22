
Imports Mostech.Common.Entity
Imports Mostech.Common.Settings
Imports Mostech.StyleFile.Entity

Public Class UserSettings

    Private Shared _instance As UserSettings
    Public Shared DBAccessSettings As DBAccess
    Public Shared UserAppSettings As AppSettings
    Public Shared License As License
    Public Shared LogSettings As LogSettings
    Public Shared EmailSettings As EmailSettings

    Private Sub New()
    End Sub

    Public Shared Function GetInstance() As UserSettings
        SyncLock GetType(UserSettings)
            If _instance Is Nothing Then
                _instance = New UserSettings
            End If
        End SyncLock
        Return _instance
    End Function

End Class

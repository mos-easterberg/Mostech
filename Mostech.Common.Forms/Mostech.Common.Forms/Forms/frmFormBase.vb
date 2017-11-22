
Public MustInherit Class frmFormBase
    Inherits System.Windows.Forms.Form

    Public Enum FormStateEnum
        LOADING
        IDLE
        SAVING
        CLOSING
    End Enum

    Protected Property IsClosing() As Boolean
    Protected Property IsDirty() As Boolean
    Protected Property IsSaved() As Boolean

    Protected Property FormState As FormStateEnum

End Class
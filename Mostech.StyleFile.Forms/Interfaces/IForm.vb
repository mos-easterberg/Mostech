
Public Interface IForm

    Sub CatchError(ByVal ex As Exception, ByVal sMsg As String)
    Sub ClearUI()
    Sub Close(ByVal bAsk As Boolean)
    Sub Init()
    Sub InitGUI()
    Sub InitForUpdate(ByVal sKey As String, ByVal bReadOnly As Boolean)
    Sub InitForInsert(ByVal sKey As String)
    Sub IsDirty(ByVal bDirty As Boolean)
    Sub LoadEntity(ByVal sKey As String)
    Sub Save()
    Sub SetToolTips()
    Sub ShowHelp()
    Sub Resize()

    Function InstantiateFromUI() As Object
    Function GetRequiredFields() As Collection

End Interface


Public Interface IView

    Sub CatchError(ByVal ex As Exception, ByVal sMsg As String)
    Sub Close(ByVal bAsk As Boolean)
    Sub Init()
    Sub InitGUI()
    Sub SetToolTips()
    Sub ShowHelp()
    Sub Resize()

End Interface

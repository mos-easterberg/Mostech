
Public Class DateOfBirth

    Public Property Day As String
    Public Property Month As String
    Public Property Year As String

    Public Sub New()
    End Sub

    Public Sub New(ByVal sDay As String,
                   ByVal sMonth As String,
                   ByVal sYear As String)
        Day = sDay
        Month = sMonth
        Year = sYear
    End Sub

End Class

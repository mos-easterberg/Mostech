
Public Class frmFormBase
    Inherits frmBase

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFormBase))
        Me.SuspendLayout()
        '
        'frmFormBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFormBase"
        Me.Text = "frmFormBase"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Enum DatabaseOp
        [INSERT]
        [UPDATE]
        [DELETE]
    End Enum

    Private _databaseOp As DatabaseOp
    Private _isDirty As Boolean
    Private _isSaved As Boolean
    Private _isClosing As Boolean
    Private _sCaption As String

    Protected Property DatabaseOperation() As DatabaseOp
        Get
            Return Me._databaseOp
        End Get
        Set(ByVal Value As DatabaseOp)
            Me._databaseOp = Value
        End Set
    End Property

    Protected Property IsDirty() As Boolean
        Get
            Return Me._isDirty
        End Get
        Set(ByVal Value As Boolean)
            Me._isDirty = Value
        End Set
    End Property

    Protected Property IsSaved() As Boolean
        Get
            Return Me._isSaved
        End Get
        Set(ByVal Value As Boolean)
            Me._isSaved = Value
        End Set
    End Property

End Class

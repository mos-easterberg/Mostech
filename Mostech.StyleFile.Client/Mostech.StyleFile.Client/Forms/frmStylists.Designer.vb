<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStylists
    Inherits Mostech.Common.Forms.frmStyleFile

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStylists))
        Me.dgvStylists = New System.Windows.Forms.DataGridView()
        Me.st_lastname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.st_firstname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnRemoveStylist = New System.Windows.Forms.Button()
        Me.btnNewStylist = New System.Windows.Forms.Button()
        Me.btnEditStylist = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.dgvStylists, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvStylists
        '
        Me.dgvStylists.AllowUserToAddRows = False
        Me.dgvStylists.AllowUserToDeleteRows = False
        Me.dgvStylists.AllowUserToOrderColumns = True
        Me.dgvStylists.AllowUserToResizeRows = False
        Me.dgvStylists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStylists.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.st_lastname, Me.st_firstname})
        Me.dgvStylists.Location = New System.Drawing.Point(12, 12)
        Me.dgvStylists.MultiSelect = False
        Me.dgvStylists.Name = "dgvStylists"
        Me.dgvStylists.ReadOnly = True
        Me.dgvStylists.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStylists.Size = New System.Drawing.Size(311, 215)
        Me.dgvStylists.TabIndex = 5
        Me.dgvStylists.TabStop = False
        '
        'st_lastname
        '
        Me.st_lastname.HeaderText = "Efternamn"
        Me.st_lastname.Name = "st_lastname"
        Me.st_lastname.ReadOnly = True
        '
        'st_firstname
        '
        Me.st_firstname.HeaderText = "Förnamn"
        Me.st_firstname.Name = "st_firstname"
        Me.st_firstname.ReadOnly = True
        '
        'btnRemoveStylist
        '
        Me.btnRemoveStylist.Location = New System.Drawing.Point(329, 70)
        Me.btnRemoveStylist.Name = "btnRemoveStylist"
        Me.btnRemoveStylist.Size = New System.Drawing.Size(76, 23)
        Me.btnRemoveStylist.TabIndex = 2
        Me.btnRemoveStylist.Text = "&Radera"
        Me.btnRemoveStylist.UseVisualStyleBackColor = True
        '
        'btnNewStylist
        '
        Me.btnNewStylist.Location = New System.Drawing.Point(329, 12)
        Me.btnNewStylist.Name = "btnNewStylist"
        Me.btnNewStylist.Size = New System.Drawing.Size(76, 23)
        Me.btnNewStylist.TabIndex = 0
        Me.btnNewStylist.Text = "&Ny..."
        Me.btnNewStylist.UseVisualStyleBackColor = True
        '
        'btnEditStylist
        '
        Me.btnEditStylist.Location = New System.Drawing.Point(329, 41)
        Me.btnEditStylist.Name = "btnEditStylist"
        Me.btnEditStylist.Size = New System.Drawing.Size(76, 23)
        Me.btnEditStylist.TabIndex = 1
        Me.btnEditStylist.Text = "&Visa/ändra..."
        Me.btnEditStylist.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(248, 242)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "&Avbryt"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(330, 204)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "&Stäng"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmStylists
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 233)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnRemoveStylist)
        Me.Controls.Add(Me.btnNewStylist)
        Me.Controls.Add(Me.btnEditStylist)
        Me.Controls.Add(Me.dgvStylists)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStylists"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Stylister"
        CType(Me.dgvStylists, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvStylists As System.Windows.Forms.DataGridView
    Friend WithEvents btnRemoveStylist As System.Windows.Forms.Button
    Friend WithEvents btnNewStylist As System.Windows.Forms.Button
    Friend WithEvents btnEditStylist As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents st_lastname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents st_firstname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class

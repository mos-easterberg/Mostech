<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCategories
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCategories))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboCategoryType = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvValues = New System.Windows.Forms.DataGridView()
        Me.ct_value = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ct_active = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ct_default = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnRemoveValue = New System.Windows.Forms.Button()
        Me.btnNewValue = New System.Windows.Forms.Button()
        Me.btnEditValue = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvValues, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboCategoryType)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(281, 52)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Kategorityp"
        '
        'cboCategoryType
        '
        Me.cboCategoryType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategoryType.FormattingEnabled = True
        Me.cboCategoryType.Location = New System.Drawing.Point(9, 19)
        Me.cboCategoryType.Name = "cboCategoryType"
        Me.cboCategoryType.Size = New System.Drawing.Size(264, 21)
        Me.cboCategoryType.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvValues)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 65)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(281, 171)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Värden"
        '
        'dgvValues
        '
        Me.dgvValues.AllowUserToAddRows = False
        Me.dgvValues.AllowUserToDeleteRows = False
        Me.dgvValues.AllowUserToResizeRows = False
        Me.dgvValues.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvValues.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ct_value, Me.ct_active, Me.ct_default})
        Me.dgvValues.Location = New System.Drawing.Point(9, 19)
        Me.dgvValues.MultiSelect = False
        Me.dgvValues.Name = "dgvValues"
        Me.dgvValues.ReadOnly = True
        Me.dgvValues.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvValues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvValues.Size = New System.Drawing.Size(264, 146)
        Me.dgvValues.TabIndex = 0
        Me.dgvValues.TabStop = False
        '
        'ct_value
        '
        Me.ct_value.HeaderText = "Värde"
        Me.ct_value.Name = "ct_value"
        Me.ct_value.ReadOnly = True
        '
        'ct_active
        '
        Me.ct_active.HeaderText = "Aktiv"
        Me.ct_active.Name = "ct_active"
        Me.ct_active.ReadOnly = True
        '
        'ct_default
        '
        Me.ct_default.HeaderText = "Förhandsvald"
        Me.ct_default.Name = "ct_default"
        Me.ct_default.ReadOnly = True
        '
        'btnRemoveValue
        '
        Me.btnRemoveValue.Location = New System.Drawing.Point(290, 142)
        Me.btnRemoveValue.Name = "btnRemoveValue"
        Me.btnRemoveValue.Size = New System.Drawing.Size(76, 23)
        Me.btnRemoveValue.TabIndex = 4
        Me.btnRemoveValue.Text = "&Radera"
        Me.btnRemoveValue.UseVisualStyleBackColor = True
        '
        'btnNewValue
        '
        Me.btnNewValue.Location = New System.Drawing.Point(290, 84)
        Me.btnNewValue.Name = "btnNewValue"
        Me.btnNewValue.Size = New System.Drawing.Size(76, 23)
        Me.btnNewValue.TabIndex = 2
        Me.btnNewValue.Text = "&Ny..."
        Me.btnNewValue.UseVisualStyleBackColor = True
        '
        'btnEditValue
        '
        Me.btnEditValue.Location = New System.Drawing.Point(290, 113)
        Me.btnEditValue.Name = "btnEditValue"
        Me.btnEditValue.Size = New System.Drawing.Size(76, 23)
        Me.btnEditValue.TabIndex = 3
        Me.btnEditValue.Text = "&Ändra..."
        Me.btnEditValue.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(151, 263)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "&Avbryt"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(290, 213)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "&Stäng"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmCategories
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 241)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnRemoveValue)
        Me.Controls.Add(Me.btnNewValue)
        Me.Controls.Add(Me.btnEditValue)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCategories"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Kategorier"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvValues, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboCategoryType As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvValues As System.Windows.Forms.DataGridView
    Friend WithEvents btnRemoveValue As System.Windows.Forms.Button
    Friend WithEvents btnNewValue As System.Windows.Forms.Button
    Friend WithEvents btnEditValue As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents ct_value As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ct_active As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ct_default As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class

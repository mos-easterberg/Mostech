<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReport))
        Me.tcTabs = New System.Windows.Forms.TabControl()
        Me.tpRunReport = New System.Windows.Forms.TabPage()
        Me.gbResult = New System.Windows.Forms.GroupBox()
        Me.btnSaveResult = New System.Windows.Forms.Button()
        Me.dgData = New System.Windows.Forms.DataGrid()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.cboExecutableReports = New System.Windows.Forms.ComboBox()
        Me.tpCreateReport = New System.Windows.Forms.TabPage()
        Me.btnRemoveReport = New System.Windows.Forms.Button()
        Me.cboEditableReports = New System.Windows.Forms.ComboBox()
        Me.btnUpdateReport = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSaveReport = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtEdited = New System.Windows.Forms.TextBox()
        Me.txtCreated = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gbSQL = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSQLCounter = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.rtbSQL = New System.Windows.Forms.RichTextBox()
        Me.chkActive = New System.Windows.Forms.CheckBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.tcTabs.SuspendLayout()
        Me.tpRunReport.SuspendLayout()
        Me.gbResult.SuspendLayout()
        CType(Me.dgData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpCreateReport.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbSQL.SuspendLayout()
        Me.SuspendLayout()
        '
        'tcTabs
        '
        Me.tcTabs.Controls.Add(Me.tpRunReport)
        Me.tcTabs.Controls.Add(Me.tpCreateReport)
        Me.tcTabs.Location = New System.Drawing.Point(3, 2)
        Me.tcTabs.Name = "tcTabs"
        Me.tcTabs.SelectedIndex = 0
        Me.tcTabs.Size = New System.Drawing.Size(419, 434)
        Me.tcTabs.TabIndex = 0
        '
        'tpRunReport
        '
        Me.tpRunReport.Controls.Add(Me.gbResult)
        Me.tpRunReport.Controls.Add(Me.Label1)
        Me.tpRunReport.Controls.Add(Me.btnRun)
        Me.tpRunReport.Controls.Add(Me.cboExecutableReports)
        Me.tpRunReport.Location = New System.Drawing.Point(4, 22)
        Me.tpRunReport.Name = "tpRunReport"
        Me.tpRunReport.Padding = New System.Windows.Forms.Padding(3)
        Me.tpRunReport.Size = New System.Drawing.Size(411, 408)
        Me.tpRunReport.TabIndex = 0
        Me.tpRunReport.Tag = "RUN_REPORT"
        Me.tpRunReport.Text = "Ta ut rapport"
        Me.tpRunReport.UseVisualStyleBackColor = True
        '
        'gbResult
        '
        Me.gbResult.Controls.Add(Me.btnSaveResult)
        Me.gbResult.Controls.Add(Me.dgData)
        Me.gbResult.Location = New System.Drawing.Point(9, 33)
        Me.gbResult.Name = "gbResult"
        Me.gbResult.Size = New System.Drawing.Size(396, 369)
        Me.gbResult.TabIndex = 16
        Me.gbResult.TabStop = False
        Me.gbResult.Text = "Resultat"
        '
        'btnSaveResult
        '
        Me.btnSaveResult.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSaveResult.Location = New System.Drawing.Point(6, 19)
        Me.btnSaveResult.Name = "btnSaveResult"
        Me.btnSaveResult.Size = New System.Drawing.Size(124, 23)
        Me.btnSaveResult.TabIndex = 0
        Me.btnSaveResult.Text = "&Spara resultat som bild"
        Me.btnSaveResult.UseVisualStyleBackColor = True
        '
        'dgData
        '
        Me.dgData.DataMember = ""
        Me.dgData.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgData.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgData.Location = New System.Drawing.Point(6, 48)
        Me.dgData.Name = "dgData"
        Me.dgData.Size = New System.Drawing.Size(384, 315)
        Me.dgData.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Välj rapport:"
        '
        'btnRun
        '
        Me.btnRun.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnRun.Location = New System.Drawing.Point(330, 6)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(75, 25)
        Me.btnRun.TabIndex = 1
        Me.btnRun.Text = "&Kör"
        Me.btnRun.UseVisualStyleBackColor = True
        '
        'cboExecutableReports
        '
        Me.cboExecutableReports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboExecutableReports.FormattingEnabled = True
        Me.cboExecutableReports.Location = New System.Drawing.Point(75, 6)
        Me.cboExecutableReports.Name = "cboExecutableReports"
        Me.cboExecutableReports.Size = New System.Drawing.Size(249, 21)
        Me.cboExecutableReports.TabIndex = 0
        '
        'tpCreateReport
        '
        Me.tpCreateReport.Controls.Add(Me.btnRemoveReport)
        Me.tpCreateReport.Controls.Add(Me.cboEditableReports)
        Me.tpCreateReport.Controls.Add(Me.btnUpdateReport)
        Me.tpCreateReport.Controls.Add(Me.Label6)
        Me.tpCreateReport.Controls.Add(Me.btnSaveReport)
        Me.tpCreateReport.Controls.Add(Me.GroupBox2)
        Me.tpCreateReport.Controls.Add(Me.gbSQL)
        Me.tpCreateReport.Location = New System.Drawing.Point(4, 22)
        Me.tpCreateReport.Name = "tpCreateReport"
        Me.tpCreateReport.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCreateReport.Size = New System.Drawing.Size(411, 408)
        Me.tpCreateReport.TabIndex = 1
        Me.tpCreateReport.Tag = "CREATE_REPORT"
        Me.tpCreateReport.Text = "Skapa/editera rapport"
        Me.tpCreateReport.UseVisualStyleBackColor = True
        '
        'btnRemoveReport
        '
        Me.btnRemoveReport.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnRemoveReport.Location = New System.Drawing.Point(201, 379)
        Me.btnRemoveReport.Name = "btnRemoveReport"
        Me.btnRemoveReport.Size = New System.Drawing.Size(90, 23)
        Me.btnRemoveReport.TabIndex = 29
        Me.btnRemoveReport.Text = "&Radera"
        Me.btnRemoveReport.UseVisualStyleBackColor = True
        '
        'cboEditableReports
        '
        Me.cboEditableReports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEditableReports.FormattingEnabled = True
        Me.cboEditableReports.Location = New System.Drawing.Point(105, 13)
        Me.cboEditableReports.Name = "cboEditableReports"
        Me.cboEditableReports.Size = New System.Drawing.Size(300, 21)
        Me.cboEditableReports.TabIndex = 3
        '
        'btnUpdateReport
        '
        Me.btnUpdateReport.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnUpdateReport.Location = New System.Drawing.Point(9, 379)
        Me.btnUpdateReport.Name = "btnUpdateReport"
        Me.btnUpdateReport.Size = New System.Drawing.Size(90, 23)
        Me.btnUpdateReport.TabIndex = 17
        Me.btnUpdateReport.Text = "&Uppdatera"
        Me.btnUpdateReport.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Välj rapport:"
        '
        'btnSaveReport
        '
        Me.btnSaveReport.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSaveReport.Location = New System.Drawing.Point(105, 379)
        Me.btnSaveReport.Name = "btnSaveReport"
        Me.btnSaveReport.Size = New System.Drawing.Size(90, 23)
        Me.btnSaveReport.TabIndex = 15
        Me.btnSaveReport.Text = "S&para som ny..."
        Me.btnSaveReport.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtEdited)
        Me.GroupBox2.Controls.Add(Me.txtCreated)
        Me.GroupBox2.Controls.Add(Me.txtID)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(396, 89)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Automatiska uppgifter"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Ändrad:"
        '
        'txtEdited
        '
        Me.txtEdited.Location = New System.Drawing.Point(96, 64)
        Me.txtEdited.Name = "txtEdited"
        Me.txtEdited.ReadOnly = True
        Me.txtEdited.Size = New System.Drawing.Size(294, 20)
        Me.txtEdited.TabIndex = 4
        Me.txtEdited.TabStop = False
        '
        'txtCreated
        '
        Me.txtCreated.Location = New System.Drawing.Point(96, 42)
        Me.txtCreated.Name = "txtCreated"
        Me.txtCreated.ReadOnly = True
        Me.txtCreated.Size = New System.Drawing.Size(294, 20)
        Me.txtCreated.TabIndex = 3
        Me.txtCreated.TabStop = False
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(96, 19)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(294, 20)
        Me.txtID.TabIndex = 0
        Me.txtID.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Skapad:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Rapportnummer:"
        '
        'gbSQL
        '
        Me.gbSQL.Controls.Add(Me.Label3)
        Me.gbSQL.Controls.Add(Me.Label2)
        Me.gbSQL.Controls.Add(Me.txtSQLCounter)
        Me.gbSQL.Controls.Add(Me.txtName)
        Me.gbSQL.Controls.Add(Me.rtbSQL)
        Me.gbSQL.Controls.Add(Me.chkActive)
        Me.gbSQL.Location = New System.Drawing.Point(9, 135)
        Me.gbSQL.Name = "gbSQL"
        Me.gbSQL.Size = New System.Drawing.Size(396, 237)
        Me.gbSQL.TabIndex = 16
        Me.gbSQL.TabStop = False
        Me.gbSQL.Text = "Rapportuppgifter"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "SQL-fråga:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Namn:"
        '
        'txtSQLCounter
        '
        Me.txtSQLCounter.Location = New System.Drawing.Point(297, 212)
        Me.txtSQLCounter.Name = "txtSQLCounter"
        Me.txtSQLCounter.ReadOnly = True
        Me.txtSQLCounter.Size = New System.Drawing.Size(93, 20)
        Me.txtSQLCounter.TabIndex = 19
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(96, 19)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(294, 20)
        Me.txtName.TabIndex = 19
        '
        'rtbSQL
        '
        Me.rtbSQL.Location = New System.Drawing.Point(96, 68)
        Me.rtbSQL.Name = "rtbSQL"
        Me.rtbSQL.Size = New System.Drawing.Size(294, 138)
        Me.rtbSQL.TabIndex = 0
        Me.rtbSQL.Text = ""
        '
        'chkActive
        '
        Me.chkActive.AutoSize = True
        Me.chkActive.Location = New System.Drawing.Point(96, 45)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(50, 17)
        Me.chkActive.TabIndex = 18
        Me.chkActive.Text = "&Aktiv"
        Me.chkActive.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(144, 481)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 14
        Me.btnClose.Text = "&Stäng"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(424, 439)
        Me.Controls.Add(Me.tcTabs)
        Me.Controls.Add(Me.btnClose)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReport"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "REPORT"
        Me.Text = "Rapporter"
        Me.tcTabs.ResumeLayout(False)
        Me.tpRunReport.ResumeLayout(False)
        Me.tpRunReport.PerformLayout()
        Me.gbResult.ResumeLayout(False)
        CType(Me.dgData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpCreateReport.ResumeLayout(False)
        Me.tpCreateReport.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gbSQL.ResumeLayout(False)
        Me.gbSQL.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcTabs As System.Windows.Forms.TabControl
    Friend WithEvents tpRunReport As System.Windows.Forms.TabPage
    Friend WithEvents tpCreateReport As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboExecutableReports As System.Windows.Forms.ComboBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents cboEditableReports As System.Windows.Forms.ComboBox
    Friend WithEvents rtbSQL As System.Windows.Forms.RichTextBox
    Friend WithEvents gbResult As System.Windows.Forms.GroupBox
    Friend WithEvents gbSQL As System.Windows.Forms.GroupBox
    Friend WithEvents btnSaveReport As System.Windows.Forms.Button
    Friend WithEvents btnRun As System.Windows.Forms.Button
    Friend WithEvents btnUpdateReport As System.Windows.Forms.Button
    Friend WithEvents chkActive As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtEdited As System.Windows.Forms.TextBox
    Friend WithEvents txtCreated As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSQLCounter As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnRemoveReport As System.Windows.Forms.Button
    Friend WithEvents dgData As System.Windows.Forms.DataGrid
    Friend WithEvents btnSaveResult As System.Windows.Forms.Button
End Class

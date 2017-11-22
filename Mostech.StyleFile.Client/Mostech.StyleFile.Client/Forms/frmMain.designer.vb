<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.mnuProgram = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTools = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStylist = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCategory = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuBackup = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuShowHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLicense = New System.Windows.Forms.ToolStripMenuItem()
        Me.MostechOnlineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMostechWebSiteURL = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMostechOnFacebook = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbCustomer = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboSearchField = New System.Windows.Forms.ComboBox()
        Me.txtSearchCriteria = New System.Windows.Forms.TextBox()
        Me.chkShowAllCustomers = New System.Windows.Forms.CheckBox()
        Me.cboLastName = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRemoveCustomer = New System.Windows.Forms.Button()
        Me.btnNewCustomer = New System.Windows.Forms.Button()
        Me.btnEditCustomer = New System.Windows.Forms.Button()
        Me.dgvCustomers = New System.Windows.Forms.DataGridView()
        Me.cu_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cu_lastname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cu_firstname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cu_category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cu_telmobile = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cu_city = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbWork = New System.Windows.Forms.GroupBox()
        Me.btnPrintJob = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.dgvJobs = New System.Windows.Forms.DataGridView()
        Me.jb_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jb_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jb_starttime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jb_stylist = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jb_category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jb_description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_JobSelected = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnRemoveJob = New System.Windows.Forms.Button()
        Me.btnNewJob = New System.Windows.Forms.Button()
        Me.btnEditJob = New System.Windows.Forms.Button()
        Me.sbMain = New System.Windows.Forms.StatusStrip()
        Me.sblLeft = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pbMain = New System.Windows.Forms.ToolStripProgressBar()
        Me.mnuMain.SuspendLayout()
        Me.gbCustomer.SuspendLayout()
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbWork.SuspendLayout()
        CType(Me.dgvJobs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sbMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProgram, Me.mnuTools, Me.mnuHelp})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(758, 24)
        Me.mnuMain.TabIndex = 0
        Me.mnuMain.Text = "MenuStrip1"
        '
        'mnuProgram
        '
        Me.mnuProgram.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSettings, Me.ToolStripSeparator1, Me.mnuExit})
        Me.mnuProgram.Name = "mnuProgram"
        Me.mnuProgram.Size = New System.Drawing.Size(59, 20)
        Me.mnuProgram.Text = "&Program"
        '
        'mnuSettings
        '
        Me.mnuSettings.Name = "mnuSettings"
        Me.mnuSettings.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.mnuSettings.Size = New System.Drawing.Size(169, 22)
        Me.mnuSettings.Text = "&Inställningar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(166, 6)
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(169, 22)
        Me.mnuExit.Text = "&Avsluta"
        '
        'mnuTools
        '
        Me.mnuTools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuStylist, Me.mnuCategory, Me.mnuReport, Me.ToolStripMenuItem2, Me.mnuBackup})
        Me.mnuTools.Name = "mnuTools"
        Me.mnuTools.Size = New System.Drawing.Size(56, 20)
        Me.mnuTools.Text = "&Verktyg"
        '
        'mnuStylist
        '
        Me.mnuStylist.Name = "mnuStylist"
        Me.mnuStylist.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuStylist.Size = New System.Drawing.Size(162, 22)
        Me.mnuStylist.Text = "&Stylister"
        '
        'mnuCategory
        '
        Me.mnuCategory.Name = "mnuCategory"
        Me.mnuCategory.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.K), System.Windows.Forms.Keys)
        Me.mnuCategory.Size = New System.Drawing.Size(162, 22)
        Me.mnuCategory.Text = "&Kategorier"
        '
        'mnuReport
        '
        Me.mnuReport.Name = "mnuReport"
        Me.mnuReport.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.mnuReport.Size = New System.Drawing.Size(162, 22)
        Me.mnuReport.Text = "&Rapporter"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(159, 6)
        '
        'mnuBackup
        '
        Me.mnuBackup.Name = "mnuBackup"
        Me.mnuBackup.Size = New System.Drawing.Size(162, 22)
        Me.mnuBackup.Text = "&Backup"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuShowHelp, Me.mnuLicense, Me.MostechOnlineToolStripMenuItem})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(43, 20)
        Me.mnuHelp.Text = "&Hjälp"
        '
        'mnuShowHelp
        '
        Me.mnuShowHelp.Name = "mnuShowHelp"
        Me.mnuShowHelp.Size = New System.Drawing.Size(157, 22)
        Me.mnuShowHelp.Text = "&Visa hjälp"
        '
        'mnuLicense
        '
        Me.mnuLicense.Name = "mnuLicense"
        Me.mnuLicense.Size = New System.Drawing.Size(157, 22)
        Me.mnuLicense.Text = "&Licensinformation"
        '
        'MostechOnlineToolStripMenuItem
        '
        Me.MostechOnlineToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMostechWebSiteURL, Me.mnuMostechOnFacebook})
        Me.MostechOnlineToolStripMenuItem.Name = "MostechOnlineToolStripMenuItem"
        Me.MostechOnlineToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.MostechOnlineToolStripMenuItem.Text = "Mostech Online"
        '
        'mnuMostechWebSiteURL
        '
        Me.mnuMostechWebSiteURL.Name = "mnuMostechWebSiteURL"
        Me.mnuMostechWebSiteURL.Size = New System.Drawing.Size(178, 22)
        Me.mnuMostechWebSiteURL.Text = "Mostech.fi"
        '
        'mnuMostechOnFacebook
        '
        Me.mnuMostechOnFacebook.Name = "mnuMostechOnFacebook"
        Me.mnuMostechOnFacebook.Size = New System.Drawing.Size(178, 22)
        Me.mnuMostechOnFacebook.Text = "Mostech på Facebook"
        '
        'gbCustomer
        '
        Me.gbCustomer.Controls.Add(Me.Label3)
        Me.gbCustomer.Controls.Add(Me.Label2)
        Me.gbCustomer.Controls.Add(Me.cboSearchField)
        Me.gbCustomer.Controls.Add(Me.txtSearchCriteria)
        Me.gbCustomer.Controls.Add(Me.chkShowAllCustomers)
        Me.gbCustomer.Controls.Add(Me.cboLastName)
        Me.gbCustomer.Controls.Add(Me.Label1)
        Me.gbCustomer.Controls.Add(Me.btnRemoveCustomer)
        Me.gbCustomer.Controls.Add(Me.btnNewCustomer)
        Me.gbCustomer.Controls.Add(Me.btnEditCustomer)
        Me.gbCustomer.Controls.Add(Me.dgvCustomers)
        Me.gbCustomer.Location = New System.Drawing.Point(5, 27)
        Me.gbCustomer.Name = "gbCustomer"
        Me.gbCustomer.Size = New System.Drawing.Size(748, 296)
        Me.gbCustomer.TabIndex = 0
        Me.gbCustomer.TabStop = False
        Me.gbCustomer.Text = "Kunder"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(444, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Sökord:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(312, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Sökfält:"
        '
        'cboSearchField
        '
        Me.cboSearchField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSearchField.FormattingEnabled = True
        Me.cboSearchField.Location = New System.Drawing.Point(361, 18)
        Me.cboSearchField.Name = "cboSearchField"
        Me.cboSearchField.Size = New System.Drawing.Size(77, 21)
        Me.cboSearchField.TabIndex = 4
        '
        'txtSearchCriteria
        '
        Me.txtSearchCriteria.Location = New System.Drawing.Point(492, 19)
        Me.txtSearchCriteria.Name = "txtSearchCriteria"
        Me.txtSearchCriteria.Size = New System.Drawing.Size(158, 20)
        Me.txtSearchCriteria.TabIndex = 5
        '
        'chkShowAllCustomers
        '
        Me.chkShowAllCustomers.AutoSize = True
        Me.chkShowAllCustomers.Location = New System.Drawing.Point(9, 41)
        Me.chkShowAllCustomers.Name = "chkShowAllCustomers"
        Me.chkShowAllCustomers.Size = New System.Drawing.Size(101, 17)
        Me.chkShowAllCustomers.TabIndex = 6
        Me.chkShowAllCustomers.Text = "Visa alla kunder"
        Me.chkShowAllCustomers.UseVisualStyleBackColor = True
        '
        'cboLastName
        '
        Me.cboLastName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLastName.FormattingEnabled = True
        Me.cboLastName.Location = New System.Drawing.Point(231, 18)
        Me.cboLastName.Name = "cboLastName"
        Me.cboLastName.Size = New System.Drawing.Size(40, 21)
        Me.cboLastName.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Lista enligt efternamnets begynnelsebokstav:"
        '
        'btnRemoveCustomer
        '
        Me.btnRemoveCustomer.Location = New System.Drawing.Point(656, 122)
        Me.btnRemoveCustomer.Name = "btnRemoveCustomer"
        Me.btnRemoveCustomer.Size = New System.Drawing.Size(76, 23)
        Me.btnRemoveCustomer.TabIndex = 2
        Me.btnRemoveCustomer.Text = "&Radera"
        Me.btnRemoveCustomer.UseVisualStyleBackColor = True
        '
        'btnNewCustomer
        '
        Me.btnNewCustomer.Location = New System.Drawing.Point(656, 64)
        Me.btnNewCustomer.Name = "btnNewCustomer"
        Me.btnNewCustomer.Size = New System.Drawing.Size(75, 23)
        Me.btnNewCustomer.TabIndex = 0
        Me.btnNewCustomer.Text = "&Ny..."
        Me.btnNewCustomer.UseVisualStyleBackColor = True
        '
        'btnEditCustomer
        '
        Me.btnEditCustomer.Location = New System.Drawing.Point(656, 93)
        Me.btnEditCustomer.Name = "btnEditCustomer"
        Me.btnEditCustomer.Size = New System.Drawing.Size(76, 23)
        Me.btnEditCustomer.TabIndex = 1
        Me.btnEditCustomer.Text = "Visa/&ändra..."
        Me.btnEditCustomer.UseVisualStyleBackColor = True
        '
        'dgvCustomers
        '
        Me.dgvCustomers.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.dgvCustomers.AllowUserToAddRows = False
        Me.dgvCustomers.AllowUserToDeleteRows = False
        Me.dgvCustomers.AllowUserToOrderColumns = True
        Me.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cu_id, Me.cu_lastname, Me.cu_firstname, Me.cu_category, Me.cu_telmobile, Me.cu_city})
        Me.dgvCustomers.Location = New System.Drawing.Point(6, 64)
        Me.dgvCustomers.MultiSelect = False
        Me.dgvCustomers.Name = "dgvCustomers"
        Me.dgvCustomers.ReadOnly = True
        Me.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCustomers.Size = New System.Drawing.Size(644, 216)
        Me.dgvCustomers.TabIndex = 3
        Me.dgvCustomers.TabStop = False
        '
        'cu_id
        '
        Me.cu_id.HeaderText = "Kundnr"
        Me.cu_id.Name = "cu_id"
        Me.cu_id.ReadOnly = True
        '
        'cu_lastname
        '
        Me.cu_lastname.HeaderText = "Efternamn"
        Me.cu_lastname.Name = "cu_lastname"
        Me.cu_lastname.ReadOnly = True
        '
        'cu_firstname
        '
        Me.cu_firstname.HeaderText = "Förnamn"
        Me.cu_firstname.Name = "cu_firstname"
        Me.cu_firstname.ReadOnly = True
        '
        'cu_category
        '
        Me.cu_category.HeaderText = "Kategori"
        Me.cu_category.Name = "cu_category"
        Me.cu_category.ReadOnly = True
        '
        'cu_telmobile
        '
        Me.cu_telmobile.HeaderText = "Mobil"
        Me.cu_telmobile.Name = "cu_telmobile"
        Me.cu_telmobile.ReadOnly = True
        '
        'cu_city
        '
        Me.cu_city.HeaderText = "Ort"
        Me.cu_city.Name = "cu_city"
        Me.cu_city.ReadOnly = True
        '
        'gbWork
        '
        Me.gbWork.Controls.Add(Me.btnPrintJob)
        Me.gbWork.Controls.Add(Me.btnCancel)
        Me.gbWork.Controls.Add(Me.dgvJobs)
        Me.gbWork.Controls.Add(Me.btnRemoveJob)
        Me.gbWork.Controls.Add(Me.btnNewJob)
        Me.gbWork.Controls.Add(Me.btnEditJob)
        Me.gbWork.Location = New System.Drawing.Point(5, 339)
        Me.gbWork.Name = "gbWork"
        Me.gbWork.Size = New System.Drawing.Size(748, 211)
        Me.gbWork.TabIndex = 1
        Me.gbWork.TabStop = False
        Me.gbWork.Text = "Arbeten"
        '
        'btnPrintJob
        '
        Me.btnPrintJob.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnPrintJob.Location = New System.Drawing.Point(656, 106)
        Me.btnPrintJob.Name = "btnPrintJob"
        Me.btnPrintJob.Size = New System.Drawing.Size(75, 23)
        Me.btnPrintJob.TabIndex = 3
        Me.btnPrintJob.Text = "&Skriv ut..."
        Me.btnPrintJob.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(534, 125)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "&Avbryt"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'dgvJobs
        '
        Me.dgvJobs.AllowUserToAddRows = False
        Me.dgvJobs.AllowUserToDeleteRows = False
        Me.dgvJobs.AllowUserToOrderColumns = True
        Me.dgvJobs.AllowUserToResizeRows = False
        Me.dgvJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvJobs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.jb_id, Me.jb_date, Me.jb_starttime, Me.jb_stylist, Me.jb_category, Me.jb_description, Me.col_JobSelected})
        Me.dgvJobs.Location = New System.Drawing.Point(6, 20)
        Me.dgvJobs.MultiSelect = False
        Me.dgvJobs.Name = "dgvJobs"
        Me.dgvJobs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvJobs.Size = New System.Drawing.Size(644, 184)
        Me.dgvJobs.TabIndex = 4
        Me.dgvJobs.TabStop = False
        '
        'jb_id
        '
        Me.jb_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.jb_id.HeaderText = "Nr"
        Me.jb_id.Name = "jb_id"
        Me.jb_id.ReadOnly = True
        Me.jb_id.Width = 33
        '
        'jb_date
        '
        Me.jb_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.jb_date.HeaderText = "Datum"
        Me.jb_date.Name = "jb_date"
        Me.jb_date.ReadOnly = True
        Me.jb_date.Width = 70
        '
        'jb_starttime
        '
        Me.jb_starttime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.jb_starttime.HeaderText = "Tid"
        Me.jb_starttime.Name = "jb_starttime"
        Me.jb_starttime.ReadOnly = True
        Me.jb_starttime.Width = 45
        '
        'jb_stylist
        '
        Me.jb_stylist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.jb_stylist.HeaderText = "Stylist"
        Me.jb_stylist.Name = "jb_stylist"
        Me.jb_stylist.ReadOnly = True
        Me.jb_stylist.Width = 90
        '
        'jb_category
        '
        Me.jb_category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.jb_category.HeaderText = "Kategori"
        Me.jb_category.Name = "jb_category"
        Me.jb_category.ReadOnly = True
        Me.jb_category.Width = 110
        '
        'jb_description
        '
        Me.jb_description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.jb_description.HeaderText = "Beskrivning"
        Me.jb_description.Name = "jb_description"
        Me.jb_description.ReadOnly = True
        Me.jb_description.Width = 195
        '
        'col_JobSelected
        '
        Me.col_JobSelected.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.col_JobSelected.HeaderText = "Utskrift"
        Me.col_JobSelected.Name = "col_JobSelected"
        Me.col_JobSelected.Width = 55
        '
        'btnRemoveJob
        '
        Me.btnRemoveJob.Location = New System.Drawing.Point(656, 77)
        Me.btnRemoveJob.Name = "btnRemoveJob"
        Me.btnRemoveJob.Size = New System.Drawing.Size(76, 23)
        Me.btnRemoveJob.TabIndex = 2
        Me.btnRemoveJob.Text = "R&adera"
        Me.btnRemoveJob.UseVisualStyleBackColor = True
        '
        'btnNewJob
        '
        Me.btnNewJob.Location = New System.Drawing.Point(656, 19)
        Me.btnNewJob.Name = "btnNewJob"
        Me.btnNewJob.Size = New System.Drawing.Size(76, 23)
        Me.btnNewJob.TabIndex = 0
        Me.btnNewJob.Text = "N&ytt..."
        Me.btnNewJob.UseVisualStyleBackColor = True
        '
        'btnEditJob
        '
        Me.btnEditJob.Location = New System.Drawing.Point(656, 48)
        Me.btnEditJob.Name = "btnEditJob"
        Me.btnEditJob.Size = New System.Drawing.Size(76, 23)
        Me.btnEditJob.TabIndex = 1
        Me.btnEditJob.Text = "Visa/än&dra..."
        Me.btnEditJob.UseVisualStyleBackColor = True
        '
        'sbMain
        '
        Me.sbMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sblLeft, Me.pbMain})
        Me.sbMain.Location = New System.Drawing.Point(0, 554)
        Me.sbMain.Name = "sbMain"
        Me.sbMain.Size = New System.Drawing.Size(758, 22)
        Me.sbMain.TabIndex = 3
        '
        'sblLeft
        '
        Me.sblLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.sblLeft.Name = "sblLeft"
        Me.sblLeft.Size = New System.Drawing.Size(0, 17)
        Me.sblLeft.Tag = "sblLeft"
        '
        'pbMain
        '
        Me.pbMain.Name = "pbMain"
        Me.pbMain.Size = New System.Drawing.Size(100, 16)
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(758, 576)
        Me.Controls.Add(Me.sbMain)
        Me.Controls.Add(Me.gbWork)
        Me.Controls.Add(Me.gbCustomer)
        Me.Controls.Add(Me.mnuMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.mnuMain
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StyleFile"
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.gbCustomer.ResumeLayout(False)
        Me.gbCustomer.PerformLayout()
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbWork.ResumeLayout(False)
        CType(Me.dgvJobs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sbMain.ResumeLayout(False)
        Me.sbMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuProgram As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTools As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuStylist As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuShowHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLicense As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gbCustomer As System.Windows.Forms.GroupBox
    Friend WithEvents gbWork As System.Windows.Forms.GroupBox
    Friend WithEvents dgvCustomers As System.Windows.Forms.DataGridView
    Friend WithEvents btnRemoveCustomer As System.Windows.Forms.Button
    Friend WithEvents btnNewCustomer As System.Windows.Forms.Button
    Friend WithEvents btnEditCustomer As System.Windows.Forms.Button
    Friend WithEvents dgvJobs As System.Windows.Forms.DataGridView
    Friend WithEvents btnRemoveJob As System.Windows.Forms.Button
    Friend WithEvents btnNewJob As System.Windows.Forms.Button
    Friend WithEvents btnEditJob As System.Windows.Forms.Button
    Friend WithEvents cboLastName As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkShowAllCustomers As System.Windows.Forms.CheckBox
    Friend WithEvents sbMain As System.Windows.Forms.StatusStrip
    Friend WithEvents sblLeft As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents pbMain As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents cu_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cu_lastname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cu_firstname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cu_category As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cu_telmobile As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cu_city As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mnuCategory As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents mnuReport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtSearchCriteria As System.Windows.Forms.TextBox
    Friend WithEvents cboSearchField As System.Windows.Forms.ComboBox
    Friend WithEvents mnuSettings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuBackup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MostechOnlineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMostechWebSiteURL As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMostechOnFacebook As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnPrintJob As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents jb_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jb_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jb_starttime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jb_stylist As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jb_category As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jb_description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_JobSelected As System.Windows.Forms.DataGridViewCheckBoxColumn

End Class

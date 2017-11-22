<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.colorPicker = New System.Windows.Forms.ColorDialog()
        Me.tcTabs = New System.Windows.Forms.TabControl()
        Me.tpGeneral = New System.Windows.Forms.TabPage()
        Me.cboNrOfJobsPerPrint = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtTelephoneInitialText = New System.Windows.Forms.TextBox()
        Me.chkShowTooltips = New System.Windows.Forms.CheckBox()
        Me.chkDisplayActiveOnly = New System.Windows.Forms.CheckBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnFormBackColor = New System.Windows.Forms.Button()
        Me.btnButtonColor = New System.Windows.Forms.Button()
        Me.btnRequiredFields = New System.Windows.Forms.Button()
        Me.txtFormBackColor = New System.Windows.Forms.TextBox()
        Me.txtButtonColor = New System.Windows.Forms.TextBox()
        Me.chkConfirmAppExit = New System.Windows.Forms.CheckBox()
        Me.txtRequiredFields = New System.Windows.Forms.TextBox()
        Me.tpPassword = New System.Windows.Forms.TabPage()
        Me.chkDontUsePassword = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAppPasswordRepeat = New System.Windows.Forms.TextBox()
        Me.txtAppPassword = New System.Windows.Forms.TextBox()
        Me.tpDatabase = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.txtServer = New System.Windows.Forms.TextBox()
        Me.txtDBPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtDatabase = New System.Windows.Forms.TextBox()
        Me.cboDBTimeOut = New System.Windows.Forms.ComboBox()
        Me.tpMiscSettings = New System.Windows.Forms.TabPage()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnBrowseForHelpFile = New System.Windows.Forms.Button()
        Me.btnBrowseForReportResult = New System.Windows.Forms.Button()
        Me.btnBrowseForJobPrintFolderPath = New System.Windows.Forms.Button()
        Me.btnBrowseForJobImagesRepository = New System.Windows.Forms.Button()
        Me.btnBrowseForJobImagesSource = New System.Windows.Forms.Button()
        Me.btnBrowseForBackupFolderPath = New System.Windows.Forms.Button()
        Me.btnBrowseForBackupScript = New System.Windows.Forms.Button()
        Me.txtHelpFilePath = New System.Windows.Forms.TextBox()
        Me.txtReportResultPath = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtJobPrintFolderPath = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtJobImagesRepositoryPath = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtJobImagesSourcePath = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtBackupFolderPath = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtBackupScriptPath = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tpEmail = New System.Windows.Forms.TabPage()
        Me.chkEmailEnableSSL = New System.Windows.Forms.CheckBox()
        Me.cboEmailTimeout = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtEmailPort = New System.Windows.Forms.TextBox()
        Me.txtEmailServer = New System.Windows.Forms.TextBox()
        Me.txtEmailSender = New System.Windows.Forms.TextBox()
        Me.txtEmailReceiver = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.tcTabs.SuspendLayout()
        Me.tpGeneral.SuspendLayout()
        Me.tpPassword.SuspendLayout()
        Me.tpDatabase.SuspendLayout()
        Me.tpMiscSettings.SuspendLayout()
        Me.tpEmail.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(367, 284)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "&Spara"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(286, 284)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "&Avbryt"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'tcTabs
        '
        Me.tcTabs.Controls.Add(Me.tpGeneral)
        Me.tcTabs.Controls.Add(Me.tpPassword)
        Me.tcTabs.Controls.Add(Me.tpDatabase)
        Me.tcTabs.Controls.Add(Me.tpMiscSettings)
        Me.tcTabs.Controls.Add(Me.tpEmail)
        Me.tcTabs.Location = New System.Drawing.Point(2, 1)
        Me.tcTabs.Name = "tcTabs"
        Me.tcTabs.SelectedIndex = 0
        Me.tcTabs.Size = New System.Drawing.Size(440, 277)
        Me.tcTabs.TabIndex = 1
        '
        'tpGeneral
        '
        Me.tpGeneral.Controls.Add(Me.cboNrOfJobsPerPrint)
        Me.tpGeneral.Controls.Add(Me.Label25)
        Me.tpGeneral.Controls.Add(Me.Label18)
        Me.tpGeneral.Controls.Add(Me.txtTelephoneInitialText)
        Me.tpGeneral.Controls.Add(Me.chkShowTooltips)
        Me.tpGeneral.Controls.Add(Me.chkDisplayActiveOnly)
        Me.tpGeneral.Controls.Add(Me.Label17)
        Me.tpGeneral.Controls.Add(Me.Label16)
        Me.tpGeneral.Controls.Add(Me.Label3)
        Me.tpGeneral.Controls.Add(Me.btnFormBackColor)
        Me.tpGeneral.Controls.Add(Me.btnButtonColor)
        Me.tpGeneral.Controls.Add(Me.btnRequiredFields)
        Me.tpGeneral.Controls.Add(Me.txtFormBackColor)
        Me.tpGeneral.Controls.Add(Me.txtButtonColor)
        Me.tpGeneral.Controls.Add(Me.chkConfirmAppExit)
        Me.tpGeneral.Controls.Add(Me.txtRequiredFields)
        Me.tpGeneral.Location = New System.Drawing.Point(4, 22)
        Me.tpGeneral.Name = "tpGeneral"
        Me.tpGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tpGeneral.Size = New System.Drawing.Size(432, 251)
        Me.tpGeneral.TabIndex = 0
        Me.tpGeneral.Tag = "GENERAL"
        Me.tpGeneral.Text = "Allmänna"
        Me.tpGeneral.UseVisualStyleBackColor = True
        '
        'cboNrOfJobsPerPrint
        '
        Me.cboNrOfJobsPerPrint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNrOfJobsPerPrint.FormattingEnabled = True
        Me.cboNrOfJobsPerPrint.Location = New System.Drawing.Point(203, 117)
        Me.cboNrOfJobsPerPrint.Name = "cboNrOfJobsPerPrint"
        Me.cboNrOfJobsPerPrint.Size = New System.Drawing.Size(135, 21)
        Me.cboNrOfJobsPerPrint.TabIndex = 7
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(7, 117)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(125, 13)
        Me.Label25.TabIndex = 6
        Me.Label25.Text = "Antal arbeten per utskrift:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(7, 91)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(141, 13)
        Me.Label18.TabIndex = 6
        Me.Label18.Text = "Initial text för telefonnummer:"
        '
        'txtTelephoneInitialText
        '
        Me.txtTelephoneInitialText.Location = New System.Drawing.Point(203, 91)
        Me.txtTelephoneInitialText.Name = "txtTelephoneInitialText"
        Me.txtTelephoneInitialText.Size = New System.Drawing.Size(135, 20)
        Me.txtTelephoneInitialText.TabIndex = 5
        '
        'chkShowTooltips
        '
        Me.chkShowTooltips.AutoSize = True
        Me.chkShowTooltips.Location = New System.Drawing.Point(203, 169)
        Me.chkShowTooltips.Name = "chkShowTooltips"
        Me.chkShowTooltips.Size = New System.Drawing.Size(100, 17)
        Me.chkShowTooltips.TabIndex = 4
        Me.chkShowTooltips.Text = "Visa snabbhjälp"
        Me.chkShowTooltips.UseVisualStyleBackColor = True
        '
        'chkDisplayActiveOnly
        '
        Me.chkDisplayActiveOnly.AutoSize = True
        Me.chkDisplayActiveOnly.Location = New System.Drawing.Point(203, 146)
        Me.chkDisplayActiveOnly.Name = "chkDisplayActiveOnly"
        Me.chkDisplayActiveOnly.Size = New System.Drawing.Size(147, 17)
        Me.chkDisplayActiveOnly.TabIndex = 3
        Me.chkDisplayActiveOnly.Text = "Lista endast aktiva poster"
        Me.chkDisplayActiveOnly.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(7, 65)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(136, 13)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "Bakgrundsfärg för knappar:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(7, 36)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(173, 13)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Bakgrundsfärg för obligatoriska fält:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Bakgrundsfärg för formulär:"
        '
        'btnFormBackColor
        '
        Me.btnFormBackColor.Location = New System.Drawing.Point(344, 10)
        Me.btnFormBackColor.Name = "btnFormBackColor"
        Me.btnFormBackColor.Size = New System.Drawing.Size(82, 23)
        Me.btnFormBackColor.TabIndex = 1
        Me.btnFormBackColor.Text = "&Välj färg..."
        Me.btnFormBackColor.UseVisualStyleBackColor = True
        '
        'btnButtonColor
        '
        Me.btnButtonColor.Location = New System.Drawing.Point(344, 65)
        Me.btnButtonColor.Name = "btnButtonColor"
        Me.btnButtonColor.Size = New System.Drawing.Size(82, 23)
        Me.btnButtonColor.TabIndex = 1
        Me.btnButtonColor.Text = "&Välj färg..."
        Me.btnButtonColor.UseVisualStyleBackColor = True
        '
        'btnRequiredFields
        '
        Me.btnRequiredFields.Location = New System.Drawing.Point(344, 36)
        Me.btnRequiredFields.Name = "btnRequiredFields"
        Me.btnRequiredFields.Size = New System.Drawing.Size(82, 23)
        Me.btnRequiredFields.TabIndex = 1
        Me.btnRequiredFields.Text = "&Välj färg..."
        Me.btnRequiredFields.UseVisualStyleBackColor = True
        '
        'txtFormBackColor
        '
        Me.txtFormBackColor.BackColor = System.Drawing.Color.DarkGray
        Me.txtFormBackColor.Location = New System.Drawing.Point(203, 10)
        Me.txtFormBackColor.Name = "txtFormBackColor"
        Me.txtFormBackColor.Size = New System.Drawing.Size(135, 20)
        Me.txtFormBackColor.TabIndex = 0
        Me.txtFormBackColor.TabStop = False
        '
        'txtButtonColor
        '
        Me.txtButtonColor.BackColor = System.Drawing.Color.LawnGreen
        Me.txtButtonColor.Location = New System.Drawing.Point(203, 65)
        Me.txtButtonColor.Name = "txtButtonColor"
        Me.txtButtonColor.Size = New System.Drawing.Size(135, 20)
        Me.txtButtonColor.TabIndex = 0
        Me.txtButtonColor.TabStop = False
        '
        'chkConfirmAppExit
        '
        Me.chkConfirmAppExit.AutoSize = True
        Me.chkConfirmAppExit.Location = New System.Drawing.Point(203, 192)
        Me.chkConfirmAppExit.Name = "chkConfirmAppExit"
        Me.chkConfirmAppExit.Size = New System.Drawing.Size(130, 17)
        Me.chkConfirmAppExit.TabIndex = 2
        Me.chkConfirmAppExit.Text = "Bekräfta nerstängning"
        Me.chkConfirmAppExit.UseVisualStyleBackColor = True
        '
        'txtRequiredFields
        '
        Me.txtRequiredFields.BackColor = System.Drawing.Color.Yellow
        Me.txtRequiredFields.Location = New System.Drawing.Point(203, 36)
        Me.txtRequiredFields.Name = "txtRequiredFields"
        Me.txtRequiredFields.Size = New System.Drawing.Size(135, 20)
        Me.txtRequiredFields.TabIndex = 0
        Me.txtRequiredFields.TabStop = False
        '
        'tpPassword
        '
        Me.tpPassword.Controls.Add(Me.chkDontUsePassword)
        Me.tpPassword.Controls.Add(Me.Label10)
        Me.tpPassword.Controls.Add(Me.Label4)
        Me.tpPassword.Controls.Add(Me.txtAppPasswordRepeat)
        Me.tpPassword.Controls.Add(Me.txtAppPassword)
        Me.tpPassword.Location = New System.Drawing.Point(4, 22)
        Me.tpPassword.Name = "tpPassword"
        Me.tpPassword.Size = New System.Drawing.Size(432, 251)
        Me.tpPassword.TabIndex = 2
        Me.tpPassword.Tag = "PASSWORD"
        Me.tpPassword.Text = "Lösenord"
        Me.tpPassword.UseVisualStyleBackColor = True
        '
        'chkDontUsePassword
        '
        Me.chkDontUsePassword.AutoSize = True
        Me.chkDontUsePassword.Location = New System.Drawing.Point(128, 63)
        Me.chkDontUsePassword.Name = "chkDontUsePassword"
        Me.chkDontUsePassword.Size = New System.Drawing.Size(110, 17)
        Me.chkDontUsePassword.TabIndex = 2
        Me.chkDontUsePassword.Text = "Lösenord ej i bruk"
        Me.chkDontUsePassword.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 13)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Nytt lösenord:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Repetera nytt lösenord:"
        '
        'txtAppPasswordRepeat
        '
        Me.txtAppPasswordRepeat.Location = New System.Drawing.Point(128, 37)
        Me.txtAppPasswordRepeat.Name = "txtAppPasswordRepeat"
        Me.txtAppPasswordRepeat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtAppPasswordRepeat.Size = New System.Drawing.Size(172, 20)
        Me.txtAppPasswordRepeat.TabIndex = 1
        '
        'txtAppPassword
        '
        Me.txtAppPassword.Location = New System.Drawing.Point(128, 13)
        Me.txtAppPassword.Name = "txtAppPassword"
        Me.txtAppPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtAppPassword.Size = New System.Drawing.Size(172, 20)
        Me.txtAppPassword.TabIndex = 0
        '
        'tpDatabase
        '
        Me.tpDatabase.Controls.Add(Me.Label6)
        Me.tpDatabase.Controls.Add(Me.Label5)
        Me.tpDatabase.Controls.Add(Me.Label8)
        Me.tpDatabase.Controls.Add(Me.Label7)
        Me.tpDatabase.Controls.Add(Me.Label1)
        Me.tpDatabase.Controls.Add(Me.Label2)
        Me.tpDatabase.Controls.Add(Me.txtPort)
        Me.tpDatabase.Controls.Add(Me.txtServer)
        Me.tpDatabase.Controls.Add(Me.txtDBPassword)
        Me.tpDatabase.Controls.Add(Me.txtUsername)
        Me.tpDatabase.Controls.Add(Me.txtDatabase)
        Me.tpDatabase.Controls.Add(Me.cboDBTimeOut)
        Me.tpDatabase.Location = New System.Drawing.Point(4, 22)
        Me.tpDatabase.Name = "tpDatabase"
        Me.tpDatabase.Padding = New System.Windows.Forms.Padding(3)
        Me.tpDatabase.Size = New System.Drawing.Size(432, 251)
        Me.tpDatabase.TabIndex = 1
        Me.tpDatabase.Tag = "DATABASE"
        Me.tpDatabase.Text = "Databas"
        Me.tpDatabase.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Port:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Server:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Lösenord:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 84)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Användarnamn:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Databasnamn:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Timeout (sek):"
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(134, 32)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(165, 20)
        Me.txtPort.TabIndex = 1
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(134, 6)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(165, 20)
        Me.txtServer.TabIndex = 0
        '
        'txtDBPassword
        '
        Me.txtDBPassword.Location = New System.Drawing.Point(134, 110)
        Me.txtDBPassword.Name = "txtDBPassword"
        Me.txtDBPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtDBPassword.Size = New System.Drawing.Size(165, 20)
        Me.txtDBPassword.TabIndex = 4
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(134, 84)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(165, 20)
        Me.txtUsername.TabIndex = 3
        '
        'txtDatabase
        '
        Me.txtDatabase.Location = New System.Drawing.Point(134, 58)
        Me.txtDatabase.Name = "txtDatabase"
        Me.txtDatabase.Size = New System.Drawing.Size(165, 20)
        Me.txtDatabase.TabIndex = 2
        '
        'cboDBTimeOut
        '
        Me.cboDBTimeOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDBTimeOut.FormattingEnabled = True
        Me.cboDBTimeOut.Location = New System.Drawing.Point(134, 136)
        Me.cboDBTimeOut.Name = "cboDBTimeOut"
        Me.cboDBTimeOut.Size = New System.Drawing.Size(62, 21)
        Me.cboDBTimeOut.TabIndex = 5
        '
        'tpMiscSettings
        '
        Me.tpMiscSettings.Controls.Add(Me.Label12)
        Me.tpMiscSettings.Controls.Add(Me.btnBrowseForHelpFile)
        Me.tpMiscSettings.Controls.Add(Me.btnBrowseForReportResult)
        Me.tpMiscSettings.Controls.Add(Me.btnBrowseForJobPrintFolderPath)
        Me.tpMiscSettings.Controls.Add(Me.btnBrowseForJobImagesRepository)
        Me.tpMiscSettings.Controls.Add(Me.btnBrowseForJobImagesSource)
        Me.tpMiscSettings.Controls.Add(Me.btnBrowseForBackupFolderPath)
        Me.tpMiscSettings.Controls.Add(Me.btnBrowseForBackupScript)
        Me.tpMiscSettings.Controls.Add(Me.txtHelpFilePath)
        Me.tpMiscSettings.Controls.Add(Me.txtReportResultPath)
        Me.tpMiscSettings.Controls.Add(Me.Label15)
        Me.tpMiscSettings.Controls.Add(Me.txtJobPrintFolderPath)
        Me.tpMiscSettings.Controls.Add(Me.Label19)
        Me.tpMiscSettings.Controls.Add(Me.txtJobImagesRepositoryPath)
        Me.tpMiscSettings.Controls.Add(Me.Label14)
        Me.tpMiscSettings.Controls.Add(Me.txtJobImagesSourcePath)
        Me.tpMiscSettings.Controls.Add(Me.Label13)
        Me.tpMiscSettings.Controls.Add(Me.txtBackupFolderPath)
        Me.tpMiscSettings.Controls.Add(Me.Label9)
        Me.tpMiscSettings.Controls.Add(Me.txtBackupScriptPath)
        Me.tpMiscSettings.Controls.Add(Me.Label11)
        Me.tpMiscSettings.Location = New System.Drawing.Point(4, 22)
        Me.tpMiscSettings.Name = "tpMiscSettings"
        Me.tpMiscSettings.Size = New System.Drawing.Size(432, 251)
        Me.tpMiscSettings.TabIndex = 3
        Me.tpMiscSettings.Tag = "SPECIAL"
        Me.tpMiscSettings.Text = "Special"
        Me.tpMiscSettings.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 7)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 13)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Hjälpsida:"
        '
        'btnBrowseForHelpFile
        '
        Me.btnBrowseForHelpFile.Location = New System.Drawing.Point(398, 8)
        Me.btnBrowseForHelpFile.Name = "btnBrowseForHelpFile"
        Me.btnBrowseForHelpFile.Size = New System.Drawing.Size(29, 19)
        Me.btnBrowseForHelpFile.TabIndex = 1
        Me.btnBrowseForHelpFile.Text = "..."
        Me.btnBrowseForHelpFile.UseVisualStyleBackColor = True
        '
        'btnBrowseForReportResult
        '
        Me.btnBrowseForReportResult.Location = New System.Drawing.Point(398, 159)
        Me.btnBrowseForReportResult.Name = "btnBrowseForReportResult"
        Me.btnBrowseForReportResult.Size = New System.Drawing.Size(29, 20)
        Me.btnBrowseForReportResult.TabIndex = 9
        Me.btnBrowseForReportResult.Text = "..."
        Me.btnBrowseForReportResult.UseVisualStyleBackColor = True
        '
        'btnBrowseForJobPrintFolderPath
        '
        Me.btnBrowseForJobPrintFolderPath.Location = New System.Drawing.Point(398, 133)
        Me.btnBrowseForJobPrintFolderPath.Name = "btnBrowseForJobPrintFolderPath"
        Me.btnBrowseForJobPrintFolderPath.Size = New System.Drawing.Size(29, 20)
        Me.btnBrowseForJobPrintFolderPath.TabIndex = 7
        Me.btnBrowseForJobPrintFolderPath.Text = "..."
        Me.btnBrowseForJobPrintFolderPath.UseVisualStyleBackColor = True
        '
        'btnBrowseForJobImagesRepository
        '
        Me.btnBrowseForJobImagesRepository.Location = New System.Drawing.Point(398, 107)
        Me.btnBrowseForJobImagesRepository.Name = "btnBrowseForJobImagesRepository"
        Me.btnBrowseForJobImagesRepository.Size = New System.Drawing.Size(29, 20)
        Me.btnBrowseForJobImagesRepository.TabIndex = 7
        Me.btnBrowseForJobImagesRepository.Text = "..."
        Me.btnBrowseForJobImagesRepository.UseVisualStyleBackColor = True
        '
        'btnBrowseForJobImagesSource
        '
        Me.btnBrowseForJobImagesSource.Location = New System.Drawing.Point(398, 83)
        Me.btnBrowseForJobImagesSource.Name = "btnBrowseForJobImagesSource"
        Me.btnBrowseForJobImagesSource.Size = New System.Drawing.Size(29, 20)
        Me.btnBrowseForJobImagesSource.TabIndex = 5
        Me.btnBrowseForJobImagesSource.Text = "..."
        Me.btnBrowseForJobImagesSource.UseVisualStyleBackColor = True
        '
        'btnBrowseForBackupFolderPath
        '
        Me.btnBrowseForBackupFolderPath.Location = New System.Drawing.Point(398, 57)
        Me.btnBrowseForBackupFolderPath.Name = "btnBrowseForBackupFolderPath"
        Me.btnBrowseForBackupFolderPath.Size = New System.Drawing.Size(29, 20)
        Me.btnBrowseForBackupFolderPath.TabIndex = 3
        Me.btnBrowseForBackupFolderPath.Text = "..."
        Me.btnBrowseForBackupFolderPath.UseVisualStyleBackColor = True
        '
        'btnBrowseForBackupScript
        '
        Me.btnBrowseForBackupScript.Location = New System.Drawing.Point(398, 31)
        Me.btnBrowseForBackupScript.Name = "btnBrowseForBackupScript"
        Me.btnBrowseForBackupScript.Size = New System.Drawing.Size(29, 20)
        Me.btnBrowseForBackupScript.TabIndex = 3
        Me.btnBrowseForBackupScript.Text = "..."
        Me.btnBrowseForBackupScript.UseVisualStyleBackColor = True
        '
        'txtHelpFilePath
        '
        Me.txtHelpFilePath.Location = New System.Drawing.Point(115, 7)
        Me.txtHelpFilePath.Name = "txtHelpFilePath"
        Me.txtHelpFilePath.Size = New System.Drawing.Size(277, 20)
        Me.txtHelpFilePath.TabIndex = 0
        '
        'txtReportResultPath
        '
        Me.txtReportResultPath.Location = New System.Drawing.Point(115, 158)
        Me.txtReportResultPath.Name = "txtReportResultPath"
        Me.txtReportResultPath.Size = New System.Drawing.Size(277, 20)
        Me.txtReportResultPath.TabIndex = 8
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 158)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(94, 13)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Rapporter, lagring:"
        '
        'txtJobPrintFolderPath
        '
        Me.txtJobPrintFolderPath.Location = New System.Drawing.Point(115, 132)
        Me.txtJobPrintFolderPath.Name = "txtJobPrintFolderPath"
        Me.txtJobPrintFolderPath.Size = New System.Drawing.Size(277, 20)
        Me.txtJobPrintFolderPath.TabIndex = 6
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 132)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(70, 13)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Jobb, utskrift:"
        '
        'txtJobImagesRepositoryPath
        '
        Me.txtJobImagesRepositoryPath.Location = New System.Drawing.Point(115, 106)
        Me.txtJobImagesRepositoryPath.Name = "txtJobImagesRepositoryPath"
        Me.txtJobImagesRepositoryPath.Size = New System.Drawing.Size(277, 20)
        Me.txtJobImagesRepositoryPath.TabIndex = 6
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 106)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(98, 13)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Jobb-bilder, lagring:"
        '
        'txtJobImagesSourcePath
        '
        Me.txtJobImagesSourcePath.Location = New System.Drawing.Point(115, 82)
        Me.txtJobImagesSourcePath.Name = "txtJobImagesSourcePath"
        Me.txtJobImagesSourcePath.Size = New System.Drawing.Size(277, 20)
        Me.txtJobImagesSourcePath.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 82)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Jobb-bilder, in:"
        '
        'txtBackupFolderPath
        '
        Me.txtBackupFolderPath.Location = New System.Drawing.Point(115, 56)
        Me.txtBackupFolderPath.Name = "txtBackupFolderPath"
        Me.txtBackupFolderPath.Size = New System.Drawing.Size(277, 20)
        Me.txtBackupFolderPath.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Backup-katalog:"
        '
        'txtBackupScriptPath
        '
        Me.txtBackupScriptPath.Location = New System.Drawing.Point(115, 30)
        Me.txtBackupScriptPath.Name = "txtBackupScriptPath"
        Me.txtBackupScriptPath.Size = New System.Drawing.Size(277, 20)
        Me.txtBackupScriptPath.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 30)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Backup-script:"
        '
        'tpEmail
        '
        Me.tpEmail.Controls.Add(Me.chkEmailEnableSSL)
        Me.tpEmail.Controls.Add(Me.cboEmailTimeout)
        Me.tpEmail.Controls.Add(Me.Label24)
        Me.tpEmail.Controls.Add(Me.Label23)
        Me.tpEmail.Controls.Add(Me.Label22)
        Me.tpEmail.Controls.Add(Me.Label21)
        Me.tpEmail.Controls.Add(Me.txtEmailPort)
        Me.tpEmail.Controls.Add(Me.txtEmailServer)
        Me.tpEmail.Controls.Add(Me.txtEmailSender)
        Me.tpEmail.Controls.Add(Me.txtEmailReceiver)
        Me.tpEmail.Controls.Add(Me.Label20)
        Me.tpEmail.Location = New System.Drawing.Point(4, 22)
        Me.tpEmail.Name = "tpEmail"
        Me.tpEmail.Padding = New System.Windows.Forms.Padding(3)
        Me.tpEmail.Size = New System.Drawing.Size(432, 251)
        Me.tpEmail.TabIndex = 4
        Me.tpEmail.Tag = "EMAIL"
        Me.tpEmail.Text = "E-post"
        Me.tpEmail.UseVisualStyleBackColor = True
        '
        'chkEmailEnableSSL
        '
        Me.chkEmailEnableSSL.AutoSize = True
        Me.chkEmailEnableSSL.Location = New System.Drawing.Point(144, 142)
        Me.chkEmailEnableSSL.Name = "chkEmailEnableSSL"
        Me.chkEmailEnableSSL.Size = New System.Drawing.Size(88, 17)
        Me.chkEmailEnableSSL.TabIndex = 4
        Me.chkEmailEnableSSL.Text = "Aktivera SSL"
        Me.chkEmailEnableSSL.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkEmailEnableSSL.UseVisualStyleBackColor = True
        '
        'cboEmailTimeout
        '
        Me.cboEmailTimeout.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmailTimeout.FormattingEnabled = True
        Me.cboEmailTimeout.Location = New System.Drawing.Point(144, 115)
        Me.cboEmailTimeout.Name = "cboEmailTimeout"
        Me.cboEmailTimeout.Size = New System.Drawing.Size(138, 21)
        Me.cboEmailTimeout.TabIndex = 3
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(6, 112)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(74, 13)
        Me.Label24.TabIndex = 2
        Me.Label24.Text = "Timeout (sek):"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(6, 85)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(66, 13)
        Me.Label23.TabIndex = 2
        Me.Label23.Text = "Portnummer:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(6, 62)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(67, 13)
        Me.Label22.TabIndex = 2
        Me.Label22.Text = "Servernamn:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 36)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(100, 13)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "Sändare (standard):"
        '
        'txtEmailPort
        '
        Me.txtEmailPort.Location = New System.Drawing.Point(144, 89)
        Me.txtEmailPort.Name = "txtEmailPort"
        Me.txtEmailPort.Size = New System.Drawing.Size(138, 20)
        Me.txtEmailPort.TabIndex = 1
        '
        'txtEmailServer
        '
        Me.txtEmailServer.Location = New System.Drawing.Point(144, 62)
        Me.txtEmailServer.Name = "txtEmailServer"
        Me.txtEmailServer.Size = New System.Drawing.Size(282, 20)
        Me.txtEmailServer.TabIndex = 1
        '
        'txtEmailSender
        '
        Me.txtEmailSender.Location = New System.Drawing.Point(144, 36)
        Me.txtEmailSender.Name = "txtEmailSender"
        Me.txtEmailSender.Size = New System.Drawing.Size(282, 20)
        Me.txtEmailSender.TabIndex = 1
        '
        'txtEmailReceiver
        '
        Me.txtEmailReceiver.Location = New System.Drawing.Point(144, 10)
        Me.txtEmailReceiver.Name = "txtEmailReceiver"
        Me.txtEmailReceiver.Size = New System.Drawing.Size(282, 20)
        Me.txtEmailReceiver.TabIndex = 1
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 10)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(108, 13)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Mottagare (standard):"
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 310)
        Me.Controls.Add(Me.tcTabs)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettings"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Inställningar"
        Me.tcTabs.ResumeLayout(False)
        Me.tpGeneral.ResumeLayout(False)
        Me.tpGeneral.PerformLayout()
        Me.tpPassword.ResumeLayout(False)
        Me.tpPassword.PerformLayout()
        Me.tpDatabase.ResumeLayout(False)
        Me.tpDatabase.PerformLayout()
        Me.tpMiscSettings.ResumeLayout(False)
        Me.tpMiscSettings.PerformLayout()
        Me.tpEmail.ResumeLayout(False)
        Me.tpEmail.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents colorPicker As System.Windows.Forms.ColorDialog
    Friend WithEvents tcTabs As System.Windows.Forms.TabControl
    Friend WithEvents tpGeneral As System.Windows.Forms.TabPage
    Friend WithEvents chkDisplayActiveOnly As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnRequiredFields As System.Windows.Forms.Button
    Friend WithEvents chkConfirmAppExit As System.Windows.Forms.CheckBox
    Friend WithEvents txtRequiredFields As System.Windows.Forms.TextBox
    Friend WithEvents tpDatabase As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDatabase As System.Windows.Forms.TextBox
    Friend WithEvents cboDBTimeOut As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPort As System.Windows.Forms.TextBox
    Friend WithEvents txtServer As System.Windows.Forms.TextBox
    Friend WithEvents txtDBPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents tpPassword As System.Windows.Forms.TabPage
    Friend WithEvents txtAppPasswordRepeat As System.Windows.Forms.TextBox
    Friend WithEvents txtAppPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tpMiscSettings As System.Windows.Forms.TabPage
    Friend WithEvents btnBrowseForBackupScript As System.Windows.Forms.Button
    Friend WithEvents txtBackupScriptPath As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnBrowseForHelpFile As System.Windows.Forms.Button
    Friend WithEvents txtHelpFilePath As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowseForJobImagesRepository As System.Windows.Forms.Button
    Friend WithEvents btnBrowseForJobImagesSource As System.Windows.Forms.Button
    Friend WithEvents txtJobImagesRepositoryPath As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtJobImagesSourcePath As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnBrowseForReportResult As System.Windows.Forms.Button
    Friend WithEvents txtReportResultPath As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents chkDontUsePassword As System.Windows.Forms.CheckBox
    Friend WithEvents chkShowTooltips As System.Windows.Forms.CheckBox
    Friend WithEvents btnBrowseForBackupFolderPath As System.Windows.Forms.Button
    Friend WithEvents txtBackupFolderPath As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btnFormBackColor As System.Windows.Forms.Button
    Friend WithEvents txtFormBackColor As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents btnButtonColor As System.Windows.Forms.Button
    Friend WithEvents txtButtonColor As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtTelephoneInitialText As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowseForJobPrintFolderPath As System.Windows.Forms.Button
    Friend WithEvents txtJobPrintFolderPath As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents tpEmail As System.Windows.Forms.TabPage
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtEmailSender As System.Windows.Forms.TextBox
    Friend WithEvents txtEmailReceiver As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtEmailServer As System.Windows.Forms.TextBox
    Friend WithEvents chkEmailEnableSSL As System.Windows.Forms.CheckBox
    Friend WithEvents cboEmailTimeout As System.Windows.Forms.ComboBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtEmailPort As System.Windows.Forms.TextBox
    Friend WithEvents cboNrOfJobsPerPrint As System.Windows.Forms.ComboBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
End Class

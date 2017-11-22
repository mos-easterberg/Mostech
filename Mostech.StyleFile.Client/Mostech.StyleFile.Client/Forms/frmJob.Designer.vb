<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJob
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmJob))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtEdited = New System.Windows.Forms.TextBox()
        Me.txtCreated = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cboCategory = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboStartHour = New System.Windows.Forms.ComboBox()
        Me.cboEndMinute = New System.Windows.Forms.ComboBox()
        Me.cboEndHour = New System.Windows.Forms.ComboBox()
        Me.cboStartMinute = New System.Windows.Forms.ComboBox()
        Me.txtJobDuration = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtJobDate = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cboStylist = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.gbJobDescription = New System.Windows.Forms.GroupBox()
        Me.txtJobDescription = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtPriceExclVAT = New System.Windows.Forms.TextBox()
        Me.mtxtPriceInclVAT = New System.Windows.Forms.MaskedTextBox()
        Me.cboVAT = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.gbImage = New System.Windows.Forms.GroupBox()
        Me.lblChooseImage = New System.Windows.Forms.Label()
        Me.cboImages = New System.Windows.Forms.ComboBox()
        Me.btnAddImage = New System.Windows.Forms.Button()
        Me.btnOpenImageExternally = New System.Windows.Forms.Button()
        Me.btnRemoveImage = New System.Windows.Forms.Button()
        Me.pbImage = New System.Windows.Forms.PictureBox()
        Me.btnPrintJob = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.gbJobDescription.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.gbImage.SuspendLayout()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtEdited)
        Me.GroupBox1.Controls.Add(Me.txtCreated)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(307, 97)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Automatiska uppgifter"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 66)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 13)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Ändrat:"
        '
        'txtEdited
        '
        Me.txtEdited.Location = New System.Drawing.Point(96, 66)
        Me.txtEdited.Name = "txtEdited"
        Me.txtEdited.ReadOnly = True
        Me.txtEdited.Size = New System.Drawing.Size(204, 20)
        Me.txtEdited.TabIndex = 12
        Me.txtEdited.TabStop = False
        '
        'txtCreated
        '
        Me.txtCreated.Location = New System.Drawing.Point(96, 44)
        Me.txtCreated.Name = "txtCreated"
        Me.txtCreated.ReadOnly = True
        Me.txtCreated.Size = New System.Drawing.Size(204, 20)
        Me.txtCreated.TabIndex = 11
        Me.txtCreated.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 44)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 13)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Skapat:"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(96, 19)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(205, 20)
        Me.txtID.TabIndex = 0
        Me.txtID.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Arbetsnummer:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cboCategory)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 150)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(307, 45)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Kategorisering"
        '
        'cboCategory
        '
        Me.cboCategory.BackColor = System.Drawing.SystemColors.Window
        Me.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.Location = New System.Drawing.Point(95, 19)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(204, 21)
        Me.cboCategory.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Arbetskategori:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboStartHour)
        Me.GroupBox2.Controls.Add(Me.cboEndMinute)
        Me.GroupBox2.Controls.Add(Me.cboEndHour)
        Me.GroupBox2.Controls.Add(Me.cboStartMinute)
        Me.GroupBox2.Controls.Add(Me.txtJobDuration)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.dtJobDate)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 201)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(307, 125)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datum, tid"
        '
        'cboStartHour
        '
        Me.cboStartHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStartHour.FormattingEnabled = True
        Me.cboStartHour.Location = New System.Drawing.Point(94, 45)
        Me.cboStartHour.Name = "cboStartHour"
        Me.cboStartHour.Size = New System.Drawing.Size(41, 21)
        Me.cboStartHour.TabIndex = 1
        '
        'cboEndMinute
        '
        Me.cboEndMinute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEndMinute.FormattingEnabled = True
        Me.cboEndMinute.Location = New System.Drawing.Point(132, 71)
        Me.cboEndMinute.Name = "cboEndMinute"
        Me.cboEndMinute.Size = New System.Drawing.Size(41, 21)
        Me.cboEndMinute.TabIndex = 4
        '
        'cboEndHour
        '
        Me.cboEndHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEndHour.FormattingEnabled = True
        Me.cboEndHour.Location = New System.Drawing.Point(94, 71)
        Me.cboEndHour.Name = "cboEndHour"
        Me.cboEndHour.Size = New System.Drawing.Size(41, 21)
        Me.cboEndHour.TabIndex = 3
        '
        'cboStartMinute
        '
        Me.cboStartMinute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStartMinute.FormattingEnabled = True
        Me.cboStartMinute.Location = New System.Drawing.Point(132, 45)
        Me.cboStartMinute.Name = "cboStartMinute"
        Me.cboStartMinute.Size = New System.Drawing.Size(41, 21)
        Me.cboStartMinute.TabIndex = 2
        '
        'txtJobDuration
        '
        Me.txtJobDuration.Location = New System.Drawing.Point(95, 97)
        Me.txtJobDuration.Name = "txtJobDuration"
        Me.txtJobDuration.ReadOnly = True
        Me.txtJobDuration.Size = New System.Drawing.Size(204, 20)
        Me.txtJobDuration.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Längd (min):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Sluttid:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Starttid:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Datum:"
        '
        'dtJobDate
        '
        Me.dtJobDate.CalendarMonthBackground = System.Drawing.Color.Yellow
        Me.dtJobDate.CustomFormat = "dd.mm.yyyy"
        Me.dtJobDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtJobDate.Location = New System.Drawing.Point(95, 19)
        Me.dtJobDate.Name = "dtJobDate"
        Me.dtJobDate.Size = New System.Drawing.Size(204, 20)
        Me.dtJobDate.TabIndex = 0
        Me.dtJobDate.Value = New Date(2011, 11, 15, 0, 0, 0, 0)
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cboStylist)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Location = New System.Drawing.Point(3, 332)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(307, 44)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Stylist"
        '
        'cboStylist
        '
        Me.cboStylist.BackColor = System.Drawing.SystemColors.Window
        Me.cboStylist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStylist.FormattingEnabled = True
        Me.cboStylist.Location = New System.Drawing.Point(96, 13)
        Me.cboStylist.Name = "cboStylist"
        Me.cboStylist.Size = New System.Drawing.Size(202, 21)
        Me.cboStylist.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Namn:"
        '
        'gbJobDescription
        '
        Me.gbJobDescription.Controls.Add(Me.txtJobDescription)
        Me.gbJobDescription.Location = New System.Drawing.Point(316, 2)
        Me.gbJobDescription.Name = "gbJobDescription"
        Me.gbJobDescription.Size = New System.Drawing.Size(307, 141)
        Me.gbJobDescription.TabIndex = 4
        Me.gbJobDescription.TabStop = False
        Me.gbJobDescription.Text = "Beskrivning"
        '
        'txtJobDescription
        '
        Me.txtJobDescription.Location = New System.Drawing.Point(10, 19)
        Me.txtJobDescription.Multiline = True
        Me.txtJobDescription.Name = "txtJobDescription"
        Me.txtJobDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtJobDescription.Size = New System.Drawing.Size(289, 112)
        Me.txtJobDescription.TabIndex = 0
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtPriceExclVAT)
        Me.GroupBox6.Controls.Add(Me.mtxtPriceInclVAT)
        Me.GroupBox6.Controls.Add(Me.cboVAT)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Location = New System.Drawing.Point(4, 382)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(307, 88)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Pris"
        '
        'txtPriceExclVAT
        '
        Me.txtPriceExclVAT.Location = New System.Drawing.Point(96, 63)
        Me.txtPriceExclVAT.Name = "txtPriceExclVAT"
        Me.txtPriceExclVAT.ReadOnly = True
        Me.txtPriceExclVAT.Size = New System.Drawing.Size(204, 20)
        Me.txtPriceExclVAT.TabIndex = 2
        '
        'mtxtPriceInclVAT
        '
        Me.mtxtPriceInclVAT.Location = New System.Drawing.Point(97, 9)
        Me.mtxtPriceInclVAT.Name = "mtxtPriceInclVAT"
        Me.mtxtPriceInclVAT.Size = New System.Drawing.Size(202, 20)
        Me.mtxtPriceInclVAT.TabIndex = 0
        '
        'cboVAT
        '
        Me.cboVAT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVAT.FormattingEnabled = True
        Me.cboVAT.Location = New System.Drawing.Point(97, 35)
        Me.cboVAT.Name = "cboVAT"
        Me.cboVAT.Size = New System.Drawing.Size(204, 21)
        Me.cboVAT.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Moms-%:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Pris (exkl. moms):"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Pris (inkl. moms):"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(466, 447)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "&Avbryt"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(547, 447)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "&Spara"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'gbImage
        '
        Me.gbImage.Controls.Add(Me.lblChooseImage)
        Me.gbImage.Controls.Add(Me.cboImages)
        Me.gbImage.Controls.Add(Me.btnAddImage)
        Me.gbImage.Controls.Add(Me.btnOpenImageExternally)
        Me.gbImage.Controls.Add(Me.btnRemoveImage)
        Me.gbImage.Controls.Add(Me.pbImage)
        Me.gbImage.Location = New System.Drawing.Point(315, 150)
        Me.gbImage.Name = "gbImage"
        Me.gbImage.Size = New System.Drawing.Size(307, 269)
        Me.gbImage.TabIndex = 5
        Me.gbImage.TabStop = False
        Me.gbImage.Text = "Bilder"
        '
        'lblChooseImage
        '
        Me.lblChooseImage.AutoSize = True
        Me.lblChooseImage.Location = New System.Drawing.Point(6, 211)
        Me.lblChooseImage.Name = "lblChooseImage"
        Me.lblChooseImage.Size = New System.Drawing.Size(46, 13)
        Me.lblChooseImage.TabIndex = 0
        Me.lblChooseImage.Text = "Välj bild:"
        '
        'cboImages
        '
        Me.cboImages.BackColor = System.Drawing.SystemColors.Window
        Me.cboImages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboImages.FormattingEnabled = True
        Me.cboImages.Location = New System.Drawing.Point(58, 211)
        Me.cboImages.Name = "cboImages"
        Me.cboImages.Size = New System.Drawing.Size(241, 21)
        Me.cboImages.TabIndex = 0
        '
        'btnAddImage
        '
        Me.btnAddImage.Location = New System.Drawing.Point(6, 238)
        Me.btnAddImage.Name = "btnAddImage"
        Me.btnAddImage.Size = New System.Drawing.Size(75, 23)
        Me.btnAddImage.TabIndex = 1
        Me.btnAddImage.Text = "&Lägg till..."
        Me.btnAddImage.UseVisualStyleBackColor = True
        '
        'btnOpenImageExternally
        '
        Me.btnOpenImageExternally.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnOpenImageExternally.Location = New System.Drawing.Point(168, 239)
        Me.btnOpenImageExternally.Name = "btnOpenImageExternally"
        Me.btnOpenImageExternally.Size = New System.Drawing.Size(131, 23)
        Me.btnOpenImageExternally.TabIndex = 3
        Me.btnOpenImageExternally.Text = "&Öppna i externt program"
        Me.btnOpenImageExternally.UseVisualStyleBackColor = True
        '
        'btnRemoveImage
        '
        Me.btnRemoveImage.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnRemoveImage.Location = New System.Drawing.Point(87, 239)
        Me.btnRemoveImage.Name = "btnRemoveImage"
        Me.btnRemoveImage.Size = New System.Drawing.Size(75, 23)
        Me.btnRemoveImage.TabIndex = 2
        Me.btnRemoveImage.Text = "&Radera"
        Me.btnRemoveImage.UseVisualStyleBackColor = True
        '
        'pbImage
        '
        Me.pbImage.Location = New System.Drawing.Point(6, 16)
        Me.pbImage.Name = "pbImage"
        Me.pbImage.Size = New System.Drawing.Size(293, 189)
        Me.pbImage.TabIndex = 0
        Me.pbImage.TabStop = False
        '
        'btnPrintJob
        '
        Me.btnPrintJob.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnPrintJob.Location = New System.Drawing.Point(385, 447)
        Me.btnPrintJob.Name = "btnPrintJob"
        Me.btnPrintJob.Size = New System.Drawing.Size(75, 23)
        Me.btnPrintJob.TabIndex = 6
        Me.btnPrintJob.Text = "&Skriv ut..."
        Me.btnPrintJob.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lblCustomerName)
        Me.GroupBox5.Location = New System.Drawing.Point(4, 104)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(307, 39)
        Me.GroupBox5.TabIndex = 26
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Kund"
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerName.Location = New System.Drawing.Point(5, 16)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(283, 13)
        Me.lblCustomerName.TabIndex = 0
        Me.lblCustomerName.Text = "Kundnaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaamn"
        '
        'frmJob
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(627, 474)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.btnPrintJob)
        Me.Controls.Add(Me.gbImage)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.gbJobDescription)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmJob"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Arbete"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.gbJobDescription.ResumeLayout(False)
        Me.gbJobDescription.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.gbImage.ResumeLayout(False)
        Me.gbImage.PerformLayout()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cboCategory As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtJobDuration As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtJobDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents gbJobDescription As System.Windows.Forms.GroupBox
    Friend WithEvents txtJobDescription As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents cboVAT As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents mtxtPriceInclVAT As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtPriceExclVAT As System.Windows.Forms.TextBox
    Friend WithEvents cboStylist As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtEdited As System.Windows.Forms.TextBox
    Friend WithEvents txtCreated As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cboEndMinute As System.Windows.Forms.ComboBox
    Friend WithEvents cboEndHour As System.Windows.Forms.ComboBox
    Friend WithEvents cboStartMinute As System.Windows.Forms.ComboBox
    Friend WithEvents cboStartHour As System.Windows.Forms.ComboBox
    Friend WithEvents gbImage As System.Windows.Forms.GroupBox
    Friend WithEvents btnOpenImageExternally As System.Windows.Forms.Button
    Friend WithEvents btnRemoveImage As System.Windows.Forms.Button
    Friend WithEvents pbImage As System.Windows.Forms.PictureBox
    Friend WithEvents btnAddImage As System.Windows.Forms.Button
    Friend WithEvents lblChooseImage As System.Windows.Forms.Label
    Friend WithEvents cboImages As System.Windows.Forms.ComboBox
    Friend WithEvents btnPrintJob As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents lblCustomerName As System.Windows.Forms.Label
End Class

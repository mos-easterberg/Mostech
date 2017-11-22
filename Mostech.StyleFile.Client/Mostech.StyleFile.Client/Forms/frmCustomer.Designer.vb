<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomer))
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTelephoneWork = New System.Windows.Forms.TextBox()
        Me.gbName = New System.Windows.Forms.GroupBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEmailAddress = New System.Windows.Forms.TextBox()
        Me.txtTelephoneHome = New System.Windows.Forms.TextBox()
        Me.txtTelephoneMobile = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gbMiscInfo = New System.Windows.Forms.GroupBox()
        Me.txtMiscInfo = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPostalCode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtEdited = New System.Windows.Forms.TextBox()
        Me.txtCreated = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cboCategory = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gbAllergy = New System.Windows.Forms.GroupBox()
        Me.txtAllergy = New System.Windows.Forms.TextBox()
        Me.chkActive = New System.Windows.Forms.CheckBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.chkMail = New System.Windows.Forms.CheckBox()
        Me.chkEmail = New System.Windows.Forms.CheckBox()
        Me.chkSMS = New System.Windows.Forms.CheckBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cboDOBYear = New System.Windows.Forms.ComboBox()
        Me.cboDOBMonth = New System.Windows.Forms.ComboBox()
        Me.cboDOBDay = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.cboDistrict = New System.Windows.Forms.ComboBox()
        Me.gbName.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.gbMiscInfo.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.gbAllergy.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Telefon, jobb:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 87)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "E-post:"
        '
        'txtTelephoneWork
        '
        Me.txtTelephoneWork.Location = New System.Drawing.Point(96, 64)
        Me.txtTelephoneWork.Name = "txtTelephoneWork"
        Me.txtTelephoneWork.Size = New System.Drawing.Size(202, 20)
        Me.txtTelephoneWork.TabIndex = 2
        '
        'gbName
        '
        Me.gbName.Controls.Add(Me.txtFirstName)
        Me.gbName.Controls.Add(Me.lblFirstName)
        Me.gbName.Controls.Add(Me.txtLastName)
        Me.gbName.Controls.Add(Me.lblLastName)
        Me.gbName.Location = New System.Drawing.Point(2, 152)
        Me.gbName.Name = "gbName"
        Me.gbName.Size = New System.Drawing.Size(308, 64)
        Me.gbName.TabIndex = 1
        Me.gbName.TabStop = False
        Me.gbName.Text = "Namn"
        '
        'txtFirstName
        '
        Me.txtFirstName.BackColor = System.Drawing.Color.Yellow
        Me.txtFirstName.Location = New System.Drawing.Point(96, 38)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(202, 20)
        Me.txtFirstName.TabIndex = 1
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(7, 38)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(51, 13)
        Me.lblFirstName.TabIndex = 2
        Me.lblFirstName.Text = "Förnamn:"
        '
        'txtLastName
        '
        Me.txtLastName.BackColor = System.Drawing.Color.Yellow
        Me.txtLastName.Location = New System.Drawing.Point(96, 15)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(202, 20)
        Me.txtLastName.TabIndex = 0
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(6, 15)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(58, 13)
        Me.lblLastName.TabIndex = 5
        Me.lblLastName.Text = "Efternamn:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.txtTelephoneWork)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.txtEmailAddress)
        Me.GroupBox4.Controls.Add(Me.txtTelephoneHome)
        Me.GroupBox4.Controls.Add(Me.txtTelephoneMobile)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Location = New System.Drawing.Point(3, 391)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(308, 111)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Kontakt"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Telefon, hem:"
        '
        'txtEmailAddress
        '
        Me.txtEmailAddress.Location = New System.Drawing.Point(96, 87)
        Me.txtEmailAddress.Name = "txtEmailAddress"
        Me.txtEmailAddress.Size = New System.Drawing.Size(202, 20)
        Me.txtEmailAddress.TabIndex = 3
        '
        'txtTelephoneHome
        '
        Me.txtTelephoneHome.Location = New System.Drawing.Point(96, 42)
        Me.txtTelephoneHome.Name = "txtTelephoneHome"
        Me.txtTelephoneHome.Size = New System.Drawing.Size(202, 20)
        Me.txtTelephoneHome.TabIndex = 1
        '
        'txtTelephoneMobile
        '
        Me.txtTelephoneMobile.BackColor = System.Drawing.Color.White
        Me.txtTelephoneMobile.Location = New System.Drawing.Point(96, 19)
        Me.txtTelephoneMobile.Name = "txtTelephoneMobile"
        Me.txtTelephoneMobile.Size = New System.Drawing.Size(202, 20)
        Me.txtTelephoneMobile.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Telefon, mobil:"
        '
        'gbMiscInfo
        '
        Me.gbMiscInfo.Controls.Add(Me.txtMiscInfo)
        Me.gbMiscInfo.Location = New System.Drawing.Point(325, 152)
        Me.gbMiscInfo.Name = "gbMiscInfo"
        Me.gbMiscInfo.Size = New System.Drawing.Size(308, 350)
        Me.gbMiscInfo.TabIndex = 7
        Me.gbMiscInfo.TabStop = False
        Me.gbMiscInfo.Text = "Annat"
        '
        'txtMiscInfo
        '
        Me.txtMiscInfo.Location = New System.Drawing.Point(9, 17)
        Me.txtMiscInfo.Multiline = True
        Me.txtMiscInfo.Name = "txtMiscInfo"
        Me.txtMiscInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMiscInfo.Size = New System.Drawing.Size(289, 327)
        Me.txtMiscInfo.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboDistrict)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtAddress)
        Me.GroupBox2.Controls.Add(Me.txtCity)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtPostalCode)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(2, 269)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(308, 116)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Address"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 41)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 13)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Stadsdel:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Ort:"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(96, 19)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(202, 20)
        Me.txtAddress.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Address:"
        '
        'txtPostalCode
        '
        Me.txtPostalCode.Location = New System.Drawing.Point(201, 64)
        Me.txtPostalCode.Name = "txtPostalCode"
        Me.txtPostalCode.Size = New System.Drawing.Size(97, 20)
        Me.txtPostalCode.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Postnr:"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(477, 532)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "&Avbryt"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(558, 532)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "&Spara"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtEdited)
        Me.GroupBox1.Controls.Add(Me.txtCreated)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(307, 92)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Automatiska uppgifter"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 65)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Ändrad:"
        '
        'txtEdited
        '
        Me.txtEdited.Location = New System.Drawing.Point(96, 65)
        Me.txtEdited.Name = "txtEdited"
        Me.txtEdited.ReadOnly = True
        Me.txtEdited.Size = New System.Drawing.Size(204, 20)
        Me.txtEdited.TabIndex = 2
        Me.txtEdited.TabStop = False
        '
        'txtCreated
        '
        Me.txtCreated.Location = New System.Drawing.Point(96, 43)
        Me.txtCreated.Name = "txtCreated"
        Me.txtCreated.ReadOnly = True
        Me.txtCreated.Size = New System.Drawing.Size(204, 20)
        Me.txtCreated.TabIndex = 1
        Me.txtCreated.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 43)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 13)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Skapad:"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(96, 19)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(203, 20)
        Me.txtID.TabIndex = 1
        Me.txtID.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Kundnummer:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cboCategory)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 101)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(307, 45)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Kategorisering"
        '
        'cboCategory
        '
        Me.cboCategory.BackColor = System.Drawing.Color.White
        Me.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.Location = New System.Drawing.Point(95, 19)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(200, 21)
        Me.cboCategory.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Kundkategori:"
        '
        'gbAllergy
        '
        Me.gbAllergy.Controls.Add(Me.txtAllergy)
        Me.gbAllergy.Location = New System.Drawing.Point(325, 3)
        Me.gbAllergy.Name = "gbAllergy"
        Me.gbAllergy.Size = New System.Drawing.Size(306, 143)
        Me.gbAllergy.TabIndex = 6
        Me.gbAllergy.TabStop = False
        Me.gbAllergy.Text = "Allergier"
        '
        'txtAllergy
        '
        Me.txtAllergy.Location = New System.Drawing.Point(6, 18)
        Me.txtAllergy.Multiline = True
        Me.txtAllergy.Name = "txtAllergy"
        Me.txtAllergy.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAllergy.Size = New System.Drawing.Size(291, 119)
        Me.txtAllergy.TabIndex = 0
        '
        'chkActive
        '
        Me.chkActive.AutoSize = True
        Me.chkActive.Location = New System.Drawing.Point(325, 508)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(50, 17)
        Me.chkActive.TabIndex = 8
        Me.chkActive.Text = "Aktiv"
        Me.chkActive.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.chkMail)
        Me.GroupBox7.Controls.Add(Me.chkEmail)
        Me.GroupBox7.Controls.Add(Me.chkSMS)
        Me.GroupBox7.Location = New System.Drawing.Point(3, 508)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(306, 47)
        Me.GroupBox7.TabIndex = 5
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Tillåter utskick (erbjudanden, reklam, etc.)"
        '
        'chkMail
        '
        Me.chkMail.AutoSize = True
        Me.chkMail.Location = New System.Drawing.Point(126, 22)
        Me.chkMail.Name = "chkMail"
        Me.chkMail.Size = New System.Drawing.Size(47, 17)
        Me.chkMail.TabIndex = 2
        Me.chkMail.Text = "Post"
        Me.chkMail.UseVisualStyleBackColor = True
        '
        'chkEmail
        '
        Me.chkEmail.AutoSize = True
        Me.chkEmail.Location = New System.Drawing.Point(64, 22)
        Me.chkEmail.Name = "chkEmail"
        Me.chkEmail.Size = New System.Drawing.Size(56, 17)
        Me.chkEmail.TabIndex = 1
        Me.chkEmail.Text = "E-post"
        Me.chkEmail.UseVisualStyleBackColor = True
        '
        'chkSMS
        '
        Me.chkSMS.AutoSize = True
        Me.chkSMS.Location = New System.Drawing.Point(9, 22)
        Me.chkSMS.Name = "chkSMS"
        Me.chkSMS.Size = New System.Drawing.Size(49, 17)
        Me.chkSMS.TabIndex = 0
        Me.chkSMS.Text = "SMS"
        Me.chkSMS.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.cboDOBYear)
        Me.GroupBox5.Controls.Add(Me.cboDOBMonth)
        Me.GroupBox5.Controls.Add(Me.cboDOBDay)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Location = New System.Drawing.Point(3, 222)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(307, 42)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Födelsedatum"
        '
        'cboDOBYear
        '
        Me.cboDOBYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDOBYear.FormattingEnabled = True
        Me.cboDOBYear.Location = New System.Drawing.Point(211, 13)
        Me.cboDOBYear.Name = "cboDOBYear"
        Me.cboDOBYear.Size = New System.Drawing.Size(86, 21)
        Me.cboDOBYear.TabIndex = 2
        '
        'cboDOBMonth
        '
        Me.cboDOBMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDOBMonth.FormattingEnabled = True
        Me.cboDOBMonth.Location = New System.Drawing.Point(153, 13)
        Me.cboDOBMonth.Name = "cboDOBMonth"
        Me.cboDOBMonth.Size = New System.Drawing.Size(52, 21)
        Me.cboDOBMonth.TabIndex = 1
        '
        'cboDOBDay
        '
        Me.cboDOBDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDOBDay.FormattingEnabled = True
        Me.cboDOBDay.Location = New System.Drawing.Point(95, 13)
        Me.cboDOBDay.Name = "cboDOBDay"
        Me.cboDOBDay.Size = New System.Drawing.Size(52, 21)
        Me.cboDOBDay.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Dag, månad, år:"
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(96, 86)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(202, 20)
        Me.txtCity.TabIndex = 3
        '
        'cboDistrict
        '
        Me.cboDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDistrict.FormattingEnabled = True
        Me.cboDistrict.Location = New System.Drawing.Point(96, 41)
        Me.cboDistrict.Name = "cboDistrict"
        Me.cboDistrict.Size = New System.Drawing.Size(202, 21)
        Me.cboDistrict.TabIndex = 12
        '
        'frmCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 559)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.chkActive)
        Me.Controls.Add(Me.gbAllergy)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbName)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.gbMiscInfo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCustomer"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Kund"
        Me.gbName.ResumeLayout(False)
        Me.gbName.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.gbMiscInfo.ResumeLayout(False)
        Me.gbMiscInfo.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.gbAllergy.ResumeLayout(False)
        Me.gbAllergy.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTelephoneWork As System.Windows.Forms.TextBox
    Friend WithEvents gbName As System.Windows.Forms.GroupBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtEmailAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtTelephoneHome As System.Windows.Forms.TextBox
    Friend WithEvents txtTelephoneMobile As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents gbMiscInfo As System.Windows.Forms.GroupBox
    Friend WithEvents txtMiscInfo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPostalCode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cboCategory As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtEdited As System.Windows.Forms.TextBox
    Friend WithEvents txtCreated As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents gbAllergy As System.Windows.Forms.GroupBox
    Friend WithEvents txtAllergy As System.Windows.Forms.TextBox
    Friend WithEvents chkActive As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents chkMail As System.Windows.Forms.CheckBox
    Friend WithEvents chkEmail As System.Windows.Forms.CheckBox
    Friend WithEvents chkSMS As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents cboDOBYear As System.Windows.Forms.ComboBox
    Friend WithEvents cboDOBMonth As System.Windows.Forms.ComboBox
    Friend WithEvents cboDOBDay As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents cboDistrict As System.Windows.Forms.ComboBox
End Class

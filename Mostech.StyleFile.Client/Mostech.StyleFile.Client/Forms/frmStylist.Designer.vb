<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStylist
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStylist))
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPostalCode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbName = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTelephoneWork = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEmailAddress = New System.Windows.Forms.TextBox()
        Me.txtTelephoneHome = New System.Windows.Forms.TextBox()
        Me.txtTelephoneMobile = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gbMiscInfo = New System.Windows.Forms.GroupBox()
        Me.txtMiscInfo = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtEdited = New System.Windows.Forms.TextBox()
        Me.txtCreated = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gbAllergy = New System.Windows.Forms.GroupBox()
        Me.txtAllergy = New System.Windows.Forms.TextBox()
        Me.chkActive = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cboProfession = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboEmploymentType = New System.Windows.Forms.ComboBox()
        Me.gbName.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.gbMiscInfo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbAllergy.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(559, 442)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "&Spara"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(478, 442)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "&Avbryt"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(6, 42)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(51, 13)
        Me.lblFirstName.TabIndex = 2
        Me.lblFirstName.Text = "Förnamn:"
        '
        'txtFirstName
        '
        Me.txtFirstName.BackColor = System.Drawing.Color.Yellow
        Me.txtFirstName.Location = New System.Drawing.Point(96, 42)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(204, 20)
        Me.txtFirstName.TabIndex = 1
        '
        'txtLastName
        '
        Me.txtLastName.BackColor = System.Drawing.Color.Yellow
        Me.txtLastName.Location = New System.Drawing.Point(96, 19)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(204, 20)
        Me.txtLastName.TabIndex = 0
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(7, 19)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(58, 13)
        Me.lblLastName.TabIndex = 5
        Me.lblLastName.Text = "Efternamn:"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(96, 19)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(204, 20)
        Me.txtAddress.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Address:"
        '
        'txtPostalCode
        '
        Me.txtPostalCode.Location = New System.Drawing.Point(201, 42)
        Me.txtPostalCode.Name = "txtPostalCode"
        Me.txtPostalCode.Size = New System.Drawing.Size(99, 20)
        Me.txtPostalCode.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Postnr:"
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(96, 64)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(204, 20)
        Me.txtCity.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Ort:"
        '
        'gbName
        '
        Me.gbName.Controls.Add(Me.txtFirstName)
        Me.gbName.Controls.Add(Me.lblFirstName)
        Me.gbName.Controls.Add(Me.txtLastName)
        Me.gbName.Controls.Add(Me.lblLastName)
        Me.gbName.Location = New System.Drawing.Point(7, 177)
        Me.gbName.Name = "gbName"
        Me.gbName.Size = New System.Drawing.Size(306, 75)
        Me.gbName.TabIndex = 1
        Me.gbName.TabStop = False
        Me.gbName.Text = "Namn"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtAddress)
        Me.GroupBox2.Controls.Add(Me.txtCity)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtPostalCode)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 258)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(306, 91)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Address"
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
        Me.GroupBox4.Location = New System.Drawing.Point(7, 355)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(306, 110)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Kontakt"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Telefon, jobb:"
        '
        'txtTelephoneWork
        '
        Me.txtTelephoneWork.Location = New System.Drawing.Point(96, 61)
        Me.txtTelephoneWork.Name = "txtTelephoneWork"
        Me.txtTelephoneWork.Size = New System.Drawing.Size(204, 20)
        Me.txtTelephoneWork.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 83)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "E-post:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Telefon, hem:"
        '
        'txtEmailAddress
        '
        Me.txtEmailAddress.Location = New System.Drawing.Point(96, 83)
        Me.txtEmailAddress.Name = "txtEmailAddress"
        Me.txtEmailAddress.Size = New System.Drawing.Size(204, 20)
        Me.txtEmailAddress.TabIndex = 3
        '
        'txtTelephoneHome
        '
        Me.txtTelephoneHome.Location = New System.Drawing.Point(96, 38)
        Me.txtTelephoneHome.Name = "txtTelephoneHome"
        Me.txtTelephoneHome.Size = New System.Drawing.Size(204, 20)
        Me.txtTelephoneHome.TabIndex = 1
        '
        'txtTelephoneMobile
        '
        Me.txtTelephoneMobile.Location = New System.Drawing.Point(96, 16)
        Me.txtTelephoneMobile.Name = "txtTelephoneMobile"
        Me.txtTelephoneMobile.Size = New System.Drawing.Size(204, 20)
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
        Me.gbMiscInfo.Location = New System.Drawing.Point(328, 177)
        Me.gbMiscInfo.Name = "gbMiscInfo"
        Me.gbMiscInfo.Size = New System.Drawing.Size(306, 259)
        Me.gbMiscInfo.TabIndex = 5
        Me.gbMiscInfo.TabStop = False
        Me.gbMiscInfo.Text = "Annat"
        '
        'txtMiscInfo
        '
        Me.txtMiscInfo.Location = New System.Drawing.Point(9, 19)
        Me.txtMiscInfo.Multiline = True
        Me.txtMiscInfo.Name = "txtMiscInfo"
        Me.txtMiscInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMiscInfo.Size = New System.Drawing.Size(291, 233)
        Me.txtMiscInfo.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtEdited)
        Me.GroupBox1.Controls.Add(Me.txtCreated)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(306, 89)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Automatiska uppgifter"
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
        Me.txtEdited.Size = New System.Drawing.Size(204, 20)
        Me.txtEdited.TabIndex = 4
        Me.txtEdited.TabStop = False
        '
        'txtCreated
        '
        Me.txtCreated.Location = New System.Drawing.Point(96, 42)
        Me.txtCreated.Name = "txtCreated"
        Me.txtCreated.ReadOnly = True
        Me.txtCreated.Size = New System.Drawing.Size(204, 20)
        Me.txtCreated.TabIndex = 3
        Me.txtCreated.TabStop = False
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(96, 19)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(204, 20)
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
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Stylistnummer:"
        '
        'gbAllergy
        '
        Me.gbAllergy.Controls.Add(Me.txtAllergy)
        Me.gbAllergy.Location = New System.Drawing.Point(328, 3)
        Me.gbAllergy.Name = "gbAllergy"
        Me.gbAllergy.Size = New System.Drawing.Size(306, 168)
        Me.gbAllergy.TabIndex = 4
        Me.gbAllergy.TabStop = False
        Me.gbAllergy.Text = "Allergier"
        '
        'txtAllergy
        '
        Me.txtAllergy.Location = New System.Drawing.Point(6, 18)
        Me.txtAllergy.Multiline = True
        Me.txtAllergy.Name = "txtAllergy"
        Me.txtAllergy.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAllergy.Size = New System.Drawing.Size(291, 143)
        Me.txtAllergy.TabIndex = 0
        '
        'chkActive
        '
        Me.chkActive.AutoSize = True
        Me.chkActive.Location = New System.Drawing.Point(328, 442)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(50, 17)
        Me.chkActive.TabIndex = 6
        Me.chkActive.Text = "Aktiv"
        Me.chkActive.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cboEmploymentType)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.cboProfession)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 98)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(307, 73)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Kategorisering"
        '
        'cboProfession
        '
        Me.cboProfession.BackColor = System.Drawing.Color.White
        Me.cboProfession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProfession.FormattingEnabled = True
        Me.cboProfession.Location = New System.Drawing.Point(96, 45)
        Me.cboProfession.Name = "cboProfession"
        Me.cboProfession.Size = New System.Drawing.Size(204, 21)
        Me.cboProfession.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 45)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Profession:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 21)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 13)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Anställningstyp:"
        '
        'cboEmploymentType
        '
        Me.cboEmploymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmploymentType.FormattingEnabled = True
        Me.cboEmploymentType.Location = New System.Drawing.Point(97, 18)
        Me.cboEmploymentType.Name = "cboEmploymentType"
        Me.cboEmploymentType.Size = New System.Drawing.Size(204, 21)
        Me.cboEmploymentType.TabIndex = 4
        '
        'frmStylist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 470)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.chkActive)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbAllergy)
        Me.Controls.Add(Me.gbMiscInfo)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.gbName)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStylist"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Stylist"
        Me.gbName.ResumeLayout(False)
        Me.gbName.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.gbMiscInfo.ResumeLayout(False)
        Me.gbMiscInfo.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbAllergy.ResumeLayout(False)
        Me.gbAllergy.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPostalCode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gbName As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtEmailAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtTelephoneHome As System.Windows.Forms.TextBox
    Friend WithEvents txtTelephoneMobile As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents gbMiscInfo As System.Windows.Forms.GroupBox
    Friend WithEvents txtMiscInfo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTelephoneWork As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtEdited As System.Windows.Forms.TextBox
    Friend WithEvents txtCreated As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents gbAllergy As System.Windows.Forms.GroupBox
    Friend WithEvents txtAllergy As System.Windows.Forms.TextBox
    Friend WithEvents chkActive As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cboProfession As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboEmploymentType As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class

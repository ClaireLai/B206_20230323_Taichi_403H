<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLicense
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLicense))
        Me.lblNotice02Text = New System.Windows.Forms.Label()
        Me.lblNotice01Text = New System.Windows.Forms.Label()
        Me.lblRegisterText = New System.Windows.Forms.Label()
        Me.txtNoticeCode1 = New System.Windows.Forms.TextBox()
        Me.txtNoticeCode3 = New System.Windows.Forms.TextBox()
        Me.txtRegisterCode1 = New System.Windows.Forms.TextBox()
        Me.txtRegisterCode3 = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.txtRegisterCode2 = New System.Windows.Forms.TextBox()
        Me.txtNoticeCode2 = New System.Windows.Forms.TextBox()
        Me.btnTry = New System.Windows.Forms.Button()
        Me.picCelloLogo = New System.Windows.Forms.PictureBox()
        Me.btnResetTrial = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnResetExpired = New System.Windows.Forms.Button()
        Me.btnUnRegister = New System.Windows.Forms.Button()
        Me.btnTrial = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.chkLicenseOK = New System.Windows.Forms.CheckBox()
        Me.chkLicenseTrial = New System.Windows.Forms.CheckBox()
        Me.chkLicenseExpired = New System.Windows.Forms.CheckBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnSetExpired = New System.Windows.Forms.Button()
        Me.lblTrialDaysText = New System.Windows.Forms.Label()
        Me.lblRunDaysText = New System.Windows.Forms.Label()
        Me.lblCurrentDaysText = New System.Windows.Forms.Label()
        Me.lblRunDays = New System.Windows.Forms.Label()
        Me.lblCurrentDate = New System.Windows.Forms.Label()
        Me.txtTrialDays = New System.Windows.Forms.TextBox()
        Me.pnlSpecial = New System.Windows.Forms.Panel()
        Me.lblHDDSN = New System.Windows.Forms.Label()
        Me.lblUsedMins = New System.Windows.Forms.Label()
        Me.lblHDD1ID = New System.Windows.Forms.Label()
        Me.lblMBID = New System.Windows.Forms.Label()
        Me.lblCPUID = New System.Windows.Forms.Label()
        Me.lblTotalMins = New System.Windows.Forms.Label()
        CType(Me.picCelloLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSpecial.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNotice02Text
        '
        Me.lblNotice02Text.BackColor = System.Drawing.SystemColors.Control
        Me.lblNotice02Text.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNotice02Text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblNotice02Text.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNotice02Text.Location = New System.Drawing.Point(5, 207)
        Me.lblNotice02Text.Name = "lblNotice02Text"
        Me.lblNotice02Text.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNotice02Text.Size = New System.Drawing.Size(420, 51)
        Me.lblNotice02Text.TabIndex = 16
        Me.lblNotice02Text.Text = "註冊碼: 請將原廠提供之註冊碼輸入到下列方塊中:"
        Me.lblNotice02Text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNotice01Text
        '
        Me.lblNotice01Text.BackColor = System.Drawing.SystemColors.Control
        Me.lblNotice01Text.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNotice01Text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotice01Text.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNotice01Text.Location = New System.Drawing.Point(5, 122)
        Me.lblNotice01Text.Name = "lblNotice01Text"
        Me.lblNotice01Text.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNotice01Text.Size = New System.Drawing.Size(420, 49)
        Me.lblNotice01Text.TabIndex = 17
        Me.lblNotice01Text.Text = "提示碼: 請將此碼記下並傳回原廠,原廠會提供一註冊碼."
        Me.lblNotice01Text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRegisterText
        '
        Me.lblRegisterText.BackColor = System.Drawing.SystemColors.Control
        Me.lblRegisterText.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblRegisterText.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblRegisterText.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblRegisterText.Location = New System.Drawing.Point(112, -3)
        Me.lblRegisterText.Name = "lblRegisterText"
        Me.lblRegisterText.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblRegisterText.Size = New System.Drawing.Size(323, 39)
        Me.lblRegisterText.TabIndex = 17
        Me.lblRegisterText.Text = "註冊通知:"
        Me.lblRegisterText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNoticeCode1
        '
        Me.txtNoticeCode1.AcceptsReturn = True
        Me.txtNoticeCode1.BackColor = System.Drawing.SystemColors.Window
        Me.txtNoticeCode1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNoticeCode1.Enabled = False
        Me.txtNoticeCode1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoticeCode1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNoticeCode1.Location = New System.Drawing.Point(42, 176)
        Me.txtNoticeCode1.MaxLength = 0
        Me.txtNoticeCode1.Name = "txtNoticeCode1"
        Me.txtNoticeCode1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNoticeCode1.Size = New System.Drawing.Size(98, 29)
        Me.txtNoticeCode1.TabIndex = 1
        Me.txtNoticeCode1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNoticeCode3
        '
        Me.txtNoticeCode3.AcceptsReturn = True
        Me.txtNoticeCode3.BackColor = System.Drawing.SystemColors.Window
        Me.txtNoticeCode3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNoticeCode3.Enabled = False
        Me.txtNoticeCode3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoticeCode3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNoticeCode3.Location = New System.Drawing.Point(290, 176)
        Me.txtNoticeCode3.MaxLength = 0
        Me.txtNoticeCode3.Name = "txtNoticeCode3"
        Me.txtNoticeCode3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNoticeCode3.Size = New System.Drawing.Size(98, 29)
        Me.txtNoticeCode3.TabIndex = 3
        Me.txtNoticeCode3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRegisterCode1
        '
        Me.txtRegisterCode1.AcceptsReturn = True
        Me.txtRegisterCode1.BackColor = System.Drawing.SystemColors.Window
        Me.txtRegisterCode1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRegisterCode1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegisterCode1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtRegisterCode1.Location = New System.Drawing.Point(42, 263)
        Me.txtRegisterCode1.MaxLength = 0
        Me.txtRegisterCode1.Name = "txtRegisterCode1"
        Me.txtRegisterCode1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtRegisterCode1.Size = New System.Drawing.Size(98, 29)
        Me.txtRegisterCode1.TabIndex = 4
        Me.txtRegisterCode1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRegisterCode3
        '
        Me.txtRegisterCode3.AcceptsReturn = True
        Me.txtRegisterCode3.BackColor = System.Drawing.SystemColors.Window
        Me.txtRegisterCode3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRegisterCode3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegisterCode3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtRegisterCode3.Location = New System.Drawing.Point(290, 263)
        Me.txtRegisterCode3.MaxLength = 0
        Me.txtRegisterCode3.Name = "txtRegisterCode3"
        Me.txtRegisterCode3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtRegisterCode3.Size = New System.Drawing.Size(98, 29)
        Me.txtRegisterCode3.TabIndex = 6
        Me.txtRegisterCode3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnOK.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnOK.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnOK.Location = New System.Drawing.Point(251, 39)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnOK.Size = New System.Drawing.Size(123, 41)
        Me.btnOK.TabIndex = 13
        Me.btnOK.Text = "註冊"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'txtRegisterCode2
        '
        Me.txtRegisterCode2.AcceptsReturn = True
        Me.txtRegisterCode2.BackColor = System.Drawing.SystemColors.Window
        Me.txtRegisterCode2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRegisterCode2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegisterCode2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtRegisterCode2.Location = New System.Drawing.Point(166, 263)
        Me.txtRegisterCode2.MaxLength = 0
        Me.txtRegisterCode2.Name = "txtRegisterCode2"
        Me.txtRegisterCode2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtRegisterCode2.Size = New System.Drawing.Size(98, 29)
        Me.txtRegisterCode2.TabIndex = 5
        Me.txtRegisterCode2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNoticeCode2
        '
        Me.txtNoticeCode2.AcceptsReturn = True
        Me.txtNoticeCode2.BackColor = System.Drawing.SystemColors.Window
        Me.txtNoticeCode2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNoticeCode2.Enabled = False
        Me.txtNoticeCode2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoticeCode2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNoticeCode2.Location = New System.Drawing.Point(166, 176)
        Me.txtNoticeCode2.MaxLength = 0
        Me.txtNoticeCode2.Name = "txtNoticeCode2"
        Me.txtNoticeCode2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNoticeCode2.Size = New System.Drawing.Size(98, 29)
        Me.txtNoticeCode2.TabIndex = 2
        Me.txtNoticeCode2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnTry
        '
        Me.btnTry.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnTry.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnTry.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTry.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnTry.Location = New System.Drawing.Point(116, 39)
        Me.btnTry.Name = "btnTry"
        Me.btnTry.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnTry.Size = New System.Drawing.Size(116, 41)
        Me.btnTry.TabIndex = 13
        Me.btnTry.Text = "試用"
        Me.btnTry.UseVisualStyleBackColor = True
        Me.btnTry.Visible = False
        '
        'picCelloLogo
        '
        Me.picCelloLogo.Location = New System.Drawing.Point(0, 0)
        Me.picCelloLogo.Name = "picCelloLogo"
        Me.picCelloLogo.Size = New System.Drawing.Size(102, 84)
        Me.picCelloLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCelloLogo.TabIndex = 218
        Me.picCelloLogo.TabStop = False
        '
        'btnResetTrial
        '
        Me.btnResetTrial.Location = New System.Drawing.Point(114, 50)
        Me.btnResetTrial.Name = "btnResetTrial"
        Me.btnResetTrial.Size = New System.Drawing.Size(84, 33)
        Me.btnResetTrial.TabIndex = 224
        Me.btnResetTrial.Text = "Reset Trial"
        Me.btnResetTrial.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(208, 137)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(84, 33)
        Me.btnRefresh.TabIndex = 223
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnResetExpired
        '
        Me.btnResetExpired.Location = New System.Drawing.Point(114, 1)
        Me.btnResetExpired.Name = "btnResetExpired"
        Me.btnResetExpired.Size = New System.Drawing.Size(84, 33)
        Me.btnResetExpired.TabIndex = 222
        Me.btnResetExpired.Text = "Reset Expired"
        Me.btnResetExpired.UseVisualStyleBackColor = True
        '
        'btnUnRegister
        '
        Me.btnUnRegister.Location = New System.Drawing.Point(114, 95)
        Me.btnUnRegister.Name = "btnUnRegister"
        Me.btnUnRegister.Size = New System.Drawing.Size(84, 33)
        Me.btnUnRegister.TabIndex = 221
        Me.btnUnRegister.Text = "UnRegister"
        Me.btnUnRegister.UseVisualStyleBackColor = True
        '
        'btnTrial
        '
        Me.btnTrial.Location = New System.Drawing.Point(208, 50)
        Me.btnTrial.Name = "btnTrial"
        Me.btnTrial.Size = New System.Drawing.Size(84, 33)
        Me.btnTrial.TabIndex = 219
        Me.btnTrial.Text = "Trial"
        Me.btnTrial.UseVisualStyleBackColor = True
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(208, 95)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(84, 33)
        Me.btnRegister.TabIndex = 220
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'chkLicenseOK
        '
        Me.chkLicenseOK.AutoSize = True
        Me.chkLicenseOK.Location = New System.Drawing.Point(18, 50)
        Me.chkLicenseOK.Name = "chkLicenseOK"
        Me.chkLicenseOK.Size = New System.Drawing.Size(78, 16)
        Me.chkLicenseOK.TabIndex = 227
        Me.chkLicenseOK.Text = "License OK"
        Me.chkLicenseOK.UseVisualStyleBackColor = True
        '
        'chkLicenseTrial
        '
        Me.chkLicenseTrial.AutoSize = True
        Me.chkLicenseTrial.Location = New System.Drawing.Point(18, 28)
        Me.chkLicenseTrial.Name = "chkLicenseTrial"
        Me.chkLicenseTrial.Size = New System.Drawing.Size(46, 16)
        Me.chkLicenseTrial.TabIndex = 226
        Me.chkLicenseTrial.Text = "Trial"
        Me.chkLicenseTrial.UseVisualStyleBackColor = True
        '
        'chkLicenseExpired
        '
        Me.chkLicenseExpired.AutoSize = True
        Me.chkLicenseExpired.Location = New System.Drawing.Point(18, 6)
        Me.chkLicenseExpired.Name = "chkLicenseExpired"
        Me.chkLicenseExpired.Size = New System.Drawing.Size(61, 16)
        Me.chkLicenseExpired.TabIndex = 225
        Me.chkLicenseExpired.Text = "Exipred"
        Me.chkLicenseExpired.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'btnSetExpired
        '
        Me.btnSetExpired.Location = New System.Drawing.Point(208, 1)
        Me.btnSetExpired.Name = "btnSetExpired"
        Me.btnSetExpired.Size = New System.Drawing.Size(84, 33)
        Me.btnSetExpired.TabIndex = 233
        Me.btnSetExpired.Text = "Set Expired"
        Me.btnSetExpired.UseVisualStyleBackColor = True
        '
        'lblTrialDaysText
        '
        Me.lblTrialDaysText.BackColor = System.Drawing.SystemColors.Control
        Me.lblTrialDaysText.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTrialDaysText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrialDaysText.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTrialDaysText.Location = New System.Drawing.Point(104, 176)
        Me.lblTrialDaysText.Name = "lblTrialDaysText"
        Me.lblTrialDaysText.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTrialDaysText.Size = New System.Drawing.Size(79, 21)
        Me.lblTrialDaysText.TabIndex = 237
        Me.lblTrialDaysText.Text = "試用日數"
        Me.lblTrialDaysText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRunDaysText
        '
        Me.lblRunDaysText.BackColor = System.Drawing.SystemColors.Control
        Me.lblRunDaysText.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblRunDaysText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRunDaysText.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblRunDaysText.Location = New System.Drawing.Point(7, 176)
        Me.lblRunDaysText.Name = "lblRunDaysText"
        Me.lblRunDaysText.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblRunDaysText.Size = New System.Drawing.Size(79, 21)
        Me.lblRunDaysText.TabIndex = 238
        Me.lblRunDaysText.Text = "已使用天數"
        Me.lblRunDaysText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCurrentDaysText
        '
        Me.lblCurrentDaysText.BackColor = System.Drawing.SystemColors.Control
        Me.lblCurrentDaysText.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCurrentDaysText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentDaysText.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCurrentDaysText.Location = New System.Drawing.Point(7, 69)
        Me.lblCurrentDaysText.Name = "lblCurrentDaysText"
        Me.lblCurrentDaysText.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCurrentDaysText.Size = New System.Drawing.Size(79, 21)
        Me.lblCurrentDaysText.TabIndex = 239
        Me.lblCurrentDaysText.Text = "現在日數"
        Me.lblCurrentDaysText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRunDays
        '
        Me.lblRunDays.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblRunDays.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRunDays.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblRunDays.Location = New System.Drawing.Point(8, 197)
        Me.lblRunDays.Name = "lblRunDays"
        Me.lblRunDays.Size = New System.Drawing.Size(61, 22)
        Me.lblRunDays.TabIndex = 235
        '
        'lblCurrentDate
        '
        Me.lblCurrentDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCurrentDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCurrentDate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblCurrentDate.Location = New System.Drawing.Point(8, 95)
        Me.lblCurrentDate.Name = "lblCurrentDate"
        Me.lblCurrentDate.Size = New System.Drawing.Size(61, 22)
        Me.lblCurrentDate.TabIndex = 234
        '
        'txtTrialDays
        '
        Me.txtTrialDays.AcceptsReturn = True
        Me.txtTrialDays.BackColor = System.Drawing.SystemColors.Window
        Me.txtTrialDays.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTrialDays.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTrialDays.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTrialDays.Location = New System.Drawing.Point(100, 197)
        Me.txtTrialDays.MaxLength = 0
        Me.txtTrialDays.Name = "txtTrialDays"
        Me.txtTrialDays.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTrialDays.Size = New System.Drawing.Size(88, 29)
        Me.txtTrialDays.TabIndex = 240
        Me.txtTrialDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnlSpecial
        '
        Me.pnlSpecial.Controls.Add(Me.lblHDDSN)
        Me.pnlSpecial.Controls.Add(Me.lblUsedMins)
        Me.pnlSpecial.Controls.Add(Me.lblHDD1ID)
        Me.pnlSpecial.Controls.Add(Me.lblMBID)
        Me.pnlSpecial.Controls.Add(Me.lblCPUID)
        Me.pnlSpecial.Controls.Add(Me.lblTotalMins)
        Me.pnlSpecial.Controls.Add(Me.txtTrialDays)
        Me.pnlSpecial.Controls.Add(Me.lblTrialDaysText)
        Me.pnlSpecial.Controls.Add(Me.lblRunDaysText)
        Me.pnlSpecial.Controls.Add(Me.lblCurrentDaysText)
        Me.pnlSpecial.Controls.Add(Me.lblRunDays)
        Me.pnlSpecial.Controls.Add(Me.lblCurrentDate)
        Me.pnlSpecial.Controls.Add(Me.btnSetExpired)
        Me.pnlSpecial.Controls.Add(Me.chkLicenseOK)
        Me.pnlSpecial.Controls.Add(Me.chkLicenseTrial)
        Me.pnlSpecial.Controls.Add(Me.chkLicenseExpired)
        Me.pnlSpecial.Controls.Add(Me.btnResetTrial)
        Me.pnlSpecial.Controls.Add(Me.btnRefresh)
        Me.pnlSpecial.Controls.Add(Me.btnResetExpired)
        Me.pnlSpecial.Controls.Add(Me.btnUnRegister)
        Me.pnlSpecial.Controls.Add(Me.btnTrial)
        Me.pnlSpecial.Controls.Add(Me.btnRegister)
        Me.pnlSpecial.Location = New System.Drawing.Point(423, 2)
        Me.pnlSpecial.Name = "pnlSpecial"
        Me.pnlSpecial.Size = New System.Drawing.Size(295, 318)
        Me.pnlSpecial.TabIndex = 241
        Me.pnlSpecial.Visible = False
        '
        'lblHDDSN
        '
        Me.lblHDDSN.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblHDDSN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHDDSN.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblHDDSN.Location = New System.Drawing.Point(8, 148)
        Me.lblHDDSN.Name = "lblHDDSN"
        Me.lblHDDSN.Size = New System.Drawing.Size(180, 22)
        Me.lblHDDSN.TabIndex = 246
        Me.lblHDDSN.Text = "0123456789012"
        Me.lblHDDSN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUsedMins
        '
        Me.lblUsedMins.BackColor = System.Drawing.SystemColors.Control
        Me.lblUsedMins.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblUsedMins.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsedMins.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblUsedMins.Location = New System.Drawing.Point(204, 176)
        Me.lblUsedMins.Name = "lblUsedMins"
        Me.lblUsedMins.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblUsedMins.Size = New System.Drawing.Size(79, 21)
        Me.lblUsedMins.TabIndex = 245
        Me.lblUsedMins.Text = "已用分鐘數"
        Me.lblUsedMins.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblHDD1ID
        '
        Me.lblHDD1ID.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblHDD1ID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHDD1ID.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblHDD1ID.Location = New System.Drawing.Point(9, 286)
        Me.lblHDD1ID.Name = "lblHDD1ID"
        Me.lblHDD1ID.Size = New System.Drawing.Size(283, 22)
        Me.lblHDD1ID.TabIndex = 244
        Me.lblHDD1ID.Text = "0123456789012"
        Me.lblHDD1ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMBID
        '
        Me.lblMBID.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblMBID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMBID.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblMBID.Location = New System.Drawing.Point(9, 258)
        Me.lblMBID.Name = "lblMBID"
        Me.lblMBID.Size = New System.Drawing.Size(283, 22)
        Me.lblMBID.TabIndex = 243
        Me.lblMBID.Text = "0123456789012"
        Me.lblMBID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCPUID
        '
        Me.lblCPUID.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCPUID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCPUID.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblCPUID.Location = New System.Drawing.Point(9, 230)
        Me.lblCPUID.Name = "lblCPUID"
        Me.lblCPUID.Size = New System.Drawing.Size(281, 22)
        Me.lblCPUID.TabIndex = 242
        Me.lblCPUID.Text = "0123456789012"
        Me.lblCPUID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalMins
        '
        Me.lblTotalMins.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTotalMins.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalMins.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblTotalMins.Location = New System.Drawing.Point(202, 197)
        Me.lblTotalMins.Name = "lblTotalMins"
        Me.lblTotalMins.Size = New System.Drawing.Size(88, 22)
        Me.lblTotalMins.TabIndex = 241
        Me.lblTotalMins.Text = "0123456789012"
        Me.lblTotalMins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormLicense
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(720, 328)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlSpecial)
        Me.Controls.Add(Me.picCelloLogo)
        Me.Controls.Add(Me.txtNoticeCode2)
        Me.Controls.Add(Me.txtRegisterCode2)
        Me.Controls.Add(Me.btnTry)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtRegisterCode3)
        Me.Controls.Add(Me.txtRegisterCode1)
        Me.Controls.Add(Me.txtNoticeCode3)
        Me.Controls.Add(Me.txtNoticeCode1)
        Me.Controls.Add(Me.lblRegisterText)
        Me.Controls.Add(Me.lblNotice01Text)
        Me.Controls.Add(Me.lblNotice02Text)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormLicense"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "License"
        Me.TopMost = True
        CType(Me.picCelloLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSpecial.ResumeLayout(False)
        Me.pnlSpecial.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents lblNotice02Text As System.Windows.Forms.Label
    Public WithEvents lblNotice01Text As System.Windows.Forms.Label
    Public WithEvents lblRegisterText As System.Windows.Forms.Label
    Public WithEvents txtNoticeCode1 As System.Windows.Forms.TextBox
    Public WithEvents txtNoticeCode3 As System.Windows.Forms.TextBox
    Public WithEvents txtRegisterCode1 As System.Windows.Forms.TextBox
    Public WithEvents txtRegisterCode3 As System.Windows.Forms.TextBox
    Public WithEvents btnOK As System.Windows.Forms.Button
    Public WithEvents txtRegisterCode2 As System.Windows.Forms.TextBox
    Public WithEvents txtNoticeCode2 As System.Windows.Forms.TextBox
    Public WithEvents btnTry As System.Windows.Forms.Button
    Friend WithEvents picCelloLogo As System.Windows.Forms.PictureBox
    Friend WithEvents btnResetTrial As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnResetExpired As System.Windows.Forms.Button
    Friend WithEvents btnUnRegister As System.Windows.Forms.Button
    Friend WithEvents btnTrial As System.Windows.Forms.Button
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents chkLicenseOK As System.Windows.Forms.CheckBox
    Friend WithEvents chkLicenseTrial As System.Windows.Forms.CheckBox
    Friend WithEvents chkLicenseExpired As System.Windows.Forms.CheckBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnSetExpired As System.Windows.Forms.Button
    Public WithEvents lblTrialDaysText As System.Windows.Forms.Label
    Public WithEvents lblRunDaysText As System.Windows.Forms.Label
    Public WithEvents lblCurrentDaysText As System.Windows.Forms.Label
    Friend WithEvents lblRunDays As System.Windows.Forms.Label
    Friend WithEvents lblCurrentDate As System.Windows.Forms.Label
    Public WithEvents txtTrialDays As System.Windows.Forms.TextBox
    Friend WithEvents pnlSpecial As System.Windows.Forms.Panel
    Friend WithEvents lblTotalMins As System.Windows.Forms.Label
    Friend WithEvents lblHDD1ID As System.Windows.Forms.Label
    Friend WithEvents lblMBID As System.Windows.Forms.Label
    Friend WithEvents lblCPUID As System.Windows.Forms.Label
    Public WithEvents lblUsedMins As System.Windows.Forms.Label
    Friend WithEvents lblHDDSN As System.Windows.Forms.Label
End Class

Public Class FormKeyinProcessName
    Inherits System.Windows.Forms.Form

    Private FileName As String
    Property ProcessFileName() As String
        Get
            FileName = txtProcessingFileName.Text
            Return FileName
        End Get
        Set(ByVal value As String)
            FileName = value
            txtProcessingFileName.Text = value
        End Set
    End Property

#Region " Windows Form ³]­p¤u¨ã²£¥Íªºµ{¦¡½X "

    Public Sub New()
        MyBase.New()

        '¦¹©I¥s¬° Windows Form ³]­p¤u¨ãªº¥²­n¶µ¡C
        InitializeComponent()

        '¦b InitializeComponent() ©I¥s¤§«á¥[¤J©Ò¦³ªºªì©l³]©w

    End Sub

    'Form ÂÐ¼g Dispose ¥H²M°£¤¸¥ó²M³æ¡C
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    '¬° Windows Form ³]­p¤u¨ãªº¥²­n¶µ
    Private components As System.ComponentModel.IContainer

    'ª`·N: ¥H¤U¬° Windows Form ³]­p¤u¨ã©Ò»Ýªºµ{§Ç
    '±z¥i¥H¨Ï¥Î Windows Form ³]­p¤u¨ã¶i¦æ­×§ï¡C
    '½Ð¤Å¨Ï¥Îµ{¦¡½X½s¿è¾¹¨Ó­×§ï³o¨Çµ{§Ç¡C
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents txtProcessingFileName As System.Windows.Forms.TextBox
    Friend WithEvents btnAddRecipeName As System.Windows.Forms.Button
    Friend WithEvents btnAddTime As System.Windows.Forms.Button
    Friend WithEvents btnAddDate As System.Windows.Forms.Button
    Friend WithEvents btnAddUser As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnAddSpace As System.Windows.Forms.Button
    Friend WithEvents btnAddUnderline As System.Windows.Forms.Button
    Friend WithEvents btnAddDash As System.Windows.Forms.Button
    Friend WithEvents picCelloLogo As System.Windows.Forms.PictureBox
    Friend WithEvents txtBarcodeInput As System.Windows.Forms.TextBox
    Friend WithEvents lblProcessingFileName As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.txtProcessingFileName = New System.Windows.Forms.TextBox()
        Me.lblProcessingFileName = New System.Windows.Forms.Label()
        Me.btnAddRecipeName = New System.Windows.Forms.Button()
        Me.btnAddTime = New System.Windows.Forms.Button()
        Me.btnAddDate = New System.Windows.Forms.Button()
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAddSpace = New System.Windows.Forms.Button()
        Me.btnAddUnderline = New System.Windows.Forms.Button()
        Me.btnAddDash = New System.Windows.Forms.Button()
        Me.picCelloLogo = New System.Windows.Forms.PictureBox()
        Me.txtBarcodeInput = New System.Windows.Forms.TextBox()
        CType(Me.picCelloLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(270, 194)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(163, 60)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "  EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnEnter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnter.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.Location = New System.Drawing.Point(16, 194)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(163, 60)
        Me.btnEnter.TabIndex = 14
        Me.btnEnter.Text = "ENTER"
        Me.btnEnter.UseVisualStyleBackColor = False
        '
        'txtProcessingFileName
        '
        Me.txtProcessingFileName.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProcessingFileName.Location = New System.Drawing.Point(16, 115)
        Me.txtProcessingFileName.Name = "txtProcessingFileName"
        Me.txtProcessingFileName.Size = New System.Drawing.Size(417, 29)
        Me.txtProcessingFileName.TabIndex = 13
        '
        'lblProcessingFileName
        '
        Me.lblProcessingFileName.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcessingFileName.ForeColor = System.Drawing.Color.Black
        Me.lblProcessingFileName.Location = New System.Drawing.Point(12, 80)
        Me.lblProcessingFileName.Name = "lblProcessingFileName"
        Me.lblProcessingFileName.Size = New System.Drawing.Size(218, 32)
        Me.lblProcessingFileName.TabIndex = 12
        Me.lblProcessingFileName.Text = "½Ð¿é¤J»sµ{ÀÉ¦W:"
        '
        'btnAddRecipeName
        '
        Me.btnAddRecipeName.Location = New System.Drawing.Point(31, 12)
        Me.btnAddRecipeName.Name = "btnAddRecipeName"
        Me.btnAddRecipeName.Size = New System.Drawing.Size(74, 40)
        Me.btnAddRecipeName.TabIndex = 208
        Me.btnAddRecipeName.Text = "°t¤è¦W"
        Me.btnAddRecipeName.UseVisualStyleBackColor = True
        '
        'btnAddTime
        '
        Me.btnAddTime.Location = New System.Drawing.Point(190, 12)
        Me.btnAddTime.Name = "btnAddTime"
        Me.btnAddTime.Size = New System.Drawing.Size(74, 40)
        Me.btnAddTime.TabIndex = 208
        Me.btnAddTime.Text = "®É¶¡"
        Me.btnAddTime.UseVisualStyleBackColor = True
        '
        'btnAddDate
        '
        Me.btnAddDate.Location = New System.Drawing.Point(111, 12)
        Me.btnAddDate.Name = "btnAddDate"
        Me.btnAddDate.Size = New System.Drawing.Size(74, 40)
        Me.btnAddDate.TabIndex = 208
        Me.btnAddDate.Text = "¤é´Á"
        Me.btnAddDate.UseVisualStyleBackColor = True
        '
        'btnAddUser
        '
        Me.btnAddUser.Location = New System.Drawing.Point(271, 12)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(74, 40)
        Me.btnAddUser.TabIndex = 208
        Me.btnAddUser.Text = "¨Ï¥ÎªÌ"
        Me.btnAddUser.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(351, 12)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(74, 40)
        Me.btnClear.TabIndex = 208
        Me.btnClear.Text = "²M°£"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnAddSpace
        '
        Me.btnAddSpace.Location = New System.Drawing.Point(190, 69)
        Me.btnAddSpace.Name = "btnAddSpace"
        Me.btnAddSpace.Size = New System.Drawing.Size(74, 40)
        Me.btnAddSpace.TabIndex = 209
        Me.btnAddSpace.Text = "ªÅ¥Õ"
        Me.btnAddSpace.UseVisualStyleBackColor = True
        '
        'btnAddUnderline
        '
        Me.btnAddUnderline.Location = New System.Drawing.Point(270, 69)
        Me.btnAddUnderline.Name = "btnAddUnderline"
        Me.btnAddUnderline.Size = New System.Drawing.Size(74, 40)
        Me.btnAddUnderline.TabIndex = 209
        Me.btnAddUnderline.Text = "©³½u"
        Me.btnAddUnderline.UseVisualStyleBackColor = True
        '
        'btnAddDash
        '
        Me.btnAddDash.Location = New System.Drawing.Point(351, 69)
        Me.btnAddDash.Name = "btnAddDash"
        Me.btnAddDash.Size = New System.Drawing.Size(74, 40)
        Me.btnAddDash.TabIndex = 209
        Me.btnAddDash.Text = "¤¤½u"
        Me.btnAddDash.UseVisualStyleBackColor = True
        '
        'picCelloLogo
        '
        Me.picCelloLogo.Image = Global.CELLO.My.Resources.Resources.CELLOLOGO02
        Me.picCelloLogo.Location = New System.Drawing.Point(185, 194)
        Me.picCelloLogo.Name = "picCelloLogo"
        Me.picCelloLogo.Size = New System.Drawing.Size(79, 60)
        Me.picCelloLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCelloLogo.TabIndex = 219
        Me.picCelloLogo.TabStop = False
        '
        'txtBarcodeInput
        '
        Me.txtBarcodeInput.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtBarcodeInput.Location = New System.Drawing.Point(16, 150)
        Me.txtBarcodeInput.Name = "txtBarcodeInput"
        Me.txtBarcodeInput.Size = New System.Drawing.Size(417, 29)
        Me.txtBarcodeInput.TabIndex = 0
        Me.txtBarcodeInput.WordWrap = False
        '
        'FormKeyinProcessName
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(442, 261)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtBarcodeInput)
        Me.Controls.Add(Me.picCelloLogo)
        Me.Controls.Add(Me.btnAddDash)
        Me.Controls.Add(Me.btnAddUnderline)
        Me.Controls.Add(Me.btnAddSpace)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAddUser)
        Me.Controls.Add(Me.btnAddDate)
        Me.Controls.Add(Me.btnAddTime)
        Me.Controls.Add(Me.btnAddRecipeName)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.txtProcessingFileName)
        Me.Controls.Add(Me.lblProcessingFileName)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "FormKeyinProcessName"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Keyin Process Name"
        Me.TopMost = True
        CType(Me.picCelloLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        If txtBarcodeInput.Text.Length > 0 Then
            FileName = txtBarcodeInput.Text
            txtProcessingFileName.Text = FileName
        Else
            FileName = txtProcessingFileName.Text
        End If

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Hide()
    End Sub

    Private Sub txtProcessingFileName_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtProcessingFileName.MouseDown
        FormKeyboard1s.Value = txtProcessingFileName.Text
        CallKeyboard1(sender, False)
    End Sub

    Private Sub KeyinProcessNameForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtBarcodeInput.Focus()
    End Sub


    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtProcessingFileName.Text = ""
    End Sub

    Private Sub btnAddDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddDate.Click
        txtProcessingFileName.Text = txtProcessingFileName.Text + FDate
    End Sub

    Private Sub btnAddTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddTime.Click
        txtProcessingFileName.Text = txtProcessingFileName.Text + FTime

    End Sub

    Private Sub btnAddUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddUser.Click
        txtProcessingFileName.Text = txtProcessingFileName.Text + LoginUserName

    End Sub

    Private Sub btnAddRecipeName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddRecipeName.Click
        Dim aa() As String
        aa = Split(FormProcesss.lblRecipeFileName.Text, ".")
        txtProcessingFileName.Text = txtProcessingFileName.Text + aa(0)

    End Sub

    Private Sub btnAddSpace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddSpace.Click
        txtProcessingFileName.Text = txtProcessingFileName.Text + " "

    End Sub

    Private Sub btnAddUnderline_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddUnderline.Click
        txtProcessingFileName.Text = txtProcessingFileName.Text + "_"

    End Sub

    Private Sub btnAddDash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddDash.Click
        txtProcessingFileName.Text = txtProcessingFileName.Text + "-"
    End Sub
    'Add By Vincent 20160913 Start 
    Private Sub txtBarcodeInput_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtBarcodeInput.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtBarcodeInput.Text.Length > 0 Then
                FileName = txtBarcodeInput.Text
                txtProcessingFileName.Text = FileName
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        End If
    End Sub
    'Add By Vincent 20160913 Start 
#Region "SanAn CIM Function 20190710"
    'Add By Vincent 20190710  ----------------------------------------------------------  Start
    Public Sub RemoteEnter(Optional ByVal sstr As String = "")
        Me.DialogResult = Windows.Forms.DialogResult.OK
        If Trim(txtProcessingFileName.Text).Length < 1 Then
            '  MsgBoxLangOK("ÀÉ¦W¤Ó¤Ö,¨Ï¥Î¹w³]ÀÉ¦W.", "ÀÉ¦W¤Ó¤Ö,¨Ï¥Î†{„¦ÀÉ¦W.", "File Too Short, Use Default.")
            txtProcessingFileName.Text = FDate + "-" + FTime + "-[" + LoginUserName + "]"
        End If
        If sstr = "" Then
            '«Ø¥ß»sµ{°O¿ýÀÉ¦W
            txtProcessingFileName.Text = FDate + "-" + FTime + "-[" + LoginUserName + "]"
            ProcessFileName = txtProcessingFileName.Text
            ProcessPN = txtProcessingFileName.Text
            ProcessRecordShortFileName = txtProcessingFileName.Text + ".dat"
            'FormProcesss.lblProcessRecordFileName.Text = ProcessRecordShortFileName'Remark By vincent  '20180214
            ProcessRecordFileName = ProcessRecordDir + ProcessRecordShortFileName
            '«Ø¥ß»sµ{¨Æ¥óÀÉ¦W
            ProcessEeventFileName = ProcessEeventDir + txtProcessingFileName.Text + "_Event" + ".dat"
            '«Ø¥ß¦±½uÀÉ¦W
            ProcessRecordCurveFileName = ProcessRecordCurveDir + txtProcessingFileName.Text + ".proc"
        Else
            ProcessFileName = sstr
            ProcessPN = sstr
            ProcessRecordShortFileName = sstr + ".dat"
            'FormProcesss.lblProcessRecordFileName.Text = ProcessRecordShortFileName 'Remark By vincent  '20180214
            ProcessRecordFileName = ProcessRecordDir + ProcessRecordShortFileName
            '«Ø¥ß»sµ{¨Æ¥óÀÉ¦W
            ProcessEeventFileName = ProcessEeventDir + sstr + "_Event" + ".dat"
            '«Ø¥ß¦±½uÀÉ¦W
            ProcessRecordCurveFileName = ProcessRecordCurveDir + sstr + ".proc"
        End If
        Me.Hide()
    End Sub
    'Add By Vincent 20190710  ----------------------------------------------------------  End
#End Region
End Class

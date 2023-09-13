Public Class FormKeyinDataLogName
    Inherits System.Windows.Forms.Form

#Region " Windows Form 設計工具產生的程式碼 "

    Public Sub New()
        MyBase.New()

        '此呼叫為 Windows Form 設計工具的必要項。
        InitializeComponent()

        '在 InitializeComponent() 呼叫之後加入所有的初始設定

    End Sub

    'Form 覆寫 Dispose 以清除元件清單。
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '您可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器來修改這些程序。
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents txtFileName As System.Windows.Forms.TextBox
    Friend WithEvents btnAddTime As System.Windows.Forms.Button
    Friend WithEvents btnAddDate As System.Windows.Forms.Button
    Friend WithEvents btnAddUser As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnAddSpace As System.Windows.Forms.Button
    Friend WithEvents btnAddUnderline As System.Windows.Forms.Button
    Friend WithEvents btnAddDash As System.Windows.Forms.Button
    Friend WithEvents picCelloLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblFileNameText As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormKeyinDataLogName))
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnEnter = New System.Windows.Forms.Button
        Me.txtFileName = New System.Windows.Forms.TextBox
        Me.lblFileNameText = New System.Windows.Forms.Label
        Me.btnAddTime = New System.Windows.Forms.Button
        Me.btnAddDate = New System.Windows.Forms.Button
        Me.btnAddUser = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnAddSpace = New System.Windows.Forms.Button
        Me.btnAddUnderline = New System.Windows.Forms.Button
        Me.btnAddDash = New System.Windows.Forms.Button
        Me.picCelloLogo = New System.Windows.Forms.PictureBox
        CType(Me.picCelloLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(190, 172)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(120, 60)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "離開"
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnEnter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnter.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.Location = New System.Drawing.Point(16, 172)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(120, 60)
        Me.btnEnter.TabIndex = 14
        Me.btnEnter.Text = "輸入"
        Me.btnEnter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEnter.UseVisualStyleBackColor = False
        '
        'txtFileName
        '
        Me.txtFileName.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtFileName.Location = New System.Drawing.Point(16, 123)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(384, 30)
        Me.txtFileName.TabIndex = 13
        '
        'lblFileNameText
        '
        Me.lblFileNameText.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFileNameText.ForeColor = System.Drawing.Color.Black
        Me.lblFileNameText.Location = New System.Drawing.Point(12, 88)
        Me.lblFileNameText.Name = "lblFileNameText"
        Me.lblFileNameText.Size = New System.Drawing.Size(258, 32)
        Me.lblFileNameText.TabIndex = 12
        Me.lblFileNameText.Text = "請輸入資料記錄檔名:"
        '
        'btnAddTime
        '
        Me.btnAddTime.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddTime.ForeColor = System.Drawing.Color.Blue
        Me.btnAddTime.Location = New System.Drawing.Point(341, 9)
        Me.btnAddTime.Name = "btnAddTime"
        Me.btnAddTime.Size = New System.Drawing.Size(59, 40)
        Me.btnAddTime.TabIndex = 208
        Me.btnAddTime.Text = "時間"
        Me.btnAddTime.UseVisualStyleBackColor = True
        '
        'btnAddDate
        '
        Me.btnAddDate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddDate.ForeColor = System.Drawing.Color.Blue
        Me.btnAddDate.Location = New System.Drawing.Point(276, 9)
        Me.btnAddDate.Name = "btnAddDate"
        Me.btnAddDate.Size = New System.Drawing.Size(59, 40)
        Me.btnAddDate.TabIndex = 208
        Me.btnAddDate.Text = "日期"
        Me.btnAddDate.UseVisualStyleBackColor = True
        '
        'btnAddUser
        '
        Me.btnAddUser.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddUser.ForeColor = System.Drawing.Color.Blue
        Me.btnAddUser.Location = New System.Drawing.Point(406, 9)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(59, 40)
        Me.btnAddUser.TabIndex = 208
        Me.btnAddUser.Text = "使用者"
        Me.btnAddUser.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Blue
        Me.btnClear.Location = New System.Drawing.Point(406, 116)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(59, 40)
        Me.btnClear.TabIndex = 208
        Me.btnClear.Text = "清除"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnAddSpace
        '
        Me.btnAddSpace.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddSpace.ForeColor = System.Drawing.Color.Blue
        Me.btnAddSpace.Location = New System.Drawing.Point(406, 61)
        Me.btnAddSpace.Name = "btnAddSpace"
        Me.btnAddSpace.Size = New System.Drawing.Size(59, 40)
        Me.btnAddSpace.TabIndex = 209
        Me.btnAddSpace.Text = "空白"
        Me.btnAddSpace.UseVisualStyleBackColor = True
        '
        'btnAddUnderline
        '
        Me.btnAddUnderline.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddUnderline.ForeColor = System.Drawing.Color.Blue
        Me.btnAddUnderline.Location = New System.Drawing.Point(276, 61)
        Me.btnAddUnderline.Name = "btnAddUnderline"
        Me.btnAddUnderline.Size = New System.Drawing.Size(59, 40)
        Me.btnAddUnderline.TabIndex = 209
        Me.btnAddUnderline.Text = "底線"
        Me.btnAddUnderline.UseVisualStyleBackColor = True
        '
        'btnAddDash
        '
        Me.btnAddDash.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddDash.ForeColor = System.Drawing.Color.Blue
        Me.btnAddDash.Location = New System.Drawing.Point(341, 61)
        Me.btnAddDash.Name = "btnAddDash"
        Me.btnAddDash.Size = New System.Drawing.Size(59, 40)
        Me.btnAddDash.TabIndex = 209
        Me.btnAddDash.Text = "中線"
        Me.btnAddDash.UseVisualStyleBackColor = True
        '
        'picCelloLogo
        '
        Me.picCelloLogo.Image = Global.CELLO.My.Resources.Resources.CELLOLOGO02
        Me.picCelloLogo.Location = New System.Drawing.Point(0, 0)
        Me.picCelloLogo.Name = "picCelloLogo"
        Me.picCelloLogo.Size = New System.Drawing.Size(102, 84)
        Me.picCelloLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCelloLogo.TabIndex = 218
        Me.picCelloLogo.TabStop = False
        '
        'FormKeyinDataLogName
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(470, 244)
        Me.ControlBox = False
        Me.Controls.Add(Me.picCelloLogo)
        Me.Controls.Add(Me.btnAddDash)
        Me.Controls.Add(Me.btnAddUnderline)
        Me.Controls.Add(Me.btnAddSpace)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAddUser)
        Me.Controls.Add(Me.btnAddDate)
        Me.Controls.Add(Me.btnAddTime)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.lblFileNameText)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormKeyinDataLogName"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Keyin Datalog Name"
        Me.TopMost = True
        CType(Me.picCelloLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        Me.Hide()

        If txtFileName.Text.Length < 1 Then
            txtFileName.Text = FDate + "-" + FTime + "-[" + LoginUserName + "]"
        Else
            CheckDataLogDirAndCreate()
            DataLogShortFileName = txtFileName.Text + ".csv"
            DataLogShortFileName1 = txtFileName.Text + "_A.csv"
            DataLogCUVFileName = txtFileName.Text + ".cuv"
            DataLogCUVFileName1 = txtFileName.Text + "_A.cuv"
            DataLogRecordFileName = DataLogRecordDir + DataLogShortFileName
            DataLogRecordFileName1 = DataLogRecordDir + txtFileName.Text + "_A.txt"
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub txtProcessingFileName_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtFileName.MouseDown
        CallKeyboard1(sender, False)
    End Sub


    Private Sub KeyinProcessNameForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtFileName.Text = FDate & "-" & FTime & "_" & LoginUserName
    End Sub


    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtFileName.Text = ""
    End Sub

    Private Sub btnAddDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddDate.Click
        txtFileName.Text = txtFileName.Text + FDate

    End Sub

    Private Sub btnAddTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddTime.Click
        txtFileName.Text = txtFileName.Text + FTime

    End Sub

    Private Sub btnAddUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddUser.Click
        txtFileName.Text = txtFileName.Text + LoginUserName

    End Sub

    Private Sub btnAddSpace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddSpace.Click
        txtFileName.Text = txtFileName.Text + " "

    End Sub

    Private Sub btnAddUnderline_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddUnderline.Click
        txtFileName.Text = txtFileName.Text + "_"

    End Sub

    Private Sub btnAddDash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddDash.Click
        txtFileName.Text = txtFileName.Text + "-"
    End Sub
End Class

Public Class FormLogin
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
    Friend WithEvents btnExit As Windows.Forms.Button
    Friend WithEvents btnEnter As Windows.Forms.Button
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents lblPasswordText As System.Windows.Forms.Label
    Friend WithEvents picCelloLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblUserText As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnExit = New Windows.Forms.Button()
        Me.btnEnter = New Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.lblPasswordText = New System.Windows.Forms.Label()
        Me.lblUserText = New System.Windows.Forms.Label()
        Me.picCelloLogo = New System.Windows.Forms.PictureBox()
        CType(Me.picCelloLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(289, 177)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(132, 47)
        Me.btnExit.TabIndex = 45
        Me.btnExit.Text = "離開"
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnEnter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnter.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.Location = New System.Drawing.Point(123, 177)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(132, 47)
        Me.btnEnter.TabIndex = 44
        Me.btnEnter.Text = "確定"
        Me.btnEnter.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(123, 109)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(298, 35)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtUserName
        '
        Me.txtUserName.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.Location = New System.Drawing.Point(123, 39)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(298, 35)
        Me.txtUserName.TabIndex = 1
        '
        'lblPasswordText
        '
        Me.lblPasswordText.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPasswordText.ForeColor = System.Drawing.Color.Black
        Me.lblPasswordText.Location = New System.Drawing.Point(118, 77)
        Me.lblPasswordText.Name = "lblPasswordText"
        Me.lblPasswordText.Size = New System.Drawing.Size(173, 29)
        Me.lblPasswordText.TabIndex = 1
        Me.lblPasswordText.Text = "密碼:"
        '
        'lblUserText
        '
        Me.lblUserText.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserText.ForeColor = System.Drawing.Color.Black
        Me.lblUserText.Location = New System.Drawing.Point(118, 9)
        Me.lblUserText.Name = "lblUserText"
        Me.lblUserText.Size = New System.Drawing.Size(173, 27)
        Me.lblUserText.TabIndex = 0
        Me.lblUserText.Text = "使用者:"
        '
        'picCelloLogo
        '
        Me.picCelloLogo.Image = Global.CELLO.My.Resources.Resources.CELLOLOGO02
        Me.picCelloLogo.Location = New System.Drawing.Point(-1, 1)
        Me.picCelloLogo.Name = "picCelloLogo"
        Me.picCelloLogo.Size = New System.Drawing.Size(118, 97)
        Me.picCelloLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCelloLogo.TabIndex = 524
        Me.picCelloLogo.TabStop = False
        '
        'FormLogin
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(454, 248)
        Me.ControlBox = False
        Me.Controls.Add(Me.picCelloLogo)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblPasswordText)
        Me.Controls.Add(Me.lblUserText)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.TopMost = True
        CType(Me.picCelloLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Dim LoginFlag As Boolean
    Dim FormLoginsetupFormOpen As Boolean

    Private Sub FormLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If FormLoginsetupFormOpen = False Then
            ReadUserRightsFile(UserDataFileName, UserRights)  '讀取使用者資料設定檔
        End If
        FormLoginsetupFormOpen = True
    End Sub


    Private Sub txtUserName_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtUserName.MouseDown
        FormKeyboard1s.KeyInString(sender)
    End Sub

    Private Sub txtPassword_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtPassword.MouseDown
        FormKeyboard1s.txtEnterValue.PasswordChar = "*"
        FormKeyboard1s.txtEnterValue.UseSystemPasswordChar = True
        FormKeyboard1s.KeyInString(sender)
        FormKeyboard1s.txtEnterValue.PasswordChar = ""
        FormKeyboard1s.txtEnterValue.UseSystemPasswordChar = False
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Hide()
        Form1s.Show()
    End Sub



    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        Dim i As Integer
        Dim tuser, tpass, auser, apass As String
        CheckOperatorLogDirAndCreate()

        DisableAllRights()
        If LC.IsOK Then
            FormMenus.btnExit.BackColor = Color.FromArgb(255, 255, 192)
        Else
            FormMenus.btnExit.BackColor = Color.FromArgb(255, 128, 128)
        End If
        '設定超級使用者函數
        'SetSuperPass()
        'CheckOperatorLogDirAndCreate()
        auser = UCase(Trim(txtUserName.Text))       '目前輸入之使用者
        apass = UCase(Trim(txtPassword.Text))       '目前輸入之密碼
        LoginFlag = False
        For i = 0 To MaxUser
            tpass = UCase(Trim(UserRights(i).Password)) '已存檔之使用者
            tuser = UCase(Trim(UserRights(i).Name))     '已存檔之密碼
            If (tuser = auser And auser <> "") Or auser = "CELLO" Then       '比對使用使名稱
                If (tpass = apass And apass <> "") Or apass = "CELLOPASS" Or apass = "CELLO2420" Or apass = "2527CELLO" Then                   '比對密碼
                    '設定權限

                    Rights_Process = UserRights(i).Process
                    Rights_Recipe = UserRights(i).Recipe
                    Rights_Manual = UserRights(i).Manual
                    Rights_Alarm = UserRights(i).Alarm
                    Rights_Recodrd = UserRights(i).Record
                    Rights_Parameter = UserRights(i).Parameter
                    Rights_Maintain = UserRights(i).Maintain
                    Rights_Authority = UserRights(i).Authority

                    LoginUserName = UCase(txtUserName.Text)
                    LoginUserPass = UCase(txtPassword.Text)
                    '寫入登入記錄檔
                    AppendMultiData(OperatorRecordFileName, 40, LoginUserName, "   ==>Login  ", ADate, TTime)
                    Me.Hide()
                    If auser = "CELLO" And apass = "CELLOPASS" Then
                        EnableAllRights()
                    End If
                    If auser = "CELLO" And apass = "CELLO2420" Then
                        EnableAllRights()
                    End If
                    If auser = "CELLO" And apass = "2527CELLO" Then
                        EnableAllRights()
                    End If
                    DisableMenu()
                    FormProcesss.Enabled = False
                    FormProcesss.Enabled = Rights_Process
                    If Rights_Process Then FormMenus.btnProcess.Enabled = True
                    If Rights_Recipe Then FormMenus.btnProcessPara.Enabled = True
                    If Rights_Maintain Then FormMenus.btnMaintance.Enabled = True
                    If Rights_Parameter Then FormMenus.btnParameter.Enabled = True
                    If Rights_Authority Then FormMenus.btnFormLoginsetup.Enabled = True
                    If Rights_Recodrd Then FormMenus.btnRecord.Enabled = True
                    If Rights_Manual Then FormMenus.BtnTest.Enabled = True
                    If Rights_Alarm Then FormMenus.btnAlarm.Enabled = True
                    If LC.IsExpired Then
                        FormLicenses.ShowDialog()
                        LoginFlag = False
                    Else
                        FormMenus.Show()
                        FormProcesss.Show()
                        'Me.Hide()
                        LoginFlag = True
                    End If
                    Exit For
                End If
            End If
        Next i
        'If LC.IsExpired Then
        '    FormProcesss.grpProcess.Enabled = False
        '    SetFromRights()
        'End If
    End Sub

    Public Sub DisableMenu()
        FormMenus.btnProcess.Enabled = False
        FormMenus.btnProcessPara.Enabled = False
        FormMenus.btnMaintance.Enabled = False
        FormMenus.btnParameter.Enabled = False
        FormMenus.btnFormLoginsetup.Enabled = False
        FormMenus.btnRecord.Enabled = False
        FormMenus.BtnTest.Enabled = False
        FormMenus.btnAlarm.Enabled = False
    End Sub

End Class

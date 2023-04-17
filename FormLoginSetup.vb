Public Class FormLoginSetup
    Inherits System.Windows.Forms.Form
    Dim state As Integer
    Private X As Single '當前窗體的寬度
    Private Y As Single '當前窗體的高度
    Private isLoaded As Boolean '// 是否已設定各控制的尺寸資料到Tag屬性
    Private FormW As Integer
    Private FormH As Integer

#Region " Windows Form 設計工具產生的程式碼 "

    Public Sub New()
        MyBase.New()

        '此呼叫為 Windows Form 設計工具的必要項。
        InitializeComponent()
        isLoaded = False
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
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblManualText As System.Windows.Forms.Label
    Friend WithEvents lblRecipeText As System.Windows.Forms.Label
    Friend WithEvents lblProcessText As System.Windows.Forms.Label
    Friend WithEvents lblPassText As System.Windows.Forms.Label
    Friend WithEvents lblUserText As System.Windows.Forms.Label
    Friend WithEvents lblAlarmText As System.Windows.Forms.Label
    Friend WithEvents lblAuthorityText As System.Windows.Forms.Label
    Friend WithEvents lblParameterText As System.Windows.Forms.Label
    Friend WithEvents lblRecordText As System.Windows.Forms.Label
    Friend WithEvents lblMaintainText As System.Windows.Forms.Label
    Friend WithEvents pnlAuthority As System.Windows.Forms.Panel
    Friend WithEvents btnReload As System.Windows.Forms.Button
    Friend WithEvents picCelloTitleEng As System.Windows.Forms.PictureBox
    Friend WithEvents picCelloTitle As System.Windows.Forms.PictureBox
    Friend WithEvents picCelloLogo As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents pgbShowAuthority As System.Windows.Forms.ProgressBar
    Friend WithEvents pnlAuthorityTitle As System.Windows.Forms.Panel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLoginSetup))
        Me.btnSave = New System.Windows.Forms.Button
        Me.lblAlarmText = New System.Windows.Forms.Label
        Me.lblManualText = New System.Windows.Forms.Label
        Me.lblRecipeText = New System.Windows.Forms.Label
        Me.lblProcessText = New System.Windows.Forms.Label
        Me.lblPassText = New System.Windows.Forms.Label
        Me.lblUserText = New System.Windows.Forms.Label
        Me.lblAuthorityText = New System.Windows.Forms.Label
        Me.lblParameterText = New System.Windows.Forms.Label
        Me.lblRecordText = New System.Windows.Forms.Label
        Me.lblMaintainText = New System.Windows.Forms.Label
        Me.pnlAuthority = New System.Windows.Forms.Panel
        Me.pnlAuthorityTitle = New System.Windows.Forms.Panel
        Me.btnReload = New System.Windows.Forms.Button
        Me.picCelloTitleEng = New System.Windows.Forms.PictureBox
        Me.picCelloTitle = New System.Windows.Forms.PictureBox
        Me.picCelloLogo = New System.Windows.Forms.PictureBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pgbShowAuthority = New System.Windows.Forms.ProgressBar
        Me.pnlAuthorityTitle.SuspendLayout()
        CType(Me.picCelloTitleEng, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCelloTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCelloLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(156, 64)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(127, 50)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "儲存"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lblAlarmText
        '
        Me.lblAlarmText.BackColor = System.Drawing.Color.Transparent
        Me.lblAlarmText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlarmText.ForeColor = System.Drawing.Color.Black
        Me.lblAlarmText.Location = New System.Drawing.Point(543, 9)
        Me.lblAlarmText.Name = "lblAlarmText"
        Me.lblAlarmText.Size = New System.Drawing.Size(80, 26)
        Me.lblAlarmText.TabIndex = 117
        Me.lblAlarmText.Text = "異常訊息"
        Me.lblAlarmText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblManualText
        '
        Me.lblManualText.BackColor = System.Drawing.Color.Transparent
        Me.lblManualText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblManualText.ForeColor = System.Drawing.Color.Black
        Me.lblManualText.Location = New System.Drawing.Point(453, 9)
        Me.lblManualText.Name = "lblManualText"
        Me.lblManualText.Size = New System.Drawing.Size(80, 26)
        Me.lblManualText.TabIndex = 6
        Me.lblManualText.Text = "手動操作"
        Me.lblManualText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRecipeText
        '
        Me.lblRecipeText.BackColor = System.Drawing.Color.Transparent
        Me.lblRecipeText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecipeText.ForeColor = System.Drawing.Color.Black
        Me.lblRecipeText.Location = New System.Drawing.Point(363, 9)
        Me.lblRecipeText.Name = "lblRecipeText"
        Me.lblRecipeText.Size = New System.Drawing.Size(80, 26)
        Me.lblRecipeText.TabIndex = 3
        Me.lblRecipeText.Text = "製程參數"
        Me.lblRecipeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProcessText
        '
        Me.lblProcessText.BackColor = System.Drawing.Color.Transparent
        Me.lblProcessText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcessText.ForeColor = System.Drawing.Color.Black
        Me.lblProcessText.Location = New System.Drawing.Point(273, 9)
        Me.lblProcessText.Name = "lblProcessText"
        Me.lblProcessText.Size = New System.Drawing.Size(80, 26)
        Me.lblProcessText.TabIndex = 2
        Me.lblProcessText.Text = "製程執行"
        Me.lblProcessText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPassText
        '
        Me.lblPassText.BackColor = System.Drawing.Color.Transparent
        Me.lblPassText.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassText.ForeColor = System.Drawing.Color.Black
        Me.lblPassText.Location = New System.Drawing.Point(150, 9)
        Me.lblPassText.Name = "lblPassText"
        Me.lblPassText.Size = New System.Drawing.Size(121, 26)
        Me.lblPassText.TabIndex = 1
        Me.lblPassText.Text = "密碼"
        Me.lblPassText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUserText
        '
        Me.lblUserText.BackColor = System.Drawing.Color.Transparent
        Me.lblUserText.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserText.ForeColor = System.Drawing.Color.Black
        Me.lblUserText.Location = New System.Drawing.Point(38, 9)
        Me.lblUserText.Name = "lblUserText"
        Me.lblUserText.Size = New System.Drawing.Size(107, 26)
        Me.lblUserText.TabIndex = 0
        Me.lblUserText.Text = "使用者"
        Me.lblUserText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAuthorityText
        '
        Me.lblAuthorityText.BackColor = System.Drawing.Color.Transparent
        Me.lblAuthorityText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuthorityText.ForeColor = System.Drawing.Color.Black
        Me.lblAuthorityText.Location = New System.Drawing.Point(814, 10)
        Me.lblAuthorityText.Name = "lblAuthorityText"
        Me.lblAuthorityText.Size = New System.Drawing.Size(80, 26)
        Me.lblAuthorityText.TabIndex = 6
        Me.lblAuthorityText.Text = "權限設定"
        Me.lblAuthorityText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblParameterText
        '
        Me.lblParameterText.BackColor = System.Drawing.Color.Transparent
        Me.lblParameterText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParameterText.ForeColor = System.Drawing.Color.Black
        Me.lblParameterText.Location = New System.Drawing.Point(724, 10)
        Me.lblParameterText.Name = "lblParameterText"
        Me.lblParameterText.Size = New System.Drawing.Size(80, 26)
        Me.lblParameterText.TabIndex = 3
        Me.lblParameterText.Text = "參數設定"
        Me.lblParameterText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRecordText
        '
        Me.lblRecordText.BackColor = System.Drawing.Color.Transparent
        Me.lblRecordText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecordText.ForeColor = System.Drawing.Color.Black
        Me.lblRecordText.Location = New System.Drawing.Point(634, 10)
        Me.lblRecordText.Name = "lblRecordText"
        Me.lblRecordText.Size = New System.Drawing.Size(80, 26)
        Me.lblRecordText.TabIndex = 2
        Me.lblRecordText.Text = "系統記錄"
        Me.lblRecordText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMaintainText
        '
        Me.lblMaintainText.BackColor = System.Drawing.Color.Transparent
        Me.lblMaintainText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaintainText.ForeColor = System.Drawing.Color.Black
        Me.lblMaintainText.Location = New System.Drawing.Point(904, 10)
        Me.lblMaintainText.Name = "lblMaintainText"
        Me.lblMaintainText.Size = New System.Drawing.Size(80, 26)
        Me.lblMaintainText.TabIndex = 117
        Me.lblMaintainText.Text = "維修畫面"
        Me.lblMaintainText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlAuthority
        '
        Me.pnlAuthority.AutoScroll = True
        Me.pnlAuthority.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlAuthority.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAuthority.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.pnlAuthority.Location = New System.Drawing.Point(0, 160)
        Me.pnlAuthority.Name = "pnlAuthority"
        Me.pnlAuthority.Size = New System.Drawing.Size(1024, 538)
        Me.pnlAuthority.TabIndex = 118
        '
        'pnlAuthorityTitle
        '
        Me.pnlAuthorityTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlAuthorityTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAuthorityTitle.Controls.Add(Me.lblUserText)
        Me.pnlAuthorityTitle.Controls.Add(Me.lblManualText)
        Me.pnlAuthorityTitle.Controls.Add(Me.lblRecipeText)
        Me.pnlAuthorityTitle.Controls.Add(Me.lblMaintainText)
        Me.pnlAuthorityTitle.Controls.Add(Me.lblAuthorityText)
        Me.pnlAuthorityTitle.Controls.Add(Me.lblAlarmText)
        Me.pnlAuthorityTitle.Controls.Add(Me.lblProcessText)
        Me.pnlAuthorityTitle.Controls.Add(Me.lblParameterText)
        Me.pnlAuthorityTitle.Controls.Add(Me.lblPassText)
        Me.pnlAuthorityTitle.Controls.Add(Me.lblRecordText)
        Me.pnlAuthorityTitle.Location = New System.Drawing.Point(0, 116)
        Me.pnlAuthorityTitle.Name = "pnlAuthorityTitle"
        Me.pnlAuthorityTitle.Size = New System.Drawing.Size(1024, 45)
        Me.pnlAuthorityTitle.TabIndex = 119
        '
        'btnReload
        '
        Me.btnReload.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnReload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReload.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReload.Location = New System.Drawing.Point(156, 0)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(127, 50)
        Me.btnReload.TabIndex = 8
        Me.btnReload.Text = "重新載入"
        Me.btnReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReload.UseVisualStyleBackColor = False
        '
        'picCelloTitleEng
        '
        Me.picCelloTitleEng.Image = Global.CELLO.My.Resources.Resources.CELLO_CO_ENG
        Me.picCelloTitleEng.Location = New System.Drawing.Point(590, 64)
        Me.picCelloTitleEng.Name = "picCelloTitleEng"
        Me.picCelloTitleEng.Size = New System.Drawing.Size(430, 50)
        Me.picCelloTitleEng.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCelloTitleEng.TabIndex = 525
        Me.picCelloTitleEng.TabStop = False
        '
        'picCelloTitle
        '
        Me.picCelloTitle.Image = Global.CELLO.My.Resources.Resources.Cello_Co
        Me.picCelloTitle.Location = New System.Drawing.Point(375, 0)
        Me.picCelloTitle.Name = "picCelloTitle"
        Me.picCelloTitle.Size = New System.Drawing.Size(645, 65)
        Me.picCelloTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCelloTitle.TabIndex = 524
        Me.picCelloTitle.TabStop = False
        '
        'picCelloLogo
        '
        Me.picCelloLogo.Image = Global.CELLO.My.Resources.Resources.CELLOLOGO02
        Me.picCelloLogo.Location = New System.Drawing.Point(0, 0)
        Me.picCelloLogo.Name = "picCelloLogo"
        Me.picCelloLogo.Size = New System.Drawing.Size(138, 110)
        Me.picCelloLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCelloLogo.TabIndex = 523
        Me.picCelloLogo.TabStop = False
        '
        'pgbShowAuthority
        '
        Me.pgbShowAuthority.Location = New System.Drawing.Point(375, 101)
        Me.pgbShowAuthority.MarqueeAnimationSpeed = 50
        Me.pgbShowAuthority.Maximum = 32
        Me.pgbShowAuthority.Name = "pgbShowAuthority"
        Me.pgbShowAuthority.Size = New System.Drawing.Size(209, 13)
        Me.pgbShowAuthority.Step = 1
        Me.pgbShowAuthority.TabIndex = 0
        '
        'FormLoginSetup
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1024, 710)
        Me.ControlBox = False
        Me.Controls.Add(Me.pgbShowAuthority)
        Me.Controls.Add(Me.picCelloTitleEng)
        Me.Controls.Add(Me.picCelloTitle)
        Me.Controls.Add(Me.picCelloLogo)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnReload)
        Me.Controls.Add(Me.pnlAuthorityTitle)
        Me.Controls.Add(Me.pnlAuthority)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(0, 58)
        Me.Name = "FormLoginSetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Login Setup"
        Me.pnlAuthorityTitle.ResumeLayout(False)
        CType(Me.picCelloTitleEng, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCelloTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCelloLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FormLoginsetup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'ReadUserRightsFile(UserDataFileName, UserRights)  '讀取使用者資料設定檔
        'AddAuthoritySetupToPanel(FormLoginSetups.pnlAuthority, 0, MaxUser)
        'SetFromRights()
        X = Me.Width '獲取窗體的寬度
        Y = Me.Height '獲取窗體的高度
        isLoaded = True '已設定各控制項的尺寸到Tag屬性中
        SetTag(Me) '調用方法
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        GetFormRights()                                      '取得表單的設定資料
        WriteUserRightsFile(UserDataFileName, UserRights)  '寫入使用者資料設定檔
        '還原按鈕文字
        ResetModifiedButton(btnSave, "*")
    End Sub

    '重新載入資料
    Private Sub btnReload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReload.Click
        ReadUserRightsFile(UserDataFileName, UserRights)  '讀取使用者資料設定檔
        SetFromRights()                                     '設定表單內之資料
        ResetModifiedButton(btnSave, "*")
    End Sub
    Private Sub FormProcess_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If isLoaded Then

            NewX_sub = FormW / X
            NewY_sub = (FormH - FromStartUpTopPosition) / Y
            Me.Height = (FormW - FromStartUpTopPosition)
            Me.Width = FormW
            SetControls(NewX_sub, NewY_sub, Me, isLoaded)
            Debug.Print("Form1_Resize  ,Me.Width=" + Me.Width.ToString + ",Me.Height=" + Me.Height.ToString)
        End If
    End Sub

    Private Sub FormProcess_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        FormW = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width
        FormH = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height

        Me.WindowState = FormWindowState.Normal
        FormProcess_Resize(Me, e)
        'Debug.Print("Form1_Shown" + ",screen.Width=" + FormW.ToString + ",screen.Height=" + FormH.ToString)
    End Sub


End Class

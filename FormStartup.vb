Public Class FormStartup
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
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents pgbSystemLoad As System.Windows.Forms.ProgressBar
    Friend WithEvents lblPercent As System.Windows.Forms.Label
    Friend WithEvents picCelloTitleEng As System.Windows.Forms.PictureBox
    Friend WithEvents picCelloTitle As System.Windows.Forms.PictureBox
    Friend WithEvents picCelloLogo As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblSystemLoadString As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormStartup))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pgbSystemLoad = New System.Windows.Forms.ProgressBar
        Me.lblSystemLoadString = New System.Windows.Forms.Label
        Me.lblPercent = New System.Windows.Forms.Label
        Me.picCelloTitleEng = New System.Windows.Forms.PictureBox
        Me.picCelloTitle = New System.Windows.Forms.PictureBox
        Me.picCelloLogo = New System.Windows.Forms.PictureBox
        Me.Panel1 = New System.Windows.Forms.Panel
        CType(Me.picCelloTitleEng, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCelloTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCelloLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'pgbSystemLoad
        '
        Me.pgbSystemLoad.BackColor = System.Drawing.SystemColors.Control
        Me.pgbSystemLoad.ForeColor = System.Drawing.Color.Lime
        Me.pgbSystemLoad.Location = New System.Drawing.Point(48, 191)
        Me.pgbSystemLoad.Name = "pgbSystemLoad"
        Me.pgbSystemLoad.Size = New System.Drawing.Size(347, 21)
        Me.pgbSystemLoad.Step = 1
        Me.pgbSystemLoad.TabIndex = 0
        '
        'lblSystemLoadString
        '
        Me.lblSystemLoadString.AutoSize = True
        Me.lblSystemLoadString.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSystemLoadString.Location = New System.Drawing.Point(30, 148)
        Me.lblSystemLoadString.Name = "lblSystemLoadString"
        Me.lblSystemLoadString.Size = New System.Drawing.Size(213, 27)
        Me.lblSystemLoadString.TabIndex = 1
        Me.lblSystemLoadString.Text = "System Loading...."
        '
        'lblPercent
        '
        Me.lblPercent.AutoSize = True
        Me.lblPercent.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercent.Location = New System.Drawing.Point(401, 188)
        Me.lblPercent.Name = "lblPercent"
        Me.lblPercent.Size = New System.Drawing.Size(82, 27)
        Me.lblPercent.TabIndex = 2
        Me.lblPercent.Text = "(0.0%)"
        '
        'picCelloTitleEng
        '
        Me.picCelloTitleEng.Image = Global.CELLO.My.Resources.Resources.CELLO_CO_ENG
        Me.picCelloTitleEng.Location = New System.Drawing.Point(311, 76)
        Me.picCelloTitleEng.Name = "picCelloTitleEng"
        Me.picCelloTitleEng.Size = New System.Drawing.Size(275, 36)
        Me.picCelloTitleEng.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCelloTitleEng.TabIndex = 519
        Me.picCelloTitleEng.TabStop = False
        '
        'picCelloTitle
        '
        Me.picCelloTitle.Image = Global.CELLO.My.Resources.Resources.Cello_Co
        Me.picCelloTitle.Location = New System.Drawing.Point(214, 13)
        Me.picCelloTitle.Name = "picCelloTitle"
        Me.picCelloTitle.Size = New System.Drawing.Size(372, 57)
        Me.picCelloTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCelloTitle.TabIndex = 518
        Me.picCelloTitle.TabStop = False
        '
        'picCelloLogo
        '
        Me.picCelloLogo.Image = Global.CELLO.My.Resources.Resources.cello_LOGO1
        Me.picCelloLogo.Location = New System.Drawing.Point(14, 14)
        Me.picCelloLogo.Name = "picCelloLogo"
        Me.picCelloLogo.Size = New System.Drawing.Size(178, 144)
        Me.picCelloLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCelloLogo.TabIndex = 517
        Me.picCelloLogo.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblSystemLoadString)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(576, 216)
        Me.Panel1.TabIndex = 520
        '
        'FormStartup
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(600, 240)
        Me.Controls.Add(Me.picCelloTitleEng)
        Me.Controls.Add(Me.picCelloTitle)
        Me.Controls.Add(Me.picCelloLogo)
        Me.Controls.Add(Me.lblPercent)
        Me.Controls.Add(Me.pgbSystemLoad)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormStartup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "System Startup"
        Me.TopMost = True
        CType(Me.picCelloTitleEng, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCelloTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCelloLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub FormStartup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        If Me.DesignMode Then Exit Sub
        If IsRun(Me.Text) Then
            MsgBox("Program is running", MsgBoxStyle.Critical)
            MsgBoxLangErr("程式已在執行中!", "Program is running!")
        End If
        pgbSystemLoad.Minimum = 0
        pgbSystemLoad.Maximum = 20
        pgbSystemLoad.PerformStep()
        CreateInitialDirectory()                '建立資料夾
        pgbSystemLoad.PerformStep()
        InitProgramIniFile(ProgramDir)          '初始化 INI 設定檔
        ReadFormAlarmstring(AlarmINIFile)
        ReadProgramCaption(ProgramINIFile)
        ReadProgramMode(ProgramINIFile)
        'Add  by Vincent 20181016  壓力修整功能 ------------------- Start

        For i = 0 To MAXPLATE
            AvergaeValue(i) = New CAverage(5)
        Next
        'Add  by Vincent 20181016  壓力修整功能 ------------------- End
        '設定各logo
        SetupLogo()
        SetupFlag()



        pgbSystemLoad.PerformStep()
        ReadVacuumSetup(ProgramINIFile)         '讀取真空計設定
        pgbSystemLoad.PerformStep()
        PLCSetting(ProgramINIFile)
        ' 初始化輸出類別
        For i = 0 To MAX_OUTPUT
            Output(i) = New ValveClass(i)
        Next

        DeviceLifeTimeInit()                    '初始化裝置壽命
        '參數讀取
        '參數讀取
        ReadFlowMeterMode(ParameterINIFile)
        pgbSystemLoad.PerformStep()
        ReadParameterFromFile(ParameterINIFile) '載入參數檔

        CreateUserControlData()
        RecipeInit(RecipeINIFile)
        ' 溫度校正資料
        pgbSystemLoad.PerformStep()

        '設定 PLC 的AD/DA 資料
        PLCADDADefine(ADDAINIFile)                            '設定 PLC 的AD/DA 資料
        pgbSystemLoad.PerformStep()

        ReadUserRightsFile(UserDataFileName, UserRights)                    '讀取使用者資料設定檔
        pgbSystemLoad.PerformStep()
        AddAuthoritySetupToPanel(FormLoginSetups.pnlAuthority, 0, MaxUser)  '設定讀取使用者資料設定檔
        pgbSystemLoad.PerformStep()
        SetFromRights() '讀取使用者資料設定檔
        pgbSystemLoad.PerformStep()
        ReadIOName(LangCHTINIFile, LangCHSINIFile, LangEngINIFile)

        SystemLanguage = Val(ReadProgData("PROGRAM", "LANGUAGE", "0", ProgramINIFile)) '讀取語言設定
        'ClickLanguge() ' 設定語言系統參數
        LanguageSelect(ProgramINIFile, LangCHTINIFile, LangCHSINIFile, LangEngINIFile)

        'ChangeLanguage(LanguageFile) '改變畫面語言
        ReadProcessString()
        ReadPumpSetup(ProgramINIFile)

        'Add By Vincent 20190710  ----------------------------------------------------------  Start
        'RemoteCIM = New CRemoteClass
        RemoteCIM.Initial()
        'RemoteCIM.RecipeData.Parse_H2E_CMD_EXE(RemoteCIM.EQID) 'For Test parse XML command
        'Add By Vincent 20190710  ----------------------------------------------------------  End

        pgbSystemLoad.PerformStep()


        'MFC01_Control.Start(50, 5, 10)
        'MFC02_Control.Start(50, 5, 10)


        Timer1.Interval = 100
        Timer1.Enabled = True

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblPercent.Text = Format((pgbSystemLoad.Value) / pgbSystemLoad.Maximum, "0.0%")
        If pgbSystemLoad.Value >= pgbSystemLoad.Maximum Then
            'Form1s.Show()
            Timer1.Enabled = False
            Me.Hide()
            Form1s.Show()

            'FormManuals.Show()
            'FormProcesss.Show()
            'FormParameters.Show()
            'FormLoginSetups.Show()
            'FormRecipes.Show()
            'FormMaintances.Show()
            'FormRecords.Show()
            'FormAlarms.Show()

            'Threading.Thread.Sleep(1000)
            'FormManuals.Hide()
            'FormProcesss.Hide()
            'FormParameters.Hide()
            'FormLoginSetups.Hide()
            'FormRecipes.Hide()
            'FormMaintances.Hide()
            'FormRecords.Hide()
            'FormAlarms.Hide()
            Form1s.TopMost = False

        Else
            pgbSystemLoad.PerformStep()
        End If
    End Sub


End Class

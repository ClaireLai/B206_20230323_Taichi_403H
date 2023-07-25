Imports System.Windows.Forms.DataVisualization.Charting

Public Class FormProcess
    Inherits System.Windows.Forms.Form
    Public RecipeLoaded As Boolean
    '#Const SanAn_TCPIP_Used = 0
#Region " Windows Form ³]­p¤u¨ã²£¥Íªºµ{¦¡½X "
    Friend WithEvents lblHoldTime02Text As System.Windows.Forms.Label
    Friend WithEvents pgbReadCurve As System.Windows.Forms.ProgressBar
    Friend WithEvents tabProcessDataCurve As System.Windows.Forms.TabControl
    Friend WithEvents TabPageCurve As System.Windows.Forms.TabPage
    Friend WithEvents TabPageData As System.Windows.Forms.TabPage
    Friend WithEvents lblCUPUsage As System.Windows.Forms.Label
    Friend WithEvents btnRunProcess As System.Windows.Forms.Button
    Friend WithEvents btnCurveReset As System.Windows.Forms.Button

    Friend WithEvents btnPrintCurve As System.Windows.Forms.Button

    Friend WithEvents lblRecipeFileName As System.Windows.Forms.Label
    Friend WithEvents lblWafreSizeText As System.Windows.Forms.Label
    Friend WithEvents pnlProcessCSelect As System.Windows.Forms.Panel
    Friend WithEvents btnShowSeriesName As System.Windows.Forms.Button
    Friend WithEvents lblSlash01Text As System.Windows.Forms.Label
    Friend WithEvents btnCurveFreeze As System.Windows.Forms.Button
    Friend WithEvents lblWaferSize As System.Windows.Forms.Label
    Friend WithEvents lblCursorValue As System.Windows.Forms.Label
    Friend WithEvents TabPagePlateData As System.Windows.Forms.TabPage
    Friend WithEvents flwProcess As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents flwProcessData As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents flwProcessCurve As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents pnlVacuumChart As System.Windows.Forms.Panel
    Friend WithEvents btnSaveAs As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblPumpingStatus As System.Windows.Forms.Label
    Friend WithEvents btnAutoPurge As System.Windows.Forms.Button
    Friend WithEvents btnAutoVacuum As System.Windows.Forms.Button
    Friend WithEvents pnlChamberLeft As System.Windows.Forms.Panel
    Friend WithEvents lblVentText As System.Windows.Forms.Label
    Friend WithEvents btnPumpProtection As System.Windows.Forms.Button
    Friend WithEvents picDP As System.Windows.Forms.PictureBox
    Friend WithEvents lblN2Text As System.Windows.Forms.Label
    Friend WithEvents picRVP As System.Windows.Forms.PictureBox
    Friend WithEvents lblDPText As System.Windows.Forms.Label
    Friend WithEvents picPipeV02 As System.Windows.Forms.PictureBox
    Friend WithEvents picV4P As System.Windows.Forms.PictureBox
    Friend WithEvents picPipeV01 As System.Windows.Forms.PictureBox
    Friend WithEvents lblRVText As System.Windows.Forms.Label
    Friend WithEvents pnlChamberRight As System.Windows.Forms.Panel
    Friend WithEvents pnlChamberUp As System.Windows.Forms.Panel
    Friend WithEvents pnlChamberDown As System.Windows.Forms.Panel
    Friend WithEvents lblDPCurrent As System.Windows.Forms.Label
    Friend WithEvents lblA03Text As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblCHVac As System.Windows.Forms.Label
    Friend WithEvents lbl1ATM As System.Windows.Forms.Label
    Friend WithEvents lblTorr02Text As System.Windows.Forms.Label
    Friend WithEvents lblCPUUsage As System.Windows.Forms.Label
    Friend WithEvents grpDoorControl As System.Windows.Forms.GroupBox
    Friend WithEvents btnDoor2Down As System.Windows.Forms.Button
    Friend WithEvents btnDoor1Down As System.Windows.Forms.Button
    Friend WithEvents btnDoor2Up As System.Windows.Forms.Button
    Friend WithEvents btnDoor1Up As System.Windows.Forms.Button
    Friend WithEvents picDoor2 As System.Windows.Forms.PictureBox
    Friend WithEvents picDoor1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblCHVac2 As System.Windows.Forms.Label
    Friend WithEvents lbl1ATM02 As System.Windows.Forms.Label
    Friend WithEvents lblTorr03Text As System.Windows.Forms.Label
    Friend WithEvents btnChamberLight As System.Windows.Forms.Button
    Friend WithEvents pnlMFC02 As System.Windows.Forms.Panel
    Friend WithEvents lblV11TText As System.Windows.Forms.Label
    Friend WithEvents lblMFCTime02 As System.Windows.Forms.Label
    Friend WithEvents picGas02T As System.Windows.Forms.PictureBox
    Friend WithEvents txtGas02MFCSet As System.Windows.Forms.TextBox
    Friend WithEvents lblGas02MFC As System.Windows.Forms.Label
    Friend WithEvents lblGas02Text As System.Windows.Forms.Label
    Friend WithEvents PictureBox100 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlMFC01 As System.Windows.Forms.Panel
    Friend WithEvents lblMFCTime01 As System.Windows.Forms.Label
    Friend WithEvents lblGas01Text As System.Windows.Forms.Label
    Friend WithEvents txtGas01MFCSet As System.Windows.Forms.TextBox
    Friend WithEvents lblGas01MFC As System.Windows.Forms.Label
    Friend WithEvents picGas01T As System.Windows.Forms.PictureBox
    Friend WithEvents lblV10TText As System.Windows.Forms.Label
    Friend WithEvents PictureBox94 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlRecipe As System.Windows.Forms.Panel
    Friend WithEvents grpProcessCondition As System.Windows.Forms.GroupBox
    Friend WithEvents radPress As System.Windows.Forms.RadioButton
    Friend WithEvents radTemp As System.Windows.Forms.RadioButton
    Friend WithEvents radBoth As System.Windows.Forms.RadioButton
    Friend WithEvents grpProcessOption As System.Windows.Forms.GroupBox
    Friend WithEvents chkAutoDoorOpen As System.Windows.Forms.CheckBox
    Friend WithEvents chkAfterPurge As System.Windows.Forms.CheckBox
    Friend WithEvents chkVacuumMode As System.Windows.Forms.CheckBox
    Friend WithEvents chkAutoVent As System.Windows.Forms.CheckBox
    Friend WithEvents chkKeepBonding As System.Windows.Forms.CheckBox
    Friend WithEvents chkBondBeforeVacuum As System.Windows.Forms.CheckBox
    Friend WithEvents chkVacuumPurge As System.Windows.Forms.CheckBox
    Friend WithEvents btnPullerClose As System.Windows.Forms.Button
    Friend WithEvents TabPagePaint As System.Windows.Forms.TabPage
    Friend WithEvents ControlPaintBoard1 As CELLO.ControlPaintBoard
    Friend WithEvents lblModelnameText As System.Windows.Forms.Label
    Friend WithEvents lblModelname As System.Windows.Forms.Label
    Friend WithEvents picC05 As System.Windows.Forms.PictureBox
    Friend WithEvents lblDPTemp As System.Windows.Forms.Label
    Friend WithEvents lblAfterPurgeTemp As System.Windows.Forms.Label
    Friend WithEvents chkPurgeKeepBonding As System.Windows.Forms.CheckBox
    Friend WithEvents lblPurgeOffText As System.Windows.Forms.Label
    Friend WithEvents txtPurgeOFFTime As System.Windows.Forms.TextBox
    Friend WithEvents lblPurgeOnText As System.Windows.Forms.Label
    Friend WithEvents txtPurgeONTime As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtAfterPurgeTemp As System.Windows.Forms.TextBox
    Friend WithEvents chkPurgeCooling As System.Windows.Forms.CheckBox
    Friend WithEvents pnlPurgeCooling As System.Windows.Forms.Panel
    Friend WithEvents btnBarcodeReader As System.Windows.Forms.Button
    Friend WithEvents lblRunNoText As System.Windows.Forms.Label
    Friend WithEvents lblRunCount As System.Windows.Forms.Label
    Friend WithEvents lblProcessDataFile As System.Windows.Forms.Label

    Friend WithEvents btnOffLine As System.Windows.Forms.Button
    Friend WithEvents btnInLine As System.Windows.Forms.Button
    '#If SanAn_TCPIP_Used = 1 Then
    '   Friend WithEvents tpCIMInput As System.Windows.Forms.TabPage
    '    Friend WithEvents CtlSanAnCIM1 As CELLO.CtlSanAnCIM

    Friend WithEvents tpCIMInput As TabPage
    Friend WithEvents CtlSanAnCIM1 As CtlSanAnCIM
    '#End If
    Friend WithEvents lblCIMError As System.Windows.Forms.Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents txtRecipeFile As TextBox
    Friend WithEvents TabPageVacuum As System.Windows.Forms.TabPage
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
    Friend WithEvents grpProcess As System.Windows.Forms.GroupBox
    Friend WithEvents lblProcessRunTime As System.Windows.Forms.Label
    Friend WithEvents lblProcessRunTimeText As System.Windows.Forms.Label
    Friend WithEvents lblBasePressureSet As System.Windows.Forms.Label
    Friend WithEvents lblProcessStepStatus As System.Windows.Forms.Label
    Friend WithEvents lblRecipeNote As System.Windows.Forms.Label
    Friend WithEvents lblBasePressureText As System.Windows.Forms.Label
    Friend WithEvents lblProcessStepText As System.Windows.Forms.Label
    Friend WithEvents lblRecipeNoteText As System.Windows.Forms.Label
    Friend WithEvents lblMessageText As System.Windows.Forms.Label
    Friend WithEvents btnAbort As System.Windows.Forms.Button
    Friend WithEvents btnLoadRecipe As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnVent As System.Windows.Forms.Button
    Friend WithEvents lblHoldTime As System.Windows.Forms.Label
    Friend WithEvents lblProcessStatus As System.Windows.Forms.Label
    Friend WithEvents lblProcessStartTimeText As System.Windows.Forms.Label
    Friend WithEvents lblProcessStartTime As System.Windows.Forms.Label
    Friend WithEvents lblProcessStopTime As System.Windows.Forms.Label
    Friend WithEvents lblTorr01Text As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormProcess))
        Me.grpProcess = New System.Windows.Forms.GroupBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.txtRecipeFile = New System.Windows.Forms.TextBox()
        Me.lblCIMError = New System.Windows.Forms.Label()
        Me.btnOffLine = New System.Windows.Forms.Button()
        Me.btnInLine = New System.Windows.Forms.Button()
        Me.lblProcessDataFile = New System.Windows.Forms.Label()
        Me.lblRunNoText = New System.Windows.Forms.Label()
        Me.lblRunCount = New System.Windows.Forms.Label()
        Me.btnBarcodeReader = New System.Windows.Forms.Button()
        Me.lblModelnameText = New System.Windows.Forms.Label()
        Me.lblModelname = New System.Windows.Forms.Label()
        Me.grpDoorControl = New System.Windows.Forms.GroupBox()
        Me.lblCHVac2 = New System.Windows.Forms.Label()
        Me.lbl1ATM02 = New System.Windows.Forms.Label()
        Me.lblTorr03Text = New System.Windows.Forms.Label()
        Me.btnDoor2Down = New System.Windows.Forms.Button()
        Me.btnDoor1Down = New System.Windows.Forms.Button()
        Me.btnDoor2Up = New System.Windows.Forms.Button()
        Me.btnDoor1Up = New System.Windows.Forms.Button()
        Me.lblCUPUsage = New System.Windows.Forms.Label()
        Me.lblBasePressureText = New System.Windows.Forms.Label()
        Me.lblWaferSize = New System.Windows.Forms.Label()
        Me.lblWafreSizeText = New System.Windows.Forms.Label()
        Me.lblBasePressureSet = New System.Windows.Forms.Label()
        Me.btnRunProcess = New System.Windows.Forms.Button()
        Me.lblTorr01Text = New System.Windows.Forms.Label()
        Me.pgbReadCurve = New System.Windows.Forms.ProgressBar()
        Me.lblProcessStatus = New System.Windows.Forms.Label()
        Me.btnLoadRecipe = New System.Windows.Forms.Button()
        Me.lblMessageText = New System.Windows.Forms.Label()
        Me.lblProcessRunTime = New System.Windows.Forms.Label()
        Me.btnAbort = New System.Windows.Forms.Button()
        Me.lblSlash01Text = New System.Windows.Forms.Label()
        Me.lblProcessStartTimeText = New System.Windows.Forms.Label()
        Me.lblProcessRunTimeText = New System.Windows.Forms.Label()
        Me.btnVent = New System.Windows.Forms.Button()
        Me.lblProcessStartTime = New System.Windows.Forms.Label()
        Me.lblProcessStopTime = New System.Windows.Forms.Label()
        Me.lblRecipeNoteText = New System.Windows.Forms.Label()
        Me.lblRecipeFileName = New System.Windows.Forms.Label()
        Me.lblRecipeNote = New System.Windows.Forms.Label()
        Me.pnlProcessCSelect = New System.Windows.Forms.Panel()
        Me.btnShowSeriesName = New System.Windows.Forms.Button()
        Me.btnCurveFreeze = New System.Windows.Forms.Button()
        Me.lblProcessStepStatus = New System.Windows.Forms.Label()
        Me.lblProcessStepText = New System.Windows.Forms.Label()
        Me.lblHoldTime = New System.Windows.Forms.Label()
        Me.lblHoldTime02Text = New System.Windows.Forms.Label()
        Me.lblCursorValue = New System.Windows.Forms.Label()
        Me.btnPrintCurve = New System.Windows.Forms.Button()
        Me.btnCurveReset = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.tabProcessDataCurve = New System.Windows.Forms.TabControl()
        Me.TabPagePlateData = New System.Windows.Forms.TabPage()
        Me.flwProcess = New System.Windows.Forms.FlowLayoutPanel()
        Me.TabPageCurve = New System.Windows.Forms.TabPage()
        Me.flwProcessCurve = New System.Windows.Forms.FlowLayoutPanel()
        Me.TabPageData = New System.Windows.Forms.TabPage()
        Me.flwProcessData = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlRecipe = New System.Windows.Forms.Panel()
        Me.grpProcessOption = New System.Windows.Forms.GroupBox()
        Me.pnlPurgeCooling = New System.Windows.Forms.Panel()
        Me.lblAfterPurgeTemp = New System.Windows.Forms.Label()
        Me.chkPurgeKeepBonding = New System.Windows.Forms.CheckBox()
        Me.lblPurgeOffText = New System.Windows.Forms.Label()
        Me.txtPurgeOFFTime = New System.Windows.Forms.TextBox()
        Me.lblPurgeOnText = New System.Windows.Forms.Label()
        Me.txtPurgeONTime = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtAfterPurgeTemp = New System.Windows.Forms.TextBox()
        Me.chkPurgeCooling = New System.Windows.Forms.CheckBox()
        Me.chkAutoDoorOpen = New System.Windows.Forms.CheckBox()
        Me.chkAfterPurge = New System.Windows.Forms.CheckBox()
        Me.chkVacuumMode = New System.Windows.Forms.CheckBox()
        Me.chkAutoVent = New System.Windows.Forms.CheckBox()
        Me.chkKeepBonding = New System.Windows.Forms.CheckBox()
        Me.chkBondBeforeVacuum = New System.Windows.Forms.CheckBox()
        Me.chkVacuumPurge = New System.Windows.Forms.CheckBox()
        Me.grpProcessCondition = New System.Windows.Forms.GroupBox()
        Me.radPress = New System.Windows.Forms.RadioButton()
        Me.radTemp = New System.Windows.Forms.RadioButton()
        Me.radBoth = New System.Windows.Forms.RadioButton()
        Me.TabPageVacuum = New System.Windows.Forms.TabPage()
        Me.btnPullerClose = New System.Windows.Forms.Button()
        Me.btnChamberLight = New System.Windows.Forms.Button()
        Me.btnSaveAs = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.picC05 = New System.Windows.Forms.PictureBox()
        Me.lblDPTemp = New System.Windows.Forms.Label()
        Me.pnlMFC02 = New System.Windows.Forms.Panel()
        Me.lblV11TText = New System.Windows.Forms.Label()
        Me.lblMFCTime02 = New System.Windows.Forms.Label()
        Me.picGas02T = New System.Windows.Forms.PictureBox()
        Me.txtGas02MFCSet = New System.Windows.Forms.TextBox()
        Me.lblGas02MFC = New System.Windows.Forms.Label()
        Me.lblGas02Text = New System.Windows.Forms.Label()
        Me.PictureBox100 = New System.Windows.Forms.PictureBox()
        Me.pnlMFC01 = New System.Windows.Forms.Panel()
        Me.lblMFCTime01 = New System.Windows.Forms.Label()
        Me.lblGas01Text = New System.Windows.Forms.Label()
        Me.txtGas01MFCSet = New System.Windows.Forms.TextBox()
        Me.lblGas01MFC = New System.Windows.Forms.Label()
        Me.picGas01T = New System.Windows.Forms.PictureBox()
        Me.lblV10TText = New System.Windows.Forms.Label()
        Me.PictureBox94 = New System.Windows.Forms.PictureBox()
        Me.picDoor2 = New System.Windows.Forms.PictureBox()
        Me.picDoor1 = New System.Windows.Forms.PictureBox()
        Me.lblPumpingStatus = New System.Windows.Forms.Label()
        Me.btnAutoPurge = New System.Windows.Forms.Button()
        Me.btnAutoVacuum = New System.Windows.Forms.Button()
        Me.pnlChamberLeft = New System.Windows.Forms.Panel()
        Me.lblVentText = New System.Windows.Forms.Label()
        Me.btnPumpProtection = New System.Windows.Forms.Button()
        Me.picDP = New System.Windows.Forms.PictureBox()
        Me.lblN2Text = New System.Windows.Forms.Label()
        Me.picRVP = New System.Windows.Forms.PictureBox()
        Me.lblDPText = New System.Windows.Forms.Label()
        Me.picPipeV02 = New System.Windows.Forms.PictureBox()
        Me.picV4P = New System.Windows.Forms.PictureBox()
        Me.picPipeV01 = New System.Windows.Forms.PictureBox()
        Me.lblRVText = New System.Windows.Forms.Label()
        Me.pnlChamberRight = New System.Windows.Forms.Panel()
        Me.pnlChamberUp = New System.Windows.Forms.Panel()
        Me.pnlChamberDown = New System.Windows.Forms.Panel()
        Me.lblDPCurrent = New System.Windows.Forms.Label()
        Me.lblA03Text = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblCHVac = New System.Windows.Forms.Label()
        Me.lbl1ATM = New System.Windows.Forms.Label()
        Me.lblTorr02Text = New System.Windows.Forms.Label()
        Me.lblCPUUsage = New System.Windows.Forms.Label()
        Me.pnlVacuumChart = New System.Windows.Forms.Panel()
        Me.TabPagePaint = New System.Windows.Forms.TabPage()
        Me.ControlPaintBoard1 = New CELLO.ControlPaintBoard()
        Me.tpCIMInput = New System.Windows.Forms.TabPage()
        Me.CtlSanAnCIM1 = New CELLO.CtlSanAnCIM()
        Me.grpProcess.SuspendLayout()
        Me.grpDoorControl.SuspendLayout()
        Me.pnlProcessCSelect.SuspendLayout()
        Me.tabProcessDataCurve.SuspendLayout()
        Me.TabPagePlateData.SuspendLayout()
        Me.TabPageCurve.SuspendLayout()
        Me.TabPageData.SuspendLayout()
        Me.pnlRecipe.SuspendLayout()
        Me.grpProcessOption.SuspendLayout()
        Me.pnlPurgeCooling.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpProcessCondition.SuspendLayout()
        Me.TabPageVacuum.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.picC05, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMFC02.SuspendLayout()
        CType(Me.picGas02T, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox100, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMFC01.SuspendLayout()
        CType(Me.picGas01T, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox94, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDoor2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDoor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRVP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPipeV02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picV4P, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPipeV01, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.TabPagePaint.SuspendLayout()
        Me.tpCIMInput.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpProcess
        '
        Me.grpProcess.BackColor = System.Drawing.SystemColors.Control
        Me.grpProcess.Controls.Add(Me.btnEnter)
        Me.grpProcess.Controls.Add(Me.txtRecipeFile)
        Me.grpProcess.Controls.Add(Me.lblCIMError)
        Me.grpProcess.Controls.Add(Me.btnOffLine)
        Me.grpProcess.Controls.Add(Me.btnInLine)
        Me.grpProcess.Controls.Add(Me.lblProcessDataFile)
        Me.grpProcess.Controls.Add(Me.lblRunNoText)
        Me.grpProcess.Controls.Add(Me.lblRunCount)
        Me.grpProcess.Controls.Add(Me.btnBarcodeReader)
        Me.grpProcess.Controls.Add(Me.lblModelnameText)
        Me.grpProcess.Controls.Add(Me.lblModelname)
        Me.grpProcess.Controls.Add(Me.grpDoorControl)
        Me.grpProcess.Controls.Add(Me.lblCUPUsage)
        Me.grpProcess.Controls.Add(Me.lblBasePressureText)
        Me.grpProcess.Controls.Add(Me.lblWaferSize)
        Me.grpProcess.Controls.Add(Me.lblWafreSizeText)
        Me.grpProcess.Controls.Add(Me.lblBasePressureSet)
        Me.grpProcess.Controls.Add(Me.btnRunProcess)
        Me.grpProcess.Controls.Add(Me.lblTorr01Text)
        Me.grpProcess.Controls.Add(Me.pgbReadCurve)
        Me.grpProcess.Controls.Add(Me.lblProcessStatus)
        Me.grpProcess.Controls.Add(Me.btnLoadRecipe)
        Me.grpProcess.Controls.Add(Me.lblMessageText)
        Me.grpProcess.Controls.Add(Me.lblProcessRunTime)
        Me.grpProcess.Controls.Add(Me.btnAbort)
        Me.grpProcess.Controls.Add(Me.lblSlash01Text)
        Me.grpProcess.Controls.Add(Me.lblProcessStartTimeText)
        Me.grpProcess.Controls.Add(Me.lblProcessRunTimeText)
        Me.grpProcess.Controls.Add(Me.btnVent)
        Me.grpProcess.Controls.Add(Me.lblProcessStartTime)
        Me.grpProcess.Controls.Add(Me.lblProcessStopTime)
        Me.grpProcess.Controls.Add(Me.lblRecipeNoteText)
        Me.grpProcess.Controls.Add(Me.lblRecipeFileName)
        Me.grpProcess.Controls.Add(Me.lblRecipeNote)
        Me.grpProcess.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpProcess.ForeColor = System.Drawing.Color.Black
        Me.grpProcess.Location = New System.Drawing.Point(4, 527)
        Me.grpProcess.Name = "grpProcess"
        Me.grpProcess.Size = New System.Drawing.Size(1016, 177)
        Me.grpProcess.TabIndex = 98
        Me.grpProcess.TabStop = False
        Me.grpProcess.Text = "»sµ{±±¨î"
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.Color.SkyBlue
        Me.btnEnter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnter.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.ForeColor = System.Drawing.Color.Black
        Me.btnEnter.Location = New System.Drawing.Point(941, 58)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(71, 27)
        Me.btnEnter.TabIndex = 683
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEnter.UseVisualStyleBackColor = False
        '
        'txtRecipeFile
        '
        Me.txtRecipeFile.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecipeFile.Location = New System.Drawing.Point(791, 33)
        Me.txtRecipeFile.Name = "txtRecipeFile"
        Me.txtRecipeFile.Size = New System.Drawing.Size(221, 26)
        Me.txtRecipeFile.TabIndex = 682
        '
        'lblCIMError
        '
        Me.lblCIMError.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCIMError.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCIMError.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.lblCIMError.Location = New System.Drawing.Point(133, 0)
        Me.lblCIMError.Name = "lblCIMError"
        Me.lblCIMError.Size = New System.Drawing.Size(311, 22)
        Me.lblCIMError.TabIndex = 681
        '
        'btnOffLine
        '
        Me.btnOffLine.BackColor = System.Drawing.Color.Red
        Me.btnOffLine.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOffLine.ForeColor = System.Drawing.Color.Black
        Me.btnOffLine.Location = New System.Drawing.Point(934, 54)
        Me.btnOffLine.Name = "btnOffLine"
        Me.btnOffLine.Size = New System.Drawing.Size(80, 35)
        Me.btnOffLine.TabIndex = 680
        Me.btnOffLine.Text = "Off-Line"
        Me.btnOffLine.UseVisualStyleBackColor = False
        Me.btnOffLine.Visible = False
        '
        'btnInLine
        '
        Me.btnInLine.BackColor = System.Drawing.Color.Red
        Me.btnInLine.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInLine.ForeColor = System.Drawing.Color.Black
        Me.btnInLine.Location = New System.Drawing.Point(933, 4)
        Me.btnInLine.Name = "btnInLine"
        Me.btnInLine.Size = New System.Drawing.Size(80, 35)
        Me.btnInLine.TabIndex = 679
        Me.btnInLine.Text = "In-Line"
        Me.btnInLine.UseVisualStyleBackColor = False
        Me.btnInLine.Visible = False
        '
        'lblProcessDataFile
        '
        Me.lblProcessDataFile.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblProcessDataFile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProcessDataFile.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblProcessDataFile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblProcessDataFile.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblProcessDataFile.Location = New System.Drawing.Point(450, 0)
        Me.lblProcessDataFile.Name = "lblProcessDataFile"
        Me.lblProcessDataFile.Size = New System.Drawing.Size(467, 22)
        Me.lblProcessDataFile.TabIndex = 670
        Me.lblProcessDataFile.Text = "Datalog FIle"
        Me.lblProcessDataFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRunNoText
        '
        Me.lblRunNoText.BackColor = System.Drawing.Color.Transparent
        Me.lblRunNoText.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblRunNoText.ForeColor = System.Drawing.Color.Black
        Me.lblRunNoText.Location = New System.Drawing.Point(275, 79)
        Me.lblRunNoText.Name = "lblRunNoText"
        Me.lblRunNoText.Size = New System.Drawing.Size(75, 23)
        Me.lblRunNoText.TabIndex = 669
        Me.lblRunNoText.Text = "»sµ{­p¼Æ:"
        Me.lblRunNoText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRunCount
        '
        Me.lblRunCount.BackColor = System.Drawing.Color.Black
        Me.lblRunCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRunCount.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.lblRunCount.ForeColor = System.Drawing.Color.Lime
        Me.lblRunCount.Location = New System.Drawing.Point(213, 103)
        Me.lblRunCount.Name = "lblRunCount"
        Me.lblRunCount.Size = New System.Drawing.Size(137, 22)
        Me.lblRunCount.TabIndex = 668
        Me.lblRunCount.Text = "00000000"
        Me.lblRunCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBarcodeReader
        '
        Me.btnBarcodeReader.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBarcodeReader.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBarcodeReader.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBarcodeReader.ForeColor = System.Drawing.Color.Black
        Me.btnBarcodeReader.Location = New System.Drawing.Point(792, 31)
        Me.btnBarcodeReader.Name = "btnBarcodeReader"
        Me.btnBarcodeReader.Size = New System.Drawing.Size(112, 41)
        Me.btnBarcodeReader.TabIndex = 547
        Me.btnBarcodeReader.Text = "¨ê¤J±ø½X"
        Me.btnBarcodeReader.UseVisualStyleBackColor = False
        Me.btnBarcodeReader.Visible = False
        '
        'lblModelnameText
        '
        Me.lblModelnameText.BackColor = System.Drawing.Color.Transparent
        Me.lblModelnameText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModelnameText.ForeColor = System.Drawing.Color.Black
        Me.lblModelnameText.Location = New System.Drawing.Point(2, 32)
        Me.lblModelnameText.Name = "lblModelnameText"
        Me.lblModelnameText.Size = New System.Drawing.Size(131, 19)
        Me.lblModelnameText.TabIndex = 545
        Me.lblModelnameText.Text = "³]³Æ½s¸¹:"
        Me.lblModelnameText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblModelname
        '
        Me.lblModelname.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblModelname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblModelname.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lblModelname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblModelname.Location = New System.Drawing.Point(133, 29)
        Me.lblModelname.Name = "lblModelname"
        Me.lblModelname.Size = New System.Drawing.Size(217, 22)
        Me.lblModelname.TabIndex = 546
        '
        'grpDoorControl
        '
        Me.grpDoorControl.Controls.Add(Me.lblCHVac2)
        Me.grpDoorControl.Controls.Add(Me.lbl1ATM02)
        Me.grpDoorControl.Controls.Add(Me.lblTorr03Text)
        Me.grpDoorControl.Controls.Add(Me.btnDoor2Down)
        Me.grpDoorControl.Controls.Add(Me.btnDoor1Down)
        Me.grpDoorControl.Controls.Add(Me.btnDoor2Up)
        Me.grpDoorControl.Controls.Add(Me.btnDoor1Up)
        Me.grpDoorControl.Location = New System.Drawing.Point(792, 83)
        Me.grpDoorControl.Name = "grpDoorControl"
        Me.grpDoorControl.Size = New System.Drawing.Size(221, 89)
        Me.grpDoorControl.TabIndex = 544
        Me.grpDoorControl.TabStop = False
        Me.grpDoorControl.Text = "µÄªù¾Þ§@"
        '
        'lblCHVac2
        '
        Me.lblCHVac2.BackColor = System.Drawing.Color.Black
        Me.lblCHVac2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCHVac2.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lblCHVac2.ForeColor = System.Drawing.Color.Lime
        Me.lblCHVac2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCHVac2.Location = New System.Drawing.Point(68, 20)
        Me.lblCHVac2.Name = "lblCHVac2"
        Me.lblCHVac2.Size = New System.Drawing.Size(96, 26)
        Me.lblCHVac2.TabIndex = 540
        Me.lblCHVac2.Text = "9.90E+09"
        Me.lblCHVac2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl1ATM02
        '
        Me.lbl1ATM02.BackColor = System.Drawing.Color.Red
        Me.lbl1ATM02.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl1ATM02.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1ATM02.ForeColor = System.Drawing.Color.Black
        Me.lbl1ATM02.Location = New System.Drawing.Point(6, 23)
        Me.lbl1ATM02.Name = "lbl1ATM02"
        Me.lbl1ATM02.Size = New System.Drawing.Size(56, 24)
        Me.lbl1ATM02.TabIndex = 542
        Me.lbl1ATM02.Text = "1ATM"
        Me.lbl1ATM02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTorr03Text
        '
        Me.lblTorr03Text.BackColor = System.Drawing.Color.Transparent
        Me.lblTorr03Text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTorr03Text.ForeColor = System.Drawing.Color.Black
        Me.lblTorr03Text.Location = New System.Drawing.Point(169, 26)
        Me.lblTorr03Text.Name = "lblTorr03Text"
        Me.lblTorr03Text.Size = New System.Drawing.Size(51, 19)
        Me.lblTorr03Text.TabIndex = 541
        Me.lblTorr03Text.Text = "Torr"
        Me.lblTorr03Text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnDoor2Down
        '
        Me.btnDoor2Down.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDoor2Down.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDoor2Down.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDoor2Down.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDoor2Down.Location = New System.Drawing.Point(236, 111)
        Me.btnDoor2Down.Name = "btnDoor2Down"
        Me.btnDoor2Down.Size = New System.Drawing.Size(101, 44)
        Me.btnDoor2Down.TabIndex = 536
        Me.btnDoor2Down.Text = "µÄªù 2 ¤U­°"
        Me.btnDoor2Down.UseVisualStyleBackColor = False
        '
        'btnDoor1Down
        '
        Me.btnDoor1Down.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDoor1Down.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDoor1Down.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDoor1Down.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDoor1Down.Location = New System.Drawing.Point(119, 49)
        Me.btnDoor1Down.Name = "btnDoor1Down"
        Me.btnDoor1Down.Size = New System.Drawing.Size(101, 38)
        Me.btnDoor1Down.TabIndex = 535
        Me.btnDoor1Down.Text = "µÄªù 1 ¤U­°"
        Me.btnDoor1Down.UseVisualStyleBackColor = False
        '
        'btnDoor2Up
        '
        Me.btnDoor2Up.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDoor2Up.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDoor2Up.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDoor2Up.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDoor2Up.Location = New System.Drawing.Point(235, 61)
        Me.btnDoor2Up.Name = "btnDoor2Up"
        Me.btnDoor2Up.Size = New System.Drawing.Size(101, 44)
        Me.btnDoor2Up.TabIndex = 534
        Me.btnDoor2Up.Text = "µÄªù 2 ¤W¤É"
        Me.btnDoor2Up.UseVisualStyleBackColor = False
        '
        'btnDoor1Up
        '
        Me.btnDoor1Up.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDoor1Up.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDoor1Up.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDoor1Up.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDoor1Up.Location = New System.Drawing.Point(5, 49)
        Me.btnDoor1Up.Name = "btnDoor1Up"
        Me.btnDoor1Up.Size = New System.Drawing.Size(101, 38)
        Me.btnDoor1Up.TabIndex = 533
        Me.btnDoor1Up.Text = "µÄªù 1 ¤W¤É"
        Me.btnDoor1Up.UseVisualStyleBackColor = False
        '
        'lblCUPUsage
        '
        Me.lblCUPUsage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCUPUsage.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCUPUsage.ForeColor = System.Drawing.Color.Red
        Me.lblCUPUsage.Location = New System.Drawing.Point(372, 98)
        Me.lblCUPUsage.Name = "lblCUPUsage"
        Me.lblCUPUsage.Size = New System.Drawing.Size(59, 24)
        Me.lblCUPUsage.TabIndex = 525
        Me.lblCUPUsage.Text = "50%"
        Me.lblCUPUsage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCUPUsage.Visible = False
        '
        'lblBasePressureText
        '
        Me.lblBasePressureText.BackColor = System.Drawing.Color.Transparent
        Me.lblBasePressureText.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.lblBasePressureText.ForeColor = System.Drawing.Color.Black
        Me.lblBasePressureText.Location = New System.Drawing.Point(2, 81)
        Me.lblBasePressureText.Name = "lblBasePressureText"
        Me.lblBasePressureText.Size = New System.Drawing.Size(131, 19)
        Me.lblBasePressureText.TabIndex = 2
        Me.lblBasePressureText.Text = "­I´ºÀ£¤O:"
        Me.lblBasePressureText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblWaferSize
        '
        Me.lblWaferSize.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblWaferSize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWaferSize.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lblWaferSize.ForeColor = System.Drawing.Color.Black
        Me.lblWaferSize.Location = New System.Drawing.Point(133, 103)
        Me.lblWaferSize.Name = "lblWaferSize"
        Me.lblWaferSize.Size = New System.Drawing.Size(52, 22)
        Me.lblWaferSize.TabIndex = 86
        Me.lblWaferSize.Text = "0"
        Me.lblWaferSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWafreSizeText
        '
        Me.lblWafreSizeText.BackColor = System.Drawing.Color.Transparent
        Me.lblWafreSizeText.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.lblWafreSizeText.ForeColor = System.Drawing.Color.Black
        Me.lblWafreSizeText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblWafreSizeText.Location = New System.Drawing.Point(2, 105)
        Me.lblWafreSizeText.Name = "lblWafreSizeText"
        Me.lblWafreSizeText.Size = New System.Drawing.Size(131, 19)
        Me.lblWafreSizeText.TabIndex = 517
        Me.lblWafreSizeText.Text = "´¹¶ê¤Ø¤o(in):"
        Me.lblWafreSizeText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBasePressureSet
        '
        Me.lblBasePressureSet.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblBasePressureSet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBasePressureSet.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lblBasePressureSet.ForeColor = System.Drawing.Color.Black
        Me.lblBasePressureSet.Location = New System.Drawing.Point(133, 79)
        Me.lblBasePressureSet.Name = "lblBasePressureSet"
        Me.lblBasePressureSet.Size = New System.Drawing.Size(81, 22)
        Me.lblBasePressureSet.TabIndex = 5
        Me.lblBasePressureSet.Text = "5.0E-2"
        Me.lblBasePressureSet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRunProcess
        '
        Me.btnRunProcess.BackColor = System.Drawing.Color.Lavender
        Me.btnRunProcess.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRunProcess.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRunProcess.ForeColor = System.Drawing.Color.Black
        Me.btnRunProcess.Image = Global.CELLO.My.Resources.Resources.Button_Right1
        Me.btnRunProcess.Location = New System.Drawing.Point(359, 124)
        Me.btnRunProcess.Name = "btnRunProcess"
        Me.btnRunProcess.Size = New System.Drawing.Size(123, 47)
        Me.btnRunProcess.TabIndex = 524
        Me.btnRunProcess.Text = "°õ¦æ"
        Me.btnRunProcess.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRunProcess.UseVisualStyleBackColor = False
        '
        'lblTorr01Text
        '
        Me.lblTorr01Text.BackColor = System.Drawing.Color.Transparent
        Me.lblTorr01Text.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTorr01Text.ForeColor = System.Drawing.Color.Black
        Me.lblTorr01Text.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTorr01Text.Location = New System.Drawing.Point(220, 81)
        Me.lblTorr01Text.Name = "lblTorr01Text"
        Me.lblTorr01Text.Size = New System.Drawing.Size(45, 19)
        Me.lblTorr01Text.TabIndex = 357
        Me.lblTorr01Text.Text = "Torr"
        Me.lblTorr01Text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pgbReadCurve
        '
        Me.pgbReadCurve.Location = New System.Drawing.Point(487, 62)
        Me.pgbReadCurve.Name = "pgbReadCurve"
        Me.pgbReadCurve.Size = New System.Drawing.Size(303, 10)
        Me.pgbReadCurve.TabIndex = 522
        Me.pgbReadCurve.Visible = False
        '
        'lblProcessStatus
        '
        Me.lblProcessStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblProcessStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProcessStatus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcessStatus.ForeColor = System.Drawing.Color.Red
        Me.lblProcessStatus.Location = New System.Drawing.Point(488, 74)
        Me.lblProcessStatus.Name = "lblProcessStatus"
        Me.lblProcessStatus.Size = New System.Drawing.Size(303, 49)
        Me.lblProcessStatus.TabIndex = 191
        '
        'btnLoadRecipe
        '
        Me.btnLoadRecipe.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLoadRecipe.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadRecipe.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.btnLoadRecipe.ForeColor = System.Drawing.Color.Black
        Me.btnLoadRecipe.Location = New System.Drawing.Point(359, 33)
        Me.btnLoadRecipe.Name = "btnLoadRecipe"
        Me.btnLoadRecipe.Size = New System.Drawing.Size(123, 39)
        Me.btnLoadRecipe.TabIndex = 87
        Me.btnLoadRecipe.Text = "¸ü¤J°t¤è"
        Me.btnLoadRecipe.UseVisualStyleBackColor = False
        '
        'lblMessageText
        '
        Me.lblMessageText.BackColor = System.Drawing.Color.Transparent
        Me.lblMessageText.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.lblMessageText.ForeColor = System.Drawing.Color.Black
        Me.lblMessageText.Location = New System.Drawing.Point(356, 83)
        Me.lblMessageText.Name = "lblMessageText"
        Me.lblMessageText.Size = New System.Drawing.Size(131, 19)
        Me.lblMessageText.TabIndex = 65
        Me.lblMessageText.Text = "°T®§:"
        Me.lblMessageText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblProcessRunTime
        '
        Me.lblProcessRunTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblProcessRunTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProcessRunTime.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcessRunTime.Location = New System.Drawing.Point(133, 151)
        Me.lblProcessRunTime.Name = "lblProcessRunTime"
        Me.lblProcessRunTime.Size = New System.Drawing.Size(217, 22)
        Me.lblProcessRunTime.TabIndex = 88
        Me.lblProcessRunTime.Text = "00:00:00"
        Me.lblProcessRunTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAbort
        '
        Me.btnAbort.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAbort.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAbort.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbort.ForeColor = System.Drawing.Color.Black
        Me.btnAbort.Image = Global.CELLO.My.Resources.Resources.Button_Close1
        Me.btnAbort.Location = New System.Drawing.Point(522, 124)
        Me.btnAbort.Name = "btnAbort"
        Me.btnAbort.Size = New System.Drawing.Size(115, 47)
        Me.btnAbort.TabIndex = 57
        Me.btnAbort.Text = "©ñ±ó"
        Me.btnAbort.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAbort.UseVisualStyleBackColor = False
        '
        'lblSlash01Text
        '
        Me.lblSlash01Text.BackColor = System.Drawing.Color.Transparent
        Me.lblSlash01Text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSlash01Text.ForeColor = System.Drawing.Color.Black
        Me.lblSlash01Text.Location = New System.Drawing.Point(234, 130)
        Me.lblSlash01Text.Name = "lblSlash01Text"
        Me.lblSlash01Text.Size = New System.Drawing.Size(14, 19)
        Me.lblSlash01Text.TabIndex = 87
        Me.lblSlash01Text.Text = "/"
        Me.lblSlash01Text.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblProcessStartTimeText
        '
        Me.lblProcessStartTimeText.BackColor = System.Drawing.Color.Transparent
        Me.lblProcessStartTimeText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcessStartTimeText.ForeColor = System.Drawing.Color.Black
        Me.lblProcessStartTimeText.Location = New System.Drawing.Point(2, 130)
        Me.lblProcessStartTimeText.Name = "lblProcessStartTimeText"
        Me.lblProcessStartTimeText.Size = New System.Drawing.Size(131, 19)
        Me.lblProcessStartTimeText.TabIndex = 87
        Me.lblProcessStartTimeText.Text = "¶}©l/°±¤î®É¶¡:"
        Me.lblProcessStartTimeText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblProcessRunTimeText
        '
        Me.lblProcessRunTimeText.BackColor = System.Drawing.Color.Transparent
        Me.lblProcessRunTimeText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcessRunTimeText.ForeColor = System.Drawing.Color.Black
        Me.lblProcessRunTimeText.Location = New System.Drawing.Point(2, 154)
        Me.lblProcessRunTimeText.Name = "lblProcessRunTimeText"
        Me.lblProcessRunTimeText.Size = New System.Drawing.Size(131, 19)
        Me.lblProcessRunTimeText.TabIndex = 87
        Me.lblProcessRunTimeText.Text = "Á`°õ¦æ®É¶¡:"
        Me.lblProcessRunTimeText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnVent
        '
        Me.btnVent.BackColor = System.Drawing.Color.LavenderBlush
        Me.btnVent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVent.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVent.ForeColor = System.Drawing.Color.Black
        Me.btnVent.Image = Global.CELLO.My.Resources.Resources.Button_Refresh1
        Me.btnVent.Location = New System.Drawing.Point(670, 124)
        Me.btnVent.Name = "btnVent"
        Me.btnVent.Size = New System.Drawing.Size(115, 47)
        Me.btnVent.TabIndex = 27
        Me.btnVent.Text = "¯}¯uªÅ"
        Me.btnVent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVent.UseVisualStyleBackColor = False
        '
        'lblProcessStartTime
        '
        Me.lblProcessStartTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblProcessStartTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProcessStartTime.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcessStartTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblProcessStartTime.Location = New System.Drawing.Point(133, 127)
        Me.lblProcessStartTime.Name = "lblProcessStartTime"
        Me.lblProcessStartTime.Size = New System.Drawing.Size(96, 22)
        Me.lblProcessStartTime.TabIndex = 4
        Me.lblProcessStartTime.Text = "00:00:00"
        Me.lblProcessStartTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProcessStopTime
        '
        Me.lblProcessStopTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblProcessStopTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProcessStopTime.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcessStopTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblProcessStopTime.Location = New System.Drawing.Point(254, 127)
        Me.lblProcessStopTime.Name = "lblProcessStopTime"
        Me.lblProcessStopTime.Size = New System.Drawing.Size(96, 22)
        Me.lblProcessStopTime.TabIndex = 4
        Me.lblProcessStopTime.Text = "00:00:00"
        Me.lblProcessStopTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRecipeNoteText
        '
        Me.lblRecipeNoteText.BackColor = System.Drawing.Color.Transparent
        Me.lblRecipeNoteText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecipeNoteText.ForeColor = System.Drawing.Color.Black
        Me.lblRecipeNoteText.Location = New System.Drawing.Point(2, 57)
        Me.lblRecipeNoteText.Name = "lblRecipeNoteText"
        Me.lblRecipeNoteText.Size = New System.Drawing.Size(131, 19)
        Me.lblRecipeNoteText.TabIndex = 0
        Me.lblRecipeNoteText.Text = "°t¤èµù¸Ñ:"
        Me.lblRecipeNoteText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRecipeFileName
        '
        Me.lblRecipeFileName.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblRecipeFileName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRecipeFileName.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.lblRecipeFileName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblRecipeFileName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRecipeFileName.Location = New System.Drawing.Point(487, 32)
        Me.lblRecipeFileName.Name = "lblRecipeFileName"
        Me.lblRecipeFileName.Size = New System.Drawing.Size(303, 27)
        Me.lblRecipeFileName.TabIndex = 3
        Me.lblRecipeFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRecipeNote
        '
        Me.lblRecipeNote.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblRecipeNote.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRecipeNote.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lblRecipeNote.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblRecipeNote.Location = New System.Drawing.Point(133, 54)
        Me.lblRecipeNote.Name = "lblRecipeNote"
        Me.lblRecipeNote.Size = New System.Drawing.Size(217, 22)
        Me.lblRecipeNote.TabIndex = 3
        '
        'pnlProcessCSelect
        '
        Me.pnlProcessCSelect.AutoScroll = True
        Me.pnlProcessCSelect.BackColor = System.Drawing.Color.Transparent
        Me.pnlProcessCSelect.Controls.Add(Me.btnShowSeriesName)
        Me.pnlProcessCSelect.Controls.Add(Me.btnCurveFreeze)
        Me.pnlProcessCSelect.Controls.Add(Me.lblProcessStepStatus)
        Me.pnlProcessCSelect.Controls.Add(Me.lblProcessStepText)
        Me.pnlProcessCSelect.Controls.Add(Me.lblHoldTime)
        Me.pnlProcessCSelect.Controls.Add(Me.lblHoldTime02Text)
        Me.pnlProcessCSelect.Location = New System.Drawing.Point(5, 373)
        Me.pnlProcessCSelect.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlProcessCSelect.Name = "pnlProcessCSelect"
        Me.pnlProcessCSelect.Size = New System.Drawing.Size(449, 103)
        Me.pnlProcessCSelect.TabIndex = 522
        Me.pnlProcessCSelect.Visible = False
        '
        'btnShowSeriesName
        '
        Me.btnShowSeriesName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnShowSeriesName.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btnShowSeriesName.Location = New System.Drawing.Point(252, 57)
        Me.btnShowSeriesName.Name = "btnShowSeriesName"
        Me.btnShowSeriesName.Size = New System.Drawing.Size(117, 34)
        Me.btnShowSeriesName.TabIndex = 523
        Me.btnShowSeriesName.Text = "¦±½u¿ï¾Ü"
        Me.btnShowSeriesName.UseVisualStyleBackColor = False
        '
        'btnCurveFreeze
        '
        Me.btnCurveFreeze.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCurveFreeze.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btnCurveFreeze.Location = New System.Drawing.Point(24, 10)
        Me.btnCurveFreeze.Name = "btnCurveFreeze"
        Me.btnCurveFreeze.Size = New System.Drawing.Size(97, 34)
        Me.btnCurveFreeze.TabIndex = 524
        Me.btnCurveFreeze.Text = "¦±½u­áµ²"
        Me.btnCurveFreeze.UseVisualStyleBackColor = False
        '
        'lblProcessStepStatus
        '
        Me.lblProcessStepStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblProcessStepStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProcessStepStatus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcessStepStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblProcessStepStatus.Location = New System.Drawing.Point(220, 15)
        Me.lblProcessStepStatus.Name = "lblProcessStepStatus"
        Me.lblProcessStepStatus.Size = New System.Drawing.Size(96, 24)
        Me.lblProcessStepStatus.TabIndex = 4
        Me.lblProcessStepStatus.Text = "0/0"
        Me.lblProcessStepStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProcessStepText
        '
        Me.lblProcessStepText.BackColor = System.Drawing.Color.Transparent
        Me.lblProcessStepText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcessStepText.ForeColor = System.Drawing.Color.Black
        Me.lblProcessStepText.Location = New System.Drawing.Point(89, 18)
        Me.lblProcessStepText.Name = "lblProcessStepText"
        Me.lblProcessStepText.Size = New System.Drawing.Size(131, 19)
        Me.lblProcessStepText.TabIndex = 1
        Me.lblProcessStepText.Text = "¨BÆJ:"
        Me.lblProcessStepText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHoldTime
        '
        Me.lblHoldTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblHoldTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHoldTime.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoldTime.ForeColor = System.Drawing.Color.Red
        Me.lblHoldTime.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblHoldTime.Location = New System.Drawing.Point(135, 73)
        Me.lblHoldTime.Name = "lblHoldTime"
        Me.lblHoldTime.Size = New System.Drawing.Size(96, 24)
        Me.lblHoldTime.TabIndex = 65
        Me.lblHoldTime.Text = "0/0"
        Me.lblHoldTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHoldTime02Text
        '
        Me.lblHoldTime02Text.BackColor = System.Drawing.Color.Transparent
        Me.lblHoldTime02Text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoldTime02Text.ForeColor = System.Drawing.Color.Black
        Me.lblHoldTime02Text.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblHoldTime02Text.Location = New System.Drawing.Point(4, 76)
        Me.lblHoldTime02Text.Name = "lblHoldTime02Text"
        Me.lblHoldTime02Text.Size = New System.Drawing.Size(131, 19)
        Me.lblHoldTime02Text.TabIndex = 1
        Me.lblHoldTime02Text.Text = "«O«ù®É¶¡:"
        Me.lblHoldTime02Text.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCursorValue
        '
        Me.lblCursorValue.BackColor = System.Drawing.Color.Black
        Me.lblCursorValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCursorValue.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCursorValue.ForeColor = System.Drawing.Color.Lime
        Me.lblCursorValue.Location = New System.Drawing.Point(749, 8)
        Me.lblCursorValue.Name = "lblCursorValue"
        Me.lblCursorValue.Size = New System.Drawing.Size(257, 34)
        Me.lblCursorValue.TabIndex = 538
        Me.lblCursorValue.Text = "[0,0]"
        Me.lblCursorValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPrintCurve
        '
        Me.btnPrintCurve.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPrintCurve.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btnPrintCurve.Location = New System.Drawing.Point(460, 8)
        Me.btnPrintCurve.Name = "btnPrintCurve"
        Me.btnPrintCurve.Size = New System.Drawing.Size(59, 34)
        Me.btnPrintCurve.TabIndex = 520
        Me.btnPrintCurve.Text = "¦C¦L"
        Me.btnPrintCurve.UseVisualStyleBackColor = False
        '
        'btnCurveReset
        '
        Me.btnCurveReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCurveReset.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btnCurveReset.Location = New System.Drawing.Point(670, 8)
        Me.btnCurveReset.Name = "btnCurveReset"
        Me.btnCurveReset.Size = New System.Drawing.Size(65, 34)
        Me.btnCurveReset.TabIndex = 519
        Me.btnCurveReset.Text = "­«³]"
        Me.btnCurveReset.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'tabProcessDataCurve
        '
        Me.tabProcessDataCurve.Controls.Add(Me.TabPagePlateData)
        Me.tabProcessDataCurve.Controls.Add(Me.TabPageCurve)
        Me.tabProcessDataCurve.Controls.Add(Me.TabPageData)
        Me.tabProcessDataCurve.Controls.Add(Me.TabPageVacuum)
        Me.tabProcessDataCurve.Controls.Add(Me.TabPagePaint)
        Me.tabProcessDataCurve.Controls.Add(Me.tpCIMInput)
        Me.tabProcessDataCurve.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabProcessDataCurve.HotTrack = True
        Me.tabProcessDataCurve.ItemSize = New System.Drawing.Size(124, 30)
        Me.tabProcessDataCurve.Location = New System.Drawing.Point(0, 0)
        Me.tabProcessDataCurve.Margin = New System.Windows.Forms.Padding(0)
        Me.tabProcessDataCurve.Name = "tabProcessDataCurve"
        Me.tabProcessDataCurve.Padding = New System.Drawing.Point(20, 3)
        Me.tabProcessDataCurve.SelectedIndex = 0
        Me.tabProcessDataCurve.Size = New System.Drawing.Size(1024, 527)
        Me.tabProcessDataCurve.TabIndex = 525
        '
        'TabPagePlateData
        '
        Me.TabPagePlateData.BackColor = System.Drawing.SystemColors.Control
        Me.TabPagePlateData.Controls.Add(Me.flwProcess)
        Me.TabPagePlateData.Location = New System.Drawing.Point(4, 34)
        Me.TabPagePlateData.Margin = New System.Windows.Forms.Padding(0)
        Me.TabPagePlateData.Name = "TabPagePlateData"
        Me.TabPagePlateData.Size = New System.Drawing.Size(1016, 489)
        Me.TabPagePlateData.TabIndex = 2
        Me.TabPagePlateData.Text = "À£ÀY¸ê°T"
        '
        'flwProcess
        '
        Me.flwProcess.AutoScroll = True
        Me.flwProcess.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.flwProcess.Location = New System.Drawing.Point(0, 0)
        Me.flwProcess.Margin = New System.Windows.Forms.Padding(0)
        Me.flwProcess.Name = "flwProcess"
        Me.flwProcess.Size = New System.Drawing.Size(1016, 486)
        Me.flwProcess.TabIndex = 183
        '
        'TabPageCurve
        '
        Me.TabPageCurve.BackColor = System.Drawing.SystemColors.Control
        Me.TabPageCurve.Controls.Add(Me.flwProcessCurve)
        Me.TabPageCurve.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageCurve.Location = New System.Drawing.Point(4, 34)
        Me.TabPageCurve.Name = "TabPageCurve"
        Me.TabPageCurve.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageCurve.Size = New System.Drawing.Size(1016, 489)
        Me.TabPageCurve.TabIndex = 0
        Me.TabPageCurve.Text = "§Y®É¦±½u"
        '
        'flwProcessCurve
        '
        Me.flwProcessCurve.AutoScroll = True
        Me.flwProcessCurve.BackColor = System.Drawing.SystemColors.Control
        Me.flwProcessCurve.Location = New System.Drawing.Point(0, 0)
        Me.flwProcessCurve.Margin = New System.Windows.Forms.Padding(0)
        Me.flwProcessCurve.Name = "flwProcessCurve"
        Me.flwProcessCurve.Size = New System.Drawing.Size(1016, 490)
        Me.flwProcessCurve.TabIndex = 539
        '
        'TabPageData
        '
        Me.TabPageData.BackColor = System.Drawing.SystemColors.Control
        Me.TabPageData.Controls.Add(Me.flwProcessData)
        Me.TabPageData.Controls.Add(Me.pnlRecipe)
        Me.TabPageData.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageData.Location = New System.Drawing.Point(4, 34)
        Me.TabPageData.Name = "TabPageData"
        Me.TabPageData.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageData.Size = New System.Drawing.Size(1016, 489)
        Me.TabPageData.TabIndex = 1
        Me.TabPageData.Text = "°t¤è¸ê®Æ"
        '
        'flwProcessData
        '
        Me.flwProcessData.AutoScroll = True
        Me.flwProcessData.Location = New System.Drawing.Point(0, 0)
        Me.flwProcessData.Margin = New System.Windows.Forms.Padding(0)
        Me.flwProcessData.Name = "flwProcessData"
        Me.flwProcessData.Size = New System.Drawing.Size(818, 487)
        Me.flwProcessData.TabIndex = 526
        '
        'pnlRecipe
        '
        Me.pnlRecipe.Controls.Add(Me.grpProcessOption)
        Me.pnlRecipe.Controls.Add(Me.grpProcessCondition)
        Me.pnlRecipe.Enabled = False
        Me.pnlRecipe.Location = New System.Drawing.Point(821, 3)
        Me.pnlRecipe.Name = "pnlRecipe"
        Me.pnlRecipe.Size = New System.Drawing.Size(192, 483)
        Me.pnlRecipe.TabIndex = 525
        '
        'grpProcessOption
        '
        Me.grpProcessOption.Controls.Add(Me.pnlPurgeCooling)
        Me.grpProcessOption.Controls.Add(Me.chkAutoDoorOpen)
        Me.grpProcessOption.Controls.Add(Me.chkAfterPurge)
        Me.grpProcessOption.Controls.Add(Me.chkVacuumMode)
        Me.grpProcessOption.Controls.Add(Me.chkAutoVent)
        Me.grpProcessOption.Controls.Add(Me.chkKeepBonding)
        Me.grpProcessOption.Controls.Add(Me.chkBondBeforeVacuum)
        Me.grpProcessOption.Controls.Add(Me.chkVacuumPurge)
        Me.grpProcessOption.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.grpProcessOption.ForeColor = System.Drawing.Color.Black
        Me.grpProcessOption.Location = New System.Drawing.Point(0, 3)
        Me.grpProcessOption.Name = "grpProcessOption"
        Me.grpProcessOption.Size = New System.Drawing.Size(184, 347)
        Me.grpProcessOption.TabIndex = 526
        Me.grpProcessOption.TabStop = False
        Me.grpProcessOption.Text = "»sµ{¿ï¶µ"
        '
        'pnlPurgeCooling
        '
        Me.pnlPurgeCooling.Controls.Add(Me.lblAfterPurgeTemp)
        Me.pnlPurgeCooling.Controls.Add(Me.chkPurgeKeepBonding)
        Me.pnlPurgeCooling.Controls.Add(Me.lblPurgeOffText)
        Me.pnlPurgeCooling.Controls.Add(Me.txtPurgeOFFTime)
        Me.pnlPurgeCooling.Controls.Add(Me.lblPurgeOnText)
        Me.pnlPurgeCooling.Controls.Add(Me.txtPurgeONTime)
        Me.pnlPurgeCooling.Controls.Add(Me.PictureBox1)
        Me.pnlPurgeCooling.Controls.Add(Me.txtAfterPurgeTemp)
        Me.pnlPurgeCooling.Controls.Add(Me.chkPurgeCooling)
        Me.pnlPurgeCooling.Location = New System.Drawing.Point(3, 158)
        Me.pnlPurgeCooling.Name = "pnlPurgeCooling"
        Me.pnlPurgeCooling.Size = New System.Drawing.Size(186, 189)
        Me.pnlPurgeCooling.TabIndex = 632
        '
        'lblAfterPurgeTemp
        '
        Me.lblAfterPurgeTemp.BackColor = System.Drawing.Color.Transparent
        Me.lblAfterPurgeTemp.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblAfterPurgeTemp.ForeColor = System.Drawing.Color.Black
        Me.lblAfterPurgeTemp.Location = New System.Drawing.Point(2, 22)
        Me.lblAfterPurgeTemp.Name = "lblAfterPurgeTemp"
        Me.lblAfterPurgeTemp.Size = New System.Drawing.Size(172, 20)
        Me.lblAfterPurgeTemp.TabIndex = 631
        Me.lblAfterPurgeTemp.Text = "¶}©lPurge ·Å«×:"
        Me.lblAfterPurgeTemp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkPurgeKeepBonding
        '
        Me.chkPurgeKeepBonding.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.chkPurgeKeepBonding.Location = New System.Drawing.Point(4, 163)
        Me.chkPurgeKeepBonding.Name = "chkPurgeKeepBonding"
        Me.chkPurgeKeepBonding.Size = New System.Drawing.Size(160, 20)
        Me.chkPurgeKeepBonding.TabIndex = 630
        Me.chkPurgeKeepBonding.Text = "Purge ®É«ùÀ£"
        Me.chkPurgeKeepBonding.UseVisualStyleBackColor = True
        '
        'lblPurgeOffText
        '
        Me.lblPurgeOffText.BackColor = System.Drawing.Color.Transparent
        Me.lblPurgeOffText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblPurgeOffText.ForeColor = System.Drawing.Color.Black
        Me.lblPurgeOffText.Location = New System.Drawing.Point(2, 117)
        Me.lblPurgeOffText.Name = "lblPurgeOffText"
        Me.lblPurgeOffText.Size = New System.Drawing.Size(172, 20)
        Me.lblPurgeOffText.TabIndex = 628
        Me.lblPurgeOffText.Text = "©â®ð®É¶¡(s)"
        Me.lblPurgeOffText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPurgeOFFTime
        '
        Me.txtPurgeOFFTime.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtPurgeOFFTime.Location = New System.Drawing.Point(98, 140)
        Me.txtPurgeOFFTime.Name = "txtPurgeOFFTime"
        Me.txtPurgeOFFTime.Size = New System.Drawing.Size(55, 22)
        Me.txtPurgeOFFTime.TabIndex = 627
        Me.txtPurgeOFFTime.Text = "15"
        Me.txtPurgeOFFTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPurgeOnText
        '
        Me.lblPurgeOnText.BackColor = System.Drawing.Color.Transparent
        Me.lblPurgeOnText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblPurgeOnText.ForeColor = System.Drawing.Color.Black
        Me.lblPurgeOnText.Location = New System.Drawing.Point(2, 71)
        Me.lblPurgeOnText.Name = "lblPurgeOnText"
        Me.lblPurgeOnText.Size = New System.Drawing.Size(172, 20)
        Me.lblPurgeOnText.TabIndex = 629
        Me.lblPurgeOnText.Text = "¶i®ð®É¶¡(s)"
        Me.lblPurgeOnText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPurgeONTime
        '
        Me.txtPurgeONTime.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtPurgeONTime.Location = New System.Drawing.Point(98, 94)
        Me.txtPurgeONTime.Name = "txtPurgeONTime"
        Me.txtPurgeONTime.Size = New System.Drawing.Size(55, 22)
        Me.txtPurgeONTime.TabIndex = 626
        Me.txtPurgeONTime.Text = "3"
        Me.txtPurgeONTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.CELLO.My.Resources.Resources.tempc
        Me.PictureBox1.Location = New System.Drawing.Point(148, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(22, 22)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 625
        Me.PictureBox1.TabStop = False
        '
        'txtAfterPurgeTemp
        '
        Me.txtAfterPurgeTemp.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtAfterPurgeTemp.Location = New System.Drawing.Point(98, 45)
        Me.txtAfterPurgeTemp.Name = "txtAfterPurgeTemp"
        Me.txtAfterPurgeTemp.Size = New System.Drawing.Size(44, 22)
        Me.txtAfterPurgeTemp.TabIndex = 624
        Me.txtAfterPurgeTemp.Text = "200"
        Me.txtAfterPurgeTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chkPurgeCooling
        '
        Me.chkPurgeCooling.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.chkPurgeCooling.Location = New System.Drawing.Point(5, 2)
        Me.chkPurgeCooling.Name = "chkPurgeCooling"
        Me.chkPurgeCooling.Size = New System.Drawing.Size(153, 20)
        Me.chkPurgeCooling.TabIndex = 623
        Me.chkPurgeCooling.Text = "µ²§ô«áPurge"
        Me.chkPurgeCooling.UseVisualStyleBackColor = True
        '
        'chkAutoDoorOpen
        '
        Me.chkAutoDoorOpen.Checked = True
        Me.chkAutoDoorOpen.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAutoDoorOpen.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.chkAutoDoorOpen.Location = New System.Drawing.Point(8, 100)
        Me.chkAutoDoorOpen.Name = "chkAutoDoorOpen"
        Me.chkAutoDoorOpen.Size = New System.Drawing.Size(153, 20)
        Me.chkAutoDoorOpen.TabIndex = 522
        Me.chkAutoDoorOpen.Text = "µ²§ô«á¶}ªù"
        Me.chkAutoDoorOpen.UseVisualStyleBackColor = True
        '
        'chkAfterPurge
        '
        Me.chkAfterPurge.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.chkAfterPurge.Location = New System.Drawing.Point(8, 120)
        Me.chkAfterPurge.Name = "chkAfterPurge"
        Me.chkAfterPurge.Size = New System.Drawing.Size(153, 20)
        Me.chkAfterPurge.TabIndex = 521
        Me.chkAfterPurge.Text = "µ²§ô«áPurge"
        Me.chkAfterPurge.UseVisualStyleBackColor = True
        '
        'chkVacuumMode
        '
        Me.chkVacuumMode.Checked = True
        Me.chkVacuumMode.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkVacuumMode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.chkVacuumMode.Location = New System.Drawing.Point(8, 140)
        Me.chkVacuumMode.Name = "chkVacuumMode"
        Me.chkVacuumMode.Size = New System.Drawing.Size(153, 20)
        Me.chkVacuumMode.TabIndex = 517
        Me.chkVacuumMode.Text = "¯uªÅÀ£¦X"
        Me.chkVacuumMode.UseVisualStyleBackColor = True
        '
        'chkAutoVent
        '
        Me.chkAutoVent.Checked = True
        Me.chkAutoVent.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAutoVent.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.chkAutoVent.Location = New System.Drawing.Point(8, 80)
        Me.chkAutoVent.Name = "chkAutoVent"
        Me.chkAutoVent.Size = New System.Drawing.Size(153, 20)
        Me.chkAutoVent.TabIndex = 520
        Me.chkAutoVent.Text = "µ²§ô«áVENT"
        Me.chkAutoVent.UseVisualStyleBackColor = True
        '
        'chkKeepBonding
        '
        Me.chkKeepBonding.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.chkKeepBonding.Location = New System.Drawing.Point(8, 60)
        Me.chkKeepBonding.Name = "chkKeepBonding"
        Me.chkKeepBonding.Size = New System.Drawing.Size(153, 20)
        Me.chkKeepBonding.TabIndex = 514
        Me.chkKeepBonding.Text = "µ²§ô«á«ùÀ£ "
        Me.chkKeepBonding.UseVisualStyleBackColor = True
        '
        'chkBondBeforeVacuum
        '
        Me.chkBondBeforeVacuum.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.chkBondBeforeVacuum.Location = New System.Drawing.Point(8, 40)
        Me.chkBondBeforeVacuum.Name = "chkBondBeforeVacuum"
        Me.chkBondBeforeVacuum.Size = New System.Drawing.Size(153, 20)
        Me.chkBondBeforeVacuum.TabIndex = 516
        Me.chkBondBeforeVacuum.Text = "©â®ð«e¹wÀ£"
        Me.chkBondBeforeVacuum.UseVisualStyleBackColor = True
        '
        'chkVacuumPurge
        '
        Me.chkVacuumPurge.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.chkVacuumPurge.Location = New System.Drawing.Point(8, 20)
        Me.chkVacuumPurge.Name = "chkVacuumPurge"
        Me.chkVacuumPurge.Size = New System.Drawing.Size(153, 20)
        Me.chkVacuumPurge.TabIndex = 515
        Me.chkVacuumPurge.Text = "©â®ð®ÉPurge"
        Me.chkVacuumPurge.UseVisualStyleBackColor = True
        '
        'grpProcessCondition
        '
        Me.grpProcessCondition.Controls.Add(Me.radPress)
        Me.grpProcessCondition.Controls.Add(Me.radTemp)
        Me.grpProcessCondition.Controls.Add(Me.radBoth)
        Me.grpProcessCondition.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.grpProcessCondition.ForeColor = System.Drawing.Color.Black
        Me.grpProcessCondition.Location = New System.Drawing.Point(3, 356)
        Me.grpProcessCondition.Name = "grpProcessCondition"
        Me.grpProcessCondition.Size = New System.Drawing.Size(182, 124)
        Me.grpProcessCondition.TabIndex = 524
        Me.grpProcessCondition.TabStop = False
        Me.grpProcessCondition.Text = "»sµ{Ä~Äò±ø¥ó"
        '
        'radPress
        '
        Me.radPress.AutoSize = True
        Me.radPress.Location = New System.Drawing.Point(25, 86)
        Me.radPress.Name = "radPress"
        Me.radPress.Size = New System.Drawing.Size(54, 20)
        Me.radPress.TabIndex = 0
        Me.radPress.Text = "À£¤O"
        Me.radPress.UseVisualStyleBackColor = True
        '
        'radTemp
        '
        Me.radTemp.AutoSize = True
        Me.radTemp.Location = New System.Drawing.Point(25, 56)
        Me.radTemp.Name = "radTemp"
        Me.radTemp.Size = New System.Drawing.Size(54, 20)
        Me.radTemp.TabIndex = 0
        Me.radTemp.Text = "·Å«×"
        Me.radTemp.UseVisualStyleBackColor = True
        '
        'radBoth
        '
        Me.radBoth.AutoSize = True
        Me.radBoth.Checked = True
        Me.radBoth.Location = New System.Drawing.Point(25, 26)
        Me.radBoth.Name = "radBoth"
        Me.radBoth.Size = New System.Drawing.Size(54, 20)
        Me.radBoth.TabIndex = 0
        Me.radBoth.TabStop = True
        Me.radBoth.Text = "¦P®É"
        Me.radBoth.UseVisualStyleBackColor = True
        '
        'TabPageVacuum
        '
        Me.TabPageVacuum.BackColor = System.Drawing.SystemColors.Control
        Me.TabPageVacuum.Controls.Add(Me.btnPullerClose)
        Me.TabPageVacuum.Controls.Add(Me.btnChamberLight)
        Me.TabPageVacuum.Controls.Add(Me.lblCursorValue)
        Me.TabPageVacuum.Controls.Add(Me.btnSaveAs)
        Me.TabPageVacuum.Controls.Add(Me.Panel2)
        Me.TabPageVacuum.Controls.Add(Me.pnlProcessCSelect)
        Me.TabPageVacuum.Controls.Add(Me.btnCurveReset)
        Me.TabPageVacuum.Controls.Add(Me.btnPrintCurve)
        Me.TabPageVacuum.Controls.Add(Me.pnlVacuumChart)
        Me.TabPageVacuum.Location = New System.Drawing.Point(4, 34)
        Me.TabPageVacuum.Name = "TabPageVacuum"
        Me.TabPageVacuum.Size = New System.Drawing.Size(1016, 489)
        Me.TabPageVacuum.TabIndex = 3
        Me.TabPageVacuum.Text = "¯uªÅ©â®ð¹Ï"
        '
        'btnPullerClose
        '
        Me.btnPullerClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPullerClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPullerClose.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPullerClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPullerClose.Location = New System.Drawing.Point(627, 437)
        Me.btnPullerClose.Name = "btnPullerClose"
        Me.btnPullerClose.Size = New System.Drawing.Size(116, 44)
        Me.btnPullerClose.TabIndex = 545
        Me.btnPullerClose.Text = "ªù©Ô¬ûÃö³¬"
        Me.btnPullerClose.UseVisualStyleBackColor = False
        '
        'btnChamberLight
        '
        Me.btnChamberLight.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnChamberLight.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChamberLight.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChamberLight.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnChamberLight.Location = New System.Drawing.Point(460, 437)
        Me.btnChamberLight.Name = "btnChamberLight"
        Me.btnChamberLight.Size = New System.Drawing.Size(116, 44)
        Me.btnChamberLight.TabIndex = 543
        Me.btnChamberLight.Text = "µÄ¤º·Ó©ú"
        Me.btnChamberLight.UseVisualStyleBackColor = False
        '
        'btnSaveAs
        '
        Me.btnSaveAs.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSaveAs.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btnSaveAs.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSaveAs.Location = New System.Drawing.Point(561, 8)
        Me.btnSaveAs.Name = "btnSaveAs"
        Me.btnSaveAs.Size = New System.Drawing.Size(65, 34)
        Me.btnSaveAs.TabIndex = 542
        Me.btnSaveAs.Text = "¥t¦s"
        Me.btnSaveAs.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.picC05)
        Me.Panel2.Controls.Add(Me.lblDPTemp)
        Me.Panel2.Controls.Add(Me.pnlMFC02)
        Me.Panel2.Controls.Add(Me.pnlMFC01)
        Me.Panel2.Controls.Add(Me.picDoor2)
        Me.Panel2.Controls.Add(Me.picDoor1)
        Me.Panel2.Controls.Add(Me.lblPumpingStatus)
        Me.Panel2.Controls.Add(Me.btnAutoPurge)
        Me.Panel2.Controls.Add(Me.btnAutoVacuum)
        Me.Panel2.Controls.Add(Me.pnlChamberLeft)
        Me.Panel2.Controls.Add(Me.lblVentText)
        Me.Panel2.Controls.Add(Me.btnPumpProtection)
        Me.Panel2.Controls.Add(Me.picDP)
        Me.Panel2.Controls.Add(Me.lblN2Text)
        Me.Panel2.Controls.Add(Me.picRVP)
        Me.Panel2.Controls.Add(Me.lblDPText)
        Me.Panel2.Controls.Add(Me.picPipeV02)
        Me.Panel2.Controls.Add(Me.picV4P)
        Me.Panel2.Controls.Add(Me.picPipeV01)
        Me.Panel2.Controls.Add(Me.lblRVText)
        Me.Panel2.Controls.Add(Me.pnlChamberRight)
        Me.Panel2.Controls.Add(Me.pnlChamberUp)
        Me.Panel2.Controls.Add(Me.pnlChamberDown)
        Me.Panel2.Controls.Add(Me.lblDPCurrent)
        Me.Panel2.Controls.Add(Me.lblA03Text)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(5, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(449, 367)
        Me.Panel2.TabIndex = 542
        '
        'picC05
        '
        Me.picC05.BackColor = System.Drawing.SystemColors.Control
        Me.picC05.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picC05.Image = Global.CELLO.My.Resources.Resources.tempc
        Me.picC05.Location = New System.Drawing.Point(283, 323)
        Me.picC05.Name = "picC05"
        Me.picC05.Size = New System.Drawing.Size(29, 26)
        Me.picC05.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picC05.TabIndex = 559
        Me.picC05.TabStop = False
        '
        'lblDPTemp
        '
        Me.lblDPTemp.BackColor = System.Drawing.Color.Black
        Me.lblDPTemp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDPTemp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDPTemp.ForeColor = System.Drawing.Color.Lime
        Me.lblDPTemp.Location = New System.Drawing.Point(214, 323)
        Me.lblDPTemp.Name = "lblDPTemp"
        Me.lblDPTemp.Size = New System.Drawing.Size(63, 24)
        Me.lblDPTemp.TabIndex = 558
        Me.lblDPTemp.Text = "0"
        Me.lblDPTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlMFC02
        '
        Me.pnlMFC02.Controls.Add(Me.lblV11TText)
        Me.pnlMFC02.Controls.Add(Me.lblMFCTime02)
        Me.pnlMFC02.Controls.Add(Me.picGas02T)
        Me.pnlMFC02.Controls.Add(Me.txtGas02MFCSet)
        Me.pnlMFC02.Controls.Add(Me.lblGas02MFC)
        Me.pnlMFC02.Controls.Add(Me.lblGas02Text)
        Me.pnlMFC02.Controls.Add(Me.PictureBox100)
        Me.pnlMFC02.Location = New System.Drawing.Point(227, 100)
        Me.pnlMFC02.Name = "pnlMFC02"
        Me.pnlMFC02.Size = New System.Drawing.Size(213, 87)
        Me.pnlMFC02.TabIndex = 557
        '
        'lblV11TText
        '
        Me.lblV11TText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblV11TText.Location = New System.Drawing.Point(11, 2)
        Me.lblV11TText.Name = "lblV11TText"
        Me.lblV11TText.Size = New System.Drawing.Size(41, 20)
        Me.lblV11TText.TabIndex = 537
        Me.lblV11TText.Text = "V11"
        Me.lblV11TText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMFCTime02
        '
        Me.lblMFCTime02.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMFCTime02.Location = New System.Drawing.Point(10, 55)
        Me.lblMFCTime02.Name = "lblMFCTime02"
        Me.lblMFCTime02.Size = New System.Drawing.Size(41, 20)
        Me.lblMFCTime02.TabIndex = 553
        Me.lblMFCTime02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picGas02T
        '
        Me.picGas02T.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.picGas02T.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picGas02T.Image = Global.CELLO.My.Resources.Resources.vvoff
        Me.picGas02T.Location = New System.Drawing.Point(11, 23)
        Me.picGas02T.Name = "picGas02T"
        Me.picGas02T.Size = New System.Drawing.Size(40, 32)
        Me.picGas02T.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGas02T.TabIndex = 538
        Me.picGas02T.TabStop = False
        '
        'txtGas02MFCSet
        '
        Me.txtGas02MFCSet.Enabled = False
        Me.txtGas02MFCSet.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGas02MFCSet.Location = New System.Drawing.Point(67, 23)
        Me.txtGas02MFCSet.Name = "txtGas02MFCSet"
        Me.txtGas02MFCSet.Size = New System.Drawing.Size(62, 26)
        Me.txtGas02MFCSet.TabIndex = 543
        Me.txtGas02MFCSet.Text = "000"
        Me.txtGas02MFCSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblGas02MFC
        '
        Me.lblGas02MFC.BackColor = System.Drawing.Color.Black
        Me.lblGas02MFC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGas02MFC.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGas02MFC.ForeColor = System.Drawing.Color.Lime
        Me.lblGas02MFC.Location = New System.Drawing.Point(67, 52)
        Me.lblGas02MFC.Name = "lblGas02MFC"
        Me.lblGas02MFC.Size = New System.Drawing.Size(62, 26)
        Me.lblGas02MFC.TabIndex = 544
        Me.lblGas02MFC.Text = "0"
        Me.lblGas02MFC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGas02Text
        '
        Me.lblGas02Text.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGas02Text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGas02Text.ForeColor = System.Drawing.Color.Red
        Me.lblGas02Text.Location = New System.Drawing.Point(131, 23)
        Me.lblGas02Text.Name = "lblGas02Text"
        Me.lblGas02Text.Size = New System.Drawing.Size(62, 26)
        Me.lblGas02Text.TabIndex = 545
        Me.lblGas02Text.Text = "N2O"
        Me.lblGas02Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox100
        '
        Me.PictureBox100.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox100.Image = CType(resources.GetObject("PictureBox100.Image"), System.Drawing.Image)
        Me.PictureBox100.Location = New System.Drawing.Point(-1, 34)
        Me.PictureBox100.Name = "PictureBox100"
        Me.PictureBox100.Size = New System.Drawing.Size(83, 10)
        Me.PictureBox100.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox100.TabIndex = 539
        Me.PictureBox100.TabStop = False
        '
        'pnlMFC01
        '
        Me.pnlMFC01.Controls.Add(Me.lblMFCTime01)
        Me.pnlMFC01.Controls.Add(Me.lblGas01Text)
        Me.pnlMFC01.Controls.Add(Me.txtGas01MFCSet)
        Me.pnlMFC01.Controls.Add(Me.lblGas01MFC)
        Me.pnlMFC01.Controls.Add(Me.picGas01T)
        Me.pnlMFC01.Controls.Add(Me.lblV10TText)
        Me.pnlMFC01.Controls.Add(Me.PictureBox94)
        Me.pnlMFC01.Location = New System.Drawing.Point(227, 13)
        Me.pnlMFC01.Name = "pnlMFC01"
        Me.pnlMFC01.Size = New System.Drawing.Size(213, 87)
        Me.pnlMFC01.TabIndex = 556
        '
        'lblMFCTime01
        '
        Me.lblMFCTime01.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMFCTime01.Location = New System.Drawing.Point(11, 55)
        Me.lblMFCTime01.Name = "lblMFCTime01"
        Me.lblMFCTime01.Size = New System.Drawing.Size(41, 20)
        Me.lblMFCTime01.TabIndex = 552
        Me.lblMFCTime01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGas01Text
        '
        Me.lblGas01Text.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGas01Text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGas01Text.ForeColor = System.Drawing.Color.Red
        Me.lblGas01Text.Location = New System.Drawing.Point(131, 23)
        Me.lblGas01Text.Name = "lblGas01Text"
        Me.lblGas01Text.Size = New System.Drawing.Size(62, 26)
        Me.lblGas01Text.TabIndex = 542
        Me.lblGas01Text.Text = "SiH4"
        Me.lblGas01Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtGas01MFCSet
        '
        Me.txtGas01MFCSet.Enabled = False
        Me.txtGas01MFCSet.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGas01MFCSet.Location = New System.Drawing.Point(67, 23)
        Me.txtGas01MFCSet.Name = "txtGas01MFCSet"
        Me.txtGas01MFCSet.Size = New System.Drawing.Size(62, 26)
        Me.txtGas01MFCSet.TabIndex = 540
        Me.txtGas01MFCSet.Text = "000"
        Me.txtGas01MFCSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblGas01MFC
        '
        Me.lblGas01MFC.BackColor = System.Drawing.Color.Black
        Me.lblGas01MFC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGas01MFC.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGas01MFC.ForeColor = System.Drawing.Color.Lime
        Me.lblGas01MFC.Location = New System.Drawing.Point(67, 52)
        Me.lblGas01MFC.Name = "lblGas01MFC"
        Me.lblGas01MFC.Size = New System.Drawing.Size(62, 26)
        Me.lblGas01MFC.TabIndex = 541
        Me.lblGas01MFC.Text = "0"
        Me.lblGas01MFC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picGas01T
        '
        Me.picGas01T.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.picGas01T.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picGas01T.Image = Global.CELLO.My.Resources.Resources.vvoff
        Me.picGas01T.Location = New System.Drawing.Point(11, 23)
        Me.picGas01T.Name = "picGas01T"
        Me.picGas01T.Size = New System.Drawing.Size(40, 32)
        Me.picGas01T.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGas01T.TabIndex = 535
        Me.picGas01T.TabStop = False
        '
        'lblV10TText
        '
        Me.lblV10TText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblV10TText.Location = New System.Drawing.Point(11, 2)
        Me.lblV10TText.Name = "lblV10TText"
        Me.lblV10TText.Size = New System.Drawing.Size(41, 20)
        Me.lblV10TText.TabIndex = 534
        Me.lblV10TText.Text = "V10"
        Me.lblV10TText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox94
        '
        Me.PictureBox94.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox94.Image = CType(resources.GetObject("PictureBox94.Image"), System.Drawing.Image)
        Me.PictureBox94.Location = New System.Drawing.Point(-1, 34)
        Me.PictureBox94.Name = "PictureBox94"
        Me.PictureBox94.Size = New System.Drawing.Size(83, 10)
        Me.PictureBox94.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox94.TabIndex = 536
        Me.PictureBox94.TabStop = False
        '
        'picDoor2
        '
        Me.picDoor2.BackColor = System.Drawing.Color.Transparent
        Me.picDoor2.Cursor = System.Windows.Forms.Cursors.Default
        Me.picDoor2.Image = CType(resources.GetObject("picDoor2.Image"), System.Drawing.Image)
        Me.picDoor2.Location = New System.Drawing.Point(0, 14)
        Me.picDoor2.Name = "picDoor2"
        Me.picDoor2.Size = New System.Drawing.Size(24, 24)
        Me.picDoor2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDoor2.TabIndex = 549
        Me.picDoor2.TabStop = False
        '
        'picDoor1
        '
        Me.picDoor1.BackColor = System.Drawing.Color.Transparent
        Me.picDoor1.Cursor = System.Windows.Forms.Cursors.Default
        Me.picDoor1.Image = CType(resources.GetObject("picDoor1.Image"), System.Drawing.Image)
        Me.picDoor1.Location = New System.Drawing.Point(0, 153)
        Me.picDoor1.Name = "picDoor1"
        Me.picDoor1.Size = New System.Drawing.Size(24, 24)
        Me.picDoor1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDoor1.TabIndex = 548
        Me.picDoor1.TabStop = False
        '
        'lblPumpingStatus
        '
        Me.lblPumpingStatus.BackColor = System.Drawing.Color.Black
        Me.lblPumpingStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPumpingStatus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPumpingStatus.ForeColor = System.Drawing.Color.Lime
        Me.lblPumpingStatus.Location = New System.Drawing.Point(13, 298)
        Me.lblPumpingStatus.Name = "lblPumpingStatus"
        Me.lblPumpingStatus.Size = New System.Drawing.Size(106, 25)
        Me.lblPumpingStatus.TabIndex = 532
        Me.lblPumpingStatus.Text = "0"
        Me.lblPumpingStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblPumpingStatus.Visible = False
        '
        'btnAutoPurge
        '
        Me.btnAutoPurge.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAutoPurge.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAutoPurge.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAutoPurge.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAutoPurge.Location = New System.Drawing.Point(332, 312)
        Me.btnAutoPurge.Name = "btnAutoPurge"
        Me.btnAutoPurge.Size = New System.Drawing.Size(108, 44)
        Me.btnAutoPurge.TabIndex = 84
        Me.btnAutoPurge.Text = "Auto Purge"
        Me.btnAutoPurge.UseVisualStyleBackColor = False
        '
        'btnAutoVacuum
        '
        Me.btnAutoVacuum.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAutoVacuum.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAutoVacuum.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAutoVacuum.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAutoVacuum.Location = New System.Drawing.Point(332, 193)
        Me.btnAutoVacuum.Name = "btnAutoVacuum"
        Me.btnAutoVacuum.Size = New System.Drawing.Size(108, 44)
        Me.btnAutoVacuum.TabIndex = 532
        Me.btnAutoVacuum.Text = "¦Û°Ê©â®ð"
        Me.btnAutoVacuum.UseVisualStyleBackColor = False
        '
        'pnlChamberLeft
        '
        Me.pnlChamberLeft.BackColor = System.Drawing.Color.Red
        Me.pnlChamberLeft.Location = New System.Drawing.Point(24, 14)
        Me.pnlChamberLeft.Name = "pnlChamberLeft"
        Me.pnlChamberLeft.Size = New System.Drawing.Size(10, 163)
        Me.pnlChamberLeft.TabIndex = 517
        '
        'lblVentText
        '
        Me.lblVentText.BackColor = System.Drawing.Color.Transparent
        Me.lblVentText.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVentText.Location = New System.Drawing.Point(15, 232)
        Me.lblVentText.Name = "lblVentText"
        Me.lblVentText.Size = New System.Drawing.Size(49, 22)
        Me.lblVentText.TabIndex = 359
        Me.lblVentText.Text = "Vent"
        '
        'btnPumpProtection
        '
        Me.btnPumpProtection.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPumpProtection.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPumpProtection.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPumpProtection.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPumpProtection.Location = New System.Drawing.Point(332, 252)
        Me.btnPumpProtection.Name = "btnPumpProtection"
        Me.btnPumpProtection.Size = New System.Drawing.Size(108, 44)
        Me.btnPumpProtection.TabIndex = 533
        Me.btnPumpProtection.Text = "¯uªÅºû«ù"
        Me.btnPumpProtection.UseVisualStyleBackColor = False
        '
        'picDP
        '
        Me.picDP.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.picDP.Cursor = System.Windows.Forms.Cursors.Default
        Me.picDP.Image = Global.CELLO.My.Resources.Resources.dp_off
        Me.picDP.Location = New System.Drawing.Point(127, 270)
        Me.picDP.Name = "picDP"
        Me.picDP.Size = New System.Drawing.Size(83, 56)
        Me.picDP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDP.TabIndex = 142
        Me.picDP.TabStop = False
        '
        'lblN2Text
        '
        Me.lblN2Text.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblN2Text.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lblN2Text.ForeColor = System.Drawing.Color.Blue
        Me.lblN2Text.Location = New System.Drawing.Point(64, 271)
        Me.lblN2Text.Name = "lblN2Text"
        Me.lblN2Text.Size = New System.Drawing.Size(37, 20)
        Me.lblN2Text.TabIndex = 76
        Me.lblN2Text.Text = "N2"
        '
        'picRVP
        '
        Me.picRVP.BackColor = System.Drawing.Color.Transparent
        Me.picRVP.Cursor = System.Windows.Forms.Cursors.Default
        Me.picRVP.Image = Global.CELLO.My.Resources.Resources.hvoff
        Me.picRVP.Location = New System.Drawing.Point(153, 197)
        Me.picRVP.Name = "picRVP"
        Me.picRVP.Size = New System.Drawing.Size(45, 57)
        Me.picRVP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRVP.TabIndex = 192
        Me.picRVP.TabStop = False
        '
        'lblDPText
        '
        Me.lblDPText.BackColor = System.Drawing.Color.Transparent
        Me.lblDPText.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDPText.Location = New System.Drawing.Point(216, 273)
        Me.lblDPText.Name = "lblDPText"
        Me.lblDPText.Size = New System.Drawing.Size(61, 18)
        Me.lblDPText.TabIndex = 68
        Me.lblDPText.Text = "MP"
        '
        'picPipeV02
        '
        Me.picPipeV02.BackColor = System.Drawing.Color.Transparent
        Me.picPipeV02.Image = Global.CELLO.My.Resources.Resources.Pipe_v
        Me.picPipeV02.Location = New System.Drawing.Point(170, 177)
        Me.picPipeV02.Name = "picPipeV02"
        Me.picPipeV02.Size = New System.Drawing.Size(10, 127)
        Me.picPipeV02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPipeV02.TabIndex = 193
        Me.picPipeV02.TabStop = False
        '
        'picV4P
        '
        Me.picV4P.BackColor = System.Drawing.Color.Transparent
        Me.picV4P.Cursor = System.Windows.Forms.Cursors.Default
        Me.picV4P.Image = Global.CELLO.My.Resources.Resources.hvoff
        Me.picV4P.Location = New System.Drawing.Point(64, 197)
        Me.picV4P.Name = "picV4P"
        Me.picV4P.Size = New System.Drawing.Size(45, 57)
        Me.picV4P.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picV4P.TabIndex = 143
        Me.picV4P.TabStop = False
        '
        'picPipeV01
        '
        Me.picPipeV01.BackColor = System.Drawing.Color.Transparent
        Me.picPipeV01.Image = Global.CELLO.My.Resources.Resources.Pipe_v
        Me.picPipeV01.Location = New System.Drawing.Point(81, 177)
        Me.picPipeV01.Name = "picPipeV01"
        Me.picPipeV01.Size = New System.Drawing.Size(10, 112)
        Me.picPipeV01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPipeV01.TabIndex = 358
        Me.picPipeV01.TabStop = False
        '
        'lblRVText
        '
        Me.lblRVText.BackColor = System.Drawing.Color.Transparent
        Me.lblRVText.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRVText.Location = New System.Drawing.Point(204, 233)
        Me.lblRVText.Name = "lblRVText"
        Me.lblRVText.Size = New System.Drawing.Size(56, 21)
        Me.lblRVText.TabIndex = 194
        Me.lblRVText.Text = "RV"
        '
        'pnlChamberRight
        '
        Me.pnlChamberRight.BackColor = System.Drawing.Color.Red
        Me.pnlChamberRight.Location = New System.Drawing.Point(218, 14)
        Me.pnlChamberRight.Name = "pnlChamberRight"
        Me.pnlChamberRight.Size = New System.Drawing.Size(10, 163)
        Me.pnlChamberRight.TabIndex = 518
        '
        'pnlChamberUp
        '
        Me.pnlChamberUp.BackColor = System.Drawing.Color.Red
        Me.pnlChamberUp.Location = New System.Drawing.Point(33, 14)
        Me.pnlChamberUp.Name = "pnlChamberUp"
        Me.pnlChamberUp.Size = New System.Drawing.Size(190, 10)
        Me.pnlChamberUp.TabIndex = 516
        '
        'pnlChamberDown
        '
        Me.pnlChamberDown.BackColor = System.Drawing.Color.Red
        Me.pnlChamberDown.Location = New System.Drawing.Point(33, 167)
        Me.pnlChamberDown.Name = "pnlChamberDown"
        Me.pnlChamberDown.Size = New System.Drawing.Size(190, 10)
        Me.pnlChamberDown.TabIndex = 515
        '
        'lblDPCurrent
        '
        Me.lblDPCurrent.BackColor = System.Drawing.Color.Black
        Me.lblDPCurrent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDPCurrent.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDPCurrent.ForeColor = System.Drawing.Color.Lime
        Me.lblDPCurrent.Location = New System.Drawing.Point(214, 299)
        Me.lblDPCurrent.Name = "lblDPCurrent"
        Me.lblDPCurrent.Size = New System.Drawing.Size(63, 24)
        Me.lblDPCurrent.TabIndex = 498
        Me.lblDPCurrent.Text = "0"
        Me.lblDPCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblA03Text
        '
        Me.lblA03Text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblA03Text.ForeColor = System.Drawing.Color.Black
        Me.lblA03Text.Location = New System.Drawing.Point(283, 301)
        Me.lblA03Text.Name = "lblA03Text"
        Me.lblA03Text.Size = New System.Drawing.Size(19, 20)
        Me.lblA03Text.TabIndex = 499
        Me.lblA03Text.Text = "A"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lblCHVac)
        Me.Panel3.Controls.Add(Me.lbl1ATM)
        Me.Panel3.Controls.Add(Me.lblTorr02Text)
        Me.Panel3.Controls.Add(Me.lblCPUUsage)
        Me.Panel3.Location = New System.Drawing.Point(34, 24)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(184, 143)
        Me.Panel3.TabIndex = 512
        '
        'lblCHVac
        '
        Me.lblCHVac.BackColor = System.Drawing.Color.Black
        Me.lblCHVac.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCHVac.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lblCHVac.ForeColor = System.Drawing.Color.Lime
        Me.lblCHVac.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCHVac.Location = New System.Drawing.Point(22, 35)
        Me.lblCHVac.Name = "lblCHVac"
        Me.lblCHVac.Size = New System.Drawing.Size(96, 28)
        Me.lblCHVac.TabIndex = 356
        Me.lblCHVac.Text = "9.90E+09"
        Me.lblCHVac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl1ATM
        '
        Me.lbl1ATM.BackColor = System.Drawing.Color.Red
        Me.lbl1ATM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl1ATM.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1ATM.ForeColor = System.Drawing.Color.Black
        Me.lbl1ATM.Location = New System.Drawing.Point(22, 11)
        Me.lbl1ATM.Name = "lbl1ATM"
        Me.lbl1ATM.Size = New System.Drawing.Size(72, 24)
        Me.lbl1ATM.TabIndex = 526
        Me.lbl1ATM.Text = "1ATM"
        Me.lbl1ATM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTorr02Text
        '
        Me.lblTorr02Text.BackColor = System.Drawing.Color.Transparent
        Me.lblTorr02Text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTorr02Text.ForeColor = System.Drawing.Color.Black
        Me.lblTorr02Text.Location = New System.Drawing.Point(123, 40)
        Me.lblTorr02Text.Name = "lblTorr02Text"
        Me.lblTorr02Text.Size = New System.Drawing.Size(51, 19)
        Me.lblTorr02Text.TabIndex = 357
        Me.lblTorr02Text.Text = "Torr"
        Me.lblTorr02Text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCPUUsage
        '
        Me.lblCPUUsage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCPUUsage.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCPUUsage.ForeColor = System.Drawing.Color.Red
        Me.lblCPUUsage.Location = New System.Drawing.Point(22, 63)
        Me.lblCPUUsage.Name = "lblCPUUsage"
        Me.lblCPUUsage.Size = New System.Drawing.Size(77, 32)
        Me.lblCPUUsage.TabIndex = 3
        Me.lblCPUUsage.Text = "50%"
        Me.lblCPUUsage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCPUUsage.Visible = False
        '
        'pnlVacuumChart
        '
        Me.pnlVacuumChart.Location = New System.Drawing.Point(460, 48)
        Me.pnlVacuumChart.Name = "pnlVacuumChart"
        Me.pnlVacuumChart.Size = New System.Drawing.Size(548, 322)
        Me.pnlVacuumChart.TabIndex = 527
        '
        'TabPagePaint
        '
        Me.TabPagePaint.BackColor = System.Drawing.SystemColors.Control
        Me.TabPagePaint.Controls.Add(Me.ControlPaintBoard1)
        Me.TabPagePaint.Location = New System.Drawing.Point(4, 34)
        Me.TabPagePaint.Name = "TabPagePaint"
        Me.TabPagePaint.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPagePaint.Size = New System.Drawing.Size(1016, 489)
        Me.TabPagePaint.TabIndex = 4
        Me.TabPagePaint.Text = "¯d¨¥ªO"
        '
        'ControlPaintBoard1
        '
        Me.ControlPaintBoard1.Enable = False
        Me.ControlPaintBoard1.Eraser = False
        Me.ControlPaintBoard1.iHeight = 484
        Me.ControlPaintBoard1.iWidth = 1016
        Me.ControlPaintBoard1.Location = New System.Drawing.Point(0, 1)
        Me.ControlPaintBoard1.Margin = New System.Windows.Forms.Padding(6)
        Me.ControlPaintBoard1.Name = "ControlPaintBoard1"
        Me.ControlPaintBoard1.Size = New System.Drawing.Size(1016, 484)
        Me.ControlPaintBoard1.TabIndex = 0
        '
        'tpCIMInput
        '
        Me.tpCIMInput.Controls.Add(Me.CtlSanAnCIM1)
        Me.tpCIMInput.Location = New System.Drawing.Point(4, 34)
        Me.tpCIMInput.Name = "tpCIMInput"
        Me.tpCIMInput.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCIMInput.Size = New System.Drawing.Size(1016, 489)
        Me.tpCIMInput.TabIndex = 5
        Me.tpCIMInput.Text = "CIMInput"
        Me.tpCIMInput.UseVisualStyleBackColor = True
        '
        'CtlSanAnCIM1
        '
        Me.CtlSanAnCIM1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.CtlSanAnCIM1.Location = New System.Drawing.Point(0, 1)
        Me.CtlSanAnCIM1.Name = "CtlSanAnCIM1"
        Me.CtlSanAnCIM1.Size = New System.Drawing.Size(1016, 486)
        Me.CtlSanAnCIM1.TabIndex = 0
        '
        'FormProcess
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1024, 710)
        Me.ControlBox = False
        Me.Controls.Add(Me.tabProcessDataCurve)
        Me.Controls.Add(Me.grpProcess)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(0, 50)
        Me.Name = "FormProcess"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Process"
        Me.grpProcess.ResumeLayout(False)
        Me.grpProcess.PerformLayout()
        Me.grpDoorControl.ResumeLayout(False)
        Me.pnlProcessCSelect.ResumeLayout(False)
        Me.tabProcessDataCurve.ResumeLayout(False)
        Me.TabPagePlateData.ResumeLayout(False)
        Me.TabPageCurve.ResumeLayout(False)
        Me.TabPageData.ResumeLayout(False)
        Me.pnlRecipe.ResumeLayout(False)
        Me.grpProcessOption.ResumeLayout(False)
        Me.pnlPurgeCooling.ResumeLayout(False)
        Me.pnlPurgeCooling.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpProcessCondition.ResumeLayout(False)
        Me.grpProcessCondition.PerformLayout()
        Me.TabPageVacuum.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.picC05, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMFC02.ResumeLayout(False)
        Me.pnlMFC02.PerformLayout()
        CType(Me.picGas02T, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox100, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMFC01.ResumeLayout(False)
        Me.pnlMFC01.PerformLayout()
        CType(Me.picGas01T, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox94, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDoor2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDoor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRVP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPipeV02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picV4P, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPipeV01, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.TabPagePaint.ResumeLayout(False)
        Me.tpCIMInput.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub



    Private Sub Process_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        If DesignMode Then Exit Sub
        Dim i As Byte
        Me.Top = FromStartUpTopPosition
        Me.Left = 0

        If SystemParameters.BarcodeOnly = "1" And BarCodeFile_Flag Then
            txtRecipeFile.Text = ""
            txtRecipeFile.Focus()
            txtRecipeFile.SelectAll()
        End If
        'Add By Vtncent 20220506  ----------------------------------------------------------  Start

        If SanAn_TCPIP_Used_Flag = False Then
            tabProcessDataCurve.TabPages.RemoveByKey("tpCIMInput")
        End If

        'If TCPIP_Used Then
        'tabProcessDataCurve.TabPages.RemoveByKey("tpCIMInput")
        'End If
        'btnBarcodeReader.Visible = Not TCPIP_Used
        btnInLine.Visible = Not TCPIP_Used
        btnOffLine.Visible = Not TCPIP_Used
        'Add By Vtncent 20220506  ----------------------------------------------------------  End

        txtGas01MFCSet.Enabled = MFC01_USED
        txtGas02MFCSet.Enabled = MFC01_USED

        If MAXPLATE < 3 Then
            tabProcessDataCurve.TabPages.RemoveByKey("TabPageCurve")
        End If

        lblModelname.Text = Program_ModelName

        ''Add By Vincent 20190710  ----------------------------------------------------------  Start
        'If CIM_Used Then
        '    lblModelname.Text = RemoteCIM._MachineNo
        'Else
        '    lblModelname.Text = Program_ModelName
        'End If
        ''Add By Vincent 20190710  ----------------------------------------------------------  End


        'lblRecipeNote.Text = RecipeNum(0).RecipeNote
        'lblBasePressureSet.Text = ChangeKPa(PressureUnit_Status, Val(RecipeNum(0).BasePressure))
        'lblProcessStepStatus.Text = RecipeNum(0).STEPNote(ProcessStepIndex)
        'lblTotalStepSet.Text = Str$(ProcessStepIndex + 1)
        'If BarCodeFile_Flag Then '½[°Ê²v BarBode
        '    btnEnter.Visible = True
        '    txtRecipeFile.Visible = True
        'Else
        '    btnEnter.Visible = False
        '    txtRecipeFile.Visible = False
        'End If
        Timer1.Interval = 1000
        Timer1.Enabled = True

    End Sub


    Private Sub btnAutoVacuum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAutoVacuum.Click
        If ProcessMode_RUN Then Exit Sub

        CAutoPumping.Start = Not CAutoPumping.Start
        If Purge_Flag Then

            Output(DoTopPurge1Index).Status = False
            Output(DoTopPurge2Index).Status = False
            Output(DoTopPurge3Index).Status = False

            Output(DoBotPurge1Index).Status = False
            Output(DoBotPurge2Index).Status = False
            Output(DoBotPurge3Index).Status = False
        End If
    End Sub

    Private Sub btnPumpProtection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPumpProtection.Click
        ProcessAutoVacuum_Status = Not ProcessAutoVacuum_Status
        CAutoPumping.AutoProtection = Not CAutoPumping.AutoProtection
        SystemParameters.ProcessAutoVacuum = GetTrue01String(ProcessAutoVacuum_Status)
        'CAutoPumping.SetBasePressure(CAutoPumping.AutoProtection, Val(SystemParameters.ProcessVacuumAutoVac), Val(SystemParameters.ProcessVacuumAutoVacLo))

        If ProcessMode_RUN Then
            CAutoPumping.SetBasePressure(CAutoPumping.AutoProtection, Val(SystemParameters.ProcessVacuumAutoVac), Val(RecipeNum(RecipeRunIndex).BasePressure))
        Else
            CAutoPumping.SetBasePressure(CAutoPumping.AutoProtection, Val(SystemParameters.ProcessVacuumAutoVac), Val(SystemParameters.ProcessVacuumAutoVacLo))
        End If
    End Sub


    Private Sub btnAutoPurge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAutoPurge.Click
        'Dim cond As Boolean
        If ProcessMode_RUN Then Exit Sub
        CAutoPumping.Start = True
        CAutoPumping.AutoPurge = Not CAutoPumping.AutoPurge
        CAutoPumping.SetAutoPurge(CAutoPumping.AutoPurge, Val(SystemParameters.AutoPurgeOnTime), Val(SystemParameters.AutoPurgeOFFTime), Val(SystemParameters.AutoPurgeCycle))
        'cond = PLC_Y(DoMPIndex) = "1"
        'If cond Then
        '    AutoPurge_Status = Not AutoPurge_Status
        'Else
        '    MsgBoxLangErr("½Ð¥ý¶}±Ò¯uªÅÀ°®ú¤ÎRV.", "ˆ[¥ý…{„Q¯uªÅ‰Ö®ú¤ÎRV.", "Pump, RV On first.")
        'End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'Dim PlcSetInitalingValue(16) As Integer
        Dim i As Integer
        'Add By Vincent 20190710  ----------------------------------------------------------  Start
        'btnRunProcess.Enabled = Not RemoteCIM.Enable ' Not RemoteCIM.SanAnCIM_Start
        txtRecipeFile.Enabled = (SystemParameters.BarcodeOnly = "1")


        If CIM_Used Then
            lblModelname.Text = RemoteCIM._MachineNo
        Else
            lblModelname.Text = Program_ModelName
        End If
        lblProcessDataFile.Text = IO.Path.GetFileName(ProcessRecordFileName) & " <" & ProcessRecordsIndex.ToString & ">"
        btnDoor1Up.Enabled = Not ProcessMode_RUN
        btnDoor1Down.Enabled = Not ProcessMode_RUN
        btnBarcodeReader.Enabled = RemoteCIM.Enable Or Not ProcessMode_RUN
        btnInLine.Enabled = Not ProcessMode_RUN
        btnOffLine.Enabled = Not ProcessMode_RUN
        btnInLine.Visible = CIM_Used
        btnOffLine.Visible = CIM_Used
        lblCIMError.Visible = CIM_Used
        'lblProcessDataName.Visible = CIM_Used

        ObjShow.Show(RemoteCIM.Enable, btnInLine, Color.Lime, Color.Red)
        ObjShow.Show(Not RemoteCIM.Enable, btnOffLine, Color.Lime, Color.Red)
        lblCIMError.Text = RemoteCIM.ErrorString
        btnOffLine.Enabled = Not ProcessMode_RUN

        If RemoteCIM.Enable Then
            btnLoadRecipe.Enabled = False
            'btnRunProcess.Text = GetLangText("¨ê¤J±ø½X", "Barcode")
            FormMenus.btnExit.Enabled = Not (ProcessMode_RUN Or RemoteCIM.Enable)
            btnRunProcess.Enabled = False
        Else
            '«ö¶s°Ê§@§í¯à
            btnLoadRecipe.Enabled = Not ProcessMode_RUN
            btnRunProcess.Enabled = Not ProcessMode_RUN
            FormMenus.btnExit.Enabled = Not ProcessMode_RUN
            'btnRunProcess.Text = GetLangText("°õ¦æ", "Run")
        End If
        '«ö¶s°Ê§@§í¯à
        'btnLoadRecipe.Enabled = Not ProcessMode_RUN
        'btnRunProcess.Enabled = Not ProcessMode_RUN
        'FormMenus.btnExit.Enabled = Not ProcessMode_RUN
        'Add By Vincent 20190710  ----------------------------------------------------------  End

        lblRunCount.Text = RunCounts.ToString

        lblCUPUsage.Visible = CelloUsbFlag

        btnPumpProtection.Visible = DP_Pump_Used
        lblDPTemp.Visible = DP_Pump_Used
        picC05.Visible = DP_Pump_Used
        If DP_Pump_Used Or Ulvac_LS120_Used Then
            lblDPText.Text = "DP"
        Else
            lblDPText.Text = "MP"
        End If
        lblDPTemp.Text = Get_PLC_R1000(ADDPTempIndex).ToString
        lblDPTemp.Visible = DP_Pump_Used

        ObjShow.Show(Check_PLC_Y(DoChamberLightIndex), btnChamberLight, ColorOn, ColorOff)
        ObjShow.Show(CAutoPumping.Start, btnAutoVacuum, ColorOn, ColorOff)
        ObjShow.Show(CAutoPumping.AutoPurge, btnAutoPurge, ColorOn, ColorOff)
        ObjShow.Show(CAutoPumping.AutoProtection, btnPumpProtection, ColorOn, ColorOff)

        ObjShow.Show(Check_PLC_X(DiSaftyGate01Index), picDoor1, My.Resources.Sensor_ON, My.Resources.Sensor_OFF)
        picDoor2.Visible = False
        'ObjShow.Show(Check_PLC_X(DiSaftyGate02Index), picDoor2, My.Resources.Sensor_ON, My.Resources.Sensor_OFF)
        ObjShow.Show(Check_PLC_M(DoDoor1UpIndex), btnDoor1Up, ColorOn, ColorOff)
        ObjShow.Show(Check_PLC_M(DoDoor1DownIndex), btnDoor1Down, ColorOn, ColorOff)
        ObjShow.Show(Check_PLC_M(DoDoor2UpIndex), btnDoor2Up, ColorOn, ColorOff)
        ObjShow.Show(Check_PLC_M(DoDoor2DownIndex), btnDoor2Down, ColorOn, ColorOff)

        ObjShow.Show(Vac1ATM_Status, lbl1ATM, Color.Lime, Color.Red)
        ObjShow.Show(Vac1ATM_Status, lbl1ATM02, Color.Lime, Color.Red)


        ObjShow.Show(Check_PLC_M(DoPullerCloseIndex), btnPullerClose, ColorOn, ColorOff)


        If CelloUsbFlag Then lblCUPUsage.Text = Format(CPU_Usage() / 100, "0.0%")
        'ObjShow.Show(Check_PLC_X(DiSaftyGate01Index), picDoor1, My.Resources.Sensor_ON, My.Resources.Sensor_OFF)
        'ObjShow.Show(Check_PLC_X(DiSaftyGate02Index), picDoor2, My.Resources.Sensor_ON, My.Resources.Sensor_ON)
        '©â¯uªÅÅã¥Ü°Ï°ì -----------------------------------------------------
        ObjShow.Show(PLC_Y(DoMPIndex) = "1", picDP, My.Resources.dp_on, My.Resources.dp_off)
        ObjShow.Show(PLC_Y(DoRVIndex) = "1", picRVP, My.Resources.hvon, My.Resources.hvoff)
        ObjShow.Show(PLC_Y(DoVentIndex) = "1", picV4P, My.Resources.hvon, My.Resources.hvoff)
        ObjShow.Show(PLC_Y(DoVentIndex) = "1", btnVent, Color.Lime, System.Drawing.SystemColors.Control)

        btnVent.Enabled = Not ProcessMode_RUN
        'btnBarcodeReader.Enabled = Not ProcessMode_RUN
        lblDPCurrent.Text = MPCurrentStr
        lblCHVac.Text = GaugeCHVacStr
        lblCHVac2.Text = GaugeCHVacStr
        '©â¯uªÅÅã¥Ü°Ï°ì -----------------------------------------------------

        '¦UÀY¸ê®ÆÅã¥Ü============================================
        For i = 0 To MAXPLATE
            PlateProcess(i).RunMode = ProcessMode_RUN
            PlateProcess(i).ShowFlow = False
            PlateProcess(i).RunTemp(PressPV(i), TopTempPV(i), BotTempPV(i))
            'PlateProcess(i).RunFlow(TopFlowMeterStr(i), BotFlowMeterStr(i))

            If CSubAutoProcess(i).Run Then
                PlateProcess(i).grpProcessDataTitle.BackColor = Color.Pink
            ElseIf CSubAutoProcess(i).AbortStatus Then
                PlateProcess(i).grpProcessDataTitle.BackColor = Color.FromArgb(255, 255, 0)
            Else
                PlateProcess(i).grpProcessDataTitle.BackColor = System.Drawing.SystemColors.Control
            End If

        Next
        '¦UÀY¸ê®ÆÅã¥Ü============================================


        '­ì³æÀY
        'If PLC_X(DiBondUp01Index) = "1" Then
        '    picBotPlate.Top = picBotPlate2.Top
        '    picWaferChip.Top = picWaferChip2.Top
        '    pnlCylinderAxis.Top = pnlCylinderAxis2.Top
        'Else
        '    picBotPlate.Top = picBotPlate1.Top
        '    picWaferChip.Top = picWaferChip1.Top
        '    pnlCylinderAxis.Top = pnlCylinderAxis1.Top
        'End If
        If PLC_X(DiDoor1UpIndex) = "1" Then
            pnlChamberDown.BackColor = Color.Red
        Else
            pnlChamberDown.BackColor = Color.Transparent
        End If
        pnlChamberUp.BackColor = Color.Red

        lblGas01MFC.Text = MFCReadValueStr(ADMFC01Index)
        lblGas02MFC.Text = MFCReadValueStr(ADMFC02Index)
        ObjShow.Show(Check_PLC_Y(DoV10Index), picGas01T, My.Resources.vvon, My.Resources.vvoff)
        ObjShow.Show(Check_PLC_Y(DoV10Index), picGas02T, My.Resources.vvon, My.Resources.vvoff)

        '»sµ{¸ê®ÆÅã¥Ü
        ObjShow.Show(ProcessMode_RUN, btnRunProcess, Color.Lime, Color.FromArgb(224, 224, 224))
        ObjShow.Show(CurveFreeze, btnCurveFreeze, Color.Lime, System.Drawing.SystemColors.Control)

        lblProcessStepStatus.Text = (ProcessStepIndex + 1).ToString + "/" + RecipeNum(RecipeRunIndex).StepSet
        'TotalProcessTime = -17574
        lblProcessRunTime.Text = ConvertSecToTime(TotalProcessTime) + Format(TotalProcessTime, "(0)")
        lblProcessStatus.Text = ProcessStatusString

        If BarCodeFile_Flag = False And SanAn_TCPIP_Used_Flag Then
            btnBarcodeReader.Visible = True
        Else
            btnBarcodeReader.Visible = False
        End If
        If BarCodeFile_Flag Then '½[°Ê²v BarBode
            btnEnter.Visible = True
            txtRecipeFile.Visible = True
        Else
            btnEnter.Visible = False
            txtRecipeFile.Visible = False
        End If
    End Sub

    Public Sub ShowInit()
        Me.Show()
        Timer1.Enabled = True
    End Sub
    Private Sub btnRunProcess_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRunProcess.Click
        BondCycleStop("all") 'By chesly 20170914 À£¬û¦Û°Ê´`Àô°Ê§@
        If LC.IsExpired Then
            MsgBoxLangErr("¨t²Î¥¼µù¥U!", "Not Register!")
            Exit Sub
        End If
        'Add  by Vincent 20180419  ------------------- Start
        'If Get_PLC_R1100(DAProgramVersionIndex) <> 2 Then
        '    MsgBoxLangErr("µ{¦¡ª©¥»¤£¦P¡A¤£¯à°õ¦æ!", "Program version not matched!")
        '    Exit Sub
        'End If
        'Add  by Vincent 20180419  ------------------- End
        Dim sstr As String = ""
        Dim sFile As String = ""
        Dim i As Integer
        'If SystemParameters.BarcodeOnly = "1" Then
        If RemoteCIM.Enable Then
            'MsgBoxLangOK("½Ð¨ê¤J±ø½X!", "Please use barcode reader!")
            'BarcodeReadStart()
            'Add By Vincent 20190710  ----------------------------------------------------------  Start
            FormSanAnBarcodeInput.TopMost = True
            FormSanAnBarcodeInput.TopLevel = True
            FormSanAnBarcodeInput.Input(RemoteCIM.EQID)
            FormSanAnBarcodeInput.txtOPID.Focus()
            FormSanAnBarcodeInput.txtOPID.SelectAll()
            'Add By Vincent 20190710  ----------------------------------------------------------  End
        Else
            If RecipeLoaded = False Then
                LoadRecipe()
                If RecipeLoaded = False Then
                    Exit Sub
                End If
            End If
            CheckProcessDateAndCreate()
            Cal_PresetData(RecipeNum(RecipeRunIndex).TotalTime)
            'Add By vincent  20150125  Start
            If GetTrue01Boolean(SystemParameters.AutoRecordData) Then
                Dim aa As String = FDate + "-" + FTime + "-[" + LoginUserName + "]"
                Dim bb As String = ProcessRecordDir + aa + ".dat"
                ProcessRecordFileName = bb
                ProcessEeventFileName = ProcessEeventDir + "Event_" + FDate + "-" + FTime + "-[" + LoginUserName + "].dat"
                sFile = aa
                ProcessPN = sFile
                ProcessRecordFileName = ProcessRecordDir + sFile + ".dat"
                ProcessRecordFileName1 = ProcessRecordDir + sFile + "_A.txt"
                ProcessRecordCurveFileName = ProcessRecordCurveDir + sFile + ".Proc"
                CsvFilename = ProcessCSVDir + sFile + ".csv"
                CsvFilename1 = ProcessCSVDir + sFile + "_A.csv"
                If FileIO.FileSystem.FileExists(ProcessRecordFileName) Then
                    FileIO.FileSystem.DeleteFile(ProcessRecordFileName)
                End If
                If FileIO.FileSystem.FileExists(ProcessRecordFileName1) Then
                    FileIO.FileSystem.DeleteFile(ProcessRecordFileName1)
                End If
                If FileIO.FileSystem.FileExists(ProcessRecordCurveFileName) Then
                    FileIO.FileSystem.DeleteFile(ProcessRecordCurveFileName)
                End If
                If FileIO.FileSystem.FileExists(CsvFilename) Then
                    FileIO.FileSystem.DeleteFile(CsvFilename)
                End If
                If FileIO.FileSystem.FileExists(CsvFilename1) Then
                    FileIO.FileSystem.DeleteFile(CsvFilename1)
                End If
                lblProcessStartTime.Text = TTime
                lblProcessStopTime.Text = "00:00:00"

                FormProcesss.Text = "Process [" + ProcessPN + "]"

                lblBasePressureSet.Text = Format(Val(RecipeNum(RecipeRunIndex).BasePressure), "0.0E+00")
                lblRecipeNote.Text = RecipeNum(RecipeRunIndex).RecipeNote
                lblWaferSize.Text = RecipeNum(RecipeRunIndex).WaferSize

                SetLangText(btnAbort, "©ñ±ó", "Abort")
                btnRunProcess.Enabled = False
                btnVent.Enabled = False
                FormMenus.btnExit.Enabled = False
                Timex = 0


                For i = 0 To MAXPLATE
                    PlateProcess(i).RunMode = ProcessMode_RUN
                    CSubAutoProcess(i).Clear()
                Next
                ProcessMode_RUN = True
            Else
                FormKeyInProcessNames.ProcessFileName = FDate + "-" + FTime + "-[" + LoginUserName + "]"
                'Add By Vincent 20160913 Start  -------------------------------------------------------
                FormKeyInProcessNames.txtBarcodeInput.Text = ""
                FormKeyInProcessNames.txtBarcodeInput.Focus()
                'FormKeyInProcessNames.txtBarcodeInput.SelectAll()
                'Add By Vincent 20160913 End    -------------------------------------------------------
                If FormKeyInProcessNames.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    sstr = System.IO.Path.GetFileNameWithoutExtension(ProcessRecipeFileName)
                    sFile = Now.ToString("yyyyMMdd-HHmmss") & "-" & sstr & "-Lot-" & FormKeyInProcessNames.ProcessFileName
                Else
                    Exit Sub
                End If

                'sFile = ProcessRecordFileName 'FormKeyInProcessNames.ProcessFileName
                ProcessPN = sFile
                ProcessRecordFileName = ProcessRecordDir + sFile + ".dat"
                ProcessRecordFileName1 = ProcessRecordDir + sFile + "_A.txt"
                ProcessRecordCurveFileName = ProcessRecordCurveDir + sFile + ".Proc"
                ProcessEeventFileName = ProcessEeventDir + "Event_" + FDate + "-" + FTime + "-[" + LoginUserName + "].dat"
                If FileIO.FileSystem.FileExists(ProcessRecordFileName) Then
                    If MsgBoxLangYesNo("ÀÉ®×¤w¦s¦b,­nÂÐ»\?", "File Exist, Overwrite?") Then
                        FileIO.FileSystem.DeleteFile(ProcessRecordFileName)
                    Else
                        Exit Sub
                    End If
                End If
                lblProcessDataFile.Text = ProcessPN + ".dat"
                CsvFilename = ProcessCSVDir + sFile + ".csv"
                CsvFilename1 = ProcessCSVDir + sFile + "_A.csv"
                lblProcessStartTime.Text = TTime
                lblProcessStopTime.Text = "00:00:00"

                FormProcesss.Text = "Process [" + ProcessPN + "]"

                lblBasePressureSet.Text = Format(Val(RecipeNum(RecipeRunIndex).BasePressure), "0.0E+00")
                lblRecipeNote.Text = RecipeNum(RecipeRunIndex).RecipeNote
                lblWaferSize.Text = RecipeNum(RecipeRunIndex).WaferSize

                SetLangText(btnAbort, "©ñ±ó", "Abort")
                btnRunProcess.Enabled = False
                btnVent.Enabled = False
                FormMenus.btnExit.Enabled = False
                Timex = 0


                For i = 0 To MAXPLATE
                    PlateProcess(i).RunMode = ProcessMode_RUN
                    CSubAutoProcess(i).Clear()
                Next
                ProcessMode_RUN = True
            End If


        End If
        If SystemParameters.BarcodeOnly = "1" And BarCodeFile_Flag Then
            txtRecipeFile.Focus()
            txtRecipeFile.SelectAll()
        End If
    End Sub

    Private Sub btnLoadRecipe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadRecipe.Click
        Dim i As Integer
        'On Error Resume Next
        If SystemParameters.BarcodeOnly = "1" Then
            BarcodeReadStart()
        Else
            pnlRecipe.Enabled = True
            LoadRecipe()
            If (FormRecipeSelects.RecipeFileName) <> Nothing And lblRecipeFileName.Text <> "" Then
                For i = 0 To MAXPLATE

                    CSubAutoProcess(i).LoadPlateRecipe(RecipeNum(RecipeRunIndex).Plate(i))
                    Dim TopTemp1 As Integer
                    Dim BotTemp1 As Integer

                    TopTemp1 = TempCal(i).GetTICTopTemp(Val(RecipeNum(RecipeRunIndex).Plate(i).Temperature(0)))
                    BotTemp1 = TempCal(i).GetTICBotTemp(Val(RecipeNum(RecipeRunIndex).Plate(i).Temperature(0))) 'TempTopSV 'Modified by Vincent 20180419 
                    ManualControl(i).WriteTempData(TopTemp1, BotTemp1, RecipeNum(RecipeRunIndex).Plate(i).Temperature_Rate(0))
                    ManualControl(i).WritePressData(RecipeNum(RecipeRunIndex).Plate(i).Pressure(0), RecipeNum(RecipeRunIndex).Plate(i).Pressure_Rate(0))
                    PIDs(i).PIDTopSave()
                    PIDs(i).PIDBotSave()
                Next
                pnlRecipe.Enabled = False
            End If
        End If
        If SystemParameters.BarcodeOnly = "1" And BarCodeFile_Flag Then
            txtRecipeFile.Focus()
            txtRecipeFile.SelectAll()
        End If
    End Sub


    Private Function LoadRecipe() As Boolean
        Dim i As Integer
        i = RecipeRunIndex
        pgbReadCurve.Visible = True

        If Not ProcessMode_RUN Then
            FormRecipeSelects.RecipeDir = RecipeDir
            If FormRecipeSelects.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
                Exit Function
            End If
            If FormRecipeSelects.RecipeFileName <> "" Then
                lblRecipeFileName.Text = FormRecipeSelects.RecipeFileName
                ProcessRecipeFileName = lblRecipeFileName.Text
                ProcessRecipeName = Mid(ProcessRecipeFileName, 1, InStr(ProcessRecipeFileName, "."))
                lblRecipeFileName.Text = ProcessRecipeFileName

                ProcessRecipeLongFileName = RecipeDir & ProcessRecipeFileName
                ProcessRecipeLongFileName = FormRecipeSelects.RecipeDir & ProcessRecipeFileName

                ReadRecipeFile(ProcessRecipeLongFileName)
            End If


            FormProcesss.lblRecipeNote.Text = RecipeNum(i).RecipeNote
            FormProcesss.lblBasePressureSet.Text = Format(Val(RecipeNum(i).BasePressure), "0.0E+00")
            FormProcesss.lblWaferSize.Text = RecipeNum(i).WaferSize


            chkBondBeforeVacuum.Checked = GetTrue01Boolean(RecipeNum(i).BondBeforeVacuum)
            chkKeepBonding.Checked = GetTrue01Boolean(RecipeNum(i).KeepBonding)
            chkVacuumMode.Checked = GetTrue01Boolean(RecipeNum(i).PumpingMode)
            chkVacuumPurge.Checked = GetTrue01Boolean(RecipeNum(i).VacuumPurge)
            chkAutoVent.Checked = GetTrue01Boolean(RecipeNum(i).AutoVent)
            chkAfterPurge.Checked = GetTrue01Boolean(RecipeNum(i).AfterPurge)
            chkAutoDoorOpen.Checked = GetTrue01Boolean(RecipeNum(i).AutoDoorOpen)

            'Purge Function Start
            chkBondBeforeVacuum.Checked = GetTrue01Boolean(RecipeNum(i).BondBeforeVacuum)
            chkKeepBonding.Checked = GetTrue01Boolean(RecipeNum(i).KeepBonding)
            chkVacuumMode.Checked = GetTrue01Boolean(RecipeNum(i).PumpingMode)
            chkVacuumPurge.Checked = GetTrue01Boolean(RecipeNum(i).VacuumPurge)
            chkAutoVent.Checked = GetTrue01Boolean(RecipeNum(i).AutoVent)


            chkPurgeCooling.Checked = GetTrue01Boolean(RecipeNum(i).PurgeCooling)
            txtAfterPurgeTemp.Text = RecipeNum(i).PurgeCoolingTemp
            txtPurgeONTime.Text = RecipeNum(i).PurgeONTime
            txtPurgeOFFTime.Text = RecipeNum(i).PurgeOFFTime
            chkPurgeKeepBonding.Checked = GetTrue01Boolean(RecipeNum(i).PurgeKeepBonding)
            'Purge Function Start


            If RecipeNum(i).BondingSync = "0" Then radBoth.Checked = True
            If RecipeNum(i).BondingSync = "1" Then radTemp.Checked = True
            If RecipeNum(i).BondingSync = "2" Then radPress.Checked = True
            RecipeLoaded = True
            Cal_PresetData(RecipeNum(i).TotalTime)
            'chartpe.ChartAreas(0).AxisX.Maximum = TotalStepTime + 1000
        End If
        For i = 0 To MAXPLATE
            CSubAutoProcess(i).LoadPlateRecipe(RecipeNum(RecipeRunIndex).Plate(i))
            'ProcessData(i).LoadPlateRecipe(RecipeNum(RecipeRunIndex).Plate(i))
            PlateProcess(i).SetTempPress(Val(RecipeNum(RecipeRunIndex).Plate(i).Pressure(0)), Val(RecipeNum(RecipeRunIndex).Plate(i).Temperature(0)))
        Next
        pgbReadCurve.Visible = False
        Return True
    End Function



    Public Sub Cal_PresetData(ByVal iTotal As Integer)
        Dim rwstepindex As Integer
        Dim pressure As Integer = 0
        Dim temp As Single = 0
        Dim i, j, k, l As Integer
        Dim LastPress, LastTemp As Single
        k = 0
        rwstepindex = Val(RecipeNum(RecipeRunIndex).StepSet)
        Dim a, b, c As Double
        'Chart1.Series("Series1").Color = Color.Violet
        'Chart1.Series("Series2").Color = Color.Cyan
        'Chart1.Series("Series3").Color = Color.DarkGray
        ReDim RealTimePreSetCurves(MAXPLATE) 'claire
        For l = 0 To MAXPLATE
            ReDim RealTimePreSetCurves(l).BondingPressure(iTotal + 100)
            ReDim RealTimePreSetCurves(l).BotTemperature(iTotal + 100)
            ReDim RealTimePreSetCurves(l).TopTemperature(iTotal + 100)
        Next

        For l = 0 To MAXPLATE
            TotalStepTime = 0
            LastPress = 0
            LastTemp = 25
            pressure = 0
            temp = 25
            k = 0
            For j = 0 To rwstepindex - 1
                For i = 0 To RecipeNum(RecipeRunIndex).Plate(l).StepTime(j) - 1
                    If Val(RecipeNum(RecipeRunIndex).Plate(l).Pressure(j)) > LastPress Then  'Add pressure
                        If pressure < (Val(RecipeNum(RecipeRunIndex).Plate(l).Pressure(j)) - Val(RecipeNum(RecipeRunIndex).Plate(l).Pressure_Rate(j))) Then
                            pressure += Val(RecipeNum(RecipeRunIndex).Plate(l).Pressure_Rate(j))
                        Else
                            pressure = Val(RecipeNum(RecipeRunIndex).Plate(l).Pressure(j))
                        End If
                    Else
                        If pressure > Val(RecipeNum(RecipeRunIndex).Plate(l).Pressure(j)) + Val(RecipeNum(RecipeRunIndex).Plate(l).Pressure_Rate(j)) Then   'Sub pressure
                            pressure -= Val(RecipeNum(RecipeRunIndex).Plate(l).Pressure_Rate(j))
                        Else
                            pressure = Val(RecipeNum(RecipeRunIndex).Plate(l).Pressure(j))
                        End If
                    End If
                    If Val(RecipeNum(RecipeRunIndex).Plate(l).Temperature(j)) > LastTemp Then
                        If temp < Val(RecipeNum(RecipeRunIndex).Plate(l).Temperature(j)) Then
                            temp += Val(RecipeNum(RecipeRunIndex).Plate(l).Temperature_Rate(j))
                        Else
                            temp = Val(RecipeNum(RecipeRunIndex).Plate(l).Temperature(j))
                        End If

                    Else
                        If temp > Val(RecipeNum(RecipeRunIndex).Plate(l).Temperature(j)) Then
                            temp -= Val(RecipeNum(RecipeRunIndex).Plate(l).Temperature_Rate(j))
                        Else
                            temp = Val(RecipeNum(RecipeRunIndex).Plate(l).Temperature(j))
                        End If
                    End If
                    RealTimePreSetCurves(l).BondingPressure(k) = pressure
                    'RealTimePreSetCurves.BotTemperature(k) = temp
                    RealTimePreSetCurves(l).TopTemperature(k) = temp
                    'ProcessCurve(l).Chart1.Series(3).Points.AddY(temp)
                    'ProcessCurve(l).Chart1.Series(4).Points.AddY(pressure)
                    k += 1
                Next

                LastPress = Val(RecipeNum(RecipeRunIndex).Plate(l).Pressure(j))
                LastTemp = Val(RecipeNum(RecipeRunIndex).Plate(l).Temperature(j))

                'ProcessCurve(l).Chart1, 4, RealTimePreSetCurves(l).BondingPressure)

                'Application.DoEvents()
                'System.Threading.Thread.Sleep(1)
            Next
            TotalStepTime = 0
            For j = 0 To MAXPLATE
                If TotalStepTime < RecipeNum(RecipeRunIndex).Plate(j).TotalTime Then
                    TotalStepTime = RecipeNum(RecipeRunIndex).Plate(j).TotalTime
                End If
            Next

            'ProcessCurve(l).Chart1.ChartAreas(0).AxisX.Maximum = iTotal * 1.5
            ProcessCurve(l).Chart1.ChartAreas(0).AxisX.Maximum = [Double].NaN
            CurveDataBindY(ProcessCurve(l).Chart1, 3, RealTimePreSetCurves(l).TopTemperature) 'claire
            CurveDataBindY(ProcessCurve(l).Chart1, 4, RealTimePreSetCurves(l).BondingPressure)
            'ProcessCurve(l).Chart1.ChartAreas(0).RecalculateAxesScale()
        Next
    End Sub

    Private Sub btnVent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVent.Click
        Dim sstr As String
        If ProcessMode_RUN Then Exit Sub
        'Add By Vincent 20190710  ----------------------------------------------------------  Start
        If RemoteCIM.Enable And ProcessMode_RUN = False Then
            If MsgBoxLangYesNo("»·ºÝ¼Ò¦¡¤U,½T©w­n¨Ï¥Î¨Ï¥Î vent ¥\¯à?", "Run Vent in In-Line mode?") = False Then
                Exit Sub
            End If
        End If
        'Add By Vincent 20190710  ----------------------------------------------------------  End
        If Output(DoVentIndex).Status Then
            Output(DoVentIndex).Status = False
        Else
            'If VentOK Then
            Output(DoRVIndex).Status = False
            Output(DoVentIndex).Status = True
            CAutoPumping.Start = False
            'Vent_Status = Not Vent_Status
            'Else
            '    sstr = SystemParameters.CoolingTemperature
            '    MsgBoxLangErr("µ¥«Ý·Å«×­°¦Ü: " + sstr, "µ¥«Ý h«×­°¦Ü: " + sstr, "Wait Temp Down: " + sstr)
            'End If
        End If
        If SystemParameters.BarcodeOnly = "1" And BarCodeFile_Flag Then
            txtRecipeFile.Focus()
            txtRecipeFile.SelectAll()
        End If
    End Sub

    Private Sub btnAbort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbort.Click
        Dim i As Integer
        If ProcessMode_RUN Then
            If MsgBoxLangYesNo("»sµ{¤¤Â_, ¬O§_½T©w?", "Process Abort, Confirm?") Then
                btnRunProcess.Enabled = True
                btnVent.Enabled = True
                FormMenus.btnExit.Enabled = True
                For i = 0 To MAXPLATE
                    ManualControl(i).SetHeater(False)
                    CSubAutoProcess(i).Abort()
                Next
                ProcessMode_RUN = False
                CAutoPumping.Start = False
            End If
        Else
            For i = 0 To MAXPLATE
                CSubAutoProcess(i).Abort()
            Next
        End If
        If SystemParameters.BarcodeOnly = "1" And BarCodeFile_Flag Then
            txtRecipeFile.Focus()
            txtRecipeFile.SelectAll()
        End If
    End Sub
    Private Function ReadRecipeFile(ByVal iRecipeNum As Integer, ByVal sfile As String) As Boolean 'Add By Vincent 20190710
        Dim i, j, k As Integer
        Dim sstr As String
        'i = RecipeRunIndex 'Remark  By Vincent 20190710
        i = iRecipeNum 'Add By Vincent 20190710
        sstr = "RECIPE"
        RecipeNum(i).RecipeNote = ReadProgData(sstr, "RECIPE_NOTE", "0", sfile)
        RecipeNum(i).StepSet = ReadProgData(sstr, "PROCESS_STEP", "0", sfile)
        RecipeNum(i).BasePressure = ReadProgData(sstr, "BASE_PRESSURE", "0", sfile)
        RecipeNum(i).WaferSize = ReadProgData(sstr, "WAFER_SIZE", "0", sfile)
        RecipeNum(i).TotalTime = Val(ReadProgData(sstr, "TOTAL_TIME", "0", sfile))

        RecipeNum(i).PumpingMode = ReadProgData(sstr, "VACUUM_MODE", "0", sfile)
        RecipeNum(i).KeepBonding = ReadProgData(sstr, "KEEP_PRESS", "0", sfile)
        RecipeNum(i).BondingSync = Val(ReadProgData(sstr, "BOND_SYNC", "0", sfile))
        RecipeNum(i).VacuumPurge = Val(ReadProgData(sstr, "VACUUM_PURGE", "0", sfile))
        RecipeNum(i).BondBeforeVacuum = ReadProgData(sstr, "BONDBEFOREVACUUM", "0", sfile)

        RecipeNum(i).AutoVent = ReadProgData(sstr, "AUTO_VENT", "0", sfile)
        RecipeNum(i).AfterPurge = ReadProgData(sstr, "AFTERPURGE", "0", sfile)
        RecipeNum(i).AutoDoorOpen = ReadProgData(sstr, "AUTODOOROPEN", "0", sfile)

        RecipeNum(i).MFC01Flow = ReadProgData(sstr, "MFC01FLOW", "0", sfile)
        RecipeNum(i).MFC01ONTime = ReadProgData(sstr, "MFC01ONTIME", "0", sfile)
        RecipeNum(i).MFC01OFFTime = ReadProgData(sstr, "MFC01OFFTIME", "0", sfile)

        RecipeNum(i).MFC02Flow = ReadProgData(sstr, "MFC02FLOW", "0", sfile)
        RecipeNum(i).MFC02ONTime = ReadProgData(sstr, "MFC02ONTIME", "0", sfile)
        RecipeNum(i).MFC02OFFTime = ReadProgData(sstr, "MFC02OFFTIME", "0", sfile)

        'Purge Function Start
        RecipeNum(i).PurgeCooling = ReadProgData(sstr, "PURGECOOLING", "0", sfile)
        RecipeNum(i).PurgeCoolingTemp = ReadProgData(sstr, "PURGECOOLINGTEMP", "0", sfile)
        RecipeNum(i).PurgeONTime = ReadProgData(sstr, "PURGEONTIME", "0", sfile)
        RecipeNum(i).PurgeOFFTime = ReadProgData(sstr, "PURGEOFFTIME", "0", sfile)
        RecipeNum(i).PurgeKeepBonding = ReadProgData(sstr, "PURGEKEEPBONDING", "0", sfile)
        'Purge Function End

        'chkBondBeforeVacuum.Checked = GetTrue01Boolean(RecipeNum(i).BondBeforeVacuum)
        'chkKeepBonding.Checked = GetTrue01Boolean(RecipeNum(i).KeepBonding)
        'chkVacuumMode.Checked = GetTrue01Boolean(RecipeNum(i).PumpingMode)
        'chkVacuumPurge.Checked = GetTrue01Boolean(RecipeNum(i).VacuumPurge)
        'chkAutoVent.Checked = GetTrue01Boolean(RecipeNum(i).AutoVent)

        radBoth.Checked = (RecipeNum(i).BondingSync = "0")
        radTemp.Checked = (RecipeNum(i).BondingSync = "1")
        radPress.Checked = (RecipeNum(i).BondingSync = "2")

        lblWaferSize.Text = RecipeNum(i).WaferSize
        lblRecipeNote.Text = RecipeNum(i).RecipeNote
        lblBasePressureSet.Text = Format(Val(RecipeNum(i).BasePressure), "0.0E+00")
        'lblRecipeStep.Text = RecipeNum(i).StepSet

        TotalStepTime = RecipeNum(i).TotalTime
        rwstepindex = Val(RecipeNum(i).StepSet)
        For k = 0 To MAXPLATE
            For j = 0 To rwstepindex - 1
                sstr = "STEP" & Format(j + 1, "00")
                RecipeNum(i).Plate(k).Pressure(j) = Val(ReadProgData(sstr, "PRESS" + Format(k, "00"), "0", sfile))
                RecipeNum(i).Plate(k).Pressure_Rate(j) = Val(ReadProgData(sstr, "PRESS_RATE" + Format(k, "00"), "0", sfile))
                RecipeNum(i).Plate(k).Temperature(j) = Val(ReadProgData(sstr, "TEMP" + Format(k, "00"), "0", sfile))
                RecipeNum(i).Plate(k).Temperature_Rate(j) = Val(ReadProgData(sstr, "TEMP_RATE" + Format(k, "00"), "0", sfile))
                RecipeNum(i).Plate(k).Time(j) = Val(ReadProgData(sstr, "HOLD_TIME" + Format(k, "00"), "0", sfile))
                RecipeNum(i).Plate(k).STEPNote(j) = ReadProgData(sstr, "NOTE" + Format(k, "00"), "0", sfile)
                RecipeNum(i).Plate(k).StepTime(j) = Val(ReadProgData(sstr, "STEP_TIME" + Format(k, "00"), "0", sfile))
                RecipeNum(i).Plate(k).TotalTime = Val(ReadProgData(sstr, "TOTALTIME" + Format(k, "00"), "0", sfile))
                RecipeNum(i).Plate(k).TotalStep = Val(ReadProgData(sstr, "TOTALSTEP" + Format(k, "00"), "0", sfile))
            Next
        Next
        For k = 0 To MAXPLATE
            ProcessData(k).SetRecipeIndex(0)
            'ProcessData(k).PressuseSet = RecipeNum(i).Plate(k).Pressure(0)
            'ProcessData(k).PressuseRate = RecipeNum(i).Plate(k).Pressure_Rate(0)
            'ProcessData(k).TempSet = RecipeNum(i).Plate(k).Temperature(0)
            'ProcessData(k).TempRateSet = RecipeNum(i).Plate(k).Temperature_Rate(0)
            'ProcessData(k).HoldTimeSet = RecipeNum(i).Plate(k).Time(0)
            'ProcessData(k).StepSet = RecipeNum(i).Plate(k).TotalStep
            'ProcessData(k).StepNote = RecipeNum(i).Plate(k).STEPNote(0)
            'ProcessData(k).StepTimeMin = RecipeNum(i).Plate(k).StepTime(0)
            PlateProcess(k).lblPressureSet.Text = RecipeNum(i).Plate(k).Pressure(0)
            PlateProcess(k).lblTopTempSet.Text = RecipeNum(i).Plate(k).Temperature(0)
            PlateProcess(k).lblBotTempSet.Text = RecipeNum(i).Plate(k).Temperature(0)
        Next
        Return True
        'Cal_StepTime()
    End Function

    Private Sub ReadRecipeFile(ByVal sfile As String)
        Dim i, j, k As Integer
        Dim sstr As String
        i = RecipeRunIndex
        sstr = "RECIPE"
        RecipeNum(i).RecipeNote = ReadProgData(sstr, "RECIPE_NOTE", "0", sfile)
        RecipeNum(i).StepSet = ReadProgData(sstr, "PROCESS_STEP", "0", sfile)
        RecipeNum(i).BasePressure = ReadProgData(sstr, "BASE_PRESSURE", "0", sfile)
        RecipeNum(i).WaferSize = ReadProgData(sstr, "WAFER_SIZE", "0", sfile)
        RecipeNum(i).TotalTime = Val(ReadProgData(sstr, "TOTAL_TIME", "0", sfile))

        RecipeNum(i).PumpingMode = ReadProgData(sstr, "VACUUM_MODE", "0", sfile)
        RecipeNum(i).KeepBonding = ReadProgData(sstr, "KEEP_PRESS", "0", sfile)
        RecipeNum(i).BondingSync = Val(ReadProgData(sstr, "BOND_SYNC", "0", sfile))
        RecipeNum(i).VacuumPurge = Val(ReadProgData(sstr, "VACUUM_PURGE", "0", sfile))
        RecipeNum(i).BondBeforeVacuum = ReadProgData(sstr, "BONDBEFOREVACUUM", "0", sfile)

        RecipeNum(i).AutoVent = ReadProgData(sstr, "AUTO_VENT", "0", sfile)
        RecipeNum(i).AfterPurge = ReadProgData(sstr, "AFTERPURGE", "0", sfile)
        RecipeNum(i).AutoDoorOpen = ReadProgData(sstr, "AUTODOOROPEN", "0", sfile)

        RecipeNum(i).MFC01Flow = ReadProgData(sstr, "MFC01FLOW", "0", sfile)
        RecipeNum(i).MFC01ONTime = ReadProgData(sstr, "MFC01ONTIME", "0", sfile)
        RecipeNum(i).MFC01OFFTime = ReadProgData(sstr, "MFC01OFFTIME", "0", sfile)

        RecipeNum(i).MFC02Flow = ReadProgData(sstr, "MFC02FLOW", "0", sfile)
        RecipeNum(i).MFC02ONTime = ReadProgData(sstr, "MFC02ONTIME", "0", sfile)
        RecipeNum(i).MFC02OFFTime = ReadProgData(sstr, "MFC02OFFTIME", "0", sfile)

        'Purge Function Start
        RecipeNum(i).PurgeCooling = ReadProgData(sstr, "PURGECOOLING", "0", sfile)
        RecipeNum(i).PurgeCoolingTemp = ReadProgData(sstr, "PURGECOOLINGTEMP", "0", sfile)
        RecipeNum(i).PurgeONTime = ReadProgData(sstr, "PURGEONTIME", "0", sfile)
        RecipeNum(i).PurgeOFFTime = ReadProgData(sstr, "PURGEOFFTIME", "0", sfile)
        RecipeNum(i).PurgeKeepBonding = ReadProgData(sstr, "PURGEKEEPBONDING", "0", sfile)
        'Purge Function End

        'chkBondBeforeVacuum.Checked = GetTrue01Boolean(RecipeNum(i).BondBeforeVacuum)
        'chkKeepBonding.Checked = GetTrue01Boolean(RecipeNum(i).KeepBonding)
        'chkVacuumMode.Checked = GetTrue01Boolean(RecipeNum(i).PumpingMode)
        'chkVacuumPurge.Checked = GetTrue01Boolean(RecipeNum(i).VacuumPurge)
        'chkAutoVent.Checked = GetTrue01Boolean(RecipeNum(i).AutoVent)

        radBoth.Checked = (RecipeNum(i).BondingSync = "0")
        radTemp.Checked = (RecipeNum(i).BondingSync = "1")
        radPress.Checked = (RecipeNum(i).BondingSync = "2")

        lblWaferSize.Text = RecipeNum(i).WaferSize
        lblRecipeNote.Text = RecipeNum(i).RecipeNote
        lblBasePressureSet.Text = Format(Val(RecipeNum(i).BasePressure), "0.0E+00")
        'lblRecipeStep.Text = RecipeNum(i).StepSet

        TotalStepTime = RecipeNum(i).TotalTime
        rwstepindex = Val(RecipeNum(i).StepSet)
        For k = 0 To MAXPLATE
            For j = 0 To rwstepindex - 1
                sstr = "STEP" & Format(j + 1, "00")
                RecipeNum(i).Plate(k).Pressure(j) = Val(ReadProgData(sstr, "PRESS" + Format(k, "00"), "0", sfile))
                RecipeNum(i).Plate(k).Pressure_Rate(j) = Val(ReadProgData(sstr, "PRESS_RATE" + Format(k, "00"), "0", sfile))
                RecipeNum(i).Plate(k).Temperature(j) = Val(ReadProgData(sstr, "TEMP" + Format(k, "00"), "0", sfile))
                RecipeNum(i).Plate(k).Temperature_Rate(j) = Val(ReadProgData(sstr, "TEMP_RATE" + Format(k, "00"), "0", sfile))
                RecipeNum(i).Plate(k).Time(j) = Val(ReadProgData(sstr, "HOLD_TIME" + Format(k, "00"), "0", sfile))
                RecipeNum(i).Plate(k).STEPNote(j) = ReadProgData(sstr, "NOTE" + Format(k, "00"), "0", sfile)
                RecipeNum(i).Plate(k).StepTime(j) = Val(ReadProgData(sstr, "STEP_TIME" + Format(k, "00"), "0", sfile))
                RecipeNum(i).Plate(k).TotalTime = Val(ReadProgData(sstr, "TOTALTIME" + Format(k, "00"), "0", sfile))
                RecipeNum(i).Plate(k).TotalStep = Val(ReadProgData(sstr, "TOTALSTEP" + Format(k, "00"), "0", sfile))
            Next
        Next
        For k = 0 To MAXPLATE
            ProcessData(k).SetRecipeIndex(0)
            'ProcessData(k).PressuseSet = RecipeNum(i).Plate(k).Pressure(0)
            'ProcessData(k).PressuseRate = RecipeNum(i).Plate(k).Pressure_Rate(0)
            'ProcessData(k).TempSet = RecipeNum(i).Plate(k).Temperature(0)
            'ProcessData(k).TempRateSet = RecipeNum(i).Plate(k).Temperature_Rate(0)
            'ProcessData(k).HoldTimeSet = RecipeNum(i).Plate(k).Time(0)
            'ProcessData(k).StepSet = RecipeNum(i).Plate(k).TotalStep
            'ProcessData(k).StepNote = RecipeNum(i).Plate(k).STEPNote(0)
            'ProcessData(k).StepTimeMin = RecipeNum(i).Plate(k).StepTime(0)
            PlateProcess(k).lblPressureSet.Text = RecipeNum(i).Plate(k).Pressure(0)
            PlateProcess(k).lblTopTempSet.Text = RecipeNum(i).Plate(k).Temperature(0)
            PlateProcess(k).lblBotTempSet.Text = RecipeNum(i).Plate(k).Temperature(0)
        Next

        'Cal_StepTime()
    End Sub
    Private Sub btnYReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCurveReset.Click
        ResetCurve(ChartProcessVacuum)
        'CurveFreeze = False
    End Sub

    Public Sub btnPrintCurve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintCurve.Click
        Dim FileName As String
        If ProcessPN = "" Then
            FileName = "Vacuum" + FDate + "_" + FTime
        Else
            FileName = ProcessPN
        End If
        printCurve(ChartProcessVacuum, FileName)

    End Sub

    Private Sub btnShowSeriesName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowSeriesName.Click
        pnlProcessCSelect.Visible = Not pnlProcessCSelect.Visible
    End Sub

    Private Sub btnCurveFreeze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCurveFreeze.Click
        CurveFreeze = Not CurveFreeze
    End Sub

    Private Sub btnSaveAs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveAs.Click
        SaveChartToJPG(ChartProcessVacuum)
    End Sub
    Private Sub btnDoor1Up_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDoor1Up.Click
        If ProcessMode_RUN Then Exit Sub
        If Check_PLC_X(DiSaftyGate01Index) Then
            Output(DoDoor1UpIndex).Status = Not Output(DoDoor1UpIndex).Status
            Output(DoDoor1DownIndex).Status = False
        Else
            MsgBoxLangErr("¦w¥þªù 1 ²§±`!", "Safty Gate 1 Error!")
        End If
        If SystemParameters.BarcodeOnly = "1" And BarCodeFile_Flag Then
            txtRecipeFile.Focus()
            txtRecipeFile.SelectAll()
        End If
    End Sub
    Private Sub btnDoor1Down_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDoor1Down.Click
        If ProcessMode_RUN Then Exit Sub
        Dim sstr As String
        If VentOK = False Then
            sstr = SystemParameters.CoolingTemperature
            MsgBoxLangErr("µ¥«Ý·Å«×­°¦Ü: " + sstr, "Wait Temp Down: " + sstr)
            Exit Sub
        End If
        If Vac1ATM_Status Then
            Output(DoDoor1UpIndex).Status = False
            Output(DoDoor1DownIndex).Status = Not Output(DoDoor1DownIndex).Status
        Else
            Output(DoDoor1DownIndex).Status = False
            MsgBoxLangErr("­n¦b¤@¤j®ðÀ£¤U¤~¯à¶}ªù!", "Must In 1 Atm.")
        End If
        If SystemParameters.BarcodeOnly = "1" And BarCodeFile_Flag Then
            txtRecipeFile.Focus()
            txtRecipeFile.SelectAll()
        End If
    End Sub

    Private Sub btnDoor2Up_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDoor2Up.Click
        If ProcessMode_RUN Then Exit Sub
        If Check_PLC_X(DiSaftyGate02Index) Then
            Output(DoDoor2UpIndex).Status = Not Output(DoDoor2UpIndex).Status
            Output(DoDoor2DownIndex).Status = False
        Else
            MsgBoxLangErr("¦w¥þªù 2 ²§±`!", "Safty Gate 1 Error!")
        End If
    End Sub
    Private Sub btnDoor2Down_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDoor2Down.Click
        If ProcessMode_RUN Then Exit Sub
        Dim sstr As String
        If VentOK = False Then
            sstr = SystemParameters.CoolingTemperature
            MsgBoxLangErr("µ¥«Ý·Å«×­°¦Ü: " + sstr, "Wait Temp Down: " + sstr)
            Exit Sub
        End If
        If Vac1ATM_Status Then
            Output(DoDoor2UpIndex).Status = False
            Output(DoDoor2DownIndex).Status = Not Output(DoDoor2DownIndex).Status
        Else
            Output(DoDoor2DownIndex).Status = False
            MsgBoxLangErr("­n¦b¤@¤j®ðÀ£¤U¤~¯à¶}ªù!", "Must In 1 Atm.")
        End If

    End Sub



    Private Sub btnChamberLight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChamberLight.Click
        Output(DoChamberLightIndex).Status = Not Output(DoChamberLightIndex).Status
    End Sub

    Private Sub btnPullerClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPullerClose.Click
        Output(DoPullerCloseIndex).Status = Not Output(DoPullerCloseIndex).Status
    End Sub


    Private Sub lblRunCount_DoubleClick(sender As System.Object, e As System.EventArgs) Handles lblRunCount.DoubleClick
        If MsgBoxLangYesNo("¬O§_­n²M°£Á`°õ¦æ­p¼Æ?", "Do you want to clear run counts?") Then
            RunCounts = 0
        End If
    End Sub

    Private Sub BondCycleStop(ByVal Index As String)
        Dim str As String = Index
        Select Case str
            Case "Site #01"
                BondCycle1.StartRun = False
            Case "Site #02"
                BondCycle2.StartRun = False
            Case "Site #03"
                BondCycle3.StartRun = False
            Case "Site #04"
                BondCycle4.StartRun = False
            Case "Site #05"
                BondCycle5.StartRun = False
            Case "Site #06"
                BondCycle6.StartRun = False
            Case "all"
                BondCycle1.StartRun = False
                BondCycle2.StartRun = False
                BondCycle3.StartRun = False
                BondCycle4.StartRun = False
                BondCycle5.StartRun = False
                BondCycle6.StartRun = False
        End Select
    End Sub 'By chesly 20181023 À£¬û¦Û°Ê´`Àô°Ê§@ end

    Private Declare Auto Function BitBlt Lib "gdi32.dll" (ByVal hdcDest As IntPtr, ByVal nXDest As Integer,
                                                        ByVal nYDest As Integer, ByVal nWidth As Integer,
                                                        ByVal nHeight As Integer, ByVal hdcSrc As IntPtr,
                                                        ByVal nXSrc As Integer, ByVal nYSrc As Integer,
                                                        ByVal dwRop As System.Int32) As Boolean

    Private Const SRCCOPY As Integer = &HCC0020
    ' Save the picture.
    Public Sub SaveFromToImage(ByVal obj As Object, ByVal filename As String)
        Dim bm As Bitmap = GetFormImage(obj)
        bm.Save(filename, System.Drawing.Imaging.ImageFormat.Jpeg)
    End Sub

    Private Function GetFormImage(ByVal obj As Object) As Bitmap
        ' Get this form's Graphics object.
        Dim me_gr As Graphics = obj.CreateGraphics

        ' Make a Bitmap to hold the image.
        Dim bm As New Bitmap(obj.ClientSize.Width,
            obj.ClientSize.Height, me_gr)
        Dim bm_gr As Graphics = Graphics.FromImage(bm)
        Dim bm_hdc As IntPtr = bm_gr.GetHdc

        ' Get the form's hDC. We must do this after 
        ' creating the new Bitmap, which uses me_gr.
        Dim me_hdc As IntPtr = me_gr.GetHdc

        ' BitBlt the form's image onto the Bitmap.
        BitBlt(bm_hdc, 0, 0, obj.ClientSize.Width,
            obj.ClientSize.Height,
            me_hdc, 0, 0, SRCCOPY)
        me_gr.ReleaseHdc(me_hdc)
        bm_gr.ReleaseHdc(bm_hdc)

        ' Return the result.
        Return bm
    End Function



#Region "SanAn CIM Function 20190710"
    'Add By Vincent 20190710  ----------------------------------------------------------  Start
    'EPILEDS BARCODE ---------------------- Start
    Private Sub btnBarcodeReader_Click(sender As System.Object, e As System.EventArgs) Handles btnBarcodeReader.Click
        If LC.IsExpired Then
            MsgBoxLangErr("µù¥U«á¤~¯à¨Ï¥Î!", "Please Register!")
            Exit Sub
        End If
        If RemoteCIM.Enable = False Then
            MsgBoxLangOK("½Ð¥ý³]¬° IN-LINE ¼Ò¦¡!", "Please change to IN-LINE mode.")
        Else
            If SanAn_TCPIP_Used_Flag Then
                tabProcessDataCurve.SelectTab(tpCIMInput)
                CtlSanAnCIM1.txtOpID.SelectAll()
                CtlSanAnCIM1.txtOpID.Focus()
            End If
            MsgBoxLangOK("½Ð¨ê¤J±ø½X!", "Please use barcode reader!")
            End If
        'BarcodeReadStart()
    End Sub
    Public Sub BarcodeReadStart()
        If RemoteCIM.Enable Then
            'MsgBoxLangOK("½Ð¨ê¤J±ø½X!", "Please use barcode reader!")
            FormSanAnBarcodeInput.TopMost = True
            FormSanAnBarcodeInput.TopLevel = True
            FormSanAnBarcodeInput.Input(RemoteCIM.EQID)
            FormSanAnBarcodeInput.txtOPID.Focus()
            FormSanAnBarcodeInput.txtOPID.SelectAll()
            'Add By Vincent 20190710  ----------------------------------------------------------  End
        End If
    End Sub
    'EPILEDS BARCODE ---------------------- End


    'CIM  20190710 by vincent ---------------- Start
    Public RecipeShow As Boolean = False
    Public RecipeShowCount As Integer = 0
    Public Sub AutoLoadRecipeThenRun(ByVal recipe As String)
        'Dim i As Integer
        ''New
        'CheckProcessDateAndCreate()
        'ProcessRecipeFileName = recipe
        'ProcessRecipeName = recipe
        'lblRecipeFileName.Text = recipe

        'ProcessRecipeLongFileName = RecipeDir & ProcessRecipeFileName
        'FormRecipes.ReadRecipeFile(ProcessRecipeLongFileName)
        'FormRecipes.Show()

        'LoadRecipe(ProcessRecipeLongFileName)
        'RecipeShow = True
        'RecipeShowCount = 5
        'If MsgBoxLangYesNo("½Ð½T»{°t¤è¬O§_¥¿½T¡A" & vbCrLf & "½Ð«ö <¬O> °õ¦æ¡A<§_> Â÷¶}.", "Please Confirm Recipe, Yes for Run, No for stop.") Then
        '    Application.DoEvents()
        '    System.Threading.Thread.Sleep(100)
        '    Application.DoEvents()
        '    System.Threading.Thread.Sleep(100)
        '    CheckJPGDirAndCreate()
        '    Dim SaveName As String = JPGDir & FDate & "_" & FTime & "_" & Format(RunCounts, "000000") & ".jpg"
        '    SaveFromToImage(FormRecipes, SaveName)
        '    FormRecipes.Hide()
        '    '«Ø¥ß»sµ{°O¿ýÀÉ¦W
        '    ProcessPN = recipe
        '    ProcessRecordShortFileName = recipe + ".dat"
        '    ProcessRecordFileName = ProcessRecordDir + ProcessRecordShortFileName
        '    ProcessEeventFileName = ProcessEeventDir + "Event_" + FDate + "-" + FTime + "-[" + LoginUserName + "].dat"
        '    ProcessRecordFileName1 = ProcessRecordDir + recipe + "_A.txt"
        '    ProcessRecordCurveFileName = ProcessRecordCurveDir + recipe + ".Proc"
        '    CsvFilename = ProcessCSVDir + recipe + ".csv"
        '    CsvFilename1 = ProcessCSVDir + recipe + "_A.csv"
        '    If FileIO.FileSystem.FileExists(ProcessRecordFileName) Then
        '        FileIO.FileSystem.DeleteFile(ProcessRecordFileName)
        '    End If
        '    If FileIO.FileSystem.FileExists(ProcessRecordFileName1) Then
        '        FileIO.FileSystem.DeleteFile(ProcessRecordFileName1)
        '    End If
        '    If FileIO.FileSystem.FileExists(ProcessRecordCurveFileName) Then
        '        FileIO.FileSystem.DeleteFile(ProcessRecordCurveFileName)
        '    End If
        '    If FileIO.FileSystem.FileExists(CsvFilename) Then
        '        FileIO.FileSystem.DeleteFile(CsvFilename)
        '    End If
        '    If FileIO.FileSystem.FileExists(CsvFilename1) Then
        '        FileIO.FileSystem.DeleteFile(CsvFilename1)
        '    End If

        '    Dim SaveName1 As String = JPGDir & FDate & "_" & FTime & "_" & Format(RunCounts, "000000") & ".csv"
        '    AppendDataA(SaveName1, "LogFile," & "=""" & ProcessRecordShortFileName & """")
        '    AppendDataA(SaveName1, "")
        '    AppendDataA(SaveName1, "UserID," & "=""" & RecipeMapEditor.RunCard.UserID & """")
        '    AppendDataA(SaveName1, "RunNo.," & "=""" & Format(RunCounts, "000000") & """")
        '    AppendDataA(SaveName1, "BarcodeID," & "=""" & RecipeMapEditor.RunCard.BarcodeMap & """")
        '    AppendDataA(SaveName1, "RecipeFile," & "=""" & RecipeMapEditor.RunCard.RecipeName & """")
        '    AppendDataA(SaveName1, "CassetteNum," & "=""" & RecipeMapEditor.RunCard.Index & """")
        '    AppendDataA(SaveName1, "")
        '    Dim sstr1 As String = "No,ProductID, RunCardID,WaferNum"
        '    AppendDataA(SaveName1, sstr1)
        '    For i = 0 To RecipeMapEditor.RunCard.Index - 1
        '        Dim astr0, astr1, astr2, astr3, astr4 As String
        '        astr0 = (i + 1).ToString
        '        astr1 = RecipeMapEditor.RunCard.Data(i).ProductID
        '        astr2 = RecipeMapEditor.RunCard.Data(i).LotID
        '        astr3 = RecipeMapEditor.RunCard.Data(i).WaferNum
        '        astr4 = "=""" & astr0 & """,=""" & astr1 & """,=""" & astr2 & """,=""" & astr3 & """"
        '        AppendDataA(SaveName1, astr4)
        '    Next






        '    lblProcessStartTime.Text = TTime
        '    lblProcessStopTime.Text = "00:00:00"
        '    FormProcesss.Text = "Process [" + ProcessPN + "]"
        '    Timex = 0

        '    lblBasePressureSet.Text = Format(Val(RecipeNum(RecipeRunIndex).BasePressure), "0.0E+00")
        '    lblRecipeNote.Text = RecipeNum(RecipeRunIndex).RecipeNote
        '    lblWaferSize.Text = RecipeNum(RecipeRunIndex).WaferSize

        '    SetLangText(btnAbort, "©ñ±ó", "Abort")
        '    btnRunProcess.Enabled = False
        '    btnVent.Enabled = False
        '    FormMenus.btnExit.Enabled = False

        '    ProcessMode_RUN = True
        '    ProcessNormalEnd = False
        'Else
        '    FormRecipes.Hide()
        '    MsgBoxLangYesNo("»sµ{¤£°õ¦æ!", "Process stop.")
        'End If

        Dim i As Integer
        'New
        RecipeShow = False
        CheckProcessDateAndCreate()


        ProcessRecipeFileName = recipe & ".rcp"
        ProcessRecipeName = recipe
        lblRecipeFileName.Text = recipe & ".rcp"
        'Debug.Print("lblRecipeFileName  _2=" + lblRecipeFileName.Text)
        ProcessRecipeLongFileName = RecipeDir & ProcessRecipeFileName

        'Show Recipe Form
        If RecipeShow Then
            FormRecipes.ReadRecipeFile(ProcessRecipeLongFileName)
            FormRecipes.Show()
        End If
        LoadRecipe(ProcessRecipeLongFileName)
        If GetTrue01Boolean(SystemParameters.RunConfirm) Then
            'If MsgBoxLangYesNo("½Ð½T»{°t¤è¬O§_¥¿½T¡A" & vbCrLf & "½Ð«ö <¬O> °õ¦æ¡A<§_> Â÷¶}.", "Please Confirm Recipe, Yes for Run, No for stop.") Then
            If MsgBoxLangYesNo("½T©w­n°õ¦æ»sµ{? (" & lblRecipeFileName.Text & ")", "Confirm to Run Process? (" & lblRecipeFileName.Text & ")") Then
                If RecipeShow Then
                    Application.DoEvents()
                    System.Threading.Thread.Sleep(100)
                    Application.DoEvents()
                    System.Threading.Thread.Sleep(100)
                    CheckJPGDirAndCreate()
                    Dim SaveName As String = JPGDir & FDate & "_" & FTime & "_" & Format(RunCounts, "000000") & ".jpg"
                    SaveFromToImage(FormRecipes, SaveName)
                    FormRecipes.Hide()
                End If
                RunProcess(recipe)
            Else
                FormRecipes.Hide()
                MsgBoxLangYesNo("»sµ{¤£°õ¦æ!", "Process stop.")
            End If
        Else
            RunProcess(recipe)
        End If

    End Sub
    Public Sub RunProcess(ByVal Recipe As String)
        Dim sstr As String = ""
        Dim sFile As String = ""
        Dim i As Integer
        FormKeyInProcessNames.ProcessFileName = FDate + "-" + FTime + "-[" + LoginUserName + "]"
        'Add By Vincent 20160913 Start  -------------------------------------------------------
        FormKeyInProcessNames.txtBarcodeInput.Text = ""
        FormKeyInProcessNames.txtBarcodeInput.Focus()
        'FormKeyInProcessNames.txtBarcodeInput.SelectAll()
        'Add By Vincent 20160913 End    -------------------------------------------------------
        If FormKeyInProcessNames.ShowDialog() = Windows.Forms.DialogResult.OK Then
            sstr = System.IO.Path.GetFileNameWithoutExtension(ProcessRecipeFileName)
            sFile = FormKeyInProcessNames.ProcessFileName ' Now.ToString("yyyyMMdd-HHmmss") & "-" & sstr & "-Lot-" & FormKeyInProcessNames.ProcessFileName
        Else
            Exit Sub
        End If

        'sFile = ProcessRecordFileName 'FormKeyInProcessNames.ProcessFileName
        ProcessPN = sFile
        ProcessRecordFileName = ProcessRecordDir + sFile + ".dat"
        ProcessRecordFileName1 = ProcessRecordDir + sFile + "_A.txt"
        ProcessRecordCurveFileName = ProcessRecordCurveDir + sFile + ".Proc"
        ProcessEeventFileName = ProcessEeventDir + "Event_" + FDate + "-" + FTime + "-[" + LoginUserName + "].dat"
        If FileIO.FileSystem.FileExists(ProcessRecordFileName) Then
            If MsgBoxLangYesNo("ÀÉ®×¤w¦s¦b,­nÂÐ»\?", "File Exist, Overwrite?") Then
                FileIO.FileSystem.DeleteFile(ProcessRecordFileName)
            Else
                Exit Sub
            End If
        End If

        '«Ø¥ß»sµ{°O¿ýÀÉ¦W
        CsvFilename = ProcessCSVDir + Recipe + ".csv"
        If FileIO.FileSystem.FileExists(ProcessRecordFileName) Then
            FileIO.FileSystem.DeleteFile(ProcessRecordFileName)
        End If
        If FileIO.FileSystem.FileExists(ProcessRecordFileName1) Then
            FileIO.FileSystem.DeleteFile(ProcessRecordFileName1)
        End If
        If FileIO.FileSystem.FileExists(ProcessRecordCurveFileName) Then
            FileIO.FileSystem.DeleteFile(ProcessRecordCurveFileName)
        End If
        If FileIO.FileSystem.FileExists(CsvFilename) Then
            FileIO.FileSystem.DeleteFile(CsvFilename)
        End If
        lblProcessStartTime.Text = TTime
        lblProcessStopTime.Text = "00:00:00"
        FormProcesss.Text = "Process [" + ProcessPN + "]"
        Timex = 0

        lblBasePressureSet.Text = Format(Val(RecipeNum(RecipeRunIndex).BasePressure), "0.0E+00")
        lblRecipeNote.Text = RecipeNum(RecipeRunIndex).RecipeNote
        lblWaferSize.Text = RecipeNum(RecipeRunIndex).WaferSize

        SetLangText(btnAbort, "©ñ±ó", "Abort")
        btnRunProcess.Enabled = False
        btnVent.Enabled = False
        FormMenus.btnExit.Enabled = False
        '''
        lblProcessDataFile.Text = ProcessPN + ".dat"

        For i = 0 To MAXPLATE
            PlateProcess(i).RunMode = ProcessMode_RUN
            CSubAutoProcess(i).Clear()
        Next
        ProcessMode_RUN = True
    End Sub
    Public Function LoadRecipe(ByVal RecipeFile As String) As Boolean
        Dim i As Integer
        i = RecipeRunIndex
        pgbReadCurve.Visible = True
        If Not ProcessMode_RUN Then
            Try
                'lblRecipeFileName.Text = RecipeFile
                'Debug.Print("lblRecipeFileName  _1=" + lblRecipeFileName.Text)
                ProcessRecipeFileName = lblRecipeFileName.Text
                ProcessRecipeName = Mid(ProcessRecipeFileName, 1, InStr(ProcessRecipeFileName, "."))
                'lblRecipeFileName.Text = ProcessRecipeFileName

                ProcessRecipeLongFileName = RecipeDir & ProcessRecipeFileName
                'ProcessRecipeLongFileName = FormRecipeSelects.RecipeDir & ProcessRecipeFileName
                'ReadRecipeFile(ProcessRecipeLongFileName)'Modified By Vincent 20190710 
                ReadRecipeFile(i, ProcessRecipeLongFileName) 'Add By Vincent 20190710 

                FormProcesss.lblRecipeNote.Text = RecipeNum(i).RecipeNote
                FormProcesss.lblBasePressureSet.Text = Format(Val(RecipeNum(i).BasePressure), "0.0E+00")
                FormProcesss.lblWaferSize.Text = RecipeNum(i).WaferSize


                chkBondBeforeVacuum.Checked = GetTrue01Boolean(RecipeNum(i).BondBeforeVacuum)
                chkKeepBonding.Checked = GetTrue01Boolean(RecipeNum(i).KeepBonding)
                chkVacuumMode.Checked = GetTrue01Boolean(RecipeNum(i).PumpingMode)
                chkVacuumPurge.Checked = GetTrue01Boolean(RecipeNum(i).VacuumPurge)
                chkAutoVent.Checked = GetTrue01Boolean(RecipeNum(i).AutoVent)
                chkAfterPurge.Checked = GetTrue01Boolean(RecipeNum(i).AfterPurge)
                chkAutoDoorOpen.Checked = GetTrue01Boolean(RecipeNum(i).AutoDoorOpen)

                'Purge Function Start
                chkBondBeforeVacuum.Checked = GetTrue01Boolean(RecipeNum(i).BondBeforeVacuum)
                chkKeepBonding.Checked = GetTrue01Boolean(RecipeNum(i).KeepBonding)
                chkVacuumMode.Checked = GetTrue01Boolean(RecipeNum(i).PumpingMode)
                chkVacuumPurge.Checked = GetTrue01Boolean(RecipeNum(i).VacuumPurge)
                chkAutoVent.Checked = GetTrue01Boolean(RecipeNum(i).AutoVent)


                chkPurgeCooling.Checked = GetTrue01Boolean(RecipeNum(i).PurgeCooling)
                txtAfterPurgeTemp.Text = RecipeNum(i).PurgeCoolingTemp
                txtPurgeONTime.Text = RecipeNum(i).PurgeONTime
                txtPurgeOFFTime.Text = RecipeNum(i).PurgeOFFTime
                chkPurgeKeepBonding.Checked = GetTrue01Boolean(RecipeNum(i).PurgeKeepBonding)
                'Purge Function Start
                If RecipeNum(i).BondingSync = "0" Then radBoth.Checked = True
                If RecipeNum(i).BondingSync = "1" Then radTemp.Checked = True
                If RecipeNum(i).BondingSync = "2" Then radPress.Checked = True
                RecipeLoaded = True
                Cal_PresetData(RecipeNum(i).TotalTime)
                For i = 0 To MAXPLATE
                    CSubAutoProcess(i).LoadPlateRecipe(RecipeNum(RecipeRunIndex).Plate(i))
                    PlateProcess(i).SetTempPress(Val(RecipeNum(RecipeRunIndex).Plate(i).Pressure(0)), Val(RecipeNum(RecipeRunIndex).Plate(i).Temperature(0)))
                Next
                pgbReadCurve.Visible = False

            Catch ex As Exception

                'MsgBoxLangErr(ex.Message)
                Return False
            End Try
        Else
            Return False
        End If
        Return True
    End Function

    Private Sub btnInLine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInLine.Click
        'If Get_PLC_R1100(DAProgramVersionIndex) <> 1 Then
        '    If CelloUsbFlag = False Then
        '        MsgBoxLangErr("µ{¦¡ª©¥»¤£¦P¡A¤£¯à°õ¦æ!", "Program version not matched!")
        '        Exit Sub
        '    End If
        'End If


        If RemoteCIM.Enable = False Then
            If MsgBoxLangYesNo("¬O§_­n±Ò°Ê»·ºÝ³s½u¼Ò¦¡?", "Change mode to IN-LINE?") = True Then
                RemoteCIM.ChangeToInLine()
                If SanAn_TCPIP_Used_Flag Then
                    tabProcessDataCurve.SelectTab(tpCIMInput)
                    CtlSanAnCIM1.Timer1.Enabled = True
                    CtlSanAnCIM1.txtOpID.Enabled = True
                    CtlSanAnCIM1.txtOpID.SelectAll()
                    CtlSanAnCIM1.txtOpID.Focus()
                End If
            End If
            End If
    End Sub

    Private Sub btnOffLine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOffLine.Click
        'If Rights_Recipe Then
        If RemoteCIM.Enable = True Then
            If MsgBoxLangYesNo("¬O§_­n°±¤î»·ºÝ³s½u¼Ò¦¡?", "Change mode to OFF-LINE?") = True Then
                RemoteCIM.ChangeToOffLine()
            End If
        End If
        'Else
        'MsgBoxLangErr("Åv­­¤£¨¬¡A¤£¯à¤U½u.", "No rights to set off-line.")
        'End If
    End Sub
    Public Function RemoteLoadRecipe() As Boolean
        'load
        Dim i, j As Integer
        RecipeFileName = RemoteCIM.RecipeData.RecipeName
        If RemoteCIM.RecipeData.RecipeFileName <> "" Then
            lblRecipeFileName.Text = IO.Path.GetFileNameWithoutExtension(RecipeFileName)
            'RecipeFileName = lblRecipeFileName.Text
            ProcessRecipeName = RecipeFileName
            If ReadRecipeFile(RecipeRunIndex, RemoteCIM.RecipeData.RecipeFileName) = False Then
                Return False
            End If
        Else
            Return False
        End If
        i = RecipeRunIndex
        pgbReadCurve.Visible = True
        FormRecipeSelects.RecipeDir = RecipeDir

        ProcessRecipeFileName = lblRecipeFileName.Text & ".rcp"
        ProcessRecipeName = lblRecipeFileName.Text

        ProcessRecipeLongFileName = RemoteCIM.RecipeData.RecipeFileName

        ReadRecipeFile(RecipeRunIndex, ProcessRecipeLongFileName)



        FormProcesss.lblRecipeNote.Text = RecipeNum(i).RecipeNote
        FormProcesss.lblBasePressureSet.Text = Format(Val(RecipeNum(i).BasePressure), "0.0E+00")
        FormProcesss.lblWaferSize.Text = RecipeNum(i).WaferSize


        chkBondBeforeVacuum.Checked = GetTrue01Boolean(RecipeNum(i).BondBeforeVacuum)
        chkKeepBonding.Checked = GetTrue01Boolean(RecipeNum(i).KeepBonding)
        chkVacuumMode.Checked = GetTrue01Boolean(RecipeNum(i).PumpingMode)
        chkVacuumPurge.Checked = GetTrue01Boolean(RecipeNum(i).VacuumPurge)
        chkAutoVent.Checked = GetTrue01Boolean(RecipeNum(i).AutoVent)
        chkAfterPurge.Checked = GetTrue01Boolean(RecipeNum(i).AfterPurge)
        chkAutoDoorOpen.Checked = GetTrue01Boolean(RecipeNum(i).AutoDoorOpen)
        'chkDoorOpenBondDown.Checked = GetTrue01Boolean(RecipeNum(i).DoorOpenBondDown)

        If RecipeNum(i).BondingSync = "0" Then radBoth.Checked = True
        If RecipeNum(i).BondingSync = "1" Then radTemp.Checked = True
        If RecipeNum(i).BondingSync = "2" Then radPress.Checked = True
        'Purge Function Start
        chkBondBeforeVacuum.Checked = GetTrue01Boolean(RecipeNum(i).BondBeforeVacuum)
        chkKeepBonding.Checked = GetTrue01Boolean(RecipeNum(i).KeepBonding)
        chkVacuumMode.Checked = GetTrue01Boolean(RecipeNum(i).PumpingMode)
        chkVacuumPurge.Checked = GetTrue01Boolean(RecipeNum(i).VacuumPurge)
        chkAutoVent.Checked = GetTrue01Boolean(RecipeNum(i).AutoVent)
        'chkDoorOpenBondDown.Checked = GetTrue01Boolean(RecipeNum(i).DoorOpenBondDown)

        chkPurgeCooling.Checked = GetTrue01Boolean(RecipeNum(i).PurgeCooling)
        txtAfterPurgeTemp.Text = RecipeNum(i).PurgeCoolingTemp
        txtPurgeONTime.Text = RecipeNum(i).PurgeONTime
        txtPurgeOFFTime.Text = RecipeNum(i).PurgeOFFTime
        chkPurgeKeepBonding.Checked = GetTrue01Boolean(RecipeNum(i).PurgeKeepBonding)
        'Purge Function Start


        RecipeLoaded = True
        Cal_PresetData(RecipeNum(i).TotalTime)
        'chartpe.ChartAreas(0).AxisX.Maximum = TotalStepTime + 1000
        pgbReadCurve.Visible = False
        Return True
    End Function


    Public Function ConfirmLoad() As Boolean
        If RemoteCIM.ConfirmEnable Then
            If MsgBoxLangYesNo("¬O§_°õ¦æ»sµ{?  °t¤èÀÉ®×: " + RemoteCIM.RecipeData.RecipeName,
                            "Confirm to run process? Recipe: " + RemoteCIM.RecipeData.RecipeName) = False Then
                'MsgBoxLangErr("»sµ{¥¼°õ¦æ!", "Process not excuted!")
                RemoteCIM.ErrorString = GetLangText("»sµ{¥¼°õ¦æ!", "Process not excuted!")
                RemoteCIM.ProcessGo = False
                RemoteCIM.Pause = False
                Return False
            Else
                RemoteCIM.ProcessGo = True
                RemoteCIM.Pause = False
                Return True
            End If
        Else
            RemoteCIM.ProcessGo = True
            RemoteCIM.Pause = False
            Return True
        End If
    End Function


    Public Function RemoteRunProcess() As Boolean
        Dim sFile As String
        Dim i As Integer
        CheckProcessDateAndCreate()
        'RemoteLoadRecipe()
        For i = 0 To MAXPLATE
            CSubAutoProcess(i).SubProcessRunStepIndex = 0
            CSubAutoProcess(i).LoadPlateRecipe(RecipeNum(RecipeRunIndex).Plate(i))
            Dim TopTemp1 As Integer
            Dim BotTemp1 As Integer
            TopTemp1 = TempCal(i).GetTICTopTemp(Val(RecipeNum(RecipeRunIndex).Plate(i).Temperature(0)))
            BotTemp1 = TempCal(i).GetTICBotTemp(Val(RecipeNum(RecipeRunIndex).Plate(i).Temperature(0))) 'TempTopSV 'Modified by Vincent 20180419 
            ManualControl(i).WriteTempData(TopTemp1, BotTemp1, RecipeNum(RecipeRunIndex).Plate(i).Temperature_Rate(0))
            'ManualControl(i).WriteTempData(RecipeNum(RecipeRunIndex).Plate(i).Temperature(0), RecipeNum(RecipeRunIndex).Plate(i).Temperature_Rate(0))
            ManualControl(i).WritePressData(RecipeNum(RecipeRunIndex).Plate(i).Pressure(0), RecipeNum(RecipeRunIndex).Plate(i).Pressure_Rate(0))

        Next

        FormKeyInProcessNames.RemoteEnter(RemoteCIM.PorcessDataFileName)
        ProcessRecordShortFileName = FormKeyInProcessNames.ProcessFileName
        ProcessRecordFileName = ProcessRecordDir + ProcessRecordShortFileName + ".dat"
        ProcessEeventFileName = ProcessEeventDir + "Event_" + FDate + "-" + FTime + "-[" + LoginUserName + "].dat"
        If FileIO.FileSystem.FileExists(ProcessRecordFileName) Then
            'If MsgBoxLangYesNo("ÀÉ®×¤w¦s¦b,­nÂÐ»\?", "‰ã®×¤w¦s¦b,­nÂÐ‡I?", "File Exist, Overwrite?") Then
            FileIO.FileSystem.DeleteFile(ProcessRecordFileName)
            'Else
            'Exit Function
        End If
        'End If
        'Cal_PresetData(RecipeNum(RecipeRunIndex).TotalTime)
        sFile = FormKeyInProcessNames.ProcessFileName
        ProcessPN = sFile
        'lblProcessRecordFileName.Text = ProcessRecordShortFileName 'Remark By vincent  '20190710
        'ToolTip1.SetToolTip(lblProcessRecordFileName, lblProcessRecordFileName.Text) 'Remark By vincent  '20190710
        ProcessPN = ProcessRecordShortFileName
        ProcessRecordFileName = ProcessRecordDir + ProcessRecordShortFileName + ".dat"
        ProcessRecordFileName1 = ProcessRecordDir + sFile + "_A.txt"
        ProcessRecordCurveFileName = ProcessRecordCurveDir + ProcessRecordShortFileName + ".Proc"

        CsvFilename = ProcessCSVDir + ProcessRecordShortFileName + ".csv"
        CsvFilename1 = ProcessCSVDir + ProcessRecordShortFileName + "_A.csv"
        lblProcessStartTime.Text = TTime
        lblProcessStopTime.Text = "00:00:00"

        FormProcesss.Text = "Process [" + ProcessPN + "]"

        lblBasePressureSet.Text = Format(Val(RecipeNum(RecipeRunIndex).BasePressure), "0.0E+00")
        lblRecipeNote.Text = RecipeNum(RecipeRunIndex).RecipeNote
        lblWaferSize.Text = RecipeNum(RecipeRunIndex).WaferSize


        SetLangText(btnAbort, "©ñ±ó", "Abort")
        btnRunProcess.Enabled = False
        btnVent.Enabled = False
        FormMenus.btnExit.Enabled = False
        Timex = 0

        ProcessMode_RUN = True
        ProcessNormalEnd = False
        For i = 0 To MAXPLATE
            PlateProcess(i).RunMode = ProcessMode_RUN
            CSubAutoProcess(i).Clear()
        Next
        Return True

    End Function

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        If ProcessMode_RUN Then
            MsgBoxLangErr("»sµ{¤¤", "Processing!")
            Exit Sub
        End If

        If SystemParameters.BarcodeOnly = "1" Then
            If txtRecipeFile.Text.Length > 0 Then
                CheckBarcodeInput()
            End If
        End If
    End Sub
    Public Function CheeckRecipeExist(ByVal file As String) As Boolean
        Dim rcp As String = RecipeDir & txtRecipeFile.Text & ".rcp"
        Return IO.File.Exists(rcp)
    End Function
    Public Sub CheckBarcodeInput()
        Dim rcp As String = RecipeDir & txtRecipeFile.Text & ".rcp"
        If CheeckRecipeExist(RecipeDir & txtRecipeFile.Text & ".rcp") = False Then
            txtRecipeFile.Text = ""
            txtRecipeFile.Focus()
            txtRecipeFile.SelectAll()
            MsgBoxLangErr("°t¤èÀÉ¦W¤£¦s¦b!", "Recipe file not exist!")
        Else
            AutoLoadRecipeThenRun(txtRecipeFile.Text)
            txtRecipeFile.Text = ""
            txtRecipeFile.Focus()
            txtRecipeFile.SelectAll()
        End If
    End Sub
    'SanAn CIM  20190710  by vincent ---------------- End
#End Region
End Class

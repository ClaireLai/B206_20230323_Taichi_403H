Public Class FormManual
    Inherits System.Windows.Forms.Form

    Friend WithEvents btnAutoPurge As System.Windows.Forms.Button
    Friend WithEvents lblCUPUsage As System.Windows.Forms.Label
    Friend WithEvents tabManualLog As System.Windows.Forms.TabControl
    Friend WithEvents tabPageDataLog As System.Windows.Forms.TabPage
    Friend WithEvents lblSec02Text As System.Windows.Forms.Label
    Friend WithEvents lblDataLogStepTimeText As System.Windows.Forms.Label
    Friend WithEvents btnOpenLogFile As System.Windows.Forms.Button
    Friend WithEvents btnStartLog As System.Windows.Forms.Button
    Friend WithEvents lblDatalogFileName As System.Windows.Forms.Label
    Friend WithEvents txtDataLogStepTime As System.Windows.Forms.TextBox
    Friend WithEvents tabPageTimer As System.Windows.Forms.TabPage
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lblTimerMin As System.Windows.Forms.Label
    Friend WithEvents txtTimerSec As System.Windows.Forms.TextBox
    Friend WithEvents btnTimerStart As System.Windows.Forms.Button
    Friend WithEvents lblTimerSec As System.Windows.Forms.Label
    Friend WithEvents lblTimerMinText As System.Windows.Forms.Label
    Friend WithEvents txtTimerMin As System.Windows.Forms.TextBox
    Friend WithEvents lblTimerSecText As System.Windows.Forms.Label
    Friend WithEvents btnTimerReset As System.Windows.Forms.Button
    Friend WithEvents pnlVacuumCurve As System.Windows.Forms.Panel
    Friend WithEvents btnAutoVacuum As System.Windows.Forms.Button
    Friend WithEvents btnPumpProtection As System.Windows.Forms.Button
    Friend WithEvents lblPumpingStatus As System.Windows.Forms.Label
    Friend WithEvents lblCursorValue As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblVentText As System.Windows.Forms.Label
    Friend WithEvents picDP As System.Windows.Forms.PictureBox
    Friend WithEvents lblN2Text As System.Windows.Forms.Label
    Friend WithEvents picRVP As System.Windows.Forms.PictureBox
    Friend WithEvents lblDPText As System.Windows.Forms.Label
    Friend WithEvents picPipeV02 As System.Windows.Forms.PictureBox
    Friend WithEvents picV4P As System.Windows.Forms.PictureBox
    Friend WithEvents picPipeV01 As System.Windows.Forms.PictureBox
    Friend WithEvents lblRVText As System.Windows.Forms.Label
    Friend WithEvents pnlChamberRight As System.Windows.Forms.Panel
    Friend WithEvents pnlChamberLeft As System.Windows.Forms.Panel
    Friend WithEvents pnlDoor2 As System.Windows.Forms.Panel
    Friend WithEvents pnlDoor1 As System.Windows.Forms.Panel
    Friend WithEvents lblDPCurrent As System.Windows.Forms.Label
    Friend WithEvents lblA03Text As System.Windows.Forms.Label
    Friend WithEvents lblTorr02Text As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblCHVac As System.Windows.Forms.Label
    Friend WithEvents lbl1ATM As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblMin01Text As System.Windows.Forms.Label
    Friend WithEvents lblSec01Text As System.Windows.Forms.Label
    Friend WithEvents tabManual As System.Windows.Forms.TabControl
    Friend WithEvents tabPage1to3 As System.Windows.Forms.TabPage
    Friend WithEvents tabPage4to6 As System.Windows.Forms.TabPage
    Friend WithEvents flwManualPage1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents flwManualPage2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents tabPageVacuum As System.Windows.Forms.TabPage
    Friend WithEvents flwManualChart1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents flwManualChart2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents picGas01T As System.Windows.Forms.PictureBox
    Friend WithEvents lblV10TText As System.Windows.Forms.Label
    Friend WithEvents PictureBox94 As System.Windows.Forms.PictureBox
    Friend WithEvents lblGas02Text As System.Windows.Forms.Label
    Friend WithEvents lblGas02MFC As System.Windows.Forms.Label
    Friend WithEvents txtGas02MFCSet As System.Windows.Forms.TextBox
    Friend WithEvents lblGas01Text As System.Windows.Forms.Label
    Friend WithEvents txtGas01MFCSet As System.Windows.Forms.TextBox
    Friend WithEvents lblGas01MFC As System.Windows.Forms.Label
    Friend WithEvents picGas02T As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox100 As System.Windows.Forms.PictureBox
    Friend WithEvents lblV11TText As System.Windows.Forms.Label
    Friend WithEvents grpDoorControl As System.Windows.Forms.GroupBox
    Friend WithEvents btnDoor2Up As System.Windows.Forms.Button
    Friend WithEvents btnDoor1Up As System.Windows.Forms.Button
    Friend WithEvents btnDoor2Down As System.Windows.Forms.Button
    Friend WithEvents btnDoor1Down As System.Windows.Forms.Button
    Friend WithEvents picDoor2 As System.Windows.Forms.PictureBox
    Friend WithEvents picDoor1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnSaveAs As System.Windows.Forms.Button
    Friend WithEvents lblMFCTime02 As System.Windows.Forms.Label
    Friend WithEvents lblMFCTime01 As System.Windows.Forms.Label
    Friend WithEvents btnChamberLight As System.Windows.Forms.Button
    Friend WithEvents pnlMFC02 As System.Windows.Forms.Panel
    Friend WithEvents pnlMFC01 As System.Windows.Forms.Panel
    Friend WithEvents btnPullerClose As System.Windows.Forms.Button
    Friend WithEvents picC05 As System.Windows.Forms.PictureBox
    Friend WithEvents lblDPTemp As System.Windows.Forms.Label
    Private X As Single '·í«eµ¡Åéªº¼e«×
    Private Y As Single '·í«eµ¡Åéªº°ª«×
    Private isLoaded As Boolean '// ¬O§_¤w³]©w¦U±±¨îªº¤Ø¤o¸ê®Æ¨ìTagÄÝ©Ê
    Private FormW As Integer
    Private FormH As Integer
    Dim maxvalue(10) As Double
#Region " Windows Form ³]­p¤u¨ã²£¥Íªºµ{¦¡½X "

    Public Sub New()
        MyBase.New()

        '¦¹©I¥s¬° Windows Form ³]­p¤u¨ãªº¥²­n¶µ¡C
        InitializeComponent()
        isLoaded = False
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
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnYReset As System.Windows.Forms.Button
    Friend WithEvents btnPrintCurve As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormManual))
        Me.pnlVacuumCurve = New System.Windows.Forms.Panel
        Me.lblPumpingStatus = New System.Windows.Forms.Label
        Me.lblCUPUsage = New System.Windows.Forms.Label
        Me.btnAutoPurge = New System.Windows.Forms.Button
        Me.tabManualLog = New System.Windows.Forms.TabControl
        Me.tabPageDataLog = New System.Windows.Forms.TabPage
        Me.lblSec02Text = New System.Windows.Forms.Label
        Me.lblDataLogStepTimeText = New System.Windows.Forms.Label
        Me.btnOpenLogFile = New System.Windows.Forms.Button
        Me.btnStartLog = New System.Windows.Forms.Button
        Me.lblDatalogFileName = New System.Windows.Forms.Label
        Me.txtDataLogStepTime = New System.Windows.Forms.TextBox
        Me.tabPageTimer = New System.Windows.Forms.TabPage
        Me.lblTimerMin = New System.Windows.Forms.Label
        Me.txtTimerSec = New System.Windows.Forms.TextBox
        Me.btnTimerStart = New System.Windows.Forms.Button
        Me.lblTimerSec = New System.Windows.Forms.Label
        Me.lblMin01Text = New System.Windows.Forms.Label
        Me.lblTimerMinText = New System.Windows.Forms.Label
        Me.txtTimerMin = New System.Windows.Forms.TextBox
        Me.lblSec01Text = New System.Windows.Forms.Label
        Me.lblTimerSecText = New System.Windows.Forms.Label
        Me.btnTimerReset = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnYReset = New System.Windows.Forms.Button
        Me.btnPrintCurve = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.btnAutoVacuum = New System.Windows.Forms.Button
        Me.btnPumpProtection = New System.Windows.Forms.Button
        Me.lblCursorValue = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.pnlMFC02 = New System.Windows.Forms.Panel
        Me.lblV11TText = New System.Windows.Forms.Label
        Me.lblMFCTime02 = New System.Windows.Forms.Label
        Me.picGas02T = New System.Windows.Forms.PictureBox
        Me.txtGas02MFCSet = New System.Windows.Forms.TextBox
        Me.lblGas02MFC = New System.Windows.Forms.Label
        Me.lblGas02Text = New System.Windows.Forms.Label
        Me.PictureBox100 = New System.Windows.Forms.PictureBox
        Me.pnlMFC01 = New System.Windows.Forms.Panel
        Me.lblMFCTime01 = New System.Windows.Forms.Label
        Me.lblGas01Text = New System.Windows.Forms.Label
        Me.txtGas01MFCSet = New System.Windows.Forms.TextBox
        Me.lblGas01MFC = New System.Windows.Forms.Label
        Me.picGas01T = New System.Windows.Forms.PictureBox
        Me.lblV10TText = New System.Windows.Forms.Label
        Me.PictureBox94 = New System.Windows.Forms.PictureBox
        Me.picDoor2 = New System.Windows.Forms.PictureBox
        Me.picDoor1 = New System.Windows.Forms.PictureBox
        Me.pnlChamberLeft = New System.Windows.Forms.Panel
        Me.lblVentText = New System.Windows.Forms.Label
        Me.picDP = New System.Windows.Forms.PictureBox
        Me.lblN2Text = New System.Windows.Forms.Label
        Me.picRVP = New System.Windows.Forms.PictureBox
        Me.lblDPText = New System.Windows.Forms.Label
        Me.picPipeV02 = New System.Windows.Forms.PictureBox
        Me.picV4P = New System.Windows.Forms.PictureBox
        Me.picPipeV01 = New System.Windows.Forms.PictureBox
        Me.lblRVText = New System.Windows.Forms.Label
        Me.pnlChamberRight = New System.Windows.Forms.Panel
        Me.pnlDoor2 = New System.Windows.Forms.Panel
        Me.pnlDoor1 = New System.Windows.Forms.Panel
        Me.lblDPCurrent = New System.Windows.Forms.Label
        Me.lblA03Text = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.lblCHVac = New System.Windows.Forms.Label
        Me.lbl1ATM = New System.Windows.Forms.Label
        Me.lblTorr02Text = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnSaveAs = New System.Windows.Forms.Button
        Me.tabManual = New System.Windows.Forms.TabControl
        Me.tabPageVacuum = New System.Windows.Forms.TabPage
        Me.btnChamberLight = New System.Windows.Forms.Button
        Me.grpDoorControl = New System.Windows.Forms.GroupBox
        Me.btnPullerClose = New System.Windows.Forms.Button
        Me.btnDoor2Down = New System.Windows.Forms.Button
        Me.btnDoor1Down = New System.Windows.Forms.Button
        Me.btnDoor2Up = New System.Windows.Forms.Button
        Me.btnDoor1Up = New System.Windows.Forms.Button
        Me.tabPage1to3 = New System.Windows.Forms.TabPage
        Me.flwManualChart1 = New System.Windows.Forms.FlowLayoutPanel
        Me.flwManualPage1 = New System.Windows.Forms.FlowLayoutPanel
        Me.tabPage4to6 = New System.Windows.Forms.TabPage
        Me.flwManualChart2 = New System.Windows.Forms.FlowLayoutPanel
        Me.flwManualPage2 = New System.Windows.Forms.FlowLayoutPanel
        Me.picC05 = New System.Windows.Forms.PictureBox
        Me.lblDPTemp = New System.Windows.Forms.Label
        Me.tabManualLog.SuspendLayout()
        Me.tabPageDataLog.SuspendLayout()
        Me.tabPageTimer.SuspendLayout()
        Me.Panel2.SuspendLayout()
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
        Me.Panel1.SuspendLayout()
        Me.tabManual.SuspendLayout()
        Me.tabPageVacuum.SuspendLayout()
        Me.grpDoorControl.SuspendLayout()
        Me.tabPage1to3.SuspendLayout()
        Me.tabPage4to6.SuspendLayout()
        CType(Me.picC05, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlVacuumCurve
        '
        Me.pnlVacuumCurve.Location = New System.Drawing.Point(2, 42)
        Me.pnlVacuumCurve.Name = "pnlVacuumCurve"
        Me.pnlVacuumCurve.Size = New System.Drawing.Size(548, 322)
        Me.pnlVacuumCurve.TabIndex = 524
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
        'lblCUPUsage
        '
        Me.lblCUPUsage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCUPUsage.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCUPUsage.ForeColor = System.Drawing.Color.Red
        Me.lblCUPUsage.Location = New System.Drawing.Point(22, 63)
        Me.lblCUPUsage.Name = "lblCUPUsage"
        Me.lblCUPUsage.Size = New System.Drawing.Size(77, 32)
        Me.lblCUPUsage.TabIndex = 3
        Me.lblCUPUsage.Text = "50%"
        Me.lblCUPUsage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCUPUsage.Visible = False
        '
        'btnAutoPurge
        '
        Me.btnAutoPurge.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAutoPurge.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAutoPurge.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAutoPurge.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAutoPurge.Location = New System.Drawing.Point(338, 312)
        Me.btnAutoPurge.Name = "btnAutoPurge"
        Me.btnAutoPurge.Size = New System.Drawing.Size(108, 44)
        Me.btnAutoPurge.TabIndex = 84
        Me.btnAutoPurge.Text = "Auto Purge"
        Me.btnAutoPurge.UseVisualStyleBackColor = False
        '
        'tabManualLog
        '
        Me.tabManualLog.Controls.Add(Me.tabPageDataLog)
        Me.tabManualLog.Controls.Add(Me.tabPageTimer)
        Me.tabManualLog.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabManualLog.ItemSize = New System.Drawing.Size(140, 50)
        Me.tabManualLog.Location = New System.Drawing.Point(8, 373)
        Me.tabManualLog.Margin = New System.Windows.Forms.Padding(0)
        Me.tabManualLog.Multiline = True
        Me.tabManualLog.Name = "tabManualLog"
        Me.tabManualLog.Padding = New System.Drawing.Point(0, 0)
        Me.tabManualLog.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tabManualLog.SelectedIndex = 0
        Me.tabManualLog.Size = New System.Drawing.Size(449, 294)
        Me.tabManualLog.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tabManualLog.TabIndex = 517
        '
        'tabPageDataLog
        '
        Me.tabPageDataLog.BackColor = System.Drawing.SystemColors.Control
        Me.tabPageDataLog.Controls.Add(Me.lblSec02Text)
        Me.tabPageDataLog.Controls.Add(Me.lblDataLogStepTimeText)
        Me.tabPageDataLog.Controls.Add(Me.btnOpenLogFile)
        Me.tabPageDataLog.Controls.Add(Me.btnStartLog)
        Me.tabPageDataLog.Controls.Add(Me.lblDatalogFileName)
        Me.tabPageDataLog.Controls.Add(Me.txtDataLogStepTime)
        Me.tabPageDataLog.Location = New System.Drawing.Point(4, 54)
        Me.tabPageDataLog.Name = "tabPageDataLog"
        Me.tabPageDataLog.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageDataLog.Size = New System.Drawing.Size(441, 236)
        Me.tabPageDataLog.TabIndex = 0
        Me.tabPageDataLog.Text = "¸ê®Æ°O¿ý"
        '
        'lblSec02Text
        '
        Me.lblSec02Text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSec02Text.ForeColor = System.Drawing.Color.Black
        Me.lblSec02Text.Location = New System.Drawing.Point(256, 90)
        Me.lblSec02Text.Name = "lblSec02Text"
        Me.lblSec02Text.Size = New System.Drawing.Size(41, 19)
        Me.lblSec02Text.TabIndex = 113
        Me.lblSec02Text.Text = "Sec"
        Me.lblSec02Text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDataLogStepTimeText
        '
        Me.lblDataLogStepTimeText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataLogStepTimeText.ForeColor = System.Drawing.Color.Black
        Me.lblDataLogStepTimeText.Location = New System.Drawing.Point(36, 90)
        Me.lblDataLogStepTimeText.Name = "lblDataLogStepTimeText"
        Me.lblDataLogStepTimeText.Size = New System.Drawing.Size(129, 19)
        Me.lblDataLogStepTimeText.TabIndex = 115
        Me.lblDataLogStepTimeText.Text = "°O¿ý¶¡¹j(¬í):"
        Me.lblDataLogStepTimeText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnOpenLogFile
        '
        Me.btnOpenLogFile.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnOpenLogFile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOpenLogFile.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenLogFile.ForeColor = System.Drawing.Color.Black
        Me.btnOpenLogFile.Location = New System.Drawing.Point(171, 27)
        Me.btnOpenLogFile.Name = "btnOpenLogFile"
        Me.btnOpenLogFile.Size = New System.Drawing.Size(114, 41)
        Me.btnOpenLogFile.TabIndex = 118
        Me.btnOpenLogFile.Text = "¶}±ÒÀÉ®×"
        Me.btnOpenLogFile.UseVisualStyleBackColor = False
        '
        'btnStartLog
        '
        Me.btnStartLog.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnStartLog.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStartLog.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartLog.ForeColor = System.Drawing.Color.Black
        Me.btnStartLog.Location = New System.Drawing.Point(13, 24)
        Me.btnStartLog.Name = "btnStartLog"
        Me.btnStartLog.Size = New System.Drawing.Size(114, 41)
        Me.btnStartLog.TabIndex = 112
        Me.btnStartLog.Text = "¶}©l°O¿ý"
        Me.btnStartLog.UseVisualStyleBackColor = False
        '
        'lblDatalogFileName
        '
        Me.lblDatalogFileName.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblDatalogFileName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDatalogFileName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatalogFileName.ForeColor = System.Drawing.Color.Black
        Me.lblDatalogFileName.Location = New System.Drawing.Point(3, 130)
        Me.lblDatalogFileName.Name = "lblDatalogFileName"
        Me.lblDatalogFileName.Size = New System.Drawing.Size(431, 68)
        Me.lblDatalogFileName.TabIndex = 117
        Me.lblDatalogFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDataLogStepTime
        '
        Me.txtDataLogStepTime.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataLogStepTime.Location = New System.Drawing.Point(171, 86)
        Me.txtDataLogStepTime.Name = "txtDataLogStepTime"
        Me.txtDataLogStepTime.Size = New System.Drawing.Size(79, 26)
        Me.txtDataLogStepTime.TabIndex = 116
        Me.txtDataLogStepTime.Text = "5"
        Me.txtDataLogStepTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tabPageTimer
        '
        Me.tabPageTimer.BackColor = System.Drawing.SystemColors.Control
        Me.tabPageTimer.Controls.Add(Me.lblTimerMin)
        Me.tabPageTimer.Controls.Add(Me.txtTimerSec)
        Me.tabPageTimer.Controls.Add(Me.btnTimerStart)
        Me.tabPageTimer.Controls.Add(Me.lblTimerSec)
        Me.tabPageTimer.Controls.Add(Me.lblMin01Text)
        Me.tabPageTimer.Controls.Add(Me.lblTimerMinText)
        Me.tabPageTimer.Controls.Add(Me.txtTimerMin)
        Me.tabPageTimer.Controls.Add(Me.lblSec01Text)
        Me.tabPageTimer.Controls.Add(Me.lblTimerSecText)
        Me.tabPageTimer.Controls.Add(Me.btnTimerReset)
        Me.tabPageTimer.Location = New System.Drawing.Point(4, 54)
        Me.tabPageTimer.Name = "tabPageTimer"
        Me.tabPageTimer.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageTimer.Size = New System.Drawing.Size(441, 236)
        Me.tabPageTimer.TabIndex = 1
        Me.tabPageTimer.Text = "­p®É¾¹"
        '
        'lblTimerMin
        '
        Me.lblTimerMin.BackColor = System.Drawing.Color.Black
        Me.lblTimerMin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTimerMin.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimerMin.ForeColor = System.Drawing.Color.Lime
        Me.lblTimerMin.Location = New System.Drawing.Point(16, 55)
        Me.lblTimerMin.Name = "lblTimerMin"
        Me.lblTimerMin.Size = New System.Drawing.Size(81, 29)
        Me.lblTimerMin.TabIndex = 109
        Me.lblTimerMin.Text = "0"
        Me.lblTimerMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTimerSec
        '
        Me.txtTimerSec.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimerSec.Location = New System.Drawing.Point(157, 13)
        Me.txtTimerSec.Name = "txtTimerSec"
        Me.txtTimerSec.Size = New System.Drawing.Size(81, 29)
        Me.txtTimerSec.TabIndex = 11
        Me.txtTimerSec.Text = "0"
        Me.txtTimerSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnTimerStart
        '
        Me.btnTimerStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnTimerStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTimerStart.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimerStart.ForeColor = System.Drawing.Color.Black
        Me.btnTimerStart.Location = New System.Drawing.Point(16, 114)
        Me.btnTimerStart.Name = "btnTimerStart"
        Me.btnTimerStart.Size = New System.Drawing.Size(116, 39)
        Me.btnTimerStart.TabIndex = 84
        Me.btnTimerStart.Text = "¶}©l­p®É"
        Me.btnTimerStart.UseVisualStyleBackColor = False
        '
        'lblTimerSec
        '
        Me.lblTimerSec.BackColor = System.Drawing.Color.Black
        Me.lblTimerSec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTimerSec.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimerSec.ForeColor = System.Drawing.Color.Lime
        Me.lblTimerSec.Location = New System.Drawing.Point(157, 55)
        Me.lblTimerSec.Name = "lblTimerSec"
        Me.lblTimerSec.Size = New System.Drawing.Size(81, 29)
        Me.lblTimerSec.TabIndex = 97
        Me.lblTimerSec.Text = "0"
        Me.lblTimerSec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMin01Text
        '
        Me.lblMin01Text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMin01Text.ForeColor = System.Drawing.Color.Black
        Me.lblMin01Text.Location = New System.Drawing.Point(100, 55)
        Me.lblMin01Text.Name = "lblMin01Text"
        Me.lblMin01Text.Size = New System.Drawing.Size(51, 29)
        Me.lblMin01Text.TabIndex = 2
        Me.lblMin01Text.Text = "Min"
        Me.lblMin01Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTimerMinText
        '
        Me.lblTimerMinText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimerMinText.ForeColor = System.Drawing.Color.Black
        Me.lblTimerMinText.Location = New System.Drawing.Point(100, 13)
        Me.lblTimerMinText.Name = "lblTimerMinText"
        Me.lblTimerMinText.Size = New System.Drawing.Size(51, 29)
        Me.lblTimerMinText.TabIndex = 2
        Me.lblTimerMinText.Text = "Min"
        Me.lblTimerMinText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTimerMin
        '
        Me.txtTimerMin.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimerMin.Location = New System.Drawing.Point(16, 13)
        Me.txtTimerMin.Name = "txtTimerMin"
        Me.txtTimerMin.Size = New System.Drawing.Size(81, 29)
        Me.txtTimerMin.TabIndex = 10
        Me.txtTimerMin.Text = "0"
        Me.txtTimerMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblSec01Text
        '
        Me.lblSec01Text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSec01Text.ForeColor = System.Drawing.Color.Black
        Me.lblSec01Text.Location = New System.Drawing.Point(244, 13)
        Me.lblSec01Text.Name = "lblSec01Text"
        Me.lblSec01Text.Size = New System.Drawing.Size(51, 29)
        Me.lblSec01Text.TabIndex = 2
        Me.lblSec01Text.Text = "Sec"
        Me.lblSec01Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTimerSecText
        '
        Me.lblTimerSecText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimerSecText.ForeColor = System.Drawing.Color.Black
        Me.lblTimerSecText.Location = New System.Drawing.Point(244, 57)
        Me.lblTimerSecText.Name = "lblTimerSecText"
        Me.lblTimerSecText.Size = New System.Drawing.Size(51, 29)
        Me.lblTimerSecText.TabIndex = 2
        Me.lblTimerSecText.Text = "Sec"
        Me.lblTimerSecText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnTimerReset
        '
        Me.btnTimerReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnTimerReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTimerReset.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimerReset.ForeColor = System.Drawing.Color.Black
        Me.btnTimerReset.Location = New System.Drawing.Point(157, 114)
        Me.btnTimerReset.Name = "btnTimerReset"
        Me.btnTimerReset.Size = New System.Drawing.Size(116, 39)
        Me.btnTimerReset.TabIndex = 85
        Me.btnTimerReset.Text = "²M°£¸ê®Æ"
        Me.btnTimerReset.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'btnYReset
        '
        Me.btnYReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnYReset.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular)
        Me.btnYReset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnYReset.Location = New System.Drawing.Point(227, 2)
        Me.btnYReset.Name = "btnYReset"
        Me.btnYReset.Size = New System.Drawing.Size(62, 36)
        Me.btnYReset.TabIndex = 520
        Me.btnYReset.Text = "­«³]"
        Me.btnYReset.UseVisualStyleBackColor = False
        '
        'btnPrintCurve
        '
        Me.btnPrintCurve.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPrintCurve.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular)
        Me.btnPrintCurve.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnPrintCurve.Location = New System.Drawing.Point(3, 4)
        Me.btnPrintCurve.Name = "btnPrintCurve"
        Me.btnPrintCurve.Size = New System.Drawing.Size(62, 36)
        Me.btnPrintCurve.TabIndex = 522
        Me.btnPrintCurve.Text = "¦C¦L"
        Me.btnPrintCurve.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnAutoVacuum
        '
        Me.btnAutoVacuum.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAutoVacuum.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAutoVacuum.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAutoVacuum.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAutoVacuum.Location = New System.Drawing.Point(338, 193)
        Me.btnAutoVacuum.Name = "btnAutoVacuum"
        Me.btnAutoVacuum.Size = New System.Drawing.Size(108, 44)
        Me.btnAutoVacuum.TabIndex = 532
        Me.btnAutoVacuum.Text = "¦Û°Ê©â®ð"
        Me.btnAutoVacuum.UseVisualStyleBackColor = False
        '
        'btnPumpProtection
        '
        Me.btnPumpProtection.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPumpProtection.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPumpProtection.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPumpProtection.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPumpProtection.Location = New System.Drawing.Point(338, 252)
        Me.btnPumpProtection.Name = "btnPumpProtection"
        Me.btnPumpProtection.Size = New System.Drawing.Size(108, 44)
        Me.btnPumpProtection.TabIndex = 533
        Me.btnPumpProtection.Text = "¯uªÅºû«ù"
        Me.btnPumpProtection.UseVisualStyleBackColor = False
        '
        'lblCursorValue
        '
        Me.lblCursorValue.BackColor = System.Drawing.Color.Black
        Me.lblCursorValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCursorValue.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCursorValue.ForeColor = System.Drawing.Color.Lime
        Me.lblCursorValue.Location = New System.Drawing.Point(295, 4)
        Me.lblCursorValue.Name = "lblCursorValue"
        Me.lblCursorValue.Size = New System.Drawing.Size(252, 31)
        Me.lblCursorValue.TabIndex = 540
        Me.lblCursorValue.Text = "[0,0]"
        Me.lblCursorValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.Panel2.Controls.Add(Me.pnlDoor2)
        Me.Panel2.Controls.Add(Me.pnlDoor1)
        Me.Panel2.Controls.Add(Me.lblDPCurrent)
        Me.Panel2.Controls.Add(Me.lblA03Text)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(5, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(449, 367)
        Me.Panel2.TabIndex = 541
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
        Me.pnlMFC02.Location = New System.Drawing.Point(228, 100)
        Me.pnlMFC02.Name = "pnlMFC02"
        Me.pnlMFC02.Size = New System.Drawing.Size(213, 87)
        Me.pnlMFC02.TabIndex = 555
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
        Me.pnlMFC01.Location = New System.Drawing.Point(228, 13)
        Me.pnlMFC01.Name = "pnlMFC01"
        Me.pnlMFC01.Size = New System.Drawing.Size(213, 87)
        Me.pnlMFC01.TabIndex = 554
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
        Me.picDoor2.TabIndex = 547
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
        Me.picDoor1.TabIndex = 546
        Me.picDoor1.TabStop = False
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
        Me.lblN2Text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular)
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
        'pnlDoor2
        '
        Me.pnlDoor2.BackColor = System.Drawing.Color.Red
        Me.pnlDoor2.Location = New System.Drawing.Point(33, 14)
        Me.pnlDoor2.Name = "pnlDoor2"
        Me.pnlDoor2.Size = New System.Drawing.Size(190, 10)
        Me.pnlDoor2.TabIndex = 516
        '
        'pnlDoor1
        '
        Me.pnlDoor1.BackColor = System.Drawing.Color.Red
        Me.pnlDoor1.Location = New System.Drawing.Point(33, 167)
        Me.pnlDoor1.Name = "pnlDoor1"
        Me.pnlDoor1.Size = New System.Drawing.Size(190, 10)
        Me.pnlDoor1.TabIndex = 515
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
        Me.Panel3.Controls.Add(Me.lblCUPUsage)
        Me.Panel3.Location = New System.Drawing.Point(34, 24)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(184, 143)
        Me.Panel3.TabIndex = 512
        '
        'lblCHVac
        '
        Me.lblCHVac.BackColor = System.Drawing.Color.Black
        Me.lblCHVac.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCHVac.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular)
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnSaveAs)
        Me.Panel1.Controls.Add(Me.pnlVacuumCurve)
        Me.Panel1.Controls.Add(Me.btnYReset)
        Me.Panel1.Controls.Add(Me.lblCursorValue)
        Me.Panel1.Controls.Add(Me.btnPrintCurve)
        Me.Panel1.Location = New System.Drawing.Point(457, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(556, 367)
        Me.Panel1.TabIndex = 542
        '
        'btnSaveAs
        '
        Me.btnSaveAs.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSaveAs.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveAs.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSaveAs.Location = New System.Drawing.Point(114, 4)
        Me.btnSaveAs.Name = "btnSaveAs"
        Me.btnSaveAs.Size = New System.Drawing.Size(62, 36)
        Me.btnSaveAs.TabIndex = 546
        Me.btnSaveAs.Text = "¥t¦s"
        Me.btnSaveAs.UseVisualStyleBackColor = False
        '
        'tabManual
        '
        Me.tabManual.Controls.Add(Me.tabPageVacuum)
        Me.tabManual.Controls.Add(Me.tabPage1to3)
        Me.tabManual.Controls.Add(Me.tabPage4to6)
        Me.tabManual.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabManual.ItemSize = New System.Drawing.Size(300, 30)
        Me.tabManual.Location = New System.Drawing.Point(0, 0)
        Me.tabManual.Name = "tabManual"
        Me.tabManual.SelectedIndex = 0
        Me.tabManual.Size = New System.Drawing.Size(1024, 709)
        Me.tabManual.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tabManual.TabIndex = 543
        '
        'tabPageVacuum
        '
        Me.tabPageVacuum.BackColor = System.Drawing.SystemColors.Control
        Me.tabPageVacuum.Controls.Add(Me.btnChamberLight)
        Me.tabPageVacuum.Controls.Add(Me.grpDoorControl)
        Me.tabPageVacuum.Controls.Add(Me.Panel2)
        Me.tabPageVacuum.Controls.Add(Me.Panel1)
        Me.tabPageVacuum.Controls.Add(Me.tabManualLog)
        Me.tabPageVacuum.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabPageVacuum.Location = New System.Drawing.Point(4, 34)
        Me.tabPageVacuum.Name = "tabPageVacuum"
        Me.tabPageVacuum.Size = New System.Drawing.Size(1016, 671)
        Me.tabPageVacuum.TabIndex = 2
        Me.tabPageVacuum.Text = "¯uªÅ©â®ð¤Î°O¿ý"
        '
        'btnChamberLight
        '
        Me.btnChamberLight.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnChamberLight.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChamberLight.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChamberLight.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnChamberLight.Location = New System.Drawing.Point(491, 619)
        Me.btnChamberLight.Name = "btnChamberLight"
        Me.btnChamberLight.Size = New System.Drawing.Size(101, 44)
        Me.btnChamberLight.TabIndex = 544
        Me.btnChamberLight.Text = "µÄ¤º·Ó©ú"
        Me.btnChamberLight.UseVisualStyleBackColor = False
        '
        'grpDoorControl
        '
        Me.grpDoorControl.Controls.Add(Me.btnPullerClose)
        Me.grpDoorControl.Controls.Add(Me.btnDoor2Down)
        Me.grpDoorControl.Controls.Add(Me.btnDoor1Down)
        Me.grpDoorControl.Controls.Add(Me.btnDoor2Up)
        Me.grpDoorControl.Controls.Add(Me.btnDoor1Up)
        Me.grpDoorControl.Location = New System.Drawing.Point(465, 386)
        Me.grpDoorControl.Name = "grpDoorControl"
        Me.grpDoorControl.Size = New System.Drawing.Size(297, 227)
        Me.grpDoorControl.TabIndex = 543
        Me.grpDoorControl.TabStop = False
        Me.grpDoorControl.Text = "µÄªù¾Þ§@"
        '
        'btnPullerClose
        '
        Me.btnPullerClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPullerClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPullerClose.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPullerClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPullerClose.Location = New System.Drawing.Point(26, 171)
        Me.btnPullerClose.Name = "btnPullerClose"
        Me.btnPullerClose.Size = New System.Drawing.Size(116, 44)
        Me.btnPullerClose.TabIndex = 538
        Me.btnPullerClose.Text = "ªù©Ô¬ûÃö³¬"
        Me.btnPullerClose.UseVisualStyleBackColor = False
        '
        'btnDoor2Down
        '
        Me.btnDoor2Down.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDoor2Down.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDoor2Down.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDoor2Down.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDoor2Down.Location = New System.Drawing.Point(165, 109)
        Me.btnDoor2Down.Name = "btnDoor2Down"
        Me.btnDoor2Down.Size = New System.Drawing.Size(116, 44)
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
        Me.btnDoor1Down.Location = New System.Drawing.Point(26, 109)
        Me.btnDoor1Down.Name = "btnDoor1Down"
        Me.btnDoor1Down.Size = New System.Drawing.Size(116, 44)
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
        Me.btnDoor2Up.Location = New System.Drawing.Point(165, 41)
        Me.btnDoor2Up.Name = "btnDoor2Up"
        Me.btnDoor2Up.Size = New System.Drawing.Size(116, 44)
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
        Me.btnDoor1Up.Location = New System.Drawing.Point(26, 42)
        Me.btnDoor1Up.Name = "btnDoor1Up"
        Me.btnDoor1Up.Size = New System.Drawing.Size(116, 44)
        Me.btnDoor1Up.TabIndex = 533
        Me.btnDoor1Up.Text = "µÄªù 1 ¤W¤É"
        Me.btnDoor1Up.UseVisualStyleBackColor = False
        '
        'tabPage1to3
        '
        Me.tabPage1to3.BackColor = System.Drawing.Color.LavenderBlush
        Me.tabPage1to3.Controls.Add(Me.flwManualChart1)
        Me.tabPage1to3.Controls.Add(Me.flwManualPage1)
        Me.tabPage1to3.Location = New System.Drawing.Point(4, 34)
        Me.tabPage1to3.Name = "tabPage1to3"
        Me.tabPage1to3.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage1to3.Size = New System.Drawing.Size(1016, 671)
        Me.tabPage1to3.TabIndex = 0
        Me.tabPage1to3.Text = "Head 1~3"
        '
        'flwManualChart1
        '
        Me.flwManualChart1.Location = New System.Drawing.Point(0, 380)
        Me.flwManualChart1.Name = "flwManualChart1"
        Me.flwManualChart1.Size = New System.Drawing.Size(1016, 290)
        Me.flwManualChart1.TabIndex = 3
        '
        'flwManualPage1
        '
        Me.flwManualPage1.AutoScroll = True
        Me.flwManualPage1.Location = New System.Drawing.Point(0, 0)
        Me.flwManualPage1.Margin = New System.Windows.Forms.Padding(0)
        Me.flwManualPage1.Name = "flwManualPage1"
        Me.flwManualPage1.Size = New System.Drawing.Size(1016, 377)
        Me.flwManualPage1.TabIndex = 0
        '
        'tabPage4to6
        '
        Me.tabPage4to6.BackColor = System.Drawing.Color.Azure
        Me.tabPage4to6.Controls.Add(Me.flwManualChart2)
        Me.tabPage4to6.Controls.Add(Me.flwManualPage2)
        Me.tabPage4to6.Location = New System.Drawing.Point(4, 34)
        Me.tabPage4to6.Name = "tabPage4to6"
        Me.tabPage4to6.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage4to6.Size = New System.Drawing.Size(1016, 671)
        Me.tabPage4to6.TabIndex = 1
        Me.tabPage4to6.Text = "Head 4~6"
        '
        'flwManualChart2
        '
        Me.flwManualChart2.Location = New System.Drawing.Point(0, 380)
        Me.flwManualChart2.Margin = New System.Windows.Forms.Padding(0)
        Me.flwManualChart2.Name = "flwManualChart2"
        Me.flwManualChart2.Size = New System.Drawing.Size(1016, 290)
        Me.flwManualChart2.TabIndex = 2
        '
        'flwManualPage2
        '
        Me.flwManualPage2.AutoScroll = True
        Me.flwManualPage2.Location = New System.Drawing.Point(0, 0)
        Me.flwManualPage2.Name = "flwManualPage2"
        Me.flwManualPage2.Size = New System.Drawing.Size(1016, 377)
        Me.flwManualPage2.TabIndex = 1
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
        Me.picC05.TabIndex = 561
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
        Me.lblDPTemp.TabIndex = 560
        Me.lblDPTemp.Text = "0"
        Me.lblDPTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormManual
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1024, 710)
        Me.ControlBox = False
        Me.Controls.Add(Me.tabManual)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(0, 50)
        Me.Name = "FormManual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Manual Operation"
        Me.tabManualLog.ResumeLayout(False)
        Me.tabPageDataLog.ResumeLayout(False)
        Me.tabPageDataLog.PerformLayout()
        Me.tabPageTimer.ResumeLayout(False)
        Me.tabPageTimer.PerformLayout()
        Me.Panel2.ResumeLayout(False)
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
        Me.Panel1.ResumeLayout(False)
        Me.tabManual.ResumeLayout(False)
        Me.tabPageVacuum.ResumeLayout(False)
        Me.grpDoorControl.ResumeLayout(False)
        Me.tabPage1to3.ResumeLayout(False)
        Me.tabPage4to6.ResumeLayout(False)
        CType(Me.picC05, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub TEST_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If DesignMode Then Exit Sub
        Dim PlcSetInitalingValue(16) As Integer
        Dim i As Integer
        Dim a As Integer
        Me.Top = FromStartUpTopPosition
        Me.Left = 0
        For i = 0 To 10
            maxvalue(i) = 0
        Next
        FormTextBoxSave.SetTextBox(Me, Me.Name, FormSaveINIFile)

        'txtTempSet.Text = Get_PLC_R1100(DAProcessTemp01Index).ToString
        'txtTempRateSet.Text = Format(Get_PLC_R1100(DAProcessTempRate01Index) / 100, "0.00")

        'txtPressureSet.Text = PressPVstr(i)
        'txtPressureRateSet.Text = Get_PLC_R1100(DAProcessBondRate01Index).ToString
        lblGas01Text.Text = PLCRValue(ADMFC01Index).Name
        lblGas02Text.Text = PLCRValue(ADMFC02Index).Name


        lblGas01MFC.Text = MFCReadValueStr(ADMFC01Index)
        lblGas01MFC.Text = MFCReadValueStr(ADMFC02Index)


        '¦UÀY¸ê®ÆÅã¥Ü============================================
        'Dim i As Integer
        For i = 0 To MAXPLATE
            'ManualControl(i).RunMode = ProcessMode_RUN
            ManualControl(i).ShowFlow = False
            ManualControl(i).SetTempPressure(PressPV(i), TopTempPV(i), BotTempPV(i))

            PressSV(i) = Val(ManualControl(i).txtPressureSet.Text)
            PressRateSV(i) = Val(ManualControl(i).txtPressureRateSet.Text)

            TopTempSV(i) = Val(ManualControl(i).txtTempSet.Text)
            BotTempSV(i) = TopTempSV(i)

            TopTempRateSV(i) = Val(ManualControl(i).txtTempRateSet.Text) * 100
            BotTempRateSV(i) = TopTempRateSV(i)

            'ManualControl(i).SetFlow(TopFlowMeterStr(i), BotFlowMeterStr(i))


            FormTextBoxSave.SetTextBox(ManualControl(i), ManualControl(i).Name, FormSaveINIFile)

        Next

        Timer1.Interval = 500
        Timer1.Enabled = True
        X = Me.Width 'Àò¨úµ¡Åéªº¼e«×
        Y = Me.Height 'Àò¨úµ¡Åéªº°ª«×
        isLoaded = True '¤w³]©w¦U±±¨î¶µªº¤Ø¤o¨ìTagÄÝ©Ê¤¤
        SetTag(Me) '½Õ¥Î¤èªk

    End Sub

    Public Sub ShowInit()
        Me.Show()
        Timer1.Enabled = True
    End Sub

    Public showflag As Boolean
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Top = FromStartUpTopPosition
        Me.Left = 0
        Dim i As Integer
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

        ObjShow.Show(Check_PLC_M(DoChamberLightIndex), btnChamberLight, ColorOn, ColorOff)
        For i = 0 To MAXPLATE
            If CSubAutoProcess(i).Run Then
                ManualControl(i).grpManualTitle.BackColor = Color.Pink
            ElseIf CSubAutoProcess(i).AbortStatus Then
                ManualControl(i).grpManualTitle.BackColor = Color.FromArgb(255, 255, 0)
            Else
                ManualControl(i).grpManualTitle.BackColor = System.Drawing.SystemColors.Control
            End If
        Next
        lblCUPUsage.Visible = CelloUsbFlag
        If CelloUsbFlag Then lblCUPUsage.Text = Format(CPU_Usage() / 100, "0.0%")

        ObjShow.Show(Check_PLC_X(DiSaftyGate01Index), picDoor1, My.Resources.Sensor_ON, My.Resources.Sensor_OFF)
        picDoor2.Visible = False
        'ObjShow.Show(Check_PLC_X(DiSaftyGate01Index), picDoor2, My.Resources.Sensor_ON, My.Resources.Sensor_ON)
        ObjShow.Show(Check_PLC_M(DoDoor1UpIndex), btnDoor1Up, ColorOn, ColorOff)
        ObjShow.Show(Check_PLC_M(DoDoor1DownIndex), btnDoor1Down, ColorOn, ColorOff)
        ObjShow.Show(Check_PLC_M(DoDoor2UpIndex), btnDoor2Up, ColorOn, ColorOff)
        ObjShow.Show(Check_PLC_M(DoDoor2DownIndex), btnDoor2Down, ColorOn, ColorOff)

        ObjShow.Show(Check_PLC_M(DoPullerCloseIndex), btnPullerClose, ColorOn, ColorOff)


        ObjShow.Show(Vac1ATM_Status, lbl1ATM, Color.Lime, Color.Red)
        ObjShow.Show(CSVTimerStartPb_Status, btnStartLog, ColorOn, ColorOff)
        ObjShow.Show(Timercount_enable, btnTimerStart, ColorOn, ColorOff)
        'dispaly
        ObjShow.Show(PLC_Y(DoMPIndex) = "1", picDP, My.Resources.dp_on, My.Resources.dp_off)
        ObjShow.Show(PLC_Y(DoRVIndex) = "1", picRVP, My.Resources.hvon, My.Resources.hvoff)
        ObjShow.Show(PLC_Y(DoVentIndex) = "1", picV4P, My.Resources.hvon, My.Resources.hvoff)

        'ObjShow.Show(PLC_Y(DoHeater01Index) = "1", picTopPlate, My.Resources.HEAT_ON, My.Resources.HEAT_OFF)
        'ObjShow.Show(PLC_Y(DoHeater01Index) = "1", picBotPlate, My.Resources.HEAT_ON, My.Resources.HEAT_OFF)

        'ObjShow.Show(PLC_Y(DoHeater01Index) = "1", btnTempON, ColorOn, "ON", ColorOff, "OFF")
        'ObjShow.Show(PLC_Y(DoBondDown01Index) = "1", btnPlateDown, ColorOn, ColorOff)
        'ObjShow.Show(PLC_M(DoBondUp01Index) = "1", btnPlateUp, ColorOn, ColorOff)
        'ObjShow.Show(PLC_M(DoBondForce01Index) = "1", btnBondingForce, ColorOn, "ON", ColorOff, "OFF")
        'ObjShow.Show(PLC_Y(DoOilPumpIndex) = "1", btnOilPump, ColorOn, ColorOff)

        'MFC ¬y¶qÅã¥Ü
        lblGas01MFC.Text = MFCReadValueStr(ADMFC01Index)
        lblGas02MFC.Text = MFCReadValueStr(ADMFC02Index)
        ObjShow.Show(Check_PLC_Y(DoV10Index), picGas01T, My.Resources.vvon, My.Resources.vvoff)
        ObjShow.Show(Check_PLC_Y(DoV11Index), picGas02T, My.Resources.vvon, My.Resources.vvoff)

        ObjShow.Show(CAutoPumping.Start, btnAutoVacuum, ColorOn, ColorOff)
        ObjShow.Show(CAutoPumping.AutoPurge, btnAutoPurge, ColorOn, ColorOff)
        ObjShow.Show(CAutoPumping.AutoProtection, btnPumpProtection, ColorOn, ColorOff)

        lblPumpingStatus.Visible = CelloUsbFlag
        lblPumpingStatus.Text = Format(CAutoPumping.State, "S:0 ") + Format(CAutoPumping.Timer, "T:0 ") + Format(CAutoPumping.PurgeCounter, "P:0 ")
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
            pnlDoor1.BackColor = Color.Red

        Else
            pnlDoor1.BackColor = Color.Transparent
        End If
        pnlDoor2.BackColor = Color.Red
        'If PLC_X(DiDoor2UpIndex) = "1" Then
        '    pnlDoor2.BackColor = Color.Red

        'Else
        '    pnlDoor2.BackColor = Color.Transparent
        'End If


        '¦UÀY¸ê®ÆÅã¥Ü============================================
        'lblTopFlow.Text = TopFlowMeterStr
        'lblBotFlow.Text = BotFlowMeterStr

        'lblTopTemp.Text = TopTempPVStr
        'lblTopTemp.Text = TopTempPVStr
        'lblBottomTemp.Text = BotTempPVStr
        'lblBotTemp.Text = BotTempPV.ToString
        'lblTopCurrent.Text = TopCurrentStr
        'lblBotCurrent.Text = BotCurrentStr
        lblDPCurrent.Text = MPCurrentStr
        lblCHVac.Text = GaugeCHVacStr
        'lblPressureRead.Text = PressPVstr
        'lblPressureRead1.Text = PressPVstr




    End Sub

    'Private Sub txtTempSet_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtTempSet.MouseDown
    '    If ProcessMode_RUN Then Exit Sub
    '    If CallKeyboard2(sender, TEMP_MAX, TEMP_MIN) <> "" Then
    '        'TopTempSV = SetCalibratedTemp(Val(sender.Text), tempTopX, tempTopY, 5)
    '        'BotTempSV = TopTempSV
    '        'BotTempSV = SetCalibratedTemp(Val(sender.Text), tempTopX, tempTopY, 5)
    '        'Write_PLC_R1100(DAProcessTemp01Index, TopTempSV)
    '        'Write_PLC_R1100(DABotTempCaledIndex, BotTempSV)
    '    End If
    'End Sub

    'Private Sub txtTempRateSet_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtTempRateSet.MouseDown
    '    Dim max As String
    '    If ProcessMode_RUN Then Exit Sub
    '    If CelloUsbFlag Then
    '        max = "20"
    '    Else
    '        max = TEMPRATE_MAX
    '    End If
    '    If CallKeyboard2(sender, max, TEMPRATE_MIN) <> "" Then
    '        Write_PLC_R1100(DAProcessTempRate01Index, Val(sender.Text) * 100)
    '    End If
    'End Sub

    'Private Sub txtPressureSet_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtPressureSet.MouseDown
    '    If CallKeyboard2(sender, PRESS_MAX, PRESS_MIN) <> "" Then
    '        'PressSV = Val(sender.Text) ' SetCalibratedTemp(Val(sender.Text), PressX, PressY, 5)
    '        'Write_PLC_R1100(DAProcessBond01Index, PressSV)
    '    End If
    'End Sub

    'Private Sub txtPressureRateSet_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtPressureRateSet.MouseDown
    '    If CallKeyboard2(sender, PRESSRATE_MAX, PRESSRATE_MIN) <> "" Then
    '        Write_PLC_R1100(DAProcessBondRate01Index, Val(sender.Text))
    '    End If
    'End Sub

    'Private Sub btnTempON_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTempON.Click
    '    Dim VacLimit As String = "1.0E-01"

    '    If ProcessMode_RUN Then Exit Sub
    '    If HeaterPb_Status = False Then
    '        If Not Check_PLC_X(DiDoor1UpIndex) Then
    '            MsgBoxLangErr("µÄªù¥¼Ãö³¬,½ÐÃö³¬µÄªù!", "µÄƒd¥¼‹×„¸,ˆ[‹×„¸µÄƒd!", "Door not Close!")
    '        ElseIf GaugeCHVac > Val(VacLimit) Then
    '            If CelloUsbFlag Then
    '                If AlarmError(Alarm_Name.TOP_FLOW_Error) = False And AlarmError(Alarm_Name.BOT_FLOW_Error) = False And Check_PLC_X(DiWater01Index) = False Then
    '                    MsgBoxLangErr("§N«o¤ôÀ£¶}Ãö²§±`!!", "§Nƒj¤ô‰Í…{‹×ÉÝ±`!!", "Water Pressure Error!!")
    '                Else

    '                    If MsgBoxLangYesNo("¯uªÅ­È­n<" + VacLimit + " Torr, ½T»{­n¶}±Ò¥[¼ö?", "¯uªÅ­È­n<" + VacLimit + " Torr, ÚÌ‡P­n…{„Q¥[‡ñ?", "Vacuum Need <" + VacLimit + " Torr, Still Force ON?") Then
    '                        'TopTempSV = SetCalibratedTemp(Val(txtTempSet.Text), tempTopX, tempTopY, 5)
    '                        'BotTempSV = TopTempSV
    '                        'BotTempSV = SetCalibratedTemp(Val(sender.Text), tempTopX, tempTopY, 5)
    '                        'Write_PLC_R1100(DAProcessTemp01Index, TopTempSV)
    '                        'Write_PLC_R1100(DABotTempCaledIndex, BotTempSV)
    '                        Write_PLC_R1100(DAProcessTempRate01Index, Val(txtTempRateSet.Text) * 100)
    '                        HeaterPb_Status = True
    '                    End If
    '                End If
    '            Else
    '                MsgBoxLangErr("¯uªÅ­È­n<" + VacLimit + " Torr", "¯uªÅ­È­n<" + VacLimit + " Torr", "Vacuum Need <" + VacLimit + " Torr")
    '            End If
    '        ElseIf AlarmError(Alarm_Name.TOP_FLOW_Error) = False And AlarmError(Alarm_Name.BOT_FLOW_Error) = False And Check_PLC_X(DiWater01Index) Then
    '            'TopTempSV = SetCalibratedTemp(Val(txtTempSet.Text), tempTopX, tempTopY, 5)
    '            BotTempSV = TopTempSV
    '            'BotTempSV = SetCalibratedTemp(Val(sender.Text), tempTopX, tempTopY, 5)
    '            'Write_PLC_R1100(DAProcessTemp01Index, TopTempSV)
    '            'Write_PLC_R1100(DABotTempCaledIndex, BotTempSV)
    '            Write_PLC_R1100(DAProcessTempRate01Index, Val(txtTempRateSet.Text) * 100)
    '            HeaterPb_Status = True
    '        Else
    '            MsgBoxLangErr("µL§N«o¤ô!!", "ÆÓ§Nƒj¤ô!!", "No Cooling Water!!")
    '        End If
    '    Else
    '        HeaterPb_Status = False
    '    End If
    'End Sub

    Private Sub picRVP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picRVP.Click
        If ProcessMode_RUN Then Exit Sub
        CAutoPumping.Start = False
        If Output(DoRVIndex).Status Then
            Output(DoRVIndex).Status = False
        Else
            If PLC_Y(DoMPIndex) = "0" Then
                'RVPb_Status = False
                MsgBoxLangErr("½Ð¥ý¶}±Ò¯uªÅÀ°®ú.", "Pump On first.")
                'RVPb_Status = Not RVPb_Status
            Else
                If PLC_X(DiDoor1UpIndex) = "0" Or PLC_X(DiDoor2UpIndex) = "0" Then
                    MsgBoxLangErr("µÄªù¥¼Ãö³¬,½ÐÃö³¬µÄªù!", "Door not Close!")
                Else
                    Output(DoVentIndex).Status = False
                    Output(DoRVIndex).Status = True
                End If
            End If
        End If
    End Sub

    Private Sub picV4P_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picV4P.Click
        Dim sstr As String
        If ProcessMode_RUN Then Exit Sub
        If Output(DoVentIndex).Status Then
            Output(DoVentIndex).Status = False
        Else
            'If VentOK Then
            CAutoPumping.Start = False
            Output(DoRVIndex).Status = False
            Output(DoVentIndex).Status = True
            '                Else
            '    sstr = SystemParameters.CoolingTemperature
            '    MsgBoxLangErr("µ¥«Ý·Å«×­°¦Ü: " + sstr, "µ¥«Ý h«×­°¦Ü: " + sstr, "Wait Temp Down: " + sstr)
            'End If
        End If

    End Sub

    Private Sub picDP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picDP.Click
        If ProcessMode_RUN Then Exit Sub
        CAutoPumping.Start = False
        Output(DoMPIndex).Status = Not Output(DoMPIndex).Status
        'DPPb_Status = Not DPPb_Status
    End Sub



    'Private Sub btnPlateUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlateUp.Click
    '    If ProcessMode_RUN Then Exit Sub
    '    If ChuckUpPb_Status Then
    '        ChuckUpPb_Status = False
    '    Else
    '        If PLC_X(DiDoor1UpIndex) = "0" Then
    '            MsgBoxLangErr("µÄªù¥¼Ãö³¬,½ÐÃö³¬µÄªù!", "µÄƒd¥¼‹×„¸,ˆ[‹×„¸µÄƒd!", "Door not Close!")
    '        Else
    '            'If Check_PLC_M(DoOilPumpIndex) Then
    '            If MsgBoxLangYesNo("½Ð½T»{¸ü½L¤w¸m©ñ!", "ˆ[ÚÌ‡P†^‡÷¤w¸m©ñ!", "Please Cormfirm Plate Up!") Then
    '                ChuckUpPb_Status = Not ChuckUpPb_Status
    '                ChuckDnPb_Status = False
    '                BoundingPb_Status = False
    '            End If
    '            'Else
    '            '    MsgBoxLangErr("ªoÀ£À°®ú¥¼±Ò°Ê!", "ªo‰Í‰Ö®ú¥¼„Qƒð!", "Oil Pump need ON!")
    '            'End If
    '        End If
    '    End If

    'End Sub

    'Private Sub btnPlateDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlateDown.Click
    '    If ProcessMode_RUN Then Exit Sub
    '    If ChuckDnPb_Status Then
    '        ChuckDnPb_Status = False
    '    Else
    '        'If Check_PLC_M(DoOilPumpIndex) Then
    '        ChuckDnPb_Status = Not ChuckDnPb_Status
    '        ChuckUpPb_Status = False
    '        BoundingPb_Status = False
    '        '    Else
    '        '    MsgBoxLangErr("ªoÀ£À°®ú¥¼±Ò°Ê!", "ªo‰Í‰Ö®ú¥¼„Qƒð!", "Oil Pump need ON!")
    '        'End If
    '    End If
    'End Sub

    'Private Sub btnBondingForce_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBondingForce.Click
    '    If ProcessMode_RUN Then Exit Sub
    '    If BoundingPb_Status Then
    '        BoundingPb_Status = False
    '    Else
    '        If PLC_X(DiDoor1UpIndex) = "0" Then
    '            MsgBoxLangErr("µÄªù¥¼Ãö³¬,½ÐÃö³¬µÄªù!", "µÄƒd¥¼‹×„¸,ˆ[‹×„¸µÄƒd!", "Door not Close!")
    '        Else
    '            'If Check_PLC_M(DoOilPumpIndex) Then
    '            If MsgBoxLangYesNo("½Ð½T»{¸ü½L¤w¸m©ñ!", "ˆ[ÚÌ‡P†^‡÷¤w¸m©ñ!", "Please Cormfirm Plate Up!") Then
    '                BoundingPb_Status = Not BoundingPb_Status
    '                ChuckUpPb_Status = True
    '                ChuckDnPb_Status = False
    '                PressSV(0) = Val(txtPressureSet.Text) ' SetCalibratedTemp(Val(sender.Text), PressX, PressY, 5)
    '                Write_PLC_R1100(DAProcessBond01Index, PressSV(0))
    '                Write_PLC_R1100(DAProcessBondRate01Index, Val(txtPressureRateSet.Text))

    '            End If
    '            '    Else
    '            '    MsgBoxLangErr("ªoÀ£À°®ú¥¼±Ò°Ê!", "ªo‰Í‰Ö®ú¥¼„Qƒð!", "Oil Pump need ON!")
    '            'End If
    '        End If
    '    End If
    'End Sub



    Private Sub btnYReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYReset.Click
        ResetCurve(ChartManualVacuum)
    End Sub

    Private Sub btnPrintCurve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintCurve.Click
        Dim FileName As String
        FileName = "Manual_" + FDate + "_" + FTime
        printCurve(ChartManualVacuum, FileName)
    End Sub



    Private Sub btnStartLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartLog.Click
        Dim tempstr As String
        tempstr = DataLogRecordFileName
        If CSVTimerStartPb_Status = True Then
            CSVTimerStartPb_Status = False
        Else
            DataLogRecordFileName = ""
            If FormKeyInDataLogNames.ShowDialog() = Windows.Forms.DialogResult.OK Then
                If Len(DataLogShortFileName) > 0 Then
                    CheckDataLogDirAndCreate()

                    lblDatalogFileName.Text = DataLogRecordFileName
                    DatalogTime = Val(txtDataLogStepTime.Text)
                    CSVTimerStartPb_Status = True
                End If
            End If
        End If
        DatalogStart = CSVTimerStartPb_Status
    End Sub

    'Private Sub lblDatalogFileName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDatalogFileName.Click
    '    Shell("Notepad.exe " + DataLogRecordFileName, AppWinStyle.NormalFocus)
    'End Sub

    'Private Sub btnOpenLogFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenLogFile.Click
    '    OpenFileDialog1.Filter = "csv files (*.csv)|*.csv"
    '    OpenFileDialog1.InitialDirectory = DataLogRecordDir
    '    OpenFileDialog1.Multiselect = False
    '    OpenFileDialog1.RestoreDirectory = True
    '    OpenFileDialog1.CheckPathExists = True
    '    OpenFileDialog1.CheckFileExists = True
    '    OpenFileDialog1.FileName = ""
    '    If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
    '        Shell("Notepad.exe " + OpenFileDialog1.FileName, AppWinStyle.NormalFocus)
    '    End If
    'End Sub
    Private Sub btnOpenLogFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenLogFile.Click
        OpenFileDialog1.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*"
        OpenFileDialog1.InitialDirectory = DataLogRecordDir
        OpenFileDialog1.Multiselect = False
        OpenFileDialog1.RestoreDirectory = True
        OpenFileDialog1.CheckPathExists = True
        OpenFileDialog1.CheckFileExists = True
        'OpenFileDialog1.FileName = ""

        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If IO.File.Exists(OpenFileDialog1.FileName) Then
                FormDataLogViews.ReadProcessRecord(OpenFileDialog1.FileName)
                'Shell("Notepad.exe " + OpenFileDialog1.FileName, AppWinStyle.NormalFocus)
            End If
        End If
    End Sub

    Private Sub lblDatalogFileName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDatalogFileName.Click
        If IO.File.Exists(lblDatalogFileName.Text) Then
            FormDataLogViews.ReadProcessRecord(lblDatalogFileName.Text)
            'Shell("Notepad.exe " + lblDatalogFileName.Text, AppWinStyle.NormalFocus)
        End If

    End Sub
    Private Sub txtDataLogStepTime_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtDataLogStepTime.MouseDown
        CallKeyboard2(sender, "3600", "1")
        If Val(txtDataLogStepTime.Text) > 0 Then
            DatalogTime = Val(txtDataLogStepTime.Text)
        End If
    End Sub

    '­p®É¾¹===========================================================

    '¥¿¼Æ/­Ë¼Æ­p®É¾¹
    Private Sub btnTImerStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTimerStart.Click
        Dim hh As Integer
        Dim mm As Integer
        Dim ss As Integer
        '±Ò°Ê/°±¤î­p®É¾¹
        Timercount_enable = Not Timercount_enable
        '­Y­p®É¾¹¬°±Ò°Ê
        If Timercount_enable = True Then
            btnTimerStart.Text = GetLangText("°±¤î­p®É", "Stop")
            '¸ü¤J³]©w®É¶¡
            Timercount.set_min = Val(txtTimerMin.Text)
            Timercount.set_sec = Val(txtTimerSec.Text)
            '¨ú±o¥Ø«e®É¶¡
            hh = Val(NHour)
            mm = Val(NMin)
            ss = Val(NSec)
            '±N¥Ø«e®É¶¡Âà´«¦¨¬í¼Æ
            Timercount_start = 3600 * hh + 60 * mm + ss
            Timercount_shift = False

            If Timercount.set_min = 0 And Timercount.set_sec = 0 Then
                '¦pªG³]©w­È¬°¹sªí¥Ü­n¥¿¼Æ
                Timercount_up = True
                Timercount_now = False
            Else
                '¦pªG³]©w­È¤£¬°¹sªí¥Ü­n­Ë¼Æ
                Timercount_down = True
                Timercount_up = False
                '­pºâ­Ë¼Æ©Ò»Ý¬í¼Æ
                Timercount_now = Timercount.set_min * 60 + Timercount.set_sec
            End If
        Else
            '­p®É°±¤î
            Timercount_up = False
            Timercount_down = False
            Timercount_shift = False
            btnTimerStart.Text = GetLangText("¶}©l­p®É", "Start")
        End If
    End Sub


    Private Sub btnTimerReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTimerReset.Click
        Timercount_enable = False
        btnTimerStart.Text = GetLangText("¶}©l­p®É", "Start")
        lblTimerMin.Text = "0"
        lblTimerSec.Text = "0"
        Timercount_up = False
        Timercount_down = False
        Timercount_shift = 0
    End Sub

    Private Sub txtTimerMin_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtTimerMin.MouseDown
        'If ProcessMode_RUN Then Exit Sub
        FormKeyboard2s.KeyInString(sender, NORMAL_MAX, NORMAL_MIN)
    End Sub

    Private Sub txtTimerSec_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtTimerSec.MouseDown
        'If ProcessMode_RUN Then Exit Sub

        FormKeyboard2s.KeyInString(sender, "59", "0")
        'CallKeyboard2(sender, "59", "0")
        If Val(sender.Text) > 59 Then
            sender.Text = "59"
        End If
    End Sub
    '­p®É¾¹===========================================================

    'Private Sub btnOilPump_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If ProcessMode_RUN Then Exit Sub
    '    OilPump_Status = Not OilPump_Status
    'End Sub

    Private Sub btnAutoVacuum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAutoVacuum.Click
        If ProcessMode_RUN Then Exit Sub
        CAutoPumping.Start = Not CAutoPumping.Start

        If DP_Pump_Used = False Then
            CAutoPumping.AutoProtection = True
        End If
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
        If DP_Pump_Used = False Then Exit Sub

        If DP_Pump_Used Then
            lblDPText.Text = "DP"
        Else
            lblDPText.Text = "MP"
        End If
        ProcessAutoVacuum_Status = Not ProcessAutoVacuum_Status
        CAutoPumping.AutoProtection = Not CAutoPumping.AutoProtection
        SystemParameters.ProcessAutoVacuum = GetTrue01String(ProcessAutoVacuum_Status)
        'CAutoPumping.SetBasePressure(CAutoPumping.AutoProtection, Val(SystemParameters.ProcessVacuumAutoVac), Val(SystemParameters.ProcessVacuumAutoVacLo))

        If ProcessMode_RUN Then
            CAutoPumping.SetBasePressure(CAutoPumping.AutoProtection, Val(SystemParameters.ProcessVacuumAutoVac), Val(RecipeNum(RecipeRunIndex).BasePressure) - Val(RecipeNum(RecipeRunIndex).BasePressure) * 0.2)
        Else
            CAutoPumping.SetBasePressure(CAutoPumping.AutoProtection, Val(SystemParameters.ProcessVacuumAutoVac), Val(SystemParameters.ProcessVacuumAutoVacLo))
        End If
        ''ProcessAutoVacuum_Status = Not ProcessAutoVacuum_Status
        'CAutoPumping.AutoProtection = Not CAutoPumping.AutoProtection
        'If ProcessMode_RUN Then
        '    CAutoPumping.SetBasePressure(CAutoPumping.AutoProtection, Val(SystemParameters.ProcessVacuumAutoVac), Val(RecipeNum(RecipeRunIndex).BasePressure))
        'Else
        '    If CAutoPumping.AutoProtection Then
        '        'CAutoPumping.Start = True
        '        CAutoPumping.SetBasePressure(CAutoPumping.AutoProtection, Val(SystemParameters.ProcessVacuumAutoVac), Val("1.0E-1"))
        '    End If
        'End If
    End Sub

    Private Sub btnAutoPurge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAutoPurge.Click
        'Dim cond As Boolean
        If CAutoPumping.AutoPurge Then
            CAutoPumping.AutoPurge = False
        Else
            If ProcessMode_RUN Then Exit Sub
            CAutoPumping.Start = True
            CAutoPumping.SetAutoPurge(CAutoPumping.AutoPurge, Val(SystemParameters.AutoPurgeOnTime), Val(SystemParameters.AutoPurgeOFFTime), Val(SystemParameters.AutoPurgeCycle))
            CAutoPumping.AutoPurge = True
        End If
        'cond = PLC_Y(DoMPIndex) = "1"
        'If cond Then
        '    AutoPurge_Status = Not AutoPurge_Status
        'Else
        '    MsgBoxLangErr("½Ð¥ý¶}±Ò¯uªÅÀ°®ú¤ÎRV.", "ˆ[¥ý…{„Q¯uªÅ‰Ö®ú¤ÎRV.", "Pump, RV On first.")
        'End If
    End Sub
    'MFC SET
    Private Sub txtGas01MFCSet_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtGas01MFCSet.MouseDown
        CallKeyboard2(sender, PLCRValue(DAMFC01Index).Max, PLCRValue(DAMFC01Index).Min)
        SetPLCRValue(DAMFC01Index, sender.Text)
    End Sub

    Private Sub txtGas02MFCSet_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtGas02MFCSet.MouseDown
        CallKeyboard2(sender, PLCRValue(DAMFC02Index).Max, PLCRValue(DAMFC02Index).Min)
        SetPLCRValue(DAMFC02Index, sender.Text)
    End Sub

    Private Sub picGas01T_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picGas01T.Click
        If ProcessMode_RUN Then Exit Sub
        SetPLCRValue(DAMFC01Index, txtGas01MFCSet.Text)
        If Output(DoV10Index).Status Then
            Output(DoV10Index).Status = False
        Else
            Output(DoV10Index).Status = True
        End If
    End Sub

    Private Sub picGas02T_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picGas02T.Click
        If ProcessMode_RUN Then Exit Sub
        SetPLCRValue(DAMFC02Index, txtGas02MFCSet.Text)

        If Output(DoV11Index).Status Then
            Output(DoV11Index).Status = False
        Else
            Output(DoV11Index).Status = True
        End If
    End Sub

    Private Sub btnDoor1Up_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDoor1Up.Click
        If ProcessMode_RUN Then Exit Sub
        If Check_PLC_X(DiSaftyGate01Index) Then
            Output(DoDoor1UpIndex).Status = Not Output(DoDoor1UpIndex).Status
            Output(DoDoor1DownIndex).Status = False
        Else
            MsgBoxLangErr("¦w¥þªù 1 ²§±`!", "Safty Gate 1 Error!")
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

    Private Sub btnSaveAs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveAs.Click
        SaveChartToJPG(ChartManualVacuum)
    End Sub

    Private Sub btnChamberLight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChamberLight.Click
        Output(DoChamberLightIndex).Status = Not Output(DoChamberLightIndex).Status

        'ObjShow.Show(Output(DoChamberLightIndex).Status, btnChamberLight, ColorOn, ColorOff)

        'watdog_Restart()
    End Sub

    Private Sub btnPullerClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPullerClose.Click
        Output(DoPullerCloseIndex).Status = Not Output(DoPullerCloseIndex).Status
        'watdog_Restart()
    End Sub
    Private Sub FormProcess_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If isLoaded Then

            'Dim new_x As Single = FormW / X
            'Dim new_Y As Single = (FormH - FromStartUpTopPosition) / Y
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
Imports System.Windows.Forms.DataVisualization.Charting

Public Class FormRecord
    Inherits System.Windows.Forms.Form
#Region " Windows Form 設計工具產生的程式碼 "
    Friend WithEvents pnlRecordCurve As System.Windows.Forms.Panel
    Friend WithEvents pnlRecordCSelect1 As System.Windows.Forms.Panel
    Friend WithEvents pnlCurveData As System.Windows.Forms.Panel
    Friend WithEvents lblFileCurve1 As System.Windows.Forms.Label
    Friend WithEvents pgbReadCurve As System.Windows.Forms.ProgressBar
    Friend WithEvents btnPrintCurve As System.Windows.Forms.Button
    Friend WithEvents btnYReset As System.Windows.Forms.Button
    Friend WithEvents btnOpenCurve1 As System.Windows.Forms.Button
    Friend WithEvents picCelloTitleEng As System.Windows.Forms.PictureBox
    Friend WithEvents picCelloTitle As System.Windows.Forms.PictureBox
    Friend WithEvents picCelloLogo As System.Windows.Forms.PictureBox
    Friend WithEvents btnCurveSelect1 As System.Windows.Forms.Button
    Friend WithEvents chkVacuum As System.Windows.Forms.CheckBox
    Friend WithEvents chkSite6 As System.Windows.Forms.CheckBox
    Friend WithEvents chkSite5 As System.Windows.Forms.CheckBox
    Friend WithEvents chkSite4 As System.Windows.Forms.CheckBox
    Friend WithEvents chkSite3 As System.Windows.Forms.CheckBox
    Friend WithEvents chkSite1 As System.Windows.Forms.CheckBox
    Friend WithEvents chkSite2 As System.Windows.Forms.CheckBox
    Friend WithEvents btnSaveAs As System.Windows.Forms.Button
    Friend WithEvents btnValueShow As System.Windows.Forms.Button
    Friend WithEvents pnlShowRecordData As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents lblCHVac As System.Windows.Forms.Label
    Friend WithEvents lblDPCurrent As System.Windows.Forms.Label
    Friend WithEvents lblTorr01Text As System.Windows.Forms.Label
    Friend WithEvents lblA01Text As System.Windows.Forms.Label
    Friend WithEvents btnStopZoom As System.Windows.Forms.Button
    Friend WithEvents lblSec01Text As System.Windows.Forms.Label
    Friend WithEvents lblTimeX As System.Windows.Forms.Label
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents pnlSiteSelect As System.Windows.Forms.Panel
    Friend WithEvents Control_Datalogview1 As CELLO.Control_Datalogview
    Friend WithEvents btnMultiChartArea As System.Windows.Forms.Button
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
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OpenFileDialog3 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OpenFileDialog2 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnOpenProcessFile As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog4 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnOpenOperatorFile As System.Windows.Forms.Button
    Friend WithEvents btnOpenAlarmRecordFile As System.Windows.Forms.Button
    Friend WithEvents tabPageAlarmRecord As System.Windows.Forms.TabPage
    Friend WithEvents tabPageUserRecord As System.Windows.Forms.TabPage
    Friend WithEvents tabPageProcessRecord As System.Windows.Forms.TabPage
    Friend WithEvents tabPageCurveRecord As System.Windows.Forms.TabPage
    Friend WithEvents RichTextAlarmRecord As System.Windows.Forms.RichTextBox
    Friend WithEvents lblFile01Text As System.Windows.Forms.Label
    Friend WithEvents lblAlarmFileName As System.Windows.Forms.Label
    Friend WithEvents lblFile02Text As System.Windows.Forms.Label
    Friend WithEvents lblOperatorFileName As System.Windows.Forms.Label
    Friend WithEvents lblFile03Text As System.Windows.Forms.Label
    Friend WithEvents lblProcessFileName As System.Windows.Forms.Label
    Friend WithEvents tabRecords As System.Windows.Forms.TabControl
    Friend WithEvents richRecordUser As System.Windows.Forms.RichTextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRecord))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog3 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.btnOpenProcessFile = New System.Windows.Forms.Button()
        Me.OpenFileDialog4 = New System.Windows.Forms.OpenFileDialog()
        Me.btnOpenOperatorFile = New System.Windows.Forms.Button()
        Me.btnOpenAlarmRecordFile = New System.Windows.Forms.Button()
        Me.richRecordUser = New System.Windows.Forms.RichTextBox()
        Me.tabRecords = New System.Windows.Forms.TabControl()
        Me.tabPageAlarmRecord = New System.Windows.Forms.TabPage()
        Me.lblFile01Text = New System.Windows.Forms.Label()
        Me.lblAlarmFileName = New System.Windows.Forms.Label()
        Me.RichTextAlarmRecord = New System.Windows.Forms.RichTextBox()
        Me.tabPageUserRecord = New System.Windows.Forms.TabPage()
        Me.lblFile02Text = New System.Windows.Forms.Label()
        Me.lblOperatorFileName = New System.Windows.Forms.Label()
        Me.tabPageProcessRecord = New System.Windows.Forms.TabPage()
        Me.lblFile03Text = New System.Windows.Forms.Label()
        Me.lblProcessFileName = New System.Windows.Forms.Label()
        Me.tabPageCurveRecord = New System.Windows.Forms.TabPage()
        Me.pnlCurveData = New System.Windows.Forms.Panel()
        Me.pnlSiteSelect = New System.Windows.Forms.Panel()
        Me.chkSite2 = New System.Windows.Forms.CheckBox()
        Me.chkVacuum = New System.Windows.Forms.CheckBox()
        Me.chkSite6 = New System.Windows.Forms.CheckBox()
        Me.chkSite5 = New System.Windows.Forms.CheckBox()
        Me.chkSite4 = New System.Windows.Forms.CheckBox()
        Me.chkSite3 = New System.Windows.Forms.CheckBox()
        Me.chkSite1 = New System.Windows.Forms.CheckBox()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.lblSec01Text = New System.Windows.Forms.Label()
        Me.pgbReadCurve = New System.Windows.Forms.ProgressBar()
        Me.btnStopZoom = New System.Windows.Forms.Button()
        Me.lblTimeX = New System.Windows.Forms.Label()
        Me.pnlShowRecordData = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblCHVac = New System.Windows.Forms.Label()
        Me.lblTorr01Text = New System.Windows.Forms.Label()
        Me.lblDPCurrent = New System.Windows.Forms.Label()
        Me.lblA01Text = New System.Windows.Forms.Label()
        Me.btnValueShow = New System.Windows.Forms.Button()
        Me.btnSaveAs = New System.Windows.Forms.Button()
        Me.btnMultiChartArea = New System.Windows.Forms.Button()
        Me.btnCurveSelect1 = New System.Windows.Forms.Button()
        Me.btnOpenCurve1 = New System.Windows.Forms.Button()
        Me.lblFileCurve1 = New System.Windows.Forms.Label()
        Me.pnlRecordCSelect1 = New System.Windows.Forms.Panel()
        Me.btnPrintCurve = New System.Windows.Forms.Button()
        Me.btnYReset = New System.Windows.Forms.Button()
        Me.pnlRecordCurve = New System.Windows.Forms.Panel()
        Me.picCelloTitleEng = New System.Windows.Forms.PictureBox()
        Me.picCelloTitle = New System.Windows.Forms.PictureBox()
        Me.picCelloLogo = New System.Windows.Forms.PictureBox()
        Me.Control_Datalogview1 = New CELLO.Control_Datalogview()
        Me.tabRecords.SuspendLayout()
        Me.tabPageAlarmRecord.SuspendLayout()
        Me.tabPageUserRecord.SuspendLayout()
        Me.tabPageProcessRecord.SuspendLayout()
        Me.tabPageCurveRecord.SuspendLayout()
        Me.pnlCurveData.SuspendLayout()
        Me.pnlSiteSelect.SuspendLayout()
        Me.pnlShowRecordData.SuspendLayout()
        CType(Me.picCelloTitleEng, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCelloTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCelloLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOpenProcessFile
        '
        Me.btnOpenProcessFile.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnOpenProcessFile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOpenProcessFile.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenProcessFile.Location = New System.Drawing.Point(3, 469)
        Me.btnOpenProcessFile.Name = "btnOpenProcessFile"
        Me.btnOpenProcessFile.Size = New System.Drawing.Size(150, 60)
        Me.btnOpenProcessFile.TabIndex = 47
        Me.btnOpenProcessFile.Text = "開啟檔案"
        Me.btnOpenProcessFile.UseVisualStyleBackColor = False
        '
        'btnOpenOperatorFile
        '
        Me.btnOpenOperatorFile.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnOpenOperatorFile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOpenOperatorFile.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenOperatorFile.Location = New System.Drawing.Point(3, 469)
        Me.btnOpenOperatorFile.Name = "btnOpenOperatorFile"
        Me.btnOpenOperatorFile.Size = New System.Drawing.Size(150, 60)
        Me.btnOpenOperatorFile.TabIndex = 46
        Me.btnOpenOperatorFile.Text = "開啟檔案"
        Me.btnOpenOperatorFile.UseVisualStyleBackColor = False
        '
        'btnOpenAlarmRecordFile
        '
        Me.btnOpenAlarmRecordFile.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnOpenAlarmRecordFile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOpenAlarmRecordFile.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenAlarmRecordFile.Location = New System.Drawing.Point(3, 469)
        Me.btnOpenAlarmRecordFile.Name = "btnOpenAlarmRecordFile"
        Me.btnOpenAlarmRecordFile.Size = New System.Drawing.Size(150, 60)
        Me.btnOpenAlarmRecordFile.TabIndex = 45
        Me.btnOpenAlarmRecordFile.Text = "開啟檔案"
        Me.btnOpenAlarmRecordFile.UseVisualStyleBackColor = False
        '
        'richRecordUser
        '
        Me.richRecordUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.richRecordUser.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.richRecordUser.Location = New System.Drawing.Point(0, 0)
        Me.richRecordUser.Name = "richRecordUser"
        Me.richRecordUser.Size = New System.Drawing.Size(1016, 466)
        Me.richRecordUser.TabIndex = 43
        Me.richRecordUser.Text = ""
        Me.richRecordUser.WordWrap = False
        '
        'tabRecords
        '
        Me.tabRecords.Controls.Add(Me.tabPageAlarmRecord)
        Me.tabRecords.Controls.Add(Me.tabPageUserRecord)
        Me.tabRecords.Controls.Add(Me.tabPageProcessRecord)
        Me.tabRecords.Controls.Add(Me.tabPageCurveRecord)
        Me.tabRecords.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabRecords.HotTrack = True
        Me.tabRecords.ItemSize = New System.Drawing.Size(160, 40)
        Me.tabRecords.Location = New System.Drawing.Point(0, 116)
        Me.tabRecords.Name = "tabRecords"
        Me.tabRecords.Padding = New System.Drawing.Point(40, 3)
        Me.tabRecords.SelectedIndex = 0
        Me.tabRecords.Size = New System.Drawing.Size(1024, 597)
        Me.tabRecords.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.tabRecords.TabIndex = 187
        '
        'tabPageAlarmRecord
        '
        Me.tabPageAlarmRecord.BackColor = System.Drawing.Color.Transparent
        Me.tabPageAlarmRecord.Controls.Add(Me.lblFile01Text)
        Me.tabPageAlarmRecord.Controls.Add(Me.lblAlarmFileName)
        Me.tabPageAlarmRecord.Controls.Add(Me.RichTextAlarmRecord)
        Me.tabPageAlarmRecord.Controls.Add(Me.btnOpenAlarmRecordFile)
        Me.tabPageAlarmRecord.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabPageAlarmRecord.Location = New System.Drawing.Point(4, 44)
        Me.tabPageAlarmRecord.Name = "tabPageAlarmRecord"
        Me.tabPageAlarmRecord.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageAlarmRecord.Size = New System.Drawing.Size(1016, 549)
        Me.tabPageAlarmRecord.TabIndex = 0
        Me.tabPageAlarmRecord.Text = "異常記錄"
        Me.tabPageAlarmRecord.UseVisualStyleBackColor = True
        '
        'lblFile01Text
        '
        Me.lblFile01Text.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFile01Text.Location = New System.Drawing.Point(159, 494)
        Me.lblFile01Text.Name = "lblFile01Text"
        Me.lblFile01Text.Size = New System.Drawing.Size(66, 30)
        Me.lblFile01Text.TabIndex = 46
        Me.lblFile01Text.Text = "File:"
        Me.lblFile01Text.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAlarmFileName
        '
        Me.lblAlarmFileName.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblAlarmFileName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAlarmFileName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlarmFileName.Location = New System.Drawing.Point(231, 494)
        Me.lblAlarmFileName.Name = "lblAlarmFileName"
        Me.lblAlarmFileName.Size = New System.Drawing.Size(775, 30)
        Me.lblAlarmFileName.TabIndex = 46
        Me.lblAlarmFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RichTextAlarmRecord
        '
        Me.RichTextAlarmRecord.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RichTextAlarmRecord.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.RichTextAlarmRecord.Location = New System.Drawing.Point(0, 0)
        Me.RichTextAlarmRecord.Name = "RichTextAlarmRecord"
        Me.RichTextAlarmRecord.Size = New System.Drawing.Size(1016, 466)
        Me.RichTextAlarmRecord.TabIndex = 44
        Me.RichTextAlarmRecord.Text = ""
        Me.RichTextAlarmRecord.WordWrap = False
        '
        'tabPageUserRecord
        '
        Me.tabPageUserRecord.BackColor = System.Drawing.Color.Transparent
        Me.tabPageUserRecord.Controls.Add(Me.lblFile02Text)
        Me.tabPageUserRecord.Controls.Add(Me.lblOperatorFileName)
        Me.tabPageUserRecord.Controls.Add(Me.richRecordUser)
        Me.tabPageUserRecord.Controls.Add(Me.btnOpenOperatorFile)
        Me.tabPageUserRecord.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabPageUserRecord.Location = New System.Drawing.Point(4, 44)
        Me.tabPageUserRecord.Name = "tabPageUserRecord"
        Me.tabPageUserRecord.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageUserRecord.Size = New System.Drawing.Size(1016, 549)
        Me.tabPageUserRecord.TabIndex = 1
        Me.tabPageUserRecord.Text = "操作者記錄"
        Me.tabPageUserRecord.UseVisualStyleBackColor = True
        '
        'lblFile02Text
        '
        Me.lblFile02Text.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFile02Text.Location = New System.Drawing.Point(159, 494)
        Me.lblFile02Text.Name = "lblFile02Text"
        Me.lblFile02Text.Size = New System.Drawing.Size(66, 30)
        Me.lblFile02Text.TabIndex = 48
        Me.lblFile02Text.Text = "File:"
        Me.lblFile02Text.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblOperatorFileName
        '
        Me.lblOperatorFileName.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblOperatorFileName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOperatorFileName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperatorFileName.Location = New System.Drawing.Point(231, 494)
        Me.lblOperatorFileName.Name = "lblOperatorFileName"
        Me.lblOperatorFileName.Size = New System.Drawing.Size(775, 30)
        Me.lblOperatorFileName.TabIndex = 47
        Me.lblOperatorFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tabPageProcessRecord
        '
        Me.tabPageProcessRecord.BackColor = System.Drawing.Color.Transparent
        Me.tabPageProcessRecord.Controls.Add(Me.Control_Datalogview1)
        Me.tabPageProcessRecord.Controls.Add(Me.lblFile03Text)
        Me.tabPageProcessRecord.Controls.Add(Me.lblProcessFileName)
        Me.tabPageProcessRecord.Controls.Add(Me.btnOpenProcessFile)
        Me.tabPageProcessRecord.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabPageProcessRecord.Location = New System.Drawing.Point(4, 44)
        Me.tabPageProcessRecord.Name = "tabPageProcessRecord"
        Me.tabPageProcessRecord.Size = New System.Drawing.Size(1016, 549)
        Me.tabPageProcessRecord.TabIndex = 2
        Me.tabPageProcessRecord.Text = "製程記錄"
        Me.tabPageProcessRecord.UseVisualStyleBackColor = True
        '
        'lblFile03Text
        '
        Me.lblFile03Text.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFile03Text.Location = New System.Drawing.Point(159, 494)
        Me.lblFile03Text.Name = "lblFile03Text"
        Me.lblFile03Text.Size = New System.Drawing.Size(66, 30)
        Me.lblFile03Text.TabIndex = 50
        Me.lblFile03Text.Text = "File:"
        Me.lblFile03Text.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblProcessFileName
        '
        Me.lblProcessFileName.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblProcessFileName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProcessFileName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcessFileName.Location = New System.Drawing.Point(231, 494)
        Me.lblProcessFileName.Name = "lblProcessFileName"
        Me.lblProcessFileName.Size = New System.Drawing.Size(775, 30)
        Me.lblProcessFileName.TabIndex = 49
        Me.lblProcessFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tabPageCurveRecord
        '
        Me.tabPageCurveRecord.BackColor = System.Drawing.Color.Transparent
        Me.tabPageCurveRecord.Controls.Add(Me.pnlCurveData)
        Me.tabPageCurveRecord.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabPageCurveRecord.Location = New System.Drawing.Point(4, 44)
        Me.tabPageCurveRecord.Name = "tabPageCurveRecord"
        Me.tabPageCurveRecord.Size = New System.Drawing.Size(1016, 549)
        Me.tabPageCurveRecord.TabIndex = 3
        Me.tabPageCurveRecord.Text = "歷史曲線圖"
        Me.tabPageCurveRecord.UseVisualStyleBackColor = True
        '
        'pnlCurveData
        '
        Me.pnlCurveData.BackColor = System.Drawing.SystemColors.Control
        Me.pnlCurveData.Controls.Add(Me.pnlSiteSelect)
        Me.pnlCurveData.Controls.Add(Me.lblMessage)
        Me.pnlCurveData.Controls.Add(Me.lblSec01Text)
        Me.pnlCurveData.Controls.Add(Me.pgbReadCurve)
        Me.pnlCurveData.Controls.Add(Me.btnStopZoom)
        Me.pnlCurveData.Controls.Add(Me.lblTimeX)
        Me.pnlCurveData.Controls.Add(Me.pnlShowRecordData)
        Me.pnlCurveData.Controls.Add(Me.btnValueShow)
        Me.pnlCurveData.Controls.Add(Me.btnSaveAs)
        Me.pnlCurveData.Controls.Add(Me.btnMultiChartArea)
        Me.pnlCurveData.Controls.Add(Me.btnCurveSelect1)
        Me.pnlCurveData.Controls.Add(Me.btnOpenCurve1)
        Me.pnlCurveData.Controls.Add(Me.lblFileCurve1)
        Me.pnlCurveData.Controls.Add(Me.pnlRecordCSelect1)
        Me.pnlCurveData.Controls.Add(Me.btnPrintCurve)
        Me.pnlCurveData.Controls.Add(Me.btnYReset)
        Me.pnlCurveData.Controls.Add(Me.pnlRecordCurve)
        Me.pnlCurveData.Location = New System.Drawing.Point(0, 0)
        Me.pnlCurveData.Name = "pnlCurveData"
        Me.pnlCurveData.Size = New System.Drawing.Size(1016, 547)
        Me.pnlCurveData.TabIndex = 187
        '
        'pnlSiteSelect
        '
        Me.pnlSiteSelect.Controls.Add(Me.chkSite2)
        Me.pnlSiteSelect.Controls.Add(Me.chkVacuum)
        Me.pnlSiteSelect.Controls.Add(Me.chkSite6)
        Me.pnlSiteSelect.Controls.Add(Me.chkSite5)
        Me.pnlSiteSelect.Controls.Add(Me.chkSite4)
        Me.pnlSiteSelect.Controls.Add(Me.chkSite3)
        Me.pnlSiteSelect.Controls.Add(Me.chkSite1)
        Me.pnlSiteSelect.Location = New System.Drawing.Point(298, 42)
        Me.pnlSiteSelect.Name = "pnlSiteSelect"
        Me.pnlSiteSelect.Size = New System.Drawing.Size(383, 30)
        Me.pnlSiteSelect.TabIndex = 554
        '
        'chkSite2
        '
        Me.chkSite2.Checked = True
        Me.chkSite2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSite2.Location = New System.Drawing.Point(204, 4)
        Me.chkSite2.Name = "chkSite2"
        Me.chkSite2.Size = New System.Drawing.Size(91, 23)
        Me.chkSite2.TabIndex = 1
        Me.chkSite2.Text = "Site2"
        Me.chkSite2.UseVisualStyleBackColor = True
        '
        'chkVacuum
        '
        Me.chkVacuum.Checked = True
        Me.chkVacuum.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkVacuum.Location = New System.Drawing.Point(6, 4)
        Me.chkVacuum.Name = "chkVacuum"
        Me.chkVacuum.Size = New System.Drawing.Size(91, 23)
        Me.chkVacuum.TabIndex = 6
        Me.chkVacuum.Text = "真空值"
        Me.chkVacuum.UseVisualStyleBackColor = True
        '
        'chkSite6
        '
        Me.chkSite6.Checked = True
        Me.chkSite6.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSite6.Location = New System.Drawing.Point(600, 4)
        Me.chkSite6.Name = "chkSite6"
        Me.chkSite6.Size = New System.Drawing.Size(91, 23)
        Me.chkSite6.TabIndex = 5
        Me.chkSite6.Text = "Site6"
        Me.chkSite6.UseVisualStyleBackColor = True
        '
        'chkSite5
        '
        Me.chkSite5.Checked = True
        Me.chkSite5.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSite5.Location = New System.Drawing.Point(501, 4)
        Me.chkSite5.Name = "chkSite5"
        Me.chkSite5.Size = New System.Drawing.Size(91, 23)
        Me.chkSite5.TabIndex = 4
        Me.chkSite5.Text = "Site5"
        Me.chkSite5.UseVisualStyleBackColor = True
        '
        'chkSite4
        '
        Me.chkSite4.Checked = True
        Me.chkSite4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSite4.Location = New System.Drawing.Point(402, 4)
        Me.chkSite4.Name = "chkSite4"
        Me.chkSite4.Size = New System.Drawing.Size(91, 23)
        Me.chkSite4.TabIndex = 3
        Me.chkSite4.Text = "Site4"
        Me.chkSite4.UseVisualStyleBackColor = True
        '
        'chkSite3
        '
        Me.chkSite3.Checked = True
        Me.chkSite3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSite3.Location = New System.Drawing.Point(303, 4)
        Me.chkSite3.Name = "chkSite3"
        Me.chkSite3.Size = New System.Drawing.Size(91, 23)
        Me.chkSite3.TabIndex = 2
        Me.chkSite3.Text = "Site3"
        Me.chkSite3.UseVisualStyleBackColor = True
        '
        'chkSite1
        '
        Me.chkSite1.Checked = True
        Me.chkSite1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSite1.Location = New System.Drawing.Point(105, 4)
        Me.chkSite1.Name = "chkSite1"
        Me.chkSite1.Size = New System.Drawing.Size(91, 23)
        Me.chkSite1.TabIndex = 0
        Me.chkSite1.Text = "Site1"
        Me.chkSite1.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMessage.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblMessage.Location = New System.Drawing.Point(146, 42)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(146, 28)
        Me.lblMessage.TabIndex = 553
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSec01Text
        '
        Me.lblSec01Text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSec01Text.ForeColor = System.Drawing.Color.Black
        Me.lblSec01Text.Location = New System.Drawing.Point(997, 45)
        Me.lblSec01Text.Margin = New System.Windows.Forms.Padding(3)
        Me.lblSec01Text.Name = "lblSec01Text"
        Me.lblSec01Text.Size = New System.Drawing.Size(16, 24)
        Me.lblSec01Text.TabIndex = 552
        Me.lblSec01Text.Text = "s"
        Me.lblSec01Text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pgbReadCurve
        '
        Me.pgbReadCurve.Location = New System.Drawing.Point(431, 33)
        Me.pgbReadCurve.Name = "pgbReadCurve"
        Me.pgbReadCurve.Size = New System.Drawing.Size(311, 8)
        Me.pgbReadCurve.TabIndex = 43
        Me.pgbReadCurve.Visible = False
        '
        'btnStopZoom
        '
        Me.btnStopZoom.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnStopZoom.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStopZoom.Location = New System.Drawing.Point(70, 42)
        Me.btnStopZoom.Name = "btnStopZoom"
        Me.btnStopZoom.Size = New System.Drawing.Size(72, 30)
        Me.btnStopZoom.TabIndex = 548
        Me.btnStopZoom.Text = "縮放停止"
        Me.btnStopZoom.UseVisualStyleBackColor = False
        '
        'lblTimeX
        '
        Me.lblTimeX.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTimeX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTimeX.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeX.ForeColor = System.Drawing.Color.Black
        Me.lblTimeX.Location = New System.Drawing.Point(921, 45)
        Me.lblTimeX.Margin = New System.Windows.Forms.Padding(3)
        Me.lblTimeX.Name = "lblTimeX"
        Me.lblTimeX.Size = New System.Drawing.Size(74, 24)
        Me.lblTimeX.TabIndex = 549
        Me.lblTimeX.Text = "0"
        Me.lblTimeX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlShowRecordData
        '
        Me.pnlShowRecordData.Controls.Add(Me.lblCHVac)
        Me.pnlShowRecordData.Controls.Add(Me.lblTorr01Text)
        Me.pnlShowRecordData.Controls.Add(Me.lblDPCurrent)
        Me.pnlShowRecordData.Controls.Add(Me.lblA01Text)
        Me.pnlShowRecordData.Location = New System.Drawing.Point(783, 73)
        Me.pnlShowRecordData.Name = "pnlShowRecordData"
        Me.pnlShowRecordData.Size = New System.Drawing.Size(233, 470)
        Me.pnlShowRecordData.TabIndex = 0
        '
        'lblCHVac
        '
        Me.lblCHVac.BackColor = System.Drawing.Color.Black
        Me.lblCHVac.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCHVac.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCHVac.ForeColor = System.Drawing.Color.Lime
        Me.lblCHVac.Location = New System.Drawing.Point(3, 3)
        Me.lblCHVac.Margin = New System.Windows.Forms.Padding(3)
        Me.lblCHVac.Name = "lblCHVac"
        Me.lblCHVac.Size = New System.Drawing.Size(88, 24)
        Me.lblCHVac.TabIndex = 548
        Me.lblCHVac.Text = "0"
        Me.lblCHVac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTorr01Text
        '
        Me.lblTorr01Text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTorr01Text.ForeColor = System.Drawing.Color.Black
        Me.lblTorr01Text.Location = New System.Drawing.Point(97, 3)
        Me.lblTorr01Text.Margin = New System.Windows.Forms.Padding(3)
        Me.lblTorr01Text.Name = "lblTorr01Text"
        Me.lblTorr01Text.Size = New System.Drawing.Size(39, 24)
        Me.lblTorr01Text.TabIndex = 551
        Me.lblTorr01Text.Text = "Torr"
        Me.lblTorr01Text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDPCurrent
        '
        Me.lblDPCurrent.BackColor = System.Drawing.Color.Black
        Me.lblDPCurrent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDPCurrent.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDPCurrent.ForeColor = System.Drawing.Color.Lime
        Me.lblDPCurrent.Location = New System.Drawing.Point(142, 3)
        Me.lblDPCurrent.Margin = New System.Windows.Forms.Padding(3)
        Me.lblDPCurrent.Name = "lblDPCurrent"
        Me.lblDPCurrent.Size = New System.Drawing.Size(53, 24)
        Me.lblDPCurrent.TabIndex = 549
        Me.lblDPCurrent.Text = "0"
        Me.lblDPCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblA01Text
        '
        Me.lblA01Text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblA01Text.ForeColor = System.Drawing.Color.Black
        Me.lblA01Text.Location = New System.Drawing.Point(201, 3)
        Me.lblA01Text.Margin = New System.Windows.Forms.Padding(3)
        Me.lblA01Text.Name = "lblA01Text"
        Me.lblA01Text.Size = New System.Drawing.Size(27, 24)
        Me.lblA01Text.TabIndex = 550
        Me.lblA01Text.Text = "A"
        Me.lblA01Text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnValueShow
        '
        Me.btnValueShow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnValueShow.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValueShow.Location = New System.Drawing.Point(750, 39)
        Me.btnValueShow.Name = "btnValueShow"
        Me.btnValueShow.Size = New System.Drawing.Size(74, 30)
        Me.btnValueShow.TabIndex = 547
        Me.btnValueShow.Text = "顯示值"
        Me.btnValueShow.UseVisualStyleBackColor = False
        '
        'btnSaveAs
        '
        Me.btnSaveAs.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSaveAs.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveAs.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSaveAs.Location = New System.Drawing.Point(921, 5)
        Me.btnSaveAs.Name = "btnSaveAs"
        Me.btnSaveAs.Size = New System.Drawing.Size(74, 30)
        Me.btnSaveAs.TabIndex = 545
        Me.btnSaveAs.Text = "另存圖檔"
        Me.btnSaveAs.UseVisualStyleBackColor = False
        '
        'btnMultiChartArea
        '
        Me.btnMultiChartArea.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnMultiChartArea.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiChartArea.Location = New System.Drawing.Point(750, 5)
        Me.btnMultiChartArea.Name = "btnMultiChartArea"
        Me.btnMultiChartArea.Size = New System.Drawing.Size(74, 30)
        Me.btnMultiChartArea.TabIndex = 541
        Me.btnMultiChartArea.Text = "並列顯示"
        Me.btnMultiChartArea.UseVisualStyleBackColor = False
        '
        'btnCurveSelect1
        '
        Me.btnCurveSelect1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCurveSelect1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCurveSelect1.Location = New System.Drawing.Point(835, 39)
        Me.btnCurveSelect1.Name = "btnCurveSelect1"
        Me.btnCurveSelect1.Size = New System.Drawing.Size(74, 30)
        Me.btnCurveSelect1.TabIndex = 540
        Me.btnCurveSelect1.Text = "曲線選擇"
        Me.btnCurveSelect1.UseVisualStyleBackColor = False
        '
        'btnOpenCurve1
        '
        Me.btnOpenCurve1.BackColor = System.Drawing.Color.AliceBlue
        Me.btnOpenCurve1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOpenCurve1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenCurve1.Location = New System.Drawing.Point(5, 1)
        Me.btnOpenCurve1.Name = "btnOpenCurve1"
        Me.btnOpenCurve1.Size = New System.Drawing.Size(129, 36)
        Me.btnOpenCurve1.TabIndex = 7
        Me.btnOpenCurve1.Text = "讀曲線檔1"
        Me.btnOpenCurve1.UseVisualStyleBackColor = False
        '
        'lblFileCurve1
        '
        Me.lblFileCurve1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblFileCurve1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFileCurve1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFileCurve1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblFileCurve1.Location = New System.Drawing.Point(140, 5)
        Me.lblFileCurve1.Name = "lblFileCurve1"
        Me.lblFileCurve1.Size = New System.Drawing.Size(604, 28)
        Me.lblFileCurve1.TabIndex = 44
        Me.lblFileCurve1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlRecordCSelect1
        '
        Me.pnlRecordCSelect1.AutoScroll = True
        Me.pnlRecordCSelect1.AutoScrollMargin = New System.Drawing.Size(30, 0)
        Me.pnlRecordCSelect1.BackColor = System.Drawing.Color.AliceBlue
        Me.pnlRecordCSelect1.Location = New System.Drawing.Point(783, 73)
        Me.pnlRecordCSelect1.Name = "pnlRecordCSelect1"
        Me.pnlRecordCSelect1.Size = New System.Drawing.Size(233, 470)
        Me.pnlRecordCSelect1.TabIndex = 0
        Me.pnlRecordCSelect1.Visible = False
        '
        'btnPrintCurve
        '
        Me.btnPrintCurve.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPrintCurve.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintCurve.Location = New System.Drawing.Point(835, 5)
        Me.btnPrintCurve.Name = "btnPrintCurve"
        Me.btnPrintCurve.Size = New System.Drawing.Size(74, 30)
        Me.btnPrintCurve.TabIndex = 42
        Me.btnPrintCurve.Text = "列印"
        Me.btnPrintCurve.UseVisualStyleBackColor = False
        '
        'btnYReset
        '
        Me.btnYReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnYReset.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnYReset.Location = New System.Drawing.Point(5, 42)
        Me.btnYReset.Name = "btnYReset"
        Me.btnYReset.Size = New System.Drawing.Size(57, 30)
        Me.btnYReset.TabIndex = 41
        Me.btnYReset.Text = "重設"
        Me.btnYReset.UseVisualStyleBackColor = False
        '
        'pnlRecordCurve
        '
        Me.pnlRecordCurve.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnlRecordCurve.Location = New System.Drawing.Point(0, 73)
        Me.pnlRecordCurve.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlRecordCurve.Name = "pnlRecordCurve"
        Me.pnlRecordCurve.Size = New System.Drawing.Size(780, 470)
        Me.pnlRecordCurve.TabIndex = 187
        '
        'picCelloTitleEng
        '
        Me.picCelloTitleEng.Image = CType(resources.GetObject("picCelloTitleEng.Image"), System.Drawing.Image)
        Me.picCelloTitleEng.Location = New System.Drawing.Point(590, 64)
        Me.picCelloTitleEng.Name = "picCelloTitleEng"
        Me.picCelloTitleEng.Size = New System.Drawing.Size(430, 50)
        Me.picCelloTitleEng.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCelloTitleEng.TabIndex = 538
        Me.picCelloTitleEng.TabStop = False
        '
        'picCelloTitle
        '
        Me.picCelloTitle.Image = CType(resources.GetObject("picCelloTitle.Image"), System.Drawing.Image)
        Me.picCelloTitle.Location = New System.Drawing.Point(375, 0)
        Me.picCelloTitle.Name = "picCelloTitle"
        Me.picCelloTitle.Size = New System.Drawing.Size(645, 65)
        Me.picCelloTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCelloTitle.TabIndex = 537
        Me.picCelloTitle.TabStop = False
        '
        'picCelloLogo
        '
        Me.picCelloLogo.Image = Global.CELLO.My.Resources.Resources.CELLOLOGO02
        Me.picCelloLogo.Location = New System.Drawing.Point(0, 0)
        Me.picCelloLogo.Name = "picCelloLogo"
        Me.picCelloLogo.Size = New System.Drawing.Size(138, 110)
        Me.picCelloLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCelloLogo.TabIndex = 536
        Me.picCelloLogo.TabStop = False
        '
        'Control_Datalogview1
        '
        Me.Control_Datalogview1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Control_Datalogview1.Location = New System.Drawing.Point(1, 1)
        Me.Control_Datalogview1.Name = "Control_Datalogview1"
        Me.Control_Datalogview1.Size = New System.Drawing.Size(1012, 466)
        Me.Control_Datalogview1.TabIndex = 51
        '
        'FormRecord
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1024, 710)
        Me.ControlBox = False
        Me.Controls.Add(Me.picCelloTitleEng)
        Me.Controls.Add(Me.picCelloTitle)
        Me.Controls.Add(Me.picCelloLogo)
        Me.Controls.Add(Me.tabRecords)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(0, 50)
        Me.Name = "FormRecord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Record"
        Me.tabRecords.ResumeLayout(False)
        Me.tabPageAlarmRecord.ResumeLayout(False)
        Me.tabPageUserRecord.ResumeLayout(False)
        Me.tabPageProcessRecord.ResumeLayout(False)
        Me.tabPageCurveRecord.ResumeLayout(False)
        Me.pnlCurveData.ResumeLayout(False)
        Me.pnlSiteSelect.ResumeLayout(False)
        Me.pnlShowRecordData.ResumeLayout(False)
        CType(Me.picCelloTitleEng, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCelloTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCelloLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public MultiAreaFlag As Boolean
    Public ShowDataFlag As Boolean
    Public ShowSelectFlag As Boolean
    Public DataBind As System.Threading.Thread
    Public ReadCurveData As System.Threading.Thread

    Public TIck1, Tick2 As Integer
    Private Delegate Sub UpdateUICallBack(ByVal newText As String, ByVal c As Control)
    Private Sub UpdateUI(ByVal newText As String, ByVal c As Control)
        If Me.InvokeRequired() Then
            Dim cb As New UpdateUICallBack(AddressOf UpdateUI)
            Me.Invoke(cb, newText, c)
        Else
            c.Text = newText
        End If
    End Sub


    Private Delegate Sub SetVisibleUICallBack(ByVal c As Control, ByVal bVisible As Boolean)
    Private Sub SetVisibleUI(ByVal c As Control, ByVal bVisible As Boolean)
        If Me.InvokeRequired() Then
            Dim cb As New SetVisibleUICallBack(AddressOf SetVisibleUI)
            Me.Invoke(cb, c, bVisible)
        Else
            c.Visible = bVisible
        End If
    End Sub

    Private Delegate Sub UpdateProgressCallBack(ByVal newText As Integer, ByVal c As ProgressBar, ByVal type As Integer)
    ''' <summary>
    ''' 更在不同執行緒中更新 PROGRESS BAR
    ''' </summary>
    ''' <param name="newText">設定的整數值</param>
    ''' <param name="c">控制項名稱</param>
    ''' <param name="type">0=最大值, 1=目前值,3=顯示,4=HIDE,累加1個STEP</param>
    ''' <remarks></remarks>
    Private Sub UpdateProgressBar(ByVal newText As Integer, ByVal c As ProgressBar, ByVal type As Integer)
        If Me.InvokeRequired() Then
            Dim cb As New UpdateProgressCallBack(AddressOf UpdateProgressBar)
            Me.Invoke(cb, newText, c, type)
        Else
            Select Case type
                Case 0
                    c.Maximum = newText
                Case 1
                    c.Value = newText
                Case 3
                    c.Visible = True
                Case 4
                    c.Visible = False
                Case 5
                    c.PerformStep()
            End Select

        End If
    End Sub
    Private Delegate Sub PointsBindYCallBack(ByVal Points() As Double, ByRef c As Chart, ByVal index As Integer)

    Private Sub PointsBindY(ByVal Points() As Double, ByRef c As Chart, ByVal index As Integer)
        If Me.InvokeRequired() Then
            Dim cb As New PointsBindYCallBack(AddressOf PointsBindY)
            Me.Invoke(cb, Points, c, index)
        Else
            If index < c.Series.Count Then
                c.Series(index).Points.DataBindY(Points)
            End If
        End If
    End Sub

    Private Delegate Sub SeriesEnabledCallBack(ByRef c As Chart, ByVal index As Integer, ByVal bEnabled As Boolean)

    Private Sub SeriesEnabled(ByRef c As Chart, ByVal index As Integer, ByVal bEnabled As Boolean)
        If Me.InvokeRequired() Then
            Dim cb As New SeriesEnabledCallBack(AddressOf SeriesEnabled)
            Me.Invoke(cb, c, index, bEnabled)
        Else
            c.Series(index).Enabled = bEnabled
            c.Series(index).YAxisType = AxisType.Primary
        End If
    End Sub

    Private Delegate Sub ControlsEnabledCallBack(ByRef c As Object, ByVal bEnabled As Boolean)

    Private Sub ControlsEnabled(ByRef c As Object, ByVal bEnabled As Boolean)
        If Me.InvokeRequired() Then
            Dim cb As New ControlsEnabledCallBack(AddressOf ControlsEnabled)
            Me.Invoke(cb, c, bEnabled)
        Else
            c.Enabled = bEnabled
        End If
    End Sub

    Private Delegate Sub PointsAddCallBack(ByVal Points As Double, ByRef c As Chart, ByVal index As Integer)

    Private Sub PointsAdd(ByVal Points As Double, ByRef c As Chart, ByVal index As Integer)
        If Me.InvokeRequired() Then
            Dim cb As New PointsAddCallBack(AddressOf PointsAdd)
            Me.Invoke(cb, Points, c, index)
        Else
            If index < c.Series.Count Then
                c.Series(index).Points.AddY(Points)
            End If
        End If
    End Sub

    Private Delegate Sub SetChartMaxXAxisCallBack(ByRef c As Chart, ByVal max As Integer)

    Private Sub SetChartMaxXAxis(ByRef c As Chart, ByVal max As Integer)
        If Me.InvokeRequired() Then
            Dim cb As New SetChartMaxXAxisCallBack(AddressOf SetChartMaxXAxis)
            Me.Invoke(cb, c, max)
        Else
            Dim i As Integer
            For i = 0 To c.ChartAreas.Count - 1
                If max < 2000 Then
                    c.ChartAreas(i).AxisX.Maximum = 2000
                Else
                    c.ChartAreas(i).AxisX.Maximum = max
                End If
            Next
        End If
    End Sub

    Public WithEvents ReadCurveBackWorker As System.ComponentModel.BackgroundWorker
    Public Sub Work_BackDoor_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles ReadCurveBackWorker.DoWork
        TIck1 = GetTickCount
        ReadProcessCurveData(File1Name)
        Tick2 = GetTickCount
    End Sub

    Public Sub ReadCurveDataThread()
        TIck1 = GetTickCount
        ReadProcessCurveData(File1Name)
        Tick2 = GetTickCount
        ControlsEnabled(btnOpenCurve1, True)
        UpdateUI("Record: " + CelloCurve.TOTAL_RECORD.ToString, lblMessage)
        MsgBoxLangOK("資料讀取完成." + Format((Tick2 - TIck1) / 1000, "(0.000)"), "Data Read OK." + Format((Tick2 - TIck1) / 1000, "(0.000)"))
    End Sub

    Private Sub ReadCurveBackWorker_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles ReadCurveBackWorker.ProgressChanged

    End Sub

    Private Sub ReadCurveBackWorker_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles ReadCurveBackWorker.RunWorkerCompleted
        Dim SpentTime As String
        SpentTime = Format((Tick2 - TIck1) / 1000, "(0.000)")
        MsgBoxLangOK("資料讀取完成." + SpentTime, "Data Read OK." + SpentTime)
    End Sub

    Public Function ReadProcessCurveData(ByVal sfile As String) As Integer
        Dim i, j As Integer
        Dim sstr, SplitString() As String
        On Error Resume Next
        If sfile = "" Then
            Exit Function
        End If
        UpdateProgressBar(CelloCurve.TOTAL_RECORD, pgbReadCurve, 3)
        CelloCurve.CAPTION_ALL = ReadProgData("CURVE_SETUP", "CAPTION", "NoData", sfile)
        CelloCurve.DEVICENAME = ReadProgData("CURVE_SETUP", "DEVICENAME", "NoData", sfile)
        CelloCurve.MODELNAME = ReadProgData("CURVE_SETUP", "MODELNAME", "NoData", sfile)
        CelloCurve.DATETIME = ReadProgData("CURVE_SETUP", "DATETIME", "NoData", sfile)
        CelloCurve.RECIPE = ReadProgData("CURVE_SETUP", "RECIPE", "NoData", sfile)
        CelloCurve.PROCESSPN = ReadProgData("CURVE_SETUP", "PROCESSPN", "NoData", sfile)
        CelloCurve.TOTAL_RECORD = Val(ReadProgData("CURVE_SETUP", "TOTAL_RECORD", "0", sfile))
        UpdateProgressBar(CelloCurve.TOTAL_RECORD, pgbReadCurve, 0)
        If CelloCurve.TOTAL_RECORD = 0 Then Return 0
        'Try
        CelloCurve.CAPTION = Split(CelloCurve.CAPTION_ALL, ",")
        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        '    Exit Function
        'End Try
        j = 0
        For i = 0 To CelloCurve.CAPTION.Length - 1
            If Len(CelloCurve.CAPTION(i)) > 0 Then
                j += 1
            End If
        Next
        CelloCurve.CAPTION_NUM = j
        ReDim CelloCurve.Record(CelloCurve.CAPTION_NUM)
        For i = 0 To CelloCurve.CAPTION_NUM
            ReDim CelloCurve.Record(i)(CelloCurve.TOTAL_RECORD - 1)
        Next

        Dim filenum, llen As Integer
        Dim astr As String
        filenum = FreeFile()
        FileOpen(filenum, sfile, OpenMode.Input, OpenAccess.Read, OpenShare.Shared)
        i = 0
        Do While Not EOF(filenum)
            astr = LineInput(filenum)
            llen = Len(astr)
            sstr = "DATA"
            If InStr(1, astr, sstr) = 1 Then
                astr = Mid(astr, 12, llen - 11)
                SplitString = Split(astr, ",")
                If SplitString.Length <= CelloCurve.CAPTION_NUM Then
                    For j = 0 To MAX_CURVES
                        CelloCurve.Record(j)(i) = Val(SplitString(j))
                    Next
                Else
                    For j = 0 To MAX_CURVES
                        If i > 0 Then
                            CelloCurve.Record(j)(i) = CelloCurve.Record(j)(i)
                        Else
                            'CelloCurve.Record(j)(i) = 0
                        End If
                    Next
                End If
                UpdateProgressBar(CelloCurve.TOTAL_RECORD, pgbReadCurve, 5)
                i += 1
                If i >= CelloCurve.TOTAL_RECORD Then Exit Do
            End If
        Loop
        FileClose(filenum)

        ';---------------------------

        'For i = 0 To CelloCurve.TOTAL_RECORD
        '    sstr = ReadProgData("CURVE_DATA", "DATA" + Format(i, "000000"), "Unknow", sfile)
        '    'Try
        '    SplitString = Split(sstr, ",")
        '    If SplitString.Length >= CelloCurve.CAPTION_NUM Then
        '        For j = 0 To CelloCurve.CAPTION_NUM - 1

        '            CelloCurve.Record(j)(i) = Val(SplitString(j))
        '            'PointsAdd(CelloCurve.Record(j)(i), ChartRecord, j)
        '        Next
        '    Else
        '        For j = 0 To CelloCurve.CAPTION_NUM - 1
        '            If i > 0 Then
        '                CelloCurve.Record(j)(i) = CelloCurve.Record(j)(i - 1)
        '            Else
        '                CelloCurve.Record(j)(i) = 0
        '                'PointsAdd(CelloCurve.Record(j)(i), ChartRecord, j)
        '            End If
        '        Next
        '    End If
        '    UpdateProgressBar(CelloCurve.TOTAL_RECORD, pgbReadCurve, 5)
        'Next
        ';---------------------------
        UpdateUI("Redrawing......", lblMessage)
        DataBind = New System.Threading.Thread(AddressOf DataBinThread)
        DataBind.Priority = Threading.ThreadPriority.Highest
        DataBind.Start()
    End Function



    Public Sub DataBinThread()
        Dim j As Integer
        On Error Resume Next
        For j = 0 To CelloCurve.CAPTION_NUM - 1
            'For j = 0 To 6
            If j <= MAX_CURVES Then 'CelloCurve.Record.Length Then
                PointsBindY(CelloCurve.Record(j), ChartRecord, j)
                SeriesEnabled(ChartRecord, j, True)
                'UpdateProgressBar(0, pgbReadCurve, 5)
                'ChartRecord.Series(j).Points.DataBindY(CelloCurve.Record(j))
                'UpdateProgressBar(CelloCurve.TOTAL_RECORD, pgbReadCurve, 5)
            End If
            Threading.Thread.Sleep(1)
        Next
        UpdateUI("Finished: " + CelloCurve.TOTAL_RECORD.ToString, lblMessage)
        SetVisibleUI(pgbReadCurve, False)
        SetChartMaxXAxis(ChartRecord, CelloCurve.TOTAL_RECORD + CelloCurve.TOTAL_RECORD * 0.2)
    End Sub


    Private Sub FormRecord_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If DesignMode Then Exit Sub
        Dim i As Integer
        Me.Top = FromStartUpTopPosition
        Me.Left = 0



        ShowDataFlag = True
        ShowSelectFlag = False
        ShowMode()
    End Sub

    Private Sub btnOpenAlarmRecordFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenAlarmRecordFile.Click
        OpenFileDialog1.Filter = "dat files (*.dat)|*.dat"
        OpenFileDialog1.InitialDirectory = WorkingDir & "Records\AlarmRecords"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            lblAlarmFileName.Text = OpenFileDialog1.FileName
            RichTextAlarmRecord.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.UnicodePlainText)
        End If
    End Sub

    Private Sub btnOpenOperatorFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenOperatorFile.Click
        OpenFileDialog2.Filter = "dat files (*.dat)|*.dat"
        OpenFileDialog2.InitialDirectory = WorkingDir & "Records\OperatorRecords"
        If OpenFileDialog2.ShowDialog = DialogResult.OK Then
            lblOperatorFileName.Text = OpenFileDialog2.FileName
            richRecordUser.LoadFile(OpenFileDialog2.FileName, RichTextBoxStreamType.UnicodePlainText)
        End If
    End Sub

    'Private Sub ProcessFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcessFile.Click
    '    OpenFileDialog3.Filter = "dat files (*.dat)|*.dat"
    '    OpenFileDialog3.InitialDirectory = WorkingDir & "Records\ProcessRecordLists"
    '    If OpenFileDialog3.ShowDialog = DialogResult.OK Then
    '        'Process.Start(OpenFileDialog1.FileName)
    '        lblProcessFileName.Text = OpenFileDialog3.FileName
    '        RichTextProcessRecord.LoadFile(OpenFileDialog3.FileName, RichTextBoxStreamType.UnicodePlainText)
    '    End If
    'End Sub

    Private Sub btnOpenProcessFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenProcessFile.Click
        OpenFileDialog3.Filter = "dat files (*.dat)|*.dat"
        OpenFileDialog3.InitialDirectory = ProcessRecordDir
        If OpenFileDialog3.ShowDialog = DialogResult.OK Then
            'RichTextProcessRecord.LoadFile(OpenFileDialog3.FileName, RichTextBoxStreamType.UnicodePlainText)
            ReadProcessRecord(OpenFileDialog3.FileName)
        End If

    End Sub
    Public Sub ReadProcessRecord(ByVal sfile As String)
        Control_Datalogview1.ReadProcessRecord(sfile)
    End Sub

    'Public Sub ReadProcessRecord(ByVal sfile As String)
    '    Dim i, j, k As Integer
    '    Dim filenum As Integer
    '    Dim sstr As String
    '    Dim data() As String
    '    Dim caption() As String
    '    Dim spacer(1) As Char
    '    Dim fs1 As System.IO.FileStream
    '    Dim sw1 As System.IO.StreamReader
    '    If FileIO.FileSystem.FileExists(sfile) = False Then
    '        MsgBoxLangErr("檔案不存在!!", "File not existed!!")
    '        Exit Sub
    '    End If
    '    fs1 = New System.IO.FileStream(sfile, System.IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read, 1024)
    '    sw1 = New System.IO.StreamReader(fs1, System.Text.Encoding.Unicode)

    '    'ListView1.Columns(k).AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
    '    ListView1.Clear()
    '    RichTextProcessRecord.Clear()
    '    spacer(0) = vbTab
    '    spacer(1) = ","
    '    filenum = FreeFile()
    '    i = 0
    '    j = 0
    '    Dim CaptionLine As Integer = 1
    '    Try
    '        'FileOpen(filenum, sfile, OpenMode.Input, OpenAccess.Read, OpenShare.Shared, 2048)
    '        'Do While Not EOF(filenum)
    '        Do While sw1.EndOfStream = False
    '            'sstr = LineInput(filenum)
    '            sstr = sw1.ReadLine
    '            If i < CaptionLine Then
    '                RichTextProcessRecord.Text = RichTextProcessRecord.Text + sstr + vbCrLf
    '            End If
    '            If i = CaptionLine Then
    '                caption = sstr.Split(vbTab)
    '                For k = 0 To caption.Length - 1
    '                    ListView1.Columns.Add(Trim(caption(k)))
    '                    ListView1.Columns(k).Width = 120
    '                    ListView1.Columns(k).TextAlign = HorizontalAlignment.Center
    '                Next
    '                ListView1.Columns(0).Width = 50
    '            End If
    '            If i > CaptionLine Then
    '                data = sstr.Split(vbTab)
    '                For k = 0 To data.Length - 1
    '                    If k = 0 Then
    '                        ListView1.Items.Add(Trim(data(k)))
    '                    Else
    '                        ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(data(k)))
    '                    End If
    '                Next
    '            End If
    '            i = i + 1
    '        Loop
    '        'FileClose(filenum)
    '        sw1.Close()
    '    Catch ex As Exception
    '        sw1.Close()
    '        'FileClose(filenum)
    '        MsgBoxLangErr(ex.Message)
    '    End Try
    '    sw1.Dispose()
    '    fs1.Dispose()
    'End Sub
    'Curve FormRecords Start
    Dim File1Name As String
    Dim File2Name As String
    Dim i As Integer
    Dim j As Integer
    Dim i0 As Integer
    Dim ShowIndex As Integer
    ''' <summary>
    ''' 選取曲線檔後狀態
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnOpenCurve1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenCurve1.Click
        Dim ii As Integer
        OpenFileDialog4.Filter = "Curve files (*.cuv)|*.cuv"
        OpenFileDialog4.InitialDirectory = WorkingDir & "Records\ProcessrecordCurves\"
        If OpenFileDialog4.ShowDialog = DialogResult.OK Then
            File1Name = OpenFileDialog4.FileName
            lblFileCurve1.Text = My.Computer.FileSystem.GetName(File1Name)
            Dim str As String
            str = ReadProgData("CURVE_SETUP", "CAPTION", "NoData", File1Name)
            Dim subString As String = Mid(str, str.Length, str.Length)
            If subString = "," Then
                str = Mid(str, 1, str.Length - 1)
            End If
            Title = str.Split(",")

            If Title.Length > 18 Then
                CurveDataINI = ProgramDir + "CURVEDATA_DA.INI"        '程式資料INI檔案 有DA欄位
                bolDAShow = True
            Else
                CurveDataINI = ProgramDir + "CURVEDATA.INI"        '程式資料INI檔案
                bolDAShow = False
            End If
            '讀title
            ReadCurveNames(CurveDataINI)
            '建立記錄畫面曲線圖
            CreateChartRecords(FormRecords.pnlRecordCurve, MAX_CURVES)

            '清除舊資料
            Do
                ii = 0
                For Each aa As Control In pnlRecordCSelect1.Controls
                    ii = ii + 1
                    pnlRecordCSelect1.Controls.Remove(aa)
                Next
                'Debug.Print("ii=" + ii.ToString)
            Loop Until ii = 0
            '建立曲線實體
            CreateSeriesRecord(ChartRecord, CurveName, 0, Title.Length)
            '建立記錄畫面曲線選擇區
            InitSeriesSelect(FormRecords.pnlRecordCSelect1, Record_Series, ChartRecord, 0)

            '改名稱語言
            ChangeSeriesRecordName(ChartRecord, CurveName)
            Dim i As Integer
            'For i = 0 To ChartRecord.Series.Count - 1
            For i = 0 To Title.Length - 1
                ChartRecord.Series(i).Points.Clear()
                ChartRecord.Series(i).YAxisType = AxisType.Primary
            Next
            For i = 0 To ChartRecord.ChartAreas.Count - 1
                ChartRecord.ChartAreas(i).AxisX.Maximum = [Double].NaN
            Next

            chkSite1.Checked = True
            chkSite2.Checked = True
            chkSite3.Checked = True
            'chkSite4.Checked = False
            'chkSite5.Checked = False
            'chkSite6.Checked = False
            chkVacuum.Checked = True
            lblMessage.Text = "Reading Data"
            pgbReadCurve.Visible = True
            btnOpenCurve1.Enabled = False
            For i = 0 To Record_Series.Length - 1
                Record_Series(i).chkEnable.Checked = True
                Record_Series(i).lblAxis.Text = "1"
            Next
            'CurveSelectChecked(chkSite1)
            ReadCurveData = New System.Threading.Thread(AddressOf ReadCurveDataThread)
            ReadCurveData.Priority = Threading.ThreadPriority.Highest
            ReadCurveData.Start()

            'ReadCurveBackWorker = New System.ComponentModel.BackgroundWorker()
            'ReadCurveBackWorker.WorkerReportsProgress = True
            'ReadCurveBackWorker.RunWorkerAsync()
        End If
    End Sub

    Private Sub btnYReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYReset.Click
        Dim i As Integer
        For i = 0 To ChartRecord.ChartAreas.Count - 1
            ResetCurve(ChartRecord, i)
        Next
    End Sub


    Private Sub btnPrintCurve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintCurve.Click
        Dim FileName As String
        If lblFileCurve1.Text = "" Then
            FileName = "Record_" + FDate + "_" + FTime
        Else
            FileName = Mid(lblFileCurve1.Text, 1, Len(lblFileCurve1.Text) - 5)
        End If
        printCurve(ChartRecord, FileName)
    End Sub


    Private Sub chkSite1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSite1.Click, chkSite2.Click, chkSite3.Click, chkSite4.Click, chkSite5.Click, chkSite6.Click, chkVacuum.Click
        CurveSelectChecked(sender)
    End Sub

    Public Sub CurveSelectChecked(ByVal sender As System.Object)
        Dim i As Integer
        Dim index As Integer
        Dim j As Integer
        Dim checked As Boolean
        On Error Resume Next
        index = sender.TabIndex
        checked = sender.Checked '第幾個被打勾


        If index = 6 Then '真空值
            ChartRecord.Series(0).Enabled = checked
            ChartRecord.Series(1).Enabled = checked
            Record_Series(0).chkEnable.Checked = checked
            Record_Series(1).chkEnable.Checked = checked
        Else
            If IsNothing(CelloCurve.Record) = False Then
                If ChartRecord.Series(index * 5 + 2).Points.Count = 0 Then
                    For j = (2 + index * 5) To (6 + index * 5)
                        'For j = (2 + index * 5) To (5 + index * 5)
                        PointsBindY(CelloCurve.Record(j), ChartRecord, j)
                    Next
                End If
            End If
            If bolDAShow Then
                For i = 0 To 5
                    If Not IsNothing(ChartRecord.Series(i + index * 6 + 2)) Then
                        ChartRecord.Series(i + index * 6 + 2).Enabled = checked
                        Record_Series(i + index * 6 + 2).chkEnable.Checked = checked
                        'Debug.Print("i + index * 5 + 2=" + (i + index * 5 + 2).ToString)
                    End If
                Next
            Else
                For i = 0 To 4
                    If Not IsNothing(ChartRecord.Series(i + index * 5 + 2)) Then
                        ChartRecord.Series(i + index * 5 + 2).Enabled = checked
                        Record_Series(i + index * 5 + 2).chkEnable.Checked = checked
                        'Debug.Print("i + index * 5 + 2=" + (i + index * 5 + 2).ToString)
                    End If
                Next
            End If

        End If
        If chkSite1.Checked = True Then
            ChartRecord.ChartAreas(0).AxisY.Title = "Site1"
        Else
            If chkVacuum.Checked Then
                ChartRecord.ChartAreas(0).AxisY.Title = "Vacuum"
            End If
        End If
        For i = 0 To ChartRecord.ChartAreas.Count - 1
            ChartRecord.ChartAreas(0).RecalculateAxesScale()
        Next
    End Sub


    Private Sub btnCurveSelect1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCurveSelect1.Click
        ShowSelectFlag = Not ShowSelectFlag
        If ShowSelectFlag Then
            ShowDataFlag = False
        End If
        ShowMode()
    End Sub
    Private Sub btnValueShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnValueShow.Click
        ShowDataFlag = Not ShowDataFlag
        If ShowDataFlag Then
            ShowSelectFlag = False
        End If
        ShowMode()
    End Sub

    Private Sub ShowMode()
        If ShowDataFlag Or ShowSelectFlag Then
            pnlRecordCurve.Width = tabPageCurveRecord.Width - pnlRecordCSelect1.Width
        Else
            pnlRecordCurve.Width = tabPageCurveRecord.Width
        End If
        ObjShow.Show(ShowDataFlag, btnValueShow, Color.Lime, Color.FromArgb(255, 255, 192))
        ObjShow.Show(ShowSelectFlag, btnCurveSelect1, Color.Lime, Color.FromArgb(255, 255, 192))

        pnlShowRecordData.Visible = ShowDataFlag
        pnlRecordCSelect1.Visible = ShowSelectFlag
        'ChartRecord.Width = pnlRecordCurve.Width
    End Sub

    'Private Sub SaveChartToJPG(ByVal cChart As Chart)
    '    Dim sFile As String
    '    If FormkeyInFileNames.ShowDialog() = DialogResult.OK Then
    '        If FormkeyInFileNames.FileName = "" Then
    '            sFile = JPGDir + FDate + "_" + FTime + ".JPG"
    '        Else
    '            sFile = JPGDir + FormkeyInFileNames.FileName + ".JPG"
    '        End If
    '        cChart.SaveImage(sFile, DataVisualization.Charting.ChartImageFormat.Jpeg)
    '    End If

    'End Sub


    Private Sub btnMultiChartArea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMultiChartArea.Click
        Dim i, j, k As Integer
        MultiAreaFlag = Not MultiAreaFlag
        If MultiAreaFlag Then
            ChartRecord.ChartAreas(0).AxisY.Title = ChartRecord.ChartAreas(0).Name
            ChartRecord.Series(0).Enabled = False
            ChartRecord.Series(1).Enabled = False
            k = 0
            j = 0
            For i = 2 To MAX_CURVES - 1
                If k < ChartRecord.ChartAreas.Count Then
                    ChartRecord.Series(i).ChartArea = ChartRecord.ChartAreas(k).Name
                End If
                If j >= 4 Then
                    j = 0
                    k += 1
                Else
                    j += 1
                End If
            Next
        Else
            ChartRecord.ChartAreas(0).AxisY.Title = ""
            ChartRecord.Series(0).Enabled = True
            ChartRecord.Series(1).Enabled = True
            For i = 0 To MAX_CURVES - 1
                ChartRecord.Series(i).ChartArea = ChartRecord.ChartAreas(0).Name
            Next
        End If
        ChartRecord.ChartAreas("Site2").Visible = MultiAreaFlag
        ChartRecord.ChartAreas("Site3").Visible = MultiAreaFlag
        If MAXPLATE > 2 Then
            ChartRecord.ChartAreas("Site4").Visible = MultiAreaFlag
            ChartRecord.ChartAreas("Site5").Visible = MultiAreaFlag
            ChartRecord.ChartAreas("Site6").Visible = MultiAreaFlag
        End If
        'ChartRecord.ChartAreas("Vacuum").Visible = MultiAreaFlag
        ObjShow.Show(MultiAreaFlag, sender, Color.Lime, Color.FromArgb(255, 255, 192))

    End Sub


    Public StopZoomFlag As Boolean
    Private Sub btnStopZoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStopZoom.Click
        Dim i As Integer
        StopZoomFlag = Not StopZoomFlag
        ObjShow.Show(StopZoomFlag, btnStopZoom, Color.Lime, Color.FromArgb(192, 192, 255))
        If StopZoomFlag Then
            For i = 0 To ChartRecord.ChartAreas.Count - 1
                ChartRecord.ChartAreas(i).AxisX.ScaleView.Zoomable = False          'X軸 可放大,縮小
                ChartRecord.ChartAreas(i).AxisY.ScaleView.Zoomable = False          'X軸 可放大,縮小
                ChartRecord.ChartAreas(i).AxisY2.ScaleView.Zoomable = False          'X軸 可放大,縮小
            Next
        Else
            For i = 0 To ChartRecord.ChartAreas.Count - 1
                ChartRecord.ChartAreas(i).AxisX.ScaleView.Zoomable = True          'X軸 可放大,縮小
                ChartRecord.ChartAreas(i).AxisY.ScaleView.Zoomable = True          'X軸 可放大,縮小
                ChartRecord.ChartAreas(i).AxisY2.ScaleView.Zoomable = True          'X軸 可放大,縮小

            Next
        End If
    End Sub

    Private Sub btnSaveAs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveAs.Click
        SaveChartToJPG(ChartRecord)
    End Sub

End Class

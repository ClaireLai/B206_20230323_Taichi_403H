<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlADAM4118
    Inherits System.Windows.Forms.UserControl

    'UserControl 覆寫 Dispose 以清除元件清單。
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
        Dim Series7 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
        Dim Series8 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
        Me.cmoUserName = New System.Windows.Forms.ComboBox
        Me.btnCurveForm = New System.Windows.Forms.Button
        Me.btnSub1000 = New System.Windows.Forms.Button
        Me.btnAdd1000 = New System.Windows.Forms.Button
        Me.btnOpenFile = New System.Windows.Forms.Button
        Me.lstLogList = New System.Windows.Forms.ListBox
        Me.btnStartLog = New System.Windows.Forms.Button
        Me.cmoComport = New System.Windows.Forms.ComboBox
        Me.lblLogFileName = New System.Windows.Forms.Label
        Me.lblCount = New System.Windows.Forms.Label
        Me.lblData08 = New System.Windows.Forms.Label
        Me.lblData07 = New System.Windows.Forms.Label
        Me.lblData06 = New System.Windows.Forms.Label
        Me.lblData05 = New System.Windows.Forms.Label
        Me.lblData04 = New System.Windows.Forms.Label
        Me.lblData03 = New System.Windows.Forms.Label
        Me.lblData02 = New System.Windows.Forms.Label
        Me.lblData01 = New System.Windows.Forms.Label
        Me.lblLogStartTime = New System.Windows.Forms.Label
        Me.lblCurrentTime = New System.Windows.Forms.Label
        Me.lblStartTimeText = New System.Windows.Forms.Label
        Me.lblLogCountText = New System.Windows.Forms.Label
        Me.lblIntervalText = New System.Windows.Forms.Label
        Me.lblCurrentTimeText = New System.Windows.Forms.Label
        Me.txtListTitle = New System.Windows.Forms.TextBox
        Me.txtStepTime = New System.Windows.Forms.TextBox
        Me.btnCloseComm = New System.Windows.Forms.Button
        Me.btnOpenComm = New System.Windows.Forms.Button
        Me.pnlChart = New System.Windows.Forms.Panel
        Me.btnYReset = New System.Windows.Forms.Button
        Me.btnPrintCurve = New System.Windows.Forms.Button
        Me.chkCH08 = New System.Windows.Forms.CheckBox
        Me.chkCH07 = New System.Windows.Forms.CheckBox
        Me.chkCH06 = New System.Windows.Forms.CheckBox
        Me.chkCH05 = New System.Windows.Forms.CheckBox
        Me.chkCH01 = New System.Windows.Forms.CheckBox
        Me.chkCH04 = New System.Windows.Forms.CheckBox
        Me.chkCH02 = New System.Windows.Forms.CheckBox
        Me.chkCH03 = New System.Windows.Forms.CheckBox
        Me.ChartTimeLog = New System.Windows.Forms.DataVisualization.Charting.Chart
        Me.btnClose = New System.Windows.Forms.Button
        Me.pnlChart.SuspendLayout()
        CType(Me.ChartTimeLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmoUserName
        '
        Me.cmoUserName.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmoUserName.FormattingEnabled = True
        Me.cmoUserName.Location = New System.Drawing.Point(518, 64)
        Me.cmoUserName.Name = "cmoUserName"
        Me.cmoUserName.Size = New System.Drawing.Size(92, 27)
        Me.cmoUserName.TabIndex = 169
        '
        'btnCurveForm
        '
        Me.btnCurveForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCurveForm.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCurveForm.Location = New System.Drawing.Point(327, 64)
        Me.btnCurveForm.Margin = New System.Windows.Forms.Padding(6)
        Me.btnCurveForm.Name = "btnCurveForm"
        Me.btnCurveForm.Size = New System.Drawing.Size(76, 39)
        Me.btnCurveForm.TabIndex = 168
        Me.btnCurveForm.Text = "曲線圖"
        Me.btnCurveForm.UseVisualStyleBackColor = False
        '
        'btnSub1000
        '
        Me.btnSub1000.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSub1000.Location = New System.Drawing.Point(432, 31)
        Me.btnSub1000.Margin = New System.Windows.Forms.Padding(6)
        Me.btnSub1000.Name = "btnSub1000"
        Me.btnSub1000.Size = New System.Drawing.Size(36, 27)
        Me.btnSub1000.TabIndex = 151
        Me.btnSub1000.Text = "-1"
        Me.btnSub1000.UseVisualStyleBackColor = True
        '
        'btnAdd1000
        '
        Me.btnAdd1000.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd1000.Location = New System.Drawing.Point(389, 31)
        Me.btnAdd1000.Margin = New System.Windows.Forms.Padding(6)
        Me.btnAdd1000.Name = "btnAdd1000"
        Me.btnAdd1000.Size = New System.Drawing.Size(36, 27)
        Me.btnAdd1000.TabIndex = 150
        Me.btnAdd1000.Text = "+1"
        Me.btnAdd1000.UseVisualStyleBackColor = True
        '
        'btnOpenFile
        '
        Me.btnOpenFile.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenFile.Location = New System.Drawing.Point(223, 64)
        Me.btnOpenFile.Margin = New System.Windows.Forms.Padding(6)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(76, 39)
        Me.btnOpenFile.TabIndex = 148
        Me.btnOpenFile.Text = "資料夾"
        Me.btnOpenFile.UseVisualStyleBackColor = True
        '
        'lstLogList
        '
        Me.lstLogList.BackColor = System.Drawing.Color.Honeydew
        Me.lstLogList.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstLogList.FormattingEnabled = True
        Me.lstLogList.HorizontalExtent = 500
        Me.lstLogList.HorizontalScrollbar = True
        Me.lstLogList.ItemHeight = 16
        Me.lstLogList.Location = New System.Drawing.Point(3, 159)
        Me.lstLogList.Name = "lstLogList"
        Me.lstLogList.Size = New System.Drawing.Size(713, 324)
        Me.lstLogList.TabIndex = 147
        '
        'btnStartLog
        '
        Me.btnStartLog.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnStartLog.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartLog.Location = New System.Drawing.Point(620, 103)
        Me.btnStartLog.Margin = New System.Windows.Forms.Padding(6)
        Me.btnStartLog.Name = "btnStartLog"
        Me.btnStartLog.Size = New System.Drawing.Size(92, 32)
        Me.btnStartLog.TabIndex = 146
        Me.btnStartLog.Text = "記錄開始"
        Me.btnStartLog.UseVisualStyleBackColor = False
        '
        'cmoComport
        '
        Me.cmoComport.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmoComport.FormattingEnabled = True
        Me.cmoComport.Location = New System.Drawing.Point(518, 31)
        Me.cmoComport.Name = "cmoComport"
        Me.cmoComport.Size = New System.Drawing.Size(92, 27)
        Me.cmoComport.TabIndex = 145
        '
        'lblLogFileName
        '
        Me.lblLogFileName.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblLogFileName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLogFileName.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogFileName.Location = New System.Drawing.Point(4, 104)
        Me.lblLogFileName.Name = "lblLogFileName"
        Me.lblLogFileName.Size = New System.Drawing.Size(606, 31)
        Me.lblLogFileName.TabIndex = 144
        Me.lblLogFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCount
        '
        Me.lblCount.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCount.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.Location = New System.Drawing.Point(103, 78)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(107, 24)
        Me.lblCount.TabIndex = 143
        Me.lblCount.Text = "00"
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblData08
        '
        Me.lblData08.BackColor = System.Drawing.Color.Black
        Me.lblData08.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblData08.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData08.ForeColor = System.Drawing.Color.Red
        Me.lblData08.Location = New System.Drawing.Point(620, 0)
        Me.lblData08.Name = "lblData08"
        Me.lblData08.Size = New System.Drawing.Size(88, 27)
        Me.lblData08.TabIndex = 159
        Me.lblData08.Text = "00"
        Me.lblData08.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblData07
        '
        Me.lblData07.BackColor = System.Drawing.Color.Black
        Me.lblData07.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblData07.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData07.ForeColor = System.Drawing.Color.Red
        Me.lblData07.Location = New System.Drawing.Point(532, 0)
        Me.lblData07.Name = "lblData07"
        Me.lblData07.Size = New System.Drawing.Size(88, 27)
        Me.lblData07.TabIndex = 158
        Me.lblData07.Text = "00"
        Me.lblData07.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblData06
        '
        Me.lblData06.BackColor = System.Drawing.Color.Black
        Me.lblData06.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblData06.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData06.ForeColor = System.Drawing.Color.Red
        Me.lblData06.Location = New System.Drawing.Point(444, 0)
        Me.lblData06.Name = "lblData06"
        Me.lblData06.Size = New System.Drawing.Size(88, 27)
        Me.lblData06.TabIndex = 157
        Me.lblData06.Text = "00"
        Me.lblData06.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblData05
        '
        Me.lblData05.BackColor = System.Drawing.Color.Black
        Me.lblData05.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblData05.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData05.ForeColor = System.Drawing.Color.Red
        Me.lblData05.Location = New System.Drawing.Point(356, 0)
        Me.lblData05.Name = "lblData05"
        Me.lblData05.Size = New System.Drawing.Size(88, 27)
        Me.lblData05.TabIndex = 156
        Me.lblData05.Text = "00"
        Me.lblData05.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblData04
        '
        Me.lblData04.BackColor = System.Drawing.Color.Black
        Me.lblData04.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblData04.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData04.ForeColor = System.Drawing.Color.Red
        Me.lblData04.Location = New System.Drawing.Point(268, 0)
        Me.lblData04.Name = "lblData04"
        Me.lblData04.Size = New System.Drawing.Size(88, 27)
        Me.lblData04.TabIndex = 155
        Me.lblData04.Text = "00"
        Me.lblData04.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblData03
        '
        Me.lblData03.BackColor = System.Drawing.Color.Black
        Me.lblData03.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblData03.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData03.ForeColor = System.Drawing.Color.Red
        Me.lblData03.Location = New System.Drawing.Point(180, 0)
        Me.lblData03.Name = "lblData03"
        Me.lblData03.Size = New System.Drawing.Size(88, 27)
        Me.lblData03.TabIndex = 154
        Me.lblData03.Text = "00"
        Me.lblData03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblData02
        '
        Me.lblData02.BackColor = System.Drawing.Color.Black
        Me.lblData02.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblData02.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData02.ForeColor = System.Drawing.Color.Red
        Me.lblData02.Location = New System.Drawing.Point(92, 0)
        Me.lblData02.Name = "lblData02"
        Me.lblData02.Size = New System.Drawing.Size(88, 27)
        Me.lblData02.TabIndex = 153
        Me.lblData02.Text = "00"
        Me.lblData02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblData01
        '
        Me.lblData01.BackColor = System.Drawing.Color.Black
        Me.lblData01.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblData01.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData01.ForeColor = System.Drawing.Color.Red
        Me.lblData01.Location = New System.Drawing.Point(4, 0)
        Me.lblData01.Name = "lblData01"
        Me.lblData01.Size = New System.Drawing.Size(88, 27)
        Me.lblData01.TabIndex = 152
        Me.lblData01.Text = "00"
        Me.lblData01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLogStartTime
        '
        Me.lblLogStartTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblLogStartTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLogStartTime.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogStartTime.Location = New System.Drawing.Point(103, 52)
        Me.lblLogStartTime.Name = "lblLogStartTime"
        Me.lblLogStartTime.Size = New System.Drawing.Size(107, 24)
        Me.lblLogStartTime.TabIndex = 141
        Me.lblLogStartTime.Text = "00:00:00"
        Me.lblLogStartTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCurrentTime
        '
        Me.lblCurrentTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblCurrentTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCurrentTime.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentTime.Location = New System.Drawing.Point(103, 27)
        Me.lblCurrentTime.Name = "lblCurrentTime"
        Me.lblCurrentTime.Size = New System.Drawing.Size(107, 24)
        Me.lblCurrentTime.TabIndex = 142
        Me.lblCurrentTime.Text = "00:00:00"
        Me.lblCurrentTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStartTimeText
        '
        Me.lblStartTimeText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartTimeText.Location = New System.Drawing.Point(4, 50)
        Me.lblStartTimeText.Name = "lblStartTimeText"
        Me.lblStartTimeText.Size = New System.Drawing.Size(90, 27)
        Me.lblStartTimeText.TabIndex = 140
        Me.lblStartTimeText.Text = "開始時間:"
        Me.lblStartTimeText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLogCountText
        '
        Me.lblLogCountText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogCountText.Location = New System.Drawing.Point(4, 74)
        Me.lblLogCountText.Name = "lblLogCountText"
        Me.lblLogCountText.Size = New System.Drawing.Size(90, 27)
        Me.lblLogCountText.TabIndex = 139
        Me.lblLogCountText.Text = "記錄計數:"
        Me.lblLogCountText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblIntervalText
        '
        Me.lblIntervalText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntervalText.Location = New System.Drawing.Point(216, 31)
        Me.lblIntervalText.Name = "lblIntervalText"
        Me.lblIntervalText.Size = New System.Drawing.Size(119, 27)
        Me.lblIntervalText.TabIndex = 136
        Me.lblIntervalText.Text = "記錄間隔(Sec):"
        Me.lblIntervalText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCurrentTimeText
        '
        Me.lblCurrentTimeText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentTimeText.Location = New System.Drawing.Point(4, 28)
        Me.lblCurrentTimeText.Name = "lblCurrentTimeText"
        Me.lblCurrentTimeText.Size = New System.Drawing.Size(90, 27)
        Me.lblCurrentTimeText.TabIndex = 137
        Me.lblCurrentTimeText.Text = "現在時間:"
        Me.lblCurrentTimeText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtListTitle
        '
        Me.txtListTitle.BackColor = System.Drawing.Color.AliceBlue
        Me.txtListTitle.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtListTitle.ForeColor = System.Drawing.Color.Black
        Me.txtListTitle.Location = New System.Drawing.Point(3, 138)
        Me.txtListTitle.Margin = New System.Windows.Forms.Padding(6)
        Me.txtListTitle.Name = "txtListTitle"
        Me.txtListTitle.Size = New System.Drawing.Size(713, 22)
        Me.txtListTitle.TabIndex = 134
        Me.txtListTitle.Text = "Title"
        '
        'txtStepTime
        '
        Me.txtStepTime.BackColor = System.Drawing.Color.White
        Me.txtStepTime.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtStepTime.ForeColor = System.Drawing.Color.Black
        Me.txtStepTime.Location = New System.Drawing.Point(339, 31)
        Me.txtStepTime.Margin = New System.Windows.Forms.Padding(6)
        Me.txtStepTime.Name = "txtStepTime"
        Me.txtStepTime.Size = New System.Drawing.Size(47, 27)
        Me.txtStepTime.TabIndex = 133
        Me.txtStepTime.Text = "1"
        Me.txtStepTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCloseComm
        '
        Me.btnCloseComm.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCloseComm.Location = New System.Drawing.Point(619, 64)
        Me.btnCloseComm.Margin = New System.Windows.Forms.Padding(6)
        Me.btnCloseComm.Name = "btnCloseComm"
        Me.btnCloseComm.Size = New System.Drawing.Size(93, 27)
        Me.btnCloseComm.TabIndex = 131
        Me.btnCloseComm.Text = "通訊停止"
        Me.btnCloseComm.UseVisualStyleBackColor = True
        '
        'btnOpenComm
        '
        Me.btnOpenComm.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenComm.Location = New System.Drawing.Point(618, 28)
        Me.btnOpenComm.Margin = New System.Windows.Forms.Padding(6)
        Me.btnOpenComm.Name = "btnOpenComm"
        Me.btnOpenComm.Size = New System.Drawing.Size(93, 27)
        Me.btnOpenComm.TabIndex = 132
        Me.btnOpenComm.Text = "通訊開啟"
        Me.btnOpenComm.UseVisualStyleBackColor = True
        '
        'pnlChart
        '
        Me.pnlChart.Controls.Add(Me.btnYReset)
        Me.pnlChart.Controls.Add(Me.btnPrintCurve)
        Me.pnlChart.Controls.Add(Me.chkCH08)
        Me.pnlChart.Controls.Add(Me.chkCH07)
        Me.pnlChart.Controls.Add(Me.chkCH06)
        Me.pnlChart.Controls.Add(Me.chkCH05)
        Me.pnlChart.Controls.Add(Me.chkCH01)
        Me.pnlChart.Controls.Add(Me.chkCH04)
        Me.pnlChart.Controls.Add(Me.chkCH02)
        Me.pnlChart.Controls.Add(Me.chkCH03)
        Me.pnlChart.Controls.Add(Me.ChartTimeLog)
        Me.pnlChart.Location = New System.Drawing.Point(3, 159)
        Me.pnlChart.Name = "pnlChart"
        Me.pnlChart.Size = New System.Drawing.Size(712, 324)
        Me.pnlChart.TabIndex = 170
        '
        'btnYReset
        '
        Me.btnYReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnYReset.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular)
        Me.btnYReset.Location = New System.Drawing.Point(615, 5)
        Me.btnYReset.Name = "btnYReset"
        Me.btnYReset.Size = New System.Drawing.Size(93, 34)
        Me.btnYReset.TabIndex = 533
        Me.btnYReset.Text = "重設"
        Me.btnYReset.UseVisualStyleBackColor = False
        '
        'btnPrintCurve
        '
        Me.btnPrintCurve.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPrintCurve.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular)
        Me.btnPrintCurve.Location = New System.Drawing.Point(616, 45)
        Me.btnPrintCurve.Name = "btnPrintCurve"
        Me.btnPrintCurve.Size = New System.Drawing.Size(93, 34)
        Me.btnPrintCurve.TabIndex = 534
        Me.btnPrintCurve.Text = "列印"
        Me.btnPrintCurve.UseVisualStyleBackColor = False
        '
        'chkCH08
        '
        Me.chkCH08.AutoSize = True
        Me.chkCH08.Checked = True
        Me.chkCH08.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCH08.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCH08.Location = New System.Drawing.Point(617, 253)
        Me.chkCH08.Name = "chkCH08"
        Me.chkCH08.Size = New System.Drawing.Size(61, 23)
        Me.chkCH08.TabIndex = 530
        Me.chkCH08.Text = "CH8"
        Me.chkCH08.UseVisualStyleBackColor = True
        '
        'chkCH07
        '
        Me.chkCH07.AutoSize = True
        Me.chkCH07.Checked = True
        Me.chkCH07.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCH07.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCH07.Location = New System.Drawing.Point(617, 229)
        Me.chkCH07.Name = "chkCH07"
        Me.chkCH07.Size = New System.Drawing.Size(61, 23)
        Me.chkCH07.TabIndex = 532
        Me.chkCH07.Text = "CH7"
        Me.chkCH07.UseVisualStyleBackColor = True
        '
        'chkCH06
        '
        Me.chkCH06.AutoSize = True
        Me.chkCH06.Checked = True
        Me.chkCH06.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCH06.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCH06.Location = New System.Drawing.Point(617, 205)
        Me.chkCH06.Name = "chkCH06"
        Me.chkCH06.Size = New System.Drawing.Size(61, 23)
        Me.chkCH06.TabIndex = 531
        Me.chkCH06.Text = "CH6"
        Me.chkCH06.UseVisualStyleBackColor = True
        '
        'chkCH05
        '
        Me.chkCH05.AutoSize = True
        Me.chkCH05.Checked = True
        Me.chkCH05.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCH05.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCH05.Location = New System.Drawing.Point(617, 181)
        Me.chkCH05.Name = "chkCH05"
        Me.chkCH05.Size = New System.Drawing.Size(61, 23)
        Me.chkCH05.TabIndex = 526
        Me.chkCH05.Text = "CH5"
        Me.chkCH05.UseVisualStyleBackColor = True
        '
        'chkCH01
        '
        Me.chkCH01.AutoSize = True
        Me.chkCH01.Checked = True
        Me.chkCH01.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCH01.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCH01.Location = New System.Drawing.Point(617, 85)
        Me.chkCH01.Name = "chkCH01"
        Me.chkCH01.Size = New System.Drawing.Size(61, 23)
        Me.chkCH01.TabIndex = 529
        Me.chkCH01.Text = "CH1"
        Me.chkCH01.UseVisualStyleBackColor = True
        '
        'chkCH04
        '
        Me.chkCH04.AutoSize = True
        Me.chkCH04.Checked = True
        Me.chkCH04.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCH04.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCH04.Location = New System.Drawing.Point(617, 157)
        Me.chkCH04.Name = "chkCH04"
        Me.chkCH04.Size = New System.Drawing.Size(61, 23)
        Me.chkCH04.TabIndex = 528
        Me.chkCH04.Text = "CH4"
        Me.chkCH04.UseVisualStyleBackColor = True
        '
        'chkCH02
        '
        Me.chkCH02.AutoSize = True
        Me.chkCH02.Checked = True
        Me.chkCH02.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCH02.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCH02.Location = New System.Drawing.Point(617, 109)
        Me.chkCH02.Name = "chkCH02"
        Me.chkCH02.Size = New System.Drawing.Size(61, 23)
        Me.chkCH02.TabIndex = 527
        Me.chkCH02.Text = "CH2"
        Me.chkCH02.UseVisualStyleBackColor = True
        '
        'chkCH03
        '
        Me.chkCH03.AutoSize = True
        Me.chkCH03.Checked = True
        Me.chkCH03.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCH03.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCH03.Location = New System.Drawing.Point(617, 133)
        Me.chkCH03.Name = "chkCH03"
        Me.chkCH03.Size = New System.Drawing.Size(61, 23)
        Me.chkCH03.TabIndex = 525
        Me.chkCH03.Text = "CH3"
        Me.chkCH03.UseVisualStyleBackColor = True
        '
        'ChartTimeLog
        '
        ChartArea1.Name = "ChartArea1"
        Me.ChartTimeLog.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.ChartTimeLog.Legends.Add(Legend1)
        Me.ChartTimeLog.Location = New System.Drawing.Point(2, 1)
        Me.ChartTimeLog.Name = "ChartTimeLog"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series2.Legend = "Legend1"
        Series2.Name = "Series2"
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series3.Legend = "Legend1"
        Series3.Name = "Series3"
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series4.Legend = "Legend1"
        Series4.Name = "Series4"
        Series5.ChartArea = "ChartArea1"
        Series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series5.Legend = "Legend1"
        Series5.Name = "Series5"
        Series6.ChartArea = "ChartArea1"
        Series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series6.Legend = "Legend1"
        Series6.Name = "Series6"
        Series7.ChartArea = "ChartArea1"
        Series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series7.Legend = "Legend1"
        Series7.Name = "Series7"
        Series8.ChartArea = "ChartArea1"
        Series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series8.Legend = "Legend1"
        Series8.Name = "Series8"
        Me.ChartTimeLog.Series.Add(Series1)
        Me.ChartTimeLog.Series.Add(Series2)
        Me.ChartTimeLog.Series.Add(Series3)
        Me.ChartTimeLog.Series.Add(Series4)
        Me.ChartTimeLog.Series.Add(Series5)
        Me.ChartTimeLog.Series.Add(Series6)
        Me.ChartTimeLog.Series.Add(Series7)
        Me.ChartTimeLog.Series.Add(Series8)
        Me.ChartTimeLog.Size = New System.Drawing.Size(607, 320)
        Me.ChartTimeLog.TabIndex = 0
        Me.ChartTimeLog.Text = "Chart1"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.LightPink
        Me.btnClose.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(431, 64)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(6)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(76, 39)
        Me.btnClose.TabIndex = 524
        Me.btnClose.Text = "關閉"
        Me.btnClose.UseVisualStyleBackColor = False
        Me.btnClose.Visible = False
        '
        'ControlADAM4118
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.pnlChart)
        Me.Controls.Add(Me.cmoUserName)
        Me.Controls.Add(Me.btnCurveForm)
        Me.Controls.Add(Me.btnSub1000)
        Me.Controls.Add(Me.btnAdd1000)
        Me.Controls.Add(Me.btnOpenFile)
        Me.Controls.Add(Me.lstLogList)
        Me.Controls.Add(Me.btnStartLog)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.cmoComport)
        Me.Controls.Add(Me.lblLogFileName)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.lblData08)
        Me.Controls.Add(Me.lblData07)
        Me.Controls.Add(Me.lblData06)
        Me.Controls.Add(Me.lblData05)
        Me.Controls.Add(Me.lblData04)
        Me.Controls.Add(Me.lblData03)
        Me.Controls.Add(Me.lblData02)
        Me.Controls.Add(Me.lblData01)
        Me.Controls.Add(Me.lblLogStartTime)
        Me.Controls.Add(Me.lblCurrentTime)
        Me.Controls.Add(Me.lblStartTimeText)
        Me.Controls.Add(Me.lblLogCountText)
        Me.Controls.Add(Me.lblIntervalText)
        Me.Controls.Add(Me.lblCurrentTimeText)
        Me.Controls.Add(Me.txtListTitle)
        Me.Controls.Add(Me.txtStepTime)
        Me.Controls.Add(Me.btnCloseComm)
        Me.Controls.Add(Me.btnOpenComm)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "ControlADAM4118"
        Me.Size = New System.Drawing.Size(722, 486)
        Me.pnlChart.ResumeLayout(False)
        Me.pnlChart.PerformLayout()
        CType(Me.ChartTimeLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmoUserName As System.Windows.Forms.ComboBox
    Friend WithEvents btnCurveForm As System.Windows.Forms.Button
    Friend WithEvents btnSub1000 As System.Windows.Forms.Button
    Friend WithEvents btnAdd1000 As System.Windows.Forms.Button
    Friend WithEvents btnOpenFile As System.Windows.Forms.Button
    Friend WithEvents lstLogList As System.Windows.Forms.ListBox
    Friend WithEvents btnStartLog As System.Windows.Forms.Button
    Friend WithEvents cmoComport As System.Windows.Forms.ComboBox
    Friend WithEvents lblLogFileName As System.Windows.Forms.Label
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents lblData08 As System.Windows.Forms.Label
    Friend WithEvents lblData07 As System.Windows.Forms.Label
    Friend WithEvents lblData06 As System.Windows.Forms.Label
    Friend WithEvents lblData05 As System.Windows.Forms.Label
    Friend WithEvents lblData04 As System.Windows.Forms.Label
    Friend WithEvents lblData03 As System.Windows.Forms.Label
    Friend WithEvents lblData02 As System.Windows.Forms.Label
    Friend WithEvents lblData01 As System.Windows.Forms.Label
    Friend WithEvents lblLogStartTime As System.Windows.Forms.Label
    Friend WithEvents lblCurrentTime As System.Windows.Forms.Label
    Friend WithEvents lblStartTimeText As System.Windows.Forms.Label
    Friend WithEvents lblLogCountText As System.Windows.Forms.Label
    Friend WithEvents lblIntervalText As System.Windows.Forms.Label
    Friend WithEvents lblCurrentTimeText As System.Windows.Forms.Label
    Friend WithEvents txtListTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtStepTime As System.Windows.Forms.TextBox
    Friend WithEvents btnCloseComm As System.Windows.Forms.Button
    Friend WithEvents btnOpenComm As System.Windows.Forms.Button
    Friend WithEvents pnlChart As System.Windows.Forms.Panel
    Friend WithEvents ChartTimeLog As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents btnYReset As System.Windows.Forms.Button
    Friend WithEvents btnPrintCurve As System.Windows.Forms.Button
    Friend WithEvents chkCH08 As System.Windows.Forms.CheckBox
    Friend WithEvents chkCH07 As System.Windows.Forms.CheckBox
    Friend WithEvents chkCH06 As System.Windows.Forms.CheckBox
    Friend WithEvents chkCH05 As System.Windows.Forms.CheckBox
    Friend WithEvents chkCH01 As System.Windows.Forms.CheckBox
    Friend WithEvents chkCH04 As System.Windows.Forms.CheckBox
    Friend WithEvents chkCH02 As System.Windows.Forms.CheckBox
    Friend WithEvents chkCH03 As System.Windows.Forms.CheckBox
    Friend WithEvents btnClose As System.Windows.Forms.Button

End Class

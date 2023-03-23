<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlADAM4018_Modbus
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtListTitle = New System.Windows.Forms.TextBox
        Me.txtStepTime = New System.Windows.Forms.TextBox
        Me.btnCloseComm = New System.Windows.Forms.Button
        Me.btnOpenComm = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.lblData16 = New System.Windows.Forms.Label
        Me.lblData15 = New System.Windows.Forms.Label
        Me.lblData14 = New System.Windows.Forms.Label
        Me.lblData13 = New System.Windows.Forms.Label
        Me.lblData12 = New System.Windows.Forms.Label
        Me.lblData11 = New System.Windows.Forms.Label
        Me.lblData10 = New System.Windows.Forms.Label
        Me.lblData09 = New System.Windows.Forms.Label
        Me.txtListTitle2 = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'cmoUserName
        '
        Me.cmoUserName.Font = New System.Drawing.Font("新細明體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmoUserName.FormattingEnabled = True
        Me.cmoUserName.Location = New System.Drawing.Point(518, 105)
        Me.cmoUserName.Name = "cmoUserName"
        Me.cmoUserName.Size = New System.Drawing.Size(92, 27)
        Me.cmoUserName.TabIndex = 169
        '
        'btnCurveForm
        '
        Me.btnCurveForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCurveForm.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCurveForm.Location = New System.Drawing.Point(356, 116)
        Me.btnCurveForm.Margin = New System.Windows.Forms.Padding(6)
        Me.btnCurveForm.Name = "btnCurveForm"
        Me.btnCurveForm.Size = New System.Drawing.Size(76, 31)
        Me.btnCurveForm.TabIndex = 168
        Me.btnCurveForm.Text = "曲線圖"
        Me.btnCurveForm.UseVisualStyleBackColor = False
        '
        'btnSub1000
        '
        Me.btnSub1000.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSub1000.Location = New System.Drawing.Point(296, 120)
        Me.btnSub1000.Margin = New System.Windows.Forms.Padding(6)
        Me.btnSub1000.Name = "btnSub1000"
        Me.btnSub1000.Size = New System.Drawing.Size(45, 27)
        Me.btnSub1000.TabIndex = 151
        Me.btnSub1000.Text = "-1"
        Me.btnSub1000.UseVisualStyleBackColor = True
        '
        'btnAdd1000
        '
        Me.btnAdd1000.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd1000.Location = New System.Drawing.Point(235, 120)
        Me.btnAdd1000.Margin = New System.Windows.Forms.Padding(6)
        Me.btnAdd1000.Name = "btnAdd1000"
        Me.btnAdd1000.Size = New System.Drawing.Size(45, 27)
        Me.btnAdd1000.TabIndex = 150
        Me.btnAdd1000.Text = "+1"
        Me.btnAdd1000.UseVisualStyleBackColor = True
        '
        'btnOpenFile
        '
        Me.btnOpenFile.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenFile.Location = New System.Drawing.Point(9, 146)
        Me.btnOpenFile.Margin = New System.Windows.Forms.Padding(6)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(85, 45)
        Me.btnOpenFile.TabIndex = 148
        Me.btnOpenFile.Text = "資料夾"
        Me.btnOpenFile.UseVisualStyleBackColor = True
        '
        'lstLogList
        '
        Me.lstLogList.BackColor = System.Drawing.Color.Honeydew
        Me.lstLogList.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstLogList.FormattingEnabled = True
        Me.lstLogList.HorizontalExtent = 500
        Me.lstLogList.HorizontalScrollbar = True
        Me.lstLogList.ItemHeight = 16
        Me.lstLogList.Location = New System.Drawing.Point(1, 250)
        Me.lstLogList.Name = "lstLogList"
        Me.lstLogList.Size = New System.Drawing.Size(713, 436)
        Me.lstLogList.TabIndex = 147
        '
        'btnStartLog
        '
        Me.btnStartLog.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnStartLog.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartLog.Location = New System.Drawing.Point(619, 144)
        Me.btnStartLog.Margin = New System.Windows.Forms.Padding(6)
        Me.btnStartLog.Name = "btnStartLog"
        Me.btnStartLog.Size = New System.Drawing.Size(92, 47)
        Me.btnStartLog.TabIndex = 146
        Me.btnStartLog.Text = "記錄開始"
        Me.btnStartLog.UseVisualStyleBackColor = False
        '
        'cmoComport
        '
        Me.cmoComport.Font = New System.Drawing.Font("新細明體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmoComport.FormattingEnabled = True
        Me.cmoComport.Location = New System.Drawing.Point(470, 66)
        Me.cmoComport.Name = "cmoComport"
        Me.cmoComport.Size = New System.Drawing.Size(140, 27)
        Me.cmoComport.TabIndex = 145
        '
        'lblLogFileName
        '
        Me.lblLogFileName.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblLogFileName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLogFileName.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogFileName.Location = New System.Drawing.Point(103, 150)
        Me.lblLogFileName.Name = "lblLogFileName"
        Me.lblLogFileName.Size = New System.Drawing.Size(410, 41)
        Me.lblLogFileName.TabIndex = 144
        Me.lblLogFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCount
        '
        Me.lblCount.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCount.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.Location = New System.Drawing.Point(103, 120)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(107, 27)
        Me.lblCount.TabIndex = 143
        Me.lblCount.Text = "00"
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblData08
        '
        Me.lblData08.BackColor = System.Drawing.Color.Black
        Me.lblData08.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblData08.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData08.ForeColor = System.Drawing.Color.Red
        Me.lblData08.Location = New System.Drawing.Point(620, 5)
        Me.lblData08.Name = "lblData08"
        Me.lblData08.Size = New System.Drawing.Size(88, 27)
        Me.lblData08.TabIndex = 7
        Me.lblData08.Text = "00"
        Me.lblData08.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblData07
        '
        Me.lblData07.BackColor = System.Drawing.Color.Black
        Me.lblData07.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblData07.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData07.ForeColor = System.Drawing.Color.Red
        Me.lblData07.Location = New System.Drawing.Point(532, 5)
        Me.lblData07.Name = "lblData07"
        Me.lblData07.Size = New System.Drawing.Size(88, 27)
        Me.lblData07.TabIndex = 6
        Me.lblData07.Text = "00"
        Me.lblData07.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblData06
        '
        Me.lblData06.BackColor = System.Drawing.Color.Black
        Me.lblData06.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblData06.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData06.ForeColor = System.Drawing.Color.Red
        Me.lblData06.Location = New System.Drawing.Point(444, 5)
        Me.lblData06.Name = "lblData06"
        Me.lblData06.Size = New System.Drawing.Size(88, 27)
        Me.lblData06.TabIndex = 5
        Me.lblData06.Text = "00"
        Me.lblData06.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblData05
        '
        Me.lblData05.BackColor = System.Drawing.Color.Black
        Me.lblData05.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblData05.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData05.ForeColor = System.Drawing.Color.Red
        Me.lblData05.Location = New System.Drawing.Point(356, 5)
        Me.lblData05.Name = "lblData05"
        Me.lblData05.Size = New System.Drawing.Size(88, 27)
        Me.lblData05.TabIndex = 4
        Me.lblData05.Text = "00"
        Me.lblData05.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblData04
        '
        Me.lblData04.BackColor = System.Drawing.Color.Black
        Me.lblData04.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblData04.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData04.ForeColor = System.Drawing.Color.Red
        Me.lblData04.Location = New System.Drawing.Point(268, 5)
        Me.lblData04.Name = "lblData04"
        Me.lblData04.Size = New System.Drawing.Size(88, 27)
        Me.lblData04.TabIndex = 3
        Me.lblData04.Text = "00"
        Me.lblData04.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblData03
        '
        Me.lblData03.BackColor = System.Drawing.Color.Black
        Me.lblData03.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblData03.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData03.ForeColor = System.Drawing.Color.Red
        Me.lblData03.Location = New System.Drawing.Point(180, 5)
        Me.lblData03.Name = "lblData03"
        Me.lblData03.Size = New System.Drawing.Size(88, 27)
        Me.lblData03.TabIndex = 2
        Me.lblData03.Text = "00"
        Me.lblData03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblData02
        '
        Me.lblData02.BackColor = System.Drawing.Color.Black
        Me.lblData02.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblData02.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData02.ForeColor = System.Drawing.Color.Red
        Me.lblData02.Location = New System.Drawing.Point(92, 5)
        Me.lblData02.Name = "lblData02"
        Me.lblData02.Size = New System.Drawing.Size(88, 27)
        Me.lblData02.TabIndex = 1
        Me.lblData02.Text = "00"
        Me.lblData02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblData01
        '
        Me.lblData01.BackColor = System.Drawing.Color.Black
        Me.lblData01.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblData01.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData01.ForeColor = System.Drawing.Color.Red
        Me.lblData01.Location = New System.Drawing.Point(4, 5)
        Me.lblData01.Name = "lblData01"
        Me.lblData01.Size = New System.Drawing.Size(88, 27)
        Me.lblData01.TabIndex = 0
        Me.lblData01.Text = "00"
        Me.lblData01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLogStartTime
        '
        Me.lblLogStartTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblLogStartTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLogStartTime.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogStartTime.Location = New System.Drawing.Point(103, 91)
        Me.lblLogStartTime.Name = "lblLogStartTime"
        Me.lblLogStartTime.Size = New System.Drawing.Size(107, 27)
        Me.lblLogStartTime.TabIndex = 141
        Me.lblLogStartTime.Text = "00:00:00"
        Me.lblLogStartTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCurrentTime
        '
        Me.lblCurrentTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblCurrentTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCurrentTime.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentTime.Location = New System.Drawing.Point(103, 62)
        Me.lblCurrentTime.Name = "lblCurrentTime"
        Me.lblCurrentTime.Size = New System.Drawing.Size(107, 27)
        Me.lblCurrentTime.TabIndex = 142
        Me.lblCurrentTime.Text = "00:00:00"
        Me.lblCurrentTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 27)
        Me.Label3.TabIndex = 140
        Me.Label3.Text = "開始時間:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(441, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 27)
        Me.Label5.TabIndex = 138
        Me.Label5.Text = "使用者:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 27)
        Me.Label4.TabIndex = 139
        Me.Label4.Text = "記錄計數:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(232, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 27)
        Me.Label6.TabIndex = 136
        Me.Label6.Text = "記錄間隔(Sec):"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 27)
        Me.Label2.TabIndex = 137
        Me.Label2.Text = "現在時間:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(370, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 29)
        Me.Label1.TabIndex = 135
        Me.Label1.Text = "連接埠:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtListTitle
        '
        Me.txtListTitle.BackColor = System.Drawing.Color.AliceBlue
        Me.txtListTitle.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtListTitle.ForeColor = System.Drawing.Color.Black
        Me.txtListTitle.Location = New System.Drawing.Point(1, 197)
        Me.txtListTitle.Margin = New System.Windows.Forms.Padding(6)
        Me.txtListTitle.Name = "txtListTitle"
        Me.txtListTitle.Size = New System.Drawing.Size(713, 22)
        Me.txtListTitle.TabIndex = 134
        Me.txtListTitle.Text = "Title"
        '
        'txtStepTime
        '
        Me.txtStepTime.BackColor = System.Drawing.Color.White
        Me.txtStepTime.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtStepTime.ForeColor = System.Drawing.Color.Black
        Me.txtStepTime.Location = New System.Drawing.Point(236, 92)
        Me.txtStepTime.Margin = New System.Windows.Forms.Padding(6)
        Me.txtStepTime.Name = "txtStepTime"
        Me.txtStepTime.Size = New System.Drawing.Size(105, 27)
        Me.txtStepTime.TabIndex = 133
        Me.txtStepTime.Text = "1"
        Me.txtStepTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCloseComm
        '
        Me.btnCloseComm.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCloseComm.Location = New System.Drawing.Point(619, 105)
        Me.btnCloseComm.Margin = New System.Windows.Forms.Padding(6)
        Me.btnCloseComm.Name = "btnCloseComm"
        Me.btnCloseComm.Size = New System.Drawing.Size(93, 36)
        Me.btnCloseComm.TabIndex = 131
        Me.btnCloseComm.Text = "通訊停止"
        Me.btnCloseComm.UseVisualStyleBackColor = True
        '
        'btnOpenComm
        '
        Me.btnOpenComm.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenComm.Location = New System.Drawing.Point(618, 63)
        Me.btnOpenComm.Margin = New System.Windows.Forms.Padding(6)
        Me.btnOpenComm.Name = "btnOpenComm"
        Me.btnOpenComm.Size = New System.Drawing.Size(93, 36)
        Me.btnOpenComm.TabIndex = 132
        Me.btnOpenComm.Text = "通訊開啟"
        Me.btnOpenComm.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.LightPink
        Me.btnClose.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(518, 146)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(6)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(67, 45)
        Me.btnClose.TabIndex = 524
        Me.btnClose.Text = "關閉"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lblData16
        '
        Me.lblData16.BackColor = System.Drawing.Color.Black
        Me.lblData16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblData16.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData16.ForeColor = System.Drawing.Color.Red
        Me.lblData16.Location = New System.Drawing.Point(619, 32)
        Me.lblData16.Name = "lblData16"
        Me.lblData16.Size = New System.Drawing.Size(88, 27)
        Me.lblData16.TabIndex = 15
        Me.lblData16.Text = "00"
        Me.lblData16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblData15
        '
        Me.lblData15.BackColor = System.Drawing.Color.Black
        Me.lblData15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblData15.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData15.ForeColor = System.Drawing.Color.Red
        Me.lblData15.Location = New System.Drawing.Point(531, 32)
        Me.lblData15.Name = "lblData15"
        Me.lblData15.Size = New System.Drawing.Size(88, 27)
        Me.lblData15.TabIndex = 14
        Me.lblData15.Text = "00"
        Me.lblData15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblData14
        '
        Me.lblData14.BackColor = System.Drawing.Color.Black
        Me.lblData14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblData14.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData14.ForeColor = System.Drawing.Color.Red
        Me.lblData14.Location = New System.Drawing.Point(443, 32)
        Me.lblData14.Name = "lblData14"
        Me.lblData14.Size = New System.Drawing.Size(88, 27)
        Me.lblData14.TabIndex = 13
        Me.lblData14.Text = "00"
        Me.lblData14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblData13
        '
        Me.lblData13.BackColor = System.Drawing.Color.Black
        Me.lblData13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblData13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData13.ForeColor = System.Drawing.Color.Red
        Me.lblData13.Location = New System.Drawing.Point(355, 32)
        Me.lblData13.Name = "lblData13"
        Me.lblData13.Size = New System.Drawing.Size(88, 27)
        Me.lblData13.TabIndex = 12
        Me.lblData13.Text = "00"
        Me.lblData13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblData12
        '
        Me.lblData12.BackColor = System.Drawing.Color.Black
        Me.lblData12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblData12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData12.ForeColor = System.Drawing.Color.Red
        Me.lblData12.Location = New System.Drawing.Point(267, 32)
        Me.lblData12.Name = "lblData12"
        Me.lblData12.Size = New System.Drawing.Size(88, 27)
        Me.lblData12.TabIndex = 11
        Me.lblData12.Text = "00"
        Me.lblData12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblData11
        '
        Me.lblData11.BackColor = System.Drawing.Color.Black
        Me.lblData11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblData11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData11.ForeColor = System.Drawing.Color.Red
        Me.lblData11.Location = New System.Drawing.Point(179, 32)
        Me.lblData11.Name = "lblData11"
        Me.lblData11.Size = New System.Drawing.Size(88, 27)
        Me.lblData11.TabIndex = 10
        Me.lblData11.Text = "00"
        Me.lblData11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblData10
        '
        Me.lblData10.BackColor = System.Drawing.Color.Black
        Me.lblData10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblData10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData10.ForeColor = System.Drawing.Color.Red
        Me.lblData10.Location = New System.Drawing.Point(91, 32)
        Me.lblData10.Name = "lblData10"
        Me.lblData10.Size = New System.Drawing.Size(88, 27)
        Me.lblData10.TabIndex = 9
        Me.lblData10.Text = "00"
        Me.lblData10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblData09
        '
        Me.lblData09.BackColor = System.Drawing.Color.Black
        Me.lblData09.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblData09.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData09.ForeColor = System.Drawing.Color.Red
        Me.lblData09.Location = New System.Drawing.Point(3, 32)
        Me.lblData09.Name = "lblData09"
        Me.lblData09.Size = New System.Drawing.Size(88, 27)
        Me.lblData09.TabIndex = 8
        Me.lblData09.Text = "00"
        Me.lblData09.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtListTitle2
        '
        Me.txtListTitle2.BackColor = System.Drawing.Color.AliceBlue
        Me.txtListTitle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtListTitle2.ForeColor = System.Drawing.Color.Black
        Me.txtListTitle2.Location = New System.Drawing.Point(2, 222)
        Me.txtListTitle2.Margin = New System.Windows.Forms.Padding(6)
        Me.txtListTitle2.Name = "txtListTitle2"
        Me.txtListTitle2.Size = New System.Drawing.Size(713, 22)
        Me.txtListTitle2.TabIndex = 533
        Me.txtListTitle2.Text = "Title2"
        '
        'ControlADAM4018_Modbus
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.txtListTitle2)
        Me.Controls.Add(Me.lblData16)
        Me.Controls.Add(Me.lblData15)
        Me.Controls.Add(Me.lblData14)
        Me.Controls.Add(Me.lblData13)
        Me.Controls.Add(Me.lblData12)
        Me.Controls.Add(Me.lblData11)
        Me.Controls.Add(Me.lblData10)
        Me.Controls.Add(Me.lblData09)
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
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtListTitle)
        Me.Controls.Add(Me.txtStepTime)
        Me.Controls.Add(Me.btnCloseComm)
        Me.Controls.Add(Me.btnOpenComm)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "ControlADAM4018_Modbus"
        Me.Size = New System.Drawing.Size(721, 689)
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtListTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtStepTime As System.Windows.Forms.TextBox
    Friend WithEvents btnCloseComm As System.Windows.Forms.Button
    Friend WithEvents btnOpenComm As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblData16 As System.Windows.Forms.Label
    Friend WithEvents lblData15 As System.Windows.Forms.Label
    Friend WithEvents lblData14 As System.Windows.Forms.Label
    Friend WithEvents lblData13 As System.Windows.Forms.Label
    Friend WithEvents lblData12 As System.Windows.Forms.Label
    Friend WithEvents lblData11 As System.Windows.Forms.Label
    Friend WithEvents lblData10 As System.Windows.Forms.Label
    Friend WithEvents lblData09 As System.Windows.Forms.Label
    Friend WithEvents txtListTitle2 As System.Windows.Forms.TextBox

End Class

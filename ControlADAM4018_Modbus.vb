Public Class ControlADAM4018_Modbus
    Public Adam4018 As Adam4018_Class

    Public TempGain(99) As Double
    Public TempOffset(99) As Double

    Public SeriesName(99) As String
    Public StartLog As Boolean
    Public Comport As Integer
    Public StepTime As Integer
    Public LogCount As Long
    Public CountTimer As Long
    Public CurveCount As Integer
    Public CurrentUser As String

    Public firstFalg As Boolean
    Public LogDir, LogFileName As String
    Public UserList(99) As String

    Public TimerCount As Long
    Public lblData(99) As Label
    Public chkChanel(99) As CheckBox
    Public Timer1 As Timer
    Public FFile As String
    Public fs As System.IO.FileStream
    Public sw As System.IO.StreamWriter

    Class Adam4018_Class

        Public CommLive As Boolean
        Public Modbus As CModbus
        Sub New()
            Modbus = New CModbus
        End Sub

        Public Sub Initial(ByVal comm As Integer, ByVal Addr As Integer, ByVal iTime As Integer)
            'If Addr = 0 Then Addr = 1

        End Sub


        Public Sub OpenComm()
            Try
                If Modbus.ModbusComm.IsOpen() = False Then
                    Modbus.ModbusComm.Open()
                    Modbus.ReadADAM4018P(1)
                    CommLive = True
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub
        Public Sub CloseComm()
            Try
                If Modbus.ModbusComm.IsOpen() = True Then
                    CommLive = False
                    Modbus.ModbusComm.BreakState = True
                    Modbus.ModbusComm.DiscardInBuffer()
                    Modbus.ModbusComm.DiscardOutBuffer()
                    Modbus.ModbusComm.BreakState = False
                    Modbus.ModbusComm.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub
        Public Sub ReOpenComm(ByVal port As Integer)
            Try
                CloseComm()
                Modbus.ModbusComm.PortName = "COM" + port.ToString
                OpenComm()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub
        Public Function IsOpen()
            Return Modbus.ModbusComm.IsOpen
        End Function

        Public Function GetADValue(ByVal iCH As Integer) As Single
            Return Modbus.AdamTemp(iCH)
        End Function
        Public Function GetADValue(ByRef iArray() As Single) As Single
            Dim i As Integer
            For i = 0 To 7
                iArray(i) = Modbus.AdamTemp(i)
            Next
        End Function
    End Class
    Public Class CModbus


        Public AdamData(99) As Double
        Public AdamTemp(99) As Double
        Public Address As Integer
        Public ModbusWatchdog As Byte
        Public ModbusCommLive As Boolean
        Public ModbusSendComm(50) As Byte
        Public ModbusReadData(50) As Byte

        Public ModBusControl_State As Byte
        Public ModbusSetInputDataByteNumber As Byte
        Public ModbusTureInputDataByteNumber As Byte
        Public ModbusReadDataValue(20) As Integer
        Public ModbusSetTail As Byte
        Public ModbusSetHead As Byte
        Public Const ModbusSetMaxBufferNumber = 36
        Public ModbusSetBuffer(36, 7) As Byte
        Public ENDC_Connect As Boolean
        Public ModbusLiveErrDelayTimer As Integer
        Public ModbusLiveErrDelayTimerEnabled As Boolean
        Public ModbusLinkLiveErr_Status As Boolean

        Public ModbusLink_Value As Byte

        Public ModbusComm As IO.Ports.SerialPort
        Public WatchDogTimer As Timer
        Sub New()
            ModbusComm = New IO.Ports.SerialPort
            WatchDogTimer = New Timer
            Dim i As Integer
            For i = 0 To 15
                AdamData(i) = 65535
                AdamTemp(i) = Math.Round(1370 * (AdamData(i) / 65535), 1)
            Next
        End Sub
        Public Sub ModbusCommSetting(ByVal iComm As Integer, ByVal Settings As String)
            If iComm <= 0 Then iComm = 1
            ModbusComm.PortName = "COM" + iComm.ToString
            Dim comset() As String
            comset = Split(Settings, ",")
            If CInt(comset(0)) > 0 Then
                ModbusComm.BaudRate = CInt(comset(0))
            Else
                ModbusComm.BaudRate = 9600
            End If
            Dim ii As Integer
            ModbusComm.Parity = IO.Ports.Parity.None
            If comset(1).ToUpper = "N" Then ii = IO.Ports.Parity.None
            If comset(1).ToUpper = "E" Then ii = IO.Ports.Parity.Even
            If comset(1).ToUpper = "O" Then ii = IO.Ports.Parity.Odd
            ModbusComm.Parity = ii
            ModbusComm.DataBits = CInt(comset(2))
            ModbusComm.StopBits = CInt(comset(3))
            ModbusComm.RtsEnable = True
            ModbusComm.DtrEnable = True
            ModbusComm.ReceivedBytesThreshold = 1
            ModbusComm.Handshake = IO.Ports.Handshake.None

            AddHandler ModbusComm.DataReceived, AddressOf ModbusCommDataReceived
            'ModbusComm.Open()


            AddHandler WatchDogTimer.Tick, AddressOf RestartModbus
            WatchDogTimer.Interval = 100
            WatchDogTimer.Enabled = True


            'ReadADAM4018P(1)
            ModbusWatchdog = 2
        End Sub


        Public Sub ReadADAM4018P(ByVal addr As Byte)
            Address = addr
            'Read ADDR1 #1~8 Temp.
            ModbusSendComm(0) = addr
            ModbusSendComm(1) = &H3
            ModbusSendComm(2) = &H0
            ModbusSendComm(3) = &H0
            ModbusSendComm(4) = &H0
            ModbusSendComm(5) = &H8
            Dim Crc16_Value As Integer = Cal_Crc16(6, ModbusSendComm)
            Dim a1 As Byte
            Dim a2 As Byte
            a1 = Crc16_Value \ 256
            a2 = Crc16_Value Mod 256
            ModbusSendComm(6) = a2
            ModbusSendComm(7) = a1
            ModbusSetInputDataByteNumber = 5 + ModbusSendComm(5) * 2
            ModbusTureInputDataByteNumber = 0
            ReDim ModbusReadData(50)
            If ModbusComm.IsOpen Then ModbusComm.Write(ModbusSendComm, 0, 8)
        End Sub
        Public Function CombineData(ByVal Hibyte As Byte, ByVal lowbyte As Byte)
            Return Hibyte * 256 + lowbyte
        End Function

        Public Sub ModbusCommDataReceived()
            Dim i As Integer            ' Step control of received string
            Dim cnt As Integer      ' Recording the length of received string
            Dim rx_Variant() As Byte
            Dim rx_Byte As Byte
            Dim SetData(7) As Byte
            Dim DelayCount As Integer
            Dim ab1 As Integer
            Dim ac1 As Integer
            Dim a1 As Integer
            Dim a2 As Integer

            ac1 = 1000000
            If ModbusComm.BytesToRead < 1 Then
                Exit Sub
            End If
            ReDim rx_Variant(100)
            cnt = ModbusComm.BytesToRead
            ModbusComm.Read(rx_Variant, 0, cnt)
            For i = 0 To cnt - 1
                rx_Byte = rx_Variant(i)
                ModbusTureInputDataByteNumber += 1
                ModbusReadData(ModbusTureInputDataByteNumber - 1) = rx_Byte
            Next
            If ModbusTureInputDataByteNumber = ModbusSetInputDataByteNumber Then
                Dim Crc16_Value As Integer = Cal_Crc16(ModbusSetInputDataByteNumber - 2, ModbusReadData)
                a1 = Crc16_Value \ 256
                a2 = Crc16_Value Mod 256
                If a1 = ModbusReadData(ModbusSetInputDataByteNumber - 1) And a2 = ModbusReadData(ModbusSetInputDataByteNumber - 2) Then
                    Select Case ModBusControl_State
                        Case 0 '0
                            If ModbusLink_Value < 100 Then
                                ModbusLink_Value = 30
                            End If
                            'temp1 pv
                            ModbusWatchdog = 3
                            For i = 0 To 7
                                AdamData(i) = 65535
                                AdamTemp(i) = Math.Round(1370 * (AdamData(i) / 65535), 1)
                            Next
                            If ModbusReadData(0) = 1 Then
                                For i = 0 To 7
                                    AdamData(i) = CombineData(ModbusReadData(3 + i * 2), ModbusReadData(4 + i * 2))
                                    AdamTemp(i) = Math.Round(1370 * (AdamData(i) / 65535), 1)
                                Next
                            End If
                            System.Threading.Thread.Sleep(20)
                            'ReadADAM4018P(1)
                            ReadADAM4018P(2)
                            ModBusControl_State = 1
                        Case 1 '1
                            If ModbusLink_Value < 100 Then
                                ModbusLink_Value = 40
                            End If
                            'temp1 at pid
                            ModbusWatchdog = 3
                            For i = 0 To 7
                                AdamData(8 + i) = 65535
                                AdamTemp(8 + i) = Math.Round(1370 * (AdamData(8 + i) / 65535), 1)
                            Next
                            If ModbusReadData(0) = 2 Then
                                For i = 0 To 7
                                    AdamData(8 + i) = CombineData(ModbusReadData(3 + i * 2), ModbusReadData(4 + i * 2))
                                    AdamTemp(8 + i) = Math.Round(1370 * (AdamData(8 + i) / 65535), 1)
                                Next
                            End If

                            For DelayCount = 0 To ac1
                                ab1 += 1
                            Next
                            System.Threading.Thread.Sleep(20)
                            ReadADAM4018P(1)
                            ModBusControl_State = 0
                    End Select
                End If
            End If


        End Sub

        Public Function Cal_Crc16(ByVal BufLen As Byte, ByVal data() As Byte)
            Dim Cur_crc_Value As Integer
            Dim i As Byte
            Dim j As Byte
            Cur_crc_Value = &HFFFF

            For i = 0 To BufLen - 1
                Cur_crc_Value = Cur_crc_Value Xor data(i)
                For j = 0 To 7
                    If Cur_crc_Value And &H1 Then
                        Cur_crc_Value = Cur_crc_Value >> 1
                        Cur_crc_Value = Cur_crc_Value Xor &HA001
                    Else
                        Cur_crc_Value = Cur_crc_Value >> 1
                    End If
                Next
            Next
            Return Cur_crc_Value
        End Function

        Public Sub RestartModbus()
            If ModbusComm.IsOpen Then
                ModbusWatchdog = ModbusWatchdog - 1
                If ModbusWatchdog = 0 Then
                    ModbusWatchdog = 2
                    ModbusCommLive = False
                    If Address = 1 Then
                        ReadADAM4018P(2)
                        ModBusControl_State = 1
                    Else
                        ReadADAM4018P(1)
                        ModBusControl_State = 0
                    End If
                End If
            End If
            'ModbusCommLive = False
            'ModbusLink_Value = 0
            'ModbusWatchdog = 3
            'ReadADAM4018P(1)
            'ModBusControl_State = 0
        End Sub
    End Class



  
    '-----------------------------------------------------------------------End 
    '寫入多筆資料以TAB 隔開, 並在最後端換行,檔案不存在會自動建立
    Public Sub AppendMultiData(ByVal sfile As String, ByVal DataLen As Integer, ByVal ParamArray sstr() As Object)
        Dim i As Integer
        On Error Resume Next
        fs = New System.IO.FileStream(sfile, System.IO.FileMode.Append)
        sw = New System.IO.StreamWriter(fs, System.Text.Encoding.Unicode)
        If sstr.Length < 0 Then Exit Sub
        For i = 0 To sstr.Length - 1
            sw.Write(sstr(i) + vbTab)
        Next
        sw.WriteLine()
        sw.Close()
    End Sub


    Sub New()

        ' 此為 Windows Form 設計工具所需的呼叫。
        InitializeComponent()

        ' 在 InitializeComponent() 呼叫之後加入任何初始設定。

    End Sub

    Private Sub ControlADAM4018_Modbus_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Adam4018.Modbus.ModbusComm.Close()
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ii As Integer
        MakeDateData()
        ReadProgramIni()
        For ii = 0 To 31
            cmoComport.Items.Add("COM" + Format(ii + 1))
        Next
        If Comport <= 0 Then
            Comport = 2
        End If
        If Comport > 0 Then cmoComport.SelectedIndex = Comport - 1

        Adam4018 = New Adam4018_Class
        Adam4018.Initial(Comport, 0, 100)

        lblCurrentTime.Text = TTime



        lblData(0) = lblData01
        lblData(1) = lblData02
        lblData(2) = lblData03
        lblData(3) = lblData04
        lblData(4) = lblData05
        lblData(5) = lblData06
        lblData(6) = lblData07
        lblData(7) = lblData08
        lblData(8) = lblData09
        lblData(9) = lblData10
        lblData(10) = lblData11
        lblData(11) = lblData12
        lblData(12) = lblData13
        lblData(13) = lblData14
        lblData(14) = lblData15
        lblData(15) = lblData16

        'chkChanel(0) = FormCurve.CheckBox1
        'chkChanel(1) = FormCurve.CheckBox2
        'chkChanel(2) = FormCurve.CheckBox3
        'chkChanel(3) = FormCurve.CheckBox4
        'chkChanel(4) = FormCurve.CheckBox5
        'chkChanel(5) = FormCurve.CheckBox6
        'chkChanel(6) = FormCurve.CheckBox7
        'chkChanel(7) = FormCurve.CheckBox8
        'chkChanel(8) = FormCurve.CheckBox9
        'chkChanel(9) = FormCurve.CheckBox10
        'chkChanel(10) = FormCurve.CheckBox11
        'chkChanel(11) = FormCurve.CheckBox12
        'chkChanel(12) = FormCurve.CheckBox13
        'chkChanel(13) = FormCurve.CheckBox14
        'chkChanel(14) = FormCurve.CheckBox15
        'chkChanel(15) = FormCurve.CheckBox16


        'UserList(0) = "Leo"
        'UserList(1) = "HCC"
        'UserList(2) = "Vincent"
        'UserList(3) = "Joe"
        'UserList(4) = "User5"
        'UserList(5) = "User6"
        'UserList(6) = "User7"
        'UserList(7) = "User8"
        'UserList(8) = "User9"

        For ii = 0 To 15
            cmoUserName.Items.Add(UserList(ii))
            'chkChanel(ii).Text = SeriesName(ii)

        Next
        cmoUserName.SelectedIndex = 0
        CurrentUser = cmoUserName.SelectedItem
   

        LogDir = CurDir()

        Timer1 = New Timer
        AddHandler Timer1.Tick, AddressOf DataLogging

        Timer1.Interval = 300
        Timer1.Enabled = True

        firstFalg = True
    End Sub
    Public Sub ReadProgramIni()
        Dim sfile As String = CurDir() & "\PROGRAM.INI"
        Dim i As Integer
        Comport = Val(ReadProgData("Communication", "Comport", "1", sfile))
        For i = 0 To 15
            TempGain(i) = Val(ReadProgData("Calibration", "Gain" & Format(i + 1, "00"), "1.0", sfile))
            TempOffset(i) = Val(ReadProgData("Calibration", "Offset" & Format(i + 1, "00"), "0.0", sfile))
            UserList(i) = ReadProgData("Calibration", "Gain" & Format(i + 1, "00"), "Nobody", sfile)
            SeriesName(i) = ReadProgData("SeriesName", "Series" & Format(i + 1, "00"), Format(i + 1, "CH00"), sfile)
        Next
        For i = 0 To 15

        Next
        WriteProgramIni()
    End Sub

    Public Sub WriteProgramIni()
        Dim sfile As String = CurDir() & "\PROGRAM.INI"
        Dim i As Integer
        WriteProgData("Communication", "Comport", Comport.ToString, sfile)
        For i = 0 To 15
            WriteProgData("Calibration", "Gain" & Format(i + 1, "00"), TempGain(i).ToString, sfile)
            WriteProgData("Calibration", "Offset" & Format(i + 1, "00"), TempOffset(i).ToString, sfile)
            WriteProgData("UserList", "User" & Format(i + 1, "00"), UserList(i), sfile)
            WriteProgData("SeriesName", "Series" & Format(i + 1, "00"), SeriesName(i), sfile)
        Next
        For i = 0 To 15

        Next
    End Sub
   
    Private Sub btnStartLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartLog.Click
        Dim rtl As MsgBoxResult
        Dim i As Integer
        Dim astr As String = ""
        Dim astr1 As String = ""
        Dim sstr As String = ""
        Dim sstr1 As String = ""
        If StartLog Then
            rtl = MsgBox("中止記錄?", MsgBoxStyle.YesNo)
            If rtl = MsgBoxResult.No Then
                Exit Sub
            End If
        End If
        If Adam4018.CommLive = False Then
            MsgBox("通訊異常,不能記錄!")
            Exit Sub
        End If
        StartLog = Not StartLog
        If StartLog Then
            btnOpenComm.Enabled = False
            btnCloseComm.Enabled = False
            cmoComport.Enabled = False
        Else
            btnOpenComm.Enabled = True
            btnCloseComm.Enabled = True
            cmoComport.Enabled = True
        End If

        If StartLog Then
            TimerCount = 0
            LogCount = 0
            lstLogList.Items.Clear()
            If Val(txtStepTime.Text) < 1 Then
                txtStepTime.Text = "1"
            End If
            StepTime = Val(txtStepTime.Text)
            MakeDateData()
            lblLogStartTime.Text = TTime
            CurrentUser = cmoUserName.SelectedItem
            LogDir = CurDir() + "\" + CurrentUser + "_" + NYear + "_" + NMonth + "_" + NDate + "\"
            If FileIO.FileSystem.DirectoryExists(LogDir) = False Then
                FileIO.FileSystem.CreateDirectory(LogDir)
            End If
            LogFileName = CurrentUser + "-" + FDate + FTime + ".csv"
            FFile = LogDir + LogFileName
            lblLogFileName.Text = FFile
            For i = 0 To 7
                'sstr = sstr + Chart1.Series(i).Name + vbTab
                sstr = sstr + SeriesName(i) + vbTab
            Next
            txtListTitle.Text = "序號" + vbTab + "時間" + vbTab + vbTab + sstr
         
            For i = 8 To 15
                'sstr1 = sstr1 + Chart1.Series(i).Name + vbTab
                sstr1 = sstr1 + SeriesName(i) + vbTab
            Next
            txtListTitle2.Text = "    " + vbTab + "    " + vbTab + vbTab + sstr1

            Dim aa As String = ""
            For i = 0 To 15
                aa = aa + SeriesName(i) + vbTab
            Next
            AppendMultiData(FFile, 80, "序號", "時間", vbTab, aa)

            TimerCount = Now().Second
            LogCount = LogCount + 1
            lblCount.Text = LogCount.ToString
            astr = Format(LogCount, "00000") + vbTab + TTime + vbTab + vbTab
            For i = 0 To 7
                astr = astr + lblData(i).Text + vbTab
                'FormCurve.Chart1.Series(i).Points.Clear()
            Next
            astr1 = "     " + vbTab + TTime + vbTab + vbTab
            For i = 8 To 15
                astr1 = astr1 + lblData(i).Text + vbTab
                'FormCurve.Chart1.Series(i).Points.Clear()
            Next
            lstLogList.Items.Add(astr)
            lstLogList.Items.Add(astr1)

            Dim bb As String = Format(LogCount, "00000") + vbTab + TTime + vbTab + vbTab
            For i = 0 To 15
                bb = bb + lblData(i).Text + vbTab
            Next
            AppendMultiData(FFile, 80, bb)

            CountTimer = 0
        End If
    End Sub

    Private Sub btnOpenComm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenComm.Click
        On Error Resume Next
        Comport = cmoComport.SelectedIndex + 1
        'Adam4018.Modbus.ModbusComm.PortName = "COM" + Comport.ToString
        Adam4018.Modbus.ModbusCommSetting(Comport, "9600,N,8,1")
        Adam4018.OpenComm()
        WriteProgramIni()
    End Sub

    Private Sub btnCloseComm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseComm.Click
        Adam4018.CloseComm()
    End Sub

    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Adam4018.IsOpen Then
            Adam4018.CloseComm()
        End If
        WriteProgramIni()
        Me.Dispose()
        End
    End Sub

    Public Function GetCalTemp(ByVal ch As Integer)
        Dim caltemp As Double
        caltemp = Adam4018.GetADValue(ch) * TempGain(ch) + TempOffset(ch)
        Return caltemp
    End Function


    Private Sub DataLogging()
        Dim astr As String = ""
        Dim astr1 As String = ""
        Dim i As Integer
        Dim curSec As Long
        Static OldTime As Long

        On Error Resume Next
        MakeDateData()


        'If FormCurve.Visible Then
        '    btnCurveForm.BackColor = Color.Lime
        'Else
        '    btnCurveForm.BackColor = System.Drawing.SystemColors.Control

        'End If
        If Adam4018.CommLive Then
            btnOpenComm.BackColor = Color.Lime
            btnOpenComm.Enabled = False
            cmoComport.Enabled = False
        Else
            btnOpenComm.BackColor = System.Drawing.SystemColors.Control
            btnOpenComm.Enabled = True
            cmoComport.Enabled = True
        End If
        If StartLog Then
            btnStartLog.BackColor = Color.Lime
        Else
            btnStartLog.BackColor = Color.FromArgb(255, 255, 192)
        End If

   
        If OldTime <> Now().Second Then
            lblCurrentTime.Text = TTime
            For i = 0 To 15
                If Adam4018.CommLive = False Then
                    lblData(i).Text = "--.-"
                Else
                    If Adam4018.GetADValue(i) < 1000 Then
                        'lblData(i).Text = Format(Adam4018.GetADValue(i), "0.0")
                        lblData(i).Text = Format(GetCalTemp(i), "0.0")

                    Else
                        lblData(i).Text = "--.-"
                    End If
                    'Chart1.Series(i).Points.AddY(Adam4018.GetADValue(i))
                    'FormCurve.Chart1.Series(i).Points.AddY(GetCalTemp(i))
                    'If CurveCount < (FormCurve.Chart1.ChartAreas(0).AxisX.Maximum - 10) Then
                    '    CurveCount += 1
                    'Else
                    '    FormCurve.Chart1.Series(i).Points.RemoveAt(0)
                    'End If
                End If
            Next
            If StartLog Then
                CountTimer += 1
                If CountTimer >= StepTime Then
                    CountTimer = 0
                    'MakeDateData()
                    LogCount = LogCount + 1
                    lblCount.Text = LogCount.ToString
                    astr = Format(LogCount, "00000") + vbTab + TTime + vbTab + vbTab
                    For i = 0 To 7
                        astr = astr + lblData(i).Text + vbTab
                    Next
                    astr1 = "     " + vbTab + TTime + vbTab + vbTab
                    For i = 8 To 15
                        astr1 = astr1 + lblData(i).Text + vbTab
                    Next
                    lstLogList.Items.Add(astr)
                    lstLogList.Items.Add(astr1)
                    Dim bb As String = Format(LogCount, "00000") + vbTab + TTime + vbTab + vbTab
                    For i = 0 To 15
                        bb = bb + lblData(i).Text + vbTab
                    Next
                    AppendMultiData(FFile, 80, bb)

                    'AppendMultiData(FFile, 80, astr)
                    'AppendMultiData(FFile, 80, astr1)
                    lstLogList.SelectedIndex = lstLogList.Items.Count - 1
                    If LogCount > 12 Then
                        lstLogList.Items.RemoveAt(0)
                        lstLogList.Items.RemoveAt(0)
                    End If
                End If
            End If
            OldTime = Now().Second
        End If


    End Sub

    Private Sub btnOpenFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblLogFileName.Click
        Shell("notepad.exe " + FFile, AppWinStyle.NormalFocus)
    End Sub

    Private Sub lblLogFileName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenFile.Click
        Shell("explorer.exe " + LogDir + ",/e", AppWinStyle.NormalFocus)
    End Sub
    Private Sub btnAdd1000_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd1000.Click
        If Val(txtStepTime.Text) < 999 Then
            txtStepTime.Text = (Val(txtStepTime.Text) + 1).ToString
        End If

    End Sub
    Private Sub btnSub1000_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSub1000.Click
        If Val(txtStepTime.Text) > 1 Then
            txtStepTime.Text = (Val(txtStepTime.Text) - 1).ToString
        End If
    End Sub

    Private Sub btnCurveForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCurveForm.Click
        'FormCurve.Show()
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Adam4018.Modbus.ModbusComm.Close()
        End
    End Sub

  
    Private Sub lblData01_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
    lblData01.Click, lblData02.Click, lblData03.Click, lblData04.Click, _
    lblData05.Click, lblData06.Click, lblData07.Click, lblData08.Click, _
    lblData09.Click, lblData10.Click, lblData11.Click, lblData12.Click, _
    lblData13.Click, lblData14.Click, lblData15.Click, lblData16.Click

     

    End Sub

    Private Sub lblData01_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles _
        lblData01.MouseClick, lblData02.MouseClick, lblData03.MouseClick, lblData04.MouseClick, _
        lblData05.MouseClick, lblData06.MouseClick, lblData07.MouseClick, lblData08.MouseClick, _
        lblData09.MouseClick, lblData10.MouseClick, lblData11.MouseClick, lblData12.MouseClick, _
        lblData13.MouseClick, lblData14.MouseClick, lblData15.MouseClick, lblData16.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            'Dim aa As New FormTempCal
            'aa.LoadData(sender.TabIndex)

            'FormCurve.Chart1.Series(sender.TabIndex).LegendText = SeriesName(sender.TabIndex)
            chkChanel(sender.TabIndex).Text = SeriesName(sender.TabIndex)
            Dim sstr As String = ""
            Dim i As Integer
            For i = 0 To 7
                'sstr = sstr + Chart1.Series(i).Name + vbTab
                sstr = sstr + SeriesName(i) + vbTab
            Next
            txtListTitle.Text = "序號" + vbTab + "時間" + vbTab + vbTab + sstr
            sstr = ""
            For i = 8 To 15
                'sstr1 = sstr1 + Chart1.Series(i).Name + vbTab
                sstr = sstr + SeriesName(i) + vbTab
            Next
            txtListTitle2.Text = "    " + vbTab + "    " + vbTab + vbTab + sstr
            WriteProgramIni()
        End If
        'If e.Button = Windows.Forms.MouseButtons.Right Then
        '    Dim aa As New FormEnterName
        '    aa.LoadData(sender.TabIndex)
        '    Chart1.Series(sender.TabIndex).LegendText = SeriesName(sender.TabIndex)
        'End If
    End Sub
End Class

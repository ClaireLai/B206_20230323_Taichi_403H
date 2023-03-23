Public Class ControlADAM4118

  

    Public Adam4018 As Adam4018_Class

    Class Adam4018_Class
        Enum Input_AD_Type
            TempC = 15
        End Enum
        Public RSCOMM As New IO.Ports.SerialPort

        Private AD_Input(32)
        Private CommPort As Integer
        Private iAddr As Integer
        Private iTimer As Integer
        Private WatchDogTimer As New Timer
        Private WatchDogTimeSet As Integer
        Private WatchDogTimeCount As Integer
        Private Control_State As Integer
        Private rx_Str As String
        Private rx_Buf As String
        Public CommLive As Boolean
        Sub New()

        End Sub

        Public Sub Initial(ByVal comm As Integer, ByVal Addr As Integer, ByVal iTime As Integer)
            '            If Addr = 0 Then Addr = 1
            CommPort = comm
            iAddr = Addr
            iTimer = iTime
            RSCOMM.PortName = "COM" + CommPort.ToString
            RSCOMM.Parity = IO.Ports.Parity.None
            RSCOMM.DataBits = 8
            RSCOMM.BaudRate = 9600
            RSCOMM.StopBits = IO.Ports.StopBits.One
            RSCOMM.WriteTimeout = iTime
            RSCOMM.ReceivedBytesThreshold = 1
            rx_Str = ""
            rx_Buf = ""
            WatchDogTimer.Interval = 1000
            WatchDogTimer.Enabled = True
            AddHandler WatchDogTimer.Tick, AddressOf WatchDog
            WatchDogTimeSet = 5

            AddHandler RSCOMM.DataReceived, AddressOf On_Comm

            CommLive = False
        End Sub

        Private Sub WatchDog()
            On Error Resume Next
            If RSCOMM.IsOpen Then
                WatchDogTimeCount -= 1
                If WatchDogTimeCount <= 0 Then
                    WatchDogTimeCount = WatchDogTimeSet
                    CommLive = False
                    CloseComm()
                    OpenComm()
                    If RSCOMM.IsOpen Then
                        'RSCOMM.Write("$" + Format(iAddr, "00") + "2" + vbCr)
                        WatchDogTimeSet = 5
                    End If
                    Control_State = 0
                End If
            End If
        End Sub
        Private Sub On_Comm()

            On Error Resume Next
            rx_Buf = rx_Buf + RSCOMM.ReadExisting
            If InStr(rx_Buf, Chr(13)) Then
                Select Case Control_State
                    Case 0
                        rx_Buf = ""
                        System.Threading.Thread.Sleep(500)
                        RSCOMM.Write("$" + Format(iAddr, "00") + "6" + vbCr)
                        WatchDogTimeCount = WatchDogTimeSet
                        Control_State = 11
                    Case 1
                        rx_Buf = ""
                        RSCOMM.Write("$" + Format(iAddr, "00") + "7C0R0F" + vbCr)
                        System.Threading.Thread.Sleep(500)
                        WatchDogTimeCount = WatchDogTimeSet
                        Control_State = 2
                    Case 2
                        rx_Buf = ""
                        RSCOMM.Write("$" + Format(iAddr, "00") + "7C1R0F" + vbCr)
                        System.Threading.Thread.Sleep(500)
                        WatchDogTimeCount = WatchDogTimeSet
                        Control_State = 3
                    Case 3
                        rx_Buf = ""
                        RSCOMM.Write("$" + Format(iAddr, "00") + "7C2R0F" + vbCr)
                        System.Threading.Thread.Sleep(500)
                        WatchDogTimeCount = WatchDogTimeSet
                        Control_State = 4
                    Case 4
                        rx_Buf = ""
                        RSCOMM.Write("$" + Format(iAddr, "00") + "7C3R0F" + vbCr)
                        System.Threading.Thread.Sleep(500)
                        WatchDogTimeCount = WatchDogTimeSet
                        Control_State = 5
                    Case 5
                        rx_Buf = ""
                        RSCOMM.Write("$" + Format(iAddr, "00") + "7C4R0F" + vbCr)
                        System.Threading.Thread.Sleep(500)
                        WatchDogTimeCount = WatchDogTimeSet
                        Control_State = 6
                    Case 6
                        rx_Buf = ""
                        RSCOMM.Write("$" + Format(iAddr, "00") + "7C5R0F" + vbCr)
                        System.Threading.Thread.Sleep(500)
                        WatchDogTimeCount = WatchDogTimeSet
                        Control_State = 7
                    Case 7
                        rx_Buf = ""
                        RSCOMM.Write("$" + Format(iAddr, "00") + "7C6R0F" + vbCr)
                        System.Threading.Thread.Sleep(500)
                        WatchDogTimeCount = WatchDogTimeSet
                        Control_State = 8
                    Case 8
                        rx_Buf = ""
                        RSCOMM.Write("$" + Format(iAddr, "00") + "7C7R0F" + vbCr)
                        System.Threading.Thread.Sleep(500)
                        WatchDogTimeCount = WatchDogTimeSet
                        Control_State = 9
                    Case 9
                        rx_Buf = ""
                        RSCOMM.Write("$" + Format(iAddr, "00") + "6" + vbCr)
                        System.Threading.Thread.Sleep(500)
                        WatchDogTimeCount = WatchDogTimeSet
                        Control_State = 10
                    Case 10
                        rx_Buf = ""
                        RSCOMM.Write("#" + Format(iAddr, "00") + vbCr)
                        System.Threading.Thread.Sleep(500)
                        WatchDogTimeCount = WatchDogTimeSet
                        Control_State = 11
                    Case 11
                        rx_Str = rx_Buf
                        Refresh(rx_Str)
                        rx_Str = ""
                        rx_Buf = ""
                        System.Threading.Thread.Sleep(500)
                        RSCOMM.Write("#" + Format(iAddr, "00") + vbCr)
                        WatchDogTimeCount = WatchDogTimeSet

                        CommLive = True
                        Control_State = 11
                End Select
            End If

        End Sub

        Public Sub OpenComm()
            Try
                If RSCOMM.IsOpen() = False Then
                    RSCOMM.Open()
                    If RSCOMM.IsOpen Then
                        RSCOMM.Write("$0015FF" + vbCr)
                        System.Threading.Thread.Sleep(200)
                        RSCOMM.Write("#" + Format(iAddr, "00") + vbCr)
                    End If
                End If
            Catch ex As Exception
                'MsgBox(ex.Message)
            End Try
        End Sub
        Public Sub CloseComm()
            Try
                If RSCOMM.IsOpen() = True Then
                    CommLive = False
                    RSCOMM.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub
        Public Sub ReOpenComm(ByVal port As Integer)
            Try
                CloseComm()
                RSCOMM.PortName = "COM" + port.ToString
                OpenComm()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub
        Public Function IsOpen()
            Return RSCOMM.IsOpen
        End Function

        Public Function GetADValue(ByVal iCH As Integer) As Single
            Return AD_Input(iCH)
        End Function
        Public Function GetADValue(ByRef iArray() As Single) As Single
            Dim i As Integer
            For i = 0 To 7
                iArray(i) = AD_Input(i)
            Next
        End Function
        Private Sub Refresh(ByVal sstr As String)
            Dim i, st, ed As Integer
            Dim buf(7) As Single
            On Error Resume Next
            Dim astr, bstr As String
            st = InStr(sstr, ">")
            If st = 0 Then
                st = InStr(sstr, "!")
            End If
            If st >= 0 Then
                ed = InStr(sstr, Chr(13))
                astr = Mid(sstr, st, ed)
                If Len(sstr) < ed Then Exit Sub
                For i = 0 To 7
                    AD_Input(i) = Val(Mid(sstr, 2 + i * 7, 7))
                Next
            End If
        End Sub
    End Class




    Private StartLog As Boolean
    Private Comport As Integer
    Private StepTime As Integer
    Private LogCount As Long
    Private CountTimer As Long
    Private CurveCount As Integer
    Private CurrentUser As String

    Private firstFalg As Boolean
    Private LogDir, LogFileName As String
    Private UserList(20) As String

    Private TimerCount As Long
    Private lblData(20) As Label
    Dim chkChanel(7) As CheckBox
    Private Timer1 As Timer
    Private FFile As String
    Private fs As System.IO.FileStream
    Private sw As System.IO.StreamWriter
    ' 自動建立日期格式資料,以便程式使用
    Private NYear, NMonth, NDate, NHour, NMin, NSec, ADate, ATime, FDate, FTime, TDate, TTime As String

    Public Sub MakeDateData()
        NYear = Format(DatePart(DateInterval.Year, Now()), "0000")
        NMonth = Format(DatePart(DateInterval.Month, Now()), "00")
        NDate = Format(DatePart(DateInterval.Day, Now()), "00")
        NHour = Format(DatePart(DateInterval.Hour, Now()), "00")
        NMin = Format(DatePart(DateInterval.Minute, Now()), "00")
        NSec = Format(DatePart(DateInterval.Second, Now()), "00")
        ADate = NYear + "/" + NMonth + "/" + NDate      '以 "/" 分隔之日期 用於顯示
        ATime = NHour + "/" + NMin + "/" + NSec         '以 "/" 分隔之時間 用於顯示
        FDate = NYear + "_" + NMonth + "_" + NDate      '以 "_" 分隔之日期 用於檔案名稱
        FTime = NHour + "_" + NMin + "_" + NSec         '以 "_" 分隔之時間 用於檔案名稱
        TDate = NYear + ":" + NMonth + ":" + NDate      '以 ":" 分隔之日期 用於顯示
        TTime = NHour + ":" + NMin + ":" + NSec         '以 ":" 分隔之時間 用於顯示
    End Sub
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

        Adam4018 = New Adam4018_Class

        ' 在 InitializeComponent() 呼叫之後加入任何初始設定。

    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ii As Integer
        MakeDateData()

        For ii = 0 To 31
            cmoComport.Items.Add("COM" + Format(ii + 1))
        Next
        If Comport <= 0 Then
            Comport = 2
        End If
        If Comport > 0 Then cmoComport.SelectedIndex = Comport - 1

        lblCurrentTime.Text = TTime



        lblData(0) = lblData01
        lblData(1) = lblData02
        lblData(2) = lblData03
        lblData(3) = lblData04
        lblData(4) = lblData05
        lblData(5) = lblData06
        lblData(6) = lblData07
        lblData(7) = lblData08

        chkChanel(0) = chkCH01
        chkChanel(1) = chkCH02
        chkChanel(2) = chkCH03
        chkChanel(3) = chkCH04
        chkChanel(4) = chkCH05
        chkChanel(5) = chkCH06
        chkChanel(6) = chkCH07
        chkChanel(7) = chkCH08



        UserList(0) = "Leo"
        UserList(1) = "HCC"
        UserList(2) = "Vincent"
        UserList(3) = "Joe"
        UserList(4) = "User5"
        UserList(5) = "User6"
        UserList(6) = "User7"
        UserList(7) = "User8"
        UserList(8) = "User9"

        For ii = 0 To 8
            cmoUserName.Items.Add(UserList(ii))
        Next
        cmoUserName.SelectedIndex = 0
        CurrentUser = cmoUserName.SelectedItem
        ChartTimeLog.ChartAreas(0).AxisY.Minimum = [Double].NaN
        ChartTimeLog.ChartAreas(0).AxisY.Maximum = 100
        ' Enable range selection and zooming end user interface

        ChartTimeLog.ChartAreas(0).CursorX.IsUserEnabled = True
        ChartTimeLog.ChartAreas(0).CursorX.IsUserSelectionEnabled = True
        ChartTimeLog.ChartAreas(0).AxisX.ScaleView.Zoomable = True
        ChartTimeLog.ChartAreas(0).AxisX.ScrollBar.IsPositionedInside = True
        ChartTimeLog.ChartAreas(0).AxisX.ScrollBar.Size = 20
        ChartTimeLog.ChartAreas(0).AxisX.ScrollBar.IsPositionedInside = False
        ChartTimeLog.ChartAreas(0).CursorX.AutoScroll = True
        ChartTimeLog.ChartAreas(0).CursorY.IsUserEnabled = True
        ChartTimeLog.ChartAreas(0).CursorY.IsUserSelectionEnabled = True
        ChartTimeLog.ChartAreas(0).AxisY.ScaleView.Zoomable = True
        ChartTimeLog.ChartAreas(0).AxisY.ScrollBar.IsPositionedInside = True
        ChartTimeLog.ChartAreas(0).AxisY.ScrollBar.Size = 20
        ChartTimeLog.ChartAreas(0).AxisY.ScrollBar.IsPositionedInside = False
        ChartTimeLog.ChartAreas(0).CursorY.AutoScroll = True

        ChartTimeLog.ChartAreas(0).AxisY2.ScaleView.Zoomable = True
        ChartTimeLog.ChartAreas(0).AxisY2.ScrollBar.IsPositionedInside = False
        ChartTimeLog.ChartAreas(0).AxisY2.ScrollBar.Size = 20

        ChartTimeLog.ChartAreas(0).AxisX.Minimum = 0
        ChartTimeLog.ChartAreas(0).AxisX.Maximum = 600 '[Double].NaN 'MAX_XSCALE
        ChartTimeLog.ChartAreas(0).AxisY.Minimum = [Double].NaN
        ChartTimeLog.ChartAreas(0).AxisY.Maximum = 100

        For ii = 0 To 7
            ChartTimeLog.Series(ii).Name = "CH" + Format(ii + 1, "00")
        Next

        pnlChart.Visible = False
        LogDir = CurDir()

        Timer1 = New Timer
        AddHandler Timer1.Tick, AddressOf DataLogging

        Timer1.Interval = 300
        Timer1.Enabled = True

        firstFalg = True
    End Sub




    Private Sub btnStartLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartLog.Click
        Dim rtl As MsgBoxResult
        Dim i As Integer
        Dim astr As String
        Dim sstr As String
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
            sstr = ""
            For i = 0 To 7
                sstr = sstr + ChartTimeLog.Series(i).Name + vbTab
            Next
            AppendMultiData(FFile, 80, "序號", "時間", vbTab, sstr)
            txtListTitle.Text = "序號" + vbTab + "時間" + vbTab + vbTab + sstr
            TimerCount = Now().Second
            LogCount = LogCount + 1
            lblCount.Text = LogCount.ToString
            astr = Format(LogCount, "00000") + vbTab + TTime + vbTab + vbTab
            For i = 0 To 7
                astr = astr + lblData(i).Text + vbTab
                ChartTimeLog.Series(i).Points.Clear()
            Next
            AppendMultiData(FFile, 80, astr)
            lstLogList.Items.Add(astr)
            CountTimer = 0
        End If
    End Sub
    Public Sub StartMonitor(ByVal iPort As Integer)
        On Error Resume Next
        Adam4018.Initial(iPort, 1, 100)
        Adam4018.RSCOMM.PortName = "COM" + iPort.ToString
        Adam4018.OpenComm()
    End Sub

    Public Function GetTempData(ByVal iIndex As Integer) As Integer
        If iIndex >= 0 And iIndex <= 7 Then
            Return (Adam4018.GetADValue(iIndex))
        Else
            Return 999
        End If

    End Function

    Private Sub btnOpenComm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenComm.Click
        On Error Resume Next
        Comport = cmoComport.SelectedIndex + 1
        Adam4018.RSCOMM.PortName = "COM" + Comport.ToString
        Adam4018.OpenComm()
    End Sub

    Private Sub btnCloseComm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseComm.Click
        Adam4018.CloseComm()
    End Sub

    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Adam4018.IsOpen Then
            Adam4018.CloseComm()
        End If
        Me.Dispose()
    End Sub
    Private Sub DataLogging()
        Dim astr As String = ""
        Dim i As Integer
        Dim curSec As Long
        Static OldTime As Long

        On Error Resume Next
        MakeDateData()


        If pnlChart.Visible Then
            btnCurveForm.BackColor = Color.Lime
        Else
            btnCurveForm.BackColor = System.Drawing.SystemColors.Control

        End If
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
            For i = 0 To 7
                If Adam4018.CommLive = False Then
                    lblData(i).Text = "--.-"
                Else
                    If Adam4018.GetADValue(i) < 2000 Then
                        lblData(i).Text = Format(Adam4018.GetADValue(i), "0.0")
                    Else
                        lblData(i).Text = "--.-"
                    End If
                    ChartTimeLog.Series(i).Points.AddY(Adam4018.GetADValue(i))
                    If CurveCount < (ChartTimeLog.ChartAreas(0).AxisX.Maximum - 10) Then
                        CurveCount += 1
                    Else
                        ChartTimeLog.Series(i).Points.RemoveAt(0)
                    End If
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
                    AppendMultiData(FFile, 80, astr)
                    If LogCount Mod 20 = 0 Then lstLogList.Items.Clear()
                    lstLogList.Items.Add(astr)
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
            StepTime = Val(txtStepTime.Text)
        End If

    End Sub
    Private Sub btnSub1000_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSub1000.Click
        If Val(txtStepTime.Text) > 1 Then
            txtStepTime.Text = (Val(txtStepTime.Text) - 1).ToString
            StepTime = Val(txtStepTime.Text)
        End If
    End Sub

    Private Sub btnCurveForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCurveForm.Click
        pnlChart.Visible = Not pnlChart.Visible
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Adam4018.RSCOMM.Close()
        Me.Dispose()
    End Sub

    Private Sub CheckBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCH01.Click, chkCH08.Click, chkCH07.Click, chkCH06.Click, chkCH05.Click, chkCH04.Click, chkCH03.Click, chkCH02.Click
        Dim i As Integer
        For i = 0 To 7
            ChartTimeLog.Series(i).Enabled = chkChanel(i).Checked
        Next
    End Sub

    Private Sub btnYReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYReset.Click
        ChartTimeLog.ChartAreas("ChartArea1").AxisX.ScaleView.ZoomReset()
        ChartTimeLog.ChartAreas("ChartArea1").AxisY.ScaleView.ZoomReset()
        ChartTimeLog.ChartAreas("ChartArea1").AxisY2.ScaleView.ZoomReset()
    End Sub

    Private Sub btnPrintCurve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintCurve.Click
        ' Show Page Setup dialog
        'RecordChart.Printing.PageSetup()

        ' Print preview chart
        ChartTimeLog.Printing.PrintDocument.DocumentName = "Cello Curve " + FDate + "-" + FTime
        ChartTimeLog.Printing.PrintDocument.OriginAtMargins = True
        ChartTimeLog.Printing.PrintDocument.DefaultPageSettings.Landscape = True
        'Chart1.Printing.PrintPreview()
        ' Print chart (without Printer dialog)
        ChartTimeLog.Printing.Print(True)
    End Sub

End Class

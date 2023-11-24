Module Module_User_Control_Setup

    ''' <summary>
    '''ADAM 4118+
    ''' </summary>
    ''' <remarks></remarks>
    'Public ControlADAM4118s As New ControlADAM4118
    'Public ControlADAM4018_Modbuss As New ControlADAM4018_Modbus
    Public TIC_MONITOR_USED As Boolean
    Public TIC_MONITOR_COMPORT As Integer
    Public MonitorTemp(MAXPLATE) As Integer
    Public TimMonitorTimer As Timer

    Public Sub ReadMonitorTemp()
        Dim i As Integer
        For i = 0 To MAXPLATE
            'MonitorTemp(i) = ControlADAM4118s.GetTempData(i)
        Next
    End Sub

    Public Sub CreateTIC_Monitor()
        TIC_MONITOR_USED = GetTrue01Boolean(ReadProgData("TIC_MONITOR", "TIC_MONITOR_USED", "0", ProgramINIFile))
        TIC_MONITOR_COMPORT = Val(ReadProgData("TIC_MONITOR", "TIC_MONITOR_COMPORT", "2", ProgramINIFile))
        If TIC_MONITOR_USED Then
            If TIC_MONITOR_COMPORT > 0 Then
                'ControlADAM4118s.StartMonitor(TIC_MONITOR_COMPORT)
                TimMonitorTimer = New Timer
                TimMonitorTimer.Interval = 300
                AddHandler TimMonitorTimer.Tick, AddressOf ReadMonitorTemp
                TimMonitorTimer.Enabled = True
            End If
        End If
        '[TIC_MONITOR]
        'TIC_MONITOR_USED = 1
        'TIC_MONITOR_COMPORT = 2
    End Sub

    ''' <summary>
    ''' PID 子控制元件
    ''' </summary>
    ''' <remarks></remarks>
    Public PIDs(MAXPLATE) As ControlTempPID
    ''' <summary>
    ''' 溫度校正子元件
    ''' </summary>
    ''' <remarks></remarks>
    Public TempCal(MAXPLATE) As ControlTempCal
    ''' <summary>
    ''' 製程壓頭子元件
    ''' </summary>
    ''' <remarks></remarks>
    Public PlateProcess(MAXPLATE) As ControlProcess
    ''' <summary>
    ''' 製程資料顯示子元件
    ''' </summary>
    ''' <remarks></remarks>
    Public ProcessData(MAXPLATE) As ControlProcessData
    ''' <summary>
    ''' 製程曲線子元件
    ''' </summary>
    ''' <remarks></remarks>
    Public ProcessCurve(MAXPLATE) As ControlProcessChart
    ''' <summary>
    ''' 手動畫面曲線子元件
    ''' </summary>
    ''' <remarks></remarks>
    Public ManualCurve(MAXPLATE) As ControlManualChart
    ''' <summary>
    ''' 手動控制子元件
    ''' </summary>
    ''' <remarks></remarks>
    Public ManualControl(MAXPLATE) As ControlManual

    Public PressPID As New ControlPressPID
    ''' <summary>
    ''' 壓力校正子元件
    ''' </summary>
    ''' <remarks></remarks>
    Public PressCal(MAXPLATE) As ControlPressCal
    ''' <summary>
    ''' 流量讀出子元件
    ''' </summary>
    ''' <remarks></remarks>
    Public FlowRead(MAXPLATE) As ControlFlowSet
    ''' <summary>
    ''' 是否使用油壓
    ''' </summary>
    ''' <remarks></remarks>
    Public OilPumpUsed As Boolean

    ''' <summary>
    ''' 是否使用MFC PURGE
    ''' </summary>
    ''' <remarks></remarks>
    Public MFCPurgeUsed As Boolean

    ''' <summary>
    ''' 校正後上溫度
    ''' </summary>
    ''' <remarks></remarks>
    Public CaledTopTemp(MAXPLATE) As Integer
    ''' <summary>
    ''' 校正後下溫度
    ''' </summary>
    ''' <remarks></remarks>
    Public CaledBotTemp(MAXPLATE) As Integer
    ''' <summary>
    ''' 記錄顯示子元件
    ''' </summary>
    ''' <remarks></remarks>
    Public RecordDataShow(MAXPLATE) As ControlDataShow



    ''' <summary>
    ''' 建立及顯示子元件
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CreateUserControlData()
        Dim i As Integer
        '建立溫度校正控制項
        OilPumpUsed = True
        MFCPurgeUsed = False

        '建立PID調整控制項
        CreatePID(FormParameters.flwPIDPage1, 0, 2)
        If MAXPLATE > 2 Then
            CreatePID(FormParameters.flwPIDPage2, 3, MAXPLATE)
        End If
        ''建立壓頭校正控制項
        'CreatePressCal(FormParameters.flwPressCal, 0, MAXPLATE)
        ''CreateTempCal(FormTempCals.flwProcess1, 0, MAXPLATE)
        'CreateTempCal(FormParameters.flwTempCal, 0, MAXPLATE)
        If User_Cal_Enabled Then
            CreateTempCal(FormParameters.flwTempCalUser, 0, MAXPLATE)
            CreatePressCal(FormParameters.flwPressCalUser, 0, MAXPLATE)
        Else
            CreateTempCal(FormParameters.flwTempCal, 0, MAXPLATE)
            CreatePressCal(FormParameters.flwPressCal, 0, MAXPLATE)
            FormParameters.tabParameter.TabPages.RemoveByKey("TabPageTCal")
            FormParameters.tabParameter.TabPages.RemoveByKey("TabPagePCal")
        End If
        '建立流量控制項
        CreateFlowSet(FormParameters.flwFlowSetup, 0, MAXPLATE)
        '建立壓力PID控制項
        CreatePressPID(FormParameters.flwPressPID, 0, 0)
        If PressPID_Flag Then
            FormParameters.flwPressPID.Visible = True
            FormParameters.Panel1.Visible = False
            'FormParameters.pnlPressureAverage.Visible = False
            FormParameters.lblOutRangAddDAText.Visible = False
            FormParameters.txtOutRangAddDA1.Visible = False
            FormParameters.txtOutRangAddDA2.Visible = False
            FormParameters.txtOutRangAddDA3.Visible = False
            FormParameters.lblkgDARatioText.Visible = False
            FormParameters.txtkgDARatio1.Visible = False
            FormParameters.txtkgDARatio2.Visible = False
            FormParameters.txtkgDARatio3.Visible = False
        Else
            FormParameters.flwPressPID.Visible = False
            FormParameters.Panel1.Visible = True
            FormParameters.pnlPressureAverage.Visible = True
            FormParameters.lblOutRangAddDAText.Visible = True
            FormParameters.txtOutRangAddDA1.Visible = True
            FormParameters.txtOutRangAddDA2.Visible = True
            FormParameters.txtOutRangAddDA3.Visible = True
            FormParameters.lblkgDARatioText.Visible = True
            FormParameters.txtkgDARatio1.Visible = True
            FormParameters.txtkgDARatio2.Visible = True
            FormParameters.txtkgDARatio3.Visible = True
        End If
        '建立製程壓頭顯示控制項
        CreatePlateProcess(FormProcesss.flwProcess, 0, MAXPLATE)
        '建立製程壓頭配方顯示控制項
        CreateProcessData(FormProcesss.flwProcessData, 0, MAXPLATE)
        '建立製程壓頭圖表顯示控制項
        If MAXPLATE > 2 Then
            CreateProcessChart(FormProcesss.flwProcessCurve, 0, MAXPLATE)
        Else
            CreateProcessChart(FormProcesss.flwProcess, 0, MAXPLATE)
        End If

        '建立手動壓頭控制控制項
        CreateManual(FormManuals.flwManualPage1, 0, 2)
        If MAXPLATE > 2 Then
            CreateManual(FormManuals.flwManualPage2, 3, MAXPLATE)
        End If
        '建立手動壓頭曲線控制項
        CreateManualChart(FormManuals.flwManualChart1, 0, 2)
        If MAXPLATE > 2 Then
            CreateManualChart(FormManuals.flwManualChart2, 3, MAXPLATE)
        End If

        ' 初始化子製程類別
        For i = 0 To MAXPLATE
            CSubAutoProcess(i) = New CSubProcess
            CSubAutoProcess(i).Initial(i)
        Next

        CreateDataShow(FormRecords.pnlShowRecordData, 0, MAXPLATE)
        'CreateInfoData(0, 5)
    End Sub

    Public Sub CreateDataShow(ByRef frm As Object, ByVal iStart As Integer, ByVal iEnd As Integer, Optional ByVal Title As String = "Site #")
        Dim i As Integer
        For i = iStart To iEnd
            RecordDataShow(i) = New ControlDataShow
            RecordDataShow(i).Name = "RECORD_DATA" + Format(i, "00")

            RecordDataShow(i).Title = "Plate #" + (i + 1).ToString
            frm.Controls.Add(RecordDataShow(i))
        Next
    End Sub

    Public Sub CreateFlowSet(ByRef frm As Object, ByVal iStart As Integer, ByVal iEnd As Integer, Optional ByVal Title As String = "Site #")
        Dim i As Integer
        For i = iStart To iEnd
            FlowRead(i) = New ControlFlowSet
            FlowRead(i).Name = "PARAMETER_FLOWSET" + Format(i, "00")

            FlowRead(i).Initial(i, ADTopFlowMeter01Index + i * 2, ADBotFlowMeter01Index + i * 2)
            FlowRead(i).Title = Title + Format(i + 1, "00")
            frm.Controls.Add(FlowRead(i))
            FlowRead(i).ReadCalData(ParameterINIFile)
            'FlowRead(i).WriteCalData(ParameterINIFile)
        Next
    End Sub

    Public Sub CreatePressCal(ByRef frm As Object, ByVal iStart As Integer, ByVal iEnd As Integer, Optional ByVal Title As String = "Site #")
        Dim i As Integer
        For i = iStart To iEnd
            PressCal(i) = New ControlPressCal
            PressCal(i).Name = "PARAMETER_PRESSCAL" + Format(i, "00")

            PressCal(i).Initial(i, DAPressureCal1XIndex + i * 5, DAPressure01Cal1Index + i * 5,
                                ADOriginPressAD01Index + i, ADOriginPress01Index + i, ADBoundingP01Index + i,
                                DAPressFullScaleIndex, ADScalerA01Index + i,
                                 DoBondUp01Index + i * 4, DoBondDown01Index + i * 4,
                                 DoOilPump01Index + i * 4, 3000)
            PressCal(i).Title = Title + Format(i + 1, "00")
            PressCal(i).OilPumpUsed = OilPumpUsed
            frm.Controls.Add(PressCal(i))
            If i > 0 Then PressCal(i).EnableXInput = False
        Next
        AddHandler PressCal(0).CalXInput, AddressOf SyncPressCalData
    End Sub
    Public Sub CreatePressPID(ByRef frm As Object, ByVal iStart As Integer, ByVal iEnd As Integer)
        PressPID.Width = 60
        PressPID.Height = 50
        frm.Controls.Add(PressPID)
        PressPID.ReadPID()
    End Sub

    Public Sub SyncPressCalData()
        Dim i As Integer
        For i = 1 To MAXPLATE
            PressCal(i).txtX1.Text = PressCal(0).txtX1.Text
            PressCal(i).txtX2.Text = PressCal(0).txtX2.Text
            PressCal(i).txtX3.Text = PressCal(0).txtX3.Text
            PressCal(i).txtX4.Text = PressCal(0).txtX4.Text
            PressCal(i).txtX5.Text = PressCal(0).txtX5.Text
            PressCal(i).txtFullScale.Text = PressCal(0).txtFullScale.Text
            PressCal(i).SaveData()
        Next
    End Sub

    Public Sub CreateManual(ByRef frm As Object, ByVal iStart As Integer, ByVal iEnd As Integer, Optional ByVal Title As String = "Site #")
        Dim i As Integer
        For i = iStart To iEnd
            ManualControl(i) = New ControlManual()
            ManualControl(i).Name = "MANUAL_PLATE" + Format(i, "00")

            ManualControl(i).Initial(i, DiBondUp01Index + i * 2, DiBondDown01Index + i * 2, _
                                         DoHeater01Index + i, DoHeater01Index + i, _
                                        DoBondForce01Index + i, DoBondUp01Index + i * 4, DoBondDown01Index + i * 4, _
                                        DoOilPump01Index + i * 4, ADTopFlowMeter01Index + i * 2, ADTopFlowMeter01Index + i * 2, _
                                        ADTopCurrent01Index + i * 2, ADBotCurrent01Index + i * 2, _
                                        DAProcessBond01Index + i * 4, DAProcessBondRate01Index + i * 4, Do1stContactOK01Index + i, _
                                        DAProcessTemp01Index + i * 4, DAProcessTemp04Index + i * 4, DAProcessTempRate01Index + i * 4, DiTopWater01Index + i * 2, DiBotWater01Indx + i * 2)
            ManualControl(i).OilPumpUsed = OilPumpUsed
            ManualControl(i).Title = Title + Format(i + 1, "00")
            frm.Controls.Add(ManualControl(i))

            'ManualControl(i).Write_TempSet(ReadProgData(ManualControl(i).Name, ManualControl(i).txtPressureSet.Name, "25", FormSaveINIFile))
            'ManualControl(i).Write_TempRateSet(ReadProgData(ManualControl(i).Name, ManualControl(i).txtPressureSet.Name, "1", FormSaveINIFile))
            'ManualControl(i).Write_PressureSet(ReadProgData(ManualControl(i).Name, ManualControl(i).txtPressureSet.Name, "0", FormSaveINIFile))
            'ManualControl(i).Write_PressureRateSet(ReadProgData(ManualControl(i).Name, ManualControl(i).txtPressureSet.Name, "20", FormSaveINIFile))


            'ManualControl(i).txtPressureSet.Text = ReadProgData(ManualControl(i).Name, ManualControl(i).txtPressureSet.Name, "0", FormSaveINIFile)
            'ManualControl(i).txtPressureRateSet.Text = ReadProgData(ManualControl(i).Name, ManualControl(i).txtPressureRateSet.Name, "20", FormSaveINIFile)
            'ManualControl(i).txtTempSet.Text = ReadProgData(ManualControl(i).Name, ManualControl(i).txtTempSet.Name, "25", FormSaveINIFile)
            'ManualControl(i).txtTempRateSet.Text = ReadProgData(ManualControl(i).Name, ManualControl(i).txtTempRateSet.Name, "1", FormSaveINIFile)
            'FormTextBoxSave.SetTextBox(ManualControl(i), ManualControl(i).Name, FormSaveINIFile)
        Next
    End Sub

    Public Sub CreateProcessChart(ByRef frm As Object, ByVal iStart As Integer, ByVal iEnd As Integer, Optional ByVal Title As String = "Plate #")
        Dim i As Integer
        For i = iStart To iEnd
            ProcessCurve(i) = New ControlProcessChart
            ProcessCurve(i).Name = "PROCESS_CURVE" + Format(i, "00")

            ProcessCurve(i).Initial(i)
            ProcessCurve(i).Title = Title + Format(i + 1, "00")
            frm.Controls.Add(ProcessCurve(i))
        Next
    End Sub

    Public Sub CreateManualChart(ByRef frm As Object, ByVal iStart As Integer, ByVal iEnd As Integer, Optional ByVal Title As String = "Plate #")
        Dim i As Integer
        For i = iStart To iEnd
            ManualCurve(i) = New ControlManualChart
            ManualCurve(i).Name = "MANUAL_CURVE" + Format(i, "00")

            ManualCurve(i).Initial(i)
            ManualCurve(i).Title = Title + Format(i + 1, "00")
            frm.Controls.Add(ManualCurve(i))
        Next
    End Sub

    Public Sub CreatePID(ByRef frm As Object, ByVal iStart As Integer, ByVal iEnd As Integer, Optional ByVal Title As String = "Plate #")
        Dim i As Integer
        For i = iStart To iEnd
            PIDs(i) = New ControlTempPID
            PIDs(i).Name = "PARAMETER_PID" + Format(i, "00")

            PIDs(i).Initial(i, DoTopWPID01Index + i * 2, DoBotWPID01Index + i * 2, _
                             DoWAT01Index + i, DoWAT01Index + i, _
                             ADTopPIndex + i * 6, DATopP1Index + i * 10, _
                             ADBotPIndex + i * 6, DABotP1Index + i * 10, ADTopPower01Index + i * 2, ADBotPower01Index + i * 2)
            PIDs(i).Title = Title + Format(i + 1, "00")
            frm.Controls.Add(PIDs(i))
        Next
    End Sub

    Public Sub CreateTempCal(ByRef frm As Object, ByVal iStart As Integer, ByVal iEnd As Integer, Optional ByVal Title As String = "Plate #")
        Dim i As Integer
        For i = iStart To iEnd
            TempCal(i) = New ControlTempCal
            TempCal(i).Name = "PARAMETER_TEMPCAL" + Format(i, "00")

            TempCal(i).Initial(i, DoHeater01Index + i, ADTopTemp01Index + i * 2, ADBotTemp01Index + i * 2)
            TempCal(i).Title = "Plate #" + Format(i + 1, "00")
            frm.Controls.Add(TempCal(i))
            If i > 0 Then TempCal(i).EnableXInput = False
        Next
        AddHandler TempCal(0).CalXInput, AddressOf SyncTempCalData
    End Sub

    Public Sub SyncTempCalData()
        Dim i As Integer
        For i = 1 To MAXPLATE
            TempCal(i).txtTempX1.Text = TempCal(0).txtTempX1.Text
            TempCal(i).txtTempX2.Text = TempCal(0).txtTempX2.Text
            TempCal(i).txtTempX3.Text = TempCal(0).txtTempX3.Text
            TempCal(i).txtTempX4.Text = TempCal(0).txtTempX4.Text
            TempCal(i).txtTempX5.Text = TempCal(0).txtTempX5.Text
            TempCal(i).SaveData()
        Next
    End Sub
    Public Sub CreatePlateProcess(ByRef frm As Object, ByVal iStart As Integer, ByVal iEnd As Integer, Optional ByVal Title As String = "Plate #")
        Dim i As Integer
        For i = iStart To iEnd
            PlateProcess(i) = New ControlProcess
            PlateProcess(i).Name = "PLATE_PROCESS" + Format(i, "00")

            PlateProcess(i).Initial(i, DiBondUp01Index + i * 2, DiBondDown01Index + i * 2, _
                                                 DoHeater01Index + i, DoHeater01Index + i, _
                                                 DoBondUp01Index + i * 4, DoBondDown01Index + i * 4, _
                                                  ADTopCurrent01Index + i * 2, ADBotCurrent01Index + i * 2)
            PlateProcess(i).Title = "Plate #" + Format(i + 1, "00")
            frm.Controls.Add(PlateProcess(i))
        Next
    End Sub
    Public Sub CreateProcessData(ByRef frm As Object, ByVal iStart As Integer, ByVal iEnd As Integer, Optional ByVal Title As String = "Plate #")
        Dim i As Integer
        For i = iStart To iEnd
            ProcessData(i) = New ControlProcessData()
            ProcessData(i).Name = "PROCESS_DATA" + Format(i, "00")

            ProcessData(i).Initial(i)
            ProcessData(i).Title = "Plate #" + Format(i + 1, "00")
            frm.Controls.Add(ProcessData(i))
        Next
    End Sub

    'Public Sub CreateInfoData(ByVal iStart As Integer, ByVal iEnd As Integer, Optional ByVal Title As String = "Site #")
    '    Dim i As Integer
    '    For i = iStart To iEnd
    '        CInfo(i) = New ClassInfomation(i, DoBondForce01Index + i, ADBoundingP01Index + i, _
    '                                      ADTopTemp01Index + i * 2, ADBotTemp01Index + i * 2, _
    '                                        ADTopCurrent01Index + i * 2, ADBotCurrent01Index + i * 2, _
    '                                        ADTopFlowMeter01Index + i, ADBotFlowMeter01Index + i)
    '    Next
    'End Sub


    'Public Sub CreateTempManual(ByRef frm As Object, ByVal iStart As Integer, ByVal iEnd As Integer, Optional ByVal Title As String = "Site #")
    '    Dim i As Integer
    '    For i = iStart To iEnd
    '        TubeManual(i) = New ControlTubeManual(i, DoHeater01Index + i, ADSite01TopTempIndex + i, ADSite01BotTempIndex + i, DASite01TopTempIndex + i, DASite01BotTempIndex + i, DASite01RateIndex + i)
    '        TubeManual(i).Title = "Site #" + Format(i + 1, "00")
    '        frm.Controls.Add(TubeManual(i))
    '    Next
    'End Sub


End Module

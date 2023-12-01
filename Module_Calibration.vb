Module Module_Calibration
    Public Const Max_Caled_Temp As Integer = 2000
    Public Const Max_POINT As Integer = 6
    Public PressX(Max_POINT) As Integer
    Public PressY(Max_POINT) As Integer
    Public tempTopX(Max_POINT) As Integer
    Public tempTopY(Max_POINT) As Integer
    Public tempBotX(Max_POINT) As Integer
    Public tempBotY(Max_POINT) As Integer
    Public VentOKCount As Integer
    Public VentOK As Boolean
    Public intPeakClearTimes(2) As Integer

    'Public CInfo(20) As ClassInfomation


    'Public Class ClassInfomation
    'Private SiteNum As Integer
    ''設定 加熱器溫度讀取暫存器
    'Private ADTopTempIndex As Integer
    'Private ADBotTempIndex As Integer
    ''設定 加熱器電流讀取暫存器
    'Private ADTopCurrent01Index As Integer
    'Private ADBotCurrent01Index As Integer
    ''設定 加熱器電流讀取暫存器
    'Private ADTopFlowIndex As Integer
    'Private ADBotFlowIndex As Integer
    ''設定 加熱器電流讀取暫存器
    'Private ADPressureIndex As Integer
    'Private DoForceIndex As Integer

    Public MAXPLATE As Integer = 5
    Public DOOR1_USED As Boolean
    Public DOOR2_USED As Boolean
    Public MFC01_USED As Boolean
    Public MFC02_USED As Boolean
    Public MFC01_NAME As String
    Public MFC02_NAME As String
    Public PURGECOOLING As Boolean

    Public User_Cal_Enabled As Boolean = False
    Public Sub ReadProgramMode(ByVal sfile As String)
        MAXPLATE = Val(ReadProgData("PROGRAM_MODE", "PALTE", "3", ProgramINIFile)) - 1
        If MAXPLATE < 1 Then MAXPLATE = 1
        DOOR1_USED = GetTrue01Boolean(ReadProgData("PROGRAM_MODE", "DOOR1_USED", "1", ProgramINIFile))
        DOOR2_USED = GetTrue01Boolean(ReadProgData("PROGRAM_MODE", "DOOR2_USED", "0", ProgramINIFile))
        MFC01_USED = GetTrue01Boolean(ReadProgData("PROGRAM_MODE", "MFC01_USED", "0", ProgramINIFile))
        MFC02_USED = GetTrue01Boolean(ReadProgData("PROGRAM_MODE", "MFC02_USED", "0", ProgramINIFile))
        MFC01_NAME = ReadProgData("PROGRAM_MODE", "MFC01_NAME", "N2", ProgramINIFile)
        MFC02_NAME = ReadProgData("PROGRAM_MODE", "MFC01_NAME", "N2", ProgramINIFile)
        PURGECOOLING = GetTrue01Boolean(ReadProgData("PROGRAM_MODE", "PURGECOOLING", "0", ProgramINIFile))


        SetVisible(DOOR1_USED, FormManuals.btnDoor1Up, FormManuals.btnDoor1Down, FormProcesss.btnDoor1Up, FormProcesss.btnDoor1Down)
        SetVisible(DOOR2_USED, FormManuals.btnDoor2Up, FormManuals.btnDoor2Down, FormProcesss.btnDoor2Up, FormProcesss.btnDoor2Down)
        SetVisible(MFC01_USED, FormManuals.pnlMFC01, FormProcesss.pnlMFC01)
        SetVisible(MFC02_USED, FormManuals.pnlMFC02, FormProcesss.pnlMFC02)


        If MFC01_USED = False Then
            FormRecipes.TabControlOption.TabPages.Remove(FormRecipes.TabPageMFC01)
        End If
        If MFC02_USED = False Then
            FormRecipes.TabControlOption.TabPages.Remove(FormRecipes.TabPageMFC02)
        End If
        SetVisible(PURGECOOLING, FormProcesss.pnlPurgeCooling)
        If PURGECOOLING = False Then
            FormRecipes.TabControlOption.TabPages.Remove(FormRecipes.TabPagePurge)
        End If
        SetVisible(MAXPLATE > 2, FormRecipes.btnNext, FormRecipes.btnPrev)
        SetVisible(MAXPLATE > 2, FormRecords.chkSite4, FormRecords.chkSite5, FormRecords.chkSite6)

        If MAXPLATE < 3 Then
            FormManuals.tabManual.TabPages.RemoveByKey("tabPage4to6")
            FormParameters.tabPIDSetup.TabPages.RemoveByKey("tabPage4to6")
        End If
        User_Cal_Enabled = GetTrue01Boolean(ReadProgData("PROGRAM_MODE", "USER_CALIBRATION", "0", sfile))

        WriteProgramMode(sfile)
    End Sub


    Public Sub WriteProgramMode(ByVal sfile As String)
        'WriteProgData("PROGRAM_MODE", "PALTE", (MAXPLATE).ToString, ProgramINIFile)
        'WriteProgData("PROGRAM_MODE", "DOOR1_USED", GetTrue01String(DOOR1_USED), ProgramINIFile)
        'WriteProgData("PROGRAM_MODE", "DOOR2_USED", GetTrue01String(DOOR2_USED), ProgramINIFile)
        'WriteProgData("PROGRAM_MODE", "MFC01_USED", GetTrue01String(MFC01_USED), ProgramINIFile)
        'WriteProgData("PROGRAM_MODE", "MFC02_USED", GetTrue01String(MFC02_USED), ProgramINIFile)
        WriteProgData("PROGRAM_MODE", "USER_CALIBRATION", GetTrue01String(User_Cal_Enabled), ProgramINIFile)
        WriteProgData("PROGRAM_MODE", "PURGECOOLING", GetTrue01String(PURGECOOLING), sfile)
        'WriteProgData("PROGRAM_MODE", "MFC01_NAME", MFC01_NAME, ProgramINIFile)
        'WriteProgData("PROGRAM_MODE", "MFC01_NAME", MFC02_NAME, ProgramINIFile)
    End Sub

    '溫度
    Public TopTempSV(MAXPLATE) As Integer
    Public TopTempRateSV(MAXPLATE) As Integer
    Public BotTempRateSV(MAXPLATE) As Integer
    Public TopTempPV(MAXPLATE) As Integer
    Public BotTempSV(MAXPLATE) As Integer
    Public BotTempPV(MAXPLATE) As Integer
    Public TopTempSVStr(MAXPLATE) As String
    Public TopTempPVStr(MAXPLATE) As String
    Public BotTempSVStr(MAXPLATE) As String
    Public BotTempPVStr(MAXPLATE) As String


    Public TopPowerPV(MAXPLATE) As Double
    Public TopPowerPVStr(MAXPLATE) As String
    Public TopPowerSV(MAXPLATE) As Double
    Public TopPowerSVStr(MAXPLATE) As String

    Public BotPowerPV(MAXPLATE) As Double
    Public BotPowerPVStr(MAXPLATE) As String
    Public BotPowerSV(MAXPLATE) As Double
    Public BotPowerSVStr(MAXPLATE) As String
    '電流
    Public TopCurrent(MAXPLATE) As Single
    Public BotCurrent(MAXPLATE) As Single
    Public TopCurrentStr(MAXPLATE) As String
    Public BotCurrentStr(MAXPLATE) As String
    '壓力
    Public PressSV(MAXPLATE) As Integer
    Public PressRateSV(MAXPLATE) As Integer
    Public PressPV(MAXPLATE) As Integer
    Public oriPressPV(MAXPLATE) As Integer
    Public PressPVstr(MAXPLATE) As String



    '預設曲線
    Public PresetTemp(MAXPLATE) As Integer
    Public PresetPress(MAXPLATE) As Integer
    Public PresetTempStr(MAXPLATE) As String
    Public PresetPressStr(MAXPLATE) As String
    'MFC
    Public MFCReadValue(9) As Integer
    Public MFCSetValue(9) As Integer
    Public MFCReadValueStr(9) As String
    Public MFCSetValueStr(9) As String

    'Public TopFlowMeter(MAXPLATE) As Single
    'Public BotFlowMeter(MAXPLATE) As Single
    'Public TopFlowMeterStr(MAXPLATE) As String
    'Public BotFlowMeterStr(MAXPLATE) As String
    '抽真空資訊更新
    Public MPCurrent As Single
    Public MPCurrentStr As String

    Public WaterPressStr As String
    Public bolAddPress(MAXPLATE) As Boolean
    Public bolRedPress(MAXPLATE) As Boolean
    Public bolDePeakStart(MAXPLATE) As Boolean
    Public bolPressChange(MAXPLATE) As Boolean
    Public LastSetPress(MAXPLATE) As Integer

    Public Sub ReadInformation()
        '單頭溫度 
        Dim i As Integer
        Dim simulate As Boolean
        'simulate = True
        ' FOr Simulate
        'If simulate Then
        '    Randomize()
        '    MPCurrent = 5 + Rnd() * 2
        '    GaugeCHVac = 1 / Timex
        '    TopTempPV(i) = 300 + Rnd() * 20
        '    BotTempPV(i) = 300 + Rnd() * 20
        '    PressPV(i) = 3000 + Rnd() * 20
        'End If

        'MP/DP 電流值
        MPCurrent = Get_PLC_R1000(ADDPCurrentIndex) / 100
        If MPCurrent < 0 Then MPCurrent = 0
        MPCurrentStr = Format(MPCurrent, "0.00")

        '真空計
        GaugeCHVac = ChamberVacuum(Get_PLC_R1000(ADVacuumIndex), GaugeName)
        If GaugeCHVac = 0 Then GaugeCHVac = 990
        GaugeCHVacStr = Format(GaugeCHVac, "0.0E+00")
        '一大氣壓
        Check1ATM(GaugeCHVac)

        'MFC 流量
        MFCReadValue(ADMFC01Index) = GetPLCReadValue(ADMFC01Index)
        MFCReadValue(ADMFC02Index) = GetPLCReadValue(ADMFC02Index)
        If MFCReadValue(ADMFC01Index) < 0 Then MFCReadValue(ADMFC01Index) = 0
        If MFCReadValue(ADMFC02Index) < 0 Then MFCReadValue(ADMFC02Index) = 0
        MFCReadValueStr(ADMFC01Index) = Format(MFCReadValue(ADMFC01Index), "0")
        MFCReadValueStr(ADMFC02Index) = Format(MFCReadValue(ADMFC02Index), "0")
        '判斷是否可以VENT
        VentOKCount = 0

        '水壓

        For i = 0 To MAXPLATE
            '各頭溫度值
            TopTempPV(i) = TempCal(i).CaledTopTemp
            BotTempPV(i) = TempCal(i).CaledBotTemp
            TopTempPVStr(i) = Format(TopTempPV(i), "0")
            BotTempPVStr(i) = Format(BotTempPV(i), "0")

            TopPowerSV(i) = MonitorCurrentLimit
            TopPowerSVStr(i) = TopPowerSV(i).ToString

            BotPowerSV(i) = MonitorCurrentLimit
            BotPowerSVStr(i) = BotPowerSV(i).ToString

            TopPowerPV(i) = Get_PLC_R1000(ADTopPower01Index + i * 2) / 10
            TopPowerPVStr(i) = TopPowerPV(i).ToString

            BotPowerPV(i) = Get_PLC_R1000(ADBotPower01Index + i * 2) / 10
            BotPowerPVStr(i) = BotPowerPV(i).ToString

            '各頭加壓值
            oriPressPV(i) = Get_PLC_R1000(ADBoundingP01Index + i)
            If oriPressPV(i) < 0 Then oriPressPV(i) = 0

            If GetTrue01Boolean(SystemParameters.PressureAverageEnable) Then '平均次數
                'If PV_InRange(Get_PLC_R1100(DAProcessBond01Index + 4 * i), oriPressPV(i), Val(SystemParameters.PressAverage)) Then
                AvergaeValue(i).SetAverageTimes(Val(SystemParameters.PressureAverageTimes))
                PressPV(i) = AvergaeValue(i).GetAverageValue(oriPressPV(i))


            ElseIf GetTrue01Boolean(SystemParameters.PeakClearEnable) Then '去 Peak
                If Check_PLC_M(DoBondForce01Index + i) And LastSetPress(i) <> Get_PLC_R1100(DAProcessBond01Index + i * 4) Then
                    Debug.Print("LastSetPress(" + i.ToString + ")=" + LastSetPress(i).ToString + " , Get_PLC_R1100(" + i.ToString + ")=" + Get_PLC_R1100(DAProcessBond01Index + i * 4).ToString)
                    If Get_PLC_R1100(DAProcessBond01Index + i * 4) > oriPressPV(i) Then
                        bolAddPress(i) = True '有升壓
                        Debug.Print("升壓(" + i.ToString + ")")
                    Else
                        bolAddPress(i) = False
                    End If
                    If Get_PLC_R1100(DAProcessBond01Index + i * 4) < oriPressPV(i) Then
                        bolRedPress(i) = True '有降壓
                        Debug.Print("降壓(" + i.ToString + ")")
                    Else
                        bolRedPress(i) = False
                    End If
                    bolPressChange(i) = True
                    LastSetPress(i) = Get_PLC_R1100(DAProcessBond01Index + i * 4)
                End If
                If Get_PLC_R1100(DAProcessBond01Index + i * 4) > 200 Then
                    SystemParameters.PeakLimit = Int(Get_PLC_R1100(DAProcessBond01Index + i * 4) * 0.02).ToString
                Else
                    SystemParameters.PeakLimit = Int(Get_PLC_R1100(DAProcessBond01Index + i * 4) * 0.08).ToString
                End If
                If Check_PLC_M(DoBondForce01Index + i) And bolAddPress(i) And oriPressPV(i) >= Get_PLC_R1100(DAProcessBond01Index + i * 4) And bolPressChange(i) Then
                    bolDePeakStart(i) = True '有加壓修整
                    bolPressChange(i) = False
                Else
                    If Check_PLC_M(DoBondForce01Index + i) And bolRedPress(i) And oriPressPV(i) <= Get_PLC_R1100(DAProcessBond01Index + i * 4) And bolPressChange(i) Then
                        bolDePeakStart(i) = True '有降壓修整
                        bolPressChange(i) = False
                    Else
                        If bolPressChange(i) Then bolDePeakStart(i) = False '無修整
                    End If
                End If
                If Not Check_PLC_M(DoBondForce01Index + i) Then
                    bolDePeakStart(i) = False
                    LastSetPress(i) = 0
                End If
                If bolDePeakStart(i) Then AvergaeValue(i).GetDePeak(oriPressPV(i), SystemParameters.PeakLimit, SystemParameters.PeakTimes, Get_PLC_R1100(DAProcessBond01Index + i * 4), i)

            Else
                    PressPV(i) = SetInRange(True, oriPressPV(i), Get_PLC_R1100(DAProcessBond01Index + 4 * i), Val(SystemParameters.PressAverage)) '在均化範圍內傳回值
            End If
            'Debug.Print("bolDePeakStart(" + i.ToString + ")=" + bolDePeakStart(i).ToString)
            If GetTrue01Boolean(SystemParameters.PressureAdjust) Then '壓力修整......不好用
                Select Case PressState(i)
                    Case 0
                        If Check_PLC_M(DoBondForce01Index + i) Then '有加壓
                            OldPressValue(i) = Get_PLC_R1100(DAProcessBond01Index + 4 * i)
                            If PV_InRange(Get_PLC_R1100(DAProcessBond01Index + 4 * i), PressPV(i), Val(SystemParameters.PressAverage)) Then '均化範圍內
                                PressStateDelay(i) += 1
                                If PressStateDelay(i) > 3 Then '等3秒
                                    PressState(i) = 1
                                    PressStateDelay(i) = 0
                                End If
                            Else
                                PressStateDelay(i) = 0
                            End If
                        Else
                            OldPressValue(i) = 0
                        End If
                    Case 1
                        If Check_PLC_M(DoBondForce01Index + i) Then '有加壓
                            If Get_PLC_R1100(DAProcessBond01Index + 4 * i) <> OldPressValue(i) Then '設定值有變
                                PressPV(i) = SetInRange(True, oriPressPV(i), Get_PLC_R1100(DAProcessBond01Index + 4 * i), Val(SystemParameters.PressAverage)) '在均化範圍內顯示設定值
                                PressStateDelay(i) += 1
                                If PressStateDelay(i) > 3 Then
                                    PressStateDelay(i) = 0
                                    PressState(i) = 0
                                    OldPressValue(i) = 0
                                End If
                            Else
                                PressPV(i) = Get_PLC_R1100(DAProcessBond01Index + 4 * i) '在均化範圍內顯示設定值
                            End If
                        Else
                            PressState(i) = 0
                            OldPressValue(i) = 0
                        End If
                End Select
            Else
                If GetTrue01Boolean(SystemParameters.PressureAverageEnable) = False Then '不平均
                    PressPV(i) = SetInRange(True, oriPressPV(i), Get_PLC_R1100(DAProcessBond01Index + 4 * i), Val(SystemParameters.PressAverage)) '均化
                End If
            End If
            If Check_PLC_M(DoBondForce01Index + i) Then '有加壓
            Else
                PressPV(i) = oriPressPV(i)
            End If
            PressPVstr(i) = PressPV(i).ToString
            '各頭加熱器電流
            TopCurrent(i) = Get_PLC_R1000(ADTopCurrent01Index + i * 2) / 100
            BotCurrent(i) = Get_PLC_R1000(ADBotCurrent01Index + i * 2) / 100
            If TopCurrent(i) < 0 Then TopCurrent(i) = 0
            If BotCurrent(i) < 0 Then BotCurrent(i) = 0
            TopCurrentStr(i) = Format(TopCurrent(i), "0.00")
            BotCurrentStr(i) = Format(BotCurrent(i), "0.00")

            '各頭水流量
            'If FlowMeterMode Then
            If Val(SystemParameters.TopFlowMeterHz(i)) = 0 Then
                SystemParameters.TopFlowMeterHz(i) = 100000
            End If
            If Val(SystemParameters.BotFlowMeterHz(i)) = 0 Then
                SystemParameters.BotFlowMeterHz(i) = 100000
            End If

            '各頭預設曲線--溫度/壓力
            If ProcessMode_RUN Then
                If ProcessCurveIndex < RealTimePreSetCurves(i).BondingPressure.Length Then
                    PresetTemp(i) = RealTimePreSetCurves(i).TopTemperature(ProcessCurveIndex)
                    PresetPress(i) = RealTimePreSetCurves(i).BondingPressure(ProcessCurveIndex)
                End If
            Else
                PresetTemp(i) = 0
                PresetPress(i) = 0
            End If
            PresetTempStr(i) = PresetTemp(i).ToString
            PresetPressStr(i) = PresetPress(i).ToString

            '判斷是否可以 vent
            If TopTempPV(i) > Val(SystemParameters.CoolingTemperature) Then VentOKCount += 1
            If BotTempPV(i) > Val(SystemParameters.CoolingTemperature) Then VentOKCount += 1
        Next
        '可以 vent
        VentOK = (VentOKCount = 0)
        WaterPressStr = Format(Get_PLC_R1000(ADWaterPressIndex) / 100, "0.00")

    End Sub
    'End Class

    '傳回校正後數值
    'GetCalibratedTemp(未校正前數值,校正後序列,校正前序列,點數)
    Public Function GetCalibratedTemp(ByVal temp As Double, ByVal tempx() As Integer, ByVal tempy() As Integer, ByVal point As Integer) As Double
        Dim i As Integer
        On Error Resume Next
        Dim im, c As Double
        '點數小於2, 傳回原數值
        If point < 2 Then Return temp
        '數值超過範圍則傳回原數值
        If temp < tempy(0) Or temp > tempy(point + 1) Then Return temp
        '找數值在數列中之範圍位置
        For i = 0 To point + 1
            '通過原點之線性方程式為 y=mx, 則校正過之 X值= y/m, im= 1/m, im為 m 之倒數
            '假設 tempx(i),tempy(i) 為原點
            '則新的點為 (tempx(i + 1) - tempx(i)),(tempy(i + 1) - tempy(i))
            If temp >= tempx(i) And temp < tempx(i + 1) Then
                im = (tempy(i + 1) - tempy(i)) / (tempx(i + 1) - tempx(i))
                Return tempy(i) + (temp - tempx(i)) * im
            End If
        Next
        '若到這一步表示數值不在範圍內
        Return temp
    End Function
    '寫入校正後溫度
    'SetCalibratedTemp(溫度,校正後序列,校正前序列,點數)
    Public Function SetCalibratedTemp(ByVal temp As Double, ByVal tempx() As Integer, ByVal tempy() As Integer, ByVal point As Integer) As Double
        Dim i As Integer
        On Error Resume Next
        Dim im, c As Double
        '點數小於2, 傳回原數值
        If point < 2 Then Return temp
        '數值超過範圍則傳回原數值
        If temp < tempy(0) Or temp > tempy(point + 1) Then Return temp
        '找數值在數列中之範圍位置
        For i = 0 To point + 1
            '通過原點之線性方程式為 y=mx, 則校正過之 X值= y/m, im= 1/m, im為 m 之倒數
            '假設 tempx(i),tempy(i) 為原點
            '則新的點為 (tempx(i + 1) - tempx(i)),(tempy(i + 1) - tempy(i))
            If temp >= tempy(i) And temp < tempy(i + 1) Then
                im = (tempy(i + 1) - tempy(i)) / (tempx(i + 1) - tempx(i))
                Return tempx(i) + (temp - tempy(i)) / im
            End If
        Next

        '若到這一步表示數值不在範圍內
        Return temp
    End Function
    Public Sub ReadHeaterCalData(ByVal sfile As String)
        Dim i As Integer
        tempTopX(0) = 0
        tempTopX(1) = Val(ReadProgData("PARAMETER", "TOPTEMPCALX1", "25", sfile))
        tempTopX(2) = Val(ReadProgData("PARAMETER", "TOPTEMPCALX2", "100", sfile))
        tempTopX(3) = Val(ReadProgData("PARAMETER", "TOPTEMPCALX3", "200", sfile))
        tempTopX(4) = Val(ReadProgData("PARAMETER", "TOPTEMPCALX4", "300", sfile))
        tempTopX(5) = Val(ReadProgData("PARAMETER", "TOPTEMPCALX5", "400", sfile))
        tempTopX(6) = Max_Caled_Temp

        tempTopY(0) = 0
        tempTopY(1) = Val(ReadProgData("PARAMETER", "TOPTEMPCAL1", "25", sfile))
        tempTopY(2) = Val(ReadProgData("PARAMETER", "TOPTEMPCAL2", "100", sfile))
        tempTopY(3) = Val(ReadProgData("PARAMETER", "TOPTEMPCAL3", "200", sfile))
        tempTopY(4) = Val(ReadProgData("PARAMETER", "TOPTEMPCAL4", "300", sfile))
        tempTopY(5) = Val(ReadProgData("PARAMETER", "TOPTEMPCAL5", "400", sfile))
        tempTopY(6) = Max_Caled_Temp

        tempBotX(0) = 0
        tempBotX(1) = Val(ReadProgData("PARAMETER", "BOTTEMPCALX1", "25", sfile))
        tempBotX(2) = Val(ReadProgData("PARAMETER", "BOTTEMPCALX2", "100", sfile))
        tempBotX(3) = Val(ReadProgData("PARAMETER", "BOTTEMPCALX3", "200", sfile))
        tempBotX(4) = Val(ReadProgData("PARAMETER", "BOTTEMPCALX4", "300", sfile))
        tempBotX(5) = Val(ReadProgData("PARAMETER", "BOTTEMPCALX5", "400", sfile))
        tempBotX(6) = Max_Caled_Temp

        tempBotY(0) = 0
        tempBotY(1) = Val(ReadProgData("PARAMETER", "BOTTEMPCAL1", "25", sfile))
        tempBotY(2) = Val(ReadProgData("PARAMETER", "BOTTEMPCAL2", "100", sfile))
        tempBotY(3) = Val(ReadProgData("PARAMETER", "BOTTEMPCAL3", "200", sfile))
        tempBotY(4) = Val(ReadProgData("PARAMETER", "BOTTEMPCAL4", "300", sfile))
        tempBotY(5) = Val(ReadProgData("PARAMETER", "BOTTEMPCAL5", "400", sfile))
        tempBotY(6) = Max_Caled_Temp


    End Sub

    Public Sub WriteHeaterCalData(ByVal sfile As String)
        Dim i As Integer
        For i = 1 To 5
            WriteProgData("PARAMETER", "TOPTEMPCALX" + Format(i, "0"), tempTopX(i).ToString, sfile)
        Next
        For i = 1 To 5
            WriteProgData("PARAMETER", "TOPTEMPCAL" + Format(i, "0"), tempTopY(i).ToString, sfile)
        Next
        For i = 1 To 5
            WriteProgData("PARAMETER", "BOTTEMPCALX" + Format(i, "0"), tempBotX(i).ToString, sfile)
        Next
        For i = 1 To 5
            WriteProgData("PARAMETER", "BOTTEMPCAL" + Format(i, "0"), tempBotY(i).ToString, sfile)
        Next
    End Sub


    Public Sub ReadPressCalData(ByVal sfile As String)
        Dim i As Integer
        For i = 0 To 6
            PressX(i) = Val(ReadProgData("PARAMETER", "PRESSURECALX" + Format(i, "0"), (i * 3000).ToString, sfile))
            PressY(i) = Val(ReadProgData("PARAMETER", "PRESSURECAL" + Format(i, "0"), (i * 3000).ToString, sfile))
        Next
        SystemParameters.PressureCal1 = PressY(1)
        SystemParameters.PressureCal2 = PressY(2)
        SystemParameters.PressureCal3 = PressY(3)
        SystemParameters.PressureCal4 = PressY(4)
        SystemParameters.PressureCal5 = PressY(5)

        SystemParameters.PressureCalX1 = PressX(1)
        SystemParameters.PressureCalX2 = PressX(2)
        SystemParameters.PressureCalX3 = PressX(3)
        SystemParameters.PressureCalX4 = PressX(4)
        SystemParameters.PressureCalX5 = PressX(5)

        Write_PLC_R1100(DAPressure01Cal1Index, PressY(1))
        Write_PLC_R1100(DAPressure01Cal2Index, PressY(2))
        Write_PLC_R1100(DAPressure01Cal3Index, PressY(3))
        Write_PLC_R1100(DAPressure01Cal4Index, PressY(4))
        Write_PLC_R1100(DAPressure01Cal5Index, PressY(5))

        Write_PLC_R1100(DAPressureCal1XIndex, PressX(1))
        Write_PLC_R1100(DAPressureCal2XIndex, PressX(2))
        Write_PLC_R1100(DAPressureCal3XIndex, PressX(3))
        Write_PLC_R1100(DAPressureCal4XIndex, PressX(4))
        Write_PLC_R1100(DAPressureCal5XIndex, PressX(5))
    End Sub

    Public Sub WritePressCalData(ByVal sfile As String)
        Dim i As Integer
        PressY(0) = 0
        PressY(1) = Val(SystemParameters.PressureCal1)
        PressY(2) = Val(SystemParameters.PressureCal2)
        PressY(3) = Val(SystemParameters.PressureCal3)
        PressY(4) = Val(SystemParameters.PressureCal4)
        PressY(5) = Val(SystemParameters.PressureCal5)
        PressY(6) = 30000

        PressX(0) = 0
        PressX(1) = Val(SystemParameters.PressureCalX1)
        PressX(2) = Val(SystemParameters.PressureCalX2)
        PressX(3) = Val(SystemParameters.PressureCalX3)
        PressX(4) = Val(SystemParameters.PressureCalX4)
        PressX(5) = Val(SystemParameters.PressureCalX5)
        PressX(6) = 30000

        For i = 0 To 6
            WriteProgData("PARAMETER", "PRESSURECALX" + Format(i, "0"), PressX(i).ToString, sfile)
        Next
        For i = 0 To 6
            WriteProgData("PARAMETER", "PRESSURECAL" + Format(i, "0"), PressY(i).ToString, sfile)
        Next
    End Sub

End Module

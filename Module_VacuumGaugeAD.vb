Module Module_VacuumGaugeAD

    '==============================================================================================================================
    Public GaugeCHVac As Single
    Public GaugeCHVacStr As String
    Public GaugeCHVacOffsetVoltage As Single
    Public GaugeName As String
    Public Vac1ATM As Single
    Public Vac1ATM_Status As Boolean
    Public Vac1ATM_Select As Boolean  'true = X Input , False =GP275
    Public VacBasePressure_Status As Boolean


    'GP275 讀取變數 (載入腔使用之真空計),0-10V (0.3~5.659V)查表法 
    Public Gp275PressureIndexN() As Single = {1000, 900, 800, 760, 700, 600, 500, 400, 300, 200, _
                                             100, 50, 20, 10, 5, 2, 1, 0.5, 0.2, 0.1, _
                                             0.05, 0.02, 0.01, 0.005, 0.002, 0.001}
    'AD 數值, 不轉換 0-10V, 0-8191
    Public Gp275VoltageIndexN() As Integer = {4635, 4598, 4553, 4533, 4501, 4439, 4365, 4279, 4186, 4111, _
                                             4050, 3969, 3749, 3445, 3010, 2328, 1816, 1379, 946, 718, _
                                             559, 428, 373, 342, 321, 315}
    ''' <summary>
    ''' 是否使用 dry pump
    ''' </summary>
    ''' <remarks></remarks>
    Public DP_Pump_Used As Boolean
    Public DP_Temp_Used As Boolean
    Public DP_Flow_Used As Boolean
    Public DP_Flow_IO_Used As Boolean
    Public RP_Used As Boolean
    Public Ulvac_LS120_Used As Boolean
    Public Sub ReadPumpSetup(ByVal sfile As String)
        DP_Pump_Used = GetTrue01Boolean(ReadProgData("PUMP_SETUP", "DPPUMP", "0", sfile))
        Ulvac_LS120_Used = GetTrue01Boolean(ReadProgData("PUMP_SETUP", "Ulvac_LS120_Used", "0", sfile))

        'DP_Pump_Used = GetTrue01Boolean(ReadProgData("PUMP_SETUP", "DPPUMP", "1", sfile))
        DP_Temp_Used = GetTrue01Boolean(ReadProgData("PUMP_SETUP", "DP_Temp_Used", "0", sfile))
        DP_Flow_Used = GetTrue01Boolean(ReadProgData("PUMP_SETUP", "DP_Flow_Used", "0", sfile))
        DP_Flow_IO_Used = GetTrue01Boolean(ReadProgData("PUMP_SETUP", "DP_Flow_IO_Used", "0", sfile))
        RP_Used = GetTrue01Boolean(ReadProgData("PUMP_SETUP", "RP_Used", "0", sfile))
        'If DP_Flow_IO_Used Then
        '    DiDPWaterIndex = 9
        '    DiN2Index = 23
        'Else
        '    DiN2Index = 9
        '    DiDPWaterIndex = 23
        'End If
        WritePumpSetup(sfile)
    End Sub
    Public Sub WritePumpSetup(ByVal sfile As String)
        WriteProgData("PUMP_SETUP", "DPPUMP", GetTrue01String(DP_Pump_Used), sfile)
        WriteProgData("PUMP_SETUP", "Ulvac_LS120_Used", GetTrue01String(Ulvac_LS120_Used), sfile)
        WriteProgData("PUMP_SETUP", "DPPUMP", GetTrue01String(DP_Pump_Used), sfile)
        WriteProgData("PUMP_SETUP", "DP_Temp_Used", GetTrue01String(DP_Temp_Used), sfile)
        WriteProgData("PUMP_SETUP", "DP_Flow_Used", GetTrue01String(DP_Flow_Used), sfile)
        WriteProgData("PUMP_SETUP", "RP_Used", GetTrue01String(RP_Used), sfile)
    End Sub

    Public Sub ReadVacuumSetup(ByVal sfile As String)
        GaugeName = ReadProgData("VACUUM_SETUP", "GAUGENAME", "AP2004", sfile)
        GaugeCHVacOffsetVoltage = Val(ReadProgData("VACUUM_SETUP", "OFFSETVOLTAGE", "0", sfile))
        Vac1ATM = Val(ReadProgData("VACUUM_SETUP", "VAC1ATM", "7.6E+02", sfile))
      End Sub

    Public Sub WriteVacuumSetup(ByVal sfile As String)
        WriteProgData("VACUUM_SETUP", "GAUGENAME", GaugeName, sfile)
        WriteProgData("VACUUM_SETUP", "OFFSETVOLTAGE", GaugeCHVacOffsetVoltage.ToString, sfile)
        WriteProgData("VACUUM_SETUP", "VAC1ATM", Vac1ATM.ToString, sfile)
        WriteProgData("PUMP_SETUP", "DPPUMP", GetTrue01String(DP_Pump_Used), sfile)
    End Sub

    Public Function ChamberVacuum(ByVal ADCount As Integer, ByVal Gauge As String) As Single
        Select Case Gauge
            Case "GP275"
                Return GP275_ConvertDbl(ADCount)
            Case "AP2004"
                Return AP2004_ConvertDbl(ADCount)
            Case "ZSE40"
                Return ZSE40_ConvertDbl(ADCount)
            Case "APG100"
                Return APG100_ConvertDbl(ADCount)
            Case "PSG500"
                Return PSG500_Convert(ADCount)
            Case "PSG500"
                Return PSG500_Convert(ADCount)
            Case "PCG550"
                Return PCG550_Convert(ADCount)
            Case Else
                Return GP275_ConvertDbl(ADCount)
        End Select

    End Function

    Public Function GP275_ConvertDbl(ByVal ADIndex As Integer) As Double
        Dim i As Integer
        Dim a, b, c, d, e, f As Single
        Dim testvalue As Integer
        Dim rtl As Single
        Dim x As Double

        x = 10 * (ADIndex / 8191)
        'x = 0.38
        If x < 0.3 Or x > 6 Then
            rtl = 9900
            Return rtl
        End If
        If x <= 2.842 Then
            a = -0.02585
            b = 0.03767
            c = 0.04563
            d = 0.1151
            e = -0.04158
            f = 0.008737
            rtl = a + b * x + c * (x ^ 2) + d * (x ^ 3) + e * (x ^ 4) + f * (x ^ 5)
        ElseIf x > 2.842 And x <= 4.945 Then
            a = 0.1031
            b = -0.3986
            c = -0.02322
            d = 0.07438
            e = 0.07229
            f = -0.006866
            rtl = (a + c * x + e * x ^ 2) / (1 + b * x + d * x ^ 2 + f * x ^ 3)
        ElseIf x > 4.945 Then
            a = 100.624
            b = -0.37679
            c = -20.5623
            d = 0.0348656
            rtl = (a + c * x) / (1 + b * x + d * x ^ 2)
        End If
        If rtl < 0.001 Then rtl = 0.001
        If rtl > 990 Then rtl = 990
        Return rtl
    End Function



    Public Function BCG450_Convert(ByVal adValue As Integer) As Double
        'p = 10(U - 7.75) / 0.75 + c
        'U = 0.75 × (log p - c) + 7.75
        'where U p c
        '[V] [mbar]     0
        '[V] [Pa]       2
        '[v] [Torr]     -0.125
        Dim a, b, c, v, p As Double
        '計算全刻度電壓差 (所有 AD 皆為 0~10V之解析度
        a = 10
        '全刻度AD COUNTS
        b = 8191
        '目前讀值
        c = adValue 'Get_PLC_R1000(AdIndex)
        '目前讀值轉換成電壓值
        v = (c / b) * a
        p = Math.Pow(10, ((v - 7.75) / 0.75) + (-0.125))
        Return p
    End Function
    Public Function PSG500_Convert(ByVal adValue As Integer) As Double
        'p = 10((U-c)/1.286) ⇔
        ' U = c + 1.286 × log10 p
        'U p c U p c
        '[V] [mbar] 6.143  [V] [micron] 2.448
        '[V] [μbar] 2.287 [V] [Pa] 3.572
        '[V] [Torr] 6.304  [V] [kPa] 7.429
        '[V] [mTorr] 2.448
        'where p pressure
        'U measurement signal
        'c constant (depending on pressure unit
        Dim a, b, c, v, p As Double
        '計算全刻度電壓差 (所有 AD 皆為 0~10V之解析度
        a = 10
        '全刻度AD COUNTS
        b = 8191
        '目前讀值
        c = adValue ' Get_PLC_R1000(AdIndex)
        '目前讀值轉換成電壓值
        v = (c / b) * a
        p = Math.Pow(10, (v - 6.304) / 1.286)
        Return p
    End Function
    Public Function PCG550_Convert(ByVal adValue As Integer) As Double
        '3PC1-001-3101  1.2~8.68V
        'p = 10(U - c) 
        'U = c + (log P)
        'where U p c
        '[V] [mbar]     5.5
        '[v] [Torr]     5.625
        Dim a, b, c, v, p As Double
        '計算全刻度電壓差 (所有 AD 皆為 0~10V之解析度
        a = 10
        '全刻度AD COUNTS
        b = 8191
        '目前讀值
        c = adValue ' Get_PLC_R1000(AdIndex)
        '目前讀值轉換成電壓值
        v = (c / b) * a
        p = Math.Pow(10, (v - 5.625))
        If v < 1.0 Or v > 9.0 Then
            p = 990
            Return p
        End If
        If p < 0.0001 Then
            p = 0.0001
            Return p
        End If
        Return p
    End Function

    '計算 AP2004 低真空計的數值  P=10^(V-d), Torr=> d=5.62 , mbar=> d=5.5, Pa=> d=3.5
    Public Function AP2004_ConvertDbl(ByVal adValue As Double) As Double
        Dim a, b, c, d, j As Double
        '計算全刻度電壓差 (所有 AD 皆為 0~10V之解析度
        a = 10 ' Voltage ' PLCRReadValue(ADIndex).Max - PLCRReadValue(ADIndex).Min
        ' If a = 0 Then a = Voltage
        '全刻度AD COUNTS
        b = 8191 'AD_Max
        '目前讀值
        c = adValue
        '若 b=0 則載入預設值
        'If b = 0 Then b = AD_Max
        '目前讀值轉換成電壓值
        d = (c / b) * a
        j = Math.Pow(10, d - 5.62)
        Return j
    End Function

    '計算 APG100 低真空計的數值  P=10^(V-d), Torr=> d=6.125 , mbar=> d=6, Pa=> d=4
    Public Function APG100_Convert(ByVal adValue As Integer) As Double
        Dim a, b, c, d, j As Double
        '計算全刻度電壓差 (所有 AD 皆為 0~10V之解析度
        a = 10 ' PLCRReadValue(ADIndex).Max - PLCRReadValue(ADIndex).Min
        If a = 0 Then a = 10
        '全刻度AD COUNTS
        b = 8191 'PLCRReadValue(ADIndex).FullScale - PLCRReadValue(ADIndex).Zero
        '目前讀值
        c = adValue 'Val(PLC_R_READ(ADIndex))
        '若 b=0 則載入預設值
        'If b = 0 Then b = PLCRReadValue(ADIndex).FullScale
        '目前讀值轉換成電壓值
        d = (c / b) * a
        j = Math.Pow(10, d - 6.125)
        Return j
    End Function

    '計算 APG100 低真空計的數值  P=10^(V-d), Torr=> d=6.125 , mbar=> d=6, Pa=> d=4
    Public Function APG100_ConvertDbl(ByVal adValue As Double) As Double
        Dim a, b, c, d, j As Double
        '計算全刻度電壓差 (所有 AD 皆為 0~10V之解析度
        a = 10 ' PLCRReadValue(ADIndex).Max - PLCRReadValue(ADIndex).Min
        'If a = 0 Then a = Voltage
        '全刻度AD COUNTS
        b = 8191 ' AD_Max
        '目前讀值
        c = adValue
        '若 b=0 則載入預設值
        'If b = 0 Then b = AD_Max
        '目前讀值轉換成電壓值
        d = (c / b) * a
        j = Math.Pow(10, d - 6.125)
        Return j
    End Function

    '計算 ZSE40 真空計的數值  P=10^(V-d), Torr=> d=5.62 , mbar=> d=5.5, Pa=> d=3.5
    Public Function ZSE40_ConvertDbl(ByVal adValue As Double) As Double
        Dim a, b, c, d, j As Double
        '計算全刻度電壓差 (所有 AD 皆為 0~10V之解析度
        a = 10 ' PLCRReadValue(ADIndex).Max - PLCRReadValue(ADIndex).Min
        'If a = 0 Then a = Voltage
        '全刻度AD COUNTS
        b = 8191 'AD_Max
        '目前讀值
        c = adValue
        '目前讀值轉換成電壓值
        d = (c / b) * a
        j = 760 = (adValue - 590) * 1.9125
        Return j
    End Function

    '- for FX2n-4ad'由真度度回算 AP2004 的AD COUNT值=
    Public Function TorrToAP2004Count(ByVal torr As Double) As Double
        If torr = 0 Then Return 0
        Return 8191 * (5.62 + (Math.Log(torr) / (Math.Log(10)))) / 10
    End Function

    Public Function Check1ATM(ByVal vac As Double) As Double
        Dim cond As Boolean
        Static delay As Integer = 10

        If Vac1ATM_Select Then
            cond = Check_PLC_X(Di1ATMIndex)
        Else
            cond = (vac >= Vac1ATM)
        End If
        If cond Then
            If delay > (SystemParameters.VentOffDelay) * 10 Then
                Vac1ATM_Status = True
            Else
                Vac1ATM_Status = False
                delay += 1
            End If
        Else
            Vac1ATM_Status = False
            delay = 0
        End If
    End Function

    'Public Sub ChangeUnit(ByVal unit As Integer)
    '    Dim sunit As String
    '    If unit = "0" Then
    '        sunit = "Torr"
    '    Else
    '        sunit = "Pa"
    '    End If
    '    FormProcesss.lblTorr01Text.Text = sunit
    '    FormProcesss.lblTorr02Text.Text = sunit
    '    FormManuals.lblTorr01Text.Text = sunit
    '    FormRecipes.lblUnit.Text = sunit
    'End Sub
    'Public Function ChangeKPa(ByVal unit As Integer, ByVal torr As String) As String

    '    Dim sunit As String
    '    If unit = "1" Then
    '        torr = ((Val(torr) * 133.32)).ToString
    '        If Len(torr) < 3 Then
    '            sunit = "Pa"
    '        Else
    '            torr = ((Val(torr) / 1000)).ToString
    '            sunit = "kPa"
    '        End If
    '        FormProcesss.lblTorr01Text.Text = sunit
    '        FormProcesss.lblTorr02Text.Text = sunit
    '        FormManuals.lblTorr01Text.Text = sunit
    '        FormRecipes.lblUnit.Text = sunit
    '    End If

    '    Return torr
    'End Function
    'Public Function ChangeKPa(ByVal unit As Integer, ByVal torr As Double) As Double

    '    Dim sunit As String
    '    If unit = "1" Then
    '        torr = torr * 133.32
    '        If torr < 1000 Then
    '            sunit = "Pa"
    '        Else
    '            torr = torr / 1000
    '            sunit = "kPa"
    '        End If
    '        FormProcesss.lblTorr01Text.Text = sunit
    '        FormProcesss.lblTorr02Text.Text = sunit
    '        FormManuals.lblTorr01Text.Text = sunit
    '        FormRecipes.lblUnit.Text = sunit
    '    End If
    '    Return torr
    'End Function
End Module

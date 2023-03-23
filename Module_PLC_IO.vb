Module Module_PLC_IO
    'Add By Vtncent 20220506  ----------------------------------------------------------  Start

#Const SanAn_TCPIP_Used = 0
    'Add By Vtncent 20220506  ----------------------------------------------------------  End

    'Add By Vincent 20190710  ----------------------------------------------------------  Start
#Const B016_B020 = 0
#Const B030_B031 = 1
#Const B119_B122 = 2


#Const BONDER_TYPE = B119_B122
    '#Const BONDER_TYPE = B030_B031
    '#Const BONDER_TYPE = B016_B020

#If BONDER_TYPE = B016_B020 Then
    Public Const MachineID As String = "B020"
#ElseIf BONDER_TYPE = B030_B031 Then
    Public Const MachineID As String = "B030"
#Else
    Public Const MachineID As String = "B122"
#End If

    'Add By Vincent 20190710  ----------------------------------------------------------  End
#If BONDER_TYPE = B119_B122 Then

    Public Const DiCDAIndex As Integer = 0
    Public Const DiEMOIndex As Integer = 1 '5
    Public Const DiTopWater01Index As Integer = 2 '8
    Public Const DiBotWater01Indx As Integer = 3 '9
    Public Const DiTopWater02Index As Integer = 4 '10
    Public Const DiBotWater02Indx As Integer = 5 '11
    Public Const DiTopWater03Index As Integer = 6 '12
    Public Const DiBotWater03Indx As Integer = 7 '13
    Public Const DiWater01Index As Integer = 8 '1
    Public Const DiWater02Index As Integer = 8 '1
    Public Const DiN2Index As Integer = 9 '2
    Public Const DiSaftyGate01Index As Integer = 10 '3
    Public Const DiSaftyGate02Index As Integer = 10 '3
    Public Const DiDPFailIndex As Integer = 11 '4
    Public Const DiDoor1DownIndex As Integer = 12 '6
    Public Const DiDoor1UpIndex As Integer = 13 '7
    Public Const DiDoor2DownIndex As Integer = 12 '6
    Public Const DiDoor2UpIndex As Integer = 13 '7
#ElseIf BONDER_TYPE = B016_B020 Or BONDER_TYPE = B030_B031 Then

    Public Const DiCDAIndex As Integer = 0
    Public Const DiWater01Index As Integer = 1
    Public Const DiWater02Index As Integer = 1 '2          
    Public Const DiN2Index As Integer = 2
    Public Const DiSaftyGate01Index As Integer = 3 '42     
    Public Const DiSaftyGate02Index As Integer = 3
    Public Const DiEMOIndex As Integer = 5
    Public Const DiDPFailIndex As Integer = 4 '6           
    Public Const DiDoor1DownIndex As Integer = 6 '8        
    Public Const DiDoor1UpIndex As Integer = 7 '7          
    Public Const DiDoor2DownIndex As Integer = 6 '10       
    Public Const DiDoor2UpIndex As Integer = 7 '9          
    Public Const DiTopWater01Index As Integer = 8 '15           
    Public Const DiBotWater01Indx As Integer = 9 '16            
    Public Const DiTopWater02Index As Integer = 10 '20          
    Public Const DiBotWater02Indx As Integer = 11 '21           
    Public Const DiTopWater03Index As Integer = 12 '25          
    Public Const DiBotWater03Indx As Integer = 13 '26           
#End If



    Public Const DiBondDown01Index As Integer = 14 '13          'X02
    Public Const DiBondUp01Index As Integer = 15 '12            'X03
    Public Const DiBondDown02Index As Integer = 16 '18          'X02
    Public Const DiBondUp02Index As Integer = 17 '19            'X03
    Public Const DiBondDown03Index As Integer = 18 '23          'X02
    Public Const DiBondUp03Index As Integer = 19 '22            'X03


    Public Const DiHeaterOL01Index As Integer = 23 '14               '    X12
    Public Const DiHeaterOL02Index As Integer = 24 '19               '    X12
    Public Const DiHeaterOL03Index As Integer = 25 '24               '    X12

    '----------------------------------------------------------------------------------以下為6頭使用
    Public Const Di1ATMIndex As Integer = 20 '4               'X01
    Public Const DiPullerOpenIndex As Integer = 21 '4               'X01
    Public Const DiPullerCloseIndex As Integer = 22 '4               'X01



    Public Const DiBondUp04Index As Integer = 27            'X03
    Public Const DiBondDown04Index As Integer = 28          'X02
    Public Const DiHeaterOL04Index As Integer = 29               '    X12
    Public Const DiTopWater04Index As Integer = 30             'X07
    Public Const DiBotWater04Indx As Integer = 31              'X10

    Public Const DiBondUp05Index As Integer = 32            'X03
    Public Const DiBondDown05Index As Integer = 33          'X02
    Public Const DiHeaterOL05Index As Integer = 34               '    X12
    Public Const DiTopWater05Index As Integer = 35             'X07
    Public Const DiBotWater05Indx As Integer = 36              'X10

    Public Const DiBondUp06Index As Integer = 37            'X03
    Public Const DiBondDown06Index As Integer = 38          'X02
    Public Const DiHeaterOL06Index As Integer = 39               '    X12
    Public Const DiTopWater06Index As Integer = 40             'X07
    Public Const DiBotWater06Indx As Integer = 41              'X10




    ' PLC Y Output
    Public Const DoMPIndex As Integer = 0         ' DP POWER ON   Y3
    Public Const DoRVIndex As Integer = 1              ' RVP 閥        Y4
    Public Const DoVentIndex As Integer = 2              ' Vent/N2 閥門 Y7
    Public Const DoMPVentIndex As Integer = 3          'MP VENT
    Public Const DoTopHeat01Index As Integer = 4 '17         ' 上壓盤加熱開關 Y0
    Public Const DoBotHeat01Index As Integer = 5 '18         ' 下壓座加熱開 關 Y1
    Public Const DoTopHeat02Index As Integer = 6 '22         ' 上壓盤加熱開關 Y0
    Public Const DoBotHeat02Index As Integer = 7 '23         ' 下壓座加熱開 關 Y1
    Public Const DoTopHeat03Index As Integer = 8 '27         ' 上壓盤加熱開關 Y0
    Public Const DoBotHeat03Index As Integer = 9 '28         ' 下壓座加熱開 關 Y1

    Public Const DoDoor1UpIndex As Integer = 10             ' 蜂鳴器    Y17
    Public Const DoDoor1DownIndex As Integer = 11             ' 蜂鳴器    Y17
    Public Const DoRLLampIndex As Integer = 12 '6         ' 紅燈      Y14
    Public Const DoYLLampIndex As Integer = 13 '7         ' 黃燈      Y15
    Public Const DoGLLampIndex As Integer = 14 '8         ' 綠燈      Y16
    Public Const DoBZIndex As Integer = 15 '9             ' 蜂鳴器    Y17
    Public Const DoOilPump01Index As Integer = 16 ' 60        
    Public Const DoChamberLightIndex As Integer = 17 '44         '腔內照明
    Public Const DoBondDown01Index As Integer = 18 '14      ' 加壓氣缸下降  Y5  
    Public Const DoBondUp01Index As Integer = 19 '15        ' 加壓氣缸上升  Y6
    Public Const DoOilPump02Index As Integer = 20 '61        '
    Public Const DoPullerOpenIndex As Integer = 21 '4               'X01
    Public Const DoBondDown02Index As Integer = 22 '19      ' 加壓氣缸下降  Y5  
    Public Const DoBondUp02Index As Integer = 23 '20        ' 加壓氣缸上升  Y6
    Public Const DoOilPump03Index As Integer = 24 '62        
    Public Const DoPullerCloseIndex As Integer = 25 '4               'X01

    Public Const DoBondDown03Index As Integer = 26 '24      ' 加壓氣缸下降  Y5  
    Public Const DoBondUp03Index As Integer = 27 '25        ' 加壓氣缸上升  Y6

    'Add By Vincent 20190710  ----------------------------------------------------------  Start
    'BONDER_TYPE 定義於 Module_PLC_IO
#If BONDER_TYPE = B119_B122 Then
    Public Const DoHeater01Index As Integer = 28 '16       ' 加熱總開關,  Y2
    Public Const DoHeater02Index As Integer = 29 '21       ' 加熱總開關,  Y2
    Public Const DoHeater03Index As Integer = 30 '26       ' 加熱總開關,  Y2
    Public Const DoV10Index As Integer = 31 '4          'MP VENT
    Public Const DoV11Index As Integer = 32 '5          'MP VENT
#ElseIf BONDER_TYPE = B016_B020 Then
    Public Const DoHeater01Index As Integer = 30
    Public Const DoHeater02Index As Integer = 31
    Public Const DoHeater03Index As Integer = 32
    Public Const DoV10Index As Integer = 95
    Public Const DoV11Index As Integer = 95
#ElseIf BONDER_TYPE = B030_B031 Then
        Public Const DoHeater01Index As Integer = 28     
    Public Const DoHeater02Index As Integer = 29 
    Public Const DoHeater03Index As Integer = 30     
    Public Const DoV10Index As Integer = 95     
    Public Const DoV11Index As Integer = 95   
#End If
    'Add By Vincent 20190710  ----------------------------------------------------------  End

    'Add By Vtncent 20220506  ----------------------------------------------------------  Start
    Public Const DoTopPurge1Index As Integer = 36
    Public Const DoBotPurge1Index As Integer = 37
    Public Const DoTopPurge2Index As Integer = 38
    Public Const DoBotPurge2Index As Integer = 39
    Public Const DoTopPurge3Index As Integer = 40
    Public Const DoBotPurge3Index As Integer = 41
    'Add By Vtncent 20220506  ----------------------------------------------------------  End

    Public Const DoDoor2UpIndex As Integer = 95 '12             ' 蜂鳴器    Y17
    Public Const DoDoor2DownIndex As Integer = 95 '13             ' 蜂鳴器    Y17

    Public Const DoBondDown04Index As Integer = 95 '29      ' 加壓氣缸下降  Y5  
    Public Const DoBondUp04Index As Integer = 95 '30        ' 加壓氣缸上升  Y6
    Public Const DoHeater04Index As Integer = 95 '31       ' 加熱總開關,  Y2
    Public Const DoTopHeat04Index As Integer = 95 '32          ' 上壓盤加熱開關 Y0
    Public Const DoBotHeat04Index As Integer = 95 '33         ' 下壓座加熱開 關 Y1

    Public Const DoBondDown05Index As Integer = 95 '34      ' 加壓氣缸下降  Y5  
    Public Const DoBondUp05Index As Integer = 95 '35        ' 加壓氣缸上升  Y6
    Public Const DoHeater05Index As Integer = 95 '36       ' 加熱總開關,  Y2
    Public Const DoTopHeat05Index As Integer = 95 '37         ' 上壓盤加熱開關 Y0
    Public Const DoBotHeat05Index As Integer = 95 '38         ' 下壓座加熱開 關 Y1

    Public Const DoBondDown06Index As Integer = 95 ' 39      ' 加壓氣缸下降  Y5  
    Public Const DoBondUp06Index As Integer = 95 '40        ' 加壓氣缸上升  Y6
    Public Const DoHeater06Index As Integer = 95 ' 41       ' 加熱總開關,  Y2
    Public Const DoTopHeat06Index As Integer = 95 ' 42         ' 上壓盤加熱開關 Y0
    Public Const DoBotHeat06Index As Integer = 95 '43         ' 下壓座加熱開 關 Y1


    Public Const DoOilPump04Index As Integer = 95 ' 63        '結束後警聲
    Public Const DoOilPump05Index As Integer = 95 ' 64        '結束後警聲
    Public Const DoOilPump06Index As Integer = 95 '65        '結束後警聲

    Public Const DoBondForce01Index As Integer = 50       ' BONDING 加壓開始
    Public Const DoBondForce02Index As Integer = 51       ' BONDING 加壓開始
    Public Const DoBondForce03Index As Integer = 52       ' BONDING 加壓開始
    Public Const DoBondForce04Index As Integer = 95 '53       ' BONDING 加壓開始
    Public Const DoBondForce05Index As Integer = 95 '54       ' BONDING 加壓開始
    Public Const DoBondForce06Index As Integer = 95 ' 55       ' BONDING 加壓開始

    'Public Const DoPressDAOutLowIndex As Integer = 63        '比例閥強制輸出
    'Public Const DoPressDAOutHighIndex As Integer = 64        '比例閥強制輸出
    Public Const DoDPTempAlarmIndex As Integer = 63
    Public Const DoDPTempAlarmOFFIndex As Integer = 64

    Public Const DoPressEndAlarmIndex As Integer = 66        '結束後警聲
    Public Const DoForceDAOutIndex As Integer = 67        '結束後警聲
    Public Const DoSaftyGateAlarmIndex As Integer = 69        '結束後警聲

    Public Const DoTopWPID01Index As Integer = 70       ' 寫入PID
    Public Const DoBotWPID01Index As Integer = 71       ' 寫入PID
    Public Const DoTopWPID02Index As Integer = 72       ' 寫入PID
    Public Const DoBotWPID02Index As Integer = 73       ' 寫入PID
    Public Const DoTopWPID03Index As Integer = 74       ' 寫入PID
    Public Const DoBotWPID03Index As Integer = 75       ' 寫入PID
    Public Const DoTopWPID04Index As Integer = 76       ' 寫入PID
    Public Const DoBotWPID04Index As Integer = 77       ' 寫入PID
    Public Const DoTopWPID05Index As Integer = 78       ' 寫入PID
    Public Const DoBotWPID05Index As Integer = 79       ' 寫入PID
    Public Const DoTopWPID06Index As Integer = 80       ' 寫入PID
    Public Const DoBotWPID06Index As Integer = 81       ' 寫入PID

    Public Const DoWAT01Index As Integer = 82       ' 寫入TOP AT
    Public Const DoWAT02Index As Integer = 83       ' 寫入BOT AT
    Public Const DoWAT03Index As Integer = 84     ' 寫入BOT AT
    Public Const DoWAT04Index As Integer = 85       ' 寫入BOT AT
    Public Const DoWAT05Index As Integer = 86       ' 寫入BOT AT
    Public Const DoWAT06Index As Integer = 87       ' 寫入BOT AT

    Public Const DoTempTrackDisableIndex As Integer = 88 '26       ' 加熱追溫功能

    Public Const Do1stContactOK01Index As Integer = 90        '首次壓合完成
    Public Const Do1stContactOK02Index As Integer = 91        '首次壓合完成
    Public Const Do1stContactOK03Index As Integer = 92        '首次壓合完成
    Public Const Do1stContactOK04Index As Integer = 93        '首次壓合完成
    Public Const Do1stContactOK05Index As Integer = 94        '首次壓合完成
    Public Const Do1stContactOK06Index As Integer = 95        '首次壓合完成


    '================================================
    Public Const DAkgDARatio1Index As Integer = 0 '壓力/DA值比例
    Public Const DAkgDARatio2Index As Integer = 1 '壓力/DA值比例
    Public Const DAkgDARatio3Index As Integer = 2 '壓力/DA值比例
    Public Const DAkgDARatio4Index As Integer = 3 '壓力/DA值比例
    Public Const DAkgDARatio5Index As Integer = 4 '壓力/DA值比例
    Public Const DAkgDARatio6Index As Integer = 5 '壓力/DA值比例

    Public Const DADPOverTempIndex As Integer = 4           'MFC 01
    Public Const DADPOverTempOFFIndex As Integer = 5           'MFC 01

    Public Const DAMFC01Index As Integer = 6           'MFC 01
    Public Const DAMFC02Index As Integer = 7        'MFC 02
    Public Const DANoControlPresssIndex As Integer = 8        'MFC 02
    Public Const DADPMPSelectIndex As Integer = 9        '0=dp, mp >=1

    Public Const DATopP1Index As Integer = 10   '上P值
    Public Const DATopI1Index As Integer = 11   '上I值
    Public Const DATopD1Index As Integer = 12   '上D值
    Public Const DATopMax1Index As Integer = 13 '上輸出最大值
    Public Const DATopMin1Index As Integer = 14 '上輸出最小值

    Public Const DABotP1Index As Integer = 15       '下 P值
    Public Const DABotI1Index As Integer = 16       '下I值
    Public Const DABotD1Index As Integer = 17       ' 下D值
    Public Const DABotMax1Index As Integer = 18 '下輸出最大值
    Public Const DABotMin1Index As Integer = 19 '下輸出最小值

    Public Const DATopP2Index As Integer = 20   '上P值
    Public Const DATopI2Index As Integer = 21   '上I值
    Public Const DATopD2Index As Integer = 22   '上D值
    Public Const DATopMax2Index As Integer = 23 '上輸出最大值
    Public Const DATopMin2Index As Integer = 24 '上輸出最小值

    Public Const DABotP2Index As Integer = 25       '下 P值
    Public Const DABotI2Index As Integer = 26       '下I值
    Public Const DABotD2Index As Integer = 27       ' 下D值
    Public Const DABotMax2Index As Integer = 28 '下輸出最大值
    Public Const DABotMin2Index As Integer = 29 '下輸出最小值


    Public Const DATopP3Index As Integer = 30   '上P值
    Public Const DATopI3Index As Integer = 31   '上I值
    Public Const DATopD3Index As Integer = 32   '上D值
    Public Const DATopMax3Index As Integer = 33 '上輸出最大值
    Public Const DATopMin3Index As Integer = 34 '上輸出最小值

    Public Const DABotP3Index As Integer = 35       '下 P值
    Public Const DABotI3Index As Integer = 36       '下I值
    Public Const DABotD3Index As Integer = 37       ' 下D值
    Public Const DABotMax3Index As Integer = 38 '下輸出最大值
    Public Const DABotMin3Index As Integer = 39 '下輸出最小值


    Public Const DATopP4Index As Integer = 40   '上P值
    Public Const DATopI4Index As Integer = 41   '上I值
    Public Const DATopD4Index As Integer = 42   '上D值
    Public Const DATopMax4Index As Integer = 43 '上輸出最大值
    Public Const DATopMin4Index As Integer = 44 '上輸出最小值

    Public Const DABotP4Index As Integer = 45       '下 P值
    Public Const DABotI4Index As Integer = 46       '下I值
    Public Const DABotD4Index As Integer = 47       ' 下D值
    Public Const DABotMax4Index As Integer = 48 '下輸出最大值
    Public Const DABotMin4Index As Integer = 49 '下輸出最小值

    Public Const DATopP5Index As Integer = 50   '上P值
    Public Const DATopI5Index As Integer = 51   '上I值
    Public Const DATopD5Index As Integer = 52   '上D值
    Public Const DATopMax5Index As Integer = 53 '上輸出最大值
    Public Const DATopMin5Index As Integer = 54 '上輸出最小值

    Public Const DABotP5Index As Integer = 55       '下 P值
    Public Const DABotI5Index As Integer = 56       '下I值
    Public Const DABotD5Index As Integer = 57       ' 下D值
    Public Const DABotMax5Index As Integer = 58 '下輸出最大值
    Public Const DABotMin5Index As Integer = 59 '下輸出最小值

    Public Const DATopP6Index As Integer = 60   '上P值
    Public Const DATopI6Index As Integer = 61   '上I值
    Public Const DATopD6Index As Integer = 62   '上D值
    Public Const DATopMax6Index As Integer = 63 '上輸出最大值
    Public Const DATopMin6Index As Integer = 64 '上輸出最小值

    Public Const DABotP6Index As Integer = 65       '下 P值
    Public Const DABotI6Index As Integer = 66       '下I值
    Public Const DABotD6Index As Integer = 67       ' 下D值
    Public Const DABotMax6Index As Integer = 68 '下輸出最大值
    Public Const DABotMin6Index As Integer = 69 '下輸出最小值

    'Public Const DAProcessBondingModeIndex As Integer = 49  '製程中 壓合模式 -> 0= 同時, 1=壓力, 2=溫度

    Public Const DA1stPressIndex As Integer = 70         '第1段上升壓力 --> 抵消摩擦力
    Public Const DA2ndPressIndex As Integer = 71         '第2段上升壓力  --> 慢速上升
    Public Const DA3rdPressIndex As Integer = 72         '預壓壓力(第3段壓力)
    Public Const DAPlateUpPressureIndex As Integer = 73      '接觸點壓力
    Public Const DAT1stControlTimeIndex As Integer = 74 '16   '第1段控壓間隔時間
    Public Const DAT2ndControlTimeIndex As Integer = 75 '17   '第2段控壓間隔時間
    Public Const DAT1stControlKgIndex As Integer = 76 '18   '第1段控壓壓力
    Public Const DAT2ndControlKgIndex As Integer = 77 '19   '第2段控壓壓力
    Public Const DAInRagePDiv1SetIndex As Integer = 78 '47 '壓力範圍1控壓除數 (低壓)
    Public Const DAInRagePDiv2SetIndex As Integer = 79 '48 '壓力範圍2控壓除數 (高壓)
    Public Const DAThresholdIndex As Integer = 80 '2   '控壓臨界壓力
    Public Const DAThresholdRatioIndex As Integer = 81 '3   '控壓臨界比率, 除值為100
    Public Const DAPressFullScaleIndex As Integer = 82 '9            '壓力最大轉換徧移值
    Public Const DAHighDAIndex As Integer = 83
    Public Const DAProcessOKAlarmIndex As Integer = 84 '80 '58          ' 製程結束ALARM
    Public Const DAVentTimeIndex As Integer = 85            ' Vent 時間
    Public Const DALimitPowerTempIndex As Integer = 86  '下低溫時最大功率限制
    Public Const DALimitPowerIndex As Integer = 87      '下低溫時最大功率限制溫度
    Public Const DAMaxTempPowerIndex As Integer = 88      ' 溫控器最大輸出功率
    Public Const DAControlRangeTimeIndex As Integer = 89      '控壓範圍動作延遲時間
    Public Const DADPTempOffsetIndex As Integer = 90      '控壓範圍動作延遲時間
    Public Const DARullerLengthIndex As Integer = 91      '使用電阻尺,解析度0.1mm
    Public Const DAPressOKRangeIndex As Integer = 92 '46 '壓力OK範圍
    Public Const DAProgramVersionIndex As Integer = 94 'Version 2  'Add  by Vincent 20180419  ------------------- Start
    'R1300
    Public Const DAPressureCal1XIndex As Integer = 96   '壓合壓力5點校正 設定點 R1300
    Public Const DAPressureCal2XIndex As Integer = 97
    Public Const DAPressureCal3XIndex As Integer = 98
    Public Const DAPressureCal4XIndex As Integer = 99
    Public Const DAPressureCal5XIndex As Integer = 100
    'R1305
    Public Const DAPressure01Cal1Index As Integer = 101   '壓合壓力5點校正實際值 R1305
    Public Const DAPressure01Cal2Index As Integer = 102
    Public Const DAPressure01Cal3Index As Integer = 103
    Public Const DAPressure01Cal4Index As Integer = 104
    Public Const DAPressure01Cal5Index As Integer = 105
    'R1310
    Public Const DAPressure02Cal1Index As Integer = 106   '壓合壓力5點校正實際值 R1310
    Public Const DAPressure02Cal2Index As Integer = 107
    Public Const DAPressure02Cal3Index As Integer = 108
    Public Const DAPressure02Cal4Index As Integer = 109
    Public Const DAPressure02Cal5Index As Integer = 110
    'R1315
    Public Const DAPressure03Cal1Index As Integer = 111   '壓合壓力5點校正實際值 R1315
    Public Const DAPressure03Cal2Index As Integer = 112
    Public Const DAPressure03Cal3Index As Integer = 113
    Public Const DAPressure03Cal4Index As Integer = 114
    Public Const DAPressure03Cal5Index As Integer = 115
    'R1320
    Public Const DAPressure04Cal1Index As Integer = 116   '壓合壓力5點校正實際值 R1320
    Public Const DAPressure04Cal2Index As Integer = 117
    Public Const DAPressure04Cal3Index As Integer = 118
    Public Const DAPressure04Cal4Index As Integer = 119
    Public Const DAPressure04Cal5Index As Integer = 120
    'R1325
    Public Const DAPressure05Cal1Index As Integer = 121   '壓合壓力5點校正實際值 R1325
    Public Const DAPressure05Cal2Index As Integer = 122
    Public Const DAPressure05Cal3Index As Integer = 123
    Public Const DAPressure05Cal4Index As Integer = 124
    Public Const DAPressure05Cal5Index As Integer = 125
    'R1330
    Public Const DAPressure06Cal1Index As Integer = 126   '壓合壓力5點校正實際值 R1330
    Public Const DAPressure06Cal2Index As Integer = 127
    Public Const DAPressure06Cal3Index As Integer = 128
    Public Const DAPressure06Cal4Index As Integer = 129
    Public Const DAPressure06Cal5Index As Integer = 130
    'R1335
    Public Const DAProcessBond01Index As Integer = 131     '壓合壓力 
    Public Const DAProcessBondRate01Index As Integer = 132 '壓速
    Public Const DAProcessTemp01Index As Integer = 133        '溫度 'R1337
    Public Const DAProcessTempRate01Index As Integer = 134    '溫速
    'R1339
    Public Const DAProcessBond02Index As Integer = 135     '壓合壓力 
    Public Const DAProcessBondRate02Index As Integer = 136 '壓速
    Public Const DAProcessTemp02Index As Integer = 137        '溫度 'R1341
    Public Const DAProcessTempRate02Index As Integer = 138    '溫速
    'R1343
    Public Const DAProcessBond03Index As Integer = 139     '壓合壓力 
    Public Const DAProcessBondRate03Index As Integer = 140 '壓速
    Public Const DAProcessTemp03Index As Integer = 141        '溫度'R1345
    Public Const DAProcessTempRate03Index As Integer = 142    '溫速
    'R1347
    Public Const DAProcessBond04Index As Integer = 143     '壓合壓力 
    Public Const DAProcessBondRate04Index As Integer = 144 '壓速
    Public Const DAProcessTemp04Index As Integer = 145        '溫度'R1349
    Public Const DAProcessTempRate04Index As Integer = 146    '溫速
    'R1351
    Public Const DAProcessBond05Index As Integer = 147     '壓合壓力 
    Public Const DAProcessBondRate05Index As Integer = 148 '壓速
    Public Const DAProcessTemp05Index As Integer = 149        '溫度'R1353
    Public Const DAProcessTempRate05Index As Integer = 150    '溫速
    'R1355
    Public Const DAProcessBond06Index As Integer = 151     '壓合壓力 
    Public Const DAProcessBondRate06Index As Integer = 152 '壓速
    Public Const DAProcessTemp06Index As Integer = 153        '溫度'R1357
    Public Const DAProcessTempRate06Index As Integer = 154    '溫速
    'R1359
    Public Const DA2ndPress1Index As Integer = 155     '壓合壓力 
    Public Const DA2ndPress2Index As Integer = 156 '壓速
    Public Const DA2ndPress3Index As Integer = 157        '溫度
    Public Const DA2ndPress4Index As Integer = 158    '溫速
    Public Const DA2ndPress5Index As Integer = 159    '溫速
    Public Const DA2ndPress6Index As Integer = 160    '溫速

    'R1365
    Public Const DAPlateUpPressure1Index As Integer = 161   '壓合壓力 
    Public Const DAPlateUpPressure2Index As Integer = 162 '壓速
    Public Const DAPlateUpPressure3Index As Integer = 163        '溫度
    Public Const DAPlateUpPressure4Index As Integer = 164    '溫速
    Public Const DAPlateUpPressure5Index As Integer = 165    '溫速
    Public Const DAPlateUpPressure6Index As Integer = 166    '溫速


    'R1371
    ''' <summary>
    ''' 油壓缸位置
    ''' </summary>
    ''' <remarks>99.02.02</remarks>
    Public Const DAPositionSet01Index As Integer = 167   '油壓缸位置
    Public Const DAPositionSet02Index As Integer = 168   '
    Public Const DAPositionSet03Index As Integer = 169        '溫度
    Public Const DAPositionSet04Index As Integer = 170    '溫速
    Public Const DAPositionSet05Index As Integer = 171    '溫速
    Public Const DAPositionSet06Index As Integer = 172    '溫速

    'R1383
    '================================================
    Public Const DAOutRangAddDA1Index As Integer = 179 '壓力/DA值比例
    Public Const DAOutRangAddDA2Index As Integer = 180 '壓力/DA值比例
    Public Const DAOutRangAddDA3Index As Integer = 181 '壓力/DA值比例
    Public Const DAOutRangAddDA4Index As Integer = 182 '壓力/DA值比例
    Public Const DAOutRangAddDA5Index As Integer = 183 '壓力/DA值比例
    Public Const DAOutRangAddDA6Index As Integer = 184 '壓力/DA值比例

    '=====================================================

    Public Const ADBoundingP01Index As Integer = 0     '目前 LOAD CELL 值(校正過已扣重)
    Public Const ADBoundingP02Index As Integer = 1     '目前 LOAD CELL 值(校正過已扣重)
    Public Const ADBoundingP03Index As Integer = 2     '目前 LOAD CELL 值(校正過已扣重)
    Public Const ADBoundingP04Index As Integer = 3     '目前 LOAD CELL 值(校正過已扣重)
    Public Const ADBoundingP05Index As Integer = 4     '目前 LOAD CELL 值(校正過已扣重)
    Public Const ADBoundingP06Index As Integer = 5     '目前 LOAD CELL 值(校正過已扣重)
    'Public Const ADBoundingPressureRealIndex As Integer = 1     '目前 LOAD CELL 值(校正過未扣重)
    Public Const ADMFC01Index As Integer = 6           'MFC 01
    Public Const ADMFC02Index As Integer = 7           'MFC 02
    Public Const ADVacuumIndex As Integer = 8              '真空原始值GP275
    Public Const ADDPCurrentIndex As Integer = 9            'DP電流
    Public Const ADDPTempIndex As Integer = 10          'DP電流

    Public Const ADTopPIndex As Integer = 20            '目前上溫控器 P值
    Public Const ADTopIIndex As Integer = 21             '目前上溫控器 I值
    Public Const ADTopDIndex As Integer = 22             '目前上溫控器 D值

    Public Const ADBotPIndex As Integer = 23          '目前下溫控器 P值
    Public Const ADBotIIndex As Integer = 24          '目前下溫控器 I值
    Public Const ADBotDIndex As Integer = 25          '目前下溫控器 D值

    Public Const ADTopP02Index As Integer = 26            '目前上溫控器 P值
    Public Const ADTopI02Index As Integer = 27             '目前上溫控器 I值
    Public Const ADTopD02Index As Integer = 28             '目前上溫控器 D值

    Public Const ADBotP02Index As Integer = 29          '目前下溫控器 P值
    Public Const ADBotI02Index As Integer = 30          '目前下溫控器 I值
    Public Const ADBotD02Index As Integer = 31          '目前下溫控器 D值

    Public Const ADTopP03Index As Integer = 32            '目前上溫控器 P值
    Public Const ADTopI03Index As Integer = 33             '目前上溫控器 I值
    Public Const ADTopD03Index As Integer = 34             '目前上溫控器 D值

    Public Const ADBotP03Index As Integer = 35          '目前下溫控器 P值
    Public Const ADBotI03Index As Integer = 36          '目前下溫控器 I值
    Public Const ADBotD03Index As Integer = 37          '目前下溫控器 D值

    Public Const ADTopP04Index As Integer = 38            '目前上溫控器 P值
    Public Const ADTopI04Index As Integer = 39             '目前上溫控器 I值
    Public Const ADTopD04Index As Integer = 40             '目前上溫控器 D值
    Public Const ADBotP04Index As Integer = 41          '目前下溫控器 P值
    Public Const ADBotI04Index As Integer = 42          '目前下溫控器 I值
    Public Const ADBotD04Index As Integer = 43          '目前下溫控器 D值

    Public Const ADTopP05Index As Integer = 44            '目前上溫控器 P值
    Public Const ADTopI05Index As Integer = 45             '目前上溫控器 I值
    Public Const ADTopD05Index As Integer = 46             '目前上溫控器 D值
    Public Const ADBotP05Index As Integer = 47          '目前下溫控器 P值
    Public Const ADBotI05Index As Integer = 48          '目前下溫控器 I值
    Public Const ADBotD05Index As Integer = 49          '目前下溫控器 D值

    Public Const ADTopP06Index As Integer = 50            '目前上溫控器 P值
    Public Const ADTopI06Index As Integer = 51             '目前上溫控器 I值
    Public Const ADTopD06Index As Integer = 52             '目前上溫控器 D值
    Public Const ADBotP06Index As Integer = 53          '目前下溫控器 P值
    Public Const ADBotI06Index As Integer = 54          '目前下溫控器 I值
    Public Const ADBotD06Index As Integer = 55          '目前下溫控器 D值

    Public Const ADTopCurrent01Index As Integer = 56           '上加熱電流
    Public Const ADBotCurrent01Index As Integer = 57        '下加熱電流
    Public Const ADTopCurrent02Index As Integer = 58           '上加熱電流
    Public Const ADBotCurrent02Index As Integer = 59        '下加熱電流
    Public Const ADTopCurrent03Index As Integer = 60          '上加熱電流
    Public Const ADBotCurrent03Index As Integer = 61        '下加熱電流
    Public Const ADTopCurrent04Index As Integer = 62           '上加熱電流
    Public Const ADBotCurrent04Index As Integer = 63        '下加熱電流
    Public Const ADTopCurrent05Index As Integer = 64           '上加熱電流
    Public Const ADBotCurrent05Index As Integer = 65        '下加熱電流
    Public Const ADTopCurrent06Index As Integer = 66           '上加熱電流
    Public Const ADBotCurrent06Index As Integer = 67        '下加熱電流

    Public Const ADTopTemp01Index As Integer = 80 '1        '目前 上壓頭溫度值
    Public Const ADBotTemp01Index As Integer = 81 '2        '目前 下壓頭溫度值
    Public Const ADTopTemp02Index As Integer = 82        '目前 上壓頭溫度值
    Public Const ADBotTemp02Index As Integer = 83       '目前 下壓頭溫度值
    Public Const ADTopTemp03Index As Integer = 84        '目前 上壓頭溫度值
    Public Const ADBotTemp03Index As Integer = 85       '目前 下壓頭溫度值
    Public Const ADTopTemp04Index As Integer = 86        '目前 上壓頭溫度值
    Public Const ADBotTemp04Index As Integer = 87       '目前 下壓頭溫度值
    Public Const ADTopTemp05Index As Integer = 88        '目前 上壓頭溫度值
    Public Const ADBotTemp05Index As Integer = 89       '目前 下壓頭溫度值
    Public Const ADTopTemp06Index As Integer = 90        '目前 上壓頭溫度值
    Public Const ADBotTemp06Index As Integer = 91       '目前 下壓頭溫度值


    'R1200 ~R1263 從 96開始
    Public Const ADTopFlowMeter01Index As Integer = 96        '上水流量01R1200
    Public Const ADBotFlowMeter01Index As Integer = 97        '下水流量01R1201
    Public Const ADTopFlowMeter02Index As Integer = 98        '上水流量01
    Public Const ADBotFlowMeter02Index As Integer = 99        '下水流量01
    Public Const ADTopFlowMeter03Index As Integer = 100        '上水流量01
    Public Const ADBotFlowMeter03Index As Integer = 101       '下水流量01
    Public Const ADTopFlowMeter04Index As Integer = 102       '上水流量01
    Public Const ADBotFlowMeter04Index As Integer = 103       '下水流量01
    Public Const ADTopFlowMeter05Index As Integer = 104       '上水流量01
    Public Const ADBotFlowMeter05Index As Integer = 105       '下水流量01
    Public Const ADTopFlowMeter06Index As Integer = 106       '上水流量01
    Public Const ADBotFlowMeter06Index As Integer = 107       '下水流量01
    'R1212
    Public Const ADScalerA01Index As Integer = 108       '油壓比例閥低壓輸出
    Public Const ADScalerA02Index As Integer = 109       '油壓比例閥低壓輸出
    Public Const ADScalerA03Index As Integer = 110       '油壓比例閥低壓輸出
    Public Const ADScalerA04Index As Integer = 111       '油壓比例閥低壓輸出
    Public Const ADScalerA05Index As Integer = 112       '油壓比例閥低壓輸出
    Public Const ADScalerA06Index As Integer = 113       '油壓比例閥低壓輸出
    'R1218
    Public Const ADScalerB01Index As Integer = 114        '油壓比例閥高壓輸出
    Public Const ADScalerB02Index As Integer = 115        '油壓比例閥高壓輸出
    Public Const ADScalerB03Index As Integer = 116        '油壓比例閥高壓輸出
    Public Const ADScalerB04Index As Integer = 117        '油壓比例閥高壓輸出
    Public Const ADScalerB05Index As Integer = 118        '油壓比例閥高壓輸出
    Public Const ADScalerB06Index As Integer = 119        '油壓比例閥高壓輸出
    'R1224
    Public Const ADOriginPress01Index As Integer = 120     '壓力未校正值
    Public Const ADOriginPress02Index As Integer = 121     '壓力未校正值
    Public Const ADOriginPress03Index As Integer = 122     '壓力未校正值
    Public Const ADOriginPress04Index As Integer = 123     '壓力未校正值
    Public Const ADOriginPress05Index As Integer = 124     '壓力未校正值
    Public Const ADOriginPress06Index As Integer = 125     '壓力未校正值
    'R1230
    Public Const ADOriginPressAD01Index As Integer = 126     '壓力未校正值
    Public Const ADOriginPressAD02Index As Integer = 127     '壓力未校正值
    Public Const ADOriginPressAD03Index As Integer = 128     '壓力未校正值
    Public Const ADOriginPressAD04Index As Integer = 129     '壓力未校正值
    Public Const ADOriginPressAD05Index As Integer = 130     '壓力未校正值
    Public Const ADOriginPressAD06Index As Integer = 131     '壓力未校正值
    'R1236
    Public Const ADTopPower01Index As Integer = 132     '壓力未校正值
    Public Const ADBotPower01Index As Integer = 133     '壓力未校正值
    Public Const ADTopPower02Index As Integer = 134     '壓力未校正值
    Public Const ADBotPower02Index As Integer = 135     '壓力未校正值
    Public Const ADTopPower03Index As Integer = 136     '壓力未校正值
    Public Const ADBotPower03Index As Integer = 137     '壓力未校正值
    Public Const ADTopPower04Index As Integer = 138     '壓力未校正值
    Public Const ADBotPower04Index As Integer = 139     '壓力未校正值
    Public Const ADTopPower05Index As Integer = 140     '壓力未校正值
    Public Const ADBotPower05Index As Integer = 141     '壓力未校正值
    Public Const ADTopPower06Index As Integer = 142     '壓力未校正值
    Public Const ADBotPower06Index As Integer = 143     '壓力未校正值
    'R1248
    Public Const ADSubPress01Index As Integer = 144     '壓力未校正值
    Public Const ADSubPress02Index As Integer = 145     '壓力未校正值
    Public Const ADSubPress03Index As Integer = 146     '壓力未校正值
    Public Const ADSubPress04Index As Integer = 147     '壓力未校正值
    Public Const ADSubPress05Index As Integer = 148     '壓力未校正值
    Public Const ADSubPress06Index As Integer = 149     '壓力未校正值

    'R1254
    ''' <summary>
    ''' 油壓缸位置
    ''' </summary>
    ''' <remarks>99.02.02</remarks>
    ''' R1254
    Public Const ADCurrentPosition01Index As Integer = 150   '油壓缸位置
    Public Const ADCurrentPosition02Index As Integer = 151   '
    Public Const ADCurrentPosition03Index As Integer = 152    '溫度
    Public Const ADCurrentPosition04Index As Integer = 153    '溫速
    Public Const ADCurrentPosition05Index As Integer = 154    '溫速
    Public Const ADCurrentPosition06Index As Integer = 155    '溫速
    '==========================================================
    'PLC 讀出暫存器--------------------------------------------------------------------------------------

    '==========================================================================================================================

    '讀取 I/O 名稱
    Public InputXName(2, 95) As String
    Public OutputYName(2, 95) As String
    Public Sub ReadIOName(ByVal cht_file As String, ByVal chs_file As String, ByVal eng_file As String)
        Dim i As Integer
        For i = 0 To 95
            InputXName(0, i) = ReadProgData("DI_CHT", "lblX" + Format(i, "00"), "X" + Format(i, "00"), PLCIOMappingINIFile)
            OutputYName(0, i) = ReadProgData("DO_CHT", "lblY" + Format(i, "00"), "Y" + Format(i, "00"), PLCIOMappingINIFile)

            InputXName(1, i) = ReadProgData("DI_CHS", "lblX" + Format(i, "00"), "X" + Format(i, "00"), PLCIOMappingINIFile)
            OutputYName(1, i) = ReadProgData("DO_CHS", "lblY" + Format(i, "00"), "Y" + Format(i, "00"), PLCIOMappingINIFile)

            InputXName(2, i) = ReadProgData("DI_ENG", "lblX" + Format(i, "00"), "X" + Format(i, "00"), PLCIOMappingINIFile)
            OutputYName(2, i) = ReadProgData("DO_ENG", "lblY" + Format(i, "00"), "Y" + Format(i, "00"), PLCIOMappingINIFile)
        Next
        For i = 0 To 95
            WriteProgData("FormMaintance", "lblX" + Format(i, "00"), InputXName(0, i), cht_file)
            WriteProgData("FormMaintance", "lblY" + Format(i, "00"), OutputYName(0, i), cht_file)
            WriteProgData("FormMaintance", "lblX" + Format(i, "00"), InputXName(1, i), chs_file)
            WriteProgData("FormMaintance", "lblY" + Format(i, "00"), OutputYName(1, i), chs_file)
            WriteProgData("FormMaintance", "lblX" + Format(i, "00"), InputXName(2, i), eng_file)
            WriteProgData("FormMaintance", "lblY" + Format(i, "00"), OutputYName(2, i), eng_file)
        Next
    End Sub
    '取得 LOCK 字串
    Public Function GetLockXTrue(ByVal ParamArray Lock() As Integer) As String
        Dim i As Integer
        Dim sstr As String
        sstr = ""
        For i = 0 To Lock.GetUpperBound(0)
            If PLC_X(Lock(i)) = "0" Then sstr = sstr + InputXName(SystemLanguage, Lock(i)) + "= ON" + ", "
        Next
        Return sstr

    End Function
    Public Function GetLockXFalse(ByVal ParamArray Lock() As Integer) As String
        Dim i As Integer
        Dim sstr As String
        sstr = ""
        For i = 0 To Lock.GetUpperBound(0)
            If PLC_X(Lock(i)) = "1" Then sstr = sstr + InputXName(SystemLanguage, Lock(i)) + "= OFF" + ", "
        Next
        Return sstr
    End Function

    Public Function GetLockYTrue(ByVal ParamArray Lock() As Integer) As String
        Dim i As Integer
        Dim sstr As String
        sstr = ""
        For i = 0 To Lock.GetUpperBound(0)
            If PLC_Y(Lock(i)) = "0" Then sstr = sstr + OutputYName(SystemLanguage, Lock(i)) + "= ON" + ", "
        Next
        Return sstr

    End Function
    Public Function GetLockYFalse(ByVal ParamArray Lock() As Integer) As String
        Dim i As Integer
        Dim sstr As String
        sstr = ""
        For i = 0 To Lock.GetUpperBound(0)
            If PLC_Y(Lock(i)) = "1" Then sstr = sstr + OutputYName(SystemLanguage, Lock(i)) + "= OFF" + ", "
        Next
        Return sstr

    End Function
End Module

Imports Microsoft.Win32
Imports System.Runtime.InteropServices


Module Module_Alarm_Task

    Public Const MAX_ALARM As Integer = 200
    Public Const MAX_LANGUAGE As Integer = 3
    Public AlarmList(MAX_ALARM) As String
    'Public AlarmListENG(MAX_ALARM) As String
    Public AlarmState(MAX_ALARM) As Integer    'Alarm 狀態, 用來避免重覆
    Public AlarmError(MAX_ALARM) As Boolean   '是否有ALARM, 
    Public AlarmList1(MAX_LANGUAGE, MAX_ALARM) As String  '三語ALARM 訊息

    'ALARM TASK 使用

    Public bolAlarmBZ As Boolean
    Public Alarm_String As String

    Public Alarm_status As Boolean
    Public Alarm_Length As Integer
    Public scroll_index As Integer
    Public Alarm_Text As String
    Public PopupFlag As Boolean = False
    Public ProcessEndAlarm_Err As Boolean
    Public PLCAlarm_String As String

    Public Vacuum_Error As Boolean

    <StructLayout(LayoutKind.Sequential)> Public Structure sAlarmOption
        Public None As Boolean
        Public Alarm As Boolean
        Public Abort As Boolean
    End Structure
    Public AlarmOptions(MAX_ALARM) As sAlarmOption

    'MFC 異常檢查

    <StructLayout(LayoutKind.Sequential)> Structure AlarmFormRecords
        Public Code As String
        Public [Date] As String
        Public Time As String
        Public Description As String
    End Structure
    Public AlarmRecord(MAX_ALARM) As AlarmFormRecords

    Public CAlarmError(MAX_ALARM) As Class_SetTimer

    Enum Alarm_Name
        PLC_Error = 0
        CDA_Error = 1
        N2_Error = 2
        WATER_Error1 = 3
        WATER_Error2 = 4
        EMO_Error = 5
        MPOL_Error = 6
        OVER_PRESS_Error1 = 7
        OVER_PRESS_Error2 = 8
        OVER_PRESS_Error3 = 9
        OVER_PRESS_Error4 = 10
        OVER_PRESS_Error5 = 11
        OVER_PRESS_Error6 = 12
        VACUUM_Error = 13
        TOP_FLOW_Error1 = 14
        BOT_FLOW_Error1 = 15
        TOP_FLOW_Error2 = 16
        BOT_FLOW_Error2 = 17
        TOP_FLOW_Error3 = 18
        BOT_FLOW_Error3 = 19
        TOP_FLOW_Error4 = 20
        BOT_FLOW_Error4 = 21
        TOP_FLOW_Error5 = 22
        BOT_FLOW_Error5 = 23
        TOP_FLOW_Error6 = 24
        BOT_FLOW_Error6 = 25
        BUND_DOWN_Error1 = 26
        BUND_DOWN_Error2 = 27
        BUND_DOWN_Error3 = 28
        BUND_DOWN_Error4 = 29
        BUND_DOWN_Error5 = 30
        BUND_DOWN_Error6 = 31
        TOP_OVTEMP_Error1 = 32
        BOT_OVTEMP_Error1 = 33
        TOP_OVTEMP_Error2 = 34
        BOT_OVTEMP_Error2 = 35
        TOP_OVTEMP_Error3 = 36
        BOT_OVTEMP_Error3 = 37
        TOP_OVTEMP_Error4 = 38
        BOT_OVTEMP_Error4 = 39
        TOP_OVTEMP_Error5 = 40
        BOT_OVTEMP_Error5 = 41
        TOP_OVTEMP_Error6 = 42
        BOT_OVTEMP_Error6 = 43

        BOND_UP_Error1 = 44
        BOND_UP_Error2 = 45
        BOND_UP_Error3 = 46
        BOND_UP_Error4 = 47
        BOND_UP_Error5 = 48
        BOND_UP_Error6 = 49

        BOND_FORCE_Error1 = 50
        BOND_FORCE_Error2 = 51
        BOND_FORCE_Error3 = 52
        BOND_FORCE_Error4 = 53
        BOND_FORCE_Error5 = 54
        BOND_FORCE_Error6 = 55

        TOP_HEATER_Error1 = 56
        BOT_HEATER_Error1 = 57
        TOP_HEATER_Error2 = 58
        BOT_HEATER_Error2 = 59
        TOP_HEATER_Error3 = 60
        BOT_HEATER_Error3 = 61
        TOP_HEATER_Error4 = 62
        BOT_HEATER_Error4 = 63
        TOP_HEATER_Error5 = 64
        BOT_HEATER_Error5 = 65
        TOP_HEATER_Error6 = 66
        BOT_HEATER_Error6 = 67

        DP_LIFE_Error = 68
        TOP_HEATER_LIFE_Error1 = 69
        BOT_HEATER_LIFE_Error1 = 70
        TOP_HEATER_LIFE_Error2 = 71
        BOT_HEATER_LIFE_Error2 = 72
        TOP_HEATER_LIFE_Error3 = 73
        BOT_HEATER_LIFE_Error3 = 74
        TOP_HEATER_LIFE_Error4 = 75
        BOT_HEATER_LIFE_Error4 = 76
        TOP_HEATER_LIFE_Error5 = 77
        BOT_HEATER_LIFE_Error5 = 78
        TOP_HEATER_LIFE_Error6 = 79
        BOT_HEATER_LIFE_Error6 = 80
        ORING_LIFE_Error = 81
        CALIBRATION_Error = 82

        HeaterOverLoadError1 = 83 '沒用到
        HeaterOverLoadError2 = 84
        HeaterOverLoadError3 = 85
        HeaterOverLoadError4 = 86
        HeaterOverLoadError5 = 87
        HeaterOverLoadError6 = 88

        ProcessTopTempError1 = 89
        ProcessBotTempError1 = 90
        ProcessPressError1 = 91
        FirstConatctError1 = 92
        ProcessTopTempError2 = 93
        ProcessBotTempError2 = 94
        ProcessPressError2 = 95
        FirstConatctError2 = 96
        ProcessTopTempError3 = 97
        ProcessBotTempError3 = 98
        ProcessPressError3 = 99
        FirstConatctError3 = 100
        ProcessTopTempError4 = 101
        ProcessBotTempError4 = 102
        ProcessPressError4 = 103
        FirstConatctError4 = 104
        ProcessTopTempError5 = 105
        ProcessBotTempError5 = 106
        ProcessPressError5 = 107
        FirstConatctError5 = 108
        ProcessTopTempError6 = 109
        ProcessBotTempError6 = 110
        ProcessPressError6 = 111
        FirstConatctError6 = 112

        OilPumpOverLoadError1 = 113
        OilPumpOverLoadError2 = 114
        OilPumpOverLoadError3 = 115
        OilPumpOverLoadError4 = 116
        OilPumpOverLoadError5 = 117
        OilPumpOverLoadError6 = 118
        SaftyGate1Error = 119
        SaftyGate2Error = 120
        TOP_TEMP_Error1 = 121
        BOT_TEMP_Error1 = 122
        TOP_TEMP_Error2 = 123
        BOT_TEMP_Error2 = 124
        TOP_TEMP_Error3 = 125
        BOT_TEMP_Error3 = 126
        TOP_TEMP_Error4 = 127
        BOT_TEMP_Error4 = 128
        TOP_TEMP_Error5 = 129
        BOT_TEMP_Error5 = 130
        TOP_TEMP_Error6 = 131
        BOT_TEMP_Error6 = 132
        DPOverCurrentError = 133
        ATM_SensorError = 134
        MFC01_DeviceLife = 135
        MFC02_DeviceLife = 136
        MFC01_Error = 137
        MFC02_Error = 138
        DP_OverTemp_Error = 139
        DP_OverTempOff_Error = 140
        'Add By Vincent 20190416 ------------------ Start
        Puller1Open_Error = 141
        Puller1Close_Error = 142
        Door1Open_Error = 143
        Door1Close_Error = 144
        Door1CloseAlarm_Error = 145

        PumpingAlarm_Error = 146
        WaterLeak_Error = 147
        'Add By Vincent 20190416 ------------------ End
    End Enum
    'Add By Vincent 20190416 ------------------ Start
    Public Door1CloseAlarm_Error As Boolean
    Public PumpingAlarm_Error As Boolean
    'Add By Vincent 20190416 ------------------ End

    '讀取警報字串
    Public Total_Alarm_Num As Integer
    'Alarm Timer Set

    Public TOPFLOWTIME As Integer
    Public BOTFLOWTIME As Integer
    Public BONDDOWNTIME As Integer
    Public BONDUPTIME As Integer
    Public TOPOVERTEMPTIME As Integer
    Public BOTOVERTEMPTIME As Integer
    Public BONDFORCETIME As Integer
    Public TOPTEMPRUNTIME As Integer
    Public BOTTEMPRUNTIME As Integer
    Public FIRSTCONTACTTIME As Integer
    Public PROCESSTOPTEMPTIME As Integer
    Public PROCESSBOTTEMPTIME As Integer
    Public PROCESSBONDFORCETIME As Integer
    Public CURRENTMONITORTIME As Integer
    'Add By Vincent 20190416 ------------------ Start
    Public PULLERTIME As Integer
    Public DOORTIME As Integer
    Public PUMPINGTIME As Integer
    Public PUMPINGVACUUM As Double
    'Add By Vincent 20190416 ------------------ End

#Region "Play Alarm Sound"
    ' Play Mp3, Wav  Start 
    Public BZReset_Status As Boolean
    'Public AlarmPlay As New CAlarmPlaySound(".\ALARM.INI")
    'Public Class CAlarmPlaySound
    '    Dim PlayAlarm As New WMPLib.WindowsMediaPlayer
    '    Dim timer1 As New Timer
    '    Dim PLCLinkCount As Integer
    '    Sub New(ByVal sfile As String)
    '        Dim sstr As String
    '        sstr = ReadProgData("PROGRAM", "ALARM_SOUND", ProgramDir + "ALARM.MID", sfile)
    '        If Not IO.File.Exists(sstr) Then
    '            sstr = ProgramDir + "ALARM.MID"
    '        End If
    '        WriteProgData("PROGRAM", "ALARM_SOUND", sstr, sfile)
    '        PlayAlarm.URL = ProgramDir + sstr
    '        timer1.Interval = 500
    '        timer1.Enabled = True
    '        AddHandler timer1.Tick, AddressOf Timer1_Tick
    '    End Sub

    '    Private Sub Timer1_Tick()
    '        If CommLivePLC = False Then
    '            PLCLinkCount += 1
    '        Else
    '            PLCLinkCount = 0
    '        End If
    '        If PLCLinkCount > 200 Then
    '            PlayMp3(CommLivePLC = False And Not BZReset_Status)
    '        Else
    '            PlayMp3(Check_PLC_Y(DoBZIndex))
    '        End If
    '    End Sub
    '    Private Sub PlayMp3(ByVal cond As Boolean)
    '        Static State As Integer
    '        Select Case State
    '            Case 0
    '                If cond Then
    '                    'My.Computer.Audio.Play(SoundFile)
    '                    PlayAlarm.controls.play()
    '                    State = 1
    '                Else
    '                    'My.Computer.Audio.Stop()
    '                    PlayAlarm.controls.stop()
    '                End If
    '            Case 1
    '                If cond = False Then
    '                    'My.Computer.Audio.Stop()
    '                    PlayAlarm.controls.stop()
    '                    State = 0
    '                Else
    '                    If PlayAlarm.playState.wmppsStopped Then
    '                        State = 0
    '                    End If
    '                End If
    '        End Select
    '    End Sub

    'End Class
    ' Play WAV, MP3, MID ---End
#End Region
    '讀取警報字串
    Public Sub ReadFormAlarmstring(ByVal sfile As String)
        Dim ss, ll(2) As String
        Dim i, j As Integer
        ll(0) = "ALARM_CHT"
        ll(1) = "ALARM_CHS"
        ll(2) = "ALARM_ENG"
        Total_Alarm_Num = Val(ReadProgData(ll(0), "ALARM_NUM", "0", sfile))
        If Total_Alarm_Num > 0 Then
            For j = 0 To 2
                For i = 0 To Total_Alarm_Num
                    ss = "ALARM" & Format(i, "00")
                    AlarmList1(j, i) = ReadProgData(ll(j), ss, "Unknow Error!", sfile)
                    If j = 1 Then
                        AlarmList1(j, i) = StrConv(AlarmList1(0, i), VbStrConv.SimplifiedChinese, 2052)
                    Else
                        AlarmList1(j, i) = ReadProgData(ll(j), ss, "Unknow Error!", sfile)
                    End If
                Next
            Next
        End If
        For i = 0 To MAX_ALARM
            CAlarmError(i) = New Class_SetTimer
        Next

        ReadAlarmTimeSetup(AlarmINIFile)
        'WriteAlarmTimeSetup(AlarmINIFile)
        'Public TOPFLOWTIME As Integer = 5
        'Public BOTFLOWTIME As Integer = 5
        'Public BONDDOWNTIME As Integer = 20
        'Public BONDUPTIME As Integer = 20
        'Public TOPOVERTEMPTIME As Integer = 5
        'Public BOTOVERTEMPTIME As Integer = 5
        'Public BONDFORCETIME As Integer = 15
        'Public TOPTEMPRUNTIME As Integer = 15
        'Public BOTTEMPRUNTIME As Integer = 15
        'Public FIRSTCONTACTTIME As Integer = 30
        'Public PROCESSTOPTEMPTIME As Integer = 10
        'Public PROCESSBOTTEMPTIME As Integer = 10
        'Public PROCESSBOTTEMPTIME As Integer = 10

    End Sub

    Public Sub ReadAlarmTimeSetup(ByVal sfile As String)
        'Read Alarm Timer
        TOPFLOWTIME = Val(ReadProgData("ALARM_TIMER", "TOPFLOWTIME", "5", sfile))
        BOTFLOWTIME = Val(ReadProgData("ALARM_TIMER", "BOTFLOWTIME", "5", sfile))
        BONDDOWNTIME = Val(ReadProgData("ALARM_TIMER", "BONDDOWNTIME", "20", sfile))
        BONDUPTIME = Val(ReadProgData("ALARM_TIMER", "BONDUPTIME", "20", sfile))
        TOPOVERTEMPTIME = Val(ReadProgData("ALARM_TIMER", "TOPOVERTEMPTIME", "5", sfile))
        BOTOVERTEMPTIME = Val(ReadProgData("ALARM_TIMER", "BOTOVERTEMPTIME", "5", sfile))
        BONDFORCETIME = Val(ReadProgData("ALARM_TIMER", "BONDFORCETIME", "15", sfile))
        TOPTEMPRUNTIME = Val(ReadProgData("ALARM_TIMER", "TOPTEMPRUNTIME", "30", sfile))
        BOTTEMPRUNTIME = Val(ReadProgData("ALARM_TIMER", "BOTTEMPRUNTIME", "30", sfile))
        FIRSTCONTACTTIME = Val(ReadProgData("ALARM_TIMER", "FIRSTCONTACTTIME", "60", sfile))
        PROCESSTOPTEMPTIME = Val(ReadProgData("ALARM_TIMER", "PROCESSTOPTEMPTIME", "30", sfile))
        PROCESSBOTTEMPTIME = Val(ReadProgData("ALARM_TIMER", "PROCESSBOTTEMPTIME", "30", sfile))
        PROCESSBONDFORCETIME = Val(ReadProgData("ALARM_TIMER", "PROCESSBONDFORCETIME", "30", sfile))
        CURRENTMONITORTIME = Val(ReadProgData("ALARM_TIMER", "CURRENTMONITORTIME", "30", sfile))
        'Add By Vincent 20190416 ------------------ Start
        PULLERTIME = Val(ReadProgData("ALARM_TIMER", "PULLERTIME", "15", sfile))
        DOORTIME = Val(ReadProgData("ALARM_TIMER", "DOORTIME", "30", sfile))
        PUMPINGTIME = Val(ReadProgData("ALARM_TIMER", "PUMPINGTIME", "15", sfile))
        PUMPINGVACUUM = Val(ReadProgData("ALARM_TIMER", "PUMPINGVACUUM", "700", sfile))
        If PUMPINGVACUUM > 700 Then
            PUMPINGVACUUM = 700
        End If
        If PUMPINGVACUUM < 0.01 Then
            PUMPINGVACUUM = 0.01
        End If
        'Add By Vincent 20190416 ------------------ End
    End Sub
    Public Sub WriteAlarmTimeSetup(ByVal sfile As String)
        WriteProgData("ALARM_TIMER", "TOPFLOWTIME", TOPFLOWTIME, sfile)
        WriteProgData("ALARM_TIMER", "BOTFLOWTIME", BOTFLOWTIME, sfile)
        WriteProgData("ALARM_TIMER", "BONDDOWNTIME", BONDDOWNTIME, sfile)
        WriteProgData("ALARM_TIMER", "BONDUPTIME", BONDUPTIME, sfile)
        WriteProgData("ALARM_TIMER", "TOPOVERTEMPTIME", TOPOVERTEMPTIME, sfile)
        WriteProgData("ALARM_TIMER", "BOTOVERTEMPTIME", BOTOVERTEMPTIME, sfile)
        WriteProgData("ALARM_TIMER", "BONDFORCETIME", BONDFORCETIME, sfile)
        WriteProgData("ALARM_TIMER", "TOPTEMPRUNTIME", TOPTEMPRUNTIME, sfile)
        WriteProgData("ALARM_TIMER", "BOTTEMPRUNTIME", BOTTEMPRUNTIME, sfile)
        WriteProgData("ALARM_TIMER", "FIRSTCONTACTTIME", FIRSTCONTACTTIME, sfile)
        WriteProgData("ALARM_TIMER", "PROCESSTOPTEMPTIME", PROCESSTOPTEMPTIME, sfile)
        WriteProgData("ALARM_TIMER", "PROCESSBOTTEMPTIME", PROCESSBOTTEMPTIME, sfile)
        WriteProgData("ALARM_TIMER", "PROCESSBONDFORCETIME", PROCESSBONDFORCETIME, sfile)
        WriteProgData("ALARM_TIMER", "CURRENTMONITORTIME", CURRENTMONITORTIME, sfile)
        'Add By Vincent 20190416 ------------------ Start
        WriteProgData("ALARM_TIMER", "PULLERTIME", PULLERTIME, sfile)
        WriteProgData("ALARM_TIMER", "DOORTIME", DOORTIME, sfile)
        WriteProgData("ALARM_TIMER", "PUMPINGTIME", PUMPINGTIME, sfile)
        WriteProgData("ALARM_TIMER", "PUMPINGVACUUM", PUMPINGVACUUM, sfile)
        'Add By Vincent 20190416 ------------------ End
    End Sub



    Public StopSort As Boolean
    Public Function AddAlarmToListView(ByRef ClistView As ListView, ByVal ParamArray sStr() As String) As String
        Static AlarmNo As Integer
        Static ListCount As Integer
        Dim rstr As String
        Dim i As Integer
        On Error Resume Next
        StopSort = True
        For i = 0 To ClistView.Items.Count - 1
            ClistView.Items(i).ForeColor = Color.Black
        Next
        If ListCount > 1000 Then
            ClistView.Items.Clear()
            ListCount = 0
        End If
        If sStr.Length > 0 Then
            ClistView.Items.Add(AlarmNo.ToString)
            If sStr.Length > 1 Then
                For i = 0 To sStr.Length - 1
                    ClistView.Items(ClistView.Items.Count - 1).SubItems.Add(sStr(i))
                    rstr = rstr + sStr(i)
                Next
            End If
            ClistView.Items(ClistView.Items.Count - 1).ForeColor = Color.Red
            AlarmNo += 1
            ListCount += 1
        End If

        StopSort = False
        Return rstr
    End Function

    Public Sub ChangeListViewColHeater(ByRef cList As ListView)
        Dim sstr, pstr(5) As String
        'cList.Columns(0).Width = 15
        'cList.Columns(1).Width = 50
        'cList.Columns(2).Width = 30
        'cList.Columns(3).Width = 30
        'cList.Columns(4).Width = 30
        'cList.Columns(5).Width = 200
        Dim i, j As Integer
        For i = 0 To 5
            If cList.Columns(i).Text.StartsWith("> ") Then
                pstr(i) = "> "
            ElseIf cList.Columns(i).Text.StartsWith("< ") Then
                pstr(i) = "< "
            Else
                pstr(i) = ""
            End If
        Next
        cList.Columns(0).Text = pstr(0) + AdjustText(GetLangText("No.", "No."), 6)
        cList.Columns(1).Text = pstr(1) + AdjustText(GetLangText("使用者", "User"), 18)
        cList.Columns(2).Text = pstr(2) + AdjustText(GetLangText("日期", "Date"), 12)
        cList.Columns(3).Text = pstr(3) + AdjustText(GetLangText("時間", "Time"), 12)
        cList.Columns(4).Text = pstr(4) + AdjustText(GetLangText("代碼", "Code"), 10)
        cList.Columns(5).Text = pstr(5) + AdjustText(GetLangText("異常說明", "Alarm Message"), 25)
        For i = 0 To 5
            cList.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.HeaderSize)
        Next
    End Sub

    Public Function AdjustText(ByVal sstr As String, ByVal Lenghth As Integer) As String
        Dim i As Integer
        Dim llen, a1, a2 As Integer
        llen = StringLen(sstr)
        a1 = (Lenghth - llen)
        If a1 < 1 Then
            Return sstr
        Else
            Return sstr + Space(a1)
        End If
    End Function
    Public Sub ClearAlarm()
        Dim i As Integer
        FormAlarms.txtAlarmList.Text = ""
        For i = 0 To MAX_ALARM
            AlarmError(i) = False
            'AlarmState(i) = 0
            If AlarmError(i) = False Then
                AlarmState(i) = 0
            End If
            'AlarmOccur(i) = False
            'AlarmClear(i) = False
        Next
        'Add By Vincent 20190416 ------------------ Start
        Door1CloseAlarm_Error = False
        PumpingAlarm_Error = False
        'Add By Vincent 20190416 ------------------ End
    End Sub

    Public AlarmOccur(200) As Boolean
    Public AlarmClear(200) As Boolean

    Public Sub AlarmRecord_Task()
        Static Control_State As Integer
        Static i, SerialNo, OldSerialNo, j, k As Integer
        Dim astr As String

        If TCPIP_Used Then
            For i = 0 To Total_Alarm_Num
                If AlarmOccur(i) = True Then
                    SanAnTCP.E2H_RPT_ALM_AlarmOccure(RemoteCIM.EQID, i, AlarmList1(2, i))
                    AlarmOccur(i) = False
                    AlarmClear(i) = True
                End If
                If AlarmClear(i) = True Then
                    If AlarmError(i) = False Then
                        SanAnTCP.E2H_RPT_ALM_AlarmClear(RemoteCIM.EQID, i, AlarmList1(2, i))
                        AlarmClear(i) = False
                        AlarmOccur(i) = False
                    End If
                End If
            Next
        End If
        AlarmMapping()

        'AlarmStringList.Clear()
        Alarm_String = ""
        CheckAlarmDateAndCreate()

        SerialNo = 0
        For i = 0 To Total_Alarm_Num
            If AlarmError(i) Or AlarmState(i) = 1 Then
                'Debug.Print("i=" + i.ToString + "  ,AlarmError(i)=" + AlarmError(i).ToString + " ,AlarmState(i)=" + AlarmState(i).ToString)
                astr = LoginUserName + vbTab + AlarmRecord(i).Time + vbTab + Format(i, " [000]  ") + vbTab + AlarmList1(SystemLanguage, i) + vbCrLf
                Alarm_String = Alarm_String + astr
                If AlarmState(i) = 0 Then '沒紀錄過
                    'FormAlarms.txtAlarmList.Text = Alarm_String
                    AlarmRecord(i).Time = ADate + "   " + TTime

                    AlarmRecord(i).Description = AddAlarmToListView(FormAlarms.ListView1, LoginUserName, ADate, TTime, Format(i, "[000]"), AlarmList1(SystemLanguage, i))
                    AppendMultiData(AlarmRecordFileName, 80, LoginUserName, ADate, TTime, Format(i, "[000]"), AlarmList1(SystemLanguage, i))
                    AlarmState(i) = 1
                    If TCPIP_Used Then
                        AlarmOccur(i) = True
                    End If
                End If
                SerialNo += 1
            Else
                'FormAlarms.txtAlarmList.Text = Alarm_String
                'AlarmState(i) = 0
            End If
        Next

        '門上升警報
        'CheckDoorUpAlarm()


        '聲音控制
        Select Case Control_State
            Case 0      '警報發生, BZ ON
                If Alarm_status Then
                    Set_MBit(DoBZIndex, DEVICE_ON)
                    Control_State = 1
                End If
            Case 1      'BZ 已 ON 等待警報消失
                If Alarm_status = False Then
                    Set_MBit(DoBZIndex, DEVICE_OFF)
                    'BZ_Status = False
                    Control_State = 0
                End If
                '若按下 BZ OFF, 則關閉警聲
                If Check_PLC_Y(DoBZIndex) Then
                    Control_State = 11
                End If
            Case 11
                If Alarm_status = False Then '已沒有ALARM..>閉嘴
                    Set_MBit(DoBZIndex, DEVICE_OFF)
                    Control_State = 2
                Else
                    If Check_PLC_Y(DoBZIndex) = False Then '有alarm但是被叫閉嘴
                        Control_State = 2
                    End If
                End If
            Case 2      'BZ 已 OFF, 等待 ALARM 消失
                bolAlarmBZ = False
                If Alarm_status = False Then
                    Control_State = 0
                    Set_MBit(DoBZIndex, DEVICE_OFF)
                    'BZ_Status = False
                End If
                '有新的Alarm產生
                If (OldSerialNo <> SerialNo) And Alarm_status Then
                    Control_State = 0
                    bolAlarmBZ = True '又開始叫了
                End If
        End Select

        '如果 SerialNo >0 表示有異常, 則顯示ALARM彈出視窗,ALARM 解除時會自動隱藏
        If SerialNo > 0 Then

            Alarm_status = True
            FormAlarms.txtAlarmList.Text = Alarm_String
            FormAlarmPopups.txtAlarmText.Text = Alarm_String
            If OldSerialNo <> SerialNo Then
                OldSerialNo = SerialNo
                FormAlarmPopups.Show()
                Alarm_status = True
                BZReset_Status = False
                'BZ_Status = True
            End If
            ' 第一次顯示ALARM彈出視窗,則設定位置.
            If PopupFlag = False Then
                'FormAlarmPopups.btnClose.Enabled = False
                FormAlarmPopups.Top = 100
                FormAlarmPopups.Left = 50
                PopupFlag = True
            End If
            'ElseIf (Output(DoDoor1UpIndex).Status = True And Check_PLC_X(DiDoor1UpIndex) = False) Then
            '    Alarm_status = True
        Else
            Alarm_status = False
            'FormAlarms.txtAlarmList.Text = ""
            FormAlarmPopups.txtAlarmText.Text = ""
            'FormAlarmPopups.btnClose.Enabled = True
            FormAlarmPopups.Hide()
            PopupFlag = False
            SerialNo = 0
            OldSerialNo = 0
        End If
    End Sub
    'Public Sub ClearAlarm()
    '    Dim i As Integer
    '    FormAlarms.txtAlarmList.Text = ""
    '    FormAlarmPopups.txtAlarmText.Text = ""
    '    FormAlarmPopups.Hide()
    '    PopupFlag = False
    '    Alarm_status = False
    '    For i = 0 To MAX_ALARM
    '        If AlarmError(i) = False Then AlarmState(i) = 0
    '        'AlarmState(i) = 0
    '    Next

    'End Sub
    'Public Sub AlarmRecord_Task()
    '    Static Control_State As Integer
    '    Static i, SerialNo, OldSerialNo, j, k As Integer
    '    Dim astr As String


    '    AlarmMapping()
    '    'AlarmStringList.Clear()
    '    Alarm_String = ""

    '    SerialNo = 0
    '    For i = 0 To Total_Alarm_Num
    '        'AlarmError(i) = False
    '        If AlarmError(i) Then
    '            SerialNo += 1
    '        End If
    '        If AlarmError(i) Or AlarmState(i) = 1 Then
    '            If AlarmState(i) = 0 Then
    '                'FormAlarms.txtAlarmList.Text = Alarm_String
    '                AlarmRecord(i).Time = ADate + "   " + TTime
    '            End If
    '            AlarmRecord(i).Description = LoginUserName + vbTab + AlarmRecord(i).Time + vbTab + Format(i, " [000]  ") + vbTab + AlarmList1(SystemLanguage, i) + vbCrLf
    '            Alarm_String = Alarm_String + AlarmRecord(i).Description

    '            If AlarmState(i) = 0 Then
    '                'FormAlarms.txtAlarmList.Text = Alarm_String
    '                'AlarmRecord(i).Time = ADate + "   " + TTime
    '                'AddAlarmToListView(FormAlarms.ListView1, AlarmRecord(i).Description)
    '                AppendMultiData(AlarmRecordFileName, 256, AlarmRecord(i).Description)

    '                AddAlarmToListView(FormAlarms.ListView1, LoginUserName, ADate, TTime, Format(i, "[000]"), AlarmList1(SystemLanguage, i))
    '                'AppendMultiData(AlarmRecordFileName, 80, LoginUserName, ADate, TTime, Format(i, "[000]"), AlarmList1(SystemLanguage, i))
    '                AlarmState(i) = 1
    '            End If


    '        Else
    '            AlarmRecord(i).Description = ""
    '            Alarm_String = Alarm_String + AlarmRecord(i).Description
    '            'FormAlarms.txtAlarmList.Text = Alarm_String
    '            'AlarmState(i) = 0
    '        End If

    '    Next

    '    '聲音控制
    '    Select Case Control_State
    '        Case 0      '警報發生, BZ ON
    '            If Alarm_status Then
    '                Set_MBit(DoBZIndex, DEVICE_ON)
    '                Control_State = 1
    '            End If
    '        Case 1      'BZ 已 ON 等待警報消失
    '            If Alarm_status = False And SerialNo = 0 Then
    '                Set_MBit(DoBZIndex, DEVICE_OFF)
    '                'BZ_Status = False
    '                Control_State = 0
    '            End If
    '            '若按下 BZ OFF, 則關閉警聲
    '            If Check_PLC_Y(DoBZIndex) Then
    '                Control_State = 11
    '            End If
    '        Case 11
    '            If Alarm_status = False And SerialNo = 0 Then
    '                Set_MBit(DoBZIndex, DEVICE_OFF)
    '                Control_State = 2
    '            Else
    '                If Check_PLC_Y(DoBZIndex) = False Then
    '                    Control_State = 2
    '                End If
    '            End If
    '        Case 2      'BZ 已 OFF, 等待 ALARM 消失
    '            If Alarm_status = False Then
    '                Control_State = 0
    '                Set_MBit(DoBZIndex, DEVICE_OFF)
    '                'BZ_Status = False
    '            End If
    '            If (OldSerialNo <> SerialNo) And Alarm_status Then
    '                Control_State = 0
    '            End If
    '    End Select

    '    '如果 SerialNo >0 表示有異常, 則顯示ALARM彈出視窗,ALARM 解除時會自動隱藏
    '    If SerialNo > 0 Then

    '        Alarm_status = True
    '        FormAlarms.txtAlarmList.Text = Alarm_String
    '        FormAlarmPopups.txtAlarmText.Text = Alarm_String
    '        If OldSerialNo <> SerialNo Then
    '            Alarm_String = ""
    '            OldSerialNo = SerialNo
    '            FormAlarmPopups.Show()
    '            Alarm_status = True
    '            'BZ_Status = True
    '        End If
    '        ' 第一次顯示ALARM彈出視窗,則設定位置.
    '        If PopupFlag = False Then
    '            'FormAlarmPopups.btnClose.Enabled = False
    '            FormAlarmPopups.Top = 100
    '            FormAlarmPopups.Left = 50
    '            PopupFlag = True
    '        End If
    '    Else
    '        'Alarm_status = False
    '        'FormAlarms.txtAlarmList.Text = ""
    '        'FormAlarmPopups.txtAlarmText.Text = ""
    '        'FormAlarmPopups.btnClose.Enabled = True
    '        'FormAlarmPopups.Hide()
    '        'PopupFlag = False
    '        SerialNo = 0
    '        OldSerialNo = 0
    '    End If
    'End Sub

    Public Sub PLCAlarm_Log(ByVal strErr As String)
        Static Control_State As Integer
        Static i, SerialNo, OldSerialNo, j, k As Integer
        Dim astr As String
        Dim tempstr As String
        PLCAlarm_String = ""
        CheckPLCAlarmDateAndCreate()
        SerialNo = 0

        astr = LoginUserName + vbTab + ADate + "   " + TTime + vbTab + Format(i, " [000]  ") + vbTab + strErr + vbCrLf
        PLCAlarm_String = PLCAlarm_String + astr

        'tempstr = AddAlarmToListView(FormAlarms.ListView1, LoginUserName, ADate, TTime, Format(i, "[000]"), strErr)
        AppendMultiData(PLCAlarmRecordFileName, 80, LoginUserName, ADate, TTime, Format(i, "[000]"), PLCAlarm_String)
        i += 1
    End Sub
    '門上升警報 for B222
    Public Sub CheckDoorUpAlarm()
        If Output(DoDoor1UpIndex).Status = True And Check_PLC_X(DiDoor1UpIndex) = False Then
            Set_MBit(DoBZIndex, DEVICE_ON)
        ElseIf bolAlarmBZ = False Then 'Alarm也不叫了
            Set_MBit(DoBZIndex, DEVICE_OFF)
        End If

    End Sub

    '對應警報 的狀態點
    Public Sub AlarmMapping()
        Dim i, j As Integer
        i = 0
        'Public TOPFLOWTIME As Integer = 5
        'Public BOTFLOWTIME As Integer = 5
        'Public BONDDOWNTIME As Integer = 20
        'Public BONDUPTIME As Integer = 20
        'Public TOPOVERTEMPTIME As Integer = 5
        'Public BOTOVERTEMPTIME As Integer = 5
        'Public BONDFORCETIME As Integer = 15
        'Public TOPTEMPRUNTIME As Integer = 15
        'Public BOTTEMPRUNTIME As Integer = 15
        'Public FIRSTCONTACTTIME As Integer = 30
        'Public PROCESSTOPTEMPTIME As Integer = 10
        'Public PROCESSBOTTEMPTIME As Integer = 10
        'Public PROCESSBONDFORCETIME As Integer = 10
        AlarmError(Alarm_Name.PLC_Error) = Not CommLivePLC
        If CommLivePLC Then
            AlarmError(Alarm_Name.CDA_Error) = Not Check_PLC_X(DiCDAIndex)
            AlarmError(Alarm_Name.N2_Error) = Not Check_PLC_X(DiN2Index)
            AlarmError(Alarm_Name.WATER_Error1) = Not Check_PLC_X(DiWater01Index)
            'AlarmError(Alarm_Name.WATER_Error2) = Not Check_PLC_X(DiWater02Index)
            AlarmError(Alarm_Name.EMO_Error) = Not Check_PLC_X(DiEMOIndex)
            AlarmError(Alarm_Name.MPOL_Error) = Check_PLC_X(DiDPFailIndex)
            AlarmError(Alarm_Name.DPOverCurrentError) = CAlarmError(Alarm_Name.DPOverCurrentError).Higher(Val(SystemParameters.PumpCurrentAlarmTime), Check_PLC_Y(DoMPIndex), Val(SystemParameters.PumpCurrentLimit), MPCurrent)
            'AlarmError(Alarm_Name.SaftyGate1Error) = (Not Check_PLC_X(DiDoor1UpIndex)) And (Not Check_PLC_X(DiSaftyGate01Index) And Check_PLC_Y(DoDoor1UpIndex))
            'AlarmError(Alarm_Name.SaftyGate1Error) = (Not Check_PLC_X(DiDoor1UpIndex) Or Not Check_PLC_X(DiDoor1DownIndex)) And (Not Check_PLC_X(DiSaftyGate01Index) And Check_PLC_Y(DoDoor1UpIndex))
            'AlarmError(Alarm_Name.SaftyGate2Error) = Not Check_PLC_X(DiSaftyGate02Index) And Check_PLC_Y(DoDoor2UpIndex)
            AlarmError(Alarm_Name.SaftyGate1Error) = Check_PLC_M(DoSaftyGateAlarmIndex)
            AlarmError(Alarm_Name.WaterLeak_Error) = Check_PLC_X(DiWaterLeakIndex)

            For i = 0 To MAXPLATE
                'AlarmError(Alarm_Name.BUND_DOWN_Error1 + i) = CAlarmError(Alarm_Name.BUND_DOWN_Error1 + i).CheckAlarm(BONDDOWNTIME, Check_PLC_Y(DoBondDown01Index + i * 4), Check_PLC_X(DiBondDown01Index + i * 2))
                AlarmError(Alarm_Name.OVER_PRESS_Error1 + i) = (PressPV(i) > Val(SystemParameters.HighPressureLimit)) ' (PressPV(i) > (PRESS_MAX + 100))

                If FlowMeterMode Then
                    AlarmError(Alarm_Name.TOP_FLOW_Error1 + i * 2) = CAlarmError(Alarm_Name.TOP_FLOW_Error1 + i * 2).Lower(TOPFLOWTIME, True, Val(SystemParameters.LowFlowAlarm), FlowRead(i).GetTopFLow) 'Check_PLC_Y(78)  ' CAlarmError(i).Run(Check_PLC_X(DiEMOIndex) = False, 2)
                    AlarmError(Alarm_Name.BOT_FLOW_Error1 + i * 2) = CAlarmError(Alarm_Name.BOT_FLOW_Error1 + i * 2).Lower(BOTFLOWTIME, True, Val(SystemParameters.LowFlowAlarm), FlowRead(i).GetBotFLow) 'Check_PLC_Y(79)  '
                Else
                    AlarmError(Alarm_Name.TOP_FLOW_Error1 + i * 2) = Not Check_PLC_X(DiTopWater01Index + i * 2)
                    AlarmError(Alarm_Name.BOT_FLOW_Error1 + i * 2) = Not Check_PLC_X(DiBotWater01Indx + i * 2)
                End If

                'AlarmError(Alarm_Name.TOP_FLOW_Error1 + i * 2) = Not Check_PLC_X(DiTopWater01Index + i * 2)
                'AlarmError(Alarm_Name.BOT_FLOW_Error1 + i * 2) = Not Check_PLC_X(DiBotWater01Indx + i * 2)




                AlarmError(Alarm_Name.TOP_OVTEMP_Error1 + i * 2) = CAlarmError(Alarm_Name.TOP_OVTEMP_Error1 + i * 2).Lower(TOPOVERTEMPTIME, True, TopTempPV(i), Val(SystemParameters.HighTempLimit)) '(TopTempPV > Val(SystemParameters.HighTempLimit))
                AlarmError(Alarm_Name.BOT_OVTEMP_Error1 + i * 2) = CAlarmError(Alarm_Name.BOT_OVTEMP_Error1 + i * 2).Lower(BOTOVERTEMPTIME, True, BotTempPV(i), Val(SystemParameters.HighTempLimit)) ' (BotTempPV > Val(SystemParameters.HighTempLimit))
                'AlarmError(Alarm_Name.BOND_UP_Error1 + i) = CAlarmError(Alarm_Name.BOND_UP_Error1 + i).CheckAlarm(BONDUPTIME, Check_PLC_Y(DoBondUp01Index + i * 5), Check_PLC_X(DiBondUp01Index + i * 5) Or Check_PLC_M(Do1stContactOK01Index + i))

                AlarmError(Alarm_Name.BOND_FORCE_Error1 + i) = CAlarmError(Alarm_Name.BOND_FORCE_Error1 + i).CheckValueAction(Check_PLC_M(DoBondForce01Index + i), PressSV(i), PressPV(i), Val(SystemParameters.PressureRange), BONDFORCETIME)

                Dim ttempSV, btempSV As Integer
                Dim ttempPV, btempPV As Integer
                ttempSV = TempCal(i).SetTICTopTemp(Get_PLC_R1100(DAProcessTemp01Index + i * 4))
                btempSV = TempCal(i).SetTICBotTemp(Get_PLC_R1100(DAProcessTemp04Index + i * 4)) 'ttempSV ''Modified by Vincent 20180419 
                If GetTrue01Boolean(SystemParameters.SplitTopBotTemp) = False Then
                    btempSV = ttempSV
                End If
                ttempPV = TopTempPV(i) 'TempCal(i).SetTICTopTemp(Get_PLC_R1000(ADTopTemp01Index + i * 2))
                btempPV = BotTempPV(i)
                AlarmError(Alarm_Name.TOP_TEMP_Error1 + i * 2) = CAlarmError(Alarm_Name.TOP_TEMP_Error1 + i * 2).CheckValueAction(Check_PLC_Y(DoHeater01Index + i), ttempSV, ttempPV, Val(SystemParameters.ProcessTempRange), TOPTEMPRUNTIME)
                AlarmError(Alarm_Name.BOT_TEMP_Error1 + i * 2) = CAlarmError(Alarm_Name.BOT_TEMP_Error1 + i * 2).CheckValueAction(Check_PLC_Y(DoHeater01Index + i), btempSV, btempPV, Val(SystemParameters.ProcessTempRange), BOTTEMPRUNTIME)
                AlarmError(Alarm_Name.HeaterOverLoadError1 + i) = Check_PLC_X(DiHeaterOL01Index + i) '沒用到 過溫用TOP_TEMP_Error1

                'Current Limit
                AlarmError(Alarm_Name.TOP_HEATER_Error1 + i * 2) = CAlarmError(Alarm_Name.TOP_HEATER_Error1 + i * 2).Lower(
                CURRENTMONITORTIME, Check_PLC_Y(DoHeater01Index + i) And (TopPowerPV(i) >= MonitorPower), MonitorCurrentLimit, TopCurrent(i))

                AlarmError(Alarm_Name.BOT_HEATER_Error1 + i * 2) = CAlarmError(Alarm_Name.BOT_HEATER_Error1 + i * 2).Lower(
                CURRENTMONITORTIME, Check_PLC_Y(DoHeater01Index + i) And (BotPowerPV(i) >= MonitorPower), MonitorCurrentLimit, BotCurrent(i))
                AlarmError(Alarm_Name.ProcessTopTempError1 + i * 4) = CAlarmError(Alarm_Name.ProcessTopTempError1 + i * 4).CheckProcessValue(Check_PLC_Y(DoHeater01Index + i) And CSubAutoProcess(i).Run, ttempSV, ttempPV, Val(SystemParameters.AbortTempRange), PROCESSTOPTEMPTIME)
                AlarmError(Alarm_Name.ProcessBotTempError1 + i * 4) = CAlarmError(Alarm_Name.ProcessBotTempError1 + i * 4).CheckProcessValue(Check_PLC_Y(DoHeater01Index + i) And CSubAutoProcess(i).Run, btempSV, btempPV, Val(SystemParameters.AbortTempRange), PROCESSBOTTEMPTIME)
                AlarmError(Alarm_Name.ProcessPressError1 + i * 4) = CAlarmError(Alarm_Name.ProcessPressError1 + i * 4).CheckProcessValue(Check_PLC_M(DoBondForce01Index + i) And CSubAutoProcess(i).Run, PressSV(i), PressPV(i), Val(SystemParameters.AbortPressureRange), PROCESSBONDFORCETIME)
                AlarmError(Alarm_Name.FirstConatctError1 + i * 4) = CAlarmError(Alarm_Name.FirstConatctError1 + i * 4).CheckAlarm(FIRSTCONTACTTIME, Check_PLC_Y(DoBondUp01Index + i * 4), Check_PLC_M(Do1stContactOK01Index + i))

            Next

            'If ProcessMode_RUN Then
            AlarmError(Alarm_Name.VACUUM_Error) = CAlarmError(Alarm_Name.VACUUM_Error).LowerVacuum(Val(SystemParameters.PumpingTime), Check_PLC_Y(DoRVIndex) And ProcessMode_RUN, GaugeCHVac, Val(RecipeNum(RecipeRunIndex).BasePressure)) 'Check_PLC_Y(78)  ' CAlarmError(i).Run(Check_PLC_X(DiEMOIndex) = False, 2)
            'AlarmError(Alarm_Name.ProcessTopTempError1 + i * 4) = CAlarmError(Alarm_Name.ProcessTopTempError1 + i * 4).CheckProcessValue(Check_PLC_Y(DoHeater01Index + i * 5) And ProcessMode_RUN, TopTempSV(i), Get_PLC_R1000(ADTopTemp01Index + i * 2), Val(SystemParameters.ProcessTempRange), PROCESSTOPTEMPTIME)
            'AlarmError(Alarm_Name.ProcessBotTempError1 + i * 4) = CAlarmError(Alarm_Name.ProcessBotTempError1 + i * 4).CheckProcessValue(Check_PLC_Y(DoHeater01Index + i * 5) And ProcessMode_RUN, BotTempSV(i), Get_PLC_R1000(ADBotTemp01Index) + i * 2, Val(SystemParameters.ProcessTempRange), PROCESSBOTTEMPTIME)
            'AlarmError(Alarm_Name.ProcessPressError1 + i * 4) = CAlarmError(Alarm_Name.ProcessPressError1 + i * 4).CheckProcessValue(Check_PLC_M(DoBondForce01Index) + i * 5 And ProcessMode_RUN, PressSV(i), PressPV(i), Val(SystemParameters.PressureRange), PROCESSBONDFORCETIME)
            'End If

            'AlarmError(Alarm_Name.ATM_SensorError) = (GaugeCHVac > Vac1ATM) And Not Check_PLC_X(Di1ATMIndex)

            For j = 0 To TotalDeviceNum
                'AlarmError(Alarm_Name.DP_LIFE_Error + j) = (DeviceLifeTime(j).Visible > 0) And (DeviceLifeTime(j).Hour >= Val(DeviceLifeTime(j).TimeSet))
                AlarmError(Alarm_Name.DP_LIFE_Error + j) = (DeviceLifeTime(j).Visible > 0) And (DeviceLifeTime(j).ResetEnable > 0) And DeviceLifeTime(j).Hour >= Val(DeviceLifeTime(j).TimeSet)
            Next

            AlarmError(Alarm_Name.DP_OverTemp_Error) = Not Check_PLC_Y(DoDPTempAlarmIndex)
            AlarmError(Alarm_Name.DP_OverTempOff_Error) = Not Check_PLC_Y(DoDPTempAlarmOFFIndex)
            'Add By Vincent 20190416 ------------------ Start
            AlarmError(Alarm_Name.Puller1Open_Error) = CAlarmError(Alarm_Name.Puller1Open_Error).CheckAlarm( _
                                                  PULLERTIME, Not Check_PLC_Y(DoPullerCloseIndex), Check_PLC_X(DiPullerOpenIndex))

            AlarmError(Alarm_Name.Puller1Close_Error) = CAlarmError(Alarm_Name.Puller1Close_Error).CheckAlarm( _
                                                   PULLERTIME, Check_PLC_Y(DoPullerCloseIndex), Check_PLC_X(DiPullerCloseIndex))

            AlarmError(Alarm_Name.Door1Open_Error) = CAlarmError(Alarm_Name.Door1Open_Error).CheckAlarm( _
                                               DOORTIME, Check_PLC_Y(DoDoor1DownIndex), Check_PLC_X(DiDoor1DownIndex))

            AlarmError(Alarm_Name.Door1Close_Error) = CAlarmError(Alarm_Name.Door1Close_Error).CheckAlarm( _
                                                   DOORTIME, Check_PLC_Y(DoDoor1UpIndex), Check_PLC_X(DiDoor1UpIndex))

            AlarmError(Alarm_Name.Door1CloseAlarm_Error) = ProcessMode_RUN And Door1CloseAlarm_Error

            'AlarmError(Alarm_Name.DPWaterFlow_Error) = DP_Flow_Used And CAlarmError(Alarm_Name.DPWaterFlow_Error).Lower(5, True, Val(SystemParameters.DPWaterFlowAlarm), DPWaterFlow)


            AlarmError(Alarm_Name.PumpingAlarm_Error) = ProcessMode_RUN And PumpingAlarm_Error

            'Add By Vincent 20190416 ------------------ End
        End If

        'DP_LIFE_Error = 68
        'TOP_HEATER_LIFE_Error1 = 69
        'BOT_HEATER_LIFE_Error1 = 70
        'TOP_HEATER_LIFE_Error2 = 71
        'BOT_HEATER_LIFE_Error2 = 72
        'TOP_HEATER_LIFE_Error3 = 73
        'BOT_HEATER_LIFE_Error3 = 74
        'TOP_HEATER_LIFE_Error4 = 75
        'BOT_HEATER_LIFE_Error4 = 76
        'TOP_HEATER_LIFE_Error5 = 77
        'BOT_HEATER_LIFE_Error5 = 78
        'TOP_HEATER_LIFE_Error6 = 79
        'BOT_HEATER_LIFE_Error6 = 80
        'ORING_LIFE_Error = 81
        'CALIBRATION_Error = 82
        'AlarmError(Alarm_Name.OilPumpOverLoadError) = Check_PLC_X(DiOilPumpOLIndex)
        '  ALARM00=CDA 空氣源異常! 
        '  ALARM01=N2 壓力不足!
        '  ALARM02 = 冷卻水壓力開關異常!
        '  ALARM03 = 緊急開關按下!
        '  ALARM04 = 真空幫浦超載!
        '  ALARM05 = 壓合壓力超過極限15000KG!
        '  ALARM06 = 腔體抽真空異常!
        '  ALARM07 = 上壓頭冷卻水流量異常!
        '  ALARM08 = 下壓頭冷卻水流量異常!
        '  ALARM09 = 壓缸未下降到定點!
        '  ALARM10 = 上壓頭超過警報溫度!
        '  ALARM11 = 下壓頭超過警報溫度!
        '  ALARM12 = 壓缸未上升到定點!
        '  ALARM13 = 製程應加壓逾時仍不加壓!
        '  ALARM14 = 上壓頭應加溫逾時仍不加溫!
        '  ALARM15 = 下壓頭應加溫逾時仍不加溫!
        '  ALARM16 = 真空幫浦保養時間到!
        '  ALARM17 = 上加熱器保養時間到!
        '  ALARM18 = 下加熱器保養時間到!
        '  ALARM19 = O - Ring週期時間到!
        '  ALARM20 = 設備校正期週期時間到!
        '  ALARM21=  PLC 通訊異常!
        '  ALARM22 = 加熱器過載!
        '  ALARM23 = 製程中上溫度異常
        '  ALARM24 = 製程中下溫度異常
        '  ALARM25 = 製程中壓力異常
        '  ALARM26 = 首次貼合未完成
        '  ALARM27 = 油壓幫浦過載!
    End Sub

End Module


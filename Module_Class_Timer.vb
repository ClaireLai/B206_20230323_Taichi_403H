Module Module_Class_Timer
    '=======================================================================================================================
    '計時檢查異常類別
    '宣告主類別: Public CV5OpenError As New Class_SetTimer
    '輸出(放在計時器中,輪詢檢查): V5OpenError = CV5OpenError.CheckAlarm(15, PLC_Y(DoV5OpenIndex) = "1", PLC_X(DiV5OpenIndex) = "1")
    Class Class_SetTimer
        '計時器物件
        Private DelayTimer As Timer
        '計時變數
        Private TickCount As Integer
        Private TickCountEnabled As Boolean
        '狀態變數
        Private Control_State As Integer
        '輸出狀態變數
        Private Sstatus As Boolean
        '是否循環計時變數
        Private CycleCount As Boolean

        '建構函數
        Sub New()
            DelayTimer = New Timer
            DelayTimer.Interval = 1000
            DelayTimer.Enabled = False
            CycleCount = False                  '預設不循環計時
            AddHandler DelayTimer.Tick, AddressOf TimerTick
            TickCount = 0
        End Sub

        '類別屬性--> 取得或設定計時值
        Public Property TimeCount() As Integer
            Get
                Return TickCount
            End Get
            Set(ByVal value As Integer)
                TickCount = value
            End Set
        End Property

        '類別屬性--> 取得或設定計時致能變數
        Public Property TimeEnabled() As Boolean
            Get
                Return TickCountEnabled
            End Get
            Set(ByVal value As Boolean)
                TickCountEnabled = value
            End Set
        End Property


        '檢查主函數, 當 "開始計時條件" 成立(TRUE)開始計時, 時間到前不斷檢查 "解除異常條件"成立(TRUE), 
        '若為TRUE 則輸出FALSE 表示時間到前完成, 若未到則輸出TRUE 表示異常
        'CheckAlarm(ByVal TimeUp As Integer, ByVal YCond As Boolean, ByVal XCond As Boolean) As Boolean
        '異常 = CheckAlarm(計時時間(秒), 開始計時條件, 解除異常條件) 
        '如: V5Error=CheckAlarm(10,PLC_Y(DoV5OpenIndex)="1" ,PLC_X(DoV5OpenIndex)="1") 
        Public Function CheckAlarm(ByVal TimeUp As Integer, ByVal YCond As Boolean, ByVal XCond As Boolean) As Boolean
            Select Case Control_State
                Case 0
                    If YCond And TimeUp > 0 And XCond = False Then
                        TickCount = TimeUp
                        TickCountEnabled = True
                        DelayTimer.Enabled = True
                        Control_State = 1
                    End If
                Case 1
                    If YCond Then
                        If XCond Then
                            Sstatus = False
                            'DelayTimer.Enabled = False
                            TickCount = 0
                        End If
                        If TickCountEnabled = False Then
                            If XCond Then
                                Sstatus = False
                                Control_State = 0
                            Else
                                Sstatus = True
                            End If
                            'DelayTimer.Enabled = False
                            TickCount = 0
                            If CycleCount Then Control_State = 0
                        End If
                    Else
                        Sstatus = False
                        DelayTimer.Enabled = False
                        TickCount = 0
                        Control_State = 0
                    End If
            End Select
            Return Sstatus
        End Function

        '檢查主函數, 當 "開始計時條件" 成立(TRUE)開始計時, 時間到前不斷檢查 "PV和SV的差值, 
        '若小於差值表示PV在設定範圍內則輸出FALSE 表示時間到前完成, 若未到則輸出TRUE 表示異常
        'CheckAlarm(ByVal TimeUp As Integer, ByVal On_Cond As Boolean, ByVal SV As Integer, ByVal PV As Integer, ByVal Limit As Integer) As Boolean
        '異常 = CheckAlarm(計時時間(秒), 開始計時條件, 解除異常條件) 
        '如: MFCError=CheckAlarm(15,PLC_Y(DoV10TIndex)="1" ,MFC SV, MFC PV, 3sccm) 
        Public Function CheckAlarm(ByVal TimeUp As Integer, ByVal On_Cond As Boolean, ByVal SV As Integer, ByVal PV As Integer, ByVal Limit As Integer) As Boolean
            Dim compare As Integer
            compare = Math.Abs(PV - SV)
            Select Case Control_State
                Case 0
                    If On_Cond And TimeUp > 0 And compare > Limit Then
                        TickCount = TimeUp
                        TickCountEnabled = True
                        DelayTimer.Enabled = True
                        Control_State = 1
                    Else
                        'Sstatus = False
                        'DelayTimer.Enabled = False
                        'TickCount = 0
                    End If
                Case 1
                    If On_Cond Then

                        If compare <= Limit Then
                            Sstatus = False
                            TickCount = 0
                            DelayTimer.Enabled = False
                            Control_State = 0
                        Else
                            If TickCountEnabled = False Then
                                If compare <= Limit Then
                                    Sstatus = False
                                    Control_State = 0
                                Else
                                    Sstatus = True
                                End If
                                TickCount = 0
                                If CycleCount Then Control_State = 0
                            End If
                        End If
                    Else
                        Sstatus = False
                        DelayTimer.Enabled = False
                        TickCount = 0
                        Control_State = 0
                    End If
            End Select
            Return Sstatus
        End Function
        '檢查主函數, 當 "開始計時條件" 成立(TRUE)開始計時, 時間到前不斷檢查 "PV和SV的差值, 
        '若小於差值表示PV在設定範圍內則輸出FALSE 表示時間到前完成, 若未到則輸出TRUE 表示異常
        'CheckAlarm(ByVal TimeUp As Integer, ByVal On_Cond As Boolean, ByVal SV As Integer, ByVal PV As Integer, ByVal Limit As Integer) As Boolean
        '異常 = CheckAlarm(計時時間(秒), 開始計時條件, 解除異常條件) 
        '如: MFCError=CheckAlarm(15,PLC_Y(DoV10TIndex)="1" ,MFC SV, MFC PV, 3sccm) 
        Public Function Higher(ByVal TimeUp As Integer, ByVal On_Cond As Boolean, ByVal SV As Integer, ByVal PV As Integer) As Boolean
            Dim compare As Integer
            Static OldTime As Integer
            compare = Math.Abs(PV - SV)
            Select Case Control_State
                Case 0
                    If On_Cond And TimeUp > 0 Then
                        OldTime = TimeUp
                        TickCount = TimeUp
                        TickCountEnabled = True
                        DelayTimer.Enabled = True
                        Control_State = 1
                    Else
                        'Sstatus = False
                        'DelayTimer.Enabled = False
                        'TickCount = 0
                    End If
                Case 1
                    If On_Cond Then
                        If TickCountEnabled = False Then
                            If PV > SV Then
                                Sstatus = True
                            Else
                                Sstatus = False
                                Control_State = 0
                            End If
                            TickCount = 0
                            'If CycleCount Then Control_State = 0
                            If TimeUp <> OldTime Then
                                TickCount = TickCount + TimeUp - OldTime
                                If TickCount < 0 Then
                                    TickCount = 0
                                    TickCountEnabled = False
                                End If
                                OldTime = TimeUp
                            End If
                        End If
                    Else
                        Sstatus = False
                        DelayTimer.Enabled = False
                        TickCount = 0
                        Control_State = 0
                    End If
            End Select
            Return Sstatus
        End Function
        Public Function Lower(ByVal TimeUp As Integer, ByVal On_Cond As Boolean, ByVal SV As Double, ByVal PV As Double) As Boolean
            Dim compare As Integer
            Static OldTime As Integer
            compare = Math.Abs(PV - SV)
            Select Case Control_State
                Case 0
                    If On_Cond And TimeUp > 0 Then
                        OldTime = TimeUp
                        TickCount = TimeUp
                        TickCountEnabled = True
                        DelayTimer.Enabled = True
                        Control_State = 1
                    Else
                        Sstatus = False
                        'DelayTimer.Enabled = False
                        'TickCount = 0
                    End If
                Case 1
                    If On_Cond Then
                        If TickCountEnabled = False Then
                            If PV < SV Then
                                Sstatus = True
                            Else
                                Sstatus = False
                                Control_State = 0
                            End If
                            TickCount = 0
                            'If CycleCount Then Control_State = 0
                        Else
                            If TimeUp <> OldTime Then
                                TickCount = TickCount + TimeUp - OldTime
                                If TickCount < 0 Then
                                    TickCount = 0
                                    TickCountEnabled = False
                                End If
                                OldTime = TimeUp
                            End If
                        End If
                    Else
                        Sstatus = False
                        DelayTimer.Enabled = False
                        TickCount = 0
                        Control_State = 0
                    End If
            End Select
            Return Sstatus
        End Function
        Public Function LowerVacuum(ByVal TimeUp As Integer, ByVal On_Cond As Boolean, ByVal SV As Double, ByVal PV As Double) As Boolean
            Dim compare As Integer
            Static OldTime As Integer
            compare = Math.Abs(PV - SV)
            Select Case Control_State
                Case 0
                    If On_Cond And TimeUp > 0 Then
                        OldTime = TimeUp
                        TickCount = TimeUp
                        TickCountEnabled = True
                        DelayTimer.Enabled = True
                        Control_State = 1
                    Else
                        Sstatus = False
                        'DelayTimer.Enabled = False
                        'TickCount = 0
                    End If
                Case 1
                    If On_Cond Then
                        If TickCountEnabled = False Then
                            If PV < SV Then
                                Sstatus = True
                            Else
                                Sstatus = False
                                Control_State = 0
                            End If
                            TickCount = 0
                            'If CycleCount Then Control_State = 0
                            If TimeUp <> OldTime Then
                                TickCount = TickCount + TimeUp - OldTime
                                If TickCount < 0 Then
                                    TickCount = 0
                                    TickCountEnabled = False
                                End If
                                OldTime = TimeUp
                            End If
                        End If
                    Else
                        Sstatus = False
                        DelayTimer.Enabled = False
                        TickCount = 0
                        Control_State = 0
                    End If
            End Select
            Return Sstatus
        End Function

        '升降溫,升降壓檢查專用
        Public Function CheckValueAction(ByVal Cond As Boolean, ByVal iTempSV As Integer, ByVal iTempPV As Integer, ByVal iLimit As Integer, ByVal iTime As Integer) As Boolean
            Static OldTempSV, OldTempPV, oldiTime As Integer

            Select Case Control_State
                Case 0  '初始化
                    If Cond And iTime > 0 Then
                        OldTempSV = iTempSV
                        OldTempPV = iTempPV
                        oldiTime = iTime
                        DelayTimer.Enabled = True
                        TickCount = 3
                        TickCountEnabled = True
                        Sstatus = False
                        Control_State = 1
                    End If
                Case 1 '檢查升溫降溫
                    If Cond Then
                        If iTempSV > iTempPV Then
                            'OldTempPV = iTempPV
                            'OldTempSV = iTempSV
                            TickCount = iTime
                            TickCountEnabled = True
                            Control_State = 2
                        End If
                        If iTempSV < iTempPV Then
                            'OldTempPV = iTempPV
                            'OldTempSV = iTempSV
                            TickCount = iTime
                            TickCountEnabled = True
                            Control_State = 3
                        End If
                    Else
                        Sstatus = False
                        Control_State = 0
                    End If
                Case 2 '升溫異常檢查
                    If Cond Then
                        '檢查設定值是否有改變
                        If iTempSV <> OldTempSV Then
                            TickCountEnabled = False
                            Control_State = 1
                        Else
                            If TickCountEnabled = False Then
                                If Not PV_InRange(iTempSV, iTempPV, iLimit) Then
                                    If iTempPV <= OldTempPV Then
                                        Sstatus = True
                                    Else
                                        OldTempPV = iTempPV
                                        Sstatus = False
                                    End If
                                Else
                                    Sstatus = False
                                    Control_State = 1
                                End If
                                TickCount = iTime
                                TickCountEnabled = True
                            Else
                                If oldiTime <> iTime Then
                                    TickCount = TickCount + iTime - oldiTime
                                    If TickCount < 0 Then TickCount = 0
                                    oldiTime = iTime
                                End If
                                If PV_InRange(iTempSV, iTempPV, iLimit) Then
                                    OldTempPV = iTempPV
                                    Sstatus = False
                                    Control_State = 1
                                End If
                            End If
                        End If
                    Else
                        Sstatus = False
                        Control_State = 0
                    End If
                Case 3 '降溫異常檢查
                    If Cond Then
                        '檢查設定值是否有改變
                        If iTempSV <> OldTempSV Then
                            TickCountEnabled = False
                            Control_State = 1
                        Else
                            If TickCountEnabled = False Then
                                If Not PV_InRange(iTempSV, iTempPV, iLimit) Then

                                    If iTempPV >= OldTempPV Then
                                        Sstatus = True
                                    Else
                                        OldTempPV = iTempPV
                                        Sstatus = False
                                    End If
                                Else
                                    Sstatus = False
                                    Control_State = 1
                                End If
                                TickCount = iTime
                                TickCountEnabled = True
                            End If
                            If PV_InRange(iTempSV, iTempPV, iLimit) Then
                                OldTempPV = iTempPV
                                Sstatus = False
                                Control_State = 1
                            End If
                        End If
                    Else
                        Sstatus = False
                        Control_State = 0
                    End If
            End Select
            Return Sstatus
        End Function

        '製程升降溫,升降壓檢查專用
        Public Function CheckHeaterOC(ByVal Cond As Boolean, ByVal iTempSV As Integer, ByVal iTempPV As Integer, ByVal iLimit As Integer, ByVal iTime As Integer) As Boolean
            Static OldTempSV, OldTempPV As Integer

            Select Case Control_State
                Case 0  '設定值=現在值 則開始監視
                    If Cond And iTime > 0 Then
                        If PV_InRange(iTempSV, iTempPV, iLimit) Then
                            OldTempSV = iTempSV
                            OldTempPV = iTempPV
                            TickCount = iTime
                            TickCountEnabled = True
                            DelayTimer.Enabled = True
                            Sstatus = False
                            Control_State = 1
                        End If
                    End If
                Case 2 '檢查升溫降溫
                    If Cond Then
                        '檢查設定值是否有改變,有改變則再等待設定值=現在值
                        If iTempSV <> OldTempSV Then
                            TickCountEnabled = False
                            Control_State = 0
                        Else
                            '開始監視 溫度範圍
                            If TickCountEnabled = False Then
                                If Not PV_InRange(iTempSV, iTempPV, iLimit) Then
                                    Sstatus = True
                                Else
                                    Sstatus = False
                                End If
                                TickCount = iTime
                                TickCountEnabled = True
                            Else
                                If PV_InRange(iTempSV, iTempPV, iLimit) Then
                                    Sstatus = False
                                End If
                            End If
                        End If
                    Else
                        Sstatus = False
                        Control_State = 0
                    End If
            End Select
            Return Sstatus
        End Function
        '製程升降溫,升降壓檢查專用
        Public Function CheckProcessValue(ByVal Cond As Boolean, ByVal iTempSV As Integer, ByVal iTempPV As Integer, ByVal iLimit As Integer, ByVal iTime As Integer) As Boolean
            Static OldTempSV, OldTempPV As Integer

            Select Case Control_State
                Case 0  '設定值=現在值 則開始監視
                    If Cond And iTime > 0 Then
                        'If PV_InRange(iTempSV, iTempPV, iLimit) Then
                        If iTempSV = iTempPV Then
                            OldTempSV = iTempSV
                            OldTempPV = iTempPV
                            TickCount = iTime
                            TickCountEnabled = True
                            DelayTimer.Enabled = True
                            Sstatus = False
                            Control_State = 1
                        End If
                    Else
                        Sstatus = False
                    End If
                Case 1 '檢查升溫降溫
                    If Cond Then
                        '檢查設定值是否有改變,有改變則再等待設定值=現在值
                        If iTempSV <> OldTempSV Then
                            TickCountEnabled = False
                            Control_State = 0
                        Else
                            '開始監視 溫度範圍
                            If TickCountEnabled = False Then
                                If Not PV_InRange(iTempSV, iTempPV, iLimit) Then
                                    Sstatus = True
                                Else
                                    Sstatus = False
                                End If
                                TickCount = iTime
                                TickCountEnabled = True
                            Else
                                If PV_InRange(iTempSV, iTempPV, iLimit) Then
                                    Sstatus = False
                                End If
                            End If
                        End If
                    Else
                        Sstatus = False
                        Control_State = 0
                    End If
            End Select
            Return Sstatus
        End Function

        '計時器
        Public Sub TimerTick()
            If TickCountEnabled Then
                TickCount = TickCount - 1
                If TickCount <= 0 Then
                    TickCount = 0
                    TickCountEnabled = False
                End If
            End If
        End Sub
    End Class

 

    'Class Class_Delay
    '    '計時器物件
    '    Private DelayTimer As Timer
    '    '計時變數
    '    Private TickCount As Integer
    '    Private TickCountEnabled As Boolean
    '    '狀態變數
    '    Private Control_State As Integer
    '    '狀態變數
    '    Private Cond As Boolean
    '    '時間校正
    '    Private OldTime, CurTime As Integer
    '    '變數
    '    Private DAIndex As Integer
    '    Private ADIndex As Integer
    '    Private OutputIndex As Integer
    '    '執行用變數
    '    Private OnTime As Integer
    '    Private OffTime As Integer
    '    Private DelayMode As Integer
    '    Public Event ON_Event()
    '    Public Event OFF_Event()
    '    '建構函數
    '    Sub New(ByVal iDoIndex As Integer, ByVal iDAIndex As Integer, ByVal iADIndex As Integer)
    '        DelayTimer = New Timer
    '        DAIndex = iDAIndex
    '        ADIndex = iADIndex
    '        OutputIndex = iDoIndex
    '        DelayTimer.Enabled = True
    '        DelayTimer.Interval = 100
    '        DelayTimer.Enabled = True
    '        AddHandler DelayTimer.Tick, AddressOf TimerTick
    '        TickCount = 0
    '    End Sub
    '    '計時器
    '    Public Sub TimerTick()
    '        CurTime = DatePart(DateInterval.Second, Now())
    '        If CurTime <> OldTime Then
    '            If TickCountEnabled Then
    '                TickCount = TickCount - 1
    '                If TickCount <= 0 Then
    '                    TickCount = 0
    '                    TickCountEnabled = False
    '                End If
    '            End If
    '            OldTime = CurTime
    '        End If
    '    End Sub

    '    Public Sub OnDelay(ByVal bCond As Boolean, ByVal iDelayTime As Integer)
    '        OnTime = iDelayTime
    '        DelayMode = 0
    '        Cond = True
    '    End Sub
    '    Public Sub OffDelay(ByVal bCond As Boolean, ByVal iDelayTime As Integer)
    '        OffTime = iDelayTime
    '        DelayMode = 1
    '        Cond = True
    '    End Sub
    '    Public Sub [Stop]()
    '        Cond = False
    '        DelayTimer.Enabled = False
    '        Control_State = 0
    '    End Sub

    '    Public Sub RunDelay()
    '        Select Case Control_State
    '            Case 0
    '                If Cond Then
    '                    Select Case DelayMode
    '                        Case 0

    '                            Control_State = 1
    '                        Case 1
    '                            Control_State = 1
    '                    End Select
    '                Else
    '                    Control_State = 1
    '                    Control_State = 99
    '                End If
    '            Case 1
    '                If Cond Then
    '                    If TickCountEnabled = False Then
    '                        Set_MBit(OutputIndex, DEVICE_ON)
    '                        TickCount = MFCOnTime
    '                        TickCountEnabled = True
    '                        Control_State = 2
    '                    End If
    '                Else
    '                    Control_State = 99
    '                End If
    '            Case 2
    '                If Cond Then
    '                    If TickCountEnabled = False Then
    '                        Set_MBit(OutputIndex, DEVICE_OFF)
    '                        TickCount = MFCOffTime
    '                        TickCountEnabled = True
    '                        Control_State = 1
    '                    End If
    '                Else
    '                    Control_State = 99
    '                End If
    '            Case 99
    '                Set_MBit(OutputIndex, DEVICE_OFF)
    '                Cond = False
    '                Control_State = 0
    '        End Select
    '    End Sub

    'End Class

End Module

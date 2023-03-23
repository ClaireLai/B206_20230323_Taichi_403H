Module Module_Class_Delay
    '計時ON/OFF類別
    '=======================================================================================================================
    '宣告主類別: Dim OnDelay As New Class_Delay(MFCerrstatus)
    '宣告輸出變數: Dim bolOndelay As Boolean
    '設定: OnDelay.Start(5,ON/OFF Delay), 選擇性參數: True = OFF Delay, FALSE=ON DELAY,預設為 ON DELAY
    '輸出: OnDelay.Run(bolOndelay) <-定時執行
    Class Class_Delay
        Public Enum DelayMode As Integer
            [ON] = 0
            OFF = -1
        End Enum
        '計時器物件
        Private DelayTimer As Timer
        '計時變數
        Private TickCount As Integer
        Private TickCountEnabled As Boolean
        '輸出狀態變數
        Private TimerUp As Boolean
        Private Delay_Mode As Boolean
        Private Sstatus As Boolean
        '連結物件
        Private ActiveObject As Object
        Private ActiveObjectText As String

        '類別屬性--> 取得或設定計時值
        Public Property TimeCount() As Integer
            Get
                Return TickCount
            End Get
            Set(ByVal value As Integer)
                TickCount = value
            End Set
        End Property
        '類別屬性--> 取得或設定計時值
        ReadOnly Property Busy() As Boolean
            Get
                Return DelayTimer.Enabled
            End Get
        End Property

        '建構函數初始化
        Sub New()
            DelayTimer = New Timer
            AddHandler DelayTimer.Tick, AddressOf TimerTick
            DelayTimer.Interval = 1000
            DelayTimer.Enabled = False
            TickCount = 0
        End Sub

        '類別方法定義
        '開始計時, 傳入計時時間及ON/OFF DELAY , 預設值FALSE -> ON DELAY,
        Overloads Sub Start(ByVal TimeUp As Integer, ByVal Dly_Mode As Boolean)
            If TimeUp > 0 Then
                DelayTimer.Enabled = True
                TimerUp = False
                TickCountEnabled = True
                TickCount = TimeUp
                Delay_Mode = Dly_Mode
            End If
        End Sub
        '類別方法定義
        '開始計時, 傳入計時時間及ON/OFF DELAY , 預設值FALSE -> ON DELAY,
        Overloads Sub Start(ByVal TimeUp As Integer, ByVal Dly_Mode As Boolean, ByRef obj As Object)
            If TimeUp > 0 Then
                If IsNothing(obj) = False Then
                    ActiveObject = obj
                    ActiveObjectText = obj.Text
                End If
                DelayTimer.Enabled = True
                TimerUp = False
                TickCountEnabled = True
                TickCount = TimeUp
                Delay_Mode = Dly_Mode
            End If
        End Sub
        '停止計時, 需要 Start(), 重新再計時
        Sub [Stop]()
            If TimerUp = False And DelayTimer.Enabled Then
                TimerUp = False
                DelayTimer.Enabled = False
                TickCountEnabled = False
                TickCount = 0
            End If
        End Sub
        '暫停計時, 用 ReStart()繼續
        Sub Pause()
            If TimerUp = False And DelayTimer.Enabled Then
                TickCountEnabled = False
            End If
        End Sub
        '暫停後, 繼續計時.
        Sub ReStart()
            If TimerUp = False And DelayTimer.Enabled Then
                TickCountEnabled = True
            End If
        End Sub
        '計時時間到, 輸出控制函數,需掛在定時執行之計時器內
        Function Run(ByRef out As Boolean) As Integer
            If TickCountEnabled = False And TimerUp Then
                If Delay_Mode Then
                    out = False
                Else
                    out = True
                End If
                TimerUp = False
            End If
        End Function

        '計時器
        Public Sub TimerTick()
            If IsNothing(ActiveObject) = False Then ActiveObject.Text = ActiveObjectText + Format(TickCount, "[0]")

            If TickCountEnabled Then
                If TickCount > 0 Then
                    TickCount = TickCount - 1
                End If
                If TickCount <= 0 Then
                    TickCount = 0
                    TickCountEnabled = False
                    DelayTimer.Enabled = False
                    TimerUp = True
                End If
            End If
        End Sub
    End Class

    '=======================================================================================================================
End Module

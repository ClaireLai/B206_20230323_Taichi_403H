
Module Module_Button_Class
    '按鈕模組(控制PLC M點輸出, 且M輸出後要設定同編號Y輸出為ON
    '宣告: Output(i) = New ValveClass(i)
    '使用: 在定時RUN之計時器內
    '設定 INTERLOCK
    'on_cond = PLC_X(DiCDAIndex) = "1" And PLC_X(DiEMOIndex) = "1" And PLC_X(DiRobotOutIndex) = "1"
    '啟動程序
    'Output(DoV5CloseIndex).Run(V5Close_Status, on_cond)
    Public watdog As New Stopwatch
    Public boltemp As Boolean = False
    Public Sub watdog_Restart()
        watdog.Stop()
        watdog.Reset()
        watdog.Start()
    End Sub
    Public Class ValveClass
        Private pInterlock As Boolean   '定義私有變數 互鎖
        Private vStatus As Boolean      '定義私有變數 狀態顯示及設定
        Private OnDelay As Integer      '定義私有變數 ON 延遲
        Private OffDelay As Integer     '定義私有變數 OFF 延遲
        Private OnColor As Color        '定義私有變數 ON 顏色值
        Private OffColor As Color       '定義私有變數 OFF 顏色值
        Private ConnectButton As Button ' 定義欲連結的 BUTTON 物件
        Private iOnDelay As Integer ' 定義欲連結的 BUTTON 物件
        Private iOnDelayHandle As Integer ' 定義欲連結的 BUTTON 物件
        Private iOnDelayEnable As Boolean ' 定義欲連結的 BUTTON 物件
        Private iOffDelay As Integer ' 定義欲連結的 BUTTON 物件
        Private iOffDelayHandle As Integer ' 定義欲連結的 BUTTON 物件
        Private iOffDelayEnable As Boolean ' 定義欲連結的 BUTTON 物件
        Public OutputMIndex As Integer = 0  '定義 M點代號
        Public OutputYIndex As Integer = 0  '定義 Y點代號

        '定義可操作的屬性-- 互鎖
        Public Property InterLock() As Boolean
            Get
                Return pInterlock
            End Get
            Set(ByVal Value As Boolean)
                pInterlock = Value
            End Set
        End Property

        '定義可操作的屬性-- 狀態讀取及設定
        Public Property Status() As Boolean
            Get
                Return vStatus
            End Get
            Set(ByVal Value As Boolean)
                vStatus = Value
            End Set
        End Property

        '定義可操作的屬性-- BUTTON ON 的顏色讀取及設定
        Public Property ON_Color() As Color
            Get
                Return OnColor
            End Get
            Set(ByVal Value As Color)
                OnColor = Value
            End Set
        End Property

        '定義可操作的屬性-- BUTTON OFF 的顏色讀取及設定
        Public Property OFF_Color() As Color
            Get
                Return OffColor
            End Get
            Set(ByVal Value As Color)
                OffColor = Value
            End Set
        End Property


        '建構函數， 新建物件時的預設值
        Public Sub New(ByVal index As Integer)
            OutputMIndex = index
            OutputYIndex = index
            vStatus = False         '初始狀態為 FALSE
            OnColor = Color.Lime                            ' ON 時為 檸檬綠色
            OffColor = Color.FromArgb(255, 255, 192)         'OFF 時為 淺黃色
            pInterlock = True
        End Sub

        '1.多載 RUN 函數, 輸出點 INDEX 跟初始編號一樣
        '狀態點為使用內部狀態變數      '輸出為Y輸出點
        Public Overloads Function Run() As Boolean
            Static Control_State As Byte
            Dim on_cond As Boolean
            on_cond = pInterlock
            Select Case Control_State
                Case 0 '初始檢查ON/OFF狀態並跳往指定STATUS

                    If PLC_Y(OutputYIndex) = "1" And on_cond Then  '初始狀態為 ON, 跳到狀態 3
                        Status = True
                        Control_State = 3
                    ElseIf PLC_Y(OutputYIndex) = "0" Then       '初始狀態為 OFF, 跳到狀態 1
                        Status = False
                        Control_State = 1
                    Else
                        Set_MBit(OutputMIndex, DEVICE_OFF)     '初始狀態不明,強制設定為OFF 並到 跳到狀態 4
                        Status = False
                        Control_State = 4
                    End If
                Case 1  '狀態為 OFF, 等待 ON
                    If Status And on_cond Then          'PLC端 設定為 ON, 跳到 狀態5
                        Control_State = 5
                    Else
                        If PLC_Y(OutputYIndex) = "1" Then  '若OUPUT 由PLC內部 ON 則更新為ON狀態 3
                            Status = True
                            Control_State = 3
                        Else
                            Status = False      '若未ON則在 狀態 1等待
                        End If
                    End If
                Case 2  'PLC 設定ON ,檢查是否已ON
                    If Not (Status And on_cond) Then    'PC 端命令 OFF , 設定 OFF 後到狀態4
                        Set_MBit(OutputMIndex, DEVICE_OFF)
                        Status = False
                        Control_State = 4
                    Else
                        If PLC_Y(OutputYIndex) = "1" Then  'PC 端已設定ON,
                            Status = True
                            Control_State = 3
                        Else
                            Status = False
                            Control_State = 1
                        End If
                    End If
                Case 3  '輸出已ON, 等待PC命令OFF
                    If Not (Status And on_cond) Then
                        Set_MBit(OutputMIndex, DEVICE_OFF)
                        Status = False
                        Control_State = 4
                    ElseIf PLC_Y(OutputYIndex) = "0" Then  '輸出已ON, 等待PLC命令OFF則跳到 狀態1
                        Status = False
                        Control_State = 1
                    End If
                Case 4  ' 強制 OFF , 等待 PLC OFF
                    If PLC_Y(OutputYIndex) = "0" Then
                        Status = False
                        Control_State = 1
                    End If
                Case 5  'PC端設為 ON, 設定輸出命令
                    If Not (Status And on_cond) Then    '檢查PC 命令及 INTERLOCK
                        Status = False                  '強制OFF
                        Control_State = 4
                    Else                                '設定為ON 並跳到 狀態2
                        Set_MBit(OutputMIndex, DEVICE_ON)
                        Status = True
                        Control_State = 2
                    End If
            End Select
            Return PLC_Y(OutputYIndex) = "1"   '將目前 I/O 狀態傳回

        End Function

        '2.多載 RUN 函數, 輸出點 M,Y 為同一編號
        '狀態點為使用內部狀態變數      '輸出為Y輸出點
        Public Overloads Function Run(ByVal Do_Index As Integer) As Boolean
            Static Control_State As Byte
            Dim on_cond As Boolean
            on_cond = pInterlock
            OutputMIndex = Do_Index
            OutputYIndex = Do_Index
            Select Case Control_State
                Case 0 '初始檢查ON/OFF狀態並跳往指定STATUS

                    If PLC_Y(OutputYIndex) = "1" And on_cond Then  '初始狀態為 ON, 跳到狀態 3
                        Status = True
                        Control_State = 3
                    ElseIf PLC_Y(OutputYIndex) = "0" Then       '初始狀態為 OFF, 跳到狀態 1
                        Status = False
                        Control_State = 1
                    Else
                        Set_MBit(OutputMIndex, DEVICE_OFF)     '初始狀態不明,強制設定為OFF 並到 跳到狀態 4
                        Status = False
                        Control_State = 4
                    End If
                Case 1  '狀態為 OFF, 等待 ON
                    If Status And on_cond Then          'PLC端 設定為 ON, 跳到 狀態5
                        Control_State = 5
                    Else
                        If PLC_Y(OutputYIndex) = "1" Then  '若OUPUT 由PLC內部 ON 則更新為ON狀態 3
                            Status = True
                            Control_State = 3
                        Else
                            Status = False      '若未ON則在 狀態 1等待
                        End If
                    End If
                Case 2  'PLC 設定ON ,檢查是否已ON
                    If Not (Status And on_cond) Then    'PC 端命令 OFF , 設定 OFF 後到狀態4
                        Set_MBit(OutputMIndex, DEVICE_OFF)
                        Status = False
                        Control_State = 4
                    Else
                        If PLC_Y(OutputYIndex) = "1" Then  'PC 端已設定ON,
                            Status = True
                            Control_State = 3
                        Else
                            Status = False
                            Control_State = 1
                        End If
                    End If
                Case 3  '輸出已ON, 等待PC命令OFF
                    If Not (Status And on_cond) Then
                        Set_MBit(OutputMIndex, DEVICE_OFF)
                        Status = False
                        Control_State = 4
                    ElseIf PLC_Y(OutputYIndex) = "0" Then  '輸出已ON, 等待PLC命令OFF則跳到 狀態1
                        Status = False
                        Control_State = 1
                    End If
                Case 4  ' 強制 OFF , 等待 PLC OFF
                    If PLC_Y(OutputYIndex) = "0" Then
                        Status = False
                        Control_State = 1
                    End If
                Case 5  'PC端設為 ON, 設定輸出命令
                    If Not (Status And on_cond) Then    '檢查PC 命令及 INTERLOCK
                        Status = False                  '強制OFF
                        Control_State = 4
                    Else                                '設定為ON 並跳到 狀態2
                        Set_MBit(OutputMIndex, DEVICE_ON)
                        Status = True
                        Control_State = 2
                    End If
            End Select

            Return PLC_Y(OutputYIndex) = "1"   '將目前 I/O 狀態傳回
        End Function

        '3.多載 RUN 函數, 輸出點 INDEX 跟初始編號一樣, 輸入為 INTERLOCK 值
        '狀態點為使用內部狀態變數      '輸出為Y輸出點
        Public Overloads Function Run(ByVal interlock As Boolean) As Boolean
            Static Control_State As Byte
            Dim on_cond As Boolean
            pInterlock = interlock
            on_cond = pInterlock
            Select Case Control_State
                Case 0 '初始檢查ON/OFF狀態並跳往指定STATUS

                    If PLC_Y(OutputYIndex) = "1" And on_cond Then  '初始狀態為 ON, 跳到狀態 3
                        Status = True
                        Control_State = 3
                    ElseIf PLC_Y(OutputYIndex) = "0" Then       '初始狀態為 OFF, 跳到狀態 1
                        Status = False
                        Control_State = 1
                    Else
                        Set_MBit(OutputMIndex, DEVICE_OFF)     '初始狀態不明,強制設定為OFF 並到 跳到狀態 4
                        Status = False
                        Control_State = 4
                    End If
                Case 1  '狀態為 OFF, 等待 ON
                    If Status And on_cond Then          'PLC端 設定為 ON, 跳到 狀態5
                        Control_State = 5
                    Else
                        If PLC_Y(OutputYIndex) = "1" Then  '若OUPUT 由PLC內部 ON 則更新為ON狀態 3
                            Status = True
                            Control_State = 3
                        Else
                            Status = False      '若未ON則在 狀態 1等待
                        End If
                    End If
                Case 2  'PLC 設定ON ,檢查是否已ON
                    If Not (Status And on_cond) Then    'PC 端命令 OFF , 設定 OFF 後到狀態4
                        Set_MBit(OutputMIndex, DEVICE_OFF)
                        Status = False
                        Control_State = 4
                    Else
                        If PLC_Y(OutputYIndex) = "1" Then  'PC 端已設定ON,
                            Status = True
                            Control_State = 3
                        Else
                            Status = False
                            Control_State = 1
                        End If
                    End If
                Case 3  '輸出已ON, 等待PC命令OFF
                    If Not (Status And on_cond) Then
                        Set_MBit(OutputMIndex, DEVICE_OFF)
                        Status = False
                        Control_State = 4
                    ElseIf PLC_Y(OutputYIndex) = "0" Then  '輸出已ON, 等待PLC命令OFF則跳到 狀態1
                        Status = False
                        Control_State = 1
                    End If
                Case 4  ' 強制 OFF , 等待 PLC OFF
                    If PLC_Y(OutputYIndex) = "0" Then
                        Status = False
                        Control_State = 1
                    End If
                Case 5  'PC端設為 ON, 設定輸出命令
                    If Not (Status And on_cond) Then    '檢查PC 命令及 INTERLOCK
                        Status = False                  '強制OFF
                        Control_State = 4
                    Else                                '設定為ON 並跳到 狀態2
                        Set_MBit(OutputMIndex, DEVICE_ON)
                        Status = True
                        Control_State = 2
                    End If
            End Select
            Return PLC_Y(OutputYIndex) = "1"   '將目前 I/O 狀態傳回
        End Function
        '4.多載 RUN 函數, 輸出點 M,Y同一點, 輸入為 INTERLOCK 值
        '狀態點為使用內部狀態變數      '輸出為Y輸出點
        Public Overloads Function Run(ByVal Do_index As Integer, ByVal interlock As Boolean) As Boolean
            Static Control_State As Byte
            Dim on_cond As Boolean
            pInterlock = interlock
            on_cond = pInterlock
            OutputMIndex = Do_index
            OutputYIndex = Do_index
            Select Case Control_State
                Case 0 '初始檢查ON/OFF狀態並跳往指定STATUS

                    If PLC_Y(OutputYIndex) = "1" And on_cond Then  '初始狀態為 ON, 跳到狀態 3
                        Status = True
                        Control_State = 3
                    ElseIf PLC_Y(OutputYIndex) = "0" Then       '初始狀態為 OFF, 跳到狀態 1
                        Status = False
                        Control_State = 1
                    Else
                        Set_MBit(OutputMIndex, DEVICE_OFF)     '初始狀態不明,強制設定為OFF 並到 跳到狀態 4
                        Status = False
                        Control_State = 4
                    End If
                Case 1  '狀態為 OFF, 等待 ON
                    If Status And on_cond Then          'PLC端 設定為 ON, 跳到 狀態5
                        Control_State = 5
                    Else
                        If PLC_Y(OutputYIndex) = "1" Then  '若OUPUT 由PLC內部 ON 則更新為ON狀態 3
                            Status = True
                            Control_State = 3
                        Else
                            Status = False      '若未ON則在 狀態 1等待
                        End If
                    End If
                Case 2  'PLC 設定ON ,檢查是否已ON
                    If Not (Status And on_cond) Then    'PC 端命令 OFF , 設定 OFF 後到狀態4
                        Set_MBit(OutputMIndex, DEVICE_OFF)
                        Status = False
                        Control_State = 4
                    Else
                        If PLC_Y(OutputYIndex) = "1" Then  'PC 端已設定ON,
                            Status = True
                            Control_State = 3
                        Else
                            Status = False
                            Control_State = 1
                        End If
                    End If
                Case 3  '輸出已ON, 等待PC命令OFF
                    If Not (Status And on_cond) Then
                        Set_MBit(OutputMIndex, DEVICE_OFF)
                        Status = False
                        Control_State = 4
                    ElseIf PLC_Y(OutputYIndex) = "0" Then  '輸出已ON, 等待PLC命令OFF則跳到 狀態1
                        Status = False
                        Control_State = 1
                    End If
                Case 4  ' 強制 OFF , 等待 PLC OFF
                    If PLC_Y(OutputYIndex) = "0" Then
                        Status = False
                        Control_State = 1
                    End If
                Case 5  'PC端設為 ON, 設定輸出命令
                    If Not (Status And on_cond) Then    '檢查PC 命令及 INTERLOCK
                        Status = False                  '強制OFF
                        Control_State = 4
                    Else                                '設定為ON 並跳到 狀態2
                        Set_MBit(OutputMIndex, DEVICE_ON)
                        Status = True
                        Control_State = 2
                    End If
            End Select

            Return PLC_Y(OutputYIndex) = "1"   '將目前 I/O 狀態傳回
        End Function

        '5.多載 RUN 函數, 輸出點 INDEX 跟初始編號一樣, 輸入為 連結的 boolean 變數 及INTERLOCK 值, 
        '狀態點為使用內部狀態變數      '輸出為Y輸出點
        Public Overloads Function Run(ByRef vStatus As Boolean, ByVal interlock As Boolean) As Boolean
            Static Control_State As Byte
            Dim on_cond As Boolean
            Static dCount As Integer
            pInterlock = interlock
            on_cond = pInterlock
            Select Case Control_State
                Case 0 '初始檢查ON/OFF狀態並跳往指定STATUS

                    If PLC_Y(OutputYIndex) = "1" Then  '初始狀態為 ON, 跳到狀態 3
                        vStatus = True
                        Control_State = 3
                    ElseIf PLC_Y(OutputYIndex) = "0" Then       '初始狀態為 OFF, 跳到狀態 1
                        vStatus = False
                        Control_State = 1
                        'Else
                        '    Set_MBit(OutputYIndex, DEVICE_OFF) '初始狀態不明,強制設定為OFF 並到 跳到狀態 4
                        '    vStatus = False
                        '    Control_State = 4
                    End If
                Case 1  '狀態為 OFF, 等待 ON
                    If vStatus And on_cond Then          'PLC端 設定為 ON, 跳到 狀態5
                        Control_State = 5
                    Else
                        If PLC_Y(OutputYIndex) = "1" Then  '若OUPUT 由PLC內部 ON 則更新為ON狀態 3
                            vStatus = True
                            Control_State = 3
                        Else
                            vStatus = False      '若未ON則在 狀態 1等待
                        End If
                    End If
                Case 2  'PLC 設定ON ,檢查是否已ON
                    If Not (vStatus And on_cond) Then    'PC 端命令 OFF , 設定 OFF 後到狀態4
                        Set_MBit(OutputYIndex, DEVICE_OFF)
                        vStatus = False
                        Control_State = 4
                    Else
                        If PLC_Y(OutputYIndex) = "1" Then  'PC 端已設定ON,
                            vStatus = True
                            Control_State = 3
                        Else
                            vStatus = False
                            Control_State = 1
                        End If
                    End If
                Case 3  '輸出已ON, 等待PC命令OFF
                    If Not (vStatus And on_cond) Then
                        Set_MBit(OutputYIndex, DEVICE_OFF)
                        vStatus = False
                        Control_State = 4
                    ElseIf PLC_Y(OutputYIndex) = "0" Then  '輸出已ON, 等待PLC命令OFF則跳到 狀態1
                        vStatus = False
                        Control_State = 1
                    End If
                Case 4  ' 強制 OFF , 等待 PLC OFF
                    If PLC_Y(OutputYIndex) = "0" Then
                        vStatus = False
                        Control_State = 1
                    Else
                        dCount = dCount + 1
                        If dCount = 30 Then
                            If PLC_Y(OutputYIndex) = "1" Then Set_MBit(OutputMIndex, DEVICE_OFF)
                            dCount = 0
                        End If
                    End If
                Case 5  'PC端設為 ON, 設定輸出命令
                    If Not (vStatus And on_cond) Then    '檢查PC 命令及 INTERLOCK
                        vStatus = False                  '強制OFF
                        Control_State = 4
                    Else                                '設定為ON 並跳到 狀態2
                        If PLC_Y(OutputYIndex) = "0" Then
                            Set_MBit(OutputYIndex, DEVICE_ON)
                        End If
                        vStatus = True
                        Control_State = 2
                    End If
            End Select
            Status = vStatus
            Return PLC_Y(OutputYIndex) = "1"   '將目前 I/O 狀態傳回
        End Function

        Public Overloads Function Run(ByVal Do_MIndex As Integer, ByVal interlock As Boolean, ByVal obj As Button) As Boolean
            Static Control_State As Byte
            Dim on_cond As Boolean
            on_cond = interlock
            pInterlock = on_cond
            OutputMIndex = Do_MIndex
            Select Case Control_State
                Case 0 '初始檢查ON/OFF狀態並跳往指定STATUS

                    If PLC_Y(Do_MIndex) = "1" And on_cond Then  '初始狀態為 ON, 跳到狀態 3
                        Status = True
                        Control_State = 3
                    ElseIf PLC_Y(Do_MIndex) = "0" Then       '初始狀態為 OFF, 跳到狀態 1
                        Status = False
                        Control_State = 1
                    Else
                        Set_MBit(Do_MIndex, DEVICE_OFF)     '初始狀態不明,強制設定為OFF 並到 跳到狀態 4
                        Status = False
                        Control_State = 4
                    End If
                Case 1  '狀態為 OFF, 等待 ON
                    If Status And on_cond Then          'PLC端 設定為 ON, 跳到 狀態5
                        Control_State = 5
                    Else
                        If PLC_Y(Do_MIndex) = "1" Then  '若OUPUT 由PLC內部 ON 則更新為ON狀態 3
                            Status = True
                            Control_State = 3
                        Else
                            Status = False      '若未ON則在 狀態 1等待
                        End If
                    End If
                Case 2  'PLC 設定ON ,檢查是否已ON
                    If Not (Status And on_cond) Then    'PC 端命令 OFF , 設定 OFF 後到狀態4
                        Set_MBit(Do_MIndex, DEVICE_OFF)
                        Status = False
                        Control_State = 4
                    Else
                        If PLC_Y(Do_MIndex) = "1" Then  'PC 端已設定ON,
                            Status = True
                            Control_State = 3
                        Else
                            Status = False
                            Control_State = 1
                        End If
                    End If
                Case 3  '輸出已ON, 等待PC命令OFF
                    If Not (Status And on_cond) Then
                        Set_MBit(Do_MIndex, DEVICE_OFF)
                        Status = False
                        Control_State = 4
                    ElseIf PLC_Y(Do_MIndex) = "0" Then  '輸出已ON, 等待PLC命令OFF則跳到 狀態1
                        Status = False
                        Control_State = 1
                    End If
                Case 4  ' 強制 OFF , 等待 PLC OFF
                    If PLC_Y(Do_MIndex) = "0" Then
                        Status = False
                        Control_State = 1
                    End If
                Case 5  'PC端設為 ON, 設定輸出命令
                    If Not (Status And on_cond) Then    '檢查PC 命令及 INTERLOCK
                        Status = False                  '強制OFF
                        Control_State = 4
                    Else                                '設定為ON 並跳到 狀態2
                        Set_MBit(Do_MIndex, DEVICE_ON)
                        Status = True
                        Control_State = 2
                    End If
            End Select

            If PLC_Y(Do_MIndex) = "1" Then  '將目前 I/O 狀態傳回
                Run = True
                obj.BackColor = OnColor
            Else
                Run = False
                obj.BackColor = OffColor
            End If
        End Function
        Public Overloads Function RunM(ByVal Do_MIndex As Integer, ByVal interlock As Boolean, ByVal obj As Button) As Boolean
            Static Control_State As Byte
            Dim on_cond As Boolean
            on_cond = interlock
            pInterlock = on_cond
            OutputMIndex = Do_MIndex
            Select Case Control_State
                Case 0 '初始檢查ON/OFF狀態並跳往指定STATUS

                    If PLC_M(Do_MIndex) = "1" And on_cond Then  '初始狀態為 ON, 跳到狀態 3
                        Status = True
                        Control_State = 3
                    ElseIf PLC_M(Do_MIndex) = "0" Then       '初始狀態為 OFF, 跳到狀態 1
                        Status = False
                        Control_State = 1
                    Else
                        Set_MBit(Do_MIndex, DEVICE_OFF)     '初始狀態不明,強制設定為OFF 並到 跳到狀態 4
                        Status = False
                        Control_State = 4
                    End If
                Case 1  '狀態為 OFF, 等待 ON
                    If Status And on_cond Then          'PLC端 設定為 ON, 跳到 狀態5
                        Control_State = 5
                    Else
                        If PLC_M(Do_MIndex) = "1" Then  '若OUPUT 由PLC內部 ON 則更新為ON狀態 3
                            Status = True
                            Control_State = 3
                        Else
                            Status = False      '若未ON則在 狀態 1等待
                        End If
                    End If
                Case 2  'PLC 設定ON ,檢查是否已ON
                    If Not (Status And on_cond) Then    'PC 端命令 OFF , 設定 OFF 後到狀態4
                        Set_MBit(Do_MIndex, DEVICE_OFF)
                        Status = False
                        Control_State = 4
                    Else
                        If PLC_M(Do_MIndex) = "1" Then  'PC 端已設定ON,
                            Status = True
                            Control_State = 3
                        Else
                            Status = False
                            Control_State = 1
                        End If
                    End If
                Case 3  '輸出已ON, 等待PC命令OFF
                    If Not (Status And on_cond) Then
                        Set_MBit(Do_MIndex, DEVICE_OFF)
                        Status = False
                        Control_State = 4
                    ElseIf PLC_M(Do_MIndex) = "0" Then  '輸出已ON, 等待PLC命令OFF則跳到 狀態1
                        Status = False
                        Control_State = 1
                    End If
                Case 4  ' 強制 OFF , 等待 PLC OFF
                    If PLC_M(Do_MIndex) = "0" Then
                        Status = False
                        Control_State = 1
                    End If
                Case 5  'PC端設為 ON, 設定輸出命令
                    If Not (Status And on_cond) Then    '檢查PC 命令及 INTERLOCK
                        Status = False                  '強制OFF
                        Control_State = 4
                    Else                                '設定為ON 並跳到 狀態2
                        Set_MBit(Do_MIndex, DEVICE_ON)
                        Status = True
                        Control_State = 2
                    End If
            End Select

            If PLC_M(Do_MIndex) = "1" Then  '將目前 I/O 狀態傳回
                RunM = True
                obj.BackColor = OnColor
            Else
                RunM = False
                obj.BackColor = OffColor
            End If
        End Function

        Public Overloads Function RunM(ByVal Do_MIndex As Integer, ByRef vStatus As Boolean, ByVal interlock As Boolean, ByVal obj As Button) As Boolean
            Static Control_State As Byte
            Dim on_cond As Boolean
            on_cond = interlock
            pInterlock = on_cond
            OutputMIndex = Do_MIndex
            Select Case Control_State
                Case 0 '初始檢查ON/OFF狀態並跳往指定STATUS

                    If PLC_M(Do_MIndex) = "1" And on_cond Then  '初始狀態為 ON, 跳到狀態 3
                        vStatus = True
                        Control_State = 3
                    ElseIf PLC_M(Do_MIndex) = "0" Then       '初始狀態為 OFF, 跳到狀態 1
                        vStatus = False
                        Control_State = 1
                    Else
                        Set_MBit(Do_MIndex, DEVICE_OFF)     '初始狀態不明,強制設定為OFF 並到 跳到狀態 4
                        vStatus = False
                        Control_State = 4
                    End If
                Case 1  '狀態為 OFF, 等待 ON
                    If vStatus And on_cond Then          'PLC端 設定為 ON, 跳到 狀態5
                        Control_State = 5
                    Else
                        If PLC_M(Do_MIndex) = "1" Then  '若OUPUT 由PLC內部 ON 則更新為ON狀態 3
                            vStatus = True
                            Control_State = 3
                        Else
                            vStatus = False      '若未ON則在 狀態 1等待
                        End If
                    End If
                Case 2  'PLC 設定ON ,檢查是否已ON
                    If Not (vStatus And on_cond) Then    'PC 端命令 OFF , 設定 OFF 後到狀態4
                        Set_MBit(Do_MIndex, DEVICE_OFF)
                        vStatus = False
                        Control_State = 4
                    Else
                        If PLC_M(Do_MIndex) = "1" Then  'PC 端已設定ON,
                            vStatus = True
                            Control_State = 3
                        Else
                            vStatus = False
                            Control_State = 1
                        End If
                    End If
                Case 3  '輸出已ON, 等待PC命令OFF
                    If Not (vStatus And on_cond) Then
                        Set_MBit(Do_MIndex, DEVICE_OFF)
                        vStatus = False
                        Control_State = 4
                    ElseIf PLC_M(Do_MIndex) = "0" Then  '輸出已ON, 等待PLC命令OFF則跳到 狀態1
                        vStatus = False
                        Control_State = 1
                    End If
                Case 4  ' 強制 OFF , 等待 PLC OFF
                    If PLC_M(Do_MIndex) = "0" Then
                        vStatus = False
                        Control_State = 1
                    End If
                Case 5  'PC端設為 ON, 設定輸出命令
                    If Not (vStatus And on_cond) Then    '檢查PC 命令及 INTERLOCK
                        vStatus = False                  '強制OFF
                        Control_State = 4
                    Else                                '設定為ON 並跳到 狀態2
                        Set_MBit(Do_MIndex, DEVICE_ON)
                        vStatus = True
                        Control_State = 2
                    End If
            End Select

            If PLC_M(Do_MIndex) = "1" Then  '將目前 I/O 狀態傳回
                RunM = True
                obj.BackColor = OnColor
            Else
                RunM = False
                obj.BackColor = OffColor
            End If
            Status = vStatus
        End Function
        Public Overloads Function RunM() As Boolean
            Static Control_State As Byte
            Dim on_cond As Boolean
            on_cond = pInterlock
            Dim debugID As Integer = DoOilPump01Index
            Select Case Control_State
                Case 0 '初始檢查ON/OFF狀態並跳往指定STATUS
                    If PLC_M(OutputYIndex) = "1" And on_cond Then  '初始狀態為 ON, 跳到狀態 3
                        Status = True
                        Control_State = 3
                        If OutputYIndex = debugID Then
                            Debug.Print("0_Control_State = 3 +" + watdog.ElapsedMilliseconds.ToString)
                            watdog_Restart()
                        End If
                    ElseIf PLC_M(OutputYIndex) = "0" Then       '初始狀態為 OFF, 跳到狀態 1
                        Status = False
                        Control_State = 1
                        If OutputYIndex = debugID Then
                            Debug.Print("0_PLC_Y(OutputYIndex) = 0 +" + watdog.ElapsedMilliseconds.ToString)
                            watdog_Restart()
                        End If
                    Else
                        Set_MBit(OutputMIndex, DEVICE_OFF)     '初始狀態不明,強制設定為OFF 並到 跳到狀態 4
                        Status = False
                        Control_State = 4
                        If OutputMIndex = debugID Then
                            Debug.Print("0_Set_MBit(OutputMIndex, DEVICE_OFF+" + watdog.ElapsedMilliseconds.ToString)
                            watdog_Restart()
                        End If
                    End If
                Case 1  '狀態為 OFF, 等待 ON
                    If Status And on_cond Then          'PLC端 設定為 ON, 跳到 狀態5
                        Control_State = 5
                        If OutputMIndex = debugID Then
                            Debug.Print("1_狀態為 OFF, 等待 ON +" + watdog.ElapsedMilliseconds.ToString)
                            watdog_Restart()
                        End If
                    Else
                        If PLC_M(OutputYIndex) = "1" Then  '若OUPUT 由PLC內部 ON 則更新為ON狀態 3
                            Status = True
                            Control_State = 3
                            If OutputMIndex = debugID Then
                                Debug.Print("1_PLC_M(OutputYIndex) = 1 +" + watdog.ElapsedMilliseconds.ToString)
                                watdog_Restart()
                            End If
                        Else
                            Status = False      '若未ON則在 狀態 1等待
                        End If
                    End If
                Case 2  'PLC 設定ON ,檢查是否已ON
                    If Not (vStatus And on_cond) Then    'PC 端命令 OFF , 設定 OFF 後到狀態4
                        If OutputMIndex = debugID Then
                            Debug.Print("2_Set_MBit(OutputMIndex, DEVICE_OFF +" + watdog.ElapsedMilliseconds.ToString)
                            watdog_Restart()
                        End If
                        Set_MBit(OutputMIndex, DEVICE_OFF)
                        Status = False
                        Control_State = 4
                    Else
                        If PLC_M(OutputYIndex) = "1" Then  'PC 端已設定ON,
                            Status = True
                            Control_State = 3
                            If OutputMIndex = debugID Then
                                Debug.Print("2_PLC_Y(OutputYIndex) = 1 Then  PC 端已設定ON,+" + watdog.ElapsedMilliseconds.ToString)
                                watdog_Restart()
                            End If
                        Else
                            Status = False
                            Control_State = 1
                            If OutputMIndex = debugID Then
                                Debug.Print("2_PLC 設定ON ,檢查是否已ON+" + watdog.ElapsedMilliseconds.ToString)
                                watdog_Restart()
                            End If
                        End If
                    End If
                Case 3  '輸出已ON, 等待PC命令OFF
                    If Not (vStatus And on_cond) Then
                        Set_MBit(OutputMIndex, DEVICE_OFF)
                        Status = False
                        Control_State = 4
                        If OutputMIndex = debugID Then
                            Debug.Print("3_Set_MBit(OutputMIndex, DEVICE_OFF+" + watdog.ElapsedMilliseconds.ToString)
                            watdog_Restart()
                        End If
                    ElseIf PLC_M(OutputYIndex) = "0" Then  '輸出已ON, 等待PLC命令OFF則跳到 狀態1
                        Status = False
                        Control_State = 1
                        If OutputMIndex = debugID Then
                            Debug.Print("3_輸出已ON, 等待PC命令OFF+" + watdog.ElapsedMilliseconds.ToString)
                            watdog_Restart()
                        End If
                    End If
                Case 4  ' 強制 OFF , 等待 PLC OFF
                    If PLC_M(OutputYIndex) = "0" Then
                        Status = False
                        Control_State = 1
                        If OutputMIndex = debugID Then
                            Debug.Print("4_強制 OFF , 等待 PLC OFF+" + watdog.ElapsedMilliseconds.ToString)
                            watdog_Restart()
                        End If
                    End If
                Case 5  'PC端設為 ON, 設定輸出命令
                    If Not (vStatus And on_cond) Then    '檢查PC 命令及 INTERLOCK
                        Status = False                  '強制OFF
                        Control_State = 4
                        If OutputMIndex = debugID Then
                            Debug.Print("5_PC端設為 ON, 設定輸出命令+" + watdog.ElapsedMilliseconds.ToString)
                            watdog_Restart()
                        End If
                    Else                                '設定為ON 並跳到 狀態2
                        Set_MBit(OutputMIndex, DEVICE_ON)
                        Status = True
                        Control_State = 2
                        If OutputMIndex = debugID Then
                            Debug.Print("5_Set_MBit(OutputMIndex, DEVICE_ON+" + watdog.ElapsedMilliseconds.ToString)
                            watdog_Restart()
                        End If
                    End If
            End Select
            Return PLC_M(OutputYIndex) = "1"   '將目前 I/O 狀態傳回
        End Function
        Public Overloads Function RunM(ByVal interlock As Boolean) As Boolean
            Static Control_State As Byte
            Dim on_cond As Boolean
            pInterlock = interlock
            on_cond = pInterlock
            Select Case Control_State
                Case 0 '初始檢查ON/OFF狀態並跳往指定STATUS
                    If PLC_M(OutputYIndex) = "1" And on_cond Then  '初始狀態為 ON, 跳到狀態 3
                        Status = True
                        Control_State = 3
                    ElseIf PLC_M(OutputYIndex) = "0" Then       '初始狀態為 OFF, 跳到狀態 1
                        Status = False
                        Control_State = 1
                    Else
                        Set_MBit(OutputMIndex, DEVICE_OFF)     '初始狀態不明,強制設定為OFF 並到 跳到狀態 4
                        Status = False
                        Control_State = 4
                    End If
                Case 1  '狀態為 OFF, 等待 ON
                    If Status And on_cond Then          'PLC端 設定為 ON, 跳到 狀態5
                        Control_State = 5
                    Else
                        If PLC_M(OutputYIndex) = "1" Then  '若OUPUT 由PLC內部 ON 則更新為ON狀態 3
                            Status = True
                            Control_State = 3
                        Else
                            Status = False      '若未ON則在 狀態 1等待
                        End If
                    End If
                Case 2  'PLC 設定ON ,檢查是否已ON
                    If Not (vStatus And on_cond) Then    'PC 端命令 OFF , 設定 OFF 後到狀態4
                        Set_MBit(OutputMIndex, DEVICE_OFF)
                        Status = False
                        Control_State = 4
                    Else
                        If PLC_M(OutputYIndex) = "1" Then  'PC 端已設定ON,
                            Status = True
                            Control_State = 3
                        Else
                            Status = False
                            Control_State = 1
                        End If
                    End If
                Case 3  '輸出已ON, 等待PC命令OFF
                    If Not (vStatus And on_cond) Then
                        Set_MBit(OutputMIndex, DEVICE_OFF)
                        Status = False
                        Control_State = 4
                    ElseIf PLC_M(OutputYIndex) = "0" Then  '輸出已ON, 等待PLC命令OFF則跳到 狀態1
                        Status = False
                        Control_State = 1
                    End If
                Case 4  ' 強制 OFF , 等待 PLC OFF
                    If PLC_M(OutputYIndex) = "0" Then
                        Status = False
                        Control_State = 1
                    End If
                Case 5  'PC端設為 ON, 設定輸出命令
                    If Not (vStatus And on_cond) Then    '檢查PC 命令及 INTERLOCK
                        Status = False                  '強制OFF
                        Control_State = 4
                    Else                                '設定為ON 並跳到 狀態2
                        Set_MBit(OutputMIndex, DEVICE_ON)
                        Status = True
                        Control_State = 2
                    End If
            End Select
            Return PLC_M(OutputYIndex) = "1"   '將目前 I/O 狀態傳回
        End Function

        '5.多載 RUN 函數, 輸出點 INDEX 跟初始編號一樣, 輸入為 連結的 boolean 變數 及INTERLOCK 值, 
        '狀態點為使用內部狀態變數      '輸出為Y輸出點
        Public Overloads Function RunM(ByRef vStatus As Boolean, ByVal interlock As Boolean) As Boolean
            Static Control_State As Byte
            Dim on_cond As Boolean
            pInterlock = interlock
            on_cond = pInterlock
            Select Case Control_State
                Case 0 '初始檢查ON/OFF狀態並跳往指定STATUS

                    If PLC_M(OutputYIndex) = "1" And on_cond Then  '初始狀態為 ON, 跳到狀態 3
                        vStatus = True
                        Control_State = 3
                    ElseIf PLC_M(OutputYIndex) = "0" Then       '初始狀態為 OFF, 跳到狀態 1
                        vStatus = False
                        Control_State = 1
                    Else
                        Set_MBit(OutputMIndex, DEVICE_OFF)     '初始狀態不明,強制設定為OFF 並到 跳到狀態 4
                        vStatus = False
                        Control_State = 4
                    End If
                Case 1  '狀態為 OFF, 等待 ON
                    If vStatus And on_cond Then          'PLC端 設定為 ON, 跳到 狀態5
                        Control_State = 5
                    Else
                        If PLC_M(OutputYIndex) = "1" Then  '若OUPUT 由PLC內部 ON 則更新為ON狀態 3
                            vStatus = True
                            Control_State = 3
                        Else
                            vStatus = False      '若未ON則在 狀態 1等待
                        End If
                    End If
                Case 2  'PLC 設定ON ,檢查是否已ON
                    If Not (vStatus And on_cond) Then    'PC 端命令 OFF , 設定 OFF 後到狀態4
                        Set_MBit(OutputMIndex, DEVICE_OFF)
                        vStatus = False
                        Control_State = 4
                    Else
                        If PLC_M(OutputYIndex) = "1" Then  'PC 端已設定ON,
                            vStatus = True
                            Control_State = 3
                        Else
                            vStatus = False
                            Control_State = 1
                        End If
                    End If
                Case 3  '輸出已ON, 等待PC命令OFF
                    If Not (vStatus And on_cond) Then
                        Set_MBit(OutputMIndex, DEVICE_OFF)
                        vStatus = False
                        Control_State = 4
                    ElseIf PLC_M(OutputYIndex) = "0" Then  '輸出已ON, 等待PLC命令OFF則跳到 狀態1
                        vStatus = False
                        Control_State = 1
                    End If
                Case 4  ' 強制 OFF , 等待 PLC OFF
                    If PLC_M(OutputYIndex) = "0" Then
                        vStatus = False
                        Control_State = 1
                    End If
                Case 5  'PC端設為 ON, 設定輸出命令
                    If Not (vStatus And on_cond) Then    '檢查PC 命令及 INTERLOCK
                        vStatus = False                  '強制OFF
                        Control_State = 4
                    Else                                '設定為ON 並跳到 狀態2
                        Set_MBit(OutputMIndex, DEVICE_ON)
                        vStatus = True
                        Control_State = 2
                    End If
            End Select
            Status = vStatus
            Return PLC_M(OutputYIndex) = "1"   '將目前 I/O 狀態傳回
        End Function

    End Class

   
End Module

Module Module_Class_CheckError
    '異常檢查類別
    Public Class CheckError
        Private CountTimer As New Timer
        Private GTimerEnabled As Boolean
        Private GTimer As Integer

        '建構子, 建立計時器及處理函數
        Public Sub New()
            CountTimer.Interval = 1000
            CountTimer.Enabled = False
            AddHandler CountTimer.Tick, AddressOf TimerTick
        End Sub
        'Run(要連結的異常旗標,要檢查異常的條件式, 設定值, 現在值,秒數) => 傳回計時秒數
        Public Overloads Function Run(ByVal on_cond As Boolean, ByVal DTime As Integer) As Boolean
            Static Control_State As Integer
            Static ErrorFlag As Boolean
            Select Case Control_State
                Case 0  '檢查輸入條件式是否成立, 

                    If on_cond Then '檢查輸入條件式是否成立, 
                        '若輸入條件啟動, 則開始計時
                        GTimer = DTime
                        GTimerEnabled = True
                        CountTimer.Enabled = True
                        Control_State = 1
                    Else
                        ErrorFlag = False
                    End If
                Case 1  '等待計時間到
                    If on_cond Then '檢查輸入條件式是否成立, 
                        If GTimerEnabled = False Then '檢查計時時間是否到達, 
                            ErrorFlag = True                    '若在範圍外則為 異常
                        Else
                            ErrorFlag = False                   '若在範圍內,則正常,
                            CountTimer.Enabled = False          '停止計時器.
                            Control_State = 0
                        End If
                    Else
                        ErrorFlag = False
                        CountTimer.Enabled = False
                        Control_State = 0
                    End If
            End Select
            Return ErrorFlag
        End Function

        'Run(要連結的異常旗標,要檢查異常的條件式, 設定值, 現在值,秒數) => 傳回計時秒數
        Public Overloads Function Run(ByVal Y_cond As Boolean, ByVal X_cond As Boolean, ByVal DTime As Integer) As Boolean
            Static Control_State As Integer
            Static ErrorFlag As Boolean
            Select Case Control_State
                Case 0  '檢查輸入條件式是否成立, 

                    If Y_cond Then '檢查輸入條件式是否成立, 
                        '若輸入條件啟動, 則開始計時
                        GTimer = DTime
                        GTimerEnabled = True
                        CountTimer.Enabled = True
                        Control_State = 1
                    Else
                        ErrorFlag = False
                    End If
                Case 1  '等待計時間到
                    If Y_cond Then '檢查輸入條件式是否成立, 
                        If GTimerEnabled = False Then '檢查計時時間是否到達, 
                            ErrorFlag = True                    '若在範圍外則為 異常
                        Else
                            ErrorFlag = False                   '若在範圍內,則正常,
                            CountTimer.Enabled = False          '停止計時器.
                            Control_State = 0
                        End If
                    Else
                        ErrorFlag = False
                        CountTimer.Enabled = False
                        Control_State = 0
                    End If
            End Select
            Return ErrorFlag
        End Function

        'Run(要連結的異常旗標,要檢查異常的條件式, 設定值, 現在值,秒數) => 傳回計時秒數
        Public Overloads Function Run(ByVal on_cond As Boolean, ByVal SV As Double, ByVal PV As Double, ByVal Limit As Double, ByVal DTime As Integer) As Boolean
            Static Control_State As Integer
            Static ErrorFlag As Boolean
            Select Case Control_State
                Case 0  '檢查輸入條件式是否成立, 

                    If on_cond Then '檢查輸入條件式是否成立, 
                        '若輸入條件啟動, 則開始計時
                        GTimer = DTime
                        GTimerEnabled = True
                        CountTimer.Enabled = True
                        Control_State = 1
                    Else
                        ErrorFlag = False
                    End If
                Case 1  '等待計時間到
                    If on_cond Then '檢查輸入條件式是否成立, 
                        If GTimerEnabled = False Then '檢查計時時間是否到達, 
                            If Math.Abs(PV - SV) > Limit Then   '檢查設定值和現在值
                                ErrorFlag = True                    '若在範圍外則為 異常
                            Else
                                ErrorFlag = False                   '若在範圍內,則正常,
                                CountTimer.Enabled = False          '停止計時器.
                                Control_State = 0
                            End If
                        End If
                    Else
                        ErrorFlag = False
                        CountTimer.Enabled = False
                        Control_State = 0
                    End If
            End Select
            Return ErrorFlag
        End Function

        'Run(要連結的異常旗標,要檢查異常的條件式, 設定值, 現在值,秒數) => 傳回計時秒數
        Public Overloads Function RunLower(ByVal on_cond As Boolean, ByVal SV As Double, ByVal PV As Double, ByVal Limit As Double, ByVal DTime As Integer) As Boolean
            Static Control_State As Integer
            Static ErrorFlag As Boolean
            Select Case Control_State
                Case 0  '檢查輸入條件式是否成立, 

                    If on_cond Then '檢查輸入條件式是否成立, 
                        '若輸入條件啟動, 則開始計時
                        GTimer = DTime
                        GTimerEnabled = True
                        CountTimer.Enabled = True
                        Control_State = 1
                    Else
                        ErrorFlag = False
                    End If
                Case 1  '等待計時間到
                    If on_cond Then '檢查輸入條件式是否成立, 
                        If GTimerEnabled = False Then '檢查計時時間是否到達, 
                            If PV < (SV - Limit) Then   '檢查設定值和現在值
                                ErrorFlag = True                    '若在範圍外則為 異常
                            Else
                                ErrorFlag = False                   '若在範圍內,則正常,
                                CountTimer.Enabled = False          '停止計時器.
                                Control_State = 0
                            End If
                        End If
                    Else
                        ErrorFlag = False
                        CountTimer.Enabled = False
                        Control_State = 0
                    End If
            End Select
            Return ErrorFlag
        End Function
        'Run(要連結的異常旗標,要檢查異常的條件式, 設定值, 現在值,秒數) => 傳回計時秒數
        Public Overloads Function RunHigher(ByVal on_cond As Boolean, ByVal SV As Double, ByVal PV As Double, ByVal Limit As Double, ByVal DTime As Integer) As Boolean
            Static Control_State As Integer
            Static ErrorFlag As Boolean
            Select Case Control_State
                Case 0  '檢查輸入條件式是否成立, 

                    If on_cond Then '檢查輸入條件式是否成立, 
                        '若輸入條件啟動, 則開始計時
                        GTimer = DTime
                        GTimerEnabled = True
                        CountTimer.Enabled = True
                        Control_State = 1
                    Else
                        ErrorFlag = False
                    End If
                Case 1  '等待計時間到
                    If on_cond Then '檢查輸入條件式是否成立, 
                        If GTimerEnabled = False Then '檢查計時時間是否到達, 
                            If PV > (SV + Limit) Then   '檢查設定值和現在值
                                ErrorFlag = True                    '若在範圍外則為 異常
                            Else
                                ErrorFlag = False                   '若在範圍內,則正常,
                                CountTimer.Enabled = False          '停止計時器.
                                Control_State = 0
                            End If
                        End If
                    Else
                        ErrorFlag = False
                        CountTimer.Enabled = False
                        Control_State = 0
                    End If
            End Select
            Return ErrorFlag
        End Function
        '自帶計時程序
        Private Sub TimerTick()
            If GTimerEnabled Then
                GTimer -= 1
                If GTimer <= 0 Then
                    GTimerEnabled = False
                End If
            End If
        End Sub
    End Class
End Module

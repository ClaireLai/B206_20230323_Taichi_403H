Module Module_Button
    Public Const MAX_OUTPUT As Integer = 95
    Public Output(MAX_OUTPUT) As ValveClass

    'Public RVPb_Status As Boolean
    'Public Vent_Status As Boolean
    'Public HeaterPb_Status As Boolean

    'Public MFC01_Status As Boolean
    'Public MFC02_Status As Boolean


    'Public ChuckUpPb_Status As Boolean
    'Public ChuckDnPb_Status As Boolean

    'Public DPPb_Status As Boolean
    'Public BoundingPb_Status As Boolean

    'Public BZ_Status As Boolean
    'Public OilPump_Status As Boolean

    Public AlarmResetPb_Status As Boolean
    Public TimerStartPb_Status As Boolean
    Public CSVTimerStartPb_Status As Boolean


    Public ProcessOkALMEnabled_Status As Boolean
    Public AutoVacuum_Status As Boolean
    Public BondBeforeVacuum_Status As Boolean
    Public ProcessAutoVacuum_Status As Boolean
    Public AutoVent_Status As Boolean
    Public AutoPurge_Status As Boolean

    Public PressDAOutLow_Status As Boolean
    Public PressDAOutHigh_Status As Boolean
    'USB 後門程式, COPY COPY 配方資料及製程記錄

    Public WithEvents Button_BackWork As System.ComponentModel.BackgroundWorker
    Public Sub Button_BackWork_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles Button_BackWork.DoWork
        Static tick1, tick2, tick3, tick4 As Long
        Do
            tick1 = GetTickCount
            If Math.Abs(tick2 - tick1) > 50 Then
                tick2 = tick1
                If CommLivePLC Then
                    ReadInformation()
                    Button_Control()
                    'AutoProcess_Task()
                    UpDataDigital()
                End If
            End If
            'If Math.Abs(tick3 - tick1) > 50 Then
            '    tick3 = tick1
            '    If PLCComm.IsOpen Then
            '        FBSPLC_Control()
            '    End If
            'End If
            'If Math.Abs(tick4 - tick1) > 2000 Then
            '    tick4 = tick1
            '    Application.DoEvents()
            'Else
            System.Threading.Thread.SpinWait(1)
            'End If
        Loop
    End Sub



    ''' <summary>
    ''' 按鈕控制函數, 由M0000~M0095
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Button_Control()     ' ON 2SEC
        Dim i As Integer
        Dim on_cond As Boolean

        Output(DoVentIndex).InterLock = Not Vac1ATM_Status

        For i = 0 To 95
            on_cond = True
            Output(i).RunM()
            'Output(i).RunM(on_cond)
        Next
    End Sub
End Module

Module Module_Availability
    Public Machine_Number As String
    Public Wafer_Bond As Integer
    Public Run_Time As Integer 'sec
    Public Idel_Time As Integer 'sec
    Public StartAlarm_Time(MAXPLATE) As Date 'sec
    Public StopAlarm_Time(MAXPLATE) As Date 'sec
    Public StartLog_Time As Integer
    Public bolNewDay As Boolean = False '要記錄了
    Private bolRunCrossDay As Boolean = False '執行跨天
    Private bolAlarmCrossDay(MAXPLATE) As Boolean  '警報跨天
    Public LastRecordTime As Date
    Public NextRecordTime As Date
    Public TotalAlarmTime(MAXPLATE) As Integer
    Public MaxTotalAlarmTime As Integer
    Public TotalRun_Time As Integer = 0
    Public TotalIdel_Time As Integer
    Private LastTotalProcessTime As Integer
    Private interval As TimeSpan
    Dim UtilizationFileName As String



    ''' <summary>
    ''' 稼動率紀錄
    ''' </summary>
    Public Sub AvailabilityLog()
        Dim i As Integer
        Try
            If bolRunCrossDay Then '跨天先把天執行時間記下來
                LastTotalProcessTime = TotalProcessTime
                TotalRun_Time = TotalRun_Time + LastTotalProcessTime
            End If

            For i = 0 To MAXPLATE
                If bolAlarmCrossDay(i) Then '跨天還 alarm 紀錄當天alarm時間
                    interval = Now() - StartAlarm_Time(i)
                    TotalAlarmTime(i) = TotalAlarmTime(i) + interval.TotalSeconds
                    StartAlarm_Time(i) = Now().AddSeconds(1) '今天重算
                    bolAlarmCrossDay(i) = False
                End If
                If TotalAlarmTime(i) > MaxTotalAlarmTime Then
                    MaxTotalAlarmTime = TotalAlarmTime(i)
                End If
            Next
            TotalIdel_Time = 86400 - TotalRun_Time - MaxTotalAlarmTime
            Wafer_Bond = RunCounts
            UtilizationFileName = SystemParameters.WebPath + "\" + FDate + "-" + FTime + ".txt"
            'CheckExistDirAndCreate(UtilizationFileName)
            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter(UtilizationFileName, False)
            file.WriteLine("Machine Number=" + Program_ModelName)
            file.WriteLine("Wafer Bond=" + RunCounts.ToString)
            file.WriteLine("Run time=" + ConvertSecToTime(TotalRun_Time))
            file.WriteLine("Idel time=" + ConvertSecToTime(TotalIdel_Time.ToString))
            file.WriteLine("Alarm time=" + ConvertSecToTime(MaxTotalAlarmTime.ToString))
            file.Close()
            For i = 0 To MAXPLATE
                TotalAlarmTime(i) = 0
            Next

            MaxTotalAlarmTime = 0
            TotalRun_Time = 0
            RunCounts = 0
            WriteRunData()
            bolNewDay = False '不記錄了
            'RunCounts = Val(ReadProgData("RUNDATA", "RunCounts", "0", RunDataINIFile))
            WriteProgData("RUNDATA", "RunCounts", RunCounts.ToString, RunDataINIFile)
        Catch ex As Exception
            MessageBox.Show("請檢查遠端Log存檔路徑", ex.ToString)
        End Try

    End Sub
    ''' <summary>
    ''' 稼動率計時
    ''' </summary>
    Public Sub AvailabilityCheck()
        Dim i As Integer
        Dim ii As Integer

        Dim nullDate As New Date
        'On Error Resume Next
        If bolNewDay Then Exit Sub '要先紀錄完
        If SystemParameters.StartLog_Time = "" Then SystemParameters.StartLog_Time = "0"
        Dim TodayRecordTime As New System.DateTime(Now.Year, Now.Month, Now.Day, Convert.ToInt32(SystemParameters.StartLog_Time), 0, 0) '今天要記錄的時間
        '紀錄要記錄時間
        If NextRecordTime = nullDate Then
            If Now() > TodayRecordTime And bolNewDay = False Then
                NextRecordTime = TodayRecordTime.AddDays(1)
            Else
                NextRecordTime = TodayRecordTime
            End If
            'NextRecordTime = TodayRecordTime
        End If
        If LastRecordTime = nullDate Then
            LastRecordTime = TodayRecordTime.AddDays(-0.01)
        End If
        'Debug.Print("LastRecordTime=" + LastRecordTime.ToString + " ,NextRecordTime=" + NextRecordTime.ToString)
        If Now() > NextRecordTime Then
            bolNewDay = True '要紀錄了
            If ProcessMode_RUN Then bolRunCrossDay = True ''執行跨天
            For i = 0 To MAXPLATE
                If StartAlarm_Time(i) <> nullDate Then bolAlarmCrossDay(i) = True '有alarm
            Next
            AvailabilityLog() '紀錄
            LastRecordTime = Now()

        End If

        '累計執行時間

        If bolRunCrossDay Then  '如果跨天還再執行
            If ProcessMode_RUN Then '跨天執行中
                interval = Now() - NextRecordTime.AddDays(-1)
                LastTotalProcessTime = interval.TotalSeconds
            Else '跨天執行完
                TotalRun_Time = TotalRun_Time + LastTotalProcessTime
                '    'Debug.Print("TotalRun_Time=" + TotalRun_Time.ToString)
                LastTotalProcessTime = 0
                bolRunCrossDay = False
            End If
        Else '沒跨天
            If ProcessMode_RUN Then '沒跨天執行中
                LastTotalProcessTime = TotalProcessTime
            Else '沒跨天執行完
                TotalRun_Time = TotalRun_Time + LastTotalProcessTime
                '    'Debug.Print("TotalRun_Time=" + TotalRun_Time.ToString)
                LastTotalProcessTime = 0
                bolRunCrossDay = False
            End If
        End If

        '累計Alarm時間
        For i = 0 To MAXPLATE
            If StartAlarm_Time(i) = nullDate And CSubAutoProcess(i).AbortStatus Then '有alarm
                StartAlarm_Time(i) = Now()
                StopAlarm_Time(i) = nullDate
            ElseIf StartAlarm_Time(i) <> nullDate And CSubAutoProcess(i).AbortStatus = False Then  'Alarm解除
                StopAlarm_Time(i) = Now()
                interval = StopAlarm_Time(i) - StartAlarm_Time(i)
                TotalAlarmTime(i) = TotalAlarmTime(i) + interval.TotalSeconds
                StartAlarm_Time(i) = nullDate
                bolAlarmCrossDay(i) = False
            End If

            If TotalAlarmTime(i) > MaxTotalAlarmTime Then
                MaxTotalAlarmTime = TotalAlarmTime(i)
            End If
        Next


        If Now() > TodayRecordTime And bolNewDay = False Then
            NextRecordTime = TodayRecordTime.AddDays(1)
        Else
            NextRecordTime = TodayRecordTime
        End If

    End Sub
End Module

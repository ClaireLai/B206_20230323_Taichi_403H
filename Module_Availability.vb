Module Module_Availability
    Public Machine_Number As String
    Public Wafer_Bond As Integer
    Public Run_Time As Integer 'sec
    Public Idel_Time As Integer 'sec
    Public StartAlarm_Time As Date 'sec
    Public StopAlarm_Time As Date 'sec
    Public StartLog_Time As Integer
    Public bolNewDay As Boolean = False '要記錄了
    Public LastRecordTime As Date
    Public NextRecordTime As Date
    Public TotalAlarmTime As Integer
    Public TotalRun_Time As Integer
    Public TotalIdel_Time As Integer
    Private LastTotalProcessTime As Integer
    Dim UtilizationFileName As String



    ''' <summary>
    ''' 稼動率紀錄
    ''' </summary>
    Public Sub AvailabilityLog()
        Try
            TotalIdel_Time = 86400 - TotalRun_Time - TotalAlarmTime
            Wafer_Bond = RunCounts
            UtilizationFileName = SystemParameters.WebPath + "\" + FDate + "-" + FTime + ".txt"
            'CheckExistDirAndCreate(UtilizationFileName)
            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter(UtilizationFileName, False)
            file.WriteLine("Machine Number=" + Program_ModelName)
            file.WriteLine("Wafer Bond=" + RunCounts.ToString)
            file.WriteLine("Run time=" + ConvertSecToTime(TotalRun_Time))
            file.WriteLine("Idel time=" + ConvertSecToTime(TotalIdel_Time.ToString))
            file.WriteLine("Alarm time=" + ConvertSecToTime(TotalAlarmTime.ToString))
            file.Close()
            TotalAlarmTime = 0
            TotalRun_Time = 0
            RunCounts = 0
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
        Debug.Print("LastRecordTime=" + LastRecordTime.ToString + " ,NextRecordTime=" + NextRecordTime.ToString)
        If Now() > NextRecordTime Then
            bolNewDay = True '要紀錄了
            If ProcessMode_RUN = False Then
                AvailabilityLog() '紀錄
                LastRecordTime = Now()
            End If
        End If

        '累計執行時間
        If ProcessMode_RUN Then
            LastTotalProcessTime = TotalProcessTime
        Else
            TotalRun_Time = TotalRun_Time + LastTotalProcessTime
            'Debug.Print("TotalRun_Time=" + TotalRun_Time.ToString)
            LastTotalProcessTime = 0
        End If
        '累計Alarm時間
        For i = 0 To MAXPLATE
            If StartAlarm_Time = nullDate Then
                If CSubAutoProcess(i).AbortFlag Then
                    StartAlarm_Time = Now()
                End If
            End If
            If StartAlarm_Time <> nullDate And ProcessMode_RUN Then
                StopAlarm_Time = Now()
                Dim interval As TimeSpan = StopAlarm_Time - StartAlarm_Time
                TotalAlarmTime = TotalAlarmTime + interval.TotalSeconds
                StartAlarm_Time = nullDate
            End If
        Next
        If Now() > TodayRecordTime And bolNewDay = False Then
            NextRecordTime = TodayRecordTime.AddDays(1)
        Else
            NextRecordTime = TodayRecordTime
        End If

    End Sub
End Module

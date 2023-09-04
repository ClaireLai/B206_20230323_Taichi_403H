Module Module_CreateINIFile

    Public ProgramINIFile As String
    Public ProcessINIFile As String
    Public AlarmINIFile As String
    Public ADDAINIFile As String
    Public DeviceLifeINIFile As String
    Public DeviceDataINIFile As String
    Public ParameterINIFile As String
    Public PIDINIFile As String
    Public PLCIOMappingINIFile As String


    Public Sub InitProgramIniFile(ByVal sdir As String)
        ' 讀取程式設定資料初始化
        FormSaveINIFile = ProgramDir + "FORMSAVE.INI"
        ProgramINIFile = sdir + "PROGRAM.INI"         '程式資料INI檔案
        AlarmINIFile = sdir + "ALARM.INI"             '程式資料INI檔案
        ADDAINIFile = sdir + "ADDA_SETUP.INI"         '程式資料INI檔案
        DeviceLifeINIFile = sdir + "DEVICELIFE.INI"   '程式資料INI檔案
        DeviceDataINIFile = sdir + "DEVICEDATA.INI"   '程式資料INI檔案
        ParameterINIFile = sdir + "PARAMETER.INI"     '程式資料INI檔案
        PLCIOMappingINIFile = sdir + "PLCIOMAP.INI"   '程式資料INI檔案
        PIDINIFile = sdir + "PID.INI"
        ProcessINIFile = sdir + "PROCESS.INI"
        RunDataINIFile = ProgramDir + "RUNDATA.INI"  'Barcode 20160808 by vincent ----------------
        InitRecipe(sdir)
        InitLanguage(sdir)
        'If SystemParameters.bolDAlog Then
        '    ReadCurveNames(ProgramDir + "CURVEDATA_DA.INI")
        'Else
        '    ReadCurveNames(ProgramDir + "CURVEDATA.INI")
        'End If
        ' 建立製程用曲線
        ChartInitial()
    End Sub

    Public VideoFileName As String
    Public CsvFilename As String
    Public CsvFilename1 As String
    Public UserDataFileName As String           '使用者帳密設定檔
    Public AlarmRecordFileName As String        '異常記錄資料夾
    Public PLCAlarmRecordFileName As String     'PLC異常記錄資料夾
    Public OperatorRecordFileName As String     '使用者登入/登出記錄檔
    Public PurgeGasRecordFileName As String     '氣體管路 PURGE 資料夾, PURGE PIPE 
    Public ProcessEeventFileName As String      '製程事件檔名,含路徑,依製程檔名+EVENT建立
    Public ProcessRecordShortFileName As String
    Public ProcessRecordFileName As String
    Public ProcessRecordCurveFileName As String '製程記錄曲線檔名(*.PROC)
    Public OperateEeventLogFileName As String

    Public ProcessRecordFileName1 As String
    Public Sub CheckPLCAlarmDateAndCreate()
        Static LastDateTime As New DateTime
        Static CurrentDateTime As New DateTime
        CurrentDateTime = Now()
        If CurrentDateTime.Date <> LastDateTime.Date Then
            Dim sstr As String
            MakeDateData()        '建立日期資料
            sstr = WorkingDir & "Records\PLCAlarmRecords\" & FDate
            CheckExistDirAndCreate(sstr)
            PLCAlarmRecordFileName = sstr & "\" & FDate & ".dat"
            LastDateTime = CurrentDateTime
        End If
    End Sub


    Public Sub CheckAlarmDateAndCreate()
        Static LastDateTime As New DateTime
        Static CurrentDateTime As New DateTime
        CurrentDateTime = Now()
        If CurrentDateTime.Date <> LastDateTime.Date Then
            Dim sstr As String
            MakeDateData()        '建立日期資料
            sstr = WorkingDir & "Records\AlarmRecords\" & FDate
            CheckExistDirAndCreate(sstr)
            AlarmRecordFileName = sstr & "\" & FDate & ".dat"
            LastDateTime = CurrentDateTime
        End If
    End Sub
    Public Sub CheckProcessDateAndCreate()
        Static LastDateTime As New DateTime
        Static CurrentDateTime As New DateTime
        CurrentDateTime = Now()
        If CurrentDateTime.Date <> LastDateTime.Date Then
            Dim sstr As String

            sstr = WorkingDir & "Records\ProcessRecordCurves\" & FDate
            CheckExistDirAndCreate(sstr)
            ProcessRecordCurveDir = sstr & "\"

            sstr = WorkingDir & "Records\ProcessRecordLists\" & FDate
            CheckExistDirAndCreate(sstr)
            ProcessRecordDir = sstr & "\"

            sstr = WorkingDir & "Records\ProcessEvent\" & FDate
            CheckExistDirAndCreate(sstr)
            ProcessEeventDir = sstr & "\"

            LastDateTime = CurrentDateTime
        End If
    End Sub

    Public Sub CheckDataLogDirAndCreate()
        Static LastDateTime As New DateTime
        Static CurrentDateTime As New DateTime
        CurrentDateTime = Now()
        If CurrentDateTime.Date <> LastDateTime.Date Then
            Dim sstr As String

            sstr = WorkingDir & "Records\DataLogRecords\" & FDate
            CheckExistDirAndCreate(sstr)
            DataLogRecordDir = sstr & "\"

            LastDateTime = CurrentDateTime
        End If
    End Sub

    Public Sub CheckOperatorLogDirAndCreate()
        Static LastDateTime As New DateTime
        Static CurrentDateTime As New DateTime
        CurrentDateTime = Now()
        If CurrentDateTime.Date <> LastDateTime.Date Then
            Dim sstr As String
            sstr = WorkingDir & "Records\OperatorRecords\" & FDate
            CheckExistDirAndCreate(sstr)
            OperatorRecordFileName = sstr & "\" & FDate & ".dat"

            LastDateTime = CurrentDateTime
        End If
    End Sub
    Public Sub CheckOperatorEventLogAndCreate()
        Static LastDateTime As New DateTime
        Static CurrentDateTime As New DateTime
        CurrentDateTime = Now()
        If CurrentDateTime.Date <> LastDateTime.Date Then
            Dim sstr As String
            sstr = WorkingDir & "Records\OperateEventLog\" & FDate
            CheckExistDirAndCreate(sstr)
            OperateEeventLogFileName = sstr & "\" & "EventLog_" & FDate & ".dat"
            LastDateTime = CurrentDateTime
        End If
    End Sub
    Public Sub CheckJPGDirAndCreate()
        Static LastDateTime As New DateTime
        Static CurrentDateTime As New DateTime
        CurrentDateTime = Now()
        If CurrentDateTime.Date <> LastDateTime.Date Then
            Dim sstr As String
            sstr = WorkingDir & "Images\" & FDate
            CheckExistDirAndCreate(sstr)
            JPGDir = sstr & "\"
            LastDateTime = CurrentDateTime
        End If
    End Sub

    Public Sub CreateInitialDirectory()
        Dim sstr As String
        MakeDateData()        '建立日期資料

        ProgramDir = CurDir() + "\"
        WorkingDir = Strings.Left(ProgramDir, Len(ProgramDir) - 4)

        sstr = WorkingDir & "Records\AlarmRecords"
        CheckExistDirAndCreate(sstr)
        AlarmRecordFileName = sstr & "\" & FDate & ".dat"

        sstr = WorkingDir & "Records\OperatorRecords"
        CheckExistDirAndCreate(sstr)
        OperatorRecordFileName = sstr & "\" & FDate & ".dat"

        sstr = WorkingDir & "Records\ProcessRecordLists"
        CheckExistDirAndCreate(sstr)
        PurgeGasRecordFileName = sstr & "\" & FDate & ".dat"

        sstr = WorkingDir & "Records\VideoRecorders"
        CheckExistDirAndCreate(sstr)
        VideoRecordDir = sstr & "\"

        sstr = WorkingDir & "Records\ProcessRecordCurves"
        CheckExistDirAndCreate(sstr)
        ProcessRecordCurveDir = sstr & "\"

        sstr = WorkingDir & "Records\DataLogRecords"
        CheckExistDirAndCreate(sstr)
        DataLogRecordDir = sstr & "\"

        sstr = WorkingDir & "Records\ProcessRecordLists"
        CheckExistDirAndCreate(sstr)
        ProcessRecordDir = sstr & "\"

        sstr = WorkingDir & "Records\ProcessEvent"
        CheckExistDirAndCreate(sstr)
        ProcessEeventDir = sstr & "\"

        sstr = WorkingDir & "Records\PurgeGasRecords"
        CheckExistDirAndCreate(sstr)
        PurgeGasRecordFileName = sstr & "\" & "Purge_" & FDate & ".dat"

        sstr = WorkingDir & "Records\PIDs"
        CheckExistDirAndCreate(sstr)
        PIDsDir = sstr & "\"
        sstr = WorkingDir & "Records\CSVRecord"
        CheckExistDirAndCreate(sstr)
        ProcessCSVDir = sstr & "\"

        sstr = WorkingDir & "Recipes"
        CheckExistDirAndCreate(sstr)
        RecipeDir = sstr & "\"

        sstr = WorkingDir & "JPGs"
        CheckExistDirAndCreate(sstr)
        JPGDir = sstr & "\"

        UserDataFileName = CurDir() & "\User.dat"
    End Sub
    Public Sub CheckExistDirAndCreate(ByVal sstr As String)
        If Not My.Computer.FileSystem.DirectoryExists(sstr) Then
            My.Computer.FileSystem.CreateDirectory(sstr)
        End If
    End Sub
    Public Sub CheckExistDirAndCreateCC(ByVal sstr As String)
        If Not My.Computer.FileSystem.FileExists(sstr) Then
            'My.Computer.FileSystem.(sstr)
            MsgBox("ok")
        End If
    End Sub
End Module

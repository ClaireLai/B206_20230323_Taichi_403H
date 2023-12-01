Imports System.Runtime.InteropServices

Module Module_Parameter
    Public ColorOn As Color = Color.Lime
    Public ColorOff As Color = Color.FromArgb(255, 255, 192)


    '電流監控
    Public MonitorCurrent As Double
    Public MonitorPower As Double
    Public MonitorCurrentLimit As Double
    '目錄及檔名設定
    'Public ProgramDir As String
    Public PersonDir As String                  '使用者權限檔案
    Public AlarmRecordDir As String             '異常 記錄資料夾
    Public OperatorRecordDir As String          '使用者 記錄資料夾
    Public PurgeGasRecordDir As String          'PURGE 記錄資料夾
    Public WorkingDir As String                 '目前工作目錄   
    Public ProgramDir As String                 '目前工作目錄   
    Public ProcessRecordDir As String           '製程記錄資料夾
    Public ProcessRecordCurveDir As String      '製程記錄曲線資料夾
    Public ProcessEeventDir As String           '製程事件記錄資料夾
    Public ProcessCSVDir As String           '製程事件記錄資料夾
    Public RecipeDir As String                  '配方資料夾
    Public PIDsDir As String                    'PID 記錄資料夾
    Public VideoRecordDir As String             '錄影記錄資料夾
    Public JPGDir As String                     '使用者權限檔案
    Public JPGFileName As String                  '使用者權限檔案

    Public RecipeLongFileName As String
    Public RecipeFileName As String
    Public RecipeName As String

    Public ProcessRecipeLongFileName As String
    Public ProcessRecipeFileName As String
    Public ProcessRecipeName As String



    Public ProcessPN As String
    Public ParaVacuumMode As Integer
    Public ParaSyncMode As Integer
    Public ProcessMode_RUN As Boolean
    Public ProcessMode_Abort As Boolean
    Public ProcessNormalEnd As Boolean 'Add by Vincent TCPIP 20200716  

    Public LangStr() As String = {"_CHT", "_CHS", "ENG"}
    Public total_Process_Num As Integer
    Public ProcessStatusList(2, 99) As String


    '系統參數
    <StructLayout(LayoutKind.Sequential)> Structure SystemParameterss
        '溫控器參數-----------------------------------START
        '三個範圍 PID設定'
        Public TopP1 As String
        Public TopP2 As String
        Public TopP3 As String
        Public BotP1 As String
        Public BotP2 As String
        Public BotP3 As String
        Public TopI1 As String
        Public TopI2 As String
        Public TopI3 As String
        Public BotI1 As String
        Public BotI2 As String
        Public BotI3 As String
        Public TopD1 As String
        Public TopD2 As String
        Public TopD3 As String
        Public BotD1 As String
        Public BotD2 As String
        Public BotD3 As String
        '三個範圍 最大/最小功率設定
        Public TopMax1 As String
        Public TopMax2 As String
        Public TopMax3 As String
        Public BotMax1 As String
        Public BotMax2 As String
        Public BotMax3 As String
        Public TopMin1 As String
        Public TopMin2 As String
        Public TopMin3 As String
        Public BotMin1 As String
        Public BotMin2 As String
        Public BotMin3 As String
        '範圍分界
        Public TopLowRange As String
        Public TopHighRange As String
        Public BotLowRange As String
        Public BotHighRange As String
        '低溫時最大輸出
        Public TopLimitPowerTemp As String
        Public TopLimitPower As String
        Public BotLimitPowerTemp As String
        Public BotLimitPower As String
        '水流設定
        Public TopFlowMeterHz() As String
        Public BotFlowMeterHz() As String
        Public LowFlowAlarm As String
        '溫控器參數-----------------------------------END




        '溫度校正-----------------------------------START
        '上溫度校正
        Public TopTempCal1 As String
        Public TopTempCal2 As String
        Public TopTempCal3 As String
        Public TopTempCal4 As String
        Public TopTempCal5 As String
        Public TopTempCalX1 As String
        Public TopTempCalX2 As String
        Public TopTempCalX3 As String
        Public TopTempCalX4 As String
        Public TopTempCalX5 As String
        '下溫度校正
        Public BotTempCal1 As String
        Public BotTempCal2 As String
        Public BotTempCal3 As String
        Public BotTempCal4 As String
        Public BotTempCal5 As String
        Public BotTempCalX1 As String
        Public BotTempCalX2 As String
        Public BotTempCalX3 As String
        Public BotTempCalX4 As String
        Public BotTempCalX5 As String
        '溫度校正-----------------------------------END

        '壓力校正-----------------------------------START
        '壓力校正
        Public PressureCal1 As String
        Public PressureCal2 As String
        Public PressureCal3 As String
        Public PressureCal4 As String
        Public PressureCal5 As String

        Public PressureCalX1 As String
        Public PressureCalX2 As String
        Public PressureCalX3 As String
        Public PressureCalX4 As String
        Public PressureCalX5 As String

        Public PressFullScale As String
        Public PressZero As String

        '壓力斜率
        Public PressureRamp As String
        '壓力偏移值 (常數項)
        Public PressOffset As String
        '扣重
        Public PressureNet As String

        '壓力校正-----------------------------------END
        '控壓程序 ------------------------------------------------
        Public KgDARatio As String  '重力/油壓比

        Public Ctrl1stRange As String  '重力/油壓比
        Public Ctrl1stTime As String  '重力/油壓比
        Public Ctrl2ndtRange As String  '重力/油壓比
        Public Ctrl2ndtTime As String  '重力/油壓比
        Public Ctrl1stDiv As String  '控壓第一段輸出壓力除數

        Public ThresholdPress As String  '壓力分界
        Public ThresholdPressDiv As String  '壓力分界除數
        Public ThresholdPressRatio As String  '壓力分界以上輸出比例

        '首次壓合程序 ------------------------------------------------START
        '接觸最大壓力
        Public PlateUpPreset As String
        '第1段壓力DA
        Public Press1st As String
        '第2段壓力DA
        Public Press2nd As String
        '初始貼合壓力
        Public Press3rd As String

        '首次壓合 ------------------------------------------------END


        '警報設定----------------------------------------------------
        '幫浦電流限制
        Public PumpCurrentLimit As String
        Public PumpCurrentAlarmTime As String
        '開門冷卻溫度
        Public CoolingTemperature As String
        '高溫警報
        Public HighTempLimit As String
        Public HighPressureLimit As String
        '抽氣警報時間
        Public PumpingTime As String
        '製程結束 ALARM TIME
        Public ProcessEndBZonTime As String
        '製程結束 ALARM
        Public ProcessEndAlarm As String

        '警報設定----------------------------------------------------


        '真空單位
        Public PressureUnit As String
        '真空補償
        Public VacuumOffset As String

        '製程條件 ----------------------------------------------------START
        '製程繼續壓力範圍
        Public PressureRange As String
        '製程溫度範圍
        Public ProcessTempRange As String
        '壓力同步--製程條件
        'Public SyncPressure As String
        ''溫度同步--製程條件
        'Public SyncTemp As String
        ''時間同步--製程條件
        'Public SyncTime As String
        Public PressAverage As String
        '製程條件 ----------------------------------------------------END


        '自動 程序-------------------------------START
        '抽真空時自動 PURGE-------------------------------
        '自動PURGE
        'Public AutoPurge As String
        '自動 PURGE 週期
        Public AutoPurgeCycle As String
        '自動 PURGE ON 時間
        Public AutoPurgeOnTime As String
        '自動 PURGE OFF 時間
        Public AutoPurgeOFFTime As String

        '製程結束 ALARM
        'Public BondBeforeVacuum As String

        '抽真空時自動 PURGE-------------------------------

        '關門自動抽真空
        'Public AutoVacuum As String
        '製程中自動抽真空--PUMP會關
        Public ProcessAutoVacuum As String
        Public Vac1ATM_Select As String

        '抽真空時自動真空值
        Public ProcessVacuumAutoVac As String
        '抽真空時自動真空值
        ' Modified 990303 -Start
        Public ProcessVacuumAutoVacLo As String
        'VENT 時間
        Public VentTime As String
        '結束後自動 VENT(開門)
        'Public AutoVent As String
        '製程中斷條件
        Public AbortPressureRange As String
        Public AbortPressureRangeFlag As String
        Public AbortTempRange As String
        Public AbortTempRangeFlag As String

        '自動 程序-------------------------------END
        Public HeaterCount As String
        Public HeaterPower As String
        Public HeaterVoltage As String
        Public HeaterMonitorPower As String
        Public HeaterCurrentRate As String

        '油壓缸位置
        Public Position01Set As String
        Public Position02Set As String
        Public Position03Set As String
        Public Position04Set As String
        Public Position05Set As String
        Public Position06Set As String

        Public DistanceSet As String

        Public BarcodeOnly As String
        Public AutoRecordData As String
        Public SplitTopBotTemp As String 'Add  by Vincent 20180419  ------------------- Start
        Public SplitTopBotTempEnable As String
        Public RunConfirm As String 'Add  by Claire 20230620 
        Public WebPath As String
        'Add  by Vincent 20181016  壓力修整功能 ------------------- Start
        Public PressureAverageTimes As String
        Public PressureAverageEnable As String
        Public PeakClearEnable As String
        Public PressureAdjust As String
        Public PeakLimit As String
        Public PeakTimes As String
        'Add  by Vincent 20181016  壓力修整功能 ------------------- End
        Public VentOffDelay As String
        Public RPONPressure As String
        Public DPWaterFlowHz As String
        Public DPWaterFlowHzMax As String
        Public DPWaterFlowAlarm As String
        'Add  by claire 20230620  稼動率功能 ------------------- End
        Public StartLog_Time As String
        Public bolDAlog As Boolean '在Log時是否要紀錄DA值
    End Structure
    Public SystemParameters As SystemParameterss

    <StructLayout(LayoutKind.Sequential)> Structure ProcessRecord
        Public ProcessStep As String
        Public ProcessTime As String
        Public StepTime As String
        Public TopTemperature As String
        Public BotTemperature As String
        Public TopCurrent As String
        Public BotCurrent As String
        Public BondingPressure As String
        Public DCPower As String
        Public DCCurrent As String
        Public DPCurrent As String
        Public Vacuum As String
    End Structure
    Public ProcessRecords As ProcessRecord
    Public ProcessRecordsIndex As Long
    Public ProcessRecordsIndex_222 As Long
    Public ProcessRecordsIndex1 As Long
    Public ProcessRecordShow As ProcessRecord

    Public Sub ReadParameterFromFile(ByVal sfile As String)

        SystemParameters.LowFlowAlarm = ReadProgData("PARAMETER", "LOWFLOWALARM", "60", sfile)
        SystemParameters.PressFullScale = ReadProgData("PARAMETER", "PRESSFULLSCALE", "15000", sfile)
        SystemParameters.PressZero = ReadProgData("PARAMETER", "PRESSZERO", "0", sfile)
        SystemParameters.PressureRamp = ReadProgData("PARAMETER", "PRESSURERAMP", "0", sfile)
        SystemParameters.PressOffset = ReadProgData("PARAMETER", "PRESSOFFSET", "0", sfile)
        SystemParameters.PressureNet = ReadProgData("PARAMETER", "PRESSURENET", "0", sfile)
        SystemParameters.KgDARatio = ReadProgData("PARAMETER", "KGDARATIO", "0", sfile)
        SystemParameters.Ctrl1stRange = ReadProgData("PARAMETER", "CTRL1STRANGE", "0", sfile)
        SystemParameters.Ctrl1stTime = ReadProgData("PARAMETER", "CTRL1STTIME", "0", sfile)
        SystemParameters.Ctrl2ndtRange = ReadProgData("PARAMETER", "CTRL2NDTRANGE", "0", sfile)
        SystemParameters.Ctrl2ndtTime = ReadProgData("PARAMETER", "CTRL2NDTTIME", "0", sfile)
        SystemParameters.Ctrl1stDiv = ReadProgData("PARAMETER", "CTRL1STDIV", "0", sfile)
        SystemParameters.ThresholdPress = ReadProgData("PARAMETER", "THRESHOLDPRESS", "0", sfile)
        SystemParameters.ThresholdPressDiv = ReadProgData("PARAMETER", "THRESHOLDPRESSDIV", "0", sfile)
        SystemParameters.ThresholdPressRatio = ReadProgData("PARAMETER", "THRESHOLDPRESSRATIO", "0", sfile)
        SystemParameters.PressAverage = ReadProgData("PARAMETER", "PRESSAVERAGE", "0", sfile)
        SystemParameters.PlateUpPreset = ReadProgData("PARAMETER", "PLATEUPPRESET", "0", sfile)
        SystemParameters.Press1st = ReadProgData("PARAMETER", "PRESS1ST", "0", sfile)
        SystemParameters.Press2nd = ReadProgData("PARAMETER", "PRESS2ND", "0", sfile)
        SystemParameters.Press3rd = ReadProgData("PARAMETER", "PRESS3RD", "0", sfile)
        SystemParameters.PumpCurrentLimit = ReadProgData("PARAMETER", "PUMPCURRENTLIMIT", "5", sfile)
        SystemParameters.PumpCurrentAlarmTime = ReadProgData("PARAMETER", "PUMPCURRENTALARMTIME", "10", sfile)
        FormParameters.txtDpCurrentLimit.Text = SystemParameters.PumpCurrentLimit
        FormParameters.txtDpCurrentAlarmTime.Text = SystemParameters.PumpCurrentAlarmTime

        SystemParameters.CoolingTemperature = ReadProgData("PARAMETER", "COOLINGTEMPERATURE", "0", sfile)
        SystemParameters.HighTempLimit = ReadProgData("PARAMETER", "HIGHTEMPLIMIT", "0", sfile)
        SystemParameters.HighPressureLimit = ReadProgData("PARAMETER", "HighPressureLimit", "16000", sfile)

        SystemParameters.PumpingTime = ReadProgData("PARAMETER", "PUMPINGTIME", "0", sfile)
        SystemParameters.ProcessEndBZonTime = ReadProgData("PARAMETER", "PROCESSENDBZONTIME", "0", sfile)
        SystemParameters.ProcessEndAlarm = ReadProgData("PARAMETER", "PROCESSENDALARM", "0", sfile)
        SystemParameters.PressureRange = ReadProgData("PARAMETER", "PRESSURERANGE", "0", sfile)
        SystemParameters.ProcessTempRange = ReadProgData("PARAMETER", "PROCESSTEMPRANGE", "0", sfile)
        'SystemParameters.AutoPurge = ReadProgData("PARAMETER", "AUTOPURGE", "0", sfile)
        SystemParameters.AutoPurgeCycle = ReadProgData("PARAMETER", "AUTOPURGECYCLE", "0", sfile)
        SystemParameters.AutoPurgeOnTime = ReadProgData("PARAMETER", "AUTOPURGEONTIME", "0", sfile)
        SystemParameters.AutoPurgeOFFTime = ReadProgData("PARAMETER", "AUTOPURGEOFFTIME", "0", sfile)
        SystemParameters.ProcessVacuumAutoVac = ReadProgData("PARAMETER", "PROCESSAUTOVACUUMVAC", "2.0E-2", sfile)
        SystemParameters.VentTime = ReadProgData("PARAMETER", "VENTTIME", "0", sfile)
        'SystemParameters.AutoVacuum = ReadProgData("PARAMETER", "AUTOVACUUM", "0", sfile)
        SystemParameters.ProcessAutoVacuum = ReadProgData("PARAMETER", "PROCESSAUTOVACUUM", "0", sfile)
        SystemParameters.ProcessVacuumAutoVacLo = ReadProgData("PARAMETER", "PROCESSAUTOVACUUMVACLO", "1.0E-01", sfile)
        SystemParameters.Vac1ATM_Select = ReadProgData("PARAMETER", "VAC1ATMSELECT", "0", sfile)
        Vac1ATM_Select = GetTrue01Boolean(SystemParameters.Vac1ATM_Select)

        '----------------------------------------

        ReadHeaterCalData(ParameterINIFile)       '讀取溫度校正資料

        ProcessOkALMEnabled_Status = GetTrue01Boolean(SystemParameters.ProcessEndAlarm)
        ProcessAutoVacuum_Status = GetTrue01Boolean(SystemParameters.ProcessAutoVacuum)

        SystemParameters.HeaterCount = ReadProgData("PARAMETER", "HEATERCOUNT", "4", sfile)
        SystemParameters.HeaterPower = ReadProgData("PARAMETER", "HEATERPOWER", "750", sfile)
        SystemParameters.HeaterVoltage = ReadProgData("PARAMETER", "HEATERVOLTAGE", "220", sfile)
        SystemParameters.HeaterMonitorPower = ReadProgData("PARAMETER", "HEATERMONITORPOWER", "60", sfile)
        SystemParameters.HeaterCurrentRate = ReadProgData("PARAMETER", "HEATERCURRENTRATE", "80", sfile)
        If Val(SystemParameters.HeaterVoltage) <= 0 Then SystemParameters.HeaterVoltage = "220"
        MonitorPower = Val(SystemParameters.HeaterMonitorPower)
        MonitorCurrent = Val(SystemParameters.HeaterCount) * Val(SystemParameters.HeaterPower) / Val(SystemParameters.HeaterVoltage)
        FormParameters.lblFullCurrent.Text = Format(MonitorCurrent * MonitorPower / 100, "0.00")
        MonitorCurrentLimit = MonitorCurrent * Val(SystemParameters.HeaterCurrentRate) / 100
        FormParameters.lblHeaterCurrent.Text = Format(MonitorCurrentLimit, "0.00")

        '製程中斷設定
        SystemParameters.AbortPressureRange = ReadProgData("PARAMETER", "ABORTPRESSURERANGE", "100", sfile)
        SystemParameters.AbortTempRange = ReadProgData("PARAMETER", "ABORTTEMPRANGE", "30", sfile)

        SystemParameters.AbortPressureRangeFlag = ReadProgData("PARAMETER", "ABORTPRESSURERANGEFLAG", "0", sfile)
        SystemParameters.AbortTempRangeFlag = ReadProgData("PARAMETER", "ABORTTEMPRANGEFLAG", "0", sfile)

        FormParameters.txtAbortPressureRange.Text = SystemParameters.AbortPressureRange
        FormParameters.txtAbortTempRange.Text = SystemParameters.AbortTempRange

        FormParameters.chkPressureAbort.Checked = GetTrue01Boolean(SystemParameters.AbortPressureRangeFlag)
        FormParameters.chkTempAbort.Checked = GetTrue01Boolean(SystemParameters.AbortTempRangeFlag)

        '油壓行程設定 99.02.03  start
        SystemParameters.Position01Set = ReadProgData("PARAMETER", "POSITIONSET01", "45", sfile)
        SystemParameters.Position02Set = ReadProgData("PARAMETER", "POSITIONSET02", "45", sfile)
        SystemParameters.Position03Set = ReadProgData("PARAMETER", "POSITIONSET03", "45", sfile)
        SystemParameters.Position04Set = ReadProgData("PARAMETER", "POSITIONSET04", "45", sfile)
        SystemParameters.Position05Set = ReadProgData("PARAMETER", "POSITIONSET05", "45", sfile)
        SystemParameters.Position06Set = ReadProgData("PARAMETER", "POSITIONSET06", "45", sfile)

        FormParameters.txtPosition01Set.Text = SystemParameters.Position01Set
        FormParameters.txtPosition02Set.Text = SystemParameters.Position02Set
        FormParameters.txtPosition03Set.Text = SystemParameters.Position03Set
        FormParameters.txtPosition04Set.Text = SystemParameters.Position04Set
        FormParameters.txtPosition05Set.Text = SystemParameters.Position05Set
        FormParameters.txtPosition06Set.Text = SystemParameters.Position06Set

        SystemParameters.DistanceSet = ReadProgData("PARAMETER", "DISTANCESET", "90", sfile)
        FormParameters.txtDistanceSet.Text = SystemParameters.DistanceSet
        '油壓行程設定 99.02.03  End

        SystemParameters.BarcodeOnly = ReadProgData("PARAMETER", "BarcodeOnly", "0", sfile)
        SystemParameters.AutoRecordData = ReadProgData("PARAMETER", "AutoRecordData", "0", sfile)
        SystemParameters.SplitTopBotTemp = ReadProgData("PARAMETER", "SplitTopBotTemp", "0", sfile) 'Add  by Vincent 20180419  ------------------- Start
        SystemParameters.SplitTopBotTempEnable = ReadProgData("PARAMETER", "SplitTopBotTempEnable", "0", sfile)

        'WriteParameterToFile(sfile)
        'Add  by Vincent 20181016  壓力修整功能 ------------------- Start
        SystemParameters.PressureAverageTimes = ReadProgData("PARAMETER", "PressureAverageTimes", "1", sfile)
        SystemParameters.PressureAverageEnable = ReadProgData("PARAMETER", "PressureAverageEnable", "0", sfile)
        SystemParameters.PeakClearEnable = ReadProgData("PARAMETER", "PeakClearEnable", "0", sfile)
        SystemParameters.PressureAdjust = ReadProgData("PARAMETER", "PressureAdjust", "0", sfile)
        SystemParameters.PeakLimit = ReadProgData("PARAMETER", "PeakLimit", "0", sfile)
        SystemParameters.PeakTimes = ReadProgData("PARAMETER", "PeakTimes", "3", sfile)
        'Add  by Vincent 20181016  壓力修整功能 ------------------- End

        SystemParameters.VentOffDelay = ReadProgData("PARAMETER", "VentOffDelay", "10", sfile)  'Add  by Vincent 20210318
        SystemParameters.RPONPressure = ReadProgData("PARAMETER", "RPONPressure", "50", sfile)  'Add  by Vincent 20210318
        SystemParameters.DPWaterFlowHz = ReadProgData("PARAMETER", "DPWaterFlowHz", "135", sfile)  'Add  by Vincent 20210318
        SystemParameters.DPWaterFlowHzMax = ReadProgData("PARAMETER", "DPWaterFlowHzMax", "20", sfile)  'Add  by Vincent 20210318
        SystemParameters.DPWaterFlowAlarm = ReadProgData("PARAMETER", "DPWaterFlowAlarm", "4.0", sfile)  'Add  by Vincent 20210318

        SystemParameters.StartLog_Time = ReadProgData("PARAMETER", "StartLog_Time", "0", sfile)  'Add  by claire 20230620
        SystemParameters.RunConfirm = ReadProgData("PARAMETER", "RunConfirm", "0", sfile)
        SystemParameters.WebPath = ReadProgData("PARAMETER", "WebPath", "", sfile)
        If (SystemParameters.WebPath = "") Then MessageBox.Show("請檢查遠端 稼動率Log存檔位置")
        If Val(SystemParameters.DPWaterFlowHz) <= 0 Then
            SystemParameters.DPWaterFlowHz = "135"
        End If
        If Val(SystemParameters.DPWaterFlowHzMax) <= 0 Then
            SystemParameters.DPWaterFlowHzMax = "20"
        End If
        SystemParameters.bolDAlog = ReadProgData("PARAMETER", "DALog", "0", sfile)  'Add  by claire 20230901



    End Sub
    '將資料結構寫入檔案內
    Public Sub WriteParameterToFile(ByVal sfile As String)
        Dim i As Integer


        WriteProgData("PARAMETER", "LOWFLOWALARM", SystemParameters.LowFlowAlarm, sfile)

        WriteHeaterCalData(sfile)
        WritePressCalData(sfile)
        WriteProgData("PARAMETER", "PRESSFULLSCALE", SystemParameters.PressFullScale, sfile)
        WriteProgData("PARAMETER", "PRESSZERO", SystemParameters.PressZero, sfile)

        WriteProgData("PARAMETER", "PRESSURERAMP", SystemParameters.PressureRamp, sfile)
        WriteProgData("PARAMETER", "PRESSOFFSET", SystemParameters.PressOffset, sfile)
        WriteProgData("PARAMETER", "PRESSURENET", SystemParameters.PressureNet, sfile)
        WriteProgData("PARAMETER", "KGDARATIO", SystemParameters.KgDARatio, sfile)
        WriteProgData("PARAMETER", "CTRL1STRANGE", SystemParameters.Ctrl1stRange, sfile)
        WriteProgData("PARAMETER", "CTRL1STTIME", SystemParameters.Ctrl1stTime, sfile)
        WriteProgData("PARAMETER", "CTRL2NDTRANGE", SystemParameters.Ctrl2ndtRange, sfile)
        WriteProgData("PARAMETER", "CTRL2NDTTIME", SystemParameters.Ctrl2ndtTime, sfile)
        WriteProgData("PARAMETER", "CTRL1STDIV", SystemParameters.Ctrl1stDiv, sfile)
        WriteProgData("PARAMETER", "THRESHOLDPRESS", SystemParameters.ThresholdPress, sfile)
        WriteProgData("PARAMETER", "THRESHOLDPRESSDIV", SystemParameters.ThresholdPressDiv, sfile)
        WriteProgData("PARAMETER", "THRESHOLDPRESSRATIO", SystemParameters.ThresholdPressRatio, sfile)
        WriteProgData("PARAMETER", "PRESSAVERAGE", SystemParameters.PressAverage, sfile)
        WriteProgData("PARAMETER", "PLATEUPPRESET", SystemParameters.PlateUpPreset, sfile)
        WriteProgData("PARAMETER", "PRESS1ST", SystemParameters.Press1st, sfile)
        WriteProgData("PARAMETER", "PRESS2ND", SystemParameters.Press2nd, sfile)
        WriteProgData("PARAMETER", "PRESS3RD", SystemParameters.Press3rd, sfile)
        WriteProgData("PARAMETER", "PUMPCURRENTLIMIT", SystemParameters.PumpCurrentLimit, sfile)
        WriteProgData("PARAMETER", "PUMPCURRENTALARMTIME", SystemParameters.PumpCurrentAlarmTime, sfile)

        WriteProgData("PARAMETER", "COOLINGTEMPERATURE", SystemParameters.CoolingTemperature, sfile)
        WriteProgData("PARAMETER", "HIGHTEMPLIMIT", SystemParameters.HighTempLimit, sfile)
        WriteProgData("PARAMETER", "HighPressureLimit", SystemParameters.HighPressureLimit, sfile)

        WriteProgData("PARAMETER", "PUMPINGTIME", SystemParameters.PumpingTime, sfile)
        WriteProgData("PARAMETER", "PROCESSENDBZONTIME", SystemParameters.ProcessEndBZonTime, sfile)
        WriteProgData("PARAMETER", "PROCESSENDALARM", SystemParameters.ProcessEndAlarm, sfile)
        WriteProgData("PARAMETER", "PRESSURERANGE", SystemParameters.PressureRange, sfile)
        WriteProgData("PARAMETER", "PROCESSTEMPRANGE", SystemParameters.ProcessTempRange, sfile)
        WriteProgData("PARAMETER", "AUTOPURGECYCLE", SystemParameters.AutoPurgeCycle, sfile)
        WriteProgData("PARAMETER", "AUTOPURGEONTIME", SystemParameters.AutoPurgeOnTime, sfile)
        WriteProgData("PARAMETER", "AUTOPURGEOFFTIME", SystemParameters.AutoPurgeOFFTime, sfile)
        WriteProgData("PARAMETER", "PROCESSAUTOVACUUMVAC", SystemParameters.ProcessVacuumAutoVac, sfile)
        WriteProgData("PARAMETER", "VENTTIME", SystemParameters.VentTime, sfile)
        WriteProgData("PARAMETER", "PROCESSAUTOVACUUM", SystemParameters.ProcessAutoVacuum, sfile)
        WriteProgData("PARAMETER", "PROCESSAUTOVACUUMVACLO", SystemParameters.ProcessVacuumAutoVacLo, sfile)
        '自動PURGE
        WriteProgData("PARAMETER", "VAC1ATMSELECT", SystemParameters.Vac1ATM_Select, sfile)
        WriteProgData("PARAMETER", "AUTOVENT", GetTrue01String(AutoVent_Status), sfile)
        WriteProgData("PARAMETER", "AUTOPURGE", GetTrue01String(AutoPurge_Status), sfile)
        WriteProgData("PARAMETER", "AUTOPURGEOFFTIME", SystemParameters.AutoPurgeOFFTime, sfile)
        WriteProgData("PARAMETER", "AUTOPURGEONTIME", SystemParameters.AutoPurgeOnTime, sfile)
        WriteProgData("PARAMETER", "AUTOPURGECYCLE", SystemParameters.AutoPurgeCycle, sfile)

        WriteProgData("PARAMETER", "HEATERCOUNT", SystemParameters.HeaterCount, sfile)
        WriteProgData("PARAMETER", "HEATERPOWER", SystemParameters.HeaterPower, sfile)
        WriteProgData("PARAMETER", "HEATERVOLTAGE", SystemParameters.HeaterVoltage, sfile)
        WriteProgData("PARAMETER", "HEATERMONITORPOWER", SystemParameters.HeaterMonitorPower, sfile)
        WriteProgData("PARAMETER", "HEATERCURRENTRATE", SystemParameters.HeaterCurrentRate, sfile)

        '製程中斷設定
        WriteProgData("PARAMETER", "ABORTPRESSURERANGE", SystemParameters.AbortPressureRange, sfile)
        WriteProgData("PARAMETER", "ABORTTEMPRANGE", SystemParameters.AbortTempRange, sfile)

        WriteProgData("PARAMETER", "ABORTPRESSURERANGEFLAG", SystemParameters.AbortPressureRangeFlag, sfile)
        WriteProgData("PARAMETER", "ABORTTEMPRANGEFLAG", SystemParameters.AbortTempRangeFlag, sfile)

        '油壓行程設定
        WriteProgData("PARAMETER", "POSITIONSET01", SystemParameters.Position01Set, sfile)
        WriteProgData("PARAMETER", "POSITIONSET02", SystemParameters.Position02Set, sfile)
        WriteProgData("PARAMETER", "POSITIONSET03", SystemParameters.Position03Set, sfile)
        WriteProgData("PARAMETER", "POSITIONSET04", SystemParameters.Position04Set, sfile)
        WriteProgData("PARAMETER", "POSITIONSET05", SystemParameters.Position05Set, sfile)
        WriteProgData("PARAMETER", "POSITIONSET06", SystemParameters.Position06Set, sfile)
        WriteProgData("PARAMETER", "DISTANCESET", SystemParameters.DistanceSet, sfile)


        WriteProgData("PARAMETER", "BarcodeOnly", SystemParameters.BarcodeOnly, sfile)
        WriteProgData("PARAMETER", "AutoRecordData", SystemParameters.AutoRecordData, sfile)
        WriteProgData("PARAMETER", "SplitTopBotTemp", SystemParameters.SplitTopBotTemp, sfile) 'Add  by Vincent 20180419  ------------------- Start
        WriteProgData("PARAMETER", "VentOffDelay", SystemParameters.VentOffDelay, sfile) 'Add  by Vincent 20210318  
        WriteProgData("PARAMETER", "RPONPressure", SystemParameters.RPONPressure, sfile) 'Add  by Vincent 20210318  
        WriteProgData("PARAMETER", "DPWaterFlowHz", SystemParameters.DPWaterFlowHz, sfile) 'Add  by Vincent 20210318  
        WriteProgData("PARAMETER", "DPWaterFlowHzMax", SystemParameters.DPWaterFlowHzMax, sfile) 'Add  by Vincent 20210318  
        WriteProgData("PARAMETER", "DPWaterFlowAlarm", SystemParameters.DPWaterFlowAlarm, sfile) 'Add  by Vincent 20210318
        '
        WriteProgData("PARAMETER", "StartLog_Time", SystemParameters.StartLog_Time, sfile) 'Add  by claire 20230620
        WriteProgData("PARAMETER", "RunConfirm", SystemParameters.RunConfirm, sfile)
        WriteProgData("PARAMETER", "WebPath", SystemParameters.WebPath, sfile)

        WriteProgData("PARAMETER", "DALog", SystemParameters.bolDAlog, sfile)
    End Sub


    '讀取製程所有字串
    Public Sub ReadProcessString()
        '讀取製程字串
        total_Process_Num = ReadStatusString("PROCESS", ProcessStatusList, ProcessINIFile)    '讀取製程字串 3 語
    End Sub
    '讀取執字串,3語
    'process = 製程名稱,INI 檔案設定為==>  若 process= "PROCESS" [process"_
    'ReadStatusString (製程名,儲存3語之2維陣列, 檔案名) 傳回字串總數 --> 定義於 XXXX_=40
    '中文字串定義如下, 簡體則為 _CHS, 英文為 _ENG
    '[PROCESS_CHT]   
    'PROCESS_NUM=10
    'PROCESS00=製程開始
    'PROCESS01=抽真空
    '.....餘類推
    '一次讀三種語言存入陣列中
    Public Function ReadStatusString(ByVal process As String, ByRef sstr(,) As String, ByVal sfile As String) As Integer
        Dim para, section As String
        Dim i, j, num As Integer
        section = process & LangStr(0)
        num = Val(ReadProgData(section, process & "_NUM", "0", sfile))
        If num > 0 Then
            For j = 0 To 2
                Select Case j
                    Case 0
                        section = process + "_CHT"
                    Case 1
                        section = process + "_CHT"
                    Case 2
                        section = process + "_ENG"
                End Select
                For i = 0 To num
                    para = process & Format(i, "00")
                    If j = 1 Then
                        sstr(j, i) = StrConv(sstr(0, i), VbStrConv.SimplifiedChinese, 2052)
                    Else
                        sstr(j, i) = ReadProgData(section, para, "No Message.", sfile)
                    End If
                Next
            Next j
        End If
        Return num
    End Function


    Public FlowMeterMode As Boolean

    Public Sub ReadFlowMeterMode(ByVal sfile As String)
        FlowMeterMode = GetTrue01Boolean(ReadProgData("FLOW_SETUP", "FLOWMETERMODE", "0", sfile))
        FlowMeterMode = True
        ReDim SystemParameters.TopFlowMeterHz(6)
        ReDim SystemParameters.BotFlowMeterHz(6)
        WriteProgData("FLOW_SETUP", "FLOWMETERMODE", GetTrue01String(FlowMeterMode), sfile)
    End Sub

    Public Sub WriteFlowMeterMode(ByVal sfile As String)
        WriteProgData("FLOW_SETUP", "FLOWMETERMODE", GetTrue01String(FlowMeterMode), sfile)
    End Sub

    Public Sub ReadIniFile()
        'PLC_IO_MAPPING(PLCIOMappingINIFile)
        ReadFormAlarmstring(AlarmINIFile)
        ReadProgramCaption(ProgramINIFile)
        ReadProgramMode(ProgramINIFile)
        ReadVacuumSetup(ProgramINIFile)         '讀取真空計設定
        DeviceLifeTimeInit()                    '初始化裝置壽命
        PLCADDADefine(ADDAINIFile)                            '設定 PLC 的AD/DA 資料
        ReadProcessString()
        ReadIOName(LangCHTINIFile, LangCHSINIFile, LangEngINIFile)
        '讀取曲線檔名
    End Sub

End Module



Public Class FormParameter
    Inherits System.Windows.Forms.Form
    Dim TempTab1 As TabPage
    Private DoorChk As Boolean
    Private txtC_Time As Integer = 200 ''By chesly 20181023 壓缸自動循環動作/Sec
    Private txtCR_Time As Integer = 999 'By chesly 20181023 壓缸自動循環動作/次數
    Private tempi As Integer
    Private bolUp As Boolean
    'Public Resistance_ruler_Flag As Boolean
    '#Const SanAn_TCPIP_Used = 0
#Region " Windows Form 設計工具產生的程式碼 "
    Friend WithEvents lblPurgeOnText As System.Windows.Forms.Label
    Friend WithEvents txtPurgeONTime As System.Windows.Forms.TextBox
    Friend WithEvents txtPurgeOFFTime As System.Windows.Forms.TextBox
    Friend WithEvents lblTimes01Text As System.Windows.Forms.Label
    Friend WithEvents lblPurgeOffText As System.Windows.Forms.Label
    Friend WithEvents txtPurgeCycle As System.Windows.Forms.TextBox
    Friend WithEvents lblProcessAutoVacuumText As System.Windows.Forms.Label
    Friend WithEvents btnProcessAutoVacuum As System.Windows.Forms.Button
    Friend WithEvents lblVentTimeText As System.Windows.Forms.Label
    Friend WithEvents txtVentTime As System.Windows.Forms.TextBox
    Friend WithEvents lblSec04Text As System.Windows.Forms.Label
    Friend WithEvents tabParameter As System.Windows.Forms.TabControl
    Friend WithEvents TabPageTIC As System.Windows.Forms.TabPage
    Friend WithEvents TabPageSystem As System.Windows.Forms.TabPage
    Friend WithEvents TabPageCello As System.Windows.Forms.TabPage
    Friend WithEvents txtProcessVacSet As System.Windows.Forms.TextBox
    Friend WithEvents lblTorr01Text As System.Windows.Forms.Label
    Friend WithEvents btnLoadPIDFile As System.Windows.Forms.Button
    Friend WithEvents btnSavePIDFile As System.Windows.Forms.Button
    Friend WithEvents txtPIDFileName As System.Windows.Forms.TextBox
    Friend WithEvents grpPIDLoadSave As System.Windows.Forms.GroupBox
    Friend WithEvents lblLowFlowAlarmText As System.Windows.Forms.Label
    Friend WithEvents txtLowFlowAlarm As System.Windows.Forms.TextBox
    Friend WithEvents lblFlowUnit01Text As System.Windows.Forms.Label
    Friend WithEvents grpAlarmSetup As System.Windows.Forms.GroupBox
    Friend WithEvents lblSec05Text As System.Windows.Forms.Label
    Friend WithEvents grpPurgeSetup As System.Windows.Forms.GroupBox
    Friend WithEvents picCelloTitleEng As System.Windows.Forms.PictureBox
    Friend WithEvents picCelloTitle As System.Windows.Forms.PictureBox
    Friend WithEvents picCelloLogo As System.Windows.Forms.PictureBox
    Friend WithEvents tabPIDSetup As System.Windows.Forms.TabControl
    Friend WithEvents tabPage1to3 As System.Windows.Forms.TabPage
    Friend WithEvents flwPIDPage1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents tabPage4to6 As System.Windows.Forms.TabPage
    Friend WithEvents flwPIDPage2 As System.Windows.Forms.FlowLayoutPanel
    'Friend WithEvents ControlPressCal1 As CELLO.ControlPressCal
    'Friend WithEvents ControlPressCal2 As CELLO.ControlPressCal
    'Friend WithEvents ControlPressCal3 As CELLO.ControlPressCal
    'Friend WithEvents ControlPressCal4 As CELLO.ControlPressCal
    'Friend WithEvents ControlPressCal5 As CELLO.ControlPressCal
    'Friend WithEvents ControlPressCal6 As CELLO.ControlPressCal
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents grpVacuum As System.Windows.Forms.GroupBox
    Friend WithEvents grpProcessCondition As System.Windows.Forms.GroupBox
    Friend WithEvents lblKg21Text As System.Windows.Forms.Label
    Friend WithEvents picC06 As System.Windows.Forms.PictureBox
    Friend WithEvents lblTopLowLimitTempText As System.Windows.Forms.Label
    Friend WithEvents lblProcessPressAlarmTimeText As System.Windows.Forms.Label
    Friend WithEvents lblSec09Text As System.Windows.Forms.Label
    Friend WithEvents txtProcessPressAlarmTime As System.Windows.Forms.TextBox
    Friend WithEvents lblProcessTempAlarmTimeText As System.Windows.Forms.Label
    Friend WithEvents lblSec08Text As System.Windows.Forms.Label
    Friend WithEvents txtProcessTempAlarmTime As System.Windows.Forms.TextBox
    Friend WithEvents lblPressAlarmTimeText As System.Windows.Forms.Label
    Friend WithEvents lblSec06Text As System.Windows.Forms.Label
    Friend WithEvents txtPressAlarmTime As System.Windows.Forms.TextBox
    Friend WithEvents lblTempAlarmTimeText As System.Windows.Forms.Label
    Friend WithEvents lblSec07Text As System.Windows.Forms.Label
    Friend WithEvents txtTempAlarmTime As System.Windows.Forms.TextBox
    Friend WithEvents txtTopLowLimitTemp As System.Windows.Forms.TextBox
    Friend WithEvents lblTopLowLimitPowerText As System.Windows.Forms.Label
    Friend WithEvents txtTopLowLimitPower As System.Windows.Forms.TextBox
    Friend WithEvents lblPercent07Text As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents chkTempAbort As System.Windows.Forms.CheckBox
    Friend WithEvents chkPressureAbort As System.Windows.Forms.CheckBox
    Friend WithEvents lblKg22Text As System.Windows.Forms.Label
    Friend WithEvents txtAbortPressureRange As System.Windows.Forms.TextBox
    Friend WithEvents lblAbortTempRangeText As System.Windows.Forms.Label
    Friend WithEvents lblAbortPressureRangeText As System.Windows.Forms.Label
    Friend WithEvents txtAbortTempRange As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txtMaxTempPower As System.Windows.Forms.TextBox
    Friend WithEvents lblTempMaxPowText As System.Windows.Forms.Label
    Friend WithEvents lblPer03Text As System.Windows.Forms.Label
    Friend WithEvents txtDpCurrentAlarmTime As System.Windows.Forms.TextBox
    Friend WithEvents lblSec24Text As System.Windows.Forms.Label
    Friend WithEvents txtPosition01Set As System.Windows.Forms.TextBox
    Friend WithEvents lblPositionSetText As System.Windows.Forms.Label
    Friend WithEvents lblmm02Text As System.Windows.Forms.Label
    Friend WithEvents lblPlate03Text As System.Windows.Forms.Label
    Friend WithEvents lblPlate02Text As System.Windows.Forms.Label
    Friend WithEvents lblPlate01Text As System.Windows.Forms.Label
    Friend WithEvents txtPosition03Set As System.Windows.Forms.TextBox
    Friend WithEvents txtPosition02Set As System.Windows.Forms.TextBox
    Friend WithEvents lblPlate06Text As System.Windows.Forms.Label
    Friend WithEvents lblPlate05Text As System.Windows.Forms.Label
    Friend WithEvents lblPlate04Text As System.Windows.Forms.Label
    Friend WithEvents txtPosition06Set As System.Windows.Forms.TextBox
    Friend WithEvents txtPosition05Set As System.Windows.Forms.TextBox
    Friend WithEvents txtPosition04Set As System.Windows.Forms.TextBox
    Friend WithEvents lblmm03Text As System.Windows.Forms.Label
    Friend WithEvents lblProcessVacSetText As System.Windows.Forms.Label
    Friend WithEvents lblProcessVacSetLoText As System.Windows.Forms.Label
    Friend WithEvents lblTorr03Text As System.Windows.Forms.Label
    Friend WithEvents txtProcessVacSetLo As System.Windows.Forms.TextBox
    Friend WithEvents pnlFlowShow As System.Windows.Forms.Panel
    Friend WithEvents lblBotFlow06 As System.Windows.Forms.Label
    Friend WithEvents lbllmin01Text As System.Windows.Forms.Label
    Friend WithEvents lblBotFlow05 As System.Windows.Forms.Label
    Friend WithEvents lblBotFlow04 As System.Windows.Forms.Label
    Friend WithEvents lblBotFlow03 As System.Windows.Forms.Label
    Friend WithEvents lblBotFlow02 As System.Windows.Forms.Label
    Friend WithEvents lblBotFlow01 As System.Windows.Forms.Label
    Friend WithEvents lblSite06 As System.Windows.Forms.Label
    Friend WithEvents lblTopFlow06 As System.Windows.Forms.Label
    Friend WithEvents lblSite05 As System.Windows.Forms.Label
    Friend WithEvents lblTopFlow05 As System.Windows.Forms.Label
    Friend WithEvents lblSite04 As System.Windows.Forms.Label
    Friend WithEvents lblTopFlow04 As System.Windows.Forms.Label
    Friend WithEvents lblSite03 As System.Windows.Forms.Label
    Friend WithEvents lblTopFlow03 As System.Windows.Forms.Label
    Friend WithEvents lblSite02 As System.Windows.Forms.Label
    Friend WithEvents lblSite01Text As System.Windows.Forms.Label
    Friend WithEvents lblTopFlow02 As System.Windows.Forms.Label
    Friend WithEvents lblTopFlow01 As System.Windows.Forms.Label
    Friend WithEvents TabPageTCal As System.Windows.Forms.TabPage
    Friend WithEvents flwTempCalUser As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents TabPagePCal As System.Windows.Forms.TabPage
    Friend WithEvents flwPressCalUser As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents txtDPTempAlarmOff As System.Windows.Forms.TextBox
    Friend WithEvents txtDPTempAlarmText As System.Windows.Forms.TextBox
    Friend WithEvents lblDPTempAlarmOffText As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents lblDPTempAlarmText As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents txtHiPressureLimit As System.Windows.Forms.TextBox
    Friend WithEvents lblHiPressureLimitText As System.Windows.Forms.Label
    Friend WithEvents lblKg05Text As System.Windows.Forms.Label
    Friend WithEvents pnlSplitTopBotTemp As System.Windows.Forms.Panel
    Friend WithEvents chkSplitTopBotTemp As System.Windows.Forms.CheckBox
    Friend WithEvents lblTempTrackDescribeText As System.Windows.Forms.Label
    Friend WithEvents btnTempTrackDisable As System.Windows.Forms.Button
    Friend WithEvents lblTempTrackTemp As System.Windows.Forms.Label
    Friend WithEvents TabPageCIM As System.Windows.Forms.TabPage
    Friend WithEvents CtlSanAnCIMSetup1 As CELLO.ctlSanAnCIMSetup
    Friend WithEvents chkCIMUsed As System.Windows.Forms.CheckBox
    Friend WithEvents lblPullerTimeText As System.Windows.Forms.Label
    Friend WithEvents lblSec12Text As System.Windows.Forms.Label
    Friend WithEvents txtPullerTime As System.Windows.Forms.TextBox
    Friend WithEvents lblDoorCloseTime As System.Windows.Forms.Label
    Friend WithEvents lblSec13Text As System.Windows.Forms.Label
    Friend WithEvents txtDoorCloseTime As System.Windows.Forms.TextBox
    Friend WithEvents lblProcessPumpVacuumText As System.Windows.Forms.Label
    Friend WithEvents lblTorr09Text As System.Windows.Forms.Label
    Friend WithEvents txtProcessPumpVacuum As System.Windows.Forms.TextBox
    Friend WithEvents txtProcessPumpTime As System.Windows.Forms.TextBox
    Friend WithEvents lblProcessPumpTimeText As System.Windows.Forms.Label
    Friend WithEvents lblSec14Text As System.Windows.Forms.Label
    Friend WithEvents pnlDPTemp As System.Windows.Forms.Panel
    Friend WithEvents pnlDPWaterFlow As System.Windows.Forms.Panel
    Friend WithEvents txtDPWaterFlowAlarm As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblDPWaterAlarmText As System.Windows.Forms.Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents chkAutoRecordData As CheckBox
    Friend WithEvents chkBarcodeOnly As CheckBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents chkRunConfirm As CheckBox
    Friend WithEvents txtWebPath As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents dudLogStartTime As DomainUpDown
    Friend WithEvents btnSelPath As Button
    Friend WithEvents chkAvailBarCode As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnSite3Cal As Button
    Friend WithEvents btnSite2Cal As Button
    Friend WithEvents btnSite1Cal As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents tabSystem As TabControl
    Friend WithEvents tabpageTempCal As TabPage
    Friend WithEvents pnlHeaterSetup As Panel
    Friend WithEvents chkSplitTopBotTempEnable As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTempRiseComp As TextBox
    Friend WithEvents lblTempRiseCompText As Label
    Friend WithEvents lblHeaterCountText As Label
    Friend WithEvents lblS01Text As Label
    Friend WithEvents lblHeaterPowerText As Label
    Friend WithEvents txtHeaterAlarmTime As TextBox
    Friend WithEvents lblHeaterVoltageText As Label
    Friend WithEvents lblHeaterAlarmTimeText As Label
    Friend WithEvents txtHeaterVoltage As TextBox
    Friend WithEvents lblFullCurrentText As Label
    Friend WithEvents txtHeaterPower As TextBox
    Friend WithEvents lblA02Text As Label
    Friend WithEvents txtHeaterCount As TextBox
    Friend WithEvents lblFullCurrent As Label
    Friend WithEvents lblW01Text As Label
    Friend WithEvents lblHeaterCurrentText As Label
    Friend WithEvents lblV02Text As Label
    Friend WithEvents lblA03Text As Label
    Friend WithEvents lblHeaterMonitorPowerText As Label
    Friend WithEvents lblHeaterCurrent As Label
    Friend WithEvents txtHeaterMonitorPower As TextBox
    Friend WithEvents lblPer01Text As Label
    Friend WithEvents lblPer02Text As Label
    Friend WithEvents txtHeaterCurrentRate As TextBox
    Friend WithEvents lblHeaterCurrentRateText As Label
    Friend WithEvents flwTempCal As FlowLayoutPanel
    Friend WithEvents tabpageVacuum As TabPage
    Friend WithEvents grpFlowMeter As GroupBox
    Friend WithEvents lblDPWaterFlowMaxText As Label
    Friend WithEvents txtDPWaterFlowMax As TextBox
    Friend WithEvents lblDPWaterFlowHzText As Label
    Friend WithEvents txtDPWaterFlowHz As TextBox
    Friend WithEvents btnFlowMode As Button
    Friend WithEvents lblFlowModeText As Label
    Friend WithEvents lblFlowDescriptionText As Label
    Friend WithEvents lblFlowSamplingTimeText As Label
    Friend WithEvents txtFlowSamplingTime As TextBox
    Friend WithEvents lblSec11Text As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radPSG500 As RadioButton
    Friend WithEvents radPCG550 As RadioButton
    Friend WithEvents radAPG100 As RadioButton
    Friend WithEvents radZSE40 As RadioButton
    Friend WithEvents radAP2004 As RadioButton
    Friend WithEvents radGP275 As RadioButton
    Friend WithEvents grpPumpType As GroupBox
    Friend WithEvents radUlvacLS120 As RadioButton
    Friend WithEvents lblDPTempCalText As Label
    Friend WithEvents txtDPTempCalSet As TextBox
    Friend WithEvents picC02 As PictureBox
    Friend WithEvents radMachinePump As RadioButton
    Friend WithEvents radDryPump As RadioButton
    Friend WithEvents flwFlowSetup As FlowLayoutPanel
    Friend WithEvents grpVacuumSetup As GroupBox
    Friend WithEvents txtRPOnPressure As TextBox
    Friend WithEvents lblRPOnPressureText As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtVentOffDelay As TextBox
    Friend WithEvents lblVentOffDelay As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn1ATMSelect As Button
    Friend WithEvents txtRVONDelay As TextBox
    Friend WithEvents lblRVONDelayText As Label
    Friend WithEvents lbl1ATM As Label
    Friend WithEvents txt1ATMVac As TextBox
    Friend WithEvents txtBasePressureTest As TextBox
    Friend WithEvents txtCHVacOffsetVoltage As TextBox
    Friend WithEvents lbl1Atm02Text As Label
    Friend WithEvents lblTorr05Text As Label
    Friend WithEvents lblTorr02Text As Label
    Friend WithEvents lblSec10Text As Label
    Friend WithEvents lblV01Text As Label
    Friend WithEvents lblZSE40UseText As Label
    Friend WithEvents lblCHVacOffsetVoltageText As Label
    Friend WithEvents lblVacuumOriginal As Label
    Friend WithEvents lblBasePressure As Label
    Friend WithEvents lblVacuumCaled As Label
    Friend WithEvents lblVacuumCaledText As Label
    Friend WithEvents tabpagePressCal As TabPage
    Friend WithEvents flwPressCal As FlowLayoutPanel
    Friend WithEvents tabpagePressControl As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnlog As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtdown As TextBox
    Friend WithEvents txtup As TextBox
    Friend WithEvents txtinterval As TextBox
    Friend WithEvents btDn As Button
    Friend WithEvents btUp As Button
    Friend WithEvents btnForceDAOut As Button
    Friend WithEvents pnlPressureAverage As Panel
    Friend WithEvents lbPeakClearTimes As Label
    Friend WithEvents rdoPeakClear As RadioButton
    Friend WithEvents Button2 As Button
    Friend WithEvents rdoPressureAverage As RadioButton
    Friend WithEvents txtPeakTimes As TextBox
    Friend WithEvents lblPeakTimesText As Label
    Friend WithEvents txtPeakLimit As TextBox
    Friend WithEvents lblTimes03Text As Label
    Friend WithEvents lblTimes02Text As Label
    Friend WithEvents txtPressureAverageTimes As TextBox
    Friend WithEvents chkPressureAdjust As CheckBox
    Friend WithEvents Label15 As Label
    Friend WithEvents lblNoControlPressText As Label
    Friend WithEvents lblPressAverageText As Label
    Friend WithEvents txtNoControlPress As TextBox
    Friend WithEvents txtPressAverage As TextBox
    Friend WithEvents lblKg23Text As Label
    Friend WithEvents lblKg12Text As Label
    Friend WithEvents txtRullerLength As TextBox
    Friend WithEvents lblDA04Text As Label
    Friend WithEvents lblRullerLengthText As Label
    Friend WithEvents txtHighPDAOut As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblPositionSet3 As Label
    Friend WithEvents lblPositionSet2 As Label
    Friend WithEvents lblOutRangAddDAText As Label
    Friend WithEvents txtOutRangAddDA3 As TextBox
    Friend WithEvents txtOutRangAddDA2 As TextBox
    Friend WithEvents txtOutRangAddDA1 As TextBox
    Friend WithEvents lblPositionrReadText As Label
    Friend WithEvents lblPositionSet01Text As Label
    Friend WithEvents txtDistanceSet As TextBox
    Friend WithEvents lblPositionSet1 As Label
    Friend WithEvents lblDistanceSetText As Label
    Friend WithEvents lblmm01Text As Label
    Friend WithEvents lblCurrentPosition3 As Label
    Friend WithEvents lblCurrentPosition2 As Label
    Friend WithEvents lblCurrentPosition1 As Label
    Friend WithEvents btnReload As Button
    Friend WithEvents lblThresholdRatioText As Label
    Friend WithEvents txtkgDARatio3 As TextBox
    Friend WithEvents txtkgDARatio2 As TextBox
    Friend WithEvents lblOverThresholdkgDA3 As Label
    Friend WithEvents lblOverThresholdkgDA2 As Label
    Friend WithEvents txtPress2nd3 As TextBox
    Friend WithEvents txtPress2nd2 As TextBox
    Friend WithEvents txtPress3rd3 As TextBox
    Friend WithEvents txtPress3rd2 As TextBox
    Friend WithEvents lblKg13Text As Label
    Friend WithEvents lblSubPress3 As Label
    Friend WithEvents lblRealPressure3 As Label
    Friend WithEvents lblPressureRead3 As Label
    Friend WithEvents lblSubPress2 As Label
    Friend WithEvents lblRealPressure2 As Label
    Friend WithEvents lblPressureRead2 As Label
    Friend WithEvents lblITVRealValue3 As Label
    Friend WithEvents btnPlateUp3 As Button
    Friend WithEvents btnPlateDown3 As Button
    Friend WithEvents btnPlateUp2 As Button
    Friend WithEvents btnPlateDown2 As Button
    Friend WithEvents lblOverThresholdkgDA1 As Label
    Friend WithEvents lblSubPress1 As Label
    Friend WithEvents lblKg15Text As Label
    Friend WithEvents lblRealPressure1 As Label
    Friend WithEvents lblKg14Text As Label
    Friend WithEvents lblDA10Text As Label
    Friend WithEvents lblSubPressText As Label
    Friend WithEvents lblKg20Text As Label
    Friend WithEvents lblRealPressureText1 As Label
    Friend WithEvents lblPressureRead1 As Label
    Friend WithEvents lbl1stPlateUpProcedureText As Label
    Friend WithEvents lblKg09Text As Label
    Friend WithEvents lblmmCount02Text As Label
    Friend WithEvents lblKgDA02Text As Label
    Friend WithEvents btnShowPicControl As Button
    Friend WithEvents lblDA01Text As Label
    Friend WithEvents txtkgDARatio1 As TextBox
    Friend WithEvents lblDA06Text As Label
    Friend WithEvents lblDA09Text As Label
    Friend WithEvents lblDA11Text As Label
    Friend WithEvents btnHighPDAOut As Button
    Friend WithEvents lblDA07Text As Label
    Friend WithEvents lblkgDARatioText As Label
    Friend WithEvents txtPress1st As TextBox
    Friend WithEvents txtPress2nd1 As TextBox
    Friend WithEvents txtPress3rd1 As TextBox
    Friend WithEvents txtLowPDAOut As TextBox
    Friend WithEvents txtPlateUpContactKg As TextBox
    Friend WithEvents btnLowPDAOut As Button
    Friend WithEvents lblPlateUpContactKgText As Label
    Friend WithEvents lblPress3rdText As Label
    Friend WithEvents lblITVRealValue1Text As Label
    Friend WithEvents lblITVRealValue2Text As Label
    Friend WithEvents lblPress1stText As Label
    Friend WithEvents lblITVRealValue1 As Label
    Friend WithEvents lblITVRealValue2 As Label
    Friend WithEvents lblPress2ndText As Label
    Friend WithEvents btnPlateUp1 As Button
    Friend WithEvents btnPlateDown1 As Button
    Friend WithEvents pnl6Plate As Panel
    Friend WithEvents lblPositionSet6 As Label
    Friend WithEvents lblPositionSet5 As Label
    Friend WithEvents lblPositionSet4 As Label
    Friend WithEvents txtkgDARatio6 As TextBox
    Friend WithEvents txtOutRangAddDA6 As TextBox
    Friend WithEvents lblOverThresholdkgDA6 As Label
    Friend WithEvents txtOutRangAddDA5 As TextBox
    Friend WithEvents txtkgDARatio5 As TextBox
    Friend WithEvents txtOutRangAddDA4 As TextBox
    Friend WithEvents txtPress2nd6 As TextBox
    Friend WithEvents txtkgDARatio4 As TextBox
    Friend WithEvents lblOverThresholdkgDA5 As Label
    Friend WithEvents txtPress2nd5 As TextBox
    Friend WithEvents lblOverThresholdkgDA4 As Label
    Friend WithEvents lblCurrentPosition6 As Label
    Friend WithEvents txtPress2nd4 As TextBox
    Friend WithEvents lblCurrentPosition5 As Label
    Friend WithEvents txtPress3rd6 As TextBox
    Friend WithEvents lblCurrentPosition4 As Label
    Friend WithEvents txtPress3rd5 As TextBox
    Friend WithEvents txtPress3rd4 As TextBox
    Friend WithEvents lblSubPress6 As Label
    Friend WithEvents lblRealPressure6 As Label
    Friend WithEvents lblPressureRead6 As Label
    Friend WithEvents lblSubPress5 As Label
    Friend WithEvents lblRealPressure5 As Label
    Friend WithEvents lblPressureRead5 As Label
    Friend WithEvents lblSubPress4 As Label
    Friend WithEvents lblRealPressure4 As Label
    Friend WithEvents lblPressureRead4 As Label
    Friend WithEvents lblITVRealValue6 As Label
    Friend WithEvents lblITVRealValue5 As Label
    Friend WithEvents lblITVRealValue4 As Label
    Friend WithEvents btnPlateUp6 As Button
    Friend WithEvents btnPlateDown6 As Button
    Friend WithEvents btnPlateUp5 As Button
    Friend WithEvents lblKg19Text As Label
    Friend WithEvents btnPlateDown5 As Button
    Friend WithEvents btnPlateUp4 As Button
    Friend WithEvents btnPlateDown4 As Button
    Friend WithEvents lblKg16Text As Label
    Friend WithEvents lblDA02Text As Label
    Friend WithEvents lblDA05Text As Label
    Friend WithEvents lblDA03Text As Label
    Friend WithEvents lblKg17Text As Label
    Friend WithEvents lblKgDA04Text As Label
    Friend WithEvents lblKgDA01Text As Label
    Friend WithEvents lblKgDA03Text As Label
    Friend WithEvents lblmmCount03Text As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblStepControlDelayText As Label
    Friend WithEvents txtControlDelayTime As TextBox
    Friend WithEvents lblTime01sText As Label
    Friend WithEvents txtThreshold As TextBox
    Friend WithEvents lblPercent05Text As Label
    Friend WithEvents lblKg18Text As Label
    Friend WithEvents txtThresholdPressRatio As TextBox
    Friend WithEvents lbl2stControlText As Label
    Friend WithEvents lbl1stControlText As Label
    Friend WithEvents lblCtrl1stRangeText As Label
    Friend WithEvents lblCtrl1stDivText As Label
    Friend WithEvents lblCtrl1stTimeText As Label
    Friend WithEvents txtCtrl2ndRange As TextBox
    Friend WithEvents txtThresholdPressDiv As TextBox
    Friend WithEvents txtCtrl1stDiv As TextBox
    Friend WithEvents txtCtrl1stRange As TextBox
    Friend WithEvents txtCtrl2ndtTime As TextBox
    Friend WithEvents txtCtrl1stTime As TextBox
    Friend WithEvents lblPer11Text As Label
    Friend WithEvents lblPer10Text As Label
    Friend WithEvents lblSec02Text As Label
    Friend WithEvents lblSec01Text As Label
    Friend WithEvents lblThresholdText As Label
    Friend WithEvents lblThresholdPressRatioText As Label
    Friend WithEvents flwPressPID As FlowLayoutPanel
    Friend WithEvents tabPageIniEdit As TabPage
    Friend WithEvents ControlINIEdit1 As ControlINIEdit
    Friend WithEvents TabPageTempCalTool As TabPage
    Friend WithEvents chkDa As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTICComport As TextBox
    Friend WithEvents chkTICMonitorUsed As CheckBox
    Friend WithEvents tabpageCycleRun As TabPage
    Friend WithEvents CYCLETime As Label
    Friend WithEvents RUNTime As Label
    Friend WithEvents txtCR_Timer As TextBox
    Friend WithEvents txtC_Timer As TextBox
    Friend WithEvents BondCycleDoorChk As CheckBox
    Friend WithEvents lblBondCycles3 As Label
    Friend WithEvents lblBondCycles2 As Label
    Friend WithEvents lblBondCycles1 As Label
    Friend WithEvents btnCycleRun3 As Button
    Friend WithEvents btnCycleRun2 As Button
    Friend WithEvents btnCycleRun1 As Button
    Friend WithEvents BondCycleTitle3 As Label
    Friend WithEvents BondCycleTitle2 As Label
    Friend WithEvents BondCycleTitle1 As Label
    Friend WithEvents pnl6Plate1 As Panel
    Friend WithEvents lblBondCycles6 As Label
    Friend WithEvents lblBondCycles5 As Label
    Friend WithEvents lblBondCycles4 As Label
    Friend WithEvents btnCycleRun6 As Button
    Friend WithEvents btnCycleRun5 As Button
    Friend WithEvents btnCycleRun4 As Button
    Friend WithEvents BondCycleTitle6 As Label
    Friend WithEvents BondCycleTitle5 As Label
    Friend WithEvents BondCycleTitle4 As Label
    Friend WithEvents btnPlateUpACR5 As Button
    Friend WithEvents btnPlateDownACR6 As Button
    Friend WithEvents btnPlateUpACR4 As Button
    Friend WithEvents btnPlateUpACR6 As Button
    Friend WithEvents btnPlateDownACR4 As Button
    Friend WithEvents btnPlateDownACR5 As Button
    Friend WithEvents btnPlateDownACR3 As Button
    Friend WithEvents btnPlateUpACR3 As Button
    Friend WithEvents btnPlateDownACR2 As Button
    Friend WithEvents btnPlateUpACR2 As Button
    Friend WithEvents btnPlateDownACR1 As Button
    Friend WithEvents btnPlateUpACR1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label14 As Label
    Public Sub New()
        MyBase.New()

        '此呼叫為 Windows Form 設計工具的必要項。
        InitializeComponent()

        '在 InitializeComponent() 呼叫之後加入所有的初始設定

    End Sub

    'Form 覆寫 Dispose 以清除元件清單。
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '您可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器來修改這些程序。
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblProcessEndAlarmText As System.Windows.Forms.Label
    Friend WithEvents btnEndAlarm As System.Windows.Forms.Button
    Friend WithEvents lblDPCurrentLimitText As System.Windows.Forms.Label
    Friend WithEvents lblPumpTimeText As System.Windows.Forms.Label
    Friend WithEvents lblTempRangeText As System.Windows.Forms.Label
    Friend WithEvents lblHiTempLimitText As System.Windows.Forms.Label
    Friend WithEvents txtProcessEndBZonTime As System.Windows.Forms.TextBox
    Friend WithEvents txtDpCurrentLimit As System.Windows.Forms.TextBox
    Friend WithEvents txtPumpTime As System.Windows.Forms.TextBox
    Friend WithEvents txtTempRange As System.Windows.Forms.TextBox
    Friend WithEvents txtHiTempLimit As System.Windows.Forms.TextBox
    Friend WithEvents txtCoolingTemp As System.Windows.Forms.TextBox
    Friend WithEvents lblProcessOKCoolingText As System.Windows.Forms.Label
    Friend WithEvents txtPressureRange As System.Windows.Forms.TextBox
    Friend WithEvents lblPressureRangeText As System.Windows.Forms.Label
    Friend WithEvents pnlParaSet As System.Windows.Forms.Panel
    Friend WithEvents lblSec03Text As System.Windows.Forms.Label
    Friend WithEvents lblA01Text As System.Windows.Forms.Label
    Friend WithEvents picC01 As System.Windows.Forms.PictureBox
    Friend WithEvents picC05 As System.Windows.Forms.PictureBox
    Friend WithEvents btnAutoPurge As System.Windows.Forms.Button
    Friend WithEvents lblPumpingPurgeText As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblProcessEndAlarmText = New System.Windows.Forms.Label()
        Me.btnEndAlarm = New System.Windows.Forms.Button()
        Me.txtProcessEndBZonTime = New System.Windows.Forms.TextBox()
        Me.txtDpCurrentLimit = New System.Windows.Forms.TextBox()
        Me.lblDPCurrentLimitText = New System.Windows.Forms.Label()
        Me.txtPumpTime = New System.Windows.Forms.TextBox()
        Me.lblPumpTimeText = New System.Windows.Forms.Label()
        Me.txtTempRange = New System.Windows.Forms.TextBox()
        Me.lblTempRangeText = New System.Windows.Forms.Label()
        Me.txtHiTempLimit = New System.Windows.Forms.TextBox()
        Me.lblHiTempLimitText = New System.Windows.Forms.Label()
        Me.txtCoolingTemp = New System.Windows.Forms.TextBox()
        Me.lblProcessOKCoolingText = New System.Windows.Forms.Label()
        Me.txtPressureRange = New System.Windows.Forms.TextBox()
        Me.lblPressureRangeText = New System.Windows.Forms.Label()
        Me.pnlParaSet = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnSelPath = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dudLogStartTime = New System.Windows.Forms.DomainUpDown()
        Me.txtWebPath = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.chkAvailBarCode = New System.Windows.Forms.CheckBox()
        Me.chkRunConfirm = New System.Windows.Forms.CheckBox()
        Me.chkAutoRecordData = New System.Windows.Forms.CheckBox()
        Me.chkBarcodeOnly = New System.Windows.Forms.CheckBox()
        Me.chkCIMUsed = New System.Windows.Forms.CheckBox()
        Me.lblPullerTimeText = New System.Windows.Forms.Label()
        Me.lblSec12Text = New System.Windows.Forms.Label()
        Me.txtPullerTime = New System.Windows.Forms.TextBox()
        Me.lblDoorCloseTime = New System.Windows.Forms.Label()
        Me.grpVacuum = New System.Windows.Forms.GroupBox()
        Me.pnlDPWaterFlow = New System.Windows.Forms.Panel()
        Me.txtDPWaterFlowAlarm = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblDPWaterAlarmText = New System.Windows.Forms.Label()
        Me.pnlDPTemp = New System.Windows.Forms.Panel()
        Me.txtDPTempAlarmOff = New System.Windows.Forms.TextBox()
        Me.txtDPTempAlarmText = New System.Windows.Forms.TextBox()
        Me.lblDPTempAlarmOffText = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.lblDPTempAlarmText = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lblProcessVacSetText = New System.Windows.Forms.Label()
        Me.lblVentTimeText = New System.Windows.Forms.Label()
        Me.lblProcessVacSetLoText = New System.Windows.Forms.Label()
        Me.lblTorr03Text = New System.Windows.Forms.Label()
        Me.txtVentTime = New System.Windows.Forms.TextBox()
        Me.txtProcessVacSetLo = New System.Windows.Forms.TextBox()
        Me.lblTorr01Text = New System.Windows.Forms.Label()
        Me.lblSec04Text = New System.Windows.Forms.Label()
        Me.txtProcessVacSet = New System.Windows.Forms.TextBox()
        Me.btnProcessAutoVacuum = New System.Windows.Forms.Button()
        Me.lblProcessAutoVacuumText = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblSec13Text = New System.Windows.Forms.Label()
        Me.grpProcessCondition = New System.Windows.Forms.GroupBox()
        Me.picC06 = New System.Windows.Forms.PictureBox()
        Me.lblKg21Text = New System.Windows.Forms.Label()
        Me.lblTopLowLimitTempText = New System.Windows.Forms.Label()
        Me.txtTopLowLimitTemp = New System.Windows.Forms.TextBox()
        Me.picC01 = New System.Windows.Forms.PictureBox()
        Me.lblTopLowLimitPowerText = New System.Windows.Forms.Label()
        Me.lblPercent07Text = New System.Windows.Forms.Label()
        Me.txtTopLowLimitPower = New System.Windows.Forms.TextBox()
        Me.txtDoorCloseTime = New System.Windows.Forms.TextBox()
        Me.lblProcessPumpVacuumText = New System.Windows.Forms.Label()
        Me.grpAlarmSetup = New System.Windows.Forms.GroupBox()
        Me.txtHiPressureLimit = New System.Windows.Forms.TextBox()
        Me.lblHiPressureLimitText = New System.Windows.Forms.Label()
        Me.lblKg05Text = New System.Windows.Forms.Label()
        Me.pnlFlowShow = New System.Windows.Forms.Panel()
        Me.lblBotFlow06 = New System.Windows.Forms.Label()
        Me.lbllmin01Text = New System.Windows.Forms.Label()
        Me.lblBotFlow05 = New System.Windows.Forms.Label()
        Me.lblBotFlow04 = New System.Windows.Forms.Label()
        Me.lblBotFlow03 = New System.Windows.Forms.Label()
        Me.lblBotFlow02 = New System.Windows.Forms.Label()
        Me.lblBotFlow01 = New System.Windows.Forms.Label()
        Me.lblSite06 = New System.Windows.Forms.Label()
        Me.lblTopFlow06 = New System.Windows.Forms.Label()
        Me.lblSite05 = New System.Windows.Forms.Label()
        Me.lblTopFlow05 = New System.Windows.Forms.Label()
        Me.lblSite04 = New System.Windows.Forms.Label()
        Me.lblTopFlow04 = New System.Windows.Forms.Label()
        Me.lblSite03 = New System.Windows.Forms.Label()
        Me.lblTopFlow03 = New System.Windows.Forms.Label()
        Me.lblSite02 = New System.Windows.Forms.Label()
        Me.lblSite01Text = New System.Windows.Forms.Label()
        Me.lblTopFlow02 = New System.Windows.Forms.Label()
        Me.lblTopFlow01 = New System.Windows.Forms.Label()
        Me.lblmm03Text = New System.Windows.Forms.Label()
        Me.lblPlate06Text = New System.Windows.Forms.Label()
        Me.lblPlate05Text = New System.Windows.Forms.Label()
        Me.lblPlate04Text = New System.Windows.Forms.Label()
        Me.txtPosition06Set = New System.Windows.Forms.TextBox()
        Me.txtPosition05Set = New System.Windows.Forms.TextBox()
        Me.txtPosition04Set = New System.Windows.Forms.TextBox()
        Me.lblPlate03Text = New System.Windows.Forms.Label()
        Me.lblPlate02Text = New System.Windows.Forms.Label()
        Me.lblPlate01Text = New System.Windows.Forms.Label()
        Me.txtPosition03Set = New System.Windows.Forms.TextBox()
        Me.txtPosition02Set = New System.Windows.Forms.TextBox()
        Me.txtPosition01Set = New System.Windows.Forms.TextBox()
        Me.lblPositionSetText = New System.Windows.Forms.Label()
        Me.txtDpCurrentAlarmTime = New System.Windows.Forms.TextBox()
        Me.lblSec24Text = New System.Windows.Forms.Label()
        Me.lblmm02Text = New System.Windows.Forms.Label()
        Me.chkTempAbort = New System.Windows.Forms.CheckBox()
        Me.chkPressureAbort = New System.Windows.Forms.CheckBox()
        Me.lblKg22Text = New System.Windows.Forms.Label()
        Me.txtAbortPressureRange = New System.Windows.Forms.TextBox()
        Me.lblAbortTempRangeText = New System.Windows.Forms.Label()
        Me.lblAbortPressureRangeText = New System.Windows.Forms.Label()
        Me.txtAbortTempRange = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblProcessPressAlarmTimeText = New System.Windows.Forms.Label()
        Me.lblSec09Text = New System.Windows.Forms.Label()
        Me.txtProcessPressAlarmTime = New System.Windows.Forms.TextBox()
        Me.lblProcessTempAlarmTimeText = New System.Windows.Forms.Label()
        Me.lblSec08Text = New System.Windows.Forms.Label()
        Me.txtProcessTempAlarmTime = New System.Windows.Forms.TextBox()
        Me.lblPressAlarmTimeText = New System.Windows.Forms.Label()
        Me.lblSec06Text = New System.Windows.Forms.Label()
        Me.txtPressAlarmTime = New System.Windows.Forms.TextBox()
        Me.lblTempAlarmTimeText = New System.Windows.Forms.Label()
        Me.lblSec07Text = New System.Windows.Forms.Label()
        Me.txtTempAlarmTime = New System.Windows.Forms.TextBox()
        Me.lblA01Text = New System.Windows.Forms.Label()
        Me.lblSec03Text = New System.Windows.Forms.Label()
        Me.lblLowFlowAlarmText = New System.Windows.Forms.Label()
        Me.lblSec05Text = New System.Windows.Forms.Label()
        Me.picC05 = New System.Windows.Forms.PictureBox()
        Me.txtLowFlowAlarm = New System.Windows.Forms.TextBox()
        Me.lblFlowUnit01Text = New System.Windows.Forms.Label()
        Me.lblTorr09Text = New System.Windows.Forms.Label()
        Me.grpPurgeSetup = New System.Windows.Forms.GroupBox()
        Me.lblPumpingPurgeText = New System.Windows.Forms.Label()
        Me.lblTimes01Text = New System.Windows.Forms.Label()
        Me.lblPurgeOffText = New System.Windows.Forms.Label()
        Me.txtPurgeOFFTime = New System.Windows.Forms.TextBox()
        Me.lblPurgeOnText = New System.Windows.Forms.Label()
        Me.txtPurgeONTime = New System.Windows.Forms.TextBox()
        Me.txtPurgeCycle = New System.Windows.Forms.TextBox()
        Me.btnAutoPurge = New System.Windows.Forms.Button()
        Me.txtProcessPumpVacuum = New System.Windows.Forms.TextBox()
        Me.txtProcessPumpTime = New System.Windows.Forms.TextBox()
        Me.lblProcessPumpTimeText = New System.Windows.Forms.Label()
        Me.lblSec14Text = New System.Windows.Forms.Label()
        Me.grpPIDLoadSave = New System.Windows.Forms.GroupBox()
        Me.btnLoadPIDFile = New System.Windows.Forms.Button()
        Me.txtPIDFileName = New System.Windows.Forms.TextBox()
        Me.btnSavePIDFile = New System.Windows.Forms.Button()
        Me.tabParameter = New System.Windows.Forms.TabControl()
        Me.TabPageTIC = New System.Windows.Forms.TabPage()
        Me.txtMaxTempPower = New System.Windows.Forms.TextBox()
        Me.lblTempMaxPowText = New System.Windows.Forms.Label()
        Me.lblPer03Text = New System.Windows.Forms.Label()
        Me.tabPIDSetup = New System.Windows.Forms.TabControl()
        Me.tabPage1to3 = New System.Windows.Forms.TabPage()
        Me.flwPIDPage1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.tabPage4to6 = New System.Windows.Forms.TabPage()
        Me.flwPIDPage2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.TabPageTCal = New System.Windows.Forms.TabPage()
        Me.pnlSplitTopBotTemp = New System.Windows.Forms.Panel()
        Me.chkSplitTopBotTemp = New System.Windows.Forms.CheckBox()
        Me.lblTempTrackDescribeText = New System.Windows.Forms.Label()
        Me.btnTempTrackDisable = New System.Windows.Forms.Button()
        Me.lblTempTrackTemp = New System.Windows.Forms.Label()
        Me.flwTempCalUser = New System.Windows.Forms.FlowLayoutPanel()
        Me.TabPagePCal = New System.Windows.Forms.TabPage()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnSite3Cal = New System.Windows.Forms.Button()
        Me.btnSite2Cal = New System.Windows.Forms.Button()
        Me.btnSite1Cal = New System.Windows.Forms.Button()
        Me.flwPressCalUser = New System.Windows.Forms.FlowLayoutPanel()
        Me.TabPageSystem = New System.Windows.Forms.TabPage()
        Me.TabPageCIM = New System.Windows.Forms.TabPage()
        Me.CtlSanAnCIMSetup1 = New CELLO.ctlSanAnCIMSetup()
        Me.TabPageCello = New System.Windows.Forms.TabPage()
        Me.tabSystem = New System.Windows.Forms.TabControl()
        Me.tabpageTempCal = New System.Windows.Forms.TabPage()
        Me.pnlHeaterSetup = New System.Windows.Forms.Panel()
        Me.chkSplitTopBotTempEnable = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTempRiseComp = New System.Windows.Forms.TextBox()
        Me.lblTempRiseCompText = New System.Windows.Forms.Label()
        Me.lblHeaterCountText = New System.Windows.Forms.Label()
        Me.lblS01Text = New System.Windows.Forms.Label()
        Me.lblHeaterPowerText = New System.Windows.Forms.Label()
        Me.txtHeaterAlarmTime = New System.Windows.Forms.TextBox()
        Me.lblHeaterVoltageText = New System.Windows.Forms.Label()
        Me.lblHeaterAlarmTimeText = New System.Windows.Forms.Label()
        Me.txtHeaterVoltage = New System.Windows.Forms.TextBox()
        Me.lblFullCurrentText = New System.Windows.Forms.Label()
        Me.txtHeaterPower = New System.Windows.Forms.TextBox()
        Me.lblA02Text = New System.Windows.Forms.Label()
        Me.txtHeaterCount = New System.Windows.Forms.TextBox()
        Me.lblFullCurrent = New System.Windows.Forms.Label()
        Me.lblW01Text = New System.Windows.Forms.Label()
        Me.lblHeaterCurrentText = New System.Windows.Forms.Label()
        Me.lblV02Text = New System.Windows.Forms.Label()
        Me.lblA03Text = New System.Windows.Forms.Label()
        Me.lblHeaterMonitorPowerText = New System.Windows.Forms.Label()
        Me.lblHeaterCurrent = New System.Windows.Forms.Label()
        Me.txtHeaterMonitorPower = New System.Windows.Forms.TextBox()
        Me.lblPer01Text = New System.Windows.Forms.Label()
        Me.lblPer02Text = New System.Windows.Forms.Label()
        Me.txtHeaterCurrentRate = New System.Windows.Forms.TextBox()
        Me.lblHeaterCurrentRateText = New System.Windows.Forms.Label()
        Me.flwTempCal = New System.Windows.Forms.FlowLayoutPanel()
        Me.tabpageVacuum = New System.Windows.Forms.TabPage()
        Me.grpFlowMeter = New System.Windows.Forms.GroupBox()
        Me.lblDPWaterFlowMaxText = New System.Windows.Forms.Label()
        Me.txtDPWaterFlowMax = New System.Windows.Forms.TextBox()
        Me.lblDPWaterFlowHzText = New System.Windows.Forms.Label()
        Me.txtDPWaterFlowHz = New System.Windows.Forms.TextBox()
        Me.btnFlowMode = New System.Windows.Forms.Button()
        Me.lblFlowModeText = New System.Windows.Forms.Label()
        Me.lblFlowDescriptionText = New System.Windows.Forms.Label()
        Me.lblFlowSamplingTimeText = New System.Windows.Forms.Label()
        Me.txtFlowSamplingTime = New System.Windows.Forms.TextBox()
        Me.lblSec11Text = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radPSG500 = New System.Windows.Forms.RadioButton()
        Me.radPCG550 = New System.Windows.Forms.RadioButton()
        Me.radAPG100 = New System.Windows.Forms.RadioButton()
        Me.radZSE40 = New System.Windows.Forms.RadioButton()
        Me.radAP2004 = New System.Windows.Forms.RadioButton()
        Me.radGP275 = New System.Windows.Forms.RadioButton()
        Me.grpPumpType = New System.Windows.Forms.GroupBox()
        Me.radUlvacLS120 = New System.Windows.Forms.RadioButton()
        Me.lblDPTempCalText = New System.Windows.Forms.Label()
        Me.txtDPTempCalSet = New System.Windows.Forms.TextBox()
        Me.picC02 = New System.Windows.Forms.PictureBox()
        Me.radMachinePump = New System.Windows.Forms.RadioButton()
        Me.radDryPump = New System.Windows.Forms.RadioButton()
        Me.flwFlowSetup = New System.Windows.Forms.FlowLayoutPanel()
        Me.grpVacuumSetup = New System.Windows.Forms.GroupBox()
        Me.txtRPOnPressure = New System.Windows.Forms.TextBox()
        Me.lblRPOnPressureText = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtVentOffDelay = New System.Windows.Forms.TextBox()
        Me.lblVentOffDelay = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn1ATMSelect = New System.Windows.Forms.Button()
        Me.txtRVONDelay = New System.Windows.Forms.TextBox()
        Me.lblRVONDelayText = New System.Windows.Forms.Label()
        Me.lbl1ATM = New System.Windows.Forms.Label()
        Me.txt1ATMVac = New System.Windows.Forms.TextBox()
        Me.txtBasePressureTest = New System.Windows.Forms.TextBox()
        Me.txtCHVacOffsetVoltage = New System.Windows.Forms.TextBox()
        Me.lbl1Atm02Text = New System.Windows.Forms.Label()
        Me.lblTorr05Text = New System.Windows.Forms.Label()
        Me.lblTorr02Text = New System.Windows.Forms.Label()
        Me.lblSec10Text = New System.Windows.Forms.Label()
        Me.lblV01Text = New System.Windows.Forms.Label()
        Me.lblZSE40UseText = New System.Windows.Forms.Label()
        Me.lblCHVacOffsetVoltageText = New System.Windows.Forms.Label()
        Me.lblVacuumOriginal = New System.Windows.Forms.Label()
        Me.lblBasePressure = New System.Windows.Forms.Label()
        Me.lblVacuumCaled = New System.Windows.Forms.Label()
        Me.lblVacuumCaledText = New System.Windows.Forms.Label()
        Me.tabpagePressCal = New System.Windows.Forms.TabPage()
        Me.flwPressCal = New System.Windows.Forms.FlowLayoutPanel()
        Me.tabpagePressControl = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnlog = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtdown = New System.Windows.Forms.TextBox()
        Me.txtup = New System.Windows.Forms.TextBox()
        Me.txtinterval = New System.Windows.Forms.TextBox()
        Me.btDn = New System.Windows.Forms.Button()
        Me.btUp = New System.Windows.Forms.Button()
        Me.btnForceDAOut = New System.Windows.Forms.Button()
        Me.pnlPressureAverage = New System.Windows.Forms.Panel()
        Me.lbPeakClearTimes = New System.Windows.Forms.Label()
        Me.rdoPeakClear = New System.Windows.Forms.RadioButton()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.rdoPressureAverage = New System.Windows.Forms.RadioButton()
        Me.txtPeakTimes = New System.Windows.Forms.TextBox()
        Me.lblPeakTimesText = New System.Windows.Forms.Label()
        Me.txtPeakLimit = New System.Windows.Forms.TextBox()
        Me.lblTimes03Text = New System.Windows.Forms.Label()
        Me.lblTimes02Text = New System.Windows.Forms.Label()
        Me.txtPressureAverageTimes = New System.Windows.Forms.TextBox()
        Me.chkPressureAdjust = New System.Windows.Forms.CheckBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblNoControlPressText = New System.Windows.Forms.Label()
        Me.lblPressAverageText = New System.Windows.Forms.Label()
        Me.txtNoControlPress = New System.Windows.Forms.TextBox()
        Me.txtPressAverage = New System.Windows.Forms.TextBox()
        Me.lblKg23Text = New System.Windows.Forms.Label()
        Me.lblKg12Text = New System.Windows.Forms.Label()
        Me.txtRullerLength = New System.Windows.Forms.TextBox()
        Me.lblDA04Text = New System.Windows.Forms.Label()
        Me.lblRullerLengthText = New System.Windows.Forms.Label()
        Me.txtHighPDAOut = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblPositionSet3 = New System.Windows.Forms.Label()
        Me.lblPositionSet2 = New System.Windows.Forms.Label()
        Me.lblOutRangAddDAText = New System.Windows.Forms.Label()
        Me.txtOutRangAddDA3 = New System.Windows.Forms.TextBox()
        Me.txtOutRangAddDA2 = New System.Windows.Forms.TextBox()
        Me.txtOutRangAddDA1 = New System.Windows.Forms.TextBox()
        Me.lblPositionrReadText = New System.Windows.Forms.Label()
        Me.lblPositionSet01Text = New System.Windows.Forms.Label()
        Me.txtDistanceSet = New System.Windows.Forms.TextBox()
        Me.lblPositionSet1 = New System.Windows.Forms.Label()
        Me.lblDistanceSetText = New System.Windows.Forms.Label()
        Me.lblmm01Text = New System.Windows.Forms.Label()
        Me.lblCurrentPosition3 = New System.Windows.Forms.Label()
        Me.lblCurrentPosition2 = New System.Windows.Forms.Label()
        Me.lblCurrentPosition1 = New System.Windows.Forms.Label()
        Me.btnReload = New System.Windows.Forms.Button()
        Me.lblThresholdRatioText = New System.Windows.Forms.Label()
        Me.txtkgDARatio3 = New System.Windows.Forms.TextBox()
        Me.txtkgDARatio2 = New System.Windows.Forms.TextBox()
        Me.lblOverThresholdkgDA3 = New System.Windows.Forms.Label()
        Me.lblOverThresholdkgDA2 = New System.Windows.Forms.Label()
        Me.txtPress2nd3 = New System.Windows.Forms.TextBox()
        Me.txtPress2nd2 = New System.Windows.Forms.TextBox()
        Me.txtPress3rd3 = New System.Windows.Forms.TextBox()
        Me.txtPress3rd2 = New System.Windows.Forms.TextBox()
        Me.lblKg13Text = New System.Windows.Forms.Label()
        Me.lblSubPress3 = New System.Windows.Forms.Label()
        Me.lblRealPressure3 = New System.Windows.Forms.Label()
        Me.lblPressureRead3 = New System.Windows.Forms.Label()
        Me.lblSubPress2 = New System.Windows.Forms.Label()
        Me.lblRealPressure2 = New System.Windows.Forms.Label()
        Me.lblPressureRead2 = New System.Windows.Forms.Label()
        Me.lblITVRealValue3 = New System.Windows.Forms.Label()
        Me.btnPlateUp3 = New System.Windows.Forms.Button()
        Me.btnPlateDown3 = New System.Windows.Forms.Button()
        Me.btnPlateUp2 = New System.Windows.Forms.Button()
        Me.btnPlateDown2 = New System.Windows.Forms.Button()
        Me.lblOverThresholdkgDA1 = New System.Windows.Forms.Label()
        Me.lblSubPress1 = New System.Windows.Forms.Label()
        Me.lblKg15Text = New System.Windows.Forms.Label()
        Me.lblRealPressure1 = New System.Windows.Forms.Label()
        Me.lblKg14Text = New System.Windows.Forms.Label()
        Me.lblDA10Text = New System.Windows.Forms.Label()
        Me.lblSubPressText = New System.Windows.Forms.Label()
        Me.lblKg20Text = New System.Windows.Forms.Label()
        Me.lblRealPressureText1 = New System.Windows.Forms.Label()
        Me.lblPressureRead1 = New System.Windows.Forms.Label()
        Me.lbl1stPlateUpProcedureText = New System.Windows.Forms.Label()
        Me.lblKg09Text = New System.Windows.Forms.Label()
        Me.lblmmCount02Text = New System.Windows.Forms.Label()
        Me.lblKgDA02Text = New System.Windows.Forms.Label()
        Me.btnShowPicControl = New System.Windows.Forms.Button()
        Me.lblDA01Text = New System.Windows.Forms.Label()
        Me.txtkgDARatio1 = New System.Windows.Forms.TextBox()
        Me.lblDA06Text = New System.Windows.Forms.Label()
        Me.lblDA09Text = New System.Windows.Forms.Label()
        Me.lblDA11Text = New System.Windows.Forms.Label()
        Me.btnHighPDAOut = New System.Windows.Forms.Button()
        Me.lblDA07Text = New System.Windows.Forms.Label()
        Me.lblkgDARatioText = New System.Windows.Forms.Label()
        Me.txtPress1st = New System.Windows.Forms.TextBox()
        Me.txtPress2nd1 = New System.Windows.Forms.TextBox()
        Me.txtPress3rd1 = New System.Windows.Forms.TextBox()
        Me.txtLowPDAOut = New System.Windows.Forms.TextBox()
        Me.txtPlateUpContactKg = New System.Windows.Forms.TextBox()
        Me.btnLowPDAOut = New System.Windows.Forms.Button()
        Me.lblPlateUpContactKgText = New System.Windows.Forms.Label()
        Me.lblPress3rdText = New System.Windows.Forms.Label()
        Me.lblITVRealValue1Text = New System.Windows.Forms.Label()
        Me.lblITVRealValue2Text = New System.Windows.Forms.Label()
        Me.lblPress1stText = New System.Windows.Forms.Label()
        Me.lblITVRealValue1 = New System.Windows.Forms.Label()
        Me.lblITVRealValue2 = New System.Windows.Forms.Label()
        Me.lblPress2ndText = New System.Windows.Forms.Label()
        Me.btnPlateUp1 = New System.Windows.Forms.Button()
        Me.btnPlateDown1 = New System.Windows.Forms.Button()
        Me.pnl6Plate = New System.Windows.Forms.Panel()
        Me.lblPositionSet6 = New System.Windows.Forms.Label()
        Me.lblPositionSet5 = New System.Windows.Forms.Label()
        Me.lblPositionSet4 = New System.Windows.Forms.Label()
        Me.txtkgDARatio6 = New System.Windows.Forms.TextBox()
        Me.txtOutRangAddDA6 = New System.Windows.Forms.TextBox()
        Me.lblOverThresholdkgDA6 = New System.Windows.Forms.Label()
        Me.txtOutRangAddDA5 = New System.Windows.Forms.TextBox()
        Me.txtkgDARatio5 = New System.Windows.Forms.TextBox()
        Me.txtOutRangAddDA4 = New System.Windows.Forms.TextBox()
        Me.txtPress2nd6 = New System.Windows.Forms.TextBox()
        Me.txtkgDARatio4 = New System.Windows.Forms.TextBox()
        Me.lblOverThresholdkgDA5 = New System.Windows.Forms.Label()
        Me.txtPress2nd5 = New System.Windows.Forms.TextBox()
        Me.lblOverThresholdkgDA4 = New System.Windows.Forms.Label()
        Me.lblCurrentPosition6 = New System.Windows.Forms.Label()
        Me.txtPress2nd4 = New System.Windows.Forms.TextBox()
        Me.lblCurrentPosition5 = New System.Windows.Forms.Label()
        Me.txtPress3rd6 = New System.Windows.Forms.TextBox()
        Me.lblCurrentPosition4 = New System.Windows.Forms.Label()
        Me.txtPress3rd5 = New System.Windows.Forms.TextBox()
        Me.txtPress3rd4 = New System.Windows.Forms.TextBox()
        Me.lblSubPress6 = New System.Windows.Forms.Label()
        Me.lblRealPressure6 = New System.Windows.Forms.Label()
        Me.lblPressureRead6 = New System.Windows.Forms.Label()
        Me.lblSubPress5 = New System.Windows.Forms.Label()
        Me.lblRealPressure5 = New System.Windows.Forms.Label()
        Me.lblPressureRead5 = New System.Windows.Forms.Label()
        Me.lblSubPress4 = New System.Windows.Forms.Label()
        Me.lblRealPressure4 = New System.Windows.Forms.Label()
        Me.lblPressureRead4 = New System.Windows.Forms.Label()
        Me.lblITVRealValue6 = New System.Windows.Forms.Label()
        Me.lblITVRealValue5 = New System.Windows.Forms.Label()
        Me.lblITVRealValue4 = New System.Windows.Forms.Label()
        Me.btnPlateUp6 = New System.Windows.Forms.Button()
        Me.btnPlateDown6 = New System.Windows.Forms.Button()
        Me.btnPlateUp5 = New System.Windows.Forms.Button()
        Me.lblKg19Text = New System.Windows.Forms.Label()
        Me.btnPlateDown5 = New System.Windows.Forms.Button()
        Me.btnPlateUp4 = New System.Windows.Forms.Button()
        Me.btnPlateDown4 = New System.Windows.Forms.Button()
        Me.lblKg16Text = New System.Windows.Forms.Label()
        Me.lblDA02Text = New System.Windows.Forms.Label()
        Me.lblDA05Text = New System.Windows.Forms.Label()
        Me.lblDA03Text = New System.Windows.Forms.Label()
        Me.lblKg17Text = New System.Windows.Forms.Label()
        Me.lblKgDA04Text = New System.Windows.Forms.Label()
        Me.lblKgDA01Text = New System.Windows.Forms.Label()
        Me.lblKgDA03Text = New System.Windows.Forms.Label()
        Me.lblmmCount03Text = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblStepControlDelayText = New System.Windows.Forms.Label()
        Me.txtControlDelayTime = New System.Windows.Forms.TextBox()
        Me.lblTime01sText = New System.Windows.Forms.Label()
        Me.txtThreshold = New System.Windows.Forms.TextBox()
        Me.lblPercent05Text = New System.Windows.Forms.Label()
        Me.lblKg18Text = New System.Windows.Forms.Label()
        Me.txtThresholdPressRatio = New System.Windows.Forms.TextBox()
        Me.lbl2stControlText = New System.Windows.Forms.Label()
        Me.lbl1stControlText = New System.Windows.Forms.Label()
        Me.lblCtrl1stRangeText = New System.Windows.Forms.Label()
        Me.lblCtrl1stDivText = New System.Windows.Forms.Label()
        Me.lblCtrl1stTimeText = New System.Windows.Forms.Label()
        Me.txtCtrl2ndRange = New System.Windows.Forms.TextBox()
        Me.txtThresholdPressDiv = New System.Windows.Forms.TextBox()
        Me.txtCtrl1stDiv = New System.Windows.Forms.TextBox()
        Me.txtCtrl1stRange = New System.Windows.Forms.TextBox()
        Me.txtCtrl2ndtTime = New System.Windows.Forms.TextBox()
        Me.txtCtrl1stTime = New System.Windows.Forms.TextBox()
        Me.lblPer11Text = New System.Windows.Forms.Label()
        Me.lblPer10Text = New System.Windows.Forms.Label()
        Me.lblSec02Text = New System.Windows.Forms.Label()
        Me.lblSec01Text = New System.Windows.Forms.Label()
        Me.lblThresholdText = New System.Windows.Forms.Label()
        Me.lblThresholdPressRatioText = New System.Windows.Forms.Label()
        Me.flwPressPID = New System.Windows.Forms.FlowLayoutPanel()
        Me.tabPageIniEdit = New System.Windows.Forms.TabPage()
        Me.ControlINIEdit1 = New CELLO.ControlINIEdit()
        Me.TabPageTempCalTool = New System.Windows.Forms.TabPage()
        Me.chkDa = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTICComport = New System.Windows.Forms.TextBox()
        Me.chkTICMonitorUsed = New System.Windows.Forms.CheckBox()
        Me.tabpageCycleRun = New System.Windows.Forms.TabPage()
        Me.CYCLETime = New System.Windows.Forms.Label()
        Me.RUNTime = New System.Windows.Forms.Label()
        Me.txtCR_Timer = New System.Windows.Forms.TextBox()
        Me.txtC_Timer = New System.Windows.Forms.TextBox()
        Me.BondCycleDoorChk = New System.Windows.Forms.CheckBox()
        Me.lblBondCycles3 = New System.Windows.Forms.Label()
        Me.lblBondCycles2 = New System.Windows.Forms.Label()
        Me.lblBondCycles1 = New System.Windows.Forms.Label()
        Me.btnCycleRun3 = New System.Windows.Forms.Button()
        Me.btnCycleRun2 = New System.Windows.Forms.Button()
        Me.btnCycleRun1 = New System.Windows.Forms.Button()
        Me.BondCycleTitle3 = New System.Windows.Forms.Label()
        Me.BondCycleTitle2 = New System.Windows.Forms.Label()
        Me.BondCycleTitle1 = New System.Windows.Forms.Label()
        Me.pnl6Plate1 = New System.Windows.Forms.Panel()
        Me.lblBondCycles6 = New System.Windows.Forms.Label()
        Me.lblBondCycles5 = New System.Windows.Forms.Label()
        Me.lblBondCycles4 = New System.Windows.Forms.Label()
        Me.btnCycleRun6 = New System.Windows.Forms.Button()
        Me.btnCycleRun5 = New System.Windows.Forms.Button()
        Me.btnCycleRun4 = New System.Windows.Forms.Button()
        Me.BondCycleTitle6 = New System.Windows.Forms.Label()
        Me.BondCycleTitle5 = New System.Windows.Forms.Label()
        Me.BondCycleTitle4 = New System.Windows.Forms.Label()
        Me.btnPlateUpACR5 = New System.Windows.Forms.Button()
        Me.btnPlateDownACR6 = New System.Windows.Forms.Button()
        Me.btnPlateUpACR4 = New System.Windows.Forms.Button()
        Me.btnPlateUpACR6 = New System.Windows.Forms.Button()
        Me.btnPlateDownACR4 = New System.Windows.Forms.Button()
        Me.btnPlateDownACR5 = New System.Windows.Forms.Button()
        Me.btnPlateDownACR3 = New System.Windows.Forms.Button()
        Me.btnPlateUpACR3 = New System.Windows.Forms.Button()
        Me.btnPlateDownACR2 = New System.Windows.Forms.Button()
        Me.btnPlateUpACR2 = New System.Windows.Forms.Button()
        Me.btnPlateDownACR1 = New System.Windows.Forms.Button()
        Me.btnPlateUpACR1 = New System.Windows.Forms.Button()
        Me.picCelloTitleEng = New System.Windows.Forms.PictureBox()
        Me.picCelloTitle = New System.Windows.Forms.PictureBox()
        Me.picCelloLogo = New System.Windows.Forms.PictureBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.pnlParaSet.SuspendLayout
        Me.Panel3.SuspendLayout
        Me.Panel2.SuspendLayout
        Me.grpVacuum.SuspendLayout
        Me.pnlDPWaterFlow.SuspendLayout
        Me.pnlDPTemp.SuspendLayout
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit
        Me.grpProcessCondition.SuspendLayout
        CType(Me.picC06, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.picC01, System.ComponentModel.ISupportInitialize).BeginInit
        Me.grpAlarmSetup.SuspendLayout
        Me.pnlFlowShow.SuspendLayout
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.picC05, System.ComponentModel.ISupportInitialize).BeginInit
        Me.grpPurgeSetup.SuspendLayout
        Me.grpPIDLoadSave.SuspendLayout
        Me.tabParameter.SuspendLayout
        Me.TabPageTIC.SuspendLayout
        Me.tabPIDSetup.SuspendLayout
        Me.tabPage1to3.SuspendLayout
        Me.tabPage4to6.SuspendLayout
        Me.TabPageTCal.SuspendLayout
        Me.pnlSplitTopBotTemp.SuspendLayout
        Me.TabPagePCal.SuspendLayout
        Me.GroupBox3.SuspendLayout
        Me.TabPageSystem.SuspendLayout
        Me.TabPageCIM.SuspendLayout
        Me.TabPageCello.SuspendLayout
        Me.tabSystem.SuspendLayout
        Me.tabpageTempCal.SuspendLayout
        Me.pnlHeaterSetup.SuspendLayout
        Me.tabpageVacuum.SuspendLayout
        Me.grpFlowMeter.SuspendLayout
        Me.GroupBox1.SuspendLayout
        Me.grpPumpType.SuspendLayout
        CType(Me.picC02, System.ComponentModel.ISupportInitialize).BeginInit
        Me.grpVacuumSetup.SuspendLayout
        Me.tabpagePressCal.SuspendLayout
        Me.tabpagePressControl.SuspendLayout
        Me.GroupBox2.SuspendLayout
        Me.pnlPressureAverage.SuspendLayout
        Me.pnl6Plate.SuspendLayout
        Me.Panel1.SuspendLayout
        Me.tabPageIniEdit.SuspendLayout
        Me.TabPageTempCalTool.SuspendLayout
        Me.tabpageCycleRun.SuspendLayout
        Me.pnl6Plate1.SuspendLayout
        CType(Me.picCelloTitleEng, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.picCelloTitle, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.picCelloLogo, System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Timer1
        '
        '
        'lblProcessEndAlarmText
        '
        Me.lblProcessEndAlarmText.BackColor = System.Drawing.Color.Transparent
        Me.lblProcessEndAlarmText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcessEndAlarmText.Location = New System.Drawing.Point(6, 243)
        Me.lblProcessEndAlarmText.Name = "lblProcessEndAlarmText"
        Me.lblProcessEndAlarmText.Size = New System.Drawing.Size(158, 36)
        Me.lblProcessEndAlarmText.TabIndex = 47
        Me.lblProcessEndAlarmText.Text = "製程結束後響音 :"
        Me.lblProcessEndAlarmText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnEndAlarm
        '
        Me.btnEndAlarm.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnEndAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEndAlarm.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEndAlarm.Location = New System.Drawing.Point(169, 245)
        Me.btnEndAlarm.Name = "btnEndAlarm"
        Me.btnEndAlarm.Size = New System.Drawing.Size(80, 33)
        Me.btnEndAlarm.TabIndex = 48
        Me.btnEndAlarm.Text = "OFF"
        Me.btnEndAlarm.UseVisualStyleBackColor = False
        '
        'txtProcessEndBZonTime
        '
        Me.txtProcessEndBZonTime.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProcessEndBZonTime.Location = New System.Drawing.Point(260, 248)
        Me.txtProcessEndBZonTime.Name = "txtProcessEndBZonTime"
        Me.txtProcessEndBZonTime.Size = New System.Drawing.Size(55, 26)
        Me.txtProcessEndBZonTime.TabIndex = 5
        Me.txtProcessEndBZonTime.Text = "15"
        Me.txtProcessEndBZonTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDpCurrentLimit
        '
        Me.txtDpCurrentLimit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDpCurrentLimit.Location = New System.Drawing.Point(169, 109)
        Me.txtDpCurrentLimit.Name = "txtDpCurrentLimit"
        Me.txtDpCurrentLimit.Size = New System.Drawing.Size(80, 26)
        Me.txtDpCurrentLimit.TabIndex = 8
        Me.txtDpCurrentLimit.Text = "60"
        Me.txtDpCurrentLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDPCurrentLimitText
        '
        Me.lblDPCurrentLimitText.BackColor = System.Drawing.Color.Transparent
        Me.lblDPCurrentLimitText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDPCurrentLimitText.ForeColor = System.Drawing.Color.Black
        Me.lblDPCurrentLimitText.Location = New System.Drawing.Point(6, 104)
        Me.lblDPCurrentLimitText.Name = "lblDPCurrentLimitText"
        Me.lblDPCurrentLimitText.Size = New System.Drawing.Size(158, 36)
        Me.lblDPCurrentLimitText.TabIndex = 313
        Me.lblDPCurrentLimitText.Text = "MP電流警報:"
        Me.lblDPCurrentLimitText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPumpTime
        '
        Me.txtPumpTime.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPumpTime.Location = New System.Drawing.Point(169, 77)
        Me.txtPumpTime.Name = "txtPumpTime"
        Me.txtPumpTime.Size = New System.Drawing.Size(80, 26)
        Me.txtPumpTime.TabIndex = 4
        Me.txtPumpTime.Text = "600"
        Me.txtPumpTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPumpTimeText
        '
        Me.lblPumpTimeText.BackColor = System.Drawing.Color.Transparent
        Me.lblPumpTimeText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPumpTimeText.ForeColor = System.Drawing.Color.Black
        Me.lblPumpTimeText.Location = New System.Drawing.Point(6, 72)
        Me.lblPumpTimeText.Name = "lblPumpTimeText"
        Me.lblPumpTimeText.Size = New System.Drawing.Size(158, 36)
        Me.lblPumpTimeText.TabIndex = 312
        Me.lblPumpTimeText.Text = "抽真空警報時間:"
        Me.lblPumpTimeText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTempRange
        '
        Me.txtTempRange.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTempRange.Location = New System.Drawing.Point(184, 55)
        Me.txtTempRange.Name = "txtTempRange"
        Me.txtTempRange.Size = New System.Drawing.Size(80, 26)
        Me.txtTempRange.TabIndex = 2
        Me.txtTempRange.Text = "3"
        Me.txtTempRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTempRangeText
        '
        Me.lblTempRangeText.BackColor = System.Drawing.Color.Transparent
        Me.lblTempRangeText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTempRangeText.ForeColor = System.Drawing.Color.Black
        Me.lblTempRangeText.Location = New System.Drawing.Point(19, 51)
        Me.lblTempRangeText.Name = "lblTempRangeText"
        Me.lblTempRangeText.Size = New System.Drawing.Size(158, 36)
        Me.lblTempRangeText.TabIndex = 310
        Me.lblTempRangeText.Text = "製程溫度範圍(+/-):"
        Me.lblTempRangeText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtHiTempLimit
        '
        Me.txtHiTempLimit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHiTempLimit.Location = New System.Drawing.Point(169, 20)
        Me.txtHiTempLimit.Name = "txtHiTempLimit"
        Me.txtHiTempLimit.Size = New System.Drawing.Size(80, 26)
        Me.txtHiTempLimit.TabIndex = 1
        Me.txtHiTempLimit.Text = "600"
        Me.txtHiTempLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblHiTempLimitText
        '
        Me.lblHiTempLimitText.BackColor = System.Drawing.Color.Transparent
        Me.lblHiTempLimitText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHiTempLimitText.ForeColor = System.Drawing.Color.Black
        Me.lblHiTempLimitText.Location = New System.Drawing.Point(6, 15)
        Me.lblHiTempLimitText.Name = "lblHiTempLimitText"
        Me.lblHiTempLimitText.Size = New System.Drawing.Size(158, 36)
        Me.lblHiTempLimitText.TabIndex = 309
        Me.lblHiTempLimitText.Text = "超溫警報溫度:"
        Me.lblHiTempLimitText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCoolingTemp
        '
        Me.txtCoolingTemp.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCoolingTemp.Location = New System.Drawing.Point(184, 53)
        Me.txtCoolingTemp.Name = "txtCoolingTemp"
        Me.txtCoolingTemp.Size = New System.Drawing.Size(80, 21)
        Me.txtCoolingTemp.TabIndex = 6
        Me.txtCoolingTemp.Text = "80"
        Me.txtCoolingTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblProcessOKCoolingText
        '
        Me.lblProcessOKCoolingText.BackColor = System.Drawing.Color.Transparent
        Me.lblProcessOKCoolingText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcessOKCoolingText.Location = New System.Drawing.Point(21, 46)
        Me.lblProcessOKCoolingText.Name = "lblProcessOKCoolingText"
        Me.lblProcessOKCoolingText.Size = New System.Drawing.Size(158, 36)
        Me.lblProcessOKCoolingText.TabIndex = 314
        Me.lblProcessOKCoolingText.Text = "Vent冷卻溫度:"
        Me.lblProcessOKCoolingText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPressureRange
        '
        Me.txtPressureRange.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPressureRange.Location = New System.Drawing.Point(184, 23)
        Me.txtPressureRange.Name = "txtPressureRange"
        Me.txtPressureRange.Size = New System.Drawing.Size(80, 26)
        Me.txtPressureRange.TabIndex = 9
        Me.txtPressureRange.Text = "5"
        Me.txtPressureRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPressureRangeText
        '
        Me.lblPressureRangeText.BackColor = System.Drawing.Color.Transparent
        Me.lblPressureRangeText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPressureRangeText.ForeColor = System.Drawing.Color.Black
        Me.lblPressureRangeText.Location = New System.Drawing.Point(19, 19)
        Me.lblPressureRangeText.Name = "lblPressureRangeText"
        Me.lblPressureRangeText.Size = New System.Drawing.Size(158, 36)
        Me.lblPressureRangeText.TabIndex = 317
        Me.lblPressureRangeText.Text = "製程壓力範圍(+/-):"
        Me.lblPressureRangeText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlParaSet
        '
        Me.pnlParaSet.BackColor = System.Drawing.SystemColors.Control
        Me.pnlParaSet.Controls.Add(Me.Panel3)
        Me.pnlParaSet.Controls.Add(Me.Panel2)
        Me.pnlParaSet.Controls.Add(Me.lblPullerTimeText)
        Me.pnlParaSet.Controls.Add(Me.lblSec12Text)
        Me.pnlParaSet.Controls.Add(Me.txtPullerTime)
        Me.pnlParaSet.Controls.Add(Me.lblDoorCloseTime)
        Me.pnlParaSet.Controls.Add(Me.grpVacuum)
        Me.pnlParaSet.Controls.Add(Me.lblSec13Text)
        Me.pnlParaSet.Controls.Add(Me.grpProcessCondition)
        Me.pnlParaSet.Controls.Add(Me.txtDoorCloseTime)
        Me.pnlParaSet.Controls.Add(Me.lblProcessPumpVacuumText)
        Me.pnlParaSet.Controls.Add(Me.grpAlarmSetup)
        Me.pnlParaSet.Controls.Add(Me.lblTorr09Text)
        Me.pnlParaSet.Controls.Add(Me.grpPurgeSetup)
        Me.pnlParaSet.Controls.Add(Me.txtProcessPumpVacuum)
        Me.pnlParaSet.Controls.Add(Me.txtProcessPumpTime)
        Me.pnlParaSet.Controls.Add(Me.lblProcessPumpTimeText)
        Me.pnlParaSet.Controls.Add(Me.lblSec14Text)
        Me.pnlParaSet.Location = New System.Drawing.Point(0, 1)
        Me.pnlParaSet.Name = "pnlParaSet"
        Me.pnlParaSet.Size = New System.Drawing.Size(1024, 541)
        Me.pnlParaSet.TabIndex = 318
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnSelPath)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.dudLogStartTime)
        Me.Panel3.Controls.Add(Me.txtWebPath)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Location = New System.Drawing.Point(448, 465)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(513, 69)
        Me.Panel3.TabIndex = 631
        '
        'btnSelPath
        '
        Me.btnSelPath.Location = New System.Drawing.Point(435, 30)
        Me.btnSelPath.Name = "btnSelPath"
        Me.btnSelPath.Size = New System.Drawing.Size(31, 39)
        Me.btnSelPath.TabIndex = 630
        Me.btnSelPath.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(259, 5)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(23, 23)
        Me.Label11.TabIndex = 629
        Me.Label11.Text = "hr"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(13, 5)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(154, 28)
        Me.Label10.TabIndex = 627
        Me.Label10.Text = "每日稼動率起算時間"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dudLogStartTime
        '
        Me.dudLogStartTime.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dudLogStartTime.Items.Add("0")
        Me.dudLogStartTime.Items.Add("1")
        Me.dudLogStartTime.Items.Add("2")
        Me.dudLogStartTime.Items.Add("3")
        Me.dudLogStartTime.Items.Add("4")
        Me.dudLogStartTime.Items.Add("5")
        Me.dudLogStartTime.Items.Add("6")
        Me.dudLogStartTime.Items.Add("7")
        Me.dudLogStartTime.Items.Add("8")
        Me.dudLogStartTime.Items.Add("9")
        Me.dudLogStartTime.Items.Add("10")
        Me.dudLogStartTime.Items.Add("11")
        Me.dudLogStartTime.Items.Add("12")
        Me.dudLogStartTime.Items.Add("13")
        Me.dudLogStartTime.Items.Add("14")
        Me.dudLogStartTime.Items.Add("15")
        Me.dudLogStartTime.Items.Add("16")
        Me.dudLogStartTime.Items.Add("17")
        Me.dudLogStartTime.Items.Add("18")
        Me.dudLogStartTime.Items.Add("19")
        Me.dudLogStartTime.Items.Add("20")
        Me.dudLogStartTime.Items.Add("21")
        Me.dudLogStartTime.Items.Add("22")
        Me.dudLogStartTime.Items.Add("23")
        Me.dudLogStartTime.Location = New System.Drawing.Point(177, 5)
        Me.dudLogStartTime.Name = "dudLogStartTime"
        Me.dudLogStartTime.Size = New System.Drawing.Size(76, 22)
        Me.dudLogStartTime.TabIndex = 628
        Me.dudLogStartTime.Text = "0"
        '
        'txtWebPath
        '
        Me.txtWebPath.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWebPath.Location = New System.Drawing.Point(59, 36)
        Me.txtWebPath.Name = "txtWebPath"
        Me.txtWebPath.Size = New System.Drawing.Size(386, 26)
        Me.txtWebPath.TabIndex = 626
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(1, 33)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 28)
        Me.Label12.TabIndex = 625
        Me.Label12.Text = "路徑"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.chkAvailBarCode)
        Me.Panel2.Controls.Add(Me.chkRunConfirm)
        Me.Panel2.Controls.Add(Me.chkAutoRecordData)
        Me.Panel2.Controls.Add(Me.chkBarcodeOnly)
        Me.Panel2.Controls.Add(Me.chkCIMUsed)
        Me.Panel2.Location = New System.Drawing.Point(449, 392)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(553, 65)
        Me.Panel2.TabIndex = 630
        Me.Panel2.Visible = False
        '
        'chkAvailBarCode
        '
        Me.chkAvailBarCode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAvailBarCode.Location = New System.Drawing.Point(434, 33)
        Me.chkAvailBarCode.Name = "chkAvailBarCode"
        Me.chkAvailBarCode.Size = New System.Drawing.Size(94, 26)
        Me.chkAvailBarCode.TabIndex = 610
        Me.chkAvailBarCode.Text = "稼動率"
        Me.chkAvailBarCode.UseVisualStyleBackColor = True
        '
        'chkRunConfirm
        '
        Me.chkRunConfirm.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRunConfirm.ForeColor = System.Drawing.Color.Black
        Me.chkRunConfirm.Location = New System.Drawing.Point(6, 33)
        Me.chkRunConfirm.Name = "chkRunConfirm"
        Me.chkRunConfirm.Size = New System.Drawing.Size(194, 26)
        Me.chkRunConfirm.TabIndex = 609
        Me.chkRunConfirm.Text = "執行前確認"
        '
        'chkAutoRecordData
        '
        Me.chkAutoRecordData.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAutoRecordData.ForeColor = System.Drawing.Color.Black
        Me.chkAutoRecordData.Location = New System.Drawing.Point(228, 2)
        Me.chkAutoRecordData.Name = "chkAutoRecordData"
        Me.chkAutoRecordData.Size = New System.Drawing.Size(190, 33)
        Me.chkAutoRecordData.TabIndex = 608
        Me.chkAutoRecordData.Text = "自動產生記錄檔名"
        '
        'chkBarcodeOnly
        '
        Me.chkBarcodeOnly.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBarcodeOnly.ForeColor = System.Drawing.Color.Black
        Me.chkBarcodeOnly.Location = New System.Drawing.Point(5, 5)
        Me.chkBarcodeOnly.Name = "chkBarcodeOnly"
        Me.chkBarcodeOnly.Size = New System.Drawing.Size(217, 33)
        Me.chkBarcodeOnly.TabIndex = 607
        Me.chkBarcodeOnly.Text = "只使用條碼刷入配方功能"
        '
        'chkCIMUsed
        '
        Me.chkCIMUsed.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCIMUsed.Location = New System.Drawing.Point(228, 34)
        Me.chkCIMUsed.Name = "chkCIMUsed"
        Me.chkCIMUsed.Size = New System.Drawing.Size(150, 26)
        Me.chkCIMUsed.TabIndex = 606
        Me.chkCIMUsed.Text = "Use CIM Function"
        Me.chkCIMUsed.UseVisualStyleBackColor = True
        Me.chkCIMUsed.Visible = False
        '
        'lblPullerTimeText
        '
        Me.lblPullerTimeText.BackColor = System.Drawing.Color.Transparent
        Me.lblPullerTimeText.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPullerTimeText.ForeColor = System.Drawing.Color.Black
        Me.lblPullerTimeText.Location = New System.Drawing.Point(769, 248)
        Me.lblPullerTimeText.Name = "lblPullerTimeText"
        Me.lblPullerTimeText.Size = New System.Drawing.Size(124, 36)
        Me.lblPullerTimeText.TabIndex = 629
        Me.lblPullerTimeText.Text = "Puller Close Time:"
        Me.lblPullerTimeText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSec12Text
        '
        Me.lblSec12Text.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSec12Text.ForeColor = System.Drawing.Color.Black
        Me.lblSec12Text.Location = New System.Drawing.Point(984, 254)
        Me.lblSec12Text.Name = "lblSec12Text"
        Me.lblSec12Text.Size = New System.Drawing.Size(27, 18)
        Me.lblSec12Text.TabIndex = 628
        Me.lblSec12Text.Text = "sec"
        '
        'txtPullerTime
        '
        Me.txtPullerTime.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPullerTime.Location = New System.Drawing.Point(899, 249)
        Me.txtPullerTime.Name = "txtPullerTime"
        Me.txtPullerTime.Size = New System.Drawing.Size(80, 26)
        Me.txtPullerTime.TabIndex = 627
        Me.txtPullerTime.Text = "10"
        Me.txtPullerTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDoorCloseTime
        '
        Me.lblDoorCloseTime.BackColor = System.Drawing.Color.Transparent
        Me.lblDoorCloseTime.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDoorCloseTime.ForeColor = System.Drawing.Color.Black
        Me.lblDoorCloseTime.Location = New System.Drawing.Point(769, 280)
        Me.lblDoorCloseTime.Name = "lblDoorCloseTime"
        Me.lblDoorCloseTime.Size = New System.Drawing.Size(124, 36)
        Me.lblDoorCloseTime.TabIndex = 626
        Me.lblDoorCloseTime.Text = "Door Close Time:"
        Me.lblDoorCloseTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grpVacuum
        '
        Me.grpVacuum.Controls.Add(Me.pnlDPWaterFlow)
        Me.grpVacuum.Controls.Add(Me.pnlDPTemp)
        Me.grpVacuum.Controls.Add(Me.lblProcessVacSetText)
        Me.grpVacuum.Controls.Add(Me.lblVentTimeText)
        Me.grpVacuum.Controls.Add(Me.lblProcessVacSetLoText)
        Me.grpVacuum.Controls.Add(Me.lblTorr03Text)
        Me.grpVacuum.Controls.Add(Me.txtCoolingTemp)
        Me.grpVacuum.Controls.Add(Me.txtVentTime)
        Me.grpVacuum.Controls.Add(Me.txtProcessVacSetLo)
        Me.grpVacuum.Controls.Add(Me.lblProcessOKCoolingText)
        Me.grpVacuum.Controls.Add(Me.lblTorr01Text)
        Me.grpVacuum.Controls.Add(Me.lblSec04Text)
        Me.grpVacuum.Controls.Add(Me.txtProcessVacSet)
        Me.grpVacuum.Controls.Add(Me.btnProcessAutoVacuum)
        Me.grpVacuum.Controls.Add(Me.lblProcessAutoVacuumText)
        Me.grpVacuum.Controls.Add(Me.PictureBox1)
        Me.grpVacuum.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpVacuum.Location = New System.Drawing.Point(448, 3)
        Me.grpVacuum.Name = "grpVacuum"
        Me.grpVacuum.Size = New System.Drawing.Size(562, 142)
        Me.grpVacuum.TabIndex = 522
        Me.grpVacuum.TabStop = False
        Me.grpVacuum.Text = "真空相關設定"
        '
        'pnlDPWaterFlow
        '
        Me.pnlDPWaterFlow.Controls.Add(Me.txtDPWaterFlowAlarm)
        Me.pnlDPWaterFlow.Controls.Add(Me.Label7)
        Me.pnlDPWaterFlow.Controls.Add(Me.lblDPWaterAlarmText)
        Me.pnlDPWaterFlow.Location = New System.Drawing.Point(315, 83)
        Me.pnlDPWaterFlow.Name = "pnlDPWaterFlow"
        Me.pnlDPWaterFlow.Size = New System.Drawing.Size(247, 29)
        Me.pnlDPWaterFlow.TabIndex = 543
        Me.pnlDPWaterFlow.Visible = False
        '
        'txtDPWaterFlowAlarm
        '
        Me.txtDPWaterFlowAlarm.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDPWaterFlowAlarm.Location = New System.Drawing.Point(143, 1)
        Me.txtDPWaterFlowAlarm.Name = "txtDPWaterFlowAlarm"
        Me.txtDPWaterFlowAlarm.Size = New System.Drawing.Size(49, 21)
        Me.txtDPWaterFlowAlarm.TabIndex = 849
        Me.txtDPWaterFlowAlarm.Text = "4.0"
        Me.txtDPWaterFlowAlarm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(193, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 26)
        Me.Label7.TabIndex = 851
        Me.Label7.Text = "L/Min"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDPWaterAlarmText
        '
        Me.lblDPWaterAlarmText.BackColor = System.Drawing.Color.Transparent
        Me.lblDPWaterAlarmText.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDPWaterAlarmText.Location = New System.Drawing.Point(11, -7)
        Me.lblDPWaterAlarmText.Name = "lblDPWaterAlarmText"
        Me.lblDPWaterAlarmText.Size = New System.Drawing.Size(126, 36)
        Me.lblDPWaterAlarmText.TabIndex = 850
        Me.lblDPWaterAlarmText.Text = "DP 水流量警報:"
        Me.lblDPWaterAlarmText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlDPTemp
        '
        Me.pnlDPTemp.Controls.Add(Me.txtDPTempAlarmOff)
        Me.pnlDPTemp.Controls.Add(Me.txtDPTempAlarmText)
        Me.pnlDPTemp.Controls.Add(Me.lblDPTempAlarmOffText)
        Me.pnlDPTemp.Controls.Add(Me.PictureBox4)
        Me.pnlDPTemp.Controls.Add(Me.lblDPTempAlarmText)
        Me.pnlDPTemp.Controls.Add(Me.PictureBox3)
        Me.pnlDPTemp.Location = New System.Drawing.Point(307, 13)
        Me.pnlDPTemp.Name = "pnlDPTemp"
        Me.pnlDPTemp.Size = New System.Drawing.Size(256, 67)
        Me.pnlDPTemp.TabIndex = 530
        Me.pnlDPTemp.Visible = False
        '
        'txtDPTempAlarmOff
        '
        Me.txtDPTempAlarmOff.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDPTempAlarmOff.Location = New System.Drawing.Point(165, 34)
        Me.txtDPTempAlarmOff.Name = "txtDPTempAlarmOff"
        Me.txtDPTempAlarmOff.Size = New System.Drawing.Size(49, 21)
        Me.txtDPTempAlarmOff.TabIndex = 525
        Me.txtDPTempAlarmOff.Text = "70"
        Me.txtDPTempAlarmOff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDPTempAlarmText
        '
        Me.txtDPTempAlarmText.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDPTempAlarmText.Location = New System.Drawing.Point(165, 6)
        Me.txtDPTempAlarmText.Name = "txtDPTempAlarmText"
        Me.txtDPTempAlarmText.Size = New System.Drawing.Size(49, 21)
        Me.txtDPTempAlarmText.TabIndex = 524
        Me.txtDPTempAlarmText.Text = "65"
        Me.txtDPTempAlarmText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDPTempAlarmOffText
        '
        Me.lblDPTempAlarmOffText.BackColor = System.Drawing.Color.Transparent
        Me.lblDPTempAlarmOffText.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDPTempAlarmOffText.Location = New System.Drawing.Point(33, 30)
        Me.lblDPTempAlarmOffText.Name = "lblDPTempAlarmOffText"
        Me.lblDPTempAlarmOffText.Size = New System.Drawing.Size(126, 36)
        Me.lblDPTempAlarmOffText.TabIndex = 527
        Me.lblDPTempAlarmOffText.Text = "DP 關閉溫度:"
        Me.lblDPTempAlarmOffText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Location = New System.Drawing.Point(222, 32)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(29, 26)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 529
        Me.PictureBox4.TabStop = False
        '
        'lblDPTempAlarmText
        '
        Me.lblDPTempAlarmText.BackColor = System.Drawing.Color.Transparent
        Me.lblDPTempAlarmText.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDPTempAlarmText.Location = New System.Drawing.Point(33, 2)
        Me.lblDPTempAlarmText.Name = "lblDPTempAlarmText"
        Me.lblDPTempAlarmText.Size = New System.Drawing.Size(126, 36)
        Me.lblDPTempAlarmText.TabIndex = 526
        Me.lblDPTempAlarmText.Text = "DP 警報溫度:"
        Me.lblDPTempAlarmText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Location = New System.Drawing.Point(222, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(29, 26)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 528
        Me.PictureBox3.TabStop = False
        '
        'lblProcessVacSetText
        '
        Me.lblProcessVacSetText.BackColor = System.Drawing.Color.Transparent
        Me.lblProcessVacSetText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcessVacSetText.ForeColor = System.Drawing.Color.Black
        Me.lblProcessVacSetText.Location = New System.Drawing.Point(12, 73)
        Me.lblProcessVacSetText.Name = "lblProcessVacSetText"
        Me.lblProcessVacSetText.Size = New System.Drawing.Size(167, 36)
        Me.lblProcessVacSetText.TabIndex = 519
        Me.lblProcessVacSetText.Text = "幫浦停止真空度:"
        Me.lblProcessVacSetText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblVentTimeText
        '
        Me.lblVentTimeText.BackColor = System.Drawing.Color.Transparent
        Me.lblVentTimeText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVentTimeText.Location = New System.Drawing.Point(21, 19)
        Me.lblVentTimeText.Name = "lblVentTimeText"
        Me.lblVentTimeText.Size = New System.Drawing.Size(158, 36)
        Me.lblVentTimeText.TabIndex = 47
        Me.lblVentTimeText.Text = "Vent ON 時間:"
        Me.lblVentTimeText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblProcessVacSetLoText
        '
        Me.lblProcessVacSetLoText.BackColor = System.Drawing.Color.Transparent
        Me.lblProcessVacSetLoText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcessVacSetLoText.ForeColor = System.Drawing.Color.Black
        Me.lblProcessVacSetLoText.Location = New System.Drawing.Point(22, 101)
        Me.lblProcessVacSetLoText.Name = "lblProcessVacSetLoText"
        Me.lblProcessVacSetLoText.Size = New System.Drawing.Size(161, 36)
        Me.lblProcessVacSetLoText.TabIndex = 520
        Me.lblProcessVacSetLoText.Text = "開始抽氣真空度:"
        Me.lblProcessVacSetLoText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTorr03Text
        '
        Me.lblTorr03Text.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTorr03Text.ForeColor = System.Drawing.Color.Black
        Me.lblTorr03Text.Location = New System.Drawing.Point(269, 91)
        Me.lblTorr03Text.Name = "lblTorr03Text"
        Me.lblTorr03Text.Size = New System.Drawing.Size(36, 18)
        Me.lblTorr03Text.TabIndex = 515
        Me.lblTorr03Text.Text = "Torr"
        '
        'txtVentTime
        '
        Me.txtVentTime.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVentTime.Location = New System.Drawing.Point(184, 25)
        Me.txtVentTime.Name = "txtVentTime"
        Me.txtVentTime.Size = New System.Drawing.Size(80, 21)
        Me.txtVentTime.TabIndex = 6
        Me.txtVentTime.Text = "15"
        Me.txtVentTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtProcessVacSetLo
        '
        Me.txtProcessVacSetLo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProcessVacSetLo.Location = New System.Drawing.Point(184, 110)
        Me.txtProcessVacSetLo.Name = "txtProcessVacSetLo"
        Me.txtProcessVacSetLo.Size = New System.Drawing.Size(80, 21)
        Me.txtProcessVacSetLo.TabIndex = 517
        Me.txtProcessVacSetLo.Text = "1.0E-01"
        Me.txtProcessVacSetLo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTorr01Text
        '
        Me.lblTorr01Text.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTorr01Text.ForeColor = System.Drawing.Color.Black
        Me.lblTorr01Text.Location = New System.Drawing.Point(271, 120)
        Me.lblTorr01Text.Name = "lblTorr01Text"
        Me.lblTorr01Text.Size = New System.Drawing.Size(36, 18)
        Me.lblTorr01Text.TabIndex = 498
        Me.lblTorr01Text.Text = "Torr"
        '
        'lblSec04Text
        '
        Me.lblSec04Text.BackColor = System.Drawing.Color.Transparent
        Me.lblSec04Text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSec04Text.ForeColor = System.Drawing.Color.Black
        Me.lblSec04Text.Location = New System.Drawing.Point(269, 25)
        Me.lblSec04Text.Name = "lblSec04Text"
        Me.lblSec04Text.Size = New System.Drawing.Size(45, 26)
        Me.lblSec04Text.TabIndex = 508
        Me.lblSec04Text.Text = "Sec"
        Me.lblSec04Text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtProcessVacSet
        '
        Me.txtProcessVacSet.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProcessVacSet.Location = New System.Drawing.Point(184, 81)
        Me.txtProcessVacSet.Name = "txtProcessVacSet"
        Me.txtProcessVacSet.Size = New System.Drawing.Size(80, 21)
        Me.txtProcessVacSet.TabIndex = 513
        Me.txtProcessVacSet.Text = "8.0E-02"
        Me.txtProcessVacSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnProcessAutoVacuum
        '
        Me.btnProcessAutoVacuum.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnProcessAutoVacuum.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcessAutoVacuum.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcessAutoVacuum.Location = New System.Drawing.Point(474, 112)
        Me.btnProcessAutoVacuum.Name = "btnProcessAutoVacuum"
        Me.btnProcessAutoVacuum.Size = New System.Drawing.Size(80, 30)
        Me.btnProcessAutoVacuum.TabIndex = 48
        Me.btnProcessAutoVacuum.Text = "OFF"
        Me.btnProcessAutoVacuum.UseVisualStyleBackColor = False
        Me.btnProcessAutoVacuum.Visible = False
        '
        'lblProcessAutoVacuumText
        '
        Me.lblProcessAutoVacuumText.BackColor = System.Drawing.Color.Transparent
        Me.lblProcessAutoVacuumText.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcessAutoVacuumText.Location = New System.Drawing.Point(311, 109)
        Me.lblProcessAutoVacuumText.Name = "lblProcessAutoVacuumText"
        Me.lblProcessAutoVacuumText.Size = New System.Drawing.Size(158, 36)
        Me.lblProcessAutoVacuumText.TabIndex = 47
        Me.lblProcessAutoVacuumText.Text = "真空維持:"
        Me.lblProcessAutoVacuumText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblProcessAutoVacuumText.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Location = New System.Drawing.Point(272, 56)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(29, 26)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 506
        Me.PictureBox1.TabStop = False
        '
        'lblSec13Text
        '
        Me.lblSec13Text.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSec13Text.ForeColor = System.Drawing.Color.Black
        Me.lblSec13Text.Location = New System.Drawing.Point(984, 285)
        Me.lblSec13Text.Name = "lblSec13Text"
        Me.lblSec13Text.Size = New System.Drawing.Size(27, 18)
        Me.lblSec13Text.TabIndex = 625
        Me.lblSec13Text.Text = "sec"
        '
        'grpProcessCondition
        '
        Me.grpProcessCondition.Controls.Add(Me.picC06)
        Me.grpProcessCondition.Controls.Add(Me.lblKg21Text)
        Me.grpProcessCondition.Controls.Add(Me.txtPressureRange)
        Me.grpProcessCondition.Controls.Add(Me.lblTempRangeText)
        Me.grpProcessCondition.Controls.Add(Me.lblTopLowLimitTempText)
        Me.grpProcessCondition.Controls.Add(Me.lblPressureRangeText)
        Me.grpProcessCondition.Controls.Add(Me.txtTopLowLimitTemp)
        Me.grpProcessCondition.Controls.Add(Me.txtTempRange)
        Me.grpProcessCondition.Controls.Add(Me.picC01)
        Me.grpProcessCondition.Controls.Add(Me.lblTopLowLimitPowerText)
        Me.grpProcessCondition.Controls.Add(Me.lblPercent07Text)
        Me.grpProcessCondition.Controls.Add(Me.txtTopLowLimitPower)
        Me.grpProcessCondition.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpProcessCondition.Location = New System.Drawing.Point(448, 236)
        Me.grpProcessCondition.Name = "grpProcessCondition"
        Me.grpProcessCondition.Size = New System.Drawing.Size(314, 150)
        Me.grpProcessCondition.TabIndex = 520
        Me.grpProcessCondition.TabStop = False
        Me.grpProcessCondition.Text = "製程條件設定"
        '
        'picC06
        '
        Me.picC06.BackColor = System.Drawing.SystemColors.Control
        Me.picC06.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picC06.Location = New System.Drawing.Point(266, 88)
        Me.picC06.Name = "picC06"
        Me.picC06.Size = New System.Drawing.Size(29, 29)
        Me.picC06.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picC06.TabIndex = 600
        Me.picC06.TabStop = False
        '
        'lblKg21Text
        '
        Me.lblKg21Text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKg21Text.ForeColor = System.Drawing.Color.Black
        Me.lblKg21Text.Location = New System.Drawing.Point(270, 22)
        Me.lblKg21Text.Name = "lblKg21Text"
        Me.lblKg21Text.Size = New System.Drawing.Size(45, 26)
        Me.lblKg21Text.TabIndex = 521
        Me.lblKg21Text.Text = "kg"
        '
        'lblTopLowLimitTempText
        '
        Me.lblTopLowLimitTempText.BackColor = System.Drawing.Color.Transparent
        Me.lblTopLowLimitTempText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopLowLimitTempText.ForeColor = System.Drawing.Color.Black
        Me.lblTopLowLimitTempText.Location = New System.Drawing.Point(4, 86)
        Me.lblTopLowLimitTempText.Name = "lblTopLowLimitTempText"
        Me.lblTopLowLimitTempText.Size = New System.Drawing.Size(174, 28)
        Me.lblTopLowLimitTempText.TabIndex = 598
        Me.lblTopLowLimitTempText.Text = "限制輸出最低溫度"
        Me.lblTopLowLimitTempText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTopLowLimitTemp
        '
        Me.txtTopLowLimitTemp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTopLowLimitTemp.Location = New System.Drawing.Point(184, 87)
        Me.txtTopLowLimitTemp.Name = "txtTopLowLimitTemp"
        Me.txtTopLowLimitTemp.Size = New System.Drawing.Size(80, 26)
        Me.txtTopLowLimitTemp.TabIndex = 596
        Me.txtTopLowLimitTemp.Text = "0"
        Me.txtTopLowLimitTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'picC01
        '
        Me.picC01.BackColor = System.Drawing.SystemColors.Control
        Me.picC01.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picC01.Location = New System.Drawing.Point(266, 56)
        Me.picC01.Name = "picC01"
        Me.picC01.Size = New System.Drawing.Size(29, 26)
        Me.picC01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picC01.TabIndex = 506
        Me.picC01.TabStop = False
        '
        'lblTopLowLimitPowerText
        '
        Me.lblTopLowLimitPowerText.BackColor = System.Drawing.Color.Transparent
        Me.lblTopLowLimitPowerText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopLowLimitPowerText.ForeColor = System.Drawing.Color.Black
        Me.lblTopLowLimitPowerText.Location = New System.Drawing.Point(4, 116)
        Me.lblTopLowLimitPowerText.Name = "lblTopLowLimitPowerText"
        Me.lblTopLowLimitPowerText.Size = New System.Drawing.Size(174, 28)
        Me.lblTopLowLimitPowerText.TabIndex = 599
        Me.lblTopLowLimitPowerText.Text = "限制輸出功率"
        Me.lblTopLowLimitPowerText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPercent07Text
        '
        Me.lblPercent07Text.BackColor = System.Drawing.Color.Transparent
        Me.lblPercent07Text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercent07Text.ForeColor = System.Drawing.Color.Black
        Me.lblPercent07Text.Location = New System.Drawing.Point(266, 125)
        Me.lblPercent07Text.Name = "lblPercent07Text"
        Me.lblPercent07Text.Size = New System.Drawing.Size(30, 24)
        Me.lblPercent07Text.TabIndex = 595
        Me.lblPercent07Text.Text = "%"
        Me.lblPercent07Text.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTopLowLimitPower
        '
        Me.txtTopLowLimitPower.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTopLowLimitPower.Location = New System.Drawing.Point(184, 116)
        Me.txtTopLowLimitPower.Name = "txtTopLowLimitPower"
        Me.txtTopLowLimitPower.Size = New System.Drawing.Size(80, 26)
        Me.txtTopLowLimitPower.TabIndex = 597
        Me.txtTopLowLimitPower.Text = "0"
        Me.txtTopLowLimitPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDoorCloseTime
        '
        Me.txtDoorCloseTime.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDoorCloseTime.Location = New System.Drawing.Point(899, 280)
        Me.txtDoorCloseTime.Name = "txtDoorCloseTime"
        Me.txtDoorCloseTime.Size = New System.Drawing.Size(80, 26)
        Me.txtDoorCloseTime.TabIndex = 624
        Me.txtDoorCloseTime.Text = "30"
        Me.txtDoorCloseTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblProcessPumpVacuumText
        '
        Me.lblProcessPumpVacuumText.BackColor = System.Drawing.Color.Transparent
        Me.lblProcessPumpVacuumText.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcessPumpVacuumText.ForeColor = System.Drawing.Color.Black
        Me.lblProcessPumpVacuumText.Location = New System.Drawing.Point(769, 343)
        Me.lblProcessPumpVacuumText.Name = "lblProcessPumpVacuumText"
        Me.lblProcessPumpVacuumText.Size = New System.Drawing.Size(124, 36)
        Me.lblProcessPumpVacuumText.TabIndex = 623
        Me.lblProcessPumpVacuumText.Text = "Pumping Vacuum:"
        Me.lblProcessPumpVacuumText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grpAlarmSetup
        '
        Me.grpAlarmSetup.Controls.Add(Me.txtHiPressureLimit)
        Me.grpAlarmSetup.Controls.Add(Me.lblHiPressureLimitText)
        Me.grpAlarmSetup.Controls.Add(Me.lblKg05Text)
        Me.grpAlarmSetup.Controls.Add(Me.pnlFlowShow)
        Me.grpAlarmSetup.Controls.Add(Me.lblmm03Text)
        Me.grpAlarmSetup.Controls.Add(Me.lblPlate06Text)
        Me.grpAlarmSetup.Controls.Add(Me.lblPlate05Text)
        Me.grpAlarmSetup.Controls.Add(Me.lblPlate04Text)
        Me.grpAlarmSetup.Controls.Add(Me.txtPosition06Set)
        Me.grpAlarmSetup.Controls.Add(Me.txtPosition05Set)
        Me.grpAlarmSetup.Controls.Add(Me.txtPosition04Set)
        Me.grpAlarmSetup.Controls.Add(Me.lblPlate03Text)
        Me.grpAlarmSetup.Controls.Add(Me.lblPlate02Text)
        Me.grpAlarmSetup.Controls.Add(Me.lblPlate01Text)
        Me.grpAlarmSetup.Controls.Add(Me.txtPosition03Set)
        Me.grpAlarmSetup.Controls.Add(Me.txtPosition02Set)
        Me.grpAlarmSetup.Controls.Add(Me.txtPosition01Set)
        Me.grpAlarmSetup.Controls.Add(Me.lblPositionSetText)
        Me.grpAlarmSetup.Controls.Add(Me.txtDpCurrentAlarmTime)
        Me.grpAlarmSetup.Controls.Add(Me.lblSec24Text)
        Me.grpAlarmSetup.Controls.Add(Me.lblmm02Text)
        Me.grpAlarmSetup.Controls.Add(Me.chkTempAbort)
        Me.grpAlarmSetup.Controls.Add(Me.chkPressureAbort)
        Me.grpAlarmSetup.Controls.Add(Me.lblKg22Text)
        Me.grpAlarmSetup.Controls.Add(Me.txtAbortPressureRange)
        Me.grpAlarmSetup.Controls.Add(Me.lblAbortTempRangeText)
        Me.grpAlarmSetup.Controls.Add(Me.lblAbortPressureRangeText)
        Me.grpAlarmSetup.Controls.Add(Me.txtAbortTempRange)
        Me.grpAlarmSetup.Controls.Add(Me.PictureBox2)
        Me.grpAlarmSetup.Controls.Add(Me.lblProcessPressAlarmTimeText)
        Me.grpAlarmSetup.Controls.Add(Me.lblSec09Text)
        Me.grpAlarmSetup.Controls.Add(Me.txtProcessPressAlarmTime)
        Me.grpAlarmSetup.Controls.Add(Me.lblProcessTempAlarmTimeText)
        Me.grpAlarmSetup.Controls.Add(Me.lblSec08Text)
        Me.grpAlarmSetup.Controls.Add(Me.txtProcessTempAlarmTime)
        Me.grpAlarmSetup.Controls.Add(Me.lblPressAlarmTimeText)
        Me.grpAlarmSetup.Controls.Add(Me.lblSec06Text)
        Me.grpAlarmSetup.Controls.Add(Me.txtPressAlarmTime)
        Me.grpAlarmSetup.Controls.Add(Me.lblTempAlarmTimeText)
        Me.grpAlarmSetup.Controls.Add(Me.lblSec07Text)
        Me.grpAlarmSetup.Controls.Add(Me.txtTempAlarmTime)
        Me.grpAlarmSetup.Controls.Add(Me.lblHiTempLimitText)
        Me.grpAlarmSetup.Controls.Add(Me.lblPumpTimeText)
        Me.grpAlarmSetup.Controls.Add(Me.lblA01Text)
        Me.grpAlarmSetup.Controls.Add(Me.lblProcessEndAlarmText)
        Me.grpAlarmSetup.Controls.Add(Me.lblSec03Text)
        Me.grpAlarmSetup.Controls.Add(Me.txtHiTempLimit)
        Me.grpAlarmSetup.Controls.Add(Me.txtDpCurrentLimit)
        Me.grpAlarmSetup.Controls.Add(Me.btnEndAlarm)
        Me.grpAlarmSetup.Controls.Add(Me.lblDPCurrentLimitText)
        Me.grpAlarmSetup.Controls.Add(Me.lblLowFlowAlarmText)
        Me.grpAlarmSetup.Controls.Add(Me.txtPumpTime)
        Me.grpAlarmSetup.Controls.Add(Me.lblSec05Text)
        Me.grpAlarmSetup.Controls.Add(Me.picC05)
        Me.grpAlarmSetup.Controls.Add(Me.txtLowFlowAlarm)
        Me.grpAlarmSetup.Controls.Add(Me.txtProcessEndBZonTime)
        Me.grpAlarmSetup.Controls.Add(Me.lblFlowUnit01Text)
        Me.grpAlarmSetup.Location = New System.Drawing.Point(5, 5)
        Me.grpAlarmSetup.Name = "grpAlarmSetup"
        Me.grpAlarmSetup.Size = New System.Drawing.Size(437, 532)
        Me.grpAlarmSetup.TabIndex = 520
        Me.grpAlarmSetup.TabStop = False
        Me.grpAlarmSetup.Text = "警報設定"
        '
        'txtHiPressureLimit
        '
        Me.txtHiPressureLimit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHiPressureLimit.Location = New System.Drawing.Point(169, 48)
        Me.txtHiPressureLimit.Name = "txtHiPressureLimit"
        Me.txtHiPressureLimit.Size = New System.Drawing.Size(80, 26)
        Me.txtHiPressureLimit.TabIndex = 853
        Me.txtHiPressureLimit.Text = "15000"
        Me.txtHiPressureLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblHiPressureLimitText
        '
        Me.lblHiPressureLimitText.BackColor = System.Drawing.Color.Transparent
        Me.lblHiPressureLimitText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHiPressureLimitText.ForeColor = System.Drawing.Color.Black
        Me.lblHiPressureLimitText.Location = New System.Drawing.Point(6, 44)
        Me.lblHiPressureLimitText.Name = "lblHiPressureLimitText"
        Me.lblHiPressureLimitText.Size = New System.Drawing.Size(158, 36)
        Me.lblHiPressureLimitText.TabIndex = 852
        Me.lblHiPressureLimitText.Text = "超壓警報壓力:"
        Me.lblHiPressureLimitText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblKg05Text
        '
        Me.lblKg05Text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKg05Text.ForeColor = System.Drawing.Color.Black
        Me.lblKg05Text.Location = New System.Drawing.Point(257, 52)
        Me.lblKg05Text.Name = "lblKg05Text"
        Me.lblKg05Text.Size = New System.Drawing.Size(31, 26)
        Me.lblKg05Text.TabIndex = 851
        Me.lblKg05Text.Text = "kg"
        '
        'pnlFlowShow
        '
        Me.pnlFlowShow.Controls.Add(Me.lblBotFlow06)
        Me.pnlFlowShow.Controls.Add(Me.lbllmin01Text)
        Me.pnlFlowShow.Controls.Add(Me.lblBotFlow05)
        Me.pnlFlowShow.Controls.Add(Me.lblBotFlow04)
        Me.pnlFlowShow.Controls.Add(Me.lblBotFlow03)
        Me.pnlFlowShow.Controls.Add(Me.lblBotFlow02)
        Me.pnlFlowShow.Controls.Add(Me.lblBotFlow01)
        Me.pnlFlowShow.Controls.Add(Me.lblSite06)
        Me.pnlFlowShow.Controls.Add(Me.lblTopFlow06)
        Me.pnlFlowShow.Controls.Add(Me.lblSite05)
        Me.pnlFlowShow.Controls.Add(Me.lblTopFlow05)
        Me.pnlFlowShow.Controls.Add(Me.lblSite04)
        Me.pnlFlowShow.Controls.Add(Me.lblTopFlow04)
        Me.pnlFlowShow.Controls.Add(Me.lblSite03)
        Me.pnlFlowShow.Controls.Add(Me.lblTopFlow03)
        Me.pnlFlowShow.Controls.Add(Me.lblSite02)
        Me.pnlFlowShow.Controls.Add(Me.lblSite01Text)
        Me.pnlFlowShow.Controls.Add(Me.lblTopFlow02)
        Me.pnlFlowShow.Controls.Add(Me.lblTopFlow01)
        Me.pnlFlowShow.Location = New System.Drawing.Point(170, 167)
        Me.pnlFlowShow.Name = "pnlFlowShow"
        Me.pnlFlowShow.Size = New System.Drawing.Size(219, 72)
        Me.pnlFlowShow.TabIndex = 841
        '
        'lblBotFlow06
        '
        Me.lblBotFlow06.BackColor = System.Drawing.Color.Black
        Me.lblBotFlow06.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBotFlow06.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBotFlow06.ForeColor = System.Drawing.Color.Lime
        Me.lblBotFlow06.Location = New System.Drawing.Point(422, 46)
        Me.lblBotFlow06.Margin = New System.Windows.Forms.Padding(0)
        Me.lblBotFlow06.Name = "lblBotFlow06"
        Me.lblBotFlow06.Size = New System.Drawing.Size(51, 20)
        Me.lblBotFlow06.TabIndex = 563
        Me.lblBotFlow06.Text = "0"
        Me.lblBotFlow06.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblBotFlow06.Visible = False
        '
        'lbllmin01Text
        '
        Me.lbllmin01Text.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllmin01Text.ForeColor = System.Drawing.Color.Black
        Me.lbllmin01Text.Location = New System.Drawing.Point(160, 31)
        Me.lbllmin01Text.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbllmin01Text.Name = "lbllmin01Text"
        Me.lbllmin01Text.Size = New System.Drawing.Size(42, 24)
        Me.lbllmin01Text.TabIndex = 561
        Me.lbllmin01Text.Text = "L/Min"
        Me.lbllmin01Text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBotFlow05
        '
        Me.lblBotFlow05.BackColor = System.Drawing.Color.Black
        Me.lblBotFlow05.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBotFlow05.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBotFlow05.ForeColor = System.Drawing.Color.Lime
        Me.lblBotFlow05.Location = New System.Drawing.Point(371, 46)
        Me.lblBotFlow05.Margin = New System.Windows.Forms.Padding(0)
        Me.lblBotFlow05.Name = "lblBotFlow05"
        Me.lblBotFlow05.Size = New System.Drawing.Size(51, 20)
        Me.lblBotFlow05.TabIndex = 563
        Me.lblBotFlow05.Text = "0"
        Me.lblBotFlow05.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblBotFlow05.Visible = False
        '
        'lblBotFlow04
        '
        Me.lblBotFlow04.BackColor = System.Drawing.Color.Black
        Me.lblBotFlow04.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBotFlow04.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBotFlow04.ForeColor = System.Drawing.Color.Lime
        Me.lblBotFlow04.Location = New System.Drawing.Point(320, 46)
        Me.lblBotFlow04.Margin = New System.Windows.Forms.Padding(0)
        Me.lblBotFlow04.Name = "lblBotFlow04"
        Me.lblBotFlow04.Size = New System.Drawing.Size(51, 20)
        Me.lblBotFlow04.TabIndex = 563
        Me.lblBotFlow04.Text = "0"
        Me.lblBotFlow04.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblBotFlow04.Visible = False
        '
        'lblBotFlow03
        '
        Me.lblBotFlow03.BackColor = System.Drawing.Color.Black
        Me.lblBotFlow03.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBotFlow03.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBotFlow03.ForeColor = System.Drawing.Color.Lime
        Me.lblBotFlow03.Location = New System.Drawing.Point(105, 43)
        Me.lblBotFlow03.Margin = New System.Windows.Forms.Padding(0)
        Me.lblBotFlow03.Name = "lblBotFlow03"
        Me.lblBotFlow03.Size = New System.Drawing.Size(51, 20)
        Me.lblBotFlow03.TabIndex = 563
        Me.lblBotFlow03.Text = "0"
        Me.lblBotFlow03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBotFlow02
        '
        Me.lblBotFlow02.BackColor = System.Drawing.Color.Black
        Me.lblBotFlow02.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBotFlow02.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBotFlow02.ForeColor = System.Drawing.Color.Lime
        Me.lblBotFlow02.Location = New System.Drawing.Point(54, 43)
        Me.lblBotFlow02.Margin = New System.Windows.Forms.Padding(0)
        Me.lblBotFlow02.Name = "lblBotFlow02"
        Me.lblBotFlow02.Size = New System.Drawing.Size(51, 20)
        Me.lblBotFlow02.TabIndex = 563
        Me.lblBotFlow02.Text = "0"
        Me.lblBotFlow02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBotFlow01
        '
        Me.lblBotFlow01.BackColor = System.Drawing.Color.Black
        Me.lblBotFlow01.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBotFlow01.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBotFlow01.ForeColor = System.Drawing.Color.Lime
        Me.lblBotFlow01.Location = New System.Drawing.Point(3, 43)
        Me.lblBotFlow01.Margin = New System.Windows.Forms.Padding(0)
        Me.lblBotFlow01.Name = "lblBotFlow01"
        Me.lblBotFlow01.Size = New System.Drawing.Size(51, 20)
        Me.lblBotFlow01.TabIndex = 563
        Me.lblBotFlow01.Text = "0"
        Me.lblBotFlow01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSite06
        '
        Me.lblSite06.BackColor = System.Drawing.SystemColors.Control
        Me.lblSite06.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSite06.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSite06.ForeColor = System.Drawing.Color.Black
        Me.lblSite06.Location = New System.Drawing.Point(422, 6)
        Me.lblSite06.Margin = New System.Windows.Forms.Padding(0)
        Me.lblSite06.Name = "lblSite06"
        Me.lblSite06.Size = New System.Drawing.Size(51, 20)
        Me.lblSite06.TabIndex = 562
        Me.lblSite06.Text = "#6"
        Me.lblSite06.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblSite06.Visible = False
        '
        'lblTopFlow06
        '
        Me.lblTopFlow06.BackColor = System.Drawing.Color.Black
        Me.lblTopFlow06.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTopFlow06.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopFlow06.ForeColor = System.Drawing.Color.Lime
        Me.lblTopFlow06.Location = New System.Drawing.Point(422, 26)
        Me.lblTopFlow06.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTopFlow06.Name = "lblTopFlow06"
        Me.lblTopFlow06.Size = New System.Drawing.Size(51, 20)
        Me.lblTopFlow06.TabIndex = 562
        Me.lblTopFlow06.Text = "0"
        Me.lblTopFlow06.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblTopFlow06.Visible = False
        '
        'lblSite05
        '
        Me.lblSite05.BackColor = System.Drawing.SystemColors.Control
        Me.lblSite05.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSite05.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSite05.ForeColor = System.Drawing.Color.Black
        Me.lblSite05.Location = New System.Drawing.Point(371, 6)
        Me.lblSite05.Margin = New System.Windows.Forms.Padding(0)
        Me.lblSite05.Name = "lblSite05"
        Me.lblSite05.Size = New System.Drawing.Size(51, 20)
        Me.lblSite05.TabIndex = 562
        Me.lblSite05.Text = "#5"
        Me.lblSite05.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblSite05.Visible = False
        '
        'lblTopFlow05
        '
        Me.lblTopFlow05.BackColor = System.Drawing.Color.Black
        Me.lblTopFlow05.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTopFlow05.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopFlow05.ForeColor = System.Drawing.Color.Lime
        Me.lblTopFlow05.Location = New System.Drawing.Point(371, 26)
        Me.lblTopFlow05.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTopFlow05.Name = "lblTopFlow05"
        Me.lblTopFlow05.Size = New System.Drawing.Size(51, 20)
        Me.lblTopFlow05.TabIndex = 562
        Me.lblTopFlow05.Text = "0"
        Me.lblTopFlow05.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblTopFlow05.Visible = False
        '
        'lblSite04
        '
        Me.lblSite04.BackColor = System.Drawing.SystemColors.Control
        Me.lblSite04.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSite04.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSite04.ForeColor = System.Drawing.Color.Black
        Me.lblSite04.Location = New System.Drawing.Point(320, 6)
        Me.lblSite04.Margin = New System.Windows.Forms.Padding(0)
        Me.lblSite04.Name = "lblSite04"
        Me.lblSite04.Size = New System.Drawing.Size(51, 20)
        Me.lblSite04.TabIndex = 562
        Me.lblSite04.Text = "#4"
        Me.lblSite04.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblSite04.Visible = False
        '
        'lblTopFlow04
        '
        Me.lblTopFlow04.BackColor = System.Drawing.Color.Black
        Me.lblTopFlow04.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTopFlow04.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopFlow04.ForeColor = System.Drawing.Color.Lime
        Me.lblTopFlow04.Location = New System.Drawing.Point(320, 26)
        Me.lblTopFlow04.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTopFlow04.Name = "lblTopFlow04"
        Me.lblTopFlow04.Size = New System.Drawing.Size(51, 20)
        Me.lblTopFlow04.TabIndex = 562
        Me.lblTopFlow04.Text = "0"
        Me.lblTopFlow04.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblTopFlow04.Visible = False
        '
        'lblSite03
        '
        Me.lblSite03.BackColor = System.Drawing.SystemColors.Control
        Me.lblSite03.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSite03.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSite03.ForeColor = System.Drawing.Color.Black
        Me.lblSite03.Location = New System.Drawing.Point(105, 3)
        Me.lblSite03.Margin = New System.Windows.Forms.Padding(0)
        Me.lblSite03.Name = "lblSite03"
        Me.lblSite03.Size = New System.Drawing.Size(51, 20)
        Me.lblSite03.TabIndex = 562
        Me.lblSite03.Text = "#3"
        Me.lblSite03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTopFlow03
        '
        Me.lblTopFlow03.BackColor = System.Drawing.Color.Black
        Me.lblTopFlow03.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTopFlow03.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopFlow03.ForeColor = System.Drawing.Color.Lime
        Me.lblTopFlow03.Location = New System.Drawing.Point(105, 23)
        Me.lblTopFlow03.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTopFlow03.Name = "lblTopFlow03"
        Me.lblTopFlow03.Size = New System.Drawing.Size(51, 20)
        Me.lblTopFlow03.TabIndex = 562
        Me.lblTopFlow03.Text = "0"
        Me.lblTopFlow03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSite02
        '
        Me.lblSite02.BackColor = System.Drawing.SystemColors.Control
        Me.lblSite02.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSite02.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSite02.ForeColor = System.Drawing.Color.Black
        Me.lblSite02.Location = New System.Drawing.Point(54, 3)
        Me.lblSite02.Margin = New System.Windows.Forms.Padding(0)
        Me.lblSite02.Name = "lblSite02"
        Me.lblSite02.Size = New System.Drawing.Size(51, 20)
        Me.lblSite02.TabIndex = 562
        Me.lblSite02.Text = "#2"
        Me.lblSite02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSite01Text
        '
        Me.lblSite01Text.BackColor = System.Drawing.SystemColors.Control
        Me.lblSite01Text.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSite01Text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSite01Text.ForeColor = System.Drawing.Color.Black
        Me.lblSite01Text.Location = New System.Drawing.Point(3, 3)
        Me.lblSite01Text.Margin = New System.Windows.Forms.Padding(0)
        Me.lblSite01Text.Name = "lblSite01Text"
        Me.lblSite01Text.Size = New System.Drawing.Size(51, 20)
        Me.lblSite01Text.TabIndex = 562
        Me.lblSite01Text.Text = "#1"
        Me.lblSite01Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTopFlow02
        '
        Me.lblTopFlow02.BackColor = System.Drawing.Color.Black
        Me.lblTopFlow02.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTopFlow02.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopFlow02.ForeColor = System.Drawing.Color.Lime
        Me.lblTopFlow02.Location = New System.Drawing.Point(54, 23)
        Me.lblTopFlow02.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTopFlow02.Name = "lblTopFlow02"
        Me.lblTopFlow02.Size = New System.Drawing.Size(51, 20)
        Me.lblTopFlow02.TabIndex = 562
        Me.lblTopFlow02.Text = "0"
        Me.lblTopFlow02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTopFlow01
        '
        Me.lblTopFlow01.BackColor = System.Drawing.Color.Black
        Me.lblTopFlow01.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTopFlow01.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopFlow01.ForeColor = System.Drawing.Color.Lime
        Me.lblTopFlow01.Location = New System.Drawing.Point(3, 23)
        Me.lblTopFlow01.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTopFlow01.Name = "lblTopFlow01"
        Me.lblTopFlow01.Size = New System.Drawing.Size(51, 20)
        Me.lblTopFlow01.TabIndex = 562
        Me.lblTopFlow01.Text = "0"
        Me.lblTopFlow01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblmm03Text
        '
        Me.lblmm03Text.BackColor = System.Drawing.Color.Transparent
        Me.lblmm03Text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmm03Text.ForeColor = System.Drawing.Color.Black
        Me.lblmm03Text.Location = New System.Drawing.Point(356, 539)
        Me.lblmm03Text.Name = "lblmm03Text"
        Me.lblmm03Text.Size = New System.Drawing.Size(45, 26)
        Me.lblmm03Text.TabIndex = 840
        Me.lblmm03Text.Text = "mm"
        Me.lblmm03Text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblmm03Text.Visible = False
        '
        'lblPlate06Text
        '
        Me.lblPlate06Text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlate06Text.ForeColor = System.Drawing.Color.Black
        Me.lblPlate06Text.Location = New System.Drawing.Point(305, 544)
        Me.lblPlate06Text.Name = "lblPlate06Text"
        Me.lblPlate06Text.Size = New System.Drawing.Size(45, 18)
        Me.lblPlate06Text.TabIndex = 839
        Me.lblPlate06Text.Text = "#06"
        Me.lblPlate06Text.Visible = False
        '
        'lblPlate05Text
        '
        Me.lblPlate05Text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlate05Text.ForeColor = System.Drawing.Color.Black
        Me.lblPlate05Text.Location = New System.Drawing.Point(242, 544)
        Me.lblPlate05Text.Name = "lblPlate05Text"
        Me.lblPlate05Text.Size = New System.Drawing.Size(45, 18)
        Me.lblPlate05Text.TabIndex = 838
        Me.lblPlate05Text.Text = "#05"
        Me.lblPlate05Text.Visible = False
        '
        'lblPlate04Text
        '
        Me.lblPlate04Text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlate04Text.ForeColor = System.Drawing.Color.Black
        Me.lblPlate04Text.Location = New System.Drawing.Point(179, 544)
        Me.lblPlate04Text.Name = "lblPlate04Text"
        Me.lblPlate04Text.Size = New System.Drawing.Size(45, 18)
        Me.lblPlate04Text.TabIndex = 837
        Me.lblPlate04Text.Text = "#04"
        Me.lblPlate04Text.Visible = False
        '
        'txtPosition06Set
        '
        Me.txtPosition06Set.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPosition06Set.Location = New System.Drawing.Point(293, 539)
        Me.txtPosition06Set.Name = "txtPosition06Set"
        Me.txtPosition06Set.Size = New System.Drawing.Size(57, 26)
        Me.txtPosition06Set.TabIndex = 5
        Me.txtPosition06Set.Text = "10"
        Me.txtPosition06Set.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPosition06Set.Visible = False
        '
        'txtPosition05Set
        '
        Me.txtPosition05Set.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPosition05Set.Location = New System.Drawing.Point(230, 539)
        Me.txtPosition05Set.Name = "txtPosition05Set"
        Me.txtPosition05Set.Size = New System.Drawing.Size(57, 26)
        Me.txtPosition05Set.TabIndex = 4
        Me.txtPosition05Set.Text = "10"
        Me.txtPosition05Set.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPosition05Set.Visible = False
        '
        'txtPosition04Set
        '
        Me.txtPosition04Set.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPosition04Set.Location = New System.Drawing.Point(167, 539)
        Me.txtPosition04Set.Name = "txtPosition04Set"
        Me.txtPosition04Set.Size = New System.Drawing.Size(57, 26)
        Me.txtPosition04Set.TabIndex = 3
        Me.txtPosition04Set.Text = "10"
        Me.txtPosition04Set.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPosition04Set.Visible = False
        '
        'lblPlate03Text
        '
        Me.lblPlate03Text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlate03Text.ForeColor = System.Drawing.Color.Black
        Me.lblPlate03Text.Location = New System.Drawing.Point(305, 482)
        Me.lblPlate03Text.Name = "lblPlate03Text"
        Me.lblPlate03Text.Size = New System.Drawing.Size(45, 18)
        Me.lblPlate03Text.TabIndex = 833
        Me.lblPlate03Text.Text = "#03"
        '
        'lblPlate02Text
        '
        Me.lblPlate02Text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlate02Text.ForeColor = System.Drawing.Color.Black
        Me.lblPlate02Text.Location = New System.Drawing.Point(242, 482)
        Me.lblPlate02Text.Name = "lblPlate02Text"
        Me.lblPlate02Text.Size = New System.Drawing.Size(45, 18)
        Me.lblPlate02Text.TabIndex = 832
        Me.lblPlate02Text.Text = "#02"
        '
        'lblPlate01Text
        '
        Me.lblPlate01Text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlate01Text.ForeColor = System.Drawing.Color.Black
        Me.lblPlate01Text.Location = New System.Drawing.Point(179, 482)
        Me.lblPlate01Text.Name = "lblPlate01Text"
        Me.lblPlate01Text.Size = New System.Drawing.Size(45, 18)
        Me.lblPlate01Text.TabIndex = 831
        Me.lblPlate01Text.Text = "#01"
        '
        'txtPosition03Set
        '
        Me.txtPosition03Set.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPosition03Set.Location = New System.Drawing.Point(293, 503)
        Me.txtPosition03Set.Name = "txtPosition03Set"
        Me.txtPosition03Set.Size = New System.Drawing.Size(57, 26)
        Me.txtPosition03Set.TabIndex = 2
        Me.txtPosition03Set.Text = "10"
        Me.txtPosition03Set.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPosition02Set
        '
        Me.txtPosition02Set.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPosition02Set.Location = New System.Drawing.Point(230, 503)
        Me.txtPosition02Set.Name = "txtPosition02Set"
        Me.txtPosition02Set.Size = New System.Drawing.Size(57, 26)
        Me.txtPosition02Set.TabIndex = 1
        Me.txtPosition02Set.Text = "10"
        Me.txtPosition02Set.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPosition01Set
        '
        Me.txtPosition01Set.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPosition01Set.Location = New System.Drawing.Point(167, 503)
        Me.txtPosition01Set.Name = "txtPosition01Set"
        Me.txtPosition01Set.Size = New System.Drawing.Size(57, 26)
        Me.txtPosition01Set.TabIndex = 0
        Me.txtPosition01Set.Text = "10"
        Me.txtPosition01Set.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPositionSetText
        '
        Me.lblPositionSetText.BackColor = System.Drawing.Color.Transparent
        Me.lblPositionSetText.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPositionSetText.ForeColor = System.Drawing.Color.Black
        Me.lblPositionSetText.Location = New System.Drawing.Point(45, 503)
        Me.lblPositionSetText.Name = "lblPositionSetText"
        Me.lblPositionSetText.Size = New System.Drawing.Size(119, 26)
        Me.lblPositionSetText.TabIndex = 825
        Me.lblPositionSetText.Text = "治具高度(mm)"
        Me.lblPositionSetText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDpCurrentAlarmTime
        '
        Me.txtDpCurrentAlarmTime.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDpCurrentAlarmTime.Location = New System.Drawing.Point(293, 110)
        Me.txtDpCurrentAlarmTime.Name = "txtDpCurrentAlarmTime"
        Me.txtDpCurrentAlarmTime.Size = New System.Drawing.Size(50, 26)
        Me.txtDpCurrentAlarmTime.TabIndex = 562
        Me.txtDpCurrentAlarmTime.Text = "30"
        Me.txtDpCurrentAlarmTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblSec24Text
        '
        Me.lblSec24Text.BackColor = System.Drawing.Color.Transparent
        Me.lblSec24Text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSec24Text.ForeColor = System.Drawing.Color.Black
        Me.lblSec24Text.Location = New System.Drawing.Point(349, 111)
        Me.lblSec24Text.Name = "lblSec24Text"
        Me.lblSec24Text.Size = New System.Drawing.Size(45, 26)
        Me.lblSec24Text.TabIndex = 561
        Me.lblSec24Text.Text = "Sec"
        Me.lblSec24Text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblmm02Text
        '
        Me.lblmm02Text.BackColor = System.Drawing.Color.Transparent
        Me.lblmm02Text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmm02Text.ForeColor = System.Drawing.Color.Black
        Me.lblmm02Text.Location = New System.Drawing.Point(356, 502)
        Me.lblmm02Text.Name = "lblmm02Text"
        Me.lblmm02Text.Size = New System.Drawing.Size(45, 26)
        Me.lblmm02Text.TabIndex = 823
        Me.lblmm02Text.Text = "mm"
        Me.lblmm02Text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkTempAbort
        '
        Me.chkTempAbort.AutoSize = True
        Me.chkTempAbort.Location = New System.Drawing.Point(303, 24)
        Me.chkTempAbort.Name = "chkTempAbort"
        Me.chkTempAbort.Size = New System.Drawing.Size(91, 22)
        Me.chkTempAbort.TabIndex = 560
        Me.chkTempAbort.Text = "中斷製程"
        Me.chkTempAbort.UseVisualStyleBackColor = True
        '
        'chkPressureAbort
        '
        Me.chkPressureAbort.AutoSize = True
        Me.chkPressureAbort.Location = New System.Drawing.Point(303, 52)
        Me.chkPressureAbort.Name = "chkPressureAbort"
        Me.chkPressureAbort.Size = New System.Drawing.Size(91, 22)
        Me.chkPressureAbort.TabIndex = 559
        Me.chkPressureAbort.Text = "中斷製程"
        Me.chkPressureAbort.UseVisualStyleBackColor = True
        '
        'lblKg22Text
        '
        Me.lblKg22Text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKg22Text.ForeColor = System.Drawing.Color.Black
        Me.lblKg22Text.Location = New System.Drawing.Point(255, 412)
        Me.lblKg22Text.Name = "lblKg22Text"
        Me.lblKg22Text.Size = New System.Drawing.Size(32, 26)
        Me.lblKg22Text.TabIndex = 558
        Me.lblKg22Text.Text = "kg"
        '
        'txtAbortPressureRange
        '
        Me.txtAbortPressureRange.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAbortPressureRange.Location = New System.Drawing.Point(169, 412)
        Me.txtAbortPressureRange.Name = "txtAbortPressureRange"
        Me.txtAbortPressureRange.Size = New System.Drawing.Size(80, 26)
        Me.txtAbortPressureRange.TabIndex = 554
        Me.txtAbortPressureRange.Text = "100"
        Me.txtAbortPressureRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblAbortTempRangeText
        '
        Me.lblAbortTempRangeText.BackColor = System.Drawing.Color.Transparent
        Me.lblAbortTempRangeText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbortTempRangeText.ForeColor = System.Drawing.Color.Black
        Me.lblAbortTempRangeText.Location = New System.Drawing.Point(4, 439)
        Me.lblAbortTempRangeText.Name = "lblAbortTempRangeText"
        Me.lblAbortTempRangeText.Size = New System.Drawing.Size(158, 36)
        Me.lblAbortTempRangeText.TabIndex = 555
        Me.lblAbortTempRangeText.Text = "製程溫度警報(+/-):"
        Me.lblAbortTempRangeText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAbortPressureRangeText
        '
        Me.lblAbortPressureRangeText.BackColor = System.Drawing.Color.Transparent
        Me.lblAbortPressureRangeText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbortPressureRangeText.ForeColor = System.Drawing.Color.Black
        Me.lblAbortPressureRangeText.Location = New System.Drawing.Point(4, 407)
        Me.lblAbortPressureRangeText.Name = "lblAbortPressureRangeText"
        Me.lblAbortPressureRangeText.Size = New System.Drawing.Size(158, 36)
        Me.lblAbortPressureRangeText.TabIndex = 556
        Me.lblAbortPressureRangeText.Text = "製程壓力警報(+/-):"
        Me.lblAbortPressureRangeText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAbortTempRange
        '
        Me.txtAbortTempRange.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAbortTempRange.Location = New System.Drawing.Point(169, 444)
        Me.txtAbortTempRange.Name = "txtAbortTempRange"
        Me.txtAbortTempRange.Size = New System.Drawing.Size(80, 26)
        Me.txtAbortTempRange.TabIndex = 553
        Me.txtAbortTempRange.Text = "20"
        Me.txtAbortTempRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Location = New System.Drawing.Point(251, 446)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(29, 26)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 557
        Me.PictureBox2.TabStop = False
        '
        'lblProcessPressAlarmTimeText
        '
        Me.lblProcessPressAlarmTimeText.BackColor = System.Drawing.Color.Transparent
        Me.lblProcessPressAlarmTimeText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcessPressAlarmTimeText.ForeColor = System.Drawing.Color.Black
        Me.lblProcessPressAlarmTimeText.Location = New System.Drawing.Point(6, 375)
        Me.lblProcessPressAlarmTimeText.Name = "lblProcessPressAlarmTimeText"
        Me.lblProcessPressAlarmTimeText.Size = New System.Drawing.Size(158, 36)
        Me.lblProcessPressAlarmTimeText.TabIndex = 543
        Me.lblProcessPressAlarmTimeText.Text = "製程中加壓警報:"
        Me.lblProcessPressAlarmTimeText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSec09Text
        '
        Me.lblSec09Text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSec09Text.ForeColor = System.Drawing.Color.Black
        Me.lblSec09Text.Location = New System.Drawing.Point(253, 384)
        Me.lblSec09Text.Name = "lblSec09Text"
        Me.lblSec09Text.Size = New System.Drawing.Size(58, 18)
        Me.lblSec09Text.TabIndex = 544
        Me.lblSec09Text.Text = "Sec"
        '
        'txtProcessPressAlarmTime
        '
        Me.txtProcessPressAlarmTime.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProcessPressAlarmTime.Location = New System.Drawing.Point(169, 380)
        Me.txtProcessPressAlarmTime.Name = "txtProcessPressAlarmTime"
        Me.txtProcessPressAlarmTime.Size = New System.Drawing.Size(80, 26)
        Me.txtProcessPressAlarmTime.TabIndex = 542
        Me.txtProcessPressAlarmTime.Text = "300"
        Me.txtProcessPressAlarmTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblProcessTempAlarmTimeText
        '
        Me.lblProcessTempAlarmTimeText.BackColor = System.Drawing.Color.Transparent
        Me.lblProcessTempAlarmTimeText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcessTempAlarmTimeText.ForeColor = System.Drawing.Color.Black
        Me.lblProcessTempAlarmTimeText.Location = New System.Drawing.Point(6, 343)
        Me.lblProcessTempAlarmTimeText.Name = "lblProcessTempAlarmTimeText"
        Me.lblProcessTempAlarmTimeText.Size = New System.Drawing.Size(158, 36)
        Me.lblProcessTempAlarmTimeText.TabIndex = 540
        Me.lblProcessTempAlarmTimeText.Text = "製程中加溫警報:"
        Me.lblProcessTempAlarmTimeText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSec08Text
        '
        Me.lblSec08Text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSec08Text.ForeColor = System.Drawing.Color.Black
        Me.lblSec08Text.Location = New System.Drawing.Point(253, 352)
        Me.lblSec08Text.Name = "lblSec08Text"
        Me.lblSec08Text.Size = New System.Drawing.Size(58, 18)
        Me.lblSec08Text.TabIndex = 541
        Me.lblSec08Text.Text = "Sec"
        '
        'txtProcessTempAlarmTime
        '
        Me.txtProcessTempAlarmTime.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProcessTempAlarmTime.Location = New System.Drawing.Point(169, 348)
        Me.txtProcessTempAlarmTime.Name = "txtProcessTempAlarmTime"
        Me.txtProcessTempAlarmTime.Size = New System.Drawing.Size(80, 26)
        Me.txtProcessTempAlarmTime.TabIndex = 539
        Me.txtProcessTempAlarmTime.Text = "300"
        Me.txtProcessTempAlarmTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPressAlarmTimeText
        '
        Me.lblPressAlarmTimeText.BackColor = System.Drawing.Color.Transparent
        Me.lblPressAlarmTimeText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPressAlarmTimeText.ForeColor = System.Drawing.Color.Black
        Me.lblPressAlarmTimeText.Location = New System.Drawing.Point(6, 311)
        Me.lblPressAlarmTimeText.Name = "lblPressAlarmTimeText"
        Me.lblPressAlarmTimeText.Size = New System.Drawing.Size(158, 36)
        Me.lblPressAlarmTimeText.TabIndex = 537
        Me.lblPressAlarmTimeText.Text = "加壓警報時間:"
        Me.lblPressAlarmTimeText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSec06Text
        '
        Me.lblSec06Text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSec06Text.ForeColor = System.Drawing.Color.Black
        Me.lblSec06Text.Location = New System.Drawing.Point(253, 320)
        Me.lblSec06Text.Name = "lblSec06Text"
        Me.lblSec06Text.Size = New System.Drawing.Size(58, 18)
        Me.lblSec06Text.TabIndex = 538
        Me.lblSec06Text.Text = "Sec"
        '
        'txtPressAlarmTime
        '
        Me.txtPressAlarmTime.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPressAlarmTime.Location = New System.Drawing.Point(169, 316)
        Me.txtPressAlarmTime.Name = "txtPressAlarmTime"
        Me.txtPressAlarmTime.Size = New System.Drawing.Size(80, 26)
        Me.txtPressAlarmTime.TabIndex = 536
        Me.txtPressAlarmTime.Text = "300"
        Me.txtPressAlarmTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTempAlarmTimeText
        '
        Me.lblTempAlarmTimeText.BackColor = System.Drawing.Color.Transparent
        Me.lblTempAlarmTimeText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTempAlarmTimeText.ForeColor = System.Drawing.Color.Black
        Me.lblTempAlarmTimeText.Location = New System.Drawing.Point(6, 279)
        Me.lblTempAlarmTimeText.Name = "lblTempAlarmTimeText"
        Me.lblTempAlarmTimeText.Size = New System.Drawing.Size(158, 36)
        Me.lblTempAlarmTimeText.TabIndex = 534
        Me.lblTempAlarmTimeText.Text = "加溫警報時間:"
        Me.lblTempAlarmTimeText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSec07Text
        '
        Me.lblSec07Text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSec07Text.ForeColor = System.Drawing.Color.Black
        Me.lblSec07Text.Location = New System.Drawing.Point(253, 288)
        Me.lblSec07Text.Name = "lblSec07Text"
        Me.lblSec07Text.Size = New System.Drawing.Size(58, 18)
        Me.lblSec07Text.TabIndex = 535
        Me.lblSec07Text.Text = "Sec"
        '
        'txtTempAlarmTime
        '
        Me.txtTempAlarmTime.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTempAlarmTime.Location = New System.Drawing.Point(169, 284)
        Me.txtTempAlarmTime.Name = "txtTempAlarmTime"
        Me.txtTempAlarmTime.Size = New System.Drawing.Size(80, 26)
        Me.txtTempAlarmTime.TabIndex = 533
        Me.txtTempAlarmTime.Text = "300"
        Me.txtTempAlarmTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblA01Text
        '
        Me.lblA01Text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblA01Text.ForeColor = System.Drawing.Color.Black
        Me.lblA01Text.Location = New System.Drawing.Point(255, 110)
        Me.lblA01Text.Name = "lblA01Text"
        Me.lblA01Text.Size = New System.Drawing.Size(32, 24)
        Me.lblA01Text.TabIndex = 502
        Me.lblA01Text.Text = "A"
        '
        'lblSec03Text
        '
        Me.lblSec03Text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSec03Text.ForeColor = System.Drawing.Color.Black
        Me.lblSec03Text.Location = New System.Drawing.Point(253, 81)
        Me.lblSec03Text.Name = "lblSec03Text"
        Me.lblSec03Text.Size = New System.Drawing.Size(58, 18)
        Me.lblSec03Text.TabIndex = 498
        Me.lblSec03Text.Text = "Sec"
        '
        'lblLowFlowAlarmText
        '
        Me.lblLowFlowAlarmText.BackColor = System.Drawing.Color.Transparent
        Me.lblLowFlowAlarmText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLowFlowAlarmText.ForeColor = System.Drawing.Color.Black
        Me.lblLowFlowAlarmText.Location = New System.Drawing.Point(6, 134)
        Me.lblLowFlowAlarmText.Name = "lblLowFlowAlarmText"
        Me.lblLowFlowAlarmText.Size = New System.Drawing.Size(158, 36)
        Me.lblLowFlowAlarmText.TabIndex = 517
        Me.lblLowFlowAlarmText.Text = "水流量過低警報:"
        Me.lblLowFlowAlarmText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSec05Text
        '
        Me.lblSec05Text.BackColor = System.Drawing.Color.Transparent
        Me.lblSec05Text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSec05Text.ForeColor = System.Drawing.Color.Black
        Me.lblSec05Text.Location = New System.Drawing.Point(321, 249)
        Me.lblSec05Text.Name = "lblSec05Text"
        Me.lblSec05Text.Size = New System.Drawing.Size(45, 26)
        Me.lblSec05Text.TabIndex = 508
        Me.lblSec05Text.Text = "Sec"
        Me.lblSec05Text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picC05
        '
        Me.picC05.BackColor = System.Drawing.SystemColors.Control
        Me.picC05.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picC05.Location = New System.Drawing.Point(258, 20)
        Me.picC05.Name = "picC05"
        Me.picC05.Size = New System.Drawing.Size(29, 26)
        Me.picC05.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picC05.TabIndex = 506
        Me.picC05.TabStop = False
        '
        'txtLowFlowAlarm
        '
        Me.txtLowFlowAlarm.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLowFlowAlarm.Location = New System.Drawing.Point(169, 139)
        Me.txtLowFlowAlarm.Name = "txtLowFlowAlarm"
        Me.txtLowFlowAlarm.Size = New System.Drawing.Size(80, 26)
        Me.txtLowFlowAlarm.TabIndex = 516
        Me.txtLowFlowAlarm.Text = "60"
        Me.txtLowFlowAlarm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFlowUnit01Text
        '
        Me.lblFlowUnit01Text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFlowUnit01Text.ForeColor = System.Drawing.Color.Black
        Me.lblFlowUnit01Text.Location = New System.Drawing.Point(255, 140)
        Me.lblFlowUnit01Text.Name = "lblFlowUnit01Text"
        Me.lblFlowUnit01Text.Size = New System.Drawing.Size(55, 24)
        Me.lblFlowUnit01Text.TabIndex = 518
        Me.lblFlowUnit01Text.Text = "L/Min"
        '
        'lblTorr09Text
        '
        Me.lblTorr09Text.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTorr09Text.ForeColor = System.Drawing.Color.Black
        Me.lblTorr09Text.Location = New System.Drawing.Point(984, 349)
        Me.lblTorr09Text.Name = "lblTorr09Text"
        Me.lblTorr09Text.Size = New System.Drawing.Size(27, 18)
        Me.lblTorr09Text.TabIndex = 622
        Me.lblTorr09Text.Text = "Torr"
        '
        'grpPurgeSetup
        '
        Me.grpPurgeSetup.Controls.Add(Me.lblPumpingPurgeText)
        Me.grpPurgeSetup.Controls.Add(Me.lblTimes01Text)
        Me.grpPurgeSetup.Controls.Add(Me.lblPurgeOffText)
        Me.grpPurgeSetup.Controls.Add(Me.txtPurgeOFFTime)
        Me.grpPurgeSetup.Controls.Add(Me.lblPurgeOnText)
        Me.grpPurgeSetup.Controls.Add(Me.txtPurgeONTime)
        Me.grpPurgeSetup.Controls.Add(Me.txtPurgeCycle)
        Me.grpPurgeSetup.Controls.Add(Me.btnAutoPurge)
        Me.grpPurgeSetup.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPurgeSetup.Location = New System.Drawing.Point(448, 149)
        Me.grpPurgeSetup.Name = "grpPurgeSetup"
        Me.grpPurgeSetup.Size = New System.Drawing.Size(568, 80)
        Me.grpPurgeSetup.TabIndex = 519
        Me.grpPurgeSetup.TabStop = False
        Me.grpPurgeSetup.Text = "抽氣時PURGE 設定"
        '
        'lblPumpingPurgeText
        '
        Me.lblPumpingPurgeText.BackColor = System.Drawing.Color.Transparent
        Me.lblPumpingPurgeText.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblPumpingPurgeText.ForeColor = System.Drawing.Color.Black
        Me.lblPumpingPurgeText.Location = New System.Drawing.Point(6, 19)
        Me.lblPumpingPurgeText.Name = "lblPumpingPurgeText"
        Me.lblPumpingPurgeText.Size = New System.Drawing.Size(161, 36)
        Me.lblPumpingPurgeText.TabIndex = 508
        Me.lblPumpingPurgeText.Text = "抽氣時Purge:"
        Me.lblPumpingPurgeText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTimes01Text
        '
        Me.lblTimes01Text.BackColor = System.Drawing.Color.Transparent
        Me.lblTimes01Text.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblTimes01Text.ForeColor = System.Drawing.Color.Black
        Me.lblTimes01Text.Location = New System.Drawing.Point(347, 23)
        Me.lblTimes01Text.Name = "lblTimes01Text"
        Me.lblTimes01Text.Size = New System.Drawing.Size(38, 36)
        Me.lblTimes01Text.TabIndex = 508
        Me.lblTimes01Text.Text = "次"
        Me.lblTimes01Text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPurgeOffText
        '
        Me.lblPurgeOffText.BackColor = System.Drawing.Color.Transparent
        Me.lblPurgeOffText.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblPurgeOffText.ForeColor = System.Drawing.Color.Black
        Me.lblPurgeOffText.Location = New System.Drawing.Point(406, 40)
        Me.lblPurgeOffText.Name = "lblPurgeOffText"
        Me.lblPurgeOffText.Size = New System.Drawing.Size(68, 34)
        Me.lblPurgeOffText.TabIndex = 508
        Me.lblPurgeOffText.Text = "抽氣時間(s)"
        Me.lblPurgeOffText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPurgeOFFTime
        '
        Me.txtPurgeOFFTime.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtPurgeOFFTime.Location = New System.Drawing.Point(480, 48)
        Me.txtPurgeOFFTime.Name = "txtPurgeOFFTime"
        Me.txtPurgeOFFTime.Size = New System.Drawing.Size(80, 22)
        Me.txtPurgeOFFTime.TabIndex = 32
        Me.txtPurgeOFFTime.Text = "15"
        Me.txtPurgeOFFTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPurgeOnText
        '
        Me.lblPurgeOnText.BackColor = System.Drawing.Color.Transparent
        Me.lblPurgeOnText.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblPurgeOnText.ForeColor = System.Drawing.Color.Black
        Me.lblPurgeOnText.Location = New System.Drawing.Point(6, 44)
        Me.lblPurgeOnText.Name = "lblPurgeOnText"
        Me.lblPurgeOnText.Size = New System.Drawing.Size(161, 36)
        Me.lblPurgeOnText.TabIndex = 508
        Me.lblPurgeOnText.Text = "進氣時間(s)"
        Me.lblPurgeOnText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPurgeONTime
        '
        Me.txtPurgeONTime.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtPurgeONTime.Location = New System.Drawing.Point(173, 53)
        Me.txtPurgeONTime.Name = "txtPurgeONTime"
        Me.txtPurgeONTime.Size = New System.Drawing.Size(80, 22)
        Me.txtPurgeONTime.TabIndex = 31
        Me.txtPurgeONTime.Text = "3"
        Me.txtPurgeONTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPurgeCycle
        '
        Me.txtPurgeCycle.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtPurgeCycle.Location = New System.Drawing.Point(259, 28)
        Me.txtPurgeCycle.Name = "txtPurgeCycle"
        Me.txtPurgeCycle.Size = New System.Drawing.Size(80, 22)
        Me.txtPurgeCycle.TabIndex = 30
        Me.txtPurgeCycle.Text = "5"
        Me.txtPurgeCycle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAutoPurge
        '
        Me.btnAutoPurge.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnAutoPurge.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnAutoPurge.Location = New System.Drawing.Point(173, 24)
        Me.btnAutoPurge.Name = "btnAutoPurge"
        Me.btnAutoPurge.Size = New System.Drawing.Size(80, 26)
        Me.btnAutoPurge.TabIndex = 48
        Me.btnAutoPurge.Text = "OFF"
        Me.btnAutoPurge.UseVisualStyleBackColor = False
        '
        'txtProcessPumpVacuum
        '
        Me.txtProcessPumpVacuum.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProcessPumpVacuum.Location = New System.Drawing.Point(899, 342)
        Me.txtProcessPumpVacuum.Name = "txtProcessPumpVacuum"
        Me.txtProcessPumpVacuum.Size = New System.Drawing.Size(80, 26)
        Me.txtProcessPumpVacuum.TabIndex = 621
        Me.txtProcessPumpVacuum.Text = "7.0E+02"
        Me.txtProcessPumpVacuum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtProcessPumpTime
        '
        Me.txtProcessPumpTime.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProcessPumpTime.Location = New System.Drawing.Point(899, 310)
        Me.txtProcessPumpTime.Name = "txtProcessPumpTime"
        Me.txtProcessPumpTime.Size = New System.Drawing.Size(80, 26)
        Me.txtProcessPumpTime.TabIndex = 618
        Me.txtProcessPumpTime.Text = "15"
        Me.txtProcessPumpTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblProcessPumpTimeText
        '
        Me.lblProcessPumpTimeText.BackColor = System.Drawing.Color.Transparent
        Me.lblProcessPumpTimeText.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcessPumpTimeText.ForeColor = System.Drawing.Color.Black
        Me.lblProcessPumpTimeText.Location = New System.Drawing.Point(769, 308)
        Me.lblProcessPumpTimeText.Name = "lblProcessPumpTimeText"
        Me.lblProcessPumpTimeText.Size = New System.Drawing.Size(124, 36)
        Me.lblProcessPumpTimeText.TabIndex = 620
        Me.lblProcessPumpTimeText.Text = "Pumping Time:"
        Me.lblProcessPumpTimeText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSec14Text
        '
        Me.lblSec14Text.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSec14Text.ForeColor = System.Drawing.Color.Black
        Me.lblSec14Text.Location = New System.Drawing.Point(984, 317)
        Me.lblSec14Text.Name = "lblSec14Text"
        Me.lblSec14Text.Size = New System.Drawing.Size(27, 18)
        Me.lblSec14Text.TabIndex = 619
        Me.lblSec14Text.Text = "sec"
        '
        'grpPIDLoadSave
        '
        Me.grpPIDLoadSave.Controls.Add(Me.btnLoadPIDFile)
        Me.grpPIDLoadSave.Controls.Add(Me.txtPIDFileName)
        Me.grpPIDLoadSave.Controls.Add(Me.btnSavePIDFile)
        Me.grpPIDLoadSave.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPIDLoadSave.ForeColor = System.Drawing.Color.Black
        Me.grpPIDLoadSave.Location = New System.Drawing.Point(6, 481)
        Me.grpPIDLoadSave.Name = "grpPIDLoadSave"
        Me.grpPIDLoadSave.Size = New System.Drawing.Size(590, 55)
        Me.grpPIDLoadSave.TabIndex = 541
        Me.grpPIDLoadSave.TabStop = False
        Me.grpPIDLoadSave.Text = "PID 儲存/載入"
        '
        'btnLoadPIDFile
        '
        Me.btnLoadPIDFile.BackColor = System.Drawing.Color.AliceBlue
        Me.btnLoadPIDFile.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadPIDFile.Location = New System.Drawing.Point(9, 21)
        Me.btnLoadPIDFile.Name = "btnLoadPIDFile"
        Me.btnLoadPIDFile.Size = New System.Drawing.Size(100, 28)
        Me.btnLoadPIDFile.TabIndex = 517
        Me.btnLoadPIDFile.Text = "載入PID"
        Me.btnLoadPIDFile.UseVisualStyleBackColor = False
        '
        'txtPIDFileName
        '
        Me.txtPIDFileName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPIDFileName.Location = New System.Drawing.Point(141, 22)
        Me.txtPIDFileName.Name = "txtPIDFileName"
        Me.txtPIDFileName.Size = New System.Drawing.Size(226, 26)
        Me.txtPIDFileName.TabIndex = 514
        Me.txtPIDFileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSavePIDFile
        '
        Me.btnSavePIDFile.BackColor = System.Drawing.Color.Linen
        Me.btnSavePIDFile.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSavePIDFile.Location = New System.Drawing.Point(394, 21)
        Me.btnSavePIDFile.Name = "btnSavePIDFile"
        Me.btnSavePIDFile.Size = New System.Drawing.Size(100, 28)
        Me.btnSavePIDFile.TabIndex = 516
        Me.btnSavePIDFile.Text = "儲存PID"
        Me.btnSavePIDFile.UseVisualStyleBackColor = False
        '
        'tabParameter
        '
        Me.tabParameter.Controls.Add(Me.TabPageTIC)
        Me.tabParameter.Controls.Add(Me.TabPageTCal)
        Me.tabParameter.Controls.Add(Me.TabPagePCal)
        Me.tabParameter.Controls.Add(Me.TabPageSystem)
        Me.tabParameter.Controls.Add(Me.TabPageCIM)
        Me.tabParameter.Controls.Add(Me.TabPageCello)
        Me.tabParameter.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabParameter.ItemSize = New System.Drawing.Size(120, 40)
        Me.tabParameter.Location = New System.Drawing.Point(0, 116)
        Me.tabParameter.Name = "tabParameter"
        Me.tabParameter.Padding = New System.Drawing.Point(40, 3)
        Me.tabParameter.SelectedIndex = 0
        Me.tabParameter.Size = New System.Drawing.Size(1024, 602)
        Me.tabParameter.TabIndex = 529
        '
        'TabPageTIC
        '
        Me.TabPageTIC.BackColor = System.Drawing.Color.Transparent
        Me.TabPageTIC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPageTIC.Controls.Add(Me.txtMaxTempPower)
        Me.TabPageTIC.Controls.Add(Me.grpPIDLoadSave)
        Me.TabPageTIC.Controls.Add(Me.lblTempMaxPowText)
        Me.TabPageTIC.Controls.Add(Me.lblPer03Text)
        Me.TabPageTIC.Controls.Add(Me.tabPIDSetup)
        Me.TabPageTIC.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageTIC.Location = New System.Drawing.Point(4, 44)
        Me.TabPageTIC.Name = "TabPageTIC"
        Me.TabPageTIC.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageTIC.Size = New System.Drawing.Size(1016, 554)
        Me.TabPageTIC.TabIndex = 0
        Me.TabPageTIC.Text = "溫控器參數"
        Me.TabPageTIC.UseVisualStyleBackColor = True
        '
        'txtMaxTempPower
        '
        Me.txtMaxTempPower.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaxTempPower.Location = New System.Drawing.Point(927, 508)
        Me.txtMaxTempPower.Name = "txtMaxTempPower"
        Me.txtMaxTempPower.Size = New System.Drawing.Size(57, 26)
        Me.txtMaxTempPower.TabIndex = 832
        Me.txtMaxTempPower.Text = "8"
        Me.txtMaxTempPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTempMaxPowText
        '
        Me.lblTempMaxPowText.BackColor = System.Drawing.Color.Transparent
        Me.lblTempMaxPowText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTempMaxPowText.ForeColor = System.Drawing.Color.Black
        Me.lblTempMaxPowText.Location = New System.Drawing.Point(730, 504)
        Me.lblTempMaxPowText.Name = "lblTempMaxPowText"
        Me.lblTempMaxPowText.Size = New System.Drawing.Size(191, 35)
        Me.lblTempMaxPowText.TabIndex = 833
        Me.lblTempMaxPowText.Text = "溫度不足增加功率"
        Me.lblTempMaxPowText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPer03Text
        '
        Me.lblPer03Text.BackColor = System.Drawing.Color.Transparent
        Me.lblPer03Text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPer03Text.ForeColor = System.Drawing.Color.Black
        Me.lblPer03Text.Location = New System.Drawing.Point(988, 510)
        Me.lblPer03Text.Name = "lblPer03Text"
        Me.lblPer03Text.Size = New System.Drawing.Size(24, 26)
        Me.lblPer03Text.TabIndex = 545
        Me.lblPer03Text.Text = "%"
        Me.lblPer03Text.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tabPIDSetup
        '
        Me.tabPIDSetup.Controls.Add(Me.tabPage1to3)
        Me.tabPIDSetup.Controls.Add(Me.tabPage4to6)
        Me.tabPIDSetup.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabPIDSetup.ItemSize = New System.Drawing.Size(300, 40)
        Me.tabPIDSetup.Location = New System.Drawing.Point(3, 9)
        Me.tabPIDSetup.Name = "tabPIDSetup"
        Me.tabPIDSetup.SelectedIndex = 0
        Me.tabPIDSetup.Size = New System.Drawing.Size(1009, 449)
        Me.tabPIDSetup.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tabPIDSetup.TabIndex = 544
        '
        'tabPage1to3
        '
        Me.tabPage1to3.BackColor = System.Drawing.SystemColors.Control
        Me.tabPage1to3.Controls.Add(Me.flwPIDPage1)
        Me.tabPage1to3.Location = New System.Drawing.Point(4, 44)
        Me.tabPage1to3.Name = "tabPage1to3"
        Me.tabPage1to3.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage1to3.Size = New System.Drawing.Size(1001, 401)
        Me.tabPage1to3.TabIndex = 0
        Me.tabPage1to3.Text = "Head 1~3"
        '
        'flwPIDPage1
        '
        Me.flwPIDPage1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flwPIDPage1.Location = New System.Drawing.Point(3, 3)
        Me.flwPIDPage1.Name = "flwPIDPage1"
        Me.flwPIDPage1.Size = New System.Drawing.Size(995, 395)
        Me.flwPIDPage1.TabIndex = 0
        '
        'tabPage4to6
        '
        Me.tabPage4to6.BackColor = System.Drawing.SystemColors.Control
        Me.tabPage4to6.Controls.Add(Me.flwPIDPage2)
        Me.tabPage4to6.Location = New System.Drawing.Point(4, 44)
        Me.tabPage4to6.Name = "tabPage4to6"
        Me.tabPage4to6.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage4to6.Size = New System.Drawing.Size(1001, 401)
        Me.tabPage4to6.TabIndex = 1
        Me.tabPage4to6.Text = "Head 4~6"
        '
        'flwPIDPage2
        '
        Me.flwPIDPage2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flwPIDPage2.Location = New System.Drawing.Point(3, 3)
        Me.flwPIDPage2.Name = "flwPIDPage2"
        Me.flwPIDPage2.Size = New System.Drawing.Size(995, 395)
        Me.flwPIDPage2.TabIndex = 1
        '
        'TabPageTCal
        '
        Me.TabPageTCal.BackColor = System.Drawing.SystemColors.Control
        Me.TabPageTCal.Controls.Add(Me.pnlSplitTopBotTemp)
        Me.TabPageTCal.Controls.Add(Me.flwTempCalUser)
        Me.TabPageTCal.Location = New System.Drawing.Point(4, 44)
        Me.TabPageTCal.Name = "TabPageTCal"
        Me.TabPageTCal.Size = New System.Drawing.Size(1016, 554)
        Me.TabPageTCal.TabIndex = 3
        Me.TabPageTCal.Text = "溫度校正"
        '
        'pnlSplitTopBotTemp
        '
        Me.pnlSplitTopBotTemp.Controls.Add(Me.chkSplitTopBotTemp)
        Me.pnlSplitTopBotTemp.Controls.Add(Me.lblTempTrackDescribeText)
        Me.pnlSplitTopBotTemp.Controls.Add(Me.btnTempTrackDisable)
        Me.pnlSplitTopBotTemp.Controls.Add(Me.lblTempTrackTemp)
        Me.pnlSplitTopBotTemp.Location = New System.Drawing.Point(816, 3)
        Me.pnlSplitTopBotTemp.Name = "pnlSplitTopBotTemp"
        Me.pnlSplitTopBotTemp.Size = New System.Drawing.Size(197, 276)
        Me.pnlSplitTopBotTemp.TabIndex = 561
        Me.pnlSplitTopBotTemp.Visible = False
        '
        'chkSplitTopBotTemp
        '
        Me.chkSplitTopBotTemp.AutoSize = True
        Me.chkSplitTopBotTemp.Location = New System.Drawing.Point(4, 229)
        Me.chkSplitTopBotTemp.Name = "chkSplitTopBotTemp"
        Me.chkSplitTopBotTemp.Size = New System.Drawing.Size(187, 22)
        Me.chkSplitTopBotTemp.TabIndex = 564
        Me.chkSplitTopBotTemp.Text = "上下溫度分開控制功能"
        Me.chkSplitTopBotTemp.UseVisualStyleBackColor = True
        '
        'lblTempTrackDescribeText
        '
        Me.lblTempTrackDescribeText.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTempTrackDescribeText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTempTrackDescribeText.Location = New System.Drawing.Point(4, 115)
        Me.lblTempTrackDescribeText.Name = "lblTempTrackDescribeText"
        Me.lblTempTrackDescribeText.Size = New System.Drawing.Size(188, 78)
        Me.lblTempTrackDescribeText.TabIndex = 563
        Me.lblTempTrackDescribeText.Text = "當上下溫度校溫表格不同時, 需停止上下溫差控制功能"
        Me.lblTempTrackDescribeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnTempTrackDisable
        '
        Me.btnTempTrackDisable.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnTempTrackDisable.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTempTrackDisable.Location = New System.Drawing.Point(40, 64)
        Me.btnTempTrackDisable.Name = "btnTempTrackDisable"
        Me.btnTempTrackDisable.Size = New System.Drawing.Size(132, 48)
        Me.btnTempTrackDisable.TabIndex = 562
        Me.btnTempTrackDisable.Text = "OFF"
        Me.btnTempTrackDisable.UseVisualStyleBackColor = False
        '
        'lblTempTrackTemp
        '
        Me.lblTempTrackTemp.BackColor = System.Drawing.Color.Transparent
        Me.lblTempTrackTemp.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTempTrackTemp.Location = New System.Drawing.Point(14, 25)
        Me.lblTempTrackTemp.Name = "lblTempTrackTemp"
        Me.lblTempTrackTemp.Size = New System.Drawing.Size(178, 36)
        Me.lblTempTrackTemp.TabIndex = 561
        Me.lblTempTrackTemp.Text = "上下溫差控制功能"
        Me.lblTempTrackTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'flwTempCalUser
        '
        Me.flwTempCalUser.Location = New System.Drawing.Point(3, 3)
        Me.flwTempCalUser.Name = "flwTempCalUser"
        Me.flwTempCalUser.Size = New System.Drawing.Size(811, 490)
        Me.flwTempCalUser.TabIndex = 533
        '
        'TabPagePCal
        '
        Me.TabPagePCal.BackColor = System.Drawing.SystemColors.Control
        Me.TabPagePCal.Controls.Add(Me.Label13)
        Me.TabPagePCal.Controls.Add(Me.GroupBox3)
        Me.TabPagePCal.Controls.Add(Me.flwPressCalUser)
        Me.TabPagePCal.Location = New System.Drawing.Point(4, 44)
        Me.TabPagePCal.Name = "TabPagePCal"
        Me.TabPagePCal.Size = New System.Drawing.Size(1016, 554)
        Me.TabPagePCal.TabIndex = 4
        Me.TabPagePCal.Text = "壓力校正"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(3, 254)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(92, 50)
        Me.Label13.TabIndex = 853
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.btnSite3Cal)
        Me.GroupBox3.Controls.Add(Me.btnSite2Cal)
        Me.GroupBox3.Controls.Add(Me.btnSite1Cal)
        Me.GroupBox3.Location = New System.Drawing.Point(235, 291)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(168, 197)
        Me.GroupBox3.TabIndex = 852
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "自動校壓"
        Me.GroupBox3.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(21, 157)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 16)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Label14"
        '
        'btnSite3Cal
        '
        Me.btnSite3Cal.Location = New System.Drawing.Point(20, 111)
        Me.btnSite3Cal.Name = "btnSite3Cal"
        Me.btnSite3Cal.Size = New System.Drawing.Size(123, 31)
        Me.btnSite3Cal.TabIndex = 3
        Me.btnSite3Cal.Text = "Site3 cal"
        Me.btnSite3Cal.UseVisualStyleBackColor = True
        '
        'btnSite2Cal
        '
        Me.btnSite2Cal.Location = New System.Drawing.Point(20, 74)
        Me.btnSite2Cal.Name = "btnSite2Cal"
        Me.btnSite2Cal.Size = New System.Drawing.Size(123, 31)
        Me.btnSite2Cal.TabIndex = 2
        Me.btnSite2Cal.Text = "Site2 cal"
        Me.btnSite2Cal.UseVisualStyleBackColor = True
        '
        'btnSite1Cal
        '
        Me.btnSite1Cal.Location = New System.Drawing.Point(20, 37)
        Me.btnSite1Cal.Name = "btnSite1Cal"
        Me.btnSite1Cal.Size = New System.Drawing.Size(123, 31)
        Me.btnSite1Cal.TabIndex = 1
        Me.btnSite1Cal.Text = "Site1 cal"
        Me.btnSite1Cal.UseVisualStyleBackColor = True
        '
        'flwPressCalUser
        '
        Me.flwPressCalUser.Location = New System.Drawing.Point(3, 3)
        Me.flwPressCalUser.Name = "flwPressCalUser"
        Me.flwPressCalUser.Size = New System.Drawing.Size(1001, 248)
        Me.flwPressCalUser.TabIndex = 849
        '
        'TabPageSystem
        '
        Me.TabPageSystem.BackColor = System.Drawing.Color.Transparent
        Me.TabPageSystem.Controls.Add(Me.pnlParaSet)
        Me.TabPageSystem.ForeColor = System.Drawing.Color.Black
        Me.TabPageSystem.Location = New System.Drawing.Point(4, 44)
        Me.TabPageSystem.Name = "TabPageSystem"
        Me.TabPageSystem.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageSystem.Size = New System.Drawing.Size(1016, 554)
        Me.TabPageSystem.TabIndex = 1
        Me.TabPageSystem.Text = "參數設定"
        Me.TabPageSystem.UseVisualStyleBackColor = True
        '
        'TabPageCIM
        '
        Me.TabPageCIM.BackColor = System.Drawing.SystemColors.Control
        Me.TabPageCIM.Controls.Add(Me.CtlSanAnCIMSetup1)
        Me.TabPageCIM.Location = New System.Drawing.Point(4, 44)
        Me.TabPageCIM.Name = "TabPageCIM"
        Me.TabPageCIM.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageCIM.Size = New System.Drawing.Size(1016, 554)
        Me.TabPageCIM.TabIndex = 5
        Me.TabPageCIM.Text = "CIM Setup"
        '
        'CtlSanAnCIMSetup1
        '
        Me.CtlSanAnCIMSetup1.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.CtlSanAnCIMSetup1.Location = New System.Drawing.Point(0, 4)
        Me.CtlSanAnCIMSetup1.Name = "CtlSanAnCIMSetup1"
        Me.CtlSanAnCIMSetup1.Size = New System.Drawing.Size(1013, 542)
        Me.CtlSanAnCIMSetup1.TabIndex = 0
        '
        'TabPageCello
        '
        Me.TabPageCello.BackColor = System.Drawing.Color.Transparent
        Me.TabPageCello.Controls.Add(Me.tabSystem)
        Me.TabPageCello.Location = New System.Drawing.Point(4, 44)
        Me.TabPageCello.Name = "TabPageCello"
        Me.TabPageCello.Size = New System.Drawing.Size(1016, 554)
        Me.TabPageCello.TabIndex = 2
        Me.TabPageCello.Text = "系統設定"
        Me.TabPageCello.UseVisualStyleBackColor = True
        '
        'tabSystem
        '
        Me.tabSystem.Controls.Add(Me.tabpageTempCal)
        Me.tabSystem.Controls.Add(Me.tabpageVacuum)
        Me.tabSystem.Controls.Add(Me.tabpagePressCal)
        Me.tabSystem.Controls.Add(Me.tabpagePressControl)
        Me.tabSystem.Controls.Add(Me.tabPageIniEdit)
        Me.tabSystem.Controls.Add(Me.TabPageTempCalTool)
        Me.tabSystem.Controls.Add(Me.tabpageCycleRun)
        Me.tabSystem.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabSystem.HotTrack = True
        Me.tabSystem.ItemSize = New System.Drawing.Size(124, 40)
        Me.tabSystem.Location = New System.Drawing.Point(1, 1)
        Me.tabSystem.Margin = New System.Windows.Forms.Padding(0)
        Me.tabSystem.Name = "tabSystem"
        Me.tabSystem.Padding = New System.Drawing.Point(20, 3)
        Me.tabSystem.SelectedIndex = 0
        Me.tabSystem.Size = New System.Drawing.Size(1010, 542)
        Me.tabSystem.TabIndex = 537
        '
        'tabpageTempCal
        '
        Me.tabpageTempCal.BackColor = System.Drawing.Color.Transparent
        Me.tabpageTempCal.Controls.Add(Me.pnlHeaterSetup)
        Me.tabpageTempCal.Controls.Add(Me.flwTempCal)
        Me.tabpageTempCal.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabpageTempCal.Location = New System.Drawing.Point(4, 44)
        Me.tabpageTempCal.Name = "tabpageTempCal"
        Me.tabpageTempCal.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageTempCal.Size = New System.Drawing.Size(1002, 494)
        Me.tabpageTempCal.TabIndex = 0
        Me.tabpageTempCal.Text = "溫度校正"
        Me.tabpageTempCal.UseVisualStyleBackColor = True
        '
        'pnlHeaterSetup
        '
        Me.pnlHeaterSetup.Controls.Add(Me.chkSplitTopBotTempEnable)
        Me.pnlHeaterSetup.Controls.Add(Me.Label2)
        Me.pnlHeaterSetup.Controls.Add(Me.txtTempRiseComp)
        Me.pnlHeaterSetup.Controls.Add(Me.lblTempRiseCompText)
        Me.pnlHeaterSetup.Controls.Add(Me.lblHeaterCountText)
        Me.pnlHeaterSetup.Controls.Add(Me.lblS01Text)
        Me.pnlHeaterSetup.Controls.Add(Me.lblHeaterPowerText)
        Me.pnlHeaterSetup.Controls.Add(Me.txtHeaterAlarmTime)
        Me.pnlHeaterSetup.Controls.Add(Me.lblHeaterVoltageText)
        Me.pnlHeaterSetup.Controls.Add(Me.lblHeaterAlarmTimeText)
        Me.pnlHeaterSetup.Controls.Add(Me.txtHeaterVoltage)
        Me.pnlHeaterSetup.Controls.Add(Me.lblFullCurrentText)
        Me.pnlHeaterSetup.Controls.Add(Me.txtHeaterPower)
        Me.pnlHeaterSetup.Controls.Add(Me.lblA02Text)
        Me.pnlHeaterSetup.Controls.Add(Me.txtHeaterCount)
        Me.pnlHeaterSetup.Controls.Add(Me.lblFullCurrent)
        Me.pnlHeaterSetup.Controls.Add(Me.lblW01Text)
        Me.pnlHeaterSetup.Controls.Add(Me.lblHeaterCurrentText)
        Me.pnlHeaterSetup.Controls.Add(Me.lblV02Text)
        Me.pnlHeaterSetup.Controls.Add(Me.lblA03Text)
        Me.pnlHeaterSetup.Controls.Add(Me.lblHeaterMonitorPowerText)
        Me.pnlHeaterSetup.Controls.Add(Me.lblHeaterCurrent)
        Me.pnlHeaterSetup.Controls.Add(Me.txtHeaterMonitorPower)
        Me.pnlHeaterSetup.Controls.Add(Me.lblPer01Text)
        Me.pnlHeaterSetup.Controls.Add(Me.lblPer02Text)
        Me.pnlHeaterSetup.Controls.Add(Me.txtHeaterCurrentRate)
        Me.pnlHeaterSetup.Controls.Add(Me.lblHeaterCurrentRateText)
        Me.pnlHeaterSetup.Location = New System.Drawing.Point(817, 6)
        Me.pnlHeaterSetup.Name = "pnlHeaterSetup"
        Me.pnlHeaterSetup.Size = New System.Drawing.Size(192, 487)
        Me.pnlHeaterSetup.TabIndex = 832
        '
        'chkSplitTopBotTempEnable
        '
        Me.chkSplitTopBotTempEnable.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSplitTopBotTempEnable.Location = New System.Drawing.Point(18, 458)
        Me.chkSplitTopBotTempEnable.Name = "chkSplitTopBotTempEnable"
        Me.chkSplitTopBotTempEnable.Size = New System.Drawing.Size(165, 26)
        Me.chkSplitTopBotTempEnable.TabIndex = 835
        Me.chkSplitTopBotTempEnable.Text = "使用上下分區校溫"
        Me.chkSplitTopBotTempEnable.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(111, 336)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 26)
        Me.Label2.TabIndex = 834
        Me.Label2.Text = "%"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Visible = False
        '
        'txtTempRiseComp
        '
        Me.txtTempRiseComp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTempRiseComp.Location = New System.Drawing.Point(53, 336)
        Me.txtTempRiseComp.Name = "txtTempRiseComp"
        Me.txtTempRiseComp.Size = New System.Drawing.Size(57, 26)
        Me.txtTempRiseComp.TabIndex = 832
        Me.txtTempRiseComp.Text = "80"
        Me.txtTempRiseComp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTempRiseComp.Visible = False
        '
        'lblTempRiseCompText
        '
        Me.lblTempRiseCompText.BackColor = System.Drawing.Color.Transparent
        Me.lblTempRiseCompText.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblTempRiseCompText.ForeColor = System.Drawing.Color.Black
        Me.lblTempRiseCompText.Location = New System.Drawing.Point(4, 307)
        Me.lblTempRiseCompText.Name = "lblTempRiseCompText"
        Me.lblTempRiseCompText.Size = New System.Drawing.Size(95, 26)
        Me.lblTempRiseCompText.TabIndex = 833
        Me.lblTempRiseCompText.Text = "升溫速率調整:"
        Me.lblTempRiseCompText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTempRiseCompText.Visible = False
        '
        'lblHeaterCountText
        '
        Me.lblHeaterCountText.BackColor = System.Drawing.Color.Transparent
        Me.lblHeaterCountText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaterCountText.ForeColor = System.Drawing.Color.Black
        Me.lblHeaterCountText.Location = New System.Drawing.Point(3, 5)
        Me.lblHeaterCountText.Name = "lblHeaterCountText"
        Me.lblHeaterCountText.Size = New System.Drawing.Size(95, 26)
        Me.lblHeaterCountText.TabIndex = 536
        Me.lblHeaterCountText.Text = "加熱器數量:"
        Me.lblHeaterCountText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblS01Text
        '
        Me.lblS01Text.BackColor = System.Drawing.Color.Transparent
        Me.lblS01Text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblS01Text.ForeColor = System.Drawing.Color.Black
        Me.lblS01Text.Location = New System.Drawing.Point(159, 220)
        Me.lblS01Text.Name = "lblS01Text"
        Me.lblS01Text.Size = New System.Drawing.Size(24, 26)
        Me.lblS01Text.TabIndex = 831
        Me.lblS01Text.Text = "s"
        Me.lblS01Text.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHeaterPowerText
        '
        Me.lblHeaterPowerText.BackColor = System.Drawing.Color.Transparent
        Me.lblHeaterPowerText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaterPowerText.ForeColor = System.Drawing.Color.Black
        Me.lblHeaterPowerText.Location = New System.Drawing.Point(3, 37)
        Me.lblHeaterPowerText.Name = "lblHeaterPowerText"
        Me.lblHeaterPowerText.Size = New System.Drawing.Size(95, 26)
        Me.lblHeaterPowerText.TabIndex = 535
        Me.lblHeaterPowerText.Text = "加熱器功率:"
        Me.lblHeaterPowerText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtHeaterAlarmTime
        '
        Me.txtHeaterAlarmTime.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHeaterAlarmTime.Location = New System.Drawing.Point(101, 220)
        Me.txtHeaterAlarmTime.Name = "txtHeaterAlarmTime"
        Me.txtHeaterAlarmTime.Size = New System.Drawing.Size(57, 26)
        Me.txtHeaterAlarmTime.TabIndex = 829
        Me.txtHeaterAlarmTime.Text = "30"
        Me.txtHeaterAlarmTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblHeaterVoltageText
        '
        Me.lblHeaterVoltageText.BackColor = System.Drawing.Color.Transparent
        Me.lblHeaterVoltageText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaterVoltageText.ForeColor = System.Drawing.Color.Black
        Me.lblHeaterVoltageText.Location = New System.Drawing.Point(3, 67)
        Me.lblHeaterVoltageText.Name = "lblHeaterVoltageText"
        Me.lblHeaterVoltageText.Size = New System.Drawing.Size(95, 26)
        Me.lblHeaterVoltageText.TabIndex = 537
        Me.lblHeaterVoltageText.Text = "加熱器電壓:"
        Me.lblHeaterVoltageText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHeaterAlarmTimeText
        '
        Me.lblHeaterAlarmTimeText.BackColor = System.Drawing.Color.Transparent
        Me.lblHeaterAlarmTimeText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaterAlarmTimeText.ForeColor = System.Drawing.Color.Black
        Me.lblHeaterAlarmTimeText.Location = New System.Drawing.Point(3, 220)
        Me.lblHeaterAlarmTimeText.Name = "lblHeaterAlarmTimeText"
        Me.lblHeaterAlarmTimeText.Size = New System.Drawing.Size(95, 35)
        Me.lblHeaterAlarmTimeText.TabIndex = 830
        Me.lblHeaterAlarmTimeText.Text = "電流警報時間:"
        Me.lblHeaterAlarmTimeText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtHeaterVoltage
        '
        Me.txtHeaterVoltage.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHeaterVoltage.Location = New System.Drawing.Point(101, 67)
        Me.txtHeaterVoltage.Name = "txtHeaterVoltage"
        Me.txtHeaterVoltage.Size = New System.Drawing.Size(57, 26)
        Me.txtHeaterVoltage.TabIndex = 534
        Me.txtHeaterVoltage.Text = "220"
        Me.txtHeaterVoltage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFullCurrentText
        '
        Me.lblFullCurrentText.BackColor = System.Drawing.Color.Transparent
        Me.lblFullCurrentText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullCurrentText.ForeColor = System.Drawing.Color.Black
        Me.lblFullCurrentText.Location = New System.Drawing.Point(3, 130)
        Me.lblFullCurrentText.Name = "lblFullCurrentText"
        Me.lblFullCurrentText.Size = New System.Drawing.Size(95, 26)
        Me.lblFullCurrentText.TabIndex = 828
        Me.lblFullCurrentText.Text = "額定電流:"
        Me.lblFullCurrentText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtHeaterPower
        '
        Me.txtHeaterPower.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHeaterPower.Location = New System.Drawing.Point(101, 37)
        Me.txtHeaterPower.Name = "txtHeaterPower"
        Me.txtHeaterPower.Size = New System.Drawing.Size(57, 26)
        Me.txtHeaterPower.TabIndex = 532
        Me.txtHeaterPower.Text = "750"
        Me.txtHeaterPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblA02Text
        '
        Me.lblA02Text.BackColor = System.Drawing.Color.Transparent
        Me.lblA02Text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblA02Text.ForeColor = System.Drawing.Color.Black
        Me.lblA02Text.Location = New System.Drawing.Point(159, 130)
        Me.lblA02Text.Name = "lblA02Text"
        Me.lblA02Text.Size = New System.Drawing.Size(24, 26)
        Me.lblA02Text.TabIndex = 827
        Me.lblA02Text.Text = "A"
        Me.lblA02Text.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtHeaterCount
        '
        Me.txtHeaterCount.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHeaterCount.Location = New System.Drawing.Point(101, 5)
        Me.txtHeaterCount.Name = "txtHeaterCount"
        Me.txtHeaterCount.Size = New System.Drawing.Size(42, 26)
        Me.txtHeaterCount.TabIndex = 533
        Me.txtHeaterCount.Text = "4"
        Me.txtHeaterCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFullCurrent
        '
        Me.lblFullCurrent.BackColor = System.Drawing.Color.Black
        Me.lblFullCurrent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFullCurrent.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullCurrent.ForeColor = System.Drawing.Color.Lime
        Me.lblFullCurrent.Location = New System.Drawing.Point(101, 129)
        Me.lblFullCurrent.Name = "lblFullCurrent"
        Me.lblFullCurrent.Size = New System.Drawing.Size(58, 26)
        Me.lblFullCurrent.TabIndex = 826
        Me.lblFullCurrent.Text = "13"
        Me.lblFullCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblW01Text
        '
        Me.lblW01Text.BackColor = System.Drawing.Color.Transparent
        Me.lblW01Text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblW01Text.ForeColor = System.Drawing.Color.Black
        Me.lblW01Text.Location = New System.Drawing.Point(159, 38)
        Me.lblW01Text.Name = "lblW01Text"
        Me.lblW01Text.Size = New System.Drawing.Size(24, 26)
        Me.lblW01Text.TabIndex = 538
        Me.lblW01Text.Text = "W"
        Me.lblW01Text.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHeaterCurrentText
        '
        Me.lblHeaterCurrentText.BackColor = System.Drawing.Color.Transparent
        Me.lblHeaterCurrentText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaterCurrentText.ForeColor = System.Drawing.Color.Black
        Me.lblHeaterCurrentText.Location = New System.Drawing.Point(3, 192)
        Me.lblHeaterCurrentText.Name = "lblHeaterCurrentText"
        Me.lblHeaterCurrentText.Size = New System.Drawing.Size(95, 26)
        Me.lblHeaterCurrentText.TabIndex = 825
        Me.lblHeaterCurrentText.Text = "監測電流:"
        Me.lblHeaterCurrentText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblV02Text
        '
        Me.lblV02Text.BackColor = System.Drawing.Color.Transparent
        Me.lblV02Text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblV02Text.ForeColor = System.Drawing.Color.Black
        Me.lblV02Text.Location = New System.Drawing.Point(159, 67)
        Me.lblV02Text.Name = "lblV02Text"
        Me.lblV02Text.Size = New System.Drawing.Size(24, 26)
        Me.lblV02Text.TabIndex = 539
        Me.lblV02Text.Text = "V"
        Me.lblV02Text.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblA03Text
        '
        Me.lblA03Text.BackColor = System.Drawing.Color.Transparent
        Me.lblA03Text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblA03Text.ForeColor = System.Drawing.Color.Black
        Me.lblA03Text.Location = New System.Drawing.Point(159, 192)
        Me.lblA03Text.Name = "lblA03Text"
        Me.lblA03Text.Size = New System.Drawing.Size(24, 26)
        Me.lblA03Text.TabIndex = 824
        Me.lblA03Text.Text = "A"
        Me.lblA03Text.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHeaterMonitorPowerText
        '
        Me.lblHeaterMonitorPowerText.BackColor = System.Drawing.Color.Transparent
        Me.lblHeaterMonitorPowerText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaterMonitorPowerText.ForeColor = System.Drawing.Color.Black
        Me.lblHeaterMonitorPowerText.Location = New System.Drawing.Point(3, 99)
        Me.lblHeaterMonitorPowerText.Name = "lblHeaterMonitorPowerText"
        Me.lblHeaterMonitorPowerText.Size = New System.Drawing.Size(95, 26)
        Me.lblHeaterMonitorPowerText.TabIndex = 541
        Me.lblHeaterMonitorPowerText.Text = "監測功率:"
        Me.lblHeaterMonitorPowerText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHeaterCurrent
        '
        Me.lblHeaterCurrent.BackColor = System.Drawing.Color.Black
        Me.lblHeaterCurrent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHeaterCurrent.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaterCurrent.ForeColor = System.Drawing.Color.Lime
        Me.lblHeaterCurrent.Location = New System.Drawing.Point(101, 191)
        Me.lblHeaterCurrent.Name = "lblHeaterCurrent"
        Me.lblHeaterCurrent.Size = New System.Drawing.Size(58, 26)
        Me.lblHeaterCurrent.TabIndex = 823
        Me.lblHeaterCurrent.Text = "10"
        Me.lblHeaterCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtHeaterMonitorPower
        '
        Me.txtHeaterMonitorPower.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHeaterMonitorPower.Location = New System.Drawing.Point(101, 99)
        Me.txtHeaterMonitorPower.Name = "txtHeaterMonitorPower"
        Me.txtHeaterMonitorPower.Size = New System.Drawing.Size(57, 26)
        Me.txtHeaterMonitorPower.TabIndex = 540
        Me.txtHeaterMonitorPower.Text = "60"
        Me.txtHeaterMonitorPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPer01Text
        '
        Me.lblPer01Text.BackColor = System.Drawing.Color.Transparent
        Me.lblPer01Text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPer01Text.ForeColor = System.Drawing.Color.Black
        Me.lblPer01Text.Location = New System.Drawing.Point(159, 158)
        Me.lblPer01Text.Name = "lblPer01Text"
        Me.lblPer01Text.Size = New System.Drawing.Size(24, 26)
        Me.lblPer01Text.TabIndex = 545
        Me.lblPer01Text.Text = "%"
        Me.lblPer01Text.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPer02Text
        '
        Me.lblPer02Text.BackColor = System.Drawing.Color.Transparent
        Me.lblPer02Text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPer02Text.ForeColor = System.Drawing.Color.Black
        Me.lblPer02Text.Location = New System.Drawing.Point(159, 99)
        Me.lblPer02Text.Name = "lblPer02Text"
        Me.lblPer02Text.Size = New System.Drawing.Size(24, 26)
        Me.lblPer02Text.TabIndex = 542
        Me.lblPer02Text.Text = "%"
        Me.lblPer02Text.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtHeaterCurrentRate
        '
        Me.txtHeaterCurrentRate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHeaterCurrentRate.Location = New System.Drawing.Point(101, 158)
        Me.txtHeaterCurrentRate.Name = "txtHeaterCurrentRate"
        Me.txtHeaterCurrentRate.Size = New System.Drawing.Size(57, 26)
        Me.txtHeaterCurrentRate.TabIndex = 543
        Me.txtHeaterCurrentRate.Text = "80"
        Me.txtHeaterCurrentRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblHeaterCurrentRateText
        '
        Me.lblHeaterCurrentRateText.BackColor = System.Drawing.Color.Transparent
        Me.lblHeaterCurrentRateText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaterCurrentRateText.ForeColor = System.Drawing.Color.Black
        Me.lblHeaterCurrentRateText.Location = New System.Drawing.Point(3, 158)
        Me.lblHeaterCurrentRateText.Name = "lblHeaterCurrentRateText"
        Me.lblHeaterCurrentRateText.Size = New System.Drawing.Size(95, 26)
        Me.lblHeaterCurrentRateText.TabIndex = 544
        Me.lblHeaterCurrentRateText.Text = "監測電流比:"
        Me.lblHeaterCurrentRateText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'flwTempCal
        '
        Me.flwTempCal.Location = New System.Drawing.Point(3, 6)
        Me.flwTempCal.Name = "flwTempCal"
        Me.flwTempCal.Size = New System.Drawing.Size(649, 392)
        Me.flwTempCal.TabIndex = 531
        '
        'tabpageVacuum
        '
        Me.tabpageVacuum.BackColor = System.Drawing.Color.Transparent
        Me.tabpageVacuum.Controls.Add(Me.grpFlowMeter)
        Me.tabpageVacuum.Controls.Add(Me.GroupBox1)
        Me.tabpageVacuum.Controls.Add(Me.grpPumpType)
        Me.tabpageVacuum.Controls.Add(Me.flwFlowSetup)
        Me.tabpageVacuum.Controls.Add(Me.grpVacuumSetup)
        Me.tabpageVacuum.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabpageVacuum.Location = New System.Drawing.Point(4, 44)
        Me.tabpageVacuum.Name = "tabpageVacuum"
        Me.tabpageVacuum.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageVacuum.Size = New System.Drawing.Size(1002, 494)
        Me.tabpageVacuum.TabIndex = 1
        Me.tabpageVacuum.Text = "真空設定"
        Me.tabpageVacuum.UseVisualStyleBackColor = True
        '
        'grpFlowMeter
        '
        Me.grpFlowMeter.Controls.Add(Me.lblDPWaterFlowMaxText)
        Me.grpFlowMeter.Controls.Add(Me.txtDPWaterFlowMax)
        Me.grpFlowMeter.Controls.Add(Me.lblDPWaterFlowHzText)
        Me.grpFlowMeter.Controls.Add(Me.txtDPWaterFlowHz)
        Me.grpFlowMeter.Controls.Add(Me.btnFlowMode)
        Me.grpFlowMeter.Controls.Add(Me.lblFlowModeText)
        Me.grpFlowMeter.Controls.Add(Me.lblFlowDescriptionText)
        Me.grpFlowMeter.Controls.Add(Me.lblFlowSamplingTimeText)
        Me.grpFlowMeter.Controls.Add(Me.txtFlowSamplingTime)
        Me.grpFlowMeter.Controls.Add(Me.lblSec11Text)
        Me.grpFlowMeter.ForeColor = System.Drawing.Color.Black
        Me.grpFlowMeter.Location = New System.Drawing.Point(699, 296)
        Me.grpFlowMeter.Name = "grpFlowMeter"
        Me.grpFlowMeter.Size = New System.Drawing.Size(306, 194)
        Me.grpFlowMeter.TabIndex = 594
        Me.grpFlowMeter.TabStop = False
        Me.grpFlowMeter.Text = "水流量開關設定"
        '
        'lblDPWaterFlowMaxText
        '
        Me.lblDPWaterFlowMaxText.BackColor = System.Drawing.Color.Transparent
        Me.lblDPWaterFlowMaxText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDPWaterFlowMaxText.ForeColor = System.Drawing.Color.Black
        Me.lblDPWaterFlowMaxText.Location = New System.Drawing.Point(25, 152)
        Me.lblDPWaterFlowMaxText.Name = "lblDPWaterFlowMaxText"
        Me.lblDPWaterFlowMaxText.Size = New System.Drawing.Size(151, 34)
        Me.lblDPWaterFlowMaxText.TabIndex = 599
        Me.lblDPWaterFlowMaxText.Text = "DP 最大水流量:"
        Me.lblDPWaterFlowMaxText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDPWaterFlowMax
        '
        Me.txtDPWaterFlowMax.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDPWaterFlowMax.Location = New System.Drawing.Point(182, 156)
        Me.txtDPWaterFlowMax.Name = "txtDPWaterFlowMax"
        Me.txtDPWaterFlowMax.Size = New System.Drawing.Size(53, 26)
        Me.txtDPWaterFlowMax.TabIndex = 600
        Me.txtDPWaterFlowMax.Text = "20"
        Me.txtDPWaterFlowMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDPWaterFlowHzText
        '
        Me.lblDPWaterFlowHzText.BackColor = System.Drawing.Color.Transparent
        Me.lblDPWaterFlowHzText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDPWaterFlowHzText.ForeColor = System.Drawing.Color.Black
        Me.lblDPWaterFlowHzText.Location = New System.Drawing.Point(25, 120)
        Me.lblDPWaterFlowHzText.Name = "lblDPWaterFlowHzText"
        Me.lblDPWaterFlowHzText.Size = New System.Drawing.Size(151, 34)
        Me.lblDPWaterFlowHzText.TabIndex = 597
        Me.lblDPWaterFlowHzText.Text = "DP 水流量脈波數:"
        Me.lblDPWaterFlowHzText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDPWaterFlowHz
        '
        Me.txtDPWaterFlowHz.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDPWaterFlowHz.Location = New System.Drawing.Point(182, 124)
        Me.txtDPWaterFlowHz.Name = "txtDPWaterFlowHz"
        Me.txtDPWaterFlowHz.Size = New System.Drawing.Size(53, 26)
        Me.txtDPWaterFlowHz.TabIndex = 598
        Me.txtDPWaterFlowHz.Text = "135"
        Me.txtDPWaterFlowHz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnFlowMode
        '
        Me.btnFlowMode.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFlowMode.ForeColor = System.Drawing.Color.Black
        Me.btnFlowMode.Location = New System.Drawing.Point(157, 26)
        Me.btnFlowMode.Name = "btnFlowMode"
        Me.btnFlowMode.Size = New System.Drawing.Size(78, 31)
        Me.btnFlowMode.TabIndex = 587
        Me.btnFlowMode.Text = "脈波式"
        '
        'lblFlowModeText
        '
        Me.lblFlowModeText.BackColor = System.Drawing.Color.Transparent
        Me.lblFlowModeText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFlowModeText.ForeColor = System.Drawing.Color.Black
        Me.lblFlowModeText.Location = New System.Drawing.Point(0, 25)
        Me.lblFlowModeText.Name = "lblFlowModeText"
        Me.lblFlowModeText.Size = New System.Drawing.Size(151, 34)
        Me.lblFlowModeText.TabIndex = 543
        Me.lblFlowModeText.Text = "流量開關型式:"
        Me.lblFlowModeText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFlowDescriptionText
        '
        Me.lblFlowDescriptionText.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFlowDescriptionText.ForeColor = System.Drawing.Color.Black
        Me.lblFlowDescriptionText.Location = New System.Drawing.Point(18, 93)
        Me.lblFlowDescriptionText.Name = "lblFlowDescriptionText"
        Me.lblFlowDescriptionText.Size = New System.Drawing.Size(273, 18)
        Me.lblFlowDescriptionText.TabIndex = 542
        Me.lblFlowDescriptionText.Text = "流量= 每分Pulse 數 / 60 /3"
        '
        'lblFlowSamplingTimeText
        '
        Me.lblFlowSamplingTimeText.BackColor = System.Drawing.Color.Transparent
        Me.lblFlowSamplingTimeText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFlowSamplingTimeText.ForeColor = System.Drawing.Color.Black
        Me.lblFlowSamplingTimeText.Location = New System.Drawing.Point(0, 59)
        Me.lblFlowSamplingTimeText.Name = "lblFlowSamplingTimeText"
        Me.lblFlowSamplingTimeText.Size = New System.Drawing.Size(151, 34)
        Me.lblFlowSamplingTimeText.TabIndex = 540
        Me.lblFlowSamplingTimeText.Text = "取樣時間:"
        Me.lblFlowSamplingTimeText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFlowSamplingTime
        '
        Me.txtFlowSamplingTime.Enabled = False
        Me.txtFlowSamplingTime.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFlowSamplingTime.Location = New System.Drawing.Point(157, 63)
        Me.txtFlowSamplingTime.Name = "txtFlowSamplingTime"
        Me.txtFlowSamplingTime.Size = New System.Drawing.Size(78, 26)
        Me.txtFlowSamplingTime.TabIndex = 541
        Me.txtFlowSamplingTime.Text = "3"
        Me.txtFlowSamplingTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblSec11Text
        '
        Me.lblSec11Text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSec11Text.ForeColor = System.Drawing.Color.Black
        Me.lblSec11Text.Location = New System.Drawing.Point(241, 71)
        Me.lblSec11Text.Name = "lblSec11Text"
        Me.lblSec11Text.Size = New System.Drawing.Size(81, 18)
        Me.lblSec11Text.TabIndex = 538
        Me.lblSec11Text.Text = "sec"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radPSG500)
        Me.GroupBox1.Controls.Add(Me.radPCG550)
        Me.GroupBox1.Controls.Add(Me.radAPG100)
        Me.GroupBox1.Controls.Add(Me.radZSE40)
        Me.GroupBox1.Controls.Add(Me.radAP2004)
        Me.GroupBox1.Controls.Add(Me.radGP275)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(699, 134)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(303, 156)
        Me.GroupBox1.TabIndex = 542
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "真空計型式設定"
        '
        'radPSG500
        '
        Me.radPSG500.AutoSize = True
        Me.radPSG500.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.radPSG500.Location = New System.Drawing.Point(163, 112)
        Me.radPSG500.Name = "radPSG500"
        Me.radPSG500.Size = New System.Drawing.Size(102, 26)
        Me.radPSG500.TabIndex = 535
        Me.radPSG500.Text = "PSG500"
        Me.radPSG500.UseVisualStyleBackColor = True
        '
        'radPCG550
        '
        Me.radPCG550.AutoSize = True
        Me.radPCG550.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.radPCG550.Location = New System.Drawing.Point(26, 112)
        Me.radPCG550.Name = "radPCG550"
        Me.radPCG550.Size = New System.Drawing.Size(103, 26)
        Me.radPCG550.TabIndex = 534
        Me.radPCG550.Text = "PCG550"
        Me.radPCG550.UseVisualStyleBackColor = True
        '
        'radAPG100
        '
        Me.radAPG100.AutoSize = True
        Me.radAPG100.Location = New System.Drawing.Point(163, 28)
        Me.radAPG100.Name = "radAPG100"
        Me.radAPG100.Size = New System.Drawing.Size(102, 26)
        Me.radAPG100.TabIndex = 531
        Me.radAPG100.Text = "APG100"
        Me.radAPG100.UseVisualStyleBackColor = True
        '
        'radZSE40
        '
        Me.radZSE40.AutoSize = True
        Me.radZSE40.Location = New System.Drawing.Point(163, 71)
        Me.radZSE40.Name = "radZSE40"
        Me.radZSE40.Size = New System.Drawing.Size(88, 26)
        Me.radZSE40.TabIndex = 510
        Me.radZSE40.Text = "ZSE40"
        Me.radZSE40.UseVisualStyleBackColor = True
        '
        'radAP2004
        '
        Me.radAP2004.AutoSize = True
        Me.radAP2004.Location = New System.Drawing.Point(26, 71)
        Me.radAP2004.Name = "radAP2004"
        Me.radAP2004.Size = New System.Drawing.Size(98, 26)
        Me.radAP2004.TabIndex = 509
        Me.radAP2004.Text = "AP2004"
        Me.radAP2004.UseVisualStyleBackColor = True
        '
        'radGP275
        '
        Me.radGP275.AutoSize = True
        Me.radGP275.Checked = True
        Me.radGP275.Location = New System.Drawing.Point(26, 28)
        Me.radGP275.Name = "radGP275"
        Me.radGP275.Size = New System.Drawing.Size(89, 26)
        Me.radGP275.TabIndex = 509
        Me.radGP275.TabStop = True
        Me.radGP275.Text = "GP275"
        Me.radGP275.UseVisualStyleBackColor = True
        '
        'grpPumpType
        '
        Me.grpPumpType.Controls.Add(Me.radUlvacLS120)
        Me.grpPumpType.Controls.Add(Me.lblDPTempCalText)
        Me.grpPumpType.Controls.Add(Me.txtDPTempCalSet)
        Me.grpPumpType.Controls.Add(Me.picC02)
        Me.grpPumpType.Controls.Add(Me.radMachinePump)
        Me.grpPumpType.Controls.Add(Me.radDryPump)
        Me.grpPumpType.ForeColor = System.Drawing.Color.Black
        Me.grpPumpType.Location = New System.Drawing.Point(681, 6)
        Me.grpPumpType.Name = "grpPumpType"
        Me.grpPumpType.Size = New System.Drawing.Size(321, 122)
        Me.grpPumpType.TabIndex = 541
        Me.grpPumpType.TabStop = False
        Me.grpPumpType.Text = "幫浦型式設定"
        '
        'radUlvacLS120
        '
        Me.radUlvacLS120.AutoSize = True
        Me.radUlvacLS120.Location = New System.Drawing.Point(26, 55)
        Me.radUlvacLS120.Name = "radUlvacLS120"
        Me.radUlvacLS120.Size = New System.Drawing.Size(136, 26)
        Me.radUlvacLS120.TabIndex = 515
        Me.radUlvacLS120.Text = "Ulvac LS120"
        Me.radUlvacLS120.UseVisualStyleBackColor = True
        '
        'lblDPTempCalText
        '
        Me.lblDPTempCalText.BackColor = System.Drawing.Color.Transparent
        Me.lblDPTempCalText.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDPTempCalText.ForeColor = System.Drawing.Color.Black
        Me.lblDPTempCalText.Location = New System.Drawing.Point(0, 85)
        Me.lblDPTempCalText.Name = "lblDPTempCalText"
        Me.lblDPTempCalText.Size = New System.Drawing.Size(158, 36)
        Me.lblDPTempCalText.TabIndex = 513
        Me.lblDPTempCalText.Text = "DP 溫度 OFFSET"
        Me.lblDPTempCalText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDPTempCalSet
        '
        Me.txtDPTempCalSet.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDPTempCalSet.Location = New System.Drawing.Point(163, 90)
        Me.txtDPTempCalSet.Name = "txtDPTempCalSet"
        Me.txtDPTempCalSet.Size = New System.Drawing.Size(80, 26)
        Me.txtDPTempCalSet.TabIndex = 512
        Me.txtDPTempCalSet.Text = "0"
        Me.txtDPTempCalSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'picC02
        '
        Me.picC02.BackColor = System.Drawing.SystemColors.Control
        Me.picC02.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picC02.Location = New System.Drawing.Point(252, 90)
        Me.picC02.Name = "picC02"
        Me.picC02.Size = New System.Drawing.Size(29, 26)
        Me.picC02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picC02.TabIndex = 514
        Me.picC02.TabStop = False
        '
        'radMachinePump
        '
        Me.radMachinePump.AutoSize = True
        Me.radMachinePump.Checked = True
        Me.radMachinePump.Location = New System.Drawing.Point(163, 26)
        Me.radMachinePump.Name = "radMachinePump"
        Me.radMachinePump.Size = New System.Drawing.Size(148, 26)
        Me.radMachinePump.TabIndex = 511
        Me.radMachinePump.TabStop = True
        Me.radMachinePump.Text = "油式機械幫浦"
        Me.radMachinePump.UseVisualStyleBackColor = True
        '
        'radDryPump
        '
        Me.radDryPump.AutoSize = True
        Me.radDryPump.Location = New System.Drawing.Point(26, 26)
        Me.radDryPump.Name = "radDryPump"
        Me.radDryPump.Size = New System.Drawing.Size(108, 26)
        Me.radDryPump.TabIndex = 510
        Me.radDryPump.Text = "乾式幫浦"
        Me.radDryPump.UseVisualStyleBackColor = True
        '
        'flwFlowSetup
        '
        Me.flwFlowSetup.Location = New System.Drawing.Point(6, 231)
        Me.flwFlowSetup.Name = "flwFlowSetup"
        Me.flwFlowSetup.Size = New System.Drawing.Size(684, 259)
        Me.flwFlowSetup.TabIndex = 536
        '
        'grpVacuumSetup
        '
        Me.grpVacuumSetup.Controls.Add(Me.txtRPOnPressure)
        Me.grpVacuumSetup.Controls.Add(Me.lblRPOnPressureText)
        Me.grpVacuumSetup.Controls.Add(Me.Label6)
        Me.grpVacuumSetup.Controls.Add(Me.txtVentOffDelay)
        Me.grpVacuumSetup.Controls.Add(Me.lblVentOffDelay)
        Me.grpVacuumSetup.Controls.Add(Me.Label4)
        Me.grpVacuumSetup.Controls.Add(Me.btn1ATMSelect)
        Me.grpVacuumSetup.Controls.Add(Me.txtRVONDelay)
        Me.grpVacuumSetup.Controls.Add(Me.lblRVONDelayText)
        Me.grpVacuumSetup.Controls.Add(Me.lbl1ATM)
        Me.grpVacuumSetup.Controls.Add(Me.txt1ATMVac)
        Me.grpVacuumSetup.Controls.Add(Me.txtBasePressureTest)
        Me.grpVacuumSetup.Controls.Add(Me.txtCHVacOffsetVoltage)
        Me.grpVacuumSetup.Controls.Add(Me.lbl1Atm02Text)
        Me.grpVacuumSetup.Controls.Add(Me.lblTorr05Text)
        Me.grpVacuumSetup.Controls.Add(Me.lblTorr02Text)
        Me.grpVacuumSetup.Controls.Add(Me.lblSec10Text)
        Me.grpVacuumSetup.Controls.Add(Me.lblV01Text)
        Me.grpVacuumSetup.Controls.Add(Me.lblZSE40UseText)
        Me.grpVacuumSetup.Controls.Add(Me.lblCHVacOffsetVoltageText)
        Me.grpVacuumSetup.Controls.Add(Me.lblVacuumOriginal)
        Me.grpVacuumSetup.Controls.Add(Me.lblBasePressure)
        Me.grpVacuumSetup.Controls.Add(Me.lblVacuumCaled)
        Me.grpVacuumSetup.Controls.Add(Me.lblVacuumCaledText)
        Me.grpVacuumSetup.ForeColor = System.Drawing.Color.Black
        Me.grpVacuumSetup.Location = New System.Drawing.Point(6, 6)
        Me.grpVacuumSetup.Name = "grpVacuumSetup"
        Me.grpVacuumSetup.Size = New System.Drawing.Size(669, 219)
        Me.grpVacuumSetup.TabIndex = 535
        Me.grpVacuumSetup.TabStop = False
        Me.grpVacuumSetup.Text = "真空計設定"
        '
        'txtRPOnPressure
        '
        Me.txtRPOnPressure.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRPOnPressure.Location = New System.Drawing.Point(166, 110)
        Me.txtRPOnPressure.Name = "txtRPOnPressure"
        Me.txtRPOnPressure.Size = New System.Drawing.Size(78, 26)
        Me.txtRPOnPressure.TabIndex = 543
        Me.txtRPOnPressure.Text = "50"
        Me.txtRPOnPressure.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblRPOnPressureText
        '
        Me.lblRPOnPressureText.BackColor = System.Drawing.Color.Transparent
        Me.lblRPOnPressureText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRPOnPressureText.ForeColor = System.Drawing.Color.Black
        Me.lblRPOnPressureText.Location = New System.Drawing.Point(6, 106)
        Me.lblRPOnPressureText.Name = "lblRPOnPressureText"
        Me.lblRPOnPressureText.Size = New System.Drawing.Size(151, 34)
        Me.lblRPOnPressureText.TabIndex = 544
        Me.lblRPOnPressureText.Text = "RP ON 壓力值:"
        Me.lblRPOnPressureText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(250, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 18)
        Me.Label6.TabIndex = 545
        Me.Label6.Text = "Torr"
        '
        'txtVentOffDelay
        '
        Me.txtVentOffDelay.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVentOffDelay.Location = New System.Drawing.Point(410, 183)
        Me.txtVentOffDelay.Name = "txtVentOffDelay"
        Me.txtVentOffDelay.Size = New System.Drawing.Size(78, 26)
        Me.txtVentOffDelay.TabIndex = 541
        Me.txtVentOffDelay.Text = "20"
        Me.txtVentOffDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblVentOffDelay
        '
        Me.lblVentOffDelay.BackColor = System.Drawing.Color.Transparent
        Me.lblVentOffDelay.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVentOffDelay.ForeColor = System.Drawing.Color.Black
        Me.lblVentOffDelay.Location = New System.Drawing.Point(329, 179)
        Me.lblVentOffDelay.Name = "lblVentOffDelay"
        Me.lblVentOffDelay.Size = New System.Drawing.Size(72, 34)
        Me.lblVentOffDelay.TabIndex = 542
        Me.lblVentOffDelay.Text = "Vent Off 延時:"
        Me.lblVentOffDelay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(494, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 26)
        Me.Label4.TabIndex = 540
        Me.Label4.Text = "Sec"
        Me.Label4.Visible = False
        '
        'btn1ATMSelect
        '
        Me.btn1ATMSelect.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn1ATMSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn1ATMSelect.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1ATMSelect.Location = New System.Drawing.Point(352, 138)
        Me.btn1ATMSelect.Name = "btn1ATMSelect"
        Me.btn1ATMSelect.Size = New System.Drawing.Size(153, 33)
        Me.btn1ATMSelect.TabIndex = 530
        Me.btn1ATMSelect.Text = "1 ATM SENSOR"
        Me.btn1ATMSelect.UseVisualStyleBackColor = False
        '
        'txtRVONDelay
        '
        Me.txtRVONDelay.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRVONDelay.Location = New System.Drawing.Point(163, 187)
        Me.txtRVONDelay.Name = "txtRVONDelay"
        Me.txtRVONDelay.Size = New System.Drawing.Size(78, 26)
        Me.txtRVONDelay.TabIndex = 528
        Me.txtRVONDelay.Text = "20"
        Me.txtRVONDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblRVONDelayText
        '
        Me.lblRVONDelayText.BackColor = System.Drawing.Color.Transparent
        Me.lblRVONDelayText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRVONDelayText.ForeColor = System.Drawing.Color.Black
        Me.lblRVONDelayText.Location = New System.Drawing.Point(3, 183)
        Me.lblRVONDelayText.Name = "lblRVONDelayText"
        Me.lblRVONDelayText.Size = New System.Drawing.Size(151, 34)
        Me.lblRVONDelayText.TabIndex = 529
        Me.lblRVONDelayText.Text = "RV 開啟延時:"
        Me.lblRVONDelayText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl1ATM
        '
        Me.lbl1ATM.BackColor = System.Drawing.Color.Red
        Me.lbl1ATM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl1ATM.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1ATM.ForeColor = System.Drawing.Color.Black
        Me.lbl1ATM.Location = New System.Drawing.Point(294, 143)
        Me.lbl1ATM.Name = "lbl1ATM"
        Me.lbl1ATM.Size = New System.Drawing.Size(41, 25)
        Me.lbl1ATM.TabIndex = 527
        Me.lbl1ATM.Text = "1ATM"
        Me.lbl1ATM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt1ATMVac
        '
        Me.txt1ATMVac.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt1ATMVac.Location = New System.Drawing.Point(165, 142)
        Me.txt1ATMVac.Name = "txt1ATMVac"
        Me.txt1ATMVac.Size = New System.Drawing.Size(78, 26)
        Me.txt1ATMVac.TabIndex = 21
        Me.txt1ATMVac.Text = "760"
        Me.txt1ATMVac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBasePressureTest
        '
        Me.txtBasePressureTest.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBasePressureTest.Location = New System.Drawing.Point(510, 30)
        Me.txtBasePressureTest.Name = "txtBasePressureTest"
        Me.txtBasePressureTest.Size = New System.Drawing.Size(78, 26)
        Me.txtBasePressureTest.TabIndex = 21
        Me.txtBasePressureTest.Text = "0.29"
        Me.txtBasePressureTest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtBasePressureTest.Visible = False
        '
        'txtCHVacOffsetVoltage
        '
        Me.txtCHVacOffsetVoltage.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCHVacOffsetVoltage.Location = New System.Drawing.Point(323, 29)
        Me.txtCHVacOffsetVoltage.Name = "txtCHVacOffsetVoltage"
        Me.txtCHVacOffsetVoltage.Size = New System.Drawing.Size(78, 26)
        Me.txtCHVacOffsetVoltage.TabIndex = 21
        Me.txtCHVacOffsetVoltage.Text = "0"
        Me.txtCHVacOffsetVoltage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtCHVacOffsetVoltage.Visible = False
        '
        'lbl1Atm02Text
        '
        Me.lbl1Atm02Text.BackColor = System.Drawing.Color.Transparent
        Me.lbl1Atm02Text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1Atm02Text.ForeColor = System.Drawing.Color.Black
        Me.lbl1Atm02Text.Location = New System.Drawing.Point(5, 138)
        Me.lbl1Atm02Text.Name = "lbl1Atm02Text"
        Me.lbl1Atm02Text.Size = New System.Drawing.Size(151, 34)
        Me.lbl1Atm02Text.TabIndex = 317
        Me.lbl1Atm02Text.Text = "一大氣壓力值:"
        Me.lbl1Atm02Text.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTorr05Text
        '
        Me.lblTorr05Text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTorr05Text.ForeColor = System.Drawing.Color.Black
        Me.lblTorr05Text.Location = New System.Drawing.Point(249, 147)
        Me.lblTorr05Text.Name = "lblTorr05Text"
        Me.lblTorr05Text.Size = New System.Drawing.Size(41, 18)
        Me.lblTorr05Text.TabIndex = 508
        Me.lblTorr05Text.Text = "Torr"
        '
        'lblTorr02Text
        '
        Me.lblTorr02Text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTorr02Text.ForeColor = System.Drawing.Color.Black
        Me.lblTorr02Text.Location = New System.Drawing.Point(407, 70)
        Me.lblTorr02Text.Name = "lblTorr02Text"
        Me.lblTorr02Text.Size = New System.Drawing.Size(41, 18)
        Me.lblTorr02Text.TabIndex = 508
        Me.lblTorr02Text.Text = "Torr"
        '
        'lblSec10Text
        '
        Me.lblSec10Text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSec10Text.ForeColor = System.Drawing.Color.Black
        Me.lblSec10Text.Location = New System.Drawing.Point(247, 194)
        Me.lblSec10Text.Name = "lblSec10Text"
        Me.lblSec10Text.Size = New System.Drawing.Size(41, 26)
        Me.lblSec10Text.TabIndex = 508
        Me.lblSec10Text.Text = "Sec"
        Me.lblSec10Text.Visible = False
        '
        'lblV01Text
        '
        Me.lblV01Text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblV01Text.ForeColor = System.Drawing.Color.Black
        Me.lblV01Text.Location = New System.Drawing.Point(407, 33)
        Me.lblV01Text.Name = "lblV01Text"
        Me.lblV01Text.Size = New System.Drawing.Size(18, 26)
        Me.lblV01Text.TabIndex = 508
        Me.lblV01Text.Text = "V"
        Me.lblV01Text.Visible = False
        '
        'lblZSE40UseText
        '
        Me.lblZSE40UseText.BackColor = System.Drawing.Color.Transparent
        Me.lblZSE40UseText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZSE40UseText.ForeColor = System.Drawing.Color.Black
        Me.lblZSE40UseText.Location = New System.Drawing.Point(6, 30)
        Me.lblZSE40UseText.Name = "lblZSE40UseText"
        Me.lblZSE40UseText.Size = New System.Drawing.Size(151, 34)
        Me.lblZSE40UseText.TabIndex = 317
        Me.lblZSE40UseText.Text = "真空計(ZSE40專用)"
        Me.lblZSE40UseText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblZSE40UseText.Visible = False
        '
        'lblCHVacOffsetVoltageText
        '
        Me.lblCHVacOffsetVoltageText.BackColor = System.Drawing.Color.Transparent
        Me.lblCHVacOffsetVoltageText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCHVacOffsetVoltageText.ForeColor = System.Drawing.Color.Black
        Me.lblCHVacOffsetVoltageText.Location = New System.Drawing.Point(163, 25)
        Me.lblCHVacOffsetVoltageText.Name = "lblCHVacOffsetVoltageText"
        Me.lblCHVacOffsetVoltageText.Size = New System.Drawing.Size(151, 34)
        Me.lblCHVacOffsetVoltageText.TabIndex = 317
        Me.lblCHVacOffsetVoltageText.Text = "真空計電壓偏移值:"
        Me.lblCHVacOffsetVoltageText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblCHVacOffsetVoltageText.Visible = False
        '
        'lblVacuumOriginal
        '
        Me.lblVacuumOriginal.BackColor = System.Drawing.Color.Black
        Me.lblVacuumOriginal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblVacuumOriginal.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVacuumOriginal.ForeColor = System.Drawing.Color.Lime
        Me.lblVacuumOriginal.Location = New System.Drawing.Point(431, 29)
        Me.lblVacuumOriginal.Name = "lblVacuumOriginal"
        Me.lblVacuumOriginal.Size = New System.Drawing.Size(57, 26)
        Me.lblVacuumOriginal.TabIndex = 523
        Me.lblVacuumOriginal.Text = "0"
        Me.lblVacuumOriginal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblVacuumOriginal.Visible = False
        '
        'lblBasePressure
        '
        Me.lblBasePressure.BackColor = System.Drawing.Color.Black
        Me.lblBasePressure.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBasePressure.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBasePressure.ForeColor = System.Drawing.Color.Lime
        Me.lblBasePressure.Location = New System.Drawing.Point(510, 68)
        Me.lblBasePressure.Name = "lblBasePressure"
        Me.lblBasePressure.Size = New System.Drawing.Size(80, 26)
        Me.lblBasePressure.TabIndex = 523
        Me.lblBasePressure.Text = "0"
        Me.lblBasePressure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblVacuumCaled
        '
        Me.lblVacuumCaled.BackColor = System.Drawing.Color.Black
        Me.lblVacuumCaled.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblVacuumCaled.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVacuumCaled.ForeColor = System.Drawing.Color.Lime
        Me.lblVacuumCaled.Location = New System.Drawing.Point(323, 66)
        Me.lblVacuumCaled.Name = "lblVacuumCaled"
        Me.lblVacuumCaled.Size = New System.Drawing.Size(80, 26)
        Me.lblVacuumCaled.TabIndex = 523
        Me.lblVacuumCaled.Text = "0"
        Me.lblVacuumCaled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblVacuumCaledText
        '
        Me.lblVacuumCaledText.BackColor = System.Drawing.Color.Transparent
        Me.lblVacuumCaledText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVacuumCaledText.ForeColor = System.Drawing.Color.Black
        Me.lblVacuumCaledText.Location = New System.Drawing.Point(160, 68)
        Me.lblVacuumCaledText.Name = "lblVacuumCaledText"
        Me.lblVacuumCaledText.Size = New System.Drawing.Size(154, 24)
        Me.lblVacuumCaledText.TabIndex = 310
        Me.lblVacuumCaledText.Text = "校正值後真空值:"
        Me.lblVacuumCaledText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tabpagePressCal
        '
        Me.tabpagePressCal.BackColor = System.Drawing.Color.Transparent
        Me.tabpagePressCal.Controls.Add(Me.flwPressCal)
        Me.tabpagePressCal.Location = New System.Drawing.Point(4, 44)
        Me.tabpagePressCal.Name = "tabpagePressCal"
        Me.tabpagePressCal.Size = New System.Drawing.Size(1002, 494)
        Me.tabpagePressCal.TabIndex = 2
        Me.tabpagePressCal.Text = "壓力校正"
        Me.tabpagePressCal.UseVisualStyleBackColor = True
        '
        'flwPressCal
        '
        Me.flwPressCal.Location = New System.Drawing.Point(3, 3)
        Me.flwPressCal.Name = "flwPressCal"
        Me.flwPressCal.Size = New System.Drawing.Size(1001, 489)
        Me.flwPressCal.TabIndex = 847
        '
        'tabpagePressControl
        '
        Me.tabpagePressControl.BackColor = System.Drawing.Color.Transparent
        Me.tabpagePressControl.Controls.Add(Me.GroupBox2)
        Me.tabpagePressControl.Controls.Add(Me.btnForceDAOut)
        Me.tabpagePressControl.Controls.Add(Me.pnlPressureAverage)
        Me.tabpagePressControl.Controls.Add(Me.lblNoControlPressText)
        Me.tabpagePressControl.Controls.Add(Me.lblPressAverageText)
        Me.tabpagePressControl.Controls.Add(Me.txtNoControlPress)
        Me.tabpagePressControl.Controls.Add(Me.txtPressAverage)
        Me.tabpagePressControl.Controls.Add(Me.lblKg23Text)
        Me.tabpagePressControl.Controls.Add(Me.lblKg12Text)
        Me.tabpagePressControl.Controls.Add(Me.txtRullerLength)
        Me.tabpagePressControl.Controls.Add(Me.lblDA04Text)
        Me.tabpagePressControl.Controls.Add(Me.lblRullerLengthText)
        Me.tabpagePressControl.Controls.Add(Me.txtHighPDAOut)
        Me.tabpagePressControl.Controls.Add(Me.Label5)
        Me.tabpagePressControl.Controls.Add(Me.lblPositionSet3)
        Me.tabpagePressControl.Controls.Add(Me.lblPositionSet2)
        Me.tabpagePressControl.Controls.Add(Me.lblOutRangAddDAText)
        Me.tabpagePressControl.Controls.Add(Me.txtOutRangAddDA3)
        Me.tabpagePressControl.Controls.Add(Me.txtOutRangAddDA2)
        Me.tabpagePressControl.Controls.Add(Me.txtOutRangAddDA1)
        Me.tabpagePressControl.Controls.Add(Me.lblPositionrReadText)
        Me.tabpagePressControl.Controls.Add(Me.lblPositionSet01Text)
        Me.tabpagePressControl.Controls.Add(Me.txtDistanceSet)
        Me.tabpagePressControl.Controls.Add(Me.lblPositionSet1)
        Me.tabpagePressControl.Controls.Add(Me.lblDistanceSetText)
        Me.tabpagePressControl.Controls.Add(Me.lblmm01Text)
        Me.tabpagePressControl.Controls.Add(Me.lblCurrentPosition3)
        Me.tabpagePressControl.Controls.Add(Me.lblCurrentPosition2)
        Me.tabpagePressControl.Controls.Add(Me.lblCurrentPosition1)
        Me.tabpagePressControl.Controls.Add(Me.btnReload)
        Me.tabpagePressControl.Controls.Add(Me.lblThresholdRatioText)
        Me.tabpagePressControl.Controls.Add(Me.txtkgDARatio3)
        Me.tabpagePressControl.Controls.Add(Me.txtkgDARatio2)
        Me.tabpagePressControl.Controls.Add(Me.lblOverThresholdkgDA3)
        Me.tabpagePressControl.Controls.Add(Me.lblOverThresholdkgDA2)
        Me.tabpagePressControl.Controls.Add(Me.txtPress2nd3)
        Me.tabpagePressControl.Controls.Add(Me.txtPress2nd2)
        Me.tabpagePressControl.Controls.Add(Me.txtPress3rd3)
        Me.tabpagePressControl.Controls.Add(Me.txtPress3rd2)
        Me.tabpagePressControl.Controls.Add(Me.lblKg13Text)
        Me.tabpagePressControl.Controls.Add(Me.lblSubPress3)
        Me.tabpagePressControl.Controls.Add(Me.lblRealPressure3)
        Me.tabpagePressControl.Controls.Add(Me.lblPressureRead3)
        Me.tabpagePressControl.Controls.Add(Me.lblSubPress2)
        Me.tabpagePressControl.Controls.Add(Me.lblRealPressure2)
        Me.tabpagePressControl.Controls.Add(Me.lblPressureRead2)
        Me.tabpagePressControl.Controls.Add(Me.lblITVRealValue3)
        Me.tabpagePressControl.Controls.Add(Me.btnPlateUp3)
        Me.tabpagePressControl.Controls.Add(Me.btnPlateDown3)
        Me.tabpagePressControl.Controls.Add(Me.btnPlateUp2)
        Me.tabpagePressControl.Controls.Add(Me.btnPlateDown2)
        Me.tabpagePressControl.Controls.Add(Me.lblOverThresholdkgDA1)
        Me.tabpagePressControl.Controls.Add(Me.lblSubPress1)
        Me.tabpagePressControl.Controls.Add(Me.lblKg15Text)
        Me.tabpagePressControl.Controls.Add(Me.lblRealPressure1)
        Me.tabpagePressControl.Controls.Add(Me.lblKg14Text)
        Me.tabpagePressControl.Controls.Add(Me.lblDA10Text)
        Me.tabpagePressControl.Controls.Add(Me.lblSubPressText)
        Me.tabpagePressControl.Controls.Add(Me.lblKg20Text)
        Me.tabpagePressControl.Controls.Add(Me.lblRealPressureText1)
        Me.tabpagePressControl.Controls.Add(Me.lblPressureRead1)
        Me.tabpagePressControl.Controls.Add(Me.lbl1stPlateUpProcedureText)
        Me.tabpagePressControl.Controls.Add(Me.lblKg09Text)
        Me.tabpagePressControl.Controls.Add(Me.lblmmCount02Text)
        Me.tabpagePressControl.Controls.Add(Me.lblKgDA02Text)
        Me.tabpagePressControl.Controls.Add(Me.btnShowPicControl)
        Me.tabpagePressControl.Controls.Add(Me.lblDA01Text)
        Me.tabpagePressControl.Controls.Add(Me.txtkgDARatio1)
        Me.tabpagePressControl.Controls.Add(Me.lblDA06Text)
        Me.tabpagePressControl.Controls.Add(Me.lblDA09Text)
        Me.tabpagePressControl.Controls.Add(Me.lblDA11Text)
        Me.tabpagePressControl.Controls.Add(Me.btnHighPDAOut)
        Me.tabpagePressControl.Controls.Add(Me.lblDA07Text)
        Me.tabpagePressControl.Controls.Add(Me.lblkgDARatioText)
        Me.tabpagePressControl.Controls.Add(Me.txtPress1st)
        Me.tabpagePressControl.Controls.Add(Me.txtPress2nd1)
        Me.tabpagePressControl.Controls.Add(Me.txtPress3rd1)
        Me.tabpagePressControl.Controls.Add(Me.txtLowPDAOut)
        Me.tabpagePressControl.Controls.Add(Me.txtPlateUpContactKg)
        Me.tabpagePressControl.Controls.Add(Me.btnLowPDAOut)
        Me.tabpagePressControl.Controls.Add(Me.lblPlateUpContactKgText)
        Me.tabpagePressControl.Controls.Add(Me.lblPress3rdText)
        Me.tabpagePressControl.Controls.Add(Me.lblITVRealValue1Text)
        Me.tabpagePressControl.Controls.Add(Me.lblITVRealValue2Text)
        Me.tabpagePressControl.Controls.Add(Me.lblPress1stText)
        Me.tabpagePressControl.Controls.Add(Me.lblITVRealValue1)
        Me.tabpagePressControl.Controls.Add(Me.lblITVRealValue2)
        Me.tabpagePressControl.Controls.Add(Me.lblPress2ndText)
        Me.tabpagePressControl.Controls.Add(Me.btnPlateUp1)
        Me.tabpagePressControl.Controls.Add(Me.btnPlateDown1)
        Me.tabpagePressControl.Controls.Add(Me.pnl6Plate)
        Me.tabpagePressControl.Controls.Add(Me.Panel1)
        Me.tabpagePressControl.Controls.Add(Me.flwPressPID)
        Me.tabpagePressControl.Location = New System.Drawing.Point(4, 44)
        Me.tabpagePressControl.Name = "tabpagePressControl"
        Me.tabpagePressControl.Size = New System.Drawing.Size(1002, 494)
        Me.tabpagePressControl.TabIndex = 3
        Me.tabpagePressControl.Text = "壓力控制設定"
        Me.tabpagePressControl.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.btnlog)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtdown)
        Me.GroupBox2.Controls.Add(Me.txtup)
        Me.GroupBox2.Controls.Add(Me.txtinterval)
        Me.GroupBox2.Controls.Add(Me.btDn)
        Me.GroupBox2.Controls.Add(Me.btUp)
        Me.GroupBox2.Location = New System.Drawing.Point(529, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(168, 177)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Visible = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(11, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 32)
        Me.Label3.TabIndex = 958
        Me.Label3.Text = "時間間隔"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnlog
        '
        Me.btnlog.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlog.Location = New System.Drawing.Point(16, 75)
        Me.btnlog.Name = "btnlog"
        Me.btnlog.Size = New System.Drawing.Size(56, 37)
        Me.btnlog.TabIndex = 962
        Me.btnlog.Text = "log"
        Me.btnlog.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(113, 131)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(47, 28)
        Me.Button1.TabIndex = 961
        Me.Button1.Text = "stop"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(39, 89)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 32)
        Me.Label9.TabIndex = 960
        Me.Label9.Text = "下"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(39, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 32)
        Me.Label8.TabIndex = 959
        Me.Label8.Text = "上"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtdown
        '
        Me.txtdown.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtdown.Location = New System.Drawing.Point(99, 98)
        Me.txtdown.Name = "txtdown"
        Me.txtdown.Size = New System.Drawing.Size(60, 23)
        Me.txtdown.TabIndex = 957
        Me.txtdown.Text = "1000"
        Me.txtdown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtup
        '
        Me.txtup.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtup.Location = New System.Drawing.Point(99, 64)
        Me.txtup.Name = "txtup"
        Me.txtup.Size = New System.Drawing.Size(60, 23)
        Me.txtup.TabIndex = 956
        Me.txtup.Text = "2000"
        Me.txtup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtinterval
        '
        Me.txtinterval.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtinterval.Location = New System.Drawing.Point(99, 29)
        Me.txtinterval.Name = "txtinterval"
        Me.txtinterval.Size = New System.Drawing.Size(60, 23)
        Me.txtinterval.TabIndex = 955
        Me.txtinterval.Text = "3000"
        Me.txtinterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btDn
        '
        Me.btDn.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btDn.Location = New System.Drawing.Point(54, 130)
        Me.btDn.Name = "btDn"
        Me.btDn.Size = New System.Drawing.Size(49, 29)
        Me.btDn.TabIndex = 954
        Me.btDn.Text = "Down"
        Me.btDn.UseVisualStyleBackColor = True
        '
        'btUp
        '
        Me.btUp.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btUp.Location = New System.Drawing.Point(12, 131)
        Me.btUp.Name = "btUp"
        Me.btUp.Size = New System.Drawing.Size(41, 28)
        Me.btUp.TabIndex = 953
        Me.btUp.Text = "up"
        Me.btUp.UseVisualStyleBackColor = True
        '
        'btnForceDAOut
        '
        Me.btnForceDAOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnForceDAOut.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnForceDAOut.Location = New System.Drawing.Point(713, 352)
        Me.btnForceDAOut.Name = "btnForceDAOut"
        Me.btnForceDAOut.Size = New System.Drawing.Size(128, 31)
        Me.btnForceDAOut.TabIndex = 849
        Me.btnForceDAOut.Text = "比例閥輸出鎖"
        Me.btnForceDAOut.UseVisualStyleBackColor = False
        '
        'pnlPressureAverage
        '
        Me.pnlPressureAverage.Controls.Add(Me.Button3)
        Me.pnlPressureAverage.Controls.Add(Me.lbPeakClearTimes)
        Me.pnlPressureAverage.Controls.Add(Me.rdoPeakClear)
        Me.pnlPressureAverage.Controls.Add(Me.Button2)
        Me.pnlPressureAverage.Controls.Add(Me.rdoPressureAverage)
        Me.pnlPressureAverage.Controls.Add(Me.txtPeakTimes)
        Me.pnlPressureAverage.Controls.Add(Me.lblPeakTimesText)
        Me.pnlPressureAverage.Controls.Add(Me.txtPeakLimit)
        Me.pnlPressureAverage.Controls.Add(Me.lblTimes03Text)
        Me.pnlPressureAverage.Controls.Add(Me.lblTimes02Text)
        Me.pnlPressureAverage.Controls.Add(Me.txtPressureAverageTimes)
        Me.pnlPressureAverage.Controls.Add(Me.chkPressureAdjust)
        Me.pnlPressureAverage.Controls.Add(Me.Label15)
        Me.pnlPressureAverage.Location = New System.Drawing.Point(696, 387)
        Me.pnlPressureAverage.Name = "pnlPressureAverage"
        Me.pnlPressureAverage.Size = New System.Drawing.Size(303, 104)
        Me.pnlPressureAverage.TabIndex = 944
        '
        'lbPeakClearTimes
        '
        Me.lbPeakClearTimes.BackColor = System.Drawing.Color.Black
        Me.lbPeakClearTimes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbPeakClearTimes.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPeakClearTimes.ForeColor = System.Drawing.Color.Lime
        Me.lbPeakClearTimes.Location = New System.Drawing.Point(182, 56)
        Me.lbPeakClearTimes.Name = "lbPeakClearTimes"
        Me.lbPeakClearTimes.Size = New System.Drawing.Size(51, 19)
        Me.lbPeakClearTimes.TabIndex = 948
        Me.lbPeakClearTimes.Text = "0"
        Me.lbPeakClearTimes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rdoPeakClear
        '
        Me.rdoPeakClear.AutoSize = True
        Me.rdoPeakClear.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoPeakClear.Location = New System.Drawing.Point(14, 33)
        Me.rdoPeakClear.Name = "rdoPeakClear"
        Me.rdoPeakClear.Size = New System.Drawing.Size(90, 20)
        Me.rdoPeakClear.TabIndex = 947
        Me.rdoPeakClear.TabStop = True
        Me.rdoPeakClear.Text = "Peak 消除"
        Me.rdoPeakClear.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(204, 75)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(69, 26)
        Me.Button2.TabIndex = 946
        Me.Button2.Text = "clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'rdoPressureAverage
        '
        Me.rdoPressureAverage.AutoSize = True
        Me.rdoPressureAverage.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoPressureAverage.Location = New System.Drawing.Point(14, 4)
        Me.rdoPressureAverage.Name = "rdoPressureAverage"
        Me.rdoPressureAverage.Size = New System.Drawing.Size(110, 20)
        Me.rdoPressureAverage.TabIndex = 945
        Me.rdoPressureAverage.TabStop = True
        Me.rdoPressureAverage.Text = "壓力平均功能"
        Me.rdoPressureAverage.UseVisualStyleBackColor = True
        '
        'txtPeakTimes
        '
        Me.txtPeakTimes.Font = New System.Drawing.Font("新細明體", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtPeakTimes.Location = New System.Drawing.Point(182, 33)
        Me.txtPeakTimes.Name = "txtPeakTimes"
        Me.txtPeakTimes.Size = New System.Drawing.Size(60, 20)
        Me.txtPeakTimes.TabIndex = 943
        Me.txtPeakTimes.Text = "3"
        Me.txtPeakTimes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPeakTimesText
        '
        Me.lblPeakTimesText.BackColor = System.Drawing.Color.Transparent
        Me.lblPeakTimesText.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblPeakTimesText.ForeColor = System.Drawing.Color.Black
        Me.lblPeakTimesText.Location = New System.Drawing.Point(104, 33)
        Me.lblPeakTimesText.Name = "lblPeakTimesText"
        Me.lblPeakTimesText.Size = New System.Drawing.Size(75, 22)
        Me.lblPeakTimesText.TabIndex = 942
        Me.lblPeakTimesText.Text = "Peak 次數:"
        Me.lblPeakTimesText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPeakLimit
        '
        Me.txtPeakLimit.Font = New System.Drawing.Font("新細明體", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtPeakLimit.Location = New System.Drawing.Point(181, 27)
        Me.txtPeakLimit.Name = "txtPeakLimit"
        Me.txtPeakLimit.Size = New System.Drawing.Size(60, 20)
        Me.txtPeakLimit.TabIndex = 941
        Me.txtPeakLimit.Text = "300"
        Me.txtPeakLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPeakLimit.Visible = False
        '
        'lblTimes03Text
        '
        Me.lblTimes03Text.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblTimes03Text.ForeColor = System.Drawing.Color.Black
        Me.lblTimes03Text.Location = New System.Drawing.Point(247, 37)
        Me.lblTimes03Text.Name = "lblTimes03Text"
        Me.lblTimes03Text.Size = New System.Drawing.Size(30, 23)
        Me.lblTimes03Text.TabIndex = 938
        Me.lblTimes03Text.Text = "次"
        '
        'lblTimes02Text
        '
        Me.lblTimes02Text.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblTimes02Text.ForeColor = System.Drawing.Color.Black
        Me.lblTimes02Text.Location = New System.Drawing.Point(247, 13)
        Me.lblTimes02Text.Name = "lblTimes02Text"
        Me.lblTimes02Text.Size = New System.Drawing.Size(36, 19)
        Me.lblTimes02Text.TabIndex = 937
        Me.lblTimes02Text.Text = "次"
        '
        'txtPressureAverageTimes
        '
        Me.txtPressureAverageTimes.Font = New System.Drawing.Font("新細明體", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtPressureAverageTimes.Location = New System.Drawing.Point(181, 4)
        Me.txtPressureAverageTimes.Name = "txtPressureAverageTimes"
        Me.txtPressureAverageTimes.Size = New System.Drawing.Size(60, 20)
        Me.txtPressureAverageTimes.TabIndex = 936
        Me.txtPressureAverageTimes.Text = "10"
        Me.txtPressureAverageTimes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chkPressureAdjust
        '
        Me.chkPressureAdjust.AutoSize = True
        Me.chkPressureAdjust.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.chkPressureAdjust.Location = New System.Drawing.Point(15, 78)
        Me.chkPressureAdjust.Name = "chkPressureAdjust"
        Me.chkPressureAdjust.Size = New System.Drawing.Size(184, 17)
        Me.chkPressureAdjust.TabIndex = 935
        Me.chkPressureAdjust.Text = "壓力修整功能(>均化值移除)"
        Me.chkPressureAdjust.UseVisualStyleBackColor = True
        Me.chkPressureAdjust.Visible = False
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(247, 41)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(36, 19)
        Me.Label15.TabIndex = 944
        Me.Label15.Text = "kg"
        Me.Label15.Visible = False
        '
        'lblNoControlPressText
        '
        Me.lblNoControlPressText.BackColor = System.Drawing.Color.Transparent
        Me.lblNoControlPressText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoControlPressText.ForeColor = System.Drawing.Color.Black
        Me.lblNoControlPressText.Location = New System.Drawing.Point(708, 291)
        Me.lblNoControlPressText.Name = "lblNoControlPressText"
        Me.lblNoControlPressText.Size = New System.Drawing.Size(125, 26)
        Me.lblNoControlPressText.TabIndex = 862
        Me.lblNoControlPressText.Text = "不控壓力範圍:"
        Me.lblNoControlPressText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPressAverageText
        '
        Me.lblPressAverageText.BackColor = System.Drawing.Color.Transparent
        Me.lblPressAverageText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPressAverageText.ForeColor = System.Drawing.Color.Black
        Me.lblPressAverageText.Location = New System.Drawing.Point(708, 323)
        Me.lblPressAverageText.Name = "lblPressAverageText"
        Me.lblPressAverageText.Size = New System.Drawing.Size(125, 26)
        Me.lblPressAverageText.TabIndex = 952
        Me.lblPressAverageText.Text = "壓力均化範圍:"
        Me.lblPressAverageText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNoControlPress
        '
        Me.txtNoControlPress.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoControlPress.Location = New System.Drawing.Point(850, 291)
        Me.txtNoControlPress.Name = "txtNoControlPress"
        Me.txtNoControlPress.Size = New System.Drawing.Size(78, 26)
        Me.txtNoControlPress.TabIndex = 861
        Me.txtNoControlPress.Text = "10"
        Me.txtNoControlPress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPressAverage
        '
        Me.txtPressAverage.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPressAverage.Location = New System.Drawing.Point(850, 321)
        Me.txtPressAverage.Name = "txtPressAverage"
        Me.txtPressAverage.Size = New System.Drawing.Size(76, 26)
        Me.txtPressAverage.TabIndex = 951
        Me.txtPressAverage.Text = "10"
        Me.txtPressAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblKg23Text
        '
        Me.lblKg23Text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKg23Text.ForeColor = System.Drawing.Color.Black
        Me.lblKg23Text.Location = New System.Drawing.Point(939, 297)
        Me.lblKg23Text.Name = "lblKg23Text"
        Me.lblKg23Text.Size = New System.Drawing.Size(45, 26)
        Me.lblKg23Text.TabIndex = 860
        Me.lblKg23Text.Text = "kg"
        '
        'lblKg12Text
        '
        Me.lblKg12Text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKg12Text.ForeColor = System.Drawing.Color.Black
        Me.lblKg12Text.Location = New System.Drawing.Point(941, 329)
        Me.lblKg12Text.Name = "lblKg12Text"
        Me.lblKg12Text.Size = New System.Drawing.Size(45, 26)
        Me.lblKg12Text.TabIndex = 950
        Me.lblKg12Text.Text = "kg"
        '
        'txtRullerLength
        '
        Me.txtRullerLength.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRullerLength.Location = New System.Drawing.Point(446, 16)
        Me.txtRullerLength.Name = "txtRullerLength"
        Me.txtRullerLength.Size = New System.Drawing.Size(80, 26)
        Me.txtRullerLength.TabIndex = 947
        Me.txtRullerLength.Text = "150"
        Me.txtRullerLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDA04Text
        '
        Me.lblDA04Text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDA04Text.ForeColor = System.Drawing.Color.Black
        Me.lblDA04Text.Location = New System.Drawing.Point(937, 359)
        Me.lblDA04Text.Name = "lblDA04Text"
        Me.lblDA04Text.Size = New System.Drawing.Size(45, 26)
        Me.lblDA04Text.TabIndex = 508
        Me.lblDA04Text.Text = "DA"
        '
        'lblRullerLengthText
        '
        Me.lblRullerLengthText.BackColor = System.Drawing.Color.Transparent
        Me.lblRullerLengthText.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRullerLengthText.ForeColor = System.Drawing.Color.Black
        Me.lblRullerLengthText.Location = New System.Drawing.Point(326, 16)
        Me.lblRullerLengthText.Name = "lblRullerLengthText"
        Me.lblRullerLengthText.Size = New System.Drawing.Size(119, 26)
        Me.lblRullerLengthText.TabIndex = 946
        Me.lblRullerLengthText.Text = "電阻尺長度:"
        Me.lblRullerLengthText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtHighPDAOut
        '
        Me.txtHighPDAOut.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHighPDAOut.Location = New System.Drawing.Point(851, 351)
        Me.txtHighPDAOut.Name = "txtHighPDAOut"
        Me.txtHighPDAOut.Size = New System.Drawing.Size(75, 26)
        Me.txtHighPDAOut.TabIndex = 807
        Me.txtHighPDAOut.Text = "100"
        Me.txtHighPDAOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(529, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 20)
        Me.Label5.TabIndex = 945
        Me.Label5.Text = "mm"
        '
        'lblPositionSet3
        '
        Me.lblPositionSet3.BackColor = System.Drawing.Color.Black
        Me.lblPositionSet3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPositionSet3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPositionSet3.ForeColor = System.Drawing.Color.Lime
        Me.lblPositionSet3.Location = New System.Drawing.Point(294, 351)
        Me.lblPositionSet3.Name = "lblPositionSet3"
        Me.lblPositionSet3.Size = New System.Drawing.Size(80, 19)
        Me.lblPositionSet3.TabIndex = 913
        Me.lblPositionSet3.Text = "0"
        Me.lblPositionSet3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPositionSet2
        '
        Me.lblPositionSet2.BackColor = System.Drawing.Color.Black
        Me.lblPositionSet2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPositionSet2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPositionSet2.ForeColor = System.Drawing.Color.Lime
        Me.lblPositionSet2.Location = New System.Drawing.Point(210, 351)
        Me.lblPositionSet2.Name = "lblPositionSet2"
        Me.lblPositionSet2.Size = New System.Drawing.Size(80, 19)
        Me.lblPositionSet2.TabIndex = 912
        Me.lblPositionSet2.Text = "0"
        Me.lblPositionSet2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOutRangAddDAText
        '
        Me.lblOutRangAddDAText.BackColor = System.Drawing.Color.Transparent
        Me.lblOutRangAddDAText.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutRangAddDAText.ForeColor = System.Drawing.Color.Black
        Me.lblOutRangAddDAText.Location = New System.Drawing.Point(0, 296)
        Me.lblOutRangAddDAText.Name = "lblOutRangAddDAText"
        Me.lblOutRangAddDAText.Size = New System.Drawing.Size(125, 32)
        Me.lblOutRangAddDAText.TabIndex = 911
        Me.lblOutRangAddDAText.Text = "控壓時壓速增加常數:"
        Me.lblOutRangAddDAText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblOutRangAddDAText.Visible = False
        '
        'txtOutRangAddDA3
        '
        Me.txtOutRangAddDA3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutRangAddDA3.Location = New System.Drawing.Point(294, 296)
        Me.txtOutRangAddDA3.Name = "txtOutRangAddDA3"
        Me.txtOutRangAddDA3.Size = New System.Drawing.Size(80, 26)
        Me.txtOutRangAddDA3.TabIndex = 2
        Me.txtOutRangAddDA3.Text = "1"
        Me.txtOutRangAddDA3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtOutRangAddDA3.Visible = False
        '
        'txtOutRangAddDA2
        '
        Me.txtOutRangAddDA2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutRangAddDA2.Location = New System.Drawing.Point(210, 296)
        Me.txtOutRangAddDA2.Name = "txtOutRangAddDA2"
        Me.txtOutRangAddDA2.Size = New System.Drawing.Size(80, 26)
        Me.txtOutRangAddDA2.TabIndex = 1
        Me.txtOutRangAddDA2.Text = "1"
        Me.txtOutRangAddDA2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtOutRangAddDA2.Visible = False
        '
        'txtOutRangAddDA1
        '
        Me.txtOutRangAddDA1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutRangAddDA1.Location = New System.Drawing.Point(126, 296)
        Me.txtOutRangAddDA1.Name = "txtOutRangAddDA1"
        Me.txtOutRangAddDA1.Size = New System.Drawing.Size(80, 26)
        Me.txtOutRangAddDA1.TabIndex = 0
        Me.txtOutRangAddDA1.Text = "1"
        Me.txtOutRangAddDA1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtOutRangAddDA1.Visible = False
        '
        'lblPositionrReadText
        '
        Me.lblPositionrReadText.BackColor = System.Drawing.Color.Transparent
        Me.lblPositionrReadText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPositionrReadText.ForeColor = System.Drawing.Color.Black
        Me.lblPositionrReadText.Location = New System.Drawing.Point(53, 330)
        Me.lblPositionrReadText.Name = "lblPositionrReadText"
        Me.lblPositionrReadText.Size = New System.Drawing.Size(67, 19)
        Me.lblPositionrReadText.TabIndex = 869
        Me.lblPositionrReadText.Text = "現在值"
        Me.lblPositionrReadText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPositionSet01Text
        '
        Me.lblPositionSet01Text.BackColor = System.Drawing.Color.Transparent
        Me.lblPositionSet01Text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPositionSet01Text.ForeColor = System.Drawing.Color.Black
        Me.lblPositionSet01Text.Location = New System.Drawing.Point(53, 351)
        Me.lblPositionSet01Text.Name = "lblPositionSet01Text"
        Me.lblPositionSet01Text.Size = New System.Drawing.Size(67, 19)
        Me.lblPositionSet01Text.TabIndex = 870
        Me.lblPositionSet01Text.Text = "設定值"
        Me.lblPositionSet01Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDistanceSet
        '
        Me.txtDistanceSet.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDistanceSet.Location = New System.Drawing.Point(126, 264)
        Me.txtDistanceSet.Name = "txtDistanceSet"
        Me.txtDistanceSet.Size = New System.Drawing.Size(80, 26)
        Me.txtDistanceSet.TabIndex = 868
        Me.txtDistanceSet.Text = "100"
        Me.txtDistanceSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPositionSet1
        '
        Me.lblPositionSet1.BackColor = System.Drawing.Color.Black
        Me.lblPositionSet1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPositionSet1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPositionSet1.ForeColor = System.Drawing.Color.Lime
        Me.lblPositionSet1.Location = New System.Drawing.Point(126, 351)
        Me.lblPositionSet1.Name = "lblPositionSet1"
        Me.lblPositionSet1.Size = New System.Drawing.Size(80, 19)
        Me.lblPositionSet1.TabIndex = 867
        Me.lblPositionSet1.Text = "0"
        Me.lblPositionSet1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDistanceSetText
        '
        Me.lblDistanceSetText.BackColor = System.Drawing.Color.Transparent
        Me.lblDistanceSetText.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDistanceSetText.ForeColor = System.Drawing.Color.Black
        Me.lblDistanceSetText.Location = New System.Drawing.Point(6, 264)
        Me.lblDistanceSetText.Name = "lblDistanceSetText"
        Me.lblDistanceSetText.Size = New System.Drawing.Size(119, 26)
        Me.lblDistanceSetText.TabIndex = 866
        Me.lblDistanceSetText.Text = "油壓缸行程:"
        Me.lblDistanceSetText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblmm01Text
        '
        Me.lblmm01Text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmm01Text.ForeColor = System.Drawing.Color.Black
        Me.lblmm01Text.Location = New System.Drawing.Point(209, 270)
        Me.lblmm01Text.Name = "lblmm01Text"
        Me.lblmm01Text.Size = New System.Drawing.Size(45, 20)
        Me.lblmm01Text.TabIndex = 864
        Me.lblmm01Text.Text = "mm"
        '
        'lblCurrentPosition3
        '
        Me.lblCurrentPosition3.BackColor = System.Drawing.Color.Black
        Me.lblCurrentPosition3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCurrentPosition3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentPosition3.ForeColor = System.Drawing.Color.Lime
        Me.lblCurrentPosition3.Location = New System.Drawing.Point(294, 330)
        Me.lblCurrentPosition3.Name = "lblCurrentPosition3"
        Me.lblCurrentPosition3.Size = New System.Drawing.Size(80, 19)
        Me.lblCurrentPosition3.TabIndex = 865
        Me.lblCurrentPosition3.Text = "0"
        Me.lblCurrentPosition3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCurrentPosition2
        '
        Me.lblCurrentPosition2.BackColor = System.Drawing.Color.Black
        Me.lblCurrentPosition2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCurrentPosition2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentPosition2.ForeColor = System.Drawing.Color.Lime
        Me.lblCurrentPosition2.Location = New System.Drawing.Point(210, 330)
        Me.lblCurrentPosition2.Name = "lblCurrentPosition2"
        Me.lblCurrentPosition2.Size = New System.Drawing.Size(80, 19)
        Me.lblCurrentPosition2.TabIndex = 865
        Me.lblCurrentPosition2.Text = "0"
        Me.lblCurrentPosition2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCurrentPosition1
        '
        Me.lblCurrentPosition1.BackColor = System.Drawing.Color.Black
        Me.lblCurrentPosition1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCurrentPosition1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentPosition1.ForeColor = System.Drawing.Color.Lime
        Me.lblCurrentPosition1.Location = New System.Drawing.Point(126, 330)
        Me.lblCurrentPosition1.Name = "lblCurrentPosition1"
        Me.lblCurrentPosition1.Size = New System.Drawing.Size(80, 19)
        Me.lblCurrentPosition1.TabIndex = 865
        Me.lblCurrentPosition1.Text = "0"
        Me.lblCurrentPosition1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnReload
        '
        Me.btnReload.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnReload.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReload.Location = New System.Drawing.Point(609, 423)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(91, 39)
        Me.btnReload.TabIndex = 863
        Me.btnReload.Text = "重載參數"
        Me.btnReload.UseVisualStyleBackColor = False
        Me.btnReload.Visible = False
        '
        'lblThresholdRatioText
        '
        Me.lblThresholdRatioText.BackColor = System.Drawing.Color.Transparent
        Me.lblThresholdRatioText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThresholdRatioText.ForeColor = System.Drawing.Color.Black
        Me.lblThresholdRatioText.Location = New System.Drawing.Point(4, 374)
        Me.lblThresholdRatioText.Name = "lblThresholdRatioText"
        Me.lblThresholdRatioText.Size = New System.Drawing.Size(116, 32)
        Me.lblThresholdRatioText.TabIndex = 859
        Me.lblThresholdRatioText.Text = "壓力分界後加壓比率:"
        Me.lblThresholdRatioText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtkgDARatio3
        '
        Me.txtkgDARatio3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkgDARatio3.Location = New System.Drawing.Point(294, 236)
        Me.txtkgDARatio3.Name = "txtkgDARatio3"
        Me.txtkgDARatio3.Size = New System.Drawing.Size(80, 26)
        Me.txtkgDARatio3.TabIndex = 2
        Me.txtkgDARatio3.Text = "3"
        Me.txtkgDARatio3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtkgDARatio3.Visible = False
        '
        'txtkgDARatio2
        '
        Me.txtkgDARatio2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkgDARatio2.Location = New System.Drawing.Point(210, 236)
        Me.txtkgDARatio2.Name = "txtkgDARatio2"
        Me.txtkgDARatio2.Size = New System.Drawing.Size(80, 26)
        Me.txtkgDARatio2.TabIndex = 1
        Me.txtkgDARatio2.Text = "3"
        Me.txtkgDARatio2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtkgDARatio2.Visible = False
        '
        'lblOverThresholdkgDA3
        '
        Me.lblOverThresholdkgDA3.BackColor = System.Drawing.Color.Black
        Me.lblOverThresholdkgDA3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOverThresholdkgDA3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOverThresholdkgDA3.ForeColor = System.Drawing.Color.Lime
        Me.lblOverThresholdkgDA3.Location = New System.Drawing.Point(294, 374)
        Me.lblOverThresholdkgDA3.Name = "lblOverThresholdkgDA3"
        Me.lblOverThresholdkgDA3.Size = New System.Drawing.Size(80, 26)
        Me.lblOverThresholdkgDA3.TabIndex = 852
        Me.lblOverThresholdkgDA3.Text = "200"
        Me.lblOverThresholdkgDA3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOverThresholdkgDA2
        '
        Me.lblOverThresholdkgDA2.BackColor = System.Drawing.Color.Black
        Me.lblOverThresholdkgDA2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOverThresholdkgDA2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOverThresholdkgDA2.ForeColor = System.Drawing.Color.Lime
        Me.lblOverThresholdkgDA2.Location = New System.Drawing.Point(210, 374)
        Me.lblOverThresholdkgDA2.Name = "lblOverThresholdkgDA2"
        Me.lblOverThresholdkgDA2.Size = New System.Drawing.Size(80, 26)
        Me.lblOverThresholdkgDA2.TabIndex = 851
        Me.lblOverThresholdkgDA2.Text = "200"
        Me.lblOverThresholdkgDA2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPress2nd3
        '
        Me.txtPress2nd3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPress2nd3.Location = New System.Drawing.Point(294, 60)
        Me.txtPress2nd3.Name = "txtPress2nd3"
        Me.txtPress2nd3.Size = New System.Drawing.Size(80, 26)
        Me.txtPress2nd3.TabIndex = 2
        Me.txtPress2nd3.Text = "70"
        Me.txtPress2nd3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPress2nd2
        '
        Me.txtPress2nd2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPress2nd2.Location = New System.Drawing.Point(210, 60)
        Me.txtPress2nd2.Name = "txtPress2nd2"
        Me.txtPress2nd2.Size = New System.Drawing.Size(80, 26)
        Me.txtPress2nd2.TabIndex = 1
        Me.txtPress2nd2.Text = "70"
        Me.txtPress2nd2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPress3rd3
        '
        Me.txtPress3rd3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPress3rd3.Location = New System.Drawing.Point(294, 115)
        Me.txtPress3rd3.Name = "txtPress3rd3"
        Me.txtPress3rd3.Size = New System.Drawing.Size(80, 26)
        Me.txtPress3rd3.TabIndex = 2
        Me.txtPress3rd3.Text = "50"
        Me.txtPress3rd3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPress3rd2
        '
        Me.txtPress3rd2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPress3rd2.Location = New System.Drawing.Point(210, 115)
        Me.txtPress3rd2.Name = "txtPress3rd2"
        Me.txtPress3rd2.Size = New System.Drawing.Size(80, 26)
        Me.txtPress3rd2.TabIndex = 1
        Me.txtPress3rd2.Text = "50"
        Me.txtPress3rd2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblKg13Text
        '
        Me.lblKg13Text.BackColor = System.Drawing.Color.Transparent
        Me.lblKg13Text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKg13Text.ForeColor = System.Drawing.Color.Black
        Me.lblKg13Text.Location = New System.Drawing.Point(7, 187)
        Me.lblKg13Text.Name = "lblKg13Text"
        Me.lblKg13Text.Size = New System.Drawing.Size(116, 23)
        Me.lblKg13Text.TabIndex = 848
        Me.lblKg13Text.Text = "壓力(Kg)"
        Me.lblKg13Text.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSubPress3
        '
        Me.lblSubPress3.BackColor = System.Drawing.Color.Black
        Me.lblSubPress3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubPress3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubPress3.ForeColor = System.Drawing.Color.Lime
        Me.lblSubPress3.Location = New System.Drawing.Point(294, 166)
        Me.lblSubPress3.Name = "lblSubPress3"
        Me.lblSubPress3.Size = New System.Drawing.Size(80, 23)
        Me.lblSubPress3.TabIndex = 841
        Me.lblSubPress3.Text = "0"
        Me.lblSubPress3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRealPressure3
        '
        Me.lblRealPressure3.BackColor = System.Drawing.Color.Black
        Me.lblRealPressure3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRealPressure3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRealPressure3.ForeColor = System.Drawing.Color.Lime
        Me.lblRealPressure3.Location = New System.Drawing.Point(294, 143)
        Me.lblRealPressure3.Name = "lblRealPressure3"
        Me.lblRealPressure3.Size = New System.Drawing.Size(80, 23)
        Me.lblRealPressure3.TabIndex = 841
        Me.lblRealPressure3.Text = "0"
        Me.lblRealPressure3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPressureRead3
        '
        Me.lblPressureRead3.BackColor = System.Drawing.Color.Black
        Me.lblPressureRead3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPressureRead3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPressureRead3.ForeColor = System.Drawing.Color.Lime
        Me.lblPressureRead3.Location = New System.Drawing.Point(294, 189)
        Me.lblPressureRead3.Name = "lblPressureRead3"
        Me.lblPressureRead3.Size = New System.Drawing.Size(80, 23)
        Me.lblPressureRead3.TabIndex = 840
        Me.lblPressureRead3.Text = "0"
        Me.lblPressureRead3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSubPress2
        '
        Me.lblSubPress2.BackColor = System.Drawing.Color.Black
        Me.lblSubPress2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubPress2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubPress2.ForeColor = System.Drawing.Color.Lime
        Me.lblSubPress2.Location = New System.Drawing.Point(210, 166)
        Me.lblSubPress2.Name = "lblSubPress2"
        Me.lblSubPress2.Size = New System.Drawing.Size(80, 23)
        Me.lblSubPress2.TabIndex = 839
        Me.lblSubPress2.Text = "0"
        Me.lblSubPress2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRealPressure2
        '
        Me.lblRealPressure2.BackColor = System.Drawing.Color.Black
        Me.lblRealPressure2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRealPressure2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRealPressure2.ForeColor = System.Drawing.Color.Lime
        Me.lblRealPressure2.Location = New System.Drawing.Point(210, 143)
        Me.lblRealPressure2.Name = "lblRealPressure2"
        Me.lblRealPressure2.Size = New System.Drawing.Size(80, 23)
        Me.lblRealPressure2.TabIndex = 839
        Me.lblRealPressure2.Text = "0"
        Me.lblRealPressure2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPressureRead2
        '
        Me.lblPressureRead2.BackColor = System.Drawing.Color.Black
        Me.lblPressureRead2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPressureRead2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPressureRead2.ForeColor = System.Drawing.Color.Lime
        Me.lblPressureRead2.Location = New System.Drawing.Point(210, 189)
        Me.lblPressureRead2.Name = "lblPressureRead2"
        Me.lblPressureRead2.Size = New System.Drawing.Size(80, 23)
        Me.lblPressureRead2.TabIndex = 838
        Me.lblPressureRead2.Text = "0"
        Me.lblPressureRead2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblITVRealValue3
        '
        Me.lblITVRealValue3.BackColor = System.Drawing.Color.Black
        Me.lblITVRealValue3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblITVRealValue3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblITVRealValue3.ForeColor = System.Drawing.Color.Lime
        Me.lblITVRealValue3.Location = New System.Drawing.Point(294, 212)
        Me.lblITVRealValue3.Name = "lblITVRealValue3"
        Me.lblITVRealValue3.Size = New System.Drawing.Size(80, 23)
        Me.lblITVRealValue3.TabIndex = 834
        Me.lblITVRealValue3.Text = "0"
        Me.lblITVRealValue3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPlateUp3
        '
        Me.btnPlateUp3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPlateUp3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPlateUp3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlateUp3.ForeColor = System.Drawing.Color.Black
        Me.btnPlateUp3.Image = Global.CELLO.My.Resources.Resources.arrowupR
        Me.btnPlateUp3.Location = New System.Drawing.Point(294, 403)
        Me.btnPlateUp3.Name = "btnPlateUp3"
        Me.btnPlateUp3.Size = New System.Drawing.Size(80, 41)
        Me.btnPlateUp3.TabIndex = 2
        Me.btnPlateUp3.Text = "UP"
        Me.btnPlateUp3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPlateUp3.UseVisualStyleBackColor = False
        '
        'btnPlateDown3
        '
        Me.btnPlateDown3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPlateDown3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPlateDown3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlateDown3.ForeColor = System.Drawing.Color.Black
        Me.btnPlateDown3.Image = Global.CELLO.My.Resources.Resources.arrowdownR
        Me.btnPlateDown3.Location = New System.Drawing.Point(294, 449)
        Me.btnPlateDown3.Name = "btnPlateDown3"
        Me.btnPlateDown3.Size = New System.Drawing.Size(80, 41)
        Me.btnPlateDown3.TabIndex = 2
        Me.btnPlateDown3.Text = "Down"
        Me.btnPlateDown3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPlateDown3.UseVisualStyleBackColor = False
        '
        'btnPlateUp2
        '
        Me.btnPlateUp2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPlateUp2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPlateUp2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlateUp2.ForeColor = System.Drawing.Color.Black
        Me.btnPlateUp2.Image = Global.CELLO.My.Resources.Resources.arrowupR
        Me.btnPlateUp2.Location = New System.Drawing.Point(210, 403)
        Me.btnPlateUp2.Name = "btnPlateUp2"
        Me.btnPlateUp2.Size = New System.Drawing.Size(80, 41)
        Me.btnPlateUp2.TabIndex = 1
        Me.btnPlateUp2.Text = "UP"
        Me.btnPlateUp2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPlateUp2.UseVisualStyleBackColor = False
        '
        'btnPlateDown2
        '
        Me.btnPlateDown2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPlateDown2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPlateDown2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlateDown2.ForeColor = System.Drawing.Color.Black
        Me.btnPlateDown2.Image = Global.CELLO.My.Resources.Resources.arrowdownR
        Me.btnPlateDown2.Location = New System.Drawing.Point(210, 449)
        Me.btnPlateDown2.Name = "btnPlateDown2"
        Me.btnPlateDown2.Size = New System.Drawing.Size(80, 41)
        Me.btnPlateDown2.TabIndex = 1
        Me.btnPlateDown2.Text = "Down"
        Me.btnPlateDown2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPlateDown2.UseVisualStyleBackColor = False
        '
        'lblOverThresholdkgDA1
        '
        Me.lblOverThresholdkgDA1.BackColor = System.Drawing.Color.Black
        Me.lblOverThresholdkgDA1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOverThresholdkgDA1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOverThresholdkgDA1.ForeColor = System.Drawing.Color.Lime
        Me.lblOverThresholdkgDA1.Location = New System.Drawing.Point(126, 374)
        Me.lblOverThresholdkgDA1.Name = "lblOverThresholdkgDA1"
        Me.lblOverThresholdkgDA1.Size = New System.Drawing.Size(80, 26)
        Me.lblOverThresholdkgDA1.TabIndex = 822
        Me.lblOverThresholdkgDA1.Text = "200"
        Me.lblOverThresholdkgDA1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSubPress1
        '
        Me.lblSubPress1.BackColor = System.Drawing.Color.Black
        Me.lblSubPress1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubPress1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubPress1.ForeColor = System.Drawing.Color.Lime
        Me.lblSubPress1.Location = New System.Drawing.Point(126, 166)
        Me.lblSubPress1.Name = "lblSubPress1"
        Me.lblSubPress1.Size = New System.Drawing.Size(80, 23)
        Me.lblSubPress1.TabIndex = 820
        Me.lblSubPress1.Text = "0"
        Me.lblSubPress1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblKg15Text
        '
        Me.lblKg15Text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKg15Text.ForeColor = System.Drawing.Color.Black
        Me.lblKg15Text.Location = New System.Drawing.Point(380, 170)
        Me.lblKg15Text.Name = "lblKg15Text"
        Me.lblKg15Text.Size = New System.Drawing.Size(45, 20)
        Me.lblKg15Text.TabIndex = 818
        Me.lblKg15Text.Text = "kg"
        '
        'lblRealPressure1
        '
        Me.lblRealPressure1.BackColor = System.Drawing.Color.Black
        Me.lblRealPressure1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRealPressure1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRealPressure1.ForeColor = System.Drawing.Color.Lime
        Me.lblRealPressure1.Location = New System.Drawing.Point(126, 143)
        Me.lblRealPressure1.Name = "lblRealPressure1"
        Me.lblRealPressure1.Size = New System.Drawing.Size(80, 23)
        Me.lblRealPressure1.TabIndex = 820
        Me.lblRealPressure1.Text = "0"
        Me.lblRealPressure1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblKg14Text
        '
        Me.lblKg14Text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKg14Text.ForeColor = System.Drawing.Color.Black
        Me.lblKg14Text.Location = New System.Drawing.Point(380, 152)
        Me.lblKg14Text.Name = "lblKg14Text"
        Me.lblKg14Text.Size = New System.Drawing.Size(45, 17)
        Me.lblKg14Text.TabIndex = 818
        Me.lblKg14Text.Text = "kg"
        '
        'lblDA10Text
        '
        Me.lblDA10Text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDA10Text.ForeColor = System.Drawing.Color.Black
        Me.lblDA10Text.Location = New System.Drawing.Point(380, 215)
        Me.lblDA10Text.Name = "lblDA10Text"
        Me.lblDA10Text.Size = New System.Drawing.Size(42, 20)
        Me.lblDA10Text.TabIndex = 508
        Me.lblDA10Text.Text = "DA"
        '
        'lblSubPressText
        '
        Me.lblSubPressText.BackColor = System.Drawing.Color.Transparent
        Me.lblSubPressText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubPressText.ForeColor = System.Drawing.Color.Black
        Me.lblSubPressText.Location = New System.Drawing.Point(7, 165)
        Me.lblSubPressText.Name = "lblSubPressText"
        Me.lblSubPressText.Size = New System.Drawing.Size(116, 23)
        Me.lblSubPressText.TabIndex = 815
        Me.lblSubPressText.Text = "扣重"
        Me.lblSubPressText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblKg20Text
        '
        Me.lblKg20Text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKg20Text.ForeColor = System.Drawing.Color.Black
        Me.lblKg20Text.Location = New System.Drawing.Point(380, 193)
        Me.lblKg20Text.Name = "lblKg20Text"
        Me.lblKg20Text.Size = New System.Drawing.Size(45, 20)
        Me.lblKg20Text.TabIndex = 817
        Me.lblKg20Text.Text = "kg"
        '
        'lblRealPressureText1
        '
        Me.lblRealPressureText1.BackColor = System.Drawing.Color.Transparent
        Me.lblRealPressureText1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRealPressureText1.ForeColor = System.Drawing.Color.Black
        Me.lblRealPressureText1.Location = New System.Drawing.Point(7, 142)
        Me.lblRealPressureText1.Name = "lblRealPressureText1"
        Me.lblRealPressureText1.Size = New System.Drawing.Size(116, 23)
        Me.lblRealPressureText1.TabIndex = 815
        Me.lblRealPressureText1.Text = "轉換後壓力值"
        Me.lblRealPressureText1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPressureRead1
        '
        Me.lblPressureRead1.BackColor = System.Drawing.Color.Black
        Me.lblPressureRead1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPressureRead1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPressureRead1.ForeColor = System.Drawing.Color.Lime
        Me.lblPressureRead1.Location = New System.Drawing.Point(126, 189)
        Me.lblPressureRead1.Name = "lblPressureRead1"
        Me.lblPressureRead1.Size = New System.Drawing.Size(80, 23)
        Me.lblPressureRead1.TabIndex = 819
        Me.lblPressureRead1.Text = "0"
        Me.lblPressureRead1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl1stPlateUpProcedureText
        '
        Me.lbl1stPlateUpProcedureText.BackColor = System.Drawing.Color.Transparent
        Me.lbl1stPlateUpProcedureText.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1stPlateUpProcedureText.ForeColor = System.Drawing.Color.Black
        Me.lbl1stPlateUpProcedureText.Location = New System.Drawing.Point(7, 4)
        Me.lbl1stPlateUpProcedureText.Name = "lbl1stPlateUpProcedureText"
        Me.lbl1stPlateUpProcedureText.Size = New System.Drawing.Size(195, 29)
        Me.lbl1stPlateUpProcedureText.TabIndex = 313
        Me.lbl1stPlateUpProcedureText.Text = "首次貼合程序壓力設定"
        Me.lbl1stPlateUpProcedureText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblKg09Text
        '
        Me.lblKg09Text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKg09Text.ForeColor = System.Drawing.Color.Black
        Me.lblKg09Text.Location = New System.Drawing.Point(209, 93)
        Me.lblKg09Text.Name = "lblKg09Text"
        Me.lblKg09Text.Size = New System.Drawing.Size(45, 20)
        Me.lblKg09Text.TabIndex = 508
        Me.lblKg09Text.Text = "kg"
        '
        'lblmmCount02Text
        '
        Me.lblmmCount02Text.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmmCount02Text.ForeColor = System.Drawing.Color.Black
        Me.lblmmCount02Text.Location = New System.Drawing.Point(380, 337)
        Me.lblmmCount02Text.Name = "lblmmCount02Text"
        Me.lblmmCount02Text.Size = New System.Drawing.Size(65, 12)
        Me.lblmmCount02Text.TabIndex = 806
        Me.lblmmCount02Text.Text = "mm/Cnt"
        '
        'lblKgDA02Text
        '
        Me.lblKgDA02Text.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKgDA02Text.ForeColor = System.Drawing.Color.Black
        Me.lblKgDA02Text.Location = New System.Drawing.Point(380, 238)
        Me.lblKgDA02Text.Name = "lblKgDA02Text"
        Me.lblKgDA02Text.Size = New System.Drawing.Size(45, 26)
        Me.lblKgDA02Text.TabIndex = 806
        Me.lblKgDA02Text.Text = "kg/DA"
        Me.lblKgDA02Text.Visible = False
        '
        'btnShowPicControl
        '
        Me.btnShowPicControl.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnShowPicControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowPicControl.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowPicControl.Location = New System.Drawing.Point(705, 8)
        Me.btnShowPicControl.Name = "btnShowPicControl"
        Me.btnShowPicControl.Size = New System.Drawing.Size(279, 34)
        Me.btnShowPicControl.TabIndex = 69
        Me.btnShowPicControl.Text = "自動控壓程序設定"
        Me.btnShowPicControl.UseVisualStyleBackColor = False
        '
        'lblDA01Text
        '
        Me.lblDA01Text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDA01Text.ForeColor = System.Drawing.Color.Black
        Me.lblDA01Text.Location = New System.Drawing.Point(209, 39)
        Me.lblDA01Text.Name = "lblDA01Text"
        Me.lblDA01Text.Size = New System.Drawing.Size(45, 20)
        Me.lblDA01Text.TabIndex = 508
        Me.lblDA01Text.Text = "DA"
        '
        'txtkgDARatio1
        '
        Me.txtkgDARatio1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkgDARatio1.Location = New System.Drawing.Point(126, 236)
        Me.txtkgDARatio1.Name = "txtkgDARatio1"
        Me.txtkgDARatio1.Size = New System.Drawing.Size(80, 26)
        Me.txtkgDARatio1.TabIndex = 0
        Me.txtkgDARatio1.Text = "3"
        Me.txtkgDARatio1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtkgDARatio1.Visible = False
        '
        'lblDA06Text
        '
        Me.lblDA06Text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDA06Text.ForeColor = System.Drawing.Color.Black
        Me.lblDA06Text.Location = New System.Drawing.Point(937, 538)
        Me.lblDA06Text.Name = "lblDA06Text"
        Me.lblDA06Text.Size = New System.Drawing.Size(45, 26)
        Me.lblDA06Text.TabIndex = 809
        Me.lblDA06Text.Text = "DA"
        Me.lblDA06Text.Visible = False
        '
        'lblDA09Text
        '
        Me.lblDA09Text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDA09Text.ForeColor = System.Drawing.Color.Black
        Me.lblDA09Text.Location = New System.Drawing.Point(380, 70)
        Me.lblDA09Text.Name = "lblDA09Text"
        Me.lblDA09Text.Size = New System.Drawing.Size(45, 20)
        Me.lblDA09Text.TabIndex = 508
        Me.lblDA09Text.Text = "DA"
        '
        'lblDA11Text
        '
        Me.lblDA11Text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDA11Text.ForeColor = System.Drawing.Color.Black
        Me.lblDA11Text.Location = New System.Drawing.Point(380, 132)
        Me.lblDA11Text.Name = "lblDA11Text"
        Me.lblDA11Text.Size = New System.Drawing.Size(45, 20)
        Me.lblDA11Text.TabIndex = 508
        Me.lblDA11Text.Text = "DA"
        '
        'btnHighPDAOut
        '
        Me.btnHighPDAOut.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHighPDAOut.Location = New System.Drawing.Point(735, 538)
        Me.btnHighPDAOut.Name = "btnHighPDAOut"
        Me.btnHighPDAOut.Size = New System.Drawing.Size(113, 27)
        Me.btnHighPDAOut.TabIndex = 808
        Me.btnHighPDAOut.Text = "高壓輸出"
        Me.btnHighPDAOut.UseVisualStyleBackColor = True
        Me.btnHighPDAOut.Visible = False
        '
        'lblDA07Text
        '
        Me.lblDA07Text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDA07Text.ForeColor = System.Drawing.Color.Black
        Me.lblDA07Text.Location = New System.Drawing.Point(940, 505)
        Me.lblDA07Text.Name = "lblDA07Text"
        Me.lblDA07Text.Size = New System.Drawing.Size(45, 26)
        Me.lblDA07Text.TabIndex = 508
        Me.lblDA07Text.Text = "DA"
        Me.lblDA07Text.Visible = False
        '
        'lblkgDARatioText
        '
        Me.lblkgDARatioText.BackColor = System.Drawing.Color.Transparent
        Me.lblkgDARatioText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblkgDARatioText.ForeColor = System.Drawing.Color.Black
        Me.lblkgDARatioText.Location = New System.Drawing.Point(-1, 237)
        Me.lblkgDARatioText.Name = "lblkgDARatioText"
        Me.lblkgDARatioText.Size = New System.Drawing.Size(125, 26)
        Me.lblkgDARatioText.TabIndex = 317
        Me.lblkgDARatioText.Text = "壓力/油壓比例:"
        Me.lblkgDARatioText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblkgDARatioText.Visible = False
        '
        'txtPress1st
        '
        Me.txtPress1st.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPress1st.Location = New System.Drawing.Point(126, 33)
        Me.txtPress1st.Name = "txtPress1st"
        Me.txtPress1st.Size = New System.Drawing.Size(80, 26)
        Me.txtPress1st.TabIndex = 20
        Me.txtPress1st.Text = "100"
        Me.txtPress1st.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPress2nd1
        '
        Me.txtPress2nd1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPress2nd1.Location = New System.Drawing.Point(126, 60)
        Me.txtPress2nd1.Name = "txtPress2nd1"
        Me.txtPress2nd1.Size = New System.Drawing.Size(80, 26)
        Me.txtPress2nd1.TabIndex = 0
        Me.txtPress2nd1.Text = "70"
        Me.txtPress2nd1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPress3rd1
        '
        Me.txtPress3rd1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPress3rd1.Location = New System.Drawing.Point(126, 115)
        Me.txtPress3rd1.Name = "txtPress3rd1"
        Me.txtPress3rd1.Size = New System.Drawing.Size(80, 26)
        Me.txtPress3rd1.TabIndex = 0
        Me.txtPress3rd1.Text = "50"
        Me.txtPress3rd1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLowPDAOut
        '
        Me.txtLowPDAOut.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLowPDAOut.Location = New System.Drawing.Point(867, 493)
        Me.txtLowPDAOut.Name = "txtLowPDAOut"
        Me.txtLowPDAOut.Size = New System.Drawing.Size(80, 26)
        Me.txtLowPDAOut.TabIndex = 40
        Me.txtLowPDAOut.Text = "0"
        Me.txtLowPDAOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtLowPDAOut.Visible = False
        '
        'txtPlateUpContactKg
        '
        Me.txtPlateUpContactKg.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlateUpContactKg.Location = New System.Drawing.Point(126, 87)
        Me.txtPlateUpContactKg.Name = "txtPlateUpContactKg"
        Me.txtPlateUpContactKg.Size = New System.Drawing.Size(80, 26)
        Me.txtPlateUpContactKg.TabIndex = 23
        Me.txtPlateUpContactKg.Text = "5"
        Me.txtPlateUpContactKg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnLowPDAOut
        '
        Me.btnLowPDAOut.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLowPDAOut.Location = New System.Drawing.Point(735, 502)
        Me.btnLowPDAOut.Name = "btnLowPDAOut"
        Me.btnLowPDAOut.Size = New System.Drawing.Size(113, 27)
        Me.btnLowPDAOut.TabIndex = 524
        Me.btnLowPDAOut.Text = "低壓輸出"
        Me.btnLowPDAOut.UseVisualStyleBackColor = True
        Me.btnLowPDAOut.Visible = False
        '
        'lblPlateUpContactKgText
        '
        Me.lblPlateUpContactKgText.BackColor = System.Drawing.Color.Transparent
        Me.lblPlateUpContactKgText.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlateUpContactKgText.ForeColor = System.Drawing.Color.Black
        Me.lblPlateUpContactKgText.Location = New System.Drawing.Point(4, 87)
        Me.lblPlateUpContactKgText.Name = "lblPlateUpContactKgText"
        Me.lblPlateUpContactKgText.Size = New System.Drawing.Size(119, 26)
        Me.lblPlateUpContactKgText.TabIndex = 317
        Me.lblPlateUpContactKgText.Text = "接觸壓力:"
        Me.lblPlateUpContactKgText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPress3rdText
        '
        Me.lblPress3rdText.BackColor = System.Drawing.Color.Transparent
        Me.lblPress3rdText.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPress3rdText.ForeColor = System.Drawing.Color.Black
        Me.lblPress3rdText.Location = New System.Drawing.Point(4, 116)
        Me.lblPress3rdText.Name = "lblPress3rdText"
        Me.lblPress3rdText.Size = New System.Drawing.Size(119, 26)
        Me.lblPress3rdText.TabIndex = 317
        Me.lblPress3rdText.Text = "初始貼合壓力:"
        Me.lblPress3rdText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblITVRealValue1Text
        '
        Me.lblITVRealValue1Text.BackColor = System.Drawing.Color.Transparent
        Me.lblITVRealValue1Text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblITVRealValue1Text.ForeColor = System.Drawing.Color.Black
        Me.lblITVRealValue1Text.Location = New System.Drawing.Point(783, 531)
        Me.lblITVRealValue1Text.Name = "lblITVRealValue1Text"
        Me.lblITVRealValue1Text.Size = New System.Drawing.Size(119, 26)
        Me.lblITVRealValue1Text.TabIndex = 317
        Me.lblITVRealValue1Text.Text = "低壓比例閥:"
        Me.lblITVRealValue1Text.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblITVRealValue1Text.Visible = False
        '
        'lblITVRealValue2Text
        '
        Me.lblITVRealValue2Text.BackColor = System.Drawing.Color.Transparent
        Me.lblITVRealValue2Text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblITVRealValue2Text.ForeColor = System.Drawing.Color.Black
        Me.lblITVRealValue2Text.Location = New System.Drawing.Point(7, 213)
        Me.lblITVRealValue2Text.Name = "lblITVRealValue2Text"
        Me.lblITVRealValue2Text.Size = New System.Drawing.Size(116, 23)
        Me.lblITVRealValue2Text.TabIndex = 317
        Me.lblITVRealValue2Text.Text = "比例閥:"
        Me.lblITVRealValue2Text.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPress1stText
        '
        Me.lblPress1stText.BackColor = System.Drawing.Color.Transparent
        Me.lblPress1stText.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPress1stText.ForeColor = System.Drawing.Color.Black
        Me.lblPress1stText.Location = New System.Drawing.Point(4, 33)
        Me.lblPress1stText.Name = "lblPress1stText"
        Me.lblPress1stText.Size = New System.Drawing.Size(119, 26)
        Me.lblPress1stText.TabIndex = 317
        Me.lblPress1stText.Text = "第一段壓力:"
        Me.lblPress1stText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblITVRealValue1
        '
        Me.lblITVRealValue1.BackColor = System.Drawing.Color.Black
        Me.lblITVRealValue1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblITVRealValue1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblITVRealValue1.ForeColor = System.Drawing.Color.Lime
        Me.lblITVRealValue1.Location = New System.Drawing.Point(126, 212)
        Me.lblITVRealValue1.Name = "lblITVRealValue1"
        Me.lblITVRealValue1.Size = New System.Drawing.Size(80, 23)
        Me.lblITVRealValue1.TabIndex = 523
        Me.lblITVRealValue1.Text = "0"
        Me.lblITVRealValue1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblITVRealValue2
        '
        Me.lblITVRealValue2.BackColor = System.Drawing.Color.Black
        Me.lblITVRealValue2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblITVRealValue2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblITVRealValue2.ForeColor = System.Drawing.Color.Lime
        Me.lblITVRealValue2.Location = New System.Drawing.Point(210, 212)
        Me.lblITVRealValue2.Name = "lblITVRealValue2"
        Me.lblITVRealValue2.Size = New System.Drawing.Size(80, 23)
        Me.lblITVRealValue2.TabIndex = 523
        Me.lblITVRealValue2.Text = "0"
        Me.lblITVRealValue2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPress2ndText
        '
        Me.lblPress2ndText.BackColor = System.Drawing.Color.Transparent
        Me.lblPress2ndText.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPress2ndText.ForeColor = System.Drawing.Color.Black
        Me.lblPress2ndText.Location = New System.Drawing.Point(4, 60)
        Me.lblPress2ndText.Name = "lblPress2ndText"
        Me.lblPress2ndText.Size = New System.Drawing.Size(119, 26)
        Me.lblPress2ndText.TabIndex = 317
        Me.lblPress2ndText.Text = "第二段壓力:"
        Me.lblPress2ndText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnPlateUp1
        '
        Me.btnPlateUp1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPlateUp1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPlateUp1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlateUp1.ForeColor = System.Drawing.Color.Black
        Me.btnPlateUp1.Image = Global.CELLO.My.Resources.Resources.arrowupR
        Me.btnPlateUp1.Location = New System.Drawing.Point(126, 403)
        Me.btnPlateUp1.Name = "btnPlateUp1"
        Me.btnPlateUp1.Size = New System.Drawing.Size(80, 41)
        Me.btnPlateUp1.TabIndex = 0
        Me.btnPlateUp1.Text = "UP"
        Me.btnPlateUp1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPlateUp1.UseVisualStyleBackColor = False
        '
        'btnPlateDown1
        '
        Me.btnPlateDown1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPlateDown1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPlateDown1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlateDown1.ForeColor = System.Drawing.Color.Black
        Me.btnPlateDown1.Image = Global.CELLO.My.Resources.Resources.arrowdownR
        Me.btnPlateDown1.Location = New System.Drawing.Point(126, 449)
        Me.btnPlateDown1.Name = "btnPlateDown1"
        Me.btnPlateDown1.Size = New System.Drawing.Size(80, 41)
        Me.btnPlateDown1.TabIndex = 0
        Me.btnPlateDown1.Text = "Down"
        Me.btnPlateDown1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPlateDown1.UseVisualStyleBackColor = False
        '
        'pnl6Plate
        '
        Me.pnl6Plate.Controls.Add(Me.lblPositionSet6)
        Me.pnl6Plate.Controls.Add(Me.lblPositionSet5)
        Me.pnl6Plate.Controls.Add(Me.lblPositionSet4)
        Me.pnl6Plate.Controls.Add(Me.txtkgDARatio6)
        Me.pnl6Plate.Controls.Add(Me.txtOutRangAddDA6)
        Me.pnl6Plate.Controls.Add(Me.lblOverThresholdkgDA6)
        Me.pnl6Plate.Controls.Add(Me.txtOutRangAddDA5)
        Me.pnl6Plate.Controls.Add(Me.txtkgDARatio5)
        Me.pnl6Plate.Controls.Add(Me.txtOutRangAddDA4)
        Me.pnl6Plate.Controls.Add(Me.txtPress2nd6)
        Me.pnl6Plate.Controls.Add(Me.txtkgDARatio4)
        Me.pnl6Plate.Controls.Add(Me.lblOverThresholdkgDA5)
        Me.pnl6Plate.Controls.Add(Me.txtPress2nd5)
        Me.pnl6Plate.Controls.Add(Me.lblOverThresholdkgDA4)
        Me.pnl6Plate.Controls.Add(Me.lblCurrentPosition6)
        Me.pnl6Plate.Controls.Add(Me.txtPress2nd4)
        Me.pnl6Plate.Controls.Add(Me.lblCurrentPosition5)
        Me.pnl6Plate.Controls.Add(Me.txtPress3rd6)
        Me.pnl6Plate.Controls.Add(Me.lblCurrentPosition4)
        Me.pnl6Plate.Controls.Add(Me.txtPress3rd5)
        Me.pnl6Plate.Controls.Add(Me.txtPress3rd4)
        Me.pnl6Plate.Controls.Add(Me.lblSubPress6)
        Me.pnl6Plate.Controls.Add(Me.lblRealPressure6)
        Me.pnl6Plate.Controls.Add(Me.lblPressureRead6)
        Me.pnl6Plate.Controls.Add(Me.lblSubPress5)
        Me.pnl6Plate.Controls.Add(Me.lblRealPressure5)
        Me.pnl6Plate.Controls.Add(Me.lblPressureRead5)
        Me.pnl6Plate.Controls.Add(Me.lblSubPress4)
        Me.pnl6Plate.Controls.Add(Me.lblRealPressure4)
        Me.pnl6Plate.Controls.Add(Me.lblPressureRead4)
        Me.pnl6Plate.Controls.Add(Me.lblITVRealValue6)
        Me.pnl6Plate.Controls.Add(Me.lblITVRealValue5)
        Me.pnl6Plate.Controls.Add(Me.lblITVRealValue4)
        Me.pnl6Plate.Controls.Add(Me.btnPlateUp6)
        Me.pnl6Plate.Controls.Add(Me.btnPlateDown6)
        Me.pnl6Plate.Controls.Add(Me.btnPlateUp5)
        Me.pnl6Plate.Controls.Add(Me.lblKg19Text)
        Me.pnl6Plate.Controls.Add(Me.btnPlateDown5)
        Me.pnl6Plate.Controls.Add(Me.btnPlateUp4)
        Me.pnl6Plate.Controls.Add(Me.btnPlateDown4)
        Me.pnl6Plate.Controls.Add(Me.lblKg16Text)
        Me.pnl6Plate.Controls.Add(Me.lblDA02Text)
        Me.pnl6Plate.Controls.Add(Me.lblDA05Text)
        Me.pnl6Plate.Controls.Add(Me.lblDA03Text)
        Me.pnl6Plate.Controls.Add(Me.lblKg17Text)
        Me.pnl6Plate.Controls.Add(Me.lblKgDA04Text)
        Me.pnl6Plate.Controls.Add(Me.lblKgDA01Text)
        Me.pnl6Plate.Controls.Add(Me.lblKgDA03Text)
        Me.pnl6Plate.Controls.Add(Me.lblmmCount03Text)
        Me.pnl6Plate.Location = New System.Drawing.Point(380, 57)
        Me.pnl6Plate.Name = "pnl6Plate"
        Me.pnl6Plate.Size = New System.Drawing.Size(309, 436)
        Me.pnl6Plate.TabIndex = 850
        '
        'lblPositionSet6
        '
        Me.lblPositionSet6.BackColor = System.Drawing.Color.Black
        Me.lblPositionSet6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPositionSet6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPositionSet6.ForeColor = System.Drawing.Color.Lime
        Me.lblPositionSet6.Location = New System.Drawing.Point(170, 294)
        Me.lblPositionSet6.Name = "lblPositionSet6"
        Me.lblPositionSet6.Size = New System.Drawing.Size(80, 19)
        Me.lblPositionSet6.TabIndex = 916
        Me.lblPositionSet6.Text = "0"
        Me.lblPositionSet6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPositionSet5
        '
        Me.lblPositionSet5.BackColor = System.Drawing.Color.Black
        Me.lblPositionSet5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPositionSet5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPositionSet5.ForeColor = System.Drawing.Color.Lime
        Me.lblPositionSet5.Location = New System.Drawing.Point(86, 294)
        Me.lblPositionSet5.Name = "lblPositionSet5"
        Me.lblPositionSet5.Size = New System.Drawing.Size(80, 19)
        Me.lblPositionSet5.TabIndex = 915
        Me.lblPositionSet5.Text = "0"
        Me.lblPositionSet5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPositionSet4
        '
        Me.lblPositionSet4.BackColor = System.Drawing.Color.Black
        Me.lblPositionSet4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPositionSet4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPositionSet4.ForeColor = System.Drawing.Color.Lime
        Me.lblPositionSet4.Location = New System.Drawing.Point(3, 294)
        Me.lblPositionSet4.Name = "lblPositionSet4"
        Me.lblPositionSet4.Size = New System.Drawing.Size(80, 19)
        Me.lblPositionSet4.TabIndex = 914
        Me.lblPositionSet4.Text = "0"
        Me.lblPositionSet4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtkgDARatio6
        '
        Me.txtkgDARatio6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkgDARatio6.Location = New System.Drawing.Point(170, 179)
        Me.txtkgDARatio6.Name = "txtkgDARatio6"
        Me.txtkgDARatio6.Size = New System.Drawing.Size(80, 26)
        Me.txtkgDARatio6.TabIndex = 5
        Me.txtkgDARatio6.Text = "3"
        Me.txtkgDARatio6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtOutRangAddDA6
        '
        Me.txtOutRangAddDA6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutRangAddDA6.Location = New System.Drawing.Point(171, 239)
        Me.txtOutRangAddDA6.Name = "txtOutRangAddDA6"
        Me.txtOutRangAddDA6.Size = New System.Drawing.Size(80, 26)
        Me.txtOutRangAddDA6.TabIndex = 5
        Me.txtOutRangAddDA6.Text = "1"
        Me.txtOutRangAddDA6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblOverThresholdkgDA6
        '
        Me.lblOverThresholdkgDA6.BackColor = System.Drawing.Color.Black
        Me.lblOverThresholdkgDA6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOverThresholdkgDA6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOverThresholdkgDA6.ForeColor = System.Drawing.Color.Lime
        Me.lblOverThresholdkgDA6.Location = New System.Drawing.Point(170, 317)
        Me.lblOverThresholdkgDA6.Name = "lblOverThresholdkgDA6"
        Me.lblOverThresholdkgDA6.Size = New System.Drawing.Size(80, 26)
        Me.lblOverThresholdkgDA6.TabIndex = 855
        Me.lblOverThresholdkgDA6.Text = "200"
        Me.lblOverThresholdkgDA6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtOutRangAddDA5
        '
        Me.txtOutRangAddDA5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutRangAddDA5.Location = New System.Drawing.Point(87, 239)
        Me.txtOutRangAddDA5.Name = "txtOutRangAddDA5"
        Me.txtOutRangAddDA5.Size = New System.Drawing.Size(80, 26)
        Me.txtOutRangAddDA5.TabIndex = 4
        Me.txtOutRangAddDA5.Text = "1"
        Me.txtOutRangAddDA5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtkgDARatio5
        '
        Me.txtkgDARatio5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkgDARatio5.Location = New System.Drawing.Point(86, 179)
        Me.txtkgDARatio5.Name = "txtkgDARatio5"
        Me.txtkgDARatio5.Size = New System.Drawing.Size(80, 26)
        Me.txtkgDARatio5.TabIndex = 4
        Me.txtkgDARatio5.Text = "3"
        Me.txtkgDARatio5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtOutRangAddDA4
        '
        Me.txtOutRangAddDA4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutRangAddDA4.Location = New System.Drawing.Point(3, 239)
        Me.txtOutRangAddDA4.Name = "txtOutRangAddDA4"
        Me.txtOutRangAddDA4.Size = New System.Drawing.Size(80, 26)
        Me.txtOutRangAddDA4.TabIndex = 3
        Me.txtOutRangAddDA4.Text = "1"
        Me.txtOutRangAddDA4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPress2nd6
        '
        Me.txtPress2nd6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPress2nd6.Location = New System.Drawing.Point(171, 3)
        Me.txtPress2nd6.Name = "txtPress2nd6"
        Me.txtPress2nd6.Size = New System.Drawing.Size(80, 26)
        Me.txtPress2nd6.TabIndex = 5
        Me.txtPress2nd6.Text = "70"
        Me.txtPress2nd6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtkgDARatio4
        '
        Me.txtkgDARatio4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkgDARatio4.Location = New System.Drawing.Point(2, 179)
        Me.txtkgDARatio4.Name = "txtkgDARatio4"
        Me.txtkgDARatio4.Size = New System.Drawing.Size(80, 26)
        Me.txtkgDARatio4.TabIndex = 3
        Me.txtkgDARatio4.Text = "3"
        Me.txtkgDARatio4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblOverThresholdkgDA5
        '
        Me.lblOverThresholdkgDA5.BackColor = System.Drawing.Color.Black
        Me.lblOverThresholdkgDA5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOverThresholdkgDA5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOverThresholdkgDA5.ForeColor = System.Drawing.Color.Lime
        Me.lblOverThresholdkgDA5.Location = New System.Drawing.Point(86, 317)
        Me.lblOverThresholdkgDA5.Name = "lblOverThresholdkgDA5"
        Me.lblOverThresholdkgDA5.Size = New System.Drawing.Size(80, 26)
        Me.lblOverThresholdkgDA5.TabIndex = 854
        Me.lblOverThresholdkgDA5.Text = "200"
        Me.lblOverThresholdkgDA5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPress2nd5
        '
        Me.txtPress2nd5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPress2nd5.Location = New System.Drawing.Point(85, 3)
        Me.txtPress2nd5.Name = "txtPress2nd5"
        Me.txtPress2nd5.Size = New System.Drawing.Size(80, 26)
        Me.txtPress2nd5.TabIndex = 4
        Me.txtPress2nd5.Text = "70"
        Me.txtPress2nd5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblOverThresholdkgDA4
        '
        Me.lblOverThresholdkgDA4.BackColor = System.Drawing.Color.Black
        Me.lblOverThresholdkgDA4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOverThresholdkgDA4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOverThresholdkgDA4.ForeColor = System.Drawing.Color.Lime
        Me.lblOverThresholdkgDA4.Location = New System.Drawing.Point(2, 317)
        Me.lblOverThresholdkgDA4.Name = "lblOverThresholdkgDA4"
        Me.lblOverThresholdkgDA4.Size = New System.Drawing.Size(80, 26)
        Me.lblOverThresholdkgDA4.TabIndex = 853
        Me.lblOverThresholdkgDA4.Text = "200"
        Me.lblOverThresholdkgDA4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCurrentPosition6
        '
        Me.lblCurrentPosition6.BackColor = System.Drawing.Color.Black
        Me.lblCurrentPosition6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCurrentPosition6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentPosition6.ForeColor = System.Drawing.Color.Lime
        Me.lblCurrentPosition6.Location = New System.Drawing.Point(171, 273)
        Me.lblCurrentPosition6.Name = "lblCurrentPosition6"
        Me.lblCurrentPosition6.Size = New System.Drawing.Size(80, 19)
        Me.lblCurrentPosition6.TabIndex = 865
        Me.lblCurrentPosition6.Text = "0"
        Me.lblCurrentPosition6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPress2nd4
        '
        Me.txtPress2nd4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPress2nd4.Location = New System.Drawing.Point(2, 3)
        Me.txtPress2nd4.Name = "txtPress2nd4"
        Me.txtPress2nd4.Size = New System.Drawing.Size(80, 26)
        Me.txtPress2nd4.TabIndex = 3
        Me.txtPress2nd4.Text = "70"
        Me.txtPress2nd4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCurrentPosition5
        '
        Me.lblCurrentPosition5.BackColor = System.Drawing.Color.Black
        Me.lblCurrentPosition5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCurrentPosition5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentPosition5.ForeColor = System.Drawing.Color.Lime
        Me.lblCurrentPosition5.Location = New System.Drawing.Point(87, 273)
        Me.lblCurrentPosition5.Name = "lblCurrentPosition5"
        Me.lblCurrentPosition5.Size = New System.Drawing.Size(80, 19)
        Me.lblCurrentPosition5.TabIndex = 865
        Me.lblCurrentPosition5.Text = "0"
        Me.lblCurrentPosition5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPress3rd6
        '
        Me.txtPress3rd6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPress3rd6.Location = New System.Drawing.Point(171, 58)
        Me.txtPress3rd6.Name = "txtPress3rd6"
        Me.txtPress3rd6.Size = New System.Drawing.Size(80, 26)
        Me.txtPress3rd6.TabIndex = 5
        Me.txtPress3rd6.Text = "50"
        Me.txtPress3rd6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCurrentPosition4
        '
        Me.lblCurrentPosition4.BackColor = System.Drawing.Color.Black
        Me.lblCurrentPosition4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCurrentPosition4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentPosition4.ForeColor = System.Drawing.Color.Lime
        Me.lblCurrentPosition4.Location = New System.Drawing.Point(3, 273)
        Me.lblCurrentPosition4.Name = "lblCurrentPosition4"
        Me.lblCurrentPosition4.Size = New System.Drawing.Size(80, 19)
        Me.lblCurrentPosition4.TabIndex = 865
        Me.lblCurrentPosition4.Text = "0"
        Me.lblCurrentPosition4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPress3rd5
        '
        Me.txtPress3rd5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPress3rd5.Location = New System.Drawing.Point(85, 58)
        Me.txtPress3rd5.Name = "txtPress3rd5"
        Me.txtPress3rd5.Size = New System.Drawing.Size(80, 26)
        Me.txtPress3rd5.TabIndex = 4
        Me.txtPress3rd5.Text = "50"
        Me.txtPress3rd5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPress3rd4
        '
        Me.txtPress3rd4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPress3rd4.Location = New System.Drawing.Point(2, 58)
        Me.txtPress3rd4.Name = "txtPress3rd4"
        Me.txtPress3rd4.Size = New System.Drawing.Size(80, 26)
        Me.txtPress3rd4.TabIndex = 3
        Me.txtPress3rd4.Text = "50"
        Me.txtPress3rd4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblSubPress6
        '
        Me.lblSubPress6.BackColor = System.Drawing.Color.Black
        Me.lblSubPress6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubPress6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubPress6.ForeColor = System.Drawing.Color.Lime
        Me.lblSubPress6.Location = New System.Drawing.Point(171, 109)
        Me.lblSubPress6.Name = "lblSubPress6"
        Me.lblSubPress6.Size = New System.Drawing.Size(80, 23)
        Me.lblSubPress6.TabIndex = 847
        Me.lblSubPress6.Text = "0"
        Me.lblSubPress6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRealPressure6
        '
        Me.lblRealPressure6.BackColor = System.Drawing.Color.Black
        Me.lblRealPressure6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRealPressure6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRealPressure6.ForeColor = System.Drawing.Color.Lime
        Me.lblRealPressure6.Location = New System.Drawing.Point(171, 86)
        Me.lblRealPressure6.Name = "lblRealPressure6"
        Me.lblRealPressure6.Size = New System.Drawing.Size(80, 23)
        Me.lblRealPressure6.TabIndex = 847
        Me.lblRealPressure6.Text = "0"
        Me.lblRealPressure6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPressureRead6
        '
        Me.lblPressureRead6.BackColor = System.Drawing.Color.Black
        Me.lblPressureRead6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPressureRead6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPressureRead6.ForeColor = System.Drawing.Color.Lime
        Me.lblPressureRead6.Location = New System.Drawing.Point(171, 132)
        Me.lblPressureRead6.Name = "lblPressureRead6"
        Me.lblPressureRead6.Size = New System.Drawing.Size(80, 23)
        Me.lblPressureRead6.TabIndex = 846
        Me.lblPressureRead6.Text = "0"
        Me.lblPressureRead6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSubPress5
        '
        Me.lblSubPress5.BackColor = System.Drawing.Color.Black
        Me.lblSubPress5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubPress5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubPress5.ForeColor = System.Drawing.Color.Lime
        Me.lblSubPress5.Location = New System.Drawing.Point(85, 109)
        Me.lblSubPress5.Name = "lblSubPress5"
        Me.lblSubPress5.Size = New System.Drawing.Size(80, 23)
        Me.lblSubPress5.TabIndex = 845
        Me.lblSubPress5.Text = "0"
        Me.lblSubPress5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRealPressure5
        '
        Me.lblRealPressure5.BackColor = System.Drawing.Color.Black
        Me.lblRealPressure5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRealPressure5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRealPressure5.ForeColor = System.Drawing.Color.Lime
        Me.lblRealPressure5.Location = New System.Drawing.Point(85, 86)
        Me.lblRealPressure5.Name = "lblRealPressure5"
        Me.lblRealPressure5.Size = New System.Drawing.Size(80, 23)
        Me.lblRealPressure5.TabIndex = 845
        Me.lblRealPressure5.Text = "0"
        Me.lblRealPressure5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPressureRead5
        '
        Me.lblPressureRead5.BackColor = System.Drawing.Color.Black
        Me.lblPressureRead5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPressureRead5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPressureRead5.ForeColor = System.Drawing.Color.Lime
        Me.lblPressureRead5.Location = New System.Drawing.Point(85, 132)
        Me.lblPressureRead5.Name = "lblPressureRead5"
        Me.lblPressureRead5.Size = New System.Drawing.Size(80, 23)
        Me.lblPressureRead5.TabIndex = 844
        Me.lblPressureRead5.Text = "0"
        Me.lblPressureRead5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSubPress4
        '
        Me.lblSubPress4.BackColor = System.Drawing.Color.Black
        Me.lblSubPress4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubPress4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubPress4.ForeColor = System.Drawing.Color.Lime
        Me.lblSubPress4.Location = New System.Drawing.Point(2, 109)
        Me.lblSubPress4.Name = "lblSubPress4"
        Me.lblSubPress4.Size = New System.Drawing.Size(80, 23)
        Me.lblSubPress4.TabIndex = 843
        Me.lblSubPress4.Text = "0"
        Me.lblSubPress4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRealPressure4
        '
        Me.lblRealPressure4.BackColor = System.Drawing.Color.Black
        Me.lblRealPressure4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRealPressure4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRealPressure4.ForeColor = System.Drawing.Color.Lime
        Me.lblRealPressure4.Location = New System.Drawing.Point(2, 86)
        Me.lblRealPressure4.Name = "lblRealPressure4"
        Me.lblRealPressure4.Size = New System.Drawing.Size(80, 23)
        Me.lblRealPressure4.TabIndex = 843
        Me.lblRealPressure4.Text = "0"
        Me.lblRealPressure4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPressureRead4
        '
        Me.lblPressureRead4.BackColor = System.Drawing.Color.Black
        Me.lblPressureRead4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPressureRead4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPressureRead4.ForeColor = System.Drawing.Color.Lime
        Me.lblPressureRead4.Location = New System.Drawing.Point(2, 132)
        Me.lblPressureRead4.Name = "lblPressureRead4"
        Me.lblPressureRead4.Size = New System.Drawing.Size(80, 23)
        Me.lblPressureRead4.TabIndex = 842
        Me.lblPressureRead4.Text = "0"
        Me.lblPressureRead4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblITVRealValue6
        '
        Me.lblITVRealValue6.BackColor = System.Drawing.Color.Black
        Me.lblITVRealValue6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblITVRealValue6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblITVRealValue6.ForeColor = System.Drawing.Color.Lime
        Me.lblITVRealValue6.Location = New System.Drawing.Point(171, 155)
        Me.lblITVRealValue6.Name = "lblITVRealValue6"
        Me.lblITVRealValue6.Size = New System.Drawing.Size(80, 23)
        Me.lblITVRealValue6.TabIndex = 837
        Me.lblITVRealValue6.Text = "0"
        Me.lblITVRealValue6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblITVRealValue5
        '
        Me.lblITVRealValue5.BackColor = System.Drawing.Color.Black
        Me.lblITVRealValue5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblITVRealValue5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblITVRealValue5.ForeColor = System.Drawing.Color.Lime
        Me.lblITVRealValue5.Location = New System.Drawing.Point(85, 155)
        Me.lblITVRealValue5.Name = "lblITVRealValue5"
        Me.lblITVRealValue5.Size = New System.Drawing.Size(80, 23)
        Me.lblITVRealValue5.TabIndex = 836
        Me.lblITVRealValue5.Text = "0"
        Me.lblITVRealValue5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblITVRealValue4
        '
        Me.lblITVRealValue4.BackColor = System.Drawing.Color.Black
        Me.lblITVRealValue4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblITVRealValue4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblITVRealValue4.ForeColor = System.Drawing.Color.Lime
        Me.lblITVRealValue4.Location = New System.Drawing.Point(2, 155)
        Me.lblITVRealValue4.Name = "lblITVRealValue4"
        Me.lblITVRealValue4.Size = New System.Drawing.Size(80, 23)
        Me.lblITVRealValue4.TabIndex = 835
        Me.lblITVRealValue4.Text = "0"
        Me.lblITVRealValue4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPlateUp6
        '
        Me.btnPlateUp6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPlateUp6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPlateUp6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlateUp6.ForeColor = System.Drawing.Color.Black
        Me.btnPlateUp6.Image = Global.CELLO.My.Resources.Resources.arrowupR
        Me.btnPlateUp6.Location = New System.Drawing.Point(172, 345)
        Me.btnPlateUp6.Name = "btnPlateUp6"
        Me.btnPlateUp6.Size = New System.Drawing.Size(80, 41)
        Me.btnPlateUp6.TabIndex = 5
        Me.btnPlateUp6.Text = "UP"
        Me.btnPlateUp6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPlateUp6.UseVisualStyleBackColor = False
        '
        'btnPlateDown6
        '
        Me.btnPlateDown6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPlateDown6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPlateDown6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlateDown6.ForeColor = System.Drawing.Color.Black
        Me.btnPlateDown6.Image = Global.CELLO.My.Resources.Resources.arrowdownR
        Me.btnPlateDown6.Location = New System.Drawing.Point(172, 390)
        Me.btnPlateDown6.Name = "btnPlateDown6"
        Me.btnPlateDown6.Size = New System.Drawing.Size(80, 41)
        Me.btnPlateDown6.TabIndex = 5
        Me.btnPlateDown6.Text = "Down"
        Me.btnPlateDown6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPlateDown6.UseVisualStyleBackColor = False
        '
        'btnPlateUp5
        '
        Me.btnPlateUp5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPlateUp5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPlateUp5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlateUp5.ForeColor = System.Drawing.Color.Black
        Me.btnPlateUp5.Image = Global.CELLO.My.Resources.Resources.arrowupR
        Me.btnPlateUp5.Location = New System.Drawing.Point(86, 346)
        Me.btnPlateUp5.Name = "btnPlateUp5"
        Me.btnPlateUp5.Size = New System.Drawing.Size(80, 41)
        Me.btnPlateUp5.TabIndex = 4
        Me.btnPlateUp5.Text = "UP"
        Me.btnPlateUp5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPlateUp5.UseVisualStyleBackColor = False
        '
        'lblKg19Text
        '
        Me.lblKg19Text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKg19Text.ForeColor = System.Drawing.Color.Black
        Me.lblKg19Text.Location = New System.Drawing.Point(254, 109)
        Me.lblKg19Text.Name = "lblKg19Text"
        Me.lblKg19Text.Size = New System.Drawing.Size(45, 23)
        Me.lblKg19Text.TabIndex = 818
        Me.lblKg19Text.Text = "kg"
        '
        'btnPlateDown5
        '
        Me.btnPlateDown5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPlateDown5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPlateDown5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlateDown5.ForeColor = System.Drawing.Color.Black
        Me.btnPlateDown5.Image = Global.CELLO.My.Resources.Resources.arrowdownR
        Me.btnPlateDown5.Location = New System.Drawing.Point(86, 391)
        Me.btnPlateDown5.Name = "btnPlateDown5"
        Me.btnPlateDown5.Size = New System.Drawing.Size(80, 41)
        Me.btnPlateDown5.TabIndex = 4
        Me.btnPlateDown5.Text = "Down"
        Me.btnPlateDown5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPlateDown5.UseVisualStyleBackColor = False
        '
        'btnPlateUp4
        '
        Me.btnPlateUp4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPlateUp4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPlateUp4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlateUp4.ForeColor = System.Drawing.Color.Black
        Me.btnPlateUp4.Image = Global.CELLO.My.Resources.Resources.arrowupR
        Me.btnPlateUp4.Location = New System.Drawing.Point(3, 346)
        Me.btnPlateUp4.Name = "btnPlateUp4"
        Me.btnPlateUp4.Size = New System.Drawing.Size(80, 41)
        Me.btnPlateUp4.TabIndex = 3
        Me.btnPlateUp4.Text = "UP"
        Me.btnPlateUp4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPlateUp4.UseVisualStyleBackColor = False
        '
        'btnPlateDown4
        '
        Me.btnPlateDown4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPlateDown4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPlateDown4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlateDown4.ForeColor = System.Drawing.Color.Black
        Me.btnPlateDown4.Image = Global.CELLO.My.Resources.Resources.arrowdownR
        Me.btnPlateDown4.Location = New System.Drawing.Point(3, 391)
        Me.btnPlateDown4.Name = "btnPlateDown4"
        Me.btnPlateDown4.Size = New System.Drawing.Size(80, 41)
        Me.btnPlateDown4.TabIndex = 3
        Me.btnPlateDown4.Text = "Down"
        Me.btnPlateDown4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPlateDown4.UseVisualStyleBackColor = False
        '
        'lblKg16Text
        '
        Me.lblKg16Text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKg16Text.ForeColor = System.Drawing.Color.Black
        Me.lblKg16Text.Location = New System.Drawing.Point(254, 86)
        Me.lblKg16Text.Name = "lblKg16Text"
        Me.lblKg16Text.Size = New System.Drawing.Size(45, 23)
        Me.lblKg16Text.TabIndex = 818
        Me.lblKg16Text.Text = "kg"
        '
        'lblDA02Text
        '
        Me.lblDA02Text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDA02Text.ForeColor = System.Drawing.Color.Black
        Me.lblDA02Text.Location = New System.Drawing.Point(254, 10)
        Me.lblDA02Text.Name = "lblDA02Text"
        Me.lblDA02Text.Size = New System.Drawing.Size(45, 20)
        Me.lblDA02Text.TabIndex = 508
        Me.lblDA02Text.Text = "DA"
        '
        'lblDA05Text
        '
        Me.lblDA05Text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDA05Text.ForeColor = System.Drawing.Color.Black
        Me.lblDA05Text.Location = New System.Drawing.Point(254, 155)
        Me.lblDA05Text.Name = "lblDA05Text"
        Me.lblDA05Text.Size = New System.Drawing.Size(45, 23)
        Me.lblDA05Text.TabIndex = 508
        Me.lblDA05Text.Text = "DA"
        Me.lblDA05Text.Visible = False
        '
        'lblDA03Text
        '
        Me.lblDA03Text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDA03Text.ForeColor = System.Drawing.Color.Black
        Me.lblDA03Text.Location = New System.Drawing.Point(254, 65)
        Me.lblDA03Text.Name = "lblDA03Text"
        Me.lblDA03Text.Size = New System.Drawing.Size(45, 20)
        Me.lblDA03Text.TabIndex = 508
        Me.lblDA03Text.Text = "DA"
        '
        'lblKg17Text
        '
        Me.lblKg17Text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKg17Text.ForeColor = System.Drawing.Color.Black
        Me.lblKg17Text.Location = New System.Drawing.Point(254, 132)
        Me.lblKg17Text.Name = "lblKg17Text"
        Me.lblKg17Text.Size = New System.Drawing.Size(45, 23)
        Me.lblKg17Text.TabIndex = 817
        Me.lblKg17Text.Text = "kg"
        '
        'lblKgDA04Text
        '
        Me.lblKgDA04Text.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKgDA04Text.ForeColor = System.Drawing.Color.Black
        Me.lblKgDA04Text.Location = New System.Drawing.Point(254, 317)
        Me.lblKgDA04Text.Name = "lblKgDA04Text"
        Me.lblKgDA04Text.Size = New System.Drawing.Size(45, 26)
        Me.lblKgDA04Text.TabIndex = 806
        Me.lblKgDA04Text.Text = "kg/DA"
        '
        'lblKgDA01Text
        '
        Me.lblKgDA01Text.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKgDA01Text.ForeColor = System.Drawing.Color.Black
        Me.lblKgDA01Text.Location = New System.Drawing.Point(251, 181)
        Me.lblKgDA01Text.Name = "lblKgDA01Text"
        Me.lblKgDA01Text.Size = New System.Drawing.Size(45, 26)
        Me.lblKgDA01Text.TabIndex = 806
        Me.lblKgDA01Text.Text = "kg/DA"
        '
        'lblKgDA03Text
        '
        Me.lblKgDA03Text.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKgDA03Text.ForeColor = System.Drawing.Color.Black
        Me.lblKgDA03Text.Location = New System.Drawing.Point(251, 179)
        Me.lblKgDA03Text.Name = "lblKgDA03Text"
        Me.lblKgDA03Text.Size = New System.Drawing.Size(45, 26)
        Me.lblKgDA03Text.TabIndex = 806
        Me.lblKgDA03Text.Text = "kg/DA"
        '
        'lblmmCount03Text
        '
        Me.lblmmCount03Text.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmmCount03Text.ForeColor = System.Drawing.Color.Black
        Me.lblmmCount03Text.Location = New System.Drawing.Point(251, 280)
        Me.lblmmCount03Text.Name = "lblmmCount03Text"
        Me.lblmmCount03Text.Size = New System.Drawing.Size(55, 12)
        Me.lblmmCount03Text.TabIndex = 806
        Me.lblmmCount03Text.Text = "mm/Cnt"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblStepControlDelayText)
        Me.Panel1.Controls.Add(Me.txtControlDelayTime)
        Me.Panel1.Controls.Add(Me.lblTime01sText)
        Me.Panel1.Controls.Add(Me.txtThreshold)
        Me.Panel1.Controls.Add(Me.lblPercent05Text)
        Me.Panel1.Controls.Add(Me.lblKg18Text)
        Me.Panel1.Controls.Add(Me.txtThresholdPressRatio)
        Me.Panel1.Controls.Add(Me.lbl2stControlText)
        Me.Panel1.Controls.Add(Me.lbl1stControlText)
        Me.Panel1.Controls.Add(Me.lblCtrl1stRangeText)
        Me.Panel1.Controls.Add(Me.lblCtrl1stDivText)
        Me.Panel1.Controls.Add(Me.lblCtrl1stTimeText)
        Me.Panel1.Controls.Add(Me.txtCtrl2ndRange)
        Me.Panel1.Controls.Add(Me.txtThresholdPressDiv)
        Me.Panel1.Controls.Add(Me.txtCtrl1stDiv)
        Me.Panel1.Controls.Add(Me.txtCtrl1stRange)
        Me.Panel1.Controls.Add(Me.txtCtrl2ndtTime)
        Me.Panel1.Controls.Add(Me.txtCtrl1stTime)
        Me.Panel1.Controls.Add(Me.lblPer11Text)
        Me.Panel1.Controls.Add(Me.lblPer10Text)
        Me.Panel1.Controls.Add(Me.lblSec02Text)
        Me.Panel1.Controls.Add(Me.lblSec01Text)
        Me.Panel1.Controls.Add(Me.lblThresholdText)
        Me.Panel1.Controls.Add(Me.lblThresholdPressRatioText)
        Me.Panel1.Location = New System.Drawing.Point(698, 44)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(296, 238)
        Me.Panel1.TabIndex = 948
        Me.Panel1.Visible = False
        '
        'lblStepControlDelayText
        '
        Me.lblStepControlDelayText.BackColor = System.Drawing.Color.Transparent
        Me.lblStepControlDelayText.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStepControlDelayText.ForeColor = System.Drawing.Color.Black
        Me.lblStepControlDelayText.Location = New System.Drawing.Point(5, 110)
        Me.lblStepControlDelayText.Name = "lblStepControlDelayText"
        Me.lblStepControlDelayText.Size = New System.Drawing.Size(106, 50)
        Me.lblStepControlDelayText.TabIndex = 857
        Me.lblStepControlDelayText.Text = "控壓分段延遲時間:"
        Me.lblStepControlDelayText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtControlDelayTime
        '
        Me.txtControlDelayTime.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtControlDelayTime.Location = New System.Drawing.Point(117, 126)
        Me.txtControlDelayTime.Name = "txtControlDelayTime"
        Me.txtControlDelayTime.Size = New System.Drawing.Size(60, 26)
        Me.txtControlDelayTime.TabIndex = 856
        Me.txtControlDelayTime.Text = "10"
        Me.txtControlDelayTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTime01sText
        '
        Me.lblTime01sText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime01sText.ForeColor = System.Drawing.Color.Black
        Me.lblTime01sText.Location = New System.Drawing.Point(183, 129)
        Me.lblTime01sText.Name = "lblTime01sText"
        Me.lblTime01sText.Size = New System.Drawing.Size(47, 16)
        Me.lblTime01sText.TabIndex = 858
        Me.lblTime01sText.Text = "x0.1s"
        '
        'txtThreshold
        '
        Me.txtThreshold.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtThreshold.Location = New System.Drawing.Point(117, 161)
        Me.txtThreshold.Name = "txtThreshold"
        Me.txtThreshold.Size = New System.Drawing.Size(76, 26)
        Me.txtThreshold.TabIndex = 527
        Me.txtThreshold.Text = "1500"
        Me.txtThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPercent05Text
        '
        Me.lblPercent05Text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercent05Text.ForeColor = System.Drawing.Color.Black
        Me.lblPercent05Text.Location = New System.Drawing.Point(195, 196)
        Me.lblPercent05Text.Name = "lblPercent05Text"
        Me.lblPercent05Text.Size = New System.Drawing.Size(26, 26)
        Me.lblPercent05Text.TabIndex = 508
        Me.lblPercent05Text.Text = "%"
        '
        'lblKg18Text
        '
        Me.lblKg18Text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKg18Text.ForeColor = System.Drawing.Color.Black
        Me.lblKg18Text.Location = New System.Drawing.Point(195, 161)
        Me.lblKg18Text.Name = "lblKg18Text"
        Me.lblKg18Text.Size = New System.Drawing.Size(27, 26)
        Me.lblKg18Text.TabIndex = 508
        Me.lblKg18Text.Text = "kg"
        '
        'txtThresholdPressRatio
        '
        Me.txtThresholdPressRatio.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtThresholdPressRatio.Location = New System.Drawing.Point(117, 195)
        Me.txtThresholdPressRatio.Name = "txtThresholdPressRatio"
        Me.txtThresholdPressRatio.Size = New System.Drawing.Size(76, 26)
        Me.txtThresholdPressRatio.TabIndex = 527
        Me.txtThresholdPressRatio.Text = "100"
        Me.txtThresholdPressRatio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl2stControlText
        '
        Me.lbl2stControlText.BackColor = System.Drawing.Color.Transparent
        Me.lbl2stControlText.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2stControlText.ForeColor = System.Drawing.Color.Black
        Me.lbl2stControlText.Location = New System.Drawing.Point(205, 1)
        Me.lbl2stControlText.Name = "lbl2stControlText"
        Me.lbl2stControlText.Size = New System.Drawing.Size(75, 26)
        Me.lbl2stControlText.TabIndex = 317
        Me.lbl2stControlText.Text = "第二段:"
        Me.lbl2stControlText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl1stControlText
        '
        Me.lbl1stControlText.BackColor = System.Drawing.Color.Transparent
        Me.lbl1stControlText.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1stControlText.ForeColor = System.Drawing.Color.Black
        Me.lbl1stControlText.Location = New System.Drawing.Point(107, 1)
        Me.lbl1stControlText.Name = "lbl1stControlText"
        Me.lbl1stControlText.Size = New System.Drawing.Size(67, 26)
        Me.lbl1stControlText.TabIndex = 317
        Me.lbl1stControlText.Text = "第一段:"
        Me.lbl1stControlText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCtrl1stRangeText
        '
        Me.lblCtrl1stRangeText.BackColor = System.Drawing.Color.Transparent
        Me.lblCtrl1stRangeText.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCtrl1stRangeText.ForeColor = System.Drawing.Color.Black
        Me.lblCtrl1stRangeText.Location = New System.Drawing.Point(31, 27)
        Me.lblCtrl1stRangeText.Name = "lblCtrl1stRangeText"
        Me.lblCtrl1stRangeText.Size = New System.Drawing.Size(80, 26)
        Me.lblCtrl1stRangeText.TabIndex = 317
        Me.lblCtrl1stRangeText.Text = "控壓範圍:"
        Me.lblCtrl1stRangeText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCtrl1stDivText
        '
        Me.lblCtrl1stDivText.BackColor = System.Drawing.Color.Transparent
        Me.lblCtrl1stDivText.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCtrl1stDivText.ForeColor = System.Drawing.Color.Black
        Me.lblCtrl1stDivText.Location = New System.Drawing.Point(31, 87)
        Me.lblCtrl1stDivText.Name = "lblCtrl1stDivText"
        Me.lblCtrl1stDivText.Size = New System.Drawing.Size(80, 26)
        Me.lblCtrl1stDivText.TabIndex = 317
        Me.lblCtrl1stDivText.Text = "壓速除數:"
        Me.lblCtrl1stDivText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCtrl1stTimeText
        '
        Me.lblCtrl1stTimeText.BackColor = System.Drawing.Color.Transparent
        Me.lblCtrl1stTimeText.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCtrl1stTimeText.ForeColor = System.Drawing.Color.Black
        Me.lblCtrl1stTimeText.Location = New System.Drawing.Point(31, 58)
        Me.lblCtrl1stTimeText.Name = "lblCtrl1stTimeText"
        Me.lblCtrl1stTimeText.Size = New System.Drawing.Size(80, 26)
        Me.lblCtrl1stTimeText.TabIndex = 317
        Me.lblCtrl1stTimeText.Text = "間隔時間:"
        Me.lblCtrl1stTimeText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCtrl2ndRange
        '
        Me.txtCtrl2ndRange.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtrl2ndRange.Location = New System.Drawing.Point(211, 27)
        Me.txtCtrl2ndRange.Name = "txtCtrl2ndRange"
        Me.txtCtrl2ndRange.Size = New System.Drawing.Size(60, 26)
        Me.txtCtrl2ndRange.TabIndex = 21
        Me.txtCtrl2ndRange.Text = "5"
        Me.txtCtrl2ndRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtThresholdPressDiv
        '
        Me.txtThresholdPressDiv.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtThresholdPressDiv.Location = New System.Drawing.Point(211, 91)
        Me.txtThresholdPressDiv.Name = "txtThresholdPressDiv"
        Me.txtThresholdPressDiv.Size = New System.Drawing.Size(60, 26)
        Me.txtThresholdPressDiv.TabIndex = 21
        Me.txtThresholdPressDiv.Text = "10"
        Me.txtThresholdPressDiv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCtrl1stDiv
        '
        Me.txtCtrl1stDiv.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtrl1stDiv.Location = New System.Drawing.Point(117, 91)
        Me.txtCtrl1stDiv.Name = "txtCtrl1stDiv"
        Me.txtCtrl1stDiv.Size = New System.Drawing.Size(60, 26)
        Me.txtCtrl1stDiv.TabIndex = 21
        Me.txtCtrl1stDiv.Text = "2"
        Me.txtCtrl1stDiv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCtrl1stRange
        '
        Me.txtCtrl1stRange.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtrl1stRange.Location = New System.Drawing.Point(117, 27)
        Me.txtCtrl1stRange.Name = "txtCtrl1stRange"
        Me.txtCtrl1stRange.Size = New System.Drawing.Size(60, 26)
        Me.txtCtrl1stRange.TabIndex = 21
        Me.txtCtrl1stRange.Text = "15"
        Me.txtCtrl1stRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCtrl2ndtTime
        '
        Me.txtCtrl2ndtTime.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtrl2ndtTime.Location = New System.Drawing.Point(211, 60)
        Me.txtCtrl2ndtTime.Name = "txtCtrl2ndtTime"
        Me.txtCtrl2ndtTime.Size = New System.Drawing.Size(60, 26)
        Me.txtCtrl2ndtTime.TabIndex = 21
        Me.txtCtrl2ndtTime.Text = "4"
        Me.txtCtrl2ndtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCtrl1stTime
        '
        Me.txtCtrl1stTime.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtrl1stTime.Location = New System.Drawing.Point(117, 60)
        Me.txtCtrl1stTime.Name = "txtCtrl1stTime"
        Me.txtCtrl1stTime.Size = New System.Drawing.Size(60, 26)
        Me.txtCtrl1stTime.TabIndex = 21
        Me.txtCtrl1stTime.Text = "2"
        Me.txtCtrl1stTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPer11Text
        '
        Me.lblPer11Text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPer11Text.ForeColor = System.Drawing.Color.Black
        Me.lblPer11Text.Location = New System.Drawing.Point(270, 29)
        Me.lblPer11Text.Name = "lblPer11Text"
        Me.lblPer11Text.Size = New System.Drawing.Size(27, 26)
        Me.lblPer11Text.TabIndex = 508
        Me.lblPer11Text.Text = "%"
        '
        'lblPer10Text
        '
        Me.lblPer10Text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPer10Text.ForeColor = System.Drawing.Color.Black
        Me.lblPer10Text.Location = New System.Drawing.Point(183, 27)
        Me.lblPer10Text.Name = "lblPer10Text"
        Me.lblPer10Text.Size = New System.Drawing.Size(27, 26)
        Me.lblPer10Text.TabIndex = 508
        Me.lblPer10Text.Text = "%"
        Me.lblPer10Text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSec02Text
        '
        Me.lblSec02Text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSec02Text.ForeColor = System.Drawing.Color.Black
        Me.lblSec02Text.Location = New System.Drawing.Point(271, 58)
        Me.lblSec02Text.Name = "lblSec02Text"
        Me.lblSec02Text.Size = New System.Drawing.Size(27, 26)
        Me.lblSec02Text.TabIndex = 508
        Me.lblSec02Text.Text = "s"
        '
        'lblSec01Text
        '
        Me.lblSec01Text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSec01Text.ForeColor = System.Drawing.Color.Black
        Me.lblSec01Text.Location = New System.Drawing.Point(183, 55)
        Me.lblSec01Text.Name = "lblSec01Text"
        Me.lblSec01Text.Size = New System.Drawing.Size(27, 26)
        Me.lblSec01Text.TabIndex = 508
        Me.lblSec01Text.Text = "s"
        '
        'lblThresholdText
        '
        Me.lblThresholdText.BackColor = System.Drawing.Color.Transparent
        Me.lblThresholdText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThresholdText.ForeColor = System.Drawing.Color.Black
        Me.lblThresholdText.Location = New System.Drawing.Point(10, 162)
        Me.lblThresholdText.Name = "lblThresholdText"
        Me.lblThresholdText.Size = New System.Drawing.Size(106, 26)
        Me.lblThresholdText.TabIndex = 528
        Me.lblThresholdText.Text = "壓力分界值:"
        Me.lblThresholdText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblThresholdPressRatioText
        '
        Me.lblThresholdPressRatioText.BackColor = System.Drawing.Color.Transparent
        Me.lblThresholdPressRatioText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThresholdPressRatioText.ForeColor = System.Drawing.Color.Black
        Me.lblThresholdPressRatioText.Location = New System.Drawing.Point(4, 195)
        Me.lblThresholdPressRatioText.Name = "lblThresholdPressRatioText"
        Me.lblThresholdPressRatioText.Size = New System.Drawing.Size(108, 26)
        Me.lblThresholdPressRatioText.TabIndex = 528
        Me.lblThresholdPressRatioText.Text = "加壓比率:"
        Me.lblThresholdPressRatioText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'flwPressPID
        '
        Me.flwPressPID.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flwPressPID.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.flwPressPID.Location = New System.Drawing.Point(698, 42)
        Me.flwPressPID.Name = "flwPressPID"
        Me.flwPressPID.Size = New System.Drawing.Size(300, 243)
        Me.flwPressPID.TabIndex = 949
        '
        'tabPageIniEdit
        '
        Me.tabPageIniEdit.Controls.Add(Me.ControlINIEdit1)
        Me.tabPageIniEdit.Location = New System.Drawing.Point(4, 44)
        Me.tabPageIniEdit.Name = "tabPageIniEdit"
        Me.tabPageIniEdit.Size = New System.Drawing.Size(1002, 494)
        Me.tabPageIniEdit.TabIndex = 4
        Me.tabPageIniEdit.Text = "設定檔編輯"
        Me.tabPageIniEdit.UseVisualStyleBackColor = True
        '
        'ControlINIEdit1
        '
        Me.ControlINIEdit1.AutoSize = True
        Me.ControlINIEdit1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ControlINIEdit1.Location = New System.Drawing.Point(4, 3)
        Me.ControlINIEdit1.Name = "ControlINIEdit1"
        Me.ControlINIEdit1.Size = New System.Drawing.Size(982, 475)
        Me.ControlINIEdit1.TabIndex = 0
        '
        'TabPageTempCalTool
        '
        Me.TabPageTempCalTool.Controls.Add(Me.chkDa)
        Me.TabPageTempCalTool.Controls.Add(Me.Label1)
        Me.TabPageTempCalTool.Controls.Add(Me.txtTICComport)
        Me.TabPageTempCalTool.Controls.Add(Me.chkTICMonitorUsed)
        Me.TabPageTempCalTool.Location = New System.Drawing.Point(4, 44)
        Me.TabPageTempCalTool.Name = "TabPageTempCalTool"
        Me.TabPageTempCalTool.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageTempCalTool.Size = New System.Drawing.Size(1002, 494)
        Me.TabPageTempCalTool.TabIndex = 5
        Me.TabPageTempCalTool.Text = "校溫工具"
        Me.TabPageTempCalTool.UseVisualStyleBackColor = True
        '
        'chkDa
        '
        Me.chkDa.AutoSize = True
        Me.chkDa.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.chkDa.Location = New System.Drawing.Point(757, 93)
        Me.chkDa.Name = "chkDa"
        Me.chkDa.Size = New System.Drawing.Size(63, 17)
        Me.chkDa.TabIndex = 954
        Me.chkDa.Text = "DALog"
        Me.chkDa.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(712, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 31)
        Me.Label1.TabIndex = 520
        Me.Label1.Text = "連線通訊埠號:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTICComport
        '
        Me.txtTICComport.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTICComport.Location = New System.Drawing.Point(876, 40)
        Me.txtTICComport.Name = "txtTICComport"
        Me.txtTICComport.Size = New System.Drawing.Size(43, 26)
        Me.txtTICComport.TabIndex = 519
        Me.txtTICComport.Text = "2"
        Me.txtTICComport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chkTICMonitorUsed
        '
        Me.chkTICMonitorUsed.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTICMonitorUsed.Location = New System.Drawing.Point(715, 6)
        Me.chkTICMonitorUsed.Name = "chkTICMonitorUsed"
        Me.chkTICMonitorUsed.Size = New System.Drawing.Size(204, 26)
        Me.chkTICMonitorUsed.TabIndex = 517
        Me.chkTICMonitorUsed.Text = "使用溫度監視功能"
        Me.chkTICMonitorUsed.UseVisualStyleBackColor = True
        '
        'tabpageCycleRun
        '
        Me.tabpageCycleRun.Controls.Add(Me.CYCLETime)
        Me.tabpageCycleRun.Controls.Add(Me.RUNTime)
        Me.tabpageCycleRun.Controls.Add(Me.txtCR_Timer)
        Me.tabpageCycleRun.Controls.Add(Me.txtC_Timer)
        Me.tabpageCycleRun.Controls.Add(Me.BondCycleDoorChk)
        Me.tabpageCycleRun.Controls.Add(Me.lblBondCycles3)
        Me.tabpageCycleRun.Controls.Add(Me.lblBondCycles2)
        Me.tabpageCycleRun.Controls.Add(Me.lblBondCycles1)
        Me.tabpageCycleRun.Controls.Add(Me.btnCycleRun3)
        Me.tabpageCycleRun.Controls.Add(Me.btnCycleRun2)
        Me.tabpageCycleRun.Controls.Add(Me.btnCycleRun1)
        Me.tabpageCycleRun.Controls.Add(Me.BondCycleTitle3)
        Me.tabpageCycleRun.Controls.Add(Me.BondCycleTitle2)
        Me.tabpageCycleRun.Controls.Add(Me.BondCycleTitle1)
        Me.tabpageCycleRun.Controls.Add(Me.pnl6Plate1)
        Me.tabpageCycleRun.Controls.Add(Me.btnPlateDownACR3)
        Me.tabpageCycleRun.Controls.Add(Me.btnPlateUpACR3)
        Me.tabpageCycleRun.Controls.Add(Me.btnPlateDownACR2)
        Me.tabpageCycleRun.Controls.Add(Me.btnPlateUpACR2)
        Me.tabpageCycleRun.Controls.Add(Me.btnPlateDownACR1)
        Me.tabpageCycleRun.Controls.Add(Me.btnPlateUpACR1)
        Me.tabpageCycleRun.Location = New System.Drawing.Point(4, 44)
        Me.tabpageCycleRun.Name = "tabpageCycleRun"
        Me.tabpageCycleRun.Size = New System.Drawing.Size(1002, 494)
        Me.tabpageCycleRun.TabIndex = 6
        Me.tabpageCycleRun.Text = "CycleRun"
        Me.tabpageCycleRun.UseVisualStyleBackColor = True
        '
        'CYCLETime
        '
        Me.CYCLETime.Location = New System.Drawing.Point(249, 425)
        Me.CYCLETime.Name = "CYCLETime"
        Me.CYCLETime.Size = New System.Drawing.Size(202, 22)
        Me.CYCLETime.TabIndex = 863
        Me.CYCLETime.Text = "UP/DOWN動作次數"
        Me.CYCLETime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RUNTime
        '
        Me.RUNTime.Location = New System.Drawing.Point(249, 383)
        Me.RUNTime.Name = "RUNTime"
        Me.RUNTime.Size = New System.Drawing.Size(202, 22)
        Me.RUNTime.TabIndex = 862
        Me.RUNTime.Text = "UP/DOWN動作秒數"
        Me.RUNTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCR_Timer
        '
        Me.txtCR_Timer.Location = New System.Drawing.Point(53, 422)
        Me.txtCR_Timer.Name = "txtCR_Timer"
        Me.txtCR_Timer.Size = New System.Drawing.Size(2, 29)
        Me.txtCR_Timer.TabIndex = 861
        Me.txtCR_Timer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtC_Timer
        '
        Me.txtC_Timer.Location = New System.Drawing.Point(53, 376)
        Me.txtC_Timer.Name = "txtC_Timer"
        Me.txtC_Timer.Size = New System.Drawing.Size(2, 29)
        Me.txtC_Timer.TabIndex = 860
        Me.txtC_Timer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BondCycleDoorChk
        '
        Me.BondCycleDoorChk.AutoSize = True
        Me.BondCycleDoorChk.Location = New System.Drawing.Point(53, 334)
        Me.BondCycleDoorChk.Name = "BondCycleDoorChk"
        Me.BondCycleDoorChk.Size = New System.Drawing.Size(291, 26)
        Me.BondCycleDoorChk.TabIndex = 859
        Me.BondCycleDoorChk.Text = "CycleRun時安全門是否要偵測"
        Me.BondCycleDoorChk.UseVisualStyleBackColor = True
        '
        'lblBondCycles3
        '
        Me.lblBondCycles3.BackColor = System.Drawing.Color.Black
        Me.lblBondCycles3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBondCycles3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBondCycles3.ForeColor = System.Drawing.Color.Lime
        Me.lblBondCycles3.Location = New System.Drawing.Point(350, 276)
        Me.lblBondCycles3.Name = "lblBondCycles3"
        Me.lblBondCycles3.Size = New System.Drawing.Size(125, 26)
        Me.lblBondCycles3.TabIndex = 858
        Me.lblBondCycles3.Text = "0"
        Me.lblBondCycles3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBondCycles2
        '
        Me.lblBondCycles2.BackColor = System.Drawing.Color.Black
        Me.lblBondCycles2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBondCycles2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBondCycles2.ForeColor = System.Drawing.Color.Lime
        Me.lblBondCycles2.Location = New System.Drawing.Point(196, 276)
        Me.lblBondCycles2.Name = "lblBondCycles2"
        Me.lblBondCycles2.Size = New System.Drawing.Size(125, 26)
        Me.lblBondCycles2.TabIndex = 857
        Me.lblBondCycles2.Text = "0"
        Me.lblBondCycles2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBondCycles1
        '
        Me.lblBondCycles1.BackColor = System.Drawing.Color.Black
        Me.lblBondCycles1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBondCycles1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBondCycles1.ForeColor = System.Drawing.Color.Lime
        Me.lblBondCycles1.Location = New System.Drawing.Point(45, 276)
        Me.lblBondCycles1.Name = "lblBondCycles1"
        Me.lblBondCycles1.Size = New System.Drawing.Size(125, 26)
        Me.lblBondCycles1.TabIndex = 856
        Me.lblBondCycles1.Text = "0"
        Me.lblBondCycles1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCycleRun3
        '
        Me.btnCycleRun3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCycleRun3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCycleRun3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCycleRun3.ForeColor = System.Drawing.Color.Black
        Me.btnCycleRun3.Location = New System.Drawing.Point(350, 219)
        Me.btnCycleRun3.Name = "btnCycleRun3"
        Me.btnCycleRun3.Size = New System.Drawing.Size(125, 41)
        Me.btnCycleRun3.TabIndex = 2
        Me.btnCycleRun3.Text = "CycleRun"
        Me.btnCycleRun3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCycleRun3.UseVisualStyleBackColor = False
        '
        'btnCycleRun2
        '
        Me.btnCycleRun2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCycleRun2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCycleRun2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCycleRun2.ForeColor = System.Drawing.Color.Black
        Me.btnCycleRun2.Location = New System.Drawing.Point(196, 219)
        Me.btnCycleRun2.Name = "btnCycleRun2"
        Me.btnCycleRun2.Size = New System.Drawing.Size(125, 41)
        Me.btnCycleRun2.TabIndex = 1
        Me.btnCycleRun2.Text = "CycleRun"
        Me.btnCycleRun2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCycleRun2.UseVisualStyleBackColor = False
        '
        'btnCycleRun1
        '
        Me.btnCycleRun1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCycleRun1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCycleRun1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCycleRun1.ForeColor = System.Drawing.Color.Black
        Me.btnCycleRun1.Location = New System.Drawing.Point(45, 219)
        Me.btnCycleRun1.Name = "btnCycleRun1"
        Me.btnCycleRun1.Size = New System.Drawing.Size(125, 41)
        Me.btnCycleRun1.TabIndex = 0
        Me.btnCycleRun1.Text = "CycleRun"
        Me.btnCycleRun1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCycleRun1.UseVisualStyleBackColor = False
        '
        'BondCycleTitle3
        '
        Me.BondCycleTitle3.AutoSize = True
        Me.BondCycleTitle3.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BondCycleTitle3.ForeColor = System.Drawing.Color.Lime
        Me.BondCycleTitle3.Location = New System.Drawing.Point(394, 49)
        Me.BondCycleTitle3.Name = "BondCycleTitle3"
        Me.BondCycleTitle3.Size = New System.Drawing.Size(34, 21)
        Me.BondCycleTitle3.TabIndex = 855
        Me.BondCycleTitle3.Text = "#3"
        '
        'BondCycleTitle2
        '
        Me.BondCycleTitle2.AutoSize = True
        Me.BondCycleTitle2.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BondCycleTitle2.ForeColor = System.Drawing.Color.Lime
        Me.BondCycleTitle2.Location = New System.Drawing.Point(241, 49)
        Me.BondCycleTitle2.Name = "BondCycleTitle2"
        Me.BondCycleTitle2.Size = New System.Drawing.Size(34, 21)
        Me.BondCycleTitle2.TabIndex = 854
        Me.BondCycleTitle2.Text = "#2"
        '
        'BondCycleTitle1
        '
        Me.BondCycleTitle1.AutoSize = True
        Me.BondCycleTitle1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BondCycleTitle1.ForeColor = System.Drawing.Color.Lime
        Me.BondCycleTitle1.Location = New System.Drawing.Point(90, 49)
        Me.BondCycleTitle1.Name = "BondCycleTitle1"
        Me.BondCycleTitle1.Size = New System.Drawing.Size(34, 21)
        Me.BondCycleTitle1.TabIndex = 853
        Me.BondCycleTitle1.Text = "#1"
        '
        'pnl6Plate1
        '
        Me.pnl6Plate1.Controls.Add(Me.lblBondCycles6)
        Me.pnl6Plate1.Controls.Add(Me.lblBondCycles5)
        Me.pnl6Plate1.Controls.Add(Me.lblBondCycles4)
        Me.pnl6Plate1.Controls.Add(Me.btnCycleRun6)
        Me.pnl6Plate1.Controls.Add(Me.btnCycleRun5)
        Me.pnl6Plate1.Controls.Add(Me.btnCycleRun4)
        Me.pnl6Plate1.Controls.Add(Me.BondCycleTitle6)
        Me.pnl6Plate1.Controls.Add(Me.BondCycleTitle5)
        Me.pnl6Plate1.Controls.Add(Me.BondCycleTitle4)
        Me.pnl6Plate1.Controls.Add(Me.btnPlateUpACR5)
        Me.pnl6Plate1.Controls.Add(Me.btnPlateDownACR6)
        Me.pnl6Plate1.Controls.Add(Me.btnPlateUpACR4)
        Me.pnl6Plate1.Controls.Add(Me.btnPlateUpACR6)
        Me.pnl6Plate1.Controls.Add(Me.btnPlateDownACR4)
        Me.pnl6Plate1.Controls.Add(Me.btnPlateDownACR5)
        Me.pnl6Plate1.Location = New System.Drawing.Point(503, 46)
        Me.pnl6Plate1.Name = "pnl6Plate1"
        Me.pnl6Plate1.Size = New System.Drawing.Size(460, 336)
        Me.pnl6Plate1.TabIndex = 852
        Me.pnl6Plate1.Visible = False
        '
        'lblBondCycles6
        '
        Me.lblBondCycles6.BackColor = System.Drawing.Color.Black
        Me.lblBondCycles6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBondCycles6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBondCycles6.ForeColor = System.Drawing.Color.Lime
        Me.lblBondCycles6.Location = New System.Drawing.Point(304, 230)
        Me.lblBondCycles6.Name = "lblBondCycles6"
        Me.lblBondCycles6.Size = New System.Drawing.Size(125, 26)
        Me.lblBondCycles6.TabIndex = 840
        Me.lblBondCycles6.Text = "0"
        Me.lblBondCycles6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBondCycles5
        '
        Me.lblBondCycles5.BackColor = System.Drawing.Color.Black
        Me.lblBondCycles5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBondCycles5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBondCycles5.ForeColor = System.Drawing.Color.Lime
        Me.lblBondCycles5.Location = New System.Drawing.Point(156, 230)
        Me.lblBondCycles5.Name = "lblBondCycles5"
        Me.lblBondCycles5.Size = New System.Drawing.Size(125, 26)
        Me.lblBondCycles5.TabIndex = 839
        Me.lblBondCycles5.Text = "0"
        Me.lblBondCycles5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBondCycles4
        '
        Me.lblBondCycles4.BackColor = System.Drawing.Color.Black
        Me.lblBondCycles4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBondCycles4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBondCycles4.ForeColor = System.Drawing.Color.Lime
        Me.lblBondCycles4.Location = New System.Drawing.Point(3, 230)
        Me.lblBondCycles4.Name = "lblBondCycles4"
        Me.lblBondCycles4.Size = New System.Drawing.Size(125, 26)
        Me.lblBondCycles4.TabIndex = 838
        Me.lblBondCycles4.Text = "0"
        Me.lblBondCycles4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCycleRun6
        '
        Me.btnCycleRun6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCycleRun6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCycleRun6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCycleRun6.ForeColor = System.Drawing.Color.Black
        Me.btnCycleRun6.Location = New System.Drawing.Point(304, 173)
        Me.btnCycleRun6.Name = "btnCycleRun6"
        Me.btnCycleRun6.Size = New System.Drawing.Size(125, 41)
        Me.btnCycleRun6.TabIndex = 5
        Me.btnCycleRun6.Text = "CycleRun"
        Me.btnCycleRun6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCycleRun6.UseVisualStyleBackColor = False
        '
        'btnCycleRun5
        '
        Me.btnCycleRun5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCycleRun5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCycleRun5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCycleRun5.ForeColor = System.Drawing.Color.Black
        Me.btnCycleRun5.Location = New System.Drawing.Point(156, 173)
        Me.btnCycleRun5.Name = "btnCycleRun5"
        Me.btnCycleRun5.Size = New System.Drawing.Size(125, 41)
        Me.btnCycleRun5.TabIndex = 4
        Me.btnCycleRun5.Text = "CycleRun"
        Me.btnCycleRun5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCycleRun5.UseVisualStyleBackColor = False
        '
        'btnCycleRun4
        '
        Me.btnCycleRun4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCycleRun4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCycleRun4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCycleRun4.ForeColor = System.Drawing.Color.Black
        Me.btnCycleRun4.Location = New System.Drawing.Point(3, 173)
        Me.btnCycleRun4.Name = "btnCycleRun4"
        Me.btnCycleRun4.Size = New System.Drawing.Size(125, 41)
        Me.btnCycleRun4.TabIndex = 3
        Me.btnCycleRun4.Text = "CycleRun"
        Me.btnCycleRun4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCycleRun4.UseVisualStyleBackColor = False
        '
        'BondCycleTitle6
        '
        Me.BondCycleTitle6.AutoSize = True
        Me.BondCycleTitle6.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BondCycleTitle6.ForeColor = System.Drawing.Color.Lime
        Me.BondCycleTitle6.Location = New System.Drawing.Point(348, 3)
        Me.BondCycleTitle6.Name = "BondCycleTitle6"
        Me.BondCycleTitle6.Size = New System.Drawing.Size(34, 21)
        Me.BondCycleTitle6.TabIndex = 12
        Me.BondCycleTitle6.Text = "#6"
        '
        'BondCycleTitle5
        '
        Me.BondCycleTitle5.AutoSize = True
        Me.BondCycleTitle5.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BondCycleTitle5.ForeColor = System.Drawing.Color.Lime
        Me.BondCycleTitle5.Location = New System.Drawing.Point(197, 3)
        Me.BondCycleTitle5.Name = "BondCycleTitle5"
        Me.BondCycleTitle5.Size = New System.Drawing.Size(34, 21)
        Me.BondCycleTitle5.TabIndex = 11
        Me.BondCycleTitle5.Text = "#5"
        '
        'BondCycleTitle4
        '
        Me.BondCycleTitle4.AutoSize = True
        Me.BondCycleTitle4.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BondCycleTitle4.ForeColor = System.Drawing.Color.Lime
        Me.BondCycleTitle4.Location = New System.Drawing.Point(45, 3)
        Me.BondCycleTitle4.Name = "BondCycleTitle4"
        Me.BondCycleTitle4.Size = New System.Drawing.Size(34, 21)
        Me.BondCycleTitle4.TabIndex = 10
        Me.BondCycleTitle4.Text = "#4"
        '
        'btnPlateUpACR5
        '
        Me.btnPlateUpACR5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPlateUpACR5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPlateUpACR5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlateUpACR5.ForeColor = System.Drawing.Color.Black
        Me.btnPlateUpACR5.Image = Global.CELLO.My.Resources.Resources.arrowupR
        Me.btnPlateUpACR5.Location = New System.Drawing.Point(156, 37)
        Me.btnPlateUpACR5.Name = "btnPlateUpACR5"
        Me.btnPlateUpACR5.Size = New System.Drawing.Size(125, 41)
        Me.btnPlateUpACR5.TabIndex = 4
        Me.btnPlateUpACR5.Text = "UP"
        Me.btnPlateUpACR5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPlateUpACR5.UseVisualStyleBackColor = False
        '
        'btnPlateDownACR6
        '
        Me.btnPlateDownACR6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPlateDownACR6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPlateDownACR6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlateDownACR6.ForeColor = System.Drawing.Color.Black
        Me.btnPlateDownACR6.Image = Global.CELLO.My.Resources.Resources.arrowdownR
        Me.btnPlateDownACR6.Location = New System.Drawing.Point(304, 106)
        Me.btnPlateDownACR6.Name = "btnPlateDownACR6"
        Me.btnPlateDownACR6.Size = New System.Drawing.Size(125, 41)
        Me.btnPlateDownACR6.TabIndex = 5
        Me.btnPlateDownACR6.Text = "Down"
        Me.btnPlateDownACR6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPlateDownACR6.UseVisualStyleBackColor = False
        '
        'btnPlateUpACR4
        '
        Me.btnPlateUpACR4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPlateUpACR4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPlateUpACR4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlateUpACR4.ForeColor = System.Drawing.Color.Black
        Me.btnPlateUpACR4.Image = Global.CELLO.My.Resources.Resources.arrowupR
        Me.btnPlateUpACR4.Location = New System.Drawing.Point(3, 37)
        Me.btnPlateUpACR4.Name = "btnPlateUpACR4"
        Me.btnPlateUpACR4.Size = New System.Drawing.Size(125, 41)
        Me.btnPlateUpACR4.TabIndex = 3
        Me.btnPlateUpACR4.Text = "UP"
        Me.btnPlateUpACR4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPlateUpACR4.UseVisualStyleBackColor = False
        '
        'btnPlateUpACR6
        '
        Me.btnPlateUpACR6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPlateUpACR6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPlateUpACR6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlateUpACR6.ForeColor = System.Drawing.Color.Black
        Me.btnPlateUpACR6.Image = Global.CELLO.My.Resources.Resources.arrowupR
        Me.btnPlateUpACR6.Location = New System.Drawing.Point(304, 37)
        Me.btnPlateUpACR6.Name = "btnPlateUpACR6"
        Me.btnPlateUpACR6.Size = New System.Drawing.Size(125, 41)
        Me.btnPlateUpACR6.TabIndex = 5
        Me.btnPlateUpACR6.Text = "UP"
        Me.btnPlateUpACR6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPlateUpACR6.UseVisualStyleBackColor = False
        '
        'btnPlateDownACR4
        '
        Me.btnPlateDownACR4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPlateDownACR4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPlateDownACR4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlateDownACR4.ForeColor = System.Drawing.Color.Black
        Me.btnPlateDownACR4.Image = Global.CELLO.My.Resources.Resources.arrowdownR
        Me.btnPlateDownACR4.Location = New System.Drawing.Point(3, 106)
        Me.btnPlateDownACR4.Name = "btnPlateDownACR4"
        Me.btnPlateDownACR4.Size = New System.Drawing.Size(125, 41)
        Me.btnPlateDownACR4.TabIndex = 3
        Me.btnPlateDownACR4.Text = "Down"
        Me.btnPlateDownACR4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPlateDownACR4.UseVisualStyleBackColor = False
        '
        'btnPlateDownACR5
        '
        Me.btnPlateDownACR5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPlateDownACR5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPlateDownACR5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlateDownACR5.ForeColor = System.Drawing.Color.Black
        Me.btnPlateDownACR5.Image = Global.CELLO.My.Resources.Resources.arrowdownR
        Me.btnPlateDownACR5.Location = New System.Drawing.Point(156, 106)
        Me.btnPlateDownACR5.Name = "btnPlateDownACR5"
        Me.btnPlateDownACR5.Size = New System.Drawing.Size(125, 41)
        Me.btnPlateDownACR5.TabIndex = 4
        Me.btnPlateDownACR5.Text = "Down"
        Me.btnPlateDownACR5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPlateDownACR5.UseVisualStyleBackColor = False
        '
        'btnPlateDownACR3
        '
        Me.btnPlateDownACR3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPlateDownACR3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPlateDownACR3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlateDownACR3.ForeColor = System.Drawing.Color.Black
        Me.btnPlateDownACR3.Image = Global.CELLO.My.Resources.Resources.arrowdownR
        Me.btnPlateDownACR3.Location = New System.Drawing.Point(350, 152)
        Me.btnPlateDownACR3.Name = "btnPlateDownACR3"
        Me.btnPlateDownACR3.Size = New System.Drawing.Size(125, 41)
        Me.btnPlateDownACR3.TabIndex = 2
        Me.btnPlateDownACR3.Text = "Down"
        Me.btnPlateDownACR3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPlateDownACR3.UseVisualStyleBackColor = False
        '
        'btnPlateUpACR3
        '
        Me.btnPlateUpACR3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPlateUpACR3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPlateUpACR3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlateUpACR3.ForeColor = System.Drawing.Color.Black
        Me.btnPlateUpACR3.Image = Global.CELLO.My.Resources.Resources.arrowupR
        Me.btnPlateUpACR3.Location = New System.Drawing.Point(350, 83)
        Me.btnPlateUpACR3.Name = "btnPlateUpACR3"
        Me.btnPlateUpACR3.Size = New System.Drawing.Size(125, 41)
        Me.btnPlateUpACR3.TabIndex = 2
        Me.btnPlateUpACR3.Text = "UP"
        Me.btnPlateUpACR3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPlateUpACR3.UseVisualStyleBackColor = False
        '
        'btnPlateDownACR2
        '
        Me.btnPlateDownACR2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPlateDownACR2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPlateDownACR2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlateDownACR2.ForeColor = System.Drawing.Color.Black
        Me.btnPlateDownACR2.Image = Global.CELLO.My.Resources.Resources.arrowdownR
        Me.btnPlateDownACR2.Location = New System.Drawing.Point(196, 152)
        Me.btnPlateDownACR2.Name = "btnPlateDownACR2"
        Me.btnPlateDownACR2.Size = New System.Drawing.Size(125, 41)
        Me.btnPlateDownACR2.TabIndex = 1
        Me.btnPlateDownACR2.Text = "Down"
        Me.btnPlateDownACR2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPlateDownACR2.UseVisualStyleBackColor = False
        '
        'btnPlateUpACR2
        '
        Me.btnPlateUpACR2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPlateUpACR2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPlateUpACR2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlateUpACR2.ForeColor = System.Drawing.Color.Black
        Me.btnPlateUpACR2.Image = Global.CELLO.My.Resources.Resources.arrowupR
        Me.btnPlateUpACR2.Location = New System.Drawing.Point(196, 83)
        Me.btnPlateUpACR2.Name = "btnPlateUpACR2"
        Me.btnPlateUpACR2.Size = New System.Drawing.Size(125, 41)
        Me.btnPlateUpACR2.TabIndex = 1
        Me.btnPlateUpACR2.Text = "UP"
        Me.btnPlateUpACR2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPlateUpACR2.UseVisualStyleBackColor = False
        '
        'btnPlateDownACR1
        '
        Me.btnPlateDownACR1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPlateDownACR1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPlateDownACR1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlateDownACR1.ForeColor = System.Drawing.Color.Black
        Me.btnPlateDownACR1.Image = Global.CELLO.My.Resources.Resources.arrowdownR
        Me.btnPlateDownACR1.Location = New System.Drawing.Point(45, 152)
        Me.btnPlateDownACR1.Name = "btnPlateDownACR1"
        Me.btnPlateDownACR1.Size = New System.Drawing.Size(125, 41)
        Me.btnPlateDownACR1.TabIndex = 0
        Me.btnPlateDownACR1.Text = "Down"
        Me.btnPlateDownACR1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPlateDownACR1.UseVisualStyleBackColor = False
        '
        'btnPlateUpACR1
        '
        Me.btnPlateUpACR1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPlateUpACR1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPlateUpACR1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlateUpACR1.ForeColor = System.Drawing.Color.Black
        Me.btnPlateUpACR1.Image = Global.CELLO.My.Resources.Resources.arrowupR
        Me.btnPlateUpACR1.Location = New System.Drawing.Point(45, 83)
        Me.btnPlateUpACR1.Name = "btnPlateUpACR1"
        Me.btnPlateUpACR1.Size = New System.Drawing.Size(125, 41)
        Me.btnPlateUpACR1.TabIndex = 0
        Me.btnPlateUpACR1.Text = "UP"
        Me.btnPlateUpACR1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPlateUpACR1.UseVisualStyleBackColor = False
        '
        'picCelloTitleEng
        '
        Me.picCelloTitleEng.Image = Global.CELLO.My.Resources.Resources.CELLO_CO_ENG
        Me.picCelloTitleEng.Location = New System.Drawing.Point(590, 64)
        Me.picCelloTitleEng.Name = "picCelloTitleEng"
        Me.picCelloTitleEng.Size = New System.Drawing.Size(430, 50)
        Me.picCelloTitleEng.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCelloTitleEng.TabIndex = 541
        Me.picCelloTitleEng.TabStop = False
        '
        'picCelloTitle
        '
        Me.picCelloTitle.Image = Global.CELLO.My.Resources.Resources.Cello_Co
        Me.picCelloTitle.Location = New System.Drawing.Point(375, 0)
        Me.picCelloTitle.Name = "picCelloTitle"
        Me.picCelloTitle.Size = New System.Drawing.Size(645, 65)
        Me.picCelloTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCelloTitle.TabIndex = 540
        Me.picCelloTitle.TabStop = False
        '
        'picCelloLogo
        '
        Me.picCelloLogo.Image = Global.CELLO.My.Resources.Resources.CELLOLOGO02
        Me.picCelloLogo.Location = New System.Drawing.Point(0, 0)
        Me.picCelloLogo.Name = "picCelloLogo"
        Me.picCelloLogo.Size = New System.Drawing.Size(138, 110)
        Me.picCelloLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCelloLogo.TabIndex = 539
        Me.picCelloLogo.TabStop = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(464, 4)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(541, 489)
        Me.FlowLayoutPanel1.TabIndex = 847
        '
        'Timer2
        '
        Me.Timer2.Interval = 10000
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(76, 71)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(69, 26)
        Me.Button3.TabIndex = 949
        Me.Button3.Text = "Print"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'FormParameter
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1024, 710)
        Me.ControlBox = False
        Me.Controls.Add(Me.picCelloTitleEng)
        Me.Controls.Add(Me.picCelloTitle)
        Me.Controls.Add(Me.picCelloLogo)
        Me.Controls.Add(Me.tabParameter)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(0, 50)
        Me.Name = "FormParameter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "ParameterSet"
        Me.pnlParaSet.ResumeLayout(False)
        Me.pnlParaSet.PerformLayout
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout
        Me.Panel2.ResumeLayout(False)
        Me.grpVacuum.ResumeLayout(False)
        Me.grpVacuum.PerformLayout
        Me.pnlDPWaterFlow.ResumeLayout(False)
        Me.pnlDPWaterFlow.PerformLayout
        Me.pnlDPTemp.ResumeLayout(False)
        Me.pnlDPTemp.PerformLayout
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit
        Me.grpProcessCondition.ResumeLayout(False)
        Me.grpProcessCondition.PerformLayout
        CType(Me.picC06, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.picC01, System.ComponentModel.ISupportInitialize).EndInit
        Me.grpAlarmSetup.ResumeLayout(False)
        Me.grpAlarmSetup.PerformLayout
        Me.pnlFlowShow.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.picC05, System.ComponentModel.ISupportInitialize).EndInit
        Me.grpPurgeSetup.ResumeLayout(False)
        Me.grpPurgeSetup.PerformLayout
        Me.grpPIDLoadSave.ResumeLayout(False)
        Me.grpPIDLoadSave.PerformLayout
        Me.tabParameter.ResumeLayout(False)
        Me.TabPageTIC.ResumeLayout(False)
        Me.TabPageTIC.PerformLayout
        Me.tabPIDSetup.ResumeLayout(False)
        Me.tabPage1to3.ResumeLayout(False)
        Me.tabPage4to6.ResumeLayout(False)
        Me.TabPageTCal.ResumeLayout(False)
        Me.pnlSplitTopBotTemp.ResumeLayout(False)
        Me.pnlSplitTopBotTemp.PerformLayout
        Me.TabPagePCal.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout
        Me.TabPageSystem.ResumeLayout(False)
        Me.TabPageCIM.ResumeLayout(False)
        Me.TabPageCello.ResumeLayout(False)
        Me.tabSystem.ResumeLayout(False)
        Me.tabpageTempCal.ResumeLayout(False)
        Me.pnlHeaterSetup.ResumeLayout(False)
        Me.pnlHeaterSetup.PerformLayout
        Me.tabpageVacuum.ResumeLayout(False)
        Me.grpFlowMeter.ResumeLayout(False)
        Me.grpFlowMeter.PerformLayout
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout
        Me.grpPumpType.ResumeLayout(False)
        Me.grpPumpType.PerformLayout
        CType(Me.picC02, System.ComponentModel.ISupportInitialize).EndInit
        Me.grpVacuumSetup.ResumeLayout(False)
        Me.grpVacuumSetup.PerformLayout
        Me.tabpagePressCal.ResumeLayout(False)
        Me.tabpagePressControl.ResumeLayout(False)
        Me.tabpagePressControl.PerformLayout
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout
        Me.pnlPressureAverage.ResumeLayout(False)
        Me.pnlPressureAverage.PerformLayout
        Me.pnl6Plate.ResumeLayout(False)
        Me.pnl6Plate.PerformLayout
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout
        Me.tabPageIniEdit.ResumeLayout(False)
        Me.tabPageIniEdit.PerformLayout
        Me.TabPageTempCalTool.ResumeLayout(False)
        Me.TabPageTempCalTool.PerformLayout
        Me.tabpageCycleRun.ResumeLayout(False)
        Me.tabpageCycleRun.PerformLayout
        Me.pnl6Plate1.ResumeLayout(False)
        Me.pnl6Plate1.PerformLayout
        CType(Me.picCelloTitleEng, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.picCelloTitle, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.picCelloLogo, System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub ParameterSetForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        If DesignMode Then Exit Sub
        Dim i As Integer
        Me.Top = FromStartUpTopPosition
        Me.Left = 0
        'Add By Vtncent 20220506  ----------------------------------------------------------  Start
        If SanAn_TCPIP_Used_Flag = False Then
            tabParameter.TabPages.RemoveByKey("TabPageCIM")
        End If

        'If TCPIP_Used Then
        'tabParameter.TabPages.RemoveByKey("TabPageCIM")
        'End If
        'Add By Vtncent 20220506  ----------------------------------------------------------  End

        'FormTextBoxSave.SetTextBox(Me, Me.Name, FormSaveINIFile)
        For i = 0 To MAXPLATE
            FormTextBoxSave.SetTextBox(TempCal(i), TempCal(i).Name, FormSaveINIFile)
            FormTextBoxSave.SetTextBox(PressCal(i), PressCal(i).Name, FormSaveINIFile)
            'FormTextBoxSave.SetTextBox(PIDs(i), PIDs(i).Name, FormSaveINIFile)
        Next

        '電阻尺
        If Resistance_ruler_Flag = False Then
            txtRullerLength.Visible = False
            lblRullerLengthText.Visible = False
            Label5.Visible = False
        Else
            txtRullerLength.Visible = True
            lblRullerLengthText.Visible = True
            Label5.Visible = True
        End If

        LoadParameterToForm()        '載入參數到表單內
        radDryPump.Checked = DP_Pump_Used
        radUlvacLS120.Checked = Ulvac_LS120_Used
        If DP_Pump_Used = False And Ulvac_LS120_Used = False Then
            radMachinePump.Checked = True
        End If
        lblProcessAutoVacuumText.Visible = DP_Pump_Used
        btnProcessAutoVacuum.Visible = DP_Pump_Used
        'TempTab1 = New TabPage
        'TempTab1 = tabParameter.TabPages("TabPageCello")
        'tabParameter.TabPages.RemoveByKey("TabPageCello")
        pnlDPTemp.Visible = DP_Pump_Used
        txtDPTempAlarmText.Visible = DP_Pump_Used
        txtDPTempAlarmOff.Visible = DP_Pump_Used
        txtDPTempCalSet.Visible = DP_Pump_Used
        txtDPTempAlarmText.Text = Get_PLC_R1100(DADPOverTempIndex).ToString
        txtDPTempAlarmOff.Text = Get_PLC_R1100(DADPOverTempOFFIndex).ToString
        txtDPTempCalSet.Text = Get_PLC_R1100(DADPTempOffsetIndex).ToString

        TempTab1 = New TabPage
        TempTab1 = tabParameter.TabPages("TabPageCello")
        tabParameter.TabPages.RemoveByKey("TabPageCello")

        pnlFlowShow.Visible = FlowMeterMode

        txtOutRangAddDA1.Text = Get_PLC_R1100(DAOutRangAddDA1Index).ToString
        txtOutRangAddDA2.Text = Get_PLC_R1100(DAOutRangAddDA2Index).ToString
        txtOutRangAddDA3.Text = Get_PLC_R1100(DAOutRangAddDA3Index).ToString
        'txtOutRangAddDA4.Text = Get_PLC_R1100(DAOutRangAddDA4Index).ToString
        'txtOutRangAddDA5.Text = Get_PLC_R1100(DAOutRangAddDA5Index).ToString
        'txtOutRangAddDA6.Text = Get_PLC_R1100(DAOutRangAddDA6Index).ToString

        'tabSystem.TabPages("TabPageTempCalTool").Controls.Add(ControlADAM4118s)'動態載入From Page

        'tabSystem.TabPages("TabPageTempCalTool").Controls.Add(ControlADAM4018_Modbuss) '動態載入From Page

        chkTICMonitorUsed.Checked = TIC_MONITOR_USED

        radGP275.Checked = (GaugeName = "GP275")
        radAP2004.Checked = (GaugeName = "AP2004")
        radZSE40.Checked = (GaugeName = "ZSE40")
        radAPG100.Checked = (GaugeName = "APG100")
        radPCG550.Checked = (GaugeName = "PCG550")
        radPSG500.Checked = (GaugeName = "PSG500")

        'Add  by Vincent 20181016  壓力修整功能 ------------------- Start
        txtPressureAverageTimes.Text = SystemParameters.PressureAverageTimes
        rdoPressureAverage.Checked = GetTrue01Boolean(SystemParameters.PressureAverageEnable)
        rdoPeakClear.Checked = GetTrue01Boolean(SystemParameters.PeakClearEnable)
        chkPressureAdjust.Checked = GetTrue01Boolean(SystemParameters.PressureAdjust)
        txtPeakLimit.Text = SystemParameters.PeakLimit
        txtPeakTimes.Text = SystemParameters.PeakTimes
        'Add  by Vincent 20181016  壓力修整功能 ------------------- End

        'Add By Vincent 20190710  ----------------------------------------------------------  Start
        CtlSanAnCIMSetup1.txtMachineNo.Text = RemoteCIM._MachineNo

        txtPullerTime.Text = PULLERTIME
        txtDoorCloseTime.Text = DOORTIME
        txtProcessPumpTime.Text = PUMPINGTIME
        txtProcessPumpVacuum.Text = PUMPINGVACUUM

        txtVentOffDelay.Text = SystemParameters.VentOffDelay  'Add  by Vincent 20210318
        txtRPOnPressure.Text = SystemParameters.RPONPressure  'Add  by Vincent 20210318
        txtDPWaterFlowHz.Text = SystemParameters.DPWaterFlowHz  'Add  by Vincent 20210318
        txtDPWaterFlowMax.Text = SystemParameters.DPWaterFlowHzMax  'Add  by Vincent 20210318
        txtDPWaterFlowAlarm.Text = SystemParameters.DPWaterFlowAlarm  'Add  by Vincent 20210318
        dudLogStartTime.Text = SystemParameters.StartLog_Time 'add by claire 2023.0620
        pnlDPTemp.Visible = DP_Pump_Used
        pnlDPWaterFlow.Visible = DP_Flow_Used
        chkCIMUsed.Checked = CIM_Used
        chkAvailBarCode.Checked = BarCodeFile_Flag
        If SanAn_TCPIP_Used_Flag = False Then
            tabParameter.TabPages.RemoveByKey("TabPageCIM")
        End If

        'If CIM_Used = False Then
        'tabParameter.TabPages.RemoveByKey("TabPageCIM")
        'End If
        'Add By Vincent 20190710  ----------------------------------------------------------  End
        chkDa.Checked = SystemParameters.bolDAlog

        Timer1.Interval = 300
        Timer1.Enabled = True
    End Sub

#Region "載入參數到表單內"
    Private Sub LoadParameterToForm()
        Dim i As Integer


        txtLowFlowAlarm.Text = SystemParameters.LowFlowAlarm
        txtkgDARatio1.Text = SystemParameters.KgDARatio
        txtCtrl1stRange.Text = SystemParameters.Ctrl1stRange
        txtCtrl1stTime.Text = SystemParameters.Ctrl1stTime
        txtCtrl2ndRange.Text = SystemParameters.Ctrl2ndtRange
        txtCtrl2ndtTime.Text = SystemParameters.Ctrl2ndtTime
        txtCtrl1stDiv.Text = SystemParameters.Ctrl1stDiv
        txtThreshold.Text = SystemParameters.ThresholdPress
        txtThresholdPressDiv.Text = SystemParameters.ThresholdPressDiv
        txtThresholdPressRatio.Text = SystemParameters.ThresholdPressRatio
        txtPressAverage.Text = SystemParameters.PressAverage
        txtPlateUpContactKg.Text = SystemParameters.PlateUpPreset
        txtPress1st.Text = SystemParameters.Press1st
        txtPress2nd1.Text = SystemParameters.Press2nd
        txtPress3rd1.Text = SystemParameters.Press3rd
        txtDpCurrentLimit.Text = SystemParameters.PumpCurrentLimit
        txtCoolingTemp.Text = SystemParameters.CoolingTemperature
        txtHiTempLimit.Text = SystemParameters.HighTempLimit
        txtHiPressureLimit.Text = SystemParameters.HighPressureLimit


        txtPumpTime.Text = SystemParameters.PumpingTime
        txtProcessEndBZonTime.Text = SystemParameters.ProcessEndBZonTime
        txtPressureRange.Text = SystemParameters.PressureRange
        txtTempRange.Text = SystemParameters.ProcessTempRange
        txtPurgeCycle.Text = SystemParameters.AutoPurgeCycle
        txtPurgeONTime.Text = SystemParameters.AutoPurgeOnTime
        txtPurgeOFFTime.Text = SystemParameters.AutoPurgeOFFTime
        txtProcessVacSet.Text = SystemParameters.ProcessVacuumAutoVac
        txtProcessVacSetLo.Text = SystemParameters.ProcessVacuumAutoVacLo
        txtVentTime.Text = SystemParameters.VentTime
        CAutoPumping.AutoProtection = True
        CAutoPumping.SetBasePressure(CAutoPumping.AutoProtection, Val(SystemParameters.ProcessVacuumAutoVac), Val(SystemParameters.ProcessVacuumAutoVacLo))



        ProcessOkALMEnabled_Status = GetTrue01Boolean(SystemParameters.ProcessEndAlarm)
        ProcessAutoVacuum_Status = GetTrue01Boolean(SystemParameters.ProcessAutoVacuum)
        txtCHVacOffsetVoltage.Text = GaugeCHVacOffsetVoltage.ToString
        txt1ATMVac.Text = Vac1ATM.ToString


        txtTempAlarmTime.Text = TOPTEMPRUNTIME.ToString
        txtPressAlarmTime.Text = BONDFORCETIME.ToString

        txtProcessTempAlarmTime.Text = PROCESSTOPTEMPTIME.ToString
        txtProcessPressAlarmTime.Text = PROCESSBONDFORCETIME.ToString

        txtHeaterAlarmTime.Text = CURRENTMONITORTIME.ToString

        txtRVONDelay.Text = CAutoPumping.SetRV_ON_Time

        SetVisible(MAXPLATE > 2, pnl6Plate)
        txtHeaterCount.Text = SystemParameters.HeaterCount
        txtHeaterPower.Text = SystemParameters.HeaterPower
        txtHeaterVoltage.Text = SystemParameters.HeaterVoltage
        txtHeaterMonitorPower.Text = SystemParameters.HeaterMonitorPower
        txtHeaterCurrentRate.Text = SystemParameters.HeaterCurrentRate



        If CommLivePLC Then
            txtPressureRange.Text = Get_PLC_R1100(DAPressOKRangeIndex).ToString

            txtThreshold.Text = Get_PLC_R1100(DAThresholdIndex).ToString
            txtThresholdPressRatio.Text = Get_PLC_R1100(DAThresholdRatioIndex).ToString
            txtCtrl1stRange.Text = Get_PLC_R1100(DAT1stControlKgIndex).ToString
            txtCtrl1stTime.Text = Format(Get_PLC_R1100(DAT1stControlTimeIndex) / 100, "0.00")
            txtCtrl2ndRange.Text = Get_PLC_R1100(DAT2ndControlKgIndex).ToString
            txtCtrl2ndtTime.Text = Format(Get_PLC_R1100(DAT2ndControlTimeIndex) / 100, "0.00")
            txtCtrl1stDiv.Text = Get_PLC_R1100(DAInRagePDiv1SetIndex).ToString
            txtThresholdPressDiv.Text = Get_PLC_R1100(DAInRagePDiv2SetIndex).ToString
            txtNoControlPress.Text = Get_PLC_R1100(DANoControlPresssIndex).ToString

            txtkgDARatio1.Text = Get_PLC_R1100(DAkgDARatio1Index).ToString
            txtkgDARatio2.Text = Get_PLC_R1100(DAkgDARatio2Index).ToString
            txtkgDARatio3.Text = Get_PLC_R1100(DAkgDARatio3Index).ToString
            txtkgDARatio4.Text = Get_PLC_R1100(DAkgDARatio4Index).ToString
            txtkgDARatio5.Text = Get_PLC_R1100(DAkgDARatio5Index).ToString
            txtkgDARatio6.Text = Get_PLC_R1100(DAkgDARatio6Index).ToString

            txtTopLowLimitTemp.Text = Get_PLC_R1100(DALimitPowerTempIndex).ToString
            txtTopLowLimitPower.Text = (Get_PLC_R1100(DALimitPowerIndex) / 10).ToString

            txtMaxTempPower.Text = (Get_PLC_R1100(DAMaxTempPowerIndex) / 10).ToString
            txtControlDelayTime.Text = Get_PLC_R1100(DAControlRangeTimeIndex).ToString
            txtHighPDAOut.Text = Get_PLC_R1100(DAHighDAIndex).ToString

            txtPress2nd1.Text = Get_PLC_R1100(DA2ndPress1Index).ToString
            txtPress2nd2.Text = Get_PLC_R1100(DA2ndPress2Index).ToString
            txtPress2nd3.Text = Get_PLC_R1100(DA2ndPress3Index).ToString
            txtPress2nd4.Text = Get_PLC_R1100(DA2ndPress4Index).ToString
            txtPress2nd5.Text = Get_PLC_R1100(DA2ndPress5Index).ToString
            txtPress2nd6.Text = Get_PLC_R1100(DA2ndPress6Index).ToString

            txtPress3rd1.Text = Get_PLC_R1100(DAPlateUpPressure1Index).ToString
            txtPress3rd2.Text = Get_PLC_R1100(DAPlateUpPressure2Index).ToString
            txtPress3rd3.Text = Get_PLC_R1100(DAPlateUpPressure3Index).ToString
            txtPress3rd4.Text = Get_PLC_R1100(DAPlateUpPressure4Index).ToString
            txtPress3rd5.Text = Get_PLC_R1100(DAPlateUpPressure5Index).ToString
            txtPress3rd6.Text = Get_PLC_R1100(DAPlateUpPressure6Index).ToString
            For i = 0 To MAXPLATE
                PressCal(i).txtFullScale.Text = Get_PLC_R1100(DAPressFullScaleIndex).ToString
            Next
        End If





        FormParameters.chkBarcodeOnly.Checked = GetTrue01Boolean(SystemParameters.BarcodeOnly)
        FormParameters.chkAutoRecordData.Checked = GetTrue01Boolean(SystemParameters.AutoRecordData)
        FormParameters.chkSplitTopBotTemp.Checked = GetTrue01Boolean(SystemParameters.SplitTopBotTemp)   'Add  by Vincent 20180419  ------------------- Start
        FormParameters.chkSplitTopBotTempEnable.Checked = GetTrue01Boolean(SystemParameters.SplitTopBotTempEnable)
        If FormParameters.chkSplitTopBotTempEnable.Checked Then
            FormParameters.pnlSplitTopBotTemp.Visible = True
        Else
            FormParameters.pnlSplitTopBotTemp.Visible = False
        End If
        FormParameters.chkRunConfirm.Checked = GetTrue01Boolean(SystemParameters.RunConfirm)
        FormParameters.txtWebPath.Text = SystemParameters.WebPath
        CalCurrent()


    End Sub
#End Region

#Region "參數儲存"

    Public Sub SaveParameter()
        Dim thread As New System.Threading.Thread(AddressOf SaveParameter_Thread)
        thread.Start()
    End Sub

    Public Sub SaveParameter_Thread()

        SystemParameters.LowFlowAlarm = txtLowFlowAlarm.Text

        SystemParameters.KgDARatio = txtkgDARatio1.Text

        SystemParameters.Ctrl1stRange = txtCtrl1stRange.Text
        SystemParameters.Ctrl1stTime = txtCtrl1stTime.Text
        SystemParameters.Ctrl2ndtRange = txtCtrl2ndRange.Text
        SystemParameters.Ctrl2ndtTime = txtCtrl2ndtTime.Text
        SystemParameters.Ctrl1stDiv = txtCtrl1stDiv.Text
        SystemParameters.ThresholdPress = txtThreshold.Text
        SystemParameters.ThresholdPressDiv = txtThresholdPressDiv.Text
        SystemParameters.ThresholdPressRatio = txtThresholdPressRatio.Text
        SystemParameters.PressAverage = txtPressAverage.Text

        SystemParameters.PlateUpPreset = txtPlateUpContactKg.Text
        SystemParameters.Press1st = txtPress1st.Text
        SystemParameters.Press2nd = txtPress2nd1.Text
        SystemParameters.Press3rd = txtPress3rd1.Text
        SystemParameters.PumpCurrentLimit = txtDpCurrentLimit.Text
        SystemParameters.PumpCurrentAlarmTime = txtDpCurrentAlarmTime.Text

        SystemParameters.CoolingTemperature = txtCoolingTemp.Text
        SystemParameters.HighTempLimit = txtHiTempLimit.Text
        SystemParameters.HighPressureLimit = txtHiPressureLimit.Text


        SystemParameters.PumpingTime = txtPumpTime.Text
        SystemParameters.ProcessEndBZonTime = txtProcessEndBZonTime.Text
        SystemParameters.ProcessEndAlarm = GetTrue01String(ProcessOkALMEnabled_Status)
        SystemParameters.PressureUnit = "0"

        SystemParameters.PressureRange = txtPressureRange.Text          '製程控壓範圍
        SystemParameters.ProcessTempRange = txtTempRange.Text           '製程控溫範圍

        SystemParameters.AutoPurgeCycle = txtPurgeCycle.Text
        SystemParameters.AutoPurgeOnTime = txtPurgeONTime.Text
        SystemParameters.AutoPurgeOFFTime = txtPurgeOFFTime.Text

        SystemParameters.ProcessVacuumAutoVac = txtProcessVacSet.Text
        SystemParameters.ProcessVacuumAutoVacLo = txtProcessVacSetLo.Text
        SystemParameters.VentTime = txtVentTime.Text

        SystemParameters.ProcessEndAlarm = GetTrue01String(ProcessOkALMEnabled_Status)
        'SystemParameters.AutoVacuum = GetTrue01String(AutoVacuum_Status)
        SystemParameters.ProcessAutoVacuum = GetTrue01String(ProcessAutoVacuum_Status)

        SystemParameters.Vac1ATM_Select = GetTrue01String(Vac1ATM_Select)

        'SystemParameters.AutoVent = GetTrue01String(AutoVent_Status)
        'SystemParameters.BondBeforeVacuum = GetTrue01String(BondBeforeVacuum_Status)
        'SystemParameters.AutoPurge = GetTrue01String(AutoPurge_Status)
        '--------------------------------------------------------------------------------------



        SystemParameters.HeaterCount = txtHeaterCount.Text
        SystemParameters.HeaterPower = txtHeaterPower.Text
        SystemParameters.HeaterVoltage = txtHeaterVoltage.Text
        SystemParameters.HeaterMonitorPower = txtHeaterMonitorPower.Text
        SystemParameters.HeaterCurrentRate = txtHeaterCurrentRate.Text



        CalCurrent()

        '製程中斷設定
        SystemParameters.AbortPressureRange = txtAbortPressureRange.Text
        SystemParameters.AbortPressureRangeFlag = GetTrue01String(chkPressureAbort.Checked)

        SystemParameters.AbortTempRange = txtAbortTempRange.Text
        SystemParameters.AbortTempRangeFlag = GetTrue01String(chkTempAbort.Checked)




        '油壓行程設定
        SystemParameters.Position01Set = txtPosition01Set.Text
        SystemParameters.Position02Set = txtPosition02Set.Text
        SystemParameters.Position03Set = txtPosition03Set.Text
        SystemParameters.Position04Set = txtPosition04Set.Text
        SystemParameters.Position05Set = txtPosition05Set.Text
        SystemParameters.Position06Set = txtPosition06Set.Text

        SystemParameters.DistanceSet = txtDistanceSet.Text

        '稼動率開始記錄時間
        SystemParameters.StartLog_Time = dudLogStartTime.Text
        'log資料是否要DA
        SystemParameters.bolDAlog = chkDa.Checked

        WriteAlarmTimeSetup(AlarmINIFile)
        WriteParameterToFile(ParameterINIFile)
        FormTextBoxSave.FindTextBox(Me, Me.Name, FormSaveINIFile)


    End Sub


#End Region
    Public Sub ShowInit()
        Me.Show()
        Timer1.Enabled = True
    End Sub

#Region "即時資訊顯示"
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim i As Integer
        Me.Top = FromStartUpTopPosition
        Me.Left = 0
        On Error Resume Next
        txtRullerLength.Text = (Get_PLC_R1100(DARullerLengthIndex) / 10).ToString   '使用電阻尺,解析度0.1mm
        'Add  by Vincent 20190710  ------------------- Start
        chkSplitTopBotTemp.Visible = CelloUsbFlag
        pnlSplitTopBotTemp.Visible = GetTrue01Boolean(SystemParameters.SplitTopBotTempEnable)
        chkCIMUsed.Visible = CelloUsbFlag


        'Add  by Vincent 20190710  ------------------- End


        'Add  by Vincent 20180419  ------------------- Start
        If Check_PLC_M(DoTempTrackDisableIndex) Then
            btnTempTrackDisable.BackColor = Color.Pink
            btnTempTrackDisable.Text = GetLangText("停用", "Disable")
        Else
            btnTempTrackDisable.BackColor = Color.Lime
            btnTempTrackDisable.Text = GetLangText("啟用", "Enable")
        End If
        'Add  by Vincent 20180419  ------------------- End
        lblProcessAutoVacuumText.Visible = DP_Pump_Used
        btnProcessAutoVacuum.Visible = DP_Pump_Used
        txtNoControlPress.Text = Get_PLC_R1100(DANoControlPresssIndex).ToString 'chesly 'chesly 從PLC讀回值
        If CelloUsbFlag Then
            i = 0
            For Each aa As TabPage In tabParameter.TabPages
                If aa.Name = "TabPageCello" Then
                    i += 1
                End If
            Next
            If i = 0 Then
                tabParameter.TabPages.Add(TempTab1)
            End If
        Else
            For Each aa As TabPage In tabParameter.TabPages
                If aa.Name = "TabPageCello" Then
                    i += 1
                End If
            Next
            If i > 0 Then
                TempTab1 = tabParameter.TabPages("TabPageCello")
                tabParameter.TabPages.RemoveByKey("TabPageCello")
            End If

        End If
        lblPressureRead1.Text = oriPressPV(0).ToString
        lblRealPressure1.Text = Get_PLC_R1000(ADOriginPress01Index)

        lblPressureRead2.Text = oriPressPV(1).ToString
        lblRealPressure2.Text = Get_PLC_R1000(ADOriginPress02Index)

        lblPressureRead3.Text = oriPressPV(2).ToString
        lblRealPressure3.Text = Get_PLC_R1000(ADOriginPress03Index)

        lblPressureRead4.Text = oriPressPV(3).ToString
        lblRealPressure4.Text = Get_PLC_R1000(ADOriginPress04Index)

        lblPressureRead5.Text = oriPressPV(4).ToString
        lblRealPressure5.Text = Get_PLC_R1000(ADOriginPress05Index)

        lblPressureRead6.Text = oriPressPV(5).ToString
        lblRealPressure6.Text = Get_PLC_R1000(ADOriginPress06Index)


        lblSubPress1.Text = Get_PLC_R1000(ADSubPress01Index)
        lblSubPress2.Text = Get_PLC_R1000(ADSubPress02Index)
        lblSubPress3.Text = Get_PLC_R1000(ADSubPress03Index)
        lblSubPress4.Text = Get_PLC_R1000(ADSubPress04Index)
        lblSubPress5.Text = Get_PLC_R1000(ADSubPress05Index)
        lblSubPress6.Text = Get_PLC_R1000(ADSubPress06Index)

        'lblRealPressureAD.Text = Get_PLC_R1000(ADPressADVALUEIndex)

        'ObjShow.Show(PLC_M(DoPressDAOutLowIndex) = "1", btnLowPDAOut, Color.Lime, System.Drawing.SystemColors.Control)
        'ObjShow.Show(PLC_M(DoPressDAOutHighIndex) = "1", btnHighPDAOut, Color.Lime, System.Drawing.SystemColors.Control)

        lblVacuumCaled.Text = Format(GaugeCHVac, "0.0+E00")


        lblVacuumOriginal.Text = Format(10 * (PLC_R_READ(ADVacuumIndex) / 8191), "0.000") '電壓


        ObjShow.Show(Vac1ATM_Status, lbl1ATM, Color.Lime, Color.Red)

        lblITVRealValue1.Text = Get_PLC_R1000(ADScalerB01Index).ToString
        lblITVRealValue2.Text = Get_PLC_R1000(ADScalerB02Index).ToString
        lblITVRealValue3.Text = Get_PLC_R1000(ADScalerB03Index).ToString
        lblITVRealValue4.Text = Get_PLC_R1000(ADScalerB04Index).ToString
        lblITVRealValue5.Text = Get_PLC_R1000(ADScalerB05Index).ToString
        lblITVRealValue6.Text = Get_PLC_R1000(ADScalerB06Index).ToString

        lblTopFlow01.Text = FlowRead(0).GetTopFLowStr
        lblTopFlow02.Text = FlowRead(1).GetTopFLowStr
        lblTopFlow03.Text = FlowRead(2).GetTopFLowStr
        'lblTopFlow04.Text = FlowRead(3).GetTopFLowStr
        'lblTopFlow05.Text = FlowRead(4).GetTopFLowStr
        'lblTopFlow06.Text = FlowRead(5).GetTopFLowStr

        lblBotFlow01.Text = FlowRead(0).GetBotFLowStr
        lblBotFlow02.Text = FlowRead(1).GetBotFLowStr
        lblBotFlow03.Text = FlowRead(2).GetBotFLowStr
        'lblBotFlow04.Text = FlowRead(3).GetBotFLowStr
        'lblBotFlow05.Text = FlowRead(4).GetBotFLowStr
        'lblBotFlow06.Text = FlowRead(5).GetBotFLowStr
        'ObjShow.Show(Check_PLC_X(DiBondUp01Index), lblPressureRead1, Color.Black, System.Drawing.SystemColors.Control)
        'ObjShow.Show(Check_PLC_X(DiBondUp02Index), lblPressureRead2, Color.Black, System.Drawing.SystemColors.Control)
        'ObjShow.Show(Check_PLC_X(DiBondUp03Index), lblPressureRead3, Color.Black, System.Drawing.SystemColors.Control)
        'ObjShow.Show(Check_PLC_X(DiBondUp04Index), lblPressureRead4, Color.Black, System.Drawing.SystemColors.Control)
        'ObjShow.Show(Check_PLC_X(DiBondUp05Index), lblPressureRead5, Color.Black, System.Drawing.SystemColors.Control)
        'ObjShow.Show(Check_PLC_X(DiBondUp06Index), lblPressureRead6, Color.Black, System.Drawing.SystemColors.Control)


        'lblPressureVoltage.Text = Format(10 * (PLC_R_READ(ADOriginPressIndex) / 8191), "0.000")

        'lblTopFlow.Text = TopFlowMeterStr(0)
        'lblBotFlow.Text = BotFlowMeterStr(0)


        'If tabParameter.TabPages.Count = 3 Then
        '    TempTab1 = tabParameter.TabPages("TabPageCello")
        '    tabParameter.TabPages.RemoveByKey("TabPageCello")
        'End If
        ObjShow.Show(Vac1ATM_Select, btn1ATMSelect, Color.Lime, "Sensor X04", System.Drawing.SystemColors.Control, "GP275")

        ObjShow.Show(Check_PLC_M(DoForceDAOutIndex), btnForceDAOut, Color.Lime, System.Drawing.SystemColors.Control)

        ObjShow.Show(ProcessAutoVacuum_Status, btnProcessAutoVacuum, Color.Lime, "ON", System.Drawing.SystemColors.Control, "OFF")
        ObjShow.Show(ProcessOkALMEnabled_Status, btnEndAlarm, Color.Lime, "ON", System.Drawing.SystemColors.Control, "OFF")
        'ObjShow.Show(AutoPurge_Status, btnAutoPurge, Color.Lime, "ON", System.Drawing.SystemColors.Control, "OFF")
        ObjShow.Show(CAutoPumping.AutoPurge, btnAutoPurge, Color.Lime, "ON", System.Drawing.SystemColors.Control, "OFF")

        'ObjShow.Show(Check_PLC_M(DoWAT01Index), btnTopAT, Color.Lime, System.Drawing.SystemColors.Control)
        'ObjShow.Show(Check_PLC_M(DoWAT01Index), btnBotAT, Color.Lime, System.Drawing.SystemColors.Control)
        'ObjShow.Show(Check_PLC_M(DoTopWPID01Index), btnTopPID1, Color.Lime, System.Drawing.SystemColors.Control)
        'ObjShow.Show(Check_PLC_M(DoBotWPID01Index), btnBotPID1, Color.Lime, System.Drawing.SystemColors.Control)
        ObjShow.Show(PLC_M(DoBondDown01Index) = "1", btnPlateDown1, ColorOn, ColorOff)
        ObjShow.Show(PLC_M(DoBondDown02Index) = "1", btnPlateDown2, ColorOn, ColorOff)
        ObjShow.Show(PLC_M(DoBondDown03Index) = "1", btnPlateDown3, ColorOn, ColorOff)
        ObjShow.Show(PLC_M(DoBondDown04Index) = "1", btnPlateDown4, ColorOn, ColorOff)
        ObjShow.Show(PLC_M(DoBondDown05Index) = "1", btnPlateDown5, ColorOn, ColorOff)
        ObjShow.Show(PLC_M(DoBondDown06Index) = "1", btnPlateDown6, ColorOn, ColorOff)

        ObjShow.Show(PLC_M(DoBondUp01Index) = "1", btnPlateUp1, ColorOn, ColorOff)
        ObjShow.Show(PLC_M(DoBondUp02Index) = "1", btnPlateUp2, ColorOn, ColorOff)
        ObjShow.Show(PLC_M(DoBondUp03Index) = "1", btnPlateUp3, ColorOn, ColorOff)
        ObjShow.Show(PLC_M(DoBondUp04Index) = "1", btnPlateUp4, ColorOn, ColorOff)
        ObjShow.Show(PLC_M(DoBondUp05Index) = "1", btnPlateUp5, ColorOn, ColorOff)
        ObjShow.Show(PLC_M(DoBondUp06Index) = "1", btnPlateUp6, ColorOn, ColorOff)

        'lblTopTempP.Text = Get_PLC_R1000(ADTopPIndex) / 10
        'lblTopTempI.Text = Get_PLC_R1000(ADTopIIndex)
        'lblTopTempD.Text = Get_PLC_R1000(ADTopDIndex)
        'lblBotTempP.Text = Get_PLC_R1000(ADBotPIndex) / 10
        'lblBotTempI.Text = Get_PLC_R1000(ADBotIIndex)
        'lblBotTempD.Text = Get_PLC_R1000(ADBotDIndex)
        lblOverThresholdkgDA1.Text = Format(Val(txtkgDARatio1.Text) * Val(txtThresholdPressRatio.Text) / 100, "0")
        lblOverThresholdkgDA2.Text = Format(Val(txtkgDARatio2.Text) * Val(txtThresholdPressRatio.Text) / 100, "0")
        lblOverThresholdkgDA3.Text = Format(Val(txtkgDARatio3.Text) * Val(txtThresholdPressRatio.Text) / 100, "0")
        lblOverThresholdkgDA4.Text = Format(Val(txtkgDARatio4.Text) * Val(txtThresholdPressRatio.Text) / 100, "0")
        lblOverThresholdkgDA5.Text = Format(Val(txtkgDARatio5.Text) * Val(txtThresholdPressRatio.Text) / 100, "0")
        lblOverThresholdkgDA6.Text = Format(Val(txtkgDARatio6.Text) * Val(txtThresholdPressRatio.Text) / 100, "0")

        If Resistance_ruler_Flag = True Then
            'Modified 990203 Vincent Start
            '油壓缸行程及治具高度設定
            '使用電阻尺,解析度0.1mm
            lblCurrentPosition1.Text = (Get_PLC_R1000(ADCurrentPosition01Index) / 10).ToString("0.0")
            lblCurrentPosition2.Text = (Get_PLC_R1000(ADCurrentPosition02Index) / 10).ToString("0.0")
            lblCurrentPosition3.Text = (Get_PLC_R1000(ADCurrentPosition03Index) / 10).ToString("0.0")

            '
            '使用電阻尺,解析度0.1mm
            lblPositionSet1.Text = (Get_PLC_R1100(DAPositionSet01Index) / 10).ToString("0.0")
            lblPositionSet2.Text = (Get_PLC_R1100(DAPositionSet02Index) / 10).ToString("0.0")
            lblPositionSet3.Text = (Get_PLC_R1100(DAPositionSet03Index) / 10).ToString("0.0")
        Else

            '使用光電素子尺, 最小2.5mm
            lblCurrentPosition1.Text = (Get_PLC_R1000(ADCurrentPosition01Index) * 2.5).ToString + "/" + Get_PLC_R1000(ADCurrentPosition01Index).ToString
            lblCurrentPosition2.Text = (Get_PLC_R1000(ADCurrentPosition02Index) * 2.5).ToString + "/" + Get_PLC_R1000(ADCurrentPosition02Index).ToString
            lblCurrentPosition3.Text = (Get_PLC_R1000(ADCurrentPosition03Index) * 2.5).ToString + "/" + Get_PLC_R1000(ADCurrentPosition03Index).ToString
            lblCurrentPosition4.Text = (Get_PLC_R1000(ADCurrentPosition04Index) * 2.5).ToString + "/" + Get_PLC_R1000(ADCurrentPosition04Index).ToString
            lblCurrentPosition5.Text = (Get_PLC_R1000(ADCurrentPosition05Index) * 2.5).ToString + "/" + Get_PLC_R1000(ADCurrentPosition05Index).ToString
            lblCurrentPosition6.Text = (Get_PLC_R1000(ADCurrentPosition06Index) * 2.5).ToString + "/" + Get_PLC_R1000(ADCurrentPosition06Index).ToString

            '使用光電素子尺, 最小2.5mm
            lblPositionSet1.Text = (Get_PLC_R1100(DAPositionSet01Index) * 2.5).ToString + "/" + Get_PLC_R1100(DAPositionSet01Index).ToString
            lblPositionSet2.Text = (Get_PLC_R1100(DAPositionSet02Index) * 2.5).ToString + "/" + Get_PLC_R1100(DAPositionSet02Index).ToString
            lblPositionSet3.Text = (Get_PLC_R1100(DAPositionSet03Index) * 2.5).ToString + "/" + Get_PLC_R1100(DAPositionSet03Index).ToString
            lblPositionSet4.Text = (Get_PLC_R1100(DAPositionSet04Index) * 2.5).ToString + "/" + Get_PLC_R1100(DAPositionSet04Index).ToString
            lblPositionSet5.Text = (Get_PLC_R1100(DAPositionSet05Index) * 2.5).ToString + "/" + Get_PLC_R1100(DAPositionSet05Index).ToString
            lblPositionSet6.Text = (Get_PLC_R1100(DAPositionSet06Index) * 2.5).ToString + "/" + Get_PLC_R1100(DAPositionSet06Index).ToString
        End If
        ObjShow.Show(FlowMeterMode, btnFlowMode, Color.Lime, "脈波型", Color.LightPink, "一般型")
        'Modified 990203 Vincent End


        'By chesly 20181023 壓缸自動循環動作 Start 
        ObjShow.Show(Vac1ATM_Status, lbl1ATM, Color.Lime, Color.Red)

        ObjShow.Show(PLC_Y(DoBondDown01Index) = "1", btnPlateDownACR1, ColorOn, ColorOff)
        ObjShow.Show(PLC_Y(DoBondDown02Index) = "1", btnPlateDownACR2, ColorOn, ColorOff)
        ObjShow.Show(PLC_Y(DoBondDown03Index) = "1", btnPlateDownACR3, ColorOn, ColorOff)
        ObjShow.Show(PLC_Y(DoBondDown04Index) = "1", btnPlateDownACR4, ColorOn, ColorOff)
        ObjShow.Show(PLC_Y(DoBondDown05Index) = "1", btnPlateDownACR5, ColorOn, ColorOff)
        ObjShow.Show(PLC_Y(DoBondDown06Index) = "1", btnPlateDownACR6, ColorOn, ColorOff)

        ObjShow.Show(PLC_Y(DoBondUp01Index) = "1", btnPlateUpACR1, ColorOn, ColorOff)
        ObjShow.Show(PLC_Y(DoBondUp02Index) = "1", btnPlateUpACR2, ColorOn, ColorOff)
        ObjShow.Show(PLC_Y(DoBondUp03Index) = "1", btnPlateUpACR3, ColorOn, ColorOff)
        ObjShow.Show(PLC_Y(DoBondUp04Index) = "1", btnPlateUpACR4, ColorOn, ColorOff)
        ObjShow.Show(PLC_Y(DoBondUp05Index) = "1", btnPlateUpACR5, ColorOn, ColorOff)
        ObjShow.Show(PLC_Y(DoBondUp06Index) = "1", btnPlateUpACR6, ColorOn, ColorOff)

        ObjShow.Show(BondCycle1.StartRun, btnCycleRun1, Color.Lime, Color.Red)
        ObjShow.Show(BondCycle2.StartRun, btnCycleRun2, Color.Lime, Color.Red)
        ObjShow.Show(BondCycle3.StartRun, btnCycleRun3, Color.Lime, Color.Red)
        ObjShow.Show(BondCycle4.StartRun, btnCycleRun4, Color.Lime, Color.Red)
        ObjShow.Show(BondCycle5.StartRun, btnCycleRun5, Color.Lime, Color.Red)
        ObjShow.Show(BondCycle6.StartRun, btnCycleRun6, Color.Lime, Color.Red)


        lblBondCycles1.Text = Format(BondCycle1.State, "[0]") & ":" & BondCycle1.RunCount.ToString & "/" & BondCycle1.RunCountSet.ToString & Format(BondCycle1.DelayTimer, "(0)")
        lblBondCycles2.Text = Format(BondCycle2.State, "[0]") & ":" & BondCycle2.RunCount.ToString & "/" & BondCycle2.RunCountSet.ToString & Format(BondCycle2.DelayTimer, "(0)")
        lblBondCycles3.Text = Format(BondCycle3.State, "[0]") & ":" & BondCycle3.RunCount.ToString & "/" & BondCycle3.RunCountSet.ToString & Format(BondCycle3.DelayTimer, "(0)")
        lblBondCycles4.Text = Format(BondCycle4.State, "[0]") & ":" & BondCycle4.RunCount.ToString & "/" & BondCycle4.RunCountSet.ToString & Format(BondCycle4.DelayTimer, "(0)")
        lblBondCycles5.Text = Format(BondCycle5.State, "[0]") & ":" & BondCycle5.RunCount.ToString & "/" & BondCycle5.RunCountSet.ToString & Format(BondCycle5.DelayTimer, "(0)")
        lblBondCycles6.Text = Format(BondCycle6.State, "[0]") & ":" & BondCycle6.RunCount.ToString & "/" & BondCycle6.RunCountSet.ToString & Format(BondCycle6.DelayTimer, "(0)")
        If DoorChk = True Then
            If Not Check_PLC_X(DiSaftyGate01Index) Then
                BondCycle1.StartRun = False
                BondCycle2.StartRun = False
                BondCycle3.StartRun = False
                BondCycle4.StartRun = False
                BondCycle5.StartRun = False
                BondCycle6.StartRun = False
            End If
            If Not Check_PLC_X(DiSaftyGate02Index) Then
                BondCycle1.StartRun = False
                BondCycle2.StartRun = False
                BondCycle3.StartRun = False
                BondCycle4.StartRun = False
                BondCycle5.StartRun = False
                BondCycle6.StartRun = False
            End If
        End If
        BondCycle1.SetDelayTime(txtC_Time, txtC_Time)
        BondCycle1.CycleTimes(txtCR_Time)
        BondCycle2.SetDelayTime(txtC_Time, txtC_Time)
        BondCycle2.CycleTimes(txtCR_Time)
        BondCycle3.SetDelayTime(txtC_Time, txtC_Time)
        BondCycle3.CycleTimes(txtCR_Time)
        BondCycle4.SetDelayTime(txtC_Time, txtC_Time)
        BondCycle4.CycleTimes(txtCR_Time)
        BondCycle5.SetDelayTime(txtC_Time, txtC_Time)
        BondCycle5.CycleTimes(txtCR_Time)
        BondCycle6.SetDelayTime(txtC_Time, txtC_Time)
        BondCycle6.CycleTimes(txtCR_Time)
        'By chesly 20181023 壓缸自動循環動作 end

        '自動校壓 claire
        ObjShow.Show(BondAutoPressCal1.StartRun, btnSite1Cal, Color.Lime, Color.Red)
        ObjShow.Show(BondAutoPressCal2.StartRun, btnSite2Cal, Color.Lime, Color.Red)
        ObjShow.Show(BondAutoPressCal3.StartRun, btnSite3Cal, Color.Lime, Color.Red)

        '自動校壓 claire...end
        ObjShow.Show(CSVTimerStartPb_Status, btnlog, ColorOn, ColorOff)

        If SanAn_TCPIP_Used_Flag Or BarCodeFile_Flag Then
            Panel2.Visible = True
        Else
            Panel2.Visible = False
        End If

        If BarCodeFile_Flag Then
            Panel3.Visible = True
        Else
            Panel3.Visible = False
        End If
        If CelloUsbFlag Then chkDa.Visible = True
        Label14.Text = strAutoPressCalMess
        lbPeakClearTimes.Text = (intPeakClearTimes(0) + intPeakClearTimes(1) + intPeakClearTimes(2)).ToString
    End Sub
    'Modified 990203 Vincent Start

    Private Sub txtPosition01Set_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtPosition01Set.MouseDown, txtPosition02Set.MouseDown, txtPosition03Set.MouseDown, txtPosition04Set.MouseDown, txtPosition05Set.MouseDown, txtPosition06Set.MouseDown
        Dim index As Integer
        index = sender.TabIndex
        If CallKeyboard2(sender, "500", "1") <> "" Then
            SaveParameter()
            If Resistance_ruler_Flag = True Then
                '使用電阻尺,解析度0.1mm
                '減 2.5mm 提早降壓 
                Write_PLC_R1100(DAPositionSet01Index + index, ((Val(SystemParameters.DistanceSet) - Val(sender.Text)) * 10) - 25)
            Else
                '使用光電素子尺, 最小2.5mm
                Write_PLC_R1100(DAPositionSet01Index + index, ((Val(SystemParameters.DistanceSet) - Val(sender.Text)) / 2.5) - 1)
            End If
        End If
    End Sub

    Private Sub txtDistanceSet_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtDistanceSet.MouseDown
        If CallKeyboard2(sender, "500", "1") <> "" Then
            SaveParameter()
            If Resistance_ruler_Flag = True Then
                '使用電阻尺,解析度0.1mm
                '減 2.5mm 提早降壓 
                Write_PLC_R1100(DAPositionSet01Index, ((Val(SystemParameters.DistanceSet) - Val(txtPosition01Set.Text)) * 10) - 25)
                Write_PLC_R1100(DAPositionSet02Index, ((Val(SystemParameters.DistanceSet) - Val(txtPosition01Set.Text)) * 10) - 25)
                Write_PLC_R1100(DAPositionSet03Index, ((Val(SystemParameters.DistanceSet) - Val(txtPosition01Set.Text)) * 10) - 25)

            Else
                '使用光電素子尺, 最小2.5mm
                Write_PLC_R1100(DAPositionSet01Index, ((Val(SystemParameters.DistanceSet) - Val(txtPosition01Set.Text)) / 2.5) - 1)
                Write_PLC_R1100(DAPositionSet02Index, ((Val(SystemParameters.DistanceSet) - Val(txtPosition02Set.Text)) / 2.5) - 1)
                Write_PLC_R1100(DAPositionSet03Index, ((Val(SystemParameters.DistanceSet) - Val(txtPosition03Set.Text)) / 2.5) - 1)
                'Write_PLC_R1100(DAPositionSet04Index, ((Val(SystemParameters.DistanceSet) - Val(txtPosition04Set.Text)) / 2.5) - 1)
                'Write_PLC_R1100(DAPositionSet05Index, ((Val(SystemParameters.DistanceSet) - Val(txtPosition05Set.Text)) / 2.5) - 1)
                'Write_PLC_R1100(DAPositionSet06Index, ((Val(SystemParameters.DistanceSet) - Val(txtPosition06Set.Text)) / 2.5) - 1)
            End If
        End If
    End Sub



    'Modified 990203 Vincent End

#End Region

#Region "參數/警報設定"

    '超溫警報
    Private Sub txtHiTempLimit_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtHiTempLimit.MouseDown
        If CallKeyboard2(sender, "1000", "25") <> "" Then
            SaveParameter()
        End If
    End Sub
    Private Sub txtHiPressureLimit_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles txtHiPressureLimit.MouseDown
        If CallKeyboard2(sender, (Val(PRESS_MAX) + 1000).ToString, "0") <> "" Then
            SaveParameter()
        End If
    End Sub
    '抽真空警報
    Private Sub txtPumpTime_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtPumpTime.MouseDown
        If CallKeyboard2(sender, "9999", "0") <> "" Then
            SaveParameter()
        End If
    End Sub
    '真空PUMP電流警報
    Private Sub txtDpCurrentLimit_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtDpCurrentLimit.MouseDown
        If CallKeyboard2(sender, "50", "0.01") <> "" Then
            SaveParameter()
        End If
    End Sub
    '製程結束後警報時間
    Private Sub txtProcessEndBZonTime_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtProcessEndBZonTime.MouseDown
        If CallKeyboard2(sender, "999", "0") <> "" Then
            Write_PLC_R1100(DAProcessOKAlarmIndex, Val(sender.Text))
            SaveParameter()
        End If
    End Sub

    '製程結束警報
    Private Sub btnEndAlarm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEndAlarm.Click
        'ProcessOkALMEnabled_Status = Not ProcessOkALMEnabled_Status
        'Write_PLC_R1100(DAProcessOKAlarmIndex, GetTrue01Integer(ProcessOkALMEnabled_Status))
        'SaveParameter()
        ProcessOkALMEnabled_Status = Not ProcessOkALMEnabled_Status
        SystemParameters.ProcessEndAlarm = GetTrue01String(ProcessOkALMEnabled_Status)
        WriteProgData("PARAMETER", "PROCESSENDALARM", SystemParameters.ProcessEndAlarm, ParameterINIFile)
        SaveParameter()
    End Sub
    '關門自動抽真空
    Private Sub btnAutoPumping_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AutoVacuum_Status = Not AutoVacuum_Status
        If AutoVacuum_Status Then
            BondBeforeVacuum_Status = False
        End If
        SaveParameter()
    End Sub

    '抽氣前預壓
    Private Sub btnBondBeforeVacuum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BondBeforeVacuum_Status = Not BondBeforeVacuum_Status
        If BondBeforeVacuum_Status Then
            AutoVacuum_Status = False
        End If
        SaveParameter()
    End Sub
    '抽氣時 PURGE
    Private Sub btnAutoPurge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAutoPurge.Click
        AutoPurge_Status = Not AutoPurge_Status
        CAutoPumping.AutoPurge = Not CAutoPumping.AutoPurge
        SaveParameter()
    End Sub
    '抽氣時PURGE 循環次數
    Private Sub txtPurgeCycle_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtPurgeCycle.MouseDown
        If CallKeyboard2(sender, "999", "0") <> "" Then
            SaveParameter()
            CAutoPumping.SetAutoPurge(CAutoPumping.AutoPurge, Val(SystemParameters.AutoPurgeOnTime), Val(SystemParameters.AutoPurgeOFFTime), Val(SystemParameters.AutoPurgeCycle))
        End If
    End Sub
    '抽氣時 PURGE ON 時間
    Private Sub txtPurgeONTime_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtPurgeONTime.MouseDown
        If CallKeyboard2(sender, "999", "0") <> "" Then
            SaveParameter()
            CAutoPumping.SetAutoPurge(CAutoPumping.AutoPurge, Val(SystemParameters.AutoPurgeOnTime), Val(SystemParameters.AutoPurgeOFFTime), Val(SystemParameters.AutoPurgeCycle))
        End If
    End Sub
    '抽氣時 PURGE OFF 時間
    Private Sub txtPurgeOFFTime_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtPurgeOFFTime.MouseDown
        If CallKeyboard2(sender, "999", "0") <> "" Then
            SaveParameter()
            CAutoPumping.SetAutoPurge(CAutoPumping.AutoPurge, Val(SystemParameters.AutoPurgeOnTime), Val(SystemParameters.AutoPurgeOFFTime), Val(SystemParameters.AutoPurgeCycle))
        End If
    End Sub

    '抽氣時真空度設定- 到此真空度則停止
    Private Sub txtProcessVacSet_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtProcessVacSet.MouseDown
        If Val(CallKeyboard3(sender, txtProcessVacSetLo.Text, "1.0E-02")) > 0 Then
            sender.text = Format(Val(sender.text), "0.0E+00")

            SaveParameter()
            If ProcessMode_RUN Then
                CAutoPumping.SetBasePressure(CAutoPumping.AutoProtection, Val(SystemParameters.ProcessVacuumAutoVac), Val(RecipeNum(RecipeRunIndex).BasePressure))
            Else
                CAutoPumping.SetBasePressure(CAutoPumping.AutoProtection, Val(SystemParameters.ProcessVacuumAutoVac), Val(SystemParameters.ProcessVacuumAutoVacLo))
            End If
        End If
    End Sub
    Private Sub txtProcessVacSetLo_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtProcessVacSetLo.MouseDown
        If Val(CallKeyboard3(sender, "760", txtProcessVacSet.Text)) > 0 Then
            sender.text = Format(Val(sender.text), "0.0E+00")
            SaveParameter()
            If ProcessMode_RUN Then
                CAutoPumping.SetBasePressure(CAutoPumping.AutoProtection, Val(SystemParameters.ProcessVacuumAutoVac), Val(RecipeNum(RecipeRunIndex).BasePressure))
            Else
                CAutoPumping.SetBasePressure(CAutoPumping.AutoProtection, Val(SystemParameters.ProcessVacuumAutoVac), Val(SystemParameters.ProcessVacuumAutoVacLo))
            End If
        End If
    End Sub

    '可開門之冷卻溫度
    Private Sub txtCoolingTime_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtCoolingTemp.MouseDown
        If CallKeyboard2(sender, "100", "0") <> "" Then
            SaveParameter()
        End If
    End Sub

    '製程繼續壓力範圍
    Private Sub txtPressureRange_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtPressureRange.MouseDown
        If CallKeyboard2(sender, "15000", "0") <> "" Then
            Write_PLC_R1100(DAPressOKRangeIndex, Val(sender.Text))
            SaveParameter()
        End If
    End Sub
    '製程繼續溫度範圍
    Private Sub txtTempRange_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtTempRange.MouseDown
        If CallKeyboard2(sender, "999", "0") <> "" Then
            SaveParameter()
        End If
    End Sub

    '製程結束後自動 VENT
    Private Sub btnAutoVent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AutoVent_Status = Not AutoVent_Status
        'Write_PLC_R1100(DAAutoVentIndex, GetTrue01String(AutoVent_Status))
        SaveParameter()
    End Sub

    '製程中自動抽真空
    Private Sub btnProcessAutoVacuum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcessAutoVacuum.Click
        ProcessAutoVacuum_Status = Not ProcessAutoVacuum_Status
        CAutoPumping.AutoProtection = ProcessAutoVacuum_Status
        'CAutoPumping.SetBasePressure(CAutoPumping.AutoProtection, Val(SystemParameters.ProcessVacuumAutoVac), Val(SystemParameters.ProcessVacuumAutoVacLo))

        If ProcessMode_RUN Then
            CAutoPumping.SetBasePressure(CAutoPumping.AutoProtection, Val(SystemParameters.ProcessVacuumAutoVac), Val(RecipeNum(RecipeRunIndex).BasePressure))
        Else
            CAutoPumping.SetBasePressure(CAutoPumping.AutoProtection, Val(SystemParameters.ProcessVacuumAutoVac), Val(SystemParameters.ProcessVacuumAutoVacLo))
        End If
        SaveParameter()
    End Sub
    '破真空時間
    Private Sub txtlblVentTime_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtVentTime.MouseDown
        If CallKeyboard2(sender, "9999", "0") <> "" Then
            Write_PLC_R1100(DAVentTimeIndex, Val(sender.Text))
            SaveParameter()
        End If
    End Sub
#End Region

#Region "溫度校正"
    ''溫度校正-- 不須寫入 PLC
    'Private Sub txtTopTempCal1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    '    If CallKeyboard2(sender, TEMP_MAX, TEMP_MIN) <> "" Then
    '        UpdateCalData()

    '        WriteHeaterCalData(ParameterINIFile)
    '        SaveParameter()
    '    End If
    'End Sub
#End Region

#Region "壓力校正"


    ''壓力校正, 須寫入 PLC
    'Private Sub txtPlatePressureCal1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    '    If CallKeyboard2(sender, PRESS_MAX, PRESS_MIN) <> "" Then
    '        Write_PLC_R1100(DAPressure01Cal1Index, Val(sender.Text))
    '        SaveParameter()
    '    End If
    'End Sub
    'Private Sub txtPlatePressureCal2_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    '    If CallKeyboard2(sender, PRESS_MAX, PRESS_MIN) <> "" Then
    '        Write_PLC_R1100(DAPressure01Cal2Index, Val(sender.Text))
    '        SaveParameter()
    '    End If
    'End Sub
    'Private Sub txtPlatePressureCal3_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    '    If CallKeyboard2(sender, PRESS_MAX, PRESS_MIN) <> "" Then
    '        Write_PLC_R1100(DAPressure01Cal3Index, Val(sender.Text))
    '        SaveParameter()
    '    End If
    'End Sub
    'Private Sub txtPlatePressureCal4_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    '    If CallKeyboard2(sender, PRESS_MAX, PRESS_MIN) <> "" Then
    '        Write_PLC_R1100(DAPressure01Cal4Index, Val(sender.Text))
    '        SaveParameter()
    '    End If
    'End Sub
    'Private Sub txtPlatePressureCal5_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    '    If CallKeyboard2(sender, PRESS_MAX, PRESS_MIN) <> "" Then
    '        Write_PLC_R1100(DAPressure01Cal5Index, Val(sender.Text))
    '        SaveParameter()
    '    End If
    'End Sub

    'Private Sub txtPlatePressureCalX1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    '    If CallKeyboard2(sender, PRESS_MAX, PRESS_MIN) <> "" Then
    '        Write_PLC_R1100(DAPressureCal1XIndex, Val(sender.Text))
    '        SaveParameter()
    '    End If
    'End Sub


    'Private Sub txtPlatePressureCalX2_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    '    If CallKeyboard2(sender, PRESS_MAX, PRESS_MIN) <> "" Then
    '        Write_PLC_R1100(DAPressureCal2XIndex, Val(sender.Text))
    '        SaveParameter()
    '    End If
    'End Sub


    'Private Sub txtPlatePressureCalX3_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    '    If CallKeyboard2(sender, PRESS_MAX, PRESS_MIN) <> "" Then
    '        Write_PLC_R1100(DAPressureCal3XIndex, Val(sender.Text))
    '        SaveParameter()
    '    End If
    'End Sub


    'Private Sub txtPlatePressureCalX4_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    '    If CallKeyboard2(sender, PRESS_MAX, PRESS_MIN) <> "" Then
    '        Write_PLC_R1100(DAPressureCal4XIndex, Val(sender.Text))
    '        SaveParameter()
    '    End If
    'End Sub


    'Private Sub txtPlatePressureCalX5_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    '    If CallKeyboard2(sender, PRESS_MAX, PRESS_MIN) <> "" Then
    '        Write_PLC_R1100(DAPressureCal5XIndex, Val(sender.Text))
    '        SaveParameter()
    '    End If
    'End Sub

    Private Sub txtPressAverage_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtPressAverage.MouseDown
        If Val(CallKeyboard2(sender, "100", "0")) > 0 Then
            SaveParameter()
        End If
    End Sub

    '更新校正資料
    Private Sub UpdateCalData()
        'tempTopX(0) = 0
        'tempTopX(1) = Val(txtTopTempCalX1.Text)
        'tempTopX(2) = Val(txtTopTempCalX2.Text)
        'tempTopX(3) = Val(txtTopTempCalX3.Text)
        'tempTopX(4) = Val(txtTopTempCalX4.Text)
        'tempTopX(5) = Val(txtTopTempCalX5.Text)
        'tempTopX(6) = Max_Caled_Temp

        'tempTopY(0) = 0
        'tempTopY(1) = Val(txtTopTempCal1.Text)
        'tempTopY(2) = Val(txtTopTempCal2.Text)
        'tempTopY(3) = Val(txtTopTempCal3.Text)
        'tempTopY(4) = Val(txtTopTempCal4.Text)
        'tempTopY(5) = Val(txtTopTempCal5.Text)
        'tempTopY(6) = Max_Caled_Temp

        'tempBotX(0) = 0
        'tempBotX(1) = Val(txtBotTempCalX1.Text)
        'tempBotX(2) = Val(txtBotTempCalX2.Text)
        'tempBotX(3) = Val(txtBotTempCalX3.Text)
        'tempBotX(4) = Val(txtBotTempCalX4.Text)
        'tempBotX(5) = Val(txtBotTempCalX5.Text)
        'tempBotX(6) = Max_Caled_Temp

        'tempBotY(0) = 0
        'tempBotY(1) = Val(txtBotTempCal1.Text)
        'tempBotY(2) = Val(txtBotTempCal2.Text)
        'tempBotY(3) = Val(txtBotTempCal3.Text)
        'tempBotY(4) = Val(txtBotTempCal4.Text)
        'tempBotY(5) = Val(txtBotTempCal5.Text)
        'tempBotY(6) = Max_Caled_Temp

        'PressX(1) = Val(txtPlatePressureCalX1.Text)
        'PressX(2) = Val(txtPlatePressureCalX2.Text)
        'PressX(3) = Val(txtPlatePressureCalX3.Text)
        'PressX(4) = Val(txtPlatePressureCalX4.Text)
        'PressX(5) = Val(txtPlatePressureCalX5.Text)

        'PressY(1) = Val(txtPlatePressureCal1.Text)
        'PressY(2) = Val(txtPlatePressureCal2.Text)
        'PressY(3) = Val(txtPlatePressureCal3.Text)
        'PressY(4) = Val(txtPlatePressureCal4.Text)
        'PressY(5) = Val(txtPlatePressureCal5.Text)


    End Sub
#End Region

#Region "首次貼合"

    Private Sub btnPlateUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlateUp1.Click, btnPlateUp2.Click, btnPlateUp3.Click, btnPlateUp4.Click, btnPlateUp5.Click, btnPlateUp6.Click
        Dim Index As Integer
        Dim UpIndex, DownIndex, ForceIndex As Integer
        If ProcessMode_RUN Then Exit Sub
        'Dim boltemp As Boolean = False
        Index = sender.Tabindex
        UpIndex = DoBondUp01Index + Index * 4
        DownIndex = DoBondDown01Index + Index * 4
        ForceIndex = DoBondForce01Index + Index

        If boltemp Then
            Output(UpIndex).Status = True
            Output(DownIndex).Status = False
            Output(ForceIndex).Status = False
        Else
            If Output(UpIndex).Status Then
                Output(UpIndex).Status = False
            Else
                'If (PLC_X(DiDoor1UpIndex) = "0" Or PLC_X(DiDoor2UpIndex) = "0") Then
                '    MsgBoxLangErr("腔門未關閉,請關閉腔門!", "腔�d未����,�[���葭��d!", "Door not Close!")
                'Else
                If OilPumpUsed Then
                    If Check_PLC_M(DoOilPump01Index + Index * 4) Then
                        If MsgBoxLangYesNo("請確認載盤已置放!", "Please Cormfirm Plate Up!") Then
                            Output(UpIndex).Status = True
                            Output(DownIndex).Status = False
                            Output(ForceIndex).Status = False
                        End If
                    Else
                        MsgBoxLangErr("油壓幫浦未啟動!", "Oil Pump need ON!")
                    End If
                Else
                    If MsgBoxLangYesNo("請確認載盤已置放!", "Please Cormfirm Plate Up!") Then
                        Output(UpIndex).Status = True
                        Output(DownIndex).Status = False
                        Output(ForceIndex).Status = False
                    End If
                End If
            End If
        End If

        'If ChuckUpPb_Status Then
        '    ChuckUpPb_Status = False
        'Else
        '    If PLC_X(DiDoor1UpIndex) = "0" Then
        '        MsgBoxLangErr("腔門未關閉,請關閉腔門!", "腔�d未����,�[���葭��d!", "Door not Close!")
        '    Else
        '        'If Check_PLC_M(DoOilPumpIndex) Then
        '        If MsgBoxLangYesNo("請確認載盤已置放!", "�[确�P�^�髐w置放!", "Please Cormfirm Plate Up!") Then
        '            ChuckUpPb_Status = Not ChuckUpPb_Status
        '            ChuckDnPb_Status = False
        '            BoundingPb_Status = False
        '        End If
        '        '    Else
        '        '    MsgBoxLangErr("油壓幫浦未啟動!", "油���眳�未�Q��!", "Oil Pump need ON!")
        '        'End If
        '    End If
        'End If
    End Sub

    Private Sub btnPlateDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlateDown1.Click, btnPlateDown2.Click, btnPlateDown3.Click, btnPlateDown4.Click, btnPlateDown5.Click, btnPlateDown6.Click
        Dim Index As Integer
        Dim UpIndex, DownIndex, ForceIndex As Integer
        If ProcessMode_RUN Then Exit Sub

        Index = sender.Tabindex
        UpIndex = DoBondUp01Index + Index * 4
        DownIndex = DoBondDown01Index + Index * 4
        ForceIndex = DoBondForce01Index + Index

        If boltemp Then
            Output(DownIndex).Status = True
            Output(UpIndex).Status = False
            Output(ForceIndex).Status = False
        Else
            If Output(DownIndex).Status Then
                Output(DownIndex).Status = False
            Else
                If OilPumpUsed Then
                    If Check_PLC_M(DoOilPump01Index + Index * 4) Then
                        'If MsgBoxLangYesNo("請確認載盤已置放!", "�P�^�髐w置放!", "Please Cormfirm Plate Up!") Then
                        Output(DownIndex).Status = True
                        Output(UpIndex).Status = False
                        Output(ForceIndex).Status = False
                        'End If
                    Else
                        MsgBoxLangErr("油壓幫浦未啟動!", "Oil Pump need ON!")
                    End If
                Else
                    Output(UpIndex).Status = False
                    Output(DownIndex).Status = True
                    Output(ForceIndex).Status = False
                End If
            End If
            ''If ChuckDnPb_Status Then
            ''    ChuckDnPb_Status = False
            ''Else
            ''    'If Check_PLC_M(DoOilPumpIndex) Then
            ''    ChuckDnPb_Status = Not ChuckDnPb_Status
            ''    ChuckUpPb_Status = False
            ''    BoundingPb_Status = False
            ''    'Else
            ''    '    MsgBoxLangErr("油壓幫浦未啟動!", "油���眳�未�Q��!", "Oil Pump need ON!")
            ''    'End If
        End If
    End Sub

    Private Sub btnLowPDAOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLowPDAOut.Click
        PressDAOutLow_Status = Not PressDAOutLow_Status
    End Sub

    Private Sub btnHighPDAOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHighPDAOut.Click
        PressDAOutHigh_Status = Not PressDAOutHigh_Status
    End Sub
    '首次貼合程序
    Private Sub txtPress1st_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtPress1st.MouseDown
        CallKeyboard2(sender, "8191", "0")
        Write_PLC_R1100(DA1stPressIndex, Val(sender.Text))
        SaveParameter()
    End Sub

    Private Sub txtPress2nd_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtPress2nd1.MouseDown, txtPress2nd2.MouseDown, txtPress2nd3.MouseDown, txtPress2nd4.MouseDown, txtPress2nd5.MouseDown, txtPress2nd6.MouseDown
        Dim Index As Integer
        Index = sender.TabIndex
        CallKeyboard2(sender, "8191", "0")
        'Write_PLC_R1100(DA2ndPressIndex, Val(sender.Text))
        Write_PLC_R1100(DA2ndPress1Index + Index, Val(sender.Text))
        SaveParameter()
    End Sub

    Private Sub txtPlateUpContactKg_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtPlateUpContactKg.MouseDown
        CallKeyboard2(sender, "15000", "0")
        Write_PLC_R1100(DA3rdPressIndex, Val(sender.Text))
        SaveParameter()
    End Sub

    Private Sub txtPress3rd_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtPress3rd1.MouseDown, txtPress3rd2.MouseDown, txtPress3rd3.MouseDown, txtPress3rd4.MouseDown, txtPress3rd5.MouseDown, txtPress3rd6.MouseDown
        Dim Index As Integer
        Index = sender.TabIndex
        CallKeyboard2(sender, "8191", "0")
        'Write_PLC_R1100(DAPlateUpPressureIndex, Val(sender.Text))
        Write_PLC_R1100(DAPlateUpPressure1Index + Index, Val(sender.Text))
        SaveParameter()
    End Sub

    Private Sub txtITVDAOut_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtLowPDAOut.MouseDown
        CallKeyboard2(sender, "8191", "0")
        'Write_PLC_R1100(DALowDAIndex, Val(sender.Text))
        SaveParameter()
    End Sub
    Private Sub txtHighPDAOut_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtHighPDAOut.MouseDown
        CallKeyboard2(sender, "8191", "0")
        Write_PLC_R1100(DAHighDAIndex, Val(sender.Text))
        SaveParameter()
    End Sub
#End Region

#Region "自動控壓設定"
    Private Sub txtThreshold_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtThreshold.MouseDown
        If CallKeyboard2(sender, "99999", "1") <> "" Then
            Write_PLC_R1100(DAThresholdIndex, Val(sender.Text))
            SaveParameter()
        End If
    End Sub

    Private Sub txtThresholdRatio_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtThresholdPressRatio.MouseDown
        If CallKeyboard2(sender, "9999", "1") <> "" Then
            Write_PLC_R1100(DAThresholdRatioIndex, Val(sender.Text))
            SaveParameter()
        End If
    End Sub

    Private Sub txt1stControlKg_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtCtrl1stRange.MouseDown
        If CallKeyboard2(sender, "9999", "1") <> "" Then
            Write_PLC_R1100(DAT1stControlKgIndex, Val(sender.Text))
            SaveParameter()
        End If
    End Sub

    Private Sub txt1stControlTime_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtCtrl1stTime.MouseDown
        If CallKeyboard2(sender, "9999", "0.1") <> "" Then
            If Val(sender.Text) = 0 Then sender.Text = "2"
            Write_PLC_R1100(DAT1stControlTimeIndex, Val(sender.Text) * 100)
            SaveParameter()
        End If
    End Sub

    Private Sub txt2ndControlKg_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtCtrl2ndRange.MouseDown
        If CallKeyboard2(sender, "9999", "1") <> "" Then
            Write_PLC_R1100(DAT2ndControlKgIndex, Val(sender.Text))
            SaveParameter()
        End If
    End Sub

    Private Sub txt2ndControlTime_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtCtrl2ndtTime.MouseDown
        If CallKeyboard2(sender, "9999", "0.1") <> "" Then
            If Val(sender.Text) = 0 Then sender.Text = "4"
            Write_PLC_R1100(DAT2ndControlTimeIndex, Val(sender.Text) * 100)
            SaveParameter()
        End If
    End Sub

    Private Sub txtInRagePDiv1Set_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtCtrl1stDiv.MouseDown
        If Val(CallKeyboard2(sender, "9999", "1")) > 0 Then
            Write_PLC_R1100(DAInRagePDiv1SetIndex, Val(sender.Text))
            SaveParameter()
        End If
    End Sub

    Private Sub txtInRagePDiv2Set_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtThresholdPressDiv.MouseDown
        If Val(CallKeyboard2(sender, "9999", "1")) > 0 Then
            Write_PLC_R1100(DAInRagePDiv2SetIndex, Val(sender.Text))
            SaveParameter()
        End If
    End Sub

    Private Sub txtkgDARatio_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtkgDARatio1.MouseDown, txtkgDARatio2.MouseDown, txtkgDARatio3.MouseDown, txtkgDARatio4.MouseDown, txtkgDARatio5.MouseDown, txtkgDARatio6.MouseDown
        If Val(CallKeyboard2(sender, "9999", "1")) > 0 Then
            Write_PLC_R1100(DAkgDARatio1Index + sender.TabIndex, Val(sender.Text))
            SaveParameter()
        End If
    End Sub

    Private Sub txtTopLowLimitTemp_MouseDown_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtTopLowLimitTemp.MouseDown
        If CallKeyboard2(sender, "150", "25") <> "" Then
            Write_PLC_R1100(DALimitPowerTempIndex, Val(sender.Text))
            SaveParameter()
        End If
    End Sub

    Private Sub txtTopLowLimitPower_MouseDown_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtTopLowLimitPower.MouseDown
        If CallKeyboard2(sender, "100", "0") <> "" Then
            Write_PLC_R1100(DALimitPowerIndex, Val(sender.Text) * 10)
            SaveParameter()
        End If
    End Sub

#End Region

#Region "真空計設定"
    Private Sub txtCHVacOffsetVoltage_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtCHVacOffsetVoltage.MouseDown
        If CallKeyboard2(sender, "10", "-10") <> "" Then
            GaugeCHVacOffsetVoltage = (sender.Text)
            WriteVacuumSetup(ProgramINIFile)
        End If
    End Sub
    Private Sub radAP2004_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radAP2004.Click, radGP275.Click, radZSE40.Click, radAPG100.Click, radPCG550.Click, radPSG500.Click
        GaugeName = sender.Text
        WriteVacuumSetup(ProgramINIFile)
    End Sub

    Private Sub txt1ATMVac_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txt1ATMVac.MouseDown
        If Val(CallKeyboard2(sender, "1000", "1")) > 0 Then
            Vac1ATM = Val(sender.Text)
            WriteVacuumSetup(ProgramINIFile)
        End If
    End Sub

    Private Sub txtBasePressureTest_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtBasePressureTest.MouseDown
        If Val(CallKeyboard3(sender, "1.0E+03", "1.0E-07")) > 0 Then
            lblBasePressure.Text = Format(TorrToAP2004Count(Val(sender.Text)), "0")
        End If
    End Sub
#End Region

#Region "PID 設定存檔"
    Private Sub btnLoadPIDFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadPIDFile.Click
        Dim i As Integer
        Dim astr As String
        astr = CallFileSelect(PIDsDir, "*.PID")
        If IO.File.Exists(PIDsDir + astr) Then
            If MsgBoxLangYesNo("確定要載入 " + astr, "Confirm Load " + astr) Then
                For i = 0 To MAXPLATE
                    'ReadPID(1, PIDsDir + astr)
                    PIDs(i).ReadParameter(PIDsDir + astr)
                Next
                txtPIDFileName.Text = Mid(astr, 1, Len(astr) - 4)
            End If
        End If
    End Sub

    Private Sub btnSavePIDFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSavePIDFile.Click
        Dim i As Integer
        Dim astr As String
        If txtPIDFileName.Text = "" Then CallKeyboard1(txtPIDFileName)
        If txtPIDFileName.Text = "" Then Exit Sub
        astr = txtPIDFileName.Text + ".PID"
        If MsgBoxLangYesNo("確定要儲存 " + astr, "Confirm Save " + astr) Then
            If IO.File.Exists(PIDsDir + astr) Then
                If MsgBoxLangYesNo("檔案 " + astr + " 已存在,要覆蓋?", "File  " + astr + " Exist, Overwrite?") = False Then
                    Exit Sub
                End If
            End If
            IO.File.Delete(PIDsDir + astr)
            For i = 0 To MAXPLATE
                'ReadPID(1, PIDsDir + astr)
                PIDs(i).WriteParameter(PIDsDir + astr)
            Next
            'WritePID(1, PIDsDir + astr)
        End If
    End Sub


    Private Sub txtPIDFileName_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtPIDFileName.MouseDown
        CallKeyboard1(sender)
    End Sub
#End Region

#Region "溫控器參數"
    ' 自動調諧寫入
    'Private Sub btnTopAT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Output(DoWAT01Index).Status = Not Output(DoWAT01Index).Status
    'End Sub
    'Private Sub btnBotAT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Output(DoWAT01Index).Status = Not Output(DoWAT01Index).Status
    'End Sub
    ''PID值寫入

    'Private Sub btnTopPID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'TopArea1 = False
    '    'TopArea2 = False
    '    'TopArea3 = False
    '    'Write_PLC_R1100(DATopP1Index, Val(sender.Text) * 10)
    '    'Write_PLC_R1100(DATopI1Index, Val(sender.Text))
    '    'Write_PLC_R1100(DATopD1Index, Val(sender.Text))
    '    'Write_PLC_R1100(DATopMax1Index, Val(sender.Text) * 10)
    '    'Write_PLC_R1100(DATopMin1Index, Val(sender.Text) * 10)
    '    'Output(DoTopWPID01Index).Status = Not Output(DoTopWPID01Index).Status
    'End Sub
    'Private Sub btnBotPID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'BotArea1 = False
    '    'BotArea2 = False
    '    'BotArea3 = False
    '    'Write_PLC_R1100(DABotP1Index, Val(sender.Text))
    '    'Write_PLC_R1100(DABotI1Index, Val(sender.Text))
    '    'Write_PLC_R1100(DABotD1Index, Val(sender.Text))
    '    'Write_PLC_R1100(DABotMax1Index, Val(sender.Text))
    '    'Write_PLC_R1100(DABotMin1Index, Val(sender.Text))
    '    'Output(DoBotWPID01Index).Status = Not Output(DoBotWPID01Index).Status
    'End Sub

    ''PID值 儲存
    ''Write P
    'Private Sub txtTopPL_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    '    CallKeyboard2(sender, "100", "1")
    '    SaveParameter()
    'End Sub
    ''Write I,D
    'Private Sub txtTopIL_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    '    CallKeyboard2(sender, "3600", "1")
    '    SaveParameter()
    'End Sub
    ''Write Min,Max
    'Private Sub txtTopMaxL_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    '    CallKeyboard2(sender, "100", "0")
    '    'TopArea1 = False
    '    'TopArea2 = False
    '    'TopArea3 = False
    '    'BotArea1 = False
    '    'BotArea2 = False
    '    'BotArea3 = False
    '    SaveParameter()
    'End Sub

    ''Temp Rage 
    'Private Sub txtTopTempRage1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    '    CallKeyboard2(sender, "9999", "0")
    '    SaveParameter()
    'End Sub
    '' Top Low Temp Power Limit  --Temp
    'Private Sub txtTopLowLimitTemp_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)

    'End Sub
    '' Top Low Temp Power Limit -- Power
    'Private Sub txtTopLowLimitPower_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)

    'End Sub

    ''Bot Low Temp Power Limit  --Temp
    'Private Sub txtBotLowLimitTemp_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    '    CallKeyboard2(sender, "100", "1")
    '    Write_PLC_R1100(DALimitPowerTempIndex, SetCalibratedTemp(Val(sender.Text), tempBotX, tempBotY, 5))
    '    SaveParameter()
    'End Sub
    ''Bot Low Temp Power Limit -- Power
    'Private Sub txtBotLowLimitPower_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    '    CallKeyboard2(sender, "100", "1")
    '    Write_PLC_R1100(DALimitPowerIndex, Val(sender.Text) * 10)
    '    SaveParameter()
    'End Sub
#End Region





    'Private Sub txtTopFlowMeter_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtTopFlowMeter.MouseDown
    '    If CallKeyboard2(sender, "9999", "0") <> "" Then
    '        SaveParameter()
    '    End If
    'End Sub
    'Private Sub txtBotFlowMeter_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtBotFlowMeter.MouseDown
    '    If CallKeyboard2(sender, "9999", "0") <> "" Then
    '        SaveParameter()
    '    End If
    'End Sub

    Private Sub txtLowFlowAlarm_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtLowFlowAlarm.MouseDown
        If CallKeyboard2(sender, "9999", "0") <> "" Then
            SaveParameter()
        End If
    End Sub


    Private Sub btnTempCal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'FormTempCals.Show()
    End Sub

    Private Sub txtTempAlarmTime_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtTempAlarmTime.MouseDown
        If CallKeyboard2(sender, "10000000", "5") <> "" Then
            TOPTEMPRUNTIME = Val(sender.Text)
            BOTTEMPRUNTIME = Val(sender.Text)
            SaveParameter()
        End If
    End Sub

    Private Sub txtPressAlarmTime_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtPressAlarmTime.MouseDown
        If CallKeyboard2(sender, "10000000", "5") <> "" Then
            BONDFORCETIME = Val(sender.Text)
            SaveParameter()
        End If
    End Sub

    Private Sub txtProcessTempAlarmTime_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtProcessTempAlarmTime.MouseDown
        If CallKeyboard2(sender, "9999", "5") <> "" Then
            PROCESSTOPTEMPTIME = Val(sender.Text)
            PROCESSBOTTEMPTIME = Val(sender.Text)
            SaveParameter()
        End If
    End Sub

    Private Sub txtProcessPressAlarmTime_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtProcessPressAlarmTime.MouseDown
        If CallKeyboard2(sender, "9999", "5") <> "" Then
            PROCESSBONDFORCETIME = Val(sender.Text)
            SaveParameter()
        End If
    End Sub





    Private Sub txtHeaterCount_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtHeaterCount.MouseDown
        If CallKeyboard2(sender, "100", "1") <> "" Then
            SaveParameter()
        End If
    End Sub

    Private Sub txtHeaterPower_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtHeaterPower.MouseDown
        If CallKeyboard2(sender, "9999", "1") <> "" Then
            SaveParameter()
        End If
    End Sub

    Private Sub txtHeaterVoltage_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtHeaterVoltage.MouseDown
        If CallKeyboard2(sender, "9999", "1") <> "" Then
            SaveParameter()
        End If
    End Sub

    Private Sub txtHeaterMonitorPower_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtHeaterMonitorPower.MouseDown
        If CallKeyboard2(sender, "100", "1") <> "" Then
            SaveParameter()
        End If
    End Sub

    Private Sub txtHeaterCurrentRate_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtHeaterCurrentRate.MouseDown
        If CallKeyboard2(sender, "100", "1") <> "" Then
            SaveParameter()
        End If
    End Sub


    Public Sub CalCurrent()
        Dim a, b, c As Double
        If Val(txtHeaterVoltage.Text) <= 0 Then txtHeaterVoltage.Text = "220"
        MonitorPower = Val(txtHeaterMonitorPower.Text)
        MonitorCurrent = Val(txtHeaterCount.Text) * Val(txtHeaterPower.Text) / Val(txtHeaterVoltage.Text)
        lblFullCurrent.Text = Format(MonitorCurrent * MonitorPower / 100, "0.00")
        MonitorCurrentLimit = MonitorCurrent * Val(txtHeaterCurrentRate.Text) / 100
        lblHeaterCurrent.Text = Format(MonitorCurrentLimit, "0.00")
    End Sub

    Private Sub txtHeaterAlarmTime_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtHeaterAlarmTime.MouseDown
        If CallKeyboard2(sender, "10000", "1") <> "" Then
            CURRENTMONITORTIME = Val(sender.Text)
            SaveParameter()
        End If

    End Sub

    Private Sub txtRVONDelay_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtRVONDelay.MouseDown
        If CallKeyboard2(sender, "100", "30") <> "" Then
            CAutoPumping.SetRV_ON_Time = Val(sender.Text)
        End If
    End Sub

    Private Sub btnForceDAOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnForceDAOut.Click
        Output(DoForceDAOutIndex).Status = Not Output(DoForceDAOutIndex).Status
    End Sub

    Private Sub btn1ATMSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1ATMSelect.Click
        Vac1ATM_Select = Not Vac1ATM_Select
        SaveParameter()
    End Sub


    '製程中斷設定
    Private Sub txtAbortPressureRange_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtAbortPressureRange.MouseDown
        If CallKeyboard2(sender, PRESS_MAX, PRESS_MIN) <> "" Then
            SaveParameter()
        End If
    End Sub

    Private Sub txtAbortTempRange_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtAbortTempRange.MouseDown
        If CallKeyboard2(sender, PRESS_MAX, PRESS_MIN) <> "" Then
            SaveParameter()
        End If
    End Sub

    Private Sub chkPressureAbort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPressureAbort.Click
        SystemParameters.AbortPressureRangeFlag = GetTrue01String(chkPressureAbort.Checked)
        SaveParameter()
    End Sub

    Private Sub chkTempAbort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTempAbort.Click
        SystemParameters.AbortTempRangeFlag = GetTrue01String(chkTempAbort.Checked)
        SaveParameter()
    End Sub

    Private Sub txtMaxTempPower_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtMaxTempPower.MouseDown
        If CallKeyboard2(sender, "100", "0") <> "" Then
            Write_PLC_R1100(DAMaxTempPowerIndex, Val(sender.Text) * 10)
            SaveParameter()
        End If
    End Sub

    Private Sub txtControlDelayTime_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtControlDelayTime.MouseDown
        If CallKeyboard2(sender, "100", "1") <> "" Then
            Write_PLC_R1100(DAControlRangeTimeIndex, Val(sender.Text))
            Form1.Timer2.Interval = Val(sender.Text) * 100
            SaveParameter()
        End If
    End Sub


    Private Sub btnReadProgramINI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        On Error Resume Next
        Shell("Notepad.exe " + ProgramDir + sender.Text, AppWinStyle.NormalFocus)
    End Sub

    Private Sub txtDpCurrentAlarmTime_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtDpCurrentAlarmTime.MouseDown
        If CallKeyboard2(sender, "100", "5") <> "" Then
            SaveParameter()
        End If
    End Sub

    Private Sub txtNoControlPress_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtNoControlPress.MouseDown
        If CallKeyboard2(sender, "500", "0") <> "" Then
            SaveParameter()
            Write_PLC_R1100(DANoControlPresssIndex, Val(sender.Text))
        End If
    End Sub

    Private Sub btnReload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReload.Click
        LoadParameterToForm()
    End Sub


    Private Sub radDryPump_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radDryPump.Click, radMachinePump.Click, radUlvacLS120.Click
        DP_Pump_Used = radDryPump.Checked
        Ulvac_LS120_Used = radUlvacLS120.Checked
        If Ulvac_LS120_Used Then
            Write_PLC_R1100(DADPMPSelectIndex, 1)
        Else
            If DP_Pump_Used Then
                Write_PLC_R1100(DADPMPSelectIndex, 0)
            Else
                Write_PLC_R1100(DADPMPSelectIndex, 1)
            End If
        End If

        WritePumpSetup(ProgramINIFile)
    End Sub



    Private Sub btnFlowMode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFlowMode.Click
        FlowMeterMode = Not FlowMeterMode
        WriteFlowMeterMode(ParameterINIFile)
    End Sub

    Private Sub txtDPTempAlarmText_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtDPTempAlarmText.MouseDown
        If CallKeyboard2(sender, "70", "25") <> "" Then
            Write_PLC_R1100(DADPOverTempIndex, Val(sender.Text))
        End If
    End Sub

    Private Sub txtDPTempAlarmOff_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtDPTempAlarmOff.MouseDown
        If CallKeyboard2(sender, "80", "25") <> "" Then
            Write_PLC_R1100(DADPOverTempOFFIndex, Val(sender.Text))
        End If
    End Sub

    Private Sub txtDPTempCalSet_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtDPTempCalSet.MouseDown
        If CallKeyboard2(sender, "100", "-100") <> "" Then
            Write_PLC_R1100(DADPTempOffsetIndex, Val(sender.Text))
        End If
    End Sub

    Private Sub txtOutRangAddDA1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtOutRangAddDA1.MouseDown, txtOutRangAddDA2.MouseDown, txtOutRangAddDA3.MouseDown, txtOutRangAddDA4.MouseDown, txtOutRangAddDA5.MouseDown, txtOutRangAddDA6.MouseDown
        If CallKeyboard2(sender, "500", "0") <> "" Then
            Write_PLC_R1100(DAOutRangAddDA1Index + sender.tabindex, Val(sender.Text))
        End If
    End Sub

    Private Sub txtTICComport_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtTICComport.MouseDown
        If CallKeyboard2(sender, "6", "2") <> "" Then
            TIC_MONITOR_COMPORT = Val(sender.Text)
            WriteProgData("TIC_MONITOR", "TIC_MONITOR_COMPORT", TIC_MONITOR_COMPORT.ToString, ProgramINIFile)
            MsgBoxLangOK("為使設定值生效,請重新開啟程式!")
        End If

    End Sub

    Private Sub chkTICMonitorUsed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTICMonitorUsed.Click
        TIC_MONITOR_USED = chkTICMonitorUsed.Checked
        WriteProgData("TIC_MONITOR", "TIC_MONITOR_USED", GetTrue01String(TIC_MONITOR_USED), ProgramINIFile)
        MsgBoxLangOK("為使設定值生效,請重新開啟程式!")
    End Sub


    Private Sub chkBarcodeOnly_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBarcodeOnly.Click
        SystemParameters.BarcodeOnly = GetTrue01String(chkBarcodeOnly.Checked)
        WriteProgData("PARAMETER", "BarcodeOnly", SystemParameters.BarcodeOnly, ParameterINIFile)
    End Sub

    Private Sub chkAutoRecordData_Click(sender As System.Object, e As System.EventArgs) Handles chkAutoRecordData.Click
        SystemParameters.AutoRecordData = GetTrue01String(chkAutoRecordData.Checked)
        WriteProgData("PARAMETER", "AutoRecordData", SystemParameters.AutoRecordData, ParameterINIFile)
    End Sub

    'Add  by Vincent 20180419  ------------------- Start
    Private Sub btnTempTrackDisable_Click(sender As System.Object, e As System.EventArgs) Handles btnTempTrackDisable.Click
        Output(DoTempTrackDisableIndex).Status = Not Output(DoTempTrackDisableIndex).Status
    End Sub
    Private Sub chkSplitTopBotTemp_Click(sender As System.Object, e As System.EventArgs) Handles chkSplitTopBotTemp.Click
        SystemParameters.SplitTopBotTemp = GetTrue01String(chkSplitTopBotTemp.Checked)
        WriteProgData("PARAMETER", "SplitTopBotTemp", SystemParameters.SplitTopBotTemp, ParameterINIFile)
    End Sub

    Private Sub chkSplitTopBotTempEnable_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkSplitTopBotTempEnable.Click
        SystemParameters.SplitTopBotTempEnable = GetTrue01String(chkSplitTopBotTempEnable.Checked)
        WriteProgData("PARAMETER", "SplitTopBotTempEnable", SystemParameters.SplitTopBotTempEnable, ParameterINIFile)
    End Sub
    'Add  by Vincent 20180419  ------------------- End


    'Add  by Vincent 20181016  壓力修整功能 ------------------- Start
    Private Sub txtPressureAverageTimes_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles txtPressureAverageTimes.MouseDown
        If FormKeyboard2s.KeyInString(sender, "1000", "1") <> "" Then
            SystemParameters.PressureAverageTimes = sender.Text
            WriteProgData("PARAMETER", "PressureAverageTimes", SystemParameters.PressureAverageTimes, ParameterINIFile)
        End If
    End Sub


    Private Sub chkPressureAdjust_Click(sender As System.Object, e As System.EventArgs) Handles chkPressureAdjust.Click '不用
        SystemParameters.PressureAdjust = GetTrue01String(chkPressureAdjust.Checked)
        WriteProgData("PARAMETER", "PressureAdjust", SystemParameters.PressureAdjust, ParameterINIFile)
    End Sub

    Private Sub txtPeakLimit_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles txtPeakLimit.MouseDown
        If FormKeyboard2s.KeyInString(sender, "30000", "0") <> "" Then
            SystemParameters.PeakLimit = sender.Text
            WriteProgData("PARAMETER", "PeakLimit", SystemParameters.PeakLimit, ParameterINIFile)
        End If
    End Sub

    Private Sub txtPeakTimes_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles txtPeakTimes.MouseDown
        If FormKeyboard2s.KeyInString(sender, "1000", "0") <> "" Then
            SystemParameters.PeakTimes = sender.Text
            WriteProgData("PARAMETER", "PeakTimes", SystemParameters.PeakTimes, ParameterINIFile)
        End If
    End Sub
    'Add  by Vincent 20181016  壓力修整功能 ------------------- End

    'By chesly 20181023 壓缸自動循環動作 start
#Region "By chesly 20170914 壓缸自動循環動作"
    Private Sub btnCycleRun_Click(sender As System.Object, e As System.EventArgs) Handles btnCycleRun1.Click, btnCycleRun2.Click, btnCycleRun3.Click, btnCycleRun4.Click, btnCycleRun5.Click, btnCycleRun6.Click
        If ProcessMode_RUN = True Then Exit Sub
        Dim Index As Integer
        Index = sender.Tabindex
        Select Case Index
            Case 0
                BondCycle1.StartRun = Not BondCycle1.StartRun
            Case 1
                BondCycle2.StartRun = Not BondCycle2.StartRun
            Case 2
                BondCycle3.StartRun = Not BondCycle3.StartRun
            Case 3
                BondCycle4.StartRun = Not BondCycle4.StartRun
            Case 4
                BondCycle5.StartRun = Not BondCycle5.StartRun
            Case 5
                BondCycle6.StartRun = Not BondCycle6.StartRun
        End Select
    End Sub
    Private Sub btnPlateUpAutoCycleRun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlateUpACR1.Click, btnPlateUpACR2.Click, btnPlateUpACR3.Click, btnPlateUpACR4.Click, btnPlateUpACR5.Click, btnPlateUpACR6.Click

        Dim Index As Integer
        Dim UpIndex, DownIndex, ForceIndex As Integer
        If ProcessMode_RUN Then Exit Sub

        Index = sender.Tabindex
        UpIndex = DoBondUp01Index + Index * 4
        DownIndex = DoBondDown01Index + Index * 4
        ForceIndex = DoBondForce01Index + Index
        If Output(UpIndex).Status Then
            Output(UpIndex).Status = False
        Else
            'If (PLC_X(DiDoor1UpIndex) = "0" Or PLC_X(DiDoor2UpIndex) = "0") Then
            '    MsgBoxLangErr("腔門未關閉,請關閉腔門!", "腔�d未����,�[���葭��d!", "Door not Close!")
            'Else
            If OilPumpUsed Then
                If Check_PLC_M(DoOilPump01Index + Index * 4) Then
                    If MsgBoxLangYesNo("請確認載盤已置放!", "Please Cormfirm Plate Up!") Then
                        Output(UpIndex).Status = True
                        Output(DownIndex).Status = False
                        Output(ForceIndex).Status = False
                    End If
                Else
                    MsgBoxLangErr("油壓幫浦未啟動!", "Oil Pump need ON!")
                End If
            Else
                If MsgBoxLangYesNo("請確認載盤已置放!", "Please Cormfirm Plate Up!") Then
                    Output(UpIndex).Status = True
                    Output(DownIndex).Status = False
                    Output(ForceIndex).Status = False
                End If
            End If
            'End If
        End If

        'If ChuckUpPb_Status Then
        '    ChuckUpPb_Status = False
        'Else
        '    If PLC_X(DiDoor1UpIndex) = "0" Then
        '        MsgBoxLangErr("腔門未關閉,請關閉腔門!", "腔�d未����,�[���葭��d!", "Door not Close!")
        '    Else
        '        'If Check_PLC_M(DoOilPumpIndex) Then
        '        If MsgBoxLangYesNo("請確認載盤已置放!", "�[确�P�^�髐w置放!", "Please Cormfirm Plate Up!") Then
        '            ChuckUpPb_Status = Not ChuckUpPb_Status
        '            ChuckDnPb_Status = False
        '            BoundingPb_Status = False
        '        End If
        '        '    Else
        '        '    MsgBoxLangErr("油壓幫浦未啟動!", "油���眳�未�Q��!", "Oil Pump need ON!")
        '        'End If
        '    End If
        'End If
    End Sub

    Private Sub btnPlateDownAutoCycleRun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlateDownACR1.Click, btnPlateDownACR2.Click, btnPlateDownACR3.Click, btnPlateDownACR4.Click, btnPlateDownACR5.Click, btnPlateDownACR6.Click
        Dim Index As Integer
        Dim UpIndex, DownIndex, ForceIndex As Integer
        If ProcessMode_RUN Then Exit Sub

        Index = sender.Tabindex
        UpIndex = DoBondUp01Index + Index * 4
        DownIndex = DoBondDown01Index + Index * 4
        ForceIndex = DoBondForce01Index + Index

        If Output(DownIndex).Status Then
            Output(DownIndex).Status = False
        Else
            If OilPumpUsed Then
                If Check_PLC_M(DoOilPump01Index + Index * 4) Then
                    Output(UpIndex).Status = False
                    Output(DownIndex).Status = True
                    Output(ForceIndex).Status = False
                Else
                    MsgBoxLangErr("油壓幫浦未啟動!", "Oil Pump need ON!")
                End If
            Else
                Output(UpIndex).Status = False
                Output(DownIndex).Status = True
                Output(ForceIndex).Status = False
            End If
        End If
    End Sub
#End Region

    Private Sub BondCycleDoorChk_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles BondCycleDoorChk.CheckedChanged
        DoorChk = Not DoorChk
    End Sub

    Private Sub txtC_Timer_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtC_Timer.MouseDown
        If CallKeyboard2(sender, 60, 10) <> "" Then
            txtC_Time = Val(sender.text) * 10
        End If
    End Sub

    Private Sub txtCR_Timer_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCR_Timer.MouseDown
        If CallKeyboard2(sender, 999, 1) <> "" Then
            txtCR_Time = Val(sender.text)
        End If
    End Sub
    'By chesly 20181023 壓缸自動循環動作 End
    Private Sub txtPullerTime_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles txtPullerTime.MouseDown
        If CallKeyboard2(sender, "180", "0") <> "" Then
            PULLERTIME = sender.Text
            WriteProgData("ALARM_TIMER", "PULLERTIME", PULLERTIME, AlarmINIFile)
        End If

    End Sub

    Private Sub txtDoorCloseTime_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles txtDoorCloseTime.MouseDown
        If CallKeyboard2(sender, "180", "0") <> "" Then
            DOORTIME = sender.Text
            WriteProgData("ALARM_TIMER", "DOORTIME", DOORTIME, AlarmINIFile)
        End If

    End Sub

    Private Sub txtProcessPumpTime_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles txtProcessPumpTime.MouseDown
        If CallKeyboard2(sender, "10000", "0") <> "" Then
            PUMPINGTIME = sender.Text
            WriteProgData("ALARM_TIMER", "PUMPINGTIME", PUMPINGTIME, AlarmINIFile)
        End If
    End Sub

    Private Sub txtProcessPumpVacuum_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles txtProcessPumpVacuum.MouseDown
        If CallKeyboard3(sender, "7.6E+02", "1.0E-03") <> "" Then
            PUMPINGVACUUM = sender.Text
            WriteProgData("ALARM_TIMER", "PUMPINGVACUUM", PUMPINGVACUUM, AlarmINIFile)
        End If

    End Sub
    'Add  by Vincent 20190710  ------------------- Start
    Private Sub chkCIMUsed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCIMUsed.Click
        CIM_Used = chkCIMUsed.Checked
        RemoteCIM.WriteCIMSetup()
        If CIM_Used Then
            WriteProgData("PROGRAM", "BarCodeFile", 0, ProgramINIFile)  '寫入目前控壓PID設定
        End If
    End Sub

    'Add  by Vincent 20190710  ------------------- End
    Private Sub txtRPOnPressure_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If Val(FormKeyboard2s.KeyInString(sender, "100", "1.0E-01")) > 0 Then
            SystemParameters.RPONPressure = sender.Text
            WriteProgData("PARAMETER", "RPONPressure", SystemParameters.RPONPressure, ParameterINIFile)
        End If
    End Sub

    Private Sub txtVentOffDelay_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles txtVentOffDelay.MouseDown
        If FormKeyboard2s.KeyInString(sender, "9999", "0.0") <> "" Then
            SystemParameters.VentOffDelay = sender.Text
            WriteProgData("PARAMETER", "VentOffDelay", SystemParameters.VentOffDelay, ParameterINIFile)
        End If
    End Sub

    Private Sub txtDPWaterFlowHz_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs)
        If FormKeyboard2s.KeyInString(sender, "99999", "1") <> "" Then
            SystemParameters.DPWaterFlowHz = sender.Text
            WriteProgData("PARAMETER", "DPWaterFlowHZ", SystemParameters.DPWaterFlowHz, ParameterINIFile)
        End If
    End Sub

    Private Sub txtDPWaterFlowMax_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs)
        If FormKeyboard2s.KeyInString(sender, "99999", "1") <> "" Then
            SystemParameters.DPWaterFlowHzMax = sender.Text
            WriteProgData("PARAMETER", "DPWaterFlowHzMax", SystemParameters.DPWaterFlowHzMax, ParameterINIFile)
        End If
    End Sub

    Private Sub txtDPWaterFlowAlarm_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles txtDPWaterFlowAlarm.MouseDown
        If FormKeyboard2s.KeyInString(sender, "40.0", "0.0") <> "" Then
            SystemParameters.DPWaterFlowAlarm = sender.Text
            WriteProgData("PARAMETER", "DPWaterFlowAlarm", SystemParameters.DPWaterFlowAlarm, ParameterINIFile)
        End If
    End Sub

    '使用電阻尺,解析度0.1mm
    Private Sub txtRullerLength_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles txtRullerLength.MouseDown
        If CallKeyboard2(sender, "500", "0") <> "" Then
            Write_PLC_R1100(DARullerLengthIndex, Val(sender.Text) * 10)
        End If
    End Sub

    Private Sub btUp_Click(sender As Object, e As EventArgs) Handles btUp.Click
        Timer2.Enabled = True
        Timer2.Interval = txtinterval.Text
        tempi = Int(txtdown.Text)
        txtHighPDAOut.Text = tempi
        bolUp = True
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If btnForceDAOut.BackColor = Color.Lime Then
            If bolUp = True Then '上
                txtHighPDAOut.Text = tempi
                Write_PLC_R1100(DAHighDAIndex, tempi)
                tempi = tempi + 1
                If tempi > Int(txtup.Text) Then
                    Timer2.Enabled = False
                    CSVTimerStartPb_Status = False
                End If
            Else
                txtHighPDAOut.Text = tempi
                Write_PLC_R1100(DAHighDAIndex, tempi)
                tempi = tempi - 1
                If tempi < Int(txtdown.Text) Then
                    Timer2.Enabled = False
                    CSVTimerStartPb_Status = False
                End If
            End If

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer2.Enabled = False
    End Sub

    Private Sub btDn_Click(sender As Object, e As EventArgs) Handles btDn.Click
        Timer2.Enabled = True
        Timer2.Interval = txtinterval.Text
        tempi = Int(txtup.Text)
        txtHighPDAOut.Text = tempi
        bolUp = False
    End Sub

    Private Sub btnlog_Click(sender As Object, e As EventArgs) Handles btnlog.Click

        Dim tempstr As String
        tempstr = DataLogRecordFileName
        If CSVTimerStartPb_Status = True Then
            CSVTimerStartPb_Status = False
        Else
            DataLogRecordFileName = ""
            If FormKeyInDataLogNames.ShowDialog() = Windows.Forms.DialogResult.OK Then
                If Len(DataLogShortFileName) > 0 Then
                    CheckDataLogDirAndCreate()

                    FormManuals.lblDatalogFileName.Text = DataLogRecordFileName
                    DatalogTime = Val(FormManuals.txtDataLogStepTime.Text)
                    CSVTimerStartPb_Status = True
                End If
            End If
        End If
        'CSVTimerStartPb_Status = Module_Button.CSVTimerStartPb_Status

    End Sub

    Private Sub dudLogStartTime_SelectedItemChanged(sender As Object, e As EventArgs)
        SystemParameters.StartLog_Time = dudLogStartTime.Text
        WriteProgData("PARAMETER", "StartLog_Time", SystemParameters.StartLog_Time, ParameterINIFile)
    End Sub

    Private Sub chkRunConfirm_Click(sender As Object, e As EventArgs) Handles chkRunConfirm.Click
        SystemParameters.RunConfirm = GetTrue01String(chkRunConfirm.Checked)
        WriteProgData("PARAMETER", "RunConfirm", SystemParameters.RunConfirm, ParameterINIFile)
    End Sub
    Private Sub btnShowPicControl_Click(sender As Object, e As EventArgs) Handles btnShowPicControl.Click
        Dim show As New FormMesgBox_passward

        'show.ShowDialog()
        If show.ShowDialog(Me) = System.Windows.Forms.DialogResult.Yes Then
        Else
            'MessageBox.Show("密碼錯誤")
            Exit Sub
        End If

        PressPID_Flag = Not PressPID_Flag
        If PressPID_Flag Then
            FormParameters.flwPressPID.Visible = True
            FormParameters.Panel1.Visible = False
            FormParameters.pnlPressureAverage.Visible = True
            lblOutRangAddDAText.Visible = False
            txtOutRangAddDA1.Visible = False
            txtOutRangAddDA2.Visible = False
            txtOutRangAddDA3.Visible = False
            lblkgDARatioText.Visible = False
            txtkgDARatio1.Visible = False
            txtkgDARatio2.Visible = False
            txtkgDARatio3.Visible = False
            WriteProgData("PROGRAM", "PressPID", 1, ProgramINIFile)  '寫入目前控壓PID設定
        Else
            FormParameters.flwPressPID.Visible = False
            FormParameters.Panel1.Visible = True
            FormParameters.pnlPressureAverage.Visible = True
            lblOutRangAddDAText.Visible = True
            txtOutRangAddDA1.Visible = True
            txtOutRangAddDA2.Visible = True
            txtOutRangAddDA3.Visible = True
            lblkgDARatioText.Visible = True
            txtkgDARatio1.Visible = True
            txtkgDARatio2.Visible = True
            txtkgDARatio3.Visible = True
            WriteProgData("PROGRAM", "PressPID", 0, ProgramINIFile)  '寫入設定目前舊式PID控壓
        End If
    End Sub

    Private Sub btnSelPath_Click(sender As Object, e As EventArgs) Handles btnSelPath.Click
        Dim folderBrowserDialog1 As New FolderBrowserDialog
        'folderBrowserDialog1.ShowDialog()
        Dim result As DialogResult = folderBrowserDialog1.ShowDialog()
        If result = DialogResult.OK Then
            txtWebPath.Text = folderBrowserDialog1.SelectedPath
            SystemParameters.WebPath = txtWebPath.Text
            WriteProgData("PARAMETER", "WebPath", SystemParameters.WebPath, ParameterINIFile)
        End If
    End Sub

    Private Sub chkAvailBarCode_Click(sender As Object, e As EventArgs) Handles chkAvailBarCode.Click
        BarCodeFile_Flag = chkAvailBarCode.Checked
        'Panel3.Visible = BarCodeFile_Flag
        If BarCodeFile_Flag Then
            WriteProgData("PROGRAM", "BarCodeFile", 1, ProgramINIFile)  '寫入稼動率設定

        Else
            WriteProgData("PROGRAM", "BarCodeFile", 0, ProgramINIFile)  '寫入稼動率設定
        End If

    End Sub


    Private Sub chkDa_CheckedChanged(sender As Object, e As EventArgs) Handles chkDa.CheckedChanged
        SystemParameters.bolDAlog = chkDa.Checked
        WriteProgData("PARAMETER", "DALog", SystemParameters.bolDAlog, ParameterINIFile)
        If SystemParameters.bolDAlog Then
            CurveDataINI = ProgramDir + "CURVEDATA_DA.INI"        '程式資料INI檔案 有DA欄位
            'bolDAShow = True
        Else
            CurveDataINI = ProgramDir + "CURVEDATA.INI"        '程式資料INI檔案
            'bolDAShow = False
        End If
    End Sub

    Private Sub btnSite1Cal_Click(sender As Object, e As EventArgs) Handles btnSite1Cal.Click
        If MsgBoxLangYesNo("請確認LoadCell已置放!", "Please Cormfirm Plate Up!") Then
            Output(DoBondUp01Index).Status = True
            Output(DoBondDown01Index).Status = False
            Output(DoBondForce01Index).Status = False
            BondAutoPressCal1.StartRun = Not BondAutoPressCal1.StartRun
        End If
    End Sub
    Private Sub btnSite2Cal_Click(sender As Object, e As EventArgs) Handles btnSite2Cal.Click
        If MsgBoxLangYesNo("請確認LoadCell已置放!", "Please Cormfirm Plate Up!") Then
            Output(DoBondUp02Index).Status = True
            Output(DoBondDown02Index).Status = False
            Output(DoBondForce02Index).Status = False
            BondAutoPressCal2.StartRun = Not BondAutoPressCal2.StartRun
        End If
    End Sub
    Private Sub btnSite3Cal_Click(sender As Object, e As EventArgs) Handles btnSite3Cal.Click
        If MsgBoxLangYesNo("請確認LoadCell已置放!", "Please Cormfirm Plate Up!") Then
            Output(DoBondUp03Index).Status = True
            Output(DoBondDown03Index).Status = False
            Output(DoBondForce03Index).Status = False
            BondAutoPressCal3.StartRun = Not BondAutoPressCal3.StartRun
        End If
    End Sub

    Private Sub lbl1stPlateUpProcedureText_DoubleClick(sender As Object, e As EventArgs) Handles lbl1stPlateUpProcedureText.DoubleClick
        GroupBox2.Visible = Not GroupBox2.Visible
    End Sub

    Private Sub picCelloLogo_DoubleClick(sender As Object, e As EventArgs) Handles picCelloLogo.DoubleClick
        GroupBox3.Visible = Not GroupBox3.Visible
    End Sub

    Private Sub Label13_DoubleClick(sender As Object, e As EventArgs) Handles Label13.DoubleClick
        GroupBox3.Visible = Not GroupBox3.Visible
    End Sub

    Private Sub txtdown_MouseDown(sender As Object, e As MouseEventArgs) Handles txtdown.MouseDown
        If CallKeyboard2(sender, "9999", "1") <> "" Then
            'Write_PLC_R1100(DAT1stControlKgIndex, Val(sender.Text))
            'SaveParameter()
        End If
    End Sub

    Private Sub txtup_MouseDown(sender As Object, e As MouseEventArgs) Handles txtup.MouseDown
        If CallKeyboard2(sender, "9999", "1") <> "" Then

        End If
    End Sub

    Private Sub txtinterval_MouseDown(sender As Object, e As MouseEventArgs) Handles txtinterval.MouseDown
        If CallKeyboard2(sender, "9999", "1") <> "" Then

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        rdoPressureAverage.Checked = False
        rdoPeakClear.Checked = False

    End Sub

    Private Sub rdoPressureAverage_CheckedChanged(sender As Object, e As EventArgs) Handles rdoPressureAverage.CheckedChanged
        SystemParameters.PressureAverageEnable = GetTrue01String(rdoPressureAverage.Checked)
        WriteProgData("PARAMETER", "PressureAverageEnable", SystemParameters.PressureAverageEnable, ParameterINIFile)
    End Sub

    Private Sub rdoPeakClear_CheckedChanged(sender As Object, e As EventArgs) Handles rdoPeakClear.CheckedChanged
        SystemParameters.PeakClearEnable = GetTrue01String(rdoPeakClear.Checked)
        WriteProgData("PARAMETER", "PeakClearEnable", SystemParameters.PeakClearEnable, ParameterINIFile)
    End Sub

    Private Sub txtCR_Timer_TextChanged(sender As Object, e As MouseEventArgs) Handles txtCR_Timer.MouseDown

    End Sub

    Private Sub txtC_Timer_TextChanged(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim ii As Integer
        Dim jj As Integer
        Dim KK As Integer
        Dim ShowData As String
        DataLogShortFileName = "Check_" & NYear & "_" & NMonth & "_" & NDate & "-" & NHour & "_" & NMin & "_" & NSec + ".csv"
        CheckDataLogDirAndCreate()
        DataLogRecordFileName = DataLogRecordDir + DataLogShortFileName

        ShowData = "ID" + Space(15 - Len("ID")) + vbTab + "OriPress" + Space(15 - Len("OriPress")) + vbTab + "SetPress" + Space(15 - Len("SetPress")) + vbTab + "limit" + Space(15 - Len("limit"))
        AppendData(DataLogRecordFileName, ShowData, 150)
        For ii = 0 To intPeakClearTimes(0) - 1
            ShowData = ii.ToString + Space(15 - Len(ii.ToString)) + vbTab + dePeak(0, ii).OriPress.ToString + Space(15 - Len(dePeak(0, ii).OriPress.ToString)) + vbTab + dePeak(0, ii).SetPress.ToString + Space(15 - Len(dePeak(0, ii).SetPress.ToString)) + vbTab + dePeak(0, ii).limit.ToString + Space(15 - Len(dePeak(0, ii).limit.ToString))
            'ShowData = ii.ToString + vbTab + dePeak(0, ii).OriPress.ToString + vbTab + dePeak(0, ii).SetPress.ToString + Space(15 - Len(dePeak(0, ii).SetPress.ToString)) + vbTab + dePeak(0, ii).limit.ToString + Space(15 - Len(dePeak(0, ii).limit.ToString))
            AppendData(DataLogRecordFileName, ShowData, 150)
        Next
        For jj = 0 To intPeakClearTimes(1) - 1
            ShowData = jj.ToString + Space(15 - Len(jj.ToString)) + vbTab + dePeak(1, jj).OriPress.ToString + Space(15 - Len(dePeak(1, jj).OriPress.ToString)) + vbTab + dePeak(1, jj).SetPress.ToString + Space(15 - Len(dePeak(0, jj).SetPress.ToString)) + vbTab + dePeak(0, jj).limit.ToString + Space(15 - Len(dePeak(0, jj).limit.ToString))

            AppendData(DataLogRecordFileName, ShowData, 150)
        Next
        For KK = 0 To intPeakClearTimes(2) - 1
            ShowData = KK.ToString + Space(15 - Len(KK.ToString)) + vbTab + dePeak(2, KK).OriPress.ToString + Space(15 - Len(dePeak(2, KK).OriPress.ToString)) + vbTab + dePeak(2, KK).SetPress.ToString + Space(15 - Len(dePeak(0, KK).SetPress.ToString)) + vbTab + dePeak(0, KK).limit.ToString + Space(15 - Len(dePeak(0, KK).limit.ToString))

            AppendData(DataLogRecordFileName, ShowData, 150)
        Next
    End Sub
End Class

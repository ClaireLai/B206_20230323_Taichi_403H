Imports System.Runtime.InteropServices

Module Module_AutoTask
    'Add by Vincent TCPIP 20200716  ---------------- Start
    Public SimulationMode As Boolean = False
    Public SimulationCount As Integer = 0
    'Add by Vincent TCPIP 20200716  ---------------- End

    'Barcode 20160808 by vincent ---------------- Start
    Public RunCounts As Integer = 0
    Public RunDataINIFile As String
    Public bolVaccTest As Boolean

    Public Sub ReadRunData()
        Dim sstr As String
        Dim sfile As String
        sfile = RunDataINIFile
        sstr = "RUNDATA"
        RunCounts = Val(ReadProgData(sstr, "RunCounts", "0", sfile))
        WriteProgData(sstr, "RunCounts", RunCounts.ToString, sfile)
    End Sub
    Public Sub WriteRunData()
        Dim sstr As String
        Dim sfile As String
        sfile = RunDataINIFile
        sstr = "RUNDATA"
        WriteProgData(sstr, "RunCounts", RunCounts.ToString, sfile)
    End Sub
    'Barcode 20160808 by vincent ---------------- End
    Public CSubAutoProcess(MAXPLATE) As CSubProcess

    '¤l»sµ{Ãþ§O
    Class CSubProcess

        Public TempTimeout_Error As Boolean
        Public ForceTimeout_Error As Boolean
        Private subPlateRecipe As New sPlateRecipe
        Private subRecipeLoad As Boolean
        Public SubProcessEeventFileName As String      '»sµ{¨Æ¥óÀÉ¦W,§t¸ô®|,¨Ì»sµ{ÀÉ¦W+EVENT«Ø¥ß
        Public TempTopSV, TempBotSV As Integer
        Private TotoalStringListNum As Integer
        Private SubProcessListString(2, 99) As String
        Private TempTimeOutWDog As New Stopwatch
        Private ForceTimeOutWDog As New Stopwatch
        Private Sub TempTimeOutWDog_Restart()
            TempTimeOutWDog.Stop()
            TempTimeOutWDog.Reset()
            TempTimeOutWDog.Start()
        End Sub
        Private Sub ForceTimeOutWDog_Restart()
            ForceTimeOutWDog.Stop()
            ForceTimeOutWDog.Reset()
            ForceTimeOutWDog.Start()
        End Sub
        'Åª¨ú°õ¦r¦ê,3»y
        'process = »sµ{¦WºÙ,INI ÀÉ®×³]©w¬°==>  ­Y process= "PROCESS" [process"_
        'ReadStatusString (»sµ{¦W,Àx¦s3»y¤§2ºû°}¦C, ÀÉ®×¦W) ¶Ç¦^¦r¦êÁ`¼Æ --> ©w¸q©ó XXXX_=40
        '¤¤¤å¦r¦ê©w¸q¦p¤U, Â²Åé«h¬° _CHS, ­^¤å¬° _ENG
        '[PROCESS_CHT]   
        'PROCESS_NUM=10
        'PROCESS00=»sµ{¶}©l
        'PROCESS01=©â¯uªÅ
        '.....¾lÃþ±À
        '¤@¦¸Åª¤TºØ»y¨¥¦s¤J°}¦C¤¤
        Public Function ReadSubProcessString(ByVal process As String, ByRef sstr(,) As String, ByVal sfile As String) As Integer
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
                            section = process + "_CHS"
                        Case 2
                            section = process + "_ENG"
                    End Select
                    For i = 0 To num
                        para = process & Format(i, "00")
                        sstr(j, i) = ReadProgData(section, para, "No Message.", sfile)
                    Next
                Next j
            End If
            Return num
        End Function

        ''' <summary>
        ''' ¤l»sµ{
        ''' </summary>
        ''' <param name="sRecipe"></param>
        Public Sub LoadPlateRecipe(ByRef sRecipe As sPlateRecipe)
            subPlateRecipe = sRecipe

            SubProcessStepIndex = 0
            SubProcessHoldTimerSet = subPlateRecipe.Time(SubProcessStepIndex)
            SubRecipeStepIndex = subPlateRecipe.TotalStep

            ProcessData(SiteNum).PressuseSet = subPlateRecipe.Pressure(SubProcessStepIndex)
            ProcessData(SiteNum).PressuseRate = subPlateRecipe.Pressure_Rate(SubProcessStepIndex)
            ProcessData(SiteNum).TempSet = subPlateRecipe.Temperature(SubProcessStepIndex)
            ProcessData(SiteNum).TempRateSet = subPlateRecipe.Temperature_Rate(SubProcessStepIndex)
            ProcessData(SiteNum).HoldTimeSet = subPlateRecipe.Time(SubProcessStepIndex)
            ProcessData(SiteNum).StepSet = subPlateRecipe.TotalStep
            ProcessData(SiteNum).StepNote = subPlateRecipe.STEPNote(SubProcessStepIndex)
            subRecipeLoad = True


        End Sub

        'Public Sub LoadPlateRecipe(ByRef sRecipe As sPlateRecipe, ByVal iIndex As Integer)
        '    SubProcessHoldTimerSet = subPlateRecipe.Time(iIndex)
        '    SubRecipeStepIndex = subPlateRecipe.TotalStep
        '    ProcessData(SiteNum).PressuseSet = subPlateRecipe.Pressure(iIndex)
        '    ProcessData(SiteNum).PressuseRate = subPlateRecipe.Pressure_Rate(iIndex)
        '    ProcessData(SiteNum).TempSet = subPlateRecipe.Temperature(iIndex)
        '    ProcessData(SiteNum).TempRateSet = subPlateRecipe.Temperature_Rate(iIndex)
        '    ProcessData(SiteNum).HoldTimeSet = subPlateRecipe.Time(iIndex)
        '    ProcessData(SiteNum).StepSet = subPlateRecipe.TotalStep
        '    ProcessData(SiteNum).StepNote = subPlateRecipe.STEPNote(iIndex)
        'End Sub






        Private SiteNum As Integer
        Private RunFlag As Boolean    'À£¦X®É­«¸m¦±½u
        Private RunOKFlag As Boolean    'À£¦X®É­«¸m¦±½u
        Private AbortFlag As Boolean    'À£¦X®É­«¸m¦±½u claire 2023.06.20¬°½[°Ê²v§ï¬°public
        Private SkipFlag As Boolean    'À£¦X®É­«¸m¦±½u
        Public SelectedFlag As Boolean    'À£¦X®É­«¸m¦±½u

        Private CurveFlag As Boolean    'À£¦X®É­«¸m¦±½u
        Private CurveFreeze As Boolean  '§¹¦¨»sµ{®É, ©w¦í¦±½u

        '»sµ{¤¤©µ¿ð®É¶¡­p®É
        Private SubProcessTimerEnabled As Boolean
        Private SubProcessTimer As Integer
        '«O«ù®É¶¡­p®É
        Private SubProcessHoldTimerEnabled As Boolean
        Public SubProcessHoldTimer As Integer
        Private SubProcessHoldTimerSet As Integer   '«O«ù®É¶¡³]©w

        '¹w­p®É¶¡¤£¨ì ALARM­p®É
        Private SubProcessPresetTimerEnabled As Boolean
        Private SubProcessPresetTimer As Integer

        Private SubProcessStartTime As String       '»sµ{¶}©l®É¶¡
        Private SubProcessEndTime As String         '»sµ{µ²§ô®É¶¡
        Private SubProcessAbortTime As String       '»sµ{¤¤Â_®É¶¡

        Public SubProcessStatusString As String       '»sµ{ª¬ºA¦r¦ê

        Private SubTotalProcessTime As Integer  '»sµ{Á`®É¶¡(sec)

        ReadOnly Property RunIndex() As Integer
            Get
                Return SubProcessRunStepIndex
            End Get
        End Property
        Public SubProcessRunStepIndex As Integer  '»sµ{ STEP ¼Æ

        Public SubProcessStepIndex As Integer  '»sµ{ STEP ¼Æ
        Private SubRecipeStepIndex As Integer   '°t¤èSTEP¼Æ
        Private SubProcessVacuumOK As Boolean   '»sµ{¯uªÅOK
        Private SubProcessPressureOK As Boolean '»sµ{À£¤OOK
        Private SubProcessTopTempOK As Boolean  '»sµ{¤¤¤W·Å«×OK
        Private SubProcessBotTempOK As Boolean  '»sµ{¤¤¤U·Å«×OK
        Private SubProcessTempOK As Boolean     '»sµ{¤¤·Å«×OK
        Private SubProcessFirstConatctOK As Boolean '»sµ{¤¤­º¦¸±µ¦XOK
        Private SubBondBeforeVacuumOK As Boolean    '»sµ{¤¤¥ýÀ£¦A©â¯uªÅOK
        Private SubProcessToStepGo As Boolean       'À£ÀY¤vÀ£,¶}©l»sµ{(¥[·Å¥[À£)
        Private SubProcessCurveIndex As Integer     '¦±½u°O¿ý¥Î index

        Private ExternalTimerFlag As Boolean

        Private Timer1 As New Timer
        Private NowTimeCount As Integer
        Private OldTimeCount As Integer
        Private TimeCount As Integer
        Private Control_State As Integer
        Private Old_State As Integer
        Private Last_State As Integer
        Private AbortStr, DelayTimer, State, ProcessStr As String

        Sub New()
            TotoalStringListNum = ReadStatusString("SUB_PROCESS", SubProcessListString, ProcessINIFile)    'Åª¨ú»sµ{¦r¦ê 3 »y
        End Sub
        ''' <summary>
        ''' »sµ{µ²§ô(¤¤Â_©Î¥¿±`µ²§ô)
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        ReadOnly Property ProcessOK() As Boolean
            Get
                Return RunOKFlag Or AbortFlag
            End Get
        End Property

        ''' <summary>
        ''' Åª¨úRUNª¬ºA
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Sub Clear()
            RunOKFlag = False
            AbortFlag = False
            RunFlag = False
            Control_State = 0
        End Sub

        ''' <summary>
        ''' Åª¨úRUNª¬ºA
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        ReadOnly Property Run() As Boolean
            Get
                Return RunFlag
            End Get
        End Property

        ''' <summary>
        ''' Åª¨ú¤¤Â_ª¬ºA
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        ReadOnly Property AbortStatus() As Boolean
            Get
                Return AbortFlag
            End Get
        End Property
        ''' <summary>
        ''' ³]©w©Î¨ú±o¯uªÅOKª¬ºA
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Property VacuumOk() As Boolean
            Get
                Return SubProcessVacuumOK
            End Get

            Set(ByVal value As Boolean)
                SubProcessVacuumOK = value
            End Set
        End Property
        '-------------------------------------------------------------------------------------------------------- Title
        '¨ç¼Æ¦WºÙ       :   ProcessTimer  
        '¨ç¼Æ¥\¯à       :   ­Ë¼Æ­p®É¤§­p®É¾¹
        '¨ç¼Æ¶Ç¤J°Ñ¼Æ   :   (¶Ç§}¤§­p®É¾¹­P¯àºX¼Ð= Boolean, ¶Ç§}¤§­p®É¾¹ÅÜ¼Æ As Integer)
        '¶Ç¦^­È         : µL
        '§@ªÌ           : Libra
        '«Ø¥ß¤é´Á       : 2009/04/07
        '­×§ï¤é´Á       :
        '-------------------------------------------------------------------------------------------------------- Start
        Private Sub ProcessTimer(ByRef bEnable As Boolean, ByRef tCount As Integer)
            If bEnable Then
                tCount = tCount - 1
                If tCount <= 0 Then
                    tCount = 0
                    bEnable = False
                End If
            End If
        End Sub
        Private Sub ProcessTimer(ByRef bEnable As Boolean, ByRef tCount As Long)
            If bEnable Then
                tCount = tCount - 1
                If tCount <= 0 Then
                    tCount = 0
                    bEnable = False
                End If
            End If
        End Sub
        Private Sub ProcessTimerPlus(ByRef bEnable As Boolean, ByRef tCount As Integer)
            If bEnable Then
                tCount = tCount + 1
            End If
        End Sub
        Private Sub ProcessTimerPlus(ByRef bEnable As Boolean, ByRef tCount As Long)
            If bEnable Then
                tCount = tCount + 1
            End If
        End Sub

        Private Sub Timer1_Tick()
            If ExternalTimerFlag = False Then
                NowTimeCount = DatePart(DateInterval.Second, Now())
                If NowTimeCount <> OldTimeCount Then
                    SubAutoProcess_Task()
                    ProcessData(SiteNum).lblProcessStatus.Text = SubProcessStatusString 'SubAutoProcess_Task().ToString
                    PlateProcess(SiteNum).lblProcessStatus.Text = SubProcessStatusString 'SubAutoProcess_Task().ToString

                    ProcessTimerPlus(RunFlag, SubTotalProcessTime)
                    ProcessTimer(SubProcessTimerEnabled, SubProcessTimer)
                    OldTimeCount = NowTimeCount
                    TimeCount = TimeCount + 1
                End If
            End If
        End Sub

        Public Sub ExternlTimeCount()
            ExternalTimerFlag = True
            SubAutoProcess_Task()
            ProcessData(SiteNum).lblProcessStatus.Text = SubProcessStatusString 'SubAutoProcess_Task().ToString
            PlateProcess(SiteNum).lblProcessStatus.Text = SubProcessStatusString 'SubAutoProcess_Task().ToString

            ProcessTimerPlus(RunFlag, SubTotalProcessTime)
            ProcessTimer(SubProcessTimerEnabled, SubProcessTimer)
            OldTimeCount = NowTimeCount
            TimeCount = TimeCount + 1
        End Sub


        Public Sub Initial(ByVal iSiteNum As Integer)
            SiteNum = iSiteNum
            AbortFlag = False
            AddHandler Timer1.Tick, AddressOf Timer1_Tick
            Timer1.Interval = 800
            Timer1.Enabled = True
        End Sub

        Public Sub Start()
            'If subRecipeLoad Then
            RunFlag = True
            AbortFlag = False
            'End If
        End Sub

        Public Sub Skip()
            If RunFlag Then
                If SubProcessStepIndex < subPlateRecipe.TotalStep Then
                    SubProcessStepIndex += 1
                    Control_State = 2
                    SubProcessTimer = 0
                End If
            End If
        End Sub

        Public Sub Abort()
            RunFlag = False
            AbortFlag = True
        End Sub
        Private Function SubAutoProcess_Task() As Integer
            State = Format(Control_State, "[000]") + "[" + (SubProcessStepIndex + 1).ToString + "/" + subPlateRecipe.TotalStep.ToString + "]"
            ProcessStr = GetLangText("»sµ{¤¤:", "Process:")
            AbortStr = GetLangText("¤¤Â_:", "Abort:")
            If SubProcessTimer = 0 Then
                DelayTimer = ""
            Else
                DelayTimer = Format(SubProcessTimer, "(0)")
            End If

            On Error Resume Next
            Select Case Control_State
                Case 0  '»sµ{ªì©l¤Æ
                    If RunFlag Then
                        RunOKFlag = False
                        CurveFlag = 0
                        CurveFreeze = 0
                        SubProcessTimerEnabled = False
                        SubProcessTimer = 0
                        '«O«ù®É¶¡­p®É
                        SubProcessHoldTimerEnabled = False
                        SubProcessHoldTimer = 0
                        SubProcessHoldTimerSet = 0

                        SubProcessStartTime = TTime
                        SubProcessEndTime = "00:00:00"
                        SubProcessAbortTime = "00:00:00"

                        'SubProcessStatusString = ""

                        SubTotalProcessTime = 0

                        SubProcessStepIndex = 0
                        SubRecipeStepIndex = 0
                        SubProcessVacuumOK = False

                        SubProcessPressureOK = False
                        SubProcessTopTempOK = False
                        SubProcessBotTempOK = False
                        SubProcessTempOK = False
                        SubProcessFirstConatctOK = False
                        SubBondBeforeVacuumOK = False
                        SubProcessToStepGo = False
                        SubProcessCurveIndex = 0
                        AbortFlag = False

                        TempTimeout_Error = False
                        ForceTimeout_Error = False
                        SubProcessRunStepIndex = 0
                        Last_State = Control_State
                        Control_State = 1
                    End If
                Case 1 'ÀË¬d¯uªÅ«×/­º¦¸¶K¦X
                    If RunFlag Then
                        TopTempSV(SiteNum) = TempCal(SiteNum).GetTICTopTemp(Val(subPlateRecipe.Temperature(SubProcessStepIndex))) 'By Chesly 20180702
                        BotTempSV(SiteNum) = TempCal(SiteNum).GetTICBotTemp(Val(subPlateRecipe.Temperature(SubProcessStepIndex))) 'By Chesly 20180702

                        TempTopSV = TempCal(SiteNum).GetTICTopTemp(Val(subPlateRecipe.Temperature(SubProcessStepIndex))) 'By Chesly 20180702
                        TempBotSV = TempCal(SiteNum).GetTICBotTemp(Val(subPlateRecipe.Temperature(SubProcessStepIndex))) ' 'By Chesly 20180702

                        TopTempRateSV(SiteNum) = Val(subPlateRecipe.Temperature_Rate(SubProcessStepIndex)) * 100 'By Chesly 20180702
                        BotTempRateSV(SiteNum) = TopTempRateSV(SiteNum) 'By Chesly 20180702

                        ManualControl(SiteNum).WriteTempData(TopTempSV(SiteNum), BotTempSV(SiteNum), TopTempRateSV(SiteNum)) 'By Chesly 20180702


                        If ManualControl(SiteNum).FirstContact Or Val(subPlateRecipe.Pressure(SubProcessStepIndex)) = 0 Then
                            SubProcessStatusString = ProcessStr + State + SubProcessListString(SystemLanguage, Control_State) + DelayTimer ' GetLangText("ÀË¬d­º¦¸¶K¦X.", "‰ä¬d­º¦¸…`¦X", "Check Vacuum.")  'ProcessStatusList(SystemLanguage, Control_State)
                            SubProcessRunStepIndex = 1
                            If ManualControl(SiteNum).FirstContact = False Then
                                If Val(subPlateRecipe.Pressure(SubProcessStepIndex)) > 0 And
                                   Val(subPlateRecipe.Time(SubProcessStepIndex)) > 0 Then
                                    If ManualControl(SiteNum).FirstContact = False Then
                                        ManualControl(SiteNum).SetPlateUp()
                                    End If
                                End If
                            End If
                            'SubProcessStatusString = ProcessStr + State + GetLangText("ÀË¬d­º¦¸¶K¦X.", "‰ä¬d­º¦¸…`¦X", "Check Vacuum.") + "OK" 'ProcessStatusList(SystemLanguage, Control_State) + "--> OK"
                            'AppendMultiData(ProcessEeventFileName, 80, ADate & "  " & TTime & "-->", ProcessStatusString)
                            SubProcessTimerEnabled = True
                            SubProcessTimer = 1
                            '===============================================================
                            Last_State = Control_State
                            Control_State = 2
                        End If
                    Else
                        SubProcessStatusString = AbortStr + State + SubProcessListString(SystemLanguage, Control_State) + DelayTimer
                        'AppendMultiData(ProcessEeventFileName, 80, ADate & "  " & TTime & "-->", ProcessStatusString)
                        Last_State = Control_State
                        Control_State = 99
                    End If
                Case 2  '¼g¤J¾Þ§@°Ñ¼Æ and Turn ON
                    If RunFlag Then
                        SubProcessStatusString = ProcessStr + State + SubProcessListString(SystemLanguage, Control_State) + DelayTimer ' GetLangText("ÀË¬d­º¦¸¶K¦X.", "‰ä¬d­º¦¸…`¦X", "Check Vacuum.")  'ProcessStatusList(SystemLanguage, Control_State)

                        'SubProcessStatusString = ProcessStr + State + GetLangText("¼g¤JStep°Ñ¼Æ.", "‡À¤JStepƒò‡Û.", "Write Step Settings.")  ' ProcessStatusList(SystemLanguage, Control_State)
                        ' Write Bonding Pressure /rate
                        PressSV(SiteNum) = Val(subPlateRecipe.Pressure(SubProcessStepIndex))
                        PressRateSV(SiteNum) = Val(subPlateRecipe.Pressure_Rate(SubProcessStepIndex))
                        ManualControl(SiteNum).WritePressData(Val(subPlateRecipe.Pressure(SubProcessStepIndex)), Val(subPlateRecipe.Pressure_Rate(SubProcessStepIndex)))
                        ' Write Temp /rate
                        '===================================================================================
                        TopTempSV(SiteNum) = TempCal(SiteNum).GetTICTopTemp(Val(subPlateRecipe.Temperature(SubProcessStepIndex)))
                        BotTempSV(SiteNum) = TempCal(SiteNum).GetTICBotTemp(Val(subPlateRecipe.Temperature(SubProcessStepIndex))) 'TopTempSV(SiteNum) 'Modified by Vincent 20180419 

                        TempTopSV = TempCal(SiteNum).GetTICTopTemp(Val(subPlateRecipe.Temperature(SubProcessStepIndex)))
                        TempBotSV = TempCal(SiteNum).GetTICBotTemp(Val(subPlateRecipe.Temperature(SubProcessStepIndex))) 'TempTopSV 'Modified by Vincent 20180419 


                        TopTempRateSV(SiteNum) = Val(subPlateRecipe.Temperature_Rate(SubProcessStepIndex)) * 100
                        BotTempRateSV(SiteNum) = TopTempRateSV(SiteNum)

                        ManualControl(SiteNum).WriteTempData(TopTempSV(SiteNum), BotTempSV(SiteNum), TopTempRateSV(SiteNum))
                        'PIDs(SiteNum).AutoPIDTop(TempTopSV, TempBotSV) 'by Chesly 20170911



                        'ProcessData(SiteNum).PressuseSet = subPlateRecipe.Pressure(SubProcessStepIndex)
                        'ProcessData(SiteNum).PressuseRate = subPlateRecipe.Pressure_Rate(SubProcessStepIndex)
                        'ProcessData(SiteNum).TempSet = subPlateRecipe.Temperature(SubProcessStepIndex)
                        'ProcessData(SiteNum).TempRateSet = subPlateRecipe.Temperature_Rate(SubProcessStepIndex)
                        'ProcessData(SiteNum).HoldTimeSet = subPlateRecipe.Time(SubProcessStepIndex)
                        'ProcessData(SiteNum).StepSet = subPlateRecipe.TotalStep
                        'ProcessData(SiteNum).StepNote = subPlateRecipe.STEPNote(SubProcessStepIndex)
                        'ProcessData(SiteNum).StepTimeMin = subPlateRecipe.StepTime(SubProcessStepIndex)

                        'PlateProcess(SiteNum).lblPressureSet.Text = subPlateRecipe.Pressure(SubProcessStepIndex)
                        'PlateProcess(SiteNum).lblTopTempSet.Text = subPlateRecipe.Temperature(SubProcessStepIndex)
                        'PlateProcess(SiteNum).lblBotTempSet.Text = subPlateRecipe.Temperature(SubProcessStepIndex)

                        ProcessData(SiteNum).SetRecipeIndex(SubProcessStepIndex)
                        PlateProcess(SiteNum).lblPressureSet.Text = subPlateRecipe.Pressure(SubProcessStepIndex)
                        PlateProcess(SiteNum).lblTopTempSet.Text = subPlateRecipe.Temperature(SubProcessStepIndex)
                        PlateProcess(SiteNum).lblBotTempSet.Text = subPlateRecipe.Temperature(SubProcessStepIndex)

                        ''³]©w¥[·Å
                        If (Val(subPlateRecipe.Temperature(SubProcessStepIndex)) > RecipeTempLowLimit) And Val(RecipeNum(RecipeRunIndex).PumpingMode) > 0 Then
                            ManualControl(SiteNum).SetHeater(True)
                            SubProcessTopTempOK = False
                            SubProcessBotTempOK = False
                            SubProcessTempOK = False
                        Else
                            ManualControl(SiteNum).SetHeater(False)
                            SubProcessTopTempOK = True
                            SubProcessBotTempOK = True
                            SubProcessTempOK = True
                        End If
                        '³]©w¥[À£
                        If Val(subPlateRecipe.Pressure(SubProcessStepIndex)) > 0 And Val(subPlateRecipe.Time(SubProcessStepIndex)) > 0 Then
                            'If ManualControl(SiteNum).FirstContact = False Then
                            '    ManualControl(SiteNum).SetPlateUp()
                            'End If
                            If ManualControl(SiteNum).FirstContact Then
                                ManualControl(SiteNum).SetBondForce(True)
                                SubProcessPressureOK = False
                                SelectedFlag = True
                                SubProcessTimerEnabled = True
                                SubProcessTimer = 1
                                TempTimeOutWDog_Restart()
                                ForceTimeOutWDog_Restart()
                                '-========================================================
                                Last_State = Control_State
                                Control_State = 3
                            End If
                        Else
                            If Val(subPlateRecipe.Pressure(SubProcessStepIndex)) = 0 And Val(subPlateRecipe.Time(SubProcessStepIndex)) > 0 Then
                                SubProcessPressureOK = True
                                SelectedFlag = True
                                SubProcessTimerEnabled = True
                                SubProcessTimer = 1
                                '-========================================================
                                Last_State = Control_State
                                TempTimeOutWDog_Restart()
                                ForceTimeOutWDog_Restart()
                                Control_State = 3
                            Else
                                SelectedFlag = False
                                SubProcessTimerEnabled = True
                                SubProcessTimer = 5
                                SubProcessStatusString = ProcessStr + State + "No Used."
                                '-========================================================
                                Last_State = Control_State
                                Control_State = 5
                            End If

                        End If

                    Else
                        SubProcessStatusString = AbortStr + State + SubProcessListString(SystemLanguage, Control_State) + " " + TTime
                        'AppendMultiData(ProcessEeventFileName, 80, ADate & "  " & TTime & "-->", ProcessStatusString)

                        Last_State = Control_State
                        Control_State = 99
                    End If
                Case 3  'ÀË¬d·Å«×¤ÎÀ£¤O/³]©w«O«ù®É¶¡
                    If RunFlag Then


                        SubProcessStatusString = ProcessStr + State + SubProcessListString(SystemLanguage, Control_State) + DelayTimer ' GetLangText("ÀË¬d­º¦¸¶K¦X.", "‰ä¬d­º¦¸…`¦X", "Check Vacuum.")  'ProcessStatusList(SystemLanguage, Control_State)

                        SubProcessStatusString = ProcessStr + State + GetLangText("µ¥«Ý·Å«×¤ÎÀ£¤O.", "Wait Temp. & Forcing.")  'ProcessStatusList(SystemLanguage, Control_State)
                        If SubProcessTimerEnabled = False Then
                            'AppendMultiData(ProcessEeventFileName, 80, ADate & "  " & TTime & "-->", ProcessStatusString)
                            SubProcessPressureOK = PV_InRange(Val(subPlateRecipe.Pressure(SubProcessStepIndex)), PressPV(SiteNum), Val(SystemParameters.PressureRange))
                            SubProcessTopTempOK = PV_InRange(Val(subPlateRecipe.Temperature(SubProcessStepIndex)), TopTempPV(SiteNum), Val(SystemParameters.ProcessTempRange))
                            SubProcessBotTempOK = PV_InRange(Val(subPlateRecipe.Temperature(SubProcessStepIndex)), BotTempPV(SiteNum), Val(SystemParameters.ProcessTempRange))
                            SubProcessTempOK = SubProcessTopTempOK And SubProcessBotTempOK
                            If (Val(subPlateRecipe.Temperature(SubProcessStepIndex)) < RecipeTempLowLimit) Then
                                SubProcessTempOK = True
                            End If
                            If Val(RecipeNum(RecipeRunIndex).BondingSync) = 1 Then
                                SubProcessTempOK = True
                            End If
                            If Val(RecipeNum(RecipeRunIndex).BondingSync) = 2 Then
                                SubProcessTempOK = True
                            End If
                            If Val(RecipeNum(RecipeRunIndex).PumpingMode) = 0 Then
                                SubProcessTempOK = True
                            End If
                            'Debug.Print("¼ö·U®É®É¶¡,²Ä" + SiteNum.ToString + "ÀY=" + RecipeNum(RecipeRunIndex).Plate(SiteNum).AddTempTime(SubProcessStepIndex).ToString)
                            If SubProcessTempOK = False And RecipeNum(RecipeRunIndex).Plate(SiteNum).AddTempTime(SubProcessStepIndex) > 0 And
                                (TempTimeOutWDog.ElapsedMilliseconds / 1000 > RecipeNum(RecipeRunIndex).Plate(SiteNum).AddTempTime(SubProcessStepIndex) * SystemParameters.AddTempTimeoutX_Alarm) Then
                                TempTimeout_Error = True

                            ElseIf SubProcessTempOK = False And RecipeNum(RecipeRunIndex).Plate(SiteNum).CoolTempTime(SubProcessStepIndex) > 0 And
                                    (TempTimeOutWDog.ElapsedMilliseconds / 1000 > RecipeNum(RecipeRunIndex).Plate(SiteNum).CoolTempTime(SubProcessStepIndex) * SystemParameters.CoolTempTimeoutX_Alarm) Then
                                TempTimeout_Error = True
                            Else
                                TempTimeout_Error = False
                            End If
                            If SubProcessPressureOK = False And
                                (ForceTimeOutWDog.ElapsedMilliseconds / 1000 > RecipeNum(RecipeRunIndex).Plate(SiteNum).AddForceTime(SubProcessStepIndex) * SystemParameters.ForceTimeoutX_Alarm) Then
                                ForceTimeout_Error = True
                            Else
                                ForceTimeout_Error = False
                            End If
                            If SubProcessPressureOK And SubProcessTempOK Then
                                    SubProcessHoldTimerSet = subPlateRecipe.Time(SubProcessStepIndex)
                                    SubProcessTimerEnabled = True
                                    SubProcessTimer = subPlateRecipe.Time(SubProcessStepIndex)
                                    '=========================================================
                                    Last_State = Control_State
                                    Control_State = 4
                                End If
                            End If
                        Else
                        SubProcessStatusString = AbortStr + State + SubProcessListString(SystemLanguage, Control_State) + DelayTimer + " " + TTime
                        'AppendMultiData(ProcessEeventFileName, 80, ADate & "  " & TTime & "-->", ProcessStatusString)

                        Last_State = Control_State
                        Control_State = 99
                    End If

                Case 4  '«O«ù®É¶¡­p®É
                    If RunFlag Then
                        SubProcessStatusString = ProcessStr + State + GetLangText("«O«ù®É¶¡­p®É:", "Hold Time:") + DelayTimer  'ProcessStatusList(SystemLanguage, Control_State)
                        If SubProcessTimerEnabled = False Then
                            ProcessStatusString = ProcessStr + State + ProcessStatusList(SystemLanguage, Control_State) + "--> OK"
                            'AppendMultiData(ProcessEeventFileName, 80, ADate & "  " & TTime & "-->", ProcessStatusString)
                            SubProcessStepIndex += 1
                            SubProcessRunStepIndex += 1
                            If SubProcessStepIndex >= subPlateRecipe.TotalStep Then
                                SubProcessRunStepIndex = 0
                                '=========================================================
                                Last_State = Control_State
                                Control_State = 5
                            Else
                                If Val(subPlateRecipe.Pressure(SubProcessStepIndex)) > 0 And Val(subPlateRecipe.Time(SubProcessStepIndex)) > 0 Then
                                    If ManualControl(SiteNum).FirstContact = False Then
                                        ManualControl(SiteNum).SetPlateUp()
                                    End If
                                End If

                                Last_State = Control_State
                                Control_State = 2
                            End If
                        End If
                    Else
                        SubProcessStatusString = AbortStr + State + SubProcessListString(SystemLanguage, Control_State) + DelayTimer + " " + TTime
                        'AppendMultiData(ProcessEeventFileName, 80, ADate & "  " & TTime & "-->", ProcessStatusString)

                        Last_State = Control_State
                        Control_State = 99
                    End If

                Case 5 'Finished
                    If RunFlag Then
                        SubProcessStepIndex = subPlateRecipe.TotalStep - 1
                        SubProcessStatusString = ProcessStr + State + GetLangText("»sµ{§¹¦¨!", "Process Finished!") + DelayTimer + " " + TTime 'ProcessStatusList(SystemLanguage, Control_State) 
                        'AppendMultiData(ProcessEeventFileName, 80, ADate & "  " & TTime & "-->", ProcessStatusString)
                        SubProcessEndTime = TTime
                        SubProcessRunStepIndex = 0
                        ManualControl(SiteNum).SetHeater(False)
                        'If Val(RecipeNum(RecipeRunIndex).KeepBonding) = 0 Then
                        '    ManualControl(SiteNum).SetPlateDown(True)
                        'End If
                        SubProcessStepIndex = 0
                        SubTotalProcessTime = 0
                        ProcessCurve(SiteNum).Freeze = True

                        SubProcessTimerEnabled = False
                        SubProcessTimer = 0
                        '«O«ù®É¶¡­p®É
                        SubProcessHoldTimerEnabled = False
                        SubProcessHoldTimer = 0
                        SubProcessHoldTimerSet = 0

                        SubProcessEndTime = TTime
                        SubProcessAbortTime = ""

                        AbortFlag = False
                        RunFlag = False
                        RunOKFlag = True
                        '===============================================================
                        Last_State = Control_State
                        Control_State = 0
                        TempTimeOutWDog.Stop()
                        ForceTimeOutWDog.Stop()
                    End If

                Case 99
                    ManualControl(SiteNum).SetHeater(False)
                    CurveFlag = 0
                    CurveFreeze = 0
                    SubProcessTimerEnabled = False
                    SubProcessTimer = 0
                    '«O«ù®É¶¡­p®É
                    SubProcessHoldTimerEnabled = False
                    SubProcessHoldTimer = 0
                    SubProcessHoldTimerSet = 0
                    ProcessCurve(SiteNum).Freeze = True
                    SubProcessStartTime = TTime
                    SubProcessEndTime = TTime
                    SubProcessAbortTime = "00:00:00"
                    AbortFlag = True
                    RunFlag = False
                    RunOKFlag = False
                    'SubProcessStatusString = ""

                    SubTotalProcessTime = 0

                    SubProcessStepIndex = 0
                    SubRecipeStepIndex = 0
                    SubProcessVacuumOK = False

                    SubProcessPressureOK = False
                    SubProcessTopTempOK = False
                    SubProcessBotTempOK = False
                    SubProcessTempOK = False
                    SubProcessFirstConatctOK = False
                    SubBondBeforeVacuumOK = False
                    SubProcessToStepGo = False
                    SubProcessCurveIndex = 0
                    SubProcessAbortTime = TTime
                    Control_State = 0
            End Select
            If Old_State <> Control_State Then
                AppendMultiData(ProcessEeventFileName, 256, ADate & "  " & TTime & "-->", SubProcessStatusString)
                Old_State = Control_State
            End If
            Return Control_State
        End Function


    End Class

    '¦Û°Ê»sµ{µ{§Ç
    Public CurveFlag As Boolean    'À£¦X®É­«¸m¦±½u
    Public CurveFreeze As Boolean  '§¹¦¨»sµ{®É, ©w¦í¦±½u

    '»sµ{¤¤©µ¿ð®É¶¡­p®É
    Public AutoProcessTimerEnabled As Boolean
    Public AutoProcessTimer As Integer
    '«O«ù®É¶¡­p®É
    Public ProcessHoldTimerEnabled As Boolean
    Public ProcessHoldTimer As Integer

    Public ProcessHoldTimerSet As Integer   '«O«ù®É¶¡³]©w

    Public ProcessStartTime As String       '»sµ{¶}©l®É¶¡
    Public ProcessEndTime As String         '»sµ{µ²§ô®É¶¡
    Public ProcessAbortTime As String       '»sµ{¤¤Â_®É¶¡

    Public ProcessStatusString As String    '»sµ{ª¬ºA¦r¦ê


    Public TotalProcessTime As Integer  '»sµ{Á`®É¶¡(sec)

    Public ProcessStepIndex As Integer  '»sµ{ STEP ¼Æ
    '
    Public RecipeStepIndex As Integer   '°t¤èSTEP¼Æ

    Public AllProcessEnd As Boolean   '»sµ{¯uªÅOK
    Public ProcessOkCount As Integer    '»sµ{¯uªÅOK
    Public ProcessAbortCount As Integer    '»sµ{¯uªÅOK

    Public ProcessVacuumOK As Boolean   '»sµ{¯uªÅOK
    Public ProcessPressureOK As Boolean '»sµ{À£¤OOK
    Public ProcessTopTempOK As Boolean  '»sµ{¤¤¤W·Å«×OK
    Public ProcessBotTempOK As Boolean  '»sµ{¤¤¤U·Å«×OK
    Public ProcessTempOK As Boolean     '»sµ{¤¤·Å«×OK
    Public ProcessFirstConatctOK As Boolean '»sµ{¤¤­º¦¸±µ¦XOK
    Public BondBeforeVacuumOK As Boolean    '»sµ{¤¤¥ýÀ£¦A©â¯uªÅOK
    Public PlateOK(MAXPLATE) As Boolean
    Public PlateCount As Integer

    Public ProcessToStepGo As Boolean       'À£ÀY¤vÀ£,¶}©l»sµ{(¥[·Å¥[À£)

    Public ProcessCurveIndex As Integer     '¦±½u°O¿ý¥Î index
    Public ProcessCSVIndex As Integer     '¦±½u°O¿ý¥Î index


    Public Function AutoProcess_Task() As Integer
        Dim i, j As Integer
        Dim Process_Lock As Boolean
        Static Control_State As Integer
        Static Old_State As Integer
        Static Last_State As Integer
        Static AbortCount As Integer
        Dim count(MAXPLATE) As Integer
        Static DoorDelay As Integer = 0 'Add By Vincent 20190416 
        Static PumpingDelay As Integer = 0 'Add By Vincent 20190416 

        Dim AbortStr, DelayTimer, State, ProcessStr As String
        State = Format(Control_State, "[000]:") '+ "[" + (ProcessStepIndex + 1).ToString + "/" + RecipeStepIndex.ToString + "]"
        ProcessStr = GetLangText("»sµ{¤¤:", "Process:")
        AbortStr = GetLangText("¤¤Â_:", "Abort:")
        If AutoProcessTimer = 0 Then
            DelayTimer = ""
        Else
            DelayTimer = Format(AutoProcessTimer, "(0)")
        End If
        'Dim AbortError As Integer = 0
        'If SystemParameters.AbortTempRangeFlag = "1" Then
        '    For i = 0 To MAXPLATE

        '        If AlarmError(Alarm_Name.TOP_OVTEMP_Error1 + i * 2) Or AlarmError(Alarm_Name.BOT_OVTEMP_Error1 + i * 2) Then
        '            AbortError += 1
        '        End If
        '        'If AlarmError(Alarm_Name.OVER_PRESS_Error1 + i) Then
        '        '    AbortError += 1
        '        'End If
        '    Next
        '    If AbortError > 0 Then
        '        AbortCount += 1
        '        If AbortCount > 50 Then
        '            If ProcessMode_RUN Then
        '                ProcessMode_RUN = False
        '            End If
        '            AbortCount = 0
        '        End If
        '    Else
        '        AbortCount = 0
        '    End If
        'Else
        '    AbortError = 0
        'End If
        On Error Resume Next
        If SystemParameters.AbortPressureRangeFlag = "1" Then
            If AlarmError(Alarm_Name.OVER_PRESS_Error1) Then
                Output(DoBondUp01Index).Status = False
                CSubAutoProcess(0).Abort()
                ProcessMode_RUN = False
            End If
            If AlarmError(Alarm_Name.OVER_PRESS_Error2) Then
                Output(DoBondUp02Index).Status = False
                CSubAutoProcess(1).Abort()
                ProcessMode_RUN = False
            End If
            If AlarmError(Alarm_Name.OVER_PRESS_Error3) Then
                Output(DoBondUp03Index).Status = False
                CSubAutoProcess(2).Abort()
                ProcessMode_RUN = False
            End If
        End If
        If SystemParameters.AbortTempRangeFlag = "1" Then
            If AlarmError(Alarm_Name.TOP_OVTEMP_Error1) Or AlarmError(Alarm_Name.BOT_OVTEMP_Error1) Then
                ManualControl(0).SetHeater(False)
                Output(DoBondUp01Index).Status = False
                CSubAutoProcess(0).Abort()
                ProcessMode_RUN = False
            End If
            If AlarmError(Alarm_Name.TOP_OVTEMP_Error2) Or AlarmError(Alarm_Name.BOT_OVTEMP_Error2) Then
                ManualControl(1).SetHeater(False)
                Output(DoBondUp02Index).Status = False
                CSubAutoProcess(1).Abort()
                ProcessMode_RUN = False
            End If
            If AlarmError(Alarm_Name.TOP_OVTEMP_Error3) Or AlarmError(Alarm_Name.BOT_OVTEMP_Error3) Then
                ManualControl(2).SetHeater(False)
                Output(DoBondUp03Index).Status = False
                CSubAutoProcess(2).Abort()
                ProcessMode_RUN = False
            End If
        End If
        For i = 0 To MAXPLATE
            If AlarmError(Alarm_Name.TOP_FLOW_Error1 + i * 2) Or AlarmError(Alarm_Name.BOT_FLOW_Error1 + i * 2) Then
                CSubAutoProcess(2).Abort()
                ProcessMode_RUN = False
            End If
        Next
        Select Case Control_State
            Case 0  '»sµ{ªì©l¤Æ
                If ProcessMode_RUN Then
                    ProcessStartTime = NHour + ":" + NMin + ":" + NSec

                    ProcessStatusString = ProcessStr + State + ProcessStatusList(SystemLanguage, Control_State)
                    AppendMultiData(ProcessEeventFileName, 40, ADate & "  " & TTime & "-->", ProcessStatusString)
                    If Purge_Flag Then
                        Output(DoTopPurge1Index).Status = False
                        Output(DoTopPurge2Index).Status = False
                        Output(DoTopPurge3Index).Status = False

                        Output(DoBotPurge1Index).Status = False
                        Output(DoBotPurge2Index).Status = False
                        Output(DoBotPurge3Index).Status = False

                    End If
                    '²M°£»sµ{¨B§Ç
                    ProcessStepIndex = 0
                    TotalProcessTime = 0

                    ProcessVacuumOK = False
                    ProcessPressureOK = False
                    ProcessTopTempOK = False
                    ProcessBotTempOK = False
                    ProcessTempOK = False
                    ProcessFirstConatctOK = False
                    BondBeforeVacuumOK = False
                    CurveFreeze = False
                    CurveFlag = False
                    ProcessToStepGo = False
                    For i = 0 To MAXPLATE
                        PlateOK(i) = False
                    Next
                    Control_State = 1
                End If

            Case 1  '¼g¤J¾Þ§@°Ñ¼Æ
                If ProcessMode_RUN Then
                    ProcessStatusString = ProcessStr + State + ProcessStatusList(SystemLanguage, Control_State) + DelayTimer
                    'AppendMultiData(ProcessEeventFileName, 80, ADate & "  " & TTime & "-->", ProcessStatusString)
                    '±Ò°ÊªoÀ£°¨¹F
                    For i = 0 To MAXPLATE
                        If OilPumpUsed Then
                            ManualControl(i).SetOilPump(True)
                        End If
                        PlateProcess(i).lblProcessStatus.Text = ""
                        CSubAutoProcess(i).SubProcessStatusString = ""
                    Next

                    '³]©w»sµ{¨BÆJ¸ê®Æ
                    RecipeStepIndex = Val(RecipeNum(RecipeRunIndex).StepSet)
                    ProcessStepIndex = 0

                    DoorDelay = 0  'Add By Vincent 20190416 
                    Door1CloseAlarm_Error = False    'Add By Vincent 20190416 

                    '¼g¤JVENT ®É¶¡
                    Write_PLC_R1100(DAVentTimeIndex, Val(SystemParameters.VentTime))
                    Write_PLC_R1100(DAProcessOKAlarmIndex, Val(SystemParameters.ProcessEndBZonTime))
                    Output(DoDoor1UpIndex).Status = True
                    Output(DoDoor1DownIndex).Status = False
                    Output(DoDoor2UpIndex).Status = True
                    Output(DoDoor2DownIndex).Status = False
                    AutoProcessTimerEnabled = True
                    AutoProcessTimer = 2
                    Last_State = Control_State
                    Control_State = 2
                Else
                    ProcessStatusString = AbortStr + State + ProcessStatusList(SystemLanguage, Control_State) + DelayTimer
                    AppendMultiData(ProcessEeventFileName, 80, ADate & "  " & TTime & "-->", ProcessStatusString)

                    Last_State = Control_State
                    Control_State = 99
                End If
            Case 2  '¼g¤J»sµ{¸ê®Æ
                If ProcessMode_RUN Then
                    ProcessStatusString = ProcessStr + State + ProcessStatusList(SystemLanguage, Control_State) + DelayTimer
                    If AutoProcessTimerEnabled = False Then
                        If Check_PLC_X(DiDoor1UpIndex) And Check_PLC_X(DiDoor2UpIndex) Then
                            ProcessStatusString = ProcessStr + State + ProcessStatusList(SystemLanguage, Control_State) + DelayTimer
                            'AppendMultiData(ProcessEeventFileName, 80, ADate & "  " & TTime & "-->", ProcessStatusString)
                            DoorDelay = 0  'Add By Vincent 20190416 
                            Door1CloseAlarm_Error = False    'Add By Vincent 20190416 

                            AutoProcessTimerEnabled = True
                            AutoProcessTimer = 2
                            If Val(RecipeNum(RecipeRunIndex).BondBeforeVacuum) > 0 And BondBeforeVacuumOK = False Then
                                Last_State = Control_State
                                BondBeforeVacuumOK = True
                                Control_State = 5
                            Else
                                Last_State = Control_State
                                Control_State = 3
                            End If
                        Else
                            If Check_PLC_X(DiSaftyGate01Index) = False Or Check_PLC_X(DiSaftyGate01Index) = False Then
                                ProcessMode_RUN = False
                                Control_State = 99
                                MsgBoxLangErr("¦w¥þªù°Ê§@,¤¤Â_»sµ{!!", "Safty Door Actived!")
                            End If
                        End If
                        'Add By Vincent 20190416 ------------------ Start
                        If Door1CloseAlarm_Error = False Then
                            If DoorDelay >= DOORTIME * 10 Then
                                ProcessStatusString = ProcessStr + State + ProcessStatusList(SystemLanguage, Control_State) + DelayTimer & "->" & GetLangText("µ¥«ÝµÄªùÃö³¬", "Wait Door close.")
                                Door1CloseAlarm_Error = True
                            Else
                                Door1CloseAlarm_Error = False
                                DoorDelay += 1
                            End If
                        Else
                            DoorDelay = 0
                        End If
                        'Add By Vincent 20190416 ------------------ End
                    End If
                Else
                    ProcessStatusString = AbortStr + State + ProcessStatusList(SystemLanguage, Control_State) + DelayTimer
                    AppendMultiData(ProcessEeventFileName, 80, ADate & "  " & TTime & "-->", ProcessStatusString)
                    Last_State = Control_State
                    Control_State = 99
                End If

            Case 3 '¶}©l©â¯uªÅ

                If ProcessMode_RUN Then
                    ProcessStatusString = ProcessStr + State + ProcessStatusList(SystemLanguage, Control_State) + DelayTimer
                    If AutoProcessTimerEnabled = False Then
                        ProcessStatusString = ProcessStr + State + ProcessStatusList(SystemLanguage, Control_State) + DelayTimer
                        'AppendMultiData(ProcessEeventFileName, 80, ADate & "  " & TTime & "-->", ProcessStatusString)

                        '³]©w°t¤è¯uªÅ¼Ò¦¡
                        If (Val(RecipeNum(RecipeRunIndex).PumpingMode) > 0) Then
                            CAutoPumping.AutoPurge = (Val(RecipeNum(RecipeRunIndex).VacuumPurge) > 0)
                            CAutoPumping.SetAutoPurge(CAutoPumping.AutoPurge, Val(SystemParameters.AutoPurgeOnTime), Val(SystemParameters.AutoPurgeOFFTime), Val(SystemParameters.AutoPurgeCycle))

                            CAutoPumping.AutoProtection = True '(Val(SystemParameters.ProcessAutoVacuum) > 0)
                            CAutoPumping.SetBasePressure(CAutoPumping.AutoProtection, Val(SystemParameters.ProcessVacuumAutoVac), Val(RecipeNum(RecipeRunIndex).BasePressure))
                            CAutoPumping.Start = True
                        Else
                            CAutoPumping.Start = False
                            Output(DoRVIndex).Status = False
                            'RVPb_Status = False
                        End If
                        PumpingAlarm_Error = False 'Add By Vincent 20190416 
                        PumpingDelay = 0 'Add By Vincent 20190416 

                        AutoProcessTimerEnabled = True
                        AutoProcessTimer = 2
                        Last_State = Control_State
                        Control_State = 4

                    End If
                Else
                    ProcessStatusString = AbortStr + State + ProcessStatusList(SystemLanguage, Control_State) + DelayTimer
                    AppendMultiData(ProcessEeventFileName, 80, ADate & "  " & TTime & "-->", ProcessStatusString)
                    Last_State = Control_State
                    Control_State = 99
                End If

            Case 4 'ÀË¬d¯uªÅ­È¬O§_¤w¨ì,
                If ProcessMode_RUN Then
                    ProcessStatusString = ProcessStr + State + ProcessStatusList(SystemLanguage, Control_State) + DelayTimer
                    If CAutoPumping.AutoPurge Then ProcessStatusString = ProcessStatusString + Format(CAutoPumping.PurgeCounter, "Purge:[00]")
                    If AutoProcessTimerEnabled = False Then
                        ProcessStatusString = ProcessStr + State + ProcessStatusList(SystemLanguage, Control_State) + DelayTimer
                        If GaugeCHVac <= Val(RecipeNum(RecipeRunIndex).BasePressure) Then
                            'AppendMultiData(ProcessEeventFileName, 80, ADate & "  " & TTime & "-->", ProcessStatusString)
                            PumpingAlarm_Error = False 'Add By Vincent 20190416 
                            ProcessVacuumOK = True
                            'For i = 0 To MAXPLATE
                            '    CSubAutoProcess(i).VacuumOk = ProcessVacuumOK
                            'Next
                        Else
                            ProcessVacuumOK = False
                            'For i = 0 To MAXPLATE
                            '    CSubAutoProcess(i).VacuumOk = ProcessVacuumOK
                            'Next
                        End If
                        If (Val(RecipeNum(RecipeRunIndex).PumpingMode) = 0) Then ProcessVacuumOK = True
                        If ProcessVacuumOK Then
                            If Val(RecipeNum(RecipeRunIndex).BondBeforeVacuum) > 0 And BondBeforeVacuumOK Then
                                AutoProcessTimerEnabled = True
                                AutoProcessTimer = 2
                                Last_State = Control_State
                                Control_State = 7
                            Else
                                AutoProcessTimerEnabled = True
                                AutoProcessTimer = 2
                                Last_State = Control_State
                                Control_State = 5
                            End If
                        End If
                        'Add By Vincent 20190416 ------------------ Start
                        If (Val(RecipeNum(RecipeRunIndex).PumpingMode) = 1) And ProcessVacuumOK = False Then
                            If PumpingAlarm_Error = False Then
                                If PumpingDelay >= PUMPINGTIME * 10 Then
                                    If GaugeCHVac > PUMPINGVACUUM Then
                                        PumpingAlarm_Error = True
                                    End If
                                Else
                                    PumpingDelay += 1
                                End If
                            Else
                                PumpingDelay = 0
                            End If
                        End If
                        'Add By Vincent 20190416 ------------------ End
                    End If
                Else
                    ProcessStatusString = AbortStr + State + ProcessStatusList(SystemLanguage, Control_State) + DelayTimer
                    AppendMultiData(ProcessEeventFileName, 80, ADate & "  " & TTime & "-->", ProcessStatusString)
                    Last_State = Control_State
                    Control_State = 99
                End If
            Case 5 'À£¬û¤W¤É
                If ProcessMode_RUN Then
                    ProcessStatusString = ProcessStr + State + ProcessStatusList(SystemLanguage, Control_State) + DelayTimer
                    If AutoProcessTimerEnabled = False Then
                        ProcessStatusString = ProcessStr + State + ProcessStatusList(SystemLanguage, Control_State)
                        'AppendMultiData(ProcessEeventFileName, 80, ADate & "  " & TTime & "-->", ProcessStatusString)
                        'À£¬û¤W¤É
                        For i = 0 To MAXPLATE
                            If Val(RecipeNum(RecipeRunIndex).Plate(i).Pressure(ProcessStepIndex)) > 0 Then
                                ManualControl(i).SetPlateUp(True)
                            End If
                        Next
                        AutoProcessTimerEnabled = True
                        AutoProcessTimer = 3
                        Last_State = Control_State
                        Control_State = 6
                    End If
                Else
                    ProcessStatusString = AbortStr + State + ProcessStatusList(SystemLanguage, Control_State) + DelayTimer
                    AppendMultiData(ProcessEeventFileName, 80, ADate & "  " & TTime & "-->", ProcessStatusString)
                    Last_State = Control_State
                    Control_State = 99
                End If
            Case 6 'À£¬û¤w¤W¤É(§¹¦¨­º¦¸¶K¦Xµ{§Ç)
                If ProcessMode_RUN Then
                    ProcessStatusString = ProcessStr + State + ProcessStatusList(SystemLanguage, Control_State) + DelayTimer
                    If AutoProcessTimerEnabled = False Then
                        For i = 0 To MAXPLATE
                            If Val(RecipeNum(RecipeRunIndex).Plate(i).Pressure(ProcessStepIndex)) > 0 Then
                                count(i) = 1
                            Else
                                count(i) = 0
                            End If
                        Next
                        PlateCount = 0
                        For i = 0 To MAXPLATE
                            If count(i) = 1 And ManualControl(i).FirstContact = False Then
                                PlateCount += 1
                            End If
                        Next
                        If PlateCount = 0 Then
                            ProcessStatusString = ProcessStr + State + ProcessStatusList(SystemLanguage, Control_State) + DelayTimer
                            'AppendMultiData(ProcessEeventFileName, 80, ADate & "  " & TTime & "-->", ProcessStatusString)
                            If Val(RecipeNum(RecipeRunIndex).BondBeforeVacuum) > 0 And BondBeforeVacuumOK = True Then
                                '¯uªÅ«e¹wÀ£
                                If PlateCount = 0 Then
                                    AutoProcessTimerEnabled = True
                                    AutoProcessTimer = 2
                                    Last_State = Control_State
                                    Control_State = 3
                                End If
                            Else
                                '¥ý©â¯uªÅ¦AÀ£
                                ProcessStepIndex = 0
                                AutoProcessTimerEnabled = True
                                AutoProcessTimer = 2
                                Last_State = Control_State
                                Control_State = 7
                            End If

                        End If
                    End If
                Else
                    ProcessStatusString = AbortStr + State + ProcessStatusList(SystemLanguage, Last_State) + DelayTimer
                    AppendMultiData(ProcessEeventFileName, 80, ADate & "  " & TTime & "-->", ProcessStatusString)
                    Last_State = Control_State
                    Control_State = 99
                End If


            Case 7 'À£¦X§¹¦¨,¶}©l»sµ{
                If ProcessMode_RUN Then
                    ProcessStatusString = ProcessStr + State + ProcessStatusList(SystemLanguage, Control_State) + DelayTimer
                    If AutoProcessTimerEnabled = False Then
                        'If Check_PLC_M(Do1stContactOK01Index) Then
                        ProcessStatusString = ProcessStr + State + ProcessStatusList(SystemLanguage, Control_State) + DelayTimer
                        'AppendMultiData(ProcessEeventFileName, 80, ADate & "  " & TTime & "-->", ProcessStatusString)
                        '³]©w MFC ¬y¶q
                        If MFC01_USED Then
                            MFC01_Control.Start(Val(RecipeNum(RecipeRunIndex).MFC01Flow),
                                                Val(RecipeNum(RecipeRunIndex).MFC01ONTime),
                                                Val(RecipeNum(RecipeRunIndex).MFC01OFFTime))
                            FormManuals.txtGas01MFCSet.Text = RecipeNum(RecipeRunIndex).MFC01Flow
                            FormProcess.txtGas01MFCSet.Text = RecipeNum(RecipeRunIndex).MFC01Flow
                        End If
                        If MFC02_USED Then
                            MFC02_Control.Start(Val(RecipeNum(RecipeRunIndex).MFC02Flow),
                                                Val(RecipeNum(RecipeRunIndex).MFC02ONTime),
                                                Val(RecipeNum(RecipeRunIndex).MFC02OFFTime))

                            FormManuals.txtGas02MFCSet.Text = RecipeNum(RecipeRunIndex).MFC02Flow
                            FormProcess.txtGas02MFCSet.Text = RecipeNum(RecipeRunIndex).MFC02Flow
                        End If
                        ProcessToStepGo = True
                        AutoProcessTimerEnabled = True
                        AutoProcessTimer = 2
                        Last_State = Control_State
                        Control_State = 8
                    End If
                Else
                    ProcessStatusString = AbortStr + State + ProcessStatusList(SystemLanguage, Control_State) + DelayTimer
                    AppendMultiData(ProcessEeventFileName, 80, ADate & "  " & TTime & "-->", ProcessStatusString)
                    Last_State = Control_State
                    Control_State = 99
                End If

            Case 8 '¥[·Å¥[À£
                If ProcessMode_RUN Then
                    ProcessStatusString = ProcessStr + State + ProcessStatusList(SystemLanguage, Last_State) + DelayTimer
                    If AutoProcessTimerEnabled = False Then
                        ProcessStatusString = ProcessStr + State + ProcessStatusList(SystemLanguage, Control_State) + DelayTimer
                        'For i = 0 To MAXPLATE
                        '    CSubAutoProcess(i).LoadPlateRecipe(RecipeNum(RecipeRunIndex).Plate(i))
                        'Next
                        If (Val(RecipeNum(RecipeRunIndex).PumpingMode) > 0) Then
                            If ProcessVacuumOK Then
                                For i = 0 To MAXPLATE
                                    If Val(RecipeNum(RecipeRunIndex).Plate(i).Time(ProcessStepIndex)) > 0 Then
                                        If Val(RecipeNum(RecipeRunIndex).Plate(i).Pressure(ProcessStepIndex)) > 0 _
                                                 Or Val(RecipeNum(RecipeRunIndex).Plate(i).Temperature(ProcessStepIndex)) > 30 _
                                                  Or Val(RecipeNum(RecipeRunIndex).Plate(i).Time(ProcessStepIndex)) > 0 Then
                                            CSubAutoProcess(i).VacuumOk = True
                                            CSubAutoProcess(i).Start()
                                            ManualControl(i).RunMode = True
                                        Else
                                            ManualControl(i).RunMode = False
                                        End If
                                    End If
                                Next
                                Last_State = Control_State
                                Control_State = 9
                            End If
                        Else
                            For i = 0 To MAXPLATE
                                If Val(RecipeNum(RecipeRunIndex).Plate(i).Time(ProcessStepIndex)) > 0 Then
                                    If Val(RecipeNum(RecipeRunIndex).Plate(i).Pressure(ProcessStepIndex)) > 0 Then
                                        ManualControl(i).SetBondForce(True)
                                        CSubAutoProcess(i).Start()
                                    End If
                                End If
                            Next
                            Last_State = Control_State
                            Control_State = 9
                        End If
                    End If
                Else
                    ProcessStatusString = AbortStr + State + ProcessStatusList(SystemLanguage, Control_State) + DelayTimer
                    AppendMultiData(ProcessEeventFileName, 80, ADate & "  " & TTime & "-->", ProcessStatusString)
                    Last_State = Control_State
                    Control_State = 99
                End If

            Case 9 'ÀË¬d·Å«×/À£¤O¤w¨ì
                If ProcessMode_RUN Then
                    ProcessStatusString = ProcessStr + State + ProcessStatusList(SystemLanguage, Last_State) + DelayTimer
                    If AutoProcessTimerEnabled = False Then
                        ProcessStatusString = ProcessStr + State + ProcessStatusList(SystemLanguage, Control_State) + DelayTimer
                        If CurveFlag = False Then
                            'AppendMultiData(ProcessEeventFileName, 80, ADate & "  " & TTime & "-->", ProcessStatusString)
                            For i = 0 To MAXPLATE
                                For j = 0 To 2
                                    ProcessCurve(i).Chart1.Series(j).Points.Clear()
                                Next
                                CSubAutoProcess(i).VacuumOk = True
                            Next
                            CurveFlag = True
                        End If
                        AllProcessEnd = False
                        ProcessOkCount = 0
                        ProcessAbortCount = 0
                        For i = 0 To MAXPLATE
                            If CSubAutoProcess(i).Run Then
                                ProcessOkCount += 1
                            End If
                        Next

                        '©Ò¦³¤l»sµ{µ²§ô
                        If ProcessOkCount = 0 Then
                            RunCounts += 1
                            If RunCounts > 100000 Then
                                RunCounts = 1
                            End If
                            WriteRunData()

                            For i = 0 To MAXPLATE
                                ManualControl(i).SetHeater(False)
                            Next
                            MFC01_Control.Stop()
                            MFC02_Control.Stop()
                            'PURGE ­°·Å
                            If Val(RecipeNum(RecipeRunIndex).PurgeCooling) > 0 And PURGECOOLING Then
                                'PURGE «ùÀ£
                                If Val(RecipeNum(RecipeRunIndex).PurgeKeepBonding) = 0 Then
                                    'À£¬û¤U­°
                                    For i = 0 To MAXPLATE
                                        ManualControl(i).SetPlateDown(True)
                                        ManualControl(i).SetPlateUp(False)
                                        ManualControl(i).SetBondForce(False)
                                    Next
                                End If
                                CAutoPumping.Start = True
                                Last_State = Control_State
                                Control_State = 18
                            Else
                                '¬O§_­nPURGE
                                If Val(RecipeNum(RecipeRunIndex).AfterPurge) > 0 Then
                                    CAutoPumping.Start = True
                                    CAutoPumping.SetAutoPurge(CAutoPumping.AutoPurge, Val(SystemParameters.AutoPurgeOnTime), Val(SystemParameters.AutoPurgeOFFTime), Val(SystemParameters.AutoPurgeCycle))
                                    CAutoPumping.AutoPurge = True
                                Else
                                    CAutoPumping.AutoPurge = False
                                End If
                                AutoProcessTimerEnabled = True
                                AutoProcessTimer = 2
                                Last_State = Control_State
                                Control_State = 10
                            End If
                        End If
                    End If
                Else
                    ProcessStatusString = AbortStr + State + ProcessStatusList(SystemLanguage, Control_State) + DelayTimer
                    AppendMultiData(ProcessEeventFileName, 80, ADate & "  " & TTime & "-->", ProcessStatusString)
                    Last_State = Control_State
                    Control_State = 99
                End If
            Case 18 ' Purge  Cooling 
                If ProcessMode_RUN Then
                    ProcessStatusString = ProcessStr + State + GetLangText("³q®ð­°·Å¤¤...", "Purge cooling...") + Format(CAutoPumping.Timer, "[0]/") + Format(CAutoPumping.PurgeCounter, "[0]") + DelayTimer
                    If AutoProcessTimerEnabled = False Then

                        Dim PurgeCoolingTempOK As Integer = 0
                        For i = 0 To MAXPLATE
                            If TopTempPV(i) > Val(RecipeNum(RecipeRunIndex).PurgeCoolingTemp) Then PurgeCoolingTempOK += 1
                            If BotTempPV(i) > Val(RecipeNum(RecipeRunIndex).PurgeCoolingTemp) Then PurgeCoolingTempOK += 1
                        Next
                        If PurgeCoolingTempOK = 0 Then
                            If CAutoPumping.AutoPurge = False Then
                                CAutoPumping.SetAutoPurge(CAutoPumping.AutoPurge, Val(RecipeNum(RecipeRunIndex).PurgeONTime), Val(RecipeNum(RecipeRunIndex).PurgeOFFTime), 9999)
                                CAutoPumping.AutoPurge = True
                            End If
                            AutoProcessTimerEnabled = True
                            AutoProcessTimer = 2
                            Control_State = 19
                        End If
                    End If
                Else
                    ProcessStatusString = AbortStr + State + ProcessStatusList(SystemLanguage, Control_State)
                    AppendMultiData(ProcessEeventFileName, 80, ADate & "  " & TTime & "-->", ProcessStatusString)
                    Last_State = Control_State
                    Control_State = 99
                End If

            Case 19
                If ProcessMode_RUN Then
                    ProcessStatusString = ProcessStr + State + GetLangText("³q®ð­°·Å¤¤...", "Purge cooling...") + Format(CAutoPumping.Timer, "[0]/") + Format(CAutoPumping.PurgeCounter, "[0]") + DelayTimer
                    If AutoProcessTimerEnabled = False Then

                        Dim cooltempok As Integer = 0
                        For i = 0 To MAXPLATE
                            If TopTempPV(i) > Val(SystemParameters.CoolingTemperature) Then cooltempok += 1
                            If BotTempPV(i) > Val(SystemParameters.CoolingTemperature) Then cooltempok += 1
                        Next
                        If cooltempok = 0 Then
                            If CAutoPumping.AutoPurge = False Then
                                CAutoPumping.SetAutoPurge(CAutoPumping.AutoPurge, Val(RecipeNum(RecipeRunIndex).PurgeONTime), Val(RecipeNum(RecipeRunIndex).PurgeOFFTime), 9999)
                                CAutoPumping.AutoPurge = True
                            End If
                            ProcessStatusString = ProcessStr + State + GetLangText("³q®ð­°·ÅOK...", "Purge cooling OK.")

                            AutoProcessTimerEnabled = True
                            AutoProcessTimer = 5 '
                            If Val(RecipeNum(RecipeRunIndex).KeepBonding) = 0 Then
                                ProcessStatusString = ProcessStr + State + GetLangText("³q®ð­°·ÅOK,À£¬û¤U­°.", "Purge cooling OK. Bond down.")
                                'À£¬û¤U­°
                                For i = 0 To MAXPLATE
                                    ManualControl(i).SetPlateDown(True)
                                    ManualControl(i).SetPlateUp(False)
                                    ManualControl(i).SetBondForce(False)
                                Next
                            End If
                            If Val(RecipeNum(RecipeRunIndex).AutoVent) > 0 Then
                                Last_State = Control_State
                                Control_State = 12
                            Else
                                Last_State = Control_State
                                Control_State = 15
                            End If
                        End If
                    End If
                Else
                    ProcessStatusString = AbortStr + State + ProcessStatusList(SystemLanguage, Control_State)
                    AppendMultiData(ProcessEeventFileName, 80, ADate & "  " & TTime & "-->", ProcessStatusString)
                    Last_State = Control_State
                    Control_State = 99
                End If

            Case 10 'Purging
                If ProcessMode_RUN Then
                    ProcessStatusString = ProcessStr + State + ProcessStatusList(SystemLanguage, Control_State) + DelayTimer + "[" + (CAutoPumping.PurgeCounter + 1).ToString + "/" + SystemParameters.AutoPurgeCycle + "]" + Format(CAutoPumping.Timer, "[0]")
                    If AutoProcessTimerEnabled = False Then
                        ProcessStatusString = ProcessStr + State + ProcessStatusList(SystemLanguage, Control_State) + DelayTimer + "[" + (CAutoPumping.PurgeCounter + 1).ToString + "/" + SystemParameters.AutoPurgeCycle + "]" + Format(CAutoPumping.Timer, "[0]")
                        If CAutoPumping.AutoPurge = False Then
                            'AppendMultiData(ProcessEeventFileName, 256, ADate & "  " & TTime & "-->", ProcessStatusString)
                            AutoProcessTimerEnabled = True
                            AutoProcessTimer = 2
                            Last_State = Control_State
                            Control_State = 11
                        End If
                    End If
                Else
                    ProcessStatusString = AbortStr + State + ProcessStatusList(SystemLanguage, Control_State) + DelayTimer
                    AppendMultiData(ProcessEeventFileName, 80, ADate & "  " & TTime & "-->", ProcessStatusString)
                    Last_State = Control_State
                    Control_State = 99
                End If
            Case 11
                If ProcessMode_RUN Then
                    ProcessStatusString = ProcessStr + State + ProcessStatusList(SystemLanguage, Last_State) + DelayTimer
                    If AutoProcessTimerEnabled = False Then
                        ProcessStatusString = ProcessStr + State + ProcessStatusList(SystemLanguage, Control_State) + DelayTimer
                        'AppendMultiData(ProcessEeventFileName, 80, ADate & "  " & TTime & "-->", ProcessStatusString)
                        'AutoProcessTimerEnabled = True
                        'AutoProcessTimer = 2
                        MFC01_Control.Stop()
                        MFC02_Control.Stop()
                        If Val(RecipeNum(RecipeRunIndex).KeepBonding) = 0 Then
                            'À£¬û¤U­°
                            For i = 0 To MAXPLATE
                                If CSubAutoProcess(i).AbortStatus = False Then
                                    ManualControl(i).SetPlateDown(True)
                                    ManualControl(i).SetPlateUp(False)
                                    ManualControl(i).SetBondForce(False)
                                End If
                                ManualControl(i).SetHeater(False)
                            Next
                        End If
                        If CAutoPumping.AutoPurge = False Then
                            If Val(RecipeNum(RecipeRunIndex).AutoVent) > 0 Then
                                CAutoPumping.AutoPurge = False
                                CAutoPumping.Start = False
                                Output(DoRVIndex).Status = False
                                CAutoPumping.Start = False
                                CAutoPumping.AutoPurge = False

                                Last_State = Control_State
                                Control_State = 12
                            Else
                                Output(DoRVIndex).Status = False
                                CAutoPumping.Start = False
                                CAutoPumping.AutoPurge = False
                                Last_State = Control_State
                                Control_State = 15
                            End If
                            AutoProcessTimerEnabled = True
                            AutoProcessTimer = 3 '
                        End If
                    End If
                Else
                    ProcessStatusString = AbortStr + State + ProcessStatusList(SystemLanguage, Control_State) + DelayTimer
                    AppendMultiData(ProcessEeventFileName, 80, ADate & "  " & TTime & "-->", ProcessStatusString)
                    Last_State = Control_State
                    Control_State = 99
                End If
            Case 12 '»sµ{µ²§ô, VENT ¤¤
                If ProcessMode_RUN Then
                    ProcessStatusString = ProcessStr + State + ProcessStatusList(SystemLanguage, Last_State) + DelayTimer
                    If AutoProcessTimerEnabled = False Then
                        ProcessStatusString = ProcessStr + State + ProcessStatusList(SystemLanguage, Control_State) + "/[" + SystemParameters.CoolingTemperature + "]" + DelayTimer
                        CAutoPumping.Start = False
                        CAutoPumping.AutoPurge = False
                        For i = 0 To MAXPLATE
                            If ManualControl(i).GetHeater() Then ManualControl(i).SetHeater(False)
                        Next
                        Output(DoRVIndex).Status = False
                        Output(DoMPIndex).Status = False
                        Output(DoVentIndex).Status = True
                        'µ²§ô«á VENT
                        '///  If TopTempPV <= Val(SystemParameters.CoolingTemperature) And BotTempPV <= Val(SystemParameters.CoolingTemperature) Then
                        'AppendMultiData(ProcessEeventFileName, 80, ADate & "  " & TTime & "-->", ProcessStatusString)

                        AutoProcessTimerEnabled = True
                        AutoProcessTimer = 2 '
                        CAutoPumping.Start = False
                        ProcessToStepGo = False
                        Last_State = Control_State
                        Control_State = 13
                        '///End If
                    End If
                Else
                    ProcessStatusString = AbortStr + State + ProcessStatusList(SystemLanguage, Control_State) + DelayTimer
                    AppendMultiData(ProcessEeventFileName, 80, ADate & "  " & TTime & "-->", ProcessStatusString)
                    Last_State = Control_State
                    Control_State = 99
                End If
            Case 13
                If ProcessMode_RUN Then
                    ProcessStatusString = ProcessStr + State + ProcessStatusList(SystemLanguage, Last_State) + DelayTimer
                    If AutoProcessTimerEnabled = False Then
                        ProcessStatusString = ProcessStr + State + ProcessStatusList(SystemLanguage, Control_State) + DelayTimer + "Vacuum:" + "[" + GaugeCHVacStr + "]"
                        If Vac1ATM_Status Then
                            Dim cooltempok As Integer = 0
                            For i = 0 To MAXPLATE
                                If TopTempPV(i) > Val(SystemParameters.CoolingTemperature) Then cooltempok += 1
                                If BotTempPV(i) > Val(SystemParameters.CoolingTemperature) Then cooltempok += 1
                            Next
                            If cooltempok = 0 Then
                                If Val(RecipeNum(RecipeRunIndex).KeepBonding) = 0 Then
                                    'À£¬û¤U­°
                                    For i = 0 To MAXPLATE
                                        ManualControl(i).SetPlateDown(True)
                                        ManualControl(i).SetPlateUp(False)
                                        ManualControl(i).SetBondForce(False)
                                    Next
                                End If
                                If Val(RecipeNum(RecipeRunIndex).AutoDoorOpen) > 0 Then
                                    Output(DoDoor1UpIndex).Status = False
                                    Output(DoDoor1DownIndex).Status = True
                                    Output(DoDoor2UpIndex).Status = False
                                    Output(DoDoor2DownIndex).Status = True
                                End If
                                AutoProcessTimerEnabled = True
                                AutoProcessTimer = 3

                                '*****claire add Ãö purge »Ö 2023.8.11
                                Output(DoTopPurge1Index).Status = False
                                Output(DoTopPurge2Index).Status = False
                                Output(DoTopPurge3Index).Status = False
                                Output(DoBotPurge1Index).Status = False
                                Output(DoBotPurge2Index).Status = False
                                Output(DoBotPurge3Index).Status = False

                                '*****claire add 2023.8.11

                                Control_State = 14
                            End If
                        Else
                            Output(DoRVIndex).Status = False
                            Output(DoMPIndex).Status = False
                            Output(DoVentIndex).Status = True
                            AutoProcessTimerEnabled = True
                            AutoProcessTimer = 5
                        End If
                    End If
                Else
                    ProcessStatusString = AbortStr + State + ProcessStatusList(SystemLanguage, Control_State) + DelayTimer
                    AppendMultiData(ProcessEeventFileName, 80, ADate & "  " & TTime & "-->", ProcessStatusString)
                    Last_State = Control_State
                    Control_State = 99
                End If
            Case 14 'Wait Door Open
                If ProcessMode_RUN Then
                    ProcessStatusString = ProcessStr + State + ProcessStatusList(SystemLanguage, Last_State) + DelayTimer
                    If AutoProcessTimerEnabled = False Then
                        ProcessStatusString = ProcessStr + State + ProcessStatusList(SystemLanguage, Control_State) + DelayTimer
                        If Val(RecipeNum(RecipeRunIndex).AutoDoorOpen) > 0 Then
                            If Check_PLC_M(DoDoor1DownIndex) = False Then
                                Output(DoDoor1UpIndex).Status = False
                                Output(DoDoor1DownIndex).Status = True
                                Output(DoDoor2UpIndex).Status = False
                                Output(DoDoor2DownIndex).Status = True
                            End If
                            If Check_PLC_X(DiDoor1DownIndex) Then 'And Check_PLC_X(DiDoor2DownIndex) Then
                                Control_State = 15
                            End If
                        Else
                            Control_State = 15
                        End If
                    End If
                Else
                    ProcessStatusString = AbortStr + State + ProcessStatusList(SystemLanguage, Control_State) + DelayTimer
                    AppendMultiData(ProcessEeventFileName, 80, ADate & "  " & TTime & "-->", ProcessStatusString)
                    Last_State = Control_State
                    Control_State = 99
                End If

            Case 15
                ProcessMode_RUN = False
                CurveFreeze = True
                FormProcesss.btnVent.Enabled = True
                FormProcesss.btnRunProcess.Enabled = True
                ProcessVacuumOK = False
                ProcessPressureOK = False
                ProcessTopTempOK = False
                ProcessBotTempOK = False
                ProcessTempOK = False
                ProcessFirstConatctOK = False
                CurveFlag = False
                ProcessToStepGo = False
                For i = 0 To MAXPLATE
                    ManualControl(i).SetHeater(False)
                    ManualControl(i).RunMode = False
                Next
                FormProcesss.lblProcessStopTime.Text = NHour + ":" + NMin + ":" + NSec
                CAutoPumping.Start = False
                ProcessStatusString = ProcessStr + State + GetLangText("»sµ{µ²§ô.", "Process Complete!")

                If ProcessOkALMEnabled_Status Then Set_MBit(DoPressEndAlarmIndex, DEVICE_ON)
                Control_State = 0
                CAutoPumping.Start = False
                CAutoPumping.AutoPurge = False
                Output(DoRVIndex).Status = False
                Output(DoVentIndex).Status = False
                Output(DoMPIndex).Status = False
                If Purge_Flag Then
                    Output(DoTopPurge1Index).Status = False
                    Output(DoTopPurge2Index).Status = False
                    Output(DoTopPurge3Index).Status = False
                    Output(DoBotPurge1Index).Status = False
                    Output(DoBotPurge2Index).Status = False
                    Output(DoBotPurge3Index).Status = False

                End If
                'If SystemParameters.BarcodeOnly = "1" Then 'Add By Vincent 20160913
                '    FormProcesss.RecipeLoaded = False
                'End If
                MsgBoxLangOK("»sµ{µ²§ô.", "Process Complete!")
                ProcessStepIndex = 0

            Case 99 'Step Finished or Aborted
                RunCounts += 1
                If RunCounts > 100000 Then
                    RunCounts = 1
                End If
                WriteRunData()

                ProcessMode_RUN = False
                MFC01_Control.Stop()
                MFC02_Control.Stop()
                FormProcesss.lblProcessStopTime.Text = NHour + ":" + NMin + ":" + NSec
                ProcessToStepGo = False
                For i = 0 To MAXPLATE
                    ManualControl(i).SetHeater(False)
                    ManualControl(i).RunMode = False
                Next
                For i = 0 To MAXPLATE
                    CSubAutoProcess(i).Abort()
                Next
                FormProcesss.btnVent.Enabled = True
                FormProcesss.btnRunProcess.Enabled = True
                ProcessStepIndex = 0
                ProcessVacuumOK = False
                ProcessPressureOK = False
                ProcessTopTempOK = False
                ProcessBotTempOK = False
                ProcessTempOK = False
                ProcessFirstConatctOK = False
                CurveFlag = False
                CurveFreeze = True
                CAutoPumping.Start = False
                CAutoPumping.AutoPurge = False
                Output(DoVentIndex).Status = False
                Output(DoRVIndex).Status = False
                Output(DoMPIndex).Status = False
                If Purge_Flag Then
                    Output(DoTopPurge1Index).Status = False
                    Output(DoTopPurge2Index).Status = False
                    Output(DoTopPurge3Index).Status = False
                    Output(DoBotPurge1Index).Status = False
                    Output(DoBotPurge2Index).Status = False
                    Output(DoBotPurge3Index).Status = False
                End If
                If ProcessOkALMEnabled_Status Then Set_MBit(DoPressEndAlarmIndex, DEVICE_ON)
                Control_State = 0
                MsgBoxLangOK("»sµ{¤¤Â_!!", "Process Abort!!")
                'BZ_Status = False

        End Select
        If Old_State <> Control_State Then
            AppendMultiData(ProcessEeventFileName, 256, ADate & "  " & TTime & "-->", ProcessStatusString)
            Old_State = Control_State
        End If
        Return Control_State

    End Function

    Public Sub ProcessRecord_Task()
        Static Control_State As Byte
        Dim ShowData As String
        Dim Data(200) As String
        Dim j, datamax As Integer
        Dim i As Byte
        On Error Resume Next
        If ProcessRecordFileName = "" Then
            Exit Sub
        End If

        Select Case Control_State
            Case 0
                If ProcessMode_RUN Then
                    ProcessRecordsIndex = 0

                    Control_State = 1
                End If
            Case 1
                If ProcessMode_RUN Then
                    If ProcessRecordsIndex = 0 Then
                        ShowData = "Model:" + vbTab + Program_ModelName + vbTab + " Process Start for Recipe:" + vbTab + ProcessRecipeName + "Date/Time:" + ADate + " " + TTime + vbTab + "  PN:" + ProcessPN
                        AppendMultiData(ProcessRecordFileName, 150, ShowData)
                        'If RemoteCIM.Enable Then
                        '    ShowData = "EqId:" & RemoteCIM.EQID & vbCrLf
                        '    ShowData = ShowData & "DateTime:" & RemoteCIM.RecipeData.DateTime & vbCrLf
                        '    Dim ProductCount As Integer = RemoteCIM.RecipeData.Site1WaferList.Count + RemoteCIM.RecipeData.Site2WaferList.Count + RemoteCIM.RecipeData.Site3WaferList.Count
                        '    ShowData = ShowData & "ProductCount:" & ProductCount & vbCrLf
                        '    Dim k As Integer = 1
                        '    ShowData = ShowData & "Site #1" & vbCrLf
                        '    If RemoteCIM.RecipeData.Site1WaferList.Count > 0 Then
                        '        For i = 0 To RemoteCIM.RecipeData.Site1WaferList.Count - 1
                        '            ShowData = ShowData & "ProductId" & k.ToString & "_InputId: " & RemoteCIM.RecipeData.Site1WaferList.Item(i) & "," & RemoteCIM.RecipeData.Site1PairWaferList.Item(i) & vbCrLf
                        '            k += 1
                        '        Next
                        '    End If
                        '    ShowData = ShowData & "Site #2" & vbCrLf
                        '    If RemoteCIM.RecipeData.Site2WaferList.Count > 0 Then
                        '        For i = 0 To RemoteCIM.RecipeData.Site2WaferList.Count - 1
                        '            ShowData = ShowData & "ProductId" & k.ToString & "_InputId: " & RemoteCIM.RecipeData.Site2WaferList.Item(i) & "," & RemoteCIM.RecipeData.Site2PairWaferList.Item(i) & vbCrLf
                        '            k += 1
                        '        Next
                        '    End If
                        '    ShowData = ShowData & "Site #3" & vbCrLf
                        '    If RemoteCIM.RecipeData.Site3WaferList.Count > 0 Then
                        '        For i = 0 To RemoteCIM.RecipeData.Site3WaferList.Count - 1
                        '            ShowData = ShowData & "ProductId" & k.ToString & "_InputId: " & RemoteCIM.RecipeData.Site3WaferList.Item(i) & "," & RemoteCIM.RecipeData.Site3PairWaferList.Item(i) & vbCrLf
                        '            k += 1
                        '        Next
                        '    End If
                        '    ShowData = ShowData & "[Data]:" & vbCrLf
                        '    AppendData(ProcessRecordFileName, ShowData, 511)
                        'End If

                        ShowData = ""
                        datamax = 0
                        Data(datamax) = "No."
                        datamax += 1
                        Data(datamax) = "Step"
                        datamax += 1
                        Data(datamax) = "Time"
                        datamax += 1
                        Data(datamax) = "ProcessTime"
                        datamax += 1
                        Data(datamax) = "Vacuum"
                        datamax += 1
                        Data(datamax) = "MPCurrent"
                        For i = 0 To MAXPLATE
                            datamax += 1
                            Data(datamax) = "Site#" + Format(i + 1, "00") + " Step"
                            datamax += 1
                            Data(datamax) = "TopTemp" + Format(i + 1, "00")
                            datamax += 1
                            Data(datamax) = "BotTemp" + Format(i + 1, "00")
                            datamax += 1
                            Data(datamax) = "Pressure" + Format(i + 1, "00")
                            datamax += 1
                            Data(datamax) = "TopCurrent" + Format(i + 1, "00")
                            datamax += 1
                            Data(datamax) = "BotCurrent" + Format(i + 1, "00")
                            datamax += 1
                            Data(datamax) = "TopWater" + Format(i + 1, "00")
                            datamax += 1
                            Data(datamax) = "BotWater" + Format(i + 1, "00")
                        Next
                        For i = 0 To datamax - 1
                            ShowData = ShowData + Data(i) + Space(15 - Len(Data(i))) + vbTab '
                        Next
                        ShowData = ShowData + Data(i)
                        'AppendMultiData(ProcessRecordFileName, 511, ShowData)
                        AppendData(ProcessRecordFileName, ShowData, 511)
                        ShowData = ""
                        ProcessRecordsIndex += 1
                    End If

                    If ProcessMode_RUN Then

                        ShowData = ""
                        datamax = 0
                        Data(datamax) = Format(ProcessRecordsIndex)
                        datamax += 1
                        Data(datamax) = Format(ProcessStepIndex + 1)
                        datamax += 1
                        Data(datamax) = TTime
                        datamax += 1
                        Data(datamax) = ConvertSecToTime(TotalProcessTime)
                        datamax += 1
                        Data(datamax) = GaugeCHVacStr
                        datamax += 1
                        Data(datamax) = MPCurrentStr

                        For i = 0 To MAXPLATE
                            datamax += 1
                            Data(datamax) = CSubAutoProcess(i).RunIndex.ToString
                            datamax += 1
                            Data(datamax) = TopTempPVStr(i)
                            datamax += 1
                            Data(datamax) = BotTempPVStr(i)
                            datamax += 1
                            Data(datamax) = PressPVstr(i)
                            datamax += 1
                            Data(datamax) = TopCurrentStr(i)
                            datamax += 1
                            Data(datamax) = BotCurrentStr(i)
                            datamax += 1
                            Data(datamax) = FlowRead(i).GetTopFLowStr
                            datamax += 1
                            Data(datamax) = FlowRead(i).GetBotFLowStr

                        Next
                        For i = 0 To datamax - 1
                            ShowData = ShowData + Data(i) + Space(15 - Len(Data(i))) + vbTab
                        Next
                        ShowData = ShowData + Data(i)
                        AppendMultiData(ProcessRecordFileName, 255, ShowData)

                        'ProcessRecords.ProcessStep = Data(0)
                        'ProcessRecords.ProcessTime = Data(1)
                        'ProcessRecords.TopTemperature = Data(2)
                        'ProcessRecords.BotTemperature = Data(3)
                        'ProcessRecords.TopCurrent = Data(4)
                        'ProcessRecords.BotCurrent = Data(5)
                        'ProcessRecords.BondingPressure = Data(6)
                        'ProcessRecords.DPCurrent = Data(7)
                        'ProcessRecords.Vacuum = Data(8)
                        'FileOpen(21, ProcessRecordCurveFileName, OpenMode.Random, , OpenShare.Shared, 300)
                        'FilePut(21, ProcessRecords, ProcessRecordsIndex)
                        'FileClose(21)
                        ProcessRecordsIndex = ProcessRecordsIndex + 1
                    End If
                Else
                    Control_State = 99
                End If
            Case 99
                Control_State = 0
                ProcessRecordsIndex = 0
                'If ProcessRecordsIndex > 0 Then
                '    FileClose(21)
                'End If
        End Select
    End Sub

    '¦±½u¤Î»sµ{°O¿ý
    Public Sub ProcessRecord_Task_200ms()
        Static Control_State As Byte
        Dim ShowData As String
        Dim Data(200) As String
        Dim j, datamax As Integer
        Dim i As Byte
        On Error Resume Next
        If ProcessRecordFileName1 = "" Then
            Exit Sub
        End If

        Select Case Control_State
            Case 0
                If ProcessMode_RUN Then
                    ProcessRecordsIndex1 = 0

                    Control_State = 1
                End If
            Case 1

                If ProcessMode_RUN Then

                    If ProcessRecordsIndex1 = 0 Then
                        ShowData = "Model:" + vbTab + Program_ModelName + vbTab + " Process Start for Recipe:" + vbTab + ProcessRecipeName + "Date/Time:" + ADate + " " + TTime + vbTab + "  PN:" + ProcessPN
                        AppendMultiData(ProcessRecordFileName1, 150, ShowData)
                        ShowData = ""
                        datamax = 0
                        Data(datamax) = "No."
                        datamax += 1
                        Data(datamax) = "Step"
                        datamax += 1
                        Data(datamax) = "Time"
                        datamax += 1
                        Data(datamax) = "ProcessTime"
                        datamax += 1
                        Data(datamax) = "Vacuum"
                        datamax += 1
                        Data(datamax) = "MPCurrent"
                        For i = 0 To MAXPLATE
                            datamax += 1
                            Data(datamax) = "Site#" + Format(i + 1, "00") + " Step"
                            datamax += 1
                            Data(datamax) = "TopTemp" + Format(i + 1, "00")
                            datamax += 1
                            Data(datamax) = "BotTemp" + Format(i + 1, "00")
                            datamax += 1
                            Data(datamax) = "Pressure" + Format(i + 1, "00")
                            datamax += 1
                            Data(datamax) = "TopCurrent" + Format(i + 1, "00")
                            datamax += 1
                            Data(datamax) = "BotCurrent" + Format(i + 1, "00")
                            datamax += 1
                            Data(datamax) = "TopWater" + Format(i + 1, "00")
                            datamax += 1
                            Data(datamax) = "BotWater" + Format(i + 1, "00")
                        Next
                        For i = 0 To datamax - 1
                            ShowData = ShowData + Data(i) + Space(15 - Len(Data(i))) + vbTab '
                        Next
                        ShowData = ShowData + Data(i)
                        'AppendMultiData(ProcessRecordFileName, 511, ShowData)
                        AppendData(ProcessRecordFileName1, ShowData, 511)
                        ShowData = ""
                        ProcessRecordsIndex1 += 1
                    End If

                    If ProcessMode_RUN Then

                        ShowData = ""
                        datamax = 0
                        Data(datamax) = Format(ProcessRecordsIndex)
                        datamax += 1
                        Data(datamax) = Format(ProcessStepIndex + 1)
                        datamax += 1
                        Data(datamax) = TTime
                        datamax += 1
                        Data(datamax) = ConvertSecToTime(TotalProcessTime)
                        datamax += 1
                        Data(datamax) = GaugeCHVacStr
                        datamax += 1
                        Data(datamax) = MPCurrentStr
                        For i = 0 To MAXPLATE
                            datamax += 1
                            Data(datamax) = CSubAutoProcess(i).RunIndex.ToString
                            datamax += 1
                            Data(datamax) = TopTempPVStr(i)
                            datamax += 1
                            Data(datamax) = BotTempPVStr(i)
                            datamax += 1
                            Data(datamax) = PressPVstr(i)
                            datamax += 1
                            Data(datamax) = TopCurrentStr(i)
                            datamax += 1
                            Data(datamax) = BotCurrentStr(i)
                            datamax += 1
                            Data(datamax) = FlowRead(i).GetTopFLowStr
                            datamax += 1
                            Data(datamax) = FlowRead(i).GetBotFLowStr

                        Next
                        For i = 0 To datamax - 1
                            ShowData = ShowData + Data(i) + Space(15 - Len(Data(i))) + vbTab
                        Next
                        ShowData = ShowData + Data(i)
                        AppendMultiData(ProcessRecordFileName1, 255, ShowData)

                        'ProcessRecords.ProcessStep = Data(0)
                        'ProcessRecords.ProcessTime = Data(1)
                        'ProcessRecords.TopTemperature = Data(2)
                        'ProcessRecords.BotTemperature = Data(3)
                        'ProcessRecords.TopCurrent = Data(4)
                        'ProcessRecords.BotCurrent = Data(5)
                        'ProcessRecords.BondingPressure = Data(6)
                        'ProcessRecords.DPCurrent = Data(7)
                        'ProcessRecords.Vacuum = Data(8)
                        'FileOpen(21, ProcessRecordCurveFileName, OpenMode.Random, , OpenShare.Shared, 300)
                        'FilePut(21, ProcessRecords, ProcessRecordsIndex)
                        'FileClose(21)
                        ProcessRecordsIndex1 = ProcessRecordsIndex1 + 1
                    End If
                Else
                    Control_State = 99
                End If
            Case 99
                Control_State = 0
                ProcessRecordsIndex1 = 0
                'If ProcessRecordsIndex > 0 Then
                '    FileClose(21)
                'End If
        End Select
    End Sub
    '¦±½u¤Î»sµ{°O¿ý/¨Ì¾ÚPID timer interval
    Public Sub ProcessRecord_Task_ms()
        Static Control_State As Byte
        Dim ShowData As String
        Dim Data(200) As String
        Dim j, datamax As Integer
        Dim i As Byte
        On Error Resume Next
        If ProcessRecordFileName1 = "" Then
            Exit Sub
        End If

        Select Case Control_State
            Case 0
                If ProcessMode_RUN Then
                    ProcessRecordsIndex1 = 0

                    Control_State = 1
                End If
            Case 1

                If ProcessMode_RUN Then
                    '¼ÐÃD
                    If ProcessRecordsIndex1 = 0 Then
                        ShowData = "Model:" + vbTab + Program_ModelName + vbTab + " Process Start for Recipe:" + vbTab + ProcessRecipeName + "Date/Time:" + ADate + " " + TTime + vbTab + "  PN:" + ProcessPN
                        AppendMultiData(ProcessRecordFileName1, 150, ShowData)
                        ShowData = ""
                        datamax = 0
                        Data(datamax) = "No."
                        datamax += 1
                        Data(datamax) = "Step"
                        datamax += 1
                        Data(datamax) = "Time"
                        datamax += 1
                        Data(datamax) = "ProcessTime"
                        datamax += 1
                        Data(datamax) = "Vacuum"
                        datamax += 1
                        Data(datamax) = "MPCurrent"
                        For i = 0 To MAXPLATE
                            datamax += 1
                            Data(datamax) = "Site#" + Format(i + 1, "00") + " Step"
                            datamax += 1
                            Data(datamax) = "TopTemp" + Format(i + 1, "00")
                            datamax += 1
                            Data(datamax) = "BotTemp" + Format(i + 1, "00")
                            datamax += 1
                            Data(datamax) = "Pressure" + Format(i + 1, "00")
                            datamax += 1
                            Data(datamax) = "DA" + Format(i + 1, "00")
                            datamax += 1
                            Data(datamax) = "TopCurrent" + Format(i + 1, "00")
                            datamax += 1
                            Data(datamax) = "BotCurrent" + Format(i + 1, "00")
                            datamax += 1
                            Data(datamax) = "TopWater" + Format(i + 1, "00")
                            datamax += 1
                            Data(datamax) = "BotWater" + Format(i + 1, "00")
                        Next
                        For i = 0 To datamax - 1
                            ShowData = ShowData + Data(i) + Space(15 - Len(Data(i))) + vbTab '
                        Next
                        ShowData = ShowData + Data(i)
                        'AppendMultiData(ProcessRecordFileName, 511, ShowData)
                        AppendData(ProcessRecordFileName1, ShowData, 511)
                        ShowData = ""
                        ProcessRecordsIndex1 += 1
                    End If
                    'log ¸ê®Æ
                    If ProcessMode_RUN Then

                        ShowData = ""
                        datamax = 0
                        Data(datamax) = Format(ProcessRecordsIndex)
                        datamax += 1
                        Data(datamax) = Format(ProcessStepIndex + 1)
                        datamax += 1
                        Data(datamax) = TTime
                        datamax += 1
                        Data(datamax) = ConvertSecToTime(TotalProcessTime)
                        datamax += 1
                        Data(datamax) = GaugeCHVacStr
                        datamax += 1
                        Data(datamax) = MPCurrentStr
                        For i = 0 To MAXPLATE
                            datamax += 1
                            Data(datamax) = CSubAutoProcess(i).RunIndex.ToString
                            datamax += 1
                            Data(datamax) = TopTempPVStr(i)
                            datamax += 1
                            Data(datamax) = BotTempPVStr(i)
                            datamax += 1
                            Data(datamax) = PressPVstr(i)
                            datamax += 1
                            Data(datamax) = Get_PLC_R1000(ADScalerB01Index + i).ToString
                            datamax += 1
                            Data(datamax) = TopCurrentStr(i)
                            datamax += 1
                            Data(datamax) = BotCurrentStr(i)
                            datamax += 1
                            Data(datamax) = FlowRead(i).GetTopFLowStr
                            datamax += 1
                            Data(datamax) = FlowRead(i).GetBotFLowStr

                        Next
                        For i = 0 To datamax - 1
                            ShowData = ShowData + Data(i) + Space(15 - Len(Data(i))) + vbTab
                        Next
                        ShowData = ShowData + Data(i)
                        AppendMultiData(ProcessRecordFileName1, 255, ShowData)

                        'ProcessRecords.ProcessStep = Data(0)
                        'ProcessRecords.ProcessTime = Data(1)
                        'ProcessRecords.TopTemperature = Data(2)
                        'ProcessRecords.BotTemperature = Data(3)
                        'ProcessRecords.TopCurrent = Data(4)
                        'ProcessRecords.BotCurrent = Data(5)
                        'ProcessRecords.BondingPressure = Data(6)
                        'ProcessRecords.DPCurrent = Data(7)
                        'ProcessRecords.Vacuum = Data(8)
                        'FileOpen(21, ProcessRecordCurveFileName, OpenMode.Random, , OpenShare.Shared, 300)
                        'FilePut(21, ProcessRecords, ProcessRecordsIndex)
                        'FileClose(21)
                        ProcessRecordsIndex1 = ProcessRecordsIndex1 + 1
                    End If
                Else
                    Control_State = 99
                End If
            Case 99
                Control_State = 0
                ProcessRecordsIndex1 = 0
                'If ProcessRecordsIndex > 0 Then
                '    FileClose(21)
                'End If
        End Select
    End Sub
    '¤â°Ê¸ê®Æ°O¿ý,
    Public DatalogStart As Boolean
    Public DatalogCount As Integer
    Public DatalogTime As Integer
    Public DatalogTimerCount As Integer

    Public DatalogCount1 As Integer
    Public DatalogTime1 As Integer
    Public DatalogTimerCount1 As Integer
    Public DataLogRecordFileName1 As String

    Public DataLogRecordFileName As String
    Public DataLogShortFileName As String
    Public DataLogShortFileName1 As String
    Public DataLogCUVFileName As String
    Public DataLogCUVFileName1 As String
    Public DataLogRecordDir As String

    Public Sub DataLog_Task()
        Static Control_State As Byte
        Dim ShowData As String
        Dim Data(99) As String
        Dim datamax As Integer
        Dim i, j As Integer
        On Error Resume Next
        Select Case Control_State
            Case 0  'ªì©l¤Æ
                If DatalogStart Then
                    DatalogTimerCount = 0
                    DatalogCount = 0
                    AppendMultiData(DataLogRecordFileName, 100, " DataLog Start At:", Now.ToString, "FileName:", DataLogShortFileName, "Model:", Program_ModelName)
                    ShowData = ""
                    datamax = 0
                    Data(datamax) = "No."
                    datamax += 1
                    Data(datamax) = "Time"
                    datamax += 1
                    Data(datamax) = "Vacuum"
                    datamax += 1
                    Data(datamax) = "MPCurrent"
                    If bolVaccTest = False Then
                        For i = 0 To MAXPLATE
                            datamax += 1
                            Data(datamax) = "Site#" + Format(i + 1, "00") + " Step"
                            datamax += 1
                            Data(datamax) = "TopTemp" + Format(i + 1, "00")
                            datamax += 1
                            Data(datamax) = "BotTemp" + Format(i + 1, "00")
                            datamax += 1
                            Data(datamax) = "Pressure" + Format(i + 1, "00")
                            datamax += 1
                            Data(datamax) = "TopCurrent" + Format(i + 1, "00")
                            datamax += 1
                            Data(datamax) = "BotCurrent" + Format(i + 1, "00")
                            datamax += 1
                            Data(datamax) = "TopWater" + Format(i + 1, "00")
                            datamax += 1
                            Data(datamax) = "BotWater" + Format(i + 1, "00")
                        Next
                    End If
                    For i = 0 To datamax - 1
                        ShowData = ShowData + Data(i) + Space(15 - Len(Data(i))) + vbTab '
                    Next
                    ShowData = ShowData + Data(i)
                    AppendData(DataLogRecordFileName, ShowData, 150)
                    Control_State = 1
                End If
            Case 1
                DatalogTimerCount = DatalogTimerCount + 1
                If DatalogStart And DatalogTimerCount >= DatalogTime Then
                    '¦¬¶°¸ê®Æ°O¿ý
                    DatalogTimerCount = 0
                    ShowData = ""
                    datamax = 0
                    Data(datamax) = Format(DatalogCount, "00000:")
                    datamax += 1
                    Data(datamax) = TTime
                    datamax += 1
                    Data(datamax) = GaugeCHVacStr
                    datamax += 1
                    Data(datamax) = MPCurrentStr
                    If bolVaccTest = False Then
                        For i = 0 To MAXPLATE
                            datamax += 1
                            Data(datamax) = CSubAutoProcess(i).RunIndex.ToString
                            datamax += 1
                            Data(datamax) = TopTempPVStr(i)
                            datamax += 1
                            Data(datamax) = BotTempPVStr(i)
                            datamax += 1
                            Data(datamax) = PressPVstr(i)
                            datamax += 1
                            Data(datamax) = TopCurrentStr(i)
                            datamax += 1
                            Data(datamax) = BotCurrentStr(i)
                            datamax += 1
                            Data(datamax) = FlowRead(i).GetTopFLowStr
                            datamax += 1
                            Data(datamax) = FlowRead(i).GetBotFLowStr

                        Next
                    End If
                    For i = 0 To datamax - 1
                        ShowData = ShowData + Data(i) + Space(15 - Len(Data(i))) + vbTab '
                    Next
                    ShowData = ShowData + Data(i)
                    '¼g¤J¸ê®Æ°O¿ý
                    AppendData(DataLogRecordFileName, ShowData, 150)
                    DatalogCount = DatalogCount + 1
                Else
                    If DatalogStart = False Then Control_State = 0
                End If
        End Select
    End Sub
    Public Sub DataLog_Task_200ms()
        Static Control_State As Byte
        Dim ShowData As String
        Dim Data(99) As String
        Dim datamax As Integer
        Dim i, j As Integer
        On Error Resume Next
        Select Case Control_State
            Case 0  'ªì©l¤Æ
                If DatalogStart Then
                    DatalogTimerCount1 = 0
                    DatalogCount1 = 0
                    AppendMultiData(DataLogRecordFileName1, 100, " DataLog Start At:", Now.ToString, "FileName:", DataLogShortFileName, "Model:", Program_ModelName)
                    ShowData = ""
                    datamax = 0
                    Data(datamax) = "No."
                    datamax += 1
                    Data(datamax) = "Time"
                    datamax += 1
                    Data(datamax) = "Vacuum"
                    datamax += 1
                    Data(datamax) = "MPCurrent"
                    For i = 0 To MAXPLATE
                        datamax += 1
                        Data(datamax) = "Site#" + Format(i + 1, "00") + " Step"
                        datamax += 1
                        Data(datamax) = "TopTemp" + Format(i + 1, "00")
                        datamax += 1
                        Data(datamax) = "BotTemp" + Format(i + 1, "00")
                        datamax += 1
                        Data(datamax) = "Pressure" + Format(i + 1, "00")
                        datamax += 1
                        Data(datamax) = "TopCurrent" + Format(i + 1, "00")
                        datamax += 1
                        Data(datamax) = "BotCurrent" + Format(i + 1, "00")
                        datamax += 1
                        Data(datamax) = "TopWater" + Format(i + 1, "00")
                        datamax += 1
                        Data(datamax) = "BotWater" + Format(i + 1, "00")
                    Next
                    For i = 0 To datamax
                        ShowData = ShowData + Data(i) + Space(15 - Len(Data(i))) + vbTab '
                    Next
                    AppendData(DataLogRecordFileName1, ShowData, 150)
                    Control_State = 1
                End If
            Case 1
                'DatalogTimerCount1 = DatalogTimerCount1 + 1
                If DatalogStart Then
                    '¦¬¶°¸ê®Æ°O¿ý
                    DatalogTimerCount1 = 0
                    ShowData = ""
                    datamax = 0
                    Data(datamax) = Format(DatalogCount1, "00000:")
                    datamax += 1
                    Data(datamax) = TTime
                    datamax += 1
                    Data(datamax) = GaugeCHVacStr
                    datamax += 1
                    Data(datamax) = MPCurrentStr
                    For i = 0 To MAXPLATE
                        datamax += 1
                        Data(datamax) = CSubAutoProcess(i).RunIndex.ToString
                        datamax += 1
                        Data(datamax) = TopTempPVStr(i)
                        datamax += 1
                        Data(datamax) = BotTempPVStr(i)
                        datamax += 1
                        Data(datamax) = PressPVstr(i)
                        datamax += 1
                        Data(datamax) = TopCurrentStr(i)
                        datamax += 1
                        Data(datamax) = FlowRead(i).GetTopFLowStr
                        datamax += 1
                        Data(datamax) = FlowRead(i).GetBotFLowStr
                    Next
                    For i = 0 To datamax - 1
                        ShowData = ShowData + Data(i) + Space(15 - Len(Data(i))) + vbTab '
                    Next
                    ShowData = ShowData + Data(i)
                    '¼g¤J¸ê®Æ°O¿ý
                    AppendData(DataLogRecordFileName1, ShowData, 150)
                    DatalogCount1 = DatalogCount1 + 1
                Else
                    If DatalogStart = False Then Control_State = 0
                End If
        End Select
    End Sub

    ' ¤â°Ê­p®É¾¹(¥¿¼Æ/­Ë¼Æ)-----------------------------------STart
    <StructLayout(LayoutKind.Sequential)> Structure Timercounts
        Public set_min As Integer
        Public set_sec As Integer
        Public pv_min As Integer
        Public pv_sec As Integer
    End Structure

    Public Timercount As Timercounts
    Public Timercount_shift As Boolean
    Public Timercount_enable As Boolean
    Public Timercount2_enable As Boolean 'for mainlist2

    Public Timercount_up As Boolean
    Public Timercount_down As Boolean
    Public Timercount_start As Integer
    Public Timercount_last As Integer
    Public Timercount_sys As Integer
    Public Timercount_now As Integer


    Public Sub TimerCountUp_Down(ByRef obj_Start As Object, ByRef obj_min As Object, ByRef obj_sec As Object)
        Dim hh As Integer
        Dim mm As Integer
        Dim ss As Integer
        '¨ú±o¥Ø«e®É¶¡
        hh = Val(NHour)
        mm = Val(NMin)
        ss = Val(NSec)
        '±N¥Ø«e®É¶¡Âà´«¦¨¬í¼Æ
        Timercount_sys = 3600 * hh + 60 * mm + ss

        If Timercount_sys = 3600 And Timercount_shift = False Then
            Timercount_now = Timercount_now + 1
            Timercount_shift = True
        End If
        If Timercount_last <> Timercount_sys Then
            '¤W¼Æ­p®É¾¹
            If Timercount_up Then
                '­p®É­È¥[1
                Timercount_now = Timercount_now + 1
                '­pºâ¤À¤Î¬í
                Timercount.pv_min = Timercount_now \ 60             '¬í°£¥H60¨ú°Ó¼Æ
                Timercount.pv_sec = Timercount_now Mod 60           '¨ú¬í¤§¾l¼Æ
                '§ó·sªí³æ­p®É­È
                obj_min.Text = Format(Timercount.pv_min, "#0")
                obj_sec.Text = Format(Timercount.pv_sec, "#0")
            End If
            '­Ë¼Æ­p®É¾¹
            If Timercount_down Then
                '­p®É­È´î1
                Timercount_now = Timercount_now - 1
                '´î1«á¤£¬°0,ªí¥ÜÁÙ¥¼¼Æ¨ì
                If Timercount_now > 0 Then
                    Timercount.pv_min = Timercount_now \ 60         '¬í°£¥H60¨ú°Ó¼Æ
                    Timercount.pv_sec = Timercount_now Mod 60       '¨ú¬í¤§¾l¼Æ
                    '§ó·sªí³æ­p®É­È
                    obj_min.Text = Format(Timercount.pv_min, "#0")
                    obj_sec.Text = Format(Timercount.pv_sec, "#0")
                Else
                    '­p®É¤w¨ì
                    Timercount_now = 0          '²M°£­p®ÉÅÜ¼Æ
                    Timercount_enable = False   '°±¤î­p®É
                    If bolVaccTest And Timercount_enable = False Then
                        CAutoPumping.Start = False
                        bolVaccTest = False
                        Output(DoMPIndex).Status = False
                        Output(DoRVIndex).Status = False
                        CSVTimerStartPb_Status = False
                    End If
                    Timercount_up = False       '
                    Timercount_down = False
                    '§ó·sªí³æ­p®É­È
                    obj_min.Text = "0"
                    obj_sec.Text = "0"
                    'obj_Start.Text = GetLangText("¶}©l­p®É",  "Start")
                    'Åã¥Ü°T®§
                    MsgBoxLangOK("­p®É§¹¦¨!", "Time Up")
                End If
            End If
            Timercount_last = 3600 * hh + 60 * mm + ss
        End If
    End Sub

    ' ¤â°Ê­p®É¾¹(¥¿¼Æ/­Ë¼Æ)-----------------------------------End


    '¦Û°Ê©â¯uªÅÃþ§O
    Public CAutoPumping As New CAutoVacuum(DoMPIndex, DoRVIndex, DoVentIndex, DiDoor1UpIndex, DiCDAIndex, DiEMOIndex, DiDPFailIndex, ADVacuumIndex)
    Public Class CAutoVacuum
        Private RV_ON_Time As Integer
        Private RV_ON_TimeStr As String


        Private DTimer As Timer
        Private RunTimer As Timer
        Private DelayTimerEnabled As Boolean
        Private DelayTimer As Integer
        Private RunStatus As Boolean
        'AutoPurge 
        Private PurgeStatus As Boolean
        Private PurgeOK As Boolean
        Private PurgeONTime As Integer
        Private PurgeOFFTime As Integer
        Private PurgeCycle As Integer
        Private PurgeCount As Integer
        'Keep& Proctect Vac.
        Private AutoBasePressure As Boolean
        Private BasePressure As Double
        Private BasePressureHi As Double
        Private CurrentVac As Double

        Private MPOn10sStatus As Boolean
        Private Status As Boolean
        'Do
        Private RV_Index As Integer
        Private DP_Index As Integer
        Private Vent_Index As Integer

        'Di
        Private Door_Index As Integer
        Private CDAIndex As Integer
        Private EMOIndex As Integer
        Private MPOLIndex As Integer
        'AD
        Private DAVacuumGaugeIndex As Integer

        'InterLock
        Private Interlock As Boolean
        'State change
        Private Control_State As Integer

        Property Start() As Boolean
            Get
                Return RunStatus
            End Get
            Set(ByVal value As Boolean)
                RunStatus = value
                If RunStatus = False Then
                    PurgeOK = False
                    AutoBasePressure = False
                End If
            End Set
        End Property

        ReadOnly Property State() As Integer
            Get
                Return Control_State
            End Get
        End Property
        ReadOnly Property Timer() As Integer
            Get
                Return DelayTimer
            End Get
        End Property
        ReadOnly Property PurgeCounter() As Integer
            Get
                Return PurgeCount
            End Get
        End Property

        Property AutoPurge() As Boolean
            Get
                Return PurgeStatus
            End Get
            Set(ByVal value As Boolean)
                PurgeStatus = value
            End Set
        End Property

        Property AutoProtection() As Boolean
            Get
                Return AutoBasePressure
            End Get
            Set(ByVal value As Boolean)
                AutoBasePressure = value
            End Set
        End Property


        'GP275 Åª¨úÅÜ¼Æ (¸ü¤JµÄ¨Ï¥Î¤§¯uªÅ­p),0-10V (0.3~5.659V)¬dªíªk 
        Private Gp275PressureIndex() As Single = {1000, 900, 800, 760, 700, 600, 500, 400, 300, 200,
                                                 100, 50, 20, 10, 5, 2, 1, 0.5, 0.2, 0.1,
                                                 0.05, 0.02, 0.01, 0.005, 0.002, 0.001}
        'AD ¼Æ­È, ¤£Âà´« 0-10V, 0-8191
        Private Gp275VoltageIndex() As Integer = {4635, 4598, 4553, 4533, 4501, 4439, 4365, 4279, 4186, 4111,
                                                 4050, 3969, 3749, 3445, 3010, 2328, 1816, 1379, 946, 718,
                                                 559, 428, 373, 342, 321, 315}
        Private Function GP275_Convert(ByVal ADCount As Integer) As Double
            Dim i As Integer
            Dim a1, a2, b1, b2, c1 As Single
            Dim VacValue As Single
            'ÀË¬d¯uªÅ­p¬O§_¦s¦b
            If ADCount < 300 Then
                Return 0
            End If
            '¬dªí¨ú±o ¯uªÅ­È
            For i = 1 To 25
                If ADCount > Gp275VoltageIndex(i) Then
                    a1 = Gp275PressureIndex(i - 1)
                    a2 = Gp275PressureIndex(i)
                    b1 = Gp275VoltageIndex(i - 1)
                    b2 = Gp275VoltageIndex(i)
                    c1 = ADCount - Gp275VoltageIndex(i)
                    VacValue = (a2 + (c1 / (b1 - b2)) * (a1 - a2))
                    Exit For
                End If
            Next
            Return VacValue
        End Function

        Sub New(ByVal iDPIndex As Integer, ByVal iRVIndex As Integer, ByVal iVentIndex As Integer, ByVal iDoorIndex As Integer, ByVal iCDAIndex As Integer, ByVal iEMOIndex As Integer, ByVal iMPOLIndex As Integer, ByVal DAVacIndex As Integer)
            Interlock = False
            DTimer = New Timer
            DTimer.Interval = 1000
            AddHandler DTimer.Tick, AddressOf Timer_Tick
            DTimer.Enabled = True
            RunTimer = New Timer
            RunTimer.Interval = 200
            AddHandler RunTimer.Tick, AddressOf Run
            RunTimer.Enabled = True

            RV_Index = iRVIndex
            DP_Index = iDPIndex
            Vent_Index = iVentIndex
            CDAIndex = iCDAIndex
            EMOIndex = iEMOIndex
            MPOLIndex = iMPOLIndex
            DAVacuumGaugeIndex = DAVacIndex
            Door_Index = iDoorIndex
            PurgeOK = False
            RV_ON_Time = ReadProgData("PUMPING_SETUP", "RV_ON_DELAY", "20", ProgramINIFile)
            WriteProgData("PUMPING_SETUP", "RV_ON_DELAY", RV_ON_Time.ToString, ProgramINIFile)
        End Sub

        Property SetRV_ON_Time() As Integer
            Get
                Return RV_ON_Time
            End Get
            Set(ByVal value As Integer)
                RV_ON_Time = value
                WriteProgData("PUMPING_SETUP", "RV_ON_DELAY", RV_ON_Time.ToString, ProgramINIFile)
            End Set
        End Property

        'Time Delay Function
        Private Sub SetTimer(ByVal iTimer As Integer)
            DelayTimerEnabled = True
            DelayTimer = iTimer
        End Sub
        Private Function TimeUp()
            Return Not DelayTimerEnabled
        End Function

        'Auto Keep Vac Methid 
        Public Sub SetBasePressure(ByVal Enabled As Boolean, ByVal VacHiSV As Double, ByVal VacLoSV As Double)
            AutoBasePressure = Enabled
            BasePressure = VacLoSV
            BasePressureHi = VacHiSV
        End Sub
        Public Sub StopBasePressure()
            AutoBasePressure = False
        End Sub

        'AUtoPurge Method 
        Public Sub SetAutoPurge(ByVal Enabled As Boolean, ByVal iOnTime As Integer, ByVal iOffTime As Integer, ByVal iCycle As Integer)
            PurgeStatus = Enabled
            PurgeONTime = iOnTime
            PurgeOFFTime = iOffTime
            PurgeCycle = iCycle

        End Sub
        Public Sub StopAutoPurge()
            PurgeStatus = False
        End Sub

        'TImer Counting 
        Private Sub Timer_Tick()
            Static Timercount As Integer
            Dim astr As String = ""
            Dim i As Integer
            Dim curSec As Long
            curSec = Now().Second
            If curSec <> Timercount Then
                Timercount = curSec


            End If
            If DelayTimerEnabled Then
                DelayTimer -= 1
                If DelayTimer <= 0 Then
                    DelayTimerEnabled = False
                    DelayTimer = 0
                End If
            End If
        End Sub

        'Main Flow
        Private Sub Run()
            'CurrentVac = ChamberVacuum(Get_PLC_R1000(ADVacuumIndex), GaugeName) 'GP275_Convert(Get_PLC_R1000(ADVacuumIndex))
            CurrentVac = GaugeCHVac
            If Not (DP_Pump_Used Or Ulvac_LS120_Used) Then AutoBasePressure = True
            Interlock = Check_PLC_X(CDAIndex) And Check_PLC_X(MPOLIndex) = False And Check_PLC_X(EMOIndex) And Check_PLC_X(DiPullerCloseIndex)
            If Interlock = False Then
                RunStatus = False
            End If
            If Check_PLC_Y(DoMPIndex) = False Then
                MPOn10sStatus = False
            End If
            If RunStatus Then
                Select Case Control_State
                    Case 0 'DP ON
                        If TimeUp() Then
                            If Check_PLC_Y(DP_Index) = False Then
                                'DPPb_Status = True
                                Set_MBit(DP_Index, DEVICE_ON)
                                If MPOn10sStatus = False Then
                                    SetTimer(RV_ON_Time)
                                Else
                                    SetTimer(3)
                                End If
                            End If
                            Control_State = 1
                        End If
                    Case 1 'CHECK DP STATUS
                        If TimeUp() And Check_PLC_Y(DP_Index) Then
                            MPOn10sStatus = True
                            Control_State = 2
                            If PurgeStatus And PurgeOK = False Then
                                If PurgeStatus = False Then
                                    PurgeStatus = True
                                    PurgeCount = 0
                                End If
                                Control_State = 3
                            Else
                                PurgeOK = False
                                PurgeStatus = False
                                Control_State = 2
                            End If
                        Else
                            Control_State = 0
                        End If

                    Case 2 'RVP ON
                        If TimeUp() Then
                            If Check_PLC_X(Door_Index) And Check_PLC_Y(DP_Index) And Check_PLC_Y(Vent_Index) = False Then
                                If Check_PLC_Y(RV_Index) = False Then
                                    Output(Vent_Index).Status = False
                                    'Set_MBit(Vent_Index, DEVICE_OFF)
                                    Output(RV_Index).Status = True
                                    'Set_MBit(RV_Index, DEVICE_ON)
                                End If
                                If AutoBasePressure Then
                                    SetTimer(3)
                                    Control_State = 7
                                Else
                                    SetTimer(1)
                                    Control_State = 0
                                End If
                            Else
                                If Check_PLC_Y(RV_Index) Then
                                    Output(RV_Index).Status = False
                                    'Set_MBit(RV_Index, DEVICE_OFF)
                                    SetTimer(3)
                                End If
                                Control_State = 0
                            End If
                        End If
                        '------------------------------------------------------------------------------------
                        '¦Û°Ê¯uªÅ±±¨î
                    Case 7 'ÀË¬d¯uªÅ«×¬O§_¹L°ª
                        If AutoBasePressure Then
                            If TimeUp() Then
                                '¯uªÅ«×¤p©ó³]©w­È
                                If CurrentVac < BasePressureHi Then
                                    SetTimer(10) '30s    ¦A©â10¬í
                                    Control_State = 8
                                Else
                                    Control_State = 0
                                End If
                            End If
                        Else
                            Control_State = 0
                        End If
                    Case 8 'Ãö³¬ RV
                        If AutoBasePressure Then
                            If TimeUp() Then
                                If Check_PLC_Y(RV_Index) = True Then
                                    Set_MBit(RV_Index, DEVICE_OFF)
                                    SetTimer(3)
                                    Control_State = 9
                                Else
                                    Control_State = 0
                                End If
                            End If
                        Else
                            Control_State = 0
                        End If
                    Case 9 'Ãö³¬ MP
                        If AutoBasePressure Then
                            If TimeUp() Then
                                If Check_PLC_Y(DP_Index) Then
                                    Set_MBit(DP_Index, DEVICE_OFF)
                                End If
                                '­Y¯uªÅ«×¦^À£¨ì §CÀ£, «h¦A­«·s±Ò°Ê.
                                If (CurrentVac > BasePressure) Or PurgeStatus Then
                                    SetTimer(3)
                                    Control_State = 0
                                End If
                            End If
                        Else
                            Control_State = 0
                        End If
                        '------------------------------------------------------------------------------------
                        '====================================================================================
                        ' Auto Purge State 
                    Case 3 'AutoPurge -- RV ON
                        If TimeUp() Then
                            If Check_PLC_Y(DP_Index) And PurgeStatus Then
                                If Check_PLC_Y(RV_Index) = False Then
                                    If Check_PLC_Y(Vent_Index) Then
                                        Set_MBit(Vent_Index, DEVICE_OFF)
                                        If Purge_Flag Then
                                            Output(DoTopPurge1Index).Status = False
                                            Output(DoTopPurge2Index).Status = False
                                            Output(DoTopPurge3Index).Status = False

                                            Output(DoBotPurge1Index).Status = False
                                            Output(DoBotPurge2Index).Status = False
                                            Output(DoBotPurge3Index).Status = False
                                        End If
                                    End If
                                    Set_MBit(RV_Index, DEVICE_ON)
                                    SetTimer(PurgeOFFTime)
                                End If
                                Control_State = 4
                            Else
                                Control_State = 0
                            End If
                        End If

                    Case 4 'RV OFF
                        If TimeUp() Then
                            If Check_PLC_Y(DP_Index) Then
                                If Check_PLC_Y(RV_Index) Then
                                    Set_MBit(RV_Index, DEVICE_OFF)
                                    SetTimer(2)
                                    Control_State = 5
                                Else
                                    Control_State = 3
                                End If
                            Else
                                Control_State = 0
                            End If
                        End If
                    Case 5 'VENT ON
                        If TimeUp() Then
                            If Check_PLC_Y(DP_Index) Then
                                If Check_PLC_Y(RV_Index) = False Then
                                    Set_MBit(Vent_Index, DEVICE_ON)
                                    If Purge_Flag Then
                                        Output(DoTopPurge1Index).Status = True
                                        Output(DoTopPurge2Index).Status = True
                                        Output(DoTopPurge3Index).Status = True

                                        Output(DoBotPurge1Index).Status = True
                                        Output(DoBotPurge2Index).Status = True
                                        Output(DoBotPurge3Index).Status = True
                                    End If
                                    SetTimer(PurgeONTime)
                                    Control_State = 6
                                Else
                                    Control_State = 4
                                End If

                            Else
                                Control_State = 0
                            End If
                        End If
                    Case 6 'VENT Off
                        If TimeUp() Then
                            If Check_PLC_Y(DP_Index) Then
                                If Check_PLC_Y(Vent_Index) = True Then
                                    Set_MBit(Vent_Index, DEVICE_OFF)
                                    If Purge_Flag Then
                                        Output(DoTopPurge1Index).Status = False
                                        Output(DoTopPurge2Index).Status = False
                                        Output(DoTopPurge3Index).Status = False

                                        Output(DoBotPurge1Index).Status = False
                                        Output(DoBotPurge2Index).Status = False
                                        Output(DoBotPurge3Index).Status = False
                                    End If
                                End If
                                SetTimer(2)
                                PurgeCount += 1
                                If PurgeCount >= PurgeCycle Then
                                    PurgeOK = True
                                    PurgeStatus = False
                                    PurgeCount = 0
                                    Control_State = 0
                                Else
                                    Control_State = 3
                                End If
                                'If PurgeCount >= PurgeCycle Then
                                '    PurgeOK = True
                                '    Control_State = 0
                                'Else
                                '    Control_State = 3
                                'End If

                            Else
                                Control_State = 0
                            End If
                        End If
                        '====================================================================================
                End Select
            Else
                Control_State = 0
            End If


        End Sub

    End Class
    '¿O¸¹±±¨îÃþ§O
    Public CLampControl As New CLampClass(Alarm_status, ProcessMode_RUN, DoRLLampIndex, DoYLLampIndex, DoGLLampIndex)
    Class CLampClass
        Private RL_Index As Integer
        Private YL_Index As Integer
        Private GL_Index As Integer
        Private control_state As Integer
        Private RunTimer As Timer
        Private NowTimeCount As Integer
        Private OldTimeCount As Integer

        Private IsAlarm As Boolean
        Private IsProcess As Boolean

        Private DTimer As Timer
        Private DelayTimerEnabled As Boolean
        Private DelayTimer As Integer

        Sub New(ByRef bAlarm As Boolean, ByRef bProcessRun As Boolean, ByVal iRL As Integer, ByVal iYL As Integer, ByVal iGL As Integer)
            RL_Index = iRL
            YL_Index = iYL
            GL_Index = iGL
            IsAlarm = bAlarm
            IsProcess = bProcessRun

            RunTimer = New Timer
            RunTimer.Interval = 500
            AddHandler RunTimer.Tick, AddressOf Run
            RunTimer.Enabled = True

            DTimer = New Timer
            DTimer.Interval = 300
            AddHandler DTimer.Tick, AddressOf Timer_Tick
            DTimer.Enabled = True
        End Sub
        'TImer Counting 
        Private Sub Timer_Tick()
            NowTimeCount = DatePart(DateInterval.Second, Now())
            If NowTimeCount <> OldTimeCount Then
                If DelayTimerEnabled Then
                    DelayTimer -= 1
                    If DelayTimer <= 0 Then
                        DelayTimerEnabled = False
                        DelayTimer = 0
                    End If
                End If
                OldTimeCount = NowTimeCount
            End If
        End Sub
        '¿O¸¹±±¨î
        Private Sub Run()
            IsAlarm = Alarm_status
            IsProcess = ProcessMode_RUN
            Select Case control_state
                Case 0
                    If DelayTimerEnabled = False Then
                        If IsAlarm Then
                            If PLC_Y(RL_Index) = "0" Then
                                Set_MBit(RL_Index, DEVICE_ON)
                            End If
                        Else
                            If PLC_Y(RL_Index) = "1" Then
                                Set_MBit(RL_Index, DEVICE_OFF)
                            End If
                        End If
                        'DelayTimerEnabled = True
                        'DelayTimer = 1
                        control_state = 1
                    End If
                Case 1
                    If DelayTimerEnabled = False Then
                        If IsProcess Then
                            If PLC_Y(YL_Index) = "0" Then
                                Set_MBit(YL_Index, DEVICE_ON)
                            End If
                        Else
                            If PLC_Y(YL_Index) = "1" Then
                                Set_MBit(YL_Index, DEVICE_OFF)
                            End If
                        End If
                        'DelayTimerEnabled = True
                        'DelayTimer = 1
                        control_state = 2
                    End If
                Case 2
                    If DelayTimerEnabled = False Then
                        If Not IsProcess And Not IsAlarm Then
                            If PLC_Y(GL_Index) = "0" Then
                                Set_MBit(GL_Index, DEVICE_ON)
                            End If
                        Else
                            If PLC_Y(GL_Index) = "1" Then
                                Set_MBit(GL_Index, DEVICE_OFF)
                            End If
                        End If
                        'DelayTimerEnabled = True
                        'DelayTimer = 1
                        control_state = 0
                    End If
            End Select
        End Sub
    End Class
    'MFC ON/OFF ¥æ´À¼Ò²Õ
    Public MFC01_Control As New Class_IntervalCOntrol(DoV10Index, DAMFC01Index, ADMFC01Index)
    Public MFC02_Control As New Class_IntervalCOntrol(DoV11Index, DAMFC02Index, ADMFC02Index)
    ''' <summary>
    ''' MFC ¥æ´À±±¨îÃþ§O Public MFC01_Control As New Class_IntervalCOntrol(DoV10Index, DAMFC01Index, ADMFC01Index)
    ''' </summary>
    ''' <remarks> Public MFC01_Control As New Class_IntervalCOntrol(DoV10Index, DAMFC01Index, ADMFC01Index)</remarks>
    Class Class_IntervalCOntrol
        '­p®É¾¹ª«¥ó
        Private DelayTimer As Timer
        '­p®ÉÅÜ¼Æ
        Private TickCount As Integer
        Private TickCountEnabled As Boolean
        'ª¬ºAÅÜ¼Æ
        Private Control_State As Integer
        'ª¬ºAÅÜ¼Æ
        Private Cond As Boolean
        '®É¶¡®Õ¥¿
        Private OldTime, CurTime As Integer
        'ÅÜ¼Æ
        Private DAIndex As Integer
        Private ADIndex As Integer
        Private OutputIndex As Integer
        '°õ¦æ¥ÎÅÜ¼Æ
        Private MFCFlow As Integer
        Private MFCOnTime As Integer
        Private MFCOffTime As Integer
        Public DelayTime As String
        '«Øºc¨ç¼Æ
        ''' <summary>
        '''ªì©l¤Æ«Øºc¨ç¼Æ
        ''' </summary>
        ''' <param name="iDoIndex">MFC ®ð»Ö¿é¥XÂI½s¸¹</param>
        ''' <param name="iDAIndex">MFC ®ð»Ö³]©w­È½s¸¹</param>
        ''' <param name="iADIndex">MFC ®ð»ÖÅª­È½s¸¹</param>
        ''' <remarks></remarks>
        Sub New(ByVal iDoIndex As Integer, ByVal iDAIndex As Integer, ByVal iADIndex As Integer)
            DelayTimer = New Timer
            DAIndex = iDAIndex
            ADIndex = iADIndex
            OutputIndex = iDoIndex
            DelayTimer.Interval = 100
            DelayTimer.Enabled = True
            AddHandler DelayTimer.Tick, AddressOf TimerTick
            TickCount = 0
        End Sub
        '­p®É¾¹
        Private Sub TimerTick()
            CurTime = DatePart(DateInterval.Second, Now())
            If CurTime <> OldTime Then
                If TickCountEnabled Then
                    TickCount = TickCount - 1
                    If TickCount <= 0 Then
                        TickCount = 0
                        TickCountEnabled = False
                    End If
                End If
                OldTime = CurTime

                If TickCount > 0 Then
                    DelayTime = Format(TickCount, "(00)")
                Else
                    DelayTime = ""
                End If
                FormManuals.lblMFCTime01.Text = DelayTime
                FormManuals.lblMFCTime02.Text = DelayTime
                FormProcesss.lblMFCTime01.Text = DelayTime
                FormProcesss.lblMFCTime02.Text = DelayTime
                MFCControl()
            End If
        End Sub
        ''' <summary>
        ''' ­«³] MFC  I/O 
        ''' </summary>
        ''' <param name="iDoIndex">MFC ®ð»Ö¿é¥XÂI½s¸¹</param>
        ''' <param name="iDAIndex">MFC ®ð»Ö³]©w­È½s¸¹</param>
        ''' <param name="iADIndex">MFC ®ð»ÖÅª­È½s¸¹</param>
        ''' <remarks></remarks>
        Public Sub Initial(ByVal iDoIndex As Integer, ByVal iDAIndex As Integer, ByVal iADIndex As Integer)
            DAIndex = iDAIndex
            ADIndex = iADIndex
            OutputIndex = iDoIndex
            DelayTimer.Enabled = True
        End Sub
        ''' <summary>
        ''' ±Ò°ÊMFC ¥æ´À±±¨î
        ''' </summary>
        ''' <param name="iFlow">³]©w¬y¶q</param>
        ''' <param name="iOnTime">³]©wON®É¶¡</param>
        ''' <param name="iOffTime">³]©wOFF®É¶¡</param>
        ''' <remarks></remarks>
        Public Sub Start(ByVal iFlow As Integer, ByVal iOnTime As Integer, ByVal iOffTime As Integer)
            MFCFlow = iFlow
            MFCOnTime = iOnTime
            MFCOffTime = iOffTime
            Cond = True
            Control_State = 0
            DelayTimer.Enabled = True
        End Sub
        ''' <summary>
        ''' °±¤îMFC ¥æ´Àµ{§Ç
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub [Stop]()
            Cond = False
            DelayTimer.Enabled = False
            Control_State = 0
        End Sub
        ''' <summary>
        ''' ÄÝ©Ê, Åª¨ú MFC Åª­È
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        ReadOnly Property MFC_Reading() As Integer
            Get
                Return GetPLCReadValue(ADIndex)
            End Get
        End Property
        Public Function MFCControl() As Integer
            Select Case Control_State
                Case 0
                    If Cond Then
                        If MFCFlow > 0 Then
                            SetPLCRValue(DAIndex, MFCFlow)
                            TickCount = 1
                            TickCountEnabled = True
                            Control_State = 1
                        Else
                            Control_State = 99
                        End If
                    End If
                Case 1
                    If Cond Then
                        If TickCountEnabled = False Then
                            Set_MBit(OutputIndex, DEVICE_ON)
                            TickCount = MFCOnTime
                            TickCountEnabled = True
                            Control_State = 2
                        End If
                    Else
                        Control_State = 99
                    End If
                Case 2
                    If Cond Then
                        If TickCountEnabled = False Then
                            Set_MBit(OutputIndex, DEVICE_OFF)
                            TickCount = MFCOffTime
                            TickCountEnabled = True
                            Control_State = 1
                        End If
                    Else
                        Control_State = 99
                    End If
                Case 99
                    Set_MBit(OutputIndex, DEVICE_OFF)
                    Cond = False
                    Control_State = 0
            End Select
            Return TickCount
        End Function

    End Class
    'By chesly 20181023 À£¬û¦Û°Ê´`Àô°Ê§@ start
#Region " Bonder Auto Cycle Run"
    Public BondCycle1 As New CCycleRun(DoBondUp01Index, DoBondDown01Index, DiBondUp01Index, DiBondDown01Index, 300, 300)
    Public BondCycle2 As New CCycleRun(DoBondUp02Index, DoBondDown02Index, DiBondUp02Index, DiBondDown02Index, 300, 300)
    Public BondCycle3 As New CCycleRun(DoBondUp03Index, DoBondDown03Index, DiBondUp03Index, DiBondDown03Index, 300, 300)
    Public BondCycle4 As New CCycleRun(DoBondUp04Index, DoBondDown04Index, DiBondUp04Index, DiBondDown04Index, 300, 300)
    Public BondCycle5 As New CCycleRun(DoBondUp05Index, DoBondDown05Index, DiBondUp05Index, DiBondDown05Index, 300, 300)
    Public BondCycle6 As New CCycleRun(DoBondUp06Index, DoBondDown06Index, DiBondUp06Index, DiBondDown06Index, 300, 300)
    Public Class CCycleRun
        Private timer1 As Timer
        Public DelayTimerEndbled As Boolean
        Public DelayTimer As Integer
        Private _Out1Index As Integer
        Private _Out2Index As Integer
        Private _Input1Index As Integer
        Private _Input2Index As Integer
        Private _DelayTime1 As Integer
        Private _DelayTime2 As Integer
        Private _Pb_Index As Integer
        Public State As Integer
        Public RunCount As Integer
        Public RunCountSet As Integer = 100

        Property StartRun As Boolean

        Public Sub SetDelayTime(ByVal t1 As Integer, ByVal t2 As Integer)
            _DelayTime1 = t1
            _DelayTime2 = t2
        End Sub
        Public Sub CycleTimes(ByVal countSet As Integer)
            RunCountSet = countSet
        End Sub
        Sub New(ByVal OutIndex1 As Integer, ByVal OutIndex2 As Integer, ByVal InputIndex1 As Integer, ByVal InputIndex2 As Integer, ByVal DelayTime1 As Integer, ByVal DelayTime2 As Integer)
            timer1 = New Timer
            timer1.Interval = 100
            AddHandler timer1.Tick, AddressOf Run
            timer1.Enabled = True
            _Out1Index = OutIndex1 'UP
            _Out2Index = OutIndex2 'Down
            _Input1Index = InputIndex1 'UP
            _Input2Index = InputIndex2 'Down
            _DelayTime1 = DelayTime1
            _DelayTime2 = DelayTime2
            StartRun = False
            DelayTimerEndbled = False
            DelayTimer = 0
            State = 0
            RunCount = 0
            RunCountSet = 100
        End Sub
        ''' <summary>
        ''' Bonding Cycle Run() by Chesly 20171024
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub Run()
            Select Case State
                Case 0
                    If StartRun Then
                        DelayTimerEndbled = True '­p®É¶}©l
                        DelayTimer = 10
                        State = 1
                    End If
                Case 1 'down
                    If StartRun Then
                        If DelayTimerEndbled = False Then '­p®É¨ì
                            Output(_Out1Index).Status = False
                            Output(_Out2Index).Status = True
                            'ChuckUpPb_Status = False
                            'ChuckDnPb_Status = True
                            DelayTimerEndbled = True
                            DelayTimer = _DelayTime1
                            State = 2
                        End If
                    Else
                        State = 99
                    End If
                Case 2 'off
                    If StartRun Then
                        If DelayTimerEndbled = False Then
                            If Check_PLC_X(_Input2Index) Then
                                Output(_Out1Index).Status = False
                                Output(_Out2Index).Status = False
                                'ChuckUpPb_Status = False
                                'ChuckDnPb_Status = False
                                DelayTimerEndbled = True
                                DelayTimer = 20
                                State = 3
                            End If
                        End If
                    Else
                        State = 99
                    End If
                Case 3 'up
                    If StartRun Then
                        If DelayTimerEndbled = False Then
                            Output(_Out1Index).Status = True
                            Output(_Out2Index).Status = False
                            'ChuckUpPb_Status = True
                            'ChuckDnPb_Status = False
                            DelayTimerEndbled = True
                            DelayTimer = _DelayTime1
                            State = 4
                        End If
                    Else
                        State = 99
                    End If
                Case 4 'off
                    If StartRun Then
                        If DelayTimerEndbled = False Then
                            Output(_Out1Index).Status = False
                            Output(_Out2Index).Status = False
                            'ChuckUpPb_Status = False
                            'ChuckDnPb_Status = False
                            DelayTimerEndbled = True
                            DelayTimer = 20
                            State = 1
                            RunCount += 1
                            If RunCount > RunCountSet Then
                                RunCount = 0
                                StartRun = False
                            End If
                        End If
                    Else
                        State = 99
                    End If
                Case 99
                    DelayTimerEndbled = False
                    DelayTimer = 0
                    RunCount = 0
                    State = 0
                    StartRun = False
            End Select
            If DelayTimerEndbled Then
                DelayTimer -= 1
                If DelayTimer <= 0 Then
                    DelayTimerEndbled = False
                    DelayTimer = 0
                End If
            Else
                DelayTimer = 0
            End If
            timer1.Interval = 100
        End Sub
    End Class
#End Region
    'By chesly 20181023 À£¬û¦Û°Ê´`Àô°Ê§@ End

End Module

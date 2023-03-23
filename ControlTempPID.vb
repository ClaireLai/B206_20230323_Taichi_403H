Public Class ControlTempPID

    Private SiteNum As Integer
    Private LowTemp As Integer
    Private LowTempPower As Integer


    '設定自動調諧
    Private DoSetTopATIndex As Integer
    Private DoSetBotATIndex As Integer
    '寫入PID
    Private DoWriteTopPIDIndex As Integer
    Private DoWriteBotPIDIndex As Integer
    '寫入最大功率限制位址
    Private DATopMaxPowerIndex As Integer
    Private DATopMinPowerIndex As Integer
    Private DABotMaxPowerIndex As Integer
    Private DABotMinPowerIndex As Integer
    '設定 PID 位址
    Private DATopP1Index As Integer
    Private DATopI1Index As Integer
    Private DATopD1Index As Integer

    Private DABotP1Index As Integer
    Private DABotI1Index As Integer
    Private DABotD1Index As Integer
    '讀取 PID 位址
    Private ADTopRead_P As Integer
    Private ADTopRead_I As Integer
    Private ADTopRead_D As Integer

    Private ADBotRead_P As Integer
    Private ADBotRead_I As Integer
    Private ADBotRead_D As Integer
    '功率位址
    Private ADTopPowerIndex As Integer
    Private ADBotPowerIndex As Integer
    'PID 變數

    Private TopPL As Integer
    Private TopIL As Integer
    Private TopDL As Integer
    Private TopMaxL As Integer
    Private TopMinL As Integer

    Private TopPM As Integer
    Private TopIM As Integer
    Private TopDM As Integer
    Private TopMaxM As Integer
    Private TopMinM As Integer

    Private TopPH As Integer
    Private TopIH As Integer
    Private TopDH As Integer
    Private TopMaxH As Integer
    Private TopMinH As Integer

    Private BotPL As Integer
    Private BotIL As Integer
    Private BotDL As Integer
    Private BotMaxL As Integer
    Private BotMinL As Integer

    Private BotPM As Integer
    Private BotIM As Integer
    Private BotDM As Integer
    Private BotMaxM As Integer
    Private BotMinM As Integer

    Private BotPH As Integer
    Private BotIH As Integer
    Private BotDH As Integer
    Private BotMaxH As Integer
    Private BotMinH As Integer


    Private IniFile As String
    Private SiteName As String
    Private Section As String

    Public Event AT_Finished(ByVal bStatus As Boolean)


    Private Sub UpdatePIDFromPLC()
        'Exit Sub
        If TopArea1 Then
            txtTopPL.Text = Get_PLC_R1000(ADTopRead_P) / 10
            txtTopIL.Text = Get_PLC_R1000(ADTopRead_I)
            txtTopDL.Text = Get_PLC_R1000(ADTopRead_D)
        End If
        If TopArea2 Then
            txtTopPM.Text = Get_PLC_R1000(ADTopRead_P) / 10
            txtTopIM.Text = Get_PLC_R1000(ADTopRead_I)
            txtTopDM.Text = Get_PLC_R1000(ADTopRead_D)
        End If
        If TopArea3 Then
            txtTopPH.Text = Get_PLC_R1000(ADTopRead_P) / 10
            txtTopIH.Text = Get_PLC_R1000(ADTopRead_I)
            txtTopDH.Text = Get_PLC_R1000(ADTopRead_D)
        End If

        If BotArea1 Then
            txtBotPL.Text = Get_PLC_R1000(ADBotRead_P) / 10
            txtBotIL.Text = Get_PLC_R1000(ADBotRead_I)
            txtBotDL.Text = Get_PLC_R1000(ADBotRead_D)
        End If
        If BotArea2 Then
            txtBotPM.Text = Get_PLC_R1000(ADBotRead_P) / 10
            txtBotIM.Text = Get_PLC_R1000(ADBotRead_I)
            txtBotDM.Text = Get_PLC_R1000(ADBotRead_D)
        End If
        If BotArea3 Then
            txtBotPH.Text = Get_PLC_R1000(ADBotRead_P) / 10
            txtBotIH.Text = Get_PLC_R1000(ADBotRead_I)
            txtBotDH.Text = Get_PLC_R1000(ADBotRead_D)
        End If
        'TopArea0 = False
        'TopArea1 = False
        'TopArea2 = False
        'TopArea3 = False

        'BotArea0 = False
        'BotArea1 = False
        'BotArea2 = False
        'BotArea3 = False
        WriteParameter(IniFile)
        Flush(IniFile)
    End Sub


    Public Sub New()

        ' 此為 Windows Form 設計工具所需的呼叫。
        InitializeComponent()


        ' 在 InitializeComponent() 呼叫之後加入任何初始設定。
    End Sub
    Public Sub Initial(ByVal iSiteNum As Integer, ByVal WTopPIDIndex As Integer, ByVal WBotPIDIndex As Integer, ByVal DoTopATIndex As Integer, ByVal DoBotATIndex As Integer, _
                     ByVal iADTopPIDStartIndex As Integer, ByVal iDATopPIDStartIndex As Integer, ByVal iADBotPIDStartIndex As Integer, ByVal iDABotPIDStartIndex As Integer, _
                     ByVal iADTopPowerIndex As Integer, ByVal iADBotPowerIndex As Integer)

        SiteNum = iSiteNum

        DoWriteTopPIDIndex = WTopPIDIndex
        DoWriteBotPIDIndex = WBotPIDIndex
        DoSetTopATIndex = DoTopATIndex
        DoSetBotATIndex = DoBotATIndex

        ADTopRead_P = iADTopPIDStartIndex
        ADTopRead_I = iADTopPIDStartIndex + 1
        ADTopRead_D = iADTopPIDStartIndex + 2

        DATopP1Index = iDATopPIDStartIndex
        DATopI1Index = iDATopPIDStartIndex + 1
        DATopD1Index = iDATopPIDStartIndex + 2
        DATopMaxPowerIndex = iDATopPIDStartIndex + 3
        DATopMinPowerIndex = iDATopPIDStartIndex + 4

        ADBotRead_P = iADBotPIDStartIndex
        ADBotRead_I = iADBotPIDStartIndex + 1
        ADBotRead_D = iADBotPIDStartIndex + 2

        DABotP1Index = iDABotPIDStartIndex
        DABotI1Index = iDABotPIDStartIndex + 1
        DABotD1Index = iDABotPIDStartIndex + 2
        DABotMaxPowerIndex = iDABotPIDStartIndex + 3
        DABotMinPowerIndex = iDABotPIDStartIndex + 4

        ADTopPowerIndex = iADTopPowerIndex
        ADBotPowerIndex = iADBotPowerIndex

        AddHandler AT_Finished, AddressOf UpdatePIDFromPLC
        Title = "Plate#" + Format(SiteNum + 1, "00")

        IniFile = ParameterINIFile
        Section = "PID_SETUP"
        SiteName = "SITE"
        ReadParameter(IniFile)
        'WriteParameter(IniFile)
        'TopArea1 = False
        'TopArea2 = False
        'TopArea3 = False
        Timer1.Interval = 300
        Timer1.Enabled = True
    End Sub

    Property Title() As String
        Get
            Return grpTitle.Text
        End Get
        Set(ByVal value As String)
            grpTitle.Text = value
        End Set
    End Property

    ReadOnly Property GetTopCurrentPower() As Integer
        Get
            Return Get_PLC_R1000(ADTopPowerIndex)
        End Get
    End Property
    ReadOnly Property GetBotCurrentPower() As Integer
        Get
            Return Get_PLC_R1000(ADBotPowerIndex)
        End Get
    End Property



    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If CommLivePLC Then
            Run()
        End If

    End Sub

    Private Sub SetColor(ByVal Cond As Boolean, ByVal obj As Object)
        If Cond Then
            obj.BackColor = Color.Lime
        Else
            obj.BackColor = System.Drawing.SystemColors.Control
        End If
    End Sub
    Private Sub SetColor(ByVal Cond As Boolean, ByVal obj As Object, ByVal OnColor As Color, ByVal OffColor As Color)
        If Cond Then
            obj.BackColor = OnColor
        Else
            obj.BackColor = OffColor
        End If
    End Sub

    Public Sub Run()


        btnTopAT.Visible = CelloUsbFlag
        btnBotAT.Visible = CelloUsbFlag

        lblTopTemp.Text = TopTempPVStr(SiteNum)
        lblBotTemp.Text = BotTempPVStr(SiteNum)

        lblTopCurrentPower.Text = (Get_PLC_R1000(ADTopPowerIndex) / 10).ToString
        lblBotCurrentPower.Text = (Get_PLC_R1000(ADBotPowerIndex) / 10).ToString

        lblTopTempP.Text = (Get_PLC_R1000(ADTopRead_P) / 10).ToString
        lblTopTempI.Text = Get_PLC_R1000(ADTopRead_I).ToString
        lblTopTempD.Text = Get_PLC_R1000(ADTopRead_D).ToString

        lblBotTempP.Text = (Get_PLC_R1000(ADBotRead_P) / 10).ToString
        lblBotTempI.Text = Get_PLC_R1000(ADBotRead_I).ToString
        lblBotTempD.Text = Get_PLC_R1000(ADBotRead_D).ToString

        ObjShow.Show(Check_PLC_M(DoSetTopATIndex), btnTopAT, Color.Lime, System.Drawing.SystemColors.Control)
        ObjShow.Show(Check_PLC_M(DoSetBotATIndex), btnBotAT, Color.Lime, System.Drawing.SystemColors.Control)

        ObjShow.Show(Check_PLC_M(DoWriteTopPIDIndex), btnTopPIDSave, Color.Lime, System.Drawing.SystemColors.Control)
        ObjShow.Show(Check_PLC_M(DoWriteBotPIDIndex), btnBotPIDSave, Color.Lime, System.Drawing.SystemColors.Control)

        SetColor(ManualControl(SiteNum).TempOn, btnTopHeater, Color.Lime, System.Drawing.SystemColors.Control)
        SetColor(ManualControl(SiteNum).TempOn, btnBotHeater, Color.Lime, System.Drawing.SystemColors.Control)

        SetColor(TopArea1, txtTopPL, Color.Pink, Color.White)
        SetColor(TopArea1, txtTopPL, Color.Pink, Color.White)
        SetColor(TopArea1, txtTopIL, Color.Pink, Color.White)
        SetColor(TopArea1, txtTopDL, Color.Pink, Color.White)
        SetColor(TopArea1, txtTopMaxL, Color.Pink, Color.White)
        SetColor(TopArea1, txtTopMinL, Color.Pink, Color.White)

        SetColor(TopArea2, txtTopPM, Color.Pink, Color.White)
        SetColor(TopArea2, txtTopIM, Color.Pink, Color.White)
        SetColor(TopArea2, txtTopDM, Color.Pink, Color.White)
        SetColor(TopArea2, txtTopMaxM, Color.Pink, Color.White)
        SetColor(TopArea2, txtTopMinM, Color.Pink, Color.White)

        SetColor(TopArea3, txtTopPH, Color.Pink, Color.White)
        SetColor(TopArea3, txtTopIH, Color.Pink, Color.White)
        SetColor(TopArea3, txtTopDH, Color.Pink, Color.White)
        SetColor(TopArea3, txtTopMaxH, Color.Pink, Color.White)
        SetColor(TopArea3, txtTopMinH, Color.Pink, Color.White)

        SetColor(BotArea1, txtBotPL, Color.Pink, Color.White)
        SetColor(BotArea1, txtBotIL, Color.Pink, Color.White)
        SetColor(BotArea1, txtBotDL, Color.Pink, Color.White)
        SetColor(BotArea1, txtBotMaxL, Color.Pink, Color.White)
        SetColor(BotArea1, txtBotMinL, Color.Pink, Color.White)

        SetColor(BotArea2, txtBotPM, Color.Pink, Color.White)
        SetColor(BotArea2, txtBotIM, Color.Pink, Color.White)
        SetColor(BotArea2, txtBotDM, Color.Pink, Color.White)
        SetColor(BotArea2, txtBotMaxM, Color.Pink, Color.White)
        SetColor(BotArea2, txtBotMinM, Color.Pink, Color.White)

        SetColor(BotArea3, txtBotPH, Color.Pink, Color.White)
        SetColor(BotArea3, txtBotIH, Color.Pink, Color.White)
        SetColor(BotArea3, txtBotDH, Color.Pink, Color.White)
        SetColor(BotArea3, txtBotMaxH, Color.Pink, Color.White)
        SetColor(BotArea3, txtBotMinH, Color.Pink, Color.White)
        'SetColor(Check_PLC_M(DoSetBotATIndex), btnBotAT)
        'SetColor(Check_PLC_M(DoWriteTopPIDIndex), btnTopPIDSave)
        'SetColor(Check_PLC_M(DoWriteBotPIDIndex), btnBotPIDSave)

        If Output(DoSetTopATIndex).Status And UpdatePID = False Then
            UpdatePID = True
        End If
        If Output(DoSetTopATIndex).Status = False And UpdatePID = True Then
            RaiseEvent AT_Finished(True)
            UpdatePID = False
        End If

        lblTopCurrentPower.Visible = CelloUsbFlag
        lblBotCurrentPower.Visible = CelloUsbFlag
    End Sub

    Public Sub WriteParameter(ByVal sfile As String)
        FormTextBoxSave.FindTextBox(Me, Me.Name, FormSaveINIFile)
        WriteProgData(Section, SiteName + Format(SiteNum, "00") + "_TOPPL", txtTopPL.Text, sfile)
        WriteProgData(Section, SiteName + Format(SiteNum, "00") + "_TOPIL", txtTopIL.Text, sfile)
        WriteProgData(Section, SiteName + Format(SiteNum, "00") + "_TOPDL", txtTopDL.Text, sfile)
        WriteProgData(Section, SiteName + Format(SiteNum, "00") + "_TOPMAXL", txtTopMaxL.Text, sfile)
        WriteProgData(Section, SiteName + Format(SiteNum, "00") + "_TOPMINL", txtTopMinL.Text, sfile)

        WriteProgData(Section, SiteName + Format(SiteNum, "00") + "_TOPPM", txtTopPM.Text, sfile)
        WriteProgData(Section, SiteName + Format(SiteNum, "00") + "_TOPIM", txtTopIM.Text, sfile)
        WriteProgData(Section, SiteName + Format(SiteNum, "00") + "_TOPDM", txtTopDM.Text, sfile)
        WriteProgData(Section, SiteName + Format(SiteNum, "00") + "_TOPMAXM", txtTopMaxM.Text, sfile)
        WriteProgData(Section, SiteName + Format(SiteNum, "00") + "_TOPMINM", txtTopMinM.Text, sfile)

        WriteProgData(Section, SiteName + Format(SiteNum, "00") + "_TOPPH", txtTopPH.Text, sfile)
        WriteProgData(Section, SiteName + Format(SiteNum, "00") + "_TOPIH", txtTopIH.Text, sfile)
        WriteProgData(Section, SiteName + Format(SiteNum, "00") + "_TOPDH", txtTopDH.Text, sfile)
        WriteProgData(Section, SiteName + Format(SiteNum, "00") + "_TOPMAXH", txtTopMaxH.Text, sfile)
        WriteProgData(Section, SiteName + Format(SiteNum, "00") + "_TOPMINH", txtTopMinH.Text, sfile)

        WriteProgData(Section, SiteName + Format(SiteNum, "00") + "_TOPLOWRANGE", txtTopLowRange.Text, sfile)
        WriteProgData(Section, SiteName + Format(SiteNum, "00") + "_TOPHIGHRANGE", txtTopHighRange.Text, sfile)

        WriteProgData(Section, SiteName + Format(SiteNum, "00") + "_TOPLOWLIMIT", txtTopLowLimitTemp.Text, sfile)
        WriteProgData(Section, SiteName + Format(SiteNum, "00") + "_TOPLOWLIMITPOWER", txtTopLowLimitPower.Text, sfile)

        '------------------------------------
        WriteProgData(Section, SiteName + Format(SiteNum, "00") + "_BOTPL", txtBotPL.Text, sfile)
        WriteProgData(Section, SiteName + Format(SiteNum, "00") + "_BOTIL", txtBotIL.Text, sfile)
        WriteProgData(Section, SiteName + Format(SiteNum, "00") + "_BOTDL", txtBotDL.Text, sfile)
        WriteProgData(Section, SiteName + Format(SiteNum, "00") + "_BOTMAXL", txtBotMaxL.Text, sfile)
        WriteProgData(Section, SiteName + Format(SiteNum, "00") + "_BOTMINL", txtBotMinL.Text, sfile)

        WriteProgData(Section, SiteName + Format(SiteNum, "00") + "_BOTPM", txtBotPM.Text, sfile)
        WriteProgData(Section, SiteName + Format(SiteNum, "00") + "_BOTIM", txtBotIM.Text, sfile)
        WriteProgData(Section, SiteName + Format(SiteNum, "00") + "_BOTDM", txtBotDM.Text, sfile)
        WriteProgData(Section, SiteName + Format(SiteNum, "00") + "_BOTMAXM", txtBotMaxM.Text, sfile)
        WriteProgData(Section, SiteName + Format(SiteNum, "00") + "_BOTMINM", txtBotMinM.Text, sfile)

        WriteProgData(Section, SiteName + Format(SiteNum, "00") + "_BOTPH", txtBotPH.Text, sfile)
        WriteProgData(Section, SiteName + Format(SiteNum, "00") + "_BOTIH", txtBotIH.Text, sfile)
        WriteProgData(Section, SiteName + Format(SiteNum, "00") + "_BOTDH", txtBotDH.Text, sfile)
        WriteProgData(Section, SiteName + Format(SiteNum, "00") + "_BOTMAXH", txtBotMaxH.Text, sfile)
        WriteProgData(Section, SiteName + Format(SiteNum, "00") + "_BOTMINH", txtBotMinH.Text, sfile)

        WriteProgData(Section, SiteName + Format(SiteNum, "00") + "_BOTLOWRANGE", txtBotLowRange.Text, sfile)
        WriteProgData(Section, SiteName + Format(SiteNum, "00") + "_BOTHIGHRANGE", txtBotHighRange.Text, sfile)

        WriteProgData(Section, SiteName + Format(SiteNum, "00") + "_BOTLOWLIMIT", txtBotLowLimitTemp.Text, sfile)
        WriteProgData(Section, SiteName + Format(SiteNum, "00") + "_BOTLOWLIMITPOWER", txtBotLowLimitPower.Text, sfile)

    End Sub
    Public Sub ReadParameter(ByVal sfile As String)
        txtTopPL.Text = ReadProgData(Section, SiteName + Format(SiteNum, "00") + "_TOPPL", "30", sfile)
        txtTopIL.Text = ReadProgData(Section, SiteName + Format(SiteNum, "00") + "_TOPIL", "120", sfile)
        txtTopDL.Text = ReadProgData(Section, SiteName + Format(SiteNum, "00") + "_TOPDL", "30", sfile)
        txtTopMaxL.Text = ReadProgData(Section, SiteName + Format(SiteNum, "00") + "_TOPMAXL", "80", sfile)
        txtTopMinL.Text = ReadProgData(Section, SiteName + Format(SiteNum, "00") + "_TOPMINL", "0", sfile)


        txtTopPM.Text = ReadProgData(Section, SiteName + Format(SiteNum, "00") + "_TOPPM", "30", sfile)
        txtTopIM.Text = ReadProgData(Section, SiteName + Format(SiteNum, "00") + "_TOPIM", "120", sfile)
        txtTopDM.Text = ReadProgData(Section, SiteName + Format(SiteNum, "00") + "_TOPDM", "30", sfile)
        txtTopMaxM.Text = ReadProgData(Section, SiteName + Format(SiteNum, "00") + "_TOPMAXM", "80", sfile)
        txtTopMinM.Text = ReadProgData(Section, SiteName + Format(SiteNum, "00") + "_TOPMINM", "0", sfile)

        txtTopPH.Text = ReadProgData(Section, SiteName + Format(SiteNum, "00") + "_TOPPH", "30", sfile)
        txtTopIH.Text = ReadProgData(Section, SiteName + Format(SiteNum, "00") + "_TOPIH", "120", sfile)
        txtTopDH.Text = ReadProgData(Section, SiteName + Format(SiteNum, "00") + "_TOPDH", "30", sfile)
        txtTopMaxH.Text = ReadProgData(Section, SiteName + Format(SiteNum, "00") + "_TOPMAXH", "80", sfile)
        txtTopMinH.Text = ReadProgData(Section, SiteName + Format(SiteNum, "00") + "_TOPMINH", "0", sfile)


        txtTopLowRange.Text = ReadProgData(Section, SiteName + Format(SiteNum, "00") + "_TOPLOWRANGE", "200", sfile)
        txtTopHighRange.Text = ReadProgData(Section, SiteName + Format(SiteNum, "00") + "_TOPHIGHRANGE", "400", sfile)

        txtTopLowLimitTemp.Text = ReadProgData(Section, SiteName + Format(SiteNum, "00") + "_TOPLOWLIMIT", "60", sfile)
        txtTopLowLimitPower.Text = ReadProgData(Section, SiteName + Format(SiteNum, "00") + "_TOPLOWLIMITPOWER", "15", sfile)


        '------------------------------------
        txtBotPL.Text = ReadProgData(Section, SiteName + Format(SiteNum, "00") + "_BOTPL", "30", sfile)
        txtBotIL.Text = ReadProgData(Section, SiteName + Format(SiteNum, "00") + "_BOTIL", "120", sfile)
        txtBotDL.Text = ReadProgData(Section, SiteName + Format(SiteNum, "00") + "_BOTDL", "30", sfile)
        txtBotMaxL.Text = ReadProgData(Section, SiteName + Format(SiteNum, "00") + "_BOTMAXL", "80", sfile)
        txtBotMinL.Text = ReadProgData(Section, SiteName + Format(SiteNum, "00") + "_BOTMINL", "0", sfile)


        txtBotPM.Text = ReadProgData(Section, SiteName + Format(SiteNum, "00") + "_BOTPM", "30", sfile)
        txtBotIM.Text = ReadProgData(Section, SiteName + Format(SiteNum, "00") + "_BOTIM", "120", sfile)
        txtBotDM.Text = ReadProgData(Section, SiteName + Format(SiteNum, "00") + "_BOTDM", "30", sfile)
        txtBotMaxM.Text = ReadProgData(Section, SiteName + Format(SiteNum, "00") + "_BOTMAXM", "80", sfile)
        txtBotMinM.Text = ReadProgData(Section, SiteName + Format(SiteNum, "00") + "_BOTMINM", "0", sfile)

        txtBotPH.Text = ReadProgData(Section, SiteName + Format(SiteNum, "00") + "_BOTPH", "30", sfile)
        txtBotIH.Text = ReadProgData(Section, SiteName + Format(SiteNum, "00") + "_BOTIH", "120", sfile)
        txtBotDH.Text = ReadProgData(Section, SiteName + Format(SiteNum, "00") + "_BOTDH", "30", sfile)
        txtBotMaxH.Text = ReadProgData(Section, SiteName + Format(SiteNum, "00") + "_BOTMAXH", "80", sfile)
        txtBotMinH.Text = ReadProgData(Section, SiteName + Format(SiteNum, "00") + "_BOTMINH", "0", sfile)


        txtBotLowRange.Text = ReadProgData(Section, SiteName + Format(SiteNum, "00") + "_BOTLOWRANGE", "200", sfile)
        txtBotHighRange.Text = ReadProgData(Section, SiteName + Format(SiteNum, "00") + "_BOTHIGHRANGE", "400", sfile)
        txtTopLowLimitTemp.Text = ReadProgData(Section, SiteName + Format(SiteNum, "00") + "_BOTLOWLIMIT", "60", sfile)
        txtTopLowLimitPower.Text = ReadProgData(Section, SiteName + Format(SiteNum, "00") + "_BOTLOWLIMITPOWER", "15", sfile)

        TopPL = Val(txtTopPL.Text) * 10
        TopIL = Val(txtTopIL.Text)
        TopDL = Val(txtTopDL.Text)
        TopMaxL = Val(txtTopMaxL.Text) * 10
        TopMinL = Val(txtTopMinL.Text) * 10

        TopPM = Val(txtTopPM.Text) * 10
        TopIM = Val(txtTopIM.Text)
        TopDM = Val(txtTopDM.Text)
        TopMaxM = Val(txtTopMaxM.Text) * 10
        TopMinM = Val(txtTopMinM.Text) * 10

        TopPH = Val(txtTopPH.Text) * 10
        TopIH = Val(txtTopIH.Text)
        TopDH = Val(txtTopDH.Text)
        TopMaxH = Val(txtTopMaxH.Text) * 10
        TopMinH = Val(txtTopMinH.Text) * 10

        BotPL = Val(txtBotPL.Text) * 10
        BotIL = Val(txtBotIL.Text)
        BotDL = Val(txtBotDL.Text)
        BotMaxL = Val(txtBotMaxL.Text) * 10
        BotMinL = Val(txtBotMinL.Text) * 10

        BotPM = Val(txtBotPM.Text) * 10
        BotIM = Val(txtBotIM.Text)
        BotDM = Val(txtBotDM.Text)
        BotMaxM = Val(txtBotMaxM.Text) * 10
        BotMinM = Val(txtBotMinM.Text) * 10

        BotPH = Val(txtBotPH.Text) * 10
        BotIH = Val(txtBotIH.Text)
        BotDH = Val(txtBotDH.Text)
        BotMaxH = Val(txtBotMaxH.Text) * 10
        BotMinH = Val(txtBotMinH.Text) * 10

    End Sub

    '根據目前溫度寫入PID
    '目前溫度範圍(共3個,分上下.)
    Private TempArea, TopArea0, TopArea1, TopArea2, TopArea3 As Boolean
    Private BotArea0, BotArea1, BotArea2, BotArea3 As Boolean
    Private WriteP, WriteI, WriteD, WriteMax, WriteMin As Integer

    Private TopLowTemp, TopLowPower As Integer
    Private BotLowTemp, BotLowPower As Integer

    Private TopRangeLow, TopRangeHigh As Integer
    Private BotRangeLow, BotRangeHigh As Integer

    Private UpdatePID As Boolean
    '根據目前溫度寫入PID


    '-------------------------石英燈PID/Max/Min Power後比對PLC值是否有改變 by Chesly 20181029--------------start
    Public Sub AutoPIDTop(ByVal itopSV As Integer, ByVal iBotSV As Integer, ByVal TempArea As Boolean)
        TopArea0 = TempArea
        TopArea1 = TempArea
        TopArea2 = TempArea
        TopArea3 = TempArea
        BotArea0 = TempArea
        BotArea1 = TempArea
        BotArea2 = TempArea
        BotArea3 = TempArea
        TopLowTemp = Val(txtTopLowLimitTemp.Text)
        BotLowTemp = Val(txtBotLowLimitTemp.Text)

        TopRangeLow = Val(txtTopLowRange.Text)
        TopRangeHigh = Val(txtTopHighRange.Text)

        BotRangeLow = Val(txtBotLowRange.Text)
        BotRangeHigh = Val(txtBotHighRange.Text)





        '上壓頭
        'If (itopSV >= 0) And (itopSV <= TopLowTemp) And TopArea0 = False Then
        '    Write_PLC_R1100(DATopMax1Index, Val(txtTopLowLimitPower.Text) * 10)
        '    TopArea0 = True
        '    TopArea1 = False
        '    TopArea2 = False
        '    TopArea3 = False
        'End If

        '上壓頭
        'If (itopSV >= TopLowTemp) And (itopSV < TopRangeLow) And TopArea1 = False Then
        '    If Output(DoSetTopATIndex).Status = False Then
        '        Write_PLC_R1100(DATopP1Index, Val(txtTopPL.Text) * 10)
        '        Write_PLC_R1100(DATopI1Index, Val(txtTopIL.Text))
        '        Write_PLC_R1100(DATopD1Index, Val(txtTopDL.Text))
        '        Write_PLC_R1100(DATopMaxPowerIndex, Val(txtTopMaxL.Text) * 10)
        '        Write_PLC_R1100(DATopMinPowerIndex, Val(txtTopMinL.Text) * 10)
        '        Output(DoWriteTopPIDIndex).Status = True
        '    End If
        '    If GetPLCRValue(DATopMaxPowerIndex) = Val((txtTopMaxL.Text) * 10) And GetPLCRValue(DATopMinPowerIndex) = Val((txtTopMinL.Text) * 10) Then
        '        '新增變更石英燈Max/Min Power後比對PLC值是否有改變 by Chesly 20170906
        '        TopArea0 = False
        '        TopArea1 = True
        '        TopArea2 = False
        '        TopArea3 = False
        '    End If

        'End If
        'If (itopSV >= TopRangeLow) And (itopSV < TopRangeHigh) And TopArea2 = False Then
        '    If Output(DoSetTopATIndex).Status = False Then
        '        Write_PLC_R1100(DATopP1Index, Val(txtTopPM.Text) * 10)
        '        Write_PLC_R1100(DATopI1Index, Val(txtTopIM.Text))
        '        Write_PLC_R1100(DATopD1Index, Val(txtTopDM.Text))
        '        Write_PLC_R1100(DATopMaxPowerIndex, Val(txtTopMaxM.Text) * 10)
        '        Write_PLC_R1100(DATopMinPowerIndex, Val(txtTopMinM.Text) * 10)
        '        Output(DoWriteTopPIDIndex).Status = True
        '    End If
        '    If GetPLCRValue(DATopMaxPowerIndex) = Val((txtTopMaxM.Text) * 10) And GetPLCRValue(DATopMinPowerIndex) = Val((txtTopMinM.Text) * 10) Then
        '        '新增變更石英燈Max/Min Power後比對PLC值是否有改變 by Chesly 20170906
        '        TopArea0 = False
        '        TopArea1 = False
        '        TopArea2 = True
        '        TopArea3 = False
        '    End If
        'End If

        'If itopSV >= TopRangeHigh And TopArea3 = False Then
        '    If Output(DoSetTopATIndex).Status = False Then
        '        Write_PLC_R1100(DATopP1Index, Val(txtTopPH.Text) * 10)
        '        Write_PLC_R1100(DATopI1Index, Val(txtTopIH.Text))
        '        Write_PLC_R1100(DATopD1Index, Val(txtTopDH.Text))
        '        Write_PLC_R1100(DATopMaxPowerIndex, Val(txtTopMaxH.Text) * 10)
        '        Write_PLC_R1100(DATopMinPowerIndex, Val(txtTopMinH.Text) * 10)
        '        Output(DoWriteTopPIDIndex).Status = True
        '    End If
        '    If GetPLCRValue(DATopMaxPowerIndex) = Val((txtTopMaxH.Text) * 10) And GetPLCRValue(DATopMinPowerIndex) = Val((txtTopMinH.Text) * 10) Then
        '        '新增變更石英燈Max/Min Power後比對PLC值是否有改變 by Chesly 20170906
        '        TopArea0 = False
        '        TopArea1 = False
        '        TopArea2 = False
        '        TopArea3 = True
        '    End If
        'End If


        ''下壓頭

        ''If (iBotSV >= 0) And (iBotSV <= BotLowTemp) And BotArea0 = False Then
        ''    Write_PLC_R1100(DABotMax1Index, Val(txtBotLowLimitPower.Text) * 10)
        ''    BotArea0 = True
        ''    BotArea1 = False
        ''    BotArea2 = False
        ''    BotArea3 = False
        ''End If
        'If (iBotSV >= BotLowTemp) And (iBotSV < BotRangeLow) And BotArea1 = False Then
        '    If Output(DoSetTopATIndex).Status = False Then
        '        Write_PLC_R1100(DABotP1Index, Val(txtBotPL.Text) * 10)
        '        Write_PLC_R1100(DABotI1Index, Val(txtBotIL.Text))
        '        Write_PLC_R1100(DABotD1Index, Val(txtBotDL.Text))
        '        Write_PLC_R1100(DABotMaxPowerIndex, Val(txtBotMaxL.Text) * 10)
        '        Write_PLC_R1100(DABotMinPowerIndex, Val(txtBotMinL.Text) * 10)
        '        Output(DoWriteBotPIDIndex).Status = True
        '    End If
        '    If GetPLCRValue(DABotMaxPowerIndex) = Val((txtBotMaxL.Text) * 10) And GetPLCRValue(DABotMinPowerIndex) = Val((txtBotMinL.Text) * 10) Then
        '        '新增變更石英燈Max/Min Power後比對PLC值是否有改變 by Chesly 20170906
        '        BotArea1 = True
        '        BotArea2 = False
        '        BotArea3 = False
        '    End If
        'End If

        'If (iBotSV >= BotRangeLow) And (iBotSV < BotRangeHigh) And BotArea2 = False Then
        '    If Output(DoSetTopATIndex).Status = False Then
        '        Write_PLC_R1100(DABotP1Index, Val(txtBotPM.Text) * 10)
        '        Write_PLC_R1100(DABotI1Index, Val(txtBotIM.Text))
        '        Write_PLC_R1100(DABotD1Index, Val(txtBotDM.Text))
        '        Write_PLC_R1100(DABotMaxPowerIndex, Val(txtBotMaxM.Text) * 10)
        '        Write_PLC_R1100(DABotMinPowerIndex, Val(txtBotMinM.Text) * 10)
        '        Output(DoWriteBotPIDIndex).Status = True
        '    End If
        '    If GetPLCRValue(DABotMaxPowerIndex) = Val((txtBotMaxM.Text) * 10) And GetPLCRValue(DABotMinPowerIndex) = Val((txtBotMinM.Text) * 10) Then
        '        '新增變更石英燈Max/Min Power後比對PLC值是否有改變 by Chesly 20170906
        '        BotArea1 = False
        '        BotArea2 = True
        '        BotArea3 = False
        '    End If
        'End If

        'If iBotSV >= BotRangeHigh And BotArea3 = False Then
        '    If Output(DoSetTopATIndex).Status = False Then
        '        Write_PLC_R1100(DABotP1Index, Val(txtBotPH.Text) * 10)
        '        Write_PLC_R1100(DABotI1Index, Val(txtBotIH.Text))
        '        Write_PLC_R1100(DABotD1Index, Val(txtBotDH.Text))
        '        Write_PLC_R1100(DABotMaxPowerIndex, Val(txtBotMaxH.Text) * 10)
        '        Write_PLC_R1100(DABotMinPowerIndex, Val(txtBotMinH.Text) * 10)
        '        Output(DoWriteBotPIDIndex).Status = True
        '    End If
        '    If GetPLCRValue(DABotMaxPowerIndex) = Val((txtBotMaxH.Text) * 10) And GetPLCRValue(DABotMinPowerIndex) = Val((txtBotMinH.Text) * 10) Then
        '        '新增變更石英燈Max/Min Power後比對PLC值是否有改變 by Chesly 20170906
        '        BotArea1 = False
        '        BotArea2 = False
        '        BotArea3 = True
        '    End If
        'End If
        If (itopSV >= TopLowTemp) And (itopSV < TopRangeLow) And TopArea1 = False Then
            If GetPLCRValue(DATopMaxPowerIndex) = Val(txtTopMaxL.Text) * 10 And GetPLCRValue(DATopMinPowerIndex) = Val((txtTopMinL.Text) * 10) _
                And GetPLCRValue(DATopP1Index) = Val(txtTopPL.Text) * 10 And GetPLCRValue(DATopI1Index) = Val(txtTopIL.Text) And GetPLCRValue(DATopD1Index) = Val(txtTopDL.Text) Then
                TopArea0 = False
                TopArea1 = True
                TopArea2 = False
                TopArea3 = False
            End If
            If TopArea1 = False Then
                If Output(DoSetTopATIndex).Status = False Then
                    Write_PLC_R1100(DATopP1Index, Val(txtTopPL.Text) * 10)
                    Write_PLC_R1100(DATopI1Index, Val(txtTopIL.Text))
                    Write_PLC_R1100(DATopD1Index, Val(txtTopDL.Text))
                    Write_PLC_R1100(DATopMaxPowerIndex, Val(txtTopMaxL.Text) * 10)
                    Write_PLC_R1100(DATopMinPowerIndex, Val(txtTopMinL.Text) * 10)
                    Output(DoWriteTopPIDIndex).Status = True
                End If
            End If
        End If
        If (itopSV >= TopRangeLow) And (itopSV < TopRangeHigh) And TopArea2 = False Then
            If GetPLCRValue(DATopMaxPowerIndex) = Val((txtTopMaxM.Text) * 10) And GetPLCRValue(DATopMinPowerIndex) = Val((txtTopMinM.Text) * 10) _
                And GetPLCRValue(DATopP1Index) = Val(txtTopPM.Text) * 10 And GetPLCRValue(DATopI1Index) = Val(txtTopIM.Text) And GetPLCRValue(DATopD1Index) = Val(txtTopDM.Text) Then
                TopArea0 = False
                TopArea1 = False
                TopArea2 = True
                TopArea3 = False
            End If
            If TopArea2 = False Then
                If Output(DoSetTopATIndex).Status = False Then
                    Write_PLC_R1100(DATopP1Index, Val(txtTopPM.Text) * 10)
                    Write_PLC_R1100(DATopI1Index, Val(txtTopIM.Text))
                    Write_PLC_R1100(DATopD1Index, Val(txtTopDM.Text))
                    Write_PLC_R1100(DATopMaxPowerIndex, Val(txtTopMaxM.Text) * 10)
                    Write_PLC_R1100(DATopMinPowerIndex, Val(txtTopMinM.Text) * 10)
                    Output(DoWriteTopPIDIndex).Status = True
                End If
            End If
        End If

        If itopSV >= TopRangeHigh And TopArea3 = False Then
            If GetPLCRValue(DATopMaxPowerIndex) = Val((txtTopMaxH.Text) * 10) And GetPLCRValue(DATopMinPowerIndex) = Val((txtTopMinH.Text) * 10) _
                And GetPLCRValue(DATopP1Index) = Val(txtTopPH.Text) * 10 And GetPLCRValue(DATopI1Index) = Val(txtTopIH.Text) And GetPLCRValue(DATopD1Index) = Val(txtTopDH.Text) Then
                TopArea0 = False
                TopArea1 = False
                TopArea2 = False
                TopArea3 = True
            End If
            If TopArea3 = False Then
                If Output(DoSetTopATIndex).Status = False Then
                    Write_PLC_R1100(DATopP1Index, Val(txtTopPH.Text) * 10)
                    Write_PLC_R1100(DATopI1Index, Val(txtTopIH.Text))
                    Write_PLC_R1100(DATopD1Index, Val(txtTopDH.Text))
                    Write_PLC_R1100(DATopMaxPowerIndex, Val(txtTopMaxH.Text) * 10)
                    Write_PLC_R1100(DATopMinPowerIndex, Val(txtTopMinH.Text) * 10)
                    Output(DoWriteTopPIDIndex).Status = True
                End If
            End If
        End If

        If (iBotSV >= BotLowTemp) And (iBotSV < BotRangeLow) And BotArea1 = False Then
            If GetPLCRValue(DABotMaxPowerIndex) = Val((txtBotMaxL.Text) * 10) And GetPLCRValue(DABotMinPowerIndex) = Val((txtBotMinL.Text) * 10) _
                And GetPLCRValue(DABotP1Index) = Val(txtBotPL.Text) * 10 And GetPLCRValue(DABotI1Index) = Val(txtBotIL.Text) And GetPLCRValue(DABotD1Index) = Val(txtBotDL.Text) Then
                BotArea1 = True
                BotArea2 = False
                BotArea3 = False
            End If
            If BotArea1 = False Then
                If Output(DoSetTopATIndex).Status = False Then
                    Write_PLC_R1100(DABotP1Index, Val(txtBotPL.Text) * 10)
                    Write_PLC_R1100(DABotI1Index, Val(txtBotIL.Text))
                    Write_PLC_R1100(DABotD1Index, Val(txtBotDL.Text))
                    Write_PLC_R1100(DABotMaxPowerIndex, Val(txtBotMaxL.Text) * 10)
                    Write_PLC_R1100(DABotMinPowerIndex, Val(txtBotMinL.Text) * 10)
                    Output(DoWriteBotPIDIndex).Status = True
                End If
            End If
        End If

        If (iBotSV >= BotRangeLow) And (iBotSV < BotRangeHigh) And BotArea2 = False Then
            If GetPLCRValue(DABotMaxPowerIndex) = Val((txtBotMaxM.Text) * 10) And GetPLCRValue(DABotMinPowerIndex) = Val((txtBotMinM.Text) * 10) _
               And GetPLCRValue(DABotP1Index) = Val(txtBotPM.Text) * 10 And GetPLCRValue(DABotI1Index) = Val(txtBotIM.Text) And GetPLCRValue(DABotD1Index) = Val(txtBotDM.Text) Then
                BotArea1 = False
                BotArea2 = True
                BotArea3 = False
            End If
            If BotArea2 = False Then
                If Output(DoSetTopATIndex).Status = False Then
                    Write_PLC_R1100(DABotP1Index, Val(txtBotPM.Text) * 10)
                    Write_PLC_R1100(DABotI1Index, Val(txtBotIM.Text))
                    Write_PLC_R1100(DABotD1Index, Val(txtBotDM.Text))
                    Write_PLC_R1100(DABotMaxPowerIndex, Val(txtBotMaxM.Text) * 10)
                    Write_PLC_R1100(DABotMinPowerIndex, Val(txtBotMinM.Text) * 10)
                    Output(DoWriteBotPIDIndex).Status = True
                End If
            End If
        End If

        If iBotSV >= BotRangeHigh And BotArea3 = False Then
            If GetPLCRValue(DABotMaxPowerIndex) = Val((txtBotMaxH.Text) * 10) And GetPLCRValue(DABotMinPowerIndex) = Val((txtBotMinH.Text) * 10) _
                And GetPLCRValue(DABotP1Index) = Val(txtBotPH.Text) * 10 And GetPLCRValue(DABotI1Index) = Val(txtBotIH.Text) And GetPLCRValue(DABotD1Index) = Val(txtBotDH.Text) Then
                BotArea1 = False
                BotArea2 = False
                BotArea3 = True
            End If
            If BotArea3 = False Then
                If Output(DoSetTopATIndex).Status = False Then
                    Write_PLC_R1100(DABotP1Index, Val(txtBotPH.Text) * 10)
                    Write_PLC_R1100(DABotI1Index, Val(txtBotIH.Text))
                    Write_PLC_R1100(DABotD1Index, Val(txtBotDH.Text))
                    Write_PLC_R1100(DABotMaxPowerIndex, Val(txtBotMaxH.Text) * 10)
                    Write_PLC_R1100(DABotMinPowerIndex, Val(txtBotMinH.Text) * 10)
                    Output(DoWriteBotPIDIndex).Status = True
                End If
            End If
        End If
    End Sub
    '-------------------------石英燈PID/Max/Min Power後比對PLC值是否有改變 by Chesly 20181029--------------start
#Region "溫控器參數"

    ' 自動調諧寫入
    Private Sub btnTopAT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTopAT.Click
        Output(DoSetTopATIndex).Status = Not Output(DoSetTopATIndex).Status
    End Sub
    Private Sub btnBotAT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBotAT.Click
        Output(DoSetBotATIndex).Status = Not Output(DoSetBotATIndex).Status
    End Sub
    'PID值寫入
    Private Sub btnTopPIDSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTopPIDSave.Click
        'Output(DoWriteTopPIDIndex).Status = Not Output(DoWriteTopPIDIndex).Status
        'If Output(DoWriteTopPIDIndex).Status Then
        '    Output(DoWriteTopPIDIndex).Status = False
        'Else
        '    Output(DoWriteTopPIDIndex).Status = True
        '    TopArea0 = False
        '    TopArea1 = False
        '    TopArea2 = False
        '    TopArea3 = False
        '    WriteParameter(IniFile)
        'End If
        PIDTopSave()
    End Sub
    Private Sub btnBotPIDSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBotPIDSave.Click
        'Output(DoWriteBotPIDIndex).Status = Not Output(DoWriteBotPIDIndex).Status
        PIDBotSave()

    End Sub
    Public Sub PIDBotSave()
        If Output(DoWriteBotPIDIndex).Status Then
            Output(DoWriteBotPIDIndex).Status = False
        Else
            Output(DoWriteBotPIDIndex).Status = True
            BotArea0 = False
            BotArea1 = False
            BotArea2 = False
            BotArea3 = False
            WriteParameter(IniFile)
        End If


    End Sub
    Public Sub PIDTopSave()

        If Output(DoWriteTopPIDIndex).Status Then
            Output(DoWriteTopPIDIndex).Status = False
        Else
            Output(DoWriteTopPIDIndex).Status = True
            TopArea0 = False
            TopArea1 = False
            TopArea2 = False
            TopArea3 = False
            WriteParameter(IniFile)
        End If
    End Sub
    'PID值 儲存
    'Write P
    Private Sub txtTopPL_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles _
    txtTopPL.MouseDown, txtTopPM.MouseDown, txtTopPH.MouseDown, _
    txtBotPL.MouseDown, txtBotPM.MouseDown, txtBotPH.MouseDown
        CallKeyboard2(sender, "100", "0.0")
        WriteParameter(IniFile)
    End Sub
    'Write I,D
    Private Sub txtTopIL_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles _
        txtTopIL.MouseDown, txtTopIM.MouseDown, txtTopIH.MouseDown, _
        txtTopDL.MouseDown, txtTopDM.MouseDown, txtTopDH.MouseDown, _
        txtBotIL.MouseDown, txtBotIM.MouseDown, txtBotIH.MouseDown, _
        txtBotDL.MouseDown, txtBotDM.MouseDown, txtBotDH.MouseDown
        CallKeyboard2(sender, "3600", "0")
        WriteParameter(IniFile)
    End Sub
    'Write Min,Max
    Private Sub txtTopMaxL_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles _
        txtTopMaxL.MouseDown, txtTopMaxM.MouseDown, txtTopMaxH.MouseDown, _
        txtBotMaxL.MouseDown, txtBotMaxM.MouseDown, txtBotMaxH.MouseDown, _
        txtTopMinL.MouseDown, txtTopMinM.MouseDown, txtTopMinH.MouseDown, _
        txtBotMinL.MouseDown, txtBotMinM.MouseDown, txtBotMinH.MouseDown
        CallKeyboard2(sender, "100", "0")
        WriteParameter(IniFile)
    End Sub
    'Temp Rage 
    Private Sub txtTopTempRage1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles _
            txtTopLowRange.MouseDown, txtTopHighRange.MouseDown, txtBotLowRange.MouseDown, txtBotHighRange.MouseDown
        CallKeyboard2(sender, "1000", "0")
        WriteParameter(IniFile)
    End Sub

#End Region

    Private Sub txtTopLowLimitTemp_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtTopLowLimitTemp.MouseDown
        CallKeyboard2(sender, "100", "0")
        WriteParameter(IniFile)
    End Sub

    Private Sub txtTopLowLimitPower_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtTopLowLimitPower.MouseDown
        CallKeyboard2(sender, "100", "0")
        WriteParameter(IniFile)
    End Sub

    Private Sub txtBotLowLimitTemp_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtBotLowLimitTemp.MouseDown
        CallKeyboard2(sender, "100", "0")
        WriteParameter(IniFile)
    End Sub

    Private Sub txtBotLowLimitPower_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtBotLowLimitPower.MouseDown
        CallKeyboard2(sender, "100", "0")
        WriteParameter(IniFile)
    End Sub

    Private Sub btnTopHeater_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTopHeater.Click, btnBotHeater.Click
        If ManualControl(SiteNum).TempOn Then
            ManualControl(SiteNum).SetHeater(False)
        Else
            ManualControl(SiteNum).SetTempON()
        End If
    End Sub

    Private Sub txtTopTempSet_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtTopTempSet.MouseDown, txtBotTempSet.MouseDown
        If ProcessMode_RUN Then Exit Sub
        If CallKeyboard2(sender, TEMP_MAX, TEMP_MIN) <> "" Then
            ManualControl(SiteNum).Write_TempSetToPLC(sender.Text)
            txtTopTempSet.Text = sender.Text
            txtBotTempSet.Text = sender.Text
        End If
    End Sub
End Class

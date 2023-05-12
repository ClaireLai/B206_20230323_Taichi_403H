Public Class ControlManual
    '站號
    Private SiteIndex As Integer
    '是否顯示流量
    Private ShowFlowFlag As Boolean
    '是否使用油壓
    Private OilPumpEnable As Boolean
    '是否在製程中
    Private RunFlag As Boolean
    '設定氣缸 SENSOR INDEX
    Private DiTopLSIndex As Integer
    Private DiBotLSIndex As Integer
    '設定氣缸 SENSOR INDEX
    Private DiTopFlowIndex As Integer
    Private DiBotFlowIndex As Integer
    '設定 油壓/氣壓缸上/下的輸出點
    Private DoPlateUpIndex As Integer
    Private DoPlateDownIndex As Integer
    Private DoBondForceIndex As Integer
    '設定 加熱器開關的輸出點
    Private DoTopHeaterIndex As Integer
    Private DoBotHeaterIndex As Integer
    '油壓幫浦
    Private DoOilPumpIndex As Integer
    '首次貼合
    Private DoFirstContactIndex As Integer

    ''加熱器溫度讀取暫存器
    'Private ADTopHeaterIndex As Integer
    'Private ADBotHeaterIndex As Integer
    '加熱器電流讀取暫存器
    Private ADTopFlowIndex As Integer
    Private ADBotFlowIndex As Integer
    '加熱器電流讀取暫存器
    Private ADTopCurrentIndex As Integer
    Private ADBotCurrentIndex As Integer
    '設定 壓力讀取暫存器
    Private ADPressureIndex As Integer

    '設定值 ,壓力
    Private DABondForceSetIndex As Integer
    Private DABondForceRateSetIndex As Integer
    '設定值 溫度
    Private DATopTempSetIndex As Integer
    Private DABotTempSetIndex As Integer
    Private DATempRateSetIndex As Integer
    '真空值
    Private VACUUM_GAUGE As Double
    '上/下水流量
    Public TopFlow As Double
    Public BotFlow As Double
    Public Sub New()
        ' 此為 Windows Form 設計工具所需的呼叫。
        InitializeComponent()
        ' 在 InitializeComponent() 呼叫之後加入任何初始設定。
    End Sub
    Public Sub Initial(ByVal iSiteIndex As Integer, ByVal iDiTopLSIndex As Integer, ByVal iDiBotLSIndex As Integer, _
               ByVal iDoTopHeaterIndex As Integer, ByVal iDoBotHeaterIndex As Integer, ByVal iDoBondForceIndex As Integer, _
               ByVal iDoBondUpIndex As Integer, ByVal iDoBondDownIndex As Integer, ByVal iDoOilPumpIndex As Integer, _
               ByVal iADTopFlowIndex As Integer, ByVal iADBotFlowIndex As Integer, ByVal iADTopCurrentIndex As Integer, ByVal iADBotCurrentIndex As Integer, _
               ByVal iDABondForceSetIndex As Integer, ByVal iDABondForceRateSetIndex As Integer, ByVal iDoFirstContactIndex As Integer, _
               ByVal iDATopTempSetIndex As Integer, ByVal iDABotTempSetIndex As Integer, ByVal iDATempRateSetIndex As Integer, ByVal iDiTopFlowIndex As Integer, ByVal iDiBotFlowIndex As Integer)
        SiteIndex = iSiteIndex
        '設定氣缸 SENSOR INDEX
        DiTopLSIndex = iDiTopLSIndex
        DiBotLSIndex = iDiBotLSIndex
        '設定 加熱器開關的輸出點
        DoTopHeaterIndex = iDoTopHeaterIndex
        DoBotHeaterIndex = iDoBotHeaterIndex
        '設定 加熱器電流讀取暫存器
        ADTopCurrentIndex = iADTopCurrentIndex
        ADBotCurrentIndex = iADBotCurrentIndex
        '油壓幫浦輸出點
        DoOilPumpIndex = iDoOilPumpIndex
        '氣缸/油壓缸 上/下輸出點
        DoPlateUpIndex = iDoBondUpIndex
        DoPlateDownIndex = iDoBondDownIndex
        DoBondForceIndex = iDoBondForceIndex
        '溫度/壓力設定值
        DABondForceSetIndex = iDABondForceSetIndex
        DABondForceRateSetIndex = iDABondForceRateSetIndex
        DATopTempSetIndex = iDATopTempSetIndex
        DABotTempSetIndex = iDABotTempSetIndex
        DATempRateSetIndex = iDATempRateSetIndex
        '水流量
        ADTopFlowIndex = iADTopFlowIndex
        ADBotFlowIndex = iADBotFlowIndex
        DiTopFlowIndex = iDiTopFlowIndex
        DiBotFlowIndex = iDiBotFlowIndex
        '首次貼合輸出點
        DoFirstContactIndex = iDoFirstContactIndex

        FormTextBoxSave.SetTextBox(Me, Me.Name, FormSaveINIFile)


        ShowFlowFlag = True
        RunFlag = False

        If Purge_Flag = True Then
            picVPT.Visible = True
            picVPB.Visible = True
            PictureBox2.Visible = True
            PictureBox3.Visible = True
            lblVPT.Visible = True
            lblVPB.Visible = True
        Else
            picVPT.Visible = False
            picVPB.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            lblVPT.Visible = False
            lblVPB.Visible = False
        End If

        Timer1.Interval = 500
        Timer1.Enabled = True
    End Sub
    '屬性
    ''' <summary>
    ''' 是否使用油壓幫浦
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property OilPumpUsed() As Boolean
        Get
            Return OilPumpEnable
        End Get
        Set(ByVal value As Boolean)
            OilPumpEnable = value
            btnOilPump.Visible = OilPumpEnable
        End Set
    End Property


    '屬性
    ''' <summary>
    ''' 設定顯示標題
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property Title() As String
        Get
            Return grpManualTitle.Text
        End Get
        Set(ByVal value As String)
            grpManualTitle.Text = value
        End Set
    End Property

    '屬性
    ''' <summary>
    ''' 顯示流量值
    ''' </summary>
    ''' <value></value>
    ''' <remarks></remarks>
    WriteOnly Property ShowFlow() As Boolean
        Set(ByVal value As Boolean)
            ShowFlowFlag = value
            lblFlow01Text.Visible = ShowFlowFlag
            lblFlow02Text.Visible = ShowFlowFlag
            lblTopFlow.Visible = ShowFlowFlag
            lblBotFlow.Visible = ShowFlowFlag
        End Set
    End Property

    '屬性
    ''' <summary>
    ''' 設定是否執行
    ''' </summary>
    ''' <value></value>
    ''' <remarks></remarks>
    WriteOnly Property RunMode() As Boolean
        Set(ByVal value As Boolean)
            RunFlag = value
        End Set
    End Property
    ''' <summary>
    ''' 檢查首次貼合是否完成
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ReadOnly Property FirstContact() As Boolean
        Get
            Return Check_PLC_M(DoFirstContactIndex)
        End Get
    End Property
    ''' <summary>
    ''' 檢查首次貼合是否完成
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ReadOnly Property TempOn() As Boolean
        Get
            Return Check_PLC_Y(DoTopHeaterIndex)
        End Get
    End Property

    '方法--函數-- 給製程使用
    ''' <summary>
    ''' 設定壓頭上升
    ''' </summary>
    ''' <param name="ON_OFF"></param>
    ''' <remarks></remarks>
    Public Sub SetPlateUp(ByVal ON_OFF As Boolean)
        If ON_OFF = True Then
            Output(DoPlateDownIndex).Status = False
            'Output(DoBondForceIndex).Status = False
        End If
        Output(DoPlateUpIndex).Status = ON_OFF
    End Sub
    ''' <summary>
    ''' 設定壓頭下降
    ''' </summary>
    ''' <param name="ON_OFF"></param>
    ''' <remarks></remarks>
    Public Sub SetPlateDown(ByVal ON_OFF As Boolean)
        If ON_OFF = True Then
            Output(DoPlateUpIndex).Status = False
            Output(DoBondForceIndex).Status = False
        End If
        Output(DoPlateDownIndex).Status = ON_OFF
    End Sub
    ''' <summary>
    ''' 設定加壓
    ''' </summary>
    ''' <param name="ON_OFF"></param>
    ''' <remarks></remarks>
    Public Sub SetBondForce(ByVal ON_OFF As Boolean)
        If ON_OFF = True Then
            Output(DoPlateDownIndex).Status = False
        End If
        Output(DoBondForceIndex).Status = ON_OFF
    End Sub
    ''' <summary>
    ''' 設定加熱器的ON/OFF
    ''' </summary>
    ''' <param name="ON_OFF"></param>
    ''' <remarks></remarks>
    Public Sub SetHeater(ByVal ON_OFF As Boolean)
        Output(DoTopHeaterIndex).Status = ON_OFF
    End Sub
    ''' <summary>
    ''' 取得加熱器的ON/OFF
    ''' </summary>
    ''' <param name="ON_OFF"></param>
    ''' <remarks></remarks>
    Public Function GetHeater() As Boolean
        Return Check_PLC_Y(DoTopHeaterIndex)
    End Function


    ''' <summary>
    ''' 設定油壓幫浦動作
    ''' </summary>
    ''' <param name="ON_OFF"></param>
    ''' <remarks></remarks>
    Public Sub SetOilPump(ByVal ON_OFF As Boolean)
        Output(DoOilPumpIndex).Status = ON_OFF
    End Sub
    ''' 寫入溫度 (自動校正轉換)
    Public Sub WriteTempData(ByVal TopTemp As Integer, ByVal BotTemp As Integer, ByVal TempRate As Double)

        'TopTempSV(SiteIndex) = TempCal(SiteIndex).GetTICTopTemp(Temp)
        'BotTempSV(SiteIndex) = TopTempSV(SiteIndex)
        If GetTrue01Boolean(SystemParameters.SplitTopBotTemp) = False Then
            BotTemp = TopTemp
        End If

        Write_PLC_R1100(DATopTempSetIndex, TopTemp)
        Write_PLC_R1100(DABotTempSetIndex, BotTemp)
        Write_PLC_R1100(DATempRateSetIndex, TempRate)

        TopTempSV(SiteIndex) = TempCal(SiteIndex).SetTICTopTemp(TopTemp)
        BotTempSV(SiteIndex) = TempCal(SiteIndex).SetTICBotTemp(BotTemp) 'TopTempSV(SiteIndex) 'Modified by Vincent 20180419 
        If GetTrue01Boolean(SystemParameters.SplitTopBotTemp) = False Then
            BotTempSV(SiteIndex) = TopTempSV(SiteIndex)
        End If
        TopTempRateSV(SiteIndex) = TempRate
        BotTempRateSV(SiteIndex) = TopTempRateSV(SiteIndex)

        txtTempSet.Text = TopTempSV(SiteIndex)
        txtTempRateSet.Text = (TempRate / 100).ToString


    End Sub
    ''' <summary>
    ''' 寫入加壓壓力,  (自動校正轉換)
    ''' </summary>
    ''' <param name="Temp"></param>
    ''' <param name="TempRate"></param>
    ''' <remarks></remarks>
    Public Sub WritePressData(ByVal Temp As Integer, ByVal TempRate As Double)
        Write_PLC_R1100(DABondForceSetIndex, PressSV(SiteIndex))
        Write_PLC_R1100(DABondForceRateSetIndex, PressRateSV(SiteIndex))

        PressSV(SiteIndex) = Temp
        PressRateSV(SiteIndex) = TempRate

        txtPressureSet.Text = Temp.ToString
        txtPressureRateSet.Text = TempRate.ToString
        
    End Sub
    ''' <summary>
    ''' 停止動作計時器
    ''' </summary>
    ''' <param name="ON_OFF"></param>
    ''' <remarks></remarks>
    Public Sub DisableTimer(ByVal ON_OFF As Boolean)
        Timer1.Enabled = ON_OFF
    End Sub

    ''' <summary>
    ''' 計時器動作
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Run()
    End Sub

    Public Sub Write_TempSet(ByVal Value As String)
        txtTempSet.Text = Value
    End Sub
    Public Sub Write_TempSetToPLC(ByVal Value As String)
        txtTempSet.Text = Value
        TopTempSV(SiteIndex) = Val(Value) ' TempCal(SiteIndex).GetTICTopTemp(Val(txtTempSet.Text))
        BotTempSV(SiteIndex) = Val(Value) 'TopTempSV(SiteIndex) 'Modified by Vincent 20180419 
        Dim tempTop As Integer = TempCal(SiteIndex).GetTICTopTemp(TopTempSV(SiteIndex))
        Dim tempBot As Integer = TempCal(SiteIndex).GetTICBotTemp(TopTempSV(SiteIndex))
        If GetTrue01Boolean(SystemParameters.SplitTopBotTemp) = False Then
            tempBot = tempTop
        End If
        Write_PLC_R1100(DATopTempSetIndex, tempTop)
        Write_PLC_R1100(DABotTempSetIndex, tempBot)

        TopTempRateSV(SiteIndex) = Val(txtTempRateSet.Text) * 100
        BotTempRateSV(SiteIndex) = TopTempRateSV(SiteIndex)
        Write_PLC_R1100(DATempRateSetIndex, TopTempRateSV(SiteIndex))

        FormTextBoxSave.FindTextBox(Me, Me.Name, FormSaveINIFile)
    End Sub
    Public Sub Write_TempRateSet(ByVal Value As String)
        txtTempRateSet.Text = Value
    End Sub
    Public Sub Write_PressureSet(ByVal Value As String)
        txtPressureSet.Text = Value
    End Sub
    Public Sub Write_PressureRateSet(ByVal Value As String)
        txtPressureRateSet.Text = Value
    End Sub

    '資料更新
    ''' <summary>
    ''' 定時資料更新
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Run()
        lblMonitorTemp.Visible = TIC_MONITOR_USED
        picC05.Visible = TIC_MONITOR_USED
        lblMonitorTemp.Text = MonitorTemp(SiteIndex)

        'btnPlateDown.Enabled = Not RunFlag
        ShowFlowFlag = True 'CelloUsbFlag
        lblTopFlow.Visible = ShowFlowFlag
        lblBotFlow.Visible = ShowFlowFlag
        lblFlow01Text.Visible = ShowFlowFlag
        lblFlow02Text.Visible = ShowFlowFlag
        'If ShowFlowFlag = True Then
        TopFlow = FlowRead(SiteIndex).GetTopFLow
        BotFlow = FlowRead(SiteIndex).GetBotFLow

        lblTopFlow.Text = FlowRead(SiteIndex).GetTopFLowStr
        lblBotFlow.Text = FlowRead(SiteIndex).GetBotFLowStr
        'End If
        If CommLivePLC Then
            If Check_PLC_Y(DoFirstContactIndex) Then
                picBotPlate.Top = picBotPlate2.Top
                picWaferChip.Top = picWaferChip2.Top
                pnlCylinderAxis.Top = pnlCylinderAxis2.Top
            Else
                picBotPlate.Top = picBotPlate1.Top
                picWaferChip.Top = picWaferChip1.Top
                pnlCylinderAxis.Top = pnlCylinderAxis1.Top
            End If
            lblTopTemp.Text = TopTempPV(SiteIndex)
            lblBotTemp.Text = BotTempPV(SiteIndex)
            lblPressure.Text = PressPVstr(SiteIndex)
            lblTopCurrent.Text = TopCurrentStr(SiteIndex)
            lblBotCurrent.Text = BotCurrentStr(SiteIndex)


            ObjShow.Show(Check_PLC_Y(DoTopHeaterIndex), picTopPlate, My.Resources.HEAT_ON, My.Resources.HEAT_OFF)
            ObjShow.Show(Check_PLC_Y(DoBotHeaterIndex), picBotPlate, My.Resources.HEAT_ON, My.Resources.HEAT_OFF)

            ObjShow.Show(Check_PLC_Y(DoFirstContactIndex), picPlateUp, My.Resources.Sensor_ON, My.Resources.Sensor_OFF)
            ObjShow.Show(Check_PLC_X(DiBotLSIndex), picPlateDown, My.Resources.Sensor_ON, My.Resources.Sensor_OFF)
            ObjShow.Show(Check_PLC_Y(DoFirstContactIndex), pic1stContact, My.Resources.Sensor_ON, My.Resources.Sensor_OFF)

            ObjShow.Show(Check_PLC_M(DoPlateDownIndex), btnPlateDown, ColorOn, ColorOff)
            ObjShow.Show(Check_PLC_M(DoPlateUpIndex), btnPlateUp, ColorOn, ColorOff)

            ObjShow.Show(Check_PLC_Y(DoTopHeaterIndex), btnTempON, ColorOn, "ON", ColorOff, "OFF")
            ObjShow.Show(Check_PLC_M(DoBondForceIndex), btnBondingForce, ColorOn, "ON", ColorOff, "OFF")
            ObjShow.Show(Check_PLC_M(DoOilPumpIndex), btnOilPump, ColorOn, ColorOff)


            ObjShow.Show(Check_PLC_M(DoTopPurge1Index + SiteIndex * 2), picVPT, My.Resources.vvon, My.Resources.vvoff)
            ObjShow.Show(Check_PLC_M(DoBotPurge1Index + SiteIndex * 2), picVPB, My.Resources.vvon, My.Resources.vvoff)

            If Purge_Flag = True Then
                ObjShow.Show(Check_PLC_M(DoTopPurge1Index + SiteIndex * 2), picVPT, My.Resources.vvon, My.Resources.vvoff)
                ObjShow.Show(Check_PLC_M(DoBotPurge1Index + SiteIndex * 2), picVPB, My.Resources.vvon, My.Resources.vvoff)

            End If

        End If

    End Sub
    '資料設定
    ''' <summary>
    ''' 設定控制項顯示溫度/壓力資料
    ''' </summary>
    ''' <param name="iPressure"></param>
    ''' <param name="iTopTemp"></param>
    ''' <param name="iBotTemp"></param>
    ''' <remarks></remarks>
    Public Sub SetTempPressure(ByVal iPressure As Integer, ByVal iTopTemp As Integer, ByVal iBotTemp As Integer)
        lblPressure.Text = iPressure.ToString
        lblTopTemp.Text = iTopTemp.ToString
        lblBotTemp.Text = iBotTemp.ToString
        Run()
    End Sub
    ''' <summary>
    ''' 設定控制項顯示流量資料
    ''' </summary>
    ''' <param name="sTopFlow"></param>
    ''' <param name="sBotFlow"></param>
    ''' <remarks></remarks>
    Public Sub SetFlow(ByVal sTopFlow As String, ByVal sBotFlow As String)
        lblTopFlow.Text = sTopFlow
        lblBotFlow.Text = sTopFlow
    End Sub
    ''' <summary>
    ''' 設定控制項顯示真空計資料
    ''' </summary>
    ''' <param name="sPressure"></param>
    ''' <param name="VacValue"></param>
    ''' <remarks></remarks>
    Public Sub SetVacuum(ByVal VacValue As Double)
        VACUUM_GAUGE = VacValue
    End Sub


    '壓力輸出
    Private Sub btnPlateUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlateUp.Click
        BondCycleStop(grpManualTitle.Text) 'By chesly 20181023 壓缸自動循環動作
        If LC.IsExpired Then
            MsgBoxLangErr("系統未註冊!", "Not Register!")
            Exit Sub
        End If
        If RunFlag Then Exit Sub
        If Output(DoPlateUpIndex).Status Then
            Output(DoPlateUpIndex).Status = False
        Else

            If PLC_X(DiDoor1UpIndex) = "0" Or PLC_X(DiDoor2UpIndex) = "0" Then
                'If CelloUsbFlag Then
                If MsgBoxLangYesNo("腔門未關閉!,確認要上升?", "Door Not Closed,Force Bond Up?") = False Then
                    Exit Sub
                Else
                    If OilPumpEnable Then
                        If Check_PLC_M(DoOilPumpIndex) Then
                            If MsgBoxLangYesNo("請確認載盤已置放!", "Please Cormfirm Plate Up!") Then
                                SetPlateUp()
                            End If
                        Else
                            MsgBoxLangErr("油壓幫浦未啟動!", "Oil Pump need ON!")
                        End If
                    Else
                        If MsgBoxLangYesNo("請確認載盤已置放!", "Please Cormfirm Plate Up!") Then
                            SetPlateUp()
                        End If
                    End If
                End If
                'Else
                '    MsgBoxLangErr("腔門未關閉,請關閉腔門!", "Door not Close!")
                'End If
            Else
                If OilPumpEnable Then
                    If Check_PLC_M(DoOilPumpIndex) Then
                        If MsgBoxLangYesNo("請確認載盤已置放!", "Please Cormfirm Plate Up!") Then
                            SetPlateUp()
                        End If
                    Else
                        MsgBoxLangErr("油壓幫浦未啟動!", "Oil Pump need ON!")
                    End If
                Else
                    If MsgBoxLangYesNo("請確認載盤已置放!", "Please Cormfirm Plate Up!") Then
                        SetPlateUp()
                    End If
                End If
            End If
        End If

    End Sub

    Public Sub SetPlateUp()
        Output(DoPlateUpIndex).Status = True
        Output(DoPlateDownIndex).Status = False
        Output(DoBondForceIndex).Status = False
    End Sub

    Private Sub btnPlateDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlateDown.Click
        BondCycleStop(grpManualTitle.Text) 'By chesly 20181023 壓缸自動循環動作
        If RunFlag Then Exit Sub
        If Output(DoPlateDownIndex).Status Then
            Output(DoPlateDownIndex).Status = False
        Else
            If OilPumpEnable Then
                If Check_PLC_M(DoOilPumpIndex) Then
                    SetPlateDown()
                Else
                    MsgBoxLangErr("油壓幫浦未啟動!", "Oil Pump need ON!")
                End If
            Else
                SetPlateDown()
            End If
        End If
    End Sub

    Public Sub SetPlateDown()
        Output(DoPlateDownIndex).Status = True
        Output(DoPlateUpIndex).Status = False
        Output(DoBondForceIndex).Status = False
    End Sub
    Private Sub txtPressureSet_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtPressureSet.MouseDown
        If RunFlag Then Exit Sub
        If CallKeyboard2(sender, PRESS_MAX, PRESS_MIN) <> "" Then
            PressSV(SiteIndex) = Val(sender.Text) ' SetCalibratedTemp(Val(sender.Text), PressX, PressY, 5)
            Write_PLC_R1100(DABondForceSetIndex, PressSV(SiteIndex))
            FormTextBoxSave.FindTextBox(Me, Me.Name, FormSaveINIFile)

        End If
    End Sub

    Private Sub txtPressureRateSet_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtPressureRateSet.MouseDown
        If RunFlag Then Exit Sub
        If CallKeyboard2(sender, PRESSRATE_MAX, PRESSRATE_MIN) <> "" Then
            PressRateSV(SiteIndex) = Val(sender.Text) ' SetCalibratedTemp(Val(sender.Text), PressX, PressY, 5)
            Write_PLC_R1100(DABondForceRateSetIndex, Val(sender.Text))
            FormTextBoxSave.FindTextBox(Me, Me.Name, FormSaveINIFile)

        End If
    End Sub

    Private Sub btnBondingForce_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBondingForce.Click
        BondCycleStop(grpManualTitle.Text) 'By chesly 20181023 壓缸自動循環動作
        If LC.IsExpired Then
            MsgBoxLangErr("註冊後才能使用!", "Please Register!")
            Exit Sub
        End If
        If RunFlag Then Exit Sub
        If Output(DoBondForceIndex).Status Then
            Output(DoBondForceIndex).Status = False
        Else
            If PLC_X(DiDoor1UpIndex) = "0" Or PLC_X(DiDoor2UpIndex) = "0" Then
                'If CelloUsbFlag Then
                If MsgBoxLangYesNo("腔門未關閉!,確認要加壓?", "腔门未关闭,确认要加压?", "Door Not Closed,Still Force ON?") = False Then
                    Exit Sub
                Else
                    SetForce()
                End If
                'Else
                '    MsgBoxLangErr("腔門未關閉,請關閉腔門!", "腔门未关闭,请关闭腔门!", "Door not Close!")
                'End If
            Else
                If OilPumpEnable Then
                    If Check_PLC_M(DoOilPumpIndex) Then
                        If MsgBoxLangYesNo("請確認載盤已置放!", "请确认载盘已置放!", "Please Cormfirm Plate Up!") Then
                            SetForce()
                        End If
                    Else
                        MsgBoxLangErr("油壓幫浦未啟動!", "油压帮浦未启动!", "Oil Pump need ON!")
                    End If
                Else
                    If MsgBoxLangYesNo("請確認載盤已置放!", "请确认载盘已置放!", "Please Cormfirm Plate Up!") Then
                        SetForce()
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub SetForce()
        Output(DoPlateDownIndex).Status = False
        Output(DoPlateUpIndex).Status = True
        Output(DoBondForceIndex).Status = True
        PressSV(SiteIndex) = Val(txtPressureSet.Text) ' SetCalibratedTemp(Val(sender.Text), PressX, PressY, 5)
        PressRateSV(SiteIndex) = Val(txtPressureRateSet.Text) ' SetCalibratedTemp(Val(sender.Text), PressX, PressY, 5)
        Write_PLC_R1100(DABondForceSetIndex, PressSV(SiteIndex))
        Write_PLC_R1100(DABondForceRateSetIndex, Val(txtPressureRateSet.Text))
    End Sub

    Private Sub btnOilPump_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOilPump.Click
        BondCycleStop(grpManualTitle.Text) 'By chesly 20181023 壓缸自動循環動作
        Output(DoOilPumpIndex).Status = Not Output(DoOilPumpIndex).Status
        If Output(DoOilPumpIndex).Status = False Then
            Output(DoPlateDownIndex).Status = False
            Output(DoPlateUpIndex).Status = False
            Output(DoBondForceIndex).Status = False
        End If
    End Sub


    Private Sub txtTempSet_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtTempSet.MouseDown
        If RunFlag Then Exit Sub
        If CallKeyboard2(sender, TEMP_MAX, TEMP_MIN) <> "" Then
            TopTempSV(SiteIndex) = TempCal(SiteIndex).GetTICTopTemp(Val(sender.Text))
            BotTempSV(SiteIndex) = TempCal(SiteIndex).GetTICBotTemp(Val(sender.Text)) 'TopTempSV(SiteIndex)  'Modified by Vincent 20180419 
            'BotTempSV(SiteIndex) = TempCal(SiteIndex).GetTICTopTemp(Val(sender.Text))
            If GetTrue01Boolean(SystemParameters.SplitTopBotTemp) = False Then
                BotTempSV(SiteIndex) = TopTempSV(SiteIndex)
            End If
            Write_PLC_R1100(DATopTempSetIndex, TopTempSV(SiteIndex))
            Write_PLC_R1100(DABotTempSetIndex, BotTempSV(SiteIndex))
            FormTextBoxSave.FindTextBox(Me, Me.Name, FormSaveINIFile)
        End If
    End Sub

    Private Sub txtTempRateSet_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtTempRateSet.MouseDown
        Dim max As String
        If RunFlag Then Exit Sub
        If CelloUsbFlag Then
            max = "20"
        Else
            max = TEMPRATE_MAX
        End If
        If CallKeyboard2(sender, max, TEMPRATE_MIN) <> "" Then
            TopTempRateSV(SiteIndex) = Val(sender.Text) * 100
            BotTempRateSV(SiteIndex) = TopTempRateSV(SiteIndex)
            Write_PLC_R1100(DATempRateSetIndex, TopTempRateSV(SiteIndex))
        End If

        FormTextBoxSave.FindTextBox(Me, Me.Name, FormSaveINIFile)
    End Sub

    Private Sub btnTempON_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTempON.Click
        BondCycleStop(grpManualTitle.Text) 'By chesly 20181023 壓缸自動循環動作
        SetTempON()
    End Sub
    Public Sub SetTempON()
        Dim VacLimit As String = "1.0E-01"
        If RunFlag Then Exit Sub
        If Output(DoTopHeaterIndex).Status Then
            Output(DoTopHeaterIndex).Status = False
        Else
            If FlowMeterMode Then
                If TopFlow < Val(SystemParameters.LowFlowAlarm) Or (BotFlow < Val(SystemParameters.LowFlowAlarm)) Then
                    If CelloUsbFlag Then
                        If MsgBoxLangYesNo("無冷卻水流量!,確認要開啟加熱?", "No Cooling Water flow, Still Force ON?") = False Then
                            Exit Sub
                        End If
                    Else
                        MsgBoxLangErr("無冷卻水流量!!", "No Cooling Water flow!!")
                        Exit Sub
                    End If
                End If
            Else
                If Check_PLC_X(DiTopFlowIndex) = False Or Check_PLC_X(DiTopFlowIndex) = False Then
                    If CelloUsbFlag Then
                        If MsgBoxLangYesNo("無冷卻水流量!,確認要開啟加熱?", "No Cooling Water flow, Still Force ON?") = False Then
                            Exit Sub
                        End If
                    Else
                        MsgBoxLangErr("無冷卻水流量!!  #" + (SiteIndex + 1).ToString, "No Cooling Water flow !!  #" + (SiteIndex + 1).ToString)
                        Exit Sub
                    End If
                End If
            End If
            If Check_PLC_X(DiWater01Index) = False Then
                If CelloUsbFlag Then
                    If MsgBoxLangYesNo("無冷卻水壓!,確認要開啟加熱?", "No Cooling Water Flow,Still Force ON?") = False Then
                        Exit Sub
                    End If
                Else
                    MsgBoxLangErr("無冷卻水壓!", "No Cooling Water Pressure!!")
                    Exit Sub
                End If
            End If
            If Check_PLC_X(DiDoor1UpIndex) = False Or Check_PLC_X(DiDoor2UpIndex) = False Then
                If CelloUsbFlag Then
                    If MsgBoxLangYesNo("腔門未關閉!,確認要開啟加熱?", "Door not Close!, Still Force ON?") = False Then
                        Exit Sub
                    End If
                Else
                    MsgBoxLangErr("腔門未關閉,請關閉腔門!", "Door not Close!")
                    Exit Sub
                End If
            End If
            If VACUUM_GAUGE > Val(VacLimit) Then
                If CelloUsbFlag Then
                    If MsgBoxLangYesNo("真空值要<" + VacLimit + " Torr, 確認要開啟加熱?", "Vacuum Need <" + VacLimit + " Torr, Still Force ON?") = False Then
                        Exit Sub
                    End If
                Else
                    MsgBoxLangErr("真空值要<" + VacLimit + " Torr", "Vacuum Need <" + VacLimit + " Torr")
                    Exit Sub
                End If
            End If

            Output(DoTopHeaterIndex).Status = True


            TopTempSV(SiteIndex) = TempCal(SiteIndex).GetTICTopTemp(Val(txtTempSet.Text))
            BotTempSV(SiteIndex) = TempCal(SiteIndex).GetTICBotTemp(Val(txtTempSet.Text)) 'TopTempSV(SiteIndex) 'Modified by Vincent 20180419 

            TopTempRateSV(SiteIndex) = Val(txtTempRateSet.Text) * 100
            BotTempRateSV(SiteIndex) = TopTempRateSV(SiteIndex)

            'TimeDelay(100)
            'BotTempSV(SiteIndex) = TempCal(SiteIndex).GetTICTopTemp(Val(sender.Text))
            If GetTrue01Boolean(SystemParameters.SplitTopBotTemp) = False Then
                BotTempSV(SiteIndex) = TopTempSV(SiteIndex)
            End If

            Write_PLC_R1100(DATopTempSetIndex, TopTempSV(SiteIndex))
            Write_PLC_R1100(DABotTempSetIndex, BotTempSV(SiteIndex))

            'TimeDelay(100)
            Write_PLC_R1100(DATempRateSetIndex, TopTempRateSV(SiteIndex))
        End If
    End Sub
    'By chesly 20181023 壓缸自動循環動作 Start 
    Private Sub BondCycleStop(ByVal Index As String)
        Dim str As String = Index
        Select Case str
            Case "Site #01"
                BondCycle1.StartRun = False
            Case "Site #02"
                BondCycle2.StartRun = False
            Case "Site #03"
                BondCycle3.StartRun = False
            Case "Site #04"
                BondCycle4.StartRun = False
            Case "Site #05"
                BondCycle5.StartRun = False
            Case "Site #06"
                BondCycle6.StartRun = False
            Case "all"
                BondCycle1.StartRun = False
                BondCycle2.StartRun = False
                BondCycle3.StartRun = False
                BondCycle4.StartRun = False
                BondCycle5.StartRun = False
                BondCycle6.StartRun = False
        End Select
    End Sub 'By chesly 20181023 壓缸自動循環動作 end

    Private Sub picTopPurge_Click(sender As System.Object, e As System.EventArgs) Handles picVPT.Click
        Output(DoTopPurge1Index + SiteIndex * 2).Status = Not Output(DoTopPurge1Index + SiteIndex * 2).Status
    End Sub

    Private Sub picBotPurge_Click(sender As System.Object, e As System.EventArgs) Handles picVPB.Click
        Output(DoBotPurge1Index + SiteIndex * 2).Status = Not Output(DoBotPurge1Index + SiteIndex * 2).Status
    End Sub
End Class

Public Class ControlProcess
    Private SiteIndex As Integer
    Private ShowFlowFlag As Boolean
    Private RunFlag As Boolean
    '設定氣缸 SENSOR INDEX
    Private DiTopLSIndex As Integer
    Private DiBotLSIndex As Integer
    '設定 加熱器開關的輸出點
    Private DoPlateUpIndex As Integer
    Private DoPlateDownIndex As Integer
    '設定 加熱器開關的輸出點
    Private DoTopHeaterIndex As Integer
    Private DoBotHeaterIndex As Integer
    '設定 加熱器溫度讀取暫存器
    Private ADTopHeaterIndex As Integer
    Private ADBotHeaterIndex As Integer
    '設定 加熱器電流讀取暫存器
    Private ADTopCurrent01Index As Integer
    Private ADBotCurrent01Index As Integer
    '設定 加熱器電流讀取暫存器
    Private ADTopFlowIndex As Integer
    Private ADBotFlowIndex As Integer

    '設定 壓力讀取暫存器
    Private ADPressureIndex As Integer
    Public Sub New()
        ' 此為 Windows Form 設計工具所需的呼叫。
        InitializeComponent()
        ' 在 InitializeComponent() 呼叫之後加入任何初始設定。

    End Sub
    Public Sub Initial(ByVal iSiteIndex As Integer, ByVal iDiTopLSIndex As Integer, ByVal iDiBotLSIndex As Integer, _
                  ByVal iDoTopIndex As Integer, ByVal iDoBotIndex As Integer, _
                  ByVal iDoBondUpIndex As Integer, ByVal iDoBondDownIndex As Integer, _
                  ByVal iADTopCurrent01Index As Integer, ByVal iADBotCurrentIndex As Integer)
        SiteIndex = iSiteIndex
        '設定氣缸 SENSOR INDEX
        DiTopLSIndex = iDiTopLSIndex
        DiBotLSIndex = iDiBotLSIndex
        '設定 加熱器開關的輸出點
        DoTopHeaterIndex = iDoTopIndex
        DoBotHeaterIndex = iDoBotIndex
        '設定 加熱器電流讀取暫存器
        ADTopCurrent01Index = iADTopCurrent01Index
        ADBotCurrent01Index = iADBotCurrentIndex

        DoPlateUpIndex = iDoBondUpIndex
        DoPlateDownIndex = iDoBondDownIndex
        ShowFlowFlag = True
        RunFlag = False

        If Purge_Flag = True Then
            picVPT.Visible = True
            picVPB.Visible = True
            PictureBox1.Visible = True
            PictureBox3.Visible = True
            lblVPT.Visible = True
            lblVPB.Visible = True
        Else
            picVPT.Visible = False
            picVPB.Visible = False
            PictureBox1.Visible = False
            PictureBox3.Visible = False
            lblVPT.Visible = False
            lblVPB.Visible = False
        End If

        Timer1.Interval = 500
        Timer1.Enabled = True
    End Sub

    Public Sub ChangeLanguage(ByVal lang As Integer)
        Select Case lang


        End Select
    End Sub

    '屬性
    Property Title() As String
        Get
            Return grpProcessDataTitle.Text
        End Get
        Set(ByVal value As String)
            grpProcessDataTitle.Text = value
        End Set
    End Property

    '屬性
    WriteOnly Property ShowFlow() As Boolean
        Set(ByVal value As Boolean)
            ShowFlowFlag = value
        End Set
    End Property

    '屬性
    WriteOnly Property RunMode() As Boolean
        Set(ByVal value As Boolean)
            RunFlag = value
        End Set
    End Property

    '方法--函數
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Run()
    End Sub
    Public Sub Run()
        lblMonitorTemp.Visible = TIC_MONITOR_USED
        picC05.Visible = TIC_MONITOR_USED
        lblMonitorTemp.Text = MonitorTemp(SiteIndex)


        btnPlateDown.Enabled = Not RunFlag
        If CommLivePLC Then
            If Check_PLC_Y(Do1stContactOK01Index + SiteIndex) Then
                picBotPlate.Top = picBotPlate2.Top
                picWaferChip.Top = picWaferChip2.Top
                pnlCylinderAxis.Top = pnlCylinderAxis2.Top
            Else
                picBotPlate.Top = picBotPlate1.Top
                picWaferChip.Top = picWaferChip1.Top
                pnlCylinderAxis.Top = pnlCylinderAxis1.Top
            End If
            lblTopCurrent.Text = Format(Get_PLC_R1000(ADTopCurrent01Index) / 100, "0.#")
            lblBotCurrent.Text = Format(Get_PLC_R1000(ADBotCurrent01Index) / 100, "0.#")
            ObjShow.Show(Check_PLC_Y(DoTopHeaterIndex), picTopPlate, My.Resources.HEAT_ON, My.Resources.HEAT_OFF)
            ObjShow.Show(Check_PLC_Y(DoBotHeaterIndex), picBotPlate, My.Resources.HEAT_ON, My.Resources.HEAT_OFF)

            ObjShow.Show(Check_PLC_Y(Do1stContactOK01Index + SiteIndex), picPlateUp, My.Resources.Sensor_ON, My.Resources.Sensor_OFF)
            ObjShow.Show(Check_PLC_X(DiBotLSIndex), picPlateDown, My.Resources.Sensor_ON, My.Resources.Sensor_OFF)

            ObjShow.Show(Check_PLC_Y(Do1stContactOK01Index + SiteIndex), picFirstContact, My.Resources.Sensor_ON, My.Resources.Sensor_OFF)

            ObjShow.Show(Check_PLC_Y(DoPlateDownIndex), btnPlateDown, Color.Lime, System.Drawing.SystemColors.Control)

            'ObjShow.Show(RunFlag, grpTitle, Color.Pink, System.Drawing.SystemColors.Control)
        End If
        ShowFlowFlag = True
        lblFlow01Text.Visible = ShowFlowFlag
        lblFlow02Text.Visible = ShowFlowFlag
        lblTopFlow.Visible = ShowFlowFlag
        lblBotFlow.Visible = ShowFlowFlag
        btnSkip.Visible = CelloUsbFlag
        'btnAbort.Visible = Rights_Manual
        lblTopFlow.Text = FlowRead(SiteIndex).GetTopFLowStr
        lblBotFlow.Text = FlowRead(SiteIndex).GetBotFLowStr
        If Purge_Flag = True Then
            ObjShow.Show(Check_PLC_M(DoTopPurge1Index + SiteIndex * 2), picVPT, My.Resources.vvon, My.Resources.vvoff)
            ObjShow.Show(Check_PLC_M(DoBotPurge1Index + SiteIndex * 2), picVPB, My.Resources.vvon, My.Resources.vvoff)
        End If
    End Sub

    Public Sub RunTemp(ByVal iPressure As Integer, ByVal iTopTemp As Integer, ByVal iBotTemp As Integer)
        lblPressure.Text = iPressure.ToString
        lblTopTemp.Text = iTopTemp.ToString
        lblBotTemp.Text = iBotTemp.ToString
        Run()
    End Sub
    Public Sub SetTempPress(ByVal iPressure As Integer, ByVal iTopTemp As Integer)
        lblPressureSet.Text = iPressure.ToString
        lblTopTempSet.Text = iTopTemp.ToString
        lblBotTempSet.Text = iTopTemp.ToString
    End Sub

    Public Sub RunFlow(ByVal sTopFlow As String, ByVal sBotFlow As String)
        lblTopFlow.Text = sTopFlow
        lblBotFlow.Text = sBotFlow
    End Sub

    Private Sub btnPlateDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlateDown.Click
        If ProcessMode_RUN Then Exit Sub
        If Output(DoPlateDownIndex).Status Then
            Output(DoPlateDownIndex).Status = False
        Else
            If OilPumpUsed Then
                If Check_PLC_M(DoOilPump01Index + SiteIndex * 4) Then
                    ManualControl(SiteIndex).SetPlateDown()
                Else
                    MsgBoxLangErr("油壓幫浦未啟動!", "Oil Pump need ON!")
                End If
            Else
                ManualControl(SiteIndex).SetPlateDown()
            End If
        End If
    End Sub

    Private Sub btnAbort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbort.Click
        Dim sstr As String
        If CSubAutoProcess(SiteIndex).Run Then
            sstr = GetLangText("確定要中斷 #" + (SiteIndex + 1).ToString + "製程?", "Abort  #" + (SiteIndex + 1).ToString + "Processes?")
            If MsgBoxLangYesNo(sstr) Then
                ManualControl(SiteIndex).SetHeater(False)
                CSubAutoProcess(SiteIndex).Abort()
                ManualControl(SiteIndex).RunMode = False
            End If
        Else
            If Check_PLC_Y(DoTopHeaterIndex) Or Check_PLC_Y(DoBotHeaterIndex) Then
                sstr = GetLangText("確定要關閉 #" + (SiteIndex + 1).ToString + " 加熱?", "Turn Heater  #" + (SiteIndex + 1).ToString + " Off?")
                If MsgBoxLangYesNo(sstr) Then
                    ManualControl(SiteIndex).SetHeater(False)
                    ManualControl(SiteIndex).RunMode = False
                End If
            End If
        End If
    End Sub

    Private Sub btnSkip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSkip.Click
        Dim sstr As String
        sstr = GetLangText("Plate #" + (SiteIndex + 1).ToString + " 確定要略過 STEP ?", "Plate #" + (SiteIndex + 1).ToString + " Confirm Skip ?")

        If MsgBoxLangYesNo(sstr) Then
            CSubAutoProcess(SiteIndex).Skip()
        End If
    End Sub

End Class

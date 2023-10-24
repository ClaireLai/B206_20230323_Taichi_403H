Imports System.Drawing
Public Class ControlPressCal
    Private Const MAXPOINT As Integer = 6
    Private CalDataX(MAXPOINT) As Integer
    Private CalDataY(MAXPOINT) As Integer

    Private ModifiedFlag As Boolean
    Private OriginalPress As Integer
    Private OriginalPressAD As Integer
    Private CaledPress As Integer
    Private ScaleValue As Integer
    '
    Private SiteNum As Integer
    Private MaxValue As Integer

    Private IniFile As String
    Private SiteName As String
    Private Section As String


    Private FullScale As Integer

    Private DisableXValue As Boolean
    Private DisableFullScale As Boolean
    Private OilPumpEnable As Boolean
    'PLC
    Private DAFullScaleIndex As Integer
    Private DAPressCalXIndex As Integer
    Private DAPressCalYIndex As Integer
    '壓力資料
    Private ADOriginalPressAD As Integer
    Private ADOriginalPressIndex As Integer
    Private ADCaledPressIndex As Integer
    '比例閥
    Private ADScalerValueIndex As Integer
    Private DoPlateUpIndex As Integer
    Private DoPlateDownIndex As Integer
    Private DoOilPumpIndex As Integer

    Private boltemp As Boolean = True
    Public Event CalXInput(ByVal bStatus As Boolean)
    Public Event CalYInput(ByVal bStatus As Boolean)
    Public Event CalFullScaleInput(ByVal bStatus As Boolean)

    Public Sub New()
        ' 此為 Windows Form 設計工具所需的呼叫。
        InitializeComponent()
        ' 在 InitializeComponent() 呼叫之後加入任何初始設定。
    End Sub
    Public Sub Initial(ByVal iSiteNum As Integer, ByVal iDAPressCalXIndex As Integer, ByVal iDAPressCalYIndex As Integer,
                       ByVal iADOriginalPressAD As Integer, ByVal iADOriginalPressIndex As Integer,
                       ByVal iADCaledPressIndex As Integer, ByVal iDAFullScaleIndex As Integer,
                       ByVal iADScalerValueIndex As Integer,
                       ByVal iDoPlateUpIndex As Integer, ByVal iDoPlateDownIndex As Integer,
                       ByVal iDoOilPumpIndex As Integer,
                       Optional ByVal iMaxValue As Integer = 30000, Optional ByVal iStep As Integer = 500)
        Dim i As Integer
        'For i = 0 To MAXPOINT
        '    CalDataX(i) = iStep * i
        '    CalDataY(i) = iStep * i
        'Next
        SiteNum = iSiteNum
        DAPressCalXIndex = iDAPressCalXIndex
        DAPressCalYIndex = iDAPressCalYIndex
        ADOriginalPressAD = iADOriginalPressAD
        ADOriginalPressIndex = iADOriginalPressIndex
        ADCaledPressIndex = iADCaledPressIndex
        DAFullScaleIndex = iDAFullScaleIndex
        ADScalerValueIndex = iADScalerValueIndex
        DoPlateUpIndex = iDoPlateUpIndex
        DoPlateDownIndex = iDoPlateDownIndex

        DoOilPumpIndex = iDoOilPumpIndex


        MaxValue = iMaxValue
        If MaxValue <= 0 Then MaxValue = 30000

        IniFile = ParameterINIFile
        SiteName = "SITE" 'SiteName = SiteName 'By Chesly 20180515
        Section = "PRESS_SETUP" + Format(iSiteNum, "00")
        ReadCalData(IniFile)
        'WriteToPLC()
        txtFullScale.Text = Get_PLC_R1100(DAFullScaleIndex).ToString
        txtX1.Text = Get_PLC_R1100(DAPressCalXIndex)
        txtX2.Text = Get_PLC_R1100(DAPressCalXIndex + 1)
        txtX3.Text = Get_PLC_R1100(DAPressCalXIndex + 2)
        txtX4.Text = Get_PLC_R1100(DAPressCalXIndex + 3)
        txtX5.Text = Get_PLC_R1100(DAPressCalXIndex + 4)

        txtY1.Text = Get_PLC_R1100(DAPressCalYIndex)
        txtY2.Text = Get_PLC_R1100(DAPressCalYIndex + 1)
        txtY3.Text = Get_PLC_R1100(DAPressCalYIndex + 2)
        txtY4.Text = Get_PLC_R1100(DAPressCalYIndex + 3)
        txtY5.Text = Get_PLC_R1100(DAPressCalYIndex + 4)

        Timer1.Interval = 500
        Timer1.Enabled = True
        'WriteCalDate(ProgramINIFile)

    End Sub
    Property Title() As String
        Get
            Return grpPressCalTitle.Text
        End Get
        Set(ByVal value As String)
            grpPressCalTitle.Text = value
        End Set
    End Property

    WriteOnly Property EnableXInput() As Boolean
        Set(ByVal value As Boolean)
            Dim i As Integer
            DisableXValue = value
            txtX1.Enabled = value
            txtX2.Enabled = value
            txtX3.Enabled = value
            txtX4.Enabled = value
            txtX5.Enabled = value
            txtFullScale.Enabled = value
        End Set
    End Property
    '屬性
    Property OilPumpUsed() As Boolean
        Get
            Return OilPumpEnable
        End Get
        Set(ByVal value As Boolean)
            OilPumpEnable = value
        End Set
    End Property
    ReadOnly Property OriginalPressure() As Integer
        Get
            Return OriginalPress
        End Get
    End Property
    ReadOnly Property CaledPressure() As Integer
        Get
            Return CaledPress
        End Get
    End Property

    Public Sub SetValue(ByVal DataX() As Integer, ByVal DataY() As Integer)
        Dim i As Integer
        For i = 0 To MAXPOINT
            CalDataX(i) = DataX(i)
            CalDataY(i) = DataY(i)
        Next
        WriteData()
    End Sub

    Public Sub ReadValue(ByRef DataX() As Integer, ByRef DataY() As Integer)
        Dim i As Integer
        For i = 0 To MAXPOINT
            DataX(i) = CalDataX(i)
            DataY(i) = CalDataY(i)
        Next
    End Sub

    Private Sub txtTempX1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles _
    txtX1.MouseDown, txtX2.MouseDown, txtX3.MouseDown, txtX4.MouseDown, txtX5.MouseDown
        CallKeyboard2(sender, NORMAL_MAX, NORMAL_MIN)
        Write_PLC_R1100(DAPressCalXIndex + sender.TabIndex, Val(sender.Text))
        RaiseEvent CalXInput(True)
        SaveData()

    End Sub
    Private Sub txtTempY1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles _
    txtY1.MouseDown, txtY2.MouseDown, txtY3.MouseDown, txtY4.MouseDown, txtY5.MouseDown
        CallKeyboard2(sender, NORMAL_MAX, NORMAL_MIN)
        Write_PLC_R1100(DAPressCalYIndex + sender.TabIndex, Val(sender.Text))
        'RaiseEvent CalXInput(True)
        SaveData()
    End Sub
    Private Sub txtFullScaleKg_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtFullScale.MouseDown
        CallKeyboard2(sender, "30000", "-30000")
        Write_PLC_R1100(DAFullScaleIndex, Val(sender.Text))
        RaiseEvent CalXInput(True)
        SaveData()
    End Sub
    Public Sub WriteToPLC()
        Dim i As Integer
        'SaveData()
        For i = 0 To 4
            Write_PLC_R1100(DAPressCalXIndex + i, CalDataX(i + 1))
            Write_PLC_R1100(DAPressCalYIndex + i, CalDataY(i + 1))
        Next
        Write_PLC_R1100(DAFullScaleIndex, FullScale)
    End Sub


    Private Sub WriteData()

        'txtX1.Text = Format(CalDataX(1), "0")
        'txtX2.Text = Format(CalDataX(2), "0")
        'txtX3.Text = Format(CalDataX(3), "0")
        'txtX4.Text = Format(CalDataX(4), "0")
        'txtX5.Text = Format(CalDataX(5), "0")

        'txtY1.Text = Format(CalDataY(1), "0")
        'txtY2.Text = Format(CalDataY(2), "0")
        'txtY3.Text = Format(CalDataY(3), "0")
        'txtY4.Text = Format(CalDataY(4), "0")
        'txtY5.Text = Format(CalDataY(5), "0")

    End Sub
    Public Sub SaveData()
        FormTextBoxSave.FindTextBox(Me, Me.Name, FormSaveINIFile)

        CalDataX(0) = 0
        CalDataX(1) = Val(txtX1.Text)
        CalDataX(2) = Val(txtX2.Text)
        CalDataX(3) = Val(txtX3.Text)
        CalDataX(4) = Val(txtX4.Text)
        CalDataX(5) = Val(txtX5.Text)
        CalDataX(6) = 30000

        CalDataY(0) = 0
        CalDataY(1) = Val(txtY1.Text)
        CalDataY(2) = Val(txtY2.Text)
        CalDataY(3) = Val(txtY3.Text)
        CalDataY(4) = Val(txtY4.Text)
        CalDataY(5) = Val(txtY5.Text)
        CalDataY(6) = 30000

        FullScale = Val(txtFullScale.Text)
        WriteCalData(IniFile)
    End Sub

    '傳回校正後數值
    'GetCalibratedTemp(未校正前數值,校正後序列,校正前序列,點數)
    Private Function GetCalibratedTemp(ByVal temp As Double, ByVal tempx() As Integer, ByVal tempy() As Integer, ByVal point As Integer) As Double
        Dim i As Integer

        Dim im, c As Double
        '點數小於2, 傳回原數值
        If point < 2 Then Return temp
        '數值超過範圍則傳回原數值
        If temp < tempy(0) Or temp > tempy(point + 1) Then Return temp
        '找數值在數列中之範圍位置
        For i = 0 To point
            '通過原點之線性方程式為 y=mx, 則校正過之 X值= y/m, im= 1/m, im為 m 之倒數
            '假設 tempx(i),tempy(i) 為原點
            '則新的點為 (tempx(i + 1) - tempx(i)),(tempy(i + 1) - tempy(i))
            If temp >= tempx(i) And temp < tempx(i + 1) Then
                im = (tempy(i + 1) - tempy(i)) / (tempx(i + 1) - tempx(i))
                Return tempy(i) + (temp - tempx(i)) * im
            End If
        Next
        '若到這一步表示數值不在範圍內
        Return temp
    End Function
    '寫入校正後溫度
    'SetCalibratedTemp(溫度,校正後序列,校正前序列,點數)
    Private Function SetCalibratedTemp(ByVal temp As Double, ByVal tempx() As Integer, ByVal tempy() As Integer, ByVal point As Integer) As Double
        Dim i As Integer

        Dim im, c As Double
        '點數小於2, 傳回原數值
        If point < 2 Then Return temp
        '數值超過範圍則傳回原數值
        If temp < tempy(0) Or temp > tempy(point + 1) Then Return temp
        '找數值在數列中之範圍位置
        For i = 0 To point
            '通過原點之線性方程式為 y=mx, 則校正過之 X值= y/m, im= 1/m, im為 m 之倒數
            '假設 tempx(i),tempy(i) 為原點
            '則新的點為 (tempx(i + 1) - tempx(i)),(tempy(i + 1) - tempy(i))
            If temp >= tempy(i) And temp < tempy(i + 1) Then
                im = (tempy(i + 1) - tempy(i)) / (tempx(i + 1) - tempx(i))
                Return tempx(i) + (temp - tempy(i)) / im
            End If
        Next

        '若到這一步表示數值不在範圍內
        Return temp
    End Function

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Run()
    End Sub
    Public Sub Run()
        OriginalPress = Get_PLC_R1000(ADOriginalPressIndex)
        OriginalPressAD = Get_PLC_R1000(ADOriginalPressAD)
        CaledPress = Get_PLC_R1000(ADCaledPressIndex) 'GetCalibratedTemp(iOriginalPress, CalDataX, CalDataY, 5)
        ScaleValue = Get_PLC_R1000(ADScalerValueIndex)

        lblCaledValue.Text = CaledPress.ToString
        lblOriginValue.Text = OriginalPress.ToString
        lblRealPressureAD.Text = OriginalPressAD.ToString
        lblPressureVoltage.Text = Format(OriginalPressAD / 819, "0.000")
        lblScaleValue.Text = ScaleValue.ToString

        ObjShow.Show(PLC_M(DoPlateUpIndex) = "1", btnPlateUp, ColorOn, ColorOff)
        ObjShow.Show(PLC_M(DoPlateDownIndex) = "1", btnPlateDown, ColorOn, ColorOff)

        CheckButtonVisible(CelloUsbFlag, btnReset)

        txtFullScale.Text = Get_PLC_R1100(DAFullScaleIndex).ToString
        If DAPressCalXIndex = DAPressureCal1XIndex Then 'By chesly fixed 20181008
            txtX1.Text = Get_PLC_R1100(DAPressCalXIndex)
            txtX2.Text = Get_PLC_R1100(DAPressCalXIndex + 1)
            txtX3.Text = Get_PLC_R1100(DAPressCalXIndex + 2)
            txtX4.Text = Get_PLC_R1100(DAPressCalXIndex + 3)
            txtX5.Text = Get_PLC_R1100(DAPressCalXIndex + 4)
        End If

        txtY1.Text = Get_PLC_R1100(DAPressCalYIndex)
        txtY2.Text = Get_PLC_R1100(DAPressCalYIndex + 1)
        txtY3.Text = Get_PLC_R1100(DAPressCalYIndex + 2)
        txtY4.Text = Get_PLC_R1100(DAPressCalYIndex + 3)
        txtY5.Text = Get_PLC_R1100(DAPressCalYIndex + 4)
        If boltemp Then
            'Debug.Print("Read PLC")
            boltemp = False
        End If
    End Sub

    Private Sub CheckButtonVisible(ByVal cond As Boolean, ByRef obj As Button)
        If cond Then
            If obj.Visible = False Then
                obj.Visible = True
            End If
        Else
            If obj.Visible = True Then
                obj.Visible = False
            End If
        End If
    End Sub


    Public Sub WriteCalData(ByVal sfile As String)
        Dim i As Integer
        i = SiteNum + 1
        WriteProgData(Section, SiteName + Format(i, "00") + "_Y01", txtY1.Text, sfile)
        WriteProgData(Section, SiteName + Format(i, "00") + "_Y02", txtY2.Text, sfile)
        WriteProgData(Section, SiteName + Format(i, "00") + "_Y03", txtY3.Text, sfile)
        WriteProgData(Section, SiteName + Format(i, "00") + "_Y04", txtY4.Text, sfile)
        WriteProgData(Section, SiteName + Format(i, "00") + "_Y05", txtY5.Text, sfile)

        WriteProgData(Section, SiteName + Format(i, "00") + "_X01", txtX1.Text, sfile)
        WriteProgData(Section, SiteName + Format(i, "00") + "_X02", txtX2.Text, sfile)
        WriteProgData(Section, SiteName + Format(i, "00") + "_X03", txtX3.Text, sfile)
        WriteProgData(Section, SiteName + Format(i, "00") + "_X04", txtX4.Text, sfile)
        WriteProgData(Section, SiteName + Format(i, "00") + "_X05", txtX5.Text, sfile)

        WriteProgData(Section, SiteName + Format(i, "00") + "_FULLSCALE", FullScale.ToString, sfile)
    End Sub
    Public Sub ReadCalData(ByVal sfile As String)
        Dim i As Integer
        i = SiteNum + 1
        'txtY1.Text = ReadProgData(Section, SiteName + Format(i, "00") + "_Y01", "50", sfile)
        'txtY2.Text = ReadProgData(Section, SiteName + Format(i, "00") + "_Y02", "100", sfile)
        'txtY3.Text = ReadProgData(Section, SiteName + Format(i, "00") + "_Y03", "150", sfile)
        'txtY4.Text = ReadProgData(Section, SiteName + Format(i, "00") + "_Y04", "200", sfile)
        'txtY5.Text = ReadProgData(Section, SiteName + Format(i, "00") + "_Y05", "250", sfile)

        'txtX1.Text = ReadProgData(Section, SiteName + Format(i, "00") + "_X01", "50", sfile)
        'txtX2.Text = ReadProgData(Section, SiteName + Format(i, "00") + "_X02", "100", sfile)
        'txtX3.Text = ReadProgData(Section, SiteName + Format(i, "00") + "_X03", "150", sfile)
        'txtX4.Text = ReadProgData(Section, SiteName + Format(i, "00") + "_X04", "200", sfile)
        'txtX5.Text = ReadProgData(Section, SiteName + Format(i, "00") + "_X05", "250", sfile)

        FullScale = Val(ReadProgData(Section, SiteName + Format(i, "00") + "_FULLSCALE", "15000", sfile))
        'SaveData() 'By Chesly 20180702
    End Sub

    Private Sub btnPlateUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlateUp.Click
        BondCycleStop(grpPressCalTitle.Text) 'By chesly 20181023 壓缸自動循環動作
        If ProcessMode_RUN Then Exit Sub
        If Output(DoPlateUpIndex).Status Then
            Output(DoPlateUpIndex).Status = False
        Else
            If Check_PLC_X(DiDoor1UpIndex) = False Or Check_PLC_X(DiDoor2UpIndex) = False Then
                MsgBoxLangErr("腔門未關閉,請關閉腔門!", "Door not Close!")
            Else
                If OilPumpEnable Then
                    If Check_PLC_M(DoOilPumpIndex) Then
                        If MsgBoxLangYesNo("請確認載盤已置放!", "Please Cormfirm Plate Up!") Then
                            Output(DoPlateUpIndex).Status = True
                            Output(DoPlateDownIndex).Status = False
                        End If
                    Else
                        MsgBoxLangErr("油壓幫浦未啟動!", "Oil Pump need ON!")
                    End If
                Else
                    If MsgBoxLangYesNo("請確認載盤已置放!", "Please Cormfirm Plate Up!") Then
                        Output(DoPlateUpIndex).Status = True
                        Output(DoPlateDownIndex).Status = False
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub btnPlateDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlateDown.Click
        BondCycleStop(grpPressCalTitle.Text) 'By chesly 20181023 壓缸自動循環動作
        If ProcessMode_RUN Then Exit Sub
        If Output(DoPlateDownIndex).Status Then
            Output(DoPlateDownIndex).Status = False
        Else
            If OilPumpEnable Then
                If Check_PLC_M(DoOilPumpIndex) Then
                    Output(DoPlateDownIndex).Status = True
                    Output(DoPlateUpIndex).Status = False
                Else
                    MsgBoxLangErr("油壓幫浦未啟動!", "Oil Pump need ON!")
                End If
            Else
                Output(DoPlateDownIndex).Status = True
                Output(DoPlateUpIndex).Status = False
            End If
        End If
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        If MsgBoxLangYesNo("重新設定預設校正值?", "Load Default Value?") Then
            Dim i As Integer
            txtY1.Text = "500"
            txtY2.Text = "4000"
            txtY3.Text = "8000"
            txtY4.Text = "12000"
            txtY5.Text = "15000"

            txtX1.Text = "500"
            txtX2.Text = "4000"
            txtX3.Text = "8000"
            txtX4.Text = "12000"
            txtX5.Text = "15000"
            SaveData()
            RaiseEvent CalXInput(True)
            WriteToPLC()
            WriteCalData(IniFile)
        Else
            MsgBoxLangErr("未載入!", "Not loaded!.")
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
End Class

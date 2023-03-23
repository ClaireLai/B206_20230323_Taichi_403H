Imports System.Drawing
Public Class ControlTempCal
    Private Const MAXPOINT As Integer = 6
    Private CalTopX(MAXPOINT) As Integer
    Private CalTopY(MAXPOINT) As Integer
    Private CalBotX(MAXPOINT) As Integer
    Private CalBotY(MAXPOINT) As Integer
    Private ModifiedFlag As Boolean
    Private iOriginalTopTemp As Integer
    Private iCaledTopTemp As Integer
    Private iOriginalBotTemp As Integer
    Private iCaledBotTemp As Integer
    '
    Private SiteNum As Integer

    Public TopHeaterStatus As Boolean
    Public BoteaterStatus As Boolean
    '設定 加熱器開關的輸出點
    Private DoTopHeaterIndex As Integer
    Private DoBotHeaterIndex As Integer
    '設定 加熱器溫度讀取暫存器
    Private ADTopHeaterIndex As Integer
    Private ADBotHeaterIndex As Integer
    '設定 加熱器溫度設定暫存器
    Private DATopHeaterIndex As Integer
    Private DABotHeaterIndex As Integer

    Private IniFile As String
    Private SiteName As String
    Private Section As String

    Private DisableXValue As Boolean
    Public Event CalXInput(ByVal bStatus As Boolean)
    Public Event CalYTopInput(ByVal bStatus As Boolean)
    Public Event CalYBotInput(ByVal bStatus As Boolean)

    Public Sub New()
        ' 此為 Windows Form 設計工具所需的呼叫。
        InitializeComponent()

        ' 在 InitializeComponent() 呼叫之後加入任何初始設定。
    End Sub
    Public Sub Initial(ByVal iSiteNum As Integer, ByVal DoIndex As Integer, ByVal ADTopIndex As Integer, ByVal ADBotIndex As Integer) ', ByVal DATopIndex As Integer, ByVal DABotIndex As Integer)
        Dim i As Integer
        SiteNum = iSiteNum
        For i = 0 To MAXPOINT
            CalTopX(i) = 50 * i
            CalTopY(i) = 50 * i
            CalBotX(i) = 50 * i
            CalBotY(i) = 50 * i
        Next

        DoTopHeaterIndex = DoIndex
        ADTopHeaterIndex = ADTopIndex
        ADBotHeaterIndex = ADBotIndex
        'DATopHeaterIndex = DATopIndex
        'DABotHeaterIndex = DABotIndex

        IniFile = ParameterINIFile
        Section = "HEATER_SETUP"
        SiteName = "SITE"
        ReadCalDate(IniFile)
        'WriteCalDate(IniFile)
        Timer1.Interval = 500
        Timer1.Enabled = True
    End Sub
    'Add  by Vincent 20180419  ------------------- Start
    Property CalTableDiff As Boolean
    Private Sub CheckCalTempTable()
        Dim i As Integer
        Dim Count As Integer = 0
        For i = 1 To 5
            If CalTopY(1) <> CalBotY(1) Then
                Count += 1
            End If
        Next
        CalTableDiff = (Count > 0)
    End Sub
    'Add  by Vincent 20180419  ------------------- End

    Property Modified() As Boolean
        Get
            Return grpTitle.Text
        End Get
        Set(ByVal value As Boolean)
            grpTitle.Text = value
        End Set
    End Property
    Property Title() As String
        Get
            Return grpTitle.Text
        End Get
        Set(ByVal value As String)
            grpTitle.Text = value
        End Set
    End Property
    Property OriginalTopTemp() As Integer
        Get
            Return iOriginalTopTemp
        End Get
        Set(ByVal value As Integer)
            iOriginalTopTemp = value
        End Set
    End Property
    Property OriginalBotTemp() As Integer
        Get
            Return iOriginalTopTemp
        End Get
        Set(ByVal value As Integer)
            iOriginalBotTemp = value
        End Set
    End Property
    Property CaledTopTemp() As Integer
        Get
            Return iCaledTopTemp
        End Get
        Set(ByVal value As Integer)
            iCaledTopTemp = value
        End Set
    End Property
    Property CaledBotTemp() As Integer
        Get
            Return iCaledBotTemp
        End Get
        Set(ByVal value As Integer)
            iCaledBotTemp = value
        End Set
    End Property
    WriteOnly Property EnableXInput() As Boolean
        Set(ByVal value As Boolean)
            Dim i As Integer
            DisableXValue = value
            txtTempX1.Enabled = value
            txtTempX2.Enabled = value
            txtTempX3.Enabled = value
            txtTempX4.Enabled = value
            txtTempX5.Enabled = value
        End Set
    End Property

    Public Sub SetValue(ByVal TopTempX() As Integer, ByVal TopTempY() As Integer, ByVal BotTempX() As Integer, ByVal BotTempY() As Integer)
        Dim i As Integer
        For i = 0 To MAXPOINT
            CalTopX(i) = TopTempX(i)
            CalTopY(i) = TopTempY(i)
            CalBotX(i) = BotTempX(i)
            CalBotY(i) = BotTempY(i)
        Next
        WriteData()
    End Sub

    Public Sub ReadValue(ByRef TopTempX() As Integer, ByRef TopTempY() As Integer, ByRef BotTempX() As Integer, ByRef BotTempY() As Integer)
        Dim i As Integer
        For i = 0 To MAXPOINT
            TopTempX(i) = CalTopX(i)
            TopTempY(i) = CalTopY(i)
            BotTempX(i) = CalBotX(i)
            BotTempX(i) = CalBotY(i)
        Next
    End Sub

    Private Sub txtTempX1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles _
                     txtTempX1.MouseDown, txtTempX2.MouseDown, txtTempX3.MouseDown, txtTempX4.MouseDown, txtTempX5.MouseDown
        CallKeyboard2(sender, NORMAL_MAX, NORMAL_MIN)
        If Val(sender.text) > 0 Then
            SaveData()
            lblTopTestCaledValue.Text = Format(SetCalibratedTemp(Val(txtTopTestValueInput.Text), CalTopX, CalTopY, 5), "0")
            lblBotTestCaledValue.Text = Format(SetCalibratedTemp(Val(txtBotTestValueInput.Text), CalBotX, CalBotY, 5), "0")
            RaiseEvent CalXInput(True)
        End If
    End Sub

    Private Sub txtTopTempY1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles _
                    txtTopTempY1.MouseDown, txtTopTempY2.MouseDown, txtTopTempY3.MouseDown, txtTopTempY4.MouseDown, txtTopTempY5.MouseDown, _
                    txtBotTempY1.MouseDown, txtBotTempY5.MouseDown, txtBotTempY2.MouseDown, txtBotTempY4.MouseDown, txtBotTempY3.MouseDown
        CallKeyboard2(sender, NORMAL_MAX, NORMAL_MIN)
        If Val(sender.text) > 0 Then
            SaveData()
            lblTopTestCaledValue.Text = Format(SetCalibratedTemp(Val(txtTopTestValueInput.Text), CalTopX, CalTopY, 5), "0")
            lblBotTestCaledValue.Text = Format(SetCalibratedTemp(Val(txtBotTestValueInput.Text), CalBotX, CalBotY, 5), "0")

        End If
    End Sub

    Private Sub WriteData()

        txtTempX1.Text = Format(CalTopX(1), "0")
        txtTempX2.Text = Format(CalTopX(2), "0")
        txtTempX3.Text = Format(CalTopX(3), "0")
        txtTempX4.Text = Format(CalTopX(4), "0")
        txtTempX5.Text = Format(CalTopX(5), "0")

        txtTopTempY1.Text = Format(CalTopY(1), "0")
        txtTopTempY2.Text = Format(CalTopY(2), "0")
        txtTopTempY3.Text = Format(CalTopY(3), "0")
        txtTopTempY4.Text = Format(CalTopY(4), "0")
        txtTopTempY5.Text = Format(CalTopY(5), "0")

        txtTempX1.Text = Format(CalBotX(1), "0")
        txtTempX2.Text = Format(CalBotX(2), "0")
        txtTempX3.Text = Format(CalBotX(3), "0")
        txtTempX4.Text = Format(CalBotX(4), "0")
        txtTempX5.Text = Format(CalBotX(5), "0")

        txtBotTempY1.Text = Format(CalBotY(1), "0")
        txtBotTempY2.Text = Format(CalBotY(2), "0")
        txtBotTempY3.Text = Format(CalBotY(3), "0")
        txtBotTempY4.Text = Format(CalBotY(4), "0")
        txtBotTempY5.Text = Format(CalBotY(5), "0")

    End Sub
    Public Sub SaveData()
        CalTopX(0) = 0
        CalTopX(1) = Val(txtTempX1.Text)
        CalTopX(2) = Val(txtTempX2.Text)
        CalTopX(3) = Val(txtTempX3.Text)
        CalTopX(4) = Val(txtTempX4.Text)
        CalTopX(5) = Val(txtTempX5.Text)
        CalTopX(6) = 2000

        CalTopY(0) = 0
        CalTopY(1) = Val(txtTopTempY1.Text)
        CalTopY(2) = Val(txtTopTempY2.Text)
        CalTopY(3) = Val(txtTopTempY3.Text)
        CalTopY(4) = Val(txtTopTempY4.Text)
        CalTopY(5) = Val(txtTopTempY5.Text)
        CalTopY(6) = 2000

        CalBotX(0) = 0
        CalBotX(1) = Val(txtTempX1.Text)
        CalBotX(2) = Val(txtTempX2.Text)
        CalBotX(3) = Val(txtTempX3.Text)
        CalBotX(4) = Val(txtTempX4.Text)
        CalBotX(5) = Val(txtTempX5.Text)
        CalBotX(6) = 2000

        CalBotY(0) = 0
        CalBotY(1) = Val(txtBotTempY1.Text)
        CalBotY(2) = Val(txtBotTempY2.Text)
        CalBotY(3) = Val(txtBotTempY3.Text)
        CalBotY(4) = Val(txtBotTempY4.Text)
        CalBotY(5) = Val(txtBotTempY5.Text)
        CalBotY(6) = 2000

        WriteCalDate(IniFile)
        FormTextBoxSave.FindTextBox(Me, Me.Name, FormSaveINIFile)

    End Sub

    Public Function UpdateTop(ByVal oTemp As Integer) As Integer
        iOriginalTopTemp = oTemp
        iCaledTopTemp = GetCalibratedTemp(iOriginalTopTemp, CalTopX, CalTopY, 5)
        Return iCaledTopTemp
    End Function
    Public Function UpdateBot(ByVal oTemp As Integer) As Integer
        iOriginalBotTemp = oTemp
        iCaledBotTemp = GetCalibratedTemp(iOriginalBotTemp, CalBotX, CalBotY, 5)
        Return iCaledBotTemp
    End Function

    '輸入溫度,取得要設定到溫控器的溫度值
    Public Function GetTICTopTemp(ByVal InputTemp As Integer) As Integer
        Dim SetTemp As Integer
        'txtTopTestValueInput.Text = InputTemp.ToString
        SetTemp = SetCalibratedTemp(InputTemp, CalTopX, CalTopY, 5)
        'lblTopTestCaledValue.Text = Format(SetTemp, "0")
        Return SetTemp
    End Function
    Public Function SetTICTopTemp(ByVal InputTemp As Integer) As Integer
        Dim SetTemp As Integer
        'txtTopTestValueInput.Text = InputTemp.ToString
        SetTemp = SetCalibratedTemp(InputTemp, CalTopY, CalTopX, 5)
        'lblTopTestCaledValue.Text = Format(SetTemp, "0")
        Return SetTemp
    End Function
    Public Function GetTICBotTemp(ByVal InputTemp As Integer) As Integer
        Dim SetTemp As Integer
        'txtBotTestValueInput.Text = InputTemp.ToString
        SetTemp = SetCalibratedTemp(InputTemp, CalBotX, CalBotY, 5)
        'lblBotTestCaledValue.Text = Format(SetTemp, "0")
        Return SetTemp
    End Function
    Public Function SetTICBotTemp(ByVal InputTemp As Integer) As Integer
        Dim SetTemp As Integer
        'txtBotTestValueInput.Text = InputTemp.ToString
        SetTemp = SetCalibratedTemp(InputTemp, CalBotY, CalBotX, 5)
        'lblBotTestCaledValue.Text = Format(SetTemp, "0")
        Return SetTemp
    End Function


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
        'Add  by Vincent 20180419  ------------------- Start
        CheckCalTempTable()
        'Add  by Vincent 20180419  ------------------- End
        iOriginalTopTemp = Get_PLC_R1000(ADTopHeaterIndex)
        iOriginalBotTemp = Get_PLC_R1000(ADBotHeaterIndex)
        iCaledTopTemp = GetCalibratedTemp(iOriginalTopTemp, CalTopX, CalTopY, 5)
        iCaledBotTemp = GetCalibratedTemp(iOriginalBotTemp, CalBotX, CalBotY, 5)
        If GetTrue01Boolean(SystemParameters.SplitTopBotTemp) = False Then
            iCaledBotTemp = GetCalibratedTemp(iOriginalBotTemp, CalTopX, CalTopY, 5)
        End If
        lblCaledTopTemp.Text = iCaledTopTemp.ToString
        lblCaledBotTemp.Text = iCaledBotTemp.ToString
        lblOriginTopTemp.Text = iOriginalTopTemp.ToString
        lblOriginBotTemp.Text = iOriginalBotTemp.ToString
        If Check_PLC_Y(DoTopHeaterIndex) Then
            btnHeaterON.BackColor = Color.Lime
        Else
            btnHeaterON.BackColor = SystemColors.Control
        End If
        CheckButtonVisible(CelloUsbFlag, btnReset)
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
    Public Sub Run(ByRef TopT As Integer, ByRef BotT As Integer)
        iOriginalTopTemp = Get_PLC_R1000(ADTopHeaterIndex)
        iOriginalBotTemp = Get_PLC_R1000(ADBotHeaterIndex)
        iCaledTopTemp = GetCalibratedTemp(iOriginalTopTemp, CalTopX, CalTopY, 5)
        iCaledBotTemp = GetCalibratedTemp(iOriginalBotTemp, CalBotX, CalBotY, 5)
        If GetTrue01Boolean(SystemParameters.SplitTopBotTemp) = False Then
            iCaledBotTemp = GetCalibratedTemp(iOriginalBotTemp, CalTopX, CalTopY, 5)
        End If
        TopT = iCaledTopTemp
        BotT = iCaledBotTemp
        lblCaledTopTemp.Text = iCaledTopTemp.ToString
        lblCaledBotTemp.Text = iCaledBotTemp.ToString
        lblOriginTopTemp.Text = iOriginalTopTemp.ToString
        lblOriginBotTemp.Text = iOriginalBotTemp.ToString
        If Check_PLC_Y(DoTopHeaterIndex) Then
            btnHeaterON.BackColor = Color.Lime
        Else
            btnHeaterON.BackColor = SystemColors.Control
        End If
    End Sub


    Private Sub txtTopTestValueInput_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtTopTestValueInput.MouseDown
        CallKeyboard2(sender, NORMAL_MAX, NORMAL_MIN)
        If Val(sender.text) > 0 Then
            lblTopTestCaledValue.Text = Format(SetCalibratedTemp(Val(sender.text), CalTopX, CalTopY, 5), "0")
        End If
    End Sub
    Private Sub txtBotTestValueInput_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtBotTestValueInput.MouseDown
        CallKeyboard2(sender, NORMAL_MAX, NORMAL_MIN)
        If Val(sender.text) > 0 Then
            lblBotTestCaledValue.Text = Format(SetCalibratedTemp(Val(sender.text), CalBotX, CalBotY, 5), "0")
        End If
    End Sub

    Private Sub btnHeaterON_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHeaterON.Click
        Output(DoTopHeaterIndex).Status = Not Output(DoTopHeaterIndex).Status
        ''TopHeaterStatus = Not TopHeaterStatus
        'If Output(DoTopHeaterIndex).Status Then
        '    'Set_MBit(DoTopHeaterIndex, DEVICE_ON)
        '    Write_PLC_R1100(DATopHeaterIndex, Val(txtTopTestValueInput.Text))
        '    Write_PLC_R1100(DABotHeaterIndex, Val(txtTopTestValueInput.Text))
        'Else
        '    'Set_MBit(DoTopHeaterIndex, DEVICE_OFF)
        'End If
    End Sub
    Private Sub btnSetY1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetY1.Click
        txtTopTempY1.Text = Get_PLC_R1000(ADTopHeaterIndex.ToString)
        txtBotTempY1.Text = Get_PLC_R1000(ADBotHeaterIndex.ToString)
    End Sub
    Private Sub btnSetY2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetY2.Click
        txtTopTempY2.Text = Get_PLC_R1000(ADTopHeaterIndex.ToString)
        txtBotTempY2.Text = Get_PLC_R1000(ADBotHeaterIndex.ToString)
    End Sub

    Private Sub btnSetY3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetY3.Click
        txtTopTempY3.Text = Get_PLC_R1000(ADTopHeaterIndex.ToString)
        txtBotTempY3.Text = Get_PLC_R1000(ADBotHeaterIndex.ToString)
    End Sub

    Private Sub btnSetY4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetY4.Click
        txtTopTempY4.Text = Get_PLC_R1000(ADTopHeaterIndex.ToString)
        txtBotTempY4.Text = Get_PLC_R1000(ADBotHeaterIndex.ToString)
    End Sub

    Private Sub btnSetY5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetY5.Click
        txtTopTempY5.Text = Get_PLC_R1000(ADTopHeaterIndex.ToString)
        txtBotTempY5.Text = Get_PLC_R1000(ADBotHeaterIndex.ToString)
    End Sub
    Public Sub WriteCalDate(ByVal sfile As String)
        Dim i As Integer
        i = SiteNum + 1
        WriteProgData(Section, SiteName + Format(i, "00") + "_TOP_Y01", txtTopTempY1.Text, sfile)
        WriteProgData(Section, SiteName + Format(i, "00") + "_TOP_Y02", txtTopTempY2.Text, sfile)
        WriteProgData(Section, SiteName + Format(i, "00") + "_TOP_Y03", txtTopTempY3.Text, sfile)
        WriteProgData(Section, SiteName + Format(i, "00") + "_TOP_Y04", txtTopTempY4.Text, sfile)
        WriteProgData(Section, SiteName + Format(i, "00") + "_TOP_Y05", txtTopTempY5.Text, sfile)

        WriteProgData(Section, SiteName + Format(i, "00") + "_BOT_Y01", txtBotTempY1.Text, sfile)
        WriteProgData(Section, SiteName + Format(i, "00") + "_BOT_Y02", txtBotTempY2.Text, sfile)
        WriteProgData(Section, SiteName + Format(i, "00") + "_BOT_Y03", txtBotTempY3.Text, sfile)
        WriteProgData(Section, SiteName + Format(i, "00") + "_BOT_Y04", txtBotTempY4.Text, sfile)
        WriteProgData(Section, SiteName + Format(i, "00") + "_BOT_Y05", txtBotTempY5.Text, sfile)

        WriteProgData(Section, SiteName + Format(i, "00") + "_X01", txtTempX1.Text, sfile)
        WriteProgData(Section, SiteName + Format(i, "00") + "_X02", txtTempX2.Text, sfile)
        WriteProgData(Section, SiteName + Format(i, "00") + "_X03", txtTempX3.Text, sfile)
        WriteProgData(Section, SiteName + Format(i, "00") + "_X04", txtTempX4.Text, sfile)
        WriteProgData(Section, SiteName + Format(i, "00") + "_X05", txtTempX5.Text, sfile)
    End Sub
    Public Sub ReadCalDate(ByVal sfile As String)
        Dim i As Integer
        i = SiteNum + 1
        txtTopTempY1.Text = ReadProgData(Section, SiteName + Format(i, "00") + "_TOP_Y01", "100", sfile)
        txtTopTempY2.Text = ReadProgData(Section, SiteName + Format(i, "00") + "_TOP_Y02", "200", sfile)
        txtTopTempY3.Text = ReadProgData(Section, SiteName + Format(i, "00") + "_TOP_Y03", "300", sfile)
        txtTopTempY4.Text = ReadProgData(Section, SiteName + Format(i, "00") + "_TOP_Y04", "400", sfile)
        txtTopTempY5.Text = ReadProgData(Section, SiteName + Format(i, "00") + "_TOP_Y05", "500", sfile)

        txtBotTempY1.Text = ReadProgData(Section, SiteName + Format(i, "00") + "_BOT_Y01", "100", sfile)
        txtBotTempY2.Text = ReadProgData(Section, SiteName + Format(i, "00") + "_BOT_Y02", "200", sfile)
        txtBotTempY3.Text = ReadProgData(Section, SiteName + Format(i, "00") + "_BOT_Y03", "300", sfile)
        txtBotTempY4.Text = ReadProgData(Section, SiteName + Format(i, "00") + "_BOT_Y04", "400", sfile)
        txtBotTempY5.Text = ReadProgData(Section, SiteName + Format(i, "00") + "_BOT_Y05", "500", sfile)

        txtTempX1.Text = ReadProgData(Section, SiteName + Format(i, "00") + "_X01", "100", sfile)
        txtTempX2.Text = ReadProgData(Section, SiteName + Format(i, "00") + "_X02", "200", sfile)
        txtTempX3.Text = ReadProgData(Section, SiteName + Format(i, "00") + "_X03", "300", sfile)
        txtTempX4.Text = ReadProgData(Section, SiteName + Format(i, "00") + "_X04", "400", sfile)
        txtTempX5.Text = ReadProgData(Section, SiteName + Format(i, "00") + "_X05", "500", sfile)
        SaveData()
    End Sub


    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        If MsgBoxLangYesNo("重新設定預設校正值?", "Load Default Value?") Then
            Dim i As Integer
            txtTopTempY1.Text = "100"
            txtTopTempY2.Text = "200"
            txtTopTempY3.Text = "300"
            txtTopTempY4.Text = "400"
            txtTopTempY5.Text = "500"

            txtBotTempY1.Text = "100"
            txtBotTempY2.Text = "200"
            txtBotTempY3.Text = "300"
            txtBotTempY4.Text = "400"
            txtBotTempY5.Text = "500"

            txtTempX1.Text = "100"
            txtTempX2.Text = "200"
            txtTempX3.Text = "300"
            txtTempX4.Text = "400"
            txtTempX5.Text = "500"

            SaveData()
            RaiseEvent CalXInput(True)

        Else
            MsgBoxLangErr("未載入!", "Not loaded!.")
        End If
    End Sub
End Class

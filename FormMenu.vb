Public Class FormMenu
    Public Const MENU_PROCESS As Integer = 1
    Public Const MENU_RECIPE As Integer = 2
    Public Const MENU_MANUAL As Integer = 3
    Public Const MENU_ALARM As Integer = 4
    Public Const MENU_RECORD As Integer = 5
    Public Const MENU_PARAMETER As Integer = 6
    Public Const MENU_LOGINSETUP As Integer = 7
    Public Const MENU_MAINTANCE As Integer = 8
    Public CurrentMenuIndex, LastMenuIndex As Integer
    Public FormPtr() As Form
    Public ButtonPtr() As Button
    Private X As Single '當前窗體的寬度
    Private Y As Single '當前窗體的高度
    Private isLoaded As Boolean '// 是否已設定各控制的尺寸資料到Tag屬性
    Private FormW As Integer
    Private FormH As Integer
    Dim size As Size


    Public Sub New()

        ' 設計工具需要此呼叫。
        InitializeComponent()

        ' 在 InitializeComponent() 呼叫之後加入所有初始設定。
        isLoaded = False
        ImageList1.Images.Clear()
    End Sub

    Private Sub MenuForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If DesignMode Then Exit Sub
        Me.Top = 0
        Me.Left = 0
        ReDim FormPtr(8)
        FormPtr(MENU_PROCESS) = FormProcesss
        FormPtr(MENU_RECIPE) = FormRecipes
        FormPtr(MENU_MANUAL) = FormManuals
        FormPtr(MENU_ALARM) = FormAlarms
        FormPtr(MENU_RECORD) = FormRecords
        FormPtr(MENU_PARAMETER) = FormParameters
        FormPtr(MENU_LOGINSETUP) = FormLoginSetups
        FormPtr(MENU_MAINTANCE) = FormMaintances

        ReDim ButtonPtr(8)
        ButtonPtr(MENU_PROCESS) = btnProcess
        ButtonPtr(MENU_RECIPE) = btnProcessPara
        ButtonPtr(MENU_MANUAL) = BtnTest
        ButtonPtr(MENU_ALARM) = btnAlarm
        ButtonPtr(MENU_RECORD) = btnRecord
        ButtonPtr(MENU_PARAMETER) = btnParameter
        ButtonPtr(MENU_LOGINSETUP) = btnFormLoginsetup
        ButtonPtr(MENU_MAINTANCE) = btnMaintance

        CurrentMenuIndex = 1
        LastMenuIndex = 1
        'SetActiveButton(CurrentMenuIndex, Color.FromArgb(255, 192, 192), Color.FromArgb(255, 255, 192))
        Timer1.Interval = 1000
        Timer1.Enabled = True
        X = Me.Width '獲取窗體的寬度
        Y = Me.Height '獲取窗體的高度
        isLoaded = True '已設定各控制項的尺寸到Tag屬性中
        SetTag(Me) '調用方法
        Debug.Print("FormManu_Load")
    End Sub
    Public Sub SetActiveButton(ByVal index As Integer, ByVal oncolor As Color, ByVal offcolor As Color)
        Dim i As Integer
        For i = FORM_MENU.PROCESS To FORM_MENU.MAINTANCE
            ButtonPtr(i).BackColor = offcolor
            'ButtonPtr(i).Image = Resize_Image(My.Resources.button, size)
            ButtonPtr(i).BackgroundImage = ImageList1.Images(1)
        Next
        'ButtonPtr(index).Image = Resize_Image(My.Resources.buttonRed, size)
        ButtonPtr(index).BackgroundImage = ImageList1.Images(0)
        ButtonPtr(index).BackColor = oncolor

    End Sub

    'Public Sub SetActiveButton(ByVal index As Integer, ByVal ON_String As String, ByVal OFF_String As String)
    '    Dim i As Integer
    '    For i = FORM_MENU.PROCESS To FORM_MENU.MAINTANCE
    '        'ButtonPtr(i).Image = Resize_Image(My.Resources.button, size)
    '        ButtonPtr(i).Image = ImageList1.Images(1)
    '    Next
    '    'ButtonPtr(index).Image = Resize_Image(My.Resources.buttonRed, size)
    '    ButtonPtr(i).Image = ImageList1.Images(0)
    'End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        On Error Resume Next
        For i As Byte = 1 To 8
            FormPtr(i).Hide()
        Next
        CurrentMenuIndex = FORM_MENU.PROCESS
        LastMenuIndex = FORM_MENU.PROCESS
        SetActiveButton(CurrentMenuIndex, Color.FromArgb(255, 192, 192), Color.FromArgb(255, 255, 192))
        AppendMultiData(OperatorRecordFileName, 40, LoginUserName, "   ==>Logout", ADate, TTime)
        Me.Hide()
        Form1s.Show()
    End Sub
    Enum FORM_MENU
        PROCESS = 1
        RECIPE = 2
        MANUAL = 3
        ALARM = 4
        RECORD = 5
        PARAMETER = 6
        AUTHORITY = 7
        MAINTANCE = 8
    End Enum

    Private Sub btnProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcess.Click
        ChangeForm(FORM_MENU.PROCESS)
        FormProcesss.Refresh()
        'CurrentMenuIndex = 1
        'SetActiveButton(CurrentMenuIndex, Color.FromArgb(255, 192, 192), Color.FromArgb(255, 255, 192))
        'If CurrentMenuIndex <> LastMenuIndex Then
        '    FormPtr(CurrentMenuIndex).Show()
        '    FormPtr(LastMenuIndex).Hide()
        '    LastMenuIndex = CurrentMenuIndex
        'End If
    End Sub

    Private Sub btnProcessPara_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcessPara.Click
        ChangeForm(FORM_MENU.RECIPE)

        'CurrentMenuIndex = 2
        'SetActiveButton(CurrentMenuIndex, Color.FromArgb(255, 192, 192), Color.FromArgb(255, 255, 192))
        'If CurrentMenuIndex <> LastMenuIndex Then
        '    FormPtr(CurrentMenuIndex).Show()
        '    FormPtr(LastMenuIndex).Hide()
        '    LastMenuIndex = CurrentMenuIndex
        'End If

    End Sub

    Private Sub BtnTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTest.Click
        'CurrentMenuIndex = 3
        'SetActiveButton(CurrentMenuIndex, Color.FromArgb(255, 192, 192), Color.FromArgb(255, 255, 192))
        'If CurrentMenuIndex <> LastMenuIndex Then

        '    FormPtr(CurrentMenuIndex).Show()
        '    FormPtr(LastMenuIndex).Hide()
        '    LastMenuIndex = CurrentMenuIndex
        'End If
        Dim km As Integer
        For km = 0 To 95
            Y_Changed(km) = True
        Next km
        For km = 0 To 95
            X_Changed(km) = True
        Next km
        ChangeForm(FORM_MENU.MANUAL)

    End Sub

    Private Sub btnAlarm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlarm.Click
        ChangeForm(FORM_MENU.ALARM)

        'CurrentMenuIndex = 4
        'SetActiveButton(CurrentMenuIndex, Color.FromArgb(255, 192, 192), Color.FromArgb(255, 255, 192))
        'If CurrentMenuIndex <> LastMenuIndex Then
        '    FormAlarms.Timer1.Enabled = True
        '    FormPtr(CurrentMenuIndex).Show()
        '    FormPtr(LastMenuIndex).Hide()
        '    LastMenuIndex = CurrentMenuIndex
        'End If
    End Sub

    Private Sub btnRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecord.Click
        ChangeForm(FORM_MENU.RECORD)

        'CurrentMenuIndex = 5
        'SetActiveButton(CurrentMenuIndex, Color.FromArgb(255, 192, 192), Color.FromArgb(255, 255, 192))
        'If CurrentMenuIndex <> LastMenuIndex Then
        '    FormPtr(CurrentMenuIndex).Show()
        '    FormPtr(LastMenuIndex).Hide()
        '    LastMenuIndex = CurrentMenuIndex
        'End If
    End Sub

    Private Sub btnParameter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnParameter.Click
        ChangeForm(FORM_MENU.PARAMETER)

        'CurrentMenuIndex = 6
        'SetActiveButton(CurrentMenuIndex, Color.FromArgb(255, 192, 192), Color.FromArgb(255, 255, 192))
        'If CurrentMenuIndex <> LastMenuIndex Then
        '    FormPtr(CurrentMenuIndex).Show()
        '    FormPtr(LastMenuIndex).Hide()
        '    LastMenuIndex = CurrentMenuIndex
        'End If
    End Sub

    Private Sub btnFormLoginsetup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFormLoginsetup.Click
        ChangeForm(FORM_MENU.AUTHORITY)

        'CurrentMenuIndex = 7
        'SetActiveButton(CurrentMenuIndex, Color.FromArgb(255, 192, 192), Color.FromArgb(255, 255, 192))
        'If CurrentMenuIndex <> LastMenuIndex Then
        '    ReadUserRightsFile(UserDataFileName, UserRights)  '讀取使用者資料設定檔
        '    FormPtr(CurrentMenuIndex).Show()
        '    FormPtr(LastMenuIndex).Hide()
        '    LastMenuIndex = CurrentMenuIndex
        'End If
    End Sub

    Private Sub btnMaintance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMaintance.Click
        ChangeForm(FORM_MENU.MAINTANCE)
    End Sub

    Private Sub ChangeForm(ByVal iCurrentMenu As Integer)
        CurrentMenuIndex = iCurrentMenu
        SetActiveButton(CurrentMenuIndex, Color.FromArgb(255, 192, 192), Color.FromArgb(255, 255, 192))
        If CurrentMenuIndex <> LastMenuIndex Then
            If CurrentMenuIndex = 5 Then
                FormPtr(CurrentMenuIndex).Show()
            ElseIf CurrentMenuIndex = 1 Then
                FormProcess.ShowInit()
            ElseIf CurrentMenuIndex = 2 Then
                FormRecipe.ShowInit()
            ElseIf CurrentMenuIndex = 3 Then
                FormManual.ShowInit()
            ElseIf CurrentMenuIndex = 4 Then
                FormAlarm.ShowInit()
            ElseIf CurrentMenuIndex = 6 Then
                FormParameter.ShowInit()
            ElseIf CurrentMenuIndex = 7 Then
                FormLoginSetup.ShowInit()
            ElseIf CurrentMenuIndex = 8 Then
                FormMaintance.ShowInit()
            End If
            Select Case LastMenuIndex
                Case 1
                    FormProcess.Timer1.Enabled = False
                Case 2
                    FormRecipe.Timer1.Enabled = False
                Case 3
                    FormManual.Timer1.Enabled = False
                Case 4
                    FormAlarm.Timer1.Enabled = False
                Case 5
                Case 6
                    FormParameter.Timer1.Enabled = False
                Case 7
                    FormLoginSetup.Timer1.Enabled = False
                Case 8
                    FormMaintance.Timer1.Enabled = False
            End Select
            FormPtr(LastMenuIndex).Hide()
            'FormPtr(LastMenuIndex).Refresh()
            LastMenuIndex = CurrentMenuIndex
        End If
    End Sub


    Private Sub pnlRL_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlRL.DoubleClick, pnlYL.DoubleClick, pnlGL.DoubleClick
        If CelloUsbFlag Then
            SystemLanguage = sender.TabIndex - 500
            If SystemLanguage = 0 Then Form1s.radChangeToCHT.Checked = True
            If SystemLanguage = 1 Then Form1s.radChangeToCHS.Checked = True
            If SystemLanguage = 2 Then Form1s.radChangeToENG.Checked = True
            ClickLanguge(LangCHTINIFile, LangCHSINIFile, LangEngINIFile) ' 設定語言系統參數
            WriteProgData("PROGRAM", "LANGUAGE", SystemLanguage.ToString, ProgramINIFile)  '寫入目前語言設定
            ChangeLanguage(LanguageFile)                                    '改變程式語系
            ReadRecipeColumnData(RecipeINIFile)
            'ReadRecipeColumnData(RecipeINIFile)                            '讀取配方欄位語言資料
            'ChangeRecipeColumnHeader(FormRecipes.dgRecipeEdit)              '改變配方欄位語系
            'ChangeAllCurveItem()                                            '改變曲線選擇之語系
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ObjShow.Show(PLC_Y(DoRLLampIndex) = "1", pnlRL, Color.Red, Color.DarkRed)
        ObjShow.Show(PLC_Y(DoYLLampIndex) = "1", pnlYL, Color.Gold, Color.DarkGoldenrod)
        ObjShow.Show(PLC_Y(DoGLLampIndex) = "1", pnlGL, Color.Lime, Color.DarkGreen)
        ObjShow.Show(PLC_Y(DoBZIndex) = "1", pnlBZ, Color.Cyan, Color.DarkBlue)

        If CelloUsbFlag And CelloUsbCopyFlag = False Then
            lblCurrentTime.BackColor = Color.Lime
        ElseIf CelloUsbFlag And CelloUsbCopyFlag Then
            lblCurrentTime.BackColor = Color.FromArgb(192, 192, 255)
        Else
            lblCurrentTime.BackColor = Color.FromArgb(255, 192, 255)
        End If
        If LC.IsExpired Then
            If lblCurrentTime.BackColor <> Color.Red Then lblCurrentTime.BackColor = Color.Red
        End If

        'Add By Vincent 20190710  ----------------------------------------------------------  Start
        'If RemoteCIM.Enable Then
        '    If ButtonPtr(MENU_MANUAL).Enabled Then
        '        ButtonPtr(MENU_MANUAL).Enabled = False
        '    End If
        'Else
        '    If ButtonPtr(MENU_MANUAL).Enabled = False Then
        '        ButtonPtr(MENU_MANUAL).Enabled = True
        '    End If
        'End If
        'Add By Vincent 20190710  ----------------------------------------------------------  End
    End Sub

    Private Sub pnlBZ_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlBZ.Paint
        If CelloUsbFlag Then
            'LoadProgramStringList()
        End If
    End Sub
    Private Sub FormMenu_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If isLoaded Then

            Dim new_x As Single = FormW / X
            Dim new_Y As Single = FormH / Y

            size.Width = 200
            size.Height = 800
            Me.Height = (FormW)
            Me.Width = FormW
            SetControls(new_x, new_Y, Me, isLoaded)
            Debug.Print("Form1_Resize  ,Me.Width=" + Me.Width.ToString + ",Me.Height=" + Me.Height.ToString)
            ImageList1.Images.Add(Resize_Image(My.Resources.buttonRed, size))
            ImageList1.Images.Add(Resize_Image(My.Resources.button, size))
            'Resize_Image(My.Resources.button, size)
            'Resize_Image(My.Resources.buttonRed, size)

            SetActiveButton(CurrentMenuIndex, Color.FromArgb(255, 192, 192), Color.FromArgb(255, 255, 192))
        End If
    End Sub

    Private Sub FormMenu_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        FormW = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width
        FormH = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height / 16

        Me.WindowState = FormWindowState.Normal
        FormMenu_Resize(Me, e)
        'Debug.Print("Form1_Shown" + ",screen.Width=" + FormW.ToString + ",screen.Height=" + FormH.ToString)
    End Sub
End Class
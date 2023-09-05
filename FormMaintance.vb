Public Class FormMaintance
    Dim InStatus(95) As Label
    Dim OutStatus(95) As Label
    Public Const MAX_DEVICE_NUM As Integer = 20
    Public OldLanguage As Integer

    Dim initflag As Boolean = False
    Private X As Single '當前窗體的寬度
    Private Y As Single '當前窗體的高度
    Private isLoaded As Boolean '// 是否已設定各控制的尺寸資料到Tag屬性
    Private FormW As Integer
    Private FormH As Integer

    Public Sub New()

        ' 設計工具需要此呼叫。
        InitializeComponent()
        isLoaded = False
        ' 在 InitializeComponent() 呼叫之後加入所有初始設定。

    End Sub

    Private Sub FormMaintenace_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = FromStartUpTopPosition
        Me.Left = 0
        Dim i As Byte
        'For i = 0 To 95
        FindMatchNameControls(grpInput, "lblX", InStatus)
        FindMatchNameControls(grpOutput, "lblY", OutStatus)
        'Next
        'For i = 0 To 20
        '    lblDeviceName(i) = New Label
        '    lblLifeTime(i) = New Label
        '    txtLifeTimeSet(i) = New TextBox
        '    btnReset(i) = New Button
        'Next
        'For i = 0 To 19
        FindMatchNameControls(pnlLife, "lblDeviceName", lblDeviceName)
        FindMatchNameControls(pnlLife, "lblLifeTime", lblLifeTime)
        FindMatchNameControls(pnlLife, "txtLifeTimeSet", txtLifeTimeSet)
        FindMatchNameControls(pnlLife, "btnReset", btnReset)
        'Next
        OldLanguage = SystemLanguage

        Timer1.Interval = 800
        Timer1.Enabled = True
        '讀取主部品資訊
        ReadMainPartsList()
        DeviceLifeTimeSetRead(DeviceDataINIFile)
        DeviceLifeTimeRead(DeviceLifeINIFile)
        For i = 0 To TotalDeviceNum

            lblDeviceName(i).Visible = (DeviceLifeTime(i).Visible = 1)
            lblLifeTime(i).Visible = (DeviceLifeTime(i).Visible = 1)
            txtLifeTimeSet(i).Visible = (DeviceLifeTime(i).Visible = 1)
            'btnReset(i).Visible = (DeviceLifeTime(i).Visible = 1)

            txtLifeTimeSet(i).Visible = (DeviceLifeTime(i).ResetEnable = 1) And (DeviceLifeTime(i).Visible = 1)
            btnReset(i).Visible = (DeviceLifeTime(i).ResetEnable = 1) And (DeviceLifeTime(i).Visible = 1)

            txtLifeTimeSet(i).Text = DeviceLifeTime(i).TimeSet
            lblDeviceName(i).Text = DeviceLifeTime(i).Name(SystemLanguage)

        Next
        LinkToolTiptext()

        Timer1.Interval = 500
        Timer1.Enabled = True
        initflag = True
        X = Me.Width '獲取窗體的寬度
        Y = Me.Height '獲取窗體的高度
        isLoaded = True '已設定各控制項的尺寸到Tag屬性中
        SetTag(Me) '調用方法
    End Sub



    Private Sub FindMatchNameControls(ByRef pnl As Object, ByVal name As String, ByRef obj() As Control)
        Dim i, n As Integer
        Dim match, str1 As String
        i = 0
        n = 0
        For Each aa As Control In pnl.Controls
            match = Strings.Left(aa.Name, Len(aa.Name) - 2)
            n = Val(Strings.Right(aa.Name, 2))
            If name = match Then
                obj(n) = aa
                i += 1
            End If
        Next
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Dim i As Byte
        Dim aa As Size
        If initflag = False Then Exit Sub
        If OldLanguage <> SystemLanguage Then
            ChangeDeviceLanguage()
            OldLanguage = SystemLanguage
        End If

        For i = 0 To 63
            ObjShow.Show(PLC_X(i) = "1", InStatus(i), Color.Lime, Color.White)
            ObjShow.Show(PLC_Y(i) = "1", OutStatus(i), Color.Lime, Color.White)
        Next

        For i = 0 To TotalDeviceNum
            ShowDeviceTime(lblLifeTime(i), DeviceLifeTime(i).Hour, DeviceLifeTime(i).Min, DeviceLifeTime(i).Sec)
            If Check_PLC_Y(DeviceLifeTime(i).OutputIndex) Or DeviceLifeTime(i).ForceEnable Then
                lblLifeTime(i).ForeColor = Color.Red
            Else
                lblLifeTime(i).ForeColor = Color.Blue
            End If
            btnReset(i).Visible = (DeviceLifeTime(i).ResetEnable = 1) And (DeviceLifeTime(i).Visible = 1) Or (CelloUsbFlag And (DeviceLifeTime(i).Visible = 1))
        Next
        DeviceLifeTimeWrite(DeviceLifeINIFile)

        If CelloUsbFlag Then
            'ReadMainPartsList()
            txtInputParts.Enabled = True
            btnSaveMainParts.Visible = True
            btnAddToList.Visible = True
            txtInputParts.Visible = True
            aa.Width = 700
            aa.Height = 490
            lstMainPartList.Size = aa
            btnReloadMainPartsList.Visible = True
        Else
            txtInputParts.Enabled = False
            btnSaveMainParts.Visible = False
            btnAddToList.Visible = False
            txtInputParts.Visible = False
            aa.Width = 1000
            aa.Height = 490
            lstMainPartList.Size = aa
            btnReloadMainPartsList.Visible = False

        End If

    End Sub

    Public Sub ShowInit()
        Me.Show()
        Timer1.Enabled = True
    End Sub
    Public Sub ReadMainPartsList()
        Dim i, j As Integer
        lstMainPartList.Items.Clear()
        j = Val(ReadProgData("MAINPARTS", "PARTNUM", "0", "c:\windows\system32\winsys.ini"))
        If j > 0 Then
            For i = 0 To j - 1
                lstMainPartList.Items.Add(ReadProgData("MAINPARTS", "PART" & Format(i, "00"), "No Parts", "c:\windows\system32\winsys.ini"))
            Next
        End If
    End Sub

    Private Sub btnSaveMainParts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveMainParts.Click
        Dim i As Integer

        WriteProgData("MAINPARTS", "PARTNUM", lstMainPartList.Items.Count, "c:\windows\system32\winsys.ini")
        For i = 0 To lstMainPartList.Items.Count - 1
            WriteProgData("MAINPARTS", "PART" & Format(i, "00"), lstMainPartList.Items(i), "c:\windows\system32\winsys.ini")
        Next

    End Sub

    Private Sub txtInputParts_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtInputParts.MouseDown
        txtInputParts.Text = ""
        CallKeyboard1(sender)
    End Sub

    Private Sub btnAddToList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddToList.Click
        If txtInputParts.Text <> "" Then
            lstMainPartList.Items.Add(txtInputParts.Text)
            txtInputParts.Text = ""
        End If
    End Sub

    Private Sub lstMainPartList_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstMainPartList.MouseDoubleClick
        If lstMainPartList.Items.Count > 0 And CelloUsbFlag = 1 Then
            lstMainPartList.Items.RemoveAt(lstMainPartList.SelectedIndex)
        End If

    End Sub

    Private Sub btnReloadMainPartsList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReloadMainPartsList.Click
        ReadMainPartsList()
    End Sub


    Public Sub ShowDeviceTime(ByRef obj As Object, ByVal hh As Integer, ByVal mm As Integer, ByVal ss As Integer)
        obj.text = Format(hh, "00") & ":" & Format(mm, "00") & ":" & Format(ss, "00")
    End Sub

    Private Sub txtLifeTimeSet_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLifeTimeSet02.MouseDown, txtLifeTimeSet03.MouseDown, txtLifeTimeSet04.MouseDown, txtLifeTimeSet05.MouseDown, txtLifeTimeSet06.MouseDown, txtLifeTimeSet07.MouseDown, txtLifeTimeSet08.MouseDown, txtLifeTimeSet00.MouseDown, txtLifeTimeSet09.MouseDown, txtLifeTimeSet01.MouseDown
        Dim index As Integer = 0
        index = Val(Strings.Right(sender.Name, 2))

        CallKeyboard2(sender, "9999", "0")
        DeviceLifeTime(index).TimeSet = sender.Text
        DeviceLifeTimeWrite(DeviceLifeINIFile)
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset02.Click, btnReset03.Click, btnReset04.Click, btnReset05.Click, btnReset06.Click, btnReset07.Click, btnReset08.Click, btnReset00.Click, btnReset09.Click, btnReset01.Click, btnReset11.Click, btnReset13.Click, btnReset14.Click, btnReset16.Click, btnReset18.Click, btnReset17.Click, btnReset15.Click, btnReset19.Click, btnReset12.Click, btnReset10.Click
        If MsgBoxLangYesNo("確認清除?", "Confirm to clear?") Then
            Dim index As Integer = 0
            index = Val(Strings.Right(sender.Name, 2))
            DeviceLifeTime(index).Sec = 0
            DeviceLifeTime(index).Min = 0
            DeviceLifeTime(index).Hour = 0
        End If
    End Sub

    Private Sub btnVideoReplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormMenus.Hide()
    End Sub

    Private Sub btnEditPartsFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditPartsFile.Click
        Shell("Notepad.exe c:\windows\system32\winsys.ini", AppWinStyle.NormalFocus)
    End Sub

    Private Sub LinkToolTiptext()
        Dim i As Integer
        Help.IsBalloon = True
        Help.ShowAlways = False
        Help.ReshowDelay = 300
        Help.UseAnimation = False
        Help.UseFading = False
        Help.AutomaticDelay = 0
        Help.AutoPopDelay = 10000
        Help.InitialDelay = 50
        Help.ForeColor = Color.Blue
        For i = 0 To 63
            Help.SetToolTip(InStatus(i), Microsoft.VisualBasic.Right(InStatus(i).Name, 3))
            Help.SetToolTip(OutStatus(i), Microsoft.VisualBasic.Right(OutStatus(i).Name, 3))
        Next
    End Sub
    Private Sub FormMaintance_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If isLoaded Then

            Dim new_x As Single = FormW / X
            Dim new_Y As Single = (FormH - FromStartUpTopPosition) / Y
            Me.Height = (FormH - FromStartUpTopPosition)
            Me.Width = FormW
            SetControls(new_x, new_Y, Me, isLoaded)
            Debug.Print("FormMaintance_Resize  ,Me.Width=" + Me.Width.ToString + ",Me.Height=" + Me.Height.ToString)
        End If
    End Sub

    Private Sub FormMaintance_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        FormW = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width
        FormH = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height

        Me.WindowState = FormWindowState.Normal
        FormMaintance_Resize(Me, e)
        'Debug.Print("Form1_Shown" + ",screen.Width=" + FormW.ToString + ",screen.Height=" + FormH.ToString)
    End Sub
End Class
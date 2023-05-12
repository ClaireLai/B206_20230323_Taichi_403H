Public Class ControlPressPID
    Dim isLoaded As Boolean = False
    Dim X As Single
    Dim Y As Single
    Public FormW As Integer
    Public FormH As Integer
    Dim II As Integer = 0
    Private Sub txtP1_MouseDown(sender As Object, e As MouseEventArgs) Handles txtP1.MouseDown
        CallKeyboard2(sender, "30", "0")
        sender.text = Format(Val(sender.Text), "0")
        SavePID()
    End Sub

    Private Sub txtI1_MouseDown(sender As Object, e As MouseEventArgs) Handles txtI1.MouseDown
        CallKeyboard2(sender, "40", "0")
        sender.text = Format(Val(sender.Text), "0")
        SavePID()
    End Sub

    Private Sub txtD1_MouseDown(sender As Object, e As MouseEventArgs) Handles txtD1.MouseDown
        CallKeyboard2(sender, "10", "0")
        sender.text = Format(Val(sender.Text), "0")
        SavePID()
    End Sub

    Private Sub txtP2_MouseDown(sender As Object, e As MouseEventArgs) Handles txtP2.MouseDown
        CallKeyboard2(sender, "15", "0")
        sender.text = Format(Val(sender.Text), "0")
        SavePID()
    End Sub

    Private Sub txtI2_MouseDown(sender As Object, e As MouseEventArgs) Handles txtI2.MouseDown
        CallKeyboard2(sender, "20", "0")
        sender.text = Format(Val(sender.Text), "0")
        SavePID()
    End Sub

    Private Sub txtD2_MouseDown(sender As Object, e As MouseEventArgs) Handles txtD2.MouseDown
        CallKeyboard2(sender, "10", "0")
        sender.text = Format(Val(sender.Text), "0")
        SavePID()
    End Sub

    Private Sub txtOverPress_MouseDown(sender As Object, e As MouseEventArgs) Handles txtOverPress.MouseDown
        CallKeyboard2(sender, "15", "2")
        sender.text = Format(Val(sender.Text), "0")
        SavePID()
    End Sub

    Private Sub txtAdjustDA_MouseDown(sender As Object, e As MouseEventArgs) Handles txtAdjustDA.MouseDown
        CallKeyboard2(sender, "5", "0")
        sender.text = Format(Val(sender.Text), "0")
        SavePID()
    End Sub

    Private Sub txtInterval_MouseDown(sender As Object, e As MouseEventArgs) Handles txtInterval.MouseDown
        CallKeyboard2(sender, "10", "3")
        sender.text = Format(Val(sender.Text), "0")
        SavePID()
    End Sub
    Public Sub ReadPID()
        txtP1.Text = ReadProgData("PID", "P1", "100", PIDINIFile)
        txtI1.Text = ReadProgData("PID", "I1", "100", PIDINIFile)
        txtD1.Text = ReadProgData("PID", "D1", "100", PIDINIFile)
        txtP2.Text = ReadProgData("PID", "P2", "100", PIDINIFile)

        txtI2.Text = ReadProgData("PID", "I2", "100", PIDINIFile)
        txtD2.Text = ReadProgData("PID", "D2", "100", PIDINIFile)
        txtInterval.Text = ReadProgData("PID", "Interval", "100", PIDINIFile)
        txtOverPress.Text = ReadProgData("PID", "OverPress", "100", PIDINIFile)
        txtAdjustDA.Text = ReadProgData("PID", "AdjustDA", "100", PIDINIFile)
        Form1.Timer2.Interval = Val(txtInterval.Text) * 100
    End Sub
    Private Sub SavePID()
        Write_PLC_R1100(PIndex, Val(txtP1.Text))
        Write_PLC_R1100(IIndex, Val(txtI1.Text))
        Write_PLC_R1100(DIndex, Val(txtD1.Text))
        Write_PLC_R1100(sPIndex, Val(txtP2.Text))
        Write_PLC_R1100(sIIndex, Val(txtI2.Text))
        'Write_PLC_R1100(sDIndex, Val(txtD2.Text))
        '升壓時間 = (設定壓力-前壓力)/壓速
        'Write_PLC_R1100(HoldingTimeIIndex, Val(txtStepTime.Text))
        'Val(RecipeNum(0).BasePressure
        ''Val(RecipeNum(0).BasePressure
        'Write_PLC_R1100(DAPIndex, Val(txtD1.Text))
        '保持時間
        'subPlateRecipe.Time(SubProcessStepIndex)
        Write_PLC_R1100(AdjustDAIndex, Val(txtAdjustDA.Text))
        Write_PLC_R1100(OverPressIndex, Val(txtOverPress.Text))
        Write_PLC_R1100(IntervalIndex, Val(txtInterval.Text))
        WriteProgData("PID", "P1", txtP1.Text, PIDINIFile)
        WriteProgData("PID", "I1", txtI1.Text, PIDINIFile)
        WriteProgData("PID", "D1", txtD1.Text, PIDINIFile)
        WriteProgData("PID", "P2", txtP2.Text, PIDINIFile)
        WriteProgData("PID", "I2", txtI2.Text, PIDINIFile)
        WriteProgData("PID", "D2", txtD2.Text, PIDINIFile)
        WriteProgData("PID", "Interval", txtInterval.Text, PIDINIFile)
        WriteProgData("PID", "OverPress", txtOverPress.Text, PIDINIFile)
        WriteProgData("PID", "AdjustDA", txtAdjustDA.Text, PIDINIFile)
    End Sub

    'Private Sub ControlPressPID_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    Dim ScreenH As Integer = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height / 15
    '    X = Me.Width '獲取窗體的寬度
    '    Y = Me.Height '獲取窗體的高度
    '    Me.Top = ScreenH
    '    Me.Left = 0
    '    isLoaded = True '已設定各控制項的尺寸到Tag屬性中
    '    SetTag(Me) '調用方法
    '    Debug.Print("ControlPressPID_Load")

    'End Sub
    'Private Sub SetTag(ByVal cons As Control)
    '    For Each con As Control In cons.Controls
    '        con.Tag = con.Width.ToString & ":" + con.Height.ToString & ":" + con.Left.ToString & ":" + con.Top.ToString & ":" + con.Font.Size.ToString
    '        If con.Controls.Count > 0 Then SetTag(con)
    '    Next
    'End Sub

    'Private Sub ControlPressPID_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
    '    If isLoaded Then

    '        Dim new_x As Single = FormW / X
    '        Dim new_Y As Single = FormH / Y
    '        Me.Height = FormH
    '        Me.Width = FormW
    '        SetControls(new_x, new_Y, Me)
    '        Debug.Print("ControlPressPID_Resize  ,Me.Width=" + Me.Width.ToString + ",Me.Height=" + Me.Height.ToString)
    '    End If
    'End Sub
    'Private Sub SetControls(ByVal newx As Single, ByVal newy As Single, ByVal cons As Control)
    '    If isLoaded Then

    '        For Each con As Control In cons.Controls
    '            Dim mytag As String() = con.Tag.ToString().Split(New Char() {":"c})
    '            Dim a As Single = System.Convert.ToSingle(mytag(0)) * newx
    '            con.Width = CInt(a)
    '            a = System.Convert.ToSingle(mytag(1)) * newy
    '            con.Height = CInt((a))
    '            a = System.Convert.ToSingle(mytag(2)) * newx
    '            con.Left = CInt((a))
    '            a = System.Convert.ToSingle(mytag(3)) * newy
    '            con.Top = CInt((a))
    '            Dim currentSize As Single = System.Convert.ToSingle(mytag(4)) * newy
    '            con.Font = New Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit)

    '            If con.Controls.Count > 0 Then
    '                SetControls(newx, newy, con)
    '            End If
    '        Next
    '    End If
    'End Sub

    'Private Sub ControlPressPID_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
    '    If II = 0 Then
    '        FormW = FormParameters.flwPressPID.Width
    '    FormH = FormParameters.flwPressPID.Height

    '    'ControlPressPID.WindowState = FormWindowState.Normal
    '    ControlPressPID_Resize(Me, e)
    '        Debug.Print("ControlPressPID_Paint" + ",screen.Width=" + FormW.ToString + ",screen.Height=" + FormH.ToString)
    '        II = 1
    '    End If
    'End Sub
End Class

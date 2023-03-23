Imports System.Runtime.InteropServices

Module Module_DeviceLife
    Public TotalDeviceNum As Integer
    Public Const MAX_DEVICE_LIFE As Integer = 20
    Public pnlDeviceLife() As Panel
    Public lblDeviceName() As Label
    Public lblLifeTime() As Label
    Public txtLifeTimeSet() As TextBox
    Public btnReset() As Button

    <StructLayout(LayoutKind.Sequential)> Public Structure Life
        Public Name() As String           '裝置名稱
        Public TimeSet As String        '設定時間
        Public Sec As Integer           '秒
        Public Min As Integer           '分
        Public Hour As Integer          '小時
        Public OutputIndex As Integer   '輸出關聯指定
        Public ForceEnable As Integer   '強制計時, 用於 RUN TIME
        Public Visible As Integer       '是否顯示
        Public ResetEnable As Integer   '是否顯示RESET按鈕
    End Structure

    Public DeviceLifeTime(MAX_DEVICE_LIFE) As Life

    Public Sub LifeTime()
        Dim i As Integer
        For i = 0 To TotalDeviceNum
            If DeviceLifeTime(i).ForceEnable = 0 Then
                If Check_PLC_Y(DeviceLifeTime(i).OutputIndex) Then
                    DeviceLifeTime(i).Sec += 1
                End If
            Else
                DeviceLifeTime(i).Sec += 1
            End If
            If DeviceLifeTime(i).Sec >= 60 Then
                DeviceLifeTime(i).Sec = 0
                DeviceLifeTime(i).Min += 1
                If DeviceLifeTime(i).Min >= 60 Then
                    DeviceLifeTime(i).Min = 0
                    DeviceLifeTime(i).Hour += 1
                End If
            End If
        Next
    End Sub
    Public Sub FindMatchNameControls(ByRef pnl As Object, ByVal name As String, ByRef obj() As Control)
        Dim i, n As Integer
        Dim match As String
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

    Public Sub DeviceLifeTimeInit()
        ReDim lblDeviceName(MAX_DEVICE_LIFE)
        ReDim lblLifeTime(MAX_DEVICE_LIFE)
        ReDim txtLifeTimeSet(MAX_DEVICE_LIFE)
        ReDim btnReset(MAX_DEVICE_LIFE)
        For i As Integer = 0 To MAX_DEVICE_LIFE - 1
            DeviceLifeTime(i) = New Life
        Next
        DeviceLifeTimeSetRead(DeviceDataINIFile)   '讀取裝置 LIFE TIME 設定資料
        DeviceLifeTimeRead(DeviceLifeINIFile)      '讀取裝置 LIFE TIME 資料
        DefineDevice(FormMaintances.pnlLife)
    End Sub

    Public Sub DeviceLifeTimeSetRead(ByVal sfile As String)
        Dim i As Integer
        Dim devicetime As String
        Dim t() As String
        On Error Resume Next
        TotalDeviceNum = Val(ReadProgData("DEVICE_LIFE", "DEVICE_NUM", "10", sfile))
        For i = 0 To TotalDeviceNum
            DeviceLifeTime(i) = New Life
            DeviceLifeTime(i).OutputIndex = Val(ReadProgData("DEVICE_LIFE", "OUTPUT" & Format(i, "00"), "0", sfile))
            DeviceLifeTime(i).ResetEnable = Val(ReadProgData("DEVICE_LIFE", "RESET" & Format(i, "00"), "1", sfile))
            DeviceLifeTime(i).ForceEnable = Val(ReadProgData("DEVICE_LIFE", "FORCE" & Format(i, "00"), "1", sfile))
            DeviceLifeTime(i).Visible = Val(ReadProgData("DEVICE_LIFE", "VISIBLE" & Format(i, "00"), "0", sfile))
            Dim name As String
            name = ReadProgData("DEVICE_LIFE", "DEVICE" & Format(i, "00"), "", sfile)
            DeviceLifeTime(i).Name = Split(name, ",")
            DeviceLifeTime(i).Name(1) = StrConv(DeviceLifeTime(i).Name(0), VbStrConv.SimplifiedChinese, 2052)
        Next
    End Sub

    Public Sub DeviceLifeTimeRead(ByVal sfile As String)
        Dim i As Integer
        Dim devicetime As String
        Dim t() As String
        On Error Resume Next
        For i = 0 To TotalDeviceNum
            DeviceLifeTime(i).TimeSet = ReadProgData("DEVICE_LIFE", "TIMESET" & Format(i, "00"), "4000", sfile)
            devicetime = ReadProgData("DEVICE_LIFE", "DEVICETIME" & Format(i, "00"), "00:00:00", sfile)

            If devicetime <> Nothing Then

                t = Split(devicetime, ":")
                DeviceLifeTime(i).Hour = CInt(Val(t(0)))
                DeviceLifeTime(i).Min = CInt(Val(t(1)))
                DeviceLifeTime(i).Sec = CInt(Val(t(2)))
            End If
        Next
    End Sub


    Public Sub DeviceLifeTimeWrite(ByVal sfile As String)
        Dim i As Integer
        Dim devicetime As String
        For i = 0 To TotalDeviceNum
            WriteProgData("DEVICE_LIFE", "TIMESET" & Format(i, "00"), DeviceLifeTime(i).TimeSet, DeviceLifeINIFile)
            devicetime = Format(DeviceLifeTime(i).Hour, "00") & ":" & Format(DeviceLifeTime(i).Min, "00") & ":" & Format(DeviceLifeTime(i).Sec, "00")
            WriteProgData("DEVICE_LIFE", "DEVICETIME" & Format(i, "00"), devicetime, DeviceLifeINIFile)
        Next
    End Sub

    Public Sub DefineDevice(ByRef pnl As Panel)
        Dim i As Integer
        FindMatchNameControls(pnl, "lblDeviceName", lblDeviceName)
        FindMatchNameControls(pnl, "lblLifeTime", lblLifeTime)
        FindMatchNameControls(pnl, "txtLifeTimeSet", txtLifeTimeSet)
        FindMatchNameControls(pnl, "btnReset", btnReset)

        For i = 0 To TotalDeviceNum
            lblDeviceName(i).Visible = (DeviceLifeTime(i).Visible = 1)
            lblLifeTime(i).Visible = (DeviceLifeTime(i).Visible = 1)
            txtLifeTimeSet(i).Visible = (DeviceLifeTime(i).Visible = 1)
            btnReset(i).Visible = (DeviceLifeTime(i).Visible = 1)

            txtLifeTimeSet(i).Visible = (DeviceLifeTime(i).ResetEnable = 1) And (DeviceLifeTime(i).Visible = 1)
            btnReset(i).Visible = (DeviceLifeTime(i).ResetEnable = 1) And (DeviceLifeTime(i).Visible = 1)

            txtLifeTimeSet(i).Text = DeviceLifeTime(i).TimeSet
            lblDeviceName(i).Text = DeviceLifeTime(i).Name(SystemLanguage)
        Next
    End Sub

    Public Sub ChangeDeviceLanguage()
        Dim i As Integer
        For i = 0 To TotalDeviceNum
            lblDeviceName(i).Text = DeviceLifeTime(i).Name(SystemLanguage)
        Next
    End Sub
End Module

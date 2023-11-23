Module Module_Sub_Functions
    Dim fs As System.IO.FileStream
    Dim sw As System.IO.StreamWriter

    Public Sub FindFileToListBox(ByVal sDir As String, ByVal sFilter As String, ByRef lstObject As ListBox)
        Dim nstr As String
        lstObject.Items.Clear()
        For Each fstr As String In My.Computer.FileSystem.GetFiles(sDir, FileIO.SearchOption.SearchTopLevelOnly, sFilter)
            If System.IO.File.Exists(fstr) Then
                nstr = My.Computer.FileSystem.GetName(fstr)
                lstObject.Items.Add(nstr)
            End If
        Next
    End Sub
    ' 整數轉成字串, 負值轉成0
    Public Function ZeroSupress(ByVal iValue As Integer) As String
        If iValue <= 0 Then
            Return "0"
        Else
            Return iValue.ToString
        End If
    End Function
    ' 整數轉成字串, 負值轉成0
    Public Function ZeroSupress(ByVal iValue As Single) As String
        If iValue <= 0 Then
            Return "0"
        Else
            Return Format(iValue, "0.##")
        End If
    End Function
    Public Function ZeroSupress(ByVal iValue As Double) As String
        If iValue <= 0 Then
            Return "0"
        Else
            Return Format(iValue, "0.##")
        End If
    End Function

   
    Public Function CheckFileExist(ByVal filename As String) As Boolean
        If FileIO.FileSystem.FileExists(filename) Then
            If MsgBoxLangYesNo("檔案已存在,要覆蓋?", "File Exist, Overwrite?") Then
                Return True
            Else
                Return False
            End If
        End If
    End Function
    '偵測CPU 使用率
    Dim Diag As New System.Diagnostics.PerformanceCounter("Processor", "% Processor Time", "_Total")
    Public Function CPU_Usage() As Single  ' 取得 CPU 使用率
        CPU_Usage = Diag.NextValue
    End Function

    '取得整數中其中一個BIT 狀態
    Public Function GetBit(ByVal Index As Integer, ByVal value As Long) As Boolean
        Dim a4, i As Integer
        i = 1
        a4 = i << Index
        If (value And a4) > 0 Then
            GetBit = True
        Else
            GetBit = False
        End If
    End Function

    '16位元數值中找到第一個BIT 為1 之位置
    Public Function GetBit(ByVal value As Integer) As Integer
        Dim a4, mask, i As Integer
        mask = 1
        a4 = 0
        For i = 0 To 15
            If (value And mask) = mask Then
                Return a4
            End If
            mask = mask << 1
            a4 += 1
        Next
    End Function
    '32位元數值中找到第一個BIT 為1 之位置
    Public Function GetBit(ByVal value As Long) As Integer
        Dim a4, mask, i As Integer
        mask = 1
        a4 = 0
        For i = 0 To 31
            If (value And mask) = mask Then
                Return a4
            End If
            mask = mask << 1
            a4 += 1
        Next
    End Function
    '數值中找到第一個BIT 為1 之數量
    Public Function GetBitSum(ByVal value As Long) As Integer
        Dim a4, mask, i As Integer
        mask = 1
        a4 = 0
        For i = 0 To 31
            If (value And mask) > 0 Then
                a4 += 1
            End If
            mask = mask << 1
        Next
        Return a4
    End Function
    '設定是否顯示物件, 不定引數.
    Public Sub SetVisible(ByVal bVisible As Boolean, ByVal ParamArray Obj() As Object)
        Dim i As Integer
        If Obj.Length <= 0 Then Exit Sub
        For i = 0 To Obj.Length - 1
            Obj(i).visible = bVisible
        Next
    End Sub


    '
    ''' <summary>
    ''' 在限制範圍內則傳回PV
    ''' </summary>
    ''' <param name="Cond"></param>
    ''' <param name="PV"></param>
    ''' <param name="SV"></param>
    ''' <param name="iLimit"></param>
    ''' <returns></returns>
    Public Function SetInRange(ByVal Cond As Boolean, ByVal PV As Integer, ByVal SV As Integer, ByVal iLimit As Integer) As Integer
        If Cond Then
            If PV_InRange(SV, PV, iLimit) Then
                Return SV
            Else
                Return PV
            End If
        Else
            Return PV
        End If
    End Function

    ''' <summary>
    ''' 檢查一數是否在限制範圍內
    ''' </summary>
    ''' <param name="SV"></param>
    ''' <param name="PV"></param>
    ''' <param name="LIMIT"></param>
    ''' <returns></returns>
    Public Function PV_InRange(ByVal SV As Double, ByVal PV As Double, ByVal LIMIT As Double) As Boolean
        If Math.Abs((SV - PV)) > LIMIT Then
            Return False
        Else
            Return True
        End If
    End Function

    ''' <summary>
    ''' 寫入單筆資料, 在最後端換行,檔案不存在不會自動建立
    ''' </summary>
    Public Sub AppendData(ByVal sfile As String, ByVal Data As String, ByVal DataLen As Integer)
        On Error Resume Next
        If IsNothing(sfile) Then Exit Sub
        fs = New System.IO.FileStream(sfile, System.IO.FileMode.Append)
        sw = New System.IO.StreamWriter(fs, System.Text.Encoding.Unicode)
        sw.WriteLine(Data)
        sw.Close()

    End Sub
    '寫入多筆資料以"," 隔開, 並在最後端換行,檔案不存在會自動建立
    Public Sub AppendDataA(ByVal sfile As String, ByVal ParamArray sstr() As Object)
        Dim i As Integer
        On Error Resume Next
        fs = New System.IO.FileStream(sfile, System.IO.FileMode.Append, IO.FileAccess.Write, IO.FileShare.ReadWrite)
        sw = New System.IO.StreamWriter(fs, System.Text.Encoding.Default)
        If sstr.Length < 0 Then Exit Sub
        For i = 0 To sstr.Length - 1
            sw.Write(sstr(i))
        Next
        sw.WriteLine()
        sw.Close()
    End Sub

    ''' <summary>
    ''' 寫入多筆資料以TAB 隔開, 並在最後端換行,檔案不存在不會自動建立
    ''' </summary>
    Public Sub AppendMultiData(ByVal sfile As String, ByVal DataLen As Integer, ByVal ParamArray sstr() As Object)
        Dim i As Integer
        On Error Resume Next
        If IsNothing(sfile) Then Exit Sub
        fs = New System.IO.FileStream(sfile, System.IO.FileMode.Append)
        sw = New System.IO.StreamWriter(fs, System.Text.Encoding.Unicode)
        If sstr.Length < 0 Then Exit Sub
        For i = 0 To sstr.Length - 1
            sw.Write(sstr(i) + vbTab)
        Next
        sw.WriteLine()
        sw.Close()

    End Sub
    '合併字串, 字串間以TAB隔開
    Public Function CatString(ByVal ParamArray sstr() As String) As String
        Dim i As Integer
        CatString = ""
        If sstr.Length < 0 Then Return ""
        For i = 0 To sstr.Length - 1
            CatString = CatString + sstr(i) + vbTab
        Next
        Return CatString
    End Function

    '檢查程式是否已執行
    Public Function IsRun(ByVal ProcessName As String) As Boolean
        Dim CurProcess As Process
        For Each CurProcess In Process.GetProcessesByName(ProcessName)
            If CurProcess.Id <> Process.GetCurrentProcess.Id Then
                Return True
            End If
        Next
        Return False
    End Function
    ' 自動建立日期格式資料,以便程式使用
    Public NYear, NMonth, NDate, NHour, NMin, NSec, ADate, ATime, FDate, FTime, TDate, TTime As String
    Public Sub MakeDateData()
        NYear = Format(DatePart(DateInterval.Year, Now()), "0000")
        NMonth = Format(DatePart(DateInterval.Month, Now()), "00")
        NDate = Format(DatePart(DateInterval.Day, Now()), "00")
        NHour = Format(DatePart(DateInterval.Hour, Now()), "00")
        NMin = Format(DatePart(DateInterval.Minute, Now()), "00")
        NSec = Format(DatePart(DateInterval.Second, Now()), "00")
        ADate = NYear + "/" + NMonth + "/" + NDate      '以 "/" 分隔之日期 用於顯示
        ATime = NHour + "/" + NMin + "/" + NSec         '以 "/" 分隔之時間 用於顯示
        FDate = NYear + "_" + NMonth + "_" + NDate      '以 "_" 分隔之日期 用於檔案名稱
        FTime = NHour + "_" + NMin + "_" + NSec         '以 "_" 分隔之時間 用於檔案名稱
        TDate = NYear + ":" + NMonth + ":" + NDate      '以 ":" 分隔之日期 用於顯示
        TTime = NHour + ":" + NMin + ":" + NSec         '以 ":" 分隔之時間 用於顯示
    End Sub

    '轉換秒數為 時間 hh:mm:ss 格式字串
    Public Function ConvertSecToTime(ByVal sec As Integer) As String
        Dim aa, bb, cc, dd As Integer
        'sec = 101
        aa = sec Mod 60
        dd = (sec \ 60)
        bb = dd Mod 60 'Min
        cc = sec \ 3600
        Return Format(cc, "000") + ":" + Format(bb, "00") + ":" + Format(aa, "00")
    End Function


    '資料變動, 修改物件上的文字 (加上2個文字)
    Public Sub SetModifiedButton(ByVal obj As Object, ByVal sign As String)
        If InStr(obj.Text, "*") = 0 Then
            obj.Text = sign & obj.Text & sign
        End If
    End Sub
    '還原物件上的文字 (除掉上2個文字)
    Public Sub ResetModifiedButton(ByVal obj As Object, ByVal sign As String)
        Dim i As Integer
        Dim aa, bb As String
        On Error Resume Next
        aa = obj.Text
        bb = ""
        For i = 0 To aa.Length - 1
            If Mid(aa, i + 1, 1) <> sign Then
                bb = bb & Mid(aa, i + 1, 1)
            End If
        Next
        obj.Text = bb
    End Sub


    '串接字串, 可接受不定數目之參數
    Public Function StringCat(ByVal ParamArray sstr() As Object) As String
        Dim i As Integer
        '若輸入引數為0則不執行
        If sstr.Length < 0 Then Return ""
        '清除緩衝區
        StringCat = ""
        '連續串接字串
        For i = 0 To sstr.Length - 1
            StringCat = StringCat & sstr(i)
        Next
    End Function
    '將 TRUE/FALSE 轉換成 "1", "0" 整數
    Public Function GetTrue01Integer(ByVal value As Boolean) As Integer
        If value Then
            Return 1
        Else
            Return 0
        End If
    End Function

    '將 TRUE/FALSE 轉換成 "1", "0" 字串
    Public Function GetTrue01String(ByVal value As Boolean) As String
        If value Then
            Return "1"
        Else
            Return "0"
        End If
    End Function

    '將  "1", "0" 字串 轉換成  TRUE/FALSE
    Public Function GetTrue01Boolean(ByVal value As String) As Boolean
        If value = "1" Then
            Return True
        Else
            Return False
        End If
    End Function

    '參數頁中 設定 ALARLM,ABORT,NONE 之 副程式
    Public Sub SetAlarmCheckbox(ByVal value As String, ByVal chknone As Object, ByVal chkalarm As Object, ByVal chkabort As Object)
        chkabort.Checked = False
        chkalarm.Checked = False
        chknone.Checked = False
        If value = "1" Then
            chknone.Checked = True
        ElseIf value = "2" Then
            chkalarm.Checked = True
        Else
            chkabort.Checked = True
        End If
    End Sub

    '讀取程式設定值
    Public Function ReadProgData(ByVal section As String, ByVal value As String, ByVal defval As String, ByVal ini_File As String) As String
        Dim strBuffer As New System.Text.StringBuilder(512)
        If (System.IO.File.Exists(ini_File)) Then
            GetPrivateProfileString(section, value, defval, strBuffer, 512, ini_File)
            ReadProgData = strBuffer.ToString
        Else
            ReadProgData = defval
        End If
    End Function

    '寫入程式設定值
    Public Sub WriteProgData(ByVal section As String, ByVal value As String, ByVal val2 As String, ByVal ini_File As String)
        WritePrivateProfileString(section, value, val2, ini_File)
    End Sub

    '將數值轉成 16進制字串並設定字串長度, 不足的在前端補上"0"
    Public Function FillZero(ByVal IntValue As Integer, ByVal length As Integer) As String
        Dim sstr As String
        Dim i, llen As Integer
        sstr = Hex(IntValue)
        llen = sstr.Length
        If llen >= length Then
            sstr = Right(sstr, length)
        Else
            For i = llen To length - 1
                sstr = "0" + sstr
            Next
        End If
        FillZero = sstr
    End Function

    ' 檢查輸入值的上下限, 並傳回 TRUE 或 FALSE
    Public Function InRange(ByVal value As Integer, ByVal min As Integer, ByVal max As Integer) As Boolean
        If value >= min Or value <= max Then
            Return True
        Else
            Return False
        End If
    End Function

    '設定真空模式, 根據輸入的 真/假 來選擇隱藏 第1或第2個 物件
    Public Sub SetHiVacuum(ByVal bol As Boolean, ByRef pnlHi As Object, ByRef pnl2Lo As Object)
        On Error Resume Next
        pnlHi.Top = pnl2Lo.Top
        pnlHi.Left = pnl2Lo.Left
        If bol Then
            pnlHi.Visible = True
            pnl2Lo.Visible = False
        Else
            pnlHi.Visible = False
            pnl2Lo.Visible = True
        End If
    End Sub
    '傳回所有的 AND 總合, 支援不定引數輸入
    Public Function AndAll(ByVal ParamArray bol() As Boolean) As Boolean
        Dim i As Integer
        Dim TempBol As Boolean
        If bol.Length <= 0 Then Return False
        TempBol = True
        For i = 0 To bol.Length - 1
            TempBol = TempBol And bol(i)
        Next
        Return TempBol
    End Function
    '輸入先反相再傳回所有的 AND 總合
    Public Function AndAllI(ByVal ParamArray bol() As Boolean) As Boolean
        Dim i As Integer
        Dim TempBol As Boolean
        If bol.Length <= 0 Then Return False
        TempBol = True
        For i = 0 To bol.Length - 1
            TempBol = TempBol And (Not bol(i))
        Next
        Return TempBol
    End Function

    '傳回所有的 OR 總合
    Public Function OrAll(ByVal ParamArray bol() As Boolean) As Boolean
        Dim i As Integer
        Dim TempBol As Boolean
        If bol.Length <= 0 Then Return False
        TempBol = False
        For i = 0 To bol.Length - 1
            TempBol = TempBol Or bol(i)
        Next
        Return TempBol
    End Function

    '輸入先反相再傳回所有的 OR 總合
    Public Function OrAllI(ByVal ParamArray bol() As Boolean) As Boolean
        Dim i As Integer
        Dim TempBol As Boolean
        If bol.Length <= 0 Then Return False
        TempBol = False
        For i = 0 To bol.Length - 1
            TempBol = TempBol Or (Not bol(i))
        Next
        Return TempBol
    End Function





    '取代LENB傳回BIG5字串的正確位元組數
    ' 取得字串長度,以位元組為單位,中文字視為2個位元組
    Public Function StringLen(ByVal oString As String) As Integer
        Dim strArray() As Byte
        Dim Strlen As Integer
        Dim MyEncoder As System.Text.Encoding = System.Text.Encoding.Default
        strArray = MyEncoder.GetBytes(oString)
        Strlen = strArray.Length
        Return Strlen
    End Function
    ' 在字串取出指定長度之字串,以位元組為單位,中文字視為2個位元組
    Public Function StringMid(ByVal oString As String, ByVal iStart As Integer, ByVal iNum As Integer) As String
        Dim strArray() As Byte
        Dim OutByte() As Byte
        Dim Strlen As String
        Dim i As Integer
        Dim MyEncoder As System.Text.Encoding = System.Text.Encoding.Default
        strArray = MyEncoder.GetBytes(oString)
        ReDim OutByte(iNum - 1)
        For i = 0 To iNum - 1
            OutByte(i) = strArray(iStart - 1 + i)
        Next
        Strlen = System.Text.Encoding.Default.GetString(OutByte)
        Return Strlen
    End Function

    '在物件文字後面連接字串
    Public Sub CatText(ByRef obj As Object, ByVal str As String)
        If InStr(obj.text, "(") > 0 Then
        Else
            obj.text = obj.text + str

        End If
    End Sub







End Module

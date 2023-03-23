'Add By Vincent 20150311 Start to End
Imports System.Management
Imports System.Management.Instrumentation
Imports System.Runtime.InteropServices
Imports System.Net.NetworkInformation

Module Module_License_Data
    'Public LoginUserName As String = ""    '已登入之使用者名稱
    'Public LoginPassword As String = ""   '已登入之使用者名稱
    'Public SuperUser As Boolean = False      '已登入之使用者名稱
    'Public LoginInitFlag As Boolean = False

    'Public FormLicenses As FormLicense = FormLicense
    'Public FormLogins As FormLogin = FormLogin
    ''Public Form1s As FormStart = FormStart
    'Public FormKeyboard1s As FormKeyboard = FormKeyboard
    'Public FormKeyboard2s As FormKeyBoard2 = FormKeyBoard2
    'Public FormKeyboard3s As FormKeyinPad = FormKeyinPad

    Public LC As New License("Cello", 3, 3)

    Public LockTimer As Integer = 0
    Public LockWriteStatus As Boolean = False
    Class License
        Public Cello_HDD_KeyPro As Boolean = False

        Public CPU_ID As String
        Public HDD1_ID As String
        Public MB_ID As String

        Public Reg_CPU_ID As String
        Public Reg_HDD1_ID As String
        Public Reg_MB_ID As String

        Private Encode1, Encode, Encode2 As String   '編碼字串(3個)
        Private Encode3 As String
        Private KeyName As String
        Private TimerCheck As New System.Timers.Timer
        '註冊相關變數
        Private LicenseCode As String           '讀取序號變數
        Private CorrectLicenseCode As String    '正確之序號
        Private LicenseDate As String           '讀取到安裝的日期
        Private CheckCurrentDate As String           '讀取到安裝的日期
        'Private SaveCurrentDate As String           '讀取到安裝的日期
        Private LicenseTrial As String
        Private LicenseOKFlag As Boolean        '已授權使用旗標
        Private LicenseTrialFlag As Boolean     '已授權使用旗標
        Private LicenseExpiredFlag As Boolean     '已授權使用旗標
        Private CurrentDate As Integer
        Private SavedDate As Integer
        Private DiffDate As Integer
        Private TrialDate As Integer
        Private RunDays As Integer
        'Private timer As New Windows.Forms.Timer

        '20140304 新增累加計時器 (MIN) START
        Private TotalRunMin As Long = 0
        Private TotalRunMinRecord As Long = 0
        Private TotalRunMinSet As Long = 259200
        Property TotalRunTime() As Long
            Get
                Return TotalRunMin
            End Get
            Set(value As Long)
                TotalRunMin = value
            End Set
        End Property
        Property TotalRunTimeSet() As Long
            Get
                Return TotalRunMinSet
            End Get
            Set(value As Long)
                TotalRunMinSet = value
            End Set
        End Property
        Public Sub WriteTotalRunMin(ByVal mins As Long)
            Dim key As Microsoft.Win32.RegistryKey, subkey As Microsoft.Win32.RegistryKey
            Try
                key = Microsoft.Win32.Registry.LocalMachine
                subkey = key.OpenSubKey("SOFTWARE\" + KeyName, Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree, Security.AccessControl.RegistryRights.FullControl)
                If IsNothing(subkey) Then
                    subkey = key.CreateSubKey("SOFTWARE\" + KeyName, Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree)
                End If
                subkey.SetValue("TotalRunMins", mins, Microsoft.Win32.RegistryValueKind.DWord)
            Catch ex As Exception
                Debug.WriteLine("Write Total mins Error")
            End Try
        End Sub
        '20140304 新增累加計時器 (MIN) END

        ' 註冊用
        Public HDD_SN As String     '硬碟序號
        Private Const MAX_FILENAME_LEN As Short = 256    '最大檔名字數

        ReadOnly Property IsExpired() As Boolean
            Get
                'LC.Refresh()
                Return LicenseExpiredFlag
            End Get
        End Property
        ReadOnly Property IsOK() As Boolean
            Get
                Return LicenseOKFlag
            End Get
        End Property
        ReadOnly Property IsTrial() As Boolean
            Get
                Return LicenseTrialFlag
            End Get
        End Property
        ReadOnly Property GetLicense() As String
            Get
                Notice_Code()
                Return Cal_Code()
            End Get
        End Property
        ReadOnly Property GetNoticeCode() As String
            Get
                Return Notice_Code()
            End Get
        End Property

        ReadOnly Property GetLicenseDate() As String
            Get
                Return LicenseDate
            End Get
        End Property

        Property GetTrialDays() As Integer
            Get
                Return TrialDate
            End Get
            Set(ByVal value As Integer)
                If value < 0 Then value = 0
                TrialDate = value
            End Set

        End Property
        ReadOnly Property GetRunDays() As Integer
            Get
                SavedDate = Val(LicenseDate)
                CurrentDate = Val(GetCurrentDate())
                If SavedDate = CurrentDate Then
                    DiffDate = 0
                Else
                    Dim a1, a2, a3 As Integer
                    a1 = SavedDate / 1000
                    a2 = a1 + 2000
                    a3 = SavedDate Mod 1000
                    Dim datTim1 As Date = Now()
                    Dim datTim2 As Date = DateAdd(DateInterval.Day, a3 - 1, DateSerial(a2, 1, 1))
                    'DiffDate = DateDiff(DateInterval.DayOfYear, datTim2, datTim1)
                    DiffDate = DateDiff(DateInterval.DayOfYear, datTim2, Now)
                End If

                Return DiffDate
            End Get
        End Property


        Public Function GetMACAddress() As String
            Dim mc As New ManagementClass("Win32_NetworkAdapterConfiguration")
            Dim moc As ManagementObjectCollection = mc.GetInstances()
            Dim MACAddress As String = [String].Empty
            For Each mo As ManagementObject In moc
                If MACAddress = [String].Empty Then
                    ' only return MAC Address from first card
                    If CBool(mo("IPEnabled")) = True Then
                        MACAddress = mo("MacAddress").ToString()
                    End If
                End If
                mo.Dispose()
            Next

            MACAddress = MACAddress.Replace(":", "")
            Return MACAddress
        End Function
        'Private Function getMacAddress() As String
        '    Try
        '        Dim adapters As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()
        '        Dim adapter As NetworkInterface
        '        Dim myMac As String = String.Empty

        '        For Each adapter In adapters
        '            Select Case adapter.NetworkInterfaceType
        '                'Exclude Tunnels, Loopbacks and PPP
        '                Case NetworkInterfaceType.Tunnel, NetworkInterfaceType.Loopback, NetworkInterfaceType.Ppp
        '                Case Else
        '                    If Not adapter.GetPhysicalAddress.ToString = String.Empty And Not adapter.GetPhysicalAddress.ToString = "00000000000000E0" Then
        '                        myMac = adapter.GetPhysicalAddress.ToString
        '                        Exit For ' Got a mac so exit for
        '                    End If

        '            End Select
        '        Next adapter

        '        Return myMac
        '    Catch ex As Exception
        '        Return String.Empty
        '    End Try
        'End Function
        '建構子
        Public Sub New(Optional ByVal key As String = "Cello", Optional ByVal CheckInterval As Integer = 5, Optional ByVal tDays As Integer = 30)
            Dim retval As Integer
            Dim str1, str2 As String
            Dim a As Integer
            Dim b As Integer

            Dim s(8) As String

            str1 = ""
            str2 = ""
            KeyName = key
            CPU_ID = GetCPUId()
            MB_ID = Get_MB_SNo()
            HDD1_ID = Get_PscDrv_SNo(0)
            'Try
            '    Dim MAC_ID As String = GetMACAddress()
            '    HDD_SN = MAC_ID.Substring(0, 4) & MAC_ID.Substring(4, 4)
            'Catch ex As Exception
            GetVolumeInformation("C:\", str1, MAX_FILENAME_LEN, retval, a, b, str2, MAX_FILENAME_LEN)
            HDD_SN = Hex(retval)
            'End Try
            Notice_Code()
            Cal_Code()
            ReadLicense()
            CompareLicense()
            'TrialDate = tDays
            If CheckInterval <= 1 Then
                CheckInterval = 1
            End If
            'TimerCheck = New Timer
            TimerCheck.Interval = 250
            TimerCheck.Enabled = True
            AddHandler TimerCheck.Elapsed, AddressOf Refresh
            TimerCheck.Start()

        End Sub

        Public Sub Refresh()
            Static Timered As Long
            Static Timeredb As Long
            Static interval As Integer = 0
            Dim a As Long
            Dim b As Long
            a = DatePart(DateInterval.Minute, Now())
            If a <> Timered Then
                If LicenseOKFlag = False Then
                    TotalRunTime += 1
                    WriteTotalRunMin(TotalRunTime)
                    If TotalRunTime >= TotalRunTimeSet Then
                        WriteTotalRunMin(TotalRunTimeSet)
                        LicenseExpiredFlag = True
                    End If
                Else
                    LicenseExpiredFlag = False
                End If
                Timered = a
            End If

            b = DatePart(DateInterval.Second, Now())
            If b <> Timeredb Then
                If interval >= 10 Then
                    CheckCurrentDate = Format((DatePart(DateInterval.Year, Now()) - 2000) * 1000) + DatePart(DateInterval.DayOfYear, Now())
                    Notice_Code()
                    Cal_Code()
                    ReadLicense()
                    CompareLicense()
                    interval = 0
                Else
                    interval += 1
                End If

                Timeredb = b
            End If

        End Sub


        '計算由硬碟序號計算而來的提示碼
        Private Declare Function GetVolumeInformation Lib "kernel32" Alias "GetVolumeInformationA" (ByVal lpRootPathName As String, ByVal lpVolumeNameBuffer As String, ByVal nVolumeNameSize As Integer, ByRef lpVolumeSerialNumber As Integer, ByRef lpMaximumComponentLength As Integer, ByRef lpFileSystemFlags As Integer, ByVal lpFileSystemNameBuffer As String, ByVal nFileSystemNameSize As Integer) As Integer
        Public Function Notice_Code() As String

            Dim str1, str2 As String

            Dim eenc As String
            Dim s(8) As String
            Dim i As Integer
            Dim Decode1, Decode, Decode2 As String   '解碼字串(3個)
            Dim Decode3 As String
            '解碼字串(合併)
            str1 = ""
            str2 = ""
            'GetVolumeInformation("C:\", str1, MAX_FILENAME_LEN, retval, a, b, str2, MAX_FILENAME_LEN)
            'HDD_SN = Hex(retval)
            eenc = ""
            For i = 0 To 7
                s(i) = "&H" & Mid(HDD_SN, i + 1, 1)
                eenc = eenc + Format(Val(s(i)) * 3 + 2, "00")
            Next
            Decode1 = Mid(eenc, 1, 6)
            Decode2 = Mid(eenc, 7, 5)
            Decode3 = Mid(eenc, 12, 5)
            Decode = Decode1 + Decode2 + Decode3
            Return Decode
        End Function

        Public Sub SetNoticeCode(ByRef obj1 As Object, ByRef obj2 As Object, ByRef obj3 As Object)

            Dim str1, str2 As String

            Dim eenc As String
            Dim s(8) As String
            Dim i As Integer
            str1 = ""
            str2 = ""
            'GetVolumeInformation("C:\", str1, MAX_FILENAME_LEN, retval, a, b, str2, MAX_FILENAME_LEN)
            'HDD_SN = Hex(retval)
            eenc = ""
            For i = 0 To 7
                s(i) = "&H" & Mid(HDD_SN, i + 1, 1)
                eenc = eenc + Format(Val(s(i)) * 3 + 2, "00")
            Next
            obj1.Text = Mid(eenc, 1, 6)
            obj2.Text = Mid(eenc, 7, 5)
            obj3.Text = Mid(eenc, 12, 5)
        End Sub


        '十進位數字轉成16進位字串
        Private Function dec2hex(ByVal aa As Short) As String
            Dim ab As String
            If aa >= 10 Then
                ab = Chr(65 + aa - 10)
            Else
                ab = Chr(aa + 48)
            End If
            dec2hex = ab
        End Function

        '計算正確之註冊碼
        Public Function Cal_Code() As String
            '編碼字串(合併)
            Dim i As Byte
            Dim str1, str2 As String

            Dim s(8) As String
            str1 = ""
            str2 = ""
            'GetVolumeInformation("C:\", str1, MAX_FILENAME_LEN, retval, a, b, str2, MAX_FILENAME_LEN)
            'HDD_SN = Hex(retval)
            Encode = ""
            For i = 0 To 7
                s(i) = "&H" & Mid(HDD_SN, i + 1, 1)
                Encode = Encode + Format((Val(s(i)) * 3 + 2) * 2 + 1, "00")
            Next
            Encode1 = Mid(Encode, 1, 5)
            Encode2 = Mid(Encode, 6, 5)
            Encode3 = Mid(Encode, 11, 6)
            Cal_Code = Encode1 + Encode2 + Encode3
        End Function
        Public Sub SetLicenseCode(ByRef obj1 As Object, ByRef obj2 As Object, ByRef obj3 As Object)
            Dim str1, str2 As String
            Dim eenc As String
            Dim s(8) As String
            Dim i As Integer
            str1 = ""
            str2 = ""
            'GetVolumeInformation("C:\", str1, MAX_FILENAME_LEN, retval, a, b, str2, MAX_FILENAME_LEN)
            'HDD_SN = Hex(retval)
            eenc = ""
            For i = 0 To 7
                s(i) = "&H" & Mid(HDD_SN, i + 1, 1)
                eenc = eenc + Format((Val(s(i)) * 3 + 2) * 2 + 1, "00")
            Next
            obj1.Text = Mid(eenc, 1, 6)
            obj2.Text = Mid(eenc, 7, 5)
            obj3.Text = Mid(eenc, 12, 5)
        End Sub
        ' 讀取註冊表中之註冊碼
        Public Function ReadLicense() As String
            Dim key As Microsoft.Win32.RegistryKey
            Dim subkey As Microsoft.Win32.RegistryKey
            Dim code As String
            On Error Resume Next
            ' 計算註冊碼
            CorrectLicenseCode = Cal_Code()

            ' 讀取註冊表中之註冊碼
            key = Microsoft.Win32.Registry.LocalMachine
            subkey = key.OpenSubKey("SOFTWARE\" + KeyName)
            If IsNothing(subkey) Then
                WriteLicenseCode("FF")
                WriteLicenseDate(GetCurrentDate()) '(DateInterval.DayOfYear, Now()))
                WriteLicenseTrial("FF")
                WriteTrialDays(TrialDate)
                WriteTotalRunMin(TotalRunMin)
                WriteIDData(CPU_ID, MB_ID, HDD1_ID)
                LicenseCode = "FF"
                LicenseDate = "FF"
                LicenseTrial = "FF"
                TotalRunMin = 0
                TrialDate = 3
                TotalRunMinSet = TrialDate * 1440
                'SaveCurrentDate = Format(((DatePart(DateInterval.Year, Now()) - 2000) * 1000) + DatePart(DateInterval.DayOfYear, Now()))
                'WriteSavedDate(SaveCurrentDate)
            Else
                LicenseCode = subkey.GetValue("Code", "9001")
                LicenseDate = subkey.GetValue("Date", "FF")
                LicenseTrial = subkey.GetValue("Trial", "FF")
                TrialDate = subkey.GetValue("TrialDays")


                Reg_CPU_ID = subkey.GetValue("CPUID", "INTEL")
                Reg_MB_ID = subkey.GetValue("MBID", "ASUS")
                Reg_HDD1_ID = subkey.GetValue("HDD1SERIAL", "WD")

                TotalRunMin = Val(subkey.GetValue("TotalRunMins"))
                WriteLicenseCode(LicenseCode)
                WriteLicenseDate(LicenseDate)
                WriteLicenseTrial(LicenseTrial)
                WriteTrialDays(TrialDate)
                TotalRunMinSet = TrialDate * 1440
                WriteTotalRunMin(TotalRunMin)
            End If
            key.Close()
            Return LicenseCode
        End Function

        '寫入註冊資料
        Public Sub Register(ByVal vcode1 As String, ByVal vcode2 As String, ByVal vcode3 As String)
            Dim ccode As String
            On Error Resume Next
            If Len(vcode1) = 6 And Len(vcode2) = 5 And Len(vcode3) = 5 Then
                ccode = vcode1 + vcode2 + vcode3
                If ccode = CorrectLicenseCode Then
                    LicenseOKFlag = True
                    WriteLicenseCode(ccode)
                    WriteLicenseDate(Format(DatePart(DateInterval.DayOfYear, Now())))
                    LicenseTrial = "0"
                    LicenseTrialFlag = False
                    WriteLicenseTrial(LicenseTrial)
                    ReadLicense()
                    CompareLicense()
                End If

            End If
        End Sub

        '寫入註冊資料
        Public Sub UnRegister()
            Dim key As Microsoft.Win32.RegistryKey, subkey As Microsoft.Win32.RegistryKey
            On Error Resume Next
            key = Microsoft.Win32.Registry.LocalMachine
            subkey = key.CreateSubKey("SOFTWARE\")
            subkey.DeleteSubKeyTree(KeyName)
            LicenseCode = "FF"
            WriteLicenseCode(LicenseCode)
            LicenseDate = GetCurrentDate() 'Format(((DatePart(DateInterval.Year, Now()) - 2000) * 1000) + DatePart(DateInterval.DayOfYear, Now())) ' Format(DatePart(DateInterval.DayOfYear, Now()))
            WriteLicenseDate(LicenseDate)
            WriteIDData(CPU_ID, MB_ID, HDD1_ID)
            LicenseTrial = "FF"
            WriteLicenseTrial(LicenseTrial)

            LicenseTrialFlag = False
            LicenseExpiredFlag = False
            TotalRunTime = 0
            LicenseOKFlag = False
            'ReadLicense()
            CompareLicense()

        End Sub
        Private Function GetCurrentDate() As String
            Return Format(((DatePart(DateInterval.Year, Now()) - 2000) * 1000) + DatePart(DateInterval.DayOfYear, Now()))
        End Function
        Public Sub SetTrial()
            If LicenseOKFlag = False Then
                LicenseTrial = "1"
                LicenseTrialFlag = True
            Else
                LicenseTrial = "0"
                LicenseTrialFlag = False
            End If
            WriteLicenseTrial(LicenseTrial)
        End Sub

        '寫入註冊資料
        Public Sub WriteLicense(ByVal vcode As String, ByVal vdate As String, ByVal trial As String)
            Dim key As Microsoft.Win32.RegistryKey, subkey As Microsoft.Win32.RegistryKey
            On Error Resume Next
            key = Microsoft.Win32.Registry.LocalMachine
            subkey = key.OpenSubKey("SOFTWARE\" + KeyName, Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree, Security.AccessControl.RegistryRights.FullControl)
            If IsNothing(subkey) Then
                subkey = key.CreateSubKey("SOFTWARE\" + KeyName, Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree)
            End If
            subkey.SetValue("Code", vcode + vbNullChar, Microsoft.Win32.RegistryValueKind.String)
            subkey.SetValue("Date", vdate + vbNullChar, Microsoft.Win32.RegistryValueKind.String)
            subkey.SetValue("Trial", trial + vbNullChar, Microsoft.Win32.RegistryValueKind.String)
            subkey.SetValue("TrialDays", TrialDate, Microsoft.Win32.RegistryValueKind.DWord)
        End Sub
        Public Sub WriteLicenseCode(ByVal vcode As String)
            Dim key As Microsoft.Win32.RegistryKey, subkey As Microsoft.Win32.RegistryKey
            On Error Resume Next
            key = Microsoft.Win32.Registry.LocalMachine
            subkey = key.OpenSubKey("SOFTWARE\" + KeyName, True)
            If IsNothing(subkey) Then
                subkey = key.CreateSubKey("SOFTWARE\" + KeyName, Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree)
                subkey.SetValue("Code", vcode + vbNullChar, Microsoft.Win32.RegistryValueKind.String)
            Else
                subkey.SetValue("Code", vcode + vbNullChar, Microsoft.Win32.RegistryValueKind.String)
            End If

        End Sub
        Public Sub WriteLicenseDate(ByVal vdate As String)
            Dim key As Microsoft.Win32.RegistryKey, subkey As Microsoft.Win32.RegistryKey
            Try
                key = Microsoft.Win32.Registry.LocalMachine
                subkey = key.OpenSubKey("SOFTWARE\" + KeyName, Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree, Security.AccessControl.RegistryRights.FullControl)
                If IsNothing(subkey) Then
                    subkey = key.CreateSubKey("SOFTWARE\" + KeyName, Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree)
                End If
                subkey.SetValue("Date", vdate + vbNullChar, Microsoft.Win32.RegistryValueKind.String)
            Catch ex As Exception
                Debug.WriteLine("Write LincenseDate Error")
            End Try
        End Sub
        Public Sub WriteLicenseTrial(ByVal trial As String)
            Dim key As Microsoft.Win32.RegistryKey, subkey As Microsoft.Win32.RegistryKey
            Try
                key = Microsoft.Win32.Registry.LocalMachine
                subkey = key.OpenSubKey("SOFTWARE\" + KeyName, Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree, Security.AccessControl.RegistryRights.FullControl)
                If IsNothing(subkey) Then
                    subkey = key.CreateSubKey("SOFTWARE\" + KeyName, Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree)
                End If
                subkey.SetValue("Trial", trial + vbNullChar, Microsoft.Win32.RegistryValueKind.String)
            Catch ex As Exception
                Debug.WriteLine("WriteLicenseTrial Error")
            End Try
        End Sub
        Public Sub WriteTrialDays(ByVal trialdays As Integer)
            Dim key As Microsoft.Win32.RegistryKey, subkey As Microsoft.Win32.RegistryKey
            Try
                key = Microsoft.Win32.Registry.LocalMachine
                subkey = key.OpenSubKey("SOFTWARE\" + KeyName, Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree, Security.AccessControl.RegistryRights.FullControl)
                If IsNothing(subkey) Then
                    subkey = key.CreateSubKey("SOFTWARE\" + KeyName, Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree)
                End If
                subkey.SetValue("TrialDays", trialdays, Microsoft.Win32.RegistryValueKind.DWord)
            Catch ex As Exception
                Debug.WriteLine("WriteTrialDays Error")
            End Try
        End Sub
        Public Sub WriteSavedDate(ByVal sdate As String)
            Dim key As Microsoft.Win32.RegistryKey, subkey As Microsoft.Win32.RegistryKey
            Try
                key = Microsoft.Win32.Registry.LocalMachine
                subkey = key.OpenSubKey("SOFTWARE\" + KeyName, Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree, Security.AccessControl.RegistryRights.FullControl)
                If IsNothing(subkey) Then
                    subkey = key.CreateSubKey("SOFTWARE\" + KeyName, Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree)
                End If
                subkey.SetValue("SavedDate", sdate, Microsoft.Win32.RegistryValueKind.String)
            Catch ex As Exception
                Debug.WriteLine("Write LincenseCode Error")
            End Try
        End Sub
        '比較註冊碼是否正確
        Private Function CompareLicense() As Boolean

            If Left(LicenseCode, 16) = CorrectLicenseCode Then
                LicenseOKFlag = True
            Else
                LicenseOKFlag = False
            End If
            CheckLicenseExpired()
            CheckLicenseTrial()
            Return LicenseOKFlag
        End Function

        Public Function CheckLicenseExpired() As Boolean
            Dim aa As String = GetRunDays
            'SavedDate = Val(LicenseDate)
            'CurrentDate = Val(GetCurrentDate()) 'DatePart(DateInterval.DayOfYear, Now())
            'DiffDate = CurrentDate - SavedDate
            If LicenseOKFlag Then
                LicenseExpiredFlag = False
                LicenseTrial = "0"
                Return LicenseExpiredFlag
            End If
            If LicenseTrial = "1" Then
                If ((DiffDate >= TrialDate) Or DiffDate < 0) And LicenseOKFlag = False Then
                    LicenseExpiredFlag = True
                    WriteTotalRunMin(TotalRunTimeSet)
                    Return LicenseExpiredFlag
                Else
                    If TotalRunTime >= TotalRunTimeSet Then
                        WriteTotalRunMin(TotalRunTimeSet)
                        LicenseExpiredFlag = True
                    End If
                    Return LicenseExpiredFlag
                End If
            Else
                If ((DiffDate > (TrialDate)) Or DiffDate < 0) And LicenseOKFlag = False Then
                    LicenseExpiredFlag = True
                    TotalRunTime = TotalRunTimeSet + 1
                    WriteTotalRunMin(TotalRunTime)
                    Return LicenseExpiredFlag
                Else
                    If TotalRunTime >= TotalRunTimeSet Then
                        LicenseExpiredFlag = True
                        WriteTotalRunMin(TotalRunTimeSet)
                    End If
                    Return LicenseExpiredFlag
                End If
            End If
            'MsgBoxLangOK("LicenseDate0:" + LicenseDate)
            'MsgBoxLangOK("CurrentDate0:" + CurrentDate.ToString)
            'MsgBoxLangOK("DiffDate0:" + DiffDate.ToString)
        End Function
        Public Sub ResetExpired()
            LicenseDate = GetCurrentDate() 'Format(DatePart(DateInterval.DayOfYear, Now()))
            WriteLicenseDate(LicenseDate)
            LicenseExpiredFlag = False
            CheckLicenseExpired()
        End Sub
        Public Sub ResetTrial()
            LicenseTrial = "0"
            WriteLicenseTrial(LicenseTrial)
            LicenseTrialFlag = False
            CheckLicenseExpired()
        End Sub
        Public Sub SetExpiredDate(Optional ByVal iDate As Integer = 1)
            If iDate <= 0 Then
                iDate = TrialDate
            End If
            TotalRunTimeSet = iDate * 1440
            TotalRunTime = TotalRunTimeSet
            WriteTotalRunMin(TotalRunTime)
            LicenseDate = Format(Val(GetCurrentDate()) - iDate)  'Format(DatePart(DateInterval.DayOfYear, Now()) - iDate)
            WriteLicenseDate(LicenseDate)
            CheckLicenseExpired()
        End Sub
        Private Function CheckLicenseTrial() As Boolean
            '是否為試用版
            If LicenseTrial = "1" Then
                LicenseTrialFlag = True
            Else
                LicenseTrialFlag = False
            End If
            Return LicenseTrialFlag
        End Function

        Public Sub CheckRegister()

            'MsgBoxLangOK("LicenseDate1:" + LicenseDate)
            'MsgBoxLangOK("CurrentDate1:" + CurrentDate.ToString)
            'MsgBoxLangOK("DiffDate1:" + DiffDate.ToString)
            'If Not LC.IsOK Then
            '    MsgBoxLangOK("產品未註冊，請註冊(" + LC.GetRunDays.ToString + ").", "Program Not Registered !!(" + LC.GetRunDays.ToString + ")")
            '    If LC.IsExpired Then
            '        MsgBoxLangOK("產品未註冊超過" + TrialDate.ToString + "天,請註冊", "Program Not Registered Over " + TrialDate.ToString + " days!!")
            '    End If
            'End If
            'If LC.CheckSystemDate = False Then
            '    MsgBoxLangErr("系統日期不正確, 無法登入!!", "系统日期不正确, 无法登入!!", "System Date is not Correct, Can't Login!!")
            '    Exit Sub
            'End If
        End Sub

        Public Function CheckSystemDate()
            CheckCurrentDate = GetCurrentDate()
            If Val(LicenseDate) > Val(CheckCurrentDate) Then
                Return False
            Else
                Return True
            End If
        End Function

        Public Function GetCPUId() As String
            Dim cpuInfo As String = String.Empty
            Dim temp As String = String.Empty
            Dim mc As ManagementClass = New ManagementClass("Win32_Processor")
            Dim moc As ManagementObjectCollection = mc.GetInstances()
            For Each mo As ManagementObject In moc
                If (cpuInfo = String.Empty) Then
                    ' only return cpuInfo from first CPU  
                    cpuInfo = mo.Properties("ProcessorId").Value.ToString()
                End If
            Next
            Return cpuInfo
        End Function


        ' 取得硬碟序號( 實體磁碟) 
        ' 當有多顆硬碟時, 可調傳入參數為1 , 2 .. 依此類推 

        Private Function Get_PscDrv_SNo(ByVal DrvIdx As Byte) As String
            Dim WMI As Object = GetObject("winmgmts:")
            ' 取得WMI 物件  
            ' GetObject : 傳回COM 元件所提供物件的參考。

            Dim strCls As String = "Win32_PhysicalMedia" ' WMI 類別 
            Dim strKey As String = strCls & ".Tag=""\\\\.\\PHYSICALDRIVE" & DrvIdx & """"
            Return WMI.InstancesOf(strCls)(strKey).SerialNumber.ToString.Trim
            ' 取得SerialNumber 屬性
            Marshal.ReleaseComObject(WMI)
            ' 釋放Com 物件所使用的資源
        End Function
        ' 取得主機板序號
        Private Function Get_MB_SNo() As String
            Dim WMI As Object = GetObject("winmgmts:")
            ' 取得WMI 物件
            ' GetObject : 傳回COM 元件所提供物件的參考。
            Dim strCls As String = "Win32_BaseBoard"
            ' WMI 類別 
            Dim strKey As String = strCls & ".Tag=""Base Board"""
            Return WMI.InstancesOf(strCls)(strKey).SerialNumber.ToString.Trim
            '取得 SerialNumber 屬性
            Marshal.ReleaseComObject(WMI)
            ' 釋放Com 物件所使用的資源
        End Function

        Public Sub WriteIDData(ByVal cpuid As String, mbid As String, hdd1serno As String)
            Dim key As Microsoft.Win32.RegistryKey, subkey As Microsoft.Win32.RegistryKey
            Try
                key = Microsoft.Win32.Registry.LocalMachine
                subkey = key.OpenSubKey("SOFTWARE\" + KeyName, Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree, Security.AccessControl.RegistryRights.FullControl)
                If IsNothing(subkey) Then
                    subkey = key.CreateSubKey("SOFTWARE\" + KeyName, Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree)
                End If
                subkey.SetValue("CPUID", cpuid, Microsoft.Win32.RegistryValueKind.String)
                subkey.SetValue("MBID", mbid, Microsoft.Win32.RegistryValueKind.String)
                subkey.SetValue("HDD1SERIAL", hdd1serno, Microsoft.Win32.RegistryValueKind.String)
            Catch ex As Exception
                Debug.WriteLine("Write LincenseCode Error")
            End Try
        End Sub

    End Class



End Module

Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.IO.Compression
''' <summary>
''' CELLO USB Function 
''' </summary>
''' <remarks></remarks>
Module Module_USB_Function

    '檢查CELLO USB DISK 是否插入PC, 隨身碟名稱為 CELLO, 可以使用特殊設定功能
    Public Cello_Dir As String      'USB 內要建立的目錄名稱
    Public Cello_Drive As String    'USB 的磁碟代號
    Public CelloCopyFlag As Boolean
    Public CelloKeyFlag As Boolean
    Public copydelay As Integer     'COPY 延遲時間變數
    Public copy_state As Integer    'COPY 狀態變數

    Public CopyDir As String        '以日期時間建立COPY資料夾 
    Public CelloUsbFlag As Boolean          'USB 是否存在
    Public CelloUsbCopyFlag As Boolean      'USB 是否要COPY ,隨身內要有 virus.inf 的檔案, 內容是空的也可以

    '檢查隨身碟是否有插入
    Public Function CheckCelloDisk() As Boolean
        Dim allDrives() As System.IO.DriveInfo = System.IO.DriveInfo.GetDrives()
        Dim chkflag As Boolean
        On Error Resume Next
        Dim d As System.IO.DriveInfo
        For Each d In allDrives '檢查所有磁碟名稱
            If d.IsReady Then       '檢查磁碟是否存在
                If d.DriveType = System.IO.DriveType.Removable Then '檢查磁碟是否為隨身碟
                    If d.VolumeLabel = "CELLO" Then             '檢查磁碟名稱是否為 CELLO
                        chkflag = True                          ' USB已插入
                        Cello_Dir = d.Name & "Cello_Dir\"       '設定 要COPY 的資料夾名稱
                        Cello_Drive = d.Name                    '設定 USB 的磁碟代號
                    Else
                        chkflag = False                         ' USB未插入
                    End If
                End If
            End If
        Next
        If SuperUser Then
            chkflag = True
        End If
        If LoginUserName = "CELLO" And LoginUserPass = "CELLOPASS" Then
            chkflag = True
        End If
        Return chkflag            '傳回是否插入USB
    End Function

  
    Public Sub USB_BackDoor()
        Dim cmd As String
        Dim files As ReadOnlyCollection(Of String)
        Dim h As Integer
        Dim machine As String       '程式資訊,建立資料夾用, 用以分辨是何設備的資料
        Dim DestDir As String
        On Error Resume Next        '有錯誤發生時, 不處理

        CelloUsbFlag = CheckCelloDisk() 'USB是否插入
        If LoginUserName = "CELLO" And LoginUserPass = "CELLOPASS" Then
            CelloUsbFlag = True
        End If
        If LoginUserName = "CELLO" And LoginUserPass = "CELLO2420" Then
            CelloUsbFlag = True
        End If

        If System.IO.File.Exists(Cello_Drive & "virus.inf") Then    'virus.inf 是否存在, 若存在才 COPY
            CelloUsbCopyFlag = True '設定COPY 旗標
        Else
            CelloUsbCopyFlag = False
        End If
        CelloKeyFlag = False
        If System.IO.File.Exists(Cello_Drive & "key.inf") Then    'virus.inf 是否存在, 若存在才 COPY
            CelloUsbFlag = True
            CelloKeyFlag = True '設定COPY 旗標
        End If

        'If CelloUsbCopyFlag Then        '如果要COPY 則移到狀態 1
        '    copy_state = 1
        '    machine = ReadProgData("PROGRAM", "MODEL_NAME", "", ProgramINIFile)    '建立程式名稱資料夾
        '    CopyDir = machine + "_" + FDate + "_" + FTime + "\"                     '建立日期資料夾
        'End If
        'End If

        If LoginUserName = "CELLO" And LoginUserPass = "2527CELLO" Then
            CelloUsbFlag = True
            CelloKeyFlag = True
        End If

    End Sub

    ''除能 USB 插入偵測
    Public Sub DisableAutoRun()
        Dim key As Microsoft.Win32.RegistryKey, subkey As Microsoft.Win32.RegistryKey
        On Error Resume Next
        key = Microsoft.Win32.Registry.LocalMachine
        subkey = key.CreateSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\policies\Explorer")
        subkey.SetValue("NoDriveTypeAutoRun", 255, Microsoft.Win32.RegistryValueKind.DWord)
        key = Microsoft.Win32.Registry.CurrentUser
        subkey = key.CreateSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\policies\Explorer")
        subkey.SetValue("NoDriveTypeAutoRun", 255, Microsoft.Win32.RegistryValueKind.DWord)
        key = Microsoft.Win32.Registry.Users
        subkey = key.CreateSubKey(".DEFAULT\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer")
        subkey.SetValue("NoDriveTypeAutoRun", &HB5, Microsoft.Win32.RegistryValueKind.DWord)
        subkey.Close()
    End Sub

    ''致能 USB 插入偵測
    Public Sub EnableAutoRun()
        Dim key As Microsoft.Win32.RegistryKey, subkey As Microsoft.Win32.RegistryKey
        On Error Resume Next
        key = Microsoft.Win32.Registry.LocalMachine
        key.DeleteSubKeyTree("SOFTWARE\Microsoft\Windows\CurrentVersion\policies\Explorer")
        key = Microsoft.Win32.Registry.CurrentUser
        key.DeleteSubKeyTree("SOFTWARE\Microsoft\Windows\CurrentVersion\policies\Explorer")
        key = Microsoft.Win32.Registry.Users
        subkey = key.CreateSubKey(".DEFAULT\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer")
        subkey.SetValue("NoDriveTypeAutoRun", &H91, Microsoft.Win32.RegistryValueKind.DWord)
        subkey.Close()
    End Sub


   
End Module

Module Module_Login_Setup
    Public LoginUserName As String      '已登入之使用者名稱
    Public LoginUserPass As String = ""    '已登入之使用者名稱
    Public SuperUser As Boolean       '已登入之使用者名稱
    Public LoginInitFlag As Boolean = False
    '使用者 權限設定之結構及變數
    Public Structure UserRightsStructure
        Public Name As String
        Public Password As String
        Public Process As Boolean
        Public Recipe As Boolean
        Public Manual As Boolean
        Public Alarm As Boolean
        Public Record As Boolean
        Public Parameter As Boolean
        Public Maintain As Boolean
        Public Authority As Boolean
    End Structure

    Public Const MaxUser As Integer = 32            '預設最大為 0~32 共33個使用者 
    Public UserRights(100) As UserRightsStructure   '預設最大為 100個使用者結構

    '程式實際使用之變數
    Public Rights_Process As Boolean            '製程畫面權限
    Public Rights_Recipe As Boolean             '配方畫面權限
    Public Rights_Manual As Boolean             '手動畫面權限
    Public Rights_Alarm As Boolean              '異常畫面權限
    Public Rights_Recodrd As Boolean            '記錄畫面權限
    Public Rights_Parameter As Boolean          '參數畫面權限
    Public Rights_Maintain As Boolean           '保養畫面權限
    Public Rights_Authority As Boolean          '權限設定畫面權限

    Public lblUserNo(MaxUser) As Label          '使用者編號 文字標籤物件
    Public txtUserName(MaxUser) As TextBox      '輸入使用者 文字方塊物件
    Public txtPassword(MaxUser) As TextBox      '輸入密碼 文字方塊物件
    Public chkProcess(MaxUser) As CheckBox      '核取 製程畫面 核取方塊物件
    Public chkRecipe(MaxUser) As CheckBox       '核取 配方畫面 核取方塊物件
    Public chkManual(MaxUser) As CheckBox       '核取 手動畫面 核取方塊物件
    Public chkAlarm(MaxUser) As CheckBox        '核取 異常畫面 核取方塊物件
    Public chkRecord(MaxUser) As CheckBox       '核取 記錄畫面 核取方塊物件
    Public chkParameter(MaxUser) As CheckBox    '核取 參數畫面 核取方塊物件
    Public chkMaintain(MaxUser) As CheckBox     '核取 保養畫面 核取方塊物件
    Public chkAuthority(MaxUser) As CheckBox    '核取 權限畫面 核取方塊物件

    '將所有權限清除
    Public Sub DisableAllRights()
        Rights_Process = False
        Rights_Recipe = False
        Rights_Manual = False
        Rights_Alarm = False
        Rights_Recodrd = False
        Rights_Parameter = False
        Rights_Maintain = False
        Rights_Authority = False
    End Sub

    '將所有權限致能
    Public Sub EnableAllRights()
        Rights_Process = True
        Rights_Recipe = True
        Rights_Manual = True
        Rights_Alarm = True
        Rights_Recodrd = True
        Rights_Parameter = True
        Rights_Maintain = True
        Rights_Authority = True
    End Sub
    '設定超級使用者函數
    Public Sub SetSuperPass()
        UserRights(MaxUser).Name = "CELLO"
        UserRights(MaxUser).Password = "CELLOPASS"
        UserRights(MaxUser).Process = True
        UserRights(MaxUser).Recipe = True
        UserRights(MaxUser).Alarm = True
        UserRights(MaxUser).Manual = True
        UserRights(MaxUser).Record = True
        UserRights(MaxUser).Parameter = True
        UserRights(MaxUser).Maintain = True
        UserRights(MaxUser).Authority = True
    End Sub

    '將權限設定寫入設定檔
    Public Sub WriteUserRightsFile(ByVal sfile As String, ByVal rs() As UserRightsStructure)
        Dim filenum, i As Integer
        filenum = FreeFile()
        FileOpen(filenum, sfile, OpenMode.Random, , OpenShare.Shared, 40)
        For i = 0 To MaxUser
            FilePut(filenum, rs(i))
        Next i
        FileClose(filenum)
    End Sub
    '將權限設定讀出
    Public Sub ReadUserRightsFile(ByVal sfile As String, ByRef rs() As UserRightsStructure)
        Dim i, filenum As Integer
        On Error Resume Next
        filenum = FreeFile()
        FileOpen(filenum, sfile, OpenMode.Random, , , 40)
        If LOF(filenum) = 0 Then
            For i = 0 To MaxUser
                UserRights(i).Name = ""
                UserRights(i).Password = ""
                UserRights(MaxUser).Process = False
                UserRights(MaxUser).Recipe = False
                UserRights(MaxUser).Alarm = False
                UserRights(MaxUser).Manual = False
                UserRights(MaxUser).Record = False
                UserRights(MaxUser).Parameter = False
                UserRights(MaxUser).Maintain = False
                UserRights(MaxUser).Authority = False
                FilePut(filenum, UserRights(i))
            Next i
        Else
            For i = 0 To MaxUser - 1
                FileGet(filenum, rs(i))
            Next i
        End If
        FileClose(filenum)
    End Sub
    Public Sub AddAuthoritySetupToPanel(ByVal pnl As Panel, ByVal Data_Start As Integer, ByVal Data_End As Integer)
        Dim i As Integer
        Dim sp As Integer = 40
        Dim txtsp1, txtsp2, txtheight, txtwidth As Integer
        Dim chksp1, chksp2 As Integer
        Dim chkBoxWidth As Integer
        'Dim graph As Graphics
        'If LoginInitFlag = True Then Exit Sub

        txtsp1 = 38    '文字方塊第一點位置
        txtsp2 = 122    '文字方塊 X 軸間隔
        txtwidth = 112  '文字方塊之寬度
        txtheight = 32  '文字方塊之高度(固定,隨字型大小設定)
        sp = 40         'Y軸間隔


        chkBoxWidth = 40    '核取方塊 寬度 (按鈕大小)
        chksp1 = 300        '核取方塊 X軸第一個位置
        chksp2 = 90         '核取方塊 X軸間距


        'graph = pnl.CreateGraphics
        For i = Data_Start To Data_End - 1
            FormLoginSetups.pgbShowAuthority.PerformStep()

            lblUserNo(i) = New Label
            lblUserNo(i).Name = "lblUserNo" & Format(i, "00")
            lblUserNo(i).Text = Format(i + 1, "00")
            lblUserNo(i).Font = New Font("Arial", 12, System.Drawing.FontStyle.Regular)
            lblUserNo(i).Width = 35
            lblUserNo(i).Height = txtheight
            lblUserNo(i).Top = i * sp + 24
            lblUserNo(i).Left = 0
            pnl.Controls.Add(lblUserNo(i))

            txtUserName(i) = New TextBox
            txtUserName(i).Name = "txtUserName" & Format(i, "00")
            txtUserName(i).Font = New Font("Arial", 16, System.Drawing.FontStyle.Regular)
            txtUserName(i).Width = txtwidth
            txtUserName(i).Height = txtheight
            txtUserName(i).Top = i * sp + 16
            txtUserName(i).Left = txtsp1 + txtsp2 * 0
            AddHandler txtUserName(i).MouseDown, AddressOf txtUser_MouseDown
            pnl.Controls.Add(txtUserName(i))

            txtPassword(i) = New TextBox
            txtPassword(i).Name = "txtPassword" & Format(i, "00")
            txtPassword(i).PasswordChar = "*"
            txtPassword(i).Font = New Font("Arial", 16, System.Drawing.FontStyle.Regular)
            txtPassword(i).Width = txtwidth
            txtPassword(i).Height = txtheight
            txtPassword(i).Top = i * sp + 16
            txtPassword(i).Left = txtsp1 + txtsp2 * 1
            AddHandler txtPassword(i).MouseDown, AddressOf txtUser_MouseDown
            pnl.Controls.Add(txtPassword(i))

            chkProcess(i) = New CheckBox
            chkProcess(i).Name = "chkProcess" & Format(i, "00")
            chkProcess(i).Font = New Font("Arial", 16, System.Drawing.FontStyle.Regular)
            chkProcess(i).Top = i * sp + 16
            chkProcess(i).Left = chksp1 + chksp2 * 0
            chkProcess(i).Width = chkBoxWidth
            AddHandler chkProcess(i).Click, AddressOf chkbox_Click
            pnl.Controls.Add(chkProcess(i))

            chkRecipe(i) = New CheckBox
            chkRecipe(i).Name = "chkRecipe" & Format(i, "00")
            chkRecipe(i).Font = New Font("Arial", 16, System.Drawing.FontStyle.Regular)
            chkRecipe(i).Top = i * sp + 16
            chkRecipe(i).Left = chksp1 + chksp2 * 1
            chkRecipe(i).Width = chkBoxWidth
            AddHandler chkRecipe(i).Click, AddressOf chkbox_Click
            pnl.Controls.Add(chkRecipe(i))

            chkManual(i) = New CheckBox
            chkManual(i).Name = "chkManual" & Format(i, "00")
            chkManual(i).Font = New Font("Arial", 16, System.Drawing.FontStyle.Regular)
            chkManual(i).Top = i * sp + 16
            chkManual(i).Left = chksp1 + chksp2 * 2
            chkManual(i).Width = chkBoxWidth
            AddHandler chkManual(i).Click, AddressOf chkbox_Click
            pnl.Controls.Add(chkManual(i))

            chkAlarm(i) = New CheckBox
            chkAlarm(i).Name = "chkAlarm" & Format(i, "00")
            chkAlarm(i).Font = New Font("Arial", 16, System.Drawing.FontStyle.Regular)
            chkAlarm(i).Top = i * sp + 16
            chkAlarm(i).Left = chksp1 + chksp2 * 3
            chkAlarm(i).Width = chkBoxWidth
            AddHandler chkAlarm(i).Click, AddressOf chkbox_Click
            pnl.Controls.Add(chkAlarm(i))

            chkRecord(i) = New CheckBox
            chkRecord(i).Name = "chkRecord" & Format(i, "00")
            chkRecord(i).Font = New Font("Arial", 16, System.Drawing.FontStyle.Regular)
            chkRecord(i).Top = i * sp + 16
            chkRecord(i).Left = chksp1 + chksp2 * 4
            chkRecord(i).Width = chkBoxWidth
            AddHandler chkRecord(i).Click, AddressOf chkbox_Click
            pnl.Controls.Add(chkRecord(i))

            chkParameter(i) = New CheckBox
            chkParameter(i).Name = "chkParameter" & Format(i, "00")
            chkParameter(i).Font = New Font("Arial", 16, System.Drawing.FontStyle.Regular)
            chkParameter(i).Top = i * sp + 16
            chkParameter(i).Left = chksp1 + chksp2 * 5
            chkParameter(i).Width = chkBoxWidth
            AddHandler chkParameter(i).Click, AddressOf chkbox_Click
            pnl.Controls.Add(chkParameter(i))


            chkAuthority(i) = New CheckBox
            chkAuthority(i).Name = "chkAuthority" & Format(i, "00")
            chkAuthority(i).Font = New Font("Arial", 16, System.Drawing.FontStyle.Regular)
            chkAuthority(i).Top = i * sp + 16
            chkAuthority(i).Left = chksp1 + chksp2 * 6
            chkAuthority(i).Width = chkBoxWidth
            AddHandler chkAuthority(i).Click, AddressOf chkbox_Click
            pnl.Controls.Add(chkAuthority(i))


            chkMaintain(i) = New CheckBox
            chkMaintain(i).Name = "chkMaintain" & Format(i, "00")
            chkMaintain(i).Font = New Font("Arial", 16, System.Drawing.FontStyle.Regular)
            chkMaintain(i).Top = i * sp + 16
            chkMaintain(i).Left = chksp1 + chksp2 * 7
            chkMaintain(i).Width = chkBoxWidth
            AddHandler chkMaintain(i).Click, AddressOf chkbox_Click
            pnl.Controls.Add(chkMaintain(i))



            LoginInitFlag = True
            'graph.DrawLine(Pens.Black, 0, i * sp, pnl.Width, i * sp)
        Next

        FormLoginSetups.pgbShowAuthority.Visible = False
    End Sub

    Private Sub txtUser_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        CallKeyboard1(sender)
        '資料變更,設定按鈕文字
        SetModifiedButton(FormLoginSetups.btnSave, "*")
    End Sub

    Private Sub chkbox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '資料變更,設定按鈕文字
        SetModifiedButton(FormLoginSetups.btnSave, "*")
    End Sub

    Public Sub SetFromRights()
        Dim i As Integer
        On Error Resume Next
        For i = 0 To MaxUser - 1
            txtUserName(i).Text = UserRights(i).Name
            txtPassword(i).Text = UserRights(i).Password
            chkProcess(i).Checked = UserRights(i).Process
            chkRecipe(i).Checked = UserRights(i).Recipe
            chkManual(i).Checked = UserRights(i).Manual
            chkAlarm(i).Checked = UserRights(i).Alarm
            chkRecord(i).Checked = UserRights(i).Record
            chkParameter(i).Checked = UserRights(i).Parameter
            chkMaintain(i).Checked = UserRights(i).Maintain
            chkAuthority(i).Checked = UserRights(i).Authority
        Next
        'Public chkProcess(MaxUser) As CheckBox
        'Public chkRecipe(MaxUser) As CheckBox
        'Public chkManual(MaxUser) As CheckBox
        'Public chkAlarm(MaxUser) As CheckBox
        'Public chkRecord(MaxUser) As CheckBox
        'Public chkParameter(MaxUser) As CheckBox
        'Public chkMaintain(MaxUser) As CheckBox
        'Public chkAuthority(MaxUser) As CheckBox

    End Sub

    Public Sub GetFormRights()
        Dim i As Integer
        For i = 0 To MaxUser - 1
            UserRights(i).Name = txtUserName(i).Text
            UserRights(i).Password = txtPassword(i).Text
            UserRights(i).Process = chkProcess(i).Checked
            UserRights(i).Recipe = chkRecipe(i).Checked()
            UserRights(i).Manual = chkManual(i).Checked()
            UserRights(i).Alarm = chkAlarm(i).Checked
            UserRights(i).Record = chkRecord(i).Checked
            UserRights(i).Parameter = chkParameter(i).Checked
            UserRights(i).Maintain = chkMaintain(i).Checked
            UserRights(i).Authority = chkAuthority(i).Checked
        Next
    End Sub


End Module

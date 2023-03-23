'Add By Vincent 20190710  ----------------------------------------------------------  Start
Public Class FormSanAnBarcodeInput
    Public BarcodeInput As String = ""

    Public RecipeFileInput As String = ""
    Public BarcodeInputMode As Boolean = True
    Public Inputed As Boolean = False
    Public BarcodeCheckOK As Boolean = False
    Public BarcodeCheckAbort As Boolean = False


    Public OPID As String = ""
    Public LotID As New ArrayList
    Public Sub Input(ByVal sEQID As String)
        lblEQID.Text = sEQID
        Restart()
        ChangeLanguage()
        Me.Show()
    End Sub
    Private Sub FormBarcodeEnter_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Restart()
        ChangeLanguage()
    End Sub
    Private Sub FormSanAnBarcodeInput_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        Timer1.Interval = 200
        Timer1.Enabled = True
        txtOPID.Focus()
        txtOPID.SelectAll()
    End Sub
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Static lang As Integer
        If lang <> SystemLanguage Then
            ChangeLanguage()
        End If
        lblLotIDCount.Text = LotID.Count.ToString

    End Sub
    Public Sub ChangeLanguage()
        lblEQIDText.Text = GetLangText("機台編號:", "EQ ID:")
        lblLotIDListText.Text = GetLangText("批號清單:", "Lot List:")
        lblLotIDText.Text = GetLangText("批號:", "Lot ID:")
        lblOPIDText.Text = GetLangText("工號:", "Operator ID:")

        btnRunProcess.Text = GetLangText("執行製程", "Run")
        btnClearData.Text = GetLangText("清除資料", "Clr data.")

        btnExit.Text = GetLangText("離開", "Exit")
        btnKeyIn.Text = GetLangText("手動輸入", "KeyIn")
        btnBarcodeReader.Text = GetLangText("刷入條碼", "Barcode")

    End Sub

    Public Sub Restart()
        LotID.Clear()
        lstLotID.Items.Clear()
        Inputed = False
        BarcodeInput = ""
        RecipeFileInput = ""
        txtOPID.Text = ""
        txtLotID.Text = ""
        OPID = ""
        BarcodeInputMode = True
        SetBarCodeMode(BarcodeInputMode)
        btnBarcodeReader.Text = GetLangText("刷入條碼", "Barcode")
        btnKeyIn.Text = GetLangText("手動輸入", "Key In")

        txtOPID.Focus()
        txtOPID.SelectAll()
    End Sub
    Public Function SetBarCodeMode(ByVal mode As Boolean) As Boolean
        BarcodeInputMode = mode
        ObjShow.Show(BarcodeInputMode, btnBarcodeReader, Color.Lime, Color.Snow)
        ObjShow.Show(Not BarcodeInputMode, btnKeyIn, Color.Lime, Color.Snow)
        Return BarcodeInputMode
    End Function

#Region "手動輸入"
    Private Sub txtOPID_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles txtOPID.MouseDown
        If BarcodeInputMode = False Then
            FormKeyboard1s.KeyInString(sender)
            Dim sstr As String = sender.text
            If CheckOPID(sstr) Then
                txtLotID.Focus()
                txtLotID.SelectAll()
            Else
                txtOPID.Focus()
                txtOPID.SelectAll()
            End If
        End If
    End Sub
    Private Sub txtLotID_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles txtLotID.MouseDown
        If BarcodeInputMode = False Then
            FormKeyboard1s.KeyInString(sender)
            Dim sstr As String = sender.text
            CheckLotID(sstr)
            txtLotID.Focus()
            txtLotID.SelectAll()
        End If
    End Sub
    'Private Sub txtOPCode_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles txtOPCode.MouseDown
    '    Dim sstr As String = sender.text
    '    If BarcodeInputMode = False Then
    '        FormKeyBoard1s.KeyInString(sender)
    '        sstr = sender.text
    '        If sstr.Length <= 0 Then
    '            MsgBoxLangErr("使用者工號未輸入!", "User ID is empty!")
    '            txtOPCode.Focus()
    '            txtOPCode.SelectAll()
    '        Else
    '            txtBarcodeMap.Focus()
    '            txtBarcodeMap.SelectAll()
    '        End If
    '    End If
    'End Sub
#End Region
#Region "Barcode 輸入"
    Private Sub txtOPID_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtOPID.KeyPress
        Dim sstr As String = sender.text
        If e.KeyChar = Chr(13) Then
            If CheckOPID(sstr) Then
                txtLotID.Focus()
                txtLotID.SelectAll()
            Else
                txtOPID.Focus()
                txtOPID.SelectAll()
            End If
        End If
    End Sub
    Private Sub txtLotID_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtLotID.KeyPress
        Dim sstr As String = sender.text
        If e.KeyChar = Chr(13) Then
            CheckLotID(sstr)
            txtLotID.Focus()
            txtLotID.SelectAll()
        End If
    End Sub

#End Region

#Region "資料檢查"
    Public Function CheckOPID(ByVal sstr As String) As Boolean
        OPID = sstr
        If sstr.Length <= 0 Then
            MsgBoxLangErr("人員工號未輸入!", "Operator ID is empty!")
            Return False
        Else
            OPID = sstr
            Return True
        End If
    End Function
    Public Function CheckLotID(ByVal sstr As String) As Boolean
        If sstr.Length <= 0 Then
            MsgBoxLangErr("產品批號未輸入!", "Lot ID is empty!")
            Return False
        Else
            Dim i As Integer = 0
            For Each aa As String In lstLotID.Items
                If aa = sstr Then
                    i += 1
                End If
            Next
            If i > 0 Then
                MsgBoxLangErr("產品批號重複! --> " & sstr, "Lot ID is existed! --> " & sstr)
                txtLotID.Text = ""
                Return False
            Else
                lstLotID.Items.Add(sstr)
                lstLotID.SelectedIndex = lstLotID.Items.Count - 1
                LotID.Clear()

                For Each aa As String In lstLotID.Items
                    LotID.Add(sstr)
                Next
                txtLotID.Text = ""
                Return True
            End If
        End If

    End Function
#End Region
#Region "按鈕動作"
    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        If MsgBoxLangYesNo("確定要離開?", "Quit?") Then
            Inputed = False
            Me.Hide()
        End If
    End Sub

    Private Sub btnBarcodeReader_Click(sender As System.Object, e As System.EventArgs) Handles btnBarcodeReader.Click
        BarcodeInputMode = True
        SetBarCodeMode(BarcodeInputMode)
        txtLotID.Focus()
        txtLotID.SelectAll()
    End Sub

    Private Sub btnKeyIn_Click(sender As System.Object, e As System.EventArgs) Handles btnKeyIn.Click
        BarcodeInputMode = False
        SetBarCodeMode(BarcodeInputMode)
        txtLotID.Focus()
        txtLotID.SelectAll()
    End Sub
    Private Sub btnClearData_Click(sender As System.Object, e As System.EventArgs) Handles btnClearData.Click
        If MsgBoxLangYesNo("確定要重新輸入資料? 所有已輸入資料都會清除!", "Confirm to restart input, All data will be clear!") Then
            Restart()
        End If
    End Sub
    Private Sub btnRunProcess_Click(sender As System.Object, e As System.EventArgs) Handles btnRunProcess.Click
        Dim i As Integer
        If OPID.Length <= 0 Or OPID = "" Then
            MsgBoxLangErr("使用者工號未輸入!", "User ID is empty!")
            txtOPID.Focus()
            txtOPID.SelectAll()
            Exit Sub
        End If
        If LotID.Count <= 0 Then
            MsgBoxLangErr("未輸入批號資料!", "No Lot ID entered!")
            txtLotID.Focus()
            txtLotID.SelectAll()
            Exit Sub
        End If
        RemoteCIM.RecipeData.EQID = RemoteCIM._MachineNo
        RemoteCIM.RecipeData.OPID = OPID
        RemoteCIM.RecipeData.ProductCount = LotID.Count
        For i = 0 To LotID.Count - 1
            RemoteCIM.RecipeData.ProductID(i).LotID = LotID.Item(i)
        Next
        Me.Hide()
    End Sub

#End Region
End Class
'Add By Vincent 20190710  ----------------------------------------------------------  Start
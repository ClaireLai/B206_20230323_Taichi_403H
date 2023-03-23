'Add by Vincent TCPIP 20200716    ------------- Start
Public Class CtlSanAnCIM
    Public Checked As Bitmap = My.Resources.BlankGreen24
    Public UnChecked As Bitmap = My.Resources.BlankRed24
    Public BarcodeInput As String = ""
    Public UserID As String = ""
    Public RecipeFileInput As String = ""
    Public BarcodeInputMode As Boolean = True
    Public Inputed As Boolean = False
    Public CasetteIndex As Integer = 0
    Public DummyWaferMessage As String = ""
    Public WaferChecked As Integer = 0
    Public WaferRun As Integer = 0
    Public TotalWafer As Integer = 0
    Public WaferSelected As Integer = 0 'Add by Vincent 20190903
    WriteOnly Property UpdateMacheID As String
        Set(value As String)
            lblEQID.Text = value
        End Set
    End Property
#Region "初始化及定時資料顯示"
    Private Sub CtlSanAnCIM_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If DesignMode Then Exit Sub
        Dim i As Integer
        Restart()
        Timer1.Interval = 250
        Timer1.Enabled = True
    End Sub
   
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        On Error Resume Next
        Static delay As Integer = 0
        Dim i As Integer
        Static lang As Integer
        If lang <> SystemLanguage Then
            ChangeLanguage()
            lang = SystemLanguage
        End If
        If TCPIP_Used Then
            lblTotalWaferCount.Text = lstWaferID.Items.Count.ToString
            If SanAnTCP._Connection.IsConnected Then
                lblAlive.BackColor = Color.Lime
                lblTimeOut.Text = "Alive"
            Else
                lblAlive.BackColor = Color.Red
                lblTimeOut.Text = "No Connection"
            End If
            If SanAnTCP._Connection.IsConnected Then
                lblAlive.BackColor = Color.Lime
                lblAlive.Text = GetLangText("已連線", "Connected")
            Else
                lblAlive.BackColor = Color.Pink
                lblAlive.Text = GetLangText("未連線", "Not Connect")
            End If



            'If SanAnTCP.Connected Then
            '    'If SanAnTCP.TimeOutError(0) Then
            '    '    lblTimeOut.BackColor = Color.Red
            '    '    lblTimeOut.Text = "TimeOut"
            '    'Else
            '    '    lblTimeOut.BackColor = Color.Snow
            '    '    lblTimeOut.Text = "Good"
            '    'End If
            'Else
            '    lblTimeOut.BackColor = Color.Snow
            '    lblTimeOut.Text = "No Connection"
            'End If
        End If



        Dim cond As Boolean = (Not ProcessMode_RUN And RemoteCIM.Enable) 'Lot 控制互鎖
        Dim cond1 As Boolean = (Not ProcessMode_RUN And RemoteCIM.Enable) ' 製程互鎖
        lblEQID.Text = RemoteCIM.EQID
        btnEndProductInput.Enabled = cond1 And (txtRunID1.Text.Length > 0) And (txtOpID.Text.Length > 0)
        'Lot Start, Stop Input

        ' And Not RemoteCIM.SanAnCIM_Start And Not RemoteCIM.SanAnCIM_Process_Start
        btnRunProcess.Enabled = cond1


        btnClearAll.Enabled = cond

        txtRunID1.Enabled = cond
        'Add By Vincent 20200929  ---------- Start
        txtRunID2.Enabled = cond
        txtRunID3.Enabled = cond
        txtRunID4.Enabled = cond
        txtRunID5.Enabled = cond
        txtRunID6.Enabled = cond
        txtRunID7.Enabled = cond
        txtRunID8.Enabled = cond
        'Add By Vincent 20200929  ---------- End

        txtOpID.Enabled = cond
        txtLotA.Enabled = cond


        ObjShow.Show(Not RemoteCIM.Enable, btnOffLine, Color.Lime, Color.Red)
        ObjShow.Show(RemoteCIM.Enable, btnInLine, Color.Lime, Color.Red)


    End Sub
    Public Sub ChangeLanguage()
        lblEQIDText.Text = GetLangText("機台編號:", "EQ ID.")
        lblOPIDtext.Text = GetLangText("工號:", "OP ID:")
        lblLotIDText.Text = GetLangText("批號:", "Lot No.")
        lblLotInfoList.Text = GetLangText("批片號清單:", "Lot Wafer List:")

        lblRecipeNameText.Text = GetLangText("配方名稱:", "Recip Name:")

        btnKeyIn.Text = GetLangText("手動輸入", "KeyIn")
        btnBarcodeReader.Text = GetLangText("刷入條碼", "Barcode")

        btnEndProductInput.Text = GetLangText("確認", "OK")

        btnRunProcess.Text = GetLangText("執行製程", "Run")
        btnClearAll.Text = GetLangText("清除資料", "Clr data.")
        btnBarcodeReader.Text = GetLangText("刷入條碼", "Barcode")
        btnKeyIn.Text = GetLangText("手動輸入", "Key In")
    End Sub

    Public Sub Restart()
        Dim i As Integer
        lblEQID.Text = RemoteCIM.EQID
        Inputed = False
        BarcodeInput = ""
        RecipeFileInput = ""
        txtLotA.Text = ""

        dgLotInfo.Rows.Clear()
        lstWaferID.Items.Clear()
        BarcodeInputMode = True
        SetBarCodeMode(BarcodeInputMode)
        txtOpID.Text = ""
        'Add by vincent 20200929  ---- Start
        txtRunID1.Text = ""
        txtRunID2.Text = ""
        txtRunID3.Text = ""
        txtRunID4.Text = ""
        txtRunID5.Text = ""
        txtRunID6.Text = ""
        txtRunID7.Text = ""
        txtRunID8.Text = ""
        'Add by vincent 20200929  ---- End
        txtLotA.Text = ""


        txtOpID.Enabled = True
        txtOpID.Focus()
        txtOpID.SelectAll()
        btnEndProductInput.Enabled = False
    End Sub
    Public Sub ClearData()
        Dim i As Integer
        dgLotInfo.Rows.Clear()
        lstWaferID.Items.Clear()
        txtOpID.Text = ""
        txtRunID1.Text = ""
        'Add by vincent 20200929  ---- Start
        txtRunID1.Text = ""
        txtRunID2.Text = ""
        txtRunID3.Text = ""
        txtRunID4.Text = ""
        txtRunID5.Text = ""
        txtRunID6.Text = ""
        txtRunID7.Text = ""
        txtRunID8.Text = ""
        'Add by vincent 20200929  ---- End
        txtLotA.Text = ""
        lblRecipeName.Text = ""
    End Sub
    Public Function SetBarCodeMode(ByVal mode As Boolean) As Boolean
        BarcodeInputMode = mode
        ObjShow.Show(BarcodeInputMode, btnBarcodeReader, Color.Lime, Color.Snow)
        ObjShow.Show(Not BarcodeInputMode, btnKeyIn, Color.Lime, Color.Snow)
        Return BarcodeInputMode
    End Function
#End Region



#Region "手動輸入"
    Private Sub txtOpID_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtOpID.MouseDown
        If BarcodeInputMode = False Then
            FormKeyboard1s.KeyInString(sender)
            If sender.Text.Length = 0 Then
                txtOpID.Focus()
                txtOpID.SelectAll()
                MsgBoxLangErr("工號未輸入!", "OP ID is empty!")
            Else
                'For 南安三安 TCPIP
                'Move to Run ID:
                SanAnTCP.E2H_RPT_EVT_IDInputComplete(RemoteCIM.RecipeData.EQID, RemoteCIM.RecipeData.OPID) 'Add By Vincent 20200929
                txtRunID1.Enabled = True
                txtRunID1.Focus()
                txtRunID1.SelectAll()
            End If
        Else
            sender.Focus()
            sender.SelectAll()
        End If
    End Sub
    'Remark  by vincent 20200929  -Start
    'Private Sub txtRunID1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtRunID1.MouseDown
    '    If BarcodeInputMode = False Then
    '        FormKeyboard1s.KeyInString(sender)
    '        If sender.Text.Length = 0 Then
    '            txtRunID1.Focus()
    '            txtRunID1.SelectAll()
    '            MsgBoxLangErr("Run ID1 未輸入!", "Run ID1 is empty!")
    '        Else
    '            If txtOpID.Text.Length > 0 Then
    '                FinishedDataEnter()
    '            End If
    '        End If
    '    Else
    '        sender.Focus()
    '        sender.SelectAll()
    '    End If
    'End Sub
    'Remark  by vincent 20200929  -End

    'Add  by vincent 20200929  ---------------- -Start
    Private Sub txtRunID1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtRunID1.MouseDown
        If BarcodeInputMode = False Then
            FormKeyboard1s.KeyInString(sender)
            If sender.Text.Length = 0 Then
                sender.Focus()
                sender.SelectAll()
                MsgBoxLangErr("Run ID1 未輸入!", "Run ID1 is empty!")
            Else
                txtRunID2.Focus()
                txtRunID2.SelectAll()
            End If
        Else
            sender.Focus()
            sender.SelectAll()
        End If
    End Sub
    Private Sub txtRunID2_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtRunID2.MouseDown
        If BarcodeInputMode = False Then
            FormKeyboard1s.KeyInString(sender)
            If sender.Text.Length = 0 Then
                sender.Focus()
                sender.SelectAll()
                MsgBoxLangErr("Run ID2 未輸入!", "Run ID2 is empty!")
            Else
                txtRunID3.Focus()
                txtRunID3.SelectAll()
            End If
        Else
            sender.Focus()
            sender.SelectAll()
        End If
    End Sub
    Private Sub txtRunID3_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtRunID3.MouseDown
        If BarcodeInputMode = False Then
            FormKeyboard1s.KeyInString(sender)
            If sender.Text.Length = 0 Then
                sender.Focus()
                sender.SelectAll()
                MsgBoxLangErr("Run ID3 未輸入!", "Run ID3 is empty!")
            Else
                txtRunID4.Focus()
                txtRunID4.SelectAll()
            End If
        Else
            sender.Focus()
            sender.SelectAll()
        End If
    End Sub
    Private Sub txtRunID4_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtRunID4.MouseDown
        If BarcodeInputMode = False Then
            FormKeyboard1s.KeyInString(sender)
            If sender.Text.Length = 0 Then
                sender.Focus()
                sender.SelectAll()
                MsgBoxLangErr("Run ID4 未輸入!", "Run ID4 is empty!")
            Else
                txtRunID5.Focus()
                txtRunID5.SelectAll()
            End If
        Else
            sender.Focus()
            sender.SelectAll()
        End If
    End Sub
    Private Sub txtRunID5_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtRunID5.MouseDown
        If BarcodeInputMode = False Then
            FormKeyboard1s.KeyInString(sender)
            If sender.Text.Length = 0 Then
                sender.Focus()
                sender.SelectAll()
                MsgBoxLangErr("Run ID5 未輸入!", "Run ID5 is empty!")
            Else
                txtRunID6.Focus()
                txtRunID6.SelectAll()
            End If
        Else
            sender.Focus()
            sender.SelectAll()
        End If
    End Sub
    Private Sub txtRunID6_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtRunID6.MouseDown
        If BarcodeInputMode = False Then
            FormKeyboard1s.KeyInString(sender)
            If sender.Text.Length = 0 Then
                sender.Focus()
                sender.SelectAll()
                MsgBoxLangErr("Run ID6 未輸入!", "Run ID6 is empty!")
            Else
                txtRunID7.Focus()
                txtRunID7.SelectAll()
            End If
        Else
            sender.Focus()
            sender.SelectAll()
        End If
    End Sub
    Private Sub txtRunID7_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtRunID7.MouseDown
        If BarcodeInputMode = False Then
            FormKeyboard1s.KeyInString(sender)
            If sender.Text.Length = 0 Then
                sender.Focus()
                sender.SelectAll()
                MsgBoxLangErr("Run ID7 未輸入!", "Run ID7 is empty!")
            Else
                txtRunID8.Focus()
                txtRunID8.SelectAll()
            End If
        Else
            sender.Focus()
            sender.SelectAll()
        End If
    End Sub
    Private Sub txtRunID8_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtRunID8.MouseDown
        If BarcodeInputMode = False Then
            FormKeyboard1s.KeyInString(sender)
            If sender.Text.Length = 0 Then
                sender.Focus()
                sender.SelectAll()
                MsgBoxLangErr("Run ID8 未輸入!", "Run ID8 is empty!")
            Else
                If txtOpID.Text.Length > 0 Then
                    FinishedDataEnter()
                Else
                    txtOpID.Focus()
                    txtOpID.SelectAll()
                    MsgBoxLangErr("工號未輸入!", "OP ID is empty!")
                End If
            End If
        Else
            sender.Focus()
            sender.SelectAll()
        End If
    End Sub
    'Add  by vincent 20200929  ---------------- -Start


    Private Sub txtLotA_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtLotA.MouseDown
        If BarcodeInputMode = False Then
            FormKeyboard1s.KeyInString(sender)
            If sender.Text.Length = 0 Then
                txtLotA.Focus()
                txtLotA.SelectAll()
                MsgBoxLangErr("批號未輸入!", "Lot ID is empty!")
            Else
                txtRunID1.Focus()
                txtRunID1.SelectAll()
            End If
        Else
            sender.Focus()
            sender.SelectAll()
        End If
    End Sub

#End Region
#Region "Barcode 輸入"
   


    Private Sub txtOpID_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtOpID.KeyPress
        If e.KeyChar = Chr(13) Then
            If sender.Text.Length = 0 Then
                txtOpID.Focus()
                txtOpID.SelectAll()
                MsgBoxLangErr("工號未輸入!", "OP ID is empty!")
            Else
                SanAnTCP.E2H_RPT_EVT_IDInputComplete(RemoteCIM.RecipeData.EQID, RemoteCIM.RecipeData.OPID) 'Add By Vincent 20200929
                txtRunID1.Enabled = True
                txtRunID1.Focus()
                txtRunID1.SelectAll()
            End If
        End If
    End Sub



    'Renark by vincent 20200929  ---------------- -Start
    ' Private Sub txtRunID_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtRunID1.KeyPress
    '    If e.KeyChar = Chr(13) Then
    '        If sender.Text.Length = 0 Then
    '            txtOpID.Focus()
    '            txtOpID.SelectAll()
    '             MsgBoxLangErr("Run ID 未輸入!", "Run ID is empty!")
    '        Else
    '            If txtOpID.Text.Length > 0 Then
    '                FinishedDataEnter()
    '            End If
    '        End If
    '    End If
    'End Sub
    'Remark by vincent 20200929  ---------------- -End

    'Add  by vincent 20200929  ---------------- -Start
    Private Sub txtRunID1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtRunID1.KeyPress
        If e.KeyChar = Chr(13) Then
            If sender.Text.Length = 0 Then
                sender.Focus()
                sender.SelectAll()
                MsgBoxLangErr("Run ID1 未輸入!", "Run ID1 is empty!")
            Else
                txtRunID2.Enabled = True
                txtRunID2.Focus()
                txtRunID2.SelectAll()
            End If
        End If
    End Sub
    Private Sub txtRunID2_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtRunID2.KeyPress
        If e.KeyChar = Chr(13) Then
            If sender.Text.Length = 0 Then
                sender.Focus()
                sender.SelectAll()
                MsgBoxLangErr("Run ID2 未輸入!", "Run ID2 is empty!")
            Else
                txtRunID3.Enabled = True
                txtRunID3.Focus()
                txtRunID3.SelectAll()
            End If
        End If
    End Sub
    Private Sub txtRunID3_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtRunID3.KeyPress
        If e.KeyChar = Chr(13) Then
            If sender.Text.Length = 0 Then
                sender.Focus()
                sender.SelectAll()
                MsgBoxLangErr("Run ID3 未輸入!", "Run ID3 is empty!")
            Else
                txtRunID4.Enabled = True
                txtRunID4.Focus()
                txtRunID4.SelectAll()
            End If
        End If
    End Sub

    Private Sub txtRunID4_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtRunID4.KeyPress
        If e.KeyChar = Chr(13) Then
            If sender.Text.Length = 0 Then
                sender.Focus()
                sender.SelectAll()
                MsgBoxLangErr("Run ID4 未輸入!", "Run ID4 is empty!")
            Else
                txtRunID5.Enabled = True
                txtRunID5.Focus()
                txtRunID5.SelectAll()
            End If
        End If
    End Sub

    Private Sub txtRunID5_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtRunID5.KeyPress
        If e.KeyChar = Chr(13) Then
            If sender.Text.Length = 0 Then
                sender.Focus()
                sender.SelectAll()
                MsgBoxLangErr("Run ID5 未輸入!", "Run ID5 is empty!")
            Else
                txtRunID6.Enabled = True
                txtRunID6.Focus()
                txtRunID6.SelectAll()
            End If
        End If
    End Sub

    Private Sub txtRunID6_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtRunID6.KeyPress
        If e.KeyChar = Chr(13) Then
            If sender.Text.Length = 0 Then
                sender.Focus()
                sender.SelectAll()
                MsgBoxLangErr("Run ID6 未輸入!", "Run ID6 is empty!")
            Else
                txtRunID7.Enabled = True
                txtRunID7.Focus()
                txtRunID7.SelectAll()
            End If
        End If
    End Sub

    Private Sub txtRunID7_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtRunID7.KeyPress
        If e.KeyChar = Chr(13) Then
            If sender.Text.Length = 0 Then
                sender.Focus()
                sender.SelectAll()
                MsgBoxLangErr("Run ID7 未輸入!", "Run ID7 is empty!")
            Else
                txtRunID8.Enabled = True
                txtRunID8.Focus()
                txtRunID8.SelectAll()
            End If
        End If
    End Sub

    Private Sub txtRunID8_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtRunID8.KeyPress
        If e.KeyChar = Chr(13) Then
            If sender.Text.Length = 0 Then
                sender.Focus()
                sender.SelectAll()
                MsgBoxLangErr("Run ID8 未輸入!", "Run ID8 is empty!")
            Else
                If txtOpID.Text.Length > 0 Then
                    FinishedDataEnter()
                Else
                    txtOpID.Focus()
                    txtOpID.SelectAll()
                    MsgBoxLangErr("工號未輸入!", "OP ID is empty!")
                End If
            End If
        End If
    End Sub
    'Add  by vincent 20200929  ---------------- End


    Private Sub txtLotA_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtLotA.KeyPress
        If e.KeyChar = Chr(13) Then
            If sender.Text.Length = 0 Then
                txtLotA.Focus()
                txtLotA.SelectAll()
                MsgBoxLangErr("批號未輸入!", "Lot ID is empty!")
            Else
                txtRunID1.Enabled = True
                txtRunID1.Focus()
                txtRunID1.SelectAll()
            End If
        End If
    End Sub
#End Region



#Region "按鈕動作"

    Private Sub btnInLine_Click(sender As System.Object, e As System.EventArgs) Handles btnInLine.Click
        If RemoteCIM.Enable = False Then
            If MsgBoxLangYesNo("是否要啟動遠端連線模式?", "Change mode to IN-LINE?") = True Then
                RemoteCIM.ChangeToInLine()
                txtOpID.Enabled = True
                txtOpID.Focus()
                txtOpID.SelectAll()
                Timer1.Enabled = True
            End If
        End If
    End Sub

    Private Sub btnOffLine_Click(sender As System.Object, e As System.EventArgs) Handles btnOffLine.Click
        If RemoteCIM.Enable = True Then
            If Rights_Recipe Then
                If MsgBoxLangYesNo("是否要停止遠端連線模式?", "Change mode to OFF-LINE?") = True Then
                    RemoteCIM.ChangeToOffLine()
                End If
            Else
                MsgBoxLangErr("權限不足，不能下線.", "No right to set off-line.")
            End If
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MsgBoxLangYesNo("確定要離開?", "Quit?") Then
            Inputed = False
            Me.Hide()
        End If
    End Sub
    '設定使用 BARCODE 輸入
    Private Sub btnBarcodeReader_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBarcodeReader.Click
        BarcodeInputMode = True
        SetBarCodeMode(BarcodeInputMode)
    End Sub
    '設定使用手動輸入
    Private Sub btnKeyIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeyIn.Click
        BarcodeInputMode = False
        SetBarCodeMode(BarcodeInputMode)
    End Sub

    '資料完成,送出 RUN_REQUEST
    Private Sub btnEndProductInput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEndProductInput.Click
        FinishedDataEnter()
    End Sub

    Public Sub FinishedDataEnter()
        Dim i As Integer
        'For 南安三安 TCPIP
        If txtOpID.Text.Length = 0 Then
            txtOpID.Focus()
            txtOpID.SelectAll()
            MsgBoxLangErr("工號未輸入!", "OP ID is empty!")
            Exit Sub
        End If
        If txtRunID1.Text.Length = 0 Then
            txtRunID1.Focus()
            txtRunID1.SelectAll()
            MsgBoxLangErr("Run ID 未輸入!", "Run ID is empty!")
            Exit Sub
        End If
        For i = 0 To RemoteCIM.RecipeData.ProductID.Length - 1
            RemoteCIM.RecipeData.ClearData()
        Next
        btnEndProductInput.Enabled = True
        btnEndProductInput.Focus()

        RemoteCIM.RecipeData.OPID = txtOpID.Text
        RemoteCIM.RecipeData.EQID = lblEQID.Text
        RemoteCIM.RecipeData.LOTID = txtLotA.Text

        'Add by vincent 20200929  ---------- Start
        'RemoteCIM.RecipeData.RUNID = txtRunID1.Text'remark by vincent 20200929
        ReDim RemoteCIM.RecipeData.RUNID_Array(7)
        RemoteCIM.RecipeData.RUNID_Array(0) = txtRunID1.Text
        RemoteCIM.RecipeData.RUNID_Array(1) = txtRunID2.Text
        RemoteCIM.RecipeData.RUNID_Array(2) = txtRunID3.Text
        RemoteCIM.RecipeData.RUNID_Array(3) = txtRunID4.Text
        RemoteCIM.RecipeData.RUNID_Array(4) = txtRunID5.Text
        RemoteCIM.RecipeData.RUNID_Array(5) = txtRunID6.Text
        RemoteCIM.RecipeData.RUNID_Array(6) = txtRunID7.Text
        RemoteCIM.RecipeData.RUNID_Array(7) = txtRunID8.Text
        Dim sstr As String = ""
        sstr = RemoteCIM.RecipeData.RUNID_Array(0)
        For i = 1 To RemoteCIM.RecipeData.RUNID_Array.Length - 1
            If RemoteCIM.RecipeData.RUNID_Array(i) <> "" Then sstr = sstr & "_" & RemoteCIM.RecipeData.RUNID_Array(i)
        Next
        RemoteCIM.RecipeData.RUNID = sstr
        'Add by vincent 20200929  ---------- End
        'SanAnTCP.E2H_RPT_EVT_IDInputComplete(RemoteCIM.RecipeData.EQID, RemoteCIM.RecipeData.RUNID & "," & RemoteCIM.RecipeData.OPID) 'remark by vincent 20200929
        SanAnTCP.E2H_RPT_EVT_IDInputComplete(RemoteCIM.RecipeData.EQID, RemoteCIM.RecipeData.RUNID) 'Add by vincent 20200929

        txtOpID.Text = ""
        txtRunID1.Text = ""
        'Add by vincent 20200929  ---- Start
        txtRunID1.Text = ""
        txtRunID2.Text = ""
        txtRunID3.Text = ""
        txtRunID4.Text = ""
        txtRunID5.Text = ""
        txtRunID6.Text = ""
        txtRunID7.Text = ""
        txtRunID8.Text = ""
        'Add by vincent 20200929  ---- End
        'Restart()
    End Sub

    Private Sub btnClearAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearAll.Click
        If ProcessMode_RUN Then
            MsgBoxLangErr("製程中.", "Running Process.")
            Exit Sub
        End If
        If MsgBoxLangYesNo("確定要清除資料?", "Confirm to clear data?") Then
            txtOpID.Text = ""
            txtRunID1.Text = ""
            'Add by vincent 20200929  ---- Start
            txtRunID1.Text = ""
            txtRunID2.Text = ""
            txtRunID3.Text = ""
            txtRunID4.Text = ""
            txtRunID5.Text = ""
            txtRunID6.Text = ""
            txtRunID7.Text = ""
            txtRunID8.Text = ""
            'Add by vincent 20200929  ---- End
            txtLotA.Text = ""
            lblRecipeName.Text = ""
            Restart()
            txtOpID.Focus()
            txtOpID.SelectAll()
        End If

    End Sub
#End Region


End Class
'Add by Vincent TCPIP 20200716    ------------- End
Public Class FormRecipeBarcodeInput
    Public BarcodeInput As String = ""
    Public UserID As String = ""
    Public RecipeFileInput As String = ""
    Public BarcodeInputMode As Boolean = True
    Public Inputed As Boolean = False
    Public CasetteIndex As Integer = 0

    Enum RunCardItem As Integer
        Product_ID = 0
        RunCard_ID = 1
        Wafer_Num = 2
    End Enum
    Private Sub FormBarcodeEnter_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Restart()
        dgRunCardInput.RowCount = 0
        CasetteIndex = 0
        lblMapCount.Text = Format(CasetteIndex, "00")
        'Timer1.Interval = 100
        'Timer1.Enabled = True
    End Sub
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Static lang As Integer
        If lang <> SystemLanguage Then
            ChangeLanguage()
        End If
    End Sub
    Public Sub ChangeLanguage()
        dgRunCardInput.Columns(0).HeaderCell.Value = GetLangText("產品名稱", "Product ID:")
        dgRunCardInput.Columns(1).HeaderCell.Value = GetLangText("工單號碼", "Lot ID:")
        dgRunCardInput.Columns(2).HeaderCell.Value = GetLangText("晶圓片數", "Wafer")
        btnDeleteLast.Text = GetLangText("刪除單筆", "Delete")
        lblOPCodeText.Text = GetLangText("輸入人員", "OP ID:")
        btnRunProcess.Text = GetLangText("執行製程", "Run")
        btnClearAll.Text = GetLangText("清除全部", "Clr All")
        btnClearSingle.Text = GetLangText("清除資料", "Clr data.")
        lblWaferNumText.Text = GetLangText("晶圓片數", "Wafer")
        lblRunCardIDText.Text = GetLangText("工單號碼", "Lot ID:")
        lblProductIDText.Text = GetLangText("產品名稱", "Product ID:")
        btnEndProductInput.Text = GetLangText("結束工單", "Finish")
        btnExit.Text = GetLangText("離開", "Exit")
        btnKeyIn.Text = GetLangText("手動輸入", "KeyIn")
        btnBarcodeReader.Text = GetLangText("刷入條碼", "Barcode")
        lblBarcodeRecipeText.Text = GetLangText("配方代號", "Recipe ID:")
        lblRecipeFileText.Text = GetLangText("配方檔案", "Recipe File:")
        btnAddData.Text = GetLangText("加入資料", "Add Data")
    End Sub
   
    Public Sub Restart()
        Inputed = False
        BarcodeInput = ""
        RecipeFileInput = ""
        txtProductID.Text = ""
        txtRunCardID.Text = ""
        txtWaferNum.Text = "0"
        txtBarcodeMap.Text = ""
        txtRecipeFile.Text = ""
        txtProductID.Enabled = True
        txtRunCardID.Enabled = True
        txtWaferNum.Enabled = True
        txtRecipeFile.Enabled = False
        txtBarcodeMap.Enabled = False
        txtOPCode.Enabled = False
        txtProductID.Focus()

        BarcodeInputMode = True
        SetBarCodeMode(BarcodeInputMode)
        btnBarcodeReader.Text = GetLangText("刷入條碼", "Barcode")
        btnKeyIn.Text = GetLangText("手動輸入", "Key In")
    End Sub
    Public Function SetBarCodeMode(ByVal mode As Boolean) As Boolean
        BarcodeInputMode = mode
        'btnBarcodeReader.BackColor = BarcodeInputMode
        'btnKeyIn.ON_OFF = Not BarcodeInputMode
        ObjShow.Show(BarcodeInputMode, btnBarcodeReader, Color.Lime, Color.Snow)
        ObjShow.Show(Not BarcodeInputMode, btnKeyIn, Color.Lime, Color.Snow)
        Return BarcodeInputMode
    End Function

#Region "手動輸入"
    Private Sub txtProductID_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles txtProductID.MouseDown
        Dim sstr As String = sender.text
        If BarcodeInputMode = False Then
            FormKeyBoard1s.KeyInString(sender)
            sstr = sender.text
            CheckProductID(sstr)
            'If sstr.Length <= 0 Then
            '    MsgBoxLangErr("產品號碼未輸入!", "Product ID is empty!")
            '    txtProductID.Focus()
            '    txtProductID.SelectAll()
            'Else
            '    txtRunCardID.Focus()
            '    txtRunCardID.SelectAll()
            'End If
        End If
    End Sub

    Private Sub txtRunCardID_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles txtRunCardID.MouseDown
        Dim sstr As String = sender.text
        If BarcodeInputMode = False Then
            FormKeyBoard1s.KeyInString(sender)
            sstr = sender.text
            CheckRunCArdID(sstr)
            'If sstr.Length <= 0 Then
            '    MsgBoxLangErr("工單號碼未輸入!", "Run Card ID is empty!")
            '    txtRunCardID.Focus()
            '    txtRunCardID.SelectAll()
            'Else
            '    txtWaferNum.Focus()
            '    txtWaferNum.SelectAll()
            'End If
        End If
    End Sub
    Private Sub txtWaferNum_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles txtWaferNum.MouseDown
        Dim sstr As String = sender.text
        If BarcodeInputMode = False Then
            FormKeyboard2s.KeyInString(sender)
            sstr = sender.text
            CheckWaferNum(sstr)
            'If Val(sstr) <= 0 Then
            '    MsgBoxLangErr("晶片數量為0", "Wafer amount is 0.")
            '    txtWaferNum.Focus()
            '    txtWaferNum.SelectAll()
            'End If
        End If
    End Sub
    Private Sub btnAddData_Click(sender As System.Object, e As System.EventArgs) Handles btnAddData.Click
        Dim sstr As String = txtWaferNum.Text
        CheckWaferNum(sstr)
    End Sub
    Private Sub txtOPCode_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles txtOPCode.MouseDown
        Dim sstr As String = sender.text
        If BarcodeInputMode = False Then
            FormKeyBoard1s.KeyInString(sender)
            sstr = sender.text
            If sstr.Length <= 0 Then
                MsgBoxLangErr("使用者工號未輸入!", "User ID is empty!")
                txtOPCode.Focus()
                txtOPCode.SelectAll()
            Else
                txtBarcodeMap.Focus()
                txtBarcodeMap.SelectAll()
            End If
        End If
    End Sub
    Private Sub txtBarcodeMap_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles txtBarcodeMap.MouseDown
        Dim sstr As String = sender.text
        If BarcodeInputMode = False Then
            FormKeyBoard1s.KeyInString(sender)
            sstr = sender.text
            If sstr.Length <= 0 Then
                MsgBoxLangErr("配方代號未輸入!", "Recipe Barcode mapping ID empty!")
                txtBarcodeMap.Focus()
                txtBarcodeMap.SelectAll()
            Else
                Dim sstr1 As String = RecipeMapEditor.CheckBarcodeRecipe(txtBarcodeMap.Text)
                If sstr1 = "" Then
                    MsgBoxLangErr("沒有對應之配方檔名!", "No Recipe file!")
                    txtBarcodeMap.Focus()
                    txtBarcodeMap.SelectAll()
                Else
                    UserID = txtOPCode.Text
                    BarcodeInput = txtBarcodeMap.Text
                    txtRecipeFile.Text = sstr1
                    RecipeFileInput = sstr1
                    MsgBoxLangOK("配方檔名為: " & sstr1, "Recipe File is: " & sstr1)
                End If
            End If
        End If
    End Sub
#End Region
#Region "Barcode 輸入"

    Public Sub CheckProductID(ByVal sstr As String)
        If sstr.Length <= 0 Then
            MsgBoxLangErr("產品號碼未輸入!", "Product ID is empty!")
            txtProductID.Focus()
            txtProductID.SelectAll()
        Else
            txtRunCardID.Focus()
            txtRunCardID.SelectAll()
        End If
    End Sub
    Private Sub txtProductID_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtProductID.KeyPress
        Dim sstr As String = sender.text
        If e.KeyChar = Chr(13) Then
            CheckProductID(sstr)
        End If
    End Sub
    Public Sub CheckRunCArdID(ByVal sstr As String)
        If sstr.Length <= 0 Then
            MsgBoxLangErr("工單號碼未輸入!", "Run Card ID is empty!")
            txtRunCardID.Focus()
            txtRunCardID.SelectAll()
        Else
            txtWaferNum.Focus()
            txtWaferNum.SelectAll()
        End If
    End Sub
    Private Sub txtRunCardID_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtRunCardID.KeyPress
        Dim sstr As String = sender.text
        If e.KeyChar = Chr(13) Then
            CheckRunCArdID(sstr)
        End If
    End Sub
    Public Sub CheckWaferNum(ByVal sstr As String)
        If txtWaferNum.Text.Length <= 0 Then
            MsgBoxLangErr("工單號碼未輸入!", "Run Card ID is empty!")
            txtRunCardID.Focus()
            txtRunCardID.SelectAll()
        End If
        If Val(sstr) <= 0 Or Val(sstr) > 26 Then
            MsgBoxLangErr("晶片數量不正確!", "Wafer amount wrong.")
            txtWaferNum.Focus()
            txtWaferNum.SelectAll()
        Else
            If dgRunCardInput.RowCount >= 0 Then
                dgRunCardInput.RowCount += 1
                dgRunCardInput.Rows(CasetteIndex).HeaderCell.Value = Format(CasetteIndex + 1, "00")
                dgRunCardInput.Item(RunCardItem.Product_ID, CasetteIndex).Value = txtProductID.Text
                dgRunCardInput.Item(RunCardItem.RunCard_ID, CasetteIndex).Value = txtRunCardID.Text
                dgRunCardInput.Item(RunCardItem.Wafer_Num, CasetteIndex).Value = txtWaferNum.Text
                CasetteIndex = dgRunCardInput.RowCount
                lblMapCount.Text = Format(CasetteIndex, "00")
                dgRunCardInput.Update()
                txtProductID.Text = ""
                txtRunCardID.Text = ""
                txtWaferNum.Text = "0"
                txtBarcodeMap.Text = ""
                txtRecipeFile.Text = ""
                txtRecipeFile.Enabled = False

                txtProductID.Focus()
                txtProductID.SelectAll()
            End If

        End If
    End Sub
    Private Sub txtWaferNum_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtWaferNum.KeyPress
        Dim sstr As String = sender.text
        If e.KeyChar = Chr(13) Then
            CheckWaferNum(sstr)
        End If
    End Sub
    Private Sub txtOpCode_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtOPCode.KeyPress
        Dim sstr As String = sender.text
        If e.KeyChar = Chr(13) Then
            If sstr.Length <= 0 Then
                MsgBoxLangErr("使用者工號未輸入!", "User ID is empty!")
                txtOPCode.Focus()
                txtOPCode.SelectAll()
            Else
                txtBarcodeMap.Focus()
                txtBarcodeMap.SelectAll()
            End If
        End If
    End Sub
    Private Sub txtBarcodeMap_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtBarcodeMap.KeyPress
        Dim sstr As String = sender.text
        If e.KeyChar = Chr(13) Then
            If sstr.Length <= 0 Then
                MsgBoxLangErr("配方代號未輸入!", "Recipe Barcode mapping ID empty!")
                txtBarcodeMap.Focus()
                txtBarcodeMap.SelectAll()
            Else
                Dim sstr1 As String = RecipeMapEditor.CheckBarcodeRecipe(txtBarcodeMap.Text)
                If sstr1 = "" Then
                    MsgBoxLangErr("沒有對應之配方檔名!", "No Recipe file!")
                    txtBarcodeMap.Focus()
                    txtBarcodeMap.SelectAll()
                Else
                    UserID = txtOPCode.Text
                    BarcodeInput = txtBarcodeMap.Text
                    txtRecipeFile.Text = sstr1
                    RecipeFileInput = sstr1
                    MsgBoxLangOK("配方檔名為: " & sstr1, "Recipe File is: " & sstr1)
                End If
            End If
        End If
    End Sub
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
        txtProductID.Focus()
        txtProductID.SelectAll()
    End Sub

    Private Sub btnKeyIn_Click(sender As System.Object, e As System.EventArgs) Handles btnKeyIn.Click
        BarcodeInputMode = False
        SetBarCodeMode(BarcodeInputMode)
        txtProductID.Focus()
        txtProductID.SelectAll()
    End Sub

    Private Sub btnStartBarcode_Click(sender As System.Object, e As System.EventArgs) Handles btnEndProductInput.Click
        If dgRunCardInput.RowCount = 0 Then
            MsgBoxLangErr("沒有資料!", "No Production data!")
            txtProductID.Focus()
            txtProductID.SelectAll()
            Exit Sub
        End If
        If MsgBoxLangYesNo("結束工單輸入，刷入工號及配方代碼?", "End product ID key in, Input user and recipe map code?") Then
            txtProductID.Text = ""
            txtRunCardID.Text = ""
            txtWaferNum.Text = ""
            txtOPCode.Text = ""

            txtProductID.Enabled = False
            txtRunCardID.Enabled = False
            txtWaferNum.Enabled = False
            txtOPCode.Enabled = True
            txtBarcodeMap.Enabled = True

            BarcodeInputMode = True
            SetBarCodeMode(BarcodeInputMode)
            txtBarcodeMap.Text = ""
            txtOPCode.Focus()
            txtOPCode.SelectAll()
        End If
    End Sub

    Private Sub btnRunProcess_Click(sender As System.Object, e As System.EventArgs) Handles btnRunProcess.Click
        If dgRunCardInput.RowCount = 0 Then
            MsgBoxLangErr("沒有資料!", "No Production data!")
            txtProductID.Focus()
            txtProductID.SelectAll()
            Exit Sub
        End If
        If txtOPCode.Text.Length <= 0 Then
            MsgBoxLangErr("使用者工號未輸入!", "User ID is empty!")
            txtOPCode.Focus()
            txtOPCode.SelectAll()
            Exit Sub
        End If
        If txtBarcodeMap.Text.Length <= 0 Then
            MsgBoxLangErr("配方代號未輸入!", "Recipe Barcode mapping ID empty!")
            txtBarcodeMap.Focus()
            txtBarcodeMap.SelectAll()
            Exit Sub
        End If
        Dim astr1 As String = RecipeMapEditor.CheckBarcodeRecipe(txtBarcodeMap.Text)
        If astr1 = "" Then
            MsgBoxLangErr("沒有對應之配方檔名!", "No Recipe file!")
            txtBarcodeMap.Focus()
            txtBarcodeMap.SelectAll()
            Exit Sub
        End If
        If dgRunCardInput.RowCount > 0 Then
            If MsgBoxLangYesNo("確定要執行製程?", "Confirm to Run Process?") Then

                Dim i As Integer
                For i = 0 To dgRunCardInput.RowCount - 1
                    Dim sstr1 As String = dgRunCardInput.Item(RunCardItem.Product_ID, i).Value
                    Dim sstr2 As String = dgRunCardInput.Item(RunCardItem.RunCard_ID, i).Value
                    Dim sstr3 As String = dgRunCardInput.Item(RunCardItem.Wafer_Num, i).Value
                    RecipeMapEditor.RunCard.UserID = UserID
                    RecipeMapEditor.RunCard.BarcodeMap = BarcodeInput
                    RecipeMapEditor.RunCard.RecipeName = RecipeFileInput
                    RecipeMapEditor.RunCard.PushData(sstr1, sstr2, sstr3)
                Next
                Inputed = True
                Me.Close()
            End If
        Else
            MsgBoxLangErr("未輸入資料.", "No Data Input.")
        End If
    End Sub

    Private Sub btnClearAll_Click(sender As System.Object, e As System.EventArgs) Handles btnClearAll.Click
        If MsgBoxLangYesNo("確定要重新輸入資料? 所有已輸入資料都會清除!", "Confirm to restart input, All data will be clear!") Then
            dgRunCardInput.RowCount = 0
            CasetteIndex = 0
            Restart()
        End If
    End Sub

    Private Sub btnClearSingle_Click(sender As System.Object, e As System.EventArgs) Handles btnClearSingle.Click
        If MsgBoxLangYesNo("確定要清除資料?", "Confirm to clear data?") Then
            txtProductID.Text = ""
            txtRunCardID.Text = ""
            txtWaferNum.Text = "0"
            txtBarcodeMap.Text = ""
            txtRecipeFile.Text = ""
            txtProductID.Focus()
            txtProductID.SelectAll()
           
        End If
      
    End Sub



    Private Sub btnDeleteLast_Click(sender As System.Object, e As System.EventArgs) Handles btnDeleteLast.Click
        'Dim sstr As Integer = dgRunCardInput.CurrentRow.Index
        If dgRunCardInput.RowCount > 0 Then
            If dgRunCardInput.CurrentRow.Index < 0 Then
                MsgBoxLangErr("請先點選下方資料列.", "Please select one row.")
                Exit Sub
            End If
        End If
        If dgRunCardInput.RowCount <= 0 Then
            MsgBoxLangErr("無資料可刪除.", "No data to delete.")
            Exit Sub
        End If
        If dgRunCardInput.RowCount > 0 Then
            If MsgBoxLangYesNo("確定要清除第 " & Format(dgRunCardInput.CurrentRow.Index + 1, "00") & " 筆資料: ", "Confirm to delete:" & Format(dgRunCardInput.CurrentRow.Index, "00") & " Data: ") Then

                If dgRunCardInput.CurrentRow.Index = (dgRunCardInput.RowCount - 1) Then
                    dgRunCardInput.RowCount -= 1
                    CasetteIndex -= 1
                Else
                    Dim i As Integer
                    For i = dgRunCardInput.CurrentRow.Index To dgRunCardInput.RowCount - 2
                        dgRunCardInput.Item(RunCardItem.Product_ID, i).Value = dgRunCardInput.Item(RunCardItem.Product_ID, i + 1).Value
                        dgRunCardInput.Item(RunCardItem.RunCard_ID, i).Value = dgRunCardInput.Item(RunCardItem.RunCard_ID, i + 1).Value
                        dgRunCardInput.Item(RunCardItem.Wafer_Num, i).Value = dgRunCardInput.Item(RunCardItem.Wafer_Num, i + 1).Value
                    Next
                    dgRunCardInput.RowCount -= 1
                    CasetteIndex -= 1
                End If
                lblMapCount.Text = Format(CasetteIndex, "00")
            End If
        End If
    End Sub
#End Region
   
    'Structure rowcol
    '    Dim ColumnIndex As Integer
    '    Dim RowIndex As Integer
    'End Structure
  
    'Private Sub dgRecipeEdit_CellMouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgRunCardInput.CellMouseDown
    '    DataGridViewInput(sender, e.ColumnIndex, e.RowIndex)
    'End Sub
    'Private Sub DataGridViewInput(ByRef sender As DataGridView, ByVal col As Integer, ByVal row As Integer)
    '    Dim txtInputTemp As New TextBox
    '    Dim index As Integer
    '    Dim e As rowcol
    '    e.ColumnIndex = col
    '    e.RowIndex = row
    '    If e.ColumnIndex < 0 Or e.RowIndex < 0 Then
    '        Exit Sub
    '    End If
    '    sender.CurrentCell = dgRunCardInput(e.ColumnIndex, e.RowIndex)
    '    index = e.RowIndex
    '    txtInputTemp.Text = dgRunCardInput.Item(e.ColumnIndex, e.RowIndex).Value
    '    Select Case index
    '        Case RunCardItem.Product_ID
    '            'dgRunCardInput.Item(RunCardItem.RunCard_ID, e.RowIndex).Selected = True

    '        Case RunCardItem.RunCard_ID
    '            'dgRunCardInput.Item(RunCardItem.Wafer_Num, e.RowIndex).Selected = True
    '            'MoveToNextColumn()
    '        Case RunCardItem.Wafer_Num
    '            dgRunCardInput.RowCount += 1
    '    End Select

    'End Sub
    'Public Sub MoveToNColumn(ByVal col As Integer)
    '    '1.按下 enter 後跳向某個指定欄位
    '    dgRunCardInput.CurrentCell = dgRunCardInput.Rows(dgRunCardInput.CurrentRow.Index - 1).Cells(col)
    'End Sub

    'Public Sub MoveToNextColumn()
    '    '2.按下 enter 後跳向右邊欄位
    '    If dgRunCardInput.CurrentCell.ColumnIndex > 0 And dgRunCardInput.CurrentCell.ColumnIndex < dgRunCardInput.ColumnCount Then
    '        dgRunCardInput.CurrentCell = dgRunCardInput.Rows(dgRunCardInput.CurrentRow.Index - 1).Cells(dgRunCardInput.CurrentCell.ColumnIndex + 1)
    '    Else
    '        If dgRunCardInput.CurrentCell.ColumnIndex > 0 Then
    '            If dgRunCardInput.CurrentCell.RowIndex < dgRunCardInput.RowCount Then
    '                dgRunCardInput.CurrentCell = dgRunCardInput.Rows(dgRunCardInput.CurrentRow.Index).Cells(0)
    '            End If
    '        End If
    '    End If

    'End Sub

    'Private Sub FormRecipeBarcodeInput_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
    '    If e.KeyChar = Chr(13) Then
    '        MoveToNextColumn()
    '    End If
    'End Sub

   


   
   
End Class
Public Class FormRecipeMapEdit

    Private Sub FormRecipeMapEdit_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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
        grpRecipeMapEditor.Text = GetLangText("條碼 - 配方對照表編輯", "Recipe Map Editor")
        btnDelete.Text = GetLangText("刪除", "Delete")
        btnSave.Text = GetLangText("儲存", "Save")
        btnModifiySelection.Text = GetLangText("修改", "Modify")
        btnRecipeSelect.Text = GetLangText("配方選擇", "Recipe")
        btnKeyIn.Text = GetLangText("手動輸入", "Keyin")
        btnBarcodeReader.Text = GetLangText("刷入條碼", "Barcode ID")
        lblBarcodeNameText.Text = GetLangText("條碼名稱", "Barcode")
        btnExit.Text = GetLangText("離開", "Exit")
        btnInsert.Text = GetLangText("加入", "Add")
        lblRecipeName.Text = GetLangText("配方檔案", "Recipe File:")
    End Sub

  
End Class
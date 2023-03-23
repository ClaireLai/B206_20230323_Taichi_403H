'Add By Vincent 20190710  ----------------------------------------------------------  Start
Public Class FormSanAnBarcodeInputConfirm
    Public Sub ChangeLanguage()
        lblEQIDText.Text = GetLangText("機台編號:", "EQ ID.")
        lblOPIDText.Text = GetLangText("工號:", "OP ID:")
        lblRunIDText.Text = GetLangText("Run ID:", "Run ID:")
        lblRecipeNameText.Text = GetLangText("Run ID:", "Run ID:")
        lblLotIDText.Text = GetLangText("批號:", "Lot No.")
        lblWaferDListText.Text = GetLangText("片號清單:", "Wafer List:")

        lblRecipeNameText.Text = GetLangText("配方名稱:", "Recip Name:")
        btnRunProcess.Text = GetLangText("執行製程", "Run")
        btnCancel.Text = GetLangText("取消", "Cancel")
    End Sub
    Public Sub Display()
        ChangeLanguage()
        Me.ShowDialog()
    End Sub



#Region "按鈕動作"
    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        If MsgBoxLangYesNo("確定要取消?", "Cancel?") Then
            SanAnTCP.ConfirmRunProcess = False
            SanAnTCP.ConfirmRunProcessCancel = True
            Me.Hide()
        End If
    End Sub

    Private Sub btnRunProcess_Click(sender As System.Object, e As System.EventArgs) Handles btnRunProcess.Click
        Dim i As Integer
        SanAnTCP.ConfirmRunProcess = True
        SanAnTCP.ConfirmRunProcessCancel = False
        Me.Hide()
    End Sub

#End Region
End Class
'Add By Vincent 20190710  ----------------------------------------------------------  Start
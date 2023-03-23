Imports System.Data
Module Module_RecipeMap
    Public RecipeMapEditor As CRecipeMap

    Class CRecipeMap
        Inherits FormRecipeMapEdit
#Region "變數定義"
        Public RecipeMapDir As String = ""
        Public RecipeMapInifile As String = ""
        Public RecipeSection As String = ""
        Public RecipePairName As String = ""
        Public BarcodeInputMode As Boolean = True
        Public RecipeSelectIndex As Integer = 0
        Public TotalRecipeMap As Integer = 0
        Public ModifyFlag As Boolean = False
        Public MapList(99) As CMapList
        Public RunCard As New CRunCard

        Public Class CRunCard
            Public Index As Integer
            Public BarcodeMap As String
            Public RecipeName As String
            Public UserID As String
            Structure SRunCard
                Public ProductID As String
                Public LotID As String
                Public WaferNum As String
            End Structure
            Public Data() As SRunCard
            Sub New()
                Clear()
            End Sub
            Public Function IsFull() As Boolean
                If Index >= 99 Then
                    Return True
                Else
                    Return False
                End If
            End Function
            Public Function IsEmpty() As Boolean
                If Index = 0 Then
                    Return True
                Else
                    Return False
                End If
            End Function
            Public Sub PushData(ByVal P_ID As String, ByVal L_ID As String, ByVal W_Num As String)
                If Index < 99 Then
                    Data(Index).ProductID = P_ID
                    Data(Index).LotID = L_ID
                    Data(Index).WaferNum = W_Num
                    Index += 1
                End If
            End Sub
            Public Sub PopData(ByRef P_ID As String, ByRef L_ID As String, ByRef W_Num As String)
                If Index > 0 Then
                    Index -= 1
                    P_ID = Data(Index).ProductID
                    L_ID = Data(Index).LotID
                    W_Num = Data(Index).WaferNum
                End If
            End Sub
            Public Sub GetData(ByVal Idx As Integer, ByRef P_ID As String, ByRef L_ID As String, ByRef W_Num As String)
                If Idx >= 0 And Idx < Index Then
                    Index -= 1
                    P_ID = Data(Idx).ProductID
                    L_ID = Data(Idx).LotID
                    W_Num = Data(Idx).WaferNum
                End If
            End Sub
            Public Sub SetData(ByVal Idx As Integer, ByVal P_ID As String, ByVal L_ID As String, ByVal W_Num As String)
                If Idx >= 0 And Idx < Index Then
                    Data(Idx).ProductID = P_ID
                    Data(Idx).LotID = L_ID
                    Data(Idx).WaferNum = W_Num
                End If
            End Sub
            Public Sub Clear()
                ReDim Data(99)
                Index = 0
                BarcodeMap = ""
                RecipeName = ""
            End Sub
        End Class
        Public Class CMapList
            Public Barcode As String
            Public RecipeName As String
            Sub New()
                Barcode = ""
                RecipeName = ""
            End Sub

        End Class
#End Region

#Region "初始化"
        Sub New()
            Dim i As Integer
            For i = 0 To 99
                MapList(i) = New CMapList
            Next

            RecipeSection = "RECIPEMAP"
            RecipePairName = "RECIPEMAP"
            RecipeMapDir = My.Computer.FileSystem.GetParentPath(CurDir()) & "\RecipeMap\"
            CheckExistDirAndCreate(RecipeMapDir)
            RecipeMapInifile = RecipeMapDir & "RecipeMap.ini"
            ReadMapIniFile()
        End Sub
#End Region

#Region "清單資料讀寫"
        Public Sub ReadMapIniFile()
            Dim i As Integer
            Dim map() As String
            'TotalRecipeMap = Val(ReadProgData("MAIN", "TotalMap", "0", RecipeMapInifile))
            TotalRecipeMap = 0
            For i = 0 To 99
                Dim sstr As String = ReadProgData(RecipeSection, RecipePairName & Format(i, "00"), "", RecipeMapInifile)
                map = sstr.Split(",", "@", "#", "$")
                If map.Length >= 2 Then
                    If map(0).Length > 0 And map(1).Length > 0 Then
                        MapList(i).Barcode = map(0)
                        MapList(i).RecipeName = map(1)
                        TotalRecipeMap += 1
                    Else
                        MapList(i).Barcode = ""
                        MapList(i).RecipeName = ""
                    End If
                End If
            Next
        End Sub
        Public Sub WriteIniFile()
            Dim i As Integer
            For i = 0 To 99
                Dim sstr As String
                sstr = MapList(i).Barcode & "," & MapList(i).RecipeName
                WriteProgData(RecipeSection, RecipePairName & Format(i, "00"), sstr, RecipeMapInifile)
            Next
        End Sub
#End Region

#Region "表單載入"
        Public Sub RefreshData()
            Dim i As Integer
            ReadMapIniFile()
            lstBarcode.Items.Clear()
            lstRecipe.Items.Clear()
            For i = 0 To TotalRecipeMap
                If MapList(i).Barcode.Length > 0 And MapList(i).RecipeName.Length > 0 Then
                    lstBarcode.Items.Add(MapList(i).Barcode)
                    lstRecipe.Items.Add(MapList(i).RecipeName)
                End If
            Next
            lblMapCount.Text = Format(TotalRecipeMap, "00")
        End Sub

        Private Sub FormRecipeMap_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
            txtRecipe.Enabled = False
            BarcodeInputMode = True
            SetBarCodeMode(BarcodeInputMode)
            btnBarcodeReader.Text = GetLangText("刷入條碼", "Barcode")
            btnKeyIn.Text = GetLangText("手動輸入", "Key In")
            RefreshData()
            txtBarcode.Focus()
            txtBarcode.Select()
        End Sub
#End Region

#Region "公用方法"
        Public Function CheckBarcodeExist(ByVal code As String) As Boolean
            Dim i As Integer
            For i = 0 To lstBarcode.Items.Count - 1
                Dim sstr As String = lstBarcode.Items.Item(i)
                If sstr.ToUpper = code.ToUpper Then
                    Return True
                End If
            Next
            Return False
        End Function
        Public Function SetBarCodeMode(ByVal mode As Boolean) As Boolean
            BarcodeInputMode = mode
            'btnBarcodeReader.ON_OFF = BarcodeInputMode
            'btnKeyIn.ON_OFF = Not BarcodeInputMode
            ObjShow.Show(BarcodeInputMode, btnBarcodeReader, Color.Lime, Color.Snow)
            ObjShow.Show(Not BarcodeInputMode, btnKeyIn, Color.Lime, Color.Snow)
            Return BarcodeInputMode
        End Function
        Public Sub FindRecipeFile(ByVal sfile As String)
            Dim nstr As String
            lstRecipe.Items.Clear()
            For Each fstr As String In My.Computer.FileSystem.GetFiles(sfile, FileIO.SearchOption.SearchTopLevelOnly, "*.rcp")
                If System.IO.File.Exists(fstr) Then
                    nstr = My.Computer.FileSystem.GetName(fstr)
                    lstRecipe.Items.Add(nstr)
                End If
            Next
        End Sub
        Public Function CheckBarcodeRecipe(ByVal barcode As String) As String
            Dim i As Integer
            For i = 0 To 99
                If MapList(i).Barcode.Length > 0 And MapList(i).RecipeName.Length > 0 Then
                    If barcode.ToUpper = MapList(i).Barcode.ToUpper Then
                        Return MapList(i).RecipeName
                    End If
                End If
            Next
            Return ""
        End Function
        Public Sub BarcodeInput()
            Dim aa As New FormRecipeBarcodeInput
            Dim Barcode As String
            Dim recipe As String
            Dim isClose As Boolean
            aa.txtProductID.Focus()
            aa.txtProductID.Select()
            aa.ChangeLanguage()
            aa.ShowDialog()
            Barcode = aa.BarcodeInput
            isClose = aa.Inputed
            recipe = CheckBarcodeRecipe(Barcode)

            If recipe <> "" Then
                FormProcesss.AutoLoadRecipeThenRun(recipe)
            Else
                If isClose Then MsgBoxLangErr("Barcode: " & Barcode & " 沒有對應配方名稱.", "No Mapped Recipe name for Barcode: " & Barcode)
            End If
        End Sub
#End Region

#Region "介面"
        Private Sub btnBarcodeReader_Click(sender As System.Object, e As System.EventArgs) Handles btnBarcodeReader.Click
            BarcodeInputMode = True
            SetBarCodeMode(BarcodeInputMode)
            txtBarcode.Focus()
            txtBarcode.Select()
        End Sub
        Private Sub btnKeyIn_Click(sender As System.Object, e As System.EventArgs) Handles btnKeyIn.Click
            BarcodeInputMode = False
            SetBarCodeMode(BarcodeInputMode)
            txtBarcode.Focus()
            txtBarcode.Select()
        End Sub
        Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
            Me.Hide()
        End Sub

        Private Sub btnRecipeSelect_Click(sender As System.Object, e As System.EventArgs) Handles btnRecipeSelect.Click
            Dim aa As New FormRecipeSelect
            aa.RecipeDir = RecipeDir
            aa.EnabledDelete = True
            aa.ShowDialog()
            If aa.RecipeFileName.Length > 0 Then
                'txtRecipe.Text = System.IO.Path.GetFileNameWithoutExtension(aa.RecipeFileName)
                txtRecipe.Text = System.IO.Path.GetFileName(aa.RecipeFileName)
            End If
        End Sub

        Private Sub btnModifiySelection_Click(sender As System.Object, e As System.EventArgs) Handles btnModifiySelection.Click
            Dim sstr1, sstr2 As String
            Dim index As Integer
            index = lstBarcode.SelectedIndex
            If lstRecipe.Items.Count < 1 Or index < 0 Then
                MsgBoxLangErr("無資料可以俢改!", "No Data to Edit.")
                Exit Sub
            End If
            sstr1 = txtBarcode.Text
            sstr2 = txtRecipe.Text
            If CheckBarcodeExist(sstr1) Then
                MsgBoxLangErr("條碼 " & sstr1 & " 已存在清單中，不可使用.", "Barcode " & sstr1 & " is Exist, Please used another barcode.")
                Exit Sub
            End If
            If MsgBoxLangYesNo("確定要修改:" & sstr1 & " => " & sstr2 & "?", "Mofidy: " & sstr1 & " => " & sstr2 & "?") Then
                ModifyFlag = True
                lstRecipe.Items.Item(index) = txtRecipe.Text
                lstBarcode.Items.Item(index) = txtBarcode.Text
                Application.DoEvents()
                System.Threading.Thread.Sleep(100)
                ModifyFlag = False
                txtBarcode.Text = ""
                txtRecipe.Text = ""
            End If
        End Sub

        Private Sub lstRecipeFile_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstRecipe.SelectedIndexChanged
            If ModifyFlag = False Then
                lstBarcode.SelectedIndex = lstRecipe.SelectedIndex

                RecipeSelectIndex = lstBarcode.SelectedIndex
                lblCurrentSelect.Text = Format(RecipeSelectIndex + 1, "00")

                txtRecipe.Text = lstRecipe.SelectedItem
                txtBarcode.Text = lstBarcode.SelectedItem
            End If
            'ModifyFlag = False
        End Sub

        Private Sub lstRecipeBarcode_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstBarcode.SelectedIndexChanged
            If ModifyFlag = False Then
                lstRecipe.SelectedIndex = lstBarcode.SelectedIndex

                RecipeSelectIndex = lstRecipe.SelectedIndex
                lblCurrentSelect.Text = Format(RecipeSelectIndex + 1, "00")

                txtRecipe.Text = lstRecipe.SelectedItem
                txtBarcode.Text = lstBarcode.SelectedItem
            End If
            'ModifyFlag = False
        End Sub

        Private Sub txtRecipeFileName_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles txtBarcode.MouseDown
            If BarcodeInputMode = False Then
                FormKeyBoard1s.KeyInString(sender)
            End If

        End Sub
        Private Sub txtRecipeName_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles txtRecipe.MouseDown
            If BarcodeInputMode = False Then
                FormKeyBoard1s.KeyInString(sender)
            End If
        End Sub

        Private Sub btnInsert_Click(sender As System.Object, e As System.EventArgs) Handles btnInsert.Click
            'Dim sstr As String = txtBarcode.Text & "," & txtRecipe.Text
            Dim sstr1, sstr2 As String
            Dim index As Integer
            index = lstBarcode.SelectedIndex
            sstr1 = txtBarcode.Text
            sstr2 = txtRecipe.Text
            If txtBarcode.Text.Length <= 0 Then
                MsgBoxLangErr("條碼未輸入.", "Barcode not entered.")
                Exit Sub
            End If
            If txtRecipe.Text.Length <= 0 Then
                MsgBoxLangErr("配方檔未輸入.", "Recipe File not entered.")
                Exit Sub
            End If
            If CheckBarcodeExist(sstr1) Then
                MsgBoxLangErr("條碼 " & sstr1 & " 已存在清單中，不可使用.", "Barcode " & sstr1 & " is Exist, Please used another barcode.")
                Exit Sub
            End If
            lstBarcode.Items.Add(txtBarcode.Text)
            lstRecipe.Items.Add(txtRecipe.Text)
            TotalRecipeMap += 1
            lblMapCount.Text = Format(TotalRecipeMap, "00")
            txtBarcode.Text = ""
            txtRecipe.Text = ""
            txtBarcode.Focus()
            txtBarcode.Select()
        End Sub
        Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
            Dim sstr1, sstr2 As String
            Dim index As Integer

            index = lstBarcode.SelectedIndex
            If index < 0 Then
                MsgBoxLangErr("無資料可以刪除.", "No data to delete.")
                Exit Sub
            End If
            sstr1 = lstBarcode.SelectedItem
            sstr2 = lstRecipe.SelectedItem
            If MsgBoxLangYesNo("確定要刪除: " & sstr1 & " => " & sstr2 & "?", "Delete: " & sstr1 & " => " & sstr2 & "?") Then
                Dim i As Integer
                lstBarcode.Items.RemoveAt(index)
                lstRecipe.Items.RemoveAt(index)
                TotalRecipeMap -= 1
                lblMapCount.Text = Format(TotalRecipeMap, "00")
                WriteIniFile()
                txtBarcode.Text = ""
                txtRecipe.Text = ""
            End If
        End Sub
        Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
            If MsgBoxLangYesNo("是否要存檔?", "Save?") Then
                Dim i As Integer
                For i = 0 To lstBarcode.Items.Count - 1
                    MapList(i).Barcode = lstBarcode.Items(i)
                    MapList(i).RecipeName = lstRecipe.Items(i)
                Next
                WriteIniFile()
            End If
        End Sub
        Private Sub txtBarcode_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtBarcode.KeyPress
            If e.KeyChar = Chr(13) Then
                txtRecipe.Focus()
                txtBarcode.Select()
                txtBarcode.Text = txtBarcode.Text.ToUpper
            End If
        End Sub

#End Region
    End Class

End Module

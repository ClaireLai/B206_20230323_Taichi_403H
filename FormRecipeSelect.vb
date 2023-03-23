Public Class FormRecipeSelect
    Private RecipeTempDir As String
    Private LongFileName As String
    Private FileName As String
    Private _EnabledDelete As Boolean

    ReadOnly Property RecipeFileName() As String
        Get
            Return FileName
        End Get
    End Property
    Property RecipeDir() As String
        Get
            Return RecipeTempDir
        End Get
        Set(ByVal value As String)
            RecipeTempDir = value
        End Set
    End Property

    WriteOnly Property EnabledDelete() As String
        Set(ByVal value As String)
            _EnabledDelete = value
        End Set
    End Property


    Private Sub FormRecipeSelect_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        btnDelete.Visible = _EnabledDelete
        RecipeTempDir = RecipeDir
        FindRecipeFile(RecipeTempDir)
    End Sub

    Private Sub btnChangeFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeFolder.Click
        Dim FolderBrowserDialog1 As New FolderBrowserDialog
        With FolderBrowserDialog1
            .RootFolder = Environment.SpecialFolder.MyComputer
            .SelectedPath = RecipeDir
            .ShowNewFolderButton = False
            .Description = "Select Folder"
            If .ShowDialog = DialogResult.OK Then
                RecipeTempDir = .SelectedPath + "\"
                FindRecipeFile(RecipeTempDir)
            End If
        End With
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        ReturnFileName()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        FindRecipeFile(RecipeTempDir)
    End Sub

    Public Sub FindRecipeFile(ByVal sfile As String)
        Dim nstr As String
        lstRecipeFile.Items.Clear()
        For Each fstr As String In My.Computer.FileSystem.GetFiles(sfile, FileIO.SearchOption.SearchTopLevelOnly, "*.rcp")
            If System.IO.File.Exists(fstr) Then
                nstr = My.Computer.FileSystem.GetName(fstr)
                lstRecipeFile.Items.Add(nstr)
            End If
        Next
    End Sub

    Private Sub lstRecipeFile_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstRecipeFile.DoubleClick
        ReturnFileName()
    End Sub

    Public Sub ReturnFileName()
        If lstRecipeFile.SelectedItem <> Nothing Then
            FileName = lstRecipeFile.SelectedItem
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        If lstRecipeFile.SelectedItem <> Nothing Then
            If IO.File.Exists(RecipeLongFileName) Then
                If MsgBoxLangYesNo("確定要刪除檔案 " + vbCrLf + FileName + " ?", "File " + vbCrLf + FileName + " confirm delete?") Then
                    Try
                        IO.File.Delete(RecipeLongFileName)
                        FindRecipeFile(RecipeTempDir)
                        RecipeLongFileName = ""
                        FileName = ""
                        lblFileName.Text = ""
                        MsgBoxLangOK("檔案 " + FileName + " 已刪除!", "File " + FileName + " deleted!")
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            Else
                MsgBoxLangErr("檔案 " + vbCrLf + FileName + " 不存在!", "File " + vbCrLf + FileName + " Not Existed!")
            End If
        Else
            MsgBoxLangErr("未選擇檔案", "No choose file.")
        End If
    End Sub

    Private Sub lstRecipeFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstRecipeFile.Click
        FileName = lstRecipeFile.SelectedItem
        RecipeLongFileName = RecipeTempDir + FileName
        lblFileName.Text = RecipeLongFileName
    End Sub
End Class
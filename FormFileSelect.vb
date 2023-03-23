Public Class FormFileSelect
    Private SelectDir As String
    Private SelectFilter As String
    Private SelectedFile As String

    WriteOnly Property Filter() As String
        Set(ByVal value As String)
            SelectFilter = value
        End Set
    End Property

    WriteOnly Property Dir() As String
        Set(ByVal value As String)
            SelectDir = value
        End Set
    End Property
    ReadOnly Property FileName() As String
        Get
            Return SelectedFile
        End Get
    End Property


    Private Sub FormRecipeSelect_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        FindFile(SelectDir, SelectFilter)
        Me.Width = 440
        Me.Height = 400
    End Sub

    Private Sub btnChangeFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeFolder.Click
        Dim FolderBrowserDialog1 As New FolderBrowserDialog
        With FolderBrowserDialog1
            .RootFolder = Environment.SpecialFolder.MyComputer
            .SelectedPath = SelectDir
            .ShowNewFolderButton = False
            .Description = "Select Folder"
            If .ShowDialog = DialogResult.OK Then
                FileSelectDir = .SelectedPath
                FindFile(SelectDir, SelectFilter)
            End If
        End With
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        If lstFileName.SelectedItem <> Nothing Then
            If lstFileName.SelectedItem <> Nothing Then SelectedFile = lstFileName.SelectedItem
            Me.DialogResult = Windows.Forms.DialogResult.OK

        End If
        Me.Close()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        FindFile(SelectDir, SelectFilter)
    End Sub

    Public Sub FindFile(ByVal sfile As String, ByVal Filter As String)
        Dim nstr As String
        lstFileName.Items.Clear()
        For Each fstr As String In My.Computer.FileSystem.GetFiles(sfile, FileIO.SearchOption.SearchTopLevelOnly, Filter)
            If System.IO.File.Exists(fstr) Then
                nstr = My.Computer.FileSystem.GetName(fstr)
                lstFileName.Items.Add(nstr)
            End If
        Next
    End Sub


    Private Sub lstFileName_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstFileName.DoubleClick
        If lstFileName.SelectedItem <> Nothing Then SelectedFile = lstFileName.SelectedItem
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        If IO.File.Exists(SelectDir + SelectedFile) Then
            If Me.Width > 600 Then
                Me.Width = 440
            Else
                Me.Width = 650
            End If
            Me.Height = 400
            richPreview.LoadFile(SelectDir + SelectedFile, RichTextBoxStreamType.PlainText)
        End If
    End Sub

    Private Sub lstFileName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstFileName.Click
        If lstFileName.SelectedItem <> Nothing Then SelectedFile = lstFileName.SelectedItem
        If IO.File.Exists(SelectDir + SelectedFile) Then

            richPreview.LoadFile(SelectDir + SelectedFile, RichTextBoxStreamType.PlainText)
        End If
    End Sub
End Class
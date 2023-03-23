Public Class ControlINIEdit
    Dim CurrentIniFileName As String

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sDir"></param>
    ''' <param name="sFilter"></param>
    ''' <param name="lstObject"></param>
    ''' <remarks></remarks>
    Public Sub FindFileToListBox(ByVal sDir As String, ByVal sFilter As String, ByRef lstObject As ListBox)
        Dim nstr As String
        lstObject.Items.Clear()
        For Each fstr As String In My.Computer.FileSystem.GetFiles(sDir, FileIO.SearchOption.SearchTopLevelOnly, sFilter)
            If System.IO.File.Exists(fstr) Then
                nstr = My.Computer.FileSystem.GetName(fstr)
                lstObject.Items.Add(nstr)
            End If
        Next
    End Sub

    Private Sub ControlINIEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FindFileToListBox(CurDir, "*.INI", lstINIFile)

    End Sub

    '-----------------------
    Dim IniFileName As String

    Private Sub lstINIFile_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstINIFile.DoubleClick
        lstINIFile.Enabled = False
        If lstINIFile.SelectedItem <> Nothing Then
            IniFileName = ProgramDir + lstINIFile.SelectedItem
            If IO.File.Exists(IniFileName) Then
                Try
                    richIniFile.LoadFile(IniFileName, RichTextBoxStreamType.UnicodePlainText)
                    ReadParameterToDataView(IniFileName, DataGridView1)

                Catch ex As Exception
                    MsgBoxLangErr(ex.Message)
                End Try
            Else
                MsgBoxLangErr("檔案不存在!", "File is not exist!")
            End If
        Else
            MsgBoxLangErr("檔案不存在!", "File is not exist!")
        End If
        lstINIFile.Enabled = True
    End Sub


    Private Sub ReadParameterToDataView(ByVal sfile As String, ByRef dg As DataGridView)
        Dim i, j, k As Integer
        Dim sstr As String
        Dim header As String
        Dim Section As String
        Dim data() As String
        Dim fs1 As System.IO.FileStream
        Dim sw1 As System.IO.StreamReader
        If FileIO.FileSystem.FileExists(sfile) = False Then
            MsgBoxLangErr("檔案不存在!!", "File not existed!!")
            Exit Sub
        End If
        CurrentIniFileName = sfile
        fs1 = New System.IO.FileStream(sfile, System.IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read, 1024)
        sw1 = New System.IO.StreamReader(fs1, System.Text.Encoding.Unicode)
        dg.Rows.Clear()
        i = 0
        Section = ""
        Try
            Do While sw1.EndOfStream = False
                sstr = sw1.ReadLine
                header = Mid(sstr, 1, 1)
                If (header <> ";") And (Len(sstr) <> 0) Then
                    If header = "[" Then
                        Section = Mid(sstr, 2, Len(sstr) - 2)

                    End If
                    If (InStr(sstr, "=") > 0) Then
                        data = sstr.Split("=")
                        dg.Rows.Add()
                        dg.Item(0, i).Value = Section
                        If data.Length > 0 Then dg.Item(1, i).Value = data(0)
                        If data.Length > 1 Then dg.Item(2, i).Value = data(1)
                        If data.Length > 2 Then dg.Item(3, i).Value = data(2)
                        i = i + 1
                    End If
                End If

            Loop
            sw1.Close()
        Catch ex As Exception
            sw1.Close()
            MsgBoxLangErr(ex.Message)
        End Try
        sw1.Dispose()
        fs1.Dispose()
    End Sub

    Private Sub DataGridView1_CellMouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDown
        DataGridViewInput(sender, e.ColumnIndex, e.RowIndex)
        richIniFile.LoadFile(IniFileName, RichTextBoxStreamType.UnicodePlainText)
    End Sub

    Private Sub DataGridViewInput(ByRef sender As DataGridView, ByVal col As Integer, ByVal row As Integer)
        Dim Section As String
        If col <> 2 Or row < 0 Then
            Exit Sub
        End If
        FormKeyBoard1s.KeyInString(sender, col, row, False)
        Section = sender.Item(0, row).Value.ToString
        WriteProgData(Section, sender.Item(1, row).Value, sender.Item(2, row).Value, CurrentIniFileName)
    End Sub


    Private Sub btnOpenIni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenIni.Click
        If lstINIFile.SelectedItem <> Nothing Then
            IniFileName = ProgramDir + lstINIFile.SelectedItem
            If IO.File.Exists(IniFileName) Then
                Try
                    richIniFile.LoadFile(ProgramDir + lstINIFile.SelectedItem, RichTextBoxStreamType.UnicodePlainText)
                Catch ex As Exception
                    MsgBoxLangErr(ex.Message)
                End Try
            Else
                MsgBoxLangErr("檔案不存在!", "File is not exist!")
            End If
        Else
            MsgBoxLangErr("檔案不存在!", "File is not exist!")
        End If
    End Sub

    Private Sub btnSaveIni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveIni.Click
        If IO.File.Exists(IniFileName) Then
            If MsgBoxLangYesNo("檔案已存在,是否覆寫?", "File existed, Overwrite?") Then
                Try
                    richIniFile.SaveFile(ProgramDir + lstINIFile.SelectedItem, RichTextBoxStreamType.UnicodePlainText)
                Catch ex As Exception
                    MsgBoxLangErr(ex.Message)
                End Try
            Else
                MsgBoxLangErr("檔案未儲存!", "File not saved!")
            End If
        Else
            MsgBoxLangErr("檔案不存在!", "File is not exist!")
        End If
    End Sub

    Private Sub btnNotepadOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotepadOpen.Click
        If lstINIFile.SelectedItem <> Nothing Then
            IniFileName = ProgramDir + lstINIFile.SelectedItem
            If IO.File.Exists(IniFileName) Then
                Shell("Notepad.EXE " + IniFileName, AppWinStyle.NormalFocus)
            Else
                MsgBoxLangErr("檔案不存在!", "File is not exist!")
            End If
        Else
            MsgBoxLangErr("檔案不存在!", "File is not exist!")
        End If
    End Sub

    Private Sub btnReLoadINI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReLoadINI.Click
        If MsgBoxLangYesNo("確定重新載入設定檔?", "Confirm Load INI File?") Then
            ReadIniFile()
            MsgBoxLangOK("建議離開程式再重新載入!", "Recommand Restart Program.")
        End If
    End Sub

    Private Sub btnOSK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOSK.Click
        Shell("OSK.EXE", AppWinStyle.NormalFocus)
    End Sub
End Class

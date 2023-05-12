Imports System.Data
Public Class Control_Datalogview
    Public StopFlag As Boolean
    Private Sub Recode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        Form.CheckForIllegalCrossThreadCalls = False
    End Sub
    ''' <summary>
    ''' 讀Chart 右邊一排 List
    ''' </summary>
    ''' <param name="sfile"></param>
    Public Sub ReadProcessRecord(ByVal sfile As String)
        Dim i, j, k, l As Integer
        Dim filenum As Integer
        Dim sstr As String
        Dim data() As String
        Dim caption() As String
        Dim spacer(1) As Char
        Dim fs1 As System.IO.FileStream
        Dim sw1 As System.IO.StreamReader
        Dim dt As New DataTable("dt")
        If FileIO.FileSystem.FileExists(sfile) = False Then
            MsgBoxLangErr("檔案不存在!!", "File not existed!!")
            Exit Sub
        End If
        fs1 = New System.IO.FileStream(sfile, System.IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.ReadWrite)
        sw1 = New System.IO.StreamReader(fs1, System.Text.Encoding.Unicode)
        RichTextProcessRecord.Clear()
        spacer(0) = vbTab
        spacer(1) = ","
        i = 0
        j = 0
        l = 0
        dt.Clear()
        dgDatalogView.DataSource = dt

        StopFlag = False
        'Application.DoEvents()
        Dim CaptionLine As Integer = 1
        Dim sw As New Stopwatch
        sw.Start()
        Try
            l = 0
            Dim astr, bstr, ccstr, ddstr As String
            astr = "真空"
            bstr = "Vacuum"
            ccstr = "Step"



            For i = 0 To 10
                sstr = sw1.ReadLine
                If InStr(sstr, astr) <= 0 And InStr(sstr, bstr) <= 0 And InStr(sstr, ccstr) <= 0 Then
                    RichTextProcessRecord.Text = RichTextProcessRecord.Text + sstr + vbCrLf
                Else
                    dt.Columns.Add("SN.")
                    caption = sstr.Split(vbTab)
                    For k = 0 To caption.Length - 1
                        dt.Columns.Add(caption(k))
                    Next
                    Exit For
                End If
            Next
            lblStatus.Text = "Reading..."
            'System.Threading.Thread.Sleep(1)
            'Application.DoEvents()

            '

            dgDatalogView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgDatalogView.ColumnHeadersDefaultCellStyle.Font = New Font("ARIAL", 10)
            dgDatalogView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgDatalogView.ColumnHeadersHeight = 26
            dgDatalogView.ColumnHeadersHeightSizeMode = False
            dgDatalogView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader


            dgDatalogView.RowHeadersVisible = False
            dgDatalogView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
            dgDatalogView.RowHeadersWidth = 60
            dgDatalogView.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgDatalogView.DefaultCellStyle.Font = New Font("ARIAL", 10)
            dgDatalogView.RowTemplate.Height = 26
            dgDatalogView.RowTemplate.MinimumHeight = 24
            dgDatalogView.RowTemplate.DefaultCellStyle.Font = New Font("ARIAL", 10)
            dgDatalogView.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


            System.Threading.Thread.Sleep(300)
            'sstr = (dt.Rows.Count + 1).ToString + vbTab + sw1.ReadLine
            'data = sstr.Split(vbTab)
            'If data.Length > dt.Columns.Count Then
            '    For i = 0 To (data.Length - dt.Columns.Count)
            '        dt.Columns.Add("Nodata" + i.ToString)
            '    Next
            'End If
            'dt.Rows.Add(data)
            Do While sw1.EndOfStream = False
                sstr = (dt.Rows.Count + 1).ToString + vbTab + sw1.ReadLine
                data = sstr.Split(vbTab)
                If data.Length > dt.Columns.Count Then
                    Array.Resize(data, dt.Columns.Count)
                End If
                dt.Rows.Add(data)
                'dt.Rows.Add(sw1.ReadLine.Split(vbTab))
                If l > 2000 Then
                    lblStatus.Text = "Data: " + dt.Rows.Count.ToString
                    'Application.DoEvents()
                    l = 0
                Else
                    l += 1
                End If
                If StopFlag Then Exit Do
            Loop
            l = 0
            dgDatalogView.DataSource = dt
            lblStatus.Text = "Data: " + dt.Rows.Count.ToString
            'System.Threading.Thread.Sleep(1)
            'Application.DoEvents()
            sw1.Close()
        Catch ex As Exception
            sw1.Close()
            MsgBoxLangErr(ex.Message)
        End Try
        StopFlag = False
        'sw1.Dispose()
        'fs1.Dispose()
        MsgBoxLangOK(GetLangText("資料讀取完成!", "Data reading ok.") + ((sw.ElapsedMilliseconds / 1000).ToString) + "s")
    End Sub
End Class

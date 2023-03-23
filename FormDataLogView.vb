Imports System.Data
Public Class FormDataLogView
    Inherits System.Windows.Forms.Form


    Friend WithEvents lblProcessFileName As System.Windows.Forms.Label
    Friend WithEvents lblFile03Text As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Control_Datalogview1 As CELLO.Control_Datalogview
    'Curve Records Start

#Region " Windows Form 設計工具產生的程式碼 "

    Public Sub New()
        MyBase.New()

        '此呼叫為 Windows Form 設計工具的必要項。
        InitializeComponent()

        '在 InitializeComponent() 呼叫之後加入所有的初始設定

    End Sub

    'Form 覆寫 Dispose 以清除元件清單。
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '您可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器來修改這些程序。
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDataLogView))
        Me.lblFile03Text = New System.Windows.Forms.Label
        Me.lblProcessFileName = New System.Windows.Forms.Label
        Me.btnExit = New System.Windows.Forms.Button
        Me.Control_Datalogview1 = New CELLO.Control_Datalogview
        Me.SuspendLayout()
        '
        'lblFile03Text
        '
        Me.lblFile03Text.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFile03Text.Location = New System.Drawing.Point(12, 12)
        Me.lblFile03Text.Name = "lblFile03Text"
        Me.lblFile03Text.Size = New System.Drawing.Size(66, 30)
        Me.lblFile03Text.TabIndex = 51
        Me.lblFile03Text.Text = "File:"
        Me.lblFile03Text.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblProcessFileName
        '
        Me.lblProcessFileName.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblProcessFileName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProcessFileName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcessFileName.Location = New System.Drawing.Point(84, 9)
        Me.lblProcessFileName.Name = "lblProcessFileName"
        Me.lblProcessFileName.Size = New System.Drawing.Size(814, 60)
        Me.lblProcessFileName.TabIndex = 49
        Me.lblProcessFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(904, 15)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(105, 54)
        Me.btnExit.TabIndex = 530
        Me.btnExit.Text = "離開"
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Control_Datalogview1
        '
        Me.Control_Datalogview1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Control_Datalogview1.Location = New System.Drawing.Point(1, 80)
        Me.Control_Datalogview1.Name = "Control_Datalogview1"
        Me.Control_Datalogview1.Size = New System.Drawing.Size(1012, 466)
        Me.Control_Datalogview1.TabIndex = 532
        '
        'FormDataLogView
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1014, 568)
        Me.ControlBox = False
        Me.Controls.Add(Me.Control_Datalogview1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblFile03Text)
        Me.Controls.Add(Me.lblProcessFileName)
        Me.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(0, 58)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1024, 600)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1024, 600)
        Me.Name = "FormDataLogView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datalog Viewer"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public StopFlag As Boolean
    Private Sub Recode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        'Form.CheckForIllegalCrossThreadCalls = False
    End Sub

    Public Sub ReadProcessRecord(ByVal sfile As String)
        lblProcessFileName.Text = sfile
        If Me.Visible = False Then
            Me.Show()
            'Me.TopMost = True
        End If
        FormManuals.showflag = True
        Control_Datalogview1.ReadProcessRecord(sfile)
        FormManuals.showflag = False
    End Sub


    'Public Sub ReadProcessRecord(ByVal sfile As String)
    '    Dim i, j, k, l As Integer
    '    Dim filenum As Integer
    '    Dim sstr As String
    '    Dim data() As String
    '    Dim caption() As String
    '    Dim spacer(1) As Char
    '    Dim fs1 As System.IO.FileStream
    '    Dim sw1 As System.IO.StreamReader
    '    Dim dt As New DataTable("dt")
    '    If FileIO.FileSystem.FileExists(sfile) = False Then
    '        MsgBoxLangErr("檔案不存在!!", "File not existed!!")
    '        Exit Sub
    '    End If
    '    fs1 = New System.IO.FileStream(sfile, System.IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read, 100000)
    '    sw1 = New System.IO.StreamReader(fs1, System.Text.Encoding.Unicode)
    '    RichTextProcessRecord.Clear()
    '    spacer(0) = vbTab
    '    spacer(1) = ","
    '    i = 0
    '    j = 0
    '    l = 0

    '    StopFlag = False
    '    Application.DoEvents()
    '    Dim CaptionLine As Integer = 1
    '    Dim sw As New Stopwatch
    '    sw.Start()
    '    Try
    '        l = 0
    '        Dim astr, bstr, ccstr, ddstr As String
    '        astr = "真空"
    '        bstr = "Vacuum"
    '        ccstr = "Step"
    '        For i = 0 To 10
    '            sstr = sw1.ReadLine
    '            If InStr(sstr, astr) <= 0 And InStr(sstr, bstr) <= 0 And InStr(sstr, ccstr) <= 0 Then
    '                RichTextProcessRecord.Text = RichTextProcessRecord.Text + sstr + vbCrLf
    '            Else
    '                dt.Columns.Add("SN.")
    '                caption = sstr.Split(vbTab)
    '                For k = 0 To caption.Length - 1
    '                    dt.Columns.Add(caption(k))
    '                Next
    '                Exit For
    '            End If
    '        Next

    '        dgDatalogView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    '        dgDatalogView.ColumnHeadersDefaultCellStyle.Font = New Font("ARIAL", 10)
    '        dgDatalogView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    '        dgDatalogView.ColumnHeadersHeight = 26
    '        dgDatalogView.ColumnHeadersHeightSizeMode = False
    '        dgDatalogView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader


    '        dgDatalogView.RowHeadersVisible = False
    '        dgDatalogView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
    '        dgDatalogView.RowHeadersWidth = 60
    '        dgDatalogView.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    '        dgDatalogView.DefaultCellStyle.Font = New Font("ARIAL", 10)
    '        dgDatalogView.RowTemplate.Height = 26
    '        dgDatalogView.RowTemplate.MinimumHeight = 24
    '        dgDatalogView.RowTemplate.DefaultCellStyle.Font = New Font("ARIAL", 10)
    '        dgDatalogView.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

    '        sstr = (dt.Rows.Count + 1).ToString + vbTab + sw1.ReadLine
    '        data = sstr.Split(vbTab)
    '        If data.Length > dt.Columns.Count Then
    '            For i = 0 To (data.Length - dt.Columns.Count)
    '                dt.Columns.Add("Nodata" + i.ToString)
    '            Next
    '        End If
    '        dt.Rows.Add(data)
    '        Do While sw1.EndOfStream = False
    '            sstr = (dt.Rows.Count + 1).ToString + vbTab + sw1.ReadLine
    '            data = sstr.Split(vbTab)
    '            dt.Rows.Add(data)
    '            'dt.Rows.Add(sw1.ReadLine.Split(vbTab))
    '            If l > 500 Then
    '                Application.DoEvents()
    '                l = 0
    '            Else
    '                l += 1
    '            End If
    '            If StopFlag Then Exit Do
    '        Loop
    '        l = 0
    '        dgDatalogView.DataSource = dt

    '        sw1.Close()
    '    Catch ex As Exception
    '        sw1.Close()
    '        MsgBoxLangErr(ex.Message)
    '    End Try
    '    StopFlag = False
    '    sw1.Dispose()
    '    fs1.Dispose()
    '    MsgBoxLangOK(GetLangText("資料讀取完成!", "Data reading ok.") + ((sw.ElapsedMilliseconds / 1000).ToString) + "s")
    'End Sub

    'Public Sub ReadProcessRecord(ByVal sfile As String)
    '    Dim i, j, k, l As Integer
    '    Dim filenum As Integer
    '    Dim sstr As String
    '    Dim data() As String
    '    Dim caption() As String
    '    Dim spacer(1) As Char
    '    Dim fs1 As System.IO.FileStream
    '    Dim sw1 As System.IO.StreamReader

    '    Dim dt As New DataTable("dt")
    '    If Me.Visible = False Then
    '        Me.Show()
    '        Me.TopMost = False
    '    End If
    '    'btnExit.Enabled = False
    '    If FileIO.FileSystem.FileExists(sfile) = False Then
    '        MsgBoxLangErr("檔案不存在!!", "File not existed!!")
    '        Exit Sub
    '    End If
    '    lblProcessFileName.Text = sfile
    '    fs1 = New System.IO.FileStream(sfile, System.IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read, 100000)
    '    sw1 = New System.IO.StreamReader(fs1, System.Text.Encoding.Unicode)

    '    'ListView1.Columns(k).AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)

    '    RichTextProcessRecord.Clear()
    '    spacer(0) = vbTab
    '    spacer(1) = ","
    '    'filenum = FreeFile()
    '    i = 0
    '    j = 0
    '    l = 0
    '    'ReadLineData.Clear()
    '    lblStatus.Text = "Reading..."
    '    '        MsgBoxLangOK("資料讀取中!", "Data reading...")

    '    StopFlag = False

    '    Dim CaptionLine As Integer = 1
    '    Dim sw As New Stopwatch
    '    sw.Start()
    '    FormManuals.Enabled = False
    '    Try
    '        l = 0
    '        sstr = sw1.ReadLine
    '        RichTextProcessRecord.Text = RichTextProcessRecord.Text + sstr + vbCrLf
    '        sstr = sw1.ReadLine
    '        caption = sstr.Split(vbTab)
    '        For k = 0 To caption.Length - 1
    '            dt.Columns.Add(caption(k))
    '        Next
    '        dgDatalogView.ColumnHeadersDefaultCellStyle.Font = New Font("ARIAL", 10)
    '        dgDatalogView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    '        dgDatalogView.ColumnHeadersHeight = 26
    '        dgDatalogView.ColumnHeadersHeightSizeMode = False
    '        dgDatalogView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader


    '        dgDatalogView.RowHeadersVisible = False
    '        dgDatalogView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
    '        dgDatalogView.RowHeadersWidth = 12
    '        dgDatalogView.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    '        dgDatalogView.DefaultCellStyle.Font = New Font("ARIAL", 10)
    '        dgDatalogView.RowTemplate.Height = 26
    '        dgDatalogView.RowTemplate.MinimumHeight = 24
    '        dgDatalogView.RowTemplate.DefaultCellStyle.Font = New Font("ARIAL", 10)
    '        dgDatalogView.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter



    '        Do While sw1.EndOfStream = False
    '            'sstr = sw1.ReadLine
    '            'data = sstr.Split(vbTab)
    '            'dt.Rows.Add(data)
    '            dt.Rows.Add(sw1.ReadLine.Split(vbTab))
    '            If l > 2000 Then
    '                lblStatus.Text = "Data: " + dt.Rows.Count.ToString
    '                Application.DoEvents()
    '                l = 0
    '            Else
    '                l += 1
    '            End If
    '            If StopFlag Then Exit Do
    '        Loop
    '        l = 0
    '        FormManuals.Enabled = True
    '        dgDatalogView.DataSource = dt

    '        sw1.Close()
    '    Catch ex As Exception
    '        sw1.Close()
    '        MsgBoxLangErr(ex.Message)
    '    End Try
    '    StopFlag = False
    '    sw1.Dispose()
    '    fs1.Dispose()
    '    If Me.Visible = False Then
    '        Me.Show()
    '        Me.TopMost = True
    '    End If
    '    lblStatus.Text = "Data: " + dt.Rows.Count.ToString + ": " + (sw.ElapsedMilliseconds / 1000).ToString
    '    MsgBoxLangOK(GetLangText("資料讀取完成!", "Data reading ok.") + ((sw.ElapsedMilliseconds / 1000).ToString) + "s")
    'End Sub





    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        FormManuals.showflag = False
        Me.Hide()
    End Sub
End Class


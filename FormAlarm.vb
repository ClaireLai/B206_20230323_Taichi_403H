Public Class FormAlarm
    Inherits System.Windows.Forms.Form


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
    Friend WithEvents btnBzReset As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents colNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents colDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents colTime As System.Windows.Forms.ColumnHeader
    Friend WithEvents colAlarm As System.Windows.Forms.ColumnHeader
    Friend WithEvents colUser As System.Windows.Forms.ColumnHeader
    Friend WithEvents colCode As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnRealTime As System.Windows.Forms.Button
    Friend WithEvents btnHistory As System.Windows.Forms.Button
    Friend WithEvents txtAlarmList As System.Windows.Forms.TextBox
    Friend WithEvents pnlAlarmTitle As System.Windows.Forms.Panel
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents lblAlarmContectText As System.Windows.Forms.Label
    Friend WithEvents lblDateText As System.Windows.Forms.Label
    Friend WithEvents lblTimeText As System.Windows.Forms.Label
    Friend WithEvents picCelloTitleEng As System.Windows.Forms.PictureBox
    Friend WithEvents picCelloTitle As System.Windows.Forms.PictureBox
    Friend WithEvents picCelloLogo As System.Windows.Forms.PictureBox
    Friend WithEvents btnAlarmReset As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.btnBzReset = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnAlarmReset = New System.Windows.Forms.Button
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.colNo = New System.Windows.Forms.ColumnHeader
        Me.colUser = New System.Windows.Forms.ColumnHeader
        Me.colDate = New System.Windows.Forms.ColumnHeader
        Me.colTime = New System.Windows.Forms.ColumnHeader
        Me.colCode = New System.Windows.Forms.ColumnHeader
        Me.colAlarm = New System.Windows.Forms.ColumnHeader
        Me.btnRealTime = New System.Windows.Forms.Button
        Me.btnHistory = New System.Windows.Forms.Button
        Me.txtAlarmList = New System.Windows.Forms.TextBox
        Me.pnlAlarmTitle = New System.Windows.Forms.Panel
        Me.lblCode = New System.Windows.Forms.Label
        Me.lblUser = New System.Windows.Forms.Label
        Me.lblAlarmContectText = New System.Windows.Forms.Label
        Me.lblDateText = New System.Windows.Forms.Label
        Me.lblTimeText = New System.Windows.Forms.Label
        Me.picCelloTitleEng = New System.Windows.Forms.PictureBox
        Me.picCelloTitle = New System.Windows.Forms.PictureBox
        Me.picCelloLogo = New System.Windows.Forms.PictureBox
        Me.pnlAlarmTitle.SuspendLayout()
        CType(Me.picCelloTitleEng, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCelloTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCelloLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBzReset
        '
        Me.btnBzReset.BackColor = System.Drawing.SystemColors.Control
        Me.btnBzReset.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBzReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBzReset.Location = New System.Drawing.Point(356, 650)
        Me.btnBzReset.Name = "btnBzReset"
        Me.btnBzReset.Size = New System.Drawing.Size(173, 53)
        Me.btnBzReset.TabIndex = 46
        Me.btnBzReset.Text = "停止警報"
        Me.btnBzReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBzReset.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'btnAlarmReset
        '
        Me.btnAlarmReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAlarmReset.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlarmReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAlarmReset.Location = New System.Drawing.Point(584, 650)
        Me.btnAlarmReset.Name = "btnAlarmReset"
        Me.btnAlarmReset.Size = New System.Drawing.Size(169, 53)
        Me.btnAlarmReset.TabIndex = 51
        Me.btnAlarmReset.Text = "清除異常訊息"
        Me.btnAlarmReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAlarmReset.UseVisualStyleBackColor = False
        '
        'ListView1
        '
        Me.ListView1.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.ListView1.Alignment = System.Windows.Forms.ListViewAlignment.[Default]
        Me.ListView1.AllowColumnReorder = True
        Me.ListView1.AutoArrange = False
        Me.ListView1.BackColor = System.Drawing.Color.LavenderBlush
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNo, Me.colUser, Me.colDate, Me.colTime, Me.colCode, Me.colAlarm})
        Me.ListView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListView1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.HotTracking = True
        Me.ListView1.HoverSelection = True
        Me.ListView1.LabelWrap = False
        Me.ListView1.Location = New System.Drawing.Point(0, 120)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.ShowGroups = False
        Me.ListView1.ShowItemToolTips = True
        Me.ListView1.Size = New System.Drawing.Size(1020, 522)
        Me.ListView1.TabIndex = 528
        Me.ListView1.TileSize = New System.Drawing.Size(6, 6)
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        Me.ListView1.VirtualListSize = 100
        Me.ListView1.Visible = False
        '
        'colNo
        '
        Me.colNo.Text = "序號"
        Me.colNo.Width = 62
        '
        'colUser
        '
        Me.colUser.Text = "使用者"
        Me.colUser.Width = 112
        '
        'colDate
        '
        Me.colDate.Text = "日期"
        Me.colDate.Width = 100
        '
        'colTime
        '
        Me.colTime.Text = "時間"
        Me.colTime.Width = 101
        '
        'colCode
        '
        Me.colCode.Text = "異常號"
        Me.colCode.Width = 69
        '
        'colAlarm
        '
        Me.colAlarm.Text = "警報訊息"
        Me.colAlarm.Width = 378
        '
        'btnRealTime
        '
        Me.btnRealTime.BackColor = System.Drawing.SystemColors.Control
        Me.btnRealTime.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRealTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRealTime.Location = New System.Drawing.Point(12, 650)
        Me.btnRealTime.Name = "btnRealTime"
        Me.btnRealTime.Size = New System.Drawing.Size(115, 53)
        Me.btnRealTime.TabIndex = 529
        Me.btnRealTime.Text = "即時異常"
        Me.btnRealTime.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRealTime.UseVisualStyleBackColor = False
        '
        'btnHistory
        '
        Me.btnHistory.BackColor = System.Drawing.SystemColors.Control
        Me.btnHistory.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHistory.Location = New System.Drawing.Point(168, 650)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(115, 53)
        Me.btnHistory.TabIndex = 530
        Me.btnHistory.Text = "異常履歷"
        Me.btnHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHistory.UseVisualStyleBackColor = False
        '
        'txtAlarmList
        '
        Me.txtAlarmList.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAlarmList.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtAlarmList.ForeColor = System.Drawing.Color.Red
        Me.txtAlarmList.Location = New System.Drawing.Point(0, 160)
        Me.txtAlarmList.Margin = New System.Windows.Forms.Padding(0)
        Me.txtAlarmList.Multiline = True
        Me.txtAlarmList.Name = "txtAlarmList"
        Me.txtAlarmList.Size = New System.Drawing.Size(1020, 482)
        Me.txtAlarmList.TabIndex = 531
        '
        'pnlAlarmTitle
        '
        Me.pnlAlarmTitle.BackColor = System.Drawing.Color.Silver
        Me.pnlAlarmTitle.Controls.Add(Me.lblCode)
        Me.pnlAlarmTitle.Controls.Add(Me.lblUser)
        Me.pnlAlarmTitle.Controls.Add(Me.lblAlarmContectText)
        Me.pnlAlarmTitle.Controls.Add(Me.lblDateText)
        Me.pnlAlarmTitle.Controls.Add(Me.lblTimeText)
        Me.pnlAlarmTitle.Location = New System.Drawing.Point(0, 116)
        Me.pnlAlarmTitle.Name = "pnlAlarmTitle"
        Me.pnlAlarmTitle.Size = New System.Drawing.Size(1020, 38)
        Me.pnlAlarmTitle.TabIndex = 532
        '
        'lblCode
        '
        Me.lblCode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.Location = New System.Drawing.Point(321, 9)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(72, 22)
        Me.lblCode.TabIndex = 46
        Me.lblCode.Text = "異常碼"
        '
        'lblUser
        '
        Me.lblUser.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(3, 9)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(65, 22)
        Me.lblUser.TabIndex = 45
        Me.lblUser.Text = "使用者"
        '
        'lblAlarmContectText
        '
        Me.lblAlarmContectText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlarmContectText.Location = New System.Drawing.Point(418, 9)
        Me.lblAlarmContectText.Name = "lblAlarmContectText"
        Me.lblAlarmContectText.Size = New System.Drawing.Size(344, 22)
        Me.lblAlarmContectText.TabIndex = 43
        Me.lblAlarmContectText.Text = "警報訊息"
        '
        'lblDateText
        '
        Me.lblDateText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateText.Location = New System.Drawing.Point(107, 9)
        Me.lblDateText.Name = "lblDateText"
        Me.lblDateText.Size = New System.Drawing.Size(96, 22)
        Me.lblDateText.TabIndex = 44
        Me.lblDateText.Text = "日期"
        '
        'lblTimeText
        '
        Me.lblTimeText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeText.Location = New System.Drawing.Point(219, 9)
        Me.lblTimeText.Name = "lblTimeText"
        Me.lblTimeText.Size = New System.Drawing.Size(96, 22)
        Me.lblTimeText.TabIndex = 44
        Me.lblTimeText.Text = "時間"
        '
        'picCelloTitleEng
        '
        Me.picCelloTitleEng.Image = Global.CELLO.My.Resources.Resources.CELLO_CO_ENG
        Me.picCelloTitleEng.Location = New System.Drawing.Point(590, 64)
        Me.picCelloTitleEng.Name = "picCelloTitleEng"
        Me.picCelloTitleEng.Size = New System.Drawing.Size(430, 50)
        Me.picCelloTitleEng.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCelloTitleEng.TabIndex = 535
        Me.picCelloTitleEng.TabStop = False
        '
        'picCelloTitle
        '
        Me.picCelloTitle.Image = Global.CELLO.My.Resources.Resources.Cello_Co
        Me.picCelloTitle.Location = New System.Drawing.Point(375, 0)
        Me.picCelloTitle.Name = "picCelloTitle"
        Me.picCelloTitle.Size = New System.Drawing.Size(645, 65)
        Me.picCelloTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCelloTitle.TabIndex = 534
        Me.picCelloTitle.TabStop = False
        '
        'picCelloLogo
        '
        Me.picCelloLogo.Image = Global.CELLO.My.Resources.Resources.CELLOLOGO02
        Me.picCelloLogo.Location = New System.Drawing.Point(0, 0)
        Me.picCelloLogo.Name = "picCelloLogo"
        Me.picCelloLogo.Size = New System.Drawing.Size(138, 110)
        Me.picCelloLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCelloLogo.TabIndex = 533
        Me.picCelloLogo.TabStop = False
        '
        'FormAlarm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1024, 710)
        Me.ControlBox = False
        Me.Controls.Add(Me.picCelloTitleEng)
        Me.Controls.Add(Me.picCelloTitle)
        Me.Controls.Add(Me.picCelloLogo)
        Me.Controls.Add(Me.pnlAlarmTitle)
        Me.Controls.Add(Me.txtAlarmList)
        Me.Controls.Add(Me.btnHistory)
        Me.Controls.Add(Me.btnRealTime)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btnAlarmReset)
        Me.Controls.Add(Me.btnBzReset)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(0, 50)
        Me.Name = "FormAlarm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Alarm"
        Me.pnlAlarmTitle.ResumeLayout(False)
        CType(Me.picCelloTitleEng, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCelloTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCelloLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    'Private Sub AlarmForm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
    '    SetAlarmRights(Me, LoginSet_Auto, LoginSet_Manual, LoginSet_Administrator)

    'End Sub
    Private Sub Alarm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = FromStartUpTopPosition
        Me.Left = 0
        Timer1.Interval = 1000
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBzReset.Click
        Set_MBit(DoBZIndex, DEVICE_OFF)
        Set_MBit(DoPressEndAlarmIndex, DEVICE_OFF)
        BZReset_Status = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Top = FromStartUpTopPosition
        Me.Left = 0
        'AlarmRecord_Task_ListView(ListView1)
    End Sub

    Public Sub ShowInit()
        Me.Show()
        Timer1.Enabled = True
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        Timer1.Enabled = False
        FormProcesss.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlarmReset.Click
        'Set_MBit(DoBZIndex, DEVICE_OFF)
        ClearAlarm()
    End Sub

    Public Class clsListviewSorter
        Implements System.Collections.IComparer
        Public m_ColumnNumber As Integer
        Public m_SortOrder As SortOrder
        Public Sub New(ByVal column_number As Integer, ByVal sort_order As SortOrder)
            m_ColumnNumber = column_number
            m_SortOrder = sort_order
        End Sub
        ' Compare the items in the appropriate column  
        Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.IComparer.Compare
            Dim item_x As ListViewItem = DirectCast(x, ListViewItem)
            Dim item_y As ListViewItem = DirectCast(y, ListViewItem)
            ' Get the sub-item values.  
            Dim string_x As String
            If StopSort Then Exit Function

            If item_x.SubItems.Count <= m_ColumnNumber Then
                string_x = ""
            Else
                string_x = item_x.SubItems(m_ColumnNumber).Text
            End If
            Dim string_y As String
            If item_y.SubItems.Count <= m_ColumnNumber Then
                string_y = ""
            Else
                string_y = item_y.SubItems(m_ColumnNumber).Text
            End If
            ' Compare them.  
            If m_SortOrder = SortOrder.Ascending Then
                If IsNumeric(string_x) And IsNumeric(string_y) Then
                    Return Val(string_x).CompareTo(Val(string_y))
                ElseIf IsDate(string_x) And IsDate(string_y) Then
                    Return DateTime.Parse(string_x).CompareTo(DateTime.Parse(string_y))
                Else
                    Return String.Compare(string_x, string_y)
                End If
            Else
                If IsNumeric(string_x) And IsNumeric(string_y) Then
                    Return Val(string_y).CompareTo(Val(string_x))
                ElseIf IsDate(string_x) And IsDate(string_y) Then
                    Return DateTime.Parse(string_y).CompareTo(DateTime.Parse(string_x))
                Else
                    Return String.Compare(string_y, string_x)
                End If
            End If
        End Function
    End Class

    Private m_SortingColumn As ColumnHeader
    Private Sub ListView1_ColumnClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles ListView1.ColumnClick
        ' Get the new sorting column.  
        Dim new_sorting_column As ColumnHeader = ListView1.Columns(e.Column)
        ' Figure out the new sorting order.  
        Dim sort_order As System.Windows.Forms.SortOrder
        If m_SortingColumn Is Nothing Then
            ' New column. Sort ascending.  
            sort_order = SortOrder.Ascending
        Else ' See if this is the same column.  
            If new_sorting_column.Equals(m_SortingColumn) Then
                ' Same column. Switch the sort order.  
                If m_SortingColumn.Text.StartsWith("> ") Then
                    sort_order = SortOrder.Descending
                Else
                    sort_order = SortOrder.Ascending
                End If
            Else
                ' New column. Sort ascending.  
                sort_order = SortOrder.Ascending
            End If
            ' Remove the old sort indicator.  
            m_SortingColumn.Text = m_SortingColumn.Text.Substring(2)
        End If
        ' Display the new sort order.  
        m_SortingColumn = new_sorting_column
        If sort_order = SortOrder.Ascending Then
            m_SortingColumn.Text = "> " & m_SortingColumn.Text
            'm_SortingColumn.Text = "> " & m_SortingColumn.Text
        Else
            m_SortingColumn.Text = "< " & m_SortingColumn.Text
            'm_SortingColumn.Text = "< " & m_SortingColumn.Text
        End If
        ' Create a comparer.  
        ListView1.ListViewItemSorter = New clsListviewSorter(e.Column, sort_order)
        ' Sort.  
        ListView1.Sort()
    End Sub

    Private Sub btnHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHistory.Click
        ListView1.Visible = True
        pnlAlarmTitle.Visible = False
        txtAlarmList.Visible = False

    End Sub

    Private Sub btnRealTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRealTime.Click
        ListView1.Visible = False
        pnlAlarmTitle.Visible = True
        txtAlarmList.Visible = True
    End Sub
End Class

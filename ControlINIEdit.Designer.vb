<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlINIEdit
    Inherits System.Windows.Forms.UserControl

    'UserControl 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlINIEdit))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.btnOSK = New System.Windows.Forms.Button
        Me.btnReLoadINI = New System.Windows.Forms.Button
        Me.btnNotepadOpen = New System.Windows.Forms.Button
        Me.btnOpenIni = New System.Windows.Forms.Button
        Me.btnSaveIni = New System.Windows.Forms.Button
        Me.richIniFile = New System.Windows.Forms.RichTextBox
        Me.lstINIFile = New System.Windows.Forms.ListBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.btnSaveDataGrid = New System.Windows.Forms.Button
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOSK
        '
        Me.btnOSK.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOSK.ForeColor = System.Drawing.Color.Black
        Me.btnOSK.Location = New System.Drawing.Point(866, 206)
        Me.btnOSK.Name = "btnOSK"
        Me.btnOSK.Size = New System.Drawing.Size(113, 40)
        Me.btnOSK.TabIndex = 148
        Me.btnOSK.Text = "螢幕小鍵盤"
        '
        'btnReLoadINI
        '
        Me.btnReLoadINI.BackgroundImage = CType(resources.GetObject("btnReLoadINI.BackgroundImage"), System.Drawing.Image)
        Me.btnReLoadINI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReLoadINI.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReLoadINI.ForeColor = System.Drawing.Color.Black
        Me.btnReLoadINI.Location = New System.Drawing.Point(554, 206)
        Me.btnReLoadINI.Name = "btnReLoadINI"
        Me.btnReLoadINI.Size = New System.Drawing.Size(113, 40)
        Me.btnReLoadINI.TabIndex = 147
        Me.btnReLoadINI.Text = "重新載入"
        '
        'btnNotepadOpen
        '
        Me.btnNotepadOpen.BackgroundImage = CType(resources.GetObject("btnNotepadOpen.BackgroundImage"), System.Drawing.Image)
        Me.btnNotepadOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNotepadOpen.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotepadOpen.ForeColor = System.Drawing.Color.Black
        Me.btnNotepadOpen.Location = New System.Drawing.Point(866, 118)
        Me.btnNotepadOpen.Name = "btnNotepadOpen"
        Me.btnNotepadOpen.Size = New System.Drawing.Size(113, 40)
        Me.btnNotepadOpen.TabIndex = 146
        Me.btnNotepadOpen.Text = "記事本開啟"
        '
        'btnOpenIni
        '
        Me.btnOpenIni.BackgroundImage = CType(resources.GetObject("btnOpenIni.BackgroundImage"), System.Drawing.Image)
        Me.btnOpenIni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOpenIni.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenIni.ForeColor = System.Drawing.Color.Black
        Me.btnOpenIni.Location = New System.Drawing.Point(866, 5)
        Me.btnOpenIni.Name = "btnOpenIni"
        Me.btnOpenIni.Size = New System.Drawing.Size(113, 40)
        Me.btnOpenIni.TabIndex = 145
        Me.btnOpenIni.Text = "開啟檔案"
        '
        'btnSaveIni
        '
        Me.btnSaveIni.BackgroundImage = CType(resources.GetObject("btnSaveIni.BackgroundImage"), System.Drawing.Image)
        Me.btnSaveIni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSaveIni.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveIni.ForeColor = System.Drawing.Color.Black
        Me.btnSaveIni.Location = New System.Drawing.Point(866, 63)
        Me.btnSaveIni.Name = "btnSaveIni"
        Me.btnSaveIni.Size = New System.Drawing.Size(113, 40)
        Me.btnSaveIni.TabIndex = 144
        Me.btnSaveIni.Text = "存檔"
        '
        'richIniFile
        '
        Me.richIniFile.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.richIniFile.DetectUrls = False
        Me.richIniFile.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.richIniFile.Location = New System.Drawing.Point(295, 5)
        Me.richIniFile.Name = "richIniFile"
        Me.richIniFile.ReadOnly = True
        Me.richIniFile.Size = New System.Drawing.Size(565, 196)
        Me.richIniFile.TabIndex = 143
        Me.richIniFile.Text = ""
        '
        'lstINIFile
        '
        Me.lstINIFile.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstINIFile.FormattingEnabled = True
        Me.lstINIFile.ItemHeight = 24
        Me.lstINIFile.Location = New System.Drawing.Point(3, 5)
        Me.lstINIFile.Name = "lstINIFile"
        Me.lstINIFile.ScrollAlwaysVisible = True
        Me.lstINIFile.Size = New System.Drawing.Size(286, 196)
        Me.lstINIFile.TabIndex = 142
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeight = 36
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column5, Me.Column2, Me.Column3})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(0, 252)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 120
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.RowTemplate.Height = 32
        Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.Size = New System.Drawing.Size(979, 220)
        Me.DataGridView1.TabIndex = 149
        '
        'btnSaveDataGrid
        '
        Me.btnSaveDataGrid.BackgroundImage = CType(resources.GetObject("btnSaveDataGrid.BackgroundImage"), System.Drawing.Image)
        Me.btnSaveDataGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSaveDataGrid.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveDataGrid.ForeColor = System.Drawing.Color.Black
        Me.btnSaveDataGrid.Location = New System.Drawing.Point(295, 208)
        Me.btnSaveDataGrid.Name = "btnSaveDataGrid"
        Me.btnSaveDataGrid.Size = New System.Drawing.Size(127, 40)
        Me.btnSaveDataGrid.TabIndex = 150
        Me.btnSaveDataGrid.Text = "表格資料存入"
        '
        'Column1
        '
        Me.Column1.FillWeight = 20.0!
        Me.Column1.HeaderText = "參數區段名"
        Me.Column1.MinimumWidth = 20
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.FillWeight = 25.0!
        Me.Column5.HeaderText = "參數名稱"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.FillWeight = 35.0!
        Me.Column2.HeaderText = "參數資料(數值)"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.FillWeight = 15.0!
        Me.Column3.HeaderText = "備註"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'ControlINIEdit
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.btnSaveDataGrid)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnOSK)
        Me.Controls.Add(Me.btnReLoadINI)
        Me.Controls.Add(Me.btnNotepadOpen)
        Me.Controls.Add(Me.btnOpenIni)
        Me.Controls.Add(Me.btnSaveIni)
        Me.Controls.Add(Me.richIniFile)
        Me.Controls.Add(Me.lstINIFile)
        Me.Name = "ControlINIEdit"
        Me.Size = New System.Drawing.Size(982, 475)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnOSK As System.Windows.Forms.Button
    Friend WithEvents btnReLoadINI As System.Windows.Forms.Button
    Friend WithEvents btnNotepadOpen As System.Windows.Forms.Button
    Friend WithEvents btnOpenIni As System.Windows.Forms.Button
    Friend WithEvents btnSaveIni As System.Windows.Forms.Button
    Friend WithEvents richIniFile As System.Windows.Forms.RichTextBox
    Friend WithEvents lstINIFile As System.Windows.Forms.ListBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnSaveDataGrid As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class

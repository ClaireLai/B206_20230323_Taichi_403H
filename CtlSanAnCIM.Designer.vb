<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlSanAnCIM
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnRunProcess = New System.Windows.Forms.Button()
        Me.btnClearAll = New System.Windows.Forms.Button()
        Me.lblLotIDText = New System.Windows.Forms.Label()
        Me.txtLotA = New System.Windows.Forms.TextBox()
        Me.btnEndProductInput = New System.Windows.Forms.Button()
        Me.btnKeyIn = New System.Windows.Forms.Button()
        Me.btnBarcodeReader = New System.Windows.Forms.Button()
        Me.btnOffLine = New System.Windows.Forms.Button()
        Me.btnInLine = New System.Windows.Forms.Button()
        Me.lblLoginStatus = New System.Windows.Forms.Label()
        Me.lblEQID = New System.Windows.Forms.Label()
        Me.lblEQIDText = New System.Windows.Forms.Label()
        Me.lblOPIDtext = New System.Windows.Forms.Label()
        Me.txtOpID = New System.Windows.Forms.TextBox()
        Me.lblLotInfoList = New System.Windows.Forms.Label()
        Me.lblAlive = New System.Windows.Forms.Label()
        Me.lblTimeOut = New System.Windows.Forms.Label()
        Me.lblRunID = New System.Windows.Forms.Label()
        Me.txtRunID1 = New System.Windows.Forms.TextBox()
        Me.WaferID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgLotInfo = New System.Windows.Forms.DataGridView()
        Me.lblRecipeName = New System.Windows.Forms.Label()
        Me.lblRecipeNameText = New System.Windows.Forms.Label()
        Me.lblTotalWaferCount = New System.Windows.Forms.Label()
        Me.lblTotalWafer = New System.Windows.Forms.Label()
        Me.lstWaferID = New System.Windows.Forms.ListBox()
        Me.txtRunID2 = New System.Windows.Forms.TextBox()
        Me.txtRunID3 = New System.Windows.Forms.TextBox()
        Me.txtRunID4 = New System.Windows.Forms.TextBox()
        Me.txtRunID8 = New System.Windows.Forms.TextBox()
        Me.txtRunID7 = New System.Windows.Forms.TextBox()
        Me.txtRunID6 = New System.Windows.Forms.TextBox()
        Me.txtRunID5 = New System.Windows.Forms.TextBox()
        CType(Me.dgLotInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'btnRunProcess
        '
        Me.btnRunProcess.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRunProcess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRunProcess.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btnRunProcess.Location = New System.Drawing.Point(996, 209)
        Me.btnRunProcess.Name = "btnRunProcess"
        Me.btnRunProcess.Size = New System.Drawing.Size(110, 60)
        Me.btnRunProcess.TabIndex = 693
        Me.btnRunProcess.Text = "執行製程"
        Me.btnRunProcess.UseVisualStyleBackColor = False
        Me.btnRunProcess.Visible = False
        '
        'btnClearAll
        '
        Me.btnClearAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnClearAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClearAll.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btnClearAll.ForeColor = System.Drawing.Color.Black
        Me.btnClearAll.Location = New System.Drawing.Point(903, 275)
        Me.btnClearAll.Name = "btnClearAll"
        Me.btnClearAll.Size = New System.Drawing.Size(110, 60)
        Me.btnClearAll.TabIndex = 692
        Me.btnClearAll.Text = "清除資料"
        Me.btnClearAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClearAll.UseVisualStyleBackColor = False
        '
        'lblLotIDText
        '
        Me.lblLotIDText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLotIDText.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblLotIDText.Location = New System.Drawing.Point(485, 450)
        Me.lblLotIDText.Name = "lblLotIDText"
        Me.lblLotIDText.Size = New System.Drawing.Size(132, 26)
        Me.lblLotIDText.TabIndex = 697
        Me.lblLotIDText.Text = "批號:"
        Me.lblLotIDText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblLotIDText.Visible = False
        '
        'txtLotA
        '
        Me.txtLotA.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtLotA.Location = New System.Drawing.Point(621, 450)
        Me.txtLotA.Name = "txtLotA"
        Me.txtLotA.Size = New System.Drawing.Size(253, 26)
        Me.txtLotA.TabIndex = 690
        Me.txtLotA.Visible = False
        '
        'btnEndProductInput
        '
        Me.btnEndProductInput.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEndProductInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEndProductInput.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btnEndProductInput.Location = New System.Drawing.Point(903, 160)
        Me.btnEndProductInput.Name = "btnEndProductInput"
        Me.btnEndProductInput.Size = New System.Drawing.Size(110, 64)
        Me.btnEndProductInput.TabIndex = 691
        Me.btnEndProductInput.Text = "確認"
        Me.btnEndProductInput.UseVisualStyleBackColor = False
        '
        'btnKeyIn
        '
        Me.btnKeyIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnKeyIn.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.btnKeyIn.ForeColor = System.Drawing.Color.Black
        Me.btnKeyIn.Location = New System.Drawing.Point(903, 56)
        Me.btnKeyIn.Name = "btnKeyIn"
        Me.btnKeyIn.Size = New System.Drawing.Size(110, 37)
        Me.btnKeyIn.TabIndex = 695
        Me.btnKeyIn.Text = "手動輸入"
        Me.btnKeyIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnKeyIn.UseVisualStyleBackColor = True
        '
        'btnBarcodeReader
        '
        Me.btnBarcodeReader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBarcodeReader.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.btnBarcodeReader.ForeColor = System.Drawing.Color.Black
        Me.btnBarcodeReader.Location = New System.Drawing.Point(903, 8)
        Me.btnBarcodeReader.Name = "btnBarcodeReader"
        Me.btnBarcodeReader.Size = New System.Drawing.Size(110, 37)
        Me.btnBarcodeReader.TabIndex = 694
        Me.btnBarcodeReader.Text = "刷入條碼"
        Me.btnBarcodeReader.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBarcodeReader.UseVisualStyleBackColor = True
        '
        'btnOffLine
        '
        Me.btnOffLine.BackColor = System.Drawing.Color.Red
        Me.btnOffLine.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOffLine.ForeColor = System.Drawing.Color.Black
        Me.btnOffLine.Location = New System.Drawing.Point(903, 426)
        Me.btnOffLine.Name = "btnOffLine"
        Me.btnOffLine.Size = New System.Drawing.Size(110, 50)
        Me.btnOffLine.TabIndex = 702
        Me.btnOffLine.Text = "Off-Line"
        Me.btnOffLine.UseVisualStyleBackColor = False
        '
        'btnInLine
        '
        Me.btnInLine.BackColor = System.Drawing.Color.Red
        Me.btnInLine.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInLine.ForeColor = System.Drawing.Color.Black
        Me.btnInLine.Location = New System.Drawing.Point(903, 366)
        Me.btnInLine.Name = "btnInLine"
        Me.btnInLine.Size = New System.Drawing.Size(110, 50)
        Me.btnInLine.TabIndex = 701
        Me.btnInLine.Text = "In-Line"
        Me.btnInLine.UseVisualStyleBackColor = False
        '
        'lblLoginStatus
        '
        Me.lblLoginStatus.BackColor = System.Drawing.Color.White
        Me.lblLoginStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLoginStatus.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lblLoginStatus.ForeColor = System.Drawing.Color.Blue
        Me.lblLoginStatus.Location = New System.Drawing.Point(1000, 136)
        Me.lblLoginStatus.Name = "lblLoginStatus"
        Me.lblLoginStatus.Size = New System.Drawing.Size(106, 26)
        Me.lblLoginStatus.TabIndex = 703
        Me.lblLoginStatus.Text = "IDLE"
        Me.lblLoginStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblLoginStatus.Visible = False
        '
        'lblEQID
        '
        Me.lblEQID.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblEQID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEQID.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lblEQID.ForeColor = System.Drawing.Color.Black
        Me.lblEQID.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblEQID.Location = New System.Drawing.Point(138, 8)
        Me.lblEQID.Name = "lblEQID"
        Me.lblEQID.Size = New System.Drawing.Size(253, 26)
        Me.lblEQID.TabIndex = 708
        Me.lblEQID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEQIDText
        '
        Me.lblEQIDText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEQIDText.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lblEQIDText.Location = New System.Drawing.Point(2, 8)
        Me.lblEQIDText.Name = "lblEQIDText"
        Me.lblEQIDText.Size = New System.Drawing.Size(132, 26)
        Me.lblEQIDText.TabIndex = 707
        Me.lblEQIDText.Text = "機台編號::"
        Me.lblEQIDText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblOPIDtext
        '
        Me.lblOPIDtext.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOPIDtext.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblOPIDtext.Location = New System.Drawing.Point(2, 37)
        Me.lblOPIDtext.Name = "lblOPIDtext"
        Me.lblOPIDtext.Size = New System.Drawing.Size(132, 26)
        Me.lblOPIDtext.TabIndex = 710
        Me.lblOPIDtext.Text = "工號:"
        Me.lblOPIDtext.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOpID
        '
        Me.txtOpID.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtOpID.Location = New System.Drawing.Point(138, 37)
        Me.txtOpID.Name = "txtOpID"
        Me.txtOpID.Size = New System.Drawing.Size(253, 26)
        Me.txtOpID.TabIndex = 709
        '
        'lblLotInfoList
        '
        Me.lblLotInfoList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLotInfoList.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblLotInfoList.Location = New System.Drawing.Point(3, 133)
        Me.lblLotInfoList.Name = "lblLotInfoList"
        Me.lblLotInfoList.Size = New System.Drawing.Size(132, 26)
        Me.lblLotInfoList.TabIndex = 722
        Me.lblLotInfoList.Text = "批片號清單:"
        Me.lblLotInfoList.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAlive
        '
        Me.lblAlive.BackColor = System.Drawing.Color.Pink
        Me.lblAlive.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAlive.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblAlive.Location = New System.Drawing.Point(903, 112)
        Me.lblAlive.Name = "lblAlive"
        Me.lblAlive.Size = New System.Drawing.Size(113, 26)
        Me.lblAlive.TabIndex = 767
        Me.lblAlive.Text = "Connected"
        Me.lblAlive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblAlive.Visible = False
        '
        'lblTimeOut
        '
        Me.lblTimeOut.BackColor = System.Drawing.Color.Pink
        Me.lblTimeOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTimeOut.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblTimeOut.Location = New System.Drawing.Point(1000, 171)
        Me.lblTimeOut.Name = "lblTimeOut"
        Me.lblTimeOut.Size = New System.Drawing.Size(106, 26)
        Me.lblTimeOut.TabIndex = 768
        Me.lblTimeOut.Text = "TimeOut"
        Me.lblTimeOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblTimeOut.Visible = False
        '
        'lblRunID
        '
        Me.lblRunID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRunID.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblRunID.Location = New System.Drawing.Point(2, 69)
        Me.lblRunID.Name = "lblRunID"
        Me.lblRunID.Size = New System.Drawing.Size(132, 26)
        Me.lblRunID.TabIndex = 769
        Me.lblRunID.Text = "Run ID:"
        Me.lblRunID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRunID1
        '
        Me.txtRunID1.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtRunID1.Location = New System.Drawing.Point(138, 69)
        Me.txtRunID1.Name = "txtRunID1"
        Me.txtRunID1.Size = New System.Drawing.Size(182, 26)
        Me.txtRunID1.TabIndex = 770
        '
        'WaferID
        '
        Me.WaferID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 10.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.WaferID.DefaultCellStyle = DataGridViewCellStyle3
        Me.WaferID.HeaderText = "WaferID"
        Me.WaferID.Name = "WaferID"
        Me.WaferID.ReadOnly = True
        Me.WaferID.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.WaferID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.WaferID.Width = 200
        '
        'dgLotInfo
        '
        Me.dgLotInfo.AllowUserToAddRows = False
        Me.dgLotInfo.AllowUserToDeleteRows = False
        Me.dgLotInfo.AllowUserToResizeColumns = False
        Me.dgLotInfo.AllowUserToResizeRows = False
        Me.dgLotInfo.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgLotInfo.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 10.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgLotInfo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgLotInfo.ColumnHeadersHeight = 24
        Me.dgLotInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgLotInfo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.WaferID})
        Me.dgLotInfo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgLotInfo.Location = New System.Drawing.Point(485, 479)
        Me.dgLotInfo.MultiSelect = False
        Me.dgLotInfo.Name = "dgLotInfo"
        Me.dgLotInfo.ReadOnly = True
        Me.dgLotInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgLotInfo.RowTemplate.Height = 24
        Me.dgLotInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgLotInfo.Size = New System.Drawing.Size(388, 344)
        Me.dgLotInfo.TabIndex = 751
        Me.dgLotInfo.Visible = False
        '
        'lblRecipeName
        '
        Me.lblRecipeName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblRecipeName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRecipeName.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lblRecipeName.ForeColor = System.Drawing.Color.Black
        Me.lblRecipeName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRecipeName.Location = New System.Drawing.Point(533, 8)
        Me.lblRecipeName.Name = "lblRecipeName"
        Me.lblRecipeName.Size = New System.Drawing.Size(253, 26)
        Me.lblRecipeName.TabIndex = 772
        Me.lblRecipeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRecipeNameText
        '
        Me.lblRecipeNameText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRecipeNameText.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lblRecipeNameText.Location = New System.Drawing.Point(397, 8)
        Me.lblRecipeNameText.Name = "lblRecipeNameText"
        Me.lblRecipeNameText.Size = New System.Drawing.Size(132, 26)
        Me.lblRecipeNameText.TabIndex = 771
        Me.lblRecipeNameText.Text = "配方名稱::"
        Me.lblRecipeNameText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalWaferCount
        '
        Me.lblTotalWaferCount.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTotalWaferCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalWaferCount.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblTotalWaferCount.Location = New System.Drawing.Point(326, 130)
        Me.lblTotalWaferCount.Name = "lblTotalWaferCount"
        Me.lblTotalWaferCount.Size = New System.Drawing.Size(66, 26)
        Me.lblTotalWaferCount.TabIndex = 752
        Me.lblTotalWaferCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalWafer
        '
        Me.lblTotalWafer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalWafer.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblTotalWafer.Location = New System.Drawing.Point(263, 130)
        Me.lblTotalWafer.Name = "lblTotalWafer"
        Me.lblTotalWafer.Size = New System.Drawing.Size(57, 26)
        Me.lblTotalWafer.TabIndex = 760
        Me.lblTotalWafer.Text = "Total:"
        Me.lblTotalWafer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lstWaferID
        '
        Me.lstWaferID.ColumnWidth = 320
        Me.lstWaferID.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.lstWaferID.FormattingEnabled = True
        Me.lstWaferID.HorizontalScrollbar = True
        Me.lstWaferID.ItemHeight = 22
        Me.lstWaferID.Items.AddRange(New Object() {"1531531351451532", "1531531351451532", "1531531351451532", "1531531351451532", "1531531351451532", "1531531351451532", "1531531351451532", "1531531351451532", "1531531351451532", "1531531351451532", "1531531351451532", "1531531351451532", "1531531351451532", "1531531351451532", "1531531351451532", "1531531351451532", "1531531351451532", "1531531351451532", "1531531351451532", "1531531351451532", "1531531351451532", "1531531351451532", "1531531351451532", "1531531351451532", "1531531351451532", "1531531351451532", "1531531351451532", "1531531351451532", "1531531351451532", "1531531351451532", "1531531351451532", "1531531351451532", "1531531351451532", "1531531351451532", "1531531351451532", "1531531351451532", "1531531351451532", "1531531351451532", "1531531351451532", "1531531351451532", "1531531351451532", "1531531351451532", "1531531351451532", "1531531351451532", "1531531351451532", "1531531351451532", "1531531351451532"})
        Me.lstWaferID.Location = New System.Drawing.Point(3, 162)
        Me.lstWaferID.MultiColumn = True
        Me.lstWaferID.Name = "lstWaferID"
        Me.lstWaferID.ScrollAlwaysVisible = True
        Me.lstWaferID.Size = New System.Drawing.Size(871, 312)
        Me.lstWaferID.TabIndex = 773
        '
        'txtRunID2
        '
        Me.txtRunID2.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtRunID2.Location = New System.Drawing.Point(320, 69)
        Me.txtRunID2.Name = "txtRunID2"
        Me.txtRunID2.Size = New System.Drawing.Size(182, 26)
        Me.txtRunID2.TabIndex = 774
        '
        'txtRunID3
        '
        Me.txtRunID3.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtRunID3.Location = New System.Drawing.Point(502, 69)
        Me.txtRunID3.Name = "txtRunID3"
        Me.txtRunID3.Size = New System.Drawing.Size(182, 26)
        Me.txtRunID3.TabIndex = 775
        '
        'txtRunID4
        '
        Me.txtRunID4.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtRunID4.Location = New System.Drawing.Point(684, 69)
        Me.txtRunID4.Name = "txtRunID4"
        Me.txtRunID4.Size = New System.Drawing.Size(182, 26)
        Me.txtRunID4.TabIndex = 776
        '
        'txtRunID8
        '
        Me.txtRunID8.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtRunID8.Location = New System.Drawing.Point(684, 97)
        Me.txtRunID8.Name = "txtRunID8"
        Me.txtRunID8.Size = New System.Drawing.Size(182, 26)
        Me.txtRunID8.TabIndex = 780
        '
        'txtRunID7
        '
        Me.txtRunID7.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtRunID7.Location = New System.Drawing.Point(502, 97)
        Me.txtRunID7.Name = "txtRunID7"
        Me.txtRunID7.Size = New System.Drawing.Size(182, 26)
        Me.txtRunID7.TabIndex = 779
        '
        'txtRunID6
        '
        Me.txtRunID6.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtRunID6.Location = New System.Drawing.Point(320, 97)
        Me.txtRunID6.Name = "txtRunID6"
        Me.txtRunID6.Size = New System.Drawing.Size(182, 26)
        Me.txtRunID6.TabIndex = 778
        '
        'txtRunID5
        '
        Me.txtRunID5.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtRunID5.Location = New System.Drawing.Point(138, 97)
        Me.txtRunID5.Name = "txtRunID5"
        Me.txtRunID5.Size = New System.Drawing.Size(182, 26)
        Me.txtRunID5.TabIndex = 777
        '
        'CtlSanAnCIM
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.txtRunID8)
        Me.Controls.Add(Me.txtRunID7)
        Me.Controls.Add(Me.txtRunID6)
        Me.Controls.Add(Me.txtRunID5)
        Me.Controls.Add(Me.txtRunID4)
        Me.Controls.Add(Me.txtRunID3)
        Me.Controls.Add(Me.txtRunID2)
        Me.Controls.Add(Me.lstWaferID)
        Me.Controls.Add(Me.lblRecipeName)
        Me.Controls.Add(Me.lblRecipeNameText)
        Me.Controls.Add(Me.txtRunID1)
        Me.Controls.Add(Me.lblRunID)
        Me.Controls.Add(Me.lblAlive)
        Me.Controls.Add(Me.lblTotalWafer)
        Me.Controls.Add(Me.lblTotalWaferCount)
        Me.Controls.Add(Me.dgLotInfo)
        Me.Controls.Add(Me.lblLotInfoList)
        Me.Controls.Add(Me.lblOPIDtext)
        Me.Controls.Add(Me.txtOpID)
        Me.Controls.Add(Me.lblEQID)
        Me.Controls.Add(Me.lblEQIDText)
        Me.Controls.Add(Me.btnOffLine)
        Me.Controls.Add(Me.btnInLine)
        Me.Controls.Add(Me.btnClearAll)
        Me.Controls.Add(Me.lblLotIDText)
        Me.Controls.Add(Me.txtLotA)
        Me.Controls.Add(Me.btnEndProductInput)
        Me.Controls.Add(Me.btnKeyIn)
        Me.Controls.Add(Me.btnBarcodeReader)
        Me.Controls.Add(Me.lblTimeOut)
        Me.Controls.Add(Me.lblLoginStatus)
        Me.Controls.Add(Me.btnRunProcess)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Name = "CtlSanAnCIM"
        Me.Size = New System.Drawing.Size(1016, 486)
        CType(Me.dgLotInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnRunProcess As System.Windows.Forms.Button
    Friend WithEvents btnClearAll As System.Windows.Forms.Button
    Friend WithEvents lblLotIDText As System.Windows.Forms.Label
    Friend WithEvents txtLotA As System.Windows.Forms.TextBox
    Friend WithEvents btnEndProductInput As System.Windows.Forms.Button
    Friend WithEvents btnKeyIn As System.Windows.Forms.Button
    Friend WithEvents btnBarcodeReader As System.Windows.Forms.Button
    Friend WithEvents btnOffLine As System.Windows.Forms.Button
    Friend WithEvents btnInLine As System.Windows.Forms.Button
    Friend WithEvents lblLoginStatus As System.Windows.Forms.Label
    Friend WithEvents lblEQID As System.Windows.Forms.Label
    Friend WithEvents lblEQIDText As System.Windows.Forms.Label
    Friend WithEvents lblOPIDtext As System.Windows.Forms.Label
    Friend WithEvents txtOpID As System.Windows.Forms.TextBox
    Friend WithEvents lblLotInfoList As System.Windows.Forms.Label
    Friend WithEvents lblAlive As System.Windows.Forms.Label
    Friend WithEvents lblTimeOut As System.Windows.Forms.Label
    Friend WithEvents lblRunID As System.Windows.Forms.Label
    Friend WithEvents txtRunID1 As System.Windows.Forms.TextBox
    Friend WithEvents WaferID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgLotInfo As System.Windows.Forms.DataGridView
    Friend WithEvents lblRecipeName As System.Windows.Forms.Label
    Friend WithEvents lblRecipeNameText As System.Windows.Forms.Label
    Friend WithEvents lblTotalWaferCount As System.Windows.Forms.Label
    Friend WithEvents lblTotalWafer As System.Windows.Forms.Label
    Friend WithEvents lstWaferID As System.Windows.Forms.ListBox
    Friend WithEvents txtRunID2 As System.Windows.Forms.TextBox
    Friend WithEvents txtRunID3 As System.Windows.Forms.TextBox
    Friend WithEvents txtRunID4 As System.Windows.Forms.TextBox
    Friend WithEvents txtRunID8 As System.Windows.Forms.TextBox
    Friend WithEvents txtRunID7 As System.Windows.Forms.TextBox
    Friend WithEvents txtRunID6 As System.Windows.Forms.TextBox
    Friend WithEvents txtRunID5 As System.Windows.Forms.TextBox

End Class

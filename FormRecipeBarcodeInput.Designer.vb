<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRecipeBarcodeInput
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblBarcodeRecipeText = New System.Windows.Forms.Label()
        Me.txtRecipeFile = New System.Windows.Forms.TextBox()
        Me.txtBarcodeMap = New System.Windows.Forms.TextBox()
        Me.lblRecipeFileText = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.dgRunCardInput = New System.Windows.Forms.DataGridView()
        Me.ProductID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RunCardID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WaferNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnEndProductInput = New System.Windows.Forms.Button()
        Me.lblProductIDText = New System.Windows.Forms.Label()
        Me.txtProductID = New System.Windows.Forms.TextBox()
        Me.lblRunCardIDText = New System.Windows.Forms.Label()
        Me.txtRunCardID = New System.Windows.Forms.TextBox()
        Me.lblWaferNumText = New System.Windows.Forms.Label()
        Me.txtWaferNum = New System.Windows.Forms.TextBox()
        Me.btnRunProcess = New System.Windows.Forms.Button()
        Me.lblMapCount = New System.Windows.Forms.Label()
        Me.btnClearAll = New System.Windows.Forms.Button()
        Me.btnClearSingle = New System.Windows.Forms.Button()
        Me.btnKeyIn = New System.Windows.Forms.Button()
        Me.btnBarcodeReader = New System.Windows.Forms.Button()
        Me.lblOPCodeText = New System.Windows.Forms.Label()
        Me.txtOPCode = New System.Windows.Forms.TextBox()
        Me.lblWaferDPOverCurrentText = New System.Windows.Forms.Label()
        Me.btnDeleteLast = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnAddData = New System.Windows.Forms.Button()
        CType(Me.dgRunCardInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBarcodeRecipeText
        '
        Me.lblBarcodeRecipeText.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblBarcodeRecipeText.Location = New System.Drawing.Point(4, 153)
        Me.lblBarcodeRecipeText.Name = "lblBarcodeRecipeText"
        Me.lblBarcodeRecipeText.Size = New System.Drawing.Size(105, 32)
        Me.lblBarcodeRecipeText.TabIndex = 667
        Me.lblBarcodeRecipeText.Text = "配方代號:"
        Me.lblBarcodeRecipeText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRecipeFile
        '
        Me.txtRecipeFile.Enabled = False
        Me.txtRecipeFile.Font = New System.Drawing.Font("Arial", 16.0!)
        Me.txtRecipeFile.Location = New System.Drawing.Point(115, 192)
        Me.txtRecipeFile.Name = "txtRecipeFile"
        Me.txtRecipeFile.Size = New System.Drawing.Size(319, 32)
        Me.txtRecipeFile.TabIndex = 4
        '
        'txtBarcodeMap
        '
        Me.txtBarcodeMap.Font = New System.Drawing.Font("Arial", 16.0!)
        Me.txtBarcodeMap.Location = New System.Drawing.Point(115, 154)
        Me.txtBarcodeMap.Name = "txtBarcodeMap"
        Me.txtBarcodeMap.Size = New System.Drawing.Size(319, 32)
        Me.txtBarcodeMap.TabIndex = 3
        '
        'lblRecipeFileText
        '
        Me.lblRecipeFileText.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblRecipeFileText.Location = New System.Drawing.Point(4, 193)
        Me.lblRecipeFileText.Name = "lblRecipeFileText"
        Me.lblRecipeFileText.Size = New System.Drawing.Size(105, 32)
        Me.lblRecipeFileText.TabIndex = 668
        Me.lblRecipeFileText.Text = "配方檔案:"
        Me.lblRecipeFileText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExit.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnExit.Location = New System.Drawing.Point(714, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(110, 42)
        Me.btnExit.TabIndex = 673
        Me.btnExit.Text = "離開"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'dgRunCardInput
        '
        Me.dgRunCardInput.AllowUserToAddRows = False
        Me.dgRunCardInput.AllowUserToDeleteRows = False
        Me.dgRunCardInput.AllowUserToResizeColumns = False
        Me.dgRunCardInput.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgRunCardInput.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgRunCardInput.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.dgRunCardInput.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgRunCardInput.ColumnHeadersHeight = 36
        Me.dgRunCardInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgRunCardInput.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductID, Me.RunCardID, Me.WaferNum})
        Me.dgRunCardInput.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgRunCardInput.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgRunCardInput.EnableHeadersVisualStyles = False
        Me.dgRunCardInput.GridColor = System.Drawing.Color.Black
        Me.dgRunCardInput.Location = New System.Drawing.Point(5, 239)
        Me.dgRunCardInput.MultiSelect = False
        Me.dgRunCardInput.Name = "dgRunCardInput"
        Me.dgRunCardInput.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 14.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgRunCardInput.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgRunCardInput.RowHeadersWidth = 60
        Me.dgRunCardInput.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgRunCardInput.RowTemplate.Height = 24
        Me.dgRunCardInput.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgRunCardInput.Size = New System.Drawing.Size(824, 429)
        Me.dgRunCardInput.TabIndex = 15
        Me.dgRunCardInput.TabStop = False
        '
        'ProductID
        '
        Me.ProductID.HeaderText = "產品名稱"
        Me.ProductID.Name = "ProductID"
        Me.ProductID.ReadOnly = True
        Me.ProductID.Width = 300
        '
        'RunCardID
        '
        Me.RunCardID.HeaderText = "工單號碼"
        Me.RunCardID.Name = "RunCardID"
        Me.RunCardID.ReadOnly = True
        Me.RunCardID.Width = 300
        '
        'WaferNum
        '
        Me.WaferNum.HeaderText = "晶圓片數"
        Me.WaferNum.Name = "WaferNum"
        Me.WaferNum.ReadOnly = True
        Me.WaferNum.Width = 160
        '
        'btnEndProductInput
        '
        Me.btnEndProductInput.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEndProductInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEndProductInput.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btnEndProductInput.Location = New System.Drawing.Point(324, 79)
        Me.btnEndProductInput.Name = "btnEndProductInput"
        Me.btnEndProductInput.Size = New System.Drawing.Size(110, 69)
        Me.btnEndProductInput.TabIndex = 5
        Me.btnEndProductInput.Text = "結束工單"
        Me.btnEndProductInput.UseVisualStyleBackColor = False
        '
        'lblProductIDText
        '
        Me.lblProductIDText.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblProductIDText.Location = New System.Drawing.Point(4, 2)
        Me.lblProductIDText.Name = "lblProductIDText"
        Me.lblProductIDText.Size = New System.Drawing.Size(105, 32)
        Me.lblProductIDText.TabIndex = 676
        Me.lblProductIDText.Text = "產品名稱:"
        Me.lblProductIDText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtProductID
        '
        Me.txtProductID.Font = New System.Drawing.Font("Arial", 16.0!)
        Me.txtProductID.Location = New System.Drawing.Point(115, 3)
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.Size = New System.Drawing.Size(319, 32)
        Me.txtProductID.TabIndex = 0
        '
        'lblRunCardIDText
        '
        Me.lblRunCardIDText.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblRunCardIDText.Location = New System.Drawing.Point(4, 40)
        Me.lblRunCardIDText.Name = "lblRunCardIDText"
        Me.lblRunCardIDText.Size = New System.Drawing.Size(105, 32)
        Me.lblRunCardIDText.TabIndex = 678
        Me.lblRunCardIDText.Text = "工單號碼:"
        Me.lblRunCardIDText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRunCardID
        '
        Me.txtRunCardID.Font = New System.Drawing.Font("Arial", 16.0!)
        Me.txtRunCardID.Location = New System.Drawing.Point(115, 41)
        Me.txtRunCardID.Name = "txtRunCardID"
        Me.txtRunCardID.Size = New System.Drawing.Size(319, 32)
        Me.txtRunCardID.TabIndex = 1
        '
        'lblWaferNumText
        '
        Me.lblWaferNumText.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblWaferNumText.Location = New System.Drawing.Point(4, 77)
        Me.lblWaferNumText.Name = "lblWaferNumText"
        Me.lblWaferNumText.Size = New System.Drawing.Size(105, 32)
        Me.lblWaferNumText.TabIndex = 680
        Me.lblWaferNumText.Text = "晶圓片數:"
        Me.lblWaferNumText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtWaferNum
        '
        Me.txtWaferNum.Font = New System.Drawing.Font("Arial", 16.0!)
        Me.txtWaferNum.Location = New System.Drawing.Point(115, 78)
        Me.txtWaferNum.Name = "txtWaferNum"
        Me.txtWaferNum.Size = New System.Drawing.Size(92, 32)
        Me.txtWaferNum.TabIndex = 2
        '
        'btnRunProcess
        '
        Me.btnRunProcess.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRunProcess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRunProcess.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btnRunProcess.Location = New System.Drawing.Point(714, 68)
        Me.btnRunProcess.Name = "btnRunProcess"
        Me.btnRunProcess.Size = New System.Drawing.Size(110, 90)
        Me.btnRunProcess.TabIndex = 8
        Me.btnRunProcess.Text = "執行製程"
        Me.btnRunProcess.UseVisualStyleBackColor = False
        '
        'lblMapCount
        '
        Me.lblMapCount.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblMapCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMapCount.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMapCount.ForeColor = System.Drawing.Color.Black
        Me.lblMapCount.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMapCount.Location = New System.Drawing.Point(716, 185)
        Me.lblMapCount.Name = "lblMapCount"
        Me.lblMapCount.Size = New System.Drawing.Size(108, 36)
        Me.lblMapCount.TabIndex = 681
        Me.lblMapCount.Text = "01"
        Me.lblMapCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClearAll
        '
        Me.btnClearAll.BackColor = System.Drawing.Color.Magenta
        Me.btnClearAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClearAll.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btnClearAll.ForeColor = System.Drawing.Color.Black
        Me.btnClearAll.Location = New System.Drawing.Point(582, 183)
        Me.btnClearAll.Name = "btnClearAll"
        Me.btnClearAll.Size = New System.Drawing.Size(110, 42)
        Me.btnClearAll.TabIndex = 7
        Me.btnClearAll.Text = "清除全部"
        Me.btnClearAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClearAll.UseVisualStyleBackColor = False
        '
        'btnClearSingle
        '
        Me.btnClearSingle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnClearSingle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClearSingle.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btnClearSingle.ForeColor = System.Drawing.Color.Black
        Me.btnClearSingle.Location = New System.Drawing.Point(582, 78)
        Me.btnClearSingle.Name = "btnClearSingle"
        Me.btnClearSingle.Size = New System.Drawing.Size(110, 42)
        Me.btnClearSingle.TabIndex = 6
        Me.btnClearSingle.Text = "清除資料"
        Me.btnClearSingle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClearSingle.UseVisualStyleBackColor = False
        '
        'btnKeyIn
        '
        Me.btnKeyIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnKeyIn.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btnKeyIn.ForeColor = System.Drawing.Color.Black
        Me.btnKeyIn.Location = New System.Drawing.Point(582, 2)
        Me.btnKeyIn.Name = "btnKeyIn"
        Me.btnKeyIn.Size = New System.Drawing.Size(110, 42)
        Me.btnKeyIn.TabIndex = 10
        Me.btnKeyIn.Text = "手動輸入"
        Me.btnKeyIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnKeyIn.UseVisualStyleBackColor = True
        '
        'btnBarcodeReader
        '
        Me.btnBarcodeReader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBarcodeReader.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btnBarcodeReader.ForeColor = System.Drawing.Color.Black
        Me.btnBarcodeReader.Location = New System.Drawing.Point(450, 2)
        Me.btnBarcodeReader.Name = "btnBarcodeReader"
        Me.btnBarcodeReader.Size = New System.Drawing.Size(110, 42)
        Me.btnBarcodeReader.TabIndex = 9
        Me.btnBarcodeReader.Text = "刷入條碼"
        Me.btnBarcodeReader.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBarcodeReader.UseVisualStyleBackColor = True
        '
        'lblOPCodeText
        '
        Me.lblOPCodeText.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblOPCodeText.Location = New System.Drawing.Point(4, 115)
        Me.lblOPCodeText.Name = "lblOPCodeText"
        Me.lblOPCodeText.Size = New System.Drawing.Size(105, 32)
        Me.lblOPCodeText.TabIndex = 683
        Me.lblOPCodeText.Text = "輸入人員:"
        Me.lblOPCodeText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOPCode
        '
        Me.txtOPCode.Font = New System.Drawing.Font("Arial", 16.0!)
        Me.txtOPCode.Location = New System.Drawing.Point(115, 116)
        Me.txtOPCode.Name = "txtOPCode"
        Me.txtOPCode.Size = New System.Drawing.Size(203, 32)
        Me.txtOPCode.TabIndex = 682
        '
        'lblWaferDPOverCurrentText
        '
        Me.lblWaferDPOverCurrentText.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.lblWaferDPOverCurrentText.Location = New System.Drawing.Point(213, 82)
        Me.lblWaferDPOverCurrentText.Name = "lblWaferDPOverCurrentText"
        Me.lblWaferDPOverCurrentText.Size = New System.Drawing.Size(105, 28)
        Me.lblWaferDPOverCurrentText.TabIndex = 684
        Me.lblWaferDPOverCurrentText.Text = "(1~26)"
        Me.lblWaferDPOverCurrentText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnDeleteLast
        '
        Me.btnDeleteLast.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDeleteLast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDeleteLast.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btnDeleteLast.ForeColor = System.Drawing.Color.Black
        Me.btnDeleteLast.Location = New System.Drawing.Point(450, 183)
        Me.btnDeleteLast.Name = "btnDeleteLast"
        Me.btnDeleteLast.Size = New System.Drawing.Size(110, 42)
        Me.btnDeleteLast.TabIndex = 685
        Me.btnDeleteLast.Text = "刪除單筆"
        Me.btnDeleteLast.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDeleteLast.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'btnAddData
        '
        Me.btnAddData.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAddData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddData.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnAddData.Location = New System.Drawing.Point(450, 79)
        Me.btnAddData.Name = "btnAddData"
        Me.btnAddData.Size = New System.Drawing.Size(110, 42)
        Me.btnAddData.TabIndex = 686
        Me.btnAddData.Text = "加入資料"
        Me.btnAddData.UseVisualStyleBackColor = False
        '
        'FormRecipeBarcodeInput
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(834, 672)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnAddData)
        Me.Controls.Add(Me.btnDeleteLast)
        Me.Controls.Add(Me.lblWaferDPOverCurrentText)
        Me.Controls.Add(Me.lblOPCodeText)
        Me.Controls.Add(Me.txtOPCode)
        Me.Controls.Add(Me.lblMapCount)
        Me.Controls.Add(Me.btnRunProcess)
        Me.Controls.Add(Me.btnClearAll)
        Me.Controls.Add(Me.btnClearSingle)
        Me.Controls.Add(Me.lblWaferNumText)
        Me.Controls.Add(Me.txtWaferNum)
        Me.Controls.Add(Me.lblRunCardIDText)
        Me.Controls.Add(Me.txtRunCardID)
        Me.Controls.Add(Me.lblProductIDText)
        Me.Controls.Add(Me.txtProductID)
        Me.Controls.Add(Me.btnEndProductInput)
        Me.Controls.Add(Me.dgRunCardInput)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnKeyIn)
        Me.Controls.Add(Me.btnBarcodeReader)
        Me.Controls.Add(Me.lblBarcodeRecipeText)
        Me.Controls.Add(Me.txtRecipeFile)
        Me.Controls.Add(Me.txtBarcodeMap)
        Me.Controls.Add(Me.lblRecipeFileText)
        Me.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormRecipeBarcodeInput"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "請刷入條碼"
        CType(Me.dgRunCardInput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnKeyIn As System.Windows.Forms.Button
    Friend WithEvents btnBarcodeReader As System.Windows.Forms.Button
    Friend WithEvents lblBarcodeRecipeText As System.Windows.Forms.Label
    Friend WithEvents txtRecipeFile As System.Windows.Forms.TextBox
    Friend WithEvents txtBarcodeMap As System.Windows.Forms.TextBox
    Friend WithEvents lblRecipeFileText As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents dgRunCardInput As System.Windows.Forms.DataGridView
    Friend WithEvents ProductID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RunCardID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WaferNum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnEndProductInput As System.Windows.Forms.Button
    Friend WithEvents lblProductIDText As System.Windows.Forms.Label
    Friend WithEvents txtProductID As System.Windows.Forms.TextBox
    Friend WithEvents lblRunCardIDText As System.Windows.Forms.Label
    Friend WithEvents txtRunCardID As System.Windows.Forms.TextBox
    Friend WithEvents lblWaferNumText As System.Windows.Forms.Label
    Friend WithEvents txtWaferNum As System.Windows.Forms.TextBox
    Friend WithEvents btnClearSingle As System.Windows.Forms.Button
    Friend WithEvents btnClearAll As System.Windows.Forms.Button
    Friend WithEvents btnRunProcess As System.Windows.Forms.Button
    Friend WithEvents lblMapCount As System.Windows.Forms.Label
    Friend WithEvents lblOPCodeText As System.Windows.Forms.Label
    Friend WithEvents txtOPCode As System.Windows.Forms.TextBox
    Friend WithEvents lblWaferDPOverCurrentText As System.Windows.Forms.Label
    Friend WithEvents btnDeleteLast As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnAddData As System.Windows.Forms.Button
End Class

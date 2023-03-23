<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRecipeMapEdit
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
        Me.txtRecipe = New System.Windows.Forms.TextBox()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblRecipeName = New System.Windows.Forms.Label()
        Me.lstBarcode = New System.Windows.Forms.ListBox()
        Me.lblBarcodeNameText = New System.Windows.Forms.Label()
        Me.lstRecipe = New System.Windows.Forms.ListBox()
        Me.grpRecipeMapEditor = New System.Windows.Forms.GroupBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblCurrentSelect = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblMapCount = New System.Windows.Forms.Label()
        Me.btnModifiySelection = New System.Windows.Forms.Button()
        Me.btnRecipeSelect = New System.Windows.Forms.Button()
        Me.btnKeyIn = New System.Windows.Forms.Button()
        Me.btnBarcodeReader = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.grpRecipeMapEditor.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtRecipe
        '
        Me.txtRecipe.Font = New System.Drawing.Font("Arial", 16.0!)
        Me.txtRecipe.Location = New System.Drawing.Point(329, 76)
        Me.txtRecipe.Name = "txtRecipe"
        Me.txtRecipe.Size = New System.Drawing.Size(314, 32)
        Me.txtRecipe.TabIndex = 220
        '
        'txtBarcode
        '
        Me.txtBarcode.Font = New System.Drawing.Font("Arial", 16.0!)
        Me.txtBarcode.Location = New System.Drawing.Point(9, 76)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(314, 32)
        Me.txtBarcode.TabIndex = 219
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExit.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnExit.Location = New System.Drawing.Point(646, 386)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(110, 42)
        Me.btnExit.TabIndex = 217
        Me.btnExit.Text = "離開"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblRecipeName
        '
        Me.lblRecipeName.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblRecipeName.Location = New System.Drawing.Point(326, 39)
        Me.lblRecipeName.Name = "lblRecipeName"
        Me.lblRecipeName.Size = New System.Drawing.Size(87, 34)
        Me.lblRecipeName.TabIndex = 216
        Me.lblRecipeName.Text = "配方檔案:"
        Me.lblRecipeName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lstBarcode
        '
        Me.lstBarcode.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBarcode.FormattingEnabled = True
        Me.lstBarcode.ItemHeight = 24
        Me.lstBarcode.Location = New System.Drawing.Point(9, 112)
        Me.lstBarcode.Name = "lstBarcode"
        Me.lstBarcode.ScrollAlwaysVisible = True
        Me.lstBarcode.Size = New System.Drawing.Size(314, 316)
        Me.lstBarcode.TabIndex = 215
        '
        'lblBarcodeNameText
        '
        Me.lblBarcodeNameText.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblBarcodeNameText.Location = New System.Drawing.Point(12, 39)
        Me.lblBarcodeNameText.Name = "lblBarcodeNameText"
        Me.lblBarcodeNameText.Size = New System.Drawing.Size(102, 34)
        Me.lblBarcodeNameText.TabIndex = 214
        Me.lblBarcodeNameText.Text = "條碼名稱:"
        Me.lblBarcodeNameText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lstRecipe
        '
        Me.lstRecipe.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstRecipe.FormattingEnabled = True
        Me.lstRecipe.ItemHeight = 24
        Me.lstRecipe.Location = New System.Drawing.Point(329, 112)
        Me.lstRecipe.Name = "lstRecipe"
        Me.lstRecipe.ScrollAlwaysVisible = True
        Me.lstRecipe.Size = New System.Drawing.Size(314, 316)
        Me.lstRecipe.TabIndex = 213
        '
        'grpRecipeMapEditor
        '
        Me.grpRecipeMapEditor.Controls.Add(Me.btnDelete)
        Me.grpRecipeMapEditor.Controls.Add(Me.lblCurrentSelect)
        Me.grpRecipeMapEditor.Controls.Add(Me.btnSave)
        Me.grpRecipeMapEditor.Controls.Add(Me.lblMapCount)
        Me.grpRecipeMapEditor.Controls.Add(Me.btnModifiySelection)
        Me.grpRecipeMapEditor.Controls.Add(Me.btnRecipeSelect)
        Me.grpRecipeMapEditor.Controls.Add(Me.btnKeyIn)
        Me.grpRecipeMapEditor.Controls.Add(Me.btnBarcodeReader)
        Me.grpRecipeMapEditor.Controls.Add(Me.lblBarcodeNameText)
        Me.grpRecipeMapEditor.Controls.Add(Me.btnExit)
        Me.grpRecipeMapEditor.Controls.Add(Me.btnInsert)
        Me.grpRecipeMapEditor.Controls.Add(Me.txtRecipe)
        Me.grpRecipeMapEditor.Controls.Add(Me.lstRecipe)
        Me.grpRecipeMapEditor.Controls.Add(Me.txtBarcode)
        Me.grpRecipeMapEditor.Controls.Add(Me.lstBarcode)
        Me.grpRecipeMapEditor.Controls.Add(Me.lblRecipeName)
        Me.grpRecipeMapEditor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpRecipeMapEditor.Location = New System.Drawing.Point(0, 0)
        Me.grpRecipeMapEditor.Name = "grpRecipeMapEditor"
        Me.grpRecipeMapEditor.Size = New System.Drawing.Size(768, 442)
        Me.grpRecipeMapEditor.TabIndex = 221
        Me.grpRecipeMapEditor.TabStop = False
        Me.grpRecipeMapEditor.Text = "條碼-配方對照表編輯"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btnDelete.Location = New System.Drawing.Point(646, 207)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(110, 42)
        Me.btnDelete.TabIndex = 672
        Me.btnDelete.Text = "刪除"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'lblCurrentSelect
        '
        Me.lblCurrentSelect.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCurrentSelect.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCurrentSelect.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentSelect.ForeColor = System.Drawing.Color.Black
        Me.lblCurrentSelect.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCurrentSelect.Location = New System.Drawing.Point(626, 19)
        Me.lblCurrentSelect.Name = "lblCurrentSelect"
        Me.lblCurrentSelect.Size = New System.Drawing.Size(65, 36)
        Me.lblCurrentSelect.TabIndex = 671
        Me.lblCurrentSelect.Text = "01"
        Me.lblCurrentSelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSave.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btnSave.Location = New System.Drawing.Point(646, 305)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(110, 42)
        Me.btnSave.TabIndex = 670
        Me.btnSave.Text = "儲存"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lblMapCount
        '
        Me.lblMapCount.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblMapCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMapCount.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMapCount.ForeColor = System.Drawing.Color.Black
        Me.lblMapCount.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMapCount.Location = New System.Drawing.Point(694, 19)
        Me.lblMapCount.Name = "lblMapCount"
        Me.lblMapCount.Size = New System.Drawing.Size(65, 36)
        Me.lblMapCount.TabIndex = 669
        Me.lblMapCount.Text = "01"
        Me.lblMapCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnModifiySelection
        '
        Me.btnModifiySelection.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnModifiySelection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnModifiySelection.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btnModifiySelection.ForeColor = System.Drawing.Color.Black
        Me.btnModifiySelection.Location = New System.Drawing.Point(646, 141)
        Me.btnModifiySelection.Name = "btnModifiySelection"
        Me.btnModifiySelection.Size = New System.Drawing.Size(110, 42)
        Me.btnModifiySelection.TabIndex = 668
        Me.btnModifiySelection.Text = "修改"
        Me.btnModifiySelection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnModifiySelection.UseVisualStyleBackColor = False
        Me.btnModifiySelection.Visible = False
        '
        'btnRecipeSelect
        '
        Me.btnRecipeSelect.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRecipeSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRecipeSelect.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btnRecipeSelect.ForeColor = System.Drawing.Color.Black
        Me.btnRecipeSelect.Location = New System.Drawing.Point(419, 39)
        Me.btnRecipeSelect.Name = "btnRecipeSelect"
        Me.btnRecipeSelect.Size = New System.Drawing.Size(110, 34)
        Me.btnRecipeSelect.TabIndex = 667
        Me.btnRecipeSelect.Text = "配方選擇"
        Me.btnRecipeSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRecipeSelect.UseVisualStyleBackColor = False
        '
        'btnKeyIn
        '
        Me.btnKeyIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnKeyIn.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btnKeyIn.ForeColor = System.Drawing.Color.Black
        Me.btnKeyIn.Location = New System.Drawing.Point(220, 39)
        Me.btnKeyIn.Name = "btnKeyIn"
        Me.btnKeyIn.Size = New System.Drawing.Size(88, 34)
        Me.btnKeyIn.TabIndex = 666
        Me.btnKeyIn.Text = "手動輸入"
        Me.btnKeyIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnKeyIn.UseVisualStyleBackColor = True
        '
        'btnBarcodeReader
        '
        Me.btnBarcodeReader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBarcodeReader.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btnBarcodeReader.ForeColor = System.Drawing.Color.Black
        Me.btnBarcodeReader.Location = New System.Drawing.Point(104, 39)
        Me.btnBarcodeReader.Name = "btnBarcodeReader"
        Me.btnBarcodeReader.Size = New System.Drawing.Size(88, 34)
        Me.btnBarcodeReader.TabIndex = 665
        Me.btnBarcodeReader.Text = "刷入條碼"
        Me.btnBarcodeReader.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBarcodeReader.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnInsert.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btnInsert.Location = New System.Drawing.Point(646, 71)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(110, 42)
        Me.btnInsert.TabIndex = 218
        Me.btnInsert.Text = "加入"
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'FormRecipeMapEdit
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(768, 442)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpRecipeMapEditor)
        Me.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormRecipeMapEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recipe Mapping"
        Me.grpRecipeMapEditor.ResumeLayout(False)
        Me.grpRecipeMapEditor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtRecipe As System.Windows.Forms.TextBox
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblRecipeName As System.Windows.Forms.Label
    Friend WithEvents lstBarcode As System.Windows.Forms.ListBox
    Friend WithEvents lblBarcodeNameText As System.Windows.Forms.Label
    Friend WithEvents lstRecipe As System.Windows.Forms.ListBox
    Friend WithEvents grpRecipeMapEditor As System.Windows.Forms.GroupBox
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents btnBarcodeReader As System.Windows.Forms.Button
    Friend WithEvents btnKeyIn As System.Windows.Forms.Button
    Friend WithEvents btnRecipeSelect As System.Windows.Forms.Button
    Friend WithEvents btnModifiySelection As System.Windows.Forms.Button
    Friend WithEvents lblMapCount As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblCurrentSelect As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class

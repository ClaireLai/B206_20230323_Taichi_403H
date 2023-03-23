<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSanAnBarcodeInput
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnRunProcess = New System.Windows.Forms.Button()
        Me.btnClearData = New System.Windows.Forms.Button()
        Me.btnKeyIn = New System.Windows.Forms.Button()
        Me.btnBarcodeReader = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblLotIDCount = New System.Windows.Forms.Label()
        Me.lblEQIDText = New System.Windows.Forms.Label()
        Me.lblEQID = New System.Windows.Forms.Label()
        Me.txtLotID = New System.Windows.Forms.TextBox()
        Me.lblLotIDText = New System.Windows.Forms.Label()
        Me.lstLotID = New System.Windows.Forms.ListBox()
        Me.lblLotIDListText = New System.Windows.Forms.Label()
        Me.lblOPIDText = New System.Windows.Forms.Label()
        Me.txtOPID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExit.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btnExit.Location = New System.Drawing.Point(504, 420)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(128, 34)
        Me.btnExit.TabIndex = 673
        Me.btnExit.Text = "離開"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnRunProcess
        '
        Me.btnRunProcess.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRunProcess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRunProcess.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btnRunProcess.Location = New System.Drawing.Point(504, 250)
        Me.btnRunProcess.Name = "btnRunProcess"
        Me.btnRunProcess.Size = New System.Drawing.Size(128, 68)
        Me.btnRunProcess.TabIndex = 8
        Me.btnRunProcess.Text = "執行製程"
        Me.btnRunProcess.UseVisualStyleBackColor = False
        '
        'btnClearData
        '
        Me.btnClearData.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnClearData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClearData.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btnClearData.ForeColor = System.Drawing.Color.Black
        Me.btnClearData.Location = New System.Drawing.Point(504, 121)
        Me.btnClearData.Name = "btnClearData"
        Me.btnClearData.Size = New System.Drawing.Size(128, 34)
        Me.btnClearData.TabIndex = 6
        Me.btnClearData.Text = "清除資料"
        Me.btnClearData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClearData.UseVisualStyleBackColor = False
        '
        'btnKeyIn
        '
        Me.btnKeyIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnKeyIn.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btnKeyIn.ForeColor = System.Drawing.Color.Black
        Me.btnKeyIn.Location = New System.Drawing.Point(504, 54)
        Me.btnKeyIn.Name = "btnKeyIn"
        Me.btnKeyIn.Size = New System.Drawing.Size(128, 34)
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
        Me.btnBarcodeReader.Location = New System.Drawing.Point(504, 6)
        Me.btnBarcodeReader.Name = "btnBarcodeReader"
        Me.btnBarcodeReader.Size = New System.Drawing.Size(128, 34)
        Me.btnBarcodeReader.TabIndex = 9
        Me.btnBarcodeReader.Text = "刷入條碼"
        Me.btnBarcodeReader.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBarcodeReader.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'lblLotIDCount
        '
        Me.lblLotIDCount.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblLotIDCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLotIDCount.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLotIDCount.ForeColor = System.Drawing.Color.Black
        Me.lblLotIDCount.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLotIDCount.Location = New System.Drawing.Point(123, 114)
        Me.lblLotIDCount.Name = "lblLotIDCount"
        Me.lblLotIDCount.Size = New System.Drawing.Size(105, 36)
        Me.lblLotIDCount.TabIndex = 681
        Me.lblLotIDCount.Text = "01"
        Me.lblLotIDCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEQIDText
        '
        Me.lblEQIDText.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lblEQIDText.Location = New System.Drawing.Point(2, 6)
        Me.lblEQIDText.Name = "lblEQIDText"
        Me.lblEQIDText.Size = New System.Drawing.Size(115, 34)
        Me.lblEQIDText.TabIndex = 685
        Me.lblEQIDText.Text = "機台編號::"
        Me.lblEQIDText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEQID
        '
        Me.lblEQID.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblEQID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEQID.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lblEQID.ForeColor = System.Drawing.Color.Black
        Me.lblEQID.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblEQID.Location = New System.Drawing.Point(123, 6)
        Me.lblEQID.Name = "lblEQID"
        Me.lblEQID.Size = New System.Drawing.Size(364, 32)
        Me.lblEQID.TabIndex = 686
        Me.lblEQID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtLotID
        '
        Me.txtLotID.Font = New System.Drawing.Font("Arial", 16.0!)
        Me.txtLotID.Location = New System.Drawing.Point(123, 79)
        Me.txtLotID.Name = "txtLotID"
        Me.txtLotID.Size = New System.Drawing.Size(364, 32)
        Me.txtLotID.TabIndex = 687
        '
        'lblLotIDText
        '
        Me.lblLotIDText.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lblLotIDText.Location = New System.Drawing.Point(2, 77)
        Me.lblLotIDText.Name = "lblLotIDText"
        Me.lblLotIDText.Size = New System.Drawing.Size(115, 34)
        Me.lblLotIDText.TabIndex = 688
        Me.lblLotIDText.Text = "批號:"
        Me.lblLotIDText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lstLotID
        '
        Me.lstLotID.ColumnWidth = 240
        Me.lstLotID.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lstLotID.FormattingEnabled = True
        Me.lstLotID.HorizontalScrollbar = True
        Me.lstLotID.ItemHeight = 18
        Me.lstLotID.Items.AddRange(New Object() {"1234567801234567890", "1234567801234567890", "1234567801234567890", "1234567801234567890", "1234567801234567890", "1234567801234567890", "1234567801234567890", "1234567801234567890", "1234567801234567890", "1234567801234567890", "1234567801234567890", "1234567801234567890", "1234567801234567890", "1234567801234567890", "1234567801234567890", "1234567801234567890", "1234567801234567890", "1234567801234567890", "1234567801234567890", "1234567801234567890", "1234567801234567890", "1234567801234567890", "1234567801234567890", "1234567801234567890", "1234567801234567890", "1234567801234567890", "1234567801234567890", "1234567801234567890"})
        Me.lstLotID.Location = New System.Drawing.Point(5, 153)
        Me.lstLotID.MultiColumn = True
        Me.lstLotID.Name = "lstLotID"
        Me.lstLotID.ScrollAlwaysVisible = True
        Me.lstLotID.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstLotID.Size = New System.Drawing.Size(482, 310)
        Me.lstLotID.TabIndex = 689
        '
        'lblLotIDListText
        '
        Me.lblLotIDListText.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lblLotIDListText.Location = New System.Drawing.Point(2, 117)
        Me.lblLotIDListText.Name = "lblLotIDListText"
        Me.lblLotIDListText.Size = New System.Drawing.Size(115, 34)
        Me.lblLotIDListText.TabIndex = 690
        Me.lblLotIDListText.Text = "批號清單:"
        Me.lblLotIDListText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblOPIDText
        '
        Me.lblOPIDText.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lblOPIDText.Location = New System.Drawing.Point(2, 39)
        Me.lblOPIDText.Name = "lblOPIDText"
        Me.lblOPIDText.Size = New System.Drawing.Size(115, 34)
        Me.lblOPIDText.TabIndex = 692
        Me.lblOPIDText.Text = "工號:"
        Me.lblOPIDText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOPID
        '
        Me.txtOPID.Font = New System.Drawing.Font("Arial", 16.0!)
        Me.txtOPID.Location = New System.Drawing.Point(123, 41)
        Me.txtOPID.Name = "txtOPID"
        Me.txtOPID.Size = New System.Drawing.Size(364, 32)
        Me.txtOPID.TabIndex = 691
        '
        'FormSanAnBarcodeInput
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(638, 474)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblOPIDText)
        Me.Controls.Add(Me.txtOPID)
        Me.Controls.Add(Me.lblLotIDListText)
        Me.Controls.Add(Me.lstLotID)
        Me.Controls.Add(Me.lblLotIDText)
        Me.Controls.Add(Me.txtLotID)
        Me.Controls.Add(Me.lblEQID)
        Me.Controls.Add(Me.lblEQIDText)
        Me.Controls.Add(Me.lblLotIDCount)
        Me.Controls.Add(Me.btnRunProcess)
        Me.Controls.Add(Me.btnClearData)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnKeyIn)
        Me.Controls.Add(Me.btnBarcodeReader)
        Me.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormSanAnBarcodeInput"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "請刷入條碼"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnKeyIn As System.Windows.Forms.Button
    Friend WithEvents btnBarcodeReader As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClearData As System.Windows.Forms.Button
    Friend WithEvents btnRunProcess As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblLotIDCount As System.Windows.Forms.Label
    Friend WithEvents lblEQIDText As System.Windows.Forms.Label
    Friend WithEvents lblEQID As System.Windows.Forms.Label
    Friend WithEvents txtLotID As System.Windows.Forms.TextBox
    Friend WithEvents lblLotIDText As System.Windows.Forms.Label
    Friend WithEvents lstLotID As System.Windows.Forms.ListBox
    Friend WithEvents lblLotIDListText As System.Windows.Forms.Label
    Friend WithEvents lblOPIDText As System.Windows.Forms.Label
    Friend WithEvents txtOPID As System.Windows.Forms.TextBox
End Class

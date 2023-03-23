<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSanAnBarcodeInputConfirm
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnRunProcess = New System.Windows.Forms.Button()
        Me.lblWaferCount = New System.Windows.Forms.Label()
        Me.lblEQIDText = New System.Windows.Forms.Label()
        Me.lblEQID = New System.Windows.Forms.Label()
        Me.txtLotID = New System.Windows.Forms.TextBox()
        Me.lblLotIDText = New System.Windows.Forms.Label()
        Me.lstWaferID = New System.Windows.Forms.ListBox()
        Me.lblWaferDListText = New System.Windows.Forms.Label()
        Me.lblOPIDText = New System.Windows.Forms.Label()
        Me.lblOPID = New System.Windows.Forms.Label()
        Me.lblRunID = New System.Windows.Forms.Label()
        Me.lblRunIDText = New System.Windows.Forms.Label()
        Me.lblRecipeName = New System.Windows.Forms.Label()
        Me.lblRecipeNameText = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancel.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(450, 169)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(122, 55)
        Me.btnCancel.TabIndex = 673
        Me.btnCancel.Text = "取消"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnRunProcess
        '
        Me.btnRunProcess.BackColor = System.Drawing.Color.SkyBlue
        Me.btnRunProcess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRunProcess.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btnRunProcess.Location = New System.Drawing.Point(450, 6)
        Me.btnRunProcess.Name = "btnRunProcess"
        Me.btnRunProcess.Size = New System.Drawing.Size(122, 68)
        Me.btnRunProcess.TabIndex = 8
        Me.btnRunProcess.Text = "執行製程"
        Me.btnRunProcess.UseVisualStyleBackColor = False
        '
        'lblWaferCount
        '
        Me.lblWaferCount.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblWaferCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWaferCount.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWaferCount.ForeColor = System.Drawing.Color.Black
        Me.lblWaferCount.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblWaferCount.Location = New System.Drawing.Point(123, 188)
        Me.lblWaferCount.Name = "lblWaferCount"
        Me.lblWaferCount.Size = New System.Drawing.Size(105, 36)
        Me.lblWaferCount.TabIndex = 681
        Me.lblWaferCount.Text = "01"
        Me.lblWaferCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.lblEQID.Size = New System.Drawing.Size(321, 32)
        Me.lblEQID.TabIndex = 686
        Me.lblEQID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtLotID
        '
        Me.txtLotID.Font = New System.Drawing.Font("Arial", 16.0!)
        Me.txtLotID.Location = New System.Drawing.Point(133, 260)
        Me.txtLotID.Name = "txtLotID"
        Me.txtLotID.Size = New System.Drawing.Size(321, 32)
        Me.txtLotID.TabIndex = 687
        Me.txtLotID.Visible = False
        '
        'lblLotIDText
        '
        Me.lblLotIDText.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lblLotIDText.Location = New System.Drawing.Point(12, 258)
        Me.lblLotIDText.Name = "lblLotIDText"
        Me.lblLotIDText.Size = New System.Drawing.Size(115, 34)
        Me.lblLotIDText.TabIndex = 688
        Me.lblLotIDText.Text = "批號:"
        Me.lblLotIDText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblLotIDText.Visible = False
        '
        'lstWaferID
        '
        Me.lstWaferID.ColumnWidth = 240
        Me.lstWaferID.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lstWaferID.FormattingEnabled = True
        Me.lstWaferID.HorizontalExtent = 1
        Me.lstWaferID.HorizontalScrollbar = True
        Me.lstWaferID.IntegralHeight = False
        Me.lstWaferID.ItemHeight = 18
        Me.lstWaferID.Location = New System.Drawing.Point(5, 227)
        Me.lstWaferID.MultiColumn = True
        Me.lstWaferID.Name = "lstWaferID"
        Me.lstWaferID.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstWaferID.Size = New System.Drawing.Size(567, 243)
        Me.lstWaferID.TabIndex = 689
        '
        'lblWaferDListText
        '
        Me.lblWaferDListText.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lblWaferDListText.Location = New System.Drawing.Point(2, 187)
        Me.lblWaferDListText.Name = "lblWaferDListText"
        Me.lblWaferDListText.Size = New System.Drawing.Size(115, 34)
        Me.lblWaferDListText.TabIndex = 690
        Me.lblWaferDListText.Text = "晶片清單:"
        Me.lblWaferDListText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'lblOPID
        '
        Me.lblOPID.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblOPID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOPID.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lblOPID.ForeColor = System.Drawing.Color.Black
        Me.lblOPID.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblOPID.Location = New System.Drawing.Point(123, 41)
        Me.lblOPID.Name = "lblOPID"
        Me.lblOPID.Size = New System.Drawing.Size(321, 32)
        Me.lblOPID.TabIndex = 693
        Me.lblOPID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRunID
        '
        Me.lblRunID.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblRunID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRunID.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lblRunID.ForeColor = System.Drawing.Color.Black
        Me.lblRunID.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRunID.Location = New System.Drawing.Point(123, 76)
        Me.lblRunID.Name = "lblRunID"
        Me.lblRunID.Size = New System.Drawing.Size(449, 74)
        Me.lblRunID.TabIndex = 695
        Me.lblRunID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRunIDText
        '
        Me.lblRunIDText.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lblRunIDText.Location = New System.Drawing.Point(2, 74)
        Me.lblRunIDText.Name = "lblRunIDText"
        Me.lblRunIDText.Size = New System.Drawing.Size(115, 34)
        Me.lblRunIDText.TabIndex = 694
        Me.lblRunIDText.Text = "Run ID:"
        Me.lblRunIDText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRecipeName
        '
        Me.lblRecipeName.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblRecipeName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRecipeName.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lblRecipeName.ForeColor = System.Drawing.Color.Black
        Me.lblRecipeName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRecipeName.Location = New System.Drawing.Point(123, 153)
        Me.lblRecipeName.Name = "lblRecipeName"
        Me.lblRecipeName.Size = New System.Drawing.Size(321, 32)
        Me.lblRecipeName.TabIndex = 697
        Me.lblRecipeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRecipeNameText
        '
        Me.lblRecipeNameText.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lblRecipeNameText.Location = New System.Drawing.Point(2, 151)
        Me.lblRecipeNameText.Name = "lblRecipeNameText"
        Me.lblRecipeNameText.Size = New System.Drawing.Size(115, 34)
        Me.lblRecipeNameText.TabIndex = 696
        Me.lblRecipeNameText.Text = "配方名稱:"
        Me.lblRecipeNameText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FormSanAnBarcodeInputConfirm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(576, 472)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblRecipeName)
        Me.Controls.Add(Me.lblRecipeNameText)
        Me.Controls.Add(Me.lblRunID)
        Me.Controls.Add(Me.lblRunIDText)
        Me.Controls.Add(Me.lblOPID)
        Me.Controls.Add(Me.lblOPIDText)
        Me.Controls.Add(Me.lblWaferDListText)
        Me.Controls.Add(Me.lstWaferID)
        Me.Controls.Add(Me.lblLotIDText)
        Me.Controls.Add(Me.txtLotID)
        Me.Controls.Add(Me.lblEQID)
        Me.Controls.Add(Me.lblEQIDText)
        Me.Controls.Add(Me.lblWaferCount)
        Me.Controls.Add(Me.btnRunProcess)
        Me.Controls.Add(Me.btnCancel)
        Me.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormSanAnBarcodeInputConfirm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "請刷入條碼"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnRunProcess As System.Windows.Forms.Button
    Friend WithEvents lblWaferCount As System.Windows.Forms.Label
    Friend WithEvents lblEQIDText As System.Windows.Forms.Label
    Friend WithEvents lblEQID As System.Windows.Forms.Label
    Friend WithEvents txtLotID As System.Windows.Forms.TextBox
    Friend WithEvents lblLotIDText As System.Windows.Forms.Label
    Friend WithEvents lstWaferID As System.Windows.Forms.ListBox
    Friend WithEvents lblWaferDListText As System.Windows.Forms.Label
    Friend WithEvents lblOPIDText As System.Windows.Forms.Label
    Friend WithEvents lblOPID As System.Windows.Forms.Label
    Friend WithEvents lblRunID As System.Windows.Forms.Label
    Friend WithEvents lblRunIDText As System.Windows.Forms.Label
    Friend WithEvents lblRecipeName As System.Windows.Forms.Label
    Friend WithEvents lblRecipeNameText As System.Windows.Forms.Label
End Class

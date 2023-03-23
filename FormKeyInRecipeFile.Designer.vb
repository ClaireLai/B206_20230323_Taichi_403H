<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKeyInRecipeFile
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
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnEnter = New System.Windows.Forms.Button
        Me.txtRecipeFileName = New System.Windows.Forms.TextBox
        Me.lblRecipeFileNameText = New System.Windows.Forms.Label
        Me.btnSameRecipeFile = New System.Windows.Forms.Button
        Me.picCelloLogo = New System.Windows.Forms.PictureBox
        CType(Me.picCelloLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(289, 147)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(118, 49)
        Me.btnExit.TabIndex = 211
        Me.btnExit.Text = "離開"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnEnter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnter.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.Location = New System.Drawing.Point(52, 147)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(118, 49)
        Me.btnEnter.TabIndex = 210
        Me.btnEnter.Text = "輸入"
        Me.btnEnter.UseVisualStyleBackColor = False
        '
        'txtRecipeFileName
        '
        Me.txtRecipeFileName.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtRecipeFileName.Location = New System.Drawing.Point(16, 109)
        Me.txtRecipeFileName.Name = "txtRecipeFileName"
        Me.txtRecipeFileName.Size = New System.Drawing.Size(417, 30)
        Me.txtRecipeFileName.TabIndex = 209
        '
        'lblRecipeFileNameText
        '
        Me.lblRecipeFileNameText.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecipeFileNameText.ForeColor = System.Drawing.Color.Black
        Me.lblRecipeFileNameText.Location = New System.Drawing.Point(12, 74)
        Me.lblRecipeFileNameText.Name = "lblRecipeFileNameText"
        Me.lblRecipeFileNameText.Size = New System.Drawing.Size(421, 32)
        Me.lblRecipeFileNameText.TabIndex = 208
        Me.lblRecipeFileNameText.Text = "請輸入配方檔名:"
        '
        'btnSameRecipeFile
        '
        Me.btnSameRecipeFile.BackColor = System.Drawing.SystemColors.Control
        Me.btnSameRecipeFile.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnSameRecipeFile.Location = New System.Drawing.Point(291, 12)
        Me.btnSameRecipeFile.Name = "btnSameRecipeFile"
        Me.btnSameRecipeFile.Size = New System.Drawing.Size(116, 38)
        Me.btnSameRecipeFile.TabIndex = 213
        Me.btnSameRecipeFile.Text = "原檔名存檔"
        Me.btnSameRecipeFile.UseVisualStyleBackColor = False
        '
        'picCelloLogo
        '
        Me.picCelloLogo.Image = Global.CELLO.My.Resources.Resources.CELLOLOGO02
        Me.picCelloLogo.Location = New System.Drawing.Point(0, 2)
        Me.picCelloLogo.Name = "picCelloLogo"
        Me.picCelloLogo.Size = New System.Drawing.Size(72, 64)
        Me.picCelloLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCelloLogo.TabIndex = 525
        Me.picCelloLogo.TabStop = False
        '
        'FormKeyInRecipeFile
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(457, 208)
        Me.ControlBox = False
        Me.Controls.Add(Me.picCelloLogo)
        Me.Controls.Add(Me.btnSameRecipeFile)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.txtRecipeFileName)
        Me.Controls.Add(Me.lblRecipeFileNameText)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormKeyInRecipeFile"
        Me.Text = "Key In Recipe FileName"
        Me.TopMost = True
        CType(Me.picCelloLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents txtRecipeFileName As System.Windows.Forms.TextBox
    Friend WithEvents lblRecipeFileNameText As System.Windows.Forms.Label
    Friend WithEvents btnSameRecipeFile As System.Windows.Forms.Button
    Friend WithEvents picCelloLogo As System.Windows.Forms.PictureBox
End Class

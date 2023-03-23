<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRecipeSelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRecipeSelect))
        Me.lstRecipeFile = New System.Windows.Forms.ListBox()
        Me.btnChangeFolder = New System.Windows.Forms.Button()
        Me.lblChooseFileText = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblFileName = New System.Windows.Forms.Label()
        Me.SuspendLayout
        '
        'lstRecipeFile
        '
        Me.lstRecipeFile.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lstRecipeFile.FormattingEnabled = true
        Me.lstRecipeFile.ItemHeight = 24
        Me.lstRecipeFile.Location = New System.Drawing.Point(1, 104)
        Me.lstRecipeFile.Name = "lstRecipeFile"
        Me.lstRecipeFile.ScrollAlwaysVisible = true
        Me.lstRecipeFile.Size = New System.Drawing.Size(416, 388)
        Me.lstRecipeFile.TabIndex = 0
        '
        'btnChangeFolder
        '
        Me.btnChangeFolder.BackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.btnChangeFolder.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136,Byte))
        Me.btnChangeFolder.Location = New System.Drawing.Point(433, 110)
        Me.btnChangeFolder.Name = "btnChangeFolder"
        Me.btnChangeFolder.Size = New System.Drawing.Size(110, 40)
        Me.btnChangeFolder.TabIndex = 1
        Me.btnChangeFolder.Text = "選擇資料夾"
        Me.btnChangeFolder.UseVisualStyleBackColor = false
        '
        'lblChooseFileText
        '
        Me.lblChooseFileText.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136,Byte))
        Me.lblChooseFileText.Location = New System.Drawing.Point(5, 12)
        Me.lblChooseFileText.Name = "lblChooseFileText"
        Me.lblChooseFileText.Size = New System.Drawing.Size(244, 34)
        Me.lblChooseFileText.TabIndex = 2
        Me.lblChooseFileText.Text = "請選擇檔案:"
        Me.lblChooseFileText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.btnExit.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136,Byte))
        Me.btnExit.Location = New System.Drawing.Point(433, 268)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(110, 67)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "離開"
        Me.btnExit.UseVisualStyleBackColor = false
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.btnEnter.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136,Byte))
        Me.btnEnter.Location = New System.Drawing.Point(433, 428)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(110, 70)
        Me.btnEnter.TabIndex = 4
        Me.btnEnter.Text = "確定"
        Me.btnEnter.UseVisualStyleBackColor = false
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.btnRefresh.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136,Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(433, 357)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(110, 40)
        Me.btnRefresh.TabIndex = 4
        Me.btnRefresh.Text = "更新"
        Me.btnRefresh.UseVisualStyleBackColor = false
        Me.btnRefresh.Visible = false
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDelete.Font = New System.Drawing.Font("新細明體", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136,Byte))
        Me.btnDelete.Location = New System.Drawing.Point(433, 180)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(110, 53)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.Text = "刪除"
        Me.btnDelete.UseVisualStyleBackColor = false
        '
        'lblFileName
        '
        Me.lblFileName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFileName.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136,Byte))
        Me.lblFileName.Location = New System.Drawing.Point(2, 45)
        Me.lblFileName.Name = "lblFileName"
        Me.lblFileName.Size = New System.Drawing.Size(553, 51)
        Me.lblFileName.TabIndex = 7
        Me.lblFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FormRecipeSelect
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(555, 499)
        Me.ControlBox = false
        Me.Controls.Add(Me.lblFileName)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblChooseFileText)
        Me.Controls.Add(Me.btnChangeFolder)
        Me.Controls.Add(Me.lstRecipeFile)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "FormRecipeSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recipe Select"
        Me.TopMost = true
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents lstRecipeFile As System.Windows.Forms.ListBox
    Friend WithEvents btnChangeFolder As System.Windows.Forms.Button
    Friend WithEvents lblChooseFileText As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents lblFileName As System.Windows.Forms.Label
End Class

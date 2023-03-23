<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFileSelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormFileSelect))
        Me.lstFileName = New System.Windows.Forms.ListBox
        Me.btnChangeFolder = New System.Windows.Forms.Button
        Me.lblChooseFileText = New System.Windows.Forms.Label
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnEnter = New System.Windows.Forms.Button
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.richPreview = New System.Windows.Forms.RichTextBox
        Me.btnPreview = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lstFileName
        '
        Me.lstFileName.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstFileName.FormattingEnabled = True
        Me.lstFileName.ItemHeight = 24
        Me.lstFileName.Location = New System.Drawing.Point(1, 45)
        Me.lstFileName.Name = "lstFileName"
        Me.lstFileName.ScrollAlwaysVisible = True
        Me.lstFileName.Size = New System.Drawing.Size(313, 316)
        Me.lstFileName.TabIndex = 0
        '
        'btnChangeFolder
        '
        Me.btnChangeFolder.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnChangeFolder.Location = New System.Drawing.Point(320, 49)
        Me.btnChangeFolder.Name = "btnChangeFolder"
        Me.btnChangeFolder.Size = New System.Drawing.Size(110, 40)
        Me.btnChangeFolder.TabIndex = 1
        Me.btnChangeFolder.Text = "選擇資料夾"
        Me.btnChangeFolder.UseVisualStyleBackColor = True
        '
        'lblChooseFileText
        '
        Me.lblChooseFileText.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblChooseFileText.Location = New System.Drawing.Point(5, 8)
        Me.lblChooseFileText.Name = "lblChooseFileText"
        Me.lblChooseFileText.Size = New System.Drawing.Size(244, 34)
        Me.lblChooseFileText.TabIndex = 2
        Me.lblChooseFileText.Text = "請選擇檔案:"
        Me.lblChooseFileText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnExit.Location = New System.Drawing.Point(320, 124)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(110, 40)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "離開"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnEnter
        '
        Me.btnEnter.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnEnter.Location = New System.Drawing.Point(320, 314)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(110, 40)
        Me.btnEnter.TabIndex = 4
        Me.btnEnter.Text = "確定"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(320, 268)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(110, 40)
        Me.btnRefresh.TabIndex = 4
        Me.btnRefresh.Text = "更新"
        Me.btnRefresh.UseVisualStyleBackColor = True
        Me.btnRefresh.Visible = False
        '
        'richPreview
        '
        Me.richPreview.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.richPreview.ForeColor = System.Drawing.Color.Blue
        Me.richPreview.Location = New System.Drawing.Point(436, 45)
        Me.richPreview.Name = "richPreview"
        Me.richPreview.Size = New System.Drawing.Size(203, 309)
        Me.richPreview.TabIndex = 5
        Me.richPreview.Text = ""
        '
        'btnPreview
        '
        Me.btnPreview.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnPreview.Location = New System.Drawing.Point(320, 212)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(110, 40)
        Me.btnPreview.TabIndex = 6
        Me.btnPreview.Text = "預覽檔案"
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'FormFileSelect
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(430, 364)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.richPreview)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblChooseFileText)
        Me.Controls.Add(Me.btnChangeFolder)
        Me.Controls.Add(Me.lstFileName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormFileSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recipe Select"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstFileName As System.Windows.Forms.ListBox
    Friend WithEvents btnChangeFolder As System.Windows.Forms.Button
    Friend WithEvents lblChooseFileText As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents richPreview As System.Windows.Forms.RichTextBox
    Friend WithEvents btnPreview As System.Windows.Forms.Button
End Class

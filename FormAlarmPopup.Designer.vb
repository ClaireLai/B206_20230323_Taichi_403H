<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAlarmPopup
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
        Me.txtAlarmText = New System.Windows.Forms.TextBox
        Me.btnBzReset = New System.Windows.Forms.Button
        Me.btnAlarmReset = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtAlarmText
        '
        Me.txtAlarmText.BackColor = System.Drawing.Color.LightGray
        Me.txtAlarmText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAlarmText.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlarmText.ForeColor = System.Drawing.Color.Red
        Me.txtAlarmText.Location = New System.Drawing.Point(0, 0)
        Me.txtAlarmText.Margin = New System.Windows.Forms.Padding(0)
        Me.txtAlarmText.Multiline = True
        Me.txtAlarmText.Name = "txtAlarmText"
        Me.txtAlarmText.Size = New System.Drawing.Size(631, 231)
        Me.txtAlarmText.TabIndex = 209
        '
        'btnBzReset
        '
        Me.btnBzReset.BackColor = System.Drawing.Color.LightPink
        Me.btnBzReset.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular)
        Me.btnBzReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBzReset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnBzReset.Location = New System.Drawing.Point(634, 12)
        Me.btnBzReset.Name = "btnBzReset"
        Me.btnBzReset.Size = New System.Drawing.Size(121, 53)
        Me.btnBzReset.TabIndex = 210
        Me.btnBzReset.Text = "停止警報"
        Me.btnBzReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBzReset.UseVisualStyleBackColor = False
        '
        'btnAlarmReset
        '
        Me.btnAlarmReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAlarmReset.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular)
        Me.btnAlarmReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAlarmReset.Location = New System.Drawing.Point(634, 87)
        Me.btnAlarmReset.Name = "btnAlarmReset"
        Me.btnAlarmReset.Size = New System.Drawing.Size(121, 53)
        Me.btnAlarmReset.TabIndex = 211
        Me.btnAlarmReset.Text = "清除異常訊息"
        Me.btnAlarmReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAlarmReset.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.PowderBlue
        Me.btnClose.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClose.Location = New System.Drawing.Point(634, 169)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(121, 53)
        Me.btnClose.TabIndex = 212
        Me.btnClose.Text = "關閉"
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'FormAlarmPopup
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(755, 231)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAlarmReset)
        Me.Controls.Add(Me.btnBzReset)
        Me.Controls.Add(Me.txtAlarmText)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FormAlarmPopup"
        Me.Opacity = 0.8
        Me.Text = "Popup Alarm"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtAlarmText As System.Windows.Forms.TextBox
    Friend WithEvents btnBzReset As System.Windows.Forms.Button
    Friend WithEvents btnAlarmReset As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class

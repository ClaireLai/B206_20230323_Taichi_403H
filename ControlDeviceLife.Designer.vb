<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlDeviceLife
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
        Me.lblLifeTime = New System.Windows.Forms.Label
        Me.btnReset = New System.Windows.Forms.Button
        Me.lblDeviceName = New System.Windows.Forms.Label
        Me.txtLifeTimeSet = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'lblLifeTime
        '
        Me.lblLifeTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblLifeTime.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLifeTime.ForeColor = System.Drawing.Color.Blue
        Me.lblLifeTime.Location = New System.Drawing.Point(182, 5)
        Me.lblLifeTime.Name = "lblLifeTime"
        Me.lblLifeTime.Size = New System.Drawing.Size(97, 32)
        Me.lblLifeTime.TabIndex = 291
        Me.lblLifeTime.Text = "0000:00:00"
        Me.lblLifeTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblLifeTime.Visible = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(363, 4)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(70, 32)
        Me.btnReset.TabIndex = 293
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        Me.btnReset.Visible = False
        '
        'lblDeviceName
        '
        Me.lblDeviceName.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.lblDeviceName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeviceName.ForeColor = System.Drawing.Color.Black
        Me.lblDeviceName.Location = New System.Drawing.Point(4, 4)
        Me.lblDeviceName.Name = "lblDeviceName"
        Me.lblDeviceName.Size = New System.Drawing.Size(172, 32)
        Me.lblDeviceName.TabIndex = 290
        Me.lblDeviceName.Text = "Machine Pump:"
        Me.lblDeviceName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblDeviceName.Visible = False
        '
        'txtLifeTimeSet
        '
        Me.txtLifeTimeSet.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtLifeTimeSet.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLifeTimeSet.Location = New System.Drawing.Point(285, 5)
        Me.txtLifeTimeSet.Name = "txtLifeTimeSet"
        Me.txtLifeTimeSet.Size = New System.Drawing.Size(72, 32)
        Me.txtLifeTimeSet.TabIndex = 292
        Me.txtLifeTimeSet.Text = "00000"
        Me.txtLifeTimeSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtLifeTimeSet.Visible = False
        '
        'ControlDeviceLife
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.lblLifeTime)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lblDeviceName)
        Me.Controls.Add(Me.txtLifeTimeSet)
        Me.Name = "ControlDeviceLife"
        Me.Size = New System.Drawing.Size(440, 40)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblLifeTime As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents lblDeviceName As System.Windows.Forms.Label
    Friend WithEvents txtLifeTimeSet As System.Windows.Forms.TextBox

End Class

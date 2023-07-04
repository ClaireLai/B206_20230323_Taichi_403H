<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlPressPID
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
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PID = New System.Windows.Forms.GroupBox()
        Me.txtInterval = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtAdjustDA = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtOverPress = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtI2 = New System.Windows.Forms.TextBox()
        Me.txtP2 = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBrake = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtI1 = New System.Windows.Forms.TextBox()
        Me.txtP1 = New System.Windows.Forms.TextBox()
        Me.PID.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'PID
        '
        Me.PID.Controls.Add(Me.txtInterval)
        Me.PID.Controls.Add(Me.Label17)
        Me.PID.Controls.Add(Me.GroupBox5)
        Me.PID.Controls.Add(Me.GroupBox4)
        Me.PID.Controls.Add(Me.GroupBox6)
        Me.PID.Location = New System.Drawing.Point(2, 2)
        Me.PID.Margin = New System.Windows.Forms.Padding(0)
        Me.PID.Name = "PID"
        Me.PID.Padding = New System.Windows.Forms.Padding(0)
        Me.PID.Size = New System.Drawing.Size(235, 181)
        Me.PID.TabIndex = 952
        Me.PID.TabStop = False
        Me.PID.Text = "PID"
        '
        'txtInterval
        '
        Me.txtInterval.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInterval.Location = New System.Drawing.Point(173, 151)
        Me.txtInterval.Name = "txtInterval"
        Me.txtInterval.Size = New System.Drawing.Size(34, 26)
        Me.txtInterval.TabIndex = 661
        Me.txtInterval.Text = "5"
        Me.txtInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(154, 110)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(69, 47)
        Me.Label17.TabIndex = 660
        Me.Label17.Text = "控壓時間間隔(0.1s)"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.txtAdjustDA)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.txtOverPress)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(7, 112)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(141, 66)
        Me.GroupBox5.TabIndex = 659
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "手動調整"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(106, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 28)
        Me.Label9.TabIndex = 662
        Me.Label9.Text = "DA"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAdjustDA
        '
        Me.txtAdjustDA.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdjustDA.Location = New System.Drawing.Point(70, 44)
        Me.txtAdjustDA.Name = "txtAdjustDA"
        Me.txtAdjustDA.Size = New System.Drawing.Size(36, 21)
        Me.txtAdjustDA.TabIndex = 661
        Me.txtAdjustDA.Text = "2"
        Me.txtAdjustDA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(9, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 28)
        Me.Label10.TabIndex = 660
        Me.Label10.Text = "加減DA值"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(106, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(22, 23)
        Me.Label8.TabIndex = 659
        Me.Label8.Text = "KG"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOverPress
        '
        Me.txtOverPress.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOverPress.Location = New System.Drawing.Point(70, 20)
        Me.txtOverPress.Name = "txtOverPress"
        Me.txtOverPress.Size = New System.Drawing.Size(36, 21)
        Me.txtOverPress.TabIndex = 658
        Me.txtOverPress.Text = "3"
        Me.txtOverPress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(11, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 28)
        Me.Label3.TabIndex = 657
        Me.Label3.Text = "跳動大於"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.txtI2)
        Me.GroupBox4.Controls.Add(Me.txtP2)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(125, 11)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(104, 98)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "穩壓段"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(-3, 64)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(36, 28)
        Me.Label15.TabIndex = 648
        Me.Label15.Text = "I2"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(1, 36)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(36, 28)
        Me.Label16.TabIndex = 647
        Me.Label16.Text = "P2"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtI2
        '
        Me.txtI2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtI2.Location = New System.Drawing.Point(43, 67)
        Me.txtI2.Name = "txtI2"
        Me.txtI2.Size = New System.Drawing.Size(55, 26)
        Me.txtI2.TabIndex = 645
        Me.txtI2.Text = "5"
        Me.txtI2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtP2
        '
        Me.txtP2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtP2.Location = New System.Drawing.Point(43, 39)
        Me.txtP2.Name = "txtP2"
        Me.txtP2.Size = New System.Drawing.Size(55, 26)
        Me.txtP2.TabIndex = 644
        Me.txtP2.Text = "10"
        Me.txtP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Controls.Add(Me.txtBrake)
        Me.GroupBox6.Controls.Add(Me.Label1)
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Controls.Add(Me.txtI1)
        Me.GroupBox6.Controls.Add(Me.txtP1)
        Me.GroupBox6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(7, 11)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(114, 100)
        Me.GroupBox6.TabIndex = 0
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "升降壓段"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(89, 20)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 15)
        Me.Label5.TabIndex = 957
        Me.Label5.Text = "Sec"
        '
        'txtBrake
        '
        Me.txtBrake.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBrake.Location = New System.Drawing.Point(55, 16)
        Me.txtBrake.Name = "txtBrake"
        Me.txtBrake.Size = New System.Drawing.Size(33, 26)
        Me.txtBrake.TabIndex = 956
        Me.txtBrake.Text = "2"
        Me.txtBrake.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(-2, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 22)
        Me.Label1.TabIndex = 955
        Me.Label1.Text = "剎車時間"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(10, 68)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(36, 28)
        Me.Label12.TabIndex = 645
        Me.Label12.Text = "I1"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(12, 40)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(36, 28)
        Me.Label13.TabIndex = 644
        Me.Label13.Text = "P1"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtI1
        '
        Me.txtI1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtI1.Location = New System.Drawing.Point(53, 70)
        Me.txtI1.Name = "txtI1"
        Me.txtI1.Size = New System.Drawing.Size(56, 26)
        Me.txtI1.TabIndex = 642
        Me.txtI1.Text = "10"
        Me.txtI1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtP1
        '
        Me.txtP1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtP1.Location = New System.Drawing.Point(54, 43)
        Me.txtP1.Name = "txtP1"
        Me.txtP1.Size = New System.Drawing.Size(55, 26)
        Me.txtP1.TabIndex = 641
        Me.txtP1.Text = "20"
        Me.txtP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ControlPressPID
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.PID)
        Me.Name = "ControlPressPID"
        Me.Size = New System.Drawing.Size(241, 235)
        Me.PID.ResumeLayout(False)
        Me.PID.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PID As GroupBox
    Friend WithEvents txtInterval As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtAdjustDA As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtOverPress As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtI2 As TextBox
    Friend WithEvents txtP2 As TextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtI1 As TextBox
    Friend WithEvents txtP1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBrake As TextBox
    Friend WithEvents Label5 As Label
End Class

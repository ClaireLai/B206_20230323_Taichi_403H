<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTempCal
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
        Me.components = New System.ComponentModel.Container
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnExit = New System.Windows.Forms.Button
        Me.tabProcessInfo = New System.Windows.Forms.TabControl
        Me.tabPageProcessData1 = New System.Windows.Forms.TabPage
        Me.flwProcess1 = New System.Windows.Forms.FlowLayoutPanel
        Me.tabProcessInfo.SuspendLayout()
        Me.tabPageProcessData1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Lavender
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(639, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(127, 41)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "離開"
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'tabProcessInfo
        '
        Me.tabProcessInfo.Controls.Add(Me.tabPageProcessData1)
        Me.tabProcessInfo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabProcessInfo.HotTrack = True
        Me.tabProcessInfo.ItemSize = New System.Drawing.Size(160, 40)
        Me.tabProcessInfo.Location = New System.Drawing.Point(0, 0)
        Me.tabProcessInfo.Margin = New System.Windows.Forms.Padding(0)
        Me.tabProcessInfo.Multiline = True
        Me.tabProcessInfo.Name = "tabProcessInfo"
        Me.tabProcessInfo.Padding = New System.Drawing.Point(0, 0)
        Me.tabProcessInfo.SelectedIndex = 0
        Me.tabProcessInfo.Size = New System.Drawing.Size(767, 740)
        Me.tabProcessInfo.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tabProcessInfo.TabIndex = 179
        '
        'tabPageProcessData1
        '
        Me.tabPageProcessData1.BackColor = System.Drawing.Color.Transparent
        Me.tabPageProcessData1.Controls.Add(Me.flwProcess1)
        Me.tabPageProcessData1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabPageProcessData1.Location = New System.Drawing.Point(4, 44)
        Me.tabPageProcessData1.Name = "tabPageProcessData1"
        Me.tabPageProcessData1.Size = New System.Drawing.Size(759, 692)
        Me.tabPageProcessData1.TabIndex = 0
        Me.tabPageProcessData1.Text = "製程資料1"
        Me.tabPageProcessData1.UseVisualStyleBackColor = True
        '
        'flwProcess1
        '
        Me.flwProcess1.BackColor = System.Drawing.SystemColors.Control
        Me.flwProcess1.Location = New System.Drawing.Point(0, 0)
        Me.flwProcess1.Margin = New System.Windows.Forms.Padding(0)
        Me.flwProcess1.Name = "flwProcess1"
        Me.flwProcess1.Size = New System.Drawing.Size(756, 692)
        Me.flwProcess1.TabIndex = 0
        '
        'FormTempCal
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(770, 740)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.tabProcessInfo)
        Me.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormTempCal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Temp Calibration"
        Me.TopMost = True
        Me.tabProcessInfo.ResumeLayout(False)
        Me.tabPageProcessData1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents tabProcessInfo As System.Windows.Forms.TabControl
    Friend WithEvents tabPageProcessData1 As System.Windows.Forms.TabPage
    Friend WithEvents flwProcess1 As System.Windows.Forms.FlowLayoutPanel
End Class

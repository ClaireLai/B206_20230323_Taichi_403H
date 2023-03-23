<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlFlowSet
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
        Me.components = New System.ComponentModel.Container
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.grpFlowTitle = New System.Windows.Forms.GroupBox
        Me.lblBotFlow = New System.Windows.Forms.Label
        Me.lblTopFlow = New System.Windows.Forms.Label
        Me.lblTopFlowMeterText = New System.Windows.Forms.Label
        Me.txtTopFlowMeter = New System.Windows.Forms.TextBox
        Me.lblBotFlowMeterText = New System.Windows.Forms.Label
        Me.lblFlowUnit01Text = New System.Windows.Forms.Label
        Me.lblPulseL01Text = New System.Windows.Forms.Label
        Me.txtBotFlowMeter = New System.Windows.Forms.TextBox
        Me.grpFlowTitle.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'grpFlowTitle
        '
        Me.grpFlowTitle.Controls.Add(Me.lblBotFlow)
        Me.grpFlowTitle.Controls.Add(Me.lblTopFlow)
        Me.grpFlowTitle.Controls.Add(Me.lblTopFlowMeterText)
        Me.grpFlowTitle.Controls.Add(Me.txtTopFlowMeter)
        Me.grpFlowTitle.Controls.Add(Me.lblBotFlowMeterText)
        Me.grpFlowTitle.Controls.Add(Me.lblFlowUnit01Text)
        Me.grpFlowTitle.Controls.Add(Me.lblPulseL01Text)
        Me.grpFlowTitle.Controls.Add(Me.txtBotFlowMeter)
        Me.grpFlowTitle.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFlowTitle.ForeColor = System.Drawing.Color.Black
        Me.grpFlowTitle.Location = New System.Drawing.Point(4, 4)
        Me.grpFlowTitle.Margin = New System.Windows.Forms.Padding(4)
        Me.grpFlowTitle.Name = "grpFlowTitle"
        Me.grpFlowTitle.Padding = New System.Windows.Forms.Padding(4)
        Me.grpFlowTitle.Size = New System.Drawing.Size(211, 112)
        Me.grpFlowTitle.TabIndex = 537
        Me.grpFlowTitle.TabStop = False
        Me.grpFlowTitle.Text = "壓頭水流量設定"
        '
        'lblBotFlow
        '
        Me.lblBotFlow.BackColor = System.Drawing.Color.Black
        Me.lblBotFlow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBotFlow.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBotFlow.ForeColor = System.Drawing.Color.Lime
        Me.lblBotFlow.Location = New System.Drawing.Point(81, 76)
        Me.lblBotFlow.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBotFlow.Name = "lblBotFlow"
        Me.lblBotFlow.Size = New System.Drawing.Size(65, 26)
        Me.lblBotFlow.TabIndex = 528
        Me.lblBotFlow.Text = "0"
        Me.lblBotFlow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTopFlow
        '
        Me.lblTopFlow.BackColor = System.Drawing.Color.Black
        Me.lblTopFlow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTopFlow.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopFlow.ForeColor = System.Drawing.Color.Lime
        Me.lblTopFlow.Location = New System.Drawing.Point(8, 76)
        Me.lblTopFlow.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTopFlow.Name = "lblTopFlow"
        Me.lblTopFlow.Size = New System.Drawing.Size(65, 26)
        Me.lblTopFlow.TabIndex = 528
        Me.lblTopFlow.Text = "0"
        Me.lblTopFlow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTopFlowMeterText
        '
        Me.lblTopFlowMeterText.BackColor = System.Drawing.Color.Transparent
        Me.lblTopFlowMeterText.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopFlowMeterText.ForeColor = System.Drawing.Color.Black
        Me.lblTopFlowMeterText.Location = New System.Drawing.Point(8, 22)
        Me.lblTopFlowMeterText.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTopFlowMeterText.Name = "lblTopFlowMeterText"
        Me.lblTopFlowMeterText.Size = New System.Drawing.Size(65, 21)
        Me.lblTopFlowMeterText.TabIndex = 528
        Me.lblTopFlowMeterText.Text = "上設定:"
        Me.lblTopFlowMeterText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTopFlowMeter
        '
        Me.txtTopFlowMeter.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTopFlowMeter.Location = New System.Drawing.Point(8, 46)
        Me.txtTopFlowMeter.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTopFlowMeter.Name = "txtTopFlowMeter"
        Me.txtTopFlowMeter.Size = New System.Drawing.Size(65, 26)
        Me.txtTopFlowMeter.TabIndex = 536
        Me.txtTopFlowMeter.Text = "200"
        Me.txtTopFlowMeter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblBotFlowMeterText
        '
        Me.lblBotFlowMeterText.BackColor = System.Drawing.Color.Transparent
        Me.lblBotFlowMeterText.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBotFlowMeterText.ForeColor = System.Drawing.Color.Black
        Me.lblBotFlowMeterText.Location = New System.Drawing.Point(81, 22)
        Me.lblBotFlowMeterText.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBotFlowMeterText.Name = "lblBotFlowMeterText"
        Me.lblBotFlowMeterText.Size = New System.Drawing.Size(65, 21)
        Me.lblBotFlowMeterText.TabIndex = 537
        Me.lblBotFlowMeterText.Text = "下設定:"
        Me.lblBotFlowMeterText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFlowUnit01Text
        '
        Me.lblFlowUnit01Text.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFlowUnit01Text.ForeColor = System.Drawing.Color.Black
        Me.lblFlowUnit01Text.Location = New System.Drawing.Point(154, 78)
        Me.lblFlowUnit01Text.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFlowUnit01Text.Name = "lblFlowUnit01Text"
        Me.lblFlowUnit01Text.Size = New System.Drawing.Size(51, 24)
        Me.lblFlowUnit01Text.TabIndex = 528
        Me.lblFlowUnit01Text.Text = "L/Min"
        Me.lblFlowUnit01Text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPulseL01Text
        '
        Me.lblPulseL01Text.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPulseL01Text.ForeColor = System.Drawing.Color.Black
        Me.lblPulseL01Text.Location = New System.Drawing.Point(154, 48)
        Me.lblPulseL01Text.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPulseL01Text.Name = "lblPulseL01Text"
        Me.lblPulseL01Text.Size = New System.Drawing.Size(51, 24)
        Me.lblPulseL01Text.TabIndex = 528
        Me.lblPulseL01Text.Text = "Pulse/L"
        Me.lblPulseL01Text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBotFlowMeter
        '
        Me.txtBotFlowMeter.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBotFlowMeter.Location = New System.Drawing.Point(81, 47)
        Me.txtBotFlowMeter.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBotFlowMeter.Name = "txtBotFlowMeter"
        Me.txtBotFlowMeter.Size = New System.Drawing.Size(65, 26)
        Me.txtBotFlowMeter.TabIndex = 539
        Me.txtBotFlowMeter.Text = "200"
        Me.txtBotFlowMeter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ControlFlowSet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grpFlowTitle)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ControlFlowSet"
        Me.Size = New System.Drawing.Size(219, 119)
        Me.grpFlowTitle.ResumeLayout(False)
        Me.grpFlowTitle.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents grpFlowTitle As System.Windows.Forms.GroupBox
    Friend WithEvents lblBotFlow As System.Windows.Forms.Label
    Friend WithEvents lblTopFlow As System.Windows.Forms.Label
    Friend WithEvents lblTopFlowMeterText As System.Windows.Forms.Label
    Friend WithEvents txtTopFlowMeter As System.Windows.Forms.TextBox
    Friend WithEvents lblBotFlowMeterText As System.Windows.Forms.Label
    Friend WithEvents lblFlowUnit01Text As System.Windows.Forms.Label
    Friend WithEvents lblPulseL01Text As System.Windows.Forms.Label
    Friend WithEvents txtBotFlowMeter As System.Windows.Forms.TextBox

End Class

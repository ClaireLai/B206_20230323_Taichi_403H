<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTempCurve
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
        Me.ControlADAM41181 = New TEMPLOG.ControlADAM4118
        Me.SuspendLayout()
        '
        'ControlADAM41181
        '
        Me.ControlADAM41181.AutoSize = True
        Me.ControlADAM41181.Location = New System.Drawing.Point(1, 0)
        Me.ControlADAM41181.Name = "ControlADAM41181"
        Me.ControlADAM41181.Size = New System.Drawing.Size(723, 611)
        Me.ControlADAM41181.TabIndex = 0
        '
        'FormTempCurve
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(720, 544)
        Me.Controls.Add(Me.ControlADAM41181)
        Me.Name = "FormTempCurve"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ControlADAM41181 As TEMPLOG.ControlADAM4118
End Class

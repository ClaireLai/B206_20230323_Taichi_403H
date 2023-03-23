<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBarcodeInput
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
        Me.txtEnterValue = New System.Windows.Forms.TextBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblCurrentWaferID = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtEnterValue
        '
        Me.txtEnterValue.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.txtEnterValue.Location = New System.Drawing.Point(-2, 31)
        Me.txtEnterValue.Name = "txtEnterValue"
        Me.txtEnterValue.Size = New System.Drawing.Size(441, 29)
        Me.txtEnterValue.TabIndex = 76
        Me.txtEnterValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEnter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnter.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.Location = New System.Drawing.Point(281, 74)
        Me.btnEnter.Margin = New System.Windows.Forms.Padding(1)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(103, 36)
        Me.btnEnter.TabIndex = 77
        Me.btnEnter.Text = "OK"
        Me.btnEnter.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(58, 74)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(1)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(103, 36)
        Me.btnCancel.TabIndex = 78
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'lblCurrentWaferID
        '
        Me.lblCurrentWaferID.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblCurrentWaferID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCurrentWaferID.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lblCurrentWaferID.Location = New System.Drawing.Point(-2, 2)
        Me.lblCurrentWaferID.Name = "lblCurrentWaferID"
        Me.lblCurrentWaferID.Size = New System.Drawing.Size(441, 26)
        Me.lblCurrentWaferID.TabIndex = 754
        Me.lblCurrentWaferID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormBarcodeInput
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(444, 132)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblCurrentWaferID)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.txtEnterValue)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormBarcodeInput"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormBarcodeInput"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtEnterValue As System.Windows.Forms.TextBox
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblCurrentWaferID As System.Windows.Forms.Label
End Class

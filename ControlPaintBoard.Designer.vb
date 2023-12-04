<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlPaintBoard
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
        Me.components = New System.ComponentModel.Container()
        Me.picPaintBoard = New System.Windows.Forms.PictureBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnEnable = New System.Windows.Forms.Button()
        Me.btnEraser = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picPaintBoard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPaintBoard
        '
        Me.picPaintBoard.BackColor = System.Drawing.Color.White
        Me.picPaintBoard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picPaintBoard.Location = New System.Drawing.Point(0, 44)
        Me.picPaintBoard.Name = "picPaintBoard"
        Me.picPaintBoard.Size = New System.Drawing.Size(600, 356)
        Me.picPaintBoard.TabIndex = 1
        Me.picPaintBoard.TabStop = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(190, 3)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(72, 35)
        Me.btnClear.TabIndex = 59
        Me.btnClear.Text = "清除"
        Me.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnEnable
        '
        Me.btnEnable.BackColor = System.Drawing.SystemColors.Control
        Me.btnEnable.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnable.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnable.ForeColor = System.Drawing.Color.Black
        Me.btnEnable.Location = New System.Drawing.Point(3, 3)
        Me.btnEnable.Name = "btnEnable"
        Me.btnEnable.Size = New System.Drawing.Size(72, 35)
        Me.btnEnable.TabIndex = 60
        Me.btnEnable.Text = "啟用"
        Me.btnEnable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEnable.UseVisualStyleBackColor = False
        '
        'btnEraser
        '
        Me.btnEraser.BackColor = System.Drawing.Color.LightBlue
        Me.btnEraser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEraser.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEraser.ForeColor = System.Drawing.Color.Black
        Me.btnEraser.Location = New System.Drawing.Point(97, 3)
        Me.btnEraser.Name = "btnEraser"
        Me.btnEraser.Size = New System.Drawing.Size(72, 35)
        Me.btnEraser.TabIndex = 61
        Me.btnEraser.Text = "橡皮擦"
        Me.btnEraser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEraser.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'ControlPaintBoard
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.btnEraser)
        Me.Controls.Add(Me.btnEnable)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.picPaintBoard)
        Me.DoubleBuffered = True
        Me.Name = "ControlPaintBoard"
        Me.Size = New System.Drawing.Size(805, 400)
        CType(Me.picPaintBoard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picPaintBoard As System.Windows.Forms.PictureBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnEnable As System.Windows.Forms.Button
    Friend WithEvents btnEraser As System.Windows.Forms.Button
    Friend WithEvents Timer1 As Timer
End Class

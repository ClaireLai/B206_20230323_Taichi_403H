<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlDataShowVertical
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlDataShowVertical))
        Me.lblPressure = New System.Windows.Forms.Label()
        Me.lblBotTemp = New System.Windows.Forms.Label()
        Me.lblPressurePreset = New System.Windows.Forms.Label()
        Me.lblTempPreset = New System.Windows.Forms.Label()
        Me.lblTopTemp = New System.Windows.Forms.Label()
        Me.picC01 = New System.Windows.Forms.PictureBox()
        Me.picC02 = New System.Windows.Forms.PictureBox()
        Me.lblKg01Text = New System.Windows.Forms.Label()
        Me.picC03 = New System.Windows.Forms.PictureBox()
        Me.lblKg02Text = New System.Windows.Forms.Label()
        Me.lblDAValue = New System.Windows.Forms.Label()
        Me.lblDa01Text = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picC01, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picC02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picC03, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPressure
        '
        Me.lblPressure.BackColor = System.Drawing.Color.Black
        Me.lblPressure.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPressure.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPressure.ForeColor = System.Drawing.Color.Lime
        Me.lblPressure.Location = New System.Drawing.Point(0, -1)
        Me.lblPressure.Name = "lblPressure"
        Me.lblPressure.Size = New System.Drawing.Size(51, 20)
        Me.lblPressure.TabIndex = 532
        Me.lblPressure.Text = "000"
        Me.lblPressure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBotTemp
        '
        Me.lblBotTemp.BackColor = System.Drawing.Color.Black
        Me.lblBotTemp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBotTemp.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBotTemp.ForeColor = System.Drawing.Color.Lime
        Me.lblBotTemp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblBotTemp.Location = New System.Drawing.Point(0, 59)
        Me.lblBotTemp.Name = "lblBotTemp"
        Me.lblBotTemp.Size = New System.Drawing.Size(51, 20)
        Me.lblBotTemp.TabIndex = 535
        Me.lblBotTemp.Text = "0"
        Me.lblBotTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPressurePreset
        '
        Me.lblPressurePreset.BackColor = System.Drawing.Color.Black
        Me.lblPressurePreset.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPressurePreset.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPressurePreset.ForeColor = System.Drawing.Color.Cyan
        Me.lblPressurePreset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPressurePreset.Location = New System.Drawing.Point(0, 19)
        Me.lblPressurePreset.Name = "lblPressurePreset"
        Me.lblPressurePreset.Size = New System.Drawing.Size(51, 20)
        Me.lblPressurePreset.TabIndex = 530
        Me.lblPressurePreset.Text = "0000"
        Me.lblPressurePreset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTempPreset
        '
        Me.lblTempPreset.BackColor = System.Drawing.Color.Black
        Me.lblTempPreset.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTempPreset.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTempPreset.ForeColor = System.Drawing.Color.Cyan
        Me.lblTempPreset.Location = New System.Drawing.Point(0, 79)
        Me.lblTempPreset.Name = "lblTempPreset"
        Me.lblTempPreset.Size = New System.Drawing.Size(51, 20)
        Me.lblTempPreset.TabIndex = 538
        Me.lblTempPreset.Text = "0"
        Me.lblTempPreset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTopTemp
        '
        Me.lblTopTemp.BackColor = System.Drawing.Color.Black
        Me.lblTopTemp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTopTemp.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopTemp.ForeColor = System.Drawing.Color.Lime
        Me.lblTopTemp.Location = New System.Drawing.Point(0, 39)
        Me.lblTopTemp.Name = "lblTopTemp"
        Me.lblTopTemp.Size = New System.Drawing.Size(51, 20)
        Me.lblTopTemp.TabIndex = 531
        Me.lblTopTemp.Text = "0"
        Me.lblTopTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picC01
        '
        Me.picC01.BackColor = System.Drawing.Color.Transparent
        Me.picC01.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picC01.Image = CType(resources.GetObject("picC01.Image"), System.Drawing.Image)
        Me.picC01.Location = New System.Drawing.Point(51, 42)
        Me.picC01.Name = "picC01"
        Me.picC01.Size = New System.Drawing.Size(16, 16)
        Me.picC01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picC01.TabIndex = 540
        Me.picC01.TabStop = False
        '
        'picC02
        '
        Me.picC02.BackColor = System.Drawing.Color.Transparent
        Me.picC02.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picC02.Image = CType(resources.GetObject("picC02.Image"), System.Drawing.Image)
        Me.picC02.Location = New System.Drawing.Point(51, 63)
        Me.picC02.Name = "picC02"
        Me.picC02.Size = New System.Drawing.Size(16, 16)
        Me.picC02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picC02.TabIndex = 539
        Me.picC02.TabStop = False
        '
        'lblKg01Text
        '
        Me.lblKg01Text.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKg01Text.ForeColor = System.Drawing.Color.Black
        Me.lblKg01Text.Location = New System.Drawing.Point(51, 0)
        Me.lblKg01Text.Name = "lblKg01Text"
        Me.lblKg01Text.Size = New System.Drawing.Size(23, 19)
        Me.lblKg01Text.TabIndex = 543
        Me.lblKg01Text.Text = "Kg"
        '
        'picC03
        '
        Me.picC03.BackColor = System.Drawing.Color.Transparent
        Me.picC03.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picC03.Image = CType(resources.GetObject("picC03.Image"), System.Drawing.Image)
        Me.picC03.Location = New System.Drawing.Point(51, 83)
        Me.picC03.Name = "picC03"
        Me.picC03.Size = New System.Drawing.Size(16, 16)
        Me.picC03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picC03.TabIndex = 539
        Me.picC03.TabStop = False
        '
        'lblKg02Text
        '
        Me.lblKg02Text.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKg02Text.ForeColor = System.Drawing.Color.Black
        Me.lblKg02Text.Location = New System.Drawing.Point(51, 21)
        Me.lblKg02Text.Name = "lblKg02Text"
        Me.lblKg02Text.Size = New System.Drawing.Size(23, 19)
        Me.lblKg02Text.TabIndex = 543
        Me.lblKg02Text.Text = "Kg"
        '
        'lblDAValue
        '
        Me.lblDAValue.BackColor = System.Drawing.Color.Black
        Me.lblDAValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDAValue.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDAValue.ForeColor = System.Drawing.Color.Fuchsia
        Me.lblDAValue.Location = New System.Drawing.Point(0, 99)
        Me.lblDAValue.Name = "lblDAValue"
        Me.lblDAValue.Size = New System.Drawing.Size(51, 20)
        Me.lblDAValue.TabIndex = 538
        Me.lblDAValue.Text = "0"
        Me.lblDAValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDa01Text
        '
        Me.lblDa01Text.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDa01Text.ForeColor = System.Drawing.Color.Black
        Me.lblDa01Text.Location = New System.Drawing.Point(51, 100)
        Me.lblDa01Text.Name = "lblDa01Text"
        Me.lblDa01Text.Size = New System.Drawing.Size(23, 19)
        Me.lblDa01Text.TabIndex = 543
        Me.lblDa01Text.Text = "DA"
        '
        'Timer1
        '
        '
        'ControlDataShowVertical
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.picC01)
        Me.Controls.Add(Me.picC03)
        Me.Controls.Add(Me.picC02)
        Me.Controls.Add(Me.lblDa01Text)
        Me.Controls.Add(Me.lblKg02Text)
        Me.Controls.Add(Me.lblKg01Text)
        Me.Controls.Add(Me.lblPressure)
        Me.Controls.Add(Me.lblDAValue)
        Me.Controls.Add(Me.lblTempPreset)
        Me.Controls.Add(Me.lblBotTemp)
        Me.Controls.Add(Me.lblPressurePreset)
        Me.Controls.Add(Me.lblTopTemp)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "ControlDataShowVertical"
        Me.Size = New System.Drawing.Size(73, 123)
        CType(Me.picC01, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picC02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picC03, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblPressure As System.Windows.Forms.Label
    Friend WithEvents lblBotTemp As System.Windows.Forms.Label
    Friend WithEvents lblPressurePreset As System.Windows.Forms.Label
    Friend WithEvents lblTempPreset As System.Windows.Forms.Label
    Friend WithEvents lblTopTemp As System.Windows.Forms.Label
    Friend WithEvents picC01 As System.Windows.Forms.PictureBox
    Friend WithEvents picC02 As System.Windows.Forms.PictureBox
    Friend WithEvents lblKg01Text As System.Windows.Forms.Label
    Friend WithEvents picC03 As System.Windows.Forms.PictureBox
    Friend WithEvents lblKg02Text As System.Windows.Forms.Label
    Friend WithEvents lblDAValue As System.Windows.Forms.Label
    Friend WithEvents lblDa01Text As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class

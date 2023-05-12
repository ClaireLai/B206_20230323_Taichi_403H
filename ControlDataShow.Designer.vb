<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlDataShow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlDataShow))
        Me.grpTitle = New System.Windows.Forms.GroupBox()
        Me.lblkg01Text = New System.Windows.Forms.Label()
        Me.picC01 = New System.Windows.Forms.PictureBox()
        Me.lblPressure = New System.Windows.Forms.Label()
        Me.lblBotTemp = New System.Windows.Forms.Label()
        Me.lblPressureDA = New System.Windows.Forms.Label()
        Me.lblTempPreset = New System.Windows.Forms.Label()
        Me.lblTopTemp = New System.Windows.Forms.Label()
        Me.lblTopTempText = New System.Windows.Forms.Label()
        Me.lblTempPresetText = New System.Windows.Forms.Label()
        Me.lblBotTempText = New System.Windows.Forms.Label()
        Me.lblPressureText = New System.Windows.Forms.Label()
        Me.grpTitle.SuspendLayout()
        CType(Me.picC01, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpTitle
        '
        Me.grpTitle.Controls.Add(Me.lblkg01Text)
        Me.grpTitle.Controls.Add(Me.picC01)
        Me.grpTitle.Controls.Add(Me.lblPressure)
        Me.grpTitle.Controls.Add(Me.lblBotTemp)
        Me.grpTitle.Controls.Add(Me.lblPressureDA)
        Me.grpTitle.Controls.Add(Me.lblTempPreset)
        Me.grpTitle.Controls.Add(Me.lblTopTemp)
        Me.grpTitle.Controls.Add(Me.lblTopTempText)
        Me.grpTitle.Controls.Add(Me.lblTempPresetText)
        Me.grpTitle.Controls.Add(Me.lblBotTempText)
        Me.grpTitle.Controls.Add(Me.lblPressureText)
        Me.grpTitle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTitle.Location = New System.Drawing.Point(0, 0)
        Me.grpTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.grpTitle.Name = "grpTitle"
        Me.grpTitle.Padding = New System.Windows.Forms.Padding(0)
        Me.grpTitle.Size = New System.Drawing.Size(219, 70)
        Me.grpTitle.TabIndex = 542
        Me.grpTitle.TabStop = False
        Me.grpTitle.Text = "曲線資料1"
        '
        'lblkg01Text
        '
        Me.lblkg01Text.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblkg01Text.ForeColor = System.Drawing.Color.Black
        Me.lblkg01Text.Location = New System.Drawing.Point(188, 14)
        Me.lblkg01Text.Name = "lblkg01Text"
        Me.lblkg01Text.Size = New System.Drawing.Size(27, 18)
        Me.lblkg01Text.TabIndex = 536
        Me.lblkg01Text.Text = "kg"
        '
        'picC01
        '
        Me.picC01.BackColor = System.Drawing.Color.Transparent
        Me.picC01.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picC01.Image = CType(resources.GetObject("picC01.Image"), System.Drawing.Image)
        Me.picC01.Location = New System.Drawing.Point(191, 48)
        Me.picC01.Name = "picC01"
        Me.picC01.Size = New System.Drawing.Size(20, 16)
        Me.picC01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picC01.TabIndex = 534
        Me.picC01.TabStop = False
        '
        'lblPressure
        '
        Me.lblPressure.BackColor = System.Drawing.Color.Black
        Me.lblPressure.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPressure.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPressure.ForeColor = System.Drawing.Color.Lime
        Me.lblPressure.Location = New System.Drawing.Point(69, 12)
        Me.lblPressure.Name = "lblPressure"
        Me.lblPressure.Size = New System.Drawing.Size(58, 20)
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
        Me.lblBotTemp.Location = New System.Drawing.Point(69, 45)
        Me.lblBotTemp.Name = "lblBotTemp"
        Me.lblBotTemp.Size = New System.Drawing.Size(58, 20)
        Me.lblBotTemp.TabIndex = 535
        Me.lblBotTemp.Text = "0"
        Me.lblBotTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPressureDA
        '
        Me.lblPressureDA.BackColor = System.Drawing.Color.Black
        Me.lblPressureDA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPressureDA.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPressureDA.ForeColor = System.Drawing.Color.Cyan
        Me.lblPressureDA.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPressureDA.Location = New System.Drawing.Point(127, 12)
        Me.lblPressureDA.Name = "lblPressureDA"
        Me.lblPressureDA.Size = New System.Drawing.Size(58, 20)
        Me.lblPressureDA.TabIndex = 530
        Me.lblPressureDA.Text = "0000"
        Me.lblPressureDA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTempPreset
        '
        Me.lblTempPreset.BackColor = System.Drawing.Color.Black
        Me.lblTempPreset.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTempPreset.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTempPreset.ForeColor = System.Drawing.Color.Cyan
        Me.lblTempPreset.Location = New System.Drawing.Point(127, 45)
        Me.lblTempPreset.Name = "lblTempPreset"
        Me.lblTempPreset.Size = New System.Drawing.Size(58, 20)
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
        Me.lblTopTemp.Location = New System.Drawing.Point(11, 45)
        Me.lblTopTemp.Name = "lblTopTemp"
        Me.lblTopTemp.Size = New System.Drawing.Size(58, 20)
        Me.lblTopTemp.TabIndex = 531
        Me.lblTopTemp.Text = "0"
        Me.lblTopTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTopTempText
        '
        Me.lblTopTempText.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopTempText.ForeColor = System.Drawing.Color.Black
        Me.lblTopTempText.Location = New System.Drawing.Point(14, 30)
        Me.lblTopTempText.Name = "lblTopTempText"
        Me.lblTopTempText.Size = New System.Drawing.Size(58, 16)
        Me.lblTopTempText.TabIndex = 539
        Me.lblTopTempText.Text = "上溫度"
        Me.lblTopTempText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTempPresetText
        '
        Me.lblTempPresetText.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTempPresetText.ForeColor = System.Drawing.Color.Black
        Me.lblTempPresetText.Location = New System.Drawing.Point(127, 30)
        Me.lblTempPresetText.Name = "lblTempPresetText"
        Me.lblTempPresetText.Size = New System.Drawing.Size(58, 16)
        Me.lblTempPresetText.TabIndex = 540
        Me.lblTempPresetText.Text = "預設"
        Me.lblTempPresetText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBotTempText
        '
        Me.lblBotTempText.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBotTempText.ForeColor = System.Drawing.Color.Black
        Me.lblBotTempText.Location = New System.Drawing.Point(72, 30)
        Me.lblBotTempText.Name = "lblBotTempText"
        Me.lblBotTempText.Size = New System.Drawing.Size(58, 16)
        Me.lblBotTempText.TabIndex = 540
        Me.lblBotTempText.Text = "下溫度"
        Me.lblBotTempText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPressureText
        '
        Me.lblPressureText.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPressureText.ForeColor = System.Drawing.Color.Black
        Me.lblPressureText.Location = New System.Drawing.Point(8, 13)
        Me.lblPressureText.Name = "lblPressureText"
        Me.lblPressureText.Size = New System.Drawing.Size(61, 18)
        Me.lblPressureText.TabIndex = 539
        Me.lblPressureText.Text = "壓力:"
        Me.lblPressureText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ControlDataShow
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.grpTitle)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "ControlDataShow"
        Me.Size = New System.Drawing.Size(220, 70)
        Me.grpTitle.ResumeLayout(False)
        CType(Me.picC01, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpTitle As System.Windows.Forms.GroupBox
    Friend WithEvents lblkg01Text As System.Windows.Forms.Label
    Friend WithEvents picC01 As System.Windows.Forms.PictureBox
    Friend WithEvents lblPressure As System.Windows.Forms.Label
    Friend WithEvents lblPressureText As System.Windows.Forms.Label
    Friend WithEvents lblBotTemp As System.Windows.Forms.Label
    Friend WithEvents lblPressureDA As System.Windows.Forms.Label
    Friend WithEvents lblTempPreset As System.Windows.Forms.Label
    Friend WithEvents lblTopTemp As System.Windows.Forms.Label
    Friend WithEvents lblTopTempText As System.Windows.Forms.Label
    Friend WithEvents lblTempPresetText As System.Windows.Forms.Label
    Friend WithEvents lblBotTempText As System.Windows.Forms.Label

End Class

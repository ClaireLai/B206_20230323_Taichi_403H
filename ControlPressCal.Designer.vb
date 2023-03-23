<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlPressCal
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
        Me.txtX1 = New System.Windows.Forms.TextBox()
        Me.txtX5 = New System.Windows.Forms.TextBox()
        Me.txtX2 = New System.Windows.Forms.TextBox()
        Me.txtX3 = New System.Windows.Forms.TextBox()
        Me.txtX4 = New System.Windows.Forms.TextBox()
        Me.txtY1 = New System.Windows.Forms.TextBox()
        Me.txtY5 = New System.Windows.Forms.TextBox()
        Me.txtY2 = New System.Windows.Forms.TextBox()
        Me.txtY3 = New System.Windows.Forms.TextBox()
        Me.txtY4 = New System.Windows.Forms.TextBox()
        Me.lblOriginValue = New System.Windows.Forms.Label()
        Me.lblCaledValue = New System.Windows.Forms.Label()
        Me.lblXText = New System.Windows.Forms.Label()
        Me.lblCaledText = New System.Windows.Forms.Label()
        Me.lblOriginText = New System.Windows.Forms.Label()
        Me.grpPressCalTitle = New System.Windows.Forms.GroupBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnPlateUp = New System.Windows.Forms.Button()
        Me.btnPlateDown = New System.Windows.Forms.Button()
        Me.lblScaleValue = New System.Windows.Forms.Label()
        Me.lblPressureVoltage = New System.Windows.Forms.Label()
        Me.lblFullScaleText = New System.Windows.Forms.Label()
        Me.txtFullScale = New System.Windows.Forms.TextBox()
        Me.lblDA01Text = New System.Windows.Forms.Label()
        Me.lblAD01Text = New System.Windows.Forms.Label()
        Me.lblRealPressureAD = New System.Windows.Forms.Label()
        Me.lblV02Text = New System.Windows.Forms.Label()
        Me.lblKgf08Text = New System.Windows.Forms.Label()
        Me.lblKgf01Text = New System.Windows.Forms.Label()
        Me.lblKgf02Text = New System.Windows.Forms.Label()
        Me.lblKgf05Text = New System.Windows.Forms.Label()
        Me.lblKgf04Text = New System.Windows.Forms.Label()
        Me.lblKgf03Text = New System.Windows.Forms.Label()
        Me.lblKgf06Text = New System.Windows.Forms.Label()
        Me.lblKgf07Text = New System.Windows.Forms.Label()
        Me.lblYText = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.grpPressCalTitle.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtX1
        '
        Me.txtX1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtX1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtX1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtX1.Location = New System.Drawing.Point(19, 41)
        Me.txtX1.MaxLength = 5
        Me.txtX1.Name = "txtX1"
        Me.txtX1.Size = New System.Drawing.Size(58, 26)
        Me.txtX1.TabIndex = 0
        Me.txtX1.Text = "25"
        Me.txtX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtX5
        '
        Me.txtX5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtX5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtX5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtX5.Location = New System.Drawing.Point(19, 149)
        Me.txtX5.MaxLength = 5
        Me.txtX5.Name = "txtX5"
        Me.txtX5.Size = New System.Drawing.Size(58, 26)
        Me.txtX5.TabIndex = 4
        Me.txtX5.Text = "400"
        Me.txtX5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtX2
        '
        Me.txtX2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtX2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtX2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtX2.Location = New System.Drawing.Point(19, 68)
        Me.txtX2.MaxLength = 5
        Me.txtX2.Name = "txtX2"
        Me.txtX2.Size = New System.Drawing.Size(58, 26)
        Me.txtX2.TabIndex = 1
        Me.txtX2.Text = "100"
        Me.txtX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtX3
        '
        Me.txtX3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtX3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtX3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtX3.Location = New System.Drawing.Point(19, 95)
        Me.txtX3.MaxLength = 5
        Me.txtX3.Name = "txtX3"
        Me.txtX3.Size = New System.Drawing.Size(58, 26)
        Me.txtX3.TabIndex = 2
        Me.txtX3.Text = "200"
        Me.txtX3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtX4
        '
        Me.txtX4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtX4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtX4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtX4.Location = New System.Drawing.Point(19, 122)
        Me.txtX4.MaxLength = 5
        Me.txtX4.Name = "txtX4"
        Me.txtX4.Size = New System.Drawing.Size(58, 26)
        Me.txtX4.TabIndex = 3
        Me.txtX4.Text = "300"
        Me.txtX4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtY1
        '
        Me.txtY1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtY1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtY1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtY1.Location = New System.Drawing.Point(80, 41)
        Me.txtY1.MaxLength = 5
        Me.txtY1.Name = "txtY1"
        Me.txtY1.Size = New System.Drawing.Size(58, 26)
        Me.txtY1.TabIndex = 0
        Me.txtY1.Text = "25"
        Me.txtY1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtY5
        '
        Me.txtY5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtY5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtY5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtY5.Location = New System.Drawing.Point(80, 149)
        Me.txtY5.MaxLength = 5
        Me.txtY5.Name = "txtY5"
        Me.txtY5.Size = New System.Drawing.Size(58, 26)
        Me.txtY5.TabIndex = 4
        Me.txtY5.Text = "400"
        Me.txtY5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtY2
        '
        Me.txtY2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtY2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtY2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtY2.Location = New System.Drawing.Point(80, 68)
        Me.txtY2.MaxLength = 5
        Me.txtY2.Name = "txtY2"
        Me.txtY2.Size = New System.Drawing.Size(58, 26)
        Me.txtY2.TabIndex = 1
        Me.txtY2.Text = "100"
        Me.txtY2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtY3
        '
        Me.txtY3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtY3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtY3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtY3.Location = New System.Drawing.Point(80, 95)
        Me.txtY3.MaxLength = 5
        Me.txtY3.Name = "txtY3"
        Me.txtY3.Size = New System.Drawing.Size(58, 26)
        Me.txtY3.TabIndex = 2
        Me.txtY3.Text = "200"
        Me.txtY3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtY4
        '
        Me.txtY4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtY4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtY4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtY4.Location = New System.Drawing.Point(80, 122)
        Me.txtY4.MaxLength = 5
        Me.txtY4.Name = "txtY4"
        Me.txtY4.Size = New System.Drawing.Size(58, 26)
        Me.txtY4.TabIndex = 3
        Me.txtY4.Text = "300"
        Me.txtY4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblOriginValue
        '
        Me.lblOriginValue.BackColor = System.Drawing.Color.Black
        Me.lblOriginValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOriginValue.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOriginValue.ForeColor = System.Drawing.Color.Red
        Me.lblOriginValue.Location = New System.Drawing.Point(80, 200)
        Me.lblOriginValue.Name = "lblOriginValue"
        Me.lblOriginValue.Size = New System.Drawing.Size(58, 23)
        Me.lblOriginValue.TabIndex = 608
        Me.lblOriginValue.Text = "0"
        Me.lblOriginValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCaledValue
        '
        Me.lblCaledValue.BackColor = System.Drawing.Color.Black
        Me.lblCaledValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCaledValue.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaledValue.ForeColor = System.Drawing.Color.Lime
        Me.lblCaledValue.Location = New System.Drawing.Point(80, 176)
        Me.lblCaledValue.Name = "lblCaledValue"
        Me.lblCaledValue.Size = New System.Drawing.Size(58, 23)
        Me.lblCaledValue.TabIndex = 609
        Me.lblCaledValue.Text = "0"
        Me.lblCaledValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblXText
        '
        Me.lblXText.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblXText.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblXText.ForeColor = System.Drawing.Color.Black
        Me.lblXText.Location = New System.Drawing.Point(19, 19)
        Me.lblXText.Name = "lblXText"
        Me.lblXText.Size = New System.Drawing.Size(58, 20)
        Me.lblXText.TabIndex = 603
        Me.lblXText.Text = "設定點"
        Me.lblXText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCaledText
        '
        Me.lblCaledText.BackColor = System.Drawing.SystemColors.Control
        Me.lblCaledText.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaledText.ForeColor = System.Drawing.Color.Black
        Me.lblCaledText.Location = New System.Drawing.Point(5, 179)
        Me.lblCaledText.Name = "lblCaledText"
        Me.lblCaledText.Size = New System.Drawing.Size(74, 17)
        Me.lblCaledText.TabIndex = 601
        Me.lblCaledText.Text = "校正後"
        Me.lblCaledText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblOriginText
        '
        Me.lblOriginText.BackColor = System.Drawing.SystemColors.Control
        Me.lblOriginText.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOriginText.ForeColor = System.Drawing.Color.Black
        Me.lblOriginText.Location = New System.Drawing.Point(5, 203)
        Me.lblOriginText.Name = "lblOriginText"
        Me.lblOriginText.Size = New System.Drawing.Size(74, 17)
        Me.lblOriginText.TabIndex = 606
        Me.lblOriginText.Text = "校正前"
        Me.lblOriginText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grpPressCalTitle
        '
        Me.grpPressCalTitle.BackColor = System.Drawing.SystemColors.Control
        Me.grpPressCalTitle.Controls.Add(Me.btnReset)
        Me.grpPressCalTitle.Controls.Add(Me.btnPlateUp)
        Me.grpPressCalTitle.Controls.Add(Me.btnPlateDown)
        Me.grpPressCalTitle.Controls.Add(Me.lblScaleValue)
        Me.grpPressCalTitle.Controls.Add(Me.lblPressureVoltage)
        Me.grpPressCalTitle.Controls.Add(Me.lblFullScaleText)
        Me.grpPressCalTitle.Controls.Add(Me.txtFullScale)
        Me.grpPressCalTitle.Controls.Add(Me.lblDA01Text)
        Me.grpPressCalTitle.Controls.Add(Me.lblAD01Text)
        Me.grpPressCalTitle.Controls.Add(Me.lblRealPressureAD)
        Me.grpPressCalTitle.Controls.Add(Me.lblV02Text)
        Me.grpPressCalTitle.Controls.Add(Me.lblKgf08Text)
        Me.grpPressCalTitle.Controls.Add(Me.lblKgf01Text)
        Me.grpPressCalTitle.Controls.Add(Me.lblKgf02Text)
        Me.grpPressCalTitle.Controls.Add(Me.lblKgf05Text)
        Me.grpPressCalTitle.Controls.Add(Me.lblKgf04Text)
        Me.grpPressCalTitle.Controls.Add(Me.lblKgf03Text)
        Me.grpPressCalTitle.Controls.Add(Me.lblKgf06Text)
        Me.grpPressCalTitle.Controls.Add(Me.lblKgf07Text)
        Me.grpPressCalTitle.Controls.Add(Me.lblOriginText)
        Me.grpPressCalTitle.Controls.Add(Me.lblYText)
        Me.grpPressCalTitle.Controls.Add(Me.lblOriginValue)
        Me.grpPressCalTitle.Controls.Add(Me.lblXText)
        Me.grpPressCalTitle.Controls.Add(Me.lblCaledText)
        Me.grpPressCalTitle.Controls.Add(Me.txtX1)
        Me.grpPressCalTitle.Controls.Add(Me.lblCaledValue)
        Me.grpPressCalTitle.Controls.Add(Me.txtX5)
        Me.grpPressCalTitle.Controls.Add(Me.txtX2)
        Me.grpPressCalTitle.Controls.Add(Me.txtX3)
        Me.grpPressCalTitle.Controls.Add(Me.txtX4)
        Me.grpPressCalTitle.Controls.Add(Me.txtY1)
        Me.grpPressCalTitle.Controls.Add(Me.txtY5)
        Me.grpPressCalTitle.Controls.Add(Me.txtY2)
        Me.grpPressCalTitle.Controls.Add(Me.txtY4)
        Me.grpPressCalTitle.Controls.Add(Me.txtY3)
        Me.grpPressCalTitle.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPressCalTitle.ForeColor = System.Drawing.Color.Black
        Me.grpPressCalTitle.Location = New System.Drawing.Point(2, 2)
        Me.grpPressCalTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.grpPressCalTitle.Name = "grpPressCalTitle"
        Me.grpPressCalTitle.Padding = New System.Windows.Forms.Padding(0)
        Me.grpPressCalTitle.Size = New System.Drawing.Size(311, 228)
        Me.grpPressCalTitle.TabIndex = 615
        Me.grpPressCalTitle.TabStop = False
        Me.grpPressCalTitle.Text = "Site #01"
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(141, 16)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(36, 23)
        Me.btnReset.TabIndex = 828
        Me.btnReset.Text = "R"
        Me.btnReset.UseVisualStyleBackColor = True
        Me.btnReset.Visible = False
        '
        'btnPlateUp
        '
        Me.btnPlateUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPlateUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPlateUp.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlateUp.ForeColor = System.Drawing.Color.Black
        Me.btnPlateUp.Image = Global.CELLO.My.Resources.Resources.arrowupR
        Me.btnPlateUp.Location = New System.Drawing.Point(175, 170)
        Me.btnPlateUp.Name = "btnPlateUp"
        Me.btnPlateUp.Size = New System.Drawing.Size(63, 52)
        Me.btnPlateUp.TabIndex = 826
        Me.btnPlateUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPlateUp.UseVisualStyleBackColor = False
        '
        'btnPlateDown
        '
        Me.btnPlateDown.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPlateDown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPlateDown.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlateDown.ForeColor = System.Drawing.Color.Black
        Me.btnPlateDown.Image = Global.CELLO.My.Resources.Resources.arrowdownR
        Me.btnPlateDown.Location = New System.Drawing.Point(244, 170)
        Me.btnPlateDown.Name = "btnPlateDown"
        Me.btnPlateDown.Size = New System.Drawing.Size(63, 52)
        Me.btnPlateDown.TabIndex = 827
        Me.btnPlateDown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPlateDown.UseVisualStyleBackColor = False
        '
        'lblScaleValue
        '
        Me.lblScaleValue.BackColor = System.Drawing.Color.Black
        Me.lblScaleValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblScaleValue.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScaleValue.ForeColor = System.Drawing.Color.Lime
        Me.lblScaleValue.Location = New System.Drawing.Point(175, 128)
        Me.lblScaleValue.Name = "lblScaleValue"
        Me.lblScaleValue.Size = New System.Drawing.Size(76, 26)
        Me.lblScaleValue.TabIndex = 824
        Me.lblScaleValue.Text = "0"
        Me.lblScaleValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPressureVoltage
        '
        Me.lblPressureVoltage.BackColor = System.Drawing.Color.Black
        Me.lblPressureVoltage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPressureVoltage.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPressureVoltage.ForeColor = System.Drawing.Color.Lime
        Me.lblPressureVoltage.Location = New System.Drawing.Point(175, 100)
        Me.lblPressureVoltage.Name = "lblPressureVoltage"
        Me.lblPressureVoltage.Size = New System.Drawing.Size(76, 26)
        Me.lblPressureVoltage.TabIndex = 822
        Me.lblPressureVoltage.Text = "0"
        Me.lblPressureVoltage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFullScaleText
        '
        Me.lblFullScaleText.BackColor = System.Drawing.Color.Transparent
        Me.lblFullScaleText.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullScaleText.ForeColor = System.Drawing.Color.Black
        Me.lblFullScaleText.Location = New System.Drawing.Point(172, 19)
        Me.lblFullScaleText.Name = "lblFullScaleText"
        Me.lblFullScaleText.Size = New System.Drawing.Size(79, 20)
        Me.lblFullScaleText.TabIndex = 819
        Me.lblFullScaleText.Text = "全刻度"
        Me.lblFullScaleText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFullScale
        '
        Me.txtFullScale.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullScale.Location = New System.Drawing.Point(175, 42)
        Me.txtFullScale.Name = "txtFullScale"
        Me.txtFullScale.Size = New System.Drawing.Size(76, 26)
        Me.txtFullScale.TabIndex = 820
        Me.txtFullScale.Text = "15000"
        Me.txtFullScale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDA01Text
        '
        Me.lblDA01Text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDA01Text.ForeColor = System.Drawing.Color.Black
        Me.lblDA01Text.Location = New System.Drawing.Point(252, 134)
        Me.lblDA01Text.Name = "lblDA01Text"
        Me.lblDA01Text.Size = New System.Drawing.Size(26, 18)
        Me.lblDA01Text.TabIndex = 812
        Me.lblDA01Text.Text = "DA"
        '
        'lblAD01Text
        '
        Me.lblAD01Text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAD01Text.ForeColor = System.Drawing.Color.Black
        Me.lblAD01Text.Location = New System.Drawing.Point(255, 78)
        Me.lblAD01Text.Name = "lblAD01Text"
        Me.lblAD01Text.Size = New System.Drawing.Size(26, 18)
        Me.lblAD01Text.TabIndex = 812
        Me.lblAD01Text.Text = "AD"
        '
        'lblRealPressureAD
        '
        Me.lblRealPressureAD.BackColor = System.Drawing.Color.Black
        Me.lblRealPressureAD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRealPressureAD.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRealPressureAD.ForeColor = System.Drawing.Color.Lime
        Me.lblRealPressureAD.Location = New System.Drawing.Point(175, 72)
        Me.lblRealPressureAD.Name = "lblRealPressureAD"
        Me.lblRealPressureAD.Size = New System.Drawing.Size(76, 26)
        Me.lblRealPressureAD.TabIndex = 818
        Me.lblRealPressureAD.Text = "0"
        Me.lblRealPressureAD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblV02Text
        '
        Me.lblV02Text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblV02Text.ForeColor = System.Drawing.Color.Black
        Me.lblV02Text.Location = New System.Drawing.Point(255, 108)
        Me.lblV02Text.Name = "lblV02Text"
        Me.lblV02Text.Size = New System.Drawing.Size(26, 18)
        Me.lblV02Text.TabIndex = 815
        Me.lblV02Text.Text = "V"
        '
        'lblKgf08Text
        '
        Me.lblKgf08Text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKgf08Text.ForeColor = System.Drawing.Color.Black
        Me.lblKgf08Text.Location = New System.Drawing.Point(255, 50)
        Me.lblKgf08Text.Name = "lblKgf08Text"
        Me.lblKgf08Text.Size = New System.Drawing.Size(26, 18)
        Me.lblKgf08Text.TabIndex = 814
        Me.lblKgf08Text.Text = "kg"
        '
        'lblKgf01Text
        '
        Me.lblKgf01Text.BackColor = System.Drawing.SystemColors.Control
        Me.lblKgf01Text.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKgf01Text.ForeColor = System.Drawing.Color.Black
        Me.lblKgf01Text.Location = New System.Drawing.Point(138, 45)
        Me.lblKgf01Text.Name = "lblKgf01Text"
        Me.lblKgf01Text.Size = New System.Drawing.Size(31, 18)
        Me.lblKgf01Text.TabIndex = 606
        Me.lblKgf01Text.Text = "kgf"
        Me.lblKgf01Text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblKgf02Text
        '
        Me.lblKgf02Text.BackColor = System.Drawing.SystemColors.Control
        Me.lblKgf02Text.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKgf02Text.ForeColor = System.Drawing.Color.Black
        Me.lblKgf02Text.Location = New System.Drawing.Point(138, 72)
        Me.lblKgf02Text.Name = "lblKgf02Text"
        Me.lblKgf02Text.Size = New System.Drawing.Size(31, 18)
        Me.lblKgf02Text.TabIndex = 606
        Me.lblKgf02Text.Text = "kgf"
        Me.lblKgf02Text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblKgf05Text
        '
        Me.lblKgf05Text.BackColor = System.Drawing.SystemColors.Control
        Me.lblKgf05Text.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKgf05Text.ForeColor = System.Drawing.Color.Black
        Me.lblKgf05Text.Location = New System.Drawing.Point(138, 153)
        Me.lblKgf05Text.Name = "lblKgf05Text"
        Me.lblKgf05Text.Size = New System.Drawing.Size(31, 18)
        Me.lblKgf05Text.TabIndex = 606
        Me.lblKgf05Text.Text = "kgf"
        Me.lblKgf05Text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblKgf04Text
        '
        Me.lblKgf04Text.BackColor = System.Drawing.SystemColors.Control
        Me.lblKgf04Text.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKgf04Text.ForeColor = System.Drawing.Color.Black
        Me.lblKgf04Text.Location = New System.Drawing.Point(138, 126)
        Me.lblKgf04Text.Name = "lblKgf04Text"
        Me.lblKgf04Text.Size = New System.Drawing.Size(31, 18)
        Me.lblKgf04Text.TabIndex = 606
        Me.lblKgf04Text.Text = "kgf"
        Me.lblKgf04Text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblKgf03Text
        '
        Me.lblKgf03Text.BackColor = System.Drawing.SystemColors.Control
        Me.lblKgf03Text.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKgf03Text.ForeColor = System.Drawing.Color.Black
        Me.lblKgf03Text.Location = New System.Drawing.Point(138, 99)
        Me.lblKgf03Text.Name = "lblKgf03Text"
        Me.lblKgf03Text.Size = New System.Drawing.Size(31, 18)
        Me.lblKgf03Text.TabIndex = 606
        Me.lblKgf03Text.Text = "kgf"
        Me.lblKgf03Text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblKgf06Text
        '
        Me.lblKgf06Text.BackColor = System.Drawing.SystemColors.Control
        Me.lblKgf06Text.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKgf06Text.ForeColor = System.Drawing.Color.Black
        Me.lblKgf06Text.Location = New System.Drawing.Point(138, 181)
        Me.lblKgf06Text.Name = "lblKgf06Text"
        Me.lblKgf06Text.Size = New System.Drawing.Size(31, 18)
        Me.lblKgf06Text.TabIndex = 606
        Me.lblKgf06Text.Text = "kgf"
        Me.lblKgf06Text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblKgf07Text
        '
        Me.lblKgf07Text.BackColor = System.Drawing.SystemColors.Control
        Me.lblKgf07Text.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKgf07Text.ForeColor = System.Drawing.Color.Black
        Me.lblKgf07Text.Location = New System.Drawing.Point(138, 205)
        Me.lblKgf07Text.Name = "lblKgf07Text"
        Me.lblKgf07Text.Size = New System.Drawing.Size(31, 18)
        Me.lblKgf07Text.TabIndex = 606
        Me.lblKgf07Text.Text = "kgf"
        Me.lblKgf07Text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblYText
        '
        Me.lblYText.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblYText.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblYText.Location = New System.Drawing.Point(80, 19)
        Me.lblYText.Name = "lblYText"
        Me.lblYText.Size = New System.Drawing.Size(58, 20)
        Me.lblYText.TabIndex = 603
        Me.lblYText.Text = "實際值"
        Me.lblYText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'ControlPressCal
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.grpPressCalTitle)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "ControlPressCal"
        Me.Size = New System.Drawing.Size(316, 234)
        Me.grpPressCalTitle.ResumeLayout(False)
        Me.grpPressCalTitle.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtX1 As System.Windows.Forms.TextBox
    Friend WithEvents txtX5 As System.Windows.Forms.TextBox
    Friend WithEvents txtX2 As System.Windows.Forms.TextBox
    Friend WithEvents txtX3 As System.Windows.Forms.TextBox
    Friend WithEvents txtX4 As System.Windows.Forms.TextBox
    Friend WithEvents txtY1 As System.Windows.Forms.TextBox
    Friend WithEvents txtY5 As System.Windows.Forms.TextBox
    Friend WithEvents txtY2 As System.Windows.Forms.TextBox
    Friend WithEvents txtY3 As System.Windows.Forms.TextBox
    Friend WithEvents txtY4 As System.Windows.Forms.TextBox
    Friend WithEvents lblOriginValue As System.Windows.Forms.Label
    Friend WithEvents lblCaledValue As System.Windows.Forms.Label
    Friend WithEvents lblXText As System.Windows.Forms.Label
    Friend WithEvents lblCaledText As System.Windows.Forms.Label
    Friend WithEvents lblOriginText As System.Windows.Forms.Label
    Friend WithEvents grpPressCalTitle As System.Windows.Forms.GroupBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblYText As System.Windows.Forms.Label
    Friend WithEvents lblKgf05Text As System.Windows.Forms.Label
    Friend WithEvents lblKgf06Text As System.Windows.Forms.Label
    Friend WithEvents lblKgf07Text As System.Windows.Forms.Label
    Friend WithEvents lblKgf01Text As System.Windows.Forms.Label
    Friend WithEvents lblKgf02Text As System.Windows.Forms.Label
    Friend WithEvents lblKgf04Text As System.Windows.Forms.Label
    Friend WithEvents lblKgf03Text As System.Windows.Forms.Label
    Friend WithEvents lblPressureVoltage As System.Windows.Forms.Label
    Friend WithEvents lblFullScaleText As System.Windows.Forms.Label
    Friend WithEvents txtFullScale As System.Windows.Forms.TextBox
    Friend WithEvents lblAD01Text As System.Windows.Forms.Label
    Friend WithEvents lblRealPressureAD As System.Windows.Forms.Label
    Friend WithEvents lblV02Text As System.Windows.Forms.Label
    Friend WithEvents lblKgf08Text As System.Windows.Forms.Label
    Friend WithEvents lblScaleValue As System.Windows.Forms.Label
    Friend WithEvents btnPlateUp As System.Windows.Forms.Button
    Friend WithEvents btnPlateDown As System.Windows.Forms.Button
    Friend WithEvents lblDA01Text As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button

End Class

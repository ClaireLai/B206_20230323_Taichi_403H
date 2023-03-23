<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlTempCal
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
        Me.txtTempX1 = New System.Windows.Forms.TextBox
        Me.txtTempX5 = New System.Windows.Forms.TextBox
        Me.txtTempX2 = New System.Windows.Forms.TextBox
        Me.txtTempX3 = New System.Windows.Forms.TextBox
        Me.txtTempX4 = New System.Windows.Forms.TextBox
        Me.txtBotTestValueInput = New System.Windows.Forms.TextBox
        Me.txtTopTempY1 = New System.Windows.Forms.TextBox
        Me.txtTopTempY5 = New System.Windows.Forms.TextBox
        Me.txtTopTempY2 = New System.Windows.Forms.TextBox
        Me.txtTopTempY3 = New System.Windows.Forms.TextBox
        Me.txtTopTempY4 = New System.Windows.Forms.TextBox
        Me.lblTopTestCaledValue = New System.Windows.Forms.Label
        Me.lblOriginTopTemp = New System.Windows.Forms.Label
        Me.lblCaledTopTemp = New System.Windows.Forms.Label
        Me.lblTestCaledText = New System.Windows.Forms.Label
        Me.lblTestInputText = New System.Windows.Forms.Label
        Me.lblCalSetText = New System.Windows.Forms.Label
        Me.lblCaledTempText = New System.Windows.Forms.Label
        Me.lblOriginTempText = New System.Windows.Forms.Label
        Me.grpTitle = New System.Windows.Forms.GroupBox
        Me.btnHeaterON = New System.Windows.Forms.Button
        Me.btnSetY5 = New System.Windows.Forms.Button
        Me.btnSetY4 = New System.Windows.Forms.Button
        Me.btnSetY3 = New System.Windows.Forms.Button
        Me.btnSetY2 = New System.Windows.Forms.Button
        Me.btnSetY1 = New System.Windows.Forms.Button
        Me.lblBotHeaterText = New System.Windows.Forms.Label
        Me.txtTopTestValueInput = New System.Windows.Forms.TextBox
        Me.lblBotTestCaledValue = New System.Windows.Forms.Label
        Me.lblTopHeaterText = New System.Windows.Forms.Label
        Me.lblOriginBotTemp = New System.Windows.Forms.Label
        Me.lblCaledBotTemp = New System.Windows.Forms.Label
        Me.txtBotTempY1 = New System.Windows.Forms.TextBox
        Me.txtBotTempY5 = New System.Windows.Forms.TextBox
        Me.txtBotTempY2 = New System.Windows.Forms.TextBox
        Me.txtBotTempY4 = New System.Windows.Forms.TextBox
        Me.txtBotTempY3 = New System.Windows.Forms.TextBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnReset = New System.Windows.Forms.Button
        Me.grpTitle.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTempX1
        '
        Me.txtTempX1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTempX1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtTempX1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTempX1.Location = New System.Drawing.Point(19, 41)
        Me.txtTempX1.MaxLength = 5
        Me.txtTempX1.Name = "txtTempX1"
        Me.txtTempX1.Size = New System.Drawing.Size(58, 26)
        Me.txtTempX1.TabIndex = 610
        Me.txtTempX1.Text = "25"
        Me.txtTempX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTempX5
        '
        Me.txtTempX5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTempX5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtTempX5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTempX5.Location = New System.Drawing.Point(19, 149)
        Me.txtTempX5.MaxLength = 5
        Me.txtTempX5.Name = "txtTempX5"
        Me.txtTempX5.Size = New System.Drawing.Size(58, 26)
        Me.txtTempX5.TabIndex = 614
        Me.txtTempX5.Text = "400"
        Me.txtTempX5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTempX2
        '
        Me.txtTempX2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTempX2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtTempX2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTempX2.Location = New System.Drawing.Point(19, 68)
        Me.txtTempX2.MaxLength = 5
        Me.txtTempX2.Name = "txtTempX2"
        Me.txtTempX2.Size = New System.Drawing.Size(58, 26)
        Me.txtTempX2.TabIndex = 611
        Me.txtTempX2.Text = "100"
        Me.txtTempX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTempX3
        '
        Me.txtTempX3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTempX3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtTempX3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTempX3.Location = New System.Drawing.Point(19, 95)
        Me.txtTempX3.MaxLength = 5
        Me.txtTempX3.Name = "txtTempX3"
        Me.txtTempX3.Size = New System.Drawing.Size(58, 26)
        Me.txtTempX3.TabIndex = 612
        Me.txtTempX3.Text = "200"
        Me.txtTempX3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTempX4
        '
        Me.txtTempX4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTempX4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtTempX4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTempX4.Location = New System.Drawing.Point(19, 122)
        Me.txtTempX4.MaxLength = 5
        Me.txtTempX4.Name = "txtTempX4"
        Me.txtTempX4.Size = New System.Drawing.Size(58, 26)
        Me.txtTempX4.TabIndex = 613
        Me.txtTempX4.Text = "300"
        Me.txtTempX4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBotTestValueInput
        '
        Me.txtBotTestValueInput.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBotTestValueInput.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtBotTestValueInput.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBotTestValueInput.Location = New System.Drawing.Point(204, 122)
        Me.txtBotTestValueInput.MaxLength = 5
        Me.txtBotTestValueInput.Name = "txtBotTestValueInput"
        Me.txtBotTestValueInput.Size = New System.Drawing.Size(58, 26)
        Me.txtBotTestValueInput.TabIndex = 596
        Me.txtBotTestValueInput.Text = "0"
        Me.txtBotTestValueInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTopTempY1
        '
        Me.txtTopTempY1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTopTempY1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtTopTempY1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTopTempY1.Location = New System.Drawing.Point(80, 41)
        Me.txtTopTempY1.MaxLength = 5
        Me.txtTopTempY1.Name = "txtTopTempY1"
        Me.txtTopTempY1.Size = New System.Drawing.Size(58, 26)
        Me.txtTopTempY1.TabIndex = 595
        Me.txtTopTempY1.Text = "25"
        Me.txtTopTempY1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTopTempY5
        '
        Me.txtTopTempY5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTopTempY5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtTopTempY5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTopTempY5.Location = New System.Drawing.Point(80, 149)
        Me.txtTopTempY5.MaxLength = 5
        Me.txtTopTempY5.Name = "txtTopTempY5"
        Me.txtTopTempY5.Size = New System.Drawing.Size(58, 26)
        Me.txtTopTempY5.TabIndex = 600
        Me.txtTopTempY5.Text = "400"
        Me.txtTopTempY5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTopTempY2
        '
        Me.txtTopTempY2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTopTempY2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtTopTempY2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTopTempY2.Location = New System.Drawing.Point(80, 68)
        Me.txtTopTempY2.MaxLength = 5
        Me.txtTopTempY2.Name = "txtTopTempY2"
        Me.txtTopTempY2.Size = New System.Drawing.Size(58, 26)
        Me.txtTopTempY2.TabIndex = 597
        Me.txtTopTempY2.Text = "100"
        Me.txtTopTempY2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTopTempY3
        '
        Me.txtTopTempY3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTopTempY3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtTopTempY3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTopTempY3.Location = New System.Drawing.Point(80, 95)
        Me.txtTopTempY3.MaxLength = 5
        Me.txtTopTempY3.Name = "txtTopTempY3"
        Me.txtTopTempY3.Size = New System.Drawing.Size(58, 26)
        Me.txtTopTempY3.TabIndex = 598
        Me.txtTopTempY3.Text = "200"
        Me.txtTopTempY3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTopTempY4
        '
        Me.txtTopTempY4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTopTempY4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtTopTempY4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTopTempY4.Location = New System.Drawing.Point(80, 122)
        Me.txtTopTempY4.MaxLength = 5
        Me.txtTopTempY4.Name = "txtTopTempY4"
        Me.txtTopTempY4.Size = New System.Drawing.Size(58, 26)
        Me.txtTopTempY4.TabIndex = 599
        Me.txtTopTempY4.Text = "300"
        Me.txtTopTempY4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTopTestCaledValue
        '
        Me.lblTopTestCaledValue.BackColor = System.Drawing.Color.Black
        Me.lblTopTestCaledValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTopTestCaledValue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblTopTestCaledValue.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopTestCaledValue.ForeColor = System.Drawing.Color.Cyan
        Me.lblTopTestCaledValue.Location = New System.Drawing.Point(204, 71)
        Me.lblTopTestCaledValue.Name = "lblTopTestCaledValue"
        Me.lblTopTestCaledValue.Size = New System.Drawing.Size(58, 23)
        Me.lblTopTestCaledValue.TabIndex = 607
        Me.lblTopTestCaledValue.Text = "0"
        Me.lblTopTestCaledValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOriginTopTemp
        '
        Me.lblOriginTopTemp.BackColor = System.Drawing.Color.Black
        Me.lblOriginTopTemp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOriginTopTemp.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOriginTopTemp.ForeColor = System.Drawing.Color.Red
        Me.lblOriginTopTemp.Location = New System.Drawing.Point(80, 200)
        Me.lblOriginTopTemp.Name = "lblOriginTopTemp"
        Me.lblOriginTopTemp.Size = New System.Drawing.Size(58, 23)
        Me.lblOriginTopTemp.TabIndex = 608
        Me.lblOriginTopTemp.Text = "0"
        Me.lblOriginTopTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCaledTopTemp
        '
        Me.lblCaledTopTemp.BackColor = System.Drawing.Color.Black
        Me.lblCaledTopTemp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCaledTopTemp.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaledTopTemp.ForeColor = System.Drawing.Color.Lime
        Me.lblCaledTopTemp.Location = New System.Drawing.Point(80, 176)
        Me.lblCaledTopTemp.Name = "lblCaledTopTemp"
        Me.lblCaledTopTemp.Size = New System.Drawing.Size(58, 23)
        Me.lblCaledTopTemp.TabIndex = 609
        Me.lblCaledTopTemp.Text = "0"
        Me.lblCaledTopTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTestCaledText
        '
        Me.lblTestCaledText.BackColor = System.Drawing.SystemColors.Control
        Me.lblTestCaledText.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTestCaledText.ForeColor = System.Drawing.Color.Black
        Me.lblTestCaledText.Location = New System.Drawing.Point(4, 259)
        Me.lblTestCaledText.Name = "lblTestCaledText"
        Me.lblTestCaledText.Size = New System.Drawing.Size(74, 17)
        Me.lblTestCaledText.TabIndex = 605
        Me.lblTestCaledText.Text = "溫控設定值"
        Me.lblTestCaledText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTestInputText
        '
        Me.lblTestInputText.BackColor = System.Drawing.SystemColors.Control
        Me.lblTestInputText.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTestInputText.ForeColor = System.Drawing.Color.Black
        Me.lblTestInputText.Location = New System.Drawing.Point(188, 19)
        Me.lblTestInputText.Name = "lblTestInputText"
        Me.lblTestInputText.Size = New System.Drawing.Size(74, 17)
        Me.lblTestInputText.TabIndex = 604
        Me.lblTestInputText.Text = "測試輸入"
        Me.lblTestInputText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCalSetText
        '
        Me.lblCalSetText.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCalSetText.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalSetText.ForeColor = System.Drawing.Color.Black
        Me.lblCalSetText.Location = New System.Drawing.Point(19, 19)
        Me.lblCalSetText.Name = "lblCalSetText"
        Me.lblCalSetText.Size = New System.Drawing.Size(58, 22)
        Me.lblCalSetText.TabIndex = 603
        Me.lblCalSetText.Text = "設定點"
        Me.lblCalSetText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCaledTempText
        '
        Me.lblCaledTempText.BackColor = System.Drawing.SystemColors.Control
        Me.lblCaledTempText.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaledTempText.ForeColor = System.Drawing.Color.Black
        Me.lblCaledTempText.Location = New System.Drawing.Point(5, 179)
        Me.lblCaledTempText.Name = "lblCaledTempText"
        Me.lblCaledTempText.Size = New System.Drawing.Size(74, 17)
        Me.lblCaledTempText.TabIndex = 601
        Me.lblCaledTempText.Text = "校正後溫度"
        Me.lblCaledTempText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblOriginTempText
        '
        Me.lblOriginTempText.BackColor = System.Drawing.SystemColors.Control
        Me.lblOriginTempText.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOriginTempText.ForeColor = System.Drawing.Color.Black
        Me.lblOriginTempText.Location = New System.Drawing.Point(5, 203)
        Me.lblOriginTempText.Name = "lblOriginTempText"
        Me.lblOriginTempText.Size = New System.Drawing.Size(74, 17)
        Me.lblOriginTempText.TabIndex = 606
        Me.lblOriginTempText.Text = "原始溫度"
        Me.lblOriginTempText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grpTitle
        '
        Me.grpTitle.BackColor = System.Drawing.SystemColors.Control
        Me.grpTitle.Controls.Add(Me.btnReset)
        Me.grpTitle.Controls.Add(Me.btnHeaterON)
        Me.grpTitle.Controls.Add(Me.btnSetY5)
        Me.grpTitle.Controls.Add(Me.btnSetY4)
        Me.grpTitle.Controls.Add(Me.btnSetY3)
        Me.grpTitle.Controls.Add(Me.btnSetY2)
        Me.grpTitle.Controls.Add(Me.btnSetY1)
        Me.grpTitle.Controls.Add(Me.lblBotHeaterText)
        Me.grpTitle.Controls.Add(Me.lblTestInputText)
        Me.grpTitle.Controls.Add(Me.txtTopTestValueInput)
        Me.grpTitle.Controls.Add(Me.txtBotTestValueInput)
        Me.grpTitle.Controls.Add(Me.lblBotTestCaledValue)
        Me.grpTitle.Controls.Add(Me.lblTopTestCaledValue)
        Me.grpTitle.Controls.Add(Me.lblOriginTempText)
        Me.grpTitle.Controls.Add(Me.lblTestCaledText)
        Me.grpTitle.Controls.Add(Me.lblTopHeaterText)
        Me.grpTitle.Controls.Add(Me.lblOriginBotTemp)
        Me.grpTitle.Controls.Add(Me.lblOriginTopTemp)
        Me.grpTitle.Controls.Add(Me.lblCalSetText)
        Me.grpTitle.Controls.Add(Me.lblCaledTempText)
        Me.grpTitle.Controls.Add(Me.txtTempX1)
        Me.grpTitle.Controls.Add(Me.lblCaledBotTemp)
        Me.grpTitle.Controls.Add(Me.lblCaledTopTemp)
        Me.grpTitle.Controls.Add(Me.txtTempX5)
        Me.grpTitle.Controls.Add(Me.txtTempX2)
        Me.grpTitle.Controls.Add(Me.txtTempX3)
        Me.grpTitle.Controls.Add(Me.txtBotTempY1)
        Me.grpTitle.Controls.Add(Me.txtTempX4)
        Me.grpTitle.Controls.Add(Me.txtBotTempY5)
        Me.grpTitle.Controls.Add(Me.txtTopTempY1)
        Me.grpTitle.Controls.Add(Me.txtBotTempY2)
        Me.grpTitle.Controls.Add(Me.txtTopTempY5)
        Me.grpTitle.Controls.Add(Me.txtBotTempY4)
        Me.grpTitle.Controls.Add(Me.txtTopTempY2)
        Me.grpTitle.Controls.Add(Me.txtBotTempY3)
        Me.grpTitle.Controls.Add(Me.txtTopTempY4)
        Me.grpTitle.Controls.Add(Me.txtTopTempY3)
        Me.grpTitle.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTitle.ForeColor = System.Drawing.Color.Black
        Me.grpTitle.Location = New System.Drawing.Point(2, 2)
        Me.grpTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.grpTitle.Name = "grpTitle"
        Me.grpTitle.Padding = New System.Windows.Forms.Padding(0)
        Me.grpTitle.Size = New System.Drawing.Size(266, 226)
        Me.grpTitle.TabIndex = 615
        Me.grpTitle.TabStop = False
        Me.grpTitle.Text = "Site #01"
        '
        'btnHeaterON
        '
        Me.btnHeaterON.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHeaterON.Location = New System.Drawing.Point(281, 177)
        Me.btnHeaterON.Name = "btnHeaterON"
        Me.btnHeaterON.Size = New System.Drawing.Size(42, 46)
        Me.btnHeaterON.TabIndex = 615
        Me.btnHeaterON.Text = "ON"
        Me.btnHeaterON.UseVisualStyleBackColor = False
        Me.btnHeaterON.Visible = False
        '
        'btnSetY5
        '
        Me.btnSetY5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetY5.Location = New System.Drawing.Point(283, 149)
        Me.btnSetY5.Name = "btnSetY5"
        Me.btnSetY5.Size = New System.Drawing.Size(40, 26)
        Me.btnSetY5.TabIndex = 615
        Me.btnSetY5.Text = "Set"
        Me.btnSetY5.UseVisualStyleBackColor = False
        Me.btnSetY5.Visible = False
        '
        'btnSetY4
        '
        Me.btnSetY4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetY4.Location = New System.Drawing.Point(283, 122)
        Me.btnSetY4.Name = "btnSetY4"
        Me.btnSetY4.Size = New System.Drawing.Size(40, 26)
        Me.btnSetY4.TabIndex = 615
        Me.btnSetY4.Text = "Set"
        Me.btnSetY4.UseVisualStyleBackColor = False
        Me.btnSetY4.Visible = False
        '
        'btnSetY3
        '
        Me.btnSetY3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetY3.Location = New System.Drawing.Point(283, 95)
        Me.btnSetY3.Name = "btnSetY3"
        Me.btnSetY3.Size = New System.Drawing.Size(40, 26)
        Me.btnSetY3.TabIndex = 615
        Me.btnSetY3.Text = "Set"
        Me.btnSetY3.UseVisualStyleBackColor = False
        Me.btnSetY3.Visible = False
        '
        'btnSetY2
        '
        Me.btnSetY2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetY2.Location = New System.Drawing.Point(283, 68)
        Me.btnSetY2.Name = "btnSetY2"
        Me.btnSetY2.Size = New System.Drawing.Size(40, 26)
        Me.btnSetY2.TabIndex = 615
        Me.btnSetY2.Text = "Set"
        Me.btnSetY2.UseVisualStyleBackColor = False
        Me.btnSetY2.Visible = False
        '
        'btnSetY1
        '
        Me.btnSetY1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetY1.Location = New System.Drawing.Point(283, 41)
        Me.btnSetY1.Name = "btnSetY1"
        Me.btnSetY1.Size = New System.Drawing.Size(40, 26)
        Me.btnSetY1.TabIndex = 615
        Me.btnSetY1.Text = "Set"
        Me.btnSetY1.UseVisualStyleBackColor = False
        Me.btnSetY1.Visible = False
        '
        'lblBotHeaterText
        '
        Me.lblBotHeaterText.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblBotHeaterText.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBotHeaterText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblBotHeaterText.Location = New System.Drawing.Point(141, 19)
        Me.lblBotHeaterText.Name = "lblBotHeaterText"
        Me.lblBotHeaterText.Size = New System.Drawing.Size(58, 20)
        Me.lblBotHeaterText.TabIndex = 603
        Me.lblBotHeaterText.Text = "下加熱"
        Me.lblBotHeaterText.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtTopTestValueInput
        '
        Me.txtTopTestValueInput.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTopTestValueInput.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtTopTestValueInput.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTopTestValueInput.Location = New System.Drawing.Point(204, 41)
        Me.txtTopTestValueInput.MaxLength = 5
        Me.txtTopTestValueInput.Name = "txtTopTestValueInput"
        Me.txtTopTestValueInput.Size = New System.Drawing.Size(58, 26)
        Me.txtTopTestValueInput.TabIndex = 596
        Me.txtTopTestValueInput.Text = "0"
        Me.txtTopTestValueInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblBotTestCaledValue
        '
        Me.lblBotTestCaledValue.BackColor = System.Drawing.Color.Black
        Me.lblBotTestCaledValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBotTestCaledValue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblBotTestCaledValue.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBotTestCaledValue.ForeColor = System.Drawing.Color.Fuchsia
        Me.lblBotTestCaledValue.Location = New System.Drawing.Point(204, 152)
        Me.lblBotTestCaledValue.Name = "lblBotTestCaledValue"
        Me.lblBotTestCaledValue.Size = New System.Drawing.Size(58, 23)
        Me.lblBotTestCaledValue.TabIndex = 607
        Me.lblBotTestCaledValue.Text = "0"
        Me.lblBotTestCaledValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTopHeaterText
        '
        Me.lblTopHeaterText.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTopHeaterText.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopHeaterText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTopHeaterText.Location = New System.Drawing.Point(80, 19)
        Me.lblTopHeaterText.Name = "lblTopHeaterText"
        Me.lblTopHeaterText.Size = New System.Drawing.Size(58, 20)
        Me.lblTopHeaterText.TabIndex = 603
        Me.lblTopHeaterText.Text = "上加熱器"
        Me.lblTopHeaterText.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblOriginBotTemp
        '
        Me.lblOriginBotTemp.BackColor = System.Drawing.Color.Black
        Me.lblOriginBotTemp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOriginBotTemp.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOriginBotTemp.ForeColor = System.Drawing.Color.Red
        Me.lblOriginBotTemp.Location = New System.Drawing.Point(141, 200)
        Me.lblOriginBotTemp.Name = "lblOriginBotTemp"
        Me.lblOriginBotTemp.Size = New System.Drawing.Size(58, 23)
        Me.lblOriginBotTemp.TabIndex = 608
        Me.lblOriginBotTemp.Text = "0"
        Me.lblOriginBotTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCaledBotTemp
        '
        Me.lblCaledBotTemp.BackColor = System.Drawing.Color.Black
        Me.lblCaledBotTemp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCaledBotTemp.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaledBotTemp.ForeColor = System.Drawing.Color.Lime
        Me.lblCaledBotTemp.Location = New System.Drawing.Point(141, 176)
        Me.lblCaledBotTemp.Name = "lblCaledBotTemp"
        Me.lblCaledBotTemp.Size = New System.Drawing.Size(58, 23)
        Me.lblCaledBotTemp.TabIndex = 609
        Me.lblCaledBotTemp.Text = "0"
        Me.lblCaledBotTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBotTempY1
        '
        Me.txtBotTempY1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBotTempY1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtBotTempY1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBotTempY1.Location = New System.Drawing.Point(141, 41)
        Me.txtBotTempY1.MaxLength = 5
        Me.txtBotTempY1.Name = "txtBotTempY1"
        Me.txtBotTempY1.Size = New System.Drawing.Size(58, 26)
        Me.txtBotTempY1.TabIndex = 595
        Me.txtBotTempY1.Text = "25"
        Me.txtBotTempY1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBotTempY5
        '
        Me.txtBotTempY5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBotTempY5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtBotTempY5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBotTempY5.Location = New System.Drawing.Point(141, 149)
        Me.txtBotTempY5.MaxLength = 5
        Me.txtBotTempY5.Name = "txtBotTempY5"
        Me.txtBotTempY5.Size = New System.Drawing.Size(58, 26)
        Me.txtBotTempY5.TabIndex = 600
        Me.txtBotTempY5.Text = "400"
        Me.txtBotTempY5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBotTempY2
        '
        Me.txtBotTempY2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBotTempY2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtBotTempY2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBotTempY2.Location = New System.Drawing.Point(141, 68)
        Me.txtBotTempY2.MaxLength = 5
        Me.txtBotTempY2.Name = "txtBotTempY2"
        Me.txtBotTempY2.Size = New System.Drawing.Size(58, 26)
        Me.txtBotTempY2.TabIndex = 597
        Me.txtBotTempY2.Text = "100"
        Me.txtBotTempY2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBotTempY4
        '
        Me.txtBotTempY4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBotTempY4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtBotTempY4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBotTempY4.Location = New System.Drawing.Point(141, 122)
        Me.txtBotTempY4.MaxLength = 5
        Me.txtBotTempY4.Name = "txtBotTempY4"
        Me.txtBotTempY4.Size = New System.Drawing.Size(58, 26)
        Me.txtBotTempY4.TabIndex = 599
        Me.txtBotTempY4.Text = "300"
        Me.txtBotTempY4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBotTempY3
        '
        Me.txtBotTempY3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBotTempY3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtBotTempY3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBotTempY3.Location = New System.Drawing.Point(141, 95)
        Me.txtBotTempY3.MaxLength = 5
        Me.txtBotTempY3.Name = "txtBotTempY3"
        Me.txtBotTempY3.Size = New System.Drawing.Size(58, 26)
        Me.txtBotTempY3.TabIndex = 598
        Me.txtBotTempY3.Text = "200"
        Me.txtBotTempY3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Timer1
        '
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(204, 197)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(58, 23)
        Me.btnReset.TabIndex = 829
        Me.btnReset.Text = "R"
        Me.btnReset.UseVisualStyleBackColor = True
        Me.btnReset.Visible = False
        '
        'ControlTempCal
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.grpTitle)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "ControlTempCal"
        Me.Size = New System.Drawing.Size(270, 232)
        Me.grpTitle.ResumeLayout(False)
        Me.grpTitle.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtTempX1 As System.Windows.Forms.TextBox
    Friend WithEvents txtTempX5 As System.Windows.Forms.TextBox
    Friend WithEvents txtTempX2 As System.Windows.Forms.TextBox
    Friend WithEvents txtTempX3 As System.Windows.Forms.TextBox
    Friend WithEvents txtTempX4 As System.Windows.Forms.TextBox
    Friend WithEvents txtBotTestValueInput As System.Windows.Forms.TextBox
    Friend WithEvents txtTopTempY1 As System.Windows.Forms.TextBox
    Friend WithEvents txtTopTempY5 As System.Windows.Forms.TextBox
    Friend WithEvents txtTopTempY2 As System.Windows.Forms.TextBox
    Friend WithEvents txtTopTempY3 As System.Windows.Forms.TextBox
    Friend WithEvents txtTopTempY4 As System.Windows.Forms.TextBox
    Friend WithEvents lblTopTestCaledValue As System.Windows.Forms.Label
    Friend WithEvents lblOriginTopTemp As System.Windows.Forms.Label
    Friend WithEvents lblCaledTopTemp As System.Windows.Forms.Label
    Friend WithEvents lblTestCaledText As System.Windows.Forms.Label
    Friend WithEvents lblTestInputText As System.Windows.Forms.Label
    Friend WithEvents lblCalSetText As System.Windows.Forms.Label
    Friend WithEvents lblCaledTempText As System.Windows.Forms.Label
    Friend WithEvents lblOriginTempText As System.Windows.Forms.Label
    Friend WithEvents grpTitle As System.Windows.Forms.GroupBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblBotHeaterText As System.Windows.Forms.Label
    Friend WithEvents lblTopHeaterText As System.Windows.Forms.Label
    Friend WithEvents txtBotTempY1 As System.Windows.Forms.TextBox
    Friend WithEvents txtBotTempY5 As System.Windows.Forms.TextBox
    Friend WithEvents txtBotTempY2 As System.Windows.Forms.TextBox
    Friend WithEvents txtBotTempY4 As System.Windows.Forms.TextBox
    Friend WithEvents txtBotTempY3 As System.Windows.Forms.TextBox
    Friend WithEvents lblBotTestCaledValue As System.Windows.Forms.Label
    Friend WithEvents lblOriginBotTemp As System.Windows.Forms.Label
    Friend WithEvents lblCaledBotTemp As System.Windows.Forms.Label
    Friend WithEvents txtTopTestValueInput As System.Windows.Forms.TextBox
    Friend WithEvents btnHeaterON As System.Windows.Forms.Button
    Friend WithEvents btnSetY5 As System.Windows.Forms.Button
    Friend WithEvents btnSetY4 As System.Windows.Forms.Button
    Friend WithEvents btnSetY3 As System.Windows.Forms.Button
    Friend WithEvents btnSetY2 As System.Windows.Forms.Button
    Friend WithEvents btnSetY1 As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button

End Class

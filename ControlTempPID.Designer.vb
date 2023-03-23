<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlTempPID
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
        Me.btnTopAT = New System.Windows.Forms.Button
        Me.btnTopPIDSave = New System.Windows.Forms.Button
        Me.txtTopHighRange = New System.Windows.Forms.TextBox
        Me.lblTopRage1Text = New System.Windows.Forms.Label
        Me.txtTopDH = New System.Windows.Forms.TextBox
        Me.txtTopMaxH = New System.Windows.Forms.TextBox
        Me.lblTopDText = New System.Windows.Forms.Label
        Me.lblTopIText = New System.Windows.Forms.Label
        Me.lblTopTempI = New System.Windows.Forms.Label
        Me.txtTopMinL = New System.Windows.Forms.TextBox
        Me.lblTopTempP = New System.Windows.Forms.Label
        Me.lblTopPText = New System.Windows.Forms.Label
        Me.lblTopMinPowerText = New System.Windows.Forms.Label
        Me.lblTopTempD = New System.Windows.Forms.Label
        Me.txtTopMaxL = New System.Windows.Forms.TextBox
        Me.txtTopIH = New System.Windows.Forms.TextBox
        Me.lblTopRage2Text = New System.Windows.Forms.Label
        Me.txtTopPH = New System.Windows.Forms.TextBox
        Me.txtTopMinH = New System.Windows.Forms.TextBox
        Me.lblTopArea3Text = New System.Windows.Forms.Label
        Me.txtTopPM = New System.Windows.Forms.TextBox
        Me.txtTopIM = New System.Windows.Forms.TextBox
        Me.lblTopArea1Text = New System.Windows.Forms.Label
        Me.txtTopIL = New System.Windows.Forms.TextBox
        Me.txtTopMinM = New System.Windows.Forms.TextBox
        Me.txtTopDL = New System.Windows.Forms.TextBox
        Me.txtTopPL = New System.Windows.Forms.TextBox
        Me.lblPercent01Text = New System.Windows.Forms.Label
        Me.lblTopMaxPowerText = New System.Windows.Forms.Label
        Me.lblPercent02Text = New System.Windows.Forms.Label
        Me.lblTopRage3Text = New System.Windows.Forms.Label
        Me.txtTopMaxM = New System.Windows.Forms.TextBox
        Me.txtTopLowRange = New System.Windows.Forms.TextBox
        Me.lblTopArea2Text = New System.Windows.Forms.Label
        Me.txtTopDM = New System.Windows.Forms.TextBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.tabpagePID02 = New System.Windows.Forms.TabControl
        Me.tabpagePID01 = New System.Windows.Forms.TabPage
        Me.btnTopHeater = New System.Windows.Forms.Button
        Me.txtTopTempSet = New System.Windows.Forms.TextBox
        Me.lblTopTemp = New System.Windows.Forms.Label
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.lblTopCurrentPower = New System.Windows.Forms.Label
        Me.picC06 = New System.Windows.Forms.PictureBox
        Me.lblTopLowLimitTempText = New System.Windows.Forms.Label
        Me.txtTopLowLimitTemp = New System.Windows.Forms.TextBox
        Me.lblTopLowLimitPowerText = New System.Windows.Forms.Label
        Me.lblPercent07Text = New System.Windows.Forms.Label
        Me.txtTopLowLimitPower = New System.Windows.Forms.TextBox
        Me.tabPageData = New System.Windows.Forms.TabPage
        Me.btnBotHeater = New System.Windows.Forms.Button
        Me.txtBotTempSet = New System.Windows.Forms.TextBox
        Me.lblBotTemp = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblBotCurrentPower = New System.Windows.Forms.Label
        Me.picC07 = New System.Windows.Forms.PictureBox
        Me.lblBotLowLimitTempText = New System.Windows.Forms.Label
        Me.txtBotLowLimitTemp = New System.Windows.Forms.TextBox
        Me.lblBotLowLimitPowerText = New System.Windows.Forms.Label
        Me.lblPercent08Text = New System.Windows.Forms.Label
        Me.txtBotLowLimitPower = New System.Windows.Forms.TextBox
        Me.lblBotTempD = New System.Windows.Forms.Label
        Me.lblBotTempI = New System.Windows.Forms.Label
        Me.lblBotTempP = New System.Windows.Forms.Label
        Me.btnBotAT = New System.Windows.Forms.Button
        Me.btnBotPIDSave = New System.Windows.Forms.Button
        Me.txtBotMaxH = New System.Windows.Forms.TextBox
        Me.txtBotMinH = New System.Windows.Forms.TextBox
        Me.txtBotIM = New System.Windows.Forms.TextBox
        Me.lblPercent03Text = New System.Windows.Forms.Label
        Me.txtBotMaxM = New System.Windows.Forms.TextBox
        Me.txtBotDM = New System.Windows.Forms.TextBox
        Me.txtBotMinM = New System.Windows.Forms.TextBox
        Me.lblBotPText = New System.Windows.Forms.Label
        Me.txtBotPM = New System.Windows.Forms.TextBox
        Me.txtBotHighRange = New System.Windows.Forms.TextBox
        Me.txtBotMinL = New System.Windows.Forms.TextBox
        Me.txtBotLowRange = New System.Windows.Forms.TextBox
        Me.txtBotIH = New System.Windows.Forms.TextBox
        Me.txtBotPL = New System.Windows.Forms.TextBox
        Me.lblBotRage3Text = New System.Windows.Forms.Label
        Me.txtBotDH = New System.Windows.Forms.TextBox
        Me.lblBotRage2Text = New System.Windows.Forms.Label
        Me.lblBotMaxPowerText = New System.Windows.Forms.Label
        Me.txtBotPH = New System.Windows.Forms.TextBox
        Me.lblBotRage1Text = New System.Windows.Forms.Label
        Me.txtBotIL = New System.Windows.Forms.TextBox
        Me.lblBotArea1Text = New System.Windows.Forms.Label
        Me.lblBotDText = New System.Windows.Forms.Label
        Me.lblBotIText = New System.Windows.Forms.Label
        Me.lblBotArea2Text = New System.Windows.Forms.Label
        Me.txtBotMaxL = New System.Windows.Forms.TextBox
        Me.lblPercent04Text = New System.Windows.Forms.Label
        Me.txtBotDL = New System.Windows.Forms.TextBox
        Me.lblBotMinPowerText = New System.Windows.Forms.Label
        Me.lblBotArea3Text = New System.Windows.Forms.Label
        Me.grpTitle = New System.Windows.Forms.GroupBox
        Me.tabpagePID02.SuspendLayout()
        Me.tabpagePID01.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picC06, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPageData.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picC07, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTitle.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnTopAT
        '
        Me.btnTopAT.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTopAT.Location = New System.Drawing.Point(78, 300)
        Me.btnTopAT.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnTopAT.Name = "btnTopAT"
        Me.btnTopAT.Size = New System.Drawing.Size(106, 37)
        Me.btnTopAT.TabIndex = 13
        Me.btnTopAT.Text = "Auto Tune"
        Me.btnTopAT.UseVisualStyleBackColor = True
        Me.btnTopAT.Visible = False
        '
        'btnTopPIDSave
        '
        Me.btnTopPIDSave.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTopPIDSave.Location = New System.Drawing.Point(196, 300)
        Me.btnTopPIDSave.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnTopPIDSave.Name = "btnTopPIDSave"
        Me.btnTopPIDSave.Size = New System.Drawing.Size(106, 37)
        Me.btnTopPIDSave.TabIndex = 13
        Me.btnTopPIDSave.Text = "Save PID"
        Me.btnTopPIDSave.UseVisualStyleBackColor = True
        '
        'txtTopHighRange
        '
        Me.txtTopHighRange.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTopHighRange.Location = New System.Drawing.Point(192, 32)
        Me.txtTopHighRange.Name = "txtTopHighRange"
        Me.txtTopHighRange.Size = New System.Drawing.Size(43, 29)
        Me.txtTopHighRange.TabIndex = 576
        Me.txtTopHighRange.Text = "000"
        Me.txtTopHighRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTopRage1Text
        '
        Me.lblTopRage1Text.BackColor = System.Drawing.Color.Transparent
        Me.lblTopRage1Text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopRage1Text.ForeColor = System.Drawing.Color.Black
        Me.lblTopRage1Text.Location = New System.Drawing.Point(88, 34)
        Me.lblTopRage1Text.Name = "lblTopRage1Text"
        Me.lblTopRage1Text.Size = New System.Drawing.Size(37, 24)
        Me.lblTopRage1Text.TabIndex = 577
        Me.lblTopRage1Text.Text = "0~"
        Me.lblTopRage1Text.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTopDH
        '
        Me.txtTopDH.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTopDH.Location = New System.Drawing.Point(217, 131)
        Me.txtTopDH.Name = "txtTopDH"
        Me.txtTopDH.Size = New System.Drawing.Size(60, 29)
        Me.txtTopDH.TabIndex = 571
        Me.txtTopDH.Text = "0"
        Me.txtTopDH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTopMaxH
        '
        Me.txtTopMaxH.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTopMaxH.Location = New System.Drawing.Point(217, 163)
        Me.txtTopMaxH.Name = "txtTopMaxH"
        Me.txtTopMaxH.Size = New System.Drawing.Size(60, 29)
        Me.txtTopMaxH.TabIndex = 587
        Me.txtTopMaxH.Text = "0"
        Me.txtTopMaxH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTopDText
        '
        Me.lblTopDText.BackColor = System.Drawing.Color.Transparent
        Me.lblTopDText.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopDText.ForeColor = System.Drawing.Color.Black
        Me.lblTopDText.Location = New System.Drawing.Point(49, 133)
        Me.lblTopDText.Name = "lblTopDText"
        Me.lblTopDText.Size = New System.Drawing.Size(30, 24)
        Me.lblTopDText.TabIndex = 560
        Me.lblTopDText.Text = "D"
        Me.lblTopDText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTopIText
        '
        Me.lblTopIText.BackColor = System.Drawing.Color.Transparent
        Me.lblTopIText.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopIText.ForeColor = System.Drawing.Color.Black
        Me.lblTopIText.Location = New System.Drawing.Point(49, 101)
        Me.lblTopIText.Name = "lblTopIText"
        Me.lblTopIText.Size = New System.Drawing.Size(30, 24)
        Me.lblTopIText.TabIndex = 559
        Me.lblTopIText.Text = "I"
        Me.lblTopIText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTopTempI
        '
        Me.lblTopTempI.BackColor = System.Drawing.Color.Black
        Me.lblTopTempI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTopTempI.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopTempI.ForeColor = System.Drawing.Color.Lime
        Me.lblTopTempI.Location = New System.Drawing.Point(6, 99)
        Me.lblTopTempI.Name = "lblTopTempI"
        Me.lblTopTempI.Size = New System.Drawing.Size(51, 29)
        Me.lblTopTempI.TabIndex = 564
        Me.lblTopTempI.Text = "0"
        Me.lblTopTempI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTopMinL
        '
        Me.txtTopMinL.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTopMinL.Location = New System.Drawing.Point(85, 195)
        Me.txtTopMinL.Name = "txtTopMinL"
        Me.txtTopMinL.Size = New System.Drawing.Size(60, 29)
        Me.txtTopMinL.TabIndex = 554
        Me.txtTopMinL.Text = "0"
        Me.txtTopMinL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTopTempP
        '
        Me.lblTopTempP.BackColor = System.Drawing.Color.Black
        Me.lblTopTempP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTopTempP.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopTempP.ForeColor = System.Drawing.Color.Lime
        Me.lblTopTempP.Location = New System.Drawing.Point(6, 67)
        Me.lblTopTempP.Name = "lblTopTempP"
        Me.lblTopTempP.Size = New System.Drawing.Size(51, 29)
        Me.lblTopTempP.TabIndex = 563
        Me.lblTopTempP.Text = "0"
        Me.lblTopTempP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTopPText
        '
        Me.lblTopPText.BackColor = System.Drawing.Color.Transparent
        Me.lblTopPText.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopPText.ForeColor = System.Drawing.Color.Black
        Me.lblTopPText.Location = New System.Drawing.Point(49, 69)
        Me.lblTopPText.Name = "lblTopPText"
        Me.lblTopPText.Size = New System.Drawing.Size(30, 24)
        Me.lblTopPText.TabIndex = 555
        Me.lblTopPText.Text = "P"
        Me.lblTopPText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTopMinPowerText
        '
        Me.lblTopMinPowerText.BackColor = System.Drawing.Color.Transparent
        Me.lblTopMinPowerText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopMinPowerText.ForeColor = System.Drawing.Color.Black
        Me.lblTopMinPowerText.Location = New System.Drawing.Point(0, 195)
        Me.lblTopMinPowerText.Name = "lblTopMinPowerText"
        Me.lblTopMinPowerText.Size = New System.Drawing.Size(82, 24)
        Me.lblTopMinPowerText.TabIndex = 562
        Me.lblTopMinPowerText.Text = "Min Pow:"
        Me.lblTopMinPowerText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTopTempD
        '
        Me.lblTopTempD.BackColor = System.Drawing.Color.Black
        Me.lblTopTempD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTopTempD.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopTempD.ForeColor = System.Drawing.Color.Lime
        Me.lblTopTempD.Location = New System.Drawing.Point(6, 131)
        Me.lblTopTempD.Name = "lblTopTempD"
        Me.lblTopTempD.Size = New System.Drawing.Size(51, 29)
        Me.lblTopTempD.TabIndex = 565
        Me.lblTopTempD.Text = "0"
        Me.lblTopTempD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTopMaxL
        '
        Me.txtTopMaxL.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTopMaxL.Location = New System.Drawing.Point(85, 163)
        Me.txtTopMaxL.Name = "txtTopMaxL"
        Me.txtTopMaxL.Size = New System.Drawing.Size(60, 29)
        Me.txtTopMaxL.TabIndex = 553
        Me.txtTopMaxL.Text = "0"
        Me.txtTopMaxL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTopIH
        '
        Me.txtTopIH.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTopIH.Location = New System.Drawing.Point(217, 99)
        Me.txtTopIH.Name = "txtTopIH"
        Me.txtTopIH.Size = New System.Drawing.Size(60, 29)
        Me.txtTopIH.TabIndex = 570
        Me.txtTopIH.Text = "0"
        Me.txtTopIH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTopRage2Text
        '
        Me.lblTopRage2Text.BackColor = System.Drawing.Color.Transparent
        Me.lblTopRage2Text.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopRage2Text.ForeColor = System.Drawing.Color.Black
        Me.lblTopRage2Text.Location = New System.Drawing.Point(171, 34)
        Me.lblTopRage2Text.Name = "lblTopRage2Text"
        Me.lblTopRage2Text.Size = New System.Drawing.Size(22, 24)
        Me.lblTopRage2Text.TabIndex = 579
        Me.lblTopRage2Text.Text = "~"
        Me.lblTopRage2Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTopPH
        '
        Me.txtTopPH.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTopPH.Location = New System.Drawing.Point(217, 67)
        Me.txtTopPH.Name = "txtTopPH"
        Me.txtTopPH.Size = New System.Drawing.Size(60, 29)
        Me.txtTopPH.TabIndex = 569
        Me.txtTopPH.Text = "0"
        Me.txtTopPH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTopMinH
        '
        Me.txtTopMinH.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTopMinH.Location = New System.Drawing.Point(217, 195)
        Me.txtTopMinH.Name = "txtTopMinH"
        Me.txtTopMinH.Size = New System.Drawing.Size(60, 29)
        Me.txtTopMinH.TabIndex = 588
        Me.txtTopMinH.Text = "0"
        Me.txtTopMinH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTopArea3Text
        '
        Me.lblTopArea3Text.BackColor = System.Drawing.Color.Transparent
        Me.lblTopArea3Text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopArea3Text.ForeColor = System.Drawing.Color.Black
        Me.lblTopArea3Text.Location = New System.Drawing.Point(217, 7)
        Me.lblTopArea3Text.Name = "lblTopArea3Text"
        Me.lblTopArea3Text.Size = New System.Drawing.Size(60, 24)
        Me.lblTopArea3Text.TabIndex = 572
        Me.lblTopArea3Text.Text = "Area3"
        Me.lblTopArea3Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTopPM
        '
        Me.txtTopPM.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTopPM.Location = New System.Drawing.Point(151, 67)
        Me.txtTopPM.Name = "txtTopPM"
        Me.txtTopPM.Size = New System.Drawing.Size(60, 29)
        Me.txtTopPM.TabIndex = 566
        Me.txtTopPM.Text = "0"
        Me.txtTopPM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTopIM
        '
        Me.txtTopIM.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTopIM.Location = New System.Drawing.Point(151, 99)
        Me.txtTopIM.Name = "txtTopIM"
        Me.txtTopIM.Size = New System.Drawing.Size(60, 29)
        Me.txtTopIM.TabIndex = 567
        Me.txtTopIM.Text = "0"
        Me.txtTopIM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTopArea1Text
        '
        Me.lblTopArea1Text.BackColor = System.Drawing.Color.Transparent
        Me.lblTopArea1Text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopArea1Text.ForeColor = System.Drawing.Color.Black
        Me.lblTopArea1Text.Location = New System.Drawing.Point(85, 7)
        Me.lblTopArea1Text.Name = "lblTopArea1Text"
        Me.lblTopArea1Text.Size = New System.Drawing.Size(60, 24)
        Me.lblTopArea1Text.TabIndex = 574
        Me.lblTopArea1Text.Text = "Area1"
        Me.lblTopArea1Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTopIL
        '
        Me.txtTopIL.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTopIL.Location = New System.Drawing.Point(85, 99)
        Me.txtTopIL.Name = "txtTopIL"
        Me.txtTopIL.Size = New System.Drawing.Size(60, 29)
        Me.txtTopIL.TabIndex = 551
        Me.txtTopIL.Text = "0"
        Me.txtTopIL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTopMinM
        '
        Me.txtTopMinM.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTopMinM.Location = New System.Drawing.Point(151, 195)
        Me.txtTopMinM.Name = "txtTopMinM"
        Me.txtTopMinM.Size = New System.Drawing.Size(60, 29)
        Me.txtTopMinM.TabIndex = 585
        Me.txtTopMinM.Text = "0"
        Me.txtTopMinM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTopDL
        '
        Me.txtTopDL.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTopDL.Location = New System.Drawing.Point(85, 131)
        Me.txtTopDL.Name = "txtTopDL"
        Me.txtTopDL.Size = New System.Drawing.Size(60, 29)
        Me.txtTopDL.TabIndex = 552
        Me.txtTopDL.Text = "0"
        Me.txtTopDL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTopPL
        '
        Me.txtTopPL.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTopPL.Location = New System.Drawing.Point(85, 67)
        Me.txtTopPL.Name = "txtTopPL"
        Me.txtTopPL.Size = New System.Drawing.Size(60, 29)
        Me.txtTopPL.TabIndex = 550
        Me.txtTopPL.Text = "0"
        Me.txtTopPL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPercent01Text
        '
        Me.lblPercent01Text.BackColor = System.Drawing.Color.Transparent
        Me.lblPercent01Text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercent01Text.ForeColor = System.Drawing.Color.Black
        Me.lblPercent01Text.Location = New System.Drawing.Point(279, 165)
        Me.lblPercent01Text.Name = "lblPercent01Text"
        Me.lblPercent01Text.Size = New System.Drawing.Size(30, 24)
        Me.lblPercent01Text.TabIndex = 558
        Me.lblPercent01Text.Text = "%"
        Me.lblPercent01Text.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTopMaxPowerText
        '
        Me.lblTopMaxPowerText.BackColor = System.Drawing.Color.Transparent
        Me.lblTopMaxPowerText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopMaxPowerText.ForeColor = System.Drawing.Color.Black
        Me.lblTopMaxPowerText.Location = New System.Drawing.Point(0, 166)
        Me.lblTopMaxPowerText.Name = "lblTopMaxPowerText"
        Me.lblTopMaxPowerText.Size = New System.Drawing.Size(82, 24)
        Me.lblTopMaxPowerText.TabIndex = 561
        Me.lblTopMaxPowerText.Text = "Max Pow:"
        Me.lblTopMaxPowerText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPercent02Text
        '
        Me.lblPercent02Text.BackColor = System.Drawing.Color.Transparent
        Me.lblPercent02Text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercent02Text.ForeColor = System.Drawing.Color.Black
        Me.lblPercent02Text.Location = New System.Drawing.Point(278, 197)
        Me.lblPercent02Text.Name = "lblPercent02Text"
        Me.lblPercent02Text.Size = New System.Drawing.Size(30, 24)
        Me.lblPercent02Text.TabIndex = 556
        Me.lblPercent02Text.Text = "%"
        Me.lblPercent02Text.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTopRage3Text
        '
        Me.lblTopRage3Text.BackColor = System.Drawing.Color.Transparent
        Me.lblTopRage3Text.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopRage3Text.ForeColor = System.Drawing.Color.Black
        Me.lblTopRage3Text.Location = New System.Drawing.Point(236, 34)
        Me.lblTopRage3Text.Name = "lblTopRage3Text"
        Me.lblTopRage3Text.Size = New System.Drawing.Size(29, 24)
        Me.lblTopRage3Text.TabIndex = 578
        Me.lblTopRage3Text.Text = "~"
        Me.lblTopRage3Text.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTopMaxM
        '
        Me.txtTopMaxM.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTopMaxM.Location = New System.Drawing.Point(151, 163)
        Me.txtTopMaxM.Name = "txtTopMaxM"
        Me.txtTopMaxM.Size = New System.Drawing.Size(60, 29)
        Me.txtTopMaxM.TabIndex = 583
        Me.txtTopMaxM.Text = "0"
        Me.txtTopMaxM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTopLowRange
        '
        Me.txtTopLowRange.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTopLowRange.Location = New System.Drawing.Point(126, 32)
        Me.txtTopLowRange.Name = "txtTopLowRange"
        Me.txtTopLowRange.Size = New System.Drawing.Size(43, 29)
        Me.txtTopLowRange.TabIndex = 575
        Me.txtTopLowRange.Text = "0"
        Me.txtTopLowRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTopArea2Text
        '
        Me.lblTopArea2Text.BackColor = System.Drawing.Color.Transparent
        Me.lblTopArea2Text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopArea2Text.ForeColor = System.Drawing.Color.Black
        Me.lblTopArea2Text.Location = New System.Drawing.Point(151, 7)
        Me.lblTopArea2Text.Name = "lblTopArea2Text"
        Me.lblTopArea2Text.Size = New System.Drawing.Size(60, 24)
        Me.lblTopArea2Text.TabIndex = 573
        Me.lblTopArea2Text.Text = "Area2"
        Me.lblTopArea2Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTopDM
        '
        Me.txtTopDM.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTopDM.Location = New System.Drawing.Point(151, 131)
        Me.txtTopDM.Name = "txtTopDM"
        Me.txtTopDM.Size = New System.Drawing.Size(60, 29)
        Me.txtTopDM.TabIndex = 568
        Me.txtTopDM.Text = "0"
        Me.txtTopDM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Timer1
        '
        '
        'tabpagePID02
        '
        Me.tabpagePID02.Controls.Add(Me.tabpagePID01)
        Me.tabpagePID02.Controls.Add(Me.tabPageData)
        Me.tabpagePID02.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabpagePID02.HotTrack = True
        Me.tabpagePID02.Location = New System.Drawing.Point(0, 18)
        Me.tabpagePID02.Margin = New System.Windows.Forms.Padding(0)
        Me.tabpagePID02.Name = "tabpagePID02"
        Me.tabpagePID02.Padding = New System.Drawing.Point(20, 3)
        Me.tabpagePID02.SelectedIndex = 0
        Me.tabpagePID02.Size = New System.Drawing.Size(319, 380)
        Me.tabpagePID02.TabIndex = 546
        '
        'tabpagePID01
        '
        Me.tabpagePID01.BackColor = System.Drawing.Color.Transparent
        Me.tabpagePID01.Controls.Add(Me.btnTopHeater)
        Me.tabpagePID01.Controls.Add(Me.txtTopTempSet)
        Me.tabpagePID01.Controls.Add(Me.lblTopTemp)
        Me.tabpagePID01.Controls.Add(Me.PictureBox3)
        Me.tabpagePID01.Controls.Add(Me.PictureBox4)
        Me.tabpagePID01.Controls.Add(Me.lblTopCurrentPower)
        Me.tabpagePID01.Controls.Add(Me.picC06)
        Me.tabpagePID01.Controls.Add(Me.lblTopLowLimitTempText)
        Me.tabpagePID01.Controls.Add(Me.txtTopLowLimitTemp)
        Me.tabpagePID01.Controls.Add(Me.lblTopLowLimitPowerText)
        Me.tabpagePID01.Controls.Add(Me.lblPercent07Text)
        Me.tabpagePID01.Controls.Add(Me.txtTopLowLimitPower)
        Me.tabpagePID01.Controls.Add(Me.lblTopTempI)
        Me.tabpagePID01.Controls.Add(Me.lblTopTempP)
        Me.tabpagePID01.Controls.Add(Me.lblTopTempD)
        Me.tabpagePID01.Controls.Add(Me.txtTopHighRange)
        Me.tabpagePID01.Controls.Add(Me.lblTopArea1Text)
        Me.tabpagePID01.Controls.Add(Me.lblTopRage1Text)
        Me.tabpagePID01.Controls.Add(Me.btnTopAT)
        Me.tabpagePID01.Controls.Add(Me.txtTopDH)
        Me.tabpagePID01.Controls.Add(Me.btnTopPIDSave)
        Me.tabpagePID01.Controls.Add(Me.txtTopMaxH)
        Me.tabpagePID01.Controls.Add(Me.txtTopDM)
        Me.tabpagePID01.Controls.Add(Me.lblTopDText)
        Me.tabpagePID01.Controls.Add(Me.lblTopArea2Text)
        Me.tabpagePID01.Controls.Add(Me.lblTopIText)
        Me.tabpagePID01.Controls.Add(Me.txtTopLowRange)
        Me.tabpagePID01.Controls.Add(Me.txtTopMaxM)
        Me.tabpagePID01.Controls.Add(Me.txtTopMinL)
        Me.tabpagePID01.Controls.Add(Me.lblTopRage3Text)
        Me.tabpagePID01.Controls.Add(Me.lblPercent02Text)
        Me.tabpagePID01.Controls.Add(Me.lblTopPText)
        Me.tabpagePID01.Controls.Add(Me.lblTopMaxPowerText)
        Me.tabpagePID01.Controls.Add(Me.lblTopMinPowerText)
        Me.tabpagePID01.Controls.Add(Me.lblPercent01Text)
        Me.tabpagePID01.Controls.Add(Me.txtTopPL)
        Me.tabpagePID01.Controls.Add(Me.txtTopMaxL)
        Me.tabpagePID01.Controls.Add(Me.txtTopDL)
        Me.tabpagePID01.Controls.Add(Me.txtTopIH)
        Me.tabpagePID01.Controls.Add(Me.txtTopMinM)
        Me.tabpagePID01.Controls.Add(Me.lblTopRage2Text)
        Me.tabpagePID01.Controls.Add(Me.txtTopIL)
        Me.tabpagePID01.Controls.Add(Me.txtTopPH)
        Me.tabpagePID01.Controls.Add(Me.txtTopIM)
        Me.tabpagePID01.Controls.Add(Me.txtTopMinH)
        Me.tabpagePID01.Controls.Add(Me.txtTopPM)
        Me.tabpagePID01.Controls.Add(Me.lblTopArea3Text)
        Me.tabpagePID01.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabpagePID01.Location = New System.Drawing.Point(4, 31)
        Me.tabpagePID01.Name = "tabpagePID01"
        Me.tabpagePID01.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpagePID01.Size = New System.Drawing.Size(311, 345)
        Me.tabpagePID01.TabIndex = 0
        Me.tabpagePID01.Text = "Top PID"
        Me.tabpagePID01.UseVisualStyleBackColor = True
        '
        'btnTopHeater
        '
        Me.btnTopHeater.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTopHeater.Location = New System.Drawing.Point(6, 300)
        Me.btnTopHeater.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnTopHeater.Name = "btnTopHeater"
        Me.btnTopHeater.Size = New System.Drawing.Size(51, 37)
        Me.btnTopHeater.TabIndex = 603
        Me.btnTopHeater.Text = "ON"
        Me.btnTopHeater.UseVisualStyleBackColor = True
        '
        'txtTopTempSet
        '
        Me.txtTopTempSet.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTopTempSet.Location = New System.Drawing.Point(6, 263)
        Me.txtTopTempSet.Name = "txtTopTempSet"
        Me.txtTopTempSet.Size = New System.Drawing.Size(51, 29)
        Me.txtTopTempSet.TabIndex = 602
        Me.txtTopTempSet.Text = "0"
        Me.txtTopTempSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTopTemp
        '
        Me.lblTopTemp.BackColor = System.Drawing.Color.Black
        Me.lblTopTemp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTopTemp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopTemp.ForeColor = System.Drawing.Color.Lime
        Me.lblTopTemp.Location = New System.Drawing.Point(6, 233)
        Me.lblTopTemp.Name = "lblTopTemp"
        Me.lblTopTemp.Size = New System.Drawing.Size(51, 29)
        Me.lblTopTemp.TabIndex = 601
        Me.lblTopTemp.Text = "0"
        Me.lblTopTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.CELLO.My.Resources.Resources.tempc
        Me.PictureBox3.Location = New System.Drawing.Point(60, 269)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(22, 22)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 599
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = Global.CELLO.My.Resources.Resources.tempc
        Me.PictureBox4.Location = New System.Drawing.Point(60, 240)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(22, 22)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 600
        Me.PictureBox4.TabStop = False
        '
        'lblTopCurrentPower
        '
        Me.lblTopCurrentPower.BackColor = System.Drawing.Color.Black
        Me.lblTopCurrentPower.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTopCurrentPower.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopCurrentPower.ForeColor = System.Drawing.Color.Lime
        Me.lblTopCurrentPower.Location = New System.Drawing.Point(6, 7)
        Me.lblTopCurrentPower.Name = "lblTopCurrentPower"
        Me.lblTopCurrentPower.Size = New System.Drawing.Size(51, 29)
        Me.lblTopCurrentPower.TabIndex = 595
        Me.lblTopCurrentPower.Text = "0"
        Me.lblTopCurrentPower.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblTopCurrentPower.Visible = False
        '
        'picC06
        '
        Me.picC06.BackColor = System.Drawing.SystemColors.Control
        Me.picC06.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picC06.Image = Global.CELLO.My.Resources.Resources.tempc
        Me.picC06.Location = New System.Drawing.Point(278, 230)
        Me.picC06.Name = "picC06"
        Me.picC06.Size = New System.Drawing.Size(29, 29)
        Me.picC06.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picC06.TabIndex = 594
        Me.picC06.TabStop = False
        Me.picC06.Visible = False
        '
        'lblTopLowLimitTempText
        '
        Me.lblTopLowLimitTempText.BackColor = System.Drawing.Color.Transparent
        Me.lblTopLowLimitTempText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopLowLimitTempText.ForeColor = System.Drawing.Color.Black
        Me.lblTopLowLimitTempText.Location = New System.Drawing.Point(85, 231)
        Me.lblTopLowLimitTempText.Name = "lblTopLowLimitTempText"
        Me.lblTopLowLimitTempText.Size = New System.Drawing.Size(126, 33)
        Me.lblTopLowLimitTempText.TabIndex = 592
        Me.lblTopLowLimitTempText.Text = "限制輸出最低溫度"
        Me.lblTopLowLimitTempText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTopLowLimitTempText.Visible = False
        '
        'txtTopLowLimitTemp
        '
        Me.txtTopLowLimitTemp.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTopLowLimitTemp.Location = New System.Drawing.Point(217, 230)
        Me.txtTopLowLimitTemp.Name = "txtTopLowLimitTemp"
        Me.txtTopLowLimitTemp.Size = New System.Drawing.Size(60, 29)
        Me.txtTopLowLimitTemp.TabIndex = 590
        Me.txtTopLowLimitTemp.Text = "0"
        Me.txtTopLowLimitTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTopLowLimitTemp.Visible = False
        '
        'lblTopLowLimitPowerText
        '
        Me.lblTopLowLimitPowerText.BackColor = System.Drawing.Color.Transparent
        Me.lblTopLowLimitPowerText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopLowLimitPowerText.ForeColor = System.Drawing.Color.Black
        Me.lblTopLowLimitPowerText.Location = New System.Drawing.Point(85, 264)
        Me.lblTopLowLimitPowerText.Name = "lblTopLowLimitPowerText"
        Me.lblTopLowLimitPowerText.Size = New System.Drawing.Size(126, 28)
        Me.lblTopLowLimitPowerText.TabIndex = 593
        Me.lblTopLowLimitPowerText.Text = "限制輸出功率"
        Me.lblTopLowLimitPowerText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTopLowLimitPowerText.Visible = False
        '
        'lblPercent07Text
        '
        Me.lblPercent07Text.BackColor = System.Drawing.Color.Transparent
        Me.lblPercent07Text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercent07Text.ForeColor = System.Drawing.Color.Black
        Me.lblPercent07Text.Location = New System.Drawing.Point(278, 267)
        Me.lblPercent07Text.Name = "lblPercent07Text"
        Me.lblPercent07Text.Size = New System.Drawing.Size(30, 24)
        Me.lblPercent07Text.TabIndex = 589
        Me.lblPercent07Text.Text = "%"
        Me.lblPercent07Text.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblPercent07Text.Visible = False
        '
        'txtTopLowLimitPower
        '
        Me.txtTopLowLimitPower.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTopLowLimitPower.Location = New System.Drawing.Point(217, 262)
        Me.txtTopLowLimitPower.Name = "txtTopLowLimitPower"
        Me.txtTopLowLimitPower.Size = New System.Drawing.Size(60, 29)
        Me.txtTopLowLimitPower.TabIndex = 591
        Me.txtTopLowLimitPower.Text = "0"
        Me.txtTopLowLimitPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTopLowLimitPower.Visible = False
        '
        'tabPageData
        '
        Me.tabPageData.BackColor = System.Drawing.Color.Transparent
        Me.tabPageData.Controls.Add(Me.btnBotHeater)
        Me.tabPageData.Controls.Add(Me.txtBotTempSet)
        Me.tabPageData.Controls.Add(Me.lblBotTemp)
        Me.tabPageData.Controls.Add(Me.PictureBox2)
        Me.tabPageData.Controls.Add(Me.PictureBox1)
        Me.tabPageData.Controls.Add(Me.lblBotCurrentPower)
        Me.tabPageData.Controls.Add(Me.picC07)
        Me.tabPageData.Controls.Add(Me.lblBotLowLimitTempText)
        Me.tabPageData.Controls.Add(Me.txtBotLowLimitTemp)
        Me.tabPageData.Controls.Add(Me.lblBotLowLimitPowerText)
        Me.tabPageData.Controls.Add(Me.lblPercent08Text)
        Me.tabPageData.Controls.Add(Me.txtBotLowLimitPower)
        Me.tabPageData.Controls.Add(Me.lblBotTempD)
        Me.tabPageData.Controls.Add(Me.lblBotTempI)
        Me.tabPageData.Controls.Add(Me.lblBotTempP)
        Me.tabPageData.Controls.Add(Me.btnBotAT)
        Me.tabPageData.Controls.Add(Me.btnBotPIDSave)
        Me.tabPageData.Controls.Add(Me.txtBotMaxH)
        Me.tabPageData.Controls.Add(Me.txtBotMinH)
        Me.tabPageData.Controls.Add(Me.txtBotIM)
        Me.tabPageData.Controls.Add(Me.lblPercent03Text)
        Me.tabPageData.Controls.Add(Me.txtBotMaxM)
        Me.tabPageData.Controls.Add(Me.txtBotDM)
        Me.tabPageData.Controls.Add(Me.txtBotMinM)
        Me.tabPageData.Controls.Add(Me.lblBotPText)
        Me.tabPageData.Controls.Add(Me.txtBotPM)
        Me.tabPageData.Controls.Add(Me.txtBotHighRange)
        Me.tabPageData.Controls.Add(Me.txtBotMinL)
        Me.tabPageData.Controls.Add(Me.txtBotLowRange)
        Me.tabPageData.Controls.Add(Me.txtBotIH)
        Me.tabPageData.Controls.Add(Me.txtBotPL)
        Me.tabPageData.Controls.Add(Me.lblBotRage3Text)
        Me.tabPageData.Controls.Add(Me.txtBotDH)
        Me.tabPageData.Controls.Add(Me.lblBotRage2Text)
        Me.tabPageData.Controls.Add(Me.lblBotMaxPowerText)
        Me.tabPageData.Controls.Add(Me.txtBotPH)
        Me.tabPageData.Controls.Add(Me.lblBotRage1Text)
        Me.tabPageData.Controls.Add(Me.txtBotIL)
        Me.tabPageData.Controls.Add(Me.lblBotArea1Text)
        Me.tabPageData.Controls.Add(Me.lblBotDText)
        Me.tabPageData.Controls.Add(Me.lblBotIText)
        Me.tabPageData.Controls.Add(Me.lblBotArea2Text)
        Me.tabPageData.Controls.Add(Me.txtBotMaxL)
        Me.tabPageData.Controls.Add(Me.lblPercent04Text)
        Me.tabPageData.Controls.Add(Me.txtBotDL)
        Me.tabPageData.Controls.Add(Me.lblBotMinPowerText)
        Me.tabPageData.Controls.Add(Me.lblBotArea3Text)
        Me.tabPageData.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabPageData.Location = New System.Drawing.Point(4, 31)
        Me.tabPageData.Name = "tabPageData"
        Me.tabPageData.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageData.Size = New System.Drawing.Size(311, 345)
        Me.tabPageData.TabIndex = 1
        Me.tabPageData.Text = "Bot PID"
        Me.tabPageData.UseVisualStyleBackColor = True
        '
        'btnBotHeater
        '
        Me.btnBotHeater.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBotHeater.Location = New System.Drawing.Point(6, 300)
        Me.btnBotHeater.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnBotHeater.Name = "btnBotHeater"
        Me.btnBotHeater.Size = New System.Drawing.Size(51, 37)
        Me.btnBotHeater.TabIndex = 603
        Me.btnBotHeater.Text = "ON"
        Me.btnBotHeater.UseVisualStyleBackColor = True
        '
        'txtBotTempSet
        '
        Me.txtBotTempSet.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBotTempSet.Location = New System.Drawing.Point(6, 263)
        Me.txtBotTempSet.Name = "txtBotTempSet"
        Me.txtBotTempSet.Size = New System.Drawing.Size(51, 29)
        Me.txtBotTempSet.TabIndex = 602
        Me.txtBotTempSet.Text = "0"
        Me.txtBotTempSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblBotTemp
        '
        Me.lblBotTemp.BackColor = System.Drawing.Color.Black
        Me.lblBotTemp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBotTemp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBotTemp.ForeColor = System.Drawing.Color.Lime
        Me.lblBotTemp.Location = New System.Drawing.Point(6, 233)
        Me.lblBotTemp.Name = "lblBotTemp"
        Me.lblBotTemp.Size = New System.Drawing.Size(51, 29)
        Me.lblBotTemp.TabIndex = 601
        Me.lblBotTemp.Text = "0"
        Me.lblBotTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.CELLO.My.Resources.Resources.tempc
        Me.PictureBox2.Location = New System.Drawing.Point(60, 269)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(22, 22)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 599
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.CELLO.My.Resources.Resources.tempc
        Me.PictureBox1.Location = New System.Drawing.Point(60, 240)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(22, 22)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 600
        Me.PictureBox1.TabStop = False
        '
        'lblBotCurrentPower
        '
        Me.lblBotCurrentPower.BackColor = System.Drawing.Color.Black
        Me.lblBotCurrentPower.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBotCurrentPower.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBotCurrentPower.ForeColor = System.Drawing.Color.Lime
        Me.lblBotCurrentPower.Location = New System.Drawing.Point(6, 7)
        Me.lblBotCurrentPower.Name = "lblBotCurrentPower"
        Me.lblBotCurrentPower.Size = New System.Drawing.Size(51, 29)
        Me.lblBotCurrentPower.TabIndex = 560
        Me.lblBotCurrentPower.Text = "0"
        Me.lblBotCurrentPower.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblBotCurrentPower.Visible = False
        '
        'picC07
        '
        Me.picC07.BackColor = System.Drawing.SystemColors.Control
        Me.picC07.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picC07.Image = Global.CELLO.My.Resources.Resources.tempc
        Me.picC07.Location = New System.Drawing.Point(278, 230)
        Me.picC07.Name = "picC07"
        Me.picC07.Size = New System.Drawing.Size(29, 29)
        Me.picC07.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picC07.TabIndex = 559
        Me.picC07.TabStop = False
        Me.picC07.Visible = False
        '
        'lblBotLowLimitTempText
        '
        Me.lblBotLowLimitTempText.BackColor = System.Drawing.Color.Transparent
        Me.lblBotLowLimitTempText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBotLowLimitTempText.ForeColor = System.Drawing.Color.Black
        Me.lblBotLowLimitTempText.Location = New System.Drawing.Point(85, 231)
        Me.lblBotLowLimitTempText.Name = "lblBotLowLimitTempText"
        Me.lblBotLowLimitTempText.Size = New System.Drawing.Size(126, 33)
        Me.lblBotLowLimitTempText.TabIndex = 557
        Me.lblBotLowLimitTempText.Text = "限制輸出最低溫度"
        Me.lblBotLowLimitTempText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblBotLowLimitTempText.Visible = False
        '
        'txtBotLowLimitTemp
        '
        Me.txtBotLowLimitTemp.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBotLowLimitTemp.Location = New System.Drawing.Point(217, 230)
        Me.txtBotLowLimitTemp.Name = "txtBotLowLimitTemp"
        Me.txtBotLowLimitTemp.Size = New System.Drawing.Size(60, 29)
        Me.txtBotLowLimitTemp.TabIndex = 555
        Me.txtBotLowLimitTemp.Text = "0"
        Me.txtBotLowLimitTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtBotLowLimitTemp.Visible = False
        '
        'lblBotLowLimitPowerText
        '
        Me.lblBotLowLimitPowerText.BackColor = System.Drawing.Color.Transparent
        Me.lblBotLowLimitPowerText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBotLowLimitPowerText.ForeColor = System.Drawing.Color.Black
        Me.lblBotLowLimitPowerText.Location = New System.Drawing.Point(85, 264)
        Me.lblBotLowLimitPowerText.Name = "lblBotLowLimitPowerText"
        Me.lblBotLowLimitPowerText.Size = New System.Drawing.Size(126, 28)
        Me.lblBotLowLimitPowerText.TabIndex = 558
        Me.lblBotLowLimitPowerText.Text = "限制輸出功率"
        Me.lblBotLowLimitPowerText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblBotLowLimitPowerText.Visible = False
        '
        'lblPercent08Text
        '
        Me.lblPercent08Text.BackColor = System.Drawing.Color.Transparent
        Me.lblPercent08Text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercent08Text.ForeColor = System.Drawing.Color.Black
        Me.lblPercent08Text.Location = New System.Drawing.Point(278, 267)
        Me.lblPercent08Text.Name = "lblPercent08Text"
        Me.lblPercent08Text.Size = New System.Drawing.Size(30, 24)
        Me.lblPercent08Text.TabIndex = 554
        Me.lblPercent08Text.Text = "%"
        Me.lblPercent08Text.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblPercent08Text.Visible = False
        '
        'txtBotLowLimitPower
        '
        Me.txtBotLowLimitPower.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBotLowLimitPower.Location = New System.Drawing.Point(217, 262)
        Me.txtBotLowLimitPower.Name = "txtBotLowLimitPower"
        Me.txtBotLowLimitPower.Size = New System.Drawing.Size(60, 29)
        Me.txtBotLowLimitPower.TabIndex = 556
        Me.txtBotLowLimitPower.Text = "0"
        Me.txtBotLowLimitPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtBotLowLimitPower.Visible = False
        '
        'lblBotTempD
        '
        Me.lblBotTempD.BackColor = System.Drawing.Color.Black
        Me.lblBotTempD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBotTempD.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBotTempD.ForeColor = System.Drawing.Color.Lime
        Me.lblBotTempD.Location = New System.Drawing.Point(6, 131)
        Me.lblBotTempD.Name = "lblBotTempD"
        Me.lblBotTempD.Size = New System.Drawing.Size(51, 29)
        Me.lblBotTempD.TabIndex = 300
        Me.lblBotTempD.Text = "0"
        Me.lblBotTempD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBotTempI
        '
        Me.lblBotTempI.BackColor = System.Drawing.Color.Black
        Me.lblBotTempI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBotTempI.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBotTempI.ForeColor = System.Drawing.Color.Lime
        Me.lblBotTempI.Location = New System.Drawing.Point(6, 99)
        Me.lblBotTempI.Name = "lblBotTempI"
        Me.lblBotTempI.Size = New System.Drawing.Size(51, 29)
        Me.lblBotTempI.TabIndex = 299
        Me.lblBotTempI.Text = "0"
        Me.lblBotTempI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBotTempP
        '
        Me.lblBotTempP.BackColor = System.Drawing.Color.Black
        Me.lblBotTempP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBotTempP.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBotTempP.ForeColor = System.Drawing.Color.Lime
        Me.lblBotTempP.Location = New System.Drawing.Point(6, 67)
        Me.lblBotTempP.Name = "lblBotTempP"
        Me.lblBotTempP.Size = New System.Drawing.Size(51, 29)
        Me.lblBotTempP.TabIndex = 298
        Me.lblBotTempP.Text = "0"
        Me.lblBotTempP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBotAT
        '
        Me.btnBotAT.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBotAT.Location = New System.Drawing.Point(78, 300)
        Me.btnBotAT.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnBotAT.Name = "btnBotAT"
        Me.btnBotAT.Size = New System.Drawing.Size(106, 37)
        Me.btnBotAT.TabIndex = 547
        Me.btnBotAT.Text = "Auto Tune"
        Me.btnBotAT.UseVisualStyleBackColor = True
        Me.btnBotAT.Visible = False
        '
        'btnBotPIDSave
        '
        Me.btnBotPIDSave.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBotPIDSave.Location = New System.Drawing.Point(196, 300)
        Me.btnBotPIDSave.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnBotPIDSave.Name = "btnBotPIDSave"
        Me.btnBotPIDSave.Size = New System.Drawing.Size(106, 37)
        Me.btnBotPIDSave.TabIndex = 546
        Me.btnBotPIDSave.Text = "Save PID"
        Me.btnBotPIDSave.UseVisualStyleBackColor = True
        '
        'txtBotMaxH
        '
        Me.txtBotMaxH.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBotMaxH.Location = New System.Drawing.Point(217, 163)
        Me.txtBotMaxH.Name = "txtBotMaxH"
        Me.txtBotMaxH.Size = New System.Drawing.Size(60, 29)
        Me.txtBotMaxH.TabIndex = 544
        Me.txtBotMaxH.Text = "0"
        Me.txtBotMaxH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBotMinH
        '
        Me.txtBotMinH.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBotMinH.Location = New System.Drawing.Point(217, 195)
        Me.txtBotMinH.Name = "txtBotMinH"
        Me.txtBotMinH.Size = New System.Drawing.Size(60, 29)
        Me.txtBotMinH.TabIndex = 545
        Me.txtBotMinH.Text = "0"
        Me.txtBotMinH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBotIM
        '
        Me.txtBotIM.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBotIM.Location = New System.Drawing.Point(151, 99)
        Me.txtBotIM.Name = "txtBotIM"
        Me.txtBotIM.Size = New System.Drawing.Size(60, 29)
        Me.txtBotIM.TabIndex = 519
        Me.txtBotIM.Text = "0"
        Me.txtBotIM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPercent03Text
        '
        Me.lblPercent03Text.BackColor = System.Drawing.Color.Transparent
        Me.lblPercent03Text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercent03Text.ForeColor = System.Drawing.Color.Black
        Me.lblPercent03Text.Location = New System.Drawing.Point(279, 165)
        Me.lblPercent03Text.Name = "lblPercent03Text"
        Me.lblPercent03Text.Size = New System.Drawing.Size(30, 24)
        Me.lblPercent03Text.TabIndex = 241
        Me.lblPercent03Text.Text = "%"
        Me.lblPercent03Text.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBotMaxM
        '
        Me.txtBotMaxM.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBotMaxM.Location = New System.Drawing.Point(151, 163)
        Me.txtBotMaxM.Name = "txtBotMaxM"
        Me.txtBotMaxM.Size = New System.Drawing.Size(60, 29)
        Me.txtBotMaxM.TabIndex = 542
        Me.txtBotMaxM.Text = "0"
        Me.txtBotMaxM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBotDM
        '
        Me.txtBotDM.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBotDM.Location = New System.Drawing.Point(151, 131)
        Me.txtBotDM.Name = "txtBotDM"
        Me.txtBotDM.Size = New System.Drawing.Size(60, 29)
        Me.txtBotDM.TabIndex = 520
        Me.txtBotDM.Text = "0"
        Me.txtBotDM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBotMinM
        '
        Me.txtBotMinM.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBotMinM.Location = New System.Drawing.Point(151, 195)
        Me.txtBotMinM.Name = "txtBotMinM"
        Me.txtBotMinM.Size = New System.Drawing.Size(60, 29)
        Me.txtBotMinM.TabIndex = 543
        Me.txtBotMinM.Text = "0"
        Me.txtBotMinM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblBotPText
        '
        Me.lblBotPText.BackColor = System.Drawing.Color.Transparent
        Me.lblBotPText.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBotPText.ForeColor = System.Drawing.Color.Black
        Me.lblBotPText.Location = New System.Drawing.Point(49, 69)
        Me.lblBotPText.Name = "lblBotPText"
        Me.lblBotPText.Size = New System.Drawing.Size(30, 24)
        Me.lblBotPText.TabIndex = 241
        Me.lblBotPText.Text = "P"
        Me.lblBotPText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBotPM
        '
        Me.txtBotPM.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBotPM.Location = New System.Drawing.Point(151, 67)
        Me.txtBotPM.Name = "txtBotPM"
        Me.txtBotPM.Size = New System.Drawing.Size(60, 29)
        Me.txtBotPM.TabIndex = 518
        Me.txtBotPM.Text = "0"
        Me.txtBotPM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBotHighRange
        '
        Me.txtBotHighRange.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBotHighRange.Location = New System.Drawing.Point(192, 32)
        Me.txtBotHighRange.Name = "txtBotHighRange"
        Me.txtBotHighRange.Size = New System.Drawing.Size(43, 29)
        Me.txtBotHighRange.TabIndex = 538
        Me.txtBotHighRange.Text = "000"
        Me.txtBotHighRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBotMinL
        '
        Me.txtBotMinL.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBotMinL.Location = New System.Drawing.Point(85, 195)
        Me.txtBotMinL.Name = "txtBotMinL"
        Me.txtBotMinL.Size = New System.Drawing.Size(60, 29)
        Me.txtBotMinL.TabIndex = 44
        Me.txtBotMinL.Text = "0"
        Me.txtBotMinL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBotLowRange
        '
        Me.txtBotLowRange.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBotLowRange.Location = New System.Drawing.Point(126, 32)
        Me.txtBotLowRange.Name = "txtBotLowRange"
        Me.txtBotLowRange.Size = New System.Drawing.Size(43, 29)
        Me.txtBotLowRange.TabIndex = 537
        Me.txtBotLowRange.Text = "0"
        Me.txtBotLowRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBotIH
        '
        Me.txtBotIH.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBotIH.Location = New System.Drawing.Point(217, 99)
        Me.txtBotIH.Name = "txtBotIH"
        Me.txtBotIH.Size = New System.Drawing.Size(60, 29)
        Me.txtBotIH.TabIndex = 522
        Me.txtBotIH.Text = "0"
        Me.txtBotIH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBotPL
        '
        Me.txtBotPL.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBotPL.Location = New System.Drawing.Point(85, 67)
        Me.txtBotPL.Name = "txtBotPL"
        Me.txtBotPL.Size = New System.Drawing.Size(60, 29)
        Me.txtBotPL.TabIndex = 4
        Me.txtBotPL.Text = "0"
        Me.txtBotPL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblBotRage3Text
        '
        Me.lblBotRage3Text.BackColor = System.Drawing.Color.Transparent
        Me.lblBotRage3Text.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBotRage3Text.ForeColor = System.Drawing.Color.Black
        Me.lblBotRage3Text.Location = New System.Drawing.Point(236, 34)
        Me.lblBotRage3Text.Name = "lblBotRage3Text"
        Me.lblBotRage3Text.Size = New System.Drawing.Size(29, 24)
        Me.lblBotRage3Text.TabIndex = 540
        Me.lblBotRage3Text.Text = "~"
        Me.lblBotRage3Text.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBotDH
        '
        Me.txtBotDH.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBotDH.Location = New System.Drawing.Point(217, 131)
        Me.txtBotDH.Name = "txtBotDH"
        Me.txtBotDH.Size = New System.Drawing.Size(60, 29)
        Me.txtBotDH.TabIndex = 523
        Me.txtBotDH.Text = "0"
        Me.txtBotDH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblBotRage2Text
        '
        Me.lblBotRage2Text.BackColor = System.Drawing.Color.Transparent
        Me.lblBotRage2Text.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBotRage2Text.ForeColor = System.Drawing.Color.Black
        Me.lblBotRage2Text.Location = New System.Drawing.Point(171, 34)
        Me.lblBotRage2Text.Name = "lblBotRage2Text"
        Me.lblBotRage2Text.Size = New System.Drawing.Size(22, 24)
        Me.lblBotRage2Text.TabIndex = 541
        Me.lblBotRage2Text.Text = "~"
        Me.lblBotRage2Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBotMaxPowerText
        '
        Me.lblBotMaxPowerText.BackColor = System.Drawing.Color.Transparent
        Me.lblBotMaxPowerText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBotMaxPowerText.ForeColor = System.Drawing.Color.Black
        Me.lblBotMaxPowerText.Location = New System.Drawing.Point(3, 166)
        Me.lblBotMaxPowerText.Name = "lblBotMaxPowerText"
        Me.lblBotMaxPowerText.Size = New System.Drawing.Size(79, 24)
        Me.lblBotMaxPowerText.TabIndex = 245
        Me.lblBotMaxPowerText.Text = "Max Pow:"
        Me.lblBotMaxPowerText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBotPH
        '
        Me.txtBotPH.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBotPH.Location = New System.Drawing.Point(217, 67)
        Me.txtBotPH.Name = "txtBotPH"
        Me.txtBotPH.Size = New System.Drawing.Size(60, 29)
        Me.txtBotPH.TabIndex = 521
        Me.txtBotPH.Text = "0"
        Me.txtBotPH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblBotRage1Text
        '
        Me.lblBotRage1Text.BackColor = System.Drawing.Color.Transparent
        Me.lblBotRage1Text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBotRage1Text.ForeColor = System.Drawing.Color.Black
        Me.lblBotRage1Text.Location = New System.Drawing.Point(88, 34)
        Me.lblBotRage1Text.Name = "lblBotRage1Text"
        Me.lblBotRage1Text.Size = New System.Drawing.Size(37, 24)
        Me.lblBotRage1Text.TabIndex = 539
        Me.lblBotRage1Text.Text = "0~"
        Me.lblBotRage1Text.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBotIL
        '
        Me.txtBotIL.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBotIL.Location = New System.Drawing.Point(85, 99)
        Me.txtBotIL.Name = "txtBotIL"
        Me.txtBotIL.Size = New System.Drawing.Size(60, 29)
        Me.txtBotIL.TabIndex = 14
        Me.txtBotIL.Text = "0"
        Me.txtBotIL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblBotArea1Text
        '
        Me.lblBotArea1Text.BackColor = System.Drawing.Color.Transparent
        Me.lblBotArea1Text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBotArea1Text.ForeColor = System.Drawing.Color.Black
        Me.lblBotArea1Text.Location = New System.Drawing.Point(83, 7)
        Me.lblBotArea1Text.Name = "lblBotArea1Text"
        Me.lblBotArea1Text.Size = New System.Drawing.Size(63, 24)
        Me.lblBotArea1Text.TabIndex = 530
        Me.lblBotArea1Text.Text = "Area1"
        Me.lblBotArea1Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBotDText
        '
        Me.lblBotDText.BackColor = System.Drawing.Color.Transparent
        Me.lblBotDText.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBotDText.ForeColor = System.Drawing.Color.Black
        Me.lblBotDText.Location = New System.Drawing.Point(49, 133)
        Me.lblBotDText.Name = "lblBotDText"
        Me.lblBotDText.Size = New System.Drawing.Size(30, 24)
        Me.lblBotDText.TabIndex = 243
        Me.lblBotDText.Text = "D"
        Me.lblBotDText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBotIText
        '
        Me.lblBotIText.BackColor = System.Drawing.Color.Transparent
        Me.lblBotIText.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBotIText.ForeColor = System.Drawing.Color.Black
        Me.lblBotIText.Location = New System.Drawing.Point(49, 101)
        Me.lblBotIText.Name = "lblBotIText"
        Me.lblBotIText.Size = New System.Drawing.Size(30, 24)
        Me.lblBotIText.TabIndex = 242
        Me.lblBotIText.Text = "I"
        Me.lblBotIText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBotArea2Text
        '
        Me.lblBotArea2Text.BackColor = System.Drawing.Color.Transparent
        Me.lblBotArea2Text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBotArea2Text.ForeColor = System.Drawing.Color.Black
        Me.lblBotArea2Text.Location = New System.Drawing.Point(151, 7)
        Me.lblBotArea2Text.Name = "lblBotArea2Text"
        Me.lblBotArea2Text.Size = New System.Drawing.Size(60, 24)
        Me.lblBotArea2Text.TabIndex = 530
        Me.lblBotArea2Text.Text = "Area2"
        Me.lblBotArea2Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBotMaxL
        '
        Me.txtBotMaxL.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBotMaxL.Location = New System.Drawing.Point(85, 163)
        Me.txtBotMaxL.Name = "txtBotMaxL"
        Me.txtBotMaxL.Size = New System.Drawing.Size(60, 29)
        Me.txtBotMaxL.TabIndex = 34
        Me.txtBotMaxL.Text = "0"
        Me.txtBotMaxL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPercent04Text
        '
        Me.lblPercent04Text.BackColor = System.Drawing.Color.Transparent
        Me.lblPercent04Text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercent04Text.ForeColor = System.Drawing.Color.Black
        Me.lblPercent04Text.Location = New System.Drawing.Point(278, 197)
        Me.lblPercent04Text.Name = "lblPercent04Text"
        Me.lblPercent04Text.Size = New System.Drawing.Size(30, 24)
        Me.lblPercent04Text.TabIndex = 241
        Me.lblPercent04Text.Text = "%"
        Me.lblPercent04Text.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBotDL
        '
        Me.txtBotDL.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBotDL.Location = New System.Drawing.Point(85, 131)
        Me.txtBotDL.Name = "txtBotDL"
        Me.txtBotDL.Size = New System.Drawing.Size(60, 29)
        Me.txtBotDL.TabIndex = 24
        Me.txtBotDL.Text = "0"
        Me.txtBotDL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblBotMinPowerText
        '
        Me.lblBotMinPowerText.BackColor = System.Drawing.Color.Transparent
        Me.lblBotMinPowerText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBotMinPowerText.ForeColor = System.Drawing.Color.Black
        Me.lblBotMinPowerText.Location = New System.Drawing.Point(3, 195)
        Me.lblBotMinPowerText.Name = "lblBotMinPowerText"
        Me.lblBotMinPowerText.Size = New System.Drawing.Size(79, 24)
        Me.lblBotMinPowerText.TabIndex = 246
        Me.lblBotMinPowerText.Text = "Min Pow:"
        Me.lblBotMinPowerText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBotArea3Text
        '
        Me.lblBotArea3Text.BackColor = System.Drawing.Color.Transparent
        Me.lblBotArea3Text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBotArea3Text.ForeColor = System.Drawing.Color.Black
        Me.lblBotArea3Text.Location = New System.Drawing.Point(215, 7)
        Me.lblBotArea3Text.Name = "lblBotArea3Text"
        Me.lblBotArea3Text.Size = New System.Drawing.Size(63, 24)
        Me.lblBotArea3Text.TabIndex = 530
        Me.lblBotArea3Text.Text = "Area3"
        Me.lblBotArea3Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpTitle
        '
        Me.grpTitle.BackColor = System.Drawing.SystemColors.Control
        Me.grpTitle.Controls.Add(Me.tabpagePID02)
        Me.grpTitle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.grpTitle.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTitle.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.grpTitle.Location = New System.Drawing.Point(0, 0)
        Me.grpTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.grpTitle.Name = "grpTitle"
        Me.grpTitle.Padding = New System.Windows.Forms.Padding(0)
        Me.grpTitle.Size = New System.Drawing.Size(319, 396)
        Me.grpTitle.TabIndex = 0
        Me.grpTitle.TabStop = False
        Me.grpTitle.Text = "PID Setup"
        Me.grpTitle.UseCompatibleTextRendering = True
        '
        'ControlTempPID
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.grpTitle)
        Me.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "ControlTempPID"
        Me.Size = New System.Drawing.Size(323, 398)
        Me.tabpagePID02.ResumeLayout(False)
        Me.tabpagePID01.ResumeLayout(False)
        Me.tabpagePID01.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picC06, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPageData.ResumeLayout(False)
        Me.tabPageData.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picC07, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTitle.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnTopAT As System.Windows.Forms.Button
    Friend WithEvents btnTopPIDSave As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txtTopHighRange As System.Windows.Forms.TextBox
    Friend WithEvents lblTopRage1Text As System.Windows.Forms.Label
    Friend WithEvents txtTopDH As System.Windows.Forms.TextBox
    Friend WithEvents txtTopMaxH As System.Windows.Forms.TextBox
    Friend WithEvents lblTopDText As System.Windows.Forms.Label
    Friend WithEvents lblTopIText As System.Windows.Forms.Label
    Friend WithEvents lblTopTempI As System.Windows.Forms.Label
    Friend WithEvents txtTopMinL As System.Windows.Forms.TextBox
    Friend WithEvents lblTopTempP As System.Windows.Forms.Label
    Friend WithEvents lblTopPText As System.Windows.Forms.Label
    Friend WithEvents lblTopMinPowerText As System.Windows.Forms.Label
    Friend WithEvents lblTopTempD As System.Windows.Forms.Label
    Friend WithEvents txtTopMaxL As System.Windows.Forms.TextBox
    Friend WithEvents txtTopIH As System.Windows.Forms.TextBox
    Friend WithEvents lblTopRage2Text As System.Windows.Forms.Label
    Friend WithEvents txtTopPH As System.Windows.Forms.TextBox
    Friend WithEvents txtTopMinH As System.Windows.Forms.TextBox
    Friend WithEvents lblTopArea3Text As System.Windows.Forms.Label
    Friend WithEvents txtTopPM As System.Windows.Forms.TextBox
    Friend WithEvents txtTopIM As System.Windows.Forms.TextBox
    Friend WithEvents lblTopArea1Text As System.Windows.Forms.Label
    Friend WithEvents txtTopIL As System.Windows.Forms.TextBox
    Friend WithEvents txtTopMinM As System.Windows.Forms.TextBox
    Friend WithEvents txtTopDL As System.Windows.Forms.TextBox
    Friend WithEvents txtTopPL As System.Windows.Forms.TextBox
    Friend WithEvents lblPercent01Text As System.Windows.Forms.Label
    Friend WithEvents lblTopMaxPowerText As System.Windows.Forms.Label
    Friend WithEvents lblPercent02Text As System.Windows.Forms.Label
    Friend WithEvents lblTopRage3Text As System.Windows.Forms.Label
    Friend WithEvents txtTopMaxM As System.Windows.Forms.TextBox
    Friend WithEvents txtTopLowRange As System.Windows.Forms.TextBox
    Friend WithEvents lblTopArea2Text As System.Windows.Forms.Label
    Friend WithEvents txtTopDM As System.Windows.Forms.TextBox
    Friend WithEvents tabpagePID02 As System.Windows.Forms.TabControl
    Friend WithEvents tabpagePID01 As System.Windows.Forms.TabPage
    Friend WithEvents tabPageData As System.Windows.Forms.TabPage
    Friend WithEvents txtBotMaxH As System.Windows.Forms.TextBox
    Friend WithEvents lblBotTempD As System.Windows.Forms.Label
    Friend WithEvents txtBotMinH As System.Windows.Forms.TextBox
    Friend WithEvents txtBotIM As System.Windows.Forms.TextBox
    Friend WithEvents lblPercent03Text As System.Windows.Forms.Label
    Friend WithEvents txtBotMaxM As System.Windows.Forms.TextBox
    Friend WithEvents txtBotDM As System.Windows.Forms.TextBox
    Friend WithEvents txtBotMinM As System.Windows.Forms.TextBox
    Friend WithEvents lblBotPText As System.Windows.Forms.Label
    Friend WithEvents txtBotPM As System.Windows.Forms.TextBox
    Friend WithEvents txtBotHighRange As System.Windows.Forms.TextBox
    Friend WithEvents txtBotMinL As System.Windows.Forms.TextBox
    Friend WithEvents txtBotLowRange As System.Windows.Forms.TextBox
    Friend WithEvents txtBotIH As System.Windows.Forms.TextBox
    Friend WithEvents txtBotPL As System.Windows.Forms.TextBox
    Friend WithEvents lblBotRage3Text As System.Windows.Forms.Label
    Friend WithEvents txtBotDH As System.Windows.Forms.TextBox
    Friend WithEvents lblBotRage2Text As System.Windows.Forms.Label
    Friend WithEvents lblBotMaxPowerText As System.Windows.Forms.Label
    Friend WithEvents txtBotPH As System.Windows.Forms.TextBox
    Friend WithEvents lblBotRage1Text As System.Windows.Forms.Label
    Friend WithEvents lblBotTempI As System.Windows.Forms.Label
    Friend WithEvents txtBotIL As System.Windows.Forms.TextBox
    Friend WithEvents lblBotArea1Text As System.Windows.Forms.Label
    Friend WithEvents lblBotDText As System.Windows.Forms.Label
    Friend WithEvents lblBotIText As System.Windows.Forms.Label
    Friend WithEvents lblBotTempP As System.Windows.Forms.Label
    Friend WithEvents lblBotArea2Text As System.Windows.Forms.Label
    Friend WithEvents txtBotMaxL As System.Windows.Forms.TextBox
    Friend WithEvents lblPercent04Text As System.Windows.Forms.Label
    Friend WithEvents txtBotDL As System.Windows.Forms.TextBox
    Friend WithEvents lblBotMinPowerText As System.Windows.Forms.Label
    Friend WithEvents lblBotArea3Text As System.Windows.Forms.Label
    Friend WithEvents btnBotAT As System.Windows.Forms.Button
    Friend WithEvents btnBotPIDSave As System.Windows.Forms.Button
    Friend WithEvents grpTitle As System.Windows.Forms.GroupBox
    Friend WithEvents picC06 As System.Windows.Forms.PictureBox
    Friend WithEvents lblTopLowLimitTempText As System.Windows.Forms.Label
    Friend WithEvents txtTopLowLimitTemp As System.Windows.Forms.TextBox
    Friend WithEvents lblTopLowLimitPowerText As System.Windows.Forms.Label
    Friend WithEvents lblPercent07Text As System.Windows.Forms.Label
    Friend WithEvents txtTopLowLimitPower As System.Windows.Forms.TextBox
    Friend WithEvents picC07 As System.Windows.Forms.PictureBox
    Friend WithEvents lblBotLowLimitTempText As System.Windows.Forms.Label
    Friend WithEvents txtBotLowLimitTemp As System.Windows.Forms.TextBox
    Friend WithEvents lblBotLowLimitPowerText As System.Windows.Forms.Label
    Friend WithEvents lblPercent08Text As System.Windows.Forms.Label
    Friend WithEvents txtBotLowLimitPower As System.Windows.Forms.TextBox
    Friend WithEvents lblTopCurrentPower As System.Windows.Forms.Label
    Friend WithEvents lblBotCurrentPower As System.Windows.Forms.Label
    Friend WithEvents btnTopHeater As System.Windows.Forms.Button
    Friend WithEvents txtTopTempSet As System.Windows.Forms.TextBox
    Friend WithEvents lblTopTemp As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents btnBotHeater As System.Windows.Forms.Button
    Friend WithEvents txtBotTempSet As System.Windows.Forms.TextBox
    Friend WithEvents lblBotTemp As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlProcessChart
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
        Me.chkTopTemp = New System.Windows.Forms.CheckBox()
        Me.chkBotTemp = New System.Windows.Forms.CheckBox()
        Me.chkPressure = New System.Windows.Forms.CheckBox()
        Me.chkPresetPress = New System.Windows.Forms.CheckBox()
        Me.chkPresetTemp = New System.Windows.Forms.CheckBox()
        Me.btnCurveReset = New System.Windows.Forms.Button()
        Me.btnPrintCurve = New System.Windows.Forms.Button()
        Me.btnCurveFreeze = New System.Windows.Forms.Button()
        Me.pnlProcessCSelect = New System.Windows.Forms.Panel()
        Me.lblAxis5 = New System.Windows.Forms.Label()
        Me.lblAxis4 = New System.Windows.Forms.Label()
        Me.lblAxis3 = New System.Windows.Forms.Label()
        Me.lblAxis2 = New System.Windows.Forms.Label()
        Me.lblAxis1 = New System.Windows.Forms.Label()
        Me.btnColor05 = New System.Windows.Forms.Button()
        Me.btnColor04 = New System.Windows.Forms.Button()
        Me.btnColor03 = New System.Windows.Forms.Button()
        Me.btnColor02 = New System.Windows.Forms.Button()
        Me.btnColor01 = New System.Windows.Forms.Button()
        Me.pnlControl = New System.Windows.Forms.Panel()
        Me.btnStopZoom = New System.Windows.Forms.Button()
        Me.btnSaveAs = New System.Windows.Forms.Button()
        Me.btnShowSeriesName = New System.Windows.Forms.Button()
        Me.pnlChart = New System.Windows.Forms.Panel()
        Me.ControlDataShowVertical1 = New CELLO.ControlDataShowVertical()
        Me.pnlProcessCSelect.SuspendLayout()
        Me.pnlControl.SuspendLayout()
        Me.pnlChart.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkTopTemp
        '
        Me.chkTopTemp.Checked = True
        Me.chkTopTemp.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTopTemp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.chkTopTemp.Location = New System.Drawing.Point(75, 3)
        Me.chkTopTemp.Name = "chkTopTemp"
        Me.chkTopTemp.Size = New System.Drawing.Size(105, 25)
        Me.chkTopTemp.TabIndex = 0
        Me.chkTopTemp.Text = "上溫度"
        Me.chkTopTemp.UseVisualStyleBackColor = True
        '
        'chkBotTemp
        '
        Me.chkBotTemp.Checked = True
        Me.chkBotTemp.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBotTemp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.chkBotTemp.Location = New System.Drawing.Point(75, 35)
        Me.chkBotTemp.Name = "chkBotTemp"
        Me.chkBotTemp.Size = New System.Drawing.Size(105, 25)
        Me.chkBotTemp.TabIndex = 1
        Me.chkBotTemp.Text = "下溫度"
        Me.chkBotTemp.UseVisualStyleBackColor = True
        '
        'chkPressure
        '
        Me.chkPressure.Checked = True
        Me.chkPressure.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPressure.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.chkPressure.Location = New System.Drawing.Point(75, 67)
        Me.chkPressure.Name = "chkPressure"
        Me.chkPressure.Size = New System.Drawing.Size(105, 25)
        Me.chkPressure.TabIndex = 2
        Me.chkPressure.Text = "壓合壓力"
        Me.chkPressure.UseVisualStyleBackColor = True
        '
        'chkPresetPress
        '
        Me.chkPresetPress.Checked = True
        Me.chkPresetPress.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPresetPress.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.chkPresetPress.Location = New System.Drawing.Point(75, 131)
        Me.chkPresetPress.Name = "chkPresetPress"
        Me.chkPresetPress.Size = New System.Drawing.Size(105, 25)
        Me.chkPresetPress.TabIndex = 4
        Me.chkPresetPress.Text = "預設壓力"
        Me.chkPresetPress.UseVisualStyleBackColor = True
        '
        'chkPresetTemp
        '
        Me.chkPresetTemp.Checked = True
        Me.chkPresetTemp.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPresetTemp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.chkPresetTemp.Location = New System.Drawing.Point(75, 99)
        Me.chkPresetTemp.Name = "chkPresetTemp"
        Me.chkPresetTemp.Size = New System.Drawing.Size(105, 25)
        Me.chkPresetTemp.TabIndex = 3
        Me.chkPresetTemp.Text = "預設溫度"
        Me.chkPresetTemp.UseVisualStyleBackColor = True
        '
        'btnCurveReset
        '
        Me.btnCurveReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCurveReset.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnCurveReset.Location = New System.Drawing.Point(3, 2)
        Me.btnCurveReset.Name = "btnCurveReset"
        Me.btnCurveReset.Size = New System.Drawing.Size(54, 35)
        Me.btnCurveReset.TabIndex = 539
        Me.btnCurveReset.Text = "重置"
        Me.btnCurveReset.UseVisualStyleBackColor = False
        '
        'btnPrintCurve
        '
        Me.btnPrintCurve.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPrintCurve.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnPrintCurve.Location = New System.Drawing.Point(191, 2)
        Me.btnPrintCurve.Name = "btnPrintCurve"
        Me.btnPrintCurve.Size = New System.Drawing.Size(54, 35)
        Me.btnPrintCurve.TabIndex = 540
        Me.btnPrintCurve.Text = "列印"
        Me.btnPrintCurve.UseVisualStyleBackColor = False
        '
        'btnCurveFreeze
        '
        Me.btnCurveFreeze.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCurveFreeze.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnCurveFreeze.Location = New System.Drawing.Point(278, 163)
        Me.btnCurveFreeze.Name = "btnCurveFreeze"
        Me.btnCurveFreeze.Size = New System.Drawing.Size(54, 35)
        Me.btnCurveFreeze.TabIndex = 542
        Me.btnCurveFreeze.Text = "凍結"
        Me.btnCurveFreeze.UseVisualStyleBackColor = False
        Me.btnCurveFreeze.Visible = False
        '
        'pnlProcessCSelect
        '
        Me.pnlProcessCSelect.Controls.Add(Me.lblAxis5)
        Me.pnlProcessCSelect.Controls.Add(Me.lblAxis4)
        Me.pnlProcessCSelect.Controls.Add(Me.lblAxis3)
        Me.pnlProcessCSelect.Controls.Add(Me.lblAxis2)
        Me.pnlProcessCSelect.Controls.Add(Me.lblAxis1)
        Me.pnlProcessCSelect.Controls.Add(Me.btnColor05)
        Me.pnlProcessCSelect.Controls.Add(Me.btnColor04)
        Me.pnlProcessCSelect.Controls.Add(Me.btnColor03)
        Me.pnlProcessCSelect.Controls.Add(Me.btnColor02)
        Me.pnlProcessCSelect.Controls.Add(Me.btnColor01)
        Me.pnlProcessCSelect.Controls.Add(Me.chkTopTemp)
        Me.pnlProcessCSelect.Controls.Add(Me.chkBotTemp)
        Me.pnlProcessCSelect.Controls.Add(Me.chkPressure)
        Me.pnlProcessCSelect.Controls.Add(Me.chkPresetTemp)
        Me.pnlProcessCSelect.Controls.Add(Me.chkPresetPress)
        Me.pnlProcessCSelect.Location = New System.Drawing.Point(65, 32)
        Me.pnlProcessCSelect.Name = "pnlProcessCSelect"
        Me.pnlProcessCSelect.Size = New System.Drawing.Size(187, 165)
        Me.pnlProcessCSelect.TabIndex = 543
        Me.pnlProcessCSelect.Visible = False
        '
        'lblAxis5
        '
        Me.lblAxis5.BackColor = System.Drawing.Color.White
        Me.lblAxis5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAxis5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAxis5.Location = New System.Drawing.Point(42, 131)
        Me.lblAxis5.Name = "lblAxis5"
        Me.lblAxis5.Size = New System.Drawing.Size(27, 25)
        Me.lblAxis5.TabIndex = 4
        Me.lblAxis5.Text = "1"
        Me.lblAxis5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAxis4
        '
        Me.lblAxis4.BackColor = System.Drawing.Color.White
        Me.lblAxis4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAxis4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAxis4.Location = New System.Drawing.Point(42, 99)
        Me.lblAxis4.Name = "lblAxis4"
        Me.lblAxis4.Size = New System.Drawing.Size(27, 25)
        Me.lblAxis4.TabIndex = 3
        Me.lblAxis4.Text = "1"
        Me.lblAxis4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAxis3
        '
        Me.lblAxis3.BackColor = System.Drawing.Color.White
        Me.lblAxis3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAxis3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAxis3.Location = New System.Drawing.Point(42, 67)
        Me.lblAxis3.Name = "lblAxis3"
        Me.lblAxis3.Size = New System.Drawing.Size(27, 25)
        Me.lblAxis3.TabIndex = 2
        Me.lblAxis3.Text = "1"
        Me.lblAxis3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAxis2
        '
        Me.lblAxis2.BackColor = System.Drawing.Color.White
        Me.lblAxis2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAxis2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAxis2.Location = New System.Drawing.Point(42, 35)
        Me.lblAxis2.Name = "lblAxis2"
        Me.lblAxis2.Size = New System.Drawing.Size(27, 25)
        Me.lblAxis2.TabIndex = 1
        Me.lblAxis2.Text = "1"
        Me.lblAxis2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAxis1
        '
        Me.lblAxis1.BackColor = System.Drawing.Color.White
        Me.lblAxis1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAxis1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAxis1.Location = New System.Drawing.Point(42, 3)
        Me.lblAxis1.Name = "lblAxis1"
        Me.lblAxis1.Size = New System.Drawing.Size(27, 25)
        Me.lblAxis1.TabIndex = 0
        Me.lblAxis1.Text = "1"
        Me.lblAxis1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnColor05
        '
        Me.btnColor05.BackColor = System.Drawing.Color.Gray
        Me.btnColor05.Location = New System.Drawing.Point(3, 131)
        Me.btnColor05.Name = "btnColor05"
        Me.btnColor05.Size = New System.Drawing.Size(33, 25)
        Me.btnColor05.TabIndex = 4
        Me.btnColor05.UseVisualStyleBackColor = False
        '
        'btnColor04
        '
        Me.btnColor04.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnColor04.Location = New System.Drawing.Point(3, 99)
        Me.btnColor04.Name = "btnColor04"
        Me.btnColor04.Size = New System.Drawing.Size(33, 25)
        Me.btnColor04.TabIndex = 3
        Me.btnColor04.UseVisualStyleBackColor = False
        '
        'btnColor03
        '
        Me.btnColor03.BackColor = System.Drawing.Color.Black
        Me.btnColor03.Location = New System.Drawing.Point(3, 67)
        Me.btnColor03.Name = "btnColor03"
        Me.btnColor03.Size = New System.Drawing.Size(33, 25)
        Me.btnColor03.TabIndex = 2
        Me.btnColor03.UseVisualStyleBackColor = False
        '
        'btnColor02
        '
        Me.btnColor02.BackColor = System.Drawing.Color.Blue
        Me.btnColor02.Location = New System.Drawing.Point(3, 35)
        Me.btnColor02.Name = "btnColor02"
        Me.btnColor02.Size = New System.Drawing.Size(33, 25)
        Me.btnColor02.TabIndex = 1
        Me.btnColor02.UseVisualStyleBackColor = False
        '
        'btnColor01
        '
        Me.btnColor01.BackColor = System.Drawing.Color.Red
        Me.btnColor01.Location = New System.Drawing.Point(3, 3)
        Me.btnColor01.Name = "btnColor01"
        Me.btnColor01.Size = New System.Drawing.Size(33, 25)
        Me.btnColor01.TabIndex = 0
        Me.btnColor01.UseVisualStyleBackColor = False
        '
        'pnlControl
        '
        Me.pnlControl.Controls.Add(Me.btnStopZoom)
        Me.pnlControl.Controls.Add(Me.btnSaveAs)
        Me.pnlControl.Controls.Add(Me.btnShowSeriesName)
        Me.pnlControl.Controls.Add(Me.btnCurveReset)
        Me.pnlControl.Controls.Add(Me.btnPrintCurve)
        Me.pnlControl.Location = New System.Drawing.Point(0, 200)
        Me.pnlControl.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlControl.Name = "pnlControl"
        Me.pnlControl.Size = New System.Drawing.Size(334, 39)
        Me.pnlControl.TabIndex = 544
        '
        'btnStopZoom
        '
        Me.btnStopZoom.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnStopZoom.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStopZoom.Location = New System.Drawing.Point(65, 2)
        Me.btnStopZoom.Name = "btnStopZoom"
        Me.btnStopZoom.Size = New System.Drawing.Size(54, 35)
        Me.btnStopZoom.TabIndex = 550
        Me.btnStopZoom.Text = "縮放"
        Me.btnStopZoom.UseVisualStyleBackColor = False
        '
        'btnSaveAs
        '
        Me.btnSaveAs.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSaveAs.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnSaveAs.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSaveAs.Location = New System.Drawing.Point(126, 2)
        Me.btnSaveAs.Name = "btnSaveAs"
        Me.btnSaveAs.Size = New System.Drawing.Size(54, 35)
        Me.btnSaveAs.TabIndex = 544
        Me.btnSaveAs.Text = "另存"
        Me.btnSaveAs.UseVisualStyleBackColor = False
        '
        'btnShowSeriesName
        '
        Me.btnShowSeriesName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnShowSeriesName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnShowSeriesName.Location = New System.Drawing.Point(255, 2)
        Me.btnShowSeriesName.Name = "btnShowSeriesName"
        Me.btnShowSeriesName.Size = New System.Drawing.Size(76, 35)
        Me.btnShowSeriesName.TabIndex = 543
        Me.btnShowSeriesName.Text = "選擇"
        Me.btnShowSeriesName.UseVisualStyleBackColor = False
        '
        'pnlChart
        '
        Me.pnlChart.Controls.Add(Me.ControlDataShowVertical1)
        Me.pnlChart.Controls.Add(Me.pnlProcessCSelect)
        Me.pnlChart.Controls.Add(Me.btnCurveFreeze)
        Me.pnlChart.Location = New System.Drawing.Point(0, 0)
        Me.pnlChart.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlChart.Name = "pnlChart"
        Me.pnlChart.Size = New System.Drawing.Size(332, 198)
        Me.pnlChart.TabIndex = 545
        '
        'ControlDataShowVertical1
        '
        Me.ControlDataShowVertical1.AutoSize = True
        Me.ControlDataShowVertical1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ControlDataShowVertical1.Location = New System.Drawing.Point(255, -1)
        Me.ControlDataShowVertical1.Margin = New System.Windows.Forms.Padding(0)
        Me.ControlDataShowVertical1.Name = "ControlDataShowVertical1"
        Me.ControlDataShowVertical1.Size = New System.Drawing.Size(77, 102)
        Me.ControlDataShowVertical1.TabIndex = 544
        '
        'ControlProcessChart
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.pnlControl)
        Me.Controls.Add(Me.pnlChart)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "ControlProcessChart"
        Me.Size = New System.Drawing.Size(332, 240)
        Me.pnlProcessCSelect.ResumeLayout(False)
        Me.pnlControl.ResumeLayout(False)
        Me.pnlChart.ResumeLayout(False)
        Me.pnlChart.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents chkTopTemp As System.Windows.Forms.CheckBox
    Friend WithEvents chkBotTemp As System.Windows.Forms.CheckBox
    Friend WithEvents chkPressure As System.Windows.Forms.CheckBox
    Friend WithEvents chkPresetPress As System.Windows.Forms.CheckBox
    Friend WithEvents chkPresetTemp As System.Windows.Forms.CheckBox
    Friend WithEvents btnCurveReset As System.Windows.Forms.Button
    Friend WithEvents btnPrintCurve As System.Windows.Forms.Button
    Friend WithEvents btnCurveFreeze As System.Windows.Forms.Button
    Friend WithEvents pnlProcessCSelect As System.Windows.Forms.Panel
    Friend WithEvents pnlControl As System.Windows.Forms.Panel
    Friend WithEvents btnColor05 As System.Windows.Forms.Button
    Friend WithEvents btnColor04 As System.Windows.Forms.Button
    Friend WithEvents btnColor03 As System.Windows.Forms.Button
    Friend WithEvents btnColor02 As System.Windows.Forms.Button
    Friend WithEvents btnColor01 As System.Windows.Forms.Button
    Friend WithEvents btnShowSeriesName As System.Windows.Forms.Button
    Friend WithEvents pnlChart As System.Windows.Forms.Panel
    Friend WithEvents btnSaveAs As System.Windows.Forms.Button
    Friend WithEvents ControlDataShowVertical1 As CELLO.ControlDataShowVertical
    Friend WithEvents btnStopZoom As System.Windows.Forms.Button
    Friend WithEvents lblAxis5 As System.Windows.Forms.Label
    Friend WithEvents lblAxis4 As System.Windows.Forms.Label
    Friend WithEvents lblAxis3 As System.Windows.Forms.Label
    Friend WithEvents lblAxis2 As System.Windows.Forms.Label
    Friend WithEvents lblAxis1 As System.Windows.Forms.Label

End Class

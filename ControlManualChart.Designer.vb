<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlManualChart
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
        Me.chkTopTemp = New System.Windows.Forms.CheckBox()
        Me.chkBotTemp = New System.Windows.Forms.CheckBox()
        Me.chkPressure = New System.Windows.Forms.CheckBox()
        Me.btnCurveReset = New System.Windows.Forms.Button()
        Me.btnPrintCurve = New System.Windows.Forms.Button()
        Me.pnlProcessCSelect = New System.Windows.Forms.Panel()
        Me.lblAxis5 = New System.Windows.Forms.Label()
        Me.btnColor05 = New System.Windows.Forms.Button()
        Me.chkMonTemp = New System.Windows.Forms.CheckBox()
        Me.lblAxis4 = New System.Windows.Forms.Label()
        Me.btnColor04 = New System.Windows.Forms.Button()
        Me.chkDAValue = New System.Windows.Forms.CheckBox()
        Me.lblAxis3 = New System.Windows.Forms.Label()
        Me.lblAxis2 = New System.Windows.Forms.Label()
        Me.lblAxis1 = New System.Windows.Forms.Label()
        Me.btnColor03 = New System.Windows.Forms.Button()
        Me.btnColor02 = New System.Windows.Forms.Button()
        Me.btnColor01 = New System.Windows.Forms.Button()
        Me.pnlControl = New System.Windows.Forms.Panel()
        Me.btnStopZoom = New System.Windows.Forms.Button()
        Me.btnSaveAs = New System.Windows.Forms.Button()
        Me.btnShowSeriesName = New System.Windows.Forms.Button()
        Me.pnlChart = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
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
        Me.chkTopTemp.Location = New System.Drawing.Point(72, 4)
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
        Me.chkBotTemp.Location = New System.Drawing.Point(72, 36)
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
        Me.chkPressure.Location = New System.Drawing.Point(72, 66)
        Me.chkPressure.Name = "chkPressure"
        Me.chkPressure.Size = New System.Drawing.Size(105, 25)
        Me.chkPressure.TabIndex = 2
        Me.chkPressure.Text = "壓合壓力"
        Me.chkPressure.UseVisualStyleBackColor = True
        '
        'btnCurveReset
        '
        Me.btnCurveReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCurveReset.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCurveReset.Location = New System.Drawing.Point(3, 1)
        Me.btnCurveReset.Name = "btnCurveReset"
        Me.btnCurveReset.Size = New System.Drawing.Size(54, 35)
        Me.btnCurveReset.TabIndex = 539
        Me.btnCurveReset.Text = "重置"
        Me.btnCurveReset.UseVisualStyleBackColor = False
        '
        'btnPrintCurve
        '
        Me.btnPrintCurve.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPrintCurve.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintCurve.Location = New System.Drawing.Point(190, 1)
        Me.btnPrintCurve.Name = "btnPrintCurve"
        Me.btnPrintCurve.Size = New System.Drawing.Size(54, 35)
        Me.btnPrintCurve.TabIndex = 540
        Me.btnPrintCurve.Text = "列印"
        Me.btnPrintCurve.UseVisualStyleBackColor = False
        '
        'pnlProcessCSelect
        '
        Me.pnlProcessCSelect.Controls.Add(Me.lblAxis4)
        Me.pnlProcessCSelect.Controls.Add(Me.btnColor04)
        Me.pnlProcessCSelect.Controls.Add(Me.chkDAValue)
        Me.pnlProcessCSelect.Controls.Add(Me.lblAxis3)
        Me.pnlProcessCSelect.Controls.Add(Me.btnColor03)
        Me.pnlProcessCSelect.Controls.Add(Me.chkPressure)
        Me.pnlProcessCSelect.Controls.Add(Me.lblAxis2)
        Me.pnlProcessCSelect.Controls.Add(Me.lblAxis1)
        Me.pnlProcessCSelect.Controls.Add(Me.btnColor02)
        Me.pnlProcessCSelect.Controls.Add(Me.btnColor01)
        Me.pnlProcessCSelect.Controls.Add(Me.chkTopTemp)
        Me.pnlProcessCSelect.Controls.Add(Me.chkBotTemp)
        Me.pnlProcessCSelect.Location = New System.Drawing.Point(67, 64)
        Me.pnlProcessCSelect.Name = "pnlProcessCSelect"
        Me.pnlProcessCSelect.Size = New System.Drawing.Size(195, 160)
        Me.pnlProcessCSelect.TabIndex = 543
        Me.pnlProcessCSelect.Visible = False
        '
        'lblAxis5
        '
        Me.lblAxis5.BackColor = System.Drawing.Color.White
        Me.lblAxis5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAxis5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAxis5.Location = New System.Drawing.Point(107, 190)
        Me.lblAxis5.Name = "lblAxis5"
        Me.lblAxis5.Size = New System.Drawing.Size(27, 25)
        Me.lblAxis5.TabIndex = 6
        Me.lblAxis5.Text = "1"
        Me.lblAxis5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblAxis5.Visible = False
        '
        'btnColor05
        '
        Me.btnColor05.BackColor = System.Drawing.Color.Blue
        Me.btnColor05.Location = New System.Drawing.Point(70, 192)
        Me.btnColor05.Name = "btnColor05"
        Me.btnColor05.Size = New System.Drawing.Size(33, 25)
        Me.btnColor05.TabIndex = 5
        Me.btnColor05.UseVisualStyleBackColor = False
        Me.btnColor05.Visible = False
        '
        'chkMonTemp
        '
        Me.chkMonTemp.Checked = True
        Me.chkMonTemp.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMonTemp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.chkMonTemp.Location = New System.Drawing.Point(140, 190)
        Me.chkMonTemp.Name = "chkMonTemp"
        Me.chkMonTemp.Size = New System.Drawing.Size(105, 25)
        Me.chkMonTemp.TabIndex = 4
        Me.chkMonTemp.Text = "下溫度"
        Me.chkMonTemp.UseVisualStyleBackColor = True
        Me.chkMonTemp.Visible = False
        '
        'lblAxis4
        '
        Me.lblAxis4.BackColor = System.Drawing.Color.White
        Me.lblAxis4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAxis4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAxis4.Location = New System.Drawing.Point(39, 97)
        Me.lblAxis4.Name = "lblAxis4"
        Me.lblAxis4.Size = New System.Drawing.Size(27, 25)
        Me.lblAxis4.TabIndex = 3
        Me.lblAxis4.Text = "1"
        Me.lblAxis4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnColor04
        '
        Me.btnColor04.BackColor = System.Drawing.Color.Purple
        Me.btnColor04.Location = New System.Drawing.Point(3, 97)
        Me.btnColor04.Name = "btnColor04"
        Me.btnColor04.Size = New System.Drawing.Size(33, 25)
        Me.btnColor04.TabIndex = 3
        Me.btnColor04.UseVisualStyleBackColor = False
        '
        'chkDAValue
        '
        Me.chkDAValue.Checked = True
        Me.chkDAValue.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDAValue.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.chkDAValue.Location = New System.Drawing.Point(72, 97)
        Me.chkDAValue.Name = "chkDAValue"
        Me.chkDAValue.Size = New System.Drawing.Size(120, 25)
        Me.chkDAValue.TabIndex = 3
        Me.chkDAValue.Text = "比例閥輸出"
        Me.chkDAValue.UseVisualStyleBackColor = True
        '
        'lblAxis3
        '
        Me.lblAxis3.BackColor = System.Drawing.Color.White
        Me.lblAxis3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAxis3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAxis3.Location = New System.Drawing.Point(39, 66)
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
        Me.lblAxis2.Location = New System.Drawing.Point(39, 36)
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
        Me.lblAxis1.Location = New System.Drawing.Point(39, 4)
        Me.lblAxis1.Name = "lblAxis1"
        Me.lblAxis1.Size = New System.Drawing.Size(27, 25)
        Me.lblAxis1.TabIndex = 0
        Me.lblAxis1.Text = "1"
        Me.lblAxis1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnColor03
        '
        Me.btnColor03.BackColor = System.Drawing.Color.Black
        Me.btnColor03.Location = New System.Drawing.Point(3, 66)
        Me.btnColor03.Name = "btnColor03"
        Me.btnColor03.Size = New System.Drawing.Size(33, 25)
        Me.btnColor03.TabIndex = 2
        Me.btnColor03.UseVisualStyleBackColor = False
        '
        'btnColor02
        '
        Me.btnColor02.BackColor = System.Drawing.Color.Blue
        Me.btnColor02.Location = New System.Drawing.Point(3, 36)
        Me.btnColor02.Name = "btnColor02"
        Me.btnColor02.Size = New System.Drawing.Size(33, 25)
        Me.btnColor02.TabIndex = 1
        Me.btnColor02.UseVisualStyleBackColor = False
        '
        'btnColor01
        '
        Me.btnColor01.BackColor = System.Drawing.Color.Red
        Me.btnColor01.Location = New System.Drawing.Point(3, 4)
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
        Me.pnlControl.Location = New System.Drawing.Point(0, 238)
        Me.pnlControl.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlControl.Name = "pnlControl"
        Me.pnlControl.Size = New System.Drawing.Size(332, 38)
        Me.pnlControl.TabIndex = 544
        '
        'btnStopZoom
        '
        Me.btnStopZoom.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnStopZoom.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStopZoom.Location = New System.Drawing.Point(67, 1)
        Me.btnStopZoom.Name = "btnStopZoom"
        Me.btnStopZoom.Size = New System.Drawing.Size(54, 35)
        Me.btnStopZoom.TabIndex = 549
        Me.btnStopZoom.Text = "縮放"
        Me.btnStopZoom.UseVisualStyleBackColor = False
        '
        'btnSaveAs
        '
        Me.btnSaveAs.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSaveAs.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveAs.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSaveAs.Location = New System.Drawing.Point(130, 1)
        Me.btnSaveAs.Name = "btnSaveAs"
        Me.btnSaveAs.Size = New System.Drawing.Size(54, 35)
        Me.btnSaveAs.TabIndex = 545
        Me.btnSaveAs.Text = "另存"
        Me.btnSaveAs.UseVisualStyleBackColor = False
        '
        'btnShowSeriesName
        '
        Me.btnShowSeriesName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnShowSeriesName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowSeriesName.Location = New System.Drawing.Point(250, 1)
        Me.btnShowSeriesName.Name = "btnShowSeriesName"
        Me.btnShowSeriesName.Size = New System.Drawing.Size(79, 35)
        Me.btnShowSeriesName.TabIndex = 543
        Me.btnShowSeriesName.Text = "選擇"
        Me.btnShowSeriesName.UseVisualStyleBackColor = False
        '
        'pnlChart
        '
        Me.pnlChart.Controls.Add(Me.lblAxis5)
        Me.pnlChart.Controls.Add(Me.btnColor05)
        Me.pnlChart.Controls.Add(Me.chkMonTemp)
        Me.pnlChart.Controls.Add(Me.ControlDataShowVertical1)
        Me.pnlChart.Controls.Add(Me.pnlProcessCSelect)
        Me.pnlChart.Location = New System.Drawing.Point(1, -2)
        Me.pnlChart.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlChart.Name = "pnlChart"
        Me.pnlChart.Size = New System.Drawing.Size(332, 238)
        Me.pnlChart.TabIndex = 545
        '
        'Timer1
        '
        '
        'ControlDataShowVertical1
        '
        Me.ControlDataShowVertical1.AutoSize = True
        Me.ControlDataShowVertical1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ControlDataShowVertical1.Location = New System.Drawing.Point(259, 0)
        Me.ControlDataShowVertical1.Margin = New System.Windows.Forms.Padding(0)
        Me.ControlDataShowVertical1.Name = "ControlDataShowVertical1"
        Me.ControlDataShowVertical1.Size = New System.Drawing.Size(77, 102)
        Me.ControlDataShowVertical1.TabIndex = 544
        '
        'ControlManualChart
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.pnlControl)
        Me.Controls.Add(Me.pnlChart)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "ControlManualChart"
        Me.Size = New System.Drawing.Size(336, 279)
        Me.pnlProcessCSelect.ResumeLayout(False)
        Me.pnlControl.ResumeLayout(False)
        Me.pnlChart.ResumeLayout(False)
        Me.pnlChart.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents chkTopTemp As System.Windows.Forms.CheckBox
    Friend WithEvents chkBotTemp As System.Windows.Forms.CheckBox
    Friend WithEvents chkPressure As System.Windows.Forms.CheckBox
    Friend WithEvents btnCurveReset As System.Windows.Forms.Button
    Friend WithEvents btnPrintCurve As System.Windows.Forms.Button
    Friend WithEvents pnlProcessCSelect As System.Windows.Forms.Panel
    Friend WithEvents pnlControl As System.Windows.Forms.Panel
    Friend WithEvents btnColor03 As System.Windows.Forms.Button
    Friend WithEvents btnColor02 As System.Windows.Forms.Button
    Friend WithEvents btnColor01 As System.Windows.Forms.Button
    Friend WithEvents btnShowSeriesName As System.Windows.Forms.Button
    Friend WithEvents pnlChart As System.Windows.Forms.Panel
    Friend WithEvents btnSaveAs As System.Windows.Forms.Button
    Friend WithEvents ControlDataShowVertical1 As CELLO.ControlDataShowVertical
    Friend WithEvents btnStopZoom As System.Windows.Forms.Button
    Friend WithEvents lblAxis3 As System.Windows.Forms.Label
    Friend WithEvents lblAxis2 As System.Windows.Forms.Label
    Friend WithEvents lblAxis1 As System.Windows.Forms.Label
    Friend WithEvents lblAxis4 As System.Windows.Forms.Label
    Friend WithEvents btnColor04 As System.Windows.Forms.Button
    Friend WithEvents chkDAValue As System.Windows.Forms.CheckBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblAxis5 As System.Windows.Forms.Label
    Friend WithEvents btnColor05 As System.Windows.Forms.Button
    Friend WithEvents chkMonTemp As System.Windows.Forms.CheckBox

End Class

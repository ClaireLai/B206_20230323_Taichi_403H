<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlProcessData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlProcessData))
        Me.lblStepTimeMin = New System.Windows.Forms.Label()
        Me.lblPresetTimeText = New System.Windows.Forms.Label()
        Me.lblHoldTimeSet = New System.Windows.Forms.Label()
        Me.lblSec02Text = New System.Windows.Forms.Label()
        Me.lblTotalStepSet = New System.Windows.Forms.Label()
        Me.lblKgSec01Text = New System.Windows.Forms.Label()
        Me.lblStepText = New System.Windows.Forms.Label()
        Me.lblKg02Text = New System.Windows.Forms.Label()
        Me.lblTempRateSet = New System.Windows.Forms.Label()
        Me.lblHoldTimeText = New System.Windows.Forms.Label()
        Me.lblSec03Text = New System.Windows.Forms.Label()
        Me.lblTempRateText = New System.Windows.Forms.Label()
        Me.lblPressureRateSet = New System.Windows.Forms.Label()
        Me.lblPressureSet = New System.Windows.Forms.Label()
        Me.lblPressRateText = New System.Windows.Forms.Label()
        Me.lblPressText = New System.Windows.Forms.Label()
        Me.lblTempSet = New System.Windows.Forms.Label()
        Me.lblTempText = New System.Windows.Forms.Label()
        Me.picC02 = New System.Windows.Forms.PictureBox()
        Me.picC01 = New System.Windows.Forms.PictureBox()
        Me.grpTitle = New System.Windows.Forms.GroupBox()
        Me.lblStepIndex = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.lblStepNote = New System.Windows.Forms.Label()
        Me.lblStepNoteText = New System.Windows.Forms.Label()
        Me.lblProcessStatus = New System.Windows.Forms.Label()
        CType(Me.picC02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picC01, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTitle.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblStepTimeMin
        '
        Me.lblStepTimeMin.BackColor = System.Drawing.Color.Black
        Me.lblStepTimeMin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStepTimeMin.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStepTimeMin.ForeColor = System.Drawing.Color.Cyan
        Me.lblStepTimeMin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStepTimeMin.Location = New System.Drawing.Point(112, 154)
        Me.lblStepTimeMin.Name = "lblStepTimeMin"
        Me.lblStepTimeMin.Size = New System.Drawing.Size(140, 22)
        Me.lblStepTimeMin.TabIndex = 536
        Me.lblStepTimeMin.Text = "0"
        Me.lblStepTimeMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPresetTimeText
        '
        Me.lblPresetTimeText.BackColor = System.Drawing.Color.Transparent
        Me.lblPresetTimeText.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPresetTimeText.ForeColor = System.Drawing.Color.Black
        Me.lblPresetTimeText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPresetTimeText.Location = New System.Drawing.Point(6, 154)
        Me.lblPresetTimeText.Name = "lblPresetTimeText"
        Me.lblPresetTimeText.Size = New System.Drawing.Size(103, 22)
        Me.lblPresetTimeText.TabIndex = 518
        Me.lblPresetTimeText.Text = "預計時間(s):"
        Me.lblPresetTimeText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHoldTimeSet
        '
        Me.lblHoldTimeSet.BackColor = System.Drawing.Color.Black
        Me.lblHoldTimeSet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHoldTimeSet.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lblHoldTimeSet.ForeColor = System.Drawing.Color.Cyan
        Me.lblHoldTimeSet.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblHoldTimeSet.Location = New System.Drawing.Point(112, 110)
        Me.lblHoldTimeSet.Name = "lblHoldTimeSet"
        Me.lblHoldTimeSet.Size = New System.Drawing.Size(79, 22)
        Me.lblHoldTimeSet.TabIndex = 532
        Me.lblHoldTimeSet.Text = "0"
        Me.lblHoldTimeSet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSec02Text
        '
        Me.lblSec02Text.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSec02Text.ForeColor = System.Drawing.Color.Black
        Me.lblSec02Text.Location = New System.Drawing.Point(217, 93)
        Me.lblSec02Text.Name = "lblSec02Text"
        Me.lblSec02Text.Size = New System.Drawing.Size(35, 16)
        Me.lblSec02Text.TabIndex = 535
        Me.lblSec02Text.Text = "/sec"
        '
        'lblTotalStepSet
        '
        Me.lblTotalStepSet.BackColor = System.Drawing.Color.Black
        Me.lblTotalStepSet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalStepSet.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lblTotalStepSet.ForeColor = System.Drawing.Color.Cyan
        Me.lblTotalStepSet.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTotalStepSet.Location = New System.Drawing.Point(112, 132)
        Me.lblTotalStepSet.Name = "lblTotalStepSet"
        Me.lblTotalStepSet.Size = New System.Drawing.Size(79, 22)
        Me.lblTotalStepSet.TabIndex = 520
        Me.lblTotalStepSet.Text = "0"
        Me.lblTotalStepSet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblKgSec01Text
        '
        Me.lblKgSec01Text.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKgSec01Text.ForeColor = System.Drawing.Color.Black
        Me.lblKgSec01Text.Location = New System.Drawing.Point(197, 44)
        Me.lblKgSec01Text.Name = "lblKgSec01Text"
        Me.lblKgSec01Text.Size = New System.Drawing.Size(55, 22)
        Me.lblKgSec01Text.TabIndex = 533
        Me.lblKgSec01Text.Text = "Kg/sec"
        '
        'lblStepText
        '
        Me.lblStepText.BackColor = System.Drawing.Color.Transparent
        Me.lblStepText.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStepText.ForeColor = System.Drawing.Color.Black
        Me.lblStepText.Location = New System.Drawing.Point(6, 132)
        Me.lblStepText.Name = "lblStepText"
        Me.lblStepText.Size = New System.Drawing.Size(103, 22)
        Me.lblStepText.TabIndex = 521
        Me.lblStepText.Text = "Step:"
        Me.lblStepText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblKg02Text
        '
        Me.lblKg02Text.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKg02Text.ForeColor = System.Drawing.Color.Black
        Me.lblKg02Text.Location = New System.Drawing.Point(197, 22)
        Me.lblKg02Text.Name = "lblKg02Text"
        Me.lblKg02Text.Size = New System.Drawing.Size(39, 22)
        Me.lblKg02Text.TabIndex = 534
        Me.lblKg02Text.Text = "Kg"
        '
        'lblTempRateSet
        '
        Me.lblTempRateSet.BackColor = System.Drawing.Color.Black
        Me.lblTempRateSet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTempRateSet.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lblTempRateSet.ForeColor = System.Drawing.Color.Cyan
        Me.lblTempRateSet.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTempRateSet.Location = New System.Drawing.Point(112, 88)
        Me.lblTempRateSet.Name = "lblTempRateSet"
        Me.lblTempRateSet.Size = New System.Drawing.Size(79, 22)
        Me.lblTempRateSet.TabIndex = 530
        Me.lblTempRateSet.Text = "0"
        Me.lblTempRateSet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHoldTimeText
        '
        Me.lblHoldTimeText.BackColor = System.Drawing.Color.Transparent
        Me.lblHoldTimeText.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoldTimeText.ForeColor = System.Drawing.Color.Black
        Me.lblHoldTimeText.Location = New System.Drawing.Point(6, 110)
        Me.lblHoldTimeText.Name = "lblHoldTimeText"
        Me.lblHoldTimeText.Size = New System.Drawing.Size(103, 22)
        Me.lblHoldTimeText.TabIndex = 519
        Me.lblHoldTimeText.Text = "保持時間:"
        Me.lblHoldTimeText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSec03Text
        '
        Me.lblSec03Text.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.lblSec03Text.ForeColor = System.Drawing.Color.Black
        Me.lblSec03Text.Location = New System.Drawing.Point(194, 110)
        Me.lblSec03Text.Name = "lblSec03Text"
        Me.lblSec03Text.Size = New System.Drawing.Size(32, 19)
        Me.lblSec03Text.TabIndex = 531
        Me.lblSec03Text.Text = "Sec"
        '
        'lblTempRateText
        '
        Me.lblTempRateText.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTempRateText.ForeColor = System.Drawing.Color.Black
        Me.lblTempRateText.Location = New System.Drawing.Point(6, 88)
        Me.lblTempRateText.Name = "lblTempRateText"
        Me.lblTempRateText.Size = New System.Drawing.Size(103, 22)
        Me.lblTempRateText.TabIndex = 529
        Me.lblTempRateText.Text = "溫度速率:"
        Me.lblTempRateText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPressureRateSet
        '
        Me.lblPressureRateSet.BackColor = System.Drawing.Color.Black
        Me.lblPressureRateSet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPressureRateSet.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lblPressureRateSet.ForeColor = System.Drawing.Color.Cyan
        Me.lblPressureRateSet.Location = New System.Drawing.Point(112, 44)
        Me.lblPressureRateSet.Name = "lblPressureRateSet"
        Me.lblPressureRateSet.Size = New System.Drawing.Size(79, 22)
        Me.lblPressureRateSet.TabIndex = 525
        Me.lblPressureRateSet.Text = "0"
        Me.lblPressureRateSet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPressureSet
        '
        Me.lblPressureSet.BackColor = System.Drawing.Color.Black
        Me.lblPressureSet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPressureSet.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lblPressureSet.ForeColor = System.Drawing.Color.Cyan
        Me.lblPressureSet.Location = New System.Drawing.Point(112, 22)
        Me.lblPressureSet.Name = "lblPressureSet"
        Me.lblPressureSet.Size = New System.Drawing.Size(79, 22)
        Me.lblPressureSet.TabIndex = 524
        Me.lblPressureSet.Text = "0"
        Me.lblPressureSet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPressRateText
        '
        Me.lblPressRateText.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPressRateText.ForeColor = System.Drawing.Color.Black
        Me.lblPressRateText.Location = New System.Drawing.Point(6, 44)
        Me.lblPressRateText.Name = "lblPressRateText"
        Me.lblPressRateText.Size = New System.Drawing.Size(103, 22)
        Me.lblPressRateText.TabIndex = 523
        Me.lblPressRateText.Text = "加壓速率:"
        Me.lblPressRateText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPressText
        '
        Me.lblPressText.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPressText.ForeColor = System.Drawing.Color.Black
        Me.lblPressText.Location = New System.Drawing.Point(6, 22)
        Me.lblPressText.Name = "lblPressText"
        Me.lblPressText.Size = New System.Drawing.Size(103, 22)
        Me.lblPressText.TabIndex = 522
        Me.lblPressText.Text = "壓頭壓力:"
        Me.lblPressText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTempSet
        '
        Me.lblTempSet.BackColor = System.Drawing.Color.Black
        Me.lblTempSet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTempSet.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lblTempSet.ForeColor = System.Drawing.Color.Cyan
        Me.lblTempSet.Location = New System.Drawing.Point(112, 66)
        Me.lblTempSet.Name = "lblTempSet"
        Me.lblTempSet.Size = New System.Drawing.Size(79, 22)
        Me.lblTempSet.TabIndex = 526
        Me.lblTempSet.Text = "0"
        Me.lblTempSet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTempText
        '
        Me.lblTempText.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTempText.ForeColor = System.Drawing.Color.Black
        Me.lblTempText.Location = New System.Drawing.Point(6, 66)
        Me.lblTempText.Name = "lblTempText"
        Me.lblTempText.Size = New System.Drawing.Size(103, 22)
        Me.lblTempText.TabIndex = 517
        Me.lblTempText.Text = "溫度:"
        Me.lblTempText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'picC02
        '
        Me.picC02.BackColor = System.Drawing.Color.Transparent
        Me.picC02.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picC02.Image = CType(resources.GetObject("picC02.Image"), System.Drawing.Image)
        Me.picC02.Location = New System.Drawing.Point(197, 88)
        Me.picC02.Name = "picC02"
        Me.picC02.Size = New System.Drawing.Size(20, 22)
        Me.picC02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picC02.TabIndex = 527
        Me.picC02.TabStop = False
        '
        'picC01
        '
        Me.picC01.BackColor = System.Drawing.Color.Transparent
        Me.picC01.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picC01.Image = CType(resources.GetObject("picC01.Image"), System.Drawing.Image)
        Me.picC01.Location = New System.Drawing.Point(197, 66)
        Me.picC01.Name = "picC01"
        Me.picC01.Size = New System.Drawing.Size(20, 22)
        Me.picC01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picC01.TabIndex = 528
        Me.picC01.TabStop = False
        '
        'grpTitle
        '
        Me.grpTitle.Controls.Add(Me.lblStepIndex)
        Me.grpTitle.Controls.Add(Me.btnNext)
        Me.grpTitle.Controls.Add(Me.btnPrev)
        Me.grpTitle.Controls.Add(Me.lblStepNote)
        Me.grpTitle.Controls.Add(Me.lblStepNoteText)
        Me.grpTitle.Controls.Add(Me.lblProcessStatus)
        Me.grpTitle.Controls.Add(Me.lblPressText)
        Me.grpTitle.Controls.Add(Me.lblStepTimeMin)
        Me.grpTitle.Controls.Add(Me.lblTempText)
        Me.grpTitle.Controls.Add(Me.lblPresetTimeText)
        Me.grpTitle.Controls.Add(Me.lblTempSet)
        Me.grpTitle.Controls.Add(Me.lblHoldTimeSet)
        Me.grpTitle.Controls.Add(Me.picC01)
        Me.grpTitle.Controls.Add(Me.lblSec02Text)
        Me.grpTitle.Controls.Add(Me.picC02)
        Me.grpTitle.Controls.Add(Me.lblTotalStepSet)
        Me.grpTitle.Controls.Add(Me.lblPressRateText)
        Me.grpTitle.Controls.Add(Me.lblKgSec01Text)
        Me.grpTitle.Controls.Add(Me.lblPressureSet)
        Me.grpTitle.Controls.Add(Me.lblStepText)
        Me.grpTitle.Controls.Add(Me.lblPressureRateSet)
        Me.grpTitle.Controls.Add(Me.lblKg02Text)
        Me.grpTitle.Controls.Add(Me.lblTempRateText)
        Me.grpTitle.Controls.Add(Me.lblTempRateSet)
        Me.grpTitle.Controls.Add(Me.lblSec03Text)
        Me.grpTitle.Controls.Add(Me.lblHoldTimeText)
        Me.grpTitle.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTitle.Location = New System.Drawing.Point(3, 3)
        Me.grpTitle.Name = "grpTitle"
        Me.grpTitle.Size = New System.Drawing.Size(257, 234)
        Me.grpTitle.TabIndex = 537
        Me.grpTitle.TabStop = False
        Me.grpTitle.Text = "Plate #01"
        '
        'lblStepIndex
        '
        Me.lblStepIndex.BackColor = System.Drawing.Color.Black
        Me.lblStepIndex.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStepIndex.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStepIndex.ForeColor = System.Drawing.Color.Cyan
        Me.lblStepIndex.Location = New System.Drawing.Point(191, 132)
        Me.lblStepIndex.Name = "lblStepIndex"
        Me.lblStepIndex.Size = New System.Drawing.Size(60, 22)
        Me.lblStepIndex.TabIndex = 543
        Me.lblStepIndex.Text = "0"
        Me.lblStepIndex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNext
        '
        Me.btnNext.Image = Global.CELLO.My.Resources.Resources.Right1
        Me.btnNext.Location = New System.Drawing.Point(215, 199)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(36, 32)
        Me.btnNext.TabIndex = 542
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrev
        '
        Me.btnPrev.Image = Global.CELLO.My.Resources.Resources.Left1
        Me.btnPrev.Location = New System.Drawing.Point(0, 199)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(36, 32)
        Me.btnPrev.TabIndex = 541
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'lblStepNote
        '
        Me.lblStepNote.BackColor = System.Drawing.Color.Black
        Me.lblStepNote.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStepNote.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStepNote.ForeColor = System.Drawing.Color.Cyan
        Me.lblStepNote.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStepNote.Location = New System.Drawing.Point(112, 177)
        Me.lblStepNote.Name = "lblStepNote"
        Me.lblStepNote.Size = New System.Drawing.Size(140, 22)
        Me.lblStepNote.TabIndex = 540
        Me.lblStepNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStepNoteText
        '
        Me.lblStepNoteText.BackColor = System.Drawing.Color.Transparent
        Me.lblStepNoteText.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStepNoteText.ForeColor = System.Drawing.Color.Black
        Me.lblStepNoteText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStepNoteText.Location = New System.Drawing.Point(6, 178)
        Me.lblStepNoteText.Name = "lblStepNoteText"
        Me.lblStepNoteText.Size = New System.Drawing.Size(103, 22)
        Me.lblStepNoteText.TabIndex = 539
        Me.lblStepNoteText.Text = "步驟註解:"
        Me.lblStepNoteText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblProcessStatus
        '
        Me.lblProcessStatus.BackColor = System.Drawing.Color.Black
        Me.lblProcessStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProcessStatus.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcessStatus.ForeColor = System.Drawing.Color.Cyan
        Me.lblProcessStatus.Location = New System.Drawing.Point(38, 201)
        Me.lblProcessStatus.Name = "lblProcessStatus"
        Me.lblProcessStatus.Size = New System.Drawing.Size(175, 30)
        Me.lblProcessStatus.TabIndex = 538
        '
        'ControlProcessData
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.grpTitle)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "ControlProcessData"
        Me.Size = New System.Drawing.Size(264, 240)
        CType(Me.picC02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picC01, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTitle.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblStepTimeMin As System.Windows.Forms.Label
    Friend WithEvents lblPresetTimeText As System.Windows.Forms.Label
    Friend WithEvents lblHoldTimeSet As System.Windows.Forms.Label
    Friend WithEvents lblSec02Text As System.Windows.Forms.Label
    Friend WithEvents lblTotalStepSet As System.Windows.Forms.Label
    Friend WithEvents lblKgSec01Text As System.Windows.Forms.Label
    Friend WithEvents lblStepText As System.Windows.Forms.Label
    Friend WithEvents lblKg02Text As System.Windows.Forms.Label
    Friend WithEvents lblTempRateSet As System.Windows.Forms.Label
    Friend WithEvents lblHoldTimeText As System.Windows.Forms.Label
    Friend WithEvents lblSec03Text As System.Windows.Forms.Label
    Friend WithEvents lblTempRateText As System.Windows.Forms.Label
    Friend WithEvents lblPressureRateSet As System.Windows.Forms.Label
    Friend WithEvents lblPressureSet As System.Windows.Forms.Label
    Friend WithEvents lblPressRateText As System.Windows.Forms.Label
    Friend WithEvents picC02 As System.Windows.Forms.PictureBox
    Friend WithEvents lblPressText As System.Windows.Forms.Label
    Friend WithEvents picC01 As System.Windows.Forms.PictureBox
    Friend WithEvents lblTempSet As System.Windows.Forms.Label
    Friend WithEvents lblTempText As System.Windows.Forms.Label
    Friend WithEvents grpTitle As System.Windows.Forms.GroupBox
    Friend WithEvents lblProcessStatus As System.Windows.Forms.Label
    Friend WithEvents lblStepNote As System.Windows.Forms.Label
    Friend WithEvents lblStepNoteText As System.Windows.Forms.Label
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnPrev As System.Windows.Forms.Button
    Friend WithEvents lblStepIndex As System.Windows.Forms.Label

End Class

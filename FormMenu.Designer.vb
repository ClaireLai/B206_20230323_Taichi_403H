<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenu
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenu))
        Me.flwMenu = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.btnProcessPara = New System.Windows.Forms.Button()
        Me.BtnTest = New System.Windows.Forms.Button()
        Me.btnAlarm = New System.Windows.Forms.Button()
        Me.btnRecord = New System.Windows.Forms.Button()
        Me.btnParameter = New System.Windows.Forms.Button()
        Me.btnFormLoginsetup = New System.Windows.Forms.Button()
        Me.btnMaintance = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblCurrentTime = New System.Windows.Forms.Label()
        Me.pnlRL = New System.Windows.Forms.Panel()
        Me.pnlYL = New System.Windows.Forms.Panel()
        Me.pnlGL = New System.Windows.Forms.Panel()
        Me.pnlBZ = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.flwMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'flwMenu
        '
        Me.flwMenu.Controls.Add(Me.btnProcess)
        Me.flwMenu.Controls.Add(Me.btnProcessPara)
        Me.flwMenu.Controls.Add(Me.BtnTest)
        Me.flwMenu.Controls.Add(Me.btnAlarm)
        Me.flwMenu.Controls.Add(Me.btnRecord)
        Me.flwMenu.Controls.Add(Me.btnParameter)
        Me.flwMenu.Controls.Add(Me.btnFormLoginsetup)
        Me.flwMenu.Controls.Add(Me.btnMaintance)
        Me.flwMenu.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.flwMenu.Location = New System.Drawing.Point(0, 0)
        Me.flwMenu.Margin = New System.Windows.Forms.Padding(0)
        Me.flwMenu.Name = "flwMenu"
        Me.flwMenu.Size = New System.Drawing.Size(821, 58)
        Me.flwMenu.TabIndex = 512
        '
        'btnProcess
        '
        Me.btnProcess.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnProcess.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProcess.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcess.ForeColor = System.Drawing.Color.Navy
        Me.btnProcess.Location = New System.Drawing.Point(0, 0)
        Me.btnProcess.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(102, 58)
        Me.btnProcess.TabIndex = 52
        Me.btnProcess.Text = "製程執行"
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'btnProcessPara
        '
        Me.btnProcessPara.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnProcessPara.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProcessPara.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcessPara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProcessPara.Location = New System.Drawing.Point(102, 0)
        Me.btnProcessPara.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcessPara.Name = "btnProcessPara"
        Me.btnProcessPara.Size = New System.Drawing.Size(102, 58)
        Me.btnProcessPara.TabIndex = 49
        Me.btnProcessPara.Text = "製程參數"
        Me.btnProcessPara.UseVisualStyleBackColor = True
        '
        'BtnTest
        '
        Me.BtnTest.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnTest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTest.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTest.Location = New System.Drawing.Point(204, 0)
        Me.BtnTest.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnTest.Name = "BtnTest"
        Me.BtnTest.Size = New System.Drawing.Size(102, 58)
        Me.BtnTest.TabIndex = 46
        Me.BtnTest.Text = "手動操作"
        Me.BtnTest.UseVisualStyleBackColor = True
        '
        'btnAlarm
        '
        Me.btnAlarm.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAlarm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAlarm.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlarm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAlarm.Location = New System.Drawing.Point(306, 0)
        Me.btnAlarm.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAlarm.Name = "btnAlarm"
        Me.btnAlarm.Size = New System.Drawing.Size(102, 58)
        Me.btnAlarm.TabIndex = 48
        Me.btnAlarm.Text = "異常訊息"
        Me.btnAlarm.UseVisualStyleBackColor = True
        '
        'btnRecord
        '
        Me.btnRecord.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRecord.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRecord.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRecord.Location = New System.Drawing.Point(408, 0)
        Me.btnRecord.Margin = New System.Windows.Forms.Padding(0)
        Me.btnRecord.Name = "btnRecord"
        Me.btnRecord.Size = New System.Drawing.Size(102, 58)
        Me.btnRecord.TabIndex = 47
        Me.btnRecord.Text = "系統記錄"
        Me.btnRecord.UseVisualStyleBackColor = True
        '
        'btnParameter
        '
        Me.btnParameter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnParameter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnParameter.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnParameter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnParameter.Location = New System.Drawing.Point(510, 0)
        Me.btnParameter.Margin = New System.Windows.Forms.Padding(0)
        Me.btnParameter.Name = "btnParameter"
        Me.btnParameter.Size = New System.Drawing.Size(105, 58)
        Me.btnParameter.TabIndex = 51
        Me.btnParameter.Text = "參數設定"
        Me.btnParameter.UseVisualStyleBackColor = True
        '
        'btnFormLoginsetup
        '
        Me.btnFormLoginsetup.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnFormLoginsetup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFormLoginsetup.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFormLoginsetup.Image = Global.CELLO.My.Resources.Resources.button
        Me.btnFormLoginsetup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFormLoginsetup.Location = New System.Drawing.Point(615, 0)
        Me.btnFormLoginsetup.Margin = New System.Windows.Forms.Padding(0)
        Me.btnFormLoginsetup.Name = "btnFormLoginsetup"
        Me.btnFormLoginsetup.Size = New System.Drawing.Size(102, 58)
        Me.btnFormLoginsetup.TabIndex = 45
        Me.btnFormLoginsetup.Text = "權限設定"
        Me.btnFormLoginsetup.UseVisualStyleBackColor = True
        '
        'btnMaintance
        '
        Me.btnMaintance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnMaintance.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMaintance.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaintance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMaintance.Location = New System.Drawing.Point(717, 0)
        Me.btnMaintance.Margin = New System.Windows.Forms.Padding(0)
        Me.btnMaintance.Name = "btnMaintance"
        Me.btnMaintance.Size = New System.Drawing.Size(102, 58)
        Me.btnMaintance.TabIndex = 56
        Me.btnMaintance.Text = "維修畫面"
        Me.btnMaintance.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(918, -1)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(102, 58)
        Me.btnExit.TabIndex = 511
        Me.btnExit.Text = "登出"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblCurrentTime
        '
        Me.lblCurrentTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblCurrentTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCurrentTime.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentTime.Location = New System.Drawing.Point(822, 5)
        Me.lblCurrentTime.Name = "lblCurrentTime"
        Me.lblCurrentTime.Size = New System.Drawing.Size(93, 28)
        Me.lblCurrentTime.TabIndex = 513
        Me.lblCurrentTime.Text = "00:00:00"
        Me.lblCurrentTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlRL
        '
        Me.pnlRL.BackColor = System.Drawing.Color.DarkRed
        Me.pnlRL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlRL.Location = New System.Drawing.Point(825, 36)
        Me.pnlRL.Name = "pnlRL"
        Me.pnlRL.Size = New System.Drawing.Size(22, 22)
        Me.pnlRL.TabIndex = 500
        '
        'pnlYL
        '
        Me.pnlYL.BackColor = System.Drawing.Color.Goldenrod
        Me.pnlYL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlYL.Location = New System.Drawing.Point(847, 36)
        Me.pnlYL.Name = "pnlYL"
        Me.pnlYL.Size = New System.Drawing.Size(22, 22)
        Me.pnlYL.TabIndex = 501
        '
        'pnlGL
        '
        Me.pnlGL.BackColor = System.Drawing.Color.DarkGreen
        Me.pnlGL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlGL.Location = New System.Drawing.Point(869, 36)
        Me.pnlGL.Name = "pnlGL"
        Me.pnlGL.Size = New System.Drawing.Size(22, 22)
        Me.pnlGL.TabIndex = 502
        '
        'pnlBZ
        '
        Me.pnlBZ.BackColor = System.Drawing.Color.DarkGray
        Me.pnlBZ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlBZ.Location = New System.Drawing.Point(891, 36)
        Me.pnlBZ.Name = "pnlBZ"
        Me.pnlBZ.Size = New System.Drawing.Size(22, 22)
        Me.pnlBZ.TabIndex = 514
        '
        'Timer1
        '
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'FormMenu
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1024, 58)
        Me.Controls.Add(Me.pnlBZ)
        Me.Controls.Add(Me.pnlGL)
        Me.Controls.Add(Me.pnlYL)
        Me.Controls.Add(Me.pnlRL)
        Me.Controls.Add(Me.lblCurrentTime)
        Me.Controls.Add(Me.flwMenu)
        Me.Controls.Add(Me.btnExit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Menu"
        Me.flwMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents flwMenu As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents btnProcessPara As System.Windows.Forms.Button
    Friend WithEvents BtnTest As System.Windows.Forms.Button
    Friend WithEvents btnAlarm As System.Windows.Forms.Button
    Friend WithEvents btnRecord As System.Windows.Forms.Button
    Friend WithEvents btnParameter As System.Windows.Forms.Button
    Friend WithEvents btnFormLoginsetup As System.Windows.Forms.Button
    Friend WithEvents btnMaintance As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblCurrentTime As System.Windows.Forms.Label
    Friend WithEvents pnlRL As System.Windows.Forms.Panel
    Friend WithEvents pnlYL As System.Windows.Forms.Panel
    Friend WithEvents pnlGL As System.Windows.Forms.Panel
    Friend WithEvents pnlBZ As System.Windows.Forms.Panel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ImageList1 As ImageList
End Class

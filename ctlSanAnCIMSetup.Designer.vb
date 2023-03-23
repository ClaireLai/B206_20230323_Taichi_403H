<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlSanAnCIMSetup
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
        Me.txtMachineNo = New System.Windows.Forms.TextBox()
        Me.lblMachineNoText = New System.Windows.Forms.Label()
        Me.pnlTCPIPProtocol = New System.Windows.Forms.Panel()
        Me.lblAlarmCode = New System.Windows.Forms.Label()
        Me.cmoAlarmType = New System.Windows.Forms.ComboBox()
        Me.cmoAlarmAction = New System.Windows.Forms.ComboBox()
        Me.cmoE2H_RPT_EVT = New System.Windows.Forms.ComboBox()
        Me.cmoE2H_RPT_ALM = New System.Windows.Forms.ComboBox()
        Me.cmoE2H_CHK_RSOL = New System.Windows.Forms.ComboBox()
        Me.lblIPAddressFormatText = New System.Windows.Forms.Label()
        Me.lblReceiveMessageText = New System.Windows.Forms.Label()
        Me.lblSendMessageText = New System.Windows.Forms.Label()
        Me.txtReceiveCommand = New System.Windows.Forms.TextBox()
        Me.txtSendCommad = New System.Windows.Forms.TextBox()
        Me.lblTestCommand = New System.Windows.Forms.Label()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.btnE2H_CHK_RSOL = New System.Windows.Forms.Button()
        Me.btnE2H_RPT_ALM = New System.Windows.Forms.Button()
        Me.btnE2H_RPT_EVT = New System.Windows.Forms.Button()
        Me.btnE2H_CHK_ALIVE = New System.Windows.Forms.Button()
        Me.btnCLear = New System.Windows.Forms.Button()
        Me.lblSec02Text = New System.Windows.Forms.Label()
        Me.lblServerTimeoutText = New System.Windows.Forms.Label()
        Me.txtServerTimeout = New System.Windows.Forms.TextBox()
        Me.lblServerIPText = New System.Windows.Forms.Label()
        Me.lblServerPortText = New System.Windows.Forms.Label()
        Me.txtServerIP = New System.Windows.Forms.TextBox()
        Me.txtServerPort = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.chkRunProcessConfirm = New System.Windows.Forms.CheckBox()
        Me.pnlTCPIPProtocol.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtMachineNo
        '
        Me.txtMachineNo.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMachineNo.Location = New System.Drawing.Point(218, 7)
        Me.txtMachineNo.Name = "txtMachineNo"
        Me.txtMachineNo.Size = New System.Drawing.Size(407, 29)
        Me.txtMachineNo.TabIndex = 695
        Me.txtMachineNo.Text = "IPE04"
        '
        'lblMachineNoText
        '
        Me.lblMachineNoText.BackColor = System.Drawing.Color.Transparent
        Me.lblMachineNoText.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMachineNoText.ForeColor = System.Drawing.Color.Black
        Me.lblMachineNoText.Location = New System.Drawing.Point(5, 4)
        Me.lblMachineNoText.Name = "lblMachineNoText"
        Me.lblMachineNoText.Size = New System.Drawing.Size(207, 34)
        Me.lblMachineNoText.TabIndex = 694
        Me.lblMachineNoText.Text = "機台編號:"
        Me.lblMachineNoText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlTCPIPProtocol
        '
        Me.pnlTCPIPProtocol.Controls.Add(Me.lblAlarmCode)
        Me.pnlTCPIPProtocol.Controls.Add(Me.cmoAlarmType)
        Me.pnlTCPIPProtocol.Controls.Add(Me.cmoAlarmAction)
        Me.pnlTCPIPProtocol.Controls.Add(Me.cmoE2H_RPT_EVT)
        Me.pnlTCPIPProtocol.Controls.Add(Me.cmoE2H_RPT_ALM)
        Me.pnlTCPIPProtocol.Controls.Add(Me.cmoE2H_CHK_RSOL)
        Me.pnlTCPIPProtocol.Controls.Add(Me.lblIPAddressFormatText)
        Me.pnlTCPIPProtocol.Controls.Add(Me.lblReceiveMessageText)
        Me.pnlTCPIPProtocol.Controls.Add(Me.lblSendMessageText)
        Me.pnlTCPIPProtocol.Controls.Add(Me.txtReceiveCommand)
        Me.pnlTCPIPProtocol.Controls.Add(Me.txtSendCommad)
        Me.pnlTCPIPProtocol.Controls.Add(Me.lblTestCommand)
        Me.pnlTCPIPProtocol.Controls.Add(Me.btnConnect)
        Me.pnlTCPIPProtocol.Controls.Add(Me.btnE2H_CHK_RSOL)
        Me.pnlTCPIPProtocol.Controls.Add(Me.btnE2H_RPT_ALM)
        Me.pnlTCPIPProtocol.Controls.Add(Me.btnE2H_RPT_EVT)
        Me.pnlTCPIPProtocol.Controls.Add(Me.btnE2H_CHK_ALIVE)
        Me.pnlTCPIPProtocol.Controls.Add(Me.btnCLear)
        Me.pnlTCPIPProtocol.Controls.Add(Me.lblSec02Text)
        Me.pnlTCPIPProtocol.Controls.Add(Me.lblServerTimeoutText)
        Me.pnlTCPIPProtocol.Controls.Add(Me.txtServerTimeout)
        Me.pnlTCPIPProtocol.Controls.Add(Me.lblServerIPText)
        Me.pnlTCPIPProtocol.Controls.Add(Me.lblServerPortText)
        Me.pnlTCPIPProtocol.Controls.Add(Me.txtServerIP)
        Me.pnlTCPIPProtocol.Controls.Add(Me.txtServerPort)
        Me.pnlTCPIPProtocol.Location = New System.Drawing.Point(9, 41)
        Me.pnlTCPIPProtocol.Name = "pnlTCPIPProtocol"
        Me.pnlTCPIPProtocol.Size = New System.Drawing.Size(1001, 498)
        Me.pnlTCPIPProtocol.TabIndex = 707
        '
        'lblAlarmCode
        '
        Me.lblAlarmCode.BackColor = System.Drawing.Color.Transparent
        Me.lblAlarmCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAlarmCode.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlarmCode.ForeColor = System.Drawing.Color.Black
        Me.lblAlarmCode.Location = New System.Drawing.Point(7, 451)
        Me.lblAlarmCode.Name = "lblAlarmCode"
        Me.lblAlarmCode.Size = New System.Drawing.Size(49, 29)
        Me.lblAlarmCode.TabIndex = 727
        Me.lblAlarmCode.Text = "000"
        Me.lblAlarmCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmoAlarmType
        '
        Me.cmoAlarmType.DropDownHeight = 120
        Me.cmoAlarmType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmoAlarmType.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmoAlarmType.FormattingEnabled = True
        Me.cmoAlarmType.IntegralHeight = False
        Me.cmoAlarmType.ItemHeight = 18
        Me.cmoAlarmType.Items.AddRange(New Object() {"Alarm", "Warning"})
        Me.cmoAlarmType.Location = New System.Drawing.Point(652, 453)
        Me.cmoAlarmType.Name = "cmoAlarmType"
        Me.cmoAlarmType.Size = New System.Drawing.Size(105, 26)
        Me.cmoAlarmType.TabIndex = 726
        '
        'cmoAlarmAction
        '
        Me.cmoAlarmAction.DropDownHeight = 120
        Me.cmoAlarmAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmoAlarmAction.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmoAlarmAction.FormattingEnabled = True
        Me.cmoAlarmAction.IntegralHeight = False
        Me.cmoAlarmAction.ItemHeight = 18
        Me.cmoAlarmAction.Items.AddRange(New Object() {"Occure", "Clear"})
        Me.cmoAlarmAction.Location = New System.Drawing.Point(541, 453)
        Me.cmoAlarmAction.Name = "cmoAlarmAction"
        Me.cmoAlarmAction.Size = New System.Drawing.Size(105, 26)
        Me.cmoAlarmAction.TabIndex = 725
        '
        'cmoE2H_RPT_EVT
        '
        Me.cmoE2H_RPT_EVT.DropDownHeight = 120
        Me.cmoE2H_RPT_EVT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmoE2H_RPT_EVT.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmoE2H_RPT_EVT.FormattingEnabled = True
        Me.cmoE2H_RPT_EVT.IntegralHeight = False
        Me.cmoE2H_RPT_EVT.ItemHeight = 18
        Me.cmoE2H_RPT_EVT.Items.AddRange(New Object() {"IDInputComplete", "ProcessStart", "ProcessEnd", "StepStart", "StepEnd"})
        Me.cmoE2H_RPT_EVT.Location = New System.Drawing.Point(768, 187)
        Me.cmoE2H_RPT_EVT.MaxDropDownItems = 5
        Me.cmoE2H_RPT_EVT.Name = "cmoE2H_RPT_EVT"
        Me.cmoE2H_RPT_EVT.Size = New System.Drawing.Size(230, 26)
        Me.cmoE2H_RPT_EVT.TabIndex = 724
        '
        'cmoE2H_RPT_ALM
        '
        Me.cmoE2H_RPT_ALM.DropDownHeight = 120
        Me.cmoE2H_RPT_ALM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmoE2H_RPT_ALM.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmoE2H_RPT_ALM.FormattingEnabled = True
        Me.cmoE2H_RPT_ALM.IntegralHeight = False
        Me.cmoE2H_RPT_ALM.ItemHeight = 18
        Me.cmoE2H_RPT_ALM.Location = New System.Drawing.Point(62, 453)
        Me.cmoE2H_RPT_ALM.Name = "cmoE2H_RPT_ALM"
        Me.cmoE2H_RPT_ALM.Size = New System.Drawing.Size(473, 26)
        Me.cmoE2H_RPT_ALM.TabIndex = 724
        '
        'cmoE2H_CHK_RSOL
        '
        Me.cmoE2H_CHK_RSOL.DropDownHeight = 120
        Me.cmoE2H_CHK_RSOL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmoE2H_CHK_RSOL.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmoE2H_CHK_RSOL.FormattingEnabled = True
        Me.cmoE2H_CHK_RSOL.IntegralHeight = False
        Me.cmoE2H_CHK_RSOL.ItemHeight = 18
        Me.cmoE2H_CHK_RSOL.Items.AddRange(New Object() {"LOCAL", "REMOTE"})
        Me.cmoE2H_CHK_RSOL.Location = New System.Drawing.Point(768, 330)
        Me.cmoE2H_CHK_RSOL.MaxDropDownItems = 2
        Me.cmoE2H_CHK_RSOL.Name = "cmoE2H_CHK_RSOL"
        Me.cmoE2H_CHK_RSOL.Size = New System.Drawing.Size(230, 26)
        Me.cmoE2H_CHK_RSOL.TabIndex = 724
        '
        'lblIPAddressFormatText
        '
        Me.lblIPAddressFormatText.BackColor = System.Drawing.Color.Transparent
        Me.lblIPAddressFormatText.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lblIPAddressFormatText.ForeColor = System.Drawing.Color.Black
        Me.lblIPAddressFormatText.Location = New System.Drawing.Point(159, 35)
        Me.lblIPAddressFormatText.Name = "lblIPAddressFormatText"
        Me.lblIPAddressFormatText.Size = New System.Drawing.Size(169, 23)
        Me.lblIPAddressFormatText.TabIndex = 723
        Me.lblIPAddressFormatText.Text = "ex: 192.168.0.1"
        Me.lblIPAddressFormatText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblReceiveMessageText
        '
        Me.lblReceiveMessageText.BackColor = System.Drawing.Color.Transparent
        Me.lblReceiveMessageText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblReceiveMessageText.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceiveMessageText.ForeColor = System.Drawing.Color.Black
        Me.lblReceiveMessageText.Location = New System.Drawing.Point(385, 50)
        Me.lblReceiveMessageText.Name = "lblReceiveMessageText"
        Me.lblReceiveMessageText.Size = New System.Drawing.Size(109, 29)
        Me.lblReceiveMessageText.TabIndex = 722
        Me.lblReceiveMessageText.Text = "Receive:"
        Me.lblReceiveMessageText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSendMessageText
        '
        Me.lblSendMessageText.BackColor = System.Drawing.Color.Transparent
        Me.lblSendMessageText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSendMessageText.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSendMessageText.ForeColor = System.Drawing.Color.Black
        Me.lblSendMessageText.Location = New System.Drawing.Point(3, 50)
        Me.lblSendMessageText.Name = "lblSendMessageText"
        Me.lblSendMessageText.Size = New System.Drawing.Size(109, 29)
        Me.lblSendMessageText.TabIndex = 721
        Me.lblSendMessageText.Text = "Send:"
        Me.lblSendMessageText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtReceiveCommand
        '
        Me.txtReceiveCommand.Font = New System.Drawing.Font("新細明體", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtReceiveCommand.Location = New System.Drawing.Point(385, 82)
        Me.txtReceiveCommand.Multiline = True
        Me.txtReceiveCommand.Name = "txtReceiveCommand"
        Me.txtReceiveCommand.Size = New System.Drawing.Size(377, 361)
        Me.txtReceiveCommand.TabIndex = 720
        '
        'txtSendCommad
        '
        Me.txtSendCommad.Font = New System.Drawing.Font("新細明體", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtSendCommad.Location = New System.Drawing.Point(3, 82)
        Me.txtSendCommad.Multiline = True
        Me.txtSendCommad.Name = "txtSendCommad"
        Me.txtSendCommad.Size = New System.Drawing.Size(377, 361)
        Me.txtSendCommad.TabIndex = 719
        '
        'lblTestCommand
        '
        Me.lblTestCommand.BackColor = System.Drawing.Color.Transparent
        Me.lblTestCommand.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTestCommand.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTestCommand.ForeColor = System.Drawing.Color.Black
        Me.lblTestCommand.Location = New System.Drawing.Point(796, 97)
        Me.lblTestCommand.Name = "lblTestCommand"
        Me.lblTestCommand.Size = New System.Drawing.Size(161, 29)
        Me.lblTestCommand.TabIndex = 718
        Me.lblTestCommand.Text = "Test Command"
        Me.lblTestCommand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnConnect
        '
        Me.btnConnect.BackColor = System.Drawing.Color.Pink
        Me.btnConnect.Location = New System.Drawing.Point(837, 3)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(161, 43)
        Me.btnConnect.TabIndex = 717
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = False
        '
        'btnE2H_CHK_RSOL
        '
        Me.btnE2H_CHK_RSOL.Location = New System.Drawing.Point(768, 362)
        Me.btnE2H_CHK_RSOL.Name = "btnE2H_CHK_RSOL"
        Me.btnE2H_CHK_RSOL.Size = New System.Drawing.Size(230, 38)
        Me.btnE2H_CHK_RSOL.TabIndex = 716
        Me.btnE2H_CHK_RSOL.Text = "E2H_CHK_RSOL"
        Me.btnE2H_CHK_RSOL.UseVisualStyleBackColor = True
        '
        'btnE2H_RPT_ALM
        '
        Me.btnE2H_RPT_ALM.Location = New System.Drawing.Point(768, 447)
        Me.btnE2H_RPT_ALM.Name = "btnE2H_RPT_ALM"
        Me.btnE2H_RPT_ALM.Size = New System.Drawing.Size(230, 38)
        Me.btnE2H_RPT_ALM.TabIndex = 715
        Me.btnE2H_RPT_ALM.Text = "E2H_RPT_ALM"
        Me.btnE2H_RPT_ALM.UseVisualStyleBackColor = True
        '
        'btnE2H_RPT_EVT
        '
        Me.btnE2H_RPT_EVT.Location = New System.Drawing.Point(768, 219)
        Me.btnE2H_RPT_EVT.Name = "btnE2H_RPT_EVT"
        Me.btnE2H_RPT_EVT.Size = New System.Drawing.Size(230, 38)
        Me.btnE2H_RPT_EVT.TabIndex = 714
        Me.btnE2H_RPT_EVT.Text = "E2H_RPT_EVT"
        Me.btnE2H_RPT_EVT.UseVisualStyleBackColor = True
        '
        'btnE2H_CHK_ALIVE
        '
        Me.btnE2H_CHK_ALIVE.Location = New System.Drawing.Point(768, 133)
        Me.btnE2H_CHK_ALIVE.Name = "btnE2H_CHK_ALIVE"
        Me.btnE2H_CHK_ALIVE.Size = New System.Drawing.Size(230, 38)
        Me.btnE2H_CHK_ALIVE.TabIndex = 713
        Me.btnE2H_CHK_ALIVE.Text = "E2H_CHK_ALIVE"
        Me.btnE2H_CHK_ALIVE.UseVisualStyleBackColor = True
        '
        'btnCLear
        '
        Me.btnCLear.Location = New System.Drawing.Point(687, 50)
        Me.btnCLear.Name = "btnCLear"
        Me.btnCLear.Size = New System.Drawing.Size(75, 30)
        Me.btnCLear.TabIndex = 712
        Me.btnCLear.Text = "Clear"
        Me.btnCLear.UseVisualStyleBackColor = True
        '
        'lblSec02Text
        '
        Me.lblSec02Text.BackColor = System.Drawing.Color.Transparent
        Me.lblSec02Text.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lblSec02Text.ForeColor = System.Drawing.Color.Black
        Me.lblSec02Text.Location = New System.Drawing.Point(724, 3)
        Me.lblSec02Text.Name = "lblSec02Text"
        Me.lblSec02Text.Size = New System.Drawing.Size(40, 29)
        Me.lblSec02Text.TabIndex = 709
        Me.lblSec02Text.Text = "sec"
        Me.lblSec02Text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblServerTimeoutText
        '
        Me.lblServerTimeoutText.BackColor = System.Drawing.Color.Transparent
        Me.lblServerTimeoutText.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServerTimeoutText.ForeColor = System.Drawing.Color.Black
        Me.lblServerTimeoutText.Location = New System.Drawing.Point(553, 3)
        Me.lblServerTimeoutText.Name = "lblServerTimeoutText"
        Me.lblServerTimeoutText.Size = New System.Drawing.Size(93, 29)
        Me.lblServerTimeoutText.TabIndex = 710
        Me.lblServerTimeoutText.Text = "Timeout:"
        Me.lblServerTimeoutText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtServerTimeout
        '
        Me.txtServerTimeout.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServerTimeout.Location = New System.Drawing.Point(652, 3)
        Me.txtServerTimeout.Name = "txtServerTimeout"
        Me.txtServerTimeout.Size = New System.Drawing.Size(66, 29)
        Me.txtServerTimeout.TabIndex = 711
        Me.txtServerTimeout.Text = "30"
        Me.txtServerTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblServerIPText
        '
        Me.lblServerIPText.BackColor = System.Drawing.Color.Transparent
        Me.lblServerIPText.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServerIPText.ForeColor = System.Drawing.Color.Black
        Me.lblServerIPText.Location = New System.Drawing.Point(3, 3)
        Me.lblServerIPText.Name = "lblServerIPText"
        Me.lblServerIPText.Size = New System.Drawing.Size(154, 29)
        Me.lblServerIPText.TabIndex = 684
        Me.lblServerIPText.Text = "Server IP:"
        Me.lblServerIPText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblServerPortText
        '
        Me.lblServerPortText.BackColor = System.Drawing.Color.Transparent
        Me.lblServerPortText.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServerPortText.ForeColor = System.Drawing.Color.Black
        Me.lblServerPortText.Location = New System.Drawing.Point(337, 3)
        Me.lblServerPortText.Name = "lblServerPortText"
        Me.lblServerPortText.Size = New System.Drawing.Size(91, 29)
        Me.lblServerPortText.TabIndex = 687
        Me.lblServerPortText.Text = "Port:"
        Me.lblServerPortText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtServerIP
        '
        Me.txtServerIP.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServerIP.Location = New System.Drawing.Point(163, 3)
        Me.txtServerIP.Name = "txtServerIP"
        Me.txtServerIP.Size = New System.Drawing.Size(165, 29)
        Me.txtServerIP.TabIndex = 685
        Me.txtServerIP.Text = "127.0.0.1"
        Me.txtServerIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtServerPort
        '
        Me.txtServerPort.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServerPort.Location = New System.Drawing.Point(434, 3)
        Me.txtServerPort.Name = "txtServerPort"
        Me.txtServerPort.Size = New System.Drawing.Size(103, 29)
        Me.txtServerPort.TabIndex = 686
        Me.txtServerPort.Text = "502"
        Me.txtServerPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Timer1
        '
        '
        'chkRunProcessConfirm
        '
        Me.chkRunProcessConfirm.Checked = True
        Me.chkRunProcessConfirm.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRunProcessConfirm.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRunProcessConfirm.ForeColor = System.Drawing.Color.Black
        Me.chkRunProcessConfirm.Location = New System.Drawing.Point(709, 4)
        Me.chkRunProcessConfirm.Name = "chkRunProcessConfirm"
        Me.chkRunProcessConfirm.Size = New System.Drawing.Size(298, 33)
        Me.chkRunProcessConfirm.TabIndex = 697
        Me.chkRunProcessConfirm.Text = "IN-LINE 製程執行確認"
        '
        'ctlSanAnCIMSetup
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.chkRunProcessConfirm)
        Me.Controls.Add(Me.pnlTCPIPProtocol)
        Me.Controls.Add(Me.txtMachineNo)
        Me.Controls.Add(Me.lblMachineNoText)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Name = "ctlSanAnCIMSetup"
        Me.Size = New System.Drawing.Size(1013, 542)
        Me.pnlTCPIPProtocol.ResumeLayout(False)
        Me.pnlTCPIPProtocol.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMachineNo As System.Windows.Forms.TextBox
    Friend WithEvents lblMachineNoText As System.Windows.Forms.Label
    Friend WithEvents pnlTCPIPProtocol As System.Windows.Forms.Panel
    Friend WithEvents btnCLear As System.Windows.Forms.Button
    Friend WithEvents lblSec02Text As System.Windows.Forms.Label
    Friend WithEvents lblServerTimeoutText As System.Windows.Forms.Label
    Friend WithEvents txtServerTimeout As System.Windows.Forms.TextBox
    Friend WithEvents lblServerIPText As System.Windows.Forms.Label
    Friend WithEvents lblServerPortText As System.Windows.Forms.Label
    Friend WithEvents txtServerIP As System.Windows.Forms.TextBox
    Friend WithEvents txtServerPort As System.Windows.Forms.TextBox
    Friend WithEvents lblTestCommand As System.Windows.Forms.Label
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents btnE2H_CHK_RSOL As System.Windows.Forms.Button
    Friend WithEvents btnE2H_RPT_ALM As System.Windows.Forms.Button
    Friend WithEvents btnE2H_RPT_EVT As System.Windows.Forms.Button
    Friend WithEvents btnE2H_CHK_ALIVE As System.Windows.Forms.Button
    Friend WithEvents lblReceiveMessageText As System.Windows.Forms.Label
    Friend WithEvents lblSendMessageText As System.Windows.Forms.Label
    Friend WithEvents txtReceiveCommand As System.Windows.Forms.TextBox
    Friend WithEvents txtSendCommad As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblIPAddressFormatText As System.Windows.Forms.Label
    Friend WithEvents cmoE2H_CHK_RSOL As System.Windows.Forms.ComboBox
    Friend WithEvents cmoE2H_RPT_EVT As System.Windows.Forms.ComboBox
    Friend WithEvents cmoE2H_RPT_ALM As System.Windows.Forms.ComboBox
    Friend WithEvents cmoAlarmType As System.Windows.Forms.ComboBox
    Friend WithEvents cmoAlarmAction As System.Windows.Forms.ComboBox
    Friend WithEvents lblAlarmCode As System.Windows.Forms.Label
    Friend WithEvents chkRunProcessConfirm As System.Windows.Forms.CheckBox

End Class

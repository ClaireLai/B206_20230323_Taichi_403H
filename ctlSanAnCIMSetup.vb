'Add by Vincent TCPIP 20200716    ------------- Start
#Region "SanAn CIM Function 20190710"
'Add By Vincent 20190710  ----------------------------------------------------------  Start
Imports System.Text.RegularExpressions

Public Class ctlSanAnCIMSetup
 

    Dim Lang As Integer = -1
    Private Sub ctlSanAnCIMSetup_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Me.DesignMode Then Exit Sub
        Dim i As Integer

        cmoE2H_CHK_RSOL.SelectedIndex = 0
        cmoE2H_RPT_EVT.SelectedIndex = 0


        cmoAlarmAction.SelectedIndex = 0
        cmoAlarmType.SelectedIndex = 0
        cmoE2H_RPT_ALM.Items.Clear()
        For i = 0 To Total_Alarm_Num
            cmoE2H_RPT_ALM.Items.Add(AlarmList1(SystemLanguage, i))
        Next
        cmoE2H_RPT_ALM.SelectedIndex = 0

        Timer1.Interval = 200
        Timer1.Enabled = True

    End Sub

    Private Delegate Sub UpdateUICallBack(ByVal newText As String, ByVal c As Control)
    Private Sub UpdateUI(ByVal newText As String, ByVal c As Control)
        If Me.InvokeRequired() Then
            Dim cb As New UpdateUICallBack(AddressOf UpdateUI)
            Me.Invoke(cb, newText, c)
        Else
            c.Text = newText
        End If
    End Sub
    Public Sub UpdateSendMessage(ByVal msg As String)
        UpdateUI(msg, txtSendCommad)
    End Sub
    Public Sub UpdateReceiveMessage(ByVal msg As String)
        UpdateUI(msg, txtReceiveCommand)
    End Sub
    Private Sub btnInLine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If Get_PLC_R1100(DAProgramVersionIndex) <> 1 Then
        '    If CelloUsbFlag = False Then
        '        MsgBoxLangErr("程式版本不同，不能執行!", "Program version not matched!")
        '        Exit Sub
        '    End If
        'End If
        If MsgBoxLangYesNo("是否要啟動遠端連線模式?", "Change mode to IN-LINE?") = True Then
            RemoteCIM.ChangeToInLine()
        End If
    End Sub

    Private Sub btnOffLine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MsgBoxLangYesNo("是否要停止遠端連線模式?", "Change mode to OFF-LINE?") = True Then
            RemoteCIM.ChangeToOffLine()
        End If
    End Sub

    Private Sub txtMachineNo_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtMachineNo.MouseDown
        If RemoteCIM.Enable Then Exit Sub
        If FormKeyboard1s.KeyInDir(sender) <> "" Then
            RemoteCIM._MachineNo = sender.Text
            RemoteCIM.EQID = RemoteCIM._MachineNo
            RemoteCIM.WriteINIFile()
            SanAnTCP.EQPID = RemoteCIM.EQID
        End If

    End Sub

    Private Sub lblRunNo_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If RemoteCIM.Enable Then Exit Sub
        If FormKeyboard2s.KeyInString(sender, "99", "1") <> "" Then
            RemoteCIM._Run_No = Val(sender.Text)
            RemoteCIM._Run_NoStr = Format(RemoteCIM._Run_No, "00")
            RemoteCIM._LastRun_No = RemoteCIM._Run_No
            RemoteCIM._LastRun_NoStr = Format(RemoteCIM._LastRun_No, "00")
            RemoteCIM.WriteRunNo()
        End If
    End Sub

    Private Sub chkRunProcessConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRunProcessConfirm.Click
        'If RemoteCIM.Enable Then Exit Sub
        RemoteCIM.ConfirmEnable = chkRunProcessConfirm.Checked
        RemoteCIM.WriteConfirmEnable()
    End Sub


    'Add By Vincent 20200716 for TCPIP
    Private Sub txtServerIP_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles txtServerIP.MouseDown
        Dim oldText As String = sender.Text
        If FormKeyBoardIP.KeyInIP(sender) <> "" Then
            If SanAnTCP.GetValidatedIP(sender.Text) Then
                SanAnTCP.ServerIP = sender.Text
                SanAnTCP.WriteTCPIPSetup()
            Else
                sender.Text = oldText
                MsgBoxLangErr("IP 位址格式錯誤", "IP address format error.")
            End If
        End If
    End Sub
    Private Sub txtServerPort_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles txtServerPort.MouseDown
        If FormKeyboard2s.KeyInString(sender, "65535", "1") <> "" Then
            SanAnTCP.ServerPort = sender.Text
            SanAnTCP.WriteTCPIPSetup()
        End If
    End Sub

    Private Sub txtServerTimeout_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles txtServerTimeout.MouseDown
        If FormKeyboard2s.KeyInString(sender, "10000", "1") <> "" Then
            SanAnTCP.ServerTimeOut = sender.Text
            If Val(SanAnTCP.ServerTimeOut) < 1 Then
                SanAnTCP.ServerTimeOut = "1"
            End If
            RemoteCIM.WriteCIMSetup()
            SanAnTCP.WriteTCPIPSetup()
        End If
    End Sub
    Private Sub btnCLear_Click(sender As System.Object, e As System.EventArgs) Handles btnCLear.Click
        txtSendCommad.Text = ""
        txtReceiveCommand.Text = ""
        TCP_SendMessage = ""
        TCP_ReceiveMessage = ""
    End Sub

    Private Sub btnConnect_Click(sender As System.Object, e As System.EventArgs) Handles btnConnect.Click
        If TCPIP_Used Then
            If SanAnTCP.ServerMode = False Then
                If SanAnTCP.Connected Then
                    SanAnTCP.CloseConnect()
                Else
                    SanAnTCP.ServerIP = txtServerIP.Text
                    SanAnTCP.ServerPort = txtServerPort.Text
                    SanAnTCP.ServerTimeOut = txtServerTimeout.Text
                    SanAnTCP.Connect(SanAnTCP.ServerIP, SanAnTCP.ServerPort)
                End If
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If SanAnTCP.ServerMode = False Then
            If SanAnTCP._Connection.IsConnected Then
                btnConnect.BackColor = Color.Lime
                btnConnect.Text = GetLangText("已連線", "Connected")
            Else
                btnConnect.BackColor = Color.Pink
                btnConnect.Text = GetLangText("連線", "Connect")
            End If
        Else
            If SanAnTCP._Connection.IsConnected Then
                btnConnect.BackColor = Color.Lime
                btnConnect.Text = GetLangText("已連線", "Connected")
            Else
                btnConnect.BackColor = Color.Pink
                btnConnect.Text = GetLangText("未連線", "Not Connect")
            End If
        End If

        txtReceiveCommand.Text = TCP_ReceiveMessage
        lblAlarmCode.Text = (cmoE2H_RPT_ALM.SelectedIndex + 1).ToString

        If RemoteCIM.Enable Then
            txtMachineNo.Enabled = False
            chkRunProcessConfirm.Enabled = False
        Else
            txtMachineNo.Enabled = True
            chkRunProcessConfirm.Enabled = True
        End If

    End Sub


    Private Sub btnE2H_CHK_ALIVE_Click(sender As System.Object, e As System.EventArgs) Handles btnE2H_CHK_ALIVE.Click
        If SanAnTCP.Connected Then

            txtReceiveCommand.Text = ""
            TCP_ReceiveMessage = ""
            SanAnTCP.E2H_CHK_ALIVE(RemoteCIM.EQID)

            'SendCommand(txtSendText.Text)
            'Dim xmlstr As String = SanAnTCP.E2H_CHK_ALIVE(RemoteCIM.EQID)
            'txtSendCommad.Text = xmlstr
            'txtReceiveCommand.Text = ""
            'TCP_ReceiveMessage = ""
            'SanAnTCP.Send(xmlstr)
            'txtReceiveCommand.Text = SanAnTCP.ReturnMessage
        Else
            MsgBoxLangErr("伺服器未連線.", "Server Not Connected")
        End If
    End Sub

    Private Sub btnE2H_RPT_EVT_Click(sender As System.Object, e As System.EventArgs) Handles btnE2H_RPT_EVT.Click
        If SanAnTCP.Connected Then

            txtReceiveCommand.Text = ""
            TCP_ReceiveMessage = ""
            Select Case cmoE2H_RPT_EVT.SelectedIndex
                Case 0
                    SanAnTCP.E2H_RPT_EVT(RemoteCIM.EQID, CSanAnTCPProcotol.REPORT_EVENT.IDInputComplete)
                Case 1
                    SanAnTCP.E2H_RPT_EVT(RemoteCIM.EQID, CSanAnTCPProcotol.REPORT_EVENT.ProcessStart)
                Case 2
                    SanAnTCP.E2H_RPT_EVT(RemoteCIM.EQID, CSanAnTCPProcotol.REPORT_EVENT.ProcessEnd)
                Case 3
                    SanAnTCP.E2H_RPT_EVT(RemoteCIM.EQID, CSanAnTCPProcotol.REPORT_EVENT.StepStart)
                Case 4
                    SanAnTCP.E2H_RPT_EVT(RemoteCIM.EQID, CSanAnTCPProcotol.REPORT_EVENT.StepEnd)
            End Select


            'SendCommand(txtSendText.Text)
            'Dim xmlstr As String = SanAnTCP.E2H_RPT_EVT(RemoteCIM.EQID)
            'txtSendCommad.Text = xmlstr
            'txtReceiveCommand.Text = ""
            'TCP_ReceiveMessage = ""
            'SanAnTCP.Send(xmlstr)
            'txtReceiveCommand.Text = SanAnTCP.ReturnMessage
        Else
            MsgBoxLangErr("伺服器未連線.", "Server Not Connected")
        End If
    End Sub

    Private Sub btnE2H_RPT_ALM_Click(sender As System.Object, e As System.EventArgs) Handles btnE2H_RPT_ALM.Click
        If SanAnTCP.Connected Then
            txtReceiveCommand.Text = ""
            TCP_ReceiveMessage = ""
            'SanAnTCP.E2H_RPT_ALM(RemoteCIM.EQID, (cmoE2H_RPT_ALM.SelectedIndex + 1), cmoE2H_RPT_ALM.SelectedItem, cmoAlarmType.SelectedIndex, cmoAlarmAction.SelectedIndex)
            SanAnTCP.E2H_RPT_ALM(RemoteCIM.EQID, (cmoE2H_RPT_ALM.SelectedIndex + 1), AlarmList1(2, cmoE2H_RPT_ALM.SelectedIndex), cmoAlarmType.SelectedIndex, cmoAlarmAction.SelectedIndex)

            'SendCommand(txtSendText.Text)
            'Dim xmlstr As String = SanAnTCP.E2H_RPT_ALM(RemoteCIM.EQID)
            'txtSendCommad.Text = xmlstr
            'txtReceiveCommand.Text = ""
            'TCP_ReceiveMessage = ""
            'SanAnTCP.Send(xmlstr)
            'txtReceiveCommand.Text = SanAnTCP.ReturnMessage
        Else
            MsgBoxLangErr("伺服器未連線.", "Server Not Connected")
        End If
    End Sub
    Private Sub btnE2H_CHK_RSOL_Click(sender As System.Object, e As System.EventArgs) Handles btnE2H_CHK_RSOL.Click
        If SanAnTCP.Connected Then
            txtReceiveCommand.Text = ""
            TCP_ReceiveMessage = ""

            Select Case cmoE2H_CHK_RSOL.SelectedIndex
                Case 0
                    SanAnTCP.E2H_CHK_RSOL(RemoteCIM.EQID, CSanAnTCPProcotol.RSOL_STATE.LOCAL)
                Case 1
                    SanAnTCP.E2H_CHK_RSOL(RemoteCIM.EQID, CSanAnTCPProcotol.RSOL_STATE.REMOTE)
            End Select
            'If RemoteCIM.Enable Then
            '    SanAnTCP.E2H_CHK_RSOL(RemoteCIM.EQID, CSanAnTCPProcotol.RSOL_STATE.LOCAL)
            'Else
            '    SanAnTCP.E2H_CHK_RSOL(RemoteCIM.EQID, CSanAnTCPProcotol.RSOL_STATE.REMOTE)
            'End If

            'SendCommand(txtSendText.Text)
            'Dim xmlstr As String = SanAnTCP.E2H_CHK_RSOL(RemoteCIM.EQID, CSanAnTCPProcotol.RSOL_STATE.LOCAL)
            'txtSendCommad.Text = xmlstr
            'txtReceiveCommand.Text = ""
            'TCP_ReceiveMessage = ""
            'SanAnTCP.Send(xmlstr)
            'txtReceiveCommand.Text = SanAnTCP.ReturnMessage
        Else
            MsgBoxLangErr("伺服器未連線.", "Server Not Connected")
        End If
    End Sub

End Class
#End Region
'Add by Vincent TCPIP 20200716    ------------- End
Public Class FormLicense

    Private Sub FormLicense_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        'Me.Width = 440
    End Sub

    Private Sub License_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Width = 440
        LC.SetNoticeCode(txtNoticeCode1, txtNoticeCode2, txtNoticeCode3)
        txtTrialDays.Text = LC.GetTrialDays
        Timer1.Interval = 1000
        Timer1.Enabled = True
    End Sub
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        LC.Register(txtRegisterCode1.Text, txtRegisterCode2.Text, txtRegisterCode3.Text)
        If LC.IsOK Then
            Me.Hide()
            FormLogins.ShowDialog()
        Else
            Me.Hide()
            Form1s.Show()
        End If
    End Sub

    Private Sub btnTry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTry.Click
        LC.SetTrial()
        btnTry.Visible = False
        FormLogins.txtUserName.Text = ""
        FormLogins.txtPassword.Text = ""
        Me.Hide()
        Form1s.Show()
    End Sub

    Private Sub RCode_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtRegisterCode1.MouseDown, txtRegisterCode2.MouseDown, txtRegisterCode3.MouseDown
        FormKeyBoard1s.KeyInString(sender)
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        btnTry.Visible = CelloUsbFlag ' Not LC.IsTrial
        pnlSpecial.Visible = CelloUsbFlag
        If CelloKeyFlag Then
            chkLicenseOK.Checked = LC.IsOK
            chkLicenseExpired.Checked = LC.IsExpired
            chkLicenseTrial.Checked = LC.IsTrial
            lblCurrentDate.Text = LC.GetLicenseDate
            lblRunDays.Text = LC.GetRunDays
            lblHDDSN.Text = LC.HDD_SN
            lblTotalMins.Text = LC.TotalRunTime.ToString
            lblCPUID.Text = LC.CPU_ID + "/" + LC.Reg_CPU_ID
            lblMBID.Text = LC.MB_ID + "/" + LC.Reg_MB_ID
            lblHDD1ID.Text = LC.HDD1_ID + "/" + LC.Reg_HDD1_ID
        Else
            Me.Width = 440
        End If
    End Sub
    Public Sub ShowInit()
        Me.Show()
        Timer1.Enabled = True
    End Sub

    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click
        LC.SetLicenseCode(txtRegisterCode1, txtRegisterCode2, txtRegisterCode3)
        'LC.Register(txtRegisterCode1.Text, txtRegisterCode2.Text, txtRegisterCode3.Text)
    End Sub

    Private Sub btnTrial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTrial.Click
        LC.SetTrial()
    End Sub

    Private Sub btnUnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnRegister.Click
        LC.UnRegister()
        txtRegisterCode1.Text = ""
        txtRegisterCode2.Text = ""
        txtRegisterCode3.Text = ""
        LC.GetTrialDays = txtTrialDays.Text
        LC.WriteTrialDays(LC.GetTrialDays)
        LC.TotalRunTime = 0
        LC.TotalRunTimeSet = LC.GetTrialDays * 1440
    End Sub

    Private Sub btnResetExpired_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResetExpired.Click
        LC.ResetExpired()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        LC.Refresh()
    End Sub

    Private Sub btnResetTrial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResetTrial.Click
        LC.ResetTrial()
    End Sub

    Private Sub picCelloLogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picCelloLogo.Click
        If CelloKeyFlag Then
            If Me.Width = 440 Then
                Me.Width = 730
            Else
                Me.Width = 440
            End If
        End If
    End Sub

    Private Sub btnSetExpired_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetExpired.Click
        LC.SetTrial()
        LC.SetExpiredDate(0)
    End Sub

    Private Sub txtTrialDays_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtTrialDays.MouseDown
        FormKeyboard2s.KeyInString(sender, "360", "0")
        LC.GetTrialDays = Val(sender.Text)
        LC.WriteTrialDays(LC.GetTrialDays)
    End Sub
End Class
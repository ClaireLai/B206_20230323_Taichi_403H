Public Class FormMsgBox
    Private Sub FormMsgBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        picCelloLogo.Visible = Program_Logo
    End Sub

    Private Sub btnYes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYes.Click
        If btnNo.Visible Then
            Me.DialogResult = vbYes
        Else
            Me.DialogResult = vbOK
        End If
        Set_MBit(DoBZIndex, DEVICE_OFF)
        Set_MBit(DoPressEndAlarmIndex, DEVICE_OFF)
        'BZ_Status = False
        Me.Close()
    End Sub

    Private Sub btnNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNo.Click
        Me.DialogResult = vbNo
        Me.Close()
    End Sub
End Class
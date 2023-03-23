Public Class FormAlarmPopup

    Private Sub btnBzReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBzReset.Click
        Set_MBit(DoBZIndex, DEVICE_OFF)
        Set_MBit(DoPressEndAlarmIndex, DEVICE_OFF)
        BZReset_Status = True
    End Sub

    Private Sub btnAlarmReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlarmReset.Click
        'Set_MBit(DoBZIndex, DEVICE_OFF)
        ClearAlarm()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Hide()
    End Sub
End Class
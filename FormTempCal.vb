Public Class FormTempCal

    Private Sub FormTempCal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'CreateTempCal(flwProcess1, 0, 7)
        'CreateTempCal(flwProcess2, 8, 15)
        Timer1.Interval = 500
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Hide()
    End Sub
End Class
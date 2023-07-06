Public Class FormMesgBox_passward
    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        'If btnNo.Visible Then
        '    Me.DialogResult = vbYes
        'Else
        '    Me.DialogResult = vbOK
        'End If
        If UCase(txtPassword.Text) = "CELLO" Then
            'Debug.Print(UCase(txtPassword.Text))
            Me.DialogResult = vbYes
            Me.Close()
        Else
            MessageBox.Show("密碼錯誤")
        End If

    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        Me.DialogResult = vbNo
        Me.Close()
    End Sub

    Private Sub txtPassword_MouseDown(sender As Object, e As MouseEventArgs) Handles txtPassword.MouseDown
        FormKeyboard1s.KeyInString(sender)
    End Sub
End Class
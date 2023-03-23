'Add by Vincent TCPIP 20200716    ------------- Start
Public Class FormBarcodeInput
    ReadOnly Property InputString
        Get
            Return txtEnterValue.Text
        End Get
    End Property

    Private Sub FormBarcodeInput_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtEnterValue.Text = ""
        txtEnterValue.SelectAll()
        txtEnterValue.Focus()
    End Sub

    Private Sub btnEnter_Click(sender As System.Object, e As System.EventArgs) Handles btnEnter.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub txtEnterValue_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtEnterValue.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class
'Add by Vincent TCPIP 20200716    ------------- End
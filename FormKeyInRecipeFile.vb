Public Class FormKeyInRecipeFile
    Private FileName As String
    Dim SameFile As String
    Property RecipeFileName() As String
        Get
            FileName = txtRecipeFileName.Text
            Return FileName
        End Get
        Set(ByVal value As String)
            FileName = value
            txtRecipeFileName.Text = value
        End Set
    End Property
    WriteOnly Property OldRecipeFileName() As String
        Set(ByVal value As String)
            SameFile = value
        End Set
    End Property

    Private Sub txtRecipeFileName_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtRecipeFileName.MouseDown
        CallKeyboard1(sender)
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        txtRecipeFileName.Text = ""
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        FileName = txtRecipeFileName.Text
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnSameRecipeFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSameRecipeFile.Click
        txtRecipeFileName.Text = SameFile
    End Sub
End Class
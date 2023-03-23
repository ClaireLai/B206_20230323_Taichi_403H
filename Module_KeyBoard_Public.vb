Module Module_KeyBoard_Public
    Public Function CallKeyboard1(ByRef obj As Object, Optional ByVal ClearText As Boolean = True) As String
        Dim sstr As String
        On Error Resume Next
        sstr = obj.Text
        If ClearText Then FormKeyboard1s.Value = ""
        If FormKeyboard1s.ShowDialog() = DialogResult.OK Then
            obj.Text = FormKeyboard1s.Value
            Return FormKeyboard1s.Value
        Else
            Return sstr
        End If
    End Function
    Public Function CallKeyboard2(ByRef obj As Object, ByVal vmax As String, ByVal vmmin As String) As String
        Dim sstr As String
        On Error Resume Next
        sstr = obj.Text
        FormKeyboard2s.Max = vmax
        FormKeyboard2s.Min = vmmin
        FormKeyboard2s.Value = ""
        If FormKeyboard2s.ShowDialog() = DialogResult.OK Then
            obj.Text = FormKeyboard2s.Value
            Return FormKeyboard2s.Value
        Else
            Return sstr
        End If
    End Function
    Public Function CallKeyboard3(ByRef obj As Object, ByVal vmax As String, ByVal vmmin As String) As String
        Dim sstr As String
        On Error Resume Next
        sstr = obj.Text
        FormKeyboard3s.Max = vmax
        FormKeyboard3s.Min = vmmin
        FormKeyboard3s.Value = ""
        If FormKeyboard3s.ShowDialog() = DialogResult.OK Then
            obj.Text = FormKeyboard3s.Value
            Return FormKeyboard3s.Value
        Else
            Return sstr
        End If
    End Function

    ' 以下為多載, 
    Public Function CallKeyboard1(ByRef obj As DataGridView, ByVal col As Integer, ByVal row As Integer, Optional ByVal ClearText As Boolean = True) As String
        Dim sstr As String
        Dim itype As Integer
        On Error Resume Next
        sstr = obj.Item(col, row).Value
        If ClearText Then
            FormKeyboard1s.Value = ""
        End If
        If FormKeyboard1s.ShowDialog() = DialogResult.OK Then
            obj.Item(col, row).Value = FormKeyboard1s.Value
            Return FormKeyboard1s.Value
        Else
            Return sstr
        End If
    End Function
    Public Function CallKeyboard2(ByRef obj As DataGridView, ByVal col As Integer, ByVal row As Integer, ByVal vmax As String, ByVal vmmin As String) As String
        Dim sstr As String
        On Error Resume Next
        sstr = obj.Item(col, row).Value
        FormKeyboard2s.Max = vmax
        FormKeyboard2s.Min = vmmin
        FormKeyboard2s.Value = ""
        If FormKeyboard2s.ShowDialog() = DialogResult.OK Then
            obj.Item(col, row).Value = FormKeyboard2s.Value
            Return FormKeyboard2s.Value
        Else
            Return sstr
        End If
    End Function
    Public Function CallKeyboard3(ByRef obj As DataGridView, ByVal col As Integer, ByVal row As Integer, ByVal vmax As String, ByVal vmmin As String) As String
        Dim sstr As String
        Dim itype As Integer
        On Error Resume Next
        sstr = obj.Item(col, row).Value
        FormKeyboard3s.Max = vmax
        FormKeyboard3s.Min = vmmin
        FormKeyboard3s.Value = ""
        If FormKeyboard3s.ShowDialog() = DialogResult.OK Then
            obj.Item(col, row).Value = FormKeyboard3s.Value
            Return FormKeyboard3s.Value
        Else
            Return sstr
        End If
    End Function
End Module

Module Module_Class_Display

    'Public RecipeFileName As String
    'Public VideoFileName As String


    'Public Function CallKeyboard1(ByRef obj As TextBox, Optional ByVal ClearText As Boolean = True) As String
    '    txtKeyboard1 = obj
    '    If ClearText Then FormKeyboard1s.txtEnterValue.Text = ""

    '    FormKeyboard1s.ShowDialog()
    '    If key_Enter = 1 Then CallKeyboard1 = txtKeyboard1.Text
    'End Function
    'Public Function CallKeyboard2(ByRef obj As TextBox, ByVal vmax As String, ByVal vmmin As String) As String
    '    txtKeyboard2 = obj
    '    FormKeyboard2s.lblMax.Text = vmax
    '    FormKeyboard2s.lblMin.Text = vmmin
    '    FormKeyboard2s.txtEnterValue.Text = ""
    '    FormKeyboard2s.ShowDialog()
    '    If key_Enter = 1 Then CallKeyboard2 = txtKeyboard2.Text
    'End Function
    'Public Function CallKeyboard3(ByRef obj As TextBox, ByVal vmax As String, ByVal vmmin As String)
    '    txtKeyboard3 = obj
    '    FormKeyboard3s.lblMax.Text = vmax
    '    FormKeyboard3s.lblMin.Text = vmmin
    '    FormKeyboard3s.txtEnterValue.Text = ""
    '    FormKeyboard3s.ShowDialog()
    '    If key_Enter = 1 Then CallKeyboard3 = txtKeyboard3.Text
    'End Function


    'Public Sub CallKeyboardD1(ByRef obj As DataGridView, ByVal col As Integer, ByVal row As Integer, Optional ByVal ClearText As Boolean = True)
    '    RecipeInput = 1
    '    If ClearText Then FormKeyboard1s.txtEnterValue.Text = ""
    '    txtKeyboardD1.Text = ""
    '    FormKeyboard1s.ShowDialog()
    '    If key_Enter = 1 Then obj.Item(col, row).Value = txtKeyboardD1.Text
    '    RecipeInput = 0
    'End Sub
    'Public Sub CallKeyboardD2(ByRef obj As DataGridView, ByVal col As Integer, ByVal row As Integer, ByVal vmax As String, ByVal vmmin As String)
    '    RecipeInput = 1
    '    FormKeyboard2s.lblMax.Text = vmax
    '    FormKeyboard2s.lblMin.Text = vmmin
    '    FormKeyboard2s.txtEnterValue.Text = ""
    '    txtKeyboardD2.Text = ""
    '    FormKeyboard2s.ShowDialog()
    '    If key_Enter = 1 Then obj.Item(col, row).Value = txtKeyboardD2.Text
    '    RecipeInput = 0
    'End Sub
    'Public Sub CallKeyboardD3(ByRef obj As DataGridView, ByVal col As Integer, ByVal row As Integer, ByVal vmax As String, ByVal vmmin As String)
    '    RecipeInput = 1
    '    FormKeyboard3s.lblMax.Text = vmax
    '    FormKeyboard3s.lblMin.Text = vmmin
    '    txtKeyboardD3.Text = ""
    '    FormKeyboard3s.ShowDialog()
    '    If key_Enter = 1 Then obj.Item(col, row).Value = txtKeyboardD3.Text
    '    RecipeInput = 0
    'End Sub
    'OUTPUT 類別    ---------------------------------START
    Public ObjShow As New IO_Show

    Public Class IO_Show
        Public Overloads Sub ShowVisible(ByVal Cond As Boolean, ByVal ParamArray obj() As Object)
            Dim i, ll As Integer
            ll = obj.Length - 1
            For i = 0 To ll
                obj(i).Visible = cond
            Next
        End Sub
        Public Overloads Sub Show(ByVal Cond As Boolean, ByRef obj As Object, ByVal onColor As Color, ByVal offColor As Color)
            If Cond Then
                obj.backcolor = onColor
            Else
                obj.backcolor = offColor
            End If
        End Sub
        Public Overloads Sub Show(ByVal Cond As Boolean, ByRef obj As Object, ByVal onColor As Color, ByVal ON_String As String, ByVal offColor As Color, ByVal OFF_String As String)
            If Cond Then
                obj.backcolor = onColor
                obj.text = ON_String
            Else
                obj.backcolor = offColor
                obj.text = OFF_String
            End If
        End Sub

        Public Overloads Sub Show(ByVal Cond As Boolean, ByRef obj As Object, ByVal ON_String As String, ByVal OFF_String As String)
            'On Error Resume Next
            If TypeName(obj) = "Label" Or TypeName(obj) = "Button" Or TypeName(obj) = "TextBox" Then
                If Cond Then
                    obj.text = ON_String
                Else
                    obj.text = OFF_String
                End If
            End If
            If TypeName(obj) = "PictureBox" Then
                If Cond Then
                    obj.Image = Bitmap.FromFile(WorkingDir + "bmp\" + ON_String)
                Else
                    obj.Image = Bitmap.FromFile(WorkingDir + "bmp\" + OFF_String)
                End If
            End If
        End Sub
        Public Overloads Sub Show(ByVal Cond As Boolean, ByRef obj As PictureBox, ByVal OnPic As PictureBox, ByVal OffPic As PictureBox)
            On Error Resume Next
            If Cond Then
                obj.Image = OnPic.Image
            Else
                obj.Image = OffPic.Image
            End If
        End Sub
        Public Overloads Sub Show(ByVal Cond As Boolean, ByRef obj As PictureBox, ByVal ON_Image As System.Drawing.Bitmap, ByVal OFF_Image As System.Drawing.Bitmap)
            On Error Resume Next
            If Cond Then
                obj.Image = ON_Image
            Else
                obj.Image = OFF_Image
            End If
        End Sub
        Public Overloads Sub Show(ByVal Changed As Boolean, ByVal Cond As Boolean, ByRef obj As Object, ByVal ON_String As String, ByVal OFF_String As String)
            'On Error Resume Next
            If Changed Then
                If TypeName(obj) = "Label" Or TypeName(obj) = "Button" Or TypeName(obj) = "TextBox" Then
                    If Cond Then
                        obj.text = ON_String
                    Else
                        obj.text = OFF_String
                    End If
                End If
                If TypeName(obj) = "PictureBox" Then
                    If Cond Then
                        obj.Image = Bitmap.FromFile(WorkingDir + "bmp\" + ON_String)
                    Else
                        obj.Image = Bitmap.FromFile(WorkingDir + "bmp\" + OFF_String)
                    End If
                End If
                Changed = False
            End If
        End Sub

        Public Overloads Sub Show3C3S(ByVal Cond As Integer, ByRef obj As Object, ByVal Color1 As Color, ByVal str1 As String, ByVal Color2 As Color, ByVal str2 As String, ByVal Color3 As Color, ByVal str3 As String)
            Select Case Cond
                Case 0
                    obj.backcolor = Color1
                    obj.text = str1
                Case 1
                    obj.backcolor = Color2
                    obj.text = str2
                Case 2
                    obj.backcolor = Color3
                    obj.text = str3
            End Select
        End Sub
        Public Overloads Sub Show(ByRef obj As Object, ByVal value As String)
            obj.text = value
        End Sub
        Public Overloads Sub Show(ByRef obj As Object, ByVal value As Integer)
            obj.text = value.ToString
        End Sub
        Public Overloads Sub Show(ByRef obj As Object, ByVal value As Long)
            obj.text = value.ToString
        End Sub
        Public Overloads Sub Show(ByRef obj As Object, ByVal value As Double)
            obj.text = value.ToString
        End Sub
        Public Overloads Sub Show(ByRef obj As Object, ByVal value As Single)
            obj.text = value.ToString
        End Sub
        Public Overloads Sub Show(ByRef obj As Object, ByVal value As Byte)
            obj.text = value.ToString
        End Sub

        Public Overloads Sub Show(ByVal sType As String, ByVal Index As Integer, ByRef obj As Object)
            Select Case sType
                Case "M"
                    If PLC_M(Index) = "1" Then
                        obj.visible = True
                    Else
                        obj.visible = False
                    End If
                Case "Y"
                    If PLC_Y(Index) = "1" Then
                        obj.visible = True
                    Else
                        obj.visible = False
                    End If
                Case "X"
                    If PLC_X(Index) = "1" Then
                        obj.visible = True
                    Else
                        obj.visible = False
                    End If
            End Select
        End Sub

        Public Overloads Sub Show(ByVal sType As String, ByVal Index As Integer, ByRef obj As Object, ByVal onColor As Color, ByVal offColor As Color)
            Select Case sType
                Case "M"
                    If PLC_M(Index) = "1" Then
                        obj.backcolor = onColor
                    Else
                        obj.backcolor = offColor
                    End If
                Case "Y"
                    If PLC_Y(Index) = "1" Then
                        obj.backcolor = onColor
                    Else
                        obj.backcolor = offColor
                    End If
                Case "X"
                    If PLC_X(Index) = "1" Then
                        obj.backcolor = onColor
                    Else
                        obj.backcolor = offColor
                    End If
            End Select
        End Sub

        Public Overloads Sub Show(ByVal sType As String, ByVal Index As Integer, ByRef obj As Object, ByVal ON_Image As String, ByVal OFF_Image As String)
            'On Error Resume Next
            If TypeName(obj) = "Label" Or TypeName(obj) = "Button" Or TypeName(obj) = "TextBox" Then
                Select Case sType
                    Case "M"
                        If PLC_M(Index) = "1" Then
                            obj.text = ON_Image
                        Else
                            obj.text = OFF_Image
                        End If
                    Case "Y"
                        If PLC_Y(Index) = "1" Then
                            obj.text = ON_Image
                        Else
                            obj.text = OFF_Image
                        End If
                    Case "X"
                        If PLC_X(Index) = "1" Then
                            obj.text = ON_Image
                        Else
                            obj.text = OFF_Image
                        End If
                End Select
            End If
            If TypeName(obj) = "PictureBox" Then
                Select Case sType
                    Case "M"
                        If PLC_M(Index) = "1" Then
                            obj.Image = Bitmap.FromFile(WorkingDir + "bmp\" + ON_Image)
                        Else
                            obj.Image = Bitmap.FromFile(WorkingDir + "bmp\" + OFF_Image)
                        End If
                    Case "Y"
                        If PLC_Y(Index) = "1" Then
                            obj.Image = Bitmap.FromFile(WorkingDir + "bmp\" + ON_Image)
                        Else
                            obj.Image = Bitmap.FromFile(WorkingDir + "bmp\" + OFF_Image)
                        End If
                    Case "X"
                        If PLC_X(Index) = "1" Then
                            obj.Image = Bitmap.FromFile(WorkingDir + "bmp\" + ON_Image)
                        Else
                            obj.Image = Bitmap.FromFile(WorkingDir + "bmp\" + OFF_Image)
                        End If
                End Select
            End If
        End Sub

        Public Overloads Sub Show(ByVal sType As String, ByVal Index As Integer, ByRef obj As Object, ByVal onColor As Color, ByVal onstr As String, ByVal offColor As Color, ByVal offstr As String)
            Select Case sType
                Case "M"
                    If PLC_M(Index) = "1" Then
                        obj.backcolor = onColor
                        obj.text = onstr
                    Else
                        obj.backcolor = offColor
                        obj.text = offstr
                    End If
                Case "Y"
                    If PLC_Y(Index) = "1" Then
                        obj.backcolor = onColor
                        obj.text = onstr
                    Else
                        obj.backcolor = offColor
                        obj.text = offstr
                    End If
                Case "X"
                    If PLC_X(Index) = "1" Then
                        obj.backcolor = onColor
                        obj.text = onstr
                    Else
                        obj.backcolor = offColor
                        obj.text = offstr
                    End If
            End Select
        End Sub

    End Class
End Module

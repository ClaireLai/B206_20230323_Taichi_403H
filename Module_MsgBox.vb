Module Module_MsgBox
    'Add by Vincent TCPIP 20200716    ------------- Start
    Public Function GetLangText(ByVal strCht As String) As String
        Return strCht   '設定為繁中
    End Function
    'Add by Vincent TCPIP 20200716    ------------- End
    '傳回文字訊息至,並提供3語的文字 
    Public Function GetLangText(ByVal strCht As String, ByVal strChs As String, ByVal strEng As String) As String
        Select Case SystemLanguage
            Case 0
                Return strCht   '設定為繁中
            Case 1
                Return StrConv(strCht, VbStrConv.SimplifiedChinese, 2052)    '設定為簡中    '設定
            Case Else
                Return strEng    '設定為英文
        End Select
    End Function
    '傳回文字訊息至,並提供3語的文字 
    Public Function GetLangText(ByVal strCht As String, ByVal strEng As String) As String
        Select Case SystemLanguage
            Case 0
                Return strCht   '設定為繁中
            Case 1
                Return StrConv(strCht, VbStrConv.SimplifiedChinese, 2052)    '設定為簡中    '設定為簡中
            Case Else
                Return strEng    '設定為英文
        End Select
    End Function
    '顯示文字訊息至 物件(具有 TEXT 屬性),並提供3語的文字 
    Public Function GetLangText(ByVal obj As Object, ByVal strCht As String, ByVal strChs As String, ByVal strEng As String) As String
        Select Case SystemLanguage
            Case 0
                Return strCht   '設定為繁中
            Case 1
                Return StrConv(strCht, VbStrConv.SimplifiedChinese, 2052)    '設定為簡中    '設定
            Case 2
                Return strEng    '設定為英文
        End Select
    End Function
    '顯示文字訊息至 物件(具有 TEXT 屬性),並提供3語的文字 
    Public Function GetLangText(ByVal obj As Object, ByVal strCht As String, ByVal strEng As String) As String
        Select Case SystemLanguage
            Case 0
                Return strCht   '設定為繁中
            Case 1
                Return StrConv(strCht, VbStrConv.SimplifiedChinese, 2052)    '設定為簡中    '設定為簡中
            Case 2
                Return strEng    '設定為英文
        End Select
    End Function
    '顯示文字訊息至 物件(具有 TEXT 屬性),並提供3語的文字 
    Public Sub SetLangText(ByVal obj As Object, ByVal strCht As String, ByVal strChs As String, ByVal strEng As String)
        Select Case SystemLanguage
            Case 0
                obj.Text = strCht   '設定為繁中
            Case 1
                obj.Text = StrConv(strCht, VbStrConv.SimplifiedChinese, 2052)        '設定為簡中
            Case 2
                obj.Text = strEng    '設定為英文
        End Select
    End Sub
    '顯示文字訊息至 物件(具有 TEXT 屬性),並提供3語的文字 
    Public Sub SetLangText(ByVal obj As Object, ByVal strCht As String, ByVal strEng As String)
        Select Case SystemLanguage
            Case 0
                obj.Text = strCht   '設定為繁中
            Case 1
                obj.Text = StrConv(strCht, VbStrConv.SimplifiedChinese, 2052)    '設定為簡中
            Case 2
                obj.Text = strEng    '設定為英文
        End Select
    End Sub
    '當輸入條件為 TRUE 時才顯示文字訊息至 物件(具有 TEXT 屬性),並提供3語的文字 ,
    Public Sub SetLangTextCond(ByVal cond As Boolean, ByVal obj As Object, ByVal strCht As String, ByVal strEng As String)
        If cond Then
            Select Case SystemLanguage
                Case 0
                    obj.Text = strCht   '設定為繁中
                Case 1
                    obj.Text = StrConv(strCht, VbStrConv.SimplifiedChinese, 2052)    '設定為簡中
                Case 2
                    obj.Text = strEng    '設定為英文
            End Select
        End If
    End Sub
    '當輸入條件為 TRUE 時才顯示文字訊息至 物件(具有 TEXT 屬性),並提供3語的文字 ,
    Public Sub SetLangTextCond(ByVal cond As Boolean, ByVal obj As Object, ByVal strCht As String, ByVal strChs As String, ByVal strEng As String)
        If cond Then
            Select Case SystemLanguage
                Case 0
                    obj.Text = strCht   '設定為繁中
                Case 1
                    obj.Text = StrConv(strCht, VbStrConv.SimplifiedChinese, 2052)        '設定為簡中
                Case 2
                    obj.Text = strEng    '設定為英文
            End Select
        End If
    End Sub

    '顯示文字盒,並傳回按鈕狀態?(YES,NO),並提供3語的文字 
    Public Function MsgBoxLangYesNo(ByVal strCht As String) As Boolean
        Dim rtl As Integer
        rtl = MyMsgBox(strCht, MsgBoxStyle.YesNo)
        If rtl = vbYes Then
            Return True
        Else
            Return False
        End If
    End Function
    '顯示文字盒,並傳回按鈕狀態?(YES,NO),並提供3語的文字 
    Public Function MsgBoxLangYesNo(ByVal strCht As String, ByVal strEng As String) As Boolean
        Dim rtl As Integer
        Select Case SystemLanguage
            Case 0
                rtl = MyMsgBox(strCht, MsgBoxStyle.YesNo)
            Case 1
                rtl = MyMsgBox(StrConv(strCht, VbStrConv.SimplifiedChinese, 2052), MsgBoxStyle.YesNo)
            Case 2
                rtl = MyMsgBox(strEng, MsgBoxStyle.YesNo)
        End Select
        If rtl = vbYes Then
            Return True
        Else
            Return False
        End If
    End Function
    '顯示文字盒,並傳回按鈕狀態?(YES,NO),並提供3語的文字 
    Public Function MsgBoxLangYesNo(ByVal strCht As String, ByVal strChs As String, ByVal strEng As String) As Boolean
        Dim rtl As Integer
        Select Case SystemLanguage
            Case 0
                rtl = MyMsgBox(strCht, MsgBoxStyle.YesNo)
            Case 1
                rtl = MyMsgBox(StrConv(strCht, VbStrConv.SimplifiedChinese, 2052), MsgBoxStyle.YesNo)
            Case 2
                rtl = MyMsgBox(strEng, MsgBoxStyle.YesNo)
        End Select
        If rtl = vbYes Then
            Return True
        Else
            Return False
        End If
    End Function
    '顯示 OK 文字盒-不指定語言
    Public Sub ShowMsgBox(ByVal sstr As String)
        MyMsgBox(sstr, MsgBoxStyle.OkOnly)
    End Sub
    '顯示 OK 文字盒 指定3語
    Public Function MsgBoxLangOK(ByVal strCht As String) As Boolean
        MyMsgBox(strCht, MsgBoxStyle.OkOnly)
        Return True
    End Function
    '顯示 OK 文字盒 指定3語
    Public Function MsgBoxLangOK(ByVal strCht As String, ByVal strEng As String) As Boolean
        Select Case SystemLanguage
            Case 0
                MyMsgBox(strCht, MsgBoxStyle.OkOnly)
            Case 1
                MyMsgBox(StrConv(strCht, VbStrConv.SimplifiedChinese, 2052), MsgBoxStyle.OkOnly)
            Case 2
                MyMsgBox(strEng, MsgBoxStyle.OkOnly)
        End Select
        Return True
    End Function
    '顯示 OK 文字盒 指定3語
    Public Function MsgBoxLangOK(ByVal strCht As String, ByVal strChs As String, ByVal strEng As String) As Boolean
        Select Case SystemLanguage
            Case 0
                MyMsgBox(strCht, MsgBoxStyle.OkOnly)
            Case 1
                MyMsgBox(StrConv(strCht, VbStrConv.SimplifiedChinese, 2052), MsgBoxStyle.OkOnly)
            Case 2
                MyMsgBox(strEng, MsgBoxStyle.OkOnly)
        End Select
        Return True
    End Function
    '顯示 錯誤OK 文字盒
    Public Sub MsgBoxLangErr(ByVal strCht As String, ByVal strChs As String, ByVal strEng As String)
        Select Case SystemLanguage
            Case 0
                MyMsgBox(strCht, MsgBoxStyle.Critical)
            Case 1
                MyMsgBox(StrConv(strCht, VbStrConv.SimplifiedChinese, 2052), MsgBoxStyle.Critical)
            Case 2
                MyMsgBox(strEng, MsgBoxStyle.Critical)
        End Select
    End Sub
    '顯示 錯誤OK 文字盒
    Public Sub MsgBoxLangErr(ByVal strCht As String, ByVal strEng As String)
        Select Case SystemLanguage
            Case 0
                MyMsgBox(strCht, MsgBoxStyle.Critical)
            Case 1
                MyMsgBox(StrConv(strCht, VbStrConv.SimplifiedChinese, 2052), MsgBoxStyle.Critical)
            Case 2
                MyMsgBox(strEng, MsgBoxStyle.Critical)
        End Select
    End Sub

    '顯示 錯誤OK 文字盒
    Public Sub MsgBoxLangErr(ByVal strCht As String)
        On Error Resume Next
        MyMsgBox(strCht, MsgBoxStyle.Critical)
    End Sub
    Public Function MyMsgBox(ByVal Msg As String, ByVal btn As MsgBoxStyle) As DialogResult
        On Error Resume Next
        Dim rtl As New DialogResult
        Select Case btn
            Case MsgBoxStyle.YesNo
                SetLangText(FormMsgboxs.btnYes, "是", "是", "Yes")
                SetLangText(FormMsgboxs.btnNo, "否", "否", "No")
                FormMsgboxs.btnNo.Visible = True
                FormMsgboxs.btnYes.Left = 60
            Case Else
                FormMsgboxs.btnNo.Visible = False
                FormMsgboxs.btnYes.Left = 136
                SetLangText(FormMsgboxs.btnYes, "OK", "OK", "OK")
        End Select
        FormMsgboxs.lblMessage.Text = Msg
        SetLangText(FormMsgboxs, "系統訊息", "系统讯息", "System Message")
        If FormMsgboxs.Visible = False Then rtl = FormMsgboxs.ShowDialog()
        Return rtl
    End Function
    Public Sub CIM_MsgBoxShow(ByVal Msg As String)
        On Error Resume Next
        Dim aa As New FormMsgBox
        Const MB_TOPMOST As Integer = &H40000
        MsgBox(Msg, MsgBoxStyle.OkOnly Or MB_TOPMOST, GetLangText("CIM 系統訊息", "CIM Message"))

        'Using form As Form = New Form() With {.TopMost = True}
        '    MessageBox.Show(form, Msg, GetLangText("CIM 系統訊息", "CIM Message"))
        'End Using
    End Sub
    Public Sub CIM_MsgBoxOK(ByVal Title As String, ByVal Msg As String)
        Dim aa As New FormMsgBox
        aa.btnNo.Visible = False
        aa.btnYes.Left = 136
        SetLangText(aa.btnYes, "是", "是", "OK")
        aa.lblMessage.Text = Msg
        aa.Text = Title
        If aa.Visible = False Then aa.Show()
    End Sub

    Public Function MyMsgBox(ByVal Msg As String, ByVal btn As MsgBoxStyle, ByVal Title As String) As DialogResult
        On Error Resume Next
        Dim rtl As New DialogResult
        Select Case btn
            Case MsgBoxStyle.YesNo
                SetLangText(FormMsgboxs.btnYes, "是", "是", "Yes")
                SetLangText(FormMsgboxs.btnNo, "否", "否", "No")
                FormMsgboxs.btnNo.Visible = True
                FormMsgboxs.btnYes.Left = 60
            Case Else
                FormMsgboxs.btnNo.Visible = False
                FormMsgboxs.btnYes.Left = 136
                SetLangText(FormMsgboxs.btnYes, "是", "是", "Yes")
        End Select
        FormMsgboxs.lblMessage.Text = Msg
        FormMsgboxs.Text = Title
        If FormMsgboxs.Visible = False Then rtl = FormMsgboxs.ShowDialog()
        Return rtl
    End Function
End Module

Module Module_Language_Change
    '語言定義--定義於各字型檔(LANG_CHT.INI)
    ''' <summary>
    ''' '系統語言變數 0=CHT, 1=CHS, 2=ENG
    ''' </summary>
    ''' <remarks></remarks>
    Public SystemLanguage As Integer        '系統語言變數
    ''' <summary>
    ''' 存上一次變更的語系,判斷語系是否有變更
    ''' </summary>
    ''' <remarks></remarks>
    Public LanguageChange As Integer
    ''' <summary>
    ''' 語系設定檔名變數
    ''' </summary>
    ''' <remarks></remarks>
    Public LanguageFile As String
    ''' <summary>
    ''' 繁中語系常數 =0
    ''' </summary>
    ''' <remarks></remarks>
    Public Const LANG_CHT As Integer = 0
    ''' <summary>
    ''' 簡中語系常數 =1
    ''' </summary>
    ''' <remarks></remarks>
    Public Const LANG_CHS As Integer = 1
    ''' <summary>
    ''' 英文語系常數 =2
    ''' </summary>
    ''' <remarks></remarks>
    Public Const LANG_ENG As Integer = 2
    ''' <summary>
    ''' 繁中語系INI檔案變數
    ''' </summary>
    ''' <remarks></remarks>
    Public LangCHTINIFile As String
    ''' <summary>
    ''' 簡中語系INI檔案變數
    ''' </summary>
    ''' <remarks></remarks>
    Public LangCHSINIFile As String
    ''' <summary>
    ''' 英文語系INI檔案變數
    ''' </summary>
    ''' <remarks></remarks>
    Public LangEngINIFile As String

    ''' <summary>
    ''' 初始化語系檔案名稱
    ''' </summary>
    ''' <param name="sdir">語系檔所在的資料夾</param>
    ''' <remarks>
    ''' LangCHTINIFile = sdir + "LANG_CHT.INI" 
    ''' LangCHSINIFile = sdir + "LANG_CHS.INI"
    ''' LangEngINIFile = sdir + "LANG_ENG.INI"
    ''' </remarks>
    Public Sub InitLanguage(ByVal sdir As String)
        LangCHTINIFile = sdir + "LANG_CHT.INI"        '程式資料INI檔案
        LangCHSINIFile = sdir + "LANG_CHS.INI"        '程式資料INI檔案
        LangEngINIFile = sdir + "LANG_ENG.INI"        '程式資料INI檔案

    End Sub

    '
    ''' <summary>
    ''' 尋找 表單內的所有控制項, 並將控制項名稱寫入 檔案內, 用來做為 語言切換使用,最多5層容器
    ''' </summary>
    ''' <param name="frm">控制項變數,一般是表單</param>
    ''' <param name="sfile">檔案名稱,一般是INI 檔案</param>
    ''' <remarks>修改記錄: 99.02.03 </remarks>
    Public Sub FindControls(ByRef frm As Object, ByVal sfile As String)
        Dim gg As TabControl
        Dim i As Integer
        On Error Resume Next
        For Each aa As Control In frm.Controls
            WriteLangIni(frm.Name, aa, sfile)
            If TypeName(aa) = "TabControl" Then
                gg = aa
                For i = 0 To gg.TabCount - 1
                    WriteProgData(frm.Name, gg.TabPages(i).Name, gg.TabPages(i).Text, sfile)
                Next
            End If
            If aa.Controls.Count > 0 Then
                For Each bb As Control In aa.Controls
                    WriteLangIni(frm.Name, bb, sfile)
                    If TypeName(bb) = "TabControl" Then
                        gg = bb
                        For i = 0 To gg.TabCount - 1
                            WriteProgData(frm.Name, gg.TabPages(i).Name, gg.TabPages(i).Text, sfile)
                        Next
                    End If
                    If bb.Controls.Count > 0 Then
                        For Each cc As Control In bb.Controls
                            WriteLangIni(frm.Name, cc, sfile)
                            If TypeName(cc) = "TabControl" Then
                                gg = cc
                                For i = 0 To gg.TabCount - 1
                                    WriteProgData(frm.Name, gg.TabPages(i).Name, gg.TabPages(i).Text, sfile)
                                Next
                            End If
                            If cc.Controls.Count > 0 Then
                                If TypeName(cc) = "TabControl" Then
                                    gg = cc
                                    For i = 0 To gg.TabCount - 1
                                        WriteProgData(frm.Name, gg.TabPages(i).Name, gg.TabPages(i).Text, sfile)
                                    Next
                                End If
                                For Each dd As Control In cc.Controls
                                    WriteLangIni(frm.Name, dd, sfile)
                                    If dd.Controls.Count > 0 Then
                                        WriteLangIni(frm.Name, dd, sfile)
                                        If TypeName(dd) = "TabControl" Then
                                            gg = dd
                                            For i = 0 To gg.TabCount - 1
                                                WriteProgData(frm.Name, gg.TabPages(i).Name, gg.TabPages(i).Text, sfile)
                                            Next
                                        End If
                                        For Each ee As Control In dd.Controls
                                            WriteLangIni(frm.Name, ee, sfile)
                                            If TypeName(ee) = "TabControl" Then
                                                gg = ee
                                                For i = 0 To gg.TabCount - 1
                                                    WriteProgData(frm.Name, gg.TabPages(i).Name, gg.TabPages(i).Text, sfile)
                                                Next
                                            End If
                                            For Each ff As Control In ee.Controls
                                                WriteLangIni(frm.Name, ff, sfile)
                                                If TypeName(ff) = "TabControl" Then
                                                    gg = ff
                                                    For i = 0 To gg.TabCount - 1
                                                        WriteProgData(frm.Name, gg.TabPages(i).Name, gg.TabPages(i).Text, sfile)
                                                    Next
                                                End If
                                                For Each hh As Control In ff.Controls
                                                    WriteLangIni(frm.Name, hh, sfile)
                                                    If TypeName(hh) = "TabControl" Then
                                                        gg = hh
                                                        For i = 0 To gg.TabCount - 1
                                                            WriteProgData(frm.Name, gg.TabPages(i).Name, gg.TabPages(i).Text, sfile)
                                                        Next
                                                    End If
                                                    For Each ii As Control In hh.Controls
                                                        WriteLangIni(frm.Name, ii, sfile)
                                                        If TypeName(ii) = "TabControl" Then
                                                            gg = ii
                                                            For i = 0 To gg.TabCount - 1
                                                                WriteProgData(frm.Name, gg.TabPages(i).Name, gg.TabPages(i).Text, sfile)
                                                            Next
                                                        End If
                                                        For Each jj As Control In ii.Controls
                                                            WriteLangIni(frm.Name, jj, sfile)
                                                            If TypeName(jj) = "TabControl" Then
                                                                gg = jj
                                                                For i = 0 To gg.TabCount - 1
                                                                    WriteProgData(frm.Name, gg.TabPages(i).Name, gg.TabPages(i).Text, sfile)
                                                                Next
                                                            End If
                                                            For Each kk As Control In jj.Controls
                                                                WriteLangIni(frm.Name, kk, sfile)

                                                            Next
                                                        Next
                                                    Next
                                                Next
                                            Next
                                        Next

                                    End If

                                Next

                            End If
                        Next

                    End If
                Next

            End If
        Next
    End Sub
    Public Sub FindControlsCHS(ByRef frm As Object, ByVal sfile As String)
        Dim gg As TabControl
        Dim i As Integer
        On Error Resume Next
        For Each aa As Control In frm.Controls
            WriteLangIniCHS(frm.Name, aa, sfile)
            If TypeName(aa) = "TabControl" Then
                gg = aa
                For i = 0 To gg.TabCount - 1
                    WriteProgData(frm.Name, gg.TabPages(i).Name, StrConv(gg.TabPages(i).Text, VbStrConv.SimplifiedChinese, 1028), sfile)
                Next
            End If
            If aa.Controls.Count > 0 Then
                For Each bb As Control In aa.Controls
                    WriteLangIniCHS(frm.Name, bb, sfile)
                    If TypeName(bb) = "TabControl" Then
                        gg = bb
                        For i = 0 To gg.TabCount - 1
                            WriteProgData(frm.Name, gg.TabPages(i).Name, StrConv(gg.TabPages(i).Text, VbStrConv.SimplifiedChinese, 1028), sfile)
                        Next
                    End If
                    If bb.Controls.Count > 0 Then
                        For Each cc As Control In bb.Controls
                            WriteLangIniCHS(frm.Name, cc, sfile)
                            If TypeName(cc) = "TabControl" Then
                                gg = cc
                                For i = 0 To gg.TabCount - 1
                                    WriteProgData(frm.Name, gg.TabPages(i).Name, StrConv(gg.TabPages(i).Text, VbStrConv.SimplifiedChinese, 1028), sfile)
                                Next
                            End If
                            If cc.Controls.Count > 0 Then
                                If TypeName(cc) = "TabControl" Then
                                    gg = cc
                                    For i = 0 To gg.TabCount - 1
                                        WriteProgData(frm.Name, gg.TabPages(i).Name, StrConv(gg.TabPages(i).Text, VbStrConv.SimplifiedChinese, 1028), sfile)
                                    Next
                                End If
                                For Each dd As Control In cc.Controls
                                    WriteLangIniCHS(frm.Name, dd, sfile)
                                    If dd.Controls.Count > 0 Then
                                        WriteLangIniCHS(frm.Name, dd, sfile)
                                        If TypeName(dd) = "TabControl" Then
                                            gg = dd
                                            For i = 0 To gg.TabCount - 1
                                                WriteProgData(frm.Name, gg.TabPages(i).Name, StrConv(gg.TabPages(i).Text, VbStrConv.SimplifiedChinese, 1028), sfile)
                                            Next
                                        End If
                                        For Each ee As Control In dd.Controls
                                            WriteLangIniCHS(frm.Name, ee, sfile)
                                            If TypeName(ee) = "TabControl" Then
                                                gg = ee
                                                For i = 0 To gg.TabCount - 1
                                                    WriteProgData(frm.Name, gg.TabPages(i).Name, StrConv(gg.TabPages(i).Text, VbStrConv.SimplifiedChinese, 1028), sfile)
                                                Next
                                            End If
                                            For Each ff As Control In ee.Controls
                                                WriteLangIniCHS(frm.Name, ff, sfile)
                                                If TypeName(ff) = "TabControl" Then
                                                    gg = ff
                                                    For i = 0 To gg.TabCount - 1
                                                        WriteProgData(frm.Name, gg.TabPages(i).Name, StrConv(gg.TabPages(i).Text, VbStrConv.SimplifiedChinese, 1028), sfile)
                                                    Next
                                                End If
                                                For Each hh As Control In ff.Controls
                                                    WriteLangIniCHS(frm.Name, hh, sfile)
                                                Next
                                            Next
                                        Next

                                    End If

                                Next

                            End If
                        Next

                    End If
                Next

            End If
        Next
    End Sub
    '將控制項的名稱及文字寫入檔案
    Public Sub WriteLangIniCHS(ByVal section As String, ByVal obj As Object, ByVal fs As String)
        If obj.Text <> "" Then
            WriteProgData(section, obj.Name, StrConv(obj.Text, VbStrConv.SimplifiedChinese, 1028), fs)
        End If
    End Sub
    '將控制項的名稱及文字寫入檔案
    Public Sub WriteLangIni(ByVal section As String, ByVal obj As Object, ByVal fs As String)
        If obj.Text <> "" Then
            If Not (InStr(obj.Name, "txt") > 0) Then
                WriteProgData(section, obj.Name, obj.Text, fs)
            End If
        End If
    End Sub

    '自檔案中讀出控制項名稱, 並依據名稱將表單內的所有控制項的文字修改, 最多5層容器
    Public Sub ChangeFormLang(ByVal frm As Object, ByVal sfile As String)
        Dim gg As TabControl
        Dim i As Integer
        Dim sstr As String
        If Not FileIO.FileSystem.FileExists(sfile) Then Exit Sub
        For Each aa As Control In frm.Controls
            Application.DoEvents()
            ReadAndSetText(frm.Name, aa, sfile)
            If TypeName(aa) = "TabControl" Then
                gg = aa
                For i = 0 To gg.TabCount - 1
                    sstr = ReadProgData(frm.Name, gg.TabPages(i).Name, gg.TabPages(i).Text, sfile)
                    If Len(sstr) > 0 Then
                        gg.TabPages(i).Text = sstr
                    End If
                Next
            End If
            If aa.Controls.Count > 0 Then
                For Each bb As Control In aa.Controls
                    ReadAndSetText(frm.Name, bb, sfile)
                    If TypeName(bb) = "TabControl" Then
                        gg = bb
                        For i = 0 To gg.TabCount - 1
                            sstr = ReadProgData(frm.Name, gg.TabPages(i).Name, gg.TabPages(i).Text, sfile)
                            If Len(sstr) > 0 Then
                                gg.TabPages(i).Text = sstr
                            End If
                        Next
                    End If
                    If bb.Controls.Count > 0 Then
                        For Each cc As Control In bb.Controls
                            ReadAndSetText(frm.Name, cc, sfile)
                            If TypeName(cc) = "TabControl" Then
                                gg = cc
                                For i = 0 To gg.TabCount - 1
                                    sstr = ReadProgData(frm.Name, gg.TabPages(i).Name, gg.TabPages(i).Text, sfile)
                                    If Len(sstr) > 0 Then
                                        gg.TabPages(i).Text = sstr
                                    End If
                                Next
                            End If
                            If cc.Controls.Count > 0 Then
                                For Each dd As Control In cc.Controls
                                    ReadAndSetText(frm.Name, dd, sfile)
                                    If TypeName(dd) = "TabControl" Then
                                        gg = dd
                                        For i = 0 To gg.TabCount - 1
                                            sstr = ReadProgData(frm.Name, gg.TabPages(i).Name, gg.TabPages(i).Text, sfile)
                                            If Len(sstr) > 0 Then
                                                gg.TabPages(i).Text = sstr
                                            End If
                                        Next
                                    End If
                                    If dd.Controls.Count > 0 Then
                                        For Each ee As Control In dd.Controls
                                            ReadAndSetText(frm.Name, ee, sfile)
                                            If TypeName(ee) = "TabControl" Then
                                                gg = ee
                                                For i = 0 To gg.TabCount - 1
                                                    sstr = ReadProgData(frm.Name, gg.TabPages(i).Name, gg.TabPages(i).Text, sfile)
                                                    If Len(sstr) > 0 Then
                                                        gg.TabPages(i).Text = sstr
                                                    End If
                                                Next
                                            End If
                                            If ee.Controls.Count > 0 Then
                                                For Each ff As Control In ee.Controls
                                                    ReadAndSetText(frm.Name, ff, sfile)
                                                    If TypeName(ff) = "TabControl" Then
                                                        gg = ff
                                                        For i = 0 To gg.TabCount - 1
                                                            sstr = ReadProgData(frm.Name, gg.TabPages(i).Name, gg.TabPages(i).Text, sfile)
                                                            If Len(sstr) > 0 Then
                                                                gg.TabPages(i).Text = sstr
                                                            End If
                                                        Next
                                                    End If
                                                    If ff.Controls.Count > 0 Then
                                                        For Each hh As Control In ff.Controls
                                                            ReadAndSetText(frm.Name, hh, sfile)
                                                            If TypeName(hh) = "TabControl" Then
                                                                gg = hh
                                                                For i = 0 To gg.TabCount - 1
                                                                    sstr = ReadProgData(frm.Name, gg.TabPages(i).Name, gg.TabPages(i).Text, sfile)
                                                                    If Len(sstr) > 0 Then
                                                                        gg.TabPages(i).Text = sstr
                                                                    End If
                                                                Next
                                                            End If
                                                            If hh.Controls.Count > 0 Then
                                                                For Each ii As Control In hh.Controls
                                                                    ReadAndSetText(frm.Name, ii, sfile)
                                                                    If TypeName(ff) = "TabControl" Then
                                                                        gg = ii
                                                                        For i = 0 To gg.TabCount - 1
                                                                            sstr = ReadProgData(frm.Name, gg.TabPages(i).Name, gg.TabPages(i).Text, sfile)
                                                                            If Len(sstr) > 0 Then
                                                                                gg.TabPages(i).Text = sstr
                                                                            End If
                                                                        Next
                                                                    End If
                                                                    If ii.Controls.Count > 0 Then
                                                                        For Each jj As Control In ii.Controls
                                                                            ReadAndSetText(frm.Name, jj, sfile)
                                                                            If TypeName(jj) = "TabControl" Then
                                                                                gg = jj
                                                                                For i = 0 To gg.TabCount - 1
                                                                                    sstr = ReadProgData(frm.Name, gg.TabPages(i).Name, gg.TabPages(i).Text, sfile)
                                                                                    If Len(sstr) > 0 Then
                                                                                        gg.TabPages(i).Text = sstr
                                                                                    End If
                                                                                Next
                                                                            End If
                                                                            If jj.Controls.Count > 0 Then
                                                                                For Each kk As Control In jj.Controls
                                                                                    ReadAndSetText(frm.Name, kk, sfile)
                                                                                    If TypeName(kk) = "TabControl" Then
                                                                                        gg = kk
                                                                                        For i = 0 To gg.TabCount - 1
                                                                                            sstr = ReadProgData(frm.Name, gg.TabPages(i).Name, gg.TabPages(i).Text, sfile)
                                                                                            If Len(sstr) > 0 Then
                                                                                                gg.TabPages(i).Text = sstr
                                                                                            End If
                                                                                        Next
                                                                                    End If
                                                                                    If kk.Controls.Count > 0 Then
                                                                                        For Each ll As Control In kk.Controls
                                                                                            ReadAndSetText(frm.Name, ll, sfile)
                                                                                            If TypeName(ll) = "TabControl" Then
                                                                                                gg = ll
                                                                                                For i = 0 To gg.TabCount - 1
                                                                                                    sstr = ReadProgData(frm.Name, gg.TabPages(i).Name, gg.TabPages(i).Text, sfile)
                                                                                                    If Len(sstr) > 0 Then
                                                                                                        gg.TabPages(i).Text = sstr
                                                                                                    End If
                                                                                                Next
                                                                                            End If
                                                                                            If ll.Controls.Count > 0 Then
                                                                                                For Each mm As Control In ll.Controls
                                                                                                    ReadAndSetText(frm.Name, mm, sfile)
                                                                                                    If TypeName(mm) = "TabControl" Then
                                                                                                        gg = mm
                                                                                                        For i = 0 To gg.TabCount - 1
                                                                                                            sstr = ReadProgData(frm.Name, gg.TabPages(i).Name, gg.TabPages(i).Text, sfile)
                                                                                                            If Len(sstr) > 0 Then
                                                                                                                gg.TabPages(i).Text = sstr
                                                                                                            End If
                                                                                                        Next
                                                                                                    End If
                                                                                                Next
                                                                                            End If
                                                                                        Next
                                                                                    End If
                                                                                Next
                                                                            End If
                                                                        Next
                                                                    End If
                                                                Next
                                                            End If
                                                        Next
                                                    End If
                                                Next
                                            End If
                                        Next
                                    End If
                                Next
                            End If
                        Next
                    End If
                Next
            End If
        Next
    End Sub

    ''將控制項的名稱自檔案讀入並比較是否有相同名稱並設定控制項文字
    'Public Sub ReadAndSetText(ByVal section As String, ByVal obj As Object, ByVal fs As String)
    '    Dim sstr As String
    '    sstr = ReadProgData(section, obj.Name, "", fs)
    '    If Len(sstr) > 0 Then
    '        obj.Text = sstr
    '        'Debug.Print(obj.Text)
    '    End If
    'End Sub
    '將控制項的名稱自檔案讀入並比較是否有相同名稱並設定控制項文字
    Public Sub ReadAndSetText(ByVal section As String, ByVal obj As Object, ByVal fs As String)
        Dim sstr As String
        If SystemLanguage = LANG_CHS Then
            sstr = StrConv(ReadProgData(section, obj.Name, "", LangCHTINIFile), VbStrConv.SimplifiedChinese, 2052)
        Else
            sstr = ReadProgData(section, obj.Name, "", fs)
        End If
        If Len(sstr) > 0 Then
            obj.Text = sstr
            'Debug.Print(obj.Text)
        End If
    End Sub

    ' 尋找表單內內所有控制項的名稱及文字存檔,以利製作 語系檔
    Public Sub GetAllFormText(ByVal ls As String)
        If IO.File.Exists(ls) Then
            IO.File.Delete(ls)
        End If
        FindControls(Form1s, ls)
        FindControls(FormAlarms, ls)
        FindControls(FormAlarmPopups, ls)
        FindControls(FormKeyboard1s, ls)
        FindControls(FormKeyboard2s, ls)
        FindControls(FormKeyboard3s, ls)
        FindControls(FormKeyInDataLogNames, ls)
        FindControls(FormkeyInFileNames, ls)
        FindControls(FormKeyInProcessNames, ls)
        FindControls(FormKeyInRecipeFileNames, ls)
        FindControls(FormKeyInVideoNames, ls)
        FindControls(FormLicenses, ls)
        FindControls(FormLogins, ls)
        FindControls(FormLoginSetups, ls)
        FindControls(FormMaintances, ls)
        FindControls(FormManuals, ls)
        FindControls(FormMenus, ls)
        FindControls(FormMsgboxs, ls)
        FindControls(FormParameters, ls)
        FindControls(FormProcesss, ls)
        FindControls(FormRecipeSelects, ls)
        FindControls(FormRecipes, ls)
        FindControls(FormRecords, ls)
        FindControls(FormRecipeMapEdit, ls)
        FindControls(FormRecipeBarcodeInput, ls)
    End Sub

    '依序將表單內的文字修改
    Public Sub ChangeLanguage(ByVal ls As String)
        ChangeListViewColHeater(FormAlarms.ListView1)
        ChangeFormLang(FormAlarms, ls)
        ChangeFormLang(FormAlarmPopups, ls)
        ChangeFormLang(FormKeyboard1s, ls)
        ChangeFormLang(FormKeyboard2s, ls)
        ChangeFormLang(FormKeyboard3s, ls)
        ChangeFormLang(FormKeyInDataLogNames, ls)
        ChangeFormLang(FormkeyInFileNames, ls)

        ChangeFormLang(FormKeyInProcessNames, ls)
        ChangeFormLang(FormKeyInRecipeFileNames, ls)
        ChangeFormLang(FormKeyInVideoNames, ls)
        ChangeFormLang(FormLicenses, ls)
        ChangeFormLang(FormLogins, ls)
        ChangeFormLang(FormLoginSetups, ls)
        ChangeFormLang(FormMaintances, ls)
        ChangeFormLang(FormManuals, ls)
        ChangeFormLang(FormMenus, ls)
        ChangeFormLang(FormMsgboxs, ls)
        ChangeFormLang(FormParameters, ls)
        ChangeFormLang(FormProcesss, ls)
        ChangeFormLang(FormRecipeSelects, ls)
        ChangeFormLang(FormRecipes, ls)
        ChangeFormLang(FormRecords, ls)
        ChangeFormLang(FormRecipeMapEdit, ls)
        ChangeFormLang(FormRecipeBarcodeInput, ls)
        ChangeFormLang(Form1s, ls)
        ChangeSeriesRecordName(ChartRecord, CurveName)
        SetLangText(Form1s.chkPLCTest, "PLC 通訊" + Format(PLC_COMPORT, "COM0"), "PLC Comm. " + Format(PLC_COMPORT, "COM0"))

    End Sub

    '依序將表單內的文字修改,並帶有進度列以顯示目前進度
    Public Sub ChangeLanguage(ByVal ls As String, ByVal pg As ProgressBar)
        Dim i As Integer = 0
        ChangeListViewColHeater(FormAlarms.ListView1)
        pg.Value = 0
        pg.Maximum = 23
        pg.Visible = True
        pg.PerformStep()
        ChangeFormLang(FormAlarms, ls)
        pg.PerformStep()
        ChangeFormLang(FormAlarmPopups, ls)
        pg.PerformStep()
        ChangeFormLang(FormKeyboard1s, ls)
        pg.PerformStep()
        ChangeFormLang(FormKeyboard2s, ls)
        pg.PerformStep()
        ChangeFormLang(FormKeyboard3s, ls)
        pg.PerformStep()
        ChangeFormLang(FormKeyInDataLogNames, ls)
        pg.PerformStep()
        ChangeFormLang(FormKeyInProcessNames, ls)
        ChangeFormLang(FormkeyInFileNames, ls)
        pg.PerformStep()
        ChangeFormLang(FormKeyInRecipeFileNames, ls)
        pg.PerformStep()
        ChangeFormLang(FormKeyInVideoNames, ls)
        pg.PerformStep()
        ChangeFormLang(FormLicenses, ls)
        pg.PerformStep()
        ChangeFormLang(FormLogins, ls)
        pg.PerformStep()
        ChangeFormLang(FormLoginSetups, ls)
        pg.PerformStep()
        ChangeFormLang(FormMaintances, ls)
        pg.PerformStep()
        ChangeFormLang(FormManuals, ls)
        pg.PerformStep()
        ChangeFormLang(FormMenus, ls)
        pg.PerformStep()
        ChangeFormLang(FormMsgboxs, ls)
        pg.PerformStep()
        ChangeFormLang(FormParameters, ls)
        pg.PerformStep()
        ChangeFormLang(FormProcesss, ls)
        pg.PerformStep()
        ChangeFormLang(FormRecipeSelects, ls)
        pg.PerformStep()
        ChangeFormLang(FormRecipes, ls)
        pg.PerformStep()
        ChangeFormLang(FormRecords, ls)
        pg.PerformStep()
        ChangeFormLang(FormRecipeMapEdit, ls)
        pg.PerformStep()
        ChangeFormLang(FormRecipeBarcodeInput, ls)
        pg.PerformStep()
        ChangeFormLang(Form1s, ls)
        pg.Value = pg.Maximum
        pg.Value = 0
        pg.Visible = False
        ChangeSeriesRecordName(ChartRecord, CurveName)
        SetLangText(Form1s.chkPLCTest, "PLC 通訊" + Format(PLC_COMPORT, "COM0"), "PLC Comm. " + Format(PLC_COMPORT, "COM0"))

    End Sub
    Public Sub LanguageSelect(ByVal sfile As String, ByVal cht As String, ByVal chs As String, ByVal eng As String)
        SystemLanguage = Val(ReadProgData("PROGRAM", "LANGUAGE", "0", sfile))     '讀取語言設定
        If SystemLanguage = 0 Then Form1s.radChangeToCHT.Checked = True
        If SystemLanguage = 1 Then Form1s.radChangeToCHS.Checked = True
        If SystemLanguage = 2 Then Form1s.radChangeToENG.Checked = True
        ClickLanguge(cht, chs, eng)  '設定語言系統參數
        ChangeLanguage(LanguageFile)
        SetLangText(Form1s.chkPLCTest, "PLC 通訊" + Format(PLC_COMPORT, "COM0"), "PLC Comm. " + Format(PLC_COMPORT, "COM0"))

    End Sub
    '按下語言選擇, 做語言切換
    Public Sub ClickLanguge(ByVal cht As String, ByVal chs As String, ByVal eng As String)
        If Form1s.radChangeToCHT.Checked Then
            SystemLanguage = 0
            LanguageFile = cht
        End If
        If Form1s.radChangeToCHS.Checked Then
            SystemLanguage = 1
            LanguageFile = chs
        End If
        If Form1s.radChangeToENG.Checked Then
            LanguageFile = eng
            SystemLanguage = 2
        End If
        If SystemLanguage < 0 And SystemLanguage > 2 Then
            SystemLanguage = 0
            LanguageFile = cht
            Form1s.radChangeToCHT.Checked = True
        End If
    End Sub



    '=============================================================
    Public FormTextBoxSave As New CFormTextBoxSave
    Public FormSaveINIFile As String
    Class CFormTextBoxSave
        Sub New()

        End Sub


        '尋找 表單內的所有控制項, 並將控制項名稱寫入 檔案內, 用來做為 語言切換使用,最多5層容器
        ''' <summary>
        ''' 找出所有控制項內的TEXTBOX 控制項並存於INI檔案中
        ''' </summary>
        ''' <param name="obj">欲尋找的父控制項</param>
        ''' <param name="SectionName">INI 檔案寫入的區塊名稱</param>
        ''' <param name="sfile">INI檔案路徑 </param>
        ''' <remarks></remarks>
        Public Sub FindTextBox(ByRef obj As Object, ByVal SectionName As String, ByVal sfile As String)
            On Error Resume Next
            Dim Section As String
            For Each aa As Control In obj.Controls
                If aa.Controls.Count > 0 Then
                    FindTextBox(aa, SectionName, sfile)
                Else
                    WriteTextBoxIni(SectionName, aa, sfile)
                End If
            Next
        End Sub

        '自檔案中讀出控制項名稱, 並依據名稱將表單內的所有控制項的文字修改, 最多5層容器
        ''' <summary>
        ''' 從INI檔案中讀取已儲存的控制項值, 並存入控制項中
        ''' </summary>
        ''' <param name="obj">欲設定的父控制項</param>
        ''' <param name="SectionName">INI 檔案讀取的區塊名稱</param>
        ''' <param name="sfile">INI檔案路徑 </param>
        ''' <remarks></remarks>
        Public Sub SetTextBox(ByRef obj As Object, ByVal SectionName As String, ByVal sfile As String)
            On Error Resume Next
            Dim Section As String
            For Each aa As Control In obj.Controls
                If aa.Controls.Count > 0 Then
                    SetTextBox(aa, SectionName, sfile)
                Else
                    ReadAndSetTextBox(SectionName, aa, sfile)
                End If
            Next
        End Sub
        '將控制項的名稱自檔案讀入並比較是否有相同名稱並設定控制項文字
        Private Sub ReadAndSetTextBox(ByVal section As String, ByVal obj As Object, ByVal fs As String)
            Dim sstr As String
            If TypeName(obj) = "TextBox" Then
                sstr = ReadProgData(section, obj.Name, "", fs)
                If Len(sstr) > 0 Then
                    'MsgBox("[" + section + "]" + vbCrLf + obj.name + " = " + sstr)
                    obj.Text = sstr
                End If
            End If
        End Sub
        '將控制項的名稱及文字寫入檔案
        Private Sub WriteTextBoxIni(ByVal section As String, ByVal obj As Object, ByVal fs As String)
            If TypeName(obj) = "TextBox" Then
                WriteProgData(section, obj.Name, obj.Text, fs)
            End If
        End Sub
    End Class


    '=============================================================
End Module

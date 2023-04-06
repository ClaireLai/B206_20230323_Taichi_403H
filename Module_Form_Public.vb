Module Module_Form_Public
    Public Form1s As Form1 = Form1
    Public FormAlarms As FormAlarm = FormAlarm
    Public FormAlarmPopups As FormAlarmPopup = FormAlarmPopup
    Public FormKeyboard1s As FormKeyBoard1 = FormKeyBoard1
    Public FormKeyboard2s As FormKeyBoard2 = FormKeyBoard2
    Public FormKeyboard3s As FormKeyBoard3 = FormKeyBoard3
    Public FormKeyInDataLogNames As FormKeyinDataLogName = FormKeyinDataLogName
    Public FormkeyInFileNames As FormKeyInFileName = FormKeyInFileName
    Public FormKeyInProcessNames As FormKeyinProcessName = FormKeyinProcessName
    Public FormKeyInRecipeFileNames As FormKeyInRecipeFile = FormKeyInRecipeFile
    Public FormKeyInVideoNames As FormKeyinVideoName = FormKeyinVideoName
    Public FormLicenses As FormLicense = FormLicense
    Public FormLogins As FormLogin = FormLogin
    Public FormLoginSetups As FormLoginSetup = FormLoginSetup

    Public FormMaintances As FormMaintance = FormMaintance

    Public FormManuals As FormManual = FormManual
    Public FormMenus As FormMenu = FormMenu
    Public FormMsgboxs As FormMsgBox = FormMsgBox
    Public FormParameters As FormParameter = FormParameter
    Public FormProcesss As FormProcess = FormProcess
    Public FormRecipeSelects As FormRecipeSelect = FormRecipeSelect
    Public FormRecipes As FormRecipe = FormRecipe
    Public FormRecords As FormRecord = FormRecord
    'Public FormTempCals As FormTempCal = FormTempCal
    Public FormDataLogViews As FormDataLogView = FormDataLogView
    'FORM 初始位置
    Public FromStartUpTopPosition As Integer = Screen.PrimaryScreen.Bounds.Height / 16

    Public Program_Title As String
    Public Program_DeviceName As String
    Public Program_ModelName As String
    Public Program_TypeName As String


    Public Sub ReadProgramCaption(ByVal sfile As String)
        Program_Title = ReadProgData("PROGRAM", "PROG_NAME", "Cello Program", ProgramINIFile)
        Program_DeviceName = ReadProgData("PROGRAM", "DEVICE_NAME", "Cello Systems", ProgramINIFile)
        Program_ModelName = ReadProgData("PROGRAM", "MODEL_NAME", "Cello", ProgramINIFile)
        Program_TypeName = ReadProgData("PROGRAM", "TYPE_NAME", "0000", ProgramINIFile)
        Program_Logo = GetTrue01Boolean(ReadProgData("PROGRAM", "LOGO", "0", ProgramINIFile))
        Program_Flag = GetTrue01Boolean(ReadProgData("PROGRAM", "FLAG", "0", ProgramINIFile))
        Purge_Flag = GetTrue01Boolean(ReadProgData("PROGRAM", "PURGE", "0", ProgramINIFile))
        Resistance_ruler_Flag = GetTrue01Boolean(ReadProgData("PROGRAM", "Resistance_ruler", "0", ProgramINIFile))
        TaichiIcon = New Icon(My.Resources.Taichi, 64, 64)
    End Sub

    Dim TaichiIcon As Icon

    Public Program_Logo As Boolean
    ''' <summary>
    ''' 讀取 [PROGRAM] 下 LOGO =0 or 1 決定是否使用 LOGO 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub SetupLogo(Optional ByVal Cond As Boolean = False)
        Dim YesNo As Boolean
        If Cond = True Then
            Program_Logo = Not Program_Logo
            WriteProgData("PROGRAM", "LOGO", GetTrue01String(Program_Logo), ProgramINIFile)
        Else
            Program_Logo = GetTrue01Boolean(ReadProgData("PROGRAM", "LOGO", "0", ProgramINIFile))
        End If
        YesNo = Program_Logo
        ChangeFormLogo(FormStartup, YesNo)
        ChangeFormLogo(FormMsgboxs, YesNo)
        ChangeFormLogo(Form1s, YesNo)
        ChangeFormLogo(FormAlarms, YesNo)
        ChangeFormLogo(FormAlarmPopups, YesNo)
        ChangeFormLogo(FormKeyboard1s, YesNo)
        ChangeFormLogo(FormKeyboard2s, YesNo)
        ChangeFormLogo(FormKeyboard3s, YesNo)
        ChangeFormLogo(FormKeyInDataLogNames, YesNo)
        ChangeFormLogo(FormKeyInProcessNames, YesNo)
        ChangeFormLogo(FormkeyInFileNames, YesNo)
        ChangeFormLogo(FormKeyInRecipeFileNames, YesNo)
        ChangeFormLogo(FormKeyInVideoNames, YesNo)
        'ChangeFormLogo(FormLicenses, YesNo)
        ChangeFormLogo(FormLogins, YesNo)
        ChangeFormLogo(FormLoginSetups, YesNo)
        ChangeFormLogo(FormMaintances, YesNo)
        ChangeFormLogo(FormManuals, YesNo)
        ChangeFormLogo(FormMenus, YesNo)
        ChangeFormLogo(FormMsgboxs, YesNo)
        ChangeFormLogo(FormParameters, YesNo)
        ChangeFormLogo(FormProcesss, YesNo)
        ChangeFormLogo(FormRecipeSelects, YesNo)
        ChangeFormLogo(FormRecipes, YesNo)
        ChangeFormLogo(FormRecords, YesNo)
    End Sub


    Public Program_Flag As Boolean
    Public Purge_Flag As Boolean
    '電阻尺  =false=0  =true=1
    Public Resistance_ruler_Flag As Boolean
    ''' <summary>
    ''' 讀取 [PROGRAM] 下 FLAG=0 or 1 決定是否使用 FLAG (主畫面之國旗圖案)
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub SetupFlag(Optional ByVal Cond As Boolean = False)
        Dim YesNo As Boolean
        If Cond = True Then
            Program_Flag = Not Program_Flag
            WriteProgData("PROGRAM", "FLAG", GetTrue01String(Program_Flag), ProgramINIFile)
        Else
            Program_Flag = GetTrue01Boolean(ReadProgData("PROGRAM", "FLAG", "0", ProgramINIFile))
        End If
        YesNo = Program_Flag
        Form1s.picFlagUSA.Visible = YesNo
        Form1s.picFlagPRC.Visible = YesNo
        Form1s.picFlagTaiwan.Visible = YesNo
    End Sub

    Public Sub ChangeFormLogo(ByRef iForm As Object, ByVal YesNo As Boolean)
        On Error Resume Next
        'iForm.picCelloLogo.Visible = YesNo
        'iForm.picCelloTitle.Visible = YesNo
        'iForm.picCelloTitleEng.Visible = YesNo
        iForm.Icon = TaichiIcon
        FindAndSetLogos(iForm, "picCelloLogo", YesNo)
        FindAndSetLogos(iForm, "picCelloTitle", YesNo)
        FindAndSetLogos(iForm, "picCelloTitleEng", YesNo)
    End Sub
    Private Sub FindAndSetLogos(ByRef pnl As Object, ByVal name As String, ByVal YesNo As Boolean)
        For Each aa As Control In pnl.Controls
            If aa.Name = name Then
                aa.Visible = YesNo
            End If
        Next
    End Sub

End Module

Imports System.Runtime.InteropServices

Module Module_Recipe_Public
    Public RecipeINIFile As String

    Public TableMax As Integer                  '配方資料欄位數
    Public TableWidth As Integer = 80           '資料欄位寬度
    Public TableHeight As Integer = 30          '資料欄位高度
    Public RowHeaderWidth As Integer = 140      '資料欄位標題寬度
    Public rwstepindex As Integer               '配方指標


    Public RowHeadersHeight As Integer = 36
    Public RowHeadersWidth As Integer = 90
    Public RowColumnWidth As Integer = 80
    Public RecipeTempLowLimit As Integer = 30


    Enum Recipe_Col
        PRESSURE = 0
        P_RATE = 1
        TEMP = 2
        TEMP_RATE = 3
        HOLD_TIME = 4
        NOTE = 5
        PRE_SET = 6
    End Enum

    Public Const Recipe_Max As Integer = 99 '配方最大　ＳＴＥＰ
    Public Const UnitTorr As Double = 0.13332237    '0.001mtorr =0.13332237Pa  
    Public DeviceUnit As Integer    ' 真空單位
    Public Const MAX_XSCALE As Integer = 2000 '圖表刻度(TEST及 PROCESS)
    Public ColHeader() As String = {"壓力", "kgf/Sec", "溫度", "C/Sec", "保持時間", "註解", "預計時間"}
    Public ColHeaderE() As String = {"Press.", "kgf/Sec", "Temp.", "C/Sec", "HoldTime", "Note", "Preset"}
    Public ColHeaderS() As String = {"压力", "kgf/Sec", "温度", "C/Sec", "保持时间", "批注", "预计时间"}

    '上下限設定
    Public PRESS_MAX As String
    Public PRESS_MIN As String
    Public PRESSRATE_MAX As String
    Public PRESSRATE_MIN As String
    Public TEMP_MAX As String
    Public TEMP_MIN As String
    Public TEMPRATE_MAX As String
    Public TEMPRATE_MIN As String
    Public VACUUM_MAX As String
    Public VACUUM_MIN As String
    Public WAFERSIZE_MAX As String
    Public WAFERSIZE_MIN As String
    Public TEMPRANGE_MAX As String
    Public TEMPRANGE_MIN As String
    Public TIME_MAX As String
    Public TIME_MIN As String
    Public NORMAL_MAX As String
    Public NORMAL_MIN As String
    'PID控壓部分
    Public AdjustDA_Max As String
    Public AdjustOverPress_Max As String
    Public PressPID_P_Max As String
    Public PressPID_I_Max As String
    '配方結構
    <StructLayout(LayoutKind.Sequential)> Structure sPlateRecipe
        Public Pressure() As String         '壓力設定
        Public Pressure_Rate() As String    '壓速設定
        Public Temperature() As String      '溫度設定
        Public Temperature_Rate() As String '溫速設定
        Public Time() As String             '保持時間
        Public STEPNote() As String         '步驟註解
        Public StepTime() As Integer        '每步所需時間
        Public TotalTime As Integer         '單頭配方總時間
        Public TotalStep As Integer         '單頭配方總時間
    End Structure


    <StructLayout(LayoutKind.Sequential)> Structure Recipes
        Public StepSet As String            '配方步數
        Public RecipeNote As String         '配方註解
        Public BasePressure As String       '製程背景壓力
        Public Used As String        '是否有設定值可以run 製程


        Public MFC01Flow As String       '製程背景壓力
        Public MFC01ONTime As String       '製程背景壓力
        Public MFC01OFFTime As String       '製程背景壓力

        Public MFC02Flow As String       '製程背景壓力
        Public MFC02ONTime As String       '製程背景壓力
        Public MFC02OFFTime As String       '製程背景壓力

        'multiplateResipe
        Public Plate() As sPlateRecipe

        'Old Recipe
        'Public Pressure() As String         '壓力設定
        'Public Pressure_Rate() As String    '壓速設定
        'Public Temperature() As String      '溫度設定
        'Public Temperature_Rate() As String '溫速設定
        'Public Time() As String             '保持時間
        'Public STEPNote() As String         '步驟註解
        'Public StepTime() As Integer        '每步所需時間
        '
        Public TotalTime As Integer         '配方總時間
        Public TotalStep() As Integer         '單頭配方總時間

        ''陽極壓合
        'Public DC() As String               '陽極電壓
        'Public DC_Rate() As String          '電壓升速
        'Public BondMode() As String         '陽極壓合模式

        Public WaferSize As String          '晶圓尺寸
        Public BondingMode As String        '壓合模式
        Public PumpingMode As String        '是否是用真空壓合, 0=大氣, 1=真空
        Public KeepBonding As String        '結束後持壓
        Public BondingSync As String        '製程繼續模式-> 0=同時, 1=溫度, 2=壓力
        Public VacuumPurge As String        '抽氣前PURGE
        Public BondBeforeVacuum As String   '抽氣前壓合
        Public AutoVent As String           '製程後 VENT
        Public AfterPurge As String           '製程後 VENT
        Public AutoDoorOpen As String           '製程後 VENT

        'Purge Function
        Public PurgeCooling As String
        Public PurgeCoolingTemp As String
        Public PurgeONTime As String
        Public PurgeOFFTime As String
        Public PurgeKeepBonding As String
    End Structure
    '配方結構變數
    Public RecipeNum(3) As Recipes
    Public Const RecipeRunIndex As Integer = 0      '製程執行 配方索引
    Public Const RecipeEditIndex As Integer = 1     '配方編輯 配方索引
    Public Const RecipeRecord1Index As Integer = 2  '曲線記錄1 配方索引
    Public Const RecipeRecord2Index As Integer = 3  '曲線記錄2 配方索引


    '讀取上下限設定
    Public Sub ReadSetupLimit()     '讀取上下限設定
        PRESS_MAX = ReadProgData("LIMIT_SETUP", "PRESS_MAX", "3000", ProgramINIFile)
        PRESS_MIN = ReadProgData("LIMIT_SETUP", "PRESS_MIN", "0", ProgramINIFile)
        PRESSRATE_MAX = ReadProgData("LIMIT_SETUP", "PRESSRATE_MAX", "9999", ProgramINIFile)
        PRESSRATE_MIN = ReadProgData("LIMIT_SETUP", "PRESSRATE_MIN", "0", ProgramINIFile)
        TEMP_MAX = ReadProgData("LIMIT_SETUP", "TEMP_MAX", "9999", ProgramINIFile)
        TEMP_MIN = ReadProgData("LIMIT_SETUP", "TEMP_MIN", "0", ProgramINIFile)
        TEMPRATE_MAX = ReadProgData("LIMIT_SETUP", "TEMPRATE_MAX", "9999", ProgramINIFile)
        TEMPRATE_MIN = ReadProgData("LIMIT_SETUP", "TEMPRATE_MIN", "0", ProgramINIFile)
        WAFERSIZE_MAX = ReadProgData("LIMIT_SETUP", "WAFERSIZE_MAX", "9999", ProgramINIFile)
        WAFERSIZE_MIN = ReadProgData("LIMIT_SETUP", "WAFERSIZE_MIN", "0", ProgramINIFile)
        TEMPRANGE_MAX = ReadProgData("LIMIT_SETUP", "TEMPRANGE_MAX", "9999", ProgramINIFile)
        TEMPRANGE_MIN = ReadProgData("LIMIT_SETUP", "TEMPRANGE_MIN", "0", ProgramINIFile)
        TIME_MAX = ReadProgData("LIMIT_SETUP", "TIME_MAX", "9999", ProgramINIFile)
        TIME_MIN = ReadProgData("LIMIT_SETUP", "TIME_MIN", "0", ProgramINIFile)
        NORMAL_MAX = ReadProgData("LIMIT_SETUP", "NORMAL_MAX", "9999", ProgramINIFile)
        NORMAL_MIN = ReadProgData("LIMIT_SETUP", "MORMAL_MIN", "0", ProgramINIFile)
        VACUUM_MAX = ReadProgData("LIMIT_SETUP", "VACUUM_MAX", "9999", ProgramINIFile)
        VACUUM_MIN = ReadProgData("LIMIT_SETUP", "VACUUM_MIN", "0", ProgramINIFile)
        AdjustDA_Max = ReadProgData("LIMIT_SETUP", "AdjustDA_Max", "15", ProgramINIFile)
        AdjustOverPress_Max = ReadProgData("LIMIT_SETUP", "AdjustOverPress_Max", "15", ProgramINIFile)
        PressPID_P_Max = ReadProgData("LIMIT_SETUP", "PressPID_P_Max", "50", ProgramINIFile)
        PressPID_I_Max = ReadProgData("LIMIT_SETUP", "PressPID_I_Max", "50", ProgramINIFile)
        'Public AdjustDA_Max As String
        'Public AdjustOverPress_Max As String
        'Public PressPID_P_Max As String
        'Public PressPID_I_Max As String


    End Sub
    Public Function GetStepTimeI0(ByVal a As Integer, ByVal b As Integer, ByVal c As Integer, ByVal d As Single, ByVal e As Integer) As Integer
        Dim i, j, k As Single
        i = 0
        If b > 0 Then
            i = a / b
        End If
        j = 0
        If d > 0 Then
            j = (c - 25) / d
        End If
        If i < j Then
            i = j
        End If
        k = i + e
        GetStepTimeI0 = CInt(k)
    End Function
    Public Function GetStepTimeI(ByVal a As Integer, ByVal b As Integer, ByVal c As Integer, ByVal d As Single, ByVal e As Integer, ByVal g As Integer, ByVal h As Integer) As Integer
        Dim i, j, k As Integer
        i = 0
        If b > 0 Then
            i = Math.Abs((a - g) / b)
        End If
        j = 0
        If d > 0 Then
            j = Math.Abs((c - h) / d)
        End If
        If i < j Then
            i = j
        End If
        k = i + e
        GetStepTimeI = CInt(k)
    End Function


    '建立個配方結構陣列, 維度為2, 0=製程載入使用, 1=配方編輯使用
    Public SelectRecipeIndex As Integer                 '
    '配方欄位名稱 
    Public RecipeRowHeader(2, 200) As String
    Public Recipe_Num As Integer
    Public Recipe_Type As String
    Public Recipe_Change As Integer


    Public Sub InitRecipe(ByVal sdir As String)
        RecipeINIFile = sdir + "RECIPE.INI"           '程式資料INI檔案
        ReadSetupLimit()
        'RecipeFileInstall()
    End Sub
    '建立配方欄位
    Public Sub RecipeInit(ByVal sfile As String)
        ReadRecipeColumnData(RecipeINIFile)
        CreateRecipeDataGrid(FormRecipes.dgRecipeEdit)                  '建立配方欄位
        RecipeStructReDim(Recipe_Max)                                   '載入配方資料
    End Sub
    '配方資料初始化
    Public Sub RecipeStructReDim(ByVal recipe As Integer)
        Dim i As Integer
        Dim j, k As Integer
        For i = 0 To 3
            ReDim RecipeNum(i).Plate(MAXPLATE)
            ''ReDim RecipeNum(i).DC(Recipe_Max)
            ''ReDim RecipeNum(i).DC_Rate(Recipe_Max)
            ''ReDim RecipeNum(i).BondingSync(Recipe_Max)
            ''ReDim RecipeNum(i).BondMode(Recipe_Max)
            For k = 0 To MAXPLATE
                ReDim RecipeNum(i).Plate(k).Pressure(Recipe_Max)
                ReDim RecipeNum(i).Plate(k).Pressure_Rate(Recipe_Max)
                ReDim RecipeNum(i).Plate(k).Temperature(Recipe_Max)
                ReDim RecipeNum(i).Plate(k).Temperature_Rate(Recipe_Max)
                ReDim RecipeNum(i).Plate(k).Time(Recipe_Max)
                ReDim RecipeNum(i).Plate(k).STEPNote(Recipe_Max)
                ReDim RecipeNum(i).Plate(k).StepTime(Recipe_Max)
            Next
        Next
    End Sub
    '讀取配方資料欄位標題
    Public Sub ReadRecipeColumnData(ByVal sfile As String)
        Dim i, j, k As Integer
        Dim lang As String
        k = 0
        Recipe_Num = Val(ReadProgData("RECIPE", "RECIPE_NUM", "0", sfile))
        Recipe_Change = Val(ReadProgData("RECIPE", "RECIPE_COLOR_CHANGE", "0", sfile))
        For i = 0 To 2
            Select Case i
                Case 0
                    lang = "RECIPE_CHT"
                Case 1
                    lang = "RECIPE_CHT"
                Case 2
                    lang = "RECIPE_ENG"
            End Select
            For j = 0 To Recipe_Num
                If i = 1 Then
                    RecipeRowHeader(i, j) = StrConv(RecipeRowHeader(0, j), VbStrConv.SimplifiedChinese, 2052)
                Else
                    RecipeRowHeader(i, j) = ReadProgData(lang, "RECIPE" + Format(j, "00"), "0", sfile)
                End If

            Next
        Next
    End Sub

    '改變配方欄位標題語言
    Public Sub ChangeRecipeColumnHeader(ByVal dg As DataGridView)
        Dim i As Integer
        Dim j As Integer
        j = 0
        For i = 0 To TableMax - 1
            dg.Rows(i).HeaderCell.Value = RecipeRowHeader(SystemLanguage, i)
            'dg.Rows(i).HeaderCell.Style.ForeColor = Color.Black
            'dg.Rows(i).HeaderCell.Style.Font = New Font("Arial", 9, System.Drawing.FontStyle.Regular)
            '    If j > (Recipe_Change - 1) Then
            '        dg.Rows(i).HeaderCell.Style.BackColor = Color.LightCyan
            '    Else
            '        dg.Rows(i).HeaderCell.Style.BackColor = Color.LightGreen
            '    End If
            '    If ((i + 1) Mod Recipe_Change) = 0 Then dg.Rows(i).HeaderCell.Style.BackColor = Color.LightGray

            '    j += 1
            '    If j > (Recipe_Change * 2 - 1) Then
            '        j = 0
            '    End If
        Next
    End Sub

    '建立編輯配方資料表格
    Public Sub CreateRecipeDataGrid(ByRef dg As DataGridView)
        Dim i, j As Integer
        Dim totaltable As Integer
        TableMax = Recipe_Num + 1
        totaltable = TableMax - 1
        TableWidth = 80           '資料欄位寬度
        TableHeight = 31 '(dg.Height / ((Recipe_Change * 3) + 2))     '資料欄位高度_ '30
        RowHeaderWidth = 200      '資料欄位標題寬度
        dg.Height = TableHeight * (Recipe_Change * 3) + dg.ColumnHeadersHeight + 3
        rwstepindex = 1

        dg.ColumnCount = rwstepindex
        dg.ColumnHeadersDefaultCellStyle.Font = New Font("ARIAL", 9, System.Drawing.FontStyle.Regular)
        dg.ColumnHeadersDefaultCellStyle.BackColor = Color.Khaki
        dg.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        dg.ColumnHeadersHeightSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dg.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dg.ScrollBars = ScrollBars.Horizontal
        dg.ColumnHeadersHeight = TableHeight
        dg.Columns(rwstepindex - 1).Name = "Step 01"
        dg.Columns(rwstepindex - 1).Width = TableWidth
        dg.Columns(rwstepindex - 1).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        dg.Columns(rwstepindex - 1).SortMode = DataGridViewColumnSortMode.NotSortable
        dg.Columns(rwstepindex - 1).DefaultCellStyle.Font = New Font("Arial", 9, System.Drawing.FontStyle.Regular)
        dg.Columns(rwstepindex - 1).DefaultCellStyle.ForeColor = Color.Black
        dg.Columns(rwstepindex - 1).DefaultCellStyle.BackColor = Color.Khaki
        dg.Columns(rwstepindex - 1).SortMode = DataGridViewColumnSortMode.NotSortable
        dg.ScrollBars = ScrollBars.Horizontal


        dg.RowHeadersVisible = True
        dg.RowHeadersWidth = RowHeaderWidth
        dg.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dg.RowHeadersDefaultCellStyle.ForeColor = Color.Black
        dg.DefaultCellStyle.Font = New Font("ARIAL", 9, System.Drawing.FontStyle.Regular)
        dg.RowCount = TableMax

        dg.Rows(0).Height = TableHeight
        dg.Rows(0).HeaderCell.Value = RecipeRowHeader(SystemLanguage, i)
        dg.Rows(0).HeaderCell.Style.Font = New Font("Arial", 9, System.Drawing.FontStyle.Regular)
        dg.Item(rwstepindex - 1, 0).Value = "0"
        dg.Rows(0).DefaultCellStyle.BackColor = Color.White


        dg.Rows(1).Height = TableHeight
        dg.Rows(1).HeaderCell.Value = RecipeRowHeader(SystemLanguage, i)
        dg.Rows(1).HeaderCell.Style.Font = New Font("Arial", 9, System.Drawing.FontStyle.Regular)
        dg.Item(rwstepindex - 1, 1).Value = "0"
        dg.Rows(1).DefaultCellStyle.BackColor = Color.White
        j = 0
        For i = 0 To TableMax - 1
            dg.Rows(i).Height = TableHeight
            dg.Rows(i).HeaderCell.Value = RecipeRowHeader(SystemLanguage, i)
            dg.Rows(i).HeaderCell.Style.Font = New Font("Arial", 9, System.Drawing.FontStyle.Regular)
            dg.Item(rwstepindex - 1, i).Value = "0"

            If j >= Recipe_Change Then
                dg.Rows(i).DefaultCellStyle.BackColor = Color.LightCyan
            Else
                dg.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen
            End If
            If ((i + 1) Mod Recipe_Change) = 0 Then dg.Rows(i).DefaultCellStyle.BackColor = Color.LightGray
            j += 1
            If j > (Recipe_Change * 2 - 1) Then
                j = 0
            End If
        Next

    End Sub
End Module

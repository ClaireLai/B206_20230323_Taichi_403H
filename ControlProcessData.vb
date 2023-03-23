Imports System.Runtime.InteropServices
Public Class ControlProcessData
    '配方結構
    '<StructLayout(LayoutKind.Sequential)> Structure sPlateRecipe
    '    Public Pressure() As String         '壓力設定
    '    Public Pressure_Rate() As String    '壓速設定
    '    Public Temperature() As String      '溫度設定
    '    Public Temperature_Rate() As String '溫速設定
    '    Public Time() As String             '保持時間
    '    Public STEPNote() As String         '步驟註解
    '    Public StepTime() As Integer        '每步所需時間
    '    Public TotalTime As Integer         '單頭配方總時間
    '    Public TotalStep As Integer         '單頭配方總時間
    'End Structure

    'Private subPlateRecipe As New sPlateRecipe
    Private SubProcessStepIndex As Integer  '製程 STEP 數
    'Private RecipeLoaded As Boolean

    'Public Sub LoadPlateRecipe(ByRef sRecipe As Module_Recipe_Public.sPlateRecipe)
    '    subPlateRecipe = sRecipe
    '    SubProcessStepIndex = 0
    '    PressuseSet = subPlateRecipe.Pressure(SubProcessStepIndex)
    '    PressuseRate = subPlateRecipe.Pressure_Rate(SubProcessStepIndex)
    '    TempSet = subPlateRecipe.Temperature(SubProcessStepIndex)
    '    TempRateSet = subPlateRecipe.Temperature_Rate(SubProcessStepIndex)
    '    HoldTimeSet = subPlateRecipe.Time(SubProcessStepIndex)
    '    StepSet = subPlateRecipe.TotalStep
    '    StepNote = subPlateRecipe.STEPNote(SubProcessStepIndex)
    '    RecipeLoaded = True
    'End Sub

    Public Sub SetRecipeIndex(ByVal index As Integer)
        SubProcessStepIndex = index
        If SubProcessStepIndex <= (RecipeNum(RecipeRunIndex).Plate(SiteNum).TotalStep - 1) Then
            PressuseSet = RecipeNum(RecipeRunIndex).Plate(SiteNum).Pressure(SubProcessStepIndex)
            PressuseRate = RecipeNum(RecipeRunIndex).Plate(SiteNum).Pressure_Rate(SubProcessStepIndex)
            TempSet = RecipeNum(RecipeRunIndex).Plate(SiteNum).Temperature(SubProcessStepIndex)
            TempRateSet = RecipeNum(RecipeRunIndex).Plate(SiteNum).Temperature_Rate(SubProcessStepIndex)
            HoldTimeSet = RecipeNum(RecipeRunIndex).Plate(SiteNum).Time(SubProcessStepIndex)
            StepSet = (SubProcessStepIndex + 1).ToString + "/" + RecipeNum(RecipeRunIndex).Plate(SiteNum).TotalStep.ToString
            StepNote = RecipeNum(RecipeRunIndex).Plate(SiteNum).STEPNote(SubProcessStepIndex)
            StepTimeMin = RecipeNum(RecipeRunIndex).Plate(SiteNum).StepTime(SubProcessStepIndex).ToString + "/" + RecipeNum(RecipeRunIndex).Plate(SiteNum).TotalTime.ToString
            If RecipeNum(RecipeRunIndex).Plate(SiteNum).TotalTime > 0 Then
                lblStepIndex.Text = Format(RecipeNum(RecipeRunIndex).Plate(SiteNum).StepTime(SubProcessStepIndex) / RecipeNum(RecipeRunIndex).Plate(SiteNum).TotalTime, "0.0%")
            Else
                lblStepIndex.Text = "---"
            End If
        End If
    End Sub
    Public Sub NextRecipe()
        If SubProcessStepIndex < (RecipeNum(RecipeRunIndex).Plate(SiteNum).TotalStep - 1) Then
            SubProcessStepIndex += 1
            SetRecipeIndex(SubProcessStepIndex)
        End If
    End Sub
    Public Sub PrevRecipe()
        If SubProcessStepIndex > 0 Then
            SubProcessStepIndex -= 1
            SetRecipeIndex(SubProcessStepIndex)
        End If
    End Sub

    Private SiteNum As Integer
    ''' <summary>
    ''' 建構子
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        ' 此為 Windows Form 設計工具所需的呼叫。
        InitializeComponent()
    End Sub
    ''' <summary>
    ''' 初始化
    ''' </summary>
    ''' <param name="iSiteNum">由0開始的索引值</param>
    ''' <remarks></remarks>
    Public Sub Initial(ByVal iSiteNum As Integer)
        SiteNum = iSiteNum
    End Sub
    '屬性
    ''' <summary>
    ''' 設定抬頭名稱
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property Title() As String
        Get
            Return grpTitle.Text
        End Get
        Set(ByVal value As String)
            grpTitle.Text = value
        End Set
    End Property
    ''' <summary>
    ''' 設定顯示壓力
    ''' </summary>
    ''' <value></value>
    ''' <remarks></remarks>
    WriteOnly Property PressuseSet() As String
        Set(ByVal value As String)
            lblPressureSet.Text = value
        End Set
    End Property
    ''' <summary>
    ''' 設定顯示壓速
    ''' </summary>
    ''' <value></value>
    ''' <remarks></remarks>
    WriteOnly Property PressuseRate() As String
        Set(ByVal value As String)
            lblPressureRateSet.Text = value
        End Set
    End Property
    ''' <summary>
    ''' 設定顯示溫度值
    ''' </summary>
    ''' <value></value>
    ''' <remarks></remarks>
    WriteOnly Property TempSet() As String
        Set(ByVal value As String)
            lblTempSet.Text = value
        End Set
    End Property
    ''' <summary>
    ''' 設定顯示溫速
    ''' </summary>
    ''' <value></value>
    ''' <remarks></remarks>
    WriteOnly Property TempRateSet() As String
        Set(ByVal value As String)
            lblTempRateSet.Text = value
        End Set
    End Property
    ''' <summary>
    ''' 設定顯示保持時間
    ''' </summary>
    ''' <value></value>
    ''' <remarks></remarks>
    WriteOnly Property HoldTimeSet() As String
        Set(ByVal value As String)
            lblHoldTimeSet.Text = value
        End Set
    End Property
    '設定顯示步驟總數
    ''' <summary>
    ''' 設定顯示步驟總數
    ''' </summary>
    ''' <value></value>
    ''' <remarks></remarks>
    WriteOnly Property StepSet() As String
        Set(ByVal value As String)
            lblTotalStepSet.Text = value
        End Set
    End Property
    ''' <summary>
    ''' 設定顯示步驟註解
    ''' </summary>
    ''' <value></value>
    ''' <remarks></remarks>
    WriteOnly Property StepNote() As String
        Set(ByVal value As String)
            lblStepNote.Text = value
        End Set
    End Property
    ''' <summary>
    ''' 設定顯示步驟時間
    ''' </summary>
    ''' <value></value>
    ''' <remarks></remarks>
    WriteOnly Property StepTimeMin() As String
        Set(ByVal value As String)
            lblStepTimeMin.Text = value
        End Set
    End Property

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        NextRecipe()
    End Sub

    Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click
        PrevRecipe()
    End Sub
End Class

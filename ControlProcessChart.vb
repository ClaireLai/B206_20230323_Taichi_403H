Imports System.Windows.Forms.DataVisualization.Charting

Public Class ControlProcessChart
    Private SiteNum As Integer
    Private CurveFreeze As Boolean
    Public Chart1 As New Chart
    Private cColor As ColorDialog

    Property Title() As String
        Get
            Return Chart1.Titles(0).Text
        End Get
        Set(ByVal value As String)
            If Chart1.Titles.Count > 0 Then Chart1.Titles(0).Text = value
        End Set
    End Property

    Property Freeze() As String
        Get
            Return CurveFreeze
        End Get
        Set(ByVal value As String)
            CurveFreeze = value
            ObjShow.Show(CurveFreeze, btnCurveFreeze, Color.Lime, Color.FromArgb(255, 255, 192))
        End Set
    End Property

    Sub New()

        ' 此為 Windows Form 設計工具所需的呼叫。
        InitializeComponent()

        ' 在 InitializeComponent() 呼叫之後加入任何初始設定。

    End Sub
    Public Sub Initial(ByVal iSiteNum As Integer)
        SiteNum = iSiteNum
        InitChart(pnlChart, Chart1)
        AddHandler Chart1.CursorPositionChanged, AddressOf Chart1_CursorPositionChanging
        cColor = New ColorDialog
    End Sub

    Private ShowFlag As Integer
    Private Sub btnShowSeriesName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowSeriesName.Click
        Select Case ShowFlag
            Case 0
                pnlProcessCSelect.Visible = True
                ControlDataShowVertical1.Visible = False
                ShowFlag = 1
            Case 1
                pnlProcessCSelect.Visible = False
                ControlDataShowVertical1.Visible = False
                ShowFlag = 2
            Case 2
                pnlProcessCSelect.Visible = False
                ControlDataShowVertical1.Visible = True
                ShowFlag = 0
        End Select
    End Sub

    Private Sub btnCurveFreeze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCurveFreeze.Click
        CurveFreeze = Not CurveFreeze
        ObjShow.Show(CurveFreeze, btnCurveFreeze, Color.Lime, Color.FromArgb(255, 255, 192))
    End Sub


    Public Sub InitChart(ByRef frm As Object, ByRef cChart As Chart, Optional ByVal Title As String = "Chart") ', _
        ''Optional ByVal iX As Integer = 3, Optional ByVal iY As Integer = 15, Optional ByVal iW As Integer = 97, Optional ByVal iH As Integer = 100)
        Dim i As Integer
        Dim Index As Integer = 0
        'cChart = New Chart
        cChart.Palette = ChartColorPalette.Bright
        frm.Controls.Add(cChart)
        cChart.Width = frm.Width
        cChart.Height = frm.Height
        cChart.ChartAreas.Add(Title)
        cChart.Titles.Add("Plate")
        CreateSeries(cChart, "TopTemp", Color.Red)
        CreateSeries(cChart, "BotTemp", Color.Blue)
        CreateSeries(cChart, "Pressure", Color.Black)
        CreateSeries(cChart, "PresetTemp", Color.Purple)
        CreateSeries(cChart, "PresetPress", Color.Silver)

        cChart.Series(0).Color = Color.Red
        cChart.Series(1).Color = Color.Blue
        cChart.Series(2).Color = Color.Black
        cChart.Series(3).Color = Color.Orange
        cChart.Series(4).Color = Color.Cyan

        btnColor01.BackColor = Color.Red
        btnColor02.BackColor = Color.Blue
        btnColor03.BackColor = Color.Black
        btnColor04.BackColor = Color.Orange
        btnColor05.BackColor = Color.Cyan

        'cChart.ChartAreas(0).Position.X = iX
        'cChart.ChartAreas(0).Position.Y = iY
        'cChart.ChartAreas(0).Position.Width = iW
        'cChart.ChartAreas(0).Position.Height = iH


        cChart.BackColor = System.Drawing.SystemColors.Control
        cChart.ChartAreas(0).BackColor = System.Drawing.SystemColors.Control


        cChart.ChartAreas(0).AxisX.Minimum = [Double].NaN            'X軸 設定 CHART X軸 的最小刻度為 自動
        cChart.ChartAreas(0).AxisX.Maximum = MAX_X_SCALE               'X軸 設定 CHART X軸 的最大刻度為 MAX_X_SCALE
        cChart.ChartAreas(0).AxisX.MajorGrid.LineColor = Color.LightGray

        cChart.ChartAreas(0).AxisX.ScaleView.Zoomable = True         'X軸 可放大,縮小
        cChart.ChartAreas(0).AxisX.ScrollBar.IsPositionedInside = False   'X軸 使用捲軸, 並設在圖表外側
        cChart.ChartAreas(0).AxisX.ScrollBar.Size = 20                       'X軸 設定捲軸大小,最大為20
        cChart.ChartAreas(0).AxisX.ScrollBar.BackColor = Color.LightGray
        cChart.ChartAreas(0).AxisX.ScrollBar.ButtonColor = Color.LightGray


        cChart.ChartAreas(0).CursorX.IsUserEnabled = True            'X軸 使用 游標控制
        cChart.ChartAreas(0).CursorX.IsUserSelectionEnabled = True   'X軸 可使用 使用者拖曳選擇
        cChart.ChartAreas(0).CursorX.AutoScroll = True                   'X軸 捲軸自動產生

        cChart.ChartAreas(0).AxisY.Minimum = [Double].NaN                'X軸 設定 CHART X軸 的最小刻度為 自動
        cChart.ChartAreas(0).AxisY.Maximum = [Double].NaN                'X軸 設定 CHART X軸 的最大刻度為 MAX_X_SCALE
        cChart.ChartAreas(0).AxisY.MajorGrid.LineColor = Color.LightGray

        cChart.ChartAreas(0).AxisY.ScaleView.Zoomable = True             'X軸 可放大,縮小
        cChart.ChartAreas(0).AxisY.ScrollBar.IsPositionedInside = False   'X軸 使用捲軸, 並設在圖表外側
        cChart.ChartAreas(0).AxisY.ScrollBar.Size = 20                    'X軸 設定捲軸大小,最大為20
        cChart.ChartAreas(0).AxisY.ScrollBar.BackColor = Color.LightGray
        cChart.ChartAreas(0).AxisY.ScrollBar.ButtonColor = Color.LightGray

        cChart.ChartAreas(0).CursorY.IsUserEnabled = True                'X軸 使用 游標控制
        cChart.ChartAreas(0).CursorY.IsUserSelectionEnabled = True       'X軸 可使用 使用者拖曳選擇
        cChart.ChartAreas(0).CursorY.AutoScroll = True                    'X軸 捲軸自動產生


        cChart.ChartAreas(0).AxisY2.Minimum = [Double].NaN                'X軸 設定 CHART X軸 的最小刻度為 自動
        cChart.ChartAreas(0).AxisY2.Maximum = [Double].NaN                'X軸 設定 CHART X軸 的最大刻度為 MAX_X_SCALE
        cChart.ChartAreas(0).AxisY2.MajorGrid.LineColor = Color.LightGray

        cChart.ChartAreas(0).AxisY2.ScaleView.Zoomable = True             'X軸 可放大,縮小
        cChart.ChartAreas(0).AxisY2.ScrollBar.IsPositionedInside = False   'X軸 使用捲軸, 並設在圖表外側
        cChart.ChartAreas(0).AxisY2.ScrollBar.Size = 20                    'X軸 設定捲軸大小,最大為20
        cChart.ChartAreas(0).AxisY2.ScrollBar.BackColor = Color.LightGray
        cChart.ChartAreas(0).AxisY2.ScrollBar.ButtonColor = Color.LightGray
        cChart.ChartAreas(0).AxisY2.Enabled = AxisEnabled.Auto
        cChart.ChartAreas(0).AxisY2.MajorGrid.LineColor = Color.LightPink


        'cChart.Series(0).YAxisType = AxisType.Secondary
        'cChart.Series(1).YAxisType = AxisType.Secondary
        'cChart.Series(2).YAxisType = AxisType.Primary
        'cChart.Series(3).YAxisType = AxisType.Secondary
        'cChart.Series(4).YAxisType = AxisType.Primary

    End Sub
    Public Sub CreateSeries(ByRef cChart As Chart, ByVal Name As String, ByVal iColor As Color)
        Dim i As Integer
        cChart.Palette = ChartColorPalette.Excel
        cChart.Series.Add(Name)
        cChart.Series(Name).ChartType = SeriesChartType.FastLine
        cChart.Series(i).Color = iColor
    End Sub
    Private Sub btnCurveReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCurveReset.Click
        ResetCurve(Chart1)
    End Sub

    Private Sub btnPrintCurve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintCurve.Click
        printCurve(Chart1, "Plate" + SiteNum.ToString + Date.Today)
    End Sub



    Private Sub ResetCurve(ByRef cChart As Chart, Optional ByVal iChartAreas As Integer = 0)
        cChart.ChartAreas(iChartAreas).AxisX.ScaleView.ZoomReset()
        cChart.ChartAreas(iChartAreas).AxisY.ScaleView.ZoomReset()
        'cChart.ChartAreas(iChartAreas).AxisX.Minimum = [Double].NaN
        'cChart.ChartAreas(iChartAreas).AxisX.Maximum = [Double].NaN
        cChart.ChartAreas(iChartAreas).AxisY.Minimum = [Double].NaN
        cChart.ChartAreas(iChartAreas).AxisY.Maximum = [Double].NaN
        cChart.ChartAreas(iChartAreas).RecalculateAxesScale()
    End Sub
    Private Sub printCurve(ByVal cChart As Chart, Optional ByVal sTitle As String = "Cello Records Curve")
        ' Show Page Setup dialo g
        'cChart.Printing.PageSetup()
        ' Print preview chart
        cChart.Printing.PrintDocument.DocumentName = sTitle
        cChart.Printing.PrintDocument.OriginAtMargins = True
        cChart.Printing.PrintDocument.DefaultPageSettings.Landscape = True
        cChart.Printing.PrintPreview()
        ' Print chart (without Printer dialog)
        cChart.Printing.Print(True)
    End Sub

    Private Sub chkTopTemp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
    chkTopTemp.CheckedChanged, chkBotTemp.CheckedChanged, chkPressure.CheckedChanged, _
    chkPresetPress.CheckedChanged, chkPresetTemp.CheckedChanged
        If Chart1.Series.Count > sender.tabindex Then Chart1.Series(sender.Tabindex).Enabled = sender.checked
    End Sub

    Private Sub btnColor01_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
    btnColor01.Click, btnColor02.Click, btnColor03.Click, btnColor04.Click, btnColor05.Click
        If cColor.ShowDialog() = DialogResult.OK Then
            sender.backcolor = cColor.Color
            Chart1.Series(sender.Tabindex).Color = cColor.Color
        End If
    End Sub

    Private Sub btnSaveAs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveAs.Click
        SaveChartToJPG(Chart1)
    End Sub

    Private Sub SaveChartToJPG(ByVal cChart As Chart)
        Dim sFile As String
        If FormkeyInFileNames.ShowDialog() = DialogResult.OK Then
            If FormkeyInFileNames.FileName = "" Then
                sFile = JPGDir + FDate + "_" + FTime + ".JPG"
            Else
                sFile = JPGDir + FormkeyInFileNames.FileName + ".JPG"
            End If
            cChart.SaveImage(sFile, DataVisualization.Charting.ChartImageFormat.Jpeg)
        End If

    End Sub


    Private Sub Chart1_CursorPositionChanging(ByVal sender As Object, ByVal e As System.Windows.Forms.DataVisualization.Charting.CursorEventArgs)
        Dim i, j, k As Integer
        Static CursorX As String
        Static CursorY As String
        If Double.IsNaN(e.NewPosition) Then
            Return
        End If
        If e.Axis.AxisName = AxisName.X Then
            CursorX = e.NewPosition.ToString
            'If e.NewPosition < ChartRecord.Series(0).Points.Count Then

            If e.NewPosition < Chart1.Series(0).Points.Count Then
                ControlDataShowVertical1.SetTopTemp = Chart1.Series(0).Points(e.NewPosition).YValues(0).ToString
            Else
                ControlDataShowVertical1.SetTopTemp = "xxx"
            End If
            If e.NewPosition < Chart1.Series(1).Points.Count Then
                ControlDataShowVertical1.SetBotTemp = Chart1.Series(1).Points(e.NewPosition).YValues(0).ToString
            Else
                ControlDataShowVertical1.SetBotTemp = "xxx"
            End If
            If e.NewPosition < Chart1.Series(2).Points.Count Then
                ControlDataShowVertical1.SetPressure = Chart1.Series(2).Points(e.NewPosition).YValues(0).ToString
            Else
                ControlDataShowVertical1.SetPressure = "xxx"
            End If
            If e.NewPosition < Chart1.Series(3).Points.Count Then
                ControlDataShowVertical1.SetTempPreset = Chart1.Series(3).Points(e.NewPosition).YValues(0).ToString
            Else
                ControlDataShowVertical1.SetTempPreset = "xxx"
            End If
            If e.NewPosition < Chart1.Series(4).Points.Count Then
                ControlDataShowVertical1.SetPressurePreset = Chart1.Series(4).Points(e.NewPosition).YValues(0).ToString
            Else
                ControlDataShowVertical1.SetPressurePreset = "xxx"
            End If
        Else
            CursorY = e.NewPosition.ToString
        End If
    End Sub

    Public StopZoomFlag As Boolean
    Private Sub btnStopZoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStopZoom.Click
        StopZoomFlag = Not StopZoomFlag
        ObjShow.Show(StopZoomFlag, btnStopZoom, Color.Lime, Color.FromArgb(192, 192, 255))
        If StopZoomFlag Then
            Chart1.ChartAreas(0).AxisX.ScaleView.Zoomable = False          'X軸 可放大,縮小
            Chart1.ChartAreas(0).AxisY.ScaleView.Zoomable = False          'X軸 可放大,縮小
            Chart1.ChartAreas(0).AxisY2.ScaleView.Zoomable = False          'X軸 可放大,縮小
        Else
            Chart1.ChartAreas(0).AxisX.ScaleView.Zoomable = True          'X軸 可放大,縮小
            Chart1.ChartAreas(0).AxisY.ScaleView.Zoomable = True          'X軸 可放大,縮小
            Chart1.ChartAreas(0).AxisY2.ScaleView.Zoomable = True          'X軸 可放大,縮小
        End If
    End Sub

    Private Sub lblAxis1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
    lblAxis1.Click, lblAxis2.Click, lblAxis3.Click, lblAxis4.Click, lblAxis5.Click
        Dim index As Integer
        index = sender.Tabindex
        If index > Chart1.Series.Count Then Exit Sub
        If sender.Text = "1" Then
            sender.Text = "2"
            Chart1.Series(index).YAxisType = AxisType.Secondary
        Else
            sender.Text = "1"
            Chart1.Series(index).YAxisType = AxisType.Primary
        End If
    End Sub
End Class

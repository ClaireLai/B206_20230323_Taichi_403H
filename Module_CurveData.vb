Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Runtime.InteropServices

Module Module_CurveData
    Public CurveDataINI As String
    Public Const CURVE_FIRST As Integer = 0
    Public Const CURVE_SECOND As Integer = 8
    Public TempInSecondary As Boolean
    Public Title() As String
    Public bolDA As Boolean

    'Public Sub InitCurveData(ByVal sdir As String)
    '    'CurveDataINI = sdir + "CURVEDATA_DA.INI"        '程式資料INI檔案
    '    'CurveDataINI = sdir + "CURVEDATA.INI"        '程式資料INI檔案
    '    ReadCurveNames(CurveDataINI)
    '    '' 建立製程用曲線
    '    'ChartInitial()
    'End Sub
    Public CurveName(2, 31) As String
    Public MAX_CURVES As Integer = 1
    Public MAX_X_SCALE As Integer = 2000
    Public Enum CurveNames
        TopTemp = 0   'CL2
        BotTemp = 1   'BCl3
        Pressure = 2
        TopCurrent = 3   'NH3'
        BotCurrent = 4
        DPCurrent = 5
        Vacuum = 6
        PreSetTemp = 7
        PresetPress = 8
        TopTemp2 = 9   'CL2
        BotTemp2 = 10   'BCl3
        Pressure2 = 11
        TopCurrent2 = 12   'NH3'
        BotCurrent2 = 13
        DPCurrent2 = 14
        Vacuum2 = 15
        PreSetTemp2 = 16
        PresetPress2 = 17
    End Enum
    '    Chart1.Series("Series1").Points.DataBindY(TopTemp1)
    'Chart1.Series("Series2").Points.DataBindY(BotTemp1)
    'Chart1.Series("Series3").Points.DataBindY(TopCurrent1)
    'Chart1.Series("Series4").Points.DataBindY(BotCurrent1)
    'Chart1.Series("Series5").Points.DataBindY(Press1)
    'Chart1.Series("Series6").Points.DataBindY(DPCurrent1)
    'Chart1.Series("Series7").Points.DataBindY(Pressure1)
    '讀取曲線名稱
    Public Sub ReadCurveNames(ByVal sfile As String)
        Dim i As Integer
        'If SystemParameters.bolDAlog Then
        '    CurveDataINI = ProgramDir + "CURVEDATA_DA.INI"        '程式資料INI檔案 有DA欄位
        '    bolDA = True
        'Else
        '    CurveDataINI = ProgramDir + "CURVEDATA.INI"        '程式資料INI檔案
        '    bolDA = False
        'End If
        MAX_CURVES = Val(ReadProgData("CURVENAME_CHT", "CURVE_NUM", "1", sfile))
        If MAX_CURVES > 0 Then
            For i = 0 To MAX_CURVES
                CurveName(0, i) = ReadProgData("CURVENAME_CHT", "CURVE" + Format(i, "00"), "NoDefine" + Format(i, "00"), sfile)
                CurveName(1, i) = ReadProgData("CURVENAME_CHS", "CURVE" + Format(i, "00"), "NoDefine" + Format(i, "00"), sfile)
                CurveName(2, i) = ReadProgData("CURVENAME_ENG", "CURVE" + Format(i, "00"), "NoDefine" + Format(i, "00"), sfile)
            Next
        End If
    End Sub

    <StructLayout(LayoutKind.Sequential)> Structure RealTimeCurve
        Public TopTemperature() As Integer
        Public BotTemperature() As Integer
        Public TopCurrent() As Integer
        Public BotCurrent() As Integer
        Public BondingPressure() As Integer
        Public DCPower() As Integer
        Public DCCurrent() As Integer
        Public DPCurrent() As Integer
        Public Vacuum() As Integer
    End Structure

    Public RealTimeCurves(5) As RealTimeCurve              '即時曲線
    Public RealTimePreSetCurves(MAXPLATE) As RealTimeCurve        '預期曲線
    Public RecordPreSetCurves(1) As RealTimeCurve        '預期曲線
    Public DataLogCurveIndex As Integer     '曲線記錄用 index


    Public TimexManual As Integer
    Public Timex As Integer
    Public TotalStepTime As Integer
    Public Sub RealTimeCurveDataSave()
        Static iRef As Integer
        Dim i, j, k As Integer
        Dim XScale As Integer
        ' Simulation data 
        'Randomize()
        'For i = 0 To MAXPLATE
        '    Rnd(3500)
        '    TopTempPV(i) = 300 + Rnd() * 20
        '    BotTempPV(i) = 300 + Rnd() * 20
        '    PressPV(i) = 3000 + Rnd() * 20
        'Next
        'GaugeCHVac = Math.Abs(Math.Sin(6.28 * Timex / 300))
        If GaugeCHVac = 0 Then GaugeCHVac = 990
        ChartProcessVacuum.Series(0).Points.AddY(GaugeCHVac)
        ChartManualVacuum.Series(0).Points.AddY(GaugeCHVac)
        For i = 0 To MAXPLATE
            ManualCurve(i).Chart1.Series(0).Points.AddY(TopTempPV(i))
            ManualCurve(i).Chart1.Series(1).Points.AddY(BotTempPV(i))
            ManualCurve(i).Chart1.Series(2).Points.AddY(PressPV(i))
            ManualCurve(i).Chart1.Series(3).Points.AddY(Get_PLC_R1000(ADScalerB01Index + i))
        Next
        ' '' Simulation data 
        If TimexManual > MAX_XSCALE Then ' MAX_XSCALE - 10 Then
            ChartManualVacuum.Series(0).Points.RemoveAt(0)
            ChartProcessVacuum.Series(0).Points.RemoveAt(0)
            For i = 0 To MAXPLATE
                For j = 0 To 3
                    If ManualCurve(i).Chart1.Series(j).Points.Count > 0 Then ManualCurve(i).Chart1.Series(j).Points.RemoveAt(0)
                Next
            Next
        Else
            TimexManual += 1
        End If
        'Next
        ' Real TIme Data
        'If CurveFreeze = False Then

        If TotalStepTime > MAX_XSCALE Then
            XScale = TotalStepTime + 1000
        Else
            XScale = MAX_X_SCALE
        End If
        For i = 0 To MAXPLATE
            'ProcessCurve(i).Chart1.ChartAreas(0).AxisX.Maximum = XScale
            ProcessCurve(i).Chart1.Series(0).Points.AddY(TopTempPV(i)) 'Val(PLC_R_READ(ADTopTemp01Index)))
            ProcessCurve(i).Chart1.Series(1).Points.AddY(BotTempPV(i)) 'Val(PLC_R_READ(ADBottomTemperatureIndex)))
            ProcessCurve(i).Chart1.Series(2).Points.AddY(PressPV(i))
            'ProcessCurve(j).Chart1.Series(3).Points.AddY(DA1stPressIndex(i)))
            'ChartProcess.Series(CurveNames.Pressure).Points.AddY(PressPV(0)) 'Val(PLC_R_READ(ADBoundingP01Index)))
            'ChartProcess.Series(CurveNames.DPCurrent).Points.AddY(MPCurrent)
        Next
        If Timex > XScale - 100 Then
            For j = 0 To MAXPLATE
                For k = 0 To 4
                    If ProcessCurve(j).Chart1.Series(k).Points.Count > 0 Then ProcessCurve(j).Chart1.Series(k).Points.RemoveAt(0)
                Next
            Next
        Else
            Timex += 1
        End If
        'End If


        If iRef >= 10 Then
            For i = 0 To MAXPLATE
                ProcessCurve(i).Chart1.ChartAreas(0).RecalculateAxesScale()
                ManualCurve(i).Chart1.ChartAreas(0).RecalculateAxesScale()
            Next
            ChartManualVacuum.ChartAreas(0).RecalculateAxesScale()
            ChartProcessVacuum.ChartAreas(0).RecalculateAxesScale()
            iRef = 0
        Else
            iRef += 1
        End If
    End Sub

    'Public ChartProcess As Chart
    Public ChartManualVacuum As Chart
    'Public ChartCurrent As Chart
    Public ChartProcessVacuum As Chart
    Public ChartRecord As Chart

    '
    Public Sub CreateManualVacuumChart(ByRef obj As Object)
        '建立記錄曲線圖
        CreateChart(obj, ChartManualVacuum, "Vacuum")

        '建立記錄曲線 1條
        ChartManualVacuum.Series.Add("Vacuum")
        ChartManualVacuum.Series(0).ChartType = SeriesChartType.FastLine
        ChartManualVacuum.Series(0).Color = Color.Blue

        '設定曲線圖格式
        ChartManualVacuum.BackColor = Color.Lavender
        ChartManualVacuum.BackGradientStyle = DataVisualization.Charting.GradientStyle.DiagonalRight
        ChartManualVacuum.ChartAreas(0).BackColor = Color.AliceBlue
        ChartManualVacuum.ChartAreas(0).BackGradientStyle = DataVisualization.Charting.GradientStyle.DiagonalRight
        '設定曲線圖格式
        ChartManualVacuum.ChartAreas(0).AxisY.MajorGrid.Interval = 50
        ChartManualVacuum.ChartAreas(0).AxisY.MinorGrid.Interval = 0.01
        ChartManualVacuum.ChartAreas(0).AxisX.Maximum = 3000
        ChartManualVacuum.ChartAreas(0).AxisX.Minimum = 0
        'ChartManualVacuum.ChartAreas(0).AxisY.Maximum = [Double].NaN
        'ChartManualVacuum.ChartAreas(0).AxisY.Minimum = 0.0001
        ChartManualVacuum.ChartAreas(0).AxisY.LabelStyle.Format = "0.0E+00"
        ChartManualVacuum.ChartAreas(0).AxisY.IsLogarithmic = True
        ChartManualVacuum.ChartAreas(0).CursorX.Interval = 1
        ChartManualVacuum.ChartAreas(0).CursorY.Interval = 0.001

        ChartManualVacuum.Legends.Add("Vacuum")
        ChartManualVacuum.Legends(0).Docking = DataVisualization.Charting.Docking.Top
        ChartManualVacuum.Legends(0).BackColor = System.Drawing.SystemColors.Control

        AddHandler ChartManualVacuum.CursorPositionChanging, AddressOf ChartManual_CursorPositionChanging

    End Sub

    Public Sub CreateProcessVacuumChart(ByRef obj As Object)
        '建立記錄曲線圖
        CreateChart(obj, ChartProcessVacuum, "Vacuum")
        '建立記錄曲線 1條
        ChartProcessVacuum.Series.Add("Vacuum")
        ChartProcessVacuum.Series(0).ChartType = SeriesChartType.FastLine
        ChartProcessVacuum.Series(0).Color = Color.Blue

        '設定曲線圖格式
        ChartProcessVacuum.ChartAreas(0).AxisY.MajorGrid.Interval = 50
        ChartProcessVacuum.ChartAreas(0).AxisY.MinorGrid.Interval = 0.01
        ChartProcessVacuum.ChartAreas(0).AxisX.Maximum = 3000
        ChartProcessVacuum.ChartAreas(0).AxisX.Minimum = 0
        ChartProcessVacuum.ChartAreas(0).AxisY.LabelStyle.Format = "0.0E+00"
        ChartProcessVacuum.ChartAreas(0).AxisY.IsLogarithmic = True

        ChartProcessVacuum.ChartAreas(0).CursorX.Interval = 1
        ChartProcessVacuum.ChartAreas(0).CursorY.Interval = 0.001

        ChartProcessVacuum.Legends.Add("Vacuum")
        ChartProcessVacuum.Legends(0).Docking = DataVisualization.Charting.Docking.Top
        ChartProcessVacuum.Legends(0).BackColor = System.Drawing.SystemColors.Control
        AddHandler ChartProcessVacuum.CursorPositionChanging, AddressOf ChartProcess_CursorPositionChanging

    End Sub
    ' 建立製程用曲線
    Public Sub ChartInitial()
        Dim i As Integer
        On Error Resume Next
        ''建立記錄畫面曲線圖
        'CreateChartRecords(FormRecords.pnlRecordCurve, MAX_CURVES)

        '建立記錄畫面曲線選擇區
        'InitSeriesSelect(FormRecords.pnlRecordCSelect1, Record_Series, ChartRecord, 0)
        '建立手動畫面真空計曲線圖
        CreateManualVacuumChart(FormManuals.pnlVacuumCurve)
        ChartManualVacuum.ChartAreas(0).CursorX.Interval = 1
        ChartManualVacuum.ChartAreas(0).CursorY.Interval = 0.001
        '建立自動畫面真空計曲線圖
        CreateProcessVacuumChart(FormProcesss.pnlVacuumChart)
        ChartProcessVacuum.ChartAreas(0).CursorX.Interval = 1
        ChartManualVacuum.ChartAreas(0).CursorY.Interval = 0.001

    End Sub

    Public Sub SetChartAreaFormat(ByRef cChart As Chart) ', _
        ''Optional ByVal iX As Integer = 3, Optional ByVal iY As Integer = 15, Optional ByVal iW As Integer = 97, Optional ByVal iH As Integer = 100)
        Dim index As Integer

        For index = 0 To cChart.ChartAreas.Count - 1
            cChart.BackColor = System.Drawing.SystemColors.Control
            cChart.ChartAreas(index).BackColor = System.Drawing.SystemColors.Control


            cChart.ChartAreas(index).AxisX.Minimum = [Double].NaN            'X軸 設定 CHART X軸 的最小刻度為 自動
            cChart.ChartAreas(index).AxisX.Maximum = MAX_X_SCALE               'X軸 設定 CHART X軸 的最大刻度為 MAX_X_SCALE
            cChart.ChartAreas(index).AxisX.MajorGrid.LineColor = Color.LightGray

            cChart.ChartAreas(index).AxisX.ScaleView.Zoomable = True         'X軸 可放大,縮小
            cChart.ChartAreas(index).AxisX.ScrollBar.IsPositionedInside = False   'X軸 使用捲軸, 並設在圖表外側
            cChart.ChartAreas(index).AxisX.ScrollBar.Size = 20                       'X軸 設定捲軸大小,最大為20
            cChart.ChartAreas(index).AxisX.ScrollBar.BackColor = Color.LightGray
            cChart.ChartAreas(index).AxisX.ScrollBar.ButtonColor = Color.LightGray


            cChart.ChartAreas(index).CursorX.IsUserEnabled = True            'X軸 使用 游標控制
            cChart.ChartAreas(index).CursorX.IsUserSelectionEnabled = True   'X軸 可使用 使用者拖曳選擇
            cChart.ChartAreas(index).CursorX.AutoScroll = True                   'X軸 捲軸自動產生

            cChart.ChartAreas(index).AxisY.Minimum = [Double].NaN                'X軸 設定 CHART X軸 的最小刻度為 自動
            cChart.ChartAreas(index).AxisY.Maximum = [Double].NaN                'X軸 設定 CHART X軸 的最大刻度為 MAX_X_SCALE
            cChart.ChartAreas(index).AxisY.MajorGrid.LineColor = Color.LightGray

            cChart.ChartAreas(index).AxisY.ScaleView.Zoomable = True             'X軸 可放大,縮小
            cChart.ChartAreas(index).AxisY.ScrollBar.IsPositionedInside = False   'X軸 使用捲軸, 並設在圖表外側
            cChart.ChartAreas(index).AxisY.ScrollBar.Size = 20                    'X軸 設定捲軸大小,最大為20
            cChart.ChartAreas(index).AxisY.ScrollBar.BackColor = Color.LightGray
            cChart.ChartAreas(index).AxisY.ScrollBar.ButtonColor = Color.LightGray

            cChart.ChartAreas(index).CursorY.IsUserEnabled = True                'X軸 使用 游標控制
            cChart.ChartAreas(index).CursorY.IsUserSelectionEnabled = True       'X軸 可使用 使用者拖曳選擇
            cChart.ChartAreas(index).CursorY.AutoScroll = True                    'X軸 捲軸自動產生


            cChart.ChartAreas(index).AxisY2.Minimum = [Double].NaN                'X軸 設定 CHART X軸 的最小刻度為 自動
            cChart.ChartAreas(index).AxisY2.Maximum = [Double].NaN                'X軸 設定 CHART X軸 的最大刻度為 MAX_X_SCALE
            cChart.ChartAreas(index).AxisY2.MajorGrid.LineColor = Color.LightGray

            cChart.ChartAreas(index).AxisY2.ScaleView.Zoomable = True             'X軸 可放大,縮小
            cChart.ChartAreas(index).AxisY2.ScrollBar.IsPositionedInside = False   'X軸 使用捲軸, 並設在圖表外側
            cChart.ChartAreas(index).AxisY2.ScrollBar.Size = 20                    'X軸 設定捲軸大小,最大為20
            cChart.ChartAreas(index).AxisY2.ScrollBar.BackColor = Color.LightGray
            cChart.ChartAreas(index).AxisY2.ScrollBar.ButtonColor = Color.LightGray
            cChart.ChartAreas(index).AxisY2.Enabled = AxisEnabled.Auto
            cChart.ChartAreas(index).AxisY2.MajorGrid.LineColor = Color.LightPink
            ChartRecord.ChartAreas(index).AxisX.Minimum = 0
            ChartRecord.ChartAreas(index).AxisY.Minimum = 0

        Next
    End Sub

    Public Sub CreateChart(ByRef frm As Object, ByRef cChart As Chart, Optional ByVal Title As String = "Chart") ', _
        ''Optional ByVal iX As Integer = 3, Optional ByVal iY As Integer = 15, Optional ByVal iW As Integer = 97, Optional ByVal iH As Integer = 100)
        Dim i As Integer
        Dim Index As Integer = 0

        If IsNothing(cChart) = False Then
            cChart.Dispose()
        End If

        cChart = New Chart
        cChart.Palette = ChartColorPalette.Bright
        frm.Controls.Add(cChart)
        cChart.Width = frm.Width
        cChart.Height = frm.Height
        cChart.ChartAreas.Add(Title)
        'cChart.ChartAreas(0).Position.X = iX
        'cChart.ChartAreas(0).Position.Y = iY
        'cChart.ChartAreas(0).Position.Width = iW
        'cChart.ChartAreas(0).Position.Height = iH


        cChart.BackColor = System.Drawing.SystemColors.Control
        cChart.ChartAreas(Index).BackColor = System.Drawing.SystemColors.Control


        cChart.ChartAreas(Index).AxisX.Minimum = [Double].NaN            'X軸 設定 CHART X軸 的最小刻度為 自動
        cChart.ChartAreas(Index).AxisX.Maximum = MAX_X_SCALE               'X軸 設定 CHART X軸 的最大刻度為 MAX_X_SCALE
        cChart.ChartAreas(Index).AxisX.MajorGrid.LineColor = Color.LightGray

        cChart.ChartAreas(Index).AxisX.ScaleView.Zoomable = True         'X軸 可放大,縮小
        cChart.ChartAreas(Index).AxisX.ScrollBar.IsPositionedInside = False   'X軸 使用捲軸, 並設在圖表外側
        cChart.ChartAreas(Index).AxisX.ScrollBar.Size = 20                       'X軸 設定捲軸大小,最大為20
        cChart.ChartAreas(Index).AxisX.ScrollBar.BackColor = Color.LightGray
        cChart.ChartAreas(Index).AxisX.ScrollBar.ButtonColor = Color.LightGray


        cChart.ChartAreas(Index).CursorX.IsUserEnabled = True            'X軸 使用 游標控制
        cChart.ChartAreas(Index).CursorX.IsUserSelectionEnabled = True   'X軸 可使用 使用者拖曳選擇
        cChart.ChartAreas(Index).CursorX.AutoScroll = True                   'X軸 捲軸自動產生

        cChart.ChartAreas(Index).AxisY.Minimum = [Double].NaN                'X軸 設定 CHART X軸 的最小刻度為 自動
        cChart.ChartAreas(Index).AxisY.Maximum = [Double].NaN                'X軸 設定 CHART X軸 的最大刻度為 MAX_X_SCALE
        cChart.ChartAreas(Index).AxisY.MajorGrid.LineColor = Color.LightGray

        cChart.ChartAreas(Index).AxisY.ScaleView.Zoomable = True             'X軸 可放大,縮小
        cChart.ChartAreas(Index).AxisY.ScrollBar.IsPositionedInside = False   'X軸 使用捲軸, 並設在圖表外側
        cChart.ChartAreas(Index).AxisY.ScrollBar.Size = 20                    'X軸 設定捲軸大小,最大為20
        cChart.ChartAreas(Index).AxisY.ScrollBar.BackColor = Color.LightGray
        cChart.ChartAreas(Index).AxisY.ScrollBar.ButtonColor = Color.LightGray

        cChart.ChartAreas(Index).CursorY.IsUserEnabled = True                'X軸 使用 游標控制
        cChart.ChartAreas(Index).CursorY.IsUserSelectionEnabled = True       'X軸 可使用 使用者拖曳選擇
        cChart.ChartAreas(Index).CursorY.AutoScroll = True                    'X軸 捲軸自動產生


        cChart.ChartAreas(Index).AxisY2.Minimum = [Double].NaN                'X軸 設定 CHART X軸 的最小刻度為 自動
        cChart.ChartAreas(Index).AxisY2.Maximum = [Double].NaN                'X軸 設定 CHART X軸 的最大刻度為 MAX_X_SCALE
        cChart.ChartAreas(Index).AxisY2.MajorGrid.LineColor = Color.LightGray

        cChart.ChartAreas(Index).AxisY2.ScaleView.Zoomable = True             'X軸 可放大,縮小
        cChart.ChartAreas(Index).AxisY2.ScrollBar.IsPositionedInside = False   'X軸 使用捲軸, 並設在圖表外側
        cChart.ChartAreas(Index).AxisY2.ScrollBar.Size = 20                    'X軸 設定捲軸大小,最大為20
        cChart.ChartAreas(Index).AxisY2.ScrollBar.BackColor = Color.LightGray
        cChart.ChartAreas(Index).AxisY2.ScrollBar.ButtonColor = Color.LightGray
        cChart.ChartAreas(Index).AxisY2.Enabled = AxisEnabled.Auto
        cChart.ChartAreas(Index).AxisY2.MajorGrid.LineColor = Color.LightPink



    End Sub

    Public Sub CreateSeries(ByRef cChart As Chart, ByVal sCurve(,) As String, ByVal iStart As Integer, ByVal iNum As Integer)
        Dim i As Integer
        cChart.Palette = ChartColorPalette.Excel
        For i = iStart To iStart + iNum
            cChart.Series.Add(sCurve(SystemLanguage, i))
            cChart.Series(i - iStart).ChartType = SeriesChartType.FastLine
            'cChart.Series(i).Color = Color.FromArgb(cChart.Series(i).Color.R, cChart.Series(i).Color.G, cChart.Series(i).Color.B)
            If i < SeriesColor.Length - 1 Then cChart.Series(i).Color = SeriesColor(i)
        Next
    End Sub
    Public Sub CreateSeries2(ByRef cChart As Chart, ByVal sCurve(,) As String, ByVal CurveIndex As Integer, ByVal iStart As Integer, ByVal iNum As Integer)
        Dim i, j As Integer
        Dim DColor As Color
        cChart.Palette = ChartColorPalette.Excel
        For i = iStart To iStart + iNum
            j = CurveIndex + i - iStart
            cChart.Series.Add(sCurve(SystemLanguage, j) + "2")
            cChart.Series(j + iStart).ChartType = SeriesChartType.FastLine

            If i < SeriesColor.Length - 1 Then
                DColor = SeriesColor(i)
                'DColor = Color.FromArgb(cChart.Series(i).Color.R, cChart.Series(i).Color.G, cChart.Series(i).Color.B)
                DColor = Color.FromArgb(DColor.R * 0.5, DColor.G * 0.5, DColor.B * 0.5)
                cChart.Series(i).Color = DColor 'Color.FromArgb(cChart.Series(i).Color.R, cChart.Series(i).Color.G, cChart.Series(i).Color.B)

                cChart.Series(j + iStart).Color = DColor
            End If
            j += 1
        Next
    End Sub
    Public Sub DisableY2Axis(ByRef cChart As Chart, ByVal iSeries As Integer)
        cChart.ChartAreas(0).AxisY2.Enabled = AxisEnabled.False
    End Sub
    Public Sub SetSeriesPrimary(ByRef cChart As Chart, ByVal iSeries As Integer)
        cChart.Series(iSeries).YAxisType = AxisType.Primary
    End Sub
    Public Sub SetSeriesSecondary(ByRef cChart As Chart, ByVal iSeries As Integer)
        cChart.Series(iSeries).YAxisType = AxisType.Secondary
    End Sub
    Public Sub SetSeriesAxis(ByRef cChart As Chart, ByVal iAxis As Integer, ByVal iSeries As Integer)
        cChart.Series(iSeries).YAxisType = iAxis
    End Sub

    Public Sub ResetCurve(ByRef cChart As Chart, Optional ByVal iChartAreas As Integer = 0)
        If IsNothing(cChart) Then Exit Sub
        cChart.ChartAreas(iChartAreas).AxisX.ScaleView.ZoomReset()
        cChart.ChartAreas(iChartAreas).AxisY.ScaleView.ZoomReset()
        'cChart.ChartAreas(iChartAreas).AxisX.Minimum = [Double].NaN
        'cChart.ChartAreas(iChartAreas).AxisX.Maximum = [Double].NaN
        cChart.ChartAreas(iChartAreas).AxisY.Minimum = [Double].NaN
        cChart.ChartAreas(iChartAreas).AxisY.Maximum = [Double].NaN
        cChart.ChartAreas(iChartAreas).RecalculateAxesScale()
    End Sub
    Public Sub printCurve(ByVal cChart As Chart, Optional ByVal sTitle As String = "Cello Records Curve")
        If IsNothing(cChart) Then Exit Sub
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


    '預設曲線顏色
    Public SeriesColor() As Color = {
                                    Color.FromArgb(255, 0, 0), Color.FromArgb(0, 255, 0), Color.FromArgb(0, 0, 255),
                                    Color.FromArgb(255, 255, 0), Color.FromArgb(0, 255, 255), Color.FromArgb(255, 0, 255),
                                    Color.FromArgb(255, 224, 0), Color.FromArgb(0, 255, 224), Color.FromArgb(192, 192, 192),
                                    Color.FromArgb(224, 0, 0), Color.FromArgb(0, 224, 0), Color.FromArgb(0, 0, 224),
                                    Color.FromArgb(224, 224, 0), Color.FromArgb(0, 224, 224), Color.FromArgb(224, 0, 224),
                                    Color.FromArgb(224, 192, 0), Color.FromArgb(0, 224, 192), Color.FromArgb(192, 0, 224),
                                    Color.FromArgb(224, 127, 0), Color.FromArgb(0, 224, 127), Color.FromArgb(127, 0, 224),
                                    Color.FromArgb(224, 64, 0), Color.FromArgb(0, 224, 64), Color.FromArgb(64, 0, 224),
                                    Color.FromArgb(192, 192, 0), Color.FromArgb(0, 192, 192), Color.FromArgb(192, 0, 192),
                                    Color.FromArgb(127, 0, 0), Color.FromArgb(0, 127, 0), Color.FromArgb(0, 0, 127),
                                    Color.FromArgb(192, 0, 0), Color.FromArgb(0, 192, 0), Color.FromArgb(0, 0, 192),
                                    Color.FromArgb(192, 127, 0), Color.FromArgb(0, 192, 127), Color.FromArgb(192, 0, 127)
                                    }
    Public diagColor As ColorDialog
    <StructLayout(LayoutKind.Sequential)> Public Structure chkSeries
        Dim chkEnable As CheckBox
        Dim lblAxis As Label
        Dim pnlColor As Panel
        Dim cColor As Color
    End Structure
    Public Record_Series(100) As chkSeries '記錄用
    Public Process_Series(10) As chkSeries '製程用
    Public Manual_Series(10) As chkSeries '製程用

    '建立記錄畫面曲線選擇區
    Public Sub InitSeriesSelect(ByRef pnl As Panel, ByRef chk() As chkSeries, ByVal cChart As Chart, Optional ByVal iNext As Integer = 0)
        Dim i As Integer
        Dim iNum As Integer
        Dim ColorBoxSize As Integer
        If IsNothing(cChart) Then Exit Sub
        ColorBoxSize = pnl.Width * 0.1
        If ColorBoxSize < 10 Then ColorBoxSize = 10
        iNum = MAX_CURVES
        ReDim chk(MAX_CURVES)
        For i = 0 To MAX_CURVES

            chk(i).pnlColor = New Panel
            chk(i).pnlColor.Name = "PNL_" + Format(i, "00")
            chk(i).pnlColor.Location = New Point(5, i * ColorBoxSize)
            chk(i).pnlColor.BorderStyle = BorderStyle.FixedSingle
            chk(i).pnlColor.Width = ColorBoxSize - 2
            chk(i).pnlColor.Height = ColorBoxSize - 2
            chk(i).pnlColor.TabIndex = i
            chk(i).pnlColor.Visible = True
            pnl.Controls.Add(chk(i).pnlColor)

            chk(i).lblAxis = New Label
            chk(i).lblAxis.Name = "lblAxis" + Format(i, "00")
            chk(i).lblAxis.Location = New Point(ColorBoxSize + 6, i * ColorBoxSize)
            chk(i).lblAxis.BorderStyle = BorderStyle.FixedSingle
            chk(i).lblAxis.Width = ColorBoxSize - 2
            chk(i).lblAxis.Height = ColorBoxSize - 2
            chk(i).lblAxis.TabIndex = i
            chk(i).lblAxis.BackColor = System.Drawing.SystemColors.Control
            chk(i).lblAxis.Text = "1"
            chk(i).lblAxis.Visible = True
            pnl.Controls.Add(chk(i).lblAxis)

            chk(i).chkEnable = New CheckBox
            chk(i).chkEnable.Name = "CHK_" + Format(i, "00")
            chk(i).chkEnable.Text = cChart.Series(i).Name
            chk(i).chkEnable.Location = New Point(ColorBoxSize * 2 + 6, i * ColorBoxSize)
            chk(i).chkEnable.AutoSize = True
            chk(i).chkEnable.TabIndex = i
            chk(i).chkEnable.Visible = True
            chk(i).chkEnable.Checked = True
            chk(i).chkEnable.Font = New Font("Ariel", ColorBoxSize / 2)
            chk(i).chkEnable.ForeColor = Color.Black
            pnl.Controls.Add(chk(i).chkEnable)

            AddHandler chk(i).chkEnable.Click, AddressOf Record_ChkClick1
            AddHandler chk(i).pnlColor.Click, AddressOf Record_PnlClick1
            AddHandler chk(i).lblAxis.Click, AddressOf Record_lblClick1


            chk(i).cColor = New Color
            chk(i).cColor = cChart.Series(i).Color
            chk(i).pnlColor.BackColor = chk(i).cColor

            diagColor = New ColorDialog
        Next
        RedefineColor(Record_Series, ChartRecord)

    End Sub
    Public Sub Record_ChkClick1(ByVal sender As Object, ByVal e As EventArgs)
        Dim i As Integer
        i = sender.Tabindex
        ChartRecord.Series(i).Enabled = sender.Checked
        ChartRecord.ChartAreas(0).RecalculateAxesScale()
    End Sub
    Public Sub Record_PnlClick1(ByVal sender As Object, ByVal e As EventArgs)
        Dim i As Integer
        i = sender.Tabindex
        If diagColor.ShowDialog() = Windows.Forms.DialogResult.OK Then
            sender.BackColor = diagColor.Color
            ChartRecord.Series(i).Color = diagColor.Color
        End If
        ChartRecord.ChartAreas(0).RecalculateAxesScale()
    End Sub

    Public Sub Record_lblClick1(ByVal sender As Object, ByVal e As EventArgs)
        If sender.Text = "1" Then
            SetSeriesSecondary(ChartRecord, sender.Tabindex)
            sender.Text = "2"
        Else
            SetSeriesPrimary(ChartRecord, sender.Tabindex)
            sender.Text = "1"
        End If
        ChartRecord.ChartAreas(0).RecalculateAxesScale()
    End Sub

    Public Sub Record_ChkClick2(ByVal sender As Object, ByVal e As EventArgs)
        Dim i As Integer
        i = sender.Tabindex
        ChartRecord.Series(i + MAX_CURVES + 1).Enabled = sender.Checked
        ChartRecord.ChartAreas(0).RecalculateAxesScale()

    End Sub
    Public Sub Record_PnlClick2(ByVal sender As Object, ByVal e As EventArgs)
        Dim i As Integer
        i = sender.Tabindex
        If diagColor.ShowDialog() = Windows.Forms.DialogResult.OK Then
            sender.BackColor = diagColor.Color
            ChartRecord.Series(i + MAX_CURVES + 1).Color = diagColor.Color
        End If
        ChartRecord.ChartAreas(0).RecalculateAxesScale()

    End Sub
    Public Sub Record_lblClick2(ByVal sender As Object, ByVal e As EventArgs)
        If sender.Text = "1" Then
            SetSeriesSecondary(ChartRecord, sender.Tabindex + MAX_CURVES + 1)
            sender.Text = "2"
        Else
            SetSeriesPrimary(ChartRecord, sender.Tabindex + MAX_CURVES + 1)

            sender.Text = "1"
        End If
        ChartRecord.ChartAreas(0).RecalculateAxesScale()

    End Sub

    Public Sub RedefineColor(ByRef chk() As chkSeries, ByRef cChart As Chart)
        Dim i As Integer
        For i = 0 To MAX_CURVES
            chk(i).cColor = cChart.Series(i).Color
            chk(i).pnlColor.BackColor = chk(i).cColor
            cChart.Series(i).Enabled = chk(i).chkEnable.Checked
        Next
    End Sub
    Public Sub RedefineColor2(ByRef chk() As chkSeries, ByRef cChart As Chart)
        Dim i, j As Integer
        Dim DColor As Color
        For i = 0 To MAX_CURVES
            j = MAX_CURVES + i + 1
            DColor = cChart.Series(j).Color
            DColor = SeriesColor(j) ' Color.FromArgb(DColor.R * 0.8, DColor.G * 0.8, DColor.B * 0.8)
            cChart.Series(j).Color = DColor
            chk(i).cColor = DColor
            chk(i).pnlColor.BackColor = chk(i).cColor
            cChart.Series(j).Enabled = chk(i).chkEnable.Checked
        Next
    End Sub

    Public Sub CurveDataBindY(ByRef cChart As Chart, ByVal Index As Integer, ByVal DataArray() As Double)
        On Error Resume Next
        If cChart.Series.Count > Index Then
            cChart.Series(Index).Points.DataBindY(DataArray)
        End If
    End Sub

    Public Sub CurveDataBindY(ByRef cChart As Chart, ByVal Index As Integer, ByVal DataArray() As Integer)
        On Error Resume Next
        If cChart.Series.Count > Index Then
            cChart.Series(Index).Points.DataBindY(DataArray)
        End If
    End Sub
    ' Edit Controls
    Public Sub SaveChartToJPG(ByVal cChart As Chart)
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

    Private Sub ChartProcess_CursorPositionChanging(ByVal sender As Object, ByVal e As System.Windows.Forms.DataVisualization.Charting.CursorEventArgs)
        Static CursorX As String
        Static CursorY As String
        If Double.IsNaN(e.NewPosition) Then
            Return
        End If
        If e.Axis.AxisName = AxisName.X Then
            If e.NewPosition < ChartProcessVacuum.Series(0).Points.Count Then
                CursorY = Format(ChartProcessVacuum.Series(0).Points(e.NewPosition).YValues(0), "0.0+E00")
            Else
                CursorY = "xxx"
            End If
            CursorX = Format("0000", e.NewPosition)
            FormProcesss.lblCursorValue.Text = "[" + CursorX + "s, Vac: " + CursorY + " Torr]"
        Else
            CursorY = Format(Math.Pow(10, e.NewPosition), "0.0E+00")
        End If
    End Sub

    Private Sub ChartManual_CursorPositionChanging(ByVal sender As Object, ByVal e As System.Windows.Forms.DataVisualization.Charting.CursorEventArgs)
        Static CursorX As String
        Static CursorY As String
        If Double.IsNaN(e.NewPosition) Then
            Return
        End If
        If e.Axis.AxisName = AxisName.X Then
            If e.NewPosition < ChartManualVacuum.Series(0).Points.Count Then
                CursorY = Format(ChartManualVacuum.Series(0).Points(e.NewPosition).YValues(0), "0.0+E00")
            Else
                CursorY = "xxx"
            End If
            CursorX = Format("0000", e.NewPosition)
            FormManuals.lblCursorValue.Text = "[" + CursorX + "s, Vac: " + CursorY + " Torr]"
        Else
            CursorY = Format(Math.Pow(10, e.NewPosition), "0.0E+00")
        End If

    End Sub

    Private Sub ChartRecord_CursorPositionChanging(ByVal sender As Object, ByVal e As System.Windows.Forms.DataVisualization.Charting.CursorEventArgs)
        Dim i, j, k As Integer
        Static CursorX As String
        Static CursorY As String
        On Error Resume Next
        If Double.IsNaN(e.NewPosition) Then
            Return
        End If
        If e.Axis.AxisName = AxisName.X Then
            CursorX = e.NewPosition.ToString
            FormRecords.lblTimeX.Text = CursorX
            If FormRecords.MultiAreaFlag Then
                Select Case e.ChartArea.Name
                    Case "Site1"
                        j = 0
                        k = 2
                        If e.NewPosition < ChartRecord.Series(0).Points.Count Then
                            FormRecords.lblCHVac.Text = Format(ChartRecord.Series(0).Points(e.NewPosition).YValues(0), "0.0+E00")
                            FormRecords.lblDPCurrent.Text = Format(ChartRecord.Series(1).Points(e.NewPosition).YValues(0), "0.00")
                        Else
                            FormRecords.lblCHVac.Text = "xxx"
                            FormRecords.lblDPCurrent.Text = "xxx"
                        End If
                    Case "Site2"
                        j = 1
                        k = 7
                    Case "Site3"
                        If MAXPLATE > 2 Then
                            j = 2
                            k = 12
                        End If
                    Case "Site4"
                        If MAXPLATE > 2 Then
                            j = 3
                            k = 17
                        End If
                    Case "Site5"
                        If MAXPLATE > 2 Then
                            j = 4
                            k = 22
                        End If
                    Case "Site6"
                        If MAXPLATE > 2 Then
                            j = 5
                            k = 27
                        End If
                End Select
                If e.NewPosition < ChartRecord.Series(k).Points.Count Then
                    RecordDataShow(j).SetTopTemp = ChartRecord.Series(k).Points(e.NewPosition).YValues(0).ToString
                    RecordDataShow(j).SetBotTemp = ChartRecord.Series(k + 1).Points(e.NewPosition).YValues(0).ToString
                    RecordDataShow(j).SetPressure = ChartRecord.Series(k + 2).Points(e.NewPosition).YValues(0).ToString
                    RecordDataShow(j).SetTempPreset = ChartRecord.Series(k + 3).Points(e.NewPosition).YValues(0).ToString
                    RecordDataShow(j).SetPressurePreset = ChartRecord.Series(k + 4).Points(e.NewPosition).YValues(0).ToString
                Else
                    RecordDataShow(j).SetTopTemp = "xxx"
                    RecordDataShow(j).SetBotTemp = "xxx"
                    RecordDataShow(j).SetPressure = "xxx"
                    RecordDataShow(j).SetTempPreset = "xxx"
                    RecordDataShow(j).SetPressurePreset = "xxx"
                End If
            Else

                k = 0
                If e.NewPosition < ChartRecord.Series(0).Points.Count Then
                    FormRecords.lblCHVac.Text = Format(ChartRecord.Series(0).Points(e.NewPosition).YValues(0), "0.0+E00")
                    FormRecords.lblDPCurrent.Text = Format(ChartRecord.Series(1).Points(e.NewPosition).YValues(0), "0.00")
                    For j = 0 To MAXPLATE
                        If bolDA Then
                            '加上DA值
                            If ChartRecord.Series(j * 6 + 2).Points.Count >= j Then
                                RecordDataShow(j).SetTopTemp = ChartRecord.Series(j * 6 + 2).Points(e.NewPosition).YValues(0).ToString
                                RecordDataShow(j).SetBotTemp = ChartRecord.Series(j * 6 + 3).Points(e.NewPosition).YValues(0).ToString
                                RecordDataShow(j).SetPressure = ChartRecord.Series(j * 6 + 4).Points(e.NewPosition).YValues(0).ToString
                                RecordDataShow(j).SetPresetDA = ChartRecord.Series(j * 6 + 5).Points(e.NewPosition).YValues(0).ToString 'da值
                                RecordDataShow(j).SetTempPreset = ChartRecord.Series(j * 6 + 6).Points(e.NewPosition).YValues(0).ToString '溫度預設
                            End If
                        Else
                            If ChartRecord.Series(j * 5 + 2).Points.Count >= j Then
                                RecordDataShow(j).SetTopTemp = ChartRecord.Series(j * 5 + 2).Points(e.NewPosition).YValues(0).ToString
                                RecordDataShow(j).SetBotTemp = ChartRecord.Series(j * 5 + 3).Points(e.NewPosition).YValues(0).ToString
                                RecordDataShow(j).SetPressure = ChartRecord.Series(j * 5 + 4).Points(e.NewPosition).YValues(0).ToString
                                RecordDataShow(j).SetTempPreset = ChartRecord.Series(j * 5 + 5).Points(e.NewPosition).YValues(0).ToString
                                RecordDataShow(j).SetPressurePreset = ChartRecord.Series(k + 6).Points(e.NewPosition).YValues(0).ToString
                            End If
                        End If


                    Next
                Else
                    FormRecords.lblCHVac.Text = "xxx"
                    FormRecords.lblDPCurrent.Text = "xxx"
                    For j = 0 To MAXPLATE
                        RecordDataShow(j).SetTopTemp = "xxx"
                        RecordDataShow(j).SetBotTemp = "xxx"
                        RecordDataShow(j).SetPressure = "xxx"
                        RecordDataShow(j).SetTempPreset = "xxx"
                        RecordDataShow(j).SetPressurePreset = "xxx"
                    Next

                End If
            End If
        Else
            CursorY = e.NewPosition.ToString
        End If




    End Sub
    '改版之製程曲線
    Public ProcessCurveLog As New WriteCurveData
    Public ProcessCurveCSVLog As New WriteCurveData
    Public DataLogCurveLog As New WriteCurveData

    Class WriteCurveData
        Private Control_State As Integer
        Dim data(100) As String
        Dim ShowData As String
        Dim i, datamax As Integer
        Sub New()

        End Sub
        Public Sub WriteProcessCurveData(ByVal Cond As Boolean, ByRef index As Integer, ByVal iTotalCurveNum As Integer, ByVal sfile As String, Optional ByVal CSVFlag As Boolean = False)
            If sfile = "" Then
                Exit Sub
            End If
            Select Case Control_State
                Case 0
                    If Cond Then
                        ShowData = ""
                        If bolVaccTest Then
                            For i = 0 To 1
                                ShowData = ShowData + CurveName(SystemLanguage, i) + ","
                            Next
                        Else
                            For i = 0 To iTotalCurveNum
                                ShowData = ShowData + CurveName(SystemLanguage, i) + ","
                            Next
                        End If
                        'ShowData = ShowData + CurveName(2, i)
                        WriteProgData("CURVE_SETUP", "CAPTION", ShowData, sfile)
                        WriteProgData("CURVE_SETUP", "DEVICENAME", Program_DeviceName, sfile)
                        WriteProgData("CURVE_SETUP", "MODELNAME", Program_ModelName, sfile)
                        WriteProgData("CURVE_SETUP", "DATETIME", ADate + " " + TTime, sfile)
                        WriteProgData("CURVE_SETUP", "RECIPE", ProcessRecipeName, sfile)
                        WriteProgData("CURVE_SETUP", "PROCESSPN", ProcessPN, sfile)
                        Control_State = 1
                        'index = 0
                    Else
                        index = 0
                    End If

                Case 1
                    If Cond Then
                        If CSVFlag Then
                            ShowData = ","
                        Else
                            ShowData = ""
                        End If

                        datamax = 0
                        data(datamax) = GaugeCHVacStr
                        datamax += 1
                        data(datamax) = MPCurrentStr
                        If bolVaccTest = False Then
                            For i = 0 To MAXPLATE
                                datamax += 1
                                data(datamax) = TopTempPVStr(i)
                                datamax += 1
                                data(datamax) = BotTempPVStr(i)
                                datamax += 1
                                data(datamax) = PressPVstr(i)
                                datamax += 1
                                '寫入DA值
                                If SystemParameters.bolDAlog Then
                                    data(datamax) = Get_PLC_R1000(ADScalerB01Index + i).ToString
                                    datamax += 1
                                End If
                                data(datamax) = PresetTempStr(i)
                                datamax += 1
                                data(datamax) = PresetPressStr(i)
                            Next
                        End If
                        For i = 0 To datamax - 1
                            ShowData = ShowData + data(i) + ","
                        Next
                        ShowData = ShowData + data(i)
                        '寫入資料記錄
                        WriteProgData("CURVE_DATA", "DATA" + Format(index, "000000"), ShowData, sfile)
                        WriteProgData("CURVE_SETUP", "TOTAL_RECORD", index, sfile)
                        index += 1
                    Else
                        Control_State = 99
                    End If

                Case 99
                    Control_State = 0

            End Select

        End Sub
    End Class

    '曲線資料結構
    Public Structure CelloCurveStructure
        Dim CAPTION_ALL As String
        Dim CAPTION_NUM As Integer
        Dim CAPTION() As String
        Dim DEVICENAME As String
        Dim MODELNAME As String
        Dim DATETIME As String
        Dim RECIPE As String
        Dim PROCESSPN As String
        Dim TOTAL_RECORD As Integer
        Dim Record()() As Double
    End Structure
    '曲線資料結構變數
    Public CelloCurve As New CelloCurveStructure

    '建立曲線實體
    Public Sub CreateSeriesRecord(ByRef cChart As Chart, ByVal sCurve(,) As String, ByVal iStart As Integer, ByVal iNum As Integer)
        Dim i As Integer

        cChart.Palette = ChartColorPalette.Excel
        For i = iStart To iStart + iNum - 1
            cChart.Series.Add(sCurve(SystemLanguage, i))
            cChart.Series(i - iStart).ChartType = SeriesChartType.FastLine
            'cChart.Series(i).Color = Color.FromArgb(cChart.Series(i).Color.R, cChart.Series(i).Color.G, cChart.Series(i).Color.B)
            If i < SeriesColor.Length - 1 Then cChart.Series(i).Color = SeriesColor(i)
        Next

    End Sub
    '建立曲線實體
    Public Sub ChangeSeriesRecordName(ByRef cChart As Chart, ByVal sCurve(,) As String)
        Dim i As Integer
        'ReadCurveNames(CurveDataINI)
        cChart.Palette = ChartColorPalette.Excel
        For i = 0 To MAX_CURVES
            cChart.Series(i).Name = sCurve(SystemLanguage, i)
            Record_Series(i).chkEnable.Text = sCurve(SystemLanguage, i)
        Next
    End Sub

    '建立記錄用曲線圖
    Public Sub CreateChartRecords(ByRef obj As Object, Optional ByVal iSeries As Integer = 0)
        Dim i, j, k As Integer
        '建立記錄曲線圖
        CreateChart(obj, ChartRecord, "Site1")
        '建立記錄曲線 2條
        ChartRecord.ChartAreas.Add("Site2")
        ChartRecord.ChartAreas.Add("Site3")
        If MAXPLATE > 2 Then
            ChartRecord.ChartAreas.Add("Site4")
            ChartRecord.ChartAreas.Add("Site5")
            ChartRecord.ChartAreas.Add("Site6")
        End If
        For i = 0 To MAXPLATE
            ChartRecord.ChartAreas(i).AxisY.Title = ChartRecord.ChartAreas(i).Name
        Next
        'ChartRecord.ChartAreas.Add("Vacuum")

        'First set the ChartArea.InnerPlotPosition property.
        ChartRecord.ChartAreas("Site1").InnerPlotPosition.Auto = True
        ChartRecord.ChartAreas("Site2").InnerPlotPosition.Auto = True
        ChartRecord.ChartAreas("Site3").InnerPlotPosition.Auto = True
        ChartRecord.ChartAreas("Site2").Visible = False
        ChartRecord.ChartAreas("Site3").Visible = False
        If MAXPLATE > 2 Then
            ChartRecord.ChartAreas("Site4").InnerPlotPosition.Auto = True
            ChartRecord.ChartAreas("Site5").InnerPlotPosition.Auto = True
            ChartRecord.ChartAreas("Site6").InnerPlotPosition.Auto = True


            ChartRecord.ChartAreas("Site4").Visible = False
            ChartRecord.ChartAreas("Site5").Visible = False
            ChartRecord.ChartAreas("Site6").Visible = False
        End If
        'For i = 2 To 6
        '    'Set the alignment properties so the "Volume" chart area will allign to "Default"
        '    ChartRecord.ChartAreas("Site" + i.ToString).AlignmentOrientation = AreaAlignmentOrientations.Vertical
        '    ChartRecord.ChartAreas("Site" + i.ToString).AlignmentStyle = AreaAlignmentStyles.All
        '    ChartRecord.ChartAreas("Site" + i.ToString).AlignWithChartArea = "Site1"
        'Next


        'ChartRecord.ChartAreas("Vacuum").Visible = False
        SetChartAreaFormat(ChartRecord)
        'CreateSeries2(ChartRecord, CurveName, 0, MAX_CURVES + 1, MAX_CURVES)
        'CreateSeriesRecord(ChartRecord, CurveName, 0, MAX_CURVES)
        'ChartRecord.Series(0).ChartArea = ChartRecord.ChartAreas(0).Name
        'ChartRecord.Series(1).ChartArea = ChartRecord.ChartAreas(0).Name
        'k = 1
        'j = 0
        'For i = 2 To MAX_CURVES
        '    ChartRecord.Series(i).ChartArea = ChartRecord.ChartAreas(k).Name
        '    If j >= 4 Then
        '        j = 0
        '        k += 1
        '    Else
        '        j += 1
        '    End If

        'Next


        ChartRecord.BackColor = Color.Lavender
        ChartRecord.BackGradientStyle = DataVisualization.Charting.GradientStyle.DiagonalRight
        For i = 0 To ChartRecord.ChartAreas.Count - 1
            '設定曲線圖格式
            ChartRecord.ChartAreas(i).BackColor = Color.AliceBlue
            ChartRecord.ChartAreas(i).BackGradientStyle = DataVisualization.Charting.GradientStyle.DiagonalRight
        Next

        AddHandler ChartRecord.CursorPositionChanging, AddressOf ChartRecord_CursorPositionChanging

    End Sub

End Module

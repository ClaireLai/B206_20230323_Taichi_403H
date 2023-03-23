Imports System.Collections.Generic

Module Module_DigitalFiiter
    Public AvergaeValue(MAXPLATE) As CAverage 'Vincent + 20171117
    Public PressState(6) As Integer
    Public OldPressValue(6) As Integer
    Public PressStateDelay(6) As Integer

    Public Class CAverage 'Vincent + 20171117
        ''' <summary>
        ''' 平均次數
        ''' </summary>
        ''' <remarks></remarks>
        Private AverageTimes As Integer = 0
        ''' <summary>
        ''' 平均值
        ''' </summary>
        ''' <remarks></remarks>
        Private Average As Double = 0.0
        ''' <summary>
        ''' 變化斜率,大於此值則不記錄
        ''' </summary>
        ''' <remarks></remarks>
        Private AverageCount As Integer = 0
        Private CurrentData As Double = 0.0
        Private LastData As Double = 0.0
        Private DataList As System.Collections.Generic.List(Of Double)

        Public Sub SetAverageTimes(ByVal iAverageTimes As Integer)
            AverageTimes = iAverageTimes
            If AverageTimes <= 0 Then
                iAverageTimes = 5
            End If
        End Sub
        ''' <summary>
        ''' 取後數位濾波後數值
        ''' </summary>
        ''' <param name="iAverageTimes">平均次數</param>
        ''' <remarks></remarks>
        Sub New(ByVal iAverageTimes As Integer)
            If iAverageTimes < 1 Then
                iAverageTimes = 1
            End If
            AverageTimes = iAverageTimes
            AverageCount = 0
            Average = 0
            DataList = New List(Of Double)
        End Sub
        ''' <summary>
        ''' 使用預設值進行濾波
        ''' </summary>
        ''' <remarks></remarks>
        Sub New()
            AverageTimes = 5
            AverageCount = 0
            Average = 0
            DataList = New List(Of Double)
        End Sub
        Public Function GetAverageValue(ByVal dData As Double) As Double
            CurrentData = dData
            If AverageCount = 0 Then
                LastData = dData
            End If
            DataList.Add(CurrentData)
            If AverageCount >= AverageTimes Then
                DataList.RemoveAt(0)
            Else
                AverageCount += 1
            End If
            Dim i As Integer = 0
            Average = 0
            For i = 0 To DataList.Count - 1
                Average = Average + DataList.Item(i)
            Next
            Average = Math.Round(Average / DataList.Count)
            LastData = CurrentData
            Return Average
        End Function
        Public Function GetAverageValueDePeak(ByVal dData As Double, ByVal PeakLimit As Double, ByVal iPeakTimes As Integer) As Double
            Static PeakCount As Integer = 0
            CurrentData = dData
            If AverageCount = 0 Then
                LastData = dData
            End If
            If Math.Abs(CurrentData - LastData) > PeakLimit Then
                PeakCount += 1
                If PeakCount < iPeakTimes Then
                    CurrentData = LastData
                Else
                    PeakCount = 0
                End If
            Else
                PeakCount = 0
            End If
            DataList.Add(CurrentData)
            If AverageCount >= AverageTimes Then
                DataList.RemoveAt(0)
            Else
                AverageCount += 1
            End If
            Dim i As Integer = 0
            Average = 0
            If DataList.Count > 0 Then
                For i = 0 To DataList.Count - 1
                    Average = Average + DataList.Item(i)
                Next
                Average = Math.Round(Average / DataList.Count)
            Else
                Average = CurrentData
            End If
            LastData = CurrentData
            Return Average
        End Function
        Public Function GetAverageValue(ByVal dData As Double, ByVal iAverageTimes As Integer) As Double
            AverageTimes = iAverageTimes
            CurrentData = dData
            If AverageCount = 0 Then
                LastData = dData
            End If
            DataList.Add(CurrentData)
            If AverageCount >= AverageTimes Then
                DataList.RemoveAt(0)
            Else
                AverageCount += 1
            End If
            Dim i As Integer = 0
            Average = 0
            For i = 0 To DataList.Count - 1
                Average = Average + DataList.Item(i)
            Next
            Average = Math.Round(Average / DataList.Count)
            LastData = CurrentData
            Return Average
        End Function
        Public Sub CLearAverageTimes()
            If AverageCount > 0 Then
                AverageCount = 0
                DataList.Clear()
            End If
        End Sub
    End Class 'Vincent + 20171117


End Module

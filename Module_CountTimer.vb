Module Module_CountTimer
    Public Class CCountTimer
        Public StartTime As DateTime
        Public Duringtime As TimeSpan
        Public counterset As Integer

        Public state As Integer = 0
        Sub New()
            StartTime = New DateTime
            Duringtime = New TimeSpan
        End Sub

        Enum TimerFunction
            MINUS = 0
            PLUS = 1
        End Enum


        Public Sub Run(ByRef enabled As Boolean, ByRef counter As Integer, Optional ByVal PlusMinus As TimerFunction = 0)
            Dim TotalTime As Integer
            Select Case state
                Case 0
                    If enabled Then
                        StartTime = Now()
                        counterset = counter
                        If PlusMinus = TimerFunction.MINUS Then
                            state = 1
                        Else
                            state = 2
                        End If
                    Else
                        counter = 0
                    End If
                Case 1
                    If enabled Then
                        Duringtime = Now - StartTime
                        counter = counterset - Duringtime.TotalSeconds
                        If Duringtime.TotalSeconds >= counterset Then
                            enabled = False
                            counter = 0
                            state = 0
                        End If
                    Else
                        enabled = False
                        counter = 0
                        state = 0
                    End If
                Case 2
                    If enabled Then
                        Duringtime = Now - StartTime
                        counter = Math.Abs(Duringtime.TotalSeconds) 'By Chesly 20180702 modify
                    Else
                        enabled = False
                        counter = 0
                        state = 0
                    End If

            End Select

        End Sub



    End Class

    Public CTimer1 As New CCountTimer
    Public CTimer2 As New CCountTimer
    Public CTimer3 As New CCountTimer
    Public CTimer4 As New CCountTimer
    Public CTimer5 As New CCountTimer
    Public CTimer6 As New CCountTimer
End Module

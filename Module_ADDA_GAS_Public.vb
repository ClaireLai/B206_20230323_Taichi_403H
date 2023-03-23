Module Module_ADDA_GAS_Public

    ' 簡易校正程序
    Public Function EasyCalbration(ByVal Value As Double, ByVal zero As Double, ByVal offset As Double) As String
        If (Value + offset) < zero Then
            Return "0.0"
        Else
            Return Format(Value + offset, "0.0")
        End If
    End Function

    'PLC AD/DA 資料定義
    ' 公式 =  轉換後值 = (AD現在值 / (FULLSCALE-ZERO)) * (MAX-MIN)  - OFFSET
    '若要得到原始值: 
    Public Sub PLCADDADefine(ByVal sfile As String)
        Dim i, AD_CH, DA_CH As Integer
        Dim section As String
        If IO.File.Exists(sfile) Then

            AD_CH = Val(ReadProgData("ADDA_SETUP", "TOTAL_AD_CH", "0", sfile))
            DA_CH = Val(ReadProgData("ADDA_SETUP", "TOTAL_DA_CH", "0", sfile))
            For i = 0 To AD_CH
                section = "AD_CH" & Format(i, "00")
                PLCRReadValue(i).Name = ReadProgData(section, "NAME", section, sfile)
                PLCRReadValue(i).FullScale = Val(ReadProgData(section, "FULLSCALE", "1", sfile))
                PLCRReadValue(i).Zero = Val(ReadProgData(section, "ZERO", "0", sfile))
                PLCRReadValue(i).Offset = Val(ReadProgData(section, "OFFSET", "0", sfile))
                PLCRReadValue(i).Min = Val(ReadProgData(section, "MIN", "0", sfile))
                PLCRReadValue(i).Max = Val(ReadProgData(section, "MAX", "1", sfile))
                PLCRReadValue(i).Unit = ReadProgData(section, "UNIT", "", sfile)
                PLCRReadValue(i).Factor = Val(ReadProgData(section, "FACTOR", "1", sfile))

            Next
            For i = 0 To DA_CH
                section = "DA_CH" & Format(i, "00")
                PLCRValue(i).Name = ReadProgData(section, "NAME", section, sfile)
                PLCRValue(i).FullScale = Val(ReadProgData(section, "FULLSCALE", "1", sfile))
                PLCRValue(i).Zero = Val(ReadProgData(section, "ZERO", "0", sfile))
                PLCRValue(i).Offset = Val(ReadProgData(section, "OFFSET", "0", sfile))
                PLCRValue(i).Min = Val(ReadProgData(section, "MIN", "0", sfile))
                PLCRValue(i).Max = Val(ReadProgData(section, "MAX", "1", sfile))
                PLCRValue(i).Unit = ReadProgData(section, "UNIT", "", sfile)
                PLCRValue(i).Factor = Val(ReadProgData(section, "FACTOR", "1", sfile))
            Next
        Else
            WriteProgData("ADDA_SETUP", "TOTAL_AD_CH", "0", sfile)
            WriteProgData("ADDA_SETUP", "TOTAL_DA_CH", "0", sfile)
            For i = 0 To 11
                section = "AD_CH" & Format(i, "00")
                WriteProgData(section, "NAME", section, sfile)
                WriteProgData(section, "FULLSCALE", "1", sfile)
                WriteProgData(section, "ZERO", "0", sfile)
                WriteProgData(section, "OFFSET", "0", sfile)
                WriteProgData(section, "MIN", "0", sfile)
                WriteProgData(section, "MAX", "1", sfile)
                WriteProgData(section, "UNIT", "", sfile)
                WriteProgData(section, "FACTOR", "1", sfile)

                section = "DA_CH" & Format(i, "00")
                WriteProgData(section, "NAME", section, sfile)
                WriteProgData(section, "FULLSCALE", "1", sfile)
                WriteProgData(section, "ZERO", "0", sfile)
                WriteProgData(section, "OFFSET", "0", sfile)
                WriteProgData(section, "MIN", "0", sfile)
                WriteProgData(section, "MAX", "1", sfile)
                WriteProgData(section, "UNIT", "", sfile)
                WriteProgData(section, "FACTOR", "1", sfile)
            Next
        End If



    End Sub

End Module

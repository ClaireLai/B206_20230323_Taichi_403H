Module Module_FileSelect
    Public FileSelectDir As String
    Public FileSelectFilter As String
    Public FileSelectName As String
    Public FormFileSelects As FormFileSelect = FormFileSelect

    Public Function CallFileSelect(ByVal sDir As String, ByVal sFilter As String) As String
        FormFileSelects.Filter = sFilter
        FormFileSelects.Dir = sDir
        FormFileSelects.ShowDialog()
        Return FormFileSelects.FileName

        'If FormFileSelects.ShowDialog() = DialogResult.OK Then
        '    Return FormFileSelects.FileName
        'Else
        '    Return ""
        'End If
    End Function

End Module

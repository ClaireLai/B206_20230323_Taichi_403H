Public Class ControlDataShow

    Public Sub New()

        ' 此為 Windows Form 設計工具所需的呼叫。
        InitializeComponent()

        ' 在 InitializeComponent() 呼叫之後加入任何初始設定。

    End Sub
    '屬性
    ''' <summary>
    ''' 設定顯示標題
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


    WriteOnly Property SetTopTemp() As String
        Set(ByVal value As String)
            lblTopTemp.Text = value
        End Set
    End Property
    WriteOnly Property SetBotTemp() As String
        Set(ByVal value As String)
            lblBotTemp.Text = value
        End Set
    End Property
    WriteOnly Property SetPressure() As String
        Set(ByVal value As String)
            lblPressure.Text = value
        End Set
    End Property
    WriteOnly Property SetTempPreset() As String
        Set(ByVal value As String)
            lblTempPreset.Text = value
        End Set
    End Property
    WriteOnly Property SetPressurePreset() As String
        Set(ByVal value As String)
            lblPressurePreset.Text = value
        End Set
    End Property

End Class

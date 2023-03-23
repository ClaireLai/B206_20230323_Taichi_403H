Public Class ControlDataShowVertical

    Public Sub New()

        ' 此為 Windows Form 設計工具所需的呼叫。
        InitializeComponent()

        ' 在 InitializeComponent() 呼叫之後加入任何初始設定。

    End Sub

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

    Private Sub ControlDataShowVertical_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Interval = 500
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        SetVisible(CelloUsbFlag, lblDa01Text, lblDAValue)
    End Sub
End Class

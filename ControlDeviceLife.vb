Public Class ControlDeviceLife
    Private SiteIndex As Integer

    Property NoReset() As Boolean
        Get
            Return BtnReset.Visible
        End Get
        Set(ByVal value As Boolean)
            btnReset.Visible = value
        End Set
    End Property

    Property DeviceName() As String
        Get
            Return lblDeviceName.Text
        End Get
        Set(ByVal value As String)
            lblDeviceName.Text = value
        End Set
    End Property

    Property LifeTime() As String
        Get
            Return lblLifeTime.Text
        End Get
        Set(ByVal value As String)
            lblLifeTime.Text = value
        End Set
    End Property

    Property LifeTimeSet() As String
        Get
            Return txtLifeTimeSet.Text
        End Get
        Set(ByVal value As String)
            txtLifeTimeSet.Text = value
        End Set
    End Property

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        DeviceLifeTime(SiteIndex).Sec = 0
        DeviceLifeTime(SiteIndex).Min = 0
        DeviceLifeTime(SiteIndex).Hour = 0
    End Sub

    Public Sub New()
        ' 此為 Windows Form 設計工具所需的呼叫。
        InitializeComponent()
        ' 在 InitializeComponent() 呼叫之後加入任何初始設定。
        SiteIndex = 0
    End Sub
    Public Sub Initial(ByVal iSiteIndex As Integer)
        SiteIndex = iSiteIndex
    End Sub



End Class

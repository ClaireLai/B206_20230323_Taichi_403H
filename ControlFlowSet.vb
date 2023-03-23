Public Class ControlFlowSet
    Private SiteIndex As Integer
    Private ADTopFlowIndex As Integer
    Private ADBotFlowIndex As Integer
    Private TopFlow As Double
    Private BotFlow As Double
    Private TopFlowStr As String
    Private BotFlowStr As String
    Private TopFlowHz As Double
    Private BotFlowHz As Double

    Private Section As String
    Sub New()
        ' 此為 Windows Form 設計工具所需的呼叫。
        InitializeComponent()
        ' 在 InitializeComponent() 呼叫之後加入任何初始設定。

    End Sub
    Property Title() As String
        Get
            Return grpFlowTitle.Text
        End Get
        Set(ByVal value As String)
            grpFlowTitle.Text = value
        End Set
    End Property
    ReadOnly Property GetTopFLow() As Double
        Get
            Return TopFlow
        End Get
    End Property
    ReadOnly Property GetBotFLow() As Double
        Get
            Return BotFlow
        End Get
    End Property
    ReadOnly Property GetTopFLowStr() As String
        Get
            Return TopFlowStr
        End Get
    End Property
    ReadOnly Property GetBotFLowStr() As String
        Get
            Return BotFlowStr
        End Get
    End Property

    Public Sub Initial(ByVal iSiteIndex As Integer, ByVal iADTopFlowIndex As Integer, ByVal iADBotFlowIndex As Integer)

        ADTopFlowIndex = iADTopFlowIndex
        ADBotFlowIndex = iADBotFlowIndex
        SiteIndex = iSiteIndex
        Section = "PARAMETER"
        'ReadCalData(ParameterINIFile)
        'WriteCalData(ParameterINIFile)
        Timer1.Interval = 500
        Timer1.Enabled = True
    End Sub

    Private Sub txtTopFlowMeter_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtTopFlowMeter.MouseDown
        If CallKeyboard2(sender, "9999", "0") <> "" Then
            TopFlowHz = Val(txtTopFlowMeter.Text)
            SaveData()
        End If
    End Sub
    Private Sub txtBotFlowMeter_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtBotFlowMeter.MouseDown
        If CallKeyboard2(sender, "9999", "0") <> "" Then
            BotFlowHz = Val(txtBotFlowMeter.Text)
            SaveData()
        End If
    End Sub
    Public Sub SaveData()
        WriteCalData(ParameterINIFile)
    End Sub
    Public Sub WriteCalData(ByVal sfile As String)
        Dim i As Integer
        i = SiteIndex
        WriteProgData(Section, "TOPFLOWMETERHZ" + Format(i, "00"), TopFlowHz.ToString, sfile)
        WriteProgData(Section, "BOTFLOWMETERHZ" + Format(i, "00"), BotFlowHz.ToString, sfile)
    End Sub
    Public Sub ReadCalData(ByVal sfile As String)
        Dim i As Integer
        i = SiteIndex
        TopFlowHz = Val(ReadProgData(Section, "TOPFLOWMETERHZ" + Format(i, "00"), "200", sfile))
        BotFlowHz = Val(ReadProgData(Section, "BOTFLOWMETERHZ" + Format(i, "00"), "200", sfile))
        txtTopFlowMeter.Text = TopFlowHz.ToString
        txtBotFlowMeter.Text = BotFlowHz.ToString
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        TopFlow = 10 * (Get_PLC_R1000(ADTopFlowIndex) / TopFlowHz)
        BotFlow = 10 * (Get_PLC_R1000(ADBotFlowIndex) / BotFlowHz)

        TopFlowStr = Format(TopFlow, "0.0")
        BotFlowStr = Format(BotFlow, "0.0")
        lblTopFlow.Text = TopFlowStr
        lblBotFlow.Text = BotFlowStr
        txtTopFlowMeter.Text = TopFlowHz.ToString
        txtBotFlowMeter.Text = BotFlowHz.ToString
    End Sub
End Class

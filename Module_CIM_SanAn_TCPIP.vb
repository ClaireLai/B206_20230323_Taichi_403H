Imports System.Net
Imports System.Net.Sockets
Imports System.Xml
Imports System.Text
Imports System.Data

Imports System
Imports System.ServiceModel
Imports System.IO

Imports System.Xml.Serialization
Imports System.Collections.Generic
Module Module_CIM_SanAn_TCPIP

#Const SanAn_TCPIP_Used = 0

    Public Class CSanAnTCPProcotol
        Public Event ServerError(ByVal code As Integer)

        Public Event SendEvent(ByVal SendStr As String)
        Public Event ReceiveEvent(ByVal SendStr As String)
        Public Event ReceiveTimeOutEvent(ByVal SendStr As String)

        Public Event Event_H2E_CMD_EXE(ByVal CmdStr As String)
        Public Event Event_H2E_REQ_PARAM_DATA(ByVal eqp As String)
        Public Event Event_H2E_MSG_DPY(ByVal msg As String)
        Public Event Event_E2H_CHK_RSOL_LOCAL(ByVal msg As String)
        Public Event Event_E2H_CHK_RSOL_REMOTE(ByVal msg As String)

        Private TCP_Log As CEventLog
        Public WithEvents _Connection As ConnectionInfo
        Private IPAddr As String = "127.0.0.1"
        Private _ServerAddress As IPAddress
        Private _serverPort As Integer = 502
        Public ReturnMessage As String = ""
        Public ConnectMessage As String = ""
        Private InitialOK As Boolean = False

        Public SendMessage As String = ""
        Public ReceiveMessage As String = ""

        Public Alive As Boolean


        Private Const TIMEOUT_MAX As Integer = 29
        Public TimeOutError(TIMEOUT_MAX) As Boolean

        Private WithEvents Timer1 As Timer
        Private DelayTimerEnabled(TIMEOUT_MAX) As Boolean
        Private DelayTimer(TIMEOUT_MAX) As Integer

        'TCPIP Use  ----------- Start
        Public MESSAGEID As String = "E2H_RPT_EVT"
        Public Send_TID As Integer = 0
        Public Receive_TID As Integer = 0
        Public Reply_TID As Integer = 0
        Public EQPID As String = "EQP_ID"
        Public ServerIP As String = "127.0.0.1"
        Public ServerPort As String = "502"
        Public ServerTimeOut As String = "30"
        Private _SECTION As String = "CIMDATA"
        Private _INIFILE As String = "CIMDATA.INI"
        'TCPIP Use  ----------- End
        Public ServerMode As Boolean = True

        Public Sub ServerIsError(ByVal code As Integer) Handles _Connection.ServerError
            RaiseEvent ServerError(code)
        End Sub
        Public Sub ReadTCPIPSetup()
            ServerIP = ReadProgData(_SECTION, "ServerIP", "127.0.0.1", _INIFILE)
            ServerPort = ReadProgData(_SECTION, "ServerPort", "5000", _INIFILE)
            ServerTimeOut = ReadProgData(_SECTION, "ServerTimeOut", "30", _INIFILE)
        End Sub
        Public Sub WriteTCPIPSetup()
            WriteProgData(_SECTION, "ServerIP", ServerIP, _INIFILE)
            WriteProgData(_SECTION, "ServerPort", ServerPort, _INIFILE)
            WriteProgData(_SECTION, "ServerTimeOut", ServerTimeOut, _INIFILE)
        End Sub

        ReadOnly Property Connected As Boolean
            Get
                If IsNothing(_Connection) = False Then
                    Return _Connection._IsConnected
                Else
                    Return False
                End If

            End Get
        End Property
        Public Sub New()
            TCP_Log = New CEventLog
            TCP_Log.initial("CIM", WorkingDir & "Records\CIM_Log\")

            _SECTION = "CIMDATA"
            _INIFILE = Application.StartupPath & "\" & "CIMDATA.INI"
            ReadTCPIPSetup()
            WriteTCPIPSetup()

            Timer1 = New Timer
            Timer1.Interval = 100
            AddHandler Timer1.Tick, AddressOf HostTCP_Control
            Timer1.Enabled = True

        End Sub
        Public Function Send(ByVal cmd As String) As Integer
            If _Connection._IsConnected Then
                _Connection.Send(cmd)
                TCP_Log.AppendLog("---> Send" & vbCrLf & cmd)
                'TimeOutStart(TIMEOUT_INDEX.SEND_TIMEOUT)
                RaiseEvent SendEvent(cmd)
                Return 0
            Else
                TCP_Log.AppendLog(cmd & "---> Not Connected.")
                Return 1
            End If
        End Function
        Public Function GetValidatedIP(ByVal ipStr As String) As String
            Dim validatedIP As String
            Dim ip As IPAddress
            If IPAddress.TryParse(ipStr, ip) Then
                validatedIP = ip.ToString
                Return validatedIP
            Else
                Return "0.0.0.0"
            End If
        End Function

        Public Function StartServer(ByVal sPort As String) As Boolean
            If IsNothing(_Connection) = True Then
                Send_TID = "000"
                Reply_TID = "000"
                Receive_TID = "000"
                'If _Connection.myTcpListener.Server.Connected Then
                '    _Connection.Close()
                'End If
                _serverPort = Val(sPort)
                _ServerAddress = IPAddress.Parse(IPAddr)
                _Connection = New ConnectionInfo(_serverPort, ServerMode)
                AddHandler _Connection.ReceiveMessage, AddressOf ReceivedMessage
                Try
                    InitialOK = True
                    'MsgBoxLangOK("Server Connected.")
                    ConnectMessage = "Start Port:" & _serverPort.ToString
                    TCP_Log.AppendLog(ConnectMessage)
                    Debug.Print(ConnectMessage)
                    Return True
                Catch ex As Exception
                    ConnectMessage = "StartFail"
                    TCP_Log.AppendLog(ConnectMessage)
                    Debug.Print(ConnectMessage)
                    Return False
                End Try
            Else
                ConnectMessage = "NotInitial"
                TCP_Log.AppendLog(ConnectMessage)
                Debug.Print(ConnectMessage)
                Return False
            End If
        End Function


        Public Function Connect(ByVal sIP As String, ByVal sPort As String) As Integer
            If IsNothing(_Connection) = False Then
                If _Connection._IsConnected Then
                    _Connection.Close()
                    ConnectMessage = "Close Connect"
                    TCP_Log.AppendLog(ConnectMessage)
                    Debug.Print(ConnectMessage)
                Else
                    Try
                        IPAddr = sIP
                        _serverPort = Val(sPort)
                        _ServerAddress = IPAddress.Parse(IPAddr)
                        _Connection = New ConnectionInfo(_ServerAddress, _serverPort, AddressOf ReceivedMessage)
                        If _Connection._IsConnected Then
                            InitialOK = True
                            'MsgBoxLangOK("Server Connected.")
                            ConnectMessage = "Connected IP: " & IPAddr & ", Port:" & _serverPort.ToString
                            TCP_Log.AppendLog(ConnectMessage)
                            Debug.Print(ConnectMessage)
                            _Connection.AwaitData()
                        Else
                            ConnectMessage = "NoConnect"
                            TCP_Log.AppendLog(ConnectMessage)
                            Debug.Print(ConnectMessage)
                        End If
                    Catch ex As Exception
                        InitialOK = False
                        ConnectMessage = "Not Connected"
                        TCP_Log.AppendLog(ConnectMessage)
                        Debug.Print(ConnectMessage)
                    End Try

                End If
            Else
                Try
                    IPAddr = sIP
                    _serverPort = Val(sPort)
                    _ServerAddress = IPAddress.Parse(IPAddr)
                    _Connection = New ConnectionInfo(_ServerAddress, _serverPort, AddressOf ReceivedMessage)
                    If _Connection._IsConnected Then
                        InitialOK = True
                        'MsgBox("Server Connected.")
                        ConnectMessage = "Connected IP: " & IPAddr & ", Port:" & _serverPort.ToString
                        TCP_Log.AppendLog(ConnectMessage)
                        Debug.Print(ConnectMessage)
                        _Connection.AwaitData()
                    Else
                        InitialOK = False
                        ConnectMessage = "Not Connected"
                        TCP_Log.AppendLog(ConnectMessage)
                        Debug.Print(ConnectMessage)
                    End If
                Catch ex As Exception
                    InitialOK = False
                    ConnectMessage = "Connect Fail"
                    TCP_Log.AppendLog(ConnectMessage)
                    Debug.Print(ConnectMessage)
                End Try

            End If
        End Function

        Public Sub CloseConnect()
            If IsNothing(_Connection) = False Then
                If Not ServerMode Then
                    If _Connection._IsConnected Then
                        ConnectMessage = "Close Connect"
                        _Connection.Close()
                        _Connection = Nothing
                    End If
                End If
            End If
        End Sub


        Public HostCommand As HOST_COMMAND = HOST_COMMAND.NO_COMMAND
        Public HostMessage As String = ""
        Enum HOST_COMMAND
            NO_COMMAND = 0
            E2H_CHK_ALIVE_R = 1
            E2H_RPT_EVT_R = 2
            E2H_RPT_ALM_R = 3
            E2H_CHK_RSOL_R = 4
            E2H_CHK_RSOL = 5
            H2E_CMD_EXE = 6
            H2E_REQ_PARAM_DATA = 7
            H2E_MSG_DPY = 8
            H2E_CMD_EXE_LOADRECIPE = 9
            H2E_CMD_EXE_PROCESS_RUN = 10
        End Enum


        Public ConfirmRunProcess As Boolean = False
        Public ConfirmRunProcessCancel As Boolean = False
        ''' <summary>
        ''' 收到 H2E_CMD_EXE  的 START 指令, 開始載入 RECIPE 並執行 製程
        ''' </summary>
        ''' <remarks></remarks>
        Public HostCommadStartProcess As Boolean = False


        '收到 H2E_CMD_EXE  的 START 指令, 開始載入 RECIPE 並執行 製程
        Public Sub RemoteLoadRecipeAndRun()
            Static Control_State As Integer
            Static Last_State As Integer
            Static DelayTimer As Integer
            Static DelayTimerEnabled As Boolean
            Dim i As Integer
            On Error Resume Next

            Select Case Control_State
                Case 0 'Wait Start Command 
                    If HostCommadStartProcess Then
                        ConfirmRunProcess = False
                        ConfirmRunProcessCancel = False
                        'Load Recipe
                        If IO.File.Exists(RemoteCIM.RecipeData.RecipeFileName) Then
                            RemoteCIM.ErrorString = GetLangText("In-Line: 載入配方中.", "In-Line: Loading Recipe.")
                            If FormProcesss.RemoteLoadRecipe() Then
                                RemoteCIM.ErrorString = GetLangText("In-Line: 配方已載入.", "In-Line: Recipe Loaded.")
                                RemoteCIM.RecipeData.RecipeLoaded = True
                                If RemoteCIM.ConfirmEnable Then
                                    RemoteCIM.ErrorString = GetLangText("In-Line: 等待使用者確認執行.", "In-Line: Wait user confirm to run process.")

                                    FormSanAnBarcodeInputConfirm.TopMost = True
                                    FormSanAnBarcodeInputConfirm.ChangeLanguage()
                                    FormSanAnBarcodeInputConfirm.lblEQID.Text = RemoteCIM.RecipeData.EQID
                                    FormSanAnBarcodeInputConfirm.lblRunID.Text = RemoteCIM.RecipeData.RUNID
                                    FormSanAnBarcodeInputConfirm.lblOPID.Text = RemoteCIM.RecipeData.OPID
                                    FormSanAnBarcodeInputConfirm.txtLotID.Text = RemoteCIM.RecipeData.LOTID
                                    FormSanAnBarcodeInputConfirm.lblRecipeName.Text = RemoteCIM.RecipeData.RecipeName
                                    FormSanAnBarcodeInputConfirm.lstWaferID.Items.Clear()
#If SanAn_TCPIP_Used = 1 Then
                                    FormProcesss.CtlSanAnCIM1.lstWaferID.Items.Clear()
#End If

                                    RemoteCIM.PorcessDataFileName = RemoteCIM.RecipeData.RUNID & "_" & FDate + "-" + FTime + "-[" + LoginUserName + "]"
                                    If RemoteCIM.RecipeData.ProductCount > 0 Then
                                        For i = 0 To RemoteCIM.RecipeData.ProductID(0).WaferCount - 1
                                            Dim sstr As String
                                            sstr = (i + 1).ToString("00") & ". " & RemoteCIM.RecipeData.ProductID(0).WaferID(i)
                                            FormSanAnBarcodeInputConfirm.lstWaferID.Items.Add(sstr)
#If SanAn_TCPIP_Used = 1 Then
          FormProcesss.CtlSanAnCIM1.lstWaferID.Items.Add(sstr)
#End If
                                        Next
                                    End If
                                    FormSanAnBarcodeInputConfirm.lblWaferCount.Text = RemoteCIM.RecipeData.ProductID(0).WaferCount.ToString
#If SanAn_TCPIP_Used = 1 Then
       FormProcesss.CtlSanAnCIM1.lblRecipeName.Text = RemoteCIM.RecipeData.RecipeName
#End If
                             
                                    DelayTimer = 5
                                    DelayTimerEnabled = True
                                    Control_State = 1
                                    If FormSanAnBarcodeInputConfirm.Visible = False Then FormSanAnBarcodeInputConfirm.ShowDialog()

                                Else
                                    DelayTimer = 5
                                    DelayTimerEnabled = False
                                    Control_State = 2
                                End If
                            Else
                                RemoteCIM.ErrorString = GetLangText("In-Line: 製程執行異常,停止製桯.", "In-Line: Process Error,Stop process.")

                                H2E_CMD_EXE_R_NG(EQPID, "Load Recipe Error.")
                                ConfirmRunProcess = False
                                ConfirmRunProcessCancel = False

                                DelayTimer = 0
                                DelayTimerEnabled = False
                                Control_State = 0
                                HostCommadStartProcess = False
                                CIM_MsgBoxShow(RemoteCIM.ErrorString)

                            End If
                        Else
                            RemoteCIM.ErrorString = GetLangText("In-Line: 遠端配方載入錯誤,停止製程!", "In-Line: Remote recipe load error, Stop process!")
                            DelayTimer = 0
                            DelayTimerEnabled = False
                            Control_State = 0
                            H2E_CMD_EXE_R_NG(EQPID, "Load Recipe Error.")
                            ConfirmRunProcess = False
                            ConfirmRunProcessCancel = False
                            HostCommadStartProcess = False
                            CIM_MsgBoxShow(RemoteCIM.ErrorString)
                        End If
                    End If
                Case 1 'Wait User COnfirm 
                    If HostCommadStartProcess Then
                        If DelayTimerEnabled = False Then
                            If ConfirmRunProcess = False And ConfirmRunProcessCancel = False Then
                                If FormSanAnBarcodeInputConfirm.Visible = False Then
                                    FormSanAnBarcodeInputConfirm.Show()
                                End If
                            End If
                            If ConfirmRunProcess Then
                                RemoteCIM.ErrorString = GetLangText("In-Line: 使用者確認執行製程.", "In-Line: User confirm to run process.")

                                ConfirmRunProcess = False
                                ConfirmRunProcessCancel = False
                                DelayTimer = 5
                                DelayTimerEnabled = True
                                Control_State = 2
                            End If
                            If ConfirmRunProcessCancel Then
                                HostCommadStartProcess = False
                                RemoteCIM.ErrorString = GetLangText("In-Line: 使用者取消執行製程.", "In-Line: User cancel process.")
                                H2E_CMD_EXE_R_NG(EQPID, "User Cancel process.")
                                ConfirmRunProcess = False
                                ConfirmRunProcessCancel = False
#If SanAn_TCPIP_Used = 1 Then
        FormProcesss.CtlSanAnCIM1.ClearData()
        FormProcesss.CtlSanAnCIM1.Restart()
#End If
                              
                                DelayTimer = 0
                                DelayTimerEnabled = False
                                Control_State = 0
                            End If

                        End If
                    Else
                        ConfirmRunProcess = False
                        ConfirmRunProcessCancel = False

                        DelayTimer = 0
                        DelayTimerEnabled = False
                        Control_State = 0
                    End If
                Case 2 'Run PRocess
                    If HostCommadStartProcess Then
                        If DelayTimerEnabled = False Then
                            If ProcessMode_RUN = False Then
                                If FormProcesss.RemoteRunProcess() Then
                                    E2H_RPT_EVT_ProcessStart(EQPID, RemoteCIM.RecipeData.RUNID)
                                    RemoteCIM.ErrorString = GetLangText("In-Line: 製程執行中.", "In-Line: Process Running.")
                                    DelayTimer = 5
                                    DelayTimerEnabled = True
                                    Control_State = 3
                                End If
                            Else
                                RemoteCIM.ErrorString = GetLangText("In-Line: 製程已在執行中.", "In-Line: Process already Running.")
                                H2E_CMD_EXE_R_NG(EQPID, "Process already Running.")
                                ConfirmRunProcess = False
                                ConfirmRunProcessCancel = False
                                DelayTimer = 0
                                DelayTimerEnabled = False
                                Control_State = 0
                                CIM_MsgBoxShow(RemoteCIM.ErrorString)

                            End If
                        End If
                    Else
                        ConfirmRunProcess = False
                        ConfirmRunProcessCancel = False

                        DelayTimer = 0
                        DelayTimerEnabled = False
                        Control_State = 0
                    End If
                Case 3 'Wait Process end 
                    If HostCommadStartProcess Then
                        If ProcessMode_RUN = False Then
                            ConfirmRunProcess = False
                            ConfirmRunProcessCancel = False
                            HostCommadStartProcess = False
                            DelayTimer = 0
                            DelayTimerEnabled = False
                            Control_State = 0
#If SanAn_TCPIP_Used = 1 Then
                            FormProcesss.CtlSanAnCIM1.ClearData()
                            FormProcesss.CtlSanAnCIM1.Restart()
#End If
                            E2H_RPT_EVT_ProcessEnd(EQPID, RemoteCIM.RecipeData.RUNID)
                            RemoteCIM.ErrorString = GetLangText("In-Line: 製程完成.", "In-Line: Process End.")
                        End If
                    Else
                        ConfirmRunProcess = False
                        ConfirmRunProcessCancel = False

                        DelayTimer = 0
                        DelayTimerEnabled = False
                        Control_State = 0
                    End If
            End Select


            If DelayTimerEnabled Then
                DelayTimer -= 1
                If DelayTimer <= 0 Then
                    DelayTimerEnabled = False
                    DelayTimer = 0
                End If
            Else
                DelayTimer = 0
            End If

        End Sub


        Public Sub HostTCP_Control()


            Try
                Select Case HostCommand

                    Case HOST_COMMAND.NO_COMMAND
                        HostMessage = ""
                    Case HOST_COMMAND.E2H_CHK_ALIVE_R
                        HostCommand = HOST_COMMAND.NO_COMMAND
                        HostMessage = ""
                    Case HOST_COMMAND.E2H_RPT_EVT_R
                        HostCommand = HOST_COMMAND.NO_COMMAND
                        HostMessage = ""
                    Case HOST_COMMAND.E2H_RPT_ALM_R
                        HostCommand = HOST_COMMAND.NO_COMMAND
                        HostMessage = ""
                    Case HOST_COMMAND.E2H_CHK_RSOL_R
                        HostCommand = HOST_COMMAND.NO_COMMAND
                        HostMessage = ""
                    Case HOST_COMMAND.E2H_CHK_RSOL
                        Dim message As String = HostMessage
                        HostCommand = HOST_COMMAND.NO_COMMAND
                        HostMessage = ""

                        Dim Xmldoc = New XmlDocument
                        Xmldoc.LoadXml(message)
                        Dim stringWriter As New IO.StringWriter
                        Dim settings As XmlWriterSettings = New XmlWriterSettings()
                        settings.Indent = True
                        Dim XmlTextWriter = XmlWriter.Create(stringWriter, settings)
                        Xmldoc.WriteTo(XmlTextWriter)
                        XmlTextWriter.Flush()
                        ReturnMessage = stringWriter.GetStringBuilder().ToString() ' FormatXml(message)
                        Dim cmd As String = ""
                        cmd = Trim(Xmldoc.DocumentElement.GetElementsByTagName("RSOL").Item(0).InnerText).ToUpper
                        If ProcessMode_RUN = False Then
                            Select Case cmd
                                Case "LOCAL"
                                    E2H_CHK_ALIVE_R_OK(EQPID)
                                    RaiseEvent Event_E2H_CHK_RSOL_LOCAL(message)
                                Case "REMOTE"
                                    E2H_CHK_ALIVE_R_OK(EQPID)

#If SanAn_TCPIP_Used = 1 Then
                                    FormProcesss.tabProcessDataCurve.SelectTab(FormProcesss.tpCIMInput)  
                                    FormProcesss.CtlSanAnCIM1.txtOpID.SelectAll()
                                    FormProcesss.CtlSanAnCIM1.txtOpID.Focus()
#End If
                                    RaiseEvent Event_E2H_CHK_RSOL_REMOTE(message)
                                Case Else
                                    E2H_CHK_ALIVE_R_NG(EQPID)
                            End Select
                        Else
                            E2H_CHK_ALIVE_R_NG(EQPID)
                        End If
                    Case HOST_COMMAND.H2E_CMD_EXE
                        Dim message As String = HostMessage
                        HostCommand = HOST_COMMAND.NO_COMMAND
                        HostMessage = ""
                        HostCommadStartProcess = False


                        Dim Xmldoc = New XmlDocument
                        Xmldoc.LoadXml(message)
                        Dim stringWriter As New IO.StringWriter
                        Dim settings As XmlWriterSettings = New XmlWriterSettings()
                        settings.Indent = True
                        Dim XmlTextWriter = XmlWriter.Create(stringWriter, settings)
                        Xmldoc.WriteTo(XmlTextWriter)
                        XmlTextWriter.Flush()
                        ReturnMessage = stringWriter.GetStringBuilder().ToString() ' FormatXml(message)
                        Dim cmd As String = ""
                        cmd = Trim(Xmldoc.DocumentElement.GetElementsByTagName("command").Item(0).InnerText).ToUpper
                        Select Case cmd
                            Case "START"
                                If RemoteCIM.RecipeData.Recieve_H2E_CMD_EXE(message) = "OK" Then
                                    RemoteCIM.RecipeData.RecipeLoaded = False
                                    RemoteCIM.RecipeData.RecipeName = RemoteCIM.RecipeData.ProductID(0).RecipeID
                                    RemoteCIM.RecipeData.RecipeShortFileName = RemoteCIM.RecipeData.RecipeName & ".RCP" '配方檔名
                                    RemoteCIM.RecipeData.RecipeFileName = RecipeDir & RemoteCIM.RecipeData.RecipeShortFileName
                                    HostCommadStartProcess = True
                                    RemoteCIM.RecipeData.RecipeLoaded = False
                                    'If IO.File.Exists(RemoteCIM.RecipeData.RecipeFileName) Then
                                    '    If FormProcesss.RemoteLoadRecipe() Then
                                    '        If RemoteCIM.RecipeData.RecipeLoaded = False Then
                                    '            RemoteCIM.ErrorString = GetLangText("In-Line: 載入配方中.", "In-Line: Loading Recipe.")
                                    '        End If
                                    '        RemoteCIM.RecipeData.RecipeLoaded = True
                                    '        If ProcessMode_RUN = False Then
                                    '            If FormProcesss.RemoteRunProcess() Then
                                    '                H2E_CMD_EXE_R_OK(EQPID, "Process Run.")
                                    '                RemoteCIM.ErrorString = GetLangText("In-Line: 製程執行中.", "In-Line: Process Running.")
                                    '            End If
                                    '        Else
                                    '            RemoteCIM.ErrorString = GetLangText("In-Line: 製程已在執行中.", "In-Line: Process already Running.")
                                    '            H2E_CMD_EXE_R_NG(EQPID, "Process already Running.")
                                    '            CIM_MsgBoxShow(RemoteCIM.ErrorString)
                                    '        End If
                                    '    Else
                                    '        RemoteCIM.ErrorString = GetLangText("In-Line: 製程執行異常,停止製桯.", "In-Line: Process Error,Stop process.")
                                    '        CIM_MsgBoxShow(RemoteCIM.ErrorString)
                                    '        H2E_CMD_EXE_R_NG(EQPID, "Load Recipe Error.")
                                    '    End If
                                    'Else
                                    '    RemoteCIM.ErrorString = GetLangText("In-Line: 遠端配方載入錯誤,停止製程!", "In-Line: Remote recipe load error, Stop process!")
                                    '    CIM_MsgBoxShow(RemoteCIM.ErrorString)
                                    '    H2E_CMD_EXE_R_NG(EQPID, "Load Recipe Error.")
                                    'End If
                                    H2E_CMD_EXE_R_OK(EQPID, "")
                                Else
                                    RemoteCIM.ErrorString = GetLangText("In-Line: 遠端配方檔案不存在!", "In-Line: Remote recipe file not existed!")
                                    CIM_MsgBoxShow(RemoteCIM.ErrorString)
                                    H2E_CMD_EXE_R_NG(EQPID, "Recipe not Exist.")
                                End If

                            Case "STOP"
                                H2E_CMD_EXE_R_NG(EQPID, "Reject Stop Command.")
                            Case "PAUSE"
                                H2E_CMD_EXE_R_NG(EQPID, "Reject Pause Command.")
                            Case "RESUME"
                                H2E_CMD_EXE_R_NG(EQPID, "Reject Resume Command.")
                            Case Else
                                H2E_CMD_EXE_R_NG(EQPID, "Uknow Command:" & cmd)
                        End Select
                    Case HOST_COMMAND.H2E_REQ_PARAM_DATA
                        HostCommand = HOST_COMMAND.NO_COMMAND
                        HostMessage = ""
                        H2E_REQ_PARAM_R(EQPID)
                        'RaiseEvent Event_H2E_REQ_PARAM_DATA(EQPID)
                    Case HOST_COMMAND.H2E_MSG_DPY
                        Dim message As String = HostMessage
                        HostCommand = HOST_COMMAND.NO_COMMAND
                        HostMessage = ""
                        Dim Xmldoc = New XmlDocument
                        Xmldoc.LoadXml(message)
                        Dim stringWriter As New IO.StringWriter
                        Dim settings As XmlWriterSettings = New XmlWriterSettings()
                        settings.Indent = True
                        Dim XmlTextWriter = XmlWriter.Create(stringWriter, settings)
                        Xmldoc.WriteTo(XmlTextWriter)
                        XmlTextWriter.Flush()
                        ReturnMessage = stringWriter.GetStringBuilder().ToString() ' FormatXml(message)
                        Dim msg As String = ""
                        msg = Trim(Xmldoc.DocumentElement.GetElementsByTagName("message").Item(0).InnerText)
                        H2E_MSG_DPY_R(EQPID, ACK_CODE.OK, "")
                        RaiseEvent Event_H2E_MSG_DPY(msg)
                End Select
            Catch ex As Exception
                CIM_MsgBoxOK("CIM Error", ex.ToString)
                'Timer1.Enabled = True
            End Try

            RemoteLoadRecipeAndRun()
        End Sub
        Public Sub ReceivedMessage(ByVal message As String)
            'Dim OnComm As New Action(Of String)(AddressOf PLC_OnComm)
            If Not ServerMode Then _Connection.Stream.Flush()
            message = message.Trim(Chr(10))
            message = message.Trim(Chr(13))
            message = message.Trim(" ")
            message = message.Replace(Chr(0), "")
            Dim Xmldoc = New XmlDocument
            '//從指定的字串載入XML文件
            HostCommand = HOST_COMMAND.NO_COMMAND
            HostMessage = ""
            Try
                Xmldoc.LoadXml(message)
                HostMessage = message
                Dim stringWriter As New IO.StringWriter
                Dim settings As XmlWriterSettings = New XmlWriterSettings()
                settings.Indent = True
                Dim XmlTextWriter = XmlWriter.Create(stringWriter, settings)
                Xmldoc.WriteTo(XmlTextWriter)
                XmlTextWriter.Flush()
                ReturnMessage = stringWriter.GetStringBuilder().ToString() ' FormatXml(message)
                'UpdateUI(ReturnMessage, lblMessage)
                If Xmldoc.DocumentElement.GetElementsByTagName("msg_id").Count > 0 Then
                    Dim msgid As String = ""
                    Dim rtid As String = ""
                    msgid = Trim(Xmldoc.DocumentElement.GetElementsByTagName("msg_id").Item(0).InnerText)
                    rtid = Trim(Xmldoc.DocumentElement.GetElementsByTagName("tid").Item(0).InnerText)
                    Select Case msgid
                        Case "E2H_CHK_ALIVE_R"
                            HostCommand = HOST_COMMAND.E2H_CHK_ALIVE_R
                            Alive = True
                        Case "E2H_RPT_EVT_R"
                            HostCommand = HOST_COMMAND.E2H_RPT_EVT_R
                        Case "E2H_RPT_ALM_R"
                            HostCommand = HOST_COMMAND.E2H_RPT_ALM_R
                        Case "E2H_CHK_RSOL_R"
                            HostCommand = HOST_COMMAND.E2H_CHK_RSOL_R
                        Case "E2H_CHK_RSOL"
                            Receive_TID = Val(Trim(Xmldoc.DocumentElement.GetElementsByTagName("tid").Item(0).InnerText))
                            Reply_TID = Receive_TID
                            HostCommand = HOST_COMMAND.E2H_CHK_RSOL
                            'Dim cmd As String = ""
                            'cmd = Trim(Xmldoc.DocumentElement.GetElementsByTagName("RSOL").Item(0).InnerText).ToUpper
                            'If ProcessMode_RUN = False Then
                            '    Select Case cmd
                            '        Case "LOCAL"
                            '            E2H_CHK_ALIVE_R_OK(EQPID)
                            '            RaiseEvent Event_E2H_CHK_RSOL_LOCAL(message)
                            '        Case "REMOTE"
                            '            E2H_CHK_ALIVE_R_OK(EQPID)
                            '            RaiseEvent Event_E2H_CHK_RSOL_REMOTE(message)
                            '        Case Else
                            '            E2H_CHK_ALIVE_R_NG(EQPID)
                            '    End Select
                            'Else
                            '    E2H_CHK_ALIVE_R_NG(EQPID)
                            'End If

                        Case "H2E_CMD_EXE"
                            Receive_TID = Val(Trim(Xmldoc.DocumentElement.GetElementsByTagName("tid").Item(0).InnerText))
                            Reply_TID = Receive_TID

                            HostCommand = HOST_COMMAND.H2E_CMD_EXE
                            'Dim cmd As String = ""
                            'cmd = Trim(Xmldoc.DocumentElement.GetElementsByTagName("command").Item(0).InnerText).ToUpper
                            'Select Case cmd
                            '    Case "START"
                            '        If RemoteCIM.RecipeData.Recieve_H2E_CMD_EXE(message) = "OK" Then
                            '            RemoteCIM.RecipeData.RecipeLoaded = False
                            '            RemoteCIM.RecipeData.RecipeName = RemoteCIM.RecipeData.ProductID(0).RecipeID
                            '            RemoteCIM.RecipeData.RecipeShortFileName = RemoteCIM.RecipeData.RecipeName & ".RCP" '配方檔名
                            '            RemoteCIM.RecipeData.RecipeFileName = RecipeDir & RemoteCIM.RecipeData.RecipeShortFileName
                            '            'FormProcess.CtlSanAnCIM1.UpdateLotData()

                            '            If IO.File.Exists(RemoteCIM.RecipeData.RecipeFileName) Then
                            '                If FormProcesss.RemoteLoadRecipe() Then
                            '                    Application.DoEvents()
                            '                    System.Threading.Thread.Sleep(500)
                            '                    Application.DoEvents()
                            '                    System.Threading.Thread.Sleep(500)
                            '                    Application.DoEvents()
                            '                    System.Threading.Thread.Sleep(500)
                            '                    RemoteCIM.RecipeData.RecipeLoaded = True
                            '                    If ProcessMode_RUN = False Then
                            '                        If FormProcesss.RemoteRunProcess() Then
                            '                            Application.DoEvents()
                            '                            System.Threading.Thread.Sleep(500)
                            '                            Application.DoEvents()
                            '                            System.Threading.Thread.Sleep(500)
                            '                            Application.DoEvents()
                            '                            System.Threading.Thread.Sleep(500)
                            '                            H2E_CMD_EXE_R_OK(EQPID, "Process Run.")
                            '                            RemoteCIM.ErrorString = GetLangText("In-Line: 製程執行中.", "In-Line: Process Running.")
                            '                        End If
                            '                    Else
                            '                        RemoteCIM.ErrorString = GetLangText("In-Line: 製程已在執行中.", "In-Line: Process already Running.")
                            '                        H2E_CMD_EXE_R_OK(EQPID, "Process already Running.")
                            '                        CIM_MsgBoxShow(RemoteCIM.ErrorString)
                            '                    End If
                            '                Else
                            '                    RemoteCIM.ErrorString = GetLangText("In-Line: 製程執行異常,停止製桯.", "In-Line: Process Error,Stop process.")
                            '                    CIM_MsgBoxShow(RemoteCIM.ErrorString)
                            '                    H2E_CMD_EXE_R_OK(EQPID, "Load Recipe Error.")
                            '                End If
                            '            Else
                            '                RemoteCIM.ErrorString = GetLangText("In-Line: 遠端配方載入錯誤,停止製程!", "In-Line: Remote recipe load error, Stop process!")
                            '                CIM_MsgBoxShow(RemoteCIM.ErrorString)
                            '                H2E_CMD_EXE_R_OK(EQPID, "Load Recipe Error.")
                            '            End If
                            '        Else
                            '            RemoteCIM.ErrorString = GetLangText("In-Line: 遠端配方檔案不存在!", "In-Line: Remote recipe file not existed!")
                            '            CIM_MsgBoxShow(RemoteCIM.ErrorString)
                            '            H2E_CMD_EXE_R_OK(EQPID, "Recipe not Exist.")
                            '        End If
                            '    Case "STOP"
                            '        H2E_CMD_EXE_R_NG(EQPID, "Reject Stop Command.")
                            '    Case "PAUSE"
                            '        H2E_CMD_EXE_R_NG(EQPID, "Reject Pause Command.")
                            '    Case "RESUME"
                            '        H2E_CMD_EXE_R_NG(EQPID, "Reject Resume Command.")
                            '    Case Else
                            '        H2E_CMD_EXE_R_NG(EQPID, "Uknow Command:" & cmd)
                            'End Select
                            'RaiseEvent Event_H2E_CMD_EXE(message)

                        Case "H2E_REQ_PARAM_DATA"
                            Receive_TID = Val(Trim(Xmldoc.DocumentElement.GetElementsByTagName("tid").Item(0).InnerText))
                            Reply_TID = Receive_TID

                            HostCommand = HOST_COMMAND.H2E_REQ_PARAM_DATA
                            'H2E_REQ_PARAM_R(EQPID)
                            'RaiseEvent Event_H2E_REQ_PARAM_DATA()
                        Case "H2E_MSG_DPY"
                            Receive_TID = Val(Trim(Xmldoc.DocumentElement.GetElementsByTagName("tid").Item(0).InnerText))
                            Reply_TID = Receive_TID

                            HostCommand = HOST_COMMAND.H2E_MSG_DPY
                            'Dim msg As String = ""
                            'msg = Trim(Xmldoc.DocumentElement.GetElementsByTagName("message").Item(0).InnerText)
                            ''MsgBox(msg, MsgBoxStyle.OkOnly, "CIM Message")
                            'RaiseEvent Event_H2E_MSG_DPY(msg)
                    End Select
                    'TimeOutStop(TIMEOUT_INDEX.SEND_TIMEOUT)
                End If
                TCP_Log.AppendLog("---> Receive" & vbCrLf & message)
                RaiseEvent ReceiveEvent(message)
            Catch ex As Exception
                Select Case Command()
                    Case 6
                        CIM_MsgBoxShow("H2E_CMD_EXE Command Error.")
                    Case Else
                        CIM_MsgBoxShow(ex.ToString)
                End Select

            End Try
        End Sub


        '1.1       Check alive
        '    HOST->EQP(E2H_CHK_ALIVE_R)					
        'Tag Name		Description		Comment	M/Opt
        'msg_id		Message ID		E2H_CHK_ALIVE_R	
        'tid		TID		Transaction ID  ex:111	
        'datetime		DateTime		2015/3/31 20:13	
        'eqp_id		EQP ID		AAF10	
        'ack_code		Ack_code		0:OK, Others:NG	
        'ack_descr		Ack_description			

        Public Sub E2H_CHK_ALIVE(ByVal EQPID As String)
            Dim doc As New XmlDocument()
            Dim dec As XmlDeclaration
            Dim docRoot As XmlElement
            Dim node As XmlElement
            '<?xml version=”1.0” encoding=”UTF-8”?>					
            '<message>					
            '  <msg_id>E2H_CHK_ALIVE</msg_id>					
            '  <tid>111</tid>					
            '  <datetime>2015/03/31 20:13:05</datetime>					
            '  <eqp_id>AAF10</eqp_id>					
            '</message>				
            dec = doc.CreateXmlDeclaration("1.0", "UTF-8", "")
            doc.AppendChild(dec)
            docRoot = doc.CreateElement("message")
            doc.AppendChild(docRoot)

            node = doc.CreateElement("msg_id")
            node.InnerText = "E2H_CHK_ALIVE"
            docRoot.AppendChild(node)

            node = doc.CreateElement("tid")
            node.InnerText = Send_TID.ToString("0")
            docRoot.AppendChild(node)

            node = doc.CreateElement("datetime")
            node.InnerText = Now.ToString("yyyy/MM/dd HH:mm:ss")
            docRoot.AppendChild(node)

            node = doc.CreateElement("eqp_id")
            node.InnerText = EQPID
            docRoot.AppendChild(node)

            Dim stringWriter As New IO.StringWriter
            Dim settings As XmlWriterSettings = New XmlWriterSettings()
            settings.Indent = True
            Dim XmlTextWriter = XmlWriter.Create(stringWriter, settings)
            doc.WriteTo(XmlTextWriter)
            XmlTextWriter.Flush()
            Dim cmd As String = stringWriter.GetStringBuilder().ToString
            Send(cmd)
            Process_Send_TID()
        End Sub

        'HOST->EQP(E2H_CHK_ALIVE_R)			
        'Tag Name	Description	Comment	M/Opt
        'msg_id	Message ID	E2H_CHK_ALIVE_R	
        'tid	TID	Transaction ID  ex:111	
        'datetime	DateTime	2015/3/31 20:13	
        'eqp_id	EQP ID	AAF10	
        'ack_code	Ack_code	0:OK, Others:NG	
        'ack_descr	Ack_description		
        '<?xml version=”1.0” encoding=”UTF-8”?>			
        '<message>			
        '  <msg_id>E2H_CHK_ALIVE_R</msg_id>			
        '  <tid>111</tid>			
        '  <datetime>2015/03/31 20:13:05</datetime>			
        '  <eqp_id>AAF10</eqp_id>			
        '  <ack_code>0</ack_code>			
        '  <ack_descr></ack_descr>			
        '</message>			

        Public Sub E2H_CHK_ALIVE_R(ByVal EQPID As String, ByVal ack_code As ACK_CODE, Optional ByVal ACK_Descr As String = "")
            Dim doc As New XmlDocument()
            Dim dec As XmlDeclaration
            Dim docRoot As XmlElement
            Dim node As XmlElement
            '<?xml version=”1.0” encoding=”UTF-8”?>			
            '<message>			
            '  <msg_id>E2H_CHK_ALIVE_R</msg_id>			
            '  <tid>111</tid>			
            '  <datetime>2015/03/31 20:13:05</datetime>			
            '  <eqp_id>AAF10</eqp_id>			
            '  <ack_code>0</ack_code>			
            '  <ack_descr></ack_descr>			
            '</message>			


            dec = doc.CreateXmlDeclaration("1.0", "UTF-8", "")
            doc.AppendChild(dec)
            docRoot = doc.CreateElement("message")
            doc.AppendChild(docRoot)

            node = doc.CreateElement("msg_id")
            node.InnerText = "E2H_CHK_ALIVE_R"
            docRoot.AppendChild(node)

            node = doc.CreateElement("tid")
            node.InnerText = Reply_TID.ToString("0")
            docRoot.AppendChild(node)

            node = doc.CreateElement("datetime")
            node.InnerText = Now.ToString("yyyy/MM/dd HH:mm:ss")
            docRoot.AppendChild(node)

            node = doc.CreateElement("eqp_id")
            node.InnerText = EQPID
            docRoot.AppendChild(node)

            node = doc.CreateElement("ack_code")
            Select Case ack_code
                Case CSanAnTCPProcotol.ACK_CODE.OK
                    node.InnerText = "0"
                Case CSanAnTCPProcotol.ACK_CODE.NG
                    node.InnerText = "1"
                Case Else
                    node.InnerText = "1"
            End Select
            docRoot.AppendChild(node)

            node = doc.CreateElement("ack_descr")
            node.InnerText = ACK_Descr
            docRoot.AppendChild(node)

            Dim stringWriter As New IO.StringWriter
            Dim settings As XmlWriterSettings = New XmlWriterSettings()
            settings.Indent = True
            Dim XmlTextWriter = XmlWriter.Create(stringWriter, settings)
            doc.WriteTo(XmlTextWriter)
            XmlTextWriter.Flush()
            Dim cmd As String = stringWriter.GetStringBuilder().ToString
            Send(cmd)
        End Sub
        Public Sub E2H_CHK_ALIVE_R_OK(ByVal EQPID As String, Optional ByVal ACK_Descr As String = "")
            E2H_CHK_ALIVE_R(EQPID, ACK_CODE.OK, ACK_Descr)
        End Sub
        Public Sub E2H_CHK_ALIVE_R_NG(ByVal EQPID As String, Optional ByVal ACK_Descr As String = "")
            E2H_CHK_ALIVE_R(EQPID, ACK_CODE.NG, ACK_Descr)
        End Sub


        '1.2       Command Execution
        'Host->EQP(H2E_CMD_EXE)			
        'Tag Name	Description	Comment	M/Opt
        'msg_id	Message ID	H2E_CMD_EXE	
        'tid	TID	Transaction ID  ex:111	
        'datetime	DateTime	2015/3/31 20:13	
        'eqp_id	Eqp ID	AAF10	
        'cmd	Command	Start/Stop/Pause/Resume	"下貨時帶Start
        '(Stop/Pause/Resume暫不使用)"
        'port	Port number	Always be 1 when equipment has only 1 port	机台有三個CST Port ，編號:1~3
        'recipe	Recipe name	Only be used with Start command	Product_Recipe = 机台傳送配方(Wafer Flow Recipe)
        'mask	Mask ID	Only be used when equipment has mask	不使用，給空值
        'product_id_list			
        'product_id	Product name	Ex: Lot ID	
        'wafer_id_list			
        'wafer_id	Wafer ID		
        '<?xml version="1.0" encoding="utf-8"?>
        '<message>
        '   <msg_id>H2E_CMD_EXE</msg_id>
        '   <tid>111</tid>
        '   <datetime>2020/07/21 17:28:13</datetime>
        '   <eqp_id>AAF10</eqp_id>
        '   <command>Start</command>
        '   <port>1</port>
        '   <recipe>CIM_DownLoad</recipe>
        '   <mask>-</mask>
        '   <product_id_list>
        '      <product_id>Lot001</product_id>
        '      <wafer_id_list>
        '         <wafer_id>Lot001-1-1</wafer_id>
        '         <wafer_id>Lot001-1-2</wafer_id>
        '         <wafer_id>Lot001-1-3</wafer_id>
        '         <wafer_id>Lot001-1-4</wafer_id>
        '         <wafer_id>Lot001-1-5</wafer_id>
        '         <wafer_id>Lot001-1-6</wafer_id>
        '         <wafer_id>Lot001-1-7</wafer_id>
        '         <wafer_id>Lot001-1-8</wafer_id>
        '         <wafer_id>Lot001-1-9</wafer_id>
        '         <wafer_id>Lot001-1-10</wafer_id>
        '         <wafer_id>Lot001-1-11</wafer_id>
        '         <wafer_id>Lot001-1-12</wafer_id>
        '         <wafer_id>Lot001-1-13</wafer_id>
        '         <wafer_id>Lot001-1-14</wafer_id>
        '         <wafer_id>Lot001-1-15</wafer_id>
        '         <wafer_id>Lot001-1-16</wafer_id>
        '         <wafer_id>Lot001-1-17</wafer_id>
        '         <wafer_id>Lot001-1-18</wafer_id>
        '         <wafer_id>Lot001-1-19</wafer_id>
        '         <wafer_id>Lot001-1-20</wafer_id>
        '         <wafer_id>Lot001-1-21</wafer_id>
        '         <wafer_id>Lot001-1-22</wafer_id>
        '         <wafer_id>Lot001-1-23</wafer_id>
        '         <wafer_id>Lot001-1-24</wafer_id>
        '         <wafer_id>Lot001-1-25</wafer_id>
        '      </wafer_id_list>
        '   </product_id_list>
        '</message>

        'EQP->HOST(H2E_CMD_EXE _R)			
        'Tag Name	Description	Comment	M/Opt
        'msg_id	Message ID	E2H_QRY_LOT_INFO_R	
        'tid	TID	Transaction ID  ex:111	
        'datetime	DateTime	2015/3/31 20:13	
        'eqp_id	EQP ID	AAF10	
        'ack_code	Ack_code	0:OK, Others:NG	"0:OK
        '1:Command error
        '2.Port No error
        '3.Recipe not found
        '4.Lot data error
        '5.Wafer Count error 
        '6.Other error "
        'ack_descr	Ack_description		
        '<?xml version=”1.0” encoding=”UTF-8”?>			
        '<message>			
        '  <msg_id> H2E_CMD_EXE_R</msg_id>			
        '  <tid>111</tid>			
        '  <datetime>2015/03/31 20:13:05</datetime>			
        '  <eqp_id>AAF10</eqp_id>			
        '  <ack_code>0</ack_code>			
        '  <ack_descr></ack_descr>			
        '</message>			

        Public Sub H2E_CMD_EXE_R(ByVal EQPID As String, ByVal ack_code As ACK_CODE, Optional ByVal ACK_Descr As String = "")
            Dim doc As New XmlDocument()
            Dim dec As XmlDeclaration
            Dim docRoot As XmlElement
            Dim node As XmlElement
            '<?xml version=”1.0” encoding=”UTF-8”?>			
            '<message>			
            '  <msg_id> H2E_CMD_EXE_R</msg_id>			
            '  <tid>111</tid>			
            '  <datetime>2015/03/31 20:13:05</datetime>			
            '  <eqp_id>AAF10</eqp_id>			
            '  <ack_code>0</ack_code>			
            '  <ack_descr></ack_descr>			
            '</message>			

            dec = doc.CreateXmlDeclaration("1.0", "UTF-8", "")
            doc.AppendChild(dec)
            docRoot = doc.CreateElement("message")
            doc.AppendChild(docRoot)

            node = doc.CreateElement("msg_id")
            node.InnerText = "H2E_CMD_EXE_R"
            docRoot.AppendChild(node)

            node = doc.CreateElement("tid")
            node.InnerText = Reply_TID.ToString("0")
            docRoot.AppendChild(node)

            node = doc.CreateElement("datetime")
            node.InnerText = Now.ToString("yyyy/MM/dd HH:mm:ss")
            docRoot.AppendChild(node)

            node = doc.CreateElement("eqp_id")
            node.InnerText = EQPID
            docRoot.AppendChild(node)

            node = doc.CreateElement("ack_code")
            Select Case ack_code
                Case CSanAnTCPProcotol.ACK_CODE.OK
                    node.InnerText = "0"
                Case CSanAnTCPProcotol.ACK_CODE.NG
                    node.InnerText = "1"
                Case Else
                    node.InnerText = "1"
            End Select
            docRoot.AppendChild(node)

            node = doc.CreateElement("ack_descr")
            node.InnerText = ACK_Descr
            docRoot.AppendChild(node)

            Dim stringWriter As New IO.StringWriter
            Dim settings As XmlWriterSettings = New XmlWriterSettings()
            settings.Indent = True
            Dim XmlTextWriter = XmlWriter.Create(stringWriter, settings)
            doc.WriteTo(XmlTextWriter)
            XmlTextWriter.Flush()
            Dim cmd As String = stringWriter.GetStringBuilder().ToString
            Send(cmd)
        End Sub
        Public Sub H2E_CMD_EXE_R_OK(ByVal EQPID As String, Optional ByVal ACK_Descr As String = "")
            H2E_CMD_EXE_R(EQPID, ACK_CODE.OK, ACK_Descr)
        End Sub
        Public Sub H2E_CMD_EXE_R_NG(ByVal EQPID As String, Optional ByVal ACK_Descr As String = "")
            H2E_CMD_EXE_R(EQPID, ACK_CODE.NG, ACK_Descr)
        End Sub


        '1.3       Event Report
        '    HOST->EQP(E2H_RPT_EVT_R)			
        'Tag Name	Description	Comment	M/Opt
        'msg_id	Message ID	E2H_RPT_EVT_R	
        'tid	TID	Transaction ID  ex:111	
        'datetime	DateTime	2015/3/31 20:13	
        'eqp_id	EQP ID	AAF10	
        Enum REPORT_EVENT
            IDInputComplete = 0
            ProcessStart = 1
            ProcessEnd = 2
            StepStart = 3
            StepEnd = 4
        End Enum
        Public Sub E2H_RPT_EVT(ByVal EQPID As String, ByVal RPV_Event As REPORT_EVENT, Optional ByVal dscr As String = "")
            Dim doc As New XmlDocument()
            Dim dec As XmlDeclaration
            Dim docRoot As XmlElement
            Dim node As XmlElement
            '<?xml version=”1.0” encoding=”UTF-8”?>			
            '<message>			
            '  <msg_id>E2H_RPT_EVT</msg_id>			
            '  <tid>111</tid>			
            '  <datetime>2015/03/31 20:13:05</datetime>			
            '  <eqp_id>AAF10</eqp_id>			
            '  <event_id>StepStart</event_id>			
            '  <descr></descr>			
            '</message>			


            dec = doc.CreateXmlDeclaration("1.0", "UTF-8", "")
            doc.AppendChild(dec)
            docRoot = doc.CreateElement("message")
            doc.AppendChild(docRoot)

            node = doc.CreateElement("msg_id")
            node.InnerText = "E2H_RPT_EVT"
            docRoot.AppendChild(node)

            node = doc.CreateElement("tid")
            node.InnerText = Send_TID.ToString("0")
            docRoot.AppendChild(node)

            node = doc.CreateElement("datetime")
            node.InnerText = Now.ToString("yyyy/MM/dd HH:mm:ss")
            docRoot.AppendChild(node)

            node = doc.CreateElement("eqp_id")
            node.InnerText = EQPID
            docRoot.AppendChild(node)

            node = doc.CreateElement("event_id")
            Select Case RPV_Event
                Case REPORT_EVENT.IDInputComplete
                    node.InnerText = "IDInputComplete"
                Case REPORT_EVENT.ProcessStart
                    node.InnerText = "ProcessStart"
                Case REPORT_EVENT.ProcessEnd
                    node.InnerText = "ProcessEnd"
                Case REPORT_EVENT.StepStart
                    node.InnerText = "StepStart"
                Case REPORT_EVENT.StepEnd
                    node.InnerText = "StepEnd"
                Case Else
                    node.InnerText = "unknow"
            End Select


            docRoot.AppendChild(node)

            node = doc.CreateElement("descr")
            node.InnerText = dscr
            docRoot.AppendChild(node)

            Dim stringWriter As New IO.StringWriter
            Dim settings As XmlWriterSettings = New XmlWriterSettings()
            settings.Indent = True
            Dim XmlTextWriter = XmlWriter.Create(stringWriter, settings)
            doc.WriteTo(XmlTextWriter)
            XmlTextWriter.Flush()
            Dim cmd As String = stringWriter.GetStringBuilder().ToString
            Send(cmd)
            Process_Send_TID()
        End Sub
        Public Sub Process_Send_TID()
            Send_TID += 1
            If Send_TID > 999 Then Send_TID = 0
        End Sub
        Public Sub E2H_RPT_EVT_IDInputComplete(ByVal EQPID As String, ByVal dscr As String)
            E2H_RPT_EVT(EQPID, REPORT_EVENT.IDInputComplete, dscr)
        End Sub
        Public Sub E2H_RPT_EVT_ProcessStart(ByVal EQPID As String, ByVal dscr As String)
            E2H_RPT_EVT(EQPID, REPORT_EVENT.ProcessStart, dscr)
        End Sub
        Public Sub E2H_RPT_EVT_ProcessEnd(ByVal EQPID As String, ByVal dscr As String)
            E2H_RPT_EVT(EQPID, REPORT_EVENT.ProcessEnd, dscr)
        End Sub
        Public Sub E2H_RPT_EVT_StepStart(ByVal EQPID As String, ByVal dscr As String)
            E2H_RPT_EVT(EQPID, REPORT_EVENT.StepStart, dscr)
        End Sub
        Public Sub E2H_RPT_EVT_StepEnd(ByVal EQPID As String, ByVal dscr As String)
            E2H_RPT_EVT(EQPID, REPORT_EVENT.StepEnd, dscr)
        End Sub
        '1.4       Alarm Report
        '    EQP->HOST(E2H_RPT_ALM)			
        'Tag Name	Description	Comment	M/Opt
        'msg_id	Message ID	E2H_RPT_ALM	
        'tid	TID	111	
        'datetime	DateTime	2015/3/31 20:13	
        'eqp_id	Eqp ID	AAF10	
        'alm_type	Alarm Type	Alarm/Warning	
        'act_type	Action Type	Occure/Clear	
        'alm_code	Alarm Code		
        'alm_msg	Alarm Message
        Enum RPT_ALM_Type
            Alarm = 0
            Warning = 1
        End Enum
        Enum RPT_ALM_Action
            Occure = 0
            Clear = 1
        End Enum
        Public Sub E2H_RPT_ALM(ByVal EQPID As String, ByVal Alm_Code As Integer, ByVal Alm_Msg As String, ByVal Alm_Type As RPT_ALM_Type, ByVal Alm_Action As RPT_ALM_Action)
            Dim doc As New XmlDocument()
            Dim dec As XmlDeclaration
            Dim docRoot As XmlElement
            Dim node As XmlElement
            '<?xml version=”1.0” encoding=”UTF-8”?>			
            '<message>			
            '  <msg_id>E2H_RPT_ALM</msg_id>			
            '  <tid>111</tid>			
            '  <datetime>2015/03/31 20:13:05</datetime>			
            '  <eqp_id>AAF10</eqp_id>			
            '  <alm_type>Alarm</alm_type>			
            '  <act_type>Occur</act_type>			
            '  <alm_code>511000000</alm_code>			
            '  <alm_msg>The Light Tower Audible Alarm has been activated;</alm_msg>			
            '</message>			

            dec = doc.CreateXmlDeclaration("1.0", "UTF-8", "")
            doc.AppendChild(dec)
            docRoot = doc.CreateElement("message")
            doc.AppendChild(docRoot)

            node = doc.CreateElement("msg_id")
            node.InnerText = "E2H_RPT_ALM"
            docRoot.AppendChild(node)

            node = doc.CreateElement("tid")
            node.InnerText = Send_TID.ToString("0")
            docRoot.AppendChild(node)

            node = doc.CreateElement("datetime")
            node.InnerText = Now.ToString("yyyy/MM/dd HH:mm:ss")
            docRoot.AppendChild(node)

            node = doc.CreateElement("eqp_id")
            node.InnerText = EQPID
            docRoot.AppendChild(node)

            node = doc.CreateElement("alm_type")

            Select Case Alm_Type
                Case RPT_ALM_Type.Alarm
                    node.InnerText = "Alarm" 'Alarm/Warning
                Case RPT_ALM_Type.Warning
                    node.InnerText = "Warning" 'Alarm/Warning
                Case Else
                    node.InnerText = "unknow"
            End Select
            docRoot.AppendChild(node)

            node = doc.CreateElement("act_type")
            Select Case Alm_Action
                Case RPT_ALM_Type.Alarm
                    node.InnerText = "Occure"
                Case RPT_ALM_Type.Warning
                    node.InnerText = "Clear"
                Case Else
                    node.InnerText = "unknow"
            End Select
            docRoot.AppendChild(node)

            node = doc.CreateElement("alm_code")
            node.InnerText = Alm_Code.ToString("000")
            docRoot.AppendChild(node)

            node = doc.CreateElement("alm_msg")
            node.InnerText = Alm_Msg
            docRoot.AppendChild(node)

            Dim stringWriter As New IO.StringWriter
            Dim settings As XmlWriterSettings = New XmlWriterSettings()
            settings.Indent = True
            Dim XmlTextWriter = XmlWriter.Create(stringWriter, settings)
            doc.WriteTo(XmlTextWriter)
            XmlTextWriter.Flush()
            Dim cmd As String = stringWriter.GetStringBuilder().ToString
            Send(cmd)
            Process_Send_TID()
        End Sub

        Public Sub E2H_RPT_ALM_AlarmOccure(ByVal EQPID As String, ByVal Alm_Code As Integer, ByVal Alm_Msg As String)
            E2H_RPT_ALM(EQPID, Alm_Code, Alm_Msg, RPT_ALM_Type.Alarm, RPT_ALM_Action.Occure)
        End Sub
        Public Sub E2H_RPT_ALM_AlarmClear(ByVal EQPID As String, ByVal Alm_Code As Integer, ByVal Alm_Msg As String)
            E2H_RPT_ALM(EQPID, Alm_Code, Alm_Msg, RPT_ALM_Type.Alarm, RPT_ALM_Action.Clear)
        End Sub
        Public Sub E2H_RPT_ALM_WarningOccure(ByVal EQPID As String, ByVal Alm_Code As Integer, ByVal Alm_Msg As String)
            E2H_RPT_ALM(EQPID, Alm_Code, Alm_Msg, RPT_ALM_Type.Warning, RPT_ALM_Action.Occure)
        End Sub
        Public Sub E2H_RPT_ALM_WarningClear(ByVal EQPID As String, ByVal Alm_Code As Integer, ByVal Alm_Msg As String)
            E2H_RPT_ALM(EQPID, Alm_Code, Alm_Msg, RPT_ALM_Type.Warning, RPT_ALM_Action.Clear)
        End Sub

        '1.5       Parameter Data Request
        'HOST->EQP(H2E_REQ_PARAM_DATA)		
        'Tag Name	Description	Comment
        'msg_id	Message ID	H2E_REQ_PARAM_DATA
        'tid	TID	Transaction ID  ex:111
        'datetime	DateTime	2015/3/31 20:13
        'eqp_id	Eqp ID	AAF10
        'param_name_list		
        'param_name		
        '<?xml version=”1.0” encoding=”UTF-8”?>		
        '<message>		
        '  <msg_id>H2E_REQ_PARAM_DATA</msg_id>		
        '  <tid>111</tid>		
        '  <datetime>2015/03/31 20:13:05</datetime>		
        '  <eqp_id>AAF10</eqp_id>		
        '<param_name_list>		
        '  <param_name>CurrentInputId</ param_name>		
        '  <param_name>Flow</ param_name>		
        '  <param_name>Pressure</ param_name>		
        '</ param _list>		
        '</message>
        Public Sub H2E_REQ_PARAM_DATA(ByVal EQPID As String, ByVal ack_code As ACK_CODE, Optional ByVal ACK_Descr As String = "")
            Dim doc As New XmlDocument()
            Dim dec As XmlDeclaration
            Dim docRoot As XmlElement
            Dim node As XmlElement
            '<?xml version=”1.0” encoding=”UTF-8”?>		
            '<message>		
            '  <msg_id>H2E_REQ_PARAM_DATA</msg_id>		
            '  <tid>111</tid>		
            '  <datetime>2015/03/31 20:13:05</datetime>		
            '  <eqp_id>AAF10</eqp_id>		
            '<param_name_list>		
            '  <param_name>CurrentInputId</ param_name>		
            '  <param_name>Flow</ param_name>		
            '  <param_name>Pressure</ param_name>		
            '</ param _list>		
            '</message>		

            dec = doc.CreateXmlDeclaration("1.0", "UTF-8", "")
            doc.AppendChild(dec)
            docRoot = doc.CreateElement("message")
            doc.AppendChild(docRoot)

            node = doc.CreateElement("msg_id")
            node.InnerText = "H2E_REQ_PARAM_DATA"
            docRoot.AppendChild(node)

            node = doc.CreateElement("tid")
            node.InnerText = Send_TID.ToString("0")
            docRoot.AppendChild(node)

            node = doc.CreateElement("datetime")
            node.InnerText = Now.ToString("yyyy/MM/dd HH:mm:ss")
            docRoot.AppendChild(node)

            node = doc.CreateElement("eqp_id")
            node.InnerText = EQPID
            docRoot.AppendChild(node)

            node = doc.CreateElement("ack_code")
            Select Case ack_code
                Case CSanAnTCPProcotol.ACK_CODE.OK
                    node.InnerText = "0"
                Case CSanAnTCPProcotol.ACK_CODE.NG
                    node.InnerText = "1"
                Case Else
                    node.InnerText = "1"
            End Select
            docRoot.AppendChild(node)

            node = doc.CreateElement("ack_descr")
            node.InnerText = ACK_Descr
            docRoot.AppendChild(node)

            Dim stringWriter As New IO.StringWriter
            Dim settings As XmlWriterSettings = New XmlWriterSettings()
            settings.Indent = True
            Dim XmlTextWriter = XmlWriter.Create(stringWriter, settings)
            doc.WriteTo(XmlTextWriter)
            XmlTextWriter.Flush()
            Dim cmd As String = stringWriter.GetStringBuilder().ToString
            Send(cmd)
        End Sub
        'EQP->HOST(H2E_REQ_PARAM_DATA_R)			
        'Tag Name	Description	Comment	M/Opt
        'msg_id	Message ID	H2E_REQ_PARAM_DATA_R	
        'tid	TID	Transaction ID  ex:111	
        'datetime	DateTime	2015/3/31 20:13	
        'eqp_id	EQP ID	AAF10	
        'ack_code	Ack_code	0:OK, Others:NG	
        'ack_descr	Ack_description		
        'param_list			
        'param_list\ param			
        'param_list\ param\name			
        'param_list\ param\value			
        '<?xml version=”1.0” encoding=”UTF-8”?>			
        '<message>			
        '  <msg_id>H2E_REQ_PARAM_R</msg_id>			
        '  <tid>111</tid>			
        '  <datetime>2015/03/31 20:13:05</datetime>			
        '  <eqp_id>AAF10</eqp_id>			
        '  <ack_code>0</ack_code>			
        '  <ack_descr></ack_descr>			
        '  <param_list>			
        '<param>			
        '  <name>CurrentLot</name>			
        '  <value>AAF10153266F</value>			
        '</param>			
        '<param>			
        '  <name>Flow</name>			
        '  <value>0.00096</value>			
        '</param>			
        '<param>			
        '  <name>Pressure</name>			
        '  <value>0.00096</value>			
        '</param>			
        '  </param_list>			
        '</message>			

        Public Function H2E_REQ_PARAM_R(ByVal EQPID As String) As String
            Dim strReturnValue As String = ""
            Dim i As Integer = 0
            '<?xml version=”1.0” encoding=”UTF-8”?>
            '<message>
            '  <msg_id>H2E_REQ_PARAM_R</msg_id>
            '  <tid>111</tid>
            '  <datetime>2015/03/31 20:13:05</datetime>
            '  <eqp_id>AAF10</eqp_id>
            '  <ack_code>0</ack_code>
            '  <ack_descr></ack_descr>
            '  <param_list>
            '<param>
            '  <name>CurrentLot</name>
            '  <value>AAF10153266F</value>
            '</param>
            '<param>
            '  <name>Flow</name>
            '  <value>0.00096</value>
            '</param>
            '<param>
            '  <name>Pressure</name>
            '  <value>0.00096</value>
            '</param>
            '  </param_list>
            '</message>


            strReturnValue = "<?xml version=""1.0"" encoding=""UTF-8""?>"
            strReturnValue += "<message>"
            strReturnValue += CombineXMLValue("msg_id", "H2E_REQ_PARAM_R")
            strReturnValue += CombineXMLValue("tid", Reply_TID.ToString("0"))
            strReturnValue += CombineXMLValue("datetime", Format(Now, "yyyy/MM/dd HH:mm:ss"))
            strReturnValue += CombineXMLValue("eqp_id", EQPID)
            strReturnValue += CombineXMLValue("ack_code", "0") ' 0=OK,others: NG 
            strReturnValue += CombineXMLValue("ack_descr", "") ' Ack_description
            'Parameters List
            strReturnValue += "<param_list>"

            'Parameter 1
            strReturnValue += "<param>"
            strReturnValue += CombineXMLValue("name", "CurrentLot")
            Dim lotid As String = ""
            If RemoteCIM.RecipeData.ProductCount > 0 Then
                lotid = RemoteCIM.RecipeData.ProductID(0).LotID
                If RemoteCIM.RecipeData.ProductCount > 1 Then
                    For i = 1 To RemoteCIM.RecipeData.ProductCount - 1
                        lotid = lotid & "," & RemoteCIM.RecipeData.ProductID(i).LotID
                    Next
                End If
            End If
            strReturnValue += CombineXMLValue("value", lotid)
            strReturnValue += "</param>"

            'Data Vacuum
            strReturnValue += "<param>"
            strReturnValue += CombineXMLValue("name", "Vacuum")
            strReturnValue += CombineXMLValue("value", GaugeCHVacStr)
            strReturnValue += "</param>"

            'Data PumpCurrent
            strReturnValue += "<param>"
            strReturnValue += CombineXMLValue("name", "PumpCurrent")
            strReturnValue += CombineXMLValue("value", MPCurrentStr)
            strReturnValue += "</param>"

            For i = 0 To 2
                'Site 1,2,3 Top Temp
                strReturnValue += "<param>"
                strReturnValue += CombineXMLValue("name", "Site#" & (i + 1).ToString & "_TopTemp")
                strReturnValue += CombineXMLValue("value", TopTempPVStr(i))
                strReturnValue += "</param>"

                'Site 1,2,3 Bot Temp
                strReturnValue += "<param>"
                strReturnValue += CombineXMLValue("name", "Site#" & (i + 1).ToString & "_BotTemp")
                strReturnValue += CombineXMLValue("value", BotTempPVStr(i))
                strReturnValue += "</param>"

                'Site 1,2,3 Force Pressure
                strReturnValue += "<param>"
                strReturnValue += CombineXMLValue("name", "Site#" & (i + 1).ToString & "_Pressure")
                strReturnValue += CombineXMLValue("value", PressPVstr(i))
                strReturnValue += "</param>"

                'Site 1,2,3 Top Current
                strReturnValue += "<param>"
                strReturnValue += CombineXMLValue("name", "Site#" & (i + 1).ToString & "_TopCurrent")
                strReturnValue += CombineXMLValue("value", TopCurrentStr(i))
                strReturnValue += "</param>"

                'Site 1,2,3 Bot Current
                strReturnValue += "<param>"
                strReturnValue += CombineXMLValue("name", "Site#" & (i + 1).ToString & "_BotCurrent")
                strReturnValue += CombineXMLValue("value", BotCurrentStr(i))
                strReturnValue += "</param>"

                'Site 1,2,3 Top Water
                strReturnValue += "<param>"
                strReturnValue += CombineXMLValue("name", "Site#" & (i + 1).ToString & "_TopWater")
                strReturnValue += CombineXMLValue("value", FlowRead(i).GetTopFLowStr)
                strReturnValue += "</param>"

                'Site 1,2,3 Bot Water
                strReturnValue += "<param>"
                strReturnValue += CombineXMLValue("name", "Site#" & (i + 1).ToString & "_BotWater")
                strReturnValue += CombineXMLValue("value", FlowRead(i).GetBotFLowStr)
                strReturnValue += "</param>"
            Next
            'End Data
            strReturnValue += "</param_list>"
            strReturnValue += "</message>"


            'Data(datamax) = "Vacuum"
            'datamax += 1
            'Data(datamax) = "MPCurrent"
            'For i = 0 To MAXPLATE
            '    datamax += 1
            '    Data(datamax) = "Site#" + Format(i + 1, "00") + " Step"
            '    datamax += 1
            '    Data(datamax) = "TopTemp" + Format(i + 1, "00")
            '    datamax += 1
            '    Data(datamax) = "BotTemp" + Format(i + 1, "00")
            '    datamax += 1
            '    Data(datamax) = "Pressure" + Format(i + 1, "00")
            '    datamax += 1
            '    Data(datamax) = "TopCurrent" + Format(i + 1, "00")
            '    datamax += 1
            '    Data(datamax) = "BotCurrent" + Format(i + 1, "00")
            '    datamax += 1
            '    Data(datamax) = "TopWater" + Format(i + 1, "00")
            '    datamax += 1
            '    Data(datamax) = "BotWater" + Format(i + 1, "00")
            'Next
            'Data(datamax) = GaugeCHVacStr
            'datamax += 1
            'Data(datamax) = MPCurrentStr

            'For i = 0 To MAXPLATE
            '    datamax += 1
            '    Data(datamax) = CSubAutoProcess(i).RunIndex.ToString
            '    datamax += 1
            '    Data(datamax) = TopTempPVStr(i)
            '    datamax += 1
            '    Data(datamax) = BotTempPVStr(i)
            '    datamax += 1
            '    Data(datamax) = PressPVstr(i)
            '    datamax += 1
            '    Data(datamax) = TopCurrentStr(i)
            '    datamax += 1
            '    Data(datamax) = BotCurrentStr(i)
            '    datamax += 1
            '    Data(datamax) = FlowRead(i).GetTopFLowStr
            '    datamax += 1
            '    Data(datamax) = FlowRead(i).GetBotFLowStr

            'Next
            Dim cmd As String = FormatXml(strReturnValue)
            Send(cmd)
            Return cmd

        End Function

        '1.6       REMOTE/LOCAL_STATE
        'Tag Name	Description		Comment		M/Opt
        'msg_id	Message ID		E2H_CHK_ALIVE		
        'tid	TID		Transaction ID  ex:111		
        'datetime	DateTime		2015/3/31 20:13		
        'eqp_id	Eqp ID		AAF10		
        'RSOL	STATE		STATE		
        Public Enum RSOL_STATE
            REMOTE = 0
            LOCAL = 1
        End Enum
        Public Sub E2H_CHK_RSOL(ByVal EQPID As String, ByVal state As RSOL_STATE)
            Dim doc As New XmlDocument()
            Dim dec As XmlDeclaration
            Dim docRoot As XmlElement
            Dim node As XmlElement
            '<?xml version=”1.0” encoding=”UTF-8”?>					
            '<message>					
            '  <msg_id>E2H_CHK_RSOL</msg_id>					
            '  <tid>111</tid>					
            '  <datetime>2015/03/31 20:13:05</datetime>					
            '  <eqp_id>AAF10</eqp_id>					
            '  <RSOL>REMOTE</RSOL>					
            '</message>					


            dec = doc.CreateXmlDeclaration("1.0", "UTF-8", "")
            doc.AppendChild(dec)
            docRoot = doc.CreateElement("message")
            doc.AppendChild(docRoot)

            node = doc.CreateElement("msg_id")
            node.InnerText = "E2H_CHK_RSOL"
            docRoot.AppendChild(node)

            node = doc.CreateElement("tid")
            node.InnerText = Send_TID.ToString("0")
            docRoot.AppendChild(node)

            node = doc.CreateElement("datetime")
            node.InnerText = Now.ToString("yyyy/MM/dd HH:mm:ss")
            docRoot.AppendChild(node)

            node = doc.CreateElement("eqp_id")
            node.InnerText = EQPID
            docRoot.AppendChild(node)

            node = doc.CreateElement("RSOL")
            Select Case state
                Case RSOL_STATE.LOCAL
                    node.InnerText = "LOCAL" '
                Case RSOL_STATE.REMOTE
                    node.InnerText = "REMOTE"
                Case Else
                    node.InnerText = "unknow"
            End Select
            docRoot.AppendChild(node)

            Dim stringWriter As New IO.StringWriter
            Dim settings As XmlWriterSettings = New XmlWriterSettings()
            settings.Indent = True
            Dim XmlTextWriter = XmlWriter.Create(stringWriter, settings)
            doc.WriteTo(XmlTextWriter)
            XmlTextWriter.Flush()
            Dim cmd As String = stringWriter.GetStringBuilder().ToString
            Send(cmd)
            Process_Send_TID()
        End Sub
        Public Sub E2H_CHK_RSOL_LOCAL(ByVal EQPID As String)
            E2H_CHK_RSOL(EQPID, RSOL_STATE.LOCAL)
        End Sub
        Public Sub E2H_CHK_RSOL_REMOTE(ByVal EQPID As String)
            E2H_CHK_RSOL(EQPID, RSOL_STATE.REMOTE)
        End Sub

        'HOST->EQP(E2H_CHK_RSOL_R)			
        'Tag Name	Description	Comment	M/Opt
        'msg_id	Message ID	E2H_CHK_ALIVE_R	
        'tid	TID	Transaction ID  ex:111	
        'datetime	DateTime	2015/3/31 20:13	
        'eqp_id	EQP ID	AAF10	
        'ack_code	Ack_code	0:OK, Others:NG	
        'ack_descr	Ack_description		
        '<?xml version=”1.0” encoding=”UTF-8”?>			
        '<message>			
        '  <msg_id>E2H_CHK_RSOL_R</msg_id>			
        '  <tid>111</tid>			
        '  <datetime>2015/03/31 20:13:05</datetime>			
        '  <eqp_id>AAF10</eqp_id>			
        '  <ack_code>0</ack_code>			
        '  <ack_descr></ack_descr>			
        '</message>			

        Enum ACK_CODE
            OK = 0
            NG = 1
        End Enum
        Public Sub E2H_CHK_RSOL_R(ByVal EQPID As String, ByVal ack_code As ACK_CODE, Optional ByVal ACK_Descr As String = "")
            Dim doc As New XmlDocument()
            Dim dec As XmlDeclaration
            Dim docRoot As XmlElement
            Dim node As XmlElement
            '<?xml version=”1.0” encoding=”UTF-8”?>			
            '<message>			
            '  <msg_id>E2H_CHK_RSOL_R</msg_id>			
            '  <tid>111</tid>			
            '  <datetime>2015/03/31 20:13:05</datetime>			
            '  <eqp_id>AAF10</eqp_id>			
            '  <ack_code>0</ack_code>			
            '  <ack_descr></ack_descr>			
            '</message>		


            dec = doc.CreateXmlDeclaration("1.0", "UTF-8", "")
            doc.AppendChild(dec)
            docRoot = doc.CreateElement("message")
            doc.AppendChild(docRoot)

            node = doc.CreateElement("msg_id")
            node.InnerText = "E2H_CHK_RSOL_R"
            docRoot.AppendChild(node)

            node = doc.CreateElement("tid")
            node.InnerText = Reply_TID.ToString("0")
            docRoot.AppendChild(node)

            node = doc.CreateElement("datetime")
            node.InnerText = Now.ToString("yyyy/MM/dd HH:mm:ss")
            docRoot.AppendChild(node)

            node = doc.CreateElement("eqp_id")
            node.InnerText = EQPID
            docRoot.AppendChild(node)

            node = doc.CreateElement("ack_code")
            Select Case ack_code
                Case CSanAnTCPProcotol.ACK_CODE.OK
                    node.InnerText = "0"
                Case CSanAnTCPProcotol.ACK_CODE.NG
                    node.InnerText = "1"
                Case Else
                    node.InnerText = "1"
            End Select
            docRoot.AppendChild(node)

            node = doc.CreateElement("ack_descr")
            node.InnerText = ACK_Descr
            docRoot.AppendChild(node)

            Dim stringWriter As New IO.StringWriter
            Dim settings As XmlWriterSettings = New XmlWriterSettings()
            settings.Indent = True
            Dim XmlTextWriter = XmlWriter.Create(stringWriter, settings)
            doc.WriteTo(XmlTextWriter)
            XmlTextWriter.Flush()
            Dim cmd As String = stringWriter.GetStringBuilder().ToString
            Send(cmd)
        End Sub

        Public Sub H2E_MSG_DPY_R(ByVal EQPID As String, ByVal ack_code As ACK_CODE, Optional ByVal ACK_Descr As String = "")
            Dim doc As New XmlDocument()
            Dim dec As XmlDeclaration
            Dim docRoot As XmlElement
            Dim node As XmlElement
            '<?xml version=”1.0” encoding=”UTF-8”?>
            '<message>
            '  <msg_id>H2E_MSG_DPY_R</msg_id>
            '  <tid>111</tid>
            '  <datetime>2015/03/31 20:13:05</datetime>
            '  <eqp_id>AAF10</eqp_id>
            '  <ack_code>0</ack_code>
            '  <ack_descr></ack_descr>
            '</message>
            dec = doc.CreateXmlDeclaration("1.0", "UTF-8", "")
            doc.AppendChild(dec)
            docRoot = doc.CreateElement("message")
            doc.AppendChild(docRoot)

            node = doc.CreateElement("msg_id")
            node.InnerText = "H2E_MSG_DPY_R"
            docRoot.AppendChild(node)

            node = doc.CreateElement("tid")
            node.InnerText = Reply_TID.ToString("0")
            docRoot.AppendChild(node)

            node = doc.CreateElement("datetime")
            node.InnerText = Now.ToString("yyyy/MM/dd HH:mm:ss")
            docRoot.AppendChild(node)

            node = doc.CreateElement("eqp_id")
            node.InnerText = EQPID
            docRoot.AppendChild(node)

            node = doc.CreateElement("ack_code")
            Select Case ack_code
                Case CSanAnTCPProcotol.ACK_CODE.OK
                    node.InnerText = "0"
                Case CSanAnTCPProcotol.ACK_CODE.NG
                    node.InnerText = "1"
                Case Else
                    node.InnerText = "1"
            End Select
            docRoot.AppendChild(node)

            node = doc.CreateElement("ack_descr")
            node.InnerText = ACK_Descr
            docRoot.AppendChild(node)

            Dim stringWriter As New IO.StringWriter
            Dim settings As XmlWriterSettings = New XmlWriterSettings()
            settings.Indent = True
            Dim XmlTextWriter = XmlWriter.Create(stringWriter, settings)
            doc.WriteTo(XmlTextWriter)
            XmlTextWriter.Flush()
            Dim cmd As String = stringWriter.GetStringBuilder().ToString
            Send(cmd)
        End Sub


        Public Sub E2H_CHK_RSOL_R_OK(ByVal EQPID As String, Optional ByVal ACK_Descr As String = "")
            E2H_CHK_RSOL_R(EQPID, ACK_CODE.OK, ACK_Descr)
        End Sub
        Public Sub E2H_CHK_RSOL_R_NG(ByVal EQPID As String, Optional ByVal ACK_Descr As String = "")
            E2H_CHK_RSOL_R(EQPID, ACK_CODE.NG, ACK_Descr)
        End Sub





        Public Function CombineAlarmXml() As String
            Dim strReturnValue As String
            '<?xml version="1.0" encoding="UTF-8"?>
            '<request>
            '	<identity>
            '		<computername>EQP-PC</computername>
            '		<curuserno>TCS</curuserno>
            '		<sendtime>2018/7/2 17:02:30</sendtime>
            '	</identity>
            '	<parameter>
            '	   <timestamp>
            '		<name>TimeStamp</name>
            '		<type>String</type>
            '		<value>2018-07-02 17:02:30</value>
            '	   </timestamp>
            '	   <eqp_id>
            '		<name>eqp_id</name>
            '		<type>String</type>
            '		<value>C1EQP001</value>
            '	   </eqp_id>
            '	   <alarm_id>
            '		<name>alarm_id</name>
            '		<type>String</type>
            '		<value>001</value>
            '	   </alarm_id>
            '	   <msg>
            '		<name>msg</name>
            '		<type>String</type>
            '	   	<value>EQ error</value>
            '	   </msg>
            '	</parameter>
            '</request>
            strReturnValue = "<?xml version=""1.0"" encoding=""UTF-8""?>"
            strReturnValue += "<request>"

            strReturnValue += "<identity>"
            strReturnValue += CombineXMLValue("computername", Environment.MachineName)
            strReturnValue += CombineXMLValue("curuserno", "TCS")
            strReturnValue += CombineXMLValue("sendtime", Format(Now, "yyyy/MM/dd HH:mm:ss"))
            strReturnValue += "</identity>"

            strReturnValue += "<parameter>"

            strReturnValue += "<timestamp>"
            strReturnValue += CombineXMLValue("name", "TimeStamp")
            strReturnValue += CombineXMLValue("type", "String")
            strReturnValue += CombineXMLValue("value", Format(Now, "yyyy/MM/dd HH:mm:ss"))
            strReturnValue += "</timestamp>"

            strReturnValue += "<eqp_id>"
            strReturnValue += CombineXMLValue("name", MachineID)
            strReturnValue += CombineXMLValue("type", "String")
            strReturnValue += CombineXMLValue("value", "LotInfo.EQP_ID")
            strReturnValue += "</eqp_id>"

            strReturnValue += "<alarm_id>"
            strReturnValue += CombineXMLValue("name", "alarm_id")
            strReturnValue += CombineXMLValue("type", "String")
            strReturnValue += CombineXMLValue("value", "LotInfo.ALARM")
            strReturnValue += "</alarm_id>"

            strReturnValue += "<msg>"
            strReturnValue += CombineXMLValue("name", "msg")
            strReturnValue += CombineXMLValue("type", "String")
            strReturnValue += CombineXMLValue("value", "LotInfo.MSG")
            strReturnValue += "</msg>"

            strReturnValue += "</parameter>"
            strReturnValue += "</request>"

            Return strReturnValue
        End Function
        Public Function CombineXMLValue(ByRef TagName As String, ByRef Value As String) As String
            CombineXMLValue = "<" & TagName & ">" & Value & "</" & TagName & ">"
        End Function
        Public Function FormatXml(ByVal sUnformattedXml As String) As String
            Try
                '//load unformatted xml into a dom
                Dim xd As Xml.XmlDocument = New Xml.XmlDocument
                xd.LoadXml(sUnformattedXml)
                '//will hold formatted xml
                Dim sb As System.Text.StringBuilder = New System.Text.StringBuilder
                '//pumps the formatted xml into the StringBuilder above
                Dim sw As IO.StringWriter = New IO.StringWriter(sb)
                '//does the formatting
                Dim xtw As Xml.XmlTextWriter = Nothing
                '//point the xtw at the StringWriter
                xtw = New Xml.XmlTextWriter(sw)
                '//we want the output formatted
                xtw.Formatting = Xml.Formatting.Indented
                'xtw.Indentation = 4
                'xtw.IndentChar = Chr(13)
                '//get the dom to dump its contents into the xtw 
                xd.WriteTo(xtw)
                xtw.Close()
                '//return the formatted xml
                Return sb.ToString
            Catch ex As Exception
                'MsgBoxLangErr(ex.ToString)
                TCP_Log.AppendLog("---> " & ex.ToString)
                Return ""
            End Try
        End Function


    End Class
    Public Class ConnectionInfo
        Public ServerMode As Boolean = True
        Public _IsConnected As Boolean = False
        Public Initialed As Boolean = False
        Public SendBuffer As String = ""
        Public ReceiveBuffer As String = ""
        Public Event SendMessage(ByVal msg As String)
        Public Event ReceiveMessage(ByVal msg As String)
        Public Event ServerStarted()
        Public Event ServerStopped()
        Public Event ServerError(ByVal Code As Integer)


#Region "Property"
        Public ReadOnly Property IsConnected As Boolean
            Get
                Return _IsConnected
            End Get
        End Property




#End Region

#Region "Server Mode"
        Dim TCP_Log As CEventLog = New CEventLog

        Public StatusString As String = ""
        Dim myObj As New CSState
        Dim ClientSocket As Socket
        Public myTcpListener As TcpListener '建立一個全域變數指標指向TcpListener  (TcpListener：接聽來自TCP 網路用戶端的連接
        Private Class CSState
            Public myTcpListener As TcpListener '將myTcpListener指向TcpListener型別，其值為Nothing
            Public ClientSocket As Socket '將ClientSocket 指向Socket型別，其值為Nothing
            Public mystring As String '將mystring指向為String型別，其值為Nothing
        End Class
        ''' <summary>
        ''' Server Mode Start
        ''' </summary>
        ''' <param name="port"></param>
        ''' <remarks></remarks>
        Public Sub New(ByVal port As Integer, ByVal Mode As Boolean)
            'On Error Resume Next
            Try
                Try
                    TCP_Log.initial("CIM", WorkingDir & "Records\CIM_RawLog\")
                    ServerMode = Mode
                    _IsConnected = False
                    Dim ListenThread As New System.Threading.Thread(AddressOf StartListen)
                    ListenThread.IsBackground = True
                    ListenThread.Start(port)
                    StatusString = "Starting"
                    TCP_Log.AppendLog("---> " & StatusString)
                    RaiseEvent ServerStarted()
                Catch ex As Exception
                    StatusString = "StartError"
                    MsgBoxLangErr(ex.ToString)
                    TCP_Log.AppendLog("---> " & StatusString)
                End Try
                Initialed = True
            Catch ex As Exception
                _IsConnected = False
                MsgBox("Server is not ready.")
                TCP_Log.AppendLog("---> " & StatusString)
            End Try
        End Sub
        Private Sub StartListen(ByVal state As Object) 'ListenThread.Start後進入監聽模式,宣告傳入值state為Object類別
            Dim iPort As Integer
            iPort = CType(state, Integer) '因為傳入值為Object，所以必須轉換成整數型態
            myTcpListener = New TcpListener(IPAddress.Any, iPort)  '為myTcpListener建立一個新的TcpListener物件，傳入值為IPAddress.Any, iPort
            Try
                myTcpListener.Start() '啟動監聽，在自訂的StartListen方法中建立TcpListener的執行個體，然後以TcpListener.Start方法啟動TcpListener，使其進入接聽封包狀態
                Dim iCount As Integer = 0
                'ChangeLB("TCP Listener 已啟動", Color.Blue) '跨執行緒內修改LABEL控制項
                StatusString = "Started"
                Do
                    ClientSocket = myTcpListener.AcceptSocket() 'AcceptSocket 方法是用於傳回Socket與新進連接的用戶端來通訊
                    If ClientSocket.Connected = True Then 'Socket與新進連接的用戶端連結成立
                        Dim myObj As New CSState
                        myObj.myTcpListener = myTcpListener
                        myObj.ClientSocket = ClientSocket
                        myObj.mystring = Now.ToString("yyyy/MM/dd HH:mm:ss") & "已連線"

                        StatusString = myObj.mystring
                        TCP_Log.AppendLog("---> Connected " & vbCrLf & StatusString)
                        _IsConnected = True
                        'DisplayMsg1(myObj) '傳送到表格顯示
                        Dim ReceiveThread As New System.Threading.Thread(AddressOf ReceiveData)
                        ReceiveThread.IsBackground = True '是否在背後執行此ReceiveThread執行緒
                        ReceiveThread.Start(myObj)
                        iCount += 1
                    End If
                Loop
            Catch ex As Exception
                'MessageBox.Show(ex.ToString())
                StatusString = "Disconnect or Server Error"
                TCP_Log.AppendLog("---> " & StatusString)
                _IsConnected = False

                RaiseEvent ServerError(1)
            End Try

        End Sub

        Private Sub ReceiveData(ByVal state As Object) '訊息傳送資訊
            Dim myObj As New CSState
            myObj.ClientSocket = CType(state, CSState).ClientSocket '因為是傳入CSState型態的myObj給state，所以必須將state物件轉換成CSState型態
            myObj.myTcpListener = CType(state, CSState).myTcpListener
            myObj.mystring = ""
            Dim myNetworkStream As New NetworkStream(myObj.ClientSocket)
            Dim InBytesCount As Integer = 0
            Dim myReceiveBytes(4095) As Byte
            Dim i As Integer = 0
            While True '一直監聽訊息
                Try
                    InBytesCount = myNetworkStream.Read(myReceiveBytes, 0, myReceiveBytes.Length) '從NetworkStream 讀取資料放到myReceiveBytes，並且等待訊息
                    System.Threading.Thread.Sleep(100) '在指定的時間內暫止目前的執行緒，單位毫秒'傳回值(給InBytesCount)：從NetworkStream 讀取的位元組數(前面宣告為)
                    If InBytesCount = 0 Then
                        Exit While
                    End If
                    'myObj.mystring = Encoding.GetEncoding(950).GetString(myReceiveBytes).TrimEnd().TrimStart() '將myReceiveBytes轉換成big5繁體中文存到myObj.mystring

                    'myObj.mystring = Encoding.ASCII.GetString(myReceiveBytes).TrimEnd().TrimStart()

                    'myObj.mystring = Encoding.Unicode.GetString(myReceiveBytes).TrimEnd().TrimStart()
                    'myObj.mystring = Encoding.GetEncoding(950).GetString(myReceiveBytes).TrimEnd().TrimStart() '將myReceiveBytes轉換成big5繁體中文存到myObj.mystring
                    myObj.mystring = Encoding.UTF8.GetString(myReceiveBytes).TrimEnd().TrimStart()
                    StatusString = "Received"

                    Dim sstr As String = myObj.mystring.Substring(0, InBytesCount)

                    TCP_Log.AppendLog("---> Receive" & vbCrLf & sstr)
                    RaiseEvent ReceiveMessage(sstr)

                    'DisplayMsg1(myObj)  '傳送到表格顯示
                Catch ex As Exception
                    'MessageBox.Show(ex.ToString) '"所有連線已終止"
                    StatusString = "Disconnect or Server Error"
                    TCP_Log.AppendLog("---> " & StatusString)
                    _IsConnected = False
                    RaiseEvent ServerError(2)
                    'RaiseEvent ReceiveMessage("ServerError")
                    'MsgBoxLangErr(ex.ToString)
                    Exit Sub
                End Try
            End While
        End Sub
#End Region

#Region "Client Mode"
        Private _Client As TcpClient
        Public ReadOnly Property AppendMethod As Action(Of String)
            Get
                Return _AppendMethod
            End Get
        End Property
        Private _AppendMethod As Action(Of String)
        ''' <summary>
        ''' TCP 客戶端物件
        ''' </summary>
        ''' <remarks></remarks>

        Public ReadOnly Property Client As TcpClient
            Get
                Return _Client
            End Get
        End Property
        ''' <summary>
        ''' 網路傳輸物件
        ''' </summary>
        ''' <remarks></remarks>
        Private _Stream As NetworkStream
        Public ReadOnly Property Stream As NetworkStream
            Get
                Return _Stream
            End Get
        End Property
        Private _LastReadLength As Integer
        Public ReadOnly Property LastReadLength As Integer
            Get
                Return _LastReadLength
            End Get
        End Property
        Private _Buffer(4096) As Byte
        ''' <summary>
        ''' Client Mode Start
        ''' </summary>
        ''' <param name="address"></param>
        ''' <param name="port"></param>
        ''' <param name="append"></param>
        ''' <remarks></remarks>
        Public Sub New(ByVal address As IPAddress, ByVal port As Integer, ByVal append As Action(Of String))
            'On Error Resume Next
            Try
                _AppendMethod = append
                _Client = New TcpClient
                'add By libra 20140804 Start
                _Client.NoDelay = True '取消 TCPIP 延遲
                'add By libra 20140804 End
                _Client.Connect(address, port)
                _Stream = _Client.GetStream
                _IsConnected = True
                Initialed = True
            Catch ex As Exception
                _IsConnected = False
                MsgBox("Server is not ready.")
            End Try
        End Sub
        ''' <summary>
        ''' 程式停止並等待接收資料
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub AwaitData()
            If Not IsNothing(_Stream) Then
                _Stream.BeginRead(_Buffer, 0, _Buffer.Length, AddressOf DoReadData, Me)
            End If
        End Sub
        ''' <summary>
        ''' 接收資料之回呼函式
        ''' </summary>
        ''' <param name="result"></param>
        ''' <remarks></remarks>
        Private Sub DoReadData(result As IAsyncResult)
            Dim info As ConnectionInfo = CType(result.AsyncState, ConnectionInfo)
            Try
                If info._Stream IsNot Nothing AndAlso info._Stream.CanRead Then
                    info._LastReadLength = info._Stream.EndRead(result)
                    If info._LastReadLength > 0 Then
                        Dim message As String = System.Text.Encoding.ASCII.GetString(info._Buffer).Substring(0, info._LastReadLength)
                        message = message.Trim(" ")
                        info._AppendMethod(message)
                    End If
                    info.AwaitData()
                End If
            Catch ex As Exception
                info.Stream.Flush()
                info._LastReadLength = -1
                info._AppendMethod(ex.Message)
            End Try
        End Sub

#End Region

#Region "Public Method"
      



        ''' <summary>
        ''' Clinent Mode Close 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub Close()
            If ServerMode Then


            Else
                If _Client IsNot Nothing Then _Client.Close()
                _IsConnected = False
                _Client = Nothing
                _Stream = Nothing
            End If

        End Sub


        Public Function Send(ByVal cmd As String) As Integer
            If _IsConnected Then
                System.Threading.Thread.Sleep(100)
                Try
                    If ServerMode Then
                        If IsConnected Then
                            myObj.ClientSocket = ClientSocket '因為是傳入CSState型態的myObj給state，所以必須將state物件轉換成CSState型態
                            myObj.myTcpListener = myTcpListener
                            myObj.mystring = ""
                            Dim myNetworkStream As New NetworkStream(myObj.ClientSocket)
                            Dim InBytesCount As Integer = 0
                            Dim myReceiveBytes(4095) As Byte
                            Dim sendBytes As [Byte]() = Encoding.ASCII.GetBytes(cmd)
                            myNetworkStream.Write(sendBytes, 0, sendBytes.Length)
                            TCP_Log.AppendLog("---> Send" & vbCrLf & cmd)
                            RaiseEvent SendMessage(cmd)
                        Else
                            TCP_Log.AppendLog("---> Send Error: Not connected.")
                        End If
                    Else
                        Dim buffer() As Byte = System.Text.Encoding.ASCII.GetBytes(cmd)
                        Stream.Write(buffer, 0, buffer.Length)
                        TCP_Log.AppendLog("---> Send " & vbCrLf & cmd)
                    End If
                Catch ex As Exception
                    TCP_Log.AppendLog("---> Send Error: " & vbCrLf & ex.ToString & vbCrLf)
                End Try

            End If
        End Function

#End Region


    End Class

    'Public Class TCPServerMode
    '    Public _IsConnected As Boolean = False
    '    Public Initialed As Boolean = False
    '    Public SendBuffer As String = ""
    '    Public ReceiveBuffer As String = ""
    '    Public StatusString As String = ""
    '    Public myTcpListener As TcpListener '建立一個全域變數指標指向TcpListener  (TcpListener：接聽來自TCP 網路用戶端的連接

    '    Private Class CSState
    '        Public myTcpListener As TcpListener '將myTcpListener指向TcpListener型別，其值為Nothing
    '        Public ClientSocket As Socket '將ClientSocket 指向Socket型別，其值為Nothing
    '        Public mystring As String '將mystring指向為String型別，其值為Nothing
    '    End Class
    '    Sub New()
    '        StatusString = "NewStart"
    '    End Sub
    '    Public Function ServerStart(ByVal Port As Integer) As Boolean
    '        Try
    '            _IsConnected = False
    '            Dim ListenThread As New System.Threading.Thread(AddressOf StartListen)
    '            ListenThread.IsBackground = True
    '            ListenThread.Start(Port)
    '            StatusString = "Starting"
    '            Return True
    '        Catch ex As Exception
    '            StatusString = "StartError"
    '            MsgBoxLangErr(ex.ToString)
    '            Return False
    '        End Try
    '    End Function
    '    Private Sub StartListen(ByVal state As Object) 'ListenThread.Start後進入監聽模式,宣告傳入值state為Object類別
    '        Dim iPort As Integer
    '        iPort = CType(state, Integer) '因為傳入值為Object，所以必須轉換成整數型態
    '        myTcpListener = New TcpListener(IPAddress.Any, iPort)  '為myTcpListener建立一個新的TcpListener物件，傳入值為IPAddress.Any, iPort
    '        Try
    '            Dim ClientSocket As Socket
    '            myTcpListener.Start() '啟動監聽，在自訂的StartListen方法中建立TcpListener的執行個體，然後以TcpListener.Start方法啟動TcpListener，使其進入接聽封包狀態
    '            Dim iCount As Integer = 0
    '            'ChangeLB("TCP Listener 已啟動", Color.Blue) '跨執行緒內修改LABEL控制項
    '            StatusString = "Started"
    '            Do
    '                ClientSocket = myTcpListener.AcceptSocket() 'AcceptSocket 方法是用於傳回Socket與新進連接的用戶端來通訊
    '                If ClientSocket.Connected = True Then 'Socket與新進連接的用戶端連結成立
    '                    Dim myObj As New CSState
    '                    myObj.myTcpListener = myTcpListener
    '                    myObj.ClientSocket = ClientSocket
    '                    myObj.mystring = Now.ToString("yyyy/MM/dd HH:mm:ss") & "已連線"
    '                    StatusString = myObj.mystring
    '                    _IsConnected = True
    '                    'DisplayMsg1(myObj) '傳送到表格顯示
    '                    Dim ReceiveThread As New System.Threading.Thread(AddressOf ReceiveData)
    '                    ReceiveThread.IsBackground = True '是否在背後執行此ReceiveThread執行緒
    '                    ReceiveThread.Start(myObj)
    '                    iCount += 1
    '                End If
    '            Loop
    '        Catch ex As Exception
    '            'MessageBox.Show(ex.ToString())
    '        End Try

    '    End Sub

    '    Private Sub ReceiveData(ByVal state As Object) '訊息傳送資訊
    '        Dim myObj As New CSState
    '        myObj.ClientSocket = CType(state, CSState).ClientSocket '因為是傳入CSState型態的myObj給state，所以必須將state物件轉換成CSState型態
    '        myObj.myTcpListener = CType(state, CSState).myTcpListener
    '        myObj.mystring = ""
    '        Dim myNetworkStream As New NetworkStream(myObj.ClientSocket)
    '        Dim InBytesCount As Integer = 0
    '        Dim myReceiveBytes(1023) As Byte
    '        Dim i As Integer = 0
    '        While True '一直監聽訊息
    '            Try
    '                InBytesCount = myNetworkStream.Read(myReceiveBytes, 0, myReceiveBytes.Length) '從NetworkStream 讀取資料放到myReceiveBytes，並且等待訊息
    '                System.Threading.Thread.Sleep(100) '在指定的時間內暫止目前的執行緒，單位毫秒'傳回值(給InBytesCount)：從NetworkStream 讀取的位元組數(前面宣告為)
    '                If InBytesCount = 0 Then
    '                    Exit While
    '                End If
    '                myObj.mystring = Encoding.GetEncoding(950).GetString(myReceiveBytes).TrimEnd().TrimStart() '將myReceiveBytes轉換成big5繁體中文存到myObj.mystring
    '                'DisplayMsg1(myObj)  '傳送到表格顯示
    '            Catch ex As Exception
    '                'MessageBox.Show(ex.ToString) '"所有連線已終止"
    '                StatusString = "ServerError"
    '                MsgBoxLangErr(ex.ToString)
    '                Exit Sub
    '            End Try
    '        End While
    '    End Sub
    'End Class
    Public Class CEventLog
        Private Initflag As Boolean = False
        Private EventName As String = "Event"
        Private BaseDirPath As String = "C:\"
        Private EeventLogDir As String = ""         '製程事件記錄資料夾
        Private EventLogShortFileName As String = ""
        Private EventLogFileName As String = ""
        Private EventLogCount As Long = 0
        Private LastDateTime As New DateTime
        Private CurrentDateTime As New DateTime

        Sub New()
            EventName = ""
            BaseDirPath = ""
        End Sub

        Sub New(ByVal sName As String, ByVal sBaseDir As String)
            EventName = sName
            SetBaseDir(sBaseDir)
            Initflag = True
        End Sub
        Public Sub initial(ByVal sName As String, ByVal sBaseDir As String)
            If Initflag = False Then
                EventName = sName
                SetBaseDir(sBaseDir)
                Initflag = True
            End If
        End Sub

        Public Sub SetBaseDir(ByVal sBaseDir As String)
            BaseDirPath = sBaseDir
            If IsValidFileNameOrPath(BaseDirPath) Then
                CheckEventLogDirAndCreate()
            Else
                MsgBox("Event Log: " & EventName & " Invlid.")
            End If
        End Sub

        Private Sub CheckEventLogDirAndCreate()
            CurrentDateTime = Now()
            If CurrentDateTime.Date <> LastDateTime.Date Then
                Dim sstr As String
                sstr = BaseDirPath & Now.ToString("yyyy_MM_dd")
                EventLogCount = 0
                ChecDirAndCreate(sstr)
                EeventLogDir = sstr & "\"
                EventLogShortFileName = EventName + "_" + Now.ToString("yyyyMMdd") + "-" + Now.ToString("HHmmss") & ".log"
                EventLogFileName = EeventLogDir + EventLogShortFileName
                LastDateTime = CurrentDateTime
            End If
        End Sub
        Public Sub ChecDirAndCreate(ByVal sstr As String)
            If Not My.Computer.FileSystem.DirectoryExists(sstr) Then
                My.Computer.FileSystem.CreateDirectory(sstr)
            End If
        End Sub

        '如何：在 Visual Basic 中驗證檔案名稱和路徑
        ''' <summary>
        ''' 驗證檔案名稱和路徑
        ''' </summary>
        ''' <param name="name">檔案名稱或和路徑</param>
        ''' <returns>True= 合法路徑，False =不合法路徑.</returns>
        ''' <remarks></remarks>
        Private Function IsValidFileNameOrPath(ByVal name As String) As Boolean
            ' Determines if the name is Nothing.
            If name Is Nothing Then
                Return False
            End If

            ' Determines if there are bad characters in the name.
            For Each badChar As Char In System.IO.Path.GetInvalidPathChars
                If InStr(name, badChar) > 0 Then
                    Return False
                End If
            Next

            ' The name passes basic validation.
            Return True
        End Function
        '寫入多筆資料以"," 隔開, 並在最後端換行,檔案不存在會自動建立
        Private Sub AppendData(ByVal sfile As String, ByVal ParamArray sstr() As Object)
            Dim i As Integer
            On Error Resume Next
            Dim fs As System.IO.FileStream
            Dim sw As System.IO.StreamWriter
            fs = New System.IO.FileStream(sfile, System.IO.FileMode.Append, IO.FileAccess.Write, IO.FileShare.ReadWrite)
            sw = New System.IO.StreamWriter(fs, System.Text.Encoding.Unicode)
            If sstr.Length < 0 Then Exit Sub
            For i = 0 To sstr.Length - 1
                sw.Write(sstr(i))
            Next
            sw.WriteLine()
            sw.Close()
        End Sub

        ''' <summary>
        ''' 事件記錄, 使用者自訂自串
        ''' </summary>
        ''' <param name="stra"></param>
        ''' <remarks></remarks>
        Public Sub AppendLog(ByVal stra As String)
            Dim sstr As String
            If EventLogCount = 0 Then
                sstr = "Log Type" & vbTab & EventName
                AppendData(EventLogFileName, sstr)
                sstr = "No" & vbTab & "Date" & vbTab & "Time" & vbTab & "Log Event"
                AppendData(EventLogFileName, sstr)
            End If
            EventLogCount += 1

            sstr = "." & vbCrLf & Format(EventLogCount, "[0000000]") & vbTab & Now.ToString("yyyy-MM-dd") & vbTab & Now.ToString("HH:mm:ss")
            CheckEventLogDirAndCreate()
            'If stra.Substring(stra.Length - 1) <> "." Then
            '    stra = stra + "."
            'End If
            AppendData(EventLogFileName, sstr & vbTab & stra)
        End Sub

        Public Sub AppendCustomLog(ByVal sstr As String)
            EventLogCount += 1
            CheckEventLogDirAndCreate()
            AppendData(EventLogFileName, sstr)
        End Sub
        Private Function CheckFileExist(ByVal filename As String) As Boolean
            If FileIO.FileSystem.FileExists(filename) Then
                If MsgBox("File Exist, Overwrite?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Return True
                Else
                    Return False
                End If
            End If
        End Function

    End Class

End Module

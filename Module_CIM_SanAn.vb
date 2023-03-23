'Add by Vincent TCPIP 20200716    ------------- Start
Imports System.Text
Imports System.Data

Imports System
Imports System.Xml
Imports System.ServiceModel
Imports System.IO
Imports System.Net

Imports System.Xml.Serialization
Imports System.Collections.Generic

Module Module_CIM_SanAn
    Public TCPIP_Used As Boolean = False  '0=NO TCPIP, 1=SananTCP
#Const SanAn_TCPIP_Used = 0

    Public WithEvents RemoteCIM As New CRemoteClass
    Public CIM_Used As Boolean = False
    Public CIM_DataFlag As Boolean = False
    Public CIMLoginEnabled As Boolean = False

    Public RemoteRecipeShortFileName As String = ""
    Public RemoteRecipeFileName As String = ""


    Public TCP_SendMessage As String = ""
    Public TCP_ReceiveMessage As String = ""

#If SanAn_TCPIP_Used = 1 Then
   Public WithEvents SanAnTCP As New CSanAnTCPProcotol
#Else
    Public WithEvents SanAnTCP As CSanAnTCPProcotol
#End If
    Public Sub ServerError(ByVal code As Integer) Handles SanAnTCP.ServerError
        RemoteCIM.ChangeToOffLine()
    End Sub



    Public Sub TCP_Received(ByVal msg As String) Handles SanAnTCP.ReceiveEvent
        TCP_ReceiveMessage = msg
        FormParameters.CtlSanAnCIMSetup1.UpdateReceiveMessage(msg)
    End Sub
    Public Sub TCP_Send(ByVal msg As String) Handles SanAnTCP.SendEvent
        TCP_SendMessage = msg
        FormParameters.CtlSanAnCIMSetup1.UpdateSendMessage(msg)
    End Sub

    Public Sub Event_H2E_CMD_EXE(ByVal cmdstr As String) Handles SanAnTCP.Event_H2E_CMD_EXE
        ' MsgBoxLangOK("Event_H2E_CMD_EXE")
    End Sub

    Public Sub Event_H2E_REQ_PARAM_DATA(ByVal eqp) Handles SanAnTCP.Event_H2E_REQ_PARAM_DATA
        'SanAnTCP.H2E_REQ_PARAM_R(eqp)
    End Sub

    Public Sub Event_H2E_MSG_DPY(ByVal msg As String) Handles SanAnTCP.Event_H2E_MSG_DPY
        Set_MBit(DoBZIndex, DEVICE_ON)


        CIM_MsgBoxOK(GetLangText("CIM 系統訊息", "CIM Message"), msg)
    End Sub

    Public Sub Event_E2H_CHK_RSOL_LOCAL() Handles SanAnTCP.Event_E2H_CHK_RSOL_LOCAL
        If ProcessMode_RUN = False Then
            RemoteCIM.ChangeToOffLine()
            RemoteCIM.ErrorString = GetLangText("Off-Line: 切換成 Off-Line 模式.", "Off-Line: Switch Off-Line Mode.")
        Else
            CIM_MsgBoxOK(GetLangText("CIM 系統訊息", "CIM Message"), GetLangText("已在製程中.", "In Processing."))
        End If
    End Sub

    Public Sub Event_E2H_CHK_RSOL_REMOTE() Handles SanAnTCP.Event_E2H_CHK_RSOL_REMOTE
        If ProcessMode_RUN = False Then
            RemoteCIM.ChangeToInLine()
            RemoteCIM.ErrorString = GetLangText("In-Line: 切換成 In-Line 模式.", "Off-Line: Switch In-Line Mode.")
        Else
            CIM_MsgBoxOK(GetLangText("CIM 系統訊息", "CIM Message"), GetLangText("已在製程中.", "In Processing."))
        End If
    End Sub

    Public Sub WriteAppenddData(ByVal sfile As String, ByVal Data As String)
        On Error Resume Next
        Dim fileno As Integer
        Dim FS1 As System.IO.FileStream
        Dim SW1 As System.IO.StreamWriter
        FS1 = New System.IO.FileStream(sfile, System.IO.FileMode.Append)
        SW1 = New System.IO.StreamWriter(FS1, System.Text.Encoding.ASCII)

        Dim unicodeString As String = Data
        ' Create two different encodings.  ASCII與 Unicode兩者互轉
        Dim ascii As Encoding = Encoding.ASCII
        Dim [unicode] As Encoding = Encoding.Unicode
        ' Convert the string into a byte[].
        Dim unicodeBytes As Byte() = [unicode].GetBytes(unicodeString)

        ' Perform the conversion from one encoding to the other. 這段程式很麻煩，一定要先用Byte型態之後，才能轉碼！
        Dim asciiBytes As Byte() = Encoding.Convert([unicode], ascii, unicodeBytes)

        ' Convert the new byte[] into a char[] and then into a string.
        ' This is a slightly different approach to converting to illustrate
        ' the use of GetCharCount/GetChars.
        Dim asciiChars(ascii.GetCharCount(asciiBytes, 0, asciiBytes.Length)) As Char
        ascii.GetChars(asciiBytes, 0, asciiBytes.Length, asciiChars, 0)
        Dim asciiString As New String(asciiChars, 0, asciiChars.Length - 1)
        asciiString.Replace(Chr(0), Chr(32))
        SW1.WriteLine(asciiString)
        SW1.Close()


    End Sub

    Public Class CRemoteClass
        Property EQID As String
            Get
                Return _MachineNo
            End Get
            Set(value As String)
                _MachineNo = value
            End Set
        End Property
        Public PorcessDataFileName As String

        Public _MachineNo As String

        Public _RunRecipeContent As String
        Public _RunRecipeNo As String
        Public _RunOperateorID As String
        Public _RunSerialoNo As String


        Private _CheckTimer As Timer
        Private _CheckTime As Integer

        Private _DelayTimerEnabled As Boolean
        Private _DelayTimer As Integer


        Private _InlineMode As Boolean

        Private _Enabled As Boolean
        Private _Pause As Boolean
        Private _state As Integer
        Private _ConfirmEnabled As Boolean
        Private _ProcessGo As Boolean

        Private _SECTION As String = "CIMDATA"
        Private _INIFILE As String = "CIMDATA.INI"

        Public REMOTEDIR As String = "C:\IT_DATA\"

        Public Const RECIPE_DATA_NAME As String = "RECIPE.TXT"

        Public _LastRunDate As String
        Public _RunDate As String

        Public _LastRunDay As String
        Public _RunDay As String
        Public ErrorString As String

        Public _Run_No As Integer
        Public _Run_NoStr As String

        Public _LastRun_No As Integer
        Public _LastRun_NoStr As String


        Public RecipeData As New CSanAnCIMData


        Public Server_Mode As Boolean = False

        Sub New()


        End Sub



        Public Sub RecreateDirs()

            WriteINIFile()
        End Sub


        ''' <summary>
        ''' 讀取 遠端控制參數檔
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub ReadINIFile()
            _MachineNo = ReadProgData(_SECTION, "MACHINENO", "IPE01", _INIFILE)

            _InlineMode = GetTrue01Boolean(ReadProgData(_SECTION, "INLINE", "0", _INIFILE))
            _ConfirmEnabled = GetTrue01Boolean(ReadProgData(_SECTION, "CONFIRM_ENABLE", "0", _INIFILE))



            CIM_DataFlag = GetTrue01Boolean(ReadProgData(_SECTION, "CIM_DataFlag", "1", _INIFILE))
            _Run_NoStr = ReadProgData(_SECTION, "RUNNO", "0000000001", _INIFILE)
            _Run_No = Format(Val(_Run_NoStr), "0000000000")
            If _Run_No < 1 Or _Run_No > 999999 Then
                _Run_No = 1
                _Run_NoStr = "0000000001"
            End If

            _LastRun_NoStr = ReadProgData(_SECTION, "LASTRUNNO", "1", _INIFILE)
            _LastRun_No = Val(_LastRun_NoStr)
            If _LastRun_No < 1 Or _LastRun_No > 999999 Then
                _LastRun_No = 1
                _LastRun_NoStr = "0000000001"
            End If

            _RunDate = ReadProgData(_SECTION, "RUNDATE", "999999", _INIFILE)
            _LastRunDate = ReadProgData(_SECTION, "LASTRUNDATE", "999999", _INIFILE)

            _RunDay = ReadProgData(_SECTION, "RUNDAY", "99", _INIFILE)
            _LastRunDay = ReadProgData(_SECTION, "LASTRUNDAY", "99", _INIFILE)


            ReadCIMSetup()
            CIM_Used = "0" ' "1" 'Modified to "0" by Vincent 20220506 


        End Sub

        Public Sub ReadCIMSetup()
            CIM_Used = GetTrue01Boolean(ReadProgData(_SECTION, "CIM_USED", "1", _INIFILE))
            CIM_Used = True
        End Sub
        Public Sub WriteCIMSetup()
            WriteProgData(_SECTION, "CIM_USED", GetTrue01String(CIM_Used), _INIFILE)
        End Sub


        Public Sub ReadCIM_DataFlag()
            CIM_DataFlag = GetTrue01Boolean(ReadProgData(_SECTION, "CIM_DataFlag", "1", _INIFILE))
        End Sub
        Public Sub WriteCIM_DataFlag()
            WriteProgData(_SECTION, "CIM_DataFlag", GetTrue01String(CIM_DataFlag), _INIFILE)
        End Sub


        Public Function GetDataID(ByVal ID As String, ByVal sp As String, ByVal data As String, Optional ByRef strout As String = "") As Boolean
            Dim ss() As String
            If ID = Nothing Then Return ""
            If sp = Nothing Then Return ""
            If data = Nothing Then Return ""
            Dim ii As Integer = InStr(data, ID)
            If ii > 0 And ii < 3 Then
                ss = data.Split(sp)
                If ss.Length > 1 Then
                    strout = ss(1)
                    Return True
                Else
                    strout = ""
                    Return False
                End If
            End If
        End Function


        ''' <summary>
        ''' 儲存 遠端控制參數檔
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub WriteINIFile()

            WriteProgData(_SECTION, "MACHINENO", _MachineNo, _INIFILE)


            WriteProgData(_SECTION, "INLINE", GetTrue01String(_InlineMode), _INIFILE)

            WriteProgData(_SECTION, "RUNNO", _Run_NoStr, _INIFILE)
            WriteProgData(_SECTION, "LASTRUNNO", _LastRun_NoStr, _INIFILE)
            WriteProgData(_SECTION, "RUNDATE", _RunDate, _INIFILE)
            WriteProgData(_SECTION, "LASTRUNDATE", _LastRunDate, _INIFILE)
            WriteProgData(_SECTION, "RUNDAY", _RunDay, _INIFILE)
            WriteProgData(_SECTION, "LASTRUNDAY", _LastRunDay, _INIFILE)
            WriteProgData(_SECTION, "CONFIRM_ENABLE", GetTrue01String(_ConfirmEnabled), _INIFILE)

            WriteProgData(_SECTION, "CIM_DataFlag", GetTrue01String(CIM_DataFlag), _INIFILE)


        End Sub

        Public Sub WriteRunNo()
            WriteProgData(_SECTION, "RUNNO", _Run_NoStr, _INIFILE)
            WriteProgData(_SECTION, "LASTRUNNO", _LastRun_NoStr, _INIFILE)
        End Sub

        Public Sub WriteRunDate()
            WriteProgData(_SECTION, "RUNDATE", _RunDate, _INIFILE)
            WriteProgData(_SECTION, "LASTRUNDATE", _LastRunDate, _INIFILE)
        End Sub
        Public Sub WriteRunDay()
            WriteProgData(_SECTION, "RUNDAY", _RunDay, _INIFILE)
            WriteProgData(_SECTION, "LASTRUNDAY", _LastRunDay, _INIFILE)
        End Sub

        Public Sub WriteConfirmEnable()
            WriteProgData(_SECTION, "CONFIRM_ENABLE", GetTrue01String(_ConfirmEnabled), _INIFILE)
        End Sub


        Property Pause() As Boolean
            Get
                Return _Pause
            End Get
            Set(ByVal value As Boolean)
                _Pause = value
            End Set
        End Property

        Property ProcessGo() As Boolean
            Get
                Return _ProcessGo
            End Get
            Set(ByVal value As Boolean)
                _ProcessGo = value
            End Set
        End Property

        ''' <summary>
        '''啟動/停止 IN-LINE 模式
        ''' </summary>
        ''' <remarks></remarks>
        Property Enable() As Boolean
            Get
                Return _Enabled
            End Get
            Set(ByVal value As Boolean)
                _Enabled = value
            End Set
        End Property

        ''' <summary>
        ''' 製程執行前確認MSGBOX
        ''' </summary>
        ''' <remarks></remarks>
        Property ConfirmEnable() As Boolean
            Get
                Return _ConfirmEnabled
            End Get
            Set(ByVal value As Boolean)
                _ConfirmEnabled = value
            End Set
        End Property

        ''' <summary>
        ''' 初始化 CIM 控制類別
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub Initial()
            'TCPIP Use  ----------- Start
#If SanAn_TCPIP_Used = 0 Then
            TCPIP_Used = False 'True  'Modified by Vincent 20220506 
#Else
            TCPIP_Used = True
            _INIFILE = Application.StartupPath + "\" + "CIMDATA.INI"
            ReadINIFile()

            'TCPIP Use  ----------- Start
            If TCPIP_Used Then
                SanAnTCP.ReadTCPIPSetup()
                SanAnTCP.EQPID = _MachineNo
                'Client Mode
                'SanAnTCP.Connect(SanAnTCP.ServerIP, SanAnTCP.ServerPort)
                'If SanAnTCP.Connected Then
                '    SanAnTCP.E2H_CHK_ALIVE(RemoteCIM.EQID)
                'End If

                'Server Mode
                SanAnTCP.StartServer(SanAnTCP.ServerPort)
            End If
            'TCPIP Use  ----------- End
            WriteINIFile()
            _state = 0

#End If
            'TCPIP Use  ----------- End
        End Sub

        Public Sub ChangeToInLine(Optional show As Boolean = False)
            If RemoteCIM.Enable Then Exit Sub
            If show Then
                If MsgBoxLangYesNo("是否要啟動遠端控制模式?", "Do you want to enable In-Line mode?") = True Then
                    RemoteCIM.Enable = True
                End If
            Else
                RemoteCIM.Enable = True
            End If
            If RemoteCIM.Enable = True Then
                SanAnTCP.E2H_CHK_RSOL_REMOTE(RemoteCIM.EQID)
            End If
        End Sub

        Public Sub ChangeToOffLine(Optional show As Boolean = False)
            If RemoteCIM.Enable = False Then Exit Sub
            If show Then
                If MsgBoxLangYesNo("是否要停止遠端控制模式?", "Do you want to disable In-Line mode?") = True Then
                    RemoteCIM.Enable = False
                End If
            Else
                RemoteCIM.Enable = False
            End If
            If RemoteCIM.Enable = False Then
                SanAnTCP.E2H_CHK_RSOL_LOCAL(RemoteCIM.EQID)
            End If
        End Sub


        '寫入單筆資料, 在最後端換行,檔案不存在會自動建立

        Public Sub WriteAppenddData(ByVal sfile As String, ByVal Data As String)
            On Error Resume Next
            Dim fileno As Integer
            Dim FS1 As System.IO.FileStream
            Dim SW1 As System.IO.StreamWriter
            FS1 = New System.IO.FileStream(sfile, System.IO.FileMode.Append)
            SW1 = New System.IO.StreamWriter(FS1, System.Text.Encoding.ASCII)


            Dim unicodeString As String = Data
            ' Create two different encodings.  ASCII與 Unicode兩者互轉
            Dim ascii As Encoding = Encoding.ASCII
            Dim [unicode] As Encoding = Encoding.Unicode
            ' Convert the string into a byte[].
            Dim unicodeBytes As Byte() = [unicode].GetBytes(unicodeString)

            ' Perform the conversion from one encoding to the other. 這段程式很麻煩，一定要先用Byte型態之後，才能轉碼！
            Dim asciiBytes As Byte() = Encoding.Convert([unicode], ascii, unicodeBytes)

            ' Convert the new byte[] into a char[] and then into a string.
            ' This is a slightly different approach to converting to illustrate
            ' the use of GetCharCount/GetChars.
            Dim asciiChars(ascii.GetCharCount(asciiBytes, 0, asciiBytes.Length)) As Char
            ascii.GetChars(asciiBytes, 0, asciiBytes.Length, asciiChars, 0)
            Dim asciiString As New String(asciiChars, 0, asciiChars.Length - 1)
            asciiString.Replace(Chr(0), Chr(32))
            SW1.WriteLine(asciiString)
            SW1.Close()

        End Sub

    End Class

    Public Class CSanAnCIMData
        Public Structure ProductData
            Public InputID As String
            Public LotID As String
            Public RecipeID As String
            Public WaferCount As String
            Public WaferID() As String
        End Structure
        'For Run Start Data.
        Public TotalWaferRunCount As Integer

        Public EQID As String = ""
        Public DateTime As String = ""
        Public WaferAmount As String = ""
        Public CheckResult As String = ""
        Public ProductCount As String = ""
        Public ProductID() As ProductData
        Public RecipeID As String = ""
        Public OPID As String = ""
        Public AbortCode As String = ""
        Public AlarmMessage As String = ""
        Public RUNID As String = ""
        Public RUNID_Array() As String 'Add by vincent 20200929
        Public LOTID As String = ""
        Public WaferCount As Integer = 0
        Public LogData As String = ""
        Public RecipeLoaded As Boolean
        Public RecipeShortFileName As String = ""
        Public RecipeFileName As String = ""
        Public RecipeName As String = ""

        Sub New()
            ClearData()
        End Sub
        Public Sub ClearData()
            Dim i, j As Integer
            EQID = ""
            DateTime = ""
            CheckResult = ""
            ProductCount = "0"
            ReDim ProductID(10)
            ReDim RUNID_Array(7) 'Add by vincent 20200929
            WaferCount = 0
            OPID = ""
            RUNID = ""
            AbortCode = ""
            AlarmMessage = ""
            LogData = ""
            RecipeShortFileName = ""
            RecipeFileName = ""
            RecipeName = ""
            RecipeLoaded = False
            ClearProduct()

        End Sub
        Public Sub ClearProduct()
            Dim i, j As Integer
            WaferCount = 0
            For i = 0 To ProductID.Length - 1
                ProductID(i).InputID = ""
                ProductID(i).LotID = ""
                ProductID(i).RecipeID = ""
                ProductID(i).WaferCount = ""
                ReDim ProductID(i).WaferID(99)
                For j = 0 To ProductID(i).WaferID.Length - 1
                    ProductID(i).WaferID(j) = ""
                Next
            Next
        End Sub
        'TCP Procotol
        ''' <summary>
        ''' Recieve_H2E_CMD_EXE
        ''' </summary>
        ''' <param name="msg"></param>
        ''' <returns></returns>
        ''' <remarks>送出 Run_Request 後接收回傳檔案</remarks>
        Public Function Recieve_H2E_CMD_EXE(ByVal msg As String) As String
            Try
                Parse_H2E_CMD_EXE(msg)
                If Val(ProductCount) <= 0 Then Return "NG: ProductCount is zero"
                If Val(WaferCount) <= 0 Then Return "NG: WaferCount is zero"
                Return "OK"
            Catch
                Return "NG"
            End Try
        End Function
        Public Function Parse_H2E_CMD_EXE(ByVal InXml As String) As Boolean
            Dim ds As New DataSet("H2E_CMD_EXE")
            Dim TableName As String = "TX"
            Dim RowIndex As Integer = 0
            Dim i As Integer
            Dim xdoc As Object = _
            <?xml version="1.0" encoding="utf-8"?>
            <message>
                <msg_id>H2E_CMD_EXE</msg_id>
                <tid>111</tid>
                <datetime>2020/07/26 20:06:07</datetime>
                <eqp_id>AAF10</eqp_id>
                <command>Start</command>
                <port>1</port>
                <recipe>CIM_DownLoad</recipe>
                <mask>-</mask>
                <product_id_list>
                    <product_id>Lot001</product_id>
                    <wafer_id_list>
                        <wafer_id>Lot001-1-1</wafer_id>
                        <wafer_id>Lot001-1-2</wafer_id>
                        <wafer_id>Lot001-1-3</wafer_id>
                        <wafer_id>Lot001-1-4</wafer_id>
                        <wafer_id>Lot001-1-5</wafer_id>
                        <wafer_id>Lot001-1-6</wafer_id>
                        <wafer_id>Lot001-1-7</wafer_id>
                        <wafer_id>Lot001-1-8</wafer_id>
                        <wafer_id>Lot001-1-9</wafer_id>
                        <wafer_id>Lot001-1-10</wafer_id>
                        <wafer_id>Lot001-1-11</wafer_id>
                        <wafer_id>Lot001-1-12</wafer_id>
                        <wafer_id>Lot001-1-13</wafer_id>
                        <wafer_id>Lot001-1-14</wafer_id>
                        <wafer_id>Lot001-1-15</wafer_id>
                        <wafer_id>Lot001-1-16</wafer_id>
                        <wafer_id>Lot001-1-17</wafer_id>
                        <wafer_id>Lot001-1-18</wafer_id>
                        <wafer_id>Lot001-1-19</wafer_id>
                        <wafer_id>Lot001-1-20</wafer_id>
                        <wafer_id>Lot001-1-21</wafer_id>
                        <wafer_id>Lot001-1-22</wafer_id>
                        <wafer_id>Lot001-1-23</wafer_id>
                        <wafer_id>Lot001-1-24</wafer_id>
                        <wafer_id>Lot001-1-25</wafer_id>
                    </wafer_id_list>
                </product_id_list>
            </message>


            '<?xml version="1.0" encoding="utf-8"?>
            '<message>
            '    <msg_id>H2E_CMD_EXE</msg_id>
            '    <tid>111</tid>
            '    <datetime>2020/07/26 20:06:07</datetime>
            '    <eqp_id>AAF10</eqp_id>
            '    <command>Start</command>
            '    <port>1</port>
            '    <recipe>CIM_DownLoad</recipe>
            '    <mask>-</mask>
            '    <product_id_list>
            '        <product_id>Lot001</product_id>
            '        <wafer_id_list>
            '            <wafer_id>Lot001-1-1</wafer_id>
            '            <wafer_id>Lot001-1-2</wafer_id>
            '            <wafer_id>Lot001-1-3</wafer_id>
            '            <wafer_id>Lot001-1-4</wafer_id>
            '            <wafer_id>Lot001-1-5</wafer_id>
            '            <wafer_id>Lot001-1-6</wafer_id>
            '            <wafer_id>Lot001-1-7</wafer_id>
            '            <wafer_id>Lot001-1-8</wafer_id>
            '            <wafer_id>Lot001-1-9</wafer_id>
            '            <wafer_id>Lot001-1-10</wafer_id>
            '            <wafer_id>Lot001-1-11</wafer_id>
            '            <wafer_id>Lot001-1-12</wafer_id>
            '            <wafer_id>Lot001-1-13</wafer_id>
            '            <wafer_id>Lot001-1-14</wafer_id>
            '            <wafer_id>Lot001-1-15</wafer_id>
            '            <wafer_id>Lot001-1-16</wafer_id>
            '            <wafer_id>Lot001-1-17</wafer_id>
            '            <wafer_id>Lot001-1-18</wafer_id>
            '            <wafer_id>Lot001-1-19</wafer_id>
            '            <wafer_id>Lot001-1-20</wafer_id>
            '            <wafer_id>Lot001-1-21</wafer_id>
            '            <wafer_id>Lot001-1-22</wafer_id>
            '            <wafer_id>Lot001-1-23</wafer_id>
            '            <wafer_id>Lot001-1-24</wafer_id>
            '            <wafer_id>Lot001-1-25</wafer_id>
            '        </wafer_id_list>
            '        <product_id>Lot002</product_id>
            '        <wafer_id_list>
            '            <wafer_id>Lot001-1-1</wafer_id>
            '            <wafer_id>Lot001-1-2</wafer_id>
            '            <wafer_id>Lot001-1-3</wafer_id>
            '            <wafer_id>Lot001-1-4</wafer_id>
            '            <wafer_id>Lot001-1-5</wafer_id>
            '            <wafer_id>Lot001-1-6</wafer_id>
            '            <wafer_id>Lot001-1-7</wafer_id>
            '            <wafer_id>Lot001-1-8</wafer_id>
            '            <wafer_id>Lot001-1-9</wafer_id>
            '            <wafer_id>Lot001-1-10</wafer_id>
            '            <wafer_id>Lot001-1-11</wafer_id>
            '            <wafer_id>Lot001-1-12</wafer_id>
            '            <wafer_id>Lot001-1-13</wafer_id>
            '            <wafer_id>Lot001-1-14</wafer_id>
            '            <wafer_id>Lot001-1-15</wafer_id>
            '            <wafer_id>Lot001-1-16</wafer_id>
            '            <wafer_id>Lot001-1-17</wafer_id>
            '            <wafer_id>Lot001-1-18</wafer_id>
            '            <wafer_id>Lot001-1-19</wafer_id>
            '            <wafer_id>Lot001-1-20</wafer_id>
            '            <wafer_id>Lot001-1-21</wafer_id>
            '            <wafer_id>Lot001-1-22</wafer_id>
            '            <wafer_id>Lot001-1-23</wafer_id>
            '            <wafer_id>Lot001-1-24</wafer_id>
            '            <wafer_id>Lot001-1-25</wafer_id>
            '        </wafer_id_list>
            '    </product_id_list>
            '</message>
            Try

                Dim Xmldoc As XmlDocument = New XmlDocument
                '//從指定的字串載入XML文件
                Xmldoc.LoadXml(InXml)
                'Xmldoc.LoadXml(xdoc.ToString)

                'ds = XmlStringToDataSet(xdoc.ToString)
                ds = XmlStringToDataSet(InXml)
                'If ds.Tables.Count > 0 Then ds.Tables(0).TableName = "message"
                'If ds.Tables.Count > 1 Then ds.Tables(1).TableName = "product_id_list"
                'If ds.Tables.Count > 2 Then ds.Tables(2).TableName = "product_id"
                'If ds.Tables.Count > 3 Then ds.Tables(3).TableName = "wafer_id_list"
                'If ds.Tables.Count > 4 Then ds.Tables(4).TableName = "wafer_id"
                If ds.Tables.Count > 0 Then
                    Dim WAFER_ID_INDEX As Integer = 0
                    Dim WAFER_ID_LIST_INDEX As Integer = 0
                    Dim PRODUCT_ID_INDEX As Integer = 0
                    Dim PRODUCT_ID_LIST_INDEX As Integer = 0
                    Dim MESSAGE_ID_INDEX As Integer = 0

                    For i = 0 To ds.Tables.Count - 1
                        If ds.Tables(i).TableName.ToUpper = "message".ToUpper Then
                            MESSAGE_ID_INDEX = i
                        End If
                        If ds.Tables(i).TableName.ToUpper = "wafer_id_list".ToUpper Then
                            WAFER_ID_LIST_INDEX = i
                        End If
                        If ds.Tables(i).TableName.ToUpper = "wafer_id".ToUpper Then
                            WAFER_ID_INDEX = i
                        End If
                        If ds.Tables(i).TableName.ToUpper = "product_id_list".ToUpper Then
                            PRODUCT_ID_LIST_INDEX = i
                        End If
                        If ds.Tables(i).TableName.ToUpper = "product_id".ToUpper Then
                            PRODUCT_ID_INDEX = i
                        End If
                    Next

                    ClearProduct()

                    Dim HostCmd As String = ds.Tables(MESSAGE_ID_INDEX).Rows(0).Item(0) '0: msg_id
                    Dim tmpTid As String = ds.Tables(MESSAGE_ID_INDEX).Rows(0).Item(1) '1: tid
                    DateTime = ds.Tables(MESSAGE_ID_INDEX).Rows(0).Item(2) '2: datetime
                    EQID = ds.Tables(MESSAGE_ID_INDEX).Rows(0).Item(3) '3: eqp_id
                    Dim subCmd As String = ds.Tables(MESSAGE_ID_INDEX).Rows(0).Item(4) '4: command
                    Dim port As String = ds.Tables(MESSAGE_ID_INDEX).Rows(0).Item(5) '5: port
                    Dim rcpID As String = ds.Tables(MESSAGE_ID_INDEX).Rows(0).Item(6) '6: Product_Recipe
                    Dim mask As String = ds.Tables(MESSAGE_ID_INDEX).Rows(0).Item(7) '7: mask
                    ProductCount = ds.Tables(PRODUCT_ID_LIST_INDEX).Rows.Count
                    Dim WaferID_List As Integer = ds.Tables(WAFER_ID_LIST_INDEX).Rows.Count
                    WaferCount = ds.Tables(WAFER_ID_INDEX).Rows.Count
                    Dim j, k, l, m, n As Integer
                    Dim sstr As String = ""
                    j = 0
                    k = 0
                    l = 0
                    m = 0
                    For i = 0 To ProductCount - 1
                        ProductID(i).RecipeID = rcpID
                    Next
                    Dim CurrentIndex As Integer = 0
                    Dim lastindex As Integer = 0

                    For i = 0 To WaferCount - 1
                        If Val(ProductCount) > 0 Then
                            CurrentIndex = Val(ds.Tables(WAFER_ID_INDEX).Rows(i).Item(1))
                            If CurrentIndex = 0 Then
                                ProductID(0).WaferID(j) = ds.Tables(WAFER_ID_INDEX).Rows(i).Item(0)
                                j += 1
                                ProductID(0).WaferCount = j
                            End If
                        End If
                        If Val(ProductCount) > 1 Then
                            If Val(ds.Tables(WAFER_ID_INDEX).Rows(i).Item(1)) = 1 Then
                                ProductID(1).WaferID(k) = ds.Tables(WAFER_ID_INDEX).Rows(i).Item(0)
                                k += 1
                                ProductID(1).WaferCount = k
                            End If
                        End If
                        If Val(ProductCount) > 2 Then
                            If Val(ds.Tables(WAFER_ID_INDEX).Rows(i).Item(1)) = 2 Then
                                ProductID(2).WaferID(l) = ds.Tables(WAFER_ID_INDEX).Rows(i).Item(0)
                                l += 1
                                ProductID(2).WaferCount = l
                            End If
                        End If
                        If Val(ProductCount) > 3 Then
                            If Val(ds.Tables(WAFER_ID_INDEX).Rows(i).Item(1)) = 3 Then
                                ProductID(3).WaferID(m) = ds.Tables(4).Rows(i).Item(0)
                                m += 1
                                ProductID(3).WaferCount = m
                            End If
                        End If
                    Next
                End If
                Return True
            Catch ex As Exception
                CIM_MsgBoxShow(ex.ToString)
            End Try

            Return False
        End Function
        Private Function XmlStringToDataTable(ByVal Xmlstring As String) As DataTable
            If Xmlstring = "" Then Return Nothing
            '//新建XML文件類別
            Dim Xmldoc = New XmlDocument
            '//從指定的字串載入XML文件
            Xmldoc.LoadXml(Xmlstring)
            '//建立此物件，並輸入透過StringReader讀取Xmldoc中的Xmldoc字串輸出
            Dim XmlReader1 As XmlReader = XmlReader.Create(New System.IO.StringReader(Xmldoc.OuterXml))
            '//建立DataSet
            Dim ds = New DataSet
            '//透過DataSet的ReadXml方法來讀取Xmlreader資料
            ds.ReadXml(XmlReader1)
            '//建立DataTable並將DataSet中的第0個Table資料給DataTable
            Dim dt As New DataTable
            dt = ds.Tables(0)
            '//回傳DataTable
            Return dt
        End Function
        Private Function XmlStringToDataSet(ByVal Xmlstring As String) As DataSet
            If Xmlstring = "" Then Return Nothing
            '//新建XML文件類別
            Dim Xmldoc = New XmlDocument
            '//從指定的字串載入XML文件
            Xmldoc.LoadXml(Xmlstring)
            '//建立此物件，並輸入透過StringReader讀取Xmldoc中的Xmldoc字串輸出
            Dim XmlReader1 As XmlReader = XmlReader.Create(New System.IO.StringReader(Xmldoc.OuterXml))
            '//建立DataSet
            Dim ds = New DataSet
            '//透過DataSet的ReadXml方法來讀取Xmlreader資料
            ds.ReadXml(XmlReader1)
            '//建立DataTable並將DataSet中的第0個Table資料給DataTable
            Dim dt As New DataTable
            dt = ds.Tables(0)
            '//回傳DataTable
            Return ds
        End Function
    End Class
End Module
'Add by Vincent TCPIP 20200716    ------------- End
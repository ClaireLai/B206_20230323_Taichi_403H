Public Module Parameter

    Public rcv_strArray As Object              'WinSock data array
    Public last_DataTmp As WinsockMsgStructure
    Public SendData As WinsockData

    Public Structure EQPTrigger
        Public Connect_Req As String    'CIM Connect Request (from EQP)
        Public Process_St As String     'Process Status Change Report
        Public BCR_Read_Cmp As String   'Barcode Read Complete
        Public Lot_Start As String      'Lot Start
        Public Lot_Close As String      'Lot Close
        Public Rework As String         'Process Rework
        Public Robot As String
        Public Slot_01 As String
        Public Slot_02 As String
        Public Slot_03 As String
        Public Slot_04 As String
        Public Slot_05 As String
        Public Slot_06 As String
        Public Slot_07 As String
        Public Slot_08 As String
        Public Slot_09 As String
        Public Slot_10 As String
        Public Slot_11 As String
        Public Slot_12 As String
        Public Slot_13 As String
        Public Slot_14 As String
        Public Slot_15 As String
        Public Slot_16 As String
    End Structure

    Public Structure EQPData
        Public LotNumber As String
        Public QTY As String
        Public Electric_1 As String
        Public Electric_2 As String
        Public Electric_3 As String
        Public Electric_4 As String
        Public Temperature_1 As String
        Public Temperature_2 As String
        Public Temperature_3 As String
        Public Temperature_4 As String
        Public Temperature_5 As String
        Public Temperature_6 As String
        Public SVID_01 As String
        Public SVID_02 As String
        Public SVID_03 As String
        Public SVID_04 As String
        Public SVID_05 As String
        Public SVID_06 As String
        Public SVID_07 As String
        Public SVID_08 As String
        Public SVID_09 As String
        Public SVID_10 As String
        Public SVID_11 As String
        Public SVID_12 As String
        Public SVID_13 As String
        Public SVID_14 As String
        Public SVID_15 As String
        Public SVID_16 As String
        Public SVID_17 As String
        Public SVID_18 As String
        Public SVID_19 As String
        Public SVID_20 As String
        Public SVID_21 As String
        Public SVID_22 As String
        Public SVID_23 As String

        Public LotID As String
        Public LotRunTime As String
        Public LotIdleTime As String
        Public LotAlarmTime As String
        Public LotPMTime As String
        Public LotTgroughPut As String
        Public TotalRunTime As String
        Public TotalIdleTime As String
        Public TotalAlarmTime As String
        Public TotalPMTime As String
        Public TotalTgroughPut As String
    End Structure

    Public Structure EQPAlarm
        Public Group01 As String
        Public Group02 As String
        Public Group03 As String
        Public Group04 As String
        Public Group05 As String
        Public Group06 As String
        Public Group07 As String
        Public Group08 As String
        Public Group09 As String
        Public Group10 As String
        Public Group11 As String
        Public Group12 As String
        Public Group13 As String
        Public Group14 As String
        Public Group15 As String
        Public Group16 As String
        Public Group17 As String
        Public Group18 As String
        Public Group19 As String
        Public Group20 As String
    End Structure

    Public Structure WinsockData
        Public Events As EQPTrigger
        Public Data As EQPData
        Public Alarm As EQPAlarm
    End Structure


End Module

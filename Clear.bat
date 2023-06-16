del /F /Q Records\AlarmRecords
FOR /D %%p IN ("Records\AlarmRecords\*.*") DO rmdir "%%p" /s /q
del /F /Q Records\CSVRecord
FOR /D %%p IN ("Records\CSVRecord\*.*") DO rmdir "%%p" /s /q
del /F /Q Records\ProcessEvent
FOR /D %%p IN ("Records\ProcessEvent\*.*") DO rmdir "%%p" /s /q
del /F /Q Records\DataLogRecords
FOR /D %%p IN ("Records\DataLogRecords\*.*") DO rmdir "%%p" /s /q
del /F /Q Records\ProcessRecordCurves
FOR /D %%p IN ("Records\ProcessRecordCurves\*.*") DO rmdir "%%p" /s /q
del /F /Q Records\ProcessRecordLists
FOR /D %%p IN ("Records\ProcessRecordLists\*.*") DO rmdir "%%p" /s /q
del /F /Q Records\ProcessRecords
FOR /D %%p IN ("Records\ProcessRecords\*.*") DO rmdir "%%p" /s /q
del /F /Q Records\PurgeGasRecords
FOR /D %%p IN ("Records\PurgeGasRecords\*.*") DO rmdir "%%p" /s /q
del /F /Q Records\VideoRecorders
FOR /D %%p IN ("Records\VideoRecorders\*.*") DO rmdir "%%p" /s /q
del /F /Q Records\OperatorRecords
FOR /D %%p IN ("Records\OperatorRecords\*.*") DO rmdir "%%p" /s /q
del /F /Q Records\CIM_Log
FOR /D %%p IN ("Records\CIM_Log\*.*") DO rmdir "%%p" /s /q
del /F /Q Records\CIM_RawLog
FOR /D %%p IN ("Records\CIM_RawLog\*.*") DO rmdir "%%p" /s /q
del /F /Q Records\PLCAlarmRecords
FOR /D %%p IN ("Records\PLCAlarmRecords\*.*") DO rmdir "%%p" /s /q


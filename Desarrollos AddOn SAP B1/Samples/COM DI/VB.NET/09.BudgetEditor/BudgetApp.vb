
'****************************************************************************
'  SAP MANAGE DI API 6.5 SDK Sample
'****************************************************************************
'
'  Copyright (c) SAP MANAGE
'
' THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
' ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
' THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
' PARTICULAR PURPOSE.
'
'****************************************************************************
' In this sample the SAP Business one order form is imitated via DI 6.5
'****************************************************************************

Module OrderApp
    Public oRecordSet As SAPbobsCOM.Recordset ' A recordset object

    '****************************************************************************
    ' This is the application entry point
    '****************************************************************************
    Public Sub Main()
        Dim fMain As frmMain ' The main form object
        fMain = New frmMain ' allocating a new form
        fMain.ShowDialog() ' showing the form
        fMain.Dispose() ' destroy the form object
        fMain = Nothing
    End Sub
End Module

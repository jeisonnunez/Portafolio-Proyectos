
'//  SAP MANAGE UI API 2007 SDK Sample
'//****************************************************************************
'//
'//  File:      Password.vb
'//
'//  Copyright (c) SAP MANAGE
'//
'// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
'// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
'// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
'// PARTICULAR PURPOSE.
'//
'//****************************************************************************
'// BEFORE STARTING:
'// 1. Add reference to the "SAP Business One UI API"
'// 2. Insert the development connection string to the "Command line argument"
'//-----------------------------------------------------------------
'// 1.
'//    a. Project->Add Reference...
'//    b. select the "SAP Business One UI API 2007" From the COM folder
'//
'// 2.
'//     a. Project->Properties...
'//     b. choose Configuration Properties folder (place the arrow on Debugging)
'//     c. place the following connection string in the 'Command line arguments' field
'// 0030002C0030002C00530041005000420044005F00440061007400650076002C0050004C006F006D0056004900490056
'//
'//**************************************************************************************************

Option Strict Off
Option Explicit On 

Friend Class Password
    Private WithEvents SBO_Application As SAPbouiCOM.Application

    Private Sub SetApplication()

        Dim SboGuiApi As SAPbouiCOM.SboGuiApi
        Dim sConnectionString As String

        SboGuiApi = New SAPbouiCOM.SboGuiApi
        sConnectionString = Environment.GetCommandLineArgs.GetValue(1)

        SboGuiApi.Connect(sConnectionString)
        SBO_Application = SboGuiApi.GetApplication()

    End Sub
    Public Sub New()
        MyBase.New()
        SetApplication()
    End Sub

    Private Sub SBO_Application_ItemEvent(ByVal FormUID As String, ByRef pVal As SAPbouiCOM.ItemEvent, ByRef BubbleEvent As Boolean) Handles SBO_Application.ItemEvent
        Dim EventEnum As SAPbouiCOM.BoEventTypes
        Dim oItem As SAPbouiCOM.Item
        Dim oEdit As SAPbouiCOM.EditText
        Dim oForm As SAPbouiCOM.Form

        EventEnum = pVal.EventType

        ' 20701 is the password setting form
        ' This is the only event handled by the addon.
        ' Items 3 and 4 are the passwoed fields

        If (pVal.FormType = "20701") And _
            (EventEnum = SAPbouiCOM.BoEventTypes.et_VALIDATE) And _
            ((pVal.ItemUID = "3") Or (pVal.ItemUID = "4")) Then

            oForm = SBO_Application.Forms.Item(FormUID)
            oItem = oForm.Items.Item(CInt(pVal.ItemUID) - 1) ' The items index is zero based
            oEdit = oItem.Specific
            Dim sPassword As String
            sPassword = oEdit.String
            If Not (ValidPassword(sPassword)) Then
                SBO_Application.StatusBar.SetText("Password Length < 7 , 1 caps and 1 num", SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Error)
                BubbleEvent = False
            Else
                SBO_Application.StatusBar.SetText("Password Is Valid", SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Success)
            End If
        End If
    End Sub

    ' This function checks if the password is complex enough
    Private Function ValidPassword(ByVal s As String) As Boolean
        Dim sPassword As String
        Dim bPasswordOk As Boolean

        Dim CheckLength = 7 ' The minimum length of the password
        Dim CheckCaps = 1 ' The minimum number of capital letters in the password
        Dim CheckNums = 1 ' The minimum number of numeric digits in the password

        Dim NumCaps = 0 ' The actual number of capital letters in the password
        Dim NumNums = 0 'The actual number of numeric digits in the password

        bPasswordOk = True
        sPassword = s ' Get the password


        ' Check for the number of capitel letters and numeric digits in the password
        Dim i As Integer
        For i = 0 To sPassword.Length - 1
            Dim c As Char
            c = sPassword.Substring(i, 1)
            If (c >= "A") And (c <= "Z") Then
                NumCaps += 1
            End If
            If (c >= "0") And (c <= "9") Then
                NumNums += 1
            End If
        Next

        'If the password it not ok, change the returned value to false
        If (sPassword.Length < CheckLength) Or (NumCaps < CheckCaps) Or (NumNums < CheckNums) Then
            bPasswordOk = False
        End If

        ValidPassword = bPasswordOk
    End Function
End Class
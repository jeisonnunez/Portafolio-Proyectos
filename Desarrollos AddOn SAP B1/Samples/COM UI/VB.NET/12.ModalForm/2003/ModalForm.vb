
'//  SAP MANAGE UI API 2007 SDK Sample
'//****************************************************************************
'//
'//  File:      ModalForm.vb
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

' This class presents a modal form.
' Only after you close the form you can open other forms.

Friend Class ModalForm
    Private WithEvents SBO_Application As SAPbouiCOM.Application
    Private bModal As Boolean ' Flag to indicate if the modal form is open.
    Private oForm As SAPbouiCOM.Form

    Private Sub SetApplication()

        Dim SboGuiApi As SAPbouiCOM.SboGuiApi
        Dim sConnectionString As String

        bModal = False
        SboGuiApi = New SAPbouiCOM.SboGuiApi
        sConnectionString = Environment.GetCommandLineArgs.GetValue(1)

        SboGuiApi.Connect(sConnectionString)
        SBO_Application = SboGuiApi.GetApplication()

        CreateModalForm()
    End Sub
    Private Sub CreateModalForm()
        Dim cp As SAPbouiCOM.FormCreationParams
        Dim oItem As SAPbouiCOM.Item
        Dim oStatic As SAPbouiCOM.StaticText

        ' Create the form
        cp = SBO_Application.CreateObject(SAPbouiCOM.BoCreatableObjectType.cot_FormCreationParams)

        cp.BorderStyle = SAPbouiCOM.BoFormBorderStyle.fbs_Fixed
        cp.FormType = "Modal"
        cp.UniqueID = "Modal"

        oForm = SBO_Application.Forms.AddEx(cp)
        oForm.ClientHeight = 130
        oForm.ClientWidth = 150

        ' Create the form GUI elements
        oForm.AutoManaged = False
        oForm.SupportedModes = 0
        oItem = oForm.Items.Add("1", SAPbouiCOM.BoFormItemTypes.it_BUTTON)
        oItem.AffectsFormMode = False
        oItem.Top = 100
        oItem.Left = 10

        oItem = oForm.Items.Add("MyStatic", SAPbouiCOM.BoFormItemTypes.it_STATIC)
        oStatic = oItem.Specific()
        oStatic.Caption = "I am a modal form"

        oForm.Visible = True
        bModal = True
    End Sub
    Public Sub New()
        MyBase.New()
        SetApplication()
    End Sub

    Private Sub SBO_Application_ItemEvent(ByVal FormUID As String, ByRef pVal As SAPbouiCOM.ItemEvent, ByRef BubbleEvent As Boolean) Handles SBO_Application.ItemEvent
        ' Don't let the user to move to other forms
        Dim EventEnum As SAPbouiCOM.BoEventTypes
        EventEnum = pVal.EventType

        If bModal And FormUID <> "Modal" Then
            oForm.Select() ' Select the modal form
            BubbleEvent = False
        End If
        ' If the modal from is closed...
        If FormUID = "Modal" And (EventEnum = SAPbouiCOM.BoEventTypes.et_FORM_CLOSE) And bModal Then
            bModal = False
        End If
    End Sub

    Private Sub SBO_Application_MenuEvent(ByRef pVal As SAPbouiCOM.MenuEvent, ByRef BubbleEvent As Boolean) Handles SBO_Application.MenuEvent
        ' Don't let the user to use the menus when the modal form is open.
        If bModal Then
            BubbleEvent = False
        End If
    End Sub
End Class
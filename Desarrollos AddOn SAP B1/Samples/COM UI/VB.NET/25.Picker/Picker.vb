'//  SAP MANAGE UI API 2007 SDK Sample
'//****************************************************************************
'//
'//  File:      Picker.vb
'//
'//  Copyright (c) SAP MANAGE
'//
'// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
'// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
'// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
'// PARTICULAR PURPOSE.
'//
'//****************************************************************************

Option Strict Off
Option Explicit On 

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


Friend Class Picker

    '//**********************************************************
    '// This parameter will use us to manipulate the
    '// SAP Business One Application
    '//**********************************************************

    Private WithEvents SBO_Application As SAPbouiCOM.Application
    Dim oForm As SAPbouiCOM.Form

    Private Sub SetApplication()
        Try
            '*******************************************************************
            '// Use an SboGuiApi object to establish connection
            '// with the SAP Business One application and return an
            '// initialized appliction object
            '*******************************************************************

            Dim SboGuiApi As SAPbouiCOM.SboGuiApi
            Dim sConnectionString As String

            SboGuiApi = New SAPbouiCOM.SboGuiApi

            '// by following the steps specified above, the following
            '// statment should be suficient for either development or run mode

            sConnectionString = Environment.GetCommandLineArgs.GetValue(1)

            '// connect to a running SBO Application

            SboGuiApi.Connect(sConnectionString)

            '// get an initialized application object

            SBO_Application = SboGuiApi.GetApplication()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub New()
        MyBase.New()

        Dim oCreationParams As SAPbouiCOM.FormCreationParams
        Dim oItem As SAPbouiCOM.Item
        Dim oEditText As SAPbouiCOM.EditText
        Dim oStaticText As SAPbouiCOM.StaticText

        Try
            '//*************************************************************
            '// set SBO_Application with an initialized application object
            '//*************************************************************

            SetApplication()

            '//*************************************************************
            '// Draw Form
            '//*************************************************************

            '// add a new form

            oCreationParams = SBO_Application.CreateObject(SAPbouiCOM.BoCreatableObjectType.cot_FormCreationParams)

            oCreationParams.BorderStyle = SAPbouiCOM.BoFormBorderStyle.fbs_Fixed
            oCreationParams.UniqueID = "PickerForm"

            oForm = SBO_Application.Forms.AddEx(oCreationParams)

            '// set the form properties
            oForm.Title = "Data Picker"
            oForm.Left = 400
            oForm.Top = 100
            oForm.ClientHeight = 150
            oForm.ClientWidth = 350

            '// add User Data Sources to the form
            oForm.DataSources.UserDataSources.Add("UDDate", SAPbouiCOM.BoDataType.dt_DATE)
            oForm.DataSources.UserDataSources.Add("UDNum", SAPbouiCOM.BoDataType.dt_PRICE)
            oForm.DataSources.UserDataSources.Add("UDCFL", SAPbouiCOM.BoDataType.dt_SHORT_TEXT)

            AddChooseFromList()

            '// Add Controls
            '//**********************************
            '// Adding Static Text item
            '//**********************************

            oItem = oForm.Items.Add("StaticHead", SAPbouiCOM.BoFormItemTypes.it_STATIC)
            oItem.Left = 7
            oItem.Width = 348
            oItem.Top = 8
            oItem.Height = 44

            oItem.LinkTo = "txtDate"
            oStaticText = oItem.Specific
            oStaticText.Caption = "This sample shows 3 different picker items."

            ' Date Picker
            '__________________________________________________________________________________________
            '//*************************
            '// Adding a Text Edit item
            '//*************************

            oItem = oForm.Items.Add("txtDate", SAPbouiCOM.BoFormItemTypes.it_EDIT)
            oItem.Left = 157
            oItem.Width = 80
            oItem.Top = 58
            oItem.Height = 14

            oEditText = oItem.Specific

            '// bind the text edit item to the defined used data source
            oEditText.DataBind.SetBound(True, "", "UDDate")

            '//**********************************
            '// Adding Static Text item
            '//**********************************

            oItem = oForm.Items.Add("StaticTxt1", SAPbouiCOM.BoFormItemTypes.it_STATIC)
            oItem.Left = 7
            oItem.Width = 148
            oItem.Top = 58
            oItem.Height = 14

            oItem.LinkTo = "txtDate"
            oStaticText = oItem.Specific
            oStaticText.Caption = "Date Picker"

            ' Calc Picker
            '__________________________________________________________________________________________
            '//*************************
            '// Adding a Text Edit item
            '//*************************

            oItem = oForm.Items.Add("txtCalc", SAPbouiCOM.BoFormItemTypes.it_EDIT)
            oItem.Left = 157
            oItem.Width = 80
            oItem.Top = 74
            oItem.Height = 14

            oEditText = oItem.Specific

            '// bind the text edit item to the defined used data source
            oEditText.DataBind.SetBound(True, "", "UDNum")

            '//**********************************
            '// Adding Static Text item
            '//**********************************

            oItem = oForm.Items.Add("StaticTxt2", SAPbouiCOM.BoFormItemTypes.it_STATIC)
            oItem.Left = 7
            oItem.Width = 148
            oItem.Top = 74
            oItem.Height = 14

            oItem.LinkTo = "txtCalc"
            oStaticText = oItem.Specific
            oStaticText.Caption = "Calc Picker"
            ' CFL Picker
            '__________________________________________________________________________________________
            '//*************************
            '// Adding a Text Edit item
            '//*************************

            oItem = oForm.Items.Add("txtCFL", SAPbouiCOM.BoFormItemTypes.it_EDIT)
            oItem.Left = 157
            oItem.Width = 80
            oItem.Top = 90
            oItem.Height = 14

            oEditText = oItem.Specific

            '// bind the text edit item to the defined used data source
            oEditText.DataBind.SetBound(True, "", "UDCFL")

            oEditText.ChooseFromListUID = "CFL1"

            '//**********************************
            '// Adding Static Text item
            '//**********************************

            oItem = oForm.Items.Add("StaticTxt3", SAPbouiCOM.BoFormItemTypes.it_STATIC)
            oItem.Left = 7
            oItem.Width = 148
            oItem.Top = 90
            oItem.Height = 14

            oItem.LinkTo = "txtCFL"
            oStaticText = oItem.Specific
            oStaticText.Caption = "CFL Picker"

            oForm.Visible = True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub AddChooseFromList()
        Try

            Dim oCFLs As SAPbouiCOM.ChooseFromListCollection
            Dim oCons As SAPbouiCOM.Conditions
            Dim oCon As SAPbouiCOM.Condition

            oCFLs = oForm.ChooseFromLists

            Dim oCFL As SAPbouiCOM.ChooseFromList
            Dim oCFLCreationParams As SAPbouiCOM.ChooseFromListCreationParams
            oCFLCreationParams = SBO_Application.CreateObject(SAPbouiCOM.BoCreatableObjectType.cot_ChooseFromListCreationParams)

            ' Adding 2 CFL, one for the button and one for the edit text.
            oCFLCreationParams.MultiSelection = False
            oCFLCreationParams.ObjectType = "2"
            oCFLCreationParams.UniqueID = "CFL1"

            oCFL = oCFLs.Add(oCFLCreationParams)

            ' Adding Conditions to CFL1

            oCons = oCFL.GetConditions()

            oCon = oCons.Add()
            oCon.Alias = "CardType"
            oCon.Operation = SAPbouiCOM.BoConditionOperation.co_EQUAL
            oCon.CondVal = "C"
            oCFL.SetConditions(oCons)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub oSBO_Application_ItemEvent(ByVal FormUID As String, ByRef pVal As SAPbouiCOM.ItemEvent, ByRef BubbleEvent As Boolean) Handles SBO_Application.ItemEvent
        Dim oItem As SAPbouiCOM.Item
        Dim oEdit As SAPbouiCOM.EditText

        Try
            If pVal.FormUID = "PickerForm" Then
                If pVal.EventType = SAPbouiCOM.BoEventTypes.et_CHOOSE_FROM_LIST Then

                    Dim oCFLEvento As SAPbouiCOM.IChooseFromListEvent
                    oCFLEvento = pVal
                    Dim sCFL_ID As String
                    sCFL_ID = oCFLEvento.ChooseFromListUID

                    'Dim oForm As SAPbouiCOM.Form
                    'oForm = SBO_Application.Forms.Item(FormUID)
                    Dim oCFL As SAPbouiCOM.ChooseFromList
                    oCFL = oForm.ChooseFromLists.Item(sCFL_ID)

                    If oCFLEvento.BeforeAction = False Then
                        Dim oDataTable As SAPbouiCOM.DataTable
                        oDataTable = oCFLEvento.SelectedObjects
                        Dim val As String
                        Try
                            val = oDataTable.GetValue(0, 0)
                        Catch ex As Exception

                        End Try
                        If (pVal.ItemUID = "txtCFL") Then
                            oForm.DataSources.UserDataSources.Item("UDCFL").ValueEx = val
                        End If

                    End If
                End If

                If (FormUID = "PickerForm") And (pVal.EventType = SAPbouiCOM.BoEventTypes.et_FORM_UNLOAD) Then
                    Windows.Forms.Application.Exit()
                End If

                If pVal.EventType = SAPbouiCOM.BoEventTypes.et_PICKER_CLICKED Then
                    oItem = oForm.Items.Item(pVal.ItemUID)
                    oEdit = oItem.Specific


                    SBO_Application.StatusBar.SetText("Picker Clicked of type " & oEdit.PickerType.ToString, SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Success)
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
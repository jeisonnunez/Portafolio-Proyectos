'//  SAP MANAGE UI API 2007 SDK Sample
'//****************************************************************************
'//
'//  File:      ChooseFromList.vb
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

Public Class ChooseFromList

    '//**********************************************************
    '// This parameter will use us to manipulate the
    '// SAP Business One Application
    '//**********************************************************

    Private WithEvents SBO_Application As SAPbouiCOM.Application
    Private oForm As SAPbouiCOM.Form

    Private Sub SetApplication()

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

    End Sub

    Private Sub CreateForm()

        Dim oCP As SAPbouiCOM.FormCreationParams
        Dim oItem As SAPbouiCOM.Item
        Dim oStatic As SAPbouiCOM.StaticText
        Dim oButton As SAPbouiCOM.Button
        Dim oEdit As SAPbouiCOM.EditText

        ' Setting the form creation params
        oCP = SBO_Application.CreateObject(SAPbouiCOM.BoCreatableObjectType.cot_FormCreationParams)
        oCP.UniqueID = "CFL1"
        oCP.FormType = "CFL1"
        oCP.BorderStyle = SAPbouiCOM.BoFormBorderStyle.fbs_Sizable


        ' Adding the form
        oForm = SBO_Application.Forms.AddEx(oCP)
        oForm.Title = "Choose From List Demo"

        ' Adding a User Data Source
        oForm.DataSources.UserDataSources.Add("EditDS", SAPbouiCOM.BoDataType.dt_SHORT_TEXT)

        AddChooseFromList()

        ' Adding a text box
        oItem = oForm.Items.Add("EditTxt", SAPbouiCOM.BoFormItemTypes.it_EDIT)
        oItem.Left = 120
        oItem.Top = 90
        oItem.LinkTo = "StaticTxt"
        oEdit = oItem.Specific

        ' Adding a static text - Customer
        oItem = oForm.Items.Add("StaticTxt", SAPbouiCOM.BoFormItemTypes.it_STATIC)
        oItem.Left = 10
        oItem.Top = 90
        oItem.LinkTo = "EditTxt"
        oStatic = oItem.Specific
        oStatic.Caption = "Customer"

        ' Adding a static texts - Explenation
        oItem = oForm.Items.Add("Explain", SAPbouiCOM.BoFormItemTypes.it_STATIC)
        oItem.Left = 10
        oItem.Top = 10
        oItem.Width = 200
        oStatic = oItem.Specific
        oStatic.Caption = "There are 2 Choose From List OBjects here"

        oItem = oForm.Items.Add("Explain1", SAPbouiCOM.BoFormItemTypes.it_STATIC)
        oItem.Left = 10
        oItem.Top = 25
        oItem.Width = 300
        oStatic = oItem.Specific
        oStatic.Caption = "One is activated by pressing TAB in the Edit box,"

        oItem = oForm.Items.Add("Explain2", SAPbouiCOM.BoFormItemTypes.it_STATIC)
        oItem.Left = 10
        oItem.Top = 40
        oItem.Width = 300
        oStatic = oItem.Specific
        oStatic.Caption = "it Shows Only 'Customer' type Business Partners."

        oItem = oForm.Items.Add("Explain3", SAPbouiCOM.BoFormItemTypes.it_STATIC)
        oItem.Left = 10
        oItem.Top = 55
        oItem.Width = 300
        oStatic = oItem.Specific
        oStatic.Caption = "The other is activated by the button,"

        oItem = oForm.Items.Add("Explain4", SAPbouiCOM.BoFormItemTypes.it_STATIC)
        oItem.Left = 10
        oItem.Top = 70
        oItem.Width = 300
        oStatic = oItem.Specific
        oStatic.Caption = "it shows all Business Partners"

        ' Adding a CFL button
        oItem = oForm.Items.Add("Button", SAPbouiCOM.BoFormItemTypes.it_BUTTON)
        oItem.Left = 198
        oItem.Top = 88
        oButton = oItem.Specific
        oButton.Type = SAPbouiCOM.BoButtonTypes.bt_Image
        oItem.Width = 20
        oItem.Height = 20
        oButton.Image = IO.Directory.GetParent(Application.StartupPath).ToString & "\CFL.BMP"

        ' Adding Choose From List
        oEdit.DataBind.SetBound(True, "", "EditDS")

        ' Adding 2 Choose From List Object, ONE FOR EDIT TEXT AND ONE FOR BUTTON.
        oEdit.ChooseFromListUID = "CFL1"

        'We set the alias only after the UID is set, the alias is the field in the database
        'It compares the value in the edit text and narrows the CFL accrodingly
        oEdit.ChooseFromListAlias = "CardCode"

        oButton.ChooseFromListUID = "CFL2"

        oForm.Width = 300
        oForm.Height = 150

        oForm.Visible = True

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

            oCFLCreationParams.UniqueID = "CFL2"
            oCFL = oCFLs.Add(oCFLCreationParams)

        Catch
            MsgBox(Err.Description)
        End Try
    End Sub

    Public Sub New()
        MyBase.New()

        '//*************************************************************
        '// set SBO_Application with an initialized application object
        '//*************************************************************

        SetApplication()

        CreateForm()

    End Sub

    Private Sub SBO_Application_ItemEvent(ByVal FormUID As String, ByRef pVal As SAPbouiCOM.ItemEvent, ByRef BubbleEvent As Boolean) Handles SBO_Application.ItemEvent
        If pVal.EventType = SAPbouiCOM.BoEventTypes.et_CHOOSE_FROM_LIST Then
            Dim oCFLEvento As SAPbouiCOM.IChooseFromListEvent
            oCFLEvento = pVal
            Dim sCFL_ID As String
            sCFL_ID = oCFLEvento.ChooseFromListUID
            Dim oForm As SAPbouiCOM.Form
            oForm = SBO_Application.Forms.Item(FormUID)
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
                If (pVal.ItemUID = "EditTxt") Or (pVal.ItemUID = "Button") Then
                        oForm.DataSources.UserDataSources.Item("EditDS").ValueEx = val
                    End If

                End If
            End If

        If (FormUID = "CFL1") And (pVal.EventType = SAPbouiCOM.BoEventTypes.et_FORM_UNLOAD) Then
            Windows.Forms.Application.Exit()
        End If


    End Sub
End Class

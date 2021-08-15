
'//  SAP MANAGE UI API 2007 SDK Sample
'//****************************************************************************
'//
'//  File:      SBOForm.vb
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

Option Explicit On 

'// This class is a SAP Business One form.
Public Class SBOForm
    Private WithEvents SBO_Application As SAPbouiCOM.Application ' Application Object
    Private oForm As SAPbouiCOM.Form ' Addon Form
    Private txtMsg As SAPbouiCOM.Item ' The text to be displayed
    Private cmbType As SAPbouiCOM.Item ' A combo box to choose display type

    Private Sub SetApplication()

        '*******************************************************************
        '// Use an SboGuiApi object to establish the connection
        '// with the application and return an initialized appliction object
        '*******************************************************************

        Dim SboGuiApi As SAPbouiCOM.SboGuiApi
        Dim sConnectionString As String

        SboGuiApi = New SAPbouiCOM.SboGuiApi()

        '// by following the steps specified above, the following
        '// statment should be suficient for either development or run mode

        sConnectionString = Environment.GetCommandLineArgs.GetValue(1)

        Try
            '// connect to a running SBO Application

            SboGuiApi.Connect(sConnectionString)

            '// get an initialized application object

            SBO_Application = SboGuiApi.GetApplication()

        Catch
            '// The Connection Failed
            System.Windows.Forms.MessageBox.Show("Could not connect to SAP Business One" _
                                                , "Connection Error" _
                                                , Windows.Forms.MessageBoxButtons.OK, _
                                                Windows.Forms.MessageBoxIcon.Exclamation)
            '// End the application
            End
        End Try
    End Sub

    Private Sub CreateMySimpleForm()

        Dim oItem As SAPbouiCOM.Item

        '// *******************************************
        '// we will use the following objects to set
        '// the specific values of every item
        '// we add.
        '// this is the best way to do so
        '//*********************************************

        Dim oButton As SAPbouiCOM.Button
        Dim oStaticText As SAPbouiCOM.StaticText
        Dim oEditText As SAPbouiCOM.EditText
        Dim oComboBox As SAPbouiCOM.ComboBox


        '// add a new form
        Try
            oForm = SBO_Application.Forms.Add("frmDisplayStatus", SAPbouiCOM.BoFormTypes.ft_Fixed)
        Catch '// Form can not be added
            '// Take care of terminating your AddOn application
            System.Windows.Forms.MessageBox.Show("An open form exists in the application", _
                                                 "Can not load Addon" _
                                                 , Windows.Forms.MessageBoxButtons.OK _
                                                 , Windows.Forms.MessageBoxIcon.Exclamation)
            End
        End Try

        '// add a User Data Source to the form
        oForm.DataSources.UserDataSources.Add("EditSource", SAPbouiCOM.BoDataType.dt_SHORT_TEXT, 40)
        oForm.DataSources.UserDataSources.Add("CombSource", SAPbouiCOM.BoDataType.dt_SHORT_TEXT, 20)

        '// set the form properties
        oForm.Title = "Status Bar Sample"
        oForm.Left = 400
        oForm.ClientWidth = 350
        oForm.Top = 100
        oForm.ClientHeight = 80

        '//*****************************************
        '// Adding Items to the form
        '// and setting their properties
        '//*****************************************


        '/**********************
        '// Adding an Ok button
        '//*********************

        '// We get automatic event handling for
        '// the Ok and Cancel Buttons by setting
        '// their UIDs to 1 and 2 respectively

        oItem = oForm.Items.Add("1", SAPbouiCOM.BoFormItemTypes.it_BUTTON)
        oItem.Left = 6
        oItem.Width = 65
        oItem.Top = 53
        oItem.Height = 19
        oItem.AffectsFormMode = False

        oButton = oItem.Specific

        oButton.Caption = "Ok"

        '//**************************************
        '// Adding a 'Display Status Bar' button
        '//**************************************

        oItem = oForm.Items.Add("BTN_STATUS", SAPbouiCOM.BoFormItemTypes.it_BUTTON)
        oItem.Left = 90
        oItem.Width = 150
        oItem.Top = 53
        oItem.Height = 19
        oItem.AffectsFormMode = False

        oButton = oItem.Specific

        oButton.Caption = "Display Status Bar"

        '//************************
        '// Adding a Rectangle
        '//***********************

        oItem = oForm.Items.Add("Rect1", SAPbouiCOM.BoFormItemTypes.it_RECTANGLE)
        oItem.Left = 0
        oItem.Width = 344
        oItem.Top = 1
        oItem.Height = 45
        oItem.AffectsFormMode = False

        '//*************************
        '// Adding a Combo Box item
        '//*************************

        oItem = oForm.Items.Add("ComboBox1", SAPbouiCOM.BoFormItemTypes.it_COMBO_BOX)
        oItem.Left = 157
        oItem.Width = 163
        oItem.Top = 24
        oItem.Height = 14
        oItem.AffectsFormMode = False
        oItem.DisplayDesc = True
        cmbType = oItem

        oItem.DisplayDesc = False

        oComboBox = oItem.Specific

        '//*************************
        '// Adding a Text Edit item
        '//*************************

        oItem = oForm.Items.Add("EditText1", SAPbouiCOM.BoFormItemTypes.it_EDIT)
        oItem.Left = 157
        oItem.Width = 163
        oItem.Top = 8
        oItem.Height = 14
        oItem.AffectsFormMode = False
        txtMsg = oItem

        oEditText = oItem.Specific

        '// bind the text edit item to the defined used data source
        oEditText.DataBind.SetBound(True, "", "EditSource")
        oEditText.String = "Type Your message Here"

        '//***************************
        '// Adding a Static Text item
        '//***************************

        oItem = oForm.Items.Add("StaticTxt1", SAPbouiCOM.BoFormItemTypes.it_STATIC)
        oItem.Left = 7
        oItem.Width = 148
        oItem.Top = 8
        oItem.Height = 14
        oItem.AffectsFormMode = False

        oItem.LinkTo = "EditText1"

        oStaticText = oItem.Specific

        oStaticText.Caption = "Message Text"

        '//**********************************
        '// Adding another Static Text item
        '//**********************************

        oItem = oForm.Items.Add("StaticTxt2", SAPbouiCOM.BoFormItemTypes.it_STATIC)
        oItem.Left = 7
        oItem.Width = 148
        oItem.Top = 24
        oItem.Height = 14
        oItem.AffectsFormMode = False

        oItem.LinkTo = "ComboBox1"

        oStaticText = oItem.Specific

        oStaticText.Caption = "Message Type"



        '// bind the Combo Box item to the defined used data source
        oComboBox.DataBind.SetBound(True, "", "CombSource")

        oComboBox.ValidValues.Add(CStr(SAPbouiCOM.BoStatusBarMessageType.smt_Warning), "Warning")
        oComboBox.ValidValues.Add(CStr(SAPbouiCOM.BoStatusBarMessageType.smt_Error), "Error")
        oComboBox.ValidValues.Add(CStr(SAPbouiCOM.BoStatusBarMessageType.smt_None), "None")
        oComboBox.ValidValues.Add(CStr(SAPbouiCOM.BoStatusBarMessageType.smt_Success), "Success")
        oComboBox.Select("1")

    End Sub

    '// Catching item events in our AddOn
    Private Sub SBO_Application_ItemEvent(ByVal FormUID As String, ByRef pVal As SAPbouiCOM.ItemEvent, ByRef BubbleEvent As Boolean) Handles SBO_Application.ItemEvent

        '// Catching the Click on the 'Display Status Bar' button
        If (pVal.ItemUID = "BTN_STATUS") And _
        (pVal.EventType = SAPbouiCOM.BoEventTypes.et_ITEM_PRESSED) And _
        (pVal.Before_Action = False) Then
            Dim EditTxtMsg As SAPbouiCOM.EditText
            Dim CmbMsgType As SAPbouiCOM.ComboBox

            EditTxtMsg = txtMsg.Specific
            CmbMsgType = cmbType.Specific

            '// Present the ststus line
            SBO_Application.StatusBar.SetText(EditTxtMsg.String, _
                                                          SAPbouiCOM.BoMessageTime.bmt_Short, _
                                                          CInt(CmbMsgType.Selected.Value))

        End If

        '// Catching the Unload event of the form
        If (pVal.EventType = SAPbouiCOM.BoEventTypes.et_FORM_UNLOAD) And _
           (pVal.FormUid = "frmDisplayStatus") Then

            SBO_Application.MessageBox("Terminating StatusBar Sample")

            '// Take care of terminating your AddOn application

            System.Windows.Forms.Application.Exit()
        End If
    End Sub

    '// Catching application events in our AddOn
    Private Sub SBO_Application_AppEvent(ByVal EventType As SAPbouiCOM.BoAppEventTypes) Handles SBO_Application.AppEvent

        If EventType = SAPbouiCOM.BoAppEventTypes.aet_ShutDown Then

            SBO_Application.MessageBox("A Shut Down Event has been caught" & _
                Environment.NewLine() & "Terminating Add On...")

            '// Take care of terminating your AddOn application

            System.Windows.Forms.Application.Exit()

        End If
    End Sub

    Public Sub New()
        MyBase.New()

        '//*************************************************************
        '// set SBO_Application with an initialized application object
        '//*************************************************************

        SetApplication()

        '//*************************************************************
        '// Create the simple form
        '//*************************************************************

        CreateMySimpleForm()

        oForm.Visible = True


        SBO_Application.StatusBar.SetText("Status Bar Sample is now active", SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Success)
    End Sub
End Class

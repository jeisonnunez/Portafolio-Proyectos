'//  SAP MANAGE UI API 2007 SDK Sample
'//****************************************************************************
'//
'//  File:      OrderFormManipulation.cls
'//
'//  Copyright (c) SAP MANAGE
'//
'// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
'// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
'// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
'// PARTICULAR PURPOSE.
'//
'//****************************************************************************

'//**************************************************************************************************
'// BEFORE STARTING:
'// 1. Add reference to the "SAP Business One UI API"
'// 2. Insert the development connection string to the "Command Line Argument"
'//-----------------------------------------------------------------
'// 1.
'//    a. Project->References
'//    b. check the "SAP Business One UI API" check box
'//
'// 2.
'//     a. Project->Properties
'//     b. choose 'Make' tab folder
'//     c. place the following connection string in the 'Command Line Arguments' field
'// 0030002C0030002C00530041005000420044005F00440061007400650076002C0050004C006F006D0056004900490056
'//
'//**************************************************************************************************

Public Class SystemForm
    '//*****************************************************************
    '// At the begining of every UI API project we should first
    '// establish connection with a running SBO application.
    '*******************************************************************

    Private WithEvents SBO_Application As SAPbouiCOM.Application

    Private oOrderForm As SAPbouiCOM.Form

    Private oNewItem As SAPbouiCOM.Item

    Private oItem As SAPbouiCOM.Item

    Private oFolderItem As SAPbouiCOM.Folder

    Private oOptionBtn As SAPbouiCOM.OptionBtn

    Private oCheckBox As SAPbouiCOM.CheckBox

    Private i As Integer '// to be used as a counter


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

        sConnectionString = Command

        '// connect to a running SBO Application

        SboGuiApi.Connect(sConnectionString)

        '// get an initialized application object

        SBO_Application = SboGuiApi.GetApplication()

    End Sub

    Private Sub AddItemsToOrderForm()

        '// add a user data source
        '// bear in mind that every item must be connected to a data source

        oOrderForm.DataSources.UserDataSources.Add("OpBtnDS", SAPbouiCOM.BoDataType.dt_SHORT_TEXT, 1)
        oOrderForm.DataSources.UserDataSources.Add("CheckDS1", SAPbouiCOM.BoDataType.dt_SHORT_TEXT, 1)
        oOrderForm.DataSources.UserDataSources.Add("CheckDS2", SAPbouiCOM.BoDataType.dt_SHORT_TEXT, 1)
        oOrderForm.DataSources.UserDataSources.Add("CheckDS3", SAPbouiCOM.BoDataType.dt_SHORT_TEXT, 1)


        '//*****************************************
        '// Adding Items to the Order form
        '// and setting their properties
        '//*****************************************


        '//***************************
        '// Adding Check Box items
        '//***************************

        '// use an existing item to place youe item on the form
        oItem = oOrderForm.Items.Item("126")

        For i = 1 To 3

            oNewItem = oOrderForm.Items.Add("CheckBox" & i, SAPbouiCOM.BoFormItemTypes.it_CHECK_BOX)
            oNewItem.Left = oItem.Left
            oNewItem.Width = 100
            oNewItem.Top = oItem.Top + (i - 1) * 19
            oNewItem.Height = 19

            '// set the Item's Pane Level.
            '// this value will determine the Items visibility
            '// according to the Form's pane level
            oNewItem.FromPane = 5
            oNewItem.ToPane = 5

            oCheckBox = oNewItem.Specific

            '// set the caption
            oCheckBox.Caption = "Check Box" & i

            '// binding the Check box with a data source
            oCheckBox.DataBind.SetBound(True, "", "CheckDS" & i)

        Next i

        '//****************************
        '// Adding Option button items
        '//****************************

        '// use an existing item to place youe item on the form
        oItem = oOrderForm.Items.Item("44")

        For i = 1 To 3

            oNewItem = oOrderForm.Items.Add("OpBtn" & i, SAPbouiCOM.BoFormItemTypes.it_OPTION_BUTTON)
            oNewItem.Left = oItem.Left
            oNewItem.Width = 100
            oNewItem.Top = oItem.Top + (i - 1) * 19
            oNewItem.Height = 19


            '// set the Item's Pane Level.
            '// this value will determine the Items visibility
            '// according to the Form's pane level
            oNewItem.FromPane = 5
            oNewItem.ToPane = 5

            oOptionBtn = oNewItem.Specific

            '// set the caption
            oOptionBtn.Caption = "Option Button" & i

            If i > 1 Then
                oOptionBtn.GroupWith("OpBtn" & i - 1)
            End If

            oOptionBtn.DataBind.SetBound(True, "", "OpBtnDS")

        Next i



    End Sub
    Public Sub New()
        MyBase.New()

        '//*************************************************************
        '// set SBO_Application with an initialized application object
        '//*************************************************************

        SetApplication()

        '//*************************************************************
        '// send an "hello world" message
        '//*************************************************************

        'SBO_Application.MessageBox("Hello World")

    End Sub

    Private Sub SBO_Application_ItemEvent(ByVal FormUID As String, ByRef pVal As SAPbouiCOM.ItemEvent, ByRef BubbleEvent As Boolean) Handles SBO_Application.ItemEvent


        If ((pVal.FormType = 139 And pVal.EventType <> SAPbouiCOM.BoEventTypes.et_FORM_UNLOAD) And (pVal.Before_Action = True)) Then

            '// get the event sending form
            oOrderForm = SBO_Application.Forms.GetFormByTypeAndCount(pVal.FormType, pVal.FormTypeCount)

            If ((pVal.EventType = SAPbouiCOM.BoEventTypes.et_FORM_LOAD) And (pVal.Before_Action = True)) Then

                '// add a new folder item to the form
                oNewItem = oOrderForm.Items.Add("UserFolder", SAPbouiCOM.BoFormItemTypes.it_FOLDER)

                '// use an existing folder item for grouping and setting the
                '// items properties (such as location properties)
                '// use the 'Display Debug Information' option (under 'Tools')
                '// in the application to acquire the UID of the desired folder
                oItem = oOrderForm.Items.Item("138")


                oNewItem.Top = oItem.Top
                oNewItem.Height = oItem.Height
                oNewItem.Width = oItem.Width
                oNewItem.Left = oItem.Left + oItem.Width

                oFolderItem = oNewItem.Specific

                oFolderItem.Caption = "User Folder"

                '// group the folder with the desired folder item
                oFolderItem.GroupWith("138")

                '// add your own items to the form
                AddItemsToOrderForm()

                oOrderForm.PaneLevel = 1

            End If

            'If pVal.EventType = SAPbouiCOM.BoEventTypes.et_CLICK And pVal.Before_Action = True Then
            'oOrderForm.PaneLevel = 5

            'End If
            If pVal.ItemUID = "UserFolder" And pVal.EventType = SAPbouiCOM.BoEventTypes.et_ITEM_PRESSED And pVal.Before_Action = True Then

                '// when the new folder is clicked change the form's pane level
                '// by doing so your items will apear on the new folder
                '// assuming they were placed correctly and their pane level
                '// was also set accordingly
                oOrderForm.PaneLevel = 5

            End If

        End If


    End Sub

    Private Sub SBO_Application_AppEvent(ByVal EventType As SAPbouiCOM.BoAppEventTypes)

        Select Case EventType

            Case SAPbouiCOM.BoAppEventTypes.aet_ShutDown

                '// Take care of terminating your AddOn application

                SBO_Application.MessageBox("A Shut Down Event has been caught" & _
                    vbNewLine & "Terminating 'Order Form Manipulation' Add On...")

                End

        End Select

    End Sub


End Class

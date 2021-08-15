'//  SAP MANAGE UI API 2007 SDK Sample
'//****************************************************************************
'//
'//  File:      AddingMenuItems.vb
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

Friend Class UseMatrix

    '//**********************************************************
    '// This parameter will use us to manipulate the
    '// SAP Business One Application
    '//**********************************************************

    Private WithEvents SBO_Application As SAPbouiCOM.Application
    Private oForm As SAPbouiCOM.Form

    Private oMatrix As SAPbouiCOM.Matrix
    Private oColumns As SAPbouiCOM.Columns
    Private oColumn As SAPbouiCOM.Column

    '// declareing a DB data source for all the Data binded columns

    Private oDBDataSource As SAPbouiCOM.DBDataSource

    '// declaring a User data source for the "Remarks" Column
    Private oUserDataSource As SAPbouiCOM.UserDataSource

    '*****************************************************************
    ' This Function is called automatically when an instance
    ' of the class is created.
    ' Indise this function
    '*****************************************************************
    Public Sub New()
        MyBase.New()

        '//*************************************************************
        '// set SBO_Application with an initialized application object
        '//*************************************************************

        SetApplication()

        '// Create the UI 
        CreateFormWithMatrix()

        '// Add Data Sources to the Form
        AddDataSourceToForm()

        '// Bind the Form's items with the desired data source
        BindDataToForm()

        '// Load date to matrix
        GetDataFromDataSource()

        '// Make the form visible
        oForm.Visible = True

    End Sub


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

        Try ' If there's no active application the connection will fail
            SboGuiApi.Connect(sConnectionString)
        Catch ' Connection failed
            System.Windows.Forms.MessageBox.Show("No SAP Business One Application was found")
            End
        End Try
        '// get an initialized application object

        SBO_Application = SboGuiApi.GetApplication()
        'SBO_Application.MessageBox("Hello World")

    End Sub
    Private Sub SBO_Application_AppEvent(ByVal EventType As SAPbouiCOM.BoAppEventTypes) Handles SBO_Application.AppEvent

        Select Case EventType

            Case SAPbouiCOM.BoAppEventTypes.aet_ShutDown

                SBO_Application.MessageBox("A Shut Down Event has been caught" & _
                    Environment.NewLine() & "Terminating 'Add Menu Item' Add On...")
                '// terminating the Add On
                System.Windows.Forms.Application.Exit()
        End Select
    End Sub

    Private Sub CreateFormWithMatrix()
        '//*******************************************************
        '// Don't Forget:
        '// it is much more efficient to load a form from xml.
        '// use code only to create your form.
        '// once you have created it save it as XML.
        '// see "WorkingWithXML" sample project
        '//*******************************************************

        '// we will use the following object to add items to our form
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

        '// The following object is needed to create our form
        Dim creationPackage
        creationPackage = SBO_Application.CreateObject(SAPbouiCOM.BoCreatableObjectType.cot_FormCreationParams)

        creationPackage.UniqueID = "UidFrmMatrix"
        creationPackage.FormType = "TypeFrmMatrix"

        '// Add our form to the SBO application
        oForm = SBO_Application.Forms.AddEx(creationPackage)

        '// Set the form properties
        oForm.Title = "Matrix, Datasources and Linked Button"
        oForm.Left = 336
        oForm.ClientWidth = 520
        oForm.Top = 44
        oForm.ClientHeight = 200

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
        oItem.Left = 5
        oItem.Width = 65
        oItem.Top = 170
        oItem.Height = 19

        oButton = oItem.Specific

        oButton.Caption = "Ok"

        '//************************
        '// Adding a Cancel button
        '//***********************

        oItem = oForm.Items.Add("2", SAPbouiCOM.BoFormItemTypes.it_BUTTON)
        oItem.Left = 75
        oItem.Width = 65
        oItem.Top = 170
        oItem.Height = 19

        oButton = oItem.Specific

        oButton.Caption = "Cancel"


        '//*************************
        '// Adding a Text Edit item
        '//*************************

        oItem = oForm.Items.Add("txtPhone", SAPbouiCOM.BoFormItemTypes.it_EDIT)
        oItem.Left = 265
        oItem.Width = 163
        oItem.Top = 172
        oItem.Height = 14

        '//******************************************
        '// Adding an Add Phone prefix column button
        '//******************************************
        oItem = oForm.Items.Add("BtnPhone", SAPbouiCOM.BoFormItemTypes.it_BUTTON)
        oItem.Left = 160
        oItem.Width = 100
        oItem.Top = 170
        oItem.Height = 19

        oButton = oItem.Specific

        oButton.Caption = "Add Phone prefix"

        '// Add the matrix to the form
        AddMatrixToForm()

    End Sub
    Private Sub AddMatrixToForm()

        '// we will use the following object to add items to our form
        Dim oItem As SAPbouiCOM.Item

        '// we will use the following object to set a linked button
        Dim oLink As SAPbouiCOM.LinkedButton

        '//***************************
        '// Adding a Matrix item
        '//***************************

        oItem = oForm.Items.Add("Matrix1", SAPbouiCOM.BoFormItemTypes.it_MATRIX)
        oItem.Left = 5
        oItem.Width = 500
        oItem.Top = 5
        oItem.Height = 150

        oMatrix = oItem.Specific
        oColumns = oMatrix.Columns

        '//***********************************
        '// Adding Culomn items to the matrix
        '//***********************************

        oColumn = oColumns.Add("#", SAPbouiCOM.BoFormItemTypes.it_EDIT)
        oColumn.TitleObject.Caption = "#"
        oColumn.Width = 30
        oColumn.Editable = False

        '// Add a column for BP Card Code
        oColumn = oColumns.Add("DSCardCode", SAPbouiCOM.BoFormItemTypes.it_LINKED_BUTTON)
        oColumn.TitleObject.Caption = "Card Code"
        oColumn.Width = 40
        oColumn.Editable = True

        '// Link the column to the BP master data system form
        oLink = oColumn.ExtendedObject
        oLink.LinkedObject = SAPbouiCOM.BoLinkedObject.lf_BusinessPartner

        '// Add a column for BP Card Name
        oColumn = oColumns.Add("DSCardName", SAPbouiCOM.BoFormItemTypes.it_EDIT)
        oColumn.TitleObject.Caption = "Name"
        oColumn.Width = 40
        oColumn.Editable = True

        '// Add a column for BP Card Phone
        oColumn = oColumns.Add("DSPhone", SAPbouiCOM.BoFormItemTypes.it_EDIT)
        oColumn.TitleObject.Caption = "Phone"
        oColumn.Width = 40
        oColumn.Editable = True

        '// Add a column for BP Card Phone
        oColumn = oColumns.Add("DSPhoneInt", SAPbouiCOM.BoFormItemTypes.it_EDIT)
        oColumn.TitleObject.Caption = "Int. Phone"
        oColumn.Width = 40
        oColumn.Editable = True
    End Sub

    Public Sub AddDataSourceToForm()

        '//****************************************************************
        '// every item must be binded to a Data Source
        '// prior of binding the data we must add Data sources to the form
        '//****************************************************************

        '// Add user data sources to the "International Phone" column in the matrix
        oUserDataSource = oForm.DataSources.UserDataSources.Add("IntPhone", SAPbouiCOM.BoDataType.dt_SHORT_TEXT, 20)

        '// Add DB data sources for the DB bound columns in the matrix
        oDBDataSource = oForm.DataSources.DBDataSources.Add("OCRD")
    End Sub

    Public Sub BindDataToForm()

        '// getting the matrix column by the UID

        oColumn = oColumns.Item("DSCardCode")
        'oColumn.DataBind.SetBound(True, "", "DSCardCode")
        oColumn.DataBind.SetBound(True, "OCRD", "CardCode")

        oColumn = oColumns.Item("DSCardName")
        oColumn.DataBind.SetBound(True, "OCRD", "CardName")

        oColumn = oColumns.Item("DSPhone")
        oColumn.DataBind.SetBound(True, "OCRD", "Phone1")

        '//************************************************
        '// to Data Bind an item with a user Data source
        '// the table name value should be an empty string
        '//************************************************

        oColumn = oColumns.Item("DSPhoneInt")
        oColumn.DataBind.SetBound(True, "", "IntPhone")

    End Sub
    Public Sub GetDataFromDataSource()

        '// Ready Matrix to populate data
        oMatrix.Clear()
        oMatrix.AutoResizeColumns()

        '// Querying the DB Data source
        oDBDataSource.Query()

        '// setting the user data source data
        oUserDataSource.Value = "Phone with prefix"
        oMatrix.LoadFromDataSource()

    End Sub

    Private Sub SBO_Application_ItemEvent(ByVal FormUID As String, ByRef pVal As SAPbouiCOM.ItemEvent, ByRef BubbleEvent As Boolean) Handles SBO_Application.ItemEvent

        If (pVal.FormUid = "UidFrmMatrix") Then

            If ((pVal.itemUID = "BtnPhone") And _
                (pVal.EventType = SAPbouiCOM.BoEventTypes.et_ITEM_PRESSED) And _
                (pVal.Before_Action = False)) Then
                AddPrefix()
            End If

            If ((pVal.EventType = SAPbouiCOM.BoEventTypes.et_FORM_UNLOAD) And _
                (pVal.Before_Action = False)) Then
                SBO_Application.MessageBox("Form Unloaded, Addon will terminate")
                System.Windows.Forms.Application.Exit()
            End If
        End If
    End Sub

    Public Sub AddPrefix()
        Dim i As Integer
        Dim PhoneExtCol As SAPbouiCOM.Column
        Dim newPhone As String
        Dim oItem As SAPbouiCOM.Item
        Dim oEditTxt As SAPbouiCOM.EditText

        '// Get the prefix edit text item
        oItem = oForm.Items.Item("txtPhone")
        oEditTxt = oItem.Specific

        '// Flush user input into datasources
        oMatrix.FlushToDataSource()

        '// Get the DBdatasource we base the matrix on
        oDBDataSource = oForm.DataSources.DBDataSources.Item("OCRD")

        '// Iterate all the records and add a prefix to the phone
        For i = 0 To oDBDataSource.Size - 1
            newPhone = oDBDataSource.GetValue("phone1", i)
            newPhone = newPhone.Trim(" ")
            oDBDataSource.SetValue("phone1", i, oEditTxt.String + newPhone)
        Next

        '// Load data back to 
        oMatrix.LoadFromDataSource()

    End Sub
End Class

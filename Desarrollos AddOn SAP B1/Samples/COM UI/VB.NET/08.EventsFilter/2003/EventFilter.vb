'  SAP MANAGE UI API 2007 SDK Sample
'****************************************************************************
'
'  File:      EventFilter.vb
'
'  Copyright (c) SAP MANAGE
'
' THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
' ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
' THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
' PARTICULAR PURPOSE.
'
'****************************************************************************
' BEFORE STARTING:
' 1. Add reference to the "SAP Business One UI API"
' 2. Insert the development connection string to the "Command line argument"
'-----------------------------------------------------------------
' 1.
'    a. Project->Add Reference...
'    b. select the "SAP Business One UI API 2007" From the COM folder
'
' 2.
'     a. Project->Properties...
'     b. choose Configuration Properties folder (place the arrow on Debugging)
'     c. place the following connection string in the 'Command line arguments' field
' 0030002C0030002C00530041005000420044005F00440061007400650076002C0050004C006F006D0056004900490056
'
'**************************************************************************************************

Option Strict Off
Option Explicit On 

Public Class EventFilter
    Private WithEvents SBO_Application As SAPbouiCOM.Application

    '//**********************************************************
    '// declaring an Event filters container object and an
    '// event filter object
    '//**********************************************************

    Public oFilters As SAPbouiCOM.EventFilters

    Public oFilter As SAPbouiCOM.EventFilter


    Private Sub SetApplication()

        '*******************************************************************
        '// Use an SboGuiApi object to establish connection
        '// with the SAP Business One application and return an
        '// initialized appliction object
        '*******************************************************************

        Dim SboGuiApi As SAPbouiCOM.SboGuiApi
        Dim sConnectionString As String

        SboGuiApi = New SAPbouiCOM.SboGuiApi()

        '// by following the steped specified above the following
        '// statment should be suficient for either development or run mode

        sConnectionString = Command()

        '// connect to a running SBO Application

        SboGuiApi.Connect(sConnectionString)

        '// get an initialized application object

        SBO_Application = SboGuiApi.GetApplication()

    End Sub

    Private Sub SetFilters()

        '// Create a new EventFilters object
        oFilters = New SAPbouiCOM.EventFilters()

        '// add an event type to the container
        '// this method returns an EventFilter object
        oFilter = oFilters.Add(SAPbouiCOM.BoEventTypes.et_CLICK)

        '// assign the form type on which the event would be processed
        oFilter.AddEx("139") 'Orders Form
        oFilter.AddEx("142") 'Purchase Form

        oFilter = oFilters.Add(SAPbouiCOM.BoEventTypes.et_KEY_DOWN)

        '// assign the form type on which the event would be processed
        oFilter.Add(139) 'Orders Form

        '// For a list of all form types see the help or use the
        '// Tools -> User Tools -> Display Debug Information option
        '// in the SBO application
        '// then open the desired form and hover over it with the mouse
        '// the form's type will apear in the lower left side of the screen


        '// Setting the application with the EventFilters object
        '// in this case we will process a click event for form types 142 and 139
        '// and we will process a key down event for for form type 139

        SBO_Application.SetFilter(oFilters)

    End Sub
    Public Sub New()

        '//*************************************************************
        '// set SBO_Application with an initialized application object
        '//*************************************************************
        SetApplication()

        '//*************************************************************
        '// set SBO_Application with an initialized EventFilters object
        '//*************************************************************

        SetFilters()

    End Sub

    Private Sub SBO_Application_AppEvent(ByVal EventType As SAPbouiCOM.BoAppEventTypes) Handles SBO_Application.AppEvent

        '//********************************************************************************
        '// the following are the events sent by the application
        '// (Ignore aet_ServerTermination)
        '// in order to implement your own code upon each of the events
        '// place you code instead of the matching message box statement
        '//********************************************************************************


        Select Case EventType

            Case SAPbouiCOM.BoAppEventTypes.aet_ShutDown

                SBO_Application.MessageBox("A Shut Down Event has been caught" _
                    & vbNewLine & "Terminating Add On...")

                '//**************************************************************
                '//
                '// Take care of terminating your AddOn application
                '//
                '//**************************************************************

                End



            Case SAPbouiCOM.BoAppEventTypes.aet_CompanyChanged

                SBO_Application.MessageBox("A Company Change Event has been caught")

                '//**************************************************************
                '// Check the new company name, if your add on was not meant for
                '// the new company terminate your AddOn
                '//    If SBO_Application.Company.Name Is Not "Company1" then
                '//         Close
                '//    End If
                '//**************************************************************

            Case SAPbouiCOM.BoAppEventTypes.aet_LanguageChanged

                SBO_Application.MessageBox("A Languge Change Event has been caught")

                '//**************************************************************
                '// Check the new language name, if your AddOn's items needs
                '// to be changed, take care of it at this point
                '//
                '//    Select Case SBO_Application.Language
                '//         Case ln_English:
                '//         Case ln_French:
                '//         Case ln_German:
                '//    End Select
                '//**************************************************************

        End Select

    End Sub


    Private Sub SBO_Application_MenuEvent(ByRef pVal As SAPbouiCOM.MenuEvent, ByRef BubbleEvent As Boolean) Handles SBO_Application.MenuEvent

        '//********************************************************************************
        '// in order to activate your own forms instead of SAP Business One system forms
        '// process the menu event by your self
        '// change BubbleEvent to True so that SAP Business One won't process it
        '//********************************************************************************

        If pVal.beforeAction = True Then

            SBO_Application.SetStatusBarMessage( _
            "Menu item: " + pVal.menuUID + " sent an event BEFORE SAP Business One processes it.", SAPbouiCOM.BoMessageTime.bmt_Long, True)

            '// to stop SAP Business One from processing this event
            '// unmark the following statement

            '// BubbleEvent = True

        Else

            SBO_Application.SetStatusBarMessage( _
            "Menu item: " & pVal.menuUID & " sent an event AFTER SAP Business One processes it.", SAPbouiCOM.BoMessageTime.bmt_Long, True)

        End If

    End Sub

    Private Sub SBO_Application_ItemEvent(ByVal FormUID As String, ByRef pVal As SAPbouiCOM.ItemEvent, ByRef BubbleEvent As Boolean) Handles SBO_Application.ItemEvent


        '//**************************************************************************
        '// BubbleEvent sets the behavior of SAP Business One.
        '// False means that the application will not continue processing this event
        '// True is the default value
        '//**************************************************************************

        If pVal.formType <> 0 And pVal.Before_Action = True Then

            '//************************************************************
            '// the message box form type is 0
            '// I chose not to deal with events triggered by a message box
            '//************************************************************

            Select Case pVal.EventType

                '//************************************************************
                '// every event will open a message box with the event
                '// name and the form UID how sent it
                '//************************************************************

            Case SAPbouiCOM.BoEventTypes.et_ITEM_PRESSED

                    '// Specifies a button release (After exit).

                    SBO_Application.MessageBox( _
                    "An et_ITEM_PRESSED has been sent by a form with the unique ID: " + FormUID)

                Case SAPbouiCOM.BoEventTypes.et_KEY_DOWN

                    '// Specifies a key down event.

                    SBO_Application.MessageBox( _
                    "An et_KEY_DOWN has been sent by a form with the unique ID: " + FormUID)

                Case SAPbouiCOM.BoEventTypes.et_GOT_FOCUS

                    '// Specifies an item got focus.

                    SBO_Application.MessageBox( _
                    "An et_GOT_FOCUS has been sent by a form with the unique ID: " + FormUID)

                Case SAPbouiCOM.BoEventTypes.et_LOST_FOCUS

                    '// Specifies an item lost focus.

                    SBO_Application.MessageBox( _
                    "An et_LOST_FOCUS has been sent by a form with the unique ID: " + FormUID)

                Case SAPbouiCOM.BoEventTypes.et_COMBO_SELECT

                    '// Specifies the selection of valid value in Combo Box.

                    SBO_Application.MessageBox( _
                    "An et_COMBO_SELECT has been sent by a form with the unique ID: " + FormUID)

                Case SAPbouiCOM.BoEventTypes.et_CLICK
                    '// Specifies Mouse Up on editable item.

                    SBO_Application.MessageBox( _
                    "An et_CLICK has been sent by a form with the unique ID: " + FormUID)

                Case SAPbouiCOM.BoEventTypes.et_DOUBLE_CLICK
                    '// Specifies Mouse Up on editable item in time interval define by
                    '// SAP Business One as double-click.

                    SBO_Application.MessageBox( _
                    "An et_DOUBLE_CLICK has been sent by a form with the unique ID: " + FormUID)

                Case SAPbouiCOM.BoEventTypes.et_MATRIX_LINK_PRESSED
                    '// Specifies a link arrow within a matrix was pressed.

                    SBO_Application.MessageBox( _
                    "An et_MATRIX_LINK_PRESSED has been sent by a form with the unique ID: " + FormUID)

                Case SAPbouiCOM.BoEventTypes.et_MATRIX_COLLAPSE_PRESSED
                    '// Specifies collapsed or expanded list within a matrix.

                    SBO_Application.MessageBox( _
                    "An et_MATRIX_COLLAPSE_PRESSED has been sent by a form with the unique ID: " + FormUID)

                Case SAPbouiCOM.BoEventTypes.et_VALIDATE
                    '//Specifies an item validation event.

                    SBO_Application.MessageBox( _
                    "An et_VALIDATE has been sent by a form with the unique ID: " + FormUID)

                Case SAPbouiCOM.BoEventTypes.et_FORM_LOAD
                    '// Specifies that SAP Business One application opened a form.

                    SBO_Application.MessageBox( _
                    "An et_FORM_LOAD has been sent by a form with the unique ID: " + FormUID)

                Case SAPbouiCOM.BoEventTypes.et_FORM_UNLOAD
                    '// Specifies that SAP Business One application closed a form.

                    SBO_Application.MessageBox( _
                    "An et_FORM_UNLOAD has been sent by a form with the unique ID: " + FormUID)

                Case SAPbouiCOM.BoEventTypes.et_FORM_ACTIVATE
                    '// Specifies that the focus is set on the form.

                Case SAPbouiCOM.BoEventTypes.et_FORM_DEACTIVATE
                    '// Specifies that the form lost focus.

                Case SAPbouiCOM.BoEventTypes.et_FORM_CLOSE
                    '// Specifies that the form was closed by calling the Close event.

                    SBO_Application.MessageBox( _
                    "An et_FORM_CLOSE has been sent by a form with the unique ID: " + FormUID)

                Case SAPbouiCOM.BoEventTypes.et_FORM_RESIZE
                    '// Specifies resizing of the form.

                    SBO_Application.MessageBox( _
                    "An et_FORM_RESIZE has been sent by a form with the unique ID: " + FormUID)

                Case SAPbouiCOM.BoEventTypes.et_FORM_KEY_DOWN
                    '// Specifies a key press on an area which is not item of the form.

                    SBO_Application.MessageBox( _
                    "An et_FORM_KEY_DOWN has been sent by a form with the unique ID: " + FormUID)

            End Select
        End If
    End Sub
End Class

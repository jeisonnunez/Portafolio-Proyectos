'  SAP MANAGE UI API 2007 SDK Sample
'****************************************************************************
'
'  File:      CatchingEvents.vb
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

Friend Class CatchingEvents

    '**********************************************************
    ' This parameter will use us to manipulate the
    ' SAP Business One Application
    '**********************************************************

    Private WithEvents SBO_Application As SAPbouiCOM.Application


    Private Sub SetApplication()

        '*******************************************************************
        ' Use an SboGuiApi object to establish connection
        ' with the SAP Business One application and return an
        ' initialized appliction object
        '*******************************************************************

        Dim SboGuiApi As SAPbouiCOM.SboGuiApi
        Dim sConnectionString As String

        SboGuiApi = New SAPbouiCOM.SboGuiApi

        ' by following the steps specified above, the following
        ' statment should be suficient for either development or run mode

        sConnectionString = Environment.GetCommandLineArgs.GetValue(1)

        ' connect to a running SBO Application

        SboGuiApi.Connect(sConnectionString)

        ' get an initialized application object

        SBO_Application = SboGuiApi.GetApplication()

    End Sub

    Public Sub New()
        MyBase.New()

        '*************************************************************
        ' set SBO_Application with an initialized application object
        '*************************************************************

        SetApplication()

    End Sub

    Private Sub SBO_Application_AppEvent(ByVal EventType As SAPbouiCOM.BoAppEventTypes) Handles SBO_Application.AppEvent

        '********************************************************************************
        ' the following are the events sent by the application
        ' (Ignore aet_ServerTermination)
        ' in order to implement your own code upon each of the events
        ' place you code instead of the matching message box statement
        '********************************************************************************


        Select Case EventType

            Case SAPbouiCOM.BoAppEventTypes.aet_ShutDown

                SBO_Application.MessageBox("A Shut Down Event has been caught" & _
                    Environment.NewLine() & "Terminating Add On...")

                '**************************************************************
                '
                ' Take care of terminating your AddOn application
                '
                '**************************************************************

                System.Windows.Forms.Application.Exit()


            Case SAPbouiCOM.BoAppEventTypes.aet_CompanyChanged

                SBO_Application.MessageBox("A Company Change Event has been caught")

                '**************************************************************
                ' Check the new company name, if your add on was not meant for
                ' the new company terminate your AddOn
                '    If SBO_Application.Company.Name Is Not "Company1" then
                '         Close
                '    End If
                '**************************************************************

            Case SAPbouiCOM.BoAppEventTypes.aet_LanguageChanged

                SBO_Application.MessageBox("A Languge Change Event has been caught")

        End Select

    End Sub


    Private Sub SBO_Application_MenuEvent(ByRef pVal As SAPbouiCOM.MenuEvent, ByRef BubbleEvent As Boolean) Handles SBO_Application.MenuEvent

        '********************************************************************************
        ' in order to activate your own forms instead of SAP Business One system forms
        ' process the menu event by your self
        ' change BubbleEvent to False so that SAP Business One won't process it
        '********************************************************************************

        If pVal.BeforeAction = True Then

            SBO_Application.SetStatusBarMessage("Menu item: " & pVal.MenuUID & " sent an event BEFORE SAP Business One processes it.", SAPbouiCOM.BoMessageTime.bmt_Long, True)

            ' to stop SAP Business One from processing this event
            ' unmark the following statement

            ' BubbleEvent = False

        Else

            SBO_Application.SetStatusBarMessage("Menu item: " & pVal.MenuUID & " sent an event AFTER SAP Business One processes it.", SAPbouiCOM.BoMessageTime.bmt_Long, True)

        End If

    End Sub

    Private Sub SBO_Application_ItemEvent(ByVal FormUID As String, ByRef pVal As SAPbouiCOM.ItemEvent, ByRef BubbleEvent As Boolean) Handles SBO_Application.ItemEvent

        '*************************************************************************
        ' BubbleEvent sets the behavior of SAP Business One.
        ' False means that the application will not continue processing this event.
        '*************************************************************************

        If pVal.FormType <> 0 Then

            '************************************************************
            ' the message box form type is 0
            ' I chose not to deal with events triggered by a message box
            '************************************************************

            '************************************************************
            ' every event will open a message box with the event
            ' name and the form UID how sent it
            '************************************************************
            Dim EventEnum As SAPbouiCOM.BoEventTypes
            EventEnum = pVal.EventType

            'To prevent an endless loop of MessageBoxes,
            'we'll not notify et_FORM_ACTIVATE and et_FORM_LOAD events
            If (EventEnum <> SAPbouiCOM.BoEventTypes.et_FORM_ACTIVATE) And _
            (EventEnum <> SAPbouiCOM.BoEventTypes.et_FORM_LOAD) Then
                SBO_Application.MessageBox("An " & EventEnum.ToString & " has been sent by a form with the unique ID: " & FormUID)
            End If
        End If
    End Sub

    Private Sub SBO_Application_ProgressBarEvent(ByRef pVal As SAPbouiCOM.ProgressBarEvent, ByRef BubbleEvent As Boolean) Handles SBO_Application.ProgressBarEvent
        Dim EventEnum As SAPbouiCOM.BoProgressBarEventTypes
        EventEnum = pVal.EventType

        SBO_Application.MessageBox("The event " & EventEnum.ToString & " has been sent")
    End Sub

    Private Sub SBO_Application_StatusBarEvent(ByVal Text As String, ByVal MessageType As SAPbouiCOM.BoStatusBarMessageType) Handles SBO_Application.StatusBarEvent
        SBO_Application.MessageBox("Status bar event with message: """ & Text & """ has been sent")
    End Sub
End Class
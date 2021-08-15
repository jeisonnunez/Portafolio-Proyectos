'  SAP MANAGE UI API 2007 SDK Sample
'****************************************************************************
'
'  File:      RightClick.vb
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

Friend Class RightClick

    '**********************************************************
    ' This parameter will use us to manipulate the
    ' SAP Business One Application
    '**********************************************************

    Private WithEvents SBO_Application As SAPbouiCOM.Application
    Private oForm As SAPbouiCOM.Form

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

        AddMenu()

        CreateForm()

    End Sub

    Private Sub AddMenu()
        Dim oMenuItem As SAPbouiCOM.MenuItem
        Dim oMenus As SAPbouiCOM.Menus

     
        Try
            ' Create menu popup MyUserMenu01 and add it to Tools menu
            Dim oCreationPackage As SAPbouiCOM.MenuCreationParams
            oCreationPackage = SBO_Application.CreateObject(SAPbouiCOM.BoCreatableObjectType.cot_MenuCreationParams)

            oCreationPackage.Type = SAPbouiCOM.BoMenuType.mt_POPUP
            oCreationPackage.UniqueID = "AlwaysAppear"
            oCreationPackage.String = "Always Appear"
            oCreationPackage.Enabled = True

            oMenuItem = SBO_Application.Menus.Item("1280") 'Data'
            oMenus = oMenuItem.SubMenus
            oMenus.AddEx(oCreationPackage)

            'Create sub menu MySubMenu1 and add it to popup MyUserMenu01
            oCreationPackage.Type = SAPbouiCOM.BoMenuType.mt_STRING
            oCreationPackage.UniqueID = "AlwaysPop"
            oCreationPackage.String = "In Data Menu and In RightClick"
            oCreationPackage.Enabled = True

            oMenuItem = SBO_Application.Menus.Item("AlwaysAppear")
            oMenus = oMenuItem.SubMenus
            oMenus.AddEx(oCreationPackage)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub CreateForm()

        Dim oCP As SAPbouiCOM.FormCreationParams
        Dim oItem As SAPbouiCOM.Item
        Dim oStatic As SAPbouiCOM.StaticText
        Dim oButton As SAPbouiCOM.Button
        Dim oEdit As SAPbouiCOM.EditText

        ' Setting the form creation params
        oCP = SBO_Application.CreateObject(SAPbouiCOM.BoCreatableObjectType.cot_FormCreationParams)
        oCP.UniqueID = "RightClk"
        oCP.FormType = "RightClk"
        oCP.BorderStyle = SAPbouiCOM.BoFormBorderStyle.fbs_Sizable

        ' Adding the form
        oForm = SBO_Application.Forms.AddEx(oCP)
        oForm.Title = "Right Click Sample"

        ' Adding a text box
        oItem = oForm.Items.Add("EditTxt", SAPbouiCOM.BoFormItemTypes.it_EDIT)
        oItem.Left = 170
        oItem.Top = 90
        oItem.LinkTo = "StaticTxt"
        oEdit = oItem.Specific

        ' Adding a static text - Caption text
        oItem = oForm.Items.Add("StaticTxt", SAPbouiCOM.BoFormItemTypes.it_STATIC)
        oItem.Left = 10
        oItem.Top = 90
        oItem.Width = 150
        oItem.LinkTo = "EditTxt"
        oStatic = oItem.Specific
        oStatic.Caption = "Right Click On the Text Box"

        ' Adding a static text - Explenation
        oItem = oForm.Items.Add("ExpTxt1", SAPbouiCOM.BoFormItemTypes.it_STATIC)
        oItem.Left = 10
        oItem.Top = 20
        oItem.Width = 350
        oItem.LinkTo = "EditTxt"
        oStatic = oItem.Specific
        oStatic.Caption = "In this sample we show the RightClick usage."

        oItem = oForm.Items.Add("ExpTxt2", SAPbouiCOM.BoFormItemTypes.it_STATIC)
        oItem.Left = 10
        oItem.Top = 35
        oItem.Width = 350
        oItem.LinkTo = "EditTxt"
        oStatic = oItem.Specific
        oStatic.Caption = "When Right-Clicking on the text box 2 additional menus will appear:"

        oItem = oForm.Items.Add("ExpTxt3", SAPbouiCOM.BoFormItemTypes.it_STATIC)
        oItem.Left = 10
        oItem.Top = 50
        oItem.Width = 350
        oItem.LinkTo = "EditTxt"
        oStatic = oItem.Specific
        oStatic.Caption = "'In Data Menu and In RightClick' that always appear in the 'Data' Menu."

        oItem = oForm.Items.Add("ExpTxt4", SAPbouiCOM.BoFormItemTypes.it_STATIC)
        oItem.Left = 10
        oItem.Top = 65
        oItem.Width = 350
        oItem.LinkTo = "EditTxt"
        oStatic = oItem.Specific
        oStatic.Caption = "'Only In RightClick' that appear only in a RightClick menu."

        oForm.Width = 400
        oForm.Height = 150

        oForm.Visible = True

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

            'SBO_Application.SetStatusBarMessage("Menu item: " & pVal.MenuUID & " sent an event AFTER SAP Business One processes it.", SAPbouiCOM.BoMessageTime.bmt_Long, True)

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
                'SBO_Application.MessageBox("An " & EventEnum.ToString & " has been sent by a form with the unique ID: " & FormUID)
            End If
        End If
    End Sub

    Private Sub SBO_Application_RightClickEvent(ByRef eventInfo As SAPbouiCOM.ContextMenuInfo, ByRef BubbleEvent As Boolean) Handles SBO_Application.RightClickEvent

        If eventInfo.FormUID = "RightClk" Then
            If (eventInfo.BeforeAction = True) Then
                Dim oMenuItem As SAPbouiCOM.MenuItem
                Dim oMenus As SAPbouiCOM.Menus


                Try
                    Dim oCreationPackage As SAPbouiCOM.MenuCreationParams
                    oCreationPackage = SBO_Application.CreateObject(SAPbouiCOM.BoCreatableObjectType.cot_MenuCreationParams)

                    oCreationPackage.Type = SAPbouiCOM.BoMenuType.mt_STRING
                    oCreationPackage.UniqueID = "OnlyOnRC"
                    oCreationPackage.String = "Only On Right Click"
                    oCreationPackage.Enabled = True

                    oMenuItem = SBO_Application.Menus.Item("1280") 'Data'
                    oMenus = oMenuItem.SubMenus
                    oMenus.AddEx(oCreationPackage)

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Else
                Dim oMenuItem As SAPbouiCOM.MenuItem
                Dim oMenus As SAPbouiCOM.Menus


                Try
                    SBO_Application.Menus.RemoveEx("OnlyOnRC")

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            End If
        End If
    End Sub
End Class
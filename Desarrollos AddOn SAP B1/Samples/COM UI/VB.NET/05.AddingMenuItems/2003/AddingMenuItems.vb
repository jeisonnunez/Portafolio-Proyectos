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

Option Strict Off
Option Explicit On 

Friend Class AddingMenuItems


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

        Try ' If there's no active application the connection will fail
            SboGuiApi.Connect(sConnectionString)
        Catch ' Connection failed
            System.Windows.Forms.MessageBox.Show("No SAP Business One Application was found")
            End
        End Try
        '// get an initialized application object

        SBO_Application = SboGuiApi.GetApplication()

    End Sub
    Private Sub AddMenuItems()
        '//******************************************************************
        '// Let's add a separator, a pop-up menu item and a string menu item
        '//******************************************************************

        Dim oMenus As SAPbouiCOM.Menus
        Dim oMenuItem As SAPbouiCOM.MenuItem

        Dim i As Integer '// to be used as counter
        Dim lAddAfter As Integer
        Dim sXML As String

        '// Get the menus collection from the application
        oMenus = SBO_Application.Menus
        '--------------------------------------------
        'Save an XML file containing the menus...
        '--------------------------------------------
        'sXML = SBO_Application.Menus.GetAsXML
        'Dim xmlD As System.Xml.XmlDocument
        'xmlD = New System.Xml.XmlDocument
        'xmlD.LoadXml(sXML)
        'xmlD.Save("c:\\mnu.xml")
        '--------------------------------------------


        Dim oCreationPackage As SAPbouiCOM.MenuCreationParams
        oCreationPackage = SBO_Application.CreateObject(SAPbouiCOM.BoCreatableObjectType.cot_MenuCreationParams)
        oMenuItem = SBO_Application.Menus.Item("43520") 'moudles'

        Dim sPath As String

        sPath = Application.StartupPath
        sPath = sPath.Remove(sPath.Length - 3, 3)

        '// find the place in wich you want to add your menu item
        '// in this example I chose to add my menu item under
        '// SAP Business One.
        oCreationPackage.Type = SAPbouiCOM.BoMenuType.mt_POPUP
        oCreationPackage.UniqueID = "MyMenu01"
        oCreationPackage.String = "Sample Menu"
        oCreationPackage.Enabled = True
        oCreationPackage.Image = sPath & "UI.bmp"
        oCreationPackage.Position = 15

        oMenus = oMenuItem.SubMenus

        Try ' If the manu already exists this code will fail
            oMenus.AddEx(oCreationPackage)

            '// Get the menu collection of the newly added pop-up item
            oMenuItem = SBO_Application.Menus.Item("MyMenu01")
            oMenus = oMenuItem.SubMenus

            '// Create s sub menu
            oCreationPackage.Type = SAPbouiCOM.BoMenuType.mt_STRING
            oCreationPackage.UniqueID = "MySubMenu"
            oCreationPackage.String = "Sample Sub Menu"
            oMenus.AddEx(oCreationPackage)
        Catch er As Exception ' Menu already exists
            SBO_Application.MessageBox("Menu Already Exists")
        End Try

    End Sub
    Private Sub AddMenuItemsToForm(ByVal oMenuForm As SAPbouiCOM.Form)

        Dim oCreationPackage As SAPbouiCOM.MenuCreationParams
        oCreationPackage = SBO_Application.CreateObject(SAPbouiCOM.BoCreatableObjectType.cot_MenuCreationParams)
        Dim sPath As String

        sPath = IO.Directory.GetParent(Application.StartupPath).ToString & "\"

        oCreationPackage.Type = SAPbouiCOM.BoMenuType.mt_STRING
        oCreationPackage.UniqueID = "MyGoToMenu"
        oCreationPackage.String = "Form Related Menu"
        oCreationPackage.Image = sPath & "UI1.bmp"


        Try ' If the manu already exists this code will fail
            oMenuForm.Menu.AddEx(oCreationPackage)
        Catch ' Menu already exists
            SBO_Application.MessageBox("Menu Already Exists")
        End Try

        oCreationPackage.UniqueID = "MySecondGoToMenu"
        oCreationPackage.String = "Second Form Related Menu"
        oCreationPackage.Image = sPath & "UI2.bmp"

        Try ' If the manu already exists this code will fail
            oMenuForm.Menu.AddEx(oCreationPackage)
        Catch ' Menu already exists
            SBO_Application.MessageBox("Menu Already Exists")
        End Try

    End Sub

    Public Sub New()
        MyBase.New()

        '//*************************************************************
        '// set SBO_Application with an initialized application object
        '//*************************************************************

        SetApplication()

        '//*************************************************************
        '// Check the SBO application lanuage
        '//*************************************************************

        If Not (SBO_Application.Language = SAPbouiCOM.BoLanguages.ln_English Or _
                SBO_Application.Language = SAPbouiCOM.BoLanguages.ln_English_Cy Or _
                SBO_Application.Language = SAPbouiCOM.BoLanguages.ln_English_Gb Or _
                SBO_Application.Language = SAPbouiCOM.BoLanguages.ln_English_Sg) Then

            SBO_Application.MessageBox("AddingMenuItems Add On:" & Environment.NewLine & _
                "The menu items will be added only for English language settings")

            Exit Sub

        End If

        '//*************************************************************
        '// add the menu items
        '//*************************************************************

        AddMenuItems()
    End Sub


    Private Sub SBO_Application_MenuEvent(ByRef pVal As SAPbouiCOM.MenuEvent, ByRef BubbleEvent As Boolean) Handles SBO_Application.MenuEvent

        If (pVal.MenuUID = "MySubMenu") And (pVal.BeforeAction = False) Then


            SBO_Application.MessageBox("My sub menu item was clicked")
            '//*************************************************************
            '// Create a form to be launched in response to a click on the 
            '// new sub menu item
            '//*************************************************************

            Try
                oForm = SBO_Application.Forms.Item("MyMenuForm")
                SBO_Application.MessageBox("The Form already exists")
            Catch
                oForm = Nothing
                oForm = SBO_Application.Forms.Add("MyMenuForm")
                oForm.Title = "New Sub Menu Item"
                oForm.Left = 400
                oForm.Top = 100
                oForm.Visible = True
                AddMenuItemsToForm(oForm)
            End Try

        End If

        If (pVal.MenuUID = "MyGoToMenu") And (pVal.BeforeAction = False) Then
            SBO_Application.MessageBox("My GoTo Menu was clicked")
        End If
        If (pVal.MenuUID = "MySecondGoToMenu") And (pVal.BeforeAction = False) Then
            SBO_Application.MessageBox("My Second GoTo Menu was clicked")
        End If
    End Sub

    Private Sub SBO_Application_AppEvent(ByVal EventType As SAPbouiCOM.BoAppEventTypes) Handles SBO_Application.AppEvent

        Select Case EventType

            Case SAPbouiCOM.BoAppEventTypes.aet_ShutDown

                SBO_Application.MessageBox("A Shut Down Event has been caught" & _
                    Environment.NewLine() & "Terminating 'Add Menu Item' Add On...")
                '// terminating the Add On
                End

            Case SAPbouiCOM.BoAppEventTypes.aet_LanguageChanged

                If SBO_Application.Language = SAPbouiCOM.BoLanguages.ln_English Or _
                    SBO_Application.Language = SAPbouiCOM.BoLanguages.ln_English_Cy Or _
                    SBO_Application.Language = SAPbouiCOM.BoLanguages.ln_English_Gb Or _
                    SBO_Application.Language = SAPbouiCOM.BoLanguages.ln_English_Sg Then

                    AddMenuItems()

                End If
        End Select
    End Sub

End Class
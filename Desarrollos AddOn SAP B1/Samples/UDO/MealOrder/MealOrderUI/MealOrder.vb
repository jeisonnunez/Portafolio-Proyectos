'//  SAP MANAGE UI API 2007 SDK Sample
'//****************************************************************************
'//
'//  File:      FrmMeal.vb
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

Public Class MealOrder

    Private WithEvents SBO_Application As SAPbouiCOM.Application
    Private oMatrix As SAPbouiCOM.Matrix
    Private sPath As String

    Public Sub New()
        SetApplication()
        AddMenuItems()
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
        SboGuiApi.Connect(sConnectionString)

        '// get an initialized application object
        SBO_Application = SboGuiApi.GetApplication()
    End Sub

    Private Sub DrawForm()
        Dim bPriceVisible As Boolean = True
        Dim f As SAPbouiCOM.Form
        Dim oItem As SAPbouiCOM.Item
        Dim oCombo As SAPbouiCOM.ComboBox
        Dim oMatrix As SAPbouiCOM.Matrix
        Dim oButton As SAPbouiCOM.Button
        Dim oLabel As SAPbouiCOM.StaticText
        Dim oEdit As SAPbouiCOM.EditText

        Dim cp As SAPbouiCOM.FormCreationParams

        cp = SBO_Application.CreateObject(SAPbouiCOM.BoCreatableObjectType.cot_FormCreationParams)

        cp.BorderStyle = SAPbouiCOM.BoFormBorderStyle.fbs_Fixed
        cp.FormType = "FrmMeal"
        cp.ObjectType = "SM_MOR"
        cp.UniqueID = "MOR1"

        Try
            f = SBO_Application.Forms.AddEx(cp)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        ' Defining form dimentions
        f.ClientWidth = 370
        f.ClientHeight = 300

        ' set the form title
        f.Title = "Meal order"

        ' Adding 3 Static Texts and Edit Items
        ' Name
        oItem = f.Items.Add("lblName", SAPbouiCOM.BoFormItemTypes.it_STATIC)
        oItem.Left = 10
        oItem.Top = 10
        oLabel = oItem.Specific
        oLabel.Caption = "Name"

        ' Room
        oItem = f.Items.Add("lblRoom", SAPbouiCOM.BoFormItemTypes.it_STATIC)
        oItem.Left = 10
        oItem.Top = 30
        oLabel = oItem.Specific
        oLabel.Caption = "Room"

        ' Price
        oItem = f.Items.Add("lblPrice", SAPbouiCOM.BoFormItemTypes.it_STATIC)
        oItem.Left = 10
        oItem.Top = 50
        oLabel = oItem.Specific
        oLabel.Caption = "Price"
        ' Hide The Price Field, It is calculated in the UDO
        oItem.Visible = bPriceVisible

        '''''''''''''''''''''''''''''
        ' Addin Fields bound to UDO '
        '''''''''''''''''''''''''''''
        ' Add 3 Edit Edit Items
        ' Name
        oItem = f.Items.Add("txtName", SAPbouiCOM.BoFormItemTypes.it_EDIT)
        oItem.Left = 60
        oItem.Top = 10
        oItem.AffectsFormMode = True
        oItem.LinkTo = "lblName"
        'Binding
        oEdit = oItem.Specific
        oEdit.DataBind.SetBound(True, "@SM_OMOR", "U_Name")

        ' Room
        oItem = f.Items.Add("txtRoom", SAPbouiCOM.BoFormItemTypes.it_EDIT)
        oItem.Left = 60
        oItem.Top = 30
        oItem.AffectsFormMode = True
        oItem.LinkTo = "lblRoom"
        'Binding
        oEdit = oItem.Specific
        oEdit.DataBind.SetBound(True, "@SM_OMOR", "U_Room")

        ' Price
        oItem = f.Items.Add("txtPrice", SAPbouiCOM.BoFormItemTypes.it_EDIT)
        oItem.Left = 60
        oItem.Top = 50
        oItem.AffectsFormMode = True
        oItem.LinkTo = "lblPrice"
        oItem.Enabled = False
        'Binding
        oEdit = oItem.Specific
        oEdit.DataBind.SetBound(True, "@SM_OMOR", "U_Price")

        ' Add the Ok/Add/Update button
        oItem = f.Items.Add("1", SAPbouiCOM.BoFormItemTypes.it_BUTTON)
        oItem.Left = 10
        oItem.Top = 270

        ' Add the cancel button
        oItem = f.Items.Add("2", SAPbouiCOM.BoFormItemTypes.it_BUTTON)
        oItem.Left = 90
        oItem.Top = 270

        ' Add the AddRow
        oItem = f.Items.Add("AddRow", SAPbouiCOM.BoFormItemTypes.it_BUTTON)
        oItem.Left = 290
        oItem.Top = 270
        oButton = oItem.Specific
        oButton.Caption = "Add Row"

        ' Adding a matrix bound to MOR1
        AddMatrixToForm(f)

        f.DataBrowser.BrowseBy = "txtName"
        ' Show the form
        f.Visible = True

    End Sub
    Sub AddMatrixToForm(ByVal f As SAPbouiCOM.Form)
        Dim oItem As SAPbouiCOM.Item
        Dim oColumns As SAPbouiCOM.Columns
        Dim oColumn As SAPbouiCOM.Column

        oItem = f.Items.Add("mat", SAPbouiCOM.BoFormItemTypes.it_MATRIX)
        oItem.Top = 80
        oItem.Left = 10
        oItem.Width = 340
        oItem.Height = 190

        oMatrix = oItem.Specific
        oColumns = oMatrix.Columns

        'Add Columns to the matrix
        'The # column
        oColumn = oColumns.Add("#", SAPbouiCOM.BoFormItemTypes.it_EDIT)
        oColumn.TitleObject.Caption = "#"
        oColumn.Width = 20
        oColumn.Editable = False

        ' Main Dish
        oColumn = oColumns.Add("MainDish", SAPbouiCOM.BoFormItemTypes.it_COMBO_BOX)
        oColumn.TitleObject.Caption = "Main Dish"
        oColumn.Width = 100
        'Add Valid Values
        oColumn.ValidValues.Add("Chicken", "")
        oColumn.ValidValues.Add("Hot Dog", "")
        oColumn.ValidValues.Add("Burger", "")
        oColumn.ValidValues.Add("Fish", "")
        oColumn.ValidValues.Add("Soup", "")
        oColumn.ValidValues.Add("Stake", "")
        'Bind column
        oColumn.DataBind.SetBound(True, "@SM_MOR1", "U_MainDish")

        ' Side Dish
        oColumn = oColumns.Add("SideDish", SAPbouiCOM.BoFormItemTypes.it_COMBO_BOX)
        oColumn.TitleObject.Caption = "Side Dish"
        oColumn.Width = 100
        'Add Valid Values
        oColumn.ValidValues.Add("Salad", "")
        oColumn.ValidValues.Add("Rice", "")
        oColumn.ValidValues.Add("French Fries", "")
        oColumn.ValidValues.Add("Potatoes", "")
        oColumn.ValidValues.Add("Corn", "")
        'Bind column
        oColumn.DataBind.SetBound(True, "@SM_MOR1", "U_SideDish")

        ' Drink
        oColumn = oColumns.Add("Drink", SAPbouiCOM.BoFormItemTypes.it_COMBO_BOX)
        oColumn.TitleObject.Caption = "Drink"
        oColumn.Width = 100
        'Add Valid Values
        oColumn.ValidValues.Add("Cola", "")
        oColumn.ValidValues.Add("7up", "")
        oColumn.ValidValues.Add("Fanta", "")
        oColumn.ValidValues.Add("Orange Juice", "")
        oColumn.ValidValues.Add("Water", "")
        oColumn.ValidValues.Add("Lemonade", "")
        oColumn.ValidValues.Add("Ice Tea", "")
        oColumn.ValidValues.Add("Coffee", "")
        'Bind column
        oColumn.DataBind.SetBound(True, "@SM_MOR1", "U_Drink")

    End Sub

    Private Sub SBO_Application_ItemEvent(ByVal FormUID As String, ByRef pVal As SAPbouiCOM.ItemEvent, ByRef BubbleEvent As Boolean) Handles SBO_Application.ItemEvent
        'Click on Add Row
        If ((FormUID = "MOR1") And (pVal.ItemUID = "AddRow") And (pVal.EventType = SAPbouiCOM.BoEventTypes.et_CLICK) And (pVal.Before_Action = False)) Then
            Dim oDS As SAPbouiCOM.DBDataSource
            oDS = SBO_Application.Forms.Item(FormUID).DataSources.DBDataSources.Item("@SM_MOR1")
            oDS.InsertRecord(oDS.Size)
            oDS.Offset = oDS.Size - 1

            oMatrix.AddRow(1)
        End If
    End Sub

    Private Sub SBO_Application_MenuEvent(ByRef pVal As SAPbouiCOM.MenuEvent, ByRef BubbleEvent As Boolean) Handles SBO_Application.MenuEvent
        If ((pVal.MenuUID = "SM_MEAL_FORM") And (pVal.BeforeAction = False)) Then
            DrawForm()
        End If
    End Sub

    Private Sub AddMenuItems()
        '//******************************************************************
        '// Let's add a pop-up menu item and 3 sub menu items
        '//******************************************************************

        Dim oMenus As SAPbouiCOM.Menus
        Dim oMenuItem As SAPbouiCOM.MenuItem

        '// Get the menus collection from the application
        oMenus = SBO_Application.Menus

        Dim oCreationPackage As SAPbouiCOM.MenuCreationParams

        oCreationPackage = SBO_Application.CreateObject(SAPbouiCOM.BoCreatableObjectType.cot_MenuCreationParams)
        oMenuItem = SBO_Application.Menus.Item("43520") 'moudles'

        sPath = System.Windows.Forms.Application.StartupPath()
        sPath = System.IO.Directory.GetParent(sPath).ToString

        ' Creation parameters
        oCreationPackage.Type = SAPbouiCOM.BoMenuType.mt_POPUP
        oCreationPackage.UniqueID = "SM_MEAL"
        oCreationPackage.String = "Meal Order"
        oCreationPackage.Image = sPath & "\meal.bmp"
        ' we add our menu at the buttom of the list
        oCreationPackage.Position = oMenuItem.SubMenus.Count + 1

        oMenus = oMenuItem.SubMenus

        Try ' If the manu already exists this code will fail
            oMenus.AddEx(oCreationPackage)

            ' Get the menu collection of the newly added pop-up item
            oMenuItem = SBO_Application.Menus.Item("SM_MEAL")
            oMenus = oMenuItem.SubMenus

            ' Add Sub Menu Item
            oCreationPackage.Type = SAPbouiCOM.BoMenuType.mt_STRING
            oCreationPackage.UniqueID = "SM_MEAL_FORM"
            oCreationPackage.String = "Meal Order Form"
            oCreationPackage.Image = sPath & "\meal.bmp"
            oMenus.AddEx(oCreationPackage)

        Catch er As Exception ' Error Handling
            SBO_Application.MessageBox(er.Message)
        End Try

    End Sub
End Class

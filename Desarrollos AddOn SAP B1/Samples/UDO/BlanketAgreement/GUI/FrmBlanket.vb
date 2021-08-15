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

Option Strict Off
Option Explicit On 

Public Class frmMeal
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents cmdCreate As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdCreate = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cmdCreate
        '
        Me.cmdCreate.Location = New System.Drawing.Point(48, 24)
        Me.cmdCreate.Name = "cmdCreate"
        Me.cmdCreate.Size = New System.Drawing.Size(192, 32)
        Me.cmdCreate.TabIndex = 0
        Me.cmdCreate.Text = "Create Blanket Agreement Form"
        '
        'frmMeal
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(272, 85)
        Me.Controls.Add(Me.cmdCreate)
        Me.Name = "frmMeal"
        Me.Text = "Create BLANKET AGREEMENT Form"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private WithEvents SBO_Application As SAPbouiCOM.Application
    Private oMatrix As SAPbouiCOM.Matrix

    ' Connect to the SBO application when the application Loads
    Private Sub frmMeal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetApplication()
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
        cp.FormType = "FrmBLK"
        cp.ObjectType = "SM_BLK"
        cp.UniqueID = "FBLK"

        f = SBO_Application.Forms.AddEx(cp)

        ' Defining form dimentions
        f.ClientWidth = 470
        f.ClientHeight = 300

        ' set the form title
        f.Title = "Blanket Agreement"

        ' Adding Static Texts
        ' BP Code
        oItem = f.Items.Add("lblCode", SAPbouiCOM.BoFormItemTypes.it_STATIC)
        oItem.Left = 10
        oItem.Top = 10
        oLabel = oItem.Specific
        oLabel.Caption = "BP Code"

        ' BP Name
        oItem = f.Items.Add("lblName", SAPbouiCOM.BoFormItemTypes.it_STATIC)
        oItem.Left = 150
        oItem.Top = 10
        oItem.AffectsFormMode = False
        oLabel = oItem.Specific
        oLabel.Caption = "BP Name"

        ' Status
        oItem = f.Items.Add("lblStatus", SAPbouiCOM.BoFormItemTypes.it_STATIC)
        oItem.Left = 300
        oItem.Top = 10
        oItem.AffectsFormMode = False
        oLabel = oItem.Specific
        oLabel.Caption = "Status"

        ' Start Date
        oItem = f.Items.Add("lblStartDT", SAPbouiCOM.BoFormItemTypes.it_STATIC)
        oItem.Left = 10
        oItem.Top = 40
        oItem.AffectsFormMode = False
        oLabel = oItem.Specific
        oLabel.Caption = "Start Date"

        ' End Date
        oItem = f.Items.Add("lblEndDT", SAPbouiCOM.BoFormItemTypes.it_STATIC)
        oItem.Left = 150
        oItem.Top = 40
        oItem.AffectsFormMode = False
        oLabel = oItem.Specific
        oLabel.Caption = "End Date"

        ' Total
        oItem = f.Items.Add("lblTotal", SAPbouiCOM.BoFormItemTypes.it_STATIC)
        oItem.Left = 300
        oItem.Top = 40
        oItem.AffectsFormMode = False
        oLabel = oItem.Specific
        oLabel.Caption = "Total"

        '''''''''''''''''''''''''''''
        ' Addin Fields bound to UDO '
        '''''''''''''''''''''''''''''
        ' Add Edit Items
        ' BP Code
        oItem = f.Items.Add("txtCode", SAPbouiCOM.BoFormItemTypes.it_EDIT)
        oItem.Left = 65
        oItem.Top = 10
        oItem.AffectsFormMode = False
        oItem.LinkTo = "lblCode"
        'Binding
        oEdit = oItem.Specific
        oEdit.DataBind.SetBound(True, "@OBLK", "U_BPCode")

        ' BP Name
        oItem = f.Items.Add("txtName", SAPbouiCOM.BoFormItemTypes.it_EDIT)
        oItem.Left = 205
        oItem.Top = 10
        oItem.AffectsFormMode = False
        oItem.LinkTo = "lblName"
        'Binding
        oEdit = oItem.Specific
        oEdit.DataBind.SetBound(True, "@OBLK", "U_BPName")

        ' Status
        oItem = f.Items.Add("cmbStat", SAPbouiCOM.BoFormItemTypes.it_COMBO_BOX)
        oItem.Left = 340
        oItem.Top = 10
        oItem.AffectsFormMode = False
        oItem.LinkTo = "lblStatus"
        'Binding
        oCombo = oItem.Specific
        oCombo.ValidValues.Add("Active", "Active")
        oCombo.ValidValues.Add("Inactive", "Inactive")
        oCombo.DataBind.SetBound(True, "@OBLK", "U_Status")

        ' Start Date
        oItem = f.Items.Add("txtStartDT", SAPbouiCOM.BoFormItemTypes.it_EDIT)
        oItem.Left = 65
        oItem.Top = 40
        oItem.AffectsFormMode = False
        oItem.LinkTo = "lblStartDT"
        'Binding
        oEdit = oItem.Specific
        oEdit.DataBind.SetBound(True, "@OBLK", "U_StartDT")

        ' Start Date
        oItem = f.Items.Add("txtEndDT", SAPbouiCOM.BoFormItemTypes.it_EDIT)
        oItem.Left = 205
        oItem.Top = 40
        oItem.AffectsFormMode = False
        oItem.LinkTo = "lblEndDT"
        'Binding
        oEdit = oItem.Specific
        oEdit.DataBind.SetBound(True, "@OBLK", "U_EndDT")

        ' Start Date
        oItem = f.Items.Add("txtTotal", SAPbouiCOM.BoFormItemTypes.it_EDIT)
        oItem.Left = 340
        oItem.Top = 40
        oItem.AffectsFormMode = False
        oItem.LinkTo = "lblTotal"
        'Binding
        oEdit = oItem.Specific
        oEdit.DataBind.SetBound(True, "@OBLK", "U_Total")

        ' Add the Ok/Add/Update button
        oItem = f.Items.Add("1", SAPbouiCOM.BoFormItemTypes.it_BUTTON)
        oItem.Left = 10
        oItem.Top = 270

        ' Add the AddRow
        oItem = f.Items.Add("AddRow", SAPbouiCOM.BoFormItemTypes.it_BUTTON)
        oItem.Left = 360
        oItem.Top = 100
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
        oItem.Top = 30
        oItem.Left = 10
        oItem.Width = 340
        oItem.Height = 240

        oMatrix = oItem.Specific
        oColumns = oMatrix.Columns

        'Add Columns to the matrix
        'The # column
        oColumn = oColumns.Add("#", SAPbouiCOM.BoFormItemTypes.it_EDIT)
        oColumn.TitleObject.Caption = "#"
        oColumn.Width = 20
        oColumn.Editable = False

        ' Item Code
        oColumn = oColumns.Add("ItemCode", SAPbouiCOM.BoFormItemTypes.it_COMBO_BOX)
        oColumn.TitleObject.Caption = "Item Code"
        oColumn.Width = 100
        'Add Valid Values
        AddItemsToCombo(oColumn)
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
    Private Sub AddItemsToCombo(ByVal oColumn As SAPbouiCOM.Column)

    End Sub

    Private Sub cmdCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCreate.Click
        DrawForm()
    End Sub
    Private Sub SBO_Application_ItemEvent(ByVal FormUID As String, ByRef pVal As SAPbouiCOM.ItemEvent, ByRef BubbleEvent As Boolean) Handles SBO_Application.ItemEvent
        'Click on Add Row
        If ((FormUID = "MOR1") And (pVal.ItemUID = "AddRow") And (pVal.EventType = SAPbouiCOM.BoEventTypes.et_CLICK) And (pVal.Before_Action = False)) Then
            oMatrix.AddRow(1)
        End If
    End Sub
End Class

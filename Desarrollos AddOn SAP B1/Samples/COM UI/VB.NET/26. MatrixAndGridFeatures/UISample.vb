'//  SAP MANAGE UI API 2007 SDK Sample
'//****************************************************************************
'//
'//  File:      ProgressBar.vb
'//
'//  Copyright (c) SAP MANAGE
'//
'// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
'// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
'// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
'// PARTICULAR PURPOSE.
'//
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

Public Class ProgressBar
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
    Friend WithEvents cmdAddMat As System.Windows.Forms.Button
    Friend WithEvents cmdMatSortable As System.Windows.Forms.Button
    Friend WithEvents cmdMatUnSort As System.Windows.Forms.Button
    Friend WithEvents cmdSort As System.Windows.Forms.Button
    Friend WithEvents cmdSortDesc As System.Windows.Forms.Button
    Friend WithEvents cmdAddGrid As System.Windows.Forms.Button
    Friend WithEvents cmdGridSortable As System.Windows.Forms.Button
    Friend WithEvents cmdGridUnSort As System.Windows.Forms.Button
    Friend WithEvents cmdSortDescGrid As System.Windows.Forms.Button
    Friend WithEvents cmdSortGrid As System.Windows.Forms.Button
    Friend WithEvents cmdExpandGrid As System.Windows.Forms.Button
    Friend WithEvents cmdCollapseGrid As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdSerXML As System.Windows.Forms.Button
    Friend WithEvents txtMatXML As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cmbSerMatXML As System.Windows.Forms.ComboBox
    Friend WithEvents cmdSerXMLGrid As System.Windows.Forms.Button
    Friend WithEvents cmbSerGridXML As System.Windows.Forms.ComboBox
    Friend WithEvents txtGridXML As System.Windows.Forms.TextBox
    Friend WithEvents cmbLoadSerGridXML As System.Windows.Forms.ComboBox
    Friend WithEvents browserHelp As AxSHDocVw.AxWebBrowser
    Friend WithEvents chkSort As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(ProgressBar))
        Me.cmdAddMat = New System.Windows.Forms.Button
        Me.cmdMatSortable = New System.Windows.Forms.Button
        Me.cmdMatUnSort = New System.Windows.Forms.Button
        Me.cmdSort = New System.Windows.Forms.Button
        Me.cmdSortDesc = New System.Windows.Forms.Button
        Me.cmdAddGrid = New System.Windows.Forms.Button
        Me.cmdGridSortable = New System.Windows.Forms.Button
        Me.cmdGridUnSort = New System.Windows.Forms.Button
        Me.cmdSortDescGrid = New System.Windows.Forms.Button
        Me.cmdSortGrid = New System.Windows.Forms.Button
        Me.cmdExpandGrid = New System.Windows.Forms.Button
        Me.cmdCollapseGrid = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdSerXML = New System.Windows.Forms.Button
        Me.txtMatXML = New System.Windows.Forms.TextBox
        Me.txtGridXML = New System.Windows.Forms.TextBox
        Me.cmdSerXMLGrid = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.cmbSerMatXML = New System.Windows.Forms.ComboBox
        Me.cmbSerGridXML = New System.Windows.Forms.ComboBox
        Me.cmbLoadSerGridXML = New System.Windows.Forms.ComboBox
        Me.browserHelp = New AxSHDocVw.AxWebBrowser
        Me.chkSort = New System.Windows.Forms.CheckBox
        CType(Me.browserHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdAddMat
        '
        Me.cmdAddMat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.cmdAddMat.Location = New System.Drawing.Point(16, 88)
        Me.cmdAddMat.Name = "cmdAddMat"
        Me.cmdAddMat.Size = New System.Drawing.Size(224, 40)
        Me.cmdAddMat.TabIndex = 0
        Me.cmdAddMat.Text = "Add Matrix"
        '
        'cmdMatSortable
        '
        Me.cmdMatSortable.Location = New System.Drawing.Point(16, 144)
        Me.cmdMatSortable.Name = "cmdMatSortable"
        Me.cmdMatSortable.Size = New System.Drawing.Size(104, 40)
        Me.cmdMatSortable.TabIndex = 1
        Me.cmdMatSortable.Text = "Make Matrix  columns sortable"
        '
        'cmdMatUnSort
        '
        Me.cmdMatUnSort.Location = New System.Drawing.Point(16, 200)
        Me.cmdMatUnSort.Name = "cmdMatUnSort"
        Me.cmdMatUnSort.Size = New System.Drawing.Size(104, 40)
        Me.cmdMatUnSort.TabIndex = 2
        Me.cmdMatUnSort.Text = "Disable Matrix column sorting"
        '
        'cmdSort
        '
        Me.cmdSort.Location = New System.Drawing.Point(136, 144)
        Me.cmdSort.Name = "cmdSort"
        Me.cmdSort.Size = New System.Drawing.Size(104, 40)
        Me.cmdSort.TabIndex = 3
        Me.cmdSort.Text = "Sort first column Ascending"
        '
        'cmdSortDesc
        '
        Me.cmdSortDesc.Location = New System.Drawing.Point(136, 200)
        Me.cmdSortDesc.Name = "cmdSortDesc"
        Me.cmdSortDesc.Size = New System.Drawing.Size(104, 40)
        Me.cmdSortDesc.TabIndex = 4
        Me.cmdSortDesc.Text = "Sort first column Descending"
        '
        'cmdAddGrid
        '
        Me.cmdAddGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.cmdAddGrid.Location = New System.Drawing.Point(16, 288)
        Me.cmdAddGrid.Name = "cmdAddGrid"
        Me.cmdAddGrid.Size = New System.Drawing.Size(224, 40)
        Me.cmdAddGrid.TabIndex = 5
        Me.cmdAddGrid.Text = "Add Grid"
        '
        'cmdGridSortable
        '
        Me.cmdGridSortable.Location = New System.Drawing.Point(16, 344)
        Me.cmdGridSortable.Name = "cmdGridSortable"
        Me.cmdGridSortable.Size = New System.Drawing.Size(104, 40)
        Me.cmdGridSortable.TabIndex = 6
        Me.cmdGridSortable.Text = "Make Grid columns sortable"
        '
        'cmdGridUnSort
        '
        Me.cmdGridUnSort.Location = New System.Drawing.Point(16, 400)
        Me.cmdGridUnSort.Name = "cmdGridUnSort"
        Me.cmdGridUnSort.Size = New System.Drawing.Size(104, 40)
        Me.cmdGridUnSort.TabIndex = 7
        Me.cmdGridUnSort.Text = "Disable Grid column sorting"
        '
        'cmdSortDescGrid
        '
        Me.cmdSortDescGrid.Location = New System.Drawing.Point(136, 400)
        Me.cmdSortDescGrid.Name = "cmdSortDescGrid"
        Me.cmdSortDescGrid.Size = New System.Drawing.Size(104, 40)
        Me.cmdSortDescGrid.TabIndex = 9
        Me.cmdSortDescGrid.Text = "Sort first column Descending"
        '
        'cmdSortGrid
        '
        Me.cmdSortGrid.Location = New System.Drawing.Point(136, 344)
        Me.cmdSortGrid.Name = "cmdSortGrid"
        Me.cmdSortGrid.Size = New System.Drawing.Size(104, 40)
        Me.cmdSortGrid.TabIndex = 8
        Me.cmdSortGrid.Text = "Sort first column Ascending"
        '
        'cmdExpandGrid
        '
        Me.cmdExpandGrid.Location = New System.Drawing.Point(136, 456)
        Me.cmdExpandGrid.Name = "cmdExpandGrid"
        Me.cmdExpandGrid.Size = New System.Drawing.Size(104, 40)
        Me.cmdExpandGrid.TabIndex = 10
        Me.cmdExpandGrid.Text = "Expand Grid"
        '
        'cmdCollapseGrid
        '
        Me.cmdCollapseGrid.Location = New System.Drawing.Point(16, 456)
        Me.cmdCollapseGrid.Name = "cmdCollapseGrid"
        Me.cmdCollapseGrid.Size = New System.Drawing.Size(104, 40)
        Me.cmdCollapseGrid.TabIndex = 11
        Me.cmdCollapseGrid.Text = "Collapse Grid"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 32)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Matrix and Grid enhancements"
        '
        'cmdSerXML
        '
        Me.cmdSerXML.Location = New System.Drawing.Point(256, 56)
        Me.cmdSerXML.Name = "cmdSerXML"
        Me.cmdSerXML.Size = New System.Drawing.Size(184, 23)
        Me.cmdSerXML.TabIndex = 13
        Me.cmdSerXML.Text = "Serialize Matrix XML -->"
        '
        'txtMatXML
        '
        Me.txtMatXML.Location = New System.Drawing.Point(256, 96)
        Me.txtMatXML.Multiline = True
        Me.txtMatXML.Name = "txtMatXML"
        Me.txtMatXML.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtMatXML.Size = New System.Drawing.Size(328, 152)
        Me.txtMatXML.TabIndex = 14
        Me.txtMatXML.Text = ""
        '
        'txtGridXML
        '
        Me.txtGridXML.Location = New System.Drawing.Point(256, 312)
        Me.txtGridXML.Multiline = True
        Me.txtGridXML.Name = "txtGridXML"
        Me.txtGridXML.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtGridXML.Size = New System.Drawing.Size(336, 152)
        Me.txtGridXML.TabIndex = 16
        Me.txtGridXML.Text = ""
        '
        'cmdSerXMLGrid
        '
        Me.cmdSerXMLGrid.Location = New System.Drawing.Point(256, 280)
        Me.cmdSerXMLGrid.Name = "cmdSerXMLGrid"
        Me.cmdSerXMLGrid.Size = New System.Drawing.Size(184, 23)
        Me.cmdSerXMLGrid.TabIndex = 15
        Me.cmdSerXMLGrid.Text = "Serialize Grid XML -->"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(256, 472)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(184, 23)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "<-- Load Serialized XML to Grid"
        '
        'cmbSerMatXML
        '
        Me.cmbSerMatXML.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSerMatXML.Items.AddRange(New Object() {"Metadata and data", "Metadata"})
        Me.cmbSerMatXML.Location = New System.Drawing.Point(456, 56)
        Me.cmbSerMatXML.Name = "cmbSerMatXML"
        Me.cmbSerMatXML.Size = New System.Drawing.Size(121, 21)
        Me.cmbSerMatXML.TabIndex = 18
        '
        'cmbSerGridXML
        '
        Me.cmbSerGridXML.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSerGridXML.Items.AddRange(New Object() {"Metadata and data", "Metadata", "Data"})
        Me.cmbSerGridXML.Location = New System.Drawing.Point(456, 280)
        Me.cmbSerGridXML.Name = "cmbSerGridXML"
        Me.cmbSerGridXML.Size = New System.Drawing.Size(121, 21)
        Me.cmbSerGridXML.TabIndex = 19
        '
        'cmbLoadSerGridXML
        '
        Me.cmbLoadSerGridXML.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLoadSerGridXML.Items.AddRange(New Object() {"Metadata and data", "Metadata", "Data"})
        Me.cmbLoadSerGridXML.Location = New System.Drawing.Point(456, 472)
        Me.cmbLoadSerGridXML.Name = "cmbLoadSerGridXML"
        Me.cmbLoadSerGridXML.Size = New System.Drawing.Size(121, 21)
        Me.cmbLoadSerGridXML.TabIndex = 20
        '
        'browserHelp
        '
        Me.browserHelp.Enabled = True
        Me.browserHelp.Location = New System.Drawing.Point(16, 512)
        Me.browserHelp.OcxState = CType(resources.GetObject("browserHelp.OcxState"), System.Windows.Forms.AxHost.State)
        Me.browserHelp.Size = New System.Drawing.Size(584, 192)
        Me.browserHelp.TabIndex = 21
        '
        'chkSort
        '
        Me.chkSort.Location = New System.Drawing.Point(16, 248)
        Me.chkSort.Name = "chkSort"
        Me.chkSort.Size = New System.Drawing.Size(144, 24)
        Me.chkSort.TabIndex = 22
        Me.chkSort.Text = "Listen to sort events"
        '
        'ProgressBar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(618, 719)
        Me.Controls.Add(Me.chkSort)
        Me.Controls.Add(Me.browserHelp)
        Me.Controls.Add(Me.cmbLoadSerGridXML)
        Me.Controls.Add(Me.cmbSerGridXML)
        Me.Controls.Add(Me.cmbSerMatXML)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtGridXML)
        Me.Controls.Add(Me.cmdSerXMLGrid)
        Me.Controls.Add(Me.txtMatXML)
        Me.Controls.Add(Me.cmdSerXML)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdCollapseGrid)
        Me.Controls.Add(Me.cmdExpandGrid)
        Me.Controls.Add(Me.cmdSortDescGrid)
        Me.Controls.Add(Me.cmdSortGrid)
        Me.Controls.Add(Me.cmdGridUnSort)
        Me.Controls.Add(Me.cmdGridSortable)
        Me.Controls.Add(Me.cmdAddGrid)
        Me.Controls.Add(Me.cmdSortDesc)
        Me.Controls.Add(Me.cmdSort)
        Me.Controls.Add(Me.cmdMatUnSort)
        Me.Controls.Add(Me.cmdMatSortable)
        Me.Controls.Add(Me.cmdAddMat)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ProgressBar"
        Me.Text = "UI Sample"
        Me.TopMost = True
        CType(Me.browserHelp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private WithEvents SBO_Application As SAPbouiCOM.Application
    Private oForm As SAPbouiCOM.IForm
    Dim oDBDataSource As SAPbouiCOM.DBDataSource
    Dim oDBDataSource1 As SAPbouiCOM.DBDataSource
    Dim oDBDataSource2 As SAPbouiCOM.DBDataSource
    Dim oDBDataSource3 As SAPbouiCOM.DBDataSource
    Dim oItem As SAPbouiCOM.IItem
    Dim oMatrix As SAPbouiCOM.IMatrix
    Dim oColumn As SAPbouiCOM.IColumn

    Dim oGrid As SAPbouiCOM.IGrid
    Dim oDataTable As SAPbouiCOM.IDataTable


    Private Sub ProgressBar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetApplication()
        CreateForm()
        cmbSerMatXML.SelectedIndex = 0
        cmbSerGridXML.SelectedIndex = 0
        cmbLoadSerGridXML.SelectedIndex = 0

        Dim sFilePath As String
        sFilePath = System.Environment.CurrentDirectory()
        sFilePath = sFilePath.Remove(sFilePath.Length - 3, 3)
        sFilePath = sFilePath + "MatrixSerializeAsXML.htm"

        browserHelp.Navigate(sFilePath)

    End Sub

    Private Sub CreateForm()
        Dim olan As SAPbouiCOM.BoLanguages
        olan = SBO_Application.Language

        Dim oFormParams As SAPbouiCOM.IFormCreationParams
        oFormParams = SBO_Application.CreateObject(SAPbouiCOM.BoCreatableObjectType.cot_FormCreationParams)
        oFormParams.FormType = "MyForm"
        oFormParams.UniqueID = "MyForm"

        Try
            oForm = SBO_Application.Forms.AddEx(oFormParams)
        Catch
            oForm = SBO_Application.Forms.Item("MyForm")
            oForm.Close()
            oForm = SBO_Application.Forms.AddEx(oFormParams)
        End Try
        With oForm
            .Top = 50
            .ClientHeight = 600
            .ClientWidth = 400
            .Title = "UI Sample Form"
            .Visible = True
        End With

    End Sub

    Private Sub SetApplication()

        '*******************************************************************
        '// Use an SboGuiApi object to establish the connection
        '// with the application and rturn an initialized appliction object
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

    Private Sub cmdAddMat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddMat.Click
        Dim oColumn As SAPbouiCOM.IColumn
        Dim oLinkButton As SAPbouiCOM.ILinkedButton

        oDBDataSource = oForm.DataSources.DBDataSources.Add("OCRD")
        oDBDataSource1 = oForm.DataSources.DBDataSources.Add("OITM")
        oDBDataSource2 = oForm.DataSources.DBDataSources.Add("OINV")
        oDBDataSource3 = oForm.DataSources.DBDataSources.Add("INV1")


        oItem = oForm.Items.Add("Matrix", SAPbouiCOM.BoFormItemTypes.it_MATRIX)
        oItem.Left = 10
        oItem.Top = 10
        oItem.Height = (oForm.ClientHeight / 2) - 10
        oItem.Width = oForm.ClientWidth - 10

        oMatrix = oItem.Specific

        oMatrix.Layout = SAPbouiCOM.BoMatrixLayoutType.mlt_Normal
        oMatrix.SelectionMode = SAPbouiCOM.BoMatrixSelect.ms_Auto

        oColumn = oMatrix.Columns.Add("col0", SAPbouiCOM.BoFormItemTypes.it_EDIT)
        oColumn.Editable = False
        oColumn.ForeColor = 1
        oColumn.TitleObject.Caption = "#"

        oColumn = oMatrix.Columns.Add("CardCode", SAPbouiCOM.BoFormItemTypes.it_EDIT)
        oColumn.Width = 30
        oColumn.Description = "col1"
        oColumn.TitleObject.Caption = "CardCode"
        oColumn.DisplayDesc = False
        oColumn.DataBind.SetBound(True, "OCRD", "CardCode")

        oColumn = oMatrix.Columns.Add("ItemCode", SAPbouiCOM.BoFormItemTypes.it_EDIT)
        oColumn.Width = 30
        oColumn.Description = "col2"
        oColumn.TitleObject.Caption = "OITM - ItemCode"
        oColumn.DisplayDesc = False
        oColumn.DataBind.SetBound(True, "OITM", "ItemCode")

        oColumn = oMatrix.Columns.Add("DocDate", SAPbouiCOM.BoFormItemTypes.it_EDIT)
        oColumn.Width = 30
        oColumn.Description = "col2"
        oColumn.TitleObject.Caption = "Date"
        oColumn.DisplayDesc = False
        oColumn.DataBind.SetBound(True, "OINV", "DocDate")

        oColumn = oMatrix.Columns.Add("LineTotal", SAPbouiCOM.BoFormItemTypes.it_EDIT)
        oColumn.Width = 30
        oColumn.Description = "col2"
        oColumn.TitleObject.Caption = "Number"
        oColumn.DisplayDesc = False
        oColumn.DataBind.SetBound(True, "INV1", "LineTotal")

        oMatrix.Clear()
        oMatrix.AutoResizeColumns()
        oDBDataSource.Query()
        oDBDataSource1.Query()
        oDBDataSource2.Query()
        oDBDataSource3.Query()

        oMatrix.LoadFromDataSource()

    End Sub

    Private Sub cmdMatSortable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMatSortable.Click
        oMatrix = oForm.Items.Item("Matrix").Specific

        oColumn = oMatrix.Columns.Item("CardCode")
        oColumn.TitleObject.Sortable = True

        oColumn = oMatrix.Columns.Item("ItemCode")
        oColumn.TitleObject.Sortable = True

        oColumn = oMatrix.Columns.Item("DocDate")
        oColumn.TitleObject.Sortable = True

        oColumn = oMatrix.Columns.Item("LineTotal")
        oColumn.TitleObject.Sortable = True

    End Sub

    Private Sub cmdMatUnSort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMatUnSort.Click
        oMatrix = oForm.Items.Item("Matrix").Specific

        oColumn = oMatrix.Columns.Item("CardCode")
        oColumn.TitleObject.Sortable = False

        oColumn = oMatrix.Columns.Item("ItemCode")
        oColumn.TitleObject.Sortable = False

        oColumn = oMatrix.Columns.Item("DocDate")
        oColumn.TitleObject.Sortable = False

        oColumn = oMatrix.Columns.Item("LineTotal")
        oColumn.TitleObject.Sortable = False
    End Sub

    Private Sub cmdSort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSort.Click

        oMatrix = oForm.Items.Item("Matrix").Specific

        oColumn = oMatrix.Columns.Item("CardCode")
        Try
            oColumn.TitleObject.Sort(SAPbouiCOM.BoGridSortType.gst_Ascending)
        Catch ex As Exception
            SBO_Application.MessageBox("Column is unsortable")
        End Try

    End Sub

    Private Sub cmdSortDesc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSortDesc.Click

        oMatrix = oForm.Items.Item("Matrix").Specific

        oColumn = oMatrix.Columns.Item("CardCode")
        Try
            oColumn.TitleObject.Sort(SAPbouiCOM.BoGridSortType.gst_Descending)
        Catch ex As Exception
            SBO_Application.MessageBox("Column is unsortable")
        End Try

    End Sub

    Private Sub cmdAddGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddGrid.Click

        Dim queryStr As String
        Dim oEditColumn As SAPbouiCOM.IEditTextColumn
        Dim oComboColumn As SAPbouiCOM.IComboBoxColumn

        oItem = oForm.Items.Add("MyGrid", SAPbouiCOM.BoFormItemTypes.it_GRID)
        oItem.Left = 10

        oItem.Top = (oForm.ClientHeight / 2)
        oItem.Height = (oForm.ClientHeight / 2) - 10
        oItem.Width = oForm.ClientWidth - 10


        oGrid = oItem.Specific
        oGrid.SelectionMode = SAPbouiCOM.BoMatrixSelect.ms_None
        oDataTable = oForm.DataSources.DataTables.Add("MyDataTable")

        oDataTable.ExecuteQuery("Select CardCode, CardName, DocDate, ExcRefDate from OINV")
        oGrid.DataTable = oDataTable

    End Sub

    Private Sub cmdGridSortable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGridSortable.Click

        oGrid = oForm.Items.Item("MyGrid").Specific

        oGrid.Columns.Item(0).TitleObject.Sortable = True
        oGrid.Columns.Item(1).TitleObject.Sortable = True
        oGrid.Columns.Item(2).TitleObject.Sortable = True
        oGrid.Columns.Item(3).TitleObject.Sortable = True

    End Sub

    Private Sub cmdGridUnSort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGridUnSort.Click

        oGrid = oForm.Items.Item("MyGrid").Specific

        oGrid.Columns.Item(0).TitleObject.Sortable = False
        oGrid.Columns.Item(1).TitleObject.Sortable = False
        oGrid.Columns.Item(2).TitleObject.Sortable = False
        oGrid.Columns.Item(3).TitleObject.Sortable = False

    End Sub

    Private Sub cmdSortGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSortGrid.Click
        oGrid = oForm.Items.Item("MyGrid").Specific
        Try
            oGrid.Columns.Item(0).TitleObject.Sort(SAPbouiCOM.BoGridSortType.gst_Ascending)
    
        Catch ex As Exception
            If oGrid.Columns.Item(0).TitleObject.Sortable = True Then
                SBO_Application.MessageBox("Cannot sort when grid is collapsed")
            Else
                SBO_Application.MessageBox("Column is unsortable")
            End If
        End Try
    End Sub

    Private Sub cmdSortDescGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSortDescGrid.Click
        oGrid = oForm.Items.Item("MyGrid").Specific
        Try
            oGrid.Columns.Item(0).TitleObject.Sort(SAPbouiCOM.BoGridSortType.gst_Descending)
        Catch ex As Exception
            If oGrid.Columns.Item(0).TitleObject.Sortable = True Then
                SBO_Application.MessageBox("Cannot sort when grid is collapsed")
            Else
                SBO_Application.MessageBox("Column is unsortable")
            End If
        End Try

    End Sub

    Private Sub cmdCollapseGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCollapseGrid.Click
        oGrid = oForm.Items.Item("MyGrid").Specific
        oGrid.CollapseLevel = 1
    End Sub

    Private Sub cmdExpandGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExpandGrid.Click
        oGrid = oForm.Items.Item("MyGrid").Specific
        oGrid.CollapseLevel = 0
    End Sub

    Private Sub cmdSerXML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSerXML.Click
        Try
            Dim sXML As String

            oMatrix = oForm.Items.Item("Matrix").Specific

            If cmbSerMatXML.SelectedIndex = 0 Then
                sXML = oMatrix.SerializeAsXML(SAPbouiCOM.BoMatrixXmlSelect.mxs_All)
            Else
                sXML = oMatrix.SerializeAsXML(SAPbouiCOM.BoMatrixXmlSelect.mxs_MetaData)
            End If

            txtMatXML.Text = sXML

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub cmdSerXMLGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSerXMLGrid.Click
        Try
            Dim sXML As String

            oGrid = oForm.Items.Item("MyGrid").Specific

            If cmbSerGridXML.SelectedIndex = 0 Then
                sXML = oGrid.DataTable.SerializeAsXML(SAPbouiCOM.BoDataTableXmlSelect.dxs_All)
            ElseIf cmbSerGridXML.SelectedIndex = 1 Then
                sXML = oGrid.DataTable.SerializeAsXML(SAPbouiCOM.BoDataTableXmlSelect.dxs_MetaData)
            Else
                sXML = oGrid.DataTable.SerializeAsXML(SAPbouiCOM.BoDataTableXmlSelect.dxs_DataOnly)
            End If

            txtGridXML.Text = sXML

        Catch ex As Exception

            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim sXML As String

            oGrid = oForm.Items.Item("MyGrid").Specific
            sXML = txtGridXML.Text

            If cmbLoadSerGridXML.SelectedIndex = 0 Then
                oGrid.DataTable.LoadSerializedXML(SAPbouiCOM.BoDataTableXmlSelect.dxs_All, sXML)
            ElseIf cmbLoadSerGridXML.SelectedIndex = 1 Then
                oGrid.DataTable.LoadSerializedXML(SAPbouiCOM.BoDataTableXmlSelect.dxs_MetaData, sXML)
            Else
                oGrid.DataTable.LoadSerializedXML(SAPbouiCOM.BoDataTableXmlSelect.dxs_DataOnly, sXML)
            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub SBO_Application_ItemEvent(ByVal FormUID As String, ByRef pVal As SAPbouiCOM.ItemEvent, ByRef BubbleEvent As Boolean) Handles SBO_Application.ItemEvent
        If (chkSort.Checked = True) And _
        (pVal.EventType = SAPbouiCOM.BoEventTypes.et_Grid_Sort) And _
        (pVal.Before_Action = True) Then
            SBO_Application.MessageBox("Sort event was fired.")
        End If
    End Sub

End Class




'//  SAP MANAGE UI API 2007 SDK Sample
'//****************************************************************************
'//
'//  File:      Blanket.vb
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

Public Class Blanket

    Private WithEvents SBO_Application As SAPbouiCOM.Application ' UI application
    Private oCompany As SAPbobsCOM.Company      ' DI application


    '**********************************************************
    ' declaring an Event filters container object and an
    ' event filter object
    '**********************************************************

    Public oFilters As SAPbouiCOM.EventFilters
    Public oFilter As SAPbouiCOM.EventFilter

    Private oMatrix As SAPbouiCOM.Matrix        ' Global variable to handle matrixes
    ' Variables for Blanket Agreement UI form
    Private cmbBPCode As SAPbouiCOM.ComboBox    ' Global variable for the BP Code
    Private txtBPName As SAPbouiCOM.EditText    ' Global variable for the BP Code
    Private colItemCode As SAPbouiCOM.Column    ' Global variable for the Item Code
    Private colItemName As SAPbouiCOM.Column    ' Global variable for the Item Name
    Private colItemPrice As SAPbouiCOM.Column   ' Global variable for the Item Price
    Private colItemQuan As SAPbouiCOM.Column    ' Global variable for the Item Quantity
    Private colInitQuan As SAPbouiCOM.Column    ' Global variable for the Item Initial Quantity
    Private colItemTotal As SAPbouiCOM.Column   ' Global variable for the Item Total
    Private oDocTotal As SAPbouiCOM.EditText    ' Global variable for the Blanket Total

    Private AddStarted As Boolean                ' Flag that indicates "Add" process started
    Private RedFlag As Boolean                   ' RedFlag when true indicates an error during "Add" process
    Private InvOk As Boolean                     ' Indicates that an invoice can be withdrawn from blanket agreement
    Private RowNum As Integer                    ' Row Number in a matrix
    Private ItemCodes() As String                ' Array to render Item Codes
    Private ItemQuantities() As Double           ' Array to render Item Quantities
    Private oEditBPCode As SAPbouiCOM.EditText   ' Global variable for the BP code edit text
    Private oEditPostDate As SAPbouiCOM.EditText ' Global variable for the Post Date edit text
    Private strEditBPCode As String              ' Global variable for the BP code edit text string value
    Private strEditPostDate As String            ' Global variable for the Post Date edit text string value
    Private IsNewItem As Boolean                 ' Indicates if you added a new item to invoice/quotation/order

#Region "Single Sign On"
    Private Sub SetApplication()
        AddStarted = False
        RedFlag = False

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

    Private Function SetConnectionContext() As Integer

        Dim sCookie As String
        Dim sConnectionContext As String
        Dim lRetCode As Integer

        Try
            '// First initialize the Company object

            oCompany = New SAPbobsCOM.Company

            '// Acquire the connection context cookie from the DI API.
            sCookie = oCompany.GetContextCookie

            '// Retrieve the connection context string from the UI API using the
            '// acquired cookie.
            sConnectionContext = SBO_Application.Company.GetConnectionContext(sCookie)

            '// before setting the SBO Login Context make sure the company is not
            '// connected

            If oCompany.Connected = True Then
                oCompany.Disconnect()
            End If

            '// Set the connection context information to the DI API.
            SetConnectionContext = oCompany.SetSboLoginContext(sConnectionContext)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Private Function ConnectToCompany() As Integer

        '// Establish the connection to the company database.
        ConnectToCompany = oCompany.Connect

    End Function

    Private Sub Class_Init()

        '//*************************************************************
        '// set SBO_Application with an initialized application object
        '//*************************************************************

        SetApplication()

        '//*************************************************************
        '// Set The Connection Context
        '//*************************************************************

        If Not SetConnectionContext() = 0 Then
            SBO_Application.MessageBox("Failed setting a connection to DI API")
            End ' Terminating the Add-On Application
        End If


        '//*************************************************************
        '// Connect To The Company Data Base
        '//*************************************************************

        If Not ConnectToCompany() = 0 Then
            SBO_Application.MessageBox("Failed connecting to the company's Data Base")
            End ' Terminating the Add-On Application
        End If

        '//*************************************************************
        '// send an "hello world" message
        '//*************************************************************

        SBO_Application.MessageBox("DI Connected To: " & oCompany.CompanyName & vbNewLine & "Add-on is loaded")

    End Sub
#End Region

    Public Sub New()
        MyBase.New()
        Class_Init()
        AddMenuItems()
        SetFilters()
    End Sub

    Private Sub SetFilters()

        '// Create a new EventFilters object
        oFilters = New SAPbouiCOM.EventFilters

        '// add an event type to the container
        '// this method returns an EventFilter object
        oFilter = oFilters.Add(SAPbouiCOM.BoEventTypes.et_ITEM_PRESSED)
        oFilter = oFilters.Add(SAPbouiCOM.BoEventTypes.et_COMBO_SELECT)
        oFilter = oFilters.Add(SAPbouiCOM.BoEventTypes.et_VALIDATE)
        oFilter = oFilters.Add(SAPbouiCOM.BoEventTypes.et_LOST_FOCUS)
        oFilter = oFilters.Add(SAPbouiCOM.BoEventTypes.et_KEY_DOWN)
        oFilter = oFilters.Add(SAPbouiCOM.BoEventTypes.et_MENU_CLICK)
        oFilter = oFilters.Add(SAPbouiCOM.BoEventTypes.et_CLICK)

        '// assign the form type on which the event would be processed
        oFilter.AddEx("149") 'Quotation Form
        oFilter.AddEx("139") 'Orders Form
        oFilter.AddEx("133") 'Invoice Form
        oFilter.AddEx("169") 'Main Menu

        SBO_Application.SetFilter(oFilters)

    End Sub

    ' This procedure adds a new Blanket Agreement form to the SBO UI
    Private Sub DrawForm()
        Dim oForm As SAPbouiCOM.Form               ' The new form
        Dim oItem As SAPbouiCOM.Item               ' An item on the new form
        Dim oCombo As SAPbouiCOM.ComboBox          ' Combo box item for the BP code and Item code
        Dim oEditText As SAPbouiCOM.EditText
        Dim oColumns As SAPbouiCOM.Columns         ' The Columns collection on the matrix
        Dim oStaticText As SAPbouiCOM.StaticText
        Dim oComboBox As SAPbouiCOM.ComboBox

        Try

            LoadFromXML("blanket.srf")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        oForm = SBO_Application.Forms.Item("FBLK")

        ' Add Edit Items

        ' BP Code
        oItem = oForm.Items.Item("txtCode")
        cmbBPCode = oItem.Specific
        AddBPCodeCombo(cmbBPCode)

        ' BP Name
        oItem = oForm.Items.Item("txtName")
        txtBPName = oItem.Specific

        ' Doc Total
        oItem = oForm.Items.Item("txtTotal")
        oDocTotal = oItem.Specific

        ' Add a matrix
        oItem = oForm.Items.Item("mat")

        oMatrix = oItem.Specific
        oColumns = oMatrix.Columns

        ' Item Code
        colItemCode = oColumns.Item("ItemCode")
        colItemName = oColumns.Item("ItemName")
        colItemPrice = oColumns.Item("ItemPrice")
        colItemQuan = oColumns.Item("ItemQuan")
        colInitQuan = oColumns.Item("InitQuan")
        colItemTotal = oColumns.Item("ItemTotal")

        'Add Valid Values
        AddItemsToCombo(colItemCode)
        oMatrix.AddRow()

    End Sub

    ' This procedure adds all the items codes and names
    Private Sub AddItemsToCombo(ByVal oColumn As SAPbouiCOM.Column)
        Dim RS As SAPbobsCOM.Recordset
        Dim Bob As SAPbobsCOM.SBObob

        RS = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        Bob = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoBridge)

        RS = Bob.GetItemList

        RS.MoveFirst()
        While RS.EoF = False
            oColumn.ValidValues.Add(RS.Fields.Item("ItemCode").Value, RS.Fields.Item("ItemName").Value)
            RS.MoveNext()
        End While
    End Sub

    ' This procedure adds all the business partners codes and names
    Private Sub AddBPCodeCombo(ByVal oCombo As SAPbouiCOM.ComboBox)
        Dim RS As SAPbobsCOM.Recordset
        Dim Bob As SAPbobsCOM.SBObob

        RS = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)

        RS.DoQuery("SELECT CardCode,CardName FROM OCRD WHERE CardType='C' ORDER BY CardCode")

        RS.MoveFirst()
        While RS.EoF = False
            oCombo.ValidValues.Add(RS.Fields.Item("CardCode").Value, RS.Fields.Item("CardName").Value)
            RS.MoveNext()
        End While
    End Sub

    ' This procedure adds a new menu item under the "Sales" menu
    Private Sub AddMenuItems()
        Dim oMenus As SAPbouiCOM.Menus          ' The menus collection
        Dim oMenuItem As SAPbouiCOM.MenuItem    ' The new menu item

        ' Get the menus collection from the application
        oMenus = SBO_Application.Menus

        Dim oCreationPackage As SAPbouiCOM.MenuCreationParams

        oCreationPackage = SBO_Application.CreateObject(SAPbouiCOM.BoCreatableObjectType.cot_MenuCreationParams)

        oMenuItem = SBO_Application.Menus.Item("2048") ' Sales menu ID
        oMenus = oMenuItem.SubMenus

        ' New menu parameters
        oCreationPackage.Type = SAPbouiCOM.BoMenuType.mt_STRING
        oCreationPackage.UniqueID = "mnuBlanket"
        oCreationPackage.String = "Blanket Agreement"
        oCreationPackage.Enabled = True
        oCreationPackage.Position = 15

        Try ' If the manu already exists this code will fail
            oMenus.AddEx(oCreationPackage)
        Catch er As Exception ' Menu already exists
            SBO_Application.MessageBox("Menu Already Exists")
        End Try

    End Sub

    ' This procedure handles the folowing events:
    '   1. Events of the Blanket Agreement form
    '   2. Events for forms 133 - A\R Invoice, 139 - Order, 149 - Sales Quotation
    '   3. Pressing "Add" in the invoice form - 133
    Private Sub SBO_Application_ItemEvent(ByVal FormUID As String, ByRef pVal As SAPbouiCOM.ItemEvent, ByRef BubbleEvent As Boolean) Handles SBO_Application.ItemEvent
        Try
            ' Events of the Blanket Agreement form
            If (FormUID = "FBLK") Then
                If (pVal.Before_Action = False) Then

                    ' Click on Add Row
                    If (pVal.ItemUID = "AddRow") And (pVal.EventType = SAPbouiCOM.BoEventTypes.et_ITEM_PRESSED) Then
                        Dim f As SAPbouiCOM.Form
                        Dim oMatrix As SAPbouiCOM.Matrix
                        f = SBO_Application.Forms.Item(FormUID)
                        oMatrix = f.Items.Item("mat").Specific
                        f.DataSources.DBDataSources.Item(1).Clear()
                        oMatrix.AddRow(1)
                    End If

                    ' After selecting a BP Code from the combo box
                    If (pVal.ItemUID = "txtCode") And (pVal.EventType = SAPbouiCOM.BoEventTypes.et_COMBO_SELECT) Then
                        txtBPName.Value = cmbBPCode.Selected.Description
                    End If

                    ' After selecting an item from the combo box
                    If (pVal.ItemUID = "mat") And (pVal.ColUID = "ItemCode") And (pVal.EventType = SAPbouiCOM.BoEventTypes.et_COMBO_SELECT) Then

                        Dim oEdit As SAPbouiCOM.EditText
                        Dim oCombo As SAPbouiCOM.ComboBox

                        oCombo = colItemCode.Cells.Item(pVal.Row).Specific
                        oEdit = colItemName.Cells.Item(pVal.Row).Specific
                        oEdit.Value = oCombo.Selected.Description
                    End If

                    ' After changing the item quantity
                    If (pVal.ItemUID = "mat") And (pVal.ColUID = "ItemQuan") And (pVal.EventType = SAPbouiCOM.BoEventTypes.et_VALIDATE) Then
                        Dim oEditPrice As SAPbouiCOM.EditText   ' Item Price
                        Dim oEditQuan As SAPbouiCOM.EditText    ' Item Quantity
                        Dim oInitQuan As SAPbouiCOM.EditText    ' Item Initial Quantity
                        Dim oEditTotal As SAPbouiCOM.EditText   ' Total = Item Price * Item Quantity

                        ' Get the items from the matrix
                        oEditPrice = colItemPrice.Cells.Item(pVal.Row).Specific
                        oEditQuan = colItemQuan.Cells.Item(pVal.Row).Specific
                        oInitQuan = colInitQuan.Cells.Item(pVal.Row).Specific
                        oEditTotal = colItemTotal.Cells.Item(pVal.Row).Specific

                        ' Copy the value to the Initial sum
                        Dim tmpInt As Integer
                        tmpInt = CInt(oEditQuan.Value)
                        oInitQuan.Value = tmpInt

                        ' Calc the total column
                        Dim tmpTotal As Integer ' temp variable to contain total result
                        tmpTotal = CInt(oEditPrice.Value) * CInt(oEditQuan.Value)
                        oEditTotal.Value = CInt(tmpTotal)

                        ' Calc the document total

                        Dim CalcTotal As Double
                        Dim i As Integer

                        CalcTotal = 0
                        ' Iterate all the matrix rows
                        For i = 1 To oMatrix.RowCount
                            oEditTotal = colItemTotal.Cells.Item(i).Specific
                            CalcTotal += oEditTotal.Value
                        Next
                        oDocTotal.Value = CalcTotal
                    End If
                End If
            End If

            ' Events for forms 133 - A\R Invoice, 139 - Order, 149 - Sales Quotation
            If (pVal.FormType = 133) Or (pVal.FormType = 139) Or (pVal.FormType = 149) Then
                If (pVal.Before_Action = False) Then

                    ' Check If the user changed the "In Blanket" to "No"/"Yes"
                    If (pVal.ItemUID = "38") And _
                        ((pVal.ColUID = "1") Or (pVal.ColUID = "3") Or (pVal.ColUID = "11")) _
                        And (pVal.EventType = SAPbouiCOM.BoEventTypes.et_ITEM_PRESSED) Then
                        Dim colCode As SAPbouiCOM.Column            ' Item Code column
                        Dim mSales As SAPbouiCOM.Matrix             ' Sales matrix
                        Dim oEditItmCode As SAPbouiCOM.EditText     ' Item Code text edit
                        Dim fSales As SAPbouiCOM.Form               ' Sales Form

                        ' Get the form
                        fSales = SBO_Application.Forms.Item(FormUID)
                        ' Get the Item code column
                        mSales = fSales.Items.Item("38").Specific ' The items matrix
                        colCode = mSales.Columns.Item("1")
                        oEditItmCode = colCode.Cells.Item(pVal.Row).Specific
                        If oEditItmCode.Value = "" Then
                            IsNewItem = True
                        Else
                            IsNewItem = False
                        End If
                    End If

                    ' Check it the current BP and the selected item are in a blanket agreement.
                    ' If so, change the price accordingly
                    If (pVal.ItemUID = "38") And (pVal.ColUID = "1") _
                        And (pVal.EventType = SAPbouiCOM.BoEventTypes.et_LOST_FOCUS) And (IsNewItem) Then

                        Dim colCode As SAPbouiCOM.Column            ' Item Code column
                        Dim colQuan As SAPbouiCOM.Column            ' Item Quantity column
                        Dim colBlk As SAPbouiCOM.Column             ' Blanket (Y/N) column
                        Dim colPrice As SAPbouiCOM.Column           ' Item Price column
                        Dim mSales As SAPbouiCOM.Matrix             ' Sales matrix
                        Dim fSales As SAPbouiCOM.Form               ' Sales Form

                        ' Document Lines variables
                        Dim oEditItmCode As SAPbouiCOM.EditText     ' Item Code text edit
                        Dim oEditItmPrice As SAPbouiCOM.EditText    ' Item Price text edit
                        Dim oEditItmQuan As SAPbouiCOM.EditText     ' Item Quantity text edit

                        ' Document variables
                        Dim cmbInBlanket As SAPbouiCOM.ComboBox     ' In blanket Combo box
                        Dim oEditBPCode As SAPbouiCOM.EditText      ' BP Code text edit
                        Dim oEditPostDate As SAPbouiCOM.EditText    ' Post Date text edit

                        Try
                            ' Get the sales form
                            fSales = SBO_Application.Forms.Item(FormUID)

                            ' Get Posting date
                            oEditPostDate = fSales.Items.Item("10").Specific
                            ' Get the BP Code
                            oEditBPCode = fSales.Items.Item("4").Specific
                            strEditBPCode = oEditBPCode.Value

                            ' Get the Item code column
                            mSales = fSales.Items.Item("38").Specific ' The items matrix
                            colCode = mSales.Columns.Item("1")
                            oEditItmCode = colCode.Cells.Item(pVal.Row).Specific

                            ' Get the Quantity column
                            colQuan = mSales.Columns.Item("11")
                            oEditItmQuan = colQuan.Cells.Item(pVal.Row).Specific

                            ' Get the Blanket Agreement (Y/N) column
                            colBlk = mSales.Columns.Item("U_blanket")
                            cmbInBlanket = colBlk.Cells.Item(pVal.Row).Specific

                            Dim newPrice As Double ' The new price, if exists. -1 if no new price
                            newPrice = CheckBlanketPrice(strEditBPCode, oEditItmCode.Value, oEditPostDate.Value, oEditItmQuan.Value)

                            ' If a new price exists for this item
                            If newPrice <> -1 Then

                                ' Change Price
                                colPrice = mSales.Columns.Item("17")
                                oEditItmPrice = colPrice.Cells.Item(pVal.Row).Specific
                                oEditItmPrice.Value = newPrice.ToString

                                ' If the current row suppose to withdraw from a blanket agreement
                                If cmbInBlanket.Selected.Value <> "Y" Then
                                    ' Change to 'Y'
                                    cmbInBlanket.Select("Y")
                                    ' Tell the user a new price has been set
                                    SBO_Application.MessageBox("Item " & oEditItmCode.Value & _
                                    " is in a blanket agreement with " & strEditBPCode & "." & vbCrLf & _
                                    "It's price was updated to " & newPrice.ToString & ".")
                                End If
                            End If ' End if a new price exists for this item


                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try
                    End If ' End the event et_LOST_FOCUS in some matrix columns
                End If ' End pVal.Before_Action = False
            End If ' End Handling events for forms 133 - A\R Invoice, 139 - Order, 149 - Sales Quotation


            ' The Add button on the Invoice form is pressed
            If (pVal.FormType = 133) And (pVal.ItemUID = 1) And (pVal.FormMode = 3) And _
               (pVal.EventType = SAPbouiCOM.BoEventTypes.et_ITEM_PRESSED) Then
                AddStarted = True
                'SBO_Application.MessageBox("Do blanket update")

                ' Get the BP code
                ' Get the Item code column
                Dim mInv As SAPbouiCOM.Matrix       ' The Matrix
                Dim colCode As SAPbouiCOM.Column    ' The Item Code Column
                Dim colQuan As SAPbouiCOM.Column    ' The Quantity Column
                Dim colBlk As SAPbouiCOM.Column     ' The Blanket Agreement Column
                Dim fInv As SAPbouiCOM.Form         ' The invoice form

                Dim oItemCode As SAPbouiCOM.EditText        ' Item code edit text
                Dim oQuan As SAPbouiCOM.EditText            ' 
                Dim cmbInBlanket As SAPbouiCOM.ComboBox     '

                Dim i As Integer
                ' Form elements
                Dim DPost As Date

                If (pVal.Before_Action) Then

                    fInv = SBO_Application.Forms.Item(FormUID)
                    mInv = fInv.Items.Item("38").Specific ' The items matrix
                    RowNum = mInv.RowCount
                    ReDim ItemCodes(RowNum)
                    ReDim ItemQuantities(RowNum)
                    ' Zero the arrays
                    For i = 0 To RowNum - 1
                        ItemCodes(i) = ""
                        ItemQuantities(i) = 0
                    Next

                    'Get Posting date
                    oEditPostDate = fInv.Items.Item("10").Specific
                    'Get the BP Code
                    oEditBPCode = fInv.Items.Item("4").Specific
                    strEditBPCode = oEditBPCode.Value
                    DPost = (CStr(oEditPostDate.Value).Substring(4, 2) & "/" & CStr(oEditPostDate.Value).Substring(2, 2) & "/" & CStr(oEditPostDate.Value).Substring(0, 4))

                    colCode = mInv.Columns.Item("1") ' The Item Code Column
                    colQuan = mInv.Columns.Item("11") ' The Quantity Column
                    colBlk = mInv.Columns.Item("U_blanket") ' The Blanket Agreement Column

                    For i = 1 To RowNum - 1
                        oItemCode = colCode.Cells.Item(i).Specific
                        oQuan = colQuan.Cells.Item(i).Specific
                        cmbInBlanket = colBlk.Cells.Item(i).Specific

                        Dim IsAdded As Boolean
                        IsAdded = False

                        If cmbInBlanket.Selected.Value = "Y" Then
                            Dim j As Integer
                            ' Go through the local arrays
                            For j = 0 To RowNum - 1
                                If ItemCodes(j) = oItemCode.Value Then
                                    ItemQuantities(j) += oQuan.Value
                                    IsAdded = True
                                    Exit For
                                End If
                            Next
                            If IsAdded = False Then
                                ' Go through the local arrays
                                For j = 0 To RowNum - 1
                                    If ItemCodes(j) = "" Then
                                        ItemCodes(j) = oItemCode.Value
                                        ItemQuantities(j) = oQuan.Value
                                        IsAdded = True
                                        Exit For
                                    End If
                                Next
                            End If
                        End If
                    Next i
                    ' Finished going all the matrix rows

                    Dim Res As Double

                    InvOk = True
                    For i = 0 To RowNum - 1
                        If ItemCodes(i) <> "" Then
                            'SBO_Application.MessageBox(ItemCodes(i))
                            Res = CheckBlanketPrice(oEditBPCode.Value, ItemCodes(i), oEditPostDate.Value, ItemQuantities(i))
                            If Res = -1 Then
                                InvOk = False
                                Exit For
                            End If
                        End If
                    Next

                    'SBO_Application.MessageBox("IF")

                Else
                    'SBO_Application.MessageBox("else")
                    If RedFlag = False Then
                        If InvOk Then
                            For i = 0 To RowNum - 1
                                If ItemCodes(i) <> "" Then
                                    WithdrawFromBlanket(strEditBPCode, ItemCodes(i), oEditPostDate.Value, ItemQuantities(i))
                                    RefreshBlanketForm()
                                End If
                            Next
                        Else
                            BubbleEvent = False
                        End If
                    Else
                        SBO_Application.MessageBox("Withdraw from blanket agreement was canceled")
                        RedFlag = False
                    End If
                    AddStarted = False
                End If
            End If
            If pVal.ItemUID = 2 And pVal.FormType = 0 And AddStarted Then
                If AddStarted = True Then
                    RedFlag = True
                End If
            End If

        Catch ex As Exception
            If (ex.Message.StartsWith("Cast from") = False) Then
                MessageBox.Show(ex.Message)
            End If
        End Try
    End Sub

    Private Sub SBO_Application_MenuEvent(ByRef pVal As SAPbouiCOM.MenuEvent, ByRef BubbleEvent As Boolean) Handles SBO_Application.MenuEvent
        If (pVal.MenuUID = "mnuBlanket") And (pVal.BeforeAction = False) Then
            Try
                Dim f As SAPbouiCOM.Form

                f = SBO_Application.Forms.Item("FBLK")
                f.Select()
            Catch ex As Exception
                DrawForm()
            End Try
        End If
    End Sub
    ' This function will return an item new price if a blanket agreement exist for it, and -1 if not
    Public Function CheckBlanketPrice(ByVal BPCode As String, ByVal ItemCode As String, ByVal PostDate As String, ByVal Quantity As Double) As Double

        CheckBlanketPrice = -1

        'Find if there's a blanket agreement for this BP on this item in this date
        Dim sSQL As String
        sSQL = "SELECT U_ItemCode,DocEntry,U_Price,U_Quan FROM [@SM_BLK1] WHERE U_ItemCode = '" & ItemCode & "'"

        Dim oLineRec As SAPbobsCOM.Recordset
        Dim oDocRec As SAPbobsCOM.Recordset
        Dim DocNum As String

        oLineRec = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        oDocRec = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        Try
            oLineRec.DoQuery(sSQL)
            'SBO_Application.MessageBox("Line: " & sSQL)

        Catch ex As Exception
            MessageBox.Show(sSQL)
            'MessageBox.Show(ex.Message)
        End Try

        If oLineRec.RecordCount > 0 Then
            oLineRec.MoveFirst()

            DocNum = CStr(oLineRec.Fields.Item(1).Value)
            sSQL = "SELECT U_BPCode,DocEntry,U_StartDT,U_EndDT,U_Status FROM [@SM_OBLK] WHERE (DocEntry = " & DocNum & ") AND (U_BPCode = '" & BPCode & "')"
            'SBO_Application.MessageBox(sSQL)
            Try
                oDocRec.DoQuery(sSQL)
                'SBO_Application.MessageBox(oDocRec.RecordCount)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            While ((oDocRec.RecordCount <= 0) And (oLineRec.EoF = False))
                'SBO_Application.MessageBox("In While")
                oLineRec.MoveNext()
                DocNum = CStr(oLineRec.Fields.Item(1).Value)
                sSQL = "SELECT U_BPCode,DocEntry,U_StartDT,U_EndDT,U_Status FROM [@SM_OBLK] WHERE (DocEntry = " & DocNum & ") AND (U_BPCode = '" & BPCode & "')"
                'SBO_Application.MessageBox(sSQL)
                Try
                    oDocRec.DoQuery(sSQL)
                    'SBO_Application.MessageBox(oDocRec.RecordCount)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                'SBO_Application.MessageBox("out While")
            End While

            If oDocRec.RecordCount > 0 Then
                oDocRec.MoveFirst()
                Dim DStart As Date
                Dim DEnd As Date
                Dim DPost As Date
                Dim SPost As String
                Dim Quan As Double
                Dim Status As String

                DStart = oDocRec.Fields.Item("U_StartDT").Value
                DEnd = oDocRec.Fields.Item("U_EndDT").Value
                Status = oDocRec.Fields.Item("U_Status").Value
                Quan = oLineRec.Fields.Item("U_Quan").Value

                SPost = PostDate.Substring(4, 2) & "/"
                SPost += PostDate.Substring(2, 2) & "/"
                SPost += PostDate.Substring(0, 4)
                DPost = SPost
                'Check that the blanket agreement date is valid
                If Status = "Active" Then
                    If (DStart <= DPost) And (DEnd >= DPost) Then
                        If Quan >= Quantity Then
                            CheckBlanketPrice = oLineRec.Fields.Item(2).Value
                        Else
                            SBO_Application.MessageBox("Item " & ItemCode & " Max quantity can be " & Quan)
                        End If
                    End If
                End If
            End If
        End If
    End Function
    Private Sub WithdrawFromBlanket(ByVal BPCode As String, ByVal ItemCode As String, ByVal PostDate As String, ByVal Quantity As Double)
        Dim SPost As String
        Dim DPost As Date
        SPost = PostDate.Substring(4, 2) & "/"
        SPost += PostDate.Substring(2, 2) & "/"
        SPost += PostDate.Substring(0, 4)
        DPost = SPost

        'Find if there's a blanket agreement for this BP on this item in this date
        Dim sSQL As String
        sSQL = "SELECT U_ItemCode,DocEntry,U_Price,U_Quan FROM [@SM_BLK1] WHERE U_ItemCode = '" & ItemCode & "'"

        Dim oLineRec As SAPbobsCOM.Recordset
        Dim oDocRec As SAPbobsCOM.Recordset
        Dim DocNum As String

        oLineRec = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        oDocRec = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        Try
            'SBO_Application.messageBox(sSQL)
            oLineRec.DoQuery(sSQL)

        Catch ex As Exception
            MessageBox.Show(sSQL)
            MessageBox.Show(ex.Message)
        End Try

        If oLineRec.RecordCount() > 0 Then
            oLineRec.MoveFirst()
            Do
                DocNum = CStr(oLineRec.Fields.Item(1).Value)
                sSQL = "SELECT U_BPCode,DocEntry,U_StartDT,U_EndDT FROM [@SM_OBLK] WHERE (DocEntry = " & DocNum & ") AND (U_BPCode = '" & BPCode & "')"
                'SBO_Application.messageBox(sSQL)
                Try
                    oDocRec.DoQuery(sSQL)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                If oDocRec.RecordCount = 0 Then
                    oLineRec.MoveNext()
                End If
            Loop Until ((oDocRec.RecordCount > 0) Or (oLineRec.EoF))

            If oDocRec.RecordCount > 0 Then
                sSQL = "UPDATE [@SM_BLK1] SET U_Quan = U_Quan - " & Quantity & " WHERE (DocEntry = " & DocNum & ") AND (U_ItemCode = '" & ItemCode & "')"
                Dim UpdateRec As SAPbobsCOM.Recordset
                UpdateRec = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
                UpdateRec.DoQuery(sSQL)
            End If
        End If

    End Sub

    Private Sub SBO_Application_StatusBarEvent(ByVal Text As String, ByVal MessageType As SAPbouiCOM.BoStatusBarMessageType) Handles SBO_Application.StatusBarEvent
        If MessageType = SAPbouiCOM.BoStatusBarMessageType.smt_Error _
        And AddStarted = True Then
            RedFlag = True
        End If
    End Sub
    Private Sub SaveAsXML(ByRef Form As SAPbouiCOM.Form)

        Dim oXmlDoc As Xml.XmlDocument
        Dim sXmlString As String

        oXmlDoc = New Xml.XmlDocument

        '// get the form as an XML string
        sXmlString = Form.GetAsXML

        '// load the form's XML string to the
        '// XML document object
        oXmlDoc.LoadXml(sXmlString)

        Dim sPath As String

        sPath = IO.Directory.GetParent(Application.StartupPath).ToString

        '// save the XML Document
        oXmlDoc.Save((sPath & "\MySimpleForm.xml"))

    End Sub

    Private Sub LoadFromXML(ByRef FileName As String)

        Dim oXmlDoc As Xml.XmlDocument

        oXmlDoc = New Xml.XmlDocument

        '// load the content of the XML File
        Dim sPath As String

        sPath = IO.Directory.GetParent(Application.StartupPath).ToString

        oXmlDoc.Load(sPath & "\" & FileName)

        '// load the form to the SBO application in one batch
        SBO_Application.LoadBatchActions(oXmlDoc.InnerXml)

    End Sub

    Private Sub RefreshBlanketForm()
        Try
            Dim f As SAPbouiCOM.Form

            f = SBO_Application.Forms.Item("FBLK")
            f.Refresh()
        Catch ex As Exception
        End Try
    End Sub
End Class

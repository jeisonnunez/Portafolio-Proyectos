'//  SAP MANAGE UIDI API 2007 SDK Sample
'//**************************************************************************************************
'//
'//  File:      AddColumn.vb
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
'// 2. Add reference to the "SAP Business One Objects Bridge VERSION 2007"
'// 3. Insert the development connection string to the "Command Line Argument"
'//-----------------------------------------------------------------
'// 1.
'//    a. Project->References
'//    b. check the "SAP Business One UI API Version 2007" check box
'//    c. check the "SAP Business One DI API Version 2007" check box
'//
'// 2.
'//     a. Project->Properties
'//     b. choose 'Make' tab folder
'//     c. place the following connection string in the 'Command Line Arguments' field
'// 0030002C0030002C00530041005000420044005F00440061007400650076002C0050004C006F006D0056004900490056
'//
'//**************************************************************************************************
'// 
'// This sample requires some user preperations:
'//     1) Create a user table called 'SER' with the following fields:
'//          - ItemCode - Alphanumeric(20)
'//          - SupSer   - Alphanumeric(32)
'//          - MyInfo   - Alphanumeric(10)
'//     2) Create a user table called 'SERVAR' with the following field:
'//          - CurrKey  - Alphanumeric(30)
'//     3) Add a record to the 'SERVAR' table with the following values:
'//          - Code = 1
'//          - Name = CurrKey
'//          - CurrKey = 1
'//**************************************************************************************************

Option Strict Off
Option Explicit On 
Friend Class AddColumn

    Private oCompany As SAPbobsCOM.Company
    Private WithEvents SBO_Application As SAPbouiCOM.Application

    ''''''''''''''''''
    ' Connect to SBO '
    ''''''''''''''''''
    Private Sub SetApplication()
        Dim SboGuiApi As SAPbouiCOM.SboGuiApi
        Dim sConnectionString As String

        SboGuiApi = New SAPbouiCOM.SboGuiApi

        sConnectionString = Environment.GetCommandLineArgs.GetValue(1)
        SboGuiApi.Connect(sConnectionString)
        SBO_Application = SboGuiApi.GetApplication()

    End Sub

    ''''''''''''''''''''''''''''''''''
    ' Connect with connection string '
    ''''''''''''''''''''''''''''''''''
    Private Function SetConnectionContext() As Integer

        Dim sCookie As String
        Dim sConnectionContext As String
        Dim lRetCode As Integer

        oCompany = New SAPbobsCOM.Company

        sCookie = oCompany.GetContextCookie
        sConnectionContext = SBO_Application.Company.GetConnectionContext(sCookie)

        If oCompany.Connected = True Then
            oCompany.Disconnect()
        End If
        SetConnectionContext = oCompany.SetSboLoginContext(sConnectionContext)

    End Function

    ''''''''''''''''''
    ' Connect to SBO '
    ''''''''''''''''''
    Private Function ConnectToCompany() As Integer

        '// Establish the connection to the company database.
        ConnectToCompany = oCompany.Connect

    End Function

    ''''''''''''''''''
    ' Init the Class '
    ''''''''''''''''''
    Public Sub New()
        MyBase.New()
        SetApplication()
        If Not SetConnectionContext() = 0 Then
            SBO_Application.MessageBox("Failed setting a connection to DI API")
            End ' Terminating the Add-On Application
        End If
        If Not ConnectToCompany() = 0 Then
            SBO_Application.MessageBox("Failed connecting to the company's Data Base")
            Application.Exit() ' Terminating the Add-On Application
        End If

        SBO_Application.MessageBox("DI Connected To: " & oCompany.CompanyName)
    End Sub

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ' This function loads data from the database to the form '
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Function LoadUserFieldToMatrix(ByVal f As SAPbouiCOM.Form, ByVal SuppSerial As String) As String
        Dim oRecordset As SAPbobsCOM.Recordset
        Dim RowNum As Integer
        Dim ItemCode As SAPbouiCOM.EditText
        Dim oMatrix As SAPbouiCOM.Matrix
        Dim oItem As SAPbouiCOM.Item
        Dim sSQL As String

        oItem = f.Items.Item("43") ' The Matrix, is item #43 as viewed in debug information
        oMatrix = oItem.Specific
        RowNum = oMatrix.GetNextSelectedRow()
        ItemCode = oMatrix.Columns.Item(5).Cells.Item(RowNum).Specific ' Column #5 is the Item Code

        Try
            'Query the database
            oRecordset = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)

            sSQL = "SELECT     U_MyInfo, U_ItemCode, U_SupSer " & _
            "FROM         dbo.[@SER] " & _
            "WHERE     (U_ItemCode = N'" & ItemCode.Value & "') AND (U_SupSer = N'" & SuppSerial & "')"

            oRecordset.DoQuery(sSQL)
            oRecordset.MoveFirst()
            LoadUserFieldToMatrix = oRecordset.Fields.Item("U_MyInfo").Value
        Catch oEx As Exception
            LoadUserFieldToMatrix = ""
            SBO_Application.MessageBox("The Select Failed: " & oEx.Message)
        End Try

    End Function

    '''''''''''''''''''''''''''''''''''''
    ' Update a record in the table @SER '
    '''''''''''''''''''''''''''''''''''''
    Sub UpdateDBWithUserField(ByVal ItemCode As String, ByVal SuppSerial As String, ByVal UserField As String)
        Dim UT, UTKey As SAPbobsCOM.UserTable
        Dim UTS As SAPbobsCOM.UserTables
        Dim sSQL As String
        Dim oRecordset As SAPbobsCOM.Recordset

        Try
            oRecordset = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)

            sSQL = "SELECT     Code, U_ItemCode, U_SupSer " & _
            "FROM         dbo.[@SER] " & _
            "WHERE     (U_ItemCode = N'" & ItemCode & "') AND (U_SupSer = N'" & SuppSerial & "')"

            oRecordset.DoQuery(sSQL)
            ' Check if a record exists with this [ItemCode] and [SuppSerial] 
            If oRecordset.RecordCount > 0 Then
                oRecordset.MoveFirst()
                sSQL = oRecordset.Fields.Item("Code").Value

                UTS = oCompany.UserTables
                UT = UTS.Item("SER")
                UT.GetByKey(sSQL)
                UT.UserFields.Fields.Item("U_MyInfo").Value = UserField
                UT.Update()
            Else
                ' Get The Last Key and Increase it
                UTS = oCompany.UserTables
                UTKey = UTS.Item("SERVAR")
                UTKey.GetByKey("1")
                Dim CurKey As String
                CurKey = UTKey.UserFields.Fields.Item("U_CurrKey").Value
                CurKey = CStr(CInt(CurKey) + 1)
                UTKey.UserFields.Fields.Item("U_CurrKey").Value = CurKey
                UTKey.Update()

                UT = UTS.Item("SER")

                UT.Code = CurKey
                UT.Name = CurKey

                'Insert a new record to the table
                UT.UserFields.Fields.Item("U_ItemCode").Value = ItemCode
                UT.UserFields.Fields.Item("U_SupSer").Value = SuppSerial
                UT.UserFields.Fields.Item("U_MyInfo").Value = UserField

                UT.Add()
                UT.Update()
            End If

        Catch oEx As Exception
            SBO_Application.MessageBox("The Select Failed: " & oEx.Message)
        End Try
    End Sub

    ''''''''''''''''''''''
    ' Handle Item Events '
    ''''''''''''''''''''''
    Private Sub SBO_Application_ItemEvent(ByVal FormUID As String, ByRef pVal As SAPbouiCOM.ItemEvent, ByRef BubbleEvent As Boolean) Handles SBO_Application.ItemEvent
        'If pVal.EventType = SAPbouiCOM.BoEventTypes.et_FORM_LOAD Then
        '    SBO_Application.MessageBox("load")
        'End If
        Dim oForm As SAPbouiCOM.Form
        Dim oMatrix As SAPbouiCOM.Matrix
        Dim oItem As SAPbouiCOM.Item
        Dim oColumn As SAPbouiCOM.Column
        Dim oRecordset As SAPbobsCOM.Recordset
        Dim oEditText As SAPbouiCOM.EditText
        Dim MyCell As SAPbouiCOM.ComboBox
        'Dim ColNum = oMatrix.Columns.Count
        'Dim RowNum = oMatrix.RowCount

        oForm = SBO_Application.Forms.Item(FormUID)

        ' If the Upper Matrix was pressed we load the lower matrix with the correct records.
        If (oForm.TypeEx = "65270") Then
            If (pVal.EventType = SAPbouiCOM.BoEventTypes.et_ITEM_PRESSED And pVal.ItemUID = "43") Then
                Dim SelRow As Integer

                ' Get the Lower Matrix
                oItem = oForm.Items.Item("3")
                oMatrix = oItem.Specific

                Dim j As Integer

                Dim ColNum = oMatrix.Columns.Count
                Dim RowNum = oMatrix.RowCount

                ' Load date to matrix from the database
                oForm.Freeze(True)
                For j = 1 To RowNum
                    Try
                        oEditText = oMatrix.Columns.Item(1).Cells.Item(j).Specific
                        Dim ItemCode = oEditText.Value
                        MyCell = oMatrix.Columns.Item(17).Cells.Item(j).Specific
                        MyCell.Select(LoadUserFieldToMatrix(oForm, oEditText.Value))
                    Catch oEx As Exception
                        oForm.Freeze(False)
                        oForm.Update()
                        MessageBox.Show(oEx.Message & " j = " & CStr(j))
                    End Try
                Next j
                oForm.Freeze(False)
                oForm.Update()
            End If

            If (pVal.EventType = SAPbouiCOM.BoEventTypes.et_ITEM_PRESSED And pVal.ItemUID = "1") Then

                If oForm.Mode = SAPbouiCOM.BoFormMode.fm_UPDATE_MODE Then
                    Dim i, j As Integer
                    Dim mm(1, 1)

                    oItem = oForm.Items.Item("43")
                    oMatrix = oItem.Specific

                    Dim ColNum = oMatrix.Columns.Count
                    Dim RowNum = oMatrix.RowCount

                    ColNum = oMatrix.Columns.Count
                    RowNum = oMatrix.RowCount
                    ReDim mm(10, RowNum)

                    i = oMatrix.GetNextSelectedRow()

                    oEditText = oMatrix.Columns.Item(5).Cells.Item(i).Specific

                    Dim ItemCode = oEditText.Value

                    Try
                        oRecordset = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
                        oRecordset.DoQuery("SELECT * from OSRI WHERE ItemCode = '" & oEditText.Value & "'")
                    Catch oEx As Exception
                        SBO_Application.MessageBox("The Select Failed: " & oEx.Message)
                    End Try

                    ' Get the Lower Matrix
                    oItem = oForm.Items.Item("3")
                    oMatrix = oItem.Specific

                    ColNum = oMatrix.Columns.Count
                    RowNum = oMatrix.RowCount

                    For j = 1 To RowNum
                        Try
                            oEditText = oMatrix.Columns.Item(1).Cells.Item(j).Specific
                            MyCell = oMatrix.Columns.Item(17).Cells.Item(j).Specific

                            If (oEditText.Value <> Nothing) And (oEditText.Value <> "") Then
                                UpdateDBWithUserField(ItemCode, oEditText.Value, MyCell.Selected.Value)
                            Else
                                MessageBox.Show("Nothing was in the cell")
                            End If
                        Catch oEx As Exception
                            MessageBox.Show(oEx.Message & " col i = " & CStr(i) & " row j = " & CStr(j))
                        End Try
                    Next j
                End If
            End If

            ' Catch the Load event of Serial numbers managment form 
            If pVal.EventType = SAPbouiCOM.BoEventTypes.et_FORM_LOAD Then
                oForm = SBO_Application.Forms.Item(FormUID)
                oItem = oForm.Items.Item(2)
                oMatrix = oItem.Specific

                Dim i, j As Integer
                Dim MyMatrix(1, 1)

                Dim ColNum = oMatrix.Columns.Count
                Dim RowNum = oMatrix.RowCount

                ColNum = oMatrix.Columns.Count
                RowNum = oMatrix.RowCount
                ' **************************************************************************************
                ' YOU CAN SAVE THE DATA IN THE MATRIX BEFORE IT IS CLEARED BY REMOVING THE REMARKED CODE

                'ReDim MyMatrix(10, RowNum)

                'For i = 0 To 9
                '    For j = 0 To RowNum - 1
                '        Try
                '            oEditText = oMatrix.Columns.Item(i + 1).Cells.Item(j + 1).Specific
                '            If (oEditText.Value <> Nothing) And (oEditText.Value <> "") Then
                '                MyMatrix(i, j) = oEditText.Value
                '            End If
                '        Catch oEx As Exception
                '            MessageBox.Show(oEx.Message & " col i = " & CStr(i) & " row j = " & CStr(j))
                '        End Try
                '    Next j
                'Next i
                ' **************************************************************************************

                oMatrix.Clear()

                oColumn = oMatrix.Columns.Add("MyCol", SAPbouiCOM.BoFormItemTypes.it_COMBO_BOX)
                oColumn.TitleObject.Caption = "My Info"
                oColumn.Width = 70
                oColumn.Visible = True
                oColumn.ValidValues.Add("a", "")
                oColumn.ValidValues.Add("b", "")
                oColumn.ValidValues.Add("c", "")

                Try
                    oForm.DataSources.DBDataSources.Add("@SER")
                    oColumn.DataBind.SetBound(True, "@SER", "U_MyInfo")
                Catch oEx As Exception
                    MessageBox.Show(oEx.Message)
                End Try
            End If
        End If
    End Sub
End Class
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

    ' Datasources
    Private oDBDS As SAPbouiCOM.DBDataSource
    Private oUsrDS As SAPbouiCOM.UserDataSource
    Private oColumn As SAPbouiCOM.Column
    Private oCombo As SAPbouiCOM.IComboBox
    Private oEdit As SAPbouiCOM.IEditText

    Private oCell As SAPbouiCOM.Cell

    Private oString As String
    Private lRowNeedToMerge As Integer
    Private oItem As SAPbouiCOM.Item
    Private oEditText As SAPbouiCOM.IEditText
    Private oForm As SAPbouiCOM.Form
    Private sUDOFormUID As String

    Dim oMatrix As SAPbouiCOM.Matrix

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

        Select Case EventType
            Case SAPbouiCOM.BoAppEventTypes.aet_ShutDown
                System.Windows.Forms.Application.Exit()
        End Select

    End Sub

    'Private Sub SBO_Application_DataEvent(ByRef BusinessObjectInfo As SAPbouiCOM.BusinessObjectInfo, ByRef BubbleEvent As Boolean) Handles SBO_Application.FormDataEvent
    '    'If this is a load event - make proper coloring and merging.
    '    If (BusinessObjectInfo.BeforeAction = False) And (BusinessObjectInfo.EventType = SAPbouiCOM.BoEventTypes.et_FORM_DATA_LOAD) Then
    '        If BusinessObjectInfo.FormUID.StartsWith("UDO_F_SM_MOR") Then

    '            Dim f As SAPbouiCOM.Form
    '            f = SBO_Application.Forms.Item(BusinessObjectInfo.FormUID)

    '            Dim oCombo As SAPbouiCOM.ComboBox

    '            oMatrix = f.Items.Item("0_U_G").Specific

    '            Dim i As Integer

    '            ' Iterate the whole matrix
    '            For i = 1 To oMatrix.RowCount

    '                oCombo = oMatrix.Columns.Item("U_LineType").Cells.Item(1).Specific
    '                MessageBox.Show("Row: " & i.ToString() & " Value: " & oCombo.Value)

    '            Next
    '        End If
    '    End If

    'End Sub


    Private Sub SBO_Application_ItemEvent(ByVal FormUID As String, ByRef pVal As SAPbouiCOM.ItemEvent, ByRef BubbleEvent As Boolean) Handles SBO_Application.ItemEvent

        Dim EventEnum As SAPbouiCOM.BoEventTypes
        EventEnum = pVal.EventType


        ' Check if this is a form of the UDO and Init the columns
        If (EventEnum = SAPbouiCOM.BoEventTypes.et_FORM_ACTIVATE) And (pVal.Before_Action = False) Then
            If FormUID.StartsWith("UDO_F_SM_MOR") Then
                'SBO_Application.SetStatusBarMessage("Finished Loading, unique ID: " & FormUID & " Form Type: " & pVal.FormType, SAPbouiCOM.BoMessageTime.bmt_Short)

                'Send the form UID to add necessary data binding
                InitSpecialLinesForm(FormUID)

            End If
        End If

        ' Handle Combo Selection of special lines 
        If (EventEnum = SAPbouiCOM.BoEventTypes.et_COMBO_SELECT) And (pVal.ItemUID = "0_U_G") And _
        (FormUID.StartsWith("UDO_F_SM_MOR")) And (pVal.BeforeAction = False) Then

            Dim f As SAPbouiCOM.Form
            f = SBO_Application.Forms.Item(FormUID)

            oMatrix = f.Items.Item("0_U_G").Specific

            oColumn = oMatrix.Columns.Item("U_LineType")

            oCombo = oColumn.Cells.Item(pVal.Row).Specific
            oString = oCombo.Selected.Value

            ' If it is a text line
            If (oString = "T") Then
                lRowNeedToMerge = pVal.Row
                'initialize by last value
                Dim oTMPET As SAPbouiCOM.EditText
                oTMPET = oMatrix.Columns.Item("U_MainDish").Cells.Item(lRowNeedToMerge).Specific
                sUDOFormUID = FormUID
                PopUp_Text_Form(oTMPET.String)
            ElseIf (oString = "S") Then


                Dim value As Integer
                value = MatrixCalculateTotal(pVal.Row)
                oMatrix.SetCellWithoutValidation(pVal.Row, "U_Price", value)
            End If
        End If

        ' User Clicked OK on Text Form
        If (pVal.EventType = SAPbouiCOM.BoEventTypes.et_CLICK) And (pVal.FormUID = "longtext") And (pVal.ItemUID = "1") Then
            Dim otempForm As SAPbouiCOM.IForm
            otempForm = SBO_Application.Forms.Item("longtext")
            oEditText = otempForm.Items.Item("multiedit").Specific
            oString = oEditText.Value
            otempForm.Visible = False

            oForm = SBO_Application.Forms.Item(sUDOFormUID)
            Dim oMatrix As SAPbouiCOM.Matrix
            Dim oCell As SAPbouiCOM.Cell

            oMatrix = oForm.Items.Item("0_U_G").Specific

            oMatrix.SetCellWithoutValidation(lRowNeedToMerge, "U_SideDish", "")
            oMatrix.SetCellWithoutValidation(lRowNeedToMerge, "U_Drink", "")
            oMatrix.SetCellWithoutValidation(lRowNeedToMerge, "U_Price", "")

            oMatrix.CommonSetting.SetRowEditable(lRowNeedToMerge, False)
            oMatrix.CommonSetting.SetCellEditable(lRowNeedToMerge, 1, True)
            oMatrix.CommonSetting.MergeCell(lRowNeedToMerge, 2, True)

            oColumn = oMatrix.Columns.Item("U_MainDish")
            oCell = oColumn.Cells.Item(lRowNeedToMerge)
            oEditText = oCell.Specific
            oEditText.Value = oString
            oMatrix.FlushToDataSource()

            oForm.Update()
            otempForm.Close()

        End If

        ' Check if this is a form of the UDO and a Data event was fired
        If (EventEnum = SAPbouiCOM.BoEventTypes.et_FORM_DATA_LOAD) And (pVal.Before_Action = False) Then
            If FormUID.StartsWith("UDO_F_SM_MOR") Then
                'SBO_Application.SetStatusBarMessage("Finished Loading, unique ID: " & FormUID & " Form Type: " & pVal.FormType, SAPbouiCOM.BoMessageTime.bmt_Short)

                SBO_Application.MessageBox("Doc loaded")
                oForm = SBO_Application.Forms.Item(FormUID)
                oMatrix = oForm.Items.Item("0_U_G").Specific
                Dim oCombo As SAPbouiCOM.ComboBox
                Dim iRow As Integer

                For iRow = 1 To oMatrix.RowCount
                    oCombo = oMatrix.GetCellSpecific(1, iRow)
                    Select Case oCombo.Value
                        Case "S"
                            ColorLineAsTotal(iRow)
                        Case "T"
                            'Do Nothing
                        Case Else ' This means the cell should have some numeric value
                    End Select

                Next iRow ' Next Row
            End If
        End If

    End Sub

    Function MatrixCalculateTotal(ByVal iRow As Integer) As Integer
        Dim iSubTotal As Integer = 0

        Try
            ' Calculate the sub total cell.
            ' Sum all the cells above current line until you get to a sub total or to the first line
            Dim i As Integer
            i = iRow
            Dim bSubTotalReached As Boolean = False
            Dim oCombo As SAPbouiCOM.ComboBox
            Dim oEdit As SAPbouiCOM.EditText

            While (i <> 1) And (bSubTotalReached = False)
                ' Check if the row above is of type subTotal
                oCombo = oMatrix.GetCellSpecific(1, i - 1)
                Select Case oCombo.Value
                    Case "S"
                        bSubTotalReached = True
                        Exit While
                    Case "T"
                        'Do Nothing
                    Case Else ' This means the cell should have some numeric value
                        oEdit = oMatrix.GetCellSpecific("U_Price", i - 1)
                        iSubTotal += oEdit.Value
                End Select
                'Go to next row
                i = i - 1
            End While

            oMatrix.SetCellWithoutValidation(iRow, "U_MainDish", "")
            oMatrix.SetCellWithoutValidation(iRow, "U_SideDish", "")
            oMatrix.SetCellWithoutValidation(iRow, "U_Drink", "")
            oMatrix.SetCellWithoutValidation(iRow, "U_Price", "")

            ColorLineAsTotal(iRow)

        Catch ex As Exception
            SBO_Application.MessageBox(ex.Message)
        End Try


        Return iSubTotal
    End Function

    Sub ColorLineAsTotal(ByVal iRow As Integer)
        oMatrix.SetCellFocus(iRow, 1)

        oMatrix.CommonSetting.SetCellEditable(iRow, 2, False)
        oMatrix.CommonSetting.SetCellEditable(iRow, 3, False)
        oMatrix.CommonSetting.SetCellEditable(iRow, 4, False)
        oMatrix.CommonSetting.SetCellEditable(iRow, 5, False)

        Dim GreyColor, BlueColor As Integer
        GreyColor = 222 Or (223 << 8) Or (222 << 16)
        BlueColor = 0 Or (0 << 8) Or (222 << 16)
        oMatrix.CommonSetting.SetRowBackColor(iRow, GreyColor)
        oMatrix.CommonSetting.SetRowFontColor(iRow, BlueColor)

        oMatrix.CommonSetting.SeparateLine(iRow, 11111, SAPbouiCOM.BoSeparateLineType.slt_Top, True) ' BUG

    End Sub


    Sub InitSpecialLinesForm(ByVal UDOformUID As String)
        'Start Init

        Dim f As SAPbouiCOM.Form
        Dim i As SAPbouiCOM.Item

        f = SBO_Application.Forms.Item(UDOformUID)

        Try
            i = f.Items.Item("MyFlag")

        Catch ex As Exception
            i = f.Items.Add("MyFlag", SAPbouiCOM.BoFormItemTypes.it_STATIC)
            'Get Matrix "0_U_G"
            Dim oMatrix As SAPbouiCOM.Matrix

            ' Get Current Matrix from UDO form
            oMatrix = f.Items.Item("0_U_G").Specific

            Try
                oMatrix.Clear()
                oDBDS = f.DataSources.DBDataSources.Item("@SM_MOR1")

                'oDBDS.Query(Nothing)

                oMatrix.Columns.Item("U_LineType").ColumnSetting.DisplayType = SAPbouiCOM.BoColumnDisplayType.cdt_Picture


                oMatrix.AddRow()

                '// Put a 16x16 pixel bitmap in the specified path (file is in the project folder)
                oString = "C:\\BitMap\\Smile.bmp"

                oColumn = oMatrix.Columns.Item("U_LineType")
                oCombo = oColumn.Cells.Item(1).Specific

                oCombo.ValidValues.Add(oString, "picture")
                oCombo.ValidValues.Add("T", "Text")
                oCombo.ValidValues.Add("A", "Alternative")
                oCombo.ValidValues.Add("S", "SubTotal")

                oMatrix.LoadFromDataSource()

            Catch ex1 As Exception
                SBO_Application.MessageBox(ex1.Message)
            End Try
        End Try

    End Sub

    Private Sub PopUp_Text_Form(ByVal inital As String)
        Dim oTop, oLeft, oHeight, oWidth As Integer
        Dim oMyForm As SAPbouiCOM.Form
        Dim oFormParams As SAPbouiCOM.FormCreationParams

        oFormParams = SBO_Application.CreateObject(SAPbouiCOM.BoCreatableObjectType.cot_FormCreationParams)
        oFormParams.FormType = "longtext"
        oFormParams.UniqueID = "longtext"

        Try
            oMyForm = SBO_Application.Forms.AddEx(oFormParams)
        Catch ex As Exception
            oMyForm = SBO_Application.Forms.Item("longtext")
            oMyForm.Close()
            oMyForm = SBO_Application.Forms.AddEx(oFormParams)
        End Try

        oMyForm.Top = 50
        oMyForm.ClientHeight = 376
        oMyForm.ClientWidth = 544
        oMyForm.Title = "long text"
        oMyForm.Visible = True

        oItem = oMyForm.Items.Add("multiedit", SAPbouiCOM.BoFormItemTypes.it_EXTEDIT)
        oItem.Height = 298
        oItem.Width = 526

        oEditText = oItem.Specific
        oEditText.Active = True
        oEditText.Value = inital

        oTop = oItem.Top
        oLeft = oItem.Left
        oWidth = oItem.Width
        oHeight = oItem.Height


        oItem = oMyForm.Items.Add("1", SAPbouiCOM.BoFormItemTypes.it_BUTTON)
        oItem.Height = 20
        oItem.Width = 70
        oItem.Top = oTop + oHeight + 50
        oItem.Left = oLeft + 3

        oTop = oItem.Top
        oLeft = oItem.Left
        oWidth = oItem.Width
        oHeight = oItem.Height

        oItem = oMyForm.Items.Add("2", SAPbouiCOM.BoFormItemTypes.it_BUTTON)
        oItem.Top = oTop
        oItem.Height = oHeight
        oItem.Width = oWidth
        oItem.Left = oLeft + oWidth + 5

    End Sub


End Class
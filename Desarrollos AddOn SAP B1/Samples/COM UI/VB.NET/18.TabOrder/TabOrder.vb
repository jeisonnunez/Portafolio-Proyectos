'  SAP MANAGE UI API 2007 SDK Sample
'****************************************************************************
'
'  File:      TabOrder.vb
'
'  Copyright (c) SAP MANAGE
'
' THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
' ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
' THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
' PARTICULAR PURPOSE.
'
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

Friend Class TabOrder

    '**********************************************************
    ' This parameter will use us to manipulate the
    ' SAP Business One Application
    '**********************************************************

    Private WithEvents SBO_Application As SAPbouiCOM.Application
    Private oForm As SAPbouiCOM.Form
    Private oItem As SAPbouiCOM.Item
    Private oOptionBtnHor As SAPbouiCOM.OptionBtn
    Private oOptionBtnVer As SAPbouiCOM.OptionBtn
    Private userDS As SAPbouiCOM.UserDataSource

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

    Private Sub LoadFromXML(ByRef FileName As String)

        Dim oXmlDoc As Xml.XmlDocument

        oXmlDoc = New Xml.XmlDocument

        ' load the content of the XML File
        Dim sPath As String

        sPath = IO.Directory.GetParent(Application.StartupPath).ToString

        oXmlDoc.Load(sPath & "\" & FileName)

        ' load the form to the SBO application in one batch
        SBO_Application.LoadBatchActions(oXmlDoc.InnerXml)

    End Sub

    Public Sub New()
        MyBase.New()

        '*************************************************************
        ' set SBO_Application with an initialized application object
        '*************************************************************
        SetApplication()

        ' Load the Tab Order form
        LoadFromXML("TabOrder.srf")

        ' Get the added form object by using the form's UID
        oForm = SBO_Application.Forms.Item("frmTab")

        ' Create a user Datasource for the 
        userDS = oForm.DataSources.UserDataSources.Add("OpBtnDS", SAPbouiCOM.BoDataType.dt_SHORT_TEXT, 1)

        ' Set binding and grouping for the option buttons
        oItem = oForm.Items.Item("optHor")

        oOptionBtnHor = oItem.Specific
        oOptionBtnHor.GroupWith("optVer")
        oOptionBtnHor.DataBind.SetBound(True, , "OpBtnDS")

        oItem = oForm.Items.Item("optVer")

        oOptionBtnHor = oItem.Specific
        oOptionBtnHor.GroupWith("optHor")
        oOptionBtnHor.DataBind.SetBound(True, , "OpBtnDS")

        ' Set the default to horizontal tabbing
        oItem = oForm.Items.Item("optHor")
        oOptionBtnHor = oItem.Specific
        oOptionBtnHor.Selected = True

        ' Show the form
        oForm.Visible = True

    End Sub
    Private Sub SBO_Application_ItemEvent(ByVal FormUID As String, ByRef pVal As SAPbouiCOM.ItemEvent, ByRef BubbleEvent As Boolean) Handles SBO_Application.ItemEvent

        '*************************************************************************
        ' BubbleEvent sets the behavior of SAP Business One.
        ' False means that the application will not continue processing this event.
        '*************************************************************************
        BubbleEvent = True
        Dim EventEnum As SAPbouiCOM.BoEventTypes
        EventEnum = pVal.EventType

        If (FormUID = "frmTab") And ((pVal.ItemUID = "optHor") Or (pVal.ItemUID = "optVer")) And _
           (pVal.EventType = SAPbouiCOM.BoEventTypes.et_ITEM_PRESSED) And (pVal.BeforeAction = False) Then
            If (userDS.Value = 1) Then
                SetTabVertical()
            ElseIf (userDS.Value = 2) Then
                SetTabHorizontal()
            End If
        End If

        ' Close the add-on if the form closes
        If (FormUID = "frmTab") And (pVal.EventType = SAPbouiCOM.BoEventTypes.et_FORM_CLOSE) Then
            System.Windows.Forms.Application.Exit()
        End If

    End Sub

    Private Sub SetTabVertical()
        Dim i, t, diff As Integer
        Dim oEdit As SAPbouiCOM.EditText

        diff = 50

        For i = 20 To 29
            oItem = oForm.Items.Item(i.ToString)
            oEdit = oItem.Specific

            oEdit.TabOrder = i + diff
        Next
    End Sub
    Private Sub SetTabHorizontal()
        Dim i, t, left, right, diff As Integer
        Dim oEdit As SAPbouiCOM.EditText

        left = 1
        right = 2
        diff = 100

        For i = 20 To 29
            oItem = oForm.Items.Item(i.ToString)
            oEdit = oItem.Specific

            If i < 25 Then
                oEdit.TabOrder = left + diff
                left = left + 2
            Else
                oEdit.TabOrder = right + diff
                right = right + 2
            End If
        Next

    End Sub
End Class
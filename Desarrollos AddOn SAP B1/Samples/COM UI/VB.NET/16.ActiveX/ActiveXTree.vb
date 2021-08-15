Option Strict Off
Option Explicit On 

Friend Class ActiveXTree
    '//  SAP MANAGE UIDI API 2006 SDK Sample
    '//****************************************************************************
    '//
    '//  File:      ActiveXTree.vb
    '//
    '//  Copyright (c) SAP MANAGE
    '//
    '// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
    '// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
    '// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
    '// PARTICULAR PURPOSE.
    '//
    '//****************************************************************************



    '//**************************************************************************************************
    '// BEFORE STARTING:
    '// 1. Add reference to the "SAP Business One UI API"
    '// 2. Add reference to the "SAP Business One Objects Bridge VERSION 2006"
    '// 3. Insert the development connection string to the "Command Line Argument"
    '//-----------------------------------------------------------------
    '// 1.
    '//    a. Project->References
    '//    b. check the "SAP Business One UI API 2007" check box
    '//
    '// 2.
    '//    a. Project->References
    '//    b. check the "SAP Business One Objects Bridge VERSION 2006" check box
    '//
    '// 3.
    '//     a. Project->Properties
    '//     b. choose 'Make' tab folder
    '//     c. place the following connection string in the 'Command Line Arguments' field
    '// 0030002C0030002C00530041005000420044005F00440061007400650076002C0050004C006F006D0056004900490056
    '//
    '//**************************************************************************************************


    '//**********************************************************
    '// This parameter will use us to manipulate the
    '// SAP Business One Application a
    '// and the Company on which we are working
    '//**********************************************************

    Private WithEvents SBO_Application As SAPbouiCOM.Application
    Private oCompany As SAPbobsCOM.Company
    Private WithEvents oTreeView As MSComctlLib.TreeView
    Private oEdit As SAPbouiCOM.EditText

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

    Private Function SetConnectionContext() As Integer

        Dim sCookie As String
        Dim sConnectionContext As String
        Dim lRetCode As Integer

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

    End Function

    Private Function ConnectToCompany() As Integer

        '// Establish the connection to the company database.
        ConnectToCompany = oCompany.Connect

    End Function
    'UPGRADE_NOTE: Class_Initialize was upgraded to Class_Initialize_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
    Private Sub Class_Initialize_Renamed()

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

        SBO_Application.MessageBox("DI Connected To: " & oCompany.CompanyName & vbNewLine & "Hello World!")

        CreateFormWithActiveX()
    End Sub
    Private Sub CreateFormWithActiveX()
        Dim CP As SAPbouiCOM.FormCreationParams
        Dim fTree As SAPbouiCOM.Form
        Dim AcXTree As SAPbouiCOM.ActiveX
        Dim oItem As SAPbouiCOM.Item
        Dim oStatic As SAPbouiCOM.StaticText
        Dim oLink As SAPbouiCOM.LinkedButton

        ' Set the form creation parameters
        CP = SBO_Application.CreateObject(SAPbouiCOM.BoCreatableObjectType.cot_FormCreationParams)
        CP.BorderStyle = SAPbouiCOM.BoFormBorderStyle.fbs_Fixed
        CP.FormType = "ACXTree"
        CP.UniqueID = "ACTree1"

        ' Add a new form
        fTree = SBO_Application.Forms.AddEx(CP)
        fTree.Left = 100
        fTree.Top = 100
        fTree.Width = 300
        fTree.Height = 300
        fTree.Height = 300
        fTree.Title = "TreeView - ActiveX"

        ' Add the edit text and linked button
        oItem = fTree.Items.Add("staticBP", SAPbouiCOM.BoFormItemTypes.it_STATIC)
        oItem.Left = 20
        oItem.Top = 10
        oItem.Width = 200
        oStatic = oItem.Specific
        oStatic.Caption = "Business Parnters with contacts"

        ' Add the edit text and linked button
        oItem = fTree.Items.Add("txtBP", SAPbouiCOM.BoFormItemTypes.it_EDIT)
        oItem.Left = 20
        oItem.Top = 250
        oItem.Width = 60
        oEdit = oItem.Specific

        oItem = fTree.Items.Add("BPLink", SAPbouiCOM.BoFormItemTypes.it_LINKED_BUTTON)
        oItem.Left = 80
        oItem.Top = 250
        oItem.LinkTo = "txtBP"
        oLink = oItem.Specific
        oLink.LinkedObject = SAPbouiCOM.BoLinkedObject.lf_BusinessPartner

        ' Add the TreeView Control to the form
        oItem = fTree.Items.Add("Tree", SAPbouiCOM.BoFormItemTypes.it_ACTIVE_X)
        oItem.Left = 20
        oItem.Top = 40
        oItem.Width = 250
        oItem.Height = 200

        ' Create the new activeX control
        AcXTree = oItem.Specific
        AcXTree.ClassID = "MSComctlLib.TreeCtrl.2"
        oTreeView = AcXTree.Object

        'Loading date to Tree Nodes
        Dim BPNode As MSComctlLib.Node
        Dim ContactNode As MSComctlLib.Node
        Dim oRecordSet As SAPbobsCOM.Recordset
        Dim oBPs As SAPbobsCOM.BusinessPartners
        Dim iContact As Integer

        ' Reference all the Business Partners
        oRecordSet = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        oRecordSet.DoQuery("SELECT * FROM OCRD")
        oBPs = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oBusinessPartners)
        oBPs.Browser.Recordset = oRecordSet

        ' Iterate all the BPs
        oBPs.Browser.MoveFirst()
        Dim j As Integer
        For j = 1 To oBPs.Browser.RecordCount - 1
            BPNode = oTreeView.Nodes.Add(, , "B" & oBPs.CardCode, oBPs.CardName)
            For iContact = 0 To oBPs.ContactEmployees.Count() - 1
                oBPs.ContactEmployees.SetCurrentLine(iContact)
                If oBPs.ContactEmployees.Name <> "" Then
                    ContactNode = oTreeView.Nodes.Add(, , "C" & oBPs.CardCode & iContact.ToString, oBPs.ContactEmployees.Name)
                    ContactNode.Parent = BPNode
                End If
            Next iContact
            oBPs.Browser.MoveNext()
        Next
        ' Make the form visible
        fTree.Visible = True

    End Sub
    Public Sub New()
        MyBase.New()
        Class_Initialize_Renamed()
    End Sub

    Private Sub oTreeView_NodeClick(ByVal Node As MSComctlLib.Node) Handles oTreeView.NodeClick
        If oTreeView.SelectedItem.Key.StartsWith("B") Then
            oEdit.Value = oTreeView.SelectedItem.Key.TrimStart("B")
        End If
    End Sub
End Class
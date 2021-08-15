'//  SAP MANAGE UI API 2007 SDK Sample
'//****************************************************************************
'//
'//  File:      WorkingWithXML.vb
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

Friend Class WorkingWithXML

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

        SboGuiApi.Connect(sConnectionString)

        '// get an initialized application object

        SBO_Application = SboGuiApi.GetApplication()

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

    Public Sub New()
        MyBase.New()

        '//*************************************************************
        '// set SBO_Application with an initialized application object
        '//*************************************************************
        SetApplication()

        LoadFromXML("MySimpleForm.xml")

        '// Get the added form object by using the form's UID
        oForm = SBO_Application.Forms.Item("MySimpleForm")

        '// Show the loaded Form
        oForm.Visible = True

        '//*********************************************
        '// Saving the Form as an XML file
        '// although it already exist as an XML file
        '// it is good for practice :)
        '//*********************************************

        SaveAsXML(oForm)

    End Sub
End Class
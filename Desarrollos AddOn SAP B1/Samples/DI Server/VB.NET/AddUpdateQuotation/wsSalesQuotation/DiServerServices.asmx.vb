'//  SAP MANAGE DI Server Api VERSION 2006 SDK Sample
'//****************************************************************************
'//
'//  File:      DiServerServices.asmx
'//
'//  Copyright (c) SAP MANAGE
'//
'// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
'// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
'// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
'// PARTICULAR PURPOSE.
'//
'//****************************************************************************


Imports System.Web.Services

<System.Web.Services.WebService(Namespace:="http://tempuri.org/wsSalesQuotation/Service1")> _
Public Class DiServerServicesSample
    Inherits System.Web.Services.WebService
    Const sRem = "|Empty Node|"

#Region " Web Services Designer Generated Code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Web Services Designer.
        InitializeComponent()

        'Add your own initialization code after the InitializeComponent() call

    End Sub

    'Required by the Web Services Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Web Services Designer
    'It can be modified using the Web Services Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        components = New System.ComponentModel.Container
    End Sub

    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        'CODEGEN: This procedure is required by the Web Services Designer
        'Do not modify it using the code editor.
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

#End Region

    ' Login to company
    <WebMethod(Description:="Login to company")> _
    Public Function Login(ByVal DataBaseServer As String, _
                                        ByVal DataBaseName As String, _
                                        ByVal DataBaseType As String, _
                                        ByVal DataBaseUserName As String, _
                                        ByVal DataBasePassword As String, _
                                        ByVal CompanyUserName As String, _
                                        ByVal CompanyPassword As String, _
                                        ByVal Language As String, _
                                        ByVal LicenseServer As String) As String

        Dim pDISnode As SBODI_Server.Node
        Dim sSOAPans As String
        Dim sCmd As String
        Dim sRetVal As String

        pDISnode = New SBODI_Server.Node

        'build the soap string
        sCmd = "<?xml version=""1.0"" encoding=""UTF-16""?>"
        sCmd += "<env:Envelope xmlns:env=""http://schemas.xmlsoap.org/soap/envelope/"">"
        sCmd += "<env:Body><dis:Login xmlns:dis=""http://www.sap.com/SBO/DIS"">"
        sCmd += "<DatabaseServer>" & DataBaseServer & "</DatabaseServer>"
        sCmd += "<DatabaseName>" & DataBaseName & "</DatabaseName>"
        sCmd += "<DatabaseType>" & DataBaseType & "</DatabaseType>"
        sCmd += "<DatabaseUsername>" & DataBaseUserName & "</DatabaseUsername>"
        sCmd += "<DatabasePassword>" & DataBasePassword & "</DatabasePassword>"
        sCmd += "<CompanyUsername>" & CompanyUserName & "</CompanyUsername>"
        sCmd += "<CompanyPassword>" & CompanyPassword & "</CompanyPassword>"
        sCmd += "<Language>" & Language & "</Language>"
        sCmd += "<LicenseServer>" & LicenseServer & "</LicenseServer>"
        sCmd += "</dis:Login></env:Body></env:Envelope>"

        'execute di-server interact and return the result
        sSOAPans = pDISnode.Interact(sCmd)

        'get parsed result
        sRetVal = GetParseResultFromSoapAnswer(sSOAPans)

        'return result
        Return sRetVal

    End Function

    ' Logout
    <WebMethod(Description:="LogOut to company")> _
    Public Function LogOut(ByVal sSessionID As String)

        Dim pDISnode As SBODI_Server.Node
        Dim sSOAPans As String
        Dim sCmdXml As String
        Dim sRetVal As String

        pDISnode = New SBODI_Server.Node

        'build the soap string
        sCmdXml = "<?xml version=""1.0"" encoding=""UTF-16""?>" & _
        "<env:Envelope xmlns:env=""http://schemas.xmlsoap.org/soap/envelope/"">" & _
        "<env:Header>" & _
        "<SessionID>" & sSessionID & "</SessionID>" & _
        "</env:Header>" & _
        "<env:Body>" & _
        "<dis:Logout xmlns:dis=""http://www.sap.com/SBO/DIS"">" & _
        "</dis:Logout>" & _
        "</env:Body>" & _
        "</env:Envelope>"

        'execute interact and return the result
        sSOAPans = pDISnode.Interact(sCmdXml)

        'return result
        Return sSOAPans

    End Function

    'return the result from the soap string
    Private Function GetParseResultFromSoapAnswer(ByVal sSOAPans As String) As String


        Dim pXmlValid As System.Xml.XmlValidatingReader
        Dim sRet As String

        'get xml reader
        pXmlValid = New System.Xml.XmlValidatingReader(sSOAPans, System.Xml.XmlNodeType.Document, Nothing)

        ' Parse the SOAP answer    
        While pXmlValid.Read()
            If pXmlValid.NodeType = System.Xml.XmlNodeType.Text Then
                If sRet = "" Then
                    sRet += pXmlValid.Value
                Else
                    If sRet.StartsWith("Error") Then
                        sRet += " " & pXmlValid.Value
                    Else
                        sRet = "Error " & sRet & " " & pXmlValid.Value
                    End If
                End If
            End If
        End While

        'check for errors
        If InStr(sSOAPans, "<env:Fault>") And (Not (sRet.StartsWith("Error"))) Then
            sRet = "Error: " & sRet
        End If

        'return result
        Return sRet

    End Function

    ' This function returns an XML document of an empty Quotation object
    <WebMethod(Description:="Get an XML document of an empty Quotation object")> _
    Public Function GetEmptyQuotationXml(ByVal sSessionID As String) As Xml.XmlDocument


        Dim pDISnode As SBODI_Server.Node
        Dim sReturnStr As String
        Dim sCmdXML As String
        Dim pXmlReturn As Xml.XmlDocument

        pXmlReturn = New Xml.XmlDocument

        'get new di-server node
        pDISnode = New SBODI_Server.Node

        'build the soap string, adding the session, the command-GetBusinessObjectTemplate,
        'and the object - oQuotations
        sCmdXML = "<?xml version=""1.0"" encoding=""UTF-16""?>" & _
        "<env:Envelope xmlns:env=""http://schemas.xmlsoap.org/soap/envelope/"">" & _
        "<env:Header>" & _
        "<SessionID>" & CStr(sSessionID) & "</SessionID>" & _
        "</env:Header><env:Body><dis:GetBusinessObjectTemplate xmlns:dis=""http://www.sap.com/SBO/DIS"">" & _
        "<Object>oQuotations</Object>" & _
        "</dis:GetBusinessObjectTemplate></env:Body></env:Envelope>"

        'execute interact and return the result
        sReturnStr = pDISnode.Interact(sCmdXML)

        'load the string to xml document
        pXmlReturn.LoadXml(sReturnStr)

        'remove the envelope string & return the result as XmlDocument
        Return (RemoveEnv(pXmlReturn))

    End Function


    ' This function removes the SOAP envelope
    Private Function RemoveEnv(ByVal pXmlReceive As Xml.XmlDocument) As Xml.XmlDocument

        Dim pXmlDoc As Xml.XmlDocument
        Dim sResult As String

        pXmlDoc = New Xml.XmlDocument

        'check for error
        If InStr(pXmlReceive.InnerXml, "<env:Fault>") Then
            'return the xml document 
            Return pXmlReceive
        Else
            'get the answer without the envelope    
            sResult = pXmlReceive.FirstChild.NextSibling.FirstChild.FirstChild.InnerXml
            'load to the xml document
            pXmlDoc.LoadXml(sResult)
        End If

        'return result
        Return pXmlDoc

    End Function

    ' This function Add Sales Quotation
    <WebMethod(Description:="Add Sales Quotation")> _
    Public Function AddQuotation(ByVal SessionID As String, _
                                 ByVal sXmlQuotationObject As String) As Xml.XmlDocument

        Dim pDISnode As SBODI_Server.Node
        Dim pXmlReturn, pXML As Xml.XmlDocument
        Dim sAddCmd As String
        Dim pNetoXML As Xml.XmlNode
        Dim sResult As String


        pXmlReturn = New Xml.XmlDocument

        'get server node
        pDISnode = New SBODI_Server.Node

        pXML = New Xml.XmlDocument

        'load the string into xml document
        pXML.LoadXml(sXmlQuotationObject)

        'remove the empty nodes
        pNetoXML = (RemoveEmptyNodes(pXML))


        'build the soap string ,adding the session, the command-AddObject
        'and the XmlQuotation string
        sAddCmd = "<?xml version=""1.0"" encoding=""UTF-16""?>" & _
        "<env:Envelope xmlns:env=""http://schemas.xmlsoap.org/soap/envelope/"">" & _
        "<env:Header>" & _
        "<SessionID>" & CStr(SessionID) & "</SessionID>" & _
        "</env:Header><env:Body><dis:AddObject xmlns:dis=""http://www.sap.com/SBO/DIS"">" & _
        pNetoXML.InnerXml & _
        "</dis:AddObject></env:Body></env:Envelope>"



        'execute interact and return the result
        sResult = pDISnode.Interact(sAddCmd)

        'load string to xml document
        pXmlReturn.LoadXml(sResult)

        'remove the envelope string & return the result as XmlDocument
        Return (RemoveEnv(pXmlReturn))

    End Function


    ' This function removes all the empty nodes from an XML document
    Private Function RemoveEmptyNodes(ByVal pXmlReceive As Xml.XmlNode) As Xml.XmlNode

        Dim pXmlAnswer As Xml.XmlNode
        Dim pXmlNodeList As Xml.XmlNodeList
        Dim sSelect As String
        Dim pTempXml As Xml.XmlNode

        pXmlAnswer = MarkEmptyNodes(pXmlReceive)

        'build the marked string
        sSelect = "//*[text()="""
        sSelect += sRem
        sSelect += """]"

        'get node list
        pXmlNodeList = pXmlAnswer.SelectNodes(sSelect)

        'remove the marked nodes
        For Each pTempXml In pXmlNodeList
            pTempXml.ParentNode.RemoveChild(pTempXml)
        Next

        'return answer
        Return pXmlAnswer

    End Function

    ' This function marks all the empty nodes with special text.
    ' The "RemoveEmptyNodes" function uses it to select the nodes to be deleted.
    Private Function MarkEmptyNodes(ByVal pXmlReceive As Xml.XmlNode) As Xml.XmlNode

        Dim pMainNode As Xml.XmlNode
        Dim pXmlTemp As Xml.XmlNode
        Dim i, Removed As Integer

        pMainNode = pXmlReceive

        i = 0

        Removed = 0

        'mark empty nodes
        For i = 0 To pMainNode.ChildNodes.Count - 1 - Removed
            pXmlTemp = pMainNode.ChildNodes(i)
            If pXmlTemp.InnerText = "" Then
                pXmlTemp.InnerText = sRem
            ElseIf pXmlTemp.HasChildNodes Then
                pXmlTemp = MarkEmptyNodes(pXmlTemp)
            End If
        Next

        'return answer
        Return pMainNode

    End Function

    ' The function gets the xml string adds the header and send it to the di-server for update 
    <WebMethod(Description:="Update Quotation object")> _
    Public Function UpdateQuotation(ByVal sSessionID As String, _
                                    ByVal sXmlQuotationObject As String) As Xml.XmlDocument

        Dim pReturnXml As Xml.XmlDocument
        Dim pXML As Xml.XmlDocument
        Dim pDiServerNode As SBODI_Server.Node
        Dim sResult As String
        Dim sAddCmd As String

        pXML = New Xml.XmlDocument

        'load string to xml document
        pXML.LoadXml(sXmlQuotationObject)

        'build the soap string ,adding the session, the command-UpdateObject
        'and the XmlQuotation string
        sAddCmd = "<?xml version=""1.0"" encoding=""UTF-16""?>" & _
        "<env:Envelope xmlns:env=""http://schemas.xmlsoap.org/soap/envelope/"">" & _
        "<env:Header>" & _
        "<SessionID>" & CStr(sSessionID) & "</SessionID>" & _
        "</env:Header><env:Body>" & _
        "<dis:UpdateObject xmlns:dis=""http://www.sap.com/SBO/DIS"">" & _
        pXML.InnerXml & _
        "</dis:UpdateObject></env:Body></env:Envelope>"

        pDiServerNode = New SBODI_Server.Node

        'execute interact and return the result
        sResult = pDiServerNode.Interact(sAddCmd)

        pReturnXml = New Xml.XmlDocument

        'load result to xml document
        pReturnXml.LoadXml(sResult)

        'return result
        Return (RemoveEnv(pReturnXml))

    End Function

End Class

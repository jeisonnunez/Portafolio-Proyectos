Imports System.Web.Services

<System.Web.Services.WebService(Namespace:="http://tempuri.org/DISSample/Sample")> _
Public Class Sample
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

    ' Login to DI Server
    <WebMethod()> Public Function Login(ByVal DataBaseServer As String, _
                                        ByVal DataBaseName As String, _
                                        ByVal DataBaseType As String, _
                                        ByVal DataBaseUserName As String, _
                                        ByVal DataBasePassword As String, _
                                        ByVal CompanyUserName As String, _
                                        ByVal CompanyPassword As String, _
                                        ByVal Language As String, _
                                        ByVal LicenseServer As String, ByVal sPort As String) As String
        Dim DISnode As SBODI_Server.Node
        Dim sSOAPans, sCmd As String

        DISnode = New SBODI_Server.Node

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
        sCmd += "<LicenseServer>" & LicenseServer & ":" & sPort & "</LicenseServer>" 'ILTLVH25
        sCmd += "</dis:Login></env:Body></env:Envelope>"

        sSOAPans = DISnode.Interact(sCmd)

        ' Parse the SOAP answer
        Dim xmlValid As System.Xml.XmlValidatingReader
        Dim sRet As String
        xmlValid = New System.Xml.XmlValidatingReader(sSOAPans, System.Xml.XmlNodeType.Document, Nothing)
        While xmlValid.Read()
            If xmlValid.NodeType = System.Xml.XmlNodeType.Text Then
                If sRet = "" Then
                    sRet += xmlValid.Value
                Else
                    If sRet.StartsWith("Error") Then
                        sRet += " " & xmlValid.Value
                    Else
                        sRet = "Error " & sRet & " " & xmlValid.Value
                    End If
                End If
            End If
        End While
        If InStr(sSOAPans, "<env:Fault>") And (Not (sRet.StartsWith("Error"))) Then
            sRet = "Error: " & sRet
        End If
        Return sRet
    End Function

    ' This function returns a list of Business Parnters in an XML format
    <WebMethod()> Public Function GetBPList(ByVal SessionID As String, ByVal CardType As String) As Xml.XmlDocument
        Dim DISnode As SBODI_Server.Node
        Dim strSOAPans, strSOAPcmd As String
        Dim xmlDoc As Xml.XmlDocument

        xmlDoc = New Xml.XmlDocument
        DISnode = New SBODI_Server.Node

        strSOAPcmd = "<?xml version=""1.0"" encoding=""UTF-16""?>" & _
        "<env:Envelope xmlns:env=""http://schemas.xmlsoap.org/soap/envelope/"">" & _
        "<env:Header>" & _
        "<SessionID>" & CStr(SessionID) & "</SessionID>" & _
        "</env:Header><env:Body><dis:GetBPList xmlns:dis=""http://www.sap.com/SBO/DIS"">" & _
        "<CardType>" & CardType & "</CardType>" & _
        "</dis:GetBPList></env:Body></env:Envelope>"

        strSOAPans = DISnode.Interact(strSOAPcmd)
        xmlDoc.LoadXml(strSOAPans)
        Return (RemoveEnv(xmlDoc))
    End Function

    ' This function removes all the empty nodes from an XML document
    Private Function RemoveEmptyNodes(ByVal n As Xml.XmlNode) As Xml.XmlNode
        Dim nAns As Xml.XmlNode

        nAns = MarkEmptyNodes(n)
        Dim nc As Xml.XmlNodeList
        Dim sSelect As String

        sSelect = "//*[text()="""
        sSelect += sRem
        sSelect += """]"

        nc = nAns.SelectNodes(sSelect)
        For Each nN As Xml.XmlNode In nc
            nN.ParentNode.RemoveChild(nN)
        Next
        Return nAns
    End Function

    ' This function marks all the empty nodes with special text.
    ' The "RemoveEmptyNodes" function uses it to select the nodes to be deleted.
    Private Function MarkEmptyNodes(ByVal n As Xml.XmlNode) As Xml.XmlNode
        Dim MainNode As Xml.XmlNode
        MainNode = n
        Dim nI As Xml.XmlNode

        Dim i, Removed As Integer
        i = 0
        Removed = 0

        For i = 0 To MainNode.ChildNodes.Count - 1 - Removed
            nI = MainNode.ChildNodes(i)
            If nI.InnerText = "" Then
                nI.InnerText = sRem
            ElseIf nI.HasChildNodes Then
                nI = MarkEmptyNodes(nI)
            End If
        Next
        Return MainNode
    End Function

    ' This function adds a Business Parnter
    <WebMethod()> Public Function AddBP(ByVal SessionID As String, _
                                        ByVal xmlBPObject As String) As Xml.XmlDocument
        Dim n As SBODI_Server.Node
        Dim d, pXML As Xml.XmlDocument

        d = New Xml.XmlDocument
        n = New SBODI_Server.Node

        Dim AddCmd As String
        Dim netoXML As Xml.XmlNode

        pXML = New Xml.XmlDocument
        pXML.LoadXml(xmlBPObject)

        netoXML = (RemoveEmptyNodes(pXML))

        AddCmd = "<?xml version=""1.0"" encoding=""UTF-16""?>" & _
        "<env:Envelope xmlns:env=""http://schemas.xmlsoap.org/soap/envelope/"">" & _
        "<env:Header>" & _
        "<SessionID>" & CStr(SessionID) & "</SessionID>" & _
        "</env:Header><env:Body><dis:AddObject xmlns:dis=""http://www.sap.com/SBO/DIS"">" & _
        netoXML.InnerXml & _
        "</dis:AddObject></env:Body></env:Envelope>"

        Dim res As String
        res = n.Interact(AddCmd)
        d.LoadXml(res)
        Return (RemoveEnv(d))
    End Function

    ' This function removes the SOAP envelope
    Public Function RemoveEnv(ByVal xmlD As Xml.XmlDocument) As Xml.XmlDocument
        Dim d As Xml.XmlDocument
        Dim s As String

        d = New Xml.XmlDocument
        If InStr(xmlD.InnerXml, "<env:Fault>") Then
            Return xmlD
        Else
            s = xmlD.FirstChild.NextSibling.FirstChild.FirstChild.InnerXml
            d.LoadXml(s)
        End If

        Return d

    End Function

    ' This function returns an XML document of an empty Business Partner object
    <WebMethod()> Public Function GetEmptyBPXml(ByVal SessionID As String) As Xml.XmlDocument
        Dim n As SBODI_Server.Node
        Dim s, strXML As String
        Dim d As Xml.XmlDocument

        d = New Xml.XmlDocument
        n = New SBODI_Server.Node

        strXML = "<?xml version=""1.0"" encoding=""UTF-16""?>" & _
        "<env:Envelope xmlns:env=""http://schemas.xmlsoap.org/soap/envelope/"">" & _
        "<env:Header>" & _
        "<SessionID>" & CStr(SessionID) & "</SessionID>" & _
        "</env:Header><env:Body><dis:GetBusinessObjectTemplate xmlns:dis=""http://www.sap.com/SBO/DIS"">" & _
        "<Object>oBusinessPartners</Object>" & _
        "</dis:GetBusinessObjectTemplate></env:Body></env:Envelope>"

        s = n.Interact(strXML)
        d.LoadXml(s)
        Return (RemoveEnv(d))
    End Function

End Class

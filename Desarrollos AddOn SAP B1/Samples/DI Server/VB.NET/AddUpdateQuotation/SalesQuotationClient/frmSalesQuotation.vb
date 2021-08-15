'//  SAP MANAGE DI Server Api VERSION 2006 SDK Sample
'//****************************************************************************
'//
'//  File:      frmSalesQuotation.vb
'//
'//  Copyright (c) SAP MANAGE
'//
'// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
'// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
'// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
'// PARTICULAR PURPOSE.
'//
'//****************************************************************************


Public Class SalesQuotationForm
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
    Friend WithEvents cmdAddQuotation As System.Windows.Forms.Button
    Friend WithEvents txtXml As System.Windows.Forms.TextBox
    Friend WithEvents cmdUpdate As System.Windows.Forms.Button
    Friend WithEvents txtUpdate As System.Windows.Forms.TextBox
    Friend WithEvents txtBpCode As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtItemCode As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtItemQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txtUpQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtUpItemCode As System.Windows.Forms.TextBox
    Friend WithEvents lblDoc As System.Windows.Forms.Label
    Friend WithEvents txtDocNo As System.Windows.Forms.TextBox
    Friend WithEvents txtItem2Quant As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtItem2Code As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSessID As System.Windows.Forms.TextBox
    Friend WithEvents txtLicenseServer As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtLanguage As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCompanyPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCompanyUserName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDataBasePassword As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDataBaseUserName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDataBaseName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDataBaseServer As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdLogInComp As System.Windows.Forms.Button
    Friend WithEvents cmdLogOut As System.Windows.Forms.Button
    Friend WithEvents txtDataBaseType As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdAddQuotation = New System.Windows.Forms.Button
        Me.txtXml = New System.Windows.Forms.TextBox
        Me.cmdUpdate = New System.Windows.Forms.Button
        Me.txtUpdate = New System.Windows.Forms.TextBox
        Me.txtBpCode = New System.Windows.Forms.TextBox
        Me.txtItemCode = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtItemQuantity = New System.Windows.Forms.TextBox
        Me.txtUpQuantity = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtUpItemCode = New System.Windows.Forms.TextBox
        Me.lblDoc = New System.Windows.Forms.Label
        Me.txtDocNo = New System.Windows.Forms.TextBox
        Me.txtItem2Quant = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtItem2Code = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdLogOut = New System.Windows.Forms.Button
        Me.txtSessID = New System.Windows.Forms.TextBox
        Me.cmdLogInComp = New System.Windows.Forms.Button
        Me.txtLicenseServer = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtLanguage = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtCompanyPassword = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtCompanyUserName = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtDataBasePassword = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtDataBaseUserName = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtDataBaseName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtDataBaseServer = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtDataBaseType = New System.Windows.Forms.ComboBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdAddQuotation
        '
        Me.cmdAddQuotation.Location = New System.Drawing.Point(16, 224)
        Me.cmdAddQuotation.Name = "cmdAddQuotation"
        Me.cmdAddQuotation.Size = New System.Drawing.Size(96, 24)
        Me.cmdAddQuotation.TabIndex = 44
        Me.cmdAddQuotation.Text = "Add Quotation"
        '
        'txtXml
        '
        Me.txtXml.Location = New System.Drawing.Point(16, 304)
        Me.txtXml.Multiline = True
        Me.txtXml.Name = "txtXml"
        Me.txtXml.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtXml.Size = New System.Drawing.Size(352, 152)
        Me.txtXml.TabIndex = 46
        Me.txtXml.Text = ""
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Location = New System.Drawing.Point(400, 224)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(96, 24)
        Me.cmdUpdate.TabIndex = 48
        Me.cmdUpdate.Text = "Update"
        '
        'txtUpdate
        '
        Me.txtUpdate.Location = New System.Drawing.Point(400, 304)
        Me.txtUpdate.Multiline = True
        Me.txtUpdate.Name = "txtUpdate"
        Me.txtUpdate.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtUpdate.Size = New System.Drawing.Size(264, 152)
        Me.txtUpdate.TabIndex = 49
        Me.txtUpdate.Text = ""
        '
        'txtBpCode
        '
        Me.txtBpCode.Location = New System.Drawing.Point(176, 224)
        Me.txtBpCode.Name = "txtBpCode"
        Me.txtBpCode.Size = New System.Drawing.Size(56, 20)
        Me.txtBpCode.TabIndex = 50
        Me.txtBpCode.Text = "HU1003"
        '
        'txtItemCode
        '
        Me.txtItemCode.Location = New System.Drawing.Point(176, 248)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(56, 20)
        Me.txtItemCode.TabIndex = 51
        Me.txtItemCode.Text = "A00001"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(120, 248)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 16)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "Item Code"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(120, 226)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 16)
        Me.Label12.TabIndex = 53
        Me.Label12.Text = "BP Code"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(128, 272)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 16)
        Me.Label13.TabIndex = 54
        Me.Label13.Text = "Quatity"
        '
        'txtItemQuantity
        '
        Me.txtItemQuantity.Location = New System.Drawing.Point(176, 272)
        Me.txtItemQuantity.Name = "txtItemQuantity"
        Me.txtItemQuantity.Size = New System.Drawing.Size(56, 20)
        Me.txtItemQuantity.TabIndex = 55
        Me.txtItemQuantity.Text = "1"
        '
        'txtUpQuantity
        '
        Me.txtUpQuantity.Location = New System.Drawing.Point(568, 272)
        Me.txtUpQuantity.Name = "txtUpQuantity"
        Me.txtUpQuantity.TabIndex = 59
        Me.txtUpQuantity.Text = "3"
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(512, 272)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 16)
        Me.Label14.TabIndex = 58
        Me.Label14.Text = "Quatity"
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(504, 248)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 16)
        Me.Label15.TabIndex = 57
        Me.Label15.Text = "Item Code"
        '
        'txtUpItemCode
        '
        Me.txtUpItemCode.Location = New System.Drawing.Point(568, 248)
        Me.txtUpItemCode.Name = "txtUpItemCode"
        Me.txtUpItemCode.TabIndex = 56
        Me.txtUpItemCode.Text = "A00001"
        '
        'lblDoc
        '
        Me.lblDoc.Location = New System.Drawing.Point(504, 224)
        Me.lblDoc.Name = "lblDoc"
        Me.lblDoc.Size = New System.Drawing.Size(56, 16)
        Me.lblDoc.TabIndex = 61
        Me.lblDoc.Text = "Doc No."
        '
        'txtDocNo
        '
        Me.txtDocNo.Location = New System.Drawing.Point(568, 224)
        Me.txtDocNo.Name = "txtDocNo"
        Me.txtDocNo.TabIndex = 60
        Me.txtDocNo.Text = ""
        '
        'txtItem2Quant
        '
        Me.txtItem2Quant.Location = New System.Drawing.Point(304, 272)
        Me.txtItem2Quant.Name = "txtItem2Quant"
        Me.txtItem2Quant.Size = New System.Drawing.Size(64, 20)
        Me.txtItem2Quant.TabIndex = 65
        Me.txtItem2Quant.Text = "2"
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(248, 272)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 16)
        Me.Label16.TabIndex = 64
        Me.Label16.Text = "Quatity"
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(248, 248)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 16)
        Me.Label17.TabIndex = 63
        Me.Label17.Text = "Item Code"
        '
        'txtItem2Code
        '
        Me.txtItem2Code.Location = New System.Drawing.Point(304, 248)
        Me.txtItem2Code.Name = "txtItem2Code"
        Me.txtItem2Code.Size = New System.Drawing.Size(64, 20)
        Me.txtItem2Code.TabIndex = 62
        Me.txtItem2Code.Text = "A00002"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDataBaseType)
        Me.GroupBox1.Controls.Add(Me.cmdLogOut)
        Me.GroupBox1.Controls.Add(Me.txtSessID)
        Me.GroupBox1.Controls.Add(Me.cmdLogInComp)
        Me.GroupBox1.Controls.Add(Me.txtLicenseServer)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtLanguage)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtCompanyPassword)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtCompanyUserName)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtDataBasePassword)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtDataBaseUserName)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtDataBaseName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtDataBaseServer)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(664, 168)
        Me.GroupBox1.TabIndex = 66
        Me.GroupBox1.TabStop = False
        '
        'cmdLogOut
        '
        Me.cmdLogOut.Location = New System.Drawing.Point(576, 133)
        Me.cmdLogOut.Name = "cmdLogOut"
        Me.cmdLogOut.TabIndex = 66
        Me.cmdLogOut.Text = "Log Out"
        '
        'txtSessID
        '
        Me.txtSessID.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtSessID.Location = New System.Drawing.Point(110, 133)
        Me.txtSessID.Name = "txtSessID"
        Me.txtSessID.Size = New System.Drawing.Size(256, 20)
        Me.txtSessID.TabIndex = 63
        Me.txtSessID.Text = ""
        '
        'cmdLogInComp
        '
        Me.cmdLogInComp.Location = New System.Drawing.Point(14, 133)
        Me.cmdLogInComp.Name = "cmdLogInComp"
        Me.cmdLogInComp.TabIndex = 62
        Me.cmdLogInComp.Text = "Log In"
        '
        'txtLicenseServer
        '
        Me.txtLicenseServer.Location = New System.Drawing.Point(552, 40)
        Me.txtLicenseServer.Name = "txtLicenseServer"
        Me.txtLicenseServer.TabIndex = 61
        Me.txtLicenseServer.Text = "LOCALHOST:30000"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(464, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 16)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "License Server"
        '
        'txtLanguage
        '
        Me.txtLanguage.Location = New System.Drawing.Point(552, 16)
        Me.txtLanguage.Name = "txtLanguage"
        Me.txtLanguage.TabIndex = 59
        Me.txtLanguage.Text = "ln_English"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(464, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 16)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Language"
        '
        'txtCompanyPassword
        '
        Me.txtCompanyPassword.Location = New System.Drawing.Point(350, 85)
        Me.txtCompanyPassword.Name = "txtCompanyPassword"
        Me.txtCompanyPassword.TabIndex = 57
        Me.txtCompanyPassword.Text = "manager"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(238, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 24)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Company Password"
        '
        'txtCompanyUserName
        '
        Me.txtCompanyUserName.Location = New System.Drawing.Point(350, 61)
        Me.txtCompanyUserName.Name = "txtCompanyUserName"
        Me.txtCompanyUserName.TabIndex = 55
        Me.txtCompanyUserName.Text = "manager"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(238, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 16)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Company UserName"
        '
        'txtDataBasePassword
        '
        Me.txtDataBasePassword.Location = New System.Drawing.Point(350, 37)
        Me.txtDataBasePassword.Name = "txtDataBasePassword"
        Me.txtDataBasePassword.TabIndex = 53
        Me.txtDataBasePassword.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(238, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 16)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "DataBase Password"
        '
        'txtDataBaseUserName
        '
        Me.txtDataBaseUserName.Location = New System.Drawing.Point(350, 13)
        Me.txtDataBaseUserName.Name = "txtDataBaseUserName"
        Me.txtDataBaseUserName.TabIndex = 51
        Me.txtDataBaseUserName.Text = "sa"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(238, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 16)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "DataBase UserName"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(14, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 16)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "DataBase Type"
        '
        'txtDataBaseName
        '
        Me.txtDataBaseName.Location = New System.Drawing.Point(126, 37)
        Me.txtDataBaseName.Name = "txtDataBaseName"
        Me.txtDataBaseName.TabIndex = 47
        Me.txtDataBaseName.Text = "SBODemo_US"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(14, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 16)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "DataBase Name"
        '
        'txtDataBaseServer
        '
        Me.txtDataBaseServer.Location = New System.Drawing.Point(126, 13)
        Me.txtDataBaseServer.Name = "txtDataBaseServer"
        Me.txtDataBaseServer.TabIndex = 45
        Me.txtDataBaseServer.Text = "localhost"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(14, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 16)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "DataBase Server:"
        '
        'txtDataBaseType
        '
        Me.txtDataBaseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtDataBaseType.Items.AddRange(New Object() {"dst_MSSQL", "dst_DB_2", "dst_SYBASE", "dst_MSSQL2005", "dst_MAXDB"})
        Me.txtDataBaseType.Location = New System.Drawing.Point(128, 64)
        Me.txtDataBaseType.Name = "txtDataBaseType"
        Me.txtDataBaseType.Size = New System.Drawing.Size(104, 21)
        Me.txtDataBaseType.TabIndex = 67
        '
        'SalesQuotationForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(688, 469)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtItem2Quant)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtItem2Code)
        Me.Controls.Add(Me.lblDoc)
        Me.Controls.Add(Me.txtDocNo)
        Me.Controls.Add(Me.txtUpQuantity)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtUpItemCode)
        Me.Controls.Add(Me.txtItemQuantity)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtItemCode)
        Me.Controls.Add(Me.txtBpCode)
        Me.Controls.Add(Me.txtUpdate)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.txtXml)
        Me.Controls.Add(Me.cmdAddQuotation)
        Me.Name = "SalesQuotationForm"
        Me.Text = "Sales Quotation"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim oWsSalesQuotation As localhost1.DiServerServicesSample
    Dim msSessionID As String
    Dim msQuotationDocNum As String

    'The function Adds new Quotation with two items,
    'it builds the soap string using the Quotation template and
    'inserting the data into it
    Private Sub cmdAddQuotation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddQuotation.Click

        Dim oQuotationXml As Xml.XmlElement
        Dim oBpCode As Xml.XmlNodeList
        Dim oItemCode As Xml.XmlNode
        Dim oFirstRow As Xml.XmlNode
        Dim oNewRow As Xml.XmlNode
        Dim oTaxCode As Xml.XmlNode
        Dim oItemQuantity As Xml.XmlNode
        Dim oXmlReply As Xml.XmlElement
        Dim oDocumentLines As Xml.XmlNode

        Try

            'get an empty Quotation - get the Quotation template 
            'for filling the items later
            oQuotationXml = oWsSalesQuotation.GetEmptyQuotationXml(msSessionID)

            'get Bp ref
            oBpCode = oQuotationXml.SelectNodes("//CardCode")
            'adding Bp code -> bp that already exists
            oBpCode.Item(0).InnerText = txtBpCode.Text

            'change document type
            oQuotationXml.SelectSingleNode("//Object").InnerText = "oQuotations"

            '// add first item

            'get item ref
            oItemCode = oQuotationXml.SelectSingleNode("//ItemCode")
            'add item code,that already exists
            oItemCode.InnerText = txtItemCode.Text

            'get item ref
            oItemQuantity = oQuotationXml.SelectSingleNode("//Quantity")
            'Add item Quantity
            oItemQuantity.InnerText = txtItemQuantity.Text

            '//add second item

            'get ref to the Document_Lines
            oDocumentLines = oQuotationXml.SelectSingleNode("//Document_Lines")

            'get the first row 
            oFirstRow = oDocumentLines.FirstChild

            'copy the first row the th new one -> for getting the same structure
            oNewRow = oFirstRow.CloneNode(True)

            'update the new row
            'get item ref
            oItemCode = oNewRow.SelectSingleNode("//ItemCode")
            'add item code
            oItemCode.InnerText = txtItem2Code.Text

            'get item Quantity ref
            oItemQuantity = oNewRow.SelectSingleNode("//Quantity")
            'Add item Quantity
            oItemQuantity.InnerText = txtItem2Quant.Text

            'add the new row to the DocumentLines object
            oDocumentLines.AppendChild(oNewRow)

            txtXml.Text = oQuotationXml.OuterXml

            'Change mouse cursor
            Cursor = System.Windows.Forms.Cursors.WaitCursor

            'Add Quotation
            oXmlReply = oWsSalesQuotation.AddQuotation(txtSessID.Text, oQuotationXml.OuterXml)

            'Change mouse cursor
            Cursor = System.Windows.Forms.Cursors.Default

            Dim sRet As String

            'check for error
            If InStr(oXmlReply.InnerXml, "<env:Fault>") Then 'And (Not (sret.StartsWith("Error"))) Then
                sRet = "Error: " & oXmlReply.InnerXml
                MsgBox(sRet)
                Exit Sub
            End If

            'saves the Quotation key
            msQuotationDocNum = oXmlReply.InnerText

            txtDocNo.Text = msQuotationDocNum

            MsgBox("Quotation Added , DocNum=" & msQuotationDocNum)

            cmdUpdate.Enabled = True        
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & "Please try to add the same document using SBO and see if it is possible")
        End Try

    End Sub

    'The function updates an item in the Quotation ,
    'it builds the soap string without the template
    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        Try
            Dim sAddCmd As String
            Dim sItemCode As String
            Dim sQuantity As String
            Dim oXmlReply As Xml.XmlNode
            Dim sDocNum As String
            Dim sRet As String


            sItemCode = txtUpItemCode.Text
            sQuantity = txtUpQuantity.Text
            sDocNum = txtDocNo.Text

            'building the soap body without the template 
            'inserting oQuotations(enum), DocEntry(the Quotation key),
            'ItemCode & Item Quontity
            sAddCmd = "<BOM xmlns="""">" & _
                     "<BO>" & _
                     "<AdmInfo>" & _
                     "<Object>oQuotations</Object>" & _
                     "</AdmInfo>" & _
                     "<QueryParams>" & _
                     "<DocEntry>" & sDocNum & "</DocEntry>" & _
                     "</QueryParams>" & _
                     "<Document_Lines>" & _
                     "<row>" & _
                     "<ItemCode>" & sItemCode & "</ItemCode>" & _
                     "<Quantity>" & sQuantity & "</Quantity>" & _
                     "</row>" & _
                     "</Document_Lines>" & _
                     "</BO>" & _
                     "</BOM>"

            'show sCmd in textbox
            txtUpdate.Text = sAddCmd

            'Change mouse cursor
            Cursor = System.Windows.Forms.Cursors.WaitCursor

            'update quotation & return result - the quotation key
            oXmlReply = oWsSalesQuotation.UpdateQuotation(txtSessID.Text, sAddCmd)

            'Change mouse cursor
            Cursor = System.Windows.Forms.Cursors.Default

            'check for error
            If InStr(oXmlReply.InnerXml, "<env:Fault>") Then 'And (Not (sret.StartsWith("Error"))) Then
                sRet = "Error: " & oXmlReply.InnerXml
                MsgBox(sRet)
                Exit Sub
            End If

            MsgBox("Quotation " & oXmlReply.InnerText & " was updated")


        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & "Please try to add the same document using SBO and see if it is possible")
        End Try


    End Sub

    'LogIn to company
    Private Sub cmdLogInComp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogInComp.Click

        'Change mouse cursor
        Cursor = System.Windows.Forms.Cursors.WaitCursor

        'create new DiServerServicesSample object
        oWsSalesQuotation = New localhost1.DiServerServicesSample

        'log in to company
        msSessionID = oWsSalesQuotation.Login(txtDataBaseServer.Text, txtDataBaseName.Text, txtDataBaseType.Text, _
                                              txtDataBaseUserName.Text, txtDataBasePassword.Text, txtCompanyUserName.Text, _
                                              txtCompanyPassword.Text, txtLanguage.Text, txtLicenseServer.Text)

        'Change mouse cursor
        Cursor = System.Windows.Forms.Cursors.Default

        txtSessID.Text = msSessionID

        cmdAddQuotation.Enabled = True

    End Sub

    'LogOut from company
    Private Sub cmdLogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogOut.Click

        Dim sResult As String

        'create di-server-sample object
        oWsSalesQuotation = New localhost1.DiServerServicesSample

        'Change mouse cursor
        Cursor = System.Windows.Forms.Cursors.WaitCursor

        'log out
        sResult = oWsSalesQuotation.LogOut(msSessionID)

        'Change mouse cursor
        Cursor = System.Windows.Forms.Cursors.Default 'Change mouse cursor

        'check for error
        If InStr(sResult, "<env:Fault>") Then 'And (Not (sret.StartsWith("Error"))) Then
            sResult = "Error: " & sResult
            MsgBox(sResult)
            Exit Sub
        Else
            MsgBox("Logged Out")
        End If

        cmdAddQuotation.Enabled = False
        cmdUpdate.Enabled = False
        cmdLogInComp.Enabled = True

    End Sub

    Private Sub SalesQuotationForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtDataBaseType.Text = "dst_MSSQL2005"
        'initiate command buttons
        cmdAddQuotation.Enabled = False
        cmdUpdate.Enabled = False

    End Sub

End Class

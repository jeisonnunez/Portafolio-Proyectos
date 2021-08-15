'//  SAP MANAGE DI API 2007 SDK Sample
'//****************************************************************************
'//
'//  File:      FrmMain.vb
'//
'//  Copyright (c) SAP MANAGE
'//
'// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
'// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
'// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
'// PARTICULAR PURPOSE.
'//
'// BEFORE STARTING:
'// Add reference to the "SAP Business One Objects Bridge Version 2005"
'//-----------------------------------------------------------------
'// 1. Project->References
'// 2. check the "SAP Business One Objects Bridge Version 2005" check box
'//****************************************************************************

Public Class FrmMain
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
    Friend WithEvents cmdLoadXML As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpConn As System.Windows.Forms.GroupBox
    Friend WithEvents cmdGetCompanyList As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbDBType As System.Windows.Forms.ComboBox
    Friend WithEvents cmdConnect As System.Windows.Forms.Button
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUSer As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents cmbCompany As System.Windows.Forms.ComboBox
    Friend WithEvents lblCompany As System.Windows.Forms.Label
    Friend WithEvents txtDBPass As System.Windows.Forms.TextBox
    Friend WithEvents txtDBUser As System.Windows.Forms.TextBox
    Friend WithEvents lblPass As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdLoadXML = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.grpConn = New System.Windows.Forms.GroupBox
        Me.cmdGetCompanyList = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbDBType = New System.Windows.Forms.ComboBox
        Me.cmdConnect = New System.Windows.Forms.Button
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.txtUSer = New System.Windows.Forms.TextBox
        Me.lblPassword = New System.Windows.Forms.Label
        Me.lblUser = New System.Windows.Forms.Label
        Me.cmbCompany = New System.Windows.Forms.ComboBox
        Me.lblCompany = New System.Windows.Forms.Label
        Me.txtDBPass = New System.Windows.Forms.TextBox
        Me.txtDBUser = New System.Windows.Forms.TextBox
        Me.lblPass = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.grpConn.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdLoadXML
        '
        Me.cmdLoadXML.Enabled = False
        Me.cmdLoadXML.Location = New System.Drawing.Point(176, 336)
        Me.cmdLoadXML.Name = "cmdLoadXML"
        Me.cmdLoadXML.TabIndex = 7
        Me.cmdLoadXML.Text = "Load XML"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 224)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 96)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "This program will try to load some business partner and item object found in an X" & _
        "ml file. This will be done within one DB transaction. If one object will fail, t" & _
        "he transaction will be rolled back, meaning that none of the objects will be add" & _
        "ed to the data base."
        '
        'grpConn
        '
        Me.grpConn.Controls.Add(Me.txtDBPass)
        Me.grpConn.Controls.Add(Me.txtDBUser)
        Me.grpConn.Controls.Add(Me.lblPass)
        Me.grpConn.Controls.Add(Me.Label4)
        Me.grpConn.Controls.Add(Me.cmdGetCompanyList)
        Me.grpConn.Controls.Add(Me.Label2)
        Me.grpConn.Controls.Add(Me.cmbDBType)
        Me.grpConn.Controls.Add(Me.cmdConnect)
        Me.grpConn.Controls.Add(Me.txtPassword)
        Me.grpConn.Controls.Add(Me.txtUSer)
        Me.grpConn.Controls.Add(Me.lblPassword)
        Me.grpConn.Controls.Add(Me.lblUser)
        Me.grpConn.Controls.Add(Me.cmbCompany)
        Me.grpConn.Controls.Add(Me.lblCompany)
        Me.grpConn.Location = New System.Drawing.Point(0, 8)
        Me.grpConn.Name = "grpConn"
        Me.grpConn.Size = New System.Drawing.Size(416, 200)
        Me.grpConn.TabIndex = 9
        Me.grpConn.TabStop = False
        Me.grpConn.Text = "Connection Properties"
        '
        'cmdGetCompanyList
        '
        Me.cmdGetCompanyList.Location = New System.Drawing.Point(8, 80)
        Me.cmdGetCompanyList.Name = "cmdGetCompanyList"
        Me.cmdGetCompanyList.Size = New System.Drawing.Size(112, 24)
        Me.cmdGetCompanyList.TabIndex = 15
        Me.cmdGetCompanyList.Text = "Get Company List"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 23)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Database Type"
        '
        'cmbDBType
        '
        Me.cmbDBType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDBType.Items.AddRange(New Object() {"MSSQL", "DB_2", "SYBASE", "MSSQL2005", "MAXDB"})
        Me.cmbDBType.Location = New System.Drawing.Point(120, 24)
        Me.cmbDBType.Name = "cmbDBType"
        Me.cmbDBType.Size = New System.Drawing.Size(121, 21)
        Me.cmbDBType.TabIndex = 13
        '
        'cmdConnect
        '
        Me.cmdConnect.Enabled = False
        Me.cmdConnect.Location = New System.Drawing.Point(304, 160)
        Me.cmdConnect.Name = "cmdConnect"
        Me.cmdConnect.Size = New System.Drawing.Size(88, 24)
        Me.cmdConnect.TabIndex = 12
        Me.cmdConnect.Text = "Connect"
        '
        'txtPassword
        '
        Me.txtPassword.Enabled = False
        Me.txtPassword.Location = New System.Drawing.Point(120, 144)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(88, 20)
        Me.txtPassword.TabIndex = 11
        Me.txtPassword.Text = "manager"
        '
        'txtUSer
        '
        Me.txtUSer.Enabled = False
        Me.txtUSer.Location = New System.Drawing.Point(120, 120)
        Me.txtUSer.Name = "txtUSer"
        Me.txtUSer.Size = New System.Drawing.Size(88, 20)
        Me.txtUSer.TabIndex = 10
        Me.txtUSer.Text = "manager"
        '
        'lblPassword
        '
        Me.lblPassword.Location = New System.Drawing.Point(56, 144)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(64, 23)
        Me.lblPassword.TabIndex = 9
        Me.lblPassword.Text = "Password"
        '
        'lblUser
        '
        Me.lblUser.Location = New System.Drawing.Point(56, 120)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(64, 23)
        Me.lblUser.TabIndex = 8
        Me.lblUser.Text = "User Name"
        '
        'cmbCompany
        '
        Me.cmbCompany.Enabled = False
        Me.cmbCompany.Location = New System.Drawing.Point(256, 80)
        Me.cmbCompany.Name = "cmbCompany"
        Me.cmbCompany.Size = New System.Drawing.Size(121, 21)
        Me.cmbCompany.TabIndex = 7
        '
        'lblCompany
        '
        Me.lblCompany.Location = New System.Drawing.Point(144, 80)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(104, 23)
        Me.lblCompany.TabIndex = 6
        Me.lblCompany.Text = "Company Database"
        '
        'txtDBPass
        '
        Me.txtDBPass.Location = New System.Drawing.Point(328, 48)
        Me.txtDBPass.Name = "txtDBPass"
        Me.txtDBPass.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtDBPass.Size = New System.Drawing.Size(72, 20)
        Me.txtDBPass.TabIndex = 41
        Me.txtDBPass.Text = ""
        '
        'txtDBUser
        '
        Me.txtDBUser.Location = New System.Drawing.Point(328, 24)
        Me.txtDBUser.Name = "txtDBUser"
        Me.txtDBUser.Size = New System.Drawing.Size(72, 20)
        Me.txtDBUser.TabIndex = 39
        Me.txtDBUser.Text = "sa"
        '
        'lblPass
        '
        Me.lblPass.Location = New System.Drawing.Point(248, 48)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(80, 16)
        Me.lblPass.TabIndex = 42
        Me.lblPass.Text = "DB Password"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(248, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "DB Username"
        '
        'FrmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(424, 373)
        Me.Controls.Add(Me.grpConn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdLoadXML)
        Me.Name = "FrmMain"
        Me.Text = "Load XML"
        Me.grpConn.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public oCompany As SAPbobsCOM.Company

    Public sErrMsg As String
    Public lErrCode As Long
    Public lRetCode As Long

    Private oBusinessPartner As SAPbobsCOM.BusinessPartners
    Private oItem As SAPbobsCOM.Items
    Private oRecordSet As SAPbobsCOM.Recordset

    Private Sub FrmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbDBType.SelectedIndex = 3
    End Sub

    Private Sub cmdConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConnect.Click
        '// setting the rest of the mandatory properties

        oCompany.CompanyDB = cmbCompany.Text
        oCompany.UserName = txtUSer.Text
        oCompany.Password = txtPassword.Text

        '// Connecting to a company DB
        lRetCode = oCompany.Connect

        '// Check for errors
        If lRetCode <> 0 Then
            oCompany.GetLastError(lErrCode, sErrMsg)
            MsgBox(sErrMsg)
        Else
            MsgBox("Connected to " & oCompany.CompanyName)
            cmbCompany.Enabled = False
            txtPassword.Enabled = False
            txtUSer.Enabled = False
            cmdConnect.Enabled = False
            cmdLoadXML.Enabled = True
        End If

    End Sub

    Private Sub InitializeCompany()

        '// Initialize the Company Object.
        '// Create a new company object
        oCompany = New SAPbobsCOM.Company

        '// Set the mandatory properties for the connection to the database.
        '// here I bring only 2 of the 5 mandatory fields.
        '// To use a remote Db Server enter his name instead of the string "(local)"
        '// This string is used to work on a DB installed on your local machine
        '// the other mandatory fields are CompanyDB, UserName and Password
        '// I am setting those fields in the ChooseCompany Form

        oCompany.Server = "(local)"
        oCompany.language = SAPbobsCOM.BoSuppLangs.ln_English

        '// Use Windows authentication for database server.
        '// True for NT server authentication,
        '// False for database server authentication.
        oCompany.UseTrusted = True

    End Sub

    Private Sub cmdLoadXML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLoadXML.Click
        LoadObjectsFromXML()
    End Sub

    Private Sub LoadObjectsFromXML()

        Dim sXmlFileName As String

        Dim iElementCount As Long

        Dim iCounter As Long

        '// setting the file name

        sXmlFileName = IO.Directory.GetParent(System.Windows.Forms.Application.StartupPath).ToString & "\xml\BPandContacts.xml"

        '// Get the number of Business object in the file ...

        iElementCount = oCompany.GetXMLelementCount(sXmlFileName)

        MsgBox(iElementCount & " Elemnts found in xml file" & vbNewLine & "Ready To Satrt Transaction")

        '// start a transaction
        '// starting a transaction means that nothing changes in the DB
        '// untill we end the transaction with the commit flag

        '// if an error is encountered the transaction rolls back
        '// which means that all changes as of the StartTransaction
        '// are discarded

        oCompany.StartTransaction()

        '// Run a loop through the objects and when with in the file
        '// and the objects to the DB

        For iCounter = 0 To iElementCount - 1

            '// get the objects type at the specified position
            oCompany.XmlExportType = SAPbobsCOM.BoXmlExportTypes.xet_ExportImportMode
            Select Case oCompany.GetXMLobjectType(sXmlFileName, iCounter)

                Case SAPbobsCOM.BoObjectTypes.oBusinessPartners
                    '// get the business object data from the file
                    oBusinessPartner = oCompany.GetBusinessObjectFromXML(sXmlFileName, iCounter)
                    '// add the object to the data base
                    oBusinessPartner.Add()

                Case SAPbobsCOM.BoObjectTypes.oItems
                    '// get the business object data from the file
                    oItem = oCompany.GetBusinessObjectFromXML(sXmlFileName, iCounter)
                    '// add the object to the data base
                    oItem.Add()
            End Select

            '// Check for errors during connect
            '// if an error is encountered the transaction will
            '// terminate automatically
            oCompany.GetLastError(lErrCode, sErrMsg)
            If lErrCode <> 0 Then
                MsgBox("Error Message: " & sErrMsg & vbNewLine & "Transaction will be rolled back")

                '// exiting the sub
                Exit Sub

            End If

        Next iCounter

        '// the objects will added to the DB only at this point
        oCompany.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit)

        MsgBox("Data inserted successfully")

    End Sub

    Private Sub cmdGetCompanyList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetCompanyList.Click
        oCompany = New SAPbobsCOM.Company

        ' Init Connection Properties
        oCompany.DbServerType = cmbDBType.SelectedIndex + 1
        oCompany.Server = "localhost" ' change to your company server
        oCompany.language = SAPbobsCOM.BoSuppLangs.ln_English ' change to your language
        oCompany.UseTrusted = False
        oCompany.DbUserName = txtDBUser.Text
        oCompany.DbPassword = txtDBPass.Text


        'Me.Show() ' shows the form while it's loaded...

        'Create a list of companies...
        Try
            oRecordSet = oCompany.GetCompanyList ' get the company list
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        oCompany.GetLastError(lErrCode, sErrMsg)

        If lErrCode <> 0 Then
            MsgBox(sErrMsg)
        Else
            Do Until oRecordSet.EoF = True
                cmbCompany.Items.Add(oRecordSet.Fields.Item(0).Value)
                oRecordSet.MoveNext()
            Loop

            'Disable Controls
            cmdGetCompanyList.Enabled = False
            cmbDBType.Enabled = False

            'Enable Controls
            txtUSer.Enabled = True
            txtPassword.Enabled = True
            cmdConnect.Enabled = True
            cmbCompany.Enabled = True

        End If

        'Select the first company as default
        If cmbCompany.Items.Count > 0 Then
            cmbCompany.SelectedIndex = 0
        Else
            MsgBox("There was no Database Found...", , "Database not found...")
            End ' Terminate Application...
        End If

        If oCompany.Connected Then ' if already connected
            Me.Text = Me.Text & ": Connected"
            ' Remove the following 2 remark lines if you want to try to connect automatically
            'Else
            'Connect()
        End If

    End Sub
End Class

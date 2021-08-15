
'****************************************************************************
'  SAP MANAGE DI API 2007 SDK Sample
'****************************************************************************
'
'  Copyright (c) SAP MANAGE
'
' THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
' ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
' THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
' PARTICULAR PURPOSE.
'
'****************************************************************************
' In this sample the SAP Business one order form is imitated via DI 2005
'****************************************************************************

Option Explicit On 

Public Class frmMain
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
    Friend WithEvents grpConn As System.Windows.Forms.GroupBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUSer As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents cmbCompany As System.Windows.Forms.ComboBox
    Friend WithEvents lblCompany As System.Windows.Forms.Label
    Friend WithEvents cmdConnect As System.Windows.Forms.Button
    Friend WithEvents grpOrder As System.Windows.Forms.GroupBox
    Friend WithEvents lstCntctCodes As System.Windows.Forms.ListBox
    Friend WithEvents lstPhones As System.Windows.Forms.ListBox
    Friend WithEvents cmbName As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents lblCurrency As System.Windows.Forms.Label
    Friend WithEvents cmbCurrency As System.Windows.Forms.ComboBox
    Friend WithEvents cmbContactPerson As System.Windows.Forms.ComboBox
    Friend WithEvents DateDelivery As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDeliveryDate As System.Windows.Forms.Label
    Friend WithEvents DatePosting As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblPostingDate As System.Windows.Forms.Label
    Friend WithEvents txtNo As System.Windows.Forms.TextBox
    Friend WithEvents lblNo As System.Windows.Forms.Label
    Friend WithEvents chkManual As System.Windows.Forms.CheckBox
    Friend WithEvents txtReference As System.Windows.Forms.TextBox
    Friend WithEvents lblReference As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblContactPerson As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblCustomer As System.Windows.Forms.Label
    Friend WithEvents cmdInvoice As System.Windows.Forms.Button
    Friend WithEvents cmdAddOrder As System.Windows.Forms.Button
    Friend WithEvents tabOrder As System.Windows.Forms.TabControl
    Friend WithEvents pageContents As System.Windows.Forms.TabPage
    Friend WithEvents cmbTax As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblItemCode As System.Windows.Forms.Label
    Friend WithEvents cmdAddItem As System.Windows.Forms.Button
    Friend WithEvents cmbItemsDesc As System.Windows.Forms.ComboBox
    Friend WithEvents cmbItemsCode As System.Windows.Forms.ComboBox
    Friend WithEvents DataLines As System.Windows.Forms.DataGrid
    Friend WithEvents lblItemName As System.Windows.Forms.Label
    Friend WithEvents pageLogistics As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pageAccounting As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdChoose As System.Windows.Forms.Button
    Friend WithEvents txtCcode As System.Windows.Forms.TextBox
    Friend WithEvents txtCName As System.Windows.Forms.TextBox
    Friend WithEvents cmbDBType As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdGetCompanyList As System.Windows.Forms.Button
    Friend WithEvents txtDBPass As System.Windows.Forms.TextBox
    Friend WithEvents txtDBUser As System.Windows.Forms.TextBox
    Friend WithEvents lblPass As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMain))
        Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
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
        Me.grpOrder = New System.Windows.Forms.GroupBox
        Me.txtCName = New System.Windows.Forms.TextBox
        Me.txtCcode = New System.Windows.Forms.TextBox
        Me.cmdChoose = New System.Windows.Forms.Button
        Me.cmdInvoice = New System.Windows.Forms.Button
        Me.cmdAddOrder = New System.Windows.Forms.Button
        Me.tabOrder = New System.Windows.Forms.TabControl
        Me.pageContents = New System.Windows.Forms.TabPage
        Me.cmbTax = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblItemCode = New System.Windows.Forms.Label
        Me.cmdAddItem = New System.Windows.Forms.Button
        Me.cmbItemsDesc = New System.Windows.Forms.ComboBox
        Me.cmbItemsCode = New System.Windows.Forms.ComboBox
        Me.DataLines = New System.Windows.Forms.DataGrid
        Me.lblItemName = New System.Windows.Forms.Label
        Me.pageLogistics = New System.Windows.Forms.TabPage
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.pageAccounting = New System.Windows.Forms.TabPage
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.lstCntctCodes = New System.Windows.Forms.ListBox
        Me.lstPhones = New System.Windows.Forms.ListBox
        Me.cmbName = New System.Windows.Forms.ComboBox
        Me.cmbCustomer = New System.Windows.Forms.ComboBox
        Me.lblCurrency = New System.Windows.Forms.Label
        Me.cmbCurrency = New System.Windows.Forms.ComboBox
        Me.cmbContactPerson = New System.Windows.Forms.ComboBox
        Me.DateDelivery = New System.Windows.Forms.DateTimePicker
        Me.lblDeliveryDate = New System.Windows.Forms.Label
        Me.DatePosting = New System.Windows.Forms.DateTimePicker
        Me.lblPostingDate = New System.Windows.Forms.Label
        Me.txtNo = New System.Windows.Forms.TextBox
        Me.lblNo = New System.Windows.Forms.Label
        Me.chkManual = New System.Windows.Forms.CheckBox
        Me.txtReference = New System.Windows.Forms.TextBox
        Me.lblReference = New System.Windows.Forms.Label
        Me.txtPhone = New System.Windows.Forms.TextBox
        Me.lblPhone = New System.Windows.Forms.Label
        Me.lblContactPerson = New System.Windows.Forms.Label
        Me.lblName = New System.Windows.Forms.Label
        Me.lblCustomer = New System.Windows.Forms.Label
        Me.txtDBPass = New System.Windows.Forms.TextBox
        Me.txtDBUser = New System.Windows.Forms.TextBox
        Me.lblPass = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.grpConn.SuspendLayout()
        Me.grpOrder.SuspendLayout()
        Me.tabOrder.SuspendLayout()
        Me.pageContents.SuspendLayout()
        CType(Me.DataLines, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pageLogistics.SuspendLayout()
        Me.pageAccounting.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpConn
        '
        Me.grpConn.Controls.Add(Me.txtDBPass)
        Me.grpConn.Controls.Add(Me.txtDBUser)
        Me.grpConn.Controls.Add(Me.lblPass)
        Me.grpConn.Controls.Add(Me.Label3)
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
        Me.grpConn.Location = New System.Drawing.Point(8, 8)
        Me.grpConn.Name = "grpConn"
        Me.grpConn.Size = New System.Drawing.Size(560, 128)
        Me.grpConn.TabIndex = 7
        Me.grpConn.TabStop = False
        Me.grpConn.Text = "Connection Properties"
        '
        'cmdGetCompanyList
        '
        Me.cmdGetCompanyList.Location = New System.Drawing.Point(416, 24)
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
        Me.cmdConnect.Location = New System.Drawing.Point(456, 88)
        Me.cmdConnect.Name = "cmdConnect"
        Me.cmdConnect.Size = New System.Drawing.Size(88, 24)
        Me.cmdConnect.TabIndex = 12
        Me.cmdConnect.Text = "Connect"
        '
        'txtPassword
        '
        Me.txtPassword.Enabled = False
        Me.txtPassword.Location = New System.Drawing.Point(344, 96)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(72, 20)
        Me.txtPassword.TabIndex = 11
        Me.txtPassword.Text = "manager"
        '
        'txtUSer
        '
        Me.txtUSer.Enabled = False
        Me.txtUSer.Location = New System.Drawing.Point(344, 72)
        Me.txtUSer.Name = "txtUSer"
        Me.txtUSer.Size = New System.Drawing.Size(72, 20)
        Me.txtUSer.TabIndex = 10
        Me.txtUSer.Text = "manager"
        '
        'lblPassword
        '
        Me.lblPassword.Location = New System.Drawing.Point(248, 96)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(88, 23)
        Me.lblPassword.TabIndex = 9
        Me.lblPassword.Text = "SBO Password"
        '
        'lblUser
        '
        Me.lblUser.Location = New System.Drawing.Point(248, 72)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(88, 23)
        Me.lblUser.TabIndex = 8
        Me.lblUser.Text = "SBO User Name"
        '
        'cmbCompany
        '
        Me.cmbCompany.Enabled = False
        Me.cmbCompany.Location = New System.Drawing.Point(120, 72)
        Me.cmbCompany.Name = "cmbCompany"
        Me.cmbCompany.Size = New System.Drawing.Size(121, 21)
        Me.cmbCompany.TabIndex = 7
        '
        'lblCompany
        '
        Me.lblCompany.Location = New System.Drawing.Point(8, 72)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(104, 23)
        Me.lblCompany.TabIndex = 6
        Me.lblCompany.Text = "Company Database"
        '
        'grpOrder
        '
        Me.grpOrder.Controls.Add(Me.txtCName)
        Me.grpOrder.Controls.Add(Me.txtCcode)
        Me.grpOrder.Controls.Add(Me.cmdChoose)
        Me.grpOrder.Controls.Add(Me.cmdInvoice)
        Me.grpOrder.Controls.Add(Me.cmdAddOrder)
        Me.grpOrder.Controls.Add(Me.tabOrder)
        Me.grpOrder.Controls.Add(Me.lstCntctCodes)
        Me.grpOrder.Controls.Add(Me.lstPhones)
        Me.grpOrder.Controls.Add(Me.cmbName)
        Me.grpOrder.Controls.Add(Me.cmbCustomer)
        Me.grpOrder.Controls.Add(Me.lblCurrency)
        Me.grpOrder.Controls.Add(Me.cmbCurrency)
        Me.grpOrder.Controls.Add(Me.cmbContactPerson)
        Me.grpOrder.Controls.Add(Me.DateDelivery)
        Me.grpOrder.Controls.Add(Me.lblDeliveryDate)
        Me.grpOrder.Controls.Add(Me.DatePosting)
        Me.grpOrder.Controls.Add(Me.lblPostingDate)
        Me.grpOrder.Controls.Add(Me.txtNo)
        Me.grpOrder.Controls.Add(Me.lblNo)
        Me.grpOrder.Controls.Add(Me.chkManual)
        Me.grpOrder.Controls.Add(Me.txtReference)
        Me.grpOrder.Controls.Add(Me.lblReference)
        Me.grpOrder.Controls.Add(Me.txtPhone)
        Me.grpOrder.Controls.Add(Me.lblPhone)
        Me.grpOrder.Controls.Add(Me.lblContactPerson)
        Me.grpOrder.Controls.Add(Me.lblName)
        Me.grpOrder.Controls.Add(Me.lblCustomer)
        Me.grpOrder.Enabled = False
        Me.grpOrder.Location = New System.Drawing.Point(8, 144)
        Me.grpOrder.Name = "grpOrder"
        Me.grpOrder.Size = New System.Drawing.Size(560, 432)
        Me.grpOrder.TabIndex = 43
        Me.grpOrder.TabStop = False
        Me.grpOrder.Text = "Order Details"
        '
        'txtCName
        '
        Me.txtCName.Enabled = False
        Me.txtCName.Location = New System.Drawing.Point(64, 48)
        Me.txtCName.Name = "txtCName"
        Me.txtCName.TabIndex = 70
        Me.txtCName.Text = ""
        '
        'txtCcode
        '
        Me.txtCcode.Enabled = False
        Me.txtCcode.Location = New System.Drawing.Point(64, 24)
        Me.txtCcode.Name = "txtCcode"
        Me.txtCcode.TabIndex = 69
        Me.txtCcode.Text = ""
        '
        'cmdChoose
        '
        Me.cmdChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdChoose.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdChoose.Image = CType(resources.GetObject("cmdChoose.Image"), System.Drawing.Image)
        Me.cmdChoose.Location = New System.Drawing.Point(176, 24)
        Me.cmdChoose.Name = "cmdChoose"
        Me.cmdChoose.Size = New System.Drawing.Size(16, 16)
        Me.cmdChoose.TabIndex = 67
        Me.cmdChoose.TabStop = False
        '
        'cmdInvoice
        '
        Me.cmdInvoice.Enabled = False
        Me.cmdInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.cmdInvoice.Location = New System.Drawing.Point(104, 392)
        Me.cmdInvoice.Name = "cmdInvoice"
        Me.cmdInvoice.Size = New System.Drawing.Size(424, 24)
        Me.cmdInvoice.TabIndex = 66
        Me.cmdInvoice.Text = "Add an Invoice based on this Order"
        '
        'cmdAddOrder
        '
        Me.cmdAddOrder.Enabled = False
        Me.cmdAddOrder.Location = New System.Drawing.Point(16, 392)
        Me.cmdAddOrder.Name = "cmdAddOrder"
        Me.cmdAddOrder.TabIndex = 65
        Me.cmdAddOrder.Text = "Add Order"
        '
        'tabOrder
        '
        Me.tabOrder.Controls.Add(Me.pageContents)
        Me.tabOrder.Controls.Add(Me.pageLogistics)
        Me.tabOrder.Controls.Add(Me.pageAccounting)
        Me.tabOrder.Location = New System.Drawing.Point(8, 160)
        Me.tabOrder.Name = "tabOrder"
        Me.tabOrder.SelectedIndex = 0
        Me.tabOrder.Size = New System.Drawing.Size(536, 216)
        Me.tabOrder.TabIndex = 64
        '
        'pageContents
        '
        Me.pageContents.Controls.Add(Me.cmbTax)
        Me.pageContents.Controls.Add(Me.Label1)
        Me.pageContents.Controls.Add(Me.lblItemCode)
        Me.pageContents.Controls.Add(Me.cmdAddItem)
        Me.pageContents.Controls.Add(Me.cmbItemsDesc)
        Me.pageContents.Controls.Add(Me.cmbItemsCode)
        Me.pageContents.Controls.Add(Me.DataLines)
        Me.pageContents.Controls.Add(Me.lblItemName)
        Me.pageContents.Location = New System.Drawing.Point(4, 22)
        Me.pageContents.Name = "pageContents"
        Me.pageContents.Size = New System.Drawing.Size(528, 190)
        Me.pageContents.TabIndex = 0
        Me.pageContents.Text = "Contents"
        '
        'cmbTax
        '
        Me.cmbTax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTax.Location = New System.Drawing.Point(376, 16)
        Me.cmbTax.Name = "cmbTax"
        Me.cmbTax.Size = New System.Drawing.Size(56, 21)
        Me.cmbTax.TabIndex = 46
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(352, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 20)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Tax"
        '
        'lblItemCode
        '
        Me.lblItemCode.Location = New System.Drawing.Point(8, 16)
        Me.lblItemCode.Name = "lblItemCode"
        Me.lblItemCode.Size = New System.Drawing.Size(32, 20)
        Me.lblItemCode.TabIndex = 43
        Me.lblItemCode.Text = "Code"
        '
        'cmdAddItem
        '
        Me.cmdAddItem.Location = New System.Drawing.Point(448, 16)
        Me.cmdAddItem.Name = "cmdAddItem"
        Me.cmdAddItem.Size = New System.Drawing.Size(72, 23)
        Me.cmdAddItem.TabIndex = 3
        Me.cmdAddItem.Text = "Add Item"
        '
        'cmbItemsDesc
        '
        Me.cmbItemsDesc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbItemsDesc.Location = New System.Drawing.Point(184, 16)
        Me.cmbItemsDesc.Name = "cmbItemsDesc"
        Me.cmbItemsDesc.Size = New System.Drawing.Size(168, 21)
        Me.cmbItemsDesc.TabIndex = 2
        '
        'cmbItemsCode
        '
        Me.cmbItemsCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbItemsCode.Location = New System.Drawing.Point(40, 16)
        Me.cmbItemsCode.Name = "cmbItemsCode"
        Me.cmbItemsCode.Size = New System.Drawing.Size(112, 21)
        Me.cmbItemsCode.TabIndex = 1
        '
        'DataLines
        '
        Me.DataLines.AllowSorting = False
        Me.DataLines.CaptionText = CType(configurationAppSettings.GetValue("DataLines.CaptionText", GetType(System.String)), String)
        Me.DataLines.CaptionVisible = CType(configurationAppSettings.GetValue("DataLines.CaptionVisible", GetType(System.Boolean)), Boolean)
        Me.DataLines.DataMember = ""
        Me.DataLines.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataLines.Location = New System.Drawing.Point(8, 48)
        Me.DataLines.Name = "DataLines"
        Me.DataLines.Size = New System.Drawing.Size(464, 96)
        Me.DataLines.TabIndex = 0
        '
        'lblItemName
        '
        Me.lblItemName.Location = New System.Drawing.Point(152, 16)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(40, 20)
        Me.lblItemName.TabIndex = 44
        Me.lblItemName.Text = "Name"
        '
        'pageLogistics
        '
        Me.pageLogistics.Controls.Add(Me.PictureBox1)
        Me.pageLogistics.Location = New System.Drawing.Point(4, 22)
        Me.pageLogistics.Name = "pageLogistics"
        Me.pageLogistics.Size = New System.Drawing.Size(528, 190)
        Me.pageLogistics.TabIndex = 1
        Me.pageLogistics.Text = "Logistics"
        Me.pageLogistics.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(176, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(176, 176)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'pageAccounting
        '
        Me.pageAccounting.Controls.Add(Me.PictureBox2)
        Me.pageAccounting.Location = New System.Drawing.Point(4, 22)
        Me.pageAccounting.Name = "pageAccounting"
        Me.pageAccounting.Size = New System.Drawing.Size(528, 190)
        Me.pageAccounting.TabIndex = 2
        Me.pageAccounting.Text = "Accounting"
        Me.pageAccounting.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(176, 7)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(176, 176)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'lstCntctCodes
        '
        Me.lstCntctCodes.Location = New System.Drawing.Point(416, 24)
        Me.lstCntctCodes.Name = "lstCntctCodes"
        Me.lstCntctCodes.Size = New System.Drawing.Size(120, 17)
        Me.lstCntctCodes.TabIndex = 63
        Me.lstCntctCodes.Visible = False
        '
        'lstPhones
        '
        Me.lstPhones.Location = New System.Drawing.Point(416, 48)
        Me.lstPhones.Name = "lstPhones"
        Me.lstPhones.Size = New System.Drawing.Size(120, 17)
        Me.lstPhones.TabIndex = 62
        Me.lstPhones.Visible = False
        '
        'cmbName
        '
        Me.cmbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbName.Location = New System.Drawing.Point(440, 104)
        Me.cmbName.Name = "cmbName"
        Me.cmbName.Size = New System.Drawing.Size(88, 21)
        Me.cmbName.TabIndex = 44
        Me.cmbName.Visible = False
        '
        'cmbCustomer
        '
        Me.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCustomer.DropDownWidth = 200
        Me.cmbCustomer.Location = New System.Drawing.Point(440, 80)
        Me.cmbCustomer.MaxDropDownItems = 15
        Me.cmbCustomer.Name = "cmbCustomer"
        Me.cmbCustomer.Size = New System.Drawing.Size(88, 21)
        Me.cmbCustomer.TabIndex = 42
        Me.cmbCustomer.Visible = False
        '
        'lblCurrency
        '
        Me.lblCurrency.Location = New System.Drawing.Point(208, 96)
        Me.lblCurrency.Name = "lblCurrency"
        Me.lblCurrency.Size = New System.Drawing.Size(80, 23)
        Me.lblCurrency.TabIndex = 61
        Me.lblCurrency.Text = "Currency"
        '
        'cmbCurrency
        '
        Me.cmbCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCurrency.Location = New System.Drawing.Point(296, 96)
        Me.cmbCurrency.Name = "cmbCurrency"
        Me.cmbCurrency.Size = New System.Drawing.Size(104, 21)
        Me.cmbCurrency.TabIndex = 60
        '
        'cmbContactPerson
        '
        Me.cmbContactPerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbContactPerson.Location = New System.Drawing.Point(88, 72)
        Me.cmbContactPerson.Name = "cmbContactPerson"
        Me.cmbContactPerson.Size = New System.Drawing.Size(104, 21)
        Me.cmbContactPerson.TabIndex = 46
        '
        'DateDelivery
        '
        Me.DateDelivery.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateDelivery.Location = New System.Drawing.Point(296, 72)
        Me.DateDelivery.Name = "DateDelivery"
        Me.DateDelivery.Size = New System.Drawing.Size(96, 20)
        Me.DateDelivery.TabIndex = 59
        '
        'lblDeliveryDate
        '
        Me.lblDeliveryDate.Location = New System.Drawing.Point(208, 72)
        Me.lblDeliveryDate.Name = "lblDeliveryDate"
        Me.lblDeliveryDate.Size = New System.Drawing.Size(80, 23)
        Me.lblDeliveryDate.TabIndex = 58
        Me.lblDeliveryDate.Text = "Delivery Date"
        '
        'DatePosting
        '
        Me.DatePosting.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DatePosting.Location = New System.Drawing.Point(296, 48)
        Me.DatePosting.Name = "DatePosting"
        Me.DatePosting.Size = New System.Drawing.Size(96, 20)
        Me.DatePosting.TabIndex = 57
        '
        'lblPostingDate
        '
        Me.lblPostingDate.Location = New System.Drawing.Point(208, 48)
        Me.lblPostingDate.Name = "lblPostingDate"
        Me.lblPostingDate.Size = New System.Drawing.Size(80, 23)
        Me.lblPostingDate.TabIndex = 56
        Me.lblPostingDate.Text = "Posting Date"
        '
        'txtNo
        '
        Me.txtNo.Enabled = False
        Me.txtNo.Location = New System.Drawing.Point(296, 24)
        Me.txtNo.Name = "txtNo"
        Me.txtNo.TabIndex = 53
        Me.txtNo.Text = ""
        '
        'lblNo
        '
        Me.lblNo.Location = New System.Drawing.Point(208, 24)
        Me.lblNo.Name = "lblNo"
        Me.lblNo.Size = New System.Drawing.Size(24, 23)
        Me.lblNo.TabIndex = 52
        Me.lblNo.Text = "No."
        '
        'chkManual
        '
        Me.chkManual.Location = New System.Drawing.Point(232, 24)
        Me.chkManual.Name = "chkManual"
        Me.chkManual.Size = New System.Drawing.Size(64, 24)
        Me.chkManual.TabIndex = 51
        Me.chkManual.Text = "Manual"
        '
        'txtReference
        '
        Me.txtReference.Location = New System.Drawing.Point(88, 120)
        Me.txtReference.Name = "txtReference"
        Me.txtReference.TabIndex = 50
        Me.txtReference.Text = ""
        '
        'lblReference
        '
        Me.lblReference.Location = New System.Drawing.Point(8, 120)
        Me.lblReference.Name = "lblReference"
        Me.lblReference.Size = New System.Drawing.Size(88, 23)
        Me.lblReference.TabIndex = 49
        Me.lblReference.Text = "Reference"
        '
        'txtPhone
        '
        Me.txtPhone.Enabled = False
        Me.txtPhone.Location = New System.Drawing.Point(88, 96)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.TabIndex = 48
        Me.txtPhone.Text = ""
        '
        'lblPhone
        '
        Me.lblPhone.Location = New System.Drawing.Point(8, 96)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(88, 23)
        Me.lblPhone.TabIndex = 47
        Me.lblPhone.Text = "Phone"
        '
        'lblContactPerson
        '
        Me.lblContactPerson.Location = New System.Drawing.Point(8, 72)
        Me.lblContactPerson.Name = "lblContactPerson"
        Me.lblContactPerson.Size = New System.Drawing.Size(88, 23)
        Me.lblContactPerson.TabIndex = 45
        Me.lblContactPerson.Text = "Contact Person"
        '
        'lblName
        '
        Me.lblName.Location = New System.Drawing.Point(8, 48)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(48, 23)
        Me.lblName.TabIndex = 43
        Me.lblName.Text = "Name"
        '
        'lblCustomer
        '
        Me.lblCustomer.Location = New System.Drawing.Point(8, 24)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(56, 23)
        Me.lblCustomer.TabIndex = 41
        Me.lblCustomer.Text = "Customer"
        '
        'txtDBPass
        '
        Me.txtDBPass.Location = New System.Drawing.Point(328, 48)
        Me.txtDBPass.Name = "txtDBPass"
        Me.txtDBPass.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtDBPass.Size = New System.Drawing.Size(72, 20)
        Me.txtDBPass.TabIndex = 29
        Me.txtDBPass.Text = ""
        '
        'txtDBUser
        '
        Me.txtDBUser.Location = New System.Drawing.Point(328, 24)
        Me.txtDBUser.Name = "txtDBUser"
        Me.txtDBUser.Size = New System.Drawing.Size(72, 20)
        Me.txtDBUser.TabIndex = 27
        Me.txtDBUser.Text = "sa"
        '
        'lblPass
        '
        Me.lblPass.Location = New System.Drawing.Point(248, 48)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(80, 16)
        Me.lblPass.TabIndex = 30
        Me.lblPass.Text = "DB Password"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(248, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "DB Username"
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(576, 581)
        Me.Controls.Add(Me.grpOrder)
        Me.Controls.Add(Me.grpConn)
        Me.ForeColor = System.Drawing.Color.Blue
        Me.MinimumSize = New System.Drawing.Size(570, 470)
        Me.Name = "frmMain"
        Me.Text = "SAP Database Interface Sample"
        Me.grpConn.ResumeLayout(False)
        Me.grpOrder.ResumeLayout(False)
        Me.tabOrder.ResumeLayout(False)
        Me.pageContents.ResumeLayout(False)
        CType(Me.DataLines, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pageLogistics.ResumeLayout(False)
        Me.pageAccounting.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    'Error handling variables
    Public sErrMsg As String
    Public lErrCode As Integer
    Public lRetCode As Integer

    '****************************************************************************
    ' This function is called when the form is loaded.
    ' It performs various initialization procedures.
    '****************************************************************************
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbDBType.SelectedIndex = 3
    End Sub

    '****************************************************************************
    ' This function creates the data grid
    '****************************************************************************
    Private Sub CreateLinesTable()
        ' Create one DataTable with one column.

        TableLines = New DataTable("LinesTable")

        Dim col1Item As DataColumn = New DataColumn("Item No", Type.GetType("System.String"))
        col1Item.ReadOnly = True
        Dim col2Item As DataColumn = New DataColumn("Item Description", Type.GetType("System.String"))
        col2Item.ReadOnly = True
        Dim col3Item As DataColumn = New DataColumn("Quantity", Type.GetType("System.Double"))
        Dim col4Item As DataColumn = New DataColumn("Price", Type.GetType("System.Double"))
        col4Item.ReadOnly = True
        Dim col5Item As DataColumn = New DataColumn("Tax Code", Type.GetType("System.String"))
        col5Item.ReadOnly = True
        Dim col6Item As DataColumn = New DataColumn("Total (LC)", Type.GetType("System.Double"))

        TableLines.Columns.Add(col1Item)
        TableLines.Columns.Add(col2Item)
        TableLines.Columns.Add(col3Item)
        TableLines.Columns.Add(col4Item)
        TableLines.Columns.Add(col5Item)
        TableLines.Columns.Add(col6Item)

        TableLines.AcceptChanges()
        DataLines.DataSource = TableLines

    End Sub

    '****************************************************************************
    ' This function connects to the database
    '****************************************************************************
    Private Sub Connect()
        Cursor = System.Windows.Forms.Cursors.WaitCursor 'Change mouse cursor

        ' Set connection properties
        oCompany.CompanyDB = cmbCompany.Text
        oCompany.UserName = txtUSer.Text
        oCompany.Password = txtPassword.Text

        'Try to connect
        lRetCode = oCompany.Connect()

        If lRetCode <> 0 Then ' if the connection failed
            oCompany.GetLastError(lErrCode, sErrMsg)
            MsgBox("Connection Failed - " & sErrMsg, MsgBoxStyle.Exclamation, "Default Connection Failed")
        End If
        If oCompany.Connected Then ' if connected
            Me.Text = Me.Text & " - Connected to " & oCompany.CompanyDB
            grpConn.Enabled = False
            grpOrder.Enabled = True
            LoadGui() ' Load data for UI elements like combo boxes
        End If

        Cursor = System.Windows.Forms.Cursors.Default 'Change mouse cursor
    End Sub

    '****************************************************************************
    ' This function is called when the "Connect" button is called
    '****************************************************************************
    Private Sub cmdConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConnect.Click
        Connect()
    End Sub

    '****************************************************************************
    ' This function adds an order to the database
    '****************************************************************************
    Private Sub AddOrderToDatabase()

        ' Init the Order object
        oOrder = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oOrders)

        Dim oBob As SAPbobsCOM.SBObob

        ' set properties of the Order object
        oOrder.CardCode = cmbCustomer.Text
        oOrder.CardName = cmbName.Text
        If lstCntctCodes.Items.Count > 0 Then
            oOrder.ContactPersonCode = lstCntctCodes.Items(lstCntctCodes.SelectedIndex)
        End If
        oOrder.NumAtCard = txtReference.Text
        If chkManual.Checked Then
            oOrder.HandWritten = SAPbobsCOM.BoYesNoEnum.tYES
        Else
            oOrder.HandWritten = SAPbobsCOM.BoYesNoEnum.tNO
        End If
        oOrder.DocNum = txtNo.Text
        oOrder.DocDate = DatePosting.Value
        oOrder.DocDueDate = DateDelivery.Value
        oOrder.DocCurrency = cmbCurrency.Items(cmbCurrency.SelectedIndex)

        TableLines.AcceptChanges() ' Update the lines table

        ' Add lines to the Orer object from the table
        Dim i As Integer
        i = 0

        Do
            oOrder.Lines.ItemCode = TableLines.Rows(i).Item(0)
            oOrder.Lines.ItemDescription = TableLines.Rows(i).Item(1)
            oOrder.Lines.Quantity = TableLines.Rows(i).Item(2)
            oOrder.Lines.Price = TableLines.Rows(i).Item(3)
            oOrder.Lines.TaxCode = TableLines.Rows(i).Item(4)
            oOrder.Lines.LineTotal = TableLines.Rows(i).Item(5)
            i += 1
            If i <> TableLines.Rows.Count Then
                oOrder.Lines.Add()
            End If
        Loop Until i = TableLines.Rows.Count

        lRetCode = oOrder.Add ' Try to add the orer to the database
        If lRetCode <> 0 Then
            oCompany.GetLastError(lErrCode, sErrMsg)
            If (lErrCode <> -4006) Then ' Incase adding an order failed
                MsgBox(lErrCode & " " & sErrMsg)  ' Display error message
            Else ' If the currency Exchange is not set
                Dim dCur As Double
                Dim sCur
                sCur = InputBox("Currency Exchange - exchange rate has not been set for today. set the exchange rate", "Currency Exchange Setting")
                If IsNumeric(sCur) Then
                    dCur = CDbl(sCur)
                    oBob = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoBridge)
                    'Update Currency rate
                    oBob.SetCurrencyRate(cmbCurrency.Text, Today, dCur)
                Else
                    MsgBox("Invalid Value to Currency Exchange", MsgBoxStyle.Exclamation, "Invalid Value")
                End If
            End If
        Else
            cmdInvoice.Enabled = True ' Enable the "Make Invoice On Order" button
            MsgBox("Order Added to DataBase", MsgBoxStyle.Information, "Order Added")
        End If
    End Sub

    '****************************************************************************
    ' This function loads data for UI elements like combo boxes
    '****************************************************************************
    Private Sub LoadGui()
        Dim oObj As SAPbobsCOM.SBObob
        Dim rs As SAPbobsCOM.Recordset
        Dim strResult As String
        Dim errResult As String

        oObj = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoBridge)
        rs = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)

        ' Set the Customer Name and Customer Code Combo Boxes
        rs = oObj.GetBPList(SAPbobsCOM.BoCardTypes.cCustomer)
        rs.MoveFirst()
        While Not (rs.EoF)
            cmbCustomer.Items.Add(rs.Fields.Item(0).Value)
            cmbName.Items.Add(rs.Fields.Item(1).Value)
            rs.MoveNext()
        End While
        If cmbCustomer.Items.Count > 0 Then
            cmbCustomer.SelectedIndex = 0
            cmbName.SelectedIndex = 0
            LoadContactInfo()
        End If
        txtCcode.Text = cmbCustomer.Text
        txtCName.Text = cmbName.Text


        ' Create the next Order number
        Dim sSQL = "SELECT TOP 1 DocNum FROM dbo.ORDR ORDER BY DocNum DESC"
        rs = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        rs.DoQuery(sSQL)
        While Not (rs.EoF)
            txtNo.Text = rs.Fields.Item(0).Value + 1
            rs.MoveNext()
        End While

        'Load All items names and codes to combo boxes
        sSQL = "SELECT ItemCode, ItemName FROM OITM"

        rs = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        rs.DoQuery(sSQL)
        While Not (rs.EoF)
            cmbItemsCode.Items.Add(rs.Fields.Item(0).Value)
            cmbItemsDesc.Items.Add(rs.Fields.Item(1).Value)
            rs.MoveNext()
        End While
        cmbItemsCode.SelectedIndex = 0
        cmbItemsDesc.SelectedIndex = 0

        'Load Tax Codes to cmbTax combo box
        sSQL = "SELECT Code FROM OSTC"

        rs = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        rs.DoQuery(sSQL)
        While Not (rs.EoF)
            cmbTax.Items.Add(rs.Fields.Item(0).Value)
            rs.MoveNext()
        End While
        cmbTax.SelectedIndex = 0

        ' Currency Comobox
        sSQL = "SELECT CurrCode FROM OCRN"

        rs = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        rs.DoQuery(sSQL)
        While Not (rs.EoF)
            cmbCurrency.Items.Add(rs.Fields.Item(0).Value)
            rs.MoveNext()
        End While
        cmbCurrency.SelectedIndex = cmbCurrency.Items.Count - 1
    End Sub

    '****************************************************************************
    ' This function undates the contact info by the current customer
    '****************************************************************************
    Private Sub LoadContactInfo()
        Dim rs As SAPbobsCOM.Recordset
        rs = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)

        rs.DoQuery("SELECT CntctCode, Name, Tel1 FROM OCPR WHERE CardCode = '" & cmbCustomer.Text & "'")

        ' Clear old contact information
        lstCntctCodes.Items.Clear()
        cmbContactPerson.Items.Clear()
        lstPhones.Items.Clear()

        ' Load new contact information
        While Not (rs.EoF)
            lstCntctCodes.Items.Add(rs.Fields.Item(0).Value)
            cmbContactPerson.Items.Add(rs.Fields.Item(1).Value)
            lstPhones.Items.Add(rs.Fields.Item(2).Value)
            rs.MoveNext()
        End While

        ' Set the default contact
        If cmbContactPerson.Items.Count > 0 Then
            lstCntctCodes.SelectedIndex = 0
            lstPhones.SelectedIndex = 0
            txtPhone.Text = lstPhones.Items(0)
            cmbContactPerson.SelectedIndex = 0
        End If
    End Sub

    '****************************************************************************
    ' This function is called whenever the form is resized.
    ' It moves GUI elements accordingly
    '****************************************************************************
    Private Sub frmMain_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        tabOrder.Width = Me.Width - 40
        tabOrder.Height = Me.Height - tabOrder.Top - cmdAddOrder.Height - 160

        DataLines.Width = tabOrder.Width - 20
        DataLines.Height = tabOrder.Height - 80

        cmdAddOrder.Top = grpOrder.Height - cmdAddOrder.Height - 10
        cmdInvoice.Top = grpOrder.Height - cmdAddOrder.Height - 10

        grpOrder.Width = Me.Width - grpOrder.Left - 15
        grpOrder.Height = Me.Height - grpOrder.Top - 30

    End Sub

    '****************************************************************************
    ' This function adds an item in the GUI table
    ' It is not updated in the database yet
    '****************************************************************************
    Private Sub AddItemToOrder()
        Dim oSBObob As SAPbobsCOM.SBObob

        Dim NewRow As DataRow
        ' Get an initialized SBObob object
        oSBObob = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoBridge)

        NewRow = TableLines.NewRow()
        NewRow(0) = cmbItemsCode.Text
        NewRow(1) = cmbItemsDesc.Text
        NewRow(2) = "1"
        oRecordSet = oSBObob.GetItemPrice(cmbCustomer.Text, cmbItemsCode.Text, 1, DatePosting.Value)
        NewRow(3) = oRecordSet.Fields.Item(0).Value
        NewRow(4) = cmbTax.Text
        NewRow(5) = 1 * oRecordSet.Fields.Item(0).Value
        TableLines.Rows.Add(NewRow)
        cmdAddOrder.Enabled = True
    End Sub

    '****************************************************************************
    ' This procedure adds an invoice to the database
    '****************************************************************************
    Private Sub CreateInvoice()
        ' init the invoice object
        oInvoice = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oInvoices)
        oInvoice.CardCode = cmbCustomer.Text

        Dim sNewObjCode As String
        Dim i As Integer
        ' Get last added document number (the order that was added)
        oCompany.GetNewObjectCode(sNewObjCode)

        ' this loop adds the different items to the invoice object
        i = 0
        Do
            oInvoice.Lines.BaseEntry = sNewObjCode
            oInvoice.Lines.BaseLine = i
            oInvoice.Lines.BaseType = SAPbobsCOM.BoObjectTypes.oOrders
            oInvoice.Lines.TaxCode = TableLines.Rows(i).Item(4)
            i += 1
            If i <> TableLines.Rows.Count Then
                oInvoice.Lines.Add()
            End If
        Loop Until i = TableLines.Rows.Count

        ' Try to add the invoice object to the database
        lRetCode = oInvoice.Add()
        If lRetCode <> 0 Then ' If the addition failed
            oCompany.GetLastError(lErrCode, sErrMsg)
            MsgBox(lErrCode & " " & sErrMsg) ' Display error message
        Else
            cmdInvoice.Enabled = True
            MsgBox("inv Added to DataBase", MsgBoxStyle.Information, "Order Added")
        End If
    End Sub

    '****************************************************************************
    ' This procedure opens a form that shows the customer list
    '****************************************************************************
    Private Sub cmdChoose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdChoose.Click
        Dim f As SelectCustomer

        f = New SelectCustomer
        f.ShowDialog()
        txtCcode.Text = f.BPCode
        txtCName.Text = f.BPName
        cmbCustomer.SelectedIndex = f.iSelectedIndex
        cmbName.SelectedIndex = f.iSelectedIndex
        f = Nothing
    End Sub

    '****************************************************************************
    ' This function is called when the "Add Order" button is clicked
    '****************************************************************************
    Private Sub cmdAddOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddOrder.Click
        AddOrderToDatabase()
    End Sub

    '****************************************************************************
    ' Called AddItemToOrder
    '****************************************************************************
    Private Sub cmdAddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddItem.Click
        AddItemToOrder()
    End Sub

    '****************************************************************************
    ' This function displays the current contact person phone number
    '****************************************************************************
    Private Sub cmbContactPerson_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbContactPerson.SelectedIndexChanged
        lstPhones.SelectedIndex = cmbContactPerson.SelectedIndex
        lstCntctCodes.SelectedIndex = cmbContactPerson.SelectedIndex
        txtPhone.Text = lstPhones.Items(lstPhones.SelectedIndex)
    End Sub

    '****************************************************************************
    ' Keeps the item code and description syncronized
    '****************************************************************************
    Private Sub cmbItemsCode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbItemsCode.SelectedIndexChanged
        cmbItemsDesc.SelectedIndex = cmbItemsCode.SelectedIndex
    End Sub

    '****************************************************************************
    ' Keeps the item code and description syncronized
    '****************************************************************************
    Private Sub cmbItemsDesc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbItemsDesc.SelectedIndexChanged
        cmbItemsCode.SelectedIndex = cmbItemsDesc.SelectedIndex
    End Sub

    '****************************************************************************
    ' This function uses the cell-change event of the data drid 
    ' to calculate the total sum for the item
    '****************************************************************************
    Private Sub DataLines_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataLines.CurrentCellChanged
        On Error Resume Next

        If TableLines.Rows.Count > DataLines.CurrentRowIndex Then
            TableLines.Rows(DataLines.CurrentRowIndex).Item(5) = TableLines.Rows(DataLines.CurrentRowIndex).Item(3) * TableLines.Rows(DataLines.CurrentRowIndex).Item(2)
            TableLines.AcceptChanges()
        Else
            cmbItemsCode.Focus()
        End If
    End Sub

    '****************************************************************************
    ' This function is called when the "Manual" checkbox is changed
    '****************************************************************************
    Private Sub chkManual_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkManual.CheckedChanged
        txtNo.Enabled = Not (txtNo.Enabled)
    End Sub

    '****************************************************************************
    ' This function is called when the user chooses a different customer
    '****************************************************************************
    Private Sub cmbCustomer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCustomer.SelectedIndexChanged
        cmbName.SelectedIndex = cmbCustomer.SelectedIndex
        LoadContactInfo()
    End Sub

    '****************************************************************************
    ' This function is called when the user chooses a different customer
    '****************************************************************************
    Private Sub cmbName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbName.SelectedIndexChanged
        cmbCustomer.SelectedIndex = cmbName.SelectedIndex
        LoadContactInfo()
    End Sub

    '****************************************************************************
    ' This function is called when the user clicks the "Add Invoice" button
    '****************************************************************************
    Private Sub cmdInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInvoice.Click
        cmdInvoice.Enabled = False
        CreateInvoice() ' Adds invoice to database
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
        CreateLinesTable()

    End Sub
End Class

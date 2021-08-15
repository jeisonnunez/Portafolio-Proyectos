
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

Option Explicit On 

Public Class frmMain

    Inherits System.Windows.Forms.Form
    Public oCompany As SAPbobsCOM.Company ' The company object

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
    Friend WithEvents grpSample As System.Windows.Forms.GroupBox
    Friend WithEvents txtItemCode As System.Windows.Forms.TextBox
    Friend WithEvents lblItemCode As System.Windows.Forms.Label
    Friend WithEvents lblDueDate As System.Windows.Forms.Label
    Friend WithEvents lblQuantity As System.Windows.Forms.Label
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents lblCardCode As System.Windows.Forms.Label
    Friend WithEvents txtCardCode As System.Windows.Forms.TextBox
    Friend WithEvents lblExplenation As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblIns1 As System.Windows.Forms.Label
    Friend WithEvents lblPercent1 As System.Windows.Forms.Label
    Friend WithEvents lblInsDueDate1 As System.Windows.Forms.Label
    Friend WithEvents lblIns2 As System.Windows.Forms.Label
    Friend WithEvents lblPercent2 As System.Windows.Forms.Label
    Friend WithEvents txtPercent2 As System.Windows.Forms.TextBox
    Friend WithEvents lblInsDueDate2 As System.Windows.Forms.Label
    Friend WithEvents numPercent As System.Windows.Forms.NumericUpDown
    Friend WithEvents DateDue As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateInsDue1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateInsDue2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnInv As System.Windows.Forms.Button
    Friend WithEvents optApplyTaxFirst As System.Windows.Forms.RadioButton
    Friend WithEvents optApplyTaxDistrib As System.Windows.Forms.RadioButton
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.grpSample = New System.Windows.Forms.GroupBox
        Me.btnInv = New System.Windows.Forms.Button
        Me.DateInsDue2 = New System.Windows.Forms.DateTimePicker
        Me.DateInsDue1 = New System.Windows.Forms.DateTimePicker
        Me.DateDue = New System.Windows.Forms.DateTimePicker
        Me.numPercent = New System.Windows.Forms.NumericUpDown
        Me.lblIns2 = New System.Windows.Forms.Label
        Me.lblPercent2 = New System.Windows.Forms.Label
        Me.txtPercent2 = New System.Windows.Forms.TextBox
        Me.lblInsDueDate2 = New System.Windows.Forms.Label
        Me.optApplyTaxDistrib = New System.Windows.Forms.RadioButton
        Me.optApplyTaxFirst = New System.Windows.Forms.RadioButton
        Me.lblIns1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblPercent1 = New System.Windows.Forms.Label
        Me.lblInsDueDate1 = New System.Windows.Forms.Label
        Me.lblPrice = New System.Windows.Forms.Label
        Me.txtPrice = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblExplenation = New System.Windows.Forms.Label
        Me.lblCardCode = New System.Windows.Forms.Label
        Me.txtCardCode = New System.Windows.Forms.TextBox
        Me.lblQuantity = New System.Windows.Forms.Label
        Me.txtQuantity = New System.Windows.Forms.TextBox
        Me.lblDueDate = New System.Windows.Forms.Label
        Me.lblItemCode = New System.Windows.Forms.Label
        Me.txtItemCode = New System.Windows.Forms.TextBox
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
        Me.Label5 = New System.Windows.Forms.Label
        Me.grpSample.SuspendLayout()
        CType(Me.numPercent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpConn.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSample
        '
        Me.grpSample.Controls.Add(Me.btnInv)
        Me.grpSample.Controls.Add(Me.DateInsDue2)
        Me.grpSample.Controls.Add(Me.DateInsDue1)
        Me.grpSample.Controls.Add(Me.DateDue)
        Me.grpSample.Controls.Add(Me.numPercent)
        Me.grpSample.Controls.Add(Me.lblIns2)
        Me.grpSample.Controls.Add(Me.lblPercent2)
        Me.grpSample.Controls.Add(Me.txtPercent2)
        Me.grpSample.Controls.Add(Me.lblInsDueDate2)
        Me.grpSample.Controls.Add(Me.optApplyTaxDistrib)
        Me.grpSample.Controls.Add(Me.optApplyTaxFirst)
        Me.grpSample.Controls.Add(Me.lblIns1)
        Me.grpSample.Controls.Add(Me.Label4)
        Me.grpSample.Controls.Add(Me.lblPercent1)
        Me.grpSample.Controls.Add(Me.lblInsDueDate1)
        Me.grpSample.Controls.Add(Me.lblPrice)
        Me.grpSample.Controls.Add(Me.txtPrice)
        Me.grpSample.Controls.Add(Me.Label3)
        Me.grpSample.Controls.Add(Me.Label1)
        Me.grpSample.Controls.Add(Me.lblExplenation)
        Me.grpSample.Controls.Add(Me.lblCardCode)
        Me.grpSample.Controls.Add(Me.txtCardCode)
        Me.grpSample.Controls.Add(Me.lblQuantity)
        Me.grpSample.Controls.Add(Me.txtQuantity)
        Me.grpSample.Controls.Add(Me.lblDueDate)
        Me.grpSample.Controls.Add(Me.lblItemCode)
        Me.grpSample.Controls.Add(Me.txtItemCode)
        Me.grpSample.Enabled = False
        Me.grpSample.Location = New System.Drawing.Point(8, 144)
        Me.grpSample.Name = "grpSample"
        Me.grpSample.Size = New System.Drawing.Size(648, 400)
        Me.grpSample.TabIndex = 15
        Me.grpSample.TabStop = False
        Me.grpSample.Text = "Sample"
        '
        'btnInv
        '
        Me.btnInv.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.btnInv.Location = New System.Drawing.Point(24, 344)
        Me.btnInv.Name = "btnInv"
        Me.btnInv.Size = New System.Drawing.Size(336, 40)
        Me.btnInv.TabIndex = 36
        Me.btnInv.Text = "Create Invoice with 2 Installments"
        '
        'DateInsDue2
        '
        Me.DateInsDue2.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateInsDue2.Location = New System.Drawing.Point(480, 280)
        Me.DateInsDue2.Name = "DateInsDue2"
        Me.DateInsDue2.Size = New System.Drawing.Size(104, 20)
        Me.DateInsDue2.TabIndex = 35
        '
        'DateInsDue1
        '
        Me.DateInsDue1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateInsDue1.Location = New System.Drawing.Point(192, 280)
        Me.DateInsDue1.Name = "DateInsDue1"
        Me.DateInsDue1.Size = New System.Drawing.Size(104, 20)
        Me.DateInsDue1.TabIndex = 34
        '
        'DateDue
        '
        Me.DateDue.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateDue.Location = New System.Drawing.Point(160, 120)
        Me.DateDue.Name = "DateDue"
        Me.DateDue.Size = New System.Drawing.Size(104, 20)
        Me.DateDue.TabIndex = 33
        '
        'numPercent
        '
        Me.numPercent.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.numPercent.Location = New System.Drawing.Point(192, 304)
        Me.numPercent.Name = "numPercent"
        Me.numPercent.Size = New System.Drawing.Size(104, 29)
        Me.numPercent.TabIndex = 32
        Me.numPercent.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'lblIns2
        '
        Me.lblIns2.Location = New System.Drawing.Point(328, 256)
        Me.lblIns2.Name = "lblIns2"
        Me.lblIns2.Size = New System.Drawing.Size(120, 23)
        Me.lblIns2.TabIndex = 31
        Me.lblIns2.Text = "Invoice Installment #2"
        '
        'lblPercent2
        '
        Me.lblPercent2.Location = New System.Drawing.Point(376, 304)
        Me.lblPercent2.Name = "lblPercent2"
        Me.lblPercent2.Size = New System.Drawing.Size(104, 23)
        Me.lblPercent2.TabIndex = 30
        Me.lblPercent2.Text = "Percent"
        '
        'txtPercent2
        '
        Me.txtPercent2.Enabled = False
        Me.txtPercent2.Location = New System.Drawing.Point(480, 304)
        Me.txtPercent2.Name = "txtPercent2"
        Me.txtPercent2.TabIndex = 29
        Me.txtPercent2.Text = "50"
        '
        'lblInsDueDate2
        '
        Me.lblInsDueDate2.Location = New System.Drawing.Point(376, 280)
        Me.lblInsDueDate2.Name = "lblInsDueDate2"
        Me.lblInsDueDate2.Size = New System.Drawing.Size(104, 23)
        Me.lblInsDueDate2.TabIndex = 28
        Me.lblInsDueDate2.Text = "Due Date"
        '
        'optApplyTaxDistrib
        '
        Me.optApplyTaxDistrib.Checked = True
        Me.optApplyTaxDistrib.Location = New System.Drawing.Point(40, 200)
        Me.optApplyTaxDistrib.Name = "optApplyTaxDistrib"
        Me.optApplyTaxDistrib.Size = New System.Drawing.Size(168, 24)
        Me.optApplyTaxDistrib.TabIndex = 26
        Me.optApplyTaxDistrib.TabStop = True
        Me.optApplyTaxDistrib.Text = "Apply Tax Proportionally"
        '
        'optApplyTaxFirst
        '
        Me.optApplyTaxFirst.Location = New System.Drawing.Point(40, 224)
        Me.optApplyTaxFirst.Name = "optApplyTaxFirst"
        Me.optApplyTaxFirst.Size = New System.Drawing.Size(176, 24)
        Me.optApplyTaxFirst.TabIndex = 25
        Me.optApplyTaxFirst.Text = "Apply Tax On First Installment"
        '
        'lblIns1
        '
        Me.lblIns1.Location = New System.Drawing.Point(40, 256)
        Me.lblIns1.Name = "lblIns1"
        Me.lblIns1.Size = New System.Drawing.Size(120, 23)
        Me.lblIns1.TabIndex = 24
        Me.lblIns1.Text = "Invoice Installment #1"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(24, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(328, 23)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Invoice Installments Info. This sample uses only 2 Installments"
        '
        'lblPercent1
        '
        Me.lblPercent1.Location = New System.Drawing.Point(88, 304)
        Me.lblPercent1.Name = "lblPercent1"
        Me.lblPercent1.Size = New System.Drawing.Size(104, 23)
        Me.lblPercent1.TabIndex = 22
        Me.lblPercent1.Text = "Percent"
        '
        'lblInsDueDate1
        '
        Me.lblInsDueDate1.Location = New System.Drawing.Point(88, 280)
        Me.lblInsDueDate1.Name = "lblInsDueDate1"
        Me.lblInsDueDate1.Size = New System.Drawing.Size(104, 23)
        Me.lblInsDueDate1.TabIndex = 20
        Me.lblInsDueDate1.Text = "Due Date"
        '
        'lblPrice
        '
        Me.lblPrice.Location = New System.Drawing.Point(368, 144)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(104, 23)
        Me.lblPrice.TabIndex = 18
        Me.lblPrice.Text = "Price"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(472, 144)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.TabIndex = 17
        Me.txtPrice.Text = "50"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(336, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 23)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Invoice Line Info"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 23)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Invoice Header Info"
        '
        'lblExplenation
        '
        Me.lblExplenation.Location = New System.Drawing.Point(24, 24)
        Me.lblExplenation.Name = "lblExplenation"
        Me.lblExplenation.Size = New System.Drawing.Size(600, 40)
        Me.lblExplenation.TabIndex = 14
        Me.lblExplenation.Text = "This sample demonstrates how to use installments. It creates an invoice with a si" & _
        "ngle line, and lets you set the installments for it. Make sure you are running t" & _
        "his sample on the SBO_Demo database"
        '
        'lblCardCode
        '
        Me.lblCardCode.Location = New System.Drawing.Point(56, 96)
        Me.lblCardCode.Name = "lblCardCode"
        Me.lblCardCode.Size = New System.Drawing.Size(104, 23)
        Me.lblCardCode.TabIndex = 13
        Me.lblCardCode.Text = "Card Code"
        '
        'txtCardCode
        '
        Me.txtCardCode.Location = New System.Drawing.Point(160, 96)
        Me.txtCardCode.Name = "txtCardCode"
        Me.txtCardCode.TabIndex = 12
        Me.txtCardCode.Text = "C20000"
        '
        'lblQuantity
        '
        Me.lblQuantity.Location = New System.Drawing.Point(368, 120)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(104, 23)
        Me.lblQuantity.TabIndex = 11
        Me.lblQuantity.Text = "Quantity"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(472, 120)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.TabIndex = 10
        Me.txtQuantity.Text = "1"
        '
        'lblDueDate
        '
        Me.lblDueDate.Location = New System.Drawing.Point(56, 120)
        Me.lblDueDate.Name = "lblDueDate"
        Me.lblDueDate.Size = New System.Drawing.Size(104, 23)
        Me.lblDueDate.TabIndex = 9
        Me.lblDueDate.Text = "Due Date"
        '
        'lblItemCode
        '
        Me.lblItemCode.Location = New System.Drawing.Point(368, 96)
        Me.lblItemCode.Name = "lblItemCode"
        Me.lblItemCode.Size = New System.Drawing.Size(104, 23)
        Me.lblItemCode.TabIndex = 7
        Me.lblItemCode.Text = "Item Code"
        '
        'txtItemCode
        '
        Me.txtItemCode.Location = New System.Drawing.Point(472, 96)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.TabIndex = 0
        Me.txtItemCode.Text = "A00001"
        '
        'grpConn
        '
        Me.grpConn.Controls.Add(Me.txtDBPass)
        Me.grpConn.Controls.Add(Me.txtDBUser)
        Me.grpConn.Controls.Add(Me.lblPass)
        Me.grpConn.Controls.Add(Me.Label5)
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
        Me.grpConn.Size = New System.Drawing.Size(648, 128)
        Me.grpConn.TabIndex = 16
        Me.grpConn.TabStop = False
        Me.grpConn.Text = "Connection Properties"
        '
        'cmdGetCompanyList
        '
        Me.cmdGetCompanyList.Location = New System.Drawing.Point(448, 32)
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
        Me.cmdConnect.Location = New System.Drawing.Point(480, 88)
        Me.cmdConnect.Name = "cmdConnect"
        Me.cmdConnect.Size = New System.Drawing.Size(88, 24)
        Me.cmdConnect.TabIndex = 12
        Me.cmdConnect.Text = "Connect"
        '
        'txtPassword
        '
        Me.txtPassword.Enabled = False
        Me.txtPassword.Location = New System.Drawing.Point(360, 96)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(88, 20)
        Me.txtPassword.TabIndex = 11
        Me.txtPassword.Text = "manager"
        '
        'txtUSer
        '
        Me.txtUSer.Enabled = False
        Me.txtUSer.Location = New System.Drawing.Point(360, 72)
        Me.txtUSer.Name = "txtUSer"
        Me.txtUSer.Size = New System.Drawing.Size(88, 20)
        Me.txtUSer.TabIndex = 10
        Me.txtUSer.Text = "manager"
        '
        'lblPassword
        '
        Me.lblPassword.Location = New System.Drawing.Point(296, 96)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(64, 23)
        Me.lblPassword.TabIndex = 9
        Me.lblPassword.Text = "Password"
        '
        'lblUser
        '
        Me.lblUser.Location = New System.Drawing.Point(296, 72)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(64, 23)
        Me.lblUser.TabIndex = 8
        Me.lblUser.Text = "User Name"
        '
        'cmbCompany
        '
        Me.cmbCompany.Enabled = False
        Me.cmbCompany.Location = New System.Drawing.Point(120, 88)
        Me.cmbCompany.Name = "cmbCompany"
        Me.cmbCompany.Size = New System.Drawing.Size(121, 21)
        Me.cmbCompany.TabIndex = 7
        '
        'lblCompany
        '
        Me.lblCompany.Location = New System.Drawing.Point(8, 88)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(104, 23)
        Me.lblCompany.TabIndex = 6
        Me.lblCompany.Text = "Company Database"
        '
        'txtDBPass
        '
        Me.txtDBPass.Location = New System.Drawing.Point(352, 40)
        Me.txtDBPass.Name = "txtDBPass"
        Me.txtDBPass.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtDBPass.Size = New System.Drawing.Size(72, 20)
        Me.txtDBPass.TabIndex = 41
        Me.txtDBPass.Text = ""
        '
        'txtDBUser
        '
        Me.txtDBUser.Location = New System.Drawing.Point(352, 16)
        Me.txtDBUser.Name = "txtDBUser"
        Me.txtDBUser.Size = New System.Drawing.Size(72, 20)
        Me.txtDBUser.TabIndex = 39
        Me.txtDBUser.Text = "sa"
        '
        'lblPass
        '
        Me.lblPass.Location = New System.Drawing.Point(272, 40)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(80, 16)
        Me.lblPass.TabIndex = 42
        Me.lblPass.Text = "DB Password"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(272, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "DB Username"
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(682, 559)
        Me.Controls.Add(Me.grpConn)
        Me.Controls.Add(Me.grpSample)
        Me.ForeColor = System.Drawing.Color.Blue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MinimumSize = New System.Drawing.Size(570, 470)
        Me.Name = "frmMain"
        Me.Text = "SAP Database Interface Sample"
        Me.grpSample.ResumeLayout(False)
        CType(Me.numPercent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpConn.ResumeLayout(False)
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
            grpSample.Enabled = True
        End If

        Cursor = System.Windows.Forms.Cursors.Default 'Change mouse cursor
    End Sub

    '****************************************************************************
    ' This function is called when the "Connect" button is called
    '****************************************************************************
    Private Sub cmdConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConnect.Click
        Connect()
    End Sub

    Private Sub numPercent_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numPercent.ValueChanged
        txtPercent2.Text = (100 - numPercent.Value).ToString
    End Sub

    Private Sub btnInv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInv.Click
        Try
            Dim oInv As SAPbobsCOM.Documents
            Dim oIns As SAPbobsCOM.Document_Installments

            'Create Invoice Object
            oInv = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oInvoices)

            'Set Invoice Header Values
            oInv.CardCode = txtCardCode.Text
            oInv.DocDueDate = DateDue.Value

            If optApplyTaxFirst.Checked = True Then
                oInv.ApplyTaxOnFirstInstallment = SAPbobsCOM.BoYesNoEnum.tYES
            End If

            'Set Invoice Line Values
            oInv.Lines.ItemCode = txtItemCode.Text
            oInv.Lines.Quantity = Convert.ToDouble(txtQuantity.Text)
            oInv.Lines.Price = Convert.ToDouble(txtPrice.Text)

            'Set Installments
            oIns = oInv.Installments
            'Installment #1
            oIns.DueDate = DateInsDue1.Value
            oIns.Percentage = Convert.ToDouble(numPercent.Value)
            oIns.Add()

            'Installment #2
            oIns.DueDate = DateInsDue2.Value
            oIns.Percentage = Convert.ToDouble(txtPercent2.Text)

            lRetCode = oInv.Add ' Try to add the invoice to the database
            If lRetCode <> 0 Then
                oCompany.GetLastError(lErrCode, sErrMsg)
                MsgBox(lErrCode & " " & sErrMsg)  ' Display error message
            Else
                MsgBox("Invoice Added to DataBase", MsgBoxStyle.Information, "Invoice Added")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

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

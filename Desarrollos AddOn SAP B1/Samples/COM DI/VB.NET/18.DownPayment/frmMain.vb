
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
Option Strict Off

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
    Friend WithEvents DateDue As System.Windows.Forms.DateTimePicker
    Friend WithEvents numPercent As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblPercent As System.Windows.Forms.Label
    Friend WithEvents cmdCreateDownPaymentInv As System.Windows.Forms.Button
    Friend WithEvents cmdPayDownPayment As System.Windows.Forms.Button
    Friend WithEvents cmdInv As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents grpConn As System.Windows.Forms.GroupBox
    Friend WithEvents cmdGetCompanyList As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.grpSample = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmdInv = New System.Windows.Forms.Button
        Me.cmdPayDownPayment = New System.Windows.Forms.Button
        Me.numPercent = New System.Windows.Forms.NumericUpDown
        Me.lblPercent = New System.Windows.Forms.Label
        Me.cmdCreateDownPaymentInv = New System.Windows.Forms.Button
        Me.DateDue = New System.Windows.Forms.DateTimePicker
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
        Me.Label5 = New System.Windows.Forms.Label
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
        Me.Label6 = New System.Windows.Forms.Label
        Me.grpSample.SuspendLayout()
        CType(Me.numPercent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpConn.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSample
        '
        Me.grpSample.Controls.Add(Me.Label4)
        Me.grpSample.Controls.Add(Me.Label2)
        Me.grpSample.Controls.Add(Me.cmdInv)
        Me.grpSample.Controls.Add(Me.cmdPayDownPayment)
        Me.grpSample.Controls.Add(Me.numPercent)
        Me.grpSample.Controls.Add(Me.lblPercent)
        Me.grpSample.Controls.Add(Me.cmdCreateDownPaymentInv)
        Me.grpSample.Controls.Add(Me.DateDue)
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
        Me.grpSample.Size = New System.Drawing.Size(672, 472)
        Me.grpSample.TabIndex = 15
        Me.grpSample.TabStop = False
        Me.grpSample.Text = "Sample"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(24, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(552, 48)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Define BP Accounts:" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "In BP Accounting tab Define -> General tab Define:" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "1. Payme" & _
        "nt advances" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "2. Control Account -> Downpayment Recievable Account." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 296)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(552, 96)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "This Add-On demonstrates the process of using DownPayment Invoice via the DI." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "In" & _
        " order to make it clearer, it was devided to 3 parts:" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "   1. Creating a Down Pay" & _
        "ment Invoice." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "   2. Paying the Down Payment Invoice." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "   3. Creating an Invoice" & _
        " that uses the paid Down Payment." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "      The Invoice contains the same parameter" & _
        "s as the Down Payment (Card Code, Due Date... )." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "In each step the relavent " & _
        "button is enabled." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10)
        '
        'cmdInv
        '
        Me.cmdInv.Enabled = False
        Me.cmdInv.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.cmdInv.Location = New System.Drawing.Point(464, 400)
        Me.cmdInv.Name = "cmdInv"
        Me.cmdInv.Size = New System.Drawing.Size(192, 56)
        Me.cmdInv.TabIndex = 42
        Me.cmdInv.Text = "Create Invoice With Down Payment"
        '
        'cmdPayDownPayment
        '
        Me.cmdPayDownPayment.Enabled = False
        Me.cmdPayDownPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.cmdPayDownPayment.Location = New System.Drawing.Point(232, 400)
        Me.cmdPayDownPayment.Name = "cmdPayDownPayment"
        Me.cmdPayDownPayment.Size = New System.Drawing.Size(192, 56)
        Me.cmdPayDownPayment.TabIndex = 41
        Me.cmdPayDownPayment.Text = "Pay Down Payment Invoice"
        '
        'numPercent
        '
        Me.numPercent.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.numPercent.Location = New System.Drawing.Point(160, 256)
        Me.numPercent.Name = "numPercent"
        Me.numPercent.Size = New System.Drawing.Size(104, 29)
        Me.numPercent.TabIndex = 40
        Me.numPercent.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'lblPercent
        '
        Me.lblPercent.Location = New System.Drawing.Point(56, 256)
        Me.lblPercent.Name = "lblPercent"
        Me.lblPercent.Size = New System.Drawing.Size(104, 32)
        Me.lblPercent.TabIndex = 37
        Me.lblPercent.Text = "Down Payment Percent"
        '
        'cmdCreateDownPaymentInv
        '
        Me.cmdCreateDownPaymentInv.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.cmdCreateDownPaymentInv.Location = New System.Drawing.Point(16, 400)
        Me.cmdCreateDownPaymentInv.Name = "cmdCreateDownPaymentInv"
        Me.cmdCreateDownPaymentInv.Size = New System.Drawing.Size(176, 56)
        Me.cmdCreateDownPaymentInv.TabIndex = 36
        Me.cmdCreateDownPaymentInv.Text = "Create Down Payment Invoice"
        '
        'DateDue
        '
        Me.DateDue.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateDue.Location = New System.Drawing.Point(160, 232)
        Me.DateDue.Name = "DateDue"
        Me.DateDue.Size = New System.Drawing.Size(104, 20)
        Me.DateDue.TabIndex = 33
        '
        'lblPrice
        '
        Me.lblPrice.Location = New System.Drawing.Point(368, 256)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(104, 23)
        Me.lblPrice.TabIndex = 18
        Me.lblPrice.Text = "Price"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(472, 256)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.TabIndex = 17
        Me.txtPrice.Text = "50"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(336, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 23)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Invoice Line Info"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 184)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 23)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Invoice Header Info"
        '
        'lblExplenation
        '
        Me.lblExplenation.Location = New System.Drawing.Point(24, 24)
        Me.lblExplenation.Name = "lblExplenation"
        Me.lblExplenation.Size = New System.Drawing.Size(552, 96)
        Me.lblExplenation.TabIndex = 14
        Me.lblExplenation.Text = "Preconditions:" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "1. You must run the sample on the SBODemo_US database." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "2. Goto" & _
        " Administration->Setup->Financials->G/L Account Determination and fefine relevan" & _
        "t accounts:" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "     A. Payments Advances (General tab)" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "     B. Down Payment Recie" & _
        "vable (press the '...' button near Account Recievable in the General tab)" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "C. Do" & _
        "wn Payment Tax Offset Account (Tax tab)" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10)
        '
        'lblCardCode
        '
        Me.lblCardCode.Location = New System.Drawing.Point(56, 208)
        Me.lblCardCode.Name = "lblCardCode"
        Me.lblCardCode.Size = New System.Drawing.Size(104, 23)
        Me.lblCardCode.TabIndex = 13
        Me.lblCardCode.Text = "Card Code"
        '
        'txtCardCode
        '
        Me.txtCardCode.Location = New System.Drawing.Point(160, 208)
        Me.txtCardCode.Name = "txtCardCode"
        Me.txtCardCode.TabIndex = 12
        Me.txtCardCode.Text = "C20000"
        '
        'lblQuantity
        '
        Me.lblQuantity.Location = New System.Drawing.Point(368, 232)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(104, 23)
        Me.lblQuantity.TabIndex = 11
        Me.lblQuantity.Text = "Quantity"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(472, 232)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.TabIndex = 10
        Me.txtQuantity.Text = "1"
        '
        'lblDueDate
        '
        Me.lblDueDate.Location = New System.Drawing.Point(56, 232)
        Me.lblDueDate.Name = "lblDueDate"
        Me.lblDueDate.Size = New System.Drawing.Size(104, 23)
        Me.lblDueDate.TabIndex = 9
        Me.lblDueDate.Text = "Due Date"
        '
        'lblItemCode
        '
        Me.lblItemCode.Location = New System.Drawing.Point(368, 208)
        Me.lblItemCode.Name = "lblItemCode"
        Me.lblItemCode.Size = New System.Drawing.Size(104, 23)
        Me.lblItemCode.TabIndex = 7
        Me.lblItemCode.Text = "Item Code"
        '
        'txtItemCode
        '
        Me.txtItemCode.Location = New System.Drawing.Point(472, 208)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.TabIndex = 0
        Me.txtItemCode.Text = "A00001"
        '
        'grpConn
        '
        Me.grpConn.Controls.Add(Me.txtDBPass)
        Me.grpConn.Controls.Add(Me.txtDBUser)
        Me.grpConn.Controls.Add(Me.lblPass)
        Me.grpConn.Controls.Add(Me.Label6)
        Me.grpConn.Controls.Add(Me.cmdGetCompanyList)
        Me.grpConn.Controls.Add(Me.Label5)
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
        Me.grpConn.Size = New System.Drawing.Size(592, 128)
        Me.grpConn.TabIndex = 16
        Me.grpConn.TabStop = False
        Me.grpConn.Text = "Connection Properties"
        '
        'cmdGetCompanyList
        '
        Me.cmdGetCompanyList.Location = New System.Drawing.Point(464, 24)
        Me.cmdGetCompanyList.Name = "cmdGetCompanyList"
        Me.cmdGetCompanyList.Size = New System.Drawing.Size(112, 24)
        Me.cmdGetCompanyList.TabIndex = 15
        Me.cmdGetCompanyList.Text = "Get Company List"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 23)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Database Type"
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
        Me.txtPassword.Location = New System.Drawing.Point(336, 96)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(88, 20)
        Me.txtPassword.TabIndex = 11
        Me.txtPassword.Text = "manager"
        '
        'txtUSer
        '
        Me.txtUSer.Enabled = False
        Me.txtUSer.Location = New System.Drawing.Point(336, 72)
        Me.txtUSer.Name = "txtUSer"
        Me.txtUSer.Size = New System.Drawing.Size(88, 20)
        Me.txtUSer.TabIndex = 10
        Me.txtUSer.Text = "manager"
        '
        'lblPassword
        '
        Me.lblPassword.Location = New System.Drawing.Point(272, 96)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(64, 23)
        Me.lblPassword.TabIndex = 9
        Me.lblPassword.Text = "Password"
        '
        'lblUser
        '
        Me.lblUser.Location = New System.Drawing.Point(272, 72)
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
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(272, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "DB Username"
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(690, 623)
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

    Public oDPM As SAPbobsCOM.Documents

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
        'oCompany = New SAPbobsCOM.Company

        '' Init Connection Properties
        'oCompany.Server = "localhost" ' change to your company server
        'oCompany.language = SAPbobsCOM.BoSuppLangs.ln_English ' change to your language
        'oCompany.UseTrusted = True

        'Me.Show() ' shows the form while it's loaded...

        ''Create a list of companies...
        'oRecordSet = oCompany.GetCompanyList ' get the company list

        'oCompany.GetLastError(lErrCode, sErrMsg)

        'If lErrCode <> 0 Then
        '    MsgBox(sErrMsg)
        'Else
        '    Do Until oRecordSet.EoF = True
        '        cmbCompany.Items.Add(oRecordSet.Fields.Item(0).Value)
        '        oRecordSet.MoveNext()
        '    Loop
        'End If

        ''Select the first company as default
        'If cmbCompany.Items.Count > 0 Then
        '    cmbCompany.SelectedIndex = 0
        'Else
        '    MsgBox("There was no Database Found...", , "Database not found...")
        '    End ' Terminate Application...
        'End If

        'If oCompany.Connected Then ' if already connected
        '    Me.Text = Me.Text & ": Connected"
        '    ' Remove the following 2 remark lines if you want to try to connect automatically
        '    'Else
        '    'Connect()
        'End If

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

    '****************************************************************************
    ' This function creates a new Down Payment invoice
    '****************************************************************************
    Private Sub cmdCreateDownPaymentInv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCreateDownPaymentInv.Click
        Try

            'Create DownPayment Invoice Object
            oDPM = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oDownPayments)

            'Set Down Payment Header Values
            oDPM.CardCode = txtCardCode.Text
            oDPM.DocDueDate = DateDue.Value
            oDPM.DownPaymentPercentage = Convert.ToDouble(numPercent.Value)

            oDPM.DownPaymentType = SAPbobsCOM.DownPaymentTypeEnum.dptInvoice

            'Set Down Payment Line Values
            oDPM.Lines.ItemCode = txtItemCode.Text
            oDPM.Lines.Quantity = Convert.ToDouble(txtQuantity.Text)
            oDPM.Lines.Price = Convert.ToDouble(txtPrice.Text)

            lRetCode = oDPM.Add ' Try to add the invoice to the database
            If lRetCode <> 0 Then
                oCompany.GetLastError(lErrCode, sErrMsg)
                MsgBox(lErrCode & " " & sErrMsg)  ' Display error message
            Else
                MsgBox("Down Payment Invoice Added to DataBase", MsgBoxStyle.Information, "Invoice Added")
                ' Enabling the next button in the process
                cmdPayDownPayment.Enabled = True
                cmdCreateDownPaymentInv.Enabled = False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    '****************************************************************************
    ' This function creates a payment for the DownPayment invoice
    '****************************************************************************
    Private Sub cmdPayDownPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPayDownPayment.Click

        Dim InPay As SAPbobsCOM.Payments
        Dim sNewObjCode As String = ""

        oCompany.GetNewObjectCode(sNewObjCode)

        InPay = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oIncomingPayments)

        oDPM.GetByKey(Convert.ToInt32(sNewObjCode))

        InPay.CardCode = txtCardCode.Text
        InPay.DocDate = DateDue.Value
        InPay.CashAccount = "_SYS00000000002"
        InPay.CashSum = oDPM.DocTotal
        InPay.Invoices.DocEntry = Convert.ToInt32(sNewObjCode)
        InPay.Invoices.InvoiceType = SAPbobsCOM.BoRcptInvTypes.it_DownPayment

        lRetCode = InPay.Add()

        If lRetCode <> 0 Then
            oCompany.GetLastError(lErrCode, sErrMsg)
            MsgBox(lErrCode & " " & sErrMsg)  ' Display error message
        Else
            MsgBox("DownPayment Document# " & sNewObjCode & " Paid", MsgBoxStyle.Information, "Payment")
            cmdPayDownPayment.Enabled = False
            cmdInv.Enabled = True
        End If

    End Sub

    '****************************************************************************
    ' This function creates an Invoice that uses the DownPayment
    '****************************************************************************
    Private Sub cmdInv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInv.Click

        Dim oInvoice As SAPbobsCOM.Documents

        ' Add invoice
        oInvoice = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oInvoices)
        oInvoice.CardCode = txtCardCode.Text
        oInvoice.DocType = SAPbobsCOM.BoDocumentTypes.dDocument_Items
        oInvoice.DocDate = DateDue.Value
        oInvoice.Lines.ItemCode = txtItemCode.Text
        oInvoice.Lines.Price = Convert.ToDouble(txtPrice.Text)
        oInvoice.Lines.Quantity = Convert.ToDouble(txtQuantity.Text)
        oInvoice.Lines.TaxCode = "PA"
        oInvoice.Lines.VatGroup = "PA"

        ' Add the Invoice with Down Payment
        Dim dpToDraw As SAPbobsCOM.DownPaymentsToDraw

        dpToDraw = oInvoice.DownPaymentsToDraw
        'dpToDraw.DocEntry = Convert.ToString(oDPM.DocNum)
        dpToDraw.AmountToDraw = oDPM.DownPaymentAmount

        lRetCode = oInvoice.Add()

        If lRetCode <> 0 Then
            oCompany.GetLastError(lErrCode, sErrMsg)
            MsgBox(lErrCode & " " & sErrMsg)  ' Display error message
        Else
            MsgBox("Invoice with Downpayment created, the process of using a downpayment invoice succeeded", MsgBoxStyle.Information, "Invoice Paid")
            cmdInv.Enabled = False
        End If

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

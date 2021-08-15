'  SAP DI API 2006 SDK Sample
'****************************************************************************
'
'  File:      AccountServiceForm.vb
'
'  Copyright (c) SAP 
'
' THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
' ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
' THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
' PARTICULAR PURPOSE.
'
'****************************************************************************

'****************************************************************************
'
' Description:
' ------------
' Creates new balances for accounts
' 
'****************************************************************************

Imports SAPbobsCOM
Public Class AccountServiceForm
    Inherits System.Windows.Forms.Form

    Dim oAccountsService As SAPbobsCOM.AccountsService
    Dim lErrCode As Integer
    Dim sErrMsg As String

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
    Friend WithEvents cmdCreateBalance As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents txtOpenBalanceDetails As System.Windows.Forms.TextBox
    Friend WithEvents txtRef2 As System.Windows.Forms.TextBox
    Friend WithEvents txtRef1 As System.Windows.Forms.TextBox
    Friend WithEvents txtOpenBalenceDate As System.Windows.Forms.TextBox
    Friend WithEvents txtOpenBalanceAcc As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSecondAcctCredit As System.Windows.Forms.TextBox
    Friend WithEvents txtSecondAcctName As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstAcctCredit As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstAcctName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdCreateBalance = New System.Windows.Forms.Button
        Me.txtOpenBalanceDetails = New System.Windows.Forms.TextBox
        Me.txtRef2 = New System.Windows.Forms.TextBox
        Me.txtRef1 = New System.Windows.Forms.TextBox
        Me.txtOpenBalenceDate = New System.Windows.Forms.TextBox
        Me.txtOpenBalanceAcc = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbl1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtSecondAcctCredit = New System.Windows.Forms.TextBox
        Me.txtSecondAcctName = New System.Windows.Forms.TextBox
        Me.txtFirstAcctCredit = New System.Windows.Forms.TextBox
        Me.txtFirstAcctName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdCreateBalance
        '
        Me.cmdCreateBalance.Location = New System.Drawing.Point(256, 360)
        Me.cmdCreateBalance.Name = "cmdCreateBalance"
        Me.cmdCreateBalance.Size = New System.Drawing.Size(120, 24)
        Me.cmdCreateBalance.TabIndex = 0
        Me.cmdCreateBalance.Text = "Create Balance"
        '
        'txtOpenBalanceDetails
        '
        Me.txtOpenBalanceDetails.Location = New System.Drawing.Point(168, 144)
        Me.txtOpenBalanceDetails.Name = "txtOpenBalanceDetails"
        Me.txtOpenBalanceDetails.Size = New System.Drawing.Size(200, 20)
        Me.txtOpenBalanceDetails.TabIndex = 19
        Me.txtOpenBalanceDetails.Text = "G/L Accounts Opening Balance"
        '
        'txtRef2
        '
        Me.txtRef2.Location = New System.Drawing.Point(168, 112)
        Me.txtRef2.Name = "txtRef2"
        Me.txtRef2.Size = New System.Drawing.Size(200, 20)
        Me.txtRef2.TabIndex = 13
        Me.txtRef2.Text = "Ref 2"
        '
        'txtRef1
        '
        Me.txtRef1.Location = New System.Drawing.Point(168, 80)
        Me.txtRef1.Name = "txtRef1"
        Me.txtRef1.Size = New System.Drawing.Size(200, 20)
        Me.txtRef1.TabIndex = 12
        Me.txtRef1.Text = "Ref 1"
        '
        'txtOpenBalenceDate
        '
        Me.txtOpenBalenceDate.Location = New System.Drawing.Point(168, 48)
        Me.txtOpenBalenceDate.Name = "txtOpenBalenceDate"
        Me.txtOpenBalenceDate.Size = New System.Drawing.Size(200, 20)
        Me.txtOpenBalenceDate.TabIndex = 11
        Me.txtOpenBalenceDate.Text = ""
        '
        'txtOpenBalanceAcc
        '
        Me.txtOpenBalanceAcc.Location = New System.Drawing.Point(168, 16)
        Me.txtOpenBalanceAcc.Name = "txtOpenBalanceAcc"
        Me.txtOpenBalanceAcc.Size = New System.Drawing.Size(200, 20)
        Me.txtOpenBalanceAcc.TabIndex = 10
        Me.txtOpenBalanceAcc.Text = "Common Stock (HO, USA, GA )"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(24, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 16)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Details"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(24, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 16)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Ref2"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(24, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Ref1"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(24, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Date"
        '
        'lbl1
        '
        Me.lbl1.Location = New System.Drawing.Point(24, 16)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(144, 24)
        Me.lbl1.TabIndex = 14
        Me.lbl1.Text = "Openning Balance Account"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSecondAcctCredit)
        Me.GroupBox1.Controls.Add(Me.txtSecondAcctName)
        Me.GroupBox1.Controls.Add(Me.txtFirstAcctCredit)
        Me.GroupBox1.Controls.Add(Me.txtFirstAcctName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 184)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(368, 168)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Accounts For Credit"
        '
        'txtSecondAcctCredit
        '
        Me.txtSecondAcctCredit.Location = New System.Drawing.Point(128, 122)
        Me.txtSecondAcctCredit.Name = "txtSecondAcctCredit"
        Me.txtSecondAcctCredit.Size = New System.Drawing.Size(224, 20)
        Me.txtSecondAcctCredit.TabIndex = 36
        Me.txtSecondAcctCredit.Text = "300"
        '
        'txtSecondAcctName
        '
        Me.txtSecondAcctName.Location = New System.Drawing.Point(128, 90)
        Me.txtSecondAcctName.Name = "txtSecondAcctName"
        Me.txtSecondAcctName.Size = New System.Drawing.Size(224, 20)
        Me.txtSecondAcctName.TabIndex = 35
        Me.txtSecondAcctName.Text = "Sales Revenues - Foreign (HO, USA, GA )"
        '
        'txtFirstAcctCredit
        '
        Me.txtFirstAcctCredit.Location = New System.Drawing.Point(128, 58)
        Me.txtFirstAcctCredit.Name = "txtFirstAcctCredit"
        Me.txtFirstAcctCredit.Size = New System.Drawing.Size(224, 20)
        Me.txtFirstAcctCredit.TabIndex = 34
        Me.txtFirstAcctCredit.Text = "300"
        '
        'txtFirstAcctName
        '
        Me.txtFirstAcctName.Location = New System.Drawing.Point(128, 26)
        Me.txtFirstAcctName.Name = "txtFirstAcctName"
        Me.txtFirstAcctName.Size = New System.Drawing.Size(224, 20)
        Me.txtFirstAcctName.TabIndex = 33
        Me.txtFirstAcctName.Text = "Sales Revenues - Services (HO, USA, GA )"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 18)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Second Account Credit"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(12, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 18)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Second Account Name"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(12, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 18)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "First Account Credit"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(12, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 16)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "First Account Name"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AccountServiceForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(384, 397)
        Me.Controls.Add(Me.txtOpenBalanceDetails)
        Me.Controls.Add(Me.txtRef2)
        Me.Controls.Add(Me.txtRef1)
        Me.Controls.Add(Me.txtOpenBalenceDate)
        Me.Controls.Add(Me.txtOpenBalanceAcc)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.cmdCreateBalance)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "AccountServiceForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account Service - Create Open Balance"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

   

    Private Sub AccountServiceForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'set the current date
        txtOpenBalenceDate.Text = Date.Today

    End Sub

    ' the function gets an opening balance account and crediting the two account 
    ' with the credit amount  
    Private Sub cmdCreateBalance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCreateBalance.Click


        Dim oOpenningBalanceAccount As SAPbobsCOM.OpenningBalanceAccount
        Dim oGLAccounts As SAPbobsCOM.GLAccounts
        Dim oGLAccountFirst As SAPbobsCOM.GLAccount
        Dim oGLAccountSecond As SAPbobsCOM.GLAccount


        Try
            'get company service
            oCmpSrv = oCompany.GetCompanyService

            'get account service
            oAccountsService = oCmpSrv.GetBusinessService(ServiceTypes.AccountsService)

            'get Accounts Service Data Interface
            oOpenningBalanceAccount = oAccountsService.GetDataInterface(AccountsServiceDataInterfaces.asdiOpenningBalanceAccount)

            'set the account number for the opening balance account
            oOpenningBalanceAccount.OpenBalanceAccount = GetAccountCode(txtOpenBalanceAcc.Text)

            'set the details
            oOpenningBalanceAccount.Details = txtOpenBalanceDetails.Text

            'set the date
            oOpenningBalanceAccount.Date = txtOpenBalenceDate.Text

            'get ref to GlAccounts
            oGLAccounts = oAccountsService.GetDataInterface(AccountsServiceDataInterfaces.asdiGLAccounts)

            'add accounts that will be in credit or in debit
            'add first account
            oGLAccountFirst = oGLAccounts.Add
            'set the account code 
            oGLAccountFirst.Code = GetAccountCode(txtFirstAcctName.Text)
            'set credit amount
            oGLAccountFirst.Credit = txtFirstAcctCredit.Text

            'add second account
            oGLAccountSecond = oGLAccounts.Add
            'set the account code
            oGLAccountSecond.Code = GetAccountCode(txtSecondAcctName.Text)
            'set credit amount
            oGLAccountSecond.Credit = txtSecondAcctCredit.Text

            'create the balance for the first and second accounts from the Openning Balance Account
            oAccountsService.CreateOpenBalance(oOpenningBalanceAccount, oGLAccounts)

            Me.Close()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
        
    End Sub

    'getting the name of the account and retrieving the account code
    Private Function GetAccountCode(ByVal sAccountName As String) As String

        Dim oChartOfAccounts As SAPbobsCOM.ChartOfAccounts
        Dim bFreeBudget As Boolean
        Dim oRecordset As SAPbobsCOM.Recordset

        Try


            'get a record set
            oRecordset = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)

            'get ref tp chart of accounts
            oChartOfAccounts = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oChartOfAccounts)

            'get all accounts 
            oRecordset.DoQuery("SELECT * FROM OACT")

            'set the record set
            oChartOfAccounts.Browser.Recordset = oRecordset

            oChartOfAccounts.Browser.MoveFirst()

            'find account by name
            While (oChartOfAccounts.Browser.EoF = False)
                If oChartOfAccounts.Name = sAccountName Then
                    Exit While
                End If
                oChartOfAccounts.Browser.MoveNext()
            End While

            'return the User Code 
            Return oChartOfAccounts.Code


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function


End Class

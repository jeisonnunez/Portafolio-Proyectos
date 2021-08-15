'  SAP DI API 2006 SDK Sample
'****************************************************************************
'
'  File:      CompanyServiceForm.vb
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
' 1) Updates company properties
' 2) Create a new period
'****************************************************************************


Imports SAPbobsCOM

Public Class CompanyServiceForm
    Inherits System.Windows.Forms.Form

    Dim oCompanyService As SAPbobsCOM.CompanyService
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
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtColor As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdUpdate As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents groupbox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtBeginDate As System.Windows.Forms.TextBox
    Friend WithEvents txtPeriodType As System.Windows.Forms.TextBox
    Friend WithEvents txtPeriodName As System.Windows.Forms.TextBox
    Friend WithEvents txtPeriodCode As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents chkAutoCreateCard As System.Windows.Forms.CheckBox
    Friend WithEvents chkBlockStock As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtName = New System.Windows.Forms.TextBox
        Me.txtColor = New System.Windows.Forms.TextBox
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.txtPhone = New System.Windows.Forms.TextBox
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmdUpdate = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.groupbox1 = New System.Windows.Forms.GroupBox
        Me.txtBeginDate = New System.Windows.Forms.TextBox
        Me.txtPeriodType = New System.Windows.Forms.TextBox
        Me.txtPeriodName = New System.Windows.Forms.TextBox
        Me.txtPeriodCode = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.chkAutoCreateCard = New System.Windows.Forms.CheckBox
        Me.chkBlockStock = New System.Windows.Forms.CheckBox
        Me.groupbox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(152, 24)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(128, 20)
        Me.txtName.TabIndex = 0
        Me.txtName.Text = "My Company"
        '
        'txtColor
        '
        Me.txtColor.Location = New System.Drawing.Point(152, 56)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(128, 20)
        Me.txtColor.TabIndex = 1
        Me.txtColor.Text = "8"
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtAddress.Location = New System.Drawing.Point(152, 88)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(128, 20)
        Me.txtAddress.TabIndex = 2
        Me.txtAddress.Text = ""
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(152, 120)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(128, 20)
        Me.txtPhone.TabIndex = 3
        Me.txtPhone.Text = "(610) 999-9999"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(152, 152)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(128, 20)
        Me.txtEmail.TabIndex = 4
        Me.txtEmail.Text = "MyEMail@oec.com"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Company Name"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(24, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Company Color"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(24, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Company Address"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(24, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Phone Number 1"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(24, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Company EMail"
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Location = New System.Drawing.Point(320, 408)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(120, 24)
        Me.cmdUpdate.TabIndex = 10
        Me.cmdUpdate.Text = "Update"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(24, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 32)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Auto Create Customer Equipment Card"
        '
        'groupbox1
        '
        Me.groupbox1.Controls.Add(Me.Label17)
        Me.groupbox1.Controls.Add(Me.txtBeginDate)
        Me.groupbox1.Controls.Add(Me.txtPeriodType)
        Me.groupbox1.Controls.Add(Me.txtPeriodName)
        Me.groupbox1.Controls.Add(Me.txtPeriodCode)
        Me.groupbox1.Controls.Add(Me.Label11)
        Me.groupbox1.Controls.Add(Me.Label10)
        Me.groupbox1.Controls.Add(Me.Label9)
        Me.groupbox1.Controls.Add(Me.Label8)
        Me.groupbox1.Location = New System.Drawing.Point(24, 264)
        Me.groupbox1.Name = "groupbox1"
        Me.groupbox1.Size = New System.Drawing.Size(416, 136)
        Me.groupbox1.TabIndex = 15
        Me.groupbox1.TabStop = False
        Me.groupbox1.Text = "New Period"
        '
        'txtBeginDate
        '
        Me.txtBeginDate.Location = New System.Drawing.Point(136, 96)
        Me.txtBeginDate.Name = "txtBeginDate"
        Me.txtBeginDate.Size = New System.Drawing.Size(128, 20)
        Me.txtBeginDate.TabIndex = 13
        Me.txtBeginDate.Text = "2008-01-01"
        '
        'txtPeriodType
        '
        Me.txtPeriodType.Location = New System.Drawing.Point(136, 72)
        Me.txtPeriodType.Name = "txtPeriodType"
        Me.txtPeriodType.Size = New System.Drawing.Size(128, 20)
        Me.txtPeriodType.TabIndex = 12
        Me.txtPeriodType.Text = "0"
        '
        'txtPeriodName
        '
        Me.txtPeriodName.Location = New System.Drawing.Point(136, 48)
        Me.txtPeriodName.Name = "txtPeriodName"
        Me.txtPeriodName.Size = New System.Drawing.Size(128, 20)
        Me.txtPeriodName.TabIndex = 11
        Me.txtPeriodName.Text = "My Period Name"
        '
        'txtPeriodCode
        '
        Me.txtPeriodCode.Location = New System.Drawing.Point(136, 24)
        Me.txtPeriodCode.Name = "txtPeriodCode"
        Me.txtPeriodCode.Size = New System.Drawing.Size(128, 20)
        Me.txtPeriodCode.TabIndex = 10
        Me.txtPeriodCode.Text = "MyCode"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(16, 96)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 32)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Beginning of Financial Year"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(16, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 16)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Sub Period Type"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(16, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 16)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Period Name"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(16, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 16)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Period Category Code"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(24, 120)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(120, 16)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Phone Number 1"
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(24, 224)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(104, 24)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Block Stock Negative Quantity"
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(24, 152)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(120, 16)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "Company EMail"
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(24, 184)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(120, 32)
        Me.Label16.TabIndex = 11
        Me.Label16.Text = "Auto Create Customer Equipment Card"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(288, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "(e.g. Red=8)"
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(272, 80)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 16)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "(e.g. Year=0)"
        '
        'chkAutoCreateCard
        '
        Me.chkAutoCreateCard.Checked = True
        Me.chkAutoCreateCard.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAutoCreateCard.Location = New System.Drawing.Point(152, 192)
        Me.chkAutoCreateCard.Name = "chkAutoCreateCard"
        Me.chkAutoCreateCard.Size = New System.Drawing.Size(16, 24)
        Me.chkAutoCreateCard.TabIndex = 17
        '
        'chkBlockStock
        '
        Me.chkBlockStock.Checked = True
        Me.chkBlockStock.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBlockStock.Location = New System.Drawing.Point(152, 224)
        Me.chkBlockStock.Name = "chkBlockStock"
        Me.chkBlockStock.Size = New System.Drawing.Size(16, 24)
        Me.chkBlockStock.TabIndex = 18
        '
        'CompanyServiceForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(456, 445)
        Me.Controls.Add(Me.chkBlockStock)
        Me.Controls.Add(Me.chkAutoCreateCard)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.groupbox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtColor)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Name = "CompanyServiceForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Company Service"
        Me.groupbox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub CompanyServiceForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load




    End Sub


    'the function is using the company service to updates some of the company 
    'properties(name,color,phonenumber..) and to create new period 
    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click

        Dim oCompanyInfo As CompanyInfo
        Dim oCompanyAdminInfo As AdminInfo
        Dim sAddress As String
        Dim oPeriodCategory As PeriodCategory

        Try

            'get company service
            oCompanyService = oCompany.GetCompanyService

            '// get admin info
            oCompanyAdminInfo = oCompanyService.GetAdminInfo

            'set company name
            oCompanyAdminInfo.CompanyName = txtName.Text

            'set Company color 
            'Sets the number of the background color for active windows
            '(e.g Red=8,Orange=7)
            oCompanyAdminInfo.CompanyColor = CInt(txtColor.Text)

            'get the company address (read only)    
            txtAddress.Text = oCompanyAdminInfo.Address()

            'set phone number   
            oCompanyAdminInfo.PhoneNumber1 = txtPhone.Text

            'set email
            oCompanyAdminInfo.EMail = txtEmail.Text

            'update the admin info
            oCompanyService.UpdateAdminInfo(oCompanyAdminInfo)


            '// get company info
            oCompanyInfo = oCompanyService.GetCompanyInfo

            'Auto Create Customer Equipment Card (1=yes ,0=No)
            oCompanyInfo.AutoCreateCustomerEqCard = IIf(chkAutoCreateCard.Checked, 1, 0)

            'Block Stock Negative Quantity(1=yes ,0=No)
            oCompanyInfo.BlockStockNegativeQuantity = IIf(chkBlockStock.Checked, 1, 0)

            'update the company info
            oCompanyService.UpdateCompanyInfo(oCompanyInfo)

            'get period category
            oPeriodCategory = oCompanyService.GetDataInterface(CompanyServiceDataInterfaces.csdiPeriodCategory)

            'set period code
            oPeriodCategory.PeriodCategory = txtPeriodCode.Text

            'set period name
            oPeriodCategory.PeriodName = txtPeriodName.Text

            'set the period type can be year,quater,month or day
            '(e.g. spt_Year=0,spt_quater=1,spt_month=2,spt_days)
            oPeriodCategory.SubPeriodType =CInt(txtPeriodType.Text)

            'set the beginning of Financial Year
            oPeriodCategory.BeginningofFinancialYear = txtBeginDate.Text()

            'create period 
            oCompanyService.CreatePeriod(oPeriodCategory)

            Me.Close()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub


End Class

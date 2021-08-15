
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
'****************************************************************************

Option Explicit On 

Public Class frmPermission
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
    Friend WithEvents grpPermission As System.Windows.Forms.GroupBox
    Friend WithEvents lblFormType As System.Windows.Forms.Label
    Friend WithEvents grpSetPermission As System.Windows.Forms.GroupBox
    Friend WithEvents cmdUserPermission As System.Windows.Forms.Button
    Friend WithEvents lblExplenation As System.Windows.Forms.Label
    Friend WithEvents cmdNewPermission As System.Windows.Forms.Button
    Friend WithEvents txtPermissionName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPermissionID As System.Windows.Forms.TextBox
    Friend WithEvents lblPermissionID As System.Windows.Forms.Label
    Friend WithEvents txtFormType As System.Windows.Forms.TextBox
    Friend WithEvents txtNewFormType As System.Windows.Forms.TextBox
    Friend WithEvents lblStaticType As System.Windows.Forms.Label
    Friend WithEvents cmdNewForm As System.Windows.Forms.Button
    Public WithEvents lstUsers As System.Windows.Forms.CheckedListBox
    Friend WithEvents lblReadMe As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpConn As System.Windows.Forms.GroupBox
    Friend WithEvents cmdGetCompanyList As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
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
        Me.grpPermission = New System.Windows.Forms.GroupBox
        Me.txtPermissionID = New System.Windows.Forms.TextBox
        Me.lblPermissionID = New System.Windows.Forms.Label
        Me.txtPermissionName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmdNewPermission = New System.Windows.Forms.Button
        Me.txtFormType = New System.Windows.Forms.TextBox
        Me.lblFormType = New System.Windows.Forms.Label
        Me.grpSetPermission = New System.Windows.Forms.GroupBox
        Me.lblExplenation = New System.Windows.Forms.Label
        Me.lstUsers = New System.Windows.Forms.CheckedListBox
        Me.cmdUserPermission = New System.Windows.Forms.Button
        Me.txtNewFormType = New System.Windows.Forms.TextBox
        Me.lblStaticType = New System.Windows.Forms.Label
        Me.cmdNewForm = New System.Windows.Forms.Button
        Me.lblReadMe = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.grpConn = New System.Windows.Forms.GroupBox
        Me.cmdGetCompanyList = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
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
        Me.grpPermission.SuspendLayout()
        Me.grpSetPermission.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpConn.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpPermission
        '
        Me.grpPermission.Controls.Add(Me.txtPermissionID)
        Me.grpPermission.Controls.Add(Me.lblPermissionID)
        Me.grpPermission.Controls.Add(Me.txtPermissionName)
        Me.grpPermission.Controls.Add(Me.Label2)
        Me.grpPermission.Controls.Add(Me.cmdNewPermission)
        Me.grpPermission.Controls.Add(Me.txtFormType)
        Me.grpPermission.Controls.Add(Me.lblFormType)
        Me.grpPermission.Enabled = False
        Me.grpPermission.Location = New System.Drawing.Point(8, 264)
        Me.grpPermission.Name = "grpPermission"
        Me.grpPermission.Size = New System.Drawing.Size(224, 160)
        Me.grpPermission.TabIndex = 19
        Me.grpPermission.TabStop = False
        Me.grpPermission.Text = "- 1 - Create a New Permission"
        '
        'txtPermissionID
        '
        Me.txtPermissionID.Location = New System.Drawing.Point(96, 24)
        Me.txtPermissionID.Name = "txtPermissionID"
        Me.txtPermissionID.TabIndex = 5
        Me.txtPermissionID.Text = ""
        '
        'lblPermissionID
        '
        Me.lblPermissionID.Location = New System.Drawing.Point(16, 24)
        Me.lblPermissionID.Name = "lblPermissionID"
        Me.lblPermissionID.Size = New System.Drawing.Size(80, 16)
        Me.lblPermissionID.TabIndex = 24
        Me.lblPermissionID.Text = "Permission ID"
        '
        'txtPermissionName
        '
        Me.txtPermissionName.Location = New System.Drawing.Point(104, 56)
        Me.txtPermissionName.Name = "txtPermissionName"
        Me.txtPermissionName.TabIndex = 6
        Me.txtPermissionName.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Permission Name"
        '
        'cmdNewPermission
        '
        Me.cmdNewPermission.Location = New System.Drawing.Point(16, 120)
        Me.cmdNewPermission.Name = "cmdNewPermission"
        Me.cmdNewPermission.Size = New System.Drawing.Size(104, 23)
        Me.cmdNewPermission.TabIndex = 8
        Me.cmdNewPermission.Text = "Add Permission"
        '
        'txtFormType
        '
        Me.txtFormType.Location = New System.Drawing.Point(80, 88)
        Me.txtFormType.Name = "txtFormType"
        Me.txtFormType.TabIndex = 7
        Me.txtFormType.Text = ""
        '
        'lblFormType
        '
        Me.lblFormType.Location = New System.Drawing.Point(16, 88)
        Me.lblFormType.Name = "lblFormType"
        Me.lblFormType.Size = New System.Drawing.Size(64, 16)
        Me.lblFormType.TabIndex = 0
        Me.lblFormType.Text = "Form Type"
        '
        'grpSetPermission
        '
        Me.grpSetPermission.Controls.Add(Me.lblExplenation)
        Me.grpSetPermission.Controls.Add(Me.lstUsers)
        Me.grpSetPermission.Controls.Add(Me.cmdUserPermission)
        Me.grpSetPermission.Enabled = False
        Me.grpSetPermission.Location = New System.Drawing.Point(248, 264)
        Me.grpSetPermission.Name = "grpSetPermission"
        Me.grpSetPermission.Size = New System.Drawing.Size(288, 160)
        Me.grpSetPermission.TabIndex = 2
        Me.grpSetPermission.TabStop = False
        Me.grpSetPermission.Text = " - 2 - Set the new permission to users"
        '
        'lblExplenation
        '
        Me.lblExplenation.Location = New System.Drawing.Point(16, 24)
        Me.lblExplenation.Name = "lblExplenation"
        Me.lblExplenation.Size = New System.Drawing.Size(264, 24)
        Me.lblExplenation.TabIndex = 22
        Me.lblExplenation.Text = "Mark the users that will be able to use this form type"
        '
        'lstUsers
        '
        Me.lstUsers.Location = New System.Drawing.Point(16, 48)
        Me.lstUsers.Name = "lstUsers"
        Me.lstUsers.Size = New System.Drawing.Size(120, 94)
        Me.lstUsers.TabIndex = 10
        '
        'cmdUserPermission
        '
        Me.cmdUserPermission.Location = New System.Drawing.Point(160, 80)
        Me.cmdUserPermission.Name = "cmdUserPermission"
        Me.cmdUserPermission.Size = New System.Drawing.Size(104, 24)
        Me.cmdUserPermission.TabIndex = 11
        Me.cmdUserPermission.Text = "Set Permissions"
        '
        'txtNewFormType
        '
        Me.txtNewFormType.Location = New System.Drawing.Point(72, 72)
        Me.txtNewFormType.Name = "txtNewFormType"
        Me.txtNewFormType.TabIndex = 25
        Me.txtNewFormType.Text = ""
        '
        'lblStaticType
        '
        Me.lblStaticType.Location = New System.Drawing.Point(8, 72)
        Me.lblStaticType.Name = "lblStaticType"
        Me.lblStaticType.Size = New System.Drawing.Size(64, 16)
        Me.lblStaticType.TabIndex = 27
        Me.lblStaticType.Text = "Form Type"
        '
        'cmdNewForm
        '
        Me.cmdNewForm.Location = New System.Drawing.Point(184, 72)
        Me.cmdNewForm.Name = "cmdNewForm"
        Me.cmdNewForm.Size = New System.Drawing.Size(104, 24)
        Me.cmdNewForm.TabIndex = 26
        Me.cmdNewForm.Text = "Create Form"
        '
        'lblReadMe
        '
        Me.lblReadMe.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.lblReadMe.Location = New System.Drawing.Point(8, 176)
        Me.lblReadMe.Name = "lblReadMe"
        Me.lblReadMe.Size = New System.Drawing.Size(512, 80)
        Me.lblReadMe.TabIndex = 28
        Me.lblReadMe.Text = "This sample shows how to add new permissions and how to assign permissions to use" & _
        "rs. After you connect to your company add a new permission, then you'll be able " & _
        "to assign this permission to any of the company users. You can see the result by" & _
        " creating a form with the form type you added to the permission. Only permitted " & _
        "users will have access to this fom"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNewFormType)
        Me.GroupBox1.Controls.Add(Me.lblStaticType)
        Me.GroupBox1.Controls.Add(Me.cmdNewForm)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 432)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(528, 112)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "- 3 - Test the permission"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(496, 40)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "When clicking on ""Create Form"" we'll try to create a form in SBO with the form ty" & _
        "pe specified. If the user is not allowed to view the form an error will appear"
        '
        'grpConn
        '
        Me.grpConn.Controls.Add(Me.txtDBPass)
        Me.grpConn.Controls.Add(Me.txtDBUser)
        Me.grpConn.Controls.Add(Me.lblPass)
        Me.grpConn.Controls.Add(Me.Label4)
        Me.grpConn.Controls.Add(Me.cmdGetCompanyList)
        Me.grpConn.Controls.Add(Me.Label3)
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
        Me.grpConn.Size = New System.Drawing.Size(552, 128)
        Me.grpConn.TabIndex = 30
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
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 23)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Database Type"
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
        Me.cmdConnect.Location = New System.Drawing.Point(432, 88)
        Me.cmdConnect.Name = "cmdConnect"
        Me.cmdConnect.Size = New System.Drawing.Size(88, 24)
        Me.cmdConnect.TabIndex = 12
        Me.cmdConnect.Text = "Connect"
        '
        'txtPassword
        '
        Me.txtPassword.Enabled = False
        Me.txtPassword.Location = New System.Drawing.Point(312, 96)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(88, 20)
        Me.txtPassword.TabIndex = 11
        Me.txtPassword.Text = "manager"
        '
        'txtUSer
        '
        Me.txtUSer.Enabled = False
        Me.txtUSer.Location = New System.Drawing.Point(312, 72)
        Me.txtUSer.Name = "txtUSer"
        Me.txtUSer.Size = New System.Drawing.Size(88, 20)
        Me.txtUSer.TabIndex = 10
        Me.txtUSer.Text = "manager"
        '
        'lblPassword
        '
        Me.lblPassword.Location = New System.Drawing.Point(248, 96)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(64, 23)
        Me.lblPassword.TabIndex = 9
        Me.lblPassword.Text = "Password"
        '
        'lblUser
        '
        Me.lblUser.Location = New System.Drawing.Point(248, 72)
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
        Me.txtDBPass.Location = New System.Drawing.Point(328, 48)
        Me.txtDBPass.Name = "txtDBPass"
        Me.txtDBPass.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtDBPass.Size = New System.Drawing.Size(72, 20)
        Me.txtDBPass.TabIndex = 37
        Me.txtDBPass.Text = ""
        '
        'txtDBUser
        '
        Me.txtDBUser.Location = New System.Drawing.Point(328, 24)
        Me.txtDBUser.Name = "txtDBUser"
        Me.txtDBUser.Size = New System.Drawing.Size(72, 20)
        Me.txtDBUser.TabIndex = 35
        Me.txtDBUser.Text = "sa"
        '
        'lblPass
        '
        Me.lblPass.Location = New System.Drawing.Point(248, 48)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(80, 16)
        Me.lblPass.TabIndex = 38
        Me.lblPass.Text = "DB Password"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(248, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "DB Username"
        '
        'frmPermission
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(562, 557)
        Me.Controls.Add(Me.grpConn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblReadMe)
        Me.Controls.Add(Me.grpPermission)
        Me.Controls.Add(Me.grpSetPermission)
        Me.ForeColor = System.Drawing.Color.Blue
        Me.MinimumSize = New System.Drawing.Size(570, 470)
        Me.Name = "frmPermission"
        Me.Text = "SAP DI Permissions Sample"
        Me.grpPermission.ResumeLayout(False)
        Me.grpSetPermission.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.grpConn.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private WithEvents SBO_Application As SAPbouiCOM.Application

    'Error handling variables
    Public sErrMsg As String
    Public lErrCode As Integer
    Public lRetCode As Integer
    Private Sub SetApplication()

        '*******************************************************************
        '// Use an SboGuiApi object to establish connection
        '// with the SAP Business One application and return an
        '// initialized appliction object
        '*******************************************************************

        Dim SboGuiApi As SAPbouiCOM.SboGuiApi
        Dim sConnectionString As String

        SboGuiApi = New SAPbouiCOM.SboGuiApi

        sConnectionString = Environment.GetCommandLineArgs.GetValue(1)

        '// connect to a running SBO Application

        Try ' If there's no active application the connection will fail
            SboGuiApi.Connect(sConnectionString)
        Catch ' Connection failed
            System.Windows.Forms.MessageBox.Show("No SAP Business One Application was found")
            End
        End Try
        '// get an initialized application object

        SBO_Application = SboGuiApi.GetApplication()
        'SBO_Application.MessageBox("Hello World")

    End Sub
    '****************************************************************************
    ' This function is called when the form is loaded.
    ' It performs various initialization procedures.
    '****************************************************************************
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbDBType.SelectedIndex = 3
        SetApplication()

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
        Else
            LoadUsers()
            grpPermission.Enabled = True
        End If
        If oCompany.Connected Then ' if connected
            Me.Text = Me.Text & " - Connected to " & oCompany.CompanyDB
            grpConn.Enabled = False
            grpPermission.Enabled = True

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
    ' This function adds a new permission
    '****************************************************************************
    Private Sub AddToPermissionTree()
        Dim RetVal As Long
        Dim ErrCode As Long
        Dim ErrMsg As String
        Dim oPermission As SAPbobsCOM.UserPermissionTree

        oPermission = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUserPermissionTree)

        oPermission.Name = txtPermissionName.Text
        oPermission.PermissionID = txtPermissionID.Text
        oPermission.UserPermissionForms.FormType = txtFormType.Text

        oPermission.Options = SAPbobsCOM.BoUPTOptions.bou_FullReadNone
        RetVal = oPermission.Add()

        oCompany.GetLastError(RetVal, ErrMsg)
        If RetVal <> 0 Then
            MessageBox.Show(ErrMsg)
        Else
            grpPermission.Enabled = False
            grpSetPermission.Enabled = True
        End If
    End Sub

    '****************************************************************************
    ' This function loads all the users in the company to a list box
    '****************************************************************************
    Private Sub LoadUsers()
        Dim oUsers As SAPbobsCOM.Users
        Dim oRecordSet As SAPbobsCOM.Recordset

        oUsers = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUsers)
        oRecordSet = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)

        oRecordSet.DoQuery("SELECT * FROM OUSR")
        oUsers.Browser.Recordset = oRecordSet
        oUsers.Browser.Refresh()
        oUsers.Browser.MoveFirst()

        ' add to list box
        Dim i As Integer
        lstUsers.Items.Add(oUsers.UserCode, False)
        For i = 1 To oUsers.Browser.RecordCount() - 1
            oUsers.Browser.MoveNext()
            lstUsers.Items.Add(oUsers.UserCode, False)
        Next

        'While Not (oUsers.Browser.EoF)
        '    lstUsers.Items.Add(oUsers.UserCode, False)
        '    oUsers.Browser.MoveNext()
        'End While
        txtNewFormType.Text = txtFormType.Text
    End Sub

    '****************************************************************************
    ' This function responds to a click in the "Add Permission" button
    '****************************************************************************
    Private Sub cmdNewPermission_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNewPermission.Click
        AddToPermissionTree()
    End Sub

    '****************************************************************************
    ' This sub assigns the permission to users
    '****************************************************************************
    Private Sub cmdUserPermission_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUserPermission.Click

        Dim oUser As SAPbobsCOM.Users

        oUser = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUsers)

        Dim i As Integer
        For i = 0 To lstUsers.CheckedIndices.Count - 1
            Dim j = lstUsers.CheckedIndices.Item(i)
            lRetCode = oUser.GetByKey(j + 1)
            oCompany.GetLastError(lRetCode, sErrMsg)

            If lRetCode <> 0 Then
                MessageBox.Show(sErrMsg)
            End If

            oUser.UserPermission.Add()
            oUser.UserPermission.SetCurrentLine(0)
            oUser.UserPermission.PermissionID = txtPermissionID.Text
            oUser.UserPermission.Permission = SAPbobsCOM.BoPermission.boper_ReadOnly

            lRetCode = oUser.Update

            oCompany.GetLastError(lRetCode, sErrMsg)
            If lRetCode <> 0 Then
                MessageBox.Show(sErrMsg)
            End If
        Next i
    End Sub

    '****************************************************************************
    ' This sub creates a form with s specified type
    '****************************************************************************
    Private Sub CreateForm()
        Dim oForm As SAPbouiCOM.Form
        Dim cp As SAPbouiCOM.FormCreationParams

        cp = SBO_Application.CreateObject(SAPbouiCOM.BoCreatableObjectType.cot_FormCreationParams)
        cp.BorderStyle = SAPbouiCOM.BoFormBorderStyle.fbs_Fixed
        cp.FormType = txtNewFormType.Text
        cp.UniqueID = "MyID"

        Try
            oForm = SBO_Application.Forms.AddEx(cp)
            oForm.Visible = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    '****************************************************************************
    ' This function responds to a click in the "Create Form" button
    '****************************************************************************
    Private Sub cmdNewForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNewForm.Click
        CreateForm()
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

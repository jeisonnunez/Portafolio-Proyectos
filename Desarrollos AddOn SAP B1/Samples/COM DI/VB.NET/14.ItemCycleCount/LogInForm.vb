'  SAP DI API 2006 SDK Sample
'****************************************************************************
'
'  File:      LogInForm.vb
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
' Log In to Company
'
'****************************************************************************

Public Class LogInForm
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "
    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
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
    Friend WithEvents cmdLogInComp As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPort As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtLicenseServer As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
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
    Friend WithEvents cmbDBType As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdLogInComp = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtPort = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtLicenseServer = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
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
        Me.cmbDBType = New System.Windows.Forms.ComboBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdLogInComp
        '
        Me.cmdLogInComp.Location = New System.Drawing.Point(392, 232)
        Me.cmdLogInComp.Name = "cmdLogInComp"
        Me.cmdLogInComp.TabIndex = 70
        Me.cmdLogInComp.Text = "Log In"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbDBType)
        Me.GroupBox1.Controls.Add(Me.txtPort)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtLicenseServer)
        Me.GroupBox1.Controls.Add(Me.Label9)
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
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(456, 216)
        Me.GroupBox1.TabIndex = 69
        Me.GroupBox1.TabStop = False
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(344, 40)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.TabIndex = 65
        Me.txtPort.Text = "30000"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(256, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 16)
        Me.Label10.TabIndex = 64
        Me.Label10.Text = "Port"
        '
        'txtLicenseServer
        '
        Me.txtLicenseServer.Location = New System.Drawing.Point(344, 16)
        Me.txtLicenseServer.Name = "txtLicenseServer"
        Me.txtLicenseServer.TabIndex = 61
        Me.txtLicenseServer.Text = "ILTLVH111"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(256, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 16)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "License Server"
        '
        'txtCompanyPassword
        '
        Me.txtCompanyPassword.Location = New System.Drawing.Point(126, 168)
        Me.txtCompanyPassword.Name = "txtCompanyPassword"
        Me.txtCompanyPassword.TabIndex = 57
        Me.txtCompanyPassword.Text = "manager"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(16, 168)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 24)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Company Password"
        '
        'txtCompanyUserName
        '
        Me.txtCompanyUserName.Location = New System.Drawing.Point(126, 144)
        Me.txtCompanyUserName.Name = "txtCompanyUserName"
        Me.txtCompanyUserName.TabIndex = 55
        Me.txtCompanyUserName.Text = "manager"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(16, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 16)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Company UserName"
        '
        'txtDataBasePassword
        '
        Me.txtDataBasePassword.Location = New System.Drawing.Point(126, 120)
        Me.txtDataBasePassword.Name = "txtDataBasePassword"
        Me.txtDataBasePassword.TabIndex = 53
        Me.txtDataBasePassword.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(16, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 16)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "DataBase Password"
        '
        'txtDataBaseUserName
        '
        Me.txtDataBaseUserName.Location = New System.Drawing.Point(126, 96)
        Me.txtDataBaseUserName.Name = "txtDataBaseUserName"
        Me.txtDataBaseUserName.TabIndex = 51
        Me.txtDataBaseUserName.Text = "sa"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 96)
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
        'cmbDBType
        '
        Me.cmbDBType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDBType.Items.AddRange(New Object() {"MSSQL", "DB_2", "SYBASE", "MSSQL2005", "MAXDB"})
        Me.cmbDBType.Location = New System.Drawing.Point(128, 64)
        Me.cmbDBType.Name = "cmbDBType"
        Me.cmbDBType.Size = New System.Drawing.Size(121, 21)
        Me.cmbDBType.TabIndex = 66
        '
        'LogInForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(472, 263)
        Me.Controls.Add(Me.cmdLogInComp)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "LogInForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log In"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
#End Region

    Private Sub cmdLogInComp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogInComp.Click

        'Create a new company object
        Dim lRetCode As Integer
        Dim lErrCode As Integer
        Dim sErrMsg As String

        '// Set the mandatory properties for the connection to the database.
        '// To use a remote Db Server enter his name instead of the string "(local)"
        '// This string is used to work on a DB installed on your local machine
        Try
            oCompany.Server = txtDataBaseServer.Text

            oCompany.CompanyDB = txtDataBaseName.Text

            oCompany.DbServerType = cmbDBType.SelectedIndex + 1

            'db user name
            oCompany.DbUserName = txtDataBaseUserName.Text

            'user name
            oCompany.UserName = txtCompanyUserName.Text
            'user password
            oCompany.Password = txtCompanyPassword.Text

            oCompany.language = SAPbobsCOM.BoSuppLangs.ln_English

            'insert license server and port
            oCompany.LicenseServer = txtLicenseServer.Text & ":" & txtPort.Text

            'Change mouse cursor
            Cursor = System.Windows.Forms.Cursors.WaitCursor

            'Connecting to a company DB
            lRetCode = oCompany.Connect

            If lRetCode <> 0 Then
                oCompany.GetLastError(lErrCode, sErrMsg)
                MsgBox(sErrMsg)
                oCompany.Disconnect()
                Exit Sub
            End If

            'Change mouse cursor
            Cursor = System.Windows.Forms.Cursors.Default

            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LogInForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbDBType.SelectedIndex = 3
    End Sub
End Class

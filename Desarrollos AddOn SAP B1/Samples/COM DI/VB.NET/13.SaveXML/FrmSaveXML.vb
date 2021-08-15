'//  SAP MANAGE DI API 2007 SDK Sample
'//****************************************************************************
'//
'//  Copyright (c) SAP MANAGE
'//
'// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
'// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
'// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
'// PARTICULAR PURPOSE.
'//
'//****************************************************************************
'// BEFORE STARTING:
'// Add reference to the "SAP Business One Objects Bridge Version 2005"
'//-----------------------------------------------------------------
'// 1. Project->References
'// 2. check the "SAP Business One Objects Bridge Version 2005" check box
'//****************************************************************************

Option Strict Off
Option Explicit On 



Public Class frmSaveXML
    Inherits System.Windows.Forms.Form

    Private oCompany As SAPbobsCOM.Company
    Private sErrMsg As String
    Private lErrCode As Integer
    Private lRetCode As Integer

    Private RS As SAPbobsCOM.Recordset
    Private Bob As SAPbobsCOM.SBObob

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
    Friend WithEvents lstBO As System.Windows.Forms.ListBox
    Friend WithEvents txtKey As System.Windows.Forms.TextBox
    Friend WithEvents cmdPrev As System.Windows.Forms.Button
    Friend WithEvents WB As AxSHDocVw.AxWebBrowser
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents lblFile As System.Windows.Forms.Label
    Friend WithEvents txtFile As System.Windows.Forms.TextBox
    Friend WithEvents cmdNext As System.Windows.Forms.Button
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSaveXML))
        Me.lstBO = New System.Windows.Forms.ListBox
        Me.txtKey = New System.Windows.Forms.TextBox
        Me.cmdNext = New System.Windows.Forms.Button
        Me.cmdPrev = New System.Windows.Forms.Button
        Me.WB = New AxSHDocVw.AxWebBrowser
        Me.cmdSave = New System.Windows.Forms.Button
        Me.lblFile = New System.Windows.Forms.Label
        Me.txtFile = New System.Windows.Forms.TextBox
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
        CType(Me.WB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpConn.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstBO
        '
        Me.lstBO.Enabled = False
        Me.lstBO.Items.AddRange(New Object() {"Business Partners", "Items"})
        Me.lstBO.Location = New System.Drawing.Point(8, 160)
        Me.lstBO.Name = "lstBO"
        Me.lstBO.Size = New System.Drawing.Size(120, 95)
        Me.lstBO.TabIndex = 0
        '
        'txtKey
        '
        Me.txtKey.Enabled = False
        Me.txtKey.Location = New System.Drawing.Point(8, 264)
        Me.txtKey.Name = "txtKey"
        Me.txtKey.Size = New System.Drawing.Size(120, 20)
        Me.txtKey.TabIndex = 1
        Me.txtKey.Text = "Object Key"
        '
        'cmdNext
        '
        Me.cmdNext.Enabled = False
        Me.cmdNext.Location = New System.Drawing.Point(88, 296)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(40, 23)
        Me.cmdNext.TabIndex = 2
        Me.cmdNext.Text = "--->"
        '
        'cmdPrev
        '
        Me.cmdPrev.Enabled = False
        Me.cmdPrev.Location = New System.Drawing.Point(8, 296)
        Me.cmdPrev.Name = "cmdPrev"
        Me.cmdPrev.Size = New System.Drawing.Size(40, 23)
        Me.cmdPrev.TabIndex = 3
        Me.cmdPrev.Text = "<---"
        '
        'WB
        '
        Me.WB.Enabled = True
        Me.WB.Location = New System.Drawing.Point(144, 160)
        Me.WB.OcxState = CType(resources.GetObject("WB.OcxState"), System.Windows.Forms.AxHost.State)
        Me.WB.Size = New System.Drawing.Size(456, 248)
        Me.WB.TabIndex = 4
        '
        'cmdSave
        '
        Me.cmdSave.Enabled = False
        Me.cmdSave.Location = New System.Drawing.Point(8, 408)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.TabIndex = 5
        Me.cmdSave.Text = "Save"
        '
        'lblFile
        '
        Me.lblFile.Location = New System.Drawing.Point(8, 328)
        Me.lblFile.Name = "lblFile"
        Me.lblFile.Size = New System.Drawing.Size(80, 16)
        Me.lblFile.TabIndex = 6
        Me.lblFile.Text = "File Name"
        '
        'txtFile
        '
        Me.txtFile.Enabled = False
        Me.txtFile.Location = New System.Drawing.Point(8, 352)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(120, 20)
        Me.txtFile.TabIndex = 7
        Me.txtFile.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(96, 416)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(472, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "The file will be saved in the current directory, don't enter full path."
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
        Me.grpConn.Location = New System.Drawing.Point(8, 8)
        Me.grpConn.Name = "grpConn"
        Me.grpConn.Size = New System.Drawing.Size(592, 128)
        Me.grpConn.TabIndex = 9
        Me.grpConn.TabStop = False
        Me.grpConn.Text = "Connection Properties"
        '
        'cmdGetCompanyList
        '
        Me.cmdGetCompanyList.Location = New System.Drawing.Point(448, 24)
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
        Me.cmdConnect.Location = New System.Drawing.Point(448, 88)
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
        Me.txtPassword.Size = New System.Drawing.Size(88, 20)
        Me.txtPassword.TabIndex = 11
        Me.txtPassword.Text = "manager"
        '
        'txtUSer
        '
        Me.txtUSer.Enabled = False
        Me.txtUSer.Location = New System.Drawing.Point(344, 72)
        Me.txtUSer.Name = "txtUSer"
        Me.txtUSer.Size = New System.Drawing.Size(88, 20)
        Me.txtUSer.TabIndex = 10
        Me.txtUSer.Text = "manager"
        '
        'lblPassword
        '
        Me.lblPassword.Location = New System.Drawing.Point(280, 96)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(64, 23)
        Me.lblPassword.TabIndex = 9
        Me.lblPassword.Text = "Password"
        '
        'lblUser
        '
        Me.lblUser.Location = New System.Drawing.Point(280, 72)
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
        Me.txtDBPass.Location = New System.Drawing.Point(344, 40)
        Me.txtDBPass.Name = "txtDBPass"
        Me.txtDBPass.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtDBPass.Size = New System.Drawing.Size(72, 20)
        Me.txtDBPass.TabIndex = 41
        Me.txtDBPass.Text = ""
        '
        'txtDBUser
        '
        Me.txtDBUser.Location = New System.Drawing.Point(344, 16)
        Me.txtDBUser.Name = "txtDBUser"
        Me.txtDBUser.Size = New System.Drawing.Size(72, 20)
        Me.txtDBUser.TabIndex = 39
        Me.txtDBUser.Text = "sa"
        '
        'lblPass
        '
        Me.lblPass.Location = New System.Drawing.Point(264, 40)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(80, 16)
        Me.lblPass.TabIndex = 42
        Me.lblPass.Text = "DB Password"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(264, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "DB Username"
        '
        'frmSaveXML
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(640, 445)
        Me.Controls.Add(Me.grpConn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFile)
        Me.Controls.Add(Me.lblFile)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.WB)
        Me.Controls.Add(Me.cmdPrev)
        Me.Controls.Add(Me.cmdNext)
        Me.Controls.Add(Me.txtKey)
        Me.Controls.Add(Me.lstBO)
        Me.MinimumSize = New System.Drawing.Size(420, 290)
        Me.Name = "frmSaveXML"
        Me.Text = "Save Objects as XML"
        CType(Me.WB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpConn.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmSaveXML_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbDBType.SelectedIndex = 3
    End Sub

    '//****************************************************************************
    '// Connect to the company
    '//****************************************************************************
    Private Sub ConnectToCompany()

        '// Initialize the Company Object.
        '// Create a new company object

        '// Set the mandatory properties for the connection to the database.
        '// To use a remote Db Server enter his name instead of the string "(local)"
        '// This string is used to work on a DB installed on your local machine

        oCompany.CompanyDB = cmbCompany.Text
        oCompany.UserName = txtUSer.Text
        oCompany.Password = txtPassword.Text
        oCompany.language = SAPbobsCOM.BoSuppLangs.ln_English

        '// Use Windows authentication for database server.
        '// True for NT server authentication,
        '// False for database server authentication.
        oCompany.UseTrusted = True

        '// connect
        oCompany.Connect()

        '// Check for errors during connect
        oCompany.GetLastError(lErrCode, sErrMsg)
        If lErrCode <> 0 Then
            MsgBox(sErrMsg)
        Else
            cmbCompany.Enabled = False
            txtUSer.Enabled = False
            txtPassword.Enabled = False

            lstBO.Enabled = True
            txtKey.Enabled = True
            cmdNext.Enabled = True
            cmdPrev.Enabled = True
            txtFile.Enabled = True
            cmdSave.Enabled = True

        End If

    End Sub

    Private Sub lstBO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstBO.SelectedIndexChanged

        RS = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        cmdPrev.Enabled = True
        cmdNext.Enabled = True
        Select Case lstBO.SelectedIndex
            Case 0
                RS.DoQuery("SELECT CardCode from OCRD")
            Case 1
                RS.DoQuery("SELECT ItemCode from OITM")
        End Select
        RS.MoveFirst()
        txtKey.Text = RS.Fields.Item(0).Value
    End Sub

    Private Sub cmdNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNext.Click
        If Not (RS.EoF) Then
            RS.MoveNext()
        End If
        If Not (RS.EoF) Then
            txtKey.Text = RS.Fields.Item(0).Value
        End If
    End Sub

    Private Sub cmdPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrev.Click
        If Not (RS.BoF) Then
            RS.MovePrevious()
        End If
        txtKey.Text = RS.Fields.Item(0).Value
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim BP As SAPbobsCOM.BusinessPartners
        Dim ITM As SAPbobsCOM.Items

        ' Set the export type suitable for reloading
        oCompany.XmlExportType = SAPbobsCOM.BoXmlExportTypes.xet_ExportImportMode

        Select Case lstBO.SelectedIndex
            Case 0 ' Business Partners
                BP = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oBusinessPartners)
                BP.GetByKey(txtKey.Text)
                BP.SaveXML(txtFile.Text & ".xml")
            Case 1 ' Items
                ITM = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oItems)
                ITM.GetByKey(txtKey.Text)
                ITM.SaveXML(txtFile.Text & ".xml")
        End Select

        MessageBox.Show("File Saved")
        WB.Navigate2(CurDir() & "\" & txtFile.Text & ".xml")
    End Sub

    Private Sub frmSaveXML_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        WB.Width = Me.Width - 10 - WB.Left
        WB.Height = Me.Height - 30 - WB.Top
    End Sub

    Private Sub cmdConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConnect.Click

        ConnectToCompany()

        If oCompany.Connected = True Then
            System.Windows.Forms.MessageBox.Show("Connected to: " & oCompany.CompanyName)
        Else
            MsgBox("Not connected. Shutting down")
            End
        End If

    End Sub

    Private Sub cmdGetCompanyList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetCompanyList.Click
        Dim oRecordSet As SAPbobsCOM.Recordset
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

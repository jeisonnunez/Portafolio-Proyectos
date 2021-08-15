Option Strict Off
Option Explicit On
Friend Class DIExercise
	Inherits System.Windows.Forms.Form
#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
		If m_vb6FormDefInstance Is Nothing Then
			If m_InitializingDefInstance Then
				m_vb6FormDefInstance = Me
			Else
				Try 
					'For the start-up form, the first instance created is the default instance.
					If System.Reflection.Assembly.GetExecutingAssembly.EntryPoint.DeclaringType Is Me.GetType Then
						m_vb6FormDefInstance = Me
					End If
				Catch
				End Try
			End If
		End If
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents Text1 As System.Windows.Forms.TextBox
    Public WithEvents lblLoad As System.Windows.Forms.Label
    Public MainMenu1 As System.Windows.Forms.MainMenu
    'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
    Friend WithEvents lstIndex As System.Windows.Forms.ListBox
    Friend WithEvents chklstXML As System.Windows.Forms.CheckedListBox
    Friend WithEvents cmdExportFiles As System.Windows.Forms.Button
    Friend WithEvents DirListBox As Microsoft.VisualBasic.Compatibility.VB6.DirListBox
    Friend WithEvents DriveBox As Microsoft.VisualBasic.Compatibility.VB6.DriveListBox
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Text1 = New System.Windows.Forms.TextBox
        Me.lblLoad = New System.Windows.Forms.Label
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.lstIndex = New System.Windows.Forms.ListBox
        Me.chklstXML = New System.Windows.Forms.CheckedListBox
        Me.cmdExportFiles = New System.Windows.Forms.Button
        Me.DirListBox = New Microsoft.VisualBasic.Compatibility.VB6.DirListBox
        Me.DriveBox = New Microsoft.VisualBasic.Compatibility.VB6.DriveListBox
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.grpConn.SuspendLayout()
        Me.SuspendLayout()
        '
        'Text1
        '
        Me.Text1.AcceptsReturn = True
        Me.Text1.AutoSize = False
        Me.Text1.BackColor = System.Drawing.SystemColors.Window
        Me.Text1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text1.Enabled = False
        Me.Text1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text1.Location = New System.Drawing.Point(8, 376)
        Me.Text1.MaxLength = 0
        Me.Text1.Multiline = True
        Me.Text1.Name = "Text1"
        Me.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Text1.Size = New System.Drawing.Size(560, 256)
        Me.Text1.TabIndex = 14
        Me.Text1.Text = ""
        Me.Text1.WordWrap = False
        '
        'lblLoad
        '
        Me.lblLoad.BackColor = System.Drawing.SystemColors.Control
        Me.lblLoad.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLoad.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoad.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLoad.Location = New System.Drawing.Point(8, 352)
        Me.lblLoad.Name = "lblLoad"
        Me.lblLoad.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLoad.Size = New System.Drawing.Size(473, 17)
        Me.lblLoad.TabIndex = 17
        '
        'lstIndex
        '
        Me.lstIndex.Enabled = False
        Me.lstIndex.ItemHeight = 14
        Me.lstIndex.Location = New System.Drawing.Point(360, 176)
        Me.lstIndex.Name = "lstIndex"
        Me.lstIndex.Size = New System.Drawing.Size(120, 32)
        Me.lstIndex.TabIndex = 18
        Me.lstIndex.Visible = False
        '
        'chklstXML
        '
        Me.chklstXML.Enabled = False
        Me.chklstXML.Location = New System.Drawing.Point(8, 144)
        Me.chklstXML.Name = "chklstXML"
        Me.chklstXML.Size = New System.Drawing.Size(152, 199)
        Me.chklstXML.TabIndex = 19
        '
        'cmdExportFiles
        '
        Me.cmdExportFiles.Enabled = False
        Me.cmdExportFiles.Location = New System.Drawing.Point(168, 304)
        Me.cmdExportFiles.Name = "cmdExportFiles"
        Me.cmdExportFiles.Size = New System.Drawing.Size(152, 32)
        Me.cmdExportFiles.TabIndex = 20
        Me.cmdExportFiles.Text = "Export XML files"
        '
        'DirListBox
        '
        Me.DirListBox.Enabled = False
        Me.DirListBox.IntegralHeight = False
        Me.DirListBox.Location = New System.Drawing.Point(168, 176)
        Me.DirListBox.Name = "DirListBox"
        Me.DirListBox.Size = New System.Drawing.Size(152, 120)
        Me.DirListBox.TabIndex = 21
        '
        'DriveBox
        '
        Me.DriveBox.Enabled = False
        Me.DriveBox.Location = New System.Drawing.Point(168, 144)
        Me.DriveBox.Name = "DriveBox"
        Me.DriveBox.Size = New System.Drawing.Size(152, 21)
        Me.DriveBox.TabIndex = 22
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
        Me.grpConn.Size = New System.Drawing.Size(552, 128)
        Me.grpConn.TabIndex = 23
        Me.grpConn.TabStop = False
        Me.grpConn.Text = "Connection Properties"
        '
        'cmdGetCompanyList
        '
        Me.cmdGetCompanyList.Location = New System.Drawing.Point(432, 24)
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
        Me.cmbDBType.Size = New System.Drawing.Size(121, 22)
        Me.cmbDBType.TabIndex = 13
        '
        'cmdConnect
        '
        Me.cmdConnect.Enabled = False
        Me.cmdConnect.Location = New System.Drawing.Point(440, 80)
        Me.cmdConnect.Name = "cmdConnect"
        Me.cmdConnect.Size = New System.Drawing.Size(88, 24)
        Me.cmdConnect.TabIndex = 12
        Me.cmdConnect.Text = "Connect"
        '
        'txtPassword
        '
        Me.txtPassword.Enabled = False
        Me.txtPassword.Location = New System.Drawing.Point(320, 96)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(88, 20)
        Me.txtPassword.TabIndex = 11
        Me.txtPassword.Text = "manager"
        '
        'txtUSer
        '
        Me.txtUSer.Enabled = False
        Me.txtUSer.Location = New System.Drawing.Point(320, 72)
        Me.txtUSer.Name = "txtUSer"
        Me.txtUSer.Size = New System.Drawing.Size(88, 20)
        Me.txtUSer.TabIndex = 10
        Me.txtUSer.Text = "manager"
        '
        'lblPassword
        '
        Me.lblPassword.Location = New System.Drawing.Point(256, 96)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(64, 23)
        Me.lblPassword.TabIndex = 9
        Me.lblPassword.Text = "Password"
        '
        'lblUser
        '
        Me.lblUser.Location = New System.Drawing.Point(256, 72)
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
        Me.cmbCompany.Size = New System.Drawing.Size(121, 22)
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
        Me.txtDBPass.Location = New System.Drawing.Point(336, 40)
        Me.txtDBPass.Name = "txtDBPass"
        Me.txtDBPass.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtDBPass.Size = New System.Drawing.Size(72, 20)
        Me.txtDBPass.TabIndex = 33
        Me.txtDBPass.Text = ""
        '
        'txtDBUser
        '
        Me.txtDBUser.Location = New System.Drawing.Point(336, 16)
        Me.txtDBUser.Name = "txtDBUser"
        Me.txtDBUser.Size = New System.Drawing.Size(72, 20)
        Me.txtDBUser.TabIndex = 31
        Me.txtDBUser.Text = "sa"
        '
        'lblPass
        '
        Me.lblPass.Location = New System.Drawing.Point(256, 40)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(80, 16)
        Me.lblPass.TabIndex = 34
        Me.lblPass.Text = "DB Password"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(256, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "DB Username"
        '
        'DIExercise
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(570, 639)
        Me.Controls.Add(Me.grpConn)
        Me.Controls.Add(Me.DriveBox)
        Me.Controls.Add(Me.DirListBox)
        Me.Controls.Add(Me.cmdExportFiles)
        Me.Controls.Add(Me.chklstXML)
        Me.Controls.Add(Me.lstIndex)
        Me.Controls.Add(Me.Text1)
        Me.Controls.Add(Me.lblLoad)
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.MinimizeBox = False
        Me.Name = "DIExercise"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "XML SCHEMA EXPORTER"
        Me.grpConn.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
#End Region 
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As DIExercise
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As DIExercise
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New DIExercise()
				m_InitializingDefInstance = False
			End If
			DefInstance = m_vb6FormDefInstance
		End Get
		Set
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region 
    '//  SAP MANAGE DI API 6.7 SDK Sample
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

    '//****************************************************************************
    '// BEFORE STARTING:
    '// Add reference to the "SAP Business One Objects Bridge Version 6.7"
    '//-----------------------------------------------------------------
    '// 1. Project->References
    '// 2. check the "SAP Business One Objects Bridge Version 6.7" check box
    '//****************************************************************************

    Private oCompany As SAPbobsCOM.Company
    Private sErrMsg As String
    Private lErrCode As Integer
	Private lRetCode As Integer
	
	
    '//****************************************************************************
    '// This function creates a list of all the objects
    '//****************************************************************************
    Private Sub LoadEnumObjects()

        Dim i As Short
        Dim s As String

        Cursor = System.Windows.Forms.Cursors.WaitCursor
        For i = 1 To 500
            Cursor = System.Windows.Forms.Cursors.WaitCursor
            lblLoad.Text = "Loading XML Schemas... " & Str((i \ 5)) & "%"

            s = TryToGetSchema(i)
            If s <> "Error" Then
                Dim strEnum As String
                Dim SBO As SAPbobsCOM.BoObjectTypes
                SBO = i
                strEnum = SBO.ToString()
                chklstXML.Items.Add(strEnum)
                lstIndex.Items.Add(Str(i))
            End If
            System.Windows.Forms.Application.DoEvents()
        Next i
        Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    '//****************************************************************************
    '// Try to get an object schema
    '//****************************************************************************
    Function TryToGetSchema(ByRef i As Short) As String
        ' Get xml schema...
        Dim str_Renamed As String

        On Error GoTo ErrorHandler

        str_Renamed = oCompany.GetBusinessObjectXmlSchema(i)
        TryToGetSchema = str_Renamed

        Exit Function
ErrorHandler:
        TryToGetSchema = "Error"
    End Function

    '//****************************************************************************
    '// Loading procedure
    '//****************************************************************************
    Private Sub DIExercise_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        cmbDBType.SelectedIndex = 3

    End Sub

    '//****************************************************************************
    '// Connect to the company
    '//****************************************************************************
    Private Sub ConnectToCompany()

        '// Initialize the Company Object.
        '// Create a new company object
        'oCompany = New SAPbobsCOM.Company

        '// Set the mandatory properties for the connection to the database.
        '// To use a remote Db Server enter his name instead of the string "(local)"
        '// This string is used to work on a DB installed on your local machine

        'oCompany.Server = "(local)"
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
            'Disable Controls
            cmdGetCompanyList.Enabled = False
            cmbDBType.Enabled = False

            txtUSer.Enabled = False
            txtPassword.Enabled = False
            cmdConnect.Enabled = False
            cmbCompany.Enabled = False

            'Enable Controls

            chklstXML.Enabled = True
            DriveBox.Enabled = True
            DirListBox.Enabled = True
            cmdExportFiles.Enabled = True
            Text1.Enabled = True
            lstIndex.Enabled = True

        End If
    End Sub

    '//****************************************************************************
    '// Show the schema of the selected object
    '//****************************************************************************
    Private Sub chklstXML_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chklstXML.SelectedIndexChanged
        Dim s As String
        's = lstIndex.Items.Item(cmbOBjects.SelectedIndex)
        s = lstIndex.Items.Item(chklstXML.SelectedIndex)
        Text1.Text = TryToGetSchema(CShort(s))
    End Sub

    '//****************************************************************************
    '// Same the selected objects schemas in files
    '//****************************************************************************
    Private Sub cmdExportFiles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExportFiles.Click
        Dim i As Integer
        For i = 0 To chklstXML.CheckedIndices.Count - 1
            chklstXML.SelectedIndex = chklstXML.CheckedIndices.Item(i)
            SaveXMLSchema(chklstXML.SelectedItem & ".xml")
        Next i
        MsgBox("Files Exported...", MsgBoxStyle.Information)
    End Sub

    '//****************************************************************************
    '// Updating the path to save the files
    '//****************************************************************************
    Private Sub DriveBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DriveBox.SelectedIndexChanged
        DirListBox.Path = DriveBox.Drive
    End Sub

    '//****************************************************************************
    '// Saving a file
    '//****************************************************************************
    Private Sub SaveXMLSchema(ByVal s As String)
        Dim file As System.IO.File
        Dim Sw As System.IO.StreamWriter
        Dim Tw As System.IO.TextWriter

        Tw = file.CreateText(DirListBox.Path.ToString & "\" & s)
        Tw.WriteLine(Text1.Text)
        Tw.Close()
    End Sub

    Private Sub cmdGetCompanyList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetCompanyList.Click
        Dim oRecordSet As SAPbobsCOM.Recordset ' A recordset object

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

    Private Sub cmdConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConnect.Click
        ConnectToCompany()

        If oCompany.Connected = True Then
            MsgBox("Connected to: " & oCompany.CompanyName)
        Else
            MsgBox("Not connected. Shutting down")
            End
        End If
        Me.Show()
        LoadEnumObjects()

    End Sub
End Class
'//  SAP MANAGE DI API 2007 SDK Sample
'//****************************************************************************
'//
'//  File:      ChooseCompany.vb
'//
'//  Copyright (c) SAP MANAGE
'//
'// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
'// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
'// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
'// PARTICULAR PURPOSE.
'//
'//****************************************************************************

Option Strict Off
Option Explicit On
Friend Class ChooseCompany
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
    'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdGetCompanyList As System.Windows.Forms.Button
    Public WithEvents cmbDBType As System.Windows.Forms.ComboBox
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Combo1 As System.Windows.Forms.ComboBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents Text2 As System.Windows.Forms.TextBox
    Public WithEvents Text1 As System.Windows.Forms.TextBox
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Command1 As System.Windows.Forms.Button
    Public WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents txtDBPass As System.Windows.Forms.TextBox
    Public WithEvents txtDBUser As System.Windows.Forms.TextBox
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.cmdGetCompanyList = New System.Windows.Forms.Button
        Me.cmbDBType = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Combo1 = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame2 = New System.Windows.Forms.GroupBox
        Me.Text2 = New System.Windows.Forms.TextBox
        Me.Text1 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Command1 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtDBPass = New System.Windows.Forms.TextBox
        Me.txtDBUser = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Frame1.SuspendLayout()
        Me.Frame2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.GroupBox1)
        Me.Frame1.Controls.Add(Me.cmdGetCompanyList)
        Me.Frame1.Controls.Add(Me.cmbDBType)
        Me.Frame1.Controls.Add(Me.Label4)
        Me.Frame1.Controls.Add(Me.Combo1)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(0, 0)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(249, 208)
        Me.Frame1.TabIndex = 6
        Me.Frame1.TabStop = False
        '
        'cmdGetCompanyList
        '
        Me.cmdGetCompanyList.Location = New System.Drawing.Point(8, 136)
        Me.cmdGetCompanyList.Name = "cmdGetCompanyList"
        Me.cmdGetCompanyList.Size = New System.Drawing.Size(112, 23)
        Me.cmdGetCompanyList.TabIndex = 6
        Me.cmdGetCompanyList.Text = "Get Company List"
        '
        'cmbDBType
        '
        Me.cmbDBType.BackColor = System.Drawing.SystemColors.Window
        Me.cmbDBType.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbDBType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDBType.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDBType.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbDBType.Items.AddRange(New Object() {"MSSQL", "DB_2", "SYBASE", "MSSQL2005", "MAXDB"})
        Me.cmbDBType.Location = New System.Drawing.Point(104, 16)
        Me.cmbDBType.Name = "cmbDBType"
        Me.cmbDBType.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbDBType.Size = New System.Drawing.Size(137, 22)
        Me.cmbDBType.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(8, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(89, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "DB Type"
        '
        'Combo1
        '
        Me.Combo1.BackColor = System.Drawing.SystemColors.Window
        Me.Combo1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Combo1.Enabled = False
        Me.Combo1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Combo1.Location = New System.Drawing.Point(104, 176)
        Me.Combo1.Name = "Combo1"
        Me.Combo1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Combo1.Size = New System.Drawing.Size(137, 22)
        Me.Combo1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Enabled = False
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(8, 176)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(89, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Company DB:"
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.Text2)
        Me.Frame2.Controls.Add(Me.Text1)
        Me.Frame2.Controls.Add(Me.Label3)
        Me.Frame2.Controls.Add(Me.Label2)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(0, 216)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(249, 81)
        Me.Frame2.TabIndex = 7
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Application Login Info"
        '
        'Text2
        '
        Me.Text2.AcceptsReturn = True
        Me.Text2.AutoSize = False
        Me.Text2.BackColor = System.Drawing.SystemColors.Window
        Me.Text2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text2.Enabled = False
        Me.Text2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text2.Location = New System.Drawing.Point(104, 48)
        Me.Text2.MaxLength = 0
        Me.Text2.Name = "Text2"
        Me.Text2.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.Text2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text2.Size = New System.Drawing.Size(137, 19)
        Me.Text2.TabIndex = 8
        Me.Text2.Text = ""
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
        Me.Text1.Location = New System.Drawing.Point(104, 16)
        Me.Text1.MaxLength = 0
        Me.Text1.Name = "Text1"
        Me.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text1.Size = New System.Drawing.Size(137, 19)
        Me.Text1.TabIndex = 6
        Me.Text1.Text = ""
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(8, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(89, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Password:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Enabled = False
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(8, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "User Name:"
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.Enabled = False
        Me.Command1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(40, 304)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(145, 33)
        Me.Command1.TabIndex = 5
        Me.Command1.Text = "Connect"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.txtDBPass)
        Me.GroupBox1.Controls.Add(Me.txtDBUser)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(8, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox1.Size = New System.Drawing.Size(224, 81)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DB Login Info"
        '
        'txtDBPass
        '
        Me.txtDBPass.AcceptsReturn = True
        Me.txtDBPass.AutoSize = False
        Me.txtDBPass.BackColor = System.Drawing.SystemColors.Window
        Me.txtDBPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDBPass.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDBPass.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDBPass.Location = New System.Drawing.Point(104, 48)
        Me.txtDBPass.MaxLength = 0
        Me.txtDBPass.Name = "txtDBPass"
        Me.txtDBPass.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtDBPass.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDBPass.Size = New System.Drawing.Size(112, 19)
        Me.txtDBPass.TabIndex = 8
        Me.txtDBPass.Text = ""
        '
        'txtDBUser
        '
        Me.txtDBUser.AcceptsReturn = True
        Me.txtDBUser.AutoSize = False
        Me.txtDBUser.BackColor = System.Drawing.SystemColors.Window
        Me.txtDBUser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDBUser.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDBUser.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDBUser.Location = New System.Drawing.Point(104, 16)
        Me.txtDBUser.MaxLength = 0
        Me.txtDBUser.Name = "txtDBUser"
        Me.txtDBUser.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDBUser.Size = New System.Drawing.Size(112, 19)
        Me.txtDBUser.TabIndex = 6
        Me.txtDBUser.Text = ""
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(8, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(89, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Password:"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(8, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(73, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "User Name:"
        '
        'ChooseCompany
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(258, 343)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.Frame1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(184, 250)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ChooseCompany"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Choose Company DB"
        Me.Frame1.ResumeLayout(False)
        Me.Frame2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
#End Region 
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As ChooseCompany
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As ChooseCompany
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New ChooseCompany()
				m_InitializingDefInstance = False
			End If
			DefInstance = m_vb6FormDefInstance
		End Get
		Set
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region 

	

    '//****************************************************************************
    '// The Recordset is a non-business object.
    '// it is an auxiliary object for querying the DB
    '//****************************************************************************
    Private oRecordSet As SAPbobsCOM.Recordset

    Private Sub ChooseCompany_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        cmbDBType.SelectedIndex = 3

    End Sub

    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click

        '// setting the rest of the mandatory properties

        oCompany.CompanyDB = Combo1.Text
        oCompany.UserName = Text1.Text
        oCompany.Password = Text2.Text

        '// Connecting to a company DB
        lRetCode = oCompany.Connect

        If lRetCode <> 0 Then
            oCompany.GetLastError(lErrCode, sErrMsg)
            MsgBox(sErrMsg)
        Else
            MsgBox("Connected to " & oCompany.CompanyName)
            Me.Text = Me.Text & ": Connected"

            ' Disable controls
            Label1.Enabled = False
            Label2.Enabled = False
            Label3.Enabled = False
            Combo1.Enabled = False
            Text1.Enabled = False
            Text2.Enabled = False
            Command1.Enabled = False
            cmbDBType.Enabled = False
            cmdGetCompanyList.Enabled = False
        End If

    End Sub

    Private Sub cmdGetCompanyList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetCompanyList.Click
        Dim i As Integer ' to be used as an index

        oCompany.DbServerType = cmbDBType.SelectedIndex + 1
        oCompany.UseTrusted = False
        oCompany.DbUserName = txtDBUser.Text
        oCompany.DbPassword = txtDBPass.Text

        '// once the Server property of the Company is set
        '// we may query for a list of companies to choos from
        '// this method returns a Recordset object
        Try
            oRecordSet = oCompany.GetCompanyList

            '// Use GetLastError method directly after a function
            '// which doesn't have a return code
            '// you may also use the On Error GoTo.
            '// functions with no return codes throws exceptions

            oCompany.GetLastError(lErrCode, sErrMsg)

            If lErrCode <> 0 Then
                MsgBox(sErrMsg)
            Else
                If oCompany.Connected = False Then
                    '// Load the available company DB names to the combo box
                    '// the returned Recordset containds 4 fields:
                    '// dbName - represents the database name
                    '// cmpName - represents the company name
                    '// versStr - represents the version number of the company database
                    '// dbUser - represents the database owner
                    '// we are interested in the first filed (mandatory property)

                    '// Clear the company list
                    Combo1.Items.Clear()
                    '// Go through the Recordset and extract the dbname
                    Do Until oRecordSet.EoF = True
                        '// add the value of the first field of the Recordset
                        Combo1.Items.Add(oRecordSet.Fields.Item(0).Value)
                        '// move the record pointer to the next row
                        oRecordSet.MoveNext()
                    Loop

                    ' Enable controls
                    Label1.Enabled = True
                    Label2.Enabled = True
                    Label3.Enabled = True
                    Combo1.Enabled = True
                    Text1.Enabled = True
                    Text2.Enabled = True
                    Command1.Enabled = True
                End If

            End If

            If oCompany.Connected = True Then
                '// if the company object is allreay connected to a DB
                '// you must first Disconnect it before connecting it
                '// to a different DB
                '// bare in mind that by disconnecting the company object
                '// you lose all of the properties (Server, Language)
                Command1.Enabled = False
                Combo1.SelectedText = oCompany.CompanyDB
                Text1.Text = oCompany.UserName
                Text2.Text = oCompany.Password
                Me.Text = Me.Text & ": Connected"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            InitializeCompany()
        End Try
    End Sub
End Class
Option Strict Off
Option Explicit On
Friend Class UsingSBObob
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
	Public WithEvents Command12 As System.Windows.Forms.Button
	Public WithEvents Command11 As System.Windows.Forms.Button
	Public WithEvents Command10 As System.Windows.Forms.Button
	Public WithEvents Command9 As System.Windows.Forms.Button
	Public WithEvents Command8 As System.Windows.Forms.Button
	Public WithEvents Command7 As System.Windows.Forms.Button
	Public WithEvents Command6 As System.Windows.Forms.Button
	Public WithEvents Command5 As System.Windows.Forms.Button
	Public WithEvents Command4 As System.Windows.Forms.Button
	Public WithEvents Command3 As System.Windows.Forms.Button
	Public WithEvents Command2 As System.Windows.Forms.Button
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(UsingSBObob))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ToolTip1.Active = True
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.Command12 = New System.Windows.Forms.Button
		Me.Command11 = New System.Windows.Forms.Button
		Me.Command10 = New System.Windows.Forms.Button
		Me.Command9 = New System.Windows.Forms.Button
		Me.Command8 = New System.Windows.Forms.Button
		Me.Command7 = New System.Windows.Forms.Button
		Me.Command6 = New System.Windows.Forms.Button
		Me.Command5 = New System.Windows.Forms.Button
		Me.Command4 = New System.Windows.Forms.Button
		Me.Command3 = New System.Windows.Forms.Button
		Me.Command2 = New System.Windows.Forms.Button
		Me.Command1 = New System.Windows.Forms.Button
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Text = "Using SBObob"
		Me.ClientSize = New System.Drawing.Size(257, 498)
		Me.Location = New System.Drawing.Point(258, 210)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.ShowInTaskbar = False
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "UsingSBObob"
		Me.Frame1.Size = New System.Drawing.Size(257, 497)
		Me.Frame1.Location = New System.Drawing.Point(0, 0)
		Me.Frame1.TabIndex = 0
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Name = "Frame1"
		Me.Command12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command12.Text = "Get Object Key By Single Value"
		Me.Command12.Size = New System.Drawing.Size(225, 33)
		Me.Command12.Location = New System.Drawing.Point(16, 456)
		Me.Command12.TabIndex = 12
		Me.Command12.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command12.BackColor = System.Drawing.SystemColors.Control
		Me.Command12.CausesValidation = True
		Me.Command12.Enabled = True
		Me.Command12.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command12.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command12.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command12.TabStop = True
		Me.Command12.Name = "Command12"
		Me.Command11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command11.Text = "Formating bobs"
		Me.Command11.Size = New System.Drawing.Size(225, 33)
		Me.Command11.Location = New System.Drawing.Point(16, 416)
		Me.Command11.TabIndex = 11
		Me.Command11.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command11.BackColor = System.Drawing.SystemColors.Control
		Me.Command11.CausesValidation = True
		Me.Command11.Enabled = True
		Me.Command11.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command11.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command11.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command11.TabStop = True
		Me.Command11.Name = "Command11"
		Me.Command10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command10.Text = "Get Contact Emploees"
		Me.Command10.Size = New System.Drawing.Size(225, 33)
		Me.Command10.Location = New System.Drawing.Point(16, 376)
		Me.Command10.TabIndex = 10
		Me.Command10.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command10.BackColor = System.Drawing.SystemColors.Control
		Me.Command10.CausesValidation = True
		Me.Command10.Enabled = True
		Me.Command10.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command10.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command10.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command10.TabStop = True
		Me.Command10.Name = "Command10"
		Me.Command9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command9.Text = "Get Warehouse List"
		Me.Command9.Size = New System.Drawing.Size(225, 33)
		Me.Command9.Location = New System.Drawing.Point(16, 336)
		Me.Command9.TabIndex = 9
		Me.Command9.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command9.BackColor = System.Drawing.SystemColors.Control
		Me.Command9.CausesValidation = True
		Me.Command9.Enabled = True
		Me.Command9.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command9.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command9.TabStop = True
		Me.Command9.Name = "Command9"
		Me.Command8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command8.Text = "Get User List"
		Me.Command8.Size = New System.Drawing.Size(225, 33)
		Me.Command8.Location = New System.Drawing.Point(16, 296)
		Me.Command8.TabIndex = 8
		Me.Command8.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command8.BackColor = System.Drawing.SystemColors.Control
		Me.Command8.CausesValidation = True
		Me.Command8.Enabled = True
		Me.Command8.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command8.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command8.TabStop = True
		Me.Command8.Name = "Command8"
		Me.Command7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command7.Text = "Get Item List"
		Me.Command7.Size = New System.Drawing.Size(225, 33)
		Me.Command7.Location = New System.Drawing.Point(16, 256)
		Me.Command7.TabIndex = 7
		Me.Command7.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command7.BackColor = System.Drawing.SystemColors.Control
		Me.Command7.CausesValidation = True
		Me.Command7.Enabled = True
		Me.Command7.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command7.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command7.TabStop = True
		Me.Command7.Name = "Command7"
		Me.Command6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command6.Text = "Get Item Price"
		Me.Command6.Size = New System.Drawing.Size(225, 33)
		Me.Command6.Location = New System.Drawing.Point(16, 216)
		Me.Command6.TabIndex = 6
		Me.Command6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command6.BackColor = System.Drawing.SystemColors.Control
		Me.Command6.CausesValidation = True
		Me.Command6.Enabled = True
		Me.Command6.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command6.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command6.TabStop = True
		Me.Command6.Name = "Command6"
		Me.Command5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command5.Text = "Get Index Rate"
		Me.Command5.Size = New System.Drawing.Size(225, 33)
		Me.Command5.Location = New System.Drawing.Point(16, 176)
		Me.Command5.TabIndex = 5
		Me.Command5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command5.BackColor = System.Drawing.SystemColors.Control
		Me.Command5.CausesValidation = True
		Me.Command5.Enabled = True
		Me.Command5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command5.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command5.TabStop = True
		Me.Command5.Name = "Command5"
		Me.Command4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command4.Text = "Conversion bobs"
		Me.Command4.Size = New System.Drawing.Size(225, 33)
		Me.Command4.Location = New System.Drawing.Point(16, 136)
		Me.Command4.TabIndex = 4
		Me.Command4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command4.BackColor = System.Drawing.SystemColors.Control
		Me.Command4.CausesValidation = True
		Me.Command4.Enabled = True
		Me.Command4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command4.TabStop = True
		Me.Command4.Name = "Command4"
		Me.Command3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command3.Text = "Currency  bobs"
		Me.Command3.Size = New System.Drawing.Size(225, 33)
		Me.Command3.Location = New System.Drawing.Point(16, 96)
		Me.Command3.TabIndex = 3
		Me.Command3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command3.BackColor = System.Drawing.SystemColors.Control
		Me.Command3.CausesValidation = True
		Me.Command3.Enabled = True
		Me.Command3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command3.TabStop = True
		Me.Command3.Name = "Command3"
		Me.Command2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command2.Text = "Get Due Date"
		Me.Command2.Size = New System.Drawing.Size(225, 33)
		Me.Command2.Location = New System.Drawing.Point(16, 56)
		Me.Command2.TabIndex = 2
		Me.Command2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command2.BackColor = System.Drawing.SystemColors.Control
		Me.Command2.CausesValidation = True
		Me.Command2.Enabled = True
		Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command2.TabStop = True
		Me.Command2.Name = "Command2"
		Me.Command1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command1.Text = "Get Business Partners List"
		Me.Command1.Size = New System.Drawing.Size(225, 33)
		Me.Command1.Location = New System.Drawing.Point(16, 16)
		Me.Command1.TabIndex = 1
		Me.Command1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command1.BackColor = System.Drawing.SystemColors.Control
		Me.Command1.CausesValidation = True
		Me.Command1.Enabled = True
		Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command1.TabStop = True
		Me.Command1.Name = "Command1"
		Me.Controls.Add(Frame1)
		Me.Frame1.Controls.Add(Command12)
		Me.Frame1.Controls.Add(Command11)
		Me.Frame1.Controls.Add(Command10)
		Me.Frame1.Controls.Add(Command9)
		Me.Frame1.Controls.Add(Command8)
		Me.Frame1.Controls.Add(Command7)
		Me.Frame1.Controls.Add(Command6)
		Me.Frame1.Controls.Add(Command5)
		Me.Frame1.Controls.Add(Command4)
		Me.Frame1.Controls.Add(Command3)
		Me.Frame1.Controls.Add(Command2)
		Me.Frame1.Controls.Add(Command1)
	End Sub
#End Region 
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As UsingSBObob
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As UsingSBObob
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New UsingSBObob()
				m_InitializingDefInstance = False
			End If
			DefInstance = m_vb6FormDefInstance
		End Get
		Set
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region 
    '//  SAP MANAGE DI API 2007 SDK Sample
	'//****************************************************************************
	'//
	'//  File:      UsingSBObob.frm
	'//
	'//  Copyright (c) SAP MANAGE
	'//
	'// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
	'// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
	'// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
	'// PARTICULAR PURPOSE.
	'//
	'//****************************************************************************
	
	'//**************************************************************************************************
	'// BEFORE STARTING:
	'// Add reference to the "SAP Business One Objects Bridge Version 6.5"
	'//-----------------------------------------------------------------
	'// 1. Project->References
	'// 2. check the "SAP Business One Objects Bridge Version 6.5" check box
	'//**************************************************************************************************
	
	Private Sub UsingSBObob_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

		ConnectToCompany()
		
    End Sub



    Private Sub ConnectToCompany()

        '// Initialize the Company Object.
        '// Create a new company object
        oCompany = New SAPbobsCOM.Company

        '// Set the mandatory properties for the connection to the database.
        '// To use a remote Db Server enter his name instead of the string "(local)"
        '// This string is used to work on a DB installed on your local machine

        oCompany.Server = "(local)"
        oCompany.language = SAPbobsCOM.BoSuppLangs.ln_English

        '// Use Windows authentication for database server.
        '// True for NT server authentication,
        '// False for database server authentication.
        oCompany.UseTrusted = True

        ChooseCompany.DefInstance.ShowDialog()

    End Sub

    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
        BPList.DefInstance.ShowDialog()
    End Sub
    Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
        DueDate.DefInstance.ShowDialog()
    End Sub
    Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command3.Click
        Currencies.DefInstance.ShowDialog()
    End Sub
    Private Sub Command4_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command4.Click
        Conversions.DefInstance.ShowDialog()
    End Sub
    Private Sub Command5_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command5.Click
        IndexRate.DefInstance.ShowDialog()
    End Sub
    Private Sub Command6_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command6.Click
        ItemPrice.DefInstance.ShowDialog()
    End Sub
    Private Sub Command7_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command7.Click
        ItemList.DefInstance.ShowDialog()
    End Sub
    Private Sub Command8_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command8.Click
        UserList.DefInstance.ShowDialog()
    End Sub
    Private Sub Command9_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command9.Click
        WarehouseList.DefInstance.ShowDialog()
    End Sub
    Private Sub Command10_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command10.Click
        ContactEmployees.DefInstance.ShowDialog()
    End Sub
    Private Sub Command11_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command11.Click
        Formating.DefInstance.ShowDialog()
    End Sub
    Private Sub Command12_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command12.Click
        KeyByValue.DefInstance.ShowDialog()
    End Sub
End Class
Option Strict Off
Option Explicit On
Friend Class BPList
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
	Public WithEvents List1 As System.Windows.Forms.ListBox
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents Combo1 As System.Windows.Forms.ComboBox
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(BPList))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ToolTip1.Active = True
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me.List1 = New System.Windows.Forms.ListBox
		Me.Command1 = New System.Windows.Forms.Button
		Me.Combo1 = New System.Windows.Forms.ComboBox
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Text = "GetBPList bob"
		Me.ClientSize = New System.Drawing.Size(242, 284)
		Me.Location = New System.Drawing.Point(265, 213)
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
		Me.Name = "BPList"
		Me.Frame2.Size = New System.Drawing.Size(241, 281)
		Me.Frame2.Location = New System.Drawing.Point(0, 0)
		Me.Frame2.TabIndex = 2
		Me.Frame2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame2.BackColor = System.Drawing.SystemColors.Control
		Me.Frame2.Enabled = True
		Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Name = "Frame2"
		Me.List1.Size = New System.Drawing.Size(225, 176)
		Me.List1.Location = New System.Drawing.Point(8, 64)
		Me.List1.TabIndex = 5
		Me.List1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.List1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.List1.BackColor = System.Drawing.SystemColors.Window
		Me.List1.CausesValidation = True
		Me.List1.Enabled = True
		Me.List1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.List1.IntegralHeight = True
		Me.List1.Cursor = System.Windows.Forms.Cursors.Default
		Me.List1.SelectionMode = System.Windows.Forms.SelectionMode.One
		Me.List1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.List1.Sorted = False
		Me.List1.TabStop = True
		Me.List1.Visible = True
		Me.List1.MultiColumn = False
		Me.List1.Name = "List1"
		Me.Command1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command1.Text = "Execute"
		Me.Command1.Size = New System.Drawing.Size(97, 25)
		Me.Command1.Location = New System.Drawing.Point(72, 248)
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
		Me.Combo1.Size = New System.Drawing.Size(129, 21)
		Me.Combo1.Location = New System.Drawing.Point(104, 16)
		Me.Combo1.TabIndex = 0
		Me.Combo1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Combo1.BackColor = System.Drawing.SystemColors.Window
		Me.Combo1.CausesValidation = True
		Me.Combo1.Enabled = True
		Me.Combo1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Combo1.IntegralHeight = True
		Me.Combo1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Combo1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Combo1.Sorted = False
		Me.Combo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.Combo1.TabStop = True
		Me.Combo1.Visible = True
		Me.Combo1.Name = "Combo1"
		Me.Label5.Text = "First 10 Results:"
		Me.Label5.Size = New System.Drawing.Size(89, 17)
		Me.Label5.Location = New System.Drawing.Point(8, 40)
		Me.Label5.TabIndex = 4
		Me.Label5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label5.BackColor = System.Drawing.SystemColors.Control
		Me.Label5.Enabled = True
		Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label5.UseMnemonic = True
		Me.Label5.Visible = True
		Me.Label5.AutoSize = False
		Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label5.Name = "Label5"
		Me.Label1.Text = "Select BP Type:"
		Me.Label1.Size = New System.Drawing.Size(89, 17)
		Me.Label1.Location = New System.Drawing.Point(8, 16)
		Me.Label1.TabIndex = 3
		Me.Label1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label1.BackColor = System.Drawing.SystemColors.Control
		Me.Label1.Enabled = True
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = False
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me.Controls.Add(Frame2)
		Me.Frame2.Controls.Add(List1)
		Me.Frame2.Controls.Add(Command1)
		Me.Frame2.Controls.Add(Combo1)
		Me.Frame2.Controls.Add(Label5)
		Me.Frame2.Controls.Add(Label1)
	End Sub
#End Region 
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As BPList
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As BPList
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New BPList()
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
	'//  File:      BPList.frm
	'//
	'//  Copyright (c) SAP MANAGE
	'//
	'// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
	'// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
	'// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
	'// PARTICULAR PURPOSE.
	'//
	'//****************************************************************************
	
	
	Private Sub BPList_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		SetComboBox()
	End Sub
	
	
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		
		Dim oSBObob As SAPbobsCOM.SBObob
		Dim oRecordSet As SAPbobsCOM.Recordset
		Dim oBusinessPartner As SAPbobsCOM.BusinessPartners
		
		Dim i As Integer
		
		'// catch exceptions
		'// can be used instead of Company.GetLastError method
		On Error GoTo ErrorHandler
		
		
		'// Get an initialized SBObob object
		oSBObob = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoBridge)
		'// Get an initialized Recordset object
		oRecordSet = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
		'// Get an initialized BusinessPartners object
		oBusinessPartner = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oBusinessPartners)
		
		'// Execute the SBObob GetBPList method
		oRecordSet = oSBObob.GetBPList(Combo1.SelectedIndex)
		'// the RecorSet now contains a list of Keys of the Requested Type
		
		i = 0
		List1.Items.Clear()
		List1.Items.Add(("Code" & vbTab & vbTab & "Name"))
		List1.Items.Add(("-------------------------------------------------------------"))
		
		'// use the RecordSet to set the BusnessPartners object
		'// by using the GetByKey method
		
		Do Until oRecordSet.EOF = True
			'// make sure the record set didn't reach the EOF
			If oRecordSet.EOF = False And i < 10 Then
				'// set the business partners object
				oBusinessPartner.GetByKey(oRecordSet.Fields.Item(0).Value)
				'// add the partner's code and name to the list box
				List1.Items.Add((oBusinessPartner.CardCode & vbTab & vbTab & oBusinessPartner.CardName))
				i = i + 1
			End If
			oRecordSet.MoveNext()
		Loop 
		
		
		Exit Sub
		
ErrorHandler: 
		MsgBox("Exception: " & Err.Description)
		
	End Sub
	
	
	Private Sub SetComboBox()
		
		Combo1.Items.Insert(0, "Cutomer")
		Combo1.Items.Insert(1, "Supplier")
		Combo1.Items.Insert(2, "Lid")
		
		Combo1.SelectedIndex = 0
		
	End Sub
End Class
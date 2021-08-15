Option Strict Off
Option Explicit On
Friend Class ItemList
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
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(ItemList))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ToolTip1.Active = True
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me.List1 = New System.Windows.Forms.ListBox
		Me.Label5 = New System.Windows.Forms.Label
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Text = "GetItemList bob"
		Me.ClientSize = New System.Drawing.Size(242, 228)
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
		Me.Name = "ItemList"
		Me.Frame2.Size = New System.Drawing.Size(241, 225)
		Me.Frame2.Location = New System.Drawing.Point(0, 0)
		Me.Frame2.TabIndex = 0
		Me.Frame2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame2.BackColor = System.Drawing.SystemColors.Control
		Me.Frame2.Enabled = True
		Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Name = "Frame2"
		Me.List1.Size = New System.Drawing.Size(225, 176)
		Me.List1.Location = New System.Drawing.Point(8, 40)
		Me.List1.TabIndex = 2
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
		Me.Label5.Text = "First 10 Items:"
		Me.Label5.Size = New System.Drawing.Size(113, 17)
		Me.Label5.Location = New System.Drawing.Point(8, 16)
		Me.Label5.TabIndex = 1
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
		Me.Controls.Add(Frame2)
		Me.Frame2.Controls.Add(List1)
		Me.Frame2.Controls.Add(Label5)
	End Sub
#End Region 
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As ItemList
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As ItemList
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New ItemList()
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
	'//  File:      ItemList.frm
	'//
	'//  Copyright (c) SAP MANAGE
	'//
	'// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
	'// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
	'// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
	'// PARTICULAR PURPOSE.
	'//
	'//****************************************************************************
	
	
	Private Sub ItemList_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		Dim oSBObob As SAPbobsCOM.SBObob
		Dim oRecordSet As SAPbobsCOM.Recordset
		
		Dim i As Integer
		
		'// catch exceptions
		'// can be used instead of Company.GetLastError method
		On Error GoTo ErrorHandler
		
		
		'// Get an initialized SBObob object
		oSBObob = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoBridge)
		'// Get an initialized Recordset object
		oRecordSet = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
		
		'// Execute the SBObob GetItemList method
		oRecordSet = oSBObob.GetItemList()
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
				'// add the user's name
				List1.Items.Add(oRecordSet.Fields.Item(0).Value & vbTab & vbTab & oRecordSet.Fields.Item(1).Value)
				i = i + 1
			End If
			oRecordSet.MoveNext()
		Loop 
		
		
		Exit Sub
		
ErrorHandler: 
		MsgBox("Exception: " & Err.Description)
	End Sub
End Class
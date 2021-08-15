'//  SAP MANAGE DI API 2007 SDK Sample
'//****************************************************************************
'//
'//  File:      BasicOperations.vb
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
Class BasicOperations
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
    Public WithEvents Command3 As System.Windows.Forms.Button
    Public WithEvents Command2 As System.Windows.Forms.Button
    Public WithEvents Command1 As System.Windows.Forms.Button
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(BasicOperations))
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
        Me.ToolTip1.Active = True
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.Command3 = New System.Windows.Forms.Button
        Me.Command2 = New System.Windows.Forms.Button
        Me.Command1 = New System.Windows.Forms.Button
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Text = "Basic Operations"
        Me.ClientSize = New System.Drawing.Size(257, 233)
        Me.Location = New System.Drawing.Point(184, 250)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.ShowInTaskbar = False
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ControlBox = True
        Me.Enabled = True
        Me.KeyPreview = False
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HelpButton = False
        Me.WindowState = System.Windows.Forms.FormWindowState.Normal
        Me.Name = "BasicOperations"
        Me.Frame1.Size = New System.Drawing.Size(257, 233)
        Me.Frame1.Location = New System.Drawing.Point(0, 0)
        Me.Frame1.TabIndex = 0
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Enabled = True
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Visible = True
        Me.Frame1.Name = "Frame1"
        Me.Command3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Command3.Text = "Data Browser Operations"
        Me.Command3.Size = New System.Drawing.Size(225, 49)
        Me.Command3.Location = New System.Drawing.Point(16, 144)
        Me.Command3.TabIndex = 3
        Me.Command3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command3.BackColor = System.Drawing.SystemColors.Control
        Me.Command3.CausesValidation = True
        Me.Command3.Enabled = True
        Me.Command3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command3.TabStop = True
        Me.Command3.Name = "Command3"
        Me.Command2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Command2.Text = "Recordset Operations"
        Me.Command2.Size = New System.Drawing.Size(225, 49)
        Me.Command2.Location = New System.Drawing.Point(16, 80)
        Me.Command2.TabIndex = 2
        Me.Command2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command2.BackColor = System.Drawing.SystemColors.Control
        Me.Command2.CausesValidation = True
        Me.Command2.Enabled = True
        Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command2.TabStop = True
        Me.Command2.Name = "Command2"
        Me.Command1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Command1.Text = "Choose Company DB"
        Me.Command1.Size = New System.Drawing.Size(225, 49)
        Me.Command1.Location = New System.Drawing.Point(16, 16)
        Me.Command1.TabIndex = 1
        Me.Command1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.CausesValidation = True
        Me.Command1.Enabled = True
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.TabStop = True
        Me.Command1.Name = "Command1"
        Me.Controls.Add(Frame1)
        Me.Frame1.Controls.Add(Command3)
        Me.Frame1.Controls.Add(Command2)
        Me.Frame1.Controls.Add(Command1)
    End Sub
#End Region
#Region "Upgrade Support "
    Private Shared m_vb6FormDefInstance As BasicOperations
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As BasicOperations
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New BasicOperations
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As BasicOperations)
            m_vb6FormDefInstance = Value
        End Set
    End Property
#End Region



    '//**************************************************************************************************
    '// BEFORE STARTING:
    '// Add reference to the "SAP Business One Objects Bridge Version 2005"
    '//-----------------------------------------------------------------
    '// 1. Project->References
    '// 2. check the "SAP Business One Objects Bridge Version 2005" check box
    '//**************************************************************************************************

    Private Sub BasicOperations_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        '// as long as we don'thave connection
        '// to a data base
        Command2.Enabled = False
        Command3.Enabled = False


        InitializeCompany()

    End Sub


    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click

        ChooseCompany.DefInstance.ShowDialog()

        If oCompany.Connected = True Then
            Command2.Enabled = True
            Command3.Enabled = True
        End If

    End Sub

    Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
        RecordsetOperations.DefInstance.ShowDialog()
    End Sub


    Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command3.Click
        DataBrowserOperations.DefInstance.ShowDialog()
    End Sub
End Class
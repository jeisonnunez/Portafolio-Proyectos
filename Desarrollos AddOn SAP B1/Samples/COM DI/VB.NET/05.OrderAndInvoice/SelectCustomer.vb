
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
'
'****************************************************************************
' In this sample the SAP Business one order form is imitated via DI 2005
'****************************************************************************

Option Explicit On 

Public Class SelectCustomer
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
    Friend WithEvents lblCustomer As System.Windows.Forms.Label
    Friend WithEvents cmbCustomer As System.Windows.Forms.ListBox
    Friend WithEvents cmbName As System.Windows.Forms.ListBox
    Friend WithEvents lstChoose As System.Windows.Forms.ListBox
    Friend WithEvents cmdSelect As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
        Me.lblCustomer = New System.Windows.Forms.Label
        Me.cmbCustomer = New System.Windows.Forms.ListBox
        Me.cmbName = New System.Windows.Forms.ListBox
        Me.lstChoose = New System.Windows.Forms.ListBox
        Me.cmdSelect = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblCustomer
        '
        Me.lblCustomer.Location = New System.Drawing.Point(8, 8)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(88, 23)
        Me.lblCustomer.TabIndex = 45
        Me.lblCustomer.Text = "Customer"
        '
        'cmbCustomer
        '
        Me.cmbCustomer.Location = New System.Drawing.Point(104, 8)
        Me.cmbCustomer.Name = "cmbCustomer"
        Me.cmbCustomer.Size = New System.Drawing.Size(24, 17)
        Me.cmbCustomer.TabIndex = 49
        Me.cmbCustomer.Visible = False
        '
        'cmbName
        '
        Me.cmbName.Location = New System.Drawing.Point(136, 8)
        Me.cmbName.Name = "cmbName"
        Me.cmbName.Size = New System.Drawing.Size(32, 17)
        Me.cmbName.TabIndex = 50
        Me.cmbName.Visible = False
        '
        'lstChoose
        '
        Me.lstChoose.Location = New System.Drawing.Point(8, 32)
        Me.lstChoose.MultiColumn = CType(configurationAppSettings.GetValue("lstChoose.MultiColumn", GetType(System.Boolean)), Boolean)
        Me.lstChoose.Name = "lstChoose"
        Me.lstChoose.Size = New System.Drawing.Size(256, 199)
        Me.lstChoose.TabIndex = 52
        '
        'cmdSelect
        '
        Me.cmdSelect.Location = New System.Drawing.Point(8, 240)
        Me.cmdSelect.Name = "cmdSelect"
        Me.cmdSelect.TabIndex = 54
        Me.cmdSelect.Text = "Choose"
        '
        'SelectCustomer
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(272, 269)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdSelect)
        Me.Controls.Add(Me.lstChoose)
        Me.Controls.Add(Me.cmbName)
        Me.Controls.Add(Me.cmbCustomer)
        Me.Controls.Add(Me.lblCustomer)
        Me.Name = "SelectCustomer"
        Me.Text = "SelectCustomer"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public BPName As String
    Public BPCode As String
    Public iSelectedIndex As Integer


    '****************************************************************************
    ' This procedure is called when the form is loaded
    '****************************************************************************
    Private Sub SelectCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadList()
    End Sub
    '****************************************************************************
    ' This procedure loads the customer list
    '****************************************************************************
    Private Sub LoadList()
        Dim oObj As SAPbobsCOM.SBObob
        Dim rs As SAPbobsCOM.Recordset

        oObj = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoBridge)
        rs = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)

        ' Set the Customer Name and Customer Code Combo Boxes
        rs = oObj.GetBPList(SAPbobsCOM.BoCardTypes.cCustomer)
        rs.MoveFirst()
        While Not (rs.EoF)
            cmbCustomer.Items.Add(rs.Fields.Item(0).Value)
            cmbName.Items.Add(rs.Fields.Item(1).Value)
            rs.MoveNext()
        End While
        If cmbCustomer.Items.Count > 0 Then
            cmbCustomer.SelectedIndex = 0
            cmbName.SelectedIndex = 0
        End If

        Dim i As Integer
        For i = 0 To cmbCustomer.Items.Count - 1
            lstChoose.Items.Add(cmbCustomer.Items(i) & ", " & cmbName.Items(i))
        Next
    End Sub

    '****************************************************************************
    ' This procedure sets the customer name and code lists by the user's choice
    '****************************************************************************
    Private Sub lstChoose_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstChoose.SelectedIndexChanged
        cmbName.SelectedIndex = lstChoose.SelectedIndex
        cmbCustomer.SelectedIndex = lstChoose.SelectedIndex
    End Sub

    '****************************************************************************
    ' This procedure is called when the "select" button is clicked.
    ' It puts values in the SelectCustomer class members, and closes the form.
    '****************************************************************************
    Private Sub cmdSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSelect.Click
        BPName = cmbName.Items(cmbName.SelectedIndex)
        BPCode = cmbCustomer.Items(cmbCustomer.SelectedIndex)
        iSelectedIndex = cmbName.SelectedIndex
        Me.Close()
    End Sub

    '****************************************************************************
    ' This procedure is called when the form is resized.
    ' It sets the size of the customer list by the size of the form.
    '****************************************************************************
    Private Sub SelectCustomer_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        lstChoose.Width = Me.Width - lstChoose.Left - 15
        lstChoose.Height = Me.Height - lstChoose.Top - 60
        cmdSelect.Top = Me.Height - cmdSelect.Height - 35
    End Sub
End Class

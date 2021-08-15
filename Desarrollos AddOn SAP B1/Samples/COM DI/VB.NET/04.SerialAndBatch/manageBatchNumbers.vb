Public Class manageBatch
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
    Friend WithEvents addButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Total As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CancelButton1 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents NumberOfBatches As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents batchNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents manBatchNumberText As System.Windows.Forms.TextBox
    Friend WithEvents InternalSerialNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.addButton = New System.Windows.Forms.Button
        Me.manBatchNumberText = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.NumberOfBatches = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Total = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.CancelButton1 = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.batchNumber = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.InternalSerialNumber = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(104, 288)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(72, 24)
        Me.addButton.TabIndex = 20
        Me.addButton.Text = "Add"
        '
        'manBatchNumberText
        '
        Me.manBatchNumberText.Location = New System.Drawing.Point(240, 216)
        Me.manBatchNumberText.Name = "manBatchNumberText"
        Me.manBatchNumberText.Size = New System.Drawing.Size(96, 20)
        Me.manBatchNumberText.TabIndex = 16
        Me.manBatchNumberText.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.NumberOfBatches)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Total)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(48, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 152)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'NumberOfBatches
        '
        Me.NumberOfBatches.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.NumberOfBatches.Location = New System.Drawing.Point(128, 104)
        Me.NumberOfBatches.Name = "NumberOfBatches"
        Me.NumberOfBatches.Size = New System.Drawing.Size(80, 16)
        Me.NumberOfBatches.TabIndex = 7
        Me.NumberOfBatches.Text = "1"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(24, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Number Of Batches:"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(24, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Total Items:"
        '
        'Total
        '
        Me.Total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Total.Location = New System.Drawing.Point(128, 80)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(80, 16)
        Me.Total.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(24, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Item Name:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Item ID:"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(128, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(128, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 16)
        Me.Label4.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(80, 216)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 16)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Manufacture Serial Number"
        '
        'CancelButton1
        '
        Me.CancelButton1.Location = New System.Drawing.Point(224, 288)
        Me.CancelButton1.Name = "CancelButton1"
        Me.CancelButton1.Size = New System.Drawing.Size(72, 24)
        Me.CancelButton1.TabIndex = 21
        Me.CancelButton1.Text = "Cancel"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(80, 192)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 16)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Batch"
        '
        'batchNumber
        '
        Me.batchNumber.Location = New System.Drawing.Point(240, 192)
        Me.batchNumber.Name = "batchNumber"
        Me.batchNumber.Size = New System.Drawing.Size(96, 20)
        Me.batchNumber.TabIndex = 12
        Me.batchNumber.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(80, 248)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(144, 16)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Internal Serial Number"
        '
        'InternalSerialNumber
        '
        Me.InternalSerialNumber.Location = New System.Drawing.Point(240, 240)
        Me.InternalSerialNumber.Name = "InternalSerialNumber"
        Me.InternalSerialNumber.Size = New System.Drawing.Size(96, 20)
        Me.InternalSerialNumber.TabIndex = 18
        Me.InternalSerialNumber.Text = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(368, 192)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(144, 16)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "+ 0,1,2,3,... (to be unique)"
        '
        'manageBatch
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(528, 445)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.InternalSerialNumber)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.batchNumber)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.manBatchNumberText)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CancelButton1)
        Me.Name = "manageBatch"
        Me.Text = "Manage Batch Numbers"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    '//  SAP MANAGE DI API 2007 SDK Sample
    '//****************************************************************************
    '//
    '//  File:      manageBatchNumbers.vb
    '//
    '//  Copyright (c) SAP MANAGE
    '//
    '// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
    '// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
    '// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
    '// PARTICULAR PURPOSE.
    '//
    '//****************************************************************************

    Private Sub manageBatch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label3.Text = oItems.ItemCode
        Label4.Text = oItems.ItemName
        Total.Text = totalNumber
        manBatchNumberText.Text = ""
        InternalSerialNumber.Text = ""
        batchNumber.Text = ""
    End Sub

    Private Sub addButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addButton.Click
        batchNum = batchNumber.Text
        manBatchNumber = manBatchNumberText.Text
        interSerNumber = InternalSerialNumber.Text
        ActiveForm.Dispose()
    End Sub

    Private Sub CancelButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelButton1.Click
        ActiveForm.Dispose()
    End Sub

End Class

Public Class ManageSerial
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents manSerialNumberText As System.Windows.Forms.TextBox
    Friend WithEvents addButton As System.Windows.Forms.Button
    Friend WithEvents Total As System.Windows.Forms.Label
    Friend WithEvents CancelButton1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Total = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.manSerialNumberText = New System.Windows.Forms.TextBox
        Me.addButton = New System.Windows.Forms.Button
        Me.CancelButton1 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Total)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(320, 120)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(24, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Total Items:"
        '
        'Total
        '
        Me.Total.BackColor = System.Drawing.SystemColors.Control
        Me.Total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Total.Location = New System.Drawing.Point(128, 80)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(80, 16)
        Me.Total.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(24, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Item Name:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(24, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Item ID:"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(128, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(128, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 16)
        Me.Label4.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(24, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Manufacture Serial Number"
        '
        'manSerialNumberText
        '
        Me.manSerialNumberText.BackColor = System.Drawing.SystemColors.Control
        Me.manSerialNumberText.Location = New System.Drawing.Point(176, 152)
        Me.manSerialNumberText.Name = "manSerialNumberText"
        Me.manSerialNumberText.Size = New System.Drawing.Size(96, 20)
        Me.manSerialNumberText.TabIndex = 7
        Me.manSerialNumberText.Text = ""
        '
        'addButton
        '
        Me.addButton.BackColor = System.Drawing.SystemColors.Control
        Me.addButton.Location = New System.Drawing.Point(48, 216)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(72, 24)
        Me.addButton.TabIndex = 8
        Me.addButton.Text = "Add"
        '
        'CancelButton1
        '
        Me.CancelButton1.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton1.Location = New System.Drawing.Point(168, 216)
        Me.CancelButton1.Name = "CancelButton1"
        Me.CancelButton1.Size = New System.Drawing.Size(72, 24)
        Me.CancelButton1.TabIndex = 9
        Me.CancelButton1.Text = "Cancel"
        '
        'ManageSerial
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(400, 325)
        Me.Controls.Add(Me.CancelButton1)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.manSerialNumberText)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ManageSerial"
        Me.Text = "Manage Serial Numbers"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    '//  SAP MANAGE DI API 2007 SDK Sample
    '//****************************************************************************
    '//
    '//  File:     ManageSerialNumbers.vb
    '//
    '//  Copyright (c) SAP MANAGE
    '//
    '// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
    '// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
    '// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
    '// PARTICULAR PURPOSE.
    '//
    '//****************************************************************************

    Private Sub ManageSerial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label3.Text = oItems.ItemCode
        Label4.Text = oItems.ItemName
        Total.Text = totalNumber
    End Sub

    Private Sub manSerialNumberText_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles manSerialNumberText.TextChanged

    End Sub

    Private Sub addButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addButton.Click
        manSerialNumber = manSerialNumberText.Text
        ActiveForm.Dispose()
    End Sub

    Private Sub CancelButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelButton1.Click
        ActiveForm.Dispose()
    End Sub

End Class

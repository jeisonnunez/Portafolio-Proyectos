'  SAP DI API 2006 Sample
'****************************************************************************
'
'  File:      StartupForm.vb
'
'  Copyright (c) SAP 
'
' THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
' ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
' THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
' PARTICULAR PURPOSE.
'
'****************************************************************************

Public Class StartupForm
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
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
    Friend WithEvents cmdLogOut As System.Windows.Forms.Button
    Friend WithEvents cmdLogIn As System.Windows.Forms.Button
    Friend WithEvents cmdItemCycle As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdLogOut = New System.Windows.Forms.Button
        Me.cmdItemCycle = New System.Windows.Forms.Button
        Me.cmdLogIn = New System.Windows.Forms.Button
        Me.SuspendLayout()

        'cmdLogOut
        Me.cmdLogOut.Location = New System.Drawing.Point(86, 144)
        Me.cmdLogOut.Name = "cmdLogOut"
        Me.cmdLogOut.Size = New System.Drawing.Size(120, 40)
        Me.cmdLogOut.TabIndex = 4
        Me.cmdLogOut.Text = "Exit"

        'cmdItemCycle
        Me.cmdItemCycle.Location = New System.Drawing.Point(86, 85)
        Me.cmdItemCycle.Name = "cmdItemCycle"
        Me.cmdItemCycle.Size = New System.Drawing.Size(120, 40)
        Me.cmdItemCycle.TabIndex = 2
        Me.cmdItemCycle.Text = "Item Cycle Count"

        'cmdLogIn
        Me.cmdLogIn.Location = New System.Drawing.Point(86, 29)
        Me.cmdLogIn.Name = "cmdLogIn"
        Me.cmdLogIn.Size = New System.Drawing.Size(120, 40)
        Me.cmdLogIn.TabIndex = 3
        Me.cmdLogIn.Text = "Log In Company"

        'StartupForm
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(280, 207)
        Me.Controls.Add(Me.cmdLogOut)
        Me.Controls.Add(Me.cmdItemCycle)
        Me.Controls.Add(Me.cmdLogIn)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StartupForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdLogIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogIn.Click

        Dim frm As New LogInForm

        'show log in dialog
        frm.ShowDialog()

        Call InitCmdButtons(True, True, True)

    End Sub


    Private Sub StartupForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call InitCmdButtons(True, False, False)

    End Sub

    Private Sub InitCmdButtons(ByVal bLogIn As Boolean, ByVal bItemCycle As Boolean, ByVal bLogOut As Boolean)

        cmdLogIn.Enabled = bLogIn
        cmdItemCycle.Enabled = bItemCycle
        cmdLogOut.Enabled = bLogOut

    End Sub

    Private Sub cmdLogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogOut.Click

        Me.Close()

    End Sub

    Private Sub cmdItemCycle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdItemCycle.Click

        Dim frm As New ItemCycleCountForm

        'show message dialog
        frm.ShowDialog()

    End Sub
End Class

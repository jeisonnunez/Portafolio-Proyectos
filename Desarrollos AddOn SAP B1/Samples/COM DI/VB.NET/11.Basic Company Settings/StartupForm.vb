'  SAP DI API 2006 SDK Sample
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

'****************************************************************************
'
' Description:
' ------------
' main menu 
'
'****************************************************************************


Public Class StartupForm
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
    Private components As System.ComponentModel.Container

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents cmdSeries As System.Windows.Forms.Button
    Friend WithEvents cmdLogOut As System.Windows.Forms.Button
    Friend WithEvents cmdLogIn As System.Windows.Forms.Button
    Friend WithEvents cmdAccount As System.Windows.Forms.Button
    Friend WithEvents cmdBp As System.Windows.Forms.Button
    Friend WithEvents cmdCompany As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdSeries = New System.Windows.Forms.Button
        Me.cmdLogOut = New System.Windows.Forms.Button
        Me.cmdLogIn = New System.Windows.Forms.Button
        Me.cmdAccount = New System.Windows.Forms.Button
        Me.cmdBp = New System.Windows.Forms.Button
        Me.cmdCompany = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cmdSeries
        '
        Me.cmdSeries.Location = New System.Drawing.Point(72, 184)
        Me.cmdSeries.Name = "cmdSeries"
        Me.cmdSeries.Size = New System.Drawing.Size(120, 40)
        Me.cmdSeries.TabIndex = 0
        Me.cmdSeries.Text = "Series Service"
        '
        'cmdLogOut
        '
        Me.cmdLogOut.Location = New System.Drawing.Point(72, 296)
        Me.cmdLogOut.Name = "cmdLogOut"
        Me.cmdLogOut.Size = New System.Drawing.Size(120, 40)
        Me.cmdLogOut.TabIndex = 0
        Me.cmdLogOut.Text = "Exit"
        '
        'cmdLogIn
        '
        Me.cmdLogIn.Location = New System.Drawing.Point(72, 16)
        Me.cmdLogIn.Name = "cmdLogIn"
        Me.cmdLogIn.Size = New System.Drawing.Size(120, 40)
        Me.cmdLogIn.TabIndex = 0
        Me.cmdLogIn.Text = "Log In Company"
        '
        'cmdAccount
        '
        Me.cmdAccount.Location = New System.Drawing.Point(72, 72)
        Me.cmdAccount.Name = "cmdAccount"
        Me.cmdAccount.Size = New System.Drawing.Size(120, 40)
        Me.cmdAccount.TabIndex = 0
        Me.cmdAccount.Text = "Account Service"
        '
        'cmdBp
        '
        Me.cmdBp.Location = New System.Drawing.Point(72, 128)
        Me.cmdBp.Name = "cmdBp"
        Me.cmdBp.Size = New System.Drawing.Size(120, 40)
        Me.cmdBp.TabIndex = 0
        Me.cmdBp.Text = "Bp Service"
        '
        'cmdCompany
        '
        Me.cmdCompany.Location = New System.Drawing.Point(72, 240)
        Me.cmdCompany.Name = "cmdCompany"
        Me.cmdCompany.Size = New System.Drawing.Size(120, 40)
        Me.cmdCompany.TabIndex = 1
        Me.cmdCompany.Text = "Company Service"
        '
        'StartupForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 17)
        Me.ClientSize = New System.Drawing.Size(264, 357)
        Me.Controls.Add(Me.cmdCompany)
        Me.Controls.Add(Me.cmdLogOut)
        Me.Controls.Add(Me.cmdSeries)
        Me.Controls.Add(Me.cmdBp)
        Me.Controls.Add(Me.cmdAccount)
        Me.Controls.Add(Me.cmdLogIn)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "StartupForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Basic Company Setting"
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub cmdLogIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogIn.Click
        Dim frm As New LogInForm
        frm.ShowDialog()
    End Sub

    Private Sub cmdAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAccount.Click
        Dim frm As New AccountServiceForm
        frm.Show()
    End Sub

    Private Sub cmdBp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBp.Click
        Dim frm As New BpSeviceForm
        frm.Show()
    End Sub

    Private Sub cmdSeries_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSeries.Click
        Dim frm As New SeriesServiceForm
        frm.Show()
    End Sub

    Private Sub cmdCompany_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCompany.Click
        Dim frm As New CompanyServiceForm
        frm.Show()
    End Sub

    Private Sub cmdLogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogOut.Click

        'oCompany.Disconnect()
        Me.Close()

    End Sub

    Private Sub StartupForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class

'  SAP MANAGE UI API 2007 SDK Sample
'****************************************************************************
'
'  File:      fromMain.vb
'
'  Copyright (c) SAP MANAGE
'
' THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
' ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
' THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
' PARTICULAR PURPOSE.
'
'****************************************************************************
' BEFORE STARTING:
' 1. Add reference to the "SAP Business One UI API"
' 2. Insert the development connection string to the "Command line argument"
'-----------------------------------------------------------------
' 1.
'    a. Project->Add Reference...
'    b. select the "SAP Business One UI API 2007" From the COM folder
'
' 2.
'     a. Project->Properties...
'     b. choose Configuration Properties folder (place the arrow on Debugging)
'     c. place the following connection string in the 'Command line arguments' field
' 0030002C0030002C00530041005000420044005F00440061007400650076002C0050004C006F006D0056004900490056
'
'**************************************************************************************************

Option Strict Off
Option Explicit On 

Public Class frmPeriod
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

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
    Friend WithEvents cmdGetData As System.Windows.Forms.Button
    Friend WithEvents txtCurPeriod As System.Windows.Forms.TextBox
    Friend WithEvents lblCurrPeriod As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdGetData = New System.Windows.Forms.Button
        Me.txtCurPeriod = New System.Windows.Forms.TextBox
        Me.lblCurrPeriod = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'cmdGetData
        '
        Me.cmdGetData.Location = New System.Drawing.Point(24, 24)
        Me.cmdGetData.Name = "cmdGetData"
        Me.cmdGetData.Size = New System.Drawing.Size(152, 40)
        Me.cmdGetData.TabIndex = 0
        Me.cmdGetData.Text = "Get Current Period"
        '
        'txtCurPeriod
        '
        Me.txtCurPeriod.Enabled = False
        Me.txtCurPeriod.Location = New System.Drawing.Point(24, 112)
        Me.txtCurPeriod.Name = "txtCurPeriod"
        Me.txtCurPeriod.Size = New System.Drawing.Size(152, 20)
        Me.txtCurPeriod.TabIndex = 1
        Me.txtCurPeriod.Text = ""
        '
        'lblCurrPeriod
        '
        Me.lblCurrPeriod.Location = New System.Drawing.Point(24, 88)
        Me.lblCurrPeriod.Name = "lblCurrPeriod"
        Me.lblCurrPeriod.Size = New System.Drawing.Size(100, 16)
        Me.lblCurrPeriod.TabIndex = 2
        Me.lblCurrPeriod.Text = "Current Period"
        '
        'frmPeriod
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(200, 157)
        Me.Controls.Add(Me.lblCurrPeriod)
        Me.Controls.Add(Me.txtCurPeriod)
        Me.Controls.Add(Me.cmdGetData)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPeriod"
        Me.Text = "Current Period"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private WithEvents SBO_Application As SAPbouiCOM.Application


    Private Sub SetApplication()

        '*******************************************************************
        ' Use an SboGuiApi object to establish connection
        ' with the SAP Business One application and return an
        ' initialized appliction object
        '*******************************************************************

        Dim SboGuiApi As SAPbouiCOM.SboGuiApi
        Dim sConnectionString As String

        SboGuiApi = New SAPbouiCOM.SboGuiApi

        ' by following the steps specified above, the following
        ' statment should be suficient for either development or run mode

        sConnectionString = Environment.GetCommandLineArgs.GetValue(1)

        ' connect to a running SBO Application

        SboGuiApi.Connect(sConnectionString)

        ' get an initialized application object

        SBO_Application = SboGuiApi.GetApplication()

    End Sub


    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call


        '*************************************************************
        ' set SBO_Application with an initialized application object
        '*************************************************************

        SetApplication()

    End Sub

    Private Sub cmdGetData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetData.Click
        txtCurPeriod.Text = SBO_Application.Company.CurrentPeriod.ToString
    End Sub
End Class

'//  SAP MANAGE UI API 2007 SDK Sample
'//****************************************************************************
'//
'//  File:      ProgressBar.vb
'//
'//  Copyright (c) SAP MANAGE
'//
'// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
'// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
'// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
'// PARTICULAR PURPOSE.
'//
'// BEFORE STARTING:
'// 1. Add reference to the "SAP Business One UI API"
'// 2. Insert the development connection string to the "Command line argument"
'//-----------------------------------------------------------------
'// 1.
'//    a. Project->Add Reference...
'//    b. select the "SAP Business One UI API 2007" From the COM folder
'//
'// 2.
'//     a. Project->Properties...
'//     b. choose Configuration Properties folder (place the arrow on Debugging)
'//     c. place the following connection string in the 'Command line arguments' field
'// 0030002C0030002C00530041005000420044005F00440061007400650076002C0050004C006F006D0056004900490056
'//
'//**************************************************************************************************
Option Strict Off
Option Explicit On 

Public Class ProgressBar
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
    Friend WithEvents cmdStart As System.Windows.Forms.Button
    Friend WithEvents cmdFoward As System.Windows.Forms.Button
    Friend WithEvents cmdBack As System.Windows.Forms.Button
    Friend WithEvents cmdStop As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdStart = New System.Windows.Forms.Button
        Me.cmdFoward = New System.Windows.Forms.Button
        Me.cmdBack = New System.Windows.Forms.Button
        Me.cmdStop = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cmdStart
        '
        Me.cmdStart.Location = New System.Drawing.Point(72, 8)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.TabIndex = 0
        Me.cmdStart.Text = "Start"
        '
        'cmdFoward
        '
        Me.cmdFoward.Enabled = False
        Me.cmdFoward.Location = New System.Drawing.Point(120, 48)
        Me.cmdFoward.Name = "cmdFoward"
        Me.cmdFoward.TabIndex = 1
        Me.cmdFoward.Text = "Foward >>"
        '
        'cmdBack
        '
        Me.cmdBack.Enabled = False
        Me.cmdBack.Location = New System.Drawing.Point(24, 48)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.TabIndex = 2
        Me.cmdBack.Text = "<< Back"
        '
        'cmdStop
        '
        Me.cmdStop.Enabled = False
        Me.cmdStop.Location = New System.Drawing.Point(72, 88)
        Me.cmdStop.Name = "cmdStop"
        Me.cmdStop.TabIndex = 3
        Me.cmdStop.Text = "Stop"
        '
        'ProgressBar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(226, 127)
        Me.Controls.Add(Me.cmdStop)
        Me.Controls.Add(Me.cmdBack)
        Me.Controls.Add(Me.cmdFoward)
        Me.Controls.Add(Me.cmdStart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ProgressBar"
        Me.Text = "ProgressBar"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private WithEvents SBO_Application As SAPbouiCOM.Application
    Private oProgBar As SAPbouiCOM.ProgressBar ' This is the progress bar
    Private Sub ProgressBar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetApplication()
    End Sub
    Private Sub SetApplication()

        '*******************************************************************
        '// Use an SboGuiApi object to establish the connection
        '// with the application and rturn an initialized appliction object
        '*******************************************************************

        Dim SboGuiApi As SAPbouiCOM.SboGuiApi
        Dim sConnectionString As String

        SboGuiApi = New SAPbouiCOM.SboGuiApi

        '// by following the steps specified above, the following
        '// statment should be suficient for either development or run mode

        sConnectionString = Environment.GetCommandLineArgs.GetValue(1)

        '// connect to a running SBO Application

        SboGuiApi.Connect(sConnectionString)

        '// get an initialized application object

        SBO_Application = SboGuiApi.GetApplication()

    End Sub

    Private Sub cmdStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStart.Click
        'Create a Progress Bar
        oProgBar = SBO_Application.StatusBar.CreateProgressBar("Sample Progress Bar", 27, True)

        'Enable the progress bar controls
        cmdFoward.Enabled = True
        cmdBack.Enabled = True
        cmdStop.Enabled = True

        'Disable the 'Start' button
        cmdStart.Enabled = False
    End Sub

    Private Sub cmdFoward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFoward.Click
        oProgBar.Value += 1
    End Sub

    Private Sub cmdBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBack.Click
        oProgBar.Value -= 1
    End Sub

    Private Sub cmdStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStop.Click
        ReleaseBar()
    End Sub
    Private Sub ReleaseBar()
        'Stopping the progress bar, thus loosing it's values.
        oProgBar.Stop()

        'Disable the progress bar controls
        cmdFoward.Enabled = False
        cmdBack.Enabled = False
        cmdStop.Enabled = False

        'Enable the 'Start' button
        cmdStart.Enabled = True

    End Sub
    Private Sub SBO_Application_ProgressBarEvent(ByRef pVal As SAPbouiCOM.ProgressBarEvent, ByRef BubbleEvent As Boolean) Handles SBO_Application.ProgressBarEvent
        If pVal.EventType = SAPbouiCOM.BoProgressBarEventTypes.pbet_ProgressBarStopped And pVal.BeforeAction Then
            SBO_Application.MessageBox("Progress Bar stopped by user, releasing progress bar")
            ReleaseBar()
        End If
    End Sub
End Class

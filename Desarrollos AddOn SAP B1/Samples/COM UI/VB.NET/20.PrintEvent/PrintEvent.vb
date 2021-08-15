'//  SAP MANAGE UI API 2007 SDK Sample
'//****************************************************************************
'//
'//  File:      PrintEvent.vb
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
Imports System.Xml

Public Class PrintEvent
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
    Friend WithEvents printXML As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.printXML = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'printXML
        '
        Me.printXML.Location = New System.Drawing.Point(16, 120)
        Me.printXML.Multiline = True
        Me.printXML.Name = "printXML"
        Me.printXML.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.printXML.Size = New System.Drawing.Size(528, 224)
        Me.printXML.TabIndex = 2
        Me.printXML.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(528, 48)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "This sample will respond to any print event sent from SBO and respont to it. It w" & _
        "il ask the user if to catch it or not and if to present it in SBO or not."
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(392, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "A report that was caught will be displayed here"
        '
        'PrintEvent
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(562, 367)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.printXML)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "PrintEvent"
        Me.Text = "Print Event"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private WithEvents SBO_Application As SAPbouiCOM.Application
    Private IsRegistered As Boolean

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

    Private Sub SBO_Application_ReportDataEvent(ByRef reportDataInfo As SAPbouiCOM.ReportDataInfo, ByRef BubbleEvent As Boolean) Handles SBO_Application.ReportDataEvent

        If reportDataInfo.BeforeAction = True Then      'before action
            Dim ans As Integer
            ans = MsgBox("A Report event was sent, do you wish to register to it?", MsgBoxStyle.YesNo)
            IsRegistered = False

            If ans = vbYes Then
                reportDataInfo.RegisterForReport(True)
                IsRegistered = True
            End If
        End If

        If reportDataInfo.BeforeAction = False Then     'after action
            MsgBox("ReportDataEvent after")
            If IsRegistered Then
                If (reportDataInfo.GetPageCount() >= 1) Then
                    printXML.Text = reportDataInfo.GetReportData(1, reportDataInfo.GetPageCount())
                End If
            End If
        End If
    End Sub

    Private Sub SBO_Application_PrintEvent(ByRef printeventInfo As SAPbouiCOM.PrintEventInfo, ByRef BubbleEvent As Boolean) Handles SBO_Application.PrintEvent
        If printeventInfo.BeforeAction = True Then      'before action
            Dim ans As Integer
            ans = MsgBox("Do you want to view it in SBO?", MsgBoxStyle.YesNo)

            If ans = vbNo Then
                BubbleEvent = False
            End If

        End If

        If printeventInfo.BeforeAction = False Then      'after action
            MsgBox("PrintEvent after")
        End If

    End Sub

    Private Sub PrintEvent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetApplication()

    End Sub

End Class

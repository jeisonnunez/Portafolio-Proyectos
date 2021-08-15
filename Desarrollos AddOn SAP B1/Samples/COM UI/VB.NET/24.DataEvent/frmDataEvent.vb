'  SAP MANAGE UI API 2007 SDK Sample
'****************************************************************************
'
'  File:      frmDataEvent.vb
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

Option Explicit On 
Option Strict On

Public Class FrmDataEvent

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
    Friend WithEvents lblWatch As System.Windows.Forms.Label
    Friend WithEvents EventsData As System.Data.DataSet
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents GridDataEvent As System.Windows.Forms.DataGrid
    Friend WithEvents tblDataEvent As System.Data.DataTable
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblWatch = New System.Windows.Forms.Label
        Me.GridDataEvent = New System.Windows.Forms.DataGrid
        Me.tblDataEvent = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.EventsData = New System.Data.DataSet
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.GridDataEvent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblDataEvent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EventsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWatch
        '
        Me.lblWatch.Location = New System.Drawing.Point(16, 16)
        Me.lblWatch.Name = "lblWatch"
        Me.lblWatch.Size = New System.Drawing.Size(552, 16)
        Me.lblWatch.TabIndex = 1
        Me.lblWatch.Text = "This sample watches all the data events and loggs them in a table. "
        '
        'GridDataEvent
        '
        Me.GridDataEvent.DataMember = ""
        Me.GridDataEvent.DataSource = Me.tblDataEvent
        Me.GridDataEvent.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.GridDataEvent.Location = New System.Drawing.Point(0, 72)
        Me.GridDataEvent.Name = "GridDataEvent"
        Me.GridDataEvent.Size = New System.Drawing.Size(600, 280)
        Me.GridDataEvent.TabIndex = 3
        '
        'tblDataEvent
        '
        Me.tblDataEvent.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7})
        Me.tblDataEvent.TableName = "DataEventTable"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "ActionSuccess"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "BeforeAction"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "EventType"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "FormType"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "FormUID"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "ObjectKey"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "Type"
        '
        'EventsData
        '
        Me.EventsData.DataSetName = "DataEventSet"
        Me.EventsData.Locale = New System.Globalization.CultureInfo("en-US")
        Me.EventsData.Tables.AddRange(New System.Data.DataTable() {Me.tblDataEvent})
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(552, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Try to Add,Update,Delete or Load any data in SBO and watch the events being logge" & _
        "d"
        '
        'FrmDataEvent
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(600, 349)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GridDataEvent)
        Me.Controls.Add(Me.lblWatch)
        Me.Name = "FrmDataEvent"
        Me.Text = "Data Event"
        Me.TopMost = True
        CType(Me.GridDataEvent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblDataEvent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EventsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    '**********************************************************
    ' This data member will use us to manipulate the
    ' SAP Business One Application
    '**********************************************************

    Private WithEvents SBO_Application As SAPbouiCOM.Application

    '***********************************************************************
    ' This Sub is the main idea of this sample - to use Data Events.
    ' For each Data Event fired from SBO a new line is created in the grid.
    '***********************************************************************
    Public Sub FormDataEvent(ByRef BusinessObjectInfo As SAPbouiCOM.BusinessObjectInfo, ByRef BubbleEvent As Boolean) Handles SBO_Application.FormDataEvent
        Dim nor As Integer
        Dim NewRow As DataRow

        NewRow = EventsData.Tables("DataEventTable").NewRow()

        nor = EventsData.Tables("DataEventTable").Rows.Count()

        NewRow(0) = BusinessObjectInfo.ActionSuccess.ToString()
        NewRow(1) = BusinessObjectInfo.BeforeAction.ToString()
        NewRow(2) = BusinessObjectInfo.EventType.ToString()
        NewRow(3) = BusinessObjectInfo.FormTypeEx.ToString()
        NewRow(4) = BusinessObjectInfo.FormUID.ToString()
        NewRow(5) = BusinessObjectInfo.ObjectKey.ToString()
        NewRow(6) = BusinessObjectInfo.Type.ToString()

        EventsData.Tables("DataEventTable").Rows.Add(NewRow)
    End Sub

    Private Sub FrmDataEvent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetApplication()
    End Sub

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

        sConnectionString = System.Convert.ToString(Environment.GetCommandLineArgs.GetValue(1))

        ' connect to a running SBO Application

        SboGuiApi.Connect(sConnectionString)

        ' get an initialized application object

        SBO_Application = SboGuiApi.GetApplication()

    End Sub

    Private Sub FrmDataEvent_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        GridDataEvent.Width = Me.Width - 5
        GridDataEvent.Height = Me.ClientSize.Height - 5 - GridDataEvent.Top
    End Sub
End Class

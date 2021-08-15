'  SAP DI API 2006 SDK Sample
'****************************************************************************
'
'  File:      ReportLayoutForm.vb
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
' Add a new Report Layout based on an existing layout
'
'****************************************************************************



Imports SAPbobsCOM

Public Class ReportLayoutForm

    Inherits System.Windows.Forms.Form

    Dim oReportLayoutService As ReportLayoutsService


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
    Friend WithEvents cmdAddReport As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtReportRemarks As System.Windows.Forms.TextBox
    Friend WithEvents txtReportAuthor As System.Windows.Forms.TextBox
    Friend WithEvents txtReportName As System.Windows.Forms.TextBox
    Friend WithEvents txtDocumentCode As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdAddReport = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtReportRemarks = New System.Windows.Forms.TextBox
        Me.txtReportAuthor = New System.Windows.Forms.TextBox
        Me.txtReportName = New System.Windows.Forms.TextBox
        Me.txtDocumentCode = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdAddReport
        '
        Me.cmdAddReport.Location = New System.Drawing.Point(304, 272)
        Me.cmdAddReport.Name = "cmdAddReport"
        Me.cmdAddReport.Size = New System.Drawing.Size(88, 24)
        Me.cmdAddReport.TabIndex = 0
        Me.cmdAddReport.Text = "Add Report"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtReportRemarks)
        Me.GroupBox1.Controls.Add(Me.txtReportAuthor)
        Me.GroupBox1.Controls.Add(Me.txtReportName)
        Me.GroupBox1.Controls.Add(Me.txtDocumentCode)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(384, 240)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Report Layout Properties"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(248, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 24)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "(e.g.   POR2=PurchaseOrder)"
        '
        'txtReportRemarks
        '
        Me.txtReportRemarks.Location = New System.Drawing.Point(136, 168)
        Me.txtReportRemarks.Name = "txtReportRemarks"
        Me.txtReportRemarks.Size = New System.Drawing.Size(112, 20)
        Me.txtReportRemarks.TabIndex = 22
        Me.txtReportRemarks.Text = "My Remarks"
        '
        'txtReportAuthor
        '
        Me.txtReportAuthor.Location = New System.Drawing.Point(136, 128)
        Me.txtReportAuthor.Name = "txtReportAuthor"
        Me.txtReportAuthor.Size = New System.Drawing.Size(112, 20)
        Me.txtReportAuthor.TabIndex = 21
        Me.txtReportAuthor.Text = "My Author"
        '
        'txtReportName
        '
        Me.txtReportName.Location = New System.Drawing.Point(136, 48)
        Me.txtReportName.Name = "txtReportName"
        Me.txtReportName.Size = New System.Drawing.Size(112, 20)
        Me.txtReportName.TabIndex = 20
        Me.txtReportName.Text = "My Report  Layout"
        '
        'txtDocumentCode
        '
        Me.txtDocumentCode.Location = New System.Drawing.Point(136, 88)
        Me.txtDocumentCode.Name = "txtDocumentCode"
        Me.txtDocumentCode.Size = New System.Drawing.Size(112, 20)
        Me.txtDocumentCode.TabIndex = 18
        Me.txtDocumentCode.Text = "POR2"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 16)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Report Remarks"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Report Author"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Report Name"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Document Type Code"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(16, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 16)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Report Author"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(16, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Report Name"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(16, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 16)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Document Type Code"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(144, 88)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(112, 20)
        Me.TextBox1.TabIndex = 17
        Me.TextBox1.Text = "POR2"
        '
        'ReportLayoutForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(408, 309)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdAddReport)
        Me.Name = "ReportLayoutForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report Layout"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub ReportLayoutForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call InitService()

    End Sub


    'init the service object
    Public Sub InitService()


        'get company service
        oCmpSrv = oCompany.GetCompanyService

        'get report service
        oReportLayoutService = oCmpSrv.GetBusinessService(ServiceTypes.ReportLayoutsService)


    End Sub

    'the function adds new layout to a specific document type
    'to add a layout you must get an existing layout 
    'and make the changes on this layout and than add the layout
    Private Sub cmdAddReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddReport.Click

        Try

            Dim oReportLayout As ReportLayout
            Dim oReportParam As ReportParams

            'get report layout service
            oReportLayoutService = oCmpSrv.GetBusinessService(ServiceTypes.ReportLayoutsService)

            'get report params
            oReportParam = oReportLayoutService.GetDataInterface(ReportLayoutsServiceDataInterfaces.rlsdiReportParams)

            'report code is the document type code (POR2=PurchaseOrder)
            oReportParam.ReportCode = txtDocumentCode.Text

            'get the default layout of the specific document 
            oReportLayout = oReportLayoutService.GetDefaultReportLayout(oReportParam)

            'set the new layout name
            oReportLayout.Name = txtReportName.Text

            'set the new author name
            oReportLayout.Author = txtReportAuthor.Text

            'set the remarks
            oReportLayout.Remarks = txtReportRemarks.Text

            'add the new layout to the specific document
            oReportLayoutService.AddReportLayout(oReportLayout)

            Me.Close()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

End Class

'  SAP DI API 2006 SDK Sample
'****************************************************************************
'
'  File:      AddSeriesForm.vb
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
' Creates new series to a specific document
' 
'****************************************************************************

Imports SAPbobsCOM

Public Class AddSeriesForm
    Inherits System.Windows.Forms.Form

    Dim oSeriesService As SAPbobsCOM.SeriesService

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
    Friend WithEvents cmdAddSeries As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSeriesName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtGroupCode As System.Windows.Forms.TextBox
    Friend WithEvents txtInitialNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblLastNumber As System.Windows.Forms.Label
    Friend WithEvents txtLastNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtDocumentType As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPeriod As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdAddSeries = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtGroupCode = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtPeriod = New System.Windows.Forms.TextBox
        Me.txtSeriesName = New System.Windows.Forms.TextBox
        Me.txtInitialNumber = New System.Windows.Forms.TextBox
        Me.lblLastNumber = New System.Windows.Forms.Label
        Me.txtLastNumber = New System.Windows.Forms.TextBox
        Me.txtDocumentType = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdAddSeries
        '
        Me.cmdAddSeries.Location = New System.Drawing.Point(240, 256)
        Me.cmdAddSeries.Name = "cmdAddSeries"
        Me.cmdAddSeries.Size = New System.Drawing.Size(88, 24)
        Me.cmdAddSeries.TabIndex = 0
        Me.cmdAddSeries.Text = "Add Series"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtDocumentType)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblLastNumber)
        Me.GroupBox1.Controls.Add(Me.txtLastNumber)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtGroupCode)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtPeriod)
        Me.GroupBox1.Controls.Add(Me.txtSeriesName)
        Me.GroupBox1.Controls.Add(Me.txtInitialNumber)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 224)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Document Series"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Initial Number"
        '
        'txtGroupCode
        '
        Me.txtGroupCode.Location = New System.Drawing.Point(112, 128)
        Me.txtGroupCode.Name = "txtGroupCode"
        Me.txtGroupCode.Size = New System.Drawing.Size(96, 20)
        Me.txtGroupCode.TabIndex = 11
        Me.txtGroupCode.Text = "1"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(16, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Group Code"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Series Name"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Period Indicator"
        '
        'txtPeriod
        '
        Me.txtPeriod.Location = New System.Drawing.Point(112, 96)
        Me.txtPeriod.Name = "txtPeriod"
        Me.txtPeriod.Size = New System.Drawing.Size(96, 20)
        Me.txtPeriod.TabIndex = 1
        Me.txtPeriod.Text = "Default"
        '
        'txtSeriesName
        '
        Me.txtSeriesName.Location = New System.Drawing.Point(112, 64)
        Me.txtSeriesName.Name = "txtSeriesName"
        Me.txtSeriesName.Size = New System.Drawing.Size(96, 20)
        Me.txtSeriesName.TabIndex = 0
        Me.txtSeriesName.Text = "Series1"
        '
        'txtInitialNumber
        '
        Me.txtInitialNumber.Location = New System.Drawing.Point(112, 160)
        Me.txtInitialNumber.Name = "txtInitialNumber"
        Me.txtInitialNumber.Size = New System.Drawing.Size(96, 20)
        Me.txtInitialNumber.TabIndex = 13
        Me.txtInitialNumber.Text = "300"
        '
        'lblLastNumber
        '
        Me.lblLastNumber.Location = New System.Drawing.Point(16, 192)
        Me.lblLastNumber.Name = "lblLastNumber"
        Me.lblLastNumber.Size = New System.Drawing.Size(88, 16)
        Me.lblLastNumber.TabIndex = 14
        Me.lblLastNumber.Text = "Last Number"
        '
        'txtLastNumber
        '
        Me.txtLastNumber.Location = New System.Drawing.Point(112, 192)
        Me.txtLastNumber.Name = "txtLastNumber"
        Me.txtLastNumber.Size = New System.Drawing.Size(96, 20)
        Me.txtLastNumber.TabIndex = 15
        Me.txtLastNumber.Text = "350"
        '
        'txtDocumentType
        '
        Me.txtDocumentType.Location = New System.Drawing.Point(112, 32)
        Me.txtDocumentType.Name = "txtDocumentType"
        Me.txtDocumentType.Size = New System.Drawing.Size(96, 20)
        Me.txtDocumentType.TabIndex = 17
        Me.txtDocumentType.Text = "15 "
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Documnet Type"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(216, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 32)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "(e.g.  Deliveries=15)"
        '
        'AddSeriesForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(344, 293)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdAddSeries)
        Me.Name = "AddSeriesForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Series"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub AddSeries_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'initiate series service
        Call InitService()

    End Sub


    Private Sub InitService()

        oCmpSrv = oCompany.GetCompanyService

        'get series service
        oSeriesService = oCmpSrv.GetBusinessService(ServiceTypes.SeriesService)

    End Sub

    'the function gets a new series , set its properties ( name,document...)
    'and add it to the chosen document
    'before adding the series to the document check that the last property of the
    'last series has a value
    Private Sub cmdAddSeries_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddSeries.Click

        Dim oSeries As Series
        Dim oSeriesParams As SeriesParams

        Try
                        
            'get series
            oSeries = oSeriesService.GetDataInterface(SeriesServiceDataInterfaces.ssdiSeries)

            'set series name
            oSeries.Name = txtSeriesName.Text

            'set doument type(e.g. Deliveries=15)
            oSeries.Document = txtDocumentType.Text

            'set the period indicator
            oSeries.PeriodIndicator = txtPeriod.Text

            'set the group code
            '(enum BoSeriesGroupEnum has all Group Enum)
            oSeries.GroupCode = CInt(txtGroupCode.Text)

            'set the first number
            oSeries.InitialNumber = CInt(txtInitialNumber.Text)

            'set last number
            oSeries.LastNumber = CInt(txtLastNumber.Text)

            'add series
            oSeriesParams = oSeriesService.AddSeries(oSeries)

            Me.Close()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub


End Class

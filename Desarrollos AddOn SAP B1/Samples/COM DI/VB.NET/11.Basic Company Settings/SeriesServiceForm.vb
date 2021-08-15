'  SAP DI API 2006 SDK Sample
'****************************************************************************
'
'  File:      SeriesServiceForm.vb
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
' 1) Get the series of a document 
' 2) Add Series
'****************************************************************************

Imports SAPbobsCOM

Public Class SeriesServiceForm
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdGetSeries As System.Windows.Forms.Button
    Friend WithEvents txtDocType As System.Windows.Forms.TextBox
    Friend WithEvents cmdAddSeries As System.Windows.Forms.Button
    Friend WithEvents First As System.Windows.Forms.ColumnHeader
    Friend WithEvents Next1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Group As System.Windows.Forms.ColumnHeader
    Friend WithEvents PeriodInd As System.Windows.Forms.ColumnHeader
    Friend WithEvents lsvSeriesDoc As System.Windows.Forms.ListView
    Friend WithEvents Document As System.Windows.Forms.ColumnHeader
    Friend WithEvents Last As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdGetSeries = New System.Windows.Forms.Button
        Me.txtDocType = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdAddSeries = New System.Windows.Forms.Button
        Me.lsvSeriesDoc = New System.Windows.Forms.ListView
        Me.Document = New System.Windows.Forms.ColumnHeader
        Me.First = New System.Windows.Forms.ColumnHeader
        Me.Next1 = New System.Windows.Forms.ColumnHeader
        Me.Last = New System.Windows.Forms.ColumnHeader
        Me.Group = New System.Windows.Forms.ColumnHeader
        Me.PeriodInd = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'cmdGetSeries
        '
        Me.cmdGetSeries.Location = New System.Drawing.Point(272, 24)
        Me.cmdGetSeries.Name = "cmdGetSeries"
        Me.cmdGetSeries.Size = New System.Drawing.Size(120, 24)
        Me.cmdGetSeries.TabIndex = 0
        Me.cmdGetSeries.Text = "Get Document Series"
        '
        'txtDocType
        '
        Me.txtDocType.Location = New System.Drawing.Point(136, 24)
        Me.txtDocType.Name = "txtDocType"
        Me.txtDocType.Size = New System.Drawing.Size(120, 20)
        Me.txtDocType.TabIndex = 1
        Me.txtDocType.Text = "13"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Document Type      (e.g. SalesInvoice=13)"
        '
        'cmdAddSeries
        '
        Me.cmdAddSeries.Location = New System.Drawing.Point(272, 208)
        Me.cmdAddSeries.Name = "cmdAddSeries"
        Me.cmdAddSeries.Size = New System.Drawing.Size(120, 24)
        Me.cmdAddSeries.TabIndex = 4
        Me.cmdAddSeries.Text = "Add Series"
        '
        'lsvSeriesDoc
        '
        Me.lsvSeriesDoc.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Document, Me.First, Me.Next1, Me.Last, Me.Group, Me.PeriodInd})
        Me.lsvSeriesDoc.FullRowSelect = True
        Me.lsvSeriesDoc.GridLines = True
        Me.lsvSeriesDoc.Location = New System.Drawing.Point(16, 72)
        Me.lsvSeriesDoc.Name = "lsvSeriesDoc"
        Me.lsvSeriesDoc.Size = New System.Drawing.Size(376, 120)
        Me.lsvSeriesDoc.TabIndex = 5
        Me.lsvSeriesDoc.View = System.Windows.Forms.View.Details
        '
        'Document
        '
        Me.Document.Text = "Document Type"
        Me.Document.Width = 89
        '
        'First
        '
        Me.First.Text = "First"
        Me.First.Width = 48
        '
        'Next1
        '
        Me.Next1.Text = "Next"
        Me.Next1.Width = 47
        '
        'Last
        '
        Me.Last.Text = "Last"
        Me.Last.Width = 46
        '
        'Group
        '
        Me.Group.Text = "Group"
        Me.Group.Width = 47
        '
        'PeriodInd
        '
        Me.PeriodInd.Text = "Period Ind"
        Me.PeriodInd.Width = 92
        '
        'SeriesServiceForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(408, 245)
        Me.Controls.Add(Me.lsvSeriesDoc)
        Me.Controls.Add(Me.cmdAddSeries)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDocType)
        Me.Controls.Add(Me.cmdGetSeries)
        Me.Name = "SeriesServiceForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Series Service"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub SeriesServiceForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call InitService()

    End Sub

    'the function gets the list of series of the current document
    Private Sub cmdGetSeries_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetSeries.Click

        Dim oSeriesCollection As SeriesCollection
        Dim oSeries As Series
        Dim oDocumentTypeParams As DocumentTypeParams
        Dim i As Integer

        'clear list view
        lsvSeriesDoc.Items.Clear()

        Try

            'get company service
            oCmpSrv = oCompany.GetCompanyService

            'get series service
            oSeriesService = oCmpSrv.GetBusinessService(ServiceTypes.SeriesService)

            'get series collection
            oSeriesCollection = oSeriesService.GetDataInterface(SeriesServiceDataInterfaces.ssdiSeriesCollection)

            'get Document Type Params
            oDocumentTypeParams = oSeriesService.GetDataInterface(SeriesServiceDataInterfaces.ssdiDocumentTypeParams)

            'set the document type 
            '(e.g. SaleInvoice=13 , BoObjectTypes has all document types)
            oDocumentTypeParams.Document = txtDocType.Text

            'get series collection
            oSeriesCollection = oSeriesService.GetDocumentSeries(oDocumentTypeParams)

            For i = 0 To oSeriesCollection.Count - 1

                Dim pItem As ListViewItem = lsvSeriesDoc.Items.Add(oSeriesCollection.Item(i).Document)

                'add document type
                pItem.SubItems.Add(oSeriesCollection.Item(i).Name)
                'add first series number
                pItem.SubItems.Add(oSeriesCollection.Item(i).InitialNumber)
                'add next number    
                pItem.SubItems.Add(oSeriesCollection.Item(i).NextNumber)
                'add last number
                pItem.SubItems.Add(oSeriesCollection.Item(i).LastNumber)
                'add period indicator
                pItem.SubItems.Add(oSeriesCollection.Item(i).PeriodIndicator)

            Next

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    'initiate the series service
    Private Sub InitService()

        oCmpSrv = oCompany.GetCompanyService

        'get series service

        oSeriesService = oCmpSrv.GetBusinessService(ServiceTypes.SeriesService)

    End Sub

    Private Sub cmdAddSeries_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddSeries.Click

        Dim frm As New AddSeriesForm

        frm.ShowDialog()
      
    End Sub

End Class


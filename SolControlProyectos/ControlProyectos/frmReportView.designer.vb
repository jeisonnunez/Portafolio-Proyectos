<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportView
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.p_Carteratotalc_sReciboBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dtSp = New ControlProyectos.dtSp
        Me.p_EstimacionCobrosxSectorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.p_EstimacionCobrosxtramitesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PEstimacionCobrosxtramitesAllBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.rpvReport = New Microsoft.Reporting.WinForms.ReportViewer
        Me.rpvReport1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.rpvReport2 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.rpvReport3 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.rpvReport4 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.PCarteratotalcsRsReciboResBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.p_Carteratotalc_sR_sRecibo_ResBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PCarteratotalcsReciboBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.p_EstimacionCobrosxSectorGobBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PEstimacionCobrosxSectorGobBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PEstimacionCobrosxSectorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PCarteratotalcsReciboBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.P_Carteratotalc_sReciboTableAdapter = New ControlProyectos.dtSpTableAdapters.p_Carteratotalc_sReciboTableAdapter
        Me.P_EstimacionCobrosxSectorTableAdapter = New ControlProyectos.dtSpTableAdapters.p_EstimacionCobrosxSectorTableAdapter
        Me.P_EstimacionCobrosxSectorGobTableAdapter = New ControlProyectos.dtSpTableAdapters.p_EstimacionCobrosxSectorGobTableAdapter
        Me.PEstimacionCobrosxtramitesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.P_EstimacionCobrosxtramitesTableAdapter = New ControlProyectos.dtSpTableAdapters.p_EstimacionCobrosxtramitesTableAdapter
        Me.P_Carteratotalc_sR_sRecibo_ResTableAdapter = New ControlProyectos.dtSpTableAdapters.p_Carteratotalc_sR_sRecibo_ResTableAdapter
        Me.p_EstimacionCobrosxtramites_AllBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.P_EstimacionCobrosxtramites_AllTableAdapter = New ControlProyectos.dtSpTableAdapters.p_EstimacionCobrosxtramites_AllTableAdapter
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.p_Carteratotalc_sReciboBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtSp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p_EstimacionCobrosxSectorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p_EstimacionCobrosxtramitesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PEstimacionCobrosxtramitesAllBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCarteratotalcsRsReciboResBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p_Carteratotalc_sR_sRecibo_ResBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCarteratotalcsReciboBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p_EstimacionCobrosxSectorGobBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PEstimacionCobrosxSectorGobBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PEstimacionCobrosxSectorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCarteratotalcsReciboBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PEstimacionCobrosxtramitesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p_EstimacionCobrosxtramites_AllBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'p_Carteratotalc_sReciboBindingSource
        '
        Me.p_Carteratotalc_sReciboBindingSource.DataMember = "p_Carteratotalc_sRecibo"
        Me.p_Carteratotalc_sReciboBindingSource.DataSource = Me.dtSp
        '
        'dtSp
        '
        Me.dtSp.DataSetName = "dtSp"
        Me.dtSp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'p_EstimacionCobrosxSectorBindingSource
        '
        Me.p_EstimacionCobrosxSectorBindingSource.DataMember = "p_EstimacionCobrosxSector"
        Me.p_EstimacionCobrosxSectorBindingSource.DataSource = Me.dtSp
        '
        'p_EstimacionCobrosxtramitesBindingSource
        '
        Me.p_EstimacionCobrosxtramitesBindingSource.DataMember = "p_EstimacionCobrosxtramites"
        Me.p_EstimacionCobrosxtramitesBindingSource.DataSource = Me.dtSp
        '
        'PEstimacionCobrosxtramitesAllBindingSource
        '
        Me.PEstimacionCobrosxtramitesAllBindingSource.DataMember = "p_EstimacionCobrosxtramites_All"
        Me.PEstimacionCobrosxtramitesAllBindingSource.DataSource = Me.dtSp
        '
        'rpvReport
        '
        Me.rpvReport.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dtSp_p_Carteratotalc_sRecibo"
        ReportDataSource1.Value = Me.p_Carteratotalc_sReciboBindingSource
        Me.rpvReport.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rpvReport.LocalReport.ReportEmbeddedResource = "ControlProyectos.rptCarteraTotal.rdlc"
        Me.rpvReport.Location = New System.Drawing.Point(0, 0)
        Me.rpvReport.Name = "rpvReport"
        Me.rpvReport.ShowPrintButton = False
        Me.rpvReport.Size = New System.Drawing.Size(1028, 701)
        Me.rpvReport.TabIndex = 0
        Me.rpvReport.ZoomPercent = 80
        '
        'rpvReport1
        '
        Me.rpvReport1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "dtSp_p_EstimacionCobrosxSector"
        ReportDataSource2.Value = Me.p_EstimacionCobrosxSectorBindingSource
        Me.rpvReport1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.rpvReport1.LocalReport.ReportEmbeddedResource = "ControlProyectos.rpt_ResumenEcxc.rdlc"
        Me.rpvReport1.Location = New System.Drawing.Point(0, 0)
        Me.rpvReport1.Name = "rpvReport1"
        Me.rpvReport1.ShowPrintButton = False
        Me.rpvReport1.Size = New System.Drawing.Size(1028, 701)
        Me.rpvReport1.TabIndex = 1
        Me.rpvReport1.ZoomPercent = 80
        '
        'rpvReport2
        '
        Me.rpvReport2.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource3.Name = "dtSp_p_EstimacionCobrosxtramites"
        ReportDataSource3.Value = Me.p_EstimacionCobrosxtramitesBindingSource
        Me.rpvReport2.LocalReport.DataSources.Add(ReportDataSource3)
        Me.rpvReport2.LocalReport.ReportEmbeddedResource = "ControlProyectos.Report4.rdlc"
        Me.rpvReport2.Location = New System.Drawing.Point(0, 0)
        Me.rpvReport2.Name = "rpvReport2"
        Me.rpvReport2.ShowPrintButton = False
        Me.rpvReport2.Size = New System.Drawing.Size(1028, 701)
        Me.rpvReport2.TabIndex = 2
        Me.rpvReport2.ZoomPercent = 80
        '
        'rpvReport3
        '
        Me.rpvReport3.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource4.Name = "dtSp_p_EstimacionCobrosxtramites"
        ReportDataSource4.Value = Me.p_EstimacionCobrosxtramitesBindingSource
        Me.rpvReport3.LocalReport.DataSources.Add(ReportDataSource4)
        Me.rpvReport3.LocalReport.ReportEmbeddedResource = "ControlProyectos.Report4.rdlc"
        Me.rpvReport3.Location = New System.Drawing.Point(0, 0)
        Me.rpvReport3.Name = "rpvReport3"
        Me.rpvReport3.ShowPrintButton = False
        Me.rpvReport3.Size = New System.Drawing.Size(1028, 701)
        Me.rpvReport3.TabIndex = 3
        Me.rpvReport3.ZoomPercent = 80
        '
        'rpvReport4
        '
        Me.rpvReport4.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource5.Name = "dtSp_p_EstimacionCobrosxtramites_All"
        ReportDataSource5.Value = Me.PEstimacionCobrosxtramitesAllBindingSource
        Me.rpvReport4.LocalReport.DataSources.Add(ReportDataSource5)
        Me.rpvReport4.LocalReport.ReportEmbeddedResource = "ControlProyectos.rptConsolidado.rdlc"
        Me.rpvReport4.Location = New System.Drawing.Point(0, 0)
        Me.rpvReport4.Name = "rpvReport4"
        Me.rpvReport4.ShowPrintButton = False
        Me.rpvReport4.Size = New System.Drawing.Size(1028, 701)
        Me.rpvReport4.TabIndex = 4
        Me.rpvReport4.ZoomPercent = 80
        '
        'PCarteratotalcsRsReciboResBindingSource
        '
        Me.PCarteratotalcsRsReciboResBindingSource.DataMember = "p_Carteratotalc_sR_sRecibo_Res"
        Me.PCarteratotalcsRsReciboResBindingSource.DataSource = Me.dtSp
        '
        'p_Carteratotalc_sR_sRecibo_ResBindingSource
        '
        Me.p_Carteratotalc_sR_sRecibo_ResBindingSource.DataMember = "p_Carteratotalc_sR_sRecibo_Res"
        Me.p_Carteratotalc_sR_sRecibo_ResBindingSource.DataSource = Me.dtSp
        '
        'PCarteratotalcsReciboBindingSource1
        '
        Me.PCarteratotalcsReciboBindingSource1.DataMember = "p_Carteratotalc_sRecibo"
        Me.PCarteratotalcsReciboBindingSource1.DataSource = Me.dtSp
        '
        'p_EstimacionCobrosxSectorGobBindingSource
        '
        Me.p_EstimacionCobrosxSectorGobBindingSource.DataMember = "p_EstimacionCobrosxSectorGob"
        Me.p_EstimacionCobrosxSectorGobBindingSource.DataSource = Me.dtSp
        '
        'PEstimacionCobrosxSectorGobBindingSource
        '
        Me.PEstimacionCobrosxSectorGobBindingSource.DataMember = "p_EstimacionCobrosxSectorGob"
        Me.PEstimacionCobrosxSectorGobBindingSource.DataSource = Me.dtSp
        '
        'PEstimacionCobrosxSectorBindingSource
        '
        Me.PEstimacionCobrosxSectorBindingSource.DataMember = "p_EstimacionCobrosxSector"
        Me.PEstimacionCobrosxSectorBindingSource.DataSource = Me.dtSp
        '
        'PCarteratotalcsReciboBindingSource
        '
        Me.PCarteratotalcsReciboBindingSource.DataMember = "p_Carteratotalc_sRecibo"
        Me.PCarteratotalcsReciboBindingSource.DataSource = Me.dtSp
        '
        'P_Carteratotalc_sReciboTableAdapter
        '
        Me.P_Carteratotalc_sReciboTableAdapter.ClearBeforeFill = True
        '
        'P_EstimacionCobrosxSectorTableAdapter
        '
        Me.P_EstimacionCobrosxSectorTableAdapter.ClearBeforeFill = True
        '
        'P_EstimacionCobrosxSectorGobTableAdapter
        '
        Me.P_EstimacionCobrosxSectorGobTableAdapter.ClearBeforeFill = True
        '
        'PEstimacionCobrosxtramitesBindingSource
        '
        Me.PEstimacionCobrosxtramitesBindingSource.DataMember = "p_EstimacionCobrosxtramites"
        Me.PEstimacionCobrosxtramitesBindingSource.DataSource = Me.dtSp
        '
        'P_EstimacionCobrosxtramitesTableAdapter
        '
        Me.P_EstimacionCobrosxtramitesTableAdapter.ClearBeforeFill = True
        '
        'P_Carteratotalc_sR_sRecibo_ResTableAdapter
        '
        Me.P_Carteratotalc_sR_sRecibo_ResTableAdapter.ClearBeforeFill = True
        '
        'p_EstimacionCobrosxtramites_AllBindingSource
        '
        Me.p_EstimacionCobrosxtramites_AllBindingSource.DataMember = "p_EstimacionCobrosxtramites_All"
        Me.p_EstimacionCobrosxtramites_AllBindingSource.DataSource = Me.dtSp
        '
        'P_EstimacionCobrosxtramites_AllTableAdapter
        '
        Me.P_EstimacionCobrosxtramites_AllTableAdapter.ClearBeforeFill = True
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "p_EstimacionCobrosxtramites_Resumen"
        Me.BindingSource1.DataSource = Me.dtSp
        '
        'frmReportView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 701)
        Me.Controls.Add(Me.rpvReport4)
        Me.Controls.Add(Me.rpvReport3)
        Me.Controls.Add(Me.rpvReport2)
        Me.Controls.Add(Me.rpvReport1)
        Me.Controls.Add(Me.rpvReport)
        Me.Name = "frmReportView"
        Me.Text = "Reportes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.p_Carteratotalc_sReciboBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtSp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p_EstimacionCobrosxSectorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p_EstimacionCobrosxtramitesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PEstimacionCobrosxtramitesAllBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCarteratotalcsRsReciboResBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p_Carteratotalc_sR_sRecibo_ResBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCarteratotalcsReciboBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p_EstimacionCobrosxSectorGobBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PEstimacionCobrosxSectorGobBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PEstimacionCobrosxSectorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCarteratotalcsReciboBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PEstimacionCobrosxtramitesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p_EstimacionCobrosxtramites_AllBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtSp As ControlProyectos.dtSp
    Friend WithEvents PCarteratotalcsReciboBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PCarteratotalcsReciboBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents P_Carteratotalc_sReciboTableAdapter As ControlProyectos.dtSpTableAdapters.p_Carteratotalc_sReciboTableAdapter
    Friend WithEvents p_Carteratotalc_sReciboBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PEstimacionCobrosxSectorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents P_EstimacionCobrosxSectorTableAdapter As ControlProyectos.dtSpTableAdapters.p_EstimacionCobrosxSectorTableAdapter
    Friend WithEvents p_EstimacionCobrosxSectorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents p_EstimacionCobrosxSectorGobBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PEstimacionCobrosxSectorGobBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents P_EstimacionCobrosxSectorGobTableAdapter As ControlProyectos.dtSpTableAdapters.p_EstimacionCobrosxSectorGobTableAdapter
    Friend WithEvents p_EstimacionCobrosxtramitesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PEstimacionCobrosxtramitesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents P_EstimacionCobrosxtramitesTableAdapter As ControlProyectos.dtSpTableAdapters.p_EstimacionCobrosxtramitesTableAdapter
    Friend WithEvents PCarteratotalcsRsReciboResBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents P_Carteratotalc_sR_sRecibo_ResTableAdapter As ControlProyectos.dtSpTableAdapters.p_Carteratotalc_sR_sRecibo_ResTableAdapter
    Friend WithEvents p_Carteratotalc_sR_sRecibo_ResBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents p_EstimacionCobrosxtramites_AllBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PEstimacionCobrosxtramitesAllBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents P_EstimacionCobrosxtramites_AllTableAdapter As ControlProyectos.dtSpTableAdapters.p_EstimacionCobrosxtramites_AllTableAdapter
    Private WithEvents rpvReport As Microsoft.Reporting.WinForms.ReportViewer
    Private WithEvents rpvReport1 As Microsoft.Reporting.WinForms.ReportViewer
    Private WithEvents rpvReport2 As Microsoft.Reporting.WinForms.ReportViewer
    Private WithEvents rpvReport3 As Microsoft.Reporting.WinForms.ReportViewer
    Private WithEvents rpvReport4 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
End Class

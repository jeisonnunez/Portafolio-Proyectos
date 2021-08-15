<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportResum
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
        Me.p_EstimacionCobrosxtramites_ResumenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DtSp = New ControlProyectos.dtSp
        Me.dtHistoricoProyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dtHistoricoProy = New ControlProyectos.dtHistoricoProy
        Me.rpvReport1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.PEstimacionCobrosxtramitesResumenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.P_EstimacionCobrosxtramites_ResumenTableAdapter = New ControlProyectos.dtSpTableAdapters.p_EstimacionCobrosxtramites_ResumenTableAdapter
        Me.dtHistoricoProyTableAdapter = New ControlProyectos.dtHistoricoProyTableAdapters.dtHistoricoProyTableAdapter
        Me.rpvReport2 = New Microsoft.Reporting.WinForms.ReportViewer
        CType(Me.p_EstimacionCobrosxtramites_ResumenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtSp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtHistoricoProyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtHistoricoProy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PEstimacionCobrosxtramitesResumenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'p_EstimacionCobrosxtramites_ResumenBindingSource
        '
        Me.p_EstimacionCobrosxtramites_ResumenBindingSource.DataMember = "p_EstimacionCobrosxtramites_Resumen"
        Me.p_EstimacionCobrosxtramites_ResumenBindingSource.DataSource = Me.DtSp
        '
        'DtSp
        '
        Me.DtSp.DataSetName = "dtSp"
        Me.DtSp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtHistoricoProyBindingSource
        '
        Me.dtHistoricoProyBindingSource.DataMember = "dtHistoricoProy"
        Me.dtHistoricoProyBindingSource.DataSource = Me.dtHistoricoProy
        '
        'dtHistoricoProy
        '
        Me.dtHistoricoProy.DataSetName = "dtHistoricoProy"
        Me.dtHistoricoProy.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rpvReport1
        '
        Me.rpvReport1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dtSp_p_EstimacionCobrosxtramites_Resumen"
        ReportDataSource1.Value = Me.p_EstimacionCobrosxtramites_ResumenBindingSource
        Me.rpvReport1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rpvReport1.LocalReport.ReportEmbeddedResource = ""
        Me.rpvReport1.Location = New System.Drawing.Point(0, 0)
        Me.rpvReport1.Name = "rpvReport1"
        Me.rpvReport1.Size = New System.Drawing.Size(782, 499)
        Me.rpvReport1.TabIndex = 0
        Me.rpvReport1.Visible = False
        '
        'PEstimacionCobrosxtramitesResumenBindingSource
        '
        Me.PEstimacionCobrosxtramitesResumenBindingSource.DataMember = "p_EstimacionCobrosxtramites_Resumen"
        Me.PEstimacionCobrosxtramitesResumenBindingSource.DataSource = Me.DtSp
        '
        'P_EstimacionCobrosxtramites_ResumenTableAdapter
        '
        Me.P_EstimacionCobrosxtramites_ResumenTableAdapter.ClearBeforeFill = True
        '
        'dtHistoricoProyTableAdapter
        '
        Me.dtHistoricoProyTableAdapter.ClearBeforeFill = True
        '
        'rpvReport2
        '
        Me.rpvReport2.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "dtHistoricoProy_dtHistoricoProy"
        ReportDataSource2.Value = Me.dtHistoricoProyBindingSource
        Me.rpvReport2.LocalReport.DataSources.Add(ReportDataSource2)
        Me.rpvReport2.LocalReport.ReportEmbeddedResource = "ControlProyectos.rptProyectosHistoricos.rdlc"
        Me.rpvReport2.Location = New System.Drawing.Point(0, 0)
        Me.rpvReport2.Name = "rpvReport2"
        Me.rpvReport2.Size = New System.Drawing.Size(782, 499)
        Me.rpvReport2.TabIndex = 1
        Me.rpvReport2.Visible = False
        '
        'frmReportResum
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 499)
        Me.Controls.Add(Me.rpvReport2)
        Me.Controls.Add(Me.rpvReport1)
        Me.Name = "frmReportResum"
        Me.Text = "Reportes"
        CType(Me.p_EstimacionCobrosxtramites_ResumenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtSp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtHistoricoProyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtHistoricoProy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PEstimacionCobrosxtramitesResumenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PEstimacionCobrosxtramitesResumenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DtSp As ControlProyectos.dtSp
    Friend WithEvents P_EstimacionCobrosxtramites_ResumenTableAdapter As ControlProyectos.dtSpTableAdapters.p_EstimacionCobrosxtramites_ResumenTableAdapter
    Friend WithEvents p_EstimacionCobrosxtramites_ResumenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dtHistoricoProyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dtHistoricoProy As ControlProyectos.dtHistoricoProy
    Friend WithEvents dtHistoricoProyTableAdapter As ControlProyectos.dtHistoricoProyTableAdapters.dtHistoricoProyTableAdapter
    Private WithEvents rpvReport1 As Microsoft.Reporting.WinForms.ReportViewer
    Private WithEvents rpvReport2 As Microsoft.Reporting.WinForms.ReportViewer
End Class

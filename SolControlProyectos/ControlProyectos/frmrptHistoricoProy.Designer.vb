<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmrptHistoricoProy
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
        Me.dtHistoricoProy = New ControlProyectos.dtHistoricoProy
        Me.DtHistoricoProyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DtHistoricoProyTableAdapter = New ControlProyectos.dtHistoricoProyTableAdapters.dtHistoricoProyTableAdapter
        Me.rpvView = New Microsoft.Reporting.WinForms.ReportViewer
        CType(Me.dtHistoricoProy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtHistoricoProyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtHistoricoProy
        '
        Me.dtHistoricoProy.DataSetName = "dtHistoricoProy"
        Me.dtHistoricoProy.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DtHistoricoProyBindingSource
        '
        Me.DtHistoricoProyBindingSource.DataMember = "dtHistoricoProy"
        Me.DtHistoricoProyBindingSource.DataSource = Me.dtHistoricoProy
        '
        'DtHistoricoProyTableAdapter
        '
        Me.DtHistoricoProyTableAdapter.ClearBeforeFill = True
        '
        'rpvView
        '
        Me.rpvView.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dtHistoricoProy_dtHistoricoProy"
        ReportDataSource1.Value = Me.DtHistoricoProyBindingSource
        Me.rpvView.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rpvView.LocalReport.ReportEmbeddedResource = "ControlProyectos.rptProyectosHistoricos.rdlc"
        Me.rpvView.Location = New System.Drawing.Point(0, 0)
        Me.rpvView.Name = "rpvView"
        Me.rpvView.Size = New System.Drawing.Size(762, 466)
        Me.rpvView.TabIndex = 0
        '
        'frmrptHistoricoProy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 466)
        Me.Controls.Add(Me.rpvView)
        Me.Name = "frmrptHistoricoProy"
        Me.Text = "frmrptHistoricoProy"
        CType(Me.dtHistoricoProy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtHistoricoProyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtHistoricoProy As ControlProyectos.dtHistoricoProy
    Friend WithEvents DtHistoricoProyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DtHistoricoProyTableAdapter As ControlProyectos.dtHistoricoProyTableAdapters.dtHistoricoProyTableAdapter
    Friend WithEvents rpvView As Microsoft.Reporting.WinForms.ReportViewer
End Class

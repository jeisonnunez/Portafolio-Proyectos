<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFacturasResumen
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.ltwFactRes = New System.Windows.Forms.ListView
        Me.chlNroP = New System.Windows.Forms.ColumnHeader
        Me.chlNroCont = New System.Windows.Forms.ColumnHeader
        Me.chlNroFact = New System.Windows.Forms.ColumnHeader
        Me.chlfecFact = New System.Windows.Forms.ColumnHeader
        Me.chlTrabReal = New System.Windows.Forms.ColumnHeader
        Me.chlCuentaxCobrar = New System.Windows.Forms.ColumnHeader
        Me.chlPagos = New System.Windows.Forms.ColumnHeader
        Me.chlTotal = New System.Windows.Forms.ColumnHeader
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.chret = New System.Windows.Forms.ColumnHeader
        Me.chDescAnt = New System.Windows.Forms.ColumnHeader
        Me.ChITBMS = New System.Windows.Forms.ColumnHeader
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ltwFactRes)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnCerrar)
        Me.SplitContainer1.Size = New System.Drawing.Size(1189, 686)
        Me.SplitContainer1.SplitterDistance = 634
        Me.SplitContainer1.TabIndex = 0
        '
        'ltwFactRes
        '
        Me.ltwFactRes.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ltwFactRes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chlNroP, Me.chlNroCont, Me.chlNroFact, Me.chlfecFact, Me.chlTrabReal, Me.chret, Me.chDescAnt, Me.ChITBMS, Me.chlCuentaxCobrar, Me.chlPagos, Me.chlTotal})
        Me.ltwFactRes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ltwFactRes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ltwFactRes.FullRowSelect = True
        Me.ltwFactRes.Location = New System.Drawing.Point(0, 0)
        Me.ltwFactRes.Name = "ltwFactRes"
        Me.ltwFactRes.Size = New System.Drawing.Size(1189, 634)
        Me.ltwFactRes.TabIndex = 0
        Me.ltwFactRes.UseCompatibleStateImageBehavior = False
        Me.ltwFactRes.View = System.Windows.Forms.View.Details
        '
        'chlNroP
        '
        Me.chlNroP.Text = "NroProy"
        Me.chlNroP.Width = 117
        '
        'chlNroCont
        '
        Me.chlNroCont.Text = "Nro. Contrato"
        Me.chlNroCont.Width = 126
        '
        'chlNroFact
        '
        Me.chlNroFact.Text = "Nro. Factura"
        Me.chlNroFact.Width = 103
        '
        'chlfecFact
        '
        Me.chlfecFact.Text = "Fecha"
        Me.chlfecFact.Width = 95
        '
        'chlTrabReal
        '
        Me.chlTrabReal.Text = "Trabajo Realizado"
        Me.chlTrabReal.Width = 129
        '
        'chlCuentaxCobrar
        '
        Me.chlCuentaxCobrar.Text = "CuentaxCobrar"
        Me.chlCuentaxCobrar.Width = 114
        '
        'chlPagos
        '
        Me.chlPagos.Text = "Pagos"
        Me.chlPagos.Width = 96
        '
        'chlTotal
        '
        Me.chlTotal.Text = "Saldo"
        Me.chlTotal.Width = 104
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Location = New System.Drawing.Point(1102, 13)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'chret
        '
        Me.chret.Text = "% Retencion"
        Me.chret.Width = 98
        '
        'chDescAnt
        '
        Me.chDescAnt.Text = "Desc. Anticipo"
        Me.chDescAnt.Width = 105
        '
        'ChITBMS
        '
        Me.ChITBMS.Text = "ITBMS"
        Me.ChITBMS.Width = 95
        '
        'frmFacturasResumen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1189, 686)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmFacturasResumen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RELACIÓN FACTURAS - PROYECTOS"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ltwFactRes As System.Windows.Forms.ListView
    Friend WithEvents chlNroP As System.Windows.Forms.ColumnHeader
    Friend WithEvents chlNroCont As System.Windows.Forms.ColumnHeader
    Friend WithEvents chlNroFact As System.Windows.Forms.ColumnHeader
    Friend WithEvents chlTrabReal As System.Windows.Forms.ColumnHeader
    Friend WithEvents chlCuentaxCobrar As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents chlPagos As System.Windows.Forms.ColumnHeader
    Friend WithEvents chlfecFact As System.Windows.Forms.ColumnHeader
    Friend WithEvents chlTotal As System.Windows.Forms.ColumnHeader
    Friend WithEvents chret As System.Windows.Forms.ColumnHeader
    Friend WithEvents chDescAnt As System.Windows.Forms.ColumnHeader
    Friend WithEvents ChITBMS As System.Windows.Forms.ColumnHeader
End Class

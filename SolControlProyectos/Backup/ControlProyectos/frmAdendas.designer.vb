<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdendas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdendas))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton12 = New System.Windows.Forms.ToolStripButton
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.ltwAdendas = New System.Windows.Forms.ListView
        Me.chtipoAd = New System.Windows.Forms.ColumnHeader
        Me.chlCuenta = New System.Windows.Forms.ColumnHeader
        Me.chlNroP = New System.Windows.Forms.ColumnHeader
        Me.chlNroCont = New System.Windows.Forms.ColumnHeader
        Me.chFecha = New System.Windows.Forms.ColumnHeader
        Me.chlMonto = New System.Windows.Forms.ColumnHeader
        Me.ChtAdf = New System.Windows.Forms.ColumnHeader
        Me.chObs = New System.Windows.Forms.ColumnHeader
        Me.chFin = New System.Windows.Forms.ColumnHeader
        Me.chlTM = New System.Windows.Forms.ColumnHeader
        Me.chlId = New System.Windows.Forms.ColumnHeader
        Me.CmsAd = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToolStrip1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ltwAdendas)
        Me.SplitContainer1.Size = New System.Drawing.Size(1380, 618)
        Me.SplitContainer1.SplitterDistance = 42
        Me.SplitContainer1.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ToolStripButton2, Me.ToolStripSeparator3, Me.ToolStripButton3, Me.ToolStripSeparator4, Me.ToolStripButton4, Me.ToolStripSeparator5, Me.ToolStripButton12, Me.toolStripSeparator})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1380, 25)
        Me.ToolStrip1.TabIndex = 180
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Guardar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Incluir"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Editar"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Eliminar"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton12
        '
        Me.ToolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton12.Image = CType(resources.GetObject("ToolStripButton12.Image"), System.Drawing.Image)
        Me.ToolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton12.Name = "ToolStripButton12"
        Me.ToolStripButton12.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton12.Tag = "Cerrar Formulario"
        Me.ToolStripButton12.Text = "Cerrar"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'ltwAdendas
        '
        Me.ltwAdendas.AllowColumnReorder = True
        Me.ltwAdendas.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ltwAdendas.CheckBoxes = True
        Me.ltwAdendas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chtipoAd, Me.chlCuenta, Me.chlNroP, Me.chlNroCont, Me.chFecha, Me.chlMonto, Me.ChtAdf, Me.chObs, Me.chFin, Me.chlTM, Me.chlId})
        Me.ltwAdendas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ltwAdendas.FullRowSelect = True
        Me.ltwAdendas.GridLines = True
        Me.ltwAdendas.Location = New System.Drawing.Point(0, 0)
        Me.ltwAdendas.Name = "ltwAdendas"
        Me.ltwAdendas.Size = New System.Drawing.Size(1380, 572)
        Me.ltwAdendas.TabIndex = 1
        Me.ltwAdendas.UseCompatibleStateImageBehavior = False
        Me.ltwAdendas.View = System.Windows.Forms.View.Details
        '
        'chtipoAd
        '
        Me.chtipoAd.Text = "tipoAd"
        Me.chtipoAd.Width = 0
        '
        'chlCuenta
        '
        Me.chlCuenta.Text = "Nro Adendas"
        Me.chlCuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chlCuenta.Width = 118
        '
        'chlNroP
        '
        Me.chlNroP.Text = "NroProy"
        Me.chlNroP.Width = 199
        '
        'chlNroCont
        '
        Me.chlNroCont.Text = "Nro. Contrato"
        Me.chlNroCont.Width = 179
        '
        'chFecha
        '
        Me.chFecha.Text = "Fecha"
        Me.chFecha.Width = 148
        '
        'chlMonto
        '
        Me.chlMonto.Text = "Monto"
        Me.chlMonto.Width = 170
        '
        'ChtAdf
        '
        Me.ChtAdf.Text = "Tiempo"
        Me.ChtAdf.Width = 108
        '
        'chObs
        '
        Me.chObs.Text = "Observación"
        Me.chObs.Width = 500
        '
        'chFin
        '
        Me.chFin.Text = "adFinanc."
        Me.chFin.Width = 0
        '
        'chlTM
        '
        Me.chlTM.Text = "pro_tipoAdendas"
        Me.chlTM.Width = 0
        '
        'chlId
        '
        Me.chlId.Text = "idAdendas"
        Me.chlId.Width = 0
        '
        'CmsAd
        '
        Me.CmsAd.Name = "CmsAd"
        Me.CmsAd.Size = New System.Drawing.Size(61, 4)
        '
        'frmAdendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1380, 618)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmAdendas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADENDAS (PROYECTOS)"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton12 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ltwAdendas As System.Windows.Forms.ListView
    Friend WithEvents chlNroP As System.Windows.Forms.ColumnHeader
    Friend WithEvents chlNroCont As System.Windows.Forms.ColumnHeader
    Friend WithEvents chlCuenta As System.Windows.Forms.ColumnHeader
    Friend WithEvents chlMonto As System.Windows.Forms.ColumnHeader
    Friend WithEvents chFecha As System.Windows.Forms.ColumnHeader
    Friend WithEvents chObs As System.Windows.Forms.ColumnHeader
    Friend WithEvents chtipoAd As System.Windows.Forms.ColumnHeader
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents chFin As System.Windows.Forms.ColumnHeader
    Friend WithEvents ChtAdf As System.Windows.Forms.ColumnHeader
    Friend WithEvents chlTM As System.Windows.Forms.ColumnHeader
    Friend WithEvents chlId As System.Windows.Forms.ColumnHeader
    Friend WithEvents CmsAd As System.Windows.Forms.ContextMenuStrip
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_manttbBasiscas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_manttbBasiscas))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton12 = New System.Windows.Forms.ToolStripButton
        Me.cmbTablas = New System.Windows.Forms.ComboBox
        Me.TabSistemasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TablasSistemas = New ControlProyectos.tablasSistemas
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ltvBasicas = New System.Windows.Forms.ListView
        Me.chlDato = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AgregarDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EliminarDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificarDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Tab_SistemasTableAdapter = New ControlProyectos.tablasSistemasTableAdapters.tab_SistemasTableAdapter
        Me.ToolStrip1.SuspendLayout()
        CType(Me.TabSistemasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TablasSistemas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator6, Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ToolStripButton2, Me.ToolStripSeparator3, Me.ToolStripButton3, Me.ToolStripSeparator4, Me.ToolStripButton4, Me.ToolStripSeparator5, Me.ToolStripButton12})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(391, 25)
        Me.ToolStrip1.TabIndex = 174
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
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
        Me.ToolStripButton4.Enabled = False
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
        'cmbTablas
        '
        Me.cmbTablas.DataSource = Me.TabSistemasBindingSource
        Me.cmbTablas.DisplayMember = "desc_Tabla"
        Me.cmbTablas.FormattingEnabled = True
        Me.cmbTablas.Location = New System.Drawing.Point(18, 39)
        Me.cmbTablas.Name = "cmbTablas"
        Me.cmbTablas.Size = New System.Drawing.Size(322, 21)
        Me.cmbTablas.TabIndex = 175
        Me.cmbTablas.ValueMember = "tablareal"
        '
        'TabSistemasBindingSource
        '
        Me.TabSistemasBindingSource.DataMember = "tab_Sistemas"
        Me.TabSistemasBindingSource.DataSource = Me.TablasSistemas
        '
        'TablasSistemas
        '
        Me.TablasSistemas.DataSetName = "tablasSistemas"
        Me.TablasSistemas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 176
        Me.Label1.Text = "Seleccione la Tabla"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbTablas)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(369, 89)
        Me.GroupBox1.TabIndex = 177
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tablas Sistemas"
        '
        'ltvBasicas
        '
        Me.ltvBasicas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chlDato, Me.ColumnHeader1})
        Me.ltvBasicas.Location = New System.Drawing.Point(0, 0)
        Me.ltvBasicas.Name = "ltvBasicas"
        Me.ltvBasicas.Size = New System.Drawing.Size(391, 365)
        Me.ltvBasicas.TabIndex = 177
        Me.ltvBasicas.UseCompatibleStateImageBehavior = False
        Me.ltvBasicas.View = System.Windows.Forms.View.Details
        '
        'chlDato
        '
        Me.chlDato.Text = "Descripción"
        Me.chlDato.Width = 415
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ltvBasicas)
        Me.SplitContainer1.Size = New System.Drawing.Size(391, 492)
        Me.SplitContainer1.SplitterDistance = 123
        Me.SplitContainer1.TabIndex = 178
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarDatosToolStripMenuItem, Me.EliminarDatosToolStripMenuItem, Me.ModificarDatosToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(159, 70)
        '
        'AgregarDatosToolStripMenuItem
        '
        Me.AgregarDatosToolStripMenuItem.Name = "AgregarDatosToolStripMenuItem"
        Me.AgregarDatosToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.AgregarDatosToolStripMenuItem.Text = "Agregar Datos"
        '
        'EliminarDatosToolStripMenuItem
        '
        Me.EliminarDatosToolStripMenuItem.Name = "EliminarDatosToolStripMenuItem"
        Me.EliminarDatosToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.EliminarDatosToolStripMenuItem.Text = "Eliminar Datos"
        '
        'ModificarDatosToolStripMenuItem
        '
        Me.ModificarDatosToolStripMenuItem.Name = "ModificarDatosToolStripMenuItem"
        Me.ModificarDatosToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.ModificarDatosToolStripMenuItem.Text = "Modificar Datos"
        '
        'Tab_SistemasTableAdapter
        '
        Me.Tab_SistemasTableAdapter.ClearBeforeFill = True
        '
        'frm_manttbBasiscas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(391, 517)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_manttbBasiscas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tablas Básicas"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.TabSistemasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TablasSistemas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton12 As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbTablas As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ltvBasicas As System.Windows.Forms.ListView
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents chlDato As System.Windows.Forms.ColumnHeader
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AgregarDatosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarDatosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarDatosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TablasSistemas As ControlProyectos.tablasSistemas
    Friend WithEvents TabSistemasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tab_SistemasTableAdapter As ControlProyectos.tablasSistemasTableAdapters.tab_SistemasTableAdapter
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
End Class

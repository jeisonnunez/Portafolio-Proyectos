<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportacionContratista
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImportacionContratista))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.gbpCont = New System.Windows.Forms.GroupBox
        Me.cmb71 = New System.Windows.Forms.ComboBox
        Me.chk71 = New System.Windows.Forms.CheckBox
        Me.cmb65 = New System.Windows.Forms.ComboBox
        Me.cmb66 = New System.Windows.Forms.ComboBox
        Me.cmb67 = New System.Windows.Forms.ComboBox
        Me.cmb68 = New System.Windows.Forms.ComboBox
        Me.cmb70 = New System.Windows.Forms.ComboBox
        Me.cmb69 = New System.Windows.Forms.ComboBox
        Me.cmb64 = New System.Windows.Forms.ComboBox
        Me.chk70 = New System.Windows.Forms.CheckBox
        Me.chk69 = New System.Windows.Forms.CheckBox
        Me.chk68 = New System.Windows.Forms.CheckBox
        Me.chk67 = New System.Windows.Forms.CheckBox
        Me.chk66 = New System.Windows.Forms.CheckBox
        Me.chk65 = New System.Windows.Forms.CheckBox
        Me.chk64 = New System.Windows.Forms.CheckBox
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton
        Me.gpbDres = New System.Windows.Forms.DataGridView
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.gbpCont.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.gpbDres, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.gbpCont)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(941, 541)
        Me.SplitContainer1.SplitterDistance = 244
        Me.SplitContainer1.TabIndex = 0
        '
        'gbpCont
        '
        Me.gbpCont.Controls.Add(Me.cmb71)
        Me.gbpCont.Controls.Add(Me.chk71)
        Me.gbpCont.Controls.Add(Me.cmb65)
        Me.gbpCont.Controls.Add(Me.cmb66)
        Me.gbpCont.Controls.Add(Me.cmb67)
        Me.gbpCont.Controls.Add(Me.cmb68)
        Me.gbpCont.Controls.Add(Me.cmb70)
        Me.gbpCont.Controls.Add(Me.cmb69)
        Me.gbpCont.Controls.Add(Me.cmb64)
        Me.gbpCont.Controls.Add(Me.chk70)
        Me.gbpCont.Controls.Add(Me.chk69)
        Me.gbpCont.Controls.Add(Me.chk68)
        Me.gbpCont.Controls.Add(Me.chk67)
        Me.gbpCont.Controls.Add(Me.chk66)
        Me.gbpCont.Controls.Add(Me.chk65)
        Me.gbpCont.Controls.Add(Me.chk64)
        Me.gbpCont.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbpCont.Location = New System.Drawing.Point(12, 29)
        Me.gbpCont.Name = "gbpCont"
        Me.gbpCont.Size = New System.Drawing.Size(229, 209)
        Me.gbpCont.TabIndex = 148
        Me.gbpCont.TabStop = False
        Me.gbpCont.Text = "Datos Contratistas"
        '
        'cmb71
        '
        Me.cmb71.Enabled = False
        Me.cmb71.Font = New System.Drawing.Font("Cambria", 8.0!)
        Me.cmb71.FormattingEnabled = True
        Me.cmb71.Location = New System.Drawing.Point(121, 179)
        Me.cmb71.Name = "cmb71"
        Me.cmb71.Size = New System.Drawing.Size(89, 20)
        Me.cmb71.TabIndex = 173
        '
        'chk71
        '
        Me.chk71.AutoSize = True
        Me.chk71.ForeColor = System.Drawing.Color.Black
        Me.chk71.Location = New System.Drawing.Point(5, 179)
        Me.chk71.Name = "chk71"
        Me.chk71.Size = New System.Drawing.Size(87, 18)
        Me.chk71.TabIndex = 172
        Me.chk71.Text = "Ruta Server"
        Me.chk71.UseVisualStyleBackColor = True
        '
        'cmb65
        '
        Me.cmb65.Enabled = False
        Me.cmb65.Font = New System.Drawing.Font("Cambria", 8.0!)
        Me.cmb65.FormattingEnabled = True
        Me.cmb65.Location = New System.Drawing.Point(121, 46)
        Me.cmb65.Name = "cmb65"
        Me.cmb65.Size = New System.Drawing.Size(89, 20)
        Me.cmb65.TabIndex = 171
        '
        'cmb66
        '
        Me.cmb66.Enabled = False
        Me.cmb66.Font = New System.Drawing.Font("Cambria", 8.0!)
        Me.cmb66.FormattingEnabled = True
        Me.cmb66.Location = New System.Drawing.Point(121, 68)
        Me.cmb66.Name = "cmb66"
        Me.cmb66.Size = New System.Drawing.Size(89, 20)
        Me.cmb66.TabIndex = 170
        '
        'cmb67
        '
        Me.cmb67.Enabled = False
        Me.cmb67.Font = New System.Drawing.Font("Cambria", 8.0!)
        Me.cmb67.FormattingEnabled = True
        Me.cmb67.Location = New System.Drawing.Point(121, 90)
        Me.cmb67.Name = "cmb67"
        Me.cmb67.Size = New System.Drawing.Size(89, 20)
        Me.cmb67.TabIndex = 169
        '
        'cmb68
        '
        Me.cmb68.Enabled = False
        Me.cmb68.Font = New System.Drawing.Font("Cambria", 8.0!)
        Me.cmb68.FormattingEnabled = True
        Me.cmb68.Location = New System.Drawing.Point(121, 113)
        Me.cmb68.Name = "cmb68"
        Me.cmb68.Size = New System.Drawing.Size(89, 20)
        Me.cmb68.TabIndex = 168
        '
        'cmb70
        '
        Me.cmb70.Enabled = False
        Me.cmb70.Font = New System.Drawing.Font("Cambria", 8.0!)
        Me.cmb70.FormattingEnabled = True
        Me.cmb70.Location = New System.Drawing.Point(121, 157)
        Me.cmb70.Name = "cmb70"
        Me.cmb70.Size = New System.Drawing.Size(89, 20)
        Me.cmb70.TabIndex = 167
        '
        'cmb69
        '
        Me.cmb69.Enabled = False
        Me.cmb69.Font = New System.Drawing.Font("Cambria", 8.0!)
        Me.cmb69.FormattingEnabled = True
        Me.cmb69.Location = New System.Drawing.Point(121, 135)
        Me.cmb69.Name = "cmb69"
        Me.cmb69.Size = New System.Drawing.Size(89, 20)
        Me.cmb69.TabIndex = 164
        '
        'cmb64
        '
        Me.cmb64.Enabled = False
        Me.cmb64.Font = New System.Drawing.Font("Cambria", 8.0!)
        Me.cmb64.FormattingEnabled = True
        Me.cmb64.Location = New System.Drawing.Point(121, 24)
        Me.cmb64.Name = "cmb64"
        Me.cmb64.Size = New System.Drawing.Size(89, 20)
        Me.cmb64.TabIndex = 162
        '
        'chk70
        '
        Me.chk70.AutoSize = True
        Me.chk70.Location = New System.Drawing.Point(5, 157)
        Me.chk70.Name = "chk70"
        Me.chk70.Size = New System.Drawing.Size(116, 18)
        Me.chk70.TabIndex = 150
        Me.chk70.Text = "Persona Contacto"
        Me.chk70.UseVisualStyleBackColor = True
        '
        'chk69
        '
        Me.chk69.AutoSize = True
        Me.chk69.Location = New System.Drawing.Point(5, 135)
        Me.chk69.Name = "chk69"
        Me.chk69.Size = New System.Drawing.Size(59, 18)
        Me.chk69.TabIndex = 149
        Me.chk69.Text = "Monto"
        Me.chk69.UseVisualStyleBackColor = True
        '
        'chk68
        '
        Me.chk68.AutoSize = True
        Me.chk68.Location = New System.Drawing.Point(5, 114)
        Me.chk68.Name = "chk68"
        Me.chk68.Size = New System.Drawing.Size(70, 18)
        Me.chk68.TabIndex = 148
        Me.chk68.Text = "Teléfono"
        Me.chk68.UseVisualStyleBackColor = True
        '
        'chk67
        '
        Me.chk67.AutoSize = True
        Me.chk67.ForeColor = System.Drawing.Color.Black
        Me.chk67.Location = New System.Drawing.Point(5, 90)
        Me.chk67.Name = "chk67"
        Me.chk67.Size = New System.Drawing.Size(103, 18)
        Me.chk67.TabIndex = 147
        Me.chk67.Text = "Dirección Cont."
        Me.chk67.UseVisualStyleBackColor = True
        '
        'chk66
        '
        Me.chk66.AutoSize = True
        Me.chk66.ForeColor = System.Drawing.Color.Black
        Me.chk66.Location = New System.Drawing.Point(5, 70)
        Me.chk66.Name = "chk66"
        Me.chk66.Size = New System.Drawing.Size(65, 18)
        Me.chk66.TabIndex = 146
        Me.chk66.Text = "Cod. A2"
        Me.chk66.UseVisualStyleBackColor = True
        '
        'chk65
        '
        Me.chk65.AutoSize = True
        Me.chk65.ForeColor = System.Drawing.Color.Red
        Me.chk65.Location = New System.Drawing.Point(5, 49)
        Me.chk65.Name = "chk65"
        Me.chk65.Size = New System.Drawing.Size(107, 18)
        Me.chk65.TabIndex = 145
        Me.chk65.Text = "Des. Contratista"
        Me.chk65.UseVisualStyleBackColor = True
        '
        'chk64
        '
        Me.chk64.AutoSize = True
        Me.chk64.ForeColor = System.Drawing.Color.Red
        Me.chk64.Location = New System.Drawing.Point(5, 28)
        Me.chk64.Name = "chk64"
        Me.chk64.Size = New System.Drawing.Size(108, 18)
        Me.chk64.TabIndex = 144
        Me.chk64.Text = "Cod. Contratista"
        Me.chk64.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.ToolStrip2)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.gpbDres)
        Me.SplitContainer2.Size = New System.Drawing.Size(693, 541)
        Me.SplitContainer2.SplitterDistance = 25
        Me.SplitContainer2.TabIndex = 0
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.ToolStripButton1, Me.ToolStripSeparator3, Me.ToolStripButton2, Me.ToolStripSeparator4, Me.ToolStripButton3, Me.ToolStripSeparator5, Me.ToolStripButton4, Me.ToolStripSeparator6, Me.ToolStripButton5, Me.ToolStripSeparator12, Me.ToolStripButton6})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip2.Size = New System.Drawing.Size(693, 25)
        Me.ToolStrip2.TabIndex = 152
        Me.ToolStrip2.Text = "Menú Importación"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Archivo Excel"
        Me.ToolStripButton1.ToolTipText = "Seleccionar Archivo"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Verificar Datos"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Enabled = False
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Importar"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Actualizar"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Tag = ""
        Me.ToolStripButton5.Text = "Eliminar Seleccion"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton6.Tag = "Cerrar Formulario"
        Me.ToolStripButton6.Text = "Cerrar"
        '
        'gpbDres
        '
        Me.gpbDres.AllowUserToAddRows = False
        Me.gpbDres.AllowUserToDeleteRows = False
        Me.gpbDres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gpbDres.ColumnHeadersVisible = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gpbDres.DefaultCellStyle = DataGridViewCellStyle3
        Me.gpbDres.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpbDres.Location = New System.Drawing.Point(0, 0)
        Me.gpbDres.Name = "gpbDres"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gpbDres.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.gpbDres.Size = New System.Drawing.Size(693, 512)
        Me.gpbDres.TabIndex = 151
        '
        'frmImportacionContratista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(941, 541)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmImportacionContratista"
        Me.Text = "frmImportacionContratista"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.gbpCont.ResumeLayout(False)
        Me.gbpCont.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.gpbDres, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents gpbDres As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents gbpCont As System.Windows.Forms.GroupBox
    Friend WithEvents cmb65 As System.Windows.Forms.ComboBox
    Friend WithEvents cmb66 As System.Windows.Forms.ComboBox
    Friend WithEvents cmb67 As System.Windows.Forms.ComboBox
    Friend WithEvents cmb68 As System.Windows.Forms.ComboBox
    Friend WithEvents cmb70 As System.Windows.Forms.ComboBox
    Friend WithEvents cmb69 As System.Windows.Forms.ComboBox
    Friend WithEvents cmb64 As System.Windows.Forms.ComboBox
    Friend WithEvents chk70 As System.Windows.Forms.CheckBox
    Friend WithEvents chk69 As System.Windows.Forms.CheckBox
    Friend WithEvents chk68 As System.Windows.Forms.CheckBox
    Friend WithEvents chk67 As System.Windows.Forms.CheckBox
    Friend WithEvents chk66 As System.Windows.Forms.CheckBox
    Friend WithEvents chk65 As System.Windows.Forms.CheckBox
    Friend WithEvents chk64 As System.Windows.Forms.CheckBox
    Friend WithEvents cmb71 As System.Windows.Forms.ComboBox
    Friend WithEvents chk71 As System.Windows.Forms.CheckBox
End Class

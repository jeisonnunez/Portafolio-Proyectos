<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantenimientoProy
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMantenimientoProy))
        Me.tbxMtoCb = New System.Windows.Forms.TextBox
        Me.tbxPxC = New System.Windows.Forms.TextBox
        Me.lblidint = New System.Windows.Forms.Label
        Me.txtCp = New System.Windows.Forms.TextBox
        Me.lblctaPag = New System.Windows.Forms.Label
        Me.lblPxC = New System.Windows.Forms.Label
        Me.txtResp = New System.Windows.Forms.TextBox
        Me.lblMontoC = New System.Windows.Forms.Label
        Me.lblid = New System.Windows.Forms.Label
        Me.lblTitulo1 = New System.Windows.Forms.Label
        Me.tbxUbi = New System.Windows.Forms.TextBox
        Me.lblCont = New System.Windows.Forms.Label
        Me.lblMtoTri = New System.Windows.Forms.Label
        Me.txtPercta = New System.Windows.Forms.TextBox
        Me.lblCtasTra = New System.Windows.Forms.Label
        Me.txtMontTri = New System.Windows.Forms.TextBox
        Me.lblResp = New System.Windows.Forms.Label
        Me.tbxDescr = New System.Windows.Forms.TextBox
        Me.lblDescrPro = New System.Windows.Forms.Label
        Me.lblCodPro = New System.Windows.Forms.Label
        Me.tbxCodp = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.tbxNroMant = New System.Windows.Forms.TextBox
        Me.lblNrMant = New System.Windows.Forms.Label
        Me.lblFei = New System.Windows.Forms.Label
        Me.dtpFechai = New System.Windows.Forms.DateTimePicker
        Me.dtpFecTer = New System.Windows.Forms.DateTimePicker
        Me.lblfecter = New System.Windows.Forms.Label
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
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton12 = New System.Windows.Forms.ToolStripButton
        Me.btnNroMant = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbxMtoCb
        '
        Me.tbxMtoCb.Font = New System.Drawing.Font("Cambria", 10.0!)
        Me.tbxMtoCb.Location = New System.Drawing.Point(216, 325)
        Me.tbxMtoCb.Name = "tbxMtoCb"
        Me.tbxMtoCb.Size = New System.Drawing.Size(345, 23)
        Me.tbxMtoCb.TabIndex = 6
        Me.tbxMtoCb.Tag = "6"
        '
        'tbxPxC
        '
        Me.tbxPxC.Font = New System.Drawing.Font("Cambria", 10.0!)
        Me.tbxPxC.Location = New System.Drawing.Point(216, 354)
        Me.tbxPxC.Name = "tbxPxC"
        Me.tbxPxC.Size = New System.Drawing.Size(345, 23)
        Me.tbxPxC.TabIndex = 7
        Me.tbxPxC.Tag = "7"
        '
        'lblidint
        '
        Me.lblidint.AutoSize = True
        Me.lblidint.Enabled = False
        Me.lblidint.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.lblidint.Location = New System.Drawing.Point(-56, 35)
        Me.lblidint.Name = "lblidint"
        Me.lblidint.Size = New System.Drawing.Size(12, 16)
        Me.lblidint.TabIndex = 115
        Me.lblidint.Text = "."
        '
        'txtCp
        '
        Me.txtCp.Font = New System.Drawing.Font("Cambria", 10.0!)
        Me.txtCp.Location = New System.Drawing.Point(216, 467)
        Me.txtCp.Name = "txtCp"
        Me.txtCp.Size = New System.Drawing.Size(345, 23)
        Me.txtCp.TabIndex = 11
        Me.txtCp.Tag = "11"
        '
        'lblctaPag
        '
        Me.lblctaPag.AutoSize = True
        Me.lblctaPag.Font = New System.Drawing.Font("Cambria", 10.0!)
        Me.lblctaPag.Location = New System.Drawing.Point(42, 472)
        Me.lblctaPag.Name = "lblctaPag"
        Me.lblctaPag.Size = New System.Drawing.Size(110, 16)
        Me.lblctaPag.TabIndex = 112
        Me.lblctaPag.Text = "Cuentas Pagadas"
        '
        'lblPxC
        '
        Me.lblPxC.AutoSize = True
        Me.lblPxC.Font = New System.Drawing.Font("Cambria", 10.0!)
        Me.lblPxC.Location = New System.Drawing.Point(42, 359)
        Me.lblPxC.Name = "lblPxC"
        Me.lblPxC.Size = New System.Drawing.Size(125, 16)
        Me.lblPxC.TabIndex = 111
        Me.lblPxC.Text = "Pendiente x Cobrar"
        '
        'txtResp
        '
        Me.txtResp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtResp.Font = New System.Drawing.Font("Cambria", 10.0!)
        Me.txtResp.Location = New System.Drawing.Point(216, 383)
        Me.txtResp.Name = "txtResp"
        Me.txtResp.Size = New System.Drawing.Size(345, 23)
        Me.txtResp.TabIndex = 8
        Me.txtResp.Tag = "8"
        '
        'lblMontoC
        '
        Me.lblMontoC.AutoSize = True
        Me.lblMontoC.Font = New System.Drawing.Font("Cambria", 10.0!)
        Me.lblMontoC.Location = New System.Drawing.Point(42, 330)
        Me.lblMontoC.Name = "lblMontoC"
        Me.lblMontoC.Size = New System.Drawing.Size(100, 16)
        Me.lblMontoC.TabIndex = 110
        Me.lblMontoC.Text = "Monto Cobrado"
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Enabled = False
        Me.lblid.Font = New System.Drawing.Font("Cambria", 10.0!)
        Me.lblid.Location = New System.Drawing.Point(31, 35)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(102, 16)
        Me.lblid.TabIndex = 107
        Me.lblid.Text = "Codigo Interno:"
        '
        'lblTitulo1
        '
        Me.lblTitulo1.AutoSize = True
        Me.lblTitulo1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblTitulo1.Location = New System.Drawing.Point(30, 57)
        Me.lblTitulo1.Name = "lblTitulo1"
        Me.lblTitulo1.Size = New System.Drawing.Size(223, 19)
        Me.lblTitulo1.TabIndex = 106
        Me.lblTitulo1.Text = "Mantenimiento  del Proyecto"
        '
        'tbxUbi
        '
        Me.tbxUbi.Font = New System.Drawing.Font("Cambria", 10.0!)
        Me.tbxUbi.Location = New System.Drawing.Point(216, 295)
        Me.tbxUbi.Name = "tbxUbi"
        Me.tbxUbi.Size = New System.Drawing.Size(345, 23)
        Me.tbxUbi.TabIndex = 5
        Me.tbxUbi.Tag = "5"
        '
        'lblCont
        '
        Me.lblCont.AutoSize = True
        Me.lblCont.Font = New System.Drawing.Font("Cambria", 10.0!)
        Me.lblCont.Location = New System.Drawing.Point(42, 300)
        Me.lblCont.Name = "lblCont"
        Me.lblCont.Size = New System.Drawing.Size(166, 16)
        Me.lblCont.TabIndex = 105
        Me.lblCont.Text = "Monto Contrato sin ITBMS"
        '
        'lblMtoTri
        '
        Me.lblMtoTri.AutoSize = True
        Me.lblMtoTri.Font = New System.Drawing.Font("Cambria", 10.0!)
        Me.lblMtoTri.Location = New System.Drawing.Point(42, 416)
        Me.lblMtoTri.Name = "lblMtoTri"
        Me.lblMtoTri.Size = New System.Drawing.Size(127, 16)
        Me.lblMtoTri.TabIndex = 104
        Me.lblMtoTri.Text = "Monto Trimestrales"
        '
        'txtPercta
        '
        Me.txtPercta.Font = New System.Drawing.Font("Cambria", 10.0!)
        Me.txtPercta.Location = New System.Drawing.Point(216, 440)
        Me.txtPercta.Name = "txtPercta"
        Me.txtPercta.Size = New System.Drawing.Size(345, 23)
        Me.txtPercta.TabIndex = 10
        Me.txtPercta.Tag = "10"
        '
        'lblCtasTra
        '
        Me.lblCtasTra.AutoSize = True
        Me.lblCtasTra.Font = New System.Drawing.Font("Cambria", 10.0!)
        Me.lblCtasTra.Location = New System.Drawing.Point(42, 445)
        Me.lblCtasTra.Name = "lblCtasTra"
        Me.lblCtasTra.Size = New System.Drawing.Size(111, 16)
        Me.lblCtasTra.TabIndex = 102
        Me.lblCtasTra.Text = "Cuentas Transito"
        '
        'txtMontTri
        '
        Me.txtMontTri.Font = New System.Drawing.Font("Cambria", 10.0!)
        Me.txtMontTri.Location = New System.Drawing.Point(216, 411)
        Me.txtMontTri.Name = "txtMontTri"
        Me.txtMontTri.Size = New System.Drawing.Size(345, 23)
        Me.txtMontTri.TabIndex = 9
        Me.txtMontTri.Tag = "9"
        '
        'lblResp
        '
        Me.lblResp.AutoSize = True
        Me.lblResp.Font = New System.Drawing.Font("Cambria", 10.0!)
        Me.lblResp.Location = New System.Drawing.Point(42, 388)
        Me.lblResp.Name = "lblResp"
        Me.lblResp.Size = New System.Drawing.Size(85, 16)
        Me.lblResp.TabIndex = 101
        Me.lblResp.Text = "Responsable"
        '
        'tbxDescr
        '
        Me.tbxDescr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxDescr.Font = New System.Drawing.Font("Cambria", 10.0!)
        Me.tbxDescr.Location = New System.Drawing.Point(216, 140)
        Me.tbxDescr.Multiline = True
        Me.tbxDescr.Name = "tbxDescr"
        Me.tbxDescr.Size = New System.Drawing.Size(474, 44)
        Me.tbxDescr.TabIndex = 1
        '
        'lblDescrPro
        '
        Me.lblDescrPro.AutoSize = True
        Me.lblDescrPro.Font = New System.Drawing.Font("Cambria", 10.0!)
        Me.lblDescrPro.Location = New System.Drawing.Point(45, 146)
        Me.lblDescrPro.Name = "lblDescrPro"
        Me.lblDescrPro.Size = New System.Drawing.Size(136, 16)
        Me.lblDescrPro.TabIndex = 100
        Me.lblDescrPro.Text = "Nombre del Proyecto"
        '
        'lblCodPro
        '
        Me.lblCodPro.AutoSize = True
        Me.lblCodPro.Font = New System.Drawing.Font("Cambria", 10.0!)
        Me.lblCodPro.Location = New System.Drawing.Point(45, 114)
        Me.lblCodPro.Name = "lblCodPro"
        Me.lblCodPro.Size = New System.Drawing.Size(105, 16)
        Me.lblCodPro.TabIndex = 99
        Me.lblCodPro.Text = "Código Proyecto"
        '
        'tbxCodp
        '
        Me.tbxCodp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxCodp.Font = New System.Drawing.Font("Cambria", 10.0!)
        Me.tbxCodp.Location = New System.Drawing.Point(216, 111)
        Me.tbxCodp.Name = "tbxCodp"
        Me.tbxCodp.Size = New System.Drawing.Size(147, 23)
        Me.tbxCodp.TabIndex = 0
        Me.tbxCodp.Tag = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Enabled = False
        Me.Label4.Font = New System.Drawing.Font("Cambria", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(143, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(11, 16)
        Me.Label4.TabIndex = 116
        Me.Label4.Text = "."
        '
        'tbxNroMant
        '
        Me.tbxNroMant.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxNroMant.Font = New System.Drawing.Font("Cambria", 10.0!)
        Me.tbxNroMant.Location = New System.Drawing.Point(216, 209)
        Me.tbxNroMant.Name = "tbxNroMant"
        Me.tbxNroMant.Size = New System.Drawing.Size(345, 23)
        Me.tbxNroMant.TabIndex = 2
        Me.tbxNroMant.Tag = ""
        '
        'lblNrMant
        '
        Me.lblNrMant.AutoSize = True
        Me.lblNrMant.Font = New System.Drawing.Font("Cambria", 10.0!)
        Me.lblNrMant.Location = New System.Drawing.Point(42, 214)
        Me.lblNrMant.Name = "lblNrMant"
        Me.lblNrMant.Size = New System.Drawing.Size(127, 16)
        Me.lblNrMant.TabIndex = 118
        Me.lblNrMant.Text = "Nro Mantenimiento"
        '
        'lblFei
        '
        Me.lblFei.AutoSize = True
        Me.lblFei.Font = New System.Drawing.Font("Cambria", 10.0!)
        Me.lblFei.Location = New System.Drawing.Point(42, 241)
        Me.lblFei.Name = "lblFei"
        Me.lblFei.Size = New System.Drawing.Size(84, 16)
        Me.lblFei.TabIndex = 119
        Me.lblFei.Text = "Fecha Inicial"
        '
        'dtpFechai
        '
        Me.dtpFechai.Font = New System.Drawing.Font("Cambria", 10.0!)
        Me.dtpFechai.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechai.Location = New System.Drawing.Point(216, 238)
        Me.dtpFechai.Name = "dtpFechai"
        Me.dtpFechai.Size = New System.Drawing.Size(115, 23)
        Me.dtpFechai.TabIndex = 3
        Me.dtpFechai.Tag = "3"
        '
        'dtpFecTer
        '
        Me.dtpFecTer.Font = New System.Drawing.Font("Cambria", 10.0!)
        Me.dtpFecTer.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecTer.Location = New System.Drawing.Point(216, 264)
        Me.dtpFecTer.Name = "dtpFecTer"
        Me.dtpFecTer.Size = New System.Drawing.Size(115, 23)
        Me.dtpFecTer.TabIndex = 4
        Me.dtpFecTer.Tag = "4"
        '
        'lblfecter
        '
        Me.lblfecter.AutoSize = True
        Me.lblfecter.Font = New System.Drawing.Font("Cambria", 10.0!)
        Me.lblfecter.Location = New System.Drawing.Point(42, 269)
        Me.lblfecter.Name = "lblfecter"
        Me.lblfecter.Size = New System.Drawing.Size(122, 16)
        Me.lblfecter.TabIndex = 121
        Me.lblfecter.Text = "Fecha Terminación"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator6, Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ToolStripButton2, Me.ToolStripSeparator3, Me.ToolStripButton3, Me.ToolStripSeparator4, Me.ToolStripButton4, Me.ToolStripSeparator5, Me.ToolStripButton5, Me.ToolStripSeparator2, Me.ToolStripButton12})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1040, 25)
        Me.ToolStrip1.TabIndex = 176
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
        Me.ToolStripButton2.Text = "Nuevo Nro de Mantenimiento"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Enabled = False
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
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "Exportar a  Excel"
        Me.ToolStripButton5.ToolTipText = "Exportar a  Excel"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
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
        'btnNroMant
        '
        Me.btnNroMant.Font = New System.Drawing.Font("Cambria", 10.0!)
        Me.btnNroMant.Image = CType(resources.GetObject("btnNroMant.Image"), System.Drawing.Image)
        Me.btnNroMant.Location = New System.Drawing.Point(567, 208)
        Me.btnNroMant.Name = "btnNroMant"
        Me.btnNroMant.Size = New System.Drawing.Size(31, 24)
        Me.btnNroMant.TabIndex = 177
        Me.btnNroMant.Text = "...:"
        Me.btnNroMant.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(924, 510)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(107, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 175
        Me.PictureBox1.TabStop = False
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Cambria", 10.0!)
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(370, 109)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(31, 24)
        Me.btnBuscar.TabIndex = 83
        Me.btnBuscar.Text = "...:"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'frmMantenimientoProy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1040, 565)
        Me.Controls.Add(Me.btnNroMant)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dtpFecTer)
        Me.Controls.Add(Me.lblfecter)
        Me.Controls.Add(Me.dtpFechai)
        Me.Controls.Add(Me.lblFei)
        Me.Controls.Add(Me.tbxNroMant)
        Me.Controls.Add(Me.lblNrMant)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbxMtoCb)
        Me.Controls.Add(Me.tbxPxC)
        Me.Controls.Add(Me.lblidint)
        Me.Controls.Add(Me.txtCp)
        Me.Controls.Add(Me.lblctaPag)
        Me.Controls.Add(Me.lblPxC)
        Me.Controls.Add(Me.txtResp)
        Me.Controls.Add(Me.lblMontoC)
        Me.Controls.Add(Me.lblid)
        Me.Controls.Add(Me.lblTitulo1)
        Me.Controls.Add(Me.tbxUbi)
        Me.Controls.Add(Me.lblCont)
        Me.Controls.Add(Me.lblMtoTri)
        Me.Controls.Add(Me.txtPercta)
        Me.Controls.Add(Me.lblCtasTra)
        Me.Controls.Add(Me.txtMontTri)
        Me.Controls.Add(Me.lblResp)
        Me.Controls.Add(Me.tbxDescr)
        Me.Controls.Add(Me.lblDescrPro)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.lblCodPro)
        Me.Controls.Add(Me.tbxCodp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMantenimientoProy"
        Me.Text = "frmMantenimientoProy"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbxMtoCb As System.Windows.Forms.TextBox
    Friend WithEvents tbxPxC As System.Windows.Forms.TextBox
    Friend WithEvents lblidint As System.Windows.Forms.Label
    Friend WithEvents txtCp As System.Windows.Forms.TextBox
    Friend WithEvents lblctaPag As System.Windows.Forms.Label
    Friend WithEvents lblPxC As System.Windows.Forms.Label
    Friend WithEvents txtResp As System.Windows.Forms.TextBox
    Friend WithEvents lblMontoC As System.Windows.Forms.Label
    Friend WithEvents lblid As System.Windows.Forms.Label
    Friend WithEvents lblTitulo1 As System.Windows.Forms.Label
    Friend WithEvents tbxUbi As System.Windows.Forms.TextBox
    Friend WithEvents lblCont As System.Windows.Forms.Label
    Friend WithEvents lblMtoTri As System.Windows.Forms.Label
    Friend WithEvents txtPercta As System.Windows.Forms.TextBox
    Friend WithEvents lblCtasTra As System.Windows.Forms.Label
    Friend WithEvents txtMontTri As System.Windows.Forms.TextBox
    Friend WithEvents lblResp As System.Windows.Forms.Label
    Friend WithEvents tbxDescr As System.Windows.Forms.TextBox
    Friend WithEvents lblDescrPro As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents lblCodPro As System.Windows.Forms.Label
    Friend WithEvents tbxCodp As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbxNroMant As System.Windows.Forms.TextBox
    Friend WithEvents lblNrMant As System.Windows.Forms.Label
    Friend WithEvents lblFei As System.Windows.Forms.Label
    Friend WithEvents dtpFechai As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecTer As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblfecter As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
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
    Friend WithEvents btnNroMant As System.Windows.Forms.Button
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
End Class

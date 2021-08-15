<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClientes))
        Me.tbxTelefCli = New System.Windows.Forms.TextBox
        Me.tbxPxC = New System.Windows.Forms.TextBox
        Me.lblPxC = New System.Windows.Forms.Label
        Me.txtResp = New System.Windows.Forms.TextBox
        Me.lblTeleCli = New System.Windows.Forms.Label
        Me.lblTitulo1 = New System.Windows.Forms.Label
        Me.tbxDirCli = New System.Windows.Forms.TextBox
        Me.lblDirCli = New System.Windows.Forms.Label
        Me.lblpersContCli = New System.Windows.Forms.Label
        Me.tbxDescrCli = New System.Windows.Forms.TextBox
        Me.lblDesCli = New System.Windows.Forms.Label
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.lblCodCli = New System.Windows.Forms.Label
        Me.tbxCodCli = New System.Windows.Forms.TextBox
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
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton12 = New System.Windows.Forms.ToolStripButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbxTelefCli
        '
        Me.tbxTelefCli.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxTelefCli.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxTelefCli.Location = New System.Drawing.Point(185, 256)
        Me.tbxTelefCli.Name = "tbxTelefCli"
        Me.tbxTelefCli.Size = New System.Drawing.Size(345, 23)
        Me.tbxTelefCli.TabIndex = 130
        Me.tbxTelefCli.Tag = "6"
        '
        'tbxPxC
        '
        Me.tbxPxC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxPxC.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxPxC.Location = New System.Drawing.Point(185, 285)
        Me.tbxPxC.Name = "tbxPxC"
        Me.tbxPxC.Size = New System.Drawing.Size(345, 23)
        Me.tbxPxC.TabIndex = 131
        Me.tbxPxC.Tag = "7"
        '
        'lblPxC
        '
        Me.lblPxC.AutoSize = True
        Me.lblPxC.Font = New System.Drawing.Font("Cambria", 12.0!)
        Me.lblPxC.Location = New System.Drawing.Point(68, 289)
        Me.lblPxC.Name = "lblPxC"
        Me.lblPxC.Size = New System.Drawing.Size(30, 19)
        Me.lblPxC.TabIndex = 147
        Me.lblPxC.Text = "DV"
        '
        'txtResp
        '
        Me.txtResp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtResp.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResp.Location = New System.Drawing.Point(185, 227)
        Me.txtResp.Name = "txtResp"
        Me.txtResp.Size = New System.Drawing.Size(345, 23)
        Me.txtResp.TabIndex = 132
        Me.txtResp.Tag = "8"
        '
        'lblTeleCli
        '
        Me.lblTeleCli.AutoSize = True
        Me.lblTeleCli.Font = New System.Drawing.Font("Cambria", 12.0!)
        Me.lblTeleCli.Location = New System.Drawing.Point(68, 260)
        Me.lblTeleCli.Name = "lblTeleCli"
        Me.lblTeleCli.Size = New System.Drawing.Size(38, 19)
        Me.lblTeleCli.TabIndex = 146
        Me.lblTeleCli.Text = "RUC"
        '
        'lblTitulo1
        '
        Me.lblTitulo1.AutoSize = True
        Me.lblTitulo1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblTitulo1.Location = New System.Drawing.Point(27, 58)
        Me.lblTitulo1.Name = "lblTitulo1"
        Me.lblTitulo1.Size = New System.Drawing.Size(201, 19)
        Me.lblTitulo1.TabIndex = 144
        Me.lblTitulo1.Text = "Datos Principales Clientes"
        '
        'tbxDirCli
        '
        Me.tbxDirCli.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxDirCli.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxDirCli.Location = New System.Drawing.Point(185, 167)
        Me.tbxDirCli.Multiline = True
        Me.tbxDirCli.Name = "tbxDirCli"
        Me.tbxDirCli.Size = New System.Drawing.Size(474, 54)
        Me.tbxDirCli.TabIndex = 129
        Me.tbxDirCli.Tag = "5"
        '
        'lblDirCli
        '
        Me.lblDirCli.AutoSize = True
        Me.lblDirCli.Font = New System.Drawing.Font("Cambria", 12.0!)
        Me.lblDirCli.Location = New System.Drawing.Point(68, 181)
        Me.lblDirCli.Name = "lblDirCli"
        Me.lblDirCli.Size = New System.Drawing.Size(75, 19)
        Me.lblDirCli.TabIndex = 143
        Me.lblDirCli.Text = "Dirección"
        '
        'lblpersContCli
        '
        Me.lblpersContCli.AutoSize = True
        Me.lblpersContCli.Font = New System.Drawing.Font("Cambria", 12.0!)
        Me.lblpersContCli.Location = New System.Drawing.Point(68, 227)
        Me.lblpersContCli.Name = "lblpersContCli"
        Me.lblpersContCli.Size = New System.Drawing.Size(70, 19)
        Me.lblpersContCli.TabIndex = 140
        Me.lblpersContCli.Text = "Contacto"
        '
        'tbxDescrCli
        '
        Me.tbxDescrCli.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxDescrCli.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxDescrCli.Location = New System.Drawing.Point(185, 117)
        Me.tbxDescrCli.Multiline = True
        Me.tbxDescrCli.Name = "tbxDescrCli"
        Me.tbxDescrCli.Size = New System.Drawing.Size(474, 44)
        Me.tbxDescrCli.TabIndex = 125
        '
        'lblDesCli
        '
        Me.lblDesCli.AutoSize = True
        Me.lblDesCli.Font = New System.Drawing.Font("Cambria", 12.0!)
        Me.lblDesCli.Location = New System.Drawing.Point(68, 117)
        Me.lblDesCli.Name = "lblDesCli"
        Me.lblDesCli.Size = New System.Drawing.Size(66, 19)
        Me.lblDesCli.TabIndex = 139
        Me.lblDesCli.Text = "Nombre"
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(338, 89)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(28, 22)
        Me.btnBuscar.TabIndex = 136
        Me.btnBuscar.Text = "...:"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'lblCodCli
        '
        Me.lblCodCli.AutoSize = True
        Me.lblCodCli.Font = New System.Drawing.Font("Cambria", 12.0!)
        Me.lblCodCli.Location = New System.Drawing.Point(68, 89)
        Me.lblCodCli.Name = "lblCodCli"
        Me.lblCodCli.Size = New System.Drawing.Size(61, 19)
        Me.lblCodCli.TabIndex = 138
        Me.lblCodCli.Text = "Código "
        '
        'tbxCodCli
        '
        Me.tbxCodCli.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxCodCli.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxCodCli.Location = New System.Drawing.Point(185, 89)
        Me.tbxCodCli.Name = "tbxCodCli"
        Me.tbxCodCli.Size = New System.Drawing.Size(147, 23)
        Me.tbxCodCli.TabIndex = 124
        Me.tbxCodCli.Tag = ""
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator6, Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ToolStripButton2, Me.ToolStripSeparator3, Me.ToolStripButton3, Me.ToolStripSeparator4, Me.ToolStripButton4, Me.ToolStripSeparator5, Me.ToolStripButton7, Me.ToolStripSeparator2, Me.ToolStripButton12})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1015, 25)
        Me.ToolStrip1.TabIndex = 173
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
        Me.ToolStripButton1.Visible = False
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
        Me.ToolStripButton3.Text = "Grabar Cambios"
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
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton7.Text = "Sincronizar Clientes con A2"
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
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(908, 544)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(107, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 176
        Me.PictureBox1.TabStop = False
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1015, 596)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.tbxTelefCli)
        Me.Controls.Add(Me.tbxPxC)
        Me.Controls.Add(Me.lblPxC)
        Me.Controls.Add(Me.txtResp)
        Me.Controls.Add(Me.lblTeleCli)
        Me.Controls.Add(Me.lblTitulo1)
        Me.Controls.Add(Me.tbxDirCli)
        Me.Controls.Add(Me.lblDirCli)
        Me.Controls.Add(Me.lblpersContCli)
        Me.Controls.Add(Me.tbxDescrCli)
        Me.Controls.Add(Me.lblDesCli)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.lblCodCli)
        Me.Controls.Add(Me.tbxCodCli)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmClientes"
        Me.Text = "Clientes"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbxTelefCli As System.Windows.Forms.TextBox
    Friend WithEvents tbxPxC As System.Windows.Forms.TextBox
    Friend WithEvents lblPxC As System.Windows.Forms.Label
    Friend WithEvents txtResp As System.Windows.Forms.TextBox
    Friend WithEvents lblTeleCli As System.Windows.Forms.Label
    Friend WithEvents lblTitulo1 As System.Windows.Forms.Label
    Friend WithEvents tbxDirCli As System.Windows.Forms.TextBox
    Friend WithEvents lblDirCli As System.Windows.Forms.Label
    Friend WithEvents lblpersContCli As System.Windows.Forms.Label
    Friend WithEvents tbxDescrCli As System.Windows.Forms.TextBox
    Friend WithEvents lblDesCli As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents lblCodCli As System.Windows.Forms.Label
    Friend WithEvents tbxCodCli As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton12 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
End Class

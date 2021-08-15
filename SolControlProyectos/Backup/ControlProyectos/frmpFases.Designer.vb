<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpFases
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
        Me.spCppalProy = New System.Windows.Forms.SplitContainer
        Me.lblMenu = New System.Windows.Forms.Label
        Me.lblCodp = New System.Windows.Forms.Label
        Me.tbxDescp = New System.Windows.Forms.TextBox
        Me.lblDescp = New System.Windows.Forms.Label
        Me.tbxLoc = New System.Windows.Forms.TextBox
        Me.lblLoc = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.btnRes = New System.Windows.Forms.Button
        Me.lblResp = New System.Windows.Forms.Label
        Me.btnAnt = New System.Windows.Forms.Button
        Me.btnSig = New System.Windows.Forms.Button
        Me.dtpfef = New System.Windows.Forms.DateTimePicker
        Me.lblfef = New System.Windows.Forms.Label
        Me.dtpfei = New System.Windows.Forms.DateTimePicker
        Me.dtpfeap = New System.Windows.Forms.DateTimePicker
        Me.tbxMontou = New System.Windows.Forms.TextBox
        Me.lblMontopg = New System.Windows.Forms.Label
        Me.tbxMontoe = New System.Windows.Forms.TextBox
        Me.lblMontop = New System.Windows.Forms.Label
        Me.lblfeci = New System.Windows.Forms.Label
        Me.lblfechap = New System.Windows.Forms.Label
        Me.cmbFaces = New System.Windows.Forms.ComboBox
        Me.btnAgr = New System.Windows.Forms.Button
        Me.Eliminar = New System.Windows.Forms.Button
        Me.btnMod = New System.Windows.Forms.Button
        Me.spCppalProy.Panel1.SuspendLayout()
        Me.spCppalProy.Panel2.SuspendLayout()
        Me.spCppalProy.SuspendLayout()
        Me.SuspendLayout()
        '
        'spCppalProy
        '
        Me.spCppalProy.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spCppalProy.Location = New System.Drawing.Point(0, 0)
        Me.spCppalProy.Name = "spCppalProy"
        Me.spCppalProy.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spCppalProy.Panel1
        '
        Me.spCppalProy.Panel1.Controls.Add(Me.btnMod)
        Me.spCppalProy.Panel1.Controls.Add(Me.Eliminar)
        Me.spCppalProy.Panel1.Controls.Add(Me.btnAgr)
        Me.spCppalProy.Panel1.Controls.Add(Me.cmbFaces)
        Me.spCppalProy.Panel1.Controls.Add(Me.lblMenu)
        Me.spCppalProy.Panel1.Controls.Add(Me.lblCodp)
        Me.spCppalProy.Panel1.Controls.Add(Me.tbxDescp)
        Me.spCppalProy.Panel1.Controls.Add(Me.lblDescp)
        '
        'spCppalProy.Panel2
        '
        Me.spCppalProy.Panel2.Controls.Add(Me.tbxLoc)
        Me.spCppalProy.Panel2.Controls.Add(Me.lblLoc)
        Me.spCppalProy.Panel2.Controls.Add(Me.ComboBox1)
        Me.spCppalProy.Panel2.Controls.Add(Me.btnRes)
        Me.spCppalProy.Panel2.Controls.Add(Me.lblResp)
        Me.spCppalProy.Panel2.Controls.Add(Me.btnAnt)
        Me.spCppalProy.Panel2.Controls.Add(Me.btnSig)
        Me.spCppalProy.Panel2.Controls.Add(Me.dtpfef)
        Me.spCppalProy.Panel2.Controls.Add(Me.lblfef)
        Me.spCppalProy.Panel2.Controls.Add(Me.dtpfei)
        Me.spCppalProy.Panel2.Controls.Add(Me.dtpfeap)
        Me.spCppalProy.Panel2.Controls.Add(Me.tbxMontou)
        Me.spCppalProy.Panel2.Controls.Add(Me.lblMontopg)
        Me.spCppalProy.Panel2.Controls.Add(Me.tbxMontoe)
        Me.spCppalProy.Panel2.Controls.Add(Me.lblMontop)
        Me.spCppalProy.Panel2.Controls.Add(Me.lblfeci)
        Me.spCppalProy.Panel2.Controls.Add(Me.lblfechap)
        Me.spCppalProy.Size = New System.Drawing.Size(874, 534)
        Me.spCppalProy.SplitterDistance = 140
        Me.spCppalProy.TabIndex = 2
        '
        'lblMenu
        '
        Me.lblMenu.AutoSize = True
        Me.lblMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.Location = New System.Drawing.Point(343, 9)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(226, 24)
        Me.lblMenu.TabIndex = 3
        Me.lblMenu.Text = "Menu Faces del Proyecto"
        '
        'lblCodp
        '
        Me.lblCodp.AutoSize = True
        Me.lblCodp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodp.Location = New System.Drawing.Point(11, 68)
        Me.lblCodp.Name = "lblCodp"
        Me.lblCodp.Size = New System.Drawing.Size(83, 13)
        Me.lblCodp.TabIndex = 2
        Me.lblCodp.Text = "Agregar Face"
        '
        'tbxDescp
        '
        Me.tbxDescp.Location = New System.Drawing.Point(425, 63)
        Me.tbxDescp.Multiline = True
        Me.tbxDescp.Name = "tbxDescp"
        Me.tbxDescp.Size = New System.Drawing.Size(424, 39)
        Me.tbxDescp.TabIndex = 2
        '
        'lblDescp
        '
        Me.lblDescp.AutoSize = True
        Me.lblDescp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescp.Location = New System.Drawing.Point(270, 68)
        Me.lblDescp.Name = "lblDescp"
        Me.lblDescp.Size = New System.Drawing.Size(138, 13)
        Me.lblDescp.TabIndex = 0
        Me.lblDescp.Text = "Descripción de la Face"
        '
        'tbxLoc
        '
        Me.tbxLoc.Location = New System.Drawing.Point(137, 188)
        Me.tbxLoc.Name = "tbxLoc"
        Me.tbxLoc.Size = New System.Drawing.Size(146, 20)
        Me.tbxLoc.TabIndex = 38
        Me.tbxLoc.Tag = "7"
        '
        'lblLoc
        '
        Me.lblLoc.AutoSize = True
        Me.lblLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoc.Location = New System.Drawing.Point(32, 188)
        Me.lblLoc.Name = "lblLoc"
        Me.lblLoc.Size = New System.Drawing.Size(62, 13)
        Me.lblLoc.TabIndex = 37
        Me.lblLoc.Text = "Localidad"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(137, 106)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(204, 21)
        Me.ComboBox1.TabIndex = 36
        Me.ComboBox1.Tag = "8"
        '
        'btnRes
        '
        Me.btnRes.Location = New System.Drawing.Point(347, 103)
        Me.btnRes.Name = "btnRes"
        Me.btnRes.Size = New System.Drawing.Size(61, 23)
        Me.btnRes.TabIndex = 35
        Me.btnRes.Text = "Agregar"
        Me.btnRes.UseVisualStyleBackColor = True
        '
        'lblResp
        '
        Me.lblResp.AutoSize = True
        Me.lblResp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResp.Location = New System.Drawing.Point(32, 113)
        Me.lblResp.Name = "lblResp"
        Me.lblResp.Size = New System.Drawing.Size(86, 13)
        Me.lblResp.TabIndex = 33
        Me.lblResp.Text = "Responsables"
        '
        'btnAnt
        '
        Me.btnAnt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAnt.Location = New System.Drawing.Point(705, 339)
        Me.btnAnt.Name = "btnAnt"
        Me.btnAnt.Size = New System.Drawing.Size(75, 23)
        Me.btnAnt.TabIndex = 31
        Me.btnAnt.Text = "Anterior"
        Me.btnAnt.UseVisualStyleBackColor = True
        '
        'btnSig
        '
        Me.btnSig.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSig.Location = New System.Drawing.Point(786, 339)
        Me.btnSig.Name = "btnSig"
        Me.btnSig.Size = New System.Drawing.Size(75, 23)
        Me.btnSig.TabIndex = 30
        Me.btnSig.Text = "Siguiente"
        Me.btnSig.UseVisualStyleBackColor = True
        '
        'dtpfef
        '
        Me.dtpfef.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfef.Location = New System.Drawing.Point(137, 71)
        Me.dtpfef.Name = "dtpfef"
        Me.dtpfef.Size = New System.Drawing.Size(115, 20)
        Me.dtpfef.TabIndex = 27
        Me.dtpfef.Tag = "5"
        '
        'lblfef
        '
        Me.lblfef.AutoSize = True
        Me.lblfef.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfef.Location = New System.Drawing.Point(32, 77)
        Me.lblfef.Name = "lblfef"
        Me.lblfef.Size = New System.Drawing.Size(63, 13)
        Me.lblfef.TabIndex = 26
        Me.lblfef.Text = "Fecha Fin"
        '
        'dtpfei
        '
        Me.dtpfei.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfei.Location = New System.Drawing.Point(137, 45)
        Me.dtpfei.Name = "dtpfei"
        Me.dtpfei.Size = New System.Drawing.Size(115, 20)
        Me.dtpfei.TabIndex = 25
        Me.dtpfei.Tag = "4"
        '
        'dtpfeap
        '
        Me.dtpfeap.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfeap.Location = New System.Drawing.Point(137, 19)
        Me.dtpfeap.Name = "dtpfeap"
        Me.dtpfeap.Size = New System.Drawing.Size(115, 20)
        Me.dtpfeap.TabIndex = 24
        Me.dtpfeap.Tag = "3"
        '
        'tbxMontou
        '
        Me.tbxMontou.Location = New System.Drawing.Point(137, 162)
        Me.tbxMontou.Name = "tbxMontou"
        Me.tbxMontou.Size = New System.Drawing.Size(146, 20)
        Me.tbxMontou.TabIndex = 13
        Me.tbxMontou.Tag = "7"
        '
        'lblMontopg
        '
        Me.lblMontopg.AutoSize = True
        Me.lblMontopg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontopg.Location = New System.Drawing.Point(31, 167)
        Me.lblMontopg.Name = "lblMontopg"
        Me.lblMontopg.Size = New System.Drawing.Size(95, 13)
        Me.lblMontopg.TabIndex = 12
        Me.lblMontopg.Text = "Monto Utilizado"
        '
        'tbxMontoe
        '
        Me.tbxMontoe.Location = New System.Drawing.Point(137, 133)
        Me.tbxMontoe.Name = "tbxMontoe"
        Me.tbxMontoe.Size = New System.Drawing.Size(146, 20)
        Me.tbxMontoe.TabIndex = 11
        Me.tbxMontoe.Tag = "6"
        '
        'lblMontop
        '
        Me.lblMontop.AutoSize = True
        Me.lblMontop.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontop.Location = New System.Drawing.Point(31, 140)
        Me.lblMontop.Name = "lblMontop"
        Me.lblMontop.Size = New System.Drawing.Size(97, 13)
        Me.lblMontop.TabIndex = 10
        Me.lblMontop.Text = "Monto Estimado"
        '
        'lblfeci
        '
        Me.lblfeci.AutoSize = True
        Me.lblfeci.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfeci.Location = New System.Drawing.Point(32, 51)
        Me.lblfeci.Name = "lblfeci"
        Me.lblfeci.Size = New System.Drawing.Size(77, 13)
        Me.lblfeci.TabIndex = 6
        Me.lblfeci.Text = "Fecha Inicio"
        '
        'lblfechap
        '
        Me.lblfechap.AutoSize = True
        Me.lblfechap.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfechap.Location = New System.Drawing.Point(32, 25)
        Me.lblfechap.Name = "lblfechap"
        Me.lblfechap.Size = New System.Drawing.Size(94, 13)
        Me.lblfechap.TabIndex = 4
        Me.lblfechap.Text = "Fecha Apertura"
        '
        'cmbFaces
        '
        Me.cmbFaces.FormattingEnabled = True
        Me.cmbFaces.Location = New System.Drawing.Point(100, 65)
        Me.cmbFaces.Name = "cmbFaces"
        Me.cmbFaces.Size = New System.Drawing.Size(164, 21)
        Me.cmbFaces.TabIndex = 39
        Me.cmbFaces.Tag = "8"
        '
        'btnAgr
        '
        Me.btnAgr.Location = New System.Drawing.Point(100, 101)
        Me.btnAgr.Name = "btnAgr"
        Me.btnAgr.Size = New System.Drawing.Size(61, 23)
        Me.btnAgr.TabIndex = 39
        Me.btnAgr.Text = "Agregar"
        Me.btnAgr.UseVisualStyleBackColor = True
        '
        'Eliminar
        '
        Me.Eliminar.Location = New System.Drawing.Point(167, 101)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(61, 23)
        Me.Eliminar.TabIndex = 40
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'btnMod
        '
        Me.btnMod.Location = New System.Drawing.Point(234, 101)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(61, 23)
        Me.btnMod.TabIndex = 41
        Me.btnMod.Text = "Modificar"
        Me.btnMod.UseVisualStyleBackColor = True
        '
        'frmpFases
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 534)
        Me.Controls.Add(Me.spCppalProy)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmpFases"
        Me.Text = "frmpFases"
        Me.spCppalProy.Panel1.ResumeLayout(False)
        Me.spCppalProy.Panel1.PerformLayout()
        Me.spCppalProy.Panel2.ResumeLayout(False)
        Me.spCppalProy.Panel2.PerformLayout()
        Me.spCppalProy.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents spCppalProy As System.Windows.Forms.SplitContainer
    Friend WithEvents lblMenu As System.Windows.Forms.Label
    Friend WithEvents lblCodp As System.Windows.Forms.Label
    Friend WithEvents tbxDescp As System.Windows.Forms.TextBox
    Friend WithEvents lblDescp As System.Windows.Forms.Label
    Friend WithEvents tbxLoc As System.Windows.Forms.TextBox
    Friend WithEvents lblLoc As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents btnRes As System.Windows.Forms.Button
    Friend WithEvents lblResp As System.Windows.Forms.Label
    Friend WithEvents btnAnt As System.Windows.Forms.Button
    Friend WithEvents btnSig As System.Windows.Forms.Button
    Friend WithEvents dtpfef As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblfef As System.Windows.Forms.Label
    Friend WithEvents dtpfei As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpfeap As System.Windows.Forms.DateTimePicker
    Friend WithEvents tbxMontou As System.Windows.Forms.TextBox
    Friend WithEvents lblMontopg As System.Windows.Forms.Label
    Friend WithEvents tbxMontoe As System.Windows.Forms.TextBox
    Friend WithEvents lblMontop As System.Windows.Forms.Label
    Friend WithEvents lblfeci As System.Windows.Forms.Label
    Friend WithEvents lblfechap As System.Windows.Forms.Label
    Friend WithEvents cmbFaces As System.Windows.Forms.ComboBox
    Friend WithEvents btnMod As System.Windows.Forms.Button
    Friend WithEvents Eliminar As System.Windows.Forms.Button
    Friend WithEvents btnAgr As System.Windows.Forms.Button
End Class

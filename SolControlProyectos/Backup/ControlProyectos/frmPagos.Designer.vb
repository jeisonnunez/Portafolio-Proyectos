<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPagos
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.tbxNroRec = New System.Windows.Forms.TextBox
        Me.btnAcept = New System.Windows.Forms.Button
        Me.btnCanc = New System.Windows.Forms.Button
        Me.tbxNroFac = New System.Windows.Forms.TextBox
        Me.tbxMonto = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.tbxDocPago = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.tbxConcepto = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.tbxNroCheq = New System.Windows.Forms.TextBox
        Me.dtpFechaR = New System.Windows.Forms.DateTimePicker
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.tbxDocSi = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.tbxMes = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.tbxScafid = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.dtpFechaFact = New System.Windows.Forms.DateTimePicker
        Me.cmbTdoc = New System.Windows.Forms.ComboBox
        Me.lblTp = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(10, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nro Factura."
        '
        'tbxNroRec
        '
        Me.tbxNroRec.Enabled = False
        Me.tbxNroRec.Location = New System.Drawing.Point(93, 83)
        Me.tbxNroRec.Name = "tbxNroRec"
        Me.tbxNroRec.Size = New System.Drawing.Size(158, 20)
        Me.tbxNroRec.TabIndex = 1
        '
        'btnAcept
        '
        Me.btnAcept.Location = New System.Drawing.Point(49, 212)
        Me.btnAcept.Name = "btnAcept"
        Me.btnAcept.Size = New System.Drawing.Size(75, 23)
        Me.btnAcept.TabIndex = 5
        Me.btnAcept.Text = "Aceptar"
        Me.btnAcept.UseVisualStyleBackColor = True
        '
        'btnCanc
        '
        Me.btnCanc.Location = New System.Drawing.Point(196, 212)
        Me.btnCanc.Name = "btnCanc"
        Me.btnCanc.Size = New System.Drawing.Size(75, 23)
        Me.btnCanc.TabIndex = 6
        Me.btnCanc.Text = "Cancelar"
        Me.btnCanc.UseVisualStyleBackColor = True
        '
        'tbxNroFac
        '
        Me.tbxNroFac.Enabled = False
        Me.tbxNroFac.Location = New System.Drawing.Point(93, 62)
        Me.tbxNroFac.Name = "tbxNroFac"
        Me.tbxNroFac.Size = New System.Drawing.Size(158, 20)
        Me.tbxNroFac.TabIndex = 0
        '
        'tbxMonto
        '
        Me.tbxMonto.Location = New System.Drawing.Point(93, 146)
        Me.tbxMonto.Name = "tbxMonto"
        Me.tbxMonto.Size = New System.Drawing.Size(158, 20)
        Me.tbxMonto.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(10, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Fecha Pago"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(93, 104)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(89, 20)
        Me.dtpFecha.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(11, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Monto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(10, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(178, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Ingrese Datos del Pago"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(27, 253)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Doc. Pago"
        Me.Label6.Visible = False
        '
        'tbxDocPago
        '
        Me.tbxDocPago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxDocPago.Location = New System.Drawing.Point(110, 249)
        Me.tbxDocPago.Name = "tbxDocPago"
        Me.tbxDocPago.Size = New System.Drawing.Size(158, 20)
        Me.tbxDocPago.TabIndex = 3
        Me.tbxDocPago.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(149, 308)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Observacion"
        Me.Label7.Visible = False
        '
        'tbxConcepto
        '
        Me.tbxConcepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxConcepto.Location = New System.Drawing.Point(205, 324)
        Me.tbxConcepto.Name = "tbxConcepto"
        Me.tbxConcepto.Size = New System.Drawing.Size(89, 20)
        Me.tbxConcepto.TabIndex = 13
        Me.tbxConcepto.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(10, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nro. Recibo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(11, 170)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Nro Cheque"
        '
        'tbxNroCheq
        '
        Me.tbxNroCheq.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxNroCheq.Location = New System.Drawing.Point(93, 167)
        Me.tbxNroCheq.Name = "tbxNroCheq"
        Me.tbxNroCheq.Size = New System.Drawing.Size(158, 20)
        Me.tbxNroCheq.TabIndex = 15
        '
        'dtpFechaR
        '
        Me.dtpFechaR.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaR.Location = New System.Drawing.Point(110, 330)
        Me.dtpFechaR.Name = "dtpFechaR"
        Me.dtpFechaR.Size = New System.Drawing.Size(89, 20)
        Me.dtpFechaR.TabIndex = 19
        Me.dtpFechaR.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(113, 305)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Fecha Ref"
        Me.Label10.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(23, 307)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 13)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "DocSigu"
        Me.Label11.Visible = False
        '
        'tbxDocSi
        '
        Me.tbxDocSi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxDocSi.Location = New System.Drawing.Point(105, 304)
        Me.tbxDocSi.Name = "tbxDocSi"
        Me.tbxDocSi.Size = New System.Drawing.Size(158, 20)
        Me.tbxDocSi.TabIndex = 25
        Me.tbxDocSi.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(23, 282)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Mes Ejec."
        Me.Label12.Visible = False
        '
        'tbxMes
        '
        Me.tbxMes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxMes.Location = New System.Drawing.Point(105, 278)
        Me.tbxMes.Name = "tbxMes"
        Me.tbxMes.Size = New System.Drawing.Size(158, 20)
        Me.tbxMes.TabIndex = 23
        Me.tbxMes.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(31, 297)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Scafid"
        Me.Label9.Visible = False
        '
        'tbxScafid
        '
        Me.tbxScafid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxScafid.Location = New System.Drawing.Point(113, 294)
        Me.tbxScafid.Name = "tbxScafid"
        Me.tbxScafid.Size = New System.Drawing.Size(158, 20)
        Me.tbxScafid.TabIndex = 27
        Me.tbxScafid.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(257, 62)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(11, 13)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "*"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(274, 252)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(11, 13)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "*"
        Me.Label14.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(257, 149)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(11, 13)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "*"
        '
        'dtpFechaFact
        '
        Me.dtpFechaFact.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFact.Location = New System.Drawing.Point(130, 223)
        Me.dtpFechaFact.Name = "dtpFechaFact"
        Me.dtpFechaFact.Size = New System.Drawing.Size(60, 20)
        Me.dtpFechaFact.TabIndex = 58
        Me.dtpFechaFact.Visible = False
        '
        'cmbTdoc
        '
        Me.cmbTdoc.FormattingEnabled = True
        Me.cmbTdoc.Location = New System.Drawing.Point(93, 40)
        Me.cmbTdoc.Name = "cmbTdoc"
        Me.cmbTdoc.Size = New System.Drawing.Size(89, 21)
        Me.cmbTdoc.TabIndex = 59
        '
        'lblTp
        '
        Me.lblTp.AutoSize = True
        Me.lblTp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTp.Location = New System.Drawing.Point(10, 43)
        Me.lblTp.Name = "lblTp"
        Me.lblTp.Size = New System.Drawing.Size(65, 13)
        Me.lblTp.TabIndex = 60
        Me.lblTp.Text = "Tipo Pago"
        '
        'frmPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 266)
        Me.Controls.Add(Me.lblTp)
        Me.Controls.Add(Me.cmbTdoc)
        Me.Controls.Add(Me.dtpFechaFact)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tbxScafid)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tbxDocSi)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.tbxMes)
        Me.Controls.Add(Me.dtpFechaR)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbxNroCheq)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbxConcepto)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbxDocPago)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.tbxMonto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbxNroFac)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCanc)
        Me.Controls.Add(Me.btnAcept)
        Me.Controls.Add(Me.tbxNroRec)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmPagos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PROYECTO  FACTURAS - PAGOS  "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbxNroRec As System.Windows.Forms.TextBox
    Friend WithEvents btnAcept As System.Windows.Forms.Button
    Friend WithEvents btnCanc As System.Windows.Forms.Button
    Friend WithEvents tbxNroFac As System.Windows.Forms.TextBox
    Friend WithEvents tbxMonto As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbxDocPago As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbxConcepto As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbxNroCheq As System.Windows.Forms.TextBox
    Friend WithEvents dtpFechaR As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tbxDocSi As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tbxMes As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tbxScafid As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaFact As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbTdoc As System.Windows.Forms.ComboBox
    Friend WithEvents lblTp As System.Windows.Forms.Label
End Class

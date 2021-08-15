<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActualizaPago
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
        Me.Label9 = New System.Windows.Forms.Label
        Me.tbxScafid = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.tbxDocSi = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.tbxMes = New System.Windows.Forms.TextBox
        Me.dtpFechaR = New System.Windows.Forms.DateTimePicker
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.tbxNroCheq = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.tbxConc = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.tbxDocPago = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.dtpFecPago = New System.Windows.Forms.DateTimePicker
        Me.tbxMonto = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.tbxNroFac = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnAcep = New System.Windows.Forms.Button
        Me.tbxNroRec = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtpFechaFact = New System.Windows.Forms.DateTimePicker
        Me.lblTp = New System.Windows.Forms.Label
        Me.cmbTdoc = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 416)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "Scafid"
        Me.Label9.Visible = False
        '
        'tbxScafid
        '
        Me.tbxScafid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxScafid.Location = New System.Drawing.Point(90, 413)
        Me.tbxScafid.Name = "tbxScafid"
        Me.tbxScafid.Size = New System.Drawing.Size(158, 20)
        Me.tbxScafid.TabIndex = 9
        Me.tbxScafid.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(19, 395)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 13)
        Me.Label11.TabIndex = 50
        Me.Label11.Text = "DocSigu"
        Me.Label11.Visible = False
        '
        'tbxDocSi
        '
        Me.tbxDocSi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxDocSi.Location = New System.Drawing.Point(90, 392)
        Me.tbxDocSi.Name = "tbxDocSi"
        Me.tbxDocSi.Size = New System.Drawing.Size(158, 20)
        Me.tbxDocSi.TabIndex = 8
        Me.tbxDocSi.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(19, 374)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 13)
        Me.Label12.TabIndex = 48
        Me.Label12.Text = "Mes Ejec."
        Me.Label12.Visible = False
        '
        'tbxMes
        '
        Me.tbxMes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxMes.Location = New System.Drawing.Point(90, 370)
        Me.tbxMes.Name = "tbxMes"
        Me.tbxMes.Size = New System.Drawing.Size(158, 20)
        Me.tbxMes.TabIndex = 7
        Me.tbxMes.Visible = False
        '
        'dtpFechaR
        '
        Me.dtpFechaR.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaR.Location = New System.Drawing.Point(90, 436)
        Me.dtpFechaR.Name = "dtpFechaR"
        Me.dtpFechaR.Size = New System.Drawing.Size(89, 20)
        Me.dtpFechaR.TabIndex = 10
        Me.dtpFechaR.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 440)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 13)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Fecha Ref"
        Me.Label10.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 170)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Nro Cheque"
        '
        'tbxNroCheq
        '
        Me.tbxNroCheq.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxNroCheq.Location = New System.Drawing.Point(87, 167)
        Me.tbxNroCheq.Name = "tbxNroCheq"
        Me.tbxNroCheq.Size = New System.Drawing.Size(158, 20)
        Me.tbxNroCheq.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 461)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Observacion"
        Me.Label7.Visible = False
        '
        'tbxConc
        '
        Me.tbxConc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxConc.Location = New System.Drawing.Point(90, 458)
        Me.tbxConc.Name = "tbxConc"
        Me.tbxConc.Size = New System.Drawing.Size(227, 20)
        Me.tbxConc.TabIndex = 11
        Me.tbxConc.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(51, 339)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Doc. Pago"
        Me.Label6.Visible = False
        '
        'tbxDocPago
        '
        Me.tbxDocPago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxDocPago.Enabled = False
        Me.tbxDocPago.Location = New System.Drawing.Point(123, 335)
        Me.tbxDocPago.Name = "tbxDocPago"
        Me.tbxDocPago.Size = New System.Drawing.Size(158, 20)
        Me.tbxDocPago.TabIndex = 4
        Me.tbxDocPago.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Monto"
        '
        'dtpFecPago
        '
        Me.dtpFecPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecPago.Location = New System.Drawing.Point(87, 120)
        Me.dtpFecPago.Name = "dtpFecPago"
        Me.dtpFecPago.Size = New System.Drawing.Size(89, 20)
        Me.dtpFecPago.TabIndex = 3
        Me.dtpFecPago.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'tbxMonto
        '
        Me.tbxMonto.Location = New System.Drawing.Point(87, 146)
        Me.tbxMonto.Name = "tbxMonto"
        Me.tbxMonto.Size = New System.Drawing.Size(158, 20)
        Me.tbxMonto.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(15, 124)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 13)
        Me.Label13.TabIndex = 38
        Me.Label13.Text = "Fecha Pago"
        '
        'tbxNroFac
        '
        Me.tbxNroFac.Enabled = False
        Me.tbxNroFac.Location = New System.Drawing.Point(87, 78)
        Me.tbxNroFac.Name = "tbxNroFac"
        Me.tbxNroFac.Size = New System.Drawing.Size(158, 20)
        Me.tbxNroFac.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(15, 102)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 13)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "Nro. Recibo"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(156, 212)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnAcep
        '
        Me.btnAcep.Location = New System.Drawing.Point(46, 212)
        Me.btnAcep.Name = "btnAcep"
        Me.btnAcep.Size = New System.Drawing.Size(75, 23)
        Me.btnAcep.TabIndex = 12
        Me.btnAcep.Text = "Aceptar"
        Me.btnAcep.UseVisualStyleBackColor = True
        '
        'tbxNroRec
        '
        Me.tbxNroRec.Enabled = False
        Me.tbxNroRec.Location = New System.Drawing.Point(87, 99)
        Me.tbxNroRec.Name = "tbxNroRec"
        Me.tbxNroRec.Size = New System.Drawing.Size(158, 20)
        Me.tbxNroRec.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(15, 81)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(66, 13)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "Nro Factura."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(251, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(11, 13)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(287, 338)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(11, 13)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(251, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(11, 13)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "*"
        '
        'dtpFechaFact
        '
        Me.dtpFechaFact.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFact.Location = New System.Drawing.Point(254, 384)
        Me.dtpFechaFact.Name = "dtpFechaFact"
        Me.dtpFechaFact.Size = New System.Drawing.Size(60, 20)
        Me.dtpFechaFact.TabIndex = 57
        Me.dtpFechaFact.Visible = False
        '
        'lblTp
        '
        Me.lblTp.AutoSize = True
        Me.lblTp.Location = New System.Drawing.Point(14, 59)
        Me.lblTp.Name = "lblTp"
        Me.lblTp.Size = New System.Drawing.Size(56, 13)
        Me.lblTp.TabIndex = 62
        Me.lblTp.Text = "Tipo Pago"
        '
        'cmbTdoc
        '
        Me.cmbTdoc.FormattingEnabled = True
        Me.cmbTdoc.Location = New System.Drawing.Point(87, 56)
        Me.cmbTdoc.Name = "cmbTdoc"
        Me.cmbTdoc.Size = New System.Drawing.Size(89, 21)
        Me.cmbTdoc.TabIndex = 61
        '
        'frmActualizaPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 258)
        Me.Controls.Add(Me.lblTp)
        Me.Controls.Add(Me.cmbTdoc)
        Me.Controls.Add(Me.dtpFechaFact)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
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
        Me.Controls.Add(Me.tbxConc)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbxDocPago)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtpFecPago)
        Me.Controls.Add(Me.tbxMonto)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.tbxNroFac)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnAcep)
        Me.Controls.Add(Me.tbxNroRec)
        Me.Controls.Add(Me.Label15)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmActualizaPago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ACTUALIZAR PAGO FACTURA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tbxScafid As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tbxDocSi As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tbxMes As System.Windows.Forms.TextBox
    Friend WithEvents dtpFechaR As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbxNroCheq As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbxConc As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbxDocPago As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpFecPago As System.Windows.Forms.DateTimePicker
    Friend WithEvents tbxMonto As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tbxNroFac As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnAcep As System.Windows.Forms.Button
    Friend WithEvents tbxNroRec As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaFact As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTp As System.Windows.Forms.Label
    Friend WithEvents cmbTdoc As System.Windows.Forms.ComboBox
End Class

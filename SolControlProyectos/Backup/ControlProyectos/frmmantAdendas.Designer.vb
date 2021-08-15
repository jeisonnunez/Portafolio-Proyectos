<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmantAdendas
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
        Me.tbxObs = New System.Windows.Forms.TextBox
        Me.btnAc = New System.Windows.Forms.Button
        Me.btnC = New System.Windows.Forms.Button
        Me.lblObs = New System.Windows.Forms.Label
        Me.lblFec = New System.Windows.Forms.Label
        Me.tbxMonto = New System.Windows.Forms.TextBox
        Me.lblMonto = New System.Windows.Forms.Label
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.lblfechad = New System.Windows.Forms.Label
        Me.chkTpAd = New System.Windows.Forms.CheckBox
        Me.tbxAdendaT = New System.Windows.Forms.TextBox
        Me.lblad1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'tbxObs
        '
        Me.tbxObs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxObs.Location = New System.Drawing.Point(105, 76)
        Me.tbxObs.Multiline = True
        Me.tbxObs.Name = "tbxObs"
        Me.tbxObs.Size = New System.Drawing.Size(347, 130)
        Me.tbxObs.TabIndex = 3
        '
        'btnAc
        '
        Me.btnAc.Location = New System.Drawing.Point(128, 212)
        Me.btnAc.Name = "btnAc"
        Me.btnAc.Size = New System.Drawing.Size(71, 21)
        Me.btnAc.TabIndex = 5
        Me.btnAc.Text = "Aceptar"
        Me.btnAc.UseVisualStyleBackColor = True
        '
        'btnC
        '
        Me.btnC.Location = New System.Drawing.Point(250, 212)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(71, 21)
        Me.btnC.TabIndex = 6
        Me.btnC.Text = "Cancelar"
        Me.btnC.UseVisualStyleBackColor = True
        '
        'lblObs
        '
        Me.lblObs.AutoSize = True
        Me.lblObs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblObs.Location = New System.Drawing.Point(4, 79)
        Me.lblObs.Name = "lblObs"
        Me.lblObs.Size = New System.Drawing.Size(78, 13)
        Me.lblObs.TabIndex = 4
        Me.lblObs.Text = "Observación"
        '
        'lblFec
        '
        Me.lblFec.AutoSize = True
        Me.lblFec.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFec.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblFec.Location = New System.Drawing.Point(279, 5)
        Me.lblFec.Name = "lblFec"
        Me.lblFec.Size = New System.Drawing.Size(42, 13)
        Me.lblFec.TabIndex = 5
        Me.lblFec.Text = "Fecha"
        '
        'tbxMonto
        '
        Me.tbxMonto.Location = New System.Drawing.Point(105, 31)
        Me.tbxMonto.Name = "tbxMonto"
        Me.tbxMonto.Size = New System.Drawing.Size(94, 20)
        Me.tbxMonto.TabIndex = 0
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblMonto.Location = New System.Drawing.Point(4, 36)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(42, 13)
        Me.lblMonto.TabIndex = 8
        Me.lblMonto.Text = "Monto"
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(327, 5)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(94, 20)
        Me.dtpFecha.TabIndex = 7
        '
        'lblfechad
        '
        Me.lblfechad.AutoSize = True
        Me.lblfechad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfechad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblfechad.Location = New System.Drawing.Point(4, 56)
        Me.lblfechad.Name = "lblfechad"
        Me.lblfechad.Size = New System.Drawing.Size(95, 13)
        Me.lblfechad.TabIndex = 10
        Me.lblfechad.Text = "Tiempo Adenda"
        '
        'chkTpAd
        '
        Me.chkTpAd.AutoSize = True
        Me.chkTpAd.Location = New System.Drawing.Point(302, 33)
        Me.chkTpAd.Name = "chkTpAd"
        Me.chkTpAd.Size = New System.Drawing.Size(115, 17)
        Me.chkTpAd.TabIndex = 4
        Me.chkTpAd.Text = "Adenda Financiera"
        Me.chkTpAd.UseVisualStyleBackColor = True
        '
        'tbxAdendaT
        '
        Me.tbxAdendaT.Location = New System.Drawing.Point(105, 53)
        Me.tbxAdendaT.Name = "tbxAdendaT"
        Me.tbxAdendaT.Size = New System.Drawing.Size(94, 20)
        Me.tbxAdendaT.TabIndex = 11
        '
        'lblad1
        '
        Me.lblad1.AutoSize = True
        Me.lblad1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblad1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblad1.Location = New System.Drawing.Point(205, 55)
        Me.lblad1.Name = "lblad1"
        Me.lblad1.Size = New System.Drawing.Size(34, 13)
        Me.lblad1.TabIndex = 12
        Me.lblad1.Text = "Días"
        '
        'frmmantAdendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 245)
        Me.Controls.Add(Me.lblad1)
        Me.Controls.Add(Me.tbxAdendaT)
        Me.Controls.Add(Me.chkTpAd)
        Me.Controls.Add(Me.lblfechad)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.lblMonto)
        Me.Controls.Add(Me.tbxMonto)
        Me.Controls.Add(Me.lblFec)
        Me.Controls.Add(Me.lblObs)
        Me.Controls.Add(Me.btnC)
        Me.Controls.Add(Me.btnAc)
        Me.Controls.Add(Me.tbxObs)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmmantAdendas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADENDAS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbxObs As System.Windows.Forms.TextBox
    Friend WithEvents btnAc As System.Windows.Forms.Button
    Friend WithEvents btnC As System.Windows.Forms.Button
    Friend WithEvents lblObs As System.Windows.Forms.Label
    Friend WithEvents lblFec As System.Windows.Forms.Label
    Friend WithEvents tbxMonto As System.Windows.Forms.TextBox
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblfechad As System.Windows.Forms.Label
    Friend WithEvents chkTpAd As System.Windows.Forms.CheckBox
    Friend WithEvents tbxAdendaT As System.Windows.Forms.TextBox
    Friend WithEvents lblad1 As System.Windows.Forms.Label
End Class

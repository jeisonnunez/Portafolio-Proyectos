<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParamRepts
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
        Me.gbpParam = New System.Windows.Forms.GroupBox
        Me.gbpFe = New System.Windows.Forms.GroupBox
        Me.rdInsp = New System.Windows.Forms.RadioButton
        Me.RdRecibo = New System.Windows.Forms.RadioButton
        Me.rdHasta = New System.Windows.Forms.RadioButton
        Me.dtpFecRes = New System.Windows.Forms.DateTimePicker
        Me.chkFechaRes = New System.Windows.Forms.CheckBox
        Me.lblFecRes = New System.Windows.Forms.Label
        Me.chkAll = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblT = New System.Windows.Forms.Label
        Me.tbxAno = New System.Windows.Forms.TextBox
        Me.cmbGrupo = New System.Windows.Forms.ComboBox
        Me.btnAcep = New System.Windows.Forms.Button
        Me.btnCanc = New System.Windows.Forms.Button
        Me.gbpParam.SuspendLayout()
        Me.gbpFe.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbpParam
        '
        Me.gbpParam.Controls.Add(Me.gbpFe)
        Me.gbpParam.Controls.Add(Me.dtpFecRes)
        Me.gbpParam.Controls.Add(Me.chkFechaRes)
        Me.gbpParam.Controls.Add(Me.lblFecRes)
        Me.gbpParam.Controls.Add(Me.chkAll)
        Me.gbpParam.Controls.Add(Me.Label1)
        Me.gbpParam.Controls.Add(Me.lblT)
        Me.gbpParam.Controls.Add(Me.tbxAno)
        Me.gbpParam.Controls.Add(Me.cmbGrupo)
        Me.gbpParam.Controls.Add(Me.btnAcep)
        Me.gbpParam.Controls.Add(Me.btnCanc)
        Me.gbpParam.Location = New System.Drawing.Point(6, 1)
        Me.gbpParam.Name = "gbpParam"
        Me.gbpParam.Size = New System.Drawing.Size(381, 225)
        Me.gbpParam.TabIndex = 0
        Me.gbpParam.TabStop = False
        Me.gbpParam.Text = "Parámetros"
        '
        'gbpFe
        '
        Me.gbpFe.Controls.Add(Me.rdInsp)
        Me.gbpFe.Controls.Add(Me.RdRecibo)
        Me.gbpFe.Controls.Add(Me.rdHasta)
        Me.gbpFe.Location = New System.Drawing.Point(9, 81)
        Me.gbpFe.Name = "gbpFe"
        Me.gbpFe.Size = New System.Drawing.Size(218, 86)
        Me.gbpFe.TabIndex = 15
        Me.gbpFe.TabStop = False
        Me.gbpFe.Text = "Por Fecha de:"
        '
        'rdInsp
        '
        Me.rdInsp.AutoSize = True
        Me.rdInsp.Location = New System.Drawing.Point(10, 63)
        Me.rdInsp.Name = "rdInsp"
        Me.rdInsp.Size = New System.Drawing.Size(125, 17)
        Me.rdInsp.TabIndex = 2
        Me.rdInsp.TabStop = True
        Me.rdInsp.Text = "Fecha de Inspección"
        Me.rdInsp.UseVisualStyleBackColor = True
        '
        'RdRecibo
        '
        Me.RdRecibo.AutoSize = True
        Me.RdRecibo.Location = New System.Drawing.Point(10, 41)
        Me.RdRecibo.Name = "RdRecibo"
        Me.RdRecibo.Size = New System.Drawing.Size(109, 17)
        Me.RdRecibo.TabIndex = 1
        Me.RdRecibo.TabStop = True
        Me.RdRecibo.Text = "Fecha del Recibo"
        Me.RdRecibo.UseVisualStyleBackColor = True
        '
        'rdHasta
        '
        Me.rdHasta.AutoSize = True
        Me.rdHasta.Location = New System.Drawing.Point(10, 19)
        Me.rdHasta.Name = "rdHasta"
        Me.rdHasta.Size = New System.Drawing.Size(124, 17)
        Me.rdHasta.TabIndex = 0
        Me.rdHasta.TabStop = True
        Me.rdHasta.Text = "Periodo de la Cuenta"
        Me.rdHasta.UseVisualStyleBackColor = True
        '
        'dtpFecRes
        '
        Me.dtpFecRes.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecRes.Location = New System.Drawing.Point(81, 167)
        Me.dtpFecRes.Name = "dtpFecRes"
        Me.dtpFecRes.Size = New System.Drawing.Size(96, 20)
        Me.dtpFecRes.TabIndex = 14
        Me.dtpFecRes.Visible = False
        '
        'chkFechaRes
        '
        Me.chkFechaRes.AutoSize = True
        Me.chkFechaRes.Location = New System.Drawing.Point(293, 81)
        Me.chkFechaRes.Name = "chkFechaRes"
        Me.chkFechaRes.Size = New System.Drawing.Size(71, 17)
        Me.chkFechaRes.TabIndex = 13
        Me.chkFechaRes.Text = "Resumen"
        Me.chkFechaRes.UseVisualStyleBackColor = True
        '
        'lblFecRes
        '
        Me.lblFecRes.AutoSize = True
        Me.lblFecRes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecRes.Location = New System.Drawing.Point(10, 167)
        Me.lblFecRes.Name = "lblFecRes"
        Me.lblFecRes.Size = New System.Drawing.Size(47, 17)
        Me.lblFecRes.TabIndex = 12
        Me.lblFecRes.Text = "Fecha"
        Me.lblFecRes.Visible = False
        '
        'chkAll
        '
        Me.chkAll.AutoSize = True
        Me.chkAll.Location = New System.Drawing.Point(293, 35)
        Me.chkAll.Name = "chkAll"
        Me.chkAll.Size = New System.Drawing.Size(56, 17)
        Me.chkAll.TabIndex = 8
        Me.chkAll.Text = "Todos"
        Me.chkAll.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Sector"
        '
        'lblT
        '
        Me.lblT.AutoSize = True
        Me.lblT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblT.Location = New System.Drawing.Point(6, 56)
        Me.lblT.Name = "lblT"
        Me.lblT.Size = New System.Drawing.Size(33, 17)
        Me.lblT.TabIndex = 6
        Me.lblT.Text = "Año"
        '
        'tbxAno
        '
        Me.tbxAno.Location = New System.Drawing.Point(69, 55)
        Me.tbxAno.Name = "tbxAno"
        Me.tbxAno.Size = New System.Drawing.Size(96, 20)
        Me.tbxAno.TabIndex = 2
        '
        'cmbGrupo
        '
        Me.cmbGrupo.FormattingEnabled = True
        Me.cmbGrupo.Location = New System.Drawing.Point(69, 33)
        Me.cmbGrupo.Name = "cmbGrupo"
        Me.cmbGrupo.Size = New System.Drawing.Size(218, 21)
        Me.cmbGrupo.TabIndex = 1
        Me.cmbGrupo.Text = "Seleccione"
        '
        'btnAcep
        '
        Me.btnAcep.Location = New System.Drawing.Point(102, 193)
        Me.btnAcep.Name = "btnAcep"
        Me.btnAcep.Size = New System.Drawing.Size(75, 23)
        Me.btnAcep.TabIndex = 3
        Me.btnAcep.Text = "Aceptar"
        Me.btnAcep.UseVisualStyleBackColor = True
        '
        'btnCanc
        '
        Me.btnCanc.Location = New System.Drawing.Point(238, 191)
        Me.btnCanc.Name = "btnCanc"
        Me.btnCanc.Size = New System.Drawing.Size(75, 23)
        Me.btnCanc.TabIndex = 2
        Me.btnCanc.Text = "Cancelar"
        Me.btnCanc.UseVisualStyleBackColor = True
        '
        'frmParamRepts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 227)
        Me.Controls.Add(Me.gbpParam)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmParamRepts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REPORTES"
        Me.gbpParam.ResumeLayout(False)
        Me.gbpParam.PerformLayout()
        Me.gbpFe.ResumeLayout(False)
        Me.gbpFe.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbpParam As System.Windows.Forms.GroupBox
    Friend WithEvents cmbGrupo As System.Windows.Forms.ComboBox
    Friend WithEvents btnAcep As System.Windows.Forms.Button
    Friend WithEvents btnCanc As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblT As System.Windows.Forms.Label
    Friend WithEvents tbxAno As System.Windows.Forms.TextBox
    Friend WithEvents chkAll As System.Windows.Forms.CheckBox
    Friend WithEvents dtpFecRes As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkFechaRes As System.Windows.Forms.CheckBox
    Friend WithEvents lblFecRes As System.Windows.Forms.Label
    Friend WithEvents gbpFe As System.Windows.Forms.GroupBox
    Friend WithEvents rdInsp As System.Windows.Forms.RadioButton
    Friend WithEvents RdRecibo As System.Windows.Forms.RadioButton
    Friend WithEvents rdHasta As System.Windows.Forms.RadioButton
End Class

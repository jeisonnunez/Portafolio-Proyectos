<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSincronizaA2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSincronizaA2))
        Me.lblFechai = New System.Windows.Forms.Label
        Me.dtpFeci = New System.Windows.Forms.DateTimePicker
        Me.btnAcep = New System.Windows.Forms.Button
        Me.btnCanc = New System.Windows.Forms.Button
        Me.dtpFecf = New System.Windows.Forms.DateTimePicker
        Me.lblfecf = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblFechai
        '
        Me.lblFechai.AutoSize = True
        Me.lblFechai.Location = New System.Drawing.Point(19, 27)
        Me.lblFechai.Name = "lblFechai"
        Me.lblFechai.Size = New System.Drawing.Size(67, 13)
        Me.lblFechai.TabIndex = 0
        Me.lblFechai.Text = "Fecha Inicial"
        '
        'dtpFeci
        '
        Me.dtpFeci.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFeci.Location = New System.Drawing.Point(22, 52)
        Me.dtpFeci.Name = "dtpFeci"
        Me.dtpFeci.Size = New System.Drawing.Size(103, 20)
        Me.dtpFeci.TabIndex = 1
        '
        'btnAcep
        '
        Me.btnAcep.Location = New System.Drawing.Point(50, 99)
        Me.btnAcep.Name = "btnAcep"
        Me.btnAcep.Size = New System.Drawing.Size(75, 23)
        Me.btnAcep.TabIndex = 2
        Me.btnAcep.Text = "Aceptar"
        Me.btnAcep.UseVisualStyleBackColor = True
        '
        'btnCanc
        '
        Me.btnCanc.Location = New System.Drawing.Point(171, 99)
        Me.btnCanc.Name = "btnCanc"
        Me.btnCanc.Size = New System.Drawing.Size(75, 23)
        Me.btnCanc.TabIndex = 3
        Me.btnCanc.Text = "Cancelar"
        Me.btnCanc.UseVisualStyleBackColor = True
        '
        'dtpFecf
        '
        Me.dtpFecf.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecf.Location = New System.Drawing.Point(171, 52)
        Me.dtpFecf.Name = "dtpFecf"
        Me.dtpFecf.Size = New System.Drawing.Size(103, 20)
        Me.dtpFecf.TabIndex = 5
        '
        'lblfecf
        '
        Me.lblfecf.AutoSize = True
        Me.lblfecf.Location = New System.Drawing.Point(168, 27)
        Me.lblfecf.Name = "lblfecf"
        Me.lblfecf.Size = New System.Drawing.Size(62, 13)
        Me.lblfecf.TabIndex = 4
        Me.lblfecf.Text = "Fecha Final"
        '
        'frmSincronizaA2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 152)
        Me.Controls.Add(Me.dtpFecf)
        Me.Controls.Add(Me.lblfecf)
        Me.Controls.Add(Me.btnCanc)
        Me.Controls.Add(Me.btnAcep)
        Me.Controls.Add(Me.dtpFeci)
        Me.Controls.Add(Me.lblFechai)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSincronizaA2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sincronizar Facturas A2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFechai As System.Windows.Forms.Label
    Friend WithEvents dtpFeci As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnAcep As System.Windows.Forms.Button
    Friend WithEvents btnCanc As System.Windows.Forms.Button
    Friend WithEvents dtpFecf As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblfecf As System.Windows.Forms.Label
End Class

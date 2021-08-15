<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLocalidades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLocalidades))
        Me.lblLoc = New System.Windows.Forms.Label
        Me.cmbxLoc = New System.Windows.Forms.ComboBox
        Me.btnCanc = New System.Windows.Forms.Button
        Me.btnAcep = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblLoc
        '
        Me.lblLoc.AutoSize = True
        Me.lblLoc.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoc.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblLoc.Location = New System.Drawing.Point(35, 30)
        Me.lblLoc.Name = "lblLoc"
        Me.lblLoc.Size = New System.Drawing.Size(172, 19)
        Me.lblLoc.TabIndex = 0
        Me.lblLoc.Text = "Seleccione la Empresa"
        '
        'cmbxLoc
        '
        Me.cmbxLoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxLoc.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxLoc.FormattingEnabled = True
        Me.cmbxLoc.Location = New System.Drawing.Point(38, 82)
        Me.cmbxLoc.Name = "cmbxLoc"
        Me.cmbxLoc.Size = New System.Drawing.Size(359, 27)
        Me.cmbxLoc.TabIndex = 1
        '
        'btnCanc
        '
        Me.btnCanc.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCanc.Location = New System.Drawing.Point(274, 145)
        Me.btnCanc.Name = "btnCanc"
        Me.btnCanc.Size = New System.Drawing.Size(87, 27)
        Me.btnCanc.TabIndex = 3
        Me.btnCanc.Text = "Cancelar"
        Me.btnCanc.UseVisualStyleBackColor = True
        '
        'btnAcep
        '
        Me.btnAcep.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAcep.Location = New System.Drawing.Point(68, 145)
        Me.btnAcep.Name = "btnAcep"
        Me.btnAcep.Size = New System.Drawing.Size(87, 27)
        Me.btnAcep.TabIndex = 2
        Me.btnAcep.Text = "Aceptar"
        Me.btnAcep.UseVisualStyleBackColor = True
        '
        'frmLocalidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 196)
        Me.Controls.Add(Me.btnAcep)
        Me.Controls.Add(Me.btnCanc)
        Me.Controls.Add(Me.cmbxLoc)
        Me.Controls.Add(Me.lblLoc)
        Me.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLocalidades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Localidades"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblLoc As System.Windows.Forms.Label
    Friend WithEvents cmbxLoc As System.Windows.Forms.ComboBox
    Friend WithEvents btnCanc As System.Windows.Forms.Button
    Friend WithEvents btnAcep As System.Windows.Forms.Button
End Class

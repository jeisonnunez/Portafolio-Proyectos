<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInicioproyectos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInicioproyectos))
        Me.tbxBuscar = New System.Windows.Forms.TextBox
        Me.btnAcep = New System.Windows.Forms.Button
        Me.btnCanc = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.gbpParam = New System.Windows.Forms.GroupBox
        Me.gbpParam.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbxBuscar
        '
        Me.tbxBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxBuscar.Location = New System.Drawing.Point(15, 65)
        Me.tbxBuscar.Name = "tbxBuscar"
        Me.tbxBuscar.Size = New System.Drawing.Size(410, 20)
        Me.tbxBuscar.TabIndex = 0
        '
        'btnAcep
        '
        Me.btnAcep.Location = New System.Drawing.Point(119, 104)
        Me.btnAcep.Name = "btnAcep"
        Me.btnAcep.Size = New System.Drawing.Size(87, 23)
        Me.btnAcep.TabIndex = 1
        Me.btnAcep.Text = "Aceptar"
        Me.btnAcep.UseVisualStyleBackColor = True
        '
        'btnCanc
        '
        Me.btnCanc.Location = New System.Drawing.Point(268, 104)
        Me.btnCanc.Name = "btnCanc"
        Me.btnCanc.Size = New System.Drawing.Size(87, 23)
        Me.btnCanc.TabIndex = 2
        Me.btnCanc.Text = "Cancelar"
        Me.btnCanc.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(15, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(281, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Introduzca el Código o Descripción del Proyecto"
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(431, 62)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(31, 24)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "...:"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'gbpParam
        '
        Me.gbpParam.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gbpParam.Controls.Add(Me.Label1)
        Me.gbpParam.Controls.Add(Me.tbxBuscar)
        Me.gbpParam.Controls.Add(Me.btnBuscar)
        Me.gbpParam.Controls.Add(Me.btnAcep)
        Me.gbpParam.Controls.Add(Me.btnCanc)
        Me.gbpParam.Location = New System.Drawing.Point(51, 67)
        Me.gbpParam.Name = "gbpParam"
        Me.gbpParam.Size = New System.Drawing.Size(468, 155)
        Me.gbpParam.TabIndex = 5
        Me.gbpParam.TabStop = False
        Me.gbpParam.Text = "Parámetros de Entrada"
        '
        'frmInicioproyectos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(531, 313)
        Me.Controls.Add(Me.gbpParam)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInicioproyectos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Solicitud de Parámetros"
        Me.gbpParam.ResumeLayout(False)
        Me.gbpParam.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbxBuscar As System.Windows.Forms.TextBox
    Friend WithEvents btnAcep As System.Windows.Forms.Button
    Friend WithEvents btnCanc As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbpParam As System.Windows.Forms.GroupBox
End Class

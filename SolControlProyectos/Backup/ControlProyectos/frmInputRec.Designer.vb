<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInputRec
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
        Me.btnCanc = New System.Windows.Forms.Button
        Me.btnAcept = New System.Windows.Forms.Button
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.tbxDato = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'btnCanc
        '
        Me.btnCanc.Location = New System.Drawing.Point(160, 61)
        Me.btnCanc.Name = "btnCanc"
        Me.btnCanc.Size = New System.Drawing.Size(75, 23)
        Me.btnCanc.TabIndex = 7
        Me.btnCanc.Text = "Cancelar"
        Me.btnCanc.UseVisualStyleBackColor = True
        '
        'btnAcept
        '
        Me.btnAcept.Location = New System.Drawing.Point(37, 61)
        Me.btnAcept.Name = "btnAcept"
        Me.btnAcept.Size = New System.Drawing.Size(75, 23)
        Me.btnAcept.TabIndex = 6
        Me.btnAcept.Text = "Aceptar"
        Me.btnAcept.UseVisualStyleBackColor = True
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(14, 10)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(114, 13)
        Me.lblTitulo.TabIndex = 5
        Me.lblTitulo.Text = "Ingrese Nro de Recibo"
        '
        'tbxDato
        '
        Me.tbxDato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxDato.Location = New System.Drawing.Point(14, 35)
        Me.tbxDato.Name = "tbxDato"
        Me.tbxDato.Size = New System.Drawing.Size(253, 20)
        Me.tbxDato.TabIndex = 4
        '
        'frmInputRec
        '
        Me.AcceptButton = Me.btnAcept
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(280, 94)
        Me.Controls.Add(Me.btnCanc)
        Me.Controls.Add(Me.btnAcept)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.tbxDato)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmInputRec"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Número de Recibo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCanc As System.Windows.Forms.Button
    Friend WithEvents btnAcept As System.Windows.Forms.Button
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents tbxDato As System.Windows.Forms.TextBox
End Class

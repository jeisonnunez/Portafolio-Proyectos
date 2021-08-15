<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClaves
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
        Me.txAct = New System.Windows.Forms.TextBox
        Me.txtNew = New System.Windows.Forms.TextBox
        Me.txtRpNew = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnAcp = New System.Windows.Forms.Button
        Me.btnCanc = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txAct
        '
        Me.txAct.Font = New System.Drawing.Font("Cambria", 9.75!)
        Me.txAct.Location = New System.Drawing.Point(148, 73)
        Me.txAct.Name = "txAct"
        Me.txAct.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txAct.Size = New System.Drawing.Size(196, 23)
        Me.txAct.TabIndex = 0
        '
        'txtNew
        '
        Me.txtNew.Font = New System.Drawing.Font("Cambria", 9.75!)
        Me.txtNew.Location = New System.Drawing.Point(148, 99)
        Me.txtNew.Name = "txtNew"
        Me.txtNew.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNew.Size = New System.Drawing.Size(196, 23)
        Me.txtNew.TabIndex = 1
        '
        'txtRpNew
        '
        Me.txtRpNew.Font = New System.Drawing.Font("Cambria", 9.75!)
        Me.txtRpNew.Location = New System.Drawing.Point(148, 125)
        Me.txtRpNew.Name = "txtRpNew"
        Me.txtRpNew.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRpNew.Size = New System.Drawing.Size(196, 23)
        Me.txtRpNew.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(60, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Clave Actual:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(60, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Clave Nueva:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(60, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Repetir Clave:"
        '
        'btnAcp
        '
        Me.btnAcp.Font = New System.Drawing.Font("Cambria", 9.75!)
        Me.btnAcp.Location = New System.Drawing.Point(103, 155)
        Me.btnAcp.Name = "btnAcp"
        Me.btnAcp.Size = New System.Drawing.Size(75, 23)
        Me.btnAcp.TabIndex = 6
        Me.btnAcp.Text = "Aceptar"
        Me.btnAcp.UseVisualStyleBackColor = True
        '
        'btnCanc
        '
        Me.btnCanc.Font = New System.Drawing.Font("Cambria", 9.75!)
        Me.btnCanc.Location = New System.Drawing.Point(231, 155)
        Me.btnCanc.Name = "btnCanc"
        Me.btnCanc.Size = New System.Drawing.Size(75, 23)
        Me.btnCanc.TabIndex = 7
        Me.btnCanc.Text = "Cancelar"
        Me.btnCanc.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(156, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Cambio de Clave"
        '
        'frmClaves
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 279)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnCanc)
        Me.Controls.Add(Me.btnAcp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRpNew)
        Me.Controls.Add(Me.txtNew)
        Me.Controls.Add(Me.txAct)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmClaves"
        Me.Text = "Cambio de Claves"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txAct As System.Windows.Forms.TextBox
    Friend WithEvents txtNew As System.Windows.Forms.TextBox
    Friend WithEvents txtRpNew As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnAcp As System.Windows.Forms.Button
    Friend WithEvents btnCanc As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class

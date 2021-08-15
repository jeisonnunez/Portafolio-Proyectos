<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParamadicRpts
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
        Me.gbpAdic = New System.Windows.Forms.GroupBox
        Me.gbpgrupo2 = New System.Windows.Forms.GroupBox
        Me.chk6 = New System.Windows.Forms.CheckBox
        Me.chkall = New System.Windows.Forms.CheckBox
        Me.chk5 = New System.Windows.Forms.CheckBox
        Me.chk3 = New System.Windows.Forms.CheckBox
        Me.chk4 = New System.Windows.Forms.CheckBox
        Me.chk2 = New System.Windows.Forms.CheckBox
        Me.chk1 = New System.Windows.Forms.CheckBox
        Me.gbpGrupo = New System.Windows.Forms.GroupBox
        Me.RadioButton5 = New System.Windows.Forms.RadioButton
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.btnCanc = New System.Windows.Forms.Button
        Me.btnAcep = New System.Windows.Forms.Button
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.gbpAdic.SuspendLayout()
        Me.gbpgrupo2.SuspendLayout()
        Me.gbpGrupo.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbpAdic
        '
        Me.gbpAdic.Controls.Add(Me.gbpgrupo2)
        Me.gbpAdic.Controls.Add(Me.gbpGrupo)
        Me.gbpAdic.Controls.Add(Me.btnCanc)
        Me.gbpAdic.Controls.Add(Me.btnAcep)
        Me.gbpAdic.Controls.Add(Me.lblTitulo)
        Me.gbpAdic.Location = New System.Drawing.Point(12, 4)
        Me.gbpAdic.Name = "gbpAdic"
        Me.gbpAdic.Size = New System.Drawing.Size(370, 274)
        Me.gbpAdic.TabIndex = 0
        Me.gbpAdic.TabStop = False
        Me.gbpAdic.Text = "Parámetros Adicionales"
        '
        'gbpgrupo2
        '
        Me.gbpgrupo2.Controls.Add(Me.chk6)
        Me.gbpgrupo2.Controls.Add(Me.chkall)
        Me.gbpgrupo2.Controls.Add(Me.chk5)
        Me.gbpgrupo2.Controls.Add(Me.chk3)
        Me.gbpgrupo2.Controls.Add(Me.chk4)
        Me.gbpgrupo2.Controls.Add(Me.chk2)
        Me.gbpgrupo2.Controls.Add(Me.chk1)
        Me.gbpgrupo2.Location = New System.Drawing.Point(197, 66)
        Me.gbpgrupo2.Name = "gbpgrupo2"
        Me.gbpgrupo2.Size = New System.Drawing.Size(167, 137)
        Me.gbpgrupo2.TabIndex = 11
        Me.gbpgrupo2.TabStop = False
        '
        'chk6
        '
        Me.chk6.AutoSize = True
        Me.chk6.Location = New System.Drawing.Point(7, 114)
        Me.chk6.Name = "chk6"
        Me.chk6.Size = New System.Drawing.Size(88, 17)
        Me.chk6.TabIndex = 6
        Me.chk6.Text = "Nro Proyecto"
        Me.chk6.UseVisualStyleBackColor = True
        '
        'chkall
        '
        Me.chkall.AutoSize = True
        Me.chkall.Location = New System.Drawing.Point(7, 11)
        Me.chkall.Name = "chkall"
        Me.chkall.Size = New System.Drawing.Size(56, 17)
        Me.chkall.TabIndex = 5
        Me.chkall.Text = "Todos"
        Me.chkall.UseVisualStyleBackColor = True
        '
        'chk5
        '
        Me.chk5.AutoSize = True
        Me.chk5.Location = New System.Drawing.Point(7, 96)
        Me.chk5.Name = "chk5"
        Me.chk5.Size = New System.Drawing.Size(77, 17)
        Me.chk5.TabIndex = 4
        Me.chk5.Text = "NroRecibo"
        Me.chk5.UseVisualStyleBackColor = True
        '
        'chk3
        '
        Me.chk3.AutoSize = True
        Me.chk3.Location = New System.Drawing.Point(7, 61)
        Me.chk3.Name = "chk3"
        Me.chk3.Size = New System.Drawing.Size(77, 17)
        Me.chk3.TabIndex = 3
        Me.chk3.Text = "CuentaNro"
        Me.chk3.UseVisualStyleBackColor = True
        '
        'chk4
        '
        Me.chk4.AutoSize = True
        Me.chk4.Location = New System.Drawing.Point(7, 78)
        Me.chk4.Name = "chk4"
        Me.chk4.Size = New System.Drawing.Size(56, 17)
        Me.chk4.TabIndex = 2
        Me.chk4.Text = "Status"
        Me.chk4.UseVisualStyleBackColor = True
        '
        'chk2
        '
        Me.chk2.AutoSize = True
        Me.chk2.Location = New System.Drawing.Point(7, 44)
        Me.chk2.Name = "chk2"
        Me.chk2.Size = New System.Drawing.Size(56, 17)
        Me.chk2.TabIndex = 1
        Me.chk2.Text = "Fecha"
        Me.chk2.UseVisualStyleBackColor = True
        '
        'chk1
        '
        Me.chk1.AutoSize = True
        Me.chk1.Location = New System.Drawing.Point(7, 27)
        Me.chk1.Name = "chk1"
        Me.chk1.Size = New System.Drawing.Size(83, 17)
        Me.chk1.TabIndex = 0
        Me.chk1.Text = "NroContrato"
        Me.chk1.UseVisualStyleBackColor = True
        '
        'gbpGrupo
        '
        Me.gbpGrupo.Controls.Add(Me.RadioButton5)
        Me.gbpGrupo.Controls.Add(Me.RadioButton4)
        Me.gbpGrupo.Controls.Add(Me.RadioButton3)
        Me.gbpGrupo.Controls.Add(Me.RadioButton2)
        Me.gbpGrupo.Controls.Add(Me.RadioButton1)
        Me.gbpGrupo.Location = New System.Drawing.Point(18, 66)
        Me.gbpGrupo.Name = "gbpGrupo"
        Me.gbpGrupo.Size = New System.Drawing.Size(167, 137)
        Me.gbpGrupo.TabIndex = 10
        Me.gbpGrupo.TabStop = False
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(10, 110)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(78, 17)
        Me.RadioButton5.TabIndex = 4
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "Mes Actual"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(10, 87)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(86, 17)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "4to Trimestre"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(10, 64)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(86, 17)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "3er Trimestre"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(10, 42)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(89, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "2do Trimestre"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(10, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(86, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "1er Trimestre"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'btnCanc
        '
        Me.btnCanc.Location = New System.Drawing.Point(225, 231)
        Me.btnCanc.Name = "btnCanc"
        Me.btnCanc.Size = New System.Drawing.Size(75, 23)
        Me.btnCanc.TabIndex = 8
        Me.btnCanc.Text = "Cancelar"
        Me.btnCanc.UseVisualStyleBackColor = True
        '
        'btnAcep
        '
        Me.btnAcep.Location = New System.Drawing.Point(54, 231)
        Me.btnAcep.Name = "btnAcep"
        Me.btnAcep.Size = New System.Drawing.Size(75, 23)
        Me.btnAcep.TabIndex = 7
        Me.btnAcep.Text = "Aceptar"
        Me.btnAcep.UseVisualStyleBackColor = True
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(25, 31)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(51, 15)
        Me.lblTitulo.TabIndex = 6
        Me.lblTitulo.Text = "Reporte"
        '
        'frmParamadicRpts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(398, 289)
        Me.Controls.Add(Me.gbpAdic)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmParamadicRpts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parámetros Adicionales"
        Me.gbpAdic.ResumeLayout(False)
        Me.gbpAdic.PerformLayout()
        Me.gbpgrupo2.ResumeLayout(False)
        Me.gbpgrupo2.PerformLayout()
        Me.gbpGrupo.ResumeLayout(False)
        Me.gbpGrupo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbpAdic As System.Windows.Forms.GroupBox
    Friend WithEvents btnCanc As System.Windows.Forms.Button
    Friend WithEvents btnAcep As System.Windows.Forms.Button
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents gbpgrupo2 As System.Windows.Forms.GroupBox
    Friend WithEvents gbpGrupo As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents chk5 As System.Windows.Forms.CheckBox
    Friend WithEvents chk3 As System.Windows.Forms.CheckBox
    Friend WithEvents chk4 As System.Windows.Forms.CheckBox
    Friend WithEvents chk2 As System.Windows.Forms.CheckBox
    Friend WithEvents chk1 As System.Windows.Forms.CheckBox
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents chkall As System.Windows.Forms.CheckBox
    Friend WithEvents chk6 As System.Windows.Forms.CheckBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContrRec
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
        Me.ltvwRec = New System.Windows.Forms.ListView
        Me.chctaNro = New System.Windows.Forms.ColumnHeader
        Me.chNroPro = New System.Windows.Forms.ColumnHeader
        Me.chNroCont = New System.Windows.Forms.ColumnHeader
        Me.chNroRec = New System.Windows.Forms.ColumnHeader
        Me.chNroFac = New System.Windows.Forms.ColumnHeader
        Me.chid = New System.Windows.Forms.ColumnHeader
        Me.SpcRec = New System.Windows.Forms.SplitContainer
        Me.btnFact = New System.Windows.Forms.Button
        Me.btnCanc = New System.Windows.Forms.Button
        Me.btnAcep = New System.Windows.Forms.Button
        Me.btnCont = New System.Windows.Forms.Button
        Me.SpcRec.Panel1.SuspendLayout()
        Me.SpcRec.Panel2.SuspendLayout()
        Me.SpcRec.SuspendLayout()
        Me.SuspendLayout()
        '
        'ltvwRec
        '
        Me.ltvwRec.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ltvwRec.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chctaNro, Me.chNroPro, Me.chNroCont, Me.chNroRec, Me.chNroFac, Me.chid})
        Me.ltvwRec.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ltvwRec.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ltvwRec.FullRowSelect = True
        Me.ltvwRec.Location = New System.Drawing.Point(0, 0)
        Me.ltvwRec.Name = "ltvwRec"
        Me.ltvwRec.Size = New System.Drawing.Size(641, 382)
        Me.ltvwRec.TabIndex = 0
        Me.ltvwRec.UseCompatibleStateImageBehavior = False
        Me.ltvwRec.View = System.Windows.Forms.View.Details
        '
        'chctaNro
        '
        Me.chctaNro.Text = "Nro. Cuenta"
        Me.chctaNro.Width = 78
        '
        'chNroPro
        '
        Me.chNroPro.Text = "Nro. Proyecto"
        Me.chNroPro.Width = 131
        '
        'chNroCont
        '
        Me.chNroCont.Text = "Nro. Contrato"
        Me.chNroCont.Width = 127
        '
        'chNroRec
        '
        Me.chNroRec.Text = "Nro. Recibo"
        Me.chNroRec.Width = 140
        '
        'chNroFac
        '
        Me.chNroFac.Text = "Nro. Factura"
        Me.chNroFac.Width = 130
        '
        'chid
        '
        Me.chid.Text = "id"
        Me.chid.Width = 0
        '
        'SpcRec
        '
        Me.SpcRec.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SpcRec.Location = New System.Drawing.Point(0, 0)
        Me.SpcRec.Name = "SpcRec"
        Me.SpcRec.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SpcRec.Panel1
        '
        Me.SpcRec.Panel1.Controls.Add(Me.ltvwRec)
        '
        'SpcRec.Panel2
        '
        Me.SpcRec.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SpcRec.Panel2.Controls.Add(Me.btnFact)
        Me.SpcRec.Panel2.Controls.Add(Me.btnCanc)
        Me.SpcRec.Panel2.Controls.Add(Me.btnAcep)
        Me.SpcRec.Panel2.Controls.Add(Me.btnCont)
        Me.SpcRec.Size = New System.Drawing.Size(641, 447)
        Me.SpcRec.SplitterDistance = 382
        Me.SpcRec.TabIndex = 1
        '
        'btnFact
        '
        Me.btnFact.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFact.Location = New System.Drawing.Point(12, 11)
        Me.btnFact.Name = "btnFact"
        Me.btnFact.Size = New System.Drawing.Size(109, 23)
        Me.btnFact.TabIndex = 4
        Me.btnFact.Text = "Agr. Nro Factura"
        Me.btnFact.UseVisualStyleBackColor = True
        '
        'btnCanc
        '
        Me.btnCanc.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCanc.Location = New System.Drawing.Point(543, 11)
        Me.btnCanc.Name = "btnCanc"
        Me.btnCanc.Size = New System.Drawing.Size(86, 23)
        Me.btnCanc.TabIndex = 3
        Me.btnCanc.Text = "Cancelar"
        Me.btnCanc.UseVisualStyleBackColor = True
        '
        'btnAcep
        '
        Me.btnAcep.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAcep.Location = New System.Drawing.Point(451, 11)
        Me.btnAcep.Name = "btnAcep"
        Me.btnAcep.Size = New System.Drawing.Size(86, 23)
        Me.btnAcep.TabIndex = 2
        Me.btnAcep.Text = "Aceptar"
        Me.btnAcep.UseVisualStyleBackColor = True
        '
        'btnCont
        '
        Me.btnCont.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCont.Location = New System.Drawing.Point(12, 11)
        Me.btnCont.Name = "btnCont"
        Me.btnCont.Size = New System.Drawing.Size(109, 23)
        Me.btnCont.TabIndex = 1
        Me.btnCont.Text = "Agr. Nro Contrato"
        Me.btnCont.UseVisualStyleBackColor = True
        Me.btnCont.Visible = False
        '
        'frmContrRec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 447)
        Me.Controls.Add(Me.SpcRec)
        Me.Name = "frmContrRec"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RELACIÓN NRO. CONTRATO - RECIBO (PROYECTOS)"
        Me.SpcRec.Panel1.ResumeLayout(False)
        Me.SpcRec.Panel2.ResumeLayout(False)
        Me.SpcRec.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ltvwRec As System.Windows.Forms.ListView
    Friend WithEvents chNroPro As System.Windows.Forms.ColumnHeader
    Friend WithEvents chNroCont As System.Windows.Forms.ColumnHeader
    Friend WithEvents chNroRec As System.Windows.Forms.ColumnHeader
    Friend WithEvents SpcRec As System.Windows.Forms.SplitContainer
    Friend WithEvents btnCont As System.Windows.Forms.Button
    Friend WithEvents btnCanc As System.Windows.Forms.Button
    Friend WithEvents btnAcep As System.Windows.Forms.Button
    Friend WithEvents chctaNro As System.Windows.Forms.ColumnHeader
    Friend WithEvents chNroFac As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnFact As System.Windows.Forms.Button
    Friend WithEvents chid As System.Windows.Forms.ColumnHeader
End Class

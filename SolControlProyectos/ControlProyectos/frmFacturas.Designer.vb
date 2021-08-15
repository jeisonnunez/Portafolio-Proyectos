<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFacturas
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.ltwFact = New System.Windows.Forms.ListView
        Me.chlNroP = New System.Windows.Forms.ColumnHeader
        Me.chlNroCont = New System.Windows.Forms.ColumnHeader
        Me.chlNroFact = New System.Windows.Forms.ColumnHeader
        Me.chlNroRec = New System.Windows.Forms.ColumnHeader
        Me.chlMonto = New System.Windows.Forms.ColumnHeader
        Me.chlManual = New System.Windows.Forms.ColumnHeader
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ltwFact)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnCerrar)
        Me.SplitContainer1.Size = New System.Drawing.Size(572, 368)
        Me.SplitContainer1.SplitterDistance = 311
        Me.SplitContainer1.TabIndex = 0
        '
        'ltwFact
        '
        Me.ltwFact.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ltwFact.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chlNroP, Me.chlNroCont, Me.chlNroFact, Me.chlNroRec, Me.chlMonto, Me.chlManual})
        Me.ltwFact.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ltwFact.FullRowSelect = True
        Me.ltwFact.Location = New System.Drawing.Point(0, 0)
        Me.ltwFact.Name = "ltwFact"
        Me.ltwFact.Size = New System.Drawing.Size(572, 311)
        Me.ltwFact.TabIndex = 0
        Me.ltwFact.UseCompatibleStateImageBehavior = False
        Me.ltwFact.View = System.Windows.Forms.View.Details
        '
        'chlNroP
        '
        Me.chlNroP.Text = "NroProy"
        Me.chlNroP.Width = 106
        '
        'chlNroCont
        '
        Me.chlNroCont.Text = "Nro. Contrato"
        Me.chlNroCont.Width = 103
        '
        'chlNroFact
        '
        Me.chlNroFact.Text = "Nro. Factura"
        Me.chlNroFact.Width = 108
        '
        'chlNroRec
        '
        Me.chlNroRec.Text = "Nro. Recibo"
        Me.chlNroRec.Width = 126
        '
        'chlMonto
        '
        Me.chlMonto.Text = "Monto"
        Me.chlMonto.Width = 111
        '
        'chlManual
        '
        Me.chlManual.Width = 0
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(485, 18)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'frmFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 368)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmFacturas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RESUMEN FACTURAS - PROYECTOS"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ltwFact As System.Windows.Forms.ListView
    Friend WithEvents chlNroP As System.Windows.Forms.ColumnHeader
    Friend WithEvents chlNroCont As System.Windows.Forms.ColumnHeader
    Friend WithEvents chlNroFact As System.Windows.Forms.ColumnHeader
    Friend WithEvents chlNroRec As System.Windows.Forms.ColumnHeader
    Friend WithEvents chlMonto As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents chlManual As System.Windows.Forms.ColumnHeader
End Class

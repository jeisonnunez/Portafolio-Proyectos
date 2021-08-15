<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSubmenupInicio
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
        Me.spCtMenu = New System.Windows.Forms.SplitContainer
        Me.ltvMenup = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.spCtMenu.Panel1.SuspendLayout()
        Me.spCtMenu.Panel2.SuspendLayout()
        Me.spCtMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'spCtMenu
        '
        Me.spCtMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spCtMenu.Location = New System.Drawing.Point(0, 0)
        Me.spCtMenu.Name = "spCtMenu"
        Me.spCtMenu.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spCtMenu.Panel1
        '
        Me.spCtMenu.Panel1.Controls.Add(Me.ltvMenup)
        '
        'spCtMenu.Panel2
        '
        Me.spCtMenu.Panel2.Controls.Add(Me.btnCerrar)
        Me.spCtMenu.Size = New System.Drawing.Size(512, 546)
        Me.spCtMenu.SplitterDistance = 499
        Me.spCtMenu.TabIndex = 2
        '
        'ltvMenup
        '
        Me.ltvMenup.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ltvMenup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ltvMenup.Font = New System.Drawing.Font("Cambria", 10.0!)
        Me.ltvMenup.FullRowSelect = True
        Me.ltvMenup.Location = New System.Drawing.Point(0, 0)
        Me.ltvMenup.Name = "ltvMenup"
        Me.ltvMenup.Size = New System.Drawing.Size(512, 499)
        Me.ltvMenup.TabIndex = 3
        Me.ltvMenup.UseCompatibleStateImageBehavior = False
        Me.ltvMenup.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Cod"
        Me.ColumnHeader1.Width = 91
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Descripción"
        Me.ColumnHeader2.Width = 408
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "id"
        Me.ColumnHeader3.Width = 0
        '
        'btnCerrar
        '
        Me.btnCerrar.Font = New System.Drawing.Font("Cambria", 10.0!)
        Me.btnCerrar.Location = New System.Drawing.Point(424, 8)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(85, 23)
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'frmSubmenupInicio
        '
        Me.AcceptButton = Me.btnCerrar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(512, 546)
        Me.Controls.Add(Me.spCtMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmSubmenupInicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "         Sub Menu Proyectos"
        Me.spCtMenu.Panel1.ResumeLayout(False)
        Me.spCtMenu.Panel2.ResumeLayout(False)
        Me.spCtMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents spCtMenu As System.Windows.Forms.SplitContainer
    Friend WithEvents ltvMenup As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
End Class

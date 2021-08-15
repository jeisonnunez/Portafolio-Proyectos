<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmexcelMant
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
        Me.ltvExcel = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'ltvExcel
        '
        Me.ltvExcel.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12})
        Me.ltvExcel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ltvExcel.Location = New System.Drawing.Point(0, 0)
        Me.ltvExcel.Name = "ltvExcel"
        Me.ltvExcel.Size = New System.Drawing.Size(798, 356)
        Me.ltvExcel.TabIndex = 0
        Me.ltvExcel.UseCompatibleStateImageBehavior = False
        Me.ltvExcel.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nro Mant"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "NroProyecto"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "descripcion"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "FechaIni"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "FechaTerm"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "MontoContrsinITBMS"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "MontoCobrado"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "PendientexCobrar"
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Responsable"
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "MontosTrimestrales"
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "CtasTransito"
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "CtasPagadas"
        '
        'frmexcelMant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 356)
        Me.Controls.Add(Me.ltvExcel)
        Me.Name = "frmexcelMant"
        Me.Text = "frmexcelMant"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ltvExcel As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
End Class

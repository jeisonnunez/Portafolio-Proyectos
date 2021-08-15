<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHistoricoProy
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
        Me.ltvHistProy = New System.Windows.Forms.ListView
        Me.ChL = New System.Windows.Forms.ColumnHeader
        Me.ChC = New System.Windows.Forms.ColumnHeader
        Me.ChN = New System.Windows.Forms.ColumnHeader
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.btnReport = New System.Windows.Forms.Button
        Me.btnHist = New System.Windows.Forms.Button
        Me.btnCan = New System.Windows.Forms.Button
        Me.btnAcep = New System.Windows.Forms.Button
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ltvHistProy
        '
        Me.ltvHistProy.CheckBoxes = True
        Me.ltvHistProy.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChL, Me.ChC, Me.ChN})
        Me.ltvHistProy.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ltvHistProy.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ltvHistProy.FullRowSelect = True
        Me.ltvHistProy.Location = New System.Drawing.Point(0, 0)
        Me.ltvHistProy.Name = "ltvHistProy"
        Me.ltvHistProy.Size = New System.Drawing.Size(457, 484)
        Me.ltvHistProy.TabIndex = 0
        Me.ltvHistProy.UseCompatibleStateImageBehavior = False
        Me.ltvHistProy.View = System.Windows.Forms.View.Details
        '
        'ChL
        '
        Me.ChL.Text = "Listar"
        Me.ChL.Width = 73
        '
        'ChC
        '
        Me.ChC.Text = "Código"
        Me.ChC.Width = 81
        '
        'ChN
        '
        Me.ChN.Text = "Nombre"
        Me.ChN.Width = 269
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.ltvHistProy)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnReport)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnHist)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnCan)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnAcep)
        Me.SplitContainer1.Size = New System.Drawing.Size(457, 535)
        Me.SplitContainer1.SplitterDistance = 484
        Me.SplitContainer1.TabIndex = 1
        '
        'btnReport
        '
        Me.btnReport.Location = New System.Drawing.Point(179, 12)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(83, 23)
        Me.btnReport.TabIndex = 3
        Me.btnReport.Text = "Listar Reporte"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'btnHist
        '
        Me.btnHist.Location = New System.Drawing.Point(12, 12)
        Me.btnHist.Name = "btnHist"
        Me.btnHist.Size = New System.Drawing.Size(83, 23)
        Me.btnHist.TabIndex = 2
        Me.btnHist.Text = "Ver Hist"
        Me.btnHist.UseVisualStyleBackColor = True
        '
        'btnCan
        '
        Me.btnCan.Location = New System.Drawing.Point(371, 12)
        Me.btnCan.Name = "btnCan"
        Me.btnCan.Size = New System.Drawing.Size(83, 23)
        Me.btnCan.TabIndex = 1
        Me.btnCan.Text = "Cancelar"
        Me.btnCan.UseVisualStyleBackColor = True
        '
        'btnAcep
        '
        Me.btnAcep.Location = New System.Drawing.Point(268, 12)
        Me.btnAcep.Name = "btnAcep"
        Me.btnAcep.Size = New System.Drawing.Size(83, 23)
        Me.btnAcep.TabIndex = 0
        Me.btnAcep.Text = "Aceptar"
        Me.btnAcep.UseVisualStyleBackColor = True
        '
        'frmHistoricoProy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 535)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmHistoricoProy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Histórico Proyectos"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ltvHistProy As System.Windows.Forms.ListView
    Friend WithEvents ChL As System.Windows.Forms.ColumnHeader
    Friend WithEvents ChC As System.Windows.Forms.ColumnHeader
    Friend WithEvents ChN As System.Windows.Forms.ColumnHeader
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents btnAcep As System.Windows.Forms.Button
    Friend WithEvents btnCan As System.Windows.Forms.Button
    Friend WithEvents btnHist As System.Windows.Forms.Button
    Friend WithEvents btnReport As System.Windows.Forms.Button
End Class

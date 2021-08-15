<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusquedas
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
        Me.splcBus = New System.Windows.Forms.SplitContainer
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.lblCod = New System.Windows.Forms.Label
        Me.tbxCod = New System.Windows.Forms.TextBox
        Me.tbxDesc = New System.Windows.Forms.TextBox
        Me.lblDesc = New System.Windows.Forms.Label
        Me.splcBus.Panel1.SuspendLayout()
        Me.splcBus.Panel2.SuspendLayout()
        Me.splcBus.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'splcBus
        '
        Me.splcBus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splcBus.Location = New System.Drawing.Point(0, 0)
        Me.splcBus.Name = "splcBus"
        Me.splcBus.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splcBus.Panel1
        '
        Me.splcBus.Panel1.Controls.Add(Me.tbxDesc)
        Me.splcBus.Panel1.Controls.Add(Me.lblDesc)
        Me.splcBus.Panel1.Controls.Add(Me.tbxCod)
        Me.splcBus.Panel1.Controls.Add(Me.lblCod)
        '
        'splcBus.Panel2
        '
        Me.splcBus.Panel2.Controls.Add(Me.DataGridView1)
        Me.splcBus.Size = New System.Drawing.Size(394, 460)
        Me.splcBus.SplitterDistance = 88
        Me.splcBus.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(394, 368)
        Me.DataGridView1.TabIndex = 0
        '
        'lblCod
        '
        Me.lblCod.AutoSize = True
        Me.lblCod.Location = New System.Drawing.Point(13, 15)
        Me.lblCod.Name = "lblCod"
        Me.lblCod.Size = New System.Drawing.Size(40, 13)
        Me.lblCod.TabIndex = 0
        Me.lblCod.Text = "Código"
        '
        'tbxCod
        '
        Me.tbxCod.Location = New System.Drawing.Point(82, 10)
        Me.tbxCod.Name = "tbxCod"
        Me.tbxCod.Size = New System.Drawing.Size(194, 20)
        Me.tbxCod.TabIndex = 1
        '
        'tbxDesc
        '
        Me.tbxDesc.Location = New System.Drawing.Point(82, 36)
        Me.tbxDesc.Multiline = True
        Me.tbxDesc.Name = "tbxDesc"
        Me.tbxDesc.Size = New System.Drawing.Size(300, 38)
        Me.tbxDesc.TabIndex = 3
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Location = New System.Drawing.Point(13, 39)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(63, 13)
        Me.lblDesc.TabIndex = 2
        Me.lblDesc.Text = "Descripción"
        '
        'frmBusquedas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 460)
        Me.Controls.Add(Me.splcBus)
        Me.Name = "frmBusquedas"
        Me.Text = "frmBusquedas"
        Me.splcBus.Panel1.ResumeLayout(False)
        Me.splcBus.Panel1.PerformLayout()
        Me.splcBus.Panel2.ResumeLayout(False)
        Me.splcBus.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents splcBus As System.Windows.Forms.SplitContainer
    Friend WithEvents tbxDesc As System.Windows.Forms.TextBox
    Friend WithEvents lblDesc As System.Windows.Forms.Label
    Friend WithEvents tbxCod As System.Windows.Forms.TextBox
    Friend WithEvents lblCod As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class

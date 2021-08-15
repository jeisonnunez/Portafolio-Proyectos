<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcarteraT
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmcarteraT))
        Me.gbpParam = New System.Windows.Forms.GroupBox
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.tbxCodCli = New System.Windows.Forms.TextBox
        Me.chkSt = New System.Windows.Forms.CheckBox
        Me.lblSt = New System.Windows.Forms.Label
        Me.chkAll = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbGrupo = New System.Windows.Forms.ComboBox
        Me.btnAcep = New System.Windows.Forms.Button
        Me.btnCanc = New System.Windows.Forms.Button
        Me.TabClienteProyBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DtCliente = New ControlProyectos.dtCliente
        Me.TabClienteProyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tab_ClienteProyTableAdapter = New ControlProyectos.dtClienteTableAdapters.tab_ClienteProyTableAdapter
        Me.gbpParam.SuspendLayout()
        CType(Me.TabClienteProyBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabClienteProyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbpParam
        '
        Me.gbpParam.Controls.Add(Me.btnBuscar)
        Me.gbpParam.Controls.Add(Me.tbxCodCli)
        Me.gbpParam.Controls.Add(Me.chkSt)
        Me.gbpParam.Controls.Add(Me.lblSt)
        Me.gbpParam.Controls.Add(Me.chkAll)
        Me.gbpParam.Controls.Add(Me.Label1)
        Me.gbpParam.Controls.Add(Me.cmbGrupo)
        Me.gbpParam.Controls.Add(Me.btnAcep)
        Me.gbpParam.Controls.Add(Me.btnCanc)
        Me.gbpParam.Location = New System.Drawing.Point(12, 12)
        Me.gbpParam.Name = "gbpParam"
        Me.gbpParam.Size = New System.Drawing.Size(408, 139)
        Me.gbpParam.TabIndex = 1
        Me.gbpParam.TabStop = False
        Me.gbpParam.Text = "Parametros"
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(293, 55)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(28, 22)
        Me.btnBuscar.TabIndex = 138
        Me.btnBuscar.Text = "...:"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'tbxCodCli
        '
        Me.tbxCodCli.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxCodCli.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxCodCli.Location = New System.Drawing.Point(69, 55)
        Me.tbxCodCli.Name = "tbxCodCli"
        Me.tbxCodCli.Size = New System.Drawing.Size(218, 23)
        Me.tbxCodCli.TabIndex = 137
        Me.tbxCodCli.Tag = ""
        '
        'chkSt
        '
        Me.chkSt.AutoSize = True
        Me.chkSt.Location = New System.Drawing.Point(346, 61)
        Me.chkSt.Name = "chkSt"
        Me.chkSt.Size = New System.Drawing.Size(56, 17)
        Me.chkSt.TabIndex = 11
        Me.chkSt.Text = "Todos"
        Me.chkSt.UseVisualStyleBackColor = True
        '
        'lblSt
        '
        Me.lblSt.AutoSize = True
        Me.lblSt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSt.Location = New System.Drawing.Point(6, 60)
        Me.lblSt.Name = "lblSt"
        Me.lblSt.Size = New System.Drawing.Size(51, 17)
        Me.lblSt.TabIndex = 10
        Me.lblSt.Text = "Cliente"
        '
        'chkAll
        '
        Me.chkAll.AutoSize = True
        Me.chkAll.Location = New System.Drawing.Point(346, 35)
        Me.chkAll.Name = "chkAll"
        Me.chkAll.Size = New System.Drawing.Size(56, 17)
        Me.chkAll.TabIndex = 8
        Me.chkAll.Text = "Todos"
        Me.chkAll.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Sector"
        '
        'cmbGrupo
        '
        Me.cmbGrupo.FormattingEnabled = True
        Me.cmbGrupo.Location = New System.Drawing.Point(69, 33)
        Me.cmbGrupo.Name = "cmbGrupo"
        Me.cmbGrupo.Size = New System.Drawing.Size(218, 21)
        Me.cmbGrupo.TabIndex = 1
        Me.cmbGrupo.Text = "Seleccione"
        '
        'btnAcep
        '
        Me.btnAcep.Location = New System.Drawing.Point(69, 110)
        Me.btnAcep.Name = "btnAcep"
        Me.btnAcep.Size = New System.Drawing.Size(75, 23)
        Me.btnAcep.TabIndex = 3
        Me.btnAcep.Text = "Aceptar"
        Me.btnAcep.UseVisualStyleBackColor = True
        '
        'btnCanc
        '
        Me.btnCanc.Location = New System.Drawing.Point(229, 110)
        Me.btnCanc.Name = "btnCanc"
        Me.btnCanc.Size = New System.Drawing.Size(75, 23)
        Me.btnCanc.TabIndex = 2
        Me.btnCanc.Text = "Cancelar"
        Me.btnCanc.UseVisualStyleBackColor = True
        '
        'TabClienteProyBindingSource1
        '
        Me.TabClienteProyBindingSource1.DataMember = "tab_ClienteProy"
        Me.TabClienteProyBindingSource1.DataSource = Me.DtCliente
        '
        'DtCliente
        '
        Me.DtCliente.DataSetName = "dtCliente"
        Me.DtCliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabClienteProyBindingSource
        '
        Me.TabClienteProyBindingSource.DataMember = "tab_ClienteProy"
        Me.TabClienteProyBindingSource.DataSource = Me.DtCliente
        '
        'Tab_ClienteProyTableAdapter
        '
        Me.Tab_ClienteProyTableAdapter.ClearBeforeFill = True
        '
        'frmcarteraT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 160)
        Me.Controls.Add(Me.gbpParam)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmcarteraT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmcarteraT"
        Me.gbpParam.ResumeLayout(False)
        Me.gbpParam.PerformLayout()
        CType(Me.TabClienteProyBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabClienteProyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbpParam As System.Windows.Forms.GroupBox
    Friend WithEvents chkSt As System.Windows.Forms.CheckBox
    Friend WithEvents lblSt As System.Windows.Forms.Label
    Friend WithEvents chkAll As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbGrupo As System.Windows.Forms.ComboBox
    Friend WithEvents btnAcep As System.Windows.Forms.Button
    Friend WithEvents btnCanc As System.Windows.Forms.Button
    Friend WithEvents DtCliente As ControlProyectos.dtCliente
    Friend WithEvents TabClienteProyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tab_ClienteProyTableAdapter As ControlProyectos.dtClienteTableAdapters.tab_ClienteProyTableAdapter
    Friend WithEvents TabClienteProyBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents tbxCodCli As System.Windows.Forms.TextBox
End Class

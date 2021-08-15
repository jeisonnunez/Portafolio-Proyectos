Imports System.Diagnostics
Imports System.Windows.Forms

Public Class frmExplorer
    Public swProy As Integer = 0
    Public swUsu As Integer = 0
    Public swmt As Integer = 0
    Public swct As Integer = 0
    Public swrpt As Integer = 0
    Public swco As Integer = 0
    Public swpc As Integer = 0
    Public swCli As Integer = 0
    Public swImpD As Integer = 0
    Public swImp As Integer = 0
    Public swCxc As Integer = 0

    Public sdata As Integer
    ' Public swProy As Integer = 0
    Private Sub frmExplorer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If StrNivel = 0 Then
            habilita_deshabMenu()
        Else
            ToolStripButton1.Enabled = True
            ToolStripButton22.Enabled = True
            ToolStripButton13.Enabled = True
            ToolStripButton15.Enabled = True
            ToolStripButton16.Enabled = True
            ToolStripButton17.Enabled = True

            tsbtnMant1.Enabled = True
            ToolStripButton18.Enabled = True
            ToolStripButton29.Enabled = True
            ToolStripButton30.Enabled = True
            ToolStripButton19.Enabled = True
            ToolStripButton20.Enabled = True
            ToolStripButton26.Enabled = True
            ToolStripButton8.Enabled = True
            ToolStripButton9.Enabled = True
            ToolStripButton10.Enabled = True

            ToolStripButton27.Enabled = True
            ToolStripButton28.Enabled = True
            NewToolStripMenuItem.Enabled = True
            ToolStripMenuItem1.Enabled = True
            ToolStripMenuItem2.Enabled = True
            ToolStripMenuItem3.Enabled = True
            ToolStripMenuItem4.Enabled = True
            ToolStripMenuItem6.Enabled = True
            ToolStripMenuItem7.Enabled = True
            ToolStripMenuItem8.Enabled = True
            ToolStripMenuItemct.Enabled = True
            ToolStripButton24.Enabled = True
            ' ToolStripMenuItemxsec.Enabled = True
            ToolStripMenuItemg.Enabled = True
            'ToolStripMenuItemt.Enabled = True
            UsuariosToolStripMenuItem.Enabled = True
            ImToolStripMenuItem.Enabled = True
            HistToolStripMenuItem.Enabled = True
            PermisoAToolStripMenuItem.Enabled = True
            FormularioToolStripMenuItem.Enabled = True


        End If


        frmLocalidades.Close()
        Me.Text = Me.Text & " - " & strdescLoc & " Usuario:  " & UserLogin


    End Sub

    Public Function EstaAbierto(ByVal Myform As Form)
        Dim objForm As Form
        Dim blnAbierto As Boolean = False
        blnAbierto = False
        For Each objForm In My.Application.OpenForms
            If (Trim(objForm.Name) = Trim(Myform.Name)) Then
                blnAbierto = True

            End If
        Next
        Return blnAbierto
    End Function

   

    Private Sub SetUpListViewColumns()

        '' TODO: agregue código para configurar las columnas de la vista de lista
        'Dim lvColumnHeader As ColumnHeader

        '' La configuración del ancho de las columnas sólo se aplica a la vista actual, por lo que esta línea
        ''  define explícitamente la ListView que se va a mostrar en la vista SmallIcon
        ''  antes de configurar el ancho de columna
        'SetView(View.SmallIcon)

        'lvColumnHeader = ListView.Columns.Add("Columna1")
        '' Defina el ancho de las columnas de la vista SmallIcon en un valor lo suficientemente grande para que los elementos
        ''  no se solapen
        '' Tenga en cuenta que la segunda y la tercera columna no aparecen en la vista SmallIcon,
        ''  por lo que no es necesario definirlas para la vista SmallIcon
        'lvColumnHeader.Width = 90

        '' Cambie la vista Details y defina el ancho de las columnas
        ''  apropiado para la vista Details en un valor diferente al de la vista SmallIcon
        'SetView(View.Details)

        ' La primera columna debe ser un poco más grande en la vista Details que en
        '  la vista SmallIcon, y Columna2 y Columna3 requieren que el tamaño esté definido explícitamente
        '  para la vista Details
        'lvColumnHeader.Width = 100

        'lvColumnHeader = ListView.Columns.Add("Columna2")
        'lvColumnHeader.Width = 70

        'lvColumnHeader = ListView.Columns.Add("Columna3")
        'lvColumnHeader.Width = 70

    End Sub

   

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolBarToolStripMenuItem.Click
        'Alternar la visibilidad del elemento ToolStrip y el estado de activación del elemento de menú asociado
        ToolBarToolStripMenuItem.Checked = Not ToolBarToolStripMenuItem.Checked
        ToolStrip.Visible = ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StatusBarToolStripMenuItem.Click
        'Alternar la visibilidad del elemento StatusStrip y el estado de activación del elemento de menú asociado
        StatusBarToolStripMenuItem.Checked = Not StatusBarToolStripMenuItem.Checked
        StatusStrip.Visible = StatusBarToolStripMenuItem.Checked
    End Sub

    'Cambiar si se muestra o no el panel de carpetas
    Private Sub ToggleFoldersVisible()
        'Alternar primero el estado de activación del elemento de menú asociado
        FoldersToolStripMenuItem.Checked = Not FoldersToolStripMenuItem.Checked

        'Cambiar el botón de la barra de herramientas de carpetas para que esté sincronizado
        FoldersToolStripButton.Checked = FoldersToolStripMenuItem.Checked

        ' Contraiga el panel que contiene TreeView.
        Me.SplitContainer.Panel1Collapsed = Not FoldersToolStripMenuItem.Checked

    End Sub

    Private Sub FoldersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FoldersToolStripMenuItem.Click
        ToggleFoldersVisible()
    End Sub

    Public Sub FoldersToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FoldersToolStripButton.Click
        ToggleFoldersVisible()



    End Sub

    Private Sub SetView(ByVal View As System.Windows.Forms.View)
        'Averiguar qué elemento de menú se debe activar
     

        'Comprobar el elemento de menú adecuado y anular la selección de los demás bajo el menú Vistas
        'For Each MenuItem As ToolStripMenuItem In ListViewToolStripButton.DropDownItems
        '    If MenuItem Is MenuItemToCheck Then
        '        MenuItem.Checked = True
        '    Else
        '        MenuItem.Checked = False
        '    End If
        'Next

        'Por último, establecer la vista solicitada
        ' ListView.View = View
    End Sub

    Private Sub ListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SetView(View.List)
    End Sub

    Private Sub DetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SetView(View.Details)
    End Sub

    Private Sub LargeIconsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SetView(View.LargeIcon)
    End Sub

    Private Sub SmallIconsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SetView(View.SmallIcon)
    End Sub

    Private Sub TileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SetView(View.Tile)
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt"
        OpenFileDialog.ShowDialog(Me)

        Dim FileName As String = OpenFileDialog.FileName
        ' TODO: agregue el código para abrir el archivo
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt"
        SaveFileDialog.ShowDialog(Me)

        Dim FileName As String = SaveFileDialog.FileName
        ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
    End Sub

    Private Sub TreeView_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs)
        ' TODO: agregue el código para cambiar el contenido de listview basándose en el nodo seleccionado actualmente de treeview

    End Sub


    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        Application.ExitThread()
    End Sub

    
    Private Sub ToolStripButton3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click

        ' funcionRecogemenu()

        If swProy = 0 Then

            ToolStripButton1.Visible = True
            '  ToolStripButton12.Visible = True
            ToolStripButton13.Visible = True

            ToolStripButton22.Visible = True
            swProy = 1
        Else

            ToolStripButton1.Visible = False
            ' ToolStripButton12.Visible = False
            ToolStripButton13.Visible = False
            ToolStripButton22.Visible = False
            swProy = 0
        End If
    End Sub

    Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click

        f1 = frmMenuProyecto
        fcall = f1.Name
        cerrarForm()
        Me.ToolStripStatusLabel.Text = "Incluir Proyectos"
        If swF = 1 Then
            MsgBox("Existen formularios abiertos, por favor cierre el formulario", MsgBoxStyle.Exclamation)

        Else


            swMenuPpal = 1

            f1.Left = (Me.SplitContainer.Panel2.Width / 2) - (f1.Width / 2)

            f1.TopLevel = False

            f1.WindowState = FormWindowState.Maximized
            f1.Parent = Me.SplitContainer.Panel2
            f1.Dock = DockStyle.None

            Me.SplitContainer.Panel2.Controls.Add(f1)

            f1.Show()
        End If

        swF = 0
    End Sub

    Private Sub tsbtnMant_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If swmt = 0 Then

            tsbtnMant1.Visible = True
            swmt = 1
        Else

            tsbtnMant1.Visible = False
            swmt = 0
        End If
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        If swUsu = 0 Then

            ToolStripButton8.Visible = True
            ToolStripButton9.Visible = True
            ToolStripButton11.Visible = True
            swUsu = 1
        Else

            ToolStripButton8.Visible = False
            ToolStripButton9.Visible = False
            ToolStripButton11.Visible = False
            swUsu = 0
        End If
    End Sub

    Private Sub ToolStripStatusLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripStatusLabel.Click

    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click

        Try

        
            f7 = frmMenuProyectoConsulta
            fcall = f7.Name
            Me.ToolStripStatusLabel.Text = "Consultar Proyectos"
            cerrarForm()
            If swF = 1 Then
                MsgBox("Existen formularios abiertos, por favor cierre el formulario", MsgBoxStyle.Exclamation)

            Else
                swMenuPpal = 2
                'f.Size = New Size(Me.SplitContainer3.Panel2.Size.Width / 2, Me.SplitContainer3.Panel2.Size.Height / 2)
                f7.Top = (Me.SplitContainer.Panel2.Height / 2) - (f7.Height / 2)
                f7.Left = (Me.SplitContainer.Panel2.Width / 2) - (f7.Width / 2)

                f7.TopLevel = False

                f7.WindowState = FormWindowState.Maximized
                f7.Parent = Me.SplitContainer.Panel2
                f7.Dock = DockStyle.None

                Me.SplitContainer.Panel2.Controls.Add(f7)
                swCambioP = 1
                frmInicioproyectos.ShowDialog()



            End If

        Catch ex As Exception
            MsgBox("Error NewToolStripMenuItem", MsgBoxStyle.Exclamation)
        End Try
        swF = 0
    End Sub

   

    Private Sub ToolStripButton14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton14.Click
        If swct = 0 Then

            ToolStripButton15.Visible = True
            swct = 1
        Else

            ToolStripButton15.Visible = False
            swct = 0
        End If
    End Sub

    Private Sub tsbtnMant1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnMant1.Click
        f2 = frmMantenimientoProy
        fcall = f2.Name

        cerrarForm()
        If swF = 1 Then
            MsgBox("Existen formularios abiertos, por favor cierre el formulario", MsgBoxStyle.Exclamation)

        Else


            'f.Size = New Size(Me.SplitContainer3.Panel2.Size.Width / 2, Me.SplitContainer3.Panel2.Size.Height / 2)
            f2.Top = (Me.SplitContainer.Panel2.Height / 2) - (f2.Height / 2)
            f2.Left = (Me.SplitContainer.Panel2.Width / 2) - (f2.Width / 2)

            f2.TopLevel = False

            f2.WindowState = FormWindowState.Maximized
            f2.Parent = Me.SplitContainer.Panel2
            f2.Dock = DockStyle.None

            Me.SplitContainer.Panel2.Controls.Add(f2)
            f2.Show()
        End If
        swF = 0
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        If swco = 0 Then

            ToolStripButton17.Visible = True
            swco = 1
        Else

            ToolStripButton17.Visible = False
            swco = 0
        End If
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        If swCli = 0 Then

            ToolStripButton16.Visible = True
            swCli = 1
        Else

            ToolStripButton16.Visible = False
            swCli = 0
        End If
    End Sub

    Private Sub ToolStripButton15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton15.Click
        f5 = frmEmpresaCont
        fcall = f5.Name

        cerrarForm()
        If swF = 1 Then
            MsgBox("Existen formularios abiertos, por favor cierre el formulario", MsgBoxStyle.Exclamation)

        Else
            ToolStripStatusLabel.Text = "Empresas"
            'f.Size = New Size(Me.SplitContainer3.Panel2.Size.Width / 2, Me.SplitContainer3.Panel2.Size.Height / 2)
            f5.Top = (Me.SplitContainer.Panel2.Height / 2) - (f5.Height / 2)
            f5.Left = (Me.SplitContainer.Panel2.Width / 2) - (f5.Width / 2)

            f5.TopLevel = False

            f5.WindowState = FormWindowState.Maximized
            f5.Parent = Me.SplitContainer.Panel2
            f5.Dock = DockStyle.None

            Me.SplitContainer.Panel2.Controls.Add(f5)
            f5.Show()
            f5.llenarContratistas()
        End If
        swF = 0
    End Sub

    Private Sub ToolStripButton16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton16.Click
        f3 = frmClientes
        fcall = f3.Name

        cerrarForm()
        If swF = 1 Then
            MsgBox("Existen formularios abiertos, por favor cierre el formulario", MsgBoxStyle.Exclamation)

        Else

            ToolStripStatusLabel.Text = "Datos Clientes"
            'f.Size = New Size(Me.SplitContainer3.Panel2.Size.Width / 2, Me.SplitContainer3.Panel2.Size.Height / 2)
            f3.Top = (Me.SplitContainer.Panel2.Height / 2) - (f3.Height / 2)
            f3.Left = (Me.SplitContainer.Panel2.Width / 2) - (f3.Width / 2)

            f3.TopLevel = False

            f3.WindowState = FormWindowState.Maximized
            f3.Parent = Me.SplitContainer.Panel2
            f3.Dock = DockStyle.None

            Me.SplitContainer.Panel2.Controls.Add(f3)
            f3.Show()
        End If

        swF = 0
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click

        If swImpD = 0 Then

            ToolStripButton18.Visible = True
            ToolStripButton19.Visible = True
            ToolStripButton29.Visible = True
            ToolStripButton30.Visible = True
            ToolStripButton20.Visible = True
            swImpD = 1
        Else

            ToolStripButton18.Visible = False
            ToolStripButton19.Visible = False
            ToolStripButton29.Visible = False
            ToolStripButton30.Visible = False
            ToolStripButton20.Visible = False
            swImpD = 0
        End If
    End Sub

    Private Sub ToolStripButton18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton18.Click
        f6 = frmImportacion
        fcall = f6.Name

        cerrarForm()
        If swF = 1 Then
            MsgBox("Existen formularios abiertos, por favor cierre el formulario", MsgBoxStyle.Exclamation)

        Else

            FoldersToolStripButton_Click(1, Nothing)
            ToolStripStatusLabel.Text = "Importar Datos Proyectos"
            f6.Top = (Me.SplitContainer.Panel2.Height / 2) - (f6.Height / 2)
            f6.Left = (Me.SplitContainer.Panel2.Width / 2) - (f6.Width / 2)

            f6.TopLevel = False

            f6.WindowState = FormWindowState.Maximized
            f6.Parent = Me.SplitContainer.Panel2
            '  f6.Dock = DockStyle.Top

            Me.SplitContainer.Panel2.Controls.Add(f6)
            f6.Show()
        End If

        swF = 0
    End Sub

    Private Sub ToolStripButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton12.Click
        ' frmMenuProyectoConsulta.Show()


        f7 = frmMenuProyectoConsulta
        fcall = f7.Name
        Me.ToolStripStatusLabel.Text = "Consultar Proyectos"
        cerrarForm()
        If swF = 1 Then
            MsgBox("Existen formularios abiertos, por favor cierre el formulario", MsgBoxStyle.Exclamation)

        Else
            swMenuPpal = 2
            'f.Size = New Size(Me.SplitContainer3.Panel2.Size.Width / 2, Me.SplitContainer3.Panel2.Size.Height / 2)
            f7.Top = (Me.SplitContainer.Panel2.Height / 2) - (f7.Height / 2)
            f7.Left = (Me.SplitContainer.Panel2.Width / 2) - (f7.Width / 2)

            f7.TopLevel = False

            f7.WindowState = FormWindowState.Maximized
            f7.Parent = Me.SplitContainer.Panel2
            f7.Dock = DockStyle.None

            Me.SplitContainer.Panel2.Controls.Add(f7)
            swCambioP = 1
            frmInicioproyectos.ShowDialog()

            If swIninio = 1 Then

                f7.Close()
            Else
                f7.Show()

                f7.lblid.Text = stridProy
                f7.tbxCodp.Text = strCodProy
                ProyNro = f7.tbxCodp.Text
                f7.tbxDescr.Text = strDescProy

                ConsultarALLproyF7()
                f7.lbltiproy.Text = strCodProy & " - " & strDescProy
                swMenuPpal = 2

            End If

        End If

     
        swF = 0
    End Sub
    Sub cerrarForm()
        
        f1 = frmMenuProyecto
        f2 = frmMantenimientoProy
        f3 = frmClientes
        f4 = frmCobranzas
        f5 = frmEmpresaCont
        f6 = frmImportacion
        f8 = frmUsuarios
        f7 = frmMenuProyectoConsulta
        f11 = frmImportacionClientes
        f12 = frmImportacionContratista
        f14 = frmContrRec
        f15 = frmMenuProyectoIncluir
        f17 = frmpermisos
        f18 = frmClaves
        'f19 = frmReportes
        f20 = frmParamRepts
        f21 = frm_manttbBasiscas
        f22 = frmcarteraT
        f23 = frmInicioproyectos
        f24 = frmReportView
        f26 = frmImportacionFacturas
        f27 = frmImportacionResp
        Try


            Dim objForm As Form

            Dim i As Integer = My.Application.OpenForms.Count
            Dim f9 As New Form

            For Each objForm In My.Application.OpenForms
                f9.Name = objForm.Name

                If f1.Name = f9.Name Or f24.Name = f9.Name Or f23.Name = f9.Name Or f22.Name = f9.Name Or f21.Name = f9.Name Or f20.Name = f9.Name Or f18.Name = f9.Name Or f17.Name = f9.Name Or f9.Name = f2.Name Or f9.Name = f3.Name Or f9.Name = f4.Name Or f9.Name = f5.Name Or f9.Name = f6.Name Or f9.Name = f7.Name Or f9.Name = f8.Name Or f9.Name = f11.Name Or f9.Name = f12.Name Or f9.Name = f14.Name Or f9.Name = f15.Name Or f9.Name = f26.Name Or f9.Name = f27.Name Then
                    swF = 1
                End If



                'If f9.Name = "frmPresentacion" Then
                '    f9.Close()
                'End If

                'If f9.Name = "frmLoginPass" Then
                '    f9.Close()
                'End If


            Next

        Catch ex As Exception
            MsgBox("Error en funcion  cerrarForm()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try

    End Sub

    Private Sub ToolStripButton19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton19.Click
        f11 = frmImportacionClientes
        fcall = f11.Name

        cerrarForm()
        If swF = 1 Then
            MsgBox("Existen formularios abiertos, por favor cierre el formulario", MsgBoxStyle.Exclamation)

        Else
            ToolStripStatusLabel.Text = "Importar Datos Clientes"

            f11.Top = (Me.SplitContainer.Panel2.Height / 2) - (f12.Height / 2)
            f11.Left = (Me.SplitContainer.Panel2.Width / 2) - (f12.Width / 2)

            f11.TopLevel = False

            f11.WindowState = FormWindowState.Maximized
            f11.Parent = Me.SplitContainer.Panel2
            f11.Dock = DockStyle.None

            Me.SplitContainer.Panel2.Controls.Add(f11)
            f11.Show()
        End If

        swF = 0
    End Sub

    Private Sub ToolStripButton20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton20.Click
        f12 = frmImportacionContratista
        fcall = f2.Name

        cerrarForm()
        If swF = 1 Then
            MsgBox("Existen formularios abiertos, por favor cierre el formulario", MsgBoxStyle.Exclamation)

        Else
            ToolStripStatusLabel.Text = "Importar Datos Contratistas"

            f12.Top = (Me.SplitContainer.Panel2.Height / 2) - (f12.Height / 2)
            f12.Left = (Me.SplitContainer.Panel2.Width / 2) - (f12.Width / 2)

            f12.TopLevel = False

            f12.WindowState = FormWindowState.Maximized
            f12.Parent = Me.SplitContainer.Panel2
            f12.Dock = DockStyle.None

            Me.SplitContainer.Panel2.Controls.Add(f12)
            f12.Show()
        End If

        swF = 0
    End Sub

    Private Sub ToolStripButton17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton17.Click
  

        'f15 = frmMenuProyectoIncluir
        'fcall = f15.Name
        'cerrarForm()
        'Me.ToolStripStatusLabel.Text = "Proyectos/Facturas"
        'If swF = 1 Then
        '    MsgBox("Existen formularios abiertos, por favor cierre el formulario", MsgBoxStyle.Exclamation)

        'Else

        '    swMenuPpal = 1

        '    f15.Top = (Me.SplitContainer.Panel2.Height / 2) - (f15.Height / 2)
        '    f15.Left = (Me.SplitContainer.Panel2.Width / 2) - (f15.Width / 2)

        '    f15.TopLevel = False

        '    f15.WindowState = FormWindowState.Maximized
        '    f15.Parent = Me.SplitContainer.Panel2
        '    f15.Dock = DockStyle.None

        '    Me.SplitContainer.Panel2.Controls.Add(f15)
        '    swMenuPpal = 1
        '    swCambioP = 1
        '    frmInicioproyectos.ShowDialog()



        'End If
        f23 = frmInicioproyectos

        fcall = f23.Name
        Me.ToolStripStatusLabel.Text = "Factura CxC Proyectos"
        cerrarForm()
        If swF = 1 Then
            MsgBox("Existen formularios abiertos, por favor cierre el formulario", MsgBoxStyle.Exclamation, "Control Proyectos")

        Else
            swMenuPpal = 1
            'f.Size = New Size(Me.SplitContainer3.Panel2.Size.Width / 2, Me.SplitContainer3.Panel2.Size.Height / 2)
            f23.Top = (Me.SplitContainer.Panel2.Height / 2) - (f23.Height / 2)
            f23.Left = (Me.SplitContainer.Panel2.Width / 2) - (f23.Width / 2)

            f23.TopLevel = False

            f23.WindowState = FormWindowState.Maximized
            f23.Parent = Me.SplitContainer.Panel2
            f23.Dock = DockStyle.None

            Me.SplitContainer.Panel2.Controls.Add(f23)
            swCambioP = 1
            f23.Show()

        End If


        swF = 0
        swIninio = 0
    End Sub

    Private Sub ToolStripButton22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'revisarDatosPrev()

    End Sub

    Private Sub ToolStripButton23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'importarDatos()

    End Sub

    'Sub revisarDatosPrev()

    '    Dim fecha As String = ""
    '    Dim fechi As Date
    '    Dim monto As Decimal
    '    Try
    '        'VALIDO CAMPOS VACIOS

    '        If f6.dtgDatosProyecto.RowCount > 0 Then

    '            For Fila = 0 To f6.dtgDatosProyecto.RowCount - 1

    '                For Colum = 0 To Fila

    '                    If f6.dtgDatosProyecto.Rows(Fila).Cells(Colum).Value() Is DBNull.Value Then
    '                        MsgBox("Existen Campos Vacios, por favor revise el archivo", MsgBoxStyle.Critical, "Control Proyectos")
    '                        f6.dtgDatosProyecto.CurrentCell = f6.dtgDatosProyecto(Colum, Fila)
    '                        Exit Sub
    '                    End If


    '                Next Colum

    '            Next Fila
    '        End If




    '        If f6.dtgDatosProyecto.RowCount > 0 Then
    '            'VALIDO FECHA Try
    '            For Fila = 1 To f6.dtgDatosProyecto.RowCount - 1

    '                Try
    '                    fechi = f6.dtgDatosProyecto.Rows(Fila).Cells(4).Value()
    '                    fecha = Format(fechi, "yyyy-MM-dd")

    '                    If IsDate(fecha) Then
    '                        sdata = 0
    '                    Else
    '                        sdata = 1
    '                        f6.dtgDatosProyecto.CurrentCell = f6.dtgDatosProyecto(4, Fila)
    '                        MsgBox("FECHA Invalida", MsgBoxStyle.Critical, "Control Proyectos")
    '                        Exit Sub
    '                    End If

    '                Catch ex As Exception
    '                    sdata = 1
    '                    f6.dtgDatosProyecto.CurrentCell = f6.dtgDatosProyecto(4, Fila)
    '                    MsgBox("FECHA Invalida", MsgBoxStyle.Critical, "Control Proyectos")
    '                    Exit Sub
    '                End Try

    '            Next Fila
    '        End If

    '        'VALIDO MONTO
    '        For Fila = 1 To f6.dtgDatosProyecto.RowCount - 1


    '            If f6.dtgDatosProyecto.Rows(Fila).Cells(4).Value() Is DBNull.Value Then

    '                MsgBox("Existen Campos Vacios", MsgBoxStyle.Critical, "Control Proyectos")
    '                sdata = 1
    '            Else
    '                Try
    '                    monto = f6.dtgDatosProyecto.Rows(Fila).Cells(6).Value()

    '                    If monto > 0 Then
    '                        sdata = 0
    '                    Else
    '                        sdata = 1
    '                        f6.dtgDatosProyecto.CurrentCell = f6.dtgDatosProyecto(6, Fila)
    '                        ' DataGridView1.Rows(Fila).Cells(6).Selected
    '                        MsgBox("MONTO Invalido", MsgBoxStyle.Critical, "Control Proyectos")
    '                        Exit Sub

    '                    End If
    '                Catch ex As Exception
    '                    sdata = 1
    '                    f6.dtgDatosProyecto.CurrentCell = f6.dtgDatosProyecto(6, Fila)
    '                    ' DataGridView1.Rows(Fila).Cells(6).Selected
    '                    MsgBox("MONTO Invalido", MsgBoxStyle.Critical, "Control Proyectos")
    '                    Exit Sub
    '                End Try


    '            End If
    '        Next Fila


    '        sdata = 0
    '        If sdata = 0 Then
    '            MsgBox("Datos listos para Importar", MsgBoxStyle.Information, "Control Proyectos")
    '            ToolStripButton2.Enabled = True
    '        End If

    '    Catch ex As Exception
    '        MsgBox("Error en funcion revisarDatosPrev()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
    '    End Try

    'End Sub
    Private Function Exist(ByVal id As String) As Boolean
        ConexionSQL()
        Dim strrecor As New ADODB.Recordset
        Dim codigo As String = id
        Dim i As Integer = 0
        Try
            strrecor = cntSQL.Execute("SELECT CODIGO,DESCRIPCION,MARCA,MODELO, FECHA_ADQ, TIPO,  TIPO, MONTO_ADQ FROM  a2CActivos WHERE CODIGO='" & codigo & "'")
            Do While Not strrecor.EOF

                i = 1
                Exit Do
            Loop

            If i = 0 Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception

            MsgBox("Error en funcion Exist" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try


    End Function

    'Sub importarDatos()
    '    ConexionSQL()
    '    Dim fecha As String = ""
    '    Dim fechi As Date
    '    Dim monto As Decimal

    '    Try
    '        If f6.dtgDatosProyecto.RowCount > 0 Then
    '            For Fila = 0 To f6.dtgDatosProyecto.RowCount

    '                fechi = f6.dtgDatosProyecto.Rows(Fila).Cells(4).Value()
    '                fecha = Format(fechi, "yyyy-MM-dd")

    '                monto = f6.dtgDatosProyecto.Rows(Fila).Cells(6).Value()

    '                If Exist(f6.dtgDatosProyecto.Rows(Fila).Cells(0).Value) = True Then
    '                    'ACTUALIZA EL CODIGO
    '                    cntSQL.Execute("UPDATE a2CActivos set DESCRIPCION= '" & f6.dtgDatosProyecto.Rows(Fila).Cells(1).Value & "',MARCA= '" & f6.dtgDatosProyecto.Rows(Fila).Cells(2).Value & "', " _
    '                                                     & " MODELO= '" & f6.dtgDatosProyecto.Rows(Fila).Cells(3).Value & "', " _
    '                                                     & " FECHA_ADQ= '" & fecha & "', " _
    '                                                     & " TIPO= '" & f6.dtgDatosProyecto.Rows(Fila).Cells(5).Value & "', " _
    '                                                     & " MONTO_ADQ = " & Replace(monto, ",", ".") & "")


    '                Else
    '                    'INSERTA EL CODIGO
    '                    cntSQL.Execute("INSERT INTO a2CActivos(CODIGO,DESCRIPCION,MARCA,MODELO, FECHA_ADQ, TIPO, MONTO_ADQ) VALUES ('" & _
    '                                                     f6.dtgDatosProyecto.Rows(Fila).Cells(0).Value & "', '" & f6.dtgDatosProyecto.Rows(Fila).Cells(1).Value & "', '" & _
    '                                                     f6.dtgDatosProyecto.Rows(Fila).Cells(2).Value & "', '" & f6.dtgDatosProyecto.Rows(Fila).Cells(3).Value & "',  '" & _
    '                                                     fecha & "', '" & f6.dtgDatosProyecto.Rows(Fila).Cells(5).Value & "'," & Replace(monto, ",", ".") & " )")

    '                End If

    '                If Fila = f6.dtgDatosProyecto.RowCount - 1 Then
    '                    MsgBox("Datos Importados", MsgBoxStyle.Information, "Control Proyectos")
    '                    ToolStripButton2.Enabled = False
    '                    f6.dtgDatosProyecto.Visible = False
    '                    Exit Sub
    '                End If

    '            Next Fila

    '        End If

    '    Catch ex As Exception
    '        MsgBox("Error en funcion  importarDatos()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
    '    End Try

    'End Sub

   
    Public Function ImportExcellToDataGridView(ByRef path As String, ByVal Datagrid As DataGridView)
        Try

            Dim stConexion As String = "Provider=Microsoft.ACE.Oledb.12.0;Data Source=" & path & ";Extended Properties=""Excel 12.0;HDR=YES;IMEX=1"""
            Dim cnConex As New OleDb.OleDbConnection(stConexion)
            Dim Cmd As New OleDb.OleDbCommand("Select * From [CUSA$]")
            Dim Ds As New DataSet
            Dim Da As New OleDb.OleDbDataAdapter
            Dim Dt As New DataTable
            cnConex.Open()
            Cmd.Connection = cnConex
            Da.SelectCommand = Cmd
            Da.Fill(Ds)
            Dt = Ds.Tables(0)
            Datagrid.Columns.Clear()
            Datagrid.DataSource = Dt

            If Datagrid.RowCount > 0 Then
                Datagrid.Visible = True


            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return True
    End Function

  
   
    Private Sub ToolStripButton25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        f6.Close()

    End Sub

    
    Private Sub ToolStripButton26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim openFD As New OpenFileDialog()
        'With openFD
        '    .Title = "Seleccionar archivos"
        '    .Filter = "Archivos Excel(*.xls;*.xlsx)|*.xls;*xlsx|Todos los archivos(*.*)|*.*"
        '    .Multiselect = False
        '    .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        '    If .ShowDialog = Windows.Forms.DialogResult.OK Then
        '        ImportExcellToDataGridView(.FileName, f6.dtgDatosProyecto)
        '    End If
        'End With
    End Sub

   
    Private Sub CambiarAparienciaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiarAparienciaToolStripMenuItem.Click

    End Sub

    Private Sub SilverToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SilverToolStripMenuItem.Click

    End Sub

    Private Sub ToolStripButton22_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton22.Click
        f23 = frmInicioproyectos
        fcall = f23.Name

        cerrarForm()
        Me.ToolStripStatusLabel.Text = "Consultar Proyectos"

        If swF = 1 Then
            MsgBox("Existen formularios abiertos, por favor cierre el formulario", MsgBoxStyle.Exclamation, "Control Proyectos")

        Else
            swMenuPpal = 2
            'f.Size = New Size(Me.SplitContainer3.Panel2.Size.Width / 2, Me.SplitContainer3.Panel2.Size.Height / 2)
            f23.Top = (Me.SplitContainer.Panel2.Height / 2) - (f23.Height / 2)
            f23.Left = (Me.SplitContainer.Panel2.Width / 2) - (f23.Width / 2)

            f23.TopLevel = False

            f23.WindowState = FormWindowState.Maximized
            f23.Parent = Me.SplitContainer.Panel2
            f23.Dock = DockStyle.None

            Me.SplitContainer.Panel2.Controls.Add(f23)
            swCambioP = 1
            f23.Show()

        End If


        swF = 0
    End Sub

    Private Sub ToolStripButton13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton13.Click
        f23 = frmInicioproyectos
        fcall = f23.Name

        cerrarForm()
        Me.ToolStripStatusLabel.Text = "Pasar Proyectos Historico"


        If swF = 1 Then
            MsgBox("Existen formularios abiertos, por favor cierre el formulario", MsgBoxStyle.Exclamation, "Control Proyectos")

        Else
            swMenuPpal = 2
            'f.Size = New Size(Me.SplitContainer3.Panel2.Size.Width / 2, Me.SplitContainer3.Panel2.Size.Height / 2)
            f23.Top = (Me.SplitContainer.Panel2.Height / 2) - (f23.Height / 2)
            f23.Left = (Me.SplitContainer.Panel2.Width / 2) - (f23.Width / 2)

            f23.TopLevel = False

            f23.WindowState = FormWindowState.Maximized
            f23.Parent = Me.SplitContainer.Panel2
            f23.Dock = DockStyle.None

            Me.SplitContainer.Panel2.Controls.Add(f23)
            swCambioP = 3
            f23.Show()

        End If


        swF = 0
    End Sub

    Private Sub ToolStripSeparator1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripSeparator1.Click

    End Sub

    Private Sub ToolStripButton24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton24.Click

        'f16 = frmPresCtas
        'fcall = f16.Name
        'Me.ToolStripStatusLabel.Text = "Presentación de Cuentas"
        'cerrarForm()
        'If swF = 1 Then
        '    MsgBox("Existen formularios abiertos, por favor cierre el formulario", MsgBoxStyle.Exclamation, "Control Proyectos")

        'Else
        '    swMenuPpal = 4

        '    f16.Top = (Me.SplitContainer.Panel2.Height / 2) - (f7.Height / 2)
        '    f16.Left = (Me.SplitContainer.Panel2.Width / 2) - (f7.Width / 2)

        '    f16.TopLevel = False

        '    f16.WindowState = FormWindowState.Maximized
        '    f16.Parent = Me.SplitContainer.Panel2
        '    f16.Dock = DockStyle.None

        '    Me.SplitContainer.Panel2.Controls.Add(f16)
        '    swCambioP = 1
        '    frmInicioproyectos.ShowDialog()



        'End If

        f23 = frmInicioproyectos

        fcall = f23.Name
        Me.ToolStripStatusLabel.Text = "Consultar Proyectos"
        cerrarForm()

        If swF = 1 Then
            MsgBox("Existen formularios abiertos, por favor cierre el formulario", MsgBoxStyle.Exclamation, "Control Proyectos")

        Else
            swMenuPpal = 4
            'f.Size = New Size(Me.SplitContainer3.Panel2.Size.Width / 2, Me.SplitContainer3.Panel2.Size.Height / 2)
            f23.Top = (Me.SplitContainer.Panel2.Height / 2) - (f23.Height / 2)
            f23.Left = (Me.SplitContainer.Panel2.Width / 2) - (f23.Width / 2)

            f23.TopLevel = False

            f23.WindowState = FormWindowState.Maximized
            f23.Parent = Me.SplitContainer.Panel2
            f23.Dock = DockStyle.None

            Me.SplitContainer.Panel2.Controls.Add(f23)
            swCambioP = 1
            f23.Show()

        End If



        swF = 0
    End Sub

    Private Sub ToolStripButton23_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton23.Click
        If swpc = 0 Then

            ToolStripButton24.Visible = True
            swpc = 1
        Else

            ToolStripButton24.Visible = False
            swpc = 0
        End If

       
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        f5 = frmEmpresaCont
        fcall = f5.Name

        cerrarForm()
        If swF = 1 Then
            MsgBox("Existen formularios abiertos, por favor cierre el formulario", MsgBoxStyle.Exclamation, "Control Proyectos")

        Else
            ToolStripStatusLabel.Text = "Empresas"
            'f.Size = New Size(Me.SplitContainer3.Panel2.Size.Width / 2, Me.SplitContainer3.Panel2.Size.Height / 2)
            f5.Top = (Me.SplitContainer.Panel2.Height / 2) - (f5.Height / 2)
            f5.Left = (Me.SplitContainer.Panel2.Width / 2) - (f5.Width / 2)

            f5.TopLevel = False

            f5.WindowState = FormWindowState.Maximized
            f5.Parent = Me.SplitContainer.Panel2
            f5.Dock = DockStyle.None

            Me.SplitContainer.Panel2.Controls.Add(f5)
            f5.Show()
            f5.llenarContratistas()
        End If
        swF = 0
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        f3 = frmClientes
        fcall = f3.Name

        cerrarForm()
        If swF = 1 Then
            MsgBox("Existen formularios abiertos, por favor cierre el formulario", MsgBoxStyle.Exclamation, "Control Proyectos")

        Else

            ToolStripStatusLabel.Text = "Datos Clientes"
            'f.Size = New Size(Me.SplitContainer3.Panel2.Size.Width / 2, Me.SplitContainer3.Panel2.Size.Height / 2)
            f3.Top = (Me.SplitContainer.Panel2.Height / 2) - (f3.Height / 2)
            f3.Left = (Me.SplitContainer.Panel2.Width / 2) - (f3.Width / 2)

            f3.TopLevel = False

            f3.WindowState = FormWindowState.Maximized
            f3.Parent = Me.SplitContainer.Panel2
            f3.Dock = DockStyle.None

            Me.SplitContainer.Panel2.Controls.Add(f3)
            f3.Show()
        End If

        swF = 0
    End Sub

    Private Sub ToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem7.Click
        f15 = frmMenuProyectoIncluir
        fcall = f15.Name
        cerrarForm()
        Me.ToolStripStatusLabel.Text = "Modificar Proyectos"
        If swF = 1 Then
            MsgBox("Existen formularios abiertos, por favor cierre el formulario", MsgBoxStyle.Exclamation, "Control Proyectos")

        Else

            swMenuPpal = 1

            f15.Top = (Me.SplitContainer.Panel2.Height / 2) - (f15.Height / 2)
            f15.Left = (Me.SplitContainer.Panel2.Width / 2) - (f15.Width / 2)

            f15.TopLevel = False

            f15.WindowState = FormWindowState.Maximized
            f15.Parent = Me.SplitContainer.Panel2
            f15.Dock = DockStyle.None

            Me.SplitContainer.Panel2.Controls.Add(f15)
            swMenuPpal = 1
            swCambioP = 1
            frmInicioproyectos.ShowDialog()

            'If swIninio = 1 Then

            '    f15.Close()
            'Else
            '    f15.Show()

            '    'f15.lblid.Text = stridProy
            '    'f15.tbxCodp.Text = strCodProy
            '    'ProyNro = f15.tbxCodp.Text
            '    'f15.tbxDescr.Text = strDescProy
            '    swMenuPpal = 1
            '    ConsultarALLproyF15()
            '    f15.lbltiproy.Text = strCodProy & " - " & strDescProy


            'End If

        End If

        swF = 0
        swIninio = 0
    End Sub

    Private Sub ToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem6.Click
        f2 = frmMantenimientoProy
        fcall = f2.Name

        cerrarForm()
        If swF = 1 Then
            MsgBox("Existen formularios abiertos, por favor cierre el formulario", MsgBoxStyle.Exclamation, "Control Proyectos")

        Else


            'f.Size = New Size(Me.SplitContainer3.Panel2.Size.Width / 2, Me.SplitContainer3.Panel2.Size.Height / 2)
            f2.Top = (Me.SplitContainer.Panel2.Height / 2) - (f2.Height / 2)
            f2.Left = (Me.SplitContainer.Panel2.Width / 2) - (f2.Width / 2)

            f2.TopLevel = False

            f2.WindowState = FormWindowState.Maximized
            f2.Parent = Me.SplitContainer.Panel2
            f2.Dock = DockStyle.None

            Me.SplitContainer.Panel2.Controls.Add(f2)
            f2.Show()
        End If
        swF = 0
    End Sub

    Private Sub ToolStripMenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem8.Click
        f16 = frmPresCtas
        fcall = f16.Name
        Me.ToolStripStatusLabel.Text = "Presentación de Cuentas"
        cerrarForm()
        If swF = 1 Then
            MsgBox("Existen formularios abiertos, por favor cierre el formulario", MsgBoxStyle.Exclamation, "Control Proyectos")

        Else
            swMenuPpal = 4

            f16.Top = (Me.SplitContainer.Panel2.Height / 2) - (f7.Height / 2)
            f16.Left = (Me.SplitContainer.Panel2.Width / 2) - (f7.Width / 2)

            f16.TopLevel = False

            f16.WindowState = FormWindowState.Maximized
            f16.Parent = Me.SplitContainer.Panel2
            f16.Dock = DockStyle.None

            Me.SplitContainer.Panel2.Controls.Add(f16)
            swCambioP = 1
            frmInicioproyectos.ShowDialog()

            'If swIninio = 1 Then

            '    f16.Close()
            'Else
            '    f16.Show()



            '    '  ConsultarALLproyF7()
            '    f16.lbltiproy.Text = strCodProy & " - " & strDescProy
            '    swMenuPpal = 4

            'End If

        End If


        swF = 0
    End Sub

    Private Sub ProyectosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProyectosToolStripMenuItem.Click
        f6 = frmImportacion
        fcall = f6.Name

        cerrarForm()
        If swF = 1 Then
            MsgBox("Existen formularios abiertos, por favor cierre el formulario", MsgBoxStyle.Exclamation, "Control Proyectos")

        Else
            FoldersToolStripButton_Click(1, Nothing)

            ToolStripStatusLabel.Text = "Importar Datos Proyectos"
            f6.Top = (Me.SplitContainer.Panel2.Height / 2) - (f6.Height / 2)
            f6.Left = (Me.SplitContainer.Panel2.Width / 2) - (f6.Width / 2)

            f6.TopLevel = False

            f6.WindowState = FormWindowState.Maximized
            f6.Parent = Me.SplitContainer.Panel2
            '  f6.Dock = DockStyle.Top

            Me.SplitContainer.Panel2.Controls.Add(f6)
            f6.Show()
        End If

        swF = 0
    End Sub

    Private Sub ContratistasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContratistasToolStripMenuItem.Click
        f12 = frmImportacionContratista
        fcall = f2.Name

        cerrarForm()
        If swF = 1 Then
            MsgBox("Existen formularios abiertos, por favor cierre el formulario", MsgBoxStyle.Exclamation, "Control Proyectos")

        Else
            ToolStripStatusLabel.Text = "Importar Datos Contratistas"
            FoldersToolStripButton_Click(1, Nothing)
            f12.Top = (Me.SplitContainer.Panel2.Height / 2) - (f12.Height / 2)
            f12.Left = (Me.SplitContainer.Panel2.Width / 2) - (f12.Width / 2)

            f12.TopLevel = False

            f12.WindowState = FormWindowState.Maximized
            f12.Parent = Me.SplitContainer.Panel2
            f12.Dock = DockStyle.None

            Me.SplitContainer.Panel2.Controls.Add(f12)
            f12.Show()
        End If

        swF = 0
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        f11 = frmImportacionClientes
        fcall = f11.Name

        cerrarForm()
        If swF = 1 Then
            MsgBox("Existen formularios abiertos, por favor cierre el formulario", MsgBoxStyle.Exclamation, "Control Proyectos")

        Else
            ToolStripStatusLabel.Text = "Importar Datos Clientes"
            FoldersToolStripButton_Click(1, Nothing)
            f11.Top = (Me.SplitContainer.Panel2.Height / 2) - (f12.Height / 2)
            f11.Left = (Me.SplitContainer.Panel2.Width / 2) - (f12.Width / 2)

            f11.TopLevel = False

            f11.WindowState = FormWindowState.Maximized
            f11.Parent = Me.SplitContainer.Panel2
            f11.Dock = DockStyle.None

            Me.SplitContainer.Panel2.Controls.Add(f11)
            f11.Show()
        End If

        swF = 0
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Application.ExitThread()
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click

        f7 = frmMenuProyectoConsulta
        fcall = f7.Name
        Me.ToolStripStatusLabel.Text = "Consultar Proyectos"
        cerrarForm()
        If swF = 1 Then
            MsgBox("Existen formularios abiertos, por favor cierre el formulario", MsgBoxStyle.Exclamation, "Control Proyectos")

        Else
            swMenuPpal = 2
            'f.Size = New Size(Me.SplitContainer3.Panel2.Size.Width / 2, Me.SplitContainer3.Panel2.Size.Height / 2)
            f7.Top = (Me.SplitContainer.Panel2.Height / 2) - (f7.Height / 2)
            f7.Left = (Me.SplitContainer.Panel2.Width / 2) - (f7.Width / 2)

            f7.TopLevel = False

            f7.WindowState = FormWindowState.Maximized
            f7.Parent = Me.SplitContainer.Panel2
            f7.Dock = DockStyle.None

            Me.SplitContainer.Panel2.Controls.Add(f7)
            swCambioP = 1
            frmInicioproyectos.ShowDialog()

            'If swIninio = 1 Then

            '    f7.Close()
            'Else

            '    f7.Show()
            '    f7.tbxMes.Parent = Nothing
            '    f7.lblid.Text = stridProy
            '    f7.tbxCodp.Text = strCodProy
            '    ProyNro = f7.tbxCodp.Text
            '    f7.tbxDescr.Text = strDescProy

            '    ConsultarALLproyF7()
            '    f7.lbltiproy.Text = strCodProy & " - " & strDescProy
            '    swMenuPpal = 2

            'End If

        End If


        swF = 0
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        f7 = frmMenuProyectoConsulta
        fcall = f7.Name
        Me.ToolStripStatusLabel.Text = "Consultar Proyectos"
        cerrarForm()
        If swF = 1 Then
            MsgBox("Existen formularios abiertos, por favor cierre el formulario", MsgBoxStyle.Exclamation, "Control Proyectos")

        Else
            swMenuPpal = 2
            'f.Size = New Size(Me.SplitContainer3.Panel2.Size.Width / 2, Me.SplitContainer3.Panel2.Size.Height / 2)
            f7.Top = (Me.SplitContainer.Panel2.Height / 2) - (f7.Height / 2)
            f7.Left = (Me.SplitContainer.Panel2.Width / 2) - (f7.Width / 2)

            f7.TopLevel = False

            f7.WindowState = FormWindowState.Maximized
            f7.Parent = Me.SplitContainer.Panel2
            f7.Dock = DockStyle.None

            Me.SplitContainer.Panel2.Controls.Add(f7)
            swCambioP = 1
            frmInicioproyectos.ShowDialog()
            f7.tbcProy.SelectedTab = f7.tbcProy.TabPages(2)

            'If swIninio = 1 Then

            '    f7.Close()
            'Else

            '    f7.Show()
            '    f7.tbpDbas.Parent = Nothing
            '    f7.lblid.Text = stridProy
            '    f7.tbxCodp.Text = strCodProy
            '    ProyNro = f7.tbxCodp.Text
            '    f7.tbxDescr.Text = strDescProy

            '    ConsultarALLproyF7()
            '    f7.lbltiproy.Text = strCodProy & " - " & strDescProy
            '    swMenuPpal = 2

            'End If

        End If


        swF = 0
    End Sub

   
    Private Sub ToolStripButton21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton21.Click
        If swmt = 0 Then

            Me.tsbtnMant1.Visible = True
            swmt = 1
        Else

            Me.tsbtnMant1.Visible = False
            swmt = 0
        End If
    End Sub

    Private Sub ToolStripButton25_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton25.Click

        Me.ToolStripButton27.Visible = False
        Me.ToolStripButton28.Visible = False
        If swrpt = 0 Then

            Me.ToolStripButton26.Visible = True
            Me.ToolStripButton10.Visible = True
            'Me.ToolStripButton27.Visible = True
            'Me.ToolStripButton28.Visible = True
            swrpt = 1
        Else

            Me.ToolStripButton26.Visible = False
            Me.ToolStripButton10.Visible = False
            'Me.ToolStripButton27.Visible = False
            'Me.ToolStripButton28.Visible = False
            swrpt = 0
        End If
    End Sub

    Private Sub ToolStripButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton8.Click
        If StrNivel = 1 Then

            f8 = frmUsuarios
            fcall = f8.Name

            cerrarForm()
            If swF = 1 Then
                MsgBox("Existen formularios abiertos, por favor cierre el formulario", MsgBoxStyle.Exclamation, "Control Proyectos")

            Else

                sw = 6
                'f.Size = New Size(Me.SplitContainer3.Panel2.Size.Width / 2, Me.SplitContainer3.Panel2.Size.Height / 2)
                f8.Top = (Me.SplitContainer.Panel2.Height / 2) - (f2.Height / 2)
                f8.Left = (Me.SplitContainer.Panel2.Width / 2) - (f2.Width / 2)

                f8.TopLevel = False

                f8.WindowState = FormWindowState.Maximized
                f8.Parent = Me.SplitContainer.Panel2
                f8.Dock = DockStyle.None

                Me.SplitContainer.Panel2.Controls.Add(f8)
                f8.Show()
            End If
        Else
            MsgBox("Usuario no tiene permisos", MsgBoxStyle.Exclamation, "Control Proyectos")
        End If
        swF = 0
    End Sub

    Private Sub ToolStripButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        f8 = frmUsuarios
        fcall = f8.Name

        cerrarForm()
        If swF = 1 Then
            MsgBox("Existen formularios abiertos, por favor cierre el formulario", MsgBoxStyle.Exclamation, "Control Proyectos")

        Else

            sw = 6
            'f.Size = New Size(Me.SplitContainer3.Panel2.Size.Width / 2, Me.SplitContainer3.Panel2.Size.Height / 2)
            f8.Top = (Me.SplitContainer.Panel2.Height / 2) - (f2.Height / 2)
            f8.Left = (Me.SplitContainer.Panel2.Width / 2) - (f2.Width / 2)

            f8.TopLevel = False

            f8.WindowState = FormWindowState.Maximized
            f8.Parent = Me.SplitContainer.Panel2
            f8.Dock = DockStyle.None

            Me.SplitContainer.Panel2.Controls.Add(f8)
            f8.Show()
        End If
        swF = 0
    End Sub

  

    Private Sub ToolStripButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton11.Click
        f18 = frmClaves
        fcall = f18.Name

        cerrarForm()
        If swF = 1 Then
            MsgBox("Existen formularios abiertos, por favor cierre el formulario", MsgBoxStyle.Exclamation, "Control Proyectos")

        Else
            swuser = 2

            'f.Size = New Size(Me.SplitContainer3.Panel2.Size.Width / 2, Me.SplitContainer3.Panel2.Size.Height / 2)
            f18.Top = (Me.SplitContainer.Panel2.Height / 2) - (f18.Height / 2)
            f18.Left = (Me.SplitContainer.Panel2.Width / 2) - (f18.Width / 2)

            f18.TopLevel = False

            f18.WindowState = FormWindowState.Maximized
            f18.Parent = Me.SplitContainer.Panel2
            f18.Dock = DockStyle.None

            Me.SplitContainer.Panel2.Controls.Add(f18)
            f18.Show()
        End If
        swF = 0
    End Sub

    Private Sub ToolStripButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        f8 = frmUsuarios
        fcall = f8.Name

        cerrarForm()
        If swF = 1 Then
            MsgBox("Existen formularios abiertos, por favor cierre el formulario", MsgBoxStyle.Exclamation, "Control Proyectos")

        Else
            swuser = 2

            'f.Size = New Size(Me.SplitContainer3.Panel2.Size.Width / 2, Me.SplitContainer3.Panel2.Size.Height / 2)
            f8.Top = (Me.SplitContainer.Panel2.Height / 2) - (f2.Height / 2)
            f8.Left = (Me.SplitContainer.Panel2.Width / 2) - (f2.Width / 2)

            f8.TopLevel = False

            f8.WindowState = FormWindowState.Maximized
            f8.Parent = Me.SplitContainer.Panel2
            f8.Dock = DockStyle.None

            Me.SplitContainer.Panel2.Controls.Add(f8)
            f8.Show()
        End If
        swF = 0
    End Sub

 
    Private Sub ToolStripButton9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton9.Click


        If StrNivel = 1 Then

            f17 = frmpermisos
            fcall = f17.Name

            cerrarForm()
            If swF = 1 Then
                MsgBox("Existen formularios abiertos, por favor cierre el formulario", MsgBoxStyle.Exclamation, "Control Proyectos")

            Else
                swUser = 2

                'f.Size = New Size(Me.SplitContainer3.Panel2.Size.Width / 2, Me.SplitContainer3.Panel2.Size.Height / 2)
                f17.Top = (Me.SplitContainer.Panel2.Height / 2) - (f17.Height / 2)
                f17.Left = (Me.SplitContainer.Panel2.Width / 2) - (f17.Width / 2)

                f17.TopLevel = False

                f17.WindowState = FormWindowState.Maximized
                f17.Parent = Me.SplitContainer.Panel2
                f17.Dock = DockStyle.None

                Me.SplitContainer.Panel2.Controls.Add(f17)
                f17.Show()
            End If
        Else
            MsgBox("Usuario no tiene permisos", MsgBoxStyle.Exclamation, "Control Proyectos")
        End If
        swF = 0

    End Sub

   
    Private Sub ToolStripButton26_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton26.Click


        f22 = frmcarteraT
        fcall = f22.Name

        cerrarForm()
        If swF = 1 Then
            MsgBox("Existen formularios abiertos, por favor cierre el formulario", MsgBoxStyle.Exclamation, "Control Proyectos")

        Else
            swUser = 2

            '  Dim frm As New frmProcess
            FoldersToolStripButton_Click(1, Nothing)

            'frm.Show()
            ' For x As Int32 = 0 To 1


            swRpts = 1
            f22.Text = ToolStripButton26.Text
            f22.Show()
            'Exit For
            ' Application.DoEvents()
            '  Next
            '   frm.Close()

        End If

        swF = 0

    End Sub

    Private Sub ToolStripButton10_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton10.Click


        f20 = frmParamRepts
        fcall = f20.Name

        cerrarForm()
        If swF = 1 Then
            MsgBox("Existen formularios abiertos, por favor cierre el formulario", MsgBoxStyle.Exclamation, "Control Proyectos")

        Else
            swUser = 2

            Dim frm As New frmProcess
            FoldersToolStripButton_Click(1, Nothing)

            frm.Show()
            For x As Int32 = 0 To 1

              
                swRpts = 5
                f20.Text = ToolStripButton10.Text
                f20.Show()
                Exit For
                Application.DoEvents()
            Next
            frm.Close()

        End If
       
        swF = 0
    End Sub

    
    Private Sub ToolStripMenuItemct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItemct.Click
        f22 = frmcarteraT
        fcall = f22.Name

        cerrarForm()
        If swF = 1 Then
            MsgBox("Existen formularios abiertos, por favor cierre el formulario", MsgBoxStyle.Exclamation, "Control Proyectos")

        Else
            swUser = 2

            '  Dim frm As New frmProcess
            FoldersToolStripButton_Click(1, Nothing)

            'frm.Show()
            ' For x As Int32 = 0 To 1


            swRpts = 1
            f22.Text = ToolStripButton26.Text
            f22.Show()
            'Exit For
            ' Application.DoEvents()
            '  Next
            '   frm.Close()

        End If

        swF = 0


    End Sub

    Private Sub ToolStripMenuItemxsec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        f20 = frmParamRepts
        fcall = f20.Name

        cerrarForm()
        If swF = 1 Then
            MsgBox("Existen formularios abiertos, por favor cierre el formulario", MsgBoxStyle.Exclamation, "Control Proyectos")

        Else
            swUser = 2
            FoldersToolStripButton_Click(1, Nothing)
            Dim frm As New frmProcess


            frm.Show()
            For x As Int32 = 0 To 1


                swRpts = 2
                f20.Text = ToolStripButton10.Text
                f20.Show()
                Exit For
                Application.DoEvents()
            Next
            frm.Close()

        End If

        swF = 0
    End Sub

   
    Private Sub ToolStripButton27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton27.Click
        f20 = frmParamRepts
        fcall = f20.Name

        cerrarForm()

        If swF = 1 Then
            MsgBox("Existen formularios abiertos, por favor cierre el formulario", MsgBoxStyle.Exclamation, "Control Proyectos")

        Else

            FoldersToolStripButton_Click(1, Nothing)

            Dim frm As New frmProcess


            frm.Show()
            For x As Int32 = 0 To 1


                swRpts = 3
                f20.Text = ToolStripButton27.Text
                f20.Show()
                Exit For
                Application.DoEvents()
            Next
            frm.Close()

        End If

        swF = 0
    End Sub

    Private Sub ToolStripButton28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton28.Click
        f20 = frmParamRepts
        fcall = f20.Name

        cerrarForm()
        If swF = 1 Then
            MsgBox("Existen formularios abiertos, por favor cierre el formulario", MsgBoxStyle.Exclamation, "Control Proyectos")

        Else

            FoldersToolStripButton_Click(1, Nothing)

            Dim frm As New frmProcess


            frm.Show()
            For x As Int32 = 0 To 1


                swRpts = 4
                f20.Text = ToolStripButton28.Text
                f20.Show()
                Exit For
                Application.DoEvents()
            Next
            frm.Close()

        End If

        swF = 0
    End Sub

    Private Sub ToolStripMenuItemg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItemg.Click
        f20 = frmParamRepts
        fcall = f20.Name

        cerrarForm()
        If swF = 1 Then
            MsgBox("Existen formularios abiertos, por favor cierre el formulario", MsgBoxStyle.Exclamation, "Control Proyectos")

        Else

            FoldersToolStripButton_Click(1, Nothing)

            Dim frm As New frmProcess


            frm.Show()
            For x As Int32 = 0 To 1


                swRpts = 3
                f20.Text = ToolStripButton27.Text
                f20.Show()
                Exit For
                Application.DoEvents()
            Next
            frm.Close()

        End If

        swF = 0
    End Sub

    Private Sub ToolStripMenuItemt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        f20 = frmParamRepts
        fcall = f20.Name

        cerrarForm()
        If swF = 1 Then
            MsgBox("Existen formularios abiertos, por favor cierre el formulario", MsgBoxStyle.Exclamation, "Control Proyectos")

        Else
            swUser = 2
            FoldersToolStripButton_Click(1, Nothing)

            Dim frm As New frmProcess


            frm.Show()
            For x As Int32 = 0 To 1


                swRpts = 3
                f20.Text = ToolStripButton28.Text
                f20.Show()
                Exit For
                Application.DoEvents()
            Next
            frm.Close()

        End If

        swF = 0
    End Sub

    Private Sub TablasBásicasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TablasBásicasToolStripMenuItem.Click
        '  frm_manttbBasiscas.ShowDialog()
        f21 = frm_manttbBasiscas
        fcall = f21.Name

        cerrarForm()
        If swF = 1 Then
            MsgBox("Existen formularios abiertos, por favor cierre el formulario", MsgBoxStyle.Exclamation, "Control Proyectos")

        Else
            swUser = 2
            ' FoldersToolStripButton_Click(1, Nothing)

            Dim frm As New frmProcess
            frm.Show()
            For x As Int32 = 0 To 1
                'f.Size = New Size(Me.SplitContainer3.Panel2.Size.Width / 2, Me.SplitContainer3.Panel2.Size.Height / 2)
                f21.Top = (Me.SplitContainer.Panel2.Height / 2) - (f21.Height / 2)
                f21.Left = (Me.SplitContainer.Panel2.Width / 2) - (f21.Width / 2)

                f21.TopLevel = False

                f21.WindowState = FormWindowState.Maximized
                f21.Parent = Me.SplitContainer.Panel2
                f21.Dock = DockStyle.None

                Me.SplitContainer.Panel2.Controls.Add(f21)

                f21.Show()
                Exit For


                f21.Text = TablasBásicasToolStripMenuItem.Text

                Exit For
                Application.DoEvents()
            Next
            frm.Close()

        End If

        swF = 0


    End Sub

    Sub funcionRecogemenu()
        Try

         
            ToolStripButton1.Visible = False
            ToolStripButton22.Visible = False
            ToolStripButton13.Visible = False
            ToolStripButton15.Visible = False
            ToolStripButton16.Visible = False
            ToolStripButton17.Visible = False

            tsbtnMant1.Visible = False
            ToolStripButton18.Visible = False
            ToolStripButton19.Visible = False
            ToolStripButton20.Visible = False
            ToolStripButton26.Visible = False
            ToolStripButton8.Visible = False
            ToolStripButton9.Visible = False
            ToolStripButton10.Visible = False

            ToolStripButton27.Visible = False
            ToolStripButton28.Visible = False
            NewToolStripMenuItem.Visible = False
            ToolStripMenuItem1.Visible = False
            ToolStripMenuItem2.Visible = False
            ToolStripMenuItem3.Visible = False
            ToolStripMenuItem4.Visible = False
            ToolStripMenuItem6.Visible = False
            ToolStripMenuItem7.Visible = False
            ToolStripMenuItem8.Visible = False
            ToolStripMenuItemct.Visible = False
            'ToolStripMenuItemxsec.Visible = False
            ToolStripMenuItemg.Visible = False
            ' ToolStripMenuItemt.Visible = False
            UsuariosToolStripMenuItem.Visible = False
            ImToolStripMenuItem.Visible = False
            HistToolStripMenuItem.Visible = False


        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripButton29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton29.Click
        f26 = frmImportacionFacturas
        fcall = f26.Name

        cerrarForm()
        If swF = 1 Then
            MsgBox("Existen formularios abiertos, por favor cierre el formulario", MsgBoxStyle.Exclamation)

        Else

            FoldersToolStripButton_Click(1, Nothing)
            ToolStripStatusLabel.Text = "Importar Datos Proyectos"
            f26.Top = (Me.SplitContainer.Panel2.Height / 2) - (f26.Height / 2)
            f26.Left = (Me.SplitContainer.Panel2.Width / 2) - (f26.Width / 2)

            f26.TopLevel = False

            f26.WindowState = FormWindowState.Maximized
            f26.Parent = Me.SplitContainer.Panel2
            '  f6.Dock = DockStyle.Top

            Me.SplitContainer.Panel2.Controls.Add(f26)
            f26.Show()
        End If

        swF = 0
    End Sub

    Private Sub ToolStripButton30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton30.Click
        f27 = frmImportacionResp
        fcall = f27.Name

        cerrarForm()
        If swF = 1 Then
            MsgBox("Existen formularios abiertos, por favor cierre el formulario", MsgBoxStyle.Exclamation)

        Else

            FoldersToolStripButton_Click(1, Nothing)
            ToolStripStatusLabel.Text = "Importar Datos Proyectos"
            f27.Top = (Me.SplitContainer.Panel2.Height / 2) - (f27.Height / 2)
            f27.Left = (Me.SplitContainer.Panel2.Width / 2) - (f27.Width / 2)

            f27.TopLevel = False

            f27.WindowState = FormWindowState.Maximized
            f27.Parent = Me.SplitContainer.Panel2
            '  f6.Dock = DockStyle.Top

            Me.SplitContainer.Panel2.Controls.Add(f27)
            f27.Show()
        End If

        swF = 0
    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click

    End Sub
End Class
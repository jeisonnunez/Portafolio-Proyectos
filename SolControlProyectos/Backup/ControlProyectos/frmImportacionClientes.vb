
Imports System.Data.OleDb
Imports System.IO
Public Class frmImportacionClientes
    Public id As Integer = 0
    Public archivoEx As String = ""
    Public Fk As Integer
    Public sdata As Integer = 0
    Public Fj As Integer

    Public swexp As Integer = 0

    Public e As Integer = 0
    Public f As Integer = 0
    Public c As Integer = 0

    Public nroDoc As String = ""
    Public errorimp As Integer = 0
    Public fechas(30) As String
    Public montos(30) As String
    Public enteros(30) As String
    Public datosPpalProy(100) As String
    Public datosPpalProy1(100) As String

    Public pro_codCliente As String = ""
    Public pro_DescripcionCliente As String = ""
    Public pro_codA2cliente As String = ""
    Public pro_dirCliente As String = ""
    Public pro_telefCliente As String = ""
    Public pro_personaContacto As String = ""
    Public pro_pendientexcobrar As Decimal = 0
    Public pro_Ruc As String = ""
    Public pro_Dv As String = ""



    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        Me.Close()
    End Sub

    Private Sub cmb76_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb76.SelectedIndexChanged
        Fk = 0
        CADENA = cmb76.SelectedItem
        llenarVector()
        Fk = IIf(cmb76.SelectedIndex = -1, 1, cmb76.SelectedIndex + 1)
        datosPpalProy(5) = Fk & ".V"
        datosPpalProy1(5) = Fj & ".V"
    End Sub
    Sub llenarVector()
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim valor As String = ""
        Dim sw As Integer = 0
        Dim preg As String = ""
        Fk = 0
        Fj = 0
        If Len(CADENA) > 9 Then
            valor = vectorDatos(Microsoft.VisualBasic.Right(CADENA, 1))

            For i = 0 To 25

                If Dato(i) = "" Then
                    Dato(i) = valor
                    Fk = 26 + i
                    Fj = valor + 26
                    Exit For
                End If

            Next


        Else
            valor = vectorDatos(Microsoft.VisualBasic.Right(CADENA, 1))

            For i = 0 To 25

                If Dato(i) = "" Then
                    Dato(i) = valor
                    Fk = i
                    Fj = valor
                    Exit For
                End If

            Next

        End If

    End Sub

    Public Function vectorDatos(ByVal strid As String)
        Dim strdato As Integer
        Dim j As Integer = 1
        Try
            For i = 65 To 90


                If strid = Chr(i) Then
                    strdato = j

                    Exit For
                End If
                j = j + 1
            Next

        Catch ex As Exception

        End Try

        Return strdato

    End Function

    Private Sub cmb71_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb71.SelectedIndexChanged
        CADENA = cmb71.SelectedItem
        llenarVector()

        Fk = IIf(cmb71.SelectedIndex = -1, 1, cmb71.SelectedIndex + 1)

        datosPpalProy(1) = Fk & ".V"
        datosPpalProy1(1) = Fj & ".V"
    End Sub

    Private Sub cmb72_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb72.SelectedIndexChanged
        CADENA = cmb72.SelectedItem
        llenarVector()

        Fk = IIf(cmb72.SelectedIndex = -1, 1, cmb72.SelectedIndex + 1)

        datosPpalProy(2) = Fk & ".V"
        datosPpalProy1(2) = Fj & ".V"
    End Sub

    Private Sub cmb73_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb73.SelectedIndexChanged
        CADENA = cmb73.SelectedItem
        llenarVector()

        Fk = IIf(cmb73.SelectedIndex = -1, 1, cmb73.SelectedIndex + 1)

        datosPpalProy(3) = Fk & ".V"
        datosPpalProy1(3) = Fj & ".V"
    End Sub

    Private Sub cmb74_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb74.SelectedIndexChanged
        CADENA = cmb74.SelectedItem
        llenarVector()

        Fk = IIf(cmb74.SelectedIndex = -1, 1, cmb74.SelectedIndex + 1)

        datosPpalProy(3) = Fk & ".V"
        datosPpalProy1(3) = Fj & ".V"
    End Sub

    Private Sub cmb75_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb75.SelectedIndexChanged
        CADENA = cmb75.SelectedItem
        llenarVector()

        Fk = IIf(cmb75.SelectedIndex = -1, 1, cmb75.SelectedIndex + 1)

        datosPpalProy(4) = Fk & ".V"
        datosPpalProy1(4) = Fj & ".V"
    End Sub

    Private Sub cmb77_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb77.SelectedIndexChanged
        CADENA = cmb77.SelectedItem
        llenarVector()

        Fk = IIf(cmb77.SelectedIndex = -1, 1, cmb77.SelectedIndex + 1)

        datosPpalProy(6) = Fk & ".V"
        datosPpalProy1(6) = Fj & ".V"
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        If chk71.Checked = True And chk72.Checked = True Then

            Proyecto = ""
            leeVector()


            If swExcel = 0 Then

                Dim openFD As New OpenFileDialog()
                With openFD
                    .Title = "Seleccionar archivos"
                    .Filter = "Archivos Excel(*.xls;*.xlsx)|*.xls;*xlsx|Todos los archivos(*.*)|*.*"
                    .Multiselect = False
                    .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
                    If .ShowDialog = Windows.Forms.DialogResult.OK Then

                        If Proyecto <> "" Then
                            archivoEx = .FileName()
                            ImportExcellToDataGridView(.FileName, gpbDres)
                        End If
                    End If
                End With

            End If



        Else
            MsgBox("Datos en Rojo Deben estar Seleccionados", MsgBoxStyle.Exclamation, "Control de Proyectos")
        End If
        swExcel = 0
    End Sub
    Public Function ImportExcellToDataGridView(ByRef path As String, ByVal Datagrid As DataGridView)

        Dim frm As New frmProcess
        Try

            frm.Show()
            For x As Int32 = 0 To 1


                Dim stConexion As String
                stConexion = "Provider=Microsoft.ACE.Oledb.12.0;Data Source=" & path & ";Extended Properties=""Excel 12.0;HDR=NO;IMEX=1"""

                Dim cnConex As New OleDbConnection(stConexion)
                Dim Cmd As New OleDbCommand("Select  " & Proyecto & " From [Hoja1$]")
                'cnConex As OleDbConnection(stConexion)

                Dim Ds As New DataSet
                Dim Da As New OleDbDataAdapter
                Dim Dt As New DataTable
                Dim i As Integer
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

                cnConex.Close()
                'limpia vector
                For i = 0 To 25
                    Dato(i) = ""
                Next



                Exit For
                Application.DoEvents()
            Next
            frm.Close()

        Catch ex As Exception
            frm.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return True
    End Function
    Sub leeVector()

        Dim j As Integer = 1
        Dim i As Integer = 0
        Dim k As Integer = 0
        Dim temp As String = ""
        Dim sw As Integer = 0
        Dim longi As Integer = 0
        Dim longi1 As Integer = 0
        For i = 0 To 30
            fechas(i) = ""
        Next
        For i = 0 To 30
            montos(i) = ""
        Next
        For i = 0 To 30
            enteros(i) = ""
        Next


        Proyecto = ""
        Try
            'metodo burbuja para no repetir campos

            For i = 1 To 100
                For j = i + 1 To 100

                    If datosPpalProy1(j) <> "" Then

                        If Microsoft.VisualBasic.Len(datosPpalProy1(i)) > 3 Then
                            longi = 2
                        Else
                            longi = 1
                        End If

                        If Microsoft.VisualBasic.Len(datosPpalProy1(j)) > 3 Then
                            longi1 = 2
                        Else
                            longi1 = 1
                        End If

                        If Microsoft.VisualBasic.Left(datosPpalProy1(i), longi) = Microsoft.VisualBasic.Left(datosPpalProy1(j), longi1) Then

                            sw = 1
                            swExcel = 1

                        End If

                    End If

                Next

            Next


            If sw = 0 Then

                For i = 0 To 100

                    If datosPpalProy1(i) <> "" Then

                        If Proyecto <> "" Then


                            Proyecto = Proyecto & "," & "F" & Val(datosPpalProy1(i))

                            If Microsoft.VisualBasic.Right(datosPpalProy1(i), 1) = "F" Then

                                For h = 0 To 30
                                    If fechas(h) = "" Then
                                        fechas(h) = k
                                        Exit For
                                    End If
                                Next

                            End If

                            If Microsoft.VisualBasic.Right(datosPpalProy1(i), 1) = "M" Then
                                For h = 0 To 30
                                    If montos(h) = "" Then
                                        montos(h) = k
                                        Exit For
                                    End If
                                Next
                            End If

                            If Microsoft.VisualBasic.Right(datosPpalProy1(i), 1) = "E" Then
                                For h = 0 To 30
                                    If enteros(h) = "" Then
                                        enteros(h) = k
                                        Exit For
                                    End If
                                Next
                            End If

                            k = k + 1
                        Else


                            If Microsoft.VisualBasic.Right(datosPpalProy1(i), 1) = "F" Then
                                For h = 0 To 30
                                    If fechas(h) = "" Then
                                        fechas(h) = k
                                        Exit For
                                    End If
                                Next
                            End If

                            If Microsoft.VisualBasic.Right(datosPpalProy1(i), 1) = "M" Then
                                For h = 0 To 30
                                    If montos(h) = "" Then
                                        montos(h) = k
                                        Exit For
                                    End If
                                Next
                            End If


                            If Microsoft.VisualBasic.Right(datosPpalProy1(i), 1) = "E" Then
                                For h = 0 To 30
                                    If enteros(h) = "" Then
                                        enteros(h) = k
                                        Exit For
                                    End If
                                Next
                            End If
                            Proyecto = "F" & Val(datosPpalProy1(i))

                            k = k + 1
                        End If

                    End If
                Next
            Else
                MsgBox("Existen Campos Duplicados, por favor verifique ", MsgBoxStyle.Exclamation)
                sw = 0

            End If

        Catch ex As Exception
            MsgBox("Error en funcion leeVector()" & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try


    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        If Me.gpbDres.RowCount > 0 Then
            Dim frm As New frmProcess
            frm.Show()
            For x As Int32 = 0 To 1

                revisarDatosPrev()
                Exit For
                Application.DoEvents()
            Next
            frm.Close()
        Else
            MsgBox("Debe Seleccionar los Datos", MsgBoxStyle.Exclamation, "Control de Proyectos")
        End If
    End Sub
    Sub revisarDatosPrev()
        Dim fecha As String = ""
        Dim fechi As Date
        Dim monto As Decimal = 0
        Dim i As Integer = 0
        Dim index As String = ""
        Dim index1 As Integer = 0
        Dim ent As Integer = 0
        Dim Colum As Integer = 0
        Try


            ' VALIDO CAMPOS VACIOS
            If Me.gpbDres.RowCount > 0 Then
                For i = 0 To gpbDres.RowCount - 1
                    For j = 0 To gpbDres.ColumnCount - 1
                        If gpbDres.Rows(i).Cells(j).Value() Is DBNull.Value Then
                            MsgBox("Existen Campos Vacios, por favor revise el archivo", MsgBoxStyle.Critical, "Control Proyectos")
                            Me.gpbDres.CurrentCell = Me.gpbDres(j, i)
                            Exit Sub
                        End If
                    Next
                Next
            End If




            If Me.gpbDres.RowCount > 0 Then
                'VALIDO FECHA 
                For i = 0 To 20

                    If fechas(i) <> "" Then
                        index = fechas(i)
                        index1 = index

                        For Fila = 2 To gpbDres.RowCount - 1
                            Try
                                fechi = gpbDres.Rows(Fila).Cells(index1).Value()
                                fecha = Format(fechi, "yyyy-MM-dd")

                                If IsDate(gpbDres.Rows(Fila).Cells(index1).Value()) Then
                                    sdata = 0
                                Else
                                    sdata = 1
                                    Me.gpbDres.CurrentCell = Me.gpbDres(index1, Fila)
                                    MsgBox("FECHA Invalida", MsgBoxStyle.Critical, "Control Proyectos")
                                    Exit Sub
                                End If
                            Catch ex As Exception
                                sdata = 1
                                Me.gpbDres.CurrentCell = Me.gpbDres(index1, Fila)
                                MsgBox("FECHA Invalida", MsgBoxStyle.Critical, "Control Proyectos")
                                Exit Sub
                            End Try
                        Next Fila

                    End If

                Next

            End If


            'VALIDO MONTO
            For i = 0 To 20

                If montos(i) <> "" Then
                    index = montos(i)
                    index1 = index

                    For Fila = 2 To gpbDres.RowCount - 1
                        Try
                            monto = gpbDres.Rows(Fila).Cells(index1).Value()

                            If monto > 0 Then
                                sdata = 0
                            Else
                                sdata = 1
                                Me.gpbDres.CurrentCell = Me.gpbDres(index1, Fila)
                                MsgBox("Monto Invalido", MsgBoxStyle.Critical, "Control Proyectos")
                                Exit Sub

                            End If
                        Catch ex As Exception
                            sdata = 1
                            Me.gpbDres.CurrentCell = Me.gpbDres(index1, Fila)
                            MsgBox("Monto Invalido", MsgBoxStyle.Critical, "Control Proyectos")
                            Exit Sub
                        End Try

                    Next Fila

                End If

            Next

            '  VALIDO CAMPOS ENTEROS
            For i = 0 To 20

                If enteros(i) <> "" Then
                    index = enteros(i)
                    index1 = index

                    For Fila = 2 To gpbDres.RowCount - 1
                        Try
                            ent = gpbDres.Rows(Fila).Cells(index1).Value()

                            If ent > 0 Then
                                sdata = 0
                            Else
                                sdata = 1
                                Me.gpbDres.CurrentCell = Me.gpbDres(index1, Fila)
                                MsgBox("Campo debe ser entero", MsgBoxStyle.Critical, "Control Proyectos")
                                Exit Sub

                            End If
                        Catch ex As Exception
                            sdata = 1
                            Me.gpbDres.CurrentCell = Me.gpbDres(index1, Fila)
                            MsgBox("Campo debe ser entero", MsgBoxStyle.Critical, "Control Proyectos")
                            Exit Sub
                        End Try

                    Next Fila

                End If

            Next



            sdata = 0
            If sdata = 0 Then
                MsgBox("Datos listos para Importar", MsgBoxStyle.Information, "Control Proyectos")
                ToolStripButton3.Enabled = True
            End If

        Catch ex As Exception
            MsgBox("Error en funcion revisarDatosPrev()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try

    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        If archivoEx = "" Then
            MsgBox("Debe Selecionar un Archivo", MsgBoxStyle.Critical, "Control Proyectos")
        Else
            Proyecto = ""
            leeVector()
            ImportExcellToDataGridView(archivoEx, gpbDres)
        End If
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        limpiarDatosImport()
    End Sub
    Sub limpiarDatosImport()
        Try
            Me.gpbDres.DataSource = Nothing
            'limpia vector
            For i = 0 To 25
                Dato(i) = ""
            Next

        Catch ex As Exception
            MsgBox("Error en Funcion limpiarDatosImport" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Try
            Dim preg As String

            preg = MsgBox("Seguro que desea importar los datos", MsgBoxStyle.YesNoCancel)

            If preg = 6 Then


                Dim frm As New frmProcess
                frm.Show()
                For x As Int32 = 0 To 1


                    nroDoc = DateTime.Now
                    nroDoc = Replace(nroDoc, "/", "")
                    nroDoc = Replace(nroDoc, "-", "")
                    nroDoc = Replace(nroDoc, ":", "")
                    nroDoc = Replace(nroDoc, " ", "")

                    'DATOS CLIENTES DEL PROYECTO
                    importarDatosClientes()


                    If errorimp = 0 Then
                        ConexionSQL()
                        cntSQL.Execute("exec p_InsertaDatosproyectoClientes '" & nroDoc & "'")

                    End If


                    If swexp = 0 Then
                        MsgBox("Datos Importados", MsgBoxStyle.Information, "Control Proyectos")
                        gpbDres.Columns.Clear()
                    End If

                    Exit For
                    Application.DoEvents()
                Next
                frm.Close()

            End If

        Catch ex As Exception
            MsgBox("Error al Importar Datos Clientes" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try

        swexp = 0
    End Sub
    Sub importarDatosClientes()
        Try
            Dim valor As String = ""
            Dim valor1 As Integer = 0
            Dim swNroProyIni As String = ""
            Dim swNroProyNext As String = ""
            Dim swNroContIni As String = ""
            Dim swNroContNext As String = ""
            Dim k As Integer = 0
            Dim nC As Integer = 0
            Dim nP As Integer = 0

            'recorre gridview para importar los datos


            If Me.gpbDres.RowCount > 0 Then

                For Fila = 1 To gpbDres.RowCount - 1

                    'VALIDA NRO DE PROYECTOS
                    k = 0
                    valor = Val(datosPpalProy(1))
                    If valor <> "" And valor <> 0 Then

                        pro_codCliente = UCase(gpbDres.Rows(Fila).Cells(k).Value())

                        nP = k
                        k = k + 1
                    End If


                    valor = Val(datosPpalProy(2))
                    If valor <> "" And valor <> 0 Then

                        pro_DescripcionCliente = UCase(gpbDres.Rows(Fila).Cells(k).Value())

                        k = k + 1
                    End If

               


                    valor = Val(datosPpalProy(3))
                    If valor <> "" And valor <> 0 Then

                        pro_dirCliente = UCase(gpbDres.Rows(Fila).Cells(k).Value())

                        nC = k
                        k = k + 1
                    End If


                    valor = Val(datosPpalProy(4))
                    If valor <> "" And valor <> 0 Then

                        pro_personaContacto = UCase(gpbDres.Rows(Fila).Cells(k).Value())
                        k = k + 1

                    End If

                    valor = Val(datosPpalProy(5))
                    If valor <> "" And valor <> 0 Then

                        pro_Ruc = UCase(gpbDres.Rows(Fila).Cells(k).Value())
                        k = k + 1
                    End If

                    valor = Val(datosPpalProy(6))
                    If valor <> "" And valor <> 0 Then

                        pro_Dv = UCase(gpbDres.Rows(Fila).Cells(k).Value())

                        k = k + 1

                    End If

                    'path_conexion 
                    guardaActImportClienProy()


                Next Fila
                e = k
            End If


        Catch ex As Exception
            MsgBox("Error en funcion importarDatosContratista()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
            errorimp = 1
        End Try
    End Sub
    Sub guardaActImportClienProy()
        Try
            ConexionSQL()
            Dim strCliente As New ADODB.Recordset
            strCliente = cntSQL.Execute("select * from [import_tab_ClienteProy] where [pro_codCliente ]='" & pro_codCliente & "'")

            If strCliente.EOF = False Then
                cntSQL.Execute("UPDATE [import_tab_ClienteProy] SET " _
                                & " [pro_codCliente]='" & pro_codCliente & "', " _
                                & " [pro_DescripcionCliente]= '" & pro_DescripcionCliente & "', " _
                                & " [pro_Ruc]='" & pro_Ruc & "', " _
                                & " [pro_personaContacto]='" & pro_personaContacto & "', " _
                                & "  pro_dirCliente='" & pro_dirCliente & "', " _
                                & "  pro_Dv='" & pro_Dv & " '," _
                                & " [nroDoc]='" & nroDoc & "' " _
                                & "  where [pro_codCliente]='" & pro_codCliente & "' and nroDoc='" & nroDoc & "'")

            Else
                cntSQL.Execute("insert into import_tab_ClienteProy ([pro_codCliente],[pro_DescripcionCliente],[pro_dirCliente],[pro_personaContacto],[pro_Ruc],[pro_Dv], nroDoc ) values " _
                                & "('" & pro_codCliente & "'," _
                                & " '" & pro_DescripcionCliente & "'," _
                                & " '" & pro_dirCliente & "'," _
                                & " '" & pro_personaContacto & "'," _
                                & " '" & pro_Ruc & "'," _
                                & " '" & pro_Dv & "','" & nroDoc & "')")
            End If



        Catch ex As Exception
            MsgBox("Error en funcion guardaActImportClienProy()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
            swexp = 1
        End Try

    End Sub

    Private Sub frmImportacionClientes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        llenaCombos()
       
    End Sub
    Sub llenaCombos()
        For i = 65 To 90

            cmb71.Items.Add("COLUMNA " & Chr(i))
            cmb72.Items.Add("COLUMNA " & Chr(i))
            cmb73.Items.Add("COLUMNA " & Chr(i))
            cmb74.Items.Add("COLUMNA " & Chr(i))
            cmb75.Items.Add("COLUMNA " & Chr(i))
            cmb76.Items.Add("COLUMNA " & Chr(i))
            cmb77.Items.Add("COLUMNA " & Chr(i))
        Next
        For i = 65 To 90
            cmb71.Items.Add("COLUMNA " & "A" & Chr(i))
            cmb72.Items.Add("COLUMNA " & "A" & Chr(i))
            cmb73.Items.Add("COLUMNA " & "A" & Chr(i))
            cmb74.Items.Add("COLUMNA " & "A" & Chr(i))
            cmb75.Items.Add("COLUMNA " & "A" & Chr(i))
            cmb76.Items.Add("COLUMNA " & "A" & Chr(i))
            cmb77.Items.Add("COLUMNA " & "A" & Chr(i))
        Next

    End Sub

    Private Sub chk71_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk71.CheckedChanged
        If chk71.Checked = True Then
            cmb71.Enabled = True
        Else
            cmb71.Enabled = False
            datosPpalProy(1) = ""
            datosPpalProy1(1) = ""
        End If
    End Sub

    Private Sub chk72_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk72.CheckedChanged
        If chk72.Checked = True Then
            cmb72.Enabled = True
        Else
            cmb72.Enabled = False
            datosPpalProy(2) = ""
            datosPpalProy1(2) = ""
        End If
    End Sub

    Private Sub chk73_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk73.CheckedChanged
        If chk73.Checked = True Then
            cmb73.Enabled = True
        Else
            cmb73.Enabled = False
            datosPpalProy(3) = ""
            datosPpalProy1(3) = ""
        End If
    End Sub

    Private Sub chk74_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk74.CheckedChanged
        If chk74.Checked = True Then
            cmb74.Enabled = True
        Else
            cmb74.Enabled = False
            datosPpalProy(4) = ""
            datosPpalProy1(4) = ""
        End If
    End Sub

    Private Sub chk75_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk75.CheckedChanged
        If chk75.Checked = True Then
            cmb75.Enabled = True
        Else
            cmb75.Enabled = False
            datosPpalProy(5) = ""
            datosPpalProy1(5) = ""
        End If
    End Sub

    Private Sub chk76_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk76.CheckedChanged
        If chk76.Checked = True Then
            cmb76.Enabled = True
        Else
            cmb76.Enabled = False
            datosPpalProy(6) = ""
            datosPpalProy1(6) = ""
        End If
    End Sub

    Private Sub chk77_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk77.CheckedChanged
        If chk77.Checked = True Then
            cmb77.Enabled = True
        Else
            cmb77.Enabled = False
            datosPpalProy(7) = ""
            datosPpalProy1(7) = ""
        End If
    End Sub
End Class
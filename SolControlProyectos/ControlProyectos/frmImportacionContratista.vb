
Imports System.Data.OleDb
Imports System.IO
Public Class frmImportacionContratista
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

    Public pro_codContratista As String = ""
    Public pro_DescrContratista As String = ""
    Public pro_codA2cContratista As String = ""
    Public pro_dircContratista As String = ""
    Public pro_telefContratista As String = ""
    Public pro_personaContContratista As String = ""
    Public pro_ContMonto As Decimal = 0
    Public path_conexion As String = ""



    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        Me.Close()
    End Sub


    Private Sub cmb69_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb69.SelectedIndexChanged
        Fk = 0
        CADENA = cmb69.SelectedItem
        llenarVector()
        Fk = IIf(cmb69.SelectedIndex = -1, 1, cmb69.SelectedIndex + 1)
        datosPpalProy(6) = Fk & ".M"
        datosPpalProy1(6) = Fj & ".M"
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

    Private Sub cmb64_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb64.SelectedIndexChanged
        CADENA = cmb64.SelectedItem
        llenarVector()

        Fk = IIf(cmb64.SelectedIndex = -1, 1, cmb64.SelectedIndex + 1)

        datosPpalProy(1) = Fk & ".V"
        datosPpalProy1(1) = Fj & ".V"
    End Sub

    Private Sub cmb65_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb65.SelectedIndexChanged
        CADENA = cmb65.SelectedItem
        llenarVector()

        Fk = IIf(cmb65.SelectedIndex = -1, 1, cmb65.SelectedIndex + 1)

        datosPpalProy(2) = Fk & ".V"
        datosPpalProy1(2) = Fj & ".V"
    End Sub

    Private Sub cmb66_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb66.SelectedIndexChanged
        CADENA = cmb66.SelectedItem
        llenarVector()

        Fk = IIf(cmb66.SelectedIndex = -1, 1, cmb66.SelectedIndex + 1)

        datosPpalProy(3) = Fk & ".V"
        datosPpalProy1(3) = Fj & ".V"
    End Sub

    Private Sub cmb67_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb67.SelectedIndexChanged
        CADENA = cmb67.SelectedItem
        llenarVector()

        Fk = IIf(cmb67.SelectedIndex = -1, 1, cmb67.SelectedIndex + 1)

        datosPpalProy(4) = Fk & ".V"
        datosPpalProy1(4) = Fj & ".V"
    End Sub

    Private Sub cmb68_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb68.SelectedIndexChanged
        CADENA = cmb68.SelectedItem
        llenarVector()

        Fk = IIf(cmb68.SelectedIndex = -1, 1, cmb68.SelectedIndex + 1)

        datosPpalProy(5) = Fk & ".V"
        datosPpalProy1(5) = Fj & ".V"
    End Sub

    Private Sub cmb70_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb70.SelectedIndexChanged
        CADENA = cmb70.SelectedItem
        llenarVector()

        Fk = IIf(cmb70.SelectedIndex = -1, 1, cmb70.SelectedIndex + 1)

        datosPpalProy(7) = Fk & ".V"
        datosPpalProy1(7) = Fj & ".V"
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click

        If chk64.Checked = True And chk65.Checked = True Then

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
            MsgBox("Error en Funcion limpiarDatosImport", MsgBoxStyle.Critical, "Control Proyectos")
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

                    'DATOS CONTRATISTA DEL PROYECTO
                    importarDatosContratista()
                  

                    If errorimp = 0 Then
                        ConexionSQL()
                        cntSQL.Execute("exec p_InsertaDatosproyectoContratistas '" & nroDoc & "'")
                      
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
            MsgBox("Error al Importar Datos Contratista", MsgBoxStyle.Critical, "Control Proyectos")
        End Try

        swexp = 0
    End Sub
    Sub importarDatosContratista()
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

                        pro_codContratista = UCase(gpbDres.Rows(Fila).Cells(k).Value())

                        nP = k
                        k = k + 1
                    End If


                    valor = Val(datosPpalProy(2))
                    If valor <> "" And valor <> 0 Then

                        pro_DescrContratista = UCase(gpbDres.Rows(Fila).Cells(k).Value())

                        k = k + 1
                    End If

                    valor = Val(datosPpalProy(3))

                    If valor <> "" And valor <> 0 Then

                        pro_codA2cContratista = UCase(gpbDres.Rows(Fila).Cells(k).Value())
                        k = k + 1
                    End If


                    valor = Val(datosPpalProy(4))
                    If valor <> "" And valor <> 0 Then

                        pro_dircContratista = UCase(gpbDres.Rows(Fila).Cells(k).Value())
                       
                        nC = k
                        k = k + 1
                    End If


                    valor = Val(datosPpalProy(5))
                    If valor <> "" And valor <> 0 Then

                        pro_telefContratista = UCase(gpbDres.Rows(Fila).Cells(k).Value())
                        k = k + 1

                    End If

                    valor = Val(datosPpalProy(6))
                    If valor <> "" And valor <> 0 Then

                        pro_ContMonto = gpbDres.Rows(Fila).Cells(k).Value()

                        k = k + 1

                    End If


                    valor = Val(datosPpalProy(7))
                    If valor <> "" And valor <> 0 Then

                        pro_personaContContratista = UCase(gpbDres.Rows(Fila).Cells(k).Value())
                        k = k + 1
                    End If

                  
                    valor = Val(datosPpalProy(8))
                    If valor <> "" And valor <> 0 Then

                        path_conexion = UCase(gpbDres.Rows(Fila).Cells(k).Value())

                        k = k + 1

                    End If
                    'path_conexion 
                    guardaActImportContrProy()
                 

                Next Fila
                e = k
            End If


        Catch ex As Exception
            MsgBox("Error en funcion importarDatosContratista()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
            errorimp = 1
        End Try
    End Sub
    Sub guardaActImportContrProy()
        Try
            ConexionSQL()
            Dim strCliente As New ADODB.Recordset
            strCliente = cntSQL.Execute("select [pro_codContratista],[pro_DescrContratista],[pro_codA2cContratista],[pro_dircContratista],[pro_telefContratista],[pro_personaContContratista],[pro_ContMonto],	[path_conexion] from [import_tab_Contratistaproy] where [pro_codContratista]='" & pro_codContratista & "'")

            If strCliente.EOF = False Then
                cntSQL.Execute("UPDATE [import_tab_Contratistaproy] SET " _
                                & " [pro_DescrContratista]='" & pro_DescrContratista & "', " _
                                & " [pro_codA2cContratista]= '" & pro_codA2cContratista & "', " _
                                & " [pro_dircContratista]='" & pro_dircContratista & "', " _
                                & " [pro_telefContratista]='" & pro_telefContratista & "', " _
                                & " [pro_personaContContratista]='" & pro_personaContContratista & "', " _
                                & "  pro_ContMonto='" & Replace(pro_ContMonto, ",", "") & "' " _
                                & " [nroDoc]='" & nroDoc & "', " _
                                & " [path_conexion]='" & path_conexion & "', " _
                                & "  where [pro_codContratista]='" & pro_codContratista & "' and nroDoc='" & nroDoc & "'")

            Else
                cntSQL.Execute("insert into import_tab_Contratistaproy ([pro_codContratista],[pro_DescrContratista],[pro_codA2cContratista],[pro_dircContratista],[pro_telefContratista],[pro_personaContContratista],[pro_ContMonto],[path_conexion], nroDoc ) values " _
                                & "('" & pro_codContratista & "'," _
                                & " '" & pro_DescrContratista & "'," _
                                & " '" & pro_codA2cContratista & "'," _
                                & " '" & pro_dircContratista & "'," _
                                & " '" & pro_telefContratista & "'," _
                                & " '" & pro_personaContContratista & "'," _
                                & " " & Replace(pro_ContMonto, ",", "") & ",'" & path_conexion & "','" & nroDoc & "')")
            End If



        Catch ex As Exception
            MsgBox("Error en funcion guardaActImportContrProy()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
            swexp = 1
        End Try

    End Sub

    Private Sub chk64_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk64.CheckedChanged
        If chk64.Checked = True Then
            cmb64.Enabled = True
        Else
            cmb64.Enabled = False
            datosPpalProy(1) = ""
            datosPpalProy1(1) = ""
        End If
    End Sub

    Private Sub chk65_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk65.CheckedChanged
        If chk65.Checked = True Then
            cmb65.Enabled = True
        Else
            cmb65.Enabled = False
            datosPpalProy(2) = ""
            datosPpalProy1(2) = ""
        End If
    End Sub

    Private Sub chk66_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk66.CheckedChanged
        If chk66.Checked = True Then
            cmb66.Enabled = True
        Else
            cmb66.Enabled = False
            datosPpalProy(3) = ""
            datosPpalProy1(3) = ""
        End If
    End Sub

    Private Sub chk67_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk67.CheckedChanged
        If chk67.Checked = True Then
            cmb67.Enabled = True
        Else
            cmb67.Enabled = False
            datosPpalProy(4) = ""
            datosPpalProy1(4) = ""
        End If
    End Sub

    Private Sub chk68_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk68.CheckedChanged
        If chk68.Checked = True Then
            cmb68.Enabled = True
        Else
            cmb68.Enabled = False
            datosPpalProy(5) = ""
            datosPpalProy1(5) = ""
        End If
    End Sub

    Private Sub chk69_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk69.CheckedChanged
        If chk69.Checked = True Then
            cmb69.Enabled = True
        Else
            cmb69.Enabled = False
            datosPpalProy(6) = ""
            datosPpalProy1(6) = ""
        End If
    End Sub

    Private Sub chk70_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk70.CheckedChanged
        If chk70.Checked = True Then
            cmb70.Enabled = True
        Else
            cmb70.Enabled = False
            datosPpalProy(7) = ""
            datosPpalProy1(7) = ""
        End If
    End Sub

   
    Private Sub frmImportacionContratista_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        llenaCombos()
        
    End Sub
    Sub llenaCombos()

        For i = 65 To 90

            cmb64.Items.Add("COLUMNA " & Chr(i))
            cmb65.Items.Add("COLUMNA " & Chr(i))
            cmb66.Items.Add("COLUMNA " & Chr(i))
            cmb67.Items.Add("COLUMNA " & Chr(i))
            cmb68.Items.Add("COLUMNA " & Chr(i))
            cmb69.Items.Add("COLUMNA " & Chr(i))
            cmb70.Items.Add("COLUMNA " & Chr(i))
            cmb71.Items.Add("COLUMNA " & Chr(i))
        Next
        For i = 65 To 90
            cmb64.Items.Add("COLUMNA " & "A" & Chr(i))
            cmb65.Items.Add("COLUMNA " & "A" & Chr(i))
            cmb66.Items.Add("COLUMNA " & "A" & Chr(i))
            cmb67.Items.Add("COLUMNA " & "A" & Chr(i))
            cmb68.Items.Add("COLUMNA " & "A" & Chr(i))
            cmb69.Items.Add("COLUMNA " & "A" & Chr(i))
            cmb70.Items.Add("COLUMNA " & "A" & Chr(i))
            cmb71.Items.Add("COLUMNA " & "A" & Chr(i))
        Next

    End Sub

    Private Sub chk71_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk71.CheckedChanged
        If chk71.Checked = True Then
            cmb71.Enabled = True
        Else
            cmb71.Enabled = False
            datosPpalProy(8) = ""
            datosPpalProy1(8) = ""
        End If
    End Sub

    Private Sub cmb71_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb71.SelectedIndexChanged
        CADENA = cmb71.SelectedItem
        llenarVector()

        Fk = IIf(cmb71.SelectedIndex = -1, 1, cmb71.SelectedIndex + 1)

        datosPpalProy(8) = Fk & ".V"
        datosPpalProy1(8) = Fj & ".V"
    End Sub

  
End Class
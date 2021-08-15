Imports System.Data.OleDb
Imports System.IO
Public Class frmImportacionResp

    'variables de excel para conocer el tipo de datos aceptado por la DB
    'variable tabla ppal de proyectos
    'Public stConexion As String
    'Public cnConex As New OleDbConnection
    Public id As Integer = 0
    Public archivoEx As String = ""
    Public Fk As Integer
    Public sdata As Integer = 0
    Public Fj As Integer
    Public cmb As String = ""
    Public db As Integer = 0
    Public e As Integer = 0
    Public f As Integer = 0
    Public c As Integer = 0
    Public impCta As Integer = 0


    Public fechas(30) As String
    Public montos(30) As String
    Public enteros(30) As String
    Public datosPpalProy(109) As String
    Public datosPpalProy1(109) As String
    Public nroDoc As String = ""
    Public errorimp As Integer = 0

    'VARIABLES IMPORTACION DE DATOS PPALES
    Public pro_Sector As String = ""
    Public pro_nroContrato As String = ""
    Public pro_descripcion As String = ""
    Public pro_provincia As String = ""
    Public pro_monto As Decimal = 0
    Public pro_nroCuenta As Integer = 0
    Public pro_serieCuenta As String = ""
    Public pro_FechaD As Date
    Public pro_FechaH As Date
    Public pro_TrabajoR As Decimal = 0
    Public pro_FechaR As Date
    Public pro_PresInsp As Decimal = 0
    Public pro_FechaP As Date
    Public pro_periodoCuenta As Integer = 0
    Public pro_duracionproy As Integer = 0
    Public pro_FechaInicio As Date
    Public pro_FechaFinOrig As Date
    Public pro_status As String = ""
    Public pro_tipo As String = ""
    Public pro_NroFacturas As String = ""
    Public pro_FechaEstimacion As String = "1900-01-01"
    'VARIABLES DE ENTES



    Public pro_NroRecibo As String = ""
    Public pro_Contratista As String = ""
    Public pro_Cliente As String = ""
    Public pro_Gerente As String = ""
    Public pro_Ingeniero As String = ""
    Public pro_CordCtasMop As String = ""
    Public pro_Gobierno As String = ""
    Public pro_EncGrupo As String = ""
    Public pro_Mtototal As Decimal = 0
    Public pro_FechaTreal As Date
    Public pro_Fechaant As Date
    Public pro_Mes As String = ""
    Public pro_FechaPago As Date
    Public pro_FechaPagoTra As Date
    Public pro_montoCheque As Decimal = 0
    Public pro_analistaCosto As String = ""
    'variables de facturas
    Public pro_FechaRes As Date
    Public pro_NroFactura As String
    Public pro_FechaFact As Date
    Public pro_trabajoFac As Double
    Public pro_Rete10 As Double
    Public pro_MtoRete10 As Double
    Public pro_Anticipo As Double
    Public pro_Penalizacion As Double
    Public pro_RETdeITBMS As Double
    Public pro_MontoITBMS As Double
    Public pro_CuentaCobrar As Double

    Public pro_EntrInsp As Double
    Public pro_FechaCliente As Date
    Public pro_FechaCxc As Date
    Public pro_FechaTes As Date

    'variables de costos

    'Public pro_NroFactura As String
    Public pro_FechaCheque As Date
    Public pro_NroCheque As String
    Public pro_ControlRec As String
    Public pro_ControlCheq As String
    Public pro_MtoCobrar As Double
    Public pro_Rango1 As String
    Public pro_Rango2 As String
    Public pro_Rango As String
    Public pro_Monto2 As Double
    Public pro_Status1 As String
    Public pro_MesEj As String
    Public pro_DocNext As String
    Public pro_Scafid As Double
    Public pro_FechaRefrendo As Date

    'variables controladoras de datos en la importacion
    Public swFact As Integer
    Public swFact1 As Integer





    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub chk1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If chk1.Checked = True Then
            cmb1.Enabled = True
        Else
            cmb1.Enabled = False
        End If
    End Sub

    Private Sub chk2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If chk2.Checked = True Then
            cmb2.Enabled = True
        Else
            cmb2.Enabled = False
        End If
    End Sub

    Private Sub chk3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If chk3.Checked = True Then
            cmb3.Enabled = True
        Else
            cmb3.Enabled = False
        End If
    End Sub

    Private Sub chk4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If chk4.Checked = True Then
            cmb4.Enabled = True
        Else
            cmb4.Enabled = False
        End If
    End Sub

  


    Private Sub frmImportacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        llenaCombos()
        limpiarDatosImport()

    End Sub
    Sub llenaCombos()
        For i = 65 To 90

            cmb1.Items.Add("COLUMNA " & Chr(i))
            cmb2.Items.Add("COLUMNA " & Chr(i))
            cmb3.Items.Add("COLUMNA " & Chr(i))
            cmb4.Items.Add("COLUMNA " & Chr(i))
           
            cmb20.Items.Add("COLUMNA " & Chr(i))
            cmb21.Items.Add("COLUMNA " & Chr(i))
            cmb22.Items.Add("COLUMNA " & Chr(i))
            cmb23.Items.Add("COLUMNA " & Chr(i))
            cmb24.Items.Add("COLUMNA " & Chr(i))
            cmb25.Items.Add("COLUMNA " & Chr(i))
            cmb26.Items.Add("COLUMNA " & Chr(i))
            cmb27.Items.Add("COLUMNA " & Chr(i))
            cmb28.Items.Add("COLUMNA " & Chr(i))
            cmb29.Items.Add("COLUMNA " & Chr(i))
            cmb30.Items.Add("COLUMNA " & Chr(i))
            cmb31.Items.Add("COLUMNA " & Chr(i))
            cmb32.Items.Add("COLUMNA " & Chr(i))
           
            cmb65.Items.Add("COLUMNA " & Chr(i))
            ' cmb32.Items.Add("COLUMNA " & Chr(i))

        Next

        For i = 65 To 90
            cmb1.Items.Add("COLUMNA " & "A" & Chr(i))
            cmb2.Items.Add("COLUMNA " & "A" & Chr(i))
            cmb3.Items.Add("COLUMNA " & "A" & Chr(i))
            cmb4.Items.Add("COLUMNA " & "A" & Chr(i))
          
            cmb20.Items.Add("COLUMNA " & "A" & Chr(i))
            cmb21.Items.Add("COLUMNA " & "A" & Chr(i))
            cmb22.Items.Add("COLUMNA " & "A" & Chr(i))
            cmb23.Items.Add("COLUMNA " & "A" & Chr(i))
            cmb24.Items.Add("COLUMNA " & "A" & Chr(i))
            cmb25.Items.Add("COLUMNA " & "A" & Chr(i))
            cmb26.Items.Add("COLUMNA " & "A" & Chr(i))
            cmb27.Items.Add("COLUMNA " & "A" & Chr(i))
            cmb28.Items.Add("COLUMNA " & "A" & Chr(i))
            cmb29.Items.Add("COLUMNA " & "A" & Chr(i))
            cmb30.Items.Add("COLUMNA " & "A" & Chr(i))
            cmb31.Items.Add("COLUMNA " & "A" & Chr(i))
            cmb32.Items.Add("COLUMNA " & "A" & Chr(i))
           
            cmb65.Items.Add("COLUMNA " & "A" & Chr(i))
        Next
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

    Private Sub cmb1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        CADENA = cmb1.SelectedItem
        llenarVector()
        llenarVectorMonto()
        datosPpalProy(1) = Fk + 1
        datosPpalProy1(1) = Fj


    End Sub
    Sub llenarVectorenteros()
        Dim i As Integer = 0
        For i = 0 To 25

            If enteros(i) = "" Then
                enteros(i) = Fk
                Exit For
            End If

        Next
    End Sub


    Sub llenarVectorMonto()
        Dim i As Integer = 0
        For i = 0 To 25

            If montos(i) = "" Then
                montos(i) = Fk
                Exit For
            End If

        Next
    End Sub
    Sub llenarVectorfecha()
        Dim i As Integer = 0
        For i = 0 To 25

            If fechas(i) = "" Then
                fechas(i) = Fk
                Exit For
            End If

        Next
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

            For i = 0 To 59

                If Dato(i) = "" Or Dato(i) = Nothing Then
                    Dato(i) = valor
                    Fk = 26 + i
                    Fj = valor + 26
                    Exit For
                End If

            Next


        Else
            valor = vectorDatos(Microsoft.VisualBasic.Right(CADENA, 1))

            For i = 0 To 59

                If Dato(i) = "" Or Dato(i) = Nothing Then
                    Dato(i) = valor
                    Fk = i
                    Fj = valor
                    Exit For
                End If

            Next


        End If



    End Sub

    Private Sub cmb2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        CADENA = cmb2.SelectedItem
        llenarVector()
        datosPpalProy(2) = Fk + 1
        datosPpalProy1(2) = Fj

    End Sub

    Private Sub cmb3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CADENA = cmb3.SelectedItem
        llenarVector()
        datosPpalProy(3) = Fk + 1
        datosPpalProy1(3) = Fj

    End Sub
    Private Sub cmb4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CADENA = cmb4.SelectedItem
        llenarVector()
        datosPpalProy(4) = Fk + 1
        datosPpalProy1(4) = Fj

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
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
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

            For i = 1 To 109
                For j = i + 1 To 109

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

                            cmb = "cmb" & i

                            sw = 1
                            swExcel = 1

                        End If

                    End If

                Next

            Next


            If sw = 0 Then

                For i = 0 To 109

                    If datosPpalProy1(i) <> "" Then

                        If Proyecto <> "" Then

                            'controla si el usuario quiera importar datos de facturas
                            If i >= 33 And datosPpalProy1(i) <> "" Then

                                If i = 33 And datosPpalProy1(i) <> "" Then
                                    swFact = 2

                                End If
                                If i = 33 And datosPpalProy1(i) = "" Then
                                    swFact = 1

                                End If


                            End If
                            'controla si el usuario quiera importar datos de facturas
                            If i >= 48 And datosPpalProy1(i) <> "" Then

                                If i = 33 And datosPpalProy1(i) <> "" Then
                                    swFact1 = 2

                                End If
                                If i = 33 And datosPpalProy1(i) = "" Then
                                    swFact1 = 1

                                End If

                            End If



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

                            'controla si el usuario quiera importar datos de facturas
                            If i >= 33 And datosPpalProy1(i) <> "" Then

                                If i = 33 And datosPpalProy1(i) <> "" Then
                                    swFact = 2
                                Else
                                    swFact = 1
                                End If

                            End If
                            'controla si el usuario quiera importar datos de facturas
                            If i >= 48 And datosPpalProy1(i) <> "" Then

                                If i = 33 And datosPpalProy1(i) <> "" Then
                                    swFact1 = 2
                                Else
                                    swFact1 = 1
                                End If

                            End If



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





    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        limpiarDatosImport()
    End Sub
    Sub limpiarDatosImport()
        Try

            Me.gpbDres.DataSource = Nothing
            '  Me.gpbDres.
            'limpia vector
            For i = 0 To 25
                Dato(i) = ""
            Next

            Fk = 0
            Fj = 0
            ' Proyecto = ""

            If Proyecto <> "" Then
                Proyecto = ""

                leeVector()
                ImportExcellToDataGridView(archivoEx, gpbDres)

            End If


        Catch ex As Exception
            MsgBox("Error en Funcion limpiarDatosImport", MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        revisarDatosPrev()
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
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







            If Me.gpbDres.RowCount > 0 Then
                'VALIDO FECHA 
                For i = 0 To 30

                    If fechas(i) <> "" Then
                        index = fechas(i)
                        index1 = index

                        For Fila = 1 To gpbDres.RowCount - 1
                            Try



                                fechi = IIf(gpbDres.Rows(Fila).Cells(index1).Value() Is DBNull.Value, Format(Date.Now, "dd/MM/yyyy"), gpbDres.Rows(Fila).Cells(index1).Value())
                                fecha = Format(fechi, "dd/MM/yyyy")

                                If IsDate(gpbDres.Rows(Fila).Cells(index1).Value()) Then
                                    sdata = 0

                                Else

                                    gpbDres.Rows(Fila).Cells(index1).Value = Format(Date.Now, "dd/MM/yyyy")
                                    'sdata = 1
                                    'Me.gpbDres.CurrentCell = Me.gpbDres(index1, Fila)
                                    'MsgBox("FECHA INVALIDA", MsgBoxStyle.Critical, "Control Proyectos")
                                    'Exit Sub
                                End If
                            Catch ex As Exception
                                gpbDres.Rows(Fila).Cells(index1).Value = Format(Date.Now, "dd/MM/yyyy")
                                'sdata = 1
                                'Me.gpbDres.CurrentCell = Me.gpbDres(index1, Fila)
                                'MsgBox("FECHA INVALIDA", MsgBoxStyle.Critical, "Control Proyectos")
                                'Exit Sub



                            End Try
                        Next Fila

                    End If

                Next

            End If


            'VALIDO MONTO
            For i = 0 To 30

                If montos(i) <> "" Then
                    index = montos(i)
                    index1 = index

                    For Fila = 1 To gpbDres.RowCount - 1
                        Try
                            monto = gpbDres.Rows(Fila).Cells(index1).Value()

                            If IsNumeric(monto) Then
                                sdata = 0
                            Else
                                gpbDres.Rows(Fila).Cells(index1).Value = 0

                                'sdata = 1
                                'Me.gpbDres.CurrentCell = Me.gpbDres(index1, Fila)
                                'MsgBox("Monto Invalido", MsgBoxStyle.Critical, "Control Proyectos")
                                'Exit Sub

                            End If
                        Catch ex As Exception

                            gpbDres.Rows(Fila).Cells(index1).Value = 0
                            'sdata = 1
                            'Me.gpbDres.CurrentCell = Me.gpbDres(index1, Fila)
                            'MsgBox("Monto Invalido", MsgBoxStyle.Critical, "Control Proyectos")
                            'Exit Sub
                        End Try

                    Next Fila

                End If

            Next

            '  VALIDO CAMPOS ENTEROS
            For i = 0 To 30

                If enteros(i) <> "" Then
                    index = enteros(i)
                    index1 = index

                    For Fila = 1 To gpbDres.RowCount - 1
                        Try
                            ent = gpbDres.Rows(Fila).Cells(index1).Value()

                            If ent <> 0 Then
                                sdata = 0
                            Else
                                gpbDres.Rows(Fila).Cells(index1).Value = 0
                                'sdata = 1
                                'Me.gpbDres.CurrentCell = Me.gpbDres(index1, Fila)
                                'MsgBox("Campo debe ser entero", MsgBoxStyle.Critical, "Control Proyectos")
                                'Exit Sub

                            End If
                        Catch ex As Exception

                            gpbDres.Rows(Fila).Cells(index1).Value = 0
                            'sdata = 1
                            'Me.gpbDres.CurrentCell = Me.gpbDres(index1, Fila)
                            'MsgBox("Campo debe ser entero", MsgBoxStyle.Critical, "Control Proyectos")
                            'Exit Sub
                        End Try

                    Next Fila

                End If

            Next


            ' VALIDO CAMPOS VACIOS
            If Me.gpbDres.RowCount > 0 Then
                For i = 0 To gpbDres.RowCount - 1
                    For j = 0 To gpbDres.ColumnCount - 1
                        If gpbDres.Rows(i).Cells(j).Value() Is DBNull.Value Then
                            gpbDres.Rows(i).Cells(j).Value = "0"

                            MsgBox("Existen Campos Vacios, por favor revise el archivo", MsgBoxStyle.Critical, "Control Proyectos")
                            Me.gpbDres.CurrentCell = Me.gpbDres(j, i)

                            Exit Sub
                        End If
                    Next
                Next
            End If




            sdata = 0
            If sdata = 0 Then
                MsgBox("Datos listos para Importar", MsgBoxStyle.Information, "Control Proyectos")
                ToolStripButton3.Enabled = True
            End If

        Catch ex As Exception
            MsgBox("Error en funcion revisarDatosPrev()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        importarDatosPpalProy()
    End Sub



    Sub importarDatosPpalProy()
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

                        ProyNro = gpbDres.Rows(Fila).Cells(k).Value()
                        swNroProyIni = ProyNro
                        nP = k
                        k = k + 1
                    End If


                    valor = Val(datosPpalProy(2))
                    If valor <> "" And valor <> 0 Then

                        pro_descripcion = gpbDres.Rows(Fila).Cells(k).Value()
                        DescProy = pro_descripcion
                        strDescProy = pro_descripcion
                        k = k + 1
                    End If

                    valor = Val(datosPpalProy(3))

                    If valor <> "" And valor <> 0 Then

                        pro_Sector = UCase(gpbDres.Rows(Fila).Cells(k).Value())
                        k = k + 1
                    End If


                    valor = Val(datosPpalProy(4))
                    If valor <> "" And valor <> 0 Then

                        pro_nroContrato = gpbDres.Rows(Fila).Cells(k).Value()
                        swNroContIni = pro_nroContrato
                        ContNro = pro_nroContrato
                        nC = k
                        k = k + 1
                    End If


                    valor = Val(datosPpalProy(5))
                    If valor <> "" And valor <> 0 Then

                        pro_provincia = IIf(gpbDres.Rows(Fila).Cells(k).Value() Is DBNull.Value, "", gpbDres.Rows(Fila).Cells(k).Value())
                        k = k + 1

                    End If

                    valor = Val(datosPpalProy(6))
                    If valor <> "" And valor <> 0 Then

                        pro_monto = IIf(gpbDres.Rows(Fila).Cells(k).Value() Is DBNull.Value, 0, gpbDres.Rows(Fila).Cells(k).Value())
                        k = k + 1
                    End If



                    guardaImportActDPpalProy()

                    If ContNro <> "" And errorimp = 0 Then
                        insertNroContimp(stridProy, ProyNro, ContNro, RecNro, FactNro)
                    End If

                    nP = db



                Next Fila
                db = k
            End If


        Catch ex As Exception
            MsgBox("Error en funcion importarDatosPpalProy()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
            errorimp = 1
        End Try
    End Sub

    Sub importarDatosPpalProyCompl()
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
            Dim dbP As Integer = 0
            Dim i As Integer = 1
            'recorre gridview para importar los datos

            'variable de inicio del grid
            dbP = db

            If Me.gpbDres.RowCount > 0 Then

                For Fila = 1 To gpbDres.RowCount - 1

                    'VALIDA NRO DE PROYECTOS
                    k = 0
                    valor = Val(datosPpalProy(1))
                    If valor <> "" And valor <> 0 Then

                        ProyNro = gpbDres.Rows(Fila).Cells(k).Value()

                        If swNroProyIni <> ProyNro Then
                            i = 1
                        End If

                        swNroProyIni = ProyNro

                        nP = k
                        k = k + 1
                    End If

                    valor = Val(datosPpalProy(2))
                    If valor <> "" And valor <> 0 Then

                        pro_descripcion = gpbDres.Rows(Fila).Cells(k).Value()
                        DescProy = pro_descripcion
                        strDescProy = pro_descripcion
                        k = k + 1
                    End If

                    valor = Val(datosPpalProy(3))

                    If valor <> "" And valor <> 0 Then

                        pro_Sector = UCase(gpbDres.Rows(Fila).Cells(k).Value())
                        k = k + 1
                    End If

                    valor = Val(datosPpalProy(4))
                    If valor <> "" And valor <> 0 Then

                        pro_nroContrato = gpbDres.Rows(Fila).Cells(k).Value()
                        swNroContIni = pro_nroContrato
                        ContNro = pro_nroContrato
                        nC = k
                        k = k + 1
                    End If



                    valor = Val(datosPpalProy(7))
                    If valor <> "" And valor <> 0 Then

                        pro_serieCuenta = gpbDres.Rows(Fila).Cells(db).Value()
                        pro_nroCuenta = i
                        CtaNro = i
                        i = i + 1
                        db = db + 1

                    End If


                    valor = Val(datosPpalProy(8))
                    If valor <> "" And valor <> 0 Then
                        If IsDate(gpbDres.Rows(Fila).Cells(db).Value()) Then
                            pro_FechaD = gpbDres.Rows(Fila).Cells(db).Value()
                        Else
                            pro_FechaD = "1900-01-01"
                        End If


                        db = db + 1
                    Else
                        pro_FechaD = "1900-01-01"
                    End If

                    valor = Val(datosPpalProy(9))
                    If valor <> "" And valor <> 0 Then

                        If IsDate(gpbDres.Rows(Fila).Cells(db).Value()) Then
                            pro_FechaH = gpbDres.Rows(Fila).Cells(db).Value()
                        Else
                            pro_FechaH = "1900-01-01"
                        End If


                        db = db + 1
                    Else
                        pro_FechaH = "1900-01-01"
                    End If

                    valor = Val(datosPpalProy(10))
                    If valor <> "" And valor <> 0 Then

                        pro_TrabajoR = gpbDres.Rows(Fila).Cells(db).Value()
                        db = db + 1
                    End If

                    valor = Val(datosPpalProy(11))
                    If valor <> "" And valor <> 0 Then

                        If IsDate(gpbDres.Rows(Fila).Cells(db).Value()) Then
                            pro_FechaR = gpbDres.Rows(Fila).Cells(db).Value()
                        Else
                            pro_FechaR = "1900-01-01"
                        End If


                        db = db + 1
                    Else
                        pro_FechaR = "1900-01-01"
                    End If

                    valor = Val(datosPpalProy(12))

                    If valor <> "" And valor <> 0 Then

                        pro_PresInsp = IIf(gpbDres.Rows(Fila).Cells(db).Value() Is DBNull.Value, 0, gpbDres.Rows(Fila).Cells(db).Value())
                        db = db + 1
                    End If

                    valor = Val(datosPpalProy(13))
                    If valor <> "" And valor <> 0 Then

                        If IsDate(gpbDres.Rows(Fila).Cells(db).Value()) Then
                            pro_FechaP = gpbDres.Rows(Fila).Cells(db).Value()
                        Else
                            pro_FechaP = "1900-01-01"
                        End If


                        db = db + 1
                    Else
                        pro_FechaP = "1900-01-01"
                    End If

                    valor = Val(datosPpalProy(14))
                    If valor <> "" And valor <> 0 Then

                        pro_duracionproy = IIf(gpbDres.Rows(Fila).Cells(db).Value() Is DBNull.Value, 0, gpbDres.Rows(Fila).Cells(db).Value())
                        db = db + 1
                    End If

                    valor = Val(datosPpalProy(15))
                    If valor <> "" And valor <> 0 Then

                        pro_periodoCuenta = IIf(gpbDres.Rows(Fila).Cells(db).Value() Is DBNull.Value, 0, gpbDres.Rows(Fila).Cells(db).Value())
                        db = db + 1
                    End If

                    valor = Val(datosPpalProy(16))
                    If valor <> "" And valor <> 0 Then
                        If IsDate(gpbDres.Rows(Fila).Cells(db).Value()) Then
                            pro_FechaInicio = gpbDres.Rows(Fila).Cells(db).Value()
                        Else
                            pro_FechaInicio = "1900-01-01"
                        End If

                        db = db + 1
                    Else
                        pro_FechaInicio = "1900-01-01"
                    End If

                    valor = Val(datosPpalProy(17))

                    If valor <> "" And valor <> 0 Then
                        If IsDate(gpbDres.Rows(Fila).Cells(db).Value()) Then
                            pro_FechaFinOrig = gpbDres.Rows(Fila).Cells(db).Value()
                        Else
                            pro_FechaFinOrig = "1900-01-01"
                        End If



                        db = db + 1
                    Else
                        pro_FechaFinOrig = "1900-01-01"
                    End If

                    valor = Val(datosPpalProy(18))

                    If valor <> "" And valor <> 0 Then

                        pro_status = UCase(IIf(gpbDres.Rows(Fila).Cells(db).Value() Is DBNull.Value, 0, gpbDres.Rows(Fila).Cells(db).Value()))
                        db = db + 1

                    End If

                    valor = Val(datosPpalProy(19))
                    If valor <> "" And valor <> 0 Then

                        pro_tipo = UCase(IIf(gpbDres.Rows(Fila).Cells(db).Value() Is DBNull.Value, 0, gpbDres.Rows(Fila).Cells(db).Value()))
                        db = db + 1
                    End If

                    'valor = Val(datosPpalProy(33))
                    'If valor <> "" And valor <> 0 Then

                    '    pro_NroFactura = IIf(gpbDres.Rows(Fila).Cells(db).Value() Is DBNull.Value, 0, gpbDres.Rows(Fila).Cells(db).Value())
                    '    db = db + 1

                    'End If


                    guardaImportActDPpalProyComp()

                    If ContNro <> "" And errorimp = 0 Then
                        insertNroContimp(stridProy, ProyNro, ContNro, RecNro, FactNro)
                    End If
                    nP = db
                    db = dbP


                Next Fila


                e = nP
            End If


        Catch ex As Exception
            MsgBox("Error en funcion importarDatosPpalProycompl()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
            errorimp = 1
        End Try
    End Sub


    Sub importarDatosEntesProy()
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
            Dim eP As Integer = 0
            'recorre gridview para importar los datos

            'variable de inicio del grid
            e = 4
            eP = e
            If Me.gpbDres.RowCount > 0 Then

                For Fila = 1 To gpbDres.RowCount - 1

                    'VALIDA NRO DE PROYECTOS
                    k = 0
                    valor = Val(datosPpalProy(1))
                    If valor <> "" And valor <> 0 Then

                        ProyNro = gpbDres.Rows(Fila).Cells(k).Value()
                        swNroProyIni = ProyNro
                        nP = k
                        k = k + 1
                    End If


                    valor = Val(datosPpalProy(2))
                    If valor <> "" And valor <> 0 Then

                        pro_descripcion = gpbDres.Rows(Fila).Cells(k).Value()
                        DescProy = pro_descripcion
                        strDescProy = pro_descripcion
                        k = k + 1
                    End If

                    valor = Val(datosPpalProy(3))

                    If valor <> "" And valor <> 0 Then

                        pro_Sector = UCase(gpbDres.Rows(Fila).Cells(k).Value())
                        k = k + 1
                    End If


                    valor = Val(datosPpalProy(4))
                    If valor <> "" And valor <> 0 Then

                        pro_nroContrato = gpbDres.Rows(Fila).Cells(k).Value()
                        swNroContIni = pro_nroContrato
                        ContNro = pro_nroContrato
                        nC = k
                        k = k + 1
                    End If

                    valor = Val(datosPpalProy(20))
                    If valor <> "" And valor <> 0 Then

                        pro_Contratista = IIf(gpbDres.Rows(Fila).Cells(e).Value() Is DBNull.Value, "", gpbDres.Rows(Fila).Cells(e).Value())
                        e = e + 1

                    End If

                    valor = Val(datosPpalProy(21))
                    If valor <> "" And valor <> 0 Then

                        pro_Cliente = IIf(gpbDres.Rows(Fila).Cells(e).Value() Is DBNull.Value, "", gpbDres.Rows(Fila).Cells(e).Value())
                        e = e + 1
                    End If

                    valor = Val(datosPpalProy(22))
                    If valor <> "" And valor <> 0 Then

                        pro_Gerente = IIf(gpbDres.Rows(Fila).Cells(e).Value() Is DBNull.Value, "", gpbDres.Rows(Fila).Cells(e).Value())
                        e = e + 1
                    End If


                    valor = Val(datosPpalProy(23))
                    If valor <> "" And valor <> 0 Then

                        pro_Ingeniero = IIf(gpbDres.Rows(Fila).Cells(e).Value() Is DBNull.Value, "", gpbDres.Rows(Fila).Cells(e).Value())
                        e = e + 1
                    End If

                    valor = Val(datosPpalProy(24))
                    If valor <> "" And valor <> 0 Then

                        pro_CordCtasMop = IIf(gpbDres.Rows(Fila).Cells(e).Value() Is DBNull.Value, "", gpbDres.Rows(Fila).Cells(e).Value())
                        e = e + 1
                    End If

                    valor = Val(datosPpalProy(25))
                    If valor <> "" And valor <> 0 Then

                        pro_Gobierno = IIf(gpbDres.Rows(Fila).Cells(e).Value() Is DBNull.Value, "", gpbDres.Rows(Fila).Cells(e).Value())
                        e = e + 1
                    End If

                    valor = Val(datosPpalProy(26))
                    If valor <> "" And valor <> 0 Then

                        pro_EncGrupo = IIf(gpbDres.Rows(Fila).Cells(e).Value() Is DBNull.Value, "", gpbDres.Rows(Fila).Cells(e).Value())
                        e = e + 1
                    End If

                    valor = Val(datosPpalProy(27))
                    If valor <> "" And valor <> 0 Then

                        pro_Mtototal = IIf(gpbDres.Rows(Fila).Cells(e).Value() Is DBNull.Value, 0, gpbDres.Rows(Fila).Cells(e).Value())
                        e = e + 1
                    End If

                    valor = Val(datosPpalProy(28))
                    If valor <> "" And valor <> 0 Then

                        pro_FechaTreal = gpbDres.Rows(Fila).Cells(e).Value()
                        e = e + 1
                    Else
                        pro_FechaTreal = "1900-01-01"
                    End If

                    valor = Val(datosPpalProy(29))
                    If valor <> "" And valor <> 0 Then

                        pro_Fechaant = gpbDres.Rows(Fila).Cells(e).Value()
                        e = e + 1
                    Else
                        pro_Fechaant = "1900-01-01"
                    End If

                    valor = Val(datosPpalProy(30))
                    If valor <> "" And valor <> 0 Then

                        pro_Mes = IIf(gpbDres.Rows(Fila).Cells(e).Value() Is DBNull.Value, "", gpbDres.Rows(Fila).Cells(e).Value())
                        e = e + 1

                    End If

                    valor = Val(datosPpalProy(31))
                    If valor <> "" And valor <> 0 Then

                        pro_FechaPago = gpbDres.Rows(Fila).Cells(e).Value()
                        e = e + 1
                    Else
                        pro_FechaPago = "1900-01-01"
                    End If

                    valor = Val(datosPpalProy(32))
                    If valor <> "" And valor <> 0 Then

                        pro_FechaPagoTra = gpbDres.Rows(Fila).Cells(e).Value()
                        e = e + 1
                    Else
                        pro_FechaPagoTra = "1900-01-01"
                    End If


                    valor = Val(datosPpalProy(65))
                    If valor <> "" And valor <> 0 Then

                        pro_analistaCosto = IIf(gpbDres.Rows(Fila).Cells(e).Value() Is DBNull.Value, "", gpbDres.Rows(Fila).Cells(e).Value())
                        e = e + 1

                    End If

                    guardaImportActProyeDResp()



                    nP = e
                    e = eP

                Next Fila

                f = nP
            End If


        Catch ex As Exception
            MsgBox("Error en funcion importarDatosEntesProy()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
            errorimp = 1
        End Try
    End Sub


    Public Function impinsertNroFact(ByVal id As Decimal, ByVal NroProy As String, ByVal NroCont As String, ByVal Rec As String, ByVal Fact As String)
        ConexionSQL()
        Dim sw As Integer = 0
        Try
            Dim strNro As New ADODB.Recordset
            Dim preg As String = ""
            Dim strcta As New ADODB.Recordset
            Dim i As Integer = 1
            'si no existe los datos del nro proyecto y el nro de contrato


            If Rec <> "" Then
                strNro = cntSQL.Execute("SELECT cta_Nro, [id_proyecto] ,[nro_proyecto] ,[nro_contrato],[nro_recibo],[nro_Factura]  FROM [dbo].[tab_NrosReciboProy] where [nro_proyecto] ='" & NroProy & "' and [nro_contrato]='" & NroCont & "' AND  [nro_Factura]='" & Fact & "' and nro_recibo='" & Rec & "'")

                'inserta la factura
                If strNro.EOF = True Then
                    'luego preguntamos si ya esta cargado un dato del contrato
                    strNro = cntSQL.Execute("SELECT cta_Nro, [id_proyecto] ,[nro_proyecto] ,[nro_contrato],[nro_recibo],[nro_Factura]  FROM [dbo].[tab_NrosReciboProy] where [nro_proyecto] ='" & NroProy & "' and [nro_contrato]='" & NroCont & "' AND  [nro_Factura]='' ")
                    If strNro.EOF = False Then

                        cntSQL.Execute("UPDATE [tab_NrosReciboProy] SET [nro_Factura]='" & Fact & "',nro_recibo='" & Rec & "' WHERE [id_proyecto] =" & id & " and [nro_proyecto]= '" & NroProy & "' and [nro_contrato]='" & NroCont & "' AND  [nro_Factura]='' ")

                    Else
                        strcta = cntSQL.Execute("SELECT max(cta_Nro) as cta_Nro FROM [dbo].[tab_NrosReciboProy] where [nro_proyecto] ='" & NroProy & "' and [nro_contrato]='" & NroCont & "'")

                        If strcta.EOF = False Then
                            i = i + Val(IIf(strcta.Fields("cta_Nro").Value Is DBNull.Value, 0, strcta.Fields("cta_Nro").Value))
                        End If


                        cntSQL.Execute("insert into [tab_NrosReciboProy](cta_Nro,[id_proyecto] ,[nro_proyecto] ,[nro_contrato],[nro_recibo],[nro_Factura]) values (" & i & "," & id & ", '" & NroProy & "', '" & NroCont & "','" & Rec & "', '" & Fact & "')")
                        FactNro = Fact

                        CtaNro = i
                    End If



                Else
                    cntSQL.Execute("UPDATE [tab_NrosReciboProy] SET [nro_Factura]='" & Fact & "' WHERE [id_proyecto] =" & id & " and [nro_proyecto]= '" & NroProy & "' and [nro_contrato]='" & NroCont & "' AND  [nro_Factura]='" & Fact & "' and nro_recibo='" & Rec & "'")

                End If


            End If
            If Rec = "" Then
                strNro = cntSQL.Execute("SELECT cta_Nro, [id_proyecto] ,[nro_proyecto] ,[nro_contrato],[nro_recibo],[nro_Factura]  FROM [dbo].[tab_NrosReciboProy] where [nro_proyecto] ='" & NroProy & "' and [nro_contrato]='" & NroCont & "' AND  [nro_Factura]='" & Fact & "' ")

                'inserta la factura
                If strNro.EOF = True Then

                    strcta = cntSQL.Execute("SELECT max(cta_Nro) as cta_Nro FROM [dbo].[tab_NrosReciboProy] where [nro_proyecto] ='" & NroProy & "' and [nro_contrato]='" & NroCont & "' ")

                    If strcta.EOF = False Then
                        i = i + Val(IIf(strcta.Fields("cta_Nro").Value Is DBNull.Value, 0, strcta.Fields("cta_Nro").Value))
                    End If

                    cntSQL.Execute("insert into [tab_NrosReciboProy](cta_Nro,[id_proyecto] ,[nro_proyecto] ,[nro_contrato],[nro_recibo],[nro_Factura]) values (" & i & "," & id & ", '" & NroProy & "', '" & NroCont & "','" & Rec & "', '" & Fact & "')")
                    FactNro = Fact

                    CtaNro = i
                Else
                    cntSQL.Execute("UPDATE [tab_NrosReciboProy] SET [nro_Factura]='" & Fact & "' WHERE [id_proyecto] =" & id & " and [nro_proyecto]= '" & NroProy & "' and [nro_contrato]='" & NroCont & "' AND  [nro_Factura]='" & Fact & "' and  nro_recibo=''")

                End If


            End If




            'If Rec <> "" Then
            '    strNro = cntSQL.Execute("SELECT cta_Nro, [id_proyecto] ,[nro_proyecto] ,[nro_contrato],[nro_recibo],[nro_Factura]  FROM [dbo].[tab_NrosReciboProy] where [nro_proyecto] ='" & NroProy & "' and [nro_contrato]='" & NroCont & "' AND  [nro_Factura]='" & Fact & "' and nro_recibo='" & Rec & "' ")

            '    If strNro.EOF = True Then


            '        strcta = cntSQL.Execute("SELECT max(cta_Nro) as cta_Nro FROM [dbo].[tab_NrosReciboProy] where [nro_proyecto] ='" & NroProy & "' and [nro_contrato]='" & NroCont & "' ")

            '        If strcta.EOF = False Then
            '            i = i + Val(IIf(strcta.Fields("cta_Nro").Value Is DBNull.Value, 0, strcta.Fields("cta_Nro").Value))
            '        End If

            '        cntSQL.Execute("insert into [tab_NrosReciboProy](cta_Nro,[id_proyecto] ,[nro_proyecto] ,[nro_contrato],[nro_recibo],[nro_Factura]) values (" & i & "," & id & ", '" & NroProy & "', '" & NroCont & "','" & Rec & "', '" & Fact & "')")
            '        FactNro = Fact

            '        CtaNro = i
            '    Else
            '        cntSQL.Execute("UPDATE [tab_NrosReciboProy] SET [nro_recibo]='" & Rec & "' WHERE [id_proyecto] =" & id & " and [nro_proyecto]= '" & NroProy & "' and [nro_contrato]='" & NroCont & "' and [nro_Factura]='" & Fact & "'  and nro_recibo='" & Rec & "' ")


            '    End If



            'End If



        Catch ex As Exception
            MsgBox("Error en funcion insertNroFact" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try


        Return idProy

    End Function
    Sub importarDatosCostosMantProy()
        Try
            swFact = 0
            Dim valor As String = ""
            Dim valor1 As Integer = 0
            Dim swNroProyIni As String = ""
            Dim swNroProyNext As String = ""
            Dim swNroContIni As String = ""
            Dim swNroContNext As String = ""
            Dim k As Integer = 0
            Dim nC As Integer = 0
            Dim nP As Integer = 0
            Dim cP As Integer = 0
            'recorre gridview para importar los datos

            cP = c
            If Me.gpbDres.RowCount > 0 Then

                For Fila = 1 To gpbDres.RowCount - 1

                    'VALIDA NRO DE PROYECTOS
                    k = 0
                    valor = Val(datosPpalProy(1))
                    If valor <> "" And valor <> 0 Then

                        ProyNro = gpbDres.Rows(Fila).Cells(k).Value()
                        swNroProyIni = ProyNro
                        nP = k
                        k = k + 1
                    End If


                    valor = Val(datosPpalProy(2))
                    If valor <> "" And valor <> 0 Then

                        pro_descripcion = gpbDres.Rows(Fila).Cells(k).Value()
                        DescProy = pro_descripcion
                        strDescProy = pro_descripcion
                        k = k + 1
                    End If

                    valor = Val(datosPpalProy(3))

                    If valor <> "" And valor <> 0 Then

                        pro_Sector = UCase(gpbDres.Rows(Fila).Cells(k).Value())
                        k = k + 1
                    End If


                    valor = Val(datosPpalProy(4))
                    If valor <> "" And valor <> 0 Then

                        pro_nroContrato = gpbDres.Rows(Fila).Cells(k).Value()
                        swNroContIni = pro_nroContrato
                        ContNro = pro_nroContrato
                        nC = k
                        k = k + 1
                    End If


                    valor = Val(datosPpalProy(33))
                    If valor <> "" And valor <> 0 Then

                        pro_NroFactura = gpbDres.Rows(Fila).Cells(f).Value()
                        swFact = 2
                        swFact1 = 2
                        f = f + 1
                    End If


                    valor = Val(datosPpalProy(48))
                    If valor <> "" And valor <> 0 Then

                        pro_FechaCheque = gpbDres.Rows(Fila).Cells(c).Value()
                        c = c + 1
                    Else
                        pro_FechaCheque = "1900-01-01"
                    End If


                    valor = Val(datosPpalProy(49))
                    If valor <> "" And valor <> 0 Then

                        pro_NroCheque = gpbDres.Rows(Fila).Cells(c).Value()
                        c = c + 1

                    End If


                    valor = Val(datosPpalProy(50))
                    If valor <> "" And valor <> 0 Then

                        pro_ControlRec = gpbDres.Rows(Fila).Cells(c).Value()
                        c = c + 1
                    End If

                    valor = Val(datosPpalProy(52))
                    If valor <> "" And valor <> 0 Then

                        pro_ControlCheq = gpbDres.Rows(Fila).Cells(c).Value()
                        c = c + 1
                    End If

                    valor = Val(datosPpalProy(53))
                    If valor <> "" And valor <> 0 Then

                        pro_MtoCobrar = gpbDres.Rows(Fila).Cells(c).Value()
                        c = c + 1
                    End If

                    valor = Val(datosPpalProy(54))
                    If valor <> "" And valor <> 0 Then

                        pro_MontoITBMS = gpbDres.Rows(Fila).Cells(c).Value()
                        c = c + 1
                    End If

                    valor = Val(datosPpalProy(55))
                    If valor <> "" And valor <> 0 Then

                        pro_Rango1 = gpbDres.Rows(Fila).Cells(c).Value()
                        c = c + 1
                    End If

                    valor = Val(datosPpalProy(56))
                    If valor <> "" And valor <> 0 Then

                        pro_Rango2 = gpbDres.Rows(Fila).Cells(c).Value()
                        c = c + 1

                    End If

                    valor = Val(datosPpalProy(57))
                    If valor <> "" And valor <> 0 Then

                        pro_Rango = gpbDres.Rows(Fila).Cells(c).Value()
                        c = c + 1

                    End If

                    valor = Val(datosPpalProy(58))
                    If valor <> "" And valor <> 0 Then

                        pro_Monto2 = gpbDres.Rows(Fila).Cells(c).Value()
                        c = c + 1


                    End If

                    valor = Val(datosPpalProy(59))
                    If valor <> "" And valor <> 0 Then

                        pro_Status1 = gpbDres.Rows(Fila).Cells(c).Value()
                        c = c + 1

                    End If

                    valor = Val(datosPpalProy(60))
                    If valor <> "" And valor <> 0 Then

                        pro_MesEj = gpbDres.Rows(Fila).Cells(c).Value()
                        c = c + 1

                    End If

                    valor = Val(datosPpalProy(61))
                    If valor <> "" And valor <> 0 Then

                        pro_DocNext = gpbDres.Rows(Fila).Cells(c).Value()
                        c = c + 1

                    End If

                    valor = Val(datosPpalProy(62))
                    If valor <> "" And valor <> 0 Then

                        pro_Scafid = gpbDres.Rows(Fila).Cells(c).Value()
                        c = c + 1

                    End If
                    valor = Val(datosPpalProy(63))
                    If valor <> "" And valor <> 0 Then

                        pro_FechaRefrendo = gpbDres.Rows(Fila).Cells(c).Value()
                        c = c + 1

                    Else
                        pro_FechaRefrendo = "1900-01-01"
                    End If


                    Me.guardaActProyeimportDCostos()

                    'If ContNro <> "" And FactNro <> "" And errorimp = 0 Then
                    '    impinsertNroFact(stridProy, ProyNro, ContNro, RecNro, FactNro)
                    'End If


                    'If ContNro <> "" And FactNro <> "" And RecNro <> "" And errorimp = 0 Then
                    '    impinsertNroRec(stridProy, ProyNro, ContNro, RecNro, FactNro)
                    'End If

                    c = cP

                Next Fila


            End If


        Catch ex As Exception
            MsgBox("Error en funcion importarDatosCostosMantProy()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
            errorimp = 1

        End Try
    End Sub
    Public Function impinsertNroRec(ByVal id As Decimal, ByVal NroProy As String, ByVal NroCont As String, ByVal Rec As String, ByVal Fact As String)
        ConexionSQL()
        Dim sw As Integer = 0
        Try
            Dim strNro As New ADODB.Recordset
            Dim preg As String = ""
            Dim strcta As New ADODB.Recordset
            Dim i As Integer = 1
            Dim swval As Integer = 0
            'si no existe los datos del nro proyecto y el nro de contrato


            strNro = cntSQL.Execute("SELECT cta_Nro, [id_proyecto] ,[nro_proyecto] ,[nro_contrato],[nro_recibo],[nro_Factura]  FROM [dbo].[tab_NrosReciboProy] where [nro_proyecto] ='" & NroProy & "' and [nro_contrato]='" & NroCont & "' and [nro_Factura] ='" & Fact & "' and nro_recibo ='" & Rec & "' ")


            If strNro.EOF = True Then
                strNro = cntSQL.Execute("SELECT cta_Nro, [id_proyecto] ,[nro_proyecto] ,[nro_contrato],[nro_recibo],[nro_Factura]  FROM [dbo].[tab_NrosReciboProy] where [nro_proyecto] ='" & NroProy & "' and [nro_contrato]='" & NroCont & "' and [nro_Factura] ='" & Fact & "' and nro_recibo =''")

                If strNro.EOF = False Then
                    cntSQL.Execute("update [tab_NrosReciboProy]set nro_recibo ='" & Rec & "' where [nro_proyecto] ='" & NroProy & "' and [nro_contrato]='" & NroCont & "' and [nro_Factura] ='" & Fact & "'")

                    swval = 1
                End If

            End If


            If swval = 0 Then

                strNro = cntSQL.Execute("SELECT cta_Nro, [id_proyecto] ,[nro_proyecto] ,[nro_contrato],[nro_recibo],[nro_Factura]  FROM [dbo].[tab_NrosReciboProy] where [nro_proyecto] ='" & NroProy & "' and [nro_contrato]='" & NroCont & "' and [nro_Factura] ='" & Fact & "' and nro_recibo ='" & Rec & "'")

                If strNro.EOF = True Then

                    strcta = cntSQL.Execute("SELECT max(cta_Nro) as cta_Nro FROM [dbo].[tab_NrosReciboProy] where [nro_proyecto] ='" & NroProy & "' and [nro_contrato]='" & NroCont & "' ")

                    If strcta.EOF = False Then
                        i = i + Val(IIf(strcta.Fields("cta_Nro").Value Is DBNull.Value, 0, strcta.Fields("cta_Nro").Value))
                    End If

                    cntSQL.Execute("insert into [tab_NrosReciboProy](cta_Nro,[id_proyecto] ,[nro_proyecto] ,[nro_contrato],[nro_recibo],[nro_Factura]) values (" & i & "," & id & ", '" & NroProy & "', '" & NroCont & "','" & Rec & "', '" & Fact & "')")
                    FactNro = Fact

                    CtaNro = i

                Else
                    cntSQL.Execute("update [tab_NrosReciboProy]set nro_recibo ='" & Rec & "' where [nro_proyecto] ='" & NroProy & "' and [nro_contrato]='" & NroCont & "' and [nro_Factura] ='" & Fact & "'")


                End If
            End If
            RecNro = Rec


        Catch ex As Exception
            MsgBox("Error en funcion insertNroRec" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try


        Return idProy

    End Function

    Sub importarDatosFactProy()
        Try
            swFact = 0
            Dim valor As String = ""
            Dim valor1 As Integer = 0
            Dim swNroProyIni As String = ""
            Dim swNroProyNext As String = ""
            Dim swNroContIni As String = ""
            Dim swNroContNext As String = ""
            Dim k As Integer = 0
            Dim nC As Integer = 0
            Dim nP As Integer = 0
            Dim fP As Integer = 0
            'recorre gridview para importar los datos

            fP = f
            If Me.gpbDres.RowCount > 0 Then

                For Fila = 1 To gpbDres.RowCount - 1

                    'VALIDA NRO DE PROYECTOS
                    k = 0
                    valor = Val(datosPpalProy(1))
                    If valor <> "" And valor <> 0 Then

                        ProyNro = gpbDres.Rows(Fila).Cells(k).Value()
                        swNroProyIni = ProyNro
                        nP = k
                        k = k + 1
                    End If


                    valor = Val(datosPpalProy(2))
                    If valor <> "" And valor <> 0 Then

                        pro_descripcion = gpbDres.Rows(Fila).Cells(k).Value()
                        DescProy = pro_descripcion
                        strDescProy = pro_descripcion
                        k = k + 1
                    End If

                    valor = Val(datosPpalProy(3))

                    If valor <> "" And valor <> 0 Then

                        pro_Sector = UCase(gpbDres.Rows(Fila).Cells(k).Value())
                        k = k + 1
                    End If


                    valor = Val(datosPpalProy(4))
                    If valor <> "" And valor <> 0 Then

                        pro_nroContrato = gpbDres.Rows(Fila).Cells(k).Value()
                        swNroContIni = pro_nroContrato
                        ContNro = pro_nroContrato
                        nC = k
                        k = k + 1
                    End If

                    valor = Val(datosPpalProy(33))
                    If valor <> "" And valor <> 0 Then

                        pro_NroFactura = IIf(gpbDres.Rows(Fila).Cells(f).Value() Is DBNull.Value, "", gpbDres.Rows(Fila).Cells(f).Value())
                        FactNro = pro_NroFactura
                        swFact = 2
                        f = f + 1

                    End If

                    valor = Val(datosPpalProy(34))
                    If valor <> "" And valor <> 0 Then

                        pro_FechaFact = gpbDres.Rows(Fila).Cells(f).Value()
                        f = f + 1
                    Else
                        pro_FechaFact = "1900-01-01"
                    End If


                    valor = Val(datosPpalProy(35))
                    If valor <> "" And valor <> 0 Then

                        pro_trabajoFac = IIf(gpbDres.Rows(Fila).Cells(f).Value() Is DBNull.Value, 0, gpbDres.Rows(Fila).Cells(f).Value())
                        f = f + 1

                    End If


                    valor = Val(datosPpalProy(36))
                    If valor <> "" And valor <> 0 Then

                        pro_MtoRete10 = IIf(gpbDres.Rows(Fila).Cells(f).Value() Is DBNull.Value, 0, gpbDres.Rows(Fila).Cells(f).Value())
                        f = f + 1
                    End If

                    valor = Val(datosPpalProy(37))
                    If valor <> "" And valor <> 0 Then

                        pro_Anticipo = IIf(gpbDres.Rows(Fila).Cells(f).Value() Is DBNull.Value, 0, gpbDres.Rows(Fila).Cells(f).Value())
                        f = f + 1
                    End If

                    valor = Val(datosPpalProy(38))
                    If valor <> "" And valor <> 0 Then

                        pro_Penalizacion = IIf(gpbDres.Rows(Fila).Cells(f).Value() Is DBNull.Value, 0, gpbDres.Rows(Fila).Cells(f).Value())
                        f = f + 1
                    End If

                    valor = Val(datosPpalProy(39))
                    If valor <> "" And valor <> 0 Then

                        pro_MontoITBMS = IIf(gpbDres.Rows(Fila).Cells(f).Value() Is DBNull.Value, 0, gpbDres.Rows(Fila).Cells(f).Value())
                        f = f + 1
                    End If

                    valor = Val(datosPpalProy(40))
                    If valor <> "" And valor <> 0 Then

                        pro_RETdeITBMS = IIf(gpbDres.Rows(Fila).Cells(f).Value() Is DBNull.Value, 0, gpbDres.Rows(Fila).Cells(f).Value())
                        f = f + 1
                    End If

                    valor = Val(datosPpalProy(41))
                    If valor <> "" And valor <> 0 Then

                        pro_CuentaCobrar = IIf(gpbDres.Rows(Fila).Cells(f).Value() Is DBNull.Value, 0, gpbDres.Rows(Fila).Cells(f).Value())
                        f = f + 1

                    End If

                    valor = Val(datosPpalProy(42))
                    If valor <> "" And valor <> 0 Then
                        If IsDate(gpbDres.Rows(Fila).Cells(f).Value()) Then
                            pro_FechaCliente = gpbDres.Rows(Fila).Cells(f).Value()
                        Else
                            pro_FechaCliente = "1900-01-01"
                        End If

                        f = f + 1
                    Else
                        pro_FechaCliente = "1900-01-01"
                    End If

                    valor = Val(datosPpalProy(43))
                    If valor <> "" And valor <> 0 Then
                        If IsDate(gpbDres.Rows(Fila).Cells(f).Value()) Then
                            pro_FechaCxc = gpbDres.Rows(Fila).Cells(f).Value()
                        Else
                            pro_FechaCxc = "1900-01-01"
                        End If



                        f = f + 1
                    Else
                        pro_FechaCxc = "1900-01-01"

                    End If

                    valor = Val(datosPpalProy(44))
                    If valor <> "" And valor <> 0 Then

                        pro_NroRecibo = IIf(gpbDres.Rows(Fila).Cells(f).Value() Is DBNull.Value, "", gpbDres.Rows(Fila).Cells(f).Value())
                        RecNro = pro_NroRecibo
                        f = f + 1

                    End If

                    valor = Val(datosPpalProy(45))
                    If valor <> "" And valor <> 0 Then
                        If IsDate(gpbDres.Rows(Fila).Cells(f).Value()) Then
                            pro_FechaRes = gpbDres.Rows(Fila).Cells(f).Value()
                        Else
                            pro_FechaRes = "1900-01-01"
                        End If

                        f = f + 1
                    Else
                        pro_FechaRes = "1900-01-01"
                    End If

                    valor = Val(datosPpalProy(46))
                    If valor <> "" And valor <> 0 Then

                        If IsDate(gpbDres.Rows(Fila).Cells(f).Value()) Then
                            pro_FechaPago = gpbDres.Rows(Fila).Cells(f).Value()
                        Else
                            pro_FechaPago = "1900-01-01"
                        End If

                        f = f + 1
                    Else
                        pro_FechaPago = "1900-01-01"
                    End If

                    valor = Val(datosPpalProy(47))
                    If valor <> "" And valor <> 0 Then

                        If IsDate(gpbDres.Rows(Fila).Cells(f).Value()) Then
                            pro_FechaTes = gpbDres.Rows(Fila).Cells(f).Value()
                        Else
                            pro_FechaTes = "1900-01-01"
                        End If


                        f = f + 1
                    Else
                        pro_FechaTes = "1900-01-01"
                    End If

                    valor = Val(datosPpalProy(64))
                    If valor <> "" And valor <> 0 Then

                        pro_montoCheque = IIf(gpbDres.Rows(Fila).Cells(f).Value() Is DBNull.Value, 0, gpbDres.Rows(Fila).Cells(f).Value())
                        f = f + 1

                    End If

                    guardaActProyeimportDFact()

                    If ContNro <> "" And FactNro <> "" And errorimp = 0 Then
                        impinsertNroFact(stridProy, ProyNro, ContNro, RecNro, FactNro)
                    End If


                    'If ContNro <> "" And FactNro <> "" And RecNro <> "" And errorimp = 0 Then
                    '    impinsertNroRec(stridProy, ProyNro, ContNro, RecNro, FactNro)
                    'End If

                    c = f

                    f = fP

                Next Fila


            End If


        Catch ex As Exception
            MsgBox("Error en funcion importarDatosFactProy()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
            errorimp = 1

        End Try
    End Sub

    Sub guardaImportActProyeDResp()
        Try
            Dim strDResp As New ADODB.Recordset
            strCodProy = ProyNro
            idProyecto(1)
            id = stridProy

            strDResp = cntSQL.Execute("SELECT * from import_tab_Aux_EntesProy where pro_idProyecto='" & stridProy & "'")

            If strDResp.EOF = False Then

                cntSQL.Execute("UPDATE import_tab_Aux_EntesProy  SET [pro_NroContrato]='" & ContNro & "', " _
                                & " [pro_NroRecibo]='" & pro_NroRecibo & "', " _
                                & " [pro_Contratista]= '" & pro_Contratista & "', " _
                                & " [pro_Cliente]='" & pro_Cliente & "', " _
                                & " [pro_Gerente]='" & pro_Gerente & "'," _
                                & " [pro_Ingeniero]='" & pro_Ingeniero & "', " _
                                & " [pro_CordCtasMop]='" & pro_CordCtasMop & "', " _
                                & " [pro_Gobierno]='" & pro_Gobierno & "', " _
                                & " [pro_EncGrupo]='" & pro_EncGrupo & "', " _
                                & " [pro_Mtototal]=" & Replace(pro_Mtototal, ",", "") & ", " _
                                & " [pro_FechaTreal]='" & Format(pro_FechaTreal, "yyyyMMdd") & "', " _
                                & " [pro_Fechaant]='" & Format(pro_Fechaant, "yyyyMMdd") & "', " _
                                & " [pro_Mes]='" & pro_Mes & "', " _
                                & " [pro_FechaPago]='" & Format(pro_FechaPago, "yyyyMMdd") & "', " _
                                & " [pro_FechaPagoTra]='" & Format(pro_FechaPagoTra, "yyyyMMdd") & "', " _
                                & " [nroDoc]='" & nroDoc & "', " _
                                & " [pro_nroProyecto]='" & ProyNro & "', " _
                                & "  pro_analistaCosto='" & pro_analistaCosto & "' " _
                                & "  where pro_idProyecto='" & stridProy & "'")

            Else

                cntSQL.Execute("insert into import_tab_Aux_EntesProy ([pro_idProyecto],[pro_NroContrato],[pro_NroRecibo],[pro_Contratista],[pro_Cliente]" _
                                    & ",[pro_Gerente],[pro_Ingeniero],[pro_CordCtasMop],[pro_Gobierno],[pro_EncGrupo]" _
                                    & ",[pro_Mtototal],[pro_FechaTreal],[pro_Fechaant],[pro_Mes],[pro_FechaPago],[pro_FechaPagoTra],nroDoc, pro_analistaCosto, pro_nroProyecto) VALUES " _
                                    & "( " & stridProy & ", " _
                                    & " '" & ContNro & "', " _
                                    & " '" & pro_NroRecibo & "', " _
                                    & " '" & pro_Contratista & "', " _
                                    & " '" & pro_Cliente & "', " _
                                    & " '" & pro_Gerente & "', " _
                                    & " '" & pro_Ingeniero & "', " _
                                    & " '" & pro_CordCtasMop & "', " _
                                    & " '" & pro_Gobierno & "', " _
                                    & " '" & pro_EncGrupo & "', " _
                                    & " '" & Replace(pro_Mtototal, ",", "") & "', " _
                                    & " '" & Format(pro_FechaTreal, "yyyyMMdd") & "', " _
                                    & "'" & Format(pro_Fechaant, "yyyyMMdd") & "'," _
                                    & " '" & pro_Mes & "', " _
                                    & " '" & Format(pro_FechaPago, "yyyyMMdd") & "', " _
                                    & "'" & Format(pro_FechaPagoTra, "yyyyMMdd") & "', " _
                                    & "'" & nroDoc & "', " _
                                    & "'" & pro_analistaCosto & "', " _
                                    & "'" & ProyNro & "')")
            End If


        Catch ex As Exception
            MsgBox("Error en funcion guardaImportActProyeDResp" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
            swguar = 1
        End Try

    End Sub
    Sub guardaImportActDPpalProy()

        Dim strPpal As New ADODB.Recordset
        Try

            If ContNro = "" Then
                strCodProy = ProyNro
                idProyecto(1)
                id = stridProy

                'VALIDA QUE NO EXISTA NRO DE PROYECTO
                strPpal = cntSQL.Execute("select pro_idProyecto from import_tab_DatosPpalProy where pro_idProyecto='" & stridProy & "'")

                If strPpal.EOF = False Then
                    cntSQL.Execute("UPDATE import_tab_DatosPpalProy SET pro_nroProyecto='" & ProyNro & "', " _
                                    & " pro_nroContrato='" & pro_nroContrato & "', " _
                                    & " pro_descripcion='" & pro_descripcion & "', " _
                                    & " pro_Sector= '" & Sector(pro_Sector) & "', " _
                                    & " pro_Provincia='" & pro_provincia & "', " _
                                    & " pro_monto=" & Replace(pro_monto, ",", "") & ", " _
                                    & " nroDoc='" & nroDoc & "' " _
                                    & " where pro_idProyecto=" & stridProy & "")

                Else
                    'strCodProy = ProyNro
                    'idProyecto(1)
                    'id = stridProy

                    cntSQL.Execute("insert into import_tab_DatosPpalProy (pro_idProyecto,pro_nroProyecto,pro_descripcion,pro_Sector,pro_nroContrato,pro_Provincia,pro_monto," _
                                 & " nroDoc ) values (  '" & id & "', " _
                                       & " '" & ProyNro & "', " _
                                       & " '" & pro_descripcion & "', " _
                                       & " '" & Sector(pro_Sector) & "', " _
                                       & " '" & pro_nroContrato & "', " _
                                       & " '" & pro_provincia & "', " _
                                       & "  " & Replace(pro_monto, ",", "") & ", " _
                                       & " '" & nroDoc & "')")

                    stridProy = id

                End If
            End If


            If ContNro <> "" Then

                strCodProy = ProyNro
                idProyecto(1)
                id = stridProy

                'VALIDA QUE NO EXISTA NRO DE PROYECTO
                strPpal = cntSQL.Execute("select pro_idProyecto from import_tab_DatosPpalProy where pro_idProyecto='" & stridProy & "' and pro_nroContrato='" & ContNro & "'")


                If strPpal.EOF = False Then
                    cntSQL.Execute("UPDATE import_tab_DatosPpalProy SET pro_nroProyecto='" & ProyNro & "', " _
                                    & " pro_nroContrato='" & pro_nroContrato & "', " _
                                    & " pro_descripcion='" & pro_descripcion & "', " _
                                    & " pro_Sector= '" & Sector(pro_Sector) & "', " _
                                    & " pro_Provincia='" & pro_provincia & "', " _
                                    & " pro_monto=" & Replace(pro_monto, ",", "") & ", " _
                                    & " nroDoc='" & nroDoc & "' " _
                                    & " where pro_idProyecto=" & stridProy & " and pro_nroContrato='" & ContNro & "'")

                Else
                    'strCodProy = ProyNro
                    'idProyecto(1)
                    'id = stridProy

                    cntSQL.Execute("insert into import_tab_DatosPpalProy (pro_idProyecto,pro_nroProyecto,pro_descripcion,pro_Sector,pro_nroContrato,pro_Provincia,pro_monto,nroDoc) values (  '" & id & "', " _
                                       & " '" & ProyNro & "', " _
                                       & " '" & pro_descripcion & "', " _
                                       & " '" & Sector(pro_Sector) & "', " _
                                       & " '" & pro_nroContrato & "', " _
                                       & " '" & pro_provincia & "', " _
                                       & "  " & Replace(pro_monto, ",", "") & ", " _
                                       & " '" & nroDoc & "')")

                    stridProy = id

                End If
            End If


        Catch ex As Exception
            MsgBox("Error en funcion guardaImportActDPpalProy" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
            swguar = 1
            errorimp = 1
        End Try

    End Sub
    Sub guardaImportActDPpalProyComp()

        Dim strPpal As New ADODB.Recordset
        Try

            If ContNro = "" Then
                strCodProy = ProyNro
                idProyecto(1)
                id = stridProy

                'VALIDA QUE NO EXISTA NRO DE PROYECTO
                strPpal = cntSQL.Execute("select pro_idProyecto from import_tab_DatosPpalProy_Compl where pro_idProyecto='" & stridProy & "' and pro_nroCuenta='" & CtaNro & "'")

                If strPpal.EOF = False Then
                    cntSQL.Execute("UPDATE import_tab_DatosPpalProy_Compl SET pro_nroProyecto='" & ProyNro & "', " _
                                    & " pro_nroContrato='" & pro_nroContrato & "', " _
                                    & " pro_serieCuenta ='" & pro_serieCuenta & "', " _
                                    & " pro_nroCuenta=" & pro_nroCuenta & ", " _
                                    & " pro_FechaD='" & Format(pro_FechaD, "yyyyMMdd") & "', " _
                                    & " pro_FechaH='" & Format(pro_FechaH, "yyyyMMdd") & "', " _
                                    & " pro_TrabajoR=" & Replace(pro_TrabajoR, ",", "") & ", " _
                                    & " pro_FechaR='" & Format(pro_FechaR, "yyyyMMdd") & "', " _
                                    & " pro_PresInsp= " & Replace(pro_PresInsp, ",", "") & ", " _
                                    & " pro_FechaP='" & Format(pro_FechaP, "yyyyMMdd") & "', " _
                                    & " pro_periodoCuenta=" & periodo(Replace(pro_periodoCuenta, ",", "")) & ", " _
                                    & " pro_duracionProy=" & pro_duracionproy & ", " _
                                    & " pro_FechaInicio ='" & Format(pro_FechaInicio, "yyyyMMdd") & "', " _
                                    & " pro_FechaFinOrig ='" & Format(pro_FechaFinOrig, "yyyyMMdd") & "', " _
                                    & " pro_status='" & Sector(pro_Sector) & "', " _
                                    & " pro_tipo='" & Tipo(pro_tipo) & "' " _
                                    & " nroDoc='" & nroDoc & "', " _
                                    & " pro_NroFactura='" & pro_NroFacturas & "', " _
                                    & " pro_FechaEstimacion='" & pro_FechaEstimacion & "' " _
                                    & " where pro_idProyecto=" & stridProy & "")

                Else
                    'strCodProy = ProyNro
                    'idProyecto(1)
                    'id = stridProy

                    cntSQL.Execute("insert into import_tab_DatosPpalProy_Compl (pro_idProyecto,pro_nroProyecto,pro_nroContrato," _
                                 & " pro_nroCuenta,pro_serieCuenta, pro_FechaD,pro_FechaH,pro_TrabajoR,pro_FechaR,pro_PresInsp,pro_FechaP,pro_periodoCuenta," _
                                    & " pro_duracionProy, pro_FechaInicio, pro_FechaFinOrig, pro_status, pro_tipo,nroDoc,pro_NroFactura,pro_FechaEstimacion ) values (  '" & id & "', " _
                                       & " '" & ProyNro & "', " _
                                       & " '" & pro_nroContrato & "', " _
                                       & " " & pro_nroCuenta & ", " _
                                       & " '" & pro_serieCuenta & "', " _
                                       & " '" & Format(pro_FechaD, "yyyyMMdd") & "', " _
                                       & " '" & Format(pro_FechaH, "yyyyMMdd") & "', " _
                                       & "  " & Replace(pro_TrabajoR, ",", "") & ", " _
                                       & " '" & Format(pro_FechaR, "yyyyMMdd") & "', " _
                                       & "  " & Replace(pro_PresInsp, ",", "") & ", " _
                                       & " '" & Format(pro_FechaP, "yyyyMMdd") & "', " _
                                       & " '" & periodo((Replace(pro_periodoCuenta, ",", ""))) & "', " _
                                       & " '" & pro_duracionproy & "', " _
                                       & " '" & Format(pro_FechaInicio, "yyyyMMdd") & "', " _
                                       & " '" & Format(pro_FechaFinOrig, "yyyyMMdd") & "', " _
                                       & " '" & Sector(pro_Sector) & "', " _
                                       & " '" & Tipo(pro_tipo) & "'," _
                                       & " '" & nroDoc & "'," _
                                       & " '" & pro_NroFacturas & "', " _
                                       & "'" & pro_FechaEstimacion & "')")

                    stridProy = id

                End If
            End If


            If ContNro <> "" Then

                strCodProy = ProyNro
                idProyecto(1)
                id = stridProy

                'VALIDA QUE NO EXISTA NRO DE PROYECTO
                strPpal = cntSQL.Execute("select pro_idProyecto from import_tab_DatosPpalProy_Compl where pro_idProyecto='" & stridProy & "' and pro_nroContrato='" & ContNro & "' and pro_nroCuenta='" & CtaNro & "'")


                If strPpal.EOF = False Then
                    cntSQL.Execute("UPDATE import_tab_DatosPpalProy_Compl SET pro_nroProyecto='" & ProyNro & "', " _
                                    & " pro_nroContrato='" & pro_nroContrato & "', " _
                                    & " pro_nroCuenta=" & pro_nroCuenta & ", " _
                                    & " pro_serieCuenta ='" & pro_serieCuenta & "', " _
                                    & " pro_FechaD='" & Format(pro_FechaD, "yyyyMMdd") & "', " _
                                    & " pro_FechaH='" & Format(pro_FechaH, "yyyyMMdd") & "', " _
                                    & " pro_TrabajoR=" & Replace(pro_TrabajoR, ",", "") & ", " _
                                    & " pro_FechaR='" & Format(pro_FechaR, "yyyyMMdd") & "', " _
                                    & " pro_PresInsp= " & Replace(pro_PresInsp, ",", "") & ", " _
                                    & " pro_FechaP='" & Format(pro_FechaP, "yyyyMMdd") & "', " _
                                    & " pro_periodoCuenta=" & periodo((Replace(pro_periodoCuenta, ",", ""))) & ", " _
                                    & " pro_duracionProy=" & pro_duracionproy & ", " _
                                    & " pro_FechaInicio ='" & Format(pro_FechaInicio, "yyyyMMdd") & "', " _
                                    & " pro_FechaFinOrig ='" & Format(pro_FechaFinOrig, "yyyyMMdd") & "', " _
                                    & " pro_status='" & Sector(pro_Sector) & "', " _
                                    & " pro_tipo='" & Tipo(pro_tipo) & "', " _
                                    & " nroDoc='" & nroDoc & "', " _
                                    & " pro_NroFactura='" & pro_NroFacturas & "', " _
                                    & " pro_FechaEstimacion='" & pro_FechaEstimacion & "' " _
                                    & " where pro_idProyecto=" & stridProy & " and pro_nroContrato='" & ContNro & "'")

                Else
                    'strCodProy = ProyNro
                    'idProyecto(1)
                    'id = stridProy

                    cntSQL.Execute("insert into import_tab_DatosPpalProy_Compl (pro_idProyecto,pro_nroProyecto,pro_nroContrato," _
                                 & " pro_nroCuenta,pro_serieCuenta, pro_FechaD,pro_FechaH,pro_TrabajoR,pro_FechaR,pro_PresInsp,pro_FechaP,pro_periodoCuenta," _
                                    & " pro_duracionProy, pro_FechaInicio, pro_FechaFinOrig, pro_status, pro_tipo,nroDoc,pro_NroFactura,pro_FechaEstimacion ) values (  '" & id & "', " _
                                       & " '" & ProyNro & "', " _
                                       & " '" & pro_nroContrato & "', " _
                                       & " " & pro_nroCuenta & ", " _
                                       & " '" & pro_serieCuenta & "', " _
                                       & " '" & Format(pro_FechaD, "yyyyMMdd") & "', " _
                                       & " '" & Format(pro_FechaH, "yyyyMMdd") & "', " _
                                       & "  " & Replace(pro_TrabajoR, ",", "") & ", " _
                                       & " '" & Format(pro_FechaR, "yyyyMMdd") & "', " _
                                       & "  " & Replace(pro_PresInsp, ",", ".") & ", " _
                                       & " '" & Format(pro_FechaP, "yyyyMMdd") & "', " _
                                       & " '" & periodo((Replace(pro_periodoCuenta, ",", ""))) & "', " _
                                       & " '" & pro_duracionproy & "', " _
                                       & " '" & Format(pro_FechaInicio, "yyyyMMdd") & "', " _
                                       & " '" & Format(pro_FechaFinOrig, "yyyyMMdd") & "', " _
                                       & " '" & Sector(pro_Sector) & "', " _
                                       & " '" & Tipo(pro_tipo) & "'," _
                                       & " '" & nroDoc & "'," _
                                       & " '" & pro_NroFacturas & "', " _
                                       & "'" & pro_FechaEstimacion & "')")

                    stridProy = id

                End If
            End If


        Catch ex As Exception
            MsgBox("Error en funcion guardaImportActDPpalProyComp" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
            swguar = 1
            errorimp = 1
        End Try

    End Sub

    Public Function Sector(ByVal Name As String)
        Dim index As Integer
        Dim strSQL As New ADODB.Recordset
        Try
            strSQL = cntSQL.Execute("SELECT id, [des_Sector]  FROM tab_Sector where des_Sector='" & Name & "'")

            If strSQL.EOF = True Then
                index = -1
            End If

            Do While Not strSQL.EOF
                index = strSQL.Fields(0).Value

                strSQL.MoveNext()
            Loop
        Catch ex As Exception
            MsgBox("Error en funcion Sector" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try

        Return index

    End Function

    Public Function Rango(ByVal Name As String)
        Dim index As Integer
        Dim strSQL As New ADODB.Recordset
        Try
            strSQL = cntSQL.Execute("SELECT [index], des_Rango  FROM tab_Rango where des_Rango='" & Name & "'")

            If strSQL.EOF = True Then
                index = -1
            End If

            Do While Not strSQL.EOF
                index = strSQL.Fields(0).Value

                strSQL.MoveNext()
            Loop
        Catch ex As Exception
            MsgBox("Error en funcion Rango" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try

        Return index

    End Function

    Public Function Cheque(ByVal Name As String)
        Dim index As Integer
        Dim strSQL As New ADODB.Recordset
        Try
            strSQL = cntSQL.Execute("SELECT id, des_CtrlCheque  FROM [tab_CtrlCheque] where des_CtrlCheque='" & Name & "'")

            If strSQL.EOF = True Then
                index = -1
            End If

            Do While Not strSQL.EOF
                index = strSQL.Fields(0).Value

                strSQL.MoveNext()
            Loop
        Catch ex As Exception
            MsgBox("Error en funcion Chequ" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try

        Return index

    End Function

    Public Function Recibo(ByVal Name As String)
        Dim index As Integer
        Dim strSQL As New ADODB.Recordset
        Try
            strSQL = cntSQL.Execute("SELECT id, des_CtrlRecibo  FROM tab_CtrlRecibo where des_CtrlRecibo='" & Name & "'")

            If strSQL.EOF = True Then
                index = -1
            End If

            Do While Not strSQL.EOF
                index = strSQL.Fields(0).Value

                strSQL.MoveNext()
            Loop
        Catch ex As Exception
            MsgBox("Error en funcion Recibo" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try

        Return index

    End Function
    Public Function Status(ByVal Name As String)
        Dim index As Integer
        Dim strSQL As New ADODB.Recordset
        Try
            strSQL = cntSQL.Execute("SELECT id FROM tab_Status where des_Status='" & Name & "'")

            If strSQL.EOF = True Then
                index = -1
            End If

            Do While Not strSQL.EOF
                index = strSQL.Fields(0).Value

                strSQL.MoveNext()
            Loop
        Catch ex As Exception
            MsgBox("Error en funcion Sector" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try

        Return index

    End Function
    Public Function periodo(ByVal Name As String)
        Dim index As Integer
        Dim strSQL As New ADODB.Recordset
        Try
            strSQL = cntSQL.Execute("SELECT id FROM tab_perpagoCuentas where des_perpagoCuentas='" & Name & "'")

            If strSQL.EOF = True Then
                index = -1
            End If

            Do While Not strSQL.EOF
                index = strSQL.Fields(0).Value

                strSQL.MoveNext()
            Loop
        Catch ex As Exception
            MsgBox("Error en funcion Sector" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try

        Return index

    End Function
    Public Function Statusc(ByVal Name As String)
        Dim index As Integer
        Dim strSQL As New ADODB.Recordset
        Try
            strSQL = cntSQL.Execute("SELECT id FROM tab_Status_C where des_Status='" & Name & "'")

            If strSQL.EOF = True Then
                index = -1
            End If

            Do While Not strSQL.EOF
                index = strSQL.Fields(0).Value

                strSQL.MoveNext()
            Loop
        Catch ex As Exception
            MsgBox("Error en funcion Sector" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try

        Return index

    End Function
    Public Function Tipo(ByVal Name As String)
        Dim index As Integer
        Dim strSQL As New ADODB.Recordset
        Try
            strSQL = cntSQL.Execute("SELECT id FROM tab_Tipo where des_tipo='" & Name & "'")

            If strSQL.EOF = True Then
                index = -1
            End If

            Do While Not strSQL.EOF
                index = strSQL.Fields(0).Value

                strSQL.MoveNext()
            Loop
        Catch ex As Exception
            MsgBox("Error en funcion Sector" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try

        Return index

    End Function

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If chk1.Checked = True And chk2.Checked = True And chk3.Checked = True And chk4.Checked = True Then
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
                            ImportExcellToDataGridView(.FileName, gpbDres)
                        End If
                    End If
                End With

            End If

        Else
            MsgBox("Datos en Rojo Deben estar Seleccionados")
        End If
        swExcel = 0
    End Sub

    Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        revisarDatosPrev()
    End Sub

    Private Sub ToolStripButton6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        limpiarDatosImport()
    End Sub

    Private Sub ToolStripButton5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub ToolStripButton2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim preg As String

            preg = MsgBox("Seguro que desea importar los datos", MsgBoxStyle.YesNoCancel)

            If preg = 6 Then
                nroDoc = DateTime.Now
                nroDoc = Replace(nroDoc, "/", "")
                nroDoc = Replace(nroDoc, "-", "")
                nroDoc = Replace(nroDoc, ":", "")
                nroDoc = Replace(nroDoc, " ", "")
                importarDatosPpalProy()
                ConexionSQL()
                cntSQL.Execute("exec p_InsertaDatosproyectoppal '" & nroDoc & "'")



            End If

        Catch ex As Exception
            MsgBox("Error al Importar Datos", MsgBoxStyle.Critical, "Control Proyectos")
        End Try

    End Sub

   

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If chk1.Checked = True And chk2.Checked = True And chk3.Checked = True And chk4.Checked = True Then


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

    Private Sub ToolStripButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

    Private Sub ToolStripButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
                    importarDatosPpalProy()
                    ConexionSQL()
                    cntSQL.Execute("exec p_InsertaDatosproyectoppal '" & nroDoc & "'")

                    If errorimp = 0 Then
                        MsgBox("Datos Importados Existosamente", MsgBoxStyle.Information, "Control Proyectos")
                    End If
                    Exit For
                    Application.DoEvents()
                Next
                frm.Close()

            End If

        Catch ex As Exception
            MsgBox("Error al Importar Datos", MsgBoxStyle.Critical, "Control Proyectos")
        End Try
        errorimp = 0
    End Sub

    Private Sub ToolStripButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        limpiarDatosImport()
    End Sub

    Private Sub ToolStripButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub


    Private Sub ToolStripButton7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripButton1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        If chk1.Checked = True And chk2.Checked = True And chk3.Checked = True And chk4.Checked = True Then

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

    Private Sub ToolStripButton8_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripButton2_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
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

    Private Sub ToolStripButton9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Dim frm As New frmProcess
        frm.Show()

        Try
            Dim preg As String

            preg = MsgBox("Seguro que desea importar los datos", MsgBoxStyle.YesNoCancel)

            If preg = 6 Then

                For x As Int32 = 0 To 1



                    nroDoc = DateTime.Now
                    nroDoc = Replace(nroDoc, "/", "")
                    nroDoc = Replace(nroDoc, "-", "")
                    nroDoc = Replace(nroDoc, ":", "")
                    nroDoc = Replace(nroDoc, " ", "")

                    'DATOS PPALES DEL PROYECTO
                    importarDatosPpalProy()

                    'DATOS RESPONSABLES DEL PROYECTO
                    importarDatosEntesProy()

                    If errorimp = 0 Then
                        ConexionSQL()
                        cntSQL.Execute("exec p_InsertaDatosproyectoppal '" & nroDoc & "'")

                        ConexionSQL()
                        cntSQL.Execute("exec p_InsertaDatosproyectoEntes '" & nroDoc & "'")
                    End If


                



                    If errorimp = 0 Then
                        ToolStripButton3.Enabled = False
                        MsgBox("Datos Importados Existosamente", MsgBoxStyle.Information, "Control Proyectos")
                        limpiarDatosImport()
                        Me.Close()
                    End If

                    Exit For
                    Application.DoEvents()
                Next
                frm.Close()

            End If

        Catch ex As Exception
            MsgBox("Error al Importar Datos Entes proy" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
            frm.Close()
        End Try
        errorimp = 0
        swFact = 0
        swFact1 = 0
    End Sub

    Sub guardaActProyeimportDCostos()
        Try
            Dim strDCostos As New ADODB.Recordset
            strCodProy = ProyNro
            idProyecto(1)
            id = stridProy


            If FactNro = "" And RecNro = "" Then

                strDCostos = cntSQL.Execute("select * from import_tab_Aux_CostosFactProy where pro_idProyecto=" & stridProy & " and pro_NroContrato='" & ContNro & "' ")

                If strDCostos.EOF = False Then
                    cntSQL.Execute("UPDATE import_tab_Aux_CostosFactProy SET [pro_NroContrato]= '" & ContNro & "', " _
                                   & " [pro_NroRecibo]= '" & pro_NroRecibo & "', " _
                                   & " [pro_nroproyecto]= '" & ProyNro & "', " _
                                   & " [pro_NroFactura]= '" & pro_NroFactura & "', " _
                                   & " [pro_FechaCheque]='" & Format(pro_FechaCheque, "yyyyMMdd") & "', " _
                                   & " [pro_NroCheque]='" & pro_NroCheque & "', " _
                                   & " [pro_ControlRec]='" & Recibo(pro_ControlRec) & "', " _
                                   & " [pro_ControlCheq]='" & Cheque(pro_ControlRec) & "', " _
                                   & " [pro_MtoCobrar]=" & Replace(pro_MtoCobrar, ",", "") & ", " _
                                   & " [pro_Rango1]='" & Rango(pro_Rango1) & "', " _
                                   & " [pro_Rango2]='" & Rango(pro_Rango2) & "', " _
                                   & " [pro_Rango]='" & Rango(pro_Rango) & "', " _
                                   & " [pro_Monto2]=" & Replace(pro_Monto2, ",", "") & ", " _
                                   & " [pro_Status]='" & Statusc(pro_status) & "', " _
                                   & " [pro_DocNext]='" & pro_DocNext & "', " _
                                   & " [pro_MesEj]='" & pro_MesEj & "', " _
                                   & " [pro_Scafid]='" & pro_Scafid & "', " _
                                   & " [pro_FechaRefrendo]='" & Format(pro_FechaRefrendo, "yyyyMMdd") & "' " _
                                   & "  where pro_idProyecto='" & stridProy & "' and  pro_NroContrato='" & ContNro & "' and [pro_NroFactura]='' and pro_NroContrato=''")


                Else


                    cntSQL.Execute("insert into import_tab_Aux_CostosFactProy ( [pro_idProyecto] , pro_nroproyecto,[pro_NroContrato],[pro_NroRecibo], [pro_NroFactura],[pro_FechaCheque] ,[pro_NroCheque],[pro_ControlRec] ,[pro_ControlCheq]" _
                                              & ",[pro_MtoCobrar],[pro_Rango1] ,[pro_Rango2] ,[pro_Rango],[pro_Monto2] ,[pro_Status],[pro_MesEj],[pro_DocNext]" _
                                              & " ,[pro_Scafid]  ,[pro_FechaRefrendo]) VALUES " _
                                              & "( " & stridProy & ", " _
                                               & " '" & ProyNro & "', " _
                                              & " '" & ContNro & "', " _
                                              & " '" & pro_NroRecibo & "', " _
                                              & " '" & pro_NroFactura & "', " _
                                              & " '" & Format(pro_FechaCheque, "yyyyMMdd") & "', " _
                                              & " '" & pro_NroCheque & "', " _
                                              & " '" & Recibo(pro_ControlRec) & "', " _
                                              & " '" & Cheque(pro_ControlRec) & "', " _
                                              & " " & Replace(pro_MtoCobrar, ",", "") & ", " _
                                              & " '" & Rango(pro_Rango1) & "', " _
                                              & " '" & Rango(pro_Rango2) & "', " _
                                              & " '" & Rango(pro_Rango) & "', " _
                                              & " " & Replace(pro_Monto2, ",", "") & "," _
                                              & " '" & Statusc(pro_status) & "', " _
                                              & " '" & pro_MesEj & "', " _
                                              & " '" & pro_DocNext & "', " _
                                              & " '" & pro_Scafid & "', " _
                                              & " '" & Format(pro_FechaRefrendo, "yyyyMMdd") & "," _
                                              & " '" & nroDoc & "')")
                End If

            End If


            If FactNro <> "" And RecNro = "" Then
                strDCostos = cntSQL.Execute("select * from import_tab_Aux_CostosFactProy where pro_idProyecto=" & stridProy & " and pro_NroContrato='" & ContNro & "' and pro_NroFactura='" & FactNro & "'")

                If strDCostos.EOF = False Then
                    cntSQL.Execute("UPDATE import_tab_Aux_CostosFactProy SET [pro_NroContrato]= '" & ContNro & "', " _
                                   & " [pro_NroRecibo]= '" & pro_NroRecibo & "', " _
                                    & " [pro_nroproyecto]= '" & ProyNro & "', " _
                                   & " [pro_NroFactura]= '" & pro_NroFactura & "', " _
                                   & " [pro_FechaCheque]='" & Format(pro_FechaCheque, "yyyyMMdd") & "', " _
                                   & " [pro_NroCheque]='" & pro_NroCheque & "', " _
                                   & " [pro_ControlRec]='" & Recibo(pro_ControlRec) & "', " _
                                   & " [pro_ControlCheq]='" & Cheque(pro_ControlRec) & "', " _
                                   & " [pro_MtoCobrar]=" & Replace(pro_MtoCobrar, ",", "") & ", " _
                                   & " [pro_Rango1]='" & Rango(pro_Rango1) & "', " _
                                   & " [pro_Rango2]='" & Rango(pro_Rango2) & "', " _
                                   & " [pro_Rango]='" & Rango(pro_Rango) & "', " _
                                   & " [pro_Monto2]=" & Replace(pro_Monto2, ",", "") & ", " _
                                   & " [pro_Status]='" & Statusc(pro_status) & "', " _
                                   & " [pro_DocNext]='" & pro_DocNext & "', " _
                                   & " [pro_MesEj]='" & pro_MesEj & "', " _
                                   & " [pro_Scafid]='" & pro_Scafid & "', " _
                                   & " [pro_FechaRefrendo]='" & Format(pro_FechaRefrendo, "yyyyMMdd") & "' " _
                                   & "  where pro_idProyecto='" & stridProy & "' and  pro_NroContrato='" & ContNro & "' and [pro_NroFactura]='' and pro_NroContrato=''")


                Else


                    cntSQL.Execute("insert into import_tab_Aux_CostosFactProy ( [pro_idProyecto] ,[pro_nroproyecto],[pro_NroContrato],[pro_NroRecibo], [pro_NroFactura],[pro_FechaCheque] ,[pro_NroCheque],[pro_ControlRec] ,[pro_ControlCheq]" _
                                              & ",[pro_MtoCobrar],[pro_Rango1] ,[pro_Rango2] ,[pro_Rango],[pro_Monto2] ,[pro_Status],[pro_MesEj],[pro_DocNext]" _
                                              & " ,[pro_Scafid]  ,[pro_FechaRefrendo]) VALUES " _
                                              & "( " & stridProy & ", " _
                                               & "  '" & ProyNro & "', " _
                                              & " '" & ContNro & "', " _
                                              & " '" & pro_NroRecibo & "', " _
                                              & " '" & pro_NroFactura & "', " _
                                              & " '" & Format(pro_FechaCheque, "yyyyMMdd") & "', " _
                                              & " '" & pro_NroCheque & "', " _
                                              & " '" & Recibo(pro_ControlRec) & "', " _
                                              & " '" & Cheque(pro_ControlRec) & "', " _
                                              & " " & Replace(pro_MtoCobrar, ",", "") & ", " _
                                              & " '" & Rango(pro_Rango1) & "', " _
                                              & " '" & Rango(pro_Rango2) & "', " _
                                              & " '" & Rango(pro_Rango) & "', " _
                                              & " " & Replace(pro_Monto2, ",", "") & "," _
                                              & " '" & Statusc(pro_status) & "', " _
                                              & " '" & pro_MesEj & "', " _
                                              & " '" & pro_DocNext & "', " _
                                              & " '" & pro_Scafid & "', " _
                                              & " '" & Format(pro_FechaRefrendo, "yyyyMMdd") & "," _
                                              & " '" & nroDoc & "')")
                End If

            End If


            If FactNro <> "" And RecNro <> "" Then

                strDCostos = cntSQL.Execute("select * from import_tab_Aux_CostosFactProy where pro_idProyecto=" & stridProy & " and pro_NroContrato='" & ContNro & "' and pro_NroFactura='" & FactNro & "' and pro_NroRecibo='" & RecNro & "'")

                If strDCostos.EOF = False Then
                    cntSQL.Execute("UPDATE import_tab_Aux_CostosFactProy SET [pro_NroContrato]= '" & ContNro & "', " _
                                   & " [pro_NroRecibo]= '" & pro_NroRecibo & "', " _
                                    & " [pro_nroproyecto]='" & ProyNro & "', " _
                                   & " [pro_NroFactura]= '" & pro_NroFactura & "', " _
                                   & " [pro_FechaCheque]='" & Format(pro_FechaCheque, "yyyyMMdd") & "', " _
                                   & " [pro_NroCheque]='" & pro_NroCheque & "', " _
                                   & " [pro_ControlRec]='" & Recibo(pro_ControlRec) & "', " _
                                   & " [pro_ControlCheq]='" & Cheque(pro_ControlRec) & "', " _
                                   & " [pro_MtoCobrar]=" & Replace(pro_MtoCobrar, ",", "") & ", " _
                                   & " [pro_Rango1]='" & Rango(pro_Rango1) & "', " _
                                   & " [pro_Rango2]='" & Rango(pro_Rango2) & "', " _
                                   & " [pro_Rango]='" & Rango(pro_Rango) & "', " _
                                   & " [pro_Monto2]=" & Replace(pro_Monto2, ",", "") & ", " _
                                   & " [pro_Status]='" & Statusc(pro_status) & "', " _
                                   & " [pro_DocNext]='" & pro_DocNext & "', " _
                                   & " [pro_MesEj]='" & pro_MesEj & "', " _
                                   & " [pro_Scafid]='" & pro_Scafid & "', " _
                                   & " [pro_FechaRefrendo]='" & Format(pro_FechaRefrendo, "yyyyMMdd") & "' " _
                                   & "  where pro_idProyecto='" & stridProy & "' and  pro_NroContrato='" & ContNro & "' and [pro_NroFactura]='' and pro_NroContrato=''")


                Else


                    cntSQL.Execute("insert into import_tab_Aux_CostosFactProy ( [pro_idProyecto] ,pro_nroproyecto, [pro_NroContrato],[pro_NroRecibo], [pro_NroFactura],[pro_FechaCheque] ,[pro_NroCheque],[pro_ControlRec] ,[pro_ControlCheq]" _
                                              & ",[pro_MtoCobrar],[pro_Rango1] ,[pro_Rango2] ,[pro_Rango],[pro_Monto2] ,[pro_Status],[pro_MesEj],[pro_DocNext]" _
                                              & " ,[pro_Scafid]  ,[pro_FechaRefrendo]) VALUES " _
                                              & "( " & stridProy & ", " _
                                              & " '" & ProyNro & "', " _
                                              & " '" & ContNro & "', " _
                                              & " '" & pro_NroRecibo & "', " _
                                              & " '" & pro_NroFactura & "', " _
                                              & " '" & Format(pro_FechaCheque, "yyyyMMdd") & "', " _
                                              & " '" & pro_NroCheque & "', " _
                                              & " '" & Recibo(pro_ControlRec) & "', " _
                                              & " '" & Cheque(pro_ControlRec) & "', " _
                                              & " " & Replace(pro_MtoCobrar, ",", "") & ", " _
                                              & " '" & Rango(pro_Rango1) & "', " _
                                              & " '" & Rango(pro_Rango2) & "', " _
                                              & " '" & Rango(pro_Rango) & "', " _
                                              & " " & Replace(pro_Monto2, ",", "") & "," _
                                              & " '" & Statusc(pro_status) & "', " _
                                              & " '" & pro_MesEj & "', " _
                                              & " '" & pro_DocNext & "', " _
                                              & " '" & pro_Scafid & "', " _
                                              & " '" & Format(pro_FechaRefrendo, "yyyyMMdd") & "," _
                                              & " '" & nroDoc & "')")
                End If


            End If





        Catch ex As Exception
            MsgBox("Error en funcion guardaActProyeimportDCostos" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
            errorimp = 1
        End Try

    End Sub
    Sub guardaActProyeimportDFact()
        Try
            Dim strDFact As New ADODB.Recordset

            strCodProy = ProyNro
            idProyecto(1)
            id = stridProy

            If FactNro = "" And RecNro = "" Then

                strDFact = cntSQL.Execute("select pro_idProyecto from import_tab_Aux_FactProy where pro_idProyecto='" & stridProy & "' and pro_NroContrato='" & ContNro & "' and pro_NroFactura='' and pro_NroRecibo='' ")

                If strDFact.EOF = False Then
                    cntSQL.Execute("UPDATE import_tab_Aux_FactProy SET [pro_NroContrato]='" & ContNro & "', " _
                                    & " [pro_NroRecibo]='" & pro_NroRecibo & "', " _
                                   & " pro_nroproyecto='" & ProyNro & "', " _
                                    & " [pro_FechaRes]= '" & Format(pro_FechaRes, "yyyyMMdd") & "', " _
                                    & " [pro_NroFactura]='" & pro_NroFactura & "', " _
                                    & " [pro_FechaFact]='" & Format(pro_FechaFact, "yyyyMMdd") & "', " _
                                    & " [pro_trabajoFac]=" & Replace(pro_trabajoFac, ",", "") & ", " _
                                    & "  pro_Rete10=" & IIf(pro_MtoRete10 > 0, 0, 1) & ", " _
                                    & " [pro_MtoRete10]= " & Replace(pro_MtoRete10, ",", "") & ", " _
                                    & " [pro_Anticipo]=" & Replace(pro_Anticipo, ",", "") & ", " _
                                    & " [pro_Penalizacion]=" & Replace(pro_Penalizacion, ",", "") & ", " _
                                    & " [pro_RETdeITBMS]=" & Replace(pro_RETdeITBMS, ",", "") & ", " _
                                    & " [pro_MontoITBMS]=" & Replace(pro_MontoITBMS, ",", "") & ", " _
                                    & " [pro_CuentaCobrar]=" & Replace(pro_CuentaCobrar, ",", "") & ", " _
                                    & " [pro_FechaCliente]='" & Format(pro_FechaCliente, "yyyyMMdd") & "', " _
                                    & " [pro_FechaCxc]='" & Format(pro_FechaCxc, "yyyyMMdd") & "', " _
                                    & " [pro_FechaTes]='" & Format(pro_FechaTes, "yyyyMMdd") & "', " _
                                    & " [pro_FechaPago]='" & Format(pro_FechaPago, "yyyyMMdd") & "', " _
                                    & " [nroDoc]='" & nroDoc & "', " _
                                    & " pro_montoCheque=" & Replace(pro_montoCheque, ",", "") & ", " _
                                    & " pro_manual=" & 0 & " " _
                                    & "  where pro_idProyecto='" & stridProy & "' and pro_NroContrato='" & ContNro & "' and pro_NroFactura='' and pro_NroRecibo=''")

                Else
                    cntSQL.Execute("insert into import_tab_Aux_FactProy ([pro_idProyecto] ,pro_nroProyecto, [pro_NroContrato],[pro_NroRecibo],[pro_FechaRes],[pro_NroFactura]" _
                                       & " ,[pro_FechaFact],[pro_trabajoFac],[pro_Rete10],[pro_MtoRete10],[pro_Anticipo],[pro_Penalizacion]" _
                                       & " ,[pro_RETdeITBMS],[pro_MontoITBMS],[pro_CuentaCobrar],[pro_EntrInsp],[pro_FechaCliente],[pro_FechaCxc]" _
                                       & " ,[pro_FechaTes],[pro_FechaPago], nroDoc,pro_montoCheque,pro_manual ) VALUES " _
                                       & "( " & stridProy & ", " _
                                         & " '" & ProyNro & "', " _
                                       & " '" & ContNro & "', " _
                                       & " '" & pro_NroRecibo & "', " _
                                       & " '" & Format(pro_FechaRes, "yyyyMMdd") & "', " _
                                       & " '" & pro_NroFactura & "', " _
                                       & " '" & Format(pro_FechaFact, "yyyyMMdd") & "', " _
                                       & " " & Replace(pro_trabajoFac, ",", "") & "," _
                                       & " " & IIf(pro_MtoRete10 > 0, 0, 1) & "," _
                                       & " " & Replace(pro_MtoRete10, ",", "") & ", " _
                                       & " " & Replace(pro_Anticipo, ",", "") & ", " _
                                       & " " & Replace(pro_Penalizacion, ",", "") & ", " _
                                       & " " & Replace(pro_RETdeITBMS, ",", "") & ",  " _
                                       & " " & Replace(pro_MontoITBMS, ",", "") & ",  " _
                                       & " " & Replace(pro_CuentaCobrar, ",", "") & " ," _
                                       & " " & IIf(pro_FechaCliente <> "1900-01-01", 0, 1) & "," _
                                       & "'" & Format(pro_FechaCliente, "yyyyMMdd") & "'  ," _
                                       & " '" & Format(pro_FechaCxc, "yyyyMMdd") & "' ," _
                                       & " '" & Format(pro_FechaTes, "yyyyMMdd") & "' ," _
                                       & " '" & Format(pro_FechaPago, "yyyyMMdd") & "'," _
                                       & " '" & nroDoc & "'," & Replace(pro_montoCheque, ", ", "") & ", " & 0 & ")")

                End If


            End If



            If FactNro <> "" And RecNro = "" Then
                strDFact = cntSQL.Execute("select pro_idProyecto from import_tab_Aux_FactProy where pro_idProyecto='" & stridProy & "' and pro_NroContrato='" & ContNro & "' and pro_NroFactura='" & FactNro & "' and pro_NroRecibo='' ")

                If strDFact.EOF = False Then
                    cntSQL.Execute("UPDATE import_tab_Aux_FactProy SET [pro_NroContrato]='" & ContNro & "', " _
                                    & " [pro_NroRecibo]='" & pro_NroRecibo & "', " _
                                      & " [pro_nroProyecto]='" & ProyNro & "', " _
                                    & " [pro_FechaRes]= '" & Format(pro_FechaRes, "yyyyMMdd") & "', " _
                                    & " [pro_NroFactura]='" & pro_NroFactura & "', " _
                                    & " [pro_FechaFact]='" & Format(pro_FechaFact, "yyyyMMdd") & "', " _
                                    & " [pro_trabajoFac]=" & Replace(pro_trabajoFac, ",", "") & ", " _
                                    & "  pro_Rete10=" & IIf(pro_MtoRete10 > 0, 0, 1) & ", " _
                                    & " [pro_MtoRete10]= " & Replace(pro_MtoRete10, ",", "") & ", " _
                                    & " [pro_Anticipo]=" & Replace(pro_Anticipo, ",", "") & ", " _
                                    & " [pro_Penalizacion]=" & Replace(pro_Penalizacion, ",", "") & ", " _
                                    & " [pro_RETdeITBMS]=" & Replace(pro_RETdeITBMS, ",", "") & ", " _
                                    & " [pro_MontoITBMS]=" & Replace(pro_MontoITBMS, ",", "") & ", " _
                                    & " [pro_CuentaCobrar]=" & Replace(pro_CuentaCobrar, ",", "") & ", " _
                                    & " [pro_FechaCliente]='" & Format(pro_FechaCliente, "yyyyMMdd") & "', " _
                                    & " [pro_FechaCxc]='" & Format(pro_FechaCxc, "yyyyMMdd") & "', " _
                                    & " [pro_FechaTes]='" & Format(pro_FechaTes, "yyyyMMdd") & "', " _
                                    & " [pro_FechaPago]='" & Format(pro_FechaPago, "yyyyMMdd") & "', " _
                                    & " [nroDoc]='" & nroDoc & "' , " _
                                    & " pro_montoCheque=" & Replace(pro_montoCheque, ",", "") & ", " _
                                    & " pro_manual=" & 0 & " " _
                                    & "  where pro_idProyecto='" & stridProy & "' and pro_NroContrato='" & ContNro & "' and pro_NroFactura='" & FactNro & "' and pro_NroRecibo='' ")

                Else
                    cntSQL.Execute("insert into import_tab_Aux_FactProy ([pro_idProyecto] ,pro_nroProyecto,[pro_NroContrato],[pro_NroRecibo],[pro_FechaRes],[pro_NroFactura]" _
                                       & " ,[pro_FechaFact],[pro_trabajoFac],[pro_Rete10],[pro_MtoRete10],[pro_Anticipo],[pro_Penalizacion]" _
                                       & " ,[pro_RETdeITBMS],[pro_MontoITBMS],[pro_CuentaCobrar],[pro_EntrInsp],[pro_FechaCliente],[pro_FechaCxc]" _
                                       & " ,[pro_FechaTes],[pro_FechaPago], nroDoc, pro_montoCheque, pro_manual) VALUES " _
                                       & "( " & stridProy & ", " _
                       & " '" & ProyNro & "', " _
                                       & " '" & ContNro & "', " _
                                       & " '" & pro_NroRecibo & "', " _
                                       & " '" & Format(pro_FechaRes, "yyyyMMdd") & "', " _
                                       & " '" & pro_NroFactura & "', " _
                                       & " '" & Format(pro_FechaFact, "yyyyMMdd") & "', " _
                                       & " " & Replace(pro_trabajoFac, ",", "") & "," _
                                       & " " & IIf(pro_MtoRete10 > 0, 0, 1) & "," _
                                       & " " & Replace(pro_MtoRete10, ",", "") & ", " _
                                       & " " & Replace(pro_Anticipo, ",", "") & ", " _
                                       & " " & Replace(pro_Penalizacion, ",", "") & ", " _
                                       & " " & Replace(pro_RETdeITBMS, ",", "") & ",  " _
                                       & " " & Replace(pro_MontoITBMS, ",", "") & ",  " _
                                       & " " & Replace(pro_CuentaCobrar, ",", "") & " ," _
                                       & " " & IIf(pro_FechaCliente <> "1900-01-01", 0, 1) & "," _
                                       & "'" & Format(pro_FechaCliente, "yyyyMMdd") & "'  ," _
                                       & " '" & Format(pro_FechaCxc, "yyyyMMdd") & "' ," _
                                       & " '" & Format(pro_FechaTes, "yyyyMMdd") & "' ," _
                                       & " '" & Format(pro_FechaPago, "yyyyMMdd") & "'," _
                                       & " '" & nroDoc & "'," & Replace(pro_montoCheque, ", ", "") & ", " & 0 & ")")
                End If



            End If



            If FactNro <> "" And RecNro <> "" Then
                strDFact = cntSQL.Execute("select pro_idProyecto from import_tab_Aux_FactProy where pro_idProyecto='" & stridProy & "' and pro_NroContrato='" & ContNro & "' and pro_NroFactura='" & FactNro & "' and pro_NroRecibo='" & RecNro & "' ")

                If strDFact.EOF = False Then
                    cntSQL.Execute("UPDATE import_tab_Aux_FactProy SET [pro_NroContrato]='" & ContNro & "', " _
                                    & " [pro_NroRecibo]='" & pro_NroRecibo & "', " _
                                    & " [pro_nroProyecto]='" & ProyNro & "', " _
                                    & " [pro_FechaRes]= '" & Format(pro_FechaRes, "yyyyMMdd") & "', " _
                                    & " [pro_NroFactura]='" & pro_NroFactura & "', " _
                                    & " [pro_FechaFact]='" & Format(pro_FechaFact, "yyyyMMdd") & "', " _
                                    & " [pro_trabajoFac]=" & Replace(pro_trabajoFac, ",", "") & ", " _
                                    & "  pro_Rete10=" & IIf(pro_MtoRete10 > 0, 0, 1) & ", " _
                                    & " [pro_MtoRete10]= " & Replace(pro_MtoRete10, ",", "") & ", " _
                                    & " [pro_Anticipo]=" & Replace(pro_Anticipo, ",", "") & ", " _
                                    & " [pro_Penalizacion]=" & Replace(pro_Penalizacion, ",", "") & ", " _
                                    & " [pro_RETdeITBMS]=" & Replace(pro_RETdeITBMS, ",", "") & ", " _
                                    & " [pro_MontoITBMS]=" & Replace(pro_MontoITBMS, ",", "") & ", " _
                                    & " [pro_CuentaCobrar]=" & Replace(pro_CuentaCobrar, ",", "") & ", " _
                                    & " [pro_FechaCliente]='" & Format(pro_FechaCliente, "yyyyMMdd") & "', " _
                                    & " [pro_FechaCxc]='" & Format(pro_FechaCxc, "yyyyMMdd") & "', " _
                                    & " [pro_FechaTes]='" & Format(pro_FechaTes, "yyyyMMdd") & "', " _
                                    & " [pro_FechaPago]='" & Format(pro_FechaPago, "yyyyMMdd") & "', " _
                                    & " [nroDoc]='" & nroDoc & "', " _
                                    & " pro_montoCheque=" & Replace(pro_montoCheque, ",", "") & ", " _
                                    & " pro_manual=" & 0 & " " _
                                    & "  where pro_idProyecto='" & stridProy & "' and pro_NroContrato='" & ContNro & "' and pro_NroFactura='" & FactNro & "' and pro_NroRecibo='" & RecNro & "' ")

                Else
                    cntSQL.Execute("insert into import_tab_Aux_FactProy ([pro_idProyecto] ,pro_nroProyecto,[pro_NroContrato],[pro_NroRecibo],[pro_FechaRes],[pro_NroFactura]" _
                                       & " ,[pro_FechaFact],[pro_trabajoFac],[pro_Rete10],[pro_MtoRete10],[pro_Anticipo],[pro_Penalizacion]" _
                                       & " ,[pro_RETdeITBMS],[pro_MontoITBMS],[pro_CuentaCobrar],[pro_EntrInsp],[pro_FechaCliente],[pro_FechaCxc]" _
                                       & " ,[pro_FechaTes],[pro_FechaPago], nroDoc,pro_montoCheque, pro_manual) VALUES " _
                                       & "( " & stridProy & ", " _
                                         & " '" & ProyNro & "', " _
                                       & " '" & ContNro & "', " _
                                       & " '" & pro_NroRecibo & "', " _
                                       & " '" & Format(pro_FechaRes, "yyyyMMdd") & "', " _
                                       & " '" & pro_NroFactura & "', " _
                                       & " '" & Format(pro_FechaFact, "yyyyMMdd") & "', " _
                                       & " " & Replace(pro_trabajoFac, ",", "") & "," _
                                       & " " & IIf(pro_MtoRete10 > 0, 0, 1) & "," _
                                       & " " & Replace(pro_MtoRete10, ",", "") & ", " _
                                       & " " & Replace(pro_Anticipo, ",", "") & ", " _
                                       & " " & Replace(pro_Penalizacion, ",", "") & ", " _
                                       & " " & Replace(pro_RETdeITBMS, ",", "") & ",  " _
                                       & " " & Replace(pro_MontoITBMS, ",", "") & ",  " _
                                       & " " & Replace(pro_CuentaCobrar, ",", "") & " ," _
                                       & " " & IIf(pro_FechaCliente <> "1900-01-01", 0, 1) & "," _
                                       & "'" & Format(pro_FechaCliente, "yyyyMMdd") & "'  ," _
                                       & " '" & Format(pro_FechaCxc, "yyyyMMdd") & "' ," _
                                       & " '" & Format(pro_FechaTes, "yyyyMMdd") & "' ," _
                                       & " '" & Format(pro_FechaPago, "yyyyMMdd") & "'," _
                                       & " '" & nroDoc & "'," & Replace(pro_montoCheque, ", ", "") & "," & 0 & ")")
                End If


            End If



            swguar = 1
        Catch ex As Exception
            MsgBox("Error en funcion guardaActProyeimportDFact" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
        swguar = 0
    End Sub


    Private Sub ToolStripButton5_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click

        'If cnConex.State <> 1 Then
        '    cnConex.Close()
        'End If
        limpiarDatosImport()
    End Sub

    Private Sub ToolStripButton6_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        'If cnConex.STATE <> 1 Then
        '    cnConex.CLOSE()
        'End If
        Me.Close()
    End Sub



    Private Sub chk1_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk1.CheckedChanged
        If chk1.Checked = True Then
            cmb1.Enabled = True
        Else
            cmb1.Enabled = False
            datosPpalProy(1) = ""
            datosPpalProy1(1) = ""
        End If
    End Sub

    Private Sub chk2_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk2.CheckedChanged
        If chk2.Checked = True Then
            cmb2.Enabled = True
        Else
            cmb2.Enabled = False
            datosPpalProy(2) = ""
            datosPpalProy1(2) = ""
        End If
    End Sub

    Private Sub chk3_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk3.CheckedChanged
        If chk3.Checked = True Then
            cmb3.Enabled = True
        Else
            cmb3.Enabled = False
            datosPpalProy(3) = ""
            datosPpalProy1(3) = ""
        End If
    End Sub

    Private Sub chk4_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk4.CheckedChanged
        If chk4.Checked = True Then
            cmb4.Enabled = True
        Else
            cmb4.Enabled = False
            datosPpalProy(4) = ""
            datosPpalProy1(4) = ""
        End If
    End Sub

   
    Private Sub cmb1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb1.SelectedIndexChanged

        CADENA = cmb1.SelectedItem
        llenarVector()

        Fk = IIf(cmb1.SelectedIndex = -1, 1, cmb1.SelectedIndex + 1)

        datosPpalProy(1) = Fk & ".V"
        datosPpalProy1(1) = Fj & ".V"
    End Sub

    Private Sub cmb2_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb2.SelectedIndexChanged
        Fk = 0
        CADENA = cmb2.SelectedItem
        llenarVector()
        Fk = IIf(cmb2.SelectedIndex = -1, 1, cmb2.SelectedIndex + 1)
        datosPpalProy(2) = Fk & ".V"
        datosPpalProy1(2) = Fj & ".V"
    End Sub

    Private Sub cmb3_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb3.SelectedIndexChanged
        Fk = 0
        CADENA = cmb3.SelectedItem
        llenarVector()
        Fk = IIf(cmb3.SelectedIndex = -1, 1, cmb3.SelectedIndex + 1)
        datosPpalProy(3) = Fk & ".V"
        datosPpalProy1(3) = Fj & ".V"

    End Sub

    Private Sub cmb4_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb4.SelectedIndexChanged
        Fk = 0
        CADENA = cmb4.SelectedItem
        llenarVector()
        Fk = IIf(cmb4.SelectedIndex = -1, 1, cmb4.SelectedIndex + 1)
        datosPpalProy(4) = Fk & ".V"
        datosPpalProy1(4) = Fj & ".V"
    End Sub

    

  

    

   

   



  

  

   

    

  

   

    

   

    Private Sub chk20_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk20.CheckedChanged
        If chk20.Checked = True Then
            cmb20.Enabled = True
        Else
            cmb20.Enabled = False
            datosPpalProy(20) = ""
            datosPpalProy1(20) = ""
        End If
    End Sub


    Private Sub cmb20_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb20.SelectedIndexChanged
        Fk = 0
        CADENA = cmb20.SelectedItem
        llenarVector()

        Fk = IIf(cmb20.SelectedIndex = -1, 1, cmb20.SelectedIndex + 1)

        datosPpalProy(20) = Fk & ".V"
        datosPpalProy1(20) = Fj & ".V"
    End Sub

    Private Sub chk21_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk21.CheckedChanged
        If chk21.Checked = True Then
            cmb21.Enabled = True
        Else
            cmb21.Enabled = False
            datosPpalProy(21) = ""
            datosPpalProy1(21) = ""
        End If
    End Sub

    Private Sub chk22_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk22.CheckedChanged
        If chk22.Checked = True Then
            cmb22.Enabled = True
        Else
            cmb22.Enabled = False
            datosPpalProy(22) = ""
            datosPpalProy1(22) = ""
        End If
    End Sub

    Private Sub chk23_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk23.CheckedChanged
        If chk23.Checked = True Then
            cmb23.Enabled = True
        Else
            cmb23.Enabled = False
            datosPpalProy(23) = ""
            datosPpalProy1(23) = ""
        End If
    End Sub

    Private Sub chk24_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk24.CheckedChanged
        If chk24.Checked = True Then
            cmb24.Enabled = True
        Else
            cmb24.Enabled = False
            datosPpalProy(24) = ""
            datosPpalProy1(24) = ""
        End If
    End Sub

    Private Sub chk25_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk25.CheckedChanged
        If chk25.Checked = True Then
            cmb25.Enabled = True
        Else
            cmb25.Enabled = False
            datosPpalProy(25) = ""
            datosPpalProy1(25) = ""
        End If
    End Sub

    Private Sub chk26_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk26.CheckedChanged
        If chk26.Checked = True Then
            cmb26.Enabled = True
        Else
            cmb26.Enabled = False
            datosPpalProy(26) = ""
            datosPpalProy1(26) = ""
        End If
    End Sub

    Private Sub chk27_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk27.CheckedChanged
        If chk27.Checked = True Then
            cmb27.Enabled = True
        Else
            cmb27.Enabled = False
            datosPpalProy(27) = ""
            datosPpalProy1(27) = ""
        End If
    End Sub

    Private Sub chk28_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk28.CheckedChanged
        If chk28.Checked = True Then
            cmb28.Enabled = True
        Else
            cmb28.Enabled = False
            datosPpalProy(28) = ""
            datosPpalProy1(28) = ""
        End If
    End Sub

    Private Sub chk29_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk29.CheckedChanged
        If chk29.Checked = True Then
            cmb29.Enabled = True
        Else
            cmb29.Enabled = False
            datosPpalProy(29) = ""
            datosPpalProy1(29) = ""
        End If
    End Sub

    Private Sub chk30_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk30.CheckedChanged
        If chk30.Checked = True Then
            cmb30.Enabled = True
        Else
            cmb30.Enabled = False
            datosPpalProy(30) = ""
            datosPpalProy1(30) = ""
        End If
    End Sub

    Private Sub chk31_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk31.CheckedChanged
        If chk31.Checked = True Then
            cmb31.Enabled = True
        Else
            cmb31.Enabled = False
            datosPpalProy(31) = ""
            datosPpalProy1(31) = ""
        End If
    End Sub

    Private Sub chk32_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk32.CheckedChanged
        If chk32.Checked = True Then
            cmb32.Enabled = True
        Else
            cmb32.Enabled = False
            datosPpalProy(32) = ""
            datosPpalProy1(32) = ""
        End If
    End Sub

    Private Sub cmb28_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb28.SelectedIndexChanged
        Fk = 0
        CADENA = cmb28.SelectedItem
        llenarVector()
        ' llenarVectorfecha()
        Fk = IIf(cmb28.SelectedIndex = -1, 1, cmb28.SelectedIndex + 1)

        datosPpalProy(28) = Fk & ".F"
        datosPpalProy1(28) = Fj & ".F"
    End Sub

    Private Sub cmb29_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb29.SelectedIndexChanged
        Fk = 0
        CADENA = cmb29.SelectedItem
        llenarVector()
        ' llenarVectorfecha()
        Fk = IIf(cmb29.SelectedIndex = -1, 1, cmb29.SelectedIndex + 1)

        datosPpalProy(29) = Fk & ".F"
        datosPpalProy1(29) = Fj & ".F"
    End Sub

    Private Sub cmb31_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb31.SelectedIndexChanged
        Fk = 0
        CADENA = cmb31.SelectedItem
        llenarVector()
        ' llenarVectorfecha()
        Fk = IIf(cmb31.SelectedIndex = -1, 1, cmb31.SelectedIndex + 1)

        datosPpalProy(31) = Fk & ".F"
        datosPpalProy1(31) = Fj & ".F"
    End Sub

    Private Sub cmb32_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb32.SelectedIndexChanged
        Fk = 0
        CADENA = cmb32.SelectedItem
        llenarVector()
        ' llenarVectorfecha()
        Fk = IIf(cmb32.SelectedIndex = -1, 1, cmb32.SelectedIndex + 1)

        datosPpalProy(32) = Fk & ".F"
        datosPpalProy1(32) = Fj & ".F"
    End Sub

    Private Sub cmb27_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb27.SelectedIndexChanged
        Fk = 0
        CADENA = cmb27.SelectedItem
        llenarVector()
        ' llenarVectorfecha()
        Fk = IIf(cmb27.SelectedIndex = -1, 1, cmb27.SelectedIndex + 1)

        datosPpalProy(27) = Fk & ".M"
        datosPpalProy1(27) = Fj & ".M"
    End Sub

    Private Sub cmb21_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb21.SelectedIndexChanged
        Fk = 0
        CADENA = cmb21.SelectedItem
        llenarVector()

        Fk = IIf(cmb21.SelectedIndex = -1, 1, cmb21.SelectedIndex + 1)

        datosPpalProy(21) = Fk & ".V"
        datosPpalProy1(21) = Fj & ".V"
    End Sub

    Private Sub cmb22_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb22.SelectedIndexChanged
        Fk = 0
        CADENA = cmb22.SelectedItem
        llenarVector()

        Fk = IIf(cmb22.SelectedIndex = -1, 1, cmb22.SelectedIndex + 1)

        datosPpalProy(22) = Fk & ".V"
        datosPpalProy1(22) = Fj & ".V"
    End Sub

    Private Sub cmb23_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb23.SelectedIndexChanged
        Fk = 0
        CADENA = cmb23.SelectedItem
        llenarVector()

        Fk = IIf(cmb23.SelectedIndex = -1, 1, cmb23.SelectedIndex + 1)

        datosPpalProy(23) = Fk & ".V"
        datosPpalProy1(23) = Fj & ".V"
    End Sub

    Private Sub cmb24_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb24.SelectedIndexChanged
        Fk = 0
        CADENA = cmb24.SelectedItem
        llenarVector()

        Fk = IIf(cmb24.SelectedIndex = -1, 1, cmb24.SelectedIndex + 1)

        datosPpalProy(24) = Fk & ".V"
        datosPpalProy1(24) = Fj & ".V"
    End Sub

    Private Sub cmb25_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb25.SelectedIndexChanged
        Fk = 0
        CADENA = cmb25.SelectedItem
        llenarVector()

        Fk = IIf(cmb25.SelectedIndex = -1, 1, cmb25.SelectedIndex + 1)

        datosPpalProy(25) = Fk & ".V"
        datosPpalProy1(25) = Fj & ".V"
    End Sub

    Private Sub cmb26_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb26.SelectedIndexChanged
        Fk = 0
        CADENA = cmb26.SelectedItem
        llenarVector()

        Fk = IIf(cmb26.SelectedIndex = -1, 1, cmb26.SelectedIndex + 1)

        datosPpalProy(26) = Fk & ".V"
        datosPpalProy1(26) = Fj & ".V"
    End Sub

    Private Sub cmb30_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb30.SelectedIndexChanged
        Fk = 0
        CADENA = cmb30.SelectedItem
        llenarVector()

        Fk = IIf(cmb30.SelectedIndex = -1, 1, cmb30.SelectedIndex + 1)

        datosPpalProy(30) = Fk & ".V"
        datosPpalProy1(30) = Fj & ".V"
    End Sub

   


























    Private Sub ToolStripButton4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click

        If archivoEx = "" Then
            MsgBox("Debe Selecionar un Archivo", MsgBoxStyle.Critical, "Control Proyectos")
        Else
            Proyecto = ""
            leeVector()
            ImportExcellToDataGridView(archivoEx, gpbDres)
        End If

    End Sub



    

   

    Private Sub chk65_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk65.CheckedChanged
        If chk65.Checked = True Then
            cmb65.Enabled = True
        Else
            cmb65.Enabled = False
            datosPpalProy(65) = ""
            datosPpalProy1(65) = ""
        End If
    End Sub

    Private Sub cmb65_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb65.SelectedIndexChanged
        Fk = 0
        CADENA = cmb65.SelectedItem
        llenarVector()
        ' llenarVectorfecha()
        Fk = IIf(cmb65.SelectedIndex = -1, 1, cmb65.SelectedIndex + 1)

        datosPpalProy(65) = Fk & ".V"
        datosPpalProy1(65) = Fj & ".V"
    End Sub












  
 

   
End Class
Imports System.Data.OleDb
Imports System.IO
Public Class frmImportacion

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
    Public pro_FechaD As Date
    Public pro_FechaH As Date
    Public pro_FechaOrg As Date
    Public pro_status As String = ""
    Public pro_tipo As String = ""
    Public pro_duracionOriginalCont As Integer = 0
    Public pro_ITBMS As Decimal = 0

    'VARIABLES IMPORTACION DE DATOS PPALES_COMPL
    Public pro_nroCuenta As Integer = 0
    Public pro_serieCuenta As String = ""
    Public pro_periodoCuenta As Decimal = 0
    Public pro_TrabajoR As Decimal = 0
    Public pro_FechaR As Date
    Public pro_PresInsp As Decimal = 0
    Public pro_FechaP As Date
    Public pro_NroFacturas As String = ""
    Public pro_FechaInicio As Date
    Public pro_FechaFinOrig As Date
    Public pro_duracionproy As Decimal = 0


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

    Private Sub chk5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If chk5.Checked = True Then
            cmb5.Enabled = True
        Else
            cmb5.Enabled = False
        End If
    End Sub

    Private Sub chk6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If chk6.Checked = True Then
            cmb6.Enabled = True
        Else
            cmb6.Enabled = False
        End If
    End Sub

    Private Sub chk7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If chk7.Checked = True Then
            cmb7.Enabled = True
        Else
            cmb7.Enabled = False
        End If
    End Sub

    Private Sub chk8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If chk8.Checked = True Then
            cmb8.Enabled = True
        Else
            cmb8.Enabled = False
        End If
    End Sub

    Private Sub chk9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If chk9.Checked = True Then
            cmb9.Enabled = True
        Else
            cmb9.Enabled = False
        End If
    End Sub

    Private Sub chk10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If chk10.Checked = True Then
            cmb10.Enabled = True
        Else
            cmb10.Enabled = False
        End If
    End Sub

    Private Sub chk11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If chk11.Checked = True Then
            cmb11.Enabled = True
        Else
            cmb11.Enabled = False
        End If
    End Sub

    Private Sub chk12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If chk12.Checked = True Then
            cmb12.Enabled = True
        Else
            cmb12.Enabled = False
        End If
    End Sub

    Private Sub chk13_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If chk13.Checked = True Then
            cmb13.Enabled = True
        Else
            cmb13.Enabled = False
        End If
    End Sub

    Private Sub chk14_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If chk14.Checked = True Then
            cmb14.Enabled = True
        Else
            cmb14.Enabled = False
        End If
    End Sub

    Private Sub chk15_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If chk15.Checked = True Then
            cmb15.Enabled = True
        Else
            cmb15.Enabled = False
        End If
    End Sub

    Private Sub chk16_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If chk16.Checked = True Then
            cmb16.Enabled = True
        Else
            cmb16.Enabled = False
        End If
    End Sub

    Private Sub chk17_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If chk17.Checked = True Then
            cmb17.Enabled = True
        Else
            cmb17.Enabled = False
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
            cmb5.Items.Add("COLUMNA " & Chr(i))
            cmb6.Items.Add("COLUMNA " & Chr(i))
            cmb7.Items.Add("COLUMNA " & Chr(i))
            cmb8.Items.Add("COLUMNA " & Chr(i))
            cmb9.Items.Add("COLUMNA " & Chr(i))
            cmb10.Items.Add("COLUMNA " & Chr(i))
            cmb11.Items.Add("COLUMNA " & Chr(i))
            cmb12.Items.Add("COLUMNA " & Chr(i))
            cmb13.Items.Add("COLUMNA " & Chr(i))
            cmb14.Items.Add("COLUMNA " & Chr(i))
            cmb15.Items.Add("COLUMNA " & Chr(i))
            cmb16.Items.Add("COLUMNA " & Chr(i))
            cmb17.Items.Add("COLUMNA " & Chr(i))
            cmb18.Items.Add("COLUMNA " & Chr(i))
            cmb19.Items.Add("COLUMNA " & Chr(i))
            cmb20.Items.Add("COLUMNA " & Chr(i))

        Next

        For i = 65 To 90
            cmb1.Items.Add("COLUMNA " & "A" & Chr(i))
            cmb2.Items.Add("COLUMNA " & "A" & Chr(i))
            cmb3.Items.Add("COLUMNA " & "A" & Chr(i))
            cmb4.Items.Add("COLUMNA " & "A" & Chr(i))
            cmb5.Items.Add("COLUMNA " & "A" & Chr(i))
            cmb6.Items.Add("COLUMNA " & "A" & Chr(i))
            cmb7.Items.Add("COLUMNA " & "A" & Chr(i))
            cmb8.Items.Add("COLUMNA " & "A" & Chr(i))
            cmb9.Items.Add("COLUMNA " & "A" & Chr(i))
            cmb10.Items.Add("COLUMNA " & "A" & Chr(i))
            cmb11.Items.Add("COLUMNA " & "A" & Chr(i))
            cmb12.Items.Add("COLUMNA " & "A" & Chr(i))
            cmb13.Items.Add("COLUMNA " & "A" & Chr(i))
            cmb14.Items.Add("COLUMNA " & "A" & Chr(i))
            cmb15.Items.Add("COLUMNA " & "A" & Chr(i))
            cmb16.Items.Add("COLUMNA " & "A" & Chr(i))
            cmb17.Items.Add("COLUMNA " & "A" & Chr(i))
            cmb18.Items.Add("COLUMNA " & "A" & Chr(i))
            cmb19.Items.Add("COLUMNA " & "A" & Chr(i))
            cmb20.Items.Add("COLUMNA " & "A" & Chr(i))
         
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

    Private Sub cmb5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CADENA = cmb5.SelectedItem
        llenarVector()
        datosPpalProy(5) = Fk + 1
        datosPpalProy1(5) = Fj

    End Sub

    Private Sub cmb6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CADENA = cmb6.SelectedItem
        llenarVector()

        llenarVectorMonto()
        datosPpalProy(6) = Fk + 1
        datosPpalProy1(6) = Fj

    End Sub

    Private Sub cmb7_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CADENA = cmb7.SelectedItem
        llenarVector()
        llenarVectorenteros()
        datosPpalProy(7) = Fk + 1
        datosPpalProy1(7) = Fj


    End Sub

    Private Sub cmb8_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CADENA = cmb8.SelectedItem
        llenarVector()
        llenarVectorfecha()
        datosPpalProy(8) = Fk + 1
        datosPpalProy1(8) = Fj

    End Sub

    Private Sub cmb9_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CADENA = cmb9.SelectedItem
        llenarVector()
        llenarVectorfecha()
        datosPpalProy(9) = Fk + 1
        datosPpalProy1(9) = Fj

    End Sub

    Private Sub cmb10_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CADENA = cmb10.SelectedItem
        llenarVector()

        llenarVectorMonto()
        datosPpalProy(10) = Fk + 1
        datosPpalProy1(10) = Fj

    End Sub

    Private Sub cmb11_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CADENA = cmb11.SelectedItem
        llenarVector()
        llenarVectorfecha()
        datosPpalProy(11) = Fk + 1
        datosPpalProy1(11) = Fj

    End Sub

    Private Sub cmb12_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CADENA = cmb12.SelectedItem
        llenarVector()
        datosPpalProy(12) = Fk + 1
        datosPpalProy1(12) = Fj

    End Sub

    Private Sub cmb13_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CADENA = cmb13.SelectedItem
        llenarVector()
        llenarVectorfecha()
        datosPpalProy(13) = Fk + 1
        datosPpalProy1(13) = Fj

    End Sub

    Private Sub cmb14_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CADENA = cmb14.SelectedItem
        llenarVector()
        llenarVectorenteros()
        datosPpalProy(14) = Fk + 1
        datosPpalProy1(14) = Fj

    End Sub

    Private Sub cmb15_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CADENA = cmb15.SelectedItem
        llenarVector()
        llenarVectorMonto()
        datosPpalProy(15) = Fk + 1
        datosPpalProy1(15) = Fj

    End Sub

    Private Sub cmb16_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CADENA = cmb16.SelectedItem
        llenarVector()
        llenarVectorfecha()
        datosPpalProy(16) = Fk + 1
        datosPpalProy1(16) = Fj

    End Sub

    Private Sub cmb17_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CADENA = cmb17.SelectedItem
        llenarVector()
        llenarVectorfecha()
        datosPpalProy(17) = Fk + 1
        datosPpalProy1(17) = Fj

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

                            ' MsgBox("Existen Campos Vacios, por favor revise el archivo", MsgBoxStyle.Critical, "Control Proyectos")
                            ' Me.gpbDres.CurrentCell = Me.gpbDres(j, i)

                            ' Exit Sub
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

                    valor = Val(datosPpalProy(7))
                    If valor <> "" And valor <> 0 Then

                        k = k + 1

                    End If

                   


                    valor = Val(datosPpalProy(8))
                    If valor <> "" And valor <> 0 Then
                        If IsDate(gpbDres.Rows(Fila).Cells(k).Value()) Then
                            pro_FechaD = gpbDres.Rows(Fila).Cells(k).Value()
                        Else
                            pro_FechaD = "1900-01-01"
                        End If
                        k = k + 1
                    Else
                        pro_FechaD = "1900-01-01"
                    End If

                    valor = Val(datosPpalProy(9))
                    If valor <> "" And valor <> 0 Then

                        If IsDate(gpbDres.Rows(Fila).Cells(k).Value()) Then
                            pro_FechaH = gpbDres.Rows(Fila).Cells(k).Value()
                        Else
                            pro_FechaH = "1900-01-01"
                        End If
                        k = k + 1
                    Else
                        pro_FechaH = "1900-01-01"
                    End If
                   

                    valor = Val(datosPpalProy(17))
                    If valor <> "" And valor <> 0 Then

                        If IsDate(gpbDres.Rows(Fila).Cells(k).Value()) Then
                            pro_FechaOrg = gpbDres.Rows(Fila).Cells(k).Value()
                        Else
                            pro_FechaOrg = "1900-01-01"
                        End If
                        k = k + 1
                    Else
                        pro_FechaOrg = "1900-01-01"
                    End If

                    valor = Val(datosPpalProy(18))

                    If valor <> "" And valor <> 0 Then

                        pro_status = UCase(IIf(gpbDres.Rows(Fila).Cells(k).Value() Is DBNull.Value, 0, gpbDres.Rows(Fila).Cells(k).Value()))

                        k = k + 1

                    End If

                    valor = Val(datosPpalProy(19))
                    If valor <> "" And valor <> 0 Then

                        pro_tipo = UCase(IIf(gpbDres.Rows(Fila).Cells(k).Value() Is DBNull.Value, 0, gpbDres.Rows(Fila).Cells(k).Value()))
                        k = k + 1
                    End If

                    'valor = Val(datosPpalProy(20))
                    'If valor <> "" And valor <> 0 Then

                    '    k = k + 1

                    'End If


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

                    valor = Val(datosPpalProy(5))
                    If valor <> "" And valor <> 0 Then

                        pro_provincia = IIf(gpbDres.Rows(Fila).Cells(k).Value() Is DBNull.Value, "", gpbDres.Rows(Fila).Cells(k).Value())
                        k = k + 1
                    Else
                        k = k + 1

                    End If

                    valor = Val(datosPpalProy(6))
                    If valor <> "" And valor <> 0 Then

                        pro_monto = IIf(gpbDres.Rows(Fila).Cells(k).Value() Is DBNull.Value, 0, gpbDres.Rows(Fila).Cells(k).Value())
                        k = k + 1
                    Else
                        k = k + 1
                    End If
                  
                    valor = Val(datosPpalProy(7))
                    If valor <> "" And valor <> 0 Then

                        pro_serieCuenta = gpbDres.Rows(Fila).Cells(k).Value()
                        pro_nroCuenta = i
                        CtaNro = i
                        i = i + 1
                        db = db + 1
                        k = k + 1
                    Else
                        k = k + 1

                    End If

                  


                    valor = Val(datosPpalProy(8))
                    If valor <> "" And valor <> 0 Then
                        If IsDate(gpbDres.Rows(Fila).Cells(k).Value()) Then
                            pro_FechaD = gpbDres.Rows(Fila).Cells(k).Value()
                        Else
                            pro_FechaD = "1900-01-01"
                        End If

                        k = k + 1
                        db = db + 1
                    Else
                        pro_FechaD = "1900-01-01"
                    End If

                    valor = Val(datosPpalProy(9))
                    If valor <> "" And valor <> 0 Then

                        If IsDate(gpbDres.Rows(Fila).Cells(k).Value()) Then
                            pro_FechaH = gpbDres.Rows(Fila).Cells(k).Value()
                        Else
                            pro_FechaH = "1900-01-01"
                        End If

                        k = k + 1
                        db = db + 1
                    Else
                        pro_FechaH = "1900-01-01"
                    End If

                    valor = Val(datosPpalProy(10))
                    If valor <> "" And valor <> 0 Then

                        pro_TrabajoR = gpbDres.Rows(Fila).Cells(k).Value()
                        db = db + 1
                        k = k + 1
                    End If

                    valor = Val(datosPpalProy(11))
                    If valor <> "" And valor <> 0 Then

                        If IsDate(gpbDres.Rows(Fila).Cells(k).Value()) Then
                            pro_FechaR = gpbDres.Rows(Fila).Cells(k).Value()
                        Else
                            pro_FechaR = "1900-01-01"
                        End If

                        k = k + 1
                        db = db + 1
                    Else
                        pro_FechaR = "1900-01-01"
                    End If

                    valor = Val(datosPpalProy(12))

                    If valor <> "" And valor <> 0 Then

                        pro_PresInsp = IIf(gpbDres.Rows(Fila).Cells(k).Value() Is DBNull.Value, 0, gpbDres.Rows(Fila).Cells(k).Value())
                        db = db + 1
                        k = k + 1
                    End If

                    valor = Val(datosPpalProy(13))
                    If valor <> "" And valor <> 0 Then

                        If IsDate(gpbDres.Rows(Fila).Cells(k).Value()) Then
                            pro_FechaP = gpbDres.Rows(Fila).Cells(k).Value()
                        Else
                            pro_FechaP = "1900-01-01"
                        End If

                        k = k + 1
                        db = db + 1
                    Else
                        pro_FechaP = "1900-01-01"
                    End If

                    valor = Val(datosPpalProy(14))
                    If valor <> "" And valor <> 0 Then

                        pro_duracionproy = IIf(gpbDres.Rows(Fila).Cells(k).Value() Is DBNull.Value, 0, gpbDres.Rows(Fila).Cells(k).Value())
                        db = db + 1
                        k = k + 1
                    End If

                    valor = Val(datosPpalProy(15))
                    If valor <> "" And valor <> 0 Then

                        pro_periodoCuenta = IIf(gpbDres.Rows(Fila).Cells(k).Value() Is DBNull.Value, 0, gpbDres.Rows(Fila).Cells(k).Value())
                        db = db + 1
                        k = k + 1
                    End If

                    valor = Val(datosPpalProy(16))
                    If valor <> "" And valor <> 0 Then
                        If IsDate(gpbDres.Rows(Fila).Cells(k).Value()) Then
                            pro_FechaInicio = gpbDres.Rows(Fila).Cells(k).Value()
                        Else
                            pro_FechaInicio = "1900-01-01"
                        End If

                        db = db + 1
                        k = k + 1
                    Else
                        pro_FechaInicio = "1900-01-01"
                    End If

                    valor = Val(datosPpalProy(17))

                    If valor <> "" And valor <> 0 Then
                        If IsDate(gpbDres.Rows(Fila).Cells(k).Value()) Then
                            pro_FechaFinOrig = gpbDres.Rows(Fila).Cells(k).Value()
                        Else
                            pro_FechaFinOrig = "1900-01-01"
                        End If

                        k = k + 1

                        db = db + 1
                    Else
                        pro_FechaFinOrig = "1900-01-01"
                    End If

                    valor = Val(datosPpalProy(18))

                    If valor <> "" And valor <> 0 Then

                        pro_status = UCase(IIf(gpbDres.Rows(Fila).Cells(k).Value() Is DBNull.Value, 0, gpbDres.Rows(Fila).Cells(k).Value()))
                        db = db + 1
                        k = k + 1

                    End If

                    valor = Val(datosPpalProy(19))
                    If valor <> "" And valor <> 0 Then

                        pro_tipo = UCase(IIf(gpbDres.Rows(Fila).Cells(k).Value() Is DBNull.Value, 0, gpbDres.Rows(Fila).Cells(k).Value()))
                        db = db + 1
                        k = k + 1
                    End If

                    valor = Val(datosPpalProy(20))
                    If valor <> "" And valor <> 0 Then

                        pro_NroFacturas = IIf(gpbDres.Rows(Fila).Cells(k).Value() Is DBNull.Value, 0, gpbDres.Rows(Fila).Cells(k).Value())
                        db = db + 1
                        k = k + 1

                    End If

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
                                    & " pro_FechaD='" & Format(pro_FechaD, "yyyyMMdd") & "'," _
                                    & " pro_FechaH='" & Format(pro_FechaH, "yyyyMMdd") & "'," _
                                    & " nroDoc='" & nroDoc & "' " _
                                    & " where pro_idProyecto=" & stridProy & "")

                Else
                    'strCodProy = ProyNro
                    'idProyecto(1)
                    'id = stridProy

                    cntSQL.Execute("insert into import_tab_DatosPpalProy (pro_idProyecto,pro_nroProyecto,pro_descripcion,pro_Sector,pro_nroContrato,pro_Provincia,pro_monto,pro_FechaD,pro_FechaH," _
                                 & " nroDoc ) values (  '" & id & "', " _
                                       & " '" & ProyNro & "', " _
                                       & " '" & pro_descripcion & "', " _
                                       & " '" & Sector(pro_Sector) & "', " _
                                       & " '" & pro_nroContrato & "', " _
                                       & " '" & pro_provincia & "', " _
                                       & "  " & Replace(pro_monto, ",", "") & ", " _
                                       & " '" & Format(pro_FechaD, "yyyyMMdd") & "', " _
                                       & " '" & Format(pro_FechaH, "yyyyMMdd") & "', " _
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
                                    & " pro_FechaD='" & Format(pro_FechaD, "yyyyMMdd") & "'," _
                                    & " pro_FechaH='" & Format(pro_FechaH, "yyyyMMdd") & "'," _
                                    & " nroDoc='" & nroDoc & "' " _
                                    & " where pro_idProyecto=" & stridProy & " and pro_nroContrato='" & ContNro & "'")

                Else
                    'strCodProy = ProyNro
                    'idProyecto(1)
                    'id = stridProy

                    cntSQL.Execute("insert into import_tab_DatosPpalProy (pro_idProyecto,pro_nroProyecto,pro_descripcion,pro_Sector,pro_nroContrato,pro_Provincia,pro_monto,pro_FechaD,pro_FechaH,nroDoc) values (  '" & id & "', " _
                                       & " '" & ProyNro & "', " _
                                       & " '" & pro_descripcion & "', " _
                                       & " '" & Sector(pro_Sector) & "', " _
                                       & " '" & pro_nroContrato & "', " _
                                       & " '" & pro_provincia & "', " _
                                       & "  " & Replace(pro_monto, ",", "") & ", " _
                                       & " '" & Format(pro_FechaD, "yyyyMMdd") & "', " _
                                       & " '" & Format(pro_FechaH, "yyyyMMdd") & "', " _
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
                                    & " pro_status='" & Sector(pro_Sector) & "', " _
                                    & " nroDoc='" & nroDoc & "', " _
                                    & " pro_NroFactura='" & pro_NroFacturas & "' " _
                                    & " where pro_idProyecto=" & stridProy & "")

                Else
                    strCodProy = ProyNro
                    idProyecto(1)
                    id = stridProy

                    cntSQL.Execute("insert into import_tab_DatosPpalProy_Compl (pro_idProyecto,pro_nroProyecto,pro_nroContrato," _
                                 & " pro_nroCuenta,pro_serieCuenta, pro_FechaD, pro_FechaH, pro_TrabajoR,pro_FechaR,pro_PresInsp,pro_FechaP," _
                                 & "pro_status,nroDoc,pro_NroFactura ) values (  '" & id & "', " _
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
                                       & " '" & Sector(pro_Sector) & " ', " _
                                       & " '" & nroDoc & "'," _
                                       & " '" & pro_NroFacturas & "')")

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
                                    & " pro_status='" & Sector(pro_Sector) & "', " _
                                    & " nroDoc='" & nroDoc & "', " _
                                    & " pro_NroFactura='" & pro_NroFacturas & "' " _
                                    & " where pro_idProyecto=" & stridProy & " and pro_nroContrato='" & ContNro & "'")

                Else
                    strCodProy = ProyNro
                    idProyecto(1)
                    id = stridProy

                    cntSQL.Execute("insert into import_tab_DatosPpalProy_Compl (pro_idProyecto,pro_nroProyecto,pro_nroContrato," _
                                 & " pro_nroCuenta,pro_serieCuenta, pro_FechaD,pro_FechaH,pro_TrabajoR,pro_FechaR,pro_PresInsp,pro_FechaP," _
                                    & "  pro_status, nroDoc,pro_NroFactura) values (  '" & id & "', " _
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
                                       & " '" & Sector(pro_Sector) & "', " _
                                       & " '" & nroDoc & "'," _
                                       & " '" & pro_NroFacturas & "')")

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

    Private Sub chk18_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If chk18.Checked = True Then
            cmb18.Enabled = True
        Else
            cmb18.Enabled = False
        End If
    End Sub

    Private Sub chk19_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If chk19.Checked = True Then
            cmb19.Enabled = True
        Else
            cmb19.Enabled = False
        End If
    End Sub

    Private Sub cmb18_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CADENA = cmb18.SelectedItem
        llenarVector()

        datosPpalProy(18) = Fk + 1
        datosPpalProy1(18) = Fj
    End Sub

    Private Sub cmb19_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CADENA = cmb19.SelectedItem
        llenarVector()

        datosPpalProy(19) = Fk + 1
        datosPpalProy1(19) = Fj
    End Sub

    Private Sub lblClas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub lblPre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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
                    importarDatosPpalProyCompl()
                    

                    If errorimp = 0 Then
                        ConexionSQL()
                        cntSQL.Execute("exec p_InsertaDatosproyectoppal '" & nroDoc & "'")
                        ConexionSQL()
                        cntSQL.Execute("exec p_InsertaDatosproyectoppal_Compl '" & nroDoc & "'")
                       
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
            MsgBox("Error al Importar Datos" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
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

    Private Sub chk5_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk5.CheckedChanged
        If chk5.Checked = True Then
            cmb5.Enabled = True
        Else
            cmb5.Enabled = False
            datosPpalProy(5) = ""
            datosPpalProy1(5) = ""
        End If
    End Sub

    Private Sub chk6_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk6.CheckedChanged
        If chk6.Checked = True Then
            cmb6.Enabled = True
        Else
            cmb6.Enabled = False
            datosPpalProy(6) = ""
            datosPpalProy1(6) = ""
        End If
    End Sub

    Private Sub chk7_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk7.CheckedChanged
        If chk7.Checked = True Then
            cmb7.Enabled = True
        Else
            cmb7.Enabled = False
            datosPpalProy(7) = ""
            datosPpalProy1(7) = ""
        End If
    End Sub

    Private Sub chk8_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk8.CheckedChanged
        If chk8.Checked = True Then
            cmb8.Enabled = True
           
        Else
            cmb8.Enabled = False
            datosPpalProy(8) = ""
            datosPpalProy1(8) = ""
        End If
    End Sub

    Private Sub chk9_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk9.CheckedChanged
        If chk9.Checked = True Then
            cmb9.Enabled = True
        Else
            cmb9.Enabled = False
            datosPpalProy(9) = ""
            datosPpalProy1(9) = ""
        End If
    End Sub

    Private Sub chk10_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk10.CheckedChanged
        If chk10.Checked = True Then
            cmb10.Enabled = True

        Else
            datosPpalProy(10) = ""
            datosPpalProy1(10) = ""
            cmb10.Enabled = False
        End If
    End Sub

    Private Sub chk11_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk11.CheckedChanged
        If chk11.Checked = True Then
            cmb11.Enabled = True
        Else
            datosPpalProy(11) = ""
            datosPpalProy1(11) = ""
            cmb11.Enabled = False
        End If
    End Sub

    Private Sub chk12_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk12.CheckedChanged
        If chk12.Checked = True Then
            cmb12.Enabled = True
        Else
            datosPpalProy(12) = ""
            datosPpalProy1(12) = ""
            cmb12.Enabled = False
        End If
    End Sub

    Private Sub chk13_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk13.CheckedChanged
        If chk13.Checked = True Then
            cmb13.Enabled = True
        Else
            datosPpalProy(13) = ""
            datosPpalProy1(13) = ""
            cmb13.Enabled = False
        End If
    End Sub

    Private Sub chk14_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk14.CheckedChanged
        If chk14.Checked = True Then
            cmb14.Enabled = True
        Else
            datosPpalProy(14) = ""
            datosPpalProy1(14) = ""
            cmb14.Enabled = False
        End If
    End Sub

    Private Sub chk15_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk15.CheckedChanged
        If chk15.Checked = True Then
            cmb15.Enabled = True
        Else
            datosPpalProy(15) = ""
            datosPpalProy1(15) = ""
            cmb15.Enabled = False
        End If
    End Sub

    Private Sub chk16_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk16.CheckedChanged
        If chk16.Checked = True Then
            cmb16.Enabled = True
        Else
            datosPpalProy(16) = ""
            datosPpalProy1(16) = ""
            cmb16.Enabled = False
        End If
    End Sub

    Private Sub chk17_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk17.CheckedChanged
        If chk17.Checked = True Then
            cmb17.Enabled = True
        Else
            datosPpalProy(17) = ""
            datosPpalProy1(17) = ""
            cmb17.Enabled = False
        End If
    End Sub

    Private Sub chk18_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk18.CheckedChanged
        If chk18.Checked = True Then
            cmb18.Enabled = True
        Else
            datosPpalProy(18) = ""
            datosPpalProy1(18) = ""
            cmb18.Enabled = False
        End If
    End Sub

    Private Sub chk19_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk19.CheckedChanged
        If chk19.Checked = True Then
            cmb19.Enabled = True
        Else
            datosPpalProy(19) = ""
            datosPpalProy1(19) = ""
            cmb19.Enabled = False
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

    Private Sub cmb5_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb5.SelectedIndexChanged
        Fk = 0
        CADENA = cmb5.SelectedItem
        llenarVector()
        Fk = IIf(cmb5.SelectedIndex = -1, 1, cmb5.SelectedIndex + 1)
        datosPpalProy(5) = Fk & ".V"
        datosPpalProy1(5) = Fj & ".V"

    End Sub

    Private Sub cmb6_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb6.SelectedIndexChanged
        Fk = 0
        CADENA = cmb6.SelectedItem
        llenarVector()
        Fk = IIf(cmb6.SelectedIndex = -1, 1, cmb6.SelectedIndex + 1)
        datosPpalProy(6) = Fk & ".M"
        datosPpalProy1(6) = Fj & ".M"
    End Sub

    Private Sub cmb7_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb7.SelectedIndexChanged
        Fk = 0
        CADENA = cmb7.SelectedItem
        llenarVector()

        Fk = IIf(cmb7.SelectedIndex = -1, 1, cmb7.SelectedIndex + 1)
        datosPpalProy(7) = Fk & ".V"
        datosPpalProy1(7) = Fj & ".V"
    End Sub

    Private Sub cmb8_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb8.SelectedIndexChanged
        Fk = 0
        CADENA = cmb8.SelectedItem
        llenarVector()


        Fk = IIf(cmb8.SelectedIndex = -1, 1, cmb8.SelectedIndex + 1)
        datosPpalProy(8) = Fk & ".F"
        datosPpalProy1(8) = Fj & ".F"
    End Sub

    Private Sub cmb9_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb9.SelectedIndexChanged
        Fk = 0
        CADENA = cmb9.SelectedItem
        llenarVector()
        ' llenarVectorfecha()
        Fk = IIf(cmb9.SelectedIndex = -1, 1, cmb9.SelectedIndex + 1)

        datosPpalProy(9) = Fk & ".F"
        datosPpalProy1(9) = Fj & ".F"

    End Sub

    Private Sub cmb10_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb10.SelectedIndexChanged
        Fk = 0
        CADENA = cmb10.SelectedItem
        llenarVector()

        Fk = IIf(cmb10.SelectedIndex = -1, 1, cmb10.SelectedIndex + 1)
        datosPpalProy(10) = Fk & ".M"
        datosPpalProy1(10) = Fj & ".M"
    End Sub

    Private Sub cmb11_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb11.SelectedIndexChanged
        Fk = 0
        CADENA = cmb11.SelectedItem
        llenarVector()
        llenarVectorfecha()
        Fk = IIf(cmb11.SelectedIndex = -1, 1, cmb11.SelectedIndex + 1)
        datosPpalProy(11) = Fk & ".F"
        datosPpalProy1(11) = Fj & ".F"
    End Sub

    Private Sub cmb12_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb12.SelectedIndexChanged
        Fk = 0
        CADENA = cmb12.SelectedItem
        llenarVector()
        Fk = IIf(cmb12.SelectedIndex = -1, 1, cmb12.SelectedIndex + 1)
        datosPpalProy(12) = Fk & ".V"
        datosPpalProy1(12) = Fj & ".V"
    End Sub

    Private Sub cmb13_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb13.SelectedIndexChanged
        Fk = 0
        CADENA = cmb13.SelectedItem
        llenarVector()
        llenarVectorfecha()
        Fk = IIf(cmb13.SelectedIndex = -1, 1, cmb13.SelectedIndex + 1)
        datosPpalProy(13) = Fk & ".F"
        datosPpalProy1(13) = Fj & ".F"
    End Sub

    Private Sub cmb14_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb14.SelectedIndexChanged
        Fk = 0
        CADENA = cmb14.SelectedItem
        llenarVector()

        Fk = IIf(cmb14.SelectedIndex = -1, 1, cmb14.SelectedIndex + 1)
        datosPpalProy(14) = Fk & ".E"
        datosPpalProy1(14) = Fj & ".E"
    End Sub

    Private Sub cmb15_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb15.SelectedIndexChanged
        Fk = 0
        CADENA = cmb15.SelectedItem
        llenarVector()

        Fk = IIf(cmb15.SelectedIndex = -1, 1, cmb15.SelectedIndex + 1)
        datosPpalProy(15) = Fk & ".E"
        datosPpalProy1(15) = Fj & ".E"
    End Sub

    Private Sub cmb16_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb16.SelectedIndexChanged
        Fk = 0
        CADENA = cmb16.SelectedItem
        llenarVector()

        Fk = IIf(cmb16.SelectedIndex = -1, 1, cmb16.SelectedIndex + 1)
        datosPpalProy(16) = Fk & ".F"
        datosPpalProy1(16) = Fj & ".F"
    End Sub

    Private Sub cmb17_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb17.SelectedIndexChanged
        Fk = 0
        CADENA = cmb17.SelectedItem
        llenarVector()
        llenarVectorfecha()
        Fk = IIf(cmb17.SelectedIndex = -1, 1, cmb17.SelectedIndex + 1)
        datosPpalProy(17) = Fk & ".F"
        datosPpalProy1(17) = Fj & ".F"
    End Sub

    Private Sub cmb18_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb18.SelectedIndexChanged
        Fk = 0
        CADENA = cmb18.SelectedItem
        llenarVector()
        Fk = IIf(cmb18.SelectedIndex = -1, 1, cmb18.SelectedIndex + 1)
        datosPpalProy(18) = Fk & ".V"
        datosPpalProy1(18) = Fj & ".V"
    End Sub

    Private Sub cmb19_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb19.SelectedIndexChanged
        Fk = 0
        CADENA = cmb19.SelectedItem
        llenarVector()
        Fk = IIf(cmb19.SelectedIndex = -1, 1, cmb19.SelectedIndex + 1)
        datosPpalProy(19) = Fk & ".V"
        datosPpalProy1(19) = Fj & ".V"
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




    Private Sub cmb20_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb20.SelectedIndexChanged
        Fk = 0
        CADENA = cmb20.SelectedItem
        llenarVector()
        Fk = IIf(cmb20.SelectedIndex = -1, 1, cmb20.SelectedIndex + 1)
        datosPpalProy(20) = Fk & ".V"
        datosPpalProy1(20) = Fj & ".V"
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
End Class
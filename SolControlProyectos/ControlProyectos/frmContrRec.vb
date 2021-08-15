Public Class frmContrRec
    Public seleccionado As String = ""
    Public cantCont As Integer = 0

    Private Sub frmContrRec_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CtaNro = 0
        RecNro = ""
        FactNro = ""

        cantidadNroContrProy()
        'llenarCmbCont()
    End Sub
    Sub llenarCmbCont()
        Try
            ConexionSQL()
            Dim strDatos As New ADODB.Recordset
            Dim i As Integer = 0
            Me.ltvwRec.Items.Clear()

            strDatos = cntSQL.Execute("select [cta_Nro], [id_proyecto] ,[nro_proyecto] ,[nro_contrato],[nro_recibo], [nro_Factura] FROM [dbo].[tab_NrosReciboProy] where [id_proyecto]= " & stridProy & "")

            Do While Not strDatos.EOF

                Me.ltvwRec.Items.Add(strDatos.Fields("cta_Nro").Value)
                Me.ltvwRec.Items(i).SubItems.Add(strDatos.Fields("nro_proyecto").Value)
                Me.ltvwRec.Items(i).SubItems.Add(strDatos.Fields("nro_contrato").Value)
                Me.ltvwRec.Items(i).SubItems.Add(strDatos.Fields("nro_recibo").Value)
                Me.ltvwRec.Items(i).SubItems.Add(strDatos.Fields("nro_Factura").Value)
                Me.ltvwRec.Items(i).SubItems.Add(strDatos.Fields("id_proyecto").Value)


                i += 1
                strDatos.MoveNext()
            Loop

        Catch ex As Exception
            MsgBox("Error en buscar Nro de Contrato" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub

    Sub llenarCmbContPpal()
        Try
            ConexionSQL()
            Dim strDatos As New ADODB.Recordset
            Dim i As Integer = 0
            Me.ltvwRec.Items.Clear()

            strDatos = cntSQL.Execute("select [cta_Nro], [id_proyecto] ,[nro_proyecto] ,[nro_contrato],[nro_recibo], [nro_Factura] FROM [dbo].[tab_NrosReciboProy] where [id_proyecto]= " & stridProy & "")

            Do While Not strDatos.EOF

                CtaNro = 1
                ProyNro = strDatos.Fields("nro_proyecto").Value
                ContNro = strDatos.Fields("nro_contrato").Value
                i += 1
                strDatos.MoveNext()
            Loop

        Catch ex As Exception
            MsgBox("Error en buscar Nro de Contrato" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub

    Sub cantidadNroContrProy()
        Try
            ConexionSQL()
            Dim strDatos As New ADODB.Recordset
            Dim i As Integer = 0
            Me.ltvwRec.Items.Clear()

            strDatos = cntSQL.Execute("select count(distinct nro_contrato) as cantidad FROM [dbo].[tab_NrosReciboProy] where [id_proyecto]= " & stridProy & "")

            Do While Not strDatos.EOF
                cantCont = Val(IIf(strDatos.Fields("cantidad").Value Is DBNull.Value, 0, strDatos.Fields("cantidad").Value))

                i += 1
                strDatos.MoveNext()
            Loop

            If cantCont > 1 Then
                llenarCmbCont()

            Else
                llenarCmbContPpal()
                If swMenuPpal = 0 Then

                    f1.tbxNroCon.Text = ContNro
                    '  f1.txtCuenta.Text = CtaNro
                    f1.tbxNroFac.Text = FactNro
                    f1.tbxNroReci.Text = RecNro

                End If


                If swMenuPpal = 1 Then

                    f15.tbxNroFac.Text = FactNro
                    f15.tbxNroReci.Text = RecNro
                    'llenarFactf15()

                End If
                If swMenuPpal = 2 Then


                    f7.tbxNroCon.Text = ContNro
                    ' f7.txtCuenta.Text = CtaNro
                    'f7.tbxNroFac.Text = FactNro
                    'f7.tbxNroReci.Text = RecNro


                End If
                Me.Close()


                'Me.btnAcep_Click(1, Nothing)
            End If


        Catch ex As Exception
            MsgBox("Error en buscar Nro de Contrato" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub

    Private Sub ltvwRec_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ltvwRec.DoubleClick

        If Me.ltvwRec.Items.Count > 0 Then

            For i = 0 To Me.ltvwRec.Items.Count - 1
                If Me.ltvwRec.Items(i).Selected = True Then
                    CtaNro = Me.ltvwRec.FocusedItem.Text
                    ProyNro = Me.ltvwRec.FocusedItem.SubItems(1).Text
                    ContNro = Me.ltvwRec.FocusedItem.SubItems(2).Text
                    RecNro = Me.ltvwRec.FocusedItem.SubItems(3).Text
                    FactNro = Me.ltvwRec.FocusedItem.SubItems(4).Text
                    seleccionado = Me.ltvwRec.FocusedItem.SubItems(1).Text
                End If
            Next

        End If

        If seleccionado <> "" Then
            If swMenuPpal = 0 Then
                f1.tbxNroCon.Text = ContNro
                '  f1.txtCuenta.Text = CtaNro
                f1.tbxNroFac.Text = FactNro
                f1.tbxNroReci.Text = RecNro
            End If

            If swMenuPpal = 2 Then
                f7.tbxNroCon.Text = ContNro
                '   f7.txtCuenta.Text = CtaNro
                'f7.tbxNroFac.Text = FactNro
                'f7.tbxNroReci.Text = RecNro
            End If

            If swMenuPpal = 1 Then
                'f15.tbxNroCon.Text = ContNro
                'f15.txtCuenta.Text = CtaNro
                f15.tbxNroFac.Text = FactNro
                f15.tbxNroReci.Text = RecNro
            End If

            Me.Close()
        Else

            MsgBox("Debe Seleccionar Una Opcion ", MsgBoxStyle.Information, "Control de Proyectos")
        End If

        seleccionado = ""
    End Sub
    Sub consultaProyDppal()
        Try
            Dim strPpal As New ADODB.Recordset



            strPpal = cntSQL.Execute("select * from tab_DatosPpalProy where pro_nroContrato='" & ContNro & "' and  pro_idProyecto='" & stridProy & "'")


            Do While Not strPpal.EOF

                f1.tbxNroCon.Text = strPpal.Fields("pro_nroContrato").Value
                f1.tbxUbi.Text = strPpal.Fields("pro_Provincia").Value
                f1.cmbClas.SelectedItem = buscaComboSector(strPpal.Fields("pro_Sector").Value)
                f1.txtMonto.Text = decimales(Math.Round(strPpal.Fields("pro_monto").Value, 2))
                'f1.txtCuenta.Text = CtaNro 'strPpal.Fields("pro_nroCuenta").Value
                'f1.dtpFd.Value = strPpal.Fields("pro_FechaD").Value
                'f1.dtpFH.Value = strPpal.Fields("pro_FechaH").Value
                'f1.tbxTraR.Text = decimales(Math.Round(strPpal.Fields("pro_TrabajoR").Value, 2))
                'f1.dtpFechaR.Value = strPpal.Fields("pro_FechaR").Value
                'f1.txtInsp.Text = decimales(Math.Round(strPpal.Fields("pro_PresInsp").Value, 2))
                'f1.dtpPIns.Value = strPpal.Fields("pro_FechaP").Value

                'f1.cmbperPagCtas.SelectedIndex = IIf(strPpal.Fields("pro_periodoCuenta").Value Is DBNull.Value, 0, strPpal.Fields("pro_periodoCuenta").Value)

                'f1.txtDur.Text = strPpal.Fields("pro_duracionProy").Value
                'f1.dtpFechai.Value = strPpal.Fields("pro_FechaInicio").Value
                'f1.dtpFfOp.Value = strPpal.Fields("pro_FechaFinOrig").Value
                'f1.cmbxSta.SelectedIndex = IIf(strPpal.Fields("pro_status").Value = "", 0, strPpal.Fields("pro_status").Value)
                'guardaComboTipo(f1.cmbTipo.SelectedItem)  = IIf(strPpal.Fields("pro_tipo").Value = "", 0, strPpal.Fields("pro_tipo").Value)

                Exit Do


            Loop

        Catch ex As Exception
            MsgBox("Error en funcion consultaProyDppal()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try

    End Sub
    Sub consultaProyDppalf7()
        Try
            Dim strPpal As New ADODB.Recordset



            strPpal = cntSQL.Execute("select * from tab_DatosPpalProy where pro_nroContrato='" & ContNro & "' and  pro_idProyecto='" & stridProy & "'")


            Do While Not strPpal.EOF

                f7.tbxCodp.Text = strPpal.Fields("pro_nroProyecto").Value
                f7.tbxDescr.Text = strPpal.Fields("pro_descripcion").Value

                f7.cmbClas.SelectedItem = buscaComboSector(strPpal.Fields("pro_Sector").Value)

                f7.tbxNroCon.Text = strPpal.Fields("pro_nroContrato").Value
                f7.tbxUbi.Text = strPpal.Fields("pro_Provincia").Value

                f7.txtMonto.Text = decimales(Math.Round(IIf(strPpal.Fields("pro_monto").Value Is DBNull.Value, 0, strPpal.Fields("pro_monto").Value), 2))
                intMontoProy = decimales(Math.Round(IIf(strPpal.Fields("pro_monto").Value Is DBNull.Value, 0, strPpal.Fields("pro_monto").Value), 2))
                f7.tbxAdendas.Text = decimales(Math.Round(IIf(strPpal.Fields("pro_Adendasmonto").Value Is DBNull.Value, 0, strPpal.Fields("pro_Adendasmonto").Value), 2))
                f7.txtItbAd.Text = decimales(Math.Round(IIf(strPpal.Fields("pro_AdendasmontoITBMS").Value Is DBNull.Value, 0, strPpal.Fields("pro_AdendasmontoITBMS").Value), 2))
                f7.txtItbContAd.Text = decimales(Math.Round(IIf(strPpal.Fields("pro_AdendasContITBMS").Value Is DBNull.Value, 0, strPpal.Fields("pro_AdendasmontoITBMS").Value), 2))
                f7.txtAdT.Text = decimales(Math.Round(IIf(strPpal.Fields("pro_AdendasTiempo").Value Is DBNull.Value, 0, strPpal.Fields("pro_AdendasTiempo").Value), 2))
                f7.txtDurOri.Text = decimales(Math.Round(IIf(strPpal.Fields("pro_duracionOriginalCont").Value Is DBNull.Value, 0, strPpal.Fields("pro_duracionOriginalCont").Value), 2))
                f7.txtDurCont.Text = decimales(Math.Round(IIf(strPpal.Fields("pro_duracionCont").Value Is DBNull.Value, 0, strPpal.Fields("pro_duracionCont").Value), 2))
                f7.dtpOriF.Value = IIf(strPpal.Fields("pro_FechaOrg").Value Is DBNull.Value, "1900-01-01", strPpal.Fields("pro_FechaOrg").Value)
                dtFechaOrig = IIf(strPpal.Fields("pro_FechaOrg").Value Is DBNull.Value, "1900-01-01", strPpal.Fields("pro_FechaOrg").Value)
                f7.dtpFecI.Value = IIf(strPpal.Fields("pro_FechaD").Value Is DBNull.Value, "1900-01-01", strPpal.Fields("pro_FechaD").Value)
                f7.dtpFecF.Value = IIf(strPpal.Fields("pro_FechaH").Value Is DBNull.Value, "1900-01-01", strPpal.Fields("pro_FechaH").Value)
                f7.cmbSt.SelectedItem = buscaComboStatus(IIf(strPpal.Fields("pro_status").Value Is DBNull.Value, 0, strPpal.Fields("pro_status").Value))
                f7.cmbTp.SelectedItem = buscaComboTipo(IIf(strPpal.Fields("pro_tipo").Value Is DBNull.Value, 0, strPpal.Fields("pro_tipo").Value))
                f7.tbxCreditos.Text = IIf(strPpal.Fields("pro_diasCredito").Value Is DBNull.Value, 0, strPpal.Fields("pro_diasCredito").Value)

                Exit Do


            Loop

        Catch ex As Exception
            MsgBox("Error en funcion consultaProyDppalf7()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try

    End Sub

    Sub consultaProyDppalf15()
        Try
            Dim strPpal As New ADODB.Recordset

            ConexionSQL()

            strPpal = cntSQL.Execute("select * from tab_DatosPpalProy where pro_nroContrato='" & ContNro & "' and  pro_idProyecto='" & stridProy & "'")


            'Do While Not strPpal.EOF

            '    f15.tbxNroCon.Text = strPpal.Fields("pro_nroContrato").Value
            '    f15.tbxUbi.Text = strPpal.Fields("pro_Provincia").Value
            '    f15.cmbClas.SelectedIndex = IIf(strPpal.Fields("pro_Sector").Value = "", 0, strPpal.Fields("pro_Sector").Value)
            '    f15.txtMonto.Text = decimales(Math.Round(strPpal.Fields("pro_monto").Value, 2))
            '    f15.txtCuenta.Text = CtaNro 'strPpal.Fields("pro_nroCuenta").Value
            '    f15.dtpFd.Value = strPpal.Fields("pro_FechaD").Value
            '    f15.dtpFH.Value = strPpal.Fields("pro_FechaH").Value
            '    f15.tbxTraR.Text = decimales(Math.Round(strPpal.Fields("pro_TrabajoR").Value, 2))
            '    f15.dtpFechaR.Value = strPpal.Fields("pro_FechaR").Value
            '    f15.txtInsp.Text = decimales(Math.Round(strPpal.Fields("pro_PresInsp").Value, 2))
            '    f15.dtpPIns.Value = strPpal.Fields("pro_FechaP").Value
            '    f15.txtPercta.Text = strPpal.Fields("pro_periodoCuenta").Value
            '    f15.txtDur.Text = strPpal.Fields("pro_duracionProy").Value
            '    f15.dtpFechai.Value = strPpal.Fields("pro_FechaInicio").Value
            '    f15.dtpFfOp.Value = strPpal.Fields("pro_FechaFinOrig").Value
            '    f15.cmbxSta.SelectedIndex = IIf(strPpal.Fields("pro_status").Value = "", 0, strPpal.Fields("pro_status").Value)
            '    f15.cmbTipo.SelectedIndex = IIf(strPpal.Fields("pro_tipo").Value = "", 0, strPpal.Fields("pro_tipo").Value)
            '    llenarFactf15()
            '    Exit Do


            'Loop

        Catch ex As Exception
            MsgBox("Error en funcion consultaProyDppalf15()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try

    End Sub
    Sub consultaProyDppalf16()
        Try
            Dim strPpal As New ADODB.Recordset



            strPpal = cntSQL.Execute("select * from tab_Aux_EstCtasProy where [pro_NroProyecto]='" & ProyNro & "' and  [pro_idProyecto]='" & stridProy & "'")

           
            Do While Not strPpal.EOF

                ' f16.tbxCta.Text = 1
                f16.tbxNrP.Text = strPpal.Fields("pro_NroProyecto").Value
                f16.tbxDescP.Text = strDescProy
                'f16.tbxPerCta.Text = decimales(Math.Round(strPpal.Fields("pro_PerCtas").Value, 2))
                'f16.dtpFecEntra.Value = strPpal.Fields("pro_FechaEntScont").Value
                'f16.tbxMeta.Text = decimales(Math.Round(strPpal.Fields("pro_Meta").Value, 2))
                'f16.tbxMeta1.Text = decimales(Math.Round(strPpal.Fields("pro_Meta1").Value, 2))
                'f16.tbxMetFac.Text = decimales(Math.Round(strPpal.Fields("pro_MetaFact").Value, 2))
                'f16.tbxCump.Text = decimales(Math.Round(strPpal.Fields("pro_porcCump").Value, 2))
                'f16.dtpFechaEn.Value = strPpal.Fields("pro_FechaEntInsp").Value
                'f16.tbxMont.Text = decimales(Math.Round(strPpal.Fields("pro_MontoCtasInsp").Value, 2))
                'f16.dtpFecEncxc.Value = strPpal.Fields("pro_FechaCxc").Value
                'f16.tbxMontoAp.Text = decimales(Math.Round(strPpal.Fields("pro_MontoAproInsp").Value, 2))

                strPpal.MoveNext()


            Loop


            f16.llenarFactestCtas()

        Catch ex As Exception
            MsgBox("Error en funcion consultaProyDppalf7()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try

    End Sub

   
   
    Private Sub btnRec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        RecNro = InputBox("Ingrese el Nro de Recibo", "Control de Proyectos")

        Do While Not RecNro <> ""

            If RecNro = "" Then
                MsgBox("Debe insertar un valor", vbCritical)
                RecNro = InputBox("Ingrese el Nro de Recibo", "Control de Proyectos")

            Else
                Exit Do
            End If

        Loop

        If swMenuPpal = 0 Then
            FactNro = f1.tbxNroFac.Text
            RecNro = f1.tbxNroReci.Text
            ContNro = f1.tbxNroCon.Text
            ProyNro = f1.tbxCodp.Text
        End If

        If swMenuPpal = 2 Then
            'FactNro = f7.tbxNroFac.Text
            'RecNro = f7.tbxNroReci.Text
            ContNro = f7.tbxNroCon.Text
            ProyNro = f7.tbxCodp.Text
        End If

        If swMenuPpal = 1 Then
            FactNro = f15.tbxNroFac.Text
            RecNro = f15.tbxNroReci.Text
            'ContNro = f15.tbxNroCon.Text
            'ProyNro = f15.tbxCodp.Text
        End If


        If RecNro <> "" Then

            If swMenuPpal = 0 Then
                insertNroRec(f1.lblid.Text, f1.tbxCodp.Text, f1.tbxNroCon.Text, f1.tbxNroReci.Text, f1.tbxNroFac.Text)
                guardaActProyeDFact()
                guardaActProyeDCostos()

            End If



            If swMenuPpal = 1 Then
                'insertNroRec(f15.lblid.Text, f15.tbxCodp.Text, f15.tbxNroCon.Text, f15.tbxNroReci.Text, f15.tbxNroFac.Text)
                guardaActProyeDFact15()
                guardaActProyeDCostos15()

            End If




        End If

    End Sub

    Private Sub btnCanc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCanc.Click
        Me.Close()
        swMenuPpal = 3
        CtaNro = 0
        ProyNro = ""
        ContNro = ""
        RecNro = ""
        FactNro = ""
        idProy = 0

    End Sub

    Private Sub btnAcep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAcep.Click


        If Me.ltvwRec.Items.Count > 0 Then

            For i = 0 To Me.ltvwRec.Items.Count - 1

                If Me.ltvwRec.Items(i).Selected = True Then
                    CtaNro = Me.ltvwRec.FocusedItem.Text
                    ProyNro = Me.ltvwRec.FocusedItem.SubItems(1).Text
                    ContNro = Me.ltvwRec.FocusedItem.SubItems(2).Text
                    RecNro = Me.ltvwRec.FocusedItem.SubItems(3).Text
                    FactNro = Me.ltvwRec.FocusedItem.SubItems(4).Text
                    idProy = Me.ltvwRec.FocusedItem.SubItems(5).Text
                    seleccionado = Me.ltvwRec.FocusedItem.SubItems(1).Text
                End If

              
            Next

        End If


        If seleccionado <> "" Then
            If swMenuPpal = 0 Then

                f1.tbxNroCon.Text = ContNro
                ' f1.txtCuenta.Text = CtaNro
                f1.tbxNroFac.Text = FactNro
                f1.tbxNroReci.Text = RecNro

            End If


            If swMenuPpal = 1 Then

                f15.tbxNroFac.Text = FactNro
                f15.tbxNroReci.Text = RecNro
                '  llenarFactf15()

            End If
            If swMenuPpal = 2 Then


                f7.tbxNroCon.Text = ContNro
                '  f7.txtCuenta.Text = CtaNro
                'f7.tbxNroFac.Text = FactNro
                'f7.tbxNroReci.Text = RecNro


            End If
            Me.Close()
        Else

            MsgBox("Debe Seleccionar Una Opcion ", MsgBoxStyle.Information, "Control de Proyectos")
        End If

        seleccionado = ""
    End Sub

    Private Sub btnCont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCont.Click
        Try

            If swMenuPpal = 0 Then
                FactNro = f1.tbxNroFac.Text
                RecNro = f1.tbxNroReci.Text
                ContNro = f1.tbxNroCon.Text
                ProyNro = f1.tbxCodp.Text
            End If


            If swMenuPpal = 1 Then
                FactNro = f15.tbxNroFac.Text
                RecNro = f15.tbxNroReci.Text
                'ContNro = f15.tbxNroCon.Text
                'ProyNro = f15.tbxCodp.Text
            End If



            Dim preg As String = ""
            ContNro = InputBox("Ingrese el Nro de Contrato", "Control de Proyectos")

            Do While Not ContNro <> ""

                If ContNro = "" Then
                    MsgBox("Debe insertar un valor", vbCritical)
                    ContNro = InputBox("Ingrese el Nro de Contrato", "Control de Proyectos")

                Else
                    Exit Do
                End If

            Loop

            If ContNro <> "" Then

                preg = MsgBox("Nuevo Nro de Contrato para Proyecto " & ProyNro, MsgBoxStyle.YesNo, "Control de Proyectos")



                If preg = 6 Then
                    clearFormularios1()

                    If swMenuPpal = 0 Then
                        insertNroCont1(f1.lblid.Text, f1.tbxCodp.Text, ContNro, "", "")
                        f1.tbxNroCon.Text = ContNro
                        guardaActProyeDFact()
                        guardaActProyeDCostos()
                    End If


                    If swMenuPpal = 1 Then
                        'insertNroCont1(f15.lblid.Text, f15.tbxCodp.Text, ContNro, "", "")
                        'f15.tbxNroCon.Text = ContNro
                        guardaActProyeDFact15()
                        guardaActProyeDCostos15()
                    End If



                End If

            End If



            llenarCmbCont()

        Catch ex As Exception
            MsgBox("Error en boton btnCont_Click", MsgBoxStyle.Critical, "Control Proyectos")
        End Try

    End Sub
    Public Function insertNroCont1(ByVal id As Decimal, ByVal NroProy As Double, ByVal NroCont As String, ByVal Rec As String, ByVal Fact As String)
        ConexionSQL()
        Dim sw As Integer = 0
        Try
            Dim strNro As New ADODB.Recordset
            Dim ctaNro As Integer = 1
            Dim i As Integer = 1
            Dim preg As String = ""
            'si no existe los datos del nro proyecto y el nro de contrato
            Dim strcta As New ADODB.Recordset

            strNro = cntSQL.Execute("SELECT cta_Nro, [id_proyecto] ,[nro_proyecto] ,[nro_contrato],[nro_recibo],[nro_Factura] FROM [dbo].[tab_NrosReciboProy] where [nro_proyecto] ='" & NroProy & "' and [nro_contrato]='" & NroCont & "' ")


            If strNro.EOF = True Then

                preg = MsgBox("Nuevo Nro de Contrato, desea Insertar ??? ", MsgBoxStyle.YesNo)

                If preg = 6 Then
                    strcta = cntSQL.Execute("SELECT max(cta_Nro) as cta_Nro FROM [dbo].[tab_NrosReciboProy] where [nro_proyecto] ='" & NroProy & "' and [nro_contrato]='" & NroCont & "' ")

                    If strcta.EOF = False Then
                        i = i + Val(IIf(strcta.Fields("cta_Nro").Value Is DBNull.Value, 0, strcta.Fields("cta_Nro").Value))
                    End If

                    cntSQL.Execute("insert into [tab_NrosReciboProy](cta_Nro,[id_proyecto] ,[nro_proyecto] ,[nro_contrato],[nro_recibo],[nro_Factura]) values (" & i & "," & id & ", '" & NroProy & "', '" & NroCont & "','" & Rec & "', '" & Fact & "')")
                    RecNro = Rec
                End If
                ctaNro = i
                swc = 1
            Else
                MsgBox("Número de Contrato ya Existe", MsgBoxStyle.Critical, "Control Proyectos")
            End If

        Catch ex As Exception
            MsgBox("Error en funcion insertNroCont" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try


        Return idProy

    End Function

    Private Sub btnFact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFact.Click

        If ContNro <> "" Then

            '  frmInputSerie.ShowDialog()

            If swInput = 0 Then
                If swMenuPpal = 0 Then
                    'ContNro = f1.tbxNroCon.Text
                    ProyNro = f1.tbxCodp.Text
                End If

                If swMenuPpal = 1 Then
                    'ContNro = f15.tbxNroCon.Text
                    'ProyNro = f15.tbxCodp.Text
                End If


                If FactNro <> "" Then
                    If swMenuPpal = 0 Then
                        insertNroFact(f1.lblid.Text, ProyNro, ContNro, RecNro, FactNro)

                        guardaActProyeDFact()
                        guardaActProyeDCostos()
                    End If

                    If swMenuPpal = 1 Then
                        'insertNroFact(f15.lblid.Text, ProyNro, ContNro, RecNro, FactNro)

                        guardaActProyeDFact15()
                        guardaActProyeDCostos15()
                    End If
                End If

            End If
        Else
            MsgBox("Debe seleccionar un item de la lista", vbCritical, "Control de Proyectos")
        End If
        llenarCmbCont()
    End Sub



    Private Sub ltvwRec_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ltvwRec.SelectedIndexChanged

        If Me.ltvwRec.Items.Count > 0 Then

            For i = 0 To Me.ltvwRec.Items.Count - 1

                If Me.ltvwRec.Items(i).Selected = True Then

                    CtaNro = Me.ltvwRec.FocusedItem.Text
                    ProyNro = Me.ltvwRec.FocusedItem.SubItems(1).Text
                    ContNro = Me.ltvwRec.FocusedItem.SubItems(2).Text
                    RecNro = Me.ltvwRec.FocusedItem.SubItems(3).Text
                    FactNro = Me.ltvwRec.FocusedItem.SubItems(4).Text

                    Exit For
                End If
            Next

        End If


    End Sub
End Class
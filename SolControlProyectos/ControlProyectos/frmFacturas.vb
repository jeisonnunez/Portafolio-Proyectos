Public Class frmFacturas
    Public intManual As Integer = 0
    Private Sub frmFacturas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarFact()
    End Sub
    Sub llenarFact()
        Try
            ConexionSQL()
            Dim strDatos As New ADODB.Recordset
            Dim i As Integer = 0
            Me.ltwFact.Items.Clear()

            strDatos = cntSQL.Execute("select pro_NroContrato, pro_NroFactura,pro_NroRecibo, sum (pro_CuentaCobrar)as pro_CuentaCobrar, pro_manual from tab_Aux_FactProy where pro_NroContrato='" & ContNro & "' and pro_nroProyecto='" & ProyNro & "' group by pro_NroContrato, pro_NroFactura,pro_NroRecibo, pro_manual")

            Do While Not strDatos.EOF

                Me.ltwFact.Items.Add(ProyNro)
                Me.ltwFact.Items(i).SubItems.Add(strDatos.Fields("pro_NroContrato").Value)
                Me.ltwFact.Items(i).SubItems.Add(strDatos.Fields("pro_NroFactura").Value)
                Me.ltwFact.Items(i).SubItems.Add(strDatos.Fields("pro_NroRecibo").Value)
                Me.ltwFact.Items(i).SubItems.Add(decimales(strDatos.Fields("pro_CuentaCobrar").Value))
                Me.ltwFact.Items(i).SubItems.Add(strDatos.Fields("pro_manual").Value)
                i += 1
                strDatos.MoveNext()
            Loop

        Catch ex As Exception
            MsgBox("Error en buscar Nro de llenarFact()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

  
    'Private Sub ltwFact_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ltwFact.DoubleClick

    '    Me.Close()
    'End Sub

    Sub ConsultarALLFactproyF15()
        Try

            consultaProyFactDppalf15()
            ConsultasDEntesFactf15()
            ConsultasDFactf15()
            ConsultasDCostosf15()


        Catch ex As Exception
            MsgBox("Error en funcion  ConsultarALLFactproyF15()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub
  
    Sub ConsultarALLFactproyF7()
        Try

            consultaProyFactDppalf7()
            ConsultasDEntesFactf7()
            ConsultasDFactf7()
            ConsultasDCostosf7()


        Catch ex As Exception
            MsgBox("Error en funcion  ConsultarALLFactproyF15()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub


    Sub consultaProyFactDppalf15()
        Try
            ConexionSQL()
            Dim strPpal As New ADODB.Recordset

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

            '    Exit Do


            'Loop

        Catch ex As Exception
            MsgBox("Error en funcion consultaProyFactDppalf15()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try

    End Sub

    Sub consultaProyFactDppalf7()
        Try
            ConexionSQL()
            Dim strPpal As New ADODB.Recordset

            strPpal = cntSQL.Execute("select * from tab_DatosPpalProy where pro_nroContrato='" & ContNro & "' and  pro_idProyecto='" & stridProy & "'")


            Do While Not strPpal.EOF

                f7.tbxNroCon.Text = strPpal.Fields("pro_nroContrato").Value
                f7.tbxUbi.Text = strPpal.Fields("pro_Provincia").Value
                f7.cmbClas.SelectedItem = buscaComboSector(strPpal.Fields("pro_Sector").Value)
                f7.txtMonto.Text = decimales(Math.Round(strPpal.Fields("pro_monto").Value, 2))
                'f7.txtCuenta.Text = CtaNro 'strPpal.Fields("pro_nroCuenta").Value
                'f7.dtpFd.Value = strPpal.Fields("pro_FechaD").Value
                'f7.dtpFH.Value = strPpal.Fields("pro_FechaH").Value
                'f7.tbxTraR.Text = decimales(Math.Round(strPpal.Fields("pro_TrabajoR").Value, 2))
                'f7.dtpFechaR.Value = strPpal.Fields("pro_FechaR").Value
                'f7.txtInsp.Text = decimales(Math.Round(strPpal.Fields("pro_PresInsp").Value, 2))
                'f7.dtpPIns.Value = strPpal.Fields("pro_FechaP").Value
                'f7.cmbperPagCtas.SelectedItem = buscacmbperPagCtas(strPpal.Fields("pro_tipo").Value)
                'f7.txtDur.Text = strPpal.Fields("pro_duracionProy").Value
                'f7.dtpFechai.Value = strPpal.Fields("pro_FechaInicio").Value
                'f7.dtpFfOp.Value = strPpal.Fields("pro_FechaFinOrig").Value

                'f7.cmbxSta.SelectedItem = buscaComboStatus(strPpal.Fields("pro_status").Value)
                'f7.cmbTipo.SelectedItem = buscaComboTipo(strPpal.Fields("pro_tipo").Value)
                Exit Do


            Loop

        Catch ex As Exception
            MsgBox("Error en funcion consultaProyFactDppalf7())" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try

    End Sub

   

    Private Sub ltwFact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ltwFact.Click
        'If Me.ltwFact.Items.Count > 0 Then

        '    For i = 0 To Me.ltwFact.Items.Count - 1

        '        If Me.ltwFact.Items(i).Selected = True Then
        '            ProyNro = Me.ltwFact.FocusedItem.SubItems(0).Text
        '            ContNro = Me.ltwFact.FocusedItem.SubItems(1).Text
        '            RecNro = Me.ltwFact.FocusedItem.SubItems(3).Text
        '            FactNro = Me.ltwFact.FocusedItem.SubItems(2).Text
        '            Exit For
        '        End If
        '    Next

        'End If




        'If swMenuPpal = 2 Then
        '    f7.tbxNroCon.Text = ContNro
        '    f7.tbxNroFac.Text = FactNro
        '    f7.tbxNroReci.Text = RecNro
        '    ConsultarALLFactproyF7()

        'End If

        'If swMenuPpal = 1 Then
        '    'f15.tbxNroCon.Text = ContNro
        '    ' f15.txtCuenta.Text = CtaNro
        '    f15.tbxNroFac.Text = FactNro
        '    f15.tbxNroReci.Text = RecNro
        '    ConsultarALLFactproyF15()

        'End If

    End Sub



   

    Sub ConsultasDFactf25()
        Try
            ConexionSQL()
            Dim strDFact As New ADODB.Recordset

            strDFact = cntSQL.Execute("select DISTINCT pro_serieCuenta, pro_FechaEstimacion, tab_Aux_FactProy.pro_NroFactura, pro_FechaFact, pro_NroRecibo, pro_FechaRes, pro_trabajoFac, pro_Rete10, pro_MtoRete10, pro_Anticipo, " _
            & " pro_Penalizacion, pro_RETdeITBMS, pro_MontoITBMS, pro_CuentaCobrar, pro_EntrInsp, pro_FechaCliente, pro_FechaCxc, pro_FechaTes, pro_FechaPago  from tab_Aux_FactProy left outer join tab_DatosPpalProy_Compl " _
            & " on tab_Aux_FactProy.pro_idProyecto=tab_DatosPpalProy_Compl.pro_idProyecto" _
            & " and tab_DatosPpalProy_Compl.pro_NroFactura =tab_Aux_FactProy.pro_NroFactura" _
            & " and tab_DatosPpalProy_Compl.pro_nroContrato =tab_Aux_FactProy.pro_NroContrato " _
            & "  where tab_Aux_FactProy.pro_idProyecto='" & stridProy & "' and tab_Aux_FactProy.pro_NroContrato='" & ContNro & "' and tab_Aux_FactProy.pro_NroRecibo='" & RecNro & "' and tab_Aux_FactProy.pro_NroFactura='" & FactNro & "' and pro_manual=1")
           

            Do While Not strDFact.EOF

                f25.tbxNroFac.Text = strDFact.Fields("pro_NroFactura").Value
                f25.dtpFecFac.Value = strDFact.Fields("pro_FechaFact").Value
                f25.tbxNroReci.Text = strDFact.Fields("pro_NroRecibo").Value
                f25.dtpFecREC.Value = strDFact.Fields("pro_FechaRes").Value
                f25.tbxFac.Text = decimales(Math.Round(strDFact.Fields("pro_trabajoFac").Value, 2))

                f25.tbxMtoRet.Text = decimales(Math.Round(strDFact.Fields("pro_MtoRete10").Value, 2))
                f25.tbxAntMont.Text = decimales(Math.Round(strDFact.Fields("pro_Anticipo").Value, 2))
                f25.tbxPena.Text = decimales(Math.Round(strDFact.Fields("pro_Penalizacion").Value, 2))
                f25.tbxRetMtoITBMS.Text = decimales(Math.Round(strDFact.Fields("pro_RETdeITBMS").Value, 2))
                f25.tbxMtoITBMS.Text = decimales(Math.Round(strDFact.Fields("pro_MontoITBMS").Value, 2))
                f25.tbxCxC.Text = decimales(Math.Round(strDFact.Fields("pro_CuentaCobrar").Value, 2))

                f25.cmbEnInsp.SelectedIndex = strDFact.Fields("pro_EntrInsp").Value
                f25.dtpFecEnt.Value = strDFact.Fields("pro_FechaCliente").Value
                f25.dtpCXC.Value = strDFact.Fields("pro_FechaCxc").Value
                f25.dtpFecTe.Value = strDFact.Fields("pro_FechaTes").Value
                f25.dtpFecPago.Value = strDFact.Fields("pro_FechaPago").Value
                f25.cmbCtrlRec.SelectedIndex = IIf(strDFact.Fields("pro_NroRecibo").Value <> "", 0, 1)
                f25.dtpFecEs.Value = IIf(strDFact.Fields("pro_FechaEstimacion").Value Is DBNull.Value, "1900-01-01", strDFact.Fields("pro_FechaEstimacion").Value)
                ' f25.tbxMtoCheq.Text = decimales(Math.Round(strDFact.Fields("pro_montoCheque").Value, 2))
                Exit Do
                strDFact.MoveNext()
            Loop



        Catch ex As Exception
            MsgBox("Error en funcion ConsultasDFact" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub

    Private Sub ltwFact_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ltwFact.DoubleClick
        If Me.ltwFact.Items.Count > 0 Then

            For i = 0 To Me.ltwFact.Items.Count - 1

                If Me.ltwFact.Items(i).Selected = True Then
                    ProyNro = Me.ltwFact.FocusedItem.SubItems(0).Text
                    ContNro = Me.ltwFact.FocusedItem.SubItems(1).Text
                    FactNro = Me.ltwFact.FocusedItem.SubItems(2).Text
                    RecNro = Me.ltwFact.FocusedItem.SubItems(3).Text
                    intManual = Me.ltwFact.FocusedItem.SubItems(5).Text

                    If intManual = 1 Then
                        ConsultasDFactf25()
                        Me.Close()
                    Else
                        MsgBox("Solo se pueden modificar las facturas de forma Manual", MsgBoxStyle.Critical, "Control Proyectos")
                    End If

                    Exit For
                End If

            Next

        End If


        intManual = 0
    End Sub
End Class
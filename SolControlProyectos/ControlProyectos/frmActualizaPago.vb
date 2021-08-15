Public Class frmActualizaPago

    Private Sub btnCanc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        swPagos = 0
        Me.Close()
    End Sub

    Private Sub tbxMonto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(tbxMonto.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                tbxMonto.Text = decimales(tbxMonto.Text) 'Format(CDec(txtMonto.Text), "C")
                e.Handled = True
                Me.btnAcep.Focus()


            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            tbxMonto.SelectAll()
        End If
    End Sub

    Private Sub frmActualizaPago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "ACTUALIZAR PAGO FACTURA" & " - " & FactNro

        Me.tbxNroFac.Text = FactNro
        Me.tbxNroRec.Text = RecNro
        dtpFecPago.Value = f15.dtpfCheq.Value
        tbxDocPago.Text = DocPago
        tbxMonto.Text = f15.tbxMtoCheq.Text
        tbxNroCheq.Text = f15.tbxNroCheque.Text
        tbxMes.Text = f15.tbx_MesEje.Text
        tbxDocSi.Text = f15.tbxDocNext.Text
        tbxScafid.Text = f15.tbxScafid.Text
        dtpFechaR.Value = f15.dtpFecRefr.Text
        dtpFechaFact.Value = f15.dtpFecFac.Value
        Me.cmbTdoc.SelectedItem = f15.dtpFecFac.Value
        ' tbxConc.Text = f15.Text
        llenarCombopagos()

        Me.cmbTdoc.Text = tPago

    End Sub
    Sub limpiaFormPagos()
        tbxNroFac.Text = ""
        tbxNroRec.Text = ""
        dtpFecPago.Value = Date.Now
        tbxDocPago.Text = ""
        tbxMonto.Text = ""
        tbxNroCheq.Text = ""
        tbxMes.Text = ""
        tbxDocSi.Text = ""
        tbxScafid.Text = ""
        dtpFechaR.Value = Date.Now
        tbxConc.Text = ""

    End Sub
    Public Function DecimalKey(ByVal KCode As Int16) As Boolean

        If (KCode >= 48 And KCode <= 57) Or KCode = 8 Or KCode = 46 Then
            Return False
        Else
            Return True
        End If

    End Function

    Public Function Numerico(ByVal valor As String) As Boolean
        intk = 0
        Dim strCad As String = valor
        Dim i As Integer

        For i = 1 To Len(strCad)
            If Mid(strCad, i, 1) = "." Then
                intk += 1
            End If


        Next


        If intk <= 1 Then
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub tbxMonto_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        bolValor = Numerico(tbxMonto.Text)
        If bolValor = False Then


            tbxMonto.Text = decimales(tbxMonto.Text) 'Format(CDec(txtMonto.Text), "C")

            Me.btnAcep.Focus()



        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            tbxMonto.SelectAll()
        End If
    End Sub


    Private Sub tbxDocPago_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            e.Handled = True
            Me.dtpFecPago.Focus()


        End If
    End Sub

    Private Sub dtpFecPago_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            e.Handled = True
            Me.tbxConc.Focus()


        End If
    End Sub

    Private Sub tbxConc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            e.Handled = True
            Me.tbxMonto.Focus()


        End If
    End Sub

    Private Sub btnAcep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            ConexionSQL()

            cntSQL.Execute("UPDATE tab_Rel_FacturasPagos SET pro_DocPago='" & Me.tbxDocPago.Text & "', pro_FechaPago=' " & Format(Me.dtpFecPago.Value, "yyyyMMdd") & "', pro_Observaciones='" & Me.tbxConc.Text & "', pro_MontoPago='" & Replace(Me.tbxMonto.Text, ",", "") & "'  WHERE pro_NroProyecto='" & ProyNro & "' AND pro_NroContrato='" & ContNro & "' AND pro_NroFactura='" & FactNro & "' AND pro_DocPago='" & DocPago & "' and  pro_NroCheque='" & LTrim(LTrim(tbxNroCheq.Text)) & "' AND pro_FechaPago=' " & Format(FecPago, "yyyyMMdd") & "'")

            MsgBox("Pago Actualizado.", MsgBoxStyle.Information, "Control Proyectos")

            Me.Close()
        Catch ex As Exception
            MsgBox("Error en funcion btnAcep_Click" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try


    End Sub

    Private Sub tbxNroFac_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxNroFac.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            Me.tbxNroRec.Focus()


        End If
    End Sub

    Private Sub tbxNroRec_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxNroRec.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            Me.dtpFecPago.Focus()


        End If
    End Sub

    Private Sub dtpFecha_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFecPago.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            Me.tbxDocPago.Focus()


        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxDocPago.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            Me.tbxMonto.Focus()


        End If
    End Sub

    Private Sub tbxMonto_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxMonto.KeyPress
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(tbxMonto.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                tbxMonto.Text = decimales(tbxMonto.Text) 'Format(CDec(txtMonto.Text), "C")
                e.Handled = True
                Me.tbxNroCheq.Focus()

            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxMonto.SelectAll()
        End If

    End Sub

    Private Sub tbxNroCheq_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxNroCheq.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            Me.tbxMes.Focus()


        End If
    End Sub

    Private Sub tbxMes_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxMes.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            Me.tbxDocSi.Focus()


        End If
    End Sub

    Private Sub tbxDocSi_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxDocSi.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            Me.tbxScafid.Focus()


        End If
    End Sub

    Private Sub tbxScafid_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxScafid.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            Me.dtpFechaR.Focus()


        End If
    End Sub

    Private Sub dtpFechaR_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFechaR.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            Me.tbxConc.Focus()


        End If
    End Sub

    Private Sub tbxConcepto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxConc.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            Me.tbxDocPago.Focus()


        End If
    End Sub

    Private Sub tbxMonto_Leave_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbxMonto.Leave
        If bolValor = False Then
            tbxMonto.Text = decimales(tbxMonto.Text) 'Format(CDec(txtMonto.Text), "C")
            Me.tbxNroCheq.Focus()
        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxMonto.SelectAll()
        End If
    End Sub

    Private Sub btnAcep_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAcep.Click

        Dim swpagr As Integer = 0
        Try

            Dim strTotalFact As ADODB.Recordset
            Dim strRelpagos As ADODB.Recordset
            Dim decMontoFac As Decimal = 0
            Dim decMontoFacpar As Decimal = 0
            Dim decMontoPago As Decimal = 0
            Dim decMontoPago1 As Decimal = 0
            Dim preg As String = "0"

            If Me.tbxMonto.Text <> "" And Me.tbxDocPago.Text <> "" Then

                strTotalFact = cntSQL.Execute("select SUM(pro_CuentaCobrar) as pro_CuentaCobrar from tab_Aux_FactProy where [pro_idProyecto]=" & stridProy & " and [pro_NroContrato]='" & ContNro & "' and [pro_nroProyecto]='" & ProyNro & "' and pro_NroFactura='" & FactNro & "' ")

                Do While Not strTotalFact.EOF
                    decMontoFac = Val(IIf(strTotalFact.Fields("pro_CuentaCobrar").Value Is DBNull.Value, 0, strTotalFact.Fields("pro_CuentaCobrar").Value))

                    Exit Do
                Loop

                strRelpagos = cntSQL.Execute("SELECT SUM(pro_MontoPago) as pro_MontoPago FROM tab_Rel_FacturasPagos WHERE [pro_idProyecto]=" & stridProy & " and [pro_NroContrato]='" & ContNro & "' and [pro_NroProyecto]='" & ProyNro & "' and pro_NroFactura='" & FactNro & "'   and pro_DocPago <>'" & Me.tbxDocPago.Text & "'")

                Do While Not strRelpagos.EOF
                    decMontoFacpar = Val(IIf(strRelpagos.Fields("pro_MontoPago").Value Is DBNull.Value, 0, strRelpagos.Fields("pro_MontoPago").Value))

                    Exit Do
                Loop
                decMontoPago = Me.tbxMonto.Text
                decMontoPago1 = Me.tbxMonto.Text


                If RTrim(LTrim(Me.cmbTdoc.SelectedItem)) = "NC" Then

                    decMontoPago1 = decMontoPago1 * -1

                End If

                If ((decMontoFac - decMontoFacpar) - decMontoPago1) < 0 Then

                    preg = MsgBox("Monto supera el pago de la factura, desea Agregar?", MsgBoxStyle.YesNo, "Control Proyectos")


                Else

                    cntSQL.Execute("UPDATE tab_Rel_FacturasPagos SET pro_FechaPago='" & Format(dtpFecPago.Value, "yyyyMMdd") & "', pro_FechaRecibo='" & Format(dtpFechaR.Value, "yyyyMMdd") & "', pro_DocPago='" & Me.tbxDocPago.Text & "', pro_MontoPago='" & Replace(Me.tbxMonto.Text, ",", "") & "', pro_NroCheque='" & RTrim(LTrim(Me.tbxNroCheq.Text)) & "',pro_MesEj='" & Me.tbxMes.Text & "',pro_DocNext= '" & Me.tbxDocSi.Text & "', pro_Scafid='" & Me.tbxScafid.Text & "', pro_Observaciones='" & Me.tbxConc.Text & "'  WHERE pro_NroProyecto='" & ProyNro & "' AND pro_NroContrato='" & LTrim(LTrim(ContNro)) & "' AND pro_NroFactura='" & LTrim(LTrim(FactNro)) & "' AND  pro_DocPago ='" & Me.tbxDocPago.Text & "' AND pro_FechaFactura='" & Format(Me.dtpFechaFact.Value, "yyyyMMdd") & "'")

                    MsgBox("Pago Actualizado.", MsgBoxStyle.Information, "Control Proyectos")
                    f15.ConsultasdPagosf15()
                    Me.Close()

                End If

                If preg = 6 Then
                    cntSQL.Execute("UPDATE tab_Rel_FacturasPagos SET pro_FechaPago='" & Format(dtpFecPago.Value, "yyyyMMdd") & "', pro_FechaRecibo='" & Format(dtpFechaR.Value, "yyyyMMdd") & "', pro_DocPago='" & Me.tbxDocPago.Text & "', pro_MontoPago='" & Replace(Me.tbxMonto.Text, ",", "") & "', pro_NroCheque='" & RTrim(LTrim(Me.tbxNroCheq.Text)) & "',pro_MesEj='" & Me.tbxMes.Text & "',pro_DocNext= '" & Me.tbxDocSi.Text & "', pro_Scafid='" & Me.tbxScafid.Text & "', pro_Observaciones='" & Me.tbxConc.Text & "'  WHERE pro_NroProyecto='" & ProyNro & "' AND pro_NroContrato='" & LTrim(LTrim(ContNro)) & "' AND pro_NroFactura='" & LTrim(LTrim(FactNro)) & "' AND  pro_DocPago ='" & Me.tbxDocPago.Text & "' AND pro_FechaFactura='" & Format(Me.dtpFechaFact.Value, "yyyyMMdd") & "'")

                    MsgBox("Pago Actualizado.", MsgBoxStyle.Information, "Control Proyectos")
                    f15.ConsultasdPagosf15()
                    Me.Close()
                End If

            Else
                MsgBox("Campos Con (*) son obligatorios, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            End If

        Catch ex As Exception
            MsgBox("Error en funcion btnAcep_Click" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try

        limpiaFormPagos()
        f15.llenarFactPagosf15()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        limpiaFormPagos()
        Me.Close()
    End Sub

    Sub llenarCombopagos()
        Try
            Dim strpg As New ADODB.Recordset
            ConexionSQL()
            Me.cmbTdoc.Items.Clear()
            strpg = cntSQL.Execute("SELECT Descripcion, id FROM tab_tipoPgo order by 2")

            Do While Not strpg.EOF
                Me.cmbTdoc.Items.Add(strpg.Fields(0).Value)

                strpg.MoveNext()
            Loop


        Catch ex As Exception
            MsgBox("Error en funcion llenarCombopagos()" & ex.Message)
        End Try
    End Sub
End Class
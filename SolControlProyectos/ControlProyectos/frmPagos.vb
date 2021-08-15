Public Class frmPagos

    Private Sub btnCanc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCanc.Click
        limpiaFormPagos()
        Me.Close()
    End Sub

    Private Sub frmPagos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        archivo = Replace((DateTime.Now), "/", "")
        archivo = Replace((archivo), ":", "")
        archivo = Replace((archivo), " ", "")
        archivo = Mid(archivo, 1, 14)
        Me.tbxDocPago.Text = archivo

        limpiarFormPagos()
        llenarCombopagos()
        cmbTdoc.SelectedIndex = 0

        If FactNro <> "" Then
            Me.tbxNroFac.Text = FactNro
            Me.tbxNroRec.Text = RecNro
            Me.dtpFechaFact.Value = f15.dtpFecFac.Value

        Else
            MsgBox("Debe Seleccionar la Factura", MsgBoxStyle.Information, "Control Proyectos")
            Me.Close()
        End If
    End Sub

    

    Private Sub dtpFecha_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFecha.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            Me.tbxDocPago.Focus()

        End If
    End Sub

    Private Sub tbxDocPago_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxDocPago.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            Me.tbxMonto.Focus()


        End If
    End Sub

    Private Sub tbxMonto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxMonto.KeyPress

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

    Private Sub tbxMonto_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbxMonto.Leave
        If bolValor = False Then


            tbxMonto.Text = decimales(tbxMonto.Text) 'Format(CDec(txtMonto.Text), "C")


            Me.tbxNroCheq.Focus()



        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxMonto.SelectAll()
        End If
    End Sub
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
    Public Function DecimalKey(ByVal KCode As Int16) As Boolean

        If (KCode >= 48 And KCode <= 57) Or KCode = 8 Or KCode = 46 Then
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub btnAcept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAcept.Click

        If Me.tbxMonto.Text <> "" And Me.tbxDocPago.Text <> "" Then
            insertaPago()
        Else
            MsgBox("Campos Con (*) son obligatorios, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
        End If

        limpiaFormPagos()
        f15.llenarFactPagosf15()
        f15.llenarFactRelPagos()
        f15.ltwPagosParciales.Refresh()

    End Sub
    Sub limpiaFormPagos()
        tbxNroFac.Text = ""
        tbxNroRec.Text = ""
        dtpFecha.Value = Date.Now
        tbxDocPago.Text = ""
        tbxMonto.Text = "0"
        tbxNroCheq.Text = ""
        tbxMes.Text = ""
        tbxDocSi.Text = ""
        tbxScafid.Text = ""
        dtpFechaR.Value = Date.Now
        tbxConcepto.Text = ""

    End Sub

    Private Sub tbxConcepto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxConcepto.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            e.Handled = True
            Me.btnAcept.Focus()

        End If
    End Sub

    Sub limpiarFormPagos()
        Me.tbxConcepto.Text = ""
        ' Me.tbxDocPago.Text = ""
        Me.tbxMonto.Text = "0"
        Me.dtpFecha.Value = Date.Now

    End Sub
    Sub insertaPago()

        Dim swpagr As Integer = 0
        Try
            Dim strPagos As ADODB.Recordset
            Dim strTotalFact As ADODB.Recordset
            Dim strRelpagos As ADODB.Recordset
            Dim strCantpagos As ADODB.Recordset
            Dim decMontoFac As Decimal = 0
            Dim decMontoFacpar As Decimal = 0
            Dim decMontoPago As Decimal = 0
            Dim decMontoPago1 As Decimal = 0
            Dim preg As String = "0"
            Dim fechaFact As Date
            Dim fechaRec As Date
            Dim fechaDoc As Date



            strPagos = cntSQL.Execute("select * from tab_Aux_FactProy where [pro_idProyecto]=" & stridProy & " and [pro_NroContrato]='" & ContNro & "' and [pro_nroProyecto]='" & ProyNro & "' and pro_NroFactura='" & FactNro & "'")

            Do While Not strPagos.EOF

                'REVISO LA CANTIDAD DE PAGOS DE ESA FACTURA
                'PARA INDICAR AL USUARIO QUE SOBREPASA EL MONTO
                'SI LLEGASE A OCURRIR

                strTotalFact = cntSQL.Execute("select SUM(pro_CuentaCobrar) as pro_CuentaCobrar from tab_Aux_FactProy where [pro_idProyecto]=" & stridProy & " and [pro_NroContrato]='" & ContNro & "' and [pro_nroProyecto]='" & ProyNro & "' and pro_NroFactura='" & FactNro & "'")

                Do While Not strTotalFact.EOF
                    decMontoFac = Val(IIf(strTotalFact.Fields("pro_CuentaCobrar").Value Is DBNull.Value, 0, strTotalFact.Fields("pro_CuentaCobrar").Value))

                    Exit Do
                Loop

                strRelpagos = cntSQL.Execute("SELECT SUM(pro_MontoPago) as pro_MontoPago FROM tab_Rel_FacturasPagos WHERE [pro_idProyecto]=" & stridProy & " and [pro_NroContrato]='" & ContNro & "' and [pro_NroProyecto]='" & ProyNro & "' and pro_NroFactura='" & FactNro & "'")

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

                    fechaFact = strPagos.Fields("pro_FechaFact").Value
                    fechaRec = strPagos.Fields("pro_FechaRes").Value
                    fechaDoc = Me.dtpFecha.Value


                    'reviso que el documento con el cheque y la fecha no esten duplicados para esta factura

                    strCantpagos = cntSQL.Execute("SELECT * FROM tab_Rel_FacturasPagos WHERE [pro_idProyecto]=" & stridProy & " and [pro_NroContrato]='" & ContNro & "' and [pro_NroProyecto]='" & ProyNro & "' and pro_NroFactura='" & FactNro & "'  and pro_DocPago ='" & Me.tbxDocPago.Text & "' and pro_FechaPago='" & Format(fechaDoc, "yyyyMMdd") & "' ")


                    If strCantpagos.EOF = True Then


                        strRelpagos = cntSQL.Execute("insert into tab_Rel_FacturasPagos(pro_idProyecto, pro_NroProyecto,pro_NroContrato,pro_NroFactura,pro_FechaFactura,pro_NroRecibo,pro_FechaRecibo,pro_DocPago,pro_FechaPago,pro_MontoPago, pro_Observaciones, pro_NroCheque,pro_MesEj, pro_DocNext, pro_Scafid, pro_FechaRefrendo, pro_ControlCheq, pro_Tipodoc) values " _
                                          & " (" & stridProy & ",'" & ProyNro & "', '" & ContNro & "','" & FactNro & "', '" & Format(fechaFact, "yyyyMMdd") & "', '" & RTrim(LTrim(RecNro)) & "', '" & Format(fechaRec, "yyyyMMdd") & "', '" & Me.tbxDocPago.Text & "','" & Format(fechaDoc, "yyyyMMdd") & "','" & Replace(decMontoPago, ",", "") & "' ,'" & Me.tbxConcepto.Text & "', '" & RTrim(LTrim(Me.tbxNroCheq.Text)) & "','" & Me.tbxMes.Text & "', '" & Me.tbxDocSi.Text & "', '" & Me.tbxScafid.Text & "', '" & Format(fechaDoc, "yyyyMMdd") & "',0,'" & RTrim(LTrim(Me.cmbTdoc.SelectedItem)) & "' )")

                        MsgBox("Pago Registrado", MsgBoxStyle.Information, "Control Proyectos")
                        Exit Do
                        Me.Close()

                        strPagos.MoveNext()

                    Else
                        MsgBox("Pago se encuentra registrado, por favor verifique", MsgBoxStyle.Information, "Control Proyectos")
                        ' Me.Close()
                    End If


                End If

                If preg = 6 Then
                    fechaFact = strPagos.Fields("pro_FechaFact").Value
                    fechaRec = strPagos.Fields("pro_FechaRes").Value
                    fechaDoc = Me.dtpFecha.Value


                    'reviso que el documento con el cheque y la fecha no esten duplicados para esta factura

                    strCantpagos = cntSQL.Execute("SELECT * FROM tab_Rel_FacturasPagos WHERE [pro_idProyecto]=" & stridProy & " and [pro_NroContrato]='" & ContNro & "' and [pro_NroProyecto]='" & ProyNro & "' and pro_NroFactura='" & FactNro & "'  and pro_DocPago ='" & Me.tbxDocPago.Text & "' and pro_FechaPago='" & Format(fechaDoc, "yyyyMMdd") & "' ")


                    If strCantpagos.EOF = True Then



                        strRelpagos = cntSQL.Execute("insert into tab_Rel_FacturasPagos(pro_idProyecto, pro_NroProyecto,pro_NroContrato,pro_NroFactura,pro_FechaFactura,pro_NroRecibo,pro_FechaRecibo,pro_DocPago,pro_FechaPago,pro_MontoPago, pro_Observaciones, pro_NroCheque,pro_MesEj, pro_DocNext, pro_Scafid, pro_FechaRefrendo, pro_ControlCheq, pro_Tipodoc) values " _
                                        & " (" & stridProy & ",'" & ProyNro & "', '" & ContNro & "','" & FactNro & "', '" & Format(fechaFact, "yyyyMMdd") & "', '" & RTrim(LTrim(RecNro)) & "', '" & Format(fechaRec, "yyyyMMdd") & "', '" & Me.tbxDocPago.Text & "','" & Format(fechaDoc, "yyyyMMdd") & "','" & Replace(decMontoPago, ",", "") & "' ,'" & Me.tbxConcepto.Text & "', '" & RTrim(LTrim(Me.tbxNroCheq.Text)) & "','" & Me.tbxMes.Text & "', '" & Me.tbxDocSi.Text & "', '" & Me.tbxScafid.Text & "', '" & Format(fechaDoc, "yyyyMMdd") & "',0,'" & RTrim(LTrim(Me.cmbTdoc.SelectedItem)) & "' )")

                        MsgBox("Pago Registrado", MsgBoxStyle.Information, "Control Proyectos")
                        Exit Do
                        Me.Close()
                    Else

                        MsgBox("Pago se encuentra registrado, por favor verifique", MsgBoxStyle.Information, "Control Proyectos")

                        Me.Close()
                    End If

                Else

                    Exit Do
                End If

            Loop
            f15.llenarFactRelPagos()

        Catch ex As Exception
            MsgBox("Error en funcion insertaPago()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
        swpagr = 0
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
            Me.tbxConcepto.Focus()


        End If
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
Public Class frmInsertaFactura
    Public dectbxFac As Decimal = 0
    Public dectbxCxC As Decimal = 0
    Public dectbxMtoITBMS As Decimal = 0
    Public dectbxMtoRet As Decimal = 0
    Public decttbxAntMont As Decimal = 0
    Public decttbxRetMtoITBMS As Decimal = 0

   

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        ' f25 = frmInsertaFactura
      

        RecNro = ""
        If ProyNro <> "" Then
            If ContNro <> "" Then


                If f25.tbxNroFac.Text <> "" And f25.tbxCxC.Text <> "" Then

                    FactNro = f25.tbxNroFac.Text()
                    RecNro = f25.tbxNroReci.Text()
                    swMenuPpal = 5


                    'insertNroFact(idProy, ProyNro, ContNro, RecNro, FactNro)
                    guardaActProyeDFact25()
                   

                Else
                    MsgBox("Campos con (*) son obligatorios", vbCritical, "Control de Proyectos")
                End If


                ' f25.tbxNroFac.Focus()
                llenarFactPagosf25()

            End If





        Else
            MsgBox("Debe Seleccionar un Proyecto", MsgBoxStyle.Information, "Control de Proyectos")
        End If


        Rec = ""
        Rec1 = ""


    End Sub
    Sub buscaNroContrato()

        Try
            ConexionSQL()
            Dim strDatos As New ADODB.Recordset
            Dim i As Integer = 0
          

            strDatos = cntSQL.Execute("SELECT top 1 pro_nroContrato from tab_DatosPpalProy_Compl where pro_nroProyecto= '" & ProyNro & "'")

           
            If strDatos.EOF = False Then
                ContNro = strDatos.Fields("pro_nroContrato").Value

            End If

        Catch ex As Exception
            MsgBox("Error en buscar Nro de buscaNroContrato()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub

    Sub llenarFactPagosf25()
        Try
            ConexionSQL()
            Dim strDatos As New ADODB.Recordset
            Dim i As Integer = 0
            f15.ltwPagosParciales.Items.Clear()
            f15.ltwPagosRel.Items.Clear()

              strDatos = cntSQL.Execute("exec p_calculaPagos '" & ProyNro & "','" & stridProy & "','" & ContNro & "'")

         
            Do While Not strDatos.EOF

                f15.ltwPagosParciales.Items.Add(ProyNro)
                f15.ltwPagosParciales.Items(i).SubItems.Add(strDatos.Fields("pro_NroContrato").Value)
                f15.ltwPagosParciales.Items(i).SubItems.Add(strDatos.Fields("pro_NroFactura").Value)
                f15.ltwPagosParciales.Items(i).SubItems.Add(strDatos.Fields("pro_NroRecibo").Value)
                f15.ltwPagosParciales.Items(i).SubItems.Add(decimales(strDatos.Fields("pro_CuentaCobrar").Value))
                i += 1
                strDatos.MoveNext()
            Loop

        Catch ex As Exception
            MsgBox("Error en buscar Nro de llenarFactPagosf15" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub

    Sub llenarCombocmbEnInsp()
        Try
            Dim strseleccion As New ADODB.Recordset
            Me.cmbEnInsp.Items.Clear()

            strseleccion = cntSQL.Execute("SELECT  [Descripcion] FROM tab_seleccionSimple")

            Do While Not strseleccion.EOF
                Me.cmbEnInsp.Items.Add(strseleccion.Fields(0).Value)

                strseleccion.MoveNext()
            Loop


        Catch ex As Exception
            MsgBox("Error en funcion llenarCombocmbEnInsp" & ex.Message)
        End Try
    End Sub
    Sub llenarComboCheque()
        'Try
        '    Dim strCheq As New ADODB.Recordset


        '    strCheq = cntSQL.Execute("SELECT des_CtrlCheque FROM [dbo].[tab_CtrlCheque]")

        '    Do While Not strCheq.EOF
        '        Me.cmbCtrlCheq.Items.Add(strCheq.Fields(0).Value)

        '        strCheq.MoveNext()
        '    Loop


        'Catch ex As Exception
        '    MsgBox("Error en funcion llenarComboCheque()" & ex.Message)
        'End Try
    End Sub
    Sub llenarComboRecibo()
        Try
            Dim strRec As New ADODB.Recordset

            Me.cmbCtrlRec.Items.Clear()
            strRec = cntSQL.Execute("SELECT des_CtrlRecibo FROM [dbo].[tab_CtrlRecibo]")

            Do While Not strRec.EOF
                Me.cmbCtrlRec.Items.Add(strRec.Fields(0).Value)

                strRec.MoveNext()
            Loop


        Catch ex As Exception
            MsgBox("Error en funcion llenarComboRecibo()" & ex.Message)
        End Try
    End Sub

    Sub llenarCombocmbRe10()
        'Try
        '    Dim strseleccion As New ADODB.Recordset
        '    Me.cmbRe10.Items.Clear()

        '    strseleccion = cntSQL.Execute("SELECT  [descripcion] FROM tab_seleccionSimple")

        '    Do While Not strseleccion.EOF
        '        Me.cmbRe10.Items.Add(strseleccion.Fields(0).Value)

        '        strseleccion.MoveNext()
        '    Loop


        'Catch ex As Exception
        '    MsgBox("Error en funcion llenarCombocmbRe10" & ex.Message)
        'End Try
    End Sub

    Private Sub frmInsertaFactura_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        f25.clearDfact25()
    End Sub

    Private Sub frmInsertaFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        llenarCombocmbEnInsp()
        llenarComboRecibo()
        buscaNroContrato()
    End Sub

    Private Sub tbxFac_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxFac.KeyPress
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(tbxFac.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                tbxFac.Text = decimales(tbxFac.Text) 'Format(CDec(txtMonto.Text), "C")
                e.Handled = True
                Me.tbxMtoRet.Focus()


            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxFac.SelectAll()
        End If

    End Sub

    Public Function DecimalKey(ByVal KCode As Int16) As Boolean

        If (KCode >= 48 And KCode <= 57) Or KCode = 8 Or KCode = 46 Then
            Return False
        Else
            Return True
        End If

    End Function

    Public Function EnteroKey(ByVal KCode As Int16) As Boolean

        If (KCode >= 48 And KCode <= 57) Or KCode = 8 Then
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

    Private Sub cmbCtrlRec_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCtrlRec.SelectedIndexChanged
        If cmbCtrlRec.SelectedIndex = 1 Then


            Me.tbxNroReci.Enabled = False
            Me.dtpFecREC.Enabled = False
        Else

            Me.tbxNroReci.Enabled = True
            Me.dtpFecREC.Enabled = True

        End If
    End Sub

    Private Sub cmbEnInsp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEnInsp.SelectedIndexChanged
        If cmbEnInsp.SelectedIndex = 1 Then
            Me.dtpFecEnt.Enabled = False
            Me.dtpCXC.Focus()


        Else
            Me.dtpFecEnt.Enabled = True
            Me.dtpFecEnt.Focus()
        End If
    End Sub

    Private Sub ToolStripButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton12.Click
        f25.clearDfact25()
        Me.Close()
    End Sub

    Private Sub tbxNroFac_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxNroFac.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.dtpFecFac.Focus()

        End If
    End Sub

    Private Sub dtpFecFac_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFecFac.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.tbxFac.Focus()

        End If
    End Sub

    Private Sub tbxFac_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbxFac.TextChanged
        dectbxFac = IIf(tbxFac.Text = "", 0, tbxFac.Text)
        tbxCxC.Text = (dectbxFac + dectbxMtoITBMS) - (dectbxMtoRet + decttbxAntMont + decttbxRetMtoITBMS)
       
    End Sub

    Private Sub tbxMtoRet_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbxMtoRet.TextChanged
        dectbxMtoRet = IIf(tbxMtoRet.Text = "", 0, tbxMtoRet.Text)
        tbxCxC.Text = (dectbxFac + dectbxMtoITBMS) - (dectbxMtoRet + decttbxAntMont + decttbxRetMtoITBMS)
    End Sub

    Private Sub dtpFecEs_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecEs.ValueChanged

    End Sub

    Private Sub tbxAntMont_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxAntMont.KeyPress
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(tbxAntMont.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                tbxAntMont.Text = decimales(tbxAntMont.Text) 'Format(CDec(txtMonto.Text), "C")
                e.Handled = True
                Me.tbxMtoITBMS.Focus()


            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxAntMont.SelectAll()
        End If

    End Sub

    Private Sub tbxMtoITBMS_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxMtoITBMS.KeyPress
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(tbxMtoITBMS.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                tbxMtoITBMS.Text = decimales(tbxMtoITBMS.Text) 'Format(CDec(txtMonto.Text), "C")
                e.Handled = True
                Me.tbxRetMtoITBMS.Focus()


            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxMtoITBMS.SelectAll()
        End If

    End Sub

    Private Sub tbxRetMtoITBMS_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxRetMtoITBMS.KeyPress
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(tbxRetMtoITBMS.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                tbxRetMtoITBMS.Text = decimales(tbxRetMtoITBMS.Text) 'Format(CDec(txtMonto.Text), "C")
                e.Handled = True
                Me.tbxCxC.Focus()


            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxRetMtoITBMS.SelectAll()
        End If
    End Sub

    Private Sub tbxCxC_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxCxC.KeyPress
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(tbxCxC.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                tbxCxC.Text = decimales(tbxCxC.Text) 'Format(CDec(txtMonto.Text), "C")
                e.Handled = True
                Me.dtpFecEs.Focus()


            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxCxC.SelectAll()
        End If
    End Sub

    Private Sub dtpFecEnt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFecEnt.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.dtpCXC.Focus()

        End If
    End Sub

    Private Sub dtpCXC_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpCXC.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.cmbCtrlRec.Focus()

        End If

    End Sub

    Private Sub tbxNroReci_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxNroReci.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.dtpFecREC.Focus()

        End If
    End Sub

    Private Sub dtpFecREC_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFecREC.KeyPress


        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.dtpFecPago.Focus()

        End If
    End Sub

    Private Sub dtpFecPago_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFecPago.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.dtpFecTe.Focus()

        End If
    End Sub

    Private Sub dtpFecTe_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFecTe.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.tbxPena.Focus()

        End If
    End Sub

    
    Private Sub tbxMtoRet_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxMtoRet.KeyPress
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(tbxMtoRet.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                tbxMtoRet.Text = decimales(tbxMtoRet.Text) 'Format(CDec(txtMonto.Text), "C")
                e.Handled = True
                Me.tbxAntMont.Focus()


            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxMtoRet.SelectAll()
        End If
    End Sub

    Private Sub dtpFecEs_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFecEs.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.cmbEnInsp.Focus()

        End If
    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub tbxPena_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxPena.KeyPress
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(tbxPena.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                tbxPena.Text = decimales(tbxPena.Text) 'Format(CDec(txtMonto.Text), "C")
                e.Handled = True
                'Me.tbxMtoRet.Focus()


            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxPena.SelectAll()
        End If

    End Sub

    Private Sub btnBusFact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusFact.Click

        frmFacturas.Show()
    End Sub

    
    Private Sub gbpA2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbpA2.Enter

    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Try
            Dim preg As String = ""

            preg = MsgBox("Seguro que desea modificar la Factura?", MsgBoxStyle.YesNo, "Control Proyectos")
            If preg = 6 Then
                ActProyeDFact25()

               
            End If

        Catch ex As Exception
            MsgBox("Error boton editar factura", MsgBoxStyle.Critical, "Control Proyectos")
        End Try

    End Sub
    Sub clearDfact25()

        f25.tbxNroReci.Text = ""

        f25.tbxNroFac.Text = ""
        ' f25.tbxSaldoFact.Text = ""
        f25.tbxFac.Text = ""
        ' f25.cmbRe10.SelectedIndex = -1
        f25.tbxMtoRet.Text = ""
        f25.tbxAntMont.Text = ""
        f25.tbxPena.Text = ""
        ' f25.tbxDocNext.Text = ""
        f25.tbxRetMtoITBMS.Text = "0"
        f25.tbxMtoITBMS.Text = "0"
        f25.tbxCxC.Text = ""
        f25.cmbEnInsp.SelectedIndex = -1
        '  f25.tbxNrocta.Text = ""
        f25.dtpFecEnt.Value = Date.Now
        f25.dtpFecFac.Value = Date.Now
        f25.dtpFecEs.Value = Date.Now

        f25.dtpFecREC.Value = Date.Now
        f25.dtpFecPago.Value = Date.Now
        f25.dtpFecTe.Value = Date.Now
        f25.cmbCtrlRec.SelectedIndex = -1
        f25.dtpCXC.Value = Date.Now
        f25.dtpFecEs.Value = Date.Now
        'f25.cmbstatus.SelectedIndex = -1

    End Sub
   
    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Try
            Dim preg As String = ""
           
            eliminaProyeDFact25()
            

        Catch ex As Exception
            MsgBox("Error boton editar factura", MsgBoxStyle.Critical, "Control Proyectos")
        End Try

    End Sub

    Private Sub tbxAntMont_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbxAntMont.TextChanged
        decttbxAntMont = IIf(tbxAntMont.Text = "", 0, tbxAntMont.Text)
        tbxCxC.Text = (dectbxFac + dectbxMtoITBMS) - (dectbxMtoRet + decttbxAntMont + decttbxRetMtoITBMS)
    End Sub

    Private Sub tbxMtoITBMS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbxMtoITBMS.TextChanged
        dectbxMtoITBMS = IIf(tbxMtoITBMS.Text = "", 0, tbxMtoITBMS.Text)
        tbxCxC.Text = (dectbxFac + dectbxMtoITBMS) - (dectbxMtoRet + decttbxAntMont + decttbxRetMtoITBMS)
    End Sub

    Private Sub tbxRetMtoITBMS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbxRetMtoITBMS.TextChanged
        decttbxRetMtoITBMS = IIf(tbxRetMtoITBMS.Text = "", 0, tbxRetMtoITBMS.Text)
        tbxCxC.Text = (dectbxFac + dectbxMtoITBMS) - (dectbxMtoRet + decttbxAntMont + decttbxRetMtoITBMS)
    End Sub

    Private Sub tbxCxC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbxCxC.TextChanged
        ' tbxCxC.Text = (dectbxFac + dectbxMtoITBMS) - (dectbxMtoRet + decttbxAntMont + decttbxRetMtoITBMS)
        '  tbxCxC.Text = (dectbxFac + dectbxMtoITBMS) - (dectbxMtoRet + decttbxAntMont + decttbxRetMtoITBMS)
    End Sub
End Class
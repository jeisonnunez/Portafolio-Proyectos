Public Class frmMenuProyecto
    Public strTabPages As Integer = 1
    Dim swproy As Integer = 0
   
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        strMenu = "1"
        tbcProy.SelectedTab = tbcProy.TabPages(1)


    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        f1.Close()

    End Sub

    Private Sub btnSig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        strMenu = "1"
        ' frmSubmenup.ShowDialog()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        strMenu = "1"
        tbcProy.SelectedTab = tbcProy.TabPages(3)

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        strMenu = "1"
        tbcProy.SelectedTab = tbcProy.TabPages(3)

    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        strMenu = "1"
        'frmSubmenup.ShowDialog()
    End Sub

   

    Private Sub Button16_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'strMenu = "1"
        'frmSubmenup.ShowDialog()


        tbcProy.SelectedTab = tbcProy.TabPages(2)


    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        tbcProy.SelectedTab = tbcProy.TabPages(1)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        tbcProy.SelectedTab = tbcProy.TabPages(2)

    End Sub



    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub tbxCodp_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            swMenuPpal = 0
            strMenu = "2"
            strCodbus = tbxCodp.Text
            frmSubmenup.ShowDialog()
            f1.cmbClas.Focus()

        End If
    End Sub


    Private Sub frmMenuProyecto_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        CtaNro = 0
        ProyNro = ""
        ContNro = ""
        RecNro = ""
        FactNro = ""
        idProy = 0
        swMenuPpal = 0
        ConexionSQL()
        f1.tbxCodp.Focus()
        llenarComboStatus()
        llenarComboTipo()
        llenarComboSector()
        llenarComboMeses()
        llenarComboRecibo()
        llenarComboCheque()
        llenarComboRango()
        clearFormularios1()
        llenarComboStatusC()
        llenarComboPerpagoCtas()

        'ValidaProy()

        Me.tbpFacturacion.Parent = Nothing
        Me.tbxProMul.Parent = Nothing
        Me.tbxProDet.Parent = Nothing



    End Sub
    Sub llenarComboPerpagoCtas()
        Try
            Dim strperCtas As New ADODB.Recordset
            'Me.strperCtas.Items.Clear()

            strperCtas = cntSQL.Execute("SELECT des_perpagoCuentas FROM [dbo].[tab_perpagoCuentas]")

            Do While Not strperCtas.EOF
                ' Me.cmbperPagCtas.Items.Add(strperCtas.Fields(0).Value)

                strperCtas.MoveNext()
            Loop


        Catch ex As Exception
            MsgBox("Error en funcion  llenarComboPerpagoCtas()" & ex.Message)
        End Try
    End Sub
    Sub llenarComboStatusC()
        Try
            Dim strSector As New ADODB.Recordset
            Me.cmbstatus.Items.Clear()

            strSector = cntSQL.Execute("SELECT  [des_Status] FROM [dbo].[tab_Status_C]")

            Do While Not strSector.EOF
                Me.cmbstatus.Items.Add(strSector.Fields(0).Value)

                strSector.MoveNext()
            Loop


        Catch ex As Exception
            MsgBox("Error en funcion llenarComboStatus" & ex.Message)
        End Try
    End Sub
    Sub llenarComboRango()
        Try
            Dim strRango As New ADODB.Recordset
            Me.cmbRango.Items.Clear()
            Me.cmbRango1.Items.Clear()
            Me.cmbRango2.Items.Clear()

            strRango = cntSQL.Execute("SELECT des_Rango FROM [dbo].[tab_Rango]")

            Do While Not strRango.EOF
                Me.cmbRango.Items.Add(strRango.Fields(0).Value)
                Me.cmbRango1.Items.Add(strRango.Fields(0).Value)
                Me.cmbRango2.Items.Add(strRango.Fields(0).Value)
                strRango.MoveNext()
            Loop


        Catch ex As Exception
            MsgBox("Error en funcion llenarComboRango()" & ex.Message)
        End Try
    End Sub
    Sub llenarComboCheque()
        Try
            Dim strCheq As New ADODB.Recordset


            strCheq = cntSQL.Execute("SELECT des_CtrlCheque FROM [dbo].[tab_CtrlCheque]")

            Do While Not strCheq.EOF
                Me.cmbCtrlCheq.Items.Add(strCheq.Fields(0).Value)

                strCheq.MoveNext()
            Loop


        Catch ex As Exception
            MsgBox("Error en funcion llenarComboCheque()" & ex.Message, MsgBoxStyle.Critical, "Control de Proyectos")
        End Try
    End Sub
    Sub llenarComboRecibo()
        Try
            Dim strRec As New ADODB.Recordset


            strRec = cntSQL.Execute("SELECT des_CtrlRecibo FROM [dbo].[tab_CtrlRecibo]")

            Do While Not strRec.EOF
                Me.cmbCtrlRec.Items.Add(strRec.Fields(0).Value)

                strRec.MoveNext()
            Loop


        Catch ex As Exception
            MsgBox("Error en funcion llenarComboRecibo()" & ex.Message)
        End Try
    End Sub
    Sub llenarComboSector()
        Try
            Dim strSector As New ADODB.Recordset
            Me.cmbClas.Items.Clear()

            strSector = cntSQL.Execute("SELECT  [des_Sector] FROM [dbo].[tab_Sector]")

            Do While Not strSector.EOF
                Me.cmbClas.Items.Add(strSector.Fields(0).Value)

                strSector.MoveNext()
            Loop


        Catch ex As Exception
            MsgBox("Error en funcion llenarComboSector" & ex.Message)
        End Try
    End Sub
    Sub llenarComboTipo()
        Try
            Dim strTipo As New ADODB.Recordset
            ' Me.cmbTipo.Items.Clear()

            strTipo = cntSQL.Execute("SELECT [des_tipo] FROM [dbo].[tab_Tipo]")

            Do While Not strTipo.EOF
                '   Me.cmbTipo.Items.Add(strTipo.Fields(0).Value)

                strTipo.MoveNext()
            Loop


        Catch ex As Exception
            MsgBox("Error en funcion llenarComboTipo" & ex.Message)
        End Try
    End Sub
    Sub llenarCombocmbEnInsp()
        Try
            Dim strseleccion As New ADODB.Recordset
            Me.cmbEnInsp.Items.Clear()

            strseleccion = cntSQL.Execute("SELECT  [descripcion] FROM tab_seleccionSimple")

            Do While Not strseleccion.EOF
                Me.cmbEnInsp.Items.Add(strseleccion.Fields(0).Value)

                strseleccion.MoveNext()
            Loop


        Catch ex As Exception
            MsgBox("Error en funcion llenarCombocmbEnInsp" & ex.Message)
        End Try
    End Sub

    Sub llenarCombocmbRe10()
        Try
            Dim strseleccion As New ADODB.Recordset
            Me.cmbRe10.Items.Clear()

            strseleccion = cntSQL.Execute("SELECT  [descripcion] FROM tab_seleccionSimple")

            Do While Not strseleccion.EOF
                Me.cmbRe10.Items.Add(strseleccion.Fields(0).Value)

                strseleccion.MoveNext()
            Loop


        Catch ex As Exception
            MsgBox("Error en funcion llenarCombocmbRe10" & ex.Message)
        End Try
    End Sub

    Sub llenarComboStatus()
        Try
            Dim strSector As New ADODB.Recordset
            '   Me.cmbxSta.Items.Clear()

            strSector = cntSQL.Execute("SELECT [des_Status] FROM [dbo].[tab_Status]")

            Do While Not strSector.EOF
                ' Me.cmbxSta.Items.Add(strSector.Fields(0).Value)

                strSector.MoveNext()
            Loop


        Catch ex As Exception
            MsgBox("Error en funcion llenarComboStatus" & ex.Message)
        End Try
    End Sub
    Sub llenarComboMeses()
        'Try
        '    Dim strMes As New ADODB.Recordset


        '    strMes = cntSQL.Execute("SELECT desMes FROM [dbo].[tab_Meses]")

        '    Do While Not strMes.EOF
        '        Me.cmbxMes.Items.Add(strMes.Fields(0).Value)

        '        strMes.MoveNext()
        '    Loop


        'Catch ex As Exception
        '    MsgBox("Error en funcion llenarComboMeses()" & ex.Message)
        'End Try
    End Sub

    Private Sub btnBusCont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



        'If Me.tbxContr.Text <> "" Then
        '    strMenu = "3"
        '    strCodCont = Me.tbxContr.Text
        '    frmSubmenup.ShowDialog()
        '    'Me.tbxCodp.SelectAll()
        'Else
        '    strMenu = "3"
        '    frmSubmenup.ShowDialog()
        'End If




    End Sub

    Private Sub tbxContr_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)



        'If e.KeyChar = Convert.ToChar(Keys.Return) Then
        '    cmbxSta.Focus()
        '    strMenu = "3"
        '    strCodCont = Me.tbxContr.Text
        '    frmSubmenup.ShowDialog()
        '    If swMen = 1 Then
        '        Me.tbxContr.Focus()
        '    Else
        '        Me.tbxContr.SelectAll()
        '    End If


        'End If
    End Sub

    Private Sub btnBusCli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        strMenu = "4"
        frmSubmenup.ShowDialog()
    End Sub

    Private Sub btnBusCli_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            strMenu = "4"
            '   strCodCli = Me.tbxClient.Text
            frmSubmenup.ShowDialog()
            Me.tbxCodp.SelectAll()

        End If
    End Sub

    Private Sub tbpFiscal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub tbxDescr_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.cmbClas.Focus()

        End If
    End Sub


    Private Sub tbxUbi_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            f1.txtMonto.Focus()

        End If
    End Sub

    Private Sub tbxClient_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            strMenu = "4"
            strCodCli = Me.tbxClient.Text
            frmSubmenup.ShowDialog()


            If swMen = 1 Then
                Me.tbxClient.Focus()
            Else
                Me.tbxClient.SelectAll()

                Me.tbxNroCon.Focus()
            End If


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


    Private Sub txtMonto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)






        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(txtMonto.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                txtMonto.Text = decimales(txtMonto.Text) 'Format(CDec(txtMonto.Text), "C")
                e.Handled = True
                ' f1.txtCuenta.Focus()


            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            f1.txtMonto.SelectAll()
        End If

    End Sub

    Private Sub cmbxSta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If Asc(e.KeyChar) = Keys.Enter Then
            'f1.cmbTipo.Focus()
        End If


    End Sub

    Private Sub txtCuenta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        e.Handled = EnteroKey(System.Convert.ToInt16(Asc(e.KeyChar)))
        Try


            '    bolValor = Numerico(txtCuenta.Text)
            If bolValor = False Then

                If e.KeyChar = Convert.ToChar(Keys.Return) Then

                    e.Handled = True
                    '  f1.dtpFd.Focus()

                End If

            Else
                intk = 0
                MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
                'f1.txtCuenta.SelectAll()
            End If

        Catch ex As Exception

        End Try


    End Sub

    Private Sub cmbxMes_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If Asc(e.KeyChar) = Keys.Enter Then

            Me.tbxClient.Focus()

        End If
    End Sub

    Private Sub txtPercta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)



   

        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            e.Handled = True
            '  f1.dtpFechai.Focus()

        End If

         
    End Sub

    Private Sub txtEje_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            'Me.tbxResp.Focus()

        End If
    End Sub


    Private Sub cmbxResp_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then

            '  Me.txtDur.Focus()

        End If
    End Sub

    Private Sub txtDur_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        '   bolValor = Numerico(txtDur.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then

                e.Handled = True
                '   Me.cmbperPagCtas.Focus()

            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            ' Me.txtDur.SelectAll()
        End If



    End Sub

    Private Sub tbxFac_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(tbxFac.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                tbxFac.Text = decimales(tbxFac.Text)
                e.Handled = True
                f1.cmbRe10.Focus()

            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxFac.SelectAll()
        End If



    End Sub

    Private Sub tbxporcM_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(tbxAntMont.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                tbxAntMont.Text = decimales(tbxAntMont.Text)
                e.Handled = True
                Me.tbxPena.Focus()

            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxAntMont.SelectAll()
        End If


    End Sub

    Private Sub dtpFecEnt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            f1.dtpCXC.Focus()

        End If
    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        e.Handled = EnteroKey(System.Convert.ToInt16(Asc(e.KeyChar)))
        Try


            'bolValor = Numerico(tbxDiasFent.Text)
            'If bolValor = False Then

            '    If e.KeyChar = Convert.ToChar(Keys.Return) Then

            '        e.Handled = True
            '        Me.tbxDiasFentR.Focus()

            '    End If

            'Else
            '    intk = 0
            '    MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            '    Me.tbxDiasFent.SelectAll()
            'End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        e.Handled = EnteroKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        'bolValor = Numerico(tbxDiasFentR.Text)
        'If bolValor = False Then

        '    If e.KeyChar = Convert.ToChar(Keys.Return) Then

        '        e.Handled = True
        '        Me.tbxMon.Focus()

        '    End If

        'Else
        '    intk = 0
        '    MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
        '    Me.tbxDiasFentR.SelectAll()
        'End If


    End Sub

    Private Sub TextBox7_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        'bolValor = Numerico(tbxMon.Text)
        'If bolValor = False Then

        '    If e.KeyChar = Convert.ToChar(Keys.Return) Then

        '        e.Handled = True
        '        Me.tbxAd.Focus()

        '    End If

        'Else
        '    intk = 0
        '    MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
        '    Me.tbxMon.SelectAll()
        'End If


    End Sub

    Private Sub tbxAd_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.dtpFecTe.Focus()

        End If
    End Sub

    Private Sub dtpFecTe_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            f1.dtpFecPago.Focus()

        End If
    End Sub

    Private Sub tbxProcT_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            'Me.tbxDoc.Focus()

        End If
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.tbxDocNext.Focus()

        End If
    End Sub

    Private Sub tbxSca_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            'Me.dtpFecRef.Focus()

        End If
    End Sub

    Private Sub dtpFecRef_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            GuardarALLproy()
            tbcProy.SelectedTab = tbcProy.TabPages(2)

            'Me.tbxCostos.Focus()

        End If
    End Sub

    Private Sub tbxCostos_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        'bolValor = Numerico(tbxCostos.Text)
        'If bolValor = False Then

        '    If e.KeyChar = Convert.ToChar(Keys.Return) Then

        '        e.Handled = True
        '        Me.tbxAdq.Focus()

        '    End If

        'Else
        '    intk = 0
        '    MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
        '    Me.tbxCostos.SelectAll()
        'End If


    End Sub

    Private Sub tbxAdq_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)



        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            'Me.tbxMontMan.Focus()

        End If
    End Sub

    Private Sub tbxMontMan_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        'bolValor = Numerico(tbxMontMan.Text)
        'If bolValor = False Then

        '    If e.KeyChar = Convert.ToChar(Keys.Return) Then

        '        e.Handled = True
        '        Me.tbx_Montot.Focus()

        '    End If

        'Else
        '    intk = 0
        '    MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
        '    Me.tbx_Montot.SelectAll()
        'End If



    End Sub

    Private Sub tbx_Montot_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(tbx_MesEje.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then

                e.Handled = True
                f1.tbxDocNext.Focus()

            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbx_MesEje.SelectAll()
        End If


    End Sub

    Private Sub tbxPorcAn_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)


        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        'bolValor = Numerico(tbxPorcAn.Text)
        'If bolValor = False Then

        '    If e.KeyChar = Convert.ToChar(Keys.Return) Then

        '        e.Handled = True
        '        Me.tbxMont.Focus()

        '    End If

        'Else
        '    intk = 0
        '    MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
        '    Me.tbxPorcAn.SelectAll()
        'End If





    End Sub

    Private Sub tbxMont_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)


        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        'bolValor = Numerico(tbxMont.Text)
        'If bolValor = False Then

        '    If e.KeyChar = Convert.ToChar(Keys.Return) Then

        '        e.Handled = True
        '        Me.tbxRet.Focus()

        '    End If

        'Else
        '    intk = 0
        '    MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
        '    Me.tbxMont.SelectAll()
        'End If



    End Sub

    Private Sub TextBox8_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        'bolValor = Numerico(tbxRet.Text)
        'If bolValor = False Then

        '    If e.KeyChar = Convert.ToChar(Keys.Return) Then

        '        e.Handled = True
        '        Me.dtpFecR.Focus()

        '    End If

        'Else
        '    intk = 0
        '    MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
        '    Me.tbxRet.SelectAll()
        'End If



    End Sub

    Private Sub dtpFecR_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            'Me.tbxMul.Focus()

        End If
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            tbcProy.SelectedTab = tbcProy.TabPages(3)
            GuardarALLproy()

            'Me.tbxCtasoc.Focus()

        End If
    End Sub

    Private Sub TextBox10_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        'bolValor = Numerico(tbxCtasoc.Text)
        'If bolValor = False Then

        '    If e.KeyChar = Convert.ToChar(Keys.Return) Then

        '        e.Handled = True
        '        Me.tbxAds.Focus()

        '    End If

        'Else
        '    intk = 0
        '    MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
        '    Me.tbxCtasoc.SelectAll()
        'End If




    End Sub

    Private Sub TextBox14_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            'Me.tbxMtoMan.Focus()

        End If
    End Sub

    Private Sub TextBox11_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        'bolValor = Numerico(tbxMtoMan.Text)
        'If bolValor = False Then

        '    If e.KeyChar = Convert.ToChar(Keys.Return) Then

        '        e.Handled = True
        '        Me.tbxDt.Focus()

        '    End If

        'Else
        '    intk = 0
        '    MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
        '    Me.tbxMtoMan.SelectAll()
        'End If




    End Sub

    Private Sub TextBox9_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            'Me.tbxPor.Focus()

        End If
    End Sub

    Private Sub TextBox13_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        'bolValor = Numerico(tbxPor.Text)
        'If bolValor = False Then

        '    If e.KeyChar = Convert.ToChar(Keys.Return) Then

        '        e.Handled = True
        '        Me.tbxMtoAnt.Focus()

        '    End If

        'Else
        '    intk = 0
        '    MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
        '    Me.tbxPor.SelectAll()
        'End If




    End Sub





    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        If stridProy <> "" Then
            ConexionSQL()
            If FactNro <> "" Then
                insertNroFact(Me.lblid.Text, Me.tbxCodp.Text, Me.tbxNroCon.Text, Me.tbxNroReci.Text, Me.tbxNroFac.Text)
                insertNroRec(Me.lblid.Text, Me.tbxCodp.Text, Me.tbxNroCon.Text, Me.tbxNroReci.Text, Me.tbxNroFac.Text)
            End If

            FactNro = f1.tbxNroFac.Text
            RecNro = f1.tbxNroReci.Text
            ContNro = f1.tbxNroCon.Text

            GuardarALLproy()

        Else

            MsgBox("Debe ingresar un Nro de Proyecto....", MsgBoxStyle.Critical, "Control Proyectos")

        End If

    End Sub

   



    Private Sub btnGuardarC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GuardarALLproy()
    End Sub

    Private Sub tbxMulta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        GuardarALLproy()
    End Sub

    Private Sub btnGdar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GuardarALLproy()
    End Sub




    Private Sub tbxResp_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        ' txtDur.Focus()
    End Sub

    Private Sub tbxNroCon_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            If tbxNroCon.Text <> "" Then
                insertNroCont(Me.lblid.Text, Me.tbxCodp.Text, Me.tbxNroCon.Text, Me.tbxNroReci.Text, Me.tbxNroFac.Text)

                f1.tbxUbi.Focus()
            End If
        End If
    End Sub

    Private Sub dtpFd_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            'f1.dtpFH.Focus()

        End If
    End Sub

    Private Sub dtpFH_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            ' f1.tbxTraR.Focus()

        End If
    End Sub

    Private Sub tbxTraR_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        '  bolValor = Numerico(tbxTraR.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then

                e.Handled = True
                'tbxTraR.Text = decimales(tbxTraR.Text)
                'f1.dtpFechaR.Focus()

            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            '   Me.tbxTraR.SelectAll()
        End If




    End Sub

    Private Sub dtpFechaR_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            ' f1.txtInsp.Focus()
        End If
    End Sub

    Private Sub txtInsp_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        ' bolValor = Numerico(txtInsp.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then

                e.Handled = True
                ' txtInsp.Text = decimales(txtInsp.Text)
                ' f1.dtpPIns.Focus()

            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            'Me.txtInsp.SelectAll()
        End If
    End Sub

    Private Sub dtpPIns_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            '  f1.txtDur.Focus()
        End If
    End Sub

    Private Sub tbxNroRec_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            'tbcProy.SelectedTab = tbcProy.TabPages(1)
            'GuardarALLproy()
            '  f1.cmbperPagCtas.Focus()

        End If
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmbTipo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            If stridProy <> "" Then
                tbcProy.SelectedTab = tbcProy.TabPages(1)
                guardaActDPpalProy()
                Me.tbxCont.Focus()
            Else
                MsgBox("Debe ingresar un Nro de Proyecto....", MsgBoxStyle.Critical, "Control Proyectos")

            End If


        End If

    End Sub

    Private Sub tbxCont_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            swMenuPpal = 0
            strMenu = "3"
            strCodCont = f1.tbxCont.Text
            f1.tbxClient.Focus()
            ' frmSubmenup.ShowDialog()
            ' f1.tbxCont.Text = strDescCont

        End If
    End Sub

    Private Sub btnCont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        swMenuPpal = 0
        strMenu = "3"
        strCodCont = f1.tbxCont.Text
        frmSubmenup.ShowDialog()

    End Sub

    Private Sub tbxClient_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            swMenuPpal = 0
            strMenu = "4"
            strCodCli = f1.tbxClient.Text
            f1.tbxGProy.Focus()
            ' frmSubmenup.ShowDialog()
            'f1.tbxClient.Text = strDescCli

        End If
    End Sub

    Private Sub btnClient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        swMenuPpal = 0
        strMenu = "4"
        strCodCli = f1.tbxClient.Text
        frmSubmenup.ShowDialog()
        f1.tbxClient.Text = strDescCli

    End Sub

    Private Sub tbxMtoT_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(tbxMtoT.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then

                e.Handled = True
                Me.dtpFecT.Focus()

            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxMtoT.SelectAll()
        End If
    End Sub

    Private Sub tbxGProy_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.tbxIng.Focus()

        End If
    End Sub

    Private Sub tbxIng_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.tbxCorCMop.Focus()

        End If
    End Sub

    Private Sub tbxCorCMop_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.tbxGob.Focus()

        End If
    End Sub

    Private Sub tbxGob_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.tbxEncG.Focus()

        End If
    End Sub

    Private Sub tbxEncG_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            f1.tbxMtoT.Focus()

        End If
    End Sub

    Private Sub dtpFecT_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.dtpAnAnt.Focus()

        End If
    End Sub

    Private Sub dtpAnAnt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.tbxMespro.Focus()

        End If
    End Sub

    Private Sub tbxMespro_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.dtpfecTraFac1.Focus()

        End If
    End Sub

    Private Sub dtpfecTraFac_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.dtpfecTraFac.Focus()

        End If
    End Sub

    Private Sub dtpfecTraFac1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)


        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            If stridProy <> "" Then
                tbcProy.SelectedTab = tbcProy.TabPages(2)
                guardaActProyeDResp()
                f1.tbxNroFac.Focus()


            Else
                MsgBox("Debe ingresar un Nro de Proyecto....", MsgBoxStyle.Critical, "Control Proyectos")

            End If


        End If
    End Sub

    Private Sub btnGuar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If stridProy <> "" Then
            GuardarALLproy()
        Else
            MsgBox("Debe ingresar un Nro de Proyecto....", MsgBoxStyle.Critical, "Control Proyectos")

        End If
    End Sub

    Private Sub tbxNroReci_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            If tbxNroReci.Text <> "" Then
                insertNroRec(Me.lblid.Text, Me.tbxCodp.Text, Me.tbxNroCon.Text, Me.tbxNroReci.Text, Me.tbxNroFac.Text)
                guardaActProyeDFact()
                guardaActProyeDCostos()
                f1.dtpFecREC.Focus()

            End If
        End If
    End Sub



    Private Sub tbxCxC_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(tbxCxC.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                tbxCxC.Text = decimales(tbxCxC.Text)
                e.Handled = True
                Me.cmbEnInsp.Focus()

            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxCxC.SelectAll()
        End If
    End Sub

    Private Sub dtpFecPago_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            If stridProy <> "" Then

                f1.tbxNroReci.Focus()


            Else
                MsgBox("Debe ingresar un Nro de Proyecto....", MsgBoxStyle.Critical, "Control Proyectos")

            End If


        End If
    End Sub

    Private Sub tbxNroFac_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            If Me.tbxNroFac.Text <> "" Then

                FactNro = f1.tbxNroFac.Text
                RecNro = f1.tbxNroReci.Text
                ContNro = f1.tbxNroCon.Text

                insertNroFact(Me.lblid.Text, Me.tbxCodp.Text, Me.tbxNroCon.Text, Me.tbxNroReci.Text, Me.tbxNroFac.Text)

                FactNro = f1.tbxNroFac.Text
                RecNro = f1.tbxNroReci.Text
                ContNro = f1.tbxNroCon.Text

                guardaActProyeDFact()
                guardaActProyeDCostos()
                f1.dtpFecFac.Focus()

            End If
        End If

    End Sub

    Private Sub dtpFecFac_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            f1.tbxFac.Focus()
        End If
    End Sub

    Private Sub dtpFecREC_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            If stridProy <> "" Then
                tbcProy.SelectedTab = tbcProy.TabPages(3)

                f1.dtpfCheq.Focus()
            Else
                MsgBox("Debe ingresar un Nro de Proyecto....", MsgBoxStyle.Critical, "Control Proyectos")

            End If


        End If

        'If e.KeyChar = Convert.ToChar(Keys.Return) Then
        '    f1.tbxFac.Focus()
        'End If
    End Sub

    Private Sub cmbRe10_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            If cmbRe10.SelectedIndex = 2 Then
                f1.tbxAntMont.Focus()
            End If
            If cmbRe10.SelectedIndex = 1 Then
                f1.tbxMtoRet.Focus()
            End If

        End If
    End Sub

    Private Sub tbxMtoRet_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(tbxMtoRet.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then

                e.Handled = True
                f1.tbxAntMont.Focus()
            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxMtoRet.SelectAll()
        End If


    End Sub

    Private Sub tbxPena_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(tbxPena.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then

                tbxPena.Text = decimales(tbxPena.Text)
                e.Handled = True
                f1.tbxRetMtoITBMS.Focus()
            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxPena.SelectAll()
        End If


    End Sub

    Private Sub cmbEnInsp_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            If cmbEnInsp.SelectedIndex = 1 Then
                f1.dtpFecEnt.Focus()
            Else
                f1.dtpCXC.Focus()

            End If


        End If
    End Sub

    Private Sub dtpCXC_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            f1.dtpFecTe.Focus()
        End If
    End Sub

    Private Sub dtpfCheq_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            f1.tbxNroCheque.Focus()
        End If
    End Sub

    Private Sub tbxNroCheque_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        e.Handled = EnteroKey(System.Convert.ToInt16(Asc(e.KeyChar)))
        Try


            bolValor = Numerico(tbxNroCheque.Text)
            If bolValor = False Then

                If e.KeyChar = Convert.ToChar(Keys.Return) Then

                    e.Handled = True
                    f1.cmbCtrlRec.Focus()

                End If

            Else
                intk = 0
                MsgBox("Error en el Numero, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
                f1.tbxNroCheque.SelectAll()
            End If

        Catch ex As Exception

        End Try



    End Sub

    Private Sub cmbCtrlRec_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            f1.cmbCtrlCheq.Focus()
        End If
    End Sub

    Private Sub cmbCtrlCheq_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            f1.tbxMtoCxC.Focus()
        End If
    End Sub


    Private Sub tbxMtoCxC_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(f1.tbxMtoCxC.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                tbxMtoCxC.Text = decimales(tbxMtoCxC.Text)
                e.Handled = True
                f1.cmbRango1.Focus()

            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            f1.tbxMtoCxC.SelectAll()
        End If


    End Sub

    Private Sub cmbRango1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            f1.cmbRango2.Focus()
        End If
    End Sub

    Private Sub cmbRango2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            f1.cmbRango.Focus()
        End If
    End Sub

    Private Sub cmbRango_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            f1.tbxMonto2.Focus()

        End If
    End Sub

    Private Sub cmbstatus_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            f1.tbx_MesEje.Focus()
        End If
    End Sub

    Private Sub tbxSca_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            f1.tbxScafid.Focus()
        End If
    End Sub

    Private Sub tbxScafid_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            f1.dtpFecRefr.Focus()
        End If
    End Sub

    Private Sub dtpFecRefr_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            'f1.dtpFecTe.Focus()
        End If
    End Sub

    Private Sub dtpFechai_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            ' f1.dtpFfOp.Focus()
        End If
    End Sub

    Private Sub dtpFfOp_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            ' f1.cmbxSta.Focus()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If stridProy <> "" Then
            GuardarALLproy()


        Else
            MsgBox("Debe ingresar un Nro de Proyecto....", MsgBoxStyle.Critical, "Control Proyectos")

        End If
    End Sub

    Private Sub tbxMonto2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(f1.tbxMonto2.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then

                e.Handled = True
                f1.cmbstatus.Focus()

            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            f1.tbxMonto2.SelectAll()
        End If



    End Sub



    Private Sub cmbClas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        f1.tbxNroCon.Focus()

    End Sub

    Private Sub cmbTipo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If stridProy <> "" Then
            tbcProy.SelectedTab = tbcProy.TabPages(1)
            guardaActDPpalProy()
            Me.tbxCont.Focus()
        Else
            MsgBox("Debe ingresar un Nro de Proyecto....", MsgBoxStyle.Critical, "Control Proyectos")

        End If
    End Sub

    Private Sub cmbClas_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        f1.tbxNroCon.Focus()
    End Sub

    Private Sub cmbxSta_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        ' f1.cmbTipo.Focus()
    End Sub

    Private Sub cmbRe10_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        f1.tbxMtoRet.Focus()
    End Sub

    Private Sub cmbEnInsp_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        f1.dtpFecEnt.Focus()
    End Sub



    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        f1.Close()
    End Sub

    Private Sub btnNext1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        strMenu = "1"
        tbcProy.SelectedTab = tbcProy.TabPages(4)
    End Sub




    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'Try
        '    Me.P_BuscaProyectosTableAdapter.Fill(Me.Dt_proy.p_BuscaProyectos, "2", "23", "")
        'Catch ex As Exception

        'End Try

    End Sub

    Private Sub rdbtn1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    FactNro = f1.tbxNroFac.Text
        '    RecNro = f1.tbxNroReci.Text
        '    ContNro = f1.tbxNroCon.Text

        '    If FactNro <> "" And RecNro <> "" And ContNro <> "" Then


        '        Me.P_BuscaProyectosTableAdapter.Fill(Me.Dt_proy.p_BuscaProyectos, stridProy, ContNro, FactNro)
        '    Else
        '        MsgBox("Debe Seleccionar Un Proyecto", MsgBoxStyle.Exclamation)
        '    End If

        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub tdbtn2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    FactNro = f1.tbxNroFac.Text
        '    RecNro = f1.tbxNroReci.Text
        '    ContNro = f1.tbxNroCon.Text

        '    Me.P_BuscaProyectosTableAdapter.Fill(Me.Dt_proy.p_BuscaProyectos, stridProy, ContNro, "")
        'Catch ex As Exception

        'End Try
    End Sub




    Private Sub cmbRe10_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If cmbRe10.SelectedIndex = 1 Then
            f1.tbxMtoRet.Enabled = False
        Else
            f1.tbxMtoRet.Enabled = True

        End If
    End Sub

    Private Sub cmbEnInsp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If cmbEnInsp.SelectedIndex = 1 Then
            f1.dtpFecEnt.Enabled = False
        Else
            f1.dtpFecEnt.Enabled = True

        End If
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        strMenu = "1"
        tbcProy.SelectedTab = tbcProy.TabPages(2)
    End Sub

    Private Sub Button9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        strMenu = "1"
        tbcProy.SelectedTab = tbcProy.TabPages(3)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        strMenu = "1"
        tbcProy.SelectedTab = tbcProy.TabPages(3)
    End Sub

    Private Sub btnAnt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        strMenu = "1"
        tbcProy.SelectedTab = tbcProy.TabPages(1)
    End Sub



    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        strMenu = "1"
        tbcProy.SelectedTab = Me.tbcProy.TabPages(2)
    End Sub

    Private Sub tbcProy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        strTabPages = tbcProy.SelectedIndex
    End Sub


    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        frmInventarioA2.ShowDialog()
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        strTabPages = tbcProy.SelectedIndex + 1
        If strTabPages < 5 Then
            tbcProy.SelectedTab = Me.tbcProy.TabPages(strTabPages)
        End If

    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub


    Private Sub tbxCodp_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxCodp.KeyPress

        'swproy = 0

        'If e.KeyChar = Convert.ToChar(Keys.Return) Then
        '    swMenuPpal = 0
        '    strMenu = "2"
        '    strCodbus = tbxCodp.Text
        '    strCodProy = tbxCodp.Text
        '    strDescProy = tbxDescr.Text
        '    buscarProyecto()

        '    If swproy = 1 Then

        '        MsgBox("Nro de Proyecto se encuentra Registrado, por Favor Verifique")
        '        Me.tbxCodp.Text = ""
        '        Me.tbxCodp.Focus()

        '    ElseIf swproy = 2 Then
        '        Me.tbxCodp.Focus()
        '    Else
        '        ProyNro = Me.tbxCodp.Text
        '        idProyecto(1)
        '        f1.tbxDescr.Focus()
        '        ' f1.txtCuenta.Text = 1

        '    End If



        'End If


    End Sub
    Sub ValidaProy()
        Try
            swproy = 0
            swMenuPpal = 0
            strMenu = "2"
            strCodbus = tbxCodp.Text
            strCodProy = tbxCodp.Text
            strDescProy = tbxDescr.Text
            buscarProyecto()

            If swproy = 1 Then


                Me.tbxCodp.Text = ""
                Me.tbxCodp.Focus()

            ElseIf swproy = 2 Then
                Me.tbxCodp.Focus()
            Else
                ProyNro = Me.tbxCodp.Text
                idProyecto(1)
                f1.tbxDescr.Focus()
                ' f1.txtCuenta.Text = 1

            End If

        Catch ex As Exception
            MsgBox("Error en funcion ValidaProy()", MsgBoxStyle.Critical, "Control de Proyectos")
        End Try
    End Sub
    Sub buscarProyecto()
        ConexionSQL()
        Dim strBuscar As ADODB.Recordset

        Try

            If Me.tbxCodp.Text <> "" Then
                strBuscar = cntSQL.Execute("SELECT id_proyecto, Nro_proyecto, desc_Proyecto, HIST_proyecto FROM tab_idProyecto where Nro_proyecto ='" & strCodbus & "'  and id_proyecto>1 and HIST_proyecto=1")

                Do While Not strBuscar.EOF

                    swproy = 1
                    strBuscar.MoveNext()
                Loop
            Else
                swproy = 2
                MsgBox("Debe Colocar un Valor", MsgBoxStyle.Information, "Control de Proyectos")
            End If
        Catch ex As Exception
            MsgBox("Error en funcion buscarProyecto()", MsgBoxStyle.Critical, "Control de Proyectos")
        End Try
    End Sub

    Private Sub tbxDescr_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxDescr.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            If tbxDescr.Text <> "" Then
                strDescProy = Me.tbxDescr.Text

                idProyecto(1)
                cmbClas.Focus()
            Else
                MsgBox("Debo Ingresar Descripcion del Proyecto", MsgBoxStyle.Information, "Control de Proyectos")
                tbxDescr.Focus()
            End If

        End If
    End Sub

    Private Sub cmbClas_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbClas.SelectedIndexChanged
        f1.tbxNroCon.Focus()
    End Sub

    Private Sub tbxNroCon_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxNroCon.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            If tbxNroCon.Text <> "" Then
                insertNroCont(Me.lblid.Text, Me.tbxCodp.Text, Me.tbxNroCon.Text, Me.tbxNroReci.Text, Me.tbxNroFac.Text)

                f1.tbxUbi.Focus()
            End If
        End If
    End Sub

    Private Sub tbxUbi_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxUbi.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            f1.txtMonto.Focus()

        End If
    End Sub

    Private Sub txtMonto_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMonto.KeyPress
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(txtMonto.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                txtMonto.Text = decimales(txtMonto.Text) 'Format(CDec(txtMonto.Text), "C")
                e.Handled = True
                '  f1.dtpFd.Focus()


            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            f1.txtMonto.SelectAll()
        End If

    End Sub

    Private Sub txtCuenta_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = EnteroKey(System.Convert.ToInt16(Asc(e.KeyChar)))
        Try

            '
            '  bolValor = Numerico(txtCuenta.Text)
            If bolValor = False Then

                If e.KeyChar = Convert.ToChar(Keys.Return) Then

                    e.Handled = True
                    'f1.dtpFd.Focus()

                End If

            Else
                intk = 0
                MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
                ' f1.txtCuenta.SelectAll()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dtpFd_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            '   f1.dtpFH.Focus()

        End If
    End Sub

    Private Sub dtpFH_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            ' f1.tbxTraR.Focus()

        End If
    End Sub

    Private Sub tbxTraR_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        'bolValor = Numerico(tbxTraR.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then

                e.Handled = True
                '  tbxTraR.Text = decimales(tbxTraR.Text)
                ' f1.dtpFechaR.Focus()

            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            ' Me.tbxTraR.SelectAll()
        End If


    End Sub

    Private Sub dtpFechaR_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            ' f1.txtInsp.Focus()
        End If
    End Sub

    Private Sub txtInsp_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        ' bolValor = Numerico(txtInsp.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then

                e.Handled = True
                '  txtInsp.Text = decimales(txtInsp.Text)
                ' f1.dtpPIns.Focus()

            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            ' Me.txtInsp.SelectAll()
        End If
    End Sub

    Private Sub dtpPIns_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            ' f1.txtDur.Focus()
        End If
    End Sub

    Private Sub txtDur_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        '  bolValor = Numerico(txtDur.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then

                e.Handled = True
                ' Me.cmbperPagCtas.Focus()

            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            ' Me.txtDur.SelectAll()
        End If

    End Sub

    Private Sub txtPercta_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        

        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            e.Handled = True
            ' f1.dtpFechai.Focus()

        End If

         

    End Sub

    Private Sub dtpFechai_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            'f1.dtpFfOp.Focus()
        End If
    End Sub

    Private Sub dtpFfOp_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            ' f1.cmbxSta.Focus()
        End If
    End Sub


    Private Sub cmbxSta_KeyDown_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'f1.cmbTipo.Focus()
    End Sub

    Private Sub cmbTipo_KeyDown_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If stridProy <> "" Then
            tbcProy.SelectedTab = tbcProy.TabPages(1)
            '  guardaActDPpalProy()
            Me.tbxCont.Focus()
        Else
            MsgBox("Debe ingresar un Nro de Proyecto....", MsgBoxStyle.Critical, "Control Proyectos")

        End If
    End Sub

    Private Sub cmbClas_KeyDown_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbClas.KeyDown
        f1.tbxNroCon.Focus()
    End Sub

    Private Sub tbxCont_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            swMenuPpal = 0
            strMenu = "3"
            strCodCont = f1.tbxCont.Text
            f1.tbxClient.Focus()
            ' frmSubmenup.ShowDialog()
            ' f1.tbxCont.Text = strDescCont

        End If
    End Sub

    Private Sub btnCont_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        swMenuPpal = 0
        strMenu = "3"
        strCodCont = f1.tbxCont.Text
        frmSubmenup.ShowDialog()
    End Sub

    Private Sub tbxClient_KeyPress_2(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            swMenuPpal = 0
            strMenu = "4"
            strCodCli = f1.tbxClient.Text
            f1.tbxGProy.Focus()
            ' frmSubmenup.ShowDialog()
            'f1.tbxClient.Text = strDescCli

        End If
    End Sub

    Private Sub btnClient_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        swMenuPpal = 0
        strMenu = "4"
        strCodCli = f1.tbxClient.Text
        frmSubmenup.ShowDialog()
        f1.tbxClient.Text = strDescCli

    End Sub

    Private Sub tbxGProy_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.tbxIng.Focus()

        End If
    End Sub

    Private Sub tbxIng_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.tbxCorCMop.Focus()

        End If
    End Sub

    Private Sub tbxCorCMop_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.tbxGob.Focus()

        End If
    End Sub

    Private Sub tbxGob_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.tbxEncG.Focus()

        End If
    End Sub

    Private Sub tbxEncG_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            f1.tbxMtoT.Focus()

        End If
    End Sub

    Private Sub tbxMtoT_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(tbxMtoT.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                tbxMtoT.Text = decimales(tbxMtoT.Text) 'Format(CDec(txtMonto.Text), "C")
                e.Handled = True
                Me.dtpFecT.Focus()

            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxMtoT.SelectAll()
        End If
    End Sub

    Private Sub dtpFecT_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.dtpAnAnt.Focus()

        End If
    End Sub

    Private Sub dtpAnAnt_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.tbxMespro.Focus()

        End If
    End Sub

    Private Sub tbxMespro_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.dtpfecTraFac1.Focus()

        End If
    End Sub

    Private Sub dtpfecTraFac_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.dtpfecTraFac.Focus()

        End If
    End Sub

    Private Sub dtpfecTraFac1_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            If stridProy <> "" Then
                tbcProy.SelectedTab = tbcProy.TabPages(2)
                ' guardaActProyeDResp()
                f1.tbxNroFac.Focus()


            Else
                MsgBox("Debe ingresar un Nro de Proyecto....", MsgBoxStyle.Critical, "Control Proyectos")

            End If
        End If
    End Sub

    Private Sub tbxNroFac_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxNroFac.KeyPress

        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            If Me.tbxNroFac.Text <> "" And Me.tbxCodp.Text <> "" Then

                FactNro = f1.tbxNroFac.Text
                RecNro = f1.tbxNroReci.Text
                ContNro = f1.tbxNroCon.Text

                insertNroFact(Me.lblid.Text, Me.tbxCodp.Text, Me.tbxNroCon.Text, Me.tbxNroReci.Text, Me.tbxNroFac.Text)

                FactNro = f1.tbxNroFac.Text
                RecNro = f1.tbxNroReci.Text
                ContNro = f1.tbxNroCon.Text

                guardaActProyeDFact()
                guardaActProyeDCostos()
                f1.dtpFecFac.Focus()

            End If
        End If
    End Sub

    Private Sub dtpFecFac_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFecFac.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            f1.tbxFac.Focus()
        End If
    End Sub

    Private Sub tbxFac_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxFac.KeyPress
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(tbxFac.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                tbxFac.Text = decimales(tbxFac.Text)
                e.Handled = True
                f1.cmbRe10.Focus()

            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxFac.SelectAll()
        End If
    End Sub

   

    Private Sub tbxMtoRet_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxMtoRet.KeyPress
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(tbxMtoRet.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                tbxMtoRet.Text = decimales(tbxMtoRet.Text)
                e.Handled = True
                f1.tbxAntMont.Focus()
            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxMtoRet.SelectAll()
        End If
    End Sub

    Private Sub tbxAntMont_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxAntMont.KeyPress
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(tbxAntMont.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then

                tbxAntMont.Text = decimales(tbxAntMont.Text)
                e.Handled = True
                f1.tbxPena.Focus()
            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxAntMont.SelectAll()
        End If
    End Sub

    Private Sub tbxPena_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxPena.KeyPress
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(tbxPena.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then

                tbxPena.Text = decimales(tbxPena.Text)
                e.Handled = True
                f1.tbxMtoITBMS.Focus()
            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxPena.SelectAll()
        End If
    End Sub

    Private Sub tbxRetMtoITBMS_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxRetMtoITBMS.KeyPress
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(tbxRetMtoITBMS.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                tbxRetMtoITBMS.Text = decimales(tbxRetMtoITBMS.Text)
                e.Handled = True
                Me.tbxCxC.Focus()

            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxRetMtoITBMS.SelectAll()
        End If
    End Sub

   

    Private Sub tbxCxC_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxCxC.KeyPress
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(tbxCxC.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                tbxCxC.Text = decimales(tbxCxC.Text)
                e.Handled = True
                Me.cmbEnInsp.Focus()

            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxCxC.SelectAll()
        End If
    End Sub

    Private Sub cmbEnInsp_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbEnInsp.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then

          
            If cmbEnInsp.SelectedIndex = 1 Then
                f1.dtpCXC.Focus()
            End If
            If cmbEnInsp.SelectedIndex = 0 Then
                f1.dtpFecEnt.Focus()

            End If

        End If
    End Sub

   

    Private Sub cmbEnInsp_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEnInsp.SelectedIndexChanged

        If cmbEnInsp.SelectedIndex = 1 Then
            f1.dtpFecEnt.Enabled = False
        Else
            f1.dtpFecEnt.Enabled = True

        End If
    End Sub

    Private Sub dtpFecEnt_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFecEnt.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            f1.dtpCXC.Focus()

        End If
    End Sub

    Private Sub dtpCXC_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpCXC.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            f1.tbxNroReci.Focus()
        End If
    End Sub

    Private Sub dtpFecTe_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFecTe.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            f1.dtpfCheq.Focus()

        End If
    End Sub

    Private Sub dtpFecPago_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFecPago.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            If stridProy <> "" Then

                f1.dtpFecTe.Focus()


            Else
                MsgBox("Debe ingresar un Nro de Proyecto....", MsgBoxStyle.Critical, "Control Proyectos")

            End If


        End If
    End Sub

    Private Sub tbxNroReci_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxNroReci.KeyPress

        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            If tbxNroReci.Text <> "" And Me.tbxCodp.Text <> "" Then
                insertNroRec(Me.lblid.Text, Me.tbxCodp.Text, Me.tbxNroCon.Text, Me.tbxNroReci.Text, Me.tbxNroFac.Text)
                guardaActProyeDFact()
                guardaActProyeDCostos()
                f1.dtpFecREC.Focus()
            Else
                MsgBox("Debe ingresar un Nro de Recibo....", MsgBoxStyle.Critical, "Control Proyectos")

            End If
        End If
    End Sub

    Private Sub dtpFecREC_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFecREC.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            If stridProy <> "" Then
                tbcProy.SelectedTab = tbcProy.TabPages(3)

                f1.dtpFecPago.Focus()
            Else
                MsgBox("Debe ingresar un Nro de Proyecto....", MsgBoxStyle.Critical, "Control Proyectos")

            End If


        End If

    End Sub

    Private Sub dtpfCheq_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpfCheq.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            f1.tbxNroCheque.Focus()
        End If
    End Sub

    Private Sub tbxNroCheque_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxNroCheque.KeyPress
        e.Handled = EnteroKey(System.Convert.ToInt16(Asc(e.KeyChar)))
        Try


            bolValor = Numerico(tbxNroCheque.Text)
            If bolValor = False Then

                If e.KeyChar = Convert.ToChar(Keys.Return) Then
                    If Me.tbxNroFac.Text <> "" Then

                        e.Handled = True
                        Me.cmbCtrlRec.Focus()
                    Else
                        MsgBox("Campo de Factura se encuentra en blanco, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
                    End If

                End If

            Else
                intk = 0
                MsgBox("Error en el Numero, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
                Me.tbxNroCheque.SelectAll()
            End If

        Catch ex As Exception

        End Try

    End Sub

 

    Private Sub tbxMtoCxC_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxMtoCxC.KeyPress
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(f1.tbxMtoCxC.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                tbxMtoCxC.Text = decimales(tbxMtoCxC.Text)
                e.Handled = True
                f1.cmbRango1.Focus()

            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            f1.tbxMtoCxC.SelectAll()
        End If
    End Sub

    Private Sub tbxMonto2_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxMonto2.KeyPress
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(f1.tbxMonto2.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                tbxMonto2.Text = decimales(tbxMonto2.Text)
                e.Handled = True
                f1.cmbstatus.Focus()

            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            f1.tbxMonto2.SelectAll()
        End If

    End Sub

    Private Sub tbx_MesEje_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_MesEje.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            f1.tbxDocNext.Focus()
        End If
    End Sub

    Private Sub tbxDocNext_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxDocNext.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            f1.tbxScafid.Focus()
        End If
    End Sub

    Private Sub tbxScafid_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxScafid.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            f1.dtpFecRefr.Focus()
        End If
    End Sub

    

    Private Sub cmbRe10_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbRe10.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            If cmbRe10.SelectedIndex = 1 Then
                f1.tbxAntMont.Focus()
            End If
            If cmbRe10.SelectedIndex = 0 Then
                f1.tbxMtoRet.Focus()
            End If

        End If
    End Sub

    Private Sub cmbRe10_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRe10.SelectedIndexChanged
        If cmbRe10.SelectedIndex = 1 Then
            f1.tbxMtoRet.Enabled = False
        Else
            f1.tbxMtoRet.Enabled = True

        End If
    End Sub

  

    Private Sub btnG_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FactNro = f1.tbxNroFac.Text
        RecNro = f1.tbxNroReci.Text

        If stridProy <> "" Then
            ConexionSQL()
            insertNroFact(Me.lblid.Text, Me.tbxCodp.Text, Me.tbxNroCon.Text, Me.tbxNroReci.Text, Me.tbxNroFac.Text)
            insertNroRec(Me.lblid.Text, Me.tbxCodp.Text, Me.tbxNroCon.Text, Me.tbxNroReci.Text, Me.tbxNroFac.Text)
            GuardarALLproy()


        Else
            MsgBox("Debe ingresar un Nro de Proyecto....", MsgBoxStyle.Critical, "Control Proyectos")

        End If
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        strTabPages = tbcProy.SelectedIndex - 1
        If strTabPages >= 0 Then
            tbcProy.SelectedTab = Me.tbcProy.TabPages(strTabPages)
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        ValidaProy()
        If swproy = 1 Then
            MsgBox("Nro de Proyecto se encuentra Registrado, por Favor Verifique")
        Else
            'PARA VALIDAR EL PROYECTO QUE NO EXISTA
            FactNro = f1.tbxNroFac.Text
            RecNro = f1.tbxNroReci.Text

            If stridProy <> "" Then

                If Me.tbxNroCon.Text <> "" Then
                    Dim frm As New frmProcess
                    frm.Show()
                    For x As Int32 = 0 To 1
                        ContNro = Me.tbxNroCon.Text
                        GuardarALLproy()
                        'insertaDatosComplProyf1()
                        Exit For
                        Application.DoEvents()
                    Next
                    frm.Close()

                    If swguar = 0 Then
                        MsgBox("Datos Guardados....", MsgBoxStyle.Information, "Control Proyectos")
                    End If
                Else
                    MsgBox("Debe ingresar un Nro de Contrato....", MsgBoxStyle.Critical, "Control Proyectos")
                    Exit Sub
                End If

            Else
                MsgBox("Debe ingresar un Nro de Proyecto....", MsgBoxStyle.Critical, "Control Proyectos")
                Exit Sub
            End If


            clearFormularios1()
            Me.tbxCodp.Focus()


            CtaNro = 0
            ProyNro = ""
            ContNro = ""
            RecNro = ""
            FactNro = ""
            idProy = 0
            swproy = 0

        End If

       
    End Sub

    Private Sub ToolStripButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton12.Click
        Dim preg As String = ""

        If Me.tbxCodp.Text <> "" Then
            preg = MsgBox("Desea Guardar el Proyecto?", MsgBoxStyle.YesNo, "Control Proyectos")
            If preg = 6 Then
                If Me.tbxDescr.Text = "" Then
                    MsgBox("Debe colocar Descripcion", MsgBoxStyle.Information, "Control Proyectos")

                Else
                    swMenuPpal = 0
                    strMenu = "2"
                    strCodbus = tbxCodp.Text
                    strCodProy = tbxCodp.Text
                    ProyNro = Me.tbxCodp.Text
                    DescProy = Me.tbxDescr.Text
                    idProyecto(1)
                    guardaActDPpalProy()
                    Me.Close()

                End If
                swproy = 0
            Else
                cancelarEntrada()
                Me.Close()
            End If
        Else
            Me.Close()
        End If

        CtaNro = 0
        ProyNro = ""
        ContNro = ""
        RecNro = ""
        FactNro = ""
        idProy = 0
    End Sub

    
    Private Sub tbxMtoITBMS_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxMtoITBMS.KeyPress
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(tbxRetMtoITBMS.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                tbxMtoITBMS.Text = decimales(tbxMtoITBMS.Text)
                e.Handled = True
                Me.tbxRetMtoITBMS.Focus()

            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxRetMtoITBMS.SelectAll()
        End If
    End Sub

    Private Sub cmbRe10_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbRe10.KeyUp
        If cmbRe10.SelectedIndex = 2 Then
            f1.tbxAntMont.Focus()
        End If
        If cmbRe10.SelectedIndex = 1 Then
            f1.tbxMtoRet.Focus()
        End If
    End Sub

    Private Sub cmbRe10_KeyDown_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbRe10.KeyDown
        If cmbRe10.SelectedIndex = 2 Then
            f1.tbxAntMont.Focus()
        End If
        If cmbRe10.SelectedIndex = 1 Then
            f1.tbxMtoRet.Focus()
        End If
    End Sub

    Private Sub rdbtn1_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbtn1.CheckedChanged
        'Try
        '    FactNro = f1.tbxNroFac.Text
        '    RecNro = f1.tbxNroReci.Text
        '    ContNro = f1.tbxNroCon.Text

        '    If FactNro <> "" And ContNro <> "" Then


        '        Me.P_BuscaProyectosTableAdapter.Fill(Me.Dt_proy.p_BuscaProyectos, stridProy, ContNro, FactNro)

        '    End If
        '    If FactNro = "" And ContNro <> "" Then


        '        Me.P_BuscaProyectosTableAdapter.Fill(Me.Dt_proy.p_BuscaProyectos, stridProy, ContNro, FactNro)

        '    End If

        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub tdbtn2_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbtn2.CheckedChanged
        'Try
        '    FactNro = f1.tbxNroFac.Text
        '    RecNro = f1.tbxNroReci.Text
        '    ContNro = f1.tbxNroCon.Text

        '    Me.P_BuscaProyectosTableAdapter.Fill(Me.Dt_proy.p_BuscaProyectos, stridProy, ContNro, "")
        'Catch ex As Exception

        'End Try
    End Sub

    
    Private Sub cmbCtrlRec_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCtrlRec.SelectedIndexChanged
        Me.cmbCtrlRec.Focus()
    End Sub

    Private Sub cmbCtrlCheq_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCtrlCheq.SelectedIndexChanged
        Me.tbxMtoCxC.Focus()
    End Sub

    Private Sub cmbRango1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRango1.SelectedIndexChanged
        cmbRango2.Focus()
    End Sub

    Private Sub cmbRango2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRango2.SelectedIndexChanged
        cmbRango.Focus()
    End Sub

    Private Sub cmbRango_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRango.SelectedIndexChanged
        Me.tbxMonto2.Focus()
    End Sub

    Private Sub cmbstatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbstatus.SelectedIndexChanged

        tbx_MesEje.Focus()

    End Sub

    Private Sub cmbCtrlRec_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbCtrlRec.KeyUp
        Me.cmbCtrlCheq.Focus()
    End Sub

    Private Sub cmbCtrlCheq_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbCtrlCheq.KeyUp
        Me.tbxMtoCxC.Focus()
    End Sub

    Private Sub cmbRango1_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbRango1.KeyUp
        cmbRango2.Focus()
    End Sub

    Private Sub cmbRango2_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbRango2.KeyUp
        cmbRango.Focus()
    End Sub

    Private Sub cmbRango_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbRango.KeyUp
        Me.tbxMonto2.Focus()
    End Sub

   
    Private Sub ToolStripButton2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
      

        cancelarEntrada()

        CtaNro = 0
        ProyNro = ""
        ContNro = ""
        RecNro = ""
        FactNro = ""
        idProy = 0

    End Sub
    Sub cancelarEntrada()
        ConexionSQL()
        Try
            Dim strId As New ADODB.Recordset
            strId = cntSQL.Execute("select * from [tab_idProyecto] where Nro_proyecto='" & ProyNro & "'")


            Do While Not strId.EOF
                cntSQL.Execute("delete from [tab_idProyecto] where Nro_proyecto='" & ProyNro & "'")

                Exit Do
            Loop
            strId.Close()
            strId = Nothing

            ConexionSQL()
            Dim strnro As New ADODB.Recordset
            strnro = cntSQL.Execute("SELECT * FROM [tab_NrosReciboProy] where nro_proyecto='" & ProyNro & "'")


            Do While Not strnro.EOF
                cntSQL.Execute("DELETE FROM [tab_NrosReciboProy] where nro_proyecto='" & ProyNro & "'")

                Exit Do
            Loop
            clearDPpal()

            strnro.Close()
            strnro = Nothing


            Me.lblid.Text = ""
          
        Catch ex As Exception
            MsgBox("Error en funcion ToolStripButton2" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub

    Private Sub txtMonto_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMonto.Leave
        bolValor = Numerico(txtMonto.Text)
        If bolValor = False Then

            txtMonto.Text = decimales(txtMonto.Text) 'Format(CDec(txtMonto.Text), "C")

            '  Me.txtCuenta.Focus()
        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.txtMonto.SelectAll()
        End If
    End Sub

  
    Private Sub tbxTraR_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
        ' bolValor = Numerico(tbxTraR.Text)
        If bolValor = False Then




            ' tbxTraR.Text = decimales(tbxTraR.Text)
            ' f1.dtpFechaR.Focus()



        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            ' Me.tbxTraR.SelectAll()
        End If
    End Sub

    Private Sub txtInsp_Leave(ByVal sender As Object, ByVal e As System.EventArgs)


        '  bolValor = Numerico(txtInsp.Text)
        If bolValor = False Then


            ' txtInsp.Text = decimales(txtInsp.Text)
            ' f1.dtpPIns.Focus()



        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            ' Me.txtInsp.SelectAll()
        End If
    End Sub

  

    Private Sub tbxMtoT_Leave(ByVal sender As Object, ByVal e As System.EventArgs)


        bolValor = Numerico(tbxMtoT.Text)
        If bolValor = False Then


            tbxMtoT.Text = decimales(tbxMtoT.Text) 'Format(CDec(txtMonto.Text), "C")

            Me.dtpFecT.Focus()



        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxMtoT.SelectAll()
        End If
    End Sub

    Private Sub tbxFac_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbxFac.Leave
        
        bolValor = Numerico(tbxFac.Text)
        If bolValor = False Then


            tbxFac.Text = decimales(tbxFac.Text)

            f1.cmbRe10.Focus()



        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxFac.SelectAll()
        End If
    End Sub

    Private Sub tbxMtoRet_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbxMtoRet.Leave
       
        bolValor = Numerico(tbxMtoRet.Text)
        If bolValor = False Then


            tbxMtoRet.Text = decimales(tbxMtoRet.Text)

            f1.tbxAntMont.Focus()


        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxMtoRet.SelectAll()
        End If
    End Sub

    Private Sub tbxAntMont_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbxAntMont.Leave


        bolValor = Numerico(tbxAntMont.Text)
        If bolValor = False Then



            tbxAntMont.Text = decimales(tbxAntMont.Text)

            f1.tbxPena.Focus()


        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxAntMont.SelectAll()
        End If
    End Sub

    Private Sub tbxPena_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbxPena.Leave
       
        bolValor = Numerico(tbxPena.Text)
        If bolValor = False Then



            tbxPena.Text = decimales(tbxPena.Text)

            f1.tbxMtoITBMS.Focus()


        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxPena.SelectAll()
        End If
    End Sub

    Private Sub tbxMtoITBMS_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbxMtoITBMS.Leave


        bolValor = Numerico(tbxRetMtoITBMS.Text)
        If bolValor = False Then


            tbxMtoITBMS.Text = decimales(tbxMtoITBMS.Text)

            Me.tbxRetMtoITBMS.Focus()



        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxRetMtoITBMS.SelectAll()
        End If
    End Sub

    Private Sub tbxRetMtoITBMS_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbxRetMtoITBMS.Leave


        bolValor = Numerico(tbxRetMtoITBMS.Text)
        If bolValor = False Then


            tbxRetMtoITBMS.Text = decimales(tbxRetMtoITBMS.Text)

            Me.tbxCxC.Focus()

       
        Else
        intk = 0
        MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
        Me.tbxRetMtoITBMS.SelectAll()
        End If
    End Sub

    Private Sub tbxCxC_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbxCxC.Leave


        bolValor = Numerico(tbxCxC.Text)
        If bolValor = False Then


            tbxCxC.Text = decimales(tbxCxC.Text)

            Me.cmbEnInsp.Focus()



        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxCxC.SelectAll()
        End If
    End Sub

    Private Sub tbxMtoCxC_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbxMtoCxC.Leave


        bolValor = Numerico(f1.tbxMtoCxC.Text)
        If bolValor = False Then


            tbxMtoCxC.Text = decimales(tbxMtoCxC.Text)

            f1.cmbRango1.Focus()



        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            f1.tbxMtoCxC.SelectAll()
        End If
    End Sub

   

  
    Private Sub tbxNroCheque_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbxNroCheque.Leave
        If Me.tbxNroFac.Text <> "" Then


            Me.cmbCtrlRec.Focus()
        Else
            MsgBox("Campo de Factura se encuentra en blanco, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
        End If
    End Sub

  

    
  
    Private Sub btnCont_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCont.Click
        swMenuPpal = 1
        strMenu = "3"
        strCodCont = f1.tbxCont.Text
        frmSubmenup.ShowDialog()
    End Sub

    Private Sub btnClient_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClient.Click
        swMenuPpal = 1
        strMenu = "4"
        strCodCli = f1.tbxClient.Text
        frmSubmenup.ShowDialog()
        f1.tbxClient.Text = strCodCli
    End Sub

    Private Sub tbxMtoT_KeyPress_2(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxMtoT.KeyPress
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(tbxMtoT.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                tbxMtoT.Text = decimales(tbxMtoT.Text) 'Format(CDec(txtMonto.Text), "C")
                e.Handled = True
                Me.dtpFecT.Focus()

            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxMtoT.SelectAll()
        End If
    End Sub

    Private Sub tbxMtoT_Leave_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbxMtoT.Leave


        bolValor = Numerico(tbxMtoT.Text)
        If bolValor = False Then

            tbxMtoT.Text = decimales(tbxMtoT.Text) 'Format(CDec(txtMonto.Text), "C")
            Me.dtpFecT.Focus()



        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxMtoT.SelectAll()
        End If
    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        frmInventarioA2.ShowDialog()
    End Sub


    Private Sub tbxGProy_KeyPress_2(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxGProy.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            swMenuPpal = 0
            strMenu = "4"
            strCodCli = f1.tbxClient.Text
            f1.tbxIng.Focus()
            

        End If
    End Sub

  

    Private Sub tbxIng_KeyPress_2(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxIng.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.tbxCorCMop.Focus()

        End If
    End Sub

    Private Sub tbxCorCMop_KeyPress_2(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxCorCMop.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.tbxGob.Focus()

        End If
    End Sub

    Private Sub tbxGob_KeyPress_2(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxGob.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.tbxEncG.Focus()

        End If
    End Sub

    Private Sub tbxEncG_KeyPress_2(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxEncG.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.tbxMtoT.Focus()

        End If
    End Sub

    Private Sub dtpFecT_KeyPress_2(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFecT.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.dtpAnAnt.Focus()

        End If
    End Sub

    Private Sub dtpAnAnt_KeyPress_2(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpAnAnt.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.tbxMespro.Focus()

        End If
    End Sub

    Private Sub tbxMespro_KeyPress_2(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxMespro.KeyPress

        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.dtpfecTraFac.Focus()

        End If
    End Sub

    Private Sub dtpfecTraFac_KeyPress_2(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpfecTraFac.KeyPress

        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.dtpfecTraFac1.Focus()

        End If
    End Sub

    Private Sub dtpfecTraFac1_KeyPress_2(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpfecTraFac1.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.tbxAnalista.Focus()

        End If
    End Sub

    Private Sub cmbperPagCtas_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'If cmbperPagCtas.SelectedIndex <> -1 Then
        '    dtpFechai.Focus()

        'End If
    End Sub

   
   
   
    Private Sub ToolStripButton3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click

        If ProyNro <> "" Then
            swMenuPpal = 1
            'gpbDatppl.Enabled = True
            frmNroctaproy.ShowDialog()
        Else
            MsgBox("Debe seleccionar un proyecto ", MsgBoxStyle.Information, "Control Proyectos")
        End If



    End Sub
    Public Function insertNroCuenta(ByVal id As Decimal, ByVal NroProy As String, ByVal NroCont As String)
        ConexionSQL()
        Dim sw As Integer = 0
        Try
            Dim strNro As New ADODB.Recordset

            Dim i As Integer = 1
            Dim preg As String = ""
            'si no existe los datos del nro proyecto y el nro de contrato
            Dim strcta As New ADODB.Recordset

            strNro = cntSQL.Execute("SELECT pro_nroCuenta, pro_idProyecto ,pro_nroProyecto ,pro_nroContrato FROM tab_DatosPpalProy_Compl where pro_nroProyecto ='" & NroProy & "' and pro_nroContrato='" & NroCont & "' ")


            If strNro.EOF = True Then

                preg = MsgBox("Nuevo Nro de Cuenta, desea Insertar ??? ", MsgBoxStyle.YesNo)

                If preg = 6 Then
                    clearComplDppal()

                    strcta = cntSQL.Execute("SELECT max(pro_nroCuenta) as cta_Nro FROM tab_DatosPpalProy_Compl where pro_nroProyecto ='" & NroProy & "' and pro_nroContrato='" & NroCont & "' ")

                    If strcta.EOF = False Then
                        If strcta.Fields("cta_Nro").Value Is DBNull.Value Then
                            i = 1
                        Else
                            i = i + Val(strcta.Fields("cta_Nro").Value)
                        End If
                    End If

                End If
                CtaNro = i
            Else


                preg = MsgBox("Nuevo Nro de Cuenta, desea Insertar ??? ", MsgBoxStyle.YesNo)

                If preg = 6 Then
                    clearComplDppal()
                    strcta = cntSQL.Execute("SELECT max(pro_nroCuenta) as cta_Nro FROM tab_DatosPpalProy_Compl where pro_nroProyecto ='" & NroProy & "' and pro_nroContrato='" & NroCont & "' ")

                    If strcta.EOF = False Then
                        If strcta.Fields("cta_Nro").Value Is DBNull.Value Then
                            i = 1
                        Else
                            i = i + Val(strcta.Fields("cta_Nro").Value)
                        End If
                    End If

                End If
                CtaNro = i

            End If
            ContNro = NroCont

        Catch ex As Exception
            MsgBox("Error en funcion insertNroCuenta" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try


        Return CtaNro


    End Function

    Private Sub ToolStripButton6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        Try
            Dim preg As String
            Dim strDel As ADODB.Recordset
            If Me.tbxCodp.Text <> "" Then
                preg = MsgBox("Seguro que desea eliminar el proyecto " & Me.tbxCodp.Text, MsgBoxStyle.YesNo, "Control Proyectos")

                If preg = 6 Then
                    ConexionSQL()
                    strDel = cntSQL.Execute("p_eliminaProyectos '" & Me.tbxCodp.Text & "'")
                    MsgBox("Proyecto Eliminado", MsgBoxStyle.Information, "Control Proyectos")
                    clearFormularios1()
                End If


            End If

        Catch ex As Exception
            MsgBox("Error al eliminar proyecto" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")

        End Try
    End Sub


End Class
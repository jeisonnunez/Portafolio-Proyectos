Public Class frmMenuProyectoConsulta
    Public strTabPages As Integer = 1
    Public swTab As Integer = 0



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        strMenu = "1"
        tbcProy.SelectedTab = tbcProy.TabPages(1)


    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

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

    'Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    'If me.tbxCodp.Text <> "" Then
    '    swMenuPpal = 0
    '    strMenu = "2"
    '    strCodbus = Me.tbxCodp.Text
    '    frmSubmenup.ShowDialog()
    '    me.tbxDescr.Focus()
    '    ' Else
    '    ' MsgBox("Debe Insertar un Registro", MsgBoxStyle.Critical, "Control Proyectos")
    '    'End If


    'End Sub

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



   

    Private Sub tbxCodp_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            swMenuPpal = 0
            strMenu = "2"
            strCodbus = tbxCodp.Text
            frmSubmenup.ShowDialog()
            Me.cmbClas.Focus()

        End If
    End Sub


    Private Sub frmMenuProyecto_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.DataTable2' Puede moverla o quitarla según sea necesario.
        Me.DataTable2TableAdapter.Fill(Me.DataSet1.DataTable2)
        CtaNro = 0
        ProyNro = ""
        ContNro = ""
        RecNro = ""
        FactNro = ""
        idProy = 0
        swMenuPpal = 0
        ConexionSQL()
        Me.tbxCodp.Focus()
        llenarComboStatus()
        llenarComboTipo()
        llenarComboSector()
        llenarComboMeses()
        llenarComboRecibo()
        llenarComboCheque()
        llenarComboRango()
        llenarComboSta()
       

    End Sub
    'Sub llenarCombost()
    '    Try
    '        ConexionSQL()
    '        Dim strSector As New ADODB.Recordset
    '        Me.cmbStatus.Items.Clear()

    '        strSector = cntSQL.Execute("SELECT  des_Status FROM [dbo].[tab_Status]")

    '        Do While Not strSector.EOF
    '            Me.cmbStatus.Items.Add(strSector.Fields(0).Value)

    '            strSector.MoveNext()
    '        Loop


    '    Catch ex As Exception
    '        MsgBox("Error en funcion llenarCombost" & ex.Message)
    '    End Try
    'End Sub
    Sub llenarComboRango()
        Try
            Dim strRango As New ADODB.Recordset
            'Me.cmbRango.Items.Clear()
            'Me.cmbRango1.Items.Clear()
            'Me.cmbRango2.Items.Clear()

            strRango = cntSQL.Execute("SELECT des_Rango FROM [dbo].[tab_Rango]")

            Do While Not strRango.EOF
                'Me.cmbRango.Items.Add(strRango.Fields(0).Value)
                'Me.cmbRango1.Items.Add(strRango.Fields(0).Value)
                'Me.cmbRango2.Items.Add(strRango.Fields(0).Value)
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
                'Me.cmbCtrlCheq.Items.Add(strCheq.Fields(0).Value)

                strCheq.MoveNext()
            Loop


        Catch ex As Exception
            MsgBox("Error en funcion llenarComboCheque()" & ex.Message)
        End Try
    End Sub
    Sub llenarComboRecibo()
        Try
            Dim strRec As New ADODB.Recordset


            strRec = cntSQL.Execute("SELECT des_CtrlRecibo FROM [dbo].[tab_CtrlRecibo]")

            Do While Not strRec.EOF
                '  Me.cmbCtrlRec1.Items.Add(strRec.Fields(0).Value)

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
            Me.cmbTp.Items.Clear()

            strTipo = cntSQL.Execute("SELECT  [des_tipo] FROM [dbo].[tab_Tipo]")

            Do While Not strTipo.EOF
                Me.cmbTp.Items.Add(strTipo.Fields(0).Value)

                strTipo.MoveNext()
            Loop


        Catch ex As Exception
            MsgBox("Error en funcion llenarComboTipo" & ex.Message)
        End Try
    End Sub
    Sub llenarCombocmbEnInsp()
        Try
            Dim strseleccion As New ADODB.Recordset
            ' Me.cmbEnInsp1.Items.Clear()

            strseleccion = cntSQL.Execute("SELECT [descripcion] FROM tab_seleccionSimple")

            Do While Not strseleccion.EOF
                ' Me.cmbEnInsp1.Items.Add(strseleccion.Fields(0).Value)

                strseleccion.MoveNext()
            Loop


        Catch ex As Exception
            MsgBox("Error en funcion llenarCombocmbEnInsp" & ex.Message)
        End Try
    End Sub

    Sub llenarCombocmbRe10()
        Try
            Dim strseleccion As New ADODB.Recordset
            '  Me.cmbRe10.Items.Clear()

            strseleccion = cntSQL.Execute("SELECT  [descripcion] FROM tab_seleccionSimple")

            Do While Not strseleccion.EOF
                ' Me.cmbRe10.Items.Add(strseleccion.Fields(0).Value)

                strseleccion.MoveNext()
            Loop


        Catch ex As Exception
            MsgBox("Error en funcion llenarCombocmbRe10" & ex.Message)
        End Try
    End Sub
    Sub llenarComboSta()
        Try
            Dim strSector As New ADODB.Recordset
            Me.cmbStatus.Items.Clear()

            strSector = cntSQL.Execute("SELECT  rtrim(ltrim([des_Status])) FROM [dbo].[tab_Status_Cuentas]")

            Do While Not strSector.EOF
                Me.cmbStatus.Items.Add(strSector.Fields(0).Value)

                strSector.MoveNext()
            Loop


        Catch ex As Exception
            MsgBox("Error en funcion llenarComboStatus" & ex.Message)
        End Try
    End Sub

    Sub llenarComboStatus()
        Try
            Dim strSector As New ADODB.Recordset
            Me.cmbSt.Items.Clear()

            strSector = cntSQL.Execute("SELECT  [des_Status] FROM [dbo].[tab_Status]")

            Do While Not strSector.EOF
                Me.cmbSt.Items.Add(strSector.Fields(0).Value)

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
            strCodCli = Me.tbxCliente.Text
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


            Me.txtMonto.Focus()

        End If
    End Sub

    Private Sub tbxClient_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            strMenu = "4"
            strCodCli = Me.tbxCliente.Text
            frmSubmenup.ShowDialog()


            If swMen = 1 Then
                Me.tbxCliente.Focus()
            Else
                Me.tbxCliente.SelectAll()

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
                Me.txtCuenta1.Focus()


            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.txtMonto.SelectAll()
        End If

    End Sub

    Private Sub cmbxSta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If Asc(e.KeyChar) = Keys.Enter Then
            '  Me.cmbTipo1.Focus()
        End If


    End Sub

    Private Sub txtCuenta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        e.Handled = EnteroKey(System.Convert.ToInt16(Asc(e.KeyChar)))
        Try


            bolValor = Numerico(txtCuenta1.Text)
            If bolValor = False Then

                If e.KeyChar = Convert.ToChar(Keys.Return) Then

                    e.Handled = True
                    Me.dtpFd1.Focus()

                End If

            Else
                intk = 0
                MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
                Me.txtCuenta1.SelectAll()
            End If

        Catch ex As Exception

        End Try


    End Sub

    Private Sub cmbxMes_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If Asc(e.KeyChar) = Keys.Enter Then

            Me.tbxCliente.Focus()

        End If
    End Sub

    Private Sub txtPercta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)


       

        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            e.Handled = True
            ' Me.dtpFechai1.Focus()

        End If

       

    End Sub

    Private Sub txtEje_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            'Me.tbxResp.Focus()

        End If
    End Sub


    Private Sub cmbxResp_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then

            '  Me.txtDur1.Focus()

        End If
    End Sub

    Private Sub txtDur_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        'e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        'bolValor = Numerico(txtDur1.Text)
        'If bolValor = False Then

        '    If e.KeyChar = Convert.ToChar(Keys.Return) Then

        '        e.Handled = True
        '        Me.cmbperPagCtas1.Focus()

        '    End If

        'Else
        '    intk = 0
        '    MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
        '    Me.txtDur1.SelectAll()
        'End If



    End Sub

    Private Sub tbxFac_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        'bolValor = Numerico(tbxFac1.Text)
        'If bolValor = False Then

        '    If e.KeyChar = Convert.ToChar(Keys.Return) Then
        '        tbxFac1.Text = decimales(tbxFac1.Text)
        '        e.Handled = True
        '        '   Me.cmbRe10.Focus()

        '    End If

        'Else
        '    intk = 0
        '    MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
        '    Me.tbxFac1.SelectAll()
        'End If



    End Sub

    Private Sub tbxporcM_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        ' bolValor = Numerico(tbxAntMont1.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                ' tbxAntMont1.Text = decimales(tbxAntMont1.Text)
                e.Handled = True
                '  Me.tbxPena1.Focus()

            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            ' Me.tbxAntMont1.SelectAll()
        End If


    End Sub

    Private Sub dtpFecEnt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            '  Me.dtpCXC1.Focus()

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


            '  Me.dtpFecTe1.Focus()

        End If
    End Sub

    Private Sub dtpFecTe_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            ' Me.dtpFecPago.Focus()

        End If
    End Sub

    Private Sub tbxProcT_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            'Me.tbxDoc.Focus()

        End If
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            'Me.tbxDocNext.Focus()

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

        'bolValor = Numerico(tbx_MesEje.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then

                e.Handled = True
                '  Me.tbxDocNext.Focus()

            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            ' Me.tbx_MesEje.SelectAll()
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
                ' insertNroFact(Me.lblid.Text, Me.tbxCodp.Text, Me.tbxNroCon.Text, Me.tbxNroReci1.Text, Me.tbxNroFac.Text)
                ' insertNroRec(Me.lblid.Text, Me.tbxCodp.Text, Me.tbxNroCon.Text, Me.tbxNroReci.Text, Me.tbxNroFac.Text)
            End If

            '  FactNro = Me.tbxNroFac1.Text
            ' RecNro = Me.tbxNroReci1.Text
            ContNro = Me.tbxNroCon.Text

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
        'txtDur1.Focus()
    End Sub

    Private Sub tbxNroCon_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            If tbxNroCon.Text <> "" Then
                '   insertNroCont(Me.lblid.Text, Me.tbxCodp.Text, Me.tbxNroCon.Text, Me.tbxNroReci.Text, Me.tbxNroFac.Text)

                Me.tbxUbi.Focus()
            End If
        End If
    End Sub

    Private Sub dtpFd_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.dtpFH1.Focus()

        End If
    End Sub

    Private Sub dtpFH_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.tbxTraR1.Focus()

        End If
    End Sub

    Private Sub tbxTraR_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(tbxTraR1.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then

                e.Handled = True
                tbxTraR1.Text = decimales(tbxTraR1.Text)
                Me.dtpFechaR1.Focus()

            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxTraR1.SelectAll()
        End If




    End Sub

    Private Sub dtpFechaR_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            Me.txtInsp1.Focus()
        End If
    End Sub

    Private Sub txtInsp_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(txtInsp1.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then

                e.Handled = True
                txtInsp1.Text = decimales(txtInsp1.Text)
                Me.dtpPIns1.Focus()

            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.txtInsp1.SelectAll()
        End If
    End Sub

    Private Sub dtpPIns_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            '  Me.txtDur1.Focus()
        End If
    End Sub

    Private Sub tbxNroRec_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            'tbcProy.SelectedTab = tbcProy.TabPages(1)
            'GuardarALLproy()
            ' Me.cmbperPagCtas1.Focus()

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
            strCodCont = Me.tbxCont.Text
            Me.tbxCliente.Focus()
            ' frmSubmenup.ShowDialog()
            ' me.tbxCont.Text = strDescCont

        End If
    End Sub

    Private Sub btnCont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        swMenuPpal = 0
        strMenu = "3"
        strCodCont = Me.tbxCont.Text
        frmSubmenup.ShowDialog()

    End Sub

    Private Sub tbxClient_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            swMenuPpal = 0
            strMenu = "4"
            strCodCli = Me.tbxCliente.Text
            Me.tbxGProy.Focus()
            ' frmSubmenup.ShowDialog()
            'me.tbxClient.Text = strDescCli

        End If
    End Sub

    Private Sub btnClient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        swMenuPpal = 0
        strMenu = "4"
        strCodCli = Me.tbxCliente.Text
        frmSubmenup.ShowDialog()
        Me.tbxCliente.Text = strDescCli

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


            Me.tbxMtoT.Focus()

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


            Me.dtpfecTraFac.Focus()

        End If
    End Sub

    Private Sub dtpfecTraFac_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.dtpfecTraFac1.Focus()

        End If
    End Sub

    Private Sub dtpfecTraFac1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)


        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            If stridProy <> "" Then
                tbcProy.SelectedTab = tbcProy.TabPages(2)
                guardaActProyeDResp()
                '  Me.tbxNroFac.Focus()


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
            ''  If tbxNroReci.Text <> "" Then
            'insertNroRec(Me.lblid.Text, Me.tbxCodp.Text, Me.tbxNroCon.Text, Me.tbxNroReci.Text, Me.tbxNroFac.Text)
            'guardaActProyeDFact()
            'guardaActProyeDCostos()
            'Me.dtpFecREC.Focus()

            ' End If
        End If
    End Sub



    Private Sub tbxCxC_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        'bolValor = Numerico(tbxCxC.Text)
        'If bolValor = False Then

        '    If e.KeyChar = Convert.ToChar(Keys.Return) Then
        '        tbxCxC.Text = decimales(tbxCxC.Text)
        '        e.Handled = True
        '        Me.cmbEnInsp.Focus()

        '    End If

        'Else
        '    intk = 0
        '    MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
        '    Me.tbxCxC.SelectAll()
        'End If
    End Sub

    Private Sub dtpFecPago_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            If stridProy <> "" Then

                'Me.tbxNroReci.Focus()


            Else
                MsgBox("Debe ingresar un Nro de Proyecto....", MsgBoxStyle.Critical, "Control Proyectos")

            End If


        End If
    End Sub

    Private Sub tbxNroFac_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            'If Me.tbxNroFac.Text <> "" Then

            '    FactNro = Me.tbxNroFac.Text
            '    RecNro = Me.tbxNroReci.Text
            '    ContNro = Me.tbxNroCon.Text

            '    insertNroFact(Me.lblid.Text, Me.tbxCodp.Text, Me.tbxNroCon.Text, Me.tbxNroReci.Text, Me.tbxNroFac.Text)

            '    FactNro = Me.tbxNroFac.Text
            '    RecNro = Me.tbxNroReci.Text
            '    ContNro = Me.tbxNroCon.Text

            '    guardaActProyeDFact()
            '    guardaActProyeDCostos()
            '    Me.dtpFecFac.Focus()

            'End If
        End If

    End Sub

    Private Sub dtpFecFac_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            ' Me.tbxFac1.Focus()
        End If
    End Sub

    Private Sub dtpFecREC_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            If stridProy <> "" Then
                tbcProy.SelectedTab = tbcProy.TabPages(3)

                '  Me.dtpfCheq.Focus()
            Else
                MsgBox("Debe ingresar un Nro de Proyecto....", MsgBoxStyle.Critical, "Control Proyectos")

            End If


        End If

        'If e.KeyChar = Convert.ToChar(Keys.Return) Then
        '    me.tbxFac.Focus()
        'End If
    End Sub

    Private Sub cmbRe10_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            'If cmbRe10.SelectedIndex = 2 Then
            '    Me.tbxAntMont.Focus()
            'End If
            'If cmbRe10.SelectedIndex = 1 Then
            '    Me.tbxMtoRet.Focus()
            'End If

        End If
    End Sub

    Private Sub tbxMtoRet_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        'bolValor = Numerico(tbxMtoRet1.Text)
        'If bolValor = False Then

        '    If e.KeyChar = Convert.ToChar(Keys.Return) Then

        '        e.Handled = True
        '        Me.tbxAntMont.Focus()
        '    End If

        'Else
        '    intk = 0
        '    MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
        '    Me.tbxMtoRet.SelectAll()
        'End If


    End Sub

    Private Sub tbxPena_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        'bolValor = Numerico(tbxPena.Text)
        'If bolValor = False Then

        '    If e.KeyChar = Convert.ToChar(Keys.Return) Then

        '        tbxPena.Text = decimales(tbxPena.Text)
        '        e.Handled = True
        '        Me.tbxRetMtoITBMS.Focus()
        '    End If

        'Else
        '    intk = 0
        '    MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
        '    Me.tbxPena.SelectAll()
        'End If


    End Sub

    Private Sub cmbEnInsp_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            'If cmbEnInsp.SelectedIndex = 1 Then
            '    Me.dtpFecEnt.Focus()
            'Else
            '    Me.dtpCXC.Focus()

            'End If


        End If
    End Sub

    Private Sub dtpCXC_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            'Me.dtpFecTe.Focus()
        End If
    End Sub

    Private Sub dtpfCheq_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            ' Me.tbxNroCheque.Focus()
        End If
    End Sub

    Private Sub tbxNroCheque_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        e.Handled = EnteroKey(System.Convert.ToInt16(Asc(e.KeyChar)))
        Try


            'bolValor = Numerico(tbxNroCheque.Text)
            'If bolValor = False Then

            '    If e.KeyChar = Convert.ToChar(Keys.Return) Then

            '        e.Handled = True
            '        Me.cmbCtrlRec.Focus()

            '    End If

            'Else
            '    intk = 0
            '    MsgBox("Error en el Numero, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            '    Me.tbxNroCheque.SelectAll()
            'End If

        Catch ex As Exception

        End Try



    End Sub

    Private Sub cmbCtrlRec_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            'Me.cmbCtrlCheq.Focus()
        End If
    End Sub

    Private Sub cmbCtrlCheq_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            'Me.tbxMtoCxC.Focus()
        End If
    End Sub


    Private Sub tbxMtoCxC_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        'bolValor = Numerico(Me.tbxMtoCxC.Text)
        'If bolValor = False Then

        '    If e.KeyChar = Convert.ToChar(Keys.Return) Then
        '        tbxMtoCxC.Text = decimales(tbxMtoCxC.Text)
        '        e.Handled = True
        '        Me.cmbRango1.Focus()

        '    End If

        'Else
        '    intk = 0
        '    MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
        '    Me.tbxMtoCxC.SelectAll()
        'End If


    End Sub

    Private Sub cmbRango1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            ' Me.cmbRango2.Focus()
        End If
    End Sub

    Private Sub cmbRango2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            ' Me.cmbRango.Focus()
        End If
    End Sub

    Private Sub cmbRango_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            ' Me.tbxMonto2.Focus()

        End If
    End Sub

    Private Sub cmbstatus_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            '  Me.tbx_MesEje.Focus()
        End If
    End Sub

    Private Sub tbxSca_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            '  Me.tbxScafid.Focus()
        End If
    End Sub

    Private Sub tbxScafid_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            '  Me.dtpFecRefr1.Focus()
        End If
    End Sub

    Private Sub dtpFecRefr_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            'me.dtpFecTe.Focus()
        End If
    End Sub

    Private Sub dtpFechai_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            ' Me.dtpFfOp.Focus()
        End If
    End Sub

    Private Sub dtpFfOp_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            ' Me.cmbxSta.Focus()
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

        'bolValor = Numerico(Me.tbxMonto2.Text)
        'If bolValor = False Then

        '    If e.KeyChar = Convert.ToChar(Keys.Return) Then

        '        e.Handled = True
        '        Me.cmbstatus.Focus()

        '    End If

        'Else
        '    intk = 0
        '    MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
        '    Me.tbxMonto2.SelectAll()
        'End If



    End Sub



    Private Sub cmbClas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.tbxNroCon.Focus()

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
        Me.tbxNroCon.Focus()
    End Sub

    Private Sub cmbxSta_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        ' Me.cmbTipo.Focus()
    End Sub

    Private Sub cmbRe10_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        '  Me.tbxMtoRet.Focus()
    End Sub

    Private Sub cmbEnInsp_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        ' Me.dtpFecEnt.Focus()
    End Sub



    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnNext1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        strMenu = "1"
        tbcProy.SelectedTab = tbcProy.TabPages(4)
    End Sub




    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try
            Me.P_BuscaProyectosTableAdapter.Fill(Me.Dt_proy.p_BuscaProyectos, "2", "23", "")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub rdbtn1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            'FactNro = Me.tbxNroFac.Text
            'RecNro = Me.tbxNroReci.Text
            ContNro = Me.tbxNroCon.Text

            If FactNro <> "" And RecNro <> "" And ContNro <> "" Then


                Me.P_BuscaProyectosTableAdapter.Fill(Me.Dt_proy.p_BuscaProyectos, stridProy, ContNro, FactNro)
            Else
                MsgBox("Debe Seleccionar Un Proyecto", MsgBoxStyle.Exclamation)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub tdbtn2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            'FactNro = Me.tbxNroFac.Text
            'RecNro = Me.tbxNroReci.Text
            ContNro = Me.tbxNroCon.Text

            Me.P_BuscaProyectosTableAdapter.Fill(Me.Dt_proy.p_BuscaProyectos, stridProy, ContNro, "")
        Catch ex As Exception

        End Try
    End Sub




    Private Sub cmbRe10_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If cmbRe10.SelectedIndex = 1 Then
        '    Me.tbxMtoRet.Enabled = False
        'Else
        '    Me.tbxMtoRet.Enabled = True

        'End If
    End Sub

    Private Sub cmbEnInsp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If cmbEnInsp.SelectedIndex = 1 Then
        '    Me.dtpFecEnt.Enabled = False
        'Else
        '    Me.dtpFecEnt.Enabled = True

        'End If
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

        swMenuPpal = 2
        strMenu = "2"
        strCodbus = Me.tbxCodp.Text
        frmSubmenup.ShowDialog()
        Me.tbxDescr.Focus()


    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        strTabPages = tbcProy.SelectedIndex + 1
        If strTabPages < 2 Then
            tbcProy.SelectedTab = Me.tbcProy.TabPages(strTabPages)
        End If

    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub


    Private Sub tbxCodp_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxCodp.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            swMenuPpal = 2
            strMenu = "2"
            strCodbus = tbxCodp.Text
            frmSubmenup.ShowDialog()
            Me.cmbClas.Focus()

        End If
    End Sub

    Private Sub tbxDescr_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxDescr.KeyPress

    End Sub

    Private Sub cmbClas_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbClas.SelectedIndexChanged
        Me.tbxNroCon.Focus()
    End Sub

    Private Sub tbxNroCon_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxNroCon.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            If tbxNroCon.Text <> "" Then
                '  insertNroCont(Me.lblid.Text, Me.tbxCodp.Text, Me.tbxNroCon.Text, Me.tbxNroReci.Text, Me.tbxNroFac.Text)

                Me.tbxUbi.Focus()
            End If
        End If
    End Sub

    Private Sub tbxUbi_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxUbi.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            Me.txtMonto.Focus()

        End If
    End Sub

    Private Sub txtMonto_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMonto.KeyPress
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(txtMonto.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                txtMonto.Text = decimales(txtMonto.Text) 'Format(CDec(txtMonto.Text), "C")
                Dim intMonto As Decimal = 0
                intMonto = IIf(txtMonto.Text = "", 0, txtMonto.Text)
                txtITBMS.Text = decimales((intMonto * Val(f7.cmbImbs.Text)) / 100)
                e.Handled = True

                Me.dtpFecI.Focus()


            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.txtMonto.SelectAll()
        End If

    End Sub

    Private Sub txtCuenta_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = EnteroKey(System.Convert.ToInt16(Asc(e.KeyChar)))
        Try


            bolValor = Numerico(txtCuenta1.Text)
            If bolValor = False Then

                If e.KeyChar = Convert.ToChar(Keys.Return) Then

                    e.Handled = True
                    Me.dtpFd1.Focus()

                End If

            Else
                intk = 0
                MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
                Me.txtCuenta1.SelectAll()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dtpFd_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.dtpFH1.Focus()

        End If
    End Sub

    Private Sub dtpFH_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.tbxTraR1.Focus()

        End If
    End Sub

    Private Sub tbxTraR_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(tbxTraR1.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then

                e.Handled = True
                tbxTraR1.Text = decimales(tbxTraR1.Text)
                Me.dtpFechaR1.Focus()

            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxTraR1.SelectAll()
        End If


    End Sub

    Private Sub dtpFechaR_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            Me.txtInsp1.Focus()
        End If
    End Sub

    Private Sub txtInsp_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(txtInsp1.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then

                e.Handled = True
                txtInsp1.Text = decimales(txtInsp1.Text)
                '  Me.dtpPIns1.Focus()

            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            '  Me.txtInsp1.SelectAll()
        End If
    End Sub

    Private Sub dtpPIns_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            ' Me.txtDur1.Focus()
        End If
    End Sub

    Private Sub txtDur_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        'bolValor = Numerico(txtDur1.Text)
        'If bolValor = False Then

        '    If e.KeyChar = Convert.ToChar(Keys.Return) Then

        '        e.Handled = True
        '        '  Me.cmbperPagCtas1.Focus()

        '    End If

        'Else
        '    intk = 0
        '    MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
        '    Me.txtDur1.SelectAll()
        'End If

    End Sub

    Private Sub txtPercta_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
       


        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            e.Handled = True
            '  Me.dtpFechai1.Focus()

        End If

     


    End Sub

    Private Sub dtpFechai_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            '  Me.dtpFfOp1.Focus()
        End If
    End Sub

    Private Sub dtpFfOp_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            '  Me.cmbxSta1.Focus()
        End If
    End Sub


    Private Sub cmbxSta_KeyDown_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        ' Me.cmbTipo1.Focus()
    End Sub

    Private Sub cmbTipo_KeyDown_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If stridProy <> "" Then
            tbcProy.SelectedTab = tbcProy.TabPages(1)

            Me.tbxCont.Focus()


        End If
    End Sub

    Private Sub cmbClas_KeyDown_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbClas.KeyDown
        Me.tbxNroCon.Focus()
    End Sub

  
    Private Sub btnCont_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCont.Click, Button1.Click
        swMenuPpal = 2
        strMenu = "3"
        strCodCont = Me.tbxCont.Text
        frmSubmenup.ShowDialog()
    End Sub

   

    Private Sub btnClient_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClient.Click, Button2.Click
        swMenuPpal = 2
        strMenu = "4"
        strCodCli = Me.tbxCliente.Text
        frmSubmenup.ShowDialog()
        Me.tbxCliente.Text = strCodCli

    End Sub

    

    Private Sub tbxIng_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxIng.KeyPress, tbxIng1.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.tbxCorCMop1.Focus()

        End If
    End Sub


    Private Sub dtpFecT_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFecT.KeyPress, dtpFecT1.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.dtpAnAnt1.Focus()

        End If
    End Sub

    Private Sub dtpAnAnt_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpAnAnt.KeyPress, dtpAnAnt1.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.tbxMespro1.Focus()

        End If
    End Sub

    Private Sub tbxMespro_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxMespro.KeyPress, tbxMespro1.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.dtpfecTraFac11.Focus()

        End If
    End Sub

    Private Sub dtpfecTraFac_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpfecTraFac.KeyPress, dtpfecTraFac11.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.dtpfecTraFac12.Focus()

        End If
    End Sub

    Private Sub dtpfecTraFac1_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpfecTraFac1.KeyPress, dtpfecTraFac12.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.tbxAnalista.Focus()

        End If
    End Sub

    Private Sub tbxNroFac_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            'If Me.tbxNroFac1.Text <> "" And Me.tbxCodp.Text <> "" Then

            '    'FactNro = Me.tbxNroFac.Text
            '    'RecNro = Me.tbxNroReci.Text
            '    'ContNro = Me.tbxNroCon.Text

            '    'insertNroFact(Me.lblid.Text, Me.tbxCodp.Text, Me.tbxNroCon.Text, Me.tbxNroReci.Text, Me.tbxNroFac.Text)

            '    'FactNro = Me.tbxNroFac.Text
            '    'RecNro = Me.tbxNroReci.Text
            '    'ContNro = Me.tbxNroCon.Text

            '    'guardaActProyeDFact()
            '    'guardaActProyeDCostos()
            '    Me.dtpFecFac.Focus()

            'End If
        End If
    End Sub

    Private Sub dtpFecFac_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            ' Me.tbxFac.Focus()
        End If
    End Sub

    Private Sub tbxFac_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        'bolValor = Numerico(tbxFac.Text)
        'If bolValor = False Then

        '    If e.KeyChar = Convert.ToChar(Keys.Return) Then
        '        tbxFac.Text = decimales(tbxFac.Text)
        '        e.Handled = True
        '        Me.cmbRe10.Focus()

        '    End If

        'Else
        '    intk = 0
        '    MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
        '    Me.tbxFac.SelectAll()
        'End If
    End Sub



    Private Sub tbxMtoRet_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        'bolValor = Numerico(tbxMtoRet.Text)
        'If bolValor = False Then

        '    If e.KeyChar = Convert.ToChar(Keys.Return) Then
        '        tbxMtoRet.Text = decimales(tbxMtoRet.Text)
        '        e.Handled = True
        '        Me.tbxAntMont.Focus()
        '    End If

        'Else
        '    intk = 0
        '    MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
        '    Me.tbxMtoRet.SelectAll()
        'End If
    End Sub

    Private Sub tbxAntMont_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        'bolValor = Numerico(tbxAntMont.Text)
        'If bolValor = False Then

        '    If e.KeyChar = Convert.ToChar(Keys.Return) Then

        '        tbxAntMont.Text = decimales(tbxAntMont.Text)
        '        e.Handled = True
        '        Me.tbxPena.Focus()
        '    End If

        'Else
        '    intk = 0
        '    MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
        '    Me.tbxAntMont.SelectAll()
        'End If
    End Sub

    Private Sub tbxPena_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        'bolValor = Numerico(tbxPena.Text)
        'If bolValor = False Then

        '    If e.KeyChar = Convert.ToChar(Keys.Return) Then

        '        tbxPena.Text = decimales(tbxPena.Text)
        '        e.Handled = True
        '        Me.tbxRetMtoITBMS.Focus()
        '    End If

        'Else
        '    intk = 0
        '    MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
        '    Me.tbxPena.SelectAll()
        'End If
    End Sub

    Private Sub tbxRetMtoITBMS_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        'bolValor = Numerico(tbxRetMtoITBMS.Text)
        'If bolValor = False Then

        '    If e.KeyChar = Convert.ToChar(Keys.Return) Then
        '        tbxRetMtoITBMS.Text = decimales(tbxRetMtoITBMS.Text)
        '        e.Handled = True
        '        Me.tbxMtoITBMS.Focus()

        '    End If

        'Else
        '    intk = 0
        '    MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
        '    Me.tbxRetMtoITBMS.SelectAll()
        'End If
    End Sub



    Private Sub tbxCxC_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        'bolValor = Numerico(tbxCxC.Text)
        'If bolValor = False Then

        '    If e.KeyChar = Convert.ToChar(Keys.Return) Then
        '        tbxCxC.Text = decimales(tbxCxC.Text)
        '        e.Handled = True
        '        Me.cmbEnInsp.Focus()

        '    End If

        'Else
        '    intk = 0
        '    MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
        '    Me.tbxCxC.SelectAll()
        'End If
    End Sub

    Private Sub cmbEnInsp_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            'If cmbEnInsp1.SelectedIndex = 1 Then
            '    Me.dtpFecEnt.Focus()
            'End If
            'If cmbEnInsp1.SelectedIndex = 0 Then
            '    Me.dtpCXC.Focus()
            'End If

        End If
    End Sub



    Private Sub cmbEnInsp_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'If cmbEnInsp1.SelectedIndex = 1 Then
        '    Me.dtpFecEnt1.Enabled = False
        'Else
        '    Me.dtpFecEnt1.Enabled = True

        'End If
    End Sub

    Private Sub dtpFecEnt_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            ' Me.dtpCXC.Focus()

        End If
    End Sub

    Private Sub dtpCXC_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            ' Me.dtpFecTe.Focus()
        End If
    End Sub

    Private Sub dtpFecTe_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            ' Me.dtpFecPago.Focus()

        End If
    End Sub

    Private Sub dtpFecPago_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            If stridProy <> "" Then

                '  Me.tbxNroReci.Focus()


            Else
                MsgBox("Debe ingresar un Nro de Proyecto....", MsgBoxStyle.Critical, "Control Proyectos")

            End If


        End If
    End Sub

    Private Sub tbxNroReci_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            '  Me.dtpFecREC.Focus()


        End If
    End Sub

    Private Sub dtpFecREC_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            If stridProy <> "" Then
                tbcProy.SelectedTab = tbcProy.TabPages(3)

                '  Me.dtpfCheq.Focus()
            Else
                MsgBox("Debe ingresar un Nro de Proyecto....", MsgBoxStyle.Critical, "Control Proyectos")

            End If


        End If

    End Sub

    Private Sub dtpfCheq_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            '  Me.tbxNroCheque.Focus()
        End If
    End Sub

    Private Sub tbxNroCheque_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = EnteroKey(System.Convert.ToInt16(Asc(e.KeyChar)))
        Try


            'bolValor = Numerico(tbxNroCheque.Text)
            'If bolValor = False Then

            '    If e.KeyChar = Convert.ToChar(Keys.Return) Then

            '        e.Handled = True
            '        Me.cmbCtrlRec.Focus()

            '    End If

            'Else
            '    intk = 0
            '    MsgBox("Error en el Numero, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            '    Me.tbxNroCheque.SelectAll()
            'End If

        Catch ex As Exception

        End Try


    End Sub

    Private Sub cmbCtrlRec_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmbCtrlRec_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub

    Private Sub cmbCtrlRec_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub

    Private Sub cmbCtrlCheq_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub tbxMtoCxC_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        'bolValor = Numerico(Me.tbxMtoCxC.Text)
        'If bolValor = False Then

        '    If e.KeyChar = Convert.ToChar(Keys.Return) Then
        '        tbxMtoCxC.Text = decimales(tbxMtoCxC.Text)
        '        e.Handled = True
        '        Me.cmbRango1.Focus()

        '    End If

        'Else
        '    intk = 0
        '    MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
        '    Me.tbxMtoCxC.SelectAll()
        'End If
    End Sub

    Private Sub tbxMonto2_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        'bolValor = Numerico(Me.tbxMonto2.Text)
        'If bolValor = False Then

        '    If e.KeyChar = Convert.ToChar(Keys.Return) Then
        '        tbxMonto2.Text = decimales(tbxMonto2.Text)
        '        e.Handled = True
        '        Me.cmbstatus.Focus()

        '    End If

        'Else
        '    intk = 0
        '    MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
        '    Me.tbxMonto2.SelectAll()
        'End If

    End Sub

    Private Sub tbx_MesEje_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

    End Sub

    Private Sub tbxDocNext_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

    End Sub

    Private Sub tbxScafid_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            'Me.dtpFecRefr.Focus()
        End If
    End Sub

    Private Sub dtpFecRefr_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            'me.dtpFecTe.Focus()
        End If
    End Sub

    Private Sub cmbRe10_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            'If cmbRe10.SelectedIndex = 1 Then
            '    Me.tbxAntMont.Focus()
            'End If
            'If cmbRe10.SelectedIndex = 0 Then
            '    Me.tbxMtoRet.Focus()
            'End If

        End If
    End Sub

    Private Sub cmbRe10_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If cmbRe10.SelectedIndex = 1 Then
        '    Me.tbxMtoRet.Enabled = False
        'Else
        '    Me.tbxMtoRet.Enabled = True

        'End If
    End Sub



    Private Sub btnG_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'FactNro = Me.tbxNroFac.Text
        'RecNro = Me.tbxNroReci.Text

        'If stridProy <> "" Then
        '    ConexionSQL()
        '    insertNroFact(Me.lblid.Text, Me.tbxCodp.Text, Me.tbxNroCon.Text, Me.tbxNroReci.Text, Me.tbxNroFac.Text)
        '    insertNroRec(Me.lblid.Text, Me.tbxCodp.Text, Me.tbxNroCon.Text, Me.tbxNroReci.Text, Me.tbxNroFac.Text)
        '    GuardarALLproy()


        'Else
        '    MsgBox("Debe ingresar un Nro de Proyecto....", MsgBoxStyle.Critical, "Control Proyectos")

        'End If
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        strTabPages = tbcProy.SelectedIndex - 1
        If strTabPages >= 0 Then
            tbcProy.SelectedTab = Me.tbcProy.TabPages(strTabPages)
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        'FactNro = Me.tbxNroFac.Text
        'RecNro = Me.tbxNroReci.Text

        'If stridProy <> "" Then
        '    Dim frm As New frmProcess
        '    frm.Show()
        '    For x As Int32 = 0 To 1
        '        ConexionSQL()
        '        insertNroFact(Me.lblid.Text, Me.tbxCodp.Text, Me.tbxNroCon.Text, Me.tbxNroReci.Text, Me.tbxNroFac.Text)
        '        insertNroRec(Me.lblid.Text, Me.tbxCodp.Text, Me.tbxNroCon.Text, Me.tbxNroReci.Text, Me.tbxNroFac.Text)
        '        GuardarALLproy()
        '        Exit For
        '        Application.DoEvents()
        '    Next
        '    frm.Close()

        'Else
        '    MsgBox("Debe ingresar un Nro de Proyecto....", MsgBoxStyle.Critical, "Control Proyectos")

        'End If


    End Sub



    Private Sub ToolStripButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton12.Click
        Me.Close()
    End Sub


    Private Sub tbxMtoITBMS_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        'bolValor = Numerico(tbxRetMtoITBMS.Text)
        'If bolValor = False Then

        '    If e.KeyChar = Convert.ToChar(Keys.Return) Then
        '        tbxMtoITBMS.Text = decimales(tbxMtoITBMS.Text)
        '        e.Handled = True
        '        Me.tbxCxC.Focus()

        '    End If

        'Else
        '    intk = 0
        '    MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
        '    Me.tbxRetMtoITBMS.SelectAll()
        'End If
    End Sub

    Private Sub cmbRe10_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'If cmbRe10.SelectedIndex = 2 Then
        '    Me.tbxAntMont.Focus()
        'End If
        'If cmbRe10.SelectedIndex = 1 Then
        '    Me.tbxMtoRet.Focus()
        'End If
    End Sub

    Private Sub cmbRe10_KeyDown_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'If cmbRe10.SelectedIndex = 2 Then
        '    Me.tbxAntMont.Focus()
        'End If
        'If cmbRe10.SelectedIndex = 1 Then
        '    Me.tbxMtoRet.Focus()
        'End If
    End Sub

    Private Sub rdbtn1_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    FactNro = Me.tbxNroFac.Text
        '    RecNro = Me.tbxNroReci.Text
        '    ContNro = Me.tbxNroCon.Text

        '    If FactNro <> "" And RecNro <> "" And ContNro <> "" Then


        '        Me.P_BuscaProyectosTableAdapter.Fill(Me.Dt_proy.p_BuscaProyectos, stridProy, ContNro, FactNro)
        '    Else
        '        MsgBox("Debe Seleccionar Un Proyecto", MsgBoxStyle.Exclamation)
        '    End If

        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub tdbtn2_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            'FactNro = Me.tbxNroFac.Text
            'RecNro = Me.tbxNroReci.Text
            ContNro = Me.tbxNroCon.Text

            Me.P_BuscaProyectosTableAdapter.Fill(Me.Dt_proy.p_BuscaProyectos, stridProy, ContNro, "")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmbTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnBusFact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        swMenuPpal = 2
        frmFacturas.Show()
    End Sub

    Private Sub ToolStripButton3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If swTab = 0 Then
            Me.tbpDbas.Parent = Me.tbcProy
            Me.tbcProy.SelectedTab = Me.tbpDbas
            Me.tbxMes.Parent = Me.tbcProy
            Me.tbcProy.SelectedTab = Me.tbxMes

            'organizar los tabpages

            swTab = 1
        Else
            swTab = 0
            Me.tbpDbas.Parent = Nothing
            Me.tbxMes.Parent = Nothing


        End If
    End Sub
    Sub guardaCuentas()
        Try
            Dim swSinD As Integer = 0
            If stridProy <> "" Then
                Dim frm As New frmProcess
                frm.Show()
                For x As Int32 = 0 To 1


                    If Me.txtCuenta1.Text <> "" Then

                        insertaDatosComplProyf7()
                        'frmInputctas.actualizaFechaEstCobros()
                        MsgBox("Datos Guardados....", MsgBoxStyle.Information, "Control Proyectos")
                        'Else
                        '    swSinD = 1


                    End If

                    Exit For
                    Application.DoEvents()
                Next
                frm.Close()

                'If swguar = 0 Then
                '    If swSinD = 1 Then
                '        MsgBox("No existe un Nro. de Cuenta, por favor verifique..", MsgBoxStyle.Information, "Control Proyectos")
                '    Else
                '        MsgBox("Datos Guardados....", MsgBoxStyle.Information, "Control Proyectos")
                '    End If

                'End If

            Else
                MsgBox("Debe ingresar un Nro de Proyecto....", MsgBoxStyle.Critical, "Control Proyectos")

            End If
            ' clearFormularios1f7()
            Me.tbxCodp.Focus()
        Catch ex As Exception
            MsgBox("Error al guardar Ctas", MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub

    Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click



        If stridProy <> "" Then
            Dim frm As New frmProcess
            frm.Show()
            For x As Int32 = 0 To 1

                GuardarALLproyf7()
                guardaCuentas()
                

                clearDcompl()
                clearCtas()
                clearEntesf7()

                Exit For
                Application.DoEvents()
            Next
            frm.Close()

            If swguar = 0 Then
                MsgBox("Datos Guardados....", MsgBoxStyle.Information, "Control Proyectos")
            End If

        Else
            MsgBox("Debe ingresar un Nro de Proyecto....", MsgBoxStyle.Critical, "Control Proyectos")

        End If
        clearFormularios1f7()
        Me.tbxCodp.Focus()

        CtaNro = 0
        ProyNro = ""
        ContNro = ""
        RecNro = ""
        FactNro = ""
        idProy = 0
    End Sub

    Private Sub ToolStripButton6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        frmInicioproyectos.ShowDialog()
    End Sub

   
    Private Sub tbxCliente_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxCliente.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            swMenuPpal = 0
            strMenu = "4"
            strCodCli = Me.tbxCliente.Text
            Me.tbxGProy.Focus()
            ' frmSubmenup.ShowDialog()
            'me.tbxClient.Text = strDescCli

        End If
    End Sub

    Private Sub tbxCont1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxCont1.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            swMenuPpal = 0
            strMenu = "3"
            strCodCont = Me.tbxCont.Text
            Me.tbxCliente.Focus()
            ' frmSubmenup.ShowDialog()
            ' me.tbxCont.Text = strDescCont

        End If
    End Sub

    Private Sub tbxGProy1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxGProy1.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.tbxIng1.Focus()

        End If
    End Sub

    Private Sub tbxCorCMop1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxCorCMop1.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.tbxGob1.Focus()

        End If
    End Sub

    Private Sub tbxGob1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxGob1.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.tbxEncG1.Focus()

        End If
    End Sub

    Private Sub tbxEncG1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxEncG1.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.tbxMtoT1.Focus()

        End If
    End Sub

    Private Sub TextBox9_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxMtoT1.KeyPress
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(tbxMtoT1.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                tbxMtoT1.Text = decimales(tbxMtoT1.Text) 'Format(CDec(txtMonto.Text), "C")
                e.Handled = True
                Me.dtpFecT.Focus()

            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxMtoT1.SelectAll()
        End If
    End Sub

    Private Sub tbxMtoT1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbxMtoT1.Leave
        bolValor = Numerico(tbxMtoT1.Text)
        If bolValor = False Then


            tbxMtoT1.Text = decimales(tbxMtoT1.Text) 'Format(CDec(txtMonto.Text), "C")

            Me.dtpFecT1.Focus()



        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxMtoT1.SelectAll()
        End If
    End Sub

    Private Sub cmbperPagCtas_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            'If cmbperPagCtas.SelectedIndex <> -1 Then
            '    dtpFechai.Focus()

            'End If

        End If
    End Sub

    Private Sub ToolStripButton3_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click

        If ProyNro <> "" Then
            'gbpDatos.Enabled = True
            ContNro = Me.tbxNroCon.Text
            swMenuPpal = 2
            swCtaFac = 0
            frmNroctaproy.ShowDialog()
        Else
            MsgBox("Debe seleccionar un proyecto ", MsgBoxStyle.Information, "Control Proyectos")
        End If

        swCtaFac = 0
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
                    clearDcompl()

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


                preg = MsgBox("Nuevo Nro de Cuenta, desea Insertar ??? ", MsgBoxStyle.YesNo, "Control Proyectos")

                If preg = 6 Then
                    clearDcompl()
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

    Private Sub btnctas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ProyNro <> "" Then
            'gbpDatos.Enabled = True
            ContNro = Me.tbxNroCon.Text
            swMenuPpal = 2
            swCtaFac = 0
            frmNroctaproy.ShowDialog()
        Else
            MsgBox("Debe seleccionar un proyecto ", MsgBoxStyle.Information, "Control Proyectos")
        End If

        swCtaFac = 0
    End Sub

    Private Sub btnAdendas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdendas.Click

        'inttipoAd = 1
        frmAdendas.Show()
    End Sub

    Private Sub ToolStripButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ProyNro <> "" Then
            'gbpDatos.Enabled = True
            ContNro = Me.tbxNroCon.Text
            swMenuPpal = 2
            swCtaFac = 0
            frmNroctaproy.ShowDialog()
        Else
            MsgBox("Debe seleccionar un proyecto ", MsgBoxStyle.Information, "Control Proyectos")
        End If

        swCtaFac = 0
    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'FactNro = f7.tbxNroFac.Text
        'RecNro = f7.tbxNroReci.Text

        Dim swSinD As Integer = 0
        If stridProy <> "" Then
            Dim frm As New frmProcess
            frm.Show()
            For x As Int32 = 0 To 1

                '  GuardarALLproyf7()
                If Me.txtCuenta1.Text <> "" Then

                    insertaDatosComplProyf7()
                    'frmInputctas.actualizaFechaEstCobros()
                Else
                    swSinD = 1
                    'clearDcompl()
                End If

                Exit For
                Application.DoEvents()
            Next
            frm.Close()

            If swguar = 0 Then
                If swSinD = 1 Then
                    MsgBox("No existe un Nro. de Cuenta, por favor verifique..", MsgBoxStyle.Information, "Control Proyectos")
                Else
                    MsgBox("Datos Guardados....", MsgBoxStyle.Information, "Control Proyectos")
                End If

            End If

        Else
            MsgBox("Debe ingresar un Nro de Proyecto....", MsgBoxStyle.Critical, "Control Proyectos")

        End If
        ' clearFormularios1f7()
        Me.tbxCodp.Focus()

        'CtaNro = 0
        'ProyNro = ""
        'ContNro = ""
        'RecNro = ""
        'FactNro = ""
        'idProy = 0
    End Sub

    Private Sub ToolStripButton2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Try
            Dim preg As String
            Dim strDel As ADODB.Recordset
            If Me.tbxCodp.Text <> "" Then
                preg = MsgBox("Seguro que desea eliminar el proyecto " & Me.tbxCodp.Text, MsgBoxStyle.YesNo, "Control Proyectos")

                If preg = 6 Then
                    ConexionSQL()
                    strDel = cntSQL.Execute("p_eliminaProyectos '" & Me.tbxCodp.Text & "'")
                    MsgBox("Proyecto Eliminado", MsgBoxStyle.Information, "Control Proyectos")
                    clearDPpal1f7()
                    clearDcompl()
                    clearEntesf7()
                    lbltiproy.Text = "."
                End If


            End If

        Catch ex As Exception
            MsgBox("Error al eliminar proyecto" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")

        End Try
    End Sub

   
   
    Private Sub ToolStripButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'FactNro = f7.tbxNroFac.Text
        'RecNro = f7.tbxNroReci.Text

        Dim swSinD As Integer = 0
        If stridProy <> "" Then
            Dim frm As New frmProcess
            frm.Show()
            For x As Int32 = 0 To 1

                '  GuardarALLproyf7()
                If Me.txtCuenta1.Text <> "" Then

                    insertaDatosComplProyf7()
                    'frmInputctas.actualizaFechaEstCobros()
                Else
                    swSinD = 1
                    'clearDcompl()
                End If

                Exit For
                Application.DoEvents()
            Next
            frm.Close()

            If swguar = 0 Then
                If swSinD = 1 Then
                    MsgBox("No existe un Nro. de Cuenta, por favor verifique..", MsgBoxStyle.Information, "Control Proyectos")
                Else
                    MsgBox("Datos Guardados....", MsgBoxStyle.Information, "Control Proyectos")
                End If

            End If

        Else
            MsgBox("Debe ingresar un Nro de Proyecto....", MsgBoxStyle.Critical, "Control Proyectos")

        End If
        ' clearFormularios1f7()
        Me.tbxCodp.Focus()

        'CtaNro = 0
        'ProyNro = ""
        'ContNro = ""
        'RecNro = ""
        'FactNro = ""
        'idProy = 0
    End Sub

    Private Sub ToolStripButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ProyNro <> "" Then
            ' gbpDatos.Enabled = True
            ContNro = Me.tbxNroCon.Text
            swMenuPpal = 2
            swCtaFac = 0
            frmNroctaproy.ShowDialog()
        Else
            MsgBox("Debe seleccionar un proyecto ", MsgBoxStyle.Information, "Control Proyectos")
        End If

        swCtaFac = 0
    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If ProyNro <> "" Then
            'gbpDatos.Enabled = True
            ContNro = Me.tbxNroCon.Text
            swMenuPpal = 2
            swCtaFac = 0
            frmNroctaproy.ShowDialog()
        Else
            MsgBox("Debe seleccionar un proyecto ", MsgBoxStyle.Information, "Control Proyectos")
        End If

        swCtaFac = 0
    End Sub

    Private Sub ltwCtas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ltwCtas.SelectedIndexChanged
        clearDcompl()

        If Me.ltwCtas.Items.Count > 0 Then

            For i = 0 To Me.ltwCtas.Items.Count - 1

                If Me.ltwCtas.Items(i).Selected = True Then
                    ProyNro = Me.ltwCtas.FocusedItem.SubItems(0).Text
                    ContNro = Me.ltwCtas.FocusedItem.SubItems(3).Text
                    CtaNro = Me.ltwCtas.FocusedItem.SubItems(10).Text
                    serieNro = Me.ltwCtas.FocusedItem.SubItems(1).Text
                    Exit For
                End If
            Next

        End If

        If swMenuPpal = 2 Then
            frmNroctaproy.consultaProyFactDppalf7()
            ConsultasDEntesFactf7()
        End If
        If swMenuPpal = 1 Then
            frmNroctaproy.consultaProyFactDppalf1()
        End If
    End Sub

    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        'inttipoAd = 0
        frmAdendas.Show()
    End Sub

    Private Sub dtpFecI_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFecI.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            dtpFecF.Focus()

        End If
    End Sub

    Private Sub dtpFecF_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFecF.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            cmbSt.Focus()

        End If
    End Sub

    Private Sub cmbSt_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSt.SelectedIndexChanged

        cmbTp.Focus()


    End Sub

    Private Sub tbxAdendas_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxAdendas.KeyPress
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(tbxAdendas.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                txtMonto.Text = decimales(tbxAdendas.Text) 'Format(CDec(txtMonto.Text), "C")
                e.Handled = True
                Me.txtItbAd.Focus()


            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxAdendas.SelectAll()
        End If
    End Sub

    Private Sub txtItbAd_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtItbAd.KeyPress
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(txtItbAd.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                txtMonto.Text = decimales(txtItbAd.Text) 'Format(CDec(txtMonto.Text), "C")
                e.Handled = True
                Me.txtItbContAd.Focus()


            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.txtItbAd.SelectAll()
        End If
    End Sub

    Private Sub txtItbContAd_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtItbContAd.KeyPress
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(txtItbContAd.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                txtMonto.Text = decimales(txtItbContAd.Text) 'Format(CDec(txtMonto.Text), "C")
                e.Handled = True
                Me.txtDurOri.Focus()


            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.txtItbContAd.SelectAll()
        End If
    End Sub

   

    Private Sub txtDurOri_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDurOri.KeyPress
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(txtDurOri.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then

                f7.dtpFecF.Value = f7.dtpFecI.Value.AddDays(Val(Me.txtDurOri.Text) + Val(Me.txtAdT.Text))
                txtDurCont.Text = Val(Me.txtDurOri.Text) + Val(Me.txtAdT.Text)

                e.Handled = True
                Me.txtAdT.Focus()


            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.txtDurOri.SelectAll()
        End If
    End Sub

    Private Sub txtAdT_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAdT.KeyPress
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(txtAdT.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                txtMonto.Text = decimales(txtAdT.Text) 'Format(CDec(txtMonto.Text), "C")
                e.Handled = True
                Me.txtDurCont.Focus()


            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.txtAdT.SelectAll()
        End If
    End Sub

    Private Sub txtDurCont_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDurCont.KeyPress
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(txtDurCont.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                txtMonto.Text = decimales(txtDurCont.Text) 'Format(CDec(txtMonto.Text), "C")
                e.Handled = True
                Me.dtpFecI.Focus()


            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.txtDurCont.SelectAll()
        End If
    End Sub


    Private Sub txtDurOri_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDurOri.Leave
       
        f7.dtpFecF.Value = f7.dtpFecI.Value.AddDays(Val(Me.txtDurOri.Text) + Val(Me.txtAdT.Text))
        txtDurCont.Text = Val(Me.txtDurOri.Text) + Val(Me.txtAdT.Text)

    End Sub

    
   
    Private Sub txtMonto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMonto.TextChanged

        Dim intMonto As Decimal = 0
        intMonto = IIf(txtMonto.Text = "", 0, txtMonto.Text)
        txtITBMS.Text = decimales((intMonto * Val(f7.cmbImbs.Text)) / 100)

        'txtItbContAd.Text = decimales((intMonto + txtITBMS.Text + tbxAdendas.Text))


    End Sub

    Private Sub txtDurOri_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDurOri.TextChanged
       
    End Sub
End Class
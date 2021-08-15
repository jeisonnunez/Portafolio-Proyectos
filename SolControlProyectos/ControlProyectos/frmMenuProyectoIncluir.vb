Imports System.Windows.Forms
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel




Public Class frmMenuProyectoIncluir
    Public strTabPages As Integer = 1
    Public swTab As Integer = 0
    Public selected As String = ""
    Public intMontAb As Decimal = 0
    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        strMenu = "1"
        'frmSubmenup.ShowDialog()
    End Sub



    Private Sub Button16_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



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
            ' strCodbus = tbxCodp.Text
            frmSubmenup.ShowDialog()
            ' Me.cmbClas.Focus()

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
        'Me.tbxCodp.Focus()
        llenarComboStatus()
        llenarComboTipo()
        llenarComboSector()
        llenarComboMeses()
        llenarComboRecibo()
        llenarComboCheque()
        llenarComboRango()
        clearFormularios15()
        llenarComboStatusC()
        llenarComboPerpagoCtas()
        llenarCombocmbEnInsp()
        'ocultar los tab de datos basicos
        dtpFecEnt.Enabled = False
        cmbEnInsp.Focus()
        Me.tbxCtaFac.Parent = Nothing
        ' Me.tbpFacturacion.Parent = Nothing
        ' tbcProy.SelectedTab = Me.tbcProy.TabPages(2)
    End Sub

    'Sub llenarCombocmbEnInsp()
    '    Try
    '        Dim strseleccion As New ADODB.Recordset
    '        Me.cmbEnInsp.Items.Clear()

    '        strseleccion = cntSQL.Execute("SELECT  [descripcion] FROM tab_seleccionSimple")

    '        Do While Not strseleccion.EOF
    '            Me.cmbEnInsp.Items.Add(strseleccion.Fields(0).Value)

    '            strseleccion.MoveNext()
    '        Loop


    '    Catch ex As Exception
    '        MsgBox("Error en funcion llenarCombocmbEnInsp" & ex.Message)
    '    End Try
    'End Sub
    Sub llenarComboPerpagoCtas()
        Try
            Dim strperCtas As New ADODB.Recordset
            Me.cmbPerPCtas.Items.Clear()

            strperCtas = cntSQL.Execute("SELECT des_perpagoCuentas FROM [dbo].[tab_perpagoCuentas]")

            Do While Not strperCtas.EOF
                Me.cmbPerPCtas.Items.Add(strperCtas.Fields(0).Value)

                strperCtas.MoveNext()
            Loop


        Catch ex As Exception
            MsgBox("Error en funcion  llenarComboPerpagoCtas()" & ex.Message)
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
            MsgBox("Error en funcion llenarComboCheque()" & ex.Message)
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
        'Try
        '    Dim strSector As New ADODB.Recordset
        '    Me.cmbClas.Items.Clear()

        '    strSector = cntSQL.Execute("SELECT [cod_Sector] + ' - ' + [des_Sector] FROM [dbo].[tab_Sector]")

        '    Do While Not strSector.EOF
        '        Me.cmbClas.Items.Add(strSector.Fields(0).Value)

        '        strSector.MoveNext()
        '    Loop


        'Catch ex As Exception
        '    MsgBox("Error en funcion llenarComboSector" & ex.Message)
        'End Try
    End Sub
    'Sub llenarComboTipo()
    '    'Try
    '    '    Dim strTipo As New ADODB.Recordset
    '    '    Me.cmbTipo.Items.Clear()

    '    '    strTipo = cntSQL.Execute("SELECT [cod_Tipo] + ' - ' + [des_Tipo] FROM [dbo].[tab_Tipo]")

    '    '    Do While Not strTipo.EOF
    '    '        Me.cmbTipo.Items.Add(strTipo.Fields(0).Value)

    '    '        strTipo.MoveNext()
    '    '    Loop


    '    'Catch ex As Exception
    '    '    MsgBox("Error en funcion llenarComboTipo" & ex.Message)
    '    'End Try
    'End Sub
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

    'Sub llenarComboStatus()
    '    'Try
    '    '    Dim strSector As New ADODB.Recordset
    '    '    Me.cmbxSta.Items.Clear()

    '    '    strSector = cntSQL.Execute("SELECT [cod_Status] + ' - ' + [des_Status] FROM [dbo].[tab_Status]")

    '    '    Do While Not strSector.EOF
    '    '        Me.cmbxSta.Items.Add(strSector.Fields(0).Value)

    '    '        strSector.MoveNext()
    '    '    Loop


    '    'Catch ex As Exception
    '    '    MsgBox("Error en funcion llenarComboStatus" & ex.Message)
    '    'End Try
    'End Sub
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
            '  strCodCli = Me.tbxClient.Text
            frmSubmenup.ShowDialog()
            ' Me.tbxCodp.SelectAll()

        End If
    End Sub

    Private Sub tbpFiscal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub tbxDescr_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            'Me.cmbClas.Focus()

        End If
    End Sub


    Private Sub tbxUbi_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            'Me.txtMonto.Focus()

        End If
    End Sub

    Private Sub tbxClient_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            strMenu = "4"
            ' strCodCli = Me.tbxClient.Text
            frmSubmenup.ShowDialog()


            'If swMen = 1 Then
            '    Me.tbxClient.Focus()
            'Else
            '    Me.tbxClient.SelectAll()

            '    Me.tbxNroCon.Focus()
            'End If


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






        'e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        'bolValor = Numerico(txtMonto.Text)
        'If bolValor = False Then

        '    If e.KeyChar = Convert.ToChar(Keys.Return) Then
        '        txtMonto.Text = decimales(txtMonto.Text) 'Format(CDec(txtMonto.Text), "C")
        '        e.Handled = True
        '        Me.txtCuenta.Focus()


        '    End If

        'Else
        '    intk = 0
        '    MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
        '    Me.txtMonto.SelectAll()
        'End If

    End Sub

    Private Sub cmbxSta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If Asc(e.KeyChar) = Keys.Enter Then
            'Me.cmbTipo.Focus()
        End If


    End Sub

    Private Sub txtCuenta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        e.Handled = EnteroKey(System.Convert.ToInt16(Asc(e.KeyChar)))
        Try


            'bolValor = Numerico(txtCuenta.Text)
            'If bolValor = False Then

            '    If e.KeyChar = Convert.ToChar(Keys.Return) Then

            '        e.Handled = True
            '        Me.dtpFd.Focus()

            '    End If

            'Else
            '    intk = 0
            '    MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            '    Me.txtCuenta.SelectAll()
            'End If

        Catch ex As Exception

        End Try


    End Sub

    Private Sub cmbxMes_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If Asc(e.KeyChar) = Keys.Enter Then

            'Me.tbxClient.Focus()

        End If
    End Sub

    Private Sub txtPercta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)


        'e.Handled = EnteroKey(System.Convert.ToInt16(Asc(e.KeyChar)))
        'Try


        '    bolValor = Numerico(txtPercta.Text)
        '    If bolValor = False Then

        '        If e.KeyChar = Convert.ToChar(Keys.Return) Then

        '            e.Handled = True
        '            Me.dtpFechai.Focus()

        '        End If

        '    Else
        '        intk = 0
        '        MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
        '        Me.txtPercta.SelectAll()
        '    End If

        'Catch ex As Exception

        'End Try

    End Sub

    Private Sub txtEje_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            'Me.tbxResp.Focus()

        End If
    End Sub


    Private Sub cmbxResp_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then

            'Me.txtDur.Focus()

        End If
    End Sub

    Private Sub txtDur_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        'bolValor = Numerico(txtDur.Text)
        'If bolValor = False Then

        '    If e.KeyChar = Convert.ToChar(Keys.Return) Then

        '        e.Handled = True
        '        Me.txtPercta.Focus()

        '    End If

        'Else
        '    intk = 0
        '    MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
        '    Me.txtDur.SelectAll()
        'End If



    End Sub

    Private Sub tbxFac_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(tbxFac.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                tbxFac.Text = decimales(tbxFac.Text)
                e.Handled = True
                Me.cmbRe10.Focus()

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


            Me.dtpCXC.Focus()

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


            Me.dtpFecPago.Focus()

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
                Me.tbxDocNext.Focus()

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


        'If stridProy <> "" Then
        '    ConexionSQL()
        '    If FactNro <> "" Then
        '        insertNroFact(Me.lblid.Text, Me.tbxCodp.Text, Me.tbxNroCon.Text, Me.tbxNroReci.Text, Me.tbxNroFac.Text)
        '        insertNroRec(Me.lblid.Text, Me.tbxCodp.Text, Me.tbxNroCon.Text, Me.tbxNroReci.Text, Me.tbxNroFac.Text)
        '    End If

        '    FactNro = Me.tbxNroFac.Text
        '    RecNro = Me.tbxNroReci.Text
        '    ContNro = Me.tbxNroCon.Text

        '    GuardarALLproy()

        'Else

        '    MsgBox("Debe ingresar un Nro de Proyecto....", MsgBoxStyle.Critical, "Control Proyectos")

        'End If

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
        'txtDur.Focus()
    End Sub

    Private Sub tbxNroCon_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            'If tbxNroCon.Text <> "" Then
            '    insertNroCont(Me.lblid.Text, Me.tbxCodp.Text, Me.tbxNroCon.Text, Me.tbxNroReci.Text, Me.tbxNroFac.Text)

            '    Me.tbxUbi.Focus()
            'End If
        End If
    End Sub

    Private Sub dtpFd_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            'Me.dtpFH.Focus()

        End If
    End Sub

    Private Sub dtpFH_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            'Me.tbxTraR.Focus()

        End If
    End Sub

    Private Sub tbxTraR_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        'bolValor = Numerico(tbxTraR.Text)
        'If bolValor = False Then

        '    If e.KeyChar = Convert.ToChar(Keys.Return) Then

        '        e.Handled = True
        '        tbxTraR.Text = decimales(tbxTraR.Text)
        '        Me.dtpFechaR.Focus()

        '    End If

        'Else
        '    intk = 0
        '    MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
        '    Me.tbxTraR.SelectAll()
        'End If




    End Sub

    Private Sub dtpFechaR_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            'Me.txtInsp.Focus()
        End If
    End Sub

    Private Sub txtInsp_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        'e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        'bolValor = Numerico(txtInsp.Text)
        'If bolValor = False Then

        '    If e.KeyChar = Convert.ToChar(Keys.Return) Then

        '        e.Handled = True
        '        txtInsp.Text = decimales(txtInsp.Text)
        '        Me.dtpPIns.Focus()

        '    End If

        'Else
        '    intk = 0
        '    MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
        '    Me.txtInsp.SelectAll()
        'End If
    End Sub

    Private Sub dtpPIns_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        'If e.KeyChar = Convert.ToChar(Keys.Return) Then
        '    Me.txtDur.Focus()
        'End If
    End Sub

    Private Sub tbxNroRec_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            'tbcProy.SelectedTab = tbcProy.TabPages(1)
            'GuardarALLproy()
            'Me.txtPercta.Focus()

        End If
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmbTipo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            If stridProy <> "" Then
                tbcProy.SelectedTab = tbcProy.TabPages(1)
                guardaActDPpalProy()
                'Me.tbxCont.Focus()
            Else
                MsgBox("Debe ingresar un Nro de Proyecto....", MsgBoxStyle.Critical, "Control Proyectos")

            End If


        End If

    End Sub

    Private Sub tbxCont_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            swMenuPpal = 0
            strMenu = "3"
            'strCodCont = Me.tbxCont.Text
            'Me.tbxClient.Focus()
            ' frmSubmenup.ShowDialog()
            ' me.tbxCont.Text = strDescCont

        End If
    End Sub

    Private Sub btnCont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        swMenuPpal = 0
        strMenu = "3"
        'strCodCont = Me.tbxCont.Text
        frmSubmenup.ShowDialog()

    End Sub

    Private Sub tbxClient_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            swMenuPpal = 0
            strMenu = "4"
            'strCodCli = Me.tbxClient.Text
            'Me.tbxGProy.Focus()
            ' frmSubmenup.ShowDialog()
            'me.tbxClient.Text = strDescCli

        End If
    End Sub

    Private Sub btnClient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        swMenuPpal = 0
        strMenu = "4"
        'strCodCli = Me.tbxClient.Text
        frmSubmenup.ShowDialog()
        'Me.tbxClient.Text = strDescCli

    End Sub

    Private Sub tbxMtoT_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        'bolValor = Numerico(tbxMtoT.Text)
        'If bolValor = False Then

        '    If e.KeyChar = Convert.ToChar(Keys.Return) Then

        '        e.Handled = True
        '        Me.dtpFecT.Focus()

        '    End If

        'Else
        '    intk = 0
        '    MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
        '    Me.tbxMtoT.SelectAll()
        'End If
    End Sub

    Private Sub tbxGProy_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            'Me.tbxIng.Focus()

        End If
    End Sub

    Private Sub tbxIng_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            'Me.tbxCorCMop.Focus()

        End If
    End Sub

    Private Sub tbxCorCMop_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            'Me.tbxGob.Focus()

        End If
    End Sub

    Private Sub tbxGob_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            'Me.tbxEncG.Focus()

        End If
    End Sub

    Private Sub tbxEncG_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            'Me.tbxMtoT.Focus()

        End If
    End Sub

    Private Sub dtpFecT_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            'Me.dtpAnAnt.Focus()

        End If
    End Sub

    Private Sub dtpAnAnt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            'Me.tbxMespro.Focus()

        End If
    End Sub

    Private Sub tbxMespro_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            'Me.dtpfecTraFac.Focus()

        End If
    End Sub

    Private Sub dtpfecTraFac_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            'Me.dtpfecTraFac1.Focus()

        End If
    End Sub

    Private Sub dtpfecTraFac1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)


        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            If stridProy <> "" Then
                tbcProy.SelectedTab = tbcProy.TabPages(2)
                guardaActProyeDResp()
                Me.tbxNroFac.Focus()


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
                'insertNroRec(Me.lblid.Text, Me.tbxCodp.Text, Me.tbxNroCon.Text, Me.tbxNroReci.Text, Me.tbxNroFac.Text)
                guardaActProyeDFact()
                guardaActProyeDCostos()
                Me.dtpFecREC.Focus()

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

                Me.tbxNroReci.Focus()


            Else
                MsgBox("Debe ingresar un Nro de Proyecto....", MsgBoxStyle.Critical, "Control Proyectos")

            End If


        End If
    End Sub

    Private Sub tbxNroFac_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            If Me.tbxNroFac.Text <> "" Then

                FactNro = Me.tbxNroFac.Text
                RecNro = Me.tbxNroReci.Text
                'ContNro = Me.tbxNroCon.Text

                'insertNroFact(Me.lblid.Text, Me.tbxCodp.Text, Me.tbxNroCon.Text, Me.tbxNroReci.Text, Me.tbxNroFac.Text)

                'FactNro = Me.tbxNroFac.Text
                'RecNro = Me.tbxNroReci.Text
                'ContNro = Me.tbxNroCon.Text

                guardaActProyeDFact()
                guardaActProyeDCostos()
                Me.dtpFecFac.Focus()

            End If
        End If

    End Sub

    Private Sub dtpFecFac_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            Me.tbxFac.Focus()
        End If
    End Sub

    Private Sub dtpFecREC_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            If stridProy <> "" Then
                tbcProy.SelectedTab = tbcProy.TabPages(3)

                Me.dtpfCheq.Focus()
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

            If cmbRe10.SelectedIndex = 2 Then
                Me.tbxAntMont.Focus()
            End If
            If cmbRe10.SelectedIndex = 1 Then
                Me.tbxMtoRet.Focus()
            End If

        End If
    End Sub

    Private Sub tbxMtoRet_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(tbxMtoRet.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then

                e.Handled = True
                Me.tbxAntMont.Focus()
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
                Me.tbxRetMtoITBMS.Focus()
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
                Me.dtpFecEnt.Focus()
            Else
                Me.dtpCXC.Focus()

            End If


        End If
    End Sub

    Private Sub dtpCXC_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            Me.dtpFecTe.Focus()
        End If
    End Sub

    Private Sub dtpfCheq_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            Me.tbxNroCheque.Focus()
        End If
    End Sub

    Private Sub tbxNroCheque_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        e.Handled = EnteroKey(System.Convert.ToInt16(Asc(e.KeyChar)))
        Try


            bolValor = Numerico(tbxNroCheque.Text)
            If bolValor = False Then

                If e.KeyChar = Convert.ToChar(Keys.Return) Then

                    e.Handled = True
                    Me.cmbCtrlRec.Focus()

                End If

            Else
                intk = 0
                MsgBox("Error en el Numero, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
                Me.tbxNroCheque.SelectAll()
            End If

        Catch ex As Exception

        End Try



    End Sub

    Private Sub cmbCtrlRec_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            Me.cmbCtrlCheq.Focus()
        End If
    End Sub

    Private Sub cmbCtrlCheq_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            Me.tbxMtoCxC.Focus()
        End If
    End Sub


    Private Sub tbxMtoCxC_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(Me.tbxMtoCxC.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                tbxMtoCxC.Text = decimales(tbxMtoCxC.Text)
                e.Handled = True
                Me.cmbRango1.Focus()

            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxMtoCxC.SelectAll()
        End If


    End Sub

    Private Sub cmbRango1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            Me.cmbRango2.Focus()
        End If
    End Sub

    Private Sub cmbRango2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            Me.cmbRango.Focus()
        End If
    End Sub

    Private Sub cmbRango_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            Me.tbxMonto2.Focus()

        End If
    End Sub

    Private Sub cmbstatus_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            Me.tbx_MesEje.Focus()
        End If
    End Sub

    Private Sub tbxSca_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            Me.tbxScafid.Focus()
        End If
    End Sub

    Private Sub tbxScafid_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            Me.dtpFecRefr.Focus()
        End If
    End Sub

    Private Sub dtpFecRefr_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            'me.dtpFecTe.Focus()
        End If
    End Sub

    Private Sub dtpFechai_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            'Me.dtpFfOp.Focus()
        End If
    End Sub

    Private Sub dtpFfOp_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            'Me.cmbxSta.Focus()
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

        bolValor = Numerico(Me.tbxMonto2.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then

                e.Handled = True
                Me.cmbstatus.Focus()

            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxMonto2.SelectAll()
        End If



    End Sub



    Private Sub cmbClas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'Me.tbxNroCon.Focus()

    End Sub

    Private Sub cmbTipo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If stridProy <> "" Then
            tbcProy.SelectedTab = tbcProy.TabPages(1)
            guardaActDPpalProy()
            'Me.tbxCont.Focus()
        Else
            MsgBox("Debe ingresar un Nro de Proyecto....", MsgBoxStyle.Critical, "Control Proyectos")

        End If
    End Sub

    Private Sub cmbClas_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'Me.tbxNroCon.Focus()
    End Sub

    Private Sub cmbxSta_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'Me.cmbTipo.Focus()
    End Sub

    Private Sub cmbRe10_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Me.tbxMtoRet.Focus()
    End Sub

    Private Sub cmbEnInsp_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Me.dtpFecEnt.Focus()
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
            FactNro = Me.tbxNroFac.Text
            RecNro = Me.tbxNroReci.Text
            'ContNro = Me.tbxNroCon.Text

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
            FactNro = Me.tbxNroFac.Text
            RecNro = Me.tbxNroReci.Text
            'ContNro = Me.tbxNroCon.Text

            Me.P_BuscaProyectosTableAdapter.Fill(Me.Dt_proy.p_BuscaProyectos, stridProy, ContNro, "")
        Catch ex As Exception

        End Try
    End Sub




    Private Sub cmbRe10_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If cmbRe10.SelectedIndex = 1 Then
            Me.tbxMtoRet.Enabled = False
        Else
            Me.tbxMtoRet.Enabled = True

        End If
    End Sub

    Private Sub cmbEnInsp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If cmbEnInsp.SelectedIndex = 1 Then
            Me.dtpFecEnt.Enabled = False
        Else
            Me.dtpFecEnt.Enabled = True

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


    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        swMenuPpal = 1

        strMenu = "2"
        'strCodbus = Me.tbxCodp.Text
        frmSubmenup.ShowDialog()
        '  Me.tbxDescr.Focus()

    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        Try


            strTabPages = tbcProy.SelectedIndex + 1
            If strTabPages < 5 Then
                tbcProy.SelectedTab = Me.tbcProy.TabPages(strTabPages)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub


    Private Sub tbxCodp_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            swMenuPpal = 1
            strMenu = "2"
            'strCodbus = tbxCodp.Text

            frmSubmenup.ShowDialog()
            'Me.cmbClas.Focus()

        End If
    End Sub

    Private Sub tbxDescr_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'If e.KeyChar = Convert.ToChar(Keys.Return) Then
        '    strDescProy = tbxDescr.Text
        '    cmbClas.Focus()
        'End If
    End Sub

    Private Sub cmbClas_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.tbxNroCon.Focus()
    End Sub

    Private Sub tbxNroCon_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            'If tbxNroCon.Text <> "" Then
            '    insertNroCont(Me.lblid.Text, Me.tbxCodp.Text, Me.tbxNroCon.Text, Me.tbxNroReci.Text, Me.tbxNroFac.Text)

            '    Me.tbxUbi.Focus()
            'End If
        End If
    End Sub

    Private Sub tbxUbi_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            'Me.txtMonto.Focus()

        End If
    End Sub

    Private Sub txtMonto_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        'bolValor = Numerico(txtMonto.Text)
        'If bolValor = False Then

        '    If e.KeyChar = Convert.ToChar(Keys.Return) Then
        '        txtMonto.Text = decimales(txtMonto.Text) 'Format(CDec(txtMonto.Text), "C")
        '        e.Handled = True
        '        Me.txtCuenta.Focus()


        '    End If

        'Else
        '    intk = 0
        '    MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
        '    Me.txtMonto.SelectAll()
        'End If

    End Sub

    Private Sub txtCuenta_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = EnteroKey(System.Convert.ToInt16(Asc(e.KeyChar)))
        Try


            'bolValor = Numerico(txtCuenta.Text)
            'If bolValor = False Then

            '    If e.KeyChar = Convert.ToChar(Keys.Return) Then

            '        e.Handled = True
            '        Me.dtpFd.Focus()

            '    End If

            'Else
            '    intk = 0
            '    MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            '    Me.txtCuenta.SelectAll()
            'End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dtpFd_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            'Me.dtpFH.Focus()

        End If
    End Sub

    Private Sub dtpFH_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            'Me.tbxTraR.Focus()

        End If
    End Sub

    Private Sub tbxTraR_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        'bolValor = Numerico(tbxTraR.Text)
        'If bolValor = False Then

        '    If e.KeyChar = Convert.ToChar(Keys.Return) Then

        '        e.Handled = True
        '        tbxTraR.Text = decimales(tbxTraR.Text)
        '        Me.dtpFechaR.Focus()

        '    End If

        'Else
        '    intk = 0
        '    MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
        '    Me.tbxTraR.SelectAll()
        'End If


    End Sub

    Private Sub dtpFechaR_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            'Me.txtInsp.Focus()
        End If
    End Sub

    Private Sub txtInsp_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        'bolValor = Numerico(txtInsp.Text)
        'If bolValor = False Then

        '    If e.KeyChar = Convert.ToChar(Keys.Return) Then

        '        e.Handled = True
        '        txtInsp.Text = decimales(txtInsp.Text)
        '        Me.dtpPIns.Focus()

        '    End If

        'Else
        '    intk = 0
        '    MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
        '    Me.txtInsp.SelectAll()
        'End If
    End Sub

    Private Sub dtpPIns_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            'Me.txtDur.Focus()
        End If
    End Sub

    Private Sub txtDur_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        'bolValor = Numerico(txtDur.Text)
        'If bolValor = False Then

        '    If e.KeyChar = Convert.ToChar(Keys.Return) Then

        '        e.Handled = True
        '        'Me.txtPercta.Focus()

        '    End If

        'Else
        '    intk = 0
        '    MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
        '    'Me.txtDur.SelectAll()
        'End If

    End Sub

    Private Sub txtPercta_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = EnteroKey(System.Convert.ToInt16(Asc(e.KeyChar)))
        Try


            'bolValor = Numerico(txtPercta.Text)
            'If bolValor = False Then

            '    If e.KeyChar = Convert.ToChar(Keys.Return) Then

            '        e.Handled = True
            '        Me.dtpFechai.Focus()

            '    End If

            'Else
            '    intk = 0
            '    MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            '    Me.txtPercta.SelectAll()
            'End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub dtpFechai_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            'Me.dtpFfOp.Focus()
        End If
    End Sub

    Private Sub dtpFfOp_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            'Me.cmbxSta.Focus()
        End If
    End Sub


    Private Sub cmbxSta_KeyDown_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'Me.cmbTipo.Focus()
    End Sub

    Private Sub cmbTipo_KeyDown_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If stridProy <> "" Then
            tbcProy.SelectedTab = tbcProy.TabPages(1)
            guardaActDPpalProy()
            'Me.tbxCont.Focus()
        Else
            MsgBox("Debe ingresar un Nro de Proyecto....", MsgBoxStyle.Critical, "Control Proyectos")

        End If
    End Sub

    Private Sub cmbClas_KeyDown_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'Me.tbxNroCon.Focus()
    End Sub

    Private Sub tbxCont_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            swMenuPpal = 0
            strMenu = "3"
            'strCodCont = Me.tbxCont.Text
            'Me.tbxClient.Focus()
            ' frmSubmenup.ShowDialog()
            ' me.tbxCont.Text = strDescCont

        End If
    End Sub

    Private Sub btnCont_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        swMenuPpal = 0
        strMenu = "8"
        'strCodCont = f15.tbxCont.Text
        frmSubmenup.ShowDialog()
    End Sub

    Private Sub tbxClient_KeyPress_2(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            swMenuPpal = 0
            strMenu = "4"
            'strCodCli = Me.tbxClient.Text
            'Me.tbxGProy.Focus()
            ' frmSubmenup.ShowDialog()
            'me.tbxClient.Text = strDescCli

        End If
    End Sub

    Private Sub btnClient_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        swMenuPpal = 0
        strMenu = "9"
        'strCodCli = f15.tbxClient.Text
        frmSubmenup.ShowDialog()
        'f15.tbxClient.Text = strDescCli

    End Sub

    Private Sub tbxGProy_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            'Me.tbxIng.Focus()

        End If
    End Sub

    Private Sub tbxIng_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            'Me.tbxCorCMop.Focus()

        End If
    End Sub

    Private Sub tbxCorCMop_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            'Me.tbxGob.Focus()

        End If
    End Sub

    Private Sub tbxGob_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            'Me.tbxEncG.Focus()

        End If
    End Sub

    Private Sub tbxEncG_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            'Me.tbxMtoT.Focus()

        End If
    End Sub

    Private Sub tbxMtoT_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        'bolValor = Numerico(tbxMtoT.Text)
        'If bolValor = False Then

        '    If e.KeyChar = Convert.ToChar(Keys.Return) Then
        '        tbxMtoT.Text = decimales(tbxMtoT.Text) 'Format(CDec(txtMonto.Text), "C")
        '        e.Handled = True
        '        Me.dtpFecT.Focus()

        '    End If

        'Else
        '    intk = 0
        '    MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
        '    Me.tbxMtoT.SelectAll()
        'End If
    End Sub

    Private Sub dtpFecT_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            'Me.dtpAnAnt.Focus()

        End If
    End Sub

    Private Sub dtpAnAnt_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            'Me.tbxMespro.Focus()

        End If
    End Sub

    Private Sub tbxMespro_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            'Me.dtpfecTraFac.Focus()

        End If
    End Sub

    Private Sub dtpfecTraFac_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            'Me.dtpfecTraFac1.Focus()

        End If
    End Sub

    Private Sub dtpfecTraFac1_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            If stridProy <> "" Then
                tbcProy.SelectedTab = tbcProy.TabPages(2)
                ' guardaActProyeDResp()
                Me.tbxNroFac.Focus()


            Else
                MsgBox("Debe ingresar un Nro de Proyecto....", MsgBoxStyle.Critical, "Control Proyectos")

            End If
        End If
    End Sub

    Private Sub tbxNroFac_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            'If Me.tbxNroFac.Text <> "" And Me.tbxCodp.Text <> "" Then

            '    'FactNro = Me.tbxNroFac.Text
            '    'RecNro = Me.tbxNroReci.Text
            '    'ContNro = Me.tbxNroCon.Text

            '    insertNroFact(Me.lblid.Text, Me.tbxCodp.Text, ContNro, RecNro, FactNro)

            '    FactNro = Me.tbxNroFac.Text
            '    RecNro = Me.tbxNroReci.Text
            '    ContNro = Me.tbxNroCon.Text

            '    guardaActProyeDFact15()
            '    guardaActProyeDCostos15()
            '    Me.dtpFecFac.Focus()

            'End If
        End If
    End Sub

    Private Sub dtpFecFac_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            Me.tbxFac.Focus()
        End If
    End Sub

    Private Sub tbxFac_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(tbxFac.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                tbxFac.Text = decimales(tbxFac.Text)
                e.Handled = True
                Me.cmbRe10.Focus()

            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxFac.SelectAll()
        End If
    End Sub



    Private Sub tbxMtoRet_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(tbxMtoRet.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                tbxMtoRet.Text = decimales(tbxMtoRet.Text)
                e.Handled = True
                Me.tbxAntMont.Focus()
            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxMtoRet.SelectAll()
        End If
    End Sub

    Private Sub tbxAntMont_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub tbxPena_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(tbxPena.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then

                tbxPena.Text = decimales(tbxPena.Text)
                e.Handled = True
                Me.tbxMtoITBMS.Focus()
            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxPena.SelectAll()
        End If
    End Sub

    Private Sub tbxRetMtoITBMS_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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



    Private Sub tbxCxC_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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
                Me.dtpCXC.Focus()
            End If
            If cmbEnInsp.SelectedIndex = 0 Then
                Me.dtpFecEnt.Focus()

            End If

        End If
    End Sub



    Private Sub cmbEnInsp_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEnInsp.SelectedIndexChanged

        If cmbEnInsp.SelectedIndex = 1 Then
            Me.dtpFecEnt.Enabled = False
        Else
            Me.dtpFecEnt.Enabled = True

        End If
    End Sub

    Private Sub dtpFecEnt_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFecEnt.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.dtpCXC.Focus()

        End If
    End Sub

    Private Sub dtpCXC_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpCXC.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            Me.cmbCtrlRec.Focus()
        End If
    End Sub

    Private Sub dtpFecTe_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFecTe.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.tbxPena.Focus()

        End If
    End Sub

    Private Sub dtpFecPago_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFecPago.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            If stridProy <> "" Then

                Me.dtpFecTe.Focus()


            Else
                MsgBox("Debe ingresar un Nro de Proyecto....", MsgBoxStyle.Critical, "Control Proyectos")

            End If


        End If
    End Sub

    Private Sub tbxNroReci_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxNroReci.KeyPress

        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            actualizaRec()

            FactNro = ""
            Rec = ""
            Rec1 = ""

            Me.dtpFecREC.Focus()


        End If
    End Sub

    Private Sub dtpFecREC_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFecREC.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            If stridProy <> "" Then
                ' tbcProy.SelectedTab = tbcProy.TabPages(3)

                Me.dtpFecPago.Focus()
            Else
                MsgBox("Debe ingresar un Nro de Proyecto....", MsgBoxStyle.Critical, "Control Proyectos")

            End If


        End If

    End Sub

    Private Sub dtpfCheq_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            Me.tbxNroCheque.Focus()
        End If
    End Sub

    Private Sub tbxNroCheque_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = EnteroKey(System.Convert.ToInt16(Asc(e.KeyChar)))
        Try


            bolValor = Numerico(tbxNroCheque.Text)
            If bolValor = False Then

                If e.KeyChar = Convert.ToChar(Keys.Return) Then
                    If Me.tbxNroFac.Text <> "" Then

                        e.Handled = True
                        Me.cmbCtrlRec.Focus()
                    Else
                        MsgBox("Campo de Factura se encuentra en blanco, por favor verifique", "Control Proyectos")
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



    Private Sub tbxMtoCxC_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(Me.tbxMtoCxC.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                tbxMtoCxC.Text = decimales(tbxMtoCxC.Text)
                e.Handled = True
                Me.cmbRango1.Focus()

            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxMtoCxC.SelectAll()
        End If
    End Sub

    Private Sub tbxMonto2_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(Me.tbxMonto2.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                tbxMonto2.Text = decimales(tbxMonto2.Text)
                e.Handled = True
                Me.cmbstatus.Focus()

            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxMonto2.SelectAll()
        End If

    End Sub

    Private Sub tbx_MesEje_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            Me.tbxDocNext.Focus()
        End If
    End Sub

    Private Sub tbxDocNext_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            Me.tbxScafid.Focus()
        End If
    End Sub

    Private Sub tbxScafid_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            Me.dtpFecRefr.Focus()
        End If
    End Sub



    Private Sub cmbRe10_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            If cmbRe10.SelectedIndex = 1 Then
                Me.tbxAntMont.Focus()
            End If
            If cmbRe10.SelectedIndex = 0 Then
                Me.tbxMtoRet.Focus()
            End If

        End If
    End Sub

    Private Sub cmbRe10_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If cmbRe10.SelectedIndex = 1 Then
            Me.tbxMtoRet.Enabled = False
        Else
            Me.tbxMtoRet.Enabled = True

        End If
    End Sub



    Private Sub btnG_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FactNro = Me.tbxNroFac.Text
        RecNro = Me.tbxNroReci.Text

        If stridProy <> "" Then
            ConexionSQL()
            'insertNroFact(Me.lblid.Text, Me.tbxCodp.Text, Me.tbxNroCon.Text, Me.tbxNroReci.Text, Me.tbxNroFac.Text)
            'insertNroRec(Me.lblid.Text, Me.tbxCodp.Text, Me.tbxNroCon.Text, Me.tbxNroReci.Text, Me.tbxNroFac.Text)
            'GuardarALLproy()


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


        FactNro = Me.tbxNroFac.Text
        RecNro = Me.tbxNroReci.Text

        If stridProy <> "" And ProyNro <> "" Then
            Dim frm As New frmProcess
            frm.Show()
            For x As Int32 = 0 To 1

                ConexionSQL()
                '  insertNroFact(stridProy, ProyNro, ContNro, Me.tbxNroReci.Text, Me.tbxNroFac.Text)
                swRec = 2
                insertNroRec(stridProy, ProyNro, ContNro, Me.tbxNroReci.Text, Me.tbxNroFac.Text)

                stridProy = idProyecto(stridProy)
                GuardarALLproy15()
                insertaDatosfactCtas()
                Exit For
                'Application.DoEvents()
            Next
            frm.Close()

            If swguar = 0 Then
                MsgBox("Datos Guardados....", MsgBoxStyle.Information, "Control Proyectos")
            End If

        Else
            MsgBox("Debe ingresar un Nro de Proyecto....", MsgBoxStyle.Critical, "Control Proyectos")

        End If
        clearFormularios15()

        CtaNro = 0
        ProyNro = ""
        ContNro = ""
        RecNro = ""
        FactNro = ""
        idProy = 0
        swRec = 0

        ' llenarFactPagosf15()
        Me.cmbEnInsp.Focus()
    End Sub
    Sub insertaDatosfactCtas()
        ConexionSQL()
        Try
            Dim strPpal As New ADODB.Recordset
            Dim id As Integer = 0


            ConexionSQL()

         

            cntSQL.Execute("UPDATE tab_DatosPpalProy_Compl SET  pro_serieCuenta='" & tbxCtaNro.Text & "', " _
                            & " pro_FechaD='" & Format(dptFechai.Value, "yyyyMMdd") & "', " _
                            & " pro_FechaH='" & Format(dtpFechaf.Value, "yyyyMMdd") & "', " _
                            & " pro_TrabajoR=" & Replace(IIf(tbxTreal.Text = "", 0, tbxTreal.Text), ",", "") & ", " _
                            & " pro_FechaR='" & Format(dtpFechare.Value, "yyyyMMdd") & "', " _
                            & " pro_PresInsp= " & Replace(IIf(tbxPresIns.Text = "", 0, tbxPresIns.Text), ",", "") & ", " _
                            & " pro_FechaP='" & Format(dtpFecP.Value, "yyyyMMdd") & "' " _
                            & " where pro_idProyecto=" & stridProy & " and pro_nroProyecto='" & ProyNro & "' " _
                            & " and pro_nroContrato='" & ContNro & "' and pro_NroFactura='" & FactNro & "'")



            'limpia los campos 
            tbxFact.Text = ""
            tbxCtaNro.Text = ""
            'dptFechai.Value = Date.Now
            'dtpFechaf.Value = Date.Now
            tbxTreal.Text = ""
            'dtpFechare.Value = Date.Now
            tbxPresIns.Text = ""
            ' dtpFecP.Value = Date.Now
            tbxDur.Text = ""
            cmbPerPCtas.SelectedItem = -1
            'dtpFechIp.Value = Date.Now
            'dtpFecFinOrPr.Value = Date.Now
            cmbSt.SelectedItem = -1
            cmbTip.SelectedItem = -1

        Catch ex As Exception
            MsgBox("Error en funcion insertaDatosfactCtas()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
            swguar = 1
        End Try
    End Sub


    Private Sub ToolStripButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton12.Click


        CtaNro = 0
        ProyNro = ""
        ContNro = ""
        RecNro = ""
        FactNro = ""
        idProy = 0
        Me.Close()
    End Sub


    Private Sub tbxMtoITBMS_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub cmbRe10_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If cmbRe10.SelectedIndex = 2 Then
            Me.tbxAntMont.Focus()
        End If
        If cmbRe10.SelectedIndex = 1 Then
            Me.tbxMtoRet.Focus()
        End If
    End Sub

    Private Sub cmbRe10_KeyDown_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If cmbRe10.SelectedIndex = 2 Then
            Me.tbxAntMont.Focus()
        End If
        If cmbRe10.SelectedIndex = 1 Then
            Me.tbxMtoRet.Focus()
        End If
    End Sub

    Private Sub rdbtn1_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbtn1.CheckedChanged

        If rdbtn1.Checked = True Then

            Try
                FactNro = Me.tbxNroFac.Text
                RecNro = Me.tbxNroReci.Text
                Dim strFact As ADODB.Recordset
                ConexionSQL()

                Dim i As Integer = 0
                Me.ltvDetfact.Items.Clear()
                strFact = cntSQL.Execute("exec p_BuscaProyectos '" & ProyNro & "', '" & ContNro & "', '" & FactNro & "'")

                Do While Not strFact.EOF

                    If strFact.Fields("NroFactura").Value Is DBNull.Value Then
                        MsgBox("No existen facturas para este proyecto", MsgBoxStyle.Exclamation, "Control Proyectos")
                    Else

                        Me.ltvDetfact.Items.Add(strFact.Fields("NroProyecto").Value)
                        Me.ltvDetfact.Items(i).SubItems.Add(IIf(strFact.Fields("NroContrato").Value Is DBNull.Value, "", strFact.Fields("NroContrato").Value))
                        Me.ltvDetfact.Items(i).SubItems.Add(IIf(strFact.Fields("FechaFactura").Value Is DBNull.Value, "", strFact.Fields("FechaFactura").Value))
                        Me.ltvDetfact.Items(i).SubItems.Add(IIf(strFact.Fields("NroFactura").Value Is DBNull.Value, "", strFact.Fields("NroFactura").Value))
                        Me.ltvDetfact.Items(i).SubItems.Add(IIf(strFact.Fields("MontoFactura").Value Is DBNull.Value, "", strFact.Fields("MontoFactura").Value))
                        Me.ltvDetfact.Items(i).SubItems.Add(IIf(strFact.Fields("CuentaCobrar").Value Is DBNull.Value, "", strFact.Fields("CuentaCobrar").Value))
                        Me.ltvDetfact.Items(i).SubItems.Add(IIf(strFact.Fields("FechaPago").Value Is DBNull.Value, "", strFact.Fields("FechaPago").Value))
                        Me.ltvDetfact.Items(i).SubItems.Add(IIf(strFact.Fields("MontoCheque").Value Is DBNull.Value, "", strFact.Fields("MontoCheque").Value))
                        Me.ltvDetfact.Items(i).SubItems.Add(IIf(strFact.Fields("DocPago").Value Is DBNull.Value, "", strFact.Fields("DocPago").Value))
                        Me.ltvDetfact.Items(i).SubItems.Add(IIf(strFact.Fields("FechaPago").Value Is DBNull.Value, "", strFact.Fields("FechaPago").Value))
                        Me.ltvDetfact.Items(i).SubItems.Add(IIf(strFact.Fields("MontoPago").Value Is DBNull.Value, "", strFact.Fields("MontoPago").Value))
                        Me.ltvDetfact.Items(i).SubItems.Add(IIf(strFact.Fields("Observaciones").Value Is DBNull.Value, "", strFact.Fields("Observaciones").Value))


                    End If
                    i += 1

                    strFact.MoveNext()
                Loop


            Catch ex As Exception
                MsgBox("Error en boton rdbtn1" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
            End Try
        End If
    End Sub

    Private Sub tdbtn2_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbtn2.CheckedChanged
        If tdbtn2.Checked = True Then

            Try
                'FactNro = Me.tbxNroFac.Text
                'RecNro = Me.tbxNroReci.Text

                'ltvDetfact
                Dim strFact As ADODB.Recordset
                ConexionSQL()

                Dim i As Integer = 0
                Me.ltvDetfact.Items.Clear()
                strFact = cntSQL.Execute("exec p_BuscaProyectos '" & ProyNro & "', '" & ContNro & "', '' ")

                Do While Not strFact.EOF

                    If strFact.Fields("NroFactura").Value Is DBNull.Value Then
                        MsgBox("No existen facturas para este proyecto", MsgBoxStyle.Exclamation, "Control Proyectos")
                    Else

                        Me.ltvDetfact.Items.Add(strFact.Fields("NroProyecto").Value)
                        Me.ltvDetfact.Items(i).SubItems.Add(IIf(strFact.Fields("NroContrato").Value Is DBNull.Value, "", strFact.Fields("NroContrato").Value))
                        Me.ltvDetfact.Items(i).SubItems.Add(IIf(strFact.Fields("FechaFactura").Value Is DBNull.Value, "", strFact.Fields("FechaFactura").Value))
                        Me.ltvDetfact.Items(i).SubItems.Add(IIf(strFact.Fields("NroFactura").Value Is DBNull.Value, "", strFact.Fields("NroFactura").Value))
                        Me.ltvDetfact.Items(i).SubItems.Add(IIf(strFact.Fields("MontoFactura").Value Is DBNull.Value, "", strFact.Fields("MontoFactura").Value))
                        Me.ltvDetfact.Items(i).SubItems.Add(IIf(strFact.Fields("CuentaCobrar").Value Is DBNull.Value, "", strFact.Fields("CuentaCobrar").Value))
                        Me.ltvDetfact.Items(i).SubItems.Add(IIf(strFact.Fields("FechaPago").Value Is DBNull.Value, "", strFact.Fields("FechaPago").Value))
                        Me.ltvDetfact.Items(i).SubItems.Add(IIf(strFact.Fields("MontoCheque").Value Is DBNull.Value, "", strFact.Fields("MontoCheque").Value))
                        Me.ltvDetfact.Items(i).SubItems.Add(IIf(strFact.Fields("DocPago").Value Is DBNull.Value, "", strFact.Fields("DocPago").Value))
                        Me.ltvDetfact.Items(i).SubItems.Add(IIf(strFact.Fields("FechaPago").Value Is DBNull.Value, "", strFact.Fields("FechaPago").Value))
                        Me.ltvDetfact.Items(i).SubItems.Add(IIf(strFact.Fields("MontoPago").Value Is DBNull.Value, "", strFact.Fields("MontoPago").Value))
                        Me.ltvDetfact.Items(i).SubItems.Add(IIf(strFact.Fields("Observaciones").Value Is DBNull.Value, "", strFact.Fields("Observaciones").Value))


                    End If
                    i += 1

                    strFact.MoveNext()
                Loop


            Catch ex As Exception
                MsgBox("Error en boton tdbtn2" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
            End Try
        End If
    End Sub


    Private Sub cmbCtrlRec_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.cmbCtrlRec.Focus()
    End Sub

    Private Sub cmbCtrlCheq_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.tbxMtoCxC.Focus()
    End Sub

    Private Sub cmbRango1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cmbRango2.Focus()
    End Sub

    Private Sub cmbRango2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cmbRango.Focus()
    End Sub

    Private Sub cmbRango_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.tbxMonto2.Focus()
    End Sub

    Private Sub cmbstatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        tbx_MesEje.Focus()

    End Sub

    Private Sub cmbCtrlRec_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Me.cmbCtrlCheq.Focus()
    End Sub

    Private Sub cmbCtrlCheq_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Me.tbxMtoCxC.Focus()
    End Sub

    Private Sub cmbRango1_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        cmbRango2.Focus()
    End Sub

    Private Sub cmbRango2_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        cmbRango.Focus()
    End Sub

    Private Sub cmbRango_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Me.tbxMonto2.Focus()
    End Sub




    Private Sub txtMonto_Leave(ByVal sender As Object, ByVal e As System.EventArgs)


        'bolValor = Numerico(txtMonto.Text)
        'If bolValor = False Then


        '    txtMonto.Text = decimales(txtMonto.Text) 'Format(CDec(txtMonto.Text), "C")

        '    Me.txtCuenta.Focus()




        'Else
        '    intk = 0
        '    MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
        '    Me.txtMonto.SelectAll()
        'End If
    End Sub

    Private Sub tbxTraR_Leave(ByVal sender As Object, ByVal e As System.EventArgs)


        'bolValor = Numerico(tbxTraR.Text)
        'If bolValor = False Then



        '    tbxTraR.Text = decimales(tbxTraR.Text)
        '    Me.dtpFechaR.Focus()



        'Else
        '    intk = 0
        '    MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
        '    Me.tbxTraR.SelectAll()
        'End If
    End Sub

    Private Sub txtInsp_Leave(ByVal sender As Object, ByVal e As System.EventArgs)


        'bolValor = Numerico(txtInsp.Text)
        'If bolValor = False Then




        '    txtInsp.Text = decimales(txtInsp.Text)
        '    Me.dtpPIns.Focus()



        'Else
        '    intk = 0
        '    MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
        '    Me.txtInsp.SelectAll()
        'End If
    End Sub

    Private Sub txtPercta_Leave(ByVal sender As Object, ByVal e As System.EventArgs)

        'Try


        '    bolValor = Numerico(txtPercta.Text)
        '    If bolValor = False Then

        '        Me.dtpFechai.Focus()
        '    Else
        '        intk = 0
        '        MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
        '        Me.txtPercta.SelectAll()
        '    End If

        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub tbxMtoT_Leave(ByVal sender As Object, ByVal e As System.EventArgs)


        'bolValor = Numerico(tbxMtoT.Text)
        'If bolValor = False Then


        '    tbxMtoT.Text = decimales(tbxMtoT.Text) 'Format(CDec(txtMonto.Text), "C")

        '    Me.dtpFecT.Focus()


        'Else
        '    intk = 0
        '    MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
        '    Me.tbxMtoT.SelectAll()
        'End If
    End Sub

    Private Sub tbxFac_Leave(ByVal sender As Object, ByVal e As System.EventArgs)


        bolValor = Numerico(tbxFac.Text)
        If bolValor = False Then


            tbxFac.Text = decimales(tbxFac.Text)

            Me.cmbRe10.Focus()



        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxFac.SelectAll()
        End If
    End Sub

    Private Sub tbxMtoRet_Leave(ByVal sender As Object, ByVal e As System.EventArgs)


        bolValor = Numerico(tbxMtoRet.Text)
        If bolValor = False Then


            tbxMtoRet.Text = decimales(tbxMtoRet.Text)

            Me.tbxAntMont.Focus()


        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxMtoRet.SelectAll()
        End If
    End Sub

    Private Sub tbxAntMont_Leave(ByVal sender As Object, ByVal e As System.EventArgs)


        bolValor = Numerico(tbxAntMont.Text)
        If bolValor = False Then



            tbxAntMont.Text = decimales(tbxAntMont.Text)

            Me.tbxPena.Focus()

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxAntMont.SelectAll()
        End If
    End Sub

    Private Sub tbxPena_Leave(ByVal sender As Object, ByVal e As System.EventArgs)


        bolValor = Numerico(tbxPena.Text)
        If bolValor = False Then



            tbxPena.Text = decimales(tbxPena.Text)

            Me.tbxMtoITBMS.Focus()


        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxPena.SelectAll()
        End If
    End Sub

    Private Sub tbxMtoITBMS_Leave(ByVal sender As Object, ByVal e As System.EventArgs)


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

    Private Sub tbxRetMtoITBMS_Leave(ByVal sender As Object, ByVal e As System.EventArgs)

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

    Private Sub tbxCxC_Leave(ByVal sender As Object, ByVal e As System.EventArgs)


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

    Private Sub tbxMtoCxC_Leave(ByVal sender As Object, ByVal e As System.EventArgs)


        bolValor = Numerico(Me.tbxMtoCxC.Text)
        If bolValor = False Then


            tbxMtoCxC.Text = decimales(tbxMtoCxC.Text)

            Me.cmbRango1.Focus()



        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxMtoCxC.SelectAll()
        End If
    End Sub





    Private Sub btnborrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        clearFormularios()
    End Sub

    Private Sub ToolStripButton2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        f25 = frmInsertaFactura

        If ProyNro <> "" Then
            f25.Text = "INSERTA FACTURA PROY NRO. " & ProyNro & " - " & strDescProy
            f25.ShowDialog()
        End If




        'clearDCostos15()
        'clearDfact15()

        'RecNro = ""
        'If ProyNro <> "" Then
        '    If ContNro <> "" Then
        '        If swInput = 0 Then

        '            If swMenuPpal = 0 Then
        '                'ContNro = f1.tbxNroCon.Text
        '                ProyNro = f1.tbxCodp.Text
        '            End If

        '            If swMenuPpal = 1 Then
        '                'ContNro = f15.tbxNroCon.Text
        '                'ProyNro = f15.tbxCodp.Text
        '            End If

        '            If FactNro <> "" Then
        '                If swMenuPpal = 0 Then
        '                    insertNroFact(idProy, ProyNro, ContNro, RecNro, FactNro)
        '                    guardaActProyeDFact()
        '                    guardaActProyeDCostos()
        '                End If

        '                If swMenuPpal = 1 Then
        '                    insertNroFact(idProy, ProyNro, ContNro, RecNro, FactNro)
        '                    guardaActProyeDFact15()
        '                    guardaActProyeDCostos15()
        '                End If
        '            End If

        '            f15.tbxNroFac.Focus()
        '            'llenarFactf15()
        '            llenarFactPagosf15()
        '        End If

        '    Else
        '        MsgBox("Debe seleccionar un item de la lista", vbCritical, "Control de Proyectos")
        '    End If



        'Else
        '    MsgBox("Debe Seleccionar un Proyecto", MsgBoxStyle.Information, "Control de Proyectos")
        'End If


        'Rec = ""
        'Rec1 = ""

    End Sub

    Private Sub tbxNroFac_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If Me.tbxNroFac.Text <> "" And Me.tbxCodp.Text <> "" Then

        '    FactNro = Me.tbxNroFac.Text
        '    RecNro = Me.tbxNroReci.Text
        '    ContNro = Me.tbxNroCon.Text

        '    insertNroFact(Me.lblid.Text, Me.tbxCodp.Text, Me.tbxNroCon.Text, Me.tbxNroReci.Text, Me.tbxNroFac.Text)

        '    FactNro = Me.tbxNroFac.Text
        '    RecNro = Me.tbxNroReci.Text
        '    ContNro = Me.tbxNroCon.Text

        '    guardaActProyeDFact15()
        '    guardaActProyeDCostos15()
        '    Me.dtpFecFac.Focus()

        'End If
    End Sub

    Private Sub tbxDescr_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'strDescProy = tbxDescr.Text
    End Sub

    Private Sub tbxNroCheque_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If Me.tbxNroFac.Text <> "" Then

            Me.cmbCtrlRec.Focus()
        Else
            MsgBox("Campo de Factura se encuentra en blanco, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")

        End If

    End Sub

    Private Sub frmMenuProyectoIncluir_LocationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LocationChanged

    End Sub

    Private Sub ToolStripButton3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub




    Private Sub ToolStripButton6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        swMenuPpal = 1
        clearDCostos15()
        clearDfact15()

        Me.ltvDetfact.Items.Clear()
        frmInicioproyectos.ShowDialog()



    End Sub

    'Private Sub ltwFacturas_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    '    If e.Button = Windows.Forms.MouseButtons.Right Then
    '        ltwFacturas.ContextMenuStrip = ContextMenuStrip1
    '    Else
    '        ltwFacturas.ContextMenuStrip = ContextMenuStrip1
    '    End If
    'End Sub

    Private Sub BtnInsertar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInsertar.Click
        swRec = 1

        frmInputRec.ShowDialog()

        If swInput = 0 Then


            If tbxNroReci.Text <> "" And ProyNro <> "" Then
                'insertNroFact(Me.lblid.Text, Me.tbxCodp.Text, Me.tbxNroCon.Text, Me.tbxNroReci.Text, Me.tbxNroFac.Text)

                insertNroRec(idProy, ProyNro, ContNro, Rec, FactNro)
                guardaActProyeDFact15()
                guardaActProyeDCostos15()
                'llenarFactf15()
                Me.dtpFecREC.Focus()
            Else
                MsgBox("Debe ingresar un Nro de Recibo....", MsgBoxStyle.Critical, "Control Proyectos")

            End If

        End If
        FactNro = ""
        Rec = ""
        Rec1 = ""
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ActualizarNroReciboToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarNroReciboToolStripMenuItem.Click
        If Me.ltwPagosParciales.Items.Count > 0 Then

            For i = 0 To Me.ltwPagosParciales.Items.Count - 1

                If Me.ltwPagosParciales.Items(i).Selected = True Then

                    ProyNro = Me.ltwPagosParciales.FocusedItem.SubItems(0).Text
                    ContNro = Me.ltwPagosParciales.FocusedItem.SubItems(1).Text
                    Rec1 = Me.ltwPagosParciales.FocusedItem.SubItems(3).Text
                    FactNro = Me.ltwPagosParciales.FocusedItem.SubItems(2).Text
                    selected = Me.ltwPagosParciales.FocusedItem.SubItems(2).Text
                End If
            Next
            actualizaRec()
        End If
        FactNro = ""
        Rec = ""
        Rec1 = ""

    End Sub
    Sub actualizaRec()
        Try


            swRec = 2


            If selected <> "" Then
                frmInputRec.ShowDialog()

                If swInput = 0 Then

                    If ProyNro <> "" Then

                        insertNroRec(idProy, ProyNro, ContNro, Rec, FactNro)

                        cntSQL.Execute("UPDATE [tab_Aux_FactProy] SET [pro_NroContrato]='" & ContNro & "', " _
                                       & " [pro_NroRecibo]='" & f15.tbxNroReci.Text & "', " _
                                       & " [pro_nroProyecto]='" & ProyNro & "', " _
                                       & " [pro_FechaRes]= '" & Format(f15.dtpFecREC.Value, "yyyyMMdd") & "', " _
                                       & " [pro_NroFactura]='" & f15.tbxNroFac.Text & "', " _
                                       & " [pro_FechaFact]='" & Format(f15.dtpFecFac.Value, "yyyyMMdd") & "', " _
                                       & " [pro_trabajoFac]=" & Replace(IIf(f15.tbxFac.Text = "", 0, f15.tbxFac.Text), ",", "") & ", " _
                                       & " [pro_Rete10]='" & f15.cmbRe10.SelectedIndex & "', " _
                                       & " [pro_MtoRete10]= " & Replace(IIf(f15.tbxMtoRet.Text = "", 0, f15.tbxMtoRet.Text), ",", "") & ", " _
                                       & " [pro_Anticipo]=" & Replace(IIf(f15.tbxAntMont.Text = "", 0, f15.tbxAntMont.Text), ",", "") & ", " _
                                       & " [pro_Penalizacion]=" & Replace(IIf(f15.tbxPena.Text = "", 0, f15.tbxPena.Text), ",", "") & ", " _
                                       & " [pro_RETdeITBMS]=" & Replace(IIf(f15.tbxRetMtoITBMS.Text = "", 0, f15.tbxRetMtoITBMS.Text), ",", "") & ", " _
                                       & " [pro_MontoITBMS]=" & Replace(IIf(f15.tbxMtoITBMS.Text = "", 0, f15.tbxMtoITBMS.Text), ",", "") & ", " _
                                       & " [pro_CuentaCobrar]=" & Replace(IIf(f15.tbxCxC.Text = "", 0, f15.tbxCxC.Text), ",", "") & ", " _
                                       & " [pro_EntrInsp]='" & f15.cmbEnInsp.SelectedIndex & "', " _
                                       & " [pro_FechaCliente]='" & Format(f15.dtpFecEnt.Value, "yyyyMMdd") & "', " _
                                       & " [pro_FechaCxc]='" & Format(f15.dtpCXC.Value, "yyyyMMdd") & "', " _
                                       & " [pro_FechaTes]='" & Format(f15.dtpFecTe.Value, "yyyyMMdd") & "', " _
                                       & " [pro_FechaPago]='" & Format(f15.dtpFecPago.Value, "yyyyMMdd") & "' ," _
                                       & " pro_montoCheque=" & Replace(IIf(f15.tbxMtoCheq.Text = "", 0, f15.tbxMtoCheq.Text), ",", "") & " " _
                                       & "  where pro_idProyecto='" & stridProy & "' and pro_NroContrato='" & ContNro & "' and  pro_NroFactura='" & FactNro & "' and pro_NroRecibo='" & Rec1 & "'")

                        guardaActProyeDCostos15()
                        ConexionSQL()
                        ' se ejecuta el sp de las cuentas para insertar por factura y proyecto
                        cntSQL.Execute("exec p_InsertaRegCtasFacturas '" & ProyNro & "','" & stridProy & "','" & ContNro & "','" & FactNro & "'")
                        llenarFactPagosf15()
                        Me.dtpFecREC.Focus()
                    Else
                        MsgBox("Debe ingresar un Nro de Recibo....", MsgBoxStyle.Critical, "Control Proyectos")

                    End If
                End If
            Else
                MsgBox("Debe Seleccionar el Número de Factura a Editar....", MsgBoxStyle.Critical, "Control Proyectos")
            End If

        Catch ex As Exception

        End Try
        Rec1 = ""
        selected = ""
        llenarFactPagosf15()
    End Sub

    Sub actualizaRec1()
        Try


            swRec = 2

            frmInputRec.ShowDialog()

            If swInput = 0 Then

                If ProyNro <> "" Then

                    insertNroRec(idProy, ProyNro, ContNro, Rec, FactNro)

                    guardaActProyeDFact15()
                    guardaActProyeDCostos15()
                    'llenarFactf15()
                    llenarFactPagosf15()
                    Me.dtpFecREC.Focus()
                Else
                    MsgBox("Debe ingresar un Nro de Recibo....", MsgBoxStyle.Critical, "Control Proyectos")

                End If
            End If


        Catch ex As Exception

        End Try
        Rec1 = ""
        selected = ""
    End Sub

    Private Sub InsertarNroReciboToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertarNroReciboToolStripMenuItem.Click

        frmInputRec.ShowDialog()

        If swInput = 0 Then


            If tbxNroReci.Text <> "" And ProyNro <> "" Then
                'insertNroFact(Me.lblid.Text, Me.tbxCodp.Text, Me.tbxNroCon.Text, Me.tbxNroReci.Text, Me.tbxNroFac.Text)

                insertNroRec(idProy, ProyNro, ContNro, Rec, FactNro)
                guardaActProyeDFact15()
                guardaActProyeDCostos15()
                'llenarFactf15()
                Me.dtpFecREC.Focus()
            Else
                MsgBox("Debe ingresar un Nro de Recibo....", MsgBoxStyle.Critical, "Control Proyectos")

            End If

        End If

        'FactNro = ""
        'Rec = ""
        'Rec1 = ""
    End Sub

    Private Sub btnBusFact_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusFact.Click
        swMenuPpal = 1
        frmFacturasResumen.ShowDialog()
    End Sub



    Private Sub tbxScafid_KeyPress_2(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxScafid.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.dtpFecRefr.Focus()

        End If
    End Sub

    Private Sub tbxDocNext_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxDocNext.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.tbxScafid.Focus()

        End If
    End Sub

    Private Sub tbx_MesEje_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_MesEje.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.tbxDocNext.Focus()

        End If
    End Sub

    Private Sub cmbCtrlCheq_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbCtrlCheq.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            If cmbCtrlCheq.SelectedIndex = 1 Then
                Me.tbxNroCheque.Enabled = False
                tbxMtoCheq.Enabled = False
                tbx_MesEje.Focus()
            Else
                Me.tbxNroCheque.Focus()
                tbxMtoCheq.Enabled = True

            End If

        End If
    End Sub

    Private Sub cmbCtrlRec_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.cmbCtrlCheq.Focus()

        End If
    End Sub

    Private Sub tbxNroCheque_KeyPress_2(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxNroCheque.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            Me.tbxMtoCheq.Focus()

        End If
    End Sub


    Private Sub dtpfCheq_KeyPress_2(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpfCheq.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            Me.cmbCtrlCheq.Focus()
        End If
    End Sub



    'Private Sub ltwFacturas_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ltwFacturas.Click
    '    If Me.ltwFacturas.Items.Count > 0 Then

    '        For i = 0 To Me.ltwFacturas.Items.Count - 1

    '            If Me.ltwFacturas.Items(i).Selected = True Then
    '                ProyNro = Me.ltwFacturas.FocusedItem.SubItems(0).Text
    '                ContNro = Me.ltwFacturas.FocusedItem.SubItems(1).Text
    '                RecNro = Me.ltwFacturas.FocusedItem.SubItems(3).Text
    '                FactNro = Me.ltwFacturas.FocusedItem.SubItems(2).Text

    '            End If

    '        Next

    '    End If

    '    If swMenuPpal <> 3 Then
    '        ConsultasDFactf15()
    '        ConsultasDCostosf15()
    '    End If

    '    If swMenuPpal = 3 Then
    '        f15.Close()

    '    End If
    'End Sub

    Private Sub ltwFacturas_MouseDown_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        'If e.Button = Windows.Forms.MouseButtons.Right Then
        '    ltwFacturas.ContextMenuStrip = ContextMenuStrip1
        'Else
        '    ltwFacturas.ContextMenuStrip = ContextMenuStrip1
        'End If
    End Sub

    'Private Sub ltwFacturas_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ltwFacturas.Click
    '    If Me.ltwFacturas.Items.Count > 0 Then

    '        For i = 0 To Me.ltwFacturas.Items.Count - 1

    '            If Me.ltwFacturas.Items(i).Selected = True Then
    '                ProyNro = Me.ltwFacturas.FocusedItem.SubItems(0).Text
    '                ContNro = Me.ltwFacturas.FocusedItem.SubItems(1).Text
    '                RecNro = Me.ltwFacturas.FocusedItem.SubItems(3).Text
    '                FactNro = Me.ltwFacturas.FocusedItem.SubItems(2).Text

    '            End If

    '        Next

    '    End If

    '    If swMenuPpal <> 3 Then
    '        ConsultasDFactf15()
    '        ConsultasDCostosf15()
    '    End If

    '    If swMenuPpal = 3 Then
    '        f15.Close()

    '    End If
    'End Sub

    Private Sub ToolStripButton3_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click


        frmPagos.ShowDialog()

    End Sub




    Sub llenarFactPagosf15()
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
                ' f15.ltwPagosParciales.Items(i).SubItems.Add(strDatos.Fields("pro_Tipodoc").Value)
                i += 1
                strDatos.MoveNext()
            Loop

        Catch ex As Exception
            MsgBox("Error en buscar Nro de llenarFactPagosf15" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub

    Private Sub ltwPagosParciales_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ltwPagosParciales.SelectedIndexChanged

        If Me.ltwPagosParciales.Items.Count > 0 Then

            For i = 0 To Me.ltwPagosParciales.Items.Count - 1

                If Me.ltwPagosParciales.Items(i).Selected = True Then
                    ProyNro = Me.ltwPagosParciales.FocusedItem.SubItems(0).Text
                    ContNro = Me.ltwPagosParciales.FocusedItem.SubItems(1).Text
                    RecNro = Me.ltwPagosParciales.FocusedItem.SubItems(3).Text
                    FactNro = Me.ltwPagosParciales.FocusedItem.SubItems(2).Text
                    FactNrocta = Me.ltwPagosParciales.FocusedItem.SubItems(2).Text

                    'limpia los campos 
                    tbxFact.Text = ""
                    tbxCtaNro.Text = ""
                    'dptFechai.Value = Date.Now
                    'dtpFechaf.Value = Date.Now
                    tbxTreal.Text = ""
                    ' dtpFechare.Value = Date.Now
                    tbxPresIns.Text = ""
                    'dtpFecP.Value = Date.Now
                    tbxDur.Text = ""
                    cmbPerPCtas.SelectedIndex = -1
                    'dtpFechIp.Value = Date.Now
                    'dtpFecFinOrPr.Value = Date.Now
                    cmbSt.SelectedIndex = -1
                    cmbTip.SelectedIndex = -1


                    clearDCostos15()
                    clearDfact15()


                    Exit For
                End If

            Next

        End If

        If swMenuPpal <> 3 Then
            'frmInputctas.actualizaFechaEstCobros()
            ConsultasDFactf15()
            ConsultasDCostosf15()
            llenarFacturasCtas()
            frmNroctaproy.llenarNrocta()

        End If

        If swMenuPpal = 3 Then
            f15.Close()
        End If
        llenarFactRelPagos()
    End Sub
    Sub llenarFacturasCtas()
        Try
            Dim strCtas As ADODB.Recordset
            Dim strdias As ADODB.Recordset
            Dim strdias1 As ADODB.Recordset
            Dim dias As String
            Dim dias1 As Integer
            ConexionSQL()
           

            strCtas = cntSQL.Execute("select [pro_idProyecto],[pro_nroProyecto],[pro_nroContrato],[pro_nroCuenta],[pro_serieCuenta],[pro_FechaD],[pro_FechaH],[pro_TrabajoR],[pro_FechaR],[pro_PresInsp],[pro_FechaP],[pro_NroFactura],[pro_status]" _
           & " FROM tab_DatosPpalProy_Compl where pro_nroProyecto='" & ProyNro & "' and pro_nroContrato='" & ContNro & "' and pro_NroFactura='" & FactNro & "' ")

            Do While Not strCtas.EOF

                Me.tbxFact.Text = strCtas.Fields("pro_nroFactura").Value
                Me.tbxCtaNro.Text = strCtas.Fields("pro_serieCuenta").Value
                Me.dptFechai.Value = strCtas.Fields("pro_FechaD").Value
                Me.dtpFechaf.Value = strCtas.Fields("pro_FechaH").Value
                Me.tbxTreal.Text = decimales(strCtas.Fields("pro_TrabajoR").Value)
                Me.dtpFechare.Value = strCtas.Fields("pro_FechaR").Value
                Me.tbxPresIns.Text = strCtas.Fields("pro_PresInsp").Value
                Me.dtpFecP.Value = strCtas.Fields("pro_FechaP").Value
                'Me.tbxDur.Text = strCtas.Fields("pro_duracionProy").Value
                'Me.cmbPerPCtas.SelectedItem = buscacmbperPagCtas(strCtas.Fields("pro_periodoCuenta").Value)
                'Me.dtpFechIp.Value = strCtas.Fields("pro_FechaInicio").Value
                'Me.dtpFecFinOrPr.Value = strCtas.Fields("pro_FechaFinOrig").Value
                'Me.cmbSt.SelectedItem = buscaComboStatus(strCtas.Fields("pro_status").Value)
                'Me.cmbTip.SelectedItem = buscaComboTipo(strCtas.Fields("pro_tipo").Value)

                strCtas.MoveNext()

            Loop
            ConexionSQL()
            ' se ejecuta el sp de las cuentas para insertar por factura y proyecto
            strdias = cntSQL.Execute("exec p_modificafechaestpago '" & ProyNro & "','" & stridProy & "','" & ContNro & "'")

            If strdias.EOF = False Then

                ' se ejecuta el sp de las cuentas para insertar por factura y proyecto
                dias = strdias.Fields(0).Value
                strdias1 = cntSQL.Execute("SELECT [dbo].[EXTRACT_PER] ( '" & dias & "')")

                If strdias1.EOF = False Then
                    dias1 = strdias1.Fields(0).Value
                    Me.dtpFecEs.Value = Me.dtpFechaf.Value.AddDays(dias1)

                End If


            End If


        Catch ex As Exception
            MsgBox("Error en buscar Nro de llenarFacturasCtas()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
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
    Sub llenarComboTipo()
        Try
            Dim strTipo As New ADODB.Recordset
            Me.cmbTip.Items.Clear()

            strTipo = cntSQL.Execute("SELECT  [des_tipo] FROM [dbo].[tab_Tipo]")

            Do While Not strTipo.EOF
                Me.cmbTip.Items.Add(strTipo.Fields(0).Value)

                strTipo.MoveNext()
            Loop


        Catch ex As Exception
            MsgBox("Error en funcion llenarComboTipo" & ex.Message)
        End Try
    End Sub

    Private Sub ltwPagosParciales_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ltwPagosParciales.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            ltwPagosParciales.ContextMenuStrip = cmFacturas
        Else
            ltwPagosParciales.ContextMenuStrip = cmFacturas
        End If
    End Sub





    Sub llenarFactRelPagos()
        Try
            ConexionSQL()
            Dim strDatos As New ADODB.Recordset
            'Dim strsql As String
            Dim i As Integer = 0
            intMontAb = 0
            Dim abono As Decimal = 0

            Me.ltwPagosRel.Items.Clear()

            strDatos = cntSQL.Execute("select * from tab_Rel_FacturasPagos where pro_NroContrato='" & ContNro & "' and pro_NroProyecto='" & ProyNro & "' and pro_NroFactura='" & FactNro & "' and pro_NroRecibo='" & LTrim(RTrim(RecNro)) & "'")

            Do While Not strDatos.EOF

                f15.ltwPagosRel.Items.Add(IIf(strDatos.Fields("pro_NroFactura").Value Is DBNull.Value, "", strDatos.Fields("pro_NroFactura").Value))
                f15.ltwPagosRel.Items(i).SubItems.Add(IIf(strDatos.Fields("pro_FechaFactura").Value Is DBNull.Value, "1900-01-01", strDatos.Fields("pro_FechaFactura").Value))
                f15.ltwPagosRel.Items(i).SubItems.Add(IIf(strDatos.Fields("pro_NroCheque").Value Is DBNull.Value, "", strDatos.Fields("pro_NroCheque").Value))
                f15.ltwPagosRel.Items(i).SubItems.Add(IIf(strDatos.Fields("pro_FechaPago").Value Is DBNull.Value, "1900-01-01", strDatos.Fields("pro_FechaPago").Value))
                f15.ltwPagosRel.Items(i).SubItems.Add(decimales(IIf(strDatos.Fields("pro_MontoPago").Value Is DBNull.Value, 0, strDatos.Fields("pro_MontoPago").Value)))
                f15.ltwPagosRel.Items(i).SubItems.Add(IIf(strDatos.Fields("pro_NroCheque").Value Is DBNull.Value, "", strDatos.Fields("pro_NroCheque").Value))
                f15.ltwPagosRel.Items(i).SubItems.Add(IIf(strDatos.Fields("pro_Tipodoc").Value Is DBNull.Value, "", strDatos.Fields("pro_Tipodoc").Value))
                abono = IIf(strDatos.Fields("pro_MontoPago").Value Is DBNull.Value, 0, strDatos.Fields("pro_MontoPago").Value)
                intMontAb = intMontAb + abono

                i += 1
                strDatos.MoveNext()
            Loop
            ' Dim strsql As String = "select * from tab_Rel_FacturasPagos where pro_NroContrato='" & ContNro & "' and pro_NroProyecto='" & ProyNro & "' and pro_NroFactura='" & FactNro & "' and pro_NroRecibo='" & LTrim(RTrim(RecNro)) & "'"
            f15.tbxSaldoFact.Text = decimales(IIf(f15.tbxCxC.Text = "", 0, f15.tbxCxC.Text) - intMontAb)

            ' MsgBox(strsql)
        Catch ex As Exception
            MsgBox("Error en funcion llenarFactRelPagos()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub


    Private Sub ltwPagosRel_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ltwPagosRel.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            ltwPagosRel.ContextMenuStrip = cmPagos
        Else
            ltwPagosRel.ContextMenuStrip = cmPagos
        End If
    End Sub


    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Try
            Dim strElimPagos As ADODB.Recordset
            ConexionSQL()
            Dim docpago As String = ""
            Dim fecha As Date
            Dim preg As String = ""

            If Me.ltwPagosRel.Items.Count > 0 Then

                For i = 0 To Me.ltwPagosRel.Items.Count - 1

                    If Me.ltwPagosRel.Items(i).Selected = True Then
                        docpago = Me.ltwPagosRel.FocusedItem.SubItems(2).Text()
                        fecha = Me.ltwPagosRel.FocusedItem.SubItems(3).Text()

                        preg = MsgBox("Seguro que desea Eliminar el Pago " & docpago, MsgBoxStyle.YesNo, "Control Proyectos")
                        If preg = 6 Then

                            strElimPagos = cntSQL.Execute("select * FROM tab_Rel_FacturasPagos WHERE pro_NroProyecto='" & ProyNro & "' AND pro_NroContrato='" & ContNro & "' AND pro_NroFactura='" & FactNro & "' AND pro_DocPago='" & docpago & "' AND pro_FechaPago=' " & Format(fecha, "yyyyMMdd") & "'")

                            Do While Not strElimPagos.EOF
                                cntSQL.Execute("DELETE FROM tab_Rel_FacturasPagos WHERE pro_NroProyecto='" & ProyNro & "' AND pro_NroContrato='" & ContNro & "' AND pro_NroFactura='" & FactNro & "' AND pro_DocPago='" & docpago & "' AND pro_FechaPago=' " & Format(fecha, "yyyyMMdd") & "'")

                                Exit Do
                            Loop


                        Else

                            Exit Sub
                        End If



                    End If
                Next

            End If
        Catch ex As Exception
            MsgBox("Error Eliminar Pago ToolStripMenuItem2" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try

        llenarFactRelPagos()
        llenarFactPagosf15()


    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Try
            Dim strActPagos As ADODB.Recordset
            ConexionSQL()

            Dim fecha As Date
            Dim preg As String = ""

            If Me.ltwPagosRel.Items.Count > 0 Then

                For i = 0 To Me.ltwPagosRel.Items.Count - 1

                    If Me.ltwPagosRel.Items(i).Selected = True Then
                        DocPago = Me.ltwPagosRel.FocusedItem.SubItems(2).Text()
                        fecha = Me.ltwPagosRel.FocusedItem.SubItems(3).Text()
                        tPago = Me.ltwPagosRel.FocusedItem.SubItems(6).Text()

                        strActPagos = cntSQL.Execute("select * FROM tab_Rel_FacturasPagos WHERE pro_NroProyecto='" & ProyNro & "' AND pro_NroContrato='" & ContNro & "' AND pro_NroFactura='" & FactNro & "' AND pro_NroCheque='" & DocPago & "' AND pro_FechaPago=' " & Format(fecha, "yyyyMMdd") & "'")



                        Do While Not strActPagos.EOF

                            frmActualizaPago.tbxDocPago.Text = strActPagos.Fields("pro_DocPago").Value
                            frmActualizaPago.dtpFecPago.Text = strActPagos.Fields("pro_FechaPago").Value
                            frmActualizaPago.tbxConc.Text = strActPagos.Fields("pro_Observaciones").Value
                            frmActualizaPago.tbxMonto.Text = decimales(strActPagos.Fields("pro_MontoPago").Value)
                            'frmActualizaPago.cmbTdoc.SelectedItem = strActPagos.Fields("pro_Tipodoc").Value

                            DocPago = strActPagos.Fields("pro_DocPago").Value
                            FecPago = fecha


                            frmActualizaPago.ShowDialog()

                            Exit Do
                        Loop



                    End If
                Next

            End If


        Catch ex As Exception
            MsgBox("Error Eliminar Pago ToolStripMenuItem2" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try

        llenarFactRelPagos()
        swPagos = 0
    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        frmSincronizaA2.ShowDialog()
    End Sub

    Private Sub tbxPena_KeyPress_2(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxPena.KeyPress
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(tbxPena.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                tbxPena.Text = decimales(tbxPena.Text) 'Format(CDec(txtMonto.Text), "C")
                e.Handled = True
                dtpfCheq.Focus()


            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            f1.txtMonto.SelectAll()
        End If


    End Sub

    Private Sub tbxPena_Leave_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbxPena.Leave
        bolValor = Numerico(tbxPena.Text)
        If bolValor = False Then


            tbxPena.Text = decimales(tbxPena.Text) 'Format(CDec(txtMonto.Text), "C")

            dtpfCheq.Focus()

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            f1.txtMonto.SelectAll()
        End If
    End Sub

    Private Sub tbxMtoCheq_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxMtoCheq.KeyPress
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(tbxMtoCheq.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                tbxMtoCheq.Text = decimales(tbxMtoCheq.Text) 'Format(CDec(txtMonto.Text), "C")
                e.Handled = True
                tbx_MesEje.Focus()


            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            tbxMtoCheq.SelectAll()
        End If
    End Sub


    Private Sub cmbCtrlRec_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCtrlRec.SelectedIndexChanged

        'If LTrim(RTrim(cmbCtrlRec.Text)) = "SIN RECIBO" Then

        '    sinRecibo()

        'End If
        'If LTrim(RTrim(cmbCtrlRec.Text)) = "CON RECIBO" Then
        '    conRecibo()
        'End If



    End Sub
    Sub sinRecibo()

        Try
            ConexionSQL()
            Dim strDatos As New ADODB.Recordset
            Dim i As Integer = 0
            f15.ltwPagosParciales.Items.Clear()
            f15.ltwPagosRel.Items.Clear()
            strDatos = cntSQL.Execute("select pro_NroContrato, pro_NroFactura,pro_NroRecibo, sum (pro_trabajoFac)as pro_trabajoFac from tab_Aux_FactProy where pro_NroContrato='" & ContNro & "' and pro_nroProyecto='" & ProyNro & "' and pro_NroRecibo='' group by pro_NroContrato, pro_NroFactura,pro_NroRecibo")

            Do While Not strDatos.EOF

                f15.ltwPagosParciales.Items.Add(ProyNro)
                f15.ltwPagosParciales.Items(i).SubItems.Add(strDatos.Fields("pro_NroContrato").Value)
                f15.ltwPagosParciales.Items(i).SubItems.Add(strDatos.Fields("pro_NroFactura").Value)
                f15.ltwPagosParciales.Items(i).SubItems.Add(strDatos.Fields("pro_NroRecibo").Value)
                f15.ltwPagosParciales.Items(i).SubItems.Add(decimales(strDatos.Fields("pro_trabajoFac").Value))
                i += 1
                strDatos.MoveNext()
            Loop

        Catch ex As Exception
            MsgBox("Error en buscar Nro de llenarFact15()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try

    End Sub
    Sub conRecibo()

        Try
            ConexionSQL()
            Dim strDatos As New ADODB.Recordset
            Dim i As Integer = 0
            f15.ltwPagosParciales.Items.Clear()
            f15.ltwPagosRel.Items.Clear()
            strDatos = cntSQL.Execute("select pro_NroContrato, pro_NroFactura,pro_NroRecibo, sum (pro_trabajoFac)as pro_trabajoFac from tab_Aux_FactProy where pro_NroContrato='" & ContNro & "' and pro_nroProyecto='" & ProyNro & "' and pro_NroRecibo<>'' group by pro_NroContrato, pro_NroFactura,pro_NroRecibo")

            Do While Not strDatos.EOF

                f15.ltwPagosParciales.Items.Add(ProyNro)
                f15.ltwPagosParciales.Items(i).SubItems.Add(strDatos.Fields("pro_NroContrato").Value)
                f15.ltwPagosParciales.Items(i).SubItems.Add(strDatos.Fields("pro_NroFactura").Value)
                f15.ltwPagosParciales.Items(i).SubItems.Add(strDatos.Fields("pro_NroRecibo").Value)
                f15.ltwPagosParciales.Items(i).SubItems.Add(decimales(strDatos.Fields("pro_trabajoFac").Value))
                i += 1
                strDatos.MoveNext()
            Loop

        Catch ex As Exception
            MsgBox("Error en buscar Nro de llenarFact15()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try

    End Sub

    Private Sub cmbCtrlCheq_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCtrlCheq.SelectedIndexChanged

        If cmbCtrlCheq.SelectedIndex = 1 Then
            Me.tbxNroCheque.Enabled = False
            tbxMtoCheq.Enabled = False
        Else
            Me.tbxNroCheque.Enabled = True
            tbxMtoCheq.Enabled = True

        End If
    End Sub

    Private Sub cmbCtrlRec_KeyPress_2(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbCtrlRec.KeyPress

        If e.KeyChar = Convert.ToChar(Keys.Return) Then


            If cmbCtrlRec.SelectedIndex = 1 Then
                Me.tbxNroReci.Enabled = False
                dtpFecREC.Enabled = False
                dtpFecPago.Focus()
            Else
                Me.tbxNroReci.Focus()
                dtpFecREC.Enabled = True

            End If

        End If
    End Sub



    Private Sub rdb3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb3.CheckedChanged

        Dim preg As String = ""
        preg = MsgBox("Exportar a Excel", MsgBoxStyle.YesNo, "Control Proyectos")

        If preg = 6 Then
            If rdb3.Checked = True Then
                Try

                    If Me.ltvDetfact.Items.Count > 0 Then
                        Dim frm As New frmProcess
                        frm.Show()
                        For x As Int32 = 0 To 1


                            Dim objExcel As New Excel.Application
                            Dim bkWorkBook As Workbook
                            Dim shWorkSheet As Worksheet
                            Dim i As Integer
                            Dim j As Integer
                            objExcel = New Excel.Application
                            bkWorkBook = objExcel.Workbooks.Add
                            shWorkSheet = CType(bkWorkBook.ActiveSheet, Worksheet)
                            For i = 0 To Me.ltvDetfact.Columns.Count - 1
                                shWorkSheet.Cells(1, i + 1) = Me.ltvDetfact.Columns(i).Text
                            Next
                            For i = 0 To Me.ltvDetfact.Items.Count - 1
                                For j = 0 To Me.ltvDetfact.Items(i).SubItems.Count - 1
                                    shWorkSheet.Cells(i + 2, j + 1) = Me.ltvDetfact.Items(i).SubItems(j).Text
                                Next
                            Next

                            objExcel.Visible = True
                            Exit For
                            '  Application.DoEvents()
                        Next
                        frm.Close()
                    Else
                        MsgBox("No existen datos para exportar", MsgBoxStyle.Information, "Control de Proyectos")
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        Else
            '  rdb3.Checked = False
            MsgBox("Exportación Cancelada", MsgBoxStyle.Information, "Control de Proyectos")

        End If
    End Sub

    Private Sub chkrec_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkrec.CheckedChanged

        If Me.chkrec.Checked = True Then
            llenarFactPagosf15()
        Else
            f15.ltwPagosParciales.Items.Clear()
            f15.ltwPagosRel.Items.Clear()
        End If
    End Sub

    Private Sub tbxFact_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxFact.KeyPress

        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            dtpFecP.Focus()

        End If

    End Sub

    Private Sub tbxTreal_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxTreal.KeyPress
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(tbxTreal.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                tbxTreal.Text = decimales(tbxTreal.Text) 'Format(CDec(txtMonto.Text), "C")
                e.Handled = True
                dtpFechare.Focus()


            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            tbxTreal.SelectAll()
        End If
    End Sub

    Private Sub dtpFechare_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFechare.KeyPress

        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            e.Handled = True
            tbxPresIns.Focus()


        End If

    End Sub

    Private Sub dtpFecP_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFecP.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            tbxDur.Focus()

        End If

    End Sub

    Private Sub tbxDur_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxDur.KeyPress

        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            cmbPerPCtas.Focus()

        End If
    End Sub

    Private Sub cmbPerPCtas_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbPerPCtas.KeyPress

        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            dtpFechIp.Focus()

        End If

    End Sub

    Private Sub dtpFechIp_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFechIp.KeyPress

        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            dtpFecFinOrPr.Focus()

        End If

    End Sub

    Private Sub dtpFecFinOrPr_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFecFinOrPr.KeyPress

        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            cmbTip.Focus()

        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmNroctaproy.Show()
    End Sub


    Private Sub tbxCtaNro_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxCtaNro.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            dptFechai.Focus()

        End If
    End Sub

    Private Sub dptFechai_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            dtpFechaf.Focus()

        End If

    End Sub

  

    Private Sub cmbSt_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSt.SelectedIndexChanged
        cmbTip.Focus()
    End Sub

    Private Sub ltwPagosRel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ltwPagosRel.SelectedIndexChanged
        Try

       
            'ProyNro = ""
            CqNro = ""

            If Me.ltwPagosRel.Items.Count > 0 Then

                For i = 0 To Me.ltwPagosRel.Items.Count - 1

                    If Me.ltwPagosRel.Items(i).Selected = True Then
                        ' ProyNro = Me.ltwPagosParciales.FocusedItem.SubItems(0).Text
                        CqNro = Me.ltwPagosRel.FocusedItem.SubItems(5).Text
                        
                        'limpia los campos 
                        tbxNroCheque.Text = ""
                        tbxMtoCheq.Text = ""
                        dtpFecRefr.Value = Date.Now
                        'dtpfCheq.Value = Date.Now
                        tbx_MesEje.Text = ""
                        tbxDocNext.Text = ""
                        tbxScafid.Text = ""
                        cmbCtrlCheq.SelectedIndex = -1

                        Exit For
                    End If

                Next

            End If
            ConsultasdPagosf15()
        Catch ex As Exception
            MsgBox("Error en funcion ltwPagosRel" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub
    Sub ConsultasdPagosf15()
        Try
            ConexionSQL()
            Dim strDCostos As New ADODB.Recordset
            strDCostos = cntSQL.Execute("select  * from tab_Rel_FacturasPagos where pro_idProyecto=" & stridProy & " and [pro_NroContrato]='" & ContNro & "' and [pro_NroRecibo]='" & RecNro & "' and [pro_NroFactura]='" & FactNro & "' and pro_NroCheque='" & LTrim(RTrim(CqNro)) & "'")


            Do While Not strDCostos.EOF

                f15.dtpfCheq.Value = strDCostos.Fields("pro_FechaPago").Value
                f15.tbxNroCheque.Text = strDCostos.Fields("pro_NroCheque").Value
                f15.tbxMtoCheq.Text = decimales(Math.Round(strDCostos.Fields("pro_MontoPago").Value, 2))
                f15.tbx_MesEje.Text = strDCostos.Fields("pro_MesEj").Value
                f15.tbxDocNext.Text = strDCostos.Fields("pro_DocNext").Value
                f15.tbxScafid.Text = strDCostos.Fields("pro_Scafid").Value
                f15.dtpFecRefr.Value = strDCostos.Fields("pro_FechaRefrendo").Value
                f15.cmbCtrlCheq.SelectedItem = buscaComboCq(strDCostos.Fields("pro_ControlCheq").Value)
                Exit Do
                strDCostos.MoveNext()
            Loop
        Catch ex As Exception
            MsgBox("Error en funcion ConsultasdPagosf15" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub

    Private Sub ModificarCuentaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarCuentaToolStripMenuItem.Click
        If ProyNro <> "" Then
            swCtaFac = 1
            frmNroctaproy.ShowDialog()
        Else
            MsgBox("Debe seleccionar un proyecto ", MsgBoxStyle.Information, "Control Proyectos")
        End If
        swCtaFac = 0
    End Sub

   
    Private Sub tbpFacturacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbpFacturacion.Click

    End Sub

    Private Sub btnCta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCta.Click
        If ProyNro <> "" Then

            '  ContNro = Me.tbxNrocta.Text
            swMenuPpal = 1
            swCtaFac = 1
            frmNroctaproy.ShowDialog()
        Else
            MsgBox("Debe seleccionar un proyecto ", MsgBoxStyle.Information, "Control Proyectos")
        End If

        swCtaFac = 0
    End Sub
End Class
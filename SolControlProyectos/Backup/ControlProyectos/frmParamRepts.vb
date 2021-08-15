Public Class frmParamRepts

    Private Sub btnCanc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCanc.Click
        Me.Close()
    End Sub

    Private Sub frmParamRepts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'If swRpts = 5 Then
        '    Me.lblSt.Visible = True
        '    Me.cmbStatus.Visible = True
        '    Me.chkSt.Visible = True
        '    llenarCombost()
        'Else


        '    Me.lblSt.Visible = False
        '    Me.cmbStatus.Visible = False
        '    Me.chkSt.Visible = False
        'End If

        llenarComboSector()

    End Sub
    Sub llenarComboSector()
        Try
            ConexionSQL()
            Dim strSector As New ADODB.Recordset
            Me.cmbGrupo.Items.Clear()

            strSector = cntSQL.Execute("SELECT  des_Sector FROM [dbo].[tab_Sector]")

            Do While Not strSector.EOF
                Me.cmbGrupo.Items.Add(strSector.Fields(0).Value)

                strSector.MoveNext()
            Loop


        Catch ex As Exception
            MsgBox("Error en funcion llenarComboSector" & ex.Message)
        End Try
    End Sub

    Sub llenarCombost()
        Try
            ConexionSQL()
            Dim strSector As New ADODB.Recordset
            '  Me.cmbStatus.Items.Clear()

            strSector = cntSQL.Execute("SELECT  des_Status FROM [dbo].[tab_Status]")

            Do While Not strSector.EOF
                ' Me.cmbStatus.Items.Add(strSector.Fields(0).Value)

                strSector.MoveNext()
            Loop


        Catch ex As Exception
            MsgBox("Error en funcion llenarCombost" & ex.Message)
        End Try
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

    Private Sub tbxAno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxAno.KeyPress
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(tbxAno.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                ' tbxAno.Text = decimales(tbxAno.Text) 'Format(CDec(txtMonto.Text), "C")
                e.Handled = True
                Me.btnAcep.Focus()


            End If

        Else
            intk = 0
            MsgBox("Error en el dato, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            tbxAno.SelectAll()
        End If
    End Sub

    Private Sub btnAcep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAcep.Click
        If Me.rdHasta.Checked = True Or Me.rdInsp.Checked = True Or Me.RdRecibo.Checked = True Then

            If swRpts = 5 Then
                If Me.tbxAno.Text <> "" Then
                    If Me.cmbGrupo.Text <> "Seleccione" Then

                        If swRpts = 3 Or swRpts = 4 Or swRpts = 5 Then


                            dano = f20.tbxAno.Text

                            If intPorFecha = 1 Then
                                selecP = "Fecha de la Cuenta"
                            End If
                            If intPorFecha = 2 Then
                                selecP = "Fecha del Recibo"
                            End If

                            If intPorFecha = 3 Then
                                selecP = "Fecha de Inspección"
                            End If


                            Dim frm As New frmProcess
                            frm.Show()
                            For x As Int32 = 0 To 1

                                frmParamadicRpts.lblTitulo.Text = Me.Text
                                frm.Close()
                                frmParamadicRpts.ShowDialog()

                                Exit For
                                Application.DoEvents()
                            Next
                            frm.Close()

                            Me.Close()

                        End If

                        swF = 0
                    Else

                        MsgBox("Debe seleccionar una opción", MsgBoxStyle.Critical, "Control Proyectos")
                    End If
                Else

                    MsgBox("Debe indicar el año a evaluar, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
                End If
            End If


            If swRpts = 2 Then

                fechaRes = Format(Me.dtpFecRes.Value, "yyyyMMdd")

                Dim frm As New frmProcess
                frm.Show()
                For x As Int32 = 0 To 1

                    frmParamadicRpts.lblTitulo.Text = Me.Text
                    frm.Close()
                    frmReportResumm.ShowDialog()

                    Exit For
                    Application.DoEvents()
                Next
                frm.Close()
                Me.Close()

            End If
        Else

            MsgBox("Debe seleccionar una Opcion de Fecha", MsgBoxStyle.Critical, "Control Proyectos")

        End If
        swF = 0
        intPorFecha = 0

    End Sub

    Private Sub chkAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAll.CheckedChanged

        If chkAll.Checked = True Then
          
            strall = ""
            Me.cmbGrupo.Text = ""
            Me.cmbGrupo.Enabled = False
            'Me.tbxAno.Enabled = False
        End If

        If chkAll.Checked = False Then
            Me.cmbGrupo.Enabled = True
            Me.cmbGrupo.Text = "Seleccione"
            strall = Me.cmbGrupo.SelectedItem

        End If

    End Sub

    Private Sub cmbGrupo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGrupo.SelectedIndexChanged
        strall = RTrim(LTrim(Me.cmbGrupo.SelectedItem))
        sectorRes = RTrim(LTrim(Me.cmbGrupo.SelectedItem))
        
    End Sub

    Private Sub chkSt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If chkSt.Checked = True Then

        '    status = ""
        '    Me.cmbStatus.Text = ""
        '    Me.cmbStatus.Enabled = False
        '    'Me.tbxAno.Enabled = False
        'End If

        'If chkSt.Checked = False Then
        '    Me.cmbStatus.Enabled = True
        '    Me.cmbStatus.Text = "Seleccione"
        '    status = Me.cmbStatus.SelectedItem

        'End If
    End Sub

    Private Sub cmbStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'status = RTrim(LTrim(Me.cmbStatus.SelectedItem))
        'statusRes = RTrim(LTrim(Me.cmbStatus.SelectedItem))
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFechaRes.CheckedChanged

        If chkFechaRes.Checked = True Then
            lblT.Visible = False
            tbxAno.Visible = False
            lblFecRes.Visible = True
            dtpFecRes.Visible = True
            swRpts = 2
        Else

            lblT.Visible = True
            tbxAno.Visible = True
            lblFecRes.Visible = False
            dtpFecRes.Visible = False
            swRpts = 3

        End If
    End Sub

    Private Sub rdHasta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdHasta.CheckedChanged
        'variables para la fecha de los reportes de estimacion de cobros
        intPorFecha = 1
        'si es 1 es por fecha de la cuenta
        'si es 2 es por fecha del recibo
        'si es 3 es por fecha de Inspeccion
    End Sub

    Private Sub RdRecibo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdRecibo.CheckedChanged
        'variables para la fecha de los reportes de estimacion de cobros
        intPorFecha = 2
        'si es 1 es por fecha de la cuenta
        'si es 2 es por fecha del recibo
        'si es 3 es por fecha de Inspeccion
    End Sub

    Private Sub rdInsp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdInsp.CheckedChanged
        'variables para la fecha de los reportes de estimacion de cobros
        intPorFecha = 3
        'si es 1 es por fecha de la cuenta
        'si es 2 es por fecha del recibo
        'si es 3 es por fecha de Inspeccion
    End Sub
End Class
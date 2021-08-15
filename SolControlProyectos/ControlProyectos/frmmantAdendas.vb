Public Class frmmantAdendas
    Dim fecha As String
    Dim adfecha As String
    Private Sub tbxMonto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxMonto.KeyPress
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(tbxMonto.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                tbxMonto.Text = decimales(tbxMonto.Text) 'Format(CDec(txtMonto.Text), "C")
                e.Handled = True
                Me.tbxAdendaT.Focus()


            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxMonto.SelectAll()
        End If
    End Sub
    Public Function DecimalKey(ByVal KCode As Int16) As Boolean

        If (KCode >= 48 And KCode <= 57) Or KCode = 8 Or KCode = 46 Or KCode = 45 Then
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

    Private Sub btnAc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAc.Click



        If Me.tbxAdendaT.Text <> 0 And Me.tbxMonto.Text <> 0 Then
            inttipoAd = 2

        End If

        If Me.tbxAdendaT.Text = 0 And Me.tbxMonto.Text <> 0 Then

            inttipoAd = 1
        End If

        If Me.tbxAdendaT.Text <> 0 And Me.tbxMonto.Text = 0 Then

            inttipoAd = 0
        End If

        If Me.tbxAdendaT.Text = 0 And Me.tbxMonto.Text = 0 Then

            inttipoAd = 1
        End If

        'pregunta que tipo de adenda es para habilitar o desh campos requeridos
        'ADENDA DE MONTO
        If inttipoAd = 1 Then

            If Me.tbxObs.Text <> "" And Me.tbxMonto.Text <> "" Then


                fecha = Format(dtpFecha.Value, "yyyyMMdd HH:mm:ss")

                ' pro_adendaFecha
                If swAd = 1 Then

                    insertaAdendas()

                    swAd = 0
                End If

                If swAd = 2 Then

                    modAdendas()

                    swAd = 0
                End If
                If swAd = 3 Then

                    elimAdendas()

                    swAd = 0
                End If
            Else
                MsgBox("Debe insertar datos", MsgBoxStyle.Critical, "Control Proyectos")
            End If

        End If


        'ADENDA DE FECHA
        If inttipoAd = 0 Then

            If Me.tbxObs.Text <> "" And Me.tbxAdendaT.Text <> "" Then
                Me.tbxMonto.Text = 0

                fecha = Format(dtpFecha.Value, "yyyyMMdd")
                ' adfecha = Format(dtpfechad.Value, "yyyyMMdd")

                If swAd = 1 Then

                    insertaAdendas()
                    swAd = 0
                End If

                If swAd = 2 Then

                    modAdendas()
                    swAd = 0
                End If
                If swAd = 3 Then

                    elimAdendas()
                    swAd = 0
                End If
            Else
                MsgBox("Debe insertar datos", MsgBoxStyle.Critical, "Control Proyectos")
            End If

        End If


        'ADENDA DE MONTO + FECHA
        If inttipoAd = 2 Then

            If Me.tbxObs.Text <> "" And Me.tbxMonto.Text <> "" And Me.tbxAdendaT.Text <> "" Then


                fecha = Format(dtpFecha.Value, "yyyyMMdd HH:mm:ss")

                ' pro_adendaFecha
                If swAd = 1 Then

                    insertaAdendas()

                    swAd = 0
                End If

                If swAd = 2 Then

                    modAdendas()

                    swAd = 0
                End If
                If swAd = 3 Then

                    elimAdendas()

                    swAd = 0
                End If
            Else
                MsgBox("Debe insertar datos", MsgBoxStyle.Critical, "Control Proyectos")
            End If

        End If

        Me.chkTpAd.Checked = False

    End Sub
    Sub insertaAdendas()
        Try
            Dim preg As String
            ConexionSQL()
            Dim strInse As ADODB.Recordset
            Dim i As Integer = 0

            strInse = cntSQL.Execute("select max(pro_NroAdenda) from  tab_AdendasProy where pro_idProyecto='" & stridProy & "' and  pro_nroProyecto='" & ProyNro & "' and pro_nroContrato='" & ContNro & "' ")

            Do While Not strInse.EOF
                i = IIf(strInse.Fields(0).Value Is DBNull.Value, 0, strInse.Fields(0).Value)

                strInse.MoveNext()
            Loop
            i = i + 1

            If i = 0 Then
                i = 1
            End If


            If intAdFin = 1 Then
                preg = MsgBox("Adenda se guardara como financiera, seguro que desea registrar?", MsgBoxStyle.YesNo, "Control Proyectos")

                If preg = 6 Then

                    cntSQL.Execute("INSERT INTO tab_AdendasProy( pro_adFecha,pro_idProyecto,pro_nroProyecto,pro_nroContrato,pro_Observacion,pro_monto, pro_tipoAdendas,pro_adendaFecha,pro_Financiera, tiempoAdf, pro_NroAdenda)VALUES('" & fecha & "','" & stridProy & "','" & ProyNro & "','" & ContNro & "','" & Me.tbxObs.Text & "'," & Replace(Me.tbxMonto.Text, ",", "") & ",'" & inttipoAd & "','" & fecha & "'," & intAdFin & "," & tbxAdendaT.Text & ", " & i & ")")
                    MsgBox("Datos Insertados", MsgBoxStyle.Information, "Control Proyectos")
                    frmAdendas.llenarNroAdendas()
                    ConsultasDAdf7()
                    Me.Close()
                End If
            Else


                cntSQL.Execute("INSERT INTO tab_AdendasProy( pro_adFecha,pro_idProyecto,pro_nroProyecto,pro_nroContrato,pro_Observacion,pro_monto, pro_tipoAdendas,pro_adendaFecha,pro_Financiera,tiempoAdf, pro_NroAdenda)VALUES('" & fecha & "','" & stridProy & "','" & ProyNro & "','" & ContNro & "','" & Me.tbxObs.Text & "'," & Replace(Me.tbxMonto.Text, ",", "") & ",'" & inttipoAd & "','" & fecha & "'," & intAdFin & "," & tbxAdendaT.Text & ", " & i & ")")
                MsgBox("Datos Insertados", MsgBoxStyle.Information, "Control Proyectos")
                frmAdendas.llenarNroAdendas()
                ConsultasDAdf7()
                Me.Close()


            End If



        Catch ex As Exception
            MsgBox("Error en funcion insertaAdendas" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try

    End Sub

    Sub modAdendas()
        Try
            ConexionSQL()
            Dim strInse As ADODB.Recordset

            fecha = Format(dtpFecha.Value, "yyyyMMdd")
            strInse = cntSQL.Execute("select * from tab_AdendasProy where pro_idAdendas =" & idAd & " and pro_idProyecto ='" & stridProy & "' and pro_nroProyecto='" & ProyNro & "' and pro_nroContrato='" & ContNro & "' and pro_tipoAdendas= '" & inttipoAd & "'")

            If strInse.EOF = False Then
                cntSQL.Execute("UPDATE tab_AdendasProy SET pro_adFecha='" & fecha & "',pro_Observacion='" & Me.tbxObs.Text & "',pro_monto='" & Replace(Me.tbxMonto.Text, ",", "") & "', pro_adendaFecha=  '" & fecha & "', pro_Financiera=" & intAdFin & ", tiempoAdf=" & Me.tbxAdendaT.Text & " WHERE  pro_idAdendas =" & idAd & " and pro_idProyecto ='" & stridProy & "' and pro_nroProyecto='" & ProyNro & "' and pro_nroContrato='" & ContNro & "' and pro_tipoAdendas= '" & inttipoAd & "'")
                MsgBox("Datos actualizados", MsgBoxStyle.Information, "Control Proyectos")

            End If

            frmAdendas.llenarNroAdendas()
            ConsultasDAdf7()
            Me.Close()
        Catch ex As Exception
            MsgBox("Error en funcion insertaAdendas" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try

    End Sub
    Sub elimAdendas()
        Try
            ConexionSQL()
            Dim strInse As ADODB.Recordset
            Dim preg As String = ""
            fecha = Format(dtpFecha.Value, "yyyyMMdd")
            strInse = cntSQL.Execute("select * from tab_AdendasProy where pro_idAdendas =" & idAd & " and pro_idProyecto ='" & stridProy & "' and pro_nroProyecto='" & ProyNro & "' and pro_nroContrato='" & ContNro & "' and pro_tipoAdendas= '" & inttipoAd & "'")


            preg = MsgBox("Seguro que desea eliminar la Adenda", MsgBoxStyle.YesNo, "Control Proyectos")

            If preg = 6 Then

                If strInse.EOF = False Then
                    cntSQL.Execute("DELETE tab_AdendasProy WHERE  pro_idAdendas =" & idAd & " and pro_idProyecto ='" & stridProy & "'and pro_nroProyecto='" & ProyNro & "'and pro_nroContrato='" & ContNro & "' and pro_tipoAdendas= '" & inttipoAd & "'")
                    MsgBox("Datos Eliminados", MsgBoxStyle.Information, "Control Proyectos")

                End If

            End If

            frmAdendas.llenarNroAdendas()
            ConsultasDAdf7()
            Me.Close()
        Catch ex As Exception
            MsgBox("Error en funcion insertaAdendas" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try

    End Sub

    Private Sub frmmantAdendas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

        
            Me.tbxObs.Text = ""
            Me.dtpFecha.Value = Date.Now
            Me.tbxMonto.Text = ""
            Me.tbxAdendaT.Text = ""

            'Me.chkTpAd.Checked = False
            'ADENDA DE MONTO
            If inttipoAd = 1 Then

                Me.Text = "ADENDA DE MONTO"
            End If


            If inttipoAd = 0 Then
               
                Me.Text = "ADENDA DE FECHA"
            End If

            If inttipoAd = 2 Then

                Me.Text = "ADENDA DE FECHA + MONTO"
            End If


            If swAd = 2 Then
                Me.tbxObs.Text = obsAd
                Me.dtpFecha.Value = fechaad
                Me.tbxMonto.Text = montoAd
                Me.tbxAdendaT.Text = intAdTiempo
            End If

            If swAd = 3 Then
                Me.tbxObs.Text = obsAd
                Me.dtpFecha.Value = fechaad
                Me.tbxMonto.Text = montoAd
                Me.tbxAdendaT.Text = intAdTiempo
            End If

            If tbxAdendaT.Text = "" Then
                tbxAdendaT.Text = "0"
            End If
            If tbxMonto.Text = "" Then
                tbxMonto.Text = "0"
            End If

            If intAdFin = 1 Then
                Me.chkTpAd.Checked = True
            Else
                Me.chkTpAd.Checked = False
            End If


        Catch ex As Exception
            MsgBox("Error en el Monto, por favor verifique " & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try

    End Sub

    Private Sub btnC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnC.Click
        Me.Close()
    End Sub

  

    Private Sub tbxObs_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxObs.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            Me.dtpFecha.Focus()


        End If
    End Sub

    Private Sub dtpFecha_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFecha.KeyPress

        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            Me.tbxMonto.Focus()


        End If
    End Sub

    Private Sub chkTpAd_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTpAd.CheckedChanged

        If Me.chkTpAd.Checked = True Then
            intAdFin = 1
            Me.tbxMonto.Text = 0
            tbxAdendaT.Text = 0
            Me.tbxMonto.Enabled = False

        Else
            'Me.tbxMonto.Text = ""
            'tbxAdendaT.Text = 0
            Me.tbxMonto.Enabled = True
            intAdFin = 0
        End If
    End Sub

    Private Sub tbxAdendaT_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxAdendaT.KeyPress
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(tbxAdendaT.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then

                e.Handled = True
                Me.tbxObs.Focus()


            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxAdendaT.SelectAll()
        End If
    End Sub
End Class
Public Class frmInputctas

    Private Sub btnCanc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCanc.Click
        Me.Close()
        swInput = 1
    End Sub
    'Sub actualizaFechaEstCobros()
    '    Dim strEst As New ADODB.Recordset
    '    ConexionSQL()
    '    Try

    '        strEst = cntSQL.Execute("exec p_ActualizaFechaEstCobros '" & ProyNro & "','" & ContNro & "','" & FactNro & "'")

    '    Catch ex As Exception
    '        MsgBox("Error en funcion actualizaFechaEstCobros" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
    '    End Try
    'End Sub

    Private Sub btnAcept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAcept.Click

        clearDcompl()
        Try


            If modTb = 0 Then
                If Me.tbxDato.Text <> "" Then

                    lblTitulo.Text = "Ingrese Nro de Cta al Proyecto: " & ProyNro

                    If ProyNro <> "" Then
                        serieNro = Me.tbxDato.Text()
                        If swMenuPpal = 0 Then
                            'f1.txtCuenta.Text = serieNro
                        End If


                        If swMenuPpal = 2 Then
                            'f7.txtCuenta.Text = serieNro
                        End If

                        If swMenuPpal = 2 Then

                            f7.txtCuenta1.Text = f7.insertNroCuenta(idProy, ProyNro, ContNro)
                            f7.txtCuenta1.Text = serieNro
                            insertaDatosComplProyf7()
                            'actualizaFechaEstCobros()

                        End If


                        If swMenuPpal = 1 Then

                            'f1.txtCuenta.Text = f1.insertNroCuenta(idProy, ProyNro, ContNro)
                            'f1.txtCuenta.Text = serieNro
                            insertaDatosComplProyf15()
                            ' actualizaFechaEstCobros()
                        End If

                        frmNroctaproy.llenarNrocta()


                        MsgBox("Registro Insertado", MsgBoxStyle.Information, "Gestion de Proyectos")
                        Me.Close()
                    Else
                        MsgBox("Debe Insertar un Valor", MsgBoxStyle.Exclamation, "Gestion de Proyectos")
                    End If
                Else
                    MsgBox("Debe poseer un número de proyecto", MsgBoxStyle.Exclamation, "Gestion de Proyectos")
                End If
            End If


            If modTb = 1 Then
                If Me.tbxDato.Text <> "" Then

                    ' lblTitulo.Text = "Ingrese Nro de Cta al Proyecto: " & ProyNro

                    If ProyNro <> "" Then
                        serieNro = Me.tbxDato.Text()
                        If swMenuPpal = 0 Then
                            'f1.txtCuenta.Text = serieNro
                        End If


                        If swMenuPpal = 2 Then
                            ' f7.txtCuenta.Text = serieNro
                        End If

                        If swMenuPpal = 2 Then

                            f7.txtCuenta1.Text = serieNro
                            '  insertaDatosComplProyf7()
                            ' actualizaFechaEstCobros()

                        End If


                        If swMenuPpal = 1 Then
                            f15.tbxNrocta.Text = serieNro
                            insertaDatosComplProyf15()
                            'actualizaFechaEstCobros()
                        End If
                        frmNroctaproy.llenarNrocta()

                        MsgBox("Registro Modificado", MsgBoxStyle.Information, "Gestion de Proyectos")
                        Me.Close()
                    Else
                        MsgBox("Debe Insertar un Valor", MsgBoxStyle.Exclamation, "Gestion de Proyectos")
                    End If
                Else
                    MsgBox("Debe poseer un número de proyecto", MsgBoxStyle.Exclamation, "Gestion de Proyectos")
                End If
            End If



        Catch ex As Exception
            MsgBox("Error en funcion btnAcept_Click" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
        modTb = 0
    End Sub

    Private Sub frmInputRec_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If modTb = 0 Then
            swInput = 0

            lblTitulo.Text = "Ingrese Nro de Cta al Proyecto: " & ProyNro

            Me.tbxDato.Text = ""

            Me.tbxDato.Focus()
        End If

    End Sub
End Class
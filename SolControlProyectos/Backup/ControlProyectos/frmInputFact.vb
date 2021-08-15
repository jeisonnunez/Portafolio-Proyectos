Public Class frmInputFact

    Private Sub btnCanc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCanc.Click
        Me.Close()
        swInput = 1
    End Sub

    Private Sub btnAcept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAcept.Click


        Try

            'modifica
            Dim strFact As ADODB.Recordset
            Dim preg As String = ""
            If modTb = 1 Then
                If Me.tbxDato.Text <> "" Then
                    If ProyNro <> "" Then
                        FactNro = Me.tbxDato.Text()
                        ConexionSQL()

                        strFact = cntSQL.Execute("select * from tab_DatosPpalProy_Compl where pro_NroFactura='" & FactNro & "' " _
                        & " and pro_idProyecto=" & stridProy & "")

                        If strFact.EOF = True Then
                            'codigo para modificar la factura en la tabla de ctas
                            '------------------------------------------------------
                            cntSQL.Execute("UPDATE tab_DatosPpalProy_Compl SET pro_NroFactura='" & FactNro & "' " _
                            & " where pro_idProyecto=" & stridProy & " and pro_nroCuenta='" & CtaNro & "' and pro_serieCuenta='" & serieNro & "'")

                            '------------------------------------------------------
                            '  frmInputctas.actualizaFechaEstCobros()
                            frmNroctaproy.llenarNrocta()

                            MsgBox("Registro Modificado", MsgBoxStyle.Information, "Gestion de Proyectos")
                        End If


                        If strFact.EOF = False Then

                            preg = MsgBox("Factura se encuentra con nro de cuenta asignada, desea actualizar", MsgBoxStyle.YesNo, "Gestion de Proyectos")

                            If preg = 6 Then
                                'codigo para modificar la factura en la tabla de ctas
                                '------------------------------------------------------
                                cntSQL.Execute("UPDATE tab_DatosPpalProy_Compl SET pro_NroFactura='" & FactNro & "' " _
                                & " where pro_idProyecto=" & stridProy & " and pro_nroCuenta='" & CtaNro & "' and pro_serieCuenta='" & serieNro & "'")

                                '------------------------------------------------------
                                'frmInputctas.actualizaFechaEstCobros()
                                frmNroctaproy.llenarNrocta()
                                MsgBox("Registro Modificado", MsgBoxStyle.Information, "Gestion de Proyectos")

                            End If
                          
                            If preg <> 6 Then
                                'codigo para modificar la factura en la tabla de ctas
                                '------------------------------------------------------
                                cntSQL.Execute("UPDATE tab_DatosPpalProy_Compl SET pro_NroFactura='" & FactNro & "' " _
                                & " where pro_idProyecto=" & stridProy & " and pro_nroCuenta='" & CtaNro & "' and pro_serieCuenta='" & serieNro & "'")

                                '------------------------------------------------------
                                ' frmInputctas.actualizaFechaEstCobros()
                                frmNroctaproy.llenarNrocta()
                                MsgBox("Registro Modificado", MsgBoxStyle.Information, "Gestion de Proyectos")

                            End If


                        End If


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

            lblTitulo.Text = "Ingrese Nro de Fact al Proyecto: " & ProyNro

            Me.tbxDato.Text = ""

            Me.tbxDato.Focus()
        End If

    End Sub
End Class
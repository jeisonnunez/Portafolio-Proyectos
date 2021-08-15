Public Class frmNroctaproy

    Private Sub frmFacturas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''cxc
        'If swCtaFac = 1 Then
        '    Me.ToolStrip1.Enabled = False
        '    ContextMenuStrip1.Enabled = True
        'End If

        ''proyectos
        'If swCtaFac = 0 Then
        '    Me.ToolStrip1.Enabled = True
        '    ContextMenuStrip1.Enabled = False

        'End If

        llenarNrocta()
    End Sub
    Sub llenarNrocta()
        Try
            ConexionSQL()
            Dim strDatos As New ADODB.Recordset
            Dim i As Integer = 0
            Me.ltwcta.Items.Clear()

            strDatos = cntSQL.Execute("select [pro_nroProyecto] ,[pro_nroContrato] ,[pro_nroCuenta], pro_serieCuenta, isnull(pro_NroFactura,'') pro_NroFactura from tab_DatosPpalProy_Compl where pro_nroContrato='" & ContNro & "' and pro_nroProyecto='" & ProyNro & "'")
        
            Do While Not strDatos.EOF

                Me.ltwcta.Items.Add(ProyNro)
                Me.ltwcta.Items(i).SubItems.Add(strDatos.Fields("pro_nroContrato").Value)
                Me.ltwcta.Items(i).SubItems.Add(strDatos.Fields("pro_nroCuenta").Value)
                Me.ltwcta.Items(i).SubItems.Add(strDatos.Fields("pro_serieCuenta").Value)
                Me.ltwcta.Items(i).SubItems.Add(strDatos.Fields("pro_NroFactura").Value)
                i += 1
                strDatos.MoveNext()
            Loop

        Catch ex As Exception
            MsgBox("Error en buscar Nro de llenarNrocta()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub



    Sub consultaProyFactDppalf7()
        Try
            ConexionSQL()
            Dim strPpal As New ADODB.Recordset

            strPpal = cntSQL.Execute("select * from tab_DatosPpalProy_Compl where pro_nroContrato='" & ContNro & "' and  pro_idProyecto='" & stridProy & "' and pro_nroCuenta='" & CtaNro & "'")


            Do While Not strPpal.EOF

            
                ' f7.txtCuenta.Text = strPpal.Fields("pro_nroCuenta").Value
                f7.txtCuenta1.Text = strPpal.Fields("pro_serieCuenta").Value
                f7.dtpFd1.Value = strPpal.Fields("pro_FechaD").Value
                f7.dtpFH1.Value = strPpal.Fields("pro_FechaH").Value
                f7.tbxTraR1.Text = decimales(Math.Round(strPpal.Fields("pro_TrabajoR").Value, 2))
                f7.dtpFechaR1.Value = strPpal.Fields("pro_FechaR").Value
                f7.txtInsp1.Text = decimales(Math.Round(strPpal.Fields("pro_PresInsp").Value, 2))
                f7.dtpPIns1.Value = strPpal.Fields("pro_FechaP").Value
                ' f7.cmbperPagCtas1.SelectedIndex = strPpal.Fields("pro_periodoCuenta").Value
                ' f7.txtDur1.Text = strPpal.Fields("pro_duracionProy").Value
                'f7.dtpFechai.Value = strPpal.Fields("pro_FechaInicio").Value
                'f7.dtpFfOp.Value = strPpal.Fields("pro_FechaFinOrig").Value
                f7.cmbStatus.SelectedIndex = strPpal.Fields("pro_status").Value
                '  f7.cmbTipo1.SelectedIndex = strPpal.Fields("pro_tipo").Value

                Exit Do


            Loop

        Catch ex As Exception
            MsgBox("Error en funcion consultaProyFactDppalf7())" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try

    End Sub

   
    Private Sub ltwcta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.ltwcta.Items.Count > 0 Then

            For i = 0 To Me.ltwcta.Items.Count - 1

                If Me.ltwcta.Items(i).Selected = True Then
                    ProyNro = Me.ltwcta.FocusedItem.SubItems(0).Text
                    ContNro = Me.ltwcta.FocusedItem.SubItems(1).Text
                    CtaNro = Me.ltwcta.FocusedItem.SubItems(2).Text
                    serieNro = Me.ltwcta.FocusedItem.SubItems(3).Text
                    Exit For
                End If
            Next

        End If

        If swMenuPpal = 2 Then
            consultaProyFactDppalf7()
        End If
        If swMenuPpal = 1 Then
            consultaProyFactDppalf1()
        End If
        '  Me.Close()
    End Sub

    Sub consultaProyFactDppalf1()
        Try
            ConexionSQL()
            Dim strPpal As New ADODB.Recordset

            strPpal = cntSQL.Execute("select * from tab_DatosPpalProy_Compl where pro_nroContrato='" & ContNro & "' and  pro_idProyecto='" & stridProy & "' and pro_nroCuenta='" & CtaNro & "'")


            Do While Not strPpal.EOF


                ' f1.txtCuenta.Text = strPpal.Fields("pro_nroCuenta").Value
                ''f1.txtCuenta.Text = strPpal.Fields("pro_serieCuenta").Value
                ''f1.dtpFd.Value = strPpal.Fields("pro_FechaD").Value
                ''f1.dtpFH.Value = strPpal.Fields("pro_FechaH").Value
                ''f1.tbxTraR.Text = decimales(Math.Round(strPpal.Fields("pro_TrabajoR").Value, 2))
                ''f1.dtpFechaR.Value = strPpal.Fields("pro_FechaR").Value
                ''f1.txtInsp.Text = decimales(Math.Round(strPpal.Fields("pro_PresInsp").Value, 2))
                ''f1.dtpPIns.Value = strPpal.Fields("pro_FechaP").Value
                ''f1.cmbperPagCtas.SelectedIndex = IIf(strPpal.Fields("pro_periodoCuenta").Value Is DBNull.Value, 0, strPpal.Fields("pro_periodoCuenta").Value)

                ''f1.txtDur.Text = strPpal.Fields("pro_duracionProy").Value
                ''f1.dtpFechai.Value = strPpal.Fields("pro_FechaInicio").Value
                ''f1.dtpFfOp.Value = strPpal.Fields("pro_FechaFinOrig").Value
                ''f1.cmbxSta.SelectedIndex = IIf(strPpal.Fields("pro_status").Value = "", 0, strPpal.Fields("pro_status").Value)
                ''f1.cmbTipo.SelectedIndex = IIf(strPpal.Fields("pro_tipo").Value = "", 0, strPpal.Fields("pro_tipo").Value)

                Exit Do


            Loop

        Catch ex As Exception
            MsgBox("Error en funcion consultaProyFactDppalf1())" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try

    End Sub


   

  

    Private Sub ltwcta_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ltwcta.ContextMenuStrip = ContextMenuStrip1
        Else
            ltwcta.ContextMenuStrip = ContextMenuStrip1
        End If
    End Sub

    Private Sub ModificarNroReciboToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim swsele As Integer = 0
            Dim preg As String = ""
            ConexionSQL()
            Dim strPpal As New ADODB.Recordset

            If Me.ltwcta.Items.Count > 0 Then

                For i = 0 To Me.ltwcta.Items.Count - 1

                    If Me.ltwcta.Items(i).Selected = True Then
                        ProyNro = Me.ltwcta.FocusedItem.SubItems(0).Text
                        ContNro = Me.ltwcta.FocusedItem.SubItems(1).Text
                        CtaNro = Me.ltwcta.FocusedItem.SubItems(2).Text
                        serieNro = Me.ltwcta.FocusedItem.SubItems(3).Text
                        swsele = 1
                        Exit For

                    End If
                Next

            End If

            If swsele = 1 Then

                preg = MsgBox("Seguro que desea eliminar la cta nro " & serieNro, MsgBoxStyle.YesNo, "Control Proyectos")

                If preg = 6 Then

                    cntSQL.Execute("delete from tab_DatosPpalProy_Compl where pro_nroContrato='" & ContNro & "' and  pro_idProyecto='" & stridProy & "' and pro_nroCuenta='" & CtaNro & "'")

                    If swMenuPpal = 2 Then
                        clearDcompl()
                    End If
                    If swMenuPpal = 1 Then
                        clearComplDppal()
                    End If
                    MsgBox("Registro eliminado", MsgBoxStyle.Critical, "Control Proyectos")
                    llenarNrocta()
                End If

            End If


        Catch ex As Exception
            MsgBox("Error en funcion btnEliminar" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub

    Private Sub InsertarNroCuentaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmInputctas.ShowDialog()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        clearDcompl()
        frmInputctas.ShowDialog()
        llenarNroctas()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Try
            Dim swsele As Integer = 0
            Dim preg As String = ""
            ConexionSQL()
            Dim strPpal As New ADODB.Recordset

            If Me.ltwcta.Items.Count > 0 Then

                For i = 0 To Me.ltwcta.Items.Count - 1

                    If Me.ltwcta.Items(i).Selected = True Then
                        ProyNro = Me.ltwcta.FocusedItem.SubItems(0).Text
                        ContNro = Me.ltwcta.FocusedItem.SubItems(1).Text
                        CtaNro = Me.ltwcta.FocusedItem.SubItems(2).Text
                        serieNro = Me.ltwcta.FocusedItem.SubItems(3).Text
                        swsele = 1
                        Exit For

                    End If
                Next

            End If

            If swsele = 1 Then

                preg = MsgBox("Seguro que desea eliminar la cta nro " & serieNro, MsgBoxStyle.YesNo, "Control Proyectos")

                If preg = 6 Then

                    cntSQL.Execute("delete from tab_DatosPpalProy_Compl where pro_nroContrato='" & ContNro & "' and  pro_idProyecto='" & stridProy & "' and pro_nroCuenta='" & CtaNro & "'")

                    If swMenuPpal = 2 Then
                        clearDcompl()
                    End If
                    If swMenuPpal = 1 Then
                        clearComplDppal()
                    End If

                End If
            Else

                MsgBox("Debe seleccionar un valor", MsgBoxStyle.Critical, "Control Proyectos")
            End If
            llenarNrocta()
            llenarNroctas()
            MsgBox("Registro Eliminado", MsgBoxStyle.Information, "Control Proyectos")
        Catch ex As Exception
            MsgBox("Error en funcion btnEliminar" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub

    
    Private Sub ltwcta_MouseDown_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ltwcta.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ltwcta.ContextMenuStrip = ContextMenuStrip1
        Else
            ltwcta.ContextMenuStrip = ContextMenuStrip1
        End If
    End Sub

    Private Sub ToolStripButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton12.Click
        Me.Close()
    End Sub

    Private Sub ltwcta_DoubleClick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ltwcta.DoubleClick
        Try
            Dim swsele As Integer = 0
            Dim preg As String = ""
            ConexionSQL()
            Dim strPpal As New ADODB.Recordset
            modTb = 0
            If Me.ltwcta.Items.Count > 0 Then

                For i = 0 To Me.ltwcta.Items.Count - 1

                    If Me.ltwcta.Items(i).Selected = True Then
                        ProyNro = Me.ltwcta.FocusedItem.SubItems(0).Text
                        ContNro = Me.ltwcta.FocusedItem.SubItems(1).Text
                        CtaNro = Me.ltwcta.FocusedItem.SubItems(2).Text
                        serieNro = Me.ltwcta.FocusedItem.SubItems(3).Text
                        FactNro = Me.ltwcta.FocusedItem.SubItems(4).Text
                        swsele = 1
                        Exit For

                    End If
                Next

            End If

            If swsele = 1 Then

                preg = MsgBox("Seguro que desea modificar la Factura Nro " & f15.tbxNroFac.Text, MsgBoxStyle.YesNo, "Control Proyectos")

                If preg = 6 Then
                    modTb = 1


                    ConexionSQL()
                    Dim strFact As ADODB.Recordset
                    Dim preg1 As String = ""

                    'reviso si la facura posee cuenta
                    strFact = cntSQL.Execute("select * from tab_DatosPpalProy_Compl where pro_NroFactura='" & f15.tbxNroFac.Text & "' " _
                    & " and pro_idProyecto=" & stridProy & "")

                    If strFact.EOF = False Then
                        preg1 = MsgBox("Factura posee cuenta asignada, desea reasignar cuenta?", MsgBoxStyle.YesNo, "Gestion de Proyectos")


                        If preg1 = 6 Then

                            'codigo para modificar la factura en la tabla de ctas

                            '------------------------------------------------------
                            cntSQL.Execute("UPDATE tab_DatosPpalProy_Compl SET pro_NroFactura='' " _
                            & " where pro_idProyecto=" & stridProy & " and pro_NroFactura='" & f15.tbxNroFac.Text & "'")

                            cntSQL.Execute("UPDATE tab_DatosPpalProy_Compl SET pro_NroFactura='" & f15.tbxNroFac.Text & "' " _
                           & " where pro_idProyecto=" & stridProy & " and pro_nroCuenta='" & CtaNro & "' and pro_serieCuenta='" & serieNro & "'")

                            '------------------------------------------------------


                            ' frmInputctas.actualizaFechaEstCobros()
                            llenarNrocta()
                            MsgBox("Registro Modificado", MsgBoxStyle.Information, "Gestion de Proyectos")
                            f15.tbxNrocta.Text = serieNro
                            Exit Sub
                        Else

                            Exit Sub

                        End If

                    End If

                    'codigo para modificar la factura en la tabla de ctas
                    '------------------------------------------------------

                    If strFact.EOF = True Then
                        cntSQL.Execute("UPDATE tab_DatosPpalProy_Compl SET pro_NroFactura='" & f15.tbxNroFac.Text & "' " _
                        & " where pro_idProyecto=" & stridProy & " and pro_nroCuenta='" & CtaNro & "' and pro_serieCuenta='" & serieNro & "'")

                        '------------------------------------------------------
                        'frmInputctas.actualizaFechaEstCobros()
                        llenarNrocta()
                        MsgBox("Registro Modificado", MsgBoxStyle.Information, "Gestion de Proyectos")
                        f15.tbxNrocta.Text = serieNro
                        Exit Sub
                    End If


                End If

            Else

                MsgBox("Debe seleccionar un valor", MsgBoxStyle.Critical, "Control Proyectos")
            End If


        Catch ex As Exception
            MsgBox("Error en funcion btnEditar" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
        FactNrocta = ""
    End Sub


    Private Sub ltwcta_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ltwcta.SelectedIndexChanged
        clearDcompl()

        If Me.ltwcta.Items.Count > 0 Then

            For i = 0 To Me.ltwcta.Items.Count - 1

                If Me.ltwcta.Items(i).Selected = True Then
                    ProyNro = Me.ltwcta.FocusedItem.SubItems(0).Text
                    ContNro = Me.ltwcta.FocusedItem.SubItems(1).Text
                    CtaNro = Me.ltwcta.FocusedItem.SubItems(2).Text
                    serieNro = Me.ltwcta.FocusedItem.SubItems(3).Text
                    Exit For
                End If
            Next

        End If

        If swMenuPpal = 2 Then
            consultaProyFactDppalf7()
            ConsultasDEntesFactf7()
        End If
        If swMenuPpal = 1 Then
            consultaProyFactDppalf1()
        End If
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Try
            Dim swsele As Integer = 0
            Dim preg As String = ""
            ConexionSQL()
            Dim strPpal As New ADODB.Recordset
            modTb = 0
            If Me.ltwcta.Items.Count > 0 Then

                For i = 0 To Me.ltwcta.Items.Count - 1

                    If Me.ltwcta.Items(i).Selected = True Then
                        ProyNro = Me.ltwcta.FocusedItem.SubItems(0).Text
                        ContNro = Me.ltwcta.FocusedItem.SubItems(1).Text
                        CtaNro = Me.ltwcta.FocusedItem.SubItems(2).Text
                        serieNro = Me.ltwcta.FocusedItem.SubItems(3).Text
                        swsele = 1
                        Exit For

                    End If
                Next

            End If

            If swsele = 1 Then

                preg = MsgBox("Seguro que desea modificar la cta nro " & serieNro, MsgBoxStyle.YesNo, "Control Proyectos")

                If preg = 6 Then
                    modTb = 1
                    frmInputctas.tbxDato.Text = serieNro
                    frmInputctas.ShowDialog()

                  
                End If

            Else

                MsgBox("Debe seleccionar un valor", MsgBoxStyle.Critical, "Control Proyectos")
            End If

            llenarNroctas()
        Catch ex As Exception
            MsgBox("Error en funcion btnEditar" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub

    Private Sub ModificarNroFacturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarNroFacturaToolStripMenuItem.Click
        Try
            Dim swsele As Integer = 0
            Dim preg As String = ""
            ConexionSQL()
            Dim strPpal As New ADODB.Recordset
            modTb = 0
            If Me.ltwcta.Items.Count > 0 Then

                For i = 0 To Me.ltwcta.Items.Count - 1

                    If Me.ltwcta.Items(i).Selected = True Then
                        ProyNro = Me.ltwcta.FocusedItem.SubItems(0).Text
                        ContNro = Me.ltwcta.FocusedItem.SubItems(1).Text
                        CtaNro = Me.ltwcta.FocusedItem.SubItems(2).Text
                        serieNro = Me.ltwcta.FocusedItem.SubItems(3).Text
                        FactNro = Me.ltwcta.FocusedItem.SubItems(4).Text
                        swsele = 1
                        Exit For

                    End If
                Next

            End If

            If swsele = 1 Then

                preg = MsgBox("Seguro que desea modificar la Factura Nro " & f15.tbxNroFac.Text, MsgBoxStyle.YesNo, "Control Proyectos")

                If preg = 6 Then
                    modTb = 1
                   

                    ConexionSQL()
                    Dim strFact As ADODB.Recordset
                    Dim preg1 As String = ""

                    'reviso si la facura posee cuenta
                    strFact = cntSQL.Execute("select * from tab_DatosPpalProy_Compl where pro_NroFactura='" & f15.tbxNroFac.Text & "' " _
                    & " and pro_idProyecto=" & stridProy & "")

                    If strFact.EOF = False Then
                        preg1 = MsgBox("Factura posee cuenta asignada, desea reasignar cuenta?", MsgBoxStyle.YesNo, "Gestion de Proyectos")


                        If preg1 = 6 Then

                            'codigo para modificar la factura en la tabla de ctas

                            '------------------------------------------------------
                            cntSQL.Execute("UPDATE tab_DatosPpalProy_Compl SET pro_NroFactura='' " _
                            & " where pro_idProyecto=" & stridProy & " and pro_NroFactura='" & f15.tbxNroFac.Text & "'")

                            cntSQL.Execute("UPDATE tab_DatosPpalProy_Compl SET pro_NroFactura='" & f15.tbxNroFac.Text & "' " _
                           & " where pro_idProyecto=" & stridProy & " and pro_nroCuenta='" & CtaNro & "' and pro_serieCuenta='" & serieNro & "'")

                            '------------------------------------------------------


                            ' frmInputctas.actualizaFechaEstCobros()
                            llenarNrocta()
                            MsgBox("Registro Modificado", MsgBoxStyle.Information, "Gestion de Proyectos")
                            f15.tbxNrocta.Text = serieNro
                            Exit Sub
                        Else

                            Exit Sub

                        End If

                    End If

                    'codigo para modificar la factura en la tabla de ctas
                    '------------------------------------------------------

                    If strFact.EOF = True Then
                        cntSQL.Execute("UPDATE tab_DatosPpalProy_Compl SET pro_NroFactura='" & f15.tbxNroFac.Text & "' " _
                        & " where pro_idProyecto=" & stridProy & " and pro_nroCuenta='" & CtaNro & "' and pro_serieCuenta='" & serieNro & "'")

                        '------------------------------------------------------
                        'frmInputctas.actualizaFechaEstCobros()
                        llenarNrocta()
                        MsgBox("Registro Modificado", MsgBoxStyle.Information, "Gestion de Proyectos")
                        f15.tbxNrocta.Text = serieNro
                        Exit Sub
                    End If


                End If

            Else

                MsgBox("Debe seleccionar un valor", MsgBoxStyle.Critical, "Control Proyectos")
            End If


        Catch ex As Exception
            MsgBox("Error en funcion btnEditar" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
        FactNrocta = ""
    End Sub

 
End Class
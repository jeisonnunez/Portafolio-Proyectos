Public Class frmInicioproyectos
   
    Private Sub btnCanc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCanc.Click
        Me.Close()
        swIninio = 1
        tbxBuscar.Text = ""
    End Sub

    Private Sub btnAcep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAcep.Click

        clearDcompl()
        clearCtas()
        clearEntesf7()


        If tbxBuscar.Text <> "" Then
            'viene del explorador del menu la solicitud
            If swCambioP = 1 Then

                If Me.tbxBuscar.Text <> "" Then
                    'menu de estimacion de cuentas

                    If swMenuPpal = 4 Then
                        If swIninio = 1 Then

                            f16.Close()
                        Else

                            f16 = frmPresCtas
                            fcall = f16.Name
                            frmExplorer.ToolStripStatusLabel.Text = "Presentación de Cuentas"
                            'frmExplorer.cerrarForm()
                            If swF = 1 Then
                                MsgBox("Existen formularios abiertos, por favor cierre el formulario", MsgBoxStyle.Exclamation, "Control Proyectos")

                            Else
                                swMenuPpal = 4

                                f16.Top = (frmExplorer.SplitContainer.Panel2.Height / 2) - (f7.Height / 2)
                                f16.Left = (frmExplorer.SplitContainer.Panel2.Width / 2) - (f7.Width / 2)

                                f16.TopLevel = False

                                f16.WindowState = FormWindowState.Maximized
                                f16.Parent = frmExplorer.SplitContainer.Panel2
                                f16.Dock = DockStyle.None

                                frmExplorer.SplitContainer.Panel2.Controls.Add(f16)
                                swCambioP = 1
                                f16.Show()
                                f16.limpiarformEstCtas()
                                ConsultasEstCtasf16()
                                f16.lbltiproy.Text = strCodProy & " - " & strDescProy
                                swMenuPpal = 4



                            End If

                        End If
                    End If


                    If swMenuPpal = 1 Then
                        If swIninio = 1 Then

                            f15.Close()
                        Else

                            f15 = frmMenuProyectoIncluir
                            fcall = f15.Name
                            ''frmExplorer.cerrarForm()
                            frmExplorer.ToolStripStatusLabel.Text = "Proyectos/Facturas"
                            If swF = 1 Then
                                MsgBox("Existen formularios abiertos, por favor cierre el formulario", MsgBoxStyle.Exclamation)

                            Else

                                swMenuPpal = 1

                                f15.Top = (frmExplorer.SplitContainer.Panel2.Height / 2) - (f15.Height / 2)
                                f15.Left = (frmExplorer.SplitContainer.Panel2.Width / 2) - (f15.Width / 2)

                                f15.TopLevel = False

                                f15.WindowState = FormWindowState.Maximized
                                f15.Parent = frmExplorer.SplitContainer.Panel2
                                f15.Dock = DockStyle.None

                                frmExplorer.SplitContainer.Panel2.Controls.Add(f15)
                                swMenuPpal = 1
                                swCambioP = 1
                                f15.Show()
                                swMenuPpal = 1
                                ConsultarALLproyF15()
                                ConsultasDEntesFactf15()
                                f15.llenarFactPagosf15()

                                ProyNro = strCodProy

                                f15.lbltiproy.Text = strCodProy & " - " & strDescProy
                                frmExplorer.ToolStripStatusLabel.Text = "Facturas CxC " & pathContr
                                frmFacturasResumen.ShowDialog()


                            End If



                        End If
                    End If

                    'menu de consulta de proyectos
                    If swMenuPpal = 2 Then

                        If swIninio = 1 Then

                            f7.Close()

                        Else
                            f7 = frmMenuProyectoConsulta
                            fcall = f7.Name

                            'frmExplorer.cerrarForm()
                            If swF = 1 Then
                                MsgBox("Existen formularios abiertos, por favor cierre el formulario", MsgBoxStyle.Exclamation, "Control Proyectos")

                            Else
                                swMenuPpal = 2

                                f7.Top = (frmExplorer.SplitContainer.Panel2.Height / 2) - (f7.Height / 2)
                                f7.Left = (frmExplorer.SplitContainer.Panel2.Width / 2) - (f7.Width / 2)

                                f7.TopLevel = False

                                f7.WindowState = FormWindowState.Maximized
                                f7.Parent = frmExplorer.SplitContainer.Panel2
                                f7.Dock = DockStyle.None

                                frmExplorer.SplitContainer.Panel2.Controls.Add(f7)

                                f7.Show()
                                f7.lblid.Text = stridProy
                                f7.tbxCodp.Text = strCodProy
                                ProyNro = f7.tbxCodp.Text
                                f7.tbxDescr.Text = strDescProy
                                idProy = IIf(stridProy = "", 0, stridProy)
                                ConsultarALLproyF7()
                                f7.lbltiproy.Text = strCodProy & " - " & strDescProy

                                llenarNroctas()
                                swMenuPpal = 2

                            End If



                        End If
                    End If

                    tbxBuscar.Text = ""
                    Me.Close()


                Else
                    MsgBox("Debe Ingresar un Dato", MsgBoxStyle.Information, "Control de Proyectos")
                    tbxBuscar.Focus()
                End If
            End If


            'viene del menu del formulario

            If swCambioP = 0 Then
                If Me.tbxBuscar.Text <> "" Then
                    If swMenuPpal = 1 Then

                        ConsultarALLproyF15()
                        ConsultasDEntesFactf15()
                        f15.llenarFactPagosf15()
                        f15.lbltiproy.Text = strCodProy & " - " & strDescProy
                        ProyNro = strCodProy
                        frmExplorer.ToolStripStatusLabel.Text = "Facturas CxC " & pathContr
                        frmFacturasResumen.ShowDialog()

                    End If

                    If swMenuPpal = 4 Then
                        f16.limpiarformEstCtas()
                        ConsultasEstCtasf16()
                        f16.lbltiproy.Text = strCodProy & " - " & strDescProy

                    End If


                    If swMenuPpal = 2 Then

                        ConsultarALLproyF7()
                        f7.lbltiproy.Text = strCodProy & " - " & strDescProy
                        llenarNroctas()
                        f7.tbxCodp.Text = strCodProy
                        f7.tbxDescr.Text = strDescProy
                    End If


                    tbxBuscar.Text = ""
                    Me.Close()
                Else
                    MsgBox("Debe Ingresar un Dato", MsgBoxStyle.Information, "Control de Proyectos")
                    tbxBuscar.Focus()
                End If
            End If

        Else
            MsgBox("Debe Ingresar un Dato", MsgBoxStyle.Information, "Control de Proyectos")


        End If
        swCambioP = 0
    End Sub
    Sub llenarNrocta()
        Try
            ConexionSQL()
            Dim strDatos As New ADODB.Recordset
            Dim i As Integer = 0
            f7.ltwCtas.Items.Clear()

            strDatos = cntSQL.Execute("SELECT pro_nroContrato,[pro_nroCuenta] ,[pro_NroFactura],[pro_FechaD] ,[pro_FechaH] ,[pro_TrabajoR],[pro_FechaR],[pro_PresInsp] ,[pro_FechaP] ,[pro_duracionProy],pro_periodoCuenta ,[pro_status],[pro_tipo] from tab_DatosPpalProy_Compl where pro_nroContrato='" & ContNro & "' and pro_nroProyecto='" & ProyNro & "'")

            Do While Not strDatos.EOF

                f7.ltwCtas.Items.Add(ProyNro)

                f7.ltwCtas.Items(i).SubItems.Add(strDatos.Fields("pro_nroCuenta").Value)
                f7.ltwCtas.Items(i).SubItems.Add(strDatos.Fields("pro_NroFactura").Value)
                f7.ltwCtas.Items(i).SubItems.Add(strDatos.Fields("pro_nroContrato").Value)
                f7.ltwCtas.Items(i).SubItems.Add(strDatos.Fields("pro_FechaD").Value)
                f7.ltwCtas.Items(i).SubItems.Add(strDatos.Fields("pro_FechaH").Value)
                f7.ltwCtas.Items(i).SubItems.Add(strDatos.Fields("pro_TrabajoR").Value)
                f7.ltwCtas.Items(i).SubItems.Add(strDatos.Fields("pro_FechaR").Value)
                f7.ltwCtas.Items(i).SubItems.Add(strDatos.Fields("pro_PresInsp").Value)
                f7.ltwCtas.Items(i).SubItems.Add(strDatos.Fields("pro_FechaP").Value)
                f7.ltwCtas.Items(i).SubItems.Add(strDatos.Fields("pro_periodoCuenta").Value)
                f7.ltwCtas.Items(i).SubItems.Add(strDatos.Fields("pro_status").Value)
                f7.ltwCtas.Items(i).SubItems.Add(strDatos.Fields("pro_tipo").Value)
                i += 1
                strDatos.MoveNext()
            Loop

        Catch ex As Exception
            MsgBox("Error en buscar Nro de llenarNrocta()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        'strMenu = "2"
        'strCodbus = Me.tbxBuscar.Text
        'frmSubmenupInicio.ShowDialog()

        If swCambioP = 3 Then

            strCodbus = Me.tbxBuscar.Text
            frmHistoricoProy.ShowDialog()
        Else

            strMenu = "2"
            strCodbus = Me.tbxBuscar.Text
            frmSubmenupInicio.ShowDialog()

        End If


    End Sub

    Private Sub frmInicioproyectos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        'If e.CloseReason = CloseReason.UserClosing Then
        '    e.Cancel = False
        '    swIninio = 1
        'Else
        '    e.Cancel = True
        'End If

    End Sub

    Private Sub frmInicioproyectos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clearDcompl()
        clearDPpal1f7()
        clearEntesf7()

        tbxBuscar.Focus()
        swIninio = 0
    End Sub

    Private Sub tbxBuscar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxBuscar.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            Me.btnBuscar.Focus()

            Me.btnBuscar_Click(1, Nothing)
        End If
    End Sub

    Private Sub frmInicioproyectos_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Leave
        'swIninio = 1
    End Sub
End Class
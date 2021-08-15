Public Class frmClientes

    Private Sub tbxCodCli_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxCodCli.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            strMenu = "5"
            strCodCli = Me.tbxCodCli.Text
            frmSubmenup.ShowDialog()


            If swMen = 1 Then
                Me.tbxDescrCli.Focus()
            Else
                Me.tbxCodCli.SelectAll()
            End If

        End If
    End Sub
    Sub llenarComboPerpagoCtas()
        Try
            Dim strperCtas As New ADODB.Recordset
            '   Me.cmbperPagCtas1.Items.Clear()

            strperCtas = cntSQL.Execute("SELECT des_perpagoCuentas FROM [dbo].[tab_perpagoCuentas]")

            Do While Not strperCtas.EOF
                ' Me.cmbperPagCtas.Items.Add(strperCtas.Fields(0).Value)
                strperCtas.MoveNext()
            Loop


        Catch ex As Exception
            MsgBox("Error en funcion  llenarComboPerpagoCtas()" & ex.Message)
        End Try
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        strMenu = "5"
        frmSubmenup.ShowDialog()
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        f3.Close()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Sub guardaActClienteProy()
        Try
            Dim strCliente As New ADODB.Recordset
            Dim preg As String = ""
            strCliente = cntSQL.Execute("select [pro_codCliente],[pro_DescripcionCliente],[pro_dirCliente],[pro_personaContacto],[pro_Ruc],[pro_Dv] from [tab_ClienteProy] where [pro_codCliente]='" & f3.tbxCodCli.Text & "'")

            If strCliente.EOF = False Then

                'preg = MsgBox("Cliente registrado, desea modificar los datos..?", MsgBoxStyle.YesNo, "Control Proyectos")

                'If preg = 6 Then
                cntSQL.Execute("UPDATE [tab_ClienteProy] SET [pro_DescripcionCliente]='" & f3.tbxDescrCli.Text & "', " _
                                & " [pro_dirCliente]= '" & f3.tbxDirCli.Text & "', " _
                                & " [pro_Ruc]='" & f3.tbxTelefCli.Text & "', " _
                                & " [pro_personaContacto]='" & f3.txtResp.Text & "', " _
                                & " [pro_Dv]='" & f3.tbxPxC.Text & "' " _
                                & " where [pro_codCliente]='" & f3.tbxCodCli.Text & "'")
                'End If
            Else

                preg = MsgBox("Cliente No se encuentra registrado, desea incluir.?", MsgBoxStyle.YesNo, "Control Proyectos")

                If preg = 6 Then

                    cntSQL.Execute("insert into tab_ClienteProy ([pro_codCliente],[pro_DescripcionCliente],[pro_dirCliente],[pro_personaContacto],[pro_Ruc],[pro_Dv])" _
                                    & " values ('" & f3.tbxCodCli.Text & "', " _
                                    & " '" & f3.tbxDescrCli.Text & "', " _
                                    & " '" & f3.tbxDirCli.Text & "', " _
                                    & " '" & f3.txtResp.Text & "', " _
                                    & " '" & f3.tbxTelefCli.Text & "', " _
                                    & " '" & f3.tbxPxC.Text & "')")

                End If
                End If

                MsgBox("Datos Guardados..", MsgBoxStyle.Information, "Control Proyectos")
                limpiarClientes()

        Catch ex As Exception
            MsgBox("Error en funcion guardaActClienteProy()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try

    End Sub
    Sub ConsultasCliente()
        Try
            Dim strDCli As New ADODB.Recordset


            strDCli = cntSQL.Execute("select  * from tab_ClienteProy where pro_codCliente='" & f3.tbxCodCli.Text & "'")


            Do While Not strDCli.EOF

                f3.tbxCodCli.Text = strDCli.Fields("pro_codCliente").Value
                f3.tbxDescrCli.Text = strDCli.Fields("pro_DescripcionCliente").Value
                f3.tbxDirCli.Text = strDCli.Fields("pro_dirCliente").Value
                f3.txtResp.Text = strDCli.Fields("pro_personaContacto").Value
                f3.tbxTelefCli.Text = strDCli.Fields("pro_Ruc").Value
                f3.tbxPxC.Text = strDCli.Fields("pro_Dv").Value


                Exit Do
                strDCli.MoveNext()
            Loop
        Catch ex As Exception
            MsgBox("Error en funcion ConsultasCliente()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub


    Private Sub tbxDescrCli_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxDescrCli.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            tbxDirCli.Focus()

        End If
    End Sub

    Private Sub tbxcoda2Cli_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            tbxDirCli.Focus()

        End If
    End Sub

    Private Sub tbxDirCli_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxDirCli.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            txtResp.Focus()

        End If
    End Sub

    Private Sub tbxTelefCli_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxTelefCli.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            tbxPxC.Focus()

        End If
    End Sub

    Private Sub tbxPxC_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxPxC.KeyPress
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(tbxPxC.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                tbxPxC.Text = decimales(tbxPxC.Text)
                e.Handled = True
                Me.txtResp.Focus()

            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxPxC.SelectAll()
        End If



    End Sub

   
    Private Sub txtResp_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtResp.KeyPress

        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            Me.tbxTelefCli.Focus()

        End If

       
    End Sub
    Public Function DecimalKey(ByVal KCode As Int16) As Boolean

        If (KCode >= 48 And KCode <= 57) Or KCode = 8 Or KCode = 46 Then
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

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click

        If Me.tbxCodCli.Text <> "" Then
            guardaActClienteProy()
        Else
            MsgBox("Debe seleccionar un Cliente", MsgBoxStyle.Information, "Control Proyectos")
        End If

    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub ToolStripButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton12.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Dim preg As String = ""

        If Me.tbxCodCli.Text <> "" Then

            preg = MsgBox("Seguro que desea Incluir el Cliente", MsgBoxStyle.YesNo, "Control Proyectos")

            If preg = 6 Then
                'limpiarForm()
                Me.tbxCodCli.Focus()
                ToolStripButton1_Click(1, Nothing)

            End If
        Else

            MsgBox("Debe seleccionar un cliente", MsgBoxStyle.Information, "Control Proyectos")
        End If
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Dim preg As String = ""

        preg = MsgBox("Seguro que desea Actualizar el Cliente", MsgBoxStyle.YesNo, "Control Proyectos")
        If Me.tbxCodCli.Text <> "" Then
            If preg = 6 Then

                Me.tbxCodCli.Focus()
                ToolStripButton1_Click(1, Nothing)

            End If
        Else
            MsgBox("Debe seleccionar un cliente", MsgBoxStyle.Information, "Control Proyectos")
        End If
    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        Dim frm As New frmProcess
        Try
            Dim strcli As ADODB.Recordset
            Dim strclipro As ADODB.Recordset
            Dim strRuta As ADODB.Recordset

            Dim rif As String = ""
            Dim preg As String = ""


            preg = MsgBox("Seguro que desea Importar los datos de los Clientes?", MsgBoxStyle.YesNo, "Control Proyectos")


            If preg = 6 Then
                frm.Show()
                For x As Int32 = 0 To 1



                    ConexionSQL()

                    strRuta = cntSQL.Execute("SELECT path_conexion, pro_DescrContratista, pro_codContratista FROM tab_Contratistaproy")

                    Do While Not strRuta.EOF

                        pathsinContr = strRuta.Fields("path_conexion").Value

                        ConexionsincBDA2()

                        strcli = cntsinDBa2.Execute("SELECT FC_CODIGO,FC_DESCRIPCION, FC_DIRECCION1, FC_CONTACTO, FC_RIF, FC_NIT FROM Sclientes ")

                        Do While Not strcli.EOF
                            rif = IIf(strcli.Fields("FC_RIF").Value Is DBNull.Value, "", strcli.Fields("FC_RIF").Value)

                            strclipro = cntSQL.Execute("SELECT * FROM tab_ClienteProy where pro_Ruc='" & rif & "'")

                            If strclipro.EOF = True Then

                                cntSQL.Execute("insert into tab_ClienteProy ( [pro_codCliente],[pro_DescripcionCliente],[pro_dirCliente],[pro_personaContacto],[pro_Ruc],[pro_Dv])" _
                                    & " values ('" & IIf(strcli.Fields("FC_CODIGO").Value Is DBNull.Value, "", strcli.Fields("FC_CODIGO").Value) & "', " _
                                    & " '" & IIf(strcli.Fields("FC_DESCRIPCION").Value Is DBNull.Value, "", strcli.Fields("FC_DESCRIPCION").Value) & "', " _
                                    & " '" & IIf(strcli.Fields("FC_DIRECCION1").Value Is DBNull.Value, "", strcli.Fields("FC_DIRECCION1").Value) & "', " _
                                    & " '" & IIf(strcli.Fields("FC_CONTACTO").Value Is DBNull.Value, "", strcli.Fields("FC_CONTACTO").Value) & "', " _
                                    & " '" & IIf(strcli.Fields("FC_RIF").Value Is DBNull.Value, "", strcli.Fields("FC_RIF").Value) & "', " _
                                    & " '" & IIf(strcli.Fields("FC_NIT").Value Is DBNull.Value, "", strcli.Fields("FC_NIT").Value) & "')")



                            End If


                            strcli.MoveNext()
                        Loop

                        strRuta.MoveNext()
                    Loop

                    Exit For
                    Application.DoEvents()
                Next
                frm.Close()

                MsgBox("Importacion Concluida exitosamente", MsgBoxStyle.Information, "Control Proyectos")
            Else

                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("Error en importar Clientes A2" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
            frm.Close()
        End Try
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Try
            ConexionSQL()
            Dim preg As String = ""
            Dim strCli As New ADODB.Recordset

            If Me.tbxCodCli.Text <> "" Then
                preg = MsgBox("Seguro que desea eliminar el Cliente " & Me.tbxCodCli.Text, MsgBoxStyle.YesNo, "Control Proyectos")

                If preg = 6 Then
                    strCli = cntSQL.Execute("SELECT * FROM tab_ClienteProy WHERE pro_codCliente='" & Me.tbxCodCli.Text & "' ")

                    If strCli.EOF = False Then

                        cntSQL.Execute("DELETE FROM tab_ClienteProy WHERE pro_codCliente='" & Me.tbxCodCli.Text & "' ")
                        limpiarClientes()
                    End If

                End If

            Else
                MsgBox("Debe seleccionar un cliente", MsgBoxStyle.Information, "Control Proyectos")
            End If


        Catch ex As Exception
            MsgBox("Error al eliminar Clientes " & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub
    Sub limpiarClientes()
        tbxCodCli.Text = ""
        tbxDescrCli.Text = ""
        tbxDirCli.Text = ""
        txtResp.Text = ""
        tbxTelefCli.Text = ""
        tbxPxC.Text = ""

    End Sub

    Private Sub frmClientes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        llenarComboPerpagoCtas()
    End Sub

    'Private Sub tbxCreditos_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxCreditos.KeyPress
    '    e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

    '    bolValor = Numerico(tbxCreditos.Text)
    '    If bolValor = False Then

    '        If e.KeyChar = Convert.ToChar(Keys.Return) Then
    '            tbxCreditos.Text = decimales(tbxCreditos.Text) 'Format(CDec(txtMonto.Text), "C")
    '            e.Handled = True


    '        End If

    '    Else
    '        intk = 0
    '        MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
    '        Me.tbxCreditos.SelectAll()
    '    End If
    'End Sub

    'Private Sub tbxCreditos_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbxCreditos.Leave
    '    bolValor = Numerico(tbxCreditos.Text)
    '    If bolValor = False Then


    '        tbxCreditos.Text = decimales(tbxCreditos.Text) 'Format(CDec(txtMonto.Text), "C")

    '    Else
    '    intk = 0
    '    MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
    '    Me.tbxCreditos.SelectAll()
    '    End If
    'End Sub

 
End Class
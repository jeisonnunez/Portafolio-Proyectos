Public Class frmEmpresaCont
    Public swMenu As Integer = 0

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        f5.Close()
    End Sub

    Private Sub tbxCodCon_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxCodCon.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            strMenu = "6"
            strCodCli = Me.tbxCodCon.Text
            frmSubmenup.ShowDialog()


            If swMen = 1 Then
                Me.tbxDescrCont.Focus()
            Else
                Me.tbxCodCon.SelectAll()
            End If

        End If
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        limpiarForm()
        strMenu = "6"
        frmSubmenup.ShowDialog()
    End Sub


    Sub guardaActContrProy()
        Try
            Dim strCliente As New ADODB.Recordset
            Dim preg As String = ""
            strCliente = cntSQL.Execute("select [pro_codContratista],[pro_DescrContratista],[pro_codA2cContratista],[pro_dircContratista],[pro_telefContratista],[pro_personaContContratista],[pro_ContMonto],	[path_conexion] from [tab_Contratistaproy] where [pro_codContratista]='" & f5.tbxCodCon.Text & "'")



            If strCliente.EOF = False Then

                preg = MsgBox("Contratista regisrado, desea modificar los datos?", MsgBoxStyle.YesNo, "Control Proyectos")

                If preg = "6" Then

                    cntSQL.Execute("UPDATE [tab_Contratistaproy] SET " _
                               & " path_conexion='" & f5.tbxServer.Text & "', " _
                               & " [pro_DescrContratista]='" & f5.tbxDescrCont.Text & "', " _
                               & " [pro_codA2cContratista]= '" & f5.tbxcoda2Cont.Text & "', " _
                               & " [pro_dircContratista]='" & f5.tbxDirCont.Text & "', " _
                               & " [pro_telefContratista]='" & f5.tbxTelefCont.Text & "', " _
                               & " [pro_personaContContratista]='" & f5.txtRespcont.Text & "', " _
                               & "  pro_ContMonto='" & Replace(IIf(f5.tbxPxCont.Text = "", 0, f5.tbxPxCont.Text), ",", "") & "' " _
                               & "  where [pro_codContratista]='" & f5.tbxCodCon.Text & "'")

                    limpiarForm()
                    MsgBox("Datos Actualizados..", MsgBoxStyle.Information, "Control Proyectos")

                End If

            Else


                preg = MsgBox("Contratista No existe, desea Insertar los datos?", MsgBoxStyle.YesNo, "Control Proyectos")

                If preg = "6" Then

                    cntSQL.Execute("insert into tab_Contratistaproy ([pro_codContratista],[pro_DescrContratista],[pro_codA2cContratista],[pro_dircContratista],[pro_telefContratista],[pro_personaContContratista],[pro_ContMonto],	[path_conexion])" _
                                    & " values ('" & f5.tbxCodCon.Text & "', " _
                                    & " '" & f5.tbxDescrCont.Text & "', " _
                                    & " '" & f5.tbxcoda2Cont.Text & "', " _
                                    & " '" & f5.tbxDirCont.Text & "', " _
                                    & " '" & f5.tbxTelefCont.Text & "', " _
                                    & " '" & f5.txtRespcont.Text & "'," _
                                    & " " & Replace(IIf(f5.tbxPxCont.Text = "", 0, f5.tbxPxCont.Text), ",", "") & ", " _
                                    & " '" & f5.tbxServer.Text & "' )")

                    limpiarForm()
                    MsgBox("Datos Guardados..", MsgBoxStyle.Information, "Control Proyectos")
                End If

                limpiarForm()
            End If


        Catch ex As Exception
            MsgBox("Error en funcion guardaActContrProy()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try

    End Sub

    Sub eliminaContrProy()
        Try
            Dim strCliente As New ADODB.Recordset
            Dim preg As String = ""

            strCliente = cntSQL.Execute("select [pro_codContratista],[pro_DescrContratista],[pro_codA2cContratista],[pro_dircContratista],[pro_telefContratista],[pro_personaContContratista],[pro_ContMonto],	[path_conexion] from [tab_Contratistaproy] where [pro_codContratista]='" & f5.tbxCodCon.Text & "'")



            If strCliente.EOF = False Then
                preg = MsgBox("Seguro que desea eliminar el registro", MsgBoxStyle.YesNo, "Control Proyectos")

                If preg = 6 Then
                    cntSQL.Execute("DELETE from [tab_Contratistaproy] where [pro_codContratista]='" & f5.tbxCodCon.Text & "'")
                Else
                    activadMenu()
                    Exit Sub
                End If
            End If

            limpiarForm()
            MsgBox("Datos Eliminados..", MsgBoxStyle.Information, "Control Proyectos")

        Catch ex As Exception
            MsgBox("Error en funcion eliminaContrProy()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub tbxPxCont_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxPxCont.KeyPress
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(tbxPxCont.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                tbxPxCont.Text = decimales(tbxPxCont.Text)
                e.Handled = True
                Me.txtRespcont.Focus()

            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxPxCont.SelectAll()
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
    Sub ConsultasContratista()
        Try
            Dim strDCont As New ADODB.Recordset


            strDCont = cntSQL.Execute("select  * from tab_Contratistaproy where pro_codContratista='" & f5.tbxCodCon.Text & "'")


            Do While Not strDCont.EOF

                f5.tbxCodCon.Text = strDCont.Fields("pro_codContratista").Value
                f5.tbxDescrCont.Text = strDCont.Fields("pro_DescrContratista").Value
                f5.tbxcoda2Cont.Text = strDCont.Fields("pro_codA2cContratista").Value
                f5.tbxDirCont.Text = strDCont.Fields("pro_dircContratista").Value
                f5.tbxTelefCont.Text = strDCont.Fields("pro_telefContratista").Value
                f5.txtRespcont.Text = strDCont.Fields("pro_personaContContratista").Value
                f5.tbxPxCont.Text = decimales(Math.Round(strDCont.Fields("pro_ContMonto").Value, 2))
                f5.tbxServer.Text = strDCont.Fields("path_conexion").Value

                Exit Do
                strDCont.MoveNext()
            Loop

        Catch ex As Exception
            MsgBox("Error en funcion ConsultasContratista()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub

    Sub llenarContratistas()
        Try
            ConexionSQL()
            Dim strDatos As New ADODB.Recordset
            Dim i As Integer = 0
            Me.ltwContratistas.Items.Clear()

            strDatos = cntSQL.Execute("select [pro_codContratista],[pro_DescrContratista],[pro_codA2cContratista],[pro_dircContratista],[pro_telefContratista],[pro_personaContContratista],[pro_ContMonto], [path_conexion] from [tab_Contratistaproy]")


            Do While Not strDatos.EOF



                Me.ltwContratistas.Items.Add(strDatos.Fields("pro_codContratista").Value)
                Me.ltwContratistas.Items(i).SubItems.Add(strDatos.Fields("pro_DescrContratista").Value)
                Me.ltwContratistas.Items(i).SubItems.Add(strDatos.Fields("pro_codA2cContratista").Value)
                Me.ltwContratistas.Items(i).SubItems.Add(strDatos.Fields("pro_dircContratista").Value)
                Me.ltwContratistas.Items(i).SubItems.Add(strDatos.Fields("pro_telefContratista").Value)

                Me.ltwContratistas.Items(i).SubItems.Add(decimales(Math.Round(strDatos.Fields("pro_ContMonto").Value, 2)))
                Me.ltwContratistas.Items(i).SubItems.Add(strDatos.Fields("pro_personaContContratista").Value)
                Me.ltwContratistas.Items(i).SubItems.Add(strDatos.Fields("path_conexion").Value)


                i += 1
                strDatos.MoveNext()
            Loop

        Catch ex As Exception
            MsgBox("Error en buscar Nro de llenarFactestCtas()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
       
        If Me.tbxCodCon.Text <> "" And Me.tbxServer.Text <> "" And tbxDescrCont.Text <> "" Then

            guardaActContrProy()
            llenarContratistas()
            activadMenu()
        Else
            MsgBox("Campos con (*) son obligatorios", MsgBoxStyle.Critical, "Control Proyectos")

        End If

        


      
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub ToolStripButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton12.Click
        Me.Close()
    End Sub



    Private Sub tbxTelefCont_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxTelefCont.KeyPress

        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            e.Handled = True
            Me.tbxPxCont.Focus()

        End If



    End Sub

    Private Sub tbxDirCont_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxDirCont.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            e.Handled = True
            tbxTelefCont.Focus()

        End If
    End Sub

    Private Sub tbxcoda2Cont_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxcoda2Cont.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            e.Handled = True
            tbxDirCont.Focus()

        End If
    End Sub

    Private Sub tbxDescrCont_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxDescrCont.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            e.Handled = True
            tbxcoda2Cont.Focus()

        End If
    End Sub

    Private Sub tbxServer_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxServer.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            e.Handled = True
            tbxDescrCont.Focus()

        End If
    End Sub

    Private Sub btnAcept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAcept.Click
        SeleccionarDirectorio()
    End Sub
    Sub SeleccionarDirectorio()
        'definimos las variables que emplearemos
        Dim Titulo, Directorio As String
        Titulo = "Selecciona la ruta de tu carpeta"
        On Error Resume Next
        'evitaría un error en caso de no seleccionar nada o pulsar ESC
        With CreateObject("shell.application")
            Directorio = .browseforfolder(0, Titulo, 0).Items.Item.path
        End With : On Error GoTo 0
        'la siguiente instruccíon IF ejecuta una acción a modo de ejemplo

        If Directorio = "" Then

            MsgBox("No ha seleccionado ningún directorio.", , "Control Proyectos")

        Else

            Me.tbxServer.Text = Directorio

        End If


    End Sub

    Private Sub txtRespcont_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRespcont.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            e.Handled = True
            tbxServer.Focus()

        End If
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Dim preg As String = ""

        preg = MsgBox("Seguro que desea Incluir el Contratista", MsgBoxStyle.YesNo, "Control Proyectos")

        If preg = 6 Then
            ToolStripButton1_Click(1, Nothing)
            limpiarForm()
            Me.tbxCodCon.Focus()

            swMenu = 1
            enabledMenu()
        End If

    End Sub
    Sub enabledMenu()
        'nuevo
        If swMenu = 1 Then
            'ToolStripButton2.Enabled = False
            ToolStripButton3.Enabled = False
            ToolStripButton4.Enabled = False
        End If

        'edita
        If swMenu = 2 Then
            ToolStripButton2.Enabled = False
            ' ToolStripButton3.Enabled = False
            ToolStripButton4.Enabled = False
        End If

        'Elimina
        If swMenu = 3 Then
            ToolStripButton1.Enabled = False
            ToolStripButton2.Enabled = False
            ToolStripButton3.Enabled = False
            ' ToolStripButton4.Enabled = False
        End If
       


    End Sub
    Sub activadMenu()

        ToolStripButton2.Enabled = True
        ToolStripButton3.Enabled = True
        ToolStripButton4.Enabled = True
        ToolStripButton1.Enabled = True

        swMenu = 0
    End Sub

    Sub limpiarForm()
        Me.tbxServer.Text = ""
        Me.tbxDirCont.Text = ""
        Me.tbxTelefCont.Text = ""
        Me.tbxDirCont.Text = ""
        Me.tbxPxCont.Text = ""
        Me.tbxDescrCont.Text = ""
        Me.tbxcoda2Cont.Text = ""
        Me.tbxCodCon.Text = ""
        Me.txtRespcont.Text = ""
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Dim preg As String = ""

        preg = MsgBox("Seguro que desea Actualizar el Contratista", MsgBoxStyle.YesNo, "Control Proyectos")

        If preg = 6 Then
            swMenu = 2
            Me.tbxCodCon.Focus()
            ToolStripButton1_Click(1, Nothing)
            enabledMenu()
        End If

    End Sub

    Private Sub ltwContratistas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ltwContratistas.SelectedIndexChanged
        If Me.ltwContratistas.Items.Count > 0 Then

            For i = 0 To Me.ltwContratistas.Items.Count - 1

                If Me.ltwContratistas.Items(i).Selected = True Then

                    Me.tbxCodCon.Text = Me.ltwContratistas.FocusedItem.SubItems(0).Text
                    Me.tbxDescrCont.Text = Me.ltwContratistas.FocusedItem.SubItems(1).Text
                    Me.tbxcoda2Cont.Text = Me.ltwContratistas.FocusedItem.SubItems(2).Text
                    tbxDirCont.Text = Me.ltwContratistas.FocusedItem.SubItems(3).Text
                    Me.tbxTelefCont.Text = Me.ltwContratistas.FocusedItem.SubItems(4).Text
                    Me.tbxPxCont.Text = Me.ltwContratistas.FocusedItem.SubItems(5).Text
                    Me.txtRespcont.Text = Me.ltwContratistas.FocusedItem.SubItems(6).Text
                    tbxServer.Text = Me.ltwContratistas.FocusedItem.SubItems(7).Text



                End If

            Next

        End If

    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        swMenu = 3
        enabledMenu()
        eliminaContrProy()
        activadMenu()
        llenarContratistas()

    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        activadMenu()
        limpiarForm()
        swMenu = 0
    End Sub

    Private Sub tbxCodCon_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbxCodCon.Leave
        'strMenu = "6"
        'strCodCli = Me.tbxCodCon.Text
        'frmSubmenup.ShowDialog()


        'If swMen = 1 Then
        '    Me.tbxDescrCont.Focus()
        'Else
        '    Me.tbxCodCon.SelectAll()
        'End If
    End Sub
End Class
Public Class frmInventarioA2
    Dim swproy As Integer = 0
    Private Sub frmInventarioA2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        revisaContrDB()
    End Sub

    
    Sub revisaContrDB()
        Try
            Dim strCont As ADODB.Recordset
            Dim i As Integer = 0
            Dim strInv As ADODB.Recordset

            Dim frm As New frmProcess


            frm.Show()
            For x As Int32 = 0 To 1

                Me.ltwInv.Items.Clear()

                ConexionSQL()

                strCont = cntSQL.Execute("SELECT path_conexion, pro_DescrContratista, pro_codContratista FROM tab_Contratistaproy")


                If strCont.EOF = True Then
                    MsgBox("No existen Contratistas cargados, por favor vaya al menu Contratista y cargue la información", MsgBoxStyle.Information, "Control de Proyectos")
                Else


                    Do While Not strCont.EOF

                        pathsinContr = strCont.Fields("path_conexion").Value

                        ConexionsincBDA2()

                     

                        strInv = cntsinDBa2.Execute("SELECT FI_CODIGO, FI_DESCRIPCION FROM sinventario where FI_CODIGO like '%" & f1.tbxCodp.Text & "%' or FI_DESCRIPCION like '%" & f1.tbxCodp.Text & "%'")

                        Do While Not strInv.EOF

                            Me.ltwInv.Items.Add(strInv.Fields("FI_CODIGO").Value)
                            Me.ltwInv.Items(i).SubItems.Add(strInv.Fields("FI_DESCRIPCION").Value)
                            Me.ltwInv.Items(i).SubItems.Add(strCont.Fields("pro_DescrContratista").Value)
                            Me.ltwInv.Items(i).SubItems.Add(strCont.Fields("pro_codContratista").Value)

                            i += 1
                            strInv.MoveNext()
                        Loop

                        strCont.MoveNext()
                    Loop

                End If

                Exit For
                Application.DoEvents()
            Next
            frm.Close()
        Catch ex As Exception
            MsgBox("Error en funcion revisaContrDB() " & pathsinContr & ex.Message, MsgBoxStyle.Critical, "Control de Proyectos")
        End Try
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.close()
    End Sub

    Private Sub ltwInv_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ltwInv.DoubleClick
        If Me.ltwInv.Items.Count > 0 Then

            For i = 0 To Me.ltwInv.Items.Count - 1
                If Me.ltwInv.FocusedItem.SubItems(0).Text <> "" Then

                    f1.tbxCodp.Text = Me.ltwInv.FocusedItem.SubItems(0).Text
                    f1.tbxDescr.Text = Me.ltwInv.FocusedItem.SubItems(1).Text
                    f1.tbxCont.Text = buscarCont(ltwInv.FocusedItem.SubItems(3).Text)
                    Exit For
                End If
            Next

        End If

        f1.tbxCont.Text = contratista
        f1.lblCont.Text = lblCon

        ProyNro = f1.tbxCodp.Text
        strDescProy = f1.tbxDescr.Text
        strCodProy = f1.tbxCodp.Text


        swMenuPpal = 0
        strMenu = "2"
        strCodbus = f1.tbxCodp.Text
        strCodProy = f1.tbxCodp.Text

        Me.buscarProyecto()

        If swproy = 1 Then
            MsgBox("Nro de Proyecto se encuentra Registrado, por Favor Verifique", MsgBoxStyle.Information, "Control de Proyectos")
            f1.tbxCodp.Text = ""
            f1.tbxDescr.Text = ""
            swproy = 0
            Exit Sub
        ElseIf swproy = 2 Then
            f1.tbxCodp.Focus()
        Else
            ProyNro = f1.tbxCodp.Text
            idProyecto(1)
            f1.tbxDescr.Focus()
            '  f1.txtCuenta.Text = 1

        End If
        swproy = 0
        Me.Close()

    End Sub
    Sub buscarProyecto()
        ConexionSQL()
        Dim strBuscar As ADODB.Recordset

        Try

            If f1.tbxCodp.Text <> "" Then
                strBuscar = cntSQL.Execute("SELECT id_proyecto, Nro_proyecto, desc_Proyecto, HIST_proyecto FROM tab_idProyecto where Nro_proyecto ='" & strCodbus & "'   and HIST_proyecto=1")

                Do While Not strBuscar.EOF

                    swproy = 1
                    strBuscar.MoveNext()
                Loop
            Else
                swproy = 2
                MsgBox("Debe Colocar un Valor", MsgBoxStyle.Information, "Control de Proyectos")
            End If
        Catch ex As Exception
            MsgBox("Error en funcion buscarProyecto()", MsgBoxStyle.Critical, "Control de Proyectos")
        End Try
    End Sub
End Class
Public Class frmSubmenup

    Private Sub frmSubmenup_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'f1.Close()
    End Sub

    Private Sub frmSubmenup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            swMen = 0
            ConexionSQL()
            Dim strSubmenu As New ADODB.Recordset
            Dim i As Integer = 0
            Dim strpreg As String = ""
            Me.ltvMenup.Items.Clear()
            '  clearFormularios1()
            'lo llama el boton siguiente del Modulo de Proyecto
            If strMenu = "1" Then
                Me.Text = "SELECCIÓN DE MENÚ"

                strSubmenu = cntSQL.Execute("SELECT id_codmenup, desc_menup FROM [tab_MenuProy]")

                Do While Not strSubmenu.EOF

                    Me.ltvMenup.Items.Add(strSubmenu.Fields("id_codmenup").Value)
                    Me.ltvMenup.Items(i).SubItems.Add(strSubmenu.Fields("desc_menup").Value)
                    i += 1

                    strSubmenu.MoveNext()

                Loop
            End If

            'lo llama el boton siguiente del Modulo de Proyecto
            If strMenu = "2" Then

                Me.Text = "SELECCIÓN DE PROYECTOS"

                If f7.tbxCodp.Text = "" Then
                    ProyNro = 0
                Else
                    ProyNro = f7.tbxCodp.Text
                End If

                If f7.tbxCodp.Text = "" Then

                    strSubmenu = cntSQL.Execute("SELECT  id_proyecto, Nro_proyecto, desc_Proyecto, HIST_proyecto FROM tab_idProyecto where  HIST_proyecto=1 ")
                Else

                    strSubmenu = cntSQL.Execute("SELECT id_proyecto, Nro_proyecto, desc_Proyecto, HIST_proyecto FROM tab_idProyecto where (Nro_proyecto like '%" & strCodbus & "%' or desc_Proyecto like '%" & strCodbus & "%') and (HIST_proyecto=1)")
                End If

                Do While Not strSubmenu.EOF


                    Me.ltvMenup.Items.Add(strSubmenu.Fields("Nro_proyecto").Value)
                    Me.ltvMenup.Items(i).SubItems.Add(strSubmenu.Fields("desc_Proyecto").Value)
                    Me.ltvMenup.Items(i).SubItems.Add(strSubmenu.Fields("id_proyecto").Value)
                    i += 1

                    strSubmenu.MoveNext()

                Loop
            End If

            '    If strSubmenu.EOF = True Then
            '        strpreg = MsgBox("Proyecto NO existe, desea ingresar uno Nuevo", MsgBoxStyle.YesNoCancel)

            '        If strpreg = 6 Then

            '            strCodProy = f15.tbxCodp.Text
            '            DescProy = InputBox("Nombre del Proyecto", "Control de Proyectos")


            '            Do While Not DescProy <> ""

            '                If DescProy = "" Then
            '                    DescProy = UCase(InputBox("Nombre del Proyecto", "Control de Proyectos"))
            '                ElseIf DescProy = vbEmpty Then
            '                    Exit Sub
            '                Else
            '                    End
            '                End If

            '            Loop

            '            idProyecto(1)
            '            guardaActDPpalProy15()
            '            f15.tbxDescr.Text = DescProy
            '            f15.tbxDescr.Focus()
            '            f15.tbxDescr.Text = DescProy
            '            Me.Close()
            '            Exit Sub

            '        Else

            '            f15.tbxDescr.Focus()
            '            Me.Close()
            '            Exit Sub
            '        End If

            '        Else

            '            If strSubmenu.EOF = True Then
            '                MsgBox("Debe colocar un Valor", MsgBoxStyle.Exclamation)

            '            Else


            '                Do While Not strSubmenu.EOF


            '                    Me.ltvMenup.Items.Add(strSubmenu.Fields("Nro_proyecto").Value)
            '                    Me.ltvMenup.Items(i).SubItems.Add(strSubmenu.Fields("desc_Proyecto").Value)
            '                    Me.ltvMenup.Items(i).SubItems.Add(strSubmenu.Fields("id_proyecto").Value)
            '                    i += 1

            '                    strSubmenu.MoveNext()

            '                Loop


            '            End If
            '        End If
            'End If

            'lo llama el boton Contratista
            If strMenu = "3" Then

                Me.Text = "SELECCIÓN DE CONTRATISTA"

                If f1.tbxCont.Text = "" Then

                    strSubmenu = cntSQL.Execute("SELECT [pro_codContratista], [pro_DescrContratista] FROM [tab_Contratistaproy]")
                Else

                    strSubmenu = cntSQL.Execute("SELECT [pro_codContratista], [pro_DescrContratista] FROM [tab_Contratistaproy] where pro_DescrContratista like '%" & strCodCont & "%'")
                End If


                If strSubmenu.EOF = True Then
                    MsgBox("Contratista NO se encuentra registrado.., por favor registre el mismo en el Menu Contratista", MsgBoxStyle.Critical, "Control Proyectos")
                    'f1.tbxContr.SelectAll()
                    swMen = 1
                    Me.Close()
                Else

                    If strSubmenu.EOF = True Then
                        MsgBox("Debe colocar un Valor", MsgBoxStyle.Exclamation)

                    Else

                        Do While Not strSubmenu.EOF


                            Me.ltvMenup.Items.Add(strSubmenu.Fields("pro_codContratista").Value)
                            Me.ltvMenup.Items(i).SubItems.Add(strSubmenu.Fields("pro_DescrContratista").Value)
                            Me.ltvMenup.Items(i).SubItems.Add("")
                            i += 1

                            strSubmenu.MoveNext()

                        Loop

                    End If
                End If
                If swMenuPpal = 2 Then
                    f7.tbxCont.Text = strDescCont
                End If

                If swMenuPpal = 1 Then
                    f1.tbxCont.Text = strDescCont
                End If

            End If
            'lo llama el boton Contratista
            If strMenu = "8" Then

                Me.Text = "SELECCIÓN DE CONTRATISTA"

                'If f15.tbxCont.Text = "" Then

                '    strSubmenu = cntSQL.Execute("SELECT [pro_codContratista], [pro_DescrContratista] FROM [tab_Contratistaproy]")
                'Else

                '    strSubmenu = cntSQL.Execute("SELECT [pro_codContratista], [pro_DescrContratista] FROM [tab_Contratistaproy] where pro_DescrContratista like '%" & strCodCont & "%'")
                'End If


                If strSubmenu.EOF = True Then
                    MsgBox("Contratista NO se encuentra registrado.., por favor registre el mismo en el Menu Contratista", MsgBoxStyle.Critical, "Control Proyectos")
                    'f1.tbxContr.SelectAll()
                    swMen = 1
                    Me.Close()
                Else

                    If strSubmenu.EOF = True Then
                        MsgBox("Debe colocar un Valor", MsgBoxStyle.Exclamation)

                    Else

                        Do While Not strSubmenu.EOF


                            Me.ltvMenup.Items.Add(strSubmenu.Fields("pro_codContratista").Value)
                            Me.ltvMenup.Items(i).SubItems.Add(strSubmenu.Fields("pro_DescrContratista").Value)
                            Me.ltvMenup.Items(i).SubItems.Add("")
                            i += 1

                            strSubmenu.MoveNext()

                        Loop

                    End If
                End If


                If swMenuPpal = 2 Then
                    f7.tbxCont.Text = strDescCont
                End If

                If swMenuPpal = 1 Then
                    f1.tbxCont.Text = strDescCont
                End If

            End If



            'lo llama el boton Cliente
            If strMenu = "4" Then

                Me.Text = "SELECCIÓN DE CLIENTE"

                If f1.tbxClient.Text = "" Then

                    strSubmenu = cntSQL.Execute("SELECT pro_codCliente, pro_DescripcionCliente, pro_Ruc  FROM tab_ClienteProy")
                Else

                    strSubmenu = cntSQL.Execute("SELECT pro_codCliente, pro_DescripcionCliente, pro_Ruc FROM tab_ClienteProy where pro_DescripcionCliente like '%" & strCodCli & "%'")
                End If


                If strSubmenu.EOF = True Then
                    'MsgBox("Cliente NO se encuentra registrado.., por favor registre el mismo en el Menu Cliente", MsgBoxStyle.Critical, "Control Proyectos")
                    'f1.tbxClient.SelectAll()
                    'swMen = 1
                    'Me.Close()
                Else
                    If strSubmenu.EOF = True Then
                        MsgBox("Debe colocar un Valor", MsgBoxStyle.Exclamation)

                    Else

                        Do While Not strSubmenu.EOF


                            Me.ltvMenup.Items.Add(strSubmenu.Fields("pro_codCliente").Value)
                            Me.ltvMenup.Items(i).SubItems.Add(strSubmenu.Fields("pro_DescripcionCliente").Value)
                            Me.ltvMenup.Items(i).SubItems.Add("pro_Ruc")
                            i += 1

                            strSubmenu.MoveNext()

                        Loop
                    End If
                End If
            End If

            'lo llama el boton Cliente
            If strMenu = "9" Then

                Me.Text = "SELECCIÓN DE CLIENTE"

                'If f15.tbxClient.Text = "" Then

                '    strSubmenu = cntSQL.Execute("SELECT pro_codCliente, pro_DescripcionCliente, pro_codA2cliente  FROM tab_ClienteProy")
                'Else

                '    strSubmenu = cntSQL.Execute("SELECT pro_codCliente, pro_DescripcionCliente, pro_codA2cliente FROM tab_ClienteProy where pro_DescripcionCliente like '%" & strCodCli & "%'")
                'End If


                If strSubmenu.EOF = True Then
                    'MsgBox("Cliente NO se encuentra registrado.., por favor registre el mismo en el Menu Cliente", MsgBoxStyle.Critical, "Control Proyectos")
                    ''f15.tbxClient.SelectAll()
                    'swMen = 1
                    'Me.Close()
                Else
                    If strSubmenu.EOF = True Then
                        MsgBox("Debe colocar un Valor", MsgBoxStyle.Exclamation)

                    Else

                        Do While Not strSubmenu.EOF


                            Me.ltvMenup.Items.Add(strSubmenu.Fields("pro_codCliente").Value)
                            Me.ltvMenup.Items(i).SubItems.Add(strSubmenu.Fields("pro_DescripcionCliente").Value)
                            Me.ltvMenup.Items(i).SubItems.Add("pro_Ruc")
                            i += 1

                            strSubmenu.MoveNext()

                        Loop
                    End If
                End If





            End If
            'lo llama el boton Cliente del formulario
            If strMenu = "5" Then

                Me.Text = "SELECCIÓN DE CLIENTE"

                If f3.tbxCodCli.Text = "" Then

                    strSubmenu = cntSQL.Execute("SELECT pro_codCliente, pro_DescripcionCliente, pro_Ruc  FROM tab_ClienteProy")
                Else

                    strSubmenu = cntSQL.Execute("SELECT pro_codCliente, pro_DescripcionCliente, pro_Ruc FROM tab_ClienteProy where pro_DescripcionCliente like '%" & strCodCli & "%' or pro_codCliente like '%" & strCodCli & "%'")
                End If

                If strSubmenu.EOF = True Then
                    strpreg = MsgBox("Cliente NO se encuentra registrado.., desea Incluirlo", MsgBoxStyle.YesNo)

                    If strpreg = 6 Then
                        f3.tbxDescrCli.Focus()
                        Me.Close()
                        swMen = 1

                    Else
                        f3.tbxCodCli.Focus()
                        Me.Close()
                    End If


                Else

                    If strSubmenu.EOF = True Then
                        MsgBox("Debe colocar un Valor", MsgBoxStyle.Exclamation)

                    Else
                        Me.ltvMenup.Refresh()
                        Do While Not strSubmenu.EOF


                            Me.ltvMenup.Items.Add(strSubmenu.Fields("pro_codCliente").Value)
                            Me.ltvMenup.Items(i).SubItems.Add(strSubmenu.Fields("pro_DescripcionCliente").Value)
                            Me.ltvMenup.Items(i).SubItems.Add("pro_Ruc")
                            i += 1

                            strSubmenu.MoveNext()

                        Loop
                        Me.ltvMenup.Refresh()
                    End If
                End If

            End If
            'lo llama el boton Contratista del formulario

            If strMenu = "6" Then

                Me.Text = "SELECCIÓN DE CONTRATISTA"

                If f5.tbxCodCon.Text = "" Then

                    strSubmenu = cntSQL.Execute("SELECT * from tab_Contratistaproy")
                Else

                    strSubmenu = cntSQL.Execute("SELECT * from tab_Contratistaproy where pro_codContratista  like '%" & f5.tbxCodCon.Text & "%' or [pro_DescrContratista] like '%" & f5.tbxCodCon.Text & "%'")
                End If


                If strSubmenu.EOF = True And f5.tbxCodCon.Text <> "" Then
                    strpreg = MsgBox("Contratista NO se encuentra registrado.., desea Incluirlo", MsgBoxStyle.YesNo)

                    If strpreg = 6 Then
                        f5.tbxDescrCont.Focus()
                        Me.Close()
                        swMen = 1

                    Else
                        f5.tbxCodCon.Focus()
                        Me.Close()
                    End If


                Else

                    If strSubmenu.EOF = True And f5.tbxCodCon.Text = "" Then
                        MsgBox("Debe colocar un Valor", MsgBoxStyle.Exclamation)
                        Me.Close()
                    Else


                        Do While Not strSubmenu.EOF


                            Me.ltvMenup.Items.Add(strSubmenu.Fields("pro_codContratista").Value)
                            Me.ltvMenup.Items(i).SubItems.Add(strSubmenu.Fields("pro_DescrContratista").Value)
                            Me.ltvMenup.Items(i).SubItems.Add("pro_codA2cContratista")
                            i += 1

                            strSubmenu.MoveNext()

                        Loop
                    End If
                End If


            End If

            'lo llama el boton de los parametros
            If strMenu = "10" Then

                Me.Text = "SELECCIÓN DE CLIENTE"

                If frmcarteraT.tbxCodCli.Text = "" Then

                    strSubmenu = cntSQL.Execute("SELECT pro_codCliente, pro_DescripcionCliente, pro_Ruc  FROM tab_ClienteProy")
                Else

                    strSubmenu = cntSQL.Execute("SELECT pro_codCliente, pro_DescripcionCliente, pro_Ruc FROM tab_ClienteProy where pro_DescripcionCliente like '%" & strCodCli & "%' or pro_codCliente like '%" & strCodCli & "%'")
                End If

             

                If strSubmenu.EOF = True Then
                    MsgBox("Debe colocar un Valor", MsgBoxStyle.Exclamation)

                Else
                    Me.ltvMenup.Refresh()
                    Do While Not strSubmenu.EOF


                        Me.ltvMenup.Items.Add(strSubmenu.Fields("pro_codCliente").Value)
                        Me.ltvMenup.Items(i).SubItems.Add(strSubmenu.Fields("pro_DescripcionCliente").Value)
                        Me.ltvMenup.Items(i).SubItems.Add("pro_Ruc")
                        i += 1

                        strSubmenu.MoveNext()

                    Loop
                    Me.ltvMenup.Refresh()
                End If


            End If


        Catch ex As Exception
            MsgBox("Error en funcion frmSubmenup_Load" & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub



    Private Sub ltvMenup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If strMenu = "1" Then
        '    strcodMenu = Me.ltvMenup.FocusedItem.Text
        'End If

        'If strMenu = "2" Then
        '    strCodProy = Me.ltvMenup.FocusedItem.Text
        'End If
    End Sub




    Private Sub ltvMenup_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If strMenu = "1" Then
            strcodMenu = Me.ltvMenup.FocusedItem.Text
        End If

        If strMenu = "2" Then
            strCodProy = Me.ltvMenup.FocusedItem.Text
            f1.tbxDescr.Focus()
        End If

        If strMenu = "3" Then
            strCodCont = Me.ltvMenup.FocusedItem.Text
            f1.tbxClient.Focus()
        End If

        If strMenu = "4" Then
            strCodCli = Me.ltvMenup.FocusedItem.Text
            f1.tbxGProy.Focus()
        End If


    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
        'f1.Close()
    End Sub

    Private Sub ltvMenup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim i As Integer = 0

        'Try

        '    If strMenu = "1" Then
        '        If Me.ltvMenup.Items.Count > 0 Then

        '            For i = 0 To Me.ltvMenup.Items.Count - 1
        '                If Me.ltvMenup.Items(i).Text = 6 Then
        '                    f1.Close()
        '                    Me.Close()
        '                Else
        '                    ' strcodMenu = Me.ltvMenup.FocusedItem.Text


        '                    If strcodMenu = "1" Then

        '                        frmMenuProyectoIncluir.tbcProy.SelectedTab = frmMenuProyecto.tbcProy.TabPages(0)
        '                        Me.Close()
        '                        Exit For

        '                    End If

        '                    If strcodMenu = "2" Then

        '                        frmMenuProyectoIncluir.tbcProy.SelectedTab = frmMenuProyecto.tbcProy.TabPages(3)
        '                        Me.Close()
        '                        Exit For
        '                    End If


        '                    If strcodMenu = "3" Then

        '                        frmMenuProyectoIncluir.tbcProy.SelectedTab = frmMenuProyecto.tbcProy.TabPages(3)
        '                        Me.Close()
        '                        Exit For
        '                    End If


        '                    If strcodMenu = "4" Then

        '                        frmMenuProyecto.tbcProy.SelectedTab = frmMenuProyecto.tbcProy.TabPages(3)
        '                        Me.Close()
        '                        Exit For
        '                    End If

        '                    If strcodMenu = "5" Then

        '                        frmMenuProyecto.tbcProy.SelectedTab = frmMenuProyecto.tbcProy.TabPages(4)
        '                        Me.Close()
        '                        Exit For
        '                    End If
        '                End If
        '            Next
        '        End If
        '    End If

        '    'PROYECTO
        '    If strMenu = "2" Then

        '        If Me.ltvMenup.Items.Count > 0 Then

        '            For i = 0 To Me.ltvMenup.Items.Count - 1

        '                strCodProy = Me.ltvMenup.FocusedItem.Text
        '                strDescProy = Me.ltvMenup.FocusedItem.SubItems(1).Text
        '                stridProy = Me.ltvMenup.FocusedItem.SubItems(2).Text
        '            Next

        '        End If

        '        If swMenuPpal = 0 Then
        '            f1.lblid.Text = stridProy
        '            f1.tbxCodp.Text = strCodProy
        '            f1.tbxDescr.Text = strDescProy
        '            ProyNro = f1.tbxCodp.Text
        '        End If

        '        If swMenuPpal = 2 Then
        '            f7.lblid.Text = stridProy
        '            f7.tbxCodp.Text = strCodProy
        '            f7.tbxDescr.Text = strDescProy
        '            ProyNro = f7.tbxCodp.Text

        '            f7.lbltiproy.Text = strCodProy & " - " & strDescProy
        '            ConsultarALLproyF7()
        '        End If

        '        If swMenuPpal = 1 Then
        '            'f15.lblid.Text = stridProy
        '            'f15.tbxCodp.Text = strCodProy
        '            'ProyNro = f15.tbxCodp.Text
        '            'f15.tbxDescr.Text = strDescProy

        '            f15.lbltiproy.Text = strCodProy & " - " & strDescProy
        '            ConsultarALLproyF15()
        '        End If

        '        Me.Close()

        '    End If

        '    'CONTRATISTA
        '    If strMenu = "3" Then

        '        If Me.ltvMenup.Items.Count > 0 Then

        '            For i = 0 To Me.ltvMenup.Items.Count - 1

        '                strCodCont = Me.ltvMenup.FocusedItem.Text
        '                strDescCont = Me.ltvMenup.FocusedItem.SubItems(1).Text

        '            Next

        '        End If

        '        f1.tbxCont.Text = strDescCont


        '        f1.tbxClient.Focus()
        '        Me.Close()

        '    End If

        '    'CONTRATISTA
        '    If strMenu = "8" Then

        '        If Me.ltvMenup.Items.Count > 0 Then

        '            For i = 0 To Me.ltvMenup.Items.Count - 1

        '                strCodCont = Me.ltvMenup.FocusedItem.Text
        '                strDescCont = Me.ltvMenup.FocusedItem.SubItems(1).Text

        '            Next

        '        End If

        '        'f15.tbxCont.Text = strDescCont


        '        'f15.tbxClient.Focus()
        '        Me.Close()

        '    End If

        '    'Cliente
        '    If strMenu = "4" Then

        '        If Me.ltvMenup.Items.Count > 0 Then

        '            For i = 0 To Me.ltvMenup.Items.Count - 1

        '                strCodCli = Me.ltvMenup.FocusedItem.Text
        '                strDescCli = Me.ltvMenup.FocusedItem.SubItems(1).Text

        '            Next

        '        End If

        '        f1.tbxClient.Text = strDescCli

        '        Me.Close()

        '    End If

        '    'Cliente
        '    If strMenu = "9" Then

        '        If Me.ltvMenup.Items.Count > 0 Then

        '            For i = 0 To Me.ltvMenup.Items.Count - 1

        '                strCodCli = Me.ltvMenup.FocusedItem.Text
        '                strDescCli = Me.ltvMenup.FocusedItem.SubItems(1).Text

        '            Next

        '        End If

        '        'f15.tbxClient.Text = strDescCli

        '        Me.Close()

        '    End If

        '    'formulario  Cliente 
        '    If strMenu = "5" Then

        '        If Me.ltvMenup.Items.Count > 0 Then

        '            For i = 0 To Me.ltvMenup.Items.Count - 1

        '                strCodCli = Me.ltvMenup.FocusedItem.Text
        '                strDescCli = Me.ltvMenup.FocusedItem.SubItems(1).Text

        '            Next

        '        End If
        '        f3.tbxCodCli.Text = strCodCli
        '        f3.tbxDescrCli.Text = strDescCli
        '        f3.ConsultasCliente()
        '        Me.Close()

        '    End If


        '    'formulario  Contratista 
        '    If strMenu = "6" Then

        '        If Me.ltvMenup.Items.Count > 0 Then

        '            For i = 0 To Me.ltvMenup.Items.Count - 1

        '                strCodCont = Me.ltvMenup.FocusedItem.Text
        '                strDescCont = Me.ltvMenup.FocusedItem.SubItems(1).Text

        '            Next

        '        End If
        '        f5.tbxCodCon.Text = strCodCont
        '        f5.tbxDescrCont.Text = strDescCont
        '        f5.ConsultasContratista()
        '        Me.Close()

        '    End If
        'Catch ex As Exception
        '    MsgBox("Error en Seleccion del Menu, funcion ltvMenup_Click" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        'End Try
        ''swMenuPpal = 0
    End Sub

   
  

    Private Sub ltvMenup_DoubleClick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ltvMenup.DoubleClick
        Dim i As Integer = 0

        Try

            If strMenu = "1" Then
                If Me.ltvMenup.Items.Count > 0 Then

                    For i = 0 To Me.ltvMenup.Items.Count - 1
                        If Me.ltvMenup.Items(i).Text = 6 Then
                            f1.Close()
                            Me.Close()
                        Else
                            ' strcodMenu = Me.ltvMenup.FocusedItem.Text


                            If strcodMenu = "1" Then

                                frmMenuProyectoIncluir.tbcProy.SelectedTab = frmMenuProyecto.tbcProy.TabPages(0)
                                Me.Close()
                                Exit For

                            End If

                            If strcodMenu = "2" Then

                                frmMenuProyectoIncluir.tbcProy.SelectedTab = frmMenuProyecto.tbcProy.TabPages(3)
                                Me.Close()
                                Exit For
                            End If


                            If strcodMenu = "3" Then

                                frmMenuProyectoIncluir.tbcProy.SelectedTab = frmMenuProyecto.tbcProy.TabPages(3)
                                Me.Close()
                                Exit For
                            End If


                            If strcodMenu = "4" Then

                                frmMenuProyecto.tbcProy.SelectedTab = frmMenuProyecto.tbcProy.TabPages(3)
                                Me.Close()
                                Exit For
                            End If

                            If strcodMenu = "5" Then

                                frmMenuProyecto.tbcProy.SelectedTab = frmMenuProyecto.tbcProy.TabPages(4)
                                Me.Close()
                                Exit For
                            End If
                        End If
                    Next
                End If
            End If

            'PROYECTO
            If strMenu = "2" Then

                If Me.ltvMenup.Items.Count > 0 Then

                    For i = 0 To Me.ltvMenup.Items.Count - 1

                        strCodProy = Me.ltvMenup.FocusedItem.Text
                        strDescProy = Me.ltvMenup.FocusedItem.SubItems(1).Text
                        stridProy = Me.ltvMenup.FocusedItem.SubItems(2).Text
                    Next

                End If

                If swMenuPpal = 0 Then
                    f1.lblid.Text = stridProy
                    f1.tbxCodp.Text = strCodProy
                    f1.tbxDescr.Text = strDescProy
                    ProyNro = f1.tbxCodp.Text
                End If

                If swMenuPpal = 2 Then
                    f7.lblid.Text = stridProy
                    f7.tbxCodp.Text = strCodProy
                    f7.tbxDescr.Text = strDescProy
                    ProyNro = f7.tbxCodp.Text

                    f7.lbltiproy.Text = strCodProy & " - " & strDescProy
                    ConsultarALLproyF7()
                    llenarNroctas()
                End If

                If swMenuPpal = 1 Then
                    'f15.lblid.Text = stridProy
                    'f15.tbxCodp.Text = strCodProy
                    'ProyNro = f15.tbxCodp.Text
                    'f15.tbxDescr.Text = strDescProy

                    f15.lbltiproy.Text = strCodProy & " - " & strDescProy
                    ConsultarALLproyF15()
                End If

                Me.Close()

            End If

            'CONTRATISTA
            If strMenu = "3" Then

                If Me.ltvMenup.Items.Count > 0 Then

                    For i = 0 To Me.ltvMenup.Items.Count - 1

                        strCodCont = Me.ltvMenup.FocusedItem.Text
                        strDescCont = Me.ltvMenup.FocusedItem.SubItems(1).Text

                    Next

                End If


                If swMenuPpal = 2 Then
                    f7.tbxCont1.Text = strCodCont
                    f7.lblcont1.Text = strDescCont

                    f7.tbxCliente.Focus()
                End If

                If swMenuPpal = 1 Then
                    f1.tbxCont.Text = strCodCont
                    f1.lblCont.Text = strDescCont

                    f1.tbxClient.Focus()
                End If





                Me.Close()

            End If

            'CONTRATISTA
            If strMenu = "8" Then

                If Me.ltvMenup.Items.Count > 0 Then

                    For i = 0 To Me.ltvMenup.Items.Count - 1

                        strCodCont = Me.ltvMenup.FocusedItem.Text
                        strDescCont = Me.ltvMenup.FocusedItem.SubItems(1).Text

                    Next

                End If

                If swMenuPpal = 2 Then
                    f7.tbxCont1.Text = strCodCont
                    f7.lblcont1.Text = strDescCont
                    f7.tbxCliente.Focus()
                End If

                If swMenuPpal = 1 Then
                    f1.tbxCont.Text = strCodCont
                    f1.lblCont.Text = strDescCont
                    f1.tbxClient.Focus()
                End If

                'f15.tbxCont.Text = strDescCont


                'f15.tbxClient.Focus()
                Me.Close()

            End If

            'Cliente
            If strMenu = "4" Then

                If Me.ltvMenup.Items.Count > 0 Then

                    For i = 0 To Me.ltvMenup.Items.Count - 1

                        strCodCli = Me.ltvMenup.FocusedItem.Text
                        strDescCli = Me.ltvMenup.FocusedItem.SubItems(1).Text

                    Next

                End If

                If swMenuPpal = 2 Then
                    f7.tbxCliente.Text = strCodCli
                    f7.lblclient1.Text = strDescCli

                End If

                If swMenuPpal = 1 Then
                    f1.tbxClient.Text = strCodCli
                    f1.lblClient.Text = strDescCli
                End If



                Me.Close()

            End If

            'Cliente
            If strMenu = "9" Then

                If Me.ltvMenup.Items.Count > 0 Then

                    For i = 0 To Me.ltvMenup.Items.Count - 1

                        strCodCli = Me.ltvMenup.FocusedItem.Text
                        strDescCli = Me.ltvMenup.FocusedItem.SubItems(1).Text

                    Next

                End If

                If swMenuPpal = 2 Then
                    f7.tbxCliente.Text = strDescCli

                End If

                If swMenuPpal = 1 Then
                    f1.tbxClient.Text = strDescCli

                End If



                Me.Close()

            End If

            'formulario  Cliente 
            If strMenu = "5" Then

                If Me.ltvMenup.Items.Count > 0 Then

                    For i = 0 To Me.ltvMenup.Items.Count - 1

                        strCodCli = Me.ltvMenup.FocusedItem.Text
                        strDescCli = Me.ltvMenup.FocusedItem.SubItems(1).Text

                    Next

                End If
                f3.tbxCodCli.Text = strCodCli
                f3.tbxDescrCli.Text = strDescCli
                f3.ConsultasCliente()
                Me.Close()

            End If


            'formulario  Contratista 
            If strMenu = "6" Then

                If Me.ltvMenup.Items.Count > 0 Then

                    For i = 0 To Me.ltvMenup.Items.Count - 1

                        strCodCont = Me.ltvMenup.FocusedItem.Text
                        strDescCont = Me.ltvMenup.FocusedItem.SubItems(1).Text

                    Next

                End If
                f5.tbxCodCon.Text = strCodCont
                f5.tbxDescrCont.Text = strDescCont
                f5.ConsultasContratista()
                f5.llenarContratistas()
                Me.Close()

            End If

            'parametros  Cliente 
            If strMenu = "10" Then

                If Me.ltvMenup.Items.Count > 0 Then

                    For i = 0 To Me.ltvMenup.Items.Count - 1

                        strCodCli = Me.ltvMenup.FocusedItem.Text
                        strDescCli = Me.ltvMenup.FocusedItem.SubItems(1).Text

                    Next

                End If
                frmcarteraT.tbxCodCli.Text = strDescCli

                'f3.ConsultasCliente()
                Me.Close()

            End If
        Catch ex As Exception
            MsgBox("Error en Seleccion del Menu, funcion ltvMenup_Click" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
        'swMenuPpal = 0
    End Sub
End Class
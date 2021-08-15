Public Class frmSubmenupInicio

    Private Sub frmSubmenup_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'f1.Close()
    End Sub

    Private Sub frmSubmenup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            swMen = 0
            ConexionSQL()
            Dim strSubmenu As New ADODB.Recordset
            Dim i As Integer = 0
            Dim j As Integer = 0
            Dim strpreg As String = ""
            Me.ltvMenup.Items.Clear()
           

            'lo llama el boton siguiente del Modulo de Proyecto
            If strMenu = "2" Then

                Me.Text = "SELECCIÓN DE PROYECTOS"

                If frmInicioproyectos.tbxBuscar.Text = "" Then
                    ProyNro = 0
                Else
                    ProyNro = frmInicioproyectos.tbxBuscar.Text
                End If

                If frmInicioproyectos.tbxBuscar.Text = "" Then

                    strSubmenu = cntSQL.Execute("SELECT  id_proyecto, Nro_proyecto, desc_Proyecto, HIST_proyecto FROM tab_idProyecto where  HIST_proyecto=1")
                Else

                    strSubmenu = cntSQL.Execute("SELECT id_proyecto, Nro_proyecto, desc_Proyecto, HIST_proyecto FROM tab_idProyecto where (Nro_proyecto like '%" & strCodbus & "%' or desc_Proyecto like '%" & strCodbus & "%') and ( HIST_proyecto=1)")
                End If

                Do While Not strSubmenu.EOF


                    Me.ltvMenup.Items.Add(strSubmenu.Fields("Nro_proyecto").Value)
                    Me.ltvMenup.Items(i).SubItems.Add(strSubmenu.Fields("desc_Proyecto").Value)
                    Me.ltvMenup.Items(i).SubItems.Add(strSubmenu.Fields("id_proyecto").Value)
                    i += 1
                    j += 1
                    strSubmenu.MoveNext()

                Loop


                'codigo para llamar al evento doble click del list view
                If j = 1 Then
                    'ltvMenup_DoubleClick(1, Nothing)

                End If

            End If



        Catch ex As Exception
            MsgBox("Error en funcion frmSubmenup_Load" & ex.Message, MsgBoxStyle.Exclamation, "Control Proyectos")
        End Try
    End Sub



   




    Private Sub ltvMenup_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ltvMenup.SelectedIndexChanged
      
        'If strMenu = "2" Then
        '    strCodProy = Me.ltvMenup.FocusedItem.Text
        '    f1.tbxDescr.Focus()
        'End If

        


    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
        'f1.Close()
    End Sub

    Private Sub ltvMenup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ltvMenup.Click
     
    End Sub


    Private Sub ltvMenup_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ltvMenup.DoubleClick
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




                            If strcodMenu = "2" Then

                                frmMenuProyecto.tbcProy.SelectedTab = frmMenuProyecto.tbcProy.TabPages(1)
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
                        ProyNro = Me.ltvMenup.FocusedItem.Text
                        strCodProy = Me.ltvMenup.FocusedItem.Text
                        strDescProy = Me.ltvMenup.FocusedItem.SubItems(1).Text
                        stridProy = Me.ltvMenup.FocusedItem.SubItems(2).Text
                    Next

                End If
                frmInicioproyectos.tbxBuscar.Text = strCodProy & " - " & strDescProy


                'If swMenuPpal = 0 Then
                '    f1.lblid.Text = stridProy
                '    f1.tbxCodp.Text = strCodProy
                '    f1.tbxDescr.Text = strDescProy
                '    ProyNro = f1.tbxCodp.Text
                'End If

                'If swMenuPpal = 2 Then
                '    f7.lblid.Text = stridProy
                '    f7.tbxCodp.Text = strCodProy
                '    f7.tbxDescr.Text = strDescProy
                '    ProyNro = f7.tbxCodp.Text
                '    f7.Label4.Text = strCodProy
                '    f7.Label5.Text = strDescProy
                '    ConsultarALLproyF7()
                'End If

                'If swMenuPpal = 1 Then
                '    f15.lblid.Text = stridProy
                '    f15.tbxCodp.Text = strCodProy
                '    ProyNro = f15.tbxCodp.Text
                '    f15.tbxDescr.Text = strDescProy
                '    f15.Label4.Text = strCodProy
                '    f15.Label5.Text = strDescProy
                '    ' f15.Label6.Text = strCodProy
                '    ConsultarALLproyF15()
                'End If

                Me.Close()

            End If


        Catch ex As Exception
            MsgBox("Error en Seleccion del Menu, funcion ltvMenup_Click" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try

    End Sub
End Class
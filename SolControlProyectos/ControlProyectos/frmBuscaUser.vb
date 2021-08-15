Public Class frmBuscaUser

    Private Sub frmBuscaUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        buscaUser()

    End Sub

    Sub buscaUser()
        Try
            ConexionSQL()
            Dim strUser As ADODB.Recordset
            Dim i As Integer = 0

            If Usuario <> "" Then
                strUser = cntSQL.Execute("SELECT  [dni] ,[nombre] ,[apellido] ,[nivel],[clave],[activo],bloq FROM [UsuariosProyecto] where dni like '%" & Usuario & "%' or nombre like '%" & Usuario & "%' ")
            Else
                strUser = cntSQL.Execute("SELECT [dni] ,[nombre] ,[apellido] ,[nivel],[clave],[activo],bloq  FROM [UsuariosProyecto]")
            End If
            ltvUser.Items.Clear()

            If strUser.EOF = True Then
                frmUsuarios.txtName.Focus()
                Me.Close()
            Else
                Do While Not strUser.EOF
                    ltvUser.Items.Add(strUser.Fields(0).Value)
                    ltvUser.Items(i).SubItems.Add(strUser.Fields(1).Value)
                    ltvUser.Items(i).SubItems.Add(strUser.Fields(2).Value)
                    ltvUser.Items(i).SubItems.Add(strUser.Fields(3).Value)
                    ltvUser.Items(i).SubItems.Add(strUser.Fields(4).Value)
                    ltvUser.Items(i).SubItems.Add(strUser.Fields(5).Value)
                    ltvUser.Items(i).SubItems.Add(strUser.Fields(6).Value)
                    i += 1
                    strUser.MoveNext()
                Loop
            End If

         



        Catch ex As Exception
            MsgBox("error en funcion buscaUser()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub

    

    Private Sub ltvUser_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ltvUser.DoubleClick
        If Me.ltvUser.Items.Count > 0 Then

            For i = 0 To Me.ltvUser.Items.Count - 1
                If Me.ltvUser.FocusedItem.SubItems(0).Text <> "" Then

                    If swUser = 1 Then

                        frmUsuarios.txtCed.Text = Me.ltvUser.FocusedItem.SubItems(0).Text
                        frmUsuarios.txtName.Text = Me.ltvUser.FocusedItem.SubItems(1).Text
                        frmUsuarios.txtApe.Text = Me.ltvUser.FocusedItem.SubItems(2).Text
                        frmUsuarios.cmbNiv.SelectedIndex = Me.ltvUser.FocusedItem.SubItems(3).Text
                        frmUsuarios.txtClave.Text = Me.ltvUser.FocusedItem.SubItems(4).Text
                        frmUsuarios.txtReClave.Text = Me.ltvUser.FocusedItem.SubItems(4).Text
                        frmUsuarios.cmbAct.SelectedIndex = Me.ltvUser.FocusedItem.SubItems(5).Text
                        frmUsuarios.chkbloq.Checked = IIf(Me.ltvUser.FocusedItem.SubItems(6).Text = 1, True, False)

                    End If

                    If swUser = 2 Then

                        frmpermisos.tbxdni.Text = Me.ltvUser.FocusedItem.SubItems(0).Text
                        frmpermisos.lblNombre.Text = Me.ltvUser.FocusedItem.SubItems(1).Text

                    End If
                   
                    Exit For
                End If
            Next

        End If
        swUser = 0
        Me.Close()
    End Sub
End Class
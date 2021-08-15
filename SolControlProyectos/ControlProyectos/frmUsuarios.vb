Public Class frmUsuarios

    Public intvalcedula As Integer = 0
    Public strNivel As Integer = 0
    Public userced As String = ""
    Public userclave As String = ""


    Private Sub txtCed_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCed.KeyPress

        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            btnBuscar_Click(Nothing, Nothing)
        End If


       


        'If strNivel = 1 Then
        '    If e.KeyChar = Convert.ToChar(Keys.Return) Then

        '        If lblTitulo.Text = "Agregar/Consultar" Then



        '            Validar_cedula()

        '            If intvalcedula = 0 Then
        '                Me.txtName.Focus()
        '                preg = MsgBox("Usuario no existe, desea crearlo?", MsgBoxStyle.YesNo)



        '                If preg = 6 Then
        '                    swuser = 1
        '                Else
        '                    Me.Close()
        '                    swuser = 0
        '                End If
        '            Else


        '                Modificar_User()
        '                Me.txtName.Focus()

        '            End If

        '        End If


        '        If lblTitulo.Text = "Eliminar" Then

        '            If txtCed.Text <> "" Then

        '                Validar_cedula()

        '                If intvalcedula = 1 Then

        '                    Modificar_User()
        '                    Me.txtName.Focus()
        '                    preg = MsgBox("seguro que desea eliminar al Usuario?", MsgBoxStyle.YesNo)

        '                    If preg = 6 Then
        '                        swuser = 2
        '                    Else
        '                        Me.Close()
        '                        swuser = 0
        '                    End If

        '                End If


        '            End If

        '        End If
        '    End If
        'Else
        '    MsgBox("Acceso Denegado, no tiene permisos para modificar usuarios", MsgBoxStyle.Information, "Control Proyectos")
        '    Me.Close()
        'End If

    End Sub

    Private Sub txtName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtName.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            e.Handled = True

            Me.txtApe.Focus()


        End If
    End Sub

    Private Sub txtApe_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApe.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            e.Handled = True

            Me.cmbNiv.Focus()


        End If
    End Sub

    Private Sub cmbNiv_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbNiv.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            e.Handled = True

            Me.txtClave.Focus()


        End If
    End Sub

   

   

    Private Sub cmbAcc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            e.Handled = True




        End If
    End Sub
   

   
    Sub Validar_cedula()
        Dim strvalced As New ADODB.Recordset
        Try
            intvalcedula = 0
            strvalced = cntSQL.Execute("select dni, nivel, clave from UsuariosProyecto where cedula='" & Me.txtCed.Text & "'")
            Do While Not strvalced.EOF = True
                intvalcedula = 1
                userced = strvalced.Fields(1).Value
                userclave = strvalced.Fields(2).Value
                Exit Do
            Loop

            strvalced.Close()
        Catch ex As Exception
            MsgBox("error en funcion Validar_cedula()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub
   
    Sub Insertar_User()
        Try
            ConexionSQL()
            Dim ced As Integer = 0
            Dim strInsertced As New ADODB.Recordset
            Dim strSelecced As New ADODB.Recordset
            'revisa que no exista el usuario
            strSelecced = cntSQL.Execute("select * from UsuariosProyecto where dni='" & Me.txtCed.Text & "'")
            If strSelecced.EOF = True Then
                ced = 1
            End If

            If ced = 0 Then
                modifica_User()
            End If

            If ced = 1 Then
                cntSQL.Execute("insert into UsuariosProyecto (dni, nombre, apellido, nivel, clave, fecha, activo, bloq) values ('" & Me.txtCed.Text & "','" & Me.txtName.Text & "', '" & Me.txtApe.Text & "', '" & Me.cmbNiv.Text & "', '" & Me.txtClave.Text & "','" & Format(Date.Now, "yyyyMMdd") & "'," & Me.cmbAct.Text & "," & intbloq & " )")
                creaMenuUser()
                MsgBox("Usuario Creado", MsgBoxStyle.Information)
               
            End If

        Catch ex As Exception

            MsgBox("error en funcion Insertar_User()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")

        End Try
       
    End Sub
    Sub creaMenuUser()
        Try
            Dim i As Integer = 0
            Dim strMenu As ADODB.Recordset
            ConexionSQL()

            strMenu = cntSQL.Execute("select usuario, menuForm, activo from tab_proPermisoform where usuario= '" & Me.txtCed.Text & "'")

            If strMenu.EOF = True Then
                For i = 1 To 35
                    If i = 16 Then
                        cntSQL.Execute("insert into tab_proPermisoform (usuario, menuForm, activo) values ('" & Me.txtCed.Text & "'," & i & ",1 )")

                    Else
                        cntSQL.Execute("insert into tab_proPermisoform (usuario, menuForm, activo) values ('" & Me.txtCed.Text & "'," & i & ",0 )")

                    End If

                Next

            End If
          
        Catch ex As Exception
            MsgBox("error en funcion creaMenuUser()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")

        End Try
    End Sub
    Sub Delete_User()
        Try
            ConexionSQL()
            Dim preg As String = ""
            preg = MsgBox("Seguro que desea eliminar el usuario " & Me.txtCed.Text, MsgBoxStyle.YesNo, "Control Proyectos")

            If preg = 6 Then

                cntSQL.Execute("delete from UsuariosProyecto where dni='" & Me.txtCed.Text & "'")
                MsgBox("Usuario Eliminado", MsgBoxStyle.Information, "Control Proyectos")
                limpiaformUser()
            End If
        Catch ex As Exception
            MsgBox("error en funcion Delete_User()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub
    Sub Modificar_User()
        Dim strModed As New ADODB.Recordset
        strModed = cntSQL.Execute("select * from UsuariosProyecto where cedula='" & Me.txtCed.Text & "'")

        Try
            Do While Not strModed.EOF

                Me.txtName.Text = strModed.Fields(1).Value
                Me.txtApe.Text = strModed.Fields(2).Value
                Me.txtClave.Text = strModed.Fields(4).Value
                Me.txtReClave.Text = strModed.Fields(4).Value
                Me.cmbNiv.Text = strModed.Fields(3).Value
                

                strModed.MoveNext()
            Loop
            strModed.Close()
            strModed = Nothing


        Catch ex As Exception
            MsgBox("Error al buscar Usuario Modificar_User()" & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

   
    Private Sub btnCanc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub txtClave_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtClave.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            e.Handled = True

            Me.txtReClave.Focus()


        End If
    End Sub

    

    Private Sub ToolStripButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton12.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        limpiaformUser()
        ToolStripButton3.Enabled = False
        ToolStripButton4.Enabled = False
        ToolStripButton2.Enabled = False
        txtCed.Focus()
    End Sub
    Sub limpiaformUser()
        Me.txtCed.Text = ""
        Me.txtName.Text = ""
        Me.txtClave.Text = ""
        Me.txtReClave.Text = ""
        Me.txtApe.Text = ""
        Me.cmbAct.Text = "Seleccione"
        Me.cmbNiv.Text = "Seleccione"
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click

        If cmbAct.Text <> "Seleccione" And cmbNiv.Text <> "Seleccione" Then

            If txtName.Text <> "" And txtCed.Text <> "" Then


                If Me.txtClave.Text = Me.txtReClave.Text Then

                    Insertar_User()
                    swuser = 0


                    Me.txtName.Focus()
                    limpiaformUser()
                    Me.Close()

                Else

                    MsgBox("claves incorrectas", MsgBoxStyle.Information, "Control Proyectos")

                    txtClave.Focus()
                End If

            End If
        Else
            MsgBox("Debe seleccionar el nivel y el status", MsgBoxStyle.Information, "Control Proyectos")

        End If
        ToolStripButton3.Enabled = True
        ToolStripButton4.Enabled = True
        ToolStripButton2.Enabled = True

    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Try
            If Me.txtCed.Text <> "" Then
                swuser = 0
                Delete_User()
                Me.Close()
            Else
                MsgBox("Debe seleccionar un usuario", MsgBoxStyle.Critical, "Control Proyectos")
            End If

        Catch ex As Exception
            MsgBox("Error en funcion eliminar" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub

 
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Usuario = Me.txtCed.Text
        swUser = 1
        frmBuscaUser.ShowDialog()
        Usuario = ""
    End Sub

    Private Sub cmbNiv_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbNiv.SelectedIndexChanged
        Me.txtClave.Focus()
    End Sub

    Private Sub txtReClave_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtReClave.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            e.Handled = True

            Me.cmbAct.Focus()


        End If
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        modifica_User()

    End Sub
    Sub modifica_User()
        Try
            Dim ced As Integer = 0
            Dim strInsertced As New ADODB.Recordset
            Dim strSelecced As New ADODB.Recordset
            'revisa que no exista el usuario
            strSelecced = cntSQL.Execute("select * from UsuariosProyecto where dni='" & Me.txtCed.Text & "'")

            If strSelecced.EOF = True Then
                ced = 1

            End If

            If Me.cmbAct.SelectedText <> "Seleccione" Or Me.cmbNiv.SelectedText <> "Seleccione" Then
                If ced = 0 Then
                    strInsertced = cntSQL.Execute("update UsuariosProyecto set  nombre='" & Me.txtName.Text & "', apellido='" & Me.txtApe.Text & "', nivel='" & Me.cmbNiv.Text & "', clave='" & Me.txtClave.Text & "', fecha='" & Format(Date.Now, "yyyyMMdd") & "', activo=" & Me.cmbAct.Text & ", bloq=" & intbloq & "  where dni='" & Me.txtCed.Text & "'")

                    MsgBox("Usuario Actualizado", MsgBoxStyle.Information, "Control Proyectos")
                    Me.Close()
                End If
            Else

                MsgBox("Debe seleccionar los combos Nivel/Act del usuario", MsgBoxStyle.Information, "Control Proyectos")

            End If

        Catch ex As Exception

            MsgBox("error en funcion Insertar_User()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")

        End Try
        limpiaformUser()
    End Sub

    Private Sub frmUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DtSp.DataTable1' Puede moverla o quitarla según sea necesario.
        Me.DataTable1TableAdapter.Fill(Me.DtSp.DataTable1)

    End Sub

    Private Sub chkbloq_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkbloq.CheckedChanged
        If Me.chkbloq.Checked = True Then
            intbloq = 0

        Else
            intbloq = 1
        End If
    End Sub
End Class

Public Class frmLoginPass
    Public intsuiche As Integer = 0
    Public bloq As Integer = 0
    Public intpassnew As Integer = 0


    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        Conectar_User()

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click

        Application.ExitThread()
       
    End Sub
    Sub Conectar_User()
        Dim swPpal As Integer = 0
        Dim strvalidauser As New ADODB.Recordset


        ConexionSQL()
        Try
            strvalidauser = cntSQL.Execute("select nivel,dni,activo,bloq  from  UsuariosProyecto where dni= '" & Me.tbxUser.Text & "' and clave= '" & Me.PasswordTextBox.Text & "'")

            If strvalidauser.EOF = False Then

                StrNivel = strvalidauser.Fields("nivel").Value
                UserLogin = strvalidauser.Fields("dni").Value
                bloq = strvalidauser.Fields("activo").Value
                intbloq = strvalidauser.Fields("bloq").Value


                If intbloq = 0 Then

                    If bloq = 1 Then
                        frmExplorer.Show()
                        Me.Hide()
                        Exit Sub
                    Else
                        MsgBox("Usuario Inactivo, consulte con el Administrador del Sistema", MsgBoxStyle.Exclamation, "Control Proyectos")

                        Application.ExitThread()
                    End If

                Else
                    MsgBox("Usuario Bloqueado, consulte con el Administrador del Sistema", MsgBoxStyle.Exclamation, "Control Proyectos")

                    Application.ExitThread()
                End If


            Else

                MsgBox("Usuario o Clave Inválida, por favor Verifique", MsgBoxStyle.Information, "Control Proyectos")
                PasswordTextBox.Text = ""


            End If

                strvalidauser.Close()
                strvalidauser = Nothing

        Catch ex As Exception

            MsgBox("Error en funcion validar Conectar_User()" & ex.Message, MsgBoxStyle.Information, "Control Proyectos")
           
        End Try
      

    End Sub

  
   
    Private Function NumericKey(ByVal KCode As Int16) As Boolean

        If (KCode >= 48 And KCode <= 57) Or KCode = 8 Then
            Return False
        Else
            Return True
        End If

    End Function

  
  
    Private Sub tbxUser_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxUser.KeyPress
   
        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            PasswordTextBox.Focus()


        End If
    End Sub

    Private Sub PasswordTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PasswordTextBox.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            OK.Focus()


        End If
    End Sub
End Class
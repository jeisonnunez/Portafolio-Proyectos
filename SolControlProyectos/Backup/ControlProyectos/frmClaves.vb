Public Class frmClaves


    Private Sub btnAcp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAcp.Click

        Validar_cedulaclave()
        Dim strvalced As New ADODB.Recordset

        If Me.txAct.Text = userclave Then

            If Me.txtNew.Text = Me.txtRpNew.Text Then

                Try
                    ConexionSQL()
                    cntSQL.Execute("update UsuariosProyecto set clave = '" & Me.txtNew.Text & "'where dni='" & UserLogin & "'")
                    MsgBox("cambio de clave exitoso", MsgBoxStyle.Information, "Control Proyectos")
                    Me.Close()

                Catch ex As Exception
                    MsgBox("error en funcion btnAcp_Click, cambio de claves", MsgBoxStyle.Critical, "Control Proyectos")
                End Try

            Else
                MsgBox("claves incorrectas, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
                Me.txtNew.Focus()
                Me.txtRpNew.Text = ""
            End If
        Else
            MsgBox("clave anterior errada, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.txAct.Focus()


        End If

    End Sub

    Private Sub frmClaves_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
     

    End Sub

    Private Sub btnCanc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCanc.Click
        Me.Close()
    End Sub
    Sub Validar_cedulaclave()
        ConexionSQL()
        Dim strvalced As New ADODB.Recordset
        Try

            strvalced = cntSQL.Execute("select dni, nivel, clave from UsuariosProyecto where dni='" & UserLogin & "'")
            Do While Not strvalced.EOF = True

                userclave = strvalced.Fields(2).Value
                Exit Do
            Loop

            strvalced.Close()
        Catch ex As Exception
            MsgBox("error en funcion Validar_cedula()", MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub

    Private Sub txAct_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txAct.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            e.Handled = True

            Me.txtNew.Focus()


        End If
    End Sub

    Private Sub txtNew_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNew.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            e.Handled = True

            Me.txtRpNew.Focus()


        End If
    End Sub

    Private Sub txtRpNew_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRpNew.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            e.Handled = True

            Me.btnAcp.Focus()
        End If
    End Sub
End Class
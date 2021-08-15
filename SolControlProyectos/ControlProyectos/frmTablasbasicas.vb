Public Class frmTablasbasicas

    Private Sub tbxDato_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxDato.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            e.Handled = True
            Me.tbxDato.Focus()

        End If
    End Sub

    Private Sub btnAcept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAcept.Click
        Try

            If modTb = 0 Then

                Dim campo As String = ""
                If Me.tbxDato.Text <> "" Then


                    ConexionSQL()
                    Dim strTB As New ADODB.Recordset

                    strTB = cntSQL.Execute("select * from tab_Sistemas where tablareal ='" & tabla & "'")

                    If strTB.EOF = False Then
                        campo = strTB.Fields("descripTabla").Value

                    End If

                    strTB = cntSQL.Execute("select * from " & tabla & " where " & campo & " ='" & Me.tbxDato.Text & "'")

                    If strTB.EOF = False Then
                        MsgBox("El valor se encuentra registrado, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")

                    Else

                        cntSQL.Execute("insert into " & tabla & "(" & campo & ")values('" & Me.tbxDato.Text & "')")

                    End If

                Else
                    MsgBox("Debe insertar un valor", MsgBoxStyle.Critical, "Control Proyectos")
                End If
                '  ConexionSQL()
                '  cntSQL.Execute("p_Ordenacionidices")
                MsgBox("Registro insertado", MsgBoxStyle.Information, "Control Proyectos")

            Else
                Dim campo As String = ""
                If Me.tbxDato.Text <> "" Then
                    ConexionSQL()
                    Dim strTB As New ADODB.Recordset

                    strTB = cntSQL.Execute("select * from tab_Sistemas where tablareal ='" & tabla & "'")

                    If strTB.EOF = False Then
                        campo = strTB.Fields("descripTabla").Value

                    End If

                    strTB = cntSQL.Execute("select * from " & tabla & " where " & campo & " ='" & descr & "'")

                    If strTB.EOF = False Then

                        cntSQL.Execute("UPDATE " & tabla & " SET " & campo & "='" & Me.tbxDato.Text & "' WHERE " & campo & "='" & descr & "' ")

                    End If


                Else
                    MsgBox("Debe insertar un valor", MsgBoxStyle.Critical, "Control Proyectos")
                End If
                MsgBox("Registro Modificado", MsgBoxStyle.Information, "Control Proyectos")


            End If
        Catch ex As Exception
            MsgBox("Error al insertar dato tabbasicas" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")

        End Try
        frm_manttbBasiscas.llenardatos()
        Me.Close()
    End Sub

    Private Sub btnCanc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCanc.Click
        Me.Close()
    End Sub

    Private Sub frmTablasbasicas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If modTb = 0 Then
            Me.tbxDato.Text = ""
        End If

        
    End Sub
End Class
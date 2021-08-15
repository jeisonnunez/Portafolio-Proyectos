Public Class frmInputRec

    Private Sub btnCanc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCanc.Click
        Me.Close()
        swInput = 1
    End Sub

    Private Sub btnAcept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAcept.Click

        If Me.tbxDato.Text <> "" Then

            RecNro = Me.tbxDato.Text
            Rec = Me.tbxDato.Text


            lblTitulo.Text = "Ingrese Nro de Recibo a la FACTURA: " & FactNro

            If FactNro <> "" Then

                If swMenuPpal = 0 Then
                    f1.tbxNroReci.Text = RecNro
                End If

                If swMenuPpal = 1 Then
                    f15.tbxNroReci.Text = RecNro

                End If
                If swMenuPpal = 2 Then
                    '  f7.tbxNroReci.Text = RecNro
                End If

                Me.Close()
            Else
                MsgBox("Debe Insertar un Valor", MsgBoxStyle.Exclamation, "Gestion de Proyectos")
            End If
        Else

            Dim preg As String = ""

            preg = MsgBox("El nro de Recibo se actualizara en blanco", MsgBoxStyle.YesNo, "Gestion de Proyectos")

            If preg = 6 Then

                RecNro = Me.tbxDato.Text
                Rec = Me.tbxDato.Text


                lblTitulo.Text = "Ingrese Nro de Recibo a la FACTURA: " & FactNro

                If FactNro <> "" Then

                    If swMenuPpal = 0 Then
                        f1.tbxNroReci.Text = RecNro
                    End If

                    If swMenuPpal = 1 Then
                        f15.tbxNroReci.Text = RecNro

                    End If
                    If swMenuPpal = 2 Then
                        ' f7.tbxNroReci.Text = RecNro
                    End If

                    Me.Close()

                End If

                ' MsgBox("Debe poseer una factura", MsgBoxStyle.Exclamation, "Gestion de Proyectos")
            End If

        End If
    End Sub

    Private Sub frmInputRec_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        swInput = 0

        lblTitulo.Text = "Ingrese Nro de Recibo a la FACTURA: " & FactNro

        Me.tbxDato.Text = ""
        Me.tbxDato.Focus()
    End Sub
End Class
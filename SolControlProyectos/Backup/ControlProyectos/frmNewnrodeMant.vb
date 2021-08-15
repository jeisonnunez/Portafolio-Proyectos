Public Class frmNewnrodeMant

    Private Sub btnAcept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAcept.Click
        Try
            If modTb = 0 Then
                ConexionSQL()
                Dim strDproyMant As New ADODB.Recordset
                'actualiza los datos
                If Me.tbxDato.Text <> "" Then
                    strDproyMant = cntSQL.Execute("select * from pro_Aux_MantProy where pro_idProyecto='" & stridProy & "' and pro_NroProyecto='" & strCodProy & "' and pro_NroMant='" & Me.tbxDato.Text & "'")

                    If strDproyMant.EOF = True Then
                        f2.tbxNroMant.Text = Me.tbxDato.Text
                        clearMant()
                        Me.Close()
                        frmNromantproy.Close()
                    Else
                        MsgBox("Nro de mantenimiento ya se encuentra registrado", MsgBoxStyle.Critical, "Control Proyectos")

                    End If
                Else
                    MsgBox("Debe insertar un valor", MsgBoxStyle.Critical, "Control Proyectos")
                End If

            End If

            If modTb = 1 Then
                ConexionSQL()
                Dim strDproyMant As New ADODB.Recordset
                'actualiza los datos
                If Me.tbxDato.Text <> "" Then
                    strDproyMant = cntSQL.Execute("select * from pro_Aux_MantProy where pro_idProyecto='" & stridProy & "' and pro_NroProyecto='" & strCodProy & "' and pro_NroMant='" & strNromant & "'")

                    If strDproyMant.EOF = False Then

                        cntSQL.Execute("update pro_Aux_MantProy set pro_NroMant='" & Me.tbxDato.Text & "' where pro_idProyecto='" & stridProy & "' and pro_NroProyecto='" & strCodProy & "' and pro_NroMant='" & strNromant & "'")
                        MsgBox("Nro de mantenimiento actualizado", MsgBoxStyle.Information, "Control Proyectos")
                    End If
                Else
                    MsgBox("Debe insertar un valor", MsgBoxStyle.Critical, "Control Proyectos")
                End If

            End If


            frmNromantproy.llenar()
            Me.Close()
        Catch ex As Exception
            MsgBox("Error en funcion btnAcept" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")

        End Try
    End Sub
    Sub clearMant()

        f2.dtpFechai.Value = Date.Now
        f2.dtpFecTer.Value = Date.Now
        f2.tbxMtoCb.Text = ""
        f2.tbxPxC.Text = ""
        f2.txtResp.Text = ""
        f2.txtMontTri.Text = ""
        f2.txtPercta.Text = ""
        f2.txtCp.Text = ""
        f2.tbxUbi.Text = ""

    End Sub

    Private Sub btnCanc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCanc.Click
        Me.Close()
    End Sub

    Private Sub frmNewnrodeMant_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If modTb = 0 Then
            Me.tbxDato.Text = ""
        End If

    End Sub
End Class
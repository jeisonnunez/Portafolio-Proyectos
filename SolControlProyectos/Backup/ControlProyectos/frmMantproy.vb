Public Class frmMantproy

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

  
    Sub consultaMantproy()
        Try
            ConexionSQL()
            Dim strDproyMant As New ADODB.Recordset
            Dim cantRg As Integer = 0

            strDproyMant = cntSQL.Execute("select  * from pro_Aux_MantProy where pro_idProyecto='" & stridProy & "' and pro_NroProyecto='" & strCodProy & "'")

            If strDproyMant.EOF = True Then

                strDproyMant = cntSQL.Execute("select  * from tab_DatosPpalProy where pro_idProyecto='" & stridProy & "' and pro_nroProyecto='" & strCodProy & "'")


                Do While Not strDproyMant.EOF

                    f2.tbxCodp.Text = strDproyMant.Fields("pro_nroProyecto").Value
                    f2.tbxDescr.Text = strDproyMant.Fields("pro_descripcion").Value
             

                    Exit Do
                    strDproyMant.MoveNext()
                Loop

                Me.Close()
            Else
                strDproyMant = cntSQL.Execute("select  count(*) from pro_Aux_MantProy where pro_idProyecto='" & stridProy & "' and pro_NroProyecto='" & strCodProy & "'")

                Do While Not strDproyMant.EOF
                    cantRg += 1
                    strDproyMant.MoveNext()
                Loop


                If cantRg > 1 Then

                    Do While Not strDproyMant.EOF

                        f2.tbxCodp.Text = strCodProy
                        f2.tbxDescr.Text = strDescProy

                        Exit Do
                        strDproyMant.MoveNext()
                    Loop

                Else
                    strDproyMant = cntSQL.Execute("select  * from pro_Aux_MantProy where pro_idProyecto='" & stridProy & "' and pro_NroProyecto='" & strCodProy & "'")

                    Do While Not strDproyMant.EOF

                        f2.tbxCodp.Text = strDproyMant.Fields("pro_NroProyecto").Value
                        f2.tbxDescr.Text = strDescProy
                        f2.tbxNroMant.Text = strDproyMant.Fields("pro_NroMant").Value
                        f2.dtpFechai.Value = strDproyMant.Fields("pro_FechaIni").Value
                        f2.dtpFecTer.Value = strDproyMant.Fields("pro_FechaTerm").Value 'decimales(Math.Round(strDproyMant.Fields("pro_trabajoFac").Value, 2))
                        ' f2.tbxUbi.Text = 'strDproyMant.Fields("pro_Rete10").Value

                        f2.tbxMtoCb.Text = decimales(Math.Round(strDproyMant.Fields("pro_MontoCobradoa").Value, 2))
                        f2.tbxPxC.Text = decimales(Math.Round(strDproyMant.Fields("pro_PendientexCobrar").Value, 2))
                        f2.txtResp.Text = strDproyMant.Fields("pro_Responsable").Value
                        f2.txtMontTri.Text = decimales(Math.Round(strDproyMant.Fields("pro_MontosTrimestrales").Value, 2))
                        f2.txtPercta.Text = strDproyMant.Fields("pro_CtasTransito").Value 'decimales(Math.Round(strDproyMant.Fields("pro_CtasTransito").Value, 2))
                        f2.txtCp.Text = strDproyMant.Fields("pro_CtasPagadas").Value 'decimales(Math.Round(strDproyMant.Fields("pro_CtasPagadas").Value, 2))


                        Exit Do
                        strDproyMant.MoveNext()
                    Loop

                End If
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Error en funcion consultaMantproy" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub

    Private Sub frmMantproy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            swMen = 0
            ConexionSQL()
            Dim strSubmenu As New ADODB.Recordset
            Dim i As Integer = 0
            Dim strpreg As String = ""
            Me.ltvMenup.Items.Clear()
            Me.ltvMenup.Refresh()
            

            If f2.tbxCodp.Text = "" Then

                strSubmenu = cntSQL.Execute("SELECT  id_proyecto, Nro_proyecto, desc_Proyecto, HIST_proyecto FROM tab_idProyecto where id_proyecto>1 and HIST_proyecto=1")
            Else

                strSubmenu = cntSQL.Execute("SELECT id_proyecto, Nro_proyecto, desc_Proyecto, HIST_proyecto FROM tab_idProyecto where Nro_proyecto like '%" & strCodbus & "%' or desc_Proyecto like '%" & strCodbus & "%' and id_proyecto>1 and HIST_proyecto=1")
            End If

            Do While Not strSubmenu.EOF


                Me.ltvMenup.Items.Add(strSubmenu.Fields("Nro_proyecto").Value)
                Me.ltvMenup.Items(i).SubItems.Add(strSubmenu.Fields("desc_Proyecto").Value)
                Me.ltvMenup.Items(i).SubItems.Add(strSubmenu.Fields("id_proyecto").Value)
                i += 1

                strSubmenu.MoveNext()

            Loop
        Catch ex As Exception
            MsgBox("Error en funcion frmMantproy_Load" & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub ltvMenup_DoubleClick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ltvMenup.DoubleClick
        If Me.ltvMenup.Items.Count > 0 Then

            For i = 0 To Me.ltvMenup.Items.Count - 1

                If Me.ltvMenup.Items(i).Selected = True Then
                    strCodProy = Me.ltvMenup.FocusedItem.Text
                    strDescProy = Me.ltvMenup.FocusedItem.SubItems(1).Text
                    stridProy = Me.ltvMenup.FocusedItem.SubItems(2).Text
                End If
            Next

        End If

        consultaMantproy()
    End Sub
End Class
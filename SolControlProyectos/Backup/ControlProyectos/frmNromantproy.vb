Public Class frmNromantproy

    Private Sub frmNromantproy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenar()
    End Sub

    Private Sub ltvMenup_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ltvMenup.DoubleClick
        If Me.ltvMenup.Items.Count > 0 Then

            For i = 0 To Me.ltvMenup.Items.Count - 1

                If Me.ltvMenup.Items(i).Selected = True Then
                    strNromant = Me.ltvMenup.FocusedItem.Text
                    strCodProy = Me.ltvMenup.FocusedItem.SubItems(1).Text
                    stridProy = Me.ltvMenup.FocusedItem.SubItems(2).Text
                End If
            Next

        End If
        consultaNromantproy()

    End Sub

    Sub llenar()
        Try

            ConexionSQL()
            Dim strSubmenu As New ADODB.Recordset
            Dim i As Integer = 0
            Dim strpreg As String = ""
            Me.ltvMenup.Items.Clear()
            Me.ltvMenup.Refresh()




            strSubmenu = cntSQL.Execute("SELECT  [pro_NroMant], [pro_NroProyecto],[pro_idProyecto] FROM pro_Aux_MantProy where [pro_idProyecto]='" & stridProy & "' and [pro_NroProyecto]='" & strCodProy & "' ")


            Do While Not strSubmenu.EOF


                Me.ltvMenup.Items.Add(strSubmenu.Fields("pro_NroMant").Value)
                Me.ltvMenup.Items(i).SubItems.Add(strSubmenu.Fields("pro_NroProyecto").Value)
                Me.ltvMenup.Items(i).SubItems.Add(strSubmenu.Fields("pro_idProyecto").Value)
                i += 1

                strSubmenu.MoveNext()

            Loop
        Catch ex As Exception
            MsgBox("Error en funcion frmMantproy_Load" & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
    Sub consultaNromantproy()
        Try
            ConexionSQL()
            Dim strDproyMant As New ADODB.Recordset

            f2.clearMant()
            strDproyMant = cntSQL.Execute("select  * from pro_Aux_MantProy where pro_idProyecto='" & stridProy & "' and pro_NroProyecto='" & strCodProy & "' and pro_NroMant='" & strNromant & "'")

            Do While Not strDproyMant.EOF

               
                f2.tbxNroMant.Text = strDproyMant.Fields("pro_NroMant").Value
                f2.dtpFechai.Value = strDproyMant.Fields("pro_FechaIni").Value
                f2.dtpFecTer.Value = strDproyMant.Fields("pro_FechaTerm").Value 'decimales(Math.Round(strDproyMant.Fields("pro_trabajoFac").Value, 2))
                f2.tbxMtoCb.Text = decimales(Math.Round(strDproyMant.Fields("pro_MontoCobradoa").Value, 2))
                f2.tbxUbi.Text = decimales(Math.Round(strDproyMant.Fields("pro_MontoContrsinITBMS").Value, 2))
                f2.tbxPxC.Text = decimales(Math.Round(strDproyMant.Fields("pro_PendientexCobrar").Value, 2))
                f2.txtResp.Text = strDproyMant.Fields("pro_Responsable").Value
                f2.txtMontTri.Text = decimales(Math.Round(strDproyMant.Fields("pro_MontosTrimestrales").Value, 2))
                f2.txtPercta.Text = strDproyMant.Fields("pro_CtasTransito").Value 'decimales(Math.Round(strDproyMant.Fields("pro_CtasTransito").Value, 2))
                f2.txtCp.Text = strDproyMant.Fields("pro_CtasPagadas").Value 'decimales(Math.Round(strDproyMant.Fields("pro_CtasPagadas").Value, 2))


                Exit Do
                strDproyMant.MoveNext()
            Loop
            Me.Close()

        Catch ex As Exception
            MsgBox("Error en funcion consultaMantproy" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub

    Private Sub ltvMenup_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ltvMenup.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ltvMenup.ContextMenuStrip = ContextMenuStrip1
        Else
            ltvMenup.ContextMenuStrip = ContextMenuStrip1
        End If
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub IncluirNuevoNroDeMantenimientoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IncluirNuevoNroDeMantenimientoToolStripMenuItem.Click
        modTb = 0
        frmNewnrodeMant.ShowDialog()
     
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        frmNewnrodeMant.ShowDialog()
    End Sub

  
    Private Sub ToolStripButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton12.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Try

            ConexionSQL()
            Dim strDproyMant As New ADODB.Recordset
            Dim preg As String = ""
            If Me.ltvMenup.Items.Count > 0 Then

                For i = 0 To Me.ltvMenup.Items.Count - 1

                    If Me.ltvMenup.Items(i).Selected = True Then
                        strNromant = Me.ltvMenup.FocusedItem.Text
                        strCodProy = Me.ltvMenup.FocusedItem.SubItems(1).Text
                        stridProy = Me.ltvMenup.FocusedItem.SubItems(2).Text
                    End If
                Next

            End If


            'actualiza los datos
            preg = MsgBox("Seguro que desea eliminar el Nro de mantenimiento " & strNromant, MsgBoxStyle.YesNo, "Control Proyectos")
            If preg = 6 Then

                strDproyMant = cntSQL.Execute("select * from pro_Aux_MantProy where pro_idProyecto='" & stridProy & "' and pro_NroProyecto='" & strCodProy & "' and pro_NroMant='" & strNromant & "'")


                If strDproyMant.EOF = False Then

                    cntSQL.Execute("delete from pro_Aux_MantProy where pro_idProyecto='" & stridProy & "' and pro_NroProyecto='" & strCodProy & "' and pro_NroMant='" & strNromant & "'")
                    MsgBox("Nro de serie eliminada", MsgBoxStyle.Information, "Control Proyectos")

                End If
            End If
            llenar()
            f2.clearMant()
        Catch ex As Exception
            MsgBox("Error en funcion ToolStripButton4" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")

        End Try
    End Sub

    Private Sub EliminarNroDeMantenimientoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarNroDeMantenimientoToolStripMenuItem.Click
        Try

            ConexionSQL()
            Dim strDproyMant As New ADODB.Recordset
            Dim preg As String = ""
            If Me.ltvMenup.Items.Count > 0 Then

                For i = 0 To Me.ltvMenup.Items.Count - 1

                    If Me.ltvMenup.Items(i).Selected = True Then
                        strNromant = Me.ltvMenup.FocusedItem.Text
                        strCodProy = Me.ltvMenup.FocusedItem.SubItems(1).Text
                        stridProy = Me.ltvMenup.FocusedItem.SubItems(2).Text
                    End If
                Next

            End If


            'actualiza los datos
            preg = MsgBox("Seguro que desea eliminar el Nro de mantenimiento " & strNromant, MsgBoxStyle.YesNo, "Control Proyectos")
            If preg = 6 Then

                strDproyMant = cntSQL.Execute("select * from pro_Aux_MantProy where pro_idProyecto='" & stridProy & "' and pro_NroProyecto='" & strCodProy & "' and pro_NroMant='" & strNromant & "'")


                If strDproyMant.EOF = False Then

                    cntSQL.Execute("delete from pro_Aux_MantProy where pro_idProyecto='" & stridProy & "' and pro_NroProyecto='" & strCodProy & "' and pro_NroMant='" & strNromant & "'")
                    MsgBox("Nro de serie eliminada", MsgBoxStyle.Information, "Control Proyectos")

                End If
            End If
            llenar()
        Catch ex As Exception
            MsgBox("Error en funcion ToolStripButton4" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")

        End Try
    End Sub

    Private Sub ModificarNroDeMantenimientoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarNroDeMantenimientoToolStripMenuItem.Click
        Dim selecte As Integer = 0
        If Me.ltvMenup.Items.Count > 0 Then

            For i = 0 To Me.ltvMenup.Items.Count - 1

                If Me.ltvMenup.Items(i).Selected = True Then
                    strNromant = Me.ltvMenup.FocusedItem.Text
                    strCodProy = Me.ltvMenup.FocusedItem.SubItems(1).Text
                    stridProy = Me.ltvMenup.FocusedItem.SubItems(2).Text
                    selecte = 1
                    Exit For
                End If
            Next

        End If

        If selecte = 1 Then
            modTb = 1
            frmNewnrodeMant.tbxDato.Text = strNromant
            frmNewnrodeMant.ShowDialog()
        Else
            MsgBox("Debe seleccionar un item", MsgBoxStyle.Critical, "Control Proyectos")

        End If
        selecte = 0
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Dim selecte As Integer = 0
        If Me.ltvMenup.Items.Count > 0 Then

            For i = 0 To Me.ltvMenup.Items.Count - 1

                If Me.ltvMenup.Items(i).Selected = True Then
                    strNromant = Me.ltvMenup.FocusedItem.Text
                    strCodProy = Me.ltvMenup.FocusedItem.SubItems(1).Text
                    stridProy = Me.ltvMenup.FocusedItem.SubItems(2).Text
                    selecte = 1
                    Exit For
                End If
            Next

        End If

        If selecte = 1 Then
            modTb = 1
            frmNewnrodeMant.tbxDato.Text = strNromant
            frmNewnrodeMant.ShowDialog()
        Else
            MsgBox("Debe seleccionar un item", MsgBoxStyle.Critical, "Control Proyectos")

        End If
        selecte = 0
    End Sub

   
End Class
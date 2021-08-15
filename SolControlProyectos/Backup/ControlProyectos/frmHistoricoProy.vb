Public Class frmHistoricoProy
    Public swHist As Integer = 0
    Public swHistp As Integer = 0
   

    Private Sub frmHistoricoProy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            swMen = 0
            ConexionSQL()
            Dim strSubmenu As New ADODB.Recordset
            Dim i As Integer = 0
            Dim strpreg As String = ""
            Me.ltvHistProy.Items.Clear()

            btnAcep.Enabled = True
           
            Me.Text = "SELECCIÓN DE PROYECTOS"

            If frmInicioproyectos.tbxBuscar.Text = "" Then
                ProyNro = 0
            Else
                ProyNro = frmInicioproyectos.tbxBuscar.Text
            End If

            If frmInicioproyectos.tbxBuscar.Text = "" Then

                strSubmenu = cntSQL.Execute("SELECT  id_proyecto, Nro_proyecto, desc_Proyecto, HIST_proyecto FROM tab_idProyecto where id_proyecto>1 and HIST_proyecto=1")
            Else

                strSubmenu = cntSQL.Execute("SELECT id_proyecto, Nro_proyecto, desc_Proyecto, HIST_proyecto FROM tab_idProyecto where Nro_proyecto like '%" & strCodbus & "%' or desc_Proyecto like '%" & strCodbus & "%' and id_proyecto>1  and HIST_proyecto=1")
            End If

            Do While Not strSubmenu.EOF


                Me.ltvHistProy.Items.Add(strSubmenu.Fields("id_proyecto").Value)
                Me.ltvHistProy.Items(i).SubItems.Add(strSubmenu.Fields("Nro_proyecto").Value)
                Me.ltvHistProy.Items(i).SubItems.Add(strSubmenu.Fields("desc_Proyecto").Value)
                i += 1

                strSubmenu.MoveNext()

            Loop


        Catch ex As Exception
            MsgBox("Error en funcion frmSubmenup_Load" & ex.Message, MsgBoxStyle.Exclamation, "Control Proyectos")
        End Try
    End Sub

    Private Sub ltvHistProy_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ltvHistProy.DoubleClick

        If Me.ltvHistProy.Items.Count > 0 Then

            For i = 0 To Me.ltvHistProy.Items.Count - 1

                Me.ltvHistProy.FocusedItem.Checked = True

                ProyNro = Me.ltvHistProy.FocusedItem.SubItems(1).Text
                strCodProy = Me.ltvHistProy.FocusedItem.SubItems(2).Text

            Next

        End If

    End Sub

    Private Sub btnCan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCan.Click
        If Me.btnAcep.Enabled = False Then
            Me.btnAcep.Enabled = True
            frmHistoricoProy_Load(sender, Nothing)
        Else
            Me.Close()
        End If


    End Sub

    Private Sub btnAcep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAcep.Click
        Try
            Dim preg As String = ""
            Dim pregProy As String = ""
            Dim strName As String = ""



            For Each item As ListViewItem In ltvHistProy.Items

                If item.Checked = True Then
                    ProyNro = item.SubItems(1).Text
                    strCodProy = item.Text

                    strName = item.SubItems(1).Text & "-" & item.SubItems(2).Text
                    preg = MsgBox("Seguro que desea pasar el  proyecto a Histórico? " & strName, MsgBoxStyle.YesNo, "Control Proyectos")

                    If preg = 6 Then

                        ActDPpalProyHist()
                        actuDPpalProyHist_Compl()
                        ActCostosFactProy()
                        Acttab_Aux_FactProy()
                        Acttab_HistoricoEntesProy()

                        'pregProy = MsgBox("Proyecto finalizado de forma existosa?", MsgBoxStyle.YesNo, "Control Proyectos")

                        'If pregProy = 6 Then
                        '    actuDPpalProyHist()
                        'End If
                        'cambio a estatus 2 en la tabla ppal de proyectos
                        envioProyHist()

                    End If

                End If

            Next
            If swHist = 0 Then
                MsgBox("Proyecto Historico exitosamente", MsgBoxStyle.Information, "Control Proyectos")

                frmHistoricoProy_Load(sender, Nothing)
            End If

        Catch ex As Exception
            MsgBox("Error en funcion btnAcep_Click" & ex.Message, MsgBoxStyle.Exclamation, "Control Proyectos")
        End Try
        swHist = 0
    End Sub
    Sub pasaProyHist()

        Try

            guardaActProyeDRespf7()

            guardaActProyeDCostosf7()


        Catch ex As Exception
            MsgBox("Error en funcion pasaProyHist()" & ex.Message, MsgBoxStyle.Exclamation, "Control Proyectos")
        End Try
    End Sub
    Sub ActDPpalProyHist()
        'ConexionSQL()
        Try
            Dim strPpal As New ADODB.Recordset
            Dim id As Integer = 0
            ConexionSQL()
            If swHist = 0 Then
                cntSQL.Execute("exec p_PasarproyectHistoricoDatosPpalProy '" & strCodProy & "', '" & ProyNro & "'")
            End If

        Catch ex As Exception
            MsgBox("Error en funcion ActDPpalProyHist" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
            swHist = 1
        End Try

    End Sub

    Sub envioProyHist()
        'ConexionSQL()
        Try
            Dim strPpal As New ADODB.Recordset
            Dim id As Integer = 0
            ConexionSQL()
            If swHist = 0 Then
                cntSQL.Execute("UPDATE tab_idProyecto SET HIST_proyecto= 2 WHERE id_proyecto='" & strCodProy & "' AND  Nro_proyecto='" & ProyNro & "'")
            End If

        Catch ex As Exception
            MsgBox("Error en funcion envioProyHist" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
            swHist = 1
        End Try

    End Sub
    Sub actuDPpalProyHist()
        'ConexionSQL()
        Try
            Dim strPpal As New ADODB.Recordset
            Dim id As Integer = 0
            ConexionSQL()
            If swHist = 0 Then
                cntSQL.Execute("update HISTtab_DatosPpalProy set pro_evaluacion = 1 where pro_idProyecto= '" & strCodProy & "' and  pro_nroProyecto='" & ProyNro & "'")
            End If

        Catch ex As Exception
            MsgBox("Error en funcion actuDPpalProyHist()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
            swHist = 1
        End Try

    End Sub


    Sub actuDPpalProyHist_Compl()
        'ConexionSQL()
        Try
            Dim strPpal As New ADODB.Recordset
            Dim id As Integer = 0
            ConexionSQL()
            If swHist = 0 Then
                cntSQL.Execute("exec p_PasarproyectHistoricoDatosPpalProy_Compl '" & strCodProy & "', '" & ProyNro & "'")
            End If

        Catch ex As Exception
            MsgBox("Error en funcion guardaActDPpalProyHist_Compl" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
            swHist = 1
        End Try

    End Sub

    Sub ActCostosFactProy()
        'ConexionSQL()
        Try
            Dim strPpal As New ADODB.Recordset
            Dim id As Integer = 0
            ConexionSQL()

            If swHist = 0 Then
                cntSQL.Execute("exec p_PasarproyectHistoricoCostosFactProy '" & strCodProy & "', '" & ProyNro & "'")
            End If

        Catch ex As Exception
            MsgBox("Error en funcion p_PasarproyectHistoricoCostosFactProy" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
            swHist = 1
        End Try

    End Sub

    Sub Acttab_Aux_FactProy()
        'ConexionSQL()
        Try
            Dim strPpal As New ADODB.Recordset
            Dim id As Integer = 0
            ConexionSQL()

            If swHist = 0 Then
                cntSQL.Execute("exec p_PasarproyectHistoricotab_Aux_FactProy '" & strCodProy & "', '" & ProyNro & "'")
            End If

        Catch ex As Exception
            MsgBox("Error en funcion Acttab_Aux_FactProy" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
            swHist = 1
        End Try

    End Sub
    Sub Acttab_HistoricoEntesProy()
        'ConexionSQL()
        Try
            Dim strPpal As New ADODB.Recordset
            Dim id As Integer = 0
            ConexionSQL()

            If swHist = 0 Then
                cntSQL.Execute("exec p_PasarproyectHistoricoEntesProy '" & strCodProy & "', '" & ProyNro & "'")
            End If

        Catch ex As Exception
            MsgBox("Error en funcion Acttab_HistoricoEntesProy()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
            swHist = 1
        End Try

    End Sub

    Private Sub btnHist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHist.Click
        Try
            swHistp = 1
            swMen = 0
            ConexionSQL()
            Dim strSubmenu As New ADODB.Recordset
            Dim i As Integer = 0
            Dim strpreg As String = ""
            Me.ltvHistProy.Items.Clear()

            btnAcep.Enabled = False


            Me.Text = "SELECCIÓN DE PROYECTOS"

            If frmInicioproyectos.tbxBuscar.Text = "" Then
                ProyNro = 0
            Else
                ProyNro = frmInicioproyectos.tbxBuscar.Text
            End If

            If frmInicioproyectos.tbxBuscar.Text = "" Then

                strSubmenu = cntSQL.Execute("SELECT  id_proyecto, Nro_proyecto, desc_Proyecto, HIST_proyecto FROM tab_idProyecto where id_proyecto>1 and HIST_proyecto=2")
                'Else

                '    strSubmenu = cntSQL.Execute("SELECT id_proyecto, Nro_proyecto, desc_Proyecto, HIST_proyecto FROM tab_idProyecto where Nro_proyecto like '%" & strCodbus & "%' or desc_Proyecto like '%" & strCodbus & "%' and id_proyecto>1  and HIST_proyecto=3")
            End If

            Do While Not strSubmenu.EOF


                Me.ltvHistProy.Items.Add(strSubmenu.Fields("id_proyecto").Value)
                Me.ltvHistProy.Items(i).SubItems.Add(strSubmenu.Fields("Nro_proyecto").Value)
                Me.ltvHistProy.Items(i).SubItems.Add(strSubmenu.Fields("desc_Proyecto").Value)
                i += 1

                strSubmenu.MoveNext()

            Loop


        Catch ex As Exception
            MsgBox("Error en funcion frmSubmenup_Load" & ex.Message, MsgBoxStyle.Exclamation, "Control Proyectos")
        End Try
    End Sub

    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        Dim frm As New frmProcess
        frm.Show()
        For x As Int32 = 0 To 1

            swRpts = 5
            frmReportResum.ShowDialog()
            Me.Close()
            Exit For
            Application.DoEvents()
        Next
        frm.Close()
    End Sub
End Class
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel

Public Class frmMantenimientoProy

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        f2.Close()
    End Sub

    Private Sub ToolStripButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub ToolStripButton12_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton12.Click
        Me.Close()
    End Sub

    Private Sub tbxCodp_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxCodp.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            Me.btnBuscar.Focus()

            Me.btnBuscar_Click(1, Nothing)
        End If
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        strCodbus = Me.tbxCodp.Text
        frmMantproy.ShowDialog()


    End Sub

    Private Sub tbxUbi_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxUbi.KeyPress
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(tbxUbi.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                tbxUbi.Text = decimales(tbxUbi.Text) 'Format(CDec(txtMonto.Text), "C")
                e.Handled = True
                Me.tbxMtoCb.Focus()


            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxUbi.SelectAll()
        End If
    End Sub
    Public Function DecimalKey(ByVal KCode As Int16) As Boolean

        If (KCode >= 48 And KCode <= 57) Or KCode = 8 Or KCode = 46 Then
            Return False
        Else
            Return True
        End If

    End Function

    Public Function EnteroKey(ByVal KCode As Int16) As Boolean

        If (KCode >= 48 And KCode <= 57) Or KCode = 8 Then
            Return False
        Else
            Return True
        End If

    End Function
    Public Function Numerico(ByVal valor As String) As Boolean
        intk = 0
        Dim strCad As String = valor
        Dim i As Integer

        For i = 1 To Len(strCad)
            If Mid(strCad, i, 1) = "." Then
                intk += 1
            End If


        Next


        If intk <= 1 Then
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub tbxPxC_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxPxC.KeyPress
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(tbxPxC.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                tbxPxC.Text = decimales(tbxPxC.Text) 'Format(CDec(txtMonto.Text), "C")
                e.Handled = True
                Me.txtResp.Focus()


            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxPxC.SelectAll()
        End If
    End Sub

    Private Sub txtMontTri_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMontTri.KeyPress
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(txtMontTri.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                txtMontTri.Text = decimales(txtMontTri.Text) 'Format(CDec(txtMonto.Text), "C")
                e.Handled = True
                Me.txtPercta.Focus()


            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.txtMontTri.SelectAll()
        End If
    End Sub


    Private Sub txtCp_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCp.Leave


        bolValor = Numerico(txtCp.Text)
        If bolValor = False Then

            txtCp.Text = decimales(txtCp.Text) 'Format(CDec(txtMonto.Text), "C")

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.txtCp.SelectAll()
        End If
    End Sub

    Private Sub txtPercta_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPercta.Leave
        bolValor = Numerico(txtPercta.Text)
        If bolValor = False Then

            txtPercta.Text = decimales(txtPercta.Text) 'Format(CDec(txtMonto.Text), "C")

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.txtPercta.SelectAll()
        End If
    End Sub

    Private Sub txtMontTri_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMontTri.Leave


        bolValor = Numerico(txtMontTri.Text)
        If bolValor = False Then


            txtMontTri.Text = decimales(txtMontTri.Text) 'Format(CDec(txtMonto.Text), "C")

            Me.txtPercta.Focus()


        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.txtMontTri.SelectAll()
        End If
    End Sub

    Private Sub tbxPxC_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbxPxC.Leave


        bolValor = Numerico(tbxPxC.Text)
        If bolValor = False Then


            tbxPxC.Text = decimales(tbxPxC.Text) 'Format(CDec(txtMonto.Text), "C")

            Me.txtResp.Focus()




        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxPxC.SelectAll()
        End If
    End Sub

    Private Sub tbxMtoCb_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxMtoCb.KeyPress
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(tbxMtoCb.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                tbxMtoCb.Text = decimales(tbxMtoCb.Text) 'Format(CDec(txtMonto.Text), "C")
                e.Handled = True
                Me.tbxPxC.Focus()


            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxMtoCb.SelectAll()
        End If
    End Sub

    Private Sub tbxMtoCb_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbxMtoCb.Leave


        bolValor = Numerico(tbxMtoCb.Text)
        If bolValor = False Then


            tbxMtoCb.Text = decimales(tbxMtoCb.Text) 'Format(CDec(txtMonto.Text), "C")

            Me.tbxPxC.Focus()




        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxMtoCb.SelectAll()
        End If
    End Sub

    Private Sub tbxUbi_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbxUbi.Leave


        bolValor = Numerico(tbxUbi.Text)
        If bolValor = False Then


            tbxUbi.Text = decimales(tbxUbi.Text) 'Format(CDec(txtMonto.Text), "C")

            Me.tbxMtoCb.Focus()




        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxUbi.SelectAll()
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click

        If tbxCodp.Text <> "" Then
            guardaMantproy()
        Else
            MsgBox("Debe seleccionar un nro de proyecto", MsgBoxStyle.Information, "Control Proyectos")
        End If

    End Sub

    Sub guardaMantproy()
        Try
            ConexionSQL()
            Dim strDproyMant As New ADODB.Recordset
            Dim preg As String

            strDproyMant = cntSQL.Execute("select * from pro_Aux_MantProy where pro_idProyecto='" & stridProy & "' and pro_NroProyecto='" & strCodProy & "'")

            If strDproyMant.EOF = True Then
                'inserta los datos
                cntSQL.Execute("INSERT INTO pro_Aux_MantProy ([pro_NroMant],[pro_idProyecto],[pro_NroProyecto],[pro_FechaIni],[pro_FechaTerm] ,[pro_MontoContrsinITBMS]" _
                               & ",[pro_MontoCobradoa],[pro_PendientexCobrar],[pro_Responsable],[pro_MontosTrimestrales] ,[pro_CtasTransito]" _
                               & ",[pro_CtasPagadas])VALUES" _
                               & "('" & f2.tbxNroMant.Text & "','" & stridProy & "','" & f2.tbxCodp.Text & "','" & Format(f2.dtpFechai.Value, "yyyyMMdd") & "','" & Format(f2.dtpFecTer.Value, "yyyyMMdd") & "','" & Replace(IIf(f2.tbxUbi.Text = "", 0, f2.tbxUbi.Text), ",", "") & "'," _
                               & " " & Replace(IIf(f2.tbxMtoCb.Text = "", 0, f2.tbxMtoCb.Text), ",", "") & "," & Replace(IIf(f2.tbxPxC.Text = "", 0, f2.tbxPxC.Text), ",", "") & ",'" & f2.txtResp.Text & "'," & Replace(IIf(f2.txtMontTri.Text = "", 0, f2.txtMontTri.Text), ",", "") & "," & Replace(IIf(f2.txtPercta.Text = "", 0, f2.txtPercta.Text), ",", "") & "," & Replace(IIf(f2.txtCp.Text = "", 0, f2.txtCp.Text), ",", "") & ")")


            Else
                'actualiza los datos
                strDproyMant = cntSQL.Execute("select * from pro_Aux_MantProy where pro_idProyecto='" & stridProy & "' and pro_NroProyecto='" & strCodProy & "' and pro_NroMant='" & Me.tbxNroMant.Text & "'")

                If strDproyMant.EOF = True Then
                    'inserta los datos si no tiene nro de mantenimiento
                    cntSQL.Execute("INSERT INTO pro_Aux_MantProy ([pro_NroMant],[pro_idProyecto],[pro_NroProyecto],[pro_FechaIni],[pro_FechaTerm] ,[pro_MontoContrsinITBMS]" _
                                   & ",[pro_MontoCobradoa],[pro_PendientexCobrar],[pro_Responsable],[pro_MontosTrimestrales] ,[pro_CtasTransito]" _
                                   & ",[pro_CtasPagadas])VALUES" _
                                   & "('" & f2.tbxNroMant.Text & "','" & stridProy & "','" & f2.tbxCodp.Text & "','" & Format(f2.dtpFechai.Value, "yyyyMMdd") & "','" & Format(f2.dtpFecTer.Value, "yyyyMMdd") & "','" & Replace(IIf(f2.tbxUbi.Text = "", 0, f2.tbxUbi.Text), ",", "") & "'," _
                                   & " " & Replace(IIf(f2.tbxMtoCb.Text = "", 0, f2.tbxMtoCb.Text), ",", "") & "," & Replace(IIf(f2.tbxPxC.Text = "", 0, f2.tbxPxC.Text), ",", "") & ",'" & f2.txtResp.Text & "'," & Replace(IIf(f2.txtMontTri.Text = "", 0, f2.txtMontTri.Text), ",", "") & "," & Replace(IIf(f2.txtPercta.Text = "", 0, f2.txtPercta.Text), ",", "") & "," & Replace(IIf(f2.txtCp.Text = "", 0, f2.txtCp.Text), ",", "") & ")")

                Else


                    preg = MsgBox("Nro de mantenimiento se encuentra registrado, desea actualizar", MsgBoxStyle.YesNo, "Control Proyectos")

                    If preg = 6 Then

                        cntSQL.Execute("UPDATE  pro_Aux_MantProy SET  pro_NroMant= '" & f2.tbxNroMant.Text & "'," _
                                    & "pro_FechaIni='" & Format(f2.dtpFechai.Value, "yyyyMMdd") & "'," _
                                    & "pro_FechaTerm='" & Format(f2.dtpFecTer.Value, "yyyyMMdd") & "'," _
                                    & "pro_MontoCobradoa =" & Replace(IIf(f2.tbxMtoCb.Text = "", 0, f2.tbxMtoCb.Text), ",", "") & "," _
                                    & "pro_PendientexCobrar=" & Replace(IIf(f2.tbxPxC.Text = "", 0, f2.tbxPxC.Text), ",", "") & ", " _
                                    & "pro_Responsable= '" & f2.txtResp.Text & "', " _
                                    & "[pro_MontoContrsinITBMS]=" & Replace(IIf(f2.tbxUbi.Text = "", 0, f2.tbxUbi.Text), ",", "") & ", " _
                                    & "pro_MontosTrimestrales= " & Replace(IIf(f2.txtMontTri.Text = "", 0, f2.txtMontTri.Text), ",", "") & ", " _
                                    & "pro_CtasTransito= " & Replace(IIf(f2.txtPercta.Text = "", 0, f2.txtPercta.Text), ",", "") & ", " _
                                    & "pro_CtasPagadas= " & Replace(IIf(f2.txtCp.Text = "", 0, f2.txtCp.Text), ",", "") & " " _
                                    & " where pro_idProyecto='" & stridProy & "' and pro_NroProyecto='" & strCodProy & "' and pro_NroMant='" & Me.tbxNroMant.Text & "'")
                    End If
                End If


            End If
            MsgBox("Datos Actualizados", MsgBoxStyle.Information, "Control Proyectos")
            clearMant()
        Catch ex As Exception
            MsgBox("Error en funcion consultaMantproy" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub

    Private Sub txtResp_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtResp.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            e.Handled = True
            Me.txtMontTri.Focus()


        End If

    End Sub

    Private Sub btnNroMant_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNroMant.Click
        frmNromantproy.ShowDialog()
    End Sub
    Sub clearMant()
        f2.tbxNroMant.Text = ""
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


    Private Sub txtPercta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPercta.KeyPress



        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(txtPercta.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                txtPercta.Text = decimales(txtPercta.Text) 'Format(CDec(txtMonto.Text), "C")
                e.Handled = True
                Me.txtCp.Focus()


            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.txtPercta.SelectAll()
        End If
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        frmNewnrodeMant.ShowDialog()
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        Try
            Dim frm As New frmProcess
            frm.Show()
            For x As Int32 = 0 To 1
                llenaExcel()
                If frmexcelMant.ltvExcel.Items.Count > 0 Then



                    Dim objExcel As New Excel.Application
                    Dim bkWorkBook As Workbook
                    Dim shWorkSheet As Worksheet
                    Dim i As Integer
                    Dim j As Integer
                    objExcel = New Excel.Application
                    bkWorkBook = objExcel.Workbooks.Add
                    shWorkSheet = CType(bkWorkBook.ActiveSheet, Worksheet)
                    For i = 0 To frmexcelMant.ltvExcel.Columns.Count - 1
                        shWorkSheet.Cells(1, i + 1) = frmexcelMant.ltvExcel.Columns(i).Text
                    Next
                    For i = 0 To frmexcelMant.ltvExcel.Items.Count - 1
                        For j = 0 To frmexcelMant.ltvExcel.Items(i).SubItems.Count - 1
                            shWorkSheet.Cells(i + 2, j + 1) = frmexcelMant.ltvExcel.Items(i).SubItems(j).Text
                        Next
                    Next

                    objExcel.Visible = True
                   
                Else
                    MsgBox("No existen datos para exportar", MsgBoxStyle.Information, "Control de Proyectos")
                End If
                Exit For
                '  Application.DoEvents()
            Next
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub llenaExcel()

        Try
            ConexionSQL()
            Dim strDproyMant As New ADODB.Recordset
            Dim cantRg As Integer = 0
            Dim i As Integer = 0
            frmexcelMant.ltvExcel.Items.Clear()
            strDproyMant = cntSQL.Execute("SELECT [pro_NroMant],tab_DatosPpalProy.pro_nroProyecto as Nroproy,[pro_descripcion],[pro_FechaIni],[pro_FechaTerm] ,[pro_MontoContrsinITBMS] ,[pro_MontoCobradoa]" _
                           & ",[pro_PendientexCobrar] ,[pro_Responsable],[pro_MontosTrimestrales],[pro_CtasTransito] ,[pro_CtasPagadas]" _
                           & " FROM pro_Aux_MantProy inner join tab_DatosPpalProy  on pro_Aux_MantProy.pro_idProyecto=tab_DatosPpalProy.pro_idProyecto" _
                           & " and pro_Aux_MantProy.pro_NroProyecto=tab_DatosPpalProy.pro_nroProyecto where tab_DatosPpalProy.pro_idProyecto='" & stridProy & "' and pro_Aux_MantProy.pro_NroProyecto='" & strCodProy & "'")


            Do While Not strDproyMant.EOF

                frmexcelMant.ltvExcel.Items.Add(strDproyMant.Fields("pro_NroMant").Value)
                frmexcelMant.ltvExcel.Items(i).SubItems.Add(strDproyMant.Fields("Nroproy").Value)
                frmexcelMant.ltvExcel.Items(i).SubItems.Add(strDproyMant.Fields("pro_descripcion").Value)
                frmexcelMant.ltvExcel.Items(i).SubItems.Add(strDproyMant.Fields("pro_FechaIni").Value)
                frmexcelMant.ltvExcel.Items(i).SubItems.Add(strDproyMant.Fields("pro_FechaTerm").Value)
                frmexcelMant.ltvExcel.Items(i).SubItems.Add(strDproyMant.Fields("pro_MontoContrsinITBMS").Value)
                frmexcelMant.ltvExcel.Items(i).SubItems.Add(strDproyMant.Fields("pro_MontoCobradoa").Value)
                frmexcelMant.ltvExcel.Items(i).SubItems.Add(strDproyMant.Fields("pro_PendientexCobrar").Value)
                frmexcelMant.ltvExcel.Items(i).SubItems.Add(strDproyMant.Fields("pro_Responsable").Value)
                frmexcelMant.ltvExcel.Items(i).SubItems.Add(strDproyMant.Fields("pro_MontosTrimestrales").Value)
                frmexcelMant.ltvExcel.Items(i).SubItems.Add(strDproyMant.Fields("pro_CtasTransito").Value)
                frmexcelMant.ltvExcel.Items(i).SubItems.Add(strDproyMant.Fields("pro_CtasPagadas").Value)

                i += 1
                strDproyMant.MoveNext()
            Loop


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub tbxNroMant_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxNroMant.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            e.Handled = True
            Me.dtpFechai.Focus()


        End If

    End Sub

    Private Sub dtpFechai_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFechai.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            e.Handled = True
            Me.tbxUbi.Focus()


        End If
    End Sub

   
End Class
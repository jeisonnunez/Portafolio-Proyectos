Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel

Public Class frmPresCtas
    Private Sub ToolStripButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton12.Click
        Me.Close()
    End Sub



    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        swMenuPpal = 4
        limpiarformEstCtas()
        f16.ltvEstCtas.Items.Clear()
        frmInicioproyectos.ShowDialog()
        ' 
        'Me.ltvEstCtas.Items.Clear()
        Me.tbxPerCta.Focus()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click


        If stridProy <> "" And ProyNro <> "" And Me.tbxCta.Text <> "0" Then
            Dim frm As New frmProcess
            frm.Show()
            For x As Int32 = 0 To 1
                ConexionSQL()

                stridProy = idProyecto(stridProy)

                guardaActProyeEstCtas16()
                llenarFactestCtas()
                Exit For
                System.Windows.Forms.Application.DoEvents()
            Next
            frm.Close()

            If swguar = 0 Then
                MsgBox("Datos Guardados....", MsgBoxStyle.Information, "Control Proyectos")
            End If

        Else
            MsgBox("Debe ingresar un Nro de Proyecto....", MsgBoxStyle.Critical, "Control Proyectos")

        End If

        ToolStripButton1.Enabled = False
        limpiarformEstCtas()
        'CtaNro = 0
        'ProyNro = ""
        'ContNro = ""
        'RecNro = ""
        'FactNro = ""
        'idProy = 0
    End Sub

    Sub llenarFactestCtas()
        Try
            ConexionSQL()
            Dim strDatos As New ADODB.Recordset
            Dim i As Integer = 0
            Me.ltvEstCtas.Items.Clear()

            strDatos = cntSQL.Execute("SELECT [pro_idProyecto],[pro_NroProyecto],[pro_NroContrato],[pro_CtaNro],[pro_PerCtas],[pro_FechaEntScont],[pro_Meta],[pro_Meta1],[pro_MetaFact],[pro_porcCump],[pro_FechaEntInsp],[pro_MontoCtasInsp],[pro_FechaCxc],[pro_MontoAproInsp]FROM tab_Aux_EstCtasProy where pro_idProyecto='" & stridProy & "'")


            Do While Not strDatos.EOF



                Me.ltvEstCtas.Items.Add(strDatos.Fields("pro_CtaNro").Value)
                Me.ltvEstCtas.Items(i).SubItems.Add(strDatos.Fields("pro_NroProyecto").Value)
                Me.ltvEstCtas.Items(i).SubItems.Add(strDescProy)
                Me.ltvEstCtas.Items(i).SubItems.Add(decimales(Math.Round(strDatos.Fields("pro_PerCtas").Value, 2)))
                Me.ltvEstCtas.Items(i).SubItems.Add(strDatos.Fields("pro_FechaEntScont").Value)
                Me.ltvEstCtas.Items(i).SubItems.Add(decimales(Math.Round(strDatos.Fields("pro_Meta").Value, 2)))
                Me.ltvEstCtas.Items(i).SubItems.Add(decimales(Math.Round(strDatos.Fields("pro_Meta1").Value, 2)))
                Me.ltvEstCtas.Items(i).SubItems.Add(decimales(Math.Round(strDatos.Fields("pro_MetaFact").Value, 2)))
                Me.ltvEstCtas.Items(i).SubItems.Add(decimales(Math.Round(strDatos.Fields("pro_porcCump").Value, 2)))
                Me.ltvEstCtas.Items(i).SubItems.Add(strDatos.Fields("pro_FechaEntInsp").Value)
                Me.ltvEstCtas.Items(i).SubItems.Add(0)
                Me.ltvEstCtas.Items(i).SubItems.Add(decimales(Math.Round(strDatos.Fields("pro_MontoCtasInsp").Value, 2)))
                Me.ltvEstCtas.Items(i).SubItems.Add(strDatos.Fields("pro_FechaCxc").Value)
                Me.ltvEstCtas.Items(i).SubItems.Add(0)
                Me.ltvEstCtas.Items(i).SubItems.Add(decimales(Math.Round(strDatos.Fields("pro_MontoAproInsp").Value, 2)))

                i += 1
                strDatos.MoveNext()
            Loop

        Catch ex As Exception
            MsgBox("Error en buscar Nro de llenarFactestCtas()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub
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
    Public Function DecimalKey(ByVal KCode As Int16) As Boolean

        If (KCode >= 48 And KCode <= 57) Or KCode = 8 Or KCode = 46 Then
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub tbxPerCta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxPerCta.KeyPress
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(tbxPerCta.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                tbxPerCta.Text = decimales(tbxPerCta.Text) 'Format(CDec(txtMonto.Text), "C")
                e.Handled = True
                Me.dtpFecEntra.Focus()

            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxPerCta.SelectAll()
        End If

    End Sub

    Private Sub tbxPerCta_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbxPerCta.Leave


        bolValor = Numerico(tbxPerCta.Text)
        If bolValor = False Then


            tbxPerCta.Text = decimales(tbxPerCta.Text) 'Format(CDec(txtMonto.Text), "C")

            Me.dtpFecEntra.Focus()



        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxPerCta.SelectAll()
        End If

    End Sub

    Private Sub tbxMeta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxMeta.KeyPress
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(tbxMeta.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                tbxMeta.Text = decimales(tbxMeta.Text) 'Format(CDec(txtMonto.Text), "C")
                e.Handled = True
                Me.tbxMeta1.Focus()

            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxMeta.SelectAll()
        End If
    End Sub

    Private Sub tbxMeta_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbxMeta.Leave
        bolValor = Numerico(tbxMeta.Text)
        If bolValor = False Then
            tbxMeta.Text = decimales(tbxMeta.Text) 'Format(CDec(txtMonto.Text), "C")
            Me.tbxMeta1.Focus()

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxMeta.SelectAll()
        End If
    End Sub

    Private Sub tbxMeta1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxMeta1.KeyPress
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(tbxMeta1.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                tbxMeta1.Text = decimales(tbxMeta1.Text) 'Format(CDec(txtMonto.Text), "C")
                e.Handled = True
                Me.tbxMetFac.Focus()

            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxMeta1.SelectAll()
        End If
    End Sub

    Private Sub tbxMetFac_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbxMetFac.KeyDown

    End Sub

    Private Sub tbxMetFac_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxMetFac.KeyPress
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(tbxMetFac.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                tbxMetFac.Text = decimales(tbxMetFac.Text) 'Format(CDec(txtMonto.Text), "C")
                e.Handled = True
                Me.tbxCump.Focus()

            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxMetFac.SelectAll()
        End If
    End Sub

    Private Sub tbxMetFac_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbxMetFac.Leave

        bolValor = Numerico(tbxMetFac.Text)
        If bolValor = False Then


            tbxMetFac.Text = decimales(tbxMetFac.Text) 'Format(CDec(txtMonto.Text), "C")

            Me.tbxCump.Focus()



        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxMetFac.SelectAll()
        End If
    End Sub

    Private Sub tbxCump_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxCump.KeyPress
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(tbxCump.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                tbxCump.Text = decimales(tbxCump.Text) 'Format(CDec(txtMonto.Text), "C")
                e.Handled = True
                Me.dtpFechaEn.Focus()

            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxCump.SelectAll()
        End If
    End Sub

    Private Sub dtpFechaEn_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaEn.Leave

    End Sub

    Private Sub tbxCump_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbxCump.Leave
        bolValor = Numerico(tbxCump.Text)
        If bolValor = False Then


            tbxCump.Text = decimales(tbxCump.Text) 'Format(CDec(txtMonto.Text), "C")
            Me.dtpFechaEn.Focus()
        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxCump.SelectAll()
        End If
    End Sub

    Private Sub dtpFechaEn_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFechaEn.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            e.Handled = True
            Me.tbxMont.Focus()

        End If
    End Sub


    Private Sub tbxMont_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxMont.KeyPress
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(tbxMont.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                tbxMont.Text = decimales(tbxMont.Text) 'Format(CDec(txtMonto.Text), "C")
                e.Handled = True
                Me.dtpFecEncxc.Focus()

            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxMont.SelectAll()
        End If
    End Sub

    Private Sub dtpFecEncxc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFecEncxc.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            e.Handled = True
            Me.tbxMontoAp.Focus()

        End If
    End Sub

    Private Sub tbxDias_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxDias.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            e.Handled = True
            Me.tbxMontoAp.Focus()

        End If
    End Sub

    Private Sub tbxMeta1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbxMeta1.Leave
        bolValor = Numerico(tbxMeta1.Text)
        If bolValor = False Then


            tbxMeta1.Text = decimales(tbxMeta1.Text) 'Format(CDec(txtMonto.Text), "C")

            Me.tbxMetFac.Focus()



        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxMeta1.SelectAll()
        End If
    End Sub

    Private Sub tbxMont_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbxMont.Leave
        bolValor = Numerico(tbxMont.Text)
        If bolValor = False Then


            tbxMont.Text = decimales(tbxMont.Text) 'Format(CDec(txtMonto.Text), "C")

            Me.dtpFecEncxc.Focus()



        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxMont.SelectAll()
        End If
    End Sub

    Private Sub tbxMontoAp_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxMontoAp.KeyPress
        e.Handled = DecimalKey(System.Convert.ToInt16(Asc(e.KeyChar)))

        bolValor = Numerico(tbxMontoAp.Text)
        If bolValor = False Then

            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                tbxMontoAp.Text = decimales(tbxMontoAp.Text) 'Format(CDec(txtMonto.Text), "C")
                e.Handled = True
                '   Me.tbxMetFac.Focus()

            End If

        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxMontoAp.SelectAll()
        End If
    End Sub

    Private Sub tbxMontoAp_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbxMontoAp.Leave
        bolValor = Numerico(tbxMontoAp.Text)
        If bolValor = False Then


            tbxMontoAp.Text = decimales(tbxMontoAp.Text) 'Format(CDec(txtMonto.Text), "C")

            '   Me.tbxMetFac.Focus()



        Else
            intk = 0
            MsgBox("Error en el Monto, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")
            Me.tbxMontoAp.SelectAll()
        End If
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        limpiarformEstCtas()

        ToolStripButton1.Enabled = True
        Try
            Dim strDFact As New ADODB.Recordset
            Dim cta As Integer = 0
            ConexionSQL()


            'budco el numero de cuenta
            strDFact = cntSQL.Execute("select max(pro_CtaNro) as pro_CtaNro from tab_Aux_EstCtasProy where pro_idProyecto='" & stridProy & "'")

            If strDFact.EOF = False Then
                cta = Val(IIf(strDFact.Fields("pro_CtaNro").Value Is DBNull.Value, 0, strDFact.Fields("pro_CtaNro").Value))
                cta += 1
            Else
                cta = 1
            End If

            f16.tbxCta.Text = cta
        Catch ex As Exception
            MsgBox("Error en Incluir/Nuevo frmEstCtas", MsgBoxStyle.Critical, "Control Proyectos")
        End Try
        Me.tbxPerCta.Focus()


    End Sub
    Sub limpiarformEstCtas()
        Try
            f16.tbxCta.Text = ""

            f16.tbxPerCta.Text = ""
            f16.dtpFecEntra.Value = Date.Now
            f16.tbxMeta.Text = ""
            f16.tbxMeta1.Text = ""
            f16.tbxMetFac.Text = ""
            f16.tbxCump.Text = ""
            f16.dtpFechaEn.Value = Date.Now
            f16.tbxMont.Text = ""
            f16.dtpFecEncxc.Value = Date.Now
            f16.tbxMontoAp.Text = ""

        Catch ex As Exception
            MsgBox("Error en limpiarformEstCtas()", MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub

    Private Sub ltvEstCtas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ltvEstCtas.SelectedIndexChanged
        If Me.ltvEstCtas.Items.Count > 0 Then

            For i = 0 To Me.ltvEstCtas.Items.Count - 1
                

                If Me.ltvEstCtas.Items(i).Selected = True Then

                    ProyNro = Me.ltvEstCtas.FocusedItem.SubItems(1).Text
                    CtaNro = Me.ltvEstCtas.FocusedItem.SubItems(0).Text
                    Exit For
                End If


            Next

            Me.tbxCta.Text = CtaNro
        End If

        If swMenuPpal <> 3 Then
            consultaProyDppalf16_1()
        End If

        If swMenuPpal = 3 Then
            f16.Close()
        End If
    End Sub


    Private Sub frmPresCtas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        swMenuPpal = 4
        llenarFactestCtas()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Dim preg As String = ""

        preg = MsgBox("Seguro que desea actualizar el Proyecto", MsgBoxStyle.YesNo, "Control de Proyectos")

        If preg = 6 Then
            ToolStripButton1_Click(1, Nothing)

        End If

    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        Try

            If Me.ltvEstCtas.Items.Count > 0 Then
                Dim frm As New frmProcess
                frm.Show()
                For x As Int32 = 0 To 1


                    Dim objExcel As New Excel.Application
                    Dim bkWorkBook As Workbook
                    Dim shWorkSheet As Worksheet
                    Dim i As Integer
                    Dim j As Integer
                    objExcel = New Excel.Application
                    bkWorkBook = objExcel.Workbooks.Add
                    shWorkSheet = CType(bkWorkBook.ActiveSheet, Worksheet)
                    For i = 0 To Me.ltvEstCtas.Columns.Count - 1
                        shWorkSheet.Cells(1, i + 1) = Me.ltvEstCtas.Columns(i).Text
                    Next
                    For i = 0 To Me.ltvEstCtas.Items.Count - 1
                        For j = 0 To Me.ltvEstCtas.Items(i).SubItems.Count - 1
                            shWorkSheet.Cells(i + 2, j + 1) = Me.ltvEstCtas.Items(i).SubItems(j).Text
                        Next
                    Next

                    objExcel.Visible = True
                    Exit For
                    '  Application.DoEvents()
                Next
                frm.Close()
            Else
                MsgBox("No existen datos para exportar", MsgBoxStyle.Information, "Control de Proyectos")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Dim preg As String = ""

        preg = MsgBox("Seguro que desea Eliminar la Cuenta " & f16.tbxCta.Text & " del Proyecto " & lbltiproy.Text & " ", MsgBoxStyle.YesNo, "Control de Proyectos")

        If preg = 6 Then
            Dim strDFact As New ADODB.Recordset
            Dim cta As Integer = 0
            ConexionSQL()
            Try

             


                strDFact = cntSQL.Execute("select pro_idProyecto from tab_Aux_EstCtasProy where pro_idProyecto='" & stridProy & "' and [pro_CtaNro]='" & f16.tbxCta.Text & "'")


                If strDFact.EOF = False Then

                    cntSQL.Execute("delete from tab_Aux_EstCtasProy where pro_idProyecto='" & stridProy & "'  and [pro_CtaNro]='" & f16.tbxCta.Text & "'")
                    MsgBox("Registro Eliminado", MsgBoxStyle.Information, "Control Proyectos")

                End If
                limpiarformEstCtas()
                llenarFactestCtas()

            Catch ex As Exception
                MsgBox("Error en funcion Eliminar Ctas" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
            End Try
         

        End If
    End Sub

    Private Sub dtpFecEntra_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFecEntra.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            'tbxMontoAp.Text = decimales(tbxMontoAp.Text) 'Format(CDec(txtMonto.Text), "C")
            e.Handled = True
            Me.tbxMeta.Focus()

        End If
    End Sub

    
End Class
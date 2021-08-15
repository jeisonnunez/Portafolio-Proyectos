Public Class frmSincronizaA2
    Public FDI_CODIGO As String = ""
    Public FTI_DOCUMENTO As String = ""
    Public FTI_FECHAEMISION As Date
    Public FTI_TOTALBRUTO As Decimal
    Public FTI_DESCUENTO1MONTO As Decimal
    Public FTI_IMPUESTO1MONTO As Decimal
    Public FTI_SALDOOPERACION As Decimal
    Public FTI_FORMADEPAGO As Byte()
    Public FCC_MONTORETENCION As Decimal
    Public strCodCt As String = ""



    Private Sub btnCanc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCanc.Click
        Me.Close()
    End Sub

    Private Sub btnAcep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAcep.Click

        If DateDiff(DateInterval.Day, Me.dtpFeci.Value, Me.dtpFecf.Value) >= 0 Then


            Dim frm As New frmProcess
            Try

                frm.Show()
                For x As Int32 = 0 To 1
                    buscarFactA2()

                    Exit For
                    Application.DoEvents()
                Next
                frm.Close()

            Catch ex As Exception
                frm.Close()
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
            End Try

            Me.Close()
        Else

            MsgBox("Rando de Fechas invalidas", MsgBoxStyle.Critical, "Control Proyectos")

        End If

    End Sub
    Sub buscarFactA2()
        If pathContr <> "" Then
            ConexionBDA2()
            Dim swFact As Integer = 0
            Try
                Dim strFact As ADODB.Recordset
                Dim strCodcont As String = ""


                ProyNro = buscacodCont(ProyNro)

                strFact = cntDBa2.Execute("SELECT FDI_CODIGO, FTI_DOCUMENTO, FTI_FECHAEMISION, FTI_TOTALBRUTO, FTI_DESCUENTO1MONTO, FTI_IMPUESTO1MONTO, FTI_SALDOOPERACION,FDI_CLIENTEPROVEEDOR, case when FCC_MONTORETENCION is null then 0 else FCC_MONTORETENCION end as FCC_MONTORETENCION FROM SOPERACIONINV INNER JOIN SDETALLEVENTA ON FDI_DOCUMENTO=FTI_DOCUMENTO AND FTI_FECHAEMISION=FDI_FECHAOPERACION " _
                                         & "  LEFT OUTER JOIN SRETENCIONCLIENTE ON FDI_CLIENTEPROVEEDOR=FCC_CODIGO AND FCC_NUMERO2=FTI_DOCUMENTO WHERE  FDI_CODIGO='" & ProyNro & "' and  FTI_FECHAEMISION between '" & Format(dtpFeci.Value, "yyyy-MM-dd") & "' and  '" & Format(dtpFecf.Value, "yyyy-MM-dd") & "'")

                Do While Not strFact.EOF
                    swFact = 1
                    FDI_CODIGO = IIf(strFact.Fields("FDI_CODIGO").Value Is DBNull.Value, "", strFact.Fields("FDI_CODIGO").Value)
                    FTI_DOCUMENTO = IIf(strFact.Fields("FTI_DOCUMENTO").Value Is DBNull.Value, "", strFact.Fields("FTI_DOCUMENTO").Value)
                    FTI_FECHAEMISION = IIf(strFact.Fields("FTI_FECHAEMISION").Value Is DBNull.Value, "", strFact.Fields("FTI_FECHAEMISION").Value)
                    FTI_TOTALBRUTO = IIf(strFact.Fields("FTI_TOTALBRUTO").Value Is DBNull.Value, "", strFact.Fields("FTI_TOTALBRUTO").Value)
                    FTI_DESCUENTO1MONTO = IIf(strFact.Fields("FTI_DESCUENTO1MONTO").Value Is DBNull.Value, "", strFact.Fields("FTI_DESCUENTO1MONTO").Value)
                    FTI_IMPUESTO1MONTO = IIf(strFact.Fields("FTI_IMPUESTO1MONTO").Value Is DBNull.Value, "", strFact.Fields("FTI_IMPUESTO1MONTO").Value)
                    FTI_SALDOOPERACION = IIf(strFact.Fields("FTI_SALDOOPERACION").Value Is DBNull.Value, "", strFact.Fields("FTI_SALDOOPERACION").Value)
                    FCC_MONTORETENCION = IIf(strFact.Fields("FCC_MONTORETENCION").Value Is DBNull.Value, "", strFact.Fields("FCC_MONTORETENCION").Value)
                    insertaProyeDFact()

                    strFact.MoveNext()
                Loop

                f15.llenarFactPagosf15()

                If swFact = 0 Then
                    MsgBox("No existen facturas para la fecha seleccionada", MsgBoxStyle.Information, "Control Proyectos")

                End If
            Catch ex As Exception
                MsgBox("Error en funcion buscarFactA2()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")

            End Try
        Else
            MsgBox("Ruta Server No configurada, Por favor Revise la Ruta de la Misma en Menu Contratista", MsgBoxStyle.Exclamation, "Control Proyectos")

        End If
    End Sub

    Sub insertaProyeDFact()
        Try
            Dim strDFact As New ADODB.Recordset
            Dim intimp As Integer = -1
            Dim EnInsp As Integer = -1

            If FCC_MONTORETENCION <> 0 Then
                intimp = 0
            End If

            ConexionSQL()

            strDFact = cntSQL.Execute("select pro_idProyecto from tab_Aux_FactProy where  pro_nroProyecto='" & FDI_CODIGO & "' and pro_NroFactura=''")

            If strDFact.EOF = False Then

                cntSQL.Execute("update tab_Aux_FactProy set pro_NroFactura='" & FTI_DOCUMENTO & "'," _
                               & " pro_FechaFact='" & Format(FTI_FECHAEMISION, "yyyyMMdd") & "', pro_trabajoFac=" & Replace(FTI_TOTALBRUTO, ",", "") & ", pro_Rete10=" & intimp & "," _
                               & " pro_MtoRete10=" & Replace(FCC_MONTORETENCION, ",", "") & "," _
                               & " pro_MontoITBMS=" & Replace(FTI_IMPUESTO1MONTO, ",", "") & ", pro_CuentaCobrar=" & Replace(FTI_SALDOOPERACION, ",", "") & " " _
                               & " where  pro_nroProyecto='" & FDI_CODIGO & "' and pro_NroFactura=''")


            End If


            strDFact = cntSQL.Execute("select pro_idProyecto from tab_Aux_FactProy where  pro_nroProyecto='" & FDI_CODIGO & "' and pro_NroFactura='" & FTI_DOCUMENTO & "'")

            If strDFact.EOF = True Then

                cntSQL.Execute("insert into [tab_Aux_FactProy] ([pro_idProyecto] ,pro_nroProyecto,[pro_NroContrato],[pro_NroRecibo],[pro_FechaRes],[pro_NroFactura]" _
                                         & " ,[pro_FechaFact],[pro_trabajoFac],[pro_Rete10],[pro_MtoRete10],[pro_Anticipo],[pro_Penalizacion]" _
                                         & " ,[pro_RETdeITBMS],[pro_MontoITBMS],[pro_CuentaCobrar],[pro_EntrInsp],[pro_FechaCliente],[pro_FechaCxc]" _
                                         & " ,[pro_FechaTes],[pro_FechaPago],pro_montoCheque,pro_manual) VALUES " _
                                         & "( " & stridProy & ", " _
                                         & " '" & FDI_CODIGO & "', " _
                                         & " '" & ContNro & "', " _
                                         & " '', " _
                                         & " '" & Format(Date.Now, "yyyyMMdd") & "'  ," _
                                         & " '" & FTI_DOCUMENTO & "', " _
                                         & " '" & Format(FTI_FECHAEMISION, "yyyyMMdd") & "', " _
                                         & " " & Replace(FTI_TOTALBRUTO, ",", "") & "," _
                                         & " " & intimp & "," _
                                         & " " & Replace(FCC_MONTORETENCION, ",", "") & ", " _
                                         & " " & 0 & ", " _
                                         & " " & 0 & ", " _
                                         & " " & 0 & ", " _
                                         & " " & Replace(FTI_IMPUESTO1MONTO, ",", "") & ", " _
                                         & " " & Replace(FTI_SALDOOPERACION, ",", "") & " ," _
                                         & " '" & EnInsp & "', " _
                                         & " '" & Format(Date.Now, "yyyyMMdd") & "'  ," _
                                         & " '" & Format(Date.Now, "yyyyMMdd") & "' ," _
                                         & " '" & Format(Date.Now, "yyyyMMdd") & "' ," _
                                         & " '" & Format(Date.Now, "yyyyMMdd") & "', " & 0 & ", " & 0 & ")")


            End If

            insertNroFacta2(stridProy, FDI_CODIGO, ContNro, RecNro, FTI_DOCUMENTO)

            swguar = 1
        Catch ex As Exception
            MsgBox("Error en funcion insertaProyeDFact()t" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
        swguar = 0
        swctaFac = 0
    End Sub
    Public Function insertNroFacta2(ByVal id As Decimal, ByVal NroProy As String, ByVal NroCont As String, ByVal Rec As String, ByVal Fact As String)
        ConexionSQL()
        Dim sw As Integer = 0
        Try
            Dim strNro As New ADODB.Recordset
            Dim preg As String = ""
            Dim swfact As Integer = 0
            Dim strcta As New ADODB.Recordset
            Dim i As Integer = 1
            'si no existe los datos del nro proyecto y el nro de contrato

            If NroCont <> "" Then


                strNro = cntSQL.Execute("SELECT cta_Nro, [id_proyecto] ,[nro_proyecto] ,[nro_contrato],[nro_recibo],[nro_Factura]  FROM [dbo].[tab_NrosReciboProy] where [nro_proyecto] ='" & NroProy & "' and [nro_contrato]='" & NroCont & "' ")

                'preguntar si es la primera factura añadida al contrato con el nro de cuenta 1
                Do While Not strNro.EOF

                    If strNro.Fields("cta_Nro").Value = 1 And strNro.Fields("nro_Factura").Value = "" And FactNro <> "" Then


                        If swInput = 0 Then
                            swfact = 1
                            cntSQL.Execute("update [tab_NrosReciboProy]set [nro_Factura] ='" & Fact & "', nro_recibo='" & RecNro & "' where [nro_proyecto] ='" & NroProy & "' and [nro_contrato]='" & NroCont & "' AND  [nro_Factura]='' AND  nro_recibo=''")
                            CtaNro = 1
                            swctaFac = 1

                            If swMenuPpal = 1 Then
                                f15.tbxNroReci.Text = RecNro
                                f15.tbxNroFac.Text = Fact
                            End If
                           
                            swfact = 1
                        End If
                    End If


                    If strNro.Fields("cta_Nro").Value = 1 And strNro.Fields("nro_Factura").Value = "" And FactNro = "" And swfact = 0 Then


                        swfact = 1
                        cntSQL.Execute("update [tab_NrosReciboProy]set [nro_Factura] ='" & Fact & "', nro_recibo='" & Rec & "' where [nro_proyecto] ='" & NroProy & "' and [nro_contrato]='" & NroCont & "' AND  [nro_Factura]='' AND  nro_recibo=''")
                        CtaNro = 1

                        If swMenuPpal = 1 Then
                            f15.tbxNroReci.Text = RecNro
                            f15.tbxNroFac.Text = Fact
                        End If

                        swfact = 1


                        If strNro.Fields("nro_Factura").Value = Fact And Rec = "" Then
                            cntSQL.Execute("update [tab_NrosReciboProy]set [nro_Factura] ='" & Fact & "' where [nro_proyecto] ='" & NroProy & "' and [nro_contrato]='" & NroCont & "' AND  [nro_Factura]='" & Fact & "'")
                            Exit Try
                        End If


                    End If
            strNro.MoveNext()
                Loop

                If swfact = 0 Then
                    strNro = cntSQL.Execute("SELECT cta_Nro, [id_proyecto] ,[nro_proyecto] ,[nro_contrato],[nro_recibo],[nro_Factura]  FROM [dbo].[tab_NrosReciboProy] where [nro_proyecto] ='" & NroProy & "' and [nro_contrato]='" & NroCont & "' AND  [nro_Factura]='" & Fact & "'")

                    If strNro.EOF = True Then
                        If swMenuPpal = 1 Then
                            f15.tbxNroReci.Text = RecNro
                            f15.tbxNroFac.Text = Fact
                        End If
                        strcta = cntSQL.Execute("SELECT max(cta_Nro) as cta_Nro FROM [dbo].[tab_NrosReciboProy] where [nro_proyecto] ='" & NroProy & "' and [nro_contrato]='" & NroCont & "' ")

                        If strcta.EOF = False Then
                            i = i + Val(IIf(strcta.Fields("cta_Nro").Value Is DBNull.Value, 0, strcta.Fields("cta_Nro").Value))
                        End If

                        cntSQL.Execute("insert into [tab_NrosReciboProy](cta_Nro,[id_proyecto] ,[nro_proyecto] ,[nro_contrato],[nro_recibo],[nro_Factura]) values (" & i & "," & id & ", '" & NroProy & "', '" & NroCont & "','" & RecNro & "', '" & Fact & "')")
                        FactNro = Fact

                        CtaNro = i

                    End If

                End If

            Else
                MsgBox("Debe indicar un Numero de Contrato", MsgBoxStyle.Critical, "Control Proyectos")
            End If

            FactNro = Fact


        Catch ex As Exception
            MsgBox("Error en funcion insertNroFact" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try


        Return idProy

    End Function

    Private Sub dtpFeci_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFeci.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            e.Handled = True
            Me.dtpFecf.Focus()

        End If
    End Sub

    Private Sub dtpFecf_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFecf.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            e.Handled = True
            Me.btnAcep.Focus()

        End If
    End Sub



    Public Function buscacodCont(ByVal index As String)
        Dim idx As String = ""
        Try
            Dim strCont As ADODB.Recordset
            Dim i As Integer = 0


            ConexionSQL()

            strCont = cntSQL.Execute("SELECT pro_Contratista from tab_Aux_EntesProy where pro_nroProyecto='" & index & "'")


            If strCont.EOF = False Then

                If (RTrim(LTrim(strCont.Fields("pro_Contratista").Value)) <> "01") Then

                    idx = LTrim(RTrim(Mid(index, 3, Len(index))))
                Else
                    idx = index

                End If

            Else
                idx = index
            End If



        Catch ex As Exception
            MsgBox("Error en funcion buscacodCont" & ex.Message)
        End Try

        Return idx

    End Function
End Class
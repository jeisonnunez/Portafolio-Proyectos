Public Class frmFacturasResumen
    Public intManual As Integer = 0
    Private Sub frmFacturas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarFactPagosfront()
    End Sub
    Sub llenarFactPagosfront()
        Try
            ConexionSQL()
            Dim strDatos As New ADODB.Recordset
            Dim i As Integer = 0
            Dim decCxc As Decimal = 0
            Dim decPg As Decimal = 0
            Dim decTtal As Decimal = 0

            Me.ltwFactRes.Items.Clear()


            strDatos = cntSQL.Execute("exec p_calculaPagos_front '" & ProyNro & "','" & stridProy & "','" & ContNro & "'")


            Do While Not strDatos.EOF

                Me.ltwFactRes.Items.Add(ProyNro)
                Me.ltwFactRes.Items(i).SubItems.Add(strDatos.Fields("pro_NroContrato").Value)
                Me.ltwFactRes.Items(i).SubItems.Add(strDatos.Fields("pro_NroFactura").Value)
                Me.ltwFactRes.Items(i).SubItems.Add(strDatos.Fields("pro_fechaFactura").Value)
                Me.ltwFactRes.Items(i).SubItems.Add(decimales(strDatos.Fields("pro_trabajoFac").Value))
                Me.ltwFactRes.Items(i).SubItems.Add(decimales(strDatos.Fields("pro_MtoRete10").Value))
                Me.ltwFactRes.Items(i).SubItems.Add(decimales(strDatos.Fields("pro_Anticipo").Value))
                Me.ltwFactRes.Items(i).SubItems.Add(decimales(strDatos.Fields("pro_MontoITBMS").Value))
                Me.ltwFactRes.Items(i).SubItems.Add(decimales(strDatos.Fields("pro_CuentaCobrar").Value))
                decCxc += strDatos.Fields("pro_CuentaCobrar").Value

                Me.ltwFactRes.Items(i).SubItems.Add(decimales(strDatos.Fields("pro_MontoPago").Value))
                decPg += strDatos.Fields("pro_MontoPago").Value

                Me.ltwFactRes.Items(i).SubItems.Add(decimales(strDatos.Fields("pro_Total").Value))
                decTtal += strDatos.Fields("pro_Total").Value
                i += 1
                strDatos.MoveNext()
            Loop

            'agrego los totales 
            'i +=d
            Me.ltwFactRes.Items.Add("").BackColor = Color.Yellow
            Me.ltwFactRes.Items(i).SubItems.Add("").BackColor = Color.Yellow
            Me.ltwFactRes.Items(i).SubItems.Add("").BackColor = Color.Yellow
            Me.ltwFactRes.Items(i).SubItems.Add("").BackColor = Color.Yellow
            Me.ltwFactRes.Items(i).SubItems.Add("").BackColor = Color.Yellow
            Me.ltwFactRes.Items(i).SubItems.Add("").BackColor = Color.Yellow
            Me.ltwFactRes.Items(i).SubItems.Add("").BackColor = Color.Yellow
            Me.ltwFactRes.Items(i).SubItems.Add("").BackColor = Color.Yellow
            Me.ltwFactRes.Items(i).SubItems.Add(decimales(decCxc)).BackColor = Color.Yellow
            Me.ltwFactRes.Items(i).SubItems.Add(decimales(decPg)).BackColor = Color.Yellow
            Me.ltwFactRes.Items(i).SubItems.Add(decimales(decTtal)).BackColor = Color.Yellow

            'Format(intMonto, "#,##0.00")


        Catch ex As Exception
            MsgBox("Error en buscar Nro de llenarFactPagosf15" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub


    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub


  
    Private Sub ltwFactRes_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ltwFactRes.DoubleClick
        If Me.ltwFactRes.Items.Count > 0 Then

            For i = 0 To Me.ltwFactRes.Items.Count - 1

                If Me.ltwFactRes.Items(i).Selected = True Then
                    ProyNro = Me.ltwFactRes.FocusedItem.SubItems(0).Text
                    ContNro = Me.ltwFactRes.FocusedItem.SubItems(1).Text
                    FactNro = Me.ltwFactRes.FocusedItem.SubItems(2).Text

                    'limpia los campos 
                    f15.tbxFact.Text = ""
                    f15.tbxCtaNro.Text = ""
                    'f15.dptFechai.Value = Date.Now
                    'f15.dtpFechaf.Value = Date.Now
                    f15.tbxTreal.Text = ""
                    'f15.dtpFechare.Value = Date.Now
                    f15.tbxPresIns.Text = ""
                    'f15.dtpFecP.Value = Date.Now
                    f15.tbxDur.Text = ""
                    f15.cmbPerPCtas.SelectedIndex = -1
                    'f15.dtpFechIp.Value = Date.Now
                    'f15.dtpFecFinOrPr.Value = Date.Now
                    f15.cmbSt.SelectedIndex = -1
                    f15.cmbTip.SelectedIndex = -1

                    clearDCostos15()
                    clearDfact15()

                    Exit For
                End If

            Next

        End If

        If swMenuPpal <> 3 Then
            ' frmInputctas.actualizaFechaEstCobros()
            ConsultasDFactf15()
            ConsultasDCostosf15()
            f15.llenarFacturasCtas()
            frmNroctaproy.llenarNrocta()
        End If

        If swMenuPpal = 3 Then
            f15.Close()
        End If

        f15.llenarFactRelPagos()
        Me.Close()

    End Sub
End Class
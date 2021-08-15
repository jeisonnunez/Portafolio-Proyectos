Public Class frmAdendas

    Private Sub frmAdendas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If inttipoAd = 1 Then

          
            Me.Text = "ADENDA DE MONTO"

        End If


        If inttipoAd = 0 Then
          
            Me.Text = "ADENDA DE FECHA"
        End If


        If inttipoAd = 2 Then
          
            Me.Text = "ADENDA DE MONTO + FECHA"
        End If

        llenarNroAdendas()


    End Sub
    Sub llenarNroAdendas()
        Try
            ConexionSQL()
            Dim strDatos As New ADODB.Recordset
            Dim i As Integer = 0
            Dim intTotal As Decimal = 0
            Dim intTotaldias As Integer = 0
            Me.ltwAdendas.Items.Clear()


            ' strDatos = cntSQL.Execute("SELECT pro_Financiera,[pro_idAdendas],pro_adFecha,[pro_idProyecto],[pro_nroProyecto],[pro_nroContrato],[pro_Observacion],[pro_monto],pro_tipoAdendas,pro_adendaFecha, tiempoAdf FROM tab_AdendasProy where pro_nroContrato='" & ContNro & "' and pro_nroProyecto='" & ProyNro & "' and pro_tipoAdendas= '" & inttipoAd & "' ")


            strDatos = cntSQL.Execute("SELECT [pro_idAdendas],[pro_idProyecto],[pro_nroProyecto],[pro_nroContrato],[pro_Observacion],[pro_monto], [pro_adFecha] ,[pro_tipoAdendas],[tiempoAdf] ,[pro_Financiera],[pro_NroAdenda] FROM [tab_AdendasProy] where pro_nroContrato='" & ContNro & "' and pro_nroProyecto='" & ProyNro & "' order by pro_NroAdenda")

            Do While Not strDatos.EOF

                Me.ltwAdendas.Items.Add(strDatos.Fields("pro_tipoAdendas").Value)
                Me.ltwAdendas.Items(i).SubItems.Add(strDatos.Fields("pro_NroAdenda").Value)
                Me.ltwAdendas.Items(i).SubItems.Add(strDatos.Fields("pro_nroProyecto").Value)
                Me.ltwAdendas.Items(i).SubItems.Add(strDatos.Fields("pro_nroContrato").Value)
                Me.ltwAdendas.Items(i).SubItems.Add(strDatos.Fields("pro_adFecha").Value)
                Me.ltwAdendas.Items(i).SubItems.Add(decimales(strDatos.Fields("pro_monto").Value))
                Me.ltwAdendas.Items(i).SubItems.Add(strDatos.Fields("tiempoAdf").Value)
                Me.ltwAdendas.Items(i).SubItems.Add(strDatos.Fields("pro_Observacion").Value)
                Me.ltwAdendas.Items(i).SubItems.Add(strDatos.Fields("pro_Financiera").Value)
                Me.ltwAdendas.Items(i).SubItems.Add(strDatos.Fields("pro_tipoAdendas").Value)
                Me.ltwAdendas.Items(i).SubItems.Add(strDatos.Fields("pro_idAdendas").Value)
                intTotal = intTotal + decimales(strDatos.Fields("pro_monto").Value)
                intTotaldias = intTotaldias + strDatos.Fields("tiempoAdf").Value
                i += 1
                strDatos.MoveNext()
            Loop


            For Each item As ListViewItem In ltwAdendas.Items

                If item.SubItems(0).Text = 1 Then
                    item.Checked = True
                    item.SubItems(0).Text = ""
                Else

                    item.Checked = False
                    item.SubItems(0).Text = ""
                End If
            Next


            Me.ltwAdendas.Items.Add("").BackColor = Color.Yellow
            Me.ltwAdendas.Items(i).SubItems.Add("").BackColor = Color.Yellow
            Me.ltwAdendas.Items(i).SubItems.Add("").BackColor = Color.Yellow
            Me.ltwAdendas.Items(i).SubItems.Add("").BackColor = Color.Yellow
            Me.ltwAdendas.Items(i).SubItems.Add("").BackColor = Color.Yellow
            Me.ltwAdendas.Items(i).SubItems.Add(decimales(intTotal)).BackColor = Color.Yellow
            Me.ltwAdendas.Items(i).SubItems.Add(intTotaldias).BackColor = Color.Yellow
            Me.ltwAdendas.Items(i).SubItems.Add("").BackColor = Color.Yellow
            Me.ltwAdendas.Items(i).SubItems.Add("").BackColor = Color.Yellow
            Me.ltwAdendas.Items(i).SubItems.Add("").BackColor = Color.Yellow



        Catch ex As Exception
            MsgBox("Error en buscar Nro de llenarNrocta()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        swAd = 1
        frmmantAdendas.ShowDialog()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click

        Dim swsele As Integer = 0
        Dim preg As String = ""
        ConexionSQL()
        Dim strPpal As New ADODB.Recordset
        modTb = 0


        If Me.ltwAdendas.Items.Count > 0 Then

            For i = 0 To Me.ltwAdendas.Items.Count - 1

                If Me.ltwAdendas.Items(i).Selected = True Then

                

                    ProyNro = Me.ltwAdendas.FocusedItem.SubItems(2).Text
                    ContNro = Me.ltwAdendas.FocusedItem.SubItems(3).Text
                    fechaad = Me.ltwAdendas.FocusedItem.SubItems(4).Text
                    idAd = Me.ltwAdendas.FocusedItem.SubItems(10).Text
                    montoAd = Me.ltwAdendas.FocusedItem.SubItems(5).Text
                    obsAd = Me.ltwAdendas.FocusedItem.SubItems(7).Text
                    inttipoAd = Me.ltwAdendas.FocusedItem.SubItems(9).Text
                    intAdFin = Me.ltwAdendas.FocusedItem.SubItems(8).Text
                    fechaadendas = Me.ltwAdendas.FocusedItem.SubItems(4).Text
                    intAdTiempo = Me.ltwAdendas.FocusedItem.SubItems(6).Text
                    swsele = 1

                    Exit For

                End If
            Next


        End If

       


        If swsele = 1 Then

            swAd = 2
            frmmantAdendas.ShowDialog()
        End If

        If swsele = 0 Then
            MsgBox("Debe seleccionar el elemento a Modificar", MsgBoxStyle.Critical, "Control Proyectos")

        End If
    End Sub
    Public Function decimales(ByVal dato As String)

        If (dato <> String.Empty) Then
            ' Convertimos a Decimal el valor del control TextBox. Si
            ' el valor no se puede convertir a Decimal, se mostrará
            ' un 0 en lugar de producirse un error.
            '
            Dim importe As Decimal
            Decimal.TryParse(dato, importe)
            ' Formateamos a entero, sin decimales, el valor decimal obtenido.
            '
            dato = String.Format("{0:n}", importe)
            ' Establecemos el punto de inserción al final del valor del control TextBox.                '
            'dato.SelectionStart = dato.TextLength

        End If
        Return dato
    End Function

    Private Sub ToolStripButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton12.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Dim swsele As Integer = 0
        Dim preg As String = ""
        ConexionSQL()
        Dim strPpal As New ADODB.Recordset
        modTb = 0
        If Me.ltwAdendas.Items.Count > 0 Then

            For i = 0 To Me.ltwAdendas.Items.Count - 1

                If Me.ltwAdendas.Items(i).Selected = True Then

                    If Me.ltwAdendas.FocusedItem.SubItems(2).Text <> "" Then

                        ProyNro = Me.ltwAdendas.FocusedItem.SubItems(2).Text
                        ContNro = Me.ltwAdendas.FocusedItem.SubItems(3).Text
                        fechaad = Me.ltwAdendas.FocusedItem.SubItems(4).Text
                        idAd = Me.ltwAdendas.FocusedItem.SubItems(10).Text
                        montoAd = Me.ltwAdendas.FocusedItem.SubItems(5).Text
                        obsAd = Me.ltwAdendas.FocusedItem.SubItems(7).Text
                        inttipoAd = Me.ltwAdendas.FocusedItem.SubItems(9).Text
                        fechaadendas = Me.ltwAdendas.FocusedItem.SubItems(8).Text
                        intAdTiempo = Me.ltwAdendas.FocusedItem.SubItems(6).Text
                        swsele = 1

                        Exit For
                    End If

                End If
            Next

        End If

        If swsele = 1 Then

            swAd = 3
            frmmantAdendas.ShowDialog()
        End If

        If swsele = 0 Then
            MsgBox("Debe seleccionar el elemento a Eliminar", MsgBoxStyle.Critical, "Control Proyectos")

        End If
    End Sub



 

    Private Sub ltwAdendas_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ltwAdendas.MouseDoubleClick
        If Me.ltwAdendas.Items.Count > 0 Then
            For i = 0 To Me.ltwAdendas.Items.Count - 1

                If Me.ltwAdendas.Items(i).Selected = True Then
                    texto = Me.ltwAdendas.FocusedItem.SubItems(7).Text
                    Exit For

                End If
            Next
        End If

        If e.Button = Windows.Forms.MouseButtons.Left Then
            frmPopup.TextBox1.Text = ""
            frmPopup.TextBox1.Text = texto
            frmPopup.ShowDialog()
        End If
    End Sub
End Class
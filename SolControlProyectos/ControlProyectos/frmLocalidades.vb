Public Class frmLocalidades

    Private Sub frmLocalidades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ConexionSQL()
            Dim strLocal As New ADODB.Recordset

            strLocal = cntSQL.Execute("select [pro_codigoLocalidad], [pro_descripLocalidad], isnull([pro_Ruta],'') as pro_Ruta from tab_LocalidadesProy")

            Do While Not strLocal.EOF

                Me.cmbxLoc.Items.Add(strLocal.Fields(1).Value)
                strLocal.MoveNext()

            Loop

        Catch ex As Exception
            MsgBox("Error al consultar localidades")
        End Try
    End Sub

    Private Sub btnCanc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCanc.Click
        Application.ExitThread()
    End Sub

    Private Sub btnAcep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAcep.Click
        If Me.cmbxLoc.SelectedItem.ToString <> "" And swChange = 0 Then
            frmExplorer.Show()

        End If

        If Me.cmbxLoc.SelectedItem.ToString <> "" And swChange = 1 Then
            frmExplorer.Text = frmExplorer.Text & " - " & strdescLoc
            Me.Close()

        End If
    End Sub

    Private Sub cmbxLoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbxLoc.SelectedIndexChanged
        strdescLoc = cmbxLoc.SelectedItem
    End Sub
End Class

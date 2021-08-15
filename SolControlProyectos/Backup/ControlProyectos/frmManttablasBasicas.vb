Public Class frmManttablasBasicas
    Public id As Integer = 0
    Private Sub frmManttablasBasicas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TablasSistemas.tab_Sistemas' Puede moverla o quitarla según sea necesario.
        Me.Tab_SistemasTableAdapter.Fill(Me.TablasSistemas.tab_Sistemas)

        tabla = cmbTablas.SelectedValue
        llenardatos()
    End Sub
    Sub llenardatos()
        Try
            ConexionSQL()
            Dim strTB As New ADODB.Recordset

            strTB = cntSQL.Execute("select * from " & tabla & "")
            Me.ltvBasicas.Items.Clear()
            Do While Not strTB.EOF
                Me.ltvBasicas.Items.Add(strTB.Fields(1).Value)

                strTB.MoveNext()
            Loop

        Catch ex As Exception
            MsgBox("Error llenardatos()", MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub

    Private Sub cmbTablas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTablas.SelectedIndexChanged
        If Me.ltvBasicas.Items.Count > 0 Then

            For i = 0 To Me.ltvBasicas.Items.Count - 1

                If Me.ltvBasicas.Items(i).Selected = True Then
                    id = Me.ltvBasicas.FocusedItem.SubItems(1).Text
                    Exit For
                End If
            Next

        End If


    End Sub
End Class
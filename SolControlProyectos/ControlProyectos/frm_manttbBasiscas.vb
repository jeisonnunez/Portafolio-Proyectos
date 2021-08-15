Public Class frm_manttbBasiscas
    Public cerrar As Integer = 0
    Public id As Integer = -1

    Private Sub ToolStripButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton12.Click

        cerrar = 1
        Me.Close()
    End Sub

    Private Sub frm_manttbBasiscas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TablasSistemas.tab_Sistemas' Puede moverla o quitarla según sea necesario.
        Me.Tab_SistemasTableAdapter.Fill(Me.TablasSistemas.tab_Sistemas)
        tabla = cmbTablas.SelectedValue
        llenardatos()
    End Sub

  

    Private Sub ltvBasicas_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ltvBasicas.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ltvBasicas.ContextMenuStrip = ContextMenuStrip1
        Else
            ltvBasicas.ContextMenuStrip = ContextMenuStrip1
        End If
    End Sub

    Private Sub cmbTablas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTablas.SelectedIndexChanged

        If cerrar = 0 Then
            tabla = cmbTablas.SelectedValue
            llenardatos()
        End If
    End Sub
    Sub llenardatos()
        Try
            ConexionSQL()
            Dim strTB As New ADODB.Recordset
            Dim i As Integer = 0
            strTB = cntSQL.Execute("select * from " & tabla & "")
            Me.ltvBasicas.Items.Clear()
            Do While Not strTB.EOF

                Me.ltvBasicas.Items.Add(strTB.Fields(1).Value)
                Me.ltvBasicas.Items(i).SubItems.Add(strTB.Fields(0).Value)
                i += 1

                strTB.MoveNext()
            Loop

        Catch ex As Exception
            MsgBox("Error llenardatos()", MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        frmTablasbasicas.ShowDialog()
    End Sub

    Private Sub AgregarDatosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarDatosToolStripMenuItem.Click
        frmTablasbasicas.ShowDialog()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Try
            Dim preg As String = ""
            Dim campo As String = ""
            Dim descr As String = ""
            If Me.ltvBasicas.Items.Count > 0 Then

                For i = 0 To Me.ltvBasicas.Items.Count - 1

                    If Me.ltvBasicas.Items(i).Selected = True Then
                        id = Me.ltvBasicas.FocusedItem.SubItems(1).Text
                        descr = Me.ltvBasicas.FocusedItem.SubItems(0).Text

                        Exit For
                    End If
                Next

            End If

            If id > 0 Then
                preg = MsgBox("Seguro que desea eliminar el registro " & descr, MsgBoxStyle.YesNo, "Control Proyectos")

                If preg = 6 Then
                    ConexionSQL()
                    Dim strTB As New ADODB.Recordset

                    strTB = cntSQL.Execute("select * from tab_Sistemas where tablareal ='" & tabla & "'")

                    

                    strTB = cntSQL.Execute("select * from " & tabla & " where id ='" & id & "'")

                    If strTB.EOF = False Then
                        cntSQL.Execute("delete from " & tabla & " where id ='" & id & "'")

                    End If
                    ' ConexionSQL()
                    ' cntSQL.Execute("p_Ordenacionidices")
                    MsgBox("Registro Eliminado", MsgBoxStyle.Information, "Control Proyectos")
                    Me.llenardatos()

                Else
                    Exit Sub
                End If
            Else
                MsgBox("Debe seleccionar un registro a eliminar", MsgBoxStyle.Critical, "Control Proyectos")
            End If
           

        Catch ex As Exception
            MsgBox("Error en funcion ToolStripButton4" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")

        End Try


    End Sub

    Private Sub ltvBasicas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ltvBasicas.SelectedIndexChanged
        'If Me.ltvBasicas.Items.Count > 0 Then

        '    For i = 0 To Me.ltvBasicas.Items.Count - 1

        '        If Me.ltvBasicas.Items(i).Selected = True Then
        '            id = Me.ltvBasicas.FocusedItem.SubItems(1).Text
        '            Exit For
        '        End If
        '    Next

        'End If



    End Sub

    Private Sub EliminarDatosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarDatosToolStripMenuItem.Click
        Try
            Dim preg As String = ""
            Dim campo As String = ""
            Dim descr As String = ""
            If Me.ltvBasicas.Items.Count > 0 Then

                For i = 0 To Me.ltvBasicas.Items.Count - 1

                    If Me.ltvBasicas.Items(i).Selected = True Then
                        id = Me.ltvBasicas.FocusedItem.SubItems(1).Text
                        descr = Me.ltvBasicas.FocusedItem.SubItems(0).Text

                        Exit For
                    End If
                Next

            End If

            If id > 0 Then
                preg = MsgBox("Seguro que desea eliminar el registro " & descr, MsgBoxStyle.YesNo, "Control Proyectos")

                If preg = 6 Then
                    ConexionSQL()
                    Dim strTB As New ADODB.Recordset

                    strTB = cntSQL.Execute("select * from tab_Sistemas where tablareal ='" & tabla & "'")



                    strTB = cntSQL.Execute("select * from " & tabla & " where id ='" & id & "'")

                    If strTB.EOF = False Then
                        cntSQL.Execute("delete from " & tabla & " where id ='" & id & "'")

                    End If
                    MsgBox("Registro Eliminado", MsgBoxStyle.Information, "Control Proyectos")
                    Me.llenardatos()

                Else
                    Exit Sub
                End If
            Else
                MsgBox("Debe seleccionar un registro a eliminar", MsgBoxStyle.Critical, "Control Proyectos")
            End If


        Catch ex As Exception
            MsgBox("Error en funcion ToolStripButton4", MsgBoxStyle.Critical, "Control Proyectos")

        End Try
       
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Try
            Dim preg As String = ""
            Dim campo As String = ""

            modTb = 0
            If Me.ltvBasicas.Items.Count > 0 Then

                For i = 0 To Me.ltvBasicas.Items.Count - 1

                    If Me.ltvBasicas.Items(i).Selected = True Then
                        id = Me.ltvBasicas.FocusedItem.SubItems(1).Text
                        descr = Me.ltvBasicas.FocusedItem.SubItems(0).Text

                        Exit For
                    End If
                Next

            End If

            If id > 0 Then
                preg = MsgBox("Seguro que desea modificar el registro " & descr, MsgBoxStyle.YesNo, "Control Proyectos")

                If preg = 6 Then
                    modTb = 1
                    frmTablasbasicas.tbxDato.Text = descr
                    frmTablasbasicas.ShowDialog()
                  

                Else
                    Exit Sub
                End If
            Else
                MsgBox("Debe seleccionar un registro", MsgBoxStyle.Critical, "Control Proyectos")
            End If


        Catch ex As Exception
            MsgBox("Error en funcion ToolStripButton4" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")

        End Try


    End Sub
End Class
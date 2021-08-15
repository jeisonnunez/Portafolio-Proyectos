Public Class frmcarteraT

    Private Sub frmcarteraT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DtCliente.tab_ClienteProy' Puede moverla o quitarla según sea necesario.
        Me.Tab_ClienteProyTableAdapter.Fill(Me.DtCliente.tab_ClienteProy)
       
        llenarComboSector()
    End Sub

    Private Sub chkAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAll.CheckedChanged
        If chkAll.Checked = True Then

            strall = ""
            Me.cmbGrupo.Text = ""
            Me.cmbGrupo.Enabled = False
            'Me.tbxAno.Enabled = False
        End If

        If chkAll.Checked = False Then
            Me.cmbGrupo.Enabled = True
            Me.cmbGrupo.Text = "Seleccione"
            strall = Me.cmbGrupo.SelectedItem

        End If
    End Sub

    Private Sub chkSt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSt.CheckedChanged
        If chkSt.Checked = True Then
            status = ""
            tbxCodCli.Text = ""
            tbxCodCli.Enabled = False
            'Me.tbxAno.Enabled = False
        End If

        If chkSt.Checked = False Then
            tbxCodCli.Enabled = True
            tbxCodCli.Text = ""
            status = strCodCli

        End If
    End Sub

    Private Sub btnAcep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAcep.Click
        If Me.tbxCodCli.Text <> "" Then
            status = strCodCli
        Else
            status = ""
        End If

        If Me.cmbGrupo.Text <> "Seleccione" Then

            If swRpts = 1 Then
                Dim frm As New frmProcess
                frm.Show()
                For x As Int32 = 0 To 1


                    f24 = frmReportView
                    f24.Show()

                    swF = 0

                    Exit For
                    Application.DoEvents()
                Next
                frm.Close()
            End If
            Me.Close()

        End If
    End Sub

    Private Sub btnCanc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCanc.Click
        Me.Close()
    End Sub
    Sub llenarComboSector()
        Try
            ConexionSQL()
            Dim strSector As New ADODB.Recordset
            Me.cmbGrupo.Items.Clear()

            strSector = cntSQL.Execute("SELECT  des_Sector FROM [dbo].[tab_Sector]")

            Do While Not strSector.EOF
                Me.cmbGrupo.Items.Add(strSector.Fields(0).Value)

                strSector.MoveNext()
            Loop


        Catch ex As Exception
            MsgBox("Error en funcion llenarComboSector" & ex.Message)
        End Try
    End Sub

    Private Sub cmbGrupo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGrupo.SelectedIndexChanged
        strall = Me.cmbGrupo.SelectedItem
    End Sub

  

    Private Sub tbxCodCli_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxCodCli.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            strMenu = "10"
            strCodCli = Me.tbxCodCli.Text
            btnBuscar_Click(1, Nothing)
            If swMen = 1 Then

            Else
                Me.tbxCodCli.SelectAll()
            End If

        End If
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        strMenu = "10"
        frmSubmenup.ShowDialog()
    End Sub
End Class
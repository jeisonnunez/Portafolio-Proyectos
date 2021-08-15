Public Class frmrptHistoricoProy

    Private Sub frmrptHistoricoProy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dtHistoricoProy._dtHistoricoProy' Puede moverla o quitarla según sea necesario.
        Me.DtHistoricoProyTableAdapter.Fill(Me.dtHistoricoProy._dtHistoricoProy)

        Me.rpvView.RefreshReport()
        Me.rpvView.RefreshReport()
    End Sub
End Class
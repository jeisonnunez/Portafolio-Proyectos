
Imports Microsoft.Reporting.WinForms
Public Class frmReportResum
 
    Private Sub frmReportResum_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try



           
            Me.Text = "Historicos Proyectos"
            Me.rpvReport2.Visible = True
            rpvReport2.LocalReport.ReportEmbeddedResource = ""
            Me.dtHistoricoProyTableAdapter.Fill(Me.dtHistoricoProy._dtHistoricoProy)
            rpvReport2.LocalReport.ReportEmbeddedResource = "ControlProyectos.rptProyectosHistoricos.rdlc"
            Me.rpvReport2.RefreshReport()




        Catch ex As Exception

        End Try
    End Sub
End Class


Imports Microsoft.Reporting.WinForms
Public Class frmReportResumm

    Private Sub frmReportResum_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try



            ' swRpts = 2
            If swRpts = 2 Then
                Me.rpvReport1.Visible = True
                rpvReport1.LocalReport.ReportEmbeddedResource = ""
                Me.P_EstimacionCobrosxtramites_ResumenTableAdapter.Fill(Me.DtSp.p_EstimacionCobrosxtramites_Resumen, fechaRes, sectorRes, statusRes, intPorFecha)
                rpvReport1.LocalReport.ReportEmbeddedResource = "ControlProyectos.EstCobrosResumen.rdlc"
                Me.rpvReport1.RefreshReport()
          
            End If



        Catch ex As Exception

        End Try
    End Sub
End Class

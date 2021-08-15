Imports Microsoft.Reporting.WinForms
Public Class frmReportView
    Public Mes As Integer = 0


    Private Sub frmReportView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            'swRpts = 5
            'repMes = True
            '//////////////////////////////////////////////////////////////////////////////
            'la logica para que no se vean es si esta en true NO se veran
            If repMes = True Then
                Mes = Month(Date.Now)                ' Mes = 1

                repP = False
                repS = False
                repT = False
                repC = False

            Else
                'muestra de trimestres en cascada
                If repC = True Then
                    repP = True
                    repS = True
                    repT = True
                End If

                If repT = True Then
                    repP = True
                    repS = True
                End If

                If repS = True Then
                    repP = True
                End If

            End If



            Dim Ptrimestre As New ReportParameter("Ptrimestre", repP)
            Dim Strimestre As New ReportParameter("Strimestre", repS)
            Dim Ttrimestre As New ReportParameter("Ttrimestre", repT)
            Dim Ctrimestre As New ReportParameter("Ctrimestre", repC)
            Dim Cmes As New ReportParameter("Cmes", Mes)


            'se miden los periodos por: 

            '1-. Ptrimestre, 
            '2.- SegundoTrimestre, 
            '3.- Tercer Trimestre, 
            '4.- Trimestre, 
            '5:- Mes actual

            If repP = True Then
                intPor = 1
            End If

            If repS = True Then
                intPor = 2
            End If

            If repT = True Then
                intPor = 3
            End If

            If repC = True Then
                intPor = 4
            End If

            If repMes = True Then
                intPor = 5
            End If

            'Parametros Internos

            '////////////////////////////////////////////////////////////////////////////
            Dim NroContrato As New ReportParameter("NroContrato", repNC)
            Dim FechaFact As New ReportParameter("FechaFact", repFecFac)
            Dim CuentaNro As New ReportParameter("CuentaNro", repCnro)
            Dim Statusinf As New ReportParameter("StatusInf", repStatus)
            Dim NroRecibo As New ReportParameter("NroRecibo", repNroRec)
            Dim NroProye As New ReportParameter("NroProye", repNroProye)
            Dim Ano As New ReportParameter("Ano", dano)
            Dim Seleccion As New ReportParameter("Seleccion", selecP)

            Me.rpvReport1.Visible = False
            Me.rpvReport2.Visible = False
            Me.rpvReport3.Visible = False
            Me.rpvReport4.Visible = False

            'cartera total

            If swRpts = 1 Then

                Me.rpvReport.Visible = True
                Me.P_Carteratotalc_sReciboTableAdapter.Fill(Me.dtSp.p_Carteratotalc_sRecibo, strall, status)
                rpvReport.LocalReport.ReportEmbeddedResource = "ControlProyectos.rptCarteraTotal.rdlc"

            End If



            'CONSOLIDADO
            If swRpts = 5 Then
                Me.rpvReport4.Visible = True

                Me.P_EstimacionCobrosxtramites_AllTableAdapter.Fill(Me.dtSp.p_EstimacionCobrosxtramites_All, f20.tbxAno.Text, strall, repCnro, intPorFecha, intPor)
                rpvReport4.LocalReport.ReportEmbeddedResource = "ControlProyectos.rptConsolidado.rdlc"
                Me.rpvReport4.LocalReport.SetParameters(New ReportParameter() {Ptrimestre, Strimestre, Ttrimestre, Ctrimestre, Cmes, NroContrato, FechaFact, CuentaNro, Statusinf, NroRecibo, NroProye, Ano, Seleccion})
                Me.rpvReport4.RefreshReport()


            End If


        Catch ex As Exception

        End Try
        
        If Me.rpvReport.Visible = True Then
            Me.rpvReport.RefreshReport()
        End If


        If Me.rpvReport1.Visible = True Then
            Me.rpvReport1.RefreshReport()
        End If

        If Me.rpvReport2.Visible = True Then
            Me.rpvReport2.RefreshReport()
        End If

        If Me.rpvReport3.Visible = True Then
            Me.rpvReport3.RefreshReport()
        End If

        If Me.rpvReport4.Visible = True Then
            Me.rpvReport4.RefreshReport()
        End If
    End Sub
End Class
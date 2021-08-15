Public Class frmParamadicRpts

   

    Private Sub btnCanc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCanc.Click
        Me.Close()
    End Sub

    Private Sub btnAcep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAcep.Click

        If Me.RadioButton1.Checked = True Or Me.RadioButton2.Checked = True Or Me.RadioButton3.Checked = True Or Me.RadioButton4.Checked = True Or Me.RadioButton5.Checked = True Then

            f24 = frmReportView

            f24.Show()

            ' Me.Hide()

        Else

            MsgBox("Debe seleccionar un trimestre", MsgBoxStyle.Critical, "Control Proyectos")
        End If

    
    End Sub

    Private Sub frmParamadicRpts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If swRpts = 5 Then
            gbpgrupo2.Enabled = True
        Else
            gbpgrupo2.Enabled = False
        End If

        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton5.Checked = False

        chkall.Checked = False
        chk1.Checked = False
        chk2.Checked = False
        chk3.Checked = False
        chk4.Checked = False
        chk5.Checked = False


        repP = False
        repS = False
        repT = False
        repC = False
        repAll = 0
        repDet = 0

        repNC = 0
        repFecFac = 0
        repCnro = 0
        repStatus = 0
        repNroRec = 0
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If Me.RadioButton1.Checked = True Then
            repP = True
        Else
            repP = False

        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If Me.RadioButton2.Checked = True Then
            repS = True
        Else
            repS = False

        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If Me.RadioButton3.Checked = True Then
            repT = True
        Else
            repT = False

        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If Me.RadioButton4.Checked = True Then
            repC = True
        Else
            repC = False

        End If
    End Sub

 

    Private Sub chk1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk1.CheckedChanged
        If chk1.Checked = True Then
            repNC = 1
        Else
            repNC = 0
        End If
    End Sub

    Private Sub chk2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk2.CheckedChanged
        If chk2.Checked = True Then
            repFecFac = 1
        Else
            repFecFac = 0
        End If
    End Sub

    Private Sub chk3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk3.CheckedChanged
        If chk3.Checked = True Then
            repCnro = 1
        Else
            repCnro = 0
        End If
    End Sub

    Private Sub chk4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk4.CheckedChanged
        If chk4.Checked = True Then
            repStatus = 1
        Else
            repStatus = 0
        End If
    End Sub

    Private Sub chk5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk5.CheckedChanged
        If chk5.Checked = True Then
            repNroRec = 1
        Else
            repNroRec = 0
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = True Then
            repMes = True
        Else
            repMes = False
        End If
    End Sub

    Private Sub chkall_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkall.CheckedChanged
        If chkall.Checked = True Then
            repNroRec = 1
            repStatus = 1
            repCnro = 1
            repFecFac = 1
            repNC = 1


            chk1.Checked = True
            chk2.Checked = True
            chk3.Checked = True
            chk4.Checked = True
            chk5.Checked = True
            chk6.Checked = True
        Else
            chk1.Checked = False
            chk2.Checked = False
            chk3.Checked = False
            chk4.Checked = False
            chk5.Checked = False
            chk6.Checked = False

            repNroRec = 0
            repStatus = 0
            repCnro = 0
            repFecFac = 0
            repNC = 0
            repNroProye = 0
        End If
    End Sub

    
    Private Sub chk6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk6.CheckedChanged
        If chk6.Checked = True Then
            repNroProye = 1
        Else
            repNroProye = 0
        End If
    End Sub
End Class
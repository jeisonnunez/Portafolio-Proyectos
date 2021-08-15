Public Class Form1


    Private Sub DateTimePicker1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DateTimePicker1.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            e.Handled = True

            MsgBox("asdasd" & Me.DateTimePicker1.Value, MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub DateTimePicker1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.Leave
        MsgBox("asdasd" & Me.DateTimePicker1.Value, MsgBoxStyle.Critical)
    End Sub

  

   

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        Dim dia As Integer = 0
        If dia >= 1 Or dia <= 31 Then

            Me.DateTimePicker1.Value.Month.ToString()
        End If

    End Sub
End Class
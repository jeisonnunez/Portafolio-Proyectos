Public Class frmProydatosppal

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        f1.close()
    End Sub

    Private Sub frmProydatosppal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSig.Click
        If EstaAbierto(f2) Then
            f2.Close()
        End If


        'f.Size = New Size(Me.SplitContainer3.Panel2.Size.Width / 2, Me.SplitContainer3.Panel2.Size.Height / 2)
        f2.Top = (frmExplorer.SplitContainer.Panel2.Height / 2) - (f2.Height / 2)
        f2.Left = (frmExplorer.SplitContainer.Panel2.Width / 2) - (f2.Width / 2)

        f2.TopLevel = False

        f2.WindowState = FormWindowState.Maximized
        f2.Parent = frmExplorer.SplitContainer.Panel2
        f2.Dock = DockStyle.None

        frmExplorer.SplitContainer.Panel2.Controls.Add(f2)
        f2.Show()
        f1.Close()
    End Sub
End Class
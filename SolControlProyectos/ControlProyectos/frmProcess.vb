Imports System.Drawing

Public Class frmProcess
    Dim animatedImage As Image = Image.FromFile(My.Application.Info.DirectoryPath & "\process.gif")
    Dim anima As System.Drawing.ImageAnimator
    Private currentlyAnimating As Boolean = False

    Public Sub AnimateImage()
        If Not currentlyAnimating Then
            ImageAnimator.Animate(animatedImage, New EventHandler(AddressOf Me.OnFrameChanged))
            currentlyAnimating = True
        End If
    End Sub

    Private Sub OnFrameChanged(ByVal o As Object, ByVal e As EventArgs)
        Me.Invalidate()
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)

        AnimateImage()
        ImageAnimator.UpdateFrames()

        e.Graphics.DrawImage(Me.animatedImage, New Point(5, 5))
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ControlBox = False
    End Sub

  


    Private Sub lblCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
End Class
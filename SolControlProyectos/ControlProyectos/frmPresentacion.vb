Imports System.Threading

Public NotInheritable Class frmPresentacion

    'TODO: Este formulario se puede establecer fácilmente como pantalla de bienvenida para la aplicación desde la ficha "Aplicación"
    '  del Diseñador de proyectos ("Propiedades" bajo el menú "Proyecto").


    Private Sub frmPresentacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Configure el texto del cuadro de diálogo en tiempo de ejecución según la información del ensamblado de la aplicación.  

        'TODO: Personalice la información del ensamblado de la aplicación en el panel "Aplicación" del cuadro de diálogo 
        '  propiedades del proyecto (bajo el menú "Proyecto").

        'Título de la aplicación
        If My.Application.Info.Title <> "" Then
            'ApplicationTitle.Text = My.Application.Info.Title
        Else
            'Si falta el título de la aplicación, utilice el nombre de la aplicación sin la extensión
            ' ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If


        Timer1.Enabled = True

        For FadeIn = 0.0 To 1.1 Step 0.1
            Me.Opacity = FadeIn
            Me.Refresh()
            Thread.Sleep(80)
        Next
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try

     

            For contador = 80 To 10 Step -10
                Me.Opacity = contador / 100
                Me.Refresh()
                Thread.Sleep(70)
            Next


            If sinConex = 0 Then
                ExtraerRutaConex()
                Me.Hide()
                Timer1.Enabled = False
            End If


            If sinConex = 1 Then
                Timer1.Stop()
                MsgBox("Error en funcion extraer ruta" & errorconex, MsgBoxStyle.Critical, "Control Proyectos")
                Application.ExitThread()
            End If
        Catch ex As Exception
            MsgBox("Error en funcion extraer ruta" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub



   
    Private Sub pictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pictureBox.Click

    End Sub
End Class
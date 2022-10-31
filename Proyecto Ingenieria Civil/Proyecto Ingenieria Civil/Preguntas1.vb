Public Class Preguntas1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If RadioButton6.Checked Then
            puntaje = puntaje + 4
        End If
        If RadioButton7.Checked Then
            puntaje = puntaje + 3
        End If
        If RadioButton8.Checked Then
            puntaje = puntaje + 3
        End If
        If RadioButton9.Checked Then
            puntaje = puntaje + 2
        End If
        If RadioButton10.Checked Then
            puntaje = puntaje + 1
        End If

        If RadioButton11.Checked Then
            puntaje = puntaje + 0
        End If
        If RadioButton12.Checked Then
            puntaje = puntaje + 3
        End If

        If RadioButton20.Checked Then
            puntaje = puntaje + 2
        End If
        If RadioButton21.Checked Then
            puntaje = puntaje + 1
        End If

        If RadioButton22.Checked Then
            puntaje = puntaje + 2
        End If
        If RadioButton23.Checked Then
            puntaje = puntaje + 1
        End If
        If RadioButton24.Checked Then
            puntaje = puntaje + 2
        End If

        Me.Hide()
        Preguntas2.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub BtnSubir_Click(sender As Object, e As EventArgs) Handles BtnSubir.Click
        If OfdSeleccionarImagen.ShowDialog = DialogResult.OK Then
            PicMostrarImagen.Image = Image.FromFile(OfdSeleccionarImagen.FileName)
            Me.Text = "aaaa(" & OfdSeleccionarImagen.FileName & ")"

        End If
    End Sub

    Private Sub PicMostrarImagen_Click(sender As Object, e As EventArgs) Handles PicMostrarImagen.Click

    End Sub

    Private Sub OfdSeleccionarImagen_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OfdSeleccionarImagen.FileOk

    End Sub
End Class

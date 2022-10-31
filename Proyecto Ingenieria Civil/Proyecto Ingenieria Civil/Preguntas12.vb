Public Class Preguntas12
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Preguntas13.Show()
    End Sub

    Private Sub BtnSubir_Click(sender As Object, e As EventArgs) Handles BtnSubir1.Click
        If OfdSeleccionarImagen1.ShowDialog = DialogResult.OK Then
            PicMostrarImagen1.Image = Image.FromFile(OfdSeleccionarImagen1.FileName)
            Me.Text = "aaaa(" & OfdSeleccionarImagen1.FileName & ")"

        End If
    End Sub

    Private Sub BtnSubir2_Click(sender As Object, e As EventArgs) Handles BtnSubir2.Click
        If OfdSeleccionarImagen2.ShowDialog = DialogResult.OK Then
            PicMostrarImagen2.Image = Image.FromFile(OfdSeleccionarImagen2.FileName)
            Me.Text = "aaaa(" & OfdSeleccionarImagen2.FileName & ")"

        End If
    End Sub
End Class
Public Class Preguntas14
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Preguntas15.Show()
    End Sub

    Private Sub BtnSubir14_Click(sender As Object, e As EventArgs) Handles BtnSubir14.Click
        If OfdSeleccionarImagen14.ShowDialog = DialogResult.OK Then
            PicMostrarImagen14.Image = Image.FromFile(OfdSeleccionarImagen14.FileName)
            Me.Text = "aaaa(" & OfdSeleccionarImagen14.FileName & ")"

        End If
    End Sub

    Private Sub PicMostrarImagen14_Click(sender As Object, e As EventArgs) Handles PicMostrarImagen14.Click

    End Sub

    Private Sub OfdSeleccionarImagen14_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OfdSeleccionarImagen14.FileOk

    End Sub

    Private Sub BotonSubir141_Click(sender As Object, e As EventArgs) Handles BotonSubir141.Click
        If OfdSeleccionarImagen141.ShowDialog = DialogResult.OK Then
            PicMostrarImagen141.Image = Image.FromFile(OfdSeleccionarImagen141.FileName)
            Me.Text = "aaaa(" & OfdSeleccionarImagen141.FileName & ")"

        End If
    End Sub
End Class
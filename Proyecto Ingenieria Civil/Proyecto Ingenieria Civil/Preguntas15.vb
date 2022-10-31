Public Class Preguntas15
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LabelPuntaje.Click

    End Sub

    Private Sub Preguntas15_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        LabelPuntaje.Text = "Tu puntaje es " + puntaje.ToString + " punto(s)."

    End Sub

End Class
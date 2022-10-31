Public Class Preguntas13
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then
            puntaje = puntaje + 3
        End If
        If RadioButton2.Checked Then
            puntaje = puntaje + 0
        End If

        Me.Hide()
        If RadioButton1.Checked = True Then Preguntas14.Show() Else Preguntas15.Show()
    End Sub
End Class
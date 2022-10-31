Public Class Preguntas2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then
            puntaje = puntaje
        End If
        If RadioButton2.Checked Then
            puntaje = puntaje + 1
        End If
        If RadioButton3.Checked Then
            puntaje = puntaje + 2
        End If
        If RadioButton4.Checked Then
            puntaje = puntaje + 2
        End If
        If RadioButton5.Checked Then
            puntaje = puntaje + 3
        End If
        If RadioButton6.Checked Then
            puntaje = puntaje + 3
        End If
        If RadioButton7.Checked Then
            puntaje = puntaje + 2
        End If
        If RadioButton8.Checked Then
            puntaje = puntaje + 4
        End If
        If RadioButton9.Checked Then
            puntaje = puntaje + 2
        End If
        If RadioButton10.Checked Then
            puntaje = puntaje
        End If

        Me.Hide()
        If RadioButton11.Checked = True Then Preguntas3.Show() Else Preguntas4.Show()
    End Sub
End Class
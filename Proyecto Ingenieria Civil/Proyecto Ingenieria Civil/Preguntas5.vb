Public Class Preguntas5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then
            puntaje = 1
        End If
        If RadioButton2.Checked Then
            puntaje = puntaje + 2
        End If
        If RadioButton3.Checked Then
            puntaje = puntaje + 3
        End If
        If RadioButton4.Checked Then
            puntaje = puntaje + 3
        End If

        If RadioButton5.Checked Then
            puntaje = puntaje + 2
        End If
        If RadioButton6.Checked Then
            puntaje = puntaje + 1
        End If
        If RadioButton7.Checked Then
            puntaje = puntaje + 2
        End If
        If RadioButton8.Checked Then
            puntaje = puntaje + 1
        End If
        If RadioButton9.Checked Then
            puntaje = puntaje + 2
        End If
        If RadioButton10.Checked Then
            puntaje = puntaje + 3
        End If
        If RadioButton11.Checked Then
            puntaje = puntaje + 3
        End If
        If RadioButton12.Checked Then
            puntaje = puntaje + 3
        End If
        If RadioButton13.Checked Then
            puntaje = puntaje
        End If

        Me.Hide()
        If RadioButton5.Checked = True Then Preguntas6.Show() Else
        If RadioButton6.Checked = True Then Preguntas7.Show() Else
        If RadioButton7.Checked = True Then Preguntas8.Show() Else
        Preguntas9.Show()

    End Sub
End Class
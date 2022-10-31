Public Class Preguntas11
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then
            puntaje = puntaje + 4
        End If
        If RadioButton2.Checked Then
            puntaje = puntaje + 0
        End If

        Me.Hide()
        If RadioButton1.Checked = True Then Preguntas12.Show() Else Preguntas13.Show()
    End Sub

    Private Sub Preguntas11_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
﻿Public Class Preguntas6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then
            puntaje = puntaje + 1
        End If
        If RadioButton2.Checked Then
            puntaje = puntaje + 1
        End If
        If RadioButton3.Checked Then
            puntaje = puntaje + 1
        End If

        Me.Hide()
        Preguntas9.Show()
    End Sub
End Class
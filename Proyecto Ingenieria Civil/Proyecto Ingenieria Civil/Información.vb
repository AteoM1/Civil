Public Class Información
    Private Sub Celular_KeyPress(sender As Object, e As KeyPressEventArgs) 
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo Puede digitar numeros")
        End If
    End Sub
    Private Sub Cedula_KeyPress(sender As Object, e As KeyPressEventArgs) 
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo Puede digitar numeros")
        End If
    End Sub

    Private Sub Información_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Bases_de_datosDataSet.Tabla1' Puede moverla o quitarla según sea necesario.
        Me.Tabla1TableAdapter.Fill(Me.Bases_de_datosDataSet.Tabla1)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Preguntas1.Show()
    End Sub

    Private Sub Tabla1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tabla1BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tabla1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Bases_de_datosDataSet)

    End Sub

    Private Sub _Autorizo_el_tratamiento_de_mis_datos__CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles _Autorizo_el_tratamiento_de_mis_datos__CheckBox.CheckedChanged

    End Sub

    Private Sub IdTextBox_TextChanged(sender As Object, e As EventArgs) Handles IdTextBox.TextChanged

    End Sub

    Private Sub Nombre_Label_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Nombre_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Nombre_TextBox.TextChanged

    End Sub

    Private Sub Apellidos_Label_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Apellidos_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Apellidos_TextBox.TextChanged

    End Sub

    Private Sub Celular_Label_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Celular_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Celular_TextBox.TextChanged

    End Sub

    Private Sub Correo_Label_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Correo_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Correo_TextBox.TextChanged

    End Sub

    Private Sub Cédula_Label_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Cédula_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Cédula_TextBox.TextChanged

    End Sub

    Private Sub Dirección_Label_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Dirección_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Dirección_TextBox.TextChanged

    End Sub

    Private Sub Nombre_de_la_unidad_Label_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Nombre_de_la_unidad_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Nombre_de_la_unidad_TextBox.TextChanged

    End Sub

    Private Sub Departamento_Label_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Departamento_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Departamento_TextBox.TextChanged

    End Sub

    Private Sub Municipio_Label_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Municipio_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Municipio_TextBox.TextChanged

    End Sub

    Private Sub Barrio_Label_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Barrio_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Barrio_TextBox.TextChanged

    End Sub

    Private Sub _Autorizo_el_tratamiento_de_mis_datos__Label_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub IdLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Hide()
        Preguntas1.Show()
    End Sub
End Class
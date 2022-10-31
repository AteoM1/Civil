<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Preguntas12
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BtnSubir2 = New System.Windows.Forms.Button()
        Me.BtnSubir1 = New System.Windows.Forms.Button()
        Me.PicMostrarImagen1 = New System.Windows.Forms.PictureBox()
        Me.PicMostrarImagen2 = New System.Windows.Forms.PictureBox()
        Me.OfdSeleccionarImagen1 = New System.Windows.Forms.OpenFileDialog()
        Me.OfdSeleccionarImagen2 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PicMostrarImagen1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicMostrarImagen2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(390, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(294, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Por favor sube una foto de la lejana al hundimiento horizontal"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(32, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(294, 42)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Por favor sube una foto a la cercana con algún objeto con el que se pueda dimensi" &
    "onar (como por ejemplo un lapiz o un cuaderno cercano al hundimiento)"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(578, 291)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Continuar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'BtnSubir2
        '
        Me.BtnSubir2.Location = New System.Drawing.Point(493, 34)
        Me.BtnSubir2.Name = "BtnSubir2"
        Me.BtnSubir2.Size = New System.Drawing.Size(75, 23)
        Me.BtnSubir2.TabIndex = 5
        Me.BtnSubir2.Text = "Subir imagen"
        Me.BtnSubir2.UseVisualStyleBackColor = True
        '
        'BtnSubir1
        '
        Me.BtnSubir1.Location = New System.Drawing.Point(135, 60)
        Me.BtnSubir1.Name = "BtnSubir1"
        Me.BtnSubir1.Size = New System.Drawing.Size(75, 23)
        Me.BtnSubir1.TabIndex = 6
        Me.BtnSubir1.Text = "Subir imagen"
        Me.BtnSubir1.UseVisualStyleBackColor = True
        '
        'PicMostrarImagen1
        '
        Me.PicMostrarImagen1.Location = New System.Drawing.Point(47, 89)
        Me.PicMostrarImagen1.Name = "PicMostrarImagen1"
        Me.PicMostrarImagen1.Size = New System.Drawing.Size(249, 171)
        Me.PicMostrarImagen1.TabIndex = 7
        Me.PicMostrarImagen1.TabStop = False
        '
        'PicMostrarImagen2
        '
        Me.PicMostrarImagen2.Location = New System.Drawing.Point(393, 60)
        Me.PicMostrarImagen2.Name = "PicMostrarImagen2"
        Me.PicMostrarImagen2.Size = New System.Drawing.Size(249, 171)
        Me.PicMostrarImagen2.TabIndex = 8
        Me.PicMostrarImagen2.TabStop = False
        '
        'OfdSeleccionarImagen1
        '
        Me.OfdSeleccionarImagen1.FileName = "OfdSeleccionarImagen1"
        '
        'OfdSeleccionarImagen2
        '
        Me.OfdSeleccionarImagen2.FileName = "OfdSeleccionarImagen2"
        '
        'Preguntas12
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(696, 338)
        Me.Controls.Add(Me.PicMostrarImagen2)
        Me.Controls.Add(Me.PicMostrarImagen1)
        Me.Controls.Add(Me.BtnSubir1)
        Me.Controls.Add(Me.BtnSubir2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Preguntas12"
        Me.Text = "Pagina 12 de preguntas"
        CType(Me.PicMostrarImagen1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicMostrarImagen2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents BtnSubir2 As Button
    Friend WithEvents BtnSubir1 As Button
    Friend WithEvents PicMostrarImagen1 As PictureBox
    Friend WithEvents PicMostrarImagen2 As PictureBox
    Friend WithEvents OfdSeleccionarImagen1 As OpenFileDialog
    Friend WithEvents OfdSeleccionarImagen2 As OpenFileDialog
End Class

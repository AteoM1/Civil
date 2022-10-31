<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Preguntas14
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BtnSubir14 = New System.Windows.Forms.Button()
        Me.BotonSubir141 = New System.Windows.Forms.Button()
        Me.PicMostrarImagen14 = New System.Windows.Forms.PictureBox()
        Me.PicMostrarImagen141 = New System.Windows.Forms.PictureBox()
        Me.OfdSeleccionarImagen14 = New System.Windows.Forms.OpenFileDialog()
        Me.OfdSeleccionarImagen141 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PicMostrarImagen14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicMostrarImagen141, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Por favor sube una foto de la lejana a la grieta" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(442, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(352, 56)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Por favor sube una foto a la cercana con algún objeto con el que se pueda dimensi" &
    "onar (como por ejemplo un lapiz o un cuaderno al lado de la grieta)"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(396, 321)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Continuar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'BtnSubir14
        '
        Me.BtnSubir14.Location = New System.Drawing.Point(109, 46)
        Me.BtnSubir14.Name = "BtnSubir14"
        Me.BtnSubir14.Size = New System.Drawing.Size(75, 23)
        Me.BtnSubir14.TabIndex = 5
        Me.BtnSubir14.Text = "Subir imagen"
        Me.BtnSubir14.UseVisualStyleBackColor = True
        '
        'BotonSubir141
        '
        Me.BotonSubir141.Location = New System.Drawing.Point(588, 62)
        Me.BotonSubir141.Name = "BotonSubir141"
        Me.BotonSubir141.Size = New System.Drawing.Size(75, 23)
        Me.BotonSubir141.TabIndex = 6
        Me.BotonSubir141.Text = "Subir imagen"
        Me.BotonSubir141.UseVisualStyleBackColor = True
        '
        'PicMostrarImagen14
        '
        Me.PicMostrarImagen14.Location = New System.Drawing.Point(23, 84)
        Me.PicMostrarImagen14.Name = "PicMostrarImagen14"
        Me.PicMostrarImagen14.Size = New System.Drawing.Size(252, 169)
        Me.PicMostrarImagen14.TabIndex = 7
        Me.PicMostrarImagen14.TabStop = False
        '
        'PicMostrarImagen141
        '
        Me.PicMostrarImagen141.Location = New System.Drawing.Point(497, 106)
        Me.PicMostrarImagen141.Name = "PicMostrarImagen141"
        Me.PicMostrarImagen141.Size = New System.Drawing.Size(252, 169)
        Me.PicMostrarImagen141.TabIndex = 8
        Me.PicMostrarImagen141.TabStop = False
        '
        'OfdSeleccionarImagen14
        '
        Me.OfdSeleccionarImagen14.FileName = "OfdSeleccionarImagen14"
        '
        'OfdSeleccionarImagen141
        '
        Me.OfdSeleccionarImagen141.FileName = "OfdSeleccionarImagen141"
        '
        'Preguntas14
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(854, 356)
        Me.Controls.Add(Me.PicMostrarImagen141)
        Me.Controls.Add(Me.PicMostrarImagen14)
        Me.Controls.Add(Me.BotonSubir141)
        Me.Controls.Add(Me.BtnSubir14)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Preguntas14"
        Me.Text = "Pagina 14 de preguntas"
        CType(Me.PicMostrarImagen14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicMostrarImagen141, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents BtnSubir14 As Button
    Friend WithEvents BotonSubir141 As Button
    Friend WithEvents PicMostrarImagen14 As PictureBox
    Friend WithEvents PicMostrarImagen141 As PictureBox
    Friend WithEvents OfdSeleccionarImagen14 As OpenFileDialog
    Friend WithEvents OfdSeleccionarImagen141 As OpenFileDialog
End Class

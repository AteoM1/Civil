<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Preguntas15
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
        Me.LabelPuntaje = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabelPuntaje
        '
        Me.LabelPuntaje.AutoSize = True
        Me.LabelPuntaje.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPuntaje.Location = New System.Drawing.Point(63, 62)
        Me.LabelPuntaje.Name = "LabelPuntaje"
        Me.LabelPuntaje.Size = New System.Drawing.Size(82, 25)
        Me.LabelPuntaje.TabIndex = 0
        Me.LabelPuntaje.Text = "Label1"
        '
        'Preguntas15
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(401, 191)
        Me.Controls.Add(Me.LabelPuntaje)
        Me.Name = "Preguntas15"
        Me.Text = "Resultado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelPuntaje As Label
End Class

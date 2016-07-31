<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxComedia = New System.Windows.Forms.CheckBox()
        Me.cbxDrama = New System.Windows.Forms.CheckBox()
        Me.cbxRomance = New System.Windows.Forms.CheckBox()
        Me.cbxSuspenso = New System.Windows.Forms.CheckBox()
        Me.cbxAccion = New System.Windows.Forms.CheckBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.lstPeliculas = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Que prliculas te gustan más?"
        '
        'cbxComedia
        '
        Me.cbxComedia.AutoSize = True
        Me.cbxComedia.Location = New System.Drawing.Point(15, 34)
        Me.cbxComedia.Name = "cbxComedia"
        Me.cbxComedia.Size = New System.Drawing.Size(67, 17)
        Me.cbxComedia.TabIndex = 1
        Me.cbxComedia.Text = "Comedia"
        Me.cbxComedia.UseVisualStyleBackColor = True
        '
        'cbxDrama
        '
        Me.cbxDrama.AutoSize = True
        Me.cbxDrama.Location = New System.Drawing.Point(15, 57)
        Me.cbxDrama.Name = "cbxDrama"
        Me.cbxDrama.Size = New System.Drawing.Size(57, 17)
        Me.cbxDrama.TabIndex = 2
        Me.cbxDrama.Text = "Drama"
        Me.cbxDrama.UseVisualStyleBackColor = True
        '
        'cbxRomance
        '
        Me.cbxRomance.AutoSize = True
        Me.cbxRomance.Location = New System.Drawing.Point(15, 80)
        Me.cbxRomance.Name = "cbxRomance"
        Me.cbxRomance.Size = New System.Drawing.Size(72, 17)
        Me.cbxRomance.TabIndex = 3
        Me.cbxRomance.Text = "Romance"
        Me.cbxRomance.UseVisualStyleBackColor = True
        '
        'cbxSuspenso
        '
        Me.cbxSuspenso.AutoSize = True
        Me.cbxSuspenso.Location = New System.Drawing.Point(15, 103)
        Me.cbxSuspenso.Name = "cbxSuspenso"
        Me.cbxSuspenso.Size = New System.Drawing.Size(73, 17)
        Me.cbxSuspenso.TabIndex = 4
        Me.cbxSuspenso.Text = "Suspenso"
        Me.cbxSuspenso.UseVisualStyleBackColor = True
        '
        'cbxAccion
        '
        Me.cbxAccion.AutoSize = True
        Me.cbxAccion.Location = New System.Drawing.Point(15, 126)
        Me.cbxAccion.Name = "cbxAccion"
        Me.cbxAccion.Size = New System.Drawing.Size(59, 17)
        Me.cbxAccion.TabIndex = 5
        Me.cbxAccion.Text = "Acción"
        Me.cbxAccion.UseVisualStyleBackColor = True
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(15, 158)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(106, 23)
        Me.btnIngresar.TabIndex = 6
        Me.btnIngresar.Text = "Ingresar Encuesta"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(240, 158)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(106, 23)
        Me.btnMostrar.TabIndex = 7
        Me.btnMostrar.Text = "Mostrar Resultados"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'lstPeliculas
        '
        Me.lstPeliculas.FormattingEnabled = True
        Me.lstPeliculas.Location = New System.Drawing.Point(193, 9)
        Me.lstPeliculas.Name = "lstPeliculas"
        Me.lstPeliculas.Size = New System.Drawing.Size(200, 134)
        Me.lstPeliculas.TabIndex = 8
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 188)
        Me.Controls.Add(Me.lstPeliculas)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.cbxAccion)
        Me.Controls.Add(Me.cbxSuspenso)
        Me.Controls.Add(Me.cbxRomance)
        Me.Controls.Add(Me.cbxDrama)
        Me.Controls.Add(Me.cbxComedia)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbxComedia As System.Windows.Forms.CheckBox
    Friend WithEvents cbxDrama As System.Windows.Forms.CheckBox
    Friend WithEvents cbxRomance As System.Windows.Forms.CheckBox
    Friend WithEvents cbxSuspenso As System.Windows.Forms.CheckBox
    Friend WithEvents cbxAccion As System.Windows.Forms.CheckBox
    Friend WithEvents btnIngresar As System.Windows.Forms.Button
    Friend WithEvents btnMostrar As System.Windows.Forms.Button
    Friend WithEvents lstPeliculas As System.Windows.Forms.ListBox
End Class

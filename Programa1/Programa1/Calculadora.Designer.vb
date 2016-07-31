<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculadora
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPrimerNumero = New System.Windows.Forms.TextBox()
        Me.txtSegundoNumero = New System.Windows.Forms.TextBox()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.btnSumar = New System.Windows.Forms.Button()
        Me.btnRestar = New System.Windows.Forms.Button()
        Me.btnDividir = New System.Windows.Forms.Button()
        Me.btnMultiplicar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(84, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Primer Número:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(84, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Segundo Número:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(84, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Resultado:"
        '
        'txtPrimerNumero
        '
        Me.txtPrimerNumero.Location = New System.Drawing.Point(183, 31)
        Me.txtPrimerNumero.Name = "txtPrimerNumero"
        Me.txtPrimerNumero.Size = New System.Drawing.Size(100, 20)
        Me.txtPrimerNumero.TabIndex = 3
        '
        'txtSegundoNumero
        '
        Me.txtSegundoNumero.Location = New System.Drawing.Point(183, 57)
        Me.txtSegundoNumero.Name = "txtSegundoNumero"
        Me.txtSegundoNumero.Size = New System.Drawing.Size(100, 20)
        Me.txtSegundoNumero.TabIndex = 4
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(183, 83)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(100, 20)
        Me.txtResultado.TabIndex = 5
        '
        'btnSumar
        '
        Me.btnSumar.Location = New System.Drawing.Point(12, 137)
        Me.btnSumar.Name = "btnSumar"
        Me.btnSumar.Size = New System.Drawing.Size(75, 23)
        Me.btnSumar.TabIndex = 6
        Me.btnSumar.Text = "+"
        Me.btnSumar.UseVisualStyleBackColor = True
        '
        'btnRestar
        '
        Me.btnRestar.Location = New System.Drawing.Point(93, 137)
        Me.btnRestar.Name = "btnRestar"
        Me.btnRestar.Size = New System.Drawing.Size(75, 23)
        Me.btnRestar.TabIndex = 7
        Me.btnRestar.Text = "-"
        Me.btnRestar.UseVisualStyleBackColor = True
        '
        'btnDividir
        '
        Me.btnDividir.Location = New System.Drawing.Point(175, 137)
        Me.btnDividir.Name = "btnDividir"
        Me.btnDividir.Size = New System.Drawing.Size(75, 23)
        Me.btnDividir.TabIndex = 8
        Me.btnDividir.Text = "/"
        Me.btnDividir.UseVisualStyleBackColor = True
        '
        'btnMultiplicar
        '
        Me.btnMultiplicar.Location = New System.Drawing.Point(256, 137)
        Me.btnMultiplicar.Name = "btnMultiplicar"
        Me.btnMultiplicar.Size = New System.Drawing.Size(75, 23)
        Me.btnMultiplicar.TabIndex = 9
        Me.btnMultiplicar.Text = "*"
        Me.btnMultiplicar.UseVisualStyleBackColor = True
        '
        'Calculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 196)
        Me.Controls.Add(Me.btnMultiplicar)
        Me.Controls.Add(Me.btnDividir)
        Me.Controls.Add(Me.btnRestar)
        Me.Controls.Add(Me.btnSumar)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.txtSegundoNumero)
        Me.Controls.Add(Me.txtPrimerNumero)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Calculadora"
        Me.Text = "Calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPrimerNumero As System.Windows.Forms.TextBox
    Friend WithEvents txtSegundoNumero As System.Windows.Forms.TextBox
    Friend WithEvents txtResultado As System.Windows.Forms.TextBox
    Friend WithEvents btnSumar As System.Windows.Forms.Button
    Friend WithEvents btnRestar As System.Windows.Forms.Button
    Friend WithEvents btnDividir As System.Windows.Forms.Button
    Friend WithEvents btnMultiplicar As System.Windows.Forms.Button
End Class

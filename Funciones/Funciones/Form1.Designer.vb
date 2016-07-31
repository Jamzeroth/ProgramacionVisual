<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtSegundo = New System.Windows.Forms.TextBox()
        Me.txtPrimer = New System.Windows.Forms.TextBox()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDiv = New System.Windows.Forms.Button()
        Me.btnMul = New System.Windows.Forms.Button()
        Me.btnMenos = New System.Windows.Forms.Button()
        Me.btnMas = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtSegundo
        '
        Me.txtSegundo.Location = New System.Drawing.Point(111, 32)
        Me.txtSegundo.Name = "txtSegundo"
        Me.txtSegundo.Size = New System.Drawing.Size(100, 20)
        Me.txtSegundo.TabIndex = 19
        '
        'txtPrimer
        '
        Me.txtPrimer.Location = New System.Drawing.Point(111, 6)
        Me.txtPrimer.Name = "txtPrimer"
        Me.txtPrimer.Size = New System.Drawing.Size(100, 20)
        Me.txtPrimer.TabIndex = 18
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Location = New System.Drawing.Point(143, 60)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(0, 13)
        Me.lblResultado.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Resultado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Segundo Número:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Primer Número:"
        '
        'btnDiv
        '
        Me.btnDiv.Location = New System.Drawing.Point(205, 91)
        Me.btnDiv.Name = "btnDiv"
        Me.btnDiv.Size = New System.Drawing.Size(30, 30)
        Me.btnDiv.TabIndex = 13
        Me.btnDiv.Text = "/"
        Me.btnDiv.UseVisualStyleBackColor = True
        '
        'btnMul
        '
        Me.btnMul.Location = New System.Drawing.Point(152, 91)
        Me.btnMul.Name = "btnMul"
        Me.btnMul.Size = New System.Drawing.Size(30, 30)
        Me.btnMul.TabIndex = 12
        Me.btnMul.Text = "*"
        Me.btnMul.UseVisualStyleBackColor = True
        '
        'btnMenos
        '
        Me.btnMenos.Location = New System.Drawing.Point(98, 91)
        Me.btnMenos.Name = "btnMenos"
        Me.btnMenos.Size = New System.Drawing.Size(30, 30)
        Me.btnMenos.TabIndex = 11
        Me.btnMenos.Text = "-"
        Me.btnMenos.UseVisualStyleBackColor = True
        '
        'btnMas
        '
        Me.btnMas.Location = New System.Drawing.Point(37, 91)
        Me.btnMas.Name = "btnMas"
        Me.btnMas.Size = New System.Drawing.Size(30, 30)
        Me.btnMas.TabIndex = 10
        Me.btnMas.Text = "+"
        Me.btnMas.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(248, 136)
        Me.Controls.Add(Me.txtSegundo)
        Me.Controls.Add(Me.txtPrimer)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDiv)
        Me.Controls.Add(Me.btnMul)
        Me.Controls.Add(Me.btnMenos)
        Me.Controls.Add(Me.btnMas)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSegundo As System.Windows.Forms.TextBox
    Friend WithEvents txtPrimer As System.Windows.Forms.TextBox
    Friend WithEvents lblResultado As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnDiv As System.Windows.Forms.Button
    Friend WithEvents btnMul As System.Windows.Forms.Button
    Friend WithEvents btnMenos As System.Windows.Forms.Button
    Friend WithEvents btnMas As System.Windows.Forms.Button

End Class

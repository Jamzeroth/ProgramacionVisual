<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rectangulo1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtLado1 = New System.Windows.Forms.TextBox()
        Me.txtLado2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lado 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Lado 2"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(67, 97)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Calcular"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtLado1
        '
        Me.txtLado1.Location = New System.Drawing.Point(98, 25)
        Me.txtLado1.Name = "txtLado1"
        Me.txtLado1.Size = New System.Drawing.Size(100, 20)
        Me.txtLado1.TabIndex = 3
        '
        'txtLado2
        '
        Me.txtLado2.Location = New System.Drawing.Point(98, 51)
        Me.txtLado2.Name = "txtLado2"
        Me.txtLado2.Size = New System.Drawing.Size(100, 20)
        Me.txtLado2.TabIndex = 4
        '
        'Rectangulo1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(234, 136)
        Me.Controls.Add(Me.txtLado2)
        Me.Controls.Add(Me.txtLado1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Rectangulo1"
        Me.Text = "Rectangulo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtLado1 As System.Windows.Forms.TextBox
    Friend WithEvents txtLado2 As System.Windows.Forms.TextBox
End Class

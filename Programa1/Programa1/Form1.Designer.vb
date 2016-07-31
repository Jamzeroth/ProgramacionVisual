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
        Me.lblSaludo = New System.Windows.Forms.Label()
        Me.btnSaludar = New System.Windows.Forms.Button()
        Me.txtHola = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblSaludo
        '
        Me.lblSaludo.AutoSize = True
        Me.lblSaludo.Location = New System.Drawing.Point(36, 31)
        Me.lblSaludo.Name = "lblSaludo"
        Me.lblSaludo.Size = New System.Drawing.Size(40, 13)
        Me.lblSaludo.TabIndex = 0
        Me.lblSaludo.Text = "Saludo"
        '
        'btnSaludar
        '
        Me.btnSaludar.Location = New System.Drawing.Point(249, 26)
        Me.btnSaludar.Name = "btnSaludar"
        Me.btnSaludar.Size = New System.Drawing.Size(75, 23)
        Me.btnSaludar.TabIndex = 1
        Me.btnSaludar.Text = "Saludar"
        Me.btnSaludar.UseVisualStyleBackColor = True
        '
        'txtHola
        '
        Me.txtHola.Location = New System.Drawing.Point(111, 28)
        Me.txtHola.Name = "txtHola"
        Me.txtHola.Size = New System.Drawing.Size(100, 20)
        Me.txtHola.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 107)
        Me.Controls.Add(Me.txtHola)
        Me.Controls.Add(Me.btnSaludar)
        Me.Controls.Add(Me.lblSaludo)
        Me.Name = "Form1"
        Me.Text = "Saludar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSaludo As System.Windows.Forms.Label
    Friend WithEvents btnSaludar As System.Windows.Forms.Button
    Friend WithEvents txtHola As System.Windows.Forms.TextBox

End Class

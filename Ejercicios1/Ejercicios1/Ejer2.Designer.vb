<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejer2
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
        Me.txtN1 = New System.Windows.Forms.TextBox()
        Me.txtN3 = New System.Windows.Forms.TextBox()
        Me.txtN2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCal = New System.Windows.Forms.Button()
        Me.lblMenor = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblMayor = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtN1
        '
        Me.txtN1.Location = New System.Drawing.Point(71, 6)
        Me.txtN1.Name = "txtN1"
        Me.txtN1.Size = New System.Drawing.Size(100, 20)
        Me.txtN1.TabIndex = 0
        '
        'txtN3
        '
        Me.txtN3.Location = New System.Drawing.Point(71, 58)
        Me.txtN3.Name = "txtN3"
        Me.txtN3.Size = New System.Drawing.Size(100, 20)
        Me.txtN3.TabIndex = 2
        '
        'txtN2
        '
        Me.txtN2.Location = New System.Drawing.Point(71, 32)
        Me.txtN2.Name = "txtN2"
        Me.txtN2.Size = New System.Drawing.Size(100, 20)
        Me.txtN2.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Número 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Número 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Número 3"
        '
        'btnCal
        '
        Me.btnCal.Location = New System.Drawing.Point(209, 29)
        Me.btnCal.Name = "btnCal"
        Me.btnCal.Size = New System.Drawing.Size(53, 33)
        Me.btnCal.TabIndex = 7
        Me.btnCal.Text = "Calcular"
        Me.btnCal.UseVisualStyleBackColor = True
        '
        'lblMenor
        '
        Me.lblMenor.AutoSize = True
        Me.lblMenor.Location = New System.Drawing.Point(81, 116)
        Me.lblMenor.Name = "lblMenor"
        Me.lblMenor.Size = New System.Drawing.Size(0, 13)
        Me.lblMenor.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Número menor"
        '
        'lblMayor
        '
        Me.lblMayor.AutoSize = True
        Me.lblMayor.Location = New System.Drawing.Point(206, 116)
        Me.lblMayor.Name = "lblMayor"
        Me.lblMayor.Size = New System.Drawing.Size(0, 13)
        Me.lblMayor.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(168, 154)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Número mayor"
        '
        'Ejer2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 189)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblMayor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblMenor)
        Me.Controls.Add(Me.btnCal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtN2)
        Me.Controls.Add(Me.txtN3)
        Me.Controls.Add(Me.txtN1)
        Me.Name = "Ejer2"
        Me.Text = "Ejer2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtN1 As System.Windows.Forms.TextBox
    Friend WithEvents txtN3 As System.Windows.Forms.TextBox
    Friend WithEvents txtN2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCal As System.Windows.Forms.Button
    Friend WithEvents lblMenor As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblMayor As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class

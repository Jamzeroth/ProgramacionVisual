<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejer5
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
        Me.btnFor = New System.Windows.Forms.Button()
        Me.btnWhile = New System.Windows.Forms.Button()
        Me.btnDo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.lblSuma = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnFor
        '
        Me.btnFor.Location = New System.Drawing.Point(12, 110)
        Me.btnFor.Name = "btnFor"
        Me.btnFor.Size = New System.Drawing.Size(75, 23)
        Me.btnFor.TabIndex = 0
        Me.btnFor.Text = "for( )"
        Me.btnFor.UseVisualStyleBackColor = True
        '
        'btnWhile
        '
        Me.btnWhile.Location = New System.Drawing.Point(106, 110)
        Me.btnWhile.Name = "btnWhile"
        Me.btnWhile.Size = New System.Drawing.Size(75, 23)
        Me.btnWhile.TabIndex = 1
        Me.btnWhile.Text = "while( )"
        Me.btnWhile.UseVisualStyleBackColor = True
        '
        'btnDo
        '
        Me.btnDo.Location = New System.Drawing.Point(197, 110)
        Me.btnDo.Name = "btnDo"
        Me.btnDo.Size = New System.Drawing.Size(75, 23)
        Me.btnDo.TabIndex = 2
        Me.btnDo.Text = "Do_Until( )"
        Me.btnDo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Hasta que número desea sumar:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "La suma es: "
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(178, 31)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(100, 20)
        Me.txtNum.TabIndex = 5
        '
        'lblSuma
        '
        Me.lblSuma.AutoSize = True
        Me.lblSuma.Location = New System.Drawing.Point(145, 71)
        Me.lblSuma.Name = "lblSuma"
        Me.lblSuma.Size = New System.Drawing.Size(0, 13)
        Me.lblSuma.TabIndex = 6
        '
        'Ejer5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 150)
        Me.Controls.Add(Me.lblSuma)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDo)
        Me.Controls.Add(Me.btnWhile)
        Me.Controls.Add(Me.btnFor)
        Me.Name = "Ejer5"
        Me.Text = "Ejer5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFor As System.Windows.Forms.Button
    Friend WithEvents btnWhile As System.Windows.Forms.Button
    Friend WithEvents btnDo As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNum As System.Windows.Forms.TextBox
    Friend WithEvents lblSuma As System.Windows.Forms.Label
End Class

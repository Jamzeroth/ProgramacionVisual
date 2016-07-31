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
        Me.lblResul = New System.Windows.Forms.Label()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.btnFor = New System.Windows.Forms.Button()
        Me.btnWhile = New System.Windows.Forms.Button()
        Me.btnUntil = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese Número:"
        '
        'lblResul
        '
        Me.lblResul.AutoSize = True
        Me.lblResul.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResul.Location = New System.Drawing.Point(101, 89)
        Me.lblResul.Name = "lblResul"
        Me.lblResul.Size = New System.Drawing.Size(0, 20)
        Me.lblResul.TabIndex = 2
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(131, 6)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(100, 20)
        Me.txtNum.TabIndex = 3
        '
        'btnFor
        '
        Me.btnFor.Location = New System.Drawing.Point(12, 43)
        Me.btnFor.Name = "btnFor"
        Me.btnFor.Size = New System.Drawing.Size(75, 23)
        Me.btnFor.TabIndex = 4
        Me.btnFor.Text = "for( )"
        Me.btnFor.UseVisualStyleBackColor = True
        '
        'btnWhile
        '
        Me.btnWhile.Location = New System.Drawing.Point(93, 43)
        Me.btnWhile.Name = "btnWhile"
        Me.btnWhile.Size = New System.Drawing.Size(75, 23)
        Me.btnWhile.TabIndex = 5
        Me.btnWhile.Text = "while( )"
        Me.btnWhile.UseVisualStyleBackColor = True
        '
        'btnUntil
        '
        Me.btnUntil.Location = New System.Drawing.Point(174, 43)
        Me.btnUntil.Name = "btnUntil"
        Me.btnUntil.Size = New System.Drawing.Size(75, 23)
        Me.btnUntil.TabIndex = 6
        Me.btnUntil.Text = "until( )"
        Me.btnUntil.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Factorial:"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(262, 133)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnUntil)
        Me.Controls.Add(Me.btnWhile)
        Me.Controls.Add(Me.btnFor)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.lblResul)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Factorial"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblResul As System.Windows.Forms.Label
    Friend WithEvents txtNum As System.Windows.Forms.TextBox
    Friend WithEvents btnFor As System.Windows.Forms.Button
    Friend WithEvents btnWhile As System.Windows.Forms.Button
    Friend WithEvents btnUntil As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class

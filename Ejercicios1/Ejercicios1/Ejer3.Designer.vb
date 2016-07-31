<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejer3
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
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.lblImpr = New System.Windows.Forms.Label()
        Me.btnFor = New System.Windows.Forms.Button()
        Me.btnWhile = New System.Windows.Forms.Button()
        Me.btnDo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hasta que número desea imprimir:"
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(184, 33)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(57, 20)
        Me.txtNum.TabIndex = 1
        '
        'lblImpr
        '
        Me.lblImpr.AutoSize = True
        Me.lblImpr.Location = New System.Drawing.Point(12, 66)
        Me.lblImpr.Name = "lblImpr"
        Me.lblImpr.Size = New System.Drawing.Size(0, 13)
        Me.lblImpr.TabIndex = 2
        '
        'btnFor
        '
        Me.btnFor.Location = New System.Drawing.Point(12, 120)
        Me.btnFor.Name = "btnFor"
        Me.btnFor.Size = New System.Drawing.Size(75, 23)
        Me.btnFor.TabIndex = 3
        Me.btnFor.Text = "for( )"
        Me.btnFor.UseVisualStyleBackColor = True
        '
        'btnWhile
        '
        Me.btnWhile.Location = New System.Drawing.Point(93, 120)
        Me.btnWhile.Name = "btnWhile"
        Me.btnWhile.Size = New System.Drawing.Size(75, 23)
        Me.btnWhile.TabIndex = 4
        Me.btnWhile.Text = "while( )"
        Me.btnWhile.UseVisualStyleBackColor = True
        '
        'btnDo
        '
        Me.btnDo.Location = New System.Drawing.Point(174, 120)
        Me.btnDo.Name = "btnDo"
        Me.btnDo.Size = New System.Drawing.Size(75, 23)
        Me.btnDo.TabIndex = 5
        Me.btnDo.Text = "do_until( )"
        Me.btnDo.UseVisualStyleBackColor = True
        '
        'Ejer3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 177)
        Me.Controls.Add(Me.btnDo)
        Me.Controls.Add(Me.btnWhile)
        Me.Controls.Add(Me.btnFor)
        Me.Controls.Add(Me.lblImpr)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Ejer3"
        Me.Text = "Ejer3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNum As System.Windows.Forms.TextBox
    Friend WithEvents lblImpr As System.Windows.Forms.Label
    Friend WithEvents btnFor As System.Windows.Forms.Button
    Friend WithEvents btnWhile As System.Windows.Forms.Button
    Friend WithEvents btnDo As System.Windows.Forms.Button
End Class

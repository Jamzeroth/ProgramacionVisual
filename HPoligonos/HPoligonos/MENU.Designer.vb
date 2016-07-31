<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MENU
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RectánguloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TriánguloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RectánguloToolStripMenuItem, Me.TriánguloToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(560, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RectánguloToolStripMenuItem
        '
        Me.RectánguloToolStripMenuItem.Name = "RectánguloToolStripMenuItem"
        Me.RectánguloToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.RectánguloToolStripMenuItem.Text = "Rectángulo"
        '
        'TriánguloToolStripMenuItem
        '
        Me.TriánguloToolStripMenuItem.Name = "TriánguloToolStripMenuItem"
        Me.TriánguloToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.TriánguloToolStripMenuItem.Text = "Triángulo"
        '
        'MENU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 344)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MENU"
        Me.Text = "Poligono"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents RectánguloToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TriánguloToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class

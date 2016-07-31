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
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuentaDeAhorroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuentaCorrienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CuentaToolStripMenuItem, Me.CuentaDeAhorroToolStripMenuItem, Me.CuentaCorrienteToolStripMenuItem})
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'CuentaToolStripMenuItem
        '
        Me.CuentaToolStripMenuItem.Name = "CuentaToolStripMenuItem"
        Me.CuentaToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.CuentaToolStripMenuItem.Text = "Cuenta"
        '
        'CuentaDeAhorroToolStripMenuItem
        '
        Me.CuentaDeAhorroToolStripMenuItem.Name = "CuentaDeAhorroToolStripMenuItem"
        Me.CuentaDeAhorroToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.CuentaDeAhorroToolStripMenuItem.Text = "Cuenta de Ahorro"
        '
        'CuentaCorrienteToolStripMenuItem
        '
        Me.CuentaCorrienteToolStripMenuItem.Name = "CuentaCorrienteToolStripMenuItem"
        Me.CuentaCorrienteToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.CuentaCorrienteToolStripMenuItem.Text = "Cuenta Corriente"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'MENU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MENU"
        Me.Text = "MENU"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents InicioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CuentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CuentaDeAhorroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CuentaCorrienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class

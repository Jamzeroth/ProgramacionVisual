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
        Me.ClasesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstudianteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfesorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClasesToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(484, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ClasesToolStripMenuItem
        '
        Me.ClasesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PersonaToolStripMenuItem, Me.EstudianteToolStripMenuItem, Me.ProfesorToolStripMenuItem})
        Me.ClasesToolStripMenuItem.Name = "ClasesToolStripMenuItem"
        Me.ClasesToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.ClasesToolStripMenuItem.Text = "Clases"
        '
        'PersonaToolStripMenuItem
        '
        Me.PersonaToolStripMenuItem.Name = "PersonaToolStripMenuItem"
        Me.PersonaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PersonaToolStripMenuItem.Text = "Persona"
        '
        'EstudianteToolStripMenuItem
        '
        Me.EstudianteToolStripMenuItem.Name = "EstudianteToolStripMenuItem"
        Me.EstudianteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EstudianteToolStripMenuItem.Text = "Estudiante"
        '
        'ProfesorToolStripMenuItem
        '
        Me.ProfesorToolStripMenuItem.Name = "ProfesorToolStripMenuItem"
        Me.ProfesorToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ProfesorToolStripMenuItem.Text = "Profesor"
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
        Me.ClientSize = New System.Drawing.Size(484, 345)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MENU"
        Me.Text = "MENU"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ClasesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PersonaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstudianteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProfesorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class

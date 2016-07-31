Public Class MENU

    Private Sub PersonaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonaToolStripMenuItem.Click
        Persona1.MdiParent = Me
        Persona1.Show()
    End Sub

    Private Sub EstudianteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstudianteToolStripMenuItem.Click
        Estudiante1.MdiParent = Me
        Estudiante1.Show()
    End Sub

    Private Sub ProfesorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfesorToolStripMenuItem.Click
        Profesor1.MdiParent = Me
        Profesor1.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dispose()
    End Sub
End Class
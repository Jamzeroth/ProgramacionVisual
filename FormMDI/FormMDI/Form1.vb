Public Class Form1

    Private Sub EstudianteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstudianteToolStripMenuItem.Click
        Estudiante.MdiParent = Me
        Estudiante.Show()
    End Sub

    Private Sub MateriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MateriaToolStripMenuItem.Click
        Materia.MdiParent = Me
        Materia.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dispose()
    End Sub
End Class

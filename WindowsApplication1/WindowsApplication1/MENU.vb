Public Class MENU

    Private Sub ZapatoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZapatoToolStripMenuItem.Click
        Zapato1.MdiParent = Me
        Zapato1.Show()
    End Sub

    Private Sub DeportivoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeportivoToolStripMenuItem.Click
        Deportivo1.MdiParent = Me
        Deportivo1.Show()
    End Sub

    Private Sub CasualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CasualToolStripMenuItem.Click
        Casual1.MdiParent = Me
        Casual1.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dispose()
    End Sub

    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click

    End Sub
End Class

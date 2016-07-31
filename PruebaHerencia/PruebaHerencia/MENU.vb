Public Class MENU

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dispose()
    End Sub

    Private Sub ProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductoToolStripMenuItem.Click
        Producto1.MdiParent = Me
        Producto1.Show()
    End Sub

    Private Sub OrganicoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrganicoToolStripMenuItem.Click
        Organico.MdiParent = Me
        Organico.Show()
    End Sub

    Private Sub InorganicoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InorganicoToolStripMenuItem.Click
        Inorganico1.MdiParent = Me
        Inorganico1.Show()
    End Sub

End Class

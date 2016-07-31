Public Class MENU

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dispose()
    End Sub

    Private Sub CuentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuentaToolStripMenuItem.Click
        Cuenta1.MdiParent = Me
        Cuenta1.Show()
    End Sub

    Private Sub CuentaDeAhorroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuentaDeAhorroToolStripMenuItem.Click
        Ahorro1.MdiParent = Me
        Ahorro1.Show()
    End Sub

    Private Sub CuentaCorrienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuentaCorrienteToolStripMenuItem.Click
        Corriente1.MdiParent = Me
        Corriente1.Show()
    End Sub
End Class
Public Class ContextMenuStrip
    Dim cont As Integer = 1

    Private Sub AñadirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AñadirToolStripMenuItem.Click
        ListBox1.Items.Add("Persona " + CStr(cont) + ": ")
        cont += 1
    End Sub

    Private Sub BorrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrarToolStripMenuItem.Click
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub

    Private Sub BorrarTodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrarTodoToolStripMenuItem.Click
        ListBox1.Items.Clear()
        cont = 1
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
End Class
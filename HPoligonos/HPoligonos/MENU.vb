Public Class MENU

    Private Sub RectánguloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RectánguloToolStripMenuItem.Click
        Rectangulo1.MdiParent = Me
        Rectangulo1.Show()
    End Sub

    Private Sub TriánguloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TriánguloToolStripMenuItem.Click
        Triangulo1.MdiParent = Me
        Triangulo1.Show()
    End Sub
End Class

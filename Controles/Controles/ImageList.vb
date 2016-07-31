Public Class ImageList
    Dim cont As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cont > 24 Then cont = 0
        PictureBox1.Image = ImageList1.Images.Item(cont)
        cont += 1
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If cont > 24 Then cont = 0
        PictureBox1.Image = ImageList1.Images.Item(cont)
        cont += 1
    End Sub
End Class
Public Class ScrollBar
    Dim gr As Double
    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        TextBox1.Text = HScrollBar1.Value
        gr = 1.8 * HScrollBar1.Value + 32
        TextBox2.Text = gr
    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar1.Scroll
        TextBox1.Text = VScrollBar1.Value
        gr = 1.8 * VScrollBar1.Value + 32
        TextBox2.Text = gr
    End Sub
End Class
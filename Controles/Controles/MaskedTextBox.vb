Public Class MaskedTextBox

    Private Sub MaskedTextBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ToolTip1.IsBalloon = True
        Me.MaskedTextBox1.Mask = "00/00/0000"
    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox1.MaskInputRejected
        ToolTip1.ToolTipTitle = "Entrada Invalida"
        ToolTip1.Show("Solo número de 0-9", MaskedTextBox1, 5000)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = MaskedTextBox1.Text
    End Sub
End Class
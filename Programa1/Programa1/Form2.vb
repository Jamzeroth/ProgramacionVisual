Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim n As Integer
        Dim Fact As Integer
        Fact = 1
        For n = 1 To txtNumero.Text
            Fact = Fact * n
        Next
        txtFactorial.Text = Fact
    End Sub
End Class
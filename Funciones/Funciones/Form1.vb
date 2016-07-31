Public Class Form1
    Function Suma(val As Integer, b As Integer) As Integer
        val = val + b
        Return val
    End Function

    Function Resta(val As Integer, b As Integer) As Integer
        val = val - b
        Return val
    End Function

    Function Mul(val As Integer, b As Integer) As Integer
        val = val * b
        Return val
    End Function

    Function Div(val As Integer, b As Integer) As Integer
        val = val / b
        Return val
    End Function

    Private Sub btnMas_Click(sender As Object, e As EventArgs) Handles btnMas.Click
        lblResultado.Text = CInt(Suma(txtPrimer.Text, txtSegundo.Text))
    End Sub

    Private Sub btnMenos_Click(sender As Object, e As EventArgs) Handles btnMenos.Click
        lblResultado.Text = CInt(Resta(txtPrimer.Text, txtSegundo.Text))
    End Sub

    Private Sub btnMul_Click(sender As Object, e As EventArgs) Handles btnMul.Click
        lblResultado.Text = CInt(Mul(txtPrimer.Text, txtSegundo.Text))
    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        lblResultado.Text = CInt(Div(txtPrimer.Text, txtSegundo.Text))
    End Sub
End Class

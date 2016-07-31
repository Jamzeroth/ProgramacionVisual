Public Class Form1
    Private Sub Suma(ByVal a, ByVal b)
        lblResultado.Text = CStr(a + b)
    End Sub

    Private Sub Resta(ByVal a, ByVal b)
        lblResultado.Text = CStr(a - b)
    End Sub

    Private Sub Mul(ByVal a, ByVal b)
        lblResultado.Text = CStr(a * b)
    End Sub

    Private Sub Div(ByVal a, ByVal b)
        lblResultado.Text = CStr(a / b)
    End Sub

    Private Sub btnMas_Click(sender As Object, e As EventArgs) Handles btnMas.Click
        Suma(CInt(txtPrimer.Text), CInt(txtSegundo.Text))
    End Sub

    Private Sub btnMenos_Click(sender As Object, e As EventArgs) Handles btnMenos.Click
        Resta(CInt(txtPrimer.Text), CInt(txtSegundo.Text))
    End Sub

    Private Sub btnMul_Click(sender As Object, e As EventArgs) Handles btnMul.Click
        Mul(CInt(txtPrimer.Text), CInt(txtSegundo.Text))
    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        Div(CInt(txtPrimer.Text), CInt(txtSegundo.Text))
    End Sub

End Class

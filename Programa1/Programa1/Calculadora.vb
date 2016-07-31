Public Class Calculadora
    Private Sub btnSumar_Click(sender As Object, e As EventArgs) Handles btnSumar.Click
        txtResultado.Text = CInt(txtPrimerNumero.Text) + CInt(txtSegundoNumero.Text)
    End Sub

    Private Sub btnRestar_Click(sender As Object, e As EventArgs) Handles btnRestar.Click
        txtResultado.Text = CInt(txtPrimerNumero.Text) - CInt(txtSegundoNumero.Text)
    End Sub

    Private Sub btnDividir_Click(sender As Object, e As EventArgs) Handles btnDividir.Click
        txtResultado.Text = CInt(txtPrimerNumero.Text) / CInt(txtSegundoNumero.Text)
    End Sub

    Private Sub btnMultiplicar_Click(sender As Object, e As EventArgs) Handles btnMultiplicar.Click
        txtResultado.Text = CInt(txtPrimerNumero.Text) * CInt(txtSegundoNumero.Text)
    End Sub
End Class
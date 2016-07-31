Public Class Ejer1

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        If CInt(txtNumero1.Text) > CInt(txtNumero2.Text) Then lblMayor.Text = txtNumero1.Text Else lblMayor.Text = txtNumero2.Text
    End Sub

    Private Sub Ejer1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

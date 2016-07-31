Public Class Ahorro1
    Public C1 As Ahorro = New Ahorro()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        C1.PNombre = txtNombre.Text
        C1.PNum = txtNumero.Text
        C1.PSaldo = CDec(txtSaldo.Text)
        C1.PInteres = CDec(txtInteres.Text)
        txtNombre.Text = ""
        txtNumero.Text = ""
        txtSaldo.Text = ""
        txtInteres.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Nombre: " + C1.PNombre + " Numero: " + C1.PNum + " Saldo: " + CStr(C1.PSaldo) + " Interes: " + CStr(C1.PInteres))
    End Sub
End Class
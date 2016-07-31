Public Class Corriente1
    Public C1 As Corriente = New Corriente()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        C1.PNombre = txtNombre.Text
        C1.PNum = txtNumero.Text
        C1.PSaldo = CDec(txtSaldo.Text)
        C1.PCheques = CInt(txtCheques.Text)
        txtNombre.Text = ""
        txtNumero.Text = ""
        txtSaldo.Text = ""
        txtCheques.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Nombre: " + C1.PNombre + " Numero: " + C1.PNum + " Saldo: " + CStr(C1.PSaldo) + " Nro. Cheques: " + CStr(C1.PCheques))
    End Sub
End Class
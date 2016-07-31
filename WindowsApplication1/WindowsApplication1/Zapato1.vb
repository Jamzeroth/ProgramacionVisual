Public Class Zapato1
    Private Z1 As Zapato = New Zapato()

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        Z1.Pmarca = txtMarca.Text
        Z1.Ptalla = CInt(txtTalla.Text)
        txtMarca.Text = ""
        txtTalla.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Marca: " + Z1.Pmarca + vbNewLine + "Talla: " + CStr(Z1.Ptalla))
    End Sub
End Class
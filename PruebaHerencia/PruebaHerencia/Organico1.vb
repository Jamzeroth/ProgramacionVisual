Public Class Organico

    Public O1 As Organicos = New Organicos()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        O1.Pnombre = TextBox1.Text
        O1.Pprecio = CDec(TextBox2.Text)
        O1.Ptiempo = CInt(TextBox3.Text)
        O1.Ptipo = TextBox4.Text
        lbValor.Text = CStr(O1.reduccion(O1.Pprecio))
        lbIva.Text = CStr(O1.iva())
        MsgBox("Nombre: " + O1.Pnombre + "      Precio: " + CStr(O1.Pprecio) + "      T. Expiracion: " + CStr(O1.Ptiempo) + "Tipo: " + O1.Ptipo + "Valor real: " + CStr(O1.reduccion(O1.Pprecio)) + "      iva:" + CStr(O1.iva()))
    End Sub

End Class
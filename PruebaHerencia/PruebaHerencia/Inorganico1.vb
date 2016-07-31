Public Class Inorganico1

    Public O1 As Inorganico = New Inorganico()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        O1.Pnombre = TextBox1.Text
        O1.Pprecio = CDec(TextBox2.Text)
        O1.PtiempoG = CInt(TextBox3.Text)
        O1.Ptipo = TextBox4.Text
        lbIva.Text = CStr(O1.iva())
        MsgBox("Nombre: " + O1.Pnombre + "      Precio: " + CStr(O1.Pprecio) + "      T. Garantia: " + CStr(O1.PtiempoG) + "        Tipo: " + O1.Ptipo + "      iva:" + CStr(O1.iva()))
    End Sub
End Class
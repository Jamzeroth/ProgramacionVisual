Public Class Producto1

    Public P1 As Producto = New Producto()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        P1.Pnombre = TextBox1.Text
        P1.Pprecio = CDec(TextBox2.Text)
        lbIva.Text = CStr(P1.iva())
        MsgBox("Nombre: " + P1.Pnombre + "      Precio: " + CStr(P1.Pprecio) + "      iva:" + CStr(P1.iva()))
    End Sub
End Class
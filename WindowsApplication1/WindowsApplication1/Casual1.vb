Public Class Casual1
    Private C1 As Casual = New Casual()

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        C1.Pmarca = txtMarca.Text
        C1.Ptalla = CInt(txtTalla.Text)
        C1.Pevento = txtEvento.Text
        txtMarca.Text = ""
        txtTalla.Text = ""
        txtEvento.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Marca: " + C1.Pmarca + vbNewLine + "Talla: " + CStr(C1.Ptalla) + vbNewLine + "Evento: " + C1.Pevento)
    End Sub
End Class
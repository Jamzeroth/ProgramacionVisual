Public Class Deportivo1
    Private D1 As Deportivo = New Deportivo()

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        D1.Pmarca = txtMarca.Text
        D1.Ptalla = CInt(txtTalla.Text)
        D1.Pdeporte = txtDeporte.Text
        txtMarca.Text = ""
        txtTalla.Text = ""
        txtDeporte.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Marca: " + D1.Pmarca + vbNewLine + "Talla: " + CStr(D1.Ptalla) + vbNewLine + "Deporte: " + D1.Pdeporte)
    End Sub
End Class
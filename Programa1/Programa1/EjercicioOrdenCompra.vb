Public Class EjercicioOrdenCompra
    Structure Orden
        Dim nombre As String
        Dim direccion As String
        Dim fecha As Date
        Dim monto As Decimal
    End Structure

    Private compra(5) As Orden
    Dim des As Decimal = 0
    Dim cont As Integer = 0

    Private Sub btnDes_Click(sender As Object, e As EventArgs) Handles btnDes.Click
        If txtDes.Text <> "" Then
            des = txtDes.Text
        End If
        des = 1 - des / 100
        lstDescuento.Items.Clear()
        lstDescuento.Items.Add("Ordenes de compra con descuento")
        For i As Integer = 0 To cont - 1
            If compra(i).monto > 500 Then
                lstDescuento.Items.Add(compra(i).nombre + "  " + CStr(compra(i).direccion) + "  " + CStr(compra(i).fecha) + "  " + CStr((compra(i).monto * des)))
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (cont < 5) Then
            compra(cont).nombre = txtNombre.Text
            compra(cont).direccion = txtDir.Text
            compra(cont).fecha = CDate(txtDate.Text)
            compra(cont).monto = CInt(txtMonto.Text)
            cont += 1
            txtNombre.Text = ""
            txtDir.Text = ""
            txtDate.Text = ""
            txtMonto.Text = ""
        End If
    End Sub

    Private Sub btnDesplegar_Click(sender As Object, e As EventArgs) Handles btnDesplegar.Click
        lstOrden.Items.Clear()
        lstOrden.Items.Add("Ordenes de compra")
        For i As Integer = 0 To cont - 1
            lstOrden.Items.Add(compra(i).nombre + "  " + CStr(compra(i).direccion) + "  " + CStr(compra(i).fecha) + "  " + CStr(compra(i).monto))
        Next
    End Sub
End Class
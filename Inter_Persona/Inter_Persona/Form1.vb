Public Class Form1
    Public per1 As Persona = New Persona()
    'Insertar datos a una lista o una tabla

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        per1.Pnombre = txtNombre.Text
        per1.Papellido = txtApellido.Text
        per1.Pedad = CInt(txtEdad.Text)
        lstLista.Items.Add(per1.Pnombre + "                " + per1.Papellido + "            " + CStr(per1.Pedad))
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        txtNombreM.Text = per1.Pnombre
        txtApellidoM.Text = per1.Papellido
        txtEdadM.Text = CStr(per1.Pedad)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstLista.Items.Add("Nombre            Apellido           Edad")
    End Sub
End Class

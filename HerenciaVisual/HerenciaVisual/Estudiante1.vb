Public Class Estudiante1
    Public estudiante As Estudiante
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        estudiante = New Estudiante
        estudiante.SetNombre(txtNombre.Text)
        estudiante.SetTelefono(txtTelefono.Text)
        estudiante.SetCarrera(txtCarrera.Text)
        MsgBox("Estudiante: " + estudiante.GetNombre + " /Telefono: " + estudiante.GetTelefono + " /Carrera: " + estudiante.GetCarrera)
    End Sub
End Class

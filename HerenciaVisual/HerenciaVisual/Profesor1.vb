Public Class Profesor1
    Public profesor As Profesor
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        profesor = New Profesor()
        profesor.SetNombre(txtNombre.Text)
        profesor.SetTelefono(txtTelefono.Text)
        profesor.SetEspecialidad(txtEspecialidad.Text)
        MsgBox("Profesor: " + profesor.GetNombre + " /Telefono:" + profesor.GetTelefono + " /Especialidad: " + profesor.GetEspecialidad)
    End Sub
End Class
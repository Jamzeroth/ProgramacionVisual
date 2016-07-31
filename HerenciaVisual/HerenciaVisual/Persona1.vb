Public Class Persona1
    Public persona As Persona

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        persona = New Persona
        persona.SetNombre(txtNombre.Text)
        persona.SetTelefono(txtTelefono.Text)
        MsgBox("Persona: " + persona.GetNombre + " /Telefono: " + persona.GetTelefono)
    End Sub
End Class
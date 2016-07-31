Public Class Persona
    'Definicion de la estructura llamada persona
    Structure Persona
        Dim nombre As String
        Dim edad As Integer
        Dim fecha As Date
    End Structure
    'Definicion de una variable tipo estructura persona
    'Dim p1 As Persona
    Private person(5) As Persona
    Dim cont As Integer = 0

    'Seccion de metodos (operaciones)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'p1.nombre = txtNombre.Text
        'p1.edad = CInt(txtEdad.Text)
        'p1.fecha = CDate(txtDate.Text)
        If (cont < 5) Then
            person(cont).nombre = txtNombre.Text
            person(cont).edad = CInt(txtEdad.Text)
            person(cont).fecha = CDate(txtDate.Text)
            cont += 1
            txtNombre.Text = ""
            txtEdad.Text = ""
            txtDate.Text = ""
        End If
        lblMensaje.Text = CStr(cont) + " personas ingresadas"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'lblNombre.Text = p1.nombre
        'lblEdad.Text = p1.edad
        'lblDate.Text = p1.fecha
    End Sub

    Private Sub btnLista_Click(sender As Object, e As EventArgs) Handles btnLista.Click
        'lstPersona.Items.Add(p1.nombre + Chr(9) + CStr(p1.edad) + Chr(9) + CStr(p1.fecha))
        lstPersona.Items.Clear()
        For i As Integer = 0 To cont - 1
            lstPersona.Items.Add(person(i).nombre + Chr(9) + CStr(person(i).edad) + Chr(9) + CStr(person(i).fecha))
        Next
    End Sub
End Class
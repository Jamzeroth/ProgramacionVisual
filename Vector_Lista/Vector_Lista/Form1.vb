Public Class Form1
    Dim f As Integer = 0
    '  Dim car As Integer = 0
    Dim mat(5, 3) As String
    Dim P1 As Persona = New Persona()
    Dim list As New List(Of Persona)

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        mat(f, 0) = txtNombre.Text
        mat(f, 1) = txtApe.Text
        mat(f, 2) = txtEdad.Text
        mat(f, 3) = txtTlf.Text
        f += 1
        txtNombre.Text = ""
        txtApe.Text = ""
        txtEdad.Text = ""
        txtTlf.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        For i As Integer = 0 To f - 1
            P1.Pnombre = mat(i, 0)
            P1.Papellido = mat(i, 1)
            P1.Pedad = CInt(mat(i, 2))
            P1.Ptelefono = mat(i, 3)
            list.Add(P1)
            ListBox1.Items.Add(list(i).Pnombre + " " + list.Item(i).Papellido + " " + CStr(list.Item(i).Pedad) + " " + list.Item(i).Ptelefono)
        Next
    End Sub
End Class

Public Class InputBoxhola
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b As String
        a = InputBox("Ingrese un numero", "Número 1", " ", 500, 200)
        If a <> "" Then
            MessageBox.Show("El numero ingresado es: " + a)
        End If
        b = InputBox("Ingrese un numero", "Numero 2", " ", 500, 200)
        If a <> "" Then
            MessageBox.Show("El numero ingresado es: " + b)
        End If
        MessageBox.Show("El resultado es: " + CStr(CInt(a) + CInt(b)), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
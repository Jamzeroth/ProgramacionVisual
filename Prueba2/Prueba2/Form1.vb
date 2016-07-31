Public Class Form1
    Dim Vector(20) As Integer
    Dim cont As Integer = 0
    Function Ingresar(num As Integer) As Integer
        Vector(cont) = num
        num = cont + 1
        Return num
    End Function

    Function Buscar(num As Integer) As Integer
        For i As Integer = 0 To cont
            If (Vector(i) = num) Then
                Return 1
            End If
        Next
        Return 0
    End Function

    
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If (txtIngreso.Text <> "") Then
            cont = Ingresar(CInt(txtIngreso.Text))
        End If
        txtIngreso.Text = ""
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If (txtBuscar.Text <> "" And cont <> 0) Then
            If (Buscar(CInt(txtBuscar.Text))) Then
                lblMensaje.Text = "El número " + txtBuscar.Text + " se encontró en el arreglo"
            Else
                lblMensaje.Text = "El número " + txtBuscar.Text + " NO se encontró en el arreglo"
            End If
        End If
        txtBuscar.Text = ""
    End Sub
End Class

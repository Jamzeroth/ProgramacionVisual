Public Class Form3

    Function parImpar(num As Integer)
        If (num Mod 2 = 0) Then
            Return 1
        End If
        Return 0
    End Function

    Private Sub btnValorar_Click(sender As Object, e As EventArgs) Handles btnValorar.Click
        If (txtNum.Text <> "") Then
            If (parImpar(CInt(txtNum.Text))) Then
                lblMensaje.Text = "El número es par"
            Else
                lblMensaje.Text = "El número es impar"
            End If
        End If
    End Sub
End Class
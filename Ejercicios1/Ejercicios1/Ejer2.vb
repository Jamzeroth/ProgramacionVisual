Public Class Ejer2

    Private Sub btnCal_Click(sender As Object, e As EventArgs) Handles btnCal.Click
        Dim a, b, c As Integer
        a = CInt(txtN1.Text)
        b = CInt(txtN2.Text)
        c = CInt(txtN3.Text)
        If (a > b And a > c) Then
            lblMayor.Text = a
        Else
            If (b > a And b > c) Then
                lblMayor.Text = b
            Else
                lblMayor.Text = c
            End If
        End If
        If (a < b And a < c) Then
            lblMenor.Text = a
        Else
            If (b < a And b < c) Then
                lblMenor.Text = b
            Else
                lblMenor.Text = c
            End If
        End If
    End Sub
End Class
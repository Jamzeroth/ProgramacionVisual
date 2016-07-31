Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (cbxOpcion.Checked) Then
            lblMensaje.Text = "Afirmativo"
        Else
            lblMensaje.Text = "Negativo"
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cbxNegrita.CheckedChanged
        If (cbxNegrita.Checked) Then
            lblMensaje.Font = New Font(lblMensaje.Font, FontStyle.Bold)
        Else
            lblMensaje.Font = New Font(lblMensaje.Font, FontStyle.Regular)
        End If
    End Sub
End Class

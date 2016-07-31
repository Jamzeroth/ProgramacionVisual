Public Class MsgBox

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Hola")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim valorRetorno As Integer
        valorRetorno = MessageBox.Show("Selecciona un boton", "Prueba", MessageBoxButtons.YesNo)
        If valorRetorno = 1 Then
            MessageBox.Show("Presiono Cancelar")
        Else
            MessageBox.Show("Presiono Aceptar")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim valorRetorno As Integer
        valorRetorno = MessageBox.Show("Selecciones valor", "Hola", MessageBoxButtons.OK)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim valorR As Integer
        valorR = MessageBox.Show("Esoja una opcion", "Prueba", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation)
        Select Case valorR
            Case 3
                MessageBox.Show("Ud presiono Anular:")
            Case 4
                MessageBox.Show("Ud presiono Reintentar")
            Case 5
                MessageBox.Show("Ud presiono Omitir")
        End Select
    End Sub
End Class

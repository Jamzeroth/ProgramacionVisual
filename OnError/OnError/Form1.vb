Public Class Form1

    Private Sub 

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        On Error GoTo 88
        i = Rnd() * 10 ^ 16
        lblError.Text = ("Esta instruccion no se llega a ejecutar")

88:     If Err.Number Then MsgBox("Se ha producido un error. Tipo de error = " + CStr(Err.Number) + " Descripción: " + Err.Description)
        lblError.Text = "La ejecucion continua"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        On Error GoTo Gestionarerror
        Dim i As Integer
        i = Rnd() * 10 ^ 16
        lblError.Text = "La ejecucion continua aqui debido al Resume Next" + vbCrLf
        lblError.Text = lblError.Text + i

Gestionaerror:
        If Err.Number <> 0 Then
            GestionError()
            Resume Next
        End If
        MsgBox("Se ha producido un error. Tipo de error = " + CStr(Err.Number) + " Descripción: " + Err.Description)
        lblError.Text = "La ejecucion continua"
    End Sub
End Class

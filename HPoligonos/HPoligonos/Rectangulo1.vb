Public Class Rectangulo1
    Private R1 As Rectangulo = New Rectangulo()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        R1.Plado1 = CDbl(txtLado1.Text)
        R1.Plado2 = CDbl(txtLado2.Text)
        R1.PnumLados = 4
        txtLado1.Text = ""
        txtLado2.Text = ""
        MsgBox("Cuadrado" + vbNewLine + "Numero de Lados: " + CStr(R1.PnumLados) + vbNewLine + "Lado 1: " + CStr(R1.Plado1) + vbNewLine + "Lado 2: " + CStr(R1.Plado2) + vbNewLine + "Area: " + CStr(R1.area()))
    End Sub
End Class
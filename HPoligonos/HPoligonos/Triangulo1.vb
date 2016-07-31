Public Class Triangulo1
    Private T1 As Triangulo = New Triangulo()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        T1.Pbase = CDbl(txtBase.Text)
        T1.Paltura = CDbl(txtAltura.Text)
        T1.PnumLados = 3
        txtBase.Text = ""
        txtAltura.Text = ""
        MsgBox("Triangulo" + vbNewLine + "Numero de Lados: " + CStr(T1.PnumLados) + vbNewLine + "Base: " + CStr(T1.Pbase) + vbNewLine + "Altura: " + CStr(T1.Paltura) + vbNewLine + "Area: " + CStr(T1.area()))
    End Sub
End Class
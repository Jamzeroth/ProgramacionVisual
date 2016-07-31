Imports EjemploDll
Public Class Form1

    Dim op As New EjemploDll.Operaciones
    Dim num1 As Integer
    Dim num2 As Integer


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        num1 = CInt(TextBox1.Text)
        num2 = CInt(TextBox2.Text)
        TextBox3.Text = CStr(op.sumar(num1, num2))
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        num1 = CInt(TextBox1.Text)
        num2 = CInt(TextBox2.Text)
        TextBox3.Text = CStr(op.restar(num1, num2))
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        num1 = CInt(TextBox1.Text)
        num2 = CInt(TextBox2.Text)
        TextBox3.Text = CStr(op.multiplicar(num1, num2))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        num1 = CInt(TextBox1.Text)
        num2 = CInt(TextBox2.Text)
        TextBox3.Text = CStr(op.dividir(num1, num2))
    End Sub
End Class

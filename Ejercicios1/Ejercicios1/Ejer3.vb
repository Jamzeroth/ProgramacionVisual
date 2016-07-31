Public Class Ejer3

    Private Sub btnFor_Click(sender As Object, e As EventArgs) Handles btnFor.Click
        Dim texto As String = ""
        For i As Integer = 1 To txtNum.Text
            texto = texto + CStr(i) + " "
        Next
        lblImpr.Text = texto
    End Sub

    Private Sub btnWhile_Click(sender As Object, e As EventArgs) Handles btnWhile.Click
        Dim texto As String = ""
        Dim i As Integer = 1
        While (i <= txtNum.Text)
            texto = texto + CStr(i) + " "
            i += 1
        End While
        lblImpr.Text = texto
    End Sub

    Private Sub btnDo_Click(sender As Object, e As EventArgs) Handles btnDo.Click
        Dim texto As String = ""
        Dim i As Integer = 1
        Do Until (i > txtNum.Text)
            texto = texto + CStr(i) + " "
            i += 1
        Loop
        lblImpr.Text = texto
    End Sub
End Class
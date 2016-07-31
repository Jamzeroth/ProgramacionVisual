Public Class Ejer5

    Private Sub btnFor_Click(sender As Object, e As EventArgs) Handles btnFor.Click
        Dim sum As Integer = 0
        For i As Integer = 1 To txtNum.Text
            sum += i
        Next
        lblSuma.Text = sum
    End Sub

    Private Sub btnWhile_Click(sender As Object, e As EventArgs) Handles btnWhile.Click
        Dim sum As Integer = 0
        Dim i As Integer = 1
        While (i <= txtNum.Text)
            sum += i
            i += 1
        End While
        lblSuma.Text = sum
    End Sub

    Private Sub btnDo_Click(sender As Object, e As EventArgs) Handles btnDo.Click
        Dim sum As Integer = 0
        Dim i As Integer = 1
        Do Until (i > txtNum.Text)
            sum += i
            i += 1
        Loop
        lblSuma.Text = sum
    End Sub
End Class
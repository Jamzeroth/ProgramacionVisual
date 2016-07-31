Public Class Form2

    Function factorial1(num As Integer) As Integer
        Dim resul As Integer = 1
        For i As Integer = 1 To num
            resul *= i
        Next
        Return resul
    End Function

    Function factorial2(num As Integer) As Integer
        Dim resul As Integer = 1
        Dim i As Integer = 1
        While (i <= num)
            resul *= i
            i += 1
        End While
        Return resul
    End Function

    Function factorial3(num As Integer) As Integer
        Dim resul As Integer = 1
        Dim i As Integer = 1
        Do Until (i > num)
            resul *= i
            i += 1
        Loop
        Return resul
    End Function

    Private Sub btnFor_Click(sender As Object, e As EventArgs) Handles btnFor.Click
        If (txtNum.Text <> "") Then
            lblResul.Text = CStr(factorial1(CInt(txtNum.Text)))
        End If
    End Sub

    Private Sub btnWhile_Click(sender As Object, e As EventArgs) Handles btnWhile.Click
        If (txtNum.Text <> "") Then
            lblResul.Text = CStr(factorial2(CInt(txtNum.Text)))
        End If
    End Sub

    Private Sub btnUntil_Click(sender As Object, e As EventArgs) Handles btnUntil.Click
        If (txtNum.Text <> "") Then
            lblResul.Text = CStr(factorial3(CInt(txtNum.Text)))
        End If
    End Sub
End Class
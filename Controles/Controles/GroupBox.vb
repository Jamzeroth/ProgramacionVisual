Public Class GroupBox

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
        For Each ctrl As Control In GroupBox1.Controls
            If TypeOf ctrl Is Label Then
                DirectCast(ctrl, Label).Font = New Font("Arial", 15, FontStyle.Bold)
            End If
        Next
    End Sub
End Class
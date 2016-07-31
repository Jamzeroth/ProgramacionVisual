Public Class RadioButton

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (RadioButton1.Checked) Then
            MsgBox(RadioButton1.Text)
            TextBox1.Text = RadioButton1.Text
        ElseIf (RadioButton2.Checked) Then
            MsgBox(RadioButton2.Text)
            TextBox1.Text = RadioButton2.Text
        ElseIf (RadioButton3.Checked) Then
            MsgBox(RadioButton3.Text)
            TextBox1.Text = RadioButton2.Text
        End If
    End Sub
End Class

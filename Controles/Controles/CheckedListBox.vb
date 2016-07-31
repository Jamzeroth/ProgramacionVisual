Public Class CheckedListBox

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged
        If (CheckedListBox1.GetItemChecked(0)) Then
            TextBox1.BackColor = Color.Red
            TextBox1.Text = "RED"
        Else
            TextBox1.BackColor = Color.White
            TextBox1.Text = ""
        End If
        If (CheckedListBox1.GetItemChecked(1)) Then
            TextBox2.BackColor = Color.Blue
            TextBox2.Text = "BLUE"
        Else
            TextBox2.BackColor = Color.White
            TextBox2.Text = ""
        End If
        If (CheckedListBox1.GetItemChecked(2)) Then
            TextBox3.BackColor = Color.Green
            TextBox3.Text = "GREEN"
        Else
            TextBox3.BackColor = Color.White
            TextBox3.Text = ""
        End If
    End Sub
End Class
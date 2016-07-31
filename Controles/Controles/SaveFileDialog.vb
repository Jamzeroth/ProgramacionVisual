Public Class SaveFileDialog

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text <> "") Then
            SaveFileDialog1.ShowDialog()
            System.IO.File.WriteAllText(SaveFileDialog1.FileName, TextBox1.Text)
        End If
    End Sub
End Class
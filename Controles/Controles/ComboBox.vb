Public Class ComboBox

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Add("Nombre: " + TextBox1.Text)
        ListBox1.Items.Add("Provincia: " + ComboBox1.SelectedItem)
        ListBox1.Items.Add("Canton: " + ComboBox2.SelectedItem)
    End Sub
End Class
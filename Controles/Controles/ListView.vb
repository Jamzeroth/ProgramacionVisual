Public Class ListView

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked Then
            Dim lvItm As ListViewItem
            lvItm = New ListViewItem("juan")
            lvItm.SubItems.Add("salazar")
            ListView1.Items.Add(lvItm)
            Dim item0 As New ListViewItem(New String() {"hola", "mundo"})
            ListView1.Items.AddRange(New ListViewItem() {item0})
        End If
    End Sub
End Class
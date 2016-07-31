Public Class TreeView
    Dim num As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            TreeView1.SelectedNode.Nodes.Add("Nodo " + CStr(num))
        Catch ex As Exception
            'MsgBox()
        End Try
    End Sub
End Class
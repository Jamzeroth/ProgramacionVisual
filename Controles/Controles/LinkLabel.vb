Public Class LinkLabel

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        LinkLabel1.LinkVisited = True
        System.Diagnostics.Process.Start("http://gravityfallstown.blogspot.com/2014/01/cortos-espanol-latino.html")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        LinkLabel1.LinkVisited = True
        System.Diagnostics.Process.Start("notepad")
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        LinkLabel1.LinkVisited = True
        System.Diagnostics.Process.Start("C:\Program Files (x86)\DAEMON Tools Pro\DTPro.exe")
    End Sub
End Class
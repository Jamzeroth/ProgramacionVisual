Public Class HelpProvider

    Private Sub HelpProvider_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HelpProvider1.SetHelpString(TextBox1, "Ingreso del código del estudiantes")
        HelpProvider1.SetHelpString(Button1, "Click para guardar")
    End Sub
End Class
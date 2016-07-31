Public Class Form1
    Dim n1, n2 As Double
    Dim ErrNum As Integer


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            n1 = Double.Parse(TextBox1.Text)
            n2 = Double.Parse(TextBox2.Text)

            ''Catch ex As FormatException
            ''MsgBox("ERROR" + ex.Message)

        Catch When ErrNum = 0
            MsgBox("ERROR: Ingreso el número 0")

        Finally
            MsgBox("MULTIPLICACIÓN DE DOS NÚMEROS")
        End Try
        resultado.Text = n1 * n2
    End Sub
End Class

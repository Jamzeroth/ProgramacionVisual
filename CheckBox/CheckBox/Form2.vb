Public Class Form2
    Dim com As Integer = 0
    Dim dra As Integer = 0
    Dim rom As Integer = 0
    Dim sus As Integer = 0
    Dim acc As Integer = 0
    Dim ec As Integer = 0

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If (cbxComedia.Checked) Then
            com += 1
        End If
        If (cbxDrama.Checked) Then
            dra += 1
        End If
        If (cbxRomance.Checked) Then
            rom += 1
        End If
        If (cbxSuspenso.Checked) Then
            sus += 1
        End If
        If (cbxAccion.Checked) Then
            acc += 1
        End If
        cbxComedia.CheckState = False
        cbxDrama.CheckState = False
        cbxRomance.CheckState = False
        cbxSuspenso.CheckState = False
        cbxAccion.CheckState = False
        ec += 1
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        lstPeliculas.Items.Clear()
        lstPeliculas.Items.Add("De " + CStr(ec) + " encuestas")
        lstPeliculas.Items.Add("Comedia: " + CStr(com))
        lstPeliculas.Items.Add("Drama: " + CStr(dra))
        lstPeliculas.Items.Add("Romance: " + CStr(rom))
        lstPeliculas.Items.Add("Suspenso: " + CStr(sus))
        lstPeliculas.Items.Add("Acción: " + CStr(acc))
    End Sub
End Class
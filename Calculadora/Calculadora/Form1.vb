Public Class Form1

    Dim Total As Decimal = 0
    Dim Parcial As Decimal = 0
    Dim op As Integer = 0

    Private Sub Operacion()
        Select Case op
            Case 1
                Total = Total + Parcial
                Parcial = 0
                lblDatos.Text = CStr(Parcial)
                op = 0
            Case 2
                Total = Total - Parcial
                Parcial = 0
                lblDatos.Text = CStr(Parcial)
                op = 0
            Case 3
                Total = Total * Parcial
                Parcial = 0
                lblDatos.Text = CStr(Parcial)
                op = 0
            Case 4
                If (Parcial <> 0) Then
                    Total = Total / Parcial
                    Parcial = 0
                    lblDatos.Text = CStr(Parcial)
                Else
                    Parcial = 0
                    lblDatos.Text = "No se puede dividir para 0"
                End If
                op = 0
        End Select
    End Sub

    Private Sub IngresarNum(ByVal Valor As String)
        If Parcial = 0 Then
            lblDatos.Text = ""
            lblDatos.Text = Valor
        Else
            lblDatos.Text += Valor
        End If
        Parcial = CDec(lblDatos.Text)
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        IngresarNum("1")
    End Sub
    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        IngresarNum("2")
    End Sub
    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        IngresarNum("3")
    End Sub
    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        IngresarNum("4")
    End Sub
    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        IngresarNum("5")
    End Sub
    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        IngresarNum("6")
    End Sub
    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        IngresarNum("7")
    End Sub
    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        IngresarNum("8")
    End Sub
    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        IngresarNum("9")
    End Sub
    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        IngresarNum("0")
    End Sub

    Private Sub btnMasmenos_Click(sender As Object, e As EventArgs) Handles btnMasmenos.Click
        If lblDatos.Text <> "" Then
            Parcial = Parcial * -1
            lblDatos.Text = CStr(Parcial)
        End If
    End Sub

    Private Sub btnComa_Click(sender As Object, e As EventArgs) Handles btnComa.Click
        IngresarNum(",")
    End Sub

    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        If (op <> 0) Then
            Operacion()
        Else
            Total = Parcial
            Parcial = 0
            lblDatos.Text = CStr(Parcial)
        End If
        lblProcesos.Text = CStr(Decimal.Round(Total, 4)) + " + "
        op = 1
    End Sub

    Private Sub btnRes_Click(sender As Object, e As EventArgs) Handles btnRes.Click
        If (op <> 0) Then
            Operacion()
        Else
            Total = Parcial
            Parcial = 0
            lblDatos.Text = CStr(Parcial)
        End If
        lblProcesos.Text = CStr(Decimal.Round(Total, 4)) + " - "
        op = 2
    End Sub

    Private Sub btnMul_Click(sender As Object, e As EventArgs) Handles btnMul.Click
        If (op <> 0) Then
            Operacion()
        Else
            Total = Parcial
            Parcial = 0
            lblDatos.Text = CStr(Parcial)

        End If
        lblProcesos.Text = CStr(Decimal.Round(Total, 4)) + " x "
        op = 3
    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        If (op <> 0) Then
            Operacion()
        Else
            Total = Parcial
            Parcial = 0
            lblDatos.Text = CStr(Parcial)
        End If
        lblProcesos.Text = CStr(Decimal.Round(Total, 4)) + " / "
        op = 4
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        lblDatos.Text = "0"
        lblProcesos.Text = ""
        Parcial = 0
        Total = 0
        op = 0
    End Sub

    Private Sub btnCE_Click(sender As Object, e As EventArgs) Handles btnCE.Click
        lblDatos.Text = "0"
        Parcial = 0
    End Sub

    Private Sub btnIgual_Click(sender As Object, e As EventArgs) Handles btnIgual.Click
        If (op = 0) Then
            Total = Parcial
        Else
            Operacion()
        End If
        If (lblDatos.Text = "No se puede dividir para 0") Then
            Parcial = 0
        Else
            Parcial = Total
        End If
        lblProcesos.Text = CStr(Decimal.Round(Total, 4))
    End Sub

    Private Sub btnDivunoparax_Click(sender As Object, e As EventArgs) Handles btnDivunoparax.Click
        If (Parcial <> 0) Then
            Total = 1 / Parcial
            Parcial = 0
            lblProcesos.Text = CStr(Decimal.Round(Total, 4))
            lblDatos.Text = CStr(Parcial)
        Else
            Parcial = 0
            lblDatos.Text = "No se puede dividir para 0"
        End If
    End Sub

    Private Sub btnCuadrado_Click(sender As Object, e As EventArgs) Handles btnCuadrado.Click
        Total = Parcial * Parcial
        Parcial = 0
        lblProcesos.Text = CStr(Decimal.Round(Total, 4))
        lblDatos.Text = CStr(Parcial)
    End Sub

    Private Sub btnPorcen_Click(sender As Object, e As EventArgs) Handles btnPorcen.Click
        Total = Total * Parcial / 100
        Parcial = 0
        lblDatos.Text = CStr(Parcial)
        lblProcesos.Text = CStr(Decimal.Round(Total, 4))
    End Sub

    Private Sub btnRaiz_Click(sender As Object, e As EventArgs) Handles btnRaiz.Click
        If (Parcial < 0) Then
            Parcial = 0
            lblProcesos.Text = "Raíz no válida"
            lblDatos.Text = CStr(Parcial)
        Else
            Total = Parcial ^ (1 / 2)
            Parcial = 0
            lblProcesos.Text = CStr(Decimal.Round(Total, 4))
            lblDatos.Text = CStr(Parcial)
        End If
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        lblDatos.Text = "0"
        Parcial = 0
    End Sub
End Class
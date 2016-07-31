Public Class Form1
    Dim nombre As String
    Dim edad As Integer
    Dim nombres As New List(Of String)
    Dim edades As New List(Of Integer)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Me.Chart1.Series("Edad").Points.AddXY("Lola", 10)
        'nombre = txtNombre.Text
        'edad = CInt(txtEdad.Text)
        'Me.Chart1.Series("Edad").Points.AddXY(nombre, edad)
        'txtNombre.Text = ""
        'txtEdad.Text = ""
        'txtNombre.Focus()
        For i As Integer = 0 To nombres.Count - 1
            Me.Chart1.Series("Edad").Points.AddXY(nombres.Item(i), edades.Item(i))
        Next
    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNombre.Validating
        If txtNombre.Text = "" Then
            MsgBox("El cuadro de texto esta vacío", vbCritical, "Advertencia")
            txtNombre.Focus()
        End If
    End Sub

    Private Sub txtEdad_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtEdad.Validating
        If txtEdad.Text = "" Then
            MsgBox("El cuadro de edad esta vacío", vbCritical, "Advertencia")
            txtEdad.Focus()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (txtNombre.Text = "" Or txtEdad.Text = "") Then
            MsgBox("Uno de los cuadros de texto esta vacío", vbCritical, "Advertencia")
        Else
            nombre = txtNombre.Text
            edad = CInt(txtEdad.Text)
            nombres.Add(nombre)
            edades.Add(edad)
            txtNombre.Clear()
            txtEdad.Clear()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked) Then
            Me.Chart1.ChartAreas(0).Area3DStyle.Enable3D = True
        Else
            Me.Chart1.ChartAreas(0).Area3DStyle.Enable3D = False
        End If
    End Sub
End Class

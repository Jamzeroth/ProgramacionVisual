Public Class Form1
    Dim Est1 As Estudiante = New Estudiante("", "", 0, 0)
    Dim Est2 As Estudiante = New Estudiante("", "", 0, 0)
    Dim Est3 As Estudiante = New Estudiante("", "", 0, 0)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Est1.setNombre(txtNombre.Text)
        Est1.setApellido(txtApellido.Text)
        Est1.setCurso(CInt(txtCurso.Text))
        Est1.setNota(CInt(txtNota.Text))
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Est2.Pnombre = txtNombre.Text
        Est2.Papellido = txtApellido.Text
        Est2.Pcurso = CInt(txtCurso.Text)
        Est2.Pnota = CInt(txtNota.Text)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Est3.setNombre(txtNombre.Text)
        Est3.Papellido = txtApellido.Text
        Est3.setCurso(CInt(txtCurso.Text))
        Est3.Pnota = CInt(txtNota.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Lista.Items.Clear()
        Lista.Items.Add("Nombre                 Apellido                Curso               Nota")
        Lista.Items.Add(Est1.getNombre + "                         " + Est1.getApellido + "                 " + CStr(Est1.getCurso) + "                      " + CStr(Est1.getNota))
        Lista.Items.Add(Est2.getNombre + "                         " + Est2.getApellido + "                 " + CStr(Est2.getCurso) + "                      " + CStr(Est2.getNota))
        Lista.Items.Add(Est3.getNombre + "                         " + Est3.getApellido + "                 " + CStr(Est3.getCurso) + "                      " + CStr(Est3.getNota))
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Lista.Items.Clear()
        Lista.Items.Add("Nombre                 Apellido                Curso               Nota")
        Lista.Items.Add(Est1.Pnombre + "                         " + Est1.Papellido + "                 " + CStr(Est1.Pcurso) + "                      " + CStr(Est1.Pnota))
        Lista.Items.Add(Est2.Pnombre + "                         " + Est2.Papellido + "                 " + CStr(Est2.Pcurso) + "                      " + CStr(Est2.Pnota))
        Lista.Items.Add(Est3.Pnombre + "                         " + Est3.Papellido + "                 " + CStr(Est3.Pcurso) + "                      " + CStr(Est3.Pnota))
    End Sub
End Class

Public Class Estudiante

    Inherits Persona
    Private carrera As String

    Sub New()
    End Sub

    Sub New(ByVal carrera1 As String)
        Me.carrera = carrera1
    End Sub

    Public Sub SetCarrera(ByVal carrera1 As String)
        carrera = carrera1
    End Sub

    Public Function GetCarrera() As String
        Return carrera
    End Function

    Overrides Sub Imprimir()
        MessageBox.Show(MyBase.GetNombre)
        MessageBox.Show(MyBase.GetTelefono)
        MessageBox.Show(Me.GetCarrera)
        MessageBox.Show(Me.carrera)
    End Sub
End Class

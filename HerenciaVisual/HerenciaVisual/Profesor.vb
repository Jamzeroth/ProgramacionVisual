Public Class Profesor
    Inherits Persona

    Private especialidad As String

    Sub New()
    End Sub

    Sub New(ByVal especialidad1 As String)
        Me.especialidad = especialidad1
    End Sub

    Public Sub SetEspecialidad(ByVal especialidad1 As String)
        especialidad = especialidad1
    End Sub

    Public Function GetEspecialidad() As String
        Return especialidad
    End Function
End Class

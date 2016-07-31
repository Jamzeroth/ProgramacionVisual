Public Class Estudiante
    Private Nombre As String
    Private Apellido As String
    Private Curso As Integer
    Private Nota As Integer

    Sub New(ByVal nom As String, ByVal ape As String, ByVal cur As Integer, ByVal nota As Integer)
        Me.Nombre = nom
        Me.Apellido = ape
        Me.Curso = cur
        Me.Nota = nota
    End Sub

    Sub setNombre(ByVal val As String)
        Me.Nombre = val
    End Sub
    Sub setApellido(ByVal val As String)
        Me.Apellido = val
    End Sub
    Sub setCurso(ByVal val As Integer)
        Me.Curso = val
    End Sub
    Sub setNota(ByVal val As Integer)
        Me.Nota = val
    End Sub

    Function getNombre() As String
        Return Me.Nombre
    End Function
    Function getApellido() As String
        Return Me.Apellido
    End Function
    Function getCurso() As Integer
        Return Me.Curso
    End Function
    Function getNota() As Integer
        Return Me.Nota
    End Function

    Public Property Pnombre() As String
        Get
            Return Me.Nombre
        End Get
        Set(value As String)
            Me.Nombre = value
        End Set
    End Property
    Public Property Papellido() As String
        Get
            Return Me.Apellido
        End Get
        Set(value As String)
            Me.Apellido = value
        End Set
    End Property
    Public Property Pcurso() As String
        Get
            Return Me.Curso
        End Get
        Set(value As String)
            Me.Curso = value
        End Set
    End Property
    Public Property Pnota() As String
        Get
            Return Me.Nota
        End Get
        Set(value As String)
            Me.Nota = value
        End Set
    End Property
End Class

Public Class Persona
    Private nombre As String
    Private apellido As String
    Private edad As Integer

    Public Property Pnombre() As String
        Get
            Return nombre
        End Get
        Set(value As String)
            Me.nombre = value
        End Set
    End Property

    Public Property Papellido() As String
        Get
            Return apellido
        End Get
        Set(value As String)
            Me.apellido = value
        End Set
    End Property

    Public Property Pedad() As Integer
        Get
            Return edad
        End Get
        Set(value As Integer)
            Me.edad = value
        End Set
    End Property
End Class

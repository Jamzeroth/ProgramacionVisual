Public Class Persona
    Private Nombre As String
    Private Apellido As String
    Private Edad As Integer
    Private Telefono As String

    Sub New()
    End Sub

    Public Property Pnombre As String
        Get
            Return Nombre
        End Get
        Set(value As String)
            Nombre = value
        End Set
    End Property

    Public Property Papellido As String
        Get
            Return Apellido
        End Get
        Set(value As String)
            Apellido = value
        End Set
    End Property
    Public Property Ptelefono As String
        Get
            Return Telefono
        End Get
        Set(value As String)
            Telefono = value
        End Set
    End Property
    Property Pedad As Integer
        Get
            Return Edad
        End Get
        Set(value As Integer)
            Edad = value
        End Set
    End Property


End Class

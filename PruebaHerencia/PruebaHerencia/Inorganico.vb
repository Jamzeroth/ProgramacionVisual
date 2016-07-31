Public Class Inorganico
    Inherits Producto
    Private tiempoGarantia As Integer
    Private tipo As String

    Property PtiempoG As Integer
        Get
            Return tiempoGarantia
        End Get
        Set(value As Integer)
            tiempoGarantia = value
        End Set
    End Property

    Property Ptipo As String
        Get
            Return tipo
        End Get
        Set(value As String)
            tipo = value
        End Set
    End Property

End Class

Public Class Rectangulo
    Inherits Poligono
    Private lado1 As Double
    Private lado2 As Double

    Property Plado1 As Double
        Get
            Return lado1
        End Get
        Set(value As Double)
            lado1 = value
        End Set
    End Property

    Property Plado2 As Double
        Get
            Return lado2
        End Get
        Set(value As Double)
            lado2 = value
        End Set
    End Property

    Public Function area() As Double
        Return lado1 * lado2
    End Function
End Class

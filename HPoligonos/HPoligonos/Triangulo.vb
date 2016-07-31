Public Class Triangulo
    Inherits Poligono
    Private base As Double
    Private altura As Double

    Property Pbase As Double
        Get
            Return base
        End Get
        Set(value As Double)
            base = value
        End Set
    End Property

    Property Paltura As Double
        Get
            Return altura
        End Get
        Set(value As Double)
            altura = value
        End Set
    End Property

    Public Function area() As Double
        Return base * altura / 2
    End Function
End Class

Public Class Producto
    Private nombre As String
    Private precio As Decimal

    Public Function iva() As Decimal
        Return precio * 0.14
    End Function

    Property Pnombre As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Property Pprecio As Decimal
        Get
            Return precio
        End Get
        Set(value As Decimal)
            precio = value
        End Set
    End Property
End Class

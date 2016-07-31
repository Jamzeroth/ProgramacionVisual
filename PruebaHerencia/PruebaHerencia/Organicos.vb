Public Class Organicos
    Inherits Producto
    Private tiempoExp As Integer
    Private tipo As String

    Public Function reduccion(ByVal val As Decimal) As Decimal
        If val < 5 Then
            Return val - 0.2 * tiempoExp
        Else
            Return val
        End If
    End Function

    Property Ptiempo As Integer
        Get
            Return tiempoExp
        End Get
        Set(value As Integer)
            tiempoExp = value
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

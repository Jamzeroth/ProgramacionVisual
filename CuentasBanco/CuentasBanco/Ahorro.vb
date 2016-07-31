Public Class Ahorro
    Inherits Cuenta
    Private interes As Decimal

    Property PInteres As Decimal
        Get
            Return interes
        End Get
        Set(value As Decimal)
            interes = value
        End Set
    End Property

End Class
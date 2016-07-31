Public Class Cuenta
    Private Num As String
    Private Nombre As String
    Private Saldo As Decimal

    Property PNum As String
        Get
            Return Num
        End Get
        Set(value As String)
            Num = value
        End Set
    End Property

    Property PNombre As String
        Get
            Return Nombre
        End Get
        Set(value As String)
            Nombre = value
        End Set
    End Property

    Property PSaldo As Decimal
        Get
            Return Saldo
        End Get
        Set(value As Decimal)
            Saldo = value
        End Set
    End Property

End Class

Public Class Corriente
    Inherits Cuenta
    Private Cheques As Integer

    Property PCheques As Integer
        Get
            Return Cheques
        End Get
        Set(value As Integer)
            Cheques = value
        End Set
    End Property

End Class

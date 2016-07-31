Public Class Deportivo
    Inherits Zapato
    Private Deporte As String

    Property Pdeporte As String
        Get
            Return Deporte
        End Get
        Set(value As String)
            Deporte = value
        End Set
    End Property
End Class

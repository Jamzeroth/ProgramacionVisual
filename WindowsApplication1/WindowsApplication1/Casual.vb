Public Class Casual
    Inherits Zapato
    Private Evento As String

    Property Pevento As String
        Get
            Return Evento
        End Get
        Set(value As String)
            Evento = value
        End Set
    End Property
End Class

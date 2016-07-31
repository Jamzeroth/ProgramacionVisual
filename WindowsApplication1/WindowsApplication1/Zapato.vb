Public Class Zapato
    Private Marca As String
    Private Talla As Integer

    Property Pmarca As String
        Get
            Return Marca
        End Get
        Set(value As String)
            Marca = value
        End Set
    End Property

    Property Ptalla As String
        Get
            Return Talla
        End Get
        Set(value As String)
            Talla = value
        End Set
    End Property
End Class

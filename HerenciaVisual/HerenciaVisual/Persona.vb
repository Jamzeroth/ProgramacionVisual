Public Class Persona
    Private nombre As String
    Private telefono As String

    Sub New()
    End Sub

    Sub New(ByVal nombre1 As String, ByVal telefono1 As String)
        Me.nombre = nombre1
        Me.telefono = telefono1
    End Sub

    Sub New(ByVal nombre1 As String)
        Me.nombre = nombre1
    End Sub

    Public Function GetNombre() As String
        Return Me.nombre
    End Function

    Public Function GetTelefono() As String
        Return Me.telefono
    End Function

    Public Sub SetNombre(ByVal nombre1 As String)
        nombre = nombre1
    End Sub

    Public Sub SetTelefono(ByVal telefono1 As String)
        telefono = telefono1
    End Sub

    Overridable Sub Imprimir()
        MessageBox.Show(Me.nombre)
        MessageBox.Show(Me.telefono)
    End Sub

End Class

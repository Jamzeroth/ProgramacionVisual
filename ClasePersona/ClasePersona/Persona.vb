Public Class Persona
    'Seccion de atributos
    Private nombre As String
    Private apellido As String
    Private edad As Integer

    'Seccion de constructores
    'Constructor sin parametros

    Sub New()
    End Sub

    Sub New(ByVal nombre1 As String, ByVal apellido1 As String, ByVal edad1 As Integer)
        Me.nombre = nombre1
        Me.nombre = apellido1
        Me.edad = edad1
    End Sub

    'Sets()
    Sub setNombre(ByVal nombre1 As String)
        Me.nombre = nombre1
    End Sub

    Sub setApellido(ByVal apellido1 As String)
        Me.apellido = apellido1
    End Sub

    Sub setEdad(ByVal edad1 As Integer)
        Me.edad = edad1
    End Sub

    'Gets()
    Function getNombre() As String
        Return Me.nombre
    End Function

    Function getApellido() As String
        Return Me.apellido
    End Function

    Function getEdad() As Integer
        Return Me.edad
    End Function

    Sub Imprimir()
        Console.WriteLine("Nombre: " + Me.nombre)
        Console.WriteLine("Apellido: " + Me.apellido)
        Console.WriteLine("Edad: " + CStr(Me.edad))
    End Sub

End Class

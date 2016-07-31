Public Class Vehiculo
    Private marca As String
    Private cilindraje As Integer
    Private matricula As String
    Private velocidad As Integer
    Private marcha As Integer

    Sub New()
    End Sub

    Sub New(ByVal marca1 As String, ByVal cilin As Integer, ByVal matri As String, ByVal velo As Integer, ByVal marcha1 As Integer)
        Me.marca = marca1
        Me.cilindraje = cilin
        Me.matricula = matri
        Me.velocidad = velo
        Me.marcha = marcha1
    End Sub

    'Set()
    Sub setMarca(ByVal marca1 As String)
        Me.marca = marca1
    End Sub

    Sub setCilindraje(ByVal cilin As Integer)
        Me.cilindraje = cilin
    End Sub

    Sub setMatricula(ByVal matri As String)
        Me.matricula = matri
    End Sub

    Sub setVelocidad(ByVal velo As Integer)
        Me.velocidad = velo
    End Sub

    Sub setMarcha(ByVal marcha1 As Integer)
        Me.marcha = marcha1
    End Sub

    'Get()
    Function getMarca() As String
        Return Me.marca
    End Function

    Function getCilindraje() As Integer
        Return Me.cilindraje
    End Function

    Function getMatricula() As String
        Return Me.matricula
    End Function

    Function getVelocidad() As Integer
        Return Me.velocidad
    End Function

    Function getMarcha() As Integer
        Return Me.marcha
    End Function

    Sub acelerar(ByVal vel As Integer)
        Me.velocidad += vel
        Console.WriteLine("Velocidad actual: " + CStr(Me.velocidad))
    End Sub

    Sub frenar(ByVal vel As Integer)
        Me.velocidad -= vel
        Console.WriteLine("Velocidad actual: " + CStr(Me.velocidad))
    End Sub

    Sub cambiamarcha(ByVal marcha1 As Integer)
        If marcha1 >= 0 And marcha1 <= 5 Then
            Me.marcha = marcha1
            Console.WriteLine("Marcha actual: " + CStr(Me.marcha))
        Else
            Console.WriteLine("No es posible cambiar de marcha")
            Console.WriteLine("Marcha actual: " + CStr(Me.marcha))
        End If
    End Sub

    Sub imprimir()
        Console.WriteLine("Marca: " + Me.marca)
        Console.WriteLine("Cilindraje: " + CStr(Me.cilindraje))
        Console.WriteLine("Matricula: " + Me.matricula)
        Console.WriteLine("Velocidad: " + CStr(Me.velocidad))
        Console.WriteLine("Marcha: " + CStr(Me.marcha))
    End Sub
End Class

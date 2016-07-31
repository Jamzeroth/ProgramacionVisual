Module Module1
    Sub Main()
        'Instanciar la clase Persona
        'Crear objetos de la clase persona
        '1era. Manera
        Dim p1 As Persona = New Persona()
        p1.setNombre("Francisco")
        p1.setApellido("Armas")
        p1.setEdad(19)

        '2da. Manera
        Dim p2 As Persona = New Persona("Lizeth", "Duque", 19)

        '3ra. Manera
        Dim p3 As New Persona()
        With p3
            .setNombre("Darwin")
            .setApellido("Guailla")
            .setEdad(20)
        End With

        'Mostrar los objetos creados
        Console.WriteLine("Persona 1")
        Console.WriteLine("Nombre: " + p1.getNombre())
        Console.WriteLine("Apellido: " + p1.getApellido())
        Console.WriteLine("Edad: " + CStr(p1.getEdad))

        Console.WriteLine("Persona 2")
        Console.WriteLine("Nombre: " + p2.getNombre())
        Console.WriteLine("Apellido: " + p2.getApellido())
        Console.WriteLine("Edad: " + CStr(p2.getEdad))

        Console.WriteLine("Persona 3")
        Console.WriteLine("Nombre: " + p3.getNombre())
        Console.WriteLine("Apellido: " + p3.getApellido())
        Console.WriteLine("Edad: " + CStr(p3.getEdad))

        Console.WriteLine("Persona 1")
        p1.Imprimir()

        Console.WriteLine("Persona 2")
        p2.Imprimir()

        Console.WriteLine("Persona 3")
        p3.Imprimir()
    End Sub
End Module

Module Module1

    Sub Main()
        Dim per1 As Persona = New Persona()
        Dim per2 As Persona = New Persona()
        per1.Pnombre = "Juanito"
        per1.Papellido = "Rodriguez"
        per1.Pedad = 20
        Console.WriteLine("     Persona 1")
        Console.WriteLine("Nombre: " + per1.Pnombre)
        Console.WriteLine("Apellido: " + per1.Papellido)
        Console.WriteLine("Edad: " + CStr(per1.Pedad))
        Console.ReadKey()
    End Sub

End Module

Module Module1
    Sub Main()
        'Menu acelerar o frenar o imprimir de que vehiculo
        Dim op As Integer = -1
        Dim v1 As Vehiculo = New Vehiculo("Chevrolet", 1600, "MBX-4562", 40, 4)
        Dim v2 As Vehiculo = New Vehiculo("Mazda", 1200, "MAA-2351", 10, 1)
        Console.WriteLine("     Vehículo 1")
        v1.imprimir()
        Console.WriteLine("     Vehículo 2")
        v2.imprimir()
        Do Until (op = 0)
            Console.WriteLine("")
            Console.WriteLine("     MENU")
            Console.WriteLine("1) Acelerar")
            Console.WriteLine("2) Frenar")
            Console.WriteLine("3) Cambiar de Marcha")
            Console.WriteLine("4) Imprimir")
            Console.WriteLine("0) Salir")
            op = CInt(Console.ReadLine())
            Select Case op
                Case 1
                    op = -1
                    Do Until (op = 1 Or op = 2 Or op = 0)
                        Console.WriteLine("")
                        Console.WriteLine("     MENU")
                        Console.WriteLine("1) Acelerar Vehículo 1")
                        Console.WriteLine("2) Acelerar Vehículo 2")
                        Console.WriteLine("0) Atrás")
                        op = CInt(Console.ReadLine())
                    Loop
                    Select Case op
                        Case 1
                            Console.WriteLine("Cuanto Acelera Vehículo 1: ")
                            op = CInt(Console.ReadLine())
                            v1.acelerar(op)
                            op = -1
                        Case 2
                            Console.WriteLine("Cuanto Acelera Vehículo 2: ")
                            op = CInt(Console.ReadLine())
                            v2.acelerar(op)
                            op = -1
                        Case Else
                            op = -1
                    End Select
                Case 2
                    op = -1
                    Do Until (op = 1 Or op = 2 Or op = 0)
                        Console.WriteLine("")
                        Console.WriteLine("     MENU")
                        Console.WriteLine("1) Frenar Vehículo 1")
                        Console.WriteLine("2) Frenar Vehículo 2")
                        Console.WriteLine("0) Atrás")
                        op = CInt(Console.ReadLine())
                    Loop
                    Select Case op
                        Case 1
                            Console.WriteLine("Cuanto Frena Vehículo 1: ")
                            op = CInt(Console.ReadLine())
                            v1.frenar(op)
                            op = -1
                        Case 2
                            Console.WriteLine("Cuanto Frena Vehículo 2: ")
                            op = CInt(Console.ReadLine())
                            v2.frenar(op)
                            op = -1
                        Case Else
                            op = -1
                    End Select
                Case 3
                    op = -1
                    Do Until (op = 1 Or op = 2 Or op = 0)
                        Console.WriteLine("")
                        Console.WriteLine("     MENU")
                        Console.WriteLine("1) Cambiar de Marcha a Vehículo 1")
                        Console.WriteLine("2) Cambiar de Marcha a Vehículo 2")
                        Console.WriteLine("0) Atrás")
                        op = CInt(Console.ReadLine())
                    Loop
                    Select Case op
                        Case 1
                            Console.WriteLine("Nueva Marcha de Vehículo 1: ")
                            op = CInt(Console.ReadLine())
                            v1.cambiamarcha(op)
                            op = -1
                        Case 2
                            Console.WriteLine("Nueva marcha de Vehículo 2: ")
                            op = CInt(Console.ReadLine())
                            v2.cambiamarcha(op)
                            op = -1
                        Case Else
                            op = -1
                    End Select
                Case 4
                    Console.WriteLine("")
                    Console.WriteLine("     Vehículo 1")
                    v1.imprimir()
                    Console.WriteLine("     Vehículo 2")
                    v2.imprimir()
            End Select
        Loop
    End Sub
End Module

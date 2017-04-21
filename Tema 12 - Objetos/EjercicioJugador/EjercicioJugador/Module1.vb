Option Strict On
Module Module1

    Sub Main()
        Dim j1 As Jugador = New Jugador()
        Dim j2 As Jugador
        ' Try
        j2 = New Jugador("WE34", "Pepe", "Gracias Toto", 450)
        'Catch ex As Exception
        '    Console.WriteLine(ex.Message)
        'End Try

        '  Try
        j1.setCodigo("WE4")
        'Catch ex As Exception
        '    Console.WriteLine(ex.Message)
        'End Try


        j1.nombre = "Mazinho"
        j1.puntos = 2000
        j1.setSaldo(100)
        '  Try
        j1.setCorreo("mazinhogmail.com")
        'Catch ex As Exception
        '    Console.WriteLine(ex.Message)
        'End Try


        Console.WriteLine(j1.ToString())
        Console.WriteLine(j2.ToString())

        Console.WriteLine("Los correos son")
        Console.WriteLine(j1.getCorreo())
        Console.WriteLine(j2.getCorreo())

        Console.WriteLine("Los dominios son:")
        ' Console.WriteLine(j1.getCorreo().Substring(6))
        Console.ReadLine()

    End Sub

End Module

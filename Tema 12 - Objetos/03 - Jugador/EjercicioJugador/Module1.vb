Option Strict On
Module Module1

    Sub Main()

        'Acceso a atributo Shared competicion
        Jugador.setCompeticion("Premier")

        Dim j1 As Jugador = New Jugador()
        Dim j2 As Jugador
        ' Try
        j2 = New Jugador("WE34", "Pepe", "Gracias@Toto", 450)
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
        j2.setCorreo("toto@gmail.com")
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

        '**************** *******************
        '24 Abril 2017 Explicación Shared
        'Comparar puntos de dos jugarores
        If j1.puntos > j2.puntos Then
            Console.WriteLine(j1)
        Else
            Console.WriteLine(j2)
        End If

        Dim jGanador As Jugador = Jugador.getJugadorConMasPuntos(j1, j2)
        Console.WriteLine(jGanador)

        Jugador.printInfo()
        printInfo()

        Console.WriteLine()

        '**************** *******************
        '24 Abril 2017 Explicación Matrices

        'Matrices de objetos
        Dim equipo(10) As Jugador
        '  Dim equipo2() As Jugador = New Jugador() {j1, j2}


        equipo(0) = New Jugador("WE·$", "Pedro", "pedro@gmail.com", 450)
        equipo(1) = j1
        equipo(2) = j2
        '  Dim j3 As Jugador = New Jugador("QE34", "Zoel", "zoel@ciclosmontecastelo.com", 900)
        Jugador.guardarJugador(equipo, New Jugador("QE34", "Zoel", "zoel@ciclosmontecastelo.com", 900))

        'Visualizar por pantalla jugadores de la matriz
        Console.WriteLine("Matriz de jugadores: ")
        For Each j As Jugador In equipo
            If Not j Is Nothing Then
                Console.WriteLine(j)
            Else
                Exit For
            End If

        Next
        Console.WriteLine()
        Console.WriteLine("Buscar jugador por código")
        'Buscar jugador por código
        Dim pos As Integer = Jugador.getPosJugador(equipo, "QE34")
        If pos >= 0 Then
            Console.WriteLine(equipo(pos))
        End If




        Console.ReadLine()
    End Sub

End Module

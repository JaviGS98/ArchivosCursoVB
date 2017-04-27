Option Strict On
Imports System.IO
Module Module1

    Sub Main()
        Dim jugadores(9) As Jugador

        'Volcar un jugador a un fichero
        Dim j As Jugador = New Jugador("423124", "Pepe", "pepe@gmail.com", 900)
        Dim ruta As String = Directory.GetCurrentDirectory() + "/jugadores.txt"
        Dim escritor As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(ruta, True)
        escritor.WriteLine(j.ToString())
        ' escritor.WriteLine(j.getCodigo() + "*" + j.nombre + "*")
        escritor.Close()

        'Recuperar datos del fichero a la matriz
        ' 1- Crear el lector
        Dim lector As StreamReader = My.Computer.FileSystem.OpenTextFileReader(ruta)
        Dim i As Integer = 0
        '2 - Recorrer los registros
        While Not lector.EndOfStream
            '3 - Troceo el registro para obtener datos objeto
            Dim cachos() As String = lector.ReadLine().Split("*"c)
            '4 - Creo el objeto
            Dim ju As Jugador = New Jugador()
            '5- le asigno sus datos
            ju.setCodigo(cachos(0))
            ju.nombre = cachos(1)
            ju.setCorreo(cachos(2))
            ju.puntos = Convert.ToInt32(cachos(3))
            ju.setSaldo(Convert.ToInt32(cachos(4)))

            ' 6. Buscar pos vacía en la matriz
            Jugador.guardarJugador(jugadores, ju)
            'If jugadores(i) Is Nothing Then
            '    jugadores(i) = ju

            'End If
            'i += 1
        End While
        lector.Close()
        For Each juga As Jugador In jugadores
            If Not juga Is Nothing Then
                Console.WriteLine(juga)
            Else
                Exit For
            End If

        Next

        Console.ReadLine()
    End Sub

End Module

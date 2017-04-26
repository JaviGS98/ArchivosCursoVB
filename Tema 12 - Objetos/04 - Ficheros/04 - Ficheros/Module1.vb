Option Strict On
Imports System.IO
Module Module1

    Sub Main()
        Dim sniper As Sniper = New Sniper("12e1243", "Chris Kyle", 200, 0.9)
        'Guardar en fichero
        Dim ruta As String = Directory.GetCurrentDirectory() + "/snipers.txt"
        Dim escritor As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(ruta, True)

        'Semi-profesional:
        escritor.WriteLine(sniper.guardarFichero())
        'Beginner:
        'escritor.WriteLine(sniper.codigo + "*" + sniper.nombre + "*" + sniper.balas.ToString() + "*" + sniper.precision.ToString())
        escritor.Close()
        Console.WriteLine(sniper.guardarFichero())


        ' Leer registros del fichero y pasarlos a matriz de Snipers
        Dim misSnipers(9) As Sniper
        Dim lector As StreamReader = My.Computer.FileSystem.OpenTextFileReader(ruta)
        Dim i As Integer = 0
        While Not lector.EndOfStream
            '1 - Splittear registro
            Dim tokens() As String = lector.ReadLine().Split("*"c)
            '2 - Crear un sniper
            Dim s As Sniper = New Sniper()
            s.codigo = tokens(0)
            s.nombre = tokens(1)
            s.balas = Convert.ToInt32(tokens(2))
            s.precision = Convert.ToSingle(tokens(3))
            '3-Guardarlo en la matriz
            If misSnipers(i) Is Nothing Then
                misSnipers(i) = s
            End If
            i += 1
        End While
        lector.Close()

        'Comprobar matriz snipers
        For Each sni As Sniper In misSnipers
            If Not sni Is Nothing Then
                Console.WriteLine(sni)
            Else
                Exit For
            End If

        Next
        Console.ReadLine()
    End Sub

End Module

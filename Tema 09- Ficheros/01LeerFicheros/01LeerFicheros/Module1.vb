Option Strict On
Imports System.IO
Module Module1

    Sub Main()
        Dim lector As StreamReader = My.Computer.FileSystem.OpenTextFileReader("C:\Users\usuario\Desktop\prueba.txt")
        Dim contenido As String = lector.ReadToEnd()
        Console.WriteLine(contenido)
        Console.ReadLine()
        Console.WriteLine()
        lector.Close()
        Console.WriteLine("Ahora leo linea por linea")
        'debo de volver a abrir el lector
        lector = My.Computer.FileSystem.OpenTextFileReader("C:\Users\usuario\Desktop\prueba.txt")
        'Leyendo linea por linea
        While Not lector.EndOfStream
            Dim registro As String = lector.ReadLine()
            Console.WriteLine(registro)
        End While
        'cerramos el lector

        lector.Close()

        Console.ReadLine()



    End Sub
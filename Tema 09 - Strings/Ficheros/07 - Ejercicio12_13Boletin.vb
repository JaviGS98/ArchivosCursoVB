Option Strict On
Imports System.IO
Module Module1
    Sub escribirFichero(ByRef ruta As String, ByRef nombre As String, ByRef mensaje As String)
        Dim rutaCompleta As String = String.Concat(ruta, "\", nombre)
        Dim escritor As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(rutaCompleta, True)
        escritor.WriteLine(mensaje)
        escritor.Close()
    End Sub
    Sub Main()
        Dim ruta As String = "C:\Users\usuario\Desktop\prueba.txt"
        Dim lector As StreamReader = My.Computer.FileSystem.OpenTextFileReader(ruta)
        Dim registros(99) As String
        Dim i As Integer = 0

        'Leemos registro a registro

        While Not lector.EndOfStream
            registros(i) = lector.ReadLine()
            i = i + 1
        End While

        lector.Close()
        'Mostrar matriz por consola para comprobar registros

        For Each reg As String In registros
            If Not reg Is Nothing Then
                Console.WriteLine(reg)
            Else
                Exit For
            End If
        Next


        'Escribimos un mensaje en el fichero

        escribirFichero("C:\Users\usuario\Desktop", "prueba.txt", "Probando funcion escribirFichero")

        'Mostrar matriz por consola para comprobar registros
        Console.WriteLine("****** Se añadió un registro **************")

        For Each reg As String In registros
            If Not reg Is Nothing Then
                Console.WriteLine(reg)
            Else
                Exit For
            End If
        Next
        Console.ReadLine()

    End Sub

End Module

Option Strict On
Imports System.IO
Module Module1

    Function leerFichero(ByVal ruta As String, ByRef nombre As String) As String
        Dim rutaCompleta As String = String.Concat(ruta, "\", nombre)
        Dim lector As StreamReader = My.Computer.FileSystem.OpenTextFileReader(rutaCompleta)

        Dim contenido As String = lector.ReadToEnd()
        lector.Close()
        Return contenido
    End Function
    Sub Main()
        Dim contenido As String = leerFichero("C:\Users\usuario\Desktop", "prueba.txt")
        Console.WriteLine(contenido)
        Console.ReadLine()
    End Sub

End Module

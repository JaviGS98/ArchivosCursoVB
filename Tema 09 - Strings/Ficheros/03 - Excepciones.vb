Option Strict On
Imports System.IO
Module Module1

    Sub Main()
        Dim ruta As String = "C:\Usrs\usuario\Desktop\prueba.txt"
        Dim lector As StreamReader
        Try
            lector = My.Computer.FileSystem.OpenTextFileReader(ruta)
        Catch ex As ArgumentException
            Console.WriteLine("Nombre de archivo no válido")
        Catch ex As IOException
            Console.WriteLine("Fichero en uso por otro proceso.")
        Catch ex As FileNotFoundException
            Console.WriteLine("Fichero no encontrado")
        Catch ex As Exception
            Console.WriteLine("Algo ha ocurrido no se lo que es")
        Finally
            lector.close()
        End Try




        Console.ReadLine()
    End Sub

End Module

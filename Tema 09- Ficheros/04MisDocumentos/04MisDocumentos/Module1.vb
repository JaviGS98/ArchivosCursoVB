Option Strict On
Imports System.IO
Module Module1

    Sub Main()
        Dim misDocumentos As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        Dim ruta As String = Path.Combine(misDocumentos, "prueba.txt")

        Dim escritor As StreamWriter
        Try
            escritor = My.Computer.FileSystem.OpenTextFileWriter(ruta, True)
            escritor.WriteLine("Que pasa tio!!")
        Catch ex As FileNotFoundException
            Console.WriteLine(ex.Message)
        Finally
            escritor.Close()
        End Try
        Console.ReadLine()
    End Sub

End Module

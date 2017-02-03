Option Strict On
Imports System.IO
Module Module1

    Sub Main()
        Dim ruta1 As String = "C:\Users\usuario\Desktop\prueba.txt"
        Dim ruta2 As String = "C:\Users\usuario\Desktop\fich1.txt"
        Dim rutaFinal As String = String.Concat("C:\Users\usuario\Desktop\", "prueba", "_", "fich1", ".txt")

        'File.Create(rutaFinal)
        'Para copiar el contenido de un fichero en otro
        'tenemos dos posibilidades. Ambas crean el fichero destino

        FileSystem.FileCopy(ruta2, rutaFinal)
        '  File.Copy(ruta1, rutaFinal)

        'Como tenemos que combinar dos contenidos

        Dim lector1 As StreamReader = My.Computer.FileSystem.OpenTextFileReader(ruta1)
        Dim contenido1 As String = lector1.ReadToEnd()
        lector1.Close()
        lector1 = My.Computer.FileSystem.OpenTextFileReader(ruta2)
        Dim contenido2 As String = lector1.ReadToEnd()
        lector1.Close()

        Dim combinado As String = String.Concat(contenido1, contenido2)
        Dim escritor As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(rutaFinal, False)

        escritor.WriteLine(combinado)
        escritor.Close()

        Console.WriteLine()
        Console.ReadLine()





    End Sub

End Module

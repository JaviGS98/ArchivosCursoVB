Option Strict On
Imports System.IO

Module Module1

    Sub Main()
        Dim escritor As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\usuario\Desktop\prueba.txt", True)

        escritor.WriteLine("Añadimos esto al fichero" & vbCr)
        escritor.Close()
        'Leeremos el texto del fichero para comprobarlo

        Dim lector As StreamReader = My.Computer.FileSystem.OpenTextFileReader("C:\Users\usuario\Desktop\prueba.txt")
        Dim contenido As String = lector.ReadToEnd()

        Console.WriteLine(contenido)
        Console.ReadLine()

        'Utilizando WriteAllText

        My.Computer.FileSystem.WriteAllText("C:\Users\usuario\Desktop\prueba.txt", "Nuevo Texto con WriteAllText", True)


    End Sub

End Module

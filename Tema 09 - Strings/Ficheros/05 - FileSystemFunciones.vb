Option Strict On
Imports System.IO
Module Module1

    Sub Main()
        Dim ruta As String = My.Computer.FileSystem.SpecialDirectories.Desktop
        Dim archivos() As String = My.Computer.FileSystem.GetFiles(ruta, FileIO.SearchOption.SearchTopLevelOnly, "*spo*").ToArray()

        For Each f As String In archivos
            Console.WriteLine(f)
        Next

        Console.ReadLine()
    End Sub

End Module

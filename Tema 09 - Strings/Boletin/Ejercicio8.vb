Option Strict On
Module Module1

    Function reemplazar(ByVal cadena As String) As String

        cadena = cadena.Replace(" "c, "*"c)

        Return cadena

    End Function

    Sub Main()
        Dim nombre As String = "Juan Martinez Villanueva"

        Dim nombreSinEspacios As String = reemplazar(nombre)

        Console.WriteLine(nombreSinEspacios)

        Console.ReadLine()

        Dim frase As String = "ALejandro Alonso ya lo entendió"

        frase = frase.Replace(" "c, "*"c)
        frase = String.Concat(frase, " Por fin!!!!!")

        Console.WriteLine(frase)

        Console.ReadLine()

    End Sub

End Module

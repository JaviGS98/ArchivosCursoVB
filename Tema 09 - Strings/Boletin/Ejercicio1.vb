Option Strict On
Module Module1

    Function contarOcurrencias(ByRef frase As String, ByVal car As Char) As Integer
        Dim contador As Integer = 0
        For i As Integer = 0 To frase.Length - 1 Step 1
            If frase(i) = car Then
                contador += 1
            End If
        Next
        Return contador
    End Function

    Sub Main()
        Dim frase As String = "Ayer disfrutamos en el curso de Java Si o Que?"
        Dim caracter As Char
        Console.WriteLine("Introduzca un caracter: ")
        caracter = Convert.ToChar(Console.ReadLine())

        Dim ocurrencias As Integer = contarOcurrencias(frase, caracter)

        Console.WriteLine("El caracter " & caracter & " aparece " & ocurrencias & " veces.")

        Console.ReadLine()














    End Sub

End Module

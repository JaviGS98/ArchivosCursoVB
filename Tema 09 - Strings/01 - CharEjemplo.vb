Option Strict On
Module Module1

    Sub Main()
        Dim caracter As Char = "&"c

        If Char.IsNumber(caracter) Then
            Console.WriteLine("Es un número")
        ElseIf Char.IsLetter(caracter) Then

            Console.WriteLine("Es una letra")
        Else
            Console.WriteLine("No es ni un número ni una letra")
        End If

        'Convertir en mayúscula
        Dim letra As Char = "o"c

        If Char.IsLower(letra) Then
            letra = Char.ToUpper(letra)
        End If

        Console.WriteLine(letra)

        Console.ReadLine()
    End Sub

End Module

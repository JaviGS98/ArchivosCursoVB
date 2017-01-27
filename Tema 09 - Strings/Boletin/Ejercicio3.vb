Option Strict On
Module Module1

    Sub Main()
        Dim frase As String = "El Barcelona gano a la Real Sociedad, buen rival para semifinales."
        'Trocear la frase en palabras
        Dim palabritas() As String = frase.Split(" "c)

        'Bucle para recorrer palabritas

        For Each palabra As String In palabritas

            'If palabra.StartsWith("b") Or palabra.StartsWith("B") Then

            'End If
            If palabra(0) = "b"c Or palabra(0) = "B"c Then
                Console.WriteLine(palabra)
            End If
        Next

        'For i As Integer = 0 To palabritas.Length - 1 Step 1
        '    If palabritas(i)(0) = "b"c Then

        '    End If
        'Next




        Console.ReadLine()

    End Sub

End Module

Option Strict On
Module Module1

    Sub Main()
        Dim frase As String = "Probando la clase String que locura"
        Dim caracterPosicionCero As Char = frase(0)

        'Encontrar las posiciones del caracter a:
        Console.WriteLine("La letra a está en : ")
        For i As Integer = 0 To frase.Length - 1 Step 1
            If frase(i) = "a"c Then
                Console.WriteLine("Posición: " & i)
            End If
        Next

        'Encontrar la posición del primer espacio
        Dim pos As Integer = frase.IndexOf(" "c)

        'Obtener string desde el último espacio hasta el final
        Dim ultimaPosicion As Integer = frase.LastIndexOf(" "c)
        Dim palabra As String = frase.Substring(ultimaPosicion + 1)
        Console.WriteLine(palabra)

        'Cuantas palabras empiezna por l
        Dim palabras() As String = frase.Split(" "c)
        Dim contador As Integer = 0
        For Each p As String In palabras
            If p.StartsWith("l") Then
                contador += 1
            End If
        Next


        Console.ReadLine()
    End Sub

End Module

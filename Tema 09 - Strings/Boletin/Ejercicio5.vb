Option Strict On
Module Module1

    Function contarAbas(ByRef frase As String) As Integer
        Dim contador As Integer
        Dim palabritas() As String = frase.Split(" "c)

        'For Each p As String In palabritas
        '    If p.Contains("aba") Then
        '        contador += 1
        '    End If
        'Next

        For i As Integer = 0 To palabritas.Length - 1 Step 1
            If palabritas(i).Contains("aba") Or palabritas(i).Contains("Aba") Then
                contador += 1
            End If
        Next
        Return contador
    End Function
    Sub Main()
        Dim frase As String = "El Celta jugaba de Maravilla y ganaba muchos partidos"
        Dim numeroPalabrasContienenAba As Integer = contarAbas(frase)

        Console.WriteLine(numeroPalabrasContienenAba)
        Console.ReadLine()
    End Sub

End Module

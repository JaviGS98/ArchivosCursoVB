Module Module1
    Function contarDivisores(ByVal n As Integer) As Integer
        Dim contador As Integer = 0

        For i As Integer = 1 To n Step 1
            If n Mod i = 0 Then
                contador += 1
            End If
        Next
        Return contador
    End Function

    Function isPrimo(ByVal n As Integer) As Boolean
        Dim divisores As Integer = contarDivisores(n)
        If divisores = 2 Then
            Return True
        Else
            Return False
        End If
    End Function

    Sub Main()
        Dim numero As Integer = 19456
        '   Dim divisores As Integer = contarDivisores(numero)

        '  Console.WriteLine(numero & " tiene " & contarDivisores(numero))

        If isPrimo(numero) = True Then
            Console.WriteLine("Numero primo")
        Else
            Console.WriteLine("No primo")
        End If
        Console.ReadLine()

    End Sub

End Module

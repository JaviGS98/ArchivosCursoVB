Option Strict On
Module Module1

    Sub intercambiar(ByRef x As Integer, ByRef y As Integer)
        Dim z As Integer = x
        x = y
        y = z
    End Sub

    Function sumar10(ByVal x As Integer) As Integer
        Return x + 10
    End Function

    Sub sumar10Referencia(ByRef x As Integer)
        x = x + 10
    End Sub


    Sub Main()
        Dim n1 As Integer = 5
        Dim n2 As Integer = 3

        intercambiar(n1, n2)

        Console.WriteLine("n1 = " & n1)
        Console.WriteLine("n2 = " & n2)


        Dim numero As Integer = 1
        numero = sumar10(numero)

        sumar10Referencia(numero)






        Console.ReadLine()

    End Sub

End Module

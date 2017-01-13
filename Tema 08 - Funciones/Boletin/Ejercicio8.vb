Option Strict On
Module Module1
    Sub sumaDivisores(ByVal n As Integer, ByRef suma As Integer)
        suma = 0
        For i As Integer = 1 To n Step 1
            If n Mod i = 0 Then
                suma = suma + i
            End If
        Next
    End Sub

    Sub Main()
        Dim n As Integer = 110
        Dim sum As Integer

        sumaDivisores(n, sum)
        Console.WriteLine("La suma de los divisores es : " & sum)

        Console.ReadLine()
    End Sub

End Module

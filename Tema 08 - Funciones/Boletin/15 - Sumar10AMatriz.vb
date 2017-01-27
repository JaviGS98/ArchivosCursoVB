Module Module1
    Sub sumar10(ByRef m() As Integer)
        For i As Integer = 0 To m.Length - 1 Step 1
            m(i) = m(i) + 10

        Next
    End Sub
    Sub escribirMatrizPorConsola(ByRef m() As Integer)
        For Each n As Integer In m
            Console.Write(n & " ")
        Next
    End Sub
    Sub Main()

        Dim matriz() As Integer = {5, 4, 3, 1}
        sumar10(matriz)

        escribirMatrizPorConsola(matriz)
        Console.ReadLine()
    End Sub

End Module
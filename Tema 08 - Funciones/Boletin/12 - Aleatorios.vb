Module Module1
    Sub llenarMatriz(ByRef m() As Integer)

        Dim aleatorio As Random = New Random()

        For i As Integer = 0 To m.Length - 1 Step 1
            m(i) = aleatorio.Next(20)
        Next


    End Sub

    Sub mostrarPorConsola(ByRef m() As Integer)
        For Each numero As Integer In m
            Console.Write(numero & " ")
        Next
    End Sub
    Sub Main()
        Dim matriz(2999) As Integer

        llenarMatriz(matriz)

        mostrarPorConsola(matriz)

        Console.ReadLine()



    End Sub

End Module

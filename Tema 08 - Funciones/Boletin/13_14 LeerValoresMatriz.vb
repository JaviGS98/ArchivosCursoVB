Option Strict On
Module Module1
    Sub guardarDatosMatriz(ByRef m() As String)

        For i As Integer = 0 To m.Length - 1 Step 1
            Console.WriteLine("Introduzca valor posición: " & i)
            m(i) = Console.ReadLine()
        Next

    End Sub

    Sub mostrarMatriz(ByRef m() As String)

        For Each elemento As String In m
            Console.WriteLine(elemento)
        Next

        'For i As Integer = 0 To m.Length - 1 Step 1
        '    Console.WriteLine(m(i))
        'Next

    End Sub
    Sub Main()
        Dim matriz(4) As String

        guardarDatosMatriz(matriz)
        mostrarMatriz(matriz)

        Dim m2() As String = {"we", "qr", "qtt"}
        mostrarMatriz(m2)
        Console.ReadLine()

    End Sub

End Module

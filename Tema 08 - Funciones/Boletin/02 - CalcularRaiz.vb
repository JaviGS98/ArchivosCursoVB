Module Module1
    Function calcularRaiz(ByVal numero As Integer) As Double

        If numero > 0 Then
            Return Math.sqrt(numero)
        Else
            Return 0
        End If
    End Function

    Sub calcularRaiz2(ByVal n As Integer, ByRef r As Double)

        If n > 0 Then
            r = Math.sqrt(n)
        Else
            r = 0
        End If
    End Sub

    Function getPosCero(ByRef m() As Integer) As Integer
        Return m(0)
    End Function

    Sub sumaMatriz(ByRef m() As Integer, ByRef suma As Integer)
        For i As Integer = 0 To m.Length - 1 Step 1
            suma = suma + m(i)
        Next
    End Sub



    Sub Main()
        Dim n As Integer = 13

        Dim raiz As Double = calcularRaiz(n)
        Dim raiz2 As Double

        calcularRaiz2(n, raiz2)

        Dim matriz() As Integer = {5, 3, 2, 9}
        Console.WriteLine(getPosCero(matriz))

        Dim s As Integer

        sumaMatriz(matriz, s)
        Console.WriteLine("La suma de la matriz es: " & s)

        Console.ReadLine()
    End Sub

End Module

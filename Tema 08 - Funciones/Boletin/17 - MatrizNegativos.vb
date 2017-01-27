Module Module1
    Function contarNumerosNegativos(ByRef m() As Integer) As Integer
        Dim c As Integer = 0
        For Each n As Integer In m
            If n < 0 Then
                c += 1
            End If
        Next

        Return c
    End Function
    Function getNumerosNegativos(ByRef m() As Integer) As Integer()
        'Necesito saber cuantos números negativos hay para crear 
        'una matriz del mismo tamaño
        'Contar números negativos
        Dim contadorNegativos As Integer = contarNumerosNegativos(m)
        Dim numerosNegativos(contadorNegativos - 1) As Integer
        Dim j As Integer = 0
        'Busco negativos y los guardo en la matriz numerosNegativos
        For i As Integer = 0 To m.Length - 1 Step 1
            If m(i) < 0 Then
                numerosNegativos(j) = m(i)
                j += 1
            End If
        Next

        Return numerosNegativos
    End Function


    Sub Main()

        Dim matriz() As Integer = {-5, 4, -3, 1}
        Dim negativos() As Integer = getNumerosNegativos(matriz)

        For Each n As Integer In negativos
            Console.WriteLine(n)
        Next
        Console.ReadLine()
    End Sub

End Module
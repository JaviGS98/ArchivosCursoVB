Option Strict On
Module Module1
    Function sumar(ByVal num1 As Integer, ByVal num2 As Integer) As Integer
        Dim resultado As Integer = num1 + num2
        Return resultado
    End Function

    Function sumar3(ByVal n1 As Integer, ByVal n2 As Integer, ByVal n3 As Integer) As Integer
        Return n1 + n2 + n3
    End Function

    Function calcularMayor(ByVal n1 As Integer, ByVal n2 As Integer) As Integer
        If n1 > n2 Then
            Return n1
        Else
            Return n2
        End If
    End Function

    Function sumarPro(ParamArray ByVal n1() As Integer) As Integer
        Dim s As Integer
        For Each n As Integer In n1
            s = s + n
        Next

        Return s
    End Function
    Function calcularMedia(ByVal matriz() As Integer) As Double
        Dim suma As Integer = 0
        For i As Integer = 0 To matriz.Length - 1 Step 1
            suma += matriz(i)
        Next
        Dim media As Double = suma / matriz.Length
        Return media
    End Function
    Sub Main()
        Dim x As Integer = 10
        Dim y As Integer = 1

        'Llamada a la funcion sumar
        Dim s As Integer = sumar(x, y)
        Console.WriteLine("Sumar 100 y 500 = " & sumar3(100, 500, 6))
        Dim array() As Integer = {3, 4, 5, 6, 5, 4, 3, 2}

        Dim m As Double = calcularMedia(array)

        Console.WriteLine("El mayor de x e y es : " & calcularMayor(x, y))






    End Sub


End Module

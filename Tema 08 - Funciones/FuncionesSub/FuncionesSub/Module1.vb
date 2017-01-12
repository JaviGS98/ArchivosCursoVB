Option Strict On
Module Module1

    Sub calcularSuma(ByVal x As Integer, ByVal y As Integer, ByRef suma As Integer)

        suma = x + y

    End Sub

    Sub saludar(ByVal nombre As String)
        Console.WriteLine("Hola " & nombre)
    End Sub

    Function devuelveSaludo(ByVal nombre As String) As String
        Return "Hola " + nombre
    End Function

    Public Sub factorial(ByVal num As Integer, ByRef fact As Long)
        If num = 0 Then
            fact = 1
        Else
            fact = 1
            While num > 0
                fact = fact * num
                num = num - 1
            End While
        End If

    End Sub

    Sub Main()
        Dim num1 As Integer = 2
        Dim num2 As Integer = 13
        Dim s As Integer
        calcularSuma(num1, num2, s)
        saludar("Alejandro")
        Console.WriteLine(devuelveSaludo("Brais"))
        Console.WriteLine(s)
        Console.ReadLine()

        Console.WriteLine("Hola")
        Dim n As String = Console.ReadLine()

        Dim f As Long
        Dim numero As Integer = 5
        factorial(numero, f)
        Console.WriteLine("El factorial de 5 es : " & f)
        f = 0
        factorial(20, f)
        Console.WriteLine("El factorial de 20 es : " & f)
        Console.ReadLine()
       End Sub

End Module

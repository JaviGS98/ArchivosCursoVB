Option Strict On
Module Module1
    Function sumar10(ByVal x As Integer) As Integer
        x = x + 10
        Return x
    End Function

    Sub sumar10Referencia(ByRef x As Integer)
        x = x + 10
    End Sub

    Sub modificArray(ByVal m() As Integer)
        m(0) = 0
        m(m.Length - 1) = 0
    End Sub
    Sub Main()
        Dim numero As Integer = 20

        Console.WriteLine("Muestro el resultado de la funcion sumar10:")

        Console.WriteLine(sumar10(numero))
        Console.WriteLine("Muestro el valor de la variable numero:")
        Console.WriteLine(numero)

        'Si queremos modificar la variable original
        numero = 1
        sumar10Referencia(numero)
        Console.WriteLine(numero)

        Dim prueba() As Integer = {4, 3, 2, 1, 7}
        modificArray(prueba)
        Console.WriteLine("Matriz modificada")
        For Each m As Integer In prueba
            Console.WriteLine(m)
        Next





        Console.ReadLine()
    End Sub

End Module

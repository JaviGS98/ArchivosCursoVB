Option Strict On
Module Module1
    Function buscarNumero(ByVal m() As Integer, ByVal numero As Integer) As Integer
        Dim posicion As Integer = -1

        For i As Integer = 0 To m.Length - 1 Step 1
            If m(i) = numero Then
                posicion = i
                Exit For
            End If
        Next
        Return posicion
    End Function
    Sub Main()
        Dim matriz() As Integer = {9, 3, 4, 5, 2, 1, 4, 0, 8, 3, 2, 1, 5, 6, 7}
        Dim numeroABuscar As Integer = 4
        Dim posicion As Integer = buscarNumero(matriz, numeroABuscar)

        If posicion = -1 Then
            Console.WriteLine("Numero no encontrado")
        Else
            Console.WriteLine("Está en la posición: " & posicion)
        End If

        Console.ReadLine()

    End Sub

End Module

Option Strict On
Module Module1
    Sub eliminar(ByRef matriz() As String, ByRef cadena As String)

        For i As Integer = 0 To matriz.Length - 1 Step 1
            If matriz(i) = cadena Then
                matriz(i) = Nothing
                'Exit For
            End If
        Next
    End Sub
    Sub Main()
        Dim matriz() As String = {"1234", "6754", "1234", "3456"}

        eliminar(matriz, "1234")

        For Each cadena As String In matriz
            If cadena Is Nothing Then
                Console.WriteLine("VACIO")
            Else
                Console.WriteLine(cadena)
            End If
        Next

        Console.ReadLine()
    End Sub

End Module

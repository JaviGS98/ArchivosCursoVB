Option Strict On
Module Module1
    Function contarPosicionesNoVacias(ByRef m() As String) As Integer
        Dim contador As Integer

        For i As Integer = 0 To m.Length - 1 Step 1
            If Not m(i) Is Nothing Then
                contador = contador + 1
            End If
        Next

        Return contador
    End Function
    Sub Main()
        Dim matriz() As String = {"Pepe", "Juan"}

        Console.WriteLine("Strings guardados : " & contarPosicionesNoVacias(matriz))

        Console.ReadLine()
    End Sub

End Module

Option Strict On
Module Module1

    Function verificarCodigo(ByVal codigo As String) As Boolean

        Dim correcto As Boolean = False

        If codigo.Length = 4 Then
            If Char.IsLetter(codigo(0)) And Char.IsLetter(codigo(1)) And Char.IsDigit(codigo(2)) And Char.IsDigit(codigo(3)) Then
                correcto = True
            End If
        End If

        Return correcto
    End Function

    Sub Main()

        Dim c As String = "W4i4"

        If verificarCodigo(c) Then
            Console.WriteLine("Correctísimoooo")
        Else
            Console.WriteLine("No correcto.")
        End If
        Console.ReadLine()

    End Sub

End Module

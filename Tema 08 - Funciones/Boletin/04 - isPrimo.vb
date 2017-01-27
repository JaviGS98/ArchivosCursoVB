Module Module1
    Function isPrimo(ByVal n As Integer) As Boolean
        Dim contador As Integer = 0

        For i As Integer = 2 To n - 1 Step 1
            If n Mod i = 0 Then
                contador += 1
                Exit For
            End If
        Next

        Dim primo As Boolean = False

        If contador = 0 Then
            primo = True
        End If

        Return primo
    End Function

    Sub Main()
        Dim n As Integer = 378654

        If isPrimo(n) Then
            Console.WriteLine("Primo")
        Else
            Console.WriteLine("No primo")
        End If
    End Sub

End Module

Module Module1
    Function contarDivisores(ByVal n As Integer) As Integer
        Dim contador As Integer = 0

        For i As Integer = 1 To n Step 1
            If n Mod i = 0 Then
                contador += 1
            End If
        Next
        Return contador
    End Function
    Sub Main()

    End Sub

End Module

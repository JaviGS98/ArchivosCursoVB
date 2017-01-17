Module Module1
    Function buscarString(ByRef n() As String, ByRef cadenan As String) As Boolean
        Dim encontrado As Boolean

        For i As Integer = 0 To n.Length - 1 Step 1
            If n(i) = cadenan Then
                encontrado = True
                Exit For
            End If
        Next
        Return encontrado
    End Function
    Sub Main()
        Dim matriz() As String = {"PEpe", "Juan", "Zoel"}

        If buscarString(matriz, "Zoel") Then
            Console.WriteLine("Zoel está en la matriz")
        Else
            Console.WriteLine("No se ha encontrado")
        End If

    End Sub

End Module

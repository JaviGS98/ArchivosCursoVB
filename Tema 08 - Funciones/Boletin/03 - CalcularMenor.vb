Module Module1
    Function menor(ByVal n1 As Integer, ByVal n2 As Integer) As Integer

        Dim min As Integer

        If n1 < n2 Then
            min = n1
        Else
            min = n2
        End If
        Return min
    End Function

    Function menor(ByVal n1 As Double, ByVal n2 As Double) As Double

        Dim min As Dou

        If n1 < n2 Then
            min = n1
        Else
            min = n2
        End If
        Return min
    End Function

    Function menor(ByVal n1 As Long, ByVal n2 As Long) As Long

        Dim min As Long

        If n1 < n2 Then
            min = n1
        Else
            min = n2
        End If
        Return min
    End Function

    Sub Main()
        Dim numero1 As Integer = -5
        Dim numero2 As Integer = 3

        Dim minor As Integer = menor(numero1, numero2)

        Console.ReadLine()
    End Sub

End Module

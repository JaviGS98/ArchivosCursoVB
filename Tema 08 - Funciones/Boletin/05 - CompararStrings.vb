Module Module1
    Function comprobarStrings(ByRef s1 As String, ByRef s2 As String) As Boolean

        If s1 = s2 Then
            Return True
        Else
            Return False
        End If
    End Function


    Sub Main()
        Dim passWord1 As String = "qwoqwq"
        Dim passWord2 As String = "dasdf"

        If comprobarStrings(passWord1, passWord2) Then
            Console.WriteLine("Las contraseñas coinciden")
        Else
            Console.WriteLine("Las contraseñas no coinciden")
        End If

        Console.ReadLine()
    End Sub

End Module

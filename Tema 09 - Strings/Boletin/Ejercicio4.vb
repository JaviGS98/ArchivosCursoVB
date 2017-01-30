Module Module1
    Function comprobarArroba(ByVal cadena As String) As Boolean

        'If cadena.Contains("@") Then
        '    Return True
        'Else
        '    Return False

        'End If

        Dim arroba As Boolean = False

        If cadena.IndexOf("@") > -1 Then
            arroba = True
        End If

        Return arroba
    End Function
    Sub Main()
        Dim email As String = "pepe@ciclosmontecastelo.com"

        If comprobarArroba(email) Then
            Console.WriteLine("Tiene arroba")
        Else
            Console.WriteLine("No tiene arroba")
        End If

    End Sub

End Module

Option Strict On
Module Module1

    Sub Main()
        Dim cadena1 As String = "Hola"
        Dim cadena2 As String = "adios"

        ' Dim n As Integer = String.Compare(cadena1, "adios")
        'Ejemplo compare
        If String.Compare(cadena1, cadena2) = 0 Then
            Console.WriteLine("Iguales")
        ElseIf String.Compare(cadena1, cadena2) < 0 Then
            Console.WriteLine(cadena1 & " " & cadena2)
        Else
            Console.WriteLine(cadena2 & " " & cadena1)
        End If

        Console.ReadLine()


        'Ejemplo concat

        Dim cadena3 As String = String.Concat(cadena1, " ", cadena2)

        Console.WriteLine(cadena3)

        Console.ReadLine()


        Dim frase As String = "En un lugar de la Mancha"

        'indexOf: Devuelve la posicion de un caracter
        Dim posicionU As Integer = frase.IndexOf("u"c)
        'lastIndexOf: Devuelve la última aparición
        Dim ultimaPosU As Integer = frase.LastIndexOf("u")

        Dim posicionZ As Integer = frase.IndexOf("z")

        'Contains

        If frase.Contains("lugar") Then
            Console.Write("Aparece lugar")
        End If

        'startsWidth endsWith

        If frase.StartsWith("Hola") Then

        End If

        'Substring
        Console.WriteLine()
        Dim subCadena As String = "Hala Celta".Substring(5)
        Dim subCadena2 As String = "Hala Celta".Substring(5, 2)
        Console.WriteLine(subCadena2)


        'Ejemplo práctica  para Anxo C.

        Dim correo As String = "anxocasanova@ciclosmontecastelo.com"
        Dim posArroba As Integer = correo.IndexOf("@")
        Dim dominio As String = correo.Substring(posArroba + 1, 18)


        Console.WriteLine(dominio)


        'split : Devuelve matriz de strings
        Dim registros As String = "Pedro Gutierrez*34567843E*Calle Doctor Paz Pardo 84"
        Dim palabras() As String = registros.Split("*"c)

        'For i As Integer = 0 To palabras.Length - 1 Step 1
        '    If palabras(i).Contains("Calle") Then

        '    End If
        'Next
        For Each p As String In palabras
            If p.Contains("Calle") Then
                Console.WriteLine(p)
            End If
        Next
        Console.ReadLine()







        Console.ReadLine()


    End Sub

End Module

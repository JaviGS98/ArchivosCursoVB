Option Strict On
Module Module1

    Sub Main()
        Dim letras() As Char = {"T"c, "R"c, "W"c, "A"c, "G"c, "M"c, "Y"c, "F"c, "P"c, "D"c, "X"c, "B"c, "N"c, "J"c}
        Dim dni As String = "361g2523Q"

        'Opcional: Comprobar que hay 9 caracteres
        If dni.Length <> 9 Then
            Console.WriteLine("Error longitud DNI")
        Else
            'Obtener string con los digitos
            Dim digitos As String = dni.Substring(0, 8)
            Dim dniErroneo As Boolean = False
            For i As Integer = 0 To digitos.Length - 1 Step 1
                If Char.IsLetter(digitos(i)) Then
                    dniErroneo = True
                    Exit For
                End If
            Next

            If Not dniErroneo Then
                'Pasarlo a integer
                Dim numeroDNI As Integer = Convert.ToInt32(digitos)

                'dividirlo entre 23

                Dim resto As Integer = numeroDNI Mod 23

                'Comprobar letra
                If Char.IsLetter(dni(8)) Then
                    Dim letra As String = dni(8)
                    If letra = letras(resto) Then
                        Console.WriteLine("DNI Ok!")
                    Else
                        Console.WriteLine("Error letra no coincide")
                    End If
                Else
                    Console.WriteLine("Error : No es letraa!!")
                End If
            Else
                Console.WriteLine("Error: Letra en el númreo del DNI")
            End If


        End If

        Console.ReadLine()



    End Sub

End Module

Option Strict On

Module Module1
    Function guardarRegistro(ByRef m() As String, ByVal s As String) As Boolean
        Dim guardado As Boolean = False
        For i As Integer = 0 To m.Length - 1 Step 1
            If m(i) Is Nothing Then
                m(i) = s
                guardado = True

                Exit For
            End If
        Next

        'Warning!!! Esto es un poco difícil, abstenerse vagos desinteresados.
        If guardado = False Then
            duplicar(m)
            'Recursividad
            'guardarRegistro(m, s)
            For i As Integer = 0 To m.Length - 1 Step 1
                If m(i) Is Nothing Then
                    m(i) = s
                    guardado = True
                    Exit For
                End If
            Next

        End If
        Return guardado
    End Function

    Sub duplicar(ByRef m() As String)
        Dim copia(m.Length * 2 - 1) As String
        'Volcar los valores de la original a la copia

        For i As Integer = 0 To m.Length - 1 Step 1
            copia(i) = m(i)
        Next

        'Igualar referencias

        m = copia
    End Sub

    Sub Main()
        Dim usuarios() As String = {"Pepe", "Juan"}
        Dim continuar As Char
        'Dar de alta usuario
        Do


            Console.WriteLine("Introduzca sus datos:")
            Dim usuario As String = Console.ReadLine()

            If guardarRegistro(usuarios, usuario) Then
                Console.WriteLine("Usuario creado con éxito.")
            Else
                Console.WriteLine("No hay espacioooooooo")
            End If



            Console.WriteLine("Desea introducir un nuevo usuario: s/n")
            continuar = Convert.ToChar(Console.ReadLine())
        Loop While continuar = "s"

        Console.WriteLine("Usuarios registrados")

        For Each usuario As String In usuarios
            Console.WriteLine(usuario)
        Next


        'Prueba duplicar tamaño

        Dim prueba() As String = {"a", "b", "c"}
        Console.WriteLine(prueba.Length)

        ReDim Preserve prueba(10)

        'duplicar(prueba)

        For Each letra As String In prueba
            If Not letra Is Nothing Then
                Console.WriteLine(letra)
            End If
        Next
        'Console.WriteLine(prueba.Length)

        prueba(3) = "w"

        Console.ReadLine()

    End Sub

End Module

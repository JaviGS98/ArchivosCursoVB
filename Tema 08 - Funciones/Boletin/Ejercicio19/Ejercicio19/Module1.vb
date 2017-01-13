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
        Return guardado
    End Function
    Sub Main()
        Dim usuarios(2) As String
        Dim continuar As Char
        'Dar de alta usuario
        Do


            Console.WriteLine("Introduzca sus datos:")
            Dim usuario As String = Console.ReadLine()

            If guardarRegistro(usuarios, usuario) Then
                Console.WriteLine("Usuario creado con éxito.")
            Else
                Console.WriteLine("No hay espacio en el disco duro")

            End If

            Console.WriteLine("Desea introducir un nuevo usuario: s/n")
            continuar = Convert.ToChar(Console.ReadLine())
        Loop While continuar = "s"

        Console.WriteLine("Usuarios registrados")

        For Each usuario As String In usuarios
            Console.WriteLine(usuario)
        Next



        Console.ReadLine()

    End Sub

End Module

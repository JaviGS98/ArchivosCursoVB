Option Strict On
Module Module1

    Sub Main()
        Dim frase As String = "Me encanta la programacion"
        Dim contador As Integer
        'Voy a contar las aes
        Dim letra As Char = "z"c
        Dim encontrado As Boolean = False
        For i As Integer = 0 To frase.Length - 1 Step 1
            If frase(i) = letra Then
                contador += 1
                Console.WriteLine("Posicion: " & i)
                encontrado = True
            End If
        Next

        If encontrado = False Then
            Console.WriteLine("No está la letra buscada")
        End If

        'Funciones String
        'Concatenar strings
        Dim nombre As String = "Pepe"
        Dim apellidos As String = "martinez Sanchez"
        Dim correo As String = "pepe@gmail.com"

        Dim registro As String = String.Concat(nombre, ",", apellidos, ",", correo)
        Console.WriteLine(registro)
        Dim registro2 As String = nombre + " " + apellidos + " " + correo

        'Obtener posicion caracter en String

        Dim posArroba As Integer = registro.LastIndexOf("@")

        If posArroba < 0 Then
            Console.WriteLine("No esta el caracter")
        Else
            Console.WriteLine("Posicion: " & posArroba)
        End If

        'Obtener substring: 
        Dim cadena As String = "17/07/1980"

        Dim anho As String = cadena.Substring(6)
        Dim mes As String = cadena.Substring(3, 2)
        Console.WriteLine(mes)

        Dim ejemplo As String = "Pedro%56,Calle Urzaiz 25 6E*Administrativo"
        Dim posComa As Integer = ejemplo.IndexOf(",")
        Dim posAsterisco As Integer = ejemplo.IndexOf("*")
        Dim caracteres As Integer = posAsterisco - posComa
        Dim direccion As String = ejemplo.Substring(posComa + 1, caracteres - 1)

        Console.WriteLine("DIRECCION : " & direccion)

        'Contar palabras que les pasa algo

        Dim fraseLarga As String = "SergioAl Juan Alejandro Albero"

        Dim palabras() As String = fraseLarga.Split(" "c)

        For i As Integer = 0 To palabras.Length - 1 Step 1
            If palabras(i).Contains("Al") Then
                Console.WriteLine(palabras(i))
            End If

        Next

        'Verificar si un char es letra o numero

        Dim dni As String = "23232323W"
        Dim c As Char = "2"c

        If Char.IsDigit(c) Then

        End If


        If Char.IsLetter(dni(9)) Then

        End If


























        Console.ReadLine()

    End Sub

End Module

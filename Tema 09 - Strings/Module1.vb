Option Strict On
Imports System.IO
Module Module1

    Sub Main()
        Dim lector As StreamReader = My.Computer.FileSystem.OpenTextFileReader("C:\Users\usuario\Desktop\datos.txt")
        Dim registros(12) As String
        Dim i As Integer = 0
        While Not lector.EndOfStream
            If registros(i) Is Nothing Then
                registros(i) = lector.ReadLine()
                i += 1
            End If
        End While
        'Cierro el lector
        lector.Close()
        'Para comprobarlo
        'Registros guardados actualmente en la matriz
        For Each cadena2 As String In registros
            If Not cadena2 Is Nothing Then
                Console.WriteLine(cadena2)
            Else
                Exit For
            End If
        Next


        'Ejercicio 2: Obtener el DNI del primer registro
        Dim primerRegistro As String = registros(0)

        Dim cachitos() As String = primerRegistro.Split("*"c)
        Dim dni As String = cachitos(1)

        'Ejercicio 3: Obtener el correo y el salario del siguiente registro
        Dim registro As String = "Pepe,34567891Q*Calle Urzaiz 45?280#pepe@gmail.com"
        Dim posAlmohadilla As Integer = registro.IndexOf("#"c)
        Dim correo As String = registro.Substring(posAlmohadilla + 1)
        Dim posInterrogante As Integer = registro.IndexOf("?"c)
        Dim salario As Integer = Convert.ToInt32(registro.Substring(posInterrogante + 1, posAlmohadilla - posInterrogante - 1))

        If salario < 1000 Then

        End If
        'Ejercicio 4: Buscar el correo de un registro a partir del dNI
        Dim dniABuscar As String = "9191991O"
        Dim encontrado As Boolean = False
        Console.WriteLine("Ejercicio 4: Obtener correo a partir de DNI")
        For indice As Integer = 0 To registros.Length - 1 Step 1
            If Not registros(indice) Is Nothing Then
                If registros(indice).Contains(dniABuscar) Then
                    'Obtener el nombre
                    Dim cachitos2() As String = registros(indice).Split("*"c)
                    Console.WriteLine(cachitos2(2))
                    encontrado = True
                    Exit For
                End If
            Else
                Exit For
            End If
        Next

        If Not encontrado Then
            Console.WriteLine("No existe ese registro")
        End If
        Console.ReadLine()

        'Ejercicio 5: Añadir datos al fichero
        Dim nombre As String = "Pepito"
        Dim dni3 As String = "23232323E"
        Dim correo2 As String = "pepito@gmail.com"
        Dim numero As Integer = 30

        Dim registro2 As String = String.Concat(nombre, "*", dni3, "*", correo2, "*", numero.ToString())
        ' Dim registro3 As String = nombre + "*" + dni3 + "*"

        Dim escritor As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\usuario\Desktop\datos.txt", True)
        escritor.WriteLine(registro2)
        escritor.Close()

        Console.WriteLine("Ejercicio 5:")
        Dim lector2 As StreamReader = My.Computer.FileSystem.OpenTextFileReader("C:\Users\usuario\Desktop\datos.txt")

        Console.WriteLine(lector2.ReadToEnd())

        'Ejercicio 6: Validar password
        'Requisito: Debe contener al menos un dígito

        Dim password As String = "erqwerqwer"

        Dim correcto As Boolean

        '  Dim caracteres() As Char = password.ToCharArray()

        For j As Integer = 0 To password.Length - 1 Step 1
            If Char.IsDigit(password(j)) Then
                correcto = True
                Exit For
            End If
        Next

        If correcto Then
            Console.WriteLine("Correcto")
        Else
            Console.WriteLine("No correcto")
        End If
        Console.ReadLine()

        'Ejercicio 7: Cuantas palabras les pasa esto... tienen una z

        Dim cadena As String = "La zarigueya es muy molezta"
        Dim palabras() As String = cadena.Split(" "c)
        Dim contador As Integer = 0
        For Each p As String In palabras
            If p.Contains("z") Then
                contador += 1
            End If
        Next

    End Sub

End Module

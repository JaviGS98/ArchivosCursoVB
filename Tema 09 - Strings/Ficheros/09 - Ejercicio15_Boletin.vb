Option Strict On
Imports System.IO
Module Module1

    Sub Main()
        Dim opcion As Integer
        Dim continuar As Char
        Do
            Console.WriteLine("Escoge una opcion:")
            opcion = Convert.ToInt32(Console.ReadLine())
            Select Case opcion
                Case 1
                    'Acceder al fichero para leer
                    Dim lector As StreamReader = My.Computer.FileSystem.OpenTextFileReader("C:\Users\usuario\Desktop\bol9Ej15.txt")

                    While Not lector.EndOfStream
                        Dim reg As String = lector.ReadLine()
                        Console.WriteLine(reg)
                    End While
                    'Cerrar el lector
                    lector.Close()
                    Console.ReadLine()
                Case 2
                    Dim escritor As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\usuario\Desktop\bol9Ej15.txt", True)
                    Dim dni As String = "23232323T"
                    Dim nombre As String = "Pepe Ortiz"
                    Dim edad As Integer = 30
                    Dim salario As Double = 1900

                    Dim reg As String = dni + "*" + nombre + "?" + edad.ToString() + "?" + salario.ToString()

                    escritor.WriteLine(reg)
                    escritor.Close()
                Case 3
                    Dim dni As String
                    Console.WriteLine("Introduzca dni a buscar:")
                    dni = Console.ReadLine()

                    Dim lector As StreamReader = My.Computer.FileSystem.OpenTextFileReader("C:\Users\usuario\Desktop\bol9Ej15.txt")
                    Dim encontrado As Boolean
                    While Not lector.EndOfStream
                        Dim reg As String = lector.ReadLine()
                        'Obtengo 9 caracteres del dni
                        Dim dniRegistro As String = reg.Substring(0, 9)
                        'Comparo dni a buscar
                        If dni = dniRegistro Then
                            Console.WriteLine(reg)
                            encontrado = True
                            Exit While
                        End If
                    End While
                    'Cerrar el lector
                    lector.Close()
                    If Not encontrado Then
                        Console.WriteLine("No existe ese usuario")
                        Console.ReadLine()
                    End If
                Case 4
                    Dim lector As StreamReader = My.Computer.FileSystem.OpenTextFileReader("C:\Users\usuario\Desktop\bol9Ej15.txt")

                    While Not lector.EndOfStream
                        Dim reg As String = lector.ReadLine()
                        Dim posUltimoInterrogante As Integer = reg.LastIndexOf("?"c)
                        Dim salario As Double = Convert.ToDouble(reg.Substring(posUltimoInterrogante + 1))

                        If salario > 1000 Then
                            Console.WriteLine(reg)
                        End If
                    End While
                    lector.Close()
                Case 5
                    'Crear matriz con registros fichero
                    Dim matrizRegistros(99) As String
                    'Acceder al fichero y pasar registros a la matriz
                    Dim lector As StreamReader = My.Computer.FileSystem.OpenTextFileReader("C:\Users\usuario\Desktop\bol9Ej15.txt")
                    Dim indice As Integer = 0

                    While Not lector.EndOfStream
                        Dim reg As String = lector.ReadLine()

                        matrizRegistros(indice) = reg
                        indice += 1
                    End While
                    lector.Close()
                    '  Ajustar tamaño de la matriz
                    '  ReDim Preserve matrizRegistros(indice - 1)

                    Dim dni As String
                    Console.WriteLine("Introduzca dni del usuario que quiere eliminar")
                    dni = Console.ReadLine()

                    For i As Integer = 0 To matrizRegistros.Length - 1 Step 1
                        Dim dniLocal As String = matrizRegistros(i).Substring(0, 9)
                        If dni = dniLocal Then
                            matrizRegistros(i) = Nothing
                            Console.WriteLine("Usuario eliminado con éxito")
                            Exit For
                        End If
                    Next
                    'Para nota: Si la matriz fue modificada poniendo una pos a nothing
                    'Necesito reordenarla
                    'Creo una copia de la matrizRegistros
                    Dim copia(matrizRegistros.Length - 1) As String
                    Dim indiceOriginal As Integer = 0
                    Dim indiceCopia As Integer = 0

                    For indiceOriginal = 0 To matrizRegistros.Length - 1 Step 1
                        If Not matrizRegistros(indiceOriginal) Is Nothing Then
                            copia(indiceCopia) = matrizRegistros(indiceOriginal)
                            indiceCopia += 1
                        End If
                    Next

                    matrizRegistros = copia

                    'Volcar registros actuales al fichero sobreescribir
                    Dim escritor As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\usuario\Desktop\bol9Ej15.txt", False)

                    For Each registro As String In matrizRegistros
                        If Not registro Is Nothing Then
                            escritor.WriteLine(registro)
                        Else
                            Exit For
                        End If
                    Next

                    escritor.Close()

            End Select

            Console.WriteLine("Desea continuar: s/n")
            continuar = Convert.ToChar(Console.ReadLine())
        Loop While continuar = "s"c
    End Sub

End Module

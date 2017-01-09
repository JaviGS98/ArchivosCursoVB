Option Strict On
Module Module1
    Function sumar(ByVal num1 As Integer, ByVal num2 As Integer) As Integer
        Dim resultado As Integer = num1 + num2
        Return resultado
    End Function

    Function sumar3(ByVal n1 As Integer, ByVal n2 As Integer, ByVal n3 As Integer) As Integer
        Return n1 + n2 + n3
    End Function

    Function calcularMayor(ByVal n1 As Integer, ByVal n2 As Integer) As Integer
        If n1 > n2 Then
            Return n1
        Else
            Return n2
        End If
    End Function

    Function sumarPro(ParamArray ByVal n1() As Integer) As Integer
        Dim s As Integer
        For Each n As Integer In n1
            s = s + n
        Next

        Return s
    End Function
    Function calcularMedia(ByVal matriz() As Integer) As Double
        Dim suma As Integer = 0
        For i As Integer = 0 To matriz.Length - 1 Step 1
            suma += matriz(i)
        Next
        Dim media As Double = suma / matriz.Length
        Return media
    End Function

    Function comprobarContrasenha(ByVal c1 As String, ByVal c2 As String) As Boolean
        If c1 = c2 Then
            Return True
        Else
            Return False
        End If
    End Function

    Function isPar(ByVal n As Integer) As Boolean
        If n Mod 2 = 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Function lalala() As String
        Return "lalala"
    End Function

    Function calcVolumen(ByVal radio As Double) As Double
        Dim volumen As Double = (4 / 3) * Math.PI * Math.Pow(radio, 3)
        Return volumen
    End Function
    Sub Main()
        'Validar la contraseña
        Dim contra1, contra2 As String

        Console.WriteLine("Introduzca la contraseña")
        contra1 = Console.ReadLine()
        Console.WriteLine("Vuelva a introducir la contraseña")
        contra2 = Console.ReadLine()

        If comprobarContrasenha(contra1, contra2) = True Then
            Console.WriteLine("Son iguales")
        Else
            Console.WriteLine("Ehhhhhhhh donde vaaaaas.")
        End If

        Console.ReadLine()

        'Comprobar función isPar
        Dim numero As Integer = 10

        If isPar(numero) Then
            Console.WriteLine("Par")
        Else
            Console.WriteLine("Impar")
        End If
        Console.ReadLine()

        'Comprobar función calcularVolumen
        Dim radio As Double = 10
        Dim volumen As Double = calcVolumen(radio)

        Console.WriteLine("El volumen de la esfera es " & volumen)
        Console.ReadLine()








    End Sub


End Module

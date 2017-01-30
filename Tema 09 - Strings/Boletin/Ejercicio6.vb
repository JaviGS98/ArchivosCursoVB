Option Strict On

Module Module1

    Sub Main()
        Dim email As String = "pepe@ciclosmontecastelo.com"
        Dim posArroba As Integer = email.IndexOf("@"c)
        Dim posPunto As Integer = email.IndexOf("."c)
        Dim numeroCaracteres As Integer = posPunto - posArroba - 1
        Dim dominio As String = email.Substring(posArroba + 1, numeroCaracteres)
        Console.WriteLine(dominio)
        Console.ReadLine()




    End Sub

End Module

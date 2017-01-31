Option Strict On
Module Module1

    Sub Main()
        Dim registro1 As String = "Pedro Jimenez*14Julio1990?500"
        Dim registro2 As String = "Maria Benitez!900!06Agosto1998"

        'Obtengo posición caracter ?
        Dim posicionInterrogante As Integer = registro1.IndexOf("?"c)

        'Obtengo subCadena desde posicion interrogante hasta el final
        Dim saldoString As String = registro1.Substring(posicionInterrogante + 1)

        Dim saldoInt As Integer = Convert.ToInt32(saldoString)

        If saldoInt < 1000 Then
            Console.WriteLine("Inferior")
        Else
            Console.WriteLine("Superior")
        End If

        Console.ReadLine()

    End Sub

End Module

Option Strict On
Imports System.IO
Module Module1

    Sub Main()
        Dim listaClase As ArrayList = New ArrayList()

        'Añadir valores al arraylist, en este ejemplo Strings
        listaClase.Add("Pedro Martinez")
        listaClase.Add("Maria Alonso")
        listaClase.Add("Juan Martínez")
        listaClase.Add("Saúl Gutiérrez")
        '/******************** ********************************/
        'Recorrer ArrayList
        Console.WriteLine("Alumnos de clase 1GMI:")
        For i As Integer = 0 To listaClase.Count - 1 Step 1
            Console.WriteLine(listaClase.Item(i).ToString())
        Next
        Console.WriteLine()
        '/******************** ********************************/
        Console.WriteLine("Eliminamos a Juan Martínez y volvemos a mostrar:")
        listaClase.Remove("Juan Martínez")

        For Each elemento As String In listaClase
            Console.WriteLine(elemento)
        Next
        Console.WriteLine()
        'Obtener el índice de un objeto
        Console.WriteLine("Probando la función indexOf: ")
        Dim pos As Integer = listaClase.IndexOf("Saúl Gutiérrez")
        Console.WriteLine("Saúl está en la posición: " & pos)
        Console.WriteLine()
        '/******************** ********************************/
        'Ordenando los elementos alfabéticamente:

        listaClase.Sort()
        Console.WriteLine("Los elementos ordenados gracias a la función sort():")
        For Each elemento As String In listaClase
            Console.WriteLine(elemento)
        Next

        '/******************** ********************************/
        'Podemos crear un ArrayList a partir de otro ya creado
        Dim aprobados As ArrayList = New ArrayList(listaClase)
        Console.WriteLine()

        Console.WriteLine("Mostrando los alumnos aprobados: ")
        For Each elemento As String In aprobados
            Console.WriteLine(elemento)
        Next

        Console.ReadLine()
    End Sub

End Module

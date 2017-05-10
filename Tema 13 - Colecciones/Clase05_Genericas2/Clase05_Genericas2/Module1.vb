Option Strict On
Module Module1

    Sub Main()
        Dim lista As List(Of Integer) = New List(Of Integer)()

        llenarColeccion(lista)
        Dim conjuntoDesordenado As HashSet(Of Integer) = New HashSet(Of Integer)()
        llenarColeccion(conjuntoDesordenado)
        Dim conjuntoOrdenado As SortedSet(Of Integer) = New SortedSet(Of Integer)()
        llenarColeccion(conjuntoOrdenado)

        Console.WriteLine("Lista: ")
        mostrarColeccion(lista)


        Console.WriteLine("HashSet: ")
        mostrarColeccion(conjuntoDesordenado)

        Console.WriteLine("SortedSet: ")
        mostrarColeccion(conjuntoOrdenado)

        'DICCIONARIOS GENÉRICOS
        Dim diccionario As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)()
        diccionario.Add("12345678U", 9)
        diccionario.Add("12345667S", 1)

        Dim nota As Integer = diccionario("12345667S")

        'For each
        For Each pareja As KeyValuePair(Of String, Integer) In diccionario
            Console.WriteLine(pareja.Key & " " & pareja.Value)
        Next

        Console.ReadLine()

        Dim diccionarioOrdenado As SortedList(Of String, String) = New SortedList(Of String, String)()

        diccionarioOrdenado.Add("Villar David", "65487654")
        diccionarioOrdenado.Add("Alonso Freitas Anxo", "654543231")

        For Each pareja As KeyValuePair(Of String, String) In diccionarioOrdenado
            Console.WriteLine(pareja.Key & " " & pareja.Value)
        Next
        Console.ReadLine()






        Console.ReadLine()
    End Sub

End Module

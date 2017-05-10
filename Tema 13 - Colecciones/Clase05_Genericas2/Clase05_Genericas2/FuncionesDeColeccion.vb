Module FuncionesDeColeccion
    'Public Sub llenarLista(ByRef l As List(Of Integer))
    '    Dim aleatorio As Random = New Random()

    '    For i As Integer = 0 To 99 Step 1
    '        l.Add(aleatorio.Next(11))
    '    Next
    'End Sub

    'Public Sub llenarHashSet(ByRef conjunto As HashSet(Of Integer))
    '    Dim aleatorio As Random = New Random()

    '    For i As Integer = 0 To 99 Step 1
    '        conjunto.Add(aleatorio.Next(11))
    '    Next
    'End Sub

    'Public Sub llenarSortedSet(ByRef conjunto As SortedSet(Of Integer))
    '    Dim aleatorio As Random = New Random()

    '    For i As Integer = 0 To 99 Step 1
    '        conjunto.Add(aleatorio.Next(11))
    '    Next
    'End Sub

    Public Sub llenarColeccion(coleccion As ICollection(Of Integer))
        Dim aleatorio As Random = New Random()

        For i As Integer = 0 To 99 Step 1
            coleccion.Add(aleatorio.Next(11))
        Next
    End Sub


    'Public Sub mostrarLista(ByRef lista As List(Of Integer))
    '    For Each numero As Integer In lista
    '        Console.Write(numero & " ")
    '    Next
    '    Console.WriteLine()
    'End Sub



    'Public Sub mostrarHashSet(ByRef conjunto As HashSet(Of Integer))
    '    For Each numero As Integer In conjunto
    '        Console.Write(numero & " ")
    '    Next
    '    Console.WriteLine()
    'End Sub

    'Public Sub mostrarSortedSet(ByRef conjunto As SortedSet(Of Integer))
    '    For Each numero As Integer In conjunto
    '        Console.Write(numero & " ")
    '    Next
    '    Console.WriteLine()
    'End Sub

    Public Sub mostrarColeccion(coleccion As ICollection(Of Integer))
        For Each numero As Integer In coleccion
            Console.Write(numero & " ")
        Next
        Console.WriteLine()
    End Sub
End Module
